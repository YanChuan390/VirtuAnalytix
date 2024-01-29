using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Edelweiss.Pattern;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class MaterialModifier
{
	[Token(Token = "0x200010D")]
	public interface Interface
	{
		[Token(Token = "0x600085C")]
		void SetMaterialProp(int nameID, float value);

		[Token(Token = "0x600085D")]
		void SetMaterialProp(int nameID, Vector4 value);

		[Token(Token = "0x600085E")]
		void SetMaterialProp(int nameID, Color value);

		[Token(Token = "0x600085F")]
		void SetMaterialProp(int nameID, Matrix4x4 value);

		[Token(Token = "0x6000860")]
		void SetMaterialProp(int nameID, Texture value);
	}

	[Token(Token = "0x200010E")]
	public delegate void Callback(Interface owner);
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
			[Address(RVA = "0x20F3CB0", Offset = "0x20F3CB0", VA = "0x20F3CB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x20F3E04", Offset = "0x20F3E04", VA = "0x20F3E04")]
		public static bool IsGpuInstancingEnabled(Material material)
		{
			return default(bool);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x20F3E1C", Offset = "0x20F3E1C", VA = "0x20F3E1C")]
		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x20F3E38", Offset = "0x20F3E38", VA = "0x20F3E38")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x20F42DC", Offset = "0x20F42DC", VA = "0x20F42DC")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x20F4438", Offset = "0x20F4438", VA = "0x20F4438")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD1E64", Offset = "0xCD1E64")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD1E64", Offset = "0xCD1E64")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD42AC", Offset = "0xCD42AC")]
		private sealed class <CoUpdateFadeOut>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x170000F7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000868")]
				[Address(RVA = "0x20F961C", Offset = "0x20F961C", VA = "0x20F961C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600086A")]
				[Address(RVA = "0x20F9684", Offset = "0x20F9684", VA = "0x20F9684", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000865")]
			[Address(RVA = "0x20F47F4", Offset = "0x20F47F4", VA = "0x20F47F4")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x20F9588", Offset = "0x20F9588", VA = "0x20F9588", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0x20F958C", Offset = "0x20F958C", VA = "0x20F958C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000869")]
			[Address(RVA = "0x20F9624", Offset = "0x20F9624", VA = "0x20F9624", Slot = "8")]
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

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD448C", Offset = "0xCD448C")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD449C", Offset = "0xCD449C")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD44AC", Offset = "0xCD44AC")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x17000002")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x20F44F4", Offset = "0x20F44F4", VA = "0x20F44F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCAAC", Offset = "0xCDCAAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x20F44FC", Offset = "0x20F44FC", VA = "0x20F44FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCABC", Offset = "0xCDCABC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x20F4504", Offset = "0x20F4504", VA = "0x20F4504")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCACC", Offset = "0xCDCACC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x20F450C", Offset = "0x20F450C", VA = "0x20F450C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCADC", Offset = "0xCDCADC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public Mesh coneMesh
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x20F4514", Offset = "0x20F4514", VA = "0x20F4514")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCAEC", Offset = "0xCDCAEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x20F451C", Offset = "0x20F451C", VA = "0x20F451C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCAFC", Offset = "0xCDCAFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public bool visible
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x20F4524", Offset = "0x20F4524", VA = "0x20F4524")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x20F4540", Offset = "0x20F4540", VA = "0x20F4540")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public int sortingLayerID
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x20F4560", Offset = "0x20F4560", VA = "0x20F4560")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x20F457C", Offset = "0x20F457C", VA = "0x20F457C")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public int sortingOrder
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x20F4598", Offset = "0x20F4598", VA = "0x20F4598")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x20F45B4", Offset = "0x20F45B4", VA = "0x20F45B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x20F45D0", Offset = "0x20F45D0", VA = "0x20F45D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x20F5018", Offset = "0x20F5018", VA = "0x20F5018")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x20F5020", Offset = "0x20F5020", VA = "0x20F5020")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x20F7518", Offset = "0x20F7518", VA = "0x20F7518")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x20F76F8", Offset = "0x20F76F8", VA = "0x20F76F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x20F45E0", Offset = "0x20F45E0", VA = "0x20F45E0")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x20F4784", Offset = "0x20F4784", VA = "0x20F4784")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDCB0C", Offset = "0xCDCB0C")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x20F4820", Offset = "0x20F4820", VA = "0x20F4820")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x20F4964", Offset = "0x20F4964", VA = "0x20F4964")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x20F4CA8", Offset = "0x20F4CA8", VA = "0x20F4CA8")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x20F4D74", Offset = "0x20F4D74", VA = "0x20F4D74")]
		private void Start()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x20F4E34", Offset = "0x20F4E34", VA = "0x20F4E34")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x20F4EDC", Offset = "0x20F4EDC", VA = "0x20F4EDC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x20F50B4", Offset = "0x20F50B4", VA = "0x20F50B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x20F51FC", Offset = "0x20F51FC", VA = "0x20F51FC")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x20F5A04", Offset = "0x20F5A04", VA = "0x20F5A04")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x20F71B4", Offset = "0x20F71B4", VA = "0x20F71B4")]
		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x20F56E0", Offset = "0x20F56E0", VA = "0x20F56E0")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x20F4AF0", Offset = "0x20F4AF0", VA = "0x20F4AF0", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x20F7E80", Offset = "0x20F7E80", VA = "0x20F7E80", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x20F7FA4", Offset = "0x20F7FA4", VA = "0x20F7FA4", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x20F80C8", Offset = "0x20F80C8", VA = "0x20F80C8", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x20F81F4", Offset = "0x20F81F4", VA = "0x20F81F4", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x20F4A2C", Offset = "0x20F4A2C", VA = "0x20F4A2C")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x20F4BE4", Offset = "0x20F4BE4", VA = "0x20F4BE4")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x20F82D0", Offset = "0x20F82D0", VA = "0x20F82D0")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x20F6854", Offset = "0x20F6854", VA = "0x20F6854")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x20F8CA4", Offset = "0x20F8CA4", VA = "0x20F8CA4")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x20F8EF8", Offset = "0x20F8EF8", VA = "0x20F8EF8")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x20F8F00", Offset = "0x20F8F00", VA = "0x20F8F00")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x20F8F80", Offset = "0x20F8F80", VA = "0x20F8F80")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x20F9070", Offset = "0x20F9070", VA = "0x20F9070")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x20F9580", Offset = "0x20F9580", VA = "0x20F9580")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD1ED4", Offset = "0xCD1ED4")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD44BC", Offset = "0xCD44BC")]
		[SerializeField]
		private RenderPipeline _RenderPipeline;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD4508", Offset = "0xCD4508")]
		[SerializeField]
		private RenderingMode _RenderingMode;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float ditheringFactor;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int sharedMeshSides;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD4554", Offset = "0xCD4554")]
		public float globalNoiseScale;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string fadeOutCameraTag;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int noise3DSize;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Texture2D ditheringNoiseTexture;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public FeatureEnabledColorGradient featureEnabledColorGradient;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool featureEnabledDepthBlend;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		public bool featureEnabledNoise3D;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		public bool featureEnabledDynamicOcclusion;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F")]
		public bool featureEnabledMeshSkewing;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool featureEnabledShaderAccuracyHigh;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Material _DummyMaterial;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Shader _BeamShader;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x1700000D")]
		public RenderPipeline renderPipeline
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x20F968C", Offset = "0x20F968C", VA = "0x20F968C")]
			get
			{
				return default(RenderPipeline);
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x20F9694", Offset = "0x20F9694", VA = "0x20F9694")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x20F9700", Offset = "0x20F9700", VA = "0x20F9700")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x20F9708", Offset = "0x20F9708", VA = "0x20F9708")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x20F3DB8", Offset = "0x20F3DB8", VA = "0x20F3DB8")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000010")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x20F98B4", Offset = "0x20F98B4", VA = "0x20F98B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		public bool requiresDoubleSidedMesh
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x20F5CE8", Offset = "0x20F5CE8", VA = "0x20F5CE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		public Shader beamShader
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x20F98D0", Offset = "0x20F98D0", VA = "0x20F98D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x20F48E0", Offset = "0x20F48E0", VA = "0x20F48E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public bool hasRenderPipelineMismatch
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x20F9974", Offset = "0x20F9974", VA = "0x20F9974")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public static Config Instance
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x20F3D58", Offset = "0x20F3D58", VA = "0x20F3D58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x20F9774", Offset = "0x20F9774", VA = "0x20F9774")]
		public void SetRenderingModeAndRefreshShader(RenderingMode mode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x20F9778", Offset = "0x20F9778", VA = "0x20F9778")]
		public bool IsSRPBatcherSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x20F98D8", Offset = "0x20F98D8", VA = "0x20F98D8")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x20F99F0", Offset = "0x20F99F0", VA = "0x20F99F0")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xCDCB70", Offset = "0xCDCB70")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x20F9B68", Offset = "0x20F9B68", VA = "0x20F9B68")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x20F9ADC", Offset = "0x20F9ADC", VA = "0x20F9ADC")]
		private void RefreshGlobalShaderProperties()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x20F9C54", Offset = "0x20F9C54", VA = "0x20F9C54")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x20F9DC8", Offset = "0x20F9DC8", VA = "0x20F9DC8")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x20F9F5C", Offset = "0x20F9F5C", VA = "0x20F9F5C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x20F9F68", Offset = "0x20F9F68", VA = "0x20F9F68")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x20F9F6C", Offset = "0x20F9F6C", VA = "0x20F9F6C")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x20FA0A8", Offset = "0x20FA0A8", VA = "0x20FA0A8")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD1F0C", Offset = "0xCD1F0C")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x4000027")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x20FA1A4", Offset = "0x20FA1A4", VA = "0x20FA1A4")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class Consts
	{
		[Token(Token = "0x4000028")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x4000029")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x400002A")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x400002B")]
		public const string HelpUrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/";

		[Token(Token = "0x400002C")]
		public const string HelpUrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/";

		[Token(Token = "0x400002D")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x400002E")]
		public const string HelpUrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle/";

		[Token(Token = "0x400002F")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x4000032")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x4000033")]
		public const float IntensityDefault = 1f;

		[Token(Token = "0x4000034")]
		public const float IntensityMin = 0f;

		[Token(Token = "0x4000035")]
		public const float IntensityMax = 8f;

		[Token(Token = "0x4000036")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x4000037")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x4000038")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x4000039")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x400003A")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x400003B")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x400003C")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x400003D")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x400003E")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x400003F")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x4000040")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x4000041")]
		public const bool GeomCap = false;

		[Token(Token = "0x4000042")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x4000043")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x4000044")]
		public const float FallOffStart = 0f;

		[Token(Token = "0x4000045")]
		public const float FallOffEnd = 3f;

		[Token(Token = "0x4000046")]
		public const float FallOffDistancesMinThreshold = 0.01f;

		[Token(Token = "0x4000047")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x4000048")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x4000049")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x400004A")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x400004B")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x400004C")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x400004D")]
		public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

		[Token(Token = "0x400004E")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x400004F")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x4000050")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x4000051")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x4000052")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x4000053")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x4000055")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x4000056")]
		public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.Fast;

		[Token(Token = "0x4000057")]
		public const float FadeOutBeginDefault = -150f;

		[Token(Token = "0x4000058")]
		public const float FadeOutEndDefault = -200f;

		[Token(Token = "0x4000059")]
		public const Dimensions DimensionsDefault = Dimensions.Dim3D;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Vector2 TiltDefault;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Vector3 SkewingLocalForwardDirectionDefault;

		[Token(Token = "0x400005C")]
		public const Transform ClippingPlaneTransformDefault = null;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly LayerMask DynOcclusionLayerMaskDefault;

		[Token(Token = "0x400005E")]
		public const float DynOcclusionFadeDistanceToSurfaceDefault = 0.25f;

		[Token(Token = "0x400005F")]
		public const DynamicOcclusionUpdateRate DynamicOcclusionUpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

		[Token(Token = "0x4000060")]
		public const int DynOcclusionWaitFramesCountDefault = 3;

		[Token(Token = "0x4000061")]
		public const Dimensions DynOcclusionRaycastingDimensionsDefault = Dimensions.Dim3D;

		[Token(Token = "0x4000062")]
		public const bool DynOcclusionRaycastingConsiderTriggersDefault = false;

		[Token(Token = "0x4000063")]
		public const float DynOcclusionRaycastingMinOccluderAreaDefault = 0f;

		[Token(Token = "0x4000064")]
		public const float DynOcclusionRaycastingMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x4000065")]
		public const float DynOcclusionRaycastingMinSurfaceRatioMin = 50f;

		[Token(Token = "0x4000066")]
		public const float DynOcclusionRaycastingMinSurfaceRatioMax = 100f;

		[Token(Token = "0x4000067")]
		public const float DynOcclusionRaycastingMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x4000068")]
		public const float DynOcclusionRaycastingMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x4000069")]
		public const float DynOcclusionRaycastingMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x400006A")]
		public const PlaneAlignment DynOcclusionRaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

		[Token(Token = "0x400006B")]
		public const float DynOcclusionRaycastingPlaneOffsetDefault = 0.1f;

		[Token(Token = "0x400006C")]
		public const int DynOcclusionDepthBufferDepthMapResolutionDefault = 32;

		[Token(Token = "0x400006D")]
		public const bool DynOcclusionDepthBufferOcclusionCullingDefault = true;

		[Token(Token = "0x400006E")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x400006F")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x4000070")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x4000071")]
		public const string ConfigFadeOutCameraTagDefault = "MainCamera";

		[Token(Token = "0x4000072")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x4000073")]
		public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

		[Token(Token = "0x4000074")]
		public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.SinglePass;

		[Token(Token = "0x4000075")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x4000076")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x4000077")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x4000078")]
		public const float ConfigDitheringFactor = 0f;

		[Token(Token = "0x4000079")]
		public const bool ConfigFeatureEnabledDefault = true;

		[Token(Token = "0x400007A")]
		public const FeatureEnabledColorGradient ConfigFeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly;

		[Token(Token = "0x17000016")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x20F5520", Offset = "0x20F5520", VA = "0x20F5520")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x2000008")]
	public static class DummyMaterial
	{
	}
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD1F44", Offset = "0xCD1F44")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD1F44", Offset = "0xCD1F44")]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x2000110")]
		protected enum ProcessOcclusionSource
		{
			[Token(Token = "0x400074D")]
			RenderLoop,
			[Token(Token = "0x400074E")]
			OnEnable,
			[Token(Token = "0x400074F")]
			EditorUpdate,
			[Token(Token = "0x4000750")]
			User
		}

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicOcclusionUpdateRate updateRate;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD45C0", Offset = "0xCD45C0")]
		public int waitXFrames;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TransformUtils.Packed m_TransformPacked;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_LastFrameRendered;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected VolumetricLightBeam m_Master;

		[Token(Token = "0x17000017")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x20FA7CC", Offset = "0x20FA7CC", VA = "0x20FA7CC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onOcclusionProcessed
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x20FA528", Offset = "0x20FA528", VA = "0x20FA528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCB80", Offset = "0xCDCB80")]
			add
			{
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x20FA5CC", Offset = "0x20FA5CC", VA = "0x20FA5CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCB90", Offset = "0xCDCB90")]
			remove
			{
			}
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x20FA344", Offset = "0x20FA344", VA = "0x20FA344")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x20FA34C", Offset = "0x20FA34C", VA = "0x20FA34C")]
		protected void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		[Token(Token = "0x6000054")]
		protected abstract string GetShaderKeyword();

		[Token(Token = "0x6000055")]
		protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

		[Token(Token = "0x6000056")]
		protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

		[Token(Token = "0x6000057")]
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		[Token(Token = "0x6000058")]
		protected abstract void OnEnablePostValidate();

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x20FA7D4", Offset = "0x20FA7D4", VA = "0x20FA7D4", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x20FA850", Offset = "0x20FA850", VA = "0x20FA850", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x20FA8C8", Offset = "0x20FA8C8", VA = "0x20FA8C8", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x20FA920", Offset = "0x20FA920", VA = "0x20FA920", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x20FABD8", Offset = "0x20FABD8", VA = "0x20FABD8", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x20FAD00", Offset = "0x20FAD00", VA = "0x20FAD00")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x20FA8E4", Offset = "0x20FA8E4", VA = "0x20FA8E4")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x20FB040", Offset = "0x20FB040", VA = "0x20FB040")]
		protected DynamicOcclusionAbstractBase()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x20FB0B0", Offset = "0x20FB0B0", VA = "0x20FB0B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCBA0", Offset = "0xCDCBA0")]
		private void <OnEnable>b__22_0()
		{
		}
	}
	[Token(Token = "0x200000A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD1FDC", Offset = "0xCD1FDC")]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LayerMask layerMask;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useOcclusionCulling;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int depthMapResolution;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Camera m_DepthCamera;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x20FB0B8", Offset = "0x20FB0B8", VA = "0x20FB0B8", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x20FB100", Offset = "0x20FB100", VA = "0x20FB100", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x20FB108", Offset = "0x20FB108", VA = "0x20FB108")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x20FB34C", Offset = "0x20FB34C", VA = "0x20FB34C", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x20FB3DC", Offset = "0x20FB3DC", VA = "0x20FB3DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x20FB138", Offset = "0x20FB138", VA = "0x20FB138")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x20FB5E0", Offset = "0x20FB5E0", VA = "0x20FB5E0")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x20FB69C", Offset = "0x20FB69C", VA = "0x20FB69C", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x20FB73C", Offset = "0x20FB73C", VA = "0x20FB73C")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x20FB9F0", Offset = "0x20FB9F0", VA = "0x20FB9F0", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x20FB9F4", Offset = "0x20FB9F4", VA = "0x20FB9F4", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x20FBA9C", Offset = "0x20FBA9C", VA = "0x20FBA9C", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x20FBAA0", Offset = "0x20FBAA0", VA = "0x20FBAA0", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x20FBAC4", Offset = "0x20FBAC4", VA = "0x20FBAC4")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x20FBC30", Offset = "0x20FBC30", VA = "0x20FBC30", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x20FBDC0", Offset = "0x20FBDC0", VA = "0x20FBDC0")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x200000B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD2028", Offset = "0xCD2028")]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x2000111")]
		public class HitResult
		{
			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 normal;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Collider2D collider2D;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Collider collider3D;

			[Token(Token = "0x170000F9")]
			public bool hasCollider
			{
				[Token(Token = "0x600086E")]
				[Address(RVA = "0x20FD22C", Offset = "0x20FD22C", VA = "0x20FD22C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000FA")]
			public string name
			{
				[Token(Token = "0x600086F")]
				[Address(RVA = "0x20FDD84", Offset = "0x20FDD84", VA = "0x20FDD84")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FB")]
			public Bounds bounds
			{
				[Token(Token = "0x6000870")]
				[Address(RVA = "0x20FDE60", Offset = "0x20FDE60", VA = "0x20FDE60")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x600086B")]
			[Address(RVA = "0x20FCC50", Offset = "0x20FCC50", VA = "0x20FCC50")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x600086C")]
			[Address(RVA = "0x20FCD54", Offset = "0x20FCD54", VA = "0x20FCD54")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x600086D")]
			[Address(RVA = "0x20FCCC0", Offset = "0x20FCCC0", VA = "0x20FCCC0")]
			public HitResult()
			{
			}
		}

		[Token(Token = "0x2000112")]
		private enum Direction
		{
			[Token(Token = "0x4000757")]
			Up = 0,
			[Token(Token = "0x4000758")]
			Down = 1,
			[Token(Token = "0x4000759")]
			Left = 2,
			[Token(Token = "0x400075A")]
			Right = 3,
			[Token(Token = "0x400075B")]
			Max2D = 1,
			[Token(Token = "0x400075C")]
			Max3D = 3
		}

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Dimensions dimensions;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public LayerMask layerMask;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool considerTriggers;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float minOccluderArea;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float minSurfaceRatio;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float maxSurfaceDot;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float planeOffset;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD4608", Offset = "0xCD4608")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD4640", Offset = "0xCD4640")]
		private HitResult <currentHit>k__BackingField;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_RangeMultiplier;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD4650", Offset = "0xCD4650")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x17000018")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE0468", Offset = "0xCE0468")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x20FBE80", Offset = "0x20FBE80", VA = "0x20FBE80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x20FBE88", Offset = "0x20FBE88", VA = "0x20FBE88")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public HitResult currentHit
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x20FC000", Offset = "0x20FC000", VA = "0x20FC000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCBB0", Offset = "0xCDCBB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x20FC008", Offset = "0x20FC008", VA = "0x20FC008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCBC0", Offset = "0xCDCBC0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x20FC060", Offset = "0x20FC060", VA = "0x20FC060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCBD0", Offset = "0xCDCBD0")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x20FC06C", Offset = "0x20FC06C", VA = "0x20FC06C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCBE0", Offset = "0xCDCBE0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x20FC430", Offset = "0x20FC430", VA = "0x20FC430")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x1700001C")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x20FC444", Offset = "0x20FC444", VA = "0x20FC444")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x20FBE90", Offset = "0x20FBE90", VA = "0x20FBE90")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x20FC010", Offset = "0x20FC010", VA = "0x20FC010", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x20FC058", Offset = "0x20FC058", VA = "0x20FC058", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x20FC078", Offset = "0x20FC078", VA = "0x20FC078", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x20FC118", Offset = "0x20FC118", VA = "0x20FC118", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x20FC120", Offset = "0x20FC120", VA = "0x20FC120", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x20FC254", Offset = "0x20FC254", VA = "0x20FC254")]
		private void Start()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x20FC334", Offset = "0x20FC334", VA = "0x20FC334")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x20FC54C", Offset = "0x20FC54C", VA = "0x20FC54C")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x20FC560", Offset = "0x20FC560", VA = "0x20FC560")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x20FC838", Offset = "0x20FC838", VA = "0x20FC838")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x20FCE3C", Offset = "0x20FCE3C", VA = "0x20FCE3C")]
		private uint GetDirectionCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x20FCE54", Offset = "0x20FCE54", VA = "0x20FCE54")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x20FD138", Offset = "0x20FD138", VA = "0x20FD138")]
		private bool IsHitValid(HitResult hit, Vector3 forwardVec)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x20FD2E0", Offset = "0x20FD2E0", VA = "0x20FD2E0", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x20FC148", Offset = "0x20FC148", VA = "0x20FC148")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x20FD988", Offset = "0x20FD988", VA = "0x20FD988", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x20FD7F4", Offset = "0x20FD7F4", VA = "0x20FD7F4")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x20FD7B0", Offset = "0x20FD7B0", VA = "0x20FD7B0")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x20FDCAC", Offset = "0x20FDCAC", VA = "0x20FDCAC")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x20FDCB8", Offset = "0x20FDCB8", VA = "0x20FDCB8")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public enum FeatureEnabledColorGradient
	{
		[Token(Token = "0x4000096")]
		Off,
		[Token(Token = "0x4000097")]
		HighOnly,
		[Token(Token = "0x4000098")]
		HighAndLow
	}
	[Token(Token = "0x200000D")]
	public enum ColorMode
	{
		[Token(Token = "0x400009A")]
		Flat,
		[Token(Token = "0x400009B")]
		Gradient
	}
	[Token(Token = "0x200000E")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x400009D")]
		Linear,
		[Token(Token = "0x400009E")]
		Quadratic,
		[Token(Token = "0x400009F")]
		Blend
	}
	[Token(Token = "0x200000F")]
	public enum BlendingMode
	{
		[Token(Token = "0x40000A1")]
		Additive,
		[Token(Token = "0x40000A2")]
		SoftAdditive,
		[Token(Token = "0x40000A3")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000010")]
	public enum ShaderAccuracy
	{
		[Token(Token = "0x40000A5")]
		Fast,
		[Token(Token = "0x40000A6")]
		High
	}
	[Token(Token = "0x2000011")]
	public enum NoiseMode
	{
		[Token(Token = "0x40000A8")]
		Disabled,
		[Token(Token = "0x40000A9")]
		WorldSpace,
		[Token(Token = "0x40000AA")]
		LocalSpace
	}
	[Token(Token = "0x2000012")]
	public enum MeshType
	{
		[Token(Token = "0x40000AC")]
		Shared,
		[Token(Token = "0x40000AD")]
		Custom
	}
	[Token(Token = "0x2000013")]
	public enum RenderPipeline
	{
		[Token(Token = "0x40000AF")]
		BuiltIn,
		[Token(Token = "0x40000B0")]
		URP,
		[Token(Token = "0x40000B1")]
		HDRP
	}
	[Token(Token = "0x2000014")]
	public enum RenderingMode
	{
		[Token(Token = "0x40000B3")]
		MultiPass,
		[Token(Token = "0x40000B4")]
		SinglePass,
		[Token(Token = "0x40000B5")]
		GPUInstancing,
		[Token(Token = "0x40000B6")]
		SRPBatcher
	}
	[Token(Token = "0x2000015")]
	public enum RenderQueue
	{
		[Token(Token = "0x40000B8")]
		Custom = 0,
		[Token(Token = "0x40000B9")]
		Background = 1000,
		[Token(Token = "0x40000BA")]
		Geometry = 2000,
		[Token(Token = "0x40000BB")]
		AlphaTest = 2450,
		[Token(Token = "0x40000BC")]
		GeometryLast = 2500,
		[Token(Token = "0x40000BD")]
		Transparent = 3000,
		[Token(Token = "0x40000BE")]
		Overlay = 4000
	}
	[Token(Token = "0x2000016")]
	public enum Dimensions
	{
		[Token(Token = "0x40000C0")]
		Dim3D,
		[Token(Token = "0x40000C1")]
		Dim2D
	}
	[Token(Token = "0x2000017")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x40000C3")]
		Surface,
		[Token(Token = "0x40000C4")]
		Beam
	}
	[Token(Token = "0x2000018")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		[Token(Token = "0x40000C6")]
		Never = 1,
		[Token(Token = "0x40000C7")]
		OnEnable = 2,
		[Token(Token = "0x40000C8")]
		OnBeamMove = 4,
		[Token(Token = "0x40000C9")]
		EveryXFrames = 8,
		[Token(Token = "0x40000CA")]
		OnBeamMoveAndEveryXFrames = 0xC
	}
	[Token(Token = "0x2000019")]
	public enum ParticlesDirection
	{
		[Token(Token = "0x40000CC")]
		Random,
		[Token(Token = "0x40000CD")]
		LocalSpace,
		[Token(Token = "0x40000CE")]
		WorldSpace
	}
	[Token(Token = "0x200001A")]
	public static class GlobalMesh
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x20F6644", Offset = "0x20F6644", VA = "0x20F6644")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x20FDF58", Offset = "0x20FDF58", VA = "0x20FDF58")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x20FE05C", Offset = "0x20FE05C", VA = "0x20FE05C")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public static class MaterialManager
	{
		[Token(Token = "0x2000113")]
		public enum BlendingMode
		{
			[Token(Token = "0x400075E")]
			Additive,
			[Token(Token = "0x400075F")]
			SoftAdditive,
			[Token(Token = "0x4000760")]
			TraditionalTransparency,
			[Token(Token = "0x4000761")]
			Count
		}

		[Token(Token = "0x2000114")]
		public enum Noise3D
		{
			[Token(Token = "0x4000763")]
			Off,
			[Token(Token = "0x4000764")]
			On,
			[Token(Token = "0x4000765")]
			Count
		}

		[Token(Token = "0x2000115")]
		public enum DepthBlend
		{
			[Token(Token = "0x4000767")]
			Off,
			[Token(Token = "0x4000768")]
			On,
			[Token(Token = "0x4000769")]
			Count
		}

		[Token(Token = "0x2000116")]
		public enum ColorGradient
		{
			[Token(Token = "0x400076B")]
			Off,
			[Token(Token = "0x400076C")]
			MatrixLow,
			[Token(Token = "0x400076D")]
			MatrixHigh,
			[Token(Token = "0x400076E")]
			Count
		}

		[Token(Token = "0x2000117")]
		public enum DynamicOcclusion
		{
			[Token(Token = "0x4000770")]
			Off,
			[Token(Token = "0x4000771")]
			ClippingPlane,
			[Token(Token = "0x4000772")]
			DepthTexture,
			[Token(Token = "0x4000773")]
			Count
		}

		[Token(Token = "0x2000118")]
		public enum MeshSkewing
		{
			[Token(Token = "0x4000775")]
			Off,
			[Token(Token = "0x4000776")]
			On,
			[Token(Token = "0x4000777")]
			Count
		}

		[Token(Token = "0x2000119")]
		public enum ShaderAccuracy
		{
			[Token(Token = "0x4000779")]
			Fast,
			[Token(Token = "0x400077A")]
			High,
			[Token(Token = "0x400077B")]
			Count
		}

		[Token(Token = "0x200011A")]
		public class StaticProperties
		{
			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BlendingMode blendingMode;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Noise3D noise3D;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DepthBlend depthBlend;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColorGradient colorGradient;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DynamicOcclusion dynamicOcclusion;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public MeshSkewing meshSkewing;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShaderAccuracy shaderAccuracy;

			[Token(Token = "0x170000FC")]
			public int materialID
			{
				[Token(Token = "0x6000871")]
				[Address(RVA = "0x20FE1E0", Offset = "0x20FE1E0", VA = "0x20FE1E0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x20F795C", Offset = "0x20F795C", VA = "0x20F795C")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x20F780C", Offset = "0x20F780C", VA = "0x20F780C")]
			public StaticProperties()
			{
			}
		}

		[Token(Token = "0x200011B")]
		private class MaterialsGroup
		{
			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x20FE158", Offset = "0x20FE158", VA = "0x20FE158")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x20F5594", Offset = "0x20F5594", VA = "0x20F5594")]
		public static Material NewMaterialTransient(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x20FE064", Offset = "0x20FE064", VA = "0x20FE064")]
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x20F7BDC", Offset = "0x20F7BDC", VA = "0x20F7BDC")]
		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x200001D")]
	public static class MeshGenerator
	{
		[Token(Token = "0x40000D7")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x20FE378", Offset = "0x20FE378", VA = "0x20FE378")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x20FE390", Offset = "0x20FE390", VA = "0x20FE390")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x20FE45C", Offset = "0x20FE45C", VA = "0x20FE45C")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x20F5D04", Offset = "0x20F5D04", VA = "0x20F5D04")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x20F8BA4", Offset = "0x20F8BA4", VA = "0x20F8BA4")]
		public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x20FE470", Offset = "0x20FE470", VA = "0x20FE470")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x20FE48C", Offset = "0x20FE48C", VA = "0x20FE48C")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x20FE4B4", Offset = "0x20FE4B4", VA = "0x20FE4B4")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x20FE550", Offset = "0x20FE550", VA = "0x20FE550")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200001E")]
	public static class Noise3D
	{
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x40000DB")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x40000DC")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x1700001D")]
		public static bool isSupported
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x20F75A8", Offset = "0x20F75A8", VA = "0x20F75A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x20FE690", Offset = "0x20FE690", VA = "0x20FE690")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x20FE5F0", Offset = "0x20FE5F0", VA = "0x20FE5F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x20FE728", Offset = "0x20FE728", VA = "0x20FE728")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xCDCBF0", Offset = "0xCDCBF0")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x20F8824", Offset = "0x20F8824", VA = "0x20F8824")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x20FE784", Offset = "0x20FE784", VA = "0x20FE784")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x200001F")]
	public class PolygonHelper : MonoBehaviour
	{
		[Token(Token = "0x200011C")]
		public struct Plane2D
		{
			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 normal;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float distance;

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x20FEA54", Offset = "0x20FEA54", VA = "0x20FEA54")]
			public float Distance(Vector2 point)
			{
				return default(float);
			}

			[Token(Token = "0x6000876")]
			[Address(RVA = "0x20FEAF0", Offset = "0x20FEAF0", VA = "0x20FEAF0")]
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x20FEBB0", Offset = "0x20FEBB0", VA = "0x20FEBB0")]
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x20FEDE4", Offset = "0x20FEDE4", VA = "0x20FEDE4")]
			public bool GetSide(Vector2 point)
			{
				return default(bool);
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0x20FEE00", Offset = "0x20FEE00", VA = "0x20FEE00")]
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x600087A")]
			[Address(RVA = "0x20FEF00", Offset = "0x20FEF00", VA = "0x20FEF00")]
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x20FEFA8", Offset = "0x20FEFA8", VA = "0x20FEFA8")]
			public void Flip()
			{
			}

			[Token(Token = "0x600087C")]
			[Address(RVA = "0x20FF034", Offset = "0x20FF034", VA = "0x20FF034")]
			public Vector2[] CutConvex(Vector2[] poly)
			{
				return null;
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0x20FF21C", Offset = "0x20FF21C", VA = "0x20FF21C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x20FEA4C", Offset = "0x20FEA4C", VA = "0x20FEA4C")]
		public PolygonHelper()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public static class SRPHelper
	{
		[Token(Token = "0x200011D")]
		public enum RenderPipeline
		{
			[Token(Token = "0x4000787")]
			Undefined,
			[Token(Token = "0x4000788")]
			BuiltIn,
			[Token(Token = "0x4000789")]
			URP,
			[Token(Token = "0x400078A")]
			LWRP,
			[Token(Token = "0x400078B")]
			HDRP
		}

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RenderPipeline m_RenderPipelineCached;

		[Token(Token = "0x17000020")]
		public static RenderPipeline renderPipelineType
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x20F9800", Offset = "0x20F9800", VA = "0x20F9800")]
			get
			{
				return default(RenderPipeline);
			}
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x20FF2DC", Offset = "0x20FF2DC", VA = "0x20FF2DC")]
		private static RenderPipeline ComputeRenderPipeline()
		{
			return default(RenderPipeline);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x20F8E04", Offset = "0x20F8E04", VA = "0x20F8E04")]
		public static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x20F5154", Offset = "0x20F5154", VA = "0x20F5154")]
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x20F4F7C", Offset = "0x20F4F7C", VA = "0x20F4F7C")]
		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}
	}
	[Token(Token = "0x2000021")]
	public static class ShaderKeywords
	{
		[Token(Token = "0x40000DE")]
		public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK";

		[Token(Token = "0x40000DF")]
		public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW";

		[Token(Token = "0x40000E0")]
		public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH";

		[Token(Token = "0x40000E1")]
		public const string DepthBlend = "VLB_DEPTH_BLEND";

		[Token(Token = "0x40000E2")]
		public const string Noise3D = "VLB_NOISE_3D";

		[Token(Token = "0x40000E3")]
		public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE";

		[Token(Token = "0x40000E4")]
		public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE";

		[Token(Token = "0x40000E5")]
		public const string MeshSkewing = "VLB_MESH_SKEWING";

		[Token(Token = "0x40000E6")]
		public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH";
	}
	[Token(Token = "0x2000022")]
	public static class ShaderProperties
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int ConeRadius;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ColorFlat;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int AlphaInside;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int DistanceFallOff;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int FresnelPow;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int GlareBehind;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int DrawCap;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static readonly int NoiseVelocityAndScale;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly int NoiseParam;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static readonly int CameraParams;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly int WorldToLocalMatrix;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static readonly int BlendSrcFactor;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly int BlendDstFactor;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static readonly int DynamicOcclusionClippingPlaneWS;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly int DynamicOcclusionClippingPlaneProps;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static readonly int DynamicOcclusionDepthTexture;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly int DynamicOcclusionDepthProps;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static readonly int LocalForwardDirection;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static readonly int TiltVector;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static readonly int AdditionalClippingPlaneWS;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static readonly int GlobalNoiseTex3D;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static readonly int GlobalNoiseCustomTime;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static readonly int GlobalDitheringFactor;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static readonly int GlobalDitheringNoiseTex;
	}
	[Token(Token = "0x2000023")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD2084", Offset = "0xCD2084")]
	public class SkewingHandle : MonoBehaviour
	{
		[Token(Token = "0x200011E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD42BC", Offset = "0xCD42BC")]
		private sealed class <CoUpdate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkewingHandle <>4__this;

			[Token(Token = "0x170000FD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000881")]
				[Address(RVA = "0x20FFC6C", Offset = "0x20FFC6C", VA = "0x20FFC6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000883")]
				[Address(RVA = "0x20FFCD4", Offset = "0x20FFCD4", VA = "0x20FFCD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600087E")]
			[Address(RVA = "0x20FFBC8", Offset = "0x20FFBC8", VA = "0x20FFBC8")]
			[DebuggerHidden]
			public <CoUpdate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x20FFBFC", Offset = "0x20FFBFC", VA = "0x20FFBFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x20FFC00", Offset = "0x20FFC00", VA = "0x20FFC00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0x20FFC74", Offset = "0x20FFC74", VA = "0x20FFC74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VolumetricLightBeam volumetricLightBeam;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool shouldUpdateEachFrame;

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x20FF878", Offset = "0x20FF878", VA = "0x20FF878")]
		public bool IsAttachedToSelf()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x20FF95C", Offset = "0x20FF95C", VA = "0x20FF95C")]
		public bool CanSetSkewingVector()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x20FFA04", Offset = "0x20FFA04", VA = "0x20FFA04")]
		public bool CanUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x20FFA48", Offset = "0x20FFA48", VA = "0x20FFA48")]
		private bool ShouldUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x20FFA5C", Offset = "0x20FFA5C", VA = "0x20FFA5C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x20FFAFC", Offset = "0x20FFAFC", VA = "0x20FFAFC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x20FFB58", Offset = "0x20FFB58", VA = "0x20FFB58")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDCC00", Offset = "0xCDCC00")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x20FFA90", Offset = "0x20FFA90", VA = "0x20FFA90")]
		private void SetSkewingVector()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x20FFBF4", Offset = "0x20FFBF4", VA = "0x20FFBF4")]
		public SkewingHandle()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class TransformUtils
	{
		[Token(Token = "0x200011F")]
		public class Packed
		{
			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 position;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion rotation;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 lossyScale;

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x20FFCDC", Offset = "0x20FFCDC", VA = "0x20FFCDC")]
			public Packed()
			{
			}
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x20FA724", Offset = "0x20FA724", VA = "0x20FA724")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x20FAE7C", Offset = "0x20FAE7C", VA = "0x20FAE7C")]
		public static bool IsSame(this Transform self, Packed packed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000025")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD20E0", Offset = "0xCD20E0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD20E0", Offset = "0xCD20E0")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x2000120")]
		private enum TriggerZoneUpdateRate
		{
			[Token(Token = "0x4000793")]
			OnEnable,
			[Token(Token = "0x4000794")]
			OnOcclusionChange
		}

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x400010D")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VolumetricLightBeam m_Beam;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PolygonCollider2D m_PolygonCollider2D;

		[Token(Token = "0x17000021")]
		private TriggerZoneUpdateRate updateRate
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x20FFCE4", Offset = "0x20FFCE4", VA = "0x20FFCE4")]
			get
			{
				return default(TriggerZoneUpdateRate);
			}
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x20FFD78", Offset = "0x20FFD78", VA = "0x20FFD78")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2100540", Offset = "0x2100540", VA = "0x2100540")]
		private void OnOcclusionProcessed()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x20FFEAC", Offset = "0x20FFEAC", VA = "0x20FFEAC")]
		private void ComputeZone()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x21006D0", Offset = "0x21006D0", VA = "0x21006D0")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public static class Utils
	{
		[Token(Token = "0x2000121")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x4000796")]
			High = 64,
			[Token(Token = "0x4000797")]
			Low = 8,
			[Token(Token = "0x4000798")]
			Undef = 0
		}

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x4000112")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x21006E8", Offset = "0x21006E8", VA = "0x21006E8")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x20F58E0", Offset = "0x20F58E0", VA = "0x20F58E0")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2100770", Offset = "0x2100770", VA = "0x2100770")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2100854", Offset = "0x2100854", VA = "0x2100854")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2100880", Offset = "0x2100880", VA = "0x2100880")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x21008B0", Offset = "0x21008B0", VA = "0x21008B0")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x21008E4", Offset = "0x21008E4", VA = "0x21008E4")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x210091C", Offset = "0x210091C", VA = "0x210091C")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2100950", Offset = "0x2100950", VA = "0x2100950")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2100980", Offset = "0x2100980", VA = "0x2100980")]
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2100A30", Offset = "0x2100A30", VA = "0x2100A30")]
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2100AF8", Offset = "0x2100AF8", VA = "0x2100AF8")]
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2100BD8", Offset = "0x2100BD8", VA = "0x2100BD8")]
		public static Vector4 AsVector4(this Vector3 vec3, float w)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2100C08", Offset = "0x2100C08", VA = "0x2100C08")]
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2100CE8", Offset = "0x2100CE8", VA = "0x2100CE8")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x20FCB64", Offset = "0x20FCB64", VA = "0x20FCB64")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2100D3C", Offset = "0x2100D3C", VA = "0x2100D3C")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x20FDB8C", Offset = "0x20FDB8C", VA = "0x20FDB8C")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x21005CC", Offset = "0x21005CC", VA = "0x21005CC")]
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x20FED68", Offset = "0x20FED68", VA = "0x20FED68")]
		public static bool IsAlmostZero(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x20FBFB4", Offset = "0x20FBFB4", VA = "0x20FBFB4")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x20F83C4", Offset = "0x20F83C4", VA = "0x20F83C4")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2100D70", Offset = "0x2100D70", VA = "0x2100D70")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x20F856C", Offset = "0x20F856C", VA = "0x20F856C")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2100E80", Offset = "0x2100E80", VA = "0x2100E80")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2100F88", Offset = "0x2100F88", VA = "0x2100F88")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2100D84", Offset = "0x2100D84", VA = "0x2100D84")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x20F773C", Offset = "0x20F773C", VA = "0x20F773C")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2101034", Offset = "0x2101034", VA = "0x2101034")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2101038", Offset = "0x2101038", VA = "0x2101038")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x2000027")]
	public static class Version
	{
		[Token(Token = "0x4000113")]
		public const int Current = 1900;
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD2188", Offset = "0xCD2188")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD2188", Offset = "0xCD2188")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD4660", Offset = "0xCD4660")]
		public float alpha;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD4678", Offset = "0xCD4678")]
		public float size;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticlesDirection direction;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 velocity;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCD4698", Offset = "0xCD4698")]
		public float speed;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float density;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD46D0", Offset = "0xCD46D0")]
		public float spawnMinDistance;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD46E8", Offset = "0xCD46E8")]
		public float spawnMaxDistance;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool cullingEnabled;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float cullingMaxDistance;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD4700", Offset = "0xCD4700")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x17000022")]
		public bool isCulled
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x2101040", Offset = "0x2101040", VA = "0x2101040")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCDF4", Offset = "0xCDCDF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x2101048", Offset = "0x2101048", VA = "0x2101048")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCE04", Offset = "0xCDCE04")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x2101054", Offset = "0x2101054", VA = "0x2101054")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x21010C0", Offset = "0x21010C0", VA = "0x21010C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		public int particlesMaxCount
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x2101154", Offset = "0x2101154", VA = "0x2101154")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000026")]
		public Camera mainCamera
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x2101200", Offset = "0x2101200", VA = "0x2101200")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2101458", Offset = "0x2101458", VA = "0x2101458")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x21015A8", Offset = "0x21015A8", VA = "0x21015A8")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2101848", Offset = "0x2101848", VA = "0x2101848")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x210178C", Offset = "0x210178C", VA = "0x210178C")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2101FB8", Offset = "0x2101FB8", VA = "0x2101FB8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2102058", Offset = "0x2102058", VA = "0x2102058")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2102118", Offset = "0x2102118", VA = "0x2102118")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x210184C", Offset = "0x210184C", VA = "0x210184C")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x21014D8", Offset = "0x21014D8", VA = "0x21014D8")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x210214C", Offset = "0x210214C", VA = "0x210214C")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2102524", Offset = "0x2102524", VA = "0x2102524")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD2230", Offset = "0xCD2230")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000122")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		[Token(Token = "0x2000123")]
		public delegate void OnBeamGeometryInitialized();

		[Token(Token = "0x2000124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD42CC", Offset = "0xCD42CC")]
		private sealed class <CoPlaytimeUpdate>d__183 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x170000FF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000890")]
				[Address(RVA = "0x2104284", Offset = "0x2104284", VA = "0x2104284", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000100")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000892")]
				[Address(RVA = "0x21042EC", Offset = "0x21042EC", VA = "0x21042EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x2103CEC", Offset = "0x2103CEC", VA = "0x2103CEC")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__183(int <>1__state)
			{
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x21041FC", Offset = "0x21041FC", VA = "0x21041FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x2104200", Offset = "0x2104200", VA = "0x2104200", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x210428C", Offset = "0x210428C", VA = "0x210428C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xCD4710", Offset = "0xCD4710")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD4710", Offset = "0xCD4710")]
		public Color color;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD4764", Offset = "0xCD4764")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD4764", Offset = "0xCD4764")]
		public float intensityInside;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD47B8", Offset = "0xCD47B8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD47B8", Offset = "0xCD47B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD47B8", Offset = "0xCD47B8")]
		public float intensityOutside;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD4830", Offset = "0xCD4830")]
		public bool spotAngleFromLight;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD4868", Offset = "0xCD4868")]
		public float spotAngle;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD4888", Offset = "0xCD4888")]
		public float coneRadiusStart;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public ShaderAccuracy shaderAccuracy;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MeshType geomMeshType;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD48C0", Offset = "0xCD48C0")]
		public int geomCustomSides;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int geomCustomSegments;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 skewingLocalForwardDirection;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform clippingPlaneTransform;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool geomCap;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD48F8", Offset = "0xCD48F8")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD4930", Offset = "0xCD4930")]
		public float attenuationCustomBlending;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD4948", Offset = "0xCD4948")]
		public float fallOffStart;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD4980", Offset = "0xCD4980")]
		public float fallOffEnd;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float depthBlendDistance;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float cameraClippingDistance;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD49B8", Offset = "0xCD49B8")]
		public float glareFrontal;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD49D0", Offset = "0xCD49D0")]
		public float glareBehind;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD49E8", Offset = "0xCD49E8")]
		public float fresnelPow;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public NoiseMode noiseMode;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD4A20", Offset = "0xCD4A20")]
		public float noiseIntensity;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD4A38", Offset = "0xCD4A38")]
		public float noiseScaleLocal;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Dimensions dimensions;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector2 tiltFactor;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD4A54", Offset = "0xCD4A54")]
		private MaterialManager.DynamicOcclusion <_INTERNAL_DynamicOcclusionMode>k__BackingField;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool m_IsDynamicOcclusionEnabled;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD4A84", Offset = "0xCD4A84")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD4AF0", Offset = "0xCD4AF0")]
		[SerializeField]
		private float _FadeOutBegin;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD4B3C", Offset = "0xCD4B3C")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD4B88", Offset = "0xCD4B88")]
		private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Light _CachedLight;

		[Token(Token = "0x17000027")]
		public ColorMode usedColorMode
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x20F84EC", Offset = "0x20F84EC", VA = "0x20F84EC")]
			get
			{
				return default(ColorMode);
			}
		}

		[Token(Token = "0x17000028")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE04A0", Offset = "0xCE04A0")]
		public float alphaInside
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x2102628", Offset = "0x2102628", VA = "0x2102628")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x2102630", Offset = "0x2102630", VA = "0x2102630")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE04D8", Offset = "0xCE04D8")]
		public float alphaOutside
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x2102638", Offset = "0x2102638", VA = "0x2102638")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x2102640", Offset = "0x2102640", VA = "0x2102640")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float intensityGlobal
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x2102648", Offset = "0x2102648", VA = "0x2102648")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x2102650", Offset = "0x2102650", VA = "0x2102650")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public float coneAngle
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x20F83E8", Offset = "0x20F83E8", VA = "0x20F83E8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002C")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x20F72F0", Offset = "0x20F72F0", VA = "0x20F72F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float coneVolume
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x2102658", Offset = "0x2102658", VA = "0x2102658")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x20F8490", Offset = "0x20F8490", VA = "0x20F8490")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002F")]
		public int geomSides
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x2100544", Offset = "0x2100544", VA = "0x2100544")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x21026AC", Offset = "0x21026AC", VA = "0x21026AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public int geomSegments
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x210272C", Offset = "0x210272C", VA = "0x210272C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x21027B4", Offset = "0x21027B4", VA = "0x21027B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public Vector3 skewingLocalForwardDirectionNormalized
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x20F8A44", Offset = "0x20F8A44", VA = "0x20F8A44")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000032")]
		public Vector4 additionalClippingPlane
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x20F86E4", Offset = "0x20F86E4", VA = "0x20F86E4")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000033")]
		public bool canHaveMeshSkewing
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x20FF9F4", Offset = "0x20FF9F4", VA = "0x20FF9F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000034")]
		public bool hasMeshSkewing
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x20F782C", Offset = "0x20F782C", VA = "0x20F782C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE0510", Offset = "0xCE0510")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x2102834", Offset = "0x2102834", VA = "0x2102834")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x210283C", Offset = "0x210283C", VA = "0x210283C")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x20F86BC", Offset = "0x20F86BC", VA = "0x20F86BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000037")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE0548", Offset = "0xCE0548")]
		public float fadeStart
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x2102848", Offset = "0x2102848", VA = "0x2102848")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x2102850", Offset = "0x2102850", VA = "0x2102850")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE0580", Offset = "0xCE0580")]
		public float fadeEnd
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x2102858", Offset = "0x2102858", VA = "0x2102858")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x2102860", Offset = "0x2102860", VA = "0x2102860")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public float maxGeometryDistance
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x20F7370", Offset = "0x20F7370", VA = "0x20F7370")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003A")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x20F44E4", Offset = "0x20F44E4", VA = "0x20F44E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE05B8", Offset = "0xCE05B8")]
		public bool noiseEnabled
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x2102868", Offset = "0x2102868", VA = "0x2102868")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x2102878", Offset = "0x2102878", VA = "0x2102878")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public float fadeOutBegin
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x2102894", Offset = "0x2102894", VA = "0x2102894")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x210289C", Offset = "0x210289C", VA = "0x210289C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public float fadeOutEnd
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x21028F8", Offset = "0x21028F8", VA = "0x21028F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x2102900", Offset = "0x2102900", VA = "0x2102900")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x20F4760", Offset = "0x20F4760", VA = "0x20F4760")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public bool isTilted
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x2102908", Offset = "0x2102908", VA = "0x2102908")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x21029D0", Offset = "0x21029D0", VA = "0x21029D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x21029D8", Offset = "0x21029D8", VA = "0x21029D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public string sortingLayerName
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x2102A88", Offset = "0x2102A88", VA = "0x2102A88")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x2102A94", Offset = "0x2102A94", VA = "0x2102A94")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public int sortingOrder
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x2102AC4", Offset = "0x2102AC4", VA = "0x2102AC4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x2102ACC", Offset = "0x2102ACC", VA = "0x2102ACC")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x2102B7C", Offset = "0x2102B7C", VA = "0x2102B7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x2102B84", Offset = "0x2102B84", VA = "0x2102B84")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x2102BE4", Offset = "0x2102BE4", VA = "0x2102BE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		public bool hasGeometry
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x2102388", Offset = "0x2102388", VA = "0x2102388")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public Bounds bounds
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x21023F8", Offset = "0x21023F8", VA = "0x21023F8")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000047")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x2102BF4", Offset = "0x2102BF4", VA = "0x2102BF4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000048")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x20F73F8", Offset = "0x20F73F8", VA = "0x20F73F8")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000049")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x20FB498", Offset = "0x20FB498", VA = "0x20FB498")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004A")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x20FB524", Offset = "0x20FB524", VA = "0x20FB524")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004B")]
		public float raycastDistance
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x20FC494", Offset = "0x20FC494", VA = "0x20FC494")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004C")]
		public Vector3 raycastGlobalForward
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x20FD690", Offset = "0x20FD690", VA = "0x20FD690")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004D")]
		public Vector3 raycastGlobalUp
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x20FCF78", Offset = "0x20FCF78", VA = "0x20FCF78")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004E")]
		public Vector3 raycastGlobalRight
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x20FD058", Offset = "0x20FD058", VA = "0x20FD058")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004F")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x2102CEC", Offset = "0x2102CEC", VA = "0x2102CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCE14", Offset = "0xCDCE14")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x2102CF4", Offset = "0x2102CF4", VA = "0x2102CF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCE24", Offset = "0xCDCE24")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public MaterialManager.DynamicOcclusion _INTERNAL_EnabledDynamicOcclusionMode
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x20F7814", Offset = "0x20F7814", VA = "0x20F7814")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x17000051")]
		public int _INTERNAL_pluginVersion
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x21032C8", Offset = "0x21032C8", VA = "0x21032C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000052")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2103374", Offset = "0x2103374", VA = "0x2103374")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCE54", Offset = "0xCDCE54")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x210337C", Offset = "0x210337C", VA = "0x210337C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCE64", Offset = "0xCDCE64")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public string meshStats
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x2103384", Offset = "0x2103384", VA = "0x2103384")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public int meshVerticesCount
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x210350C", Offset = "0x210350C", VA = "0x210350C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x21035E8", Offset = "0x21035E8", VA = "0x21035E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000056")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x21036DC", Offset = "0x21036DC", VA = "0x21036DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x20FAA60", Offset = "0x20FAA60", VA = "0x20FAA60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCE34", Offset = "0xCDCE34")]
			add
			{
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x20FAC5C", Offset = "0x20FAC5C", VA = "0x20FAC5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCE44", Offset = "0xCDCE44")]
			remove
			{
			}
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x20FA670", Offset = "0x20FA670", VA = "0x20FA670")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x20F9318", Offset = "0x20F9318", VA = "0x20F9318")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x20FAB14", Offset = "0x20FAB14", VA = "0x20FAB14")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2103090", Offset = "0x2103090", VA = "0x2103090")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x21028A4", Offset = "0x21028A4", VA = "0x21028A4")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x21032D0", Offset = "0x21032D0", VA = "0x21032D0")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x21037D4", Offset = "0x21037D4", VA = "0x21037D4")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x20F9328", Offset = "0x20F9328", VA = "0x20F9328")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2103834", Offset = "0x2103834", VA = "0x2103834")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCDCE74", Offset = "0xCDCE74")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2103840", Offset = "0x2103840", VA = "0x2103840", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2103AAC", Offset = "0x2103AAC", VA = "0x2103AAC", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2103B40", Offset = "0x2103B40", VA = "0x2103B40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2103B4C", Offset = "0x2103B4C", VA = "0x2103B4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2103BE4", Offset = "0x2103BE4", VA = "0x2103BE4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2102B90", Offset = "0x2102B90", VA = "0x2102B90")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2103C7C", Offset = "0x2103C7C", VA = "0x2103C7C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDCEAC", Offset = "0xCDCEAC")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2103D18", Offset = "0x2103D18", VA = "0x2103D18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2103D1C", Offset = "0x2103D1C", VA = "0x2103D1C")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2103DDC", Offset = "0x2103DDC", VA = "0x2103DDC")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2103EDC", Offset = "0x2103EDC", VA = "0x2103EDC")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2103A7C", Offset = "0x2103A7C", VA = "0x2103A7C")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x210396C", Offset = "0x210396C", VA = "0x210396C")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x21040C8", Offset = "0x21040C8", VA = "0x21040C8")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD229C", Offset = "0xCD229C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD229C", Offset = "0xCD229C")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000125")]
		public enum Mode
		{
			[Token(Token = "0x400079D")]
			AnimationClips,
			[Token(Token = "0x400079E")]
			AnimationStates,
			[Token(Token = "0x400079F")]
			PlayableDirector,
			[Token(Token = "0x40007A0")]
			Realtime
		}

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4B98", Offset = "0xCD4B98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD4B98", Offset = "0xCD4B98")]
		public int frameRate;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4BF0", Offset = "0xCD4BF0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD4BF0", Offset = "0xCD4BF0")]
		public float keyReductionError;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4C48", Offset = "0xCD4C48")]
		public Mode mode;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4C80", Offset = "0xCD4C80")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4CB8", Offset = "0xCD4CB8")]
		public string[] animationStates;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4CF0", Offset = "0xCD4CF0")]
		public bool loop;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4D28", Offset = "0xCD4D28")]
		public string saveToFolder;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4D60", Offset = "0xCD4D60")]
		public string appendName;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4D98", Offset = "0xCD4D98")]
		public string saveName;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD4DD0", Offset = "0xCD4DD0")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD4DE0", Offset = "0xCD4DE0")]
		private float <bakingProgress>k__BackingField;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD4E60", Offset = "0xCD4E60")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000057")]
		public bool isBaking
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1B710A4", Offset = "0x1B710A4", VA = "0x1B710A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDCFF0", Offset = "0xCDCFF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1B710AC", Offset = "0x1B710AC", VA = "0x1B710AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD000", Offset = "0xCDD000")]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public float bakingProgress
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1B710B8", Offset = "0x1B710B8", VA = "0x1B710B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD010", Offset = "0xCDD010")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1B710C0", Offset = "0x1B710C0", VA = "0x1B710C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD020", Offset = "0xCDD020")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		protected float clipLength
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x1B710C8", Offset = "0x1B710C8", VA = "0x1B710C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD030", Offset = "0xCDD030")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x1B710D0", Offset = "0x1B710D0", VA = "0x1B710D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD040", Offset = "0xCDD040")]
			private set
			{
			}
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1B70F74", Offset = "0x1B70F74", VA = "0x1B70F74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDCF10", Offset = "0xCDCF10")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1B70FC0", Offset = "0x1B70FC0", VA = "0x1B70FC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDCF48", Offset = "0xCDCF48")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1B7100C", Offset = "0x1B7100C", VA = "0x1B7100C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDCF80", Offset = "0xCDCF80")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1B71058", Offset = "0x1B71058", VA = "0x1B71058")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDCFB8", Offset = "0xCDCFB8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000157")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x6000158")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000159")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x600015A")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x600015B")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1B710D8", Offset = "0x1B710D8", VA = "0x1B710D8")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1B710DC", Offset = "0x1B710DC", VA = "0x1B710DC")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1B710E0", Offset = "0x1B710E0", VA = "0x1B710E0")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1B710E4", Offset = "0x1B710E4", VA = "0x1B710E4")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4E70", Offset = "0xCD4E70")]
		public bool markAsLegacy;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4EA8", Offset = "0xCD4EA8")]
		public Transform root;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4EE0", Offset = "0xCD4EE0")]
		public Transform rootNode;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4F18", Offset = "0xCD4F18")]
		public Transform[] ignoreList;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4F50", Offset = "0xCD4F50")]
		public Transform[] bakePositionList;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1AA535C", Offset = "0x1AA535C", VA = "0x1AA535C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1AA5728", Offset = "0x1AA5728", VA = "0x1AA5728", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1AA5730", Offset = "0x1AA5730", VA = "0x1AA5730", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1AA5840", Offset = "0x1AA5840", VA = "0x1AA5840", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1AA58BC", Offset = "0x1AA58BC", VA = "0x1AA58BC", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1AA5938", Offset = "0x1AA5938", VA = "0x1AA5938", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1AA5578", Offset = "0x1AA5578", VA = "0x1AA5578")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1AA5650", Offset = "0x1AA5650", VA = "0x1AA5650")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1AA59B4", Offset = "0x1AA59B4", VA = "0x1AA59B4")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class TQ
	{
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x20F23EC", Offset = "0x20F23EC", VA = "0x20F23EC")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class AvatarUtility
	{
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1B6FF5C", Offset = "0x1B6FF5C", VA = "0x1B6FF5C")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1B70170", Offset = "0x1B70170", VA = "0x1B70170")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1B70150", Offset = "0x1B70150", VA = "0x1B70150")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1B707F0", Offset = "0x1B707F0", VA = "0x1B707F0")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1B72228", Offset = "0x1B72228", VA = "0x1B72228")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1B736FC", Offset = "0x1B736FC", VA = "0x1B736FC")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1B71C3C", Offset = "0x1B71C3C", VA = "0x1B71C3C")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1B72270", Offset = "0x1B72270", VA = "0x1B72270")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1B71774", Offset = "0x1B71774", VA = "0x1B71774")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1B711A4", Offset = "0x1B711A4", VA = "0x1B711A4")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1B713F0", Offset = "0x1B713F0", VA = "0x1B713F0")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1B712C4", Offset = "0x1B712C4", VA = "0x1B712C4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1B71528", Offset = "0x1B71528", VA = "0x1B71528")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1B719D0", Offset = "0x1B719D0", VA = "0x1B719D0")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1B71ACC", Offset = "0x1B71ACC", VA = "0x1B71ACC")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1B71BC8", Offset = "0x1B71BC8", VA = "0x1B71BC8")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1B71B40", Offset = "0x1B71B40", VA = "0x1B71B40")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1B71E88", Offset = "0x1B71E88", VA = "0x1B71E88")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1B71F3C", Offset = "0x1B71F3C", VA = "0x1B71F3C")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class BakerMuscle
	{
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1B72274", Offset = "0x1B72274", VA = "0x1B72274")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1B722E4", Offset = "0x1B722E4", VA = "0x1B722E4")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1B729CC", Offset = "0x1B729CC", VA = "0x1B729CC")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1B72A80", Offset = "0x1B72A80", VA = "0x1B72A80")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1B7296C", Offset = "0x1B7296C", VA = "0x1B7296C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1B72B64", Offset = "0x1B72B64", VA = "0x1B72B64")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1B72BAC", Offset = "0x1B72BAC", VA = "0x1B72BAC")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class BakerTransform
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1B72BB4", Offset = "0x1B72BB4", VA = "0x1B72BB4")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1B72D48", Offset = "0x1B72D48", VA = "0x1B72D48")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1B72D5C", Offset = "0x1B72D5C", VA = "0x1B72D5C")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1B72FEC", Offset = "0x1B72FEC", VA = "0x1B72FEC")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1B72C50", Offset = "0x1B72C50", VA = "0x1B72C50")]
		public void Reset()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1B73238", Offset = "0x1B73238", VA = "0x1B73238")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1B732AC", Offset = "0x1B732AC", VA = "0x1B732AC")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1B734F8", Offset = "0x1B734F8", VA = "0x1B734F8")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4F88", Offset = "0xCD4F88")]
		public bool bakeHandIK;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD4FC0", Offset = "0xCD4FC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD4FC0", Offset = "0xCD4FC0")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5018", Offset = "0xCD5018")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD5018", Offset = "0xCD5018")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1AA68EC", Offset = "0x1AA68EC", VA = "0x1AA68EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1AA6D18", Offset = "0x1AA6D18", VA = "0x1AA6D18", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1AA6D34", Offset = "0x1AA6D34", VA = "0x1AA6D34", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1AA6E54", Offset = "0x1AA6E54", VA = "0x1AA6E54", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1AA6F30", Offset = "0x1AA6F30", VA = "0x1AA6F30", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1AA7100", Offset = "0x1AA7100", VA = "0x1AA7100", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1AA7428", Offset = "0x1AA7428", VA = "0x1AA7428")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1AA7504", Offset = "0x1AA7504", VA = "0x1AA7504")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000126")]
		public enum UpdateMode
		{
			[Token(Token = "0x40007A2")]
			Update,
			[Token(Token = "0x40007A3")]
			FixedUpdate,
			[Token(Token = "0x40007A4")]
			LateUpdate,
			[Token(Token = "0x40007A5")]
			FixedLateUpdate
		}

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD506C", Offset = "0xCD506C")]
		public bool smoothFollow;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD50A4", Offset = "0xCD50A4")]
		public float rotationSensitivity;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD50DC", Offset = "0xCD50DC")]
		public float distance;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD5114", Offset = "0xCD5114")]
		public LayerMask blockingLayers;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD514C", Offset = "0xCD514C")]
		public float blockedOffset;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD5164", Offset = "0xCD5164")]
		private float <x>k__BackingField;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD5174", Offset = "0xCD5174")]
		private float <y>k__BackingField;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD5184", Offset = "0xCD5184")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x1700005A")]
		public float x
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1A796D0", Offset = "0x1A796D0", VA = "0x1A796D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD050", Offset = "0xCDD050")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1A796D8", Offset = "0x1A796D8", VA = "0x1A796D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD060", Offset = "0xCDD060")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public float y
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x1A796E0", Offset = "0x1A796E0", VA = "0x1A796E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD070", Offset = "0xCDD070")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x1A796E8", Offset = "0x1A796E8", VA = "0x1A796E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD080", Offset = "0xCDD080")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public float distanceTarget
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x1A796F0", Offset = "0x1A796F0", VA = "0x1A796F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD090", Offset = "0xCDD090")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x1A796F8", Offset = "0x1A796F8", VA = "0x1A796F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD0A0", Offset = "0xCDD0A0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		private float zoomAdd
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x1A7A1A4", Offset = "0x1A7A1A4", VA = "0x1A7A1A4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1A79700", Offset = "0x1A79700", VA = "0x1A79700")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1A7973C", Offset = "0x1A7973C", VA = "0x1A7973C")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1A79744", Offset = "0x1A79744", VA = "0x1A79744", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1A79860", Offset = "0x1A79860", VA = "0x1A79860", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1A798BC", Offset = "0x1A798BC", VA = "0x1A798BC", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1A79924", Offset = "0x1A79924", VA = "0x1A79924", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1A79988", Offset = "0x1A79988", VA = "0x1A79988")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1A79894", Offset = "0x1A79894", VA = "0x1A79894")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1A79B08", Offset = "0x1A79B08", VA = "0x1A79B08")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1A7A0F4", Offset = "0x1A7A0F4", VA = "0x1A7A0F4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1A7A218", Offset = "0x1A7A218", VA = "0x1A7A218")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1A7A328", Offset = "0x1A7A328", VA = "0x1A7A328")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1A7A360", Offset = "0x1A7A360", VA = "0x1A7A360")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1A7A518", Offset = "0x1A7A518", VA = "0x1A7A518")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1A7A5C8", Offset = "0x1A7A5C8", VA = "0x1A7A5C8")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000035")]
	public enum Axis
	{
		[Token(Token = "0x40001CD")]
		X,
		[Token(Token = "0x40001CE")]
		Y,
		[Token(Token = "0x40001CF")]
		Z
	}
	[Token(Token = "0x2000036")]
	public class AxisTools
	{
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1B707F8", Offset = "0x1B707F8", VA = "0x1B707F8")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1B708B0", Offset = "0x1B708B0", VA = "0x1B708B0")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1B7095C", Offset = "0x1B7095C", VA = "0x1B7095C")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1B70B40", Offset = "0x1B70B40", VA = "0x1B70B40")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1B70A78", Offset = "0x1B70A78", VA = "0x1B70A78")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1B70C5C", Offset = "0x1B70C5C", VA = "0x1B70C5C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1B70CA4", Offset = "0x1B70CA4", VA = "0x1B70CA4")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1B70F6C", Offset = "0x1B70F6C", VA = "0x1B70F6C")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000127")]
		public class LimbOrientation
		{
			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x1A734A4", Offset = "0x1A734A4", VA = "0x1A734A4")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x1700005E")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x1B73B30", Offset = "0x1B73B30", VA = "0x1B73B30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x1B73DB4", Offset = "0x1B73DB4", VA = "0x1B73DB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1B73AE4", Offset = "0x1B73AE4", VA = "0x1B73AE4")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000038")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000128")]
		public enum BoneType
		{
			[Token(Token = "0x40007AA")]
			Unassigned,
			[Token(Token = "0x40007AB")]
			Spine,
			[Token(Token = "0x40007AC")]
			Head,
			[Token(Token = "0x40007AD")]
			Arm,
			[Token(Token = "0x40007AE")]
			Leg,
			[Token(Token = "0x40007AF")]
			Tail,
			[Token(Token = "0x40007B0")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000129")]
		public enum BoneSide
		{
			[Token(Token = "0x40007B2")]
			Center,
			[Token(Token = "0x40007B3")]
			Left,
			[Token(Token = "0x40007B4")]
			Right
		}

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1A7351C", Offset = "0x1A7351C", VA = "0x1A7351C")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1A7381C", Offset = "0x1A7381C", VA = "0x1A7381C")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1A73A6C", Offset = "0x1A73A6C", VA = "0x1A73A6C")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1A73AF0", Offset = "0x1A73AF0", VA = "0x1A73AF0")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1A73B9C", Offset = "0x1A73B9C", VA = "0x1A73B9C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1A736CC", Offset = "0x1A736CC", VA = "0x1A736CC")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1A739CC", Offset = "0x1A739CC", VA = "0x1A739CC")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1A743DC", Offset = "0x1A743DC", VA = "0x1A743DC")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1A741F4", Offset = "0x1A741F4", VA = "0x1A741F4")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1A742E8", Offset = "0x1A742E8", VA = "0x1A742E8")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1A73DBC", Offset = "0x1A73DBC", VA = "0x1A73DBC")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1A73E70", Offset = "0x1A73E70", VA = "0x1A73E70")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1A73F24", Offset = "0x1A73F24", VA = "0x1A73F24")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1A73FD8", Offset = "0x1A73FD8", VA = "0x1A73FD8")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1A7408C", Offset = "0x1A7408C", VA = "0x1A7408C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1A74140", Offset = "0x1A74140", VA = "0x1A74140")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1A745F0", Offset = "0x1A745F0", VA = "0x1A745F0")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1A73CD0", Offset = "0x1A73CD0", VA = "0x1A73CD0")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1A74560", Offset = "0x1A74560", VA = "0x1A74560")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1A74660", Offset = "0x1A74660", VA = "0x1A74660")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1A74738", Offset = "0x1A74738", VA = "0x1A74738")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1A744E4", Offset = "0x1A744E4", VA = "0x1A744E4")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1A7446C", Offset = "0x1A7446C", VA = "0x1A7446C")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class BipedReferences
	{
		[Token(Token = "0x200012A")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000101")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000895")]
				[Address(RVA = "0x1A796C8", Offset = "0x1A796C8", VA = "0x1A796C8")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x1A796B4", Offset = "0x1A796B4", VA = "0x1A796B4")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000060")]
		public virtual bool isFilled
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x1A762AC", Offset = "0x1A762AC", VA = "0x1A762AC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		public bool isEmpty
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x1A76698", Offset = "0x1A76698", VA = "0x1A76698")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1A766A8", Offset = "0x1A766A8", VA = "0x1A766A8", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1A76AD4", Offset = "0x1A76AD4", VA = "0x1A76AD4", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1A76F0C", Offset = "0x1A76F0C", VA = "0x1A76F0C")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1A7751C", Offset = "0x1A7751C", VA = "0x1A7751C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1A77158", Offset = "0x1A77158", VA = "0x1A77158")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1A77CCC", Offset = "0x1A77CCC", VA = "0x1A77CCC")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1A77DC0", Offset = "0x1A77DC0", VA = "0x1A77DC0")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1A78318", Offset = "0x1A78318", VA = "0x1A78318")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1A7811C", Offset = "0x1A7811C", VA = "0x1A7811C")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1A77F94", Offset = "0x1A77F94", VA = "0x1A77F94")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1A77E60", Offset = "0x1A77E60", VA = "0x1A77E60")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1A78220", Offset = "0x1A78220", VA = "0x1A78220")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1A78414", Offset = "0x1A78414", VA = "0x1A78414")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1A78EB4", Offset = "0x1A78EB4", VA = "0x1A78EB4")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1A78998", Offset = "0x1A78998", VA = "0x1A78998")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1A791A8", Offset = "0x1A791A8", VA = "0x1A791A8")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1A78CD8", Offset = "0x1A78CD8", VA = "0x1A78CD8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1A791B0", Offset = "0x1A791B0", VA = "0x1A791B0")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1A791B8", Offset = "0x1A791B8", VA = "0x1A791B8")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1A79378", Offset = "0x1A79378", VA = "0x1A79378")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1A79590", Offset = "0x1A79590", VA = "0x1A79590")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1A770E8", Offset = "0x1A770E8", VA = "0x1A770E8")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1A7A5E4", Offset = "0x1A7A5E4", VA = "0x1A7A5E4")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1A7A5EC", Offset = "0x1A7A5EC", VA = "0x1A7A5EC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1A7A72C", Offset = "0x1A7A72C", VA = "0x1A7A72C")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class Hierarchy
	{
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1AA5A1C", Offset = "0x1AA5A1C", VA = "0x1AA5A1C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1AA5C1C", Offset = "0x1AA5C1C", VA = "0x1AA5C1C")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1AA5AB4", Offset = "0x1AA5AB4", VA = "0x1AA5AB4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1AA5D40", Offset = "0x1AA5D40", VA = "0x1AA5D40")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1AA5E64", Offset = "0x1AA5E64", VA = "0x1AA5E64")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1AA610C", Offset = "0x1AA610C", VA = "0x1AA610C")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1AA6228", Offset = "0x1AA6228", VA = "0x1AA6228")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1AA63B0", Offset = "0x1AA63B0", VA = "0x1AA63B0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1AA6744", Offset = "0x1AA6744", VA = "0x1AA6744")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1AA6530", Offset = "0x1AA6530", VA = "0x1AA6530")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1AA68E4", Offset = "0x1AA68E4", VA = "0x1AA68E4")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1AA75B8", Offset = "0x1AA75B8", VA = "0x1AA75B8")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1AA7628", Offset = "0x1AA7628", VA = "0x1AA7628")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40001FD")]
		None,
		[Token(Token = "0x40001FE")]
		InOutCubic,
		[Token(Token = "0x40001FF")]
		InOutQuintic,
		[Token(Token = "0x4000200")]
		InOutSine,
		[Token(Token = "0x4000201")]
		InQuintic,
		[Token(Token = "0x4000202")]
		InQuartic,
		[Token(Token = "0x4000203")]
		InCubic,
		[Token(Token = "0x4000204")]
		InQuadratic,
		[Token(Token = "0x4000205")]
		InElastic,
		[Token(Token = "0x4000206")]
		InElasticSmall,
		[Token(Token = "0x4000207")]
		InElasticBig,
		[Token(Token = "0x4000208")]
		InSine,
		[Token(Token = "0x4000209")]
		InBack,
		[Token(Token = "0x400020A")]
		OutQuintic,
		[Token(Token = "0x400020B")]
		OutQuartic,
		[Token(Token = "0x400020C")]
		OutCubic,
		[Token(Token = "0x400020D")]
		OutInCubic,
		[Token(Token = "0x400020E")]
		OutInQuartic,
		[Token(Token = "0x400020F")]
		OutElastic,
		[Token(Token = "0x4000210")]
		OutElasticSmall,
		[Token(Token = "0x4000211")]
		OutElasticBig,
		[Token(Token = "0x4000212")]
		OutSine,
		[Token(Token = "0x4000213")]
		OutBack,
		[Token(Token = "0x4000214")]
		OutBackCubic,
		[Token(Token = "0x4000215")]
		OutBackQuartic,
		[Token(Token = "0x4000216")]
		BackInCubic,
		[Token(Token = "0x4000217")]
		BackInQuartic
	}
	[Token(Token = "0x200003F")]
	public class Interp
	{
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1A8F3FC", Offset = "0x1A8F3FC", VA = "0x1A8F3FC")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1AA7D94", Offset = "0x1AA7D94", VA = "0x1AA7D94")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1AA7E9C", Offset = "0x1AA7E9C", VA = "0x1AA7E9C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1AA7698", Offset = "0x1AA7698", VA = "0x1AA7698")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1AA76A4", Offset = "0x1AA76A4", VA = "0x1AA76A4")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1AA76C8", Offset = "0x1AA76C8", VA = "0x1AA76C8")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1AA7704", Offset = "0x1AA7704", VA = "0x1AA7704")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1AA771C", Offset = "0x1AA771C", VA = "0x1AA771C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1AA7730", Offset = "0x1AA7730", VA = "0x1AA7730")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1AA7744", Offset = "0x1AA7744", VA = "0x1AA7744")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1AA7754", Offset = "0x1AA7754", VA = "0x1AA7754")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1AA779C", Offset = "0x1AA779C", VA = "0x1AA779C")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1AA77D4", Offset = "0x1AA77D4", VA = "0x1AA77D4")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1AA77FC", Offset = "0x1AA77FC", VA = "0x1AA77FC")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1AA7F98", Offset = "0x1AA7F98", VA = "0x1AA7F98")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1AA7830", Offset = "0x1AA7830", VA = "0x1AA7830")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1AA7858", Offset = "0x1AA7858", VA = "0x1AA7858")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1AA7888", Offset = "0x1AA7888", VA = "0x1AA7888")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1AA78BC", Offset = "0x1AA78BC", VA = "0x1AA78BC")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1AA7900", Offset = "0x1AA7900", VA = "0x1AA7900")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1AA7964", Offset = "0x1AA7964", VA = "0x1AA7964")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1AA79C8", Offset = "0x1AA79C8", VA = "0x1AA79C8")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1AA7A1C", Offset = "0x1AA7A1C", VA = "0x1AA7A1C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1AA7A70", Offset = "0x1AA7A70", VA = "0x1AA7A70")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1AA7B08", Offset = "0x1AA7B08", VA = "0x1AA7B08")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1AA7B9C", Offset = "0x1AA7B9C", VA = "0x1AA7B9C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1AA7FCC", Offset = "0x1AA7FCC", VA = "0x1AA7FCC")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1AA7C40", Offset = "0x1AA7C40", VA = "0x1AA7C40")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1AA7D24", Offset = "0x1AA7D24", VA = "0x1AA7D24")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1AA7D54", Offset = "0x1AA7D54", VA = "0x1AA7D54")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1AA80B4", Offset = "0x1AA80B4", VA = "0x1AA80B4")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x20F0684", Offset = "0x20F0684", VA = "0x20F0684")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x20F06F4", Offset = "0x20F06F4", VA = "0x20F06F4")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000041")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x20F0764", Offset = "0x20F0764", VA = "0x20F0764")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x20F07BC", Offset = "0x20F07BC", VA = "0x20F07BC")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x20F0888", Offset = "0x20F0888", VA = "0x20F0888")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x20F07D4", Offset = "0x20F07D4", VA = "0x20F07D4")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x20F08A0", Offset = "0x20F08A0", VA = "0x20F08A0")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x20F0944", Offset = "0x20F0944", VA = "0x20F0944")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x20F0970", Offset = "0x20F0970", VA = "0x20F0970")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x20F09C0", Offset = "0x20F09C0", VA = "0x20F09C0")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x20F0A2C", Offset = "0x20F0A2C", VA = "0x20F0A2C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x20F0B20", Offset = "0x20F0B20", VA = "0x20F0B20")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x20F0BF8", Offset = "0x20F0BF8", VA = "0x20F0BF8")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x20F0C58", Offset = "0x20F0C58", VA = "0x20F0C58")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000042")]
	public static class QuaTools
	{
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x20F0C88", Offset = "0x20F0C88", VA = "0x20F0C88")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x20F0DD4", Offset = "0x20F0DD4", VA = "0x20F0DD4")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x20F0F20", Offset = "0x20F0F20", VA = "0x20F0F20")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x20F1034", Offset = "0x20F1034", VA = "0x20F1034")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x20F1148", Offset = "0x20F1148", VA = "0x20F1148")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x20F12D4", Offset = "0x20F12D4", VA = "0x20F12D4")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x20F13A4", Offset = "0x20F13A4", VA = "0x20F13A4")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x20F14F8", Offset = "0x20F14F8", VA = "0x20F14F8")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x20F177C", Offset = "0x20F177C", VA = "0x20F177C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x20F1990", Offset = "0x20F1990", VA = "0x20F1990")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x20F1B10", Offset = "0x20F1B10", VA = "0x20F1B10")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x20F1C80", Offset = "0x20F1C80", VA = "0x20F1C80")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x20F1D90", Offset = "0x20F1D90", VA = "0x20F1D90")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000043")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000062")]
		public static T instance
		{
			[Token(Token = "0x6000231")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000232")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000233")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD51A4", Offset = "0xCD51A4")]
		public bool fixTransforms;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000063")]
		private bool animatePhysics
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x20F1F24", Offset = "0x20F1F24", VA = "0x20F1F24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		private bool isAnimated
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x20F2220", Offset = "0x20F2220", VA = "0x20F2220")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x20F1DEC", Offset = "0x20F1DEC", VA = "0x20F1DEC")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x20F1E84", Offset = "0x20F1E84", VA = "0x20F1E84", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x20F1E88", Offset = "0x20F1E88", VA = "0x20F1E88", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x20F1E8C", Offset = "0x20F1E8C", VA = "0x20F1E8C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x20F1E90", Offset = "0x20F1E90", VA = "0x20F1E90")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x20F1F20", Offset = "0x20F1F20", VA = "0x20F1F20")]
		private void Start()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x20F1EC8", Offset = "0x20F1EC8", VA = "0x20F1EC8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x20F21D4", Offset = "0x20F21D4", VA = "0x20F21D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x20F2014", Offset = "0x20F2014", VA = "0x20F2014")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x20F22DC", Offset = "0x20F22DC", VA = "0x20F22DC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x20F2338", Offset = "0x20F2338", VA = "0x20F2338")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x20F2394", Offset = "0x20F2394", VA = "0x20F2394")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x20F23DC", Offset = "0x20F23DC", VA = "0x20F23DC")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x20F245C", Offset = "0x20F245C", VA = "0x20F245C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x20F2514", Offset = "0x20F2514", VA = "0x20F2514")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x20F25CC", Offset = "0x20F25CC", VA = "0x20F25CC")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x20F2684", Offset = "0x20F2684", VA = "0x20F2684")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public static class V3Tools
	{
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x20F268C", Offset = "0x20F268C", VA = "0x20F268C")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x20F2784", Offset = "0x20F2784", VA = "0x20F2784")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x20F287C", Offset = "0x20F287C", VA = "0x20F287C")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x20F2974", Offset = "0x20F2974", VA = "0x20F2974")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x20F2A74", Offset = "0x20F2A74", VA = "0x20F2A74")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x20F2C98", Offset = "0x20F2C98", VA = "0x20F2C98")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x20F2ED4", Offset = "0x20F2ED4", VA = "0x20F2ED4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x20F3124", Offset = "0x20F3124", VA = "0x20F3124")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x20F3324", Offset = "0x20F3324", VA = "0x20F3324")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x20F3500", Offset = "0x20F3500", VA = "0x20F3500")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x20F3634", Offset = "0x20F3634", VA = "0x20F3634")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000047")]
	public static class Warning
	{
		[Token(Token = "0x200012B")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x20F378C", Offset = "0x20F378C", VA = "0x20F378C")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x20F3BB8", Offset = "0x20F3BB8", VA = "0x20F3BB8")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD230C", Offset = "0xCD230C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD230C", Offset = "0xCD230C")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x197B31C", Offset = "0x197B31C", VA = "0x197B31C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD120", Offset = "0xCDD120")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x197B368", Offset = "0x197B368", VA = "0x197B368")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD158", Offset = "0xCDD158")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x197B3B4", Offset = "0x197B3B4", VA = "0x197B3B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD190", Offset = "0xCDD190")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x197B400", Offset = "0x197B400", VA = "0x197B400")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD1C8", Offset = "0xCDD1C8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x197B44C", Offset = "0x197B44C", VA = "0x197B44C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x197B4E8", Offset = "0x197B4E8", VA = "0x197B4E8")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x197B508", Offset = "0x197B508", VA = "0x197B508")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x197B538", Offset = "0x197B538", VA = "0x197B538")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x197B568", Offset = "0x197B568", VA = "0x197B568")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x197B5A8", Offset = "0x197B5A8", VA = "0x197B5A8")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x197B5EC", Offset = "0x197B5EC", VA = "0x197B5EC")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x197B610", Offset = "0x197B610", VA = "0x197B610")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x197B634", Offset = "0x197B634", VA = "0x197B634")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x197B65C", Offset = "0x197B65C", VA = "0x197B65C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x197B688", Offset = "0x197B688", VA = "0x197B688")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x197B6B4", Offset = "0x197B6B4", VA = "0x197B6B4")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x197B46C", Offset = "0x197B46C", VA = "0x197B46C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x197B6DC", Offset = "0x197B6DC", VA = "0x197B6DC")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x197B6E8", Offset = "0x197B6E8", VA = "0x197B6E8")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x197B6F4", Offset = "0x197B6F4", VA = "0x197B6F4")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x197B9DC", Offset = "0x197B9DC", VA = "0x197B9DC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x197BA84", Offset = "0x197BA84", VA = "0x197BA84", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x197BDCC", Offset = "0x197BDCC", VA = "0x197BDCC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x197C2B4", Offset = "0x197C2B4", VA = "0x197C2B4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x197C2E8", Offset = "0x197C2E8", VA = "0x197C2E8")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000065")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x197B894", Offset = "0x197B894", VA = "0x197B894")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x197C4B4", Offset = "0x197C4B4", VA = "0x197C4B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x197BC54", Offset = "0x197BC54", VA = "0x197BC54")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x197C36C", Offset = "0x197C36C", VA = "0x197C36C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public abstract class Constraint
	{
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000067")]
		public bool isValid
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x197CAB4", Offset = "0x197CAB4", VA = "0x197CAB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000273")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x197CB24", Offset = "0x197CB24", VA = "0x197CB24")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x197CB2C", Offset = "0x197CB2C", VA = "0x197CB2C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x197CC38", Offset = "0x197CC38", VA = "0x197CC38")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x197CC40", Offset = "0x197CC40", VA = "0x197CC40")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000068")]
		private bool positionChanged
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x197CE08", Offset = "0x197CE08", VA = "0x197CE08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x197CC6C", Offset = "0x197CC6C", VA = "0x197CC6C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x197CEC4", Offset = "0x197CEC4", VA = "0x197CEC4")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x197CECC", Offset = "0x197CECC", VA = "0x197CECC")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x197CEF8", Offset = "0x197CEF8", VA = "0x197CEF8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x197D020", Offset = "0x197D020", VA = "0x197D020")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x197D028", Offset = "0x197D028", VA = "0x197D028")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000069")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x197D1F4", Offset = "0x197D1F4", VA = "0x197D1F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x197D054", Offset = "0x197D054", VA = "0x197D054", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x197D2C4", Offset = "0x197D2C4", VA = "0x197D2C4")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x197D2CC", Offset = "0x197D2CC", VA = "0x197D2CC")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class Constraints
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD51DC", Offset = "0xCD51DC")]
		public float positionWeight;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD51F4", Offset = "0xCD51F4")]
		public float rotationWeight;

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x197D2F8", Offset = "0x197D2F8", VA = "0x197D2F8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x197BD78", Offset = "0x197BD78", VA = "0x197BD78")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x197BF54", Offset = "0x197BF54", VA = "0x197BF54")]
		public void Update()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x197C680", Offset = "0x197C680", VA = "0x197C680")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x200012C")]
		public enum DOF
		{
			[Token(Token = "0x40007B8")]
			One,
			[Token(Token = "0x40007B9")]
			Three
		}

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD520C", Offset = "0xCD520C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD520C", Offset = "0xCD520C")]
		public float weight;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5260", Offset = "0xCD5260")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD5260", Offset = "0xCD5260")]
		public float rotationWeight;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD52B4", Offset = "0xCD52B4")]
		public DOF rotationDOF;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD52EC", Offset = "0xCD52EC")]
		public bool fixBone1Twist;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5324", Offset = "0xCD5324")]
		public Transform bone1;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD535C", Offset = "0xCD535C")]
		public Transform bone2;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5394", Offset = "0xCD5394")]
		public Transform bone3;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD53CC", Offset = "0xCD53CC")]
		public Transform tip;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5404", Offset = "0xCD5404")]
		public Transform target;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD543C", Offset = "0xCD543C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x1700006A")]
		public bool initiated
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x1984630", Offset = "0x1984630", VA = "0x1984630")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD200", Offset = "0xCDD200")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x1984638", Offset = "0x1984638", VA = "0x1984638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD210", Offset = "0xCDD210")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x1984644", Offset = "0x1984644", VA = "0x1984644")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x1984664", Offset = "0x1984664", VA = "0x1984664")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x1984684", Offset = "0x1984684", VA = "0x1984684")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x19846A4", Offset = "0x19846A4", VA = "0x19846A4")]
			set
			{
			}
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x19846C4", Offset = "0x19846C4", VA = "0x19846C4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x19847C4", Offset = "0x19847C4", VA = "0x19847C4")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1984D58", Offset = "0x1984D58", VA = "0x1984D58")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1984E34", Offset = "0x1984E34", VA = "0x1984E34")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1984EFC", Offset = "0x1984EFC", VA = "0x1984EFC")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1985640", Offset = "0x1985640", VA = "0x1985640")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD544C", Offset = "0xCD544C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD544C", Offset = "0xCD544C")]
		public float weight;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD54A0", Offset = "0xCD54A0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700006D")]
		public bool initiated
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x1985650", Offset = "0x1985650", VA = "0x1985650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD220", Offset = "0xCDD220")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x1985658", Offset = "0x1985658", VA = "0x1985658")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD230", Offset = "0xCDD230")]
			private set
			{
			}
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1985664", Offset = "0x1985664", VA = "0x1985664")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x19856EC", Offset = "0x19856EC", VA = "0x19856EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD240", Offset = "0xCDD240")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1985A10", Offset = "0x1985A10", VA = "0x1985A10")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1985B80", Offset = "0x1985B80", VA = "0x1985B80")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1985908", Offset = "0x1985908", VA = "0x1985908")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1985CE8", Offset = "0x1985CE8", VA = "0x1985CE8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1985DA8", Offset = "0x1985DA8", VA = "0x1985DA8")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1985E20", Offset = "0x1985E20", VA = "0x1985E20")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1985E94", Offset = "0x1985E94", VA = "0x1985E94")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1985EFC", Offset = "0x1985EFC", VA = "0x1985EFC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1985F00", Offset = "0x1985F00", VA = "0x1985F00", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1985F14", Offset = "0x1985F14", VA = "0x1985F14")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200012D")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD54B0", Offset = "0xCD54B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD54B0", Offset = "0xCD54B0")]
		public float weight;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5504", Offset = "0xCD5504")]
		public Grounding solver;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD553C", Offset = "0xCD553C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700006E")]
		public bool initiated
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x1986F48", Offset = "0x1986F48", VA = "0x1986F48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD278", Offset = "0xCDD278")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x1986F50", Offset = "0x1986F50", VA = "0x1986F50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD288", Offset = "0xCDD288")]
			protected set
			{
			}
		}

		[Token(Token = "0x60002A1")]
		public abstract void ResetPosition();

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1986F5C", Offset = "0x1986F5C", VA = "0x1986F5C")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1987230", Offset = "0x1987230", VA = "0x1987230")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x19870A0", Offset = "0x19870A0", VA = "0x19870A0")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1987264", Offset = "0x1987264", VA = "0x1987264")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A8")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60002A9")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x198746C", Offset = "0x198746C", VA = "0x198746C")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD236C", Offset = "0xCD236C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD236C", Offset = "0xCD236C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD554C", Offset = "0xCD554C")]
		public BipedIK ik;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5584", Offset = "0xCD5584")]
		public float spineBend;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD55BC", Offset = "0xCD55BC")]
		public float spineSpeed;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x19877D4", Offset = "0x19877D4", VA = "0x19877D4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD298", Offset = "0xCDD298")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1987820", Offset = "0x1987820", VA = "0x1987820", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD2D0", Offset = "0xCDD2D0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x198786C", Offset = "0x198786C", VA = "0x198786C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1987974", Offset = "0x1987974", VA = "0x1987974")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1987A24", Offset = "0x1987A24", VA = "0x1987A24")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1987AD8", Offset = "0x1987AD8", VA = "0x1987AD8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1987FEC", Offset = "0x1987FEC", VA = "0x1987FEC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1988040", Offset = "0x1988040", VA = "0x1988040")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x19887F8", Offset = "0x19887F8", VA = "0x19887F8")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1988958", Offset = "0x1988958", VA = "0x1988958")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1988AE8", Offset = "0x1988AE8", VA = "0x1988AE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1988C58", Offset = "0x1988C58", VA = "0x1988C58")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD23CC", Offset = "0xCD23CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD23CC", Offset = "0xCD23CC")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200012E")]
		public class SpineEffector
		{
			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9410", Offset = "0xCD9410")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9448", Offset = "0xCD9448")]
			public float horizontalWeight;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9480", Offset = "0xCD9480")]
			public float verticalWeight;

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x1989AC0", Offset = "0x1989AC0", VA = "0x1989AC0")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x1989AD0", Offset = "0x1989AD0", VA = "0x1989AD0")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD55F4", Offset = "0xCD55F4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD562C", Offset = "0xCD562C")]
		public float spineBend;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5664", Offset = "0xCD5664")]
		public float spineSpeed;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1988CD8", Offset = "0x1988CD8", VA = "0x1988CD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD308", Offset = "0xCDD308")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1988D24", Offset = "0x1988D24", VA = "0x1988D24", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD340", Offset = "0xCDD340")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1988D70", Offset = "0x1988D70", VA = "0x1988D70", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD378", Offset = "0xCDD378")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1988DBC", Offset = "0x1988DBC", VA = "0x1988DBC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1988E3C", Offset = "0x1988E3C", VA = "0x1988E3C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1988ED4", Offset = "0x1988ED4", VA = "0x1988ED4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1989190", Offset = "0x1989190", VA = "0x1989190")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x198919C", Offset = "0x198919C", VA = "0x198919C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1988F90", Offset = "0x1988F90", VA = "0x1988F90")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x19891A8", Offset = "0x19891A8", VA = "0x19891A8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1989648", Offset = "0x1989648", VA = "0x1989648")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1989808", Offset = "0x1989808", VA = "0x1989808")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1989940", Offset = "0x1989940", VA = "0x1989940")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1989A40", Offset = "0x1989A40", VA = "0x1989A40")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD242C", Offset = "0xCD242C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD242C", Offset = "0xCD242C")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD569C", Offset = "0xCD569C")]
		public Transform pelvis;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD56D4", Offset = "0xCD56D4")]
		public Transform characterRoot;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD570C", Offset = "0xCD570C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD570C", Offset = "0xCD570C")]
		public float rootRotationWeight;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5760", Offset = "0xCD5760")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5798", Offset = "0xCD5798")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1989B18", Offset = "0x1989B18", VA = "0x1989B18", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD3B0", Offset = "0xCDD3B0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1989B64", Offset = "0x1989B64", VA = "0x1989B64", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD3E8", Offset = "0xCDD3E8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1989BB0", Offset = "0x1989BB0", VA = "0x1989BB0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1989BC8", Offset = "0x1989BC8", VA = "0x1989BC8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1989DB8", Offset = "0x1989DB8", VA = "0x1989DB8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1989EB8", Offset = "0x1989EB8", VA = "0x1989EB8")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x198A600", Offset = "0x198A600", VA = "0x198A600")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x198A9E4", Offset = "0x198A9E4", VA = "0x198A9E4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x198AC54", Offset = "0x198AC54", VA = "0x198AC54")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x198AF74", Offset = "0x198AF74", VA = "0x198AF74")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x198B110", Offset = "0x198B110", VA = "0x198B110")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x198B2D8", Offset = "0x198B2D8", VA = "0x198B2D8")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD248C", Offset = "0xCD248C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD248C", Offset = "0xCD248C")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200012F")]
		public struct Foot
		{
			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x198BE54", Offset = "0x198BE54", VA = "0x198BE54")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD57D0", Offset = "0xCD57D0")]
		public Grounding forelegSolver;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5808", Offset = "0xCD5808")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD5808", Offset = "0xCD5808")]
		public float rootRotationWeight;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD585C", Offset = "0xCD585C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD585C", Offset = "0xCD585C")]
		public float minRootRotation;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD58B4", Offset = "0xCD58B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD58B4", Offset = "0xCD58B4")]
		public float maxRootRotation;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD590C", Offset = "0xCD590C")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5944", Offset = "0xCD5944")]
		public float maxLegOffset;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD597C", Offset = "0xCD597C")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD59B4", Offset = "0xCD59B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD59B4", Offset = "0xCD59B4")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5A08", Offset = "0xCD5A08")]
		public Transform characterRoot;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5A40", Offset = "0xCD5A40")]
		public Transform pelvis;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5A78", Offset = "0xCD5A78")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5AB0", Offset = "0xCD5AB0")]
		public Transform head;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x198B358", Offset = "0x198B358", VA = "0x198B358", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD420", Offset = "0xCDD420")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x198B3A4", Offset = "0x198B3A4", VA = "0x198B3A4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD458", Offset = "0xCDD458")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x198B3F0", Offset = "0x198B3F0", VA = "0x198B3F0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x198B424", Offset = "0x198B424", VA = "0x198B424")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x198B554", Offset = "0x198B554", VA = "0x198B554")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x198B714", Offset = "0x198B714", VA = "0x198B714")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x198B77C", Offset = "0x198B77C", VA = "0x198B77C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x198B834", Offset = "0x198B834", VA = "0x198B834")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x198BB34", Offset = "0x198BB34", VA = "0x198BB34")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x198BE94", Offset = "0x198BE94", VA = "0x198BE94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x198BFE0", Offset = "0x198BFE0", VA = "0x198BFE0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x198C484", Offset = "0x198C484", VA = "0x198C484")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x198CC74", Offset = "0x198CC74", VA = "0x198CC74")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x198CF34", Offset = "0x198CF34", VA = "0x198CF34")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x198D094", Offset = "0x198D094", VA = "0x198D094")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x198D370", Offset = "0x198D370", VA = "0x198D370")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x198D3A8", Offset = "0x198D3A8", VA = "0x198D3A8")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x198D568", Offset = "0x198D568", VA = "0x198D568")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD24EC", Offset = "0xCD24EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD24EC", Offset = "0xCD24EC")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5AF8", Offset = "0xCD5AF8")]
		public VRIK ik;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x198D680", Offset = "0x198D680", VA = "0x198D680")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD490", Offset = "0xCDD490")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x198D6CC", Offset = "0x198D6CC", VA = "0x198D6CC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD4C8", Offset = "0xCDD4C8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x198D718", Offset = "0x198D718", VA = "0x198D718", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD500", Offset = "0xCDD500")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x198D764", Offset = "0x198D764", VA = "0x198D764", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x198D77C", Offset = "0x198D77C", VA = "0x198D77C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x198D814", Offset = "0x198D814", VA = "0x198D814")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x198D8C8", Offset = "0x198D8C8", VA = "0x198D8C8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x198DAC8", Offset = "0x198DAC8", VA = "0x198DAC8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x198DD5C", Offset = "0x198DD5C", VA = "0x198DD5C")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x198DE64", Offset = "0x198DE64", VA = "0x198DE64")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x198E064", Offset = "0x198E064", VA = "0x198E064")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x198E19C", Offset = "0x198E19C", VA = "0x198E19C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x198E2FC", Offset = "0x198E2FC", VA = "0x198E2FC")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000130")]
		public enum Quality
		{
			[Token(Token = "0x40007C2")]
			Fastest,
			[Token(Token = "0x40007C3")]
			Simple,
			[Token(Token = "0x40007C4")]
			Best
		}

		[Token(Token = "0x2000131")]
		public class Leg
		{
			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD94B8", Offset = "0xCD94B8")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD94C8", Offset = "0xCD94C8")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD94D8", Offset = "0xCD94D8")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD94E8", Offset = "0xCD94E8")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD94F8", Offset = "0xCD94F8")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD9508", Offset = "0xCD9508")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD9518", Offset = "0xCD9518")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD9528", Offset = "0xCD9528")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD9538", Offset = "0xCD9538")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000102")]
			public bool isGrounded
			{
				[Token(Token = "0x60008A1")]
				[Address(RVA = "0x198F83C", Offset = "0x198F83C", VA = "0x198F83C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF7B8", Offset = "0xCDF7B8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60008A2")]
				[Address(RVA = "0x198F844", Offset = "0x198F844", VA = "0x198F844")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF7C8", Offset = "0xCDF7C8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000103")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60008A3")]
				[Address(RVA = "0x198F850", Offset = "0x198F850", VA = "0x198F850")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF7D8", Offset = "0xCDF7D8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008A4")]
				[Address(RVA = "0x198F85C", Offset = "0x198F85C", VA = "0x198F85C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF7E8", Offset = "0xCDF7E8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000104")]
			public bool initiated
			{
				[Token(Token = "0x60008A5")]
				[Address(RVA = "0x198F868", Offset = "0x198F868", VA = "0x198F868")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF7F8", Offset = "0xCDF7F8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60008A6")]
				[Address(RVA = "0x198F870", Offset = "0x198F870", VA = "0x198F870")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF808", Offset = "0xCDF808")]
				private set
				{
				}
			}

			[Token(Token = "0x17000105")]
			public float heightFromGround
			{
				[Token(Token = "0x60008A7")]
				[Address(RVA = "0x198F87C", Offset = "0x198F87C", VA = "0x198F87C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF818", Offset = "0xCDF818")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008A8")]
				[Address(RVA = "0x198F884", Offset = "0x198F884", VA = "0x198F884")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF828", Offset = "0xCDF828")]
				private set
				{
				}
			}

			[Token(Token = "0x17000106")]
			public Vector3 velocity
			{
				[Token(Token = "0x60008A9")]
				[Address(RVA = "0x198F88C", Offset = "0x198F88C", VA = "0x198F88C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF838", Offset = "0xCDF838")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008AA")]
				[Address(RVA = "0x198F898", Offset = "0x198F898", VA = "0x198F898")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF848", Offset = "0xCDF848")]
				private set
				{
				}
			}

			[Token(Token = "0x17000107")]
			public Transform transform
			{
				[Token(Token = "0x60008AB")]
				[Address(RVA = "0x198F8A4", Offset = "0x198F8A4", VA = "0x198F8A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF858", Offset = "0xCDF858")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008AC")]
				[Address(RVA = "0x198F8AC", Offset = "0x198F8AC", VA = "0x198F8AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF868", Offset = "0xCDF868")]
				private set
				{
				}
			}

			[Token(Token = "0x17000108")]
			public float IKOffset
			{
				[Token(Token = "0x60008AD")]
				[Address(RVA = "0x198F8B4", Offset = "0x198F8B4", VA = "0x198F8B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF878", Offset = "0xCDF878")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008AE")]
				[Address(RVA = "0x198F8BC", Offset = "0x198F8BC", VA = "0x198F8BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF888", Offset = "0xCDF888")]
				private set
				{
				}
			}

			[Token(Token = "0x17000109")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60008AF")]
				[Address(RVA = "0x198F8C4", Offset = "0x198F8C4", VA = "0x198F8C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF898", Offset = "0xCDF898")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60008B0")]
				[Address(RVA = "0x198F8DC", Offset = "0x198F8DC", VA = "0x198F8DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF8A8", Offset = "0xCDF8A8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60008B1")]
				[Address(RVA = "0x198F8FC", Offset = "0x198F8FC", VA = "0x198F8FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF8B8", Offset = "0xCDF8B8")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60008B2")]
				[Address(RVA = "0x198F914", Offset = "0x198F914", VA = "0x198F914")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF8C8", Offset = "0xCDF8C8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60008B3")]
				[Address(RVA = "0x198F934", Offset = "0x198F934", VA = "0x198F934")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700010C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60008B9")]
				[Address(RVA = "0x19906F0", Offset = "0x19906F0", VA = "0x19906F0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700010D")]
			private float rootYOffset
			{
				[Token(Token = "0x60008C2")]
				[Address(RVA = "0x19909C8", Offset = "0x19909C8", VA = "0x19909C8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x198F97C", Offset = "0x198F97C", VA = "0x198F97C")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x198E98C", Offset = "0x198E98C", VA = "0x198E98C")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x198F990", Offset = "0x198F990", VA = "0x198F990")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x198F35C", Offset = "0x198F35C", VA = "0x198F35C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x198EA88", Offset = "0x198EA88", VA = "0x198EA88")]
			public void Process()
			{
			}

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x1990168", Offset = "0x1990168", VA = "0x1990168")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x198F9DC", Offset = "0x198F9DC", VA = "0x198F9DC")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x1990870", Offset = "0x1990870", VA = "0x1990870")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x198FE14", Offset = "0x198FE14", VA = "0x198FE14")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x198FF1C", Offset = "0x198FF1C", VA = "0x198FF1C")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x199096C", Offset = "0x199096C", VA = "0x199096C")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x199077C", Offset = "0x199077C", VA = "0x199077C")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x1990AF0", Offset = "0x1990AF0", VA = "0x1990AF0")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x198E8E4", Offset = "0x198E8E4", VA = "0x198E8E4")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000132")]
		public class Pelvis
		{
			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD9548", Offset = "0xCD9548")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD9558", Offset = "0xCD9558")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700010E")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60008C4")]
				[Address(RVA = "0x1E643E8", Offset = "0x1E643E8", VA = "0x1E643E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF8D8", Offset = "0xCDF8D8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008C5")]
				[Address(RVA = "0x1E643F4", Offset = "0x1E643F4", VA = "0x1E643F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF8E8", Offset = "0xCDF8E8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010F")]
			public float heightOffset
			{
				[Token(Token = "0x60008C6")]
				[Address(RVA = "0x1E64400", Offset = "0x1E64400", VA = "0x1E64400")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF8F8", Offset = "0xCDF8F8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008C7")]
				[Address(RVA = "0x1E64408", Offset = "0x1E64408", VA = "0x1E64408")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF908", Offset = "0xCDF908")]
				private set
				{
				}
			}

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x1E64410", Offset = "0x1E64410", VA = "0x1E64410")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x1E64480", Offset = "0x1E64480", VA = "0x1E64480")]
			public void Reset()
			{
			}

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x1E64420", Offset = "0x1E64420", VA = "0x1E64420")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x1E64530", Offset = "0x1E64530", VA = "0x1E64530")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x1E6477C", Offset = "0x1E6477C", VA = "0x1E6477C")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5B30", Offset = "0xCD5B30")]
		public LayerMask layers;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5B68", Offset = "0xCD5B68")]
		public float maxStep;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5BA0", Offset = "0xCD5BA0")]
		public float heightOffset;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5BD8", Offset = "0xCD5BD8")]
		public float footSpeed;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5C10", Offset = "0xCD5C10")]
		public float footRadius;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5C48", Offset = "0xCD5C48")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5C94", Offset = "0xCD5C94")]
		public float prediction;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5CCC", Offset = "0xCD5CCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD5CCC", Offset = "0xCD5CCC")]
		public float footRotationWeight;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5D20", Offset = "0xCD5D20")]
		public float footRotationSpeed;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5D58", Offset = "0xCD5D58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD5D58", Offset = "0xCD5D58")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5DB0", Offset = "0xCD5DB0")]
		public bool rotateSolver;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5DE8", Offset = "0xCD5DE8")]
		public float pelvisSpeed;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5E20", Offset = "0xCD5E20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD5E20", Offset = "0xCD5E20")]
		public float pelvisDamper;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5E74", Offset = "0xCD5E74")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5EAC", Offset = "0xCD5EAC")]
		public float liftPelvisWeight;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5EE4", Offset = "0xCD5EE4")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5F1C", Offset = "0xCD5F1C")]
		public bool overstepFallsDown;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5F54", Offset = "0xCD5F54")]
		public Quality quality;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD5F8C", Offset = "0xCD5F8C")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD5F9C", Offset = "0xCD5F9C")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD5FAC", Offset = "0xCD5FAC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD5FBC", Offset = "0xCD5FBC")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD5FCC", Offset = "0xCD5FCC")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700006F")]
		public Leg[] legs
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x198E358", Offset = "0x198E358", VA = "0x198E358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD538", Offset = "0xCDD538")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x198E360", Offset = "0x198E360", VA = "0x198E360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD548", Offset = "0xCDD548")]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x198E368", Offset = "0x198E368", VA = "0x198E368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD558", Offset = "0xCDD558")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x198E370", Offset = "0x198E370", VA = "0x198E370")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD568", Offset = "0xCDD568")]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool isGrounded
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x198E378", Offset = "0x198E378", VA = "0x198E378")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD578", Offset = "0xCDD578")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x198E380", Offset = "0x198E380", VA = "0x198E380")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD588", Offset = "0xCDD588")]
			private set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public Transform root
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x198E38C", Offset = "0x198E38C", VA = "0x198E38C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD598", Offset = "0xCDD598")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x198E394", Offset = "0x198E394", VA = "0x198E394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD5A8", Offset = "0xCDD5A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x198E39C", Offset = "0x198E39C", VA = "0x198E39C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD5B8", Offset = "0xCDD5B8")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x198E3B4", Offset = "0x198E3B4", VA = "0x198E3B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDD5C8", Offset = "0xCDD5C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public bool rootGrounded
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x198E3D4", Offset = "0x198E3D4", VA = "0x198E3D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		public Vector3 up
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x19888CC", Offset = "0x19888CC", VA = "0x19888CC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000076")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x198F410", Offset = "0x198F410", VA = "0x198F410")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x198E428", Offset = "0x198E428", VA = "0x198E428")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x198E808", Offset = "0x198E808", VA = "0x198E808")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1987D8C", Offset = "0x1987D8C", VA = "0x1987D8C")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x198858C", Offset = "0x198858C", VA = "0x198858C")]
		public void Update()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x198A3E8", Offset = "0x198A3E8", VA = "0x198A3E8")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x19878EC", Offset = "0x19878EC", VA = "0x19878EC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x198EA70", Offset = "0x198EA70", VA = "0x198EA70")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x198F4E0", Offset = "0x198F4E0", VA = "0x198F4E0")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x198F648", Offset = "0x198F648", VA = "0x198F648")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x198F74C", Offset = "0x198F74C", VA = "0x198F74C")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x198752C", Offset = "0x198752C", VA = "0x198752C")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD254C", Offset = "0xCD254C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD254C", Offset = "0xCD254C")]
	public class AimIK : IK
	{
		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x197A548", Offset = "0x197A548", VA = "0x197A548", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD5D8", Offset = "0xCDD5D8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x197A594", Offset = "0x197A594", VA = "0x197A594", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD610", Offset = "0xCDD610")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x197A5E0", Offset = "0x197A5E0", VA = "0x197A5E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD648", Offset = "0xCDD648")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x197A62C", Offset = "0x197A62C", VA = "0x197A62C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD680", Offset = "0xCDD680")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x197A678", Offset = "0x197A678", VA = "0x197A678")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD6B8", Offset = "0xCDD6B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x197A6C4", Offset = "0x197A6C4", VA = "0x197A6C4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x197A6CC", Offset = "0x197A6CC", VA = "0x197A6CC")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD25AC", Offset = "0xCD25AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD25AC", Offset = "0xCD25AC")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x197B17C", Offset = "0x197B17C", VA = "0x197B17C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD6F0", Offset = "0xCDD6F0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x197B1C8", Offset = "0x197B1C8", VA = "0x197B1C8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD728", Offset = "0xCDD728")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x197B214", Offset = "0x197B214", VA = "0x197B214")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD760", Offset = "0xCDD760")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x197B260", Offset = "0x197B260", VA = "0x197B260")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD798", Offset = "0xCDD798")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x197B2AC", Offset = "0x197B2AC", VA = "0x197B2AC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x197B2B4", Offset = "0x197B2B4", VA = "0x197B2B4")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD260C", Offset = "0xCD260C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD260C", Offset = "0xCD260C")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x197C914", Offset = "0x197C914", VA = "0x197C914", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD7D0", Offset = "0xCDD7D0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x197C960", Offset = "0x197C960", VA = "0x197C960", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD808", Offset = "0xCDD808")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x197C9AC", Offset = "0x197C9AC", VA = "0x197C9AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD840", Offset = "0xCDD840")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x197C9F8", Offset = "0x197C9F8", VA = "0x197C9F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD878", Offset = "0xCDD878")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x197CA44", Offset = "0x197CA44", VA = "0x197CA44", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x197CA4C", Offset = "0x197CA4C", VA = "0x197CA4C")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD266C", Offset = "0xCD266C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD266C", Offset = "0xCD266C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x197D4D4", Offset = "0x197D4D4", VA = "0x197D4D4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD8B0", Offset = "0xCDD8B0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x197D520", Offset = "0x197D520", VA = "0x197D520", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD8E8", Offset = "0xCDD8E8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x197D56C", Offset = "0x197D56C", VA = "0x197D56C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD920", Offset = "0xCDD920")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x197D5B8", Offset = "0x197D5B8", VA = "0x197D5B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD958", Offset = "0xCDD958")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x197D604", Offset = "0x197D604", VA = "0x197D604", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x197D60C", Offset = "0x197D60C", VA = "0x197D60C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD26CC", Offset = "0xCD26CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD26CC", Offset = "0xCD26CC")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x197DC8C", Offset = "0x197DC8C", VA = "0x197DC8C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD990", Offset = "0xCDD990")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x197DCD8", Offset = "0x197DCD8", VA = "0x197DCD8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDD9C8", Offset = "0xCDD9C8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x197DD24", Offset = "0x197DD24", VA = "0x197DD24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDA00", Offset = "0xCDDA00")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x197DD70", Offset = "0x197DD70", VA = "0x197DD70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDA38", Offset = "0xCDDA38")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x197DDBC", Offset = "0x197DDBC", VA = "0x197DDBC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x197DDC4", Offset = "0x197DDC4", VA = "0x197DDC4")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD272C", Offset = "0xCD272C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD272C", Offset = "0xCD272C")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1985F7C", Offset = "0x1985F7C", VA = "0x1985F7C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDA70", Offset = "0xCDDA70")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1985FC8", Offset = "0x1985FC8", VA = "0x1985FC8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDAA8", Offset = "0xCDDAA8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1986014", Offset = "0x1986014", VA = "0x1986014")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDAE0", Offset = "0xCDDAE0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1986060", Offset = "0x1986060", VA = "0x1986060")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDB18", Offset = "0xCDDB18")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x19860AC", Offset = "0x19860AC", VA = "0x19860AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDB50", Offset = "0xCDDB50")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x19860F8", Offset = "0x19860F8", VA = "0x19860F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDB88", Offset = "0xCDDB88")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1986144", Offset = "0x1986144", VA = "0x1986144")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1986168", Offset = "0x1986168", VA = "0x1986168", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1986170", Offset = "0x1986170", VA = "0x1986170")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x198632C", Offset = "0x198632C", VA = "0x198632C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1986680", Offset = "0x1986680", VA = "0x1986680")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDBC0", Offset = "0xCDDBC0")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x19866A0", Offset = "0x19866A0", VA = "0x19866A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDBF8", Offset = "0xCDDBF8")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x198677C", Offset = "0x198677C", VA = "0x198677C")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000334")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1E67348", Offset = "0x1E67348", VA = "0x1E67348", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1E67434", Offset = "0x1E67434", VA = "0x1E67434", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1E675F0", Offset = "0x1E675F0", VA = "0x1E675F0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000338")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000339")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1E67650", Offset = "0x1E67650", VA = "0x1E67650")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD5FDC", Offset = "0xCD5FDC")]
		public IK[] IKComponents;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6014", Offset = "0xCD6014")]
		public Animator animator;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000077")]
		private bool animatePhysics
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x1E6A5E4", Offset = "0x1E6A5E4", VA = "0x1E6A5E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1E6A680", Offset = "0x1E6A680", VA = "0x1E6A680")]
		private void Start()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1E6A6F0", Offset = "0x1E6A6F0", VA = "0x1E6A6F0")]
		private void Update()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1E6A7AC", Offset = "0x1E6A7AC", VA = "0x1E6A7AC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1E6A7E8", Offset = "0x1E6A7E8", VA = "0x1E6A7E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1E6A724", Offset = "0x1E6A724", VA = "0x1E6A724")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1E6A874", Offset = "0x1E6A874", VA = "0x1E6A874")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD278C", Offset = "0xCD278C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD278C", Offset = "0xCD278C")]
	public class LegIK : IK
	{
		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1A96E74", Offset = "0x1A96E74", VA = "0x1A96E74", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDC30", Offset = "0xCDDC30")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1A96EC0", Offset = "0x1A96EC0", VA = "0x1A96EC0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDC68", Offset = "0xCDDC68")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1A96F0C", Offset = "0x1A96F0C", VA = "0x1A96F0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDCA0", Offset = "0xCDDCA0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1A96F58", Offset = "0x1A96F58", VA = "0x1A96F58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDCD8", Offset = "0xCDDCD8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1A96FA4", Offset = "0x1A96FA4", VA = "0x1A96FA4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1A96FAC", Offset = "0x1A96FAC", VA = "0x1A96FAC")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD27EC", Offset = "0xCD27EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD27EC", Offset = "0xCD27EC")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1A97014", Offset = "0x1A97014", VA = "0x1A97014", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDD10", Offset = "0xCDDD10")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1A97060", Offset = "0x1A97060", VA = "0x1A97060", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDD48", Offset = "0xCDDD48")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1A970AC", Offset = "0x1A970AC", VA = "0x1A970AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDD80", Offset = "0xCDDD80")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1A970F8", Offset = "0x1A970F8", VA = "0x1A970F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDDB8", Offset = "0xCDDDB8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1A97144", Offset = "0x1A97144", VA = "0x1A97144", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1A9714C", Offset = "0x1A9714C", VA = "0x1A9714C")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD284C", Offset = "0xCD284C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD284C", Offset = "0xCD284C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1A971B4", Offset = "0x1A971B4", VA = "0x1A971B4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDDF0", Offset = "0xCDDDF0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1A97200", Offset = "0x1A97200", VA = "0x1A97200", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDE28", Offset = "0xCDDE28")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1A9724C", Offset = "0x1A9724C", VA = "0x1A9724C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDE60", Offset = "0xCDDE60")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1A97298", Offset = "0x1A97298", VA = "0x1A97298")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDE98", Offset = "0xCDDE98")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1A972E4", Offset = "0x1A972E4", VA = "0x1A972E4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1A972EC", Offset = "0x1A972EC", VA = "0x1A972EC")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD28AC", Offset = "0xCD28AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD28AC", Offset = "0xCD28AC")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1A9FB14", Offset = "0x1A9FB14", VA = "0x1A9FB14", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDED0", Offset = "0xCDDED0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1A9FB60", Offset = "0x1A9FB60", VA = "0x1A9FB60", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDF08", Offset = "0xCDDF08")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1A9FBAC", Offset = "0x1A9FBAC", VA = "0x1A9FBAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDF40", Offset = "0xCDDF40")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1A9FBF8", Offset = "0x1A9FBF8", VA = "0x1A9FBF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDF78", Offset = "0xCDDF78")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1A9FC44", Offset = "0x1A9FC44", VA = "0x1A9FC44", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1A9FC4C", Offset = "0x1A9FC4C", VA = "0x1A9FC4C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD290C", Offset = "0xCD290C")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000133")]
		public class References
		{
			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9568", Offset = "0xCD9568")]
			public Transform chest;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD95A0", Offset = "0xCD95A0")]
			public Transform neck;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD95D8", Offset = "0xCD95D8")]
			public Transform leftShoulder;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9610", Offset = "0xCD9610")]
			public Transform rightShoulder;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9648", Offset = "0xCD9648")]
			public Transform leftThigh;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9680", Offset = "0xCD9680")]
			public Transform leftCalf;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD96B8", Offset = "0xCD96B8")]
			public Transform leftFoot;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD96F0", Offset = "0xCD96F0")]
			public Transform leftToes;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9728", Offset = "0xCD9728")]
			public Transform rightThigh;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9760", Offset = "0xCD9760")]
			public Transform rightCalf;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9798", Offset = "0xCD9798")]
			public Transform rightFoot;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD97D0", Offset = "0xCD97D0")]
			public Transform rightToes;

			[Token(Token = "0x17000110")]
			public bool isFilled
			{
				[Token(Token = "0x60008CE")]
				[Address(RVA = "0x1AA114C", Offset = "0x1AA114C", VA = "0x1AA114C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000111")]
			public bool isEmpty
			{
				[Token(Token = "0x60008CF")]
				[Address(RVA = "0x1AA0CD0", Offset = "0x1AA0CD0", VA = "0x1AA0CD0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x1AA17D0", Offset = "0x1AA17D0", VA = "0x1AA17D0")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x1AA08BC", Offset = "0x1AA08BC", VA = "0x1AA08BC")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x1AA17C8", Offset = "0x1AA17C8", VA = "0x1AA17C8")]
			public References()
			{
			}
		}

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0xCD604C", Offset = "0xCD604C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD604C", Offset = "0xCD604C")]
		public References references;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD60C8", Offset = "0xCD60C8")]
		public IKSolverVR solver;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1AA07B0", Offset = "0x1AA07B0", VA = "0x1AA07B0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDFB0", Offset = "0xCDDFB0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1AA07FC", Offset = "0x1AA07FC", VA = "0x1AA07FC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDDFE8", Offset = "0xCDDFE8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1AA0848", Offset = "0x1AA0848", VA = "0x1AA0848")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE020", Offset = "0xCDE020")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1AA0894", Offset = "0x1AA0894", VA = "0x1AA0894")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE058", Offset = "0xCDE058")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1AA0C2C", Offset = "0x1AA0C2C", VA = "0x1AA0C2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE090", Offset = "0xCDE090")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1AA0C54", Offset = "0x1AA0C54", VA = "0x1AA0C54", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1AA0C5C", Offset = "0x1AA0C5C", VA = "0x1AA0C5C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1AA15C8", Offset = "0x1AA15C8", VA = "0x1AA15C8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1AA1740", Offset = "0x1AA1740", VA = "0x1AA1740")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class FABRIKChain
	{
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6100", Offset = "0xCD6100")]
		public float pull;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6118", Offset = "0xCD6118")]
		public float pin;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x197D674", Offset = "0x197D674", VA = "0x197D674")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x197D73C", Offset = "0x197D73C", VA = "0x197D73C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x197D75C", Offset = "0x197D75C", VA = "0x197D75C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x197DB2C", Offset = "0x197DB2C", VA = "0x197DB2C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x197D830", Offset = "0x197D830", VA = "0x197D830")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x197DC24", Offset = "0x197DC24", VA = "0x197DC24")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x197DE2C", Offset = "0x197DE2C", VA = "0x197DE2C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x197E394", Offset = "0x197E394", VA = "0x197E394")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x197E554", Offset = "0x197E554", VA = "0x197E554")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x197E64C", Offset = "0x197E64C", VA = "0x197E64C")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000134")]
		public class BendBone
		{
			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9808", Offset = "0xCD9808")]
			public Transform transform;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9840", Offset = "0xCD9840")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD9840", Offset = "0xCD9840")]
			public float weight;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x198167C", Offset = "0x198167C", VA = "0x198167C")]
			public BendBone()
			{
			}

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x19816FC", Offset = "0x19816FC", VA = "0x19816FC")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x197EE0C", Offset = "0x197EE0C", VA = "0x197EE0C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x197F210", Offset = "0x197F210", VA = "0x197F210")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6130", Offset = "0xCD6130")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCD6168", Offset = "0xCD6168")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6168", Offset = "0xCD6168")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6168", Offset = "0xCD6168")]
		public float positionWeight;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD61E0", Offset = "0xCD61E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD61E0", Offset = "0xCD61E0")]
		public float bodyWeight;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6234", Offset = "0xCD6234")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6234", Offset = "0xCD6234")]
		public float thighWeight;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6288", Offset = "0xCD6288")]
		public bool handsPullBody;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCD62C0", Offset = "0xCD62C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD62C0", Offset = "0xCD62C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD62C0", Offset = "0xCD62C0")]
		public float rotationWeight;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6338", Offset = "0xCD6338")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6338", Offset = "0xCD6338")]
		public float bodyClampWeight;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD638C", Offset = "0xCD638C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD638C", Offset = "0xCD638C")]
		public float headClampWeight;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD63E0", Offset = "0xCD63E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD63E0", Offset = "0xCD63E0")]
		public float bendWeight;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6434", Offset = "0xCD6434")]
		public BendBone[] bendBones;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCD646C", Offset = "0xCD646C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD646C", Offset = "0xCD646C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD646C", Offset = "0xCD646C")]
		public float CCDWeight;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD64E4", Offset = "0xCD64E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD64E4", Offset = "0xCD64E4")]
		public float roll;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6538", Offset = "0xCD6538")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6538", Offset = "0xCD6538")]
		public float damper;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6590", Offset = "0xCD6590")]
		public Transform[] CCDBones;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCD65C8", Offset = "0xCD65C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD65C8", Offset = "0xCD65C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD65C8", Offset = "0xCD65C8")]
		public float postStretchWeight;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6640", Offset = "0xCD6640")]
		public float maxStretch;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6678", Offset = "0xCD6678")]
		public float stretchDamper;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD66B0", Offset = "0xCD66B0")]
		public bool fixHead;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD66E8", Offset = "0xCD66E8")]
		public Transform[] stretchBones;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCD6720", Offset = "0xCD6720")]
		public Vector3 chestDirection;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6758", Offset = "0xCD6758")]
		public float chestDirectionWeight;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x197E654", Offset = "0x197E654", VA = "0x197E654")]
		private void Start()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x197E984", Offset = "0x197E984", VA = "0x197E984")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x197EE44", Offset = "0x197EE44", VA = "0x197EE44")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x197F238", Offset = "0x197F238", VA = "0x197F238")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x197FBB0", Offset = "0x197FBB0", VA = "0x197FBB0")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x197FEFC", Offset = "0x197FEFC", VA = "0x197FEFC")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1980298", Offset = "0x1980298", VA = "0x1980298")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1980D04", Offset = "0x1980D04", VA = "0x1980D04")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x197F8DC", Offset = "0x197F8DC", VA = "0x197F8DC")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1980F14", Offset = "0x1980F14", VA = "0x1980F14")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1980BC0", Offset = "0x1980BC0", VA = "0x1980BC0")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1980A24", Offset = "0x1980A24", VA = "0x1980A24")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1981280", Offset = "0x1981280", VA = "0x1981280")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1981500", Offset = "0x1981500", VA = "0x1981500")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000135")]
		public class ChildConstraint
		{
			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD98B4", Offset = "0xCD98B4")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD98C4", Offset = "0xCD98C4")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000112")]
			public float nominalDistance
			{
				[Token(Token = "0x60008D6")]
				[Address(RVA = "0x19845C0", Offset = "0x19845C0", VA = "0x19845C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF918", Offset = "0xCDF918")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008D7")]
				[Address(RVA = "0x19845C8", Offset = "0x19845C8", VA = "0x19845C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF928", Offset = "0xCDF928")]
				private set
				{
				}
			}

			[Token(Token = "0x17000113")]
			public bool isRigid
			{
				[Token(Token = "0x60008D8")]
				[Address(RVA = "0x19845D0", Offset = "0x19845D0", VA = "0x19845D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF938", Offset = "0xCDF938")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60008D9")]
				[Address(RVA = "0x19845D8", Offset = "0x19845D8", VA = "0x19845D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF948", Offset = "0xCDF948")]
				private set
				{
				}
			}

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x19845E4", Offset = "0x19845E4", VA = "0x19845E4")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x1982344", Offset = "0x1982344", VA = "0x1982344")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x1982884", Offset = "0x1982884", VA = "0x1982884")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x19842BC", Offset = "0x19842BC", VA = "0x19842BC")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000136")]
		public enum Smoothing
		{
			[Token(Token = "0x4000805")]
			None,
			[Token(Token = "0x4000806")]
			Exponential,
			[Token(Token = "0x4000807")]
			Cubic
		}

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6770", Offset = "0xCD6770")]
		public float pin;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6788", Offset = "0xCD6788")]
		public float pull;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD67A0", Offset = "0xCD67A0")]
		public float push;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD67B8", Offset = "0xCD67B8")]
		public float pushParent;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD67D0", Offset = "0xCD67D0")]
		public float reach;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000313")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x19817A0", Offset = "0x19817A0", VA = "0x19817A0")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x198186C", Offset = "0x198186C", VA = "0x198186C")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1981978", Offset = "0x1981978", VA = "0x1981978")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1981A9C", Offset = "0x1981A9C", VA = "0x1981A9C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1981B78", Offset = "0x1981B78", VA = "0x1981B78")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1981C7C", Offset = "0x1981C7C", VA = "0x1981C7C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x198239C", Offset = "0x198239C", VA = "0x198239C")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1981E0C", Offset = "0x1981E0C", VA = "0x1981E0C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1982A88", Offset = "0x1982A88", VA = "0x1982A88")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1982E2C", Offset = "0x1982E2C", VA = "0x1982E2C")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1983210", Offset = "0x1983210", VA = "0x1983210")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1983794", Offset = "0x1983794", VA = "0x1983794")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1983D64", Offset = "0x1983D64", VA = "0x1983D64")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1983FFC", Offset = "0x1983FFC", VA = "0x1983FFC")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1983C5C", Offset = "0x1983C5C", VA = "0x1983C5C")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x198357C", Offset = "0x198357C", VA = "0x198357C")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1983BE4", Offset = "0x1983BE4", VA = "0x1983BE4")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x19840E4", Offset = "0x19840E4", VA = "0x19840E4")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1983B04", Offset = "0x1983B04", VA = "0x1983B04")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1983EE4", Offset = "0x1983EE4", VA = "0x1983EE4")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD67E8", Offset = "0xCD67E8")]
		public float weight;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD6800", Offset = "0xCD6800")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000078")]
		public bool initiated
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x1E67820", Offset = "0x1E67820", VA = "0x1E67820")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE0C8", Offset = "0xCDE0C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x1E67828", Offset = "0x1E67828", VA = "0x1E67828")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE0D8", Offset = "0xCDE0D8")]
			private set
			{
			}
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1E67658", Offset = "0x1E67658", VA = "0x1E67658")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1E67834", Offset = "0x1E67834", VA = "0x1E67834")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1E678B8", Offset = "0x1E678B8", VA = "0x1E678B8")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1E67964", Offset = "0x1E67964", VA = "0x1E67964")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1E67970", Offset = "0x1E67970", VA = "0x1E67970")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1E67EC4", Offset = "0x1E67EC4", VA = "0x1E67EC4")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1E680FC", Offset = "0x1E680FC", VA = "0x1E680FC")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1E68598", Offset = "0x1E68598", VA = "0x1E68598")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1E67C94", Offset = "0x1E67C94", VA = "0x1E67C94")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1E67DAC", Offset = "0x1E67DAC", VA = "0x1E67DAC")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class IKEffector
	{
		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6810", Offset = "0xCD6810")]
		public float positionWeight;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6828", Offset = "0xCD6828")]
		public float rotationWeight;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD6840", Offset = "0xCD6840")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6850", Offset = "0xCD6850")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000079")]
		public bool isEndEffector
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x1E68C48", Offset = "0x1E68C48", VA = "0x1E68C48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE0E8", Offset = "0xCDE0E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x1E68C50", Offset = "0x1E68C50", VA = "0x1E68C50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE0F8", Offset = "0xCDE0F8")]
			private set
			{
			}
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1E68BE0", Offset = "0x1E68BE0", VA = "0x1E68BE0")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1E68C5C", Offset = "0x1E68C5C", VA = "0x1E68C5C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1E68D30", Offset = "0x1E68D30", VA = "0x1E68D30")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1E68E6C", Offset = "0x1E68E6C", VA = "0x1E68E6C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1E68FC4", Offset = "0x1E68FC4", VA = "0x1E68FC4")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1E692B4", Offset = "0x1E692B4", VA = "0x1E692B4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1E69540", Offset = "0x1E69540", VA = "0x1E69540")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1E69678", Offset = "0x1E69678", VA = "0x1E69678")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1E69724", Offset = "0x1E69724", VA = "0x1E69724")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1E69D64", Offset = "0x1E69D64", VA = "0x1E69D64")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1E69DD4", Offset = "0x1E69DD4", VA = "0x1E69DD4")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1E69FE0", Offset = "0x1E69FE0", VA = "0x1E69FE0")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1E6A314", Offset = "0x1E6A314", VA = "0x1E6A314")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000137")]
		public class BoneMap
		{
			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000114")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60008DF")]
				[Address(RVA = "0x1E6AAE4", Offset = "0x1E6AAE4", VA = "0x1E6AAE4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000115")]
			public bool isNodeBone
			{
				[Token(Token = "0x60008E2")]
				[Address(RVA = "0x1E6AC50", Offset = "0x1E6AC50", VA = "0x1E6AC50")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000116")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60008F6")]
				[Address(RVA = "0x1E6B228", Offset = "0x1E6B228", VA = "0x1E6B228")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x1E6AABC", Offset = "0x1E6AABC", VA = "0x1E6AABC")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x1E6ABB0", Offset = "0x1E6ABB0", VA = "0x1E6ABB0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x1E6AC00", Offset = "0x1E6AC00", VA = "0x1E6AC00")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x1E6AC60", Offset = "0x1E6AC60", VA = "0x1E6AC60")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x1E6AD48", Offset = "0x1E6AD48", VA = "0x1E6AD48")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x1E6AD50", Offset = "0x1E6AD50", VA = "0x1E6AD50")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x1E6AEE0", Offset = "0x1E6AEE0", VA = "0x1E6AEE0")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x1E6AFEC", Offset = "0x1E6AFEC", VA = "0x1E6AFEC")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x1E6B078", Offset = "0x1E6B078", VA = "0x1E6B078")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x1E6B44C", Offset = "0x1E6B44C", VA = "0x1E6B44C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x1E6B484", Offset = "0x1E6B484", VA = "0x1E6B484")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x1E6B4BC", Offset = "0x1E6B4BC", VA = "0x1E6B4BC")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x1E6B4E4", Offset = "0x1E6B4E4", VA = "0x1E6B4E4")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x1E6B60C", Offset = "0x1E6B60C", VA = "0x1E6B60C")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x1E6B944", Offset = "0x1E6B944", VA = "0x1E6B944")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x1E6B974", Offset = "0x1E6B974", VA = "0x1E6B974")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x1E6BB0C", Offset = "0x1E6BB0C", VA = "0x1E6BB0C")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x1E6BB7C", Offset = "0x1E6BB7C", VA = "0x1E6BB7C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x1E6BDC0", Offset = "0x1E6BDC0", VA = "0x1E6BDC0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x1E6BFE8", Offset = "0x1E6BFE8", VA = "0x1E6BFE8")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x1E6C100", Offset = "0x1E6C100", VA = "0x1E6C100")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x1E6B74C", Offset = "0x1E6B74C", VA = "0x1E6B74C")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x1E6C290", Offset = "0x1E6C290", VA = "0x1E6C290")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1E6A87C", Offset = "0x1E6A87C", VA = "0x1E6A87C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1E6A884", Offset = "0x1E6A884", VA = "0x1E6A884", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1E6A888", Offset = "0x1E6A888", VA = "0x1E6A888")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1E6A9AC", Offset = "0x1E6A9AC", VA = "0x1E6A9AC")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1E6AAB4", Offset = "0x1E6AAB4", VA = "0x1E6AAB4")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6868", Offset = "0xCD6868")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1E6C2AC", Offset = "0x1E6C2AC", VA = "0x1E6C2AC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1E6C34C", Offset = "0x1E6C34C", VA = "0x1E6C34C")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1E6C3D0", Offset = "0x1E6C3D0", VA = "0x1E6C3D0")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1E6C468", Offset = "0x1E6C468", VA = "0x1E6C468")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1E6C480", Offset = "0x1E6C480", VA = "0x1E6C480")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1E6C49C", Offset = "0x1E6C49C", VA = "0x1E6C49C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1E6C538", Offset = "0x1E6C538", VA = "0x1E6C538")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1E6C550", Offset = "0x1E6C550", VA = "0x1E6C550")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000138")]
		public enum BoneMapType
		{
			[Token(Token = "0x400081F")]
			Parent,
			[Token(Token = "0x4000820")]
			Bone1,
			[Token(Token = "0x4000821")]
			Bone2,
			[Token(Token = "0x4000822")]
			Bone3
		}

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6880", Offset = "0xCD6880")]
		public float maintainRotationWeight;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6898", Offset = "0xCD6898")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1E6C574", Offset = "0x1E6C574", VA = "0x1E6C574", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1E6C5F8", Offset = "0x1E6C5F8", VA = "0x1E6C5F8")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1E6C6CC", Offset = "0x1E6C6CC", VA = "0x1E6C6CC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1E6CA20", Offset = "0x1E6CA20", VA = "0x1E6CA20")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1E6CB28", Offset = "0x1E6CB28", VA = "0x1E6CB28")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1E6CC5C", Offset = "0x1E6CC5C", VA = "0x1E6CC5C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1E6CC68", Offset = "0x1E6CC68", VA = "0x1E6CC68")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1E6CD10", Offset = "0x1E6CD10", VA = "0x1E6CD10")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1E6CDC8", Offset = "0x1E6CDC8", VA = "0x1E6CDC8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1E6D038", Offset = "0x1E6D038", VA = "0x1E6D038")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1E6D0F0", Offset = "0x1E6D0F0", VA = "0x1E6D0F0")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD68B0", Offset = "0xCD68B0")]
		public int iterations;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD68C8", Offset = "0xCD68C8")]
		public float twistWeight;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1E6D258", Offset = "0x1E6D258", VA = "0x1E6D258", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1E6D548", Offset = "0x1E6D548", VA = "0x1E6D548")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1E6D664", Offset = "0x1E6D664", VA = "0x1E6D664")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1E6D7BC", Offset = "0x1E6D7BC", VA = "0x1E6D7BC")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1E6D7CC", Offset = "0x1E6D7CC", VA = "0x1E6D7CC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1E6D834", Offset = "0x1E6D834", VA = "0x1E6D834")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1E6D8B4", Offset = "0x1E6D8B4", VA = "0x1E6D8B4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1E6DF08", Offset = "0x1E6DF08", VA = "0x1E6DF08")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1E6DF40", Offset = "0x1E6DF40", VA = "0x1E6DF40")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1E6E220", Offset = "0x1E6E220", VA = "0x1E6E220")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1E6E5CC", Offset = "0x1E6E5CC", VA = "0x1E6E5CC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1E6E6B8", Offset = "0x1E6E6B8", VA = "0x1E6E6B8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1E6E780", Offset = "0x1E6E780", VA = "0x1E6E780")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000139")]
		public class Point
		{
			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD98D4", Offset = "0xCD98D4")]
			public float weight;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x1E7036C", Offset = "0x1E7036C", VA = "0x1E7036C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x1E703BC", Offset = "0x1E703BC", VA = "0x1E703BC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x1E704C4", Offset = "0x1E704C4", VA = "0x1E704C4")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x1E704FC", Offset = "0x1E704FC", VA = "0x1E704FC")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x1E70534", Offset = "0x1E70534", VA = "0x1E70534")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x1E70584", Offset = "0x1E70584", VA = "0x1E70584")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x1E6FE40", Offset = "0x1E6FE40", VA = "0x1E6FE40")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013A")]
		public class Bone : Point
		{
			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000117")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x60008FF")]
				[Address(RVA = "0x1E6F344", Offset = "0x1E6F344", VA = "0x1E6F344")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000900")]
				[Address(RVA = "0x1E6F438", Offset = "0x1E6F438", VA = "0x1E6F438")]
				set
				{
				}
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x1E6F4C0", Offset = "0x1E6F4C0", VA = "0x1E6F4C0")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x1E6F780", Offset = "0x1E6F780", VA = "0x1E6F780")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x1E6FA60", Offset = "0x1E6FA60", VA = "0x1E6FA60")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f, bool xy = true, bool xz = false, bool yz = false)
			{
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0x1E6FD94", Offset = "0x1E6FD94", VA = "0x1E6FD94")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000905")]
			[Address(RVA = "0x1E6FDBC", Offset = "0x1E6FDBC", VA = "0x1E6FDBC")]
			public Bone()
			{
			}

			[Token(Token = "0x6000906")]
			[Address(RVA = "0x1E6FEC0", Offset = "0x1E6FEC0", VA = "0x1E6FEC0")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000907")]
			[Address(RVA = "0x1E6FF58", Offset = "0x1E6FF58", VA = "0x1E6FF58")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013B")]
		public class Node : Point
		{
			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x1E70308", Offset = "0x1E70308", VA = "0x1E70308")]
			public Node()
			{
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0x1E7030C", Offset = "0x1E7030C", VA = "0x1E7030C")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600090A")]
			[Address(RVA = "0x1E70334", Offset = "0x1E70334", VA = "0x1E70334")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x200013C")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200013D")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD68F0", Offset = "0xCD68F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD68F0", Offset = "0xCD68F0")]
		public float IKPositionWeight;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD6944", Offset = "0xCD6944")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x1700007A")]
		public bool initiated
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x1E6ED94", Offset = "0x1E6ED94", VA = "0x1E6ED94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE108", Offset = "0xCDE108")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x1E6ED9C", Offset = "0x1E6ED9C", VA = "0x1E6ED9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE118", Offset = "0xCDE118")]
			private set
			{
			}
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1E6EA60", Offset = "0x1E6EA60", VA = "0x1E6EA60")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D0")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1E674A4", Offset = "0x1E674A4", VA = "0x1E674A4")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1E673CC", Offset = "0x1E673CC", VA = "0x1E673CC")]
		public void Update()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1E6ECE8", Offset = "0x1E6ECE8", VA = "0x1E6ECE8", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1E6ECF4", Offset = "0x1E6ECF4", VA = "0x1E6ECF4")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1E6ED00", Offset = "0x1E6ED00", VA = "0x1E6ED00")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1E6ED08", Offset = "0x1E6ED08", VA = "0x1E6ED08")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1E6ED8C", Offset = "0x1E6ED8C", VA = "0x1E6ED8C")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60003DB")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60003DC")]
		public abstract void FixTransforms();

		[Token(Token = "0x60003DD")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60003DE")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60003DF")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1E6EDA8", Offset = "0x1E6EDA8", VA = "0x1E6EDA8")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1E6EDC0", Offset = "0x1E6EDC0", VA = "0x1E6EDC0")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1E6EEFC", Offset = "0x1E6EEFC", VA = "0x1E6EEFC")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1E6EFA8", Offset = "0x1E6EFA8", VA = "0x1E6EFA8")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1E6F32C", Offset = "0x1E6F32C", VA = "0x1E6F32C")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD698C", Offset = "0xCD698C")]
		public float poleWeight;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD69A4", Offset = "0xCD69A4")]
		public float clampWeight;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD69BC", Offset = "0xCD69BC")]
		public int clampSmoothing;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700007B")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1E7071C", Offset = "0x1E7071C", VA = "0x1E7071C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007C")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x1E707E8", Offset = "0x1E707E8", VA = "0x1E707E8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007D")]
		protected override int minBones
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1E715C0", Offset = "0x1E715C0", VA = "0x1E715C0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007E")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x1E71B64", Offset = "0x1E71B64", VA = "0x1E71B64", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1E7061C", Offset = "0x1E7061C", VA = "0x1E7061C")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1E708B4", Offset = "0x1E708B4", VA = "0x1E708B4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1E70B34", Offset = "0x1E70B34", VA = "0x1E70B34", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1E7150C", Offset = "0x1E7150C", VA = "0x1E7150C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1E71134", Offset = "0x1E71134", VA = "0x1E71134")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1E715C8", Offset = "0x1E715C8", VA = "0x1E715C8")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1E71BD8", Offset = "0x1E71BD8", VA = "0x1E71BD8")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD69D4", Offset = "0xCD69D4")]
		public float IKRotationWeight;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1E71CE8", Offset = "0x1E71CE8", VA = "0x1E71CE8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1E7205C", Offset = "0x1E7205C", VA = "0x1E7205C")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1E720C8", Offset = "0x1E720C8", VA = "0x1E720C8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1E72224", Offset = "0x1E72224", VA = "0x1E72224", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1E723BC", Offset = "0x1E723BC", VA = "0x1E723BC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1E72408", Offset = "0x1E72408", VA = "0x1E72408", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1E72468", Offset = "0x1E72468", VA = "0x1E72468", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1E727D8", Offset = "0x1E727D8", VA = "0x1E727D8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1E72804", Offset = "0x1E72804", VA = "0x1E72804")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1E724CC", Offset = "0x1E724CC", VA = "0x1E724CC")]
		private void Read()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1E72870", Offset = "0x1E72870", VA = "0x1E72870")]
		private void Write()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1E729FC", Offset = "0x1E729FC", VA = "0x1E729FC")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1E72B4C", Offset = "0x1E72B4C", VA = "0x1E72B4C")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1E72BFC", Offset = "0x1E72BFC", VA = "0x1E72BFC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1E73200", Offset = "0x1E73200", VA = "0x1E73200", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1E739B8", Offset = "0x1E739B8", VA = "0x1E739B8")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1E7410C", Offset = "0x1E7410C", VA = "0x1E7410C")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700007F")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x1E75394", Offset = "0x1E75394", VA = "0x1E75394", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1E74110", Offset = "0x1E74110", VA = "0x1E74110")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1E74858", Offset = "0x1E74858", VA = "0x1E74858")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1E74990", Offset = "0x1E74990", VA = "0x1E74990", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1E74A28", Offset = "0x1E74A28", VA = "0x1E74A28", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1E74FCC", Offset = "0x1E74FCC", VA = "0x1E74FCC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1E7539C", Offset = "0x1E7539C", VA = "0x1E7539C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1E741E4", Offset = "0x1E741E4", VA = "0x1E741E4")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1E7493C", Offset = "0x1E7493C", VA = "0x1E7493C")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1E75338", Offset = "0x1E75338", VA = "0x1E75338")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1E74680", Offset = "0x1E74680", VA = "0x1E74680")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1E75C64", Offset = "0x1E75C64", VA = "0x1E75C64")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1E75D74", Offset = "0x1E75D74", VA = "0x1E75D74")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1E75EA0", Offset = "0x1E75EA0", VA = "0x1E75EA0")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1E75FB8", Offset = "0x1E75FB8", VA = "0x1E75FB8")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1E74D34", Offset = "0x1E74D34", VA = "0x1E74D34")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1E74E80", Offset = "0x1E74E80", VA = "0x1E74E80")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1E761A4", Offset = "0x1E761A4", VA = "0x1E761A4")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1E756DC", Offset = "0x1E756DC", VA = "0x1E756DC")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1E7492C", Offset = "0x1E7492C", VA = "0x1E7492C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1E7690C", Offset = "0x1E7690C", VA = "0x1E7690C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1E76378", Offset = "0x1E76378", VA = "0x1E76378")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1E754CC", Offset = "0x1E754CC", VA = "0x1E754CC")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1E75618", Offset = "0x1E75618", VA = "0x1E75618")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1E769D8", Offset = "0x1E769D8", VA = "0x1E769D8")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD69EC", Offset = "0xCD69EC")]
		public float rootPin;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1E76A4C", Offset = "0x1E76A4C", VA = "0x1E76A4C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1E77318", Offset = "0x1E77318", VA = "0x1E77318", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1E773B0", Offset = "0x1E773B0", VA = "0x1E773B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1E77450", Offset = "0x1E77450", VA = "0x1E77450", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1E77550", Offset = "0x1E77550", VA = "0x1E77550")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1E775EC", Offset = "0x1E775EC", VA = "0x1E775EC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1E77B54", Offset = "0x1E77B54", VA = "0x1E77B54", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1E77D54", Offset = "0x1E77D54", VA = "0x1E77D54", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1E77C04", Offset = "0x1E77C04", VA = "0x1E77C04")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1E77820", Offset = "0x1E77820", VA = "0x1E77820")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1E77DEC", Offset = "0x1E77DEC", VA = "0x1E77DEC")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6A04", Offset = "0xCD6A04")]
		public int iterations;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1E77E64", Offset = "0x1E77E64", VA = "0x1E77E64")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1E77F58", Offset = "0x1E77F58", VA = "0x1E77F58")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1E77FB4", Offset = "0x1E77FB4", VA = "0x1E77FB4")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1E68B84", Offset = "0x1E68B84", VA = "0x1E68B84")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1E67C14", Offset = "0x1E67C14", VA = "0x1E67C14")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1E780E8", Offset = "0x1E780E8", VA = "0x1E780E8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1E78290", Offset = "0x1E78290", VA = "0x1E78290", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1E78404", Offset = "0x1E78404", VA = "0x1E78404", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1E78604", Offset = "0x1E78604", VA = "0x1E78604", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1E786D4", Offset = "0x1E786D4", VA = "0x1E786D4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1E787B0", Offset = "0x1E787B0", VA = "0x1E787B0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1E78920", Offset = "0x1E78920", VA = "0x1E78920", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1E78AD8", Offset = "0x1E78AD8", VA = "0x1E78AD8", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1E78D14", Offset = "0x1E78D14", VA = "0x1E78D14", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1E78FD4", Offset = "0x1E78FD4", VA = "0x1E78FD4", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1E79018", Offset = "0x1E79018", VA = "0x1E79018", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1E790FC", Offset = "0x1E790FC", VA = "0x1E790FC")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x400039D")]
		Body,
		[Token(Token = "0x400039E")]
		LeftShoulder,
		[Token(Token = "0x400039F")]
		RightShoulder,
		[Token(Token = "0x40003A0")]
		LeftThigh,
		[Token(Token = "0x40003A1")]
		RightThigh,
		[Token(Token = "0x40003A2")]
		LeftHand,
		[Token(Token = "0x40003A3")]
		RightHand,
		[Token(Token = "0x40003A4")]
		LeftFoot,
		[Token(Token = "0x40003A5")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40003A7")]
		LeftArm,
		[Token(Token = "0x40003A8")]
		RightArm,
		[Token(Token = "0x40003A9")]
		LeftLeg,
		[Token(Token = "0x40003AA")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6A1C", Offset = "0xCD6A1C")]
		public float spineStiffness;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6A34", Offset = "0xCD6A34")]
		public float pullBodyVertical;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6A4C", Offset = "0xCD6A4C")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD6A64", Offset = "0xCD6A64")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000080")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x1E791DC", Offset = "0x1E791DC", VA = "0x1E791DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x1E791E4", Offset = "0x1E791E4", VA = "0x1E791E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x1E791EC", Offset = "0x1E791EC", VA = "0x1E791EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x1E791F4", Offset = "0x1E791F4", VA = "0x1E791F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x1E791FC", Offset = "0x1E791FC", VA = "0x1E791FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x1E79204", Offset = "0x1E79204", VA = "0x1E79204")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x1E7920C", Offset = "0x1E7920C", VA = "0x1E7920C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1E79214", Offset = "0x1E79214", VA = "0x1E79214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x1E7921C", Offset = "0x1E7921C", VA = "0x1E7921C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x1E79224", Offset = "0x1E79224", VA = "0x1E79224")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x1E7925C", Offset = "0x1E7925C", VA = "0x1E7925C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x1E79294", Offset = "0x1E79294", VA = "0x1E79294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x1E792CC", Offset = "0x1E792CC", VA = "0x1E792CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x1E79304", Offset = "0x1E79304", VA = "0x1E79304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x1E79338", Offset = "0x1E79338", VA = "0x1E79338")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x1E79370", Offset = "0x1E79370", VA = "0x1E79370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x1E793A8", Offset = "0x1E793A8", VA = "0x1E793A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x1E793E0", Offset = "0x1E793E0", VA = "0x1E793E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x1E7B330", Offset = "0x1E7B330", VA = "0x1E7B330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE128", Offset = "0xCDE128")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1E7B33C", Offset = "0x1E7B33C", VA = "0x1E7B33C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE138", Offset = "0xCDE138")]
			private set
			{
			}
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1E79414", Offset = "0x1E79414", VA = "0x1E79414")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1E79520", Offset = "0x1E79520", VA = "0x1E79520")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1E79468", Offset = "0x1E79468", VA = "0x1E79468")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1E795FC", Offset = "0x1E795FC", VA = "0x1E795FC")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1E65FFC", Offset = "0x1E65FFC", VA = "0x1E65FFC")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1E796CC", Offset = "0x1E796CC", VA = "0x1E796CC")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1E79784", Offset = "0x1E79784", VA = "0x1E79784")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1E79838", Offset = "0x1E79838", VA = "0x1E79838")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1E798EC", Offset = "0x1E798EC", VA = "0x1E798EC")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1E798F4", Offset = "0x1E798F4", VA = "0x1E798F4")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1E79928", Offset = "0x1E79928", VA = "0x1E79928")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1E799F0", Offset = "0x1E799F0", VA = "0x1E799F0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1E79B80", Offset = "0x1E79B80", VA = "0x1E79B80")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1E7AC54", Offset = "0x1E7AC54", VA = "0x1E7AC54")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1E7B0E8", Offset = "0x1E7B0E8", VA = "0x1E7B0E8")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1E7B148", Offset = "0x1E7B148", VA = "0x1E7B148")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1E7AF68", Offset = "0x1E7AF68", VA = "0x1E7AF68")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1E7B028", Offset = "0x1E7B028", VA = "0x1E7B028")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1E7B348", Offset = "0x1E7B348", VA = "0x1E7B348")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1E7B424", Offset = "0x1E7B424", VA = "0x1E7B424", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1E7B568", Offset = "0x1E7B568", VA = "0x1E7B568")]
		private void PullBody()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1E7B6F8", Offset = "0x1E7B6F8", VA = "0x1E7B6F8")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1E7B8F8", Offset = "0x1E7B8F8", VA = "0x1E7B8F8")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1E7BAF8", Offset = "0x1E7BAF8", VA = "0x1E7BAF8", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1E7BE28", Offset = "0x1E7BE28", VA = "0x1E7BE28", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1E7BF28", Offset = "0x1E7BF28", VA = "0x1E7BF28")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool XZ;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool YZ;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000093")]
		protected virtual int minBones
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x1E7C760", Offset = "0x1E7C760", VA = "0x1E7C760", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000094")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x1E7C768", Offset = "0x1E7C768", VA = "0x1E7C768", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000095")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x1E7C770", Offset = "0x1E7C770", VA = "0x1E7C770", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000096")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x1E7C780", Offset = "0x1E7C780", VA = "0x1E7C780", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000097")]
		protected float positionOffset
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x1E738F4", Offset = "0x1E738F4", VA = "0x1E738F4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1E7BF34", Offset = "0x1E7BF34", VA = "0x1E7BF34")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1E7C0C0", Offset = "0x1E7C0C0", VA = "0x1E7C0C0")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1E7C1FC", Offset = "0x1E7C1FC", VA = "0x1E7C1FC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1E7C264", Offset = "0x1E7C264", VA = "0x1E7C264", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1E7C2E0", Offset = "0x1E7C2E0", VA = "0x1E7C2E0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1E7C664", Offset = "0x1E7C664", VA = "0x1E7C664", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1E7C66C", Offset = "0x1E7C66C", VA = "0x1E7C66C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1E7C778", Offset = "0x1E7C778", VA = "0x1E7C778", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1E7C77C", Offset = "0x1E7C77C", VA = "0x1E7C77C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1E72C7C", Offset = "0x1E72C7C", VA = "0x1E72C7C")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1E7355C", Offset = "0x1E7355C", VA = "0x1E7355C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1E7C8B4", Offset = "0x1E7C8B4", VA = "0x1E7C8B4")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1E71C6C", Offset = "0x1E71C6C", VA = "0x1E71C6C")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6A74", Offset = "0xCD6A74")]
		public float IKRotationWeight;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1E7CB68", Offset = "0x1E7CB68", VA = "0x1E7CB68", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1E7CEDC", Offset = "0x1E7CEDC", VA = "0x1E7CEDC")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1E7CF48", Offset = "0x1E7CF48", VA = "0x1E7CF48", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1E7D0A4", Offset = "0x1E7D0A4", VA = "0x1E7D0A4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1E7D23C", Offset = "0x1E7D23C", VA = "0x1E7D23C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1E7D288", Offset = "0x1E7D288", VA = "0x1E7D288", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1E7D2E8", Offset = "0x1E7D2E8", VA = "0x1E7D2E8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1E7D658", Offset = "0x1E7D658", VA = "0x1E7D658", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1E7D684", Offset = "0x1E7D684", VA = "0x1E7D684")]
		private void Solve()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1E7D34C", Offset = "0x1E7D34C", VA = "0x1E7D34C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1E7D78C", Offset = "0x1E7D78C", VA = "0x1E7D78C")]
		private void Write()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1E7D918", Offset = "0x1E7D918", VA = "0x1E7D918")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200013E")]
		public enum BendModifier
		{
			[Token(Token = "0x4000833")]
			Animation,
			[Token(Token = "0x4000834")]
			Target,
			[Token(Token = "0x4000835")]
			Parent,
			[Token(Token = "0x4000836")]
			Arm,
			[Token(Token = "0x4000837")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200013F")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000913")]
			[Address(RVA = "0x1E9D674", Offset = "0x1E9D674", VA = "0x1E9D674")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6A8C", Offset = "0xCD6A8C")]
		public float maintainRotationWeight;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6AA4", Offset = "0xCD6AA4")]
		public float bendModifierWeight;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000098")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1E9D658", Offset = "0x1E9D658", VA = "0x1E9D658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1E9BF54", Offset = "0x1E9BF54", VA = "0x1E9BF54")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1E9BFA4", Offset = "0x1E9BFA4", VA = "0x1E9BFA4")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1E9C0B8", Offset = "0x1E9C0B8", VA = "0x1E9C0B8", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1E9C728", Offset = "0x1E9C728", VA = "0x1E9C728", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1E9D304", Offset = "0x1E9D304", VA = "0x1E9D304", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1E9D44C", Offset = "0x1E9D44C", VA = "0x1E9D44C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1E9D5D0", Offset = "0x1E9D5D0", VA = "0x1E9D5D0")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1E9C434", Offset = "0x1E9C434", VA = "0x1E9C434")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1E9C854", Offset = "0x1E9C854", VA = "0x1E9C854")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000140")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000118")]
			public Vector3 forward
			{
				[Token(Token = "0x6000918")]
				[Address(RVA = "0x1E9F714", Offset = "0x1E9F714", VA = "0x1E9F714")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x1E9FE60", Offset = "0x1E9FE60", VA = "0x1E9FE60")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x1E9E8B0", Offset = "0x1E9E8B0", VA = "0x1E9E8B0")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x1E9EBEC", Offset = "0x1E9EBEC", VA = "0x1E9EBEC")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000917")]
			[Address(RVA = "0x1E9FB18", Offset = "0x1E9FB18", VA = "0x1E9FB18")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6ABC", Offset = "0xCD6ABC")]
		public float bodyWeight;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6AD4", Offset = "0xCD6AD4")]
		public float headWeight;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6AEC", Offset = "0xCD6AEC")]
		public float eyesWeight;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6B04", Offset = "0xCD6B04")]
		public float clampWeight;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6B1C", Offset = "0xCD6B1C")]
		public float clampWeightHead;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6B34", Offset = "0xCD6B34")]
		public float clampWeightEyes;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6B4C", Offset = "0xCD6B4C")]
		public int clampSmoothing;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x17000099")]
		protected bool spineIsValid
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x1E9E014", Offset = "0x1E9E014", VA = "0x1E9E014")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009A")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x1E9E1EC", Offset = "0x1E9E1EC", VA = "0x1E9E1EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009B")]
		protected bool headIsValid
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x1E9E0F8", Offset = "0x1E9E0F8", VA = "0x1E9E0F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009C")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x1E9E210", Offset = "0x1E9E210", VA = "0x1E9E210")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x1E9E108", Offset = "0x1E9E108", VA = "0x1E9E108")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009E")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x1E9E28C", Offset = "0x1E9E28C", VA = "0x1E9E28C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1E9D6D4", Offset = "0x1E9D6D4", VA = "0x1E9D6D4")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1E9D758", Offset = "0x1E9D758", VA = "0x1E9D758")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1E9D804", Offset = "0x1E9D804", VA = "0x1E9D804")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1E9D8CC", Offset = "0x1E9D8CC", VA = "0x1E9D8CC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1E9D9B8", Offset = "0x1E9D9B8", VA = "0x1E9D9B8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1E9DAC4", Offset = "0x1E9DAC4", VA = "0x1E9DAC4")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1E9DC0C", Offset = "0x1E9DC0C", VA = "0x1E9DC0C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1E9DD3C", Offset = "0x1E9DD3C", VA = "0x1E9DD3C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1E9DE80", Offset = "0x1E9DE80", VA = "0x1E9DE80", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1E9E2B0", Offset = "0x1E9E2B0", VA = "0x1E9E2B0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1E9E4E8", Offset = "0x1E9E4E8", VA = "0x1E9E4E8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1E9E688", Offset = "0x1E9E688", VA = "0x1E9E688")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1E9E8DC", Offset = "0x1E9E8DC", VA = "0x1E9E8DC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1E9ED28", Offset = "0x1E9ED28", VA = "0x1E9ED28", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1E9EE2C", Offset = "0x1E9EE2C", VA = "0x1E9EE2C")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1E9F058", Offset = "0x1E9F058", VA = "0x1E9F058")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1E9F2B4", Offset = "0x1E9F2B4", VA = "0x1E9F2B4")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1E9F7E0", Offset = "0x1E9F7E0", VA = "0x1E9F7E0")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1E9E738", Offset = "0x1E9E738", VA = "0x1E9E738")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1E9FC80", Offset = "0x1E9FC80", VA = "0x1E9FC80")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000141")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000919")]
			[Address(RVA = "0x1EA1438", Offset = "0x1EA1438", VA = "0x1EA1438")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0x1EA1FF0", Offset = "0x1EA1FF0", VA = "0x1EA1FF0")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x1E9BFEC", Offset = "0x1E9BFEC", VA = "0x1E9BFEC")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0x1EA20B8", Offset = "0x1EA20B8", VA = "0x1EA20B8")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6B64", Offset = "0xCD6B64")]
		public float IKRotationWeight;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1E9FE68", Offset = "0x1E9FE68", VA = "0x1E9FE68")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1EA0058", Offset = "0x1EA0058", VA = "0x1EA0058")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1EA020C", Offset = "0x1EA020C", VA = "0x1EA020C")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1EA0218", Offset = "0x1EA0218", VA = "0x1EA0218")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1EA029C", Offset = "0x1EA029C", VA = "0x1EA029C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1EA02A8", Offset = "0x1EA02A8", VA = "0x1EA02A8")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1EA02B0", Offset = "0x1EA02B0", VA = "0x1EA02B0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1EA03B4", Offset = "0x1EA03B4", VA = "0x1EA03B4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1EA04D4", Offset = "0x1EA04D4", VA = "0x1EA04D4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1EA0520", Offset = "0x1EA0520", VA = "0x1EA0520", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1EA0580", Offset = "0x1EA0580", VA = "0x1EA0580", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1EA095C", Offset = "0x1EA095C", VA = "0x1EA095C")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1EA09B4", Offset = "0x1EA09B4", VA = "0x1EA09B4")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1EA0F5C", Offset = "0x1EA0F5C", VA = "0x1EA0F5C")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1EA1174", Offset = "0x1EA1174", VA = "0x1EA1174", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1EA1330", Offset = "0x1EA1330", VA = "0x1EA1330")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1EA12AC", Offset = "0x1EA12AC", VA = "0x1EA12AC")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1EA15D8", Offset = "0x1EA15D8", VA = "0x1EA15D8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1EA20AC", Offset = "0x1EA20AC", VA = "0x1EA20AC", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1EA20B0", Offset = "0x1EA20B0", VA = "0x1EA20B0", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1EA20B4", Offset = "0x1EA20B4", VA = "0x1EA20B4", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1EA1CE4", Offset = "0x1EA1CE4", VA = "0x1EA1CE4")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1E9D4C0", Offset = "0x1E9D4C0", VA = "0x1E9D4C0")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000142")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20001A4")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000A7A")]
				YawPitch,
				[Token(Token = "0x4000A7B")]
				FromTo
			}

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD98EC", Offset = "0xCD98EC")]
			public Transform target;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9924", Offset = "0xCD9924")]
			public Transform bendGoal;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD995C", Offset = "0xCD995C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD995C", Offset = "0xCD995C")]
			public float positionWeight;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD99B0", Offset = "0xCD99B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD99B0", Offset = "0xCD99B0")]
			public float rotationWeight;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9A04", Offset = "0xCD9A04")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9A3C", Offset = "0xCD9A3C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD9A3C", Offset = "0xCD9A3C")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9A90", Offset = "0xCD9A90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD9A90", Offset = "0xCD9A90")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9AE4", Offset = "0xCD9AE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD9AE4", Offset = "0xCD9AE4")]
			public float bendGoalWeight;

			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9B38", Offset = "0xCD9B38")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD9B38", Offset = "0xCD9B38")]
			public float swivelOffset;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9B94", Offset = "0xCD9B94")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9BCC", Offset = "0xCD9BCC")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9C04", Offset = "0xCD9C04")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD9C04", Offset = "0xCD9C04")]
			public float armLengthMlp;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9C5C", Offset = "0xCD9C5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD9C5C", Offset = "0xCD9C5C")]
			public float armToBodyOffset;

			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9CB0", Offset = "0xCD9CB0")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD9D28", Offset = "0xCD9D28")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD9D38", Offset = "0xCD9D38")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private bool hasShoulder;

			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			private Vector3 chestForward;

			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Vector3 chestUp;

			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private Vector3 lastArmOffset;

			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			private Vector3 pelvisPos;

			[Token(Token = "0x400085C")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400085D")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000119")]
			public Vector3 position
			{
				[Token(Token = "0x600091D")]
				[Address(RVA = "0x1EAB2AC", Offset = "0x1EAB2AC", VA = "0x1EAB2AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF958", Offset = "0xCDF958")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600091E")]
				[Address(RVA = "0x1EAB2B8", Offset = "0x1EAB2B8", VA = "0x1EAB2B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF968", Offset = "0xCDF968")]
				private set
				{
				}
			}

			[Token(Token = "0x1700011A")]
			public Quaternion rotation
			{
				[Token(Token = "0x600091F")]
				[Address(RVA = "0x1EAB2C4", Offset = "0x1EAB2C4", VA = "0x1EAB2C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF978", Offset = "0xCDF978")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000920")]
				[Address(RVA = "0x1EAB2D0", Offset = "0x1EAB2D0", VA = "0x1EAB2D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF988", Offset = "0xCDF988")]
				private set
				{
				}
			}

			[Token(Token = "0x1700011B")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000921")]
				[Address(RVA = "0x1EAB2DC", Offset = "0x1EAB2DC", VA = "0x1EAB2DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011C")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000922")]
				[Address(RVA = "0x1EAB310", Offset = "0x1EAB310", VA = "0x1EAB310")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011D")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000923")]
				[Address(RVA = "0x1EAB350", Offset = "0x1EAB350", VA = "0x1EAB350")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011E")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000924")]
				[Address(RVA = "0x1EAB39C", Offset = "0x1EAB39C", VA = "0x1EAB39C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000925")]
			[Address(RVA = "0x1EAB3E8", Offset = "0x1EAB3E8", VA = "0x1EAB3E8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x1EABD1C", Offset = "0x1EABD1C", VA = "0x1EABD1C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000927")]
			[Address(RVA = "0x1EAC0F0", Offset = "0x1EAC0F0", VA = "0x1EAC0F0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x1EAC19C", Offset = "0x1EAC19C", VA = "0x1EAC19C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x1EA90D8", Offset = "0x1EA90D8", VA = "0x1EA90D8")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x1EAD5C4", Offset = "0x1EAD5C4", VA = "0x1EAD5C4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x1EAD634", Offset = "0x1EAD634", VA = "0x1EAD634", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x1EAC5B4", Offset = "0x1EAC5B4", VA = "0x1EAC5B4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600092D")]
			[Address(RVA = "0x1EAC8C0", Offset = "0x1EAC8C0", VA = "0x1EAC8C0")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0x1EAD854", Offset = "0x1EAD854", VA = "0x1EAD854")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600092F")]
			[Address(RVA = "0x1EAAF84", Offset = "0x1EAAF84", VA = "0x1EAAF84")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000143")]
		public abstract class BodyPart
		{
			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD9D48", Offset = "0xCD9D48")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400085F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD9D58", Offset = "0xCD9D58")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x1700011F")]
			public float sqrMag
			{
				[Token(Token = "0x6000935")]
				[Address(RVA = "0x1EADA14", Offset = "0x1EADA14", VA = "0x1EADA14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF998", Offset = "0xCDF998")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000936")]
				[Address(RVA = "0x1EADA1C", Offset = "0x1EADA1C", VA = "0x1EADA1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF9A8", Offset = "0xCDF9A8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000120")]
			public float mag
			{
				[Token(Token = "0x6000937")]
				[Address(RVA = "0x1EADA24", Offset = "0x1EADA24", VA = "0x1EADA24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF9B8", Offset = "0xCDF9B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000938")]
				[Address(RVA = "0x1EADA2C", Offset = "0x1EADA2C", VA = "0x1EADA2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF9C8", Offset = "0xCDF9C8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000930")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000931")]
			public abstract void PreSolve();

			[Token(Token = "0x6000932")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000933")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000934")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000939")]
			[Address(RVA = "0x1EADA34", Offset = "0x1EADA34", VA = "0x1EADA34")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x600093A")]
			[Address(RVA = "0x1EA6B40", Offset = "0x1EA6B40", VA = "0x1EA6B40")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600093B")]
			[Address(RVA = "0x1EADD28", Offset = "0x1EADD28", VA = "0x1EADD28")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x1EADE94", Offset = "0x1EADE94", VA = "0x1EADE94")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x1EAE124", Offset = "0x1EAE124", VA = "0x1EAE124")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x1EA8C78", Offset = "0x1EA8C78", VA = "0x1EA8C78")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x1EAD424", Offset = "0x1EAD424", VA = "0x1EAD424")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0x1EAE178", Offset = "0x1EAE178", VA = "0x1EAE178")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0x1EAE2BC", Offset = "0x1EAE2BC", VA = "0x1EAE2BC")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0x1EAD97C", Offset = "0x1EAD97C", VA = "0x1EAD97C")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000144")]
		public class Footstep
		{
			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD9D78", Offset = "0xCD9D78")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000121")]
			public bool isStepping
			{
				[Token(Token = "0x6000943")]
				[Address(RVA = "0x1EAE2E4", Offset = "0x1EAE2E4", VA = "0x1EAE2E4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000122")]
			public float stepProgress
			{
				[Token(Token = "0x6000944")]
				[Address(RVA = "0x1EAE2F8", Offset = "0x1EAE2F8", VA = "0x1EAE2F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF9D8", Offset = "0xCDF9D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000945")]
				[Address(RVA = "0x1EAE300", Offset = "0x1EAE300", VA = "0x1EAE300")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF9E8", Offset = "0xCDF9E8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000946")]
			[Address(RVA = "0x1EAE308", Offset = "0x1EAE308", VA = "0x1EAE308")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000947")]
			[Address(RVA = "0x1EAE498", Offset = "0x1EAE498", VA = "0x1EAE498")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000948")]
			[Address(RVA = "0x1EAE4E0", Offset = "0x1EAE4E0", VA = "0x1EAE4E0")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000949")]
			[Address(RVA = "0x1EAE6A0", Offset = "0x1EAE6A0", VA = "0x1EAE6A0")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x600094A")]
			[Address(RVA = "0x1EAE878", Offset = "0x1EAE878", VA = "0x1EAE878")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x600094B")]
			[Address(RVA = "0x1EAEA64", Offset = "0x1EAEA64", VA = "0x1EAEA64")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000145")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9D88", Offset = "0xCD9D88")]
			public Transform target;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9DC0", Offset = "0xCD9DC0")]
			public Transform bendGoal;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9DF8", Offset = "0xCD9DF8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD9DF8", Offset = "0xCD9DF8")]
			public float positionWeight;

			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9E4C", Offset = "0xCD9E4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD9E4C", Offset = "0xCD9E4C")]
			public float rotationWeight;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9EA0", Offset = "0xCD9EA0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD9EA0", Offset = "0xCD9EA0")]
			public float bendGoalWeight;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9EF4", Offset = "0xCD9EF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD9EF4", Offset = "0xCD9EF4")]
			public float swivelOffset;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9F50", Offset = "0xCD9F50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD9F50", Offset = "0xCD9F50")]
			public float bendToTargetWeight;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9FA4", Offset = "0xCD9FA4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD9FA4", Offset = "0xCD9FA4")]
			public float legLengthMlp;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9FFC", Offset = "0xCD9FFC")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDA0A4", Offset = "0xCDA0A4")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDA0B4", Offset = "0xCDA0B4")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDA0C4", Offset = "0xCDA0C4")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDA0D4", Offset = "0xCDA0D4")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x17000123")]
			public Vector3 position
			{
				[Token(Token = "0x600094C")]
				[Address(RVA = "0x1EAEC80", Offset = "0x1EAEC80", VA = "0x1EAEC80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF9F8", Offset = "0xCDF9F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600094D")]
				[Address(RVA = "0x1EAEC8C", Offset = "0x1EAEC8C", VA = "0x1EAEC8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFA08", Offset = "0xCDFA08")]
				private set
				{
				}
			}

			[Token(Token = "0x17000124")]
			public Quaternion rotation
			{
				[Token(Token = "0x600094E")]
				[Address(RVA = "0x1EAEC98", Offset = "0x1EAEC98", VA = "0x1EAEC98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFA18", Offset = "0xCDFA18")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600094F")]
				[Address(RVA = "0x1EAECA4", Offset = "0x1EAECA4", VA = "0x1EAECA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFA28", Offset = "0xCDFA28")]
				private set
				{
				}
			}

			[Token(Token = "0x17000125")]
			public bool hasToes
			{
				[Token(Token = "0x6000950")]
				[Address(RVA = "0x1EAECB0", Offset = "0x1EAECB0", VA = "0x1EAECB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFA38", Offset = "0xCDFA38")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000951")]
				[Address(RVA = "0x1EAECB8", Offset = "0x1EAECB8", VA = "0x1EAECB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFA48", Offset = "0xCDFA48")]
				private set
				{
				}
			}

			[Token(Token = "0x17000126")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000952")]
				[Address(RVA = "0x1EAECC4", Offset = "0x1EAECC4", VA = "0x1EAECC4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000127")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000953")]
				[Address(RVA = "0x1EAECF8", Offset = "0x1EAECF8", VA = "0x1EAECF8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000128")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000954")]
				[Address(RVA = "0x1EAED30", Offset = "0x1EAED30", VA = "0x1EAED30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000129")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000955")]
				[Address(RVA = "0x1EAED68", Offset = "0x1EAED68", VA = "0x1EAED68")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012A")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000956")]
				[Address(RVA = "0x1EA8ACC", Offset = "0x1EA8ACC", VA = "0x1EA8ACC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012B")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000957")]
				[Address(RVA = "0x1EAEDA0", Offset = "0x1EAEDA0", VA = "0x1EAEDA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFA58", Offset = "0xCDFA58")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000958")]
				[Address(RVA = "0x1EAEDAC", Offset = "0x1EAEDAC", VA = "0x1EAEDAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFA68", Offset = "0xCDFA68")]
				private set
				{
				}
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0x1EAEDB8", Offset = "0x1EAEDB8", VA = "0x1EAEDB8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600095A")]
			[Address(RVA = "0x1EAF3D4", Offset = "0x1EAF3D4", VA = "0x1EAF3D4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600095B")]
			[Address(RVA = "0x1EAFCBC", Offset = "0x1EAFCBC", VA = "0x1EAFCBC", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600095C")]
			[Address(RVA = "0x1EAFBB8", Offset = "0x1EAFBB8", VA = "0x1EAFBB8")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600095D")]
			[Address(RVA = "0x1EAF980", Offset = "0x1EAF980", VA = "0x1EAF980")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600095E")]
			[Address(RVA = "0x1EA8E64", Offset = "0x1EA8E64", VA = "0x1EA8E64")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600095F")]
			[Address(RVA = "0x1EB07A0", Offset = "0x1EB07A0", VA = "0x1EB07A0")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000960")]
			[Address(RVA = "0x1EB0274", Offset = "0x1EB0274", VA = "0x1EB0274")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000961")]
			[Address(RVA = "0x1EB0C08", Offset = "0x1EB0C08", VA = "0x1EB0C08", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000962")]
			[Address(RVA = "0x1EB0E24", Offset = "0x1EB0E24", VA = "0x1EB0E24", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0x1EAB0D4", Offset = "0x1EAB0D4", VA = "0x1EAB0D4")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000146")]
		public class Locomotion
		{
			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA0E4", Offset = "0xCDA0E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDA0E4", Offset = "0xCDA0E4")]
			public float weight;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA138", Offset = "0xCDA138")]
			public float footDistance;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA170", Offset = "0xCDA170")]
			public float stepThreshold;

			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA1A8", Offset = "0xCDA1A8")]
			public float angleThreshold;

			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA1E0", Offset = "0xCDA1E0")]
			public float comAngleMlp;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA218", Offset = "0xCDA218")]
			public float maxVelocity;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA250", Offset = "0xCDA250")]
			public float velocityFactor;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA288", Offset = "0xCDA288")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDA288", Offset = "0xCDA288")]
			public float maxLegStretch;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA2E0", Offset = "0xCDA2E0")]
			public float rootSpeed;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA318", Offset = "0xCDA318")]
			public float stepSpeed;

			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA350", Offset = "0xCDA350")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA388", Offset = "0xCDA388")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA3C0", Offset = "0xCDA3C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDA3C0", Offset = "0xCDA3C0")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA418", Offset = "0xCDA418")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA450", Offset = "0xCDA450")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA488", Offset = "0xCDA488")]
			public Vector3 offset;

			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA500", Offset = "0xCDA500")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA538", Offset = "0xCDA538")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDA570", Offset = "0xCDA570")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x1700012C")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000964")]
				[Address(RVA = "0x1EB0ED4", Offset = "0x1EB0ED4", VA = "0x1EB0ED4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFA78", Offset = "0xCDFA78")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000965")]
				[Address(RVA = "0x1EB0EE0", Offset = "0x1EB0EE0", VA = "0x1EB0EE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFA88", Offset = "0xCDFA88")]
				private set
				{
				}
			}

			[Token(Token = "0x1700012D")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600096B")]
				[Address(RVA = "0x1EB1320", Offset = "0x1EB1320", VA = "0x1EB1320")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700012E")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600096C")]
				[Address(RVA = "0x1EB1360", Offset = "0x1EB1360", VA = "0x1EB1360")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700012F")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600096D")]
				[Address(RVA = "0x1EB13A4", Offset = "0x1EB13A4", VA = "0x1EB13A4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000130")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600096E")]
				[Address(RVA = "0x1EB13E4", Offset = "0x1EB13E4", VA = "0x1EB13E4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000966")]
			[Address(RVA = "0x1EA6C10", Offset = "0x1EA6C10", VA = "0x1EA6C10")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000967")]
			[Address(RVA = "0x1EA4320", Offset = "0x1EA4320", VA = "0x1EA4320")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000968")]
			[Address(RVA = "0x1EA3730", Offset = "0x1EA3730", VA = "0x1EA3730")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0x1EA3580", Offset = "0x1EA3580", VA = "0x1EA3580")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x600096A")]
			[Address(RVA = "0x1EA752C", Offset = "0x1EA752C", VA = "0x1EA752C")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x600096F")]
			[Address(RVA = "0x1EB0F2C", Offset = "0x1EB0F2C", VA = "0x1EB0F2C")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000970")]
			[Address(RVA = "0x1EB10D0", Offset = "0x1EB10D0", VA = "0x1EB10D0")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000971")]
			[Address(RVA = "0x1EB1154", Offset = "0x1EB1154", VA = "0x1EB1154")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000972")]
			[Address(RVA = "0x1EAB1C8", Offset = "0x1EAB1C8", VA = "0x1EAB1C8")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000147")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA580", Offset = "0xCDA580")]
			public Transform headTarget;

			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA5B8", Offset = "0xCDA5B8")]
			public Transform pelvisTarget;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA5F0", Offset = "0xCDA5F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDA5F0", Offset = "0xCDA5F0")]
			public float positionWeight;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA644", Offset = "0xCDA644")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDA644", Offset = "0xCDA644")]
			public float rotationWeight;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA698", Offset = "0xCDA698")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDA698", Offset = "0xCDA698")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA6EC", Offset = "0xCDA6EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDA6EC", Offset = "0xCDA6EC")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA740", Offset = "0xCDA740")]
			public Transform chestGoal;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA778", Offset = "0xCDA778")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDA778", Offset = "0xCDA778")]
			public float chestGoalWeight;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA7CC", Offset = "0xCDA7CC")]
			public float minHeadHeight;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA804", Offset = "0xCDA804")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDA804", Offset = "0xCDA804")]
			public float bodyPosStiffness;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA858", Offset = "0xCDA858")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDA858", Offset = "0xCDA858")]
			public float bodyRotStiffness;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA8AC", Offset = "0xCDA8AC")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCDA8AC", Offset = "0xCDA8AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDA8AC", Offset = "0xCDA8AC")]
			public float neckStiffness;

			[Token(Token = "0x40008B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA924", Offset = "0xCDA924")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDA924", Offset = "0xCDA924")]
			public float rotateChestByHands;

			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA978", Offset = "0xCDA978")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDA978", Offset = "0xCDA978")]
			public float chestClampWeight;

			[Token(Token = "0x40008B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDA9CC", Offset = "0xCDA9CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDA9CC", Offset = "0xCDA9CC")]
			public float headClampWeight;

			[Token(Token = "0x40008BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAA20", Offset = "0xCDAA20")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40008BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAA58", Offset = "0xCDAA58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDAA58", Offset = "0xCDAA58")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40008BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAAAC", Offset = "0xCDAAAC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDAAAC", Offset = "0xCDAAAC")]
			public float maxRootAngle;

			[Token(Token = "0x40008BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAB04", Offset = "0xCDAB04")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDAB04", Offset = "0xCDAB04")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40008BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40008C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40008C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40008CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDAC40", Offset = "0xCDAC40")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDAC50", Offset = "0xCDAC50")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x17000131")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000973")]
				[Address(RVA = "0x1EA4594", Offset = "0x1EA4594", VA = "0x1EA4594")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000132")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000974")]
				[Address(RVA = "0x1EB1428", Offset = "0x1EB1428", VA = "0x1EB1428")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000133")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000975")]
				[Address(RVA = "0x1EA9084", Offset = "0x1EA9084", VA = "0x1EA9084")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000134")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000976")]
				[Address(RVA = "0x1EB1468", Offset = "0x1EB1468", VA = "0x1EB1468")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000135")]
			public VirtualBone head
			{
				[Token(Token = "0x6000977")]
				[Address(RVA = "0x1EB0EEC", Offset = "0x1EB0EEC", VA = "0x1EB0EEC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000136")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000978")]
				[Address(RVA = "0x1EB14A8", Offset = "0x1EB14A8", VA = "0x1EB14A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFA98", Offset = "0xCDFA98")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000979")]
				[Address(RVA = "0x1EB14BC", Offset = "0x1EB14BC", VA = "0x1EB14BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFAA8", Offset = "0xCDFAA8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000137")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x600097A")]
				[Address(RVA = "0x1EB14D0", Offset = "0x1EB14D0", VA = "0x1EB14D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFAB8", Offset = "0xCDFAB8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600097B")]
				[Address(RVA = "0x1EB14E4", Offset = "0x1EB14E4", VA = "0x1EB14E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFAC8", Offset = "0xCDFAC8")]
				private set
				{
				}
			}

			[Token(Token = "0x600097C")]
			[Address(RVA = "0x1EB14F8", Offset = "0x1EB14F8", VA = "0x1EB14F8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600097D")]
			[Address(RVA = "0x1EB1FC4", Offset = "0x1EB1FC4", VA = "0x1EB1FC4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600097E")]
			[Address(RVA = "0x1EB21D4", Offset = "0x1EB21D4", VA = "0x1EB21D4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0x1EB284C", Offset = "0x1EB284C", VA = "0x1EB284C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000980")]
			[Address(RVA = "0x1EA6F08", Offset = "0x1EA6F08", VA = "0x1EA6F08")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0x1EB3228", Offset = "0x1EB3228", VA = "0x1EB3228")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0x1EB38E8", Offset = "0x1EB38E8", VA = "0x1EB38E8")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000983")]
			[Address(RVA = "0x1EB40D0", Offset = "0x1EB40D0", VA = "0x1EB40D0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0x1EB42AC", Offset = "0x1EB42AC", VA = "0x1EB42AC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0x1EB2A7C", Offset = "0x1EB2A7C", VA = "0x1EB2A7C")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0x1EA8B0C", Offset = "0x1EA8B0C", VA = "0x1EA8B0C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0x1EB2E0C", Offset = "0x1EB2E0C", VA = "0x1EB2E0C")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000988")]
			[Address(RVA = "0x1EB43A8", Offset = "0x1EB43A8", VA = "0x1EB43A8")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0x1EB369C", Offset = "0x1EB369C", VA = "0x1EB369C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600098A")]
			[Address(RVA = "0x1EB33E8", Offset = "0x1EB33E8", VA = "0x1EB33E8")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600098B")]
			[Address(RVA = "0x1EAADD0", Offset = "0x1EAADD0", VA = "0x1EAADD0")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000148")]
		public enum PositionOffset
		{
			[Token(Token = "0x40008E3")]
			Pelvis,
			[Token(Token = "0x40008E4")]
			Chest,
			[Token(Token = "0x40008E5")]
			Head,
			[Token(Token = "0x40008E6")]
			LeftHand,
			[Token(Token = "0x40008E7")]
			RightHand,
			[Token(Token = "0x40008E8")]
			LeftFoot,
			[Token(Token = "0x40008E9")]
			RightFoot,
			[Token(Token = "0x40008EA")]
			LeftHeel,
			[Token(Token = "0x40008EB")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000149")]
		public enum RotationOffset
		{
			[Token(Token = "0x40008ED")]
			Pelvis,
			[Token(Token = "0x40008EE")]
			Chest,
			[Token(Token = "0x40008EF")]
			Head
		}

		[Serializable]
		[Token(Token = "0x200014A")]
		public class VirtualBone
		{
			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x600098C")]
			[Address(RVA = "0x1EA6AA4", Offset = "0x1EA6AA4", VA = "0x1EA6AA4")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0x1EA6B20", Offset = "0x1EA6B20", VA = "0x1EA6B20")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600098E")]
			[Address(RVA = "0x1EB46D0", Offset = "0x1EB46D0", VA = "0x1EB46D0")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0x1EADA3C", Offset = "0x1EADA3C", VA = "0x1EADA3C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000990")]
			[Address(RVA = "0x1EADF3C", Offset = "0x1EADF3C", VA = "0x1EADF3C")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x1EB4960", Offset = "0x1EB4960", VA = "0x1EB4960")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000992")]
			[Address(RVA = "0x1EAC68C", Offset = "0x1EAC68C", VA = "0x1EAC68C")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x1EB4B98", Offset = "0x1EB4B98", VA = "0x1EB4B98")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000994")]
			[Address(RVA = "0x1EACE78", Offset = "0x1EACE78", VA = "0x1EACE78")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x1EB4C50", Offset = "0x1EB4C50", VA = "0x1EB4C50")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000996")]
			[Address(RVA = "0x1EB3C70", Offset = "0x1EB3C70", VA = "0x1EB3C70")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000997")]
			[Address(RVA = "0x1EB4E68", Offset = "0x1EB4E68", VA = "0x1EB4E68")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0x1EB4F70", Offset = "0x1EB4F70", VA = "0x1EB4F70")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6B7C", Offset = "0xCD6B7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6B7C", Offset = "0xCD6B7C")]
		public int LOD;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6BD0", Offset = "0xCD6BD0")]
		public bool plantFeet;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD6C08", Offset = "0xCD6C08")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6C18", Offset = "0xCD6C18")]
		public Spine spine;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6C50", Offset = "0xCD6C50")]
		public Arm leftArm;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6C88", Offset = "0xCD6C88")]
		public Arm rightArm;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6CC0", Offset = "0xCD6CC0")]
		public Leg leftLeg;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6CF8", Offset = "0xCD6CF8")]
		public Leg rightLeg;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6D30", Offset = "0xCD6D30")]
		public Locomotion locomotion;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x1700009F")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x1EAAC18", Offset = "0x1EAAC18", VA = "0x1EAAC18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE148", Offset = "0xCDE148")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x1EAAC20", Offset = "0x1EAAC20", VA = "0x1EAAC20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE158", Offset = "0xCDE158")]
			private set
			{
			}
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1EA20C0", Offset = "0x1EA20C0", VA = "0x1EA20C0")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1EA24FC", Offset = "0x1EA24FC", VA = "0x1EA24FC")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1EA23A4", Offset = "0x1EA23A4", VA = "0x1EA23A4")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1EA2EE8", Offset = "0x1EA2EE8", VA = "0x1EA2EE8")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1EA31C4", Offset = "0x1EA31C4", VA = "0x1EA31C4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1EA3268", Offset = "0x1EA3268", VA = "0x1EA3268")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1EA33FC", Offset = "0x1EA33FC", VA = "0x1EA33FC")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1EA3B08", Offset = "0x1EA3B08", VA = "0x1EA3B08")]
		public void Reset()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1EA45D4", Offset = "0x1EA45D4", VA = "0x1EA45D4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1EA4748", Offset = "0x1EA4748", VA = "0x1EA4748", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1EA4950", Offset = "0x1EA4950", VA = "0x1EA4950", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1EA49C4", Offset = "0x1EA49C4", VA = "0x1EA49C4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1EA4A38", Offset = "0x1EA4A38", VA = "0x1EA4A38", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1EA4C4C", Offset = "0x1EA4C4C", VA = "0x1EA4C4C")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1EA279C", Offset = "0x1EA279C", VA = "0x1EA279C")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1EA2974", Offset = "0x1EA2974", VA = "0x1EA2974")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1EA2DC4", Offset = "0x1EA2DC4", VA = "0x1EA2DC4")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1EA3C78", Offset = "0x1EA3C78", VA = "0x1EA3C78")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1EA4F2C", Offset = "0x1EA4F2C", VA = "0x1EA4F2C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1EA4F74", Offset = "0x1EA4F74", VA = "0x1EA4F74", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1EA662C", Offset = "0x1EA662C", VA = "0x1EA662C")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1EA3DE0", Offset = "0x1EA3DE0", VA = "0x1EA3DE0")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1EA5434", Offset = "0x1EA5434", VA = "0x1EA5434")]
		private void Solve()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1EA6A18", Offset = "0x1EA6A18", VA = "0x1EA6A18")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1EA6A60", Offset = "0x1EA6A60", VA = "0x1EA6A60")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1EA64DC", Offset = "0x1EA64DC", VA = "0x1EA64DC")]
		private void Write()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1EAA630", Offset = "0x1EAA630", VA = "0x1EAA630")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1EAAC28", Offset = "0x1EAAC28", VA = "0x1EAAC28")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6D68", Offset = "0xCD6D68")]
		public Transform parent;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6DA0", Offset = "0xCD6DA0")]
		public Transform child;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6DD8", Offset = "0xCD6DD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6DD8", Offset = "0xCD6DD8")]
		public float weight;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6E2C", Offset = "0xCD6E2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6E2C", Offset = "0xCD6E2C")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6E80", Offset = "0xCD6E80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD6E80", Offset = "0xCD6E80")]
		public float twistAngleOffset;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1A9FCB4", Offset = "0x1A9FCB4", VA = "0x1A9FCB4")]
		public void Relax()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1AA0094", Offset = "0x1AA0094", VA = "0x1AA0094")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1AA0508", Offset = "0x1AA0508", VA = "0x1AA0508")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1AA0590", Offset = "0x1AA0590", VA = "0x1AA0590")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1AA0618", Offset = "0x1AA0618", VA = "0x1AA0618")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1AA071C", Offset = "0x1AA071C", VA = "0x1AA071C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class InteractionEffector
	{
		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD6EDC", Offset = "0xCD6EDC")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD6EEC", Offset = "0xCD6EEC")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD6EFC", Offset = "0xCD6EFC")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x170000A0")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x1EB5798", Offset = "0x1EB5798", VA = "0x1EB5798")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE168", Offset = "0xCDE168")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x1EB57A0", Offset = "0x1EB57A0", VA = "0x1EB57A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE178", Offset = "0xCDE178")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public bool isPaused
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x1EB57A8", Offset = "0x1EB57A8", VA = "0x1EB57A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE188", Offset = "0xCDE188")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x1EB57B0", Offset = "0x1EB57B0", VA = "0x1EB57B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE198", Offset = "0xCDE198")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x1EB57BC", Offset = "0x1EB57BC", VA = "0x1EB57BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE1A8", Offset = "0xCDE1A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x1EB57C4", Offset = "0x1EB57C4", VA = "0x1EB57C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE1B8", Offset = "0xCDE1B8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool inInteraction
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x1EB57CC", Offset = "0x1EB57CC", VA = "0x1EB57CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A4")]
		public float progress
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x1EB71F8", Offset = "0x1EB71F8", VA = "0x1EB71F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1EB583C", Offset = "0x1EB583C", VA = "0x1EB583C")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1EB58C0", Offset = "0x1EB58C0", VA = "0x1EB58C0")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1EB5964", Offset = "0x1EB5964", VA = "0x1EB5964")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1EB5ADC", Offset = "0x1EB5ADC", VA = "0x1EB5ADC")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1EB5F8C", Offset = "0x1EB5F8C", VA = "0x1EB5F8C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1EB60C0", Offset = "0x1EB60C0", VA = "0x1EB60C0")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1EB6118", Offset = "0x1EB6118", VA = "0x1EB6118")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1EB6578", Offset = "0x1EB6578", VA = "0x1EB6578")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1EB6C4C", Offset = "0x1EB6C4C", VA = "0x1EB6C4C")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1EB6E7C", Offset = "0x1EB6E7C", VA = "0x1EB6E7C")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1EB709C", Offset = "0x1EB709C", VA = "0x1EB709C")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1EB7234", Offset = "0x1EB7234", VA = "0x1EB7234")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6F0C", Offset = "0xCD6F0C")]
		public LookAtIK ik;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6F44", Offset = "0xCD6F44")]
		public float lerpSpeed;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6F7C", Offset = "0xCD6F7C")]
		public float weightSpeed;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1A8EF6C", Offset = "0x1A8EF6C", VA = "0x1A8EF6C")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1A8F0E4", Offset = "0x1A8F0E4", VA = "0x1A8F0E4")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1A8F18C", Offset = "0x1A8F18C", VA = "0x1A8F18C")]
		public void Update()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1A8F768", Offset = "0x1A8F768", VA = "0x1A8F768")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1A8F860", Offset = "0x1A8F860", VA = "0x1A8F860")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1A8F92C", Offset = "0x1A8F92C", VA = "0x1A8F92C")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD2944", Offset = "0xCD2944")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD2944", Offset = "0xCD2944")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014B")]
		public class InteractionEvent
		{
			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAC60", Offset = "0xCDAC60")]
			public float time;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAC98", Offset = "0xCDAC98")]
			public bool pause;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDACD0", Offset = "0xCDACD0")]
			public bool pickUp;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAD08", Offset = "0xCDAD08")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAD40", Offset = "0xCDAD40")]
			public Message[] messages;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAD78", Offset = "0xCDAD78")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x1A9142C", Offset = "0x1A9142C", VA = "0x1A9142C")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0x1A915EC", Offset = "0x1A915EC", VA = "0x1A915EC")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014C")]
		public class Message
		{
			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDADB0", Offset = "0xCDADB0")]
			public string function;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDADE8", Offset = "0xCDADE8")]
			public GameObject recipient;

			[Token(Token = "0x40008FF")]
			private const string empty = "";

			[Token(Token = "0x600099B")]
			[Address(RVA = "0x1A914FC", Offset = "0x1A914FC", VA = "0x1A914FC")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x1A915F4", Offset = "0x1A915F4", VA = "0x1A915F4")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014D")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAE20", Offset = "0xCDAE20")]
			public Animator animator;

			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAE58", Offset = "0xCDAE58")]
			public Animation animation;

			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAE90", Offset = "0xCDAE90")]
			public string animationState;

			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAEC8", Offset = "0xCDAEC8")]
			public float crossfadeTime;

			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAF00", Offset = "0xCDAF00")]
			public int layer;

			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAF38", Offset = "0xCDAF38")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000906")]
			private const string empty = "";

			[Token(Token = "0x600099D")]
			[Address(RVA = "0x1A9118C", Offset = "0x1A9118C", VA = "0x1A9118C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x1A91280", Offset = "0x1A91280", VA = "0x1A91280")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x600099F")]
			[Address(RVA = "0x1A91338", Offset = "0x1A91338", VA = "0x1A91338")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x1A91418", Offset = "0x1A91418", VA = "0x1A91418")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014E")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20001A5")]
			public enum Type
			{
				[Token(Token = "0x4000A7D")]
				PositionWeight,
				[Token(Token = "0x4000A7E")]
				RotationWeight,
				[Token(Token = "0x4000A7F")]
				PositionOffsetX,
				[Token(Token = "0x4000A80")]
				PositionOffsetY,
				[Token(Token = "0x4000A81")]
				PositionOffsetZ,
				[Token(Token = "0x4000A82")]
				Pull,
				[Token(Token = "0x4000A83")]
				Reach,
				[Token(Token = "0x4000A84")]
				RotateBoneWeight,
				[Token(Token = "0x4000A85")]
				Push,
				[Token(Token = "0x4000A86")]
				PushParent,
				[Token(Token = "0x4000A87")]
				PoserWeight,
				[Token(Token = "0x4000A88")]
				BendGoalWeight
			}

			[Token(Token = "0x4000907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAF70", Offset = "0xCDAF70")]
			public Type type;

			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAFA8", Offset = "0xCDAFA8")]
			public AnimationCurve curve;

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x1A9077C", Offset = "0x1A9077C", VA = "0x1A9077C")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x1A9160C", Offset = "0x1A9160C", VA = "0x1A9160C")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014F")]
		public class Multiplier
		{
			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDAFE0", Offset = "0xCDAFE0")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400090A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB018", Offset = "0xCDB018")]
			public float multiplier;

			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB050", Offset = "0xCDB050")]
			public WeightCurve.Type result;

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x1A90E5C", Offset = "0x1A90E5C", VA = "0x1A90E5C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x1A915FC", Offset = "0x1A915FC", VA = "0x1A915FC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6FC4", Offset = "0xCD6FC4")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD6FFC", Offset = "0xCD6FFC")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7034", Offset = "0xCD7034")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD706C", Offset = "0xCD706C")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD707C", Offset = "0xCD707C")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000A5")]
		public float length
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x1A8FBA0", Offset = "0x1A8FBA0", VA = "0x1A8FBA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE388", Offset = "0xCDE388")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x1A8FBA8", Offset = "0x1A8FBA8", VA = "0x1A8FBA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE398", Offset = "0xCDE398")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x1A8FBB0", Offset = "0x1A8FBB0", VA = "0x1A8FBB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE3A8", Offset = "0xCDE3A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x1A8FBB8", Offset = "0x1A8FBB8", VA = "0x1A8FBB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE3B8", Offset = "0xCDE3B8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x1A8FE64", Offset = "0x1A8FE64", VA = "0x1A8FE64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x1A8FDD4", Offset = "0x1A8FDD4", VA = "0x1A8FDD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1A8F940", Offset = "0x1A8F940", VA = "0x1A8F940")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE1C8", Offset = "0xCDE1C8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1A8F98C", Offset = "0x1A8F98C", VA = "0x1A8F98C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE200", Offset = "0xCDE200")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1A8F9D8", Offset = "0x1A8F9D8", VA = "0x1A8F9D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE238", Offset = "0xCDE238")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1A8FA24", Offset = "0x1A8FA24", VA = "0x1A8FA24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE270", Offset = "0xCDE270")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1A8FA70", Offset = "0x1A8FA70", VA = "0x1A8FA70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE2A8", Offset = "0xCDE2A8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1A8FABC", Offset = "0x1A8FABC", VA = "0x1A8FABC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE2E0", Offset = "0xCDE2E0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1A8FB08", Offset = "0x1A8FB08", VA = "0x1A8FB08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE318", Offset = "0xCDE318")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1A8FB54", Offset = "0x1A8FB54", VA = "0x1A8FB54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE350", Offset = "0xCDE350")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1A8FBC0", Offset = "0x1A8FBC0", VA = "0x1A8FBC0")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1A8FEF4", Offset = "0x1A8FEF4", VA = "0x1A8FEF4")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1A90078", Offset = "0x1A90078", VA = "0x1A90078")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1A9012C", Offset = "0x1A9012C", VA = "0x1A9012C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1A90134", Offset = "0x1A90134", VA = "0x1A90134")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1A902E8", Offset = "0x1A902E8", VA = "0x1A902E8")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1A902F0", Offset = "0x1A902F0", VA = "0x1A902F0")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1A90E98", Offset = "0x1A90E98", VA = "0x1A90E98")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1A910C0", Offset = "0x1A910C0", VA = "0x1A910C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1A90798", Offset = "0x1A90798", VA = "0x1A90798")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1A90278", Offset = "0x1A90278", VA = "0x1A90278")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1A90DF4", Offset = "0x1A90DF4", VA = "0x1A90DF4")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1A910C4", Offset = "0x1A910C4", VA = "0x1A910C4")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1A9112C", Offset = "0x1A9112C", VA = "0x1A9112C")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD29A4", Offset = "0xCD29A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD29A4", Offset = "0xCD29A4")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000150")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000151")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD708C", Offset = "0xCD708C")]
		public string targetTag;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD70C4", Offset = "0xCD70C4")]
		public float fadeInTime;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD70FC", Offset = "0xCD70FC")]
		public float speed;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7134", Offset = "0xCD7134")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD716C", Offset = "0xCD716C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD716C", Offset = "0xCD716C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD716C", Offset = "0xCD716C")]
		public Collider characterCollider;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD71F0", Offset = "0xCD71F0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCD71F0", Offset = "0xCD71F0")]
		public Transform FPSCamera;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7250", Offset = "0xCD7250")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7288", Offset = "0xCD7288")]
		public float camRaycastDistance;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD72C0", Offset = "0xCD72C0")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCD72D0", Offset = "0xCD72D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD72D0", Offset = "0xCD72D0")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7330", Offset = "0xCD7330")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x170000A9")]
		public bool inInteraction
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x1A91874", Offset = "0x1A91874", VA = "0x1A91874")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AA")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x1A93484", Offset = "0x1A93484", VA = "0x1A93484")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x1A9348C", Offset = "0x1A9348C", VA = "0x1A9348C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x1A93494", Offset = "0x1A93494", VA = "0x1A93494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE588", Offset = "0xCDE588")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x1A9349C", Offset = "0x1A9349C", VA = "0x1A9349C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE598", Offset = "0xCDE598")]
			private set
			{
			}
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1A91614", Offset = "0x1A91614", VA = "0x1A91614")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE3C8", Offset = "0xCDE3C8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1A91660", Offset = "0x1A91660", VA = "0x1A91660")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE400", Offset = "0xCDE400")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1A916AC", Offset = "0x1A916AC", VA = "0x1A916AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE438", Offset = "0xCDE438")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1A916F8", Offset = "0x1A916F8", VA = "0x1A916F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE470", Offset = "0xCDE470")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1A91744", Offset = "0x1A91744", VA = "0x1A91744")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE4A8", Offset = "0xCDE4A8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1A91790", Offset = "0x1A91790", VA = "0x1A91790")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE4E0", Offset = "0xCDE4E0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1A917DC", Offset = "0x1A917DC", VA = "0x1A917DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE518", Offset = "0xCDE518")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1A91828", Offset = "0x1A91828", VA = "0x1A91828")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE550", Offset = "0xCDE550")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1A91A08", Offset = "0x1A91A08", VA = "0x1A91A08")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1A91AD8", Offset = "0x1A91AD8", VA = "0x1A91AD8")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1A91BA8", Offset = "0x1A91BA8", VA = "0x1A91BA8")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1A91C58", Offset = "0x1A91C58", VA = "0x1A91C58")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1A91D54", Offset = "0x1A91D54", VA = "0x1A91D54")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1A91E74", Offset = "0x1A91E74", VA = "0x1A91E74")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1A91F08", Offset = "0x1A91F08", VA = "0x1A91F08")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1A91F9C", Offset = "0x1A91F9C", VA = "0x1A91F9C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1A92030", Offset = "0x1A92030", VA = "0x1A92030")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1A920A8", Offset = "0x1A920A8", VA = "0x1A920A8")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1A92120", Offset = "0x1A92120", VA = "0x1A92120")]
		public void StopAll()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1A9218C", Offset = "0x1A9218C", VA = "0x1A9218C")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1A92218", Offset = "0x1A92218", VA = "0x1A92218")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1A922AC", Offset = "0x1A922AC", VA = "0x1A922AC")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1A92378", Offset = "0x1A92378", VA = "0x1A92378")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1A9261C", Offset = "0x1A9261C", VA = "0x1A9261C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1A927F4", Offset = "0x1A927F4", VA = "0x1A927F4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1A92A68", Offset = "0x1A92A68", VA = "0x1A92A68")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1A92D5C", Offset = "0x1A92D5C", VA = "0x1A92D5C")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1A92DA0", Offset = "0x1A92DA0", VA = "0x1A92DA0")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1A92E18", Offset = "0x1A92E18", VA = "0x1A92E18")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1A92F38", Offset = "0x1A92F38", VA = "0x1A92F38")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1A930B0", Offset = "0x1A930B0", VA = "0x1A930B0")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1A93358", Offset = "0x1A93358", VA = "0x1A93358")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1A92B68", Offset = "0x1A92B68", VA = "0x1A92B68")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1A934A4", Offset = "0x1A934A4", VA = "0x1A934A4")]
		public void Start()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1A93B5C", Offset = "0x1A93B5C", VA = "0x1A93B5C")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1A93B7C", Offset = "0x1A93B7C", VA = "0x1A93B7C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1A93B98", Offset = "0x1A93B98", VA = "0x1A93B98")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1A93BB4", Offset = "0x1A93BB4", VA = "0x1A93BB4")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1A93C14", Offset = "0x1A93C14", VA = "0x1A93C14")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1A93D30", Offset = "0x1A93D30", VA = "0x1A93D30")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1A93E2C", Offset = "0x1A93E2C", VA = "0x1A93E2C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1A9418C", Offset = "0x1A9418C", VA = "0x1A9418C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1A94278", Offset = "0x1A94278", VA = "0x1A94278")]
		public void Update()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1A944C4", Offset = "0x1A944C4", VA = "0x1A944C4")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1A938D4", Offset = "0x1A938D4", VA = "0x1A938D4")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1A94604", Offset = "0x1A94604", VA = "0x1A94604")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1A94738", Offset = "0x1A94738", VA = "0x1A94738")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1A947D0", Offset = "0x1A947D0", VA = "0x1A947D0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1A948AC", Offset = "0x1A948AC", VA = "0x1A948AC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1A948C4", Offset = "0x1A948C4", VA = "0x1A948C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1A91924", Offset = "0x1A91924", VA = "0x1A91924")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1A92518", Offset = "0x1A92518", VA = "0x1A92518")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1A94BB4", Offset = "0x1A94BB4", VA = "0x1A94BB4")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD2A04", Offset = "0xCD2A04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD2A04", Offset = "0xCD2A04")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000152")]
		public class Multiplier
		{
			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB088", Offset = "0xCDB088")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB0C0", Offset = "0xCDB0C0")]
			public float multiplier;

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x1A95E78", Offset = "0x1A95E78", VA = "0x1A95E78")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7368", Offset = "0xCD7368")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD73A0", Offset = "0xCD73A0")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD73D8", Offset = "0xCD73D8")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7410", Offset = "0xCD7410")]
		public Transform pivot;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7448", Offset = "0xCD7448")]
		public Vector3 twistAxis;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7480", Offset = "0xCD7480")]
		public float twistWeight;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD74B8", Offset = "0xCD74B8")]
		public float swingWeight;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD74F0", Offset = "0xCD74F0")]
		public bool rotateOnce;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1A955CC", Offset = "0x1A955CC", VA = "0x1A955CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE5A8", Offset = "0xCDE5A8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1A95618", Offset = "0x1A95618", VA = "0x1A95618")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE5E0", Offset = "0xCDE5E0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1A95664", Offset = "0x1A95664", VA = "0x1A95664")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE618", Offset = "0xCDE618")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1A956B0", Offset = "0x1A956B0", VA = "0x1A956B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE650", Offset = "0xCDE650")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1A956FC", Offset = "0x1A956FC", VA = "0x1A956FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE688", Offset = "0xCDE688")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1A95748", Offset = "0x1A95748", VA = "0x1A95748")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE6C0", Offset = "0xCDE6C0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1A95794", Offset = "0x1A95794", VA = "0x1A95794")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE6F8", Offset = "0xCDE6F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1A957E0", Offset = "0x1A957E0", VA = "0x1A957E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE730", Offset = "0xCDE730")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1A9070C", Offset = "0x1A9070C", VA = "0x1A9070C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1A9582C", Offset = "0x1A9582C", VA = "0x1A9582C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1A958C8", Offset = "0x1A958C8", VA = "0x1A958C8")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1A95DEC", Offset = "0x1A95DEC", VA = "0x1A95DEC")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD2A64", Offset = "0xCD2A64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD2A64", Offset = "0xCD2A64")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000153")]
		public class CharacterPosition
		{
			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB0F8", Offset = "0xCDB0F8")]
			public bool use;

			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB130", Offset = "0xCDB130")]
			public Vector2 offset;

			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB168", Offset = "0xCDB168")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDB168", Offset = "0xCDB168")]
			public float angleOffset;

			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB1C4", Offset = "0xCDB1C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDB1C4", Offset = "0xCDB1C4")]
			public float maxAngle;

			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB21C", Offset = "0xCDB21C")]
			public float radius;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB254", Offset = "0xCDB254")]
			public bool orbit;

			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB28C", Offset = "0xCDB28C")]
			public bool fixYAxis;

			[Token(Token = "0x17000138")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60009AE")]
				[Address(RVA = "0x1A96698", Offset = "0x1A96698", VA = "0x1A96698")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000139")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60009AF")]
				[Address(RVA = "0x1A966D4", Offset = "0x1A966D4", VA = "0x1A966D4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x1A967CC", Offset = "0x1A967CC", VA = "0x1A967CC")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x1A96E48", Offset = "0x1A96E48", VA = "0x1A96E48")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000154")]
		public class CameraPosition
		{
			[Token(Token = "0x4000915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB2C4", Offset = "0xCDB2C4")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB2FC", Offset = "0xCDB2FC")]
			public Vector3 direction;

			[Token(Token = "0x4000917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB334", Offset = "0xCDB334")]
			public float maxDistance;

			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB36C", Offset = "0xCDB36C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDB36C", Offset = "0xCDB36C")]
			public float maxAngle;

			[Token(Token = "0x4000919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB3C4", Offset = "0xCDB3C4")]
			public bool fixYAxis;

			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x1A96184", Offset = "0x1A96184", VA = "0x1A96184")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x1A9632C", Offset = "0x1A9632C", VA = "0x1A9632C")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x1A9660C", Offset = "0x1A9660C", VA = "0x1A9660C")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000155")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20001A6")]
			public class Interaction
			{
				[Token(Token = "0x4000A89")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC684", Offset = "0xCDC684")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000A8A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC6BC", Offset = "0xCDC6BC")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000ACF")]
				[Address(RVA = "0x1A96E6C", Offset = "0x1A96E6C", VA = "0x1A96E6C")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x400091B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x400091C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB46C", Offset = "0xCDB46C")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB4A4", Offset = "0xCDB4A4")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB4DC", Offset = "0xCDB4DC")]
			public Interaction[] interactions;

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x1A96000", Offset = "0x1A96000", VA = "0x1A96000")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x1A96E5C", Offset = "0x1A96E5C", VA = "0x1A96E5C")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7528", Offset = "0xCD7528")]
		public Range[] ranges;

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1A95E80", Offset = "0x1A95E80", VA = "0x1A95E80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE768", Offset = "0xCDE768")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1A95ECC", Offset = "0x1A95ECC", VA = "0x1A95ECC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE7A0", Offset = "0xCDE7A0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1A95F18", Offset = "0x1A95F18", VA = "0x1A95F18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE7D8", Offset = "0xCDE7D8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1A95F64", Offset = "0x1A95F64", VA = "0x1A95F64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE810", Offset = "0xCDE810")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1A95FB0", Offset = "0x1A95FB0", VA = "0x1A95FB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE848", Offset = "0xCDE848")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1A95FFC", Offset = "0x1A95FFC", VA = "0x1A95FFC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1A93FD0", Offset = "0x1A93FD0", VA = "0x1A93FD0")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1A96124", Offset = "0x1A96124", VA = "0x1A96124")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000156")]
		public class Map
		{
			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x1986AEC", Offset = "0x1986AEC", VA = "0x1986AEC")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x1986EF0", Offset = "0x1986EF0", VA = "0x1986EF0")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x1986EA4", Offset = "0x1986EA4", VA = "0x1986EA4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x1986C9C", Offset = "0x1986C9C", VA = "0x1986C9C")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1986804", Offset = "0x1986804", VA = "0x1986804", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE880", Offset = "0xCDE880")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1986B90", Offset = "0x1986B90", VA = "0x1986B90", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1986B94", Offset = "0x1986B94", VA = "0x1986B94", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1986E3C", Offset = "0x1986E3C", VA = "0x1986E3C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1986B28", Offset = "0x1986B28", VA = "0x1986B28")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1986A4C", Offset = "0x1986A4C", VA = "0x1986A4C")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1986F40", Offset = "0x1986F40", VA = "0x1986F40")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1E64784", Offset = "0x1E64784", VA = "0x1E64784", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1E64838", Offset = "0x1E64838", VA = "0x1E64838", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1E649F0", Offset = "0x1E649F0", VA = "0x1E649F0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1E64AEC", Offset = "0x1E64AEC", VA = "0x1E64AEC", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1E64894", Offset = "0x1E64894", VA = "0x1E64894")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1E64E9C", Offset = "0x1E64E9C", VA = "0x1E64E9C")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD7560", Offset = "0xCD7560")]
		public float weight;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD7578", Offset = "0xCD7578")]
		public float localRotationWeight;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD7590", Offset = "0xCD7590")]
		public float localPositionWeight;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000572")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1A98CC0", Offset = "0x1A98CC0", VA = "0x1A98CC0")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000574")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000575")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000576")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1A98CCC", Offset = "0x1A98CCC", VA = "0x1A98CCC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1A98D20", Offset = "0x1A98D20", VA = "0x1A98D20", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1A98D5C", Offset = "0x1A98D5C", VA = "0x1A98D5C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1A98D74", Offset = "0x1A98D74", VA = "0x1A98D74")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD2AC4", Offset = "0xCD2AC4")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x2000157")]
		public class Rigidbone
		{
			[Token(Token = "0x4000923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x1A992F8", Offset = "0x1A992F8", VA = "0x1A992F8")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x1A99F04", Offset = "0x1A99F04", VA = "0x1A99F04")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x1A99CE8", Offset = "0x1A99CE8", VA = "0x1A99CE8")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x2000158")]
		public class Child
		{
			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x400092F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x1A99454", Offset = "0x1A99454", VA = "0x1A99454")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x1A9A0A0", Offset = "0x1A9A0A0", VA = "0x1A9A0A0")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x1A9A050", Offset = "0x1A9A050", VA = "0x1A9A050")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD42DC", Offset = "0xCD42DC")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x1700013A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C4")]
				[Address(RVA = "0x1A9A680", Offset = "0x1A9A680", VA = "0x1A9A680", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C6")]
				[Address(RVA = "0x1A9A6E8", Offset = "0x1A9A6E8", VA = "0x1A9A6E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x1A994B4", Offset = "0x1A994B4", VA = "0x1A994B4")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x1A9A438", Offset = "0x1A9A438", VA = "0x1A9A438", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x1A9A43C", Offset = "0x1A9A43C", VA = "0x1A9A43C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x1A9A688", Offset = "0x1A9A688", VA = "0x1A9A688", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD75A8", Offset = "0xCD75A8")]
		public IK ik;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD75E0", Offset = "0xCD75E0")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7618", Offset = "0xCD7618")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7650", Offset = "0xCD7650")]
		public float applyVelocity;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7688", Offset = "0xCD7688")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x170000AC")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x1A98DBC", Offset = "0x1A98DBC", VA = "0x1A98DBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AD")]
		private bool ikUsed
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x1A998A0", Offset = "0x1A998A0", VA = "0x1A998A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1A98D84", Offset = "0x1A98D84", VA = "0x1A98D84")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1A98E34", Offset = "0x1A98E34", VA = "0x1A98E34")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1A98F64", Offset = "0x1A98F64", VA = "0x1A98F64")]
		public void Start()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1A98EF4", Offset = "0x1A98EF4", VA = "0x1A98EF4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDE8B8", Offset = "0xCDE8B8")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1A994E0", Offset = "0x1A994E0", VA = "0x1A994E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1A9972C", Offset = "0x1A9972C", VA = "0x1A9972C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1A997E4", Offset = "0x1A997E4", VA = "0x1A997E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1A99A24", Offset = "0x1A99A24", VA = "0x1A99A24")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1A99864", Offset = "0x1A99864", VA = "0x1A99864")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1A999E0", Offset = "0x1A999E0", VA = "0x1A999E0")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1A99AC0", Offset = "0x1A99AC0", VA = "0x1A99AC0")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1A99A58", Offset = "0x1A99A58", VA = "0x1A99A58")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1A98E8C", Offset = "0x1A98E8C", VA = "0x1A98E8C")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1A9976C", Offset = "0x1A9976C", VA = "0x1A9976C")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1A9A268", Offset = "0x1A9A268", VA = "0x1A9A268")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1A9A36C", Offset = "0x1A9A36C", VA = "0x1A9A36C")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD76D0", Offset = "0xCD76D0")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000AE")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x1A9BF74", Offset = "0x1A9BF74", VA = "0x1A9BF74")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000AF")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x1A9BFB0", Offset = "0x1A9BFB0", VA = "0x1A9BFB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B0")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x1A9C080", Offset = "0x1A9C080", VA = "0x1A9C080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE91C", Offset = "0xCDE91C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x1A9C088", Offset = "0x1A9C088", VA = "0x1A9C088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDE92C", Offset = "0xCDE92C")]
			private set
			{
			}
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1A9BBD8", Offset = "0x1A9BBD8", VA = "0x1A9BBD8")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1A9BC20", Offset = "0x1A9BC20", VA = "0x1A9BC20")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1A9BC38", Offset = "0x1A9BC38", VA = "0x1A9BC38")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1A9BECC", Offset = "0x1A9BECC", VA = "0x1A9BECC")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1A9BF3C", Offset = "0x1A9BF3C", VA = "0x1A9BF3C")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000596")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1A9BDDC", Offset = "0x1A9BDDC", VA = "0x1A9BDDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1A9C094", Offset = "0x1A9C094", VA = "0x1A9C094")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1A9C098", Offset = "0x1A9C098", VA = "0x1A9C098")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1A9C0CC", Offset = "0x1A9C0CC", VA = "0x1A9C0CC")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1A9C1B0", Offset = "0x1A9C1B0", VA = "0x1A9C1B0")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1A9C42C", Offset = "0x1A9C42C", VA = "0x1A9C42C")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1A9C4E8", Offset = "0x1A9C4E8", VA = "0x1A9C4E8")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD2B28", Offset = "0xCD2B28")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD2B28", Offset = "0xCD2B28")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD76E0", Offset = "0xCD76E0")]
		public float limit;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD76FC", Offset = "0xCD76FC")]
		public float twistLimit;

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1A9C560", Offset = "0x1A9C560", VA = "0x1A9C560")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE93C", Offset = "0xCDE93C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1A9C5AC", Offset = "0x1A9C5AC", VA = "0x1A9C5AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE974", Offset = "0xCDE974")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1A9C5F8", Offset = "0x1A9C5F8", VA = "0x1A9C5F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE9AC", Offset = "0xCDE9AC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1A9C644", Offset = "0x1A9C644", VA = "0x1A9C644")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDE9E4", Offset = "0xCDE9E4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1A9C690", Offset = "0x1A9C690", VA = "0x1A9C690", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1A9C748", Offset = "0x1A9C748", VA = "0x1A9C748")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1A9C990", Offset = "0x1A9C990", VA = "0x1A9C990")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD2B88", Offset = "0xCD2B88")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD2B88", Offset = "0xCD2B88")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastAngle;

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1A9C9A0", Offset = "0x1A9C9A0", VA = "0x1A9C9A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDEA1C", Offset = "0xCDEA1C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1A9C9EC", Offset = "0x1A9C9EC", VA = "0x1A9C9EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDEA54", Offset = "0xCDEA54")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1A9CA38", Offset = "0x1A9CA38", VA = "0x1A9CA38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDEA8C", Offset = "0xCDEA8C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1A9CA84", Offset = "0x1A9CA84", VA = "0x1A9CA84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDEAC4", Offset = "0xCDEAC4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1A9CAD0", Offset = "0x1A9CAD0", VA = "0x1A9CAD0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1A9CAF8", Offset = "0x1A9CAF8", VA = "0x1A9CAF8")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1A9CDF8", Offset = "0x1A9CDF8", VA = "0x1A9CDF8")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD2BE8", Offset = "0xCD2BE8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD2BE8", Offset = "0xCD2BE8")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x200015A")]
		public class ReachCone
		{
			[Token(Token = "0x4000934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x1700013C")]
			public Vector3 o
			{
				[Token(Token = "0x60009C7")]
				[Address(RVA = "0x1A9EDA0", Offset = "0x1A9EDA0", VA = "0x1A9EDA0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700013D")]
			public Vector3 a
			{
				[Token(Token = "0x60009C8")]
				[Address(RVA = "0x1A9EDD8", Offset = "0x1A9EDD8", VA = "0x1A9EDD8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700013E")]
			public Vector3 b
			{
				[Token(Token = "0x60009C9")]
				[Address(RVA = "0x1A9EE14", Offset = "0x1A9EE14", VA = "0x1A9EE14")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700013F")]
			public Vector3 c
			{
				[Token(Token = "0x60009CA")]
				[Address(RVA = "0x1A9EE50", Offset = "0x1A9EE50", VA = "0x1A9EE50")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000140")]
			public bool isValid
			{
				[Token(Token = "0x60009CC")]
				[Address(RVA = "0x1A9DF04", Offset = "0x1A9DF04", VA = "0x1A9DF04")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x1A9E550", Offset = "0x1A9E550", VA = "0x1A9E550")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x1A9E6B0", Offset = "0x1A9E6B0", VA = "0x1A9E6B0")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200015B")]
		public class LimitPoint
		{
			[Token(Token = "0x4000938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x1A9DF14", Offset = "0x1A9DF14", VA = "0x1A9DF14")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD7728", Offset = "0xCD7728")]
		public float twistLimit;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD7744", Offset = "0xCD7744")]
		public int smoothIterations;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1A9CE80", Offset = "0x1A9CE80", VA = "0x1A9CE80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDEAFC", Offset = "0xCDEAFC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1A9CECC", Offset = "0x1A9CECC", VA = "0x1A9CECC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDEB34", Offset = "0xCDEB34")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1A9CF18", Offset = "0x1A9CF18", VA = "0x1A9CF18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDEB6C", Offset = "0xCDEB6C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1A9CF64", Offset = "0x1A9CF64", VA = "0x1A9CF64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDEBA4", Offset = "0xCDEBA4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1A9CFB0", Offset = "0x1A9CFB0", VA = "0x1A9CFB0")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1A9D498", Offset = "0x1A9D498", VA = "0x1A9D498", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1A9D590", Offset = "0x1A9D590", VA = "0x1A9D590")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1A9DB50", Offset = "0x1A9DB50", VA = "0x1A9DB50")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1A9D050", Offset = "0x1A9D050", VA = "0x1A9D050")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1A9DF98", Offset = "0x1A9DF98", VA = "0x1A9DF98")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1A9E870", Offset = "0x1A9E870", VA = "0x1A9E870")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1A9E8B4", Offset = "0x1A9E8B4", VA = "0x1A9E8B4")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1A9E9FC", Offset = "0x1A9E9FC", VA = "0x1A9E9FC")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1A9D814", Offset = "0x1A9D814", VA = "0x1A9D814")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1A9EB8C", Offset = "0x1A9EB8C", VA = "0x1A9EB8C")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1A9ED3C", Offset = "0x1A9ED3C", VA = "0x1A9ED3C")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCD2C48", Offset = "0xCD2C48")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCD2C48", Offset = "0xCD2C48")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD7804", Offset = "0xCD7804")]
		public float twistLimit;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1A9EE8C", Offset = "0x1A9EE8C", VA = "0x1A9EE8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDEBDC", Offset = "0xCDEBDC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1A9EED8", Offset = "0x1A9EED8", VA = "0x1A9EED8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDEC14", Offset = "0xCDEC14")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1A9EF24", Offset = "0x1A9EF24", VA = "0x1A9EF24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDEC4C", Offset = "0xCDEC4C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1A9EF70", Offset = "0x1A9EF70", VA = "0x1A9EF70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCDEC84", Offset = "0xCDEC84")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1A9EFBC", Offset = "0x1A9EFBC", VA = "0x1A9EFBC")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1A9EFD8", Offset = "0x1A9EFD8", VA = "0x1A9EFD8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1A9F090", Offset = "0x1A9F090", VA = "0x1A9F090")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1A9F3BC", Offset = "0x1A9F3BC", VA = "0x1A9F3BC")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x200015C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD42EC", Offset = "0xCD42EC")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400093A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400093B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400093C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x17000141")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009D2")]
				[Address(RVA = "0x197A4D8", Offset = "0x197A4D8", VA = "0x197A4D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000142")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D4")]
				[Address(RVA = "0x197A540", Offset = "0x197A540", VA = "0x197A540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x197A2B4", Offset = "0x197A2B4", VA = "0x197A2B4")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x197A3B4", Offset = "0x197A3B4", VA = "0x197A3B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x197A3B8", Offset = "0x197A3B8", VA = "0x197A3B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x197A4E0", Offset = "0x197A4E0", VA = "0x197A4E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7858", Offset = "0xCD7858")]
		public AimIK ik;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7890", Offset = "0xCD7890")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD7890", Offset = "0xCD7890")]
		public float weight;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD78E4", Offset = "0xCD78E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD78E4", Offset = "0xCD78E4")]
		public Transform target;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7944", Offset = "0xCD7944")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD797C", Offset = "0xCD797C")]
		public float weightSmoothTime;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD79B4", Offset = "0xCD79B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD79B4", Offset = "0xCD79B4")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7A14", Offset = "0xCD7A14")]
		public float maxRadiansDelta;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7A4C", Offset = "0xCD7A4C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7A84", Offset = "0xCD7A84")]
		public float slerpSpeed;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7ABC", Offset = "0xCD7ABC")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7AF4", Offset = "0xCD7AF4")]
		public float minDistance;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7B2C", Offset = "0xCD7B2C")]
		public Vector3 offset;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD7B64", Offset = "0xCD7B64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7B64", Offset = "0xCD7B64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD7B64", Offset = "0xCD7B64")]
		public float maxRootAngle;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7BE0", Offset = "0xCD7BE0")]
		public bool turnToTarget;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7C18", Offset = "0xCD7C18")]
		public float turnToTargetTime;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD7C50", Offset = "0xCD7C50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7C50", Offset = "0xCD7C50")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7CB0", Offset = "0xCD7CB0")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x170000B1")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x19794B4", Offset = "0x19794B4", VA = "0x19794B4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x19793B8", Offset = "0x19793B8", VA = "0x19793B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1979600", Offset = "0x1979600", VA = "0x1979600")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1979D38", Offset = "0x1979D38", VA = "0x1979D38")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1979ED4", Offset = "0x1979ED4", VA = "0x1979ED4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x197A244", Offset = "0x197A244", VA = "0x197A244")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDECBC", Offset = "0xCDECBC")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x197A2E0", Offset = "0x197A2E0", VA = "0x197A2E0")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200015D")]
		public class Pose
		{
			[Token(Token = "0x400093D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x197A810", Offset = "0x197A810", VA = "0x197A810")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x197AB7C", Offset = "0x197AB7C", VA = "0x197AB7C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x197AB84", Offset = "0x197AB84", VA = "0x197AB84")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x197A734", Offset = "0x197A734", VA = "0x197A734")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x197AAA8", Offset = "0x197AAA8", VA = "0x197AAA8")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x197AB14", Offset = "0x197AB14", VA = "0x197AB14")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200015E")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001A7")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A8B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC6F4", Offset = "0xCDC6F4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A8C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC72C", Offset = "0xCDC72C")]
				public float weight;

				[Token(Token = "0x6000AD0")]
				[Address(RVA = "0x197B174", Offset = "0x197B174", VA = "0x197B174")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB514", Offset = "0xCDB514")]
			public Transform transform;

			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB54C", Offset = "0xCDB54C")]
			public Transform relativeTo;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB584", Offset = "0xCDB584")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB5BC", Offset = "0xCDB5BC")]
			public float verticalWeight;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB5F4", Offset = "0xCDB5F4")]
			public float horizontalWeight;

			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB62C", Offset = "0xCDB62C")]
			public float speed;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x197ACE0", Offset = "0x197ACE0", VA = "0x197ACE0")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x197B14C", Offset = "0x197B14C", VA = "0x197B14C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x197B15C", Offset = "0x197B15C", VA = "0x197B15C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7CE8", Offset = "0xCD7CE8")]
		public Body[] bodies;

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x197ABA0", Offset = "0x197ABA0", VA = "0x197ABA0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x197B144", Offset = "0x197B144", VA = "0x197B144")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7D20", Offset = "0xCD7D20")]
		public float tiltSpeed;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7D58", Offset = "0xCD7D58")]
		public float tiltSensitivity;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7D90", Offset = "0xCD7D90")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7DC8", Offset = "0xCD7DC8")]
		public OffsetPose poseRight;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x197C688", Offset = "0x197C688", VA = "0x197C688", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x197C6D0", Offset = "0x197C6D0", VA = "0x197C6D0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x197C900", Offset = "0x197C900", VA = "0x197C900")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IK ik;

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x197D368", Offset = "0x197D368", VA = "0x197D368")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x197D3FC", Offset = "0x197D3FC", VA = "0x197D3FC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x197D4CC", Offset = "0x197D4CC", VA = "0x197D4CC")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200015F")]
		public abstract class HitPoint
		{
			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB664", Offset = "0xCDB664")]
			public string name;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB69C", Offset = "0xCDB69C")]
			public Collider collider;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB6D4", Offset = "0xCDB6D4")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDB720", Offset = "0xCDB720")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDB730", Offset = "0xCDB730")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDB740", Offset = "0xCDB740")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDB750", Offset = "0xCDB750")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000143")]
			public bool inProgress
			{
				[Token(Token = "0x60009DB")]
				[Address(RVA = "0x1E64F60", Offset = "0x1E64F60", VA = "0x1E64F60")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000144")]
			protected float crossFader
			{
				[Token(Token = "0x60009DC")]
				[Address(RVA = "0x1E65508", Offset = "0x1E65508", VA = "0x1E65508")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFB78", Offset = "0xCDFB78")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009DD")]
				[Address(RVA = "0x1E65510", Offset = "0x1E65510", VA = "0x1E65510")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFB88", Offset = "0xCDFB88")]
				private set
				{
				}
			}

			[Token(Token = "0x17000145")]
			protected float timer
			{
				[Token(Token = "0x60009DE")]
				[Address(RVA = "0x1E65518", Offset = "0x1E65518", VA = "0x1E65518")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFB98", Offset = "0xCDFB98")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009DF")]
				[Address(RVA = "0x1E65520", Offset = "0x1E65520", VA = "0x1E65520")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFBA8", Offset = "0xCDFBA8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000146")]
			protected Vector3 force
			{
				[Token(Token = "0x60009E0")]
				[Address(RVA = "0x1E65528", Offset = "0x1E65528", VA = "0x1E65528")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFBB8", Offset = "0xCDFBB8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60009E1")]
				[Address(RVA = "0x1E65534", Offset = "0x1E65534", VA = "0x1E65534")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFBC8", Offset = "0xCDFBC8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000147")]
			protected Vector3 point
			{
				[Token(Token = "0x60009E2")]
				[Address(RVA = "0x1E65540", Offset = "0x1E65540", VA = "0x1E65540")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFBD8", Offset = "0xCDFBD8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60009E3")]
				[Address(RVA = "0x1E6554C", Offset = "0x1E6554C", VA = "0x1E6554C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFBE8", Offset = "0xCDFBE8")]
				private set
				{
				}
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x1E653D4", Offset = "0x1E653D4", VA = "0x1E653D4")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x1E65048", Offset = "0x1E65048", VA = "0x1E65048")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60009E6")]
			protected abstract float GetLength();

			[Token(Token = "0x60009E7")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60009E8")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x1E65558", Offset = "0x1E65558", VA = "0x1E65558")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000160")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001A8")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A8D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC764", Offset = "0xCDC764")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A8E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC79C", Offset = "0xCDC79C")]
				public float weight;

				[Token(Token = "0x4000A8F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000A90")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000AD1")]
				[Address(RVA = "0x1E65EC4", Offset = "0x1E65EC4", VA = "0x1E65EC4")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000AD2")]
				[Address(RVA = "0x1E65CB8", Offset = "0x1E65CB8", VA = "0x1E65CB8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000AD3")]
				[Address(RVA = "0x1E6613C", Offset = "0x1E6613C", VA = "0x1E6613C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB760", Offset = "0xCDB760")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB798", Offset = "0xCDB798")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB7D0", Offset = "0xCDB7D0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x1E65AD4", Offset = "0x1E65AD4", VA = "0x1E65AD4", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x1E65C4C", Offset = "0x1E65C4C", VA = "0x1E65C4C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x1E65CCC", Offset = "0x1E65CCC", VA = "0x1E65CCC", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x1E65FE8", Offset = "0x1E65FE8", VA = "0x1E65FE8")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000161")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001A9")]
			public class BoneLink
			{
				[Token(Token = "0x4000A91")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC7D4", Offset = "0xCDC7D4")]
				public Transform bone;

				[Token(Token = "0x4000A92")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC80C", Offset = "0xCDC80C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDC80C", Offset = "0xCDC80C")]
				public float weight;

				[Token(Token = "0x4000A93")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000A94")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000AD4")]
				[Address(RVA = "0x1E658DC", Offset = "0x1E658DC", VA = "0x1E658DC")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000AD5")]
				[Address(RVA = "0x1E65674", Offset = "0x1E65674", VA = "0x1E65674")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000AD6")]
				[Address(RVA = "0x1E65A4C", Offset = "0x1E65A4C", VA = "0x1E65A4C")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB808", Offset = "0xCDB808")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB840", Offset = "0xCDB840")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x1E6556C", Offset = "0x1E6556C", VA = "0x1E6556C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x1E65610", Offset = "0x1E65610", VA = "0x1E65610", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x1E65680", Offset = "0x1E65680", VA = "0x1E65680", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x1E65A38", Offset = "0x1E65A38", VA = "0x1E65A38")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7E00", Offset = "0xCD7E00")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7E38", Offset = "0xCD7E38")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000B2")]
		public bool inProgress
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x1E64EA4", Offset = "0x1E64EA4", VA = "0x1E64EA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1E64F74", Offset = "0x1E64F74", VA = "0x1E64F74", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1E65194", Offset = "0x1E65194", VA = "0x1E65194")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1E65500", Offset = "0x1E65500", VA = "0x1E65500")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x2000162")]
		public abstract class Offset
		{
			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB878", Offset = "0xCDB878")]
			public string name;

			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB8B0", Offset = "0xCDB8B0")]
			public Collider collider;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB8E8", Offset = "0xCDB8E8")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDB934", Offset = "0xCDB934")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDB944", Offset = "0xCDB944")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDB954", Offset = "0xCDB954")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDB964", Offset = "0xCDB964")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000148")]
			protected float crossFader
			{
				[Token(Token = "0x60009F2")]
				[Address(RVA = "0x1E666F4", Offset = "0x1E666F4", VA = "0x1E666F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFBF8", Offset = "0xCDFBF8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009F3")]
				[Address(RVA = "0x1E666FC", Offset = "0x1E666FC", VA = "0x1E666FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFC08", Offset = "0xCDFC08")]
				private set
				{
				}
			}

			[Token(Token = "0x17000149")]
			protected float timer
			{
				[Token(Token = "0x60009F4")]
				[Address(RVA = "0x1E66704", Offset = "0x1E66704", VA = "0x1E66704")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFC18", Offset = "0xCDFC18")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009F5")]
				[Address(RVA = "0x1E6670C", Offset = "0x1E6670C", VA = "0x1E6670C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFC28", Offset = "0xCDFC28")]
				private set
				{
				}
			}

			[Token(Token = "0x1700014A")]
			protected Vector3 force
			{
				[Token(Token = "0x60009F6")]
				[Address(RVA = "0x1E66714", Offset = "0x1E66714", VA = "0x1E66714")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFC38", Offset = "0xCDFC38")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60009F7")]
				[Address(RVA = "0x1E66720", Offset = "0x1E66720", VA = "0x1E66720")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFC48", Offset = "0xCDFC48")]
				private set
				{
				}
			}

			[Token(Token = "0x1700014B")]
			protected Vector3 point
			{
				[Token(Token = "0x60009F8")]
				[Address(RVA = "0x1E6672C", Offset = "0x1E6672C", VA = "0x1E6672C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFC58", Offset = "0xCDFC58")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60009F9")]
				[Address(RVA = "0x1E66738", Offset = "0x1E66738", VA = "0x1E66738")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDFC68", Offset = "0xCDFC68")]
				private set
				{
				}
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x1E665AC", Offset = "0x1E665AC", VA = "0x1E665AC")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x1E66210", Offset = "0x1E66210", VA = "0x1E66210")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60009FC")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x60009FD")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60009FE")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x1E66744", Offset = "0x1E66744", VA = "0x1E66744")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000163")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001AA")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000A95")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC860", Offset = "0xCDC860")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000A96")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC898", Offset = "0xCDC898")]
				public float weight;

				[Token(Token = "0x4000A97")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000A98")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000AD7")]
				[Address(RVA = "0x1E66C00", Offset = "0x1E66C00", VA = "0x1E66C00")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000AD8")]
				[Address(RVA = "0x1E669BC", Offset = "0x1E669BC", VA = "0x1E669BC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000AD9")]
				[Address(RVA = "0x1E66D1C", Offset = "0x1E66D1C", VA = "0x1E66D1C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB974", Offset = "0xCDB974")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB9AC", Offset = "0xCDB9AC")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDB9E4", Offset = "0xCDB9E4")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x1E66758", Offset = "0x1E66758", VA = "0x1E66758", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x1E66950", Offset = "0x1E66950", VA = "0x1E66950", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x1E669D0", Offset = "0x1E669D0", VA = "0x1E669D0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x1E66D00", Offset = "0x1E66D00", VA = "0x1E66D00")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000164")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001AB")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000A99")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC8D0", Offset = "0xCDC8D0")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000A9A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC908", Offset = "0xCDC908")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDC908", Offset = "0xCDC908")]
				public float weight;

				[Token(Token = "0x4000A9B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000A9C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000ADA")]
				[Address(RVA = "0x1E67184", Offset = "0x1E67184", VA = "0x1E67184")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000ADB")]
				[Address(RVA = "0x1E66E6C", Offset = "0x1E66E6C", VA = "0x1E66E6C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000ADC")]
				[Address(RVA = "0x1E672C0", Offset = "0x1E672C0", VA = "0x1E672C0")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBA1C", Offset = "0xCDBA1C")]
			public int curveIndex;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBA54", Offset = "0xCDBA54")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x1E66D24", Offset = "0x1E66D24", VA = "0x1E66D24", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x1E66E08", Offset = "0x1E66E08", VA = "0x1E66E08", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x1E66E78", Offset = "0x1E66E78", VA = "0x1E66E78", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x1E672AC", Offset = "0x1E672AC", VA = "0x1E672AC")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7E70", Offset = "0xCD7E70")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7EA8", Offset = "0xCD7EA8")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1E66144", Offset = "0x1E66144", VA = "0x1E66144", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1E66364", Offset = "0x1E66364", VA = "0x1E66364")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1E666EC", Offset = "0x1E666EC", VA = "0x1E666EC")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000165")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001AC")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A9D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC95C", Offset = "0xCDC95C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A9E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC994", Offset = "0xCDC994")]
				public float weight;

				[Token(Token = "0x6000ADD")]
				[Address(RVA = "0x1EB5790", Offset = "0x1EB5790", VA = "0x1EB5790")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBA8C", Offset = "0xCDBA8C")]
			public Transform transform;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBAC4", Offset = "0xCDBAC4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBAFC", Offset = "0xCDBAFC")]
			public float speed;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBB34", Offset = "0xCDBB34")]
			public float acceleration;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBB6C", Offset = "0xCDBB6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDBB6C", Offset = "0xCDBB6C")]
			public float matchVelocity;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBBC0", Offset = "0xCDBBC0")]
			public float gravity;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x1EB525C", Offset = "0x1EB525C", VA = "0x1EB525C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x1EB53F4", Offset = "0x1EB53F4", VA = "0x1EB53F4")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x1EB5774", Offset = "0x1EB5774", VA = "0x1EB5774")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7EE0", Offset = "0xCD7EE0")]
		public Body[] bodies;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7F18", Offset = "0xCD7F18")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1EB51E4", Offset = "0x1EB51E4", VA = "0x1EB51E4")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1EB5338", Offset = "0x1EB5338", VA = "0x1EB5338", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x1EB576C", Offset = "0x1EB576C", VA = "0x1EB576C")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000166")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBBF8", Offset = "0xCDBBF8")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBC30", Offset = "0xCDBC30")]
			public float spring;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBC68", Offset = "0xCDBC68")]
			public bool x;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBCA0", Offset = "0xCDBCA0")]
			public bool y;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBCD8", Offset = "0xCDBCD8")]
			public bool z;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBD10", Offset = "0xCDBD10")]
			public float minX;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBD48", Offset = "0xCDBD48")]
			public float maxX;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBD80", Offset = "0xCDBD80")]
			public float minY;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBDB8", Offset = "0xCDBDB8")]
			public float maxY;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBDF0", Offset = "0xCDBDF0")]
			public float minZ;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBE28", Offset = "0xCDBE28")]
			public float maxZ;

			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x1A97610", Offset = "0x1A97610", VA = "0x1A97610")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x1A97B28", Offset = "0x1A97B28", VA = "0x1A97B28")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x1A97B58", Offset = "0x1A97B58", VA = "0x1A97B58")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x1A97C30", Offset = "0x1A97C30", VA = "0x1A97C30")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD42FC", Offset = "0xCD42FC")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x1700014C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A12")]
				[Address(RVA = "0x1A97AB8", Offset = "0x1A97AB8", VA = "0x1A97AB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A14")]
				[Address(RVA = "0x1A97B20", Offset = "0x1A97B20", VA = "0x1A97B20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x1A9741C", Offset = "0x1A9741C", VA = "0x1A9741C")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x1A97978", Offset = "0x1A97978", VA = "0x1A97978", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x1A9797C", Offset = "0x1A9797C", VA = "0x1A9797C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x1A97AC0", Offset = "0x1A97AC0", VA = "0x1A97AC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7F50", Offset = "0xCD7F50")]
		public float weight;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7F88", Offset = "0xCD7F88")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000B3")]
		protected float deltaTime
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x1A97354", Offset = "0x1A97354", VA = "0x1A97354")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005E1")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x1A97380", Offset = "0x1A97380", VA = "0x1A97380", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1A973AC", Offset = "0x1A973AC", VA = "0x1A973AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDED20", Offset = "0xCDED20")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1A97448", Offset = "0x1A97448", VA = "0x1A97448")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1A97554", Offset = "0x1A97554", VA = "0x1A97554")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1A97870", Offset = "0x1A97870", VA = "0x1A97870", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1A97968", Offset = "0x1A97968", VA = "0x1A97968")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD430C", Offset = "0xCD430C")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x1700014E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A18")]
				[Address(RVA = "0x1A98080", Offset = "0x1A98080", VA = "0x1A98080", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A1A")]
				[Address(RVA = "0x1A980E8", Offset = "0x1A980E8", VA = "0x1A980E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x1A97D00", Offset = "0x1A97D00", VA = "0x1A97D00")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x1A97F40", Offset = "0x1A97F40", VA = "0x1A97F40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x1A97F44", Offset = "0x1A97F44", VA = "0x1A97F44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x1A98088", Offset = "0x1A98088", VA = "0x1A98088", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7FC0", Offset = "0xCD7FC0")]
		public float weight;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD7FF8", Offset = "0xCD7FF8")]
		public VRIK ik;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000B4")]
		protected float deltaTime
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x1A97C38", Offset = "0x1A97C38", VA = "0x1A97C38")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005E9")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1A97C64", Offset = "0x1A97C64", VA = "0x1A97C64", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1A97C90", Offset = "0x1A97C90", VA = "0x1A97C90")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDED84", Offset = "0xCDED84")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1A97D2C", Offset = "0x1A97D2C", VA = "0x1A97D2C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1A97E38", Offset = "0x1A97E38", VA = "0x1A97E38", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1A97F30", Offset = "0x1A97F30", VA = "0x1A97F30")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000169")]
		public class EffectorLink
		{
			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x1A981B0", Offset = "0x1A981B0", VA = "0x1A981B0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x1A98600", Offset = "0x1A98600", VA = "0x1A98600")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1A980F0", Offset = "0x1A980F0", VA = "0x1A980F0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1A984E8", Offset = "0x1A984E8", VA = "0x1A984E8")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1A985A0", Offset = "0x1A985A0", VA = "0x1A985A0")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200016A")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20001AD")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A9F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC9CC", Offset = "0xCDC9CC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000AA0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDCA04", Offset = "0xCDCA04")]
				public float weight;

				[Token(Token = "0x6000ADE")]
				[Address(RVA = "0x1A98CB8", Offset = "0x1A98CB8", VA = "0x1A98CB8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBE60", Offset = "0xCDBE60")]
			public Transform[] raycastFrom;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBE98", Offset = "0xCDBE98")]
			public Transform raycastTo;

			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBED0", Offset = "0xCDBED0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDBED0", Offset = "0xCDBED0")]
			public float raycastRadius;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBF24", Offset = "0xCDBF24")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBF5C", Offset = "0xCDBF5C")]
			public float smoothTimeIn;

			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBF94", Offset = "0xCDBF94")]
			public float smoothTimeOut;

			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDBFCC", Offset = "0xCDBFCC")]
			public LayerMask layers;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x1A9868C", Offset = "0x1A9868C", VA = "0x1A9868C")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x1A98898", Offset = "0x1A98898", VA = "0x1A98898")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x1A98A30", Offset = "0x1A98A30", VA = "0x1A98A30")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x1A98CA4", Offset = "0x1A98CA4", VA = "0x1A98CA4")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8030", Offset = "0xCD8030")]
		public Avoider[] avoiders;

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1A98608", Offset = "0x1A98608", VA = "0x1A98608", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1A98888", Offset = "0x1A98888", VA = "0x1A98888")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200016B")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20001AE")]
			public class EffectorLink
			{
				[Token(Token = "0x4000AA1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDCA3C", Offset = "0xCDCA3C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000AA2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDCA74", Offset = "0xCDCA74")]
				public float weight;

				[Token(Token = "0x6000ADF")]
				[Address(RVA = "0x1A9BBD0", Offset = "0x1A9BBD0", VA = "0x1A9BBD0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC004", Offset = "0xCDC004")]
			public Vector3 offset;

			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC03C", Offset = "0xCDC03C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDC03C", Offset = "0xCDC03C")]
			public float additivity;

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC090", Offset = "0xCDC090")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC0C8", Offset = "0xCDC0C8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x1A9A918", Offset = "0x1A9A918", VA = "0x1A9A918")]
			public void Start()
			{
			}

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x1A9B4A8", Offset = "0x1A9B4A8", VA = "0x1A9B4A8")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x1A9BBBC", Offset = "0x1A9BBBC", VA = "0x1A9BBBC")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016C")]
		public enum Handedness
		{
			[Token(Token = "0x400099D")]
			Right,
			[Token(Token = "0x400099E")]
			Left
		}

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8068", Offset = "0xCD8068")]
		public AimIK aimIK;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD80A0", Offset = "0xCD80A0")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD80D8", Offset = "0xCD80D8")]
		public Handedness handedness;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8110", Offset = "0xCD8110")]
		public bool twoHanded;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8148", Offset = "0xCD8148")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8180", Offset = "0xCD8180")]
		public float magnitudeRandom;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD81B8", Offset = "0xCD81B8")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD81F0", Offset = "0xCD81F0")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8228", Offset = "0xCD8228")]
		public float blendTime;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCD8260", Offset = "0xCD8260")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8260", Offset = "0xCD8260")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000B5")]
		public bool isFinished
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x1A9A6F0", Offset = "0x1A9A6F0", VA = "0x1A9A6F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B6")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x1A9B75C", Offset = "0x1A9B75C", VA = "0x1A9B75C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x1A9B79C", Offset = "0x1A9B79C", VA = "0x1A9B79C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		private Transform primaryHand
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x1A9B71C", Offset = "0x1A9B71C", VA = "0x1A9B71C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x1A9B73C", Offset = "0x1A9B73C", VA = "0x1A9B73C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1A9A720", Offset = "0x1A9A720", VA = "0x1A9A720")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1A9A74C", Offset = "0x1A9A74C", VA = "0x1A9A74C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1A9A9C8", Offset = "0x1A9A9C8", VA = "0x1A9A9C8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1A9B7DC", Offset = "0x1A9B7DC", VA = "0x1A9B7DC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1A9B934", Offset = "0x1A9B934", VA = "0x1A9B934")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1A9B970", Offset = "0x1A9B970", VA = "0x1A9B970", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1A9BB08", Offset = "0x1A9BB08", VA = "0x1A9BB08")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD82C0", Offset = "0xCD82C0")]
		public float weight;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD82F8", Offset = "0xCD82F8")]
		public float offset;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1A9F3C8", Offset = "0x1A9F3C8", VA = "0x1A9F3C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1A9F49C", Offset = "0x1A9F49C", VA = "0x1A9F49C")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1A9F588", Offset = "0x1A9F588", VA = "0x1A9F588")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1A9F9D0", Offset = "0x1A9F9D0", VA = "0x1A9F9D0")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1A9FA08", Offset = "0x1A9FA08", VA = "0x1A9FA08")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1A9FB00", Offset = "0x1A9FB00", VA = "0x1A9FB00")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x200016D")]
		public class Settings
		{
			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC100", Offset = "0xCDC100")]
			public float scaleMlp;

			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC138", Offset = "0xCDC138")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC170", Offset = "0xCDC170")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC1A8", Offset = "0xCDC1A8")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC1E0", Offset = "0xCDC1E0")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC218", Offset = "0xCDC218")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC250", Offset = "0xCDC250")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC288", Offset = "0xCDC288")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC2C0", Offset = "0xCDC2C0")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCDC2F8", Offset = "0xCDC2F8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC2F8", Offset = "0xCDC2F8")]
			public Vector3 headOffset;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC348", Offset = "0xCDC348")]
			public Vector3 handOffset;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC380", Offset = "0xCDC380")]
			public float footForwardOffset;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC3B8", Offset = "0xCDC3B8")]
			public float footInwardOffset;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC3F0", Offset = "0xCDC3F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDC3F0", Offset = "0xCDC3F0")]
			public float footHeadingOffset;

			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDC44C", Offset = "0xCDC44C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCDC464", Offset = "0xCDC464")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x1AA49A4", Offset = "0x1AA49A4", VA = "0x1AA49A4")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016E")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20001AF")]
			public class Target
			{
				[Token(Token = "0x4000AA3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000AA4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000AA5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000AE0")]
				[Address(RVA = "0x1AA3A50", Offset = "0x1AA3A50", VA = "0x1AA3A50")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000AE1")]
				[Address(RVA = "0x1AA45A4", Offset = "0x1AA45A4", VA = "0x1AA45A4")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x40009B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x40009B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x40009B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x40009B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x40009B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x40009B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40009B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40009BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x1AA3064", Offset = "0x1AA3064", VA = "0x1AA3064")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1AA1C1C", Offset = "0x1AA1C1C", VA = "0x1AA1C1C")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1AA1D84", Offset = "0x1AA1D84", VA = "0x1AA1D84")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1AA306C", Offset = "0x1AA306C", VA = "0x1AA306C")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1AA3B14", Offset = "0x1AA3B14", VA = "0x1AA3B14")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1AA4604", Offset = "0x1AA4604", VA = "0x1AA4604")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1AA4A9C", Offset = "0x1AA4A9C", VA = "0x1AA4A9C")]
		private void Start()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1AA4AF4", Offset = "0x1AA4AF4", VA = "0x1AA4AF4")]
		private void Update()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1AA4B28", Offset = "0x1AA4B28", VA = "0x1AA4B28")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1AA4CB0", Offset = "0x1AA4CB0", VA = "0x1AA4CB0")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD8330", Offset = "0xCD8330")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000BA")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x1AA4CC8", Offset = "0x1AA4CC8", VA = "0x1AA4CC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDEDE8", Offset = "0xCDEDE8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x1AA4CD4", Offset = "0x1AA4CD4", VA = "0x1AA4CD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDEDF8", Offset = "0xCDEDF8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x1AA4CE0", Offset = "0x1AA4CE0", VA = "0x1AA4CE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1AA382C", Offset = "0x1AA382C", VA = "0x1AA382C")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1AA4834", Offset = "0x1AA4834", VA = "0x1AA4834")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x1AA4DB8", Offset = "0x1AA4DB8", VA = "0x1AA4DB8")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x1AA525C", Offset = "0x1AA525C", VA = "0x1AA525C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1AA5354", Offset = "0x1AA5354", VA = "0x1AA5354")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000A1")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200016F")]
		public class Offset
		{
			[Token(Token = "0x40009BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40009BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x40009BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x1A8311C", Offset = "0x1A8311C", VA = "0x1A8311C")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x1A833A8", Offset = "0x1A833A8", VA = "0x1A833A8")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x1A8304C", Offset = "0x1A8304C", VA = "0x1A8304C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1A830A4", Offset = "0x1A830A4", VA = "0x1A830A4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1A832C4", Offset = "0x1A832C4", VA = "0x1A832C4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1A833A0", Offset = "0x1A833A0", VA = "0x1A833A0")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1A7A760", Offset = "0x1A7A760", VA = "0x1A7A760")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x1A7A7E4", Offset = "0x1A7A7E4", VA = "0x1A7A7E4")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8340", Offset = "0xCD8340")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1A7A7EC", Offset = "0x1A7A7EC", VA = "0x1A7A7EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1A7A8F4", Offset = "0x1A7A8F4", VA = "0x1A7A8F4")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x1A8D640", Offset = "0x1A8D640", VA = "0x1A8D640")]
		private void Start()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x1A8D684", Offset = "0x1A8D684", VA = "0x1A8D684")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x1A8D8E4", Offset = "0x1A8D8E4", VA = "0x1A8D8E4")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8378", Offset = "0xCD8378")]
		public AimPoser aimPoser;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD83B0", Offset = "0xCD83B0")]
		public AimIK aim;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD83E8", Offset = "0xCD83E8")]
		public LookAtIK lookAt;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8420", Offset = "0xCD8420")]
		public Animator animator;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8458", Offset = "0xCD8458")]
		public float crossfadeTime;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8490", Offset = "0xCD8490")]
		public float minAimDistance;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x1A8D8EC", Offset = "0x1A8D8EC", VA = "0x1A8D8EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1A8D930", Offset = "0x1A8D930", VA = "0x1A8D930")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1A8DA84", Offset = "0x1A8DA84", VA = "0x1A8DA84")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1A8DC88", Offset = "0x1A8DC88", VA = "0x1A8DC88")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1A8DE80", Offset = "0x1A8DE80", VA = "0x1A8DE80")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1A8DF58", Offset = "0x1A8DF58", VA = "0x1A8DF58")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCD84C8", Offset = "0xCD84C8")]
		public Animator animator;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCD8500", Offset = "0xCD8500")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8538", Offset = "0xCD8538")]
		public float lookAtWeight;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8550", Offset = "0xCD8550")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8568", Offset = "0xCD8568")]
		public float lookAtHeadWeight;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8580", Offset = "0xCD8580")]
		public float lookAtEyesWeight;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8598", Offset = "0xCD8598")]
		public float lookAtClampWeight;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD85B0", Offset = "0xCD85B0")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD85C8", Offset = "0xCD85C8")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCD85E0", Offset = "0xCD85E0")]
		public Transform footTargetBiped;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8618", Offset = "0xCD8618")]
		public float footPositionWeight;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8630", Offset = "0xCD8630")]
		public float footRotationWeight;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCD8648", Offset = "0xCD8648")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8680", Offset = "0xCD8680")]
		public float handPositionWeight;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8698", Offset = "0xCD8698")]
		public float handRotationWeight;

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1A7C484", Offset = "0x1A7C484", VA = "0x1A7C484")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1A7C930", Offset = "0x1A7C930", VA = "0x1A7C930")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1A86DB4", Offset = "0x1A86DB4", VA = "0x1A86DB4")]
		private void Update()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x1A877E8", Offset = "0x1A877E8", VA = "0x1A877E8")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1A874D0", Offset = "0x1A874D0", VA = "0x1A874D0")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1A87990", Offset = "0x1A87990", VA = "0x1A87990")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000BB")]
		public Vector3 inputVector
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x1A879BC", Offset = "0x1A879BC", VA = "0x1A879BC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1A87A5C", Offset = "0x1A87A5C", VA = "0x1A87A5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1A87CF4", Offset = "0x1A87CF4", VA = "0x1A87CF4")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x2000170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD431C", Offset = "0xCD431C")]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x17000150")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A2B")]
				[Address(RVA = "0x1A890DC", Offset = "0x1A890DC", VA = "0x1A890DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000151")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A2D")]
				[Address(RVA = "0x1A89144", Offset = "0x1A89144", VA = "0x1A89144", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x1A88CD4", Offset = "0x1A88CD4", VA = "0x1A88CD4")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x1A88DA8", Offset = "0x1A88DA8", VA = "0x1A88DA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x1A88DAC", Offset = "0x1A88DAC", VA = "0x1A88DAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x1A890E4", Offset = "0x1A890E4", VA = "0x1A890E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000BC")]
		public bool isStepping
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x1A87D08", Offset = "0x1A87D08", VA = "0x1A87D08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BD")]
		public Vector3 position
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x1A8795C", Offset = "0x1A8795C", VA = "0x1A8795C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x1A87D1C", Offset = "0x1A87D1C", VA = "0x1A87D1C")]
			set
			{
			}
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1A87D6C", Offset = "0x1A87D6C", VA = "0x1A87D6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1A87FB8", Offset = "0x1A87FB8", VA = "0x1A87FB8")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1A881D4", Offset = "0x1A881D4", VA = "0x1A881D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1A88480", Offset = "0x1A88480", VA = "0x1A88480")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1A88840", Offset = "0x1A88840", VA = "0x1A88840")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1A88A9C", Offset = "0x1A88A9C", VA = "0x1A88A9C")]
		private void Update()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1A883D4", Offset = "0x1A883D4", VA = "0x1A883D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDEE08", Offset = "0xCDEE08")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1A88D00", Offset = "0x1A88D00", VA = "0x1A88D00")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1A8914C", Offset = "0x1A8914C", VA = "0x1A8914C")]
		private void Start()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1A891F8", Offset = "0x1A891F8", VA = "0x1A891F8")]
		private void Update()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1A8948C", Offset = "0x1A8948C", VA = "0x1A8948C")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000171")]
		public struct Warp
		{
			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC4B4", Offset = "0xCDC4B4")]
			public int animationLayer;

			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC4EC", Offset = "0xCDC4EC")]
			public string animationState;

			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC524", Offset = "0xCDC524")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC55C", Offset = "0xCDC55C")]
			public Transform warpFrom;

			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC594", Offset = "0xCDC594")]
			public Transform warpTo;

			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC5CC", Offset = "0xCDC5CC")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x2000172")]
		public enum EffectorMode
		{
			[Token(Token = "0x40009CB")]
			PositionOffset,
			[Token(Token = "0x40009CC")]
			Position
		}

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD86B0", Offset = "0xCD86B0")]
		public Animator animator;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD86E8", Offset = "0xCD86E8")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCD8720", Offset = "0xCD8720")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8720", Offset = "0xCD8720")]
		public Warp[] warps;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1A7A96C", Offset = "0x1A7A96C", VA = "0x1A7A96C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1A7A998", Offset = "0x1A7A998", VA = "0x1A7A998")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1A7ABB8", Offset = "0x1A7ABB8", VA = "0x1A7ABB8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1A7AF6C", Offset = "0x1A7AF6C", VA = "0x1A7AF6C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1A7B00C", Offset = "0x1A7B00C", VA = "0x1A7B00C")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD2CB8", Offset = "0xCD2CB8")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1A7B014", Offset = "0x1A7B014", VA = "0x1A7B014", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1A7B06C", Offset = "0x1A7B06C", VA = "0x1A7B06C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1A7B2A4", Offset = "0x1A7B2A4", VA = "0x1A7B2A4", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1A7B508", Offset = "0x1A7B508", VA = "0x1A7B508")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD2D1C", Offset = "0xCD2D1C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD2D1C", Offset = "0xCD2D1C")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8770", Offset = "0xCD8770")]
		public float headLookWeight;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1A7B51C", Offset = "0x1A7B51C", VA = "0x1A7B51C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1A7B688", Offset = "0x1A7B688", VA = "0x1A7B688", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1A7B704", Offset = "0x1A7B704", VA = "0x1A7B704")]
		private void Read()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1A7B85C", Offset = "0x1A7B85C", VA = "0x1A7B85C")]
		private void AimIK()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1A7B8A4", Offset = "0x1A7B8A4", VA = "0x1A7B8A4")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1A7BE9C", Offset = "0x1A7BE9C", VA = "0x1A7BE9C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1A7BC60", Offset = "0x1A7BC60", VA = "0x1A7BC60")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x1A7C1F4", Offset = "0x1A7C1F4", VA = "0x1A7C1F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1A7C2EC", Offset = "0x1A7C2EC", VA = "0x1A7C2EC")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD2DA8", Offset = "0xCD2DA8")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1A7D8E4", Offset = "0x1A7D8E4", VA = "0x1A7D8E4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1A7D944", Offset = "0x1A7D944", VA = "0x1A7D944", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1A7DC08", Offset = "0x1A7DC08", VA = "0x1A7DC08")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1A7DDC0", Offset = "0x1A7DDC0", VA = "0x1A7DDC0")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD2E0C", Offset = "0xCD2E0C")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000BE")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x1A7EBF4", Offset = "0x1A7EBF4", VA = "0x1A7EBF4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BF")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x1A7EC94", Offset = "0x1A7EC94", VA = "0x1A7EC94")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1A7E940", Offset = "0x1A7E940", VA = "0x1A7E940")]
		private void Start()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1A7E9B0", Offset = "0x1A7E9B0", VA = "0x1A7E9B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1A7ED34", Offset = "0x1A7ED34", VA = "0x1A7ED34")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8788", Offset = "0xCD8788")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1A816D4", Offset = "0x1A816D4", VA = "0x1A816D4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1A81CB8", Offset = "0x1A81CB8", VA = "0x1A81CB8")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1A81CC0", Offset = "0x1A81CC0", VA = "0x1A81CC0")]
		private void Start()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1A81D60", Offset = "0x1A81D60", VA = "0x1A81D60")]
		private void Update()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1A821DC", Offset = "0x1A821DC", VA = "0x1A821DC")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1A82288", Offset = "0x1A82288", VA = "0x1A82288")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000173")]
		public class Limb
		{
			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x1A8245C", Offset = "0x1A8245C", VA = "0x1A8245C")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x1A82590", Offset = "0x1A82590", VA = "0x1A82590")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1A82310", Offset = "0x1A82310", VA = "0x1A82310")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1A824E0", Offset = "0x1A824E0", VA = "0x1A824E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1A8257C", Offset = "0x1A8257C", VA = "0x1A8257C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1A82580", Offset = "0x1A82580", VA = "0x1A82580")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1A825A0", Offset = "0x1A825A0", VA = "0x1A825A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1A8260C", Offset = "0x1A8260C", VA = "0x1A8260C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1A826E4", Offset = "0x1A826E4", VA = "0x1A826E4")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD87A0", Offset = "0xCD87A0")]
		public Transform target;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD87D8", Offset = "0xCD87D8")]
		public Transform pin;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8810", Offset = "0xCD8810")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8848", Offset = "0xCD8848")]
		public AimIK aim;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8880", Offset = "0xCD8880")]
		public float weight;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD88B8", Offset = "0xCD88B8")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD88F0", Offset = "0xCD88F0")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x1A826EC", Offset = "0x1A826EC", VA = "0x1A826EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1A82744", Offset = "0x1A82744", VA = "0x1A82744")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1A828E0", Offset = "0x1A828E0", VA = "0x1A828E0")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1A828E8", Offset = "0x1A828E8", VA = "0x1A828E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1A829A8", Offset = "0x1A829A8", VA = "0x1A829A8")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1A82A38", Offset = "0x1A82A38", VA = "0x1A82A38")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1A82F4C", Offset = "0x1A82F4C", VA = "0x1A82F4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1A83044", Offset = "0x1A83044", VA = "0x1A83044")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8928", Offset = "0xCD8928")]
		public float aimWeight;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8940", Offset = "0xCD8940")]
		public float sightWeight;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8958", Offset = "0xCD8958")]
		public float maxAngle;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CameraControllerFPS cam;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Recoil recoil;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8974", Offset = "0xCD8974")]
		public float cameraRecoilWeight;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool updateFrame;

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1A833B0", Offset = "0x1A833B0", VA = "0x1A833B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1A83510", Offset = "0x1A83510", VA = "0x1A83510")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1A8351C", Offset = "0x1A8351C", VA = "0x1A8351C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1A8385C", Offset = "0x1A8385C", VA = "0x1A8385C")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1A83AC4", Offset = "0x1A83AC4", VA = "0x1A83AC4")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1A835E0", Offset = "0x1A835E0", VA = "0x1A835E0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1A844E4", Offset = "0x1A844E4", VA = "0x1A844E4")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD2E70", Offset = "0xCD2E70")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD2E70", Offset = "0xCD2E70")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD898C", Offset = "0xCD898C")]
		public float walkSpeed;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1A84504", Offset = "0x1A84504", VA = "0x1A84504")]
		private void Start()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1A84574", Offset = "0x1A84574", VA = "0x1A84574")]
		private void Update()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1A84698", Offset = "0x1A84698", VA = "0x1A84698")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1A84748", Offset = "0x1A84748", VA = "0x1A84748")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1A84ADC", Offset = "0x1A84ADC", VA = "0x1A84ADC")]
		private void Update()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1A84C9C", Offset = "0x1A84C9C", VA = "0x1A84C9C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1A84E60", Offset = "0x1A84E60", VA = "0x1A84E60")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1A85204", Offset = "0x1A85204", VA = "0x1A85204")]
		private void Start()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1A853B0", Offset = "0x1A853B0", VA = "0x1A853B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1A8576C", Offset = "0x1A8576C", VA = "0x1A8576C")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1A8577C", Offset = "0x1A8577C", VA = "0x1A8577C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1A858B0", Offset = "0x1A858B0", VA = "0x1A858B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1A85A00", Offset = "0x1A85A00", VA = "0x1A85A00")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1A85A08", Offset = "0x1A85A08", VA = "0x1A85A08")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1A860D8", Offset = "0x1A860D8", VA = "0x1A860D8")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD2EFC", Offset = "0xCD2EFC")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD89A4", Offset = "0xCD89A4")]
		public InteractionObject interactionObject;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD89DC", Offset = "0xCD89DC")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1A860E0", Offset = "0x1A860E0", VA = "0x1A860E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1A86138", Offset = "0x1A86138", VA = "0x1A86138")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1A86444", Offset = "0x1A86444", VA = "0x1A86444")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000174")]
		public class Partner
		{
			[Token(Token = "0x40009D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x17000152")]
			private Transform neck
			{
				[Token(Token = "0x6000A32")]
				[Address(RVA = "0x1A86D48", Offset = "0x1A86D48", VA = "0x1A86D48")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x1A86480", Offset = "0x1A86480", VA = "0x1A86480")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x1A86500", Offset = "0x1A86500", VA = "0x1A86500")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x1A86B6C", Offset = "0x1A86B6C", VA = "0x1A86B6C")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x1A86DA0", Offset = "0x1A86DA0", VA = "0x1A86DA0")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1A8644C", Offset = "0x1A8644C", VA = "0x1A8644C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1A864A0", Offset = "0x1A864A0", VA = "0x1A864A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1A86B5C", Offset = "0x1A86B5C", VA = "0x1A86B5C")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000175")]
		public enum Mode
		{
			[Token(Token = "0x40009DC")]
			Position,
			[Token(Token = "0x40009DD")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000176")]
		public class Absorber
		{
			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC604", Offset = "0xCDC604")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40009DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCDC63C", Offset = "0xCDC63C")]
			public float weight;

			[Token(Token = "0x40009E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x40009E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x40009E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x1A895F4", Offset = "0x1A895F4", VA = "0x1A895F4")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x1A897D4", Offset = "0x1A897D4", VA = "0x1A897D4")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x1A89810", Offset = "0x1A89810", VA = "0x1A89810")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x1A899C0", Offset = "0x1A899C0", VA = "0x1A899C0")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x1A89BE4", Offset = "0x1A89BE4", VA = "0x1A89BE4")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8A14", Offset = "0xCD8A14")]
		public Mode mode;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8A4C", Offset = "0xCD8A4C")]
		public Absorber[] absorbers;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8A84", Offset = "0xCD8A84")]
		public AnimationCurve falloff;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8ABC", Offset = "0xCD8ABC")]
		public float falloffSpeed;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1A89494", Offset = "0x1A89494", VA = "0x1A89494", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1A89568", Offset = "0x1A89568", VA = "0x1A89568")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1A896C8", Offset = "0x1A896C8", VA = "0x1A896C8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1A89938", Offset = "0x1A89938", VA = "0x1A89938")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1A89AD0", Offset = "0x1A89AD0", VA = "0x1A89AD0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1A89BD4", Offset = "0x1A89BD4", VA = "0x1A89BD4")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1A89C64", Offset = "0x1A89C64", VA = "0x1A89C64")]
		private void Start()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1A89CDC", Offset = "0x1A89CDC", VA = "0x1A89CDC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1A89DA8", Offset = "0x1A89DA8", VA = "0x1A89DA8")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x1A89F08", Offset = "0x1A89F08", VA = "0x1A89F08")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000177")]
		public class EffectorLink
		{
			[Token(Token = "0x40009E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40009E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x40009E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x1A8AC64", Offset = "0x1A8AC64", VA = "0x1A8AC64")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x1A8A930", Offset = "0x1A8A930", VA = "0x1A8A930", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1A8AA30", Offset = "0x1A8AA30", VA = "0x1A8AA30", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1A8AC5C", Offset = "0x1A8AC5C", VA = "0x1A8AC5C")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD2F60", Offset = "0xCD2F60")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8AF4", Offset = "0xCD8AF4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8AF4", Offset = "0xCD8AF4")]
		public float weight;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8B48", Offset = "0xCD8B48")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8B80", Offset = "0xCD8B80")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8BCC", Offset = "0xCD8BCC")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1A8AC74", Offset = "0x1A8AC74", VA = "0x1A8AC74")]
		private void Start()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1A8AFB0", Offset = "0x1A8AFB0", VA = "0x1A8AFB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1A8B700", Offset = "0x1A8B700", VA = "0x1A8B700")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000C0")]
		private bool holding
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x1A8BA44", Offset = "0x1A8BA44", VA = "0x1A8BA44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1A8B784", Offset = "0x1A8B784", VA = "0x1A8B784")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600069C")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1A8BA64", Offset = "0x1A8BA64", VA = "0x1A8BA64")]
		private void Start()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1A8BBCC", Offset = "0x1A8BBCC", VA = "0x1A8BBCC")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1A8BD48", Offset = "0x1A8BD48", VA = "0x1A8BD48")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1A8BE28", Offset = "0x1A8BE28", VA = "0x1A8BE28")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1A8BF54", Offset = "0x1A8BF54", VA = "0x1A8BF54")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1A8C164", Offset = "0x1A8C164", VA = "0x1A8C164")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1A8C304", Offset = "0x1A8C304", VA = "0x1A8C304")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1A8C318", Offset = "0x1A8C318", VA = "0x1A8C318", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1A8C50C", Offset = "0x1A8C50C", VA = "0x1A8C50C")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1A8C520", Offset = "0x1A8C520", VA = "0x1A8C520", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x1A8C6CC", Offset = "0x1A8C6CC", VA = "0x1A8C6CC")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x1A8CE48", Offset = "0x1A8CE48", VA = "0x1A8CE48")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x1A8CF20", Offset = "0x1A8CF20", VA = "0x1A8CF20")]
		private void Update()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1A8D0C8", Offset = "0x1A8D0C8", VA = "0x1A8D0C8")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD2FC4", Offset = "0xCD2FC4")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1A8D0D0", Offset = "0x1A8D0D0", VA = "0x1A8D0D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1A8D128", Offset = "0x1A8D128", VA = "0x1A8D128")]
		private void Update()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1A8D184", Offset = "0x1A8D184", VA = "0x1A8D184")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1A8D25C", Offset = "0x1A8D25C", VA = "0x1A8D25C")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD432C", Offset = "0xCD432C")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40009E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x17000153")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A3E")]
				[Address(RVA = "0x1A8D5D0", Offset = "0x1A8D5D0", VA = "0x1A8D5D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000154")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A40")]
				[Address(RVA = "0x1A8D638", Offset = "0x1A8D638", VA = "0x1A8D638", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x1A8D3EC", Offset = "0x1A8D3EC", VA = "0x1A8D3EC")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x1A8D428", Offset = "0x1A8D428", VA = "0x1A8D428", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x1A8D42C", Offset = "0x1A8D42C", VA = "0x1A8D42C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x1A8D5D8", Offset = "0x1A8D5D8", VA = "0x1A8D5D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1A8D26C", Offset = "0x1A8D26C", VA = "0x1A8D26C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1A8D324", Offset = "0x1A8D324", VA = "0x1A8D324")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1A8D36C", Offset = "0x1A8D36C", VA = "0x1A8D36C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDEE6C", Offset = "0xCDEE6C")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1A8D418", Offset = "0x1A8D418", VA = "0x1A8D418")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD4028", Offset = "0xCD4028")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000179")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD433C", Offset = "0xCD433C")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x17000155")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A44")]
				[Address(RVA = "0x1976378", Offset = "0x1976378", VA = "0x1976378", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000156")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A46")]
				[Address(RVA = "0x19763E0", Offset = "0x19763E0", VA = "0x19763E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x1976220", Offset = "0x1976220", VA = "0x1976220")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x1976254", Offset = "0x1976254", VA = "0x1976254", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x1976258", Offset = "0x1976258", VA = "0x1976258", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x1976380", Offset = "0x1976380", VA = "0x1976380", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1976100", Offset = "0x1976100", VA = "0x1976100")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x19761B0", Offset = "0x19761B0", VA = "0x19761B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDEED0", Offset = "0xCDEED0")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x197624C", Offset = "0x197624C", VA = "0x197624C")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017A")]
		public class EffectorLink
		{
			[Token(Token = "0x40009ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40009EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40009EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40009F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x40009F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x40009F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x40009F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x40009F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x40009FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x40009FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x40009FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x40009FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000A00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x1976460", Offset = "0x1976460", VA = "0x1976460")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x19770E8", Offset = "0x19770E8", VA = "0x19770E8")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x19767A0", Offset = "0x19767A0", VA = "0x19767A0")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x19771D0", Offset = "0x19771D0", VA = "0x19771D0")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x197736C", Offset = "0x197736C", VA = "0x197736C")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x1977408", Offset = "0x1977408", VA = "0x1977408")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x19774A0", Offset = "0x19774A0", VA = "0x19774A0")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x1976F80", Offset = "0x1976F80", VA = "0x1976F80")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x1977538", Offset = "0x1977538", VA = "0x1977538")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x19763E8", Offset = "0x19763E8", VA = "0x19763E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1976734", Offset = "0x1976734", VA = "0x1976734")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x1976EB8", Offset = "0x1976EB8", VA = "0x1976EB8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x19770E0", Offset = "0x19770E0", VA = "0x19770E0")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8C18", Offset = "0xCD8C18")]
		public Transform to;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8C50", Offset = "0xCD8C50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8C50", Offset = "0xCD8C50")]
		public float transferMotion;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x197756C", Offset = "0x197756C", VA = "0x197756C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x19775A8", Offset = "0x19775A8", VA = "0x19775A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x1977700", Offset = "0x1977700", VA = "0x1977700")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8CA4", Offset = "0xCD8CA4")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x19778C0", Offset = "0x19778C0", VA = "0x19778C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1977A78", Offset = "0x1977A78", VA = "0x1977A78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1977D14", Offset = "0x1977D14", VA = "0x1977D14")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x1977DE0", Offset = "0x1977DE0", VA = "0x1977DE0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1977ED8", Offset = "0x1977ED8", VA = "0x1977ED8")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1978248", Offset = "0x1978248", VA = "0x1978248", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x19786C0", Offset = "0x19786C0", VA = "0x19786C0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1978918", Offset = "0x1978918", VA = "0x1978918")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1A84758", Offset = "0x1A84758", VA = "0x1A84758")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x1A84A54", Offset = "0x1A84A54", VA = "0x1A84A54")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1A84AD4", Offset = "0x1A84AD4", VA = "0x1A84AD4")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200017B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD434C", Offset = "0xCD434C")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x17000157")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A53")]
				[Address(RVA = "0x1A8CDD8", Offset = "0x1A8CDD8", VA = "0x1A8CDD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000158")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A55")]
				[Address(RVA = "0x1A8CE40", Offset = "0x1A8CE40", VA = "0x1A8CE40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x1A8CA94", Offset = "0x1A8CA94", VA = "0x1A8CA94")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x1A8CCA0", Offset = "0x1A8CCA0", VA = "0x1A8CCA0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x1A8CCA4", Offset = "0x1A8CCA4", VA = "0x1A8CCA4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x1A8CDE0", Offset = "0x1A8CDE0", VA = "0x1A8CDE0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1A8C6E0", Offset = "0x1A8C6E0", VA = "0x1A8C6E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1A8C86C", Offset = "0x1A8C86C", VA = "0x1A8C86C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x1A8C7FC", Offset = "0x1A8C7FC", VA = "0x1A8C7FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDEF34", Offset = "0xCDEF34")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1A8CAC0", Offset = "0x1A8CAC0", VA = "0x1A8CAC0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1A8CBA4", Offset = "0x1A8CBA4", VA = "0x1A8CBA4")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1A8CC84", Offset = "0x1A8CC84", VA = "0x1A8CC84")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8CDC", Offset = "0xCD8CDC")]
		public float weight;

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1A7C34C", Offset = "0x1A7C34C", VA = "0x1A7C34C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1A7C3B8", Offset = "0x1A7C3B8", VA = "0x1A7C3B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1A7C474", Offset = "0x1A7C474", VA = "0x1A7C474")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017C")]
		public class Part
		{
			[Token(Token = "0x4000A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x197778C", Offset = "0x197778C", VA = "0x197778C")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x19778B8", Offset = "0x19778B8", VA = "0x19778B8")]
			public Part()
			{
			}
		}

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1977714", Offset = "0x1977714", VA = "0x1977714")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x19778B0", Offset = "0x19778B0", VA = "0x19778B0")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1A84E70", Offset = "0x1A84E70", VA = "0x1A84E70")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1A85030", Offset = "0x1A85030", VA = "0x1A85030")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1A851F4", Offset = "0x1A851F4", VA = "0x1A851F4")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8CF4", Offset = "0xCD8CF4")]
		public VRIK ik;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8D2C", Offset = "0xCD8D2C")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8D64", Offset = "0xCD8D64")]
		public Transform headTracker;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8D9C", Offset = "0xCD8D9C")]
		public Transform bodyTracker;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8DD4", Offset = "0xCD8DD4")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8E0C", Offset = "0xCD8E0C")]
		public Transform rightHandTracker;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8E44", Offset = "0xCD8E44")]
		public Transform leftFootTracker;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8E7C", Offset = "0xCD8E7C")]
		public Transform rightFootTracker;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD8EB4", Offset = "0xCD8EB4")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x197893C", Offset = "0x197893C", VA = "0x197893C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1978A98", Offset = "0x1978A98", VA = "0x1978A98")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1978B00", Offset = "0x1978B00", VA = "0x1978B00")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1978B5C", Offset = "0x1978B5C", VA = "0x1978B5C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1978D70", Offset = "0x1978D70", VA = "0x1978D70")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1978DE8", Offset = "0x1978DE8", VA = "0x1978DE8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1979338", Offset = "0x1979338", VA = "0x1979338")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000C1")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x1A7C974", Offset = "0x1A7C974", VA = "0x1A7C974", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1A7C950", Offset = "0x1A7C950", VA = "0x1A7C950", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1A7C97C", Offset = "0x1A7C97C", VA = "0x1A7C97C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1A7CA40", Offset = "0x1A7CA40", VA = "0x1A7CA40", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1A7CBB8", Offset = "0x1A7CBB8", VA = "0x1A7CBB8", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1A7CE6C", Offset = "0x1A7CE6C", VA = "0x1A7CE6C", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1A7CBC8", Offset = "0x1A7CBC8", VA = "0x1A7CBC8")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1A7CE7C", Offset = "0x1A7CE7C", VA = "0x1A7CE7C")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD408C", Offset = "0xCD408C")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1A7CE94", Offset = "0x1A7CE94", VA = "0x1A7CE94", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1A7CEF4", Offset = "0x1A7CEF4", VA = "0x1A7CEF4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1A7D020", Offset = "0x1A7D020", VA = "0x1A7D020")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1A7D19C", Offset = "0x1A7D19C", VA = "0x1A7D19C")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD40F0", Offset = "0xCD40F0")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCD8F1C", Offset = "0xCD8F1C")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000649")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x400064A")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x170000C2")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x1A7D254", Offset = "0x1A7D254", VA = "0x1A7D254", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1A7D1B4", Offset = "0x1A7D1B4", VA = "0x1A7D1B4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1A7D238", Offset = "0x1A7D238", VA = "0x1A7D238", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1A7D344", Offset = "0x1A7D344", VA = "0x1A7D344", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1A7D70C", Offset = "0x1A7D70C", VA = "0x1A7D70C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1A7D8C0", Offset = "0x1A7D8C0", VA = "0x1A7D8C0")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD4154", Offset = "0xCD4154")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD4154", Offset = "0xCD4154")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD8F60", Offset = "0xCD8F60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8F60", Offset = "0xCD8F60")]
		public Transform gravityTarget;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD8FC0", Offset = "0xCD8FC0")]
		public float gravityMultiplier;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000656")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60006F0")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1A7DDE4", Offset = "0x1A7DDE4", VA = "0x1A7DDE4")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1A7DF68", Offset = "0x1A7DF68", VA = "0x1A7DF68", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1A7E100", Offset = "0x1A7E100", VA = "0x1A7E100", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1A7E378", Offset = "0x1A7E378", VA = "0x1A7E378")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1A7E43C", Offset = "0x1A7E43C", VA = "0x1A7E43C")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1A7E624", Offset = "0x1A7E624", VA = "0x1A7E624")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1A7E7D4", Offset = "0x1A7E7D4", VA = "0x1A7E7D4")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1A7E7F8", Offset = "0x1A7E7F8", VA = "0x1A7E7F8")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1A7E81C", Offset = "0x1A7E81C", VA = "0x1A7E81C")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1A7E920", Offset = "0x1A7E920", VA = "0x1A7E920")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200017D")]
		public enum MoveMode
		{
			[Token(Token = "0x4000A07")]
			Directional,
			[Token(Token = "0x4000A08")]
			Strafe
		}

		[Token(Token = "0x200017E")]
		public struct AnimState
		{
			[Token(Token = "0x4000A09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000A0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000A0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000A0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000A0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000A0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x4000A0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x200017F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD435C", Offset = "0xCD435C")]
		private sealed class <JumpSmooth>d__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x4000A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x17000159")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A5B")]
				[Address(RVA = "0x1A81664", Offset = "0x1A81664", VA = "0x1A81664", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A5D")]
				[Address(RVA = "0x1A816CC", Offset = "0x1A816CC", VA = "0x1A816CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x1A813C4", Offset = "0x1A813C4", VA = "0x1A813C4")]
			[DebuggerHidden]
			public <JumpSmooth>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x1A81524", Offset = "0x1A81524", VA = "0x1A81524", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x1A81528", Offset = "0x1A81528", VA = "0x1A81528", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x1A8166C", Offset = "0x1A8166C", VA = "0x1A8166C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD8FF8", Offset = "0xCD8FF8")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD9030", Offset = "0xCD9030")]
		public MoveMode moveMode;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD9068", Offset = "0xCD9068")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD90A0", Offset = "0xCD90A0")]
		public bool smoothJump;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD90D8", Offset = "0xCD90D8")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCD9110", Offset = "0xCD9110")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD9148", Offset = "0xCD9148")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		[Token(Token = "0x170000C3")]
		public bool onGround
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x1A7ED3C", Offset = "0x1A7ED3C", VA = "0x1A7ED3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDEF98", Offset = "0xCDEF98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x1A7ED44", Offset = "0x1A7ED44", VA = "0x1A7ED44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDEFA8", Offset = "0xCDEFA8")]
			private set
			{
			}
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1A7ED50", Offset = "0x1A7ED50", VA = "0x1A7ED50", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1A7EED4", Offset = "0x1A7EED4", VA = "0x1A7EED4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x1A7EF64", Offset = "0x1A7EF64", VA = "0x1A7EF64", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1A7F0A0", Offset = "0x1A7F0A0", VA = "0x1A7F0A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x1A80014", Offset = "0x1A80014", VA = "0x1A80014", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1A803AC", Offset = "0x1A803AC", VA = "0x1A803AC", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x1A7F6AC", Offset = "0x1A7F6AC", VA = "0x1A7F6AC")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1A8048C", Offset = "0x1A8048C", VA = "0x1A8048C")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1A80A7C", Offset = "0x1A80A7C", VA = "0x1A80A7C")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1A800F0", Offset = "0x1A800F0", VA = "0x1A800F0")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1A80B1C", Offset = "0x1A80B1C", VA = "0x1A80B1C", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1A80F8C", Offset = "0x1A80F8C", VA = "0x1A80F8C")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1A81118", Offset = "0x1A81118", VA = "0x1A81118", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1A81330", Offset = "0x1A81330", VA = "0x1A81330")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDEFB8", Offset = "0xCDEFB8")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1A7FBF4", Offset = "0x1A7FBF4", VA = "0x1A7FBF4")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1A813F0", Offset = "0x1A813F0", VA = "0x1A813F0")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCD41E0", Offset = "0xCD41E0")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000180")]
		public enum RotationMode
		{
			[Token(Token = "0x4000A17")]
			Smooth,
			[Token(Token = "0x4000A18")]
			Linear
		}

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9158", Offset = "0xCD9158")]
		public CameraController cameraController;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9190", Offset = "0xCD9190")]
		public float accelerationTime;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD91C8", Offset = "0xCD91C8")]
		public float turnTime;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9200", Offset = "0xCD9200")]
		public bool walkByDefault;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9238", Offset = "0xCD9238")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9270", Offset = "0xCD9270")]
		public float moveSpeed;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD92A8", Offset = "0xCD92A8")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000C4")]
		public bool isGrounded
		{
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x1975674", Offset = "0x1975674", VA = "0x1975674")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF01C", Offset = "0xCDF01C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x197567C", Offset = "0x197567C", VA = "0x197567C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF02C", Offset = "0xCDF02C")]
			private set
			{
			}
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1975688", Offset = "0x1975688", VA = "0x1975688")]
		private void Start()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1975710", Offset = "0x1975710", VA = "0x1975710")]
		private void Update()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1975E0C", Offset = "0x1975E0C", VA = "0x1975E0C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1975764", Offset = "0x1975764", VA = "0x1975764")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1975B64", Offset = "0x1975B64", VA = "0x1975B64")]
		private void Move()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1975E48", Offset = "0x1975E48", VA = "0x1975E48")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1975F40", Offset = "0x1975F40", VA = "0x1975F40")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1975FE0", Offset = "0x1975FE0", VA = "0x1975FE0")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1977EE0", Offset = "0x1977EE0", VA = "0x1977EE0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1977F5C", Offset = "0x1977F5C", VA = "0x1977F5C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x19781F4", Offset = "0x19781F4", VA = "0x19781F4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x197821C", Offset = "0x197821C", VA = "0x197821C")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000181")]
		public struct State
		{
			[Token(Token = "0x4000A19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000A1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x1977F24", Offset = "0x1977F24", VA = "0x1977F24", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x197835C", Offset = "0x197835C", VA = "0x197835C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1978238", Offset = "0x1978238", VA = "0x1978238")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1A7C308", Offset = "0x1A7C308", VA = "0x1A7C308")]
		private void Update()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1A7C344", Offset = "0x1A7C344", VA = "0x1A7C344")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1976008", Offset = "0x1976008", VA = "0x1976008")]
		private void Update()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x197603C", Offset = "0x197603C", VA = "0x197603C")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x19760EC", Offset = "0x19760EC", VA = "0x19760EC")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000DF")]
	public class Navigator
	{
		[Token(Token = "0x2000182")]
		public enum State
		{
			[Token(Token = "0x4000A1F")]
			Idle,
			[Token(Token = "0x4000A20")]
			Seeking,
			[Token(Token = "0x4000A21")]
			OnPath
		}

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD92B8", Offset = "0xCD92B8")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD92F0", Offset = "0xCD92F0")]
		public float cornerRadius;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9328", Offset = "0xCD9328")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9360", Offset = "0xCD9360")]
		public float maxSampleDistance;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCD9398", Offset = "0xCD9398")]
		public float nextPathInterval;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD93D0", Offset = "0xCD93D0")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD93E0", Offset = "0xCD93E0")]
		private State <state>k__BackingField;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000C5")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1A89F1C", Offset = "0x1A89F1C", VA = "0x1A89F1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF03C", Offset = "0xCDF03C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x1A89F28", Offset = "0x1A89F28", VA = "0x1A89F28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF04C", Offset = "0xCDF04C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public State state
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1A89F34", Offset = "0x1A89F34", VA = "0x1A89F34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF05C", Offset = "0xCDF05C")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x1A89F3C", Offset = "0x1A89F3C", VA = "0x1A89F3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCDF06C", Offset = "0xCDF06C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1A89F44", Offset = "0x1A89F44", VA = "0x1A89F44")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1A8A018", Offset = "0x1A8A018", VA = "0x1A8A018")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1A8A55C", Offset = "0x1A8A55C", VA = "0x1A8A55C")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1A8A5CC", Offset = "0x1A8A5CC", VA = "0x1A8A5CC")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x1A8A424", Offset = "0x1A8A424", VA = "0x1A8A424")]
		private void Stop()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x1A8A498", Offset = "0x1A8A498", VA = "0x1A8A498")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x1A8A714", Offset = "0x1A8A714", VA = "0x1A8A714")]
		public void Visualize()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1A8A8C4", Offset = "0x1A8A8C4", VA = "0x1A8A8C4")]
		public Navigator()
		{
		}
	}
}
namespace Edelweiss.Pattern
{
	[Token(Token = "0x20000E0")]
	public class CommandNotifier<TSender> where TSender : class
	{
		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ExecutableCommandNotifier<TSender> m_ExecutableCommandNotifier;

		[Token(Token = "0x600072F")]
		internal CommandNotifier(ExecutableCommandNotifier<TSender> a_ExecutableCommandNotifier)
		{
		}

		[Token(Token = "0x6000730")]
		public void Subscribe(Action a_Subscriber)
		{
		}

		[Token(Token = "0x6000731")]
		public void Subscribe(Action<TSender> a_Subscriber)
		{
		}

		[Token(Token = "0x6000732")]
		public void Unsubscribe(Action a_Subscriber)
		{
		}

		[Token(Token = "0x6000733")]
		public void Unsubscribe(Action<TSender> a_Subscriber)
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class CommandNotifier<TSender, TArgument> where TSender : class
	{
		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ExecutableCommandNotifier<TSender, TArgument> m_ExecutableCommandNotifier;

		[Token(Token = "0x6000734")]
		internal CommandNotifier(ExecutableCommandNotifier<TSender, TArgument> a_ExecutableCommandNotifier)
		{
		}

		[Token(Token = "0x6000735")]
		public void Subscribe(Action<TArgument> a_Subscriber)
		{
		}

		[Token(Token = "0x6000736")]
		public void Subscribe(Action<TSender, TArgument> a_Subscriber)
		{
		}

		[Token(Token = "0x6000737")]
		public void Unsubscribe(Action<TArgument> a_Subscriber)
		{
		}

		[Token(Token = "0x6000738")]
		public void Unsubscribe(Action<TSender, TArgument> a_Subscriber)
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class ExecutableCommandNotifier<TSender> : IDisposable where TSender : class
	{
		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TSender m_Sender;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action m_Notifier;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<TSender> m_NotifierWithSender;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly CommandNotifier<TSender> m_CommandNotifier;

		[Token(Token = "0x170000C7")]
		public TSender Sender
		{
			[Token(Token = "0x6000739")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		public CommandNotifier<TSender> CommandNotifier
		{
			[Token(Token = "0x600073A")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073B")]
		public ExecutableCommandNotifier(TSender a_Sender)
		{
		}

		[Token(Token = "0x600073C")]
		public void Execute()
		{
		}

		[Token(Token = "0x600073D")]
		public void Subscribe(Action a_Subscriber)
		{
		}

		[Token(Token = "0x600073E")]
		public void Subscribe(Action<TSender> a_Subscriber)
		{
		}

		[Token(Token = "0x600073F")]
		public void Unsubscribe(Action a_Subscriber)
		{
		}

		[Token(Token = "0x6000740")]
		public void Unsubscribe(Action<TSender> a_Subscriber)
		{
		}

		[Token(Token = "0x6000741")]
		private void System.IDisposable.Dispose()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class ExecutableCommandNotifier<TSender, TArgument> : IDisposable where TSender : class
	{
		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TSender m_Sender;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<TArgument> m_Notifier;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<TSender, TArgument> m_NotifierWithSender;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly CommandNotifier<TSender, TArgument> m_CommandNotifier;

		[Token(Token = "0x170000C9")]
		public TSender Sender
		{
			[Token(Token = "0x6000742")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		public CommandNotifier<TSender, TArgument> CommandNotifier
		{
			[Token(Token = "0x6000743")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000744")]
		public ExecutableCommandNotifier(TSender a_Sender)
		{
		}

		[Token(Token = "0x6000745")]
		public void Execute(TArgument a_Argument)
		{
		}

		[Token(Token = "0x6000746")]
		public void Subscribe(Action<TArgument> a_Subscriber)
		{
		}

		[Token(Token = "0x6000747")]
		public void Subscribe(Action<TSender, TArgument> a_Subscriber)
		{
		}

		[Token(Token = "0x6000748")]
		public void Unsubscribe(Action<TArgument> a_Subscriber)
		{
		}

		[Token(Token = "0x6000749")]
		public void Unsubscribe(Action<TSender, TArgument> a_Subscriber)
		{
		}

		[Token(Token = "0x600074A")]
		private void System.IDisposable.Dispose()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class ModifiablePropertyChangeNotifier<TSender, TProperty> : IDisposable where TSender : class
	{
		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TSender m_Sender;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<TProperty> m_Notifier;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<TSender, TProperty> m_NotifierWithSender;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TProperty m_Value;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly PropertyChangeNotifier<TSender, TProperty> m_PropertyChangeNotifier;

		[Token(Token = "0x170000CB")]
		public TSender Sender
		{
			[Token(Token = "0x600074B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		public TProperty Value
		{
			[Token(Token = "0x600074C")]
			get
			{
				return (TProperty)null;
			}
			[Token(Token = "0x600074D")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public PropertyChangeNotifier<TSender, TProperty> PropertyChangeNotifier
		{
			[Token(Token = "0x600074E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600074F")]
		public ModifiablePropertyChangeNotifier(TSender a_Sender)
		{
		}

		[Token(Token = "0x6000750")]
		public ModifiablePropertyChangeNotifier(TSender a_Sender, TProperty a_Value)
		{
		}

		[Token(Token = "0x6000751")]
		public void Subscribe(Action<TProperty> a_Subscriber)
		{
		}

		[Token(Token = "0x6000752")]
		public void Subscribe(Action<TSender, TProperty> a_Subscriber)
		{
		}

		[Token(Token = "0x6000753")]
		public void Unsubscribe(Action<TProperty> a_Subscriber)
		{
		}

		[Token(Token = "0x6000754")]
		public void Unsubscribe(Action<TSender, TProperty> a_Subscriber)
		{
		}

		[Token(Token = "0x6000755")]
		private void System.IDisposable.Dispose()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class PropertyChangeNotifier<TSender, TProperty> where TSender : class
	{
		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ModifiablePropertyChangeNotifier<TSender, TProperty> m_ModifiablePropertyChangeNotifier;

		[Token(Token = "0x6000756")]
		internal PropertyChangeNotifier(ModifiablePropertyChangeNotifier<TSender, TProperty> a_ModifiablePropertyChangeNotifier)
		{
		}

		[Token(Token = "0x6000757")]
		public void Subscribe(Action<TProperty> a_Subscriber)
		{
		}

		[Token(Token = "0x6000758")]
		public void Subscribe(Action<TSender, TProperty> a_Subscriber)
		{
		}

		[Token(Token = "0x6000759")]
		public void Unsubscribe(Action<TProperty> a_Subscriber)
		{
		}

		[Token(Token = "0x600075A")]
		public void Unsubscribe(Action<TSender, TProperty> a_Subscriber)
		{
		}
	}
}
namespace Edelweiss.Coroutine
{
	[Token(Token = "0x20000E6")]
	public class SafeCoroutine
	{
		[Token(Token = "0x2000183")]
		public class EditorSafeCoroutine
		{
			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private SafeCoroutine _coroutine;

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x1B6F79C", Offset = "0x1B6F79C", VA = "0x1B6F79C")]
			public EditorSafeCoroutine(SafeCoroutine coroutine)
			{
			}

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x1B6FB68", Offset = "0x1B6FB68", VA = "0x1B6FB68")]
			public IEnumerator GetWrappedIEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD436C", Offset = "0xCD436C")]
		private sealed class <WrappingCoroutine>d__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SafeCoroutine <>4__this;

			[Token(Token = "0x4000A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator a_Coroutine;

			[Token(Token = "0x1700015B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A63")]
				[Address(RVA = "0x1B6FAF8", Offset = "0x1B6FAF8", VA = "0x1B6FAF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A65")]
				[Address(RVA = "0x1B6FB60", Offset = "0x1B6FB60", VA = "0x1B6FB60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x1B6F70C", Offset = "0x1B6F70C", VA = "0x1B6F70C")]
			[DebuggerHidden]
			public <WrappingCoroutine>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x1B6F7C8", Offset = "0x1B6F7C8", VA = "0x1B6F7C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x1B6F7CC", Offset = "0x1B6F7CC", VA = "0x1B6F7CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x1B6FB00", Offset = "0x1B6FB00", VA = "0x1B6FB00", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ModifiablePropertyChangeNotifier<SafeCoroutine, SafeCoroutineState> m_StateChangeNotifier;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_IsSelfPaused;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool m_IsParentPaused;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected internal IEnumerator m_WrappedCoroutine;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_CatchExceptions;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Exception m_Exception;

		[Token(Token = "0x170000CE")]
		public PropertyChangeNotifier<SafeCoroutine, SafeCoroutineState> StateChangeNotifier
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x1B6CA3C", Offset = "0x1B6CA3C", VA = "0x1B6CA3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		public SafeCoroutineState State
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x1B6A670", Offset = "0x1B6A670", VA = "0x1B6A670")]
			get
			{
				return default(SafeCoroutineState);
			}
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x1B6F0A0", Offset = "0x1B6F0A0", VA = "0x1B6F0A0")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public bool IsRunning
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x1B6A76C", Offset = "0x1B6A76C", VA = "0x1B6A76C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D1")]
		public bool IsPaused
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x1B6BB74", Offset = "0x1B6BB74", VA = "0x1B6BB74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D2")]
		public bool IsSelfPaused
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x1B6F120", Offset = "0x1B6F120", VA = "0x1B6F120")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D3")]
		public bool IsParentPaused
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x1B6F128", Offset = "0x1B6F128", VA = "0x1B6F128")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D4")]
		public bool HasFinished
		{
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x1B6F130", Offset = "0x1B6F130", VA = "0x1B6F130")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D5")]
		public bool IsStopped
		{
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x1B6F14C", Offset = "0x1B6F14C", VA = "0x1B6F14C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D6")]
		public bool ThrewException
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x1B6A6C0", Offset = "0x1B6A6C0", VA = "0x1B6A6C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D7")]
		internal virtual IEnumerator WrappedCoroutine
		{
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x1B6F168", Offset = "0x1B6F168", VA = "0x1B6F168", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		public bool CatchExceptions
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x1B6F274", Offset = "0x1B6F274", VA = "0x1B6F274")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000767")]
			[Address(RVA = "0x1B6F27C", Offset = "0x1B6F27C", VA = "0x1B6F27C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public Exception ThrownException
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x1B6A6DC", Offset = "0x1B6A6DC", VA = "0x1B6A6DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1B6F288", Offset = "0x1B6F288", VA = "0x1B6F288")]
		internal SafeCoroutine(IEnumerator a_WrappedCoroutine)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1B6BAB8", Offset = "0x1B6BAB8", VA = "0x1B6BAB8")]
		public void Pause()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1B6F31C", Offset = "0x1B6F31C", VA = "0x1B6F31C")]
		private void PauseChildCoroutines()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1B6B9FC", Offset = "0x1B6B9FC", VA = "0x1B6B9FC")]
		public void Resume()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1B6F47C", Offset = "0x1B6F47C", VA = "0x1B6F47C")]
		private void ResumeChildCoroutines()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1B6BB94", Offset = "0x1B6BB94", VA = "0x1B6BB94")]
		public void Stop()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x1B6F5C8", Offset = "0x1B6F5C8", VA = "0x1B6F5C8")]
		private void StopChildRoutines()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x1B6F1F8", Offset = "0x1B6F1F8", VA = "0x1B6F1F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF07C", Offset = "0xCDF07C")]
		private IEnumerator WrappingCoroutine(IEnumerator a_Coroutine)
		{
			return null;
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1B6F738", Offset = "0x1B6F738", VA = "0x1B6F738")]
		public EditorSafeCoroutine GetEditorRoutine()
		{
			return null;
		}
	}
	[Token(Token = "0x20000E7")]
	public class SafeCoroutine<G> : SafeCoroutine
	{
		[Token(Token = "0x2000185")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD437C", Offset = "0xCD437C")]
		private sealed class <WrappingCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000A28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000A29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SafeCoroutine<G> <>4__this;

			[Token(Token = "0x4000A2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IEnumerator a_Coroutine;

			[Token(Token = "0x1700015D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A69")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A6B")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A66")]
			[DebuggerHidden]
			public <WrappingCoroutine>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000A67")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A68")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A6A")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ModifiablePropertyChangeNotifier<SafeCoroutine<G>, SafeCoroutineState> m_StateChangeNotifier;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private G m_Result;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_HasResult;

		[Token(Token = "0x170000DA")]
		public PropertyChangeNotifier<SafeCoroutine<G>, SafeCoroutineState> GenericStateChangeNotifier
		{
			[Token(Token = "0x6000772")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		internal override IEnumerator WrappedCoroutine
		{
			[Token(Token = "0x6000773")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		public G Result
		{
			[Token(Token = "0x6000774")]
			get
			{
				return (G)null;
			}
		}

		[Token(Token = "0x170000DD")]
		public bool HasResult
		{
			[Token(Token = "0x6000775")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000776")]
		internal SafeCoroutine(IEnumerator a_InternalCoroutine)
		{
		}

		[Token(Token = "0x6000777")]
		private void PropagateStateChange(SafeCoroutineState a_State)
		{
		}

		[Token(Token = "0x6000778")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF0E0", Offset = "0xCDF0E0")]
		private IEnumerator WrappingCoroutine(IEnumerator a_Coroutine)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E8")]
	public static class SafeCoroutineExtension
	{
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1B6A210", Offset = "0x1B6A210", VA = "0x1B6A210")]
		public static SafeCoroutine StartSafeCoroutine(this MonoBehaviour a_MonoBehaviour, IEnumerator a_SafeCoroutine)
		{
			return null;
		}

		[Token(Token = "0x600077A")]
		public static SafeCoroutine<TResult> StartSafeCoroutine<TResult>(this MonoBehaviour a_MonoBehaviour, IEnumerator a_SafeCoroutine)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E9")]
	public enum SafeCoroutineState
	{
		[Token(Token = "0x40006D4")]
		Created,
		[Token(Token = "0x40006D5")]
		Running,
		[Token(Token = "0x40006D6")]
		Paused,
		[Token(Token = "0x40006D7")]
		Finished,
		[Token(Token = "0x40006D8")]
		Stopped,
		[Token(Token = "0x40006D9")]
		ThrewException
	}
}
namespace Edelweiss.Coroutine.Examples
{
	[Token(Token = "0x20000EA")]
	public class ExceptionThrowingSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x2000186")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD438C", Offset = "0xCD438C")]
		private sealed class <ExceptionThrowingCoroutine>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExceptionThrowingSafeCoroutinesExample <>4__this;

			[Token(Token = "0x1700015F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A6F")]
				[Address(RVA = "0x1B6A84C", Offset = "0x1B6A84C", VA = "0x1B6A84C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000160")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A71")]
				[Address(RVA = "0x1B6A8B4", Offset = "0x1B6A8B4", VA = "0x1B6A8B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x1B6A2A8", Offset = "0x1B6A2A8", VA = "0x1B6A2A8")]
			[DebuggerHidden]
			public <ExceptionThrowingCoroutine>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x1B6A790", Offset = "0x1B6A790", VA = "0x1B6A790", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x1B6A794", Offset = "0x1B6A794", VA = "0x1B6A794", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x1B6A854", Offset = "0x1B6A854", VA = "0x1B6A854", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SafeCoroutine m_ExceptionThrowingCoroutine;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_ThrowExceptionInNextFrame;

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1B6A160", Offset = "0x1B6A160", VA = "0x1B6A160")]
		private void Awake()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1B6A1A0", Offset = "0x1B6A1A0", VA = "0x1B6A1A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF164", Offset = "0xCDF164")]
		private IEnumerator ExceptionThrowingCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1B6A2D4", Offset = "0x1B6A2D4", VA = "0x1B6A2D4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1B6A788", Offset = "0x1B6A788", VA = "0x1B6A788")]
		public ExceptionThrowingSafeCoroutinesExample()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class ExecutionOrderSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x2000187")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD439C", Offset = "0xCD439C")]
		private sealed class <FixedUpdateCoroutine>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string a_Name;

			[Token(Token = "0x17000161")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A75")]
				[Address(RVA = "0x1B6AF34", Offset = "0x1B6AF34", VA = "0x1B6AF34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000162")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A77")]
				[Address(RVA = "0x1B6AF9C", Offset = "0x1B6AF9C", VA = "0x1B6AF9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x1B6AB2C", Offset = "0x1B6AB2C", VA = "0x1B6AB2C")]
			[DebuggerHidden]
			public <FixedUpdateCoroutine>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x1B6AE50", Offset = "0x1B6AE50", VA = "0x1B6AE50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x1B6AE54", Offset = "0x1B6AE54", VA = "0x1B6AE54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x1B6AF3C", Offset = "0x1B6AF3C", VA = "0x1B6AF3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000188")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD43AC", Offset = "0xCD43AC")]
		private sealed class <UpdateCoroutine>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string a_Name;

			[Token(Token = "0x17000163")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A7B")]
				[Address(RVA = "0x1B6B06C", Offset = "0x1B6B06C", VA = "0x1B6B06C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000164")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A7D")]
				[Address(RVA = "0x1B6B0D4", Offset = "0x1B6B0D4", VA = "0x1B6B0D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x1B6AB58", Offset = "0x1B6AB58", VA = "0x1B6AB58")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x1B6AFA4", Offset = "0x1B6AFA4", VA = "0x1B6AFA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x1B6AFA8", Offset = "0x1B6AFA8", VA = "0x1B6AFA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x1B6B074", Offset = "0x1B6B074", VA = "0x1B6B074", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000189")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD43BC", Offset = "0xCD43BC")]
		private sealed class <EndOfFrameCoroutine>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string a_Name;

			[Token(Token = "0x17000165")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A81")]
				[Address(RVA = "0x1B6ADE0", Offset = "0x1B6ADE0", VA = "0x1B6ADE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000166")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A83")]
				[Address(RVA = "0x1B6AE48", Offset = "0x1B6AE48", VA = "0x1B6AE48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x1B6AB84", Offset = "0x1B6AB84", VA = "0x1B6AB84")]
			[DebuggerHidden]
			public <EndOfFrameCoroutine>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x1B6ACFC", Offset = "0x1B6ACFC", VA = "0x1B6ACFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x1B6AD00", Offset = "0x1B6AD00", VA = "0x1B6AD00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x1B6ADE8", Offset = "0x1B6ADE8", VA = "0x1B6ADE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1B6A8BC", Offset = "0x1B6A8BC", VA = "0x1B6A8BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1B6A9DC", Offset = "0x1B6A9DC", VA = "0x1B6A9DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF1C8", Offset = "0xCDF1C8")]
		private IEnumerator FixedUpdateCoroutine(string a_Name)
		{
			return null;
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1B6AA4C", Offset = "0x1B6AA4C", VA = "0x1B6AA4C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF22C", Offset = "0xCDF22C")]
		private IEnumerator UpdateCoroutine(string a_Name)
		{
			return null;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1B6AABC", Offset = "0x1B6AABC", VA = "0x1B6AABC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF290", Offset = "0xCDF290")]
		private IEnumerator EndOfFrameCoroutine(string a_Name)
		{
			return null;
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1B6ABB0", Offset = "0x1B6ABB0", VA = "0x1B6ABB0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1B6AC1C", Offset = "0x1B6AC1C", VA = "0x1B6AC1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1B6AC88", Offset = "0x1B6AC88", VA = "0x1B6AC88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1B6ACF4", Offset = "0x1B6ACF4", VA = "0x1B6ACF4")]
		public ExecutionOrderSafeCoroutinesExample()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class FailingNestedSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x200018A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD43CC", Offset = "0xCD43CC")]
		private sealed class <OuterExampleCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FailingNestedSafeCoroutinesExample <>4__this;

			[Token(Token = "0x17000167")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A87")]
				[Address(RVA = "0x1B6BDE0", Offset = "0x1B6BDE0", VA = "0x1B6BDE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000168")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A89")]
				[Address(RVA = "0x1B6BE48", Offset = "0x1B6BE48", VA = "0x1B6BE48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x1B6B17C", Offset = "0x1B6B17C", VA = "0x1B6B17C")]
			[DebuggerHidden]
			public <OuterExampleCoroutine>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x1B6BD30", Offset = "0x1B6BD30", VA = "0x1B6BD30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x1B6BD34", Offset = "0x1B6BD34", VA = "0x1B6BD34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x1B6BDE8", Offset = "0x1B6BDE8", VA = "0x1B6BDE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200018B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD43DC", Offset = "0xCD43DC")]
		private sealed class <InnerExampleCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FailingNestedSafeCoroutinesExample <>4__this;

			[Token(Token = "0x17000169")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A8D")]
				[Address(RVA = "0x1B6BCC0", Offset = "0x1B6BCC0", VA = "0x1B6BCC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A8F")]
				[Address(RVA = "0x1B6BD28", Offset = "0x1B6BD28", VA = "0x1B6BD28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x1B6B218", Offset = "0x1B6B218", VA = "0x1B6B218")]
			[DebuggerHidden]
			public <InnerExampleCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x1B6BC50", Offset = "0x1B6BC50", VA = "0x1B6BC50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x1B6BC54", Offset = "0x1B6BC54", VA = "0x1B6BC54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x1B6BCC8", Offset = "0x1B6BCC8", VA = "0x1B6BCC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_UseUnityCoroutineToFail;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SafeCoroutine m_OuterCoroutine;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SafeCoroutine m_InnerCoroutine;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_InnerCoroutineTimer;

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1B6B0DC", Offset = "0x1B6B0DC", VA = "0x1B6B0DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1B6B10C", Offset = "0x1B6B10C", VA = "0x1B6B10C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF2F4", Offset = "0xCDF2F4")]
		private IEnumerator OuterExampleCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1B6B1A8", Offset = "0x1B6B1A8", VA = "0x1B6B1A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF358", Offset = "0xCDF358")]
		private IEnumerator InnerExampleCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1B6B244", Offset = "0x1B6B244", VA = "0x1B6B244")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1B6B5DC", Offset = "0x1B6B5DC", VA = "0x1B6B5DC")]
		private static void CoroutineGUI(string a_Name, SafeCoroutine a_SafeCoroutine)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1B6BC40", Offset = "0x1B6BC40", VA = "0x1B6BC40")]
		public FailingNestedSafeCoroutinesExample()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class NestedSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x200018C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD43EC", Offset = "0xCD43EC")]
		private sealed class <OuterExampleCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NestedSafeCoroutinesExample <>4__this;

			[Token(Token = "0x1700016B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A93")]
				[Address(RVA = "0x1B6C80C", Offset = "0x1B6C80C", VA = "0x1B6C80C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A95")]
				[Address(RVA = "0x1B6C874", Offset = "0x1B6C874", VA = "0x1B6C874", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x1B6BEF0", Offset = "0x1B6BEF0", VA = "0x1B6BEF0")]
			[DebuggerHidden]
			public <OuterExampleCoroutine>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x1B6C770", Offset = "0x1B6C770", VA = "0x1B6C770", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x1B6C774", Offset = "0x1B6C774", VA = "0x1B6C774", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x1B6C814", Offset = "0x1B6C814", VA = "0x1B6C814", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200018D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD43FC", Offset = "0xCD43FC")]
		private sealed class <InnerExampleCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NestedSafeCoroutinesExample <>4__this;

			[Token(Token = "0x1700016D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A99")]
				[Address(RVA = "0x1B6C700", Offset = "0x1B6C700", VA = "0x1B6C700", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A9B")]
				[Address(RVA = "0x1B6C768", Offset = "0x1B6C768", VA = "0x1B6C768", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x1B6BF8C", Offset = "0x1B6BF8C", VA = "0x1B6BF8C")]
			[DebuggerHidden]
			public <InnerExampleCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x1B6C690", Offset = "0x1B6C690", VA = "0x1B6C690", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x1B6C694", Offset = "0x1B6C694", VA = "0x1B6C694", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x1B6C708", Offset = "0x1B6C708", VA = "0x1B6C708", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_FinishOuterCoroutineAutomatically;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SafeCoroutine m_OuterCoroutine;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SafeCoroutine m_InnerCoroutine;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_InnerCoroutineTimer;

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1B6BE50", Offset = "0x1B6BE50", VA = "0x1B6BE50")]
		private void Awake()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1B6BE80", Offset = "0x1B6BE80", VA = "0x1B6BE80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF3BC", Offset = "0xCDF3BC")]
		private IEnumerator OuterExampleCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1B6BF1C", Offset = "0x1B6BF1C", VA = "0x1B6BF1C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF420", Offset = "0xCDF420")]
		private IEnumerator InnerExampleCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1B6BFB8", Offset = "0x1B6BFB8", VA = "0x1B6BFB8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1B6C114", Offset = "0x1B6C114", VA = "0x1B6C114")]
		private static void CoroutineStateGUI(string a_Name, SafeCoroutine a_SafeCoroutine)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1B6C28C", Offset = "0x1B6C28C", VA = "0x1B6C28C")]
		private static void CoroutineGUI(string a_Name, SafeCoroutine a_SafeCoroutine)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1B6C688", Offset = "0x1B6C688", VA = "0x1B6C688")]
		public NestedSafeCoroutinesExample()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class NotifierSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x200018E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD440C", Offset = "0xCD440C")]
		private sealed class <SimpleCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NotifierSafeCoroutinesExample <>4__this;

			[Token(Token = "0x1700016F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A9F")]
				[Address(RVA = "0x1B6DE4C", Offset = "0x1B6DE4C", VA = "0x1B6DE4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000170")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AA1")]
				[Address(RVA = "0x1B6DEB4", Offset = "0x1B6DEB4", VA = "0x1B6DEB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x1B6CAFC", Offset = "0x1B6CAFC", VA = "0x1B6CAFC")]
			[DebuggerHidden]
			public <SimpleCoroutine>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x1B6DDFC", Offset = "0x1B6DDFC", VA = "0x1B6DDFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x1B6DE00", Offset = "0x1B6DE00", VA = "0x1B6DE00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x1B6DE54", Offset = "0x1B6DE54", VA = "0x1B6DE54", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200018F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD441C", Offset = "0xCD441C")]
		private sealed class <ResultReturningCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NotifierSafeCoroutinesExample <>4__this;

			[Token(Token = "0x17000171")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AA5")]
				[Address(RVA = "0x1B6DD8C", Offset = "0x1B6DD8C", VA = "0x1B6DD8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000172")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AA7")]
				[Address(RVA = "0x1B6DDF4", Offset = "0x1B6DDF4", VA = "0x1B6DDF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x1B6CB28", Offset = "0x1B6CB28", VA = "0x1B6CB28")]
			[DebuggerHidden]
			public <ResultReturningCoroutine>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x1B6DCB8", Offset = "0x1B6DCB8", VA = "0x1B6DCB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x1B6DCBC", Offset = "0x1B6DCBC", VA = "0x1B6DCBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x1B6DD94", Offset = "0x1B6DD94", VA = "0x1B6DD94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SafeCoroutine m_SafeCoroutine;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_FinishSafeCoroutineInNextFrame;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SafeCoroutine<float> m_ResultReturningSafeCoroutine;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_FinishResultReturningSafeCoroutineInNextFrame;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector2 m_ScrollPosition;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string m_Messages;

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1B6C87C", Offset = "0x1B6C87C", VA = "0x1B6C87C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1B6C9CC", Offset = "0x1B6C9CC", VA = "0x1B6C9CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF484", Offset = "0xCDF484")]
		private IEnumerator SimpleCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1B6CA8C", Offset = "0x1B6CA8C", VA = "0x1B6CA8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF4E8", Offset = "0xCDF4E8")]
		private IEnumerator ResultReturningCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1B6CB54", Offset = "0x1B6CB54", VA = "0x1B6CB54")]
		private void OnSafeCoroutineStateChange(SafeCoroutineState a_State)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1B6CD44", Offset = "0x1B6CD44", VA = "0x1B6CD44")]
		private void OnResultReturningSafeCoroutineStateChange(SafeCoroutine<float> a_SafeCoroutine, SafeCoroutineState a_State)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1B6D060", Offset = "0x1B6D060", VA = "0x1B6D060")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x1B6DC58", Offset = "0x1B6DC58", VA = "0x1B6DC58")]
		public NotifierSafeCoroutinesExample()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class ResultReturningSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x2000190")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD442C", Offset = "0xCD442C")]
		private sealed class <ResultReturningCoroutine>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ResultReturningSafeCoroutinesExample <>4__this;

			[Token(Token = "0x17000173")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AAB")]
				[Address(RVA = "0x1B6E390", Offset = "0x1B6E390", VA = "0x1B6E390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000174")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AAD")]
				[Address(RVA = "0x1B6E3F8", Offset = "0x1B6E3F8", VA = "0x1B6E3F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x1B6DF90", Offset = "0x1B6DF90", VA = "0x1B6DF90")]
			[DebuggerHidden]
			public <ResultReturningCoroutine>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x1B6E2BC", Offset = "0x1B6E2BC", VA = "0x1B6E2BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x1B6E2C0", Offset = "0x1B6E2C0", VA = "0x1B6E2C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x1B6E398", Offset = "0x1B6E398", VA = "0x1B6E398", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SafeCoroutine<float> m_ResultReturningCoroutine;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_ReturnResultInNextFrame;

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x1B6DEBC", Offset = "0x1B6DEBC", VA = "0x1B6DEBC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x1B6DF20", Offset = "0x1B6DF20", VA = "0x1B6DF20")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF54C", Offset = "0xCDF54C")]
		private IEnumerator ResultReturningCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1B6DFBC", Offset = "0x1B6DFBC", VA = "0x1B6DFBC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1B6E2B4", Offset = "0x1B6E2B4", VA = "0x1B6E2B4")]
		public ResultReturningSafeCoroutinesExample()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class SimpleNotifierSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x2000191")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD443C", Offset = "0xCD443C")]
		private sealed class <ResultReturningCoroutine>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000175")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AB1")]
				[Address(RVA = "0x1B6E898", Offset = "0x1B6E898", VA = "0x1B6E898", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000176")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AB3")]
				[Address(RVA = "0x1B6E900", Offset = "0x1B6E900", VA = "0x1B6E900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x1B6E530", Offset = "0x1B6E530", VA = "0x1B6E530")]
			[DebuggerHidden]
			public <ResultReturningCoroutine>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x1B6E7AC", Offset = "0x1B6E7AC", VA = "0x1B6E7AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x1B6E7B0", Offset = "0x1B6E7B0", VA = "0x1B6E7B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x1B6E8A0", Offset = "0x1B6E8A0", VA = "0x1B6E8A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1B6E400", Offset = "0x1B6E400", VA = "0x1B6E400")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1B6E4D0", Offset = "0x1B6E4D0", VA = "0x1B6E4D0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF5B0", Offset = "0xCDF5B0")]
		private IEnumerator ResultReturningCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1B6E55C", Offset = "0x1B6E55C", VA = "0x1B6E55C")]
		private void OnResultReturningSafeCoroutineStateChange(SafeCoroutine<float> a_SafeCoroutine, SafeCoroutineState a_State)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1B6E7A4", Offset = "0x1B6E7A4", VA = "0x1B6E7A4")]
		public SimpleNotifierSafeCoroutinesExample()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class SimpleSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x2000192")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD444C", Offset = "0xCD444C")]
		private sealed class <ExampleCoroutine>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000177")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AB7")]
				[Address(RVA = "0x1B6F030", Offset = "0x1B6F030", VA = "0x1B6F030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000178")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AB9")]
				[Address(RVA = "0x1B6F098", Offset = "0x1B6F098", VA = "0x1B6F098", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x1B6E9AC", Offset = "0x1B6E9AC", VA = "0x1B6E9AC")]
			[DebuggerHidden]
			public <ExampleCoroutine>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x1B6F004", Offset = "0x1B6F004", VA = "0x1B6F004", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x1B6F008", Offset = "0x1B6F008", VA = "0x1B6F008", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x1B6F038", Offset = "0x1B6F038", VA = "0x1B6F038", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SafeCoroutine m_SafeCoroutine1;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SafeCoroutine m_SafeCoroutine2;

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x1B6E908", Offset = "0x1B6E908", VA = "0x1B6E908")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x1B6E94C", Offset = "0x1B6E94C", VA = "0x1B6E94C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCDF614", Offset = "0xCDF614")]
		private IEnumerator ExampleCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1B6E9D8", Offset = "0x1B6E9D8", VA = "0x1B6E9D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1B6EC0C", Offset = "0x1B6EC0C", VA = "0x1B6EC0C")]
		private static void CoroutineGUI(string a_Name, SafeCoroutine a_SafeCoroutine)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1B6EFFC", Offset = "0x1B6EFFC", VA = "0x1B6EFFC")]
		public SimpleSafeCoroutinesExample()
		{
		}
	}
}
namespace Csg
{
	[Token(Token = "0x20000F2")]
	public static class Formats
	{
		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IFormatProvider icult;

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1B5E144", Offset = "0x1B5E144", VA = "0x1B5E144")]
		public static string ToStlString(this Solid csg, string name)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1B5E1F0", Offset = "0x1B5E1F0", VA = "0x1B5E1F0")]
		public static void WriteStl(this Solid csg, string name, TextWriter writer)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1B5E390", Offset = "0x1B5E390", VA = "0x1B5E390")]
		public static void WriteStl(this Polygon polygon, TextWriter writer)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1B5E70C", Offset = "0x1B5E70C", VA = "0x1B5E70C")]
		public static string ToStlString(this Vector3D vector)
		{
			return null;
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1B5E610", Offset = "0x1B5E610", VA = "0x1B5E610")]
		public static string ToStlString(this Vertex vertex)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F3")]
	public class Plane : IEquatable<Plane>
	{
		[Token(Token = "0x40006EF")]
		private const double EPSILON = 1E-05;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Vector3D Normal;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly double W;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int tag;

		[Token(Token = "0x170000DE")]
		public int Tag
		{
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x1B61214", Offset = "0x1B61214", VA = "0x1B61214")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1B612F0", Offset = "0x1B612F0", VA = "0x1B612F0")]
		public Plane(Vector3D normal, double w)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1B6133C", Offset = "0x1B6133C", VA = "0x1B6133C", Slot = "4")]
		public bool Equals(Plane n)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x1B6058C", Offset = "0x1B6058C", VA = "0x1B6058C")]
		public Plane Flipped()
		{
			return null;
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x1B613E0", Offset = "0x1B613E0", VA = "0x1B613E0")]
		public void SplitPolygon(Polygon polygon, out SplitPolygonResult result)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x1B61994", Offset = "0x1B61994", VA = "0x1B61994")]
		private Vertex SplitLineBetweenVertices(Vertex v1, Vertex v2)
		{
			return null;
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x1B61BA0", Offset = "0x1B61BA0", VA = "0x1B61BA0")]
		public static Plane FromVector3Ds(Vector3D a, Vector3D b, Vector3D c)
		{
			return null;
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1B61CBC", Offset = "0x1B61CBC", VA = "0x1B61CBC")]
		public Plane Transform(Matrix4x4 matrix4x4)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F4")]
	public struct SplitPolygonResult
	{
		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Type;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Polygon Front;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Polygon Back;
	}
	[Token(Token = "0x20000F5")]
	public class Polygon
	{
		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly List<Vertex> Vertices;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly Plane Plane;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly PolygonShared Shared;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly bool debug;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly PolygonShared defaultShared;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BoundingSphere cachedBoundingSphere;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoundingBox cachedBoundingBox;

		[Token(Token = "0x170000DF")]
		public BoundingSphere BoundingSphere
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x1B6200C", Offset = "0x1B6200C", VA = "0x1B6200C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		public BoundingBox BoundingBox
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x1B620FC", Offset = "0x1B620FC", VA = "0x1B620FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x1B5EF68", Offset = "0x1B5EF68", VA = "0x1B5EF68")]
		public Polygon(List<Vertex> vertices, [Optional] PolygonShared shared, [Optional] Plane plane)
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x1B61F88", Offset = "0x1B61F88", VA = "0x1B61F88")]
		public Polygon(params Vertex[] vertices)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1B62518", Offset = "0x1B62518", VA = "0x1B62518")]
		public Polygon Flipped()
		{
			return null;
		}
	}
	[Token(Token = "0x20000F6")]
	public class PolygonShared
	{
		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int tag;

		[Token(Token = "0x170000E1")]
		public int Tag
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x1B626D0", Offset = "0x1B626D0", VA = "0x1B626D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E2")]
		public string Hash
		{
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x1B5E954", Offset = "0x1B5E954", VA = "0x1B5E954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1B626C8", Offset = "0x1B626C8", VA = "0x1B626C8")]
		public PolygonShared(object color)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class Properties
	{
		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Dictionary<string, object> All;

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1B63100", Offset = "0x1B63100", VA = "0x1B63100")]
		public Properties Merge(Properties otherproperties)
		{
			return null;
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1B63388", Offset = "0x1B63388", VA = "0x1B63388")]
		public Properties Transform(Matrix4x4 matrix4x4)
		{
			return null;
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1B63318", Offset = "0x1B63318", VA = "0x1B63318")]
		public Properties()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class Solid
	{
		[Token(Token = "0x2000193")]
		private struct PolygonsPerPlaneKey
		{
			[Token(Token = "0x4000A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int PlaneTag;

			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int SharedTag;
		}

		[Token(Token = "0x2000194")]
		private class PolygonsPerPlaneKeyComparer : IEqualityComparer<PolygonsPerPlaneKey>
		{
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x1B67250", Offset = "0x1B67250", VA = "0x1B67250", Slot = "4")]
			public bool Equals(PolygonsPerPlaneKey x, PolygonsPerPlaneKey y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x1B67270", Offset = "0x1B67270", VA = "0x1B67270", Slot = "5")]
			public int GetHashCode(PolygonsPerPlaneKey obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x1B67130", Offset = "0x1B67130", VA = "0x1B67130")]
			public PolygonsPerPlaneKeyComparer()
			{
			}
		}

		[Token(Token = "0x2000195")]
		private struct Vertex2DInterpolation
		{
			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double Result;

			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector2D Tex;
		}

		[Token(Token = "0x2000196")]
		private struct Vertex2D
		{
			[Token(Token = "0x4000A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2D Pos;

			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector2D Tex;

			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x1B66ED4", Offset = "0x1B66ED4", VA = "0x1B66ED4")]
			public Vertex2D(Vector2D pos, Vector2D tex)
			{
			}

			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x1B66F70", Offset = "0x1B66F70", VA = "0x1B66F70")]
			public Vertex2D(double x, double y, Vector2D tex)
			{
			}
		}

		[Token(Token = "0x2000197")]
		private class RetesselateActivePolygon
		{
			[Token(Token = "0x4000A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int polygonindex;

			[Token(Token = "0x4000A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int leftvertexindex;

			[Token(Token = "0x4000A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int rightvertexindex;

			[Token(Token = "0x4000A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vertex2D topleft;

			[Token(Token = "0x4000A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vertex2D topright;

			[Token(Token = "0x4000A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vertex2D bottomleft;

			[Token(Token = "0x4000A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Vertex2D bottomright;

			[Token(Token = "0x4000A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Line2D leftline;

			[Token(Token = "0x4000A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public bool leftlinecontinues;

			[Token(Token = "0x4000A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Line2D rightline;

			[Token(Token = "0x4000A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public bool rightlinecontinues;

			[Token(Token = "0x4000A61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public RetesselateOutPolygon outpolygon;

			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x1B66EE8", Offset = "0x1B66EE8", VA = "0x1B66EE8")]
			public RetesselateActivePolygon()
			{
			}
		}

		[Token(Token = "0x2000198")]
		private class RetesselateOutPolygon
		{
			[Token(Token = "0x4000A62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly List<Vertex2D> leftpoints;

			[Token(Token = "0x4000A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly List<Vertex2D> rightpoints;

			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x1B67024", Offset = "0x1B67024", VA = "0x1B67024")]
			public RetesselateOutPolygon()
			{
			}
		}

		[Token(Token = "0x2000199")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD445C", Offset = "0xCD445C")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public double middleycoordinate;

			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<RetesselateActivePolygon, RetesselateActivePolygon, int> <>9__0;

			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x1B66EE0", Offset = "0x1B66EE0", VA = "0x1B66EE0")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x1B67138", Offset = "0x1B67138", VA = "0x1B67138")]
			internal int <RetesselateCoplanarPolygons>b__0(RetesselateActivePolygon el1, RetesselateActivePolygon el2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly PolygonsPerPlaneKeyComparer polygonsPerPlaneKeyComparer;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Polygon> Polygons;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsCanonicalized;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IsRetesselated;

		[Token(Token = "0x4000703")]
		public const int DefaultResolution2D = 32;

		[Token(Token = "0x4000704")]
		public const int DefaultResolution3D = 12;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoundingBox cachedBoundingBox;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int staticTag;

		[Token(Token = "0x170000E3")]
		private BoundingBox Bounds
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x1B64530", Offset = "0x1B64530", VA = "0x1B64530")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1B634C4", Offset = "0x1B634C4", VA = "0x1B634C4")]
		public Solid()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x1B63540", Offset = "0x1B63540", VA = "0x1B63540")]
		public static Solid FromMesh(Mesh m, UnityEngine.Matrix4x4 transform)
		{
			return null;
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1B637E8", Offset = "0x1B637E8", VA = "0x1B637E8")]
		public Mesh ToMesh(bool retesselate = false, bool canonicalize = false)
		{
			return null;
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x1B5F270", Offset = "0x1B5F270", VA = "0x1B5F270")]
		public static Solid FromPolygons(List<Polygon> polygons)
		{
			return null;
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1B64038", Offset = "0x1B64038", VA = "0x1B64038")]
		public Solid Union(params Solid[] others)
		{
			return null;
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1B64178", Offset = "0x1B64178", VA = "0x1B64178")]
		private Solid UnionSub(Solid csg, bool retesselate, bool canonicalize)
		{
			return null;
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1B64448", Offset = "0x1B64448", VA = "0x1B64448")]
		private Solid UnionForNonIntersecting(Solid csg)
		{
			return null;
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1B6486C", Offset = "0x1B6486C", VA = "0x1B6486C")]
		public Solid Subtract(params Solid[] csgs)
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1B648EC", Offset = "0x1B648EC", VA = "0x1B648EC")]
		private Solid SubtractSub(Solid csg, bool retesselate, bool canonicalize)
		{
			return null;
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1B64B30", Offset = "0x1B64B30", VA = "0x1B64B30")]
		public Solid Intersect(params Solid[] csgs)
		{
			return null;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1B64BB0", Offset = "0x1B64BB0", VA = "0x1B64BB0")]
		private Solid IntersectSub(Solid csg, bool retesselate, bool canonicalize)
		{
			return null;
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1B64D2C", Offset = "0x1B64D2C", VA = "0x1B64D2C")]
		public Solid Transform(Matrix4x4 matrix4x4)
		{
			return null;
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x1B6532C", Offset = "0x1B6532C", VA = "0x1B6532C")]
		public Solid Translate(Vector3D offset)
		{
			return null;
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1B65354", Offset = "0x1B65354", VA = "0x1B65354")]
		public Solid Translate(double x = 0.0, double y = 0.0, double z = 0.0)
		{
			return null;
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x1B6537C", Offset = "0x1B6537C", VA = "0x1B6537C")]
		public Solid Scale(Vector3D scale)
		{
			return null;
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1B653A4", Offset = "0x1B653A4", VA = "0x1B653A4")]
		public Solid Scale(double scale)
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1B653D4", Offset = "0x1B653D4", VA = "0x1B653D4")]
		public Solid Scale(double x, double y, double z)
		{
			return null;
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1B63F68", Offset = "0x1B63F68", VA = "0x1B63F68")]
		private Solid Canonicalized()
		{
			return null;
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x1B63ACC", Offset = "0x1B63ACC", VA = "0x1B63ACC")]
		private Solid Retesselated()
		{
			return null;
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x1B64350", Offset = "0x1B64350", VA = "0x1B64350")]
		private bool MayOverlap(Solid csg)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x1B653FC", Offset = "0x1B653FC", VA = "0x1B653FC")]
		private static void RetesselateCoplanarPolygons(List<Polygon> sourcepolygons, List<Polygon> destpolygons)
		{
		}

		[Token(Token = "0x60007D8")]
		private static void InsertSorted<T>(List<T> array, T element, Func<T, T, int> comparefunc)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1B66EF0", Offset = "0x1B66EF0", VA = "0x1B66EF0")]
		private static Vertex2DInterpolation InterpolateBetween2DPointsForY(Vertex2D vertex1, Vertex2D vertex2, double y)
		{
			return default(Vertex2DInterpolation);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1B61284", Offset = "0x1B61284", VA = "0x1B61284")]
		public static int GetTag()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F9")]
	internal class FuzzyCsgFactory
	{
		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly VertexFactory vertexfactory;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly PlaneFactory planefactory;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, PolygonShared> polygonsharedfactory;

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1B5E87C", Offset = "0x1B5E87C", VA = "0x1B5E87C")]
		public PolygonShared GetPolygonShared(PolygonShared sourceshared)
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x1B5E99C", Offset = "0x1B5E99C", VA = "0x1B5E99C")]
		public Vertex GetVertex(Vertex sourcevertex)
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1B5EB0C", Offset = "0x1B5EB0C", VA = "0x1B5EB0C")]
		public Plane GetPlane(Plane sourceplane)
		{
			return null;
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x1B5EC5C", Offset = "0x1B5EC5C", VA = "0x1B5EC5C")]
		public Polygon GetPolygon(Polygon sourcepolygon)
		{
			return null;
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1B5F0D4", Offset = "0x1B5F0D4", VA = "0x1B5F0D4")]
		public Solid GetCsg(Solid sourcecsg)
		{
			return null;
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x1B5F2DC", Offset = "0x1B5F2DC", VA = "0x1B5F2DC")]
		public FuzzyCsgFactory()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	internal class VertexFactory
	{
		[Token(Token = "0x200019A")]
		private struct Key
		{
			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int X;

			[Token(Token = "0x4000A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int Y;

			[Token(Token = "0x4000A68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int Z;

			[Token(Token = "0x4000A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int U;

			[Token(Token = "0x4000A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int V;
		}

		[Token(Token = "0x200019B")]
		private class KeyComparer : IEqualityComparer<Key>
		{
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x1B6A064", Offset = "0x1B6A064", VA = "0x1B6A064", Slot = "4")]
			public bool Equals(Key x, Key y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x1B6A0C0", Offset = "0x1B6A0C0", VA = "0x1B6A0C0", Slot = "5")]
			public int GetHashCode(Key k)
			{
				return default(int);
			}

			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x1B6A05C", Offset = "0x1B6A05C", VA = "0x1B6A05C")]
			public KeyComparer()
			{
			}
		}

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly KeyComparer keyComparer;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<Key, Vertex> lookuptable;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly double multiplier;

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x1B5F39C", Offset = "0x1B5F39C", VA = "0x1B5F39C")]
		public VertexFactory(double tolerance)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1B5E9CC", Offset = "0x1B5E9CC", VA = "0x1B5E9CC")]
		public Vertex LookupOrCreate(ref Vertex vertex)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FB")]
	internal class PlaneFactory
	{
		[Token(Token = "0x200019C")]
		private struct Key
		{
			[Token(Token = "0x4000A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int X;

			[Token(Token = "0x4000A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int Y;

			[Token(Token = "0x4000A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int Z;

			[Token(Token = "0x4000A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int W;
		}

		[Token(Token = "0x200019D")]
		private class KeyComparer : IEqualityComparer<Key>
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x1B61EB8", Offset = "0x1B61EB8", VA = "0x1B61EB8", Slot = "4")]
			public bool Equals(Key x, Key y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x1B61EF4", Offset = "0x1B61EF4", VA = "0x1B61EF4", Slot = "5")]
			public int GetHashCode(Key k)
			{
				return default(int);
			}

			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x1B61EB0", Offset = "0x1B61EB0", VA = "0x1B61EB0")]
			public KeyComparer()
			{
			}
		}

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly KeyComparer keyComparer;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<Key, Plane> lookuptable;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly double multiplier;

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1B5F460", Offset = "0x1B5F460", VA = "0x1B5F460")]
		public PlaneFactory(double tolerance)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1B5EB24", Offset = "0x1B5EB24", VA = "0x1B5EB24")]
		public Plane LookupOrCreate(Plane plane)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FC")]
	public static class Solids
	{
		[Token(Token = "0x200019E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD446C", Offset = "0xCD446C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3D c;

			[Token(Token = "0x4000A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3D r;

			[Token(Token = "0x4000A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Func<int, Vertex> <>9__1;

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x1B67454", Offset = "0x1B67454", VA = "0x1B67454")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x1B69A64", Offset = "0x1B69A64", VA = "0x1B69A64")]
			internal Polygon <Cube>b__0(int[][] info)
			{
				return null;
			}

			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0x1B69B68", Offset = "0x1B69B68", VA = "0x1B69B68")]
			internal Vertex <Cube>b__1(int i)
			{
				return null;
			}
		}

		[Token(Token = "0x200019F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCD447C", Offset = "0xCD447C")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000A72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public double alpha;

			[Token(Token = "0x4000A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3D axisX;

			[Token(Token = "0x4000A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3D axisY;

			[Token(Token = "0x4000A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3D s;

			[Token(Token = "0x4000A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3D ray;

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x1B69198", Offset = "0x1B69198", VA = "0x1B69198")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0x1B69C48", Offset = "0x1B69C48", VA = "0x1B69C48")]
			internal Vertex <Cylinder>b__0(double stack, double slice, double radius)
			{
				return null;
			}
		}

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[][][] cubeData;

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1B672CC", Offset = "0x1B672CC", VA = "0x1B672CC")]
		public static Solid Cube(CubeOptions options)
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1B674D8", Offset = "0x1B674D8", VA = "0x1B674D8")]
		public static Solid Cube(double size = 1.0, bool center = false)
		{
			return null;
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1B6759C", Offset = "0x1B6759C", VA = "0x1B6759C")]
		public static Solid Cube(double size, Vector3D center)
		{
			return null;
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1B67664", Offset = "0x1B67664", VA = "0x1B67664")]
		public static Solid Cube(Vector3D size, bool center = false)
		{
			return null;
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1B67748", Offset = "0x1B67748", VA = "0x1B67748")]
		public static Solid Cube(Vector3D size, Vector3D center)
		{
			return null;
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1B67828", Offset = "0x1B67828", VA = "0x1B67828")]
		public static Solid Cube(double width, double height, double depth, bool center = false)
		{
			return null;
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1B6790C", Offset = "0x1B6790C", VA = "0x1B6790C")]
		public static Solid Sphere(SphereOptions options)
		{
			return null;
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1B6812C", Offset = "0x1B6812C", VA = "0x1B6812C")]
		public static Solid Sphere(double r = 1.0, bool center = true)
		{
			return null;
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1B6822C", Offset = "0x1B6822C", VA = "0x1B6822C")]
		public static Solid Sphere(double r, Vector3D center)
		{
			return null;
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x1B68300", Offset = "0x1B68300", VA = "0x1B68300")]
		public static Solid Cylinder(CylinderOptions options)
		{
			return null;
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1B691A0", Offset = "0x1B691A0", VA = "0x1B691A0")]
		public static Solid Cylinder(double r, double h, bool center = false)
		{
			return null;
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1B6928C", Offset = "0x1B6928C", VA = "0x1B6928C")]
		public static Solid Union(params Solid[] csgs)
		{
			return null;
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1B69354", Offset = "0x1B69354", VA = "0x1B69354")]
		public static Solid Difference(params Solid[] csgs)
		{
			return null;
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1B6941C", Offset = "0x1B6941C", VA = "0x1B6941C")]
		public static Solid Intersection(params Solid[] csgs)
		{
			return null;
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x1B680A8", Offset = "0x1B680A8", VA = "0x1B680A8")]
		private static Vertex NoTexVertex(Vector3D pos)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FD")]
	public class CubeOptions
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3D Center;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3D Radius;

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x1B5E108", Offset = "0x1B5E108", VA = "0x1B5E108")]
		public CubeOptions()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class SphereOptions
	{
		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3D XAxis;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3D YAxis;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3D ZAxis;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3D Center;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public double Radius;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int Resolution;

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x1B681FC", Offset = "0x1B681FC", VA = "0x1B681FC")]
		public SphereOptions()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class CylinderOptions
	{
		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3D Start;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3D End;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public double RadiusStart;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public double RadiusEnd;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public double SectorAngle;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int Resolution;

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x1B5E120", Offset = "0x1B5E120", VA = "0x1B5E120")]
		public CylinderOptions()
		{
		}
	}
	[Token(Token = "0x2000100")]
	internal class Tree
	{
		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PolygonTreeNode polygonTree;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Node rootnode;

		[Token(Token = "0x170000E4")]
		public Node RootNode
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x1B69DA8", Offset = "0x1B69DA8", VA = "0x1B69DA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x1B646F0", Offset = "0x1B646F0", VA = "0x1B646F0")]
		public Tree(BoundingBox bounds, List<Polygon> polygons)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x1B647BC", Offset = "0x1B647BC", VA = "0x1B647BC")]
		public void Invert()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x1B647A0", Offset = "0x1B647A0", VA = "0x1B647A0")]
		public void ClipTo(Tree tree, bool alsoRemoveCoplanarFront = false)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x1B647F0", Offset = "0x1B647F0", VA = "0x1B647F0")]
		public List<Polygon> AllPolygons()
		{
			return null;
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x1B64A4C", Offset = "0x1B64A4C", VA = "0x1B64A4C")]
		public void AddPolygons(List<Polygon> polygons)
		{
		}
	}
	[Token(Token = "0x2000101")]
	internal class Node
	{
		[Token(Token = "0x20001A0")]
		private struct Args
		{
			[Token(Token = "0x4000A77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Node Node;

			[Token(Token = "0x4000A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public PolygonTreeNodeList PolygonTreeNodes;

			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x1B60820", Offset = "0x1B60820", VA = "0x1B60820")]
			public Args(Node node, PolygonTreeNodeList polygonTreeNodes)
			{
			}
		}

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Plane Plane;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Node Front;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Node Back;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PolygonTreeNodeList PolygonTreeNodes;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly Node Parent;

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x1B603D8", Offset = "0x1B603D8", VA = "0x1B603D8")]
		public Node(Node parent)
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1B6045C", Offset = "0x1B6045C", VA = "0x1B6045C")]
		public void Invert()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x1B6061C", Offset = "0x1B6061C", VA = "0x1B6061C")]
		public void ClipPolygons(PolygonTreeNodeList clippolygontreenodes, bool alsoRemoveCoplanarFront)
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1B60B6C", Offset = "0x1B60B6C", VA = "0x1B60B6C")]
		public void ClipTo(Tree clippingTree, bool alsoRemoveCoplanarFront)
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1B60CB8", Offset = "0x1B60CB8", VA = "0x1B60CB8")]
		public void AddPolygonTreeNodes(PolygonTreeNodeList addpolygontreenodes)
		{
		}
	}
	[Token(Token = "0x2000102")]
	internal class PolygonTreeNode
	{
		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PolygonTreeNode parent;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly PolygonTreeNodeList children;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Polygon polygon;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool removed;

		[Token(Token = "0x170000E5")]
		public BoundingBox BoundingBox
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x1B62740", Offset = "0x1B62740", VA = "0x1B62740")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E6")]
		public bool IsRemoved
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x1B62978", Offset = "0x1B62978", VA = "0x1B62978")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E7")]
		public bool IsRootNode
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0x1B6282C", Offset = "0x1B6282C", VA = "0x1B6282C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1B62750", Offset = "0x1B62750", VA = "0x1B62750")]
		public void AddPolygons(List<Polygon> polygons)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1B60B00", Offset = "0x1B60B00", VA = "0x1B60B00")]
		public void Remove()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1B62980", Offset = "0x1B62980", VA = "0x1B62980")]
		public void Invert()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1B60F08", Offset = "0x1B60F08", VA = "0x1B60F08")]
		public Polygon GetPolygon()
		{
			return null;
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1B62B4C", Offset = "0x1B62B4C", VA = "0x1B62B4C")]
		public void GetPolygons(List<Polygon> result)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1B60940", Offset = "0x1B60940", VA = "0x1B60940")]
		public void SplitByPlane(Plane plane, ref PolygonTreeNodeList coplanarfrontnodes, ref PolygonTreeNodeList coplanarbacknodes, ref PolygonTreeNodeList frontnodes, ref PolygonTreeNodeList backnodes)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1B62CD0", Offset = "0x1B62CD0", VA = "0x1B62CD0")]
		private void SplitPolygonByPlane(Plane plane, ref PolygonTreeNodeList coplanarfrontnodes, ref PolygonTreeNodeList coplanarbacknodes, ref PolygonTreeNodeList frontnodes, ref PolygonTreeNodeList backnodes)
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1B6283C", Offset = "0x1B6283C", VA = "0x1B6283C")]
		public PolygonTreeNode AddChild(Polygon polygon)
		{
			return null;
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1B62A08", Offset = "0x1B62A08", VA = "0x1B62A08")]
		private void InvertSub()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x1B62948", Offset = "0x1B62948", VA = "0x1B62948")]
		private void RecursivelyInvalidatePolygon()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1B63000", Offset = "0x1B63000", VA = "0x1B63000")]
		public PolygonTreeNode()
		{
		}
	}
	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xCD4264", Offset = "0xCD4264")]
	internal class PolygonTreeNodeList
	{
		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PolygonTreeNode node0;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<PolygonTreeNode> nodes;

		[Token(Token = "0x170000E8")]
		public int Count
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x1B60828", Offset = "0x1B60828", VA = "0x1B60828")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E9")]
		public PolygonTreeNode Item
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x1B60884", Offset = "0x1B60884", VA = "0x1B60884")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1B62CA4", Offset = "0x1B62CA4", VA = "0x1B62CA4")]
		public PolygonTreeNodeList(PolygonTreeNode item0)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1B63068", Offset = "0x1B63068", VA = "0x1B63068")]
		public PolygonTreeNodeList(int capacity)
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x1B60454", Offset = "0x1B60454", VA = "0x1B60454")]
		public PolygonTreeNodeList()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1B62F20", Offset = "0x1B62F20", VA = "0x1B62F20")]
		public void Add(PolygonTreeNode node)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1B628C4", Offset = "0x1B628C4", VA = "0x1B628C4")]
		public void Remove(PolygonTreeNode node)
		{
		}
	}
	[Token(Token = "0x2000104")]
	public struct Vector3D : IEquatable<Vector3D>
	{
		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double X;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double Y;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double Z;

		[Token(Token = "0x170000EA")]
		public double Length
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x1B622D0", Offset = "0x1B622D0", VA = "0x1B622D0")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000EB")]
		public Vector3D Unit
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0x1B61120", Offset = "0x1B61120", VA = "0x1B61120")]
			get
			{
				return default(Vector3D);
			}
		}

		[Token(Token = "0x170000EC")]
		public Vector3D Negated
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x1B613C8", Offset = "0x1B613C8", VA = "0x1B613C8")]
			get
			{
				return default(Vector3D);
			}
		}

		[Token(Token = "0x170000ED")]
		public Vector3D Abs
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x1B6745C", Offset = "0x1B6745C", VA = "0x1B6745C")]
			get
			{
				return default(Vector3D);
			}
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1B637D8", Offset = "0x1B637D8", VA = "0x1B637D8")]
		public static implicit operator Vector3D(Vector3 v)
		{
			return default(Vector3D);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1B63FF8", Offset = "0x1B63FF8", VA = "0x1B63FF8")]
		public static implicit operator Vector3(Vector3D v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1B5DE70", Offset = "0x1B5DE70", VA = "0x1B5DE70")]
		public Vector3D(double x, double y, double z)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1B61398", Offset = "0x1B61398", VA = "0x1B61398", Slot = "4")]
		public bool Equals(Vector3D a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x1B61B0C", Offset = "0x1B61B0C", VA = "0x1B61B0C")]
		public double DistanceToSquared(Vector3D a)
		{
			return default(double);
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1B611A4", Offset = "0x1B611A4", VA = "0x1B611A4")]
		public double Dot(Vector3D a)
		{
			return default(double);
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x1B610F0", Offset = "0x1B610F0", VA = "0x1B610F0")]
		public Vector3D Cross(Vector3D a)
		{
			return default(Vector3D);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x1B62380", Offset = "0x1B62380", VA = "0x1B62380")]
		public Vector3D Min(Vector3D other)
		{
			return default(Vector3D);
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x1B6244C", Offset = "0x1B6244C", VA = "0x1B6244C")]
		public Vector3D Max(Vector3D other)
		{
			return default(Vector3D);
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x1B5DDF4", Offset = "0x1B5DDF4", VA = "0x1B5DDF4")]
		public static Vector3D operator +(Vector3D a, Vector3D b)
		{
			return default(Vector3D);
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x1B5DE98", Offset = "0x1B5DE98", VA = "0x1B5DE98")]
		public static Vector3D operator -(Vector3D a, Vector3D b)
		{
			return default(Vector3D);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x1B69EBC", Offset = "0x1B69EBC", VA = "0x1B69EBC")]
		public static Vector3D operator *(Vector3D a, Vector3D b)
		{
			return default(Vector3D);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x1B61158", Offset = "0x1B61158", VA = "0x1B61158")]
		public static Vector3D operator *(Vector3D a, double b)
		{
			return default(Vector3D);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x1B5DED4", Offset = "0x1B5DED4", VA = "0x1B5DED4")]
		public static Vector3D operator /(Vector3D a, double b)
		{
			return default(Vector3D);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x1B61E30", Offset = "0x1B61E30", VA = "0x1B61E30")]
		public static Vector3D operator *(Vector3D a, Matrix4x4 b)
		{
			return default(Vector3D);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x1B69ECC", Offset = "0x1B69ECC", VA = "0x1B69ECC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x1B61094", Offset = "0x1B61094", VA = "0x1B61094")]
		public Vector3D RandomNonParallelVector()
		{
			return default(Vector3D);
		}
	}
	[Token(Token = "0x2000105")]
	public struct Vector2D : IEquatable<Vector2D>
	{
		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double X;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double Y;

		[Token(Token = "0x170000EE")]
		public double Length
		{
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x1B5F580", Offset = "0x1B5F580", VA = "0x1B5F580")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000EF")]
		public Vector2D Unit
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x1B5F710", Offset = "0x1B5F710", VA = "0x1B5F710")]
			get
			{
				return default(Vector2D);
			}
		}

		[Token(Token = "0x170000F0")]
		public Vector2D Negated
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0x1B5F700", Offset = "0x1B5F700", VA = "0x1B5F700")]
			get
			{
				return default(Vector2D);
			}
		}

		[Token(Token = "0x170000F1")]
		public Vector2D Normal
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x1B5F630", Offset = "0x1B5F630", VA = "0x1B5F630")]
			get
			{
				return default(Vector2D);
			}
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x1B611C4", Offset = "0x1B611C4", VA = "0x1B611C4")]
		public Vector2D(double x, double y)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x1B69DB0", Offset = "0x1B69DB0", VA = "0x1B69DB0", Slot = "4")]
		public bool Equals(Vector2D a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x1B66F7C", Offset = "0x1B66F7C", VA = "0x1B66F7C")]
		public double DistanceTo(Vector2D a)
		{
			return default(double);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x1B5F740", Offset = "0x1B5F740", VA = "0x1B5F740")]
		public double Dot(Vector2D a)
		{
			return default(double);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x1B61B38", Offset = "0x1B61B38", VA = "0x1B61B38")]
		public static Vector2D operator +(Vector2D a, Vector2D b)
		{
			return default(Vector2D);
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x1B5F6F4", Offset = "0x1B5F6F4", VA = "0x1B5F6F4")]
		public static Vector2D operator -(Vector2D a, Vector2D b)
		{
			return default(Vector2D);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x1B69DD4", Offset = "0x1B69DD4", VA = "0x1B69DD4")]
		public static Vector2D operator *(Vector2D a, Vector2D b)
		{
			return default(Vector2D);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x1B5F618", Offset = "0x1B5F618", VA = "0x1B5F618")]
		public static Vector2D operator *(Vector2D a, double b)
		{
			return default(Vector2D);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x1B69DE0", Offset = "0x1B69DE0", VA = "0x1B69DE0")]
		public static Vector2D operator /(Vector2D a, double b)
		{
			return default(Vector2D);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x1B69DEC", Offset = "0x1B69DEC", VA = "0x1B69DEC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000106")]
	public class BoundingBox
	{
		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Vector3D Min;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly Vector3D Max;

		[Token(Token = "0x170000F2")]
		public Vector3D Size
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x1B5DE7C", Offset = "0x1B5DE7C", VA = "0x1B5DE7C")]
			get
			{
				return default(Vector3D);
			}
		}

		[Token(Token = "0x170000F3")]
		public Vector3D Center
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x1B5DEA8", Offset = "0x1B5DEA8", VA = "0x1B5DEA8")]
			get
			{
				return default(Vector3D);
			}
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x1B5DCF0", Offset = "0x1B5DCF0", VA = "0x1B5DCF0")]
		public BoundingBox(Vector3D min, Vector3D max)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x1B5DD50", Offset = "0x1B5DD50", VA = "0x1B5DD50")]
		public BoundingBox At(Vector3D position, Vector3D size)
		{
			return null;
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x1B5DE04", Offset = "0x1B5DE04", VA = "0x1B5DE04")]
		public BoundingBox(double dx, double dy, double dz)
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x1B5DEE4", Offset = "0x1B5DEE4", VA = "0x1B5DEE4")]
		public static BoundingBox operator +(BoundingBox a, Vector3D b)
		{
			return null;
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1B5DFA0", Offset = "0x1B5DFA0", VA = "0x1B5DFA0")]
		public bool Intersects(BoundingBox b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x1B5E01C", Offset = "0x1B5E01C", VA = "0x1B5E01C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000107")]
	public class BoundingSphere
	{
		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3D Center;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double Radius;

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x1B5E100", Offset = "0x1B5E100", VA = "0x1B5E100")]
		public BoundingSphere()
		{
		}
	}
	[Token(Token = "0x2000108")]
	internal class OrthoNormalBasis
	{
		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Vector3D U;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly Vector3D V;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly Plane Plane;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly Vector3D PlaneOrigin;

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x1B60F8C", Offset = "0x1B60F8C", VA = "0x1B60F8C")]
		public OrthoNormalBasis(Plane plane)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x1B61168", Offset = "0x1B61168", VA = "0x1B61168")]
		public Vector2D To2D(Vector3D vec3)
		{
			return default(Vector2D);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x1B611CC", Offset = "0x1B611CC", VA = "0x1B611CC")]
		public Vector3D To3D(Vector2D vec2)
		{
			return default(Vector3D);
		}
	}
	[Token(Token = "0x2000109")]
	internal class Line2D
	{
		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Vector2D normal;

		[Token(Token = "0x170000F4")]
		public Vector2D Direction
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x1B5F624", Offset = "0x1B5F624", VA = "0x1B5F624")]
			get
			{
				return default(Vector2D);
			}
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x1B5F524", Offset = "0x1B5F524", VA = "0x1B5F524")]
		public Line2D(Vector2D normal, double w)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x1B5F63C", Offset = "0x1B5F63C", VA = "0x1B5F63C")]
		public static Line2D FromPoints(Vector2D p1, Vector2D p2)
		{
			return null;
		}
	}
	[Token(Token = "0x200010A")]
	public class Matrix4x4
	{
		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly double[] elements;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsMirroring;

		[Token(Token = "0x170000F5")]
		public double[] Elements
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x1B5F7FC", Offset = "0x1B5F7FC", VA = "0x1B5F7FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x1B5F754", Offset = "0x1B5F754", VA = "0x1B5F754")]
		public Matrix4x4(double[] els)
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x1B5F780", Offset = "0x1B5F780", VA = "0x1B5F780")]
		public Matrix4x4()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x1B5F804", Offset = "0x1B5F804", VA = "0x1B5F804")]
		public static Matrix4x4 Scaling(Vector3D vec)
		{
			return null;
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x1B5F8E0", Offset = "0x1B5F8E0", VA = "0x1B5F8E0")]
		public static Matrix4x4 Translation(Vector3D vec)
		{
			return null;
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x1B5F9C4", Offset = "0x1B5F9C4", VA = "0x1B5F9C4")]
		public static Matrix4x4 RotationX(double degrees)
		{
			return null;
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x1B5FB00", Offset = "0x1B5FB00", VA = "0x1B5FB00")]
		public static Matrix4x4 RotationY(double degrees)
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x1B5FC3C", Offset = "0x1B5FC3C", VA = "0x1B5FC3C")]
		public static Matrix4x4 RotationZ(double degrees)
		{
			return null;
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x1B5FD74", Offset = "0x1B5FD74", VA = "0x1B5FD74")]
		public Vector3D LeftMultiply1x3Vector(Vector3D v)
		{
			return default(Vector3D);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x1B5FE70", Offset = "0x1B5FE70", VA = "0x1B5FE70")]
		public static Matrix4x4 operator *(Matrix4x4 l, Matrix4x4 m)
		{
			return null;
		}
	}
	[Token(Token = "0x200010B")]
	public class Vertex
	{
		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Vector3D Pos;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly Vector2D Tex;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int tag;

		[Token(Token = "0x170000F6")]
		public int Tag
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x1B5EEF8", Offset = "0x1B5EEF8", VA = "0x1B5EEF8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x1B61B44", Offset = "0x1B61B44", VA = "0x1B61B44")]
		public Vertex(Vector3D pos, Vector2D tex)
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x1B62658", Offset = "0x1B62658", VA = "0x1B62658")]
		public Vertex Flipped()
		{
			return null;
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x1B69FC0", Offset = "0x1B69FC0", VA = "0x1B69FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x1B6527C", Offset = "0x1B6527C", VA = "0x1B6527C")]
		public Vertex Transform(Matrix4x4 matrix4x4)
		{
			return null;
		}
	}
}
