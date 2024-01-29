using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace VLB
{
	[Token(Token = "0x2000002")]
	public static class BatchingHelper
	{
		[Token(Token = "0x4000001")]
		public const bool isGpuInstancingSupported = true;

		[Token(Token = "0x17000001")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x1FAA6DC", Offset = "0x1FAA6DC", VA = "0x1FAA6DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1FAA790", Offset = "0x1FAA790", VA = "0x1FAA790")]
		public static bool IsGpuInstancingEnabled(Material material)
		{
			return default(bool);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1FAA7A8", Offset = "0x1FAA7A8", VA = "0x1FAA7A8")]
		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1FAA7C4", Offset = "0x1FAA7C4", VA = "0x1FAA7C4")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1FAAE3C", Offset = "0x1FAAE3C", VA = "0x1FAAE3C")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1FAAFFC", Offset = "0x1FAAFFC", VA = "0x1FAAFFC")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B284C", Offset = "0x9B284C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B284C", Offset = "0x9B284C")]
	[ExecuteInEditMode]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x2000004")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B28BC", Offset = "0x9B28BC")]
		private sealed class <CoUpdateFadeOut>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400000C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400000D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400000E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000037")]
				[Address(RVA = "0x1E375D0", Offset = "0x1E375D0", VA = "0x1E375D0", Slot = "4")]
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
				[Address(RVA = "0x1E37618", Offset = "0x1E37618", VA = "0x1E37618", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1E37508", Offset = "0x1E37508", VA = "0x1E37508")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1E37534", Offset = "0x1E37534", VA = "0x1E37534", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1E37538", Offset = "0x1E37538", VA = "0x1E37538", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0x1E375D8", Offset = "0x1E375D8", VA = "0x1E375D8", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3F00", Offset = "0x9B3F00")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3F10", Offset = "0x9B3F10")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3F20", Offset = "0x9B3F20")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x17000002")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x1FAB0BC", Offset = "0x1FAB0BC", VA = "0x1FAB0BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC9A0", Offset = "0x9BC9A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1FAB0C4", Offset = "0x1FAB0C4", VA = "0x1FAB0C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC9B0", Offset = "0x9BC9B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x1FAB0CC", Offset = "0x1FAB0CC", VA = "0x1FAB0CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC9C0", Offset = "0x9BC9C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x1FAB0D4", Offset = "0x1FAB0D4", VA = "0x1FAB0D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC9D0", Offset = "0x9BC9D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public Mesh coneMesh
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x1FAB0DC", Offset = "0x1FAB0DC", VA = "0x1FAB0DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC9E0", Offset = "0x9BC9E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x1FAB0E4", Offset = "0x1FAB0E4", VA = "0x1FAB0E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC9F0", Offset = "0x9BC9F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public bool visible
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x1FAB0EC", Offset = "0x1FAB0EC", VA = "0x1FAB0EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1FAB108", Offset = "0x1FAB108", VA = "0x1FAB108")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public int sortingLayerID
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x1FAB128", Offset = "0x1FAB128", VA = "0x1FAB128")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x1FAB144", Offset = "0x1FAB144", VA = "0x1FAB144")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public int sortingOrder
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x1FAB160", Offset = "0x1FAB160", VA = "0x1FAB160")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x1FAB17C", Offset = "0x1FAB17C", VA = "0x1FAB17C")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x1FAB198", Offset = "0x1FAB198", VA = "0x1FAB198")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1FABA04", Offset = "0x1FABA04", VA = "0x1FABA04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x1FABA0C", Offset = "0x1FABA0C", VA = "0x1FABA0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x1FACDAC", Offset = "0x1FACDAC", VA = "0x1FACDAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x1FACE48", Offset = "0x1FACE48", VA = "0x1FACE48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1FAB1A8", Offset = "0x1FAB1A8", VA = "0x1FAB1A8")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1FAB290", Offset = "0x1FAB290", VA = "0x1FAB290")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BCA00", Offset = "0x9BCA00")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1FAB2FC", Offset = "0x1FAB2FC", VA = "0x1FAB2FC")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1FAB3CC", Offset = "0x1FAB3CC", VA = "0x1FAB3CC")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1FAB724", Offset = "0x1FAB724", VA = "0x1FAB724")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1FAB7E0", Offset = "0x1FAB7E0", VA = "0x1FAB7E0")]
		private void Start()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1FAB89C", Offset = "0x1FAB89C", VA = "0x1FAB89C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1FAB940", Offset = "0x1FAB940", VA = "0x1FAB940")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1FABAA8", Offset = "0x1FABAA8", VA = "0x1FABAA8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1FABB6C", Offset = "0x1FABB6C", VA = "0x1FABB6C")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1FAC12C", Offset = "0x1FAC12C", VA = "0x1FAC12C")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1FACCD4", Offset = "0x1FACCD4", VA = "0x1FACCD4")]
		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1FABEEC", Offset = "0x1FABEEC", VA = "0x1FABEEC")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1FAB55C", Offset = "0x1FAB55C", VA = "0x1FAB55C", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1FACE8C", Offset = "0x1FACE8C", VA = "0x1FACE8C", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1FACFB8", Offset = "0x1FACFB8", VA = "0x1FACFB8", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1FAD0E4", Offset = "0x1FAD0E4", VA = "0x1FAD0E4", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1FAD218", Offset = "0x1FAD218", VA = "0x1FAD218", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1FAB490", Offset = "0x1FAB490", VA = "0x1FAB490")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1FAB658", Offset = "0x1FAB658", VA = "0x1FAB658")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1FAD308", Offset = "0x1FAD308", VA = "0x1FAD308")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1FAC464", Offset = "0x1FAC464", VA = "0x1FAC464")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1FAD408", Offset = "0x1FAD408", VA = "0x1FAD408")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1FAD588", Offset = "0x1FAD588", VA = "0x1FAD588")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1FAD590", Offset = "0x1FAD590", VA = "0x1FAD590")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1FAD610", Offset = "0x1FAD610", VA = "0x1FAD610")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1FAD6F8", Offset = "0x1FAD6F8", VA = "0x1FAD6F8")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1FAD9B0", Offset = "0x1FAD9B0", VA = "0x1FAD9B0")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B28CC", Offset = "0x9B28CC")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x400000F")]
		public const string ClassName = "Config";

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B3F30", Offset = "0x9B3F30")]
		private RenderPipeline _RenderPipeline;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B3F7C", Offset = "0x9B3F7C")]
		private RenderingMode _RenderingMode;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float ditheringFactor;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int sharedMeshSides;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B3FC8", Offset = "0x9B3FC8")]
		public float globalNoiseScale;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string fadeOutCameraTag;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HighlightNull]
		public Texture3D noiseTexture3D;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D ditheringNoiseTexture;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public FeatureEnabledColorGradient featureEnabledColorGradient;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool featureEnabledDepthBlend;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		public bool featureEnabledNoise3D;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x76")]
		public bool featureEnabledDynamicOcclusion;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x77")]
		public bool featureEnabledMeshSkewing;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool featureEnabledShaderAccuracyHigh;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Material _DummyMaterial;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Shader _BeamShader;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config ms_Instance;

		[Token(Token = "0x1700000F")]
		public RenderPipeline renderPipeline
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x2088194", Offset = "0x2088194", VA = "0x2088194")]
			get
			{
				return default(RenderPipeline);
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x208819C", Offset = "0x208819C", VA = "0x208819C")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2088210", Offset = "0x2088210", VA = "0x2088210")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2088218", Offset = "0x2088218", VA = "0x2088218")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x2088314", Offset = "0x2088314", VA = "0x2088314")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000012")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2088360", Offset = "0x2088360", VA = "0x2088360")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public bool requiresDoubleSidedMesh
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x208837C", Offset = "0x208837C", VA = "0x208837C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		public Shader beamShader
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2088398", Offset = "0x2088398", VA = "0x2088398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x20883A0", Offset = "0x20883A0", VA = "0x20883A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public bool hasRenderPipelineMismatch
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x20884B8", Offset = "0x20884B8", VA = "0x20884B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public static Config Instance
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2088634", Offset = "0x2088634", VA = "0x2088634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x208828C", Offset = "0x208828C", VA = "0x208828C")]
		public bool IsSRPBatcherSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2088420", Offset = "0x2088420", VA = "0x2088420")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2088534", Offset = "0x2088534", VA = "0x2088534")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9BCAB0", Offset = "0x9BCAB0")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2088768", Offset = "0x2088768", VA = "0x2088768")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2088690", Offset = "0x2088690", VA = "0x2088690")]
		private void RefreshGlobalShaderProperties()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2088868", Offset = "0x2088868", VA = "0x2088868")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2088A14", Offset = "0x2088A14", VA = "0x2088A14")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2088BE4", Offset = "0x2088BE4", VA = "0x2088BE4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2088BF0", Offset = "0x2088BF0", VA = "0x2088BF0")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2088BF4", Offset = "0x2088BF4", VA = "0x2088BF4")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2088DB8", Offset = "0x2088DB8", VA = "0x2088DB8")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B2904", Offset = "0x9B2904")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x400002A")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2088EC0", Offset = "0x2088EC0", VA = "0x2088EC0")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class Consts
	{
		[Token(Token = "0x2000008")]
		public static class Help
		{
			[Token(Token = "0x400002C")]
			private const string UrlBase = "http://saladgamer.com/vlb-doc/";

			[Token(Token = "0x400002D")]
			public const string UrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

			[Token(Token = "0x400002E")]
			public const string UrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

			[Token(Token = "0x400002F")]
			public const string UrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/";

			[Token(Token = "0x4000030")]
			public const string UrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/";

			[Token(Token = "0x4000031")]
			public const string UrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

			[Token(Token = "0x4000032")]
			public const string UrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle/";

			[Token(Token = "0x4000033")]
			public const string UrlEffectFlicker = "http://saladgamer.com/vlb-doc/comp-effect-flicker/";

			[Token(Token = "0x4000034")]
			public const string UrlEffectPulse = "http://saladgamer.com/vlb-doc/comp-effect-pulse/";

			[Token(Token = "0x4000035")]
			public const string UrlConfig = "http://saladgamer.com/vlb-doc/config/";
		}

		[Token(Token = "0x2000009")]
		public static class Internal
		{
			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly bool ProceduralObjectsVisibleInEditor;

			[Token(Token = "0x17000018")]
			public static HideFlags ProceduralObjectsHideFlags
			{
				[Token(Token = "0x6000052")]
				[Address(RVA = "0x1E37A74", Offset = "0x1E37A74", VA = "0x1E37A74")]
				get
				{
					return default(HideFlags);
				}
			}
		}

		[Token(Token = "0x200000A")]
		public static class Beam
		{
			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Color FlatColor;

			[Token(Token = "0x4000038")]
			public const ColorMode ColorModeDefault = ColorMode.Flat;

			[Token(Token = "0x4000039")]
			public const float IntensityDefault = 1f;

			[Token(Token = "0x400003A")]
			public const float IntensityMin = 0f;

			[Token(Token = "0x400003B")]
			public const float SpotAngleDefault = 35f;

			[Token(Token = "0x400003C")]
			public const float SpotAngleMin = 0.1f;

			[Token(Token = "0x400003D")]
			public const float SpotAngleMax = 179.9f;

			[Token(Token = "0x400003E")]
			public const float ConeRadiusStart = 0.1f;

			[Token(Token = "0x400003F")]
			public const MeshType GeomMeshType = MeshType.Shared;

			[Token(Token = "0x4000040")]
			public const int GeomSidesDefault = 18;

			[Token(Token = "0x4000041")]
			public const int GeomSidesMin = 3;

			[Token(Token = "0x4000042")]
			public const int GeomSidesMax = 256;

			[Token(Token = "0x4000043")]
			public const int GeomSegmentsDefault = 5;

			[Token(Token = "0x4000044")]
			public const int GeomSegmentsMin = 0;

			[Token(Token = "0x4000045")]
			public const int GeomSegmentsMax = 64;

			[Token(Token = "0x4000046")]
			public const bool GeomCap = false;

			[Token(Token = "0x4000047")]
			public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

			[Token(Token = "0x4000048")]
			public const float AttenuationCustomBlending = 0.5f;

			[Token(Token = "0x4000049")]
			public const float FallOffStart = 0f;

			[Token(Token = "0x400004A")]
			public const float FallOffEnd = 3f;

			[Token(Token = "0x400004B")]
			public const float FallOffDistancesMinThreshold = 0.01f;

			[Token(Token = "0x400004C")]
			public const float DepthBlendDistance = 2f;

			[Token(Token = "0x400004D")]
			public const float CameraClippingDistance = 0.5f;

			[Token(Token = "0x400004E")]
			public const float FresnelPowMaxValue = 10f;

			[Token(Token = "0x400004F")]
			public const float FresnelPow = 8f;

			[Token(Token = "0x4000050")]
			public const float GlareFrontal = 0.5f;

			[Token(Token = "0x4000051")]
			public const float GlareBehind = 0.5f;

			[Token(Token = "0x4000052")]
			public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

			[Token(Token = "0x4000053")]
			public const float NoiseIntensityMin = 0f;

			[Token(Token = "0x4000054")]
			public const float NoiseIntensityMax = 1f;

			[Token(Token = "0x4000055")]
			public const float NoiseIntensityDefault = 0.5f;

			[Token(Token = "0x4000056")]
			public const float NoiseScaleMin = 0.01f;

			[Token(Token = "0x4000057")]
			public const float NoiseScaleMax = 2f;

			[Token(Token = "0x4000058")]
			public const float NoiseScaleDefault = 0.5f;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly Vector3 NoiseVelocityDefault;

			[Token(Token = "0x400005A")]
			public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

			[Token(Token = "0x400005B")]
			public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.Fast;

			[Token(Token = "0x400005C")]
			public const float FadeOutBeginDefault = -150f;

			[Token(Token = "0x400005D")]
			public const float FadeOutEndDefault = -200f;

			[Token(Token = "0x400005E")]
			public const Dimensions DimensionsDefault = Dimensions.Dim3D;

			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static readonly Vector2 TiltDefault;

			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static readonly Vector3 SkewingLocalForwardDirectionDefault;

			[Token(Token = "0x4000061")]
			public const Transform ClippingPlaneTransformDefault = null;
		}

		[Token(Token = "0x200000B")]
		public static class DustParticles
		{
			[Token(Token = "0x4000062")]
			public const float AlphaDefault = 0.5f;

			[Token(Token = "0x4000063")]
			public const float SizeDefault = 0.01f;

			[Token(Token = "0x4000064")]
			public const ParticlesDirection DirectionDefault = ParticlesDirection.Random;

			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Vector3 VelocityDefault;

			[Token(Token = "0x4000066")]
			public const float DensityDefault = 5f;

			[Token(Token = "0x4000067")]
			public const float DensityMin = 0f;

			[Token(Token = "0x4000068")]
			public const float DensityMax = 1000f;

			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly MinMaxRangeFloat SpawnDistanceRangeDefault;

			[Token(Token = "0x400006A")]
			public const bool CullingEnabledDefault = false;

			[Token(Token = "0x400006B")]
			public const float CullingMaxDistanceDefault = 10f;

			[Token(Token = "0x400006C")]
			public const float CullingMaxDistanceMin = 1f;
		}

		[Token(Token = "0x200000C")]
		public static class DynOcclusion
		{
			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly LayerMask LayerMaskDefault;

			[Token(Token = "0x400006E")]
			public const float FadeDistanceToSurfaceDefault = 0.25f;

			[Token(Token = "0x400006F")]
			public const DynamicOcclusionUpdateRate UpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

			[Token(Token = "0x4000070")]
			public const int WaitFramesCountDefault = 3;

			[Token(Token = "0x4000071")]
			public const Dimensions RaycastingDimensionsDefault = Dimensions.Dim3D;

			[Token(Token = "0x4000072")]
			public const bool RaycastingConsiderTriggersDefault = false;

			[Token(Token = "0x4000073")]
			public const float RaycastingMinOccluderAreaDefault = 0f;

			[Token(Token = "0x4000074")]
			public const float RaycastingMinSurfaceRatioDefault = 0.5f;

			[Token(Token = "0x4000075")]
			public const float RaycastingMinSurfaceRatioMin = 50f;

			[Token(Token = "0x4000076")]
			public const float RaycastingMinSurfaceRatioMax = 100f;

			[Token(Token = "0x4000077")]
			public const float RaycastingMaxSurfaceDotDefault = 0.25f;

			[Token(Token = "0x4000078")]
			public const float RaycastingMaxSurfaceAngleMin = 45f;

			[Token(Token = "0x4000079")]
			public const float RaycastingMaxSurfaceAngleMax = 90f;

			[Token(Token = "0x400007A")]
			public const PlaneAlignment RaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

			[Token(Token = "0x400007B")]
			public const float RaycastingPlaneOffsetDefault = 0.1f;

			[Token(Token = "0x400007C")]
			public const int DepthBufferDepthMapResolutionDefault = 32;

			[Token(Token = "0x400007D")]
			public const bool DepthBufferOcclusionCullingDefault = true;
		}

		[Token(Token = "0x200000D")]
		public static class Effects
		{
			[Token(Token = "0x400007E")]
			public const EffectAbstractBase.ComponentsToChange ComponentsToChangeDefault = (EffectAbstractBase.ComponentsToChange)2147483647;

			[Token(Token = "0x400007F")]
			public const bool RestoreBaseIntensityDefault = true;

			[Token(Token = "0x4000080")]
			public const float FrequencyDefault = 10f;

			[Token(Token = "0x4000081")]
			public const bool PerformPausesDefault = false;

			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly MinMaxRangeFloat FlickeringDurationDefault;

			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly MinMaxRangeFloat PauseDurationDefault;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly MinMaxRangeFloat IntensityAmplitudeDefault;

			[Token(Token = "0x4000085")]
			public const float SmoothingDefault = 0.05f;
		}

		[Token(Token = "0x200000E")]
		public static class Config
		{
			[Token(Token = "0x4000086")]
			public const bool GeometryOverrideLayerDefault = true;

			[Token(Token = "0x4000087")]
			public const int GeometryLayerIDDefault = 1;

			[Token(Token = "0x4000088")]
			public const string GeometryTagDefault = "Untagged";

			[Token(Token = "0x4000089")]
			public const string FadeOutCameraTagDefault = "MainCamera";

			[Token(Token = "0x400008A")]
			public const RenderQueue GeometryRenderQueueDefault = RenderQueue.Transparent;

			[Token(Token = "0x400008B")]
			public const RenderPipeline GeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

			[Token(Token = "0x400008C")]
			public const RenderingMode GeometryRenderingModeDefault = RenderingMode.SinglePass;

			[Token(Token = "0x400008D")]
			public const int Noise3DSizeDefault = 64;

			[Token(Token = "0x400008E")]
			public const int SharedMeshSides = 24;

			[Token(Token = "0x400008F")]
			public const int SharedMeshSegments = 5;

			[Token(Token = "0x4000090")]
			public const float DitheringFactor = 0f;

			[Token(Token = "0x4000091")]
			public const bool FeatureEnabledDefault = true;

			[Token(Token = "0x4000092")]
			public const FeatureEnabledColorGradient FeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly;
		}

		[Token(Token = "0x400002B")]
		public const string PluginFolder = "Plugins/VolumetricLightBeam";
	}
	[Token(Token = "0x200000F")]
	public static class DummyMaterial
	{
	}
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B293C", Offset = "0x9B293C")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B293C", Offset = "0x9B293C")]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x2000011")]
		protected enum ProcessOcclusionSource
		{
			[Token(Token = "0x400009D")]
			RenderLoop,
			[Token(Token = "0x400009E")]
			OnEnable,
			[Token(Token = "0x400009F")]
			EditorUpdate,
			[Token(Token = "0x40000A0")]
			User
		}

		[Token(Token = "0x4000093")]
		public const string ClassName = "DynamicOcclusionAbstractBase";

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicOcclusionUpdateRate updateRate;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B4034", Offset = "0x9B4034")]
		public int waitXFrames;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TransformUtils.Packed m_TransformPacked;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_LastFrameRendered;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected VolumetricLightBeam m_Master;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected MaterialModifier.Callback m_MaterialModifierCallbackCached;

		[Token(Token = "0x17000019")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x2089C94", Offset = "0x2089C94", VA = "0x2089C94")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onOcclusionProcessed
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x2089B54", Offset = "0x2089B54", VA = "0x2089B54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BCAC0", Offset = "0x9BCAC0")]
			add
			{
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2089BF4", Offset = "0x2089BF4", VA = "0x2089BF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BCAD0", Offset = "0x9BCAD0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2089920", Offset = "0x2089920", VA = "0x2089920")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2089928", Offset = "0x2089928", VA = "0x2089928")]
		protected void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		[Token(Token = "0x600005D")]
		protected abstract string GetShaderKeyword();

		[Token(Token = "0x600005E")]
		protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

		[Token(Token = "0x600005F")]
		protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

		[Token(Token = "0x6000060")]
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		[Token(Token = "0x6000061")]
		protected abstract void OnEnablePostValidate();

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2089C9C", Offset = "0x2089C9C", VA = "0x2089C9C", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2089CD0", Offset = "0x2089CD0", VA = "0x2089CD0", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2089D44", Offset = "0x2089D44", VA = "0x2089D44", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2089DA0", Offset = "0x2089DA0", VA = "0x2089DA0", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2089F48", Offset = "0x2089F48", VA = "0x2089F48", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2089FE4", Offset = "0x2089FE4", VA = "0x2089FE4")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2089D60", Offset = "0x2089D60", VA = "0x2089D60")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x208A174", Offset = "0x208A174", VA = "0x208A174")]
		protected DynamicOcclusionAbstractBase()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x208A1E0", Offset = "0x208A1E0", VA = "0x208A1E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BCAE0", Offset = "0x9BCAE0")]
		private void <OnEnable>b__24_0()
		{
		}
	}
	[Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B29D0", Offset = "0x9B29D0")]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x40000A1")]
		public new const string ClassName = "DynamicOcclusionDepthBuffer";

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LayerMask layerMask;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool useOcclusionCulling;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int depthMapResolution;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Camera m_DepthCamera;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x208A1E8", Offset = "0x208A1E8", VA = "0x208A1E8", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x208A22C", Offset = "0x208A22C", VA = "0x208A22C", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x208A234", Offset = "0x208A234", VA = "0x208A234")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x208A400", Offset = "0x208A400", VA = "0x208A400", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x208A490", Offset = "0x208A490", VA = "0x208A490")]
		private void Update()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x208A264", Offset = "0x208A264", VA = "0x208A264")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x208A548", Offset = "0x208A548", VA = "0x208A548")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x208A600", Offset = "0x208A600", VA = "0x208A600", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x208A66C", Offset = "0x208A66C", VA = "0x208A66C")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x208A95C", Offset = "0x208A95C", VA = "0x208A95C", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x208A960", Offset = "0x208A960", VA = "0x208A960", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x208AA04", Offset = "0x208AA04", VA = "0x208AA04", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x208AA08", Offset = "0x208AA08", VA = "0x208AA08", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x208AA2C", Offset = "0x208AA2C", VA = "0x208AA2C")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x208AB94", Offset = "0x208AB94", VA = "0x208AB94", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x208AD2C", Offset = "0x208AD2C", VA = "0x208AD2C")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B2A1C", Offset = "0x9B2A1C")]
	[ExecuteInEditMode]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x2000014")]
		public struct HitResult
		{
			[Token(Token = "0x40000B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 point;

			[Token(Token = "0x40000B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 normal;

			[Token(Token = "0x40000B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float distance;

			[Token(Token = "0x40000B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Collider2D collider2D;

			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Collider collider3D;

			[Token(Token = "0x1700001E")]
			public bool hasCollider
			{
				[Token(Token = "0x600009A")]
				[Address(RVA = "0x1E37C04", Offset = "0x1E37C04", VA = "0x1E37C04")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700001F")]
			public string name
			{
				[Token(Token = "0x600009B")]
				[Address(RVA = "0x1E37CB4", Offset = "0x1E37CB4", VA = "0x1E37CB4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000020")]
			public Bounds bounds
			{
				[Token(Token = "0x600009C")]
				[Address(RVA = "0x1E37D98", Offset = "0x1E37D98", VA = "0x1E37D98")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x6000098")]
			[Address(RVA = "0x1E37B34", Offset = "0x1E37B34", VA = "0x1E37B34")]
			public HitResult(ref RaycastHit hit3D)
			{
			}

			[Token(Token = "0x6000099")]
			[Address(RVA = "0x1E37B9C", Offset = "0x1E37B9C", VA = "0x1E37B9C")]
			public HitResult(ref RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x600009D")]
			[Address(RVA = "0x1E37E94", Offset = "0x1E37E94", VA = "0x1E37E94")]
			public void SetNull()
			{
			}
		}

		[Token(Token = "0x2000015")]
		private enum Direction
		{
			[Token(Token = "0x40000BC")]
			Up = 0,
			[Token(Token = "0x40000BD")]
			Down = 1,
			[Token(Token = "0x40000BE")]
			Left = 2,
			[Token(Token = "0x40000BF")]
			Right = 3,
			[Token(Token = "0x40000C0")]
			Max2D = 1,
			[Token(Token = "0x40000C1")]
			Max3D = 3
		}

		[Token(Token = "0x40000A8")]
		public new const string ClassName = "DynamicOcclusionRaycasting";

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Dimensions dimensions;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public LayerMask layerMask;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool considerTriggers;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float minOccluderArea;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float minSurfaceRatio;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float maxSurfaceDot;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float planeOffset;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B407C", Offset = "0x9B407C")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private HitResult m_CurrentHit;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float m_RangeMultiplier;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B40B4", Offset = "0x9B40B4")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700001A")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9BFA70", Offset = "0x9BFA70")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x208ADF4", Offset = "0x208ADF4", VA = "0x208ADF4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x208ADFC", Offset = "0x208ADFC", VA = "0x208ADFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x208AE50", Offset = "0x208AE50", VA = "0x208AE50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BCAF0", Offset = "0x9BCAF0")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x208AE5C", Offset = "0x208AE5C", VA = "0x208AE5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BCB00", Offset = "0x9BCB00")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x208B090", Offset = "0x208B090", VA = "0x208B090")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x1700001D")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x208B0A4", Offset = "0x208B0A4", VA = "0x208B0A4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2088054", Offset = "0x2088054", VA = "0x2088054")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x208AE04", Offset = "0x208AE04", VA = "0x208AE04", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x208AE48", Offset = "0x208AE48", VA = "0x208AE48", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x208AE68", Offset = "0x208AE68", VA = "0x208AE68", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x208AEC8", Offset = "0x208AEC8", VA = "0x208AEC8", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x208AED4", Offset = "0x208AED4", VA = "0x208AED4", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x208AF2C", Offset = "0x208AF2C", VA = "0x208AF2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x208AFE8", Offset = "0x208AFE8", VA = "0x208AFE8")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x208B0FC", Offset = "0x208B0FC", VA = "0x208B0FC")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x208B14C", Offset = "0x208B14C", VA = "0x208B14C")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x208B408", Offset = "0x208B408", VA = "0x208B408")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x208B704", Offset = "0x208B704", VA = "0x208B704")]
		private uint GetDirectionCount()
		{
			return default(uint);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x208B71C", Offset = "0x208B71C", VA = "0x208B71C")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x208B7B4", Offset = "0x208B7B4", VA = "0x208B7B4")]
		private bool IsHitValid(ref HitResult hit, Vector3 forwardVec)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x208B830", Offset = "0x208B830", VA = "0x208B830", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x208BB54", Offset = "0x208BB54", VA = "0x208BB54")]
		private void SetHit(ref HitResult hit)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x208AF04", Offset = "0x208AF04", VA = "0x208AF04")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x208BD84", Offset = "0x208BD84", VA = "0x208BD84", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x208BC20", Offset = "0x208BC20", VA = "0x208BC20")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x208BD3C", Offset = "0x208BD3C", VA = "0x208BD3C")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x208BF90", Offset = "0x208BF90", VA = "0x208BF90")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x208BF9C", Offset = "0x208BF9C", VA = "0x208BF9C")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B2A68", Offset = "0x9B2A68")]
	[DisallowMultipleComponent]
	public class EffectAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x2000017")]
		[Flags]
		public enum ComponentsToChange
		{
			[Token(Token = "0x40000CC")]
			UnityLight = 1,
			[Token(Token = "0x40000CD")]
			VolumetricLightBeam = 2,
			[Token(Token = "0x40000CE")]
			VolumetricDustParticles = 4
		}

		[Token(Token = "0x40000C2")]
		public const string ClassName = "EffectAbstractBase";

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ComponentsToChange componentsToChange;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool restoreBaseIntensity;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected VolumetricLightBeam m_Beam;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Light m_Light;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected VolumetricDustParticles m_Particles;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected float m_BaseIntensityBeamInside;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float m_BaseIntensityBeamOutside;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected float m_BaseIntensityLight;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x208C1D4", Offset = "0x208C1D4", VA = "0x208C1D4")]
		protected void SetAdditiveIntensity(float additive)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x208C42C", Offset = "0x208C42C", VA = "0x208C42C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x208C5AC", Offset = "0x208C5AC", VA = "0x208C5AC", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x208C5B4", Offset = "0x208C5B4", VA = "0x208C5B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x208C5F4", Offset = "0x208C5F4", VA = "0x208C5F4")]
		public EffectAbstractBase()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B2AC4", Offset = "0x9B2AC4")]
	public class EffectFlicker : EffectAbstractBase
	{
		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B2AFC", Offset = "0x9B2AFC")]
		private sealed class <CoUpdate>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <remaining>5__2;

			[Token(Token = "0x17000021")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000AB")]
				[Address(RVA = "0x1E38234", Offset = "0x1E38234", VA = "0x1E38234", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000022")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000AD")]
				[Address(RVA = "0x1E3827C", Offset = "0x1E3827C", VA = "0x1E3827C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x1E38128", Offset = "0x1E38128", VA = "0x1E38128")]
			[DebuggerHidden]
			public <CoUpdate>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x1E38154", Offset = "0x1E38154", VA = "0x1E38154", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x1E38158", Offset = "0x1E38158", VA = "0x1E38158", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x1E3823C", Offset = "0x1E3823C", VA = "0x1E3823C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B2B0C", Offset = "0x9B2B0C")]
		private sealed class <CoFlicker>d__10 : IEnumerator<object>, IEnumerator, IDisposable
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
			private float <remainingDuration>5__2;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <freqDuration>5__3;

			[Token(Token = "0x17000023")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000B1")]
				[Address(RVA = "0x1E380D8", Offset = "0x1E380D8", VA = "0x1E380D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000024")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000B3")]
				[Address(RVA = "0x1E38120", Offset = "0x1E38120", VA = "0x1E38120", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x1E37FD4", Offset = "0x1E37FD4", VA = "0x1E37FD4")]
			[DebuggerHidden]
			public <CoFlicker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x1E38000", Offset = "0x1E38000", VA = "0x1E38000", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x1E38004", Offset = "0x1E38004", VA = "0x1E38004", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x1E380E0", Offset = "0x1E380E0", VA = "0x1E380E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B2B1C", Offset = "0x9B2B1C")]
		private sealed class <CoChangeIntensity>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float nextIntensity;

			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float expectedDuration;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <velocity>5__2;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <t>5__3;

			[Token(Token = "0x17000025")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000B7")]
				[Address(RVA = "0x1E37F84", Offset = "0x1E37F84", VA = "0x1E37F84", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000026")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000B9")]
				[Address(RVA = "0x1E37FCC", Offset = "0x1E37FCC", VA = "0x1E37FCC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x1E37E9C", Offset = "0x1E37E9C", VA = "0x1E37E9C")]
			[DebuggerHidden]
			public <CoChangeIntensity>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x1E37EC8", Offset = "0x1E37EC8", VA = "0x1E37EC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x1E37ECC", Offset = "0x1E37ECC", VA = "0x1E37ECC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x1E37F8C", Offset = "0x1E37F8C", VA = "0x1E37F8C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000CF")]
		public new const string ClassName = "EffectFlicker";

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B40C4", Offset = "0x9B40C4")]
		public float frequency;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool performPauses;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x9B40E0", Offset = "0x9B40E0")]
		public MinMaxRangeFloat flickeringDuration;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x9B40F8", Offset = "0x9B40F8")]
		public MinMaxRangeFloat pauseDuration;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x9B4110", Offset = "0x9B4110")]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4128", Offset = "0x9B4128")]
		public float smoothing;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_CurrentAdditiveIntensity;

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x208C60C", Offset = "0x208C60C", VA = "0x208C60C", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x208C644", Offset = "0x208C644", VA = "0x208C644")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BCB10", Offset = "0x9BCB10")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x208C6B0", Offset = "0x208C6B0", VA = "0x208C6B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BCB70", Offset = "0x9BCB70")]
		private IEnumerator CoFlicker()
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x208C71C", Offset = "0x208C71C", VA = "0x208C71C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BCBD0", Offset = "0x9BCBD0")]
		private IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x208C79C", Offset = "0x208C79C", VA = "0x208C79C")]
		public EffectFlicker()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B2B2C", Offset = "0x9B2B2C")]
	public class EffectPulse : EffectAbstractBase
	{
		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B2B64", Offset = "0x9B2B64")]
		private sealed class <CoUpdate>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EffectPulse <>4__this;

			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000027")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000C0")]
				[Address(RVA = "0x1E3836C", Offset = "0x1E3836C", VA = "0x1E3836C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000028")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000C2")]
				[Address(RVA = "0x1E383B4", Offset = "0x1E383B4", VA = "0x1E383B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x1E38284", Offset = "0x1E38284", VA = "0x1E38284")]
			[DebuggerHidden]
			public <CoUpdate>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x1E382B0", Offset = "0x1E382B0", VA = "0x1E382B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x1E382B4", Offset = "0x1E382B4", VA = "0x1E382B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x1E38374", Offset = "0x1E38374", VA = "0x1E38374", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000E7")]
		public new const string ClassName = "EffectPulse";

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4140", Offset = "0x9B4140")]
		public float frequency;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x9B4160", Offset = "0x9B4160")]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x208C84C", Offset = "0x208C84C", VA = "0x208C84C", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x208C884", Offset = "0x208C884", VA = "0x208C884")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BCD20", Offset = "0x9BCD20")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x208C8F0", Offset = "0x208C8F0", VA = "0x208C8F0")]
		public EffectPulse()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public enum FeatureEnabledColorGradient
	{
		[Token(Token = "0x40000EF")]
		Off,
		[Token(Token = "0x40000F0")]
		HighOnly,
		[Token(Token = "0x40000F1")]
		HighAndLow
	}
	[Token(Token = "0x200001F")]
	public enum ColorMode
	{
		[Token(Token = "0x40000F3")]
		Flat,
		[Token(Token = "0x40000F4")]
		Gradient
	}
	[Token(Token = "0x2000020")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x40000F6")]
		Linear,
		[Token(Token = "0x40000F7")]
		Quadratic,
		[Token(Token = "0x40000F8")]
		Blend
	}
	[Token(Token = "0x2000021")]
	public enum BlendingMode
	{
		[Token(Token = "0x40000FA")]
		Additive,
		[Token(Token = "0x40000FB")]
		SoftAdditive,
		[Token(Token = "0x40000FC")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000022")]
	public enum ShaderAccuracy
	{
		[Token(Token = "0x40000FE")]
		Fast,
		[Token(Token = "0x40000FF")]
		High
	}
	[Token(Token = "0x2000023")]
	public enum NoiseMode
	{
		[Token(Token = "0x4000101")]
		Disabled,
		[Token(Token = "0x4000102")]
		WorldSpace,
		[Token(Token = "0x4000103")]
		LocalSpace
	}
	[Token(Token = "0x2000024")]
	public enum MeshType
	{
		[Token(Token = "0x4000105")]
		Shared,
		[Token(Token = "0x4000106")]
		Custom
	}
	[Token(Token = "0x2000025")]
	public enum RenderPipeline
	{
		[Token(Token = "0x4000108")]
		BuiltIn,
		[Token(Token = "0x4000109")]
		URP,
		[Token(Token = "0x400010A")]
		HDRP
	}
	[Token(Token = "0x2000026")]
	public enum RenderingMode
	{
		[Token(Token = "0x400010C")]
		MultiPass,
		[Token(Token = "0x400010D")]
		SinglePass,
		[Token(Token = "0x400010E")]
		GPUInstancing,
		[Token(Token = "0x400010F")]
		SRPBatcher
	}
	[Token(Token = "0x2000027")]
	public enum RenderQueue
	{
		[Token(Token = "0x4000111")]
		Custom = 0,
		[Token(Token = "0x4000112")]
		Background = 1000,
		[Token(Token = "0x4000113")]
		Geometry = 2000,
		[Token(Token = "0x4000114")]
		AlphaTest = 2450,
		[Token(Token = "0x4000115")]
		GeometryLast = 2500,
		[Token(Token = "0x4000116")]
		Transparent = 3000,
		[Token(Token = "0x4000117")]
		Overlay = 4000
	}
	[Token(Token = "0x2000028")]
	public enum Dimensions
	{
		[Token(Token = "0x4000119")]
		Dim3D,
		[Token(Token = "0x400011A")]
		Dim2D
	}
	[Token(Token = "0x2000029")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x400011C")]
		Surface,
		[Token(Token = "0x400011D")]
		Beam
	}
	[Token(Token = "0x200002A")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		[Token(Token = "0x400011F")]
		Never = 1,
		[Token(Token = "0x4000120")]
		OnEnable = 2,
		[Token(Token = "0x4000121")]
		OnBeamMove = 4,
		[Token(Token = "0x4000122")]
		EveryXFrames = 8,
		[Token(Token = "0x4000123")]
		OnBeamMoveAndEveryXFrames = 0xC
	}
	[Token(Token = "0x200002B")]
	public enum ParticlesDirection
	{
		[Token(Token = "0x4000125")]
		Random,
		[Token(Token = "0x4000126")]
		LocalSpace,
		[Token(Token = "0x4000127")]
		WorldSpace
	}
	[Token(Token = "0x200002C")]
	public static class GlobalMesh
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2119530", Offset = "0x2119530", VA = "0x2119530")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2119768", Offset = "0x2119768", VA = "0x2119768")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x21219D0", Offset = "0x21219D0", VA = "0x21219D0")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public static class MaterialManager
	{
		[Token(Token = "0x200002F")]
		public enum BlendingMode
		{
			[Token(Token = "0x4000131")]
			Additive,
			[Token(Token = "0x4000132")]
			SoftAdditive,
			[Token(Token = "0x4000133")]
			TraditionalTransparency,
			[Token(Token = "0x4000134")]
			Count
		}

		[Token(Token = "0x2000030")]
		public enum Noise3D
		{
			[Token(Token = "0x4000136")]
			Off,
			[Token(Token = "0x4000137")]
			On,
			[Token(Token = "0x4000138")]
			Count
		}

		[Token(Token = "0x2000031")]
		public enum DepthBlend
		{
			[Token(Token = "0x400013A")]
			Off,
			[Token(Token = "0x400013B")]
			On,
			[Token(Token = "0x400013C")]
			Count
		}

		[Token(Token = "0x2000032")]
		public enum ColorGradient
		{
			[Token(Token = "0x400013E")]
			Off,
			[Token(Token = "0x400013F")]
			MatrixLow,
			[Token(Token = "0x4000140")]
			MatrixHigh,
			[Token(Token = "0x4000141")]
			Count
		}

		[Token(Token = "0x2000033")]
		public enum DynamicOcclusion
		{
			[Token(Token = "0x4000143")]
			Off,
			[Token(Token = "0x4000144")]
			ClippingPlane,
			[Token(Token = "0x4000145")]
			DepthTexture,
			[Token(Token = "0x4000146")]
			Count
		}

		[Token(Token = "0x2000034")]
		public enum MeshSkewing
		{
			[Token(Token = "0x4000148")]
			Off,
			[Token(Token = "0x4000149")]
			On,
			[Token(Token = "0x400014A")]
			Count
		}

		[Token(Token = "0x2000035")]
		public enum ShaderAccuracy
		{
			[Token(Token = "0x400014C")]
			Fast,
			[Token(Token = "0x400014D")]
			High,
			[Token(Token = "0x400014E")]
			Count
		}

		[Token(Token = "0x2000036")]
		public struct StaticProperties
		{
			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BlendingMode blendingMode;

			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Noise3D noise3D;

			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public DepthBlend depthBlend;

			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public ColorGradient colorGradient;

			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DynamicOcclusion dynamicOcclusion;

			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public MeshSkewing meshSkewing;

			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ShaderAccuracy shaderAccuracy;

			[Token(Token = "0x17000029")]
			private int blendingModeID
			{
				[Token(Token = "0x60000CB")]
				[Address(RVA = "0x2160044", Offset = "0x2160044", VA = "0x2160044")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002A")]
			private int noise3DID
			{
				[Token(Token = "0x60000CC")]
				[Address(RVA = "0x216004C", Offset = "0x216004C", VA = "0x216004C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002B")]
			private int depthBlendID
			{
				[Token(Token = "0x60000CD")]
				[Address(RVA = "0x21600CC", Offset = "0x21600CC", VA = "0x21600CC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002C")]
			private int colorGradientID
			{
				[Token(Token = "0x60000CE")]
				[Address(RVA = "0x216014C", Offset = "0x216014C", VA = "0x216014C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002D")]
			private int dynamicOcclusionID
			{
				[Token(Token = "0x60000CF")]
				[Address(RVA = "0x21601CC", Offset = "0x21601CC", VA = "0x21601CC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002E")]
			private int meshSkewingID
			{
				[Token(Token = "0x60000D0")]
				[Address(RVA = "0x216024C", Offset = "0x216024C", VA = "0x216024C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700002F")]
			private int shaderAccuracyID
			{
				[Token(Token = "0x60000D1")]
				[Address(RVA = "0x21602CC", Offset = "0x21602CC", VA = "0x21602CC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000030")]
			public int materialID
			{
				[Token(Token = "0x60000D2")]
				[Address(RVA = "0x216034C", Offset = "0x216034C", VA = "0x216034C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x21603E4", Offset = "0x21603E4", VA = "0x21603E4")]
			public void ApplyToMaterial(Material mat)
			{
			}
		}

		[Token(Token = "0x2000037")]
		private class MaterialsGroup
		{
			[Token(Token = "0x4000156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x215FFB4", Offset = "0x215FFB4", VA = "0x215FFB4")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x208323C", Offset = "0x208323C", VA = "0x208323C")]
		public static Material NewMaterialTransient(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x20833B4", Offset = "0x20833B4", VA = "0x20833B4")]
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x20834C0", Offset = "0x20834C0", VA = "0x20834C0")]
		public static Material GetInstancedMaterial(uint groupID, ref StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x2000038")]
	public static class MaterialModifier
	{
		[Token(Token = "0x2000039")]
		public interface Interface
		{
			[Token(Token = "0x60000D5")]
			void SetMaterialProp(int nameID, float value);

			[Token(Token = "0x60000D6")]
			void SetMaterialProp(int nameID, Vector4 value);

			[Token(Token = "0x60000D7")]
			void SetMaterialProp(int nameID, Color value);

			[Token(Token = "0x60000D8")]
			void SetMaterialProp(int nameID, Matrix4x4 value);

			[Token(Token = "0x60000D9")]
			void SetMaterialProp(int nameID, Texture value);
		}

		[Token(Token = "0x200003A")]
		public delegate void Callback(Interface owner);
	}
	[Token(Token = "0x200003B")]
	public static class MeshGenerator
	{
		[Token(Token = "0x4000157")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x19B5F8C", Offset = "0x19B5F8C", VA = "0x19B5F8C")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x19B5FA4", Offset = "0x19B5FA4", VA = "0x19B5FA4")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x19B681C", Offset = "0x19B681C", VA = "0x19B681C")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x19B6018", Offset = "0x19B6018", VA = "0x19B6018")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x19B688C", Offset = "0x19B688C", VA = "0x19B688C")]
		public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x19B68F0", Offset = "0x19B68F0", VA = "0x19B68F0")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x19B690C", Offset = "0x19B690C", VA = "0x19B690C")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x19B6934", Offset = "0x19B6934", VA = "0x19B6934")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x19B69D8", Offset = "0x19B69D8", VA = "0x19B69D8")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public struct MinMaxRangeFloat
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float m_MinValue;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private float m_MaxValue;

		[Token(Token = "0x17000031")]
		public float minValue
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x19B6AD8", Offset = "0x19B6AD8", VA = "0x19B6AD8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		public float maxValue
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x19B6AE0", Offset = "0x19B6AE0", VA = "0x19B6AE0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000033")]
		public float randomValue
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x19B6AE8", Offset = "0x19B6AE8", VA = "0x19B6AE8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000034")]
		public Vector2 asVector2
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x19B6AF4", Offset = "0x19B6AF4", VA = "0x19B6AF4")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x19B6AFC", Offset = "0x19B6AFC", VA = "0x19B6AFC")]
		public float GetLerpedValue(float lerp01)
		{
			return default(float);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x19B6B14", Offset = "0x19B6B14", VA = "0x19B6B14")]
		public MinMaxRangeFloat(float min, float max)
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class MinMaxRangeAttribute : Attribute
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4198", Offset = "0x9B4198")]
		private float <minValue>k__BackingField;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B41A8", Offset = "0x9B41A8")]
		private float <maxValue>k__BackingField;

		[Token(Token = "0x17000035")]
		public float minValue
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x19B6A80", Offset = "0x19B6A80", VA = "0x19B6A80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BCDD0", Offset = "0x9BCDD0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x19B6A88", Offset = "0x19B6A88", VA = "0x19B6A88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BCDE0", Offset = "0x9BCDE0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public float maxValue
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x19B6A90", Offset = "0x19B6A90", VA = "0x19B6A90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BCDF0", Offset = "0x9BCDF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x19B6A98", Offset = "0x19B6A98", VA = "0x19B6A98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BCE00", Offset = "0x9BCE00")]
			private set
			{
			}
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x19B6AA0", Offset = "0x19B6AA0", VA = "0x19B6AA0")]
		public MinMaxRangeAttribute(float min, float max)
		{
		}
	}
	[Token(Token = "0x200003E")]
	public static class Noise3D
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x400015F")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x17000037")]
		public static bool isSupported
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x19B7B6C", Offset = "0x19B7B6C", VA = "0x19B7B6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x19B7D6C", Offset = "0x19B7D6C", VA = "0x19B7D6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x19B7CC4", Offset = "0x19B7CC4", VA = "0x19B7CC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x19B7E0C", Offset = "0x19B7E0C", VA = "0x19B7E0C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9BCE10", Offset = "0x9BCE10")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x19B7E64", Offset = "0x19B7E64", VA = "0x19B7E64")]
		public static void LoadIfNeeded()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class PlatformHelper
	{
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x19BA278", Offset = "0x19BA278", VA = "0x19BA278")]
		public static string GetCurrentPlatformSuffix()
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x19BA290", Offset = "0x19BA290", VA = "0x19BA290")]
		private static string GetPlatformSuffix(RuntimePlatform platform)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x19BA310", Offset = "0x19BA310", VA = "0x19BA310")]
		public PlatformHelper()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class PolygonHelper : MonoBehaviour
	{
		[Token(Token = "0x2000041")]
		public struct Plane2D
		{
			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 normal;

			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float distance;

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x2161E5C", Offset = "0x2161E5C", VA = "0x2161E5C")]
			public float Distance(Vector2 point)
			{
				return default(float);
			}

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x2161E78", Offset = "0x2161E78", VA = "0x2161E78")]
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x2161EA4", Offset = "0x2161EA4", VA = "0x2161EA4")]
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x2161F9C", Offset = "0x2161F9C", VA = "0x2161F9C")]
			public bool GetSide(Vector2 point)
			{
				return default(bool);
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x2161FC0", Offset = "0x2161FC0", VA = "0x2161FC0")]
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0x2162020", Offset = "0x2162020", VA = "0x2162020")]
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x6000102")]
			[Address(RVA = "0x2162030", Offset = "0x2162030", VA = "0x2162030")]
			public void Flip()
			{
			}

			[Token(Token = "0x6000103")]
			[Address(RVA = "0x216204C", Offset = "0x216204C", VA = "0x216204C")]
			public Vector2[] CutConvex(Vector2[] poly)
			{
				return null;
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0x2162238", Offset = "0x2162238", VA = "0x2162238", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x19BA7B8", Offset = "0x19BA7B8", VA = "0x19BA7B8")]
		public PolygonHelper()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public static class SRPHelper
	{
		[Token(Token = "0x2000043")]
		public enum RenderPipeline
		{
			[Token(Token = "0x4000164")]
			Undefined,
			[Token(Token = "0x4000165")]
			BuiltIn,
			[Token(Token = "0x4000166")]
			URP,
			[Token(Token = "0x4000167")]
			LWRP,
			[Token(Token = "0x4000168")]
			HDRP
		}

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RenderPipeline m_RenderPipelineCached;

		[Token(Token = "0x1700003A")]
		public static RenderPipeline renderPipelineType
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x19BFC28", Offset = "0x19BFC28", VA = "0x19BFC28")]
			get
			{
				return default(RenderPipeline);
			}
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x19BFCD8", Offset = "0x19BFCD8", VA = "0x19BFCD8")]
		private static RenderPipeline ComputeRenderPipeline()
		{
			return default(RenderPipeline);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x19BFE0C", Offset = "0x19BFE0C", VA = "0x19BFE0C")]
		public static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x19BFF04", Offset = "0x19BFF04", VA = "0x19BFF04")]
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x19BFFB4", Offset = "0x19BFFB4", VA = "0x19BFFB4")]
		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}
	}
	[Token(Token = "0x2000044")]
	public static class ShaderKeywords
	{
		[Token(Token = "0x4000169")]
		public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK";

		[Token(Token = "0x400016A")]
		public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW";

		[Token(Token = "0x400016B")]
		public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH";

		[Token(Token = "0x400016C")]
		public const string DepthBlend = "VLB_DEPTH_BLEND";

		[Token(Token = "0x400016D")]
		public const string Noise3D = "VLB_NOISE_3D";

		[Token(Token = "0x400016E")]
		public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE";

		[Token(Token = "0x400016F")]
		public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE";

		[Token(Token = "0x4000170")]
		public const string MeshSkewing = "VLB_MESH_SKEWING";

		[Token(Token = "0x4000171")]
		public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH";
	}
	[Token(Token = "0x2000045")]
	public static class ShaderProperties
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int ConeRadius;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ColorFlat;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int AlphaInside;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int DistanceFallOff;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int FresnelPow;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int GlareBehind;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int DrawCap;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static readonly int NoiseVelocityAndScale;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly int NoiseParam;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static readonly int CameraParams;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly int WorldToLocalMatrix;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static readonly int BlendSrcFactor;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly int BlendDstFactor;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static readonly int DynamicOcclusionClippingPlaneWS;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly int DynamicOcclusionClippingPlaneProps;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static readonly int DynamicOcclusionDepthTexture;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly int DynamicOcclusionDepthProps;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static readonly int LocalForwardDirection;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static readonly int TiltVector;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static readonly int AdditionalClippingPlaneWS;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static readonly int ParticlesTintColor;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static readonly int GlobalUsesReversedZBuffer;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static readonly int GlobalNoiseTex3D;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static readonly int GlobalNoiseCustomTime;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static readonly int GlobalDitheringFactor;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public static readonly int GlobalDitheringNoiseTex;
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B2B84", Offset = "0x9B2B84")]
	[ExecuteInEditMode]
	public class SkewingHandle : MonoBehaviour
	{
		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B2BD0", Offset = "0x9B2BD0")]
		private sealed class <CoUpdate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkewingHandle <>4__this;

			[Token(Token = "0x1700003B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000118")]
				[Address(RVA = "0x2163404", Offset = "0x2163404", VA = "0x2163404", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600011A")]
				[Address(RVA = "0x216344C", Offset = "0x216344C", VA = "0x216344C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000115")]
			[Address(RVA = "0x2163368", Offset = "0x2163368", VA = "0x2163368")]
			[DebuggerHidden]
			public <CoUpdate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000116")]
			[Address(RVA = "0x2163394", Offset = "0x2163394", VA = "0x2163394", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x2163398", Offset = "0x2163398", VA = "0x2163398", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000119")]
			[Address(RVA = "0x216340C", Offset = "0x216340C", VA = "0x216340C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VolumetricLightBeam volumetricLightBeam;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool shouldUpdateEachFrame;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x19C1B38", Offset = "0x19C1B38", VA = "0x19C1B38")]
		public bool IsAttachedToSelf()
		{
			return default(bool);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x19C1C18", Offset = "0x19C1C18", VA = "0x19C1C18")]
		public bool CanSetSkewingVector()
		{
			return default(bool);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x19C1CAC", Offset = "0x19C1CAC", VA = "0x19C1CAC")]
		public bool CanUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x19C1CF0", Offset = "0x19C1CF0", VA = "0x19C1CF0")]
		private bool ShouldUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x19C1D04", Offset = "0x19C1D04", VA = "0x19C1D04")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x19C1DA4", Offset = "0x19C1DA4", VA = "0x19C1DA4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x19C1E00", Offset = "0x19C1E00", VA = "0x19C1E00")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BCE20", Offset = "0x9BCE20")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x19C1D38", Offset = "0x19C1D38", VA = "0x19C1D38")]
		private void SetSkewingVector()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x19C1E6C", Offset = "0x19C1E6C", VA = "0x19C1E6C")]
		public SkewingHandle()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public static class TransformUtils
	{
		[Token(Token = "0x2000049")]
		public struct Packed
		{
			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lossyScale;

			[Token(Token = "0x600011C")]
			[Address(RVA = "0x2164274", Offset = "0x2164274", VA = "0x2164274")]
			public bool IsSame(Transform transf)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x19C2CF4", Offset = "0x19C2CF4", VA = "0x19C2CF4")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return default(Packed);
		}
	}
	[Token(Token = "0x200004A")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B2BF0", Offset = "0x9B2BF0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B2BF0", Offset = "0x9B2BF0")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x200004B")]
		private enum TriggerZoneUpdateRate
		{
			[Token(Token = "0x40001A6")]
			OnEnable,
			[Token(Token = "0x40001A7")]
			OnOcclusionChange
		}

		[Token(Token = "0x400019E")]
		public const string ClassName = "TriggerZone";

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x40001A1")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VolumetricLightBeam m_Beam;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PolygonCollider2D m_PolygonCollider2D;

		[Token(Token = "0x1700003D")]
		private TriggerZoneUpdateRate updateRate
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x19C2FD4", Offset = "0x19C2FD4", VA = "0x19C2FD4")]
			get
			{
				return default(TriggerZoneUpdateRate);
			}
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x19C3064", Offset = "0x19C3064", VA = "0x19C3064")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x19C37C0", Offset = "0x19C37C0", VA = "0x19C37C0")]
		private void OnOcclusionProcessed()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x19C31C8", Offset = "0x19C31C8", VA = "0x19C31C8")]
		private void ComputeZone()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x19C38A4", Offset = "0x19C38A4", VA = "0x19C38A4")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public static class Utils
	{
		[Token(Token = "0x200004D")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x40001AC")]
			High = 64,
			[Token(Token = "0x40001AD")]
			Low = 8,
			[Token(Token = "0x40001AE")]
			Undef = 0
		}

		[Token(Token = "0x40001A8")]
		private const float kEpsilon = 1E-05f;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x40001AA")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x19C527C", Offset = "0x19C527C", VA = "0x19C527C")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x6000123")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x19C52B4", Offset = "0x19C52B4", VA = "0x19C52B4")]
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
		[Address(RVA = "0x19C53EC", Offset = "0x19C53EC", VA = "0x19C53EC")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x19C54CC", Offset = "0x19C54CC", VA = "0x19C54CC")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x19C54D0", Offset = "0x19C54D0", VA = "0x19C54D0")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x19C54D8", Offset = "0x19C54D8", VA = "0x19C54D8")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x19C54E4", Offset = "0x19C54E4", VA = "0x19C54E4")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x19C54F4", Offset = "0x19C54F4", VA = "0x19C54F4")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x19C5500", Offset = "0x19C5500", VA = "0x19C5500")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x19C5508", Offset = "0x19C5508", VA = "0x19C5508")]
		public static bool Approximately(float a, float b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x19C5518", Offset = "0x19C5518", VA = "0x19C5518")]
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x19C554C", Offset = "0x19C554C", VA = "0x19C554C")]
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x19C5578", Offset = "0x19C5578", VA = "0x19C5578")]
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x19C55D4", Offset = "0x19C55D4", VA = "0x19C55D4")]
		public static Vector4 AsVector4(this Vector3 vec3, float w)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x19C5604", Offset = "0x19C5604", VA = "0x19C5604")]
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x19C56B0", Offset = "0x19C56B0", VA = "0x19C56B0")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x19C5704", Offset = "0x19C5704", VA = "0x19C5704")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x19C57A4", Offset = "0x19C57A4", VA = "0x19C57A4")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x19C57D8", Offset = "0x19C57D8", VA = "0x19C57D8")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x19C3828", Offset = "0x19C3828", VA = "0x19C3828")]
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x19C3810", Offset = "0x19C3810", VA = "0x19C3810")]
		public static bool IsAlmostZero(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x19C37C4", Offset = "0x19C37C4", VA = "0x19C37C4")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x19C5880", Offset = "0x19C5880", VA = "0x19C5880")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x19C58A4", Offset = "0x19C58A4", VA = "0x19C58A4")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x19C58B8", Offset = "0x19C58B8", VA = "0x19C58B8")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x19C5AD4", Offset = "0x19C5AD4", VA = "0x19C5AD4")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x19C5BB8", Offset = "0x19C5BB8", VA = "0x19C5BB8")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x19C59DC", Offset = "0x19C59DC", VA = "0x19C59DC")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x19C5BF8", Offset = "0x19C5BF8", VA = "0x19C5BF8")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x19C5CC4", Offset = "0x19C5CC4", VA = "0x19C5CC4")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x19C5CC8", Offset = "0x19C5CC8", VA = "0x19C5CC8")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x200004E")]
	public static class Version
	{
		[Token(Token = "0x40001AF")]
		public const int Current = 1950;
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B2C94", Offset = "0x9B2C94")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B2C94", Offset = "0x9B2C94")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x40001B0")]
		public const string ClassName = "VolumetricDustParticles";

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B41B8", Offset = "0x9B41B8")]
		public float alpha;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B41D0", Offset = "0x9B41D0")]
		public float size;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticlesDirection direction;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 velocity;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9B41F0", Offset = "0x9B41F0")]
		public float speed;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float density;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x9B4228", Offset = "0x9B4228")]
		public MinMaxRangeFloat spawnDistanceRange;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9B4240", Offset = "0x9B4240")]
		public float spawnMinDistance;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9B4278", Offset = "0x9B4278")]
		public float spawnMaxDistance;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool cullingEnabled;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float cullingMaxDistance;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B42B0", Offset = "0x9B42B0")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_AlphaAdditionalRuntime;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_Material;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Gradient m_GradientCached;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_RuntimePropertiesDirty;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x1700003E")]
		public bool isCulled
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x1E331C4", Offset = "0x1E331C4", VA = "0x1E331C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD050", Offset = "0x9BD050")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x1E331CC", Offset = "0x1E331CC", VA = "0x1E331CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD060", Offset = "0x9BD060")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public float alphaAdditionalRuntime
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x1E331D8", Offset = "0x1E331D8", VA = "0x1E331D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x1E331E0", Offset = "0x1E331E0", VA = "0x1E331E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x1E331FC", Offset = "0x1E331FC", VA = "0x1E331FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x1E33264", Offset = "0x1E33264", VA = "0x1E33264")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000042")]
		public int particlesMaxCount
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x1E332F4", Offset = "0x1E332F4", VA = "0x1E332F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000043")]
		public Camera mainCamera
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x1E3339C", Offset = "0x1E3339C", VA = "0x1E3339C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1E33620", Offset = "0x1E33620", VA = "0x1E33620")]
		private void Start()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1E33780", Offset = "0x1E33780", VA = "0x1E33780")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1E33A84", Offset = "0x1E33A84", VA = "0x1E33A84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1E33AAC", Offset = "0x1E33AAC", VA = "0x1E33AAC")]
		private void SetActive(bool active)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1E339F4", Offset = "0x1E339F4", VA = "0x1E339F4")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1E33B58", Offset = "0x1E33B58", VA = "0x1E33B58")]
		private void Play()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1E342A0", Offset = "0x1E342A0", VA = "0x1E342A0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1E342A8", Offset = "0x1E342A8", VA = "0x1E342A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1E343BC", Offset = "0x1E343BC", VA = "0x1E343BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1E33C04", Offset = "0x1E33C04", VA = "0x1E33C04")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1E336A8", Offset = "0x1E336A8", VA = "0x1E336A8")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1E344E8", Offset = "0x1E344E8", VA = "0x1E344E8")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1E34980", Offset = "0x1E34980", VA = "0x1E34980")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B2D38", Offset = "0x9B2D38")]
	[DisallowMultipleComponent]
	[SelectionBase]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000051")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		[Token(Token = "0x2000052")]
		public delegate void OnBeamGeometryInitialized();

		[Token(Token = "0x2000053")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B2DA4", Offset = "0x9B2DA4")]
		private sealed class <CoPlaytimeUpdate>d__187 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x17000074")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001C4")]
				[Address(RVA = "0x2165684", Offset = "0x2165684", VA = "0x2165684", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000075")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001C6")]
				[Address(RVA = "0x21656CC", Offset = "0x21656CC", VA = "0x21656CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x21655D0", Offset = "0x21655D0", VA = "0x21655D0")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__187(int <>1__state)
			{
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x21655FC", Offset = "0x21655FC", VA = "0x21655FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x2165600", Offset = "0x2165600", VA = "0x2165600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x216568C", Offset = "0x216568C", VA = "0x216568C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001C6")]
		public const string ClassName = "VolumetricLightBeam";

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B42D0", Offset = "0x9B42D0")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x9B42D0", Offset = "0x9B42D0")]
		public Color color;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B4324", Offset = "0x9B4324")]
		public float intensityInside;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B435C", Offset = "0x9B435C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B435C", Offset = "0x9B435C")]
		public float intensityOutside;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B43BC", Offset = "0x9B43BC")]
		public bool spotAngleFromLight;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B43F4", Offset = "0x9B43F4")]
		public float spotAngle;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B4414", Offset = "0x9B4414")]
		public float coneRadiusStart;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public ShaderAccuracy shaderAccuracy;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MeshType geomMeshType;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B444C", Offset = "0x9B444C")]
		public int geomCustomSides;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int geomCustomSegments;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 skewingLocalForwardDirection;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform clippingPlaneTransform;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool geomCap;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B4484", Offset = "0x9B4484")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B44BC", Offset = "0x9B44BC")]
		public float attenuationCustomBlending;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B44D4", Offset = "0x9B44D4")]
		public float fallOffStart;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B450C", Offset = "0x9B450C")]
		public float fallOffEnd;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float depthBlendDistance;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float cameraClippingDistance;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4544", Offset = "0x9B4544")]
		public float glareFrontal;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B455C", Offset = "0x9B455C")]
		public float glareBehind;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B4574", Offset = "0x9B4574")]
		public float fresnelPow;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public NoiseMode noiseMode;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B45AC", Offset = "0x9B45AC")]
		public float noiseIntensity;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B45C4", Offset = "0x9B45C4")]
		public float noiseScaleLocal;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Dimensions dimensions;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector2 tiltFactor;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private MaterialManager.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool m_INTERNAL_DynamicOcclusionMode_Runtime;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B4600", Offset = "0x9B4600")]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B466C", Offset = "0x9B466C")]
		private float _FadeOutBegin;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B46B8", Offset = "0x9B46B8")]
		private float _FadeOutEnd;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4704", Offset = "0x9B4704")]
		private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Light m_CachedLight;

		[Token(Token = "0x17000044")]
		public ColorMode usedColorMode
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x1E346DC", Offset = "0x1E346DC", VA = "0x1E346DC")]
			get
			{
				return default(ColorMode);
			}
		}

		[Token(Token = "0x17000045")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9BFAA8", Offset = "0x9BFAA8")]
		public float alphaInside
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x1E34A74", Offset = "0x1E34A74", VA = "0x1E34A74")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x1E34A7C", Offset = "0x1E34A7C", VA = "0x1E34A7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9BFAE0", Offset = "0x9BFAE0")]
		public float alphaOutside
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x1E34A84", Offset = "0x1E34A84", VA = "0x1E34A84")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x1E34A8C", Offset = "0x1E34A8C", VA = "0x1E34A8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x1E34A94", Offset = "0x1E34A94", VA = "0x1E34A94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x1E34A9C", Offset = "0x1E34A9C", VA = "0x1E34A9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public float coneAngle
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x1E3475C", Offset = "0x1E3475C", VA = "0x1E3475C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000049")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x1E34AD0", Offset = "0x1E34AD0", VA = "0x1E34AD0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004A")]
		public float coneVolume
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x1E34B94", Offset = "0x1E34B94", VA = "0x1E34B94")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004B")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x1E34BE8", Offset = "0x1E34BE8", VA = "0x1E34BE8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004C")]
		public int geomSides
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1E34C60", Offset = "0x1E34C60", VA = "0x1E34C60")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x1E34CE8", Offset = "0x1E34CE8", VA = "0x1E34CE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public int geomSegments
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x1E34D70", Offset = "0x1E34D70", VA = "0x1E34D70")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x1E34DF8", Offset = "0x1E34DF8", VA = "0x1E34DF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public Vector3 skewingLocalForwardDirectionNormalized
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x1E34E80", Offset = "0x1E34E80", VA = "0x1E34E80")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004F")]
		public Vector4 additionalClippingPlane
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x1E34FA4", Offset = "0x1E34FA4", VA = "0x1E34FA4")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000050")]
		public bool canHaveMeshSkewing
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x1E350D0", Offset = "0x1E350D0", VA = "0x1E350D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		public bool hasMeshSkewing
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x1E350E0", Offset = "0x1E350E0", VA = "0x1E350E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000052")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9BFB18", Offset = "0x9BFB18")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x1E351BC", Offset = "0x1E351BC", VA = "0x1E351BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x1E351C4", Offset = "0x1E351C4", VA = "0x1E351C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x1E351D0", Offset = "0x1E351D0", VA = "0x1E351D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000054")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9BFB50", Offset = "0x9BFB50")]
		public float fadeStart
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x1E351F8", Offset = "0x1E351F8", VA = "0x1E351F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x1E35200", Offset = "0x1E35200", VA = "0x1E35200")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9BFB88", Offset = "0x9BFB88")]
		public float fadeEnd
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1E35208", Offset = "0x1E35208", VA = "0x1E35208")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x1E35210", Offset = "0x1E35210", VA = "0x1E35210")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public float maxGeometryDistance
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1E34B60", Offset = "0x1E34B60", VA = "0x1E34B60")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000057")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x1E35218", Offset = "0x1E35218", VA = "0x1E35218")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9BFBC0", Offset = "0x9BFBC0")]
		public bool noiseEnabled
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x1E35228", Offset = "0x1E35228", VA = "0x1E35228")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x1E35238", Offset = "0x1E35238", VA = "0x1E35238")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public float fadeOutBegin
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x1E35254", Offset = "0x1E35254", VA = "0x1E35254")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x1E3525C", Offset = "0x1E3525C", VA = "0x1E3525C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public float fadeOutEnd
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x1E352B8", Offset = "0x1E352B8", VA = "0x1E352B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x1E352C0", Offset = "0x1E352C0", VA = "0x1E352C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x1E347C8", Offset = "0x1E347C8", VA = "0x1E347C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		public bool isTilted
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x1E352C8", Offset = "0x1E352C8", VA = "0x1E352C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x1E35370", Offset = "0x1E35370", VA = "0x1E35370")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x1E35378", Offset = "0x1E35378", VA = "0x1E35378")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public string sortingLayerName
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1E3541C", Offset = "0x1E3541C", VA = "0x1E3541C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x1E35428", Offset = "0x1E35428", VA = "0x1E35428")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public int sortingOrder
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x1E35458", Offset = "0x1E35458", VA = "0x1E35458")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x1E35460", Offset = "0x1E35460", VA = "0x1E35460")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1E35504", Offset = "0x1E35504", VA = "0x1E35504")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x1E3550C", Offset = "0x1E3550C", VA = "0x1E3550C")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x1E3556C", Offset = "0x1E3556C", VA = "0x1E3556C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000062")]
		public bool hasGeometry
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x1E347EC", Offset = "0x1E347EC", VA = "0x1E347EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000063")]
		public Bounds bounds
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x1E34858", Offset = "0x1E34858", VA = "0x1E34858")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000064")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x1E3557C", Offset = "0x1E3557C", VA = "0x1E3557C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000065")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x1E33A1C", Offset = "0x1E33A1C", VA = "0x1E33A1C")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000066")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x1E35660", Offset = "0x1E35660", VA = "0x1E35660")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000067")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x1E35678", Offset = "0x1E35678", VA = "0x1E35678")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000068")]
		public float raycastDistance
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x1E35710", Offset = "0x1E35710", VA = "0x1E35710")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000069")]
		public Vector3 raycastGlobalForward
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x1E357A0", Offset = "0x1E357A0", VA = "0x1E357A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006A")]
		public Vector3 raycastGlobalUp
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x1E35848", Offset = "0x1E35848", VA = "0x1E35848")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006B")]
		public Vector3 raycastGlobalRight
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x1E358C4", Offset = "0x1E358C4", VA = "0x1E358C4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006C")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x1E35940", Offset = "0x1E35940", VA = "0x1E35940")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x1E359C0", Offset = "0x1E359C0", VA = "0x1E359C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1E359C8", Offset = "0x1E359C8", VA = "0x1E359C8")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x1700006E")]
		public int _INTERNAL_pluginVersion
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x1E35CE4", Offset = "0x1E35CE4", VA = "0x1E35CE4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006F")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x1E35D90", Offset = "0x1E35D90", VA = "0x1E35D90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD090", Offset = "0x9BD090")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x1E35D98", Offset = "0x1E35D98", VA = "0x1E35D98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD0A0", Offset = "0x9BD0A0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public string meshStats
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x1E35DA0", Offset = "0x1E35DA0", VA = "0x1E35DA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x1E35F54", Offset = "0x1E35F54", VA = "0x1E35F54")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000072")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x1E3602C", Offset = "0x1E3602C", VA = "0x1E3602C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000073")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x1E361F4", Offset = "0x1E361F4", VA = "0x1E361F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x1E35A90", Offset = "0x1E35A90", VA = "0x1E35A90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD070", Offset = "0x9BD070")]
			add
			{
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x1E35B30", Offset = "0x1E35B30", VA = "0x1E35B30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD080", Offset = "0x9BD080")]
			remove
			{
			}
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1E34AA4", Offset = "0x1E34AA4", VA = "0x1E34AA4")]
		public void GetInsideAndOutsideIntensity(out float inside, out float outside)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1E359DC", Offset = "0x1E359DC", VA = "0x1E359DC")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1E35BD0", Offset = "0x1E35BD0", VA = "0x1E35BD0")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1E35BE4", Offset = "0x1E35BE4", VA = "0x1E35BE4")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1E35CB4", Offset = "0x1E35CB4", VA = "0x1E35CB4")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1E35264", Offset = "0x1E35264", VA = "0x1E35264")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1E35CEC", Offset = "0x1E35CEC", VA = "0x1E35CEC")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1E3611C", Offset = "0x1E3611C", VA = "0x1E3611C")]
		private Light GetLightSpotAttached()
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1E361D0", Offset = "0x1E361D0", VA = "0x1E361D0")]
		private void InitLightSpotAttachedCached()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1E361FC", Offset = "0x1E361FC", VA = "0x1E361FC")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1E3625C", Offset = "0x1E3625C", VA = "0x1E3625C")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1E36404", Offset = "0x1E36404", VA = "0x1E36404")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9BD0B0", Offset = "0x9BD0B0")]
		public void Generate()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1E36410", Offset = "0x1E36410", VA = "0x1E36410", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1E3669C", Offset = "0x1E3669C", VA = "0x1E3669C", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1E3673C", Offset = "0x1E3673C", VA = "0x1E3673C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1E3676C", Offset = "0x1E3676C", VA = "0x1E3676C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1E367F8", Offset = "0x1E367F8", VA = "0x1E367F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1E35518", Offset = "0x1E35518", VA = "0x1E35518")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1E36884", Offset = "0x1E36884", VA = "0x1E36884")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BD0E8", Offset = "0x9BD0E8")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1E368F0", Offset = "0x1E368F0", VA = "0x1E368F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1E368F4", Offset = "0x1E368F4", VA = "0x1E368F4")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1E369B0", Offset = "0x1E369B0", VA = "0x1E369B0")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1E36AAC", Offset = "0x1E36AAC", VA = "0x1E36AAC")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1E36674", Offset = "0x1E36674", VA = "0x1E36674")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1E3656C", Offset = "0x1E3656C", VA = "0x1E3656C")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1E36C3C", Offset = "0x1E36C3C", VA = "0x1E36C3C")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B2DB4", Offset = "0x9B2DB4")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1FB69C4", Offset = "0x1FB69C4", VA = "0x1FB69C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1FB6AC4", Offset = "0x1FB6AC4", VA = "0x1FB6AC4")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B2E14", Offset = "0x9B2E14")]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2087DEC", Offset = "0x2087DEC", VA = "0x2087DEC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2087EBC", Offset = "0x2087EBC", VA = "0x2087EBC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2087F80", Offset = "0x2087F80", VA = "0x2087F80")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2087F88", Offset = "0x2087F88", VA = "0x2087F88")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2088184", Offset = "0x2088184", VA = "0x2088184")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2094A64", Offset = "0x2094A64", VA = "0x2094A64")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2094B30", Offset = "0x2094B30", VA = "0x2094B30")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x17000076")]
		private bool useMouseView
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x2117B64", Offset = "0x2117B64", VA = "0x2117B64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x2117B6C", Offset = "0x2117B6C", VA = "0x2117B6C")]
			set
			{
			}
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2117BA8", Offset = "0x2117BA8", VA = "0x2117BA8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2117C40", Offset = "0x2117C40", VA = "0x2117C40")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2118154", Offset = "0x2118154", VA = "0x2118154")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4724", Offset = "0x9B4724")]
		private int CountX;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4768", Offset = "0x9B4768")]
		private int CountY;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2081ED0", Offset = "0x2081ED0", VA = "0x2081ED0")]
		public void Generate()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2082594", Offset = "0x2082594", VA = "0x2082594")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B47EC", Offset = "0x9B47EC")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x19BD4AC", Offset = "0x19BD4AC", VA = "0x19BD4AC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x19BD580", Offset = "0x19BD580", VA = "0x19BD580")]
		public Rotater()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B2ECC", Offset = "0x9B2ECC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B2ECC", Offset = "0x9B2ECC")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200005B")]
		public enum Mode
		{
			[Token(Token = "0x400021F")]
			AnimationClips,
			[Token(Token = "0x4000220")]
			AnimationStates,
			[Token(Token = "0x4000221")]
			PlayableDirector,
			[Token(Token = "0x4000222")]
			Realtime
		}

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4824", Offset = "0x9B4824")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4824", Offset = "0x9B4824")]
		public int frameRate;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B487C", Offset = "0x9B487C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B487C", Offset = "0x9B487C")]
		public float keyReductionError;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B48D4", Offset = "0x9B48D4")]
		public Mode mode;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B490C", Offset = "0x9B490C")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4944", Offset = "0x9B4944")]
		public string[] animationStates;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B497C", Offset = "0x9B497C")]
		public bool loop;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B49B4", Offset = "0x9B49B4")]
		public string saveToFolder;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B49EC", Offset = "0x9B49EC")]
		public string appendName;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4A24", Offset = "0x9B4A24")]
		public string saveName;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4A5C", Offset = "0x9B4A5C")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4A6C", Offset = "0x9B4A6C")]
		private float <bakingProgress>k__BackingField;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4AEC", Offset = "0x9B4AEC")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000077")]
		public bool isBaking
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x1FA787C", Offset = "0x1FA787C", VA = "0x1FA787C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD278", Offset = "0x9BD278")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x1FA7884", Offset = "0x1FA7884", VA = "0x1FA7884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD288", Offset = "0x9BD288")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public float bakingProgress
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x1FA7890", Offset = "0x1FA7890", VA = "0x1FA7890")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD298", Offset = "0x9BD298")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x1FA7898", Offset = "0x1FA7898", VA = "0x1FA7898")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD2A8", Offset = "0x9BD2A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000079")]
		protected float clipLength
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x1FA78A0", Offset = "0x1FA78A0", VA = "0x1FA78A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD2B8", Offset = "0x9BD2B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x1FA78A8", Offset = "0x1FA78A8", VA = "0x1FA78A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD2C8", Offset = "0x9BD2C8")]
			private set
			{
			}
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1FA775C", Offset = "0x1FA775C", VA = "0x1FA775C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD198", Offset = "0x9BD198")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1FA77A4", Offset = "0x1FA77A4", VA = "0x1FA77A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD1D0", Offset = "0x9BD1D0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1FA77EC", Offset = "0x1FA77EC", VA = "0x1FA77EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD208", Offset = "0x9BD208")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1FA7834", Offset = "0x1FA7834", VA = "0x1FA7834")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD240", Offset = "0x9BD240")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001E1")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x60001E2")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x60001E3")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x60001E4")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x60001E5")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1FA78B0", Offset = "0x1FA78B0", VA = "0x1FA78B0")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1FA78B4", Offset = "0x1FA78B4", VA = "0x1FA78B4")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1FA78B8", Offset = "0x1FA78B8", VA = "0x1FA78B8")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1FA78BC", Offset = "0x1FA78BC", VA = "0x1FA78BC")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4AFC", Offset = "0x9B4AFC")]
		public bool markAsLegacy;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4B34", Offset = "0x9B4B34")]
		public Transform root;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4B6C", Offset = "0x9B4B6C")]
		public Transform rootNode;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4BA4", Offset = "0x9B4BA4")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4BDC", Offset = "0x9B4BDC")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2118954", Offset = "0x2118954", VA = "0x2118954")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2118D44", Offset = "0x2118D44", VA = "0x2118D44", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2118D4C", Offset = "0x2118D4C", VA = "0x2118D4C", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2118E5C", Offset = "0x2118E5C", VA = "0x2118E5C", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2118ED8", Offset = "0x2118ED8", VA = "0x2118ED8", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2118F54", Offset = "0x2118F54", VA = "0x2118F54", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2118B9C", Offset = "0x2118B9C", VA = "0x2118B9C")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2118C70", Offset = "0x2118C70", VA = "0x2118C70")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2118FD0", Offset = "0x2118FD0", VA = "0x2118FD0")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class TQ
	{
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x19C2690", Offset = "0x19C2690", VA = "0x19C2690")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class AvatarUtility
	{
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1FA6B54", Offset = "0x1FA6B54", VA = "0x1FA6B54")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1FA6DB0", Offset = "0x1FA6DB0", VA = "0x1FA6DB0")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1FA6D90", Offset = "0x1FA6D90", VA = "0x1FA6D90")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1FA735C", Offset = "0x1FA735C", VA = "0x1FA735C")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public static class BakerUtilities
	{
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1FA8A54", Offset = "0x1FA8A54", VA = "0x1FA8A54")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1FAA30C", Offset = "0x1FAA30C", VA = "0x1FAA30C")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1FA84A8", Offset = "0x1FA84A8", VA = "0x1FA84A8")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1FA8A9C", Offset = "0x1FA8A9C", VA = "0x1FA8A9C")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1FA7FD8", Offset = "0x1FA7FD8", VA = "0x1FA7FD8")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1FA79A8", Offset = "0x1FA79A8", VA = "0x1FA79A8")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1FA7C14", Offset = "0x1FA7C14", VA = "0x1FA7C14")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1FA7B0C", Offset = "0x1FA7B0C", VA = "0x1FA7B0C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1FA7D90", Offset = "0x1FA7D90", VA = "0x1FA7D90")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1FA823C", Offset = "0x1FA823C", VA = "0x1FA823C")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1FA8338", Offset = "0x1FA8338", VA = "0x1FA8338")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1FA8434", Offset = "0x1FA8434", VA = "0x1FA8434")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1FA83AC", Offset = "0x1FA83AC", VA = "0x1FA83AC")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1FA86A0", Offset = "0x1FA86A0", VA = "0x1FA86A0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1FA8754", Offset = "0x1FA8754", VA = "0x1FA8754")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class BakerMuscle
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1FA8AA0", Offset = "0x1FA8AA0", VA = "0x1FA8AA0")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1FA8B10", Offset = "0x1FA8B10", VA = "0x1FA8B10")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1FA95A4", Offset = "0x1FA95A4", VA = "0x1FA95A4")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1FA9658", Offset = "0x1FA9658", VA = "0x1FA9658")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1FA9548", Offset = "0x1FA9548", VA = "0x1FA9548")]
		public void Reset()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1FA9750", Offset = "0x1FA9750", VA = "0x1FA9750")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1FA9798", Offset = "0x1FA9798", VA = "0x1FA9798")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class BakerTransform
	{
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1FA97A0", Offset = "0x1FA97A0", VA = "0x1FA97A0")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1FA992C", Offset = "0x1FA992C", VA = "0x1FA992C")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1FA9940", Offset = "0x1FA9940", VA = "0x1FA9940")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1FA9C2C", Offset = "0x1FA9C2C", VA = "0x1FA9C2C")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1FA9838", Offset = "0x1FA9838", VA = "0x1FA9838")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1FA9EE0", Offset = "0x1FA9EE0", VA = "0x1FA9EE0")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1FA9F54", Offset = "0x1FA9F54", VA = "0x1FA9F54")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1FAA108", Offset = "0x1FAA108", VA = "0x1FAA108")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4C14", Offset = "0x9B4C14")]
		public bool bakeHandIK;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4C4C", Offset = "0x9B4C4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4C4C", Offset = "0x9B4C4C")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4CA4", Offset = "0x9B4CA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4CA4", Offset = "0x9B4CA4")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2122C54", Offset = "0x2122C54", VA = "0x2122C54")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2123130", Offset = "0x2123130", VA = "0x2123130", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x212314C", Offset = "0x212314C", VA = "0x212314C", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2123228", Offset = "0x2123228", VA = "0x2123228", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2123304", Offset = "0x2123304", VA = "0x2123304", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x21234D4", Offset = "0x21234D4", VA = "0x21234D4", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x212379C", Offset = "0x212379C", VA = "0x212379C")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2123878", Offset = "0x2123878", VA = "0x2123878")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000065")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000285")]
			Update,
			[Token(Token = "0x4000286")]
			FixedUpdate,
			[Token(Token = "0x4000287")]
			LateUpdate,
			[Token(Token = "0x4000288")]
			FixedLateUpdate
		}

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B4CF8", Offset = "0x9B4CF8")]
		public bool smoothFollow;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B4D30", Offset = "0x9B4D30")]
		public float rotationSensitivity;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B4D68", Offset = "0x9B4D68")]
		public float distance;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B4DA0", Offset = "0x9B4DA0")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4DD8", Offset = "0x9B4DD8")]
		public float blockedOffset;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4DF0", Offset = "0x9B4DF0")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4E00", Offset = "0x9B4E00")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4E10", Offset = "0x9B4E10")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x1700007A")]
		public float x
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x1FB5DD4", Offset = "0x1FB5DD4", VA = "0x1FB5DD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD2D8", Offset = "0x9BD2D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x1FB5DDC", Offset = "0x1FB5DDC", VA = "0x1FB5DDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD2E8", Offset = "0x9BD2E8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public float y
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x1FB5DE4", Offset = "0x1FB5DE4", VA = "0x1FB5DE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD2F8", Offset = "0x9BD2F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x1FB5DEC", Offset = "0x1FB5DEC", VA = "0x1FB5DEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD308", Offset = "0x9BD308")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public float distanceTarget
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x1FB5DF4", Offset = "0x1FB5DF4", VA = "0x1FB5DF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD318", Offset = "0x9BD318")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x1FB5DFC", Offset = "0x1FB5DFC", VA = "0x1FB5DFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD328", Offset = "0x9BD328")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		private float zoomAdd
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x1FB6684", Offset = "0x1FB6684", VA = "0x1FB6684")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1FB5E04", Offset = "0x1FB5E04", VA = "0x1FB5E04")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1FB5E40", Offset = "0x1FB5E40", VA = "0x1FB5E40")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1FB5E48", Offset = "0x1FB5E48", VA = "0x1FB5E48", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1FB5F4C", Offset = "0x1FB5F4C", VA = "0x1FB5F4C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1FB5FA8", Offset = "0x1FB5FA8", VA = "0x1FB5FA8", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1FB6010", Offset = "0x1FB6010", VA = "0x1FB6010", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1FB6074", Offset = "0x1FB6074", VA = "0x1FB6074")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1FB5F80", Offset = "0x1FB5F80", VA = "0x1FB5F80")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1FB61F4", Offset = "0x1FB61F4", VA = "0x1FB61F4")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1FB6654", Offset = "0x1FB6654", VA = "0x1FB6654")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1FB66F4", Offset = "0x1FB66F4", VA = "0x1FB66F4")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1FB6798", Offset = "0x1FB6798", VA = "0x1FB6798")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1FB67D0", Offset = "0x1FB67D0", VA = "0x1FB67D0")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1FB6978", Offset = "0x1FB6978", VA = "0x1FB6978")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1FB69A8", Offset = "0x1FB69A8", VA = "0x1FB69A8")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public enum Axis
	{
		[Token(Token = "0x400028F")]
		X,
		[Token(Token = "0x4000290")]
		Y,
		[Token(Token = "0x4000291")]
		Z
	}
	[Token(Token = "0x2000068")]
	public class AxisTools
	{
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1FA7364", Offset = "0x1FA7364", VA = "0x1FA7364")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1FA7388", Offset = "0x1FA7388", VA = "0x1FA7388")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1FA73C0", Offset = "0x1FA73C0", VA = "0x1FA73C0")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1FA74B0", Offset = "0x1FA74B0", VA = "0x1FA74B0")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1FA7458", Offset = "0x1FA7458", VA = "0x1FA7458")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1FA7548", Offset = "0x1FA7548", VA = "0x1FA7548")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1FA7590", Offset = "0x1FA7590", VA = "0x1FA7590")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1FA7754", Offset = "0x1FA7754", VA = "0x1FA7754")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x200006A")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000241")]
			[Address(RVA = "0x1E37620", Offset = "0x1E37620", VA = "0x1E37620")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x1700007E")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x1FAF08C", Offset = "0x1FAF08C", VA = "0x1FAF08C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x1FAF2F8", Offset = "0x1FAF2F8", VA = "0x1FAF2F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1FAF040", Offset = "0x1FAF040", VA = "0x1FAF040")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200006B")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x200006C")]
		public enum BoneType
		{
			[Token(Token = "0x40002AC")]
			Unassigned,
			[Token(Token = "0x40002AD")]
			Spine,
			[Token(Token = "0x40002AE")]
			Head,
			[Token(Token = "0x40002AF")]
			Arm,
			[Token(Token = "0x40002B0")]
			Leg,
			[Token(Token = "0x40002B1")]
			Tail,
			[Token(Token = "0x40002B2")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200006D")]
		public enum BoneSide
		{
			[Token(Token = "0x40002B4")]
			Center,
			[Token(Token = "0x40002B5")]
			Left,
			[Token(Token = "0x40002B6")]
			Right
		}

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1FAF564", Offset = "0x1FAF564", VA = "0x1FAF564")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1FAF880", Offset = "0x1FAF880", VA = "0x1FAF880")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1FAFAEC", Offset = "0x1FAFAEC", VA = "0x1FAFAEC")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1FAFB6C", Offset = "0x1FAFB6C", VA = "0x1FAFB6C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1FAFC14", Offset = "0x1FAFC14", VA = "0x1FAFC14")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1FAF734", Offset = "0x1FAF734", VA = "0x1FAF734")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1FAFA50", Offset = "0x1FAFA50", VA = "0x1FAFA50")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1FB0444", Offset = "0x1FB0444", VA = "0x1FB0444")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1FB024C", Offset = "0x1FB024C", VA = "0x1FB024C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1FB0348", Offset = "0x1FB0348", VA = "0x1FB0348")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1FAFE2C", Offset = "0x1FAFE2C", VA = "0x1FAFE2C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1FAFEDC", Offset = "0x1FAFEDC", VA = "0x1FAFEDC")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1FAFF8C", Offset = "0x1FAFF8C", VA = "0x1FAFF8C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1FB003C", Offset = "0x1FB003C", VA = "0x1FB003C")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1FB00EC", Offset = "0x1FB00EC", VA = "0x1FB00EC")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1FB019C", Offset = "0x1FB019C", VA = "0x1FB019C")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1FB064C", Offset = "0x1FB064C", VA = "0x1FB064C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1FAFD44", Offset = "0x1FAFD44", VA = "0x1FAFD44")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1FB05BC", Offset = "0x1FB05BC", VA = "0x1FB05BC")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1FB06B8", Offset = "0x1FB06B8", VA = "0x1FB06B8")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1FB078C", Offset = "0x1FB078C", VA = "0x1FB078C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1FB0544", Offset = "0x1FB0544", VA = "0x1FB0544")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1FB04D0", Offset = "0x1FB04D0", VA = "0x1FB04D0")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class BipedReferences
	{
		[Token(Token = "0x200006F")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000082")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000273")]
				[Address(RVA = "0x1E376AC", Offset = "0x1E376AC", VA = "0x1E376AC")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000272")]
			[Address(RVA = "0x1E37698", Offset = "0x1E37698", VA = "0x1E37698")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000080")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x1FB27D0", Offset = "0x1FB27D0", VA = "0x1FB27D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000081")]
		public bool isEmpty
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x1FB2BB8", Offset = "0x1FB2BB8", VA = "0x1FB2BB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1FB2BC8", Offset = "0x1FB2BC8", VA = "0x1FB2BC8", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1FB2FF0", Offset = "0x1FB2FF0", VA = "0x1FB2FF0", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1FB3424", Offset = "0x1FB3424", VA = "0x1FB3424")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1FB3A10", Offset = "0x1FB3A10", VA = "0x1FB3A10")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1FB3638", Offset = "0x1FB3638", VA = "0x1FB3638")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1FAE414", Offset = "0x1FAE414", VA = "0x1FAE414")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1FB4210", Offset = "0x1FB4210", VA = "0x1FB4210")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1FB4770", Offset = "0x1FB4770", VA = "0x1FB4770")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1FB4564", Offset = "0x1FB4564", VA = "0x1FB4564")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1FB43E0", Offset = "0x1FB43E0", VA = "0x1FB43E0")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1FB42B0", Offset = "0x1FB42B0", VA = "0x1FB42B0")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1FB4670", Offset = "0x1FB4670", VA = "0x1FB4670")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1FB4868", Offset = "0x1FB4868", VA = "0x1FB4868")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1FB538C", Offset = "0x1FB538C", VA = "0x1FB538C")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1FB4E14", Offset = "0x1FB4E14", VA = "0x1FB4E14")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1FB5634", Offset = "0x1FB5634", VA = "0x1FB5634")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1FB5180", Offset = "0x1FB5180", VA = "0x1FB5180")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1FB563C", Offset = "0x1FB563C", VA = "0x1FB563C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1FB5644", Offset = "0x1FB5644", VA = "0x1FB5644")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1FB580C", Offset = "0x1FB580C", VA = "0x1FB580C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1FB59C8", Offset = "0x1FB59C8", VA = "0x1FB59C8")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1FAE870", Offset = "0x1FAE870", VA = "0x1FAE870")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x208818C", Offset = "0x208818C", VA = "0x208818C")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x20897A4", Offset = "0x20897A4", VA = "0x20897A4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x20898EC", Offset = "0x20898EC", VA = "0x20898EC")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class Hierarchy
	{
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2120B38", Offset = "0x2120B38", VA = "0x2120B38")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2120D24", Offset = "0x2120D24", VA = "0x2120D24")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2120BD0", Offset = "0x2120BD0", VA = "0x2120BD0")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2120E44", Offset = "0x2120E44", VA = "0x2120E44")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2120F70", Offset = "0x2120F70", VA = "0x2120F70")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x21211BC", Offset = "0x21211BC", VA = "0x21211BC")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x21212C4", Offset = "0x21212C4", VA = "0x21212C4")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2121438", Offset = "0x2121438", VA = "0x2121438")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2121814", Offset = "0x2121814", VA = "0x2121814")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x21215D8", Offset = "0x21215D8", VA = "0x21215D8")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x21219C8", Offset = "0x21219C8", VA = "0x21219C8")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2078350", Offset = "0x2078350", VA = "0x2078350")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x20783BC", Offset = "0x20783BC", VA = "0x20783BC")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40002D0")]
		None,
		[Token(Token = "0x40002D1")]
		InOutCubic,
		[Token(Token = "0x40002D2")]
		InOutQuintic,
		[Token(Token = "0x40002D3")]
		InOutSine,
		[Token(Token = "0x40002D4")]
		InQuintic,
		[Token(Token = "0x40002D5")]
		InQuartic,
		[Token(Token = "0x40002D6")]
		InCubic,
		[Token(Token = "0x40002D7")]
		InQuadratic,
		[Token(Token = "0x40002D8")]
		InElastic,
		[Token(Token = "0x40002D9")]
		InElasticSmall,
		[Token(Token = "0x40002DA")]
		InElasticBig,
		[Token(Token = "0x40002DB")]
		InSine,
		[Token(Token = "0x40002DC")]
		InBack,
		[Token(Token = "0x40002DD")]
		OutQuintic,
		[Token(Token = "0x40002DE")]
		OutQuartic,
		[Token(Token = "0x40002DF")]
		OutCubic,
		[Token(Token = "0x40002E0")]
		OutInCubic,
		[Token(Token = "0x40002E1")]
		OutInQuartic,
		[Token(Token = "0x40002E2")]
		OutElastic,
		[Token(Token = "0x40002E3")]
		OutElasticSmall,
		[Token(Token = "0x40002E4")]
		OutElasticBig,
		[Token(Token = "0x40002E5")]
		OutSine,
		[Token(Token = "0x40002E6")]
		OutBack,
		[Token(Token = "0x40002E7")]
		OutBackCubic,
		[Token(Token = "0x40002E8")]
		OutBackQuartic,
		[Token(Token = "0x40002E9")]
		BackInCubic,
		[Token(Token = "0x40002EA")]
		BackInQuartic
	}
	[Token(Token = "0x2000075")]
	public class Interp
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x207BADC", Offset = "0x207BADC", VA = "0x207BADC")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2081488", Offset = "0x2081488", VA = "0x2081488")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x20814FC", Offset = "0x20814FC", VA = "0x20814FC")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2080EF0", Offset = "0x2080EF0", VA = "0x2080EF0")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2080EFC", Offset = "0x2080EFC", VA = "0x2080EFC")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2080F20", Offset = "0x2080F20", VA = "0x2080F20")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2080F5C", Offset = "0x2080F5C", VA = "0x2080F5C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2080F74", Offset = "0x2080F74", VA = "0x2080F74")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2080F88", Offset = "0x2080F88", VA = "0x2080F88")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x2080F9C", Offset = "0x2080F9C", VA = "0x2080F9C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2080FAC", Offset = "0x2080FAC", VA = "0x2080FAC")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2080FF4", Offset = "0x2080FF4", VA = "0x2080FF4")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x208102C", Offset = "0x208102C", VA = "0x208102C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2081054", Offset = "0x2081054", VA = "0x2081054")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2081588", Offset = "0x2081588", VA = "0x2081588")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x2081088", Offset = "0x2081088", VA = "0x2081088")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x20810B0", Offset = "0x20810B0", VA = "0x20810B0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x20810E0", Offset = "0x20810E0", VA = "0x20810E0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2081114", Offset = "0x2081114", VA = "0x2081114")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2081158", Offset = "0x2081158", VA = "0x2081158")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x20811BC", Offset = "0x20811BC", VA = "0x20811BC")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2081220", Offset = "0x2081220", VA = "0x2081220")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2081274", Offset = "0x2081274", VA = "0x2081274")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x20812C8", Offset = "0x20812C8", VA = "0x20812C8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2081304", Offset = "0x2081304", VA = "0x2081304")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x208133C", Offset = "0x208133C", VA = "0x208133C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x20815BC", Offset = "0x20815BC", VA = "0x20815BC")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x2081384", Offset = "0x2081384", VA = "0x2081384")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2081418", Offset = "0x2081418", VA = "0x2081418")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2081448", Offset = "0x2081448", VA = "0x2081448")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2081650", Offset = "0x2081650", VA = "0x2081650")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x208170C", Offset = "0x208170C", VA = "0x208170C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2081778", Offset = "0x2081778", VA = "0x2081778")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000077")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x20817E4", Offset = "0x20817E4", VA = "0x20817E4")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x208183C", Offset = "0x208183C", VA = "0x208183C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2081908", Offset = "0x2081908", VA = "0x2081908")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2081854", Offset = "0x2081854", VA = "0x2081854")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2081920", Offset = "0x2081920", VA = "0x2081920")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x20819C4", Offset = "0x20819C4", VA = "0x20819C4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x20819F0", Offset = "0x20819F0", VA = "0x20819F0")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2081A40", Offset = "0x2081A40", VA = "0x2081A40")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2081AAC", Offset = "0x2081AAC", VA = "0x2081AAC")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2081BC0", Offset = "0x2081BC0", VA = "0x2081BC0")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2081CB8", Offset = "0x2081CB8", VA = "0x2081CB8")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2081D14", Offset = "0x2081D14", VA = "0x2081D14")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000078")]
	public static class QuaTools
	{
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x19BA89C", Offset = "0x19BA89C", VA = "0x19BA89C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x19BA8EC", Offset = "0x19BA8EC", VA = "0x19BA8EC")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x19BA93C", Offset = "0x19BA93C", VA = "0x19BA93C")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x19BA9E4", Offset = "0x19BA9E4", VA = "0x19BA9E4")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x19BAA8C", Offset = "0x19BAA8C", VA = "0x19BAA8C")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x19BAB6C", Offset = "0x19BAB6C", VA = "0x19BAB6C")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x19BABC0", Offset = "0x19BABC0", VA = "0x19BABC0")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x19BA00C", Offset = "0x19BA00C", VA = "0x19BA00C")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x19BAC94", Offset = "0x19BAC94", VA = "0x19BAC94")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x19BAE24", Offset = "0x19BAE24", VA = "0x19BAE24")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x19BAF18", Offset = "0x19BAF18", VA = "0x19BAF18")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x19BB024", Offset = "0x19BB024", VA = "0x19BB024")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x19BB110", Offset = "0x19BB110", VA = "0x19BB110")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000079")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000083")]
		public static T instance
		{
			[Token(Token = "0x60002BE")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BF")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002C0")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4E30", Offset = "0x9B4E30")]
		public bool fixTransforms;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000084")]
		private bool animatePhysics
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x19C21CC", Offset = "0x19C21CC", VA = "0x19C21CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		private bool isAnimated
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x19C24D8", Offset = "0x19C24D8", VA = "0x19C24D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x19C208C", Offset = "0x19C208C", VA = "0x19C208C")]
		public void Disable()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x19C212C", Offset = "0x19C212C", VA = "0x19C212C", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x19C2130", Offset = "0x19C2130", VA = "0x19C2130", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x19C2134", Offset = "0x19C2134", VA = "0x19C2134", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x19C2138", Offset = "0x19C2138", VA = "0x19C2138")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x19C21C8", Offset = "0x19C21C8", VA = "0x19C21C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x19C2170", Offset = "0x19C2170", VA = "0x19C2170")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x19C248C", Offset = "0x19C248C", VA = "0x19C248C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x19C22B8", Offset = "0x19C22B8", VA = "0x19C22B8")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x19C2590", Offset = "0x19C2590", VA = "0x19C2590")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x19C25EC", Offset = "0x19C25EC", VA = "0x19C25EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x19C2648", Offset = "0x19C2648", VA = "0x19C2648")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x19BA88C", Offset = "0x19BA88C", VA = "0x19BA88C")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x19C2D8C", Offset = "0x19C2D8C", VA = "0x19C2D8C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x19C2E4C", Offset = "0x19C2E4C", VA = "0x19C2E4C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x19C2F0C", Offset = "0x19C2F0C", VA = "0x19C2F0C")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x19C2FCC", Offset = "0x19C2FCC", VA = "0x19C2FCC")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public static class V3Tools
	{
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x19C5CD0", Offset = "0x19C5CD0", VA = "0x19C5CD0")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x19C5D70", Offset = "0x19C5D70", VA = "0x19C5D70")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x19C5DAC", Offset = "0x19C5DAC", VA = "0x19C5DAC")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x19C5DF0", Offset = "0x19C5DF0", VA = "0x19C5DF0")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x19C5E8C", Offset = "0x19C5E8C", VA = "0x19C5E8C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x19C5FE8", Offset = "0x19C5FE8", VA = "0x19C5FE8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x19C6164", Offset = "0x19C6164", VA = "0x19C6164")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x19C62E8", Offset = "0x19C62E8", VA = "0x19C62E8")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x19C63A4", Offset = "0x19C63A4", VA = "0x19C63A4")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x19C64A4", Offset = "0x19C64A4", VA = "0x19C64A4")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x19C652C", Offset = "0x19C652C", VA = "0x19C652C")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200007D")]
	public static class Warning
	{
		[Token(Token = "0x200007E")]
		public delegate void Logger(string message);

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1E36D6C", Offset = "0x1E36D6C", VA = "0x1E36D6C")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1E36E04", Offset = "0x1E36E04", VA = "0x1E36E04")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B2F3C", Offset = "0x9B2F3C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B2F3C", Offset = "0x9B2F3C")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1FADAF4", Offset = "0x1FADAF4", VA = "0x1FADAF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD3A8", Offset = "0x9BD3A8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1FADB3C", Offset = "0x1FADB3C", VA = "0x1FADB3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD3E0", Offset = "0x9BD3E0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1FADB84", Offset = "0x1FADB84", VA = "0x1FADB84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD418", Offset = "0x9BD418")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1FADBCC", Offset = "0x1FADBCC", VA = "0x1FADBCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD450", Offset = "0x9BD450")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1FADC14", Offset = "0x1FADC14", VA = "0x1FADC14")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1FADCB0", Offset = "0x1FADCB0", VA = "0x1FADCB0")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1FADCD0", Offset = "0x1FADCD0", VA = "0x1FADCD0")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1FADD00", Offset = "0x1FADD00", VA = "0x1FADD00")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1FADD30", Offset = "0x1FADD30", VA = "0x1FADD30")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1FADD70", Offset = "0x1FADD70", VA = "0x1FADD70")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1FADDB4", Offset = "0x1FADDB4", VA = "0x1FADDB4")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1FADDD8", Offset = "0x1FADDD8", VA = "0x1FADDD8")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1FADDFC", Offset = "0x1FADDFC", VA = "0x1FADDFC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1FADE24", Offset = "0x1FADE24", VA = "0x1FADE24")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1FADE50", Offset = "0x1FADE50", VA = "0x1FADE50")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1FADE7C", Offset = "0x1FADE7C", VA = "0x1FADE7C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1FADC34", Offset = "0x1FADC34", VA = "0x1FADC34")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1FADEA4", Offset = "0x1FADEA4", VA = "0x1FADEA4")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1FADEB0", Offset = "0x1FADEB0", VA = "0x1FADEB0")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1FADEBC", Offset = "0x1FADEBC", VA = "0x1FADEBC")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1FAE1A0", Offset = "0x1FAE1A0", VA = "0x1FAE1A0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1FAE248", Offset = "0x1FAE248", VA = "0x1FAE248", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1FAE628", Offset = "0x1FAE628", VA = "0x1FAE628", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1FAE7B4", Offset = "0x1FAE7B4", VA = "0x1FAE7B4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1FAE7E8", Offset = "0x1FAE7E8", VA = "0x1FAE7E8")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000086")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x1FAE05C", Offset = "0x1FAE05C", VA = "0x1FAE05C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x1FAEA50", Offset = "0x1FAEA50", VA = "0x1FAEA50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1FAE504", Offset = "0x1FAE504", VA = "0x1FAE504")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1FAE8DC", Offset = "0x1FAE8DC", VA = "0x1FAE8DC")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000088")]
		public bool isValid
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x2088F20", Offset = "0x2088F20", VA = "0x2088F20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000304")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x2088F8C", Offset = "0x2088F8C", VA = "0x2088F8C")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x2088F94", Offset = "0x2088F94", VA = "0x2088F94", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x2089054", Offset = "0x2089054", VA = "0x2089054")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x208905C", Offset = "0x208905C", VA = "0x208905C")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000089")]
		private bool positionChanged
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x2089190", Offset = "0x2089190", VA = "0x2089190")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x2089088", Offset = "0x2089088", VA = "0x2089088", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x20891CC", Offset = "0x20891CC", VA = "0x20891CC")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x20891D4", Offset = "0x20891D4", VA = "0x20891D4")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x2089200", Offset = "0x2089200", VA = "0x2089200", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x2089280", Offset = "0x2089280", VA = "0x2089280")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x2089288", Offset = "0x2089288", VA = "0x2089288")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700008A")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x20893BC", Offset = "0x20893BC", VA = "0x20893BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x20892B4", Offset = "0x20892B4", VA = "0x20892B4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x20893F8", Offset = "0x20893F8", VA = "0x20893F8")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x2089400", Offset = "0x2089400", VA = "0x2089400")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public class Constraints
	{
		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4E68", Offset = "0x9B4E68")]
		public float positionWeight;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4E80", Offset = "0x9B4E80")]
		public float rotationWeight;

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x208942C", Offset = "0x208942C", VA = "0x208942C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x2089498", Offset = "0x2089498", VA = "0x2089498")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x20894EC", Offset = "0x20894EC", VA = "0x20894EC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x208979C", Offset = "0x208979C", VA = "0x208979C")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000088")]
		public enum DOF
		{
			[Token(Token = "0x400032A")]
			One,
			[Token(Token = "0x400032B")]
			Three
		}

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4E98", Offset = "0x9B4E98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4E98", Offset = "0x9B4E98")]
		public float weight;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4EEC", Offset = "0x9B4EEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B4EEC", Offset = "0x9B4EEC")]
		public float rotationWeight;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4F40", Offset = "0x9B4F40")]
		public DOF rotationDOF;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4F78", Offset = "0x9B4F78")]
		public bool fixBone1Twist;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4FB0", Offset = "0x9B4FB0")]
		public Transform bone1;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B4FE8", Offset = "0x9B4FE8")]
		public Transform bone2;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5020", Offset = "0x9B5020")]
		public Transform bone3;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5058", Offset = "0x9B5058")]
		public Transform tip;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5090", Offset = "0x9B5090")]
		public Transform target;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B50C8", Offset = "0x9B50C8")]
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

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x1700008B")]
		public bool initiated
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x2094B38", Offset = "0x2094B38", VA = "0x2094B38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD488", Offset = "0x9BD488")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x2094B40", Offset = "0x2094B40", VA = "0x2094B40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD498", Offset = "0x9BD498")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x2094B4C", Offset = "0x2094B4C", VA = "0x2094B4C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x2094B6C", Offset = "0x2094B6C", VA = "0x2094B6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x2094B8C", Offset = "0x2094B8C", VA = "0x2094B8C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x2094BAC", Offset = "0x2094BAC", VA = "0x2094BAC")]
			set
			{
			}
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2094BCC", Offset = "0x2094BCC", VA = "0x2094BCC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x2094CD4", Offset = "0x2094CD4", VA = "0x2094CD4")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x2095178", Offset = "0x2095178", VA = "0x2095178")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x2095250", Offset = "0x2095250", VA = "0x2095250")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x2095314", Offset = "0x2095314", VA = "0x2095314")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x209585C", Offset = "0x209585C", VA = "0x209585C")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B50D8", Offset = "0x9B50D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B50D8", Offset = "0x9B50D8")]
		public float weight;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B512C", Offset = "0x9B512C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700008E")]
		public bool initiated
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x2117204", Offset = "0x2117204", VA = "0x2117204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD4A8", Offset = "0x9BD4A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x211720C", Offset = "0x211720C", VA = "0x211720C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD4B8", Offset = "0x9BD4B8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x2117218", Offset = "0x2117218", VA = "0x2117218")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x21172A4", Offset = "0x21172A4", VA = "0x21172A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD4C8", Offset = "0x9BD4C8")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x21175D4", Offset = "0x21175D4", VA = "0x21175D4")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x2117750", Offset = "0x2117750", VA = "0x2117750")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x21174D8", Offset = "0x21174D8", VA = "0x21174D8")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x21178C0", Offset = "0x21178C0", VA = "0x21178C0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2117988", Offset = "0x2117988", VA = "0x2117988")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x2117A04", Offset = "0x2117A04", VA = "0x2117A04")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x2117A7C", Offset = "0x2117A7C", VA = "0x2117A7C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x2117AE8", Offset = "0x2117AE8", VA = "0x2117AE8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x2117AEC", Offset = "0x2117AEC", VA = "0x2117AEC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x2117B00", Offset = "0x2117B00", VA = "0x2117B00")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200008B")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B513C", Offset = "0x9B513C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B513C", Offset = "0x9B513C")]
		public float weight;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5190", Offset = "0x9B5190")]
		public Grounding solver;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B51C8", Offset = "0x9B51C8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700008F")]
		public bool initiated
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x2119874", Offset = "0x2119874", VA = "0x2119874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD500", Offset = "0x9BD500")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x211987C", Offset = "0x211987C", VA = "0x211987C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD510", Offset = "0x9BD510")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000332")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x2119888", Offset = "0x2119888", VA = "0x2119888")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x2119A34", Offset = "0x2119A34", VA = "0x2119A34")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x2119934", Offset = "0x2119934", VA = "0x2119934")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x2119A68", Offset = "0x2119A68", VA = "0x2119A68")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000339")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600033A")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2119BA4", Offset = "0x2119BA4", VA = "0x2119BA4")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B2F9C", Offset = "0x9B2F9C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B2F9C", Offset = "0x9B2F9C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B51D8", Offset = "0x9B51D8")]
		public BipedIK ik;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5210", Offset = "0x9B5210")]
		public float spineBend;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5248", Offset = "0x9B5248")]
		public float spineSpeed;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x2119CB4", Offset = "0x2119CB4", VA = "0x2119CB4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD520", Offset = "0x9BD520")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x2119CFC", Offset = "0x2119CFC", VA = "0x2119CFC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD558", Offset = "0x9BD558")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x2119D44", Offset = "0x2119D44", VA = "0x2119D44", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x2119E0C", Offset = "0x2119E0C", VA = "0x2119E0C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2119EB8", Offset = "0x2119EB8", VA = "0x2119EB8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x2119F18", Offset = "0x2119F18", VA = "0x2119F18")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x211A460", Offset = "0x211A460", VA = "0x211A460")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x211A4B4", Offset = "0x211A4B4", VA = "0x211A4B4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x211AAF0", Offset = "0x211AAF0", VA = "0x211AAF0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x211AC08", Offset = "0x211AC08", VA = "0x211AC08")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x211AD48", Offset = "0x211AD48", VA = "0x211AD48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x211AED8", Offset = "0x211AED8", VA = "0x211AED8")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B2FFC", Offset = "0x9B2FFC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B2FFC", Offset = "0x9B2FFC")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200008E")]
		public class SpineEffector
		{
			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5328", Offset = "0x9B5328")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5360", Offset = "0x9B5360")]
			public float horizontalWeight;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5398", Offset = "0x9B5398")]
			public float verticalWeight;

			[Token(Token = "0x600035A")]
			[Address(RVA = "0x1E38FDC", Offset = "0x1E38FDC", VA = "0x1E38FDC")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0x1E38FEC", Offset = "0x1E38FEC", VA = "0x1E38FEC")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5280", Offset = "0x9B5280")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B52B8", Offset = "0x9B52B8")]
		public float spineBend;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B52F0", Offset = "0x9B52F0")]
		public float spineSpeed;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x211B310", Offset = "0x211B310", VA = "0x211B310")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD590", Offset = "0x9BD590")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x211B358", Offset = "0x211B358", VA = "0x211B358", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD5C8", Offset = "0x9BD5C8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x211B3A0", Offset = "0x211B3A0", VA = "0x211B3A0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD600", Offset = "0x9BD600")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x211B3E8", Offset = "0x211B3E8", VA = "0x211B3E8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x211B424", Offset = "0x211B424", VA = "0x211B424")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x211B4B8", Offset = "0x211B4B8", VA = "0x211B4B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x211B734", Offset = "0x211B734", VA = "0x211B734")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x211B740", Offset = "0x211B740", VA = "0x211B740")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x211B520", Offset = "0x211B520", VA = "0x211B520")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x211B74C", Offset = "0x211B74C", VA = "0x211B74C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x211BA68", Offset = "0x211BA68", VA = "0x211BA68")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x211BB78", Offset = "0x211BB78", VA = "0x211BB78")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x211BCD0", Offset = "0x211BCD0", VA = "0x211BCD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x211BDE4", Offset = "0x211BDE4", VA = "0x211BDE4")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B305C", Offset = "0x9B305C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B305C", Offset = "0x9B305C")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B53D0", Offset = "0x9B53D0")]
		public Transform pelvis;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5408", Offset = "0x9B5408")]
		public Transform characterRoot;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5440", Offset = "0x9B5440")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5440", Offset = "0x9B5440")]
		public float rootRotationWeight;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5494", Offset = "0x9B5494")]
		public float rootRotationSpeed;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B54CC", Offset = "0x9B54CC")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x211BE6C", Offset = "0x211BE6C", VA = "0x211BE6C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD638", Offset = "0x9BD638")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x211BEB4", Offset = "0x211BEB4", VA = "0x211BEB4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD670", Offset = "0x9BD670")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x211BEFC", Offset = "0x211BEFC", VA = "0x211BEFC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x211BF14", Offset = "0x211BF14", VA = "0x211BF14")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x211C148", Offset = "0x211C148", VA = "0x211C148")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x211C244", Offset = "0x211C244", VA = "0x211C244")]
		private void Update()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x211C7EC", Offset = "0x211C7EC", VA = "0x211C7EC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x211CBF4", Offset = "0x211CBF4", VA = "0x211CBF4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x211CD80", Offset = "0x211CD80", VA = "0x211CD80")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x211D084", Offset = "0x211D084", VA = "0x211D084")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x211D1D0", Offset = "0x211D1D0", VA = "0x211D1D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x211D3B8", Offset = "0x211D3B8", VA = "0x211D3B8")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B30BC", Offset = "0x9B30BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B30BC", Offset = "0x9B30BC")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000091")]
		public struct Foot
		{
			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x600037A")]
			[Address(RVA = "0x1E39034", Offset = "0x1E39034", VA = "0x1E39034")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5504", Offset = "0x9B5504")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B553C", Offset = "0x9B553C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B553C", Offset = "0x9B553C")]
		public float rootRotationWeight;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5590", Offset = "0x9B5590")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5590", Offset = "0x9B5590")]
		public float minRootRotation;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B55E8", Offset = "0x9B55E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B55E8", Offset = "0x9B55E8")]
		public float maxRootRotation;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5640", Offset = "0x9B5640")]
		public float rootRotationSpeed;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5678", Offset = "0x9B5678")]
		public float maxLegOffset;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B56B0", Offset = "0x9B56B0")]
		public float maxForeLegOffset;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B56E8", Offset = "0x9B56E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B56E8", Offset = "0x9B56E8")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B573C", Offset = "0x9B573C")]
		public Transform characterRoot;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5774", Offset = "0x9B5774")]
		public Transform pelvis;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B57AC", Offset = "0x9B57AC")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B57E4", Offset = "0x9B57E4")]
		public Transform head;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x211D440", Offset = "0x211D440", VA = "0x211D440", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD6A8", Offset = "0x9BD6A8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x211D488", Offset = "0x211D488", VA = "0x211D488", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD6E0", Offset = "0x9BD6E0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x211D4D0", Offset = "0x211D4D0", VA = "0x211D4D0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x211D504", Offset = "0x211D504", VA = "0x211D504")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x211D630", Offset = "0x211D630", VA = "0x211D630")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x211D834", Offset = "0x211D834", VA = "0x211D834")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x211D89C", Offset = "0x211D89C", VA = "0x211D89C")]
		private void Update()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x211D900", Offset = "0x211D900", VA = "0x211D900")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x211DC2C", Offset = "0x211DC2C", VA = "0x211DC2C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x211DF70", Offset = "0x211DF70", VA = "0x211DF70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x211E068", Offset = "0x211E068", VA = "0x211E068")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x211E434", Offset = "0x211E434", VA = "0x211E434")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x211EA50", Offset = "0x211EA50", VA = "0x211EA50")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x211EC20", Offset = "0x211EC20", VA = "0x211EC20")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x211ECFC", Offset = "0x211ECFC", VA = "0x211ECFC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x211EF44", Offset = "0x211EF44", VA = "0x211EF44")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x211EF7C", Offset = "0x211EF7C", VA = "0x211EF7C")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x211F15C", Offset = "0x211F15C", VA = "0x211F15C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B311C", Offset = "0x9B311C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B311C", Offset = "0x9B311C")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B582C", Offset = "0x9B582C")]
		public VRIK ik;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x211F25C", Offset = "0x211F25C", VA = "0x211F25C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD718", Offset = "0x9BD718")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x211F2A4", Offset = "0x211F2A4", VA = "0x211F2A4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD750", Offset = "0x9BD750")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x211F2EC", Offset = "0x211F2EC", VA = "0x211F2EC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD788", Offset = "0x9BD788")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x211F334", Offset = "0x211F334", VA = "0x211F334", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x211F34C", Offset = "0x211F34C", VA = "0x211F34C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x211F3E0", Offset = "0x211F3E0", VA = "0x211F3E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x211F440", Offset = "0x211F440", VA = "0x211F440")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x211F660", Offset = "0x211F660", VA = "0x211F660")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x211F850", Offset = "0x211F850", VA = "0x211F850")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x211F8E0", Offset = "0x211F8E0", VA = "0x211F8E0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x211FA9C", Offset = "0x211FA9C", VA = "0x211FA9C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x211FBF4", Offset = "0x211FBF4", VA = "0x211FBF4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x211FD74", Offset = "0x211FD74", VA = "0x211FD74")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000094")]
		public enum Quality
		{
			[Token(Token = "0x4000391")]
			Fastest,
			[Token(Token = "0x4000392")]
			Simple,
			[Token(Token = "0x4000393")]
			Best
		}

		[Token(Token = "0x2000095")]
		public class Leg
		{
			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5D10", Offset = "0x9B5D10")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5D20", Offset = "0x9B5D20")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5D30", Offset = "0x9B5D30")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5D40", Offset = "0x9B5D40")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5D50", Offset = "0x9B5D50")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5D60", Offset = "0x9B5D60")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5D70", Offset = "0x9B5D70")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5D80", Offset = "0x9B5D80")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5D90", Offset = "0x9B5D90")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000098")]
			public bool isGrounded
			{
				[Token(Token = "0x60003A0")]
				[Address(RVA = "0x1E39074", Offset = "0x1E39074", VA = "0x1E39074")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD860", Offset = "0x9BD860")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003A1")]
				[Address(RVA = "0x1E3907C", Offset = "0x1E3907C", VA = "0x1E3907C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD870", Offset = "0x9BD870")]
				private set
				{
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60003A2")]
				[Address(RVA = "0x1E39088", Offset = "0x1E39088", VA = "0x1E39088")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD880", Offset = "0x9BD880")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60003A3")]
				[Address(RVA = "0x1E39094", Offset = "0x1E39094", VA = "0x1E39094")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD890", Offset = "0x9BD890")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009A")]
			public bool initiated
			{
				[Token(Token = "0x60003A4")]
				[Address(RVA = "0x1E390A0", Offset = "0x1E390A0", VA = "0x1E390A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD8A0", Offset = "0x9BD8A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003A5")]
				[Address(RVA = "0x1E390A8", Offset = "0x1E390A8", VA = "0x1E390A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD8B0", Offset = "0x9BD8B0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			public float heightFromGround
			{
				[Token(Token = "0x60003A6")]
				[Address(RVA = "0x1E390B4", Offset = "0x1E390B4", VA = "0x1E390B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD8C0", Offset = "0x9BD8C0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60003A7")]
				[Address(RVA = "0x1E390BC", Offset = "0x1E390BC", VA = "0x1E390BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD8D0", Offset = "0x9BD8D0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009C")]
			public Vector3 velocity
			{
				[Token(Token = "0x60003A8")]
				[Address(RVA = "0x1E390C4", Offset = "0x1E390C4", VA = "0x1E390C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD8E0", Offset = "0x9BD8E0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60003A9")]
				[Address(RVA = "0x1E390D0", Offset = "0x1E390D0", VA = "0x1E390D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD8F0", Offset = "0x9BD8F0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009D")]
			public Transform transform
			{
				[Token(Token = "0x60003AA")]
				[Address(RVA = "0x1E390DC", Offset = "0x1E390DC", VA = "0x1E390DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD900", Offset = "0x9BD900")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003AB")]
				[Address(RVA = "0x1E390E4", Offset = "0x1E390E4", VA = "0x1E390E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD910", Offset = "0x9BD910")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009E")]
			public float IKOffset
			{
				[Token(Token = "0x60003AC")]
				[Address(RVA = "0x1E390EC", Offset = "0x1E390EC", VA = "0x1E390EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD920", Offset = "0x9BD920")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60003AD")]
				[Address(RVA = "0x1E390F4", Offset = "0x1E390F4", VA = "0x1E390F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD930", Offset = "0x9BD930")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60003AE")]
				[Address(RVA = "0x1E390FC", Offset = "0x1E390FC", VA = "0x1E390FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD940", Offset = "0x9BD940")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60003AF")]
				[Address(RVA = "0x1E39114", Offset = "0x1E39114", VA = "0x1E39114")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD950", Offset = "0x9BD950")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A0")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60003B0")]
				[Address(RVA = "0x1E39134", Offset = "0x1E39134", VA = "0x1E39134")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD960", Offset = "0x9BD960")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60003B1")]
				[Address(RVA = "0x1E3914C", Offset = "0x1E3914C", VA = "0x1E3914C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD970", Offset = "0x9BD970")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A1")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60003B2")]
				[Address(RVA = "0x1E3916C", Offset = "0x1E3916C", VA = "0x1E3916C")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x170000A2")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60003B8")]
				[Address(RVA = "0x1E3A168", Offset = "0x1E3A168", VA = "0x1E3A168")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000A3")]
			private float rootYOffset
			{
				[Token(Token = "0x60003C1")]
				[Address(RVA = "0x1E3A2CC", Offset = "0x1E3A2CC", VA = "0x1E3A2CC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x1E391B4", Offset = "0x1E391B4", VA = "0x1E391B4")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1E391C8", Offset = "0x1E391C8", VA = "0x1E391C8")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x1E3923C", Offset = "0x1E3923C", VA = "0x1E3923C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x1E39288", Offset = "0x1E39288", VA = "0x1E39288")]
			public void Reset()
			{
			}

			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x1E392F8", Offset = "0x1E392F8", VA = "0x1E392F8")]
			public void Process()
			{
			}

			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x1E39DE0", Offset = "0x1E39DE0", VA = "0x1E39DE0")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x1E39980", Offset = "0x1E39980", VA = "0x1E39980")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1E3A1FC", Offset = "0x1E3A1FC", VA = "0x1E3A1FC")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1E39C1C", Offset = "0x1E39C1C", VA = "0x1E39C1C")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x1E39CA8", Offset = "0x1E39CA8", VA = "0x1E39CA8")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1E3A26C", Offset = "0x1E3A26C", VA = "0x1E3A26C")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1E3A190", Offset = "0x1E3A190", VA = "0x1E3A190")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x1E3A360", Offset = "0x1E3A360", VA = "0x1E3A360")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x1E3A3EC", Offset = "0x1E3A3EC", VA = "0x1E3A3EC")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000096")]
		public class Pelvis
		{
			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5DA0", Offset = "0x9B5DA0")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5DB0", Offset = "0x9B5DB0")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000A4")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60003C3")]
				[Address(RVA = "0x1E3A430", Offset = "0x1E3A430", VA = "0x1E3A430")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD980", Offset = "0x9BD980")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60003C4")]
				[Address(RVA = "0x1E3A43C", Offset = "0x1E3A43C", VA = "0x1E3A43C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD990", Offset = "0x9BD990")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			public float heightOffset
			{
				[Token(Token = "0x60003C5")]
				[Address(RVA = "0x1E3A448", Offset = "0x1E3A448", VA = "0x1E3A448")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD9A0", Offset = "0x9BD9A0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60003C6")]
				[Address(RVA = "0x1E3A450", Offset = "0x1E3A450", VA = "0x1E3A450")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD9B0", Offset = "0x9BD9B0")]
				private set
				{
				}
			}

			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x1E3A458", Offset = "0x1E3A458", VA = "0x1E3A458")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x1E3A4C8", Offset = "0x1E3A4C8", VA = "0x1E3A4C8")]
			public void Reset()
			{
			}

			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x1E3A468", Offset = "0x1E3A468", VA = "0x1E3A468")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x1E3A534", Offset = "0x1E3A534", VA = "0x1E3A534")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x1E3A6D4", Offset = "0x1E3A6D4", VA = "0x1E3A6D4")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5864", Offset = "0x9B5864")]
		public LayerMask layers;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B589C", Offset = "0x9B589C")]
		public float maxStep;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B58D4", Offset = "0x9B58D4")]
		public float heightOffset;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B590C", Offset = "0x9B590C")]
		public float footSpeed;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5944", Offset = "0x9B5944")]
		public float footRadius;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B597C", Offset = "0x9B597C")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B59C8", Offset = "0x9B59C8")]
		public float prediction;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5A00", Offset = "0x9B5A00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5A00", Offset = "0x9B5A00")]
		public float footRotationWeight;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5A54", Offset = "0x9B5A54")]
		public float footRotationSpeed;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5A8C", Offset = "0x9B5A8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5A8C", Offset = "0x9B5A8C")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5AE4", Offset = "0x9B5AE4")]
		public bool rotateSolver;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5B1C", Offset = "0x9B5B1C")]
		public float pelvisSpeed;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B5B54", Offset = "0x9B5B54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5B54", Offset = "0x9B5B54")]
		public float pelvisDamper;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5BA8", Offset = "0x9B5BA8")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5BE0", Offset = "0x9B5BE0")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5C18", Offset = "0x9B5C18")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5C50", Offset = "0x9B5C50")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5C88", Offset = "0x9B5C88")]
		public Quality quality;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5CC0", Offset = "0x9B5CC0")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5CD0", Offset = "0x9B5CD0")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5CE0", Offset = "0x9B5CE0")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5CF0", Offset = "0x9B5CF0")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5D00", Offset = "0x9B5D00")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000090")]
		public Leg[] legs
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x211FDCC", Offset = "0x211FDCC", VA = "0x211FDCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD7C0", Offset = "0x9BD7C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x211FDD4", Offset = "0x211FDD4", VA = "0x211FDD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD7D0", Offset = "0x9BD7D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public Pelvis pelvis
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x211FDDC", Offset = "0x211FDDC", VA = "0x211FDDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD7E0", Offset = "0x9BD7E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x211FDE4", Offset = "0x211FDE4", VA = "0x211FDE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD7F0", Offset = "0x9BD7F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public bool isGrounded
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x211FDEC", Offset = "0x211FDEC", VA = "0x211FDEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD800", Offset = "0x9BD800")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x211FDF4", Offset = "0x211FDF4", VA = "0x211FDF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD810", Offset = "0x9BD810")]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public Transform root
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x211FE00", Offset = "0x211FE00", VA = "0x211FE00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD820", Offset = "0x9BD820")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x211FE08", Offset = "0x211FE08", VA = "0x211FE08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD830", Offset = "0x9BD830")]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x211FE10", Offset = "0x211FE10", VA = "0x211FE10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD840", Offset = "0x9BD840")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x211FE28", Offset = "0x211FE28", VA = "0x211FE28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BD850", Offset = "0x9BD850")]
			private set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x211FE48", Offset = "0x211FE48", VA = "0x211FE48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000096")]
		public Vector3 up
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x211ABC4", Offset = "0x211ABC4", VA = "0x211ABC4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000097")]
		private bool useRootRotation
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x2120208", Offset = "0x2120208", VA = "0x2120208")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x211FE9C", Offset = "0x211FE9C", VA = "0x211FE9C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x21200E8", Offset = "0x21200E8", VA = "0x21200E8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x211A1D8", Offset = "0x211A1D8", VA = "0x211A1D8")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x211A8A8", Offset = "0x211A8A8", VA = "0x211A8A8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x211C68C", Offset = "0x211C68C", VA = "0x211C68C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x2119D80", Offset = "0x2119D80", VA = "0x2119D80")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x21201F0", Offset = "0x21201F0", VA = "0x21201F0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2120288", Offset = "0x2120288", VA = "0x2120288")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2120318", Offset = "0x2120318", VA = "0x2120318")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x21203D4", Offset = "0x21203D4", VA = "0x21203D4")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x2119C60", Offset = "0x2119C60", VA = "0x2119C60")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B317C", Offset = "0x9B317C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B317C", Offset = "0x9B317C")]
	public class AimIK : IK
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1FA4F68", Offset = "0x1FA4F68", VA = "0x1FA4F68", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD9C0", Offset = "0x9BD9C0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1FA4FB0", Offset = "0x1FA4FB0", VA = "0x1FA4FB0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BD9F8", Offset = "0x9BD9F8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1FA4FF8", Offset = "0x1FA4FF8", VA = "0x1FA4FF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDA30", Offset = "0x9BDA30")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1FA5040", Offset = "0x1FA5040", VA = "0x1FA5040")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDA68", Offset = "0x9BDA68")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1FA5088", Offset = "0x1FA5088", VA = "0x1FA5088")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDAA0", Offset = "0x9BDAA0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1FA50D0", Offset = "0x1FA50D0", VA = "0x1FA50D0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1FA50D8", Offset = "0x1FA50D8", VA = "0x1FA50D8")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B31DC", Offset = "0x9B31DC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B31DC", Offset = "0x9B31DC")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1FA69C8", Offset = "0x1FA69C8", VA = "0x1FA69C8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDAD8", Offset = "0x9BDAD8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1FA6A10", Offset = "0x1FA6A10", VA = "0x1FA6A10", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDB10", Offset = "0x9BDB10")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1FA6A58", Offset = "0x1FA6A58", VA = "0x1FA6A58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDB48", Offset = "0x9BDB48")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1FA6AA0", Offset = "0x1FA6AA0", VA = "0x1FA6AA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDB80", Offset = "0x9BDB80")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1FA6AE8", Offset = "0x1FA6AE8", VA = "0x1FA6AE8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1FA6AF0", Offset = "0x1FA6AF0", VA = "0x1FA6AF0")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B323C", Offset = "0x9B323C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B323C", Offset = "0x9B323C")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1FB5C48", Offset = "0x1FB5C48", VA = "0x1FB5C48", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDBB8", Offset = "0x9BDBB8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1FB5C90", Offset = "0x1FB5C90", VA = "0x1FB5C90", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDBF0", Offset = "0x9BDBF0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1FB5CD8", Offset = "0x1FB5CD8", VA = "0x1FB5CD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDC28", Offset = "0x9BDC28")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1FB5D20", Offset = "0x1FB5D20", VA = "0x1FB5D20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDC60", Offset = "0x9BDC60")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1FB5D68", Offset = "0x1FB5D68", VA = "0x1FB5D68", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1FB5D70", Offset = "0x1FB5D70", VA = "0x1FB5D70")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B329C", Offset = "0x9B329C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B329C", Offset = "0x9B329C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x208D300", Offset = "0x208D300", VA = "0x208D300", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDC98", Offset = "0x9BDC98")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x208D348", Offset = "0x208D348", VA = "0x208D348", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDCD0", Offset = "0x9BDCD0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x208D390", Offset = "0x208D390", VA = "0x208D390")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDD08", Offset = "0x9BDD08")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x208D3D8", Offset = "0x208D3D8", VA = "0x208D3D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDD40", Offset = "0x9BDD40")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x208D420", Offset = "0x208D420", VA = "0x208D420", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x208D428", Offset = "0x208D428", VA = "0x208D428")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B32FC", Offset = "0x9B32FC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B32FC", Offset = "0x9B32FC")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x208D94C", Offset = "0x208D94C", VA = "0x208D94C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDD78", Offset = "0x9BDD78")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x208D994", Offset = "0x208D994", VA = "0x208D994", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDDB0", Offset = "0x9BDDB0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x208D9DC", Offset = "0x208D9DC", VA = "0x208D9DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDDE8", Offset = "0x9BDDE8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x208DA24", Offset = "0x208DA24", VA = "0x208DA24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDE20", Offset = "0x9BDE20")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x208DA6C", Offset = "0x208DA6C", VA = "0x208DA6C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x208DA74", Offset = "0x208DA74", VA = "0x208DA74")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B335C", Offset = "0x9B335C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B335C", Offset = "0x9B335C")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x2118178", Offset = "0x2118178", VA = "0x2118178", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDE58", Offset = "0x9BDE58")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x21181C0", Offset = "0x21181C0", VA = "0x21181C0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDE90", Offset = "0x9BDE90")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x2118208", Offset = "0x2118208", VA = "0x2118208")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDEC8", Offset = "0x9BDEC8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x2118250", Offset = "0x2118250", VA = "0x2118250")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDF00", Offset = "0x9BDF00")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x2118298", Offset = "0x2118298", VA = "0x2118298")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDF38", Offset = "0x9BDF38")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x21182E0", Offset = "0x21182E0", VA = "0x21182E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDF70", Offset = "0x9BDF70")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x2118328", Offset = "0x2118328", VA = "0x2118328")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x211834C", Offset = "0x211834C", VA = "0x211834C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x2118354", Offset = "0x2118354", VA = "0x2118354")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2118530", Offset = "0x2118530", VA = "0x2118530")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x21187C4", Offset = "0x21187C4", VA = "0x21187C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDFA8", Offset = "0x9BDFA8")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x21187E4", Offset = "0x21187E4", VA = "0x21187E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BDFE0", Offset = "0x9BDFE0")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x21188BC", Offset = "0x21188BC", VA = "0x21188BC")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60003F8")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2123908", Offset = "0x2123908", VA = "0x2123908", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x2123990", Offset = "0x2123990", VA = "0x2123990", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2123A04", Offset = "0x2123A04", VA = "0x2123A04", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60003FC")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60003FD")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x211894C", Offset = "0x211894C", VA = "0x211894C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5DC0", Offset = "0x9B5DC0")]
		public IK[] IKComponents;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5DF8", Offset = "0x9B5DF8")]
		public Animator animator;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x170000A6")]
		private bool animatePhysics
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x2125F80", Offset = "0x2125F80", VA = "0x2125F80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x2126018", Offset = "0x2126018", VA = "0x2126018")]
		private void Start()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2126088", Offset = "0x2126088", VA = "0x2126088")]
		private void Update()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x2126144", Offset = "0x2126144", VA = "0x2126144")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x2126180", Offset = "0x2126180", VA = "0x2126180")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x21260BC", Offset = "0x21260BC", VA = "0x21260BC")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x2126210", Offset = "0x2126210", VA = "0x2126210")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B33BC", Offset = "0x9B33BC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B33BC", Offset = "0x9B33BC")]
	public class LegIK : IK
	{
		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x2081D44", Offset = "0x2081D44", VA = "0x2081D44", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE018", Offset = "0x9BE018")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x2081D8C", Offset = "0x2081D8C", VA = "0x2081D8C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE050", Offset = "0x9BE050")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x2081DD4", Offset = "0x2081DD4", VA = "0x2081DD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE088", Offset = "0x9BE088")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2081E1C", Offset = "0x2081E1C", VA = "0x2081E1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE0C0", Offset = "0x9BE0C0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x2081E64", Offset = "0x2081E64", VA = "0x2081E64", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2081E6C", Offset = "0x2081E6C", VA = "0x2081E6C")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B341C", Offset = "0x9B341C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B341C", Offset = "0x9B341C")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x20825B0", Offset = "0x20825B0", VA = "0x20825B0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE0F8", Offset = "0x9BE0F8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x20825F8", Offset = "0x20825F8", VA = "0x20825F8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE130", Offset = "0x9BE130")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2082640", Offset = "0x2082640", VA = "0x2082640")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE168", Offset = "0x9BE168")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2082688", Offset = "0x2082688", VA = "0x2082688")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE1A0", Offset = "0x9BE1A0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x20826D0", Offset = "0x20826D0", VA = "0x20826D0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x20826D8", Offset = "0x20826D8", VA = "0x20826D8")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B347C", Offset = "0x9B347C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B347C", Offset = "0x9B347C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x20830B0", Offset = "0x20830B0", VA = "0x20830B0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE1D8", Offset = "0x9BE1D8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x20830F8", Offset = "0x20830F8", VA = "0x20830F8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE210", Offset = "0x9BE210")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x2083140", Offset = "0x2083140", VA = "0x2083140")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE248", Offset = "0x9BE248")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2083188", Offset = "0x2083188", VA = "0x2083188")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE280", Offset = "0x9BE280")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x20831D0", Offset = "0x20831D0", VA = "0x20831D0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x20831D8", Offset = "0x20831D8", VA = "0x20831D8")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B34DC", Offset = "0x9B34DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B34DC", Offset = "0x9B34DC")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x19C38BC", Offset = "0x19C38BC", VA = "0x19C38BC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE2B8", Offset = "0x9BE2B8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x19C3904", Offset = "0x19C3904", VA = "0x19C3904", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE2F0", Offset = "0x9BE2F0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x19C394C", Offset = "0x19C394C", VA = "0x19C394C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE328", Offset = "0x9BE328")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x19C3994", Offset = "0x19C3994", VA = "0x19C3994")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE360", Offset = "0x9BE360")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x19C39DC", Offset = "0x19C39DC", VA = "0x19C39DC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x19C39E4", Offset = "0x19C39E4", VA = "0x19C39E4")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B353C", Offset = "0x9B353C")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000A4")]
		public class References
		{
			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5EE4", Offset = "0x9B5EE4")]
			public Transform chest;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5F1C", Offset = "0x9B5F1C")]
			public Transform neck;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5F54", Offset = "0x9B5F54")]
			public Transform leftShoulder;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5F8C", Offset = "0x9B5F8C")]
			public Transform rightShoulder;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5FC4", Offset = "0x9B5FC4")]
			public Transform leftThigh;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5FFC", Offset = "0x9B5FFC")]
			public Transform leftCalf;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6034", Offset = "0x9B6034")]
			public Transform leftFoot;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B606C", Offset = "0x9B606C")]
			public Transform leftToes;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B60A4", Offset = "0x9B60A4")]
			public Transform rightThigh;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B60DC", Offset = "0x9B60DC")]
			public Transform rightCalf;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6114", Offset = "0x9B6114")]
			public Transform rightFoot;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B614C", Offset = "0x9B614C")]
			public Transform rightToes;

			[Token(Token = "0x170000A7")]
			public bool isFilled
			{
				[Token(Token = "0x6000428")]
				[Address(RVA = "0x2164880", Offset = "0x2164880", VA = "0x2164880")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A8")]
			public bool isEmpty
			{
				[Token(Token = "0x6000429")]
				[Address(RVA = "0x2164CF8", Offset = "0x2164CF8", VA = "0x2164CF8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x2164438", Offset = "0x2164438", VA = "0x2164438")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600042A")]
			[Address(RVA = "0x2165170", Offset = "0x2165170", VA = "0x2165170")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0x216550C", Offset = "0x216550C", VA = "0x216550C")]
			public References()
			{
			}
		}

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x9B5E30", Offset = "0x9B5E30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5E30", Offset = "0x9B5E30")]
		public References references;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B5EAC", Offset = "0x9B5EAC")]
		public IKSolverVR solver;

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x19C65C8", Offset = "0x19C65C8", VA = "0x19C65C8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE398", Offset = "0x9BE398")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x19C6610", Offset = "0x19C6610", VA = "0x19C6610", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE3D0", Offset = "0x9BE3D0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x19C6658", Offset = "0x19C6658", VA = "0x19C6658")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE408", Offset = "0x9BE408")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x19C66A0", Offset = "0x19C66A0", VA = "0x19C66A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE440", Offset = "0x9BE440")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x19C66CC", Offset = "0x19C66CC", VA = "0x19C66CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE478", Offset = "0x9BE478")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x19C66F4", Offset = "0x19C66F4", VA = "0x19C66F4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x19C66FC", Offset = "0x19C66FC", VA = "0x19C66FC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x19C677C", Offset = "0x19C677C", VA = "0x19C677C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x19C68E8", Offset = "0x19C68E8", VA = "0x19C68E8")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A5")]
	public class FABRIKChain
	{
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6184", Offset = "0x9B6184")]
		public float pull;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B619C", Offset = "0x9B619C")]
		public float pin;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x208D48C", Offset = "0x208D48C", VA = "0x208D48C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x208D55C", Offset = "0x208D55C", VA = "0x208D55C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x208D57C", Offset = "0x208D57C", VA = "0x208D57C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x208D7F0", Offset = "0x208D7F0", VA = "0x208D7F0")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x208D650", Offset = "0x208D650", VA = "0x208D650")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x208D8E8", Offset = "0x208D8E8", VA = "0x208D8E8")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x208DAD8", Offset = "0x208DAD8", VA = "0x208DAD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x208DF3C", Offset = "0x208DF3C", VA = "0x208DF3C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x208E0F8", Offset = "0x208E0F8", VA = "0x208E0F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x208E204", Offset = "0x208E204", VA = "0x208E204")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A8")]
		public class BendBone
		{
			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B67F4", Offset = "0x9B67F4")]
			public Transform transform;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B682C", Offset = "0x9B682C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B682C", Offset = "0x9B682C")]
			public float weight;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x1E383BC", Offset = "0x1E383BC", VA = "0x1E383BC")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x1E383F8", Offset = "0x1E383F8", VA = "0x1E383F8")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000446")]
			[Address(RVA = "0x1E38450", Offset = "0x1E38450", VA = "0x1E38450")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x1E38488", Offset = "0x1E38488", VA = "0x1E38488")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B61B4", Offset = "0x9B61B4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9B61EC", Offset = "0x9B61EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B61EC", Offset = "0x9B61EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B61EC", Offset = "0x9B61EC")]
		public float positionWeight;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6264", Offset = "0x9B6264")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6264", Offset = "0x9B6264")]
		public float bodyWeight;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B62B8", Offset = "0x9B62B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B62B8", Offset = "0x9B62B8")]
		public float thighWeight;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B630C", Offset = "0x9B630C")]
		public bool handsPullBody;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6344", Offset = "0x9B6344")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9B6344", Offset = "0x9B6344")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6344", Offset = "0x9B6344")]
		public float rotationWeight;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B63BC", Offset = "0x9B63BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B63BC", Offset = "0x9B63BC")]
		public float bodyClampWeight;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6410", Offset = "0x9B6410")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6410", Offset = "0x9B6410")]
		public float headClampWeight;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6464", Offset = "0x9B6464")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6464", Offset = "0x9B6464")]
		public float bendWeight;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B64B8", Offset = "0x9B64B8")]
		public BendBone[] bendBones;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9B64F0", Offset = "0x9B64F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B64F0", Offset = "0x9B64F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B64F0", Offset = "0x9B64F0")]
		public float CCDWeight;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6568", Offset = "0x9B6568")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6568", Offset = "0x9B6568")]
		public float roll;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B65BC", Offset = "0x9B65BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B65BC", Offset = "0x9B65BC")]
		public float damper;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6614", Offset = "0x9B6614")]
		public Transform[] CCDBones;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B664C", Offset = "0x9B664C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B664C", Offset = "0x9B664C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9B664C", Offset = "0x9B664C")]
		public float postStretchWeight;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B66C4", Offset = "0x9B66C4")]
		public float maxStretch;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B66FC", Offset = "0x9B66FC")]
		public float stretchDamper;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6734", Offset = "0x9B6734")]
		public bool fixHead;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B676C", Offset = "0x9B676C")]
		public Transform[] stretchBones;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9B67A4", Offset = "0x9B67A4")]
		public Vector3 chestDirection;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B67DC", Offset = "0x9B67DC")]
		public float chestDirectionWeight;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x208E20C", Offset = "0x208E20C", VA = "0x208E20C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x208E540", Offset = "0x208E540", VA = "0x208E540")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x208E9E0", Offset = "0x208E9E0", VA = "0x208E9E0")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x208EDAC", Offset = "0x208EDAC", VA = "0x208EDAC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x208F538", Offset = "0x208F538", VA = "0x208F538")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x208F818", Offset = "0x208F818", VA = "0x208F818")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x208FB1C", Offset = "0x208FB1C", VA = "0x208FB1C")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x20902F0", Offset = "0x20902F0", VA = "0x20902F0")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x208F31C", Offset = "0x208F31C", VA = "0x208F31C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x20904B8", Offset = "0x20904B8", VA = "0x20904B8")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x2090208", Offset = "0x2090208", VA = "0x2090208")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x209013C", Offset = "0x209013C", VA = "0x209013C")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x209073C", Offset = "0x209073C", VA = "0x209073C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x2090A0C", Offset = "0x2090A0C", VA = "0x2090A0C")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000AA")]
		public class ChildConstraint
		{
			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B6918", Offset = "0x9B6918")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B6928", Offset = "0x9B6928")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000A9")]
			public float nominalDistance
			{
				[Token(Token = "0x600045C")]
				[Address(RVA = "0x1E38544", Offset = "0x1E38544", VA = "0x1E38544")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE4B0", Offset = "0x9BE4B0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x1E3854C", Offset = "0x1E3854C", VA = "0x1E3854C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE4C0", Offset = "0x9BE4C0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AA")]
			public bool isRigid
			{
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x1E38554", Offset = "0x1E38554", VA = "0x1E38554")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE4D0", Offset = "0x9BE4D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x1E3855C", Offset = "0x1E3855C", VA = "0x1E3855C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE4E0", Offset = "0x9BE4E0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x1E38568", Offset = "0x1E38568", VA = "0x1E38568")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x1E385B4", Offset = "0x1E385B4", VA = "0x1E385B4")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x1E3860C", Offset = "0x1E3860C", VA = "0x1E3860C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x1E387B0", Offset = "0x1E387B0", VA = "0x1E387B0")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AB")]
		public enum Smoothing
		{
			[Token(Token = "0x4000435")]
			None,
			[Token(Token = "0x4000436")]
			Exponential,
			[Token(Token = "0x4000437")]
			Cubic
		}

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6880", Offset = "0x9B6880")]
		public float pin;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6898", Offset = "0x9B6898")]
		public float pull;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B68B0", Offset = "0x9B68B0")]
		public float push;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B68C8", Offset = "0x9B68C8")]
		public float pushParent;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B68E0", Offset = "0x9B68E0")]
		public float reach;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000429")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x20910E8", Offset = "0x20910E8", VA = "0x20910E8")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x20911D4", Offset = "0x20911D4", VA = "0x20911D4")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x2091300", Offset = "0x2091300", VA = "0x2091300")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x209142C", Offset = "0x209142C", VA = "0x209142C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x2091504", Offset = "0x2091504", VA = "0x2091504")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x209161C", Offset = "0x209161C", VA = "0x209161C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x2091C98", Offset = "0x2091C98", VA = "0x2091C98")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x20917AC", Offset = "0x20917AC", VA = "0x20917AC")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x2092088", Offset = "0x2092088", VA = "0x2092088")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x20922E8", Offset = "0x20922E8", VA = "0x20922E8")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x2092554", Offset = "0x2092554", VA = "0x2092554")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x20928F8", Offset = "0x20928F8", VA = "0x20928F8")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x2092D8C", Offset = "0x2092D8C", VA = "0x2092D8C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x2092FB0", Offset = "0x2092FB0", VA = "0x2092FB0")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x2092D1C", Offset = "0x2092D1C", VA = "0x2092D1C")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x2092784", Offset = "0x2092784", VA = "0x2092784")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x2092CA0", Offset = "0x2092CA0", VA = "0x2092CA0")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x2093098", Offset = "0x2093098", VA = "0x2093098")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x2092BC0", Offset = "0x2092BC0", VA = "0x2092BC0")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x2092E98", Offset = "0x2092E98", VA = "0x2092E98")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6938", Offset = "0x9B6938")]
		public float weight;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B6950", Offset = "0x9B6950")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x170000AB")]
		public bool initiated
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x2123C4C", Offset = "0x2123C4C", VA = "0x2123C4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE4F0", Offset = "0x9BE4F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x2123C54", Offset = "0x2123C54", VA = "0x2123C54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE500", Offset = "0x9BE500")]
			private set
			{
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x2123A64", Offset = "0x2123A64", VA = "0x2123A64")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x2123C60", Offset = "0x2123C60", VA = "0x2123C60")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x2123CA0", Offset = "0x2123CA0", VA = "0x2123CA0")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x2123D00", Offset = "0x2123D00", VA = "0x2123D00")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x2123D0C", Offset = "0x2123D0C", VA = "0x2123D0C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x2124020", Offset = "0x2124020", VA = "0x2124020")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x2124210", Offset = "0x2124210", VA = "0x2124210")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x212455C", Offset = "0x212455C", VA = "0x212455C")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x2123ED0", Offset = "0x2123ED0", VA = "0x2123ED0")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x2123F78", Offset = "0x2123F78", VA = "0x2123F78")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class IKEffector
	{
		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6960", Offset = "0x9B6960")]
		public float positionWeight;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6978", Offset = "0x9B6978")]
		public float rotationWeight;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B6990", Offset = "0x9B6990")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B69A0", Offset = "0x9B69A0")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x170000AC")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x21249F8", Offset = "0x21249F8", VA = "0x21249F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE510", Offset = "0x9BE510")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x2124A00", Offset = "0x2124A00", VA = "0x2124A00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE520", Offset = "0x9BE520")]
			private set
			{
			}
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x2124990", Offset = "0x2124990", VA = "0x2124990")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x2124A0C", Offset = "0x2124A0C", VA = "0x2124A0C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x2124A9C", Offset = "0x2124A9C", VA = "0x2124A9C")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x2124BB0", Offset = "0x2124BB0", VA = "0x2124BB0")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x2124CE0", Offset = "0x2124CE0", VA = "0x2124CE0")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x2124FFC", Offset = "0x2124FFC", VA = "0x2124FFC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x2125290", Offset = "0x2125290", VA = "0x2125290")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x2125364", Offset = "0x2125364", VA = "0x2125364")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x212540C", Offset = "0x212540C", VA = "0x212540C")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x2125948", Offset = "0x2125948", VA = "0x2125948")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x2125974", Offset = "0x2125974", VA = "0x2125974")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x2125AD4", Offset = "0x2125AD4", VA = "0x2125AD4")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x2125D60", Offset = "0x2125D60", VA = "0x2125D60")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000AF")]
		public class BoneMap
		{
			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000AD")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000485")]
				[Address(RVA = "0x1E3BA3C", Offset = "0x1E3BA3C", VA = "0x1E3BA3C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AE")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x1E3BB18", Offset = "0x1E3BB18", VA = "0x1E3BB18")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AF")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x600049C")]
				[Address(RVA = "0x1E3BEBC", Offset = "0x1E3BEBC", VA = "0x1E3BEBC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x1E3BA10", Offset = "0x1E3BA10", VA = "0x1E3BA10")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x1E3BA78", Offset = "0x1E3BA78", VA = "0x1E3BA78")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x1E3BAC8", Offset = "0x1E3BAC8", VA = "0x1E3BAC8")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1E3BB28", Offset = "0x1E3BB28", VA = "0x1E3BB28")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x1E3BBB0", Offset = "0x1E3BBB0", VA = "0x1E3BBB0")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x1E3BBB8", Offset = "0x1E3BBB8", VA = "0x1E3BBB8")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x1E3BC90", Offset = "0x1E3BC90", VA = "0x1E3BC90")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x1E3BD08", Offset = "0x1E3BD08", VA = "0x1E3BD08")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x1E3BDA0", Offset = "0x1E3BDA0", VA = "0x1E3BDA0")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x1E3BFFC", Offset = "0x1E3BFFC", VA = "0x1E3BFFC")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x1E3C034", Offset = "0x1E3C034", VA = "0x1E3C034")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x1E3C06C", Offset = "0x1E3C06C", VA = "0x1E3C06C")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x1E3C094", Offset = "0x1E3C094", VA = "0x1E3C094")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x1E3C180", Offset = "0x1E3C180", VA = "0x1E3C180")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x1E3C30C", Offset = "0x1E3C30C", VA = "0x1E3C30C")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x1E3C33C", Offset = "0x1E3C33C", VA = "0x1E3C33C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1E3C404", Offset = "0x1E3C404", VA = "0x1E3C404")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x1E3C474", Offset = "0x1E3C474", VA = "0x1E3C474")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x1E3C5C4", Offset = "0x1E3C5C4", VA = "0x1E3C5C4")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x1E3C714", Offset = "0x1E3C714", VA = "0x1E3C714")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x1E3C794", Offset = "0x1E3C794", VA = "0x1E3C794")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x1E3C1FC", Offset = "0x1E3C1FC", VA = "0x1E3C1FC")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0x1E3C8CC", Offset = "0x1E3C8CC", VA = "0x1E3C8CC")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x2126218", Offset = "0x2126218", VA = "0x2126218", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x2126220", Offset = "0x2126220", VA = "0x2126220", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x2126224", Offset = "0x2126224", VA = "0x2126224")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x2126368", Offset = "0x2126368", VA = "0x2126368")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x21263D8", Offset = "0x21263D8", VA = "0x21263D8")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B69B8", Offset = "0x9B69B8")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x21263E0", Offset = "0x21263E0", VA = "0x21263E0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x2126488", Offset = "0x2126488", VA = "0x2126488")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x21264F4", Offset = "0x21264F4", VA = "0x21264F4")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2126574", Offset = "0x2126574", VA = "0x2126574")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2126590", Offset = "0x2126590", VA = "0x2126590")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x21265B0", Offset = "0x21265B0", VA = "0x21265B0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2126638", Offset = "0x2126638", VA = "0x2126638")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x2126654", Offset = "0x2126654", VA = "0x2126654")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000B2")]
		public enum BoneMapType
		{
			[Token(Token = "0x400048F")]
			Parent,
			[Token(Token = "0x4000490")]
			Bone1,
			[Token(Token = "0x4000491")]
			Bone2,
			[Token(Token = "0x4000492")]
			Bone3
		}

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B69D0", Offset = "0x9B69D0")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B69E8", Offset = "0x9B69E8")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x212667C", Offset = "0x212667C", VA = "0x212667C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x2126700", Offset = "0x2126700", VA = "0x2126700")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x21267DC", Offset = "0x21267DC", VA = "0x21267DC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x2126A00", Offset = "0x2126A00", VA = "0x2126A00")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x2126AC4", Offset = "0x2126AC4", VA = "0x2126AC4")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2126BB4", Offset = "0x2126BB4", VA = "0x2126BB4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2126BC0", Offset = "0x2126BC0", VA = "0x2126BC0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2126C74", Offset = "0x2126C74", VA = "0x2126C74")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2126D38", Offset = "0x2126D38", VA = "0x2126D38", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2126F78", Offset = "0x2126F78", VA = "0x2126F78")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2126FEC", Offset = "0x2126FEC", VA = "0x2126FEC")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6A00", Offset = "0x9B6A00")]
		public int iterations;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6A18", Offset = "0x9B6A18")]
		public float twistWeight;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x212716C", Offset = "0x212716C", VA = "0x212716C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x21274D0", Offset = "0x21274D0", VA = "0x21274D0")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x21275B4", Offset = "0x21275B4", VA = "0x21275B4")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x21276CC", Offset = "0x21276CC", VA = "0x21276CC")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x21276DC", Offset = "0x21276DC", VA = "0x21276DC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2127748", Offset = "0x2127748", VA = "0x2127748")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x21277CC", Offset = "0x21277CC", VA = "0x21277CC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2127DA4", Offset = "0x2127DA4", VA = "0x2127DA4")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2127DDC", Offset = "0x2127DDC", VA = "0x2127DDC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2128060", Offset = "0x2128060", VA = "0x2128060")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x2128368", Offset = "0x2128368", VA = "0x2128368")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2128454", Offset = "0x2128454", VA = "0x2128454")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x212851C", Offset = "0x212851C", VA = "0x212851C")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		public class Point
		{
			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6ADC", Offset = "0x9B6ADC")]
			public float weight;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x1E3D428", Offset = "0x1E3D428", VA = "0x1E3D428")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x1E3D478", Offset = "0x1E3D478", VA = "0x1E3D478")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x1E3D518", Offset = "0x1E3D518", VA = "0x1E3D518")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x1E3D550", Offset = "0x1E3D550", VA = "0x1E3D550")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x1E3D588", Offset = "0x1E3D588", VA = "0x1E3D588")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x1E3D5D8", Offset = "0x1E3D5D8", VA = "0x1E3D5D8")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x1E3CFB8", Offset = "0x1E3CFB8", VA = "0x1E3CFB8")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B6")]
		public class Bone : Point
		{
			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000B1")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x60004DB")]
				[Address(RVA = "0x1E3C8E8", Offset = "0x1E3C8E8", VA = "0x1E3C8E8")]
				get
				{
					return null;
				}
				[Token(Token = "0x60004DC")]
				[Address(RVA = "0x1E3C9E4", Offset = "0x1E3C9E4", VA = "0x1E3C9E4")]
				set
				{
				}
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x1E3CA68", Offset = "0x1E3CA68", VA = "0x1E3CA68")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x1E3CC18", Offset = "0x1E3CC18", VA = "0x1E3CC18")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x1E3CDEC", Offset = "0x1E3CDEC", VA = "0x1E3CDEC")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x1E3CF4C", Offset = "0x1E3CF4C", VA = "0x1E3CF4C")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x1E3CF74", Offset = "0x1E3CF74", VA = "0x1E3CF74")]
			public Bone()
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x1E3CFF4", Offset = "0x1E3CFF4", VA = "0x1E3CFF4")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x1E3D044", Offset = "0x1E3D044", VA = "0x1E3D044")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B7")]
		public class Node : Point
		{
			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x1E3D3C4", Offset = "0x1E3D3C4", VA = "0x1E3D3C4")]
			public Node()
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x1E3D3C8", Offset = "0x1E3D3C8", VA = "0x1E3D3C8")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x1E3D3F0", Offset = "0x1E3D3F0", VA = "0x1E3D3F0")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000B8")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000B9")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6A40", Offset = "0x9B6A40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6A40", Offset = "0x9B6A40")]
		public float IKPositionWeight;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B6A94", Offset = "0x9B6A94")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x170000B0")]
		public bool initiated
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x2343840", Offset = "0x2343840", VA = "0x2343840")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE530", Offset = "0x9BE530")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x2343848", Offset = "0x2343848", VA = "0x2343848")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE540", Offset = "0x9BE540")]
			private set
			{
			}
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x234358C", Offset = "0x234358C", VA = "0x234358C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2343604", Offset = "0x2343604", VA = "0x2343604")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2343778", Offset = "0x2343778", VA = "0x2343778")]
		public void Update()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x23437E8", Offset = "0x23437E8", VA = "0x23437E8", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x23437F4", Offset = "0x23437F4", VA = "0x23437F4")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2343800", Offset = "0x2343800", VA = "0x2343800")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2343808", Offset = "0x2343808", VA = "0x2343808")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2343838", Offset = "0x2343838", VA = "0x2343838")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60004CA")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60004CB")]
		public abstract void FixTransforms();

		[Token(Token = "0x60004CC")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60004CD")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60004CE")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2343854", Offset = "0x2343854", VA = "0x2343854")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x234386C", Offset = "0x234386C", VA = "0x234386C")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x23439A4", Offset = "0x23439A4", VA = "0x23439A4")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x2343A50", Offset = "0x2343A50", VA = "0x2343A50")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x2343CD8", Offset = "0x2343CD8", VA = "0x2343CD8")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6AF4", Offset = "0x9B6AF4")]
		public float poleWeight;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6B0C", Offset = "0x9B6B0C")]
		public float clampWeight;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6B24", Offset = "0x9B6B24")]
		public int clampSmoothing;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x170000B2")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x2343D6C", Offset = "0x2343D6C", VA = "0x2343D6C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B3")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x2343DA8", Offset = "0x2343DA8", VA = "0x2343DA8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B4")]
		protected override int minBones
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x2344838", Offset = "0x2344838", VA = "0x2344838", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B5")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x2344C1C", Offset = "0x2344C1C", VA = "0x2344C1C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2343CF0", Offset = "0x2343CF0", VA = "0x2343CF0")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2343DE4", Offset = "0x2343DE4", VA = "0x2343DE4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2344004", Offset = "0x2344004", VA = "0x2344004", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2344784", Offset = "0x2344784", VA = "0x2344784")]
		private void Solve()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2344514", Offset = "0x2344514", VA = "0x2344514")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2344840", Offset = "0x2344840", VA = "0x2344840")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x2344C90", Offset = "0x2344C90", VA = "0x2344C90")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BB")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6B3C", Offset = "0x9B6B3C")]
		public float IKRotationWeight;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2344D58", Offset = "0x2344D58", VA = "0x2344D58", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x23450F8", Offset = "0x23450F8", VA = "0x23450F8")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2345164", Offset = "0x2345164", VA = "0x2345164", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x23452BC", Offset = "0x23452BC", VA = "0x23452BC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2345450", Offset = "0x2345450", VA = "0x2345450", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x23454AC", Offset = "0x23454AC", VA = "0x23454AC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x234551C", Offset = "0x234551C", VA = "0x234551C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x234588C", Offset = "0x234588C", VA = "0x234588C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x23458B8", Offset = "0x23458B8", VA = "0x23458B8")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2345580", Offset = "0x2345580", VA = "0x2345580")]
		private void Read()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2345924", Offset = "0x2345924", VA = "0x2345924")]
		private void Write()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2345AB0", Offset = "0x2345AB0", VA = "0x2345AB0")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BC")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2345C14", Offset = "0x2345C14", VA = "0x2345C14")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2345CC4", Offset = "0x2345CC4", VA = "0x2345CC4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x23461BC", Offset = "0x23461BC", VA = "0x23461BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x23467B4", Offset = "0x23467B4", VA = "0x23467B4")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2346D90", Offset = "0x2346D90", VA = "0x2346D90")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BD")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x170000B6")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x2347CC4", Offset = "0x2347CC4", VA = "0x2347CC4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2346D94", Offset = "0x2346D94", VA = "0x2346D94")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2347358", Offset = "0x2347358", VA = "0x2347358")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2347498", Offset = "0x2347498", VA = "0x2347498", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x234752C", Offset = "0x234752C", VA = "0x234752C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2347A04", Offset = "0x2347A04", VA = "0x2347A04", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2347CCC", Offset = "0x2347CCC", VA = "0x2347CCC")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2346E70", Offset = "0x2346E70", VA = "0x2346E70")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2347444", Offset = "0x2347444", VA = "0x2347444")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x2347C68", Offset = "0x2347C68", VA = "0x2347C68")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x23471CC", Offset = "0x23471CC", VA = "0x23471CC")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x234831C", Offset = "0x234831C", VA = "0x234831C")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x2348390", Offset = "0x2348390", VA = "0x2348390")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x2348458", Offset = "0x2348458", VA = "0x2348458")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x2348508", Offset = "0x2348508", VA = "0x2348508")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x23477B4", Offset = "0x23477B4", VA = "0x23477B4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x23478DC", Offset = "0x23478DC", VA = "0x23478DC")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x234860C", Offset = "0x234860C", VA = "0x234860C")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x2347EEC", Offset = "0x2347EEC", VA = "0x2347EEC")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x2347434", Offset = "0x2347434", VA = "0x2347434")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x2348B9C", Offset = "0x2348B9C", VA = "0x2348B9C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x2348750", Offset = "0x2348750", VA = "0x2348750")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x2347D48", Offset = "0x2347D48", VA = "0x2347D48")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x2347E28", Offset = "0x2347E28", VA = "0x2347E28")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x2348C68", Offset = "0x2348C68", VA = "0x2348C68")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BE")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6B54", Offset = "0x9B6B54")]
		public float rootPin;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x2348CE4", Offset = "0x2348CE4", VA = "0x2348CE4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x2349324", Offset = "0x2349324", VA = "0x2349324", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x23493BC", Offset = "0x23493BC", VA = "0x23493BC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x234945C", Offset = "0x234945C", VA = "0x234945C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x2349558", Offset = "0x2349558", VA = "0x2349558")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x23495F4", Offset = "0x23495F4", VA = "0x23495F4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x2349A24", Offset = "0x2349A24", VA = "0x2349A24", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2349C1C", Offset = "0x2349C1C", VA = "0x2349C1C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x2349AD0", Offset = "0x2349AD0", VA = "0x2349AD0")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x23497E0", Offset = "0x23497E0", VA = "0x23497E0")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x2349CB4", Offset = "0x2349CB4", VA = "0x2349CB4")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BF")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6B6C", Offset = "0x9B6B6C")]
		public int iterations;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2349D28", Offset = "0x2349D28", VA = "0x2349D28")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x2349E18", Offset = "0x2349E18", VA = "0x2349E18")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x2349E74", Offset = "0x2349E74", VA = "0x2349E74")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x2349FA4", Offset = "0x2349FA4", VA = "0x2349FA4")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x234A000", Offset = "0x234A000", VA = "0x234A000")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x234A080", Offset = "0x234A080", VA = "0x234A080", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x234A224", Offset = "0x234A224", VA = "0x234A224", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x234A394", Offset = "0x234A394", VA = "0x234A394", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x234A5A0", Offset = "0x234A5A0", VA = "0x234A5A0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x234A678", Offset = "0x234A678", VA = "0x234A678", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x234A764", Offset = "0x234A764", VA = "0x234A764", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x234A8D8", Offset = "0x234A8D8", VA = "0x234A8D8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x234AA30", Offset = "0x234AA30", VA = "0x234AA30", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x234AC7C", Offset = "0x234AC7C", VA = "0x234AC7C", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x234AF58", Offset = "0x234AF58", VA = "0x234AF58", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x234AF9C", Offset = "0x234AF9C", VA = "0x234AF9C", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x234B08C", Offset = "0x234B08C", VA = "0x234B08C")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C0")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40004EB")]
		Body,
		[Token(Token = "0x40004EC")]
		LeftShoulder,
		[Token(Token = "0x40004ED")]
		RightShoulder,
		[Token(Token = "0x40004EE")]
		LeftThigh,
		[Token(Token = "0x40004EF")]
		RightThigh,
		[Token(Token = "0x40004F0")]
		LeftHand,
		[Token(Token = "0x40004F1")]
		RightHand,
		[Token(Token = "0x40004F2")]
		LeftFoot,
		[Token(Token = "0x40004F3")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x20000C1")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40004F5")]
		LeftArm,
		[Token(Token = "0x40004F6")]
		RightArm,
		[Token(Token = "0x40004F7")]
		LeftLeg,
		[Token(Token = "0x40004F8")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x20000C2")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6B84", Offset = "0x9B6B84")]
		public float spineStiffness;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6B9C", Offset = "0x9B6B9C")]
		public float pullBodyVertical;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6BB4", Offset = "0x9B6BB4")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B6BCC", Offset = "0x9B6BCC")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x170000B7")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x234B19C", Offset = "0x234B19C", VA = "0x234B19C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x234B2E4", Offset = "0x234B2E4", VA = "0x234B2E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x234B2EC", Offset = "0x234B2EC", VA = "0x234B2EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x234B2F4", Offset = "0x234B2F4", VA = "0x234B2F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x234B2FC", Offset = "0x234B2FC", VA = "0x234B2FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x234B304", Offset = "0x234B304", VA = "0x234B304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x234B30C", Offset = "0x234B30C", VA = "0x234B30C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x234B314", Offset = "0x234B314", VA = "0x234B314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x234B31C", Offset = "0x234B31C", VA = "0x234B31C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x234B324", Offset = "0x234B324", VA = "0x234B324")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x234B35C", Offset = "0x234B35C", VA = "0x234B35C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x234B394", Offset = "0x234B394", VA = "0x234B394")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x234B3CC", Offset = "0x234B3CC", VA = "0x234B3CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x234B404", Offset = "0x234B404", VA = "0x234B404")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x234B438", Offset = "0x234B438", VA = "0x234B438")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x234B470", Offset = "0x234B470", VA = "0x234B470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x234B4A8", Offset = "0x234B4A8", VA = "0x234B4A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x234B4E0", Offset = "0x234B4E0", VA = "0x234B4E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x234D3A4", Offset = "0x234D3A4", VA = "0x234D3A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE550", Offset = "0x9BE550")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x234D3B0", Offset = "0x234D3B0", VA = "0x234D3B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE560", Offset = "0x9BE560")]
			private set
			{
			}
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x234B514", Offset = "0x234B514", VA = "0x234B514")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x234B620", Offset = "0x234B620", VA = "0x234B620")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x234B568", Offset = "0x234B568", VA = "0x234B568")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x234B6AC", Offset = "0x234B6AC", VA = "0x234B6AC")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x234B1A4", Offset = "0x234B1A4", VA = "0x234B1A4")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x234B77C", Offset = "0x234B77C", VA = "0x234B77C")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x234B834", Offset = "0x234B834", VA = "0x234B834")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x234B8E8", Offset = "0x234B8E8", VA = "0x234B8E8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x234B99C", Offset = "0x234B99C", VA = "0x234B99C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x234B9A4", Offset = "0x234B9A4", VA = "0x234B9A4")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x234B9D8", Offset = "0x234B9D8", VA = "0x234B9D8")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x234BAA0", Offset = "0x234BAA0", VA = "0x234BAA0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x234BC44", Offset = "0x234BC44", VA = "0x234BC44")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x234CE20", Offset = "0x234CE20", VA = "0x234CE20")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x234D234", Offset = "0x234D234", VA = "0x234D234")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x234D294", Offset = "0x234D294", VA = "0x234D294")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x234D0BC", Offset = "0x234D0BC", VA = "0x234D0BC")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x234D178", Offset = "0x234D178", VA = "0x234D178")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x234D3BC", Offset = "0x234D3BC", VA = "0x234D3BC")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x234D494", Offset = "0x234D494", VA = "0x234D494", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x234D590", Offset = "0x234D590", VA = "0x234D590")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x234D6B8", Offset = "0x234D6B8", VA = "0x234D6B8")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x234D7FC", Offset = "0x234D7FC", VA = "0x234D7FC")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x234D92C", Offset = "0x234D92C", VA = "0x234D92C", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x234DB6C", Offset = "0x234DB6C", VA = "0x234DB6C", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x234DBF0", Offset = "0x234DBF0", VA = "0x234DBF0")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C3")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x170000CA")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x234E450", Offset = "0x234E450", VA = "0x234E450", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CB")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x234E458", Offset = "0x234E458", VA = "0x234E458", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CC")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x234E460", Offset = "0x234E460", VA = "0x234E460", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CD")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x234E470", Offset = "0x234E470", VA = "0x234E470", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000CE")]
		protected float positionOffset
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x2346760", Offset = "0x2346760", VA = "0x2346760")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x234DBFC", Offset = "0x234DBFC", VA = "0x234DBFC")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x234DD94", Offset = "0x234DD94", VA = "0x234DD94")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x234DECC", Offset = "0x234DECC", VA = "0x234DECC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x234DF38", Offset = "0x234DF38", VA = "0x234DF38", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x234DFB8", Offset = "0x234DFB8", VA = "0x234DFB8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x234E358", Offset = "0x234E358", VA = "0x234E358", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x234E360", Offset = "0x234E360", VA = "0x234E360", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x234E468", Offset = "0x234E468", VA = "0x234E468", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x234E46C", Offset = "0x234E46C", VA = "0x234E46C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x2345D44", Offset = "0x2345D44", VA = "0x2345D44")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x2346448", Offset = "0x2346448", VA = "0x2346448")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x234E538", Offset = "0x234E538", VA = "0x234E538")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x2344CE0", Offset = "0x2344CE0", VA = "0x2344CE0")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C4")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6BDC", Offset = "0x9B6BDC")]
		public float IKRotationWeight;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x234E72C", Offset = "0x234E72C", VA = "0x234E72C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x234EACC", Offset = "0x234EACC", VA = "0x234EACC")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x234EB38", Offset = "0x234EB38", VA = "0x234EB38", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x234EC90", Offset = "0x234EC90", VA = "0x234EC90", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x234EE24", Offset = "0x234EE24", VA = "0x234EE24", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x234EE80", Offset = "0x234EE80", VA = "0x234EE80", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x234EEF0", Offset = "0x234EEF0", VA = "0x234EEF0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x234F260", Offset = "0x234F260", VA = "0x234F260", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x234F28C", Offset = "0x234F28C", VA = "0x234F28C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x234EF54", Offset = "0x234EF54", VA = "0x234EF54")]
		private void Read()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x234F320", Offset = "0x234F320", VA = "0x234F320")]
		private void Write()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x234F4AC", Offset = "0x234F4AC", VA = "0x234F4AC")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C5")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000C6")]
		public enum BendModifier
		{
			[Token(Token = "0x4000523")]
			Animation,
			[Token(Token = "0x4000524")]
			Target,
			[Token(Token = "0x4000525")]
			Parent,
			[Token(Token = "0x4000526")]
			Arm,
			[Token(Token = "0x4000527")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000C7")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000596")]
			[Address(RVA = "0x1E3D86C", Offset = "0x1E3D86C", VA = "0x1E3D86C")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6BF4", Offset = "0x9B6BF4")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6C0C", Offset = "0x9B6C0C")]
		public float bendModifierWeight;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x170000CF")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x2350740", Offset = "0x2350740", VA = "0x2350740")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x234F610", Offset = "0x234F610", VA = "0x234F610")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x234F660", Offset = "0x234F660", VA = "0x234F660")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x234F6AC", Offset = "0x234F6AC", VA = "0x234F6AC", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x234FB80", Offset = "0x234FB80", VA = "0x234FB80", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x23504CC", Offset = "0x23504CC", VA = "0x23504CC", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x2350578", Offset = "0x2350578", VA = "0x2350578")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x23506BC", Offset = "0x23506BC", VA = "0x23506BC")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x234F9A8", Offset = "0x234F9A8", VA = "0x234F9A8")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x234FC64", Offset = "0x234FC64", VA = "0x234FC64")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000C8")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x170000D6")]
			public Vector3 forward
			{
				[Token(Token = "0x60005B5")]
				[Address(RVA = "0x1E3DAF8", Offset = "0x1E3DAF8", VA = "0x1E3DAF8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x1E3D8CC", Offset = "0x1E3D8CC", VA = "0x1E3D8CC")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x1E3D8D0", Offset = "0x1E3D8D0", VA = "0x1E3D8D0")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x1E3D8F8", Offset = "0x1E3D8F8", VA = "0x1E3D8F8")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x1E3D9F0", Offset = "0x1E3D9F0", VA = "0x1E3D9F0")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6C24", Offset = "0x9B6C24")]
		public float bodyWeight;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6C3C", Offset = "0x9B6C3C")]
		public float headWeight;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6C54", Offset = "0x9B6C54")]
		public float eyesWeight;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6C6C", Offset = "0x9B6C6C")]
		public float clampWeight;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6C84", Offset = "0x9B6C84")]
		public float clampWeightHead;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6C9C", Offset = "0x9B6C9C")]
		public float clampWeightEyes;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6CB4", Offset = "0x9B6CB4")]
		public int clampSmoothing;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x170000D0")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x2350ED8", Offset = "0x2350ED8", VA = "0x2350ED8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D1")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x23510A8", Offset = "0x23510A8", VA = "0x23510A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D2")]
		protected bool headIsValid
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x2350FB8", Offset = "0x2350FB8", VA = "0x2350FB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D3")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x23510CC", Offset = "0x23510CC", VA = "0x23510CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D4")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x2350FC8", Offset = "0x2350FC8", VA = "0x2350FC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D5")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x2351144", Offset = "0x2351144", VA = "0x2351144")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x235075C", Offset = "0x235075C", VA = "0x235075C")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x235078C", Offset = "0x235078C", VA = "0x235078C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x23507E4", Offset = "0x23507E4", VA = "0x23507E4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x2350860", Offset = "0x2350860", VA = "0x2350860")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x23508F8", Offset = "0x23508F8", VA = "0x23508F8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x23509B8", Offset = "0x23509B8", VA = "0x23509B8")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x2350AB4", Offset = "0x2350AB4", VA = "0x2350AB4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2350BE0", Offset = "0x2350BE0", VA = "0x2350BE0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x2350D20", Offset = "0x2350D20", VA = "0x2350D20", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x2351168", Offset = "0x2351168", VA = "0x2351168", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x23513A8", Offset = "0x23513A8", VA = "0x23513A8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x2351544", Offset = "0x2351544", VA = "0x2351544")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x2351770", Offset = "0x2351770", VA = "0x2351770", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x2351A44", Offset = "0x2351A44", VA = "0x2351A44", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x2351B14", Offset = "0x2351B14", VA = "0x2351B14")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x2351CB4", Offset = "0x2351CB4", VA = "0x2351CB4")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x2351ED8", Offset = "0x2351ED8", VA = "0x2351ED8")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x235228C", Offset = "0x235228C", VA = "0x235228C")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x23515EC", Offset = "0x23515EC", VA = "0x23515EC")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x23524FC", Offset = "0x23524FC", VA = "0x23524FC")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CA")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x1E3DB34", Offset = "0x1E3DB34", VA = "0x1E3DB34")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x1E3DC30", Offset = "0x1E3DC30", VA = "0x1E3DC30")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x1E3DC60", Offset = "0x1E3DC60", VA = "0x1E3DC60")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x1E3DC9C", Offset = "0x1E3DC9C", VA = "0x1E3DC9C")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6CCC", Offset = "0x9B6CCC")]
		public float IKRotationWeight;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x2352718", Offset = "0x2352718", VA = "0x2352718")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2352874", Offset = "0x2352874", VA = "0x2352874")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x23529B8", Offset = "0x23529B8", VA = "0x23529B8")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x23529C4", Offset = "0x23529C4", VA = "0x23529C4")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x23529F4", Offset = "0x23529F4", VA = "0x23529F4")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x2352A00", Offset = "0x2352A00", VA = "0x2352A00")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x2352A08", Offset = "0x2352A08", VA = "0x2352A08", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x2352B08", Offset = "0x2352B08", VA = "0x2352B08", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x2352C24", Offset = "0x2352C24", VA = "0x2352C24", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x2352C70", Offset = "0x2352C70", VA = "0x2352C70", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x2352CD0", Offset = "0x2352CD0", VA = "0x2352CD0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x2353098", Offset = "0x2353098", VA = "0x2353098")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x23530EC", Offset = "0x23530EC", VA = "0x23530EC")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x23534A8", Offset = "0x23534A8", VA = "0x23534A8")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x2353610", Offset = "0x2353610", VA = "0x2353610", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2353778", Offset = "0x2353778", VA = "0x2353778")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x23536EC", Offset = "0x23536EC", VA = "0x23536EC")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x235387C", Offset = "0x235387C", VA = "0x235387C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x2354054", Offset = "0x2354054", VA = "0x2354054", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x2354058", Offset = "0x2354058", VA = "0x2354058", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x235405C", Offset = "0x235405C", VA = "0x235405C", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x2353E6C", Offset = "0x2353E6C", VA = "0x2353E6C")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x23505E8", Offset = "0x23505E8", VA = "0x23505E8")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CC")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000CD")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20000CE")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000589")]
				YawPitch,
				[Token(Token = "0x400058A")]
				FromTo
			}

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6ED0", Offset = "0x9B6ED0")]
			public Transform target;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6F08", Offset = "0x9B6F08")]
			public Transform bendGoal;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6F40", Offset = "0x9B6F40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6F40", Offset = "0x9B6F40")]
			public float positionWeight;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6F94", Offset = "0x9B6F94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6F94", Offset = "0x9B6F94")]
			public float rotationWeight;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6FE8", Offset = "0x9B6FE8")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7020", Offset = "0x9B7020")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7020", Offset = "0x9B7020")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7074", Offset = "0x9B7074")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7074", Offset = "0x9B7074")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B70C8", Offset = "0x9B70C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B70C8", Offset = "0x9B70C8")]
			public float bendGoalWeight;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B711C", Offset = "0x9B711C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B711C", Offset = "0x9B711C")]
			public float swivelOffset;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7178", Offset = "0x9B7178")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B71B0", Offset = "0x9B71B0")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B71E8", Offset = "0x9B71E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B71E8", Offset = "0x9B71E8")]
			public float armLengthMlp;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7240", Offset = "0x9B7240")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B72B8", Offset = "0x9B72B8")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B72C8", Offset = "0x9B72C8")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x4000586")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000587")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000D8")]
			public Vector3 position
			{
				[Token(Token = "0x60005EF")]
				[Address(RVA = "0x1E3DCA0", Offset = "0x1E3DCA0", VA = "0x1E3DCA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE590", Offset = "0x9BE590")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005F0")]
				[Address(RVA = "0x1E3DCAC", Offset = "0x1E3DCAC", VA = "0x1E3DCAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE5A0", Offset = "0x9BE5A0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D9")]
			public Quaternion rotation
			{
				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x1E3DCB8", Offset = "0x1E3DCB8", VA = "0x1E3DCB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE5B0", Offset = "0x9BE5B0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60005F2")]
				[Address(RVA = "0x1E3DCC4", Offset = "0x1E3DCC4", VA = "0x1E3DCC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE5C0", Offset = "0x9BE5C0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DA")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60005F3")]
				[Address(RVA = "0x1E3DCD0", Offset = "0x1E3DCD0", VA = "0x1E3DCD0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60005F4")]
				[Address(RVA = "0x1E3DD04", Offset = "0x1E3DD04", VA = "0x1E3DD04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DC")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60005F5")]
				[Address(RVA = "0x1E3DD44", Offset = "0x1E3DD44", VA = "0x1E3DD44")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private VirtualBone hand
			{
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0x1E3DD90", Offset = "0x1E3DD90", VA = "0x1E3DD90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x1E3DDDC", Offset = "0x1E3DDDC", VA = "0x1E3DDDC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x1E3E604", Offset = "0x1E3E604", VA = "0x1E3E604", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x1E3E7C0", Offset = "0x1E3E7C0", VA = "0x1E3E7C0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x1E3E7E4", Offset = "0x1E3E7E4", VA = "0x1E3E7E4")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x1E3EA84", Offset = "0x1E3EA84", VA = "0x1E3EA84")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x1E3FFE0", Offset = "0x1E3FFE0", VA = "0x1E3FFE0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x1E4000C", Offset = "0x1E4000C", VA = "0x1E4000C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x1E3FA1C", Offset = "0x1E3FA1C", VA = "0x1E3FA1C")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x1E3FA98", Offset = "0x1E3FA98", VA = "0x1E3FA98")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x1E4022C", Offset = "0x1E4022C", VA = "0x1E4022C")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x1E40350", Offset = "0x1E40350", VA = "0x1E40350")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CF")]
		public abstract class BodyPart
		{
			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B72D8", Offset = "0x9B72D8")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B72E8", Offset = "0x9B72E8")]
			private float <mag>k__BackingField;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x170000DE")]
			public float sqrMag
			{
				[Token(Token = "0x6000607")]
				[Address(RVA = "0x1E404A8", Offset = "0x1E404A8", VA = "0x1E404A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE5D0", Offset = "0x9BE5D0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000608")]
				[Address(RVA = "0x1E404B0", Offset = "0x1E404B0", VA = "0x1E404B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE5E0", Offset = "0x9BE5E0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DF")]
			public float mag
			{
				[Token(Token = "0x6000609")]
				[Address(RVA = "0x1E404B8", Offset = "0x1E404B8", VA = "0x1E404B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE5F0", Offset = "0x9BE5F0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600060A")]
				[Address(RVA = "0x1E404C0", Offset = "0x1E404C0", VA = "0x1E404C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE600", Offset = "0x9BE600")]
				private set
				{
				}
			}

			[Token(Token = "0x6000602")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000603")]
			public abstract void PreSolve();

			[Token(Token = "0x6000604")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000605")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000606")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1E404C8", Offset = "0x1E404C8", VA = "0x1E404C8")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1E404D0", Offset = "0x1E404D0", VA = "0x1E404D0")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1E405A4", Offset = "0x1E405A4", VA = "0x1E405A4")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x1E40638", Offset = "0x1E40638", VA = "0x1E40638")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x1E406E4", Offset = "0x1E406E4", VA = "0x1E406E4")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x1E40738", Offset = "0x1E40738", VA = "0x1E40738")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x1E3FE9C", Offset = "0x1E3FE9C", VA = "0x1E3FE9C")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x1E40874", Offset = "0x1E40874", VA = "0x1E40874")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x1E409B4", Offset = "0x1E409B4", VA = "0x1E409B4")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x1E40434", Offset = "0x1E40434", VA = "0x1E40434")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D0")]
		public class Footstep
		{
			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B7308", Offset = "0x9B7308")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000E0")]
			public bool isStepping
			{
				[Token(Token = "0x6000615")]
				[Address(RVA = "0x1E409DC", Offset = "0x1E409DC", VA = "0x1E409DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E1")]
			public float stepProgress
			{
				[Token(Token = "0x6000616")]
				[Address(RVA = "0x1E409F0", Offset = "0x1E409F0", VA = "0x1E409F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE610", Offset = "0x9BE610")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000617")]
				[Address(RVA = "0x1E409F8", Offset = "0x1E409F8", VA = "0x1E409F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE620", Offset = "0x9BE620")]
				private set
				{
				}
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x1E40A00", Offset = "0x1E40A00", VA = "0x1E40A00")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x1E40B38", Offset = "0x1E40B38", VA = "0x1E40B38")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x1E40B80", Offset = "0x1E40B80", VA = "0x1E40B80")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x1E40D44", Offset = "0x1E40D44", VA = "0x1E40D44")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0x1E40EB8", Offset = "0x1E40EB8", VA = "0x1E40EB8")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x1E41010", Offset = "0x1E41010", VA = "0x1E41010")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D1")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7318", Offset = "0x9B7318")]
			public Transform target;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7350", Offset = "0x9B7350")]
			public Transform bendGoal;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7388", Offset = "0x9B7388")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7388", Offset = "0x9B7388")]
			public float positionWeight;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B73DC", Offset = "0x9B73DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B73DC", Offset = "0x9B73DC")]
			public float rotationWeight;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7430", Offset = "0x9B7430")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7430", Offset = "0x9B7430")]
			public float bendGoalWeight;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7484", Offset = "0x9B7484")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7484", Offset = "0x9B7484")]
			public float swivelOffset;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B74E0", Offset = "0x9B74E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B74E0", Offset = "0x9B74E0")]
			public float bendToTargetWeight;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7534", Offset = "0x9B7534")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7534", Offset = "0x9B7534")]
			public float legLengthMlp;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B758C", Offset = "0x9B758C")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B7634", Offset = "0x9B7634")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B7644", Offset = "0x9B7644")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B7654", Offset = "0x9B7654")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B7664", Offset = "0x9B7664")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000E2")]
			public Vector3 position
			{
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x1E4114C", Offset = "0x1E4114C", VA = "0x1E4114C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE630", Offset = "0x9BE630")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600061F")]
				[Address(RVA = "0x1E41158", Offset = "0x1E41158", VA = "0x1E41158")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE640", Offset = "0x9BE640")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E3")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000620")]
				[Address(RVA = "0x1E41164", Offset = "0x1E41164", VA = "0x1E41164")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE650", Offset = "0x9BE650")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000621")]
				[Address(RVA = "0x1E41170", Offset = "0x1E41170", VA = "0x1E41170")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE660", Offset = "0x9BE660")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E4")]
			public bool hasToes
			{
				[Token(Token = "0x6000622")]
				[Address(RVA = "0x1E4117C", Offset = "0x1E4117C", VA = "0x1E4117C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE670", Offset = "0x9BE670")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000623")]
				[Address(RVA = "0x1E41184", Offset = "0x1E41184", VA = "0x1E41184")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE680", Offset = "0x9BE680")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E5")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000624")]
				[Address(RVA = "0x1E41190", Offset = "0x1E41190", VA = "0x1E41190")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E6")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000625")]
				[Address(RVA = "0x1E411C4", Offset = "0x1E411C4", VA = "0x1E411C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E7")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000626")]
				[Address(RVA = "0x1E411FC", Offset = "0x1E411FC", VA = "0x1E411FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E8")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000627")]
				[Address(RVA = "0x1E41234", Offset = "0x1E41234", VA = "0x1E41234")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E9")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000628")]
				[Address(RVA = "0x1E4126C", Offset = "0x1E4126C", VA = "0x1E4126C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000629")]
				[Address(RVA = "0x1E412AC", Offset = "0x1E412AC", VA = "0x1E412AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE690", Offset = "0x9BE690")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600062A")]
				[Address(RVA = "0x1E412B8", Offset = "0x1E412B8", VA = "0x1E412B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE6A0", Offset = "0x9BE6A0")]
				private set
				{
				}
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x1E412C4", Offset = "0x1E412C4", VA = "0x1E412C4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x1E418F8", Offset = "0x1E418F8", VA = "0x1E418F8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x1E41EB4", Offset = "0x1E41EB4", VA = "0x1E41EB4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x1E41E64", Offset = "0x1E41E64", VA = "0x1E41E64")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x1E41CF4", Offset = "0x1E41CF4", VA = "0x1E41CF4")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x1E4229C", Offset = "0x1E4229C", VA = "0x1E4229C")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x1E4274C", Offset = "0x1E4274C", VA = "0x1E4274C")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x1E4242C", Offset = "0x1E4242C", VA = "0x1E4242C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x1E42A44", Offset = "0x1E42A44", VA = "0x1E42A44", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x1E42C60", Offset = "0x1E42C60", VA = "0x1E42C60", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x1E42CAC", Offset = "0x1E42CAC", VA = "0x1E42CAC")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D2")]
		public class Locomotion
		{
			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7674", Offset = "0x9B7674")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7674", Offset = "0x9B7674")]
			public float weight;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B76C8", Offset = "0x9B76C8")]
			public float footDistance;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7700", Offset = "0x9B7700")]
			public float stepThreshold;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7738", Offset = "0x9B7738")]
			public float angleThreshold;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7770", Offset = "0x9B7770")]
			public float comAngleMlp;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B77A8", Offset = "0x9B77A8")]
			public float maxVelocity;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B77E0", Offset = "0x9B77E0")]
			public float velocityFactor;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7818", Offset = "0x9B7818")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7818", Offset = "0x9B7818")]
			public float maxLegStretch;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7870", Offset = "0x9B7870")]
			public float rootSpeed;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B78A8", Offset = "0x9B78A8")]
			public float stepSpeed;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B78E0", Offset = "0x9B78E0")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7918", Offset = "0x9B7918")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7950", Offset = "0x9B7950")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7950", Offset = "0x9B7950")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B79A8", Offset = "0x9B79A8")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B79E0", Offset = "0x9B79E0")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7A18", Offset = "0x9B7A18")]
			public Vector3 offset;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7A90", Offset = "0x9B7A90")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7AC8", Offset = "0x9B7AC8")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B7B00", Offset = "0x9B7B00")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000EB")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000636")]
				[Address(RVA = "0x215827C", Offset = "0x215827C", VA = "0x215827C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE6B0", Offset = "0x9BE6B0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000637")]
				[Address(RVA = "0x2158288", Offset = "0x2158288", VA = "0x2158288")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE6C0", Offset = "0x9BE6C0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EC")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600063D")]
				[Address(RVA = "0x2159DEC", Offset = "0x2159DEC", VA = "0x2159DEC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000ED")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600063E")]
				[Address(RVA = "0x2159E2C", Offset = "0x2159E2C", VA = "0x2159E2C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EE")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600063F")]
				[Address(RVA = "0x2159E70", Offset = "0x2159E70", VA = "0x2159E70")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000EF")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000640")]
				[Address(RVA = "0x2159EB0", Offset = "0x2159EB0", VA = "0x2159EB0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x2158294", Offset = "0x2158294", VA = "0x2158294")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x215853C", Offset = "0x215853C", VA = "0x215853C")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x2158714", Offset = "0x2158714", VA = "0x2158714")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x215895C", Offset = "0x215895C", VA = "0x215895C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x2158A20", Offset = "0x2158A20", VA = "0x2158A20")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x2159B44", Offset = "0x2159B44", VA = "0x2159B44")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x2159C7C", Offset = "0x2159C7C", VA = "0x2159C7C")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x2159D20", Offset = "0x2159D20", VA = "0x2159D20")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x2159EF4", Offset = "0x2159EF4", VA = "0x2159EF4")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D3")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7B10", Offset = "0x9B7B10")]
			public Transform headTarget;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7B48", Offset = "0x9B7B48")]
			public Transform pelvisTarget;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7B80", Offset = "0x9B7B80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7B80", Offset = "0x9B7B80")]
			public float positionWeight;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7BD4", Offset = "0x9B7BD4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7BD4", Offset = "0x9B7BD4")]
			public float rotationWeight;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7C28", Offset = "0x9B7C28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7C28", Offset = "0x9B7C28")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7C7C", Offset = "0x9B7C7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7C7C", Offset = "0x9B7C7C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7CD0", Offset = "0x9B7CD0")]
			public Transform chestGoal;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7D08", Offset = "0x9B7D08")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7D08", Offset = "0x9B7D08")]
			public float chestGoalWeight;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7D5C", Offset = "0x9B7D5C")]
			public float minHeadHeight;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7D94", Offset = "0x9B7D94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7D94", Offset = "0x9B7D94")]
			public float bodyPosStiffness;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7DE8", Offset = "0x9B7DE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7DE8", Offset = "0x9B7DE8")]
			public float bodyRotStiffness;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7E3C", Offset = "0x9B7E3C")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B7E3C", Offset = "0x9B7E3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7E3C", Offset = "0x9B7E3C")]
			public float neckStiffness;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7EB4", Offset = "0x9B7EB4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7EB4", Offset = "0x9B7EB4")]
			public float rotateChestByHands;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7F08", Offset = "0x9B7F08")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7F08", Offset = "0x9B7F08")]
			public float chestClampWeight;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7F5C", Offset = "0x9B7F5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7F5C", Offset = "0x9B7F5C")]
			public float headClampWeight;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7FB0", Offset = "0x9B7FB0")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B7FE8", Offset = "0x9B7FE8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B7FE8", Offset = "0x9B7FE8")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B803C", Offset = "0x9B803C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B803C", Offset = "0x9B803C")]
			public float maxRootAngle;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8094", Offset = "0x9B8094")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B8094", Offset = "0x9B8094")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B81D0", Offset = "0x9B81D0")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B81E0", Offset = "0x9B81E0")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x170000F0")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000645")]
				[Address(RVA = "0x2159AC4", Offset = "0x2159AC4", VA = "0x2159AC4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F1")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000646")]
				[Address(RVA = "0x2159FE0", Offset = "0x2159FE0", VA = "0x2159FE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F2")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000647")]
				[Address(RVA = "0x215A020", Offset = "0x215A020", VA = "0x215A020")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F3")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000648")]
				[Address(RVA = "0x215A074", Offset = "0x215A074", VA = "0x215A074")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F4")]
			public VirtualBone head
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0x2159B04", Offset = "0x2159B04", VA = "0x2159B04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F5")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600064A")]
				[Address(RVA = "0x215A0B4", Offset = "0x215A0B4", VA = "0x215A0B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE6D0", Offset = "0x9BE6D0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600064B")]
				[Address(RVA = "0x215A0C8", Offset = "0x215A0C8", VA = "0x215A0C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE6E0", Offset = "0x9BE6E0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F6")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x600064C")]
				[Address(RVA = "0x215A0DC", Offset = "0x215A0DC", VA = "0x215A0DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE6F0", Offset = "0x9BE6F0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600064D")]
				[Address(RVA = "0x215A0F0", Offset = "0x215A0F0", VA = "0x215A0F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE700", Offset = "0x9BE700")]
				private set
				{
				}
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x215A104", Offset = "0x215A104", VA = "0x215A104", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x215ABAC", Offset = "0x215ABAC", VA = "0x215ABAC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x215ADB8", Offset = "0x215ADB8", VA = "0x215ADB8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x215B1FC", Offset = "0x215B1FC", VA = "0x215B1FC")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x215B638", Offset = "0x215B638", VA = "0x215B638")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x215BD90", Offset = "0x215BD90", VA = "0x215BD90")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x215C414", Offset = "0x215C414", VA = "0x215C414")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x215CE18", Offset = "0x215CE18", VA = "0x215CE18", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x215CFF4", Offset = "0x215CFF4", VA = "0x215CFF4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x215B394", Offset = "0x215B394", VA = "0x215B394")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x215C160", Offset = "0x215C160", VA = "0x215C160")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x215BA48", Offset = "0x215BA48", VA = "0x215BA48")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x215D08C", Offset = "0x215D08C", VA = "0x215D08C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x215C240", Offset = "0x215C240", VA = "0x215C240")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x215BF0C", Offset = "0x215BF0C", VA = "0x215BF0C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x215D3B4", Offset = "0x215D3B4", VA = "0x215D3B4")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D4")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000610")]
			Pelvis,
			[Token(Token = "0x4000611")]
			Chest,
			[Token(Token = "0x4000612")]
			Head,
			[Token(Token = "0x4000613")]
			LeftHand,
			[Token(Token = "0x4000614")]
			RightHand,
			[Token(Token = "0x4000615")]
			LeftFoot,
			[Token(Token = "0x4000616")]
			RightFoot,
			[Token(Token = "0x4000617")]
			LeftHeel,
			[Token(Token = "0x4000618")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000D5")]
		public enum RotationOffset
		{
			[Token(Token = "0x400061A")]
			Pelvis,
			[Token(Token = "0x400061B")]
			Chest,
			[Token(Token = "0x400061C")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000D6")]
		public class VirtualBone
		{
			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x215AB10", Offset = "0x215AB10", VA = "0x215AB10")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x215AB8C", Offset = "0x215AB8C", VA = "0x215AB8C")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x215D528", Offset = "0x215D528", VA = "0x215D528")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x215D6AC", Offset = "0x215D6AC", VA = "0x215D6AC")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x215D28C", Offset = "0x215D28C", VA = "0x215D28C")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x215D89C", Offset = "0x215D89C", VA = "0x215D89C")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x215D9FC", Offset = "0x215D9FC", VA = "0x215D9FC")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x215DB38", Offset = "0x215DB38", VA = "0x215DB38")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x215CA14", Offset = "0x215CA14", VA = "0x215CA14")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x215DBF0", Offset = "0x215DBF0", VA = "0x215DBF0")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x215C684", Offset = "0x215C684", VA = "0x215C684")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x215DD58", Offset = "0x215DD58", VA = "0x215DD58")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x215DDC8", Offset = "0x215DDC8", VA = "0x215DDC8")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B6CE4", Offset = "0x9B6CE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6CE4", Offset = "0x9B6CE4")]
		public int LOD;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6D38", Offset = "0x9B6D38")]
		public bool plantFeet;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B6D70", Offset = "0x9B6D70")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6D80", Offset = "0x9B6D80")]
		public Spine spine;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6DB8", Offset = "0x9B6DB8")]
		public Arm leftArm;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6DF0", Offset = "0x9B6DF0")]
		public Arm rightArm;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6E28", Offset = "0x9B6E28")]
		public Leg leftLeg;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6E60", Offset = "0x9B6E60")]
		public Leg rightLeg;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B6E98", Offset = "0x9B6E98")]
		public Locomotion locomotion;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x170000D7")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x2077FE0", Offset = "0x2077FE0", VA = "0x2077FE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE570", Offset = "0x9BE570")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x2077FE8", Offset = "0x2077FE8", VA = "0x2077FE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE580", Offset = "0x9BE580")]
			private set
			{
			}
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x2074478", Offset = "0x2074478", VA = "0x2074478")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x20748DC", Offset = "0x20748DC", VA = "0x20748DC")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x2074788", Offset = "0x2074788", VA = "0x2074788")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x207503C", Offset = "0x207503C", VA = "0x207503C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x2075180", Offset = "0x2075180", VA = "0x2075180")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x20751B0", Offset = "0x20751B0", VA = "0x20751B0")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x2075260", Offset = "0x2075260", VA = "0x2075260")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x2075348", Offset = "0x2075348", VA = "0x2075348")]
		public void Reset()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x2075AAC", Offset = "0x2075AAC", VA = "0x2075AAC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x2075C1C", Offset = "0x2075C1C", VA = "0x2075C1C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x2075E20", Offset = "0x2075E20", VA = "0x2075E20", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x2075E9C", Offset = "0x2075E9C", VA = "0x2075E9C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x2075F18", Offset = "0x2075F18", VA = "0x2075F18", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x20760F0", Offset = "0x20760F0", VA = "0x20760F0")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x2074B10", Offset = "0x2074B10", VA = "0x2074B10")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x2074C00", Offset = "0x2074C00", VA = "0x2074C00")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x2074F1C", Offset = "0x2074F1C", VA = "0x2074F1C")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x207543C", Offset = "0x207543C", VA = "0x207543C")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x20762B0", Offset = "0x20762B0", VA = "0x20762B0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x20762F8", Offset = "0x20762F8", VA = "0x20762F8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x2077710", Offset = "0x2077710", VA = "0x2077710")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x20755A0", Offset = "0x20755A0", VA = "0x20755A0")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x207666C", Offset = "0x207666C", VA = "0x207666C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x2077AC0", Offset = "0x2077AC0", VA = "0x2077AC0")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x2077B08", Offset = "0x2077B08", VA = "0x2077B08")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x20775C0", Offset = "0x20775C0", VA = "0x20775C0")]
		private void Write()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x2077B4C", Offset = "0x2077B4C", VA = "0x2077B4C")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x2077FF0", Offset = "0x2077FF0", VA = "0x2077FF0")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B81F0", Offset = "0x9B81F0")]
		public Transform parent;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8228", Offset = "0x9B8228")]
		public Transform child;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8260", Offset = "0x9B8260")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B8260", Offset = "0x9B8260")]
		public float weight;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B82B4", Offset = "0x9B82B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B82B4", Offset = "0x9B82B4")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B8308", Offset = "0x9B8308")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8308", Offset = "0x9B8308")]
		public float twistAngleOffset;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x19C3ACC", Offset = "0x19C3ACC", VA = "0x19C3ACC")]
		public void Relax()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x19C3DE8", Offset = "0x19C3DE8", VA = "0x19C3DE8")]
		private void Start()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x19C41A8", Offset = "0x19C41A8", VA = "0x19C41A8")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x19C422C", Offset = "0x19C422C", VA = "0x19C422C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x19C42B0", Offset = "0x19C42B0", VA = "0x19C42B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x19C43C8", Offset = "0x19C43C8", VA = "0x19C43C8")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D8")]
	public class InteractionEffector
	{
		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8364", Offset = "0x9B8364")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8374", Offset = "0x9B8374")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8384", Offset = "0x9B8384")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x170000F7")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x2078FA4", Offset = "0x2078FA4", VA = "0x2078FA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE710", Offset = "0x9BE710")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x2078FAC", Offset = "0x2078FAC", VA = "0x2078FAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE720", Offset = "0x9BE720")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public bool isPaused
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x2078FB4", Offset = "0x2078FB4", VA = "0x2078FB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE730", Offset = "0x9BE730")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x2078FBC", Offset = "0x2078FBC", VA = "0x2078FBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE740", Offset = "0x9BE740")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x2078FC8", Offset = "0x2078FC8", VA = "0x2078FC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE750", Offset = "0x9BE750")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x2078FD0", Offset = "0x2078FD0", VA = "0x2078FD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE760", Offset = "0x9BE760")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public bool inInteraction
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x2078FD8", Offset = "0x2078FD8", VA = "0x2078FD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FB")]
		public float progress
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x207B3A8", Offset = "0x207B3A8", VA = "0x207B3A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x2079044", Offset = "0x2079044", VA = "0x2079044")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x20790D0", Offset = "0x20790D0", VA = "0x20790D0")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x2079170", Offset = "0x2079170", VA = "0x2079170")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x20792E8", Offset = "0x20792E8", VA = "0x20792E8")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x207964C", Offset = "0x207964C", VA = "0x207964C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x2079708", Offset = "0x2079708", VA = "0x2079708")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x2079760", Offset = "0x2079760", VA = "0x2079760")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x207A150", Offset = "0x207A150", VA = "0x207A150")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x207ABB8", Offset = "0x207ABB8", VA = "0x207ABB8")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x207ADFC", Offset = "0x207ADFC", VA = "0x207ADFC")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x207B254", Offset = "0x207B254", VA = "0x207B254")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x207B508", Offset = "0x207B508", VA = "0x207B508")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D9")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8394", Offset = "0x9B8394")]
		public LookAtIK ik;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B83CC", Offset = "0x9B83CC")]
		public float lerpSpeed;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8404", Offset = "0x9B8404")]
		public float weightSpeed;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x207B6F8", Offset = "0x207B6F8", VA = "0x207B6F8")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x207B814", Offset = "0x207B814", VA = "0x207B814")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x207B8B8", Offset = "0x207B8B8", VA = "0x207B8B8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x207BEF0", Offset = "0x207BEF0", VA = "0x207BEF0")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x207BFE4", Offset = "0x207BFE4", VA = "0x207BFE4")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x207C0AC", Offset = "0x207C0AC", VA = "0x207C0AC")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3574", Offset = "0x9B3574")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3574", Offset = "0x9B3574")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8514", Offset = "0x9B8514")]
			public float time;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B854C", Offset = "0x9B854C")]
			public bool pause;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8584", Offset = "0x9B8584")]
			public bool pickUp;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B85BC", Offset = "0x9B85BC")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B85F4", Offset = "0x9B85F4")]
			public Message[] messages;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B862C", Offset = "0x9B862C")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x215E574", Offset = "0x215E574", VA = "0x215E574")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x215E748", Offset = "0x215E748", VA = "0x215E748")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DC")]
		public class Message
		{
			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8664", Offset = "0x9B8664")]
			public string function;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B869C", Offset = "0x9B869C")]
			public GameObject recipient;

			[Token(Token = "0x400066B")]
			private const string empty = "";

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x215E644", Offset = "0x215E644", VA = "0x215E644")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x215E750", Offset = "0x215E750", VA = "0x215E750")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DD")]
		public class AnimatorEvent
		{
			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B86D4", Offset = "0x9B86D4")]
			public Animator animator;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B870C", Offset = "0x9B870C")]
			public Animation animation;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8744", Offset = "0x9B8744")]
			public string animationState;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B877C", Offset = "0x9B877C")]
			public float crossfadeTime;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B87B4", Offset = "0x9B87B4")]
			public int layer;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B87EC", Offset = "0x9B87EC")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000672")]
			private const string empty = "";

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x215E2E0", Offset = "0x215E2E0", VA = "0x215E2E0")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x215E3D0", Offset = "0x215E3D0", VA = "0x215E3D0")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x215E484", Offset = "0x215E484", VA = "0x215E484")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x215E560", Offset = "0x215E560", VA = "0x215E560")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DE")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000DF")]
			public enum Type
			{
				[Token(Token = "0x4000676")]
				PositionWeight,
				[Token(Token = "0x4000677")]
				RotationWeight,
				[Token(Token = "0x4000678")]
				PositionOffsetX,
				[Token(Token = "0x4000679")]
				PositionOffsetY,
				[Token(Token = "0x400067A")]
				PositionOffsetZ,
				[Token(Token = "0x400067B")]
				Pull,
				[Token(Token = "0x400067C")]
				Reach,
				[Token(Token = "0x400067D")]
				RotateBoneWeight,
				[Token(Token = "0x400067E")]
				Push,
				[Token(Token = "0x400067F")]
				PushParent,
				[Token(Token = "0x4000680")]
				PoserWeight,
				[Token(Token = "0x4000681")]
				BendGoalWeight
			}

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8824", Offset = "0x9B8824")]
			public Type type;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B885C", Offset = "0x9B885C")]
			public AnimationCurve curve;

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x215E794", Offset = "0x215E794", VA = "0x215E794")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x215E7C0", Offset = "0x215E7C0", VA = "0x215E7C0")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Multiplier
		{
			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8894", Offset = "0x9B8894")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B88CC", Offset = "0x9B88CC")]
			public float multiplier;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8904", Offset = "0x9B8904")]
			public WeightCurve.Type result;

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x215E758", Offset = "0x215E758", VA = "0x215E758")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x215E7B0", Offset = "0x215E7B0", VA = "0x215E7B0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B844C", Offset = "0x9B844C")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8484", Offset = "0x9B8484")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B84BC", Offset = "0x9B84BC")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B84F4", Offset = "0x9B84F4")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8504", Offset = "0x9B8504")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000FC")]
		public float length
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x207C300", Offset = "0x207C300", VA = "0x207C300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE930", Offset = "0x9BE930")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x207C308", Offset = "0x207C308", VA = "0x207C308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE940", Offset = "0x9BE940")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x207C310", Offset = "0x207C310", VA = "0x207C310")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE950", Offset = "0x9BE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x207C318", Offset = "0x207C318", VA = "0x207C318")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BE960", Offset = "0x9BE960")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x207C4E0", Offset = "0x207C4E0", VA = "0x207C4E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FF")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x207B3E4", Offset = "0x207B3E4", VA = "0x207B3E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x207C0C0", Offset = "0x207C0C0", VA = "0x207C0C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE770", Offset = "0x9BE770")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x207C108", Offset = "0x207C108", VA = "0x207C108")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE7A8", Offset = "0x9BE7A8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x207C150", Offset = "0x207C150", VA = "0x207C150")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE7E0", Offset = "0x9BE7E0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x207C198", Offset = "0x207C198", VA = "0x207C198")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE818", Offset = "0x9BE818")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x207C1E0", Offset = "0x207C1E0", VA = "0x207C1E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE850", Offset = "0x9BE850")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x207C228", Offset = "0x207C228", VA = "0x207C228")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE888", Offset = "0x9BE888")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x207C270", Offset = "0x207C270", VA = "0x207C270")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE8C0", Offset = "0x9BE8C0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x207C2B8", Offset = "0x207C2B8", VA = "0x207C2B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE8F8", Offset = "0x9BE8F8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x207C320", Offset = "0x207C320", VA = "0x207C320")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x207C56C", Offset = "0x207C56C", VA = "0x207C56C")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x2079CC8", Offset = "0x2079CC8", VA = "0x2079CC8")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x207C6F8", Offset = "0x207C6F8", VA = "0x207C6F8")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x2079B74", Offset = "0x2079B74", VA = "0x2079B74")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x2079CC0", Offset = "0x2079CC0", VA = "0x2079CC0")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x207A75C", Offset = "0x207A75C", VA = "0x207A75C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x207B034", Offset = "0x207B034", VA = "0x207B034")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x207CCDC", Offset = "0x207CCDC", VA = "0x207CCDC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x207C7E0", Offset = "0x207C7E0", VA = "0x207C7E0")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x207C700", Offset = "0x207C700", VA = "0x207C700")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x207CC74", Offset = "0x207CC74", VA = "0x207CC74")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x207CCE0", Offset = "0x207CCE0", VA = "0x207CCE0")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x207CD48", Offset = "0x207CD48", VA = "0x207CD48")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B35D4", Offset = "0x9B35D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B35D4", Offset = "0x9B35D4")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000E2")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000E3")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B893C", Offset = "0x9B893C")]
		public string targetTag;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8974", Offset = "0x9B8974")]
		public float fadeInTime;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B89AC", Offset = "0x9B89AC")]
		public float speed;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B89E4", Offset = "0x9B89E4")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B8A1C", Offset = "0x9B8A1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8A1C", Offset = "0x9B8A1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B8A1C", Offset = "0x9B8A1C")]
		public Collider characterCollider;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9B8AA0", Offset = "0x9B8AA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8AA0", Offset = "0x9B8AA0")]
		public Transform FPSCamera;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8B00", Offset = "0x9B8B00")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8B38", Offset = "0x9B8B38")]
		public float camRaycastDistance;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B8B70", Offset = "0x9B8B70")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9B8B80", Offset = "0x9B8B80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8B80", Offset = "0x9B8B80")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8BE0", Offset = "0x9B8BE0")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000100")]
		public bool inInteraction
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x2078E7C", Offset = "0x2078E7C", VA = "0x2078E7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000101")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x207EA58", Offset = "0x207EA58", VA = "0x207EA58")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x207EA60", Offset = "0x207EA60", VA = "0x207EA60")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x207EA68", Offset = "0x207EA68", VA = "0x207EA68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEB30", Offset = "0x9BEB30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x207EA70", Offset = "0x207EA70", VA = "0x207EA70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEB40", Offset = "0x9BEB40")]
			private set
			{
			}
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x207CDA4", Offset = "0x207CDA4", VA = "0x207CDA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE970", Offset = "0x9BE970")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x207CDEC", Offset = "0x207CDEC", VA = "0x207CDEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE9A8", Offset = "0x9BE9A8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x207CE34", Offset = "0x207CE34", VA = "0x207CE34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BE9E0", Offset = "0x9BE9E0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x207CE7C", Offset = "0x207CE7C", VA = "0x207CE7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEA18", Offset = "0x9BEA18")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x207CEC4", Offset = "0x207CEC4", VA = "0x207CEC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEA50", Offset = "0x9BEA50")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x207CF0C", Offset = "0x207CF0C", VA = "0x207CF0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEA88", Offset = "0x9BEA88")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x207CF54", Offset = "0x207CF54", VA = "0x207CF54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEAC0", Offset = "0x9BEAC0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x207CF9C", Offset = "0x207CF9C", VA = "0x207CF9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEAF8", Offset = "0x9BEAF8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x207D0DC", Offset = "0x207D0DC", VA = "0x207D0DC")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x207D1A8", Offset = "0x207D1A8", VA = "0x207D1A8")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x207D274", Offset = "0x207D274", VA = "0x207D274")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x207D320", Offset = "0x207D320", VA = "0x207D320")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x207855C", Offset = "0x207855C", VA = "0x207855C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x207D418", Offset = "0x207D418", VA = "0x207D418")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x207D4A8", Offset = "0x207D4A8", VA = "0x207D4A8")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x207D538", Offset = "0x207D538", VA = "0x207D538")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x207D5C8", Offset = "0x207D5C8", VA = "0x207D5C8")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x2078F28", Offset = "0x2078F28", VA = "0x2078F28")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x207D63C", Offset = "0x207D63C", VA = "0x207D63C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x207D6A4", Offset = "0x207D6A4", VA = "0x207D6A4")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x207D730", Offset = "0x207D730", VA = "0x207D730")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x207D7E4", Offset = "0x207D7E4", VA = "0x207D7E4")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x207D8C8", Offset = "0x207D8C8", VA = "0x207D8C8")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x207DBA0", Offset = "0x207DBA0", VA = "0x207DBA0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x207DD80", Offset = "0x207DD80", VA = "0x207DD80")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x207E014", Offset = "0x207E014", VA = "0x207E014")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x207E2EC", Offset = "0x207E2EC", VA = "0x207E2EC")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x207E330", Offset = "0x207E330", VA = "0x207E330")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x207E3A8", Offset = "0x207E3A8", VA = "0x207E3A8")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x207E4C4", Offset = "0x207E4C4", VA = "0x207E4C4")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x207E668", Offset = "0x207E668", VA = "0x207E668")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x207E90C", Offset = "0x207E90C", VA = "0x207E90C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x207E128", Offset = "0x207E128", VA = "0x207E128")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x207EA78", Offset = "0x207EA78", VA = "0x207EA78")]
		public void Start()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x207F1E4", Offset = "0x207F1E4", VA = "0x207F1E4")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x207F204", Offset = "0x207F204", VA = "0x207F204")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x207F220", Offset = "0x207F220", VA = "0x207F220")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x207F23C", Offset = "0x207F23C", VA = "0x207F23C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x207F29C", Offset = "0x207F29C", VA = "0x207F29C")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x207F3D8", Offset = "0x207F3D8", VA = "0x207F3D8")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x207F4E8", Offset = "0x207F4E8", VA = "0x207F4E8")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x207F88C", Offset = "0x207F88C", VA = "0x207F88C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x207F98C", Offset = "0x207F98C", VA = "0x207F98C")]
		public void Update()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x207FC1C", Offset = "0x207FC1C", VA = "0x207FC1C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x207EF48", Offset = "0x207EF48", VA = "0x207EF48")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x207FD58", Offset = "0x207FD58", VA = "0x207FD58")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x207FE80", Offset = "0x207FE80", VA = "0x207FE80")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x207FF14", Offset = "0x207FF14", VA = "0x207FF14")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x207FFE8", Offset = "0x207FFE8", VA = "0x207FFE8")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x2080000", Offset = "0x2080000", VA = "0x2080000")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x207CFE4", Offset = "0x207CFE4", VA = "0x207CFE4")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x207DA70", Offset = "0x207DA70", VA = "0x207DA70")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x2080368", Offset = "0x2080368", VA = "0x2080368")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3634", Offset = "0x9B3634")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3634", Offset = "0x9B3634")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E5")]
		public class Multiplier
		{
			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8DD8", Offset = "0x9B8DD8")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8E10", Offset = "0x9B8E10")]
			public float multiplier;

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x215EEDC", Offset = "0x215EEDC", VA = "0x215EEDC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8C18", Offset = "0x9B8C18")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8C50", Offset = "0x9B8C50")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8C88", Offset = "0x9B8C88")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8CC0", Offset = "0x9B8CC0")]
		public Transform pivot;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8CF8", Offset = "0x9B8CF8")]
		public Vector3 twistAxis;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8D30", Offset = "0x9B8D30")]
		public float twistWeight;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8D68", Offset = "0x9B8D68")]
		public float swingWeight;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8DA0", Offset = "0x9B8DA0")]
		public bool rotateOnce;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x2080AA0", Offset = "0x2080AA0", VA = "0x2080AA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEB50", Offset = "0x9BEB50")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x2080AE8", Offset = "0x2080AE8", VA = "0x2080AE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEB88", Offset = "0x9BEB88")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x2080B30", Offset = "0x2080B30", VA = "0x2080B30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEBC0", Offset = "0x9BEBC0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x2080B78", Offset = "0x2080B78", VA = "0x2080B78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEBF8", Offset = "0x9BEBF8")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x2080BC0", Offset = "0x2080BC0", VA = "0x2080BC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEC30", Offset = "0x9BEC30")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x2080C08", Offset = "0x2080C08", VA = "0x2080C08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEC68", Offset = "0x9BEC68")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x2080C50", Offset = "0x2080C50", VA = "0x2080C50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BECA0", Offset = "0x9BECA0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x2080C98", Offset = "0x2080C98", VA = "0x2080C98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BECD8", Offset = "0x9BECD8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x207C770", Offset = "0x207C770", VA = "0x207C770")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x207B470", Offset = "0x207B470", VA = "0x207B470")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x2079D7C", Offset = "0x2079D7C", VA = "0x2079D7C")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x2080CE0", Offset = "0x2080CE0", VA = "0x2080CE0")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3694", Offset = "0x9B3694")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3694", Offset = "0x9B3694")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E7")]
		public class CharacterPosition
		{
			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8E80", Offset = "0x9B8E80")]
			public bool use;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8EB8", Offset = "0x9B8EB8")]
			public Vector2 offset;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8EF0", Offset = "0x9B8EF0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B8EF0", Offset = "0x9B8EF0")]
			public float angleOffset;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8F4C", Offset = "0x9B8F4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B8F4C", Offset = "0x9B8F4C")]
			public float maxAngle;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8FA4", Offset = "0x9B8FA4")]
			public float radius;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8FDC", Offset = "0x9B8FDC")]
			public bool orbit;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9014", Offset = "0x9B9014")]
			public bool fixYAxis;

			[Token(Token = "0x17000103")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600070A")]
				[Address(RVA = "0x215F24C", Offset = "0x215F24C", VA = "0x215F24C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000104")]
			public Vector3 direction3D
			{
				[Token(Token = "0x600070B")]
				[Address(RVA = "0x215F258", Offset = "0x215F258", VA = "0x215F258")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x215F2E0", Offset = "0x215F2E0", VA = "0x215F2E0")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x215F724", Offset = "0x215F724", VA = "0x215F724")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E8")]
		public class CameraPosition
		{
			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B904C", Offset = "0x9B904C")]
			public Collider lookAtTarget;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9084", Offset = "0x9B9084")]
			public Vector3 direction;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B90BC", Offset = "0x9B90BC")]
			public float maxDistance;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B90F4", Offset = "0x9B90F4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B90F4", Offset = "0x9B90F4")]
			public float maxAngle;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B914C", Offset = "0x9B914C")]
			public bool fixYAxis;

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x215EEE4", Offset = "0x215EEE4", VA = "0x215EEE4")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x215EFD8", Offset = "0x215EFD8", VA = "0x215EFD8")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x215F200", Offset = "0x215F200", VA = "0x215F200")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E9")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000EA")]
			public class Interaction
			{
				[Token(Token = "0x40006BB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B929C", Offset = "0x9B929C")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40006BC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B92D4", Offset = "0x9B92D4")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000713")]
				[Address(RVA = "0x21665A4", Offset = "0x21665A4", VA = "0x21665A4")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B91F4", Offset = "0x9B91F4")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B922C", Offset = "0x9B922C")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9264", Offset = "0x9B9264")]
			public Interaction[] interactions;

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x215F738", Offset = "0x215F738", VA = "0x215F738")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x215F7EC", Offset = "0x215F7EC", VA = "0x215F7EC")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B8E48", Offset = "0x9B8E48")]
		public Range[] ranges;

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x2080D28", Offset = "0x2080D28", VA = "0x2080D28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BED10", Offset = "0x9BED10")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x2080D70", Offset = "0x2080D70", VA = "0x2080D70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BED48", Offset = "0x9BED48")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x2080DB8", Offset = "0x2080DB8", VA = "0x2080DB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BED80", Offset = "0x9BED80")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x2080E00", Offset = "0x2080E00", VA = "0x2080E00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEDB8", Offset = "0x9BEDB8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x2080E48", Offset = "0x2080E48", VA = "0x2080E48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEDF0", Offset = "0x9BEDF0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x2080E90", Offset = "0x2080E90", VA = "0x2080E90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x207F6B8", Offset = "0x207F6B8", VA = "0x207F6B8")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x2080E94", Offset = "0x2080E94", VA = "0x2080E94")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000EC")]
		public class Map
		{
			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1E38B30", Offset = "0x1E38B30", VA = "0x1E38B30")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1E38B6C", Offset = "0x1E38B6C", VA = "0x1E38B6C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x1E38BBC", Offset = "0x1E38BBC", VA = "0x1E38BBC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x1E38C08", Offset = "0x1E38C08", VA = "0x1E38C08")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x2119034", Offset = "0x2119034", VA = "0x2119034", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEE28", Offset = "0x9BEE28")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x21193B0", Offset = "0x21193B0", VA = "0x21193B0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x21193B4", Offset = "0x21193B4", VA = "0x21193B4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x21194BC", Offset = "0x21194BC", VA = "0x21194BC", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x2119344", Offset = "0x2119344", VA = "0x2119344")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x21192A4", Offset = "0x21192A4", VA = "0x21192A4")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x2119528", Offset = "0x2119528", VA = "0x2119528")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x2120450", Offset = "0x2120450", VA = "0x2120450", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2120518", Offset = "0x2120518", VA = "0x2120518", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x21206D4", Offset = "0x21206D4", VA = "0x21206D4", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x21207D0", Offset = "0x21207D0", VA = "0x21207D0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x2120570", Offset = "0x2120570", VA = "0x2120570")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x2120B30", Offset = "0x2120B30", VA = "0x2120B30")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B930C", Offset = "0x9B930C")]
		public float weight;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9324", Offset = "0x9B9324")]
		public float localRotationWeight;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B933C", Offset = "0x9B933C")]
		public float localPositionWeight;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000725")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x19BA7C0", Offset = "0x19BA7C0", VA = "0x19BA7C0")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000727")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000728")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000729")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x19BA7CC", Offset = "0x19BA7CC", VA = "0x19BA7CC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x19BA820", Offset = "0x19BA820", VA = "0x19BA820", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x19BA85C", Offset = "0x19BA85C", VA = "0x19BA85C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x19BA874", Offset = "0x19BA874", VA = "0x19BA874")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B36F4", Offset = "0x9B36F4")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000F0")]
		public class Rigidbone
		{
			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x216275C", Offset = "0x216275C", VA = "0x216275C")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x21628CC", Offset = "0x21628CC", VA = "0x21628CC")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x21629AC", Offset = "0x21629AC", VA = "0x21629AC")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000F1")]
		public class Child
		{
			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x216256C", Offset = "0x216256C", VA = "0x216256C")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x21625CC", Offset = "0x21625CC", VA = "0x21625CC")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x216270C", Offset = "0x216270C", VA = "0x216270C")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3754", Offset = "0x9B3754")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000107")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000749")]
				[Address(RVA = "0x216251C", Offset = "0x216251C", VA = "0x216251C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000108")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600074B")]
				[Address(RVA = "0x2162564", Offset = "0x2162564", VA = "0x2162564", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x2162300", Offset = "0x2162300", VA = "0x2162300")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x216232C", Offset = "0x216232C", VA = "0x216232C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x2162330", Offset = "0x2162330", VA = "0x2162330", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0x2162524", Offset = "0x2162524", VA = "0x2162524", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9354", Offset = "0x9B9354")]
		public IK ik;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B938C", Offset = "0x9B938C")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B93C4", Offset = "0x9B93C4")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B93FC", Offset = "0x9B93FC")]
		public float applyVelocity;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9434", Offset = "0x9B9434")]
		public float applyAngularVelocity;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000105")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x19BB1A4", Offset = "0x19BB1A4", VA = "0x19BB1A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000106")]
		private bool ikUsed
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x19BBB2C", Offset = "0x19BBB2C", VA = "0x19BBB2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x19BB16C", Offset = "0x19BB16C", VA = "0x19BB16C")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x19BB21C", Offset = "0x19BB21C", VA = "0x19BB21C")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x19BB34C", Offset = "0x19BB34C", VA = "0x19BB34C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x19BB2E0", Offset = "0x19BB2E0", VA = "0x19BB2E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BEE60", Offset = "0x9BEE60")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x19BB768", Offset = "0x19BB768", VA = "0x19BB768")]
		private void Update()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x19BB9B4", Offset = "0x19BB9B4", VA = "0x19BB9B4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x19BBA70", Offset = "0x19BBA70", VA = "0x19BBA70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x19BBCAC", Offset = "0x19BBCAC", VA = "0x19BBCAC")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x19BBAF0", Offset = "0x19BBAF0", VA = "0x19BBAF0")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x19BBC68", Offset = "0x19BBC68", VA = "0x19BBC68")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x19BBD4C", Offset = "0x19BBD4C", VA = "0x19BBD4C")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x19BBCE0", Offset = "0x19BBCE0", VA = "0x19BBCE0")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x19BB274", Offset = "0x19BB274", VA = "0x19BB274")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x19BB9F4", Offset = "0x19BB9F4", VA = "0x19BB9F4")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x19BBF78", Offset = "0x19BBF78", VA = "0x19BBF78")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x19BC090", Offset = "0x19BC090", VA = "0x19BC090")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B947C", Offset = "0x9B947C")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000109")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x19BD8B4", Offset = "0x19BD8B4", VA = "0x19BD8B4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700010A")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x19BD8C0", Offset = "0x19BD8C0", VA = "0x19BD8C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700010B")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x19BD8DC", Offset = "0x19BD8DC", VA = "0x19BD8DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF10", Offset = "0x9BEF10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x19BD8E4", Offset = "0x19BD8E4", VA = "0x19BD8E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BEF20", Offset = "0x9BEF20")]
			private set
			{
			}
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x19BD5B4", Offset = "0x19BD5B4", VA = "0x19BD5B4")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x19BD5FC", Offset = "0x19BD5FC", VA = "0x19BD5FC")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x19BD614", Offset = "0x19BD614", VA = "0x19BD614")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x19BD80C", Offset = "0x19BD80C", VA = "0x19BD80C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x19BD87C", Offset = "0x19BD87C", VA = "0x19BD87C")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000755")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x19BD734", Offset = "0x19BD734", VA = "0x19BD734")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x19BD8F0", Offset = "0x19BD8F0", VA = "0x19BD8F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x19BD8F4", Offset = "0x19BD8F4", VA = "0x19BD8F4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x19BD928", Offset = "0x19BD928", VA = "0x19BD928")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x19BD9A4", Offset = "0x19BD9A4", VA = "0x19BD9A4")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x19BDB38", Offset = "0x19BDB38", VA = "0x19BDB38")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x19BDBA8", Offset = "0x19BDBA8", VA = "0x19BDBA8")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3764", Offset = "0x9B3764")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3764", Offset = "0x9B3764")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B948C", Offset = "0x9B948C")]
		public float limit;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B94A8", Offset = "0x9B94A8")]
		public float twistLimit;

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x19BDBDC", Offset = "0x19BDBDC", VA = "0x19BDBDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEF30", Offset = "0x9BEF30")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x19BDC24", Offset = "0x19BDC24", VA = "0x19BDC24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEF68", Offset = "0x9BEF68")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x19BDC6C", Offset = "0x19BDC6C", VA = "0x19BDC6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEFA0", Offset = "0x9BEFA0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x19BDCB4", Offset = "0x19BDCB4", VA = "0x19BDCB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BEFD8", Offset = "0x9BEFD8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x19BDCFC", Offset = "0x19BDCFC", VA = "0x19BDCFC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x19BDD40", Offset = "0x19BDD40", VA = "0x19BDD40")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x19BDF00", Offset = "0x19BDF00", VA = "0x19BDF00")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B37C4", Offset = "0x9B37C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B37C4", Offset = "0x9B37C4")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastAngle;

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x19BDF40", Offset = "0x19BDF40", VA = "0x19BDF40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BF010", Offset = "0x9BF010")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x19BDF88", Offset = "0x19BDF88", VA = "0x19BDF88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BF048", Offset = "0x9BF048")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x19BDFD0", Offset = "0x19BDFD0", VA = "0x19BDFD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BF080", Offset = "0x9BF080")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x19BE018", Offset = "0x19BE018", VA = "0x19BE018")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BF0B8", Offset = "0x9BF0B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x19BE060", Offset = "0x19BE060", VA = "0x19BE060", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x19BE088", Offset = "0x19BE088", VA = "0x19BE088")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x19BE284", Offset = "0x19BE284", VA = "0x19BE284")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3824", Offset = "0x9B3824")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3824", Offset = "0x9B3824")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000F7")]
		public class ReachCone
		{
			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x1700010C")]
			public Vector3 o
			{
				[Token(Token = "0x600077B")]
				[Address(RVA = "0x2162FE0", Offset = "0x2162FE0", VA = "0x2162FE0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010D")]
			public Vector3 a
			{
				[Token(Token = "0x600077C")]
				[Address(RVA = "0x2163018", Offset = "0x2163018", VA = "0x2163018")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010E")]
			public Vector3 b
			{
				[Token(Token = "0x600077D")]
				[Address(RVA = "0x2163054", Offset = "0x2163054", VA = "0x2163054")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010F")]
			public Vector3 c
			{
				[Token(Token = "0x600077E")]
				[Address(RVA = "0x2163090", Offset = "0x2163090", VA = "0x2163090")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000110")]
			public bool isValid
			{
				[Token(Token = "0x6000780")]
				[Address(RVA = "0x2163208", Offset = "0x2163208", VA = "0x2163208")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600077F")]
			[Address(RVA = "0x21630CC", Offset = "0x21630CC", VA = "0x21630CC")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000781")]
			[Address(RVA = "0x2163218", Offset = "0x2163218", VA = "0x2163218")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F8")]
		public class LimitPoint
		{
			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000782")]
			[Address(RVA = "0x2162FA4", Offset = "0x2162FA4", VA = "0x2162FA4")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B94D4", Offset = "0x9B94D4")]
		public float twistLimit;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B94F0", Offset = "0x9B94F0")]
		public int smoothIterations;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		public ReachCone[] reachCones;

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x19BE2DC", Offset = "0x19BE2DC", VA = "0x19BE2DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BF0F0", Offset = "0x9BF0F0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x19BE324", Offset = "0x19BE324", VA = "0x19BE324")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BF128", Offset = "0x9BF128")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x19BE36C", Offset = "0x19BE36C", VA = "0x19BE36C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BF160", Offset = "0x9BF160")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x19BE3B4", Offset = "0x19BE3B4", VA = "0x19BE3B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BF198", Offset = "0x9BF198")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x19BE3FC", Offset = "0x19BE3FC", VA = "0x19BE3FC")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x19BE89C", Offset = "0x19BE89C", VA = "0x19BE89C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x19BE930", Offset = "0x19BE930", VA = "0x19BE930")]
		private void Start()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x19BEE5C", Offset = "0x19BEE5C", VA = "0x19BEE5C")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x19BE498", Offset = "0x19BE498", VA = "0x19BE498")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x19BF1DC", Offset = "0x19BF1DC", VA = "0x19BF1DC")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x19BF5E8", Offset = "0x19BF5E8", VA = "0x19BF5E8")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x19BF62C", Offset = "0x19BF62C", VA = "0x19BF62C")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x19BF68C", Offset = "0x19BF68C", VA = "0x19BF68C")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x19BEBEC", Offset = "0x19BEBEC", VA = "0x19BEBEC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x19BF6F8", Offset = "0x19BF6F8", VA = "0x19BF6F8")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x19BF7D4", Offset = "0x19BF7D4", VA = "0x19BF7D4")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9B3884", Offset = "0x9B3884")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9B3884", Offset = "0x9B3884")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B95B0", Offset = "0x9B95B0")]
		public float twistLimit;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public AnimationCurve spline;

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x19BF848", Offset = "0x19BF848", VA = "0x19BF848")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BF1D0", Offset = "0x9BF1D0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x19BF890", Offset = "0x19BF890", VA = "0x19BF890")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BF208", Offset = "0x9BF208")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x19BF8D8", Offset = "0x19BF8D8", VA = "0x19BF8D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BF240", Offset = "0x9BF240")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x19BF920", Offset = "0x19BF920", VA = "0x19BF920")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9BF278", Offset = "0x9BF278")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x19BF968", Offset = "0x19BF968", VA = "0x19BF968")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x19BF984", Offset = "0x19BF984", VA = "0x19BF984", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x19BF9C8", Offset = "0x19BF9C8", VA = "0x19BF9C8")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x19BFBEC", Offset = "0x19BFBEC", VA = "0x19BFBEC")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B38E4", Offset = "0x9B38E4")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x17000112")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000795")]
				[Address(RVA = "0x1E36FB4", Offset = "0x1E36FB4", VA = "0x1E36FB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000113")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000797")]
				[Address(RVA = "0x1E36FFC", Offset = "0x1E36FFC", VA = "0x1E36FFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x1E36EC4", Offset = "0x1E36EC4", VA = "0x1E36EC4")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x1E36EF0", Offset = "0x1E36EF0", VA = "0x1E36EF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x1E36EF4", Offset = "0x1E36EF4", VA = "0x1E36EF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x1E36FBC", Offset = "0x1E36FBC", VA = "0x1E36FBC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9604", Offset = "0x9B9604")]
		public AimIK ik;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B963C", Offset = "0x9B963C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B963C", Offset = "0x9B963C")]
		public float weight;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9690", Offset = "0x9B9690")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B9690", Offset = "0x9B9690")]
		public Transform target;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B96F0", Offset = "0x9B96F0")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9728", Offset = "0x9B9728")]
		public float weightSmoothTime;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B9760", Offset = "0x9B9760")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9760", Offset = "0x9B9760")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B97C0", Offset = "0x9B97C0")]
		public float maxRadiansDelta;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B97F8", Offset = "0x9B97F8")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9830", Offset = "0x9B9830")]
		public float slerpSpeed;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9868", Offset = "0x9B9868")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B98A0", Offset = "0x9B98A0")]
		public float minDistance;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B98D8", Offset = "0x9B98D8")]
		public Vector3 offset;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9B9910", Offset = "0x9B9910")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9910", Offset = "0x9B9910")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B9910", Offset = "0x9B9910")]
		public float maxRootAngle;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B998C", Offset = "0x9B998C")]
		public bool turnToTarget;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B99C4", Offset = "0x9B99C4")]
		public float turnToTargetTime;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B99FC", Offset = "0x9B99FC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9B99FC", Offset = "0x9B99FC")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9A5C", Offset = "0x9B9A5C")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x17000111")]
		private Vector3 pivot
		{
			[Token(Token = "0x600078D")]
			[Address(RVA = "0x1FA4548", Offset = "0x1FA4548", VA = "0x1FA4548")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1FA44C0", Offset = "0x1FA44C0", VA = "0x1FA44C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1FA45D8", Offset = "0x1FA45D8", VA = "0x1FA45D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1FA4B30", Offset = "0x1FA4B30", VA = "0x1FA4B30")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1FA4C1C", Offset = "0x1FA4C1C", VA = "0x1FA4C1C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1FA4E6C", Offset = "0x1FA4E6C", VA = "0x1FA4E6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BF2B0", Offset = "0x9BF2B0")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1FA4ED8", Offset = "0x1FA4ED8", VA = "0x1FA4ED8")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FD")]
		public class Pose
		{
			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x1E37004", Offset = "0x1E37004", VA = "0x1E37004")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x1E37190", Offset = "0x1E37190", VA = "0x1E37190")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x1E37198", Offset = "0x1E37198", VA = "0x1E37198")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1FA513C", Offset = "0x1FA513C", VA = "0x1FA513C")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1FA521C", Offset = "0x1FA521C", VA = "0x1FA521C")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x1FA5288", Offset = "0x1FA5288", VA = "0x1FA5288")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FF")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000100")]
			public class EffectorLink
			{
				[Token(Token = "0x4000738")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9C1C", Offset = "0x9B9C1C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000739")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9C54", Offset = "0x9B9C54")]
				public float weight;

				[Token(Token = "0x60007A3")]
				[Address(RVA = "0x2166188", Offset = "0x2166188", VA = "0x2166188")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9ACC", Offset = "0x9B9ACC")]
			public Transform transform;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9B04", Offset = "0x9B9B04")]
			public Transform relativeTo;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9B3C", Offset = "0x9B9B3C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9B74", Offset = "0x9B9B74")]
			public float verticalWeight;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9BAC", Offset = "0x9B9BAC")]
			public float horizontalWeight;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9BE4", Offset = "0x9B9BE4")]
			public float speed;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x1E371B4", Offset = "0x1E371B4", VA = "0x1E371B4")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x1E374E0", Offset = "0x1E374E0", VA = "0x1E374E0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x1E374F0", Offset = "0x1E374F0", VA = "0x1E374F0")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9A94", Offset = "0x9B9A94")]
		public Body[] bodies;

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1FA5398", Offset = "0x1FA5398", VA = "0x1FA5398", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1FA54E4", Offset = "0x1FA54E4", VA = "0x1FA54E4")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9C8C", Offset = "0x9B9C8C")]
		public float tiltSpeed;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9CC4", Offset = "0x9B9CC4")]
		public float tiltSensitivity;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9CFC", Offset = "0x9B9CFC")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9D34", Offset = "0x9B9D34")]
		public OffsetPose poseRight;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x1FB5A34", Offset = "0x1FB5A34", VA = "0x1FB5A34", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1FB5A7C", Offset = "0x1FB5A7C", VA = "0x1FB5A7C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1FB5C34", Offset = "0x1FB5C34", VA = "0x1FB5C34")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IK ik;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x208C070", Offset = "0x208C070", VA = "0x208C070")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x208C100", Offset = "0x208C100", VA = "0x208C100")]
		private void Update()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x208C1CC", Offset = "0x208C1CC", VA = "0x208C1CC")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000104")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9DDC", Offset = "0x9B9DDC")]
			public string name;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9E14", Offset = "0x9B9E14")]
			public Collider collider;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9E4C", Offset = "0x9B9E4C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B9E98", Offset = "0x9B9E98")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B9EA8", Offset = "0x9B9EA8")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B9EB8", Offset = "0x9B9EB8")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B9EC8", Offset = "0x9B9EC8")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000115")]
			public bool inProgress
			{
				[Token(Token = "0x60007AE")]
				[Address(RVA = "0x1E3A6DC", Offset = "0x1E3A6DC", VA = "0x1E3A6DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000116")]
			protected float crossFader
			{
				[Token(Token = "0x60007AF")]
				[Address(RVA = "0x1E3A6F0", Offset = "0x1E3A6F0", VA = "0x1E3A6F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF360", Offset = "0x9BF360")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007B0")]
				[Address(RVA = "0x1E3A6F8", Offset = "0x1E3A6F8", VA = "0x1E3A6F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF370", Offset = "0x9BF370")]
				private set
				{
				}
			}

			[Token(Token = "0x17000117")]
			protected float timer
			{
				[Token(Token = "0x60007B1")]
				[Address(RVA = "0x1E3A700", Offset = "0x1E3A700", VA = "0x1E3A700")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF380", Offset = "0x9BF380")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007B2")]
				[Address(RVA = "0x1E3A708", Offset = "0x1E3A708", VA = "0x1E3A708")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF390", Offset = "0x9BF390")]
				private set
				{
				}
			}

			[Token(Token = "0x17000118")]
			protected Vector3 force
			{
				[Token(Token = "0x60007B3")]
				[Address(RVA = "0x1E3A710", Offset = "0x1E3A710", VA = "0x1E3A710")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF3A0", Offset = "0x9BF3A0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007B4")]
				[Address(RVA = "0x1E3A71C", Offset = "0x1E3A71C", VA = "0x1E3A71C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF3B0", Offset = "0x9BF3B0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000119")]
			protected Vector3 point
			{
				[Token(Token = "0x60007B5")]
				[Address(RVA = "0x1E3A728", Offset = "0x1E3A728", VA = "0x1E3A728")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF3C0", Offset = "0x9BF3C0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007B6")]
				[Address(RVA = "0x1E3A734", Offset = "0x1E3A734", VA = "0x1E3A734")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF3D0", Offset = "0x9BF3D0")]
				private set
				{
				}
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x1E3A740", Offset = "0x1E3A740", VA = "0x1E3A740")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x1E3A874", Offset = "0x1E3A874", VA = "0x1E3A874")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007B9")]
			protected abstract float GetLength();

			[Token(Token = "0x60007BA")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60007BB")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x1E3A948", Offset = "0x1E3A948", VA = "0x1E3A948")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000105")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000106")]
			public class EffectorLink
			{
				[Token(Token = "0x4000750")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9F80", Offset = "0x9B9F80")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000751")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9FB8", Offset = "0x9B9FB8")]
				public float weight;

				[Token(Token = "0x4000752")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000753")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60007C1")]
				[Address(RVA = "0x21662F8", Offset = "0x21662F8", VA = "0x21662F8")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60007C2")]
				[Address(RVA = "0x21663A8", Offset = "0x21663A8", VA = "0x21663A8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007C3")]
				[Address(RVA = "0x21663BC", Offset = "0x21663BC", VA = "0x21663BC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9ED8", Offset = "0x9B9ED8")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9F10", Offset = "0x9B9F10")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9F48", Offset = "0x9B9F48")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x1E3AC74", Offset = "0x1E3AC74", VA = "0x1E3AC74", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x1E3ADA4", Offset = "0x1E3ADA4", VA = "0x1E3ADA4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x1E3AE10", Offset = "0x1E3AE10", VA = "0x1E3AE10", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x1E3AF78", Offset = "0x1E3AF78", VA = "0x1E3AF78")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000107")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000108")]
			public class BoneLink
			{
				[Token(Token = "0x4000757")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA060", Offset = "0x9BA060")]
				public Transform bone;

				[Token(Token = "0x4000758")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BA098", Offset = "0x9BA098")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA098", Offset = "0x9BA098")]
				public float weight;

				[Token(Token = "0x4000759")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x400075A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60007C8")]
				[Address(RVA = "0x2166190", Offset = "0x2166190", VA = "0x2166190")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60007C9")]
				[Address(RVA = "0x21662A8", Offset = "0x21662A8", VA = "0x21662A8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007CA")]
				[Address(RVA = "0x21662B4", Offset = "0x21662B4", VA = "0x21662B4")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9FF0", Offset = "0x9B9FF0")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA028", Offset = "0x9BA028")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x1E3A95C", Offset = "0x1E3A95C", VA = "0x1E3A95C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x1E3AA00", Offset = "0x1E3AA00", VA = "0x1E3AA00", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x1E3AA6C", Offset = "0x1E3AA6C", VA = "0x1E3AA6C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x1E3AC60", Offset = "0x1E3AC60", VA = "0x1E3AC60")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9D6C", Offset = "0x9B9D6C")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9B9DA4", Offset = "0x9B9DA4")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000114")]
		public bool inProgress
		{
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x21219D8", Offset = "0x21219D8", VA = "0x21219D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x2121AA8", Offset = "0x2121AA8", VA = "0x2121AA8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x2121B84", Offset = "0x2121B84", VA = "0x2121B84")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x2121DE0", Offset = "0x2121DE0", VA = "0x2121DE0")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x200010A")]
		public abstract class Offset
		{
			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA15C", Offset = "0x9BA15C")]
			public string name;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA194", Offset = "0x9BA194")]
			public Collider collider;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA1CC", Offset = "0x9BA1CC")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA218", Offset = "0x9BA218")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA228", Offset = "0x9BA228")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA238", Offset = "0x9BA238")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BA248", Offset = "0x9BA248")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700011A")]
			protected float crossFader
			{
				[Token(Token = "0x60007CE")]
				[Address(RVA = "0x1E3AF8C", Offset = "0x1E3AF8C", VA = "0x1E3AF8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF3E0", Offset = "0x9BF3E0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007CF")]
				[Address(RVA = "0x1E3AF94", Offset = "0x1E3AF94", VA = "0x1E3AF94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF3F0", Offset = "0x9BF3F0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700011B")]
			protected float timer
			{
				[Token(Token = "0x60007D0")]
				[Address(RVA = "0x1E3AF9C", Offset = "0x1E3AF9C", VA = "0x1E3AF9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF400", Offset = "0x9BF400")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007D1")]
				[Address(RVA = "0x1E3AFA4", Offset = "0x1E3AFA4", VA = "0x1E3AFA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF410", Offset = "0x9BF410")]
				private set
				{
				}
			}

			[Token(Token = "0x1700011C")]
			protected Vector3 force
			{
				[Token(Token = "0x60007D2")]
				[Address(RVA = "0x1E3AFAC", Offset = "0x1E3AFAC", VA = "0x1E3AFAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF420", Offset = "0x9BF420")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007D3")]
				[Address(RVA = "0x1E3AFB8", Offset = "0x1E3AFB8", VA = "0x1E3AFB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF430", Offset = "0x9BF430")]
				private set
				{
				}
			}

			[Token(Token = "0x1700011D")]
			protected Vector3 point
			{
				[Token(Token = "0x60007D4")]
				[Address(RVA = "0x1E3AFC4", Offset = "0x1E3AFC4", VA = "0x1E3AFC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF440", Offset = "0x9BF440")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007D5")]
				[Address(RVA = "0x1E3AFD0", Offset = "0x1E3AFD0", VA = "0x1E3AFD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF450", Offset = "0x9BF450")]
				private set
				{
				}
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x1E3AFDC", Offset = "0x1E3AFDC", VA = "0x1E3AFDC")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x1E3B124", Offset = "0x1E3B124", VA = "0x1E3B124")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60007D8")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x60007D9")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60007DA")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x1E3B20C", Offset = "0x1E3B20C", VA = "0x1E3B20C")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010B")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x200010C")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x400076B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA300", Offset = "0x9BA300")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400076C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA338", Offset = "0x9BA338")]
				public float weight;

				[Token(Token = "0x400076D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400076E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60007E0")]
				[Address(RVA = "0x21663C4", Offset = "0x21663C4", VA = "0x21663C4")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60007E1")]
				[Address(RVA = "0x2166454", Offset = "0x2166454", VA = "0x2166454")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007E2")]
				[Address(RVA = "0x2166468", Offset = "0x2166468", VA = "0x2166468")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA258", Offset = "0x9BA258")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA290", Offset = "0x9BA290")]
			public int upDirCurveIndex;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA2C8", Offset = "0x9BA2C8")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x1E3B220", Offset = "0x1E3B220", VA = "0x1E3B220", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x1E3B3D0", Offset = "0x1E3B3D0", VA = "0x1E3B3D0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x1E3B43C", Offset = "0x1E3B43C", VA = "0x1E3B43C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x1E3B5DC", Offset = "0x1E3B5DC", VA = "0x1E3B5DC")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010D")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x200010E")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000772")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA3E0", Offset = "0x9BA3E0")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000773")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA418", Offset = "0x9BA418")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BA418", Offset = "0x9BA418")]
				public float weight;

				[Token(Token = "0x4000774")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000775")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x60007E7")]
				[Address(RVA = "0x2166470", Offset = "0x2166470", VA = "0x2166470")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60007E8")]
				[Address(RVA = "0x216654C", Offset = "0x216654C", VA = "0x216654C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007E9")]
				[Address(RVA = "0x2166558", Offset = "0x2166558", VA = "0x2166558")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA370", Offset = "0x9BA370")]
			public int curveIndex;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA3A8", Offset = "0x9BA3A8")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x1E3B5F8", Offset = "0x1E3B5F8", VA = "0x1E3B5F8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x1E3B6DC", Offset = "0x1E3B6DC", VA = "0x1E3B6DC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x1E3B748", Offset = "0x1E3B748", VA = "0x1E3B748", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x1E3B9FC", Offset = "0x1E3B9FC", VA = "0x1E3B9FC")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA0EC", Offset = "0x9BA0EC")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA124", Offset = "0x9BA124")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x2122134", Offset = "0x2122134", VA = "0x2122134", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x2122208", Offset = "0x2122208", VA = "0x2122208")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x212246C", Offset = "0x212246C", VA = "0x212246C")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000110")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000111")]
			public class EffectorLink
			{
				[Token(Token = "0x4000783")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA648", Offset = "0x9BA648")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000784")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA680", Offset = "0x9BA680")]
				public float weight;

				[Token(Token = "0x60007F0")]
				[Address(RVA = "0x216659C", Offset = "0x216659C", VA = "0x216659C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA4DC", Offset = "0x9BA4DC")]
			public Transform transform;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA514", Offset = "0x9BA514")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA54C", Offset = "0x9BA54C")]
			public float speed;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA584", Offset = "0x9BA584")]
			public float acceleration;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA5BC", Offset = "0x9BA5BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BA5BC", Offset = "0x9BA5BC")]
			public float matchVelocity;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA610", Offset = "0x9BA610")]
			public float gravity;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x215DF50", Offset = "0x215DF50", VA = "0x215DF50")]
			public void Reset()
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x215E008", Offset = "0x215E008", VA = "0x215E008")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x215E2C4", Offset = "0x215E2C4", VA = "0x215E2C4")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA46C", Offset = "0x9BA46C")]
		public Body[] bodies;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA4A4", Offset = "0x9BA4A4")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x207820C", Offset = "0x207820C", VA = "0x207820C")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x2078288", Offset = "0x2078288", VA = "0x2078288", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x2078348", Offset = "0x2078348", VA = "0x2078348")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BA6B8", Offset = "0x9BA6B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA6B8", Offset = "0x9BA6B8")]
		public Transform target;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BA718", Offset = "0x9BA718")]
		public float weight;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA730", Offset = "0x9BA730")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA768", Offset = "0x9BA768")]
		public float weightSmoothTime;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BA7A0", Offset = "0x9BA7A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA7A0", Offset = "0x9BA7A0")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA800", Offset = "0x9BA800")]
		public float maxRadiansDelta;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA838", Offset = "0x9BA838")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA870", Offset = "0x9BA870")]
		public float slerpSpeed;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA8A8", Offset = "0x9BA8A8")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA8E0", Offset = "0x9BA8E0")]
		public float minDistance;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BA918", Offset = "0x9BA918")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BA918", Offset = "0x9BA918")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA918", Offset = "0x9BA918")]
		public float maxRootAngle;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x1700011E")]
		private Vector3 pivot
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x20827B0", Offset = "0x20827B0", VA = "0x20827B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x208273C", Offset = "0x208273C", VA = "0x208273C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x2082840", Offset = "0x2082840", VA = "0x2082840")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x2082D5C", Offset = "0x2082D5C", VA = "0x2082D5C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x2082E48", Offset = "0x2082E48", VA = "0x2082E48")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x2083040", Offset = "0x2083040", VA = "0x2083040")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000114")]
		public class OffsetLimits
		{
			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAA04", Offset = "0x9BAA04")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAA3C", Offset = "0x9BAA3C")]
			public float spring;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAA74", Offset = "0x9BAA74")]
			public bool x;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAAAC", Offset = "0x9BAAAC")]
			public bool y;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAAE4", Offset = "0x9BAAE4")]
			public bool z;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAB1C", Offset = "0x9BAB1C")]
			public float minX;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAB54", Offset = "0x9BAB54")]
			public float maxX;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAB8C", Offset = "0x9BAB8C")]
			public float minY;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BABC4", Offset = "0x9BABC4")]
			public float maxY;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BABFC", Offset = "0x9BABFC")]
			public float minZ;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAC34", Offset = "0x9BAC34")]
			public float maxZ;

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x2161288", Offset = "0x2161288", VA = "0x2161288")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x21613E0", Offset = "0x21613E0", VA = "0x21613E0")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x2161458", Offset = "0x2161458", VA = "0x2161458")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x21614B0", Offset = "0x21614B0", VA = "0x21614B0")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3904", Offset = "0x9B3904")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x17000120")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000806")]
				[Address(RVA = "0x2161238", Offset = "0x2161238", VA = "0x2161238", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000121")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000808")]
				[Address(RVA = "0x2161280", Offset = "0x2161280", VA = "0x2161280", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x21610B8", Offset = "0x21610B8", VA = "0x21610B8")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x21610E4", Offset = "0x21610E4", VA = "0x21610E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x21610E8", Offset = "0x21610E8", VA = "0x21610E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x2161240", Offset = "0x2161240", VA = "0x2161240", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA994", Offset = "0x9BA994")]
		public float weight;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BA9CC", Offset = "0x9BA9CC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700011F")]
		protected float deltaTime
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x19B82B4", Offset = "0x19B82B4", VA = "0x19B82B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60007F8")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x19B6C04", Offset = "0x19B6C04", VA = "0x19B6C04", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x19B82E0", Offset = "0x19B82E0", VA = "0x19B82E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BF460", Offset = "0x9BF460")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x19B834C", Offset = "0x19B834C", VA = "0x19B834C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x19B8428", Offset = "0x19B8428", VA = "0x19B8428")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x19B6F74", Offset = "0x19B6F74", VA = "0x19B6F74", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x19B7094", Offset = "0x19B7094", VA = "0x19B7094")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3914", Offset = "0x9B3914")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x17000123")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000813")]
				[Address(RVA = "0x2161638", Offset = "0x2161638", VA = "0x2161638", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000124")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000815")]
				[Address(RVA = "0x2161680", Offset = "0x2161680", VA = "0x2161680", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x21614B8", Offset = "0x21614B8", VA = "0x21614B8")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x21614E4", Offset = "0x21614E4", VA = "0x21614E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x21614E8", Offset = "0x21614E8", VA = "0x21614E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0x2161640", Offset = "0x2161640", VA = "0x2161640", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAC6C", Offset = "0x9BAC6C")]
		public float weight;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BACA4", Offset = "0x9BACA4")]
		public VRIK ik;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000122")]
		protected float deltaTime
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x19B84E8", Offset = "0x19B84E8", VA = "0x19B84E8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600080A")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x19B8514", Offset = "0x19B8514", VA = "0x19B8514", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x19B8540", Offset = "0x19B8540", VA = "0x19B8540")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BF510", Offset = "0x9BF510")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x19B85AC", Offset = "0x19B85AC", VA = "0x19B85AC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x19B8688", Offset = "0x19B8688", VA = "0x19B8688", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x19B8794", Offset = "0x19B8794", VA = "0x19B8794")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000119")]
		public class EffectorLink
		{
			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x2161688", Offset = "0x2161688", VA = "0x2161688")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x21618A4", Offset = "0x21618A4", VA = "0x21618A4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x19B87A4", Offset = "0x19B87A4", VA = "0x19B87A4")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x19B8868", Offset = "0x19B8868", VA = "0x19B8868")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x19B8924", Offset = "0x19B8924", VA = "0x19B8924")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200011B")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x200011C")]
			public class EffectorLink
			{
				[Token(Token = "0x40007C0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAEB8", Offset = "0x9BAEB8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007C1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAEF0", Offset = "0x9BAEF0")]
				public float weight;

				[Token(Token = "0x6000821")]
				[Address(RVA = "0x21665AC", Offset = "0x21665AC", VA = "0x21665AC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAD14", Offset = "0x9BAD14")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAD4C", Offset = "0x9BAD4C")]
			public Transform raycastTo;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAD84", Offset = "0x9BAD84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BAD84", Offset = "0x9BAD84")]
			public float raycastRadius;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BADD8", Offset = "0x9BADD8")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAE10", Offset = "0x9BAE10")]
			public float smoothTimeIn;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAE48", Offset = "0x9BAE48")]
			public float smoothTimeOut;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAE80", Offset = "0x9BAE80")]
			public LayerMask layers;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x21618AC", Offset = "0x21618AC", VA = "0x21618AC")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x21619F0", Offset = "0x21619F0", VA = "0x21619F0")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x2161AE8", Offset = "0x2161AE8", VA = "0x2161AE8")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x2161CB8", Offset = "0x2161CB8", VA = "0x2161CB8")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BACDC", Offset = "0x9BACDC")]
		public Avoider[] avoiders;

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x19B92CC", Offset = "0x19B92CC", VA = "0x19B92CC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x19B9354", Offset = "0x19B9354", VA = "0x19B9354")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200011E")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x200011F")]
			public class EffectorLink
			{
				[Token(Token = "0x40007DF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB27C", Offset = "0x9BB27C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007E0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB2B4", Offset = "0x9BB2B4")]
				public float weight;

				[Token(Token = "0x6000831")]
				[Address(RVA = "0x21665B4", Offset = "0x21665B4", VA = "0x21665B4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB180", Offset = "0x9BB180")]
			public Vector3 offset;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB1B8", Offset = "0x9BB1B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB1B8", Offset = "0x9BB1B8")]
			public float additivity;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB20C", Offset = "0x9BB20C")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB244", Offset = "0x9BB244")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600082E")]
			[Address(RVA = "0x2162B50", Offset = "0x2162B50", VA = "0x2162B50")]
			public void Start()
			{
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x2162BA0", Offset = "0x2162BA0", VA = "0x2162BA0")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0x2162D64", Offset = "0x2162D64", VA = "0x2162D64")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000120")]
		public enum Handedness
		{
			[Token(Token = "0x40007E2")]
			Right,
			[Token(Token = "0x40007E3")]
			Left
		}

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAF28", Offset = "0x9BAF28")]
		public AimIK aimIK;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAF60", Offset = "0x9BAF60")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAF98", Offset = "0x9BAF98")]
		public Handedness handedness;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BAFD0", Offset = "0x9BAFD0")]
		public bool twoHanded;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB008", Offset = "0x9BB008")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB040", Offset = "0x9BB040")]
		public float magnitudeRandom;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB078", Offset = "0x9BB078")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB0B0", Offset = "0x9BB0B0")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB0E8", Offset = "0x9BB0E8")]
		public float blendTime;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB120", Offset = "0x9BB120")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9BB120", Offset = "0x9BB120")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000125")]
		public bool isFinished
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x19BC378", Offset = "0x19BC378", VA = "0x19BC378")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000126")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x19BCDF0", Offset = "0x19BCDF0", VA = "0x19BCDF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000127")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000829")]
			[Address(RVA = "0x19BCE30", Offset = "0x19BCE30", VA = "0x19BCE30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000128")]
		private Transform primaryHand
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x19BCDB0", Offset = "0x19BCDB0", VA = "0x19BCDB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000129")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600082B")]
			[Address(RVA = "0x19BCDD0", Offset = "0x19BCDD0", VA = "0x19BCDD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x19BC3A8", Offset = "0x19BC3A8", VA = "0x19BC3A8")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x19BC3D4", Offset = "0x19BC3D4", VA = "0x19BC3D4")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x19BC51C", Offset = "0x19BC51C", VA = "0x19BC51C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x19BCE70", Offset = "0x19BCE70", VA = "0x19BCE70")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x19BCF24", Offset = "0x19BCF24", VA = "0x19BCF24")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x19BCF60", Offset = "0x19BCF60", VA = "0x19BCF60", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x19BD118", Offset = "0x19BD118", VA = "0x19BD118")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB2EC", Offset = "0x9BB2EC")]
		public float weight;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB324", Offset = "0x9BB324")]
		public float offset;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x19C08CC", Offset = "0x19C08CC", VA = "0x19C08CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x19C09B4", Offset = "0x19C09B4", VA = "0x19C09B4")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x19C0A9C", Offset = "0x19C0A9C", VA = "0x19C0A9C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x19C0DF0", Offset = "0x19C0DF0", VA = "0x19C0DF0")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x19C0E28", Offset = "0x19C0E28", VA = "0x19C0E28")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x19C0F34", Offset = "0x19C0F34", VA = "0x19C0F34")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x2000123")]
		public class Settings
		{
			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB35C", Offset = "0x9BB35C")]
			public float scaleMlp;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB394", Offset = "0x9BB394")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB3CC", Offset = "0x9BB3CC")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB404", Offset = "0x9BB404")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB43C", Offset = "0x9BB43C")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB474", Offset = "0x9BB474")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB4AC", Offset = "0x9BB4AC")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB4E4", Offset = "0x9BB4E4")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB51C", Offset = "0x9BB51C")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB554", Offset = "0x9BB554")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9BB554", Offset = "0x9BB554")]
			public Vector3 headOffset;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB5A4", Offset = "0x9BB5A4")]
			public Vector3 handOffset;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB5DC", Offset = "0x9BB5DC")]
			public float footForwardOffset;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB614", Offset = "0x9BB614")]
			public float footInwardOffset;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB64C", Offset = "0x9BB64C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB64C", Offset = "0x9BB64C")]
			public float footHeadingOffset;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB6A8", Offset = "0x9BB6A8")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB6C0", Offset = "0x9BB6C0")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600083D")]
			[Address(RVA = "0x216551C", Offset = "0x216551C", VA = "0x216551C")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000124")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x2000125")]
			public class Target
			{
				[Token(Token = "0x4000804")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000805")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000806")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x600083F")]
				[Address(RVA = "0x21665BC", Offset = "0x21665BC", VA = "0x21665BC")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000840")]
				[Address(RVA = "0x216667C", Offset = "0x216667C", VA = "0x216667C")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600083E")]
			[Address(RVA = "0x2165514", Offset = "0x2165514", VA = "0x2165514")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x19C87C8", Offset = "0x19C87C8", VA = "0x19C87C8")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x19C6ADC", Offset = "0x19C6ADC", VA = "0x19C6ADC")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x19C8924", Offset = "0x19C8924", VA = "0x19C8924")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x19C7CE4", Offset = "0x19C7CE4", VA = "0x19C7CE4")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x19C8F18", Offset = "0x19C8F18", VA = "0x19C8F18")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x1E31F08", Offset = "0x1E31F08", VA = "0x1E31F08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x1E31F5C", Offset = "0x1E31F5C", VA = "0x1E31F5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x1E31F90", Offset = "0x1E31F90", VA = "0x1E31F90")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1E320CC", Offset = "0x1E320CC", VA = "0x1E320CC")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BB6D8", Offset = "0x9BB6D8")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x1700012A")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x1E327BC", Offset = "0x1E327BC", VA = "0x1E327BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF5C0", Offset = "0x9BF5C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x1E327C8", Offset = "0x1E327C8", VA = "0x1E327C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF5D0", Offset = "0x9BF5D0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x1E327D4", Offset = "0x1E327D4", VA = "0x1E327D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x1E3291C", Offset = "0x1E3291C", VA = "0x1E3291C")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x1E32B14", Offset = "0x1E32B14", VA = "0x1E32B14")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x1E32C98", Offset = "0x1E32C98", VA = "0x1E32C98")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x1E330B4", Offset = "0x1E330B4", VA = "0x1E330B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x1E331BC", Offset = "0x1E331BC", VA = "0x1E331BC")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000128")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000129")]
		public class Offset
		{
			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x1E389C8", Offset = "0x1E389C8", VA = "0x1E389C8")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x6000852")]
			[Address(RVA = "0x1E38B28", Offset = "0x1E38B28", VA = "0x1E38B28")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x20937C8", Offset = "0x20937C8", VA = "0x20937C8")]
		private void Start()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x209381C", Offset = "0x209381C", VA = "0x209381C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x2093898", Offset = "0x2093898", VA = "0x2093898")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x2093970", Offset = "0x2093970", VA = "0x2093970")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x1FA4434", Offset = "0x1FA4434", VA = "0x1FA4434")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x1FA44B8", Offset = "0x1FA44B8", VA = "0x1FA44B8")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB720", Offset = "0x9BB720")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x1FA52EC", Offset = "0x1FA52EC", VA = "0x1FA52EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x1FA5364", Offset = "0x1FA5364", VA = "0x1FA5364")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x19C005C", Offset = "0x19C005C", VA = "0x19C005C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x19C00A0", Offset = "0x19C00A0", VA = "0x19C00A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x19C0254", Offset = "0x19C0254", VA = "0x19C0254")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB758", Offset = "0x9BB758")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB790", Offset = "0x9BB790")]
		public AimIK aim;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB7C8", Offset = "0x9BB7C8")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB800", Offset = "0x9BB800")]
		public Animator animator;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB838", Offset = "0x9BB838")]
		public float crossfadeTime;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BB870", Offset = "0x9BB870")]
		public float minAimDistance;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x19C0F48", Offset = "0x19C0F48", VA = "0x19C0F48")]
		private void Start()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x19C0F8C", Offset = "0x19C0F8C", VA = "0x19C0F8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x19C10F4", Offset = "0x19C10F4", VA = "0x19C10F4")]
		private void Pose()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x19C1284", Offset = "0x19C1284", VA = "0x19C1284")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x19C13C0", Offset = "0x19C13C0", VA = "0x19C13C0")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x19C143C", Offset = "0x19C143C", VA = "0x19C143C")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x19C2700", Offset = "0x19C2700", VA = "0x19C2700")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x19C2870", Offset = "0x19C2870", VA = "0x19C2870")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x19C2A04", Offset = "0x19C2A04", VA = "0x19C2A04")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BB8A8", Offset = "0x9BB8A8")]
		public Animator animator;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BB8E0", Offset = "0x9BB8E0")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB918", Offset = "0x9BB918")]
		public float lookAtWeight;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB930", Offset = "0x9BB930")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB948", Offset = "0x9BB948")]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB960", Offset = "0x9BB960")]
		public float lookAtEyesWeight;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB978", Offset = "0x9BB978")]
		public float lookAtClampWeight;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB990", Offset = "0x9BB990")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB9A8", Offset = "0x9BB9A8")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BB9C0", Offset = "0x9BB9C0")]
		public Transform footTargetBiped;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BB9F8", Offset = "0x9BB9F8")]
		public float footPositionWeight;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BBA10", Offset = "0x9BBA10")]
		public float footRotationWeight;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9BBA28", Offset = "0x9BBA28")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BBA60", Offset = "0x9BBA60")]
		public float handPositionWeight;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BBA78", Offset = "0x9BBA78")]
		public float handRotationWeight;

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x1FAEC18", Offset = "0x1FAEC18", VA = "0x1FAEC18")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x1FAF020", Offset = "0x1FAF020", VA = "0x1FAF020")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x208390C", Offset = "0x208390C", VA = "0x208390C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x2084118", Offset = "0x2084118", VA = "0x2084118")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x2083EC8", Offset = "0x2083EC8", VA = "0x2083EC8")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x2084214", Offset = "0x2084214", VA = "0x2084214")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x1700012B")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x2084240", Offset = "0x2084240", VA = "0x2084240")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x20842C4", Offset = "0x20842C4", VA = "0x20842C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x20844E8", Offset = "0x20844E8", VA = "0x20844E8")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x2000133")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3924", Offset = "0x9B3924")]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x1700012E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600087A")]
				[Address(RVA = "0x2160E00", Offset = "0x2160E00", VA = "0x2160E00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600087C")]
				[Address(RVA = "0x2160E48", Offset = "0x2160E48", VA = "0x2160E48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x2160B10", Offset = "0x2160B10", VA = "0x2160B10")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x2160B3C", Offset = "0x2160B3C", VA = "0x2160B3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0x2160B40", Offset = "0x2160B40", VA = "0x2160B40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x2160E08", Offset = "0x2160E08", VA = "0x2160E08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x1700012C")]
		public bool isStepping
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x20844FC", Offset = "0x20844FC", VA = "0x20844FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012D")]
		public Vector3 position
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0x20841E0", Offset = "0x20841E0", VA = "0x20841E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x2084510", Offset = "0x2084510", VA = "0x2084510")]
			set
			{
			}
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x2084560", Offset = "0x2084560", VA = "0x2084560")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x2084754", Offset = "0x2084754", VA = "0x2084754")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x20848F0", Offset = "0x20848F0", VA = "0x20848F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x2084B18", Offset = "0x2084B18", VA = "0x2084B18")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x2084DBC", Offset = "0x2084DBC", VA = "0x2084DBC")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x2084F34", Offset = "0x2084F34", VA = "0x2084F34")]
		private void Update()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x2084A70", Offset = "0x2084A70", VA = "0x2084A70")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BF5E0", Offset = "0x9BF5E0")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x2085130", Offset = "0x2085130", VA = "0x2085130")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x19B5C6C", Offset = "0x19B5C6C", VA = "0x19B5C6C")]
		private void Start()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x19B5D2C", Offset = "0x19B5D2C", VA = "0x19B5D2C")]
		private void Update()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x19B5F84", Offset = "0x19B5F84", VA = "0x19B5F84")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000136")]
		public struct Warp
		{
			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBB50", Offset = "0x9BBB50")]
			public int animationLayer;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBB88", Offset = "0x9BBB88")]
			public string animationState;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBBC0", Offset = "0x9BBBC0")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBBF8", Offset = "0x9BBBF8")]
			public Transform warpFrom;

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBC30", Offset = "0x9BBC30")]
			public Transform warpTo;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBC68", Offset = "0x9BBC68")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x2000137")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000882")]
			PositionOffset,
			[Token(Token = "0x4000883")]
			Position
		}

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBA90", Offset = "0x9BBA90")]
		public Animator animator;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBAC8", Offset = "0x9BBAC8")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBB00", Offset = "0x9BBB00")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9BBB00", Offset = "0x9BBB00")]
		public Warp[] warps;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x1FA54EC", Offset = "0x1FA54EC", VA = "0x1FA54EC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x1FA5518", Offset = "0x1FA5518", VA = "0x1FA5518")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x1FA5758", Offset = "0x1FA5758", VA = "0x1FA5758", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x1FA5A1C", Offset = "0x1FA5A1C", VA = "0x1FA5A1C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x1FA5ABC", Offset = "0x1FA5ABC", VA = "0x1FA5ABC")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3934", Offset = "0x9B3934")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x1FA5AC4", Offset = "0x1FA5AC4", VA = "0x1FA5AC4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x1FA5B18", Offset = "0x1FA5B18", VA = "0x1FA5B18")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x1FA5CB4", Offset = "0x1FA5CB4", VA = "0x1FA5CB4", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x1FA5EBC", Offset = "0x1FA5EBC", VA = "0x1FA5EBC")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3994", Offset = "0x9B3994")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3994", Offset = "0x9B3994")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BBCA0", Offset = "0x9BBCA0")]
		public float headLookWeight;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x1FA5ED0", Offset = "0x1FA5ED0", VA = "0x1FA5ED0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x1FA605C", Offset = "0x1FA605C", VA = "0x1FA605C", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x1FA60D8", Offset = "0x1FA60D8", VA = "0x1FA60D8")]
		private void Read()
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x1FA61CC", Offset = "0x1FA61CC", VA = "0x1FA61CC")]
		private void AimIK()
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x1FA6214", Offset = "0x1FA6214", VA = "0x1FA6214")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x1FA6600", Offset = "0x1FA6600", VA = "0x1FA6600")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x1FA6488", Offset = "0x1FA6488", VA = "0x1FA6488")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x1FA685C", Offset = "0x1FA685C", VA = "0x1FA685C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x1FA6968", Offset = "0x1FA6968", VA = "0x1FA6968")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x200013A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3A28", Offset = "0x9B3A28")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x2085194", Offset = "0x2085194", VA = "0x2085194", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x20851F4", Offset = "0x20851F4", VA = "0x20851F4", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x2085428", Offset = "0x2085428", VA = "0x2085428")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x208551C", Offset = "0x208551C", VA = "0x208551C")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3A88", Offset = "0x9B3A88")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000130")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000898")]
			[Address(RVA = "0x2085F20", Offset = "0x2085F20", VA = "0x2085F20")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000131")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0x2085FA4", Offset = "0x2085FA4", VA = "0x2085FA4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x2085D2C", Offset = "0x2085D2C", VA = "0x2085D2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x2085D98", Offset = "0x2085D98", VA = "0x2085D98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x2086028", Offset = "0x2086028", VA = "0x2086028")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BBCB8", Offset = "0x9BBCB8")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x208C97C", Offset = "0x208C97C", VA = "0x208C97C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x208CDDC", Offset = "0x208CDDC", VA = "0x208CDDC")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x208CDE4", Offset = "0x208CDE4", VA = "0x208CDE4")]
		private void Start()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x208CE8C", Offset = "0x208CE8C", VA = "0x208CE8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x208D210", Offset = "0x208D210", VA = "0x208D210")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x208D2BC", Offset = "0x208D2BC", VA = "0x208D2BC")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200013F")]
		public class Limb
		{
			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40008B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40008BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x1E384B0", Offset = "0x1E384B0", VA = "0x1E384B0")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x1E38534", Offset = "0x1E38534", VA = "0x1E38534")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x2090B88", Offset = "0x2090B88", VA = "0x2090B88")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x2090CE0", Offset = "0x2090CE0", VA = "0x2090CE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x2090D84", Offset = "0x2090D84", VA = "0x2090D84")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x2090D88", Offset = "0x2090D88", VA = "0x2090D88")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x2090D98", Offset = "0x2090D98", VA = "0x2090D98")]
		private void Start()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x2090E0C", Offset = "0x2090E0C", VA = "0x2090E0C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x2090EE0", Offset = "0x2090EE0", VA = "0x2090EE0")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBCD0", Offset = "0x9BBCD0")]
		public Transform target;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBD08", Offset = "0x9BBD08")]
		public Transform pin;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBD40", Offset = "0x9BBD40")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBD78", Offset = "0x9BBD78")]
		public AimIK aim;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBDB0", Offset = "0x9BBDB0")]
		public float weight;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBDE8", Offset = "0x9BBDE8")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBE20", Offset = "0x9BBE20")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x2090EE8", Offset = "0x2090EE8", VA = "0x2090EE8")]
		private void Start()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x2090F3C", Offset = "0x2090F3C", VA = "0x2090F3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x20910E0", Offset = "0x20910E0", VA = "0x20910E0")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x2093184", Offset = "0x2093184", VA = "0x2093184")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x209324C", Offset = "0x209324C", VA = "0x209324C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x20932DC", Offset = "0x20932DC", VA = "0x20932DC")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x20936B4", Offset = "0x20936B4", VA = "0x20936B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x20937C0", Offset = "0x20937C0", VA = "0x20937C0")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BBE58", Offset = "0x9BBE58")]
		public float aimWeight;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BBE70", Offset = "0x9BBE70")]
		public float sightWeight;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BBE88", Offset = "0x9BBE88")]
		public float maxAngle;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CameraControllerFPS cam;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Recoil recoil;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BBEA4", Offset = "0x9BBEA4")]
		public float cameraRecoilWeight;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool updateFrame;

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x2093978", Offset = "0x2093978", VA = "0x2093978")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x2093AEC", Offset = "0x2093AEC", VA = "0x2093AEC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x2093AF8", Offset = "0x2093AF8", VA = "0x2093AF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x2093D78", Offset = "0x2093D78", VA = "0x2093D78")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x2093F24", Offset = "0x2093F24", VA = "0x2093F24")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x2093BC0", Offset = "0x2093BC0", VA = "0x2093BC0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x2094818", Offset = "0x2094818", VA = "0x2094818")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3AE8", Offset = "0x9B3AE8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3AE8", Offset = "0x9B3AE8")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BBEBC", Offset = "0x9BBEBC")]
		public float walkSpeed;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x2094838", Offset = "0x2094838", VA = "0x2094838")]
		private void Start()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x20948B0", Offset = "0x20948B0", VA = "0x20948B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x209499C", Offset = "0x209499C", VA = "0x209499C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x2094A54", Offset = "0x2094A54", VA = "0x2094A54")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x2121DE8", Offset = "0x2121DE8", VA = "0x2121DE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x2121F40", Offset = "0x2121F40", VA = "0x2121F40")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x2122124", Offset = "0x2122124", VA = "0x2122124")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x21227C0", Offset = "0x21227C0", VA = "0x21227C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x2122908", Offset = "0x2122908", VA = "0x2122908")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x2122C44", Offset = "0x2122C44", VA = "0x2122C44")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000147")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x2078428", Offset = "0x2078428", VA = "0x2078428")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x2078674", Offset = "0x2078674", VA = "0x2078674")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x2078780", Offset = "0x2078780", VA = "0x2078780")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x2078788", Offset = "0x2078788", VA = "0x2078788")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x2078F9C", Offset = "0x2078F9C", VA = "0x2078F9C")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000149")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3B7C", Offset = "0x9B3B7C")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBED4", Offset = "0x9BBED4")]
		public InteractionObject interactionObject;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBF0C", Offset = "0x9BBF0C")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x208070C", Offset = "0x208070C", VA = "0x208070C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x2080760", Offset = "0x2080760", VA = "0x2080760")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x2080A98", Offset = "0x2080A98", VA = "0x2080A98")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014B")]
		public class Partner
		{
			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x17000132")]
			private Transform neck
			{
				[Token(Token = "0x60008D0")]
				[Address(RVA = "0x215FF48", Offset = "0x215FF48", VA = "0x215FF48")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x215F7FC", Offset = "0x215F7FC", VA = "0x215F7FC")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x215F81C", Offset = "0x215F81C", VA = "0x215F81C")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x215FDB4", Offset = "0x215FDB4", VA = "0x215FDB4")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x215FFA0", Offset = "0x215FFA0", VA = "0x215FFA0")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x2081658", Offset = "0x2081658", VA = "0x2081658")]
		private void Start()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x2081694", Offset = "0x2081694", VA = "0x2081694")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x20816FC", Offset = "0x20816FC", VA = "0x20816FC")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x200014C")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200014D")]
		public enum Mode
		{
			[Token(Token = "0x400090E")]
			Position,
			[Token(Token = "0x400090F")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x200014E")]
		public class Absorber
		{
			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC024", Offset = "0x9BC024")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC05C", Offset = "0x9BC05C")]
			public float weight;

			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x2160E50", Offset = "0x2160E50", VA = "0x2160E50")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x2160F24", Offset = "0x2160F24", VA = "0x2160F24")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x2160F60", Offset = "0x2160F60", VA = "0x2160F60")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x2160FF8", Offset = "0x2160FF8", VA = "0x2160FF8")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x216106C", Offset = "0x216106C", VA = "0x216106C")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBF44", Offset = "0x9BBF44")]
		public Mode mode;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBF7C", Offset = "0x9BBF7C")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBFB4", Offset = "0x9BBFB4")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BBFEC", Offset = "0x9BBFEC")]
		public float falloffSpeed;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x19B6B1C", Offset = "0x19B6B1C", VA = "0x19B6B1C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x19B6C30", Offset = "0x19B6C30", VA = "0x19B6C30")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x19B6CC0", Offset = "0x19B6CC0", VA = "0x19B6CC0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x19B6DD4", Offset = "0x19B6DD4", VA = "0x19B6DD4")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x19B6E60", Offset = "0x19B6E60", VA = "0x19B6E60", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x19B7080", Offset = "0x19B7080", VA = "0x19B7080")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x200014F")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x19B70A4", Offset = "0x19B70A4", VA = "0x19B70A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x19B7118", Offset = "0x19B7118", VA = "0x19B7118")]
		private void Update()
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x19B71F4", Offset = "0x19B71F4", VA = "0x19B71F4")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x19B72B4", Offset = "0x19B72B4", VA = "0x19B72B4")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000151")]
		public class EffectorLink
		{
			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x21610A8", Offset = "0x21610A8", VA = "0x21610A8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x19B800C", Offset = "0x19B800C", VA = "0x19B800C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x19B8118", Offset = "0x19B8118", VA = "0x19B8118", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x19B82A4", Offset = "0x19B82A4", VA = "0x19B82A4")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000152")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3BDC", Offset = "0x9B3BDC")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC0A4", Offset = "0x9BC0A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC0A4", Offset = "0x9BC0A4")]
		public float weight;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC0F8", Offset = "0x9BC0F8")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC130", Offset = "0x9BC130")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC17C", Offset = "0x9BC17C")]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x19B8980", Offset = "0x19B8980", VA = "0x19B8980")]
		private void Start()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x19B8C44", Offset = "0x19B8C44", VA = "0x19B8C44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x19B928C", Offset = "0x19B928C", VA = "0x19B928C")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000133")]
		private bool holding
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x19B9638", Offset = "0x19B9638", VA = "0x19B9638")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x19B9364", Offset = "0x19B9364", VA = "0x19B9364")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008EA")]
		protected abstract void RotatePivot();

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x19B9658", Offset = "0x19B9658", VA = "0x19B9658")]
		private void Start()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x19B97E0", Offset = "0x19B97E0", VA = "0x19B97E0")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x19B9964", Offset = "0x19B9964", VA = "0x19B9964")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x19B9A40", Offset = "0x19B9A40", VA = "0x19B9A40")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x19B9B74", Offset = "0x19B9B74", VA = "0x19B9B74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x19B9CD8", Offset = "0x19B9CD8", VA = "0x19B9CD8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x19B9EA4", Offset = "0x19B9EA4", VA = "0x19B9EA4")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000154")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x19B9EB8", Offset = "0x19B9EB8", VA = "0x19B9EB8", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x19BA11C", Offset = "0x19BA11C", VA = "0x19BA11C")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x19BA130", Offset = "0x19BA130", VA = "0x19BA130", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x19BA264", Offset = "0x19BA264", VA = "0x19BA264")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x19BC17C", Offset = "0x19BC17C", VA = "0x19BC17C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x19BC25C", Offset = "0x19BC25C", VA = "0x19BC25C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x19BC370", Offset = "0x19BC370", VA = "0x19BC370")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3C3C", Offset = "0x9B3C3C")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x19BD188", Offset = "0x19BD188", VA = "0x19BD188")]
		private void Start()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x19BD1DC", Offset = "0x19BD1DC", VA = "0x19BD1DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x19BD234", Offset = "0x19BD234", VA = "0x19BD234")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x19BD314", Offset = "0x19BD314", VA = "0x19BD314")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3C9C", Offset = "0x9B3C9C")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x17000134")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000905")]
				[Address(RVA = "0x2162F54", Offset = "0x2162F54", VA = "0x2162F54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000135")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000907")]
				[Address(RVA = "0x2162F9C", Offset = "0x2162F9C", VA = "0x2162F9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x2162D78", Offset = "0x2162D78", VA = "0x2162D78")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x2162DA4", Offset = "0x2162DA4", VA = "0x2162DA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0x2162DA8", Offset = "0x2162DA8", VA = "0x2162DA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000906")]
			[Address(RVA = "0x2162F5C", Offset = "0x2162F5C", VA = "0x2162F5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x19BD324", Offset = "0x19BD324", VA = "0x19BD324")]
		private void Start()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x19BD3D8", Offset = "0x19BD3D8", VA = "0x19BD3D8")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x19BD420", Offset = "0x19BD420", VA = "0x19BD420")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BF690", Offset = "0x9BF690")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x19BD49C", Offset = "0x19BD49C", VA = "0x19BD49C")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3CAC", Offset = "0x9B3CAC")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x200015B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3D0C", Offset = "0x9B3D0C")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x17000136")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600090E")]
				[Address(RVA = "0x21635AC", Offset = "0x21635AC", VA = "0x21635AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000137")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000910")]
				[Address(RVA = "0x21635F4", Offset = "0x21635F4", VA = "0x21635F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600090B")]
			[Address(RVA = "0x2163454", Offset = "0x2163454", VA = "0x2163454")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600090C")]
			[Address(RVA = "0x2163480", Offset = "0x2163480", VA = "0x2163480", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600090D")]
			[Address(RVA = "0x2163484", Offset = "0x2163484", VA = "0x2163484", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600090F")]
			[Address(RVA = "0x21635B4", Offset = "0x21635B4", VA = "0x21635B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x19C1F6C", Offset = "0x19C1F6C", VA = "0x19C1F6C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x19C2018", Offset = "0x19C2018", VA = "0x19C2018")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BF740", Offset = "0x9BF740")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x19C2084", Offset = "0x19C2084", VA = "0x19C2084")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x200015C")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200015D")]
		public class EffectorLink
		{
			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x21635FC", Offset = "0x21635FC", VA = "0x21635FC")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x216389C", Offset = "0x216389C", VA = "0x216389C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000917")]
			[Address(RVA = "0x2163984", Offset = "0x2163984", VA = "0x2163984")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0x2163E18", Offset = "0x2163E18", VA = "0x2163E18")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000919")]
			[Address(RVA = "0x2163F0C", Offset = "0x2163F0C", VA = "0x2163F0C")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0x2163FA4", Offset = "0x2163FA4", VA = "0x2163FA4")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x2164038", Offset = "0x2164038", VA = "0x2164038")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0x21640CC", Offset = "0x21640CC", VA = "0x21640CC")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600091D")]
			[Address(RVA = "0x2164240", Offset = "0x2164240", VA = "0x2164240")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x19C2A34", Offset = "0x19C2A34", VA = "0x19C2A34")]
		private void Start()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x19C2AB0", Offset = "0x19C2AB0", VA = "0x19C2AB0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x19C2B20", Offset = "0x19C2B20", VA = "0x19C2B20")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x19C2BE8", Offset = "0x19C2BE8", VA = "0x19C2BE8")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200015E")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC1C8", Offset = "0x9BC1C8")]
		public Transform to;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC200", Offset = "0x9BC200")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC200", Offset = "0x9BC200")]
		public float transferMotion;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x19C2BF0", Offset = "0x19C2BF0", VA = "0x19C2BF0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x19C2C2C", Offset = "0x19C2C2C", VA = "0x19C2C2C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x19C2CE0", Offset = "0x19C2CE0", VA = "0x19C2CE0")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC254", Offset = "0x9BC254")]
		public Transform leftHandTarget;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x19C4418", Offset = "0x19C4418", VA = "0x19C4418")]
		private void Start()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x19C4608", Offset = "0x19C4608", VA = "0x19C4608")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x19C47F8", Offset = "0x19C47F8", VA = "0x19C47F8")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x19C48C4", Offset = "0x19C48C4", VA = "0x19C48C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x19C49D0", Offset = "0x19C49D0", VA = "0x19C49D0")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000160")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x19C4C60", Offset = "0x19C4C60", VA = "0x19C4C60", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x19C4FEC", Offset = "0x19C4FEC", VA = "0x19C4FEC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x19C5258", Offset = "0x19C5258", VA = "0x19C5258")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000161")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x211AF60", Offset = "0x211AF60", VA = "0x211AF60")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x211B288", Offset = "0x211B288", VA = "0x211B288")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x211B308", Offset = "0x211B308", VA = "0x211B308")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000162")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000163")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3D1C", Offset = "0x9B3D1C")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x17000138")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000935")]
				[Address(RVA = "0x2161E0C", Offset = "0x2161E0C", VA = "0x2161E0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000139")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000937")]
				[Address(RVA = "0x2161E54", Offset = "0x2161E54", VA = "0x2161E54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000932")]
			[Address(RVA = "0x2161CCC", Offset = "0x2161CCC", VA = "0x2161CCC")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0x2161CF8", Offset = "0x2161CF8", VA = "0x2161CF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0x2161CFC", Offset = "0x2161CFC", VA = "0x2161CFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0x2161E14", Offset = "0x2161E14", VA = "0x2161E14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x19BA318", Offset = "0x19BA318", VA = "0x19BA318")]
		private void Start()
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x19BA444", Offset = "0x19BA444", VA = "0x19BA444")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x19BA3D8", Offset = "0x19BA3D8", VA = "0x19BA3D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BF7F0", Offset = "0x9BF7F0")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x19BA5C8", Offset = "0x19BA5C8", VA = "0x19BA5C8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x19BA6B4", Offset = "0x19BA6B4", VA = "0x19BA6B4")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x19BA79C", Offset = "0x19BA79C", VA = "0x19BA79C")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000164")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC28C", Offset = "0x9BC28C")]
		public float weight;

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x1FAD9B8", Offset = "0x1FAD9B8", VA = "0x1FAD9B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x1FADA2C", Offset = "0x1FADA2C", VA = "0x1FADA2C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x1FADAE4", Offset = "0x1FADAE4", VA = "0x1FADAE4")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000165")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000166")]
		public class Part
		{
			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x2164304", Offset = "0x2164304", VA = "0x2164304")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x2164430", Offset = "0x2164430", VA = "0x2164430")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x19C3A48", Offset = "0x19C3A48", VA = "0x19C3A48")]
		private void Update()
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x19C3AC4", Offset = "0x19C3AC4", VA = "0x19C3AC4")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x2122474", Offset = "0x2122474", VA = "0x2122474")]
		private void Update()
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x21225CC", Offset = "0x21225CC", VA = "0x21225CC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x21227B0", Offset = "0x21227B0", VA = "0x21227B0")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC2A4", Offset = "0x9BC2A4")]
		public VRIK ik;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC2DC", Offset = "0x9BC2DC")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC314", Offset = "0x9BC314")]
		public Transform headTracker;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC34C", Offset = "0x9BC34C")]
		public Transform bodyTracker;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC384", Offset = "0x9BC384")]
		public Transform leftHandTracker;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC3BC", Offset = "0x9BC3BC")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC3F4", Offset = "0x9BC3F4")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC42C", Offset = "0x9BC42C")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BC464", Offset = "0x9BC464")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x19C6978", Offset = "0x19C6978", VA = "0x19C6978")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x19C88C0", Offset = "0x19C88C0", VA = "0x19C88C0")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x1E320E4", Offset = "0x1E320E4", VA = "0x1E320E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x1E32140", Offset = "0x1E32140", VA = "0x1E32140")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x1E322C8", Offset = "0x1E322C8", VA = "0x1E322C8")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x1E322FC", Offset = "0x1E322FC", VA = "0x1E322FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x1E32780", Offset = "0x1E32780", VA = "0x1E32780")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x200016B")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x1700013A")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x1FB6AF8", Offset = "0x1FB6AF8", VA = "0x1FB6AF8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x1FB6AD4", Offset = "0x1FB6AD4", VA = "0x1FB6AD4", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x1FB6B00", Offset = "0x1FB6B00", VA = "0x1FB6B00")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x1FB6B64", Offset = "0x1FB6B64", VA = "0x1FB6B64", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x1FB6CFC", Offset = "0x1FB6CFC", VA = "0x1FB6CFC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1FB6F20", Offset = "0x1FB6F20", VA = "0x1FB6F20", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x1FB6D0C", Offset = "0x1FB6D0C", VA = "0x1FB6D0C")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x1FB6F30", Offset = "0x1FB6F30", VA = "0x1FB6F30")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3D2C", Offset = "0x9B3D2C")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x1FB6F48", Offset = "0x1FB6F48", VA = "0x1FB6F48", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x1FB6FA4", Offset = "0x1FB6FA4", VA = "0x1FB6FA4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x1FB7040", Offset = "0x1FB7040", VA = "0x1FB7040")]
		private void Update()
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x1FB7158", Offset = "0x1FB7158", VA = "0x1FB7158")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200016D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3D8C", Offset = "0x9B3D8C")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9BC4CC", Offset = "0x9BC4CC")]
		private float animSpeedMultiplier;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40009AF")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40009B0")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x1700013B")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x1FB720C", Offset = "0x1FB720C", VA = "0x1FB720C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x1FB7170", Offset = "0x1FB7170", VA = "0x1FB7170", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x1FB71F0", Offset = "0x1FB71F0", VA = "0x1FB71F0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x1FB7304", Offset = "0x1FB7304", VA = "0x1FB7304", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x1FB76CC", Offset = "0x1FB76CC", VA = "0x1FB76CC")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x1FB77D4", Offset = "0x1FB77D4", VA = "0x1FB77D4")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200016E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3DEC", Offset = "0x9B3DEC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3DEC", Offset = "0x9B3DEC")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BC510", Offset = "0x9BC510")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC510", Offset = "0x9BC510")]
		public Transform gravityTarget;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC570", Offset = "0x9BC570")]
		public float gravityMultiplier;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40009BC")]
		protected const float half = 0.5f;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x600095B")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x2085524", Offset = "0x2085524", VA = "0x2085524")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x2085654", Offset = "0x2085654", VA = "0x2085654", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x208580C", Offset = "0x208580C", VA = "0x208580C", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x20859BC", Offset = "0x20859BC", VA = "0x20859BC")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x2085A20", Offset = "0x2085A20", VA = "0x2085A20")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x2085B40", Offset = "0x2085B40", VA = "0x2085B40")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x2085C64", Offset = "0x2085C64", VA = "0x2085C64")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x2085C88", Offset = "0x2085C88", VA = "0x2085C88")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x2085CAC", Offset = "0x2085CAC", VA = "0x2085CAC")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x2085D0C", Offset = "0x2085D0C", VA = "0x2085D0C")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000170")]
		public enum MoveMode
		{
			[Token(Token = "0x40009F9")]
			Directional,
			[Token(Token = "0x40009FA")]
			Strafe
		}

		[Token(Token = "0x2000171")]
		public struct AnimState
		{
			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40009FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40009FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40009FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40009FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000A00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x4000A01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x2000172")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3E80", Offset = "0x9B3E80")]
		private sealed class <JumpSmooth>d__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x4000A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000A06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000A07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x1700013D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600097B")]
				[Address(RVA = "0x1E377D8", Offset = "0x1E377D8", VA = "0x1E377D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600097D")]
				[Address(RVA = "0x1E37820", Offset = "0x1E37820", VA = "0x1E37820", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0x1E376B4", Offset = "0x1E376B4", VA = "0x1E376B4")]
			[DebuggerHidden]
			public <JumpSmooth>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0x1E376E0", Offset = "0x1E376E0", VA = "0x1E376E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0x1E376E4", Offset = "0x1E376E4", VA = "0x1E376E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600097C")]
			[Address(RVA = "0x1E377E0", Offset = "0x1E377E0", VA = "0x1E377E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BC5A8", Offset = "0x9BC5A8")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BC5E0", Offset = "0x9BC5E0")]
		public MoveMode moveMode;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BC618", Offset = "0x9BC618")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BC650", Offset = "0x9BC650")]
		public bool smoothJump;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BC688", Offset = "0x9BC688")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9BC6C0", Offset = "0x9BC6C0")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC6F8", Offset = "0x9BC6F8")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		[Token(Token = "0x1700013C")]
		public bool onGround
		{
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x2086030", Offset = "0x2086030", VA = "0x2086030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF8A0", Offset = "0x9BF8A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x2086038", Offset = "0x2086038", VA = "0x2086038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF8B0", Offset = "0x9BF8B0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x2086044", Offset = "0x2086044", VA = "0x2086044", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x2086184", Offset = "0x2086184", VA = "0x2086184")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x2086214", Offset = "0x2086214", VA = "0x2086214", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x2086290", Offset = "0x2086290", VA = "0x2086290")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x2086E7C", Offset = "0x2086E7C", VA = "0x2086E7C", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x20870D4", Offset = "0x20870D4", VA = "0x20870D4", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x2086784", Offset = "0x2086784", VA = "0x2086784")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x20871B8", Offset = "0x20871B8", VA = "0x20871B8")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x2087660", Offset = "0x2087660", VA = "0x2087660")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x2086F04", Offset = "0x2086F04", VA = "0x2086F04")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x2087700", Offset = "0x2087700", VA = "0x2087700", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x2087A3C", Offset = "0x2087A3C", VA = "0x2087A3C")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x2087B2C", Offset = "0x2087B2C", VA = "0x2087B2C", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x2087C8C", Offset = "0x2087C8C", VA = "0x2087C8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9BF8C0", Offset = "0x9BF8C0")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x2086AD4", Offset = "0x2086AD4", VA = "0x2086AD4")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x2087D1C", Offset = "0x2087D1C", VA = "0x2087D1C")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000173")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9B3E90", Offset = "0x9B3E90")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000174")]
		public enum RotationMode
		{
			[Token(Token = "0x4000A16")]
			Smooth,
			[Token(Token = "0x4000A17")]
			Linear
		}

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC708", Offset = "0x9BC708")]
		public CameraController cameraController;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC740", Offset = "0x9BC740")]
		public float accelerationTime;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC778", Offset = "0x9BC778")]
		public float turnTime;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC7B0", Offset = "0x9BC7B0")]
		public bool walkByDefault;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC7E8", Offset = "0x9BC7E8")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC820", Offset = "0x9BC820")]
		public float moveSpeed;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC858", Offset = "0x9BC858")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x1700013F")]
		public bool isGrounded
		{
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x19C1450", Offset = "0x19C1450", VA = "0x19C1450")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF970", Offset = "0x9BF970")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x19C1458", Offset = "0x19C1458", VA = "0x19C1458")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF980", Offset = "0x9BF980")]
			private set
			{
			}
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x19C1464", Offset = "0x19C1464", VA = "0x19C1464")]
		private void Start()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x19C14F4", Offset = "0x19C14F4", VA = "0x19C14F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x19C19B4", Offset = "0x19C19B4", VA = "0x19C19B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x19C1548", Offset = "0x19C1548", VA = "0x19C1548")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x19C17C8", Offset = "0x19C17C8", VA = "0x19C17C8")]
		private void Move()
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x19C19F0", Offset = "0x19C19F0", VA = "0x19C19F0")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x19C1A8C", Offset = "0x19C1A8C", VA = "0x19C1A8C")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x19C1B10", Offset = "0x19C1B10", VA = "0x19C1B10")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x19C49D8", Offset = "0x19C49D8", VA = "0x19C49D8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x19C4A50", Offset = "0x19C4A50", VA = "0x19C4A50", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x19C4C10", Offset = "0x19C4C10", VA = "0x19C4C10")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x19C4C34", Offset = "0x19C4C34", VA = "0x19C4C34")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000176")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000177")]
		public struct State
		{
			[Token(Token = "0x4000A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x19C4A18", Offset = "0x19C4A18", VA = "0x19C4A18", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x19C4D50", Offset = "0x19C4D50", VA = "0x19C4D50", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x19C4C50", Offset = "0x19C4C50", VA = "0x19C4C50")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x1FA6984", Offset = "0x1FA6984", VA = "0x1FA6984")]
		private void Update()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x1FA69C0", Offset = "0x1FA69C0", VA = "0x1FA69C0")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000179")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x19C1E74", Offset = "0x19C1E74", VA = "0x19C1E74")]
		private void Update()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x19C1EA8", Offset = "0x19C1EA8", VA = "0x19C1EA8")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x19C1F58", Offset = "0x19C1F58", VA = "0x19C1F58")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200017A")]
	public class Navigator
	{
		[Token(Token = "0x200017B")]
		public enum State
		{
			[Token(Token = "0x4000A39")]
			Idle,
			[Token(Token = "0x4000A3A")]
			Seeking,
			[Token(Token = "0x4000A3B")]
			OnPath
		}

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC868", Offset = "0x9BC868")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC8A0", Offset = "0x9BC8A0")]
		public float cornerRadius;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC8D8", Offset = "0x9BC8D8")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC910", Offset = "0x9BC910")]
		public float maxSampleDistance;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9BC948", Offset = "0x9BC948")]
		public float nextPathInterval;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC980", Offset = "0x9BC980")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BC990", Offset = "0x9BC990")]
		private State <state>k__BackingField;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000140")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x19B72C8", Offset = "0x19B72C8", VA = "0x19B72C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF990", Offset = "0x9BF990")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000995")]
			[Address(RVA = "0x19B72D4", Offset = "0x19B72D4", VA = "0x19B72D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF9A0", Offset = "0x9BF9A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public State state
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x19B72E0", Offset = "0x19B72E0", VA = "0x19B72E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF9B0", Offset = "0x9BF9B0")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x19B72E8", Offset = "0x19B72E8", VA = "0x19B72E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9BF9C0", Offset = "0x9BF9C0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x19B72F0", Offset = "0x19B72F0", VA = "0x19B72F0")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x19B73A0", Offset = "0x19B73A0", VA = "0x19B73A0")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x19B778C", Offset = "0x19B778C", VA = "0x19B778C")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x19B7808", Offset = "0x19B7808", VA = "0x19B7808")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x19B7748", Offset = "0x19B7748", VA = "0x19B7748")]
		private void Stop()
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x19B7778", Offset = "0x19B7778", VA = "0x19B7778")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x19B7954", Offset = "0x19B7954", VA = "0x19B7954")]
		public void Visualize()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x19B7B04", Offset = "0x19B7B04", VA = "0x19B7B04")]
		public Navigator()
		{
		}
	}
}
