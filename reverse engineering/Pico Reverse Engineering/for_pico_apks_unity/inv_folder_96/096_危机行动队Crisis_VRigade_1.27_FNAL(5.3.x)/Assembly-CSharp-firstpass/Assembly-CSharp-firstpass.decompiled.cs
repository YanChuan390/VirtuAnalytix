using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class Skeleton : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PuppetMaster puppetMaster;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ConfigurableJoint[] leftLeg;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConfigurableJoint[] rightLeg;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool leftLegRemoved;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool rightLegRemoved;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x7BB018", Offset = "0x7BB018", VA = "0x7BB018")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x7BB0E0", Offset = "0x7BB0E0", VA = "0x7BB0E0")]
	private void OnMuscleRemoved(Muscle m)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x7BB1A0", Offset = "0x7BB1A0", VA = "0x7BB1A0")]
	private bool IsLegMuscle(Muscle m, out bool isLeft)
	{
		return default(bool);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x7BB2F8", Offset = "0x7BB2F8", VA = "0x7BB2F8")]
	public Skeleton()
	{
	}
}
namespace UnLogickFactory
{
	[Token(Token = "0x2000003")]
	public class FbxCustomPropertyExporterExample : MonoBehaviour
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("filename")]
		public string editorFilename;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string runtimeFilename;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int logLevel;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool manuallyExport;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x7BB300", Offset = "0x7BB300", VA = "0x7BB300")]
		private void Start()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x7BB310", Offset = "0x7BB310", VA = "0x7BB310")]
		public void Export()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x7BDFB0", Offset = "0x7BDFB0", VA = "0x7BDFB0")]
		private void OnFbxNodeCallback(Transform transform, IntPtr fbxNode)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x7BE040", Offset = "0x7BE040", VA = "0x7BE040")]
		private void OnFbxMeshCallback(Transform transform, IntPtr fbxNode, MeshRenderer meshRenderer, IntPtr fbxMesh)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x7BE12C", Offset = "0x7BE12C", VA = "0x7BE12C")]
		private void OnFbxTerrainCallback(Transform transform, IntPtr fbxNode, Terrain terrain, IntPtr fbxMesh)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x7BE230", Offset = "0x7BE230", VA = "0x7BE230")]
		private void OnFbxSkinnedMeshCallback(Transform transform, IntPtr fbxNode, SkinnedMeshRenderer skinnedMeshRenderer, IntPtr fbxMesh)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x7BE2D4", Offset = "0x7BE2D4", VA = "0x7BE2D4")]
		private void OnFbxMaterialCallback(Transform transform, IntPtr fbxNode, IntPtr fbxMaterial, IntPtr[] fbxTextures)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x7BE378", Offset = "0x7BE378", VA = "0x7BE378")]
		public FbxCustomPropertyExporterExample()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public static class AnimatorExtension
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MethodInfo _writeDefaultPoseMethodInfo;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x7BE3EC", Offset = "0x7BE3EC", VA = "0x7BE3EC")]
		public static void SetTPose(this Animator animator)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	public class FbxCustomProperty
	{
		[Token(Token = "0x2000006")]
		public enum FbxCustomPropertyType
		{
			[Token(Token = "0x4000022")]
			Color,
			[Token(Token = "0x4000023")]
			Double4,
			[Token(Token = "0x4000024")]
			Double3,
			[Token(Token = "0x4000025")]
			Double2,
			[Token(Token = "0x4000026")]
			Matrix,
			[Token(Token = "0x4000027")]
			Double,
			[Token(Token = "0x4000028")]
			Bool,
			[Token(Token = "0x4000029")]
			Long,
			[Token(Token = "0x400002A")]
			String
		}

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FbxCustomPropertyType type;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private double m11;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private double m12;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private double m13;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private double m14;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private double m21;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private double m22;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private double m23;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private double m24;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private double m31;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private double m32;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private double m33;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private double m34;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private double m41;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private double m42;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private double m43;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private double m44;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool boolValue;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string stringValue;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private long longValue;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string propertyName;

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x7BE5CC", Offset = "0x7BE5CC", VA = "0x7BE5CC")]
		public void SetValue(float value)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x7BE5E0", Offset = "0x7BE5E0", VA = "0x7BE5E0")]
		public void SetValue(Vector2 value)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x7BE5F8", Offset = "0x7BE5F8", VA = "0x7BE5F8")]
		public void SetValue(Vector3 value)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x7BE618", Offset = "0x7BE618", VA = "0x7BE618")]
		public void SetValue(Vector4 value)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x7BE638", Offset = "0x7BE638", VA = "0x7BE638")]
		public void SetValue(Color value)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x7BE654", Offset = "0x7BE654", VA = "0x7BE654")]
		public void SetValue(Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x7BE720", Offset = "0x7BE720", VA = "0x7BE720")]
		public void SetValue(bool value)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x7BE734", Offset = "0x7BE734", VA = "0x7BE734")]
		public void SetValue(string value)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x7BE744", Offset = "0x7BE744", VA = "0x7BE744")]
		public void SetValue(long value)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x7BE754", Offset = "0x7BE754", VA = "0x7BE754")]
		public void Apply(IntPtr target)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x7BEAA8", Offset = "0x7BEAA8", VA = "0x7BEAA8")]
		public FbxCustomProperty()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public abstract class FbxCustomPropertyBehaviour : MonoBehaviour
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FbxCustomProperty[] customProperties;

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x7BEAF8", Offset = "0x7BEAF8", VA = "0x7BEAF8")]
		public void Apply(IntPtr target)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x7BEB5C", Offset = "0x7BEB5C", VA = "0x7BEB5C")]
		protected FbxCustomPropertyBehaviour()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class FbxMaterialCustomProperties : FbxCustomPropertyBehaviour
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x7BEB64", Offset = "0x7BEB64", VA = "0x7BEB64")]
		public FbxMaterialCustomProperties()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class FbxMeshCustomProperties : FbxCustomPropertyBehaviour
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x7BEB6C", Offset = "0x7BEB6C", VA = "0x7BEB6C")]
		public FbxMeshCustomProperties()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class FbxNodeCustomProperties : FbxCustomPropertyBehaviour
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x7BEB74", Offset = "0x7BEB74", VA = "0x7BEB74")]
		public FbxNodeCustomProperties()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class FbxShaderProperty
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<string> shaders;

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x7BEB7C", Offset = "0x7BEB7C", VA = "0x7BEB7C")]
		public FbxShaderProperty()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class FbxSkinnedMeshCustomProperties : FbxCustomPropertyBehaviour
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x7BEBFC", Offset = "0x7BEBFC", VA = "0x7BEBFC")]
		public FbxSkinnedMeshCustomProperties()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class FbxTerrainCustomProperties : FbxCustomPropertyBehaviour
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x7BEC04", Offset = "0x7BEC04", VA = "0x7BEC04")]
		public FbxTerrainCustomProperties()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class FbxTextureCustomProperties : FbxCustomPropertyBehaviour
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x7BEC0C", Offset = "0x7BEC0C", VA = "0x7BEC0C")]
		public FbxTextureCustomProperties()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class FbxExportSettings
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FbxLODScheme LODScheme;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int logLevel;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FbxTextureExportScheme textureScheme;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int formatId;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool embedTextures;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool embedShaderProperty;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int terrainQuality;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public SkinnedMeshOptions skinnedMeshOptions;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BlendShapeOptions blendShapeOptions;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public ObjectExportMask objectExportMask;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public FbxNodeCallback OnFbxNodeCreated;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FbxMeshCallback OnFbxMeshCreated;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public FbxSkinnedMeshCallback OnFbxSkinnedMeshCreated;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public FbxTerrainCallback OnFbxTerrainCreated;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FbxMaterialCallback OnFbxMaterialCreated;

		[Token(Token = "0x17000001")]
		public bool ExportCloth
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x7BEC14", Offset = "0x7BEC14", VA = "0x7BEC14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000002")]
		public bool ExportMeshes
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x7BEC20", Offset = "0x7BEC20", VA = "0x7BEC20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000003")]
		public bool ExportSkinnedMeshes
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x7BEC2C", Offset = "0x7BEC2C", VA = "0x7BEC2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000004")]
		public bool ExportTerrains
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x7BEC38", Offset = "0x7BEC38", VA = "0x7BEC38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000005")]
		public bool ExportLights
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x7BEC44", Offset = "0x7BEC44", VA = "0x7BEC44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000006")]
		public bool ExportCameras
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x7BEC50", Offset = "0x7BEC50", VA = "0x7BEC50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x7BB618", Offset = "0x7BB618", VA = "0x7BB618")]
		public FbxExportSettings()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class FbxExportCollection
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Dictionary<Transform, IntPtr> FbxNodes;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<MeshRenderer> Meshes;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SkinnedMeshRenderer> SkinnedMeshes;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Cloth> Cloths;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Terrain> Terrains;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Camera> Cameras;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<Light> Lights;

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x7BEEF0", Offset = "0x7BEEF0", VA = "0x7BEEF0")]
		public FbxExportCollection()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public enum ObjectExportMask
	{
		[Token(Token = "0x4000044")]
		ExportMeshes = 1,
		[Token(Token = "0x4000045")]
		ExportSkinnedMeshes = 2,
		[Token(Token = "0x4000046")]
		ExportTerrains = 4,
		[Token(Token = "0x4000047")]
		ExportCloth = 8,
		[Token(Token = "0x4000048")]
		ExportCameras = 16,
		[Token(Token = "0x4000049")]
		ExportLights = 32,
		[Token(Token = "0x400004A")]
		ExportAll = 63
	}
	[Token(Token = "0x2000012")]
	public enum SkinnedMeshOptions
	{
		[Token(Token = "0x400004C")]
		ExportCurrentPose,
		[Token(Token = "0x400004D")]
		ExportTPose
	}
	[Token(Token = "0x2000013")]
	public enum BlendShapeOptions
	{
		[Token(Token = "0x400004F")]
		Reset,
		[Token(Token = "0x4000050")]
		WriteDeformations
	}
	[Token(Token = "0x2000014")]
	public delegate void FbxNodeCallback(Transform transform, IntPtr fbxNode);
	[Token(Token = "0x2000015")]
	public delegate void FbxMeshCallback(Transform transform, IntPtr fbxNode, MeshRenderer meshRenderer, IntPtr fbxMesh);
	[Token(Token = "0x2000016")]
	public delegate void FbxTerrainCallback(Transform transform, IntPtr fbxNode, Terrain terrain, IntPtr fbxMesh);
	[Token(Token = "0x2000017")]
	public delegate void FbxSkinnedMeshCallback(Transform transform, IntPtr fbxNode, SkinnedMeshRenderer skinnedMeshRenderer, IntPtr fbxMesh);
	[Token(Token = "0x2000018")]
	public delegate void FbxMaterialCallback(Transform transform, IntPtr fbxNode, IntPtr fbxMaterial, IntPtr[] fbxTextures);
	[Token(Token = "0x2000019")]
	public class FbxExporter
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int loggingLevel;

		[Token(Token = "0x17000007")]
		public static bool FbxSupported
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x7BF4E4", Offset = "0x7BF4E4", VA = "0x7BF4E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public static string Version
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x7C5584", Offset = "0x7C5584", VA = "0x7C5584")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x7BEC64", Offset = "0x7BEC64", VA = "0x7BEC64")]
		public static int GetDefaultFormat()
		{
			return default(int);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x7BFAB4", Offset = "0x7BFAB4", VA = "0x7BFAB4")]
		public static bool Export(string filename, params Transform[] roots)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x7BFBEC", Offset = "0x7BFBEC", VA = "0x7BFBEC")]
		public static bool Export(string filename, int formatId, params Transform[] roots)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x7BBCE8", Offset = "0x7BBCE8", VA = "0x7BBCE8")]
		public static bool Export(string filename, FbxExportSettings settings, params Transform[] roots)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x7C12C8", Offset = "0x7C12C8", VA = "0x7C12C8")]
		private static void EmbedShaderProperty(IntPtr node, Material[] materials, FbxShaderProperty shaderProperty)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x7C2FD4", Offset = "0x7C2FD4", VA = "0x7C2FD4")]
		private static string GetShader(Material material)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x7C30B0", Offset = "0x7C30B0", VA = "0x7C30B0")]
		private static bool IsHumanoidRoot(Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x7C007C", Offset = "0x7C007C", VA = "0x7C007C")]
		private static void ExportSkinnedMeshOrCloth(SkinnedMeshRenderer smr, Transform root, TextureExporter textureExporter, string outputPath, Dictionary<IntPtr, IntPtr> skeletonNodes, Dictionary<Material, IntPtr> materialDictionary, FbxExportSettings settings, FbxExportCollection fbxCollection)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x7C2F30", Offset = "0x7C2F30", VA = "0x7C2F30")]
		private static UnityFbxExporterBinding.EType ConvertLightType(LightType type)
		{
			return default(UnityFbxExporterBinding.EType);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x7BFB44", Offset = "0x7BFB44", VA = "0x7BFB44")]
		public static bool Export(string filename, int formatId, FbxTextureExportScheme textureScheme, int terrainQuality, FbxLODScheme LODScheme, int logLevel, params Transform[] roots)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x7C4B24", Offset = "0x7C4B24", VA = "0x7C4B24")]
		private static void RecursivelyEnsureLimb(Transform root, Transform bone, Dictionary<Transform, IntPtr> fbxNodes, Dictionary<IntPtr, IntPtr> skeletonNodes)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x7C2F50", Offset = "0x7C2F50", VA = "0x7C2F50")]
		public static void LogFormat(bool actuallyLogThis, string format, params object[] arguments)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x7C1060", Offset = "0x7C1060", VA = "0x7C1060")]
		public static void LogFormat(bool actuallyLogThis, UnityEngine.Object context, string format, params object[] arguments)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x7C4E8C", Offset = "0x7C4E8C", VA = "0x7C4E8C")]
		public static void LogWarningFormat(bool actuallyLogThis, string format, params object[] arguments)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x7BFC74", Offset = "0x7BFC74", VA = "0x7BFC74")]
		public static void LogErrorFormat(bool actuallyLogThis, string format, params object[] arguments)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x7C1EBC", Offset = "0x7C1EBC", VA = "0x7C1EBC")]
		private static bool checkIsValid(Terrain terrain, out TerrainData terrainData)
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x7C0EDC", Offset = "0x7C0EDC", VA = "0x7C0EDC")]
		private static bool checkIsValid(MeshRenderer mr, out Mesh mesh, out Material[] materials)
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x7C3160", Offset = "0x7C3160", VA = "0x7C3160")]
		private static bool checkIsValid(SkinnedMeshRenderer smr, bool exportCloth, out Transform[] bones, out Mesh mesh, out Cloth cloth, out Material[] materials)
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x7C4F10", Offset = "0x7C4F10", VA = "0x7C4F10")]
		public static void GetFormatNames(bool filterFbx, out string[] names, out int[] formatIds)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x7C4D50", Offset = "0x7C4D50", VA = "0x7C4D50")]
		private static void SkinAddCluster(IntPtr fbxSkin, IntPtr fbxCluster, IntPtr fbxRoot, Transform bone)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x7C55C4", Offset = "0x7C55C4", VA = "0x7C55C4")]
		public FbxExporter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public class FbxLODScheme
	{
		[Token(Token = "0x200001C")]
		public enum LODScheme
		{
			[Token(Token = "0x4000057")]
			IgnoreLOD = 0,
			[Token(Token = "0x4000058")]
			MainCamera = 1,
			[Token(Token = "0x4000059")]
			OtherCameras = 2,
			[Token(Token = "0x400005A")]
			AllCameras = 3,
			[Token(Token = "0x400005B")]
			PerformCulling = 4,
			[Token(Token = "0x400005C")]
			CullMainCamera = 5,
			[Token(Token = "0x400005D")]
			CullOtherCameras = 6,
			[Token(Token = "0x400005E")]
			CullAllCameras = 8
		}

		[Token(Token = "0x200001D")]
		public enum LODSchemeEnumMaskFlags
		{
			[Token(Token = "0x4000060")]
			MainCamera = 1,
			[Token(Token = "0x4000061")]
			OtherCameras = 2,
			[Token(Token = "0x4000062")]
			PerformCulling = 4
		}

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LODScheme Scheme;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera[] _lodCameras;

		[Token(Token = "0x17000009")]
		public LODSchemeEnumMaskFlags SchemeMask
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x7C5674", Offset = "0x7C5674", VA = "0x7C5674")]
			get
			{
				return default(LODSchemeEnumMaskFlags);
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x7C567C", Offset = "0x7C567C", VA = "0x7C567C")]
			set
			{
			}
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x7C5684", Offset = "0x7C5684", VA = "0x7C5684", Slot = "4")]
		public virtual void Prepare(int logLevel)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x7C5854", Offset = "0x7C5854", VA = "0x7C5854", Slot = "5")]
		public virtual void GetRenderers(LODGroup lodGroup, FbxExportCollection result, FbxExportSettings settings)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x7C5688", Offset = "0x7C5688", VA = "0x7C5688")]
		private void _Prepare()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x7C5858", Offset = "0x7C5858", VA = "0x7C5858")]
		private void _GetRenderers(LODGroup lodGroup, FbxExportCollection result, FbxExportSettings settings)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x7C5EB8", Offset = "0x7C5EB8", VA = "0x7C5EB8")]
		private bool IsCulled(Renderer renderer)
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x7C5E08", Offset = "0x7C5E08", VA = "0x7C5E08")]
		private int DetermineLODGroup(LODGroup lodGroup)
		{
			return default(int);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x7C61EC", Offset = "0x7C61EC", VA = "0x7C61EC")]
		private static int DetermineLOD(LODGroup lodGroup, Camera camera)
		{
			return default(int);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x7BEC5C", Offset = "0x7BEC5C", VA = "0x7BEC5C")]
		public FbxLODScheme()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public class FbxTextureExportScheme
	{
		[Token(Token = "0x200001F")]
		public enum TextureExportFormat
		{
			[Token(Token = "0x4000069")]
			Png,
			[Token(Token = "0x400006A")]
			Jpeg
		}

		[Token(Token = "0x2000020")]
		public enum TextureColorSpace
		{
			[Token(Token = "0x400006C")]
			NoConversion,
			[Token(Token = "0x400006D")]
			GammaToHdr,
			[Token(Token = "0x400006E")]
			HdrToGamma,
			[Token(Token = "0x400006F")]
			Experimental
		}

		[Token(Token = "0x2000021")]
		public enum TextureElements
		{
			[Token(Token = "0x4000071")]
			None = 0,
			[Token(Token = "0x4000072")]
			Meshes = 1,
			[Token(Token = "0x4000073")]
			SkinnedMeshes = 2,
			[Token(Token = "0x4000074")]
			MeshesAndSkinnedMeshes = 3,
			[Token(Token = "0x4000075")]
			Terrains = 4,
			[Token(Token = "0x4000076")]
			MeshesAndTerrains = 5,
			[Token(Token = "0x4000077")]
			SkinnedMeshesAndTerrains = 6,
			[Token(Token = "0x4000078")]
			MeshesAndSkinnedMeshesAndTerrains = 7,
			[Token(Token = "0x4000079")]
			Everything = 7
		}

		[Token(Token = "0x2000022")]
		public enum TextureElementsMask
		{
			[Token(Token = "0x400007B")]
			Meshes = 1,
			[Token(Token = "0x400007C")]
			SkinnedMeshes = 2,
			[Token(Token = "0x400007D")]
			Terrains = 4
		}

		[Token(Token = "0x2000023")]
		public enum TextureSizes
		{
			[Token(Token = "0x400007F")]
			ScaleFull,
			[Token(Token = "0x4000080")]
			ScaleHalf,
			[Token(Token = "0x4000081")]
			ScaleQuarter,
			[Token(Token = "0x4000082")]
			ScaleEighth,
			[Token(Token = "0x4000083")]
			ScaleSixteenth,
			[Token(Token = "0x4000084")]
			Scale32nd
		}

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TextureColorSpace textureColorSpace;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TextureElements textureElements;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextureSizes textureSize;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TextureExportFormat textureFormat;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] _textureExportFormatExtensions;

		[Token(Token = "0x1700000A")]
		public bool ExportMeshTextures
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x7C14F4", Offset = "0x7C14F4", VA = "0x7C14F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool ExportSkinnedMeshTextures
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x7C33A0", Offset = "0x7C33A0", VA = "0x7C33A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		public bool ExportTerrainTextures
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x7C2898", Offset = "0x7C2898", VA = "0x7C2898")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		public string textureExtension
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x7C65F0", Offset = "0x7C65F0", VA = "0x7C65F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x7C6670", Offset = "0x7C6670", VA = "0x7C6670", Slot = "4")]
		public virtual void AllocateTextures(Material mat, Renderer renderer, ref Texture2D _diffuseTexture, ref Texture2D _specularMapTexture, ref Texture2D _normalMapTexture, out int resolutionX, out int resolutionY)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x7C69B0", Offset = "0x7C69B0", VA = "0x7C69B0", Slot = "5")]
		public virtual float CalcColorSpace()
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x7BB690", Offset = "0x7BB690", VA = "0x7BB690")]
		public static FbxTextureExportScheme GetDefaultScheme()
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x7C69EC", Offset = "0x7C69EC", VA = "0x7C69EC")]
		public static FbxTextureExportScheme GetNoneScheme()
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x7C6680", Offset = "0x7C6680", VA = "0x7C6680")]
		protected void _AllocateTextures(Material mat, Renderer renderer, ref Texture2D _diffuseTexture, ref Texture2D _normalMapTexture, ref Texture2D _specularMapTexture, out int maxResolutionX, out int maxResolutionY)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x7C6A58", Offset = "0x7C6A58", VA = "0x7C6A58")]
		protected bool AllocateTextureBasedOnMaterial(Material mat, string shaderVariableName, ref Texture2D _diffuseTexture, ref int maxResolutionX, ref int maxResolutionY)
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x7C6B98", Offset = "0x7C6B98", VA = "0x7C6B98")]
		public void AllocateTexture(ref Texture2D texture, int resolutionX, int resolutionY)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x7C6CE0", Offset = "0x7C6CE0", VA = "0x7C6CE0")]
		protected void AdjustResolution(ref int resolutionX, ref int resolutionY)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x7C69D8", Offset = "0x7C69D8", VA = "0x7C69D8")]
		public FbxTextureExportScheme()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[ExecuteInEditMode]
	public class TextureExporter : MonoBehaviour
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera _exportCamera;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Texture2D _diffuseTexture;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D _normalMapTexture;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D _specularMapTexture;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RenderTexture rt;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Renderer _textureExporter;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _normalMat;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material _specularMat;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material _diffuseMat;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string _normalMapFilename;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string _specularMapFilename;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string _diffuseTextureFilename;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Dictionary<Material, Material> AlreadyProcessedMaterials;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material lastMaterial;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int renderTextureSize;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FbxTextureExportScheme currentScheme;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x7C1500", Offset = "0x7C1500", VA = "0x7C1500")]
		public static TextureExporter CreateTextureExporter()
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x7C6E40", Offset = "0x7C6E40", VA = "0x7C6E40")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x7C6FC4", Offset = "0x7C6FC4", VA = "0x7C6FC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x7C28A4", Offset = "0x7C28A4", VA = "0x7C28A4")]
		public void ProcessTerrain(Terrain terrain, int resolution, FbxTextureExportScheme textureScheme, string path)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x7C1668", Offset = "0x7C1668", VA = "0x7C1668")]
		public Material ProcessMaterial(Material mat, Renderer renderer, FbxTextureExportScheme textureScheme, string path)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x7C7214", Offset = "0x7C7214", VA = "0x7C7214")]
		protected void CleanupLastMaterial()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x7C7A70", Offset = "0x7C7A70", VA = "0x7C7A70")]
		protected Texture MakeDummyTexture(Texture texture)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x7C7334", Offset = "0x7C7334", VA = "0x7C7334")]
		protected Material SetupTerrainMaterial(Terrain terrain, int layer, TerrainLayer[] layers, Texture2D control)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x7C78A4", Offset = "0x7C78A4", VA = "0x7C78A4")]
		protected void PerformTextureExport(int resolutionX, int resolutionY)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x7C7B40", Offset = "0x7C7B40", VA = "0x7C7B40", Slot = "4")]
		public virtual void OnRenderImage(RenderTexture src, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x7C7C64", Offset = "0x7C7C64", VA = "0x7C7C64")]
		protected void ExportSingleTexture(RenderTexture src, Texture2D dest, Material mat, string filename, int textureType)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x7C7DE8", Offset = "0x7C7DE8", VA = "0x7C7DE8")]
		private bool VerifySpecular(Texture2D dest)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x7C7DE0", Offset = "0x7C7DE0", VA = "0x7C7DE0")]
		private bool VerifyNormals(Texture2D dest)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x7C7DF0", Offset = "0x7C7DF0", VA = "0x7C7DF0")]
		protected void WriteAllBytes(string filename, byte[] data)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x7C7FE8", Offset = "0x7C7FE8", VA = "0x7C7FE8")]
		protected void EnsureFolderExists(string folder)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x7C8088", Offset = "0x7C8088", VA = "0x7C8088")]
		public TextureExporter()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public static class UnityFbxExporterBinding
	{
		[Token(Token = "0x2000026")]
		private static class NativeMethods
		{
			[PreserveSig]
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x7C8568", Offset = "0x7C8568", VA = "0x7C8568")]
			public static extern IntPtr LoadLibrary(string dllToLoad);

			[PreserveSig]
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x7C9CD8", Offset = "0x7C9CD8", VA = "0x7C9CD8")]
			public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

			[PreserveSig]
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x7C9D78", Offset = "0x7C9D78", VA = "0x7C9D78")]
			public static extern bool FreeLibrary(IntPtr hModule);
		}

		[Token(Token = "0x2000027")]
		public delegate void LogCallback(string msg);

		[Token(Token = "0x2000028")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int IntVoid();

		[Token(Token = "0x2000029")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate string StringInt(int value);

		[Token(Token = "0x200002A")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool BoolInt(int value);

		[Token(Token = "0x200002B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidLogCallback(LogCallback msg);

		[Token(Token = "0x200002C")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntLogCallback(int index, LogCallback msg);

		[Token(Token = "0x200002D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidVoid();

		[Token(Token = "0x200002E")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool BoolString(string value);

		[Token(Token = "0x200002F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool BoolStringInt(string arg0, int arg1);

		[Token(Token = "0x2000030")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool BoolStringIntBool(string arg0, int arg1, bool arg2);

		[Token(Token = "0x2000031")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrString(string value);

		[Token(Token = "0x2000032")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrStringDouble3(string value, double r, double g, double b);

		[Token(Token = "0x2000033")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrStringIntPtrDoubleDoubleDouble(string value, IntPtr node, double nearPlane, double farPlane, double fieldOfView);

		[Token(Token = "0x2000034")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrStringIntPtrETypeDoubleDoubleDoubleDoubleBoolBool(string value, IntPtr node, EType lightType, double r, double g, double b, double intensity, bool enabled, bool shadows);

		[Token(Token = "0x2000035")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrStringIntPtr(string arg0, IntPtr arg1);

		[Token(Token = "0x2000036")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrStringIntPtrDouble(string arg0, IntPtr arg1, double arg2);

		[Token(Token = "0x2000037")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrVoid(LogCallback logCallback);

		[Token(Token = "0x2000038")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrIntPtr(IntPtr value);

		[Token(Token = "0x2000039")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrIntPtrDoubleArrayInt(IntPtr arg0, double[] arg1, int arg2);

		[Token(Token = "0x200003A")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrDoubleArrayInt(IntPtr arg0, double[] arg1, int arg2);

		[Token(Token = "0x200003B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrIntIntArrayInt(IntPtr arg0, int arg1, int[] arg2, int arg3);

		[Token(Token = "0x200003C")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrStringStringETextureUseEAlphaSource(string arg0, string arg1, ETextureUse arg2, EAlphaSource arg3);

		[Token(Token = "0x200003D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrIntPtrTextureChannels(IntPtr arg0, IntPtr arg1, TextureChannels arg2);

		[Token(Token = "0x200003E")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrIntPtr(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x200003F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrDoubleArrayIntString(IntPtr arg0, double[] arg1, int arg2, string arg3);

		[Token(Token = "0x2000040")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrIntPtrString(IntPtr arg0, string arg1);

		[Token(Token = "0x2000041")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrDouble3x3(IntPtr node, double rot_x, double rot_y, double rot_z, double pos_x, double pos_y, double pos_z, double scale_x, double scale_y, double scale_z);

		[Token(Token = "0x2000042")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrIntPtr3(IntPtr arg0, IntPtr arg1, IntPtr arg2);

		[Token(Token = "0x2000043")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrIntPtr3Double3x3(IntPtr arg0, IntPtr arg1, IntPtr arg2, double rot_x, double rot_y, double rot_z, double pos_x, double pos_y, double pos_z, double scale_x, double scale_y, double scale_z);

		[Token(Token = "0x2000044")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrIntDouble(IntPtr arg0, int arg1, double arg2);

		[Token(Token = "0x2000045")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtr(IntPtr arg0);

		[Token(Token = "0x2000046")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidStringIntPtrArrayDoubleArrayInt(string arg0, IntPtr[] arg1, double[] arg2, int arg3);

		[Token(Token = "0x2000047")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrDoubleArray(IntPtr cluster, double[] matrix);

		[Token(Token = "0x2000048")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrDouble3(IntPtr arg0, double arg1, double arg2, double arg3);

		[Token(Token = "0x2000049")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrDouble4(IntPtr arg0, double arg1, double arg2, double arg3, double arg4);

		[Token(Token = "0x200004A")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrIntPtrDouble16(IntPtr arg0, IntPtr arg1, double p00, double p10, double p20, double p30, double p01, double p11, double p21, double p31, double p02, double p12, double p22, double p32, double p03, double p13, double p23, double p33);

		[Token(Token = "0x200004B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool BoolIntPtr6DoubleIntPtr(IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, double arg6, IntPtr arg7, LogCallback logCallback);

		[Token(Token = "0x200004C")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int IntIntPtr(IntPtr arg0);

		[Token(Token = "0x200004D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrIntPtrInt(IntPtr arg0, int arg1);

		[Token(Token = "0x200004E")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate string StringIntPtr(IntPtr arg0);

		[Token(Token = "0x200004F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringDouble4(IntPtr arg0, string arg1, double arg2, double arg3, double arg4, double arg5);

		[Token(Token = "0x2000050")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringDouble3(IntPtr arg0, string arg1, double arg2, double arg3, double arg4);

		[Token(Token = "0x2000051")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringDouble2(IntPtr arg0, string arg1, double arg2, double arg3);

		[Token(Token = "0x2000052")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringDouble(IntPtr arg0, string arg1, double arg2);

		[Token(Token = "0x2000053")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrDouble(IntPtr arg0, double arg1);

		[Token(Token = "0x2000054")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringBool(IntPtr arg0, string arg1, bool arg2);

		[Token(Token = "0x2000055")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringLong(IntPtr arg0, string arg1, long arg2);

		[Token(Token = "0x2000056")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringMatrix(IntPtr arg0, string arg1, double p00, double p10, double p20, double p30, double p01, double p11, double p21, double p31, double p02, double p12, double p22, double p32, double p03, double p13, double p23, double p33);

		[Token(Token = "0x2000057")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringString(IntPtr arg0, string arg1, string arg2);

		[Token(Token = "0x2000058")]
		public enum EType
		{
			[Token(Token = "0x40000DA")]
			ePoint,
			[Token(Token = "0x40000DB")]
			eDirectional,
			[Token(Token = "0x40000DC")]
			eSpot,
			[Token(Token = "0x40000DD")]
			eArea,
			[Token(Token = "0x40000DE")]
			eVolume
		}

		[Token(Token = "0x2000059")]
		public enum ETextureUse
		{
			[Token(Token = "0x40000E0")]
			eStandard,
			[Token(Token = "0x40000E1")]
			eShadowMap,
			[Token(Token = "0x40000E2")]
			eLightMap,
			[Token(Token = "0x40000E3")]
			eSphericalReflectionMap,
			[Token(Token = "0x40000E4")]
			eSphereReflectionMap,
			[Token(Token = "0x40000E5")]
			eBumpNormalMap
		}

		[Token(Token = "0x200005A")]
		public enum EAlphaSource
		{
			[Token(Token = "0x40000E7")]
			eNone,
			[Token(Token = "0x40000E8")]
			eRGBIntensity,
			[Token(Token = "0x40000E9")]
			eBlack
		}

		[Token(Token = "0x200005B")]
		public enum TextureChannels
		{
			[Token(Token = "0x40000EB")]
			Diffuse,
			[Token(Token = "0x40000EC")]
			Emissive,
			[Token(Token = "0x40000ED")]
			Ambient,
			[Token(Token = "0x40000EE")]
			NormalMap,
			[Token(Token = "0x40000EF")]
			BumpMap,
			[Token(Token = "0x40000F0")]
			TransparentColor,
			[Token(Token = "0x40000F1")]
			Shininess,
			[Token(Token = "0x40000F2")]
			Specular,
			[Token(Token = "0x40000F3")]
			Reflection
		}

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 rotAdjust;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static Vector3 posAdjust;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Vector3 scaleAdjust;

		[Token(Token = "0x4000098")]
		private const string dllFilenameBase = "UnityFbxExporter";

		[Token(Token = "0x4000099")]
		private const string dllVersion = "16";

		[Token(Token = "0x400009A")]
		private const string dllExtension = "dll";

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static IntPtr exportSceneDll;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static VoidVoid Create;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static VoidVoid Destroy;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static BoolStringIntBool Save;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static IntPtrStringIntPtr MeshCreate;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static VoidLogCallback LogFbxFormats;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static IntVoid FormatsCount;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static VoidIntLogCallback GetFormat;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static BoolInt IsFormatFbx;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static IntPtrIntPtr MeshGetNode;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static IntPtrIntPtrDoubleArrayInt MeshSetVertices;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static VoidIntPtrDoubleArrayInt MeshSetNormals;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static VoidIntPtrDoubleArrayInt MeshSetColors;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static VoidIntPtrIntIntArrayInt MeshAddTriangles;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static IntPtrStringStringETextureUseEAlphaSource CreateTexture;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static IntPtrStringDouble3 CreatePhongMaterial;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static VoidIntPtrDouble4 SetTextureScale;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static VoidIntPtrIntPtrTextureChannels MaterialSetTexture;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static VoidIntPtrIntPtr MeshAddMaterial;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static VoidIntPtrDoubleArrayIntString MeshSetUV;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static IntPtrIntPtrString CreateNode;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static VoidIntPtr MakeNodeSkeleton;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static IntPtrString SkeletonCreateRoot;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static IntPtrIntPtrString SkeletonCreateLimb;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static VoidIntPtrDouble3x3 NodeSetLocal;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static IntPtrIntPtr MeshCreateSkin;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public static IntPtrIntPtr ClusterCreate;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static IntPtrIntPtr3Double3x3 SkinAddCluster;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static VoidIntPtrIntDouble ClusterAddWeight;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static VoidIntPtr MeshStoreBindPose;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public static VoidStringIntPtrArrayDoubleArrayInt MeshSetBindPose;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public static VoidIntPtrDoubleArray ClusterSetLinkMatrix;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public static VoidIntPtrDouble3 NodeSetPreRotation;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public static VoidIntPtr UpdateTransformation;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public static IntPtrVoid CreateBindPose;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public static VoidIntPtrIntPtrDouble16 AddBoneToPose;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public static BoolIntPtr6DoubleIntPtr IsValidBindPoseVerbose;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public static IntPtrVoid FbxStatusCreate;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public static IntPtrVoid NodeListCreate;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public static IntIntPtr NodeListSize;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public static IntPtrIntPtrInt NodeListGetAt;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public static StringIntPtr NodeGetName;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public static StringIntPtr PoseGetClassId;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public static StringIntPtr NodeGetClassId;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public static VoidIntPtrStringDouble4 SetColorProperty;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public static VoidIntPtrStringDouble4 SetDouble4Property;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public static VoidIntPtrStringDouble3 SetDouble3Property;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public static VoidIntPtrStringDouble2 SetDouble2Property;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public static VoidIntPtrStringMatrix SetMatrixProperty;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public static VoidIntPtrStringDouble SetDoubleProperty;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public static VoidIntPtrStringBool SetBoolProperty;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public static VoidIntPtrStringLong SetLongProperty;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public static VoidIntPtrStringString SetStringProperty;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public static IntPtrStringIntPtrDoubleDoubleDouble CameraCreate;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public static IntPtrStringIntPtrETypeDoubleDoubleDoubleDoubleBoolBool LightCreate;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public static IntPtrIntPtr AddBlendShape;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public static IntPtrStringIntPtr AddBlendChannel;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public static IntPtrStringIntPtrDouble AddBlendFrame;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public static VoidIntPtrDouble SetBlendShapeDeformPercent;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public static SkinnedMeshRenderer blendSmr;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public static Mesh blendMesh;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public static float[] blendWeights;

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x7C8104", Offset = "0x7C8104", VA = "0x7C8104")]
		public static string GetDLLPath(int logLevel = 0)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x7BF4EC", Offset = "0x7BF4EC", VA = "0x7BF4EC")]
		public static bool Init(int logLevel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x7C8508", Offset = "0x7C8508", VA = "0x7C8508")]
		private static IntPtr LoadLibrary(string path)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000082")]
		private static void SetupMethod<T>(string methodName, ref T methodDelegate) where T : class
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x7C8564", Offset = "0x7C8564", VA = "0x7C8564")]
		public static void Close()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x7C85FC", Offset = "0x7C85FC", VA = "0x7C85FC")]
		public static IntPtr ProcessMesh(Mesh sourceMesh, Material[] materials, IntPtr node)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x7C8694", Offset = "0x7C8694", VA = "0x7C8694")]
		public static IntPtr ProcessMesh(Mesh sourceMesh, Material[] materials)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x7C8738", Offset = "0x7C8738", VA = "0x7C8738")]
		public static IntPtr ProcessMesh(Mesh sourceMesh, int logLevel, Material[] materials, Vector3[] overrideVertices, Vector3[] overrideNormals, IntPtr node, Dictionary<Material, IntPtr> KnownMaterials)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x7C1DF8", Offset = "0x7C1DF8", VA = "0x7C1DF8")]
		public static IntPtr ProcessMesh(Mesh sourceMesh, int logLevel, Material[] materials, Vector3[] overrideVertices, Vector3[] overrideNormals, IntPtr node, Dictionary<Material, IntPtr> KnownMaterials, out IntPtr[] fbxMaterials, out IntPtr[][] fbxTextures)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x7C33AC", Offset = "0x7C33AC", VA = "0x7C33AC")]
		public static IntPtr ProcessMesh(Mesh sourceMesh, int logLevel, Material[] materials, Vector3[] overrideVertices, Vector3[] overrideNormals, IntPtr node, Dictionary<Material, IntPtr> KnownMaterials, out IntPtr[] fbxMaterials, out IntPtr[][] fbxTextures, BlendShapeOptions blendShapeOptions)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x7C1F5C", Offset = "0x7C1F5C", VA = "0x7C1F5C")]
		public static IntPtr ProcessTerrain(Terrain terrain, TerrainData terrainData, int terrainQuality, IntPtr node, out IntPtr material, out IntPtr[] textures)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x7C8A24", Offset = "0x7C8A24", VA = "0x7C8A24")]
		private static void FlipTriangles(int[] triangles)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x7C8A88", Offset = "0x7C8A88", VA = "0x7C8A88")]
		private static IntPtr AddTextureToMaterial(IntPtr material, Material mat, string shaderName, TextureChannels channel, ETextureUse textureUse, int logLevel)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x7C8D38", Offset = "0x7C8D38", VA = "0x7C8D38")]
		private static void CopyVectorsToDoubles(double[] dest, Vector3[] source)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x7C87F0", Offset = "0x7C87F0", VA = "0x7C87F0")]
		private static void CopyPointsToDoubles(double[] dest, Vector3[] source)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x7C8968", Offset = "0x7C8968", VA = "0x7C8968")]
		private static void CopyColorsToDoubles(double[] dest, Color[] source)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x7C88AC", Offset = "0x7C88AC", VA = "0x7C88AC")]
		private static void CopyVectorsToDoubles(double[] dest, Vector2[] source)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x7C8DF4", Offset = "0x7C8DF4", VA = "0x7C8DF4")]
		private static void AddVector3ToArray(double[] doubleData, ref Vector3 vector, ref int index)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x7C8E74", Offset = "0x7C8E74", VA = "0x7C8E74")]
		private static void AddPoint3ToArray(double[] doubleData, ref Vector3 vector, ref int index)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x7C8EF8", Offset = "0x7C8EF8", VA = "0x7C8EF8")]
		private static void AddColorToArray(double[] doubleData, ref Color color, ref int index)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x7C8F98", Offset = "0x7C8F98", VA = "0x7C8F98")]
		private static void AddVector2ToArray(double[] doubleData, ref Vector2 vector, ref int index)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x7BFCF8", Offset = "0x7BFCF8", VA = "0x7BFCF8")]
		public static FbxExportCollection ScanHierarchy(Transform rootBone, bool createRoot, FbxExportSettings settings)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x7C8FF8", Offset = "0x7C8FF8", VA = "0x7C8FF8")]
		private static void RecursiveAddTransforms(Transform bone, IntPtr fbxBone, FbxExportCollection result, bool rootLevel, FbxExportSettings settings, bool belowLODGroup)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x7C97D0", Offset = "0x7C97D0", VA = "0x7C97D0")]
		private static void AddBoneWeight(ref BoneWeight boneWeight, IntPtr[] fbxClusters, int boneWeightIndex)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x7C4CA0", Offset = "0x7C4CA0", VA = "0x7C4CA0")]
		public static void AddBoneWeights(BoneWeight[] boneWeights, IntPtr[] fbxClusters)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x7C10EC", Offset = "0x7C10EC", VA = "0x7C10EC")]
		public static void NodeSetTransform(IntPtr node, Transform transform, bool rootLevel)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x7C9A40", Offset = "0x7C9A40", VA = "0x7C9A40")]
		public static void CameraSetTransform(IntPtr node, Transform transform, bool rootLevel)
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x200005C")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200005D")]
		public enum UpdateMode
		{
			[Token(Token = "0x400011A")]
			Update,
			[Token(Token = "0x400011B")]
			FixedUpdate,
			[Token(Token = "0x400011C")]
			LateUpdate,
			[Token(Token = "0x400011D")]
			FixedLateUpdate
		}

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Header("Position")]
		public bool smoothFollow;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Distance")]
		public float distance;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x1700000E")]
		public float x
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x7CF044", Offset = "0x7CF044", VA = "0x7CF044")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x7CF04C", Offset = "0x7CF04C", VA = "0x7CF04C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public float y
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x7CF054", Offset = "0x7CF054", VA = "0x7CF054")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x7CF05C", Offset = "0x7CF05C", VA = "0x7CF05C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public float distanceTarget
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x7CF064", Offset = "0x7CF064", VA = "0x7CF064")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x7CF06C", Offset = "0x7CF06C", VA = "0x7CF06C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		private float zoomAdd
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x7CFA3C", Offset = "0x7CFA3C", VA = "0x7CFA3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x7CF074", Offset = "0x7CF074", VA = "0x7CF074", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x7CF19C", Offset = "0x7CF19C", VA = "0x7CF19C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x7CF1E4", Offset = "0x7CF1E4", VA = "0x7CF1E4", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x7CF23C", Offset = "0x7CF23C", VA = "0x7CF23C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x7CF294", Offset = "0x7CF294", VA = "0x7CF294")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x7CF1C8", Offset = "0x7CF1C8", VA = "0x7CF1C8")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x7CF420", Offset = "0x7CF420", VA = "0x7CF420")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x7CFA00", Offset = "0x7CFA00", VA = "0x7CFA00")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x7CFAA8", Offset = "0x7CFAA8", VA = "0x7CFAA8")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x7CFB68", Offset = "0x7CFB68", VA = "0x7CFB68")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x7CFB94", Offset = "0x7CFB94", VA = "0x7CFB94")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x7CFDB8", Offset = "0x7CFDB8", VA = "0x7CFDB8")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x7CFDF4", Offset = "0x7CFDF4", VA = "0x7CFDF4")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public enum Axis
	{
		[Token(Token = "0x4000124")]
		X,
		[Token(Token = "0x4000125")]
		Y,
		[Token(Token = "0x4000126")]
		Z
	}
	[Token(Token = "0x2000060")]
	public class AxisTools
	{
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x7CFE10", Offset = "0x7CFE10", VA = "0x7CFE10")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x7CFEF0", Offset = "0x7CFEF0", VA = "0x7CFEF0")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x7CFF28", Offset = "0x7CFF28", VA = "0x7CFF28")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x7D0070", Offset = "0x7D0070", VA = "0x7D0070")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x7D0024", Offset = "0x7D0024", VA = "0x7D0024")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x7D016C", Offset = "0x7D016C", VA = "0x7D016C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x7D0594", Offset = "0x7D0594", VA = "0x7D0594")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000062")]
		public class LimbOrientation
		{
			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000180")]
			[Address(RVA = "0x7D0890", Offset = "0x7D0890", VA = "0x7D0890")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000012")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x7D05DC", Offset = "0x7D05DC", VA = "0x7D05DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x7D0904", Offset = "0x7D0904", VA = "0x7D0904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x7D059C", Offset = "0x7D059C", VA = "0x7D059C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000063")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000064")]
		public enum BoneType
		{
			[Token(Token = "0x4000141")]
			Unassigned,
			[Token(Token = "0x4000142")]
			Spine,
			[Token(Token = "0x4000143")]
			Head,
			[Token(Token = "0x4000144")]
			Arm,
			[Token(Token = "0x4000145")]
			Leg,
			[Token(Token = "0x4000146")]
			Tail,
			[Token(Token = "0x4000147")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000065")]
		public enum BoneSide
		{
			[Token(Token = "0x4000149")]
			Center,
			[Token(Token = "0x400014A")]
			Left,
			[Token(Token = "0x400014B")]
			Right
		}

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x7D0BB8", Offset = "0x7D0BB8", VA = "0x7D0BB8")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x7D0E7C", Offset = "0x7D0E7C", VA = "0x7D0E7C")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x7D10B0", Offset = "0x7D10B0", VA = "0x7D10B0")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x7D1124", Offset = "0x7D1124", VA = "0x7D1124")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x7D11B8", Offset = "0x7D11B8", VA = "0x7D11B8")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x7D0D64", Offset = "0x7D0D64", VA = "0x7D0D64")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x7D1028", Offset = "0x7D1028", VA = "0x7D1028")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x7D18F0", Offset = "0x7D18F0", VA = "0x7D18F0")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x7D1748", Offset = "0x7D1748", VA = "0x7D1748")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x7D181C", Offset = "0x7D181C", VA = "0x7D181C")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x7D13A0", Offset = "0x7D13A0", VA = "0x7D13A0")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x7D143C", Offset = "0x7D143C", VA = "0x7D143C")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x7D14D8", Offset = "0x7D14D8", VA = "0x7D14D8")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x7D1574", Offset = "0x7D1574", VA = "0x7D1574")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x7D1610", Offset = "0x7D1610", VA = "0x7D1610")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x7D16AC", Offset = "0x7D16AC", VA = "0x7D16AC")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x7D1AD8", Offset = "0x7D1AD8", VA = "0x7D1AD8")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x7D12CC", Offset = "0x7D12CC", VA = "0x7D12CC")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x7D1A54", Offset = "0x7D1A54", VA = "0x7D1A54")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x7D1B38", Offset = "0x7D1B38", VA = "0x7D1B38")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x7D1BF8", Offset = "0x7D1BF8", VA = "0x7D1BF8")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x7D19E0", Offset = "0x7D19E0", VA = "0x7D19E0")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x7D1970", Offset = "0x7D1970", VA = "0x7D1970")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class BipedReferences
	{
		[Token(Token = "0x2000067")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000016")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60001B2")]
				[Address(RVA = "0x7D851C", Offset = "0x7D851C", VA = "0x7D851C")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x7D8508", Offset = "0x7D8508", VA = "0x7D8508")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000014")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x7D4BF0", Offset = "0x7D4BF0", VA = "0x7D4BF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public bool isEmpty
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x7D4F4C", Offset = "0x7D4F4C", VA = "0x7D4F4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x7D4F5C", Offset = "0x7D4F5C", VA = "0x7D4F5C", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x7D52E8", Offset = "0x7D52E8", VA = "0x7D52E8", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x7D5678", Offset = "0x7D5678", VA = "0x7D5678")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x7D5C9C", Offset = "0x7D5C9C", VA = "0x7D5C9C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x7D58D8", Offset = "0x7D58D8", VA = "0x7D58D8")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x7D64A4", Offset = "0x7D64A4", VA = "0x7D64A4")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x7D6584", Offset = "0x7D6584", VA = "0x7D6584")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x7D7000", Offset = "0x7D7000", VA = "0x7D7000")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x7D6E20", Offset = "0x7D6E20", VA = "0x7D6E20")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x7D6BC0", Offset = "0x7D6BC0", VA = "0x7D6BC0")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x7D6620", Offset = "0x7D6620", VA = "0x7D6620")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x7D6F14", Offset = "0x7D6F14", VA = "0x7D6F14")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x7D70E0", Offset = "0x7D70E0", VA = "0x7D70E0")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x7D7BA0", Offset = "0x7D7BA0", VA = "0x7D7BA0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x7D7660", Offset = "0x7D7660", VA = "0x7D7660")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x7D7E74", Offset = "0x7D7E74", VA = "0x7D7E74")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x7D79B4", Offset = "0x7D79B4", VA = "0x7D79B4")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x7D7E7C", Offset = "0x7D7E7C", VA = "0x7D7E7C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x7D7E84", Offset = "0x7D7E84", VA = "0x7D7E84")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x7D8038", Offset = "0x7D8038", VA = "0x7D8038")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x7D84A0", Offset = "0x7D84A0", VA = "0x7D84A0")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x7D5870", Offset = "0x7D5870", VA = "0x7D5870")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x7D8524", Offset = "0x7D8524", VA = "0x7D8524")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x7D852C", Offset = "0x7D852C", VA = "0x7D852C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x7D8624", Offset = "0x7D8624", VA = "0x7D8624")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class Hierarchy
	{
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x7D841C", Offset = "0x7D841C", VA = "0x7D841C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x7D8310", Offset = "0x7D8310", VA = "0x7D8310")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x7D6700", Offset = "0x7D6700", VA = "0x7D6700")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6D10", VA = "0x7D6D10")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x7D6980", Offset = "0x7D6980", VA = "0x7D6980")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x7D8634", Offset = "0x7D8634", VA = "0x7D8634")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x7D6830", Offset = "0x7D6830", VA = "0x7D6830")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x7D8728", Offset = "0x7D8728", VA = "0x7D8728")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x7D8A94", Offset = "0x7D8A94", VA = "0x7D8A94")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x7D888C", Offset = "0x7D888C", VA = "0x7D888C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x7D8C1C", Offset = "0x7D8C1C", VA = "0x7D8C1C")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000163")]
		None,
		[Token(Token = "0x4000164")]
		InOutCubic,
		[Token(Token = "0x4000165")]
		InOutQuintic,
		[Token(Token = "0x4000166")]
		InOutSine,
		[Token(Token = "0x4000167")]
		InQuintic,
		[Token(Token = "0x4000168")]
		InQuartic,
		[Token(Token = "0x4000169")]
		InCubic,
		[Token(Token = "0x400016A")]
		InQuadratic,
		[Token(Token = "0x400016B")]
		InElastic,
		[Token(Token = "0x400016C")]
		InElasticSmall,
		[Token(Token = "0x400016D")]
		InElasticBig,
		[Token(Token = "0x400016E")]
		InSine,
		[Token(Token = "0x400016F")]
		InBack,
		[Token(Token = "0x4000170")]
		OutQuintic,
		[Token(Token = "0x4000171")]
		OutQuartic,
		[Token(Token = "0x4000172")]
		OutCubic,
		[Token(Token = "0x4000173")]
		OutInCubic,
		[Token(Token = "0x4000174")]
		OutInQuartic,
		[Token(Token = "0x4000175")]
		OutElastic,
		[Token(Token = "0x4000176")]
		OutElasticSmall,
		[Token(Token = "0x4000177")]
		OutElasticBig,
		[Token(Token = "0x4000178")]
		OutSine,
		[Token(Token = "0x4000179")]
		OutBack,
		[Token(Token = "0x400017A")]
		OutBackCubic,
		[Token(Token = "0x400017B")]
		OutBackQuartic,
		[Token(Token = "0x400017C")]
		BackInCubic,
		[Token(Token = "0x400017D")]
		BackInQuartic
	}
	[Token(Token = "0x200006C")]
	public class Interp
	{
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x7D8C24", Offset = "0x7D8C24", VA = "0x7D8C24")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x7D95AC", Offset = "0x7D95AC", VA = "0x7D95AC")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x7D961C", Offset = "0x7D961C", VA = "0x7D961C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x7D9024", Offset = "0x7D9024", VA = "0x7D9024")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x7D9030", Offset = "0x7D9030", VA = "0x7D9030")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x7D9054", Offset = "0x7D9054", VA = "0x7D9054")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x7D9090", Offset = "0x7D9090", VA = "0x7D9090")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x7D90A8", Offset = "0x7D90A8", VA = "0x7D90A8")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x7D90BC", Offset = "0x7D90BC", VA = "0x7D90BC")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x7D90D0", Offset = "0x7D90D0", VA = "0x7D90D0")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x7D90E0", Offset = "0x7D90E0", VA = "0x7D90E0")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x7D9128", Offset = "0x7D9128", VA = "0x7D9128")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x7D9160", Offset = "0x7D9160", VA = "0x7D9160")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x7D9188", Offset = "0x7D9188", VA = "0x7D9188")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x7D968C", Offset = "0x7D968C", VA = "0x7D968C")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x7D91BC", Offset = "0x7D91BC", VA = "0x7D91BC")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x7D91E4", Offset = "0x7D91E4", VA = "0x7D91E4")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x7D9214", Offset = "0x7D9214", VA = "0x7D9214")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x7D9248", Offset = "0x7D9248", VA = "0x7D9248")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x7D928C", Offset = "0x7D928C", VA = "0x7D928C")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x7D92F0", Offset = "0x7D92F0", VA = "0x7D92F0")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x7D9354", Offset = "0x7D9354", VA = "0x7D9354")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x7D93A8", Offset = "0x7D93A8", VA = "0x7D93A8")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x7D93FC", Offset = "0x7D93FC", VA = "0x7D93FC")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x7D9434", Offset = "0x7D9434", VA = "0x7D9434")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x7D9468", Offset = "0x7D9468", VA = "0x7D9468")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x7D96C0", Offset = "0x7D96C0", VA = "0x7D96C0")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x7D94AC", Offset = "0x7D94AC", VA = "0x7D94AC")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x7D953C", Offset = "0x7D953C", VA = "0x7D953C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x7D956C", Offset = "0x7D956C", VA = "0x7D956C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x7D9750", Offset = "0x7D9750", VA = "0x7D9750")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x7D9758", Offset = "0x7D9758", VA = "0x7D9758")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x7D97C0", Offset = "0x7D97C0", VA = "0x7D97C0")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200006E")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x7D9828", Offset = "0x7D9828", VA = "0x7D9828")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x7D9874", Offset = "0x7D9874", VA = "0x7D9874")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x7D9930", Offset = "0x7D9930", VA = "0x7D9930")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x7D9888", Offset = "0x7D9888", VA = "0x7D9888")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x7D9944", Offset = "0x7D9944", VA = "0x7D9944")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x7D99D4", Offset = "0x7D99D4", VA = "0x7D99D4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x7D99FC", Offset = "0x7D99FC", VA = "0x7D99FC")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x7D9A48", Offset = "0x7D9A48", VA = "0x7D9A48")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x7D9AB0", Offset = "0x7D9AB0", VA = "0x7D9AB0")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x7D9C04", Offset = "0x7D9C04", VA = "0x7D9C04")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x7D9D3C", Offset = "0x7D9D3C", VA = "0x7D9D3C")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x7D9D94", Offset = "0x7D9D94", VA = "0x7D9D94")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200006F")]
	public static class QuaTools
	{
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x7D9DB8", Offset = "0x7D9DB8", VA = "0x7D9DB8")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x7D9E04", Offset = "0x7D9E04", VA = "0x7D9E04")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x7D9E50", Offset = "0x7D9E50", VA = "0x7D9E50")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x7D9F54", Offset = "0x7D9F54", VA = "0x7D9F54")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x7DA058", Offset = "0x7DA058", VA = "0x7DA058")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x7DA16C", Offset = "0x7DA16C", VA = "0x7DA16C")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x7DA214", Offset = "0x7DA214", VA = "0x7DA214")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x7DA320", Offset = "0x7DA320", VA = "0x7DA320")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x7DA488", Offset = "0x7DA488", VA = "0x7DA488")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x7DA66C", Offset = "0x7DA66C", VA = "0x7DA66C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x7DA73C", Offset = "0x7DA73C", VA = "0x7DA73C")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000070")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000017")]
		public static T instance
		{
			[Token(Token = "0x60001F9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FA")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001FB")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000018")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x7DA9DC", Offset = "0x7DA9DC", VA = "0x7DA9DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		private bool isAnimated
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x7DAC9C", Offset = "0x7DAC9C", VA = "0x7DAC9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x7DA8C0", Offset = "0x7DA8C0", VA = "0x7DA8C0")]
		public void Disable()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x7DA954", Offset = "0x7DA954", VA = "0x7DA954", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x7DA958", Offset = "0x7DA958", VA = "0x7DA958", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x7DA95C", Offset = "0x7DA95C", VA = "0x7DA95C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x7DA960", Offset = "0x7DA960", VA = "0x7DA960")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x7DA9D8", Offset = "0x7DA9D8", VA = "0x7DA9D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x7DA988", Offset = "0x7DA988", VA = "0x7DA988")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x7DAC60", Offset = "0x7DAC60", VA = "0x7DAC60")]
		private void Update()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x7DAAA8", Offset = "0x7DAAA8", VA = "0x7DAAA8")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x7DAD34", Offset = "0x7DAD34", VA = "0x7DAD34")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x7DAD80", Offset = "0x7DAD80", VA = "0x7DAD80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x7DADCC", Offset = "0x7DADCC", VA = "0x7DADCC")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x7DAE04", Offset = "0x7DAE04", VA = "0x7DAE04")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x7DAE14", Offset = "0x7DAE14", VA = "0x7DAE14")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x7DAEC8", Offset = "0x7DAEC8", VA = "0x7DAEC8")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x7DAF7C", Offset = "0x7DAF7C", VA = "0x7DAF7C")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x7DB030", Offset = "0x7DB030", VA = "0x7DB030")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public static class V3Tools
	{
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x7DB038", Offset = "0x7DB038", VA = "0x7DB038")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x7DB094", Offset = "0x7DB094", VA = "0x7DB094")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x7DB0CC", Offset = "0x7DB0CC", VA = "0x7DB0CC")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x7DB21C", Offset = "0x7DB21C", VA = "0x7DB21C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x7DB398", Offset = "0x7DB398", VA = "0x7DB398")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x7DB5E8", Offset = "0x7DB5E8", VA = "0x7DB5E8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x7DB840", Offset = "0x7DB840", VA = "0x7DB840")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x7DB9EC", Offset = "0x7DB9EC", VA = "0x7DB9EC")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000074")]
	public static class Warning
	{
		[Token(Token = "0x2000075")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x7DBBE4", Offset = "0x7DBBE4", VA = "0x7DBBE4")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x7D63F0", Offset = "0x7D63F0", VA = "0x7D63F0")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000076")]
	public class AnimationBlocker : MonoBehaviour
	{
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x7DBD90", Offset = "0x7DBD90", VA = "0x7DBD90")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x7DBE54", Offset = "0x7DBE54", VA = "0x7DBE54")]
		public AnimationBlocker()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourAnimatedStagger")]
	public class BehaviourAnimatedStagger : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000078")]
		public struct FallParams
		{
			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float startPinWeightMlp;

			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float startMuscleWeightMlp;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float losePinSpeed;
		}

		[Serializable]
		[Token(Token = "0x2000079")]
		public struct FallParamsGroup
		{
			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Muscle.Group[] groups;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FallParams fallParams;
		}

		[Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class <LoseBalance>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourAnimatedStagger <>4__this;

			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool <done>5__2;

			[Token(Token = "0x1700001A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000228")]
				[Address(RVA = "0x7DCD68", Offset = "0x7DCD68", VA = "0x7DCD68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600022A")]
				[Address(RVA = "0x7DCDB0", Offset = "0x7DCDB0", VA = "0x7DCDB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x7DC2BC", Offset = "0x7DC2BC", VA = "0x7DC2BC")]
			[DebuggerHidden]
			public <LoseBalance>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000226")]
			[Address(RVA = "0x7DC3C4", Offset = "0x7DC3C4", VA = "0x7DC3C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000227")]
			[Address(RVA = "0x7DC3C8", Offset = "0x7DC3C8", VA = "0x7DC3C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x7DCD70", Offset = "0x7DCD70", VA = "0x7DCD70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[Header("Master Properties")]
		public LayerMask groundLayers;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float animationBlendSpeed;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public float animationMag;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public float momentumMag;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public float unbalancedMuscleWeightMlp;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float unbalancedMuscleDamperAdd;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool dropProps;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float maxGetUpVelocity;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public float minHipHeight;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Header("Muscle Group Properties")]
		public FallParams defaults;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public FallParamsGroup[] groupOverrides;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[Header("Events")]
		public PuppetEvent onUngrounded;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public PuppetEvent onFallOver;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public PuppetEvent onRest;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[HideInInspector]
		public Vector3 moveVector;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[HideInInspector]
		public bool isGrounded;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[HideInInspector]
		public Vector3 forward;

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x7DBE5C", Offset = "0x7DBE5C", VA = "0x7DBE5C", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x7DC230", Offset = "0x7DC230", VA = "0x7DC230", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x7DC2B8", Offset = "0x7DC2B8", VA = "0x7DC2B8", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x7DC250", Offset = "0x7DC250", VA = "0x7DC250")]
		[IteratorStateMachine(typeof(<LoseBalance>d__23))]
		private IEnumerator LoseBalance()
		{
			return null;
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x7DC2E4", Offset = "0x7DC2E4", VA = "0x7DC2E4")]
		private FallParams GetFallParams(Muscle.Group group)
		{
			return default(FallParams);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x7DC388", Offset = "0x7DC388", VA = "0x7DC388")]
		public BehaviourAnimatedStagger()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public abstract class BehaviourBase : MonoBehaviour
	{
		[Token(Token = "0x200007C")]
		public delegate void BehaviourDelegate();

		[Token(Token = "0x200007D")]
		public delegate void HitDelegate(MuscleHit hit);

		[Token(Token = "0x200007E")]
		public delegate void CollisionDelegate(MuscleCollision collision);

		[Serializable]
		[Token(Token = "0x200007F")]
		public struct PuppetEvent
		{
			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Another Puppet Behaviour to switch to on this event. This must be the exact Type of the the Behaviour, careful with spelling.")]
			public string switchToBehaviour;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Animations to cross-fade to on this event. This is separate from the UnityEvent below because UnityEvents can't handle calls with more than one parameter such as Animator.CrossFade.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x40001C5")]
			private const string empty = "";

			[Token(Token = "0x1700001D")]
			public bool switchBehaviour
			{
				[Token(Token = "0x6000263")]
				[Address(RVA = "0x7DCCDC", Offset = "0x7DCCDC", VA = "0x7DCCDC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000264")]
			[Address(RVA = "0x7DCA90", Offset = "0x7DCA90", VA = "0x7DCA90")]
			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000080")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string animationState;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float crossfadeTime;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int layer;

			[Token(Token = "0x40001C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40001CA")]
			private const string empty = "";

			[Token(Token = "0x6000265")]
			[Address(RVA = "0x7DDDF8", Offset = "0x7DDDF8", VA = "0x7DDDF8")]
			public void Activate(Animator animator, Animation animation)
			{
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x7DDEB4", Offset = "0x7DDEB4", VA = "0x7DDEB4")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x7DDFB0", Offset = "0x7DDFB0", VA = "0x7DDFB0")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000268")]
			[Address(RVA = "0x7DE088", Offset = "0x7DE088", VA = "0x7DE088")]
			public AnimatorEvent()
			{
			}
		}

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviourDelegate OnPreActivate;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BehaviourDelegate OnPreInitiate;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BehaviourDelegate OnPreFixedUpdate;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BehaviourDelegate OnPreUpdate;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BehaviourDelegate OnPreLateUpdate;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourDelegate OnPreDeactivate;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BehaviourDelegate OnPreFixTransforms;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BehaviourDelegate OnPreRead;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public BehaviourDelegate OnPreWrite;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HitDelegate OnPreMuscleHit;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public CollisionDelegate OnPreMuscleCollision;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CollisionDelegate OnPreMuscleCollisionExit;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public BehaviourDelegate OnHierarchyChanged;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public BehaviourDelegate OnPostActivate;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BehaviourDelegate OnPostInitiate;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public BehaviourDelegate OnPostFixedUpdate;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public BehaviourDelegate OnPostUpdate;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public BehaviourDelegate OnPostLateUpdate;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public BehaviourDelegate OnPostDeactivate;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public BehaviourDelegate OnPostDrawGizmos;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public BehaviourDelegate OnPostFixTransforms;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public BehaviourDelegate OnPostRead;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public BehaviourDelegate OnPostWrite;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public HitDelegate OnPostMuscleHit;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public CollisionDelegate OnPostMuscleCollision;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public CollisionDelegate OnPostMuscleCollisionExit;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public bool deactivated;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool initiated;

		[Token(Token = "0x1700001C")]
		public bool forceActive
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x7DCE3C", Offset = "0x7DCE3C", VA = "0x7DCE3C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x7DCE44", Offset = "0x7DCE44", VA = "0x7DCE44")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x600022B")]
		public abstract void OnReactivate();

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x7DCDB8", Offset = "0x7DCDB8", VA = "0x7DCDB8", Slot = "5")]
		public virtual void Resurrect()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x7DCDBC", Offset = "0x7DCDBC", VA = "0x7DCDBC", Slot = "6")]
		public virtual void Freeze()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x7DCDC0", Offset = "0x7DCDC0", VA = "0x7DCDC0", Slot = "7")]
		public virtual void Unfreeze()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x7DCDC4", Offset = "0x7DCDC4", VA = "0x7DCDC4", Slot = "8")]
		public virtual void KillStart()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x7DCDC8", Offset = "0x7DCDC8", VA = "0x7DCDC8", Slot = "9")]
		public virtual void KillEnd()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x7DCDCC", Offset = "0x7DCDCC", VA = "0x7DCDCC", Slot = "10")]
		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x7DCDD0", Offset = "0x7DCDD0", VA = "0x7DCDD0", Slot = "11")]
		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x7DCDEC", Offset = "0x7DCDEC", VA = "0x7DCDEC", Slot = "12")]
		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x7DCE08", Offset = "0x7DCE08", VA = "0x7DCE08", Slot = "13")]
		protected virtual void OnActivate()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x7DCE0C", Offset = "0x7DCE0C", VA = "0x7DCE0C", Slot = "14")]
		protected virtual void OnDeactivate()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x7DCE10", Offset = "0x7DCE10", VA = "0x7DCE10", Slot = "15")]
		protected virtual void OnInitiate()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x7DCE14", Offset = "0x7DCE14", VA = "0x7DCE14", Slot = "16")]
		protected virtual void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x7DCE18", Offset = "0x7DCE18", VA = "0x7DCE18", Slot = "17")]
		protected virtual void OnUpdate()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x7DCE1C", Offset = "0x7DCE1C", VA = "0x7DCE1C", Slot = "18")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x7DCE20", Offset = "0x7DCE20", VA = "0x7DCE20", Slot = "19")]
		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x7DCE24", Offset = "0x7DCE24", VA = "0x7DCE24", Slot = "20")]
		protected virtual void OnFixTransformsBehaviour()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x7DCE28", Offset = "0x7DCE28", VA = "0x7DCE28", Slot = "21")]
		protected virtual void OnReadBehaviour()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x7DCE2C", Offset = "0x7DCE2C", VA = "0x7DCE2C", Slot = "22")]
		protected virtual void OnWriteBehaviour()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x7DCE30", Offset = "0x7DCE30", VA = "0x7DCE30", Slot = "23")]
		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x7DCE34", Offset = "0x7DCE34", VA = "0x7DCE34", Slot = "24")]
		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x7DCE38", Offset = "0x7DCE38", VA = "0x7DCE38", Slot = "25")]
		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x7DCE50", Offset = "0x7DCE50", VA = "0x7DCE50")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x7DCEB0", Offset = "0x7DCEB0", VA = "0x7DCEB0")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x7DCF1C", Offset = "0x7DCF1C", VA = "0x7DCF1C")]
		public void OnRead()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x7DCF88", Offset = "0x7DCF88", VA = "0x7DCF88")]
		public void OnWrite()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x7DCFF4", Offset = "0x7DCFF4", VA = "0x7DCFF4")]
		public void OnMuscleHit(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x7DD094", Offset = "0x7DD094", VA = "0x7DD094")]
		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x7DD158", Offset = "0x7DD158", VA = "0x7DD158")]
		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x7DD21C", Offset = "0x7DD21C", VA = "0x7DD21C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x7DD22C", Offset = "0x7DD22C", VA = "0x7DD22C")]
		public void Activate()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x7DD340", Offset = "0x7DD340", VA = "0x7DD340")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x7DD3A0", Offset = "0x7DD3A0", VA = "0x7DD3A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x7DD44C", Offset = "0x7DD44C", VA = "0x7DD44C")]
		private void Update()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x7DD4F8", Offset = "0x7DD4F8", VA = "0x7DD4F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x7DD5A4", Offset = "0x7DD5A4", VA = "0x7DD5A4", Slot = "26")]
		protected virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x7DD5E8", Offset = "0x7DD5E8", VA = "0x7DD5E8")]
		protected void RotateTargetToRootMuscle()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x7DD708", Offset = "0x7DD708", VA = "0x7DD708")]
		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x7DC9F0", Offset = "0x7DC9F0", VA = "0x7DC9F0")]
		protected void RemoveMusclesOfGroup(Muscle.Group group)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x7DD8A4", Offset = "0x7DD8A4", VA = "0x7DD8A4", Slot = "27")]
		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x7DD83C", Offset = "0x7DD83C", VA = "0x7DD83C")]
		protected bool MusclesContainsGroup(Muscle.Group group)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x7DC3BC", Offset = "0x7DC3BC", VA = "0x7DC3BC")]
		protected BehaviourBase()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourFall")]
	public class BehaviourFall : BehaviourBase
	{
		[Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class <SmoothActivate>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourFall <>4__this;

			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <fader>5__2;

			[Token(Token = "0x1700001E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000278")]
				[Address(RVA = "0x7DEA58", Offset = "0x7DEA58", VA = "0x7DEA58", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600027A")]
				[Address(RVA = "0x7DEAA0", Offset = "0x7DEAA0", VA = "0x7DEAA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0x7DE1D4", Offset = "0x7DE1D4", VA = "0x7DE1D4")]
			[DebuggerHidden]
			public <SmoothActivate>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000276")]
			[Address(RVA = "0x7DE898", Offset = "0x7DE898", VA = "0x7DE898", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000277")]
			[Address(RVA = "0x7DE89C", Offset = "0x7DE89C", VA = "0x7DE89C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000279")]
			[Address(RVA = "0x7DEA60", Offset = "0x7DEA60", VA = "0x7DEA60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("Animation State to crossfade to when this behaviour is activated.")]
		[LargeHeader("Animation State")]
		public string stateName;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("The duration of crossfading to 'State Name'. Value is in seconds.")]
		public float transitionDuration;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[Tooltip("Layer index containing the destination state. If no layer is specified or layer is -1, the first state that is found with the given name or hash will be played.")]
		public int layer;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Tooltip("Start time of the current destination state. Value is in seconds. If no explicit fixedTime is specified or fixedTime value is float.NegativeInfinity, the state will either be played from the start if it's not already playing, or will continue playing from its current time and no transition will happen.")]
		public float fixedTime;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[Tooltip("The layers that will be raycasted against to find colliding objects.")]
		[LargeHeader("Blending")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[Tooltip("The parameter in the Animator that blends between catch fall and writhe animations.")]
		public string blendParameter;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[Tooltip("The height of the pelvis from the ground at which will blend to writhe animation.")]
		public float writheHeight;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[Tooltip("The vertical velocity of the pelvis at which will blend to writhe animation.")]
		public float writheYVelocity;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Tooltip("The speed of blendig between the two falling animations.")]
		public float blendSpeed;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[Tooltip("The speed of blending in mapping on activation.")]
		public float blendMappingSpeed;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[LargeHeader("Ending")]
		[Tooltip("If false, this behaviour will never end.")]
		public bool canEnd;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[Tooltip("The minimum time since this behaviour activated before it can end.")]
		public float minTime;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Tooltip("If the velocity of the pelvis falls below this value, can end the behaviour.")]
		public float maxEndVelocity;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[Tooltip("Event triggered when all end conditions are met.")]
		public PuppetEvent onEnd;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private float timer;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private bool endTriggered;

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x7DE09C", Offset = "0x7DE09C", VA = "0x7DE09C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x7DE0E0", Offset = "0x7DE0E0", VA = "0x7DE0E0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x7DE124", Offset = "0x7DE124", VA = "0x7DE124", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x7DE1C0", Offset = "0x7DE1C0", VA = "0x7DE1C0", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x7DE1C8", Offset = "0x7DE1C8", VA = "0x7DE1C8", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x7DE158", Offset = "0x7DE158", VA = "0x7DE158")]
		[IteratorStateMachine(typeof(<SmoothActivate>d__21))]
		private IEnumerator SmoothActivate()
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x7DE1FC", Offset = "0x7DE1FC", VA = "0x7DE1FC", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x7DE6AC", Offset = "0x7DE6AC", VA = "0x7DE6AC", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x7DE7B0", Offset = "0x7DE7B0", VA = "0x7DE7B0", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x7DE544", Offset = "0x7DE544", VA = "0x7DE544")]
		private float GetBlendTarget(float groundHeight)
		{
			return default(float);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x7DE448", Offset = "0x7DE448", VA = "0x7DE448")]
		private float GetGroundHeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x7DE7FC", Offset = "0x7DE7FC", VA = "0x7DE7FC")]
		public BehaviourFall()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page10.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourPuppet")]
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000084")]
		public enum State
		{
			[Token(Token = "0x4000216")]
			Puppet,
			[Token(Token = "0x4000217")]
			Unpinned,
			[Token(Token = "0x4000218")]
			GetUp
		}

		[Serializable]
		[Token(Token = "0x2000085")]
		public enum NormalMode
		{
			[Token(Token = "0x400021A")]
			Active,
			[Token(Token = "0x400021B")]
			Unmapped,
			[Token(Token = "0x400021C")]
			Kinematic
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public class MasterProps
		{
			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NormalMode normalMode;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float mappingBlendSpeed;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool activateOnStaticCollisions;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float activateOnImpulse;

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x7E1EA8", Offset = "0x7E1EA8", VA = "0x7E1EA8")]
			public MasterProps()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000087")]
		public struct MuscleProps
		{
			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("How much will collisions with muscles of this group unpin parent muscles?")]
			[Range(0f, 1f)]
			public float unpinParents;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Range(0f, 1f)]
			[Tooltip("How much will collisions with muscles of this group unpin child muscles?")]
			public float unpinChildren;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("How much will collisions with muscles of this group unpin muscles of the same group?")]
			[Range(0f, 1f)]
			public float unpinGroup;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Range(0f, 1f)]
			[Tooltip("If 1, muscles of this group will always be mapped to the ragdoll.")]
			public float minMappingWeight;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If 0, muscles of this group will not be mapped to the ragdoll pose even if they are unpinned.")]
			[Range(0f, 1f)]
			public float maxMappingWeight;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, muscles of this group will have their colliders disabled while in puppet state (not unbalanced nor getting up).")]
			public bool disableColliders;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("How fast will muscles of this group regain their pin weight (multiplier)?")]
			public float regainPinSpeed;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Smaller value means more unpinning from collisions (multiplier).")]
			public float collisionResistance;

			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("If the distance from the muscle to it's target is larger than this value, the character will be knocked out.")]
			public float knockOutDistance;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The PhysicsMaterial applied to the muscles while the character is in Puppet or GetUp state. Using a lower friction material reduces the risk of muscles getting stuck and pulled out of their joints.")]
			public PhysicMaterial puppetMaterial;

			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The PhysicsMaterial applied to the muscles while the character is in Unpinned state.")]
			public PhysicMaterial unpinnedMaterial;
		}

		[Serializable]
		[Token(Token = "0x2000088")]
		public struct MusclePropsGroup
		{
			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Muscle groups to which those properties apply.")]
			public Muscle.Group[] groups;

			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The muscle properties for those muscle groups.")]
			public MuscleProps props;
		}

		[Serializable]
		[Token(Token = "0x2000089")]
		public struct CollisionResistanceMultiplier
		{
			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LayerMask layers;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Tooltip("Multiplier for the 'Collision Resistance' for these layers.")]
			public float multiplier;

			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Overrides 'Collision Threshold' for these layers.")]
			public float collisionThreshold;
		}

		[Token(Token = "0x200008A")]
		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[LargeHeader("Collision And Recovery")]
		public MasterProps masterProps;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("Will ground the target to those layers when getting up.")]
		public LayerMask groundLayers;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[Tooltip("Will unpin the muscles that collide with those layers.")]
		public LayerMask collisionLayers;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Tooltip("The collision impulse sqrMagnitude threshold under which collisions will be ignored.")]
		public float collisionThreshold;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Weight collisionResistance;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[Tooltip("Multiplies collision resistance for the specified layers.")]
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Range(1f, 30f)]
		[Tooltip("An optimisation. Will only process up to this number of collisions per physics step.")]
		public int maxCollisions;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[Range(0.001f, 10f)]
		[Tooltip("How fast will the muscles of this group regain their pin weight?")]
		public float regainPinSpeed;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Tooltip("'Boosting' is a term used for making muscles temporarily immune to collisions and/or deal more damage to the muscles of other characters. That is done by increasing Muscle.State.immunity and Muscle.State.impulseMlp. For example when you set muscle.state.immunity to 1, boostFalloff will determine how fast this value will fall back to normal (0). Use BehaviourPuppet.BoostImmunity() and BehaviourPuppet.BoostImpulseMlp() for boosting from your own scripts. It is helpful for making the puppet stronger and deliever more punch while playing a melee hitting/kicking animation.")]
		public float boostFalloff;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Tooltip("The default muscle properties. If there are no 'Group Overrides', this will be used for all muscles.")]
		[LargeHeader("Muscle Group Properties")]
		public MuscleProps defaults;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[Tooltip("Overriding default muscle properties for some muscle groups (for example making the feet stiffer or the hands looser).")]
		public MusclePropsGroup[] groupOverrides;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[Range(0.001f, 10f)]
		[Tooltip("If the distance from the muscle to it's target is larger than this value, the character will be knocked out.")]
		[LargeHeader("Losing Balance")]
		public float knockOutDistance;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[Tooltip("Smaller value makes the muscles weaker when the puppet is knocked out.")]
		[Range(0f, 1f)]
		public float unpinnedMuscleWeightMlp;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[Tooltip("Most character controllers apply supernatural accelerations to characters when changing running direction or jumping. It will require major pinning forces to be applied on the ragdoll to keep up with that acceleration. When a puppet collides with something at that point and is unpinned, those forces might shoot the puppet off to space. This variable limits the velocity of the ragdoll's Rigidbodies when the puppet is unpinned.")]
		public float maxRigidbodyVelocity;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[Range(0f, 1f)]
		[Tooltip("If a muscle has drifted farther than 'Knock Out Distance', will only unpin the puppet if it's pin weight is less than this value. Lowering this value will make puppets less likely to lose balance on minor collisions.")]
		public float pinWeightThreshold;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[Tooltip("If false, will not unbalance the puppet by muscles that have their pin weight set to 0 in PuppetMaster muscle settings.")]
		public bool unpinnedMuscleKnockout;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		[Tooltip("If true, all muscles of the 'Prop' group will be detached from the puppet when it loses balance.")]
		public bool dropProps;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
		[LargeHeader("Getting Up")]
		[Tooltip("If true, GetUp state will be triggerred automatically after 'Get Up Delay' and when the velocity of the hip muscle is less than 'Max Get Up Velocity'.")]
		public bool canGetUp;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[Tooltip("Minimum delay for getting up after loosing balance. After that time has passed, will wait for the velocity of the hip muscle to come down below 'Max Get Up Velocity' and then switch to the GetUp state.")]
		public float getUpDelay;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[Tooltip("The duration of blending the animation target from the ragdoll pose to the getting up animation once the GetUp state has been triggered.")]
		public float blendToAnimationTime;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[Tooltip("Will not get up before the velocity of the hip muscle has come down to this value.")]
		public float maxGetUpVelocity;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[Tooltip("The duration of the 'GetUp' state after which it switches to the 'Puppetä state.")]
		public float minGetUpDuration;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		[Tooltip("Collision resistance multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpCollisionResistanceMlp;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[Tooltip("Regain pin weight speed multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpRegainPinSpeedMlp;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		[Tooltip("Knock out distance multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpKnockOutDistanceMlp;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[Tooltip("Offset of the target character (in character rotation space) from the hip bone when initiating getting up animation from a prone pose. Tweak this value if your character slides a bit when starting to get up.")]
		public Vector3 getUpOffsetProne;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		[Tooltip("Offset of the target character (in character rotation space) from the hip bone when initiating getting up animation from a supine pose. Tweak this value if your character slides a bit when starting to get up.")]
		public Vector3 getUpOffsetSupine;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[Tooltip("Called when the character starts getting up from a prone pose (facing down).")]
		[LargeHeader("Events")]
		public PuppetEvent onGetUpProne;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[Tooltip("Called when the character starts getting up from a supine pose (facing up).")]
		public PuppetEvent onGetUpSupine;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[Tooltip("Called when the character is knocked out (loses balance). Doesn't matter from which state.")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[Tooltip("Called when the character is knocked out (loses balance) only from the normal Puppet state.")]
		public PuppetEvent onLoseBalanceFromPuppet;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[Tooltip("Called when the character is knocked out (loses balance) only from the GetUp state.")]
		public PuppetEvent onLoseBalanceFromGetUp;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[Tooltip("Called when the character has fully recovered and switched to the Puppet state.")]
		public PuppetEvent onRegainBalance;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public CollisionImpulseDelegate OnCollisionImpulse;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		[HideInInspector]
		public bool canMoveTarget;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private float unpinnedTimer;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private float getUpTimer;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private Vector3 hipsForward;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private Vector3 hipsUp;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private float getupAnimationBlendWeight;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private float getupAnimationBlendWeightV;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private bool getUpTargetFixed;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private NormalMode lastNormalMode;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private int collisions;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private bool eventsEnabled;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private float lastKnockOutDistance;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		private float knockOutDistanceSqr;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private bool getupDisabled;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x299")]
		private bool hasCollidedSinceGetUp;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29A")]
		private bool hasBoosted;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private Vector3 getUpPosition;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		private bool dropPropFlag;

		[Token(Token = "0x17000020")]
		public State state
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x7DEB30", Offset = "0x7DEB30", VA = "0x7DEB30")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x7DEB38", Offset = "0x7DEB38", VA = "0x7DEB38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x7DEAA8", Offset = "0x7DEAA8", VA = "0x7DEAA8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x7DEAEC", Offset = "0x7DEAEC", VA = "0x7DEAEC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x7DEB40", Offset = "0x7DEB40", VA = "0x7DEB40", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x7DED94", Offset = "0x7DED94", VA = "0x7DED94")]
		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x7DEDFC", Offset = "0x7DEDFC", VA = "0x7DEDFC", Slot = "10")]
		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x7DEE94", Offset = "0x7DEE94", VA = "0x7DEE94", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x7DF3C8", Offset = "0x7DF3C8", VA = "0x7DF3C8", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x7DFA9C", Offset = "0x7DFA9C", VA = "0x7DFA9C", Slot = "8")]
		public override void KillStart()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x7DFB24", Offset = "0x7DFB24", VA = "0x7DFB24", Slot = "9")]
		public override void KillEnd()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x7DFB2C", Offset = "0x7DFB2C", VA = "0x7DFB2C", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x7DFB9C", Offset = "0x7DFB9C", VA = "0x7DFB9C", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x7DFBA8", Offset = "0x7DFBA8", VA = "0x7DFBA8", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x7E02A4", Offset = "0x7E02A4", VA = "0x7E02A4", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x7E054C", Offset = "0x7E054C", VA = "0x7E054C")]
		private bool SetKinematic()
		{
			return default(bool);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x7E060C", Offset = "0x7E060C", VA = "0x7E060C", Slot = "21")]
		protected override void OnReadBehaviour()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x7E03F4", Offset = "0x7E03F4", VA = "0x7E03F4")]
		private void BlendMuscleMapping(int muscleIndex, ref bool to)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x7E08EC", Offset = "0x7E08EC", VA = "0x7E08EC", Slot = "11")]
		public override void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x7E0934", Offset = "0x7E0934", VA = "0x7E0934", Slot = "12")]
		public override void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x7E08B8", Offset = "0x7E08B8", VA = "0x7E08B8")]
		protected void MoveTarget(Vector3 position)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x7E0974", Offset = "0x7E0974", VA = "0x7E0974")]
		protected void RotateTarget(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x7E09A8", Offset = "0x7E09A8", VA = "0x7E09A8", Slot = "27")]
		protected override void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x7E09BC", Offset = "0x7E09BC", VA = "0x7E09BC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x7E0B74", Offset = "0x7E0B74", VA = "0x7E0B74")]
		public void Boost(float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x7E0BF8", Offset = "0x7E0BF8", VA = "0x7E0BF8")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x7E0CE8", Offset = "0x7E0CE8", VA = "0x7E0CE8")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x7E0E9C", Offset = "0x7E0E9C", VA = "0x7E0E9C")]
		public void BoostImmunity(float immunity)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x7E0C38", Offset = "0x7E0C38", VA = "0x7E0C38")]
		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x7E0F10", Offset = "0x7E0F10", VA = "0x7E0F10")]
		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x7E0FA8", Offset = "0x7E0FA8", VA = "0x7E0FA8")]
		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x7E0C94", Offset = "0x7E0C94", VA = "0x7E0C94")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x7E1014", Offset = "0x7E1014", VA = "0x7E1014")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x7E10AC", Offset = "0x7E10AC", VA = "0x7E10AC")]
		public void Unpin()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x7E1124", Offset = "0x7E1124", VA = "0x7E1124", Slot = "23")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x7E12E4", Offset = "0x7E12E4", VA = "0x7E12E4", Slot = "24")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x7E16BC", Offset = "0x7E16BC", VA = "0x7E16BC")]
		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			return default(float);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x7E11FC", Offset = "0x7E11FC", VA = "0x7E11FC")]
		private void UnPin(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x7E19A4", Offset = "0x7E19A4", VA = "0x7E19A4")]
		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x7E1860", Offset = "0x7E1860", VA = "0x7E1860")]
		private bool Activate(Collision collision, float impulse)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x7E1BA4", Offset = "0x7E1BA4", VA = "0x7E1BA4")]
		public bool IsProne()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x7E0E04", Offset = "0x7E0E04", VA = "0x7E0E04")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return default(float);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x7E18EC", Offset = "0x7E18EC", VA = "0x7E18EC")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return default(float);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x7E1C50", Offset = "0x7E1C50", VA = "0x7E1C50")]
		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x7E01DC", Offset = "0x7E01DC", VA = "0x7E01DC")]
		private MuscleProps GetProps(Muscle.Group group)
		{
			return default(MuscleProps);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x7DF44C", Offset = "0x7DF44C", VA = "0x7DF44C")]
		public void SetState(State newState)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x7E1D1C", Offset = "0x7E1D1C", VA = "0x7E1D1C")]
		public void SetColliders(bool unpinned)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x7DEBF0", Offset = "0x7DEBF0", VA = "0x7DEBF0")]
		private void SetColliders(Muscle m, bool unpinned)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x7E1D98", Offset = "0x7E1D98", VA = "0x7E1D98")]
		public BehaviourPuppet()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourTemplate")]
	public class BehaviourTemplate : BehaviourBase
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float loseBalanceAngle;

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x7E207C", Offset = "0x7E207C", VA = "0x7E207C", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x7E209C", Offset = "0x7E209C", VA = "0x7E209C", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x7E20A0", Offset = "0x7E20A0", VA = "0x7E20A0", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x7E20A4", Offset = "0x7E20A4", VA = "0x7E20A4", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x7E20A8", Offset = "0x7E20A8", VA = "0x7E20A8", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x7E20E4", Offset = "0x7E20E4", VA = "0x7E20E4", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x7E20E8", Offset = "0x7E20E8", VA = "0x7E20E8", Slot = "23")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x7E20F0", Offset = "0x7E20F0", VA = "0x7E20F0", Slot = "24")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x7E20F8", Offset = "0x7E20F8", VA = "0x7E20F8")]
		public BehaviourTemplate()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008C")]
	public class SubBehaviourBalancer : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x200008D")]
		public class Settings
		{
			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Ankle joint damper / spring. Increase to make the balancing effect softer.")]
			public float damperForSpring;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier for joint max force.")]
			public float maxForceMlp;

			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Multiplier for the inertia tensor. Increasing this will increase the balancing forces.")]
			public float IMlp;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Velocity-based prediction.")]
			public float velocityF;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space offset for the center of pressure. Can be used to make the characer lean in a certain direction.")]
			public Vector3 copOffset;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The amount of torque applied to the lower legs to help keep the puppet balanced. Note that this is an external force (not coming from the joints themselves) and might make the simulation seem unnatural.")]
			public float torqueMlp;

			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Maximum magnitude of the torque applied to the lower legs if 'Torque Mlp' > 0.")]
			public float maxTorqueMag;

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x7E2884", Offset = "0x7E2884", VA = "0x7E2884")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Settings settings;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] copPoints;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PressureSensor pressureSensor;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody Ibody;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 I;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion toJointSpace;

		[Token(Token = "0x17000021")]
		public ConfigurableJoint joint
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x7E2108", Offset = "0x7E2108", VA = "0x7E2108")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x7E2110", Offset = "0x7E2110", VA = "0x7E2110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public Vector3 dir
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x7E2118", Offset = "0x7E2118", VA = "0x7E2118")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x7E2124", Offset = "0x7E2124", VA = "0x7E2124")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Vector3 dirVel
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x7E2130", Offset = "0x7E2130", VA = "0x7E2130")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x7E213C", Offset = "0x7E213C", VA = "0x7E213C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Vector3 cop
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x7E2148", Offset = "0x7E2148", VA = "0x7E2148")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x7E2154", Offset = "0x7E2154", VA = "0x7E2154")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Vector3 com
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x7E2160", Offset = "0x7E2160", VA = "0x7E2160")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x7E216C", Offset = "0x7E216C", VA = "0x7E216C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3 comV
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x7E2178", Offset = "0x7E2178", VA = "0x7E2178")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x7E2184", Offset = "0x7E2184", VA = "0x7E2184")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x7E2190", Offset = "0x7E2190", VA = "0x7E2190")]
		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x7E22A0", Offset = "0x7E22A0", VA = "0x7E22A0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x7E27C0", Offset = "0x7E27C0", VA = "0x7E27C0")]
		public SubBehaviourBalancer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008E")]
	public abstract class SubBehaviourBase
	{
		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected BehaviourBase behaviour;

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x7E28A0", Offset = "0x7E28A0", VA = "0x7E28A0")]
		protected static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x7E28A8", Offset = "0x7E28A8", VA = "0x7E28A8")]
		protected static Vector3 XYZ(Vector2 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x7E28B4", Offset = "0x7E28B4", VA = "0x7E28B4")]
		protected static Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x7E28BC", Offset = "0x7E28BC", VA = "0x7E28BC")]
		protected static Vector3 SetY(Vector3 v, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x7E287C", Offset = "0x7E287C", VA = "0x7E287C")]
		protected SubBehaviourBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008F")]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000090")]
		public enum Mode
		{
			[Token(Token = "0x400025E")]
			FeetCentroid,
			[Token(Token = "0x400025F")]
			CenterOfPressure
		}

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode mode;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float velocityDamper;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityLerpSpeed;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float velocityMax;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centerOfPressureSpeed;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public bool[] groundContacts;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3[] groundContactPoints;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private LayerMask groundLayers;

		[Token(Token = "0x17000027")]
		public Vector3 position
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x7E28C4", Offset = "0x7E28C4", VA = "0x7E28C4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x7E28D0", Offset = "0x7E28D0", VA = "0x7E28D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public Vector3 direction
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x7E28DC", Offset = "0x7E28DC", VA = "0x7E28DC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x7E28E8", Offset = "0x7E28E8", VA = "0x7E28E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public float angle
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x7E28F4", Offset = "0x7E28F4", VA = "0x7E28F4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x7E28FC", Offset = "0x7E28FC", VA = "0x7E28FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Vector3 velocity
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x7E2904", Offset = "0x7E2904", VA = "0x7E2904")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x7E2910", Offset = "0x7E2910", VA = "0x7E2910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Vector3 centerOfPressure
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x7E291C", Offset = "0x7E291C", VA = "0x7E291C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x7E2928", Offset = "0x7E2928", VA = "0x7E2928")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public Quaternion rotation
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x7E2934", Offset = "0x7E2934", VA = "0x7E2934")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x7E2940", Offset = "0x7E2940", VA = "0x7E2940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public Quaternion inverseRotation
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x7E294C", Offset = "0x7E294C", VA = "0x7E294C")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x7E2958", Offset = "0x7E2958", VA = "0x7E2958")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public bool isGrounded
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x7E2964", Offset = "0x7E2964", VA = "0x7E2964")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x7E296C", Offset = "0x7E296C", VA = "0x7E296C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public float lastGroundedTime
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x7E2978", Offset = "0x7E2978", VA = "0x7E2978")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x7E2980", Offset = "0x7E2980", VA = "0x7E2980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x7DBE7C", Offset = "0x7DBE7C", VA = "0x7DBE7C")]
		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x7E2988", Offset = "0x7E2988", VA = "0x7E2988")]
		private void OnHierarchyChanged()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x7E2A2C", Offset = "0x7E2A2C", VA = "0x7E2A2C")]
		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x7E2C34", Offset = "0x7E2C34", VA = "0x7E2C34")]
		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x7E2D38", Offset = "0x7E2D38", VA = "0x7E2D38")]
		private void OnPreActivate()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x7E3118", Offset = "0x7E3118", VA = "0x7E3118")]
		private void OnPreLateUpdate()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x7E374C", Offset = "0x7E374C", VA = "0x7E374C")]
		private void OnPreDeactivate()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x7E2B38", Offset = "0x7E2B38", VA = "0x7E2B38")]
		private Vector3 GetCollisionCOP(Collision collision)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x7E3470", Offset = "0x7E3470", VA = "0x7E3470")]
		private bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x7E2EEC", Offset = "0x7E2EEC", VA = "0x7E2EEC")]
		private Vector3 GetCenterOfMass()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x7E35B4", Offset = "0x7E35B4", VA = "0x7E35B4")]
		private Vector3 GetCenterOfMassVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x7E37A4", Offset = "0x7E37A4", VA = "0x7E37A4")]
		private Vector3 GetMomentum()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x7E34C8", Offset = "0x7E34C8", VA = "0x7E34C8")]
		private Vector3 GetCenterOfPressure()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x7E3020", Offset = "0x7E3020", VA = "0x7E3020")]
		private Vector3 GetFeetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x7E38D8", Offset = "0x7E38D8", VA = "0x7E38D8")]
		public SubBehaviourCOM()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public class Booster
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("If true, all the muscles will be boosted and the 'Muscles' and 'Groups' properties below will be ignored.")]
		public bool fullBody;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Muscles to boost. Used only when 'Full Body' is false.")]
		public ConfigurableJoint[] muscles;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Muscle groups to boost. Used only when 'Full Body' is false.")]
		public Muscle.Group[] groups;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("Immunity to apply to the muscles. If muscle immunity is 1, it can not be damaged.")]
		public float immunity;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Impulse multiplier to be applied to the muscles. This makes them deal more damage to other puppets.")]
		public float impulseMlp;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Falloff for parent muscles (power of kinship degree).")]
		public float boostParents;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Falloff for child muscles (power of kinship degree).")]
		public float boostChildren;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("This does nothing on it's own, you can use it in a 'yield return new WaitForseconds(delay);' call.")]
		public float delay;

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x7E38EC", Offset = "0x7E38EC", VA = "0x7E38EC")]
		public void Boost(BehaviourPuppet puppet)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x7E3AE0", Offset = "0x7E3AE0", VA = "0x7E3AE0")]
		public Booster()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		public int muscleIndex;

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x7E3B64", Offset = "0x7E3B64", VA = "0x7E3B64")]
		private void OnJointBreak()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x7E3BD0", Offset = "0x7E3BD0", VA = "0x7E3BD0")]
		public JointBreakBroadcaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	public class Muscle
	{
		[Serializable]
		[Token(Token = "0x2000094")]
		public enum Group
		{
			[Token(Token = "0x400029C")]
			Hips,
			[Token(Token = "0x400029D")]
			Spine,
			[Token(Token = "0x400029E")]
			Head,
			[Token(Token = "0x400029F")]
			Arm,
			[Token(Token = "0x40002A0")]
			Hand,
			[Token(Token = "0x40002A1")]
			Leg,
			[Token(Token = "0x40002A2")]
			Foot,
			[Token(Token = "0x40002A3")]
			Tail,
			[Token(Token = "0x40002A4")]
			Prop
		}

		[Serializable]
		[Token(Token = "0x2000095")]
		public class Props
		{
			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Which body part does this muscle belong to?")]
			public Group group;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Range(0f, 1f)]
			[Tooltip("The weight (multiplier) of mapping this muscle's target to the muscle.")]
			public float mappingWeight;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight (multiplier) of pinning this muscle to it's target's position using a simple AddForce command.")]
			[Range(0f, 1f)]
			public float pinWeight;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			[Tooltip("The muscle strength (multiplier).")]
			public float muscleWeight;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplier of the positionDamper of the ConfigurableJoints' Slerp Drive.")]
			[Range(0f, 1f)]
			public float muscleDamper;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("If true, will map the target to the world space position of the muscle. Normally this should be true for only the root muscle (the hips).")]
			public bool mapPosition;

			[Token(Token = "0x6000323")]
			[Address(RVA = "0x7E800C", Offset = "0x7E800C", VA = "0x7E800C")]
			public Props()
			{
			}

			[Token(Token = "0x6000324")]
			[Address(RVA = "0x7E8040", Offset = "0x7E8040", VA = "0x7E8040")]
			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
			{
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x7E80A0", Offset = "0x7E80A0", VA = "0x7E80A0")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x2000096")]
		public struct State
		{
			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float mappingWeightMlp;

			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float pinWeightMlp;

			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float muscleWeightMlp;

			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxForceMlp;

			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float muscleDamperMlp;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float muscleDamperAdd;

			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float immunity;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float impulseMlp;

			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 velocity;

			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 angularVelocity;

			[Token(Token = "0x1700003E")]
			public static State Default
			{
				[Token(Token = "0x6000326")]
				[Address(RVA = "0x7E80F0", Offset = "0x7E80F0", VA = "0x7E80F0")]
				get
				{
					return default(State);
				}
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x7E810C", Offset = "0x7E810C", VA = "0x7E810C")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public string name;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ConfigurableJoint joint;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Props props;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public State state;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public int[] parentIndexes;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public int[] childIndexes;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public bool[] childFlags;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public int[] kinshipDegrees;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 positionOffset;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private JointDrive slerpDrive;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float lastJointDriveRotationWeight;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float lastRotationDamper;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Vector3 defaultTargetLocalPosition;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Vector3 lastMappedPosition;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Quaternion localRotationConvert;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Quaternion toParentSpace;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Quaternion targetAnimatedRotation;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Quaternion targetAnimatedWorldRotation;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Quaternion rotationRelativeToTarget;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private Quaternion lastMappedRotation;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Transform targetParent;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Transform connectedBodyTransform;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private ConfigurableJointMotion angularXMotionDefault;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private ConfigurableJointMotion angularYMotionDefault;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private ConfigurableJointMotion angularZMotionDefault;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private bool directTargetParent;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x215")]
		private bool initiated;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Collider[] _colliders;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private float lastReadTime;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private float lastWriteTime;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private bool[] disabledColliders;

		[Token(Token = "0x17000030")]
		public Transform transform
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x7E3BD8", Offset = "0x7E3BD8", VA = "0x7E3BD8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x7E3BE0", Offset = "0x7E3BE0", VA = "0x7E3BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x7E3BE8", Offset = "0x7E3BE8", VA = "0x7E3BE8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x7E3BF0", Offset = "0x7E3BF0", VA = "0x7E3BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public Transform connectedBodyTarget
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x7E3BF8", Offset = "0x7E3BF8", VA = "0x7E3BF8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x7E3C00", Offset = "0x7E3C00", VA = "0x7E3C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public Vector3 targetAnimatedPosition
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x7E3C08", Offset = "0x7E3C08", VA = "0x7E3C08")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x7E3C14", Offset = "0x7E3C14", VA = "0x7E3C14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public Collider[] colliders
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x7E3C20", Offset = "0x7E3C20", VA = "0x7E3C20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public Vector3 targetVelocity
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x7E3C28", Offset = "0x7E3C28", VA = "0x7E3C28")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x7E3C34", Offset = "0x7E3C34", VA = "0x7E3C34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Vector3 targetAngularVelocity
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x7E3C40", Offset = "0x7E3C40", VA = "0x7E3C40")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x7E3C4C", Offset = "0x7E3C4C", VA = "0x7E3C4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public Vector3 mappedVelocity
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x7E3C58", Offset = "0x7E3C58", VA = "0x7E3C58")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x7E3C64", Offset = "0x7E3C64", VA = "0x7E3C64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public Vector3 mappedAngularVelocity
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x7E3C70", Offset = "0x7E3C70", VA = "0x7E3C70")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x7E3C7C", Offset = "0x7E3C7C", VA = "0x7E3C7C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public Quaternion targetRotationRelative
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x7E3C88", Offset = "0x7E3C88", VA = "0x7E3C88")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x7E3C98", Offset = "0x7E3C98", VA = "0x7E3C98")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		private Quaternion localRotation
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x7E4FAC", Offset = "0x7E4FAC", VA = "0x7E4FAC")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700003B")]
		private Quaternion parentRotation
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x7E5124", Offset = "0x7E5124", VA = "0x7E5124")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700003C")]
		private Quaternion targetParentRotation
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x7E506C", Offset = "0x7E506C", VA = "0x7E506C")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700003D")]
		private Quaternion targetLocalRotation
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x7E5258", Offset = "0x7E5258", VA = "0x7E5258")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x7E3CA8", Offset = "0x7E3CA8", VA = "0x7E3CA8")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x7E3E80", Offset = "0x7E3E80", VA = "0x7E3E80", Slot = "4")]
		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x7E4E60", Offset = "0x7E4E60", VA = "0x7E4E60")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x7E5934", Offset = "0x7E5934", VA = "0x7E5934")]
		public void DisableColliders()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x7E59E0", Offset = "0x7E59E0", VA = "0x7E59E0")]
		public void EnableColliders()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x7E55E8", Offset = "0x7E55E8", VA = "0x7E55E8")]
		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x7E5838", Offset = "0x7E5838", VA = "0x7E5838")]
		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x7E5A80", Offset = "0x7E5A80", VA = "0x7E5A80")]
		public void IgnoreCollisions(Muscle m, bool ignore)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x7E5C2C", Offset = "0x7E5C2C", VA = "0x7E5C2C")]
		public void IgnoreAngularLimits(bool ignore)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x7E5CC8", Offset = "0x7E5CC8", VA = "0x7E5CC8")]
		public void FixTargetTransforms()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x7E5D24", Offset = "0x7E5D24", VA = "0x7E5D24")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x7E5F24", Offset = "0x7E5F24", VA = "0x7E5F24")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x7E5398", Offset = "0x7E5398", VA = "0x7E5398")]
		public void Read()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x7E6018", Offset = "0x7E6018", VA = "0x7E6018")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x7E6124", Offset = "0x7E6124", VA = "0x7E6124")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x7E63C4", Offset = "0x7E63C4", VA = "0x7E63C4", Slot = "5")]
		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x7E6860", Offset = "0x7E6860", VA = "0x7E6860")]
		public void Map(float mappingWeightMaster)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x7E6C44", Offset = "0x7E6C44", VA = "0x7E6C44")]
		public void CalculateMappedVelocity()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x7E64A4", Offset = "0x7E64A4", VA = "0x7E64A4")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x7E66B4", Offset = "0x7E66B4", VA = "0x7E66B4")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x7E6D90", Offset = "0x7E6D90", VA = "0x7E6D90")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x7E6364", Offset = "0x7E6364", VA = "0x7E6364")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x7E4F78", Offset = "0x7E4F78", VA = "0x7E4F78")]
		private Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x7E6EB8", Offset = "0x7E6EB8", VA = "0x7E6EB8")]
		public Muscle()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public struct MuscleCollision
	{
		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Collision collision;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isStay;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x7E8160", Offset = "0x7E8160", VA = "0x7E8160")]
		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
		}
	}
	[Token(Token = "0x2000098")]
	public struct MuscleHit
	{
		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float unPin;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 force;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 position;

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x7E8174", Offset = "0x7E8174", VA = "0x7E8174")]
		public MuscleHit(int muscleIndex, float unPin, Vector3 force, Vector3 position)
		{
		}
	}
	[Token(Token = "0x2000099")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Muscle Collision Broadcaster")]
	public class MuscleCollisionBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		public int muscleIndex;

		[Token(Token = "0x40002BE")]
		private const string onMuscleHit = "OnMuscleHit";

		[Token(Token = "0x40002BF")]
		private const string onMuscleCollision = "OnMuscleCollision";

		[Token(Token = "0x40002C0")]
		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MuscleCollisionBroadcaster otherBroadcaster;

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x7E818C", Offset = "0x7E818C", VA = "0x7E818C")]
		public void Hit(float unPin, Vector3 force, Vector3 position)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x7E8264", Offset = "0x7E8264", VA = "0x7E8264")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x7E83E8", Offset = "0x7E83E8", VA = "0x7E83E8")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x7E8620", Offset = "0x7E8620", VA = "0x7E8620")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x7E884C", Offset = "0x7E884C", VA = "0x7E884C")]
		public MuscleCollisionBroadcaster()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public static class PhysXTools
	{
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x7E8854", Offset = "0x7E8854", VA = "0x7E8854")]
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x7E89B0", Offset = "0x7E89B0", VA = "0x7E89B0")]
		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x7E8B0C", Offset = "0x7E8B0C", VA = "0x7E8B0C")]
		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x7E8BAC", Offset = "0x7E8BAC", VA = "0x7E8BAC")]
		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x7E8C3C", Offset = "0x7E8C3C", VA = "0x7E8C3C")]
		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x7E8D3C", Offset = "0x7E8D3C", VA = "0x7E8D3C")]
		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x7E90D4", Offset = "0x7E90D4", VA = "0x7E90D4")]
		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x7E92A4", Offset = "0x7E92A4", VA = "0x7E92A4")]
		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x7E944C", Offset = "0x7E944C", VA = "0x7E944C")]
		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x7E95A8", Offset = "0x7E95A8", VA = "0x7E95A8")]
		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x7E95E8", Offset = "0x7E95E8", VA = "0x7E95E8")]
		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x7E9694", Offset = "0x7E9694", VA = "0x7E9694")]
		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x7E8B9C", Offset = "0x7E8B9C", VA = "0x7E8B9C")]
		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200009B")]
	public class PressureSensor : MonoBehaviour
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool visualize;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool fixedFrame;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 P;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int count;

		[Token(Token = "0x1700003F")]
		public Vector3 center
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x7E96C8", Offset = "0x7E96C8", VA = "0x7E96C8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x7E96D4", Offset = "0x7E96D4", VA = "0x7E96D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public bool inContact
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x7E96E0", Offset = "0x7E96E0", VA = "0x7E96E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x7E96E8", Offset = "0x7E96E8", VA = "0x7E96E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public Vector3 bottom
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x7E96F4", Offset = "0x7E96F4", VA = "0x7E96F4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x7E9700", Offset = "0x7E9700", VA = "0x7E9700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public Rigidbody r
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x7E970C", Offset = "0x7E970C", VA = "0x7E970C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x7E9714", Offset = "0x7E9714", VA = "0x7E9714")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x7E971C", Offset = "0x7E971C", VA = "0x7E971C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x7E9790", Offset = "0x7E9790", VA = "0x7E9790")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x7E98E4", Offset = "0x7E98E4", VA = "0x7E98E4")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x7E98E8", Offset = "0x7E98E8", VA = "0x7E98E8")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x7E98F0", Offset = "0x7E98F0", VA = "0x7E98F0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x7E9968", Offset = "0x7E9968", VA = "0x7E9968")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x7E9794", Offset = "0x7E9794", VA = "0x7E9794")]
		private void ProcessCollision(Collision c)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x7E99A4", Offset = "0x7E99A4", VA = "0x7E99A4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x7E99C8", Offset = "0x7E99C8", VA = "0x7E99C8")]
		public PressureSensor()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public abstract class Prop : MonoBehaviour
	{
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("This has no other purpose but helping you distinguish props by PropRoot.currentProp.propType.")]
		public int propType;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Muscle of this prop.")]
		[LargeHeader("Muscle")]
		public ConfigurableJoint muscle;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The muscle properties that will be applied to the Muscle on pickup.")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("If true, this prop's layer will be forced to PuppetMaster layer and target's layer forced to PuppetMaster's Target Root's layer when the prop is picked up.")]
		public bool forceLayers;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[LargeHeader("Additional Pin")]
		[Tooltip("Optinal additional pin, useful for long melee weapons that would otherwise require a lot of muscle force and solver iterations to be swinged quickly. Should normally be without any colliders attached. The position of the pin, it's mass and the pin weight will effect how the prop will handle.")]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Target Transform for the additional pin.")]
		public Transform additionalPinTarget;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The pin weight of the additional pin. Increasing this weight will make the prop follow animation better, but will increase jitter when colliding with objects.")]
		[Range(0f, 1f)]
		public float additionalPinWeight;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ConfigurableJointMotion xMotion;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private ConfigurableJointMotion yMotion;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ConfigurableJointMotion zMotion;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private ConfigurableJointMotion angularXMotion;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ConfigurableJointMotion angularYMotion;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private ConfigurableJointMotion angularZMotion;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Collider[] colliders;

		[Token(Token = "0x17000043")]
		public bool isPickedUp
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x7E99D0", Offset = "0x7E99D0", VA = "0x7E99D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		public PropRoot propRoot
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x7E9A30", Offset = "0x7E9A30", VA = "0x7E9A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x7E9A38", Offset = "0x7E9A38", VA = "0x7E9A38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x7E9A40", Offset = "0x7E9A40", VA = "0x7E9A40")]
		public void PickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x7E9BD0", Offset = "0x7E9BD0", VA = "0x7E9BD0")]
		public void Drop()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x7E9BE0", Offset = "0x7E9BE0", VA = "0x7E9BE0")]
		public void StartPickedUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x7E9BE8", Offset = "0x7E9BE8", VA = "0x7E9BE8", Slot = "4")]
		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x7E9BEC", Offset = "0x7E9BEC", VA = "0x7E9BEC", Slot = "5")]
		protected virtual void OnDrop()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x7E9BF0", Offset = "0x7E9BF0", VA = "0x7E9BF0", Slot = "6")]
		protected virtual void OnStart()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x7E9BF4", Offset = "0x7E9BF4", VA = "0x7E9BF4", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x7E9DB8", Offset = "0x7E9DB8", VA = "0x7E9DB8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x7E9DE4", Offset = "0x7E9DE4", VA = "0x7E9DE4")]
		private void ReleaseJoint()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x7E9F18", Offset = "0x7E9F18", VA = "0x7E9F18")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x7EA0A0", Offset = "0x7EA0A0", VA = "0x7EA0A0")]
		protected Prop()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Prop Root")]
	public class PropRoot : MonoBehaviour
	{
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the PuppetMaster component.")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If a prop is connected, what will it's joint be connected to?")]
		public Rigidbody connectTo;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Is there a Prop connected to this PropRoot? Simply assign this value to connect, replace or drop props.")]
		public Prop currentProp;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Prop lastProp;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool fixedUpdateCalled;

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x7EA158", Offset = "0x7EA158", VA = "0x7EA158")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x7EA19C", Offset = "0x7EA19C", VA = "0x7EA19C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x7EA1E0", Offset = "0x7EA1E0", VA = "0x7EA1E0")]
		public void DropImmediate()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x7EAFC0", Offset = "0x7EAFC0", VA = "0x7EAFC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x7EB038", Offset = "0x7EB038", VA = "0x7EB038")]
		private void Update()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x7EB140", Offset = "0x7EB140", VA = "0x7EB140")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x7EB2DC", Offset = "0x7EB2DC", VA = "0x7EB2DC")]
		private void AttachProp(Prop prop)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x7EBDE0", Offset = "0x7EBDE0", VA = "0x7EBDE0")]
		public PropRoot()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Prop Template")]
	public class PropTemplate : Prop
	{
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x7EBDE8", Offset = "0x7EBDE8", VA = "0x7EBDE8", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x7EBDEC", Offset = "0x7EBDEC", VA = "0x7EBDEC", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x7EBDF0", Offset = "0x7EBDF0", VA = "0x7EBDF0", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x7EBDF4", Offset = "0x7EBDF4", VA = "0x7EBDF4")]
		public PropTemplate()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[HelpURL("https://www.youtube.com/watch?v=LYusqeqHAUc")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Puppet Master")]
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A0")]
		public enum Mode
		{
			[Token(Token = "0x4000328")]
			Active,
			[Token(Token = "0x4000329")]
			Kinematic,
			[Token(Token = "0x400032A")]
			Disabled
		}

		[Token(Token = "0x20000A1")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000A2")]
		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		[Token(Token = "0x20000A3")]
		public enum UpdateMode
		{
			[Token(Token = "0x400032C")]
			Normal,
			[Token(Token = "0x400032D")]
			AnimatePhysics,
			[Token(Token = "0x400032E")]
			FixedUpdate
		}

		[Serializable]
		[Token(Token = "0x20000A4")]
		public enum State
		{
			[Token(Token = "0x4000330")]
			Alive,
			[Token(Token = "0x4000331")]
			Dead,
			[Token(Token = "0x4000332")]
			Frozen
		}

		[Serializable]
		[Token(Token = "0x20000A5")]
		public struct StateSettings
		{
			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("How much does it take to weigh out muscle weight to deadMuscleWeight?")]
			public float killDuration;

			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Tooltip("The muscle weight mlp while the puppet is Dead.")]
			public float deadMuscleWeight;

			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("The muscle damper add while the puppet is Dead.")]
			public float deadMuscleDamper;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Tooltip("The max square velocity of the ragdoll bones for freezing the puppet.")]
			public float maxFreezeSqrVelocity;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If true, PuppetMaster, all it's behaviours and the ragdoll will be destroyed when the puppet is frozen.")]
			public bool freezePermanently;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[Tooltip("If true, will enable angular limits when killing the puppet.")]
			public bool enableAngularLimitsOnKill;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[Tooltip("If true, will enable internal collisions when killing the puppet.")]
			public bool enableInternalCollisionsOnKill;

			[Token(Token = "0x17000053")]
			public static StateSettings Default
			{
				[Token(Token = "0x60003ED")]
				[Address(RVA = "0x7EBFAC", Offset = "0x7EBFAC", VA = "0x7EBFAC")]
				get
				{
					return default(StateSettings);
				}
			}

			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x7F6914", Offset = "0x7F6914", VA = "0x7F6914")]
			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool freezePermanently = false, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
			}
		}

		[Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class <DisabledToActive>d__125 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000054")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003F1")]
				[Address(RVA = "0x7F6B7C", Offset = "0x7F6B7C", VA = "0x7F6B7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000055")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003F3")]
				[Address(RVA = "0x7F6BC4", Offset = "0x7F6BC4", VA = "0x7F6BC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x7F1BE0", Offset = "0x7F1BE0", VA = "0x7F1BE0")]
			[DebuggerHidden]
			public <DisabledToActive>d__125(int <>1__state)
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x7F6938", Offset = "0x7F6938", VA = "0x7F6938", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x7F693C", Offset = "0x7F693C", VA = "0x7F693C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x7F6B84", Offset = "0x7F6B84", VA = "0x7F6B84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class <KinematicToActive>d__127 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000056")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003F7")]
				[Address(RVA = "0x7F6D68", Offset = "0x7F6D68", VA = "0x7F6D68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000057")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003F9")]
				[Address(RVA = "0x7F6DB0", Offset = "0x7F6DB0", VA = "0x7F6DB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x7F1C08", Offset = "0x7F1C08", VA = "0x7F1C08")]
			[DebuggerHidden]
			public <KinematicToActive>d__127(int <>1__state)
			{
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x7F6BCC", Offset = "0x7F6BCC", VA = "0x7F6BCC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x7F6BD0", Offset = "0x7F6BD0", VA = "0x7F6BD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x7F6D70", Offset = "0x7F6D70", VA = "0x7F6D70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class <ActiveToDisabled>d__128 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000058")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003FD")]
				[Address(RVA = "0x7F6EB0", Offset = "0x7F6EB0", VA = "0x7F6EB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000059")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003FF")]
				[Address(RVA = "0x7F6EF8", Offset = "0x7F6EF8", VA = "0x7F6EF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x7F1C30", Offset = "0x7F1C30", VA = "0x7F1C30")]
			[DebuggerHidden]
			public <ActiveToDisabled>d__128(int <>1__state)
			{
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x7F6DB8", Offset = "0x7F6DB8", VA = "0x7F6DB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x7F6DBC", Offset = "0x7F6DBC", VA = "0x7F6DBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x7F6EB8", Offset = "0x7F6EB8", VA = "0x7F6EB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A9")]
		[CompilerGenerated]
		private sealed class <ActiveToKinematic>d__129 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x1700005A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000403")]
				[Address(RVA = "0x7F7030", Offset = "0x7F7030", VA = "0x7F7030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000405")]
				[Address(RVA = "0x7F7078", Offset = "0x7F7078", VA = "0x7F7078", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000400")]
			[Address(RVA = "0x7F1C58", Offset = "0x7F1C58", VA = "0x7F1C58")]
			[DebuggerHidden]
			public <ActiveToKinematic>d__129(int <>1__state)
			{
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0x7F6F00", Offset = "0x7F6F00", VA = "0x7F6F00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000402")]
			[Address(RVA = "0x7F6F04", Offset = "0x7F6F04", VA = "0x7F6F04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000404")]
			[Address(RVA = "0x7F7038", Offset = "0x7F7038", VA = "0x7F7038", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class <AliveToDead>d__181 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool freeze;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <range>5__2;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <mW>5__3;

			[Token(Token = "0x1700005C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000409")]
				[Address(RVA = "0x7F7388", Offset = "0x7F7388", VA = "0x7F7388", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600040B")]
				[Address(RVA = "0x7F73D0", Offset = "0x7F73D0", VA = "0x7F73D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000406")]
			[Address(RVA = "0x7F5220", Offset = "0x7F5220", VA = "0x7F5220")]
			[DebuggerHidden]
			public <AliveToDead>d__181(int <>1__state)
			{
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0x7F7080", Offset = "0x7F7080", VA = "0x7F7080", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000408")]
			[Address(RVA = "0x7F7084", Offset = "0x7F7084", VA = "0x7F7084", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x7F7390", Offset = "0x7F7390", VA = "0x7F7390", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Humanoid Config allows you to easily share PuppetMaster properties, including individual muscle props between Humanoid puppets.")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform targetRoot;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Sets/sets the state of the puppet (Alive, Dead or Frozen). Frozen means the ragdoll will be deactivated once it comes to stop in dead state.")]
		[LargeHeader("Simulation")]
		public State state;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Settings for killing and freezing the puppet.")]
		[ContextMenuItem("Reset To Default", "ResetStateSettings")]
		public StateSettings stateSettings;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Active mode means all muscles are active and the character is physically simulated. Kinematic mode sets rigidbody.isKinematic to true for all the muscles and simply updates their position/rotation to match the target's. Disabled mode disables the ragdoll. Switching modes is done by simply changing this value, blending in/out will be handled automatically by the PuppetMaster.")]
		public Mode mode;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The time of blending when switching from Active to Kinematic/Disabled or from Kinematic/Disabled to Active. Switching from Kinematic to Disabled or vice versa will be done instantly.")]
		public float blendTime;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("If true, will fix the target character's Transforms to their default local positions and rotations in each update cycle to avoid drifting from additive reading-writing. Use this only if the target contains unanimated bones.")]
		public bool fixTargetTransforms;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Rigidbody.solverIterationCount for the muscles of this Puppet.")]
		public int solverIterationCount;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("If true, will draw the target's pose as green lines in the Scene view. This runs in the Editor only. If you wish to profile PuppetMaster, switch this off.")]
		public bool visualizeTargetPose;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[LargeHeader("Master Weights")]
		[Tooltip("The weight of mapping the animated character to the ragdoll pose.")]
		[Range(0f, 1f)]
		public float mappingWeight;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		[Tooltip("The weight of pinning the muscles to the position of their animated targets using simple AddForce.")]
		public float pinWeight;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		[Tooltip("The normalized strength of the muscles.")]
		public float muscleWeight;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The positionSpring of the ConfigurableJoints' Slerp Drive.")]
		[LargeHeader("Joint and Muscle Settings")]
		public float muscleSpring;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("The positionDamper of the ConfigurableJoints' Slerp Drive.")]
		public float muscleDamper;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(1f, 8f)]
		[Tooltip("Adjusts the slope of the pinWeight curve. Has effect only while interpolating pinWeight from 0 to 1 and back.")]
		public float pinPow;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 100f)]
		[Tooltip("Reduces pinning force the farther away the target is. Bigger value loosens the pinning, resulting in sloppier behaviour.")]
		public float pinDistanceFalloff;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("When the target has animated bones between the muscle bones, the joint anchors need to be updated in every update cycle because the muscles' targets move relative to each other in position space. This gives much more accurate results, but is computationally expensive so consider leaving it off.")]
		public bool updateJointAnchors;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[Tooltip("Enable this if any of the target's bones has translation animation.")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[Tooltip("Should the joints use angular limits? If the PuppetMaster fails to match the target's pose, it might be because the joint limits are too stiff and do not allow for such motion. Uncheck this to see if the limits are clamping the range of your puppet's animation. Since the joints are actuated, most PuppetMaster simulations will not actually require using joint limits at all.")]
		public bool angularLimits;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		[Tooltip("Should the muscles collide with each other? Consider leaving this off while the puppet is pinned for performance and better accuracy.  Since the joints are actuated, most PuppetMaster simulations will not actually require internal collisions at all.")]
		public bool internalCollisions;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Individual Muscle Settings")]
		[Tooltip("The Muscles managed by this PuppetMaster.")]
		public Muscle[] muscles;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UpdateDelegate OnRead;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnWrite;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPostLateUpdate;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UpdateDelegate OnHierarchyChanged;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public MuscleDelegate OnMuscleRemoved;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Animator _targetAnimator;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		public List<SolverManager> solvers;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool internalCollisionsEnabled;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool angularLimitsEnabled;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
		private bool fixedFrame;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int lastSolverIterationCount;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool isLegacy;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		private bool animatorDisabled;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
		private bool awakeFailed;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEB")]
		private bool interpolated;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool freezeFlag;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		private bool hasBeenDisabled;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEE")]
		private bool hierarchyIsFlat;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEF")]
		private bool teleport;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 teleportPosition;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Quaternion teleportRotation;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool teleportMoveToTarget;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Mode activeMode;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Mode lastMode;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float mappingBlend;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public UpdateDelegate OnFreeze;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public UpdateDelegate OnUnfreeze;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public UpdateDelegate OnDeath;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public UpdateDelegate OnResurrection;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private State activeState;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private State lastState;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool angularLimitsEnabledOnKill;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		private bool internalCollisionsEnabledOnKill;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		private bool animationDisabledbyStates;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14B")]
		[HideInInspector]
		public bool storeTargetMappedState;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Transform[] targetChildren;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3[] targetMappedPositions;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Quaternion[] targetMappedRotations;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Vector3[] targetSampledPositions;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Quaternion[] targetSampledRotations;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private bool targetMappedStateStored;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x179")]
		private bool targetMappedStateSampled;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17A")]
		private bool sampleTargetMappedState;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17B")]
		private bool hasProp;

		[Token(Token = "0x17000045")]
		public Animator targetAnimator
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x7EBFD0", Offset = "0x7EBFD0", VA = "0x7EBFD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x7EC0FC", Offset = "0x7EC0FC", VA = "0x7EC0FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public Animation targetAnimation
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x7EC104", Offset = "0x7EC104", VA = "0x7EC104")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x7EC10C", Offset = "0x7EC10C", VA = "0x7EC10C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public BehaviourBase[] behaviours
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x7EC114", Offset = "0x7EC114", VA = "0x7EC114")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x7EC11C", Offset = "0x7EC11C", VA = "0x7EC11C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public bool isActive
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x7EC124", Offset = "0x7EC124", VA = "0x7EC124")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		public bool initiated
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x7EC19C", Offset = "0x7EC19C", VA = "0x7EC19C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x7EC1A4", Offset = "0x7EC1A4", VA = "0x7EC1A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public UpdateMode updateMode
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x7EC1B0", Offset = "0x7EC1B0", VA = "0x7EC1B0")]
			get
			{
				return default(UpdateMode);
			}
		}

		[Token(Token = "0x1700004B")]
		public bool controlsAnimator
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x7EC2C0", Offset = "0x7EC2C0", VA = "0x7EC2C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		public bool isBlending
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x7EC178", Offset = "0x7EC178", VA = "0x7EC178")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		private AnimatorUpdateMode targetUpdateMode
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x7EC1E8", Offset = "0x7EC1E8", VA = "0x7EC1E8")]
			get
			{
				return default(AnimatorUpdateMode);
			}
		}

		[Token(Token = "0x1700004E")]
		public bool isSwitchingMode
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x7F1690", Offset = "0x7F1690", VA = "0x7F1690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x7F1698", Offset = "0x7F1698", VA = "0x7F1698")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public bool isSwitchingState
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x7EC314", Offset = "0x7EC314", VA = "0x7EC314")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		public bool isKilling
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x7F4C70", Offset = "0x7F4C70", VA = "0x7F4C70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x7F4C78", Offset = "0x7F4C78", VA = "0x7F4C78")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public bool isAlive
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x7F03A0", Offset = "0x7F03A0", VA = "0x7F03A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000052")]
		public bool isFrozen
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x7EFB1C", Offset = "0x7EFB1C", VA = "0x7EFB1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x7EBDF8", Offset = "0x7EBDF8", VA = "0x7EBDF8")]
		[ContextMenu("User Manual (Setup)")]
		private void OpenUserManualSetup()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x7EBE3C", Offset = "0x7EBE3C", VA = "0x7EBE3C")]
		[ContextMenu("User Manual (Component)")]
		private void OpenUserManualComponent()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x7EBE80", Offset = "0x7EBE80", VA = "0x7EBE80")]
		[ContextMenu("User Manual (Performance)")]
		private void OpenUserManualPerformance()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x7EBEC4", Offset = "0x7EBEC4", VA = "0x7EBEC4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x7EBF08", Offset = "0x7EBF08", VA = "0x7EBF08")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x7EBF4C", Offset = "0x7EBF4C", VA = "0x7EBF4C")]
		[ContextMenu("TUTORIAL VIDEO (COMPONENT)")]
		private void OpenComponentTutorial()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x7EBF90", Offset = "0x7EBF90", VA = "0x7EBF90")]
		private void ResetStateSettings()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x7EC328", Offset = "0x7EC328", VA = "0x7EC328")]
		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x7EC350", Offset = "0x7EC350", VA = "0x7EC350")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x7EC3E8", Offset = "0x7EC3E8", VA = "0x7EC3E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x7ECAB4", Offset = "0x7ECAB4", VA = "0x7ECAB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x7ED3DC", Offset = "0x7ED3DC", VA = "0x7ED3DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x7ED488", Offset = "0x7ED488", VA = "0x7ED488")]
		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x7ECAEC", Offset = "0x7ECAEC", VA = "0x7ECAEC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x7EEA54", Offset = "0x7EEA54", VA = "0x7EEA54")]
		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x7EEB30", Offset = "0x7EEB30", VA = "0x7EEB30")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x7EEC7C", Offset = "0x7EEC7C", VA = "0x7EEC7C")]
		private bool IsInterpolated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x7EECFC", Offset = "0x7EECFC", VA = "0x7EECFC", Slot = "4")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x7EFC98", Offset = "0x7EFC98", VA = "0x7EFC98", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x7EFD04", Offset = "0x7EFD04", VA = "0x7EFD04", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x7EFD50", Offset = "0x7EFD50", VA = "0x7EFD50", Slot = "7")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x7EFF90", Offset = "0x7EFF90", VA = "0x7EFF90")]
		private void MoveToTarget()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x7EF23C", Offset = "0x7EF23C", VA = "0x7EF23C")]
		private void Read()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x7EF100", Offset = "0x7EF100", VA = "0x7EF100")]
		private void FixTargetTransforms()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x7F03B0", Offset = "0x7F03B0", VA = "0x7F03B0")]
		private void VisualizeTargetPose()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x7F0630", Offset = "0x7F0630", VA = "0x7F0630")]
		private void VisualizeHierarchy(Transform t, Color color)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x7EFB2C", Offset = "0x7EFB2C", VA = "0x7EFB2C")]
		private void SetInternalCollisions(bool collide)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x7EFC10", Offset = "0x7EFC10", VA = "0x7EFC10")]
		private void SetAngularLimits(bool limited)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x7EB51C", Offset = "0x7EB51C", VA = "0x7EB51C")]
		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, [Optional] Muscle.Props muscleProps, bool forceTreeHierarchy = false, bool forceLayers = true)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x7EA28C", Offset = "0x7EA28C", VA = "0x7EA28C")]
		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x7F0F70", Offset = "0x7F0F70", VA = "0x7F0F70")]
		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x7F100C", Offset = "0x7F100C", VA = "0x7F100C")]
		public void SetMuscles(Muscle[] newMuscles)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x7F10A8", Offset = "0x7F10A8", VA = "0x7F10A8")]
		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x7F1144", Offset = "0x7F1144", VA = "0x7F1144")]
		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x7F11E0", Offset = "0x7F11E0", VA = "0x7F11E0")]
		[ContextMenu("Flatten Muscle Hierarchy")]
		public void FlattenHierarchy()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x7F12D8", Offset = "0x7F12D8", VA = "0x7F12D8")]
		[ContextMenu("Tree Muscle Hierarchy")]
		public void TreeHierarchy()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x7F1424", Offset = "0x7F1424", VA = "0x7F1424")]
		[ContextMenu("Fix Muscle Positions")]
		public void FixMusclePositions()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x7F1538", Offset = "0x7F1538", VA = "0x7F1538")]
		private void AddIndexesRecursive(int index, ref int[] indexes)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x7EE5B8", Offset = "0x7EE5B8", VA = "0x7EE5B8")]
		private bool HierarchyIsFlat()
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x7F0E34", Offset = "0x7F0E34", VA = "0x7F0E34")]
		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x7F0EC0", Offset = "0x7F0EC0", VA = "0x7F0EC0")]
		private void KillJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x7F16A4", Offset = "0x7F16A4", VA = "0x7F16A4")]
		public void DisableImmediately()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x7F1734", Offset = "0x7F1734", VA = "0x7F1734", Slot = "8")]
		protected virtual void SwitchModes()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x7F1878", Offset = "0x7F1878", VA = "0x7F1878")]
		private void DisabledToKinematic()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x7F19B8", Offset = "0x7F19B8", VA = "0x7F19B8")]
		[IteratorStateMachine(typeof(<DisabledToActive>d__125))]
		private IEnumerator DisabledToActive()
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x7F1A20", Offset = "0x7F1A20", VA = "0x7F1A20")]
		private void KinematicToDisabled()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x7F1AA8", Offset = "0x7F1AA8", VA = "0x7F1AA8")]
		[IteratorStateMachine(typeof(<KinematicToActive>d__127))]
		private IEnumerator KinematicToActive()
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x7F1B10", Offset = "0x7F1B10", VA = "0x7F1B10")]
		[IteratorStateMachine(typeof(<ActiveToDisabled>d__128))]
		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x7F1B78", Offset = "0x7F1B78", VA = "0x7F1B78")]
		[IteratorStateMachine(typeof(<ActiveToKinematic>d__129))]
		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x7F1C80", Offset = "0x7F1C80", VA = "0x7F1C80")]
		private void UpdateInternalCollisions()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x7F1D48", Offset = "0x7F1D48", VA = "0x7F1D48")]
		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x7F1DDC", Offset = "0x7F1DDC", VA = "0x7F1DDC")]
		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x7F217C", Offset = "0x7F217C", VA = "0x7F217C")]
		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x7F2410", Offset = "0x7F2410", VA = "0x7F2410")]
		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x7F2520", Offset = "0x7F2520", VA = "0x7F2520")]
		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x7F2600", Offset = "0x7F2600", VA = "0x7F2600")]
		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x7F2038", Offset = "0x7F2038", VA = "0x7F2038")]
		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x7F2684", Offset = "0x7F2684", VA = "0x7F2684")]
		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x7F08FC", Offset = "0x7F08FC", VA = "0x7F08FC")]
		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x7F28A4", Offset = "0x7F28A4", VA = "0x7F28A4")]
		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x7F082C", Offset = "0x7F082C", VA = "0x7F082C")]
		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x7F2200", Offset = "0x7F2200", VA = "0x7F2200")]
		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return default(int);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x7F1E60", Offset = "0x7F1E60", VA = "0x7F1E60")]
		public int GetMuscleIndex(Transform target)
		{
			return default(int);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x7F26CC", Offset = "0x7F26CC", VA = "0x7F26CC")]
		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return default(int);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x7F0C5C", Offset = "0x7F0C5C", VA = "0x7F0C5C")]
		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x7F28EC", Offset = "0x7F28EC", VA = "0x7F28EC")]
		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x7F354C", Offset = "0x7F354C", VA = "0x7F354C")]
		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x7F29DC", Offset = "0x7F29DC", VA = "0x7F29DC")]
		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x7F36BC", Offset = "0x7F36BC", VA = "0x7F36BC")]
		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x7F3E8C", Offset = "0x7F3E8C", VA = "0x7F3E8C")]
		private void SetUpMuscles(Transform setUpTo)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x7F4848", Offset = "0x7F4848", VA = "0x7F4848")]
		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default(Muscle.Group);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x7F3AB8", Offset = "0x7F3AB8", VA = "0x7F3AB8")]
		private void RemoveUnnecessaryBones()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x7F457C", Offset = "0x7F457C", VA = "0x7F457C")]
		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x7F4C84", Offset = "0x7F4C84", VA = "0x7F4C84")]
		public void Kill()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x7F4C90", Offset = "0x7F4C90", VA = "0x7F4C90")]
		public void Kill(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x7F4CAC", Offset = "0x7F4CAC", VA = "0x7F4CAC")]
		public void Freeze()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x7F4CB8", Offset = "0x7F4CB8", VA = "0x7F4CB8")]
		public void Freeze(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x7F4CD4", Offset = "0x7F4CD4", VA = "0x7F4CD4")]
		public void Resurrect()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x7F4CDC", Offset = "0x7F4CDC", VA = "0x7F4CDC", Slot = "9")]
		protected virtual void SwitchStates()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x7F4DD0", Offset = "0x7F4DD0", VA = "0x7F4DD0")]
		[IteratorStateMachine(typeof(<AliveToDead>d__181))]
		private IEnumerator AliveToDead(bool freeze)
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x7F012C", Offset = "0x7F012C", VA = "0x7F012C")]
		private void OnFreezeFlag()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x7F4E4C", Offset = "0x7F4E4C", VA = "0x7F4E4C")]
		private void DeadToAlive()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x7EC7F8", Offset = "0x7EC7F8", VA = "0x7EC7F8")]
		private void SetAnimationEnabled(bool to)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x7F4F40", Offset = "0x7F4F40", VA = "0x7F4F40")]
		private void DeadToFrozen()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x7F4F4C", Offset = "0x7F4F4C", VA = "0x7F4F4C")]
		private void FrozenToAlive()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x7F5150", Offset = "0x7F5150", VA = "0x7F5150")]
		private void FrozenToDead()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x7EC8E0", Offset = "0x7EC8E0", VA = "0x7EC8E0")]
		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x7F5248", Offset = "0x7F5248", VA = "0x7F5248")]
		private bool CanFreeze()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x7F52E0", Offset = "0x7F52E0", VA = "0x7F52E0")]
		public void SampleTargetMappedState()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x7F53C0", Offset = "0x7F53C0", VA = "0x7F53C0")]
		public void FixTargetToSampledState(float weight)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x7EE6B0", Offset = "0x7EE6B0", VA = "0x7EE6B0")]
		public void StoreTargetMappedState()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x7EE3C4", Offset = "0x7EE3C4", VA = "0x7EE3C4")]
		private void UpdateHierarchies()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x7F5D3C", Offset = "0x7F5D3C", VA = "0x7F5D3C")]
		private bool HasProp()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x7F5BFC", Offset = "0x7F5BFC", VA = "0x7F5BFC")]
		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x7F580C", Offset = "0x7F580C", VA = "0x7F580C")]
		private void AssignParentAndChildIndexes()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x7F5D9C", Offset = "0x7F5D9C", VA = "0x7F5D9C")]
		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x7F5EFC", Offset = "0x7F5EFC", VA = "0x7F5EFC")]
		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x7F5B08", Offset = "0x7F5B08", VA = "0x7F5B08")]
		private void AssignKinshipDegrees()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x7F61B4", Offset = "0x7F61B4", VA = "0x7F61B4")]
		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x7F6300", Offset = "0x7F6300", VA = "0x7F6300")]
		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x7F60F8", Offset = "0x7F60F8", VA = "0x7F60F8")]
		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x7ED830", Offset = "0x7ED830", VA = "0x7ED830")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x7F0944", Offset = "0x7F0944", VA = "0x7F0944")]
		private bool CheckMassVariation(float threshold, bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x7F07A0", Offset = "0x7F07A0", VA = "0x7F07A0")]
		private bool CheckIfInitiated()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x7F653C", Offset = "0x7F653C", VA = "0x7F653C")]
		public PuppetMaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public enum MuscleRemoveMode
	{
		[Token(Token = "0x400034D")]
		Sever,
		[Token(Token = "0x400034E")]
		Explode,
		[Token(Token = "0x400034F")]
		Numb
	}
	[Token(Token = "0x20000AC")]
	[CreateAssetMenu(fileName = "PuppetMaster Humanoid Config", menuName = "PuppetMaster/Humanoid Config", order = 1)]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20000AD")]
		public class HumanoidMuscle
		{
			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Muscle.Props props;

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x7F7598", Offset = "0x7F7598", VA = "0x7F7598")]
			public HumanoidMuscle()
			{
			}
		}

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("Simulation")]
		public PuppetMaster.State state;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PuppetMaster.Mode mode;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blendTime;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool fixTargetTransforms;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int solverIterationCount;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool visualizeTargetPose;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		[LargeHeader("Master Weights")]
		public float mappingWeight;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float pinWeight;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float muscleWeight;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[LargeHeader("Joint and Muscle Settings")]
		public float muscleSpring;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float muscleDamper;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(1f, 8f)]
		public float pinPow;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 100f)]
		public float pinDistanceFalloff;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool updateJointAnchors;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool angularLimits;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool internalCollisions;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[LargeHeader("Individual Muscle Settings")]
		public HumanoidMuscle[] muscles;

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x7EE128", Offset = "0x7EE128", VA = "0x7EE128")]
		public void ApplyTo(PuppetMaster p)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x7F73D8", Offset = "0x7F73D8", VA = "0x7F73D8")]
		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x7F74EC", Offset = "0x7F74EC", VA = "0x7F74EC")]
		public PuppetMasterHumanoidConfig()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/PuppetMaster Settings")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		[Token(Token = "0x20000AF")]
		public class PuppetUpdateLimit
		{
			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(1f, 100f)]
			public int puppetsPerFrame;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int index;

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x7F7B14", Offset = "0x7F7B14", VA = "0x7F7B14")]
			public PuppetUpdateLimit()
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x7F7974", Offset = "0x7F7974", VA = "0x7F7974")]
			public void Step(int puppetCount)
			{
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x7F75D8", Offset = "0x7F75D8", VA = "0x7F75D8")]
			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Optimizations")]
		public PuppetUpdateLimit kinematicCollidersUpdateLimit;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PuppetUpdateLimit freeUpdateLimit;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PuppetUpdateLimit fixedUpdateLimit;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool collisionStayMessages;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool collisionExitMessages;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float activePuppetCollisionThresholdMlp;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PuppetMaster> _puppets;

		[Token(Token = "0x1700005E")]
		public int currentlyActivePuppets
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x7F75A0", Offset = "0x7F75A0", VA = "0x7F75A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x7F75A8", Offset = "0x7F75A8", VA = "0x7F75A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public int currentlyKinematicPuppets
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x7F75B0", Offset = "0x7F75B0", VA = "0x7F75B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x7F75B8", Offset = "0x7F75B8", VA = "0x7F75B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public int currentlyDisabledPuppets
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x7F75C0", Offset = "0x7F75C0", VA = "0x7F75C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x7F75C8", Offset = "0x7F75C8", VA = "0x7F75C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public List<PuppetMaster> puppets
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x7F75D0", Offset = "0x7F75D0", VA = "0x7F75D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x7EE980", Offset = "0x7EE980", VA = "0x7EE980")]
		public void Register(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x7EEC24", Offset = "0x7EEC24", VA = "0x7EEC24")]
		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x7F037C", Offset = "0x7F037C", VA = "0x7F037C")]
		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x7F76F8", Offset = "0x7F76F8", VA = "0x7F76F8")]
		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x7F771C", Offset = "0x7F771C", VA = "0x7F771C")]
		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x7F7740", Offset = "0x7F7740", VA = "0x7F7740")]
		private void Update()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x7F7990", Offset = "0x7F7990", VA = "0x7F7990")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x7F79F8", Offset = "0x7F79F8", VA = "0x7F79F8")]
		public PuppetMasterSettings()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public static class PuppetMasterTools
	{
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x7F7B34", Offset = "0x7F7B34", VA = "0x7F7B34")]
		public static void PositionRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x7F8108", Offset = "0x7F8108", VA = "0x7F8108")]
		public static void RealignRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x7F89E8", Offset = "0x7F89E8", VA = "0x7F89E8")]
		private static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x7F8AC8", Offset = "0x7F8AC8", VA = "0x7F8AC8")]
		private static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class Weight
	{
		[Serializable]
		[Token(Token = "0x20000B2")]
		public enum Mode
		{
			[Token(Token = "0x4000377")]
			Float,
			[Token(Token = "0x4000378")]
			Curve
		}

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mode mode;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float floatValue;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve curve;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x7F8C00", Offset = "0x7F8C00", VA = "0x7F8C00")]
		public Weight(float floatValue)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x7F8C64", Offset = "0x7F8C64", VA = "0x7F8C64")]
		public Weight(float floatValue, string tooltip)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x7F8CD8", Offset = "0x7F8CD8", VA = "0x7F8CD8")]
		public float GetValue(float param)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000B3")]
	public class InitialVelocity : MonoBehaviour
	{
		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 initialVelocity;

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x7F8D0C", Offset = "0x7F8D0C", VA = "0x7F8D0C")]
		private void Start()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x7F8D6C", Offset = "0x7F8D6C", VA = "0x7F8D6C")]
		public InitialVelocity()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/Ragdoll Manager/Biped Ragdoll Creator")]
	[HelpURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		public struct Options
		{
			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float weight;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Header("Optional Bones")]
			public bool spine;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public bool chest;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public bool hands;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public bool feet;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Header("Joints")]
			public JointType joints;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float jointRange;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Header("Colliders")]
			public float colliderLengthOverlap;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ColliderType torsoColliders;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ColliderType headCollider;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColliderType armColliders;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ColliderType handColliders;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public ColliderType legColliders;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ColliderType footColliders;

			[Token(Token = "0x17000062")]
			public static Options Default
			{
				[Token(Token = "0x600043C")]
				[Address(RVA = "0x7FD270", Offset = "0x7FD270", VA = "0x7FD270")]
				get
				{
					return default(Options);
				}
			}
		}

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool canBuild;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedRagdollReferences references;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Options options;

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x7F8D74", Offset = "0x7F8D74", VA = "0x7F8D74")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x7F8DB8", Offset = "0x7F8DB8", VA = "0x7F8DB8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x7F8DFC", Offset = "0x7F8DFC", VA = "0x7F8DFC")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x7F8E40", Offset = "0x7F8E40", VA = "0x7F8E40")]
		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(Options);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x7F90C4", Offset = "0x7F90C4", VA = "0x7F90C4")]
		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x7F920C", Offset = "0x7F920C", VA = "0x7F920C")]
		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x7FAD1C", Offset = "0x7FAD1C", VA = "0x7FAD1C")]
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x7FB118", Offset = "0x7FB118", VA = "0x7FB118")]
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x7FB814", Offset = "0x7FB814", VA = "0x7FB814")]
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x7FA030", Offset = "0x7FA030", VA = "0x7FA030")]
		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x7FA47C", Offset = "0x7FA47C", VA = "0x7FA47C")]
		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x7FB914", Offset = "0x7FB914", VA = "0x7FB914")]
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x7FC0C8", Offset = "0x7FC0C8", VA = "0x7FC0C8")]
		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x7FC130", Offset = "0x7FC130", VA = "0x7FC130")]
		public static bool IsClear(BipedRagdollReferences r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x7FAC94", Offset = "0x7FAC94", VA = "0x7FAC94")]
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x7F904C", Offset = "0x7F904C", VA = "0x7F904C")]
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x7FC21C", Offset = "0x7FC21C", VA = "0x7FC21C")]
		public BipedRagdollCreator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public struct BipedRagdollReferences
	{
		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform root;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform hips;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform spine;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform chest;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform head;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperLeg;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftLowerLeg;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform leftFoot;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightUpperLeg;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightLowerLeg;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightFoot;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftLowerArm;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform leftHand;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightUpperArm;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightLowerArm;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform rightHand;

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x7FD2A8", Offset = "0x7FD2A8", VA = "0x7FD2A8")]
		public bool IsValid(ref string msg)
		{
			return default(bool);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x7FDA20", Offset = "0x7FDA20", VA = "0x7FDA20")]
		private bool IsChildRecursive(Transform t, Transform parent)
		{
			return default(bool);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x7FDB08", Offset = "0x7FDB08", VA = "0x7FDB08")]
		public bool IsEmpty(bool considerRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x7FDE04", Offset = "0x7FDE04", VA = "0x7FDE04")]
		public bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x7FE10C", Offset = "0x7FE10C", VA = "0x7FE10C")]
		public Transform[] GetRagdollTransforms()
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x7FE434", Offset = "0x7FE434", VA = "0x7FE434")]
		public static BipedRagdollReferences FromAvatar(Animator animator)
		{
			return default(BipedRagdollReferences);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x7FE648", Offset = "0x7FE648", VA = "0x7FE648")]
		public static BipedRagdollReferences FromBipedReferences(BipedReferences biped)
		{
			return default(BipedRagdollReferences);
		}
	}
	[Token(Token = "0x20000B7")]
	public static class JointConverter
	{
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x7FE6E0", Offset = "0x7FE6E0", VA = "0x7FE6E0")]
		public static void ToConfigurable(GameObject root)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x7FEBE8", Offset = "0x7FEBE8", VA = "0x7FEBE8")]
		public static void HingeToConfigurable(HingeJoint src)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x7FEED8", Offset = "0x7FEED8", VA = "0x7FEED8")]
		public static void FixedToConfigurable(FixedJoint src)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x7FF02C", Offset = "0x7FF02C", VA = "0x7FF02C")]
		public static void SpringToConfigurable(SpringJoint src)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x7FE9B0", Offset = "0x7FE9B0", VA = "0x7FE9B0")]
		public static void CharacterToConfigurable(CharacterJoint src)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x7FF1D0", Offset = "0x7FF1D0", VA = "0x7FF1D0")]
		private static void ConvertJoint(ref ConfigurableJoint conf, Joint src)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x7FF2FC", Offset = "0x7FF2FC", VA = "0x7FF2FC")]
		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x7FF3A8", Offset = "0x7FF3A8", VA = "0x7FF3A8")]
		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x7FF354", Offset = "0x7FF354", VA = "0x7FF354")]
		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimitSpring);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x7FF400", Offset = "0x7FF400", VA = "0x7FF400")]
		private static SoftJointLimit CopyLimit(SoftJointLimit src)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x7FF45C", Offset = "0x7FF45C", VA = "0x7FF45C")]
		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src)
		{
			return default(SoftJointLimitSpring);
		}
	}
	[Token(Token = "0x20000B8")]
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B9")]
		public enum ColliderType
		{
			[Token(Token = "0x400039D")]
			Box,
			[Token(Token = "0x400039E")]
			Capsule
		}

		[Serializable]
		[Token(Token = "0x20000BA")]
		public enum JointType
		{
			[Token(Token = "0x40003A0")]
			Configurable,
			[Token(Token = "0x40003A1")]
			Character
		}

		[Serializable]
		[Token(Token = "0x20000BB")]
		public enum Direction
		{
			[Token(Token = "0x40003A3")]
			X,
			[Token(Token = "0x40003A4")]
			Y,
			[Token(Token = "0x40003A5")]
			Z
		}

		[Token(Token = "0x20000BC")]
		public struct CreateJointParams
		{
			[Token(Token = "0x20000BD")]
			public struct Limits
			{
				[Token(Token = "0x40003AC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float minSwing;

				[Token(Token = "0x40003AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float maxSwing;

				[Token(Token = "0x40003AE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float swing2;

				[Token(Token = "0x40003AF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public float twist;

				[Token(Token = "0x600045F")]
				[Address(RVA = "0x800CCC", Offset = "0x800CCC", VA = "0x800CCC")]
				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
				}
			}

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody rigidbody;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody connectedBody;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform child;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 worldSwingAxis;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Limits limits;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public JointType type;

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x800CAC", Offset = "0x800CAC", VA = "0x800CAC")]
			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
			}
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x7FF4A8", Offset = "0x7FF4A8", VA = "0x7FF4A8")]
		public static void ClearAll(Transform root)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x7FF688", Offset = "0x7FF688", VA = "0x7FF688")]
		protected static void ClearTransform(Transform transform)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x7FF898", Offset = "0x7FF898", VA = "0x7FF898")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x7FFD44", Offset = "0x7FFD44", VA = "0x7FFD44")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x7FFBE0", Offset = "0x7FFBE0", VA = "0x7FFBE0")]
		protected static float GetScaleF(Transform t)
		{
			return default(float);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x8000CC", Offset = "0x8000CC", VA = "0x8000CC")]
		protected static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x8000DC", Offset = "0x8000DC", VA = "0x8000DC")]
		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x8000F8", Offset = "0x8000F8", VA = "0x8000F8")]
		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x8001D8", Offset = "0x8001D8", VA = "0x8001D8")]
		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x7FFC0C", Offset = "0x7FFC0C", VA = "0x7FFC0C")]
		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x8002B8", Offset = "0x8002B8", VA = "0x8002B8")]
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x800530", Offset = "0x800530", VA = "0x800530")]
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x8006D0", Offset = "0x8006D0", VA = "0x8006D0")]
		protected static void CreateJoint(CreateJointParams p)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x800C74", Offset = "0x800C74", VA = "0x800C74")]
		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x800CA4", Offset = "0x800CA4", VA = "0x800CA4")]
		protected RagdollCreator()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[HelpURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/Ragdoll Manager/Ragdoll Editor")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BF")]
		public enum Mode
		{
			[Token(Token = "0x40003B5")]
			Colliders,
			[Token(Token = "0x40003B6")]
			Joints
		}

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Rigidbody selectedRigidbody;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Collider selectedCollider;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool symmetry;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public Mode mode;

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x800CD8", Offset = "0x800CD8", VA = "0x800CD8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x800D1C", Offset = "0x800D1C", VA = "0x800D1C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x800D60", Offset = "0x800D60", VA = "0x800D60")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x800DA4", Offset = "0x800DA4", VA = "0x800DA4")]
		public RagdollEditor()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000C0")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x800DB4", Offset = "0x800DB4", VA = "0x800DB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x800E34", Offset = "0x800E34", VA = "0x800E34")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction of the animated weapon swing in character space. Tweak this value to adjust the aiming.")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x800E3C", Offset = "0x800E3C", VA = "0x800E3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x800EA8", Offset = "0x800EA8", VA = "0x800EA8")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x800F08", Offset = "0x800F08", VA = "0x800F08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x800F40", Offset = "0x800F40", VA = "0x800F40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x801088", Offset = "0x801088", VA = "0x801088")]
		private void Pose()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x8011F8", Offset = "0x8011F8", VA = "0x8011F8")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x8013DC", Offset = "0x8013DC", VA = "0x8013DC")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x80146C", Offset = "0x80146C", VA = "0x80146C")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x801480", Offset = "0x801480", VA = "0x801480")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x8015EC", Offset = "0x8015EC", VA = "0x8015EC")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x8017E8", Offset = "0x8017E8", VA = "0x8017E8")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x801818", Offset = "0x801818", VA = "0x801818")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x801C44", Offset = "0x801C44", VA = "0x801C44")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x801C64", Offset = "0x801C64", VA = "0x801C64")]
		private void Update()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x802580", Offset = "0x802580", VA = "0x802580")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x8022FC", Offset = "0x8022FC", VA = "0x8022FC")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x802690", Offset = "0x802690", VA = "0x802690")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x17000063")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x8026BC", Offset = "0x8026BC", VA = "0x8026BC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x80273C", Offset = "0x80273C", VA = "0x80273C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x802A80", Offset = "0x802A80", VA = "0x802A80")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000C8")]
		[CompilerGenerated]
		private sealed class <Step>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x17000066")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000485")]
				[Address(RVA = "0x803470", Offset = "0x803470", VA = "0x803470", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x8034B8", Offset = "0x8034B8", VA = "0x8034B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x803194", Offset = "0x803194", VA = "0x803194")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x8031EC", Offset = "0x8031EC", VA = "0x8031EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x8031F0", Offset = "0x8031F0", VA = "0x8031F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x803478", Offset = "0x803478", VA = "0x803478", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x17000064")]
		public bool isStepping
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x802A94", Offset = "0x802A94", VA = "0x802A94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		public Vector3 position
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x802660", Offset = "0x802660", VA = "0x802660")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x802AA8", Offset = "0x802AA8", VA = "0x802AA8")]
			set
			{
			}
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x802AF4", Offset = "0x802AF4", VA = "0x802AF4")]
		private void Start()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x802C34", Offset = "0x802C34", VA = "0x802C34")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x802ED4", Offset = "0x802ED4", VA = "0x802ED4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x8030F0", Offset = "0x8030F0", VA = "0x8030F0")]
		[IteratorStateMachine(typeof(<Step>d__24))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x8031BC", Offset = "0x8031BC", VA = "0x8031BC")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x8034C0", Offset = "0x8034C0", VA = "0x8034C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x80358C", Offset = "0x80358C", VA = "0x80358C")]
		private void Update()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x803800", Offset = "0x803800", VA = "0x803800")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public struct Warp
		{
			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000CC")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000415")]
			PositionOffset,
			[Token(Token = "0x4000416")]
			Position
		}

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x803808", Offset = "0x803808", VA = "0x803808", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x803828", Offset = "0x803828", VA = "0x803828")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x803A40", Offset = "0x803A40", VA = "0x803A40", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x803CF8", Offset = "0x803CF8", VA = "0x803CF8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x803D8C", Offset = "0x803D8C", VA = "0x803D8C")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[RequireComponent(typeof(Animator))]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x803D94", Offset = "0x803D94", VA = "0x803D94", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x803DE4", Offset = "0x803DE4", VA = "0x803DE4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x803FEC", Offset = "0x803FEC", VA = "0x803FEC", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x804214", Offset = "0x804214", VA = "0x804214")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	[RequireComponent(typeof(AimIK))]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x804228", Offset = "0x804228", VA = "0x804228", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x8043BC", Offset = "0x8043BC", VA = "0x8043BC", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x804424", Offset = "0x804424", VA = "0x804424")]
		private void Read()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x80455C", Offset = "0x80455C", VA = "0x80455C")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x8045B8", Offset = "0x8045B8", VA = "0x8045B8")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x804C00", Offset = "0x804C00", VA = "0x804C00")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x804A14", Offset = "0x804A14", VA = "0x804A14")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x804EA4", Offset = "0x804EA4", VA = "0x804EA4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x804FB0", Offset = "0x804FB0", VA = "0x804FB0")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x804FCC", Offset = "0x804FCC", VA = "0x804FCC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x805028", Offset = "0x805028", VA = "0x805028", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x805364", Offset = "0x805364", VA = "0x805364")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x805454", Offset = "0x805454", VA = "0x805454")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[RequireComponent(typeof(AnimatorController3rdPerson))]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000068")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x8056B4", Offset = "0x8056B4", VA = "0x8056B4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000069")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x805734", Offset = "0x805734", VA = "0x805734")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x80545C", Offset = "0x80545C", VA = "0x80545C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x8054C4", Offset = "0x8054C4", VA = "0x8054C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x8057B4", Offset = "0x8057B4", VA = "0x8057B4")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x8057BC", Offset = "0x8057BC", VA = "0x8057BC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x805C18", Offset = "0x805C18", VA = "0x805C18")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x805C20", Offset = "0x805C20", VA = "0x805C20")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x805CC4", Offset = "0x805CC4", VA = "0x805CC4")]
		private void Update()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x806120", Offset = "0x806120", VA = "0x806120")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x8061C0", Offset = "0x8061C0", VA = "0x8061C0")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D4")]
		public class Limb
		{
			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x806354", Offset = "0x806354", VA = "0x806354")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x806478", Offset = "0x806478", VA = "0x806478")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x806230", Offset = "0x806230", VA = "0x806230")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x8063CC", Offset = "0x8063CC", VA = "0x8063CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x806464", Offset = "0x806464", VA = "0x806464")]
		private void Update()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x806468", Offset = "0x806468", VA = "0x806468")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x806488", Offset = "0x806488", VA = "0x806488")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x8064F0", Offset = "0x8064F0", VA = "0x8064F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x8065B8", Offset = "0x8065B8", VA = "0x8065B8")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x8065C0", Offset = "0x8065C0", VA = "0x8065C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x806610", Offset = "0x806610", VA = "0x806610")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x8067A8", Offset = "0x8067A8", VA = "0x8067A8")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x8067B0", Offset = "0x8067B0", VA = "0x8067B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x806880", Offset = "0x806880", VA = "0x806880")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x806900", Offset = "0x806900", VA = "0x806900")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x806D48", Offset = "0x806D48", VA = "0x806D48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x806E54", Offset = "0x806E54", VA = "0x806E54")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Range(0f, 1f)]
		private float cameraRecoilWeight;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool updateFrame;

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x806E5C", Offset = "0x806E5C", VA = "0x806E5C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x806FBC", Offset = "0x806FBC", VA = "0x806FBC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x806FC8", Offset = "0x806FC8", VA = "0x806FC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x807288", Offset = "0x807288", VA = "0x807288")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x8073D8", Offset = "0x8073D8", VA = "0x8073D8")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x80708C", Offset = "0x80708C", VA = "0x80708C")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x80805C", Offset = "0x80805C", VA = "0x80805C")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(FPSAiming))]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x80807C", Offset = "0x80807C", VA = "0x80807C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x8080F8", Offset = "0x8080F8", VA = "0x8080F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x8081F4", Offset = "0x8081F4", VA = "0x8081F4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x8082A0", Offset = "0x8082A0", VA = "0x8082A0")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x8082B0", Offset = "0x8082B0", VA = "0x8082B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x8083F4", Offset = "0x8083F4", VA = "0x8083F4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x808558", Offset = "0x808558", VA = "0x808558")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x808568", Offset = "0x808568", VA = "0x808568")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x808734", Offset = "0x808734", VA = "0x808734")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x808B44", Offset = "0x808B44", VA = "0x808B44")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x808B54", Offset = "0x808B54", VA = "0x808B54")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x808C3C", Offset = "0x808C3C", VA = "0x808C3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x808D28", Offset = "0x808D28", VA = "0x808D28")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x808D30", Offset = "0x808D30", VA = "0x808D30")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x809230", Offset = "0x809230", VA = "0x809230")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	[RequireComponent(typeof(InteractionSystem))]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("The object to interact to")]
		private InteractionObject interactionObject;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The effectors to interact with")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x809238", Offset = "0x809238", VA = "0x809238")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x809288", Offset = "0x809288", VA = "0x809288")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x809534", Offset = "0x809534", VA = "0x809534")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Partner
		{
			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x1700006A")]
			private Transform neck
			{
				[Token(Token = "0x60004DB")]
				[Address(RVA = "0x809D40", Offset = "0x809D40", VA = "0x809D40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x809564", Offset = "0x809564", VA = "0x809564")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x8095E0", Offset = "0x8095E0", VA = "0x8095E0")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x809BD8", Offset = "0x809BD8", VA = "0x809BD8")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x809D8C", Offset = "0x809D8C", VA = "0x809D8C")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x80953C", Offset = "0x80953C", VA = "0x80953C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x809584", Offset = "0x809584", VA = "0x809584")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x809BC8", Offset = "0x809BC8", VA = "0x809BC8")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E2")]
		public enum Mode
		{
			[Token(Token = "0x40004A0")]
			Position,
			[Token(Token = "0x40004A1")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000E3")]
		public class Absorber
		{
			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x809F04", Offset = "0x809F04", VA = "0x809F04")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x80A0D8", Offset = "0x80A0D8", VA = "0x80A0D8")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x80A0FC", Offset = "0x80A0FC", VA = "0x80A0FC")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x80A20C", Offset = "0x80A20C", VA = "0x80A20C")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x80A3A4", Offset = "0x80A3A4", VA = "0x80A3A4")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x809DA0", Offset = "0x809DA0", VA = "0x809DA0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x809E84", Offset = "0x809E84", VA = "0x809E84")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x809FCC", Offset = "0x809FCC", VA = "0x809FCC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x80A190", Offset = "0x80A190", VA = "0x80A190")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x80A27C", Offset = "0x80A27C", VA = "0x80A27C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x80A394", Offset = "0x80A394", VA = "0x80A394")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x80A404", Offset = "0x80A404", VA = "0x80A404")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x80A474", Offset = "0x80A474", VA = "0x80A474")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x80A544", Offset = "0x80A544", VA = "0x80A544")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x80A68C", Offset = "0x80A68C", VA = "0x80A68C")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E6")]
		public class EffectorLink
		{
			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x80A90C", Offset = "0x80A90C", VA = "0x80A90C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x80A6A0", Offset = "0x80A6A0", VA = "0x80A6A0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x80A78C", Offset = "0x80A78C", VA = "0x80A78C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x80A904", Offset = "0x80A904", VA = "0x80A904")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of this script.")]
		public float weight;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x80A91C", Offset = "0x80A91C", VA = "0x80A91C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x80AC1C", Offset = "0x80AC1C", VA = "0x80AC1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x80B418", Offset = "0x80B418", VA = "0x80B418")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x1700006B")]
		private bool holding
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x80B698", Offset = "0x80B698", VA = "0x80B698")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x80B484", Offset = "0x80B484", VA = "0x80B484")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004F5")]
		protected abstract void RotatePivot();

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x80B6B8", Offset = "0x80B6B8", VA = "0x80B6B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x80B878", Offset = "0x80B878", VA = "0x80B878")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x80B9E8", Offset = "0x80B9E8", VA = "0x80B9E8")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x80BAB8", Offset = "0x80BAB8", VA = "0x80BAB8")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x80BBD8", Offset = "0x80BBD8", VA = "0x80BBD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x80BD4C", Offset = "0x80BD4C", VA = "0x80BD4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x80BF48", Offset = "0x80BF48", VA = "0x80BF48")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x80BF5C", Offset = "0x80BF5C", VA = "0x80BF5C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x80C13C", Offset = "0x80C13C", VA = "0x80C13C")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x80C150", Offset = "0x80C150", VA = "0x80C150", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x80C264", Offset = "0x80C264", VA = "0x80C264")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x20000EC")]
		[CompilerGenerated]
		private sealed class <applyForce>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtilityDemo <>4__this;

			[Token(Token = "0x1700006C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600050A")]
				[Address(RVA = "0x80C6A4", Offset = "0x80C6A4", VA = "0x80C6A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600050C")]
				[Address(RVA = "0x80C6EC", Offset = "0x80C6EC", VA = "0x80C6EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0x80C570", Offset = "0x80C570", VA = "0x80C570")]
			[DebuggerHidden]
			public <applyForce>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000508")]
			[Address(RVA = "0x80C5AC", Offset = "0x80C5AC", VA = "0x80C5AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x80C5B0", Offset = "0x80C5B0", VA = "0x80C5B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0x80C6AC", Offset = "0x80C6AC", VA = "0x80C6AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Rigidbody rigibodyHit;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float hitForce;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody hitTransform;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RaycastHit raycastHit;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Camera theCamera;

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x80C278", Offset = "0x80C278", VA = "0x80C278")]
		private void Start()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x80C2FC", Offset = "0x80C2FC", VA = "0x80C2FC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x80C394", Offset = "0x80C394", VA = "0x80C394")]
		private void Update()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x80C508", Offset = "0x80C508", VA = "0x80C508")]
		[IteratorStateMachine(typeof(<applyForce>d__13))]
		private IEnumerator applyForce()
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x80C598", Offset = "0x80C598", VA = "0x80C598")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	[RequireComponent(typeof(Recoil))]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x80C6F4", Offset = "0x80C6F4", VA = "0x80C6F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x80C744", Offset = "0x80C744", VA = "0x80C744")]
		private void Update()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x80C790", Offset = "0x80C790", VA = "0x80C790")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x80C828", Offset = "0x80C828", VA = "0x80C828")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x1700006E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000518")]
				[Address(RVA = "0x80CB68", Offset = "0x80CB68", VA = "0x80CB68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600051A")]
				[Address(RVA = "0x80CBB0", Offset = "0x80CBB0", VA = "0x80CBB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000515")]
			[Address(RVA = "0x80C99C", Offset = "0x80C99C", VA = "0x80C99C")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0x80C9D4", Offset = "0x80C9D4", VA = "0x80C9D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000517")]
			[Address(RVA = "0x80C9D8", Offset = "0x80C9D8", VA = "0x80C9D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000519")]
			[Address(RVA = "0x80CB70", Offset = "0x80CB70", VA = "0x80CB70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x80C838", Offset = "0x80C838", VA = "0x80C838")]
		private void Start()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x80C8E8", Offset = "0x80C8E8", VA = "0x80C8E8")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x80C924", Offset = "0x80C924", VA = "0x80C924")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x80C9C4", Offset = "0x80C9C4", VA = "0x80C9C4")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	[RequireComponent(typeof(Animator))]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x20000F1")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x17000070")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000521")]
				[Address(RVA = "0x80CE24", Offset = "0x80CE24", VA = "0x80CE24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000523")]
				[Address(RVA = "0x80CE6C", Offset = "0x80CE6C", VA = "0x80CE6C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600051E")]
			[Address(RVA = "0x80CCC8", Offset = "0x80CCC8", VA = "0x80CCC8")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600051F")]
			[Address(RVA = "0x80CCF8", Offset = "0x80CCF8", VA = "0x80CCF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000520")]
			[Address(RVA = "0x80CCFC", Offset = "0x80CCFC", VA = "0x80CCFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000522")]
			[Address(RVA = "0x80CE2C", Offset = "0x80CE2C", VA = "0x80CE2C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x80CBB8", Offset = "0x80CBB8", VA = "0x80CBB8")]
		private void Start()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x80CC60", Offset = "0x80CC60", VA = "0x80CC60")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x80CCF0", Offset = "0x80CCF0", VA = "0x80CCF0")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F3")]
		public class EffectorLink
		{
			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000528")]
			[Address(RVA = "0x80CED8", Offset = "0x80CED8", VA = "0x80CED8")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000529")]
			[Address(RVA = "0x80DA14", Offset = "0x80DA14", VA = "0x80DA14")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x600052A")]
			[Address(RVA = "0x80D29C", Offset = "0x80D29C", VA = "0x80D29C")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0x80DAF0", Offset = "0x80DAF0", VA = "0x80DAF0")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0x80DBD4", Offset = "0x80DBD4", VA = "0x80DBD4")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0x80DC60", Offset = "0x80DC60", VA = "0x80DC60")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0x80DCE8", Offset = "0x80DCE8", VA = "0x80DCE8")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0x80D854", Offset = "0x80D854", VA = "0x80D854")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0x80DD70", Offset = "0x80DD70", VA = "0x80DD70")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x80CE74", Offset = "0x80CE74", VA = "0x80CE74")]
		private void Start()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x80D23C", Offset = "0x80D23C", VA = "0x80D23C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x80D7A4", Offset = "0x80D7A4", VA = "0x80D7A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x80DA0C", Offset = "0x80DA0C", VA = "0x80DA0C")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("The amount of motion to transfer.")]
		public float transferMotion;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x80DDA4", Offset = "0x80DDA4", VA = "0x80DDA4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x80DDD4", Offset = "0x80DDD4", VA = "0x80DDD4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x80DE84", Offset = "0x80DE84", VA = "0x80DE84")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x80DE98", Offset = "0x80DE98", VA = "0x80DE98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x80E07C", Offset = "0x80E07C", VA = "0x80E07C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x80E318", Offset = "0x80E318", VA = "0x80E318")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x80E3E0", Offset = "0x80E3E0", VA = "0x80E3E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x80E4EC", Offset = "0x80E4EC", VA = "0x80E4EC")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x80F4F4", Offset = "0x80F4F4", VA = "0x80F4F4", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x80F94C", Offset = "0x80F94C", VA = "0x80F94C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x80FB14", Offset = "0x80FB14", VA = "0x80FB14")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x80FB48", Offset = "0x80FB48", VA = "0x80FB48")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x80FD50", Offset = "0x80FD50", VA = "0x80FD50")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x80FDBC", Offset = "0x80FDBC", VA = "0x80FDBC")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x20000F9")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x17000072")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000548")]
				[Address(RVA = "0x810508", Offset = "0x810508", VA = "0x810508", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600054A")]
				[Address(RVA = "0x810550", Offset = "0x810550", VA = "0x810550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x81019C", Offset = "0x81019C", VA = "0x81019C")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x81038C", Offset = "0x81038C", VA = "0x81038C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0x810390", Offset = "0x810390", VA = "0x810390", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0x810510", Offset = "0x810510", VA = "0x810510", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x80FDC4", Offset = "0x80FDC4", VA = "0x80FDC4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x80FEE8", Offset = "0x80FEE8", VA = "0x80FEE8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x80FE80", Offset = "0x80FE80", VA = "0x80FE80")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x8101C4", Offset = "0x8101C4", VA = "0x8101C4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x81029C", Offset = "0x81029C", VA = "0x81029C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x810370", Offset = "0x810370", VA = "0x810370")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x810558", Offset = "0x810558", VA = "0x810558")]
		private void Start()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x8105C0", Offset = "0x8105C0", VA = "0x8105C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x81066C", Offset = "0x81066C", VA = "0x81066C")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FC")]
		public class Part
		{
			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x8106E0", Offset = "0x8106E0", VA = "0x8106E0")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x810800", Offset = "0x810800", VA = "0x810800")]
			public Part()
			{
			}
		}

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x81067C", Offset = "0x81067C", VA = "0x81067C")]
		private void Update()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x8107F8", Offset = "0x8107F8", VA = "0x8107F8")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x810808", Offset = "0x810808", VA = "0x810808")]
		private void Update()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x81094C", Offset = "0x81094C", VA = "0x81094C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x810AB0", Offset = "0x810AB0", VA = "0x810AB0")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x810AC0", Offset = "0x810AC0", VA = "0x810AC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x810AEC", Offset = "0x810AEC", VA = "0x810AEC")]
		[ContextMenu("Calibrate")]
		private void Calibrate()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x810B1C", Offset = "0x810B1C", VA = "0x810B1C")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x810B24", Offset = "0x810B24", VA = "0x810B24")]
		private void Start()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x810B74", Offset = "0x810B74", VA = "0x810B74")]
		private void Update()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x810D4C", Offset = "0x810D4C", VA = "0x810D4C")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000100")]
	[RequireComponent(typeof(Animator))]
	public class AnimatorIKDemo : MonoBehaviour
	{
		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftHandIKTarget;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x810DA4", Offset = "0x810DA4", VA = "0x810DA4")]
		private void Start()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x810DF4", Offset = "0x810DF4", VA = "0x810DF4")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x810E4C", Offset = "0x810E4C", VA = "0x810E4C")]
		public AnimatorIKDemo()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class BallShooter : MonoBehaviour
	{
		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode keyCode;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject ball;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 spawnOffset;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 force;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float mass;

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x810E54", Offset = "0x810E54", VA = "0x810E54")]
		private void Update()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x811070", Offset = "0x811070", VA = "0x811070")]
		public BallShooter()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class CharacterAnimationMeleeDemo : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x17000074")]
		private CharacterMeleeDemo melee
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x81109C", Offset = "0x81109C", VA = "0x81109C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x811118", Offset = "0x811118", VA = "0x811118", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x8115D8", Offset = "0x8115D8", VA = "0x8115D8")]
		public CharacterAnimationMeleeDemo()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class CharacterMeleeDemo : CharacterPuppet
	{
		[Serializable]
		[Token(Token = "0x2000104")]
		public class Action
		{
			[Serializable]
			[Token(Token = "0x2000105")]
			public class Anim
			{
				[Token(Token = "0x4000543")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string stateName;

				[Token(Token = "0x4000544")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public int layer;

				[Token(Token = "0x4000545")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public float transitionDuration;

				[Token(Token = "0x4000546")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public float fixedTime;

				[Token(Token = "0x6000569")]
				[Address(RVA = "0x811C2C", Offset = "0x811C2C", VA = "0x811C2C")]
				public Anim()
				{
				}
			}

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int inputActionIndex;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float duration;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float minFrequency;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Anim anim;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int[] requiredPropTypes;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Booster[] boosters;

			[Token(Token = "0x6000568")]
			[Address(RVA = "0x811C1C", Offset = "0x811C1C", VA = "0x811C1C")]
			public Action()
			{
			}
		}

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[Header("Melee")]
		public Action[] actions;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[HideInInspector]
		public int currentActionIndex;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		[HideInInspector]
		public float lastActionTime;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private float lastActionMoveMag;

		[Token(Token = "0x17000075")]
		public Action currentAction
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x811598", Offset = "0x811598", VA = "0x811598")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x811620", Offset = "0x811620", VA = "0x811620", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x8116A0", Offset = "0x8116A0", VA = "0x8116A0", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x8119C8", Offset = "0x8119C8", VA = "0x8119C8")]
		private bool StartAction(Action action)
		{
			return default(bool);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x811C0C", Offset = "0x811C0C", VA = "0x811C0C")]
		public CharacterMeleeDemo()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class CharacterPuppet : CharacterThirdPerson
	{
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[Header("Puppet")]
		public PropRoot propRoot;

		[Token(Token = "0x17000076")]
		public BehaviourPuppet puppet
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x811C34", Offset = "0x811C34", VA = "0x811C34")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x811C3C", Offset = "0x811C3C", VA = "0x811C3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x81162C", Offset = "0x81162C", VA = "0x81162C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x811E18", Offset = "0x811E18", VA = "0x811E18", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x811F44", Offset = "0x811F44", VA = "0x811F44", Slot = "9")]
		protected override void Rotate()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x8125B8", Offset = "0x8125B8", VA = "0x8125B8", Slot = "10")]
		protected override bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x811C18", Offset = "0x811C18", VA = "0x811C18")]
		public CharacterPuppet()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class CreatePuppetInRuntime : MonoBehaviour
	{
		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Creating a Puppet from a ragdoll character prefab.")]
		public Transform ragdollPrefab;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("What will the Puppet be named?")]
		public string instanceName;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The layer to assign the character controller to. Collisions between this layer and the 'Ragdoll Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int characterControllerLayer;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("The layer to assign the PuppetMaster and all it's muscles to. Collisions between this layer and the 'Character Controller Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int ragdollLayer;

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x812814", Offset = "0x812814", VA = "0x812814")]
		private void Start()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x812980", Offset = "0x812980", VA = "0x812980")]
		public CreatePuppetInRuntime()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class CreateRagdollInRuntime : MonoBehaviour
	{
		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The character prefab/FBX.")]
		public GameObject prefab;

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x8129D0", Offset = "0x8129D0", VA = "0x8129D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x812B5C", Offset = "0x812B5C", VA = "0x812B5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x812B60", Offset = "0x812B60", VA = "0x812B60")]
		public CreateRagdollInRuntime()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class Destructor : MonoBehaviour
	{
		[Token(Token = "0x200010A")]
		[CompilerGenerated]
		private sealed class <Destruct>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Destructor <>4__this;

			[Token(Token = "0x17000077")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600057C")]
				[Address(RVA = "0x812D18", Offset = "0x812D18", VA = "0x812D18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000078")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600057E")]
				[Address(RVA = "0x812D60", Offset = "0x812D60", VA = "0x812D60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0x812BF0", Offset = "0x812BF0", VA = "0x812BF0")]
			[DebuggerHidden]
			public <Destruct>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x600057A")]
			[Address(RVA = "0x812C28", Offset = "0x812C28", VA = "0x812C28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0x812C2C", Offset = "0x812C2C", VA = "0x812C2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600057D")]
			[Address(RVA = "0x812D20", Offset = "0x812D20", VA = "0x812D20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float delay;

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x812B68", Offset = "0x812B68", VA = "0x812B68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x812B88", Offset = "0x812B88", VA = "0x812B88")]
		[IteratorStateMachine(typeof(<Destruct>d__2))]
		private IEnumerator Destruct()
		{
			return null;
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x812C18", Offset = "0x812C18", VA = "0x812C18")]
		public Destructor()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class Dying : MonoBehaviour
	{
		[Token(Token = "0x200010C")]
		[CompilerGenerated]
		private sealed class <FadeOutPinWeight>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x17000079")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000587")]
				[Address(RVA = "0x8131FC", Offset = "0x8131FC", VA = "0x8131FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000589")]
				[Address(RVA = "0x813244", Offset = "0x813244", VA = "0x813244", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x813094", Offset = "0x813094", VA = "0x813094")]
			[DebuggerHidden]
			public <FadeOutPinWeight>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x813150", Offset = "0x813150", VA = "0x813150", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x813154", Offset = "0x813154", VA = "0x813154", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0x813204", Offset = "0x813204", VA = "0x813204", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200010D")]
		[CompilerGenerated]
		private sealed class <FadeOutMuscleWeight>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x1700007B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600058D")]
				[Address(RVA = "0x8132F8", Offset = "0x8132F8", VA = "0x8132F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600058F")]
				[Address(RVA = "0x813340", Offset = "0x813340", VA = "0x813340", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600058A")]
			[Address(RVA = "0x8130BC", Offset = "0x8130BC", VA = "0x8130BC")]
			[DebuggerHidden]
			public <FadeOutMuscleWeight>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0x81324C", Offset = "0x81324C", VA = "0x81324C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600058C")]
			[Address(RVA = "0x813250", Offset = "0x813250", VA = "0x813250", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0x813300", Offset = "0x813300", VA = "0x813300", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the PuppetMaster component.")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The speed of fading out PuppetMaster.pinWeight.")]
		public float fadeOutPinWeightSpeed;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The speed of fading out PuppetMaster.muscleWeight.")]
		public float fadeOutMuscleWeightSpeed;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The muscle weight to fade out to.")]
		public float deadMuscleWeight;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool isDead;

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x812D68", Offset = "0x812D68", VA = "0x812D68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x812DFC", Offset = "0x812DFC", VA = "0x812DFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x812FC4", Offset = "0x812FC4", VA = "0x812FC4")]
		[IteratorStateMachine(typeof(<FadeOutPinWeight>d__10))]
		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x81302C", Offset = "0x81302C", VA = "0x81302C")]
		[IteratorStateMachine(typeof(<FadeOutMuscleWeight>d__11))]
		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x8130E4", Offset = "0x8130E4", VA = "0x8130E4")]
		public Dying()
		{
		}
	}
	[Token(Token = "0x200010E")]
	[RequireComponent(typeof(ParticleSystem))]
	public class FXCollisionBlood : MonoBehaviour
	{
		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minCollisionImpulse;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int emission;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float emissionImpulseAdd;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int maxEmission;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem particles;

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x813348", Offset = "0x813348", VA = "0x813348")]
		private void Start()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x813434", Offset = "0x813434", VA = "0x813434")]
		private void OnCollisionImpulse(MuscleCollision m, float impulse)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x813580", Offset = "0x813580", VA = "0x813580")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x813684", Offset = "0x813684", VA = "0x813684")]
		public FXCollisionBlood()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class Grab : MonoBehaviour
	{
		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The PuppetMaster this muscle belongs to.")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Used for switching walk/run by default.")]
		public UserControlMelee userControl;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The layers we wish to grab (optimization).")]
		public int grabLayer;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool grabbed;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Collider c;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BehaviourPuppet otherPuppet;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Collider otherCollider;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ConfigurableJoint joint;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float nextGrabTime;

		[Token(Token = "0x4000570")]
		private const float massMlp = 5f;

		[Token(Token = "0x4000571")]
		private const int solverIterationMlp = 10;

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x8136A4", Offset = "0x8136A4", VA = "0x8136A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x813720", Offset = "0x813720", VA = "0x813720")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x813AB4", Offset = "0x813AB4", VA = "0x813AB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x813BD0", Offset = "0x813BD0", VA = "0x813BD0")]
		public Grab()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class Killing : MonoBehaviour
	{
		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the PuppetMaster component.")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Settings for killing and freezing the puppet.")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x813BD8", Offset = "0x813BD8", VA = "0x813BD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x813C9C", Offset = "0x813C9C", VA = "0x813C9C")]
		public Killing()
		{
		}
	}
	[Token(Token = "0x2000111")]
	[RequireComponent(typeof(PuppetMaster))]
	public class LayerSetup : MonoBehaviour
	{
		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the character controller gameobject (the one that has the capsule collider/CharacterController.")]
		[Header("References")]
		public Transform characterController;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The layer to assign the character controller to. Collisions between this layer and the 'Ragdoll Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		[Header("Layers")]
		public int characterControllerLayer;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The layer to assign the PuppetMaster and all it's muscles to. Collisions between this layer and the 'Character Controller Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int ragdollLayer;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Layers that will be ignored by the character controller")]
		public LayerMask ignoreCollisionWithCharacterController;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Layers that will not collide with the Ragdoll layer.")]
		public LayerMask ignoreCollisionWithRagdoll;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PuppetMaster puppetMaster;

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x813CE4", Offset = "0x813CE4", VA = "0x813CE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x813ED4", Offset = "0x813ED4", VA = "0x813ED4")]
		public LayerSetup()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class Planet : MonoBehaviour
	{
		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float mass;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rigidbody[] rigidbodies;

		[Token(Token = "0x400057C")]
		private const float G = 6.672E-11f;

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x813EDC", Offset = "0x813EDC", VA = "0x813EDC")]
		private void Start()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x813F9C", Offset = "0x813F9C", VA = "0x813F9C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x81401C", Offset = "0x81401C", VA = "0x81401C")]
		private void ApplyGravity(Rigidbody r)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x814124", Offset = "0x814124", VA = "0x814124")]
		public Planet()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class PropDemo : MonoBehaviour
	{
		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Prop you wish to pick up.")]
		public Prop prop;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The PropRoot of the left hand.")]
		public PropRoot propRootLeft;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The PropRoot of the right hand.")]
		public PropRoot propRootRight;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("If true, the prop will be picked up when PuppetMaster initiates")]
		public bool pickUpOnStart;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool right;

		[Token(Token = "0x1700007D")]
		private PropRoot connectTo
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x814170", Offset = "0x814170", VA = "0x814170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x814134", Offset = "0x814134", VA = "0x814134")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x81418C", Offset = "0x81418C", VA = "0x81418C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x814264", Offset = "0x814264", VA = "0x814264")]
		public PropDemo()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class PropMelee : Prop
	{
		[Token(Token = "0x2000115")]
		[CompilerGenerated]
		private sealed class <Action>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropMelee <>4__this;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <additionalPinMuscleIndex>5__2;

			[Token(Token = "0x1700007E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005AD")]
				[Address(RVA = "0x8146CC", Offset = "0x8146CC", VA = "0x8146CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0x814714", Offset = "0x814714", VA = "0x814714", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x8142EC", Offset = "0x8142EC", VA = "0x8142EC")]
			[DebuggerHidden]
			public <Action>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x8144B4", Offset = "0x8144B4", VA = "0x8144B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x8144B8", Offset = "0x8144B8", VA = "0x8144B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x8146D4", Offset = "0x8146D4", VA = "0x8146D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Melee")]
		[Tooltip("Switch to a CapsuleCollider when the prop is picked up so it behaves more smoothly when colliding with objects.")]
		public CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The default BoxCollider used when this prop is not picked up.")]
		public BoxCollider boxCollider;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("Temporarily increase the radius of the capsule collider when a hitting action is triggered, so it would not pass colliders too easily.")]
		public float actionColliderRadiusMlp;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Tooltip("Temporarily set (increase) the pin weight of the additional pin when a hitting action is triggered.")]
		[Range(0f, 1f)]
		public float actionAdditionalPinWeight;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0.1f, 10f)]
		[Tooltip("Temporarily increase the mass of the Rigidbody when a hitting action is triggered.")]
		public float actionMassMlp;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Tooltip("Offset to the default center of mass of the Rigidbody (might improve prop handling).")]
		public Vector3 COMOffset;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float defaultColliderRadius;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float defaultMass;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float defaultAddMass;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Rigidbody r;

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x811B44", Offset = "0x811B44", VA = "0x811B44")]
		public void StartAction(float duration)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x814274", Offset = "0x814274", VA = "0x814274")]
		[IteratorStateMachine(typeof(<Action>d__11))]
		public IEnumerator Action(float duration)
		{
			return null;
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x814314", Offset = "0x814314", VA = "0x814314", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x8143C4", Offset = "0x8143C4", VA = "0x8143C4", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x814430", Offset = "0x814430", VA = "0x814430", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x81449C", Offset = "0x81449C", VA = "0x81449C")]
		public PropMelee()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class PropPickUpTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Prop prop;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask characterLayers;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CharacterPuppet characterPuppet;

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x81471C", Offset = "0x81471C", VA = "0x81471C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x814888", Offset = "0x814888", VA = "0x814888")]
		public PropPickUpTrigger()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class PuppetBoard : MonoBehaviour
	{
		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Board target Rigidbody.")]
		public Rigidbody target;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Pivot Transform of the body target.")]
		public Transform bodyTargetPivot;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The body target keeps the puppet upright by a SpringJoint connected to the body.")]
		public Transform bodyTarget;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x814890", Offset = "0x814890", VA = "0x814890")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x814930", Offset = "0x814930", VA = "0x814930")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x814B18", Offset = "0x814B18", VA = "0x814B18")]
		public PuppetBoard()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class PuppetScaling : MonoBehaviour
	{
		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0.01f, 10f)]
		public float masterScale;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int muscleIndex;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0.01f, 10f)]
		public float muscleScale;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float defaultMuscleSpring;

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x814B20", Offset = "0x814B20", VA = "0x814B20")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x814B48", Offset = "0x814B48", VA = "0x814B48")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x814EF8", Offset = "0x814EF8", VA = "0x814EF8")]
		public PuppetScaling()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class RaycastShooter : MonoBehaviour
	{
		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask layers;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unpin;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float force;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem blood;

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x814F0C", Offset = "0x814F0C", VA = "0x814F0C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x815158", Offset = "0x815158", VA = "0x815158")]
		public RaycastShooter()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class Respawning : MonoBehaviour
	{
		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Pooled characters will be parented to this deactivated GameObject.")]
		public Transform pool;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the BehaviourPuppet component of the character you wish to respawn.")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The animation to play on respawn.")]
		public string idleAnimation;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform puppetRoot;

		[Token(Token = "0x17000080")]
		private bool isPooled
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x815168", Offset = "0x815168", VA = "0x815168")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x8151F0", Offset = "0x8151F0", VA = "0x8151F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x815244", Offset = "0x815244", VA = "0x815244")]
		private void Update()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x815368", Offset = "0x815368", VA = "0x815368")]
		private void Pool()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x81538C", Offset = "0x81538C", VA = "0x81538C")]
		private void Respawn(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x81546C", Offset = "0x81546C", VA = "0x81546C")]
		public Respawning()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class RotateShoulderToTarget : MonoBehaviour
	{
		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform shoulder;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 euler;

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x815474", Offset = "0x815474", VA = "0x815474")]
		private void OnPuppetMasterRead()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x815564", Offset = "0x815564", VA = "0x815564")]
		public RotateShoulderToTarget()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class SkeletonShooter : MonoBehaviour
	{
		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MuscleRemoveMode removeMuscleMode;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float unpin;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem particles;

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x81556C", Offset = "0x81556C", VA = "0x81556C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x8158F0", Offset = "0x8158F0", VA = "0x8158F0")]
		public SkeletonShooter()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class UserControlAIMelee : UserControlThirdPerson
	{
		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourPuppet targetPuppet;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isAttacking;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float attackTimer;

		[Token(Token = "0x17000081")]
		private Transform moveTarget
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x815900", Offset = "0x815900", VA = "0x815900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x815948", Offset = "0x815948", VA = "0x815948", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x815C2C", Offset = "0x815C2C", VA = "0x815C2C")]
		private bool CanAttack()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x815D70", Offset = "0x815D70", VA = "0x815D70")]
		public UserControlAIMelee()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class UserControlMelee : UserControlThirdPerson
	{
		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public KeyCode hitKey;

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x815D8C", Offset = "0x815D8C", VA = "0x815D8C", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x815DB4", Offset = "0x815DB4", VA = "0x815DB4")]
		public UserControlMelee()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000082")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x815DE4", Offset = "0x815DE4", VA = "0x815DE4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x815DC4", Offset = "0x815DC4", VA = "0x815DC4", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x815DEC", Offset = "0x815DEC", VA = "0x815DEC")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x815E4C", Offset = "0x815E4C", VA = "0x815E4C", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x8160B8", Offset = "0x8160B8", VA = "0x8160B8", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x8162FC", Offset = "0x8162FC", VA = "0x8162FC", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x8160C8", Offset = "0x8160C8", VA = "0x8160C8")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x81630C", Offset = "0x81630C", VA = "0x81630C")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000120")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x816324", Offset = "0x816324", VA = "0x816324", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x81637C", Offset = "0x81637C", VA = "0x81637C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x81640C", Offset = "0x81640C", VA = "0x81640C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x816530", Offset = "0x816530", VA = "0x816530")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000121")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Range(0.1f, 3f)]
		private float animSpeedMultiplier;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40005C4")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40005C5")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x17000083")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x8165E0", Offset = "0x8165E0", VA = "0x8165E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x816548", Offset = "0x816548", VA = "0x816548", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x8165C4", Offset = "0x8165C4", VA = "0x8165C4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x811204", Offset = "0x811204", VA = "0x811204", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x8166D4", Offset = "0x8166D4", VA = "0x8166D4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x8115FC", Offset = "0x8115FC", VA = "0x8115FC")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000122")]
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Rigidbody))]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		protected float gravityMultiplier;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40005D1")]
		protected const float half = 0.5f;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60005DC")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x8167FC", Offset = "0x8167FC", VA = "0x8167FC")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x8169E8", Offset = "0x8169E8", VA = "0x8169E8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x816B98", Offset = "0x816B98", VA = "0x816B98", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x816D38", Offset = "0x816D38", VA = "0x816D38")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x816D98", Offset = "0x816D98", VA = "0x816D98")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x816EFC", Offset = "0x816EFC", VA = "0x816EFC")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x817100", Offset = "0x817100", VA = "0x817100")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x817124", Offset = "0x817124", VA = "0x817124")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x817148", Offset = "0x817148", VA = "0x817148")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x817294", Offset = "0x817294", VA = "0x817294")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000124")]
		public enum MoveMode
		{
			[Token(Token = "0x4000609")]
			Directional,
			[Token(Token = "0x400060A")]
			Strafe
		}

		[Token(Token = "0x2000125")]
		public struct AnimState
		{
			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;
		}

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public float airSpeed;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Header("Wall Running")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float wallRunMaxLength;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AnimState animState;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Animator animator;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 normal;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private RaycastHit hit;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float jumpLeg;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float jumpEndTime;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float forwardMlp;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float groundDistance;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float lastAirTime;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float stickyForce;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 wallNormal;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float wallRunWeight;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private bool fixedFrame;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float wallRunEndTime;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 gravity;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float velocityY;

		[Token(Token = "0x17000084")]
		public bool onGround
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x8172B4", Offset = "0x8172B4", VA = "0x8172B4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x8172BC", Offset = "0x8172BC", VA = "0x8172BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x811C44", Offset = "0x811C44", VA = "0x811C44", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x8172C8", Offset = "0x8172C8", VA = "0x8172C8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x811E94", Offset = "0x811E94", VA = "0x811E94", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x81734C", Offset = "0x81734C", VA = "0x81734C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x811B80", Offset = "0x811B80", VA = "0x811B80", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x8186E4", Offset = "0x8186E4", VA = "0x8186E4", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x817924", Offset = "0x817924", VA = "0x817924")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x8187BC", Offset = "0x8187BC", VA = "0x8187BC")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x818E48", Offset = "0x818E48", VA = "0x818E48")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x8182FC", Offset = "0x8182FC", VA = "0x8182FC")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x812138", Offset = "0x812138", VA = "0x812138", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x818F38", Offset = "0x818F38", VA = "0x818F38")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x8125E4", Offset = "0x8125E4", VA = "0x8125E4", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x817D9C", Offset = "0x817D9C", VA = "0x817D9C")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x812714", Offset = "0x812714", VA = "0x812714")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000126")]
	[RequireComponent(typeof(Animator))]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000127")]
		public enum RotationMode
		{
			[Token(Token = "0x400061F")]
			Smooth,
			[Token(Token = "0x4000620")]
			Linear
		}

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Acceleration of movement.")]
		private float accelerationTime;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("Turning speed.")]
		private float turnTime;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		private bool walkByDefault;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Smooth or linear rotation.")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000085")]
		public bool isGrounded
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x819060", Offset = "0x819060", VA = "0x819060")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x819068", Offset = "0x819068", VA = "0x819068")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x819074", Offset = "0x819074", VA = "0x819074")]
		private void Start()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x819108", Offset = "0x819108", VA = "0x819108")]
		private void Update()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x819720", Offset = "0x819720", VA = "0x819720")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x819150", Offset = "0x819150", VA = "0x819150")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x8194B8", Offset = "0x8194B8", VA = "0x8194B8")]
		private void Move()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x819750", Offset = "0x819750", VA = "0x819750")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x8197E8", Offset = "0x8197E8", VA = "0x8197E8")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x819868", Offset = "0x819868", VA = "0x819868")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x819890", Offset = "0x819890", VA = "0x819890", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x819A4C", Offset = "0x819A4C", VA = "0x819A4C")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200012A")]
		public struct State
		{
			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x819A68", Offset = "0x819A68", VA = "0x819A68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x80F608", Offset = "0x80F608", VA = "0x80F608", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x80FB38", Offset = "0x80FB38", VA = "0x80FB38")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x819A94", Offset = "0x819A94", VA = "0x819A94")]
		private void Update()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x819ACC", Offset = "0x819ACC", VA = "0x819ACC")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x819AD4", Offset = "0x819AD4", VA = "0x819AD4")]
		private void Update()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x819AFC", Offset = "0x819AFC", VA = "0x819AFC")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x819BA0", Offset = "0x819BA0", VA = "0x819BA0")]
		public SlowMo()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200012D")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x819BB4", Offset = "0x819BB4", VA = "0x819BB4")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x819BF8", Offset = "0x819BF8", VA = "0x819BF8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x819C3C", Offset = "0x819C3C", VA = "0x819C3C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x819C80", Offset = "0x819C80", VA = "0x819C80")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x819CC4", Offset = "0x819CC4", VA = "0x819CC4")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x819D5C", Offset = "0x819D5C", VA = "0x819D5C")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x819D78", Offset = "0x819D78", VA = "0x819D78")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x819DA4", Offset = "0x819DA4", VA = "0x819DA4")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x819DD0", Offset = "0x819DD0", VA = "0x819DD0")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x819E0C", Offset = "0x819E0C", VA = "0x819E0C")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x819E4C", Offset = "0x819E4C", VA = "0x819E4C")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x819E6C", Offset = "0x819E6C", VA = "0x819E6C")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x819E8C", Offset = "0x819E8C", VA = "0x819E8C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x819EB0", Offset = "0x819EB0", VA = "0x819EB0")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x819ED8", Offset = "0x819ED8", VA = "0x819ED8")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x819F00", Offset = "0x819F00", VA = "0x819F00")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x819CE0", Offset = "0x819CE0", VA = "0x819CE0")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x819F24", Offset = "0x819F24", VA = "0x819F24")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x819F30", Offset = "0x819F30", VA = "0x819F30")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x819F3C", Offset = "0x819F3C", VA = "0x819F3C")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x81A1A8", Offset = "0x81A1A8", VA = "0x81A1A8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x81A244", Offset = "0x81A244", VA = "0x81A244", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x81A56C", Offset = "0x81A56C", VA = "0x81A56C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x81A9D8", Offset = "0x81A9D8", VA = "0x81A9D8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x81AA00", Offset = "0x81AA00", VA = "0x81AA00")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012E")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000086")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x81A078", Offset = "0x81A078", VA = "0x81A078")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x81AC20", Offset = "0x81AC20", VA = "0x81AC20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x81A3FC", Offset = "0x81A3FC", VA = "0x81A3FC")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x81AA94", Offset = "0x81AA94", VA = "0x81AA94")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012F")]
	public abstract class Constraint
	{
		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000088")]
		public bool isValid
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x81ADDC", Offset = "0x81ADDC", VA = "0x81ADDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600062A")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x81AE3C", Offset = "0x81AE3C", VA = "0x81AE3C")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000130")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x81AE44", Offset = "0x81AE44", VA = "0x81AE44", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x81AEDC", Offset = "0x81AEDC", VA = "0x81AEDC")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x81AEE4", Offset = "0x81AEE4", VA = "0x81AEE4")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000131")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000089")]
		private bool positionChanged
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x81B010", Offset = "0x81B010", VA = "0x81B010")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x81AF0C", Offset = "0x81AF0C", VA = "0x81AF0C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x81B06C", Offset = "0x81B06C", VA = "0x81B06C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x81B074", Offset = "0x81B074", VA = "0x81B074")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000132")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x81B09C", Offset = "0x81B09C", VA = "0x81B09C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x81B118", Offset = "0x81B118", VA = "0x81B118")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x81B120", Offset = "0x81B120", VA = "0x81B120")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000133")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700008A")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x81B24C", Offset = "0x81B24C", VA = "0x81B24C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x81B148", Offset = "0x81B148", VA = "0x81B148", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x81B2A4", Offset = "0x81B2A4", VA = "0x81B2A4")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x81B2AC", Offset = "0x81B2AC", VA = "0x81B2AC")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000134")]
	public class Constraints
	{
		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x81B2D4", Offset = "0x81B2D4", VA = "0x81B2D4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x81A51C", Offset = "0x81A51C", VA = "0x81A51C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x81A6E0", Offset = "0x81A6E0", VA = "0x81A6E0")]
		public void Update()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x81ADD4", Offset = "0x81ADD4", VA = "0x81ADD4")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000135")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000136")]
		public enum DOF
		{
			[Token(Token = "0x4000664")]
			One,
			[Token(Token = "0x4000665")]
			Three
		}

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x1700008B")]
		public bool initiated
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x81B334", Offset = "0x81B334", VA = "0x81B334")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x81B33C", Offset = "0x81B33C", VA = "0x81B33C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x81B348", Offset = "0x81B348", VA = "0x81B348")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x81B368", Offset = "0x81B368", VA = "0x81B368")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x81B388", Offset = "0x81B388", VA = "0x81B388")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x81B3A8", Offset = "0x81B3A8", VA = "0x81B3A8")]
			set
			{
			}
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x81B3C8", Offset = "0x81B3C8", VA = "0x81B3C8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x81B4B4", Offset = "0x81B4B4", VA = "0x81B4B4")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x81B850", Offset = "0x81B850", VA = "0x81B850")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x81B910", Offset = "0x81B910", VA = "0x81B910")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x81BCB4", Offset = "0x81BCB4", VA = "0x81BCB4")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("The master weight for all fingers.")]
		public float weight;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x1700008E")]
		public bool initiated
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x81BCC4", Offset = "0x81BCC4", VA = "0x81BCC4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x81BCCC", Offset = "0x81BCCC", VA = "0x81BCCC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x81BCD8", Offset = "0x81BCD8", VA = "0x81BCD8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x81BD4C", Offset = "0x81BD4C", VA = "0x81BD4C")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x81C058", Offset = "0x81C058", VA = "0x81C058")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x81C1C4", Offset = "0x81C1C4", VA = "0x81C1C4")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x81BF70", Offset = "0x81BF70", VA = "0x81BF70")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x81C328", Offset = "0x81C328", VA = "0x81C328", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x81C3D0", Offset = "0x81C3D0", VA = "0x81C3D0")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x81C440", Offset = "0x81C440", VA = "0x81C440")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x81C49C", Offset = "0x81C49C", VA = "0x81C49C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x81C4A0", Offset = "0x81C4A0", VA = "0x81C4A0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x81C4A4", Offset = "0x81C4A4", VA = "0x81C4A4")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000139")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool initiated;

		[Token(Token = "0x6000656")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x81C504", Offset = "0x81C504", VA = "0x81C504")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x81C7B4", Offset = "0x81C7B4", VA = "0x81C7B4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x81C5C8", Offset = "0x81C5C8", VA = "0x81C5C8")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x81C7DC", Offset = "0x81C7DC", VA = "0x81C7DC")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600065B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600065C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x81C950", Offset = "0x81C950", VA = "0x81C950")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200013A")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x81CABC", Offset = "0x81CABC", VA = "0x81CABC", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x81CB00", Offset = "0x81CB00", VA = "0x81CB00", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x81CB44", Offset = "0x81CB44", VA = "0x81CB44", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x81CBB0", Offset = "0x81CBB0", VA = "0x81CBB0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x81CC50", Offset = "0x81CC50", VA = "0x81CC50")]
		private void Update()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x81CCA4", Offset = "0x81CCA4", VA = "0x81CCA4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x81CFA8", Offset = "0x81CFA8", VA = "0x81CFA8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x81CFE8", Offset = "0x81CFE8", VA = "0x81CFE8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x81D448", Offset = "0x81D448", VA = "0x81D448")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x81D508", Offset = "0x81D508", VA = "0x81D508")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x81D6D8", Offset = "0x81D6D8", VA = "0x81D6D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x81D880", Offset = "0x81D880", VA = "0x81D880")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200013C")]
		public class SpineEffector
		{
			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x81E524", Offset = "0x81E524", VA = "0x81E524")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x81E534", Offset = "0x81E534", VA = "0x81E534")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x81D90C", Offset = "0x81D90C", VA = "0x81D90C")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x81D950", Offset = "0x81D950", VA = "0x81D950", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x81D994", Offset = "0x81D994", VA = "0x81D994", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x81D9D8", Offset = "0x81D9D8", VA = "0x81D9D8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x81DA44", Offset = "0x81DA44", VA = "0x81DA44")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x81DACC", Offset = "0x81DACC", VA = "0x81DACC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x81DD40", Offset = "0x81DD40", VA = "0x81DD40")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x81DD4C", Offset = "0x81DD4C", VA = "0x81DD4C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x81DB28", Offset = "0x81DB28", VA = "0x81DB28")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x81DD58", Offset = "0x81DD58", VA = "0x81DD58")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x81E0CC", Offset = "0x81E0CC", VA = "0x81E0CC")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x81E250", Offset = "0x81E250", VA = "0x81E250")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x81E384", Offset = "0x81E384", VA = "0x81E384")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x81E498", Offset = "0x81E498", VA = "0x81E498")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200013D")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		public float rootRotationWeight;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x81E578", Offset = "0x81E578", VA = "0x81E578", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x81E5BC", Offset = "0x81E5BC", VA = "0x81E5BC", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x81E600", Offset = "0x81E600", VA = "0x81E600", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x81E61C", Offset = "0x81E61C", VA = "0x81E61C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x81E83C", Offset = "0x81E83C", VA = "0x81E83C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x81E91C", Offset = "0x81E91C", VA = "0x81E91C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x81EDD0", Offset = "0x81EDD0", VA = "0x81EDD0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x81F20C", Offset = "0x81F20C", VA = "0x81F20C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x81F3BC", Offset = "0x81F3BC", VA = "0x81F3BC")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x81F744", Offset = "0x81F744", VA = "0x81F744")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x81F918", Offset = "0x81F918", VA = "0x81F918")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x81FB1C", Offset = "0x81FB1C", VA = "0x81FB1C")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200013E")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200013F")]
		public struct Foot
		{
			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x821A80", Offset = "0x821A80", VA = "0x821A80")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		[Range(-90f, 0f)]
		public float minRootRotation;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		[Range(0f, 90f)]
		public float maxRootRotation;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x81FBA8", Offset = "0x81FBA8", VA = "0x81FBA8", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x81FBEC", Offset = "0x81FBEC", VA = "0x81FBEC", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x81FC30", Offset = "0x81FC30", VA = "0x81FC30", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x81FC60", Offset = "0x81FC60", VA = "0x81FC60")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x81FD64", Offset = "0x81FD64", VA = "0x81FD64")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x81FF5C", Offset = "0x81FF5C", VA = "0x81FF5C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x81FFC0", Offset = "0x81FFC0", VA = "0x81FFC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x820018", Offset = "0x820018", VA = "0x820018")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x82030C", Offset = "0x82030C", VA = "0x82030C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x820664", Offset = "0x820664", VA = "0x820664")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x8206F4", Offset = "0x8206F4", VA = "0x8206F4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x8209F4", Offset = "0x8209F4", VA = "0x8209F4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x8210BC", Offset = "0x8210BC", VA = "0x8210BC")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x821374", Offset = "0x821374", VA = "0x821374")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x8214A8", Offset = "0x8214A8", VA = "0x8214A8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x821770", Offset = "0x821770", VA = "0x821770")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x8217A0", Offset = "0x8217A0", VA = "0x8217A0")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x82199C", Offset = "0x82199C", VA = "0x82199C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000140")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x821AB4", Offset = "0x821AB4", VA = "0x821AB4")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x821AB8", Offset = "0x821AB8", VA = "0x821AB8", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x821ABC", Offset = "0x821ABC", VA = "0x821ABC", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x821AC0", Offset = "0x821AC0", VA = "0x821AC0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x821B50", Offset = "0x821B50", VA = "0x821B50")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x821BD8", Offset = "0x821BD8", VA = "0x821BD8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x821C2C", Offset = "0x821C2C", VA = "0x821C2C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x8220D8", Offset = "0x8220D8", VA = "0x8220D8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x8224C0", Offset = "0x8224C0", VA = "0x8224C0")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x822544", Offset = "0x822544", VA = "0x822544")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x8227E0", Offset = "0x8227E0", VA = "0x8227E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x822914", Offset = "0x822914", VA = "0x822914")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x822AAC", Offset = "0x822AAC", VA = "0x822AAC")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000141")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000142")]
		public enum Quality
		{
			[Token(Token = "0x40006C8")]
			Fastest,
			[Token(Token = "0x40006C9")]
			Simple,
			[Token(Token = "0x40006CA")]
			Best
		}

		[Token(Token = "0x2000143")]
		public class Leg
		{
			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x17000097")]
			public bool isGrounded
			{
				[Token(Token = "0x60006C2")]
				[Address(RVA = "0x82400C", Offset = "0x82400C", VA = "0x82400C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006C3")]
				[Address(RVA = "0x824014", Offset = "0x824014", VA = "0x824014")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60006C4")]
				[Address(RVA = "0x824020", Offset = "0x824020", VA = "0x824020")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006C5")]
				[Address(RVA = "0x82402C", Offset = "0x82402C", VA = "0x82402C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000099")]
			public bool initiated
			{
				[Token(Token = "0x60006C6")]
				[Address(RVA = "0x824038", Offset = "0x824038", VA = "0x824038")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006C7")]
				[Address(RVA = "0x824040", Offset = "0x824040", VA = "0x824040")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009A")]
			public float heightFromGround
			{
				[Token(Token = "0x60006C8")]
				[Address(RVA = "0x82404C", Offset = "0x82404C", VA = "0x82404C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006C9")]
				[Address(RVA = "0x824054", Offset = "0x824054", VA = "0x824054")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			public Vector3 velocity
			{
				[Token(Token = "0x60006CA")]
				[Address(RVA = "0x82405C", Offset = "0x82405C", VA = "0x82405C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006CB")]
				[Address(RVA = "0x824068", Offset = "0x824068", VA = "0x824068")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009C")]
			public Transform transform
			{
				[Token(Token = "0x60006CC")]
				[Address(RVA = "0x824074", Offset = "0x824074", VA = "0x824074")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60006CD")]
				[Address(RVA = "0x82407C", Offset = "0x82407C", VA = "0x82407C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009D")]
			public float IKOffset
			{
				[Token(Token = "0x60006CE")]
				[Address(RVA = "0x824084", Offset = "0x824084", VA = "0x824084")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006CF")]
				[Address(RVA = "0x82408C", Offset = "0x82408C", VA = "0x82408C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009E")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60006D4")]
				[Address(RVA = "0x824650", Offset = "0x824650", VA = "0x824650")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700009F")]
			private float rootYOffset
			{
				[Token(Token = "0x60006DD")]
				[Address(RVA = "0x8247C4", Offset = "0x8247C4", VA = "0x8247C4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x823024", Offset = "0x823024", VA = "0x823024")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x824094", Offset = "0x824094", VA = "0x824094")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x823C34", Offset = "0x823C34", VA = "0x823C34")]
			public void Reset()
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x823114", Offset = "0x823114", VA = "0x823114")]
			public void Process()
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x8243D0", Offset = "0x8243D0", VA = "0x8243D0")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x8240D4", Offset = "0x8240D4", VA = "0x8240D4")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x8246E4", Offset = "0x8246E4", VA = "0x8246E4")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x824234", Offset = "0x824234", VA = "0x824234")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x8242B4", Offset = "0x8242B4", VA = "0x8242B4")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x824750", Offset = "0x824750", VA = "0x824750")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x824684", Offset = "0x824684", VA = "0x824684")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x824868", Offset = "0x824868", VA = "0x824868")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x822F84", Offset = "0x822F84", VA = "0x822F84")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000144")]
		public class Pelvis
		{
			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000A0")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60006DF")]
				[Address(RVA = "0x824A18", Offset = "0x824A18", VA = "0x824A18")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E0")]
				[Address(RVA = "0x824A24", Offset = "0x824A24", VA = "0x824A24")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A1")]
			public float heightOffset
			{
				[Token(Token = "0x60006E1")]
				[Address(RVA = "0x824A30", Offset = "0x824A30", VA = "0x824A30")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0x824A38", Offset = "0x824A38", VA = "0x824A38")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x8230EC", Offset = "0x8230EC", VA = "0x8230EC")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x823BA0", Offset = "0x823BA0", VA = "0x823BA0")]
			public void Reset()
			{
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x824A40", Offset = "0x824A40", VA = "0x824A40")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x82383C", Offset = "0x82383C", VA = "0x82383C")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x82301C", Offset = "0x82301C", VA = "0x82301C")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		public float footRotationWeight;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 90f)]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		[Range(0f, 1f)]
		public float pelvisDamper;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700008F")]
		public Leg[] legs
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x822B04", Offset = "0x822B04", VA = "0x822B04")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x822B0C", Offset = "0x822B0C", VA = "0x822B0C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x822B14", Offset = "0x822B14", VA = "0x822B14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x822B1C", Offset = "0x822B1C", VA = "0x822B1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public bool isGrounded
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x822B24", Offset = "0x822B24", VA = "0x822B24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x822B2C", Offset = "0x822B2C", VA = "0x822B2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public Transform root
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x822B38", Offset = "0x822B38", VA = "0x822B38")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x822B40", Offset = "0x822B40", VA = "0x822B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x822B48", Offset = "0x822B48", VA = "0x822B48")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x822B60", Offset = "0x822B60", VA = "0x822B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool rootGrounded
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x822B80", Offset = "0x822B80", VA = "0x822B80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000095")]
		public Vector3 up
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x822E20", Offset = "0x822E20", VA = "0x822E20")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000096")]
		private bool useRootRotation
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x823CC8", Offset = "0x823CC8", VA = "0x823CC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x822BC8", Offset = "0x822BC8", VA = "0x822BC8")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x822E88", Offset = "0x822E88", VA = "0x822E88")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x821E64", Offset = "0x821E64", VA = "0x821E64")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x8222CC", Offset = "0x8222CC", VA = "0x8222CC")]
		public void Update()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x823A28", Offset = "0x823A28", VA = "0x823A28")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x821AD8", Offset = "0x821AD8", VA = "0x821AD8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x8230FC", Offset = "0x8230FC", VA = "0x8230FC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x823D7C", Offset = "0x823D7C", VA = "0x823D7C")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x823E00", Offset = "0x823E00", VA = "0x823E00")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x823F54", Offset = "0x823F54", VA = "0x823F54")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x823FC4", Offset = "0x823FC4", VA = "0x823FC4")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000145")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	public class AimIK : IK
	{
		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x824A94", Offset = "0x824A94", VA = "0x824A94", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x824AD8", Offset = "0x824AD8", VA = "0x824AD8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x824B1C", Offset = "0x824B1C", VA = "0x824B1C")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x824B60", Offset = "0x824B60", VA = "0x824B60")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x824BA4", Offset = "0x824BA4", VA = "0x824BA4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x824BE8", Offset = "0x824BE8", VA = "0x824BE8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x824BF0", Offset = "0x824BF0", VA = "0x824BF0")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000146")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x824C60", Offset = "0x824C60", VA = "0x824C60", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x824CA4", Offset = "0x824CA4", VA = "0x824CA4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x824CE8", Offset = "0x824CE8", VA = "0x824CE8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x824D2C", Offset = "0x824D2C", VA = "0x824D2C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x824D70", Offset = "0x824D70", VA = "0x824D70", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x824D78", Offset = "0x824D78", VA = "0x824D78")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000147")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x824DE0", Offset = "0x824DE0", VA = "0x824DE0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x824E24", Offset = "0x824E24", VA = "0x824E24", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x824E68", Offset = "0x824E68", VA = "0x824E68")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x824EAC", Offset = "0x824EAC", VA = "0x824EAC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x824EF0", Offset = "0x824EF0", VA = "0x824EF0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x824EF8", Offset = "0x824EF8", VA = "0x824EF8")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000148")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x824F60", Offset = "0x824F60", VA = "0x824F60", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x824FA4", Offset = "0x824FA4", VA = "0x824FA4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x824FE8", Offset = "0x824FE8", VA = "0x824FE8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x82502C", Offset = "0x82502C", VA = "0x82502C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x825070", Offset = "0x825070", VA = "0x825070", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x825078", Offset = "0x825078", VA = "0x825078")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000149")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x8250E0", Offset = "0x8250E0", VA = "0x8250E0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x825124", Offset = "0x825124", VA = "0x825124", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x825168", Offset = "0x825168", VA = "0x825168")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x8251AC", Offset = "0x8251AC", VA = "0x8251AC")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x8251F0", Offset = "0x8251F0", VA = "0x8251F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x825234", Offset = "0x825234", VA = "0x825234")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x825278", Offset = "0x825278", VA = "0x825278")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x82529C", Offset = "0x82529C", VA = "0x82529C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x8252A4", Offset = "0x8252A4", VA = "0x8252A4")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x825460", Offset = "0x825460", VA = "0x825460")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x825910", Offset = "0x825910", VA = "0x825910")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x825930", Offset = "0x825930", VA = "0x825930")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x825A08", Offset = "0x825A08", VA = "0x825A08")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x600070E")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x825AA0", Offset = "0x825AA0", VA = "0x825AA0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x825B18", Offset = "0x825B18", VA = "0x825B18", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x825B88", Offset = "0x825B88", VA = "0x825B88", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000712")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000713")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x824C58", Offset = "0x824C58", VA = "0x824C58")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200014B")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x170000A2")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x825BD8", Offset = "0x825BD8", VA = "0x825BD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x825C64", Offset = "0x825C64", VA = "0x825C64")]
		private void Start()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x825CC8", Offset = "0x825CC8", VA = "0x825CC8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x825D68", Offset = "0x825D68", VA = "0x825D68")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x825D94", Offset = "0x825D94", VA = "0x825D94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x825CEC", Offset = "0x825CEC", VA = "0x825CEC")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x825E18", Offset = "0x825E18", VA = "0x825E18")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200014C")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x825E20", Offset = "0x825E20", VA = "0x825E20", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x825E88", Offset = "0x825E88", VA = "0x825E88", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x825EF0", Offset = "0x825EF0", VA = "0x825EF0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x825F34", Offset = "0x825F34", VA = "0x825F34")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x825F78", Offset = "0x825F78", VA = "0x825F78", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x825F80", Offset = "0x825F80", VA = "0x825F80")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200014D")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x825FE8", Offset = "0x825FE8", VA = "0x825FE8", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x82602C", Offset = "0x82602C", VA = "0x82602C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x826070", Offset = "0x826070", VA = "0x826070")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x8260B4", Offset = "0x8260B4", VA = "0x8260B4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x8260F8", Offset = "0x8260F8", VA = "0x8260F8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x826100", Offset = "0x826100", VA = "0x826100")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200014E")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page8.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x826168", Offset = "0x826168", VA = "0x826168", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x8261AC", Offset = "0x8261AC", VA = "0x8261AC", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x8261F0", Offset = "0x8261F0", VA = "0x8261F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x826234", Offset = "0x826234", VA = "0x826234")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x826278", Offset = "0x826278", VA = "0x826278", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x826280", Offset = "0x826280", VA = "0x826280")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x8262E8", Offset = "0x8262E8", VA = "0x8262E8", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x82632C", Offset = "0x82632C", VA = "0x82632C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x826370", Offset = "0x826370", VA = "0x826370")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x8263B4", Offset = "0x8263B4", VA = "0x8263B4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x8263F8", Offset = "0x8263F8", VA = "0x8263F8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x826400", Offset = "0x826400", VA = "0x826400")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000150")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000151")]
		public class References
		{
			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x170000A3")]
			public bool isFilled
			{
				[Token(Token = "0x600073D")]
				[Address(RVA = "0x826D7C", Offset = "0x826D7C", VA = "0x826D7C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A4")]
			public bool isEmpty
			{
				[Token(Token = "0x600073E")]
				[Address(RVA = "0x8269C0", Offset = "0x8269C0", VA = "0x8269C0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x8270E8", Offset = "0x8270E8", VA = "0x8270E8")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x826598", Offset = "0x826598", VA = "0x826598")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x8270E0", Offset = "0x8270E0", VA = "0x8270E0")]
			public References()
			{
			}
		}

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character.")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		public References references;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x826468", Offset = "0x826468", VA = "0x826468", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x8264D0", Offset = "0x8264D0", VA = "0x8264D0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x826538", Offset = "0x826538", VA = "0x826538")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x82657C", Offset = "0x82657C", VA = "0x82657C")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x826924", Offset = "0x826924", VA = "0x826924")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x82694C", Offset = "0x82694C", VA = "0x82694C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x826954", Offset = "0x826954", VA = "0x826954", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x827048", Offset = "0x827048", VA = "0x827048")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000152")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x827524", Offset = "0x827524", VA = "0x827524")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x8275E8", Offset = "0x8275E8", VA = "0x8275E8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x827608", Offset = "0x827608", VA = "0x827608")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x82785C", Offset = "0x82785C", VA = "0x82785C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x8276C8", Offset = "0x8276C8", VA = "0x8276C8")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x827940", Offset = "0x827940", VA = "0x827940")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x8279A0", Offset = "0x8279A0", VA = "0x8279A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x827E3C", Offset = "0x827E3C", VA = "0x827E3C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x827FD0", Offset = "0x827FD0", VA = "0x827FD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x8280DC", Offset = "0x8280DC", VA = "0x8280DC")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000154")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000155")]
		public class BendBone
		{
			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight of rotating this bone.")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x82B234", Offset = "0x82B234", VA = "0x82B234")]
			public BendBone()
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x82B294", Offset = "0x82B294", VA = "0x82B294")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x828944", Offset = "0x828944", VA = "0x828944")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x828D14", Offset = "0x828D14", VA = "0x828D14")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[LargeHeader("Position")]
		[Tooltip("Master weight for positioning the head.")]
		public float positionWeight;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the thighs along with the head")]
		public float thighWeight;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The weight of rotating the head bone after solving")]
		[LargeHeader("Rotation")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Clamping the rotation of the head")]
		[Range(0f, 1f)]
		public float headClampWeight;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[LargeHeader("CCD")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[Range(0f, 1f)]
		public float CCDWeight;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rolling the bones in towards the target")]
		public float roll;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Smoothing the CCD effect.")]
		[Range(0f, 1000f)]
		public float damper;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[LargeHeader("Stretching")]
		[Range(0f, 1f)]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		public float postStretchWeight;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x8280E4", Offset = "0x8280E4", VA = "0x8280E4")]
		private void Start()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x8284D0", Offset = "0x8284D0", VA = "0x8284D0")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x828970", Offset = "0x828970", VA = "0x828970")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x828D3C", Offset = "0x828D3C", VA = "0x828D3C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x829638", Offset = "0x829638", VA = "0x829638")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x829A30", Offset = "0x829A30", VA = "0x829A30")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x829E40", Offset = "0x829E40", VA = "0x829E40")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x82A7B8", Offset = "0x82A7B8", VA = "0x82A7B8")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x82937C", Offset = "0x82937C", VA = "0x82937C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x82A9F4", Offset = "0x82A9F4", VA = "0x82A9F4")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x82A6D8", Offset = "0x82A6D8", VA = "0x82A6D8")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x82A5D8", Offset = "0x82A5D8", VA = "0x82A5D8")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x82AD54", Offset = "0x82AD54", VA = "0x82AD54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x82B08C", Offset = "0x82B08C", VA = "0x82B08C")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000156")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000157")]
		public class ChildConstraint
		{
			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000A5")]
			public float nominalDistance
			{
				[Token(Token = "0x6000771")]
				[Address(RVA = "0x82E240", Offset = "0x82E240", VA = "0x82E240")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000772")]
				[Address(RVA = "0x82E248", Offset = "0x82E248", VA = "0x82E248")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			public bool isRigid
			{
				[Token(Token = "0x6000773")]
				[Address(RVA = "0x82E250", Offset = "0x82E250", VA = "0x82E250")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000774")]
				[Address(RVA = "0x82E258", Offset = "0x82E258", VA = "0x82E258")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x82E264", Offset = "0x82E264", VA = "0x82E264")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x82BF54", Offset = "0x82BF54", VA = "0x82BF54")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x82C5F8", Offset = "0x82C5F8", VA = "0x82C5F8")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x82E004", Offset = "0x82E004", VA = "0x82E004")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000158")]
		public enum Smoothing
		{
			[Token(Token = "0x4000767")]
			None,
			[Token(Token = "0x4000768")]
			Exponential,
			[Token(Token = "0x4000769")]
			Cubic
		}

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x400075B")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x82B310", Offset = "0x82B310", VA = "0x82B310")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x82B478", Offset = "0x82B478", VA = "0x82B478")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x82B5AC", Offset = "0x82B5AC", VA = "0x82B5AC")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x82B6C4", Offset = "0x82B6C4", VA = "0x82B6C4")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x82B780", Offset = "0x82B780", VA = "0x82B780")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x82B88C", Offset = "0x82B88C", VA = "0x82B88C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x82C214", Offset = "0x82C214", VA = "0x82C214")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x82B9F8", Offset = "0x82B9F8", VA = "0x82B9F8")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x82C7DC", Offset = "0x82C7DC", VA = "0x82C7DC")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x82CA70", Offset = "0x82CA70", VA = "0x82CA70")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x82CD40", Offset = "0x82CD40", VA = "0x82CD40")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x82D708", Offset = "0x82D708", VA = "0x82D708")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x82DC00", Offset = "0x82DC00", VA = "0x82DC00")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x82DE00", Offset = "0x82DE00", VA = "0x82DE00")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x82DAEC", Offset = "0x82DAEC", VA = "0x82DAEC")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x82D5A8", Offset = "0x82D5A8", VA = "0x82D5A8")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x82DA88", Offset = "0x82DA88", VA = "0x82DA88")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x82DEDC", Offset = "0x82DEDC", VA = "0x82DEDC")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x82D9B4", Offset = "0x82D9B4", VA = "0x82D9B4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x82DD04", Offset = "0x82DD04", VA = "0x82DD04")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000159")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x170000A7")]
		public bool initiated
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x82E47C", Offset = "0x82E47C", VA = "0x82E47C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x82E484", Offset = "0x82E484", VA = "0x82E484")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x82E2A4", Offset = "0x82E2A4", VA = "0x82E2A4")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x82B40C", Offset = "0x82B40C", VA = "0x82B40C")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x82E490", Offset = "0x82E490", VA = "0x82E490")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x82BFA8", Offset = "0x82BFA8", VA = "0x82BFA8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x82BFB4", Offset = "0x82BFB4", VA = "0x82BFB4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x82E664", Offset = "0x82E664", VA = "0x82E664")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x82E9B0", Offset = "0x82E9B0", VA = "0x82E9B0")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x82CF78", Offset = "0x82CF78", VA = "0x82CF78")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x82E51C", Offset = "0x82E51C", VA = "0x82E51C")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x82E5C0", Offset = "0x82E5C0", VA = "0x82E5C0")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200015A")]
	public class IKEffector
	{
		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x170000A8")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0x82ED78", Offset = "0x82ED78", VA = "0x82ED78")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x82ED80", Offset = "0x82ED80", VA = "0x82ED80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x82ACF8", Offset = "0x82ACF8", VA = "0x82ACF8")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x82ED8C", Offset = "0x82ED8C", VA = "0x82ED8C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x82EE10", Offset = "0x82EE10", VA = "0x82EE10")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x82EFB0", Offset = "0x82EFB0", VA = "0x82EFB0")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x82F16C", Offset = "0x82F16C", VA = "0x82F16C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x82F460", Offset = "0x82F460", VA = "0x82F460")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x82F700", Offset = "0x82F700", VA = "0x82F700")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x82F820", Offset = "0x82F820", VA = "0x82F820")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x82F8BC", Offset = "0x82F8BC", VA = "0x82F8BC")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x82FF70", Offset = "0x82FF70", VA = "0x82FF70")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x82FFC8", Offset = "0x82FFC8", VA = "0x82FFC8")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x83019C", Offset = "0x83019C", VA = "0x83019C")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x8303F8", Offset = "0x8303F8", VA = "0x8303F8")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200015B")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x200015C")]
		public class BoneMap
		{
			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000A9")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x600079A")]
				[Address(RVA = "0x830944", Offset = "0x830944", VA = "0x830944")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AA")]
			public bool isNodeBone
			{
				[Token(Token = "0x600079D")]
				[Address(RVA = "0x8309FC", Offset = "0x8309FC", VA = "0x8309FC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AB")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60007B1")]
				[Address(RVA = "0x830DC4", Offset = "0x830DC4", VA = "0x830DC4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x830918", Offset = "0x830918", VA = "0x830918")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x830974", Offset = "0x830974", VA = "0x830974")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x8309B8", Offset = "0x8309B8", VA = "0x8309B8")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x830A0C", Offset = "0x830A0C", VA = "0x830A0C")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x830AE0", Offset = "0x830AE0", VA = "0x830AE0")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x830AE8", Offset = "0x830AE8", VA = "0x830AE8")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x830BB4", Offset = "0x830BB4", VA = "0x830BB4")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x830C20", Offset = "0x830C20", VA = "0x830C20")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x830CB4", Offset = "0x830CB4", VA = "0x830CB4")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x830F2C", Offset = "0x830F2C", VA = "0x830F2C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x830F58", Offset = "0x830F58", VA = "0x830F58")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x830F84", Offset = "0x830F84", VA = "0x830F84")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x830FAC", Offset = "0x830FAC", VA = "0x830FAC")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x831070", Offset = "0x831070", VA = "0x831070")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x831204", Offset = "0x831204", VA = "0x831204")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x831228", Offset = "0x831228", VA = "0x831228")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x831348", Offset = "0x831348", VA = "0x831348")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x8313AC", Offset = "0x8313AC", VA = "0x8313AC")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x83152C", Offset = "0x83152C", VA = "0x83152C")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x8316AC", Offset = "0x8316AC", VA = "0x8316AC")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x831728", Offset = "0x831728", VA = "0x831728")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x8310E8", Offset = "0x8310E8", VA = "0x8310E8")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x831850", Offset = "0x831850", VA = "0x831850")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x8306B4", Offset = "0x8306B4", VA = "0x8306B4", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x8306BC", Offset = "0x8306BC", VA = "0x8306BC", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x8306C0", Offset = "0x8306C0", VA = "0x8306C0")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x8307FC", Offset = "0x8307FC", VA = "0x8307FC")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x830910", Offset = "0x830910", VA = "0x830910")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015D")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x83186C", Offset = "0x83186C", VA = "0x83186C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x831908", Offset = "0x831908", VA = "0x831908")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x83198C", Offset = "0x83198C", VA = "0x83198C")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x831A24", Offset = "0x831A24", VA = "0x831A24")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x831A3C", Offset = "0x831A3C", VA = "0x831A3C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x831A58", Offset = "0x831A58", VA = "0x831A58", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x831AE4", Offset = "0x831AE4", VA = "0x831AE4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x831AFC", Offset = "0x831AFC", VA = "0x831AFC")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015E")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x200015F")]
		public enum BoneMapType
		{
			[Token(Token = "0x40007BF")]
			Parent,
			[Token(Token = "0x40007C0")]
			Bone1,
			[Token(Token = "0x40007C1")]
			Bone2,
			[Token(Token = "0x40007C2")]
			Bone3
		}

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x831B20", Offset = "0x831B20", VA = "0x831B20", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x831B94", Offset = "0x831B94", VA = "0x831B94")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x831C5C", Offset = "0x831C5C", VA = "0x831C5C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x831F14", Offset = "0x831F14", VA = "0x831F14")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x832028", Offset = "0x832028", VA = "0x832028")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x832168", Offset = "0x832168", VA = "0x832168")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x832174", Offset = "0x832174", VA = "0x832174")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x83220C", Offset = "0x83220C", VA = "0x83220C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x8322B4", Offset = "0x8322B4", VA = "0x8322B4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x832510", Offset = "0x832510", VA = "0x832510")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x832570", Offset = "0x832570", VA = "0x832570")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000160")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x8326B8", Offset = "0x8326B8", VA = "0x8326B8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x8329D8", Offset = "0x8329D8", VA = "0x8329D8")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x832B14", Offset = "0x832B14", VA = "0x832B14")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x832C84", Offset = "0x832C84", VA = "0x832C84")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x832C94", Offset = "0x832C94", VA = "0x832C94")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x832CF0", Offset = "0x832CF0", VA = "0x832CF0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x832D68", Offset = "0x832D68", VA = "0x832D68", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x83337C", Offset = "0x83337C", VA = "0x83337C")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x8333B4", Offset = "0x8333B4", VA = "0x8333B4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x833618", Offset = "0x833618", VA = "0x833618")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x833940", Offset = "0x833940", VA = "0x833940")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x833A20", Offset = "0x833A20", VA = "0x833A20")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x833AD4", Offset = "0x833AD4", VA = "0x833AD4")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000161")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000162")]
		public class Point
		{
			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x8343A4", Offset = "0x8343A4", VA = "0x8343A4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x8343E8", Offset = "0x8343E8", VA = "0x8343E8")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x8344C8", Offset = "0x8344C8", VA = "0x8344C8")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x8344F4", Offset = "0x8344F4", VA = "0x8344F4")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x834520", Offset = "0x834520", VA = "0x834520")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x834564", Offset = "0x834564", VA = "0x834564")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x8345A8", Offset = "0x8345A8", VA = "0x8345A8")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000163")]
		public class Bone : Point
		{
			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000AD")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x60007F0")]
				[Address(RVA = "0x834608", Offset = "0x834608", VA = "0x834608")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007F1")]
				[Address(RVA = "0x8346E8", Offset = "0x8346E8", VA = "0x8346E8")]
				set
				{
				}
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x834760", Offset = "0x834760", VA = "0x834760")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x8349CC", Offset = "0x8349CC", VA = "0x8349CC")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x834C88", Offset = "0x834C88", VA = "0x834C88")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x834E7C", Offset = "0x834E7C", VA = "0x834E7C")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x834EA4", Offset = "0x834EA4", VA = "0x834EA4")]
			public Bone()
			{
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x834F10", Offset = "0x834F10", VA = "0x834F10")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x834F88", Offset = "0x834F88", VA = "0x834F88")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000164")]
		public class Node : Point
		{
			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x835010", Offset = "0x835010", VA = "0x835010")]
			public Node()
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x835014", Offset = "0x835014", VA = "0x835014")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x835038", Offset = "0x835038", VA = "0x835038")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000165")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000166")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x170000AC")]
		public bool initiated
		{
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x833FB0", Offset = "0x833FB0", VA = "0x833FB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x833FB8", Offset = "0x833FB8", VA = "0x833FB8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x833D18", Offset = "0x833D18", VA = "0x833D18")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D4")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x833D8C", Offset = "0x833D8C", VA = "0x833D8C")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x833EFC", Offset = "0x833EFC", VA = "0x833EFC")]
		public void Update()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x833F6C", Offset = "0x833F6C", VA = "0x833F6C", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x833F78", Offset = "0x833F78", VA = "0x833F78")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x833F84", Offset = "0x833F84", VA = "0x833F84")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x833F8C", Offset = "0x833F8C", VA = "0x833F8C")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x833FA8", Offset = "0x833FA8", VA = "0x833FA8")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60007DF")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60007E0")]
		public abstract void FixTransforms();

		[Token(Token = "0x60007E1")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60007E2")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60007E3")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x833FC4", Offset = "0x833FC4", VA = "0x833FC4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x833FDC", Offset = "0x833FDC", VA = "0x833FDC")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x834100", Offset = "0x834100", VA = "0x834100")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x834198", Offset = "0x834198", VA = "0x834198")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x83438C", Offset = "0x83438C", VA = "0x83438C")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000167")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x170000AE")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x835408", Offset = "0x835408", VA = "0x835408")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000AF")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x835438", Offset = "0x835438", VA = "0x835438")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B0")]
		protected override int minBones
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x83606C", Offset = "0x83606C", VA = "0x83606C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B1")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x8365AC", Offset = "0x8365AC", VA = "0x8365AC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x8352D0", Offset = "0x8352D0", VA = "0x8352D0")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x835468", Offset = "0x835468", VA = "0x835468", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x8356F4", Offset = "0x8356F4", VA = "0x8356F4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x835FC4", Offset = "0x835FC4", VA = "0x835FC4")]
		private void Solve()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x835C60", Offset = "0x835C60", VA = "0x835C60")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x836074", Offset = "0x836074", VA = "0x836074")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x83660C", Offset = "0x83660C", VA = "0x83660C")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000168")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x836720", Offset = "0x836720", VA = "0x836720")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x836790", Offset = "0x836790", VA = "0x836790", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x836C84", Offset = "0x836C84", VA = "0x836C84", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x837358", Offset = "0x837358", VA = "0x837358")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x8379E8", Offset = "0x8379E8", VA = "0x8379E8")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000169")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x170000B2")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x8389B4", Offset = "0x8389B4", VA = "0x8389B4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x8379EC", Offset = "0x8379EC", VA = "0x8379EC")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x837FCC", Offset = "0x837FCC", VA = "0x837FCC")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x8380FC", Offset = "0x8380FC", VA = "0x8380FC", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x838184", Offset = "0x838184", VA = "0x838184", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x83867C", Offset = "0x83867C", VA = "0x83867C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x8389BC", Offset = "0x8389BC", VA = "0x8389BC")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x837AC4", Offset = "0x837AC4", VA = "0x837AC4")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x8380B4", Offset = "0x8380B4", VA = "0x8380B4")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x83896C", Offset = "0x83896C", VA = "0x83896C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x837E60", Offset = "0x837E60", VA = "0x837E60")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x839068", Offset = "0x839068", VA = "0x839068")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x8390D0", Offset = "0x8390D0", VA = "0x8390D0")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x8391A0", Offset = "0x8391A0", VA = "0x8391A0")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x839268", Offset = "0x839268", VA = "0x839268")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x8383F4", Offset = "0x8383F4", VA = "0x8383F4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x838538", Offset = "0x838538", VA = "0x838538")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x839358", Offset = "0x839358", VA = "0x839358")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x838C58", Offset = "0x838C58", VA = "0x838C58")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x8380A4", Offset = "0x8380A4", VA = "0x8380A4")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x8399C8", Offset = "0x8399C8", VA = "0x8399C8")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x839518", Offset = "0x839518", VA = "0x839518")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x838AD8", Offset = "0x838AD8", VA = "0x838AD8")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x838BA8", Offset = "0x838BA8", VA = "0x838BA8")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x839A80", Offset = "0x839A80", VA = "0x839A80")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016A")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x839B00", Offset = "0x839B00", VA = "0x839B00", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x83A154", Offset = "0x83A154", VA = "0x83A154", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x83A1E0", Offset = "0x83A1E0", VA = "0x83A1E0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x83A274", Offset = "0x83A274", VA = "0x83A274", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x83A35C", Offset = "0x83A35C", VA = "0x83A35C")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x83A3EC", Offset = "0x83A3EC", VA = "0x83A3EC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x83A7EC", Offset = "0x83A7EC", VA = "0x83A7EC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x83A9C4", Offset = "0x83A9C4", VA = "0x83A9C4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x83A88C", Offset = "0x83A88C", VA = "0x83A88C")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x83A5C4", Offset = "0x83A5C4", VA = "0x83A5C4")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x83AA48", Offset = "0x83AA48", VA = "0x83AA48")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016B")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x83AAB8", Offset = "0x83AAB8", VA = "0x83AAB8")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x83AB94", Offset = "0x83AB94", VA = "0x83AB94")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x83ABDC", Offset = "0x83ABDC", VA = "0x83ABDC")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x83ACF0", Offset = "0x83ACF0", VA = "0x83ACF0")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x83AD40", Offset = "0x83AD40", VA = "0x83AD40")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x83ADB4", Offset = "0x83ADB4", VA = "0x83ADB4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x83AF2C", Offset = "0x83AF2C", VA = "0x83AF2C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x83B088", Offset = "0x83B088", VA = "0x83B088", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x83B288", Offset = "0x83B288", VA = "0x83B288", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x83B35C", Offset = "0x83B35C", VA = "0x83B35C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x83B444", Offset = "0x83B444", VA = "0x83B444", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x83B5A4", Offset = "0x83B5A4", VA = "0x83B5A4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x83B740", Offset = "0x83B740", VA = "0x83B740", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x83B978", Offset = "0x83B978", VA = "0x83B978", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x83BC58", Offset = "0x83BC58", VA = "0x83BC58", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x83BC90", Offset = "0x83BC90", VA = "0x83BC90", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x83BD74", Offset = "0x83BD74", VA = "0x83BD74")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016C")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000810")]
		Body,
		[Token(Token = "0x4000811")]
		LeftShoulder,
		[Token(Token = "0x4000812")]
		RightShoulder,
		[Token(Token = "0x4000813")]
		LeftThigh,
		[Token(Token = "0x4000814")]
		RightThigh,
		[Token(Token = "0x4000815")]
		LeftHand,
		[Token(Token = "0x4000816")]
		RightHand,
		[Token(Token = "0x4000817")]
		LeftFoot,
		[Token(Token = "0x4000818")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200016D")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x400081A")]
		LeftArm,
		[Token(Token = "0x400081B")]
		RightArm,
		[Token(Token = "0x400081C")]
		LeftLeg,
		[Token(Token = "0x400081D")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200016E")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x170000B3")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x83BE90", Offset = "0x83BE90", VA = "0x83BE90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x83BFD0", Offset = "0x83BFD0", VA = "0x83BFD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x83BFD8", Offset = "0x83BFD8", VA = "0x83BFD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x83BFE0", Offset = "0x83BFE0", VA = "0x83BFE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x83BFE8", Offset = "0x83BFE8", VA = "0x83BFE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x83BFF0", Offset = "0x83BFF0", VA = "0x83BFF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x83BFF8", Offset = "0x83BFF8", VA = "0x83BFF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x83C000", Offset = "0x83C000", VA = "0x83C000")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x83C008", Offset = "0x83C008", VA = "0x83C008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x83C010", Offset = "0x83C010", VA = "0x83C010")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000853")]
			[Address(RVA = "0x83C03C", Offset = "0x83C03C", VA = "0x83C03C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0x83C068", Offset = "0x83C068", VA = "0x83C068")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000855")]
			[Address(RVA = "0x83C094", Offset = "0x83C094", VA = "0x83C094")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0x83C0C0", Offset = "0x83C0C0", VA = "0x83C0C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x83C0E8", Offset = "0x83C0E8", VA = "0x83C0E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x83C114", Offset = "0x83C114", VA = "0x83C114")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0x83C140", Offset = "0x83C140", VA = "0x83C140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x83C16C", Offset = "0x83C16C", VA = "0x83C16C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x83DF58", Offset = "0x83DF58", VA = "0x83DF58")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600086B")]
			[Address(RVA = "0x83DF64", Offset = "0x83DF64", VA = "0x83DF64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x83C194", Offset = "0x83C194", VA = "0x83C194")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x83C294", Offset = "0x83C294", VA = "0x83C294")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x83C1E4", Offset = "0x83C1E4", VA = "0x83C1E4")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x83C30C", Offset = "0x83C30C", VA = "0x83C30C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x83BE98", Offset = "0x83BE98", VA = "0x83BE98")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x83C3D4", Offset = "0x83C3D4", VA = "0x83C3D4")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x83C484", Offset = "0x83C484", VA = "0x83C484")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x83C530", Offset = "0x83C530", VA = "0x83C530")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x83C5DC", Offset = "0x83C5DC", VA = "0x83C5DC")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x83C5E4", Offset = "0x83C5E4", VA = "0x83C5E4")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x83C60C", Offset = "0x83C60C", VA = "0x83C60C")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x83C6CC", Offset = "0x83C6CC", VA = "0x83C6CC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x83C85C", Offset = "0x83C85C", VA = "0x83C85C")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x83D850", Offset = "0x83D850", VA = "0x83D850")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x83DE00", Offset = "0x83DE00", VA = "0x83DE00")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x83DE5C", Offset = "0x83DE5C", VA = "0x83DE5C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x83DCA0", Offset = "0x83DCA0", VA = "0x83DCA0")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x83DD50", Offset = "0x83DD50", VA = "0x83DD50")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x83DF70", Offset = "0x83DF70", VA = "0x83DF70")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x83E034", Offset = "0x83E034", VA = "0x83E034", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x83E104", Offset = "0x83E104", VA = "0x83E104")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x83E220", Offset = "0x83E220", VA = "0x83E220")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x83E3B0", Offset = "0x83E3B0", VA = "0x83E3B0")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x83E528", Offset = "0x83E528", VA = "0x83E528", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x83E788", Offset = "0x83E788", VA = "0x83E788", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x83E800", Offset = "0x83E800", VA = "0x83E800")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016F")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x170000C6")]
		protected virtual int minBones
		{
			[Token(Token = "0x600087E")]
			[Address(RVA = "0x83F028", Offset = "0x83F028", VA = "0x83F028", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C7")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x83F030", Offset = "0x83F030", VA = "0x83F030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C8")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000880")]
			[Address(RVA = "0x83F038", Offset = "0x83F038", VA = "0x83F038", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C9")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x83F048", Offset = "0x83F048", VA = "0x83F048", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000CA")]
		protected float positionOffset
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x837310", Offset = "0x837310", VA = "0x837310")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x83E80C", Offset = "0x83E80C", VA = "0x83E80C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x83E988", Offset = "0x83E988", VA = "0x83E988")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x83EAB4", Offset = "0x83EAB4", VA = "0x83EAB4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x83EB10", Offset = "0x83EB10", VA = "0x83EB10", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x83EB80", Offset = "0x83EB80", VA = "0x83EB80", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x83EF44", Offset = "0x83EF44", VA = "0x83EF44", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x83EF4C", Offset = "0x83EF4C", VA = "0x83EF4C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x83F040", Offset = "0x83F040", VA = "0x83F040", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x83F044", Offset = "0x83F044", VA = "0x83F044", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x8367FC", Offset = "0x8367FC", VA = "0x8367FC")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x836F64", Offset = "0x836F64", VA = "0x836F64")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x83F104", Offset = "0x83F104", VA = "0x83F104")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x8366AC", Offset = "0x8366AC", VA = "0x8366AC")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000170")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x83F398", Offset = "0x83F398", VA = "0x83F398", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x83F6F4", Offset = "0x83F6F4", VA = "0x83F6F4")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x83F754", Offset = "0x83F754", VA = "0x83F754", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x83F898", Offset = "0x83F898", VA = "0x83F898", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x83F9F8", Offset = "0x83F9F8", VA = "0x83F9F8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x83FA38", Offset = "0x83FA38", VA = "0x83FA38", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x83FA88", Offset = "0x83FA88", VA = "0x83FA88", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x83FDE0", Offset = "0x83FDE0", VA = "0x83FDE0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x83FE00", Offset = "0x83FE00", VA = "0x83FE00")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x83FAE0", Offset = "0x83FAE0", VA = "0x83FAE0")]
		private void Read()
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x83FE84", Offset = "0x83FE84", VA = "0x83FE84")]
		private void Write()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x83FF90", Offset = "0x83FF90", VA = "0x83FF90")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000171")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000172")]
		public enum BendModifier
		{
			[Token(Token = "0x4000848")]
			Animation,
			[Token(Token = "0x4000849")]
			Target,
			[Token(Token = "0x400084A")]
			Parent,
			[Token(Token = "0x400084B")]
			Arm,
			[Token(Token = "0x400084C")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000173")]
		public struct AxisDirection
		{
			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x84150C", Offset = "0x84150C", VA = "0x84150C")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x170000CB")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x8414F0", Offset = "0x8414F0", VA = "0x8414F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x840124", Offset = "0x840124", VA = "0x840124")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x840168", Offset = "0x840168", VA = "0x840168")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x8401D4", Offset = "0x8401D4", VA = "0x8401D4", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x840714", Offset = "0x840714", VA = "0x840714", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x841234", Offset = "0x841234", VA = "0x841234", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x8412DC", Offset = "0x8412DC", VA = "0x8412DC")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x841470", Offset = "0x841470", VA = "0x841470")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x840528", Offset = "0x840528", VA = "0x840528")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x8407D0", Offset = "0x8407D0", VA = "0x8407D0")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000174")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000175")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170000D2")]
			public Vector3 forward
			{
				[Token(Token = "0x60008BE")]
				[Address(RVA = "0x843044", Offset = "0x843044", VA = "0x843044")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x8436A8", Offset = "0x8436A8", VA = "0x8436A8")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x8423F0", Offset = "0x8423F0", VA = "0x8423F0")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x84269C", Offset = "0x84269C", VA = "0x84269C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x84338C", Offset = "0x84338C", VA = "0x84338C")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x170000CC")]
		private bool spineIsValid
		{
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x841C0C", Offset = "0x841C0C", VA = "0x841C0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CD")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x841DB4", Offset = "0x841DB4", VA = "0x841DB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		private bool headIsValid
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x841CD8", Offset = "0x841CD8", VA = "0x841CD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		private bool headIsEmpty
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x841DD8", Offset = "0x841DD8", VA = "0x841DD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D0")]
		private bool eyesIsValid
		{
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x841CE8", Offset = "0x841CE8", VA = "0x841CE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D1")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x841E44", Offset = "0x841E44", VA = "0x841E44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x8416A8", Offset = "0x8416A8", VA = "0x8416A8")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x8416C4", Offset = "0x8416C4", VA = "0x8416C4")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x8416F0", Offset = "0x8416F0", VA = "0x8416F0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x841728", Offset = "0x841728", VA = "0x841728")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x841770", Offset = "0x841770", VA = "0x841770")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x8417C8", Offset = "0x8417C8", VA = "0x8417C8")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x841838", Offset = "0x841838", VA = "0x841838", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x841944", Offset = "0x841944", VA = "0x841944", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x841A64", Offset = "0x841A64", VA = "0x841A64", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x841E68", Offset = "0x841E68", VA = "0x841E68", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x842080", Offset = "0x842080", VA = "0x842080", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x8421E0", Offset = "0x8421E0", VA = "0x8421E0")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x842414", Offset = "0x842414", VA = "0x842414", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x842788", Offset = "0x842788", VA = "0x842788", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x84284C", Offset = "0x84284C", VA = "0x84284C")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x842A68", Offset = "0x842A68", VA = "0x842A68")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x842DB0", Offset = "0x842DB0", VA = "0x842DB0")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x843074", Offset = "0x843074", VA = "0x843074")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x842288", Offset = "0x842288", VA = "0x842288")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x843494", Offset = "0x843494", VA = "0x843494")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000176")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000177")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x84492C", Offset = "0x84492C", VA = "0x84492C")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x8451CC", Offset = "0x8451CC", VA = "0x8451CC")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x8401A4", Offset = "0x8401A4", VA = "0x8401A4")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x845268", Offset = "0x845268", VA = "0x845268")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x8436AC", Offset = "0x8436AC", VA = "0x8436AC")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x843840", Offset = "0x843840", VA = "0x843840")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x8439C0", Offset = "0x8439C0", VA = "0x8439C0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x8439CC", Offset = "0x8439CC", VA = "0x8439CC")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x8439E8", Offset = "0x8439E8", VA = "0x8439E8")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x8439F4", Offset = "0x8439F4", VA = "0x8439F4")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x8439FC", Offset = "0x8439FC", VA = "0x8439FC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x843AE8", Offset = "0x843AE8", VA = "0x843AE8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x843BE0", Offset = "0x843BE0", VA = "0x843BE0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x843C14", Offset = "0x843C14", VA = "0x843C14", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x843C58", Offset = "0x843C58", VA = "0x843C58", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x843FFC", Offset = "0x843FFC", VA = "0x843FFC")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x844044", Offset = "0x844044", VA = "0x844044")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x844538", Offset = "0x844538", VA = "0x844538")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x844690", Offset = "0x844690", VA = "0x844690", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x84483C", Offset = "0x84483C", VA = "0x84483C")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x8447BC", Offset = "0x8447BC", VA = "0x8447BC")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x844A1C", Offset = "0x844A1C", VA = "0x844A1C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x84525C", Offset = "0x84525C", VA = "0x84525C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x845260", Offset = "0x845260", VA = "0x845260", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x845264", Offset = "0x845264", VA = "0x845264", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x845018", Offset = "0x845018", VA = "0x845018")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x841348", Offset = "0x841348", VA = "0x841348")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000178")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000179")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x200017A")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40008A8")]
				YawPitch,
				[Token(Token = "0x40008A9")]
				FromTo
			}

			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target")]
			public Transform target;

			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the hand target.")]
			public float positionWeight;

			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the hand target")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the elbow bending direction.")]
			public float swivelOffset;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the arm shorter/longer.")]
			public float armLengthMlp;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length).")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40008A5")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x40008A6")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000D4")]
			public Vector3 position
			{
				[Token(Token = "0x60008F8")]
				[Address(RVA = "0x84CCCC", Offset = "0x84CCCC", VA = "0x84CCCC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008F9")]
				[Address(RVA = "0x84CCD8", Offset = "0x84CCD8", VA = "0x84CCD8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000D5")]
			public Quaternion rotation
			{
				[Token(Token = "0x60008FA")]
				[Address(RVA = "0x84CCE4", Offset = "0x84CCE4", VA = "0x84CCE4")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60008FB")]
				[Address(RVA = "0x84CCF0", Offset = "0x84CCF0", VA = "0x84CCF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000D6")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60008FC")]
				[Address(RVA = "0x84CCFC", Offset = "0x84CCFC", VA = "0x84CCFC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60008FD")]
				[Address(RVA = "0x84CD24", Offset = "0x84CD24", VA = "0x84CD24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60008FE")]
				[Address(RVA = "0x84CD50", Offset = "0x84CD50", VA = "0x84CD50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private VirtualBone hand
			{
				[Token(Token = "0x60008FF")]
				[Address(RVA = "0x84CD7C", Offset = "0x84CD7C", VA = "0x84CD7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000900")]
			[Address(RVA = "0x84CDA8", Offset = "0x84CDA8", VA = "0x84CDA8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x84D4D4", Offset = "0x84D4D4", VA = "0x84D4D4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x84D780", Offset = "0x84D780", VA = "0x84D780", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x84D7A4", Offset = "0x84D7A4", VA = "0x84D7A4")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0x84AC90", Offset = "0x84AC90", VA = "0x84AC90")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000905")]
			[Address(RVA = "0x84E740", Offset = "0x84E740", VA = "0x84E740", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000906")]
			[Address(RVA = "0x84E798", Offset = "0x84E798", VA = "0x84E798", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000907")]
			[Address(RVA = "0x84DAF4", Offset = "0x84DAF4", VA = "0x84DAF4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x84DCFC", Offset = "0x84DCFC", VA = "0x84DCFC")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0x84E9A4", Offset = "0x84E9A4", VA = "0x84E9A4")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600090A")]
			[Address(RVA = "0x84CA20", Offset = "0x84CA20", VA = "0x84CA20")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200017B")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x170000DA")]
			public float sqrMag
			{
				[Token(Token = "0x6000910")]
				[Address(RVA = "0x84EB54", Offset = "0x84EB54", VA = "0x84EB54")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000911")]
				[Address(RVA = "0x84EB5C", Offset = "0x84EB5C", VA = "0x84EB5C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000DB")]
			public float mag
			{
				[Token(Token = "0x6000912")]
				[Address(RVA = "0x84EB64", Offset = "0x84EB64", VA = "0x84EB64")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000913")]
				[Address(RVA = "0x84EB6C", Offset = "0x84EB6C", VA = "0x84EB6C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600090B")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x600090C")]
			public abstract void PreSolve();

			[Token(Token = "0x600090D")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600090E")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x600090F")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x848B7C", Offset = "0x848B7C", VA = "0x848B7C")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x84ECD4", Offset = "0x84ECD4", VA = "0x84ECD4")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x84ED5C", Offset = "0x84ED5C", VA = "0x84ED5C")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000917")]
			[Address(RVA = "0x84EF60", Offset = "0x84EF60", VA = "0x84EF60")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0x84A824", Offset = "0x84A824", VA = "0x84A824")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000919")]
			[Address(RVA = "0x84E5DC", Offset = "0x84E5DC", VA = "0x84E5DC")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0x84EFA8", Offset = "0x84EFA8", VA = "0x84EFA8")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x84F0CC", Offset = "0x84F0CC", VA = "0x84F0CC")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0x84EABC", Offset = "0x84EABC", VA = "0x84EABC")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200017C")]
		public class Footstep
		{
			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40008B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40008BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40008BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40008BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40008BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000DC")]
			public bool isStepping
			{
				[Token(Token = "0x600091D")]
				[Address(RVA = "0x84F0E0", Offset = "0x84F0E0", VA = "0x84F0E0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DD")]
			public float stepProgress
			{
				[Token(Token = "0x600091E")]
				[Address(RVA = "0x84F0F4", Offset = "0x84F0F4", VA = "0x84F0F4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600091F")]
				[Address(RVA = "0x84F0FC", Offset = "0x84F0FC", VA = "0x84F0FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0x84F104", Offset = "0x84F104", VA = "0x84F104")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000921")]
			[Address(RVA = "0x84F204", Offset = "0x84F204", VA = "0x84F204")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0x84F2E0", Offset = "0x84F2E0", VA = "0x84F2E0")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0x84F390", Offset = "0x84F390", VA = "0x84F390")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0x84F598", Offset = "0x84F598", VA = "0x84F598")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000925")]
			[Address(RVA = "0x84F77C", Offset = "0x84F77C", VA = "0x84F77C")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200017D")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40008BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The toe/foot target.")]
			public Transform target;

			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x40008C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the toe/foot target.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x40008C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the toe/foot target.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Angular offset of the knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[NonSerialized]
			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 footPosition;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion footRotation;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 bendNormal;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x170000DE")]
			public Vector3 position
			{
				[Token(Token = "0x6000926")]
				[Address(RVA = "0x84F8F0", Offset = "0x84F8F0", VA = "0x84F8F0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000927")]
				[Address(RVA = "0x84F8FC", Offset = "0x84F8FC", VA = "0x84F8FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000DF")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000928")]
				[Address(RVA = "0x84F908", Offset = "0x84F908", VA = "0x84F908")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000929")]
				[Address(RVA = "0x84F914", Offset = "0x84F914", VA = "0x84F914")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E0")]
			public bool hasToes
			{
				[Token(Token = "0x600092A")]
				[Address(RVA = "0x84F920", Offset = "0x84F920", VA = "0x84F920")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600092B")]
				[Address(RVA = "0x84F928", Offset = "0x84F928", VA = "0x84F928")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E1")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600092C")]
				[Address(RVA = "0x84F934", Offset = "0x84F934", VA = "0x84F934")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E2")]
			private VirtualBone calf
			{
				[Token(Token = "0x600092D")]
				[Address(RVA = "0x84F95C", Offset = "0x84F95C", VA = "0x84F95C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E3")]
			private VirtualBone foot
			{
				[Token(Token = "0x600092E")]
				[Address(RVA = "0x84F988", Offset = "0x84F988", VA = "0x84F988")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private VirtualBone toes
			{
				[Token(Token = "0x600092F")]
				[Address(RVA = "0x84F9B4", Offset = "0x84F9B4", VA = "0x84F9B4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E5")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000930")]
				[Address(RVA = "0x84A700", Offset = "0x84A700", VA = "0x84A700")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E6")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000931")]
				[Address(RVA = "0x84F9E0", Offset = "0x84F9E0", VA = "0x84F9E0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000932")]
				[Address(RVA = "0x84F9EC", Offset = "0x84F9EC", VA = "0x84F9EC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0x84F9F8", Offset = "0x84F9F8", VA = "0x84F9F8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0x84FE8C", Offset = "0x84FE8C", VA = "0x84FE8C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0x850460", Offset = "0x850460", VA = "0x850460", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0x850410", Offset = "0x850410", VA = "0x850410")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0x8501D4", Offset = "0x8501D4", VA = "0x8501D4")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000938")]
			[Address(RVA = "0x84A948", Offset = "0x84A948", VA = "0x84A948")]
			public void Solve()
			{
			}

			[Token(Token = "0x6000939")]
			[Address(RVA = "0x85092C", Offset = "0x85092C", VA = "0x85092C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600093A")]
			[Address(RVA = "0x850A28", Offset = "0x850A28", VA = "0x850A28", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600093B")]
			[Address(RVA = "0x84CB64", Offset = "0x84CB64", VA = "0x84CB64")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200017E")]
		public class Locomotion
		{
			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(0f, 1f)]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			public float weight;

			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			[Range(0.9f, 1f)]
			public float maxLegStretch;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The speed of steps.")]
			public float stepSpeed;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[Range(0f, 180f)]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000E7")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600093C")]
				[Address(RVA = "0x850B08", Offset = "0x850B08", VA = "0x850B08")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600093D")]
				[Address(RVA = "0x850B14", Offset = "0x850B14", VA = "0x850B14")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E8")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000943")]
				[Address(RVA = "0x850F24", Offset = "0x850F24", VA = "0x850F24")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E9")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000944")]
				[Address(RVA = "0x850F58", Offset = "0x850F58", VA = "0x850F58")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EA")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000945")]
				[Address(RVA = "0x850F90", Offset = "0x850F90", VA = "0x850F90")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000EB")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000946")]
				[Address(RVA = "0x850FC4", Offset = "0x850FC4", VA = "0x850FC4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x848C2C", Offset = "0x848C2C", VA = "0x848C2C")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x846D98", Offset = "0x846D98", VA = "0x846D98")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0x8462A8", Offset = "0x8462A8", VA = "0x8462A8")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0x8461F0", Offset = "0x8461F0", VA = "0x8461F0")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0x8493E8", Offset = "0x8493E8", VA = "0x8493E8")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000947")]
			[Address(RVA = "0x850B54", Offset = "0x850B54", VA = "0x850B54")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000948")]
			[Address(RVA = "0x850D08", Offset = "0x850D08", VA = "0x850D08")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000949")]
			[Address(RVA = "0x850D74", Offset = "0x850D74", VA = "0x850D74")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600094A")]
			[Address(RVA = "0x84CBE0", Offset = "0x84CBE0", VA = "0x84CBE0")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200017F")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The head target.")]
			public Transform headTarget;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The pelvis target, useful with seated rigs.")]
			public Transform pelvisTarget;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the head target.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the head target.")]
			public float rotationWeight;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Positional weight of the pelvis target.")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the pelvis target.")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Rotational weight of the chest target.")]
			[Range(0f, 1f)]
			public float chestGoalWeight;

			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[Range(0f, 1f)]
			[FormerlySerializedAs("chestRotationWeight")]
			public float neckStiffness;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Range(0f, 1f)]
			[Tooltip("Clamps chest rotation.")]
			public float chestClampWeight;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Range(0f, 1f)]
			[Tooltip("Clamps head rotation.")]
			public float headClampWeight;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			[Range(0f, 1f)]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0f, 180f)]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400090A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private int pelvisIndex;

			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int spineIndex;

			[Token(Token = "0x4000919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int chestIndex;

			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private int neckIndex;

			[Token(Token = "0x400091B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private int headIndex;

			[Token(Token = "0x400091C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private float length;

			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			private bool hasChest;

			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1ED")]
			private bool hasNeck;

			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private float headHeight;

			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private float sizeMlp;

			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private Vector3 chestForward;

			[Token(Token = "0x170000EC")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x600094B")]
				[Address(RVA = "0x846F7C", Offset = "0x846F7C", VA = "0x846F7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000ED")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600094C")]
				[Address(RVA = "0x850FFC", Offset = "0x850FFC", VA = "0x850FFC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EE")]
			public VirtualBone chest
			{
				[Token(Token = "0x600094D")]
				[Address(RVA = "0x84AC48", Offset = "0x84AC48", VA = "0x84AC48")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EF")]
			private VirtualBone neck
			{
				[Token(Token = "0x600094E")]
				[Address(RVA = "0x851030", Offset = "0x851030", VA = "0x851030")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			public VirtualBone head
			{
				[Token(Token = "0x600094F")]
				[Address(RVA = "0x850B20", Offset = "0x850B20", VA = "0x850B20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F1")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000950")]
				[Address(RVA = "0x851064", Offset = "0x851064", VA = "0x851064")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000951")]
				[Address(RVA = "0x851078", Offset = "0x851078", VA = "0x851078")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0x85108C", Offset = "0x85108C", VA = "0x85108C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0x851C70", Offset = "0x851C70", VA = "0x851C70", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000954")]
			[Address(RVA = "0x851E1C", Offset = "0x851E1C", VA = "0x851E1C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0x85241C", Offset = "0x85241C", VA = "0x85241C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0x848F20", Offset = "0x848F20", VA = "0x848F20")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000957")]
			[Address(RVA = "0x852E48", Offset = "0x852E48", VA = "0x852E48")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000958")]
			[Address(RVA = "0x853450", Offset = "0x853450", VA = "0x853450")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0x853A54", Offset = "0x853A54", VA = "0x853A54", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600095A")]
			[Address(RVA = "0x853C24", Offset = "0x853C24", VA = "0x853C24", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600095B")]
			[Address(RVA = "0x852660", Offset = "0x852660", VA = "0x852660")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600095C")]
			[Address(RVA = "0x84A734", Offset = "0x84A734", VA = "0x84A734")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x600095D")]
			[Address(RVA = "0x852A50", Offset = "0x852A50", VA = "0x852A50")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x600095E")]
			[Address(RVA = "0x853CF4", Offset = "0x853CF4", VA = "0x853CF4")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600095F")]
			[Address(RVA = "0x853254", Offset = "0x853254", VA = "0x853254")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000960")]
			[Address(RVA = "0x85303C", Offset = "0x85303C", VA = "0x85303C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000961")]
			[Address(RVA = "0x84C914", Offset = "0x84C914", VA = "0x84C914")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000180")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000923")]
			Pelvis,
			[Token(Token = "0x4000924")]
			Chest,
			[Token(Token = "0x4000925")]
			Head,
			[Token(Token = "0x4000926")]
			LeftHand,
			[Token(Token = "0x4000927")]
			RightHand,
			[Token(Token = "0x4000928")]
			LeftFoot,
			[Token(Token = "0x4000929")]
			RightFoot,
			[Token(Token = "0x400092A")]
			LeftHeel,
			[Token(Token = "0x400092B")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000181")]
		public enum RotationOffset
		{
			[Token(Token = "0x400092D")]
			Pelvis,
			[Token(Token = "0x400092E")]
			Chest,
			[Token(Token = "0x400092F")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000182")]
		public class VirtualBone
		{
			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000962")]
			[Address(RVA = "0x848AEC", Offset = "0x848AEC", VA = "0x848AEC")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0x848B5C", Offset = "0x848B5C", VA = "0x848B5C")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000964")]
			[Address(RVA = "0x853F94", Offset = "0x853F94", VA = "0x853F94")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000965")]
			[Address(RVA = "0x84EB74", Offset = "0x84EB74", VA = "0x84EB74")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000966")]
			[Address(RVA = "0x84EDF0", Offset = "0x84EDF0", VA = "0x84EDF0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000967")]
			[Address(RVA = "0x854194", Offset = "0x854194", VA = "0x854194")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000968")]
			[Address(RVA = "0x84DB74", Offset = "0x84DB74", VA = "0x84DB74")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0x85433C", Offset = "0x85433C", VA = "0x85433C")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600096A")]
			[Address(RVA = "0x84E1F8", Offset = "0x84E1F8", VA = "0x84E1F8")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x600096B")]
			[Address(RVA = "0x8543E0", Offset = "0x8543E0", VA = "0x8543E0")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600096C")]
			[Address(RVA = "0x8536F8", Offset = "0x8536F8", VA = "0x8536F8")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0x854538", Offset = "0x854538", VA = "0x854538")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600096E")]
			[Address(RVA = "0x85464C", Offset = "0x85464C", VA = "0x85464C")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach.")]
		public bool plantFeet;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The procedural locomotion solver.")]
		public Locomotion locomotion;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x170000D3")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x84C6E0", Offset = "0x84C6E0", VA = "0x84C6E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x84C6E8", Offset = "0x84C6E8", VA = "0x84C6E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x84526C", Offset = "0x84526C", VA = "0x84526C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x84564C", Offset = "0x84564C", VA = "0x84564C")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x845500", Offset = "0x845500", VA = "0x845500")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x845E74", Offset = "0x845E74", VA = "0x845E74")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x845FB8", Offset = "0x845FB8", VA = "0x845FB8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x845FF8", Offset = "0x845FF8", VA = "0x845FF8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x84611C", Offset = "0x84611C", VA = "0x84611C")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x846670", Offset = "0x846670", VA = "0x846670")]
		public void Reset()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x846FB0", Offset = "0x846FB0", VA = "0x846FB0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x847104", Offset = "0x847104", VA = "0x847104", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x84727C", Offset = "0x84727C", VA = "0x84727C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x8472EC", Offset = "0x8472EC", VA = "0x8472EC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x84735C", Offset = "0x84735C", VA = "0x84735C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x847558", Offset = "0x847558", VA = "0x847558")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x845934", Offset = "0x845934", VA = "0x845934")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x845A18", Offset = "0x845A18", VA = "0x845A18")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x845D60", Offset = "0x845D60", VA = "0x845D60")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x846768", Offset = "0x846768", VA = "0x846768")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x8477C8", Offset = "0x8477C8", VA = "0x8477C8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x8477F4", Offset = "0x8477F4", VA = "0x8477F4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x8488B4", Offset = "0x8488B4", VA = "0x8488B4")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x8468B8", Offset = "0x8468B8", VA = "0x8468B8")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x84784C", Offset = "0x84784C", VA = "0x84784C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x848A78", Offset = "0x848A78", VA = "0x848A78")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x848AB4", Offset = "0x848AB4", VA = "0x848AB4")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x848780", Offset = "0x848780", VA = "0x848780")]
		private void Write()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x84C014", Offset = "0x84C014", VA = "0x84C014")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x84C6F0", Offset = "0x84C6F0", VA = "0x84C6F0")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000183")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		public float weight;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(-180f, 180f)]
		[Tooltip("Rotation offset around the twist axis.")]
		public float twistAngleOffset;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 twistAxis;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 axis;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform parent;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform child;

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x854800", Offset = "0x854800", VA = "0x854800")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x854C44", Offset = "0x854C44", VA = "0x854C44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x854F94", Offset = "0x854F94", VA = "0x854F94")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x85500C", Offset = "0x85500C", VA = "0x85500C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x855084", Offset = "0x855084", VA = "0x855084")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x85519C", Offset = "0x85519C", VA = "0x85519C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000184")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x170000F2")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x85523C", Offset = "0x85523C", VA = "0x85523C")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x855244", Offset = "0x855244", VA = "0x855244")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public bool isPaused
		{
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x85524C", Offset = "0x85524C", VA = "0x85524C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000978")]
			[Address(RVA = "0x855254", Offset = "0x855254", VA = "0x855254")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000979")]
			[Address(RVA = "0x855260", Offset = "0x855260", VA = "0x855260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600097A")]
			[Address(RVA = "0x855268", Offset = "0x855268", VA = "0x855268")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public bool inInteraction
		{
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x855270", Offset = "0x855270", VA = "0x855270")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F6")]
		public float progress
		{
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x856A64", Offset = "0x856A64", VA = "0x856A64")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x8552D0", Offset = "0x8552D0", VA = "0x8552D0")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x855360", Offset = "0x855360", VA = "0x855360")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x8553F4", Offset = "0x8553F4", VA = "0x8553F4")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x855528", Offset = "0x855528", VA = "0x855528")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x85586C", Offset = "0x85586C", VA = "0x85586C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x85598C", Offset = "0x85598C", VA = "0x85598C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x8559E0", Offset = "0x8559E0", VA = "0x8559E0")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x855E80", Offset = "0x855E80", VA = "0x855E80")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x8564D0", Offset = "0x8564D0", VA = "0x8564D0")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x8566F4", Offset = "0x8566F4", VA = "0x8566F4")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x856918", Offset = "0x856918", VA = "0x856918")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x856A94", Offset = "0x856A94", VA = "0x856A94")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000185")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x856CD8", Offset = "0x856CD8", VA = "0x856CD8")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x856DE8", Offset = "0x856DE8", VA = "0x856DE8")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x856E80", Offset = "0x856E80", VA = "0x856E80")]
		public void Update()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x857070", Offset = "0x857070", VA = "0x857070")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x857118", Offset = "0x857118", VA = "0x857118")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x8571C4", Offset = "0x8571C4", VA = "0x8571C4")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000186")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000187")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x85877C", Offset = "0x85877C", VA = "0x85877C")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x858A14", Offset = "0x858A14", VA = "0x858A14")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000188")]
		public class Message
		{
			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x400097C")]
			private const string empty = "";

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x85891C", Offset = "0x85891C", VA = "0x85891C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x858A1C", Offset = "0x858A1C", VA = "0x858A1C")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000189")]
		public class AnimatorEvent
		{
			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000983")]
			private const string empty = "";

			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x858840", Offset = "0x858840", VA = "0x858840")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x858A24", Offset = "0x858A24", VA = "0x858A24")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x858AD4", Offset = "0x858AD4", VA = "0x858AD4")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x858BAC", Offset = "0x858BAC", VA = "0x858BAC")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018A")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x200018B")]
			public enum Type
			{
				[Token(Token = "0x4000987")]
				PositionWeight,
				[Token(Token = "0x4000988")]
				RotationWeight,
				[Token(Token = "0x4000989")]
				PositionOffsetX,
				[Token(Token = "0x400098A")]
				PositionOffsetY,
				[Token(Token = "0x400098B")]
				PositionOffsetZ,
				[Token(Token = "0x400098C")]
				Pull,
				[Token(Token = "0x400098D")]
				Reach,
				[Token(Token = "0x400098E")]
				RotateBoneWeight,
				[Token(Token = "0x400098F")]
				Push,
				[Token(Token = "0x4000990")]
				PushParent,
				[Token(Token = "0x4000991")]
				PoserWeight
			}

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x857E68", Offset = "0x857E68", VA = "0x857E68")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x858BC0", Offset = "0x858BC0", VA = "0x858BC0")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018C")]
		public class Multiplier
		{
			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x858400", Offset = "0x858400", VA = "0x858400")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x858BC8", Offset = "0x858BC8", VA = "0x858BC8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000F7")]
		public float length
		{
			[Token(Token = "0x6000995")]
			[Address(RVA = "0x857370", Offset = "0x857370", VA = "0x857370")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x857378", Offset = "0x857378", VA = "0x857378")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x857380", Offset = "0x857380", VA = "0x857380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x857388", Offset = "0x857388", VA = "0x857388")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x8575C0", Offset = "0x8575C0", VA = "0x8575C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x857540", Offset = "0x857540", VA = "0x857540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x8571D8", Offset = "0x8571D8", VA = "0x8571D8")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x85721C", Offset = "0x85721C", VA = "0x85721C")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x857260", Offset = "0x857260", VA = "0x857260")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x8572A4", Offset = "0x8572A4", VA = "0x8572A4")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x8572E8", Offset = "0x8572E8", VA = "0x8572E8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x85732C", Offset = "0x85732C", VA = "0x85732C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x857390", Offset = "0x857390", VA = "0x857390")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x857640", Offset = "0x857640", VA = "0x857640")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x8577B8", Offset = "0x8577B8", VA = "0x8577B8")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x85784C", Offset = "0x85784C", VA = "0x85784C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x857854", Offset = "0x857854", VA = "0x857854")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x8579F4", Offset = "0x8579F4", VA = "0x8579F4")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x8579FC", Offset = "0x8579FC", VA = "0x8579FC")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x858430", Offset = "0x858430", VA = "0x858430")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x85863C", Offset = "0x85863C", VA = "0x85863C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x857E84", Offset = "0x857E84", VA = "0x857E84")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x857990", Offset = "0x857990", VA = "0x857990")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x8583A4", Offset = "0x8583A4", VA = "0x8583A4")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x858640", Offset = "0x858640", VA = "0x858640")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x85869C", Offset = "0x85869C", VA = "0x85869C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x8586E0", Offset = "0x8586E0", VA = "0x8586E0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x858724", Offset = "0x858724", VA = "0x858724")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200018D")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200018E")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200018F")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Triggering")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[FormerlySerializedAs("collider")]
		public Collider characterCollider;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x170000FB")]
		public bool inInteraction
		{
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x858D70", Offset = "0x858D70", VA = "0x858D70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FC")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x85A7C8", Offset = "0x85A7C8", VA = "0x85A7C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x85A7D0", Offset = "0x85A7D0", VA = "0x85A7D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x85A7D8", Offset = "0x85A7D8", VA = "0x85A7D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x85A7E0", Offset = "0x85A7E0", VA = "0x85A7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x858BD8", Offset = "0x858BD8", VA = "0x858BD8")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x858C1C", Offset = "0x858C1C", VA = "0x858C1C")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x858C60", Offset = "0x858C60", VA = "0x858C60")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x858CA4", Offset = "0x858CA4", VA = "0x858CA4")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x858CE8", Offset = "0x858CE8", VA = "0x858CE8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x858D2C", Offset = "0x858D2C", VA = "0x858D2C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x858EEC", Offset = "0x858EEC", VA = "0x858EEC")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x858FA8", Offset = "0x858FA8", VA = "0x858FA8")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x859064", Offset = "0x859064", VA = "0x859064")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x859100", Offset = "0x859100", VA = "0x859100")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x8591E8", Offset = "0x8591E8", VA = "0x8591E8")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x8592E4", Offset = "0x8592E4", VA = "0x8592E4")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x85936C", Offset = "0x85936C", VA = "0x85936C")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x8593F4", Offset = "0x8593F4", VA = "0x8593F4")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x85947C", Offset = "0x85947C", VA = "0x85947C")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x8594E8", Offset = "0x8594E8", VA = "0x8594E8")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x859554", Offset = "0x859554", VA = "0x859554")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x8595B4", Offset = "0x8595B4", VA = "0x8595B4")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x859634", Offset = "0x859634", VA = "0x859634")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x8596BC", Offset = "0x8596BC", VA = "0x8596BC")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x859774", Offset = "0x859774", VA = "0x859774")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x859A04", Offset = "0x859A04", VA = "0x859A04")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x859BC0", Offset = "0x859BC0", VA = "0x859BC0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x859E28", Offset = "0x859E28", VA = "0x859E28")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x85A0B4", Offset = "0x85A0B4", VA = "0x85A0B4")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x85A0EC", Offset = "0x85A0EC", VA = "0x85A0EC")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x85A14C", Offset = "0x85A14C", VA = "0x85A14C")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x85A254", Offset = "0x85A254", VA = "0x85A254")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x85A434", Offset = "0x85A434", VA = "0x85A434")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x85A6A8", Offset = "0x85A6A8", VA = "0x85A6A8")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x859F10", Offset = "0x859F10", VA = "0x859F10")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x85A7E8", Offset = "0x85A7E8", VA = "0x85A7E8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x85B038", Offset = "0x85B038", VA = "0x85B038")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x85B058", Offset = "0x85B058", VA = "0x85B058")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x85B074", Offset = "0x85B074", VA = "0x85B074")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x85B090", Offset = "0x85B090", VA = "0x85B090")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x85B0E4", Offset = "0x85B0E4", VA = "0x85B0E4")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x85B250", Offset = "0x85B250", VA = "0x85B250")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x85B34C", Offset = "0x85B34C", VA = "0x85B34C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x85B6A8", Offset = "0x85B6A8", VA = "0x85B6A8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x85B78C", Offset = "0x85B78C", VA = "0x85B78C")]
		private void Update()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x85BA70", Offset = "0x85BA70", VA = "0x85BA70")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x85ADF0", Offset = "0x85ADF0", VA = "0x85ADF0")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x85BBA0", Offset = "0x85BBA0", VA = "0x85BBA0")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x85BCB4", Offset = "0x85BCB4", VA = "0x85BCB4")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x85BD60", Offset = "0x85BD60", VA = "0x85BD60")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x85BE48", Offset = "0x85BE48", VA = "0x85BE48")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x85BE60", Offset = "0x85BE60", VA = "0x85BE60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x858E0C", Offset = "0x858E0C", VA = "0x858E0C")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x8598F0", Offset = "0x8598F0", VA = "0x8598F0")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x85C248", Offset = "0x85C248", VA = "0x85C248")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x85C28C", Offset = "0x85C28C", VA = "0x85C28C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x85C2D0", Offset = "0x85C2D0", VA = "0x85C2D0")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000190")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000191")]
		public class Multiplier
		{
			[Token(Token = "0x40009B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40009B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x85D084", Offset = "0x85D084", VA = "0x85D084")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x85C8C4", Offset = "0x85C8C4", VA = "0x85C8C4")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x85C908", Offset = "0x85C908", VA = "0x85C908")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x85C94C", Offset = "0x85C94C", VA = "0x85C94C")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x85C990", Offset = "0x85C990", VA = "0x85C990")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x85C9D4", Offset = "0x85C9D4", VA = "0x85C9D4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x85CA18", Offset = "0x85CA18", VA = "0x85CA18")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x857E04", Offset = "0x857E04", VA = "0x857E04")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x85CA5C", Offset = "0x85CA5C", VA = "0x85CA5C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x85CAE8", Offset = "0x85CAE8", VA = "0x85CAE8")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x85CF8C", Offset = "0x85CF8C", VA = "0x85CF8C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x85CFD0", Offset = "0x85CFD0", VA = "0x85CFD0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x85D014", Offset = "0x85D014", VA = "0x85D014")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000192")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000193")]
		public class CharacterPosition
		{
			[Token(Token = "0x40009BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x40009BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x40009BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(-180f, 180f)]
			[Tooltip("Angle offset from the default forward direction.")]
			public float angleOffset;

			[Token(Token = "0x40009BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 180f)]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			public float maxAngle;

			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x40009C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x170000FE")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000A0C")]
				[Address(RVA = "0x85D264", Offset = "0x85D264", VA = "0x85D264")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000FF")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000A0D")]
				[Address(RVA = "0x85D270", Offset = "0x85D270", VA = "0x85D270")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x85D330", Offset = "0x85D330", VA = "0x85D330")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x85DA94", Offset = "0x85DA94", VA = "0x85DA94")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000194")]
		public class CameraPosition
		{
			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction?")]
			public Collider lookAtTarget;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x85DAA8", Offset = "0x85DAA8", VA = "0x85DAA8")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x85DC20", Offset = "0x85DC20", VA = "0x85DC20")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x85DF28", Offset = "0x85DF28", VA = "0x85DF28")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000195")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000196")]
			public class Interaction
			{
				[Token(Token = "0x40009CB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40009CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000A15")]
				[Address(RVA = "0x85DFAC", Offset = "0x85DFAC", VA = "0x85DFAC")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x85D15C", Offset = "0x85D15C", VA = "0x85D15C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x85DF9C", Offset = "0x85DF9C", VA = "0x85DF9C")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x85D08C", Offset = "0x85D08C", VA = "0x85D08C")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x85D0D0", Offset = "0x85D0D0", VA = "0x85D0D0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x85D114", Offset = "0x85D114", VA = "0x85D114")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x85D158", Offset = "0x85D158", VA = "0x85D158")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x85B4F4", Offset = "0x85B4F4", VA = "0x85B4F4")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x85D20C", Offset = "0x85D20C", VA = "0x85D20C")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000197")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000198")]
		public class Map
		{
			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40009D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x85E2A0", Offset = "0x85E2A0", VA = "0x85E2A0")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x85E5DC", Offset = "0x85E5DC", VA = "0x85E5DC")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x85E59C", Offset = "0x85E59C", VA = "0x85E59C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x85E420", Offset = "0x85E420", VA = "0x85E420")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x85DFB4", Offset = "0x85DFB4", VA = "0x85DFB4", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x85E32C", Offset = "0x85E32C", VA = "0x85E32C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x85E330", Offset = "0x85E330", VA = "0x85E330", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x85E540", Offset = "0x85E540", VA = "0x85E540", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x85E2D0", Offset = "0x85E2D0", VA = "0x85E2D0")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x85E20C", Offset = "0x85E20C", VA = "0x85E20C")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x85E620", Offset = "0x85E620", VA = "0x85E620")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000199")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _poseRoot;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] children;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x85E640", Offset = "0x85E640", VA = "0x85E640", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x85E700", Offset = "0x85E700", VA = "0x85E700", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x85E8A4", Offset = "0x85E8A4", VA = "0x85E8A4", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x85E98C", Offset = "0x85E98C", VA = "0x85E98C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x85E754", Offset = "0x85E754", VA = "0x85E754")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x85ECBC", Offset = "0x85ECBC", VA = "0x85ECBC")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200019A")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000A27")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000A28")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000A29")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000A2A")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x85ECCC", Offset = "0x85ECCC", VA = "0x85ECCC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x85ED10", Offset = "0x85ED10", VA = "0x85ED10", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x85ED3C", Offset = "0x85ED3C", VA = "0x85ED3C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x85E630", Offset = "0x85E630", VA = "0x85E630")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200019B")]
	public class RagdollUtility : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200019C")]
		public class Rigidbone
		{
			[Token(Token = "0x40009EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40009ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40009EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40009EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40009F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40009F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40009F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x85F3D0", Offset = "0x85F3D0", VA = "0x85F3D0")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x85FF18", Offset = "0x85FF18", VA = "0x85FF18")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x85FCD8", Offset = "0x85FCD8", VA = "0x85FCD8")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x200019D")]
		public class Child
		{
			[Token(Token = "0x40009F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40009F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x85F524", Offset = "0x85F524", VA = "0x85F524")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x8600D8", Offset = "0x8600D8", VA = "0x8600D8")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x85FFEC", Offset = "0x85FFEC", VA = "0x85FFEC")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200019E")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000102")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A4A")]
				[Address(RVA = "0x8606A4", Offset = "0x8606A4", VA = "0x8606A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000103")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A4C")]
				[Address(RVA = "0x8606EC", Offset = "0x8606EC", VA = "0x8606EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x85F580", Offset = "0x85F580", VA = "0x85F580")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x8604C0", Offset = "0x8604C0", VA = "0x8604C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x8604C4", Offset = "0x8604C4", VA = "0x8604C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x8606AC", Offset = "0x8606AC", VA = "0x8606AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Rigidbone[] rigidbones;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000100")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x85ED80", Offset = "0x85ED80", VA = "0x85ED80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000101")]
		private bool ikUsed
		{
			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x85F90C", Offset = "0x85F90C", VA = "0x85F90C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x85ED54", Offset = "0x85ED54", VA = "0x85ED54")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x85EECC", Offset = "0x85EECC", VA = "0x85EECC")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x85EFC4", Offset = "0x85EFC4", VA = "0x85EFC4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x85EF5C", Offset = "0x85EF5C", VA = "0x85EF5C")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x85F5A8", Offset = "0x85F5A8", VA = "0x85F5A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x85F7D0", Offset = "0x85F7D0", VA = "0x85F7D0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x85F870", Offset = "0x85F870", VA = "0x85F870")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x85FA60", Offset = "0x85FA60", VA = "0x85FA60")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x85F8E0", Offset = "0x85F8E0", VA = "0x85F8E0")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x85FA2C", Offset = "0x85FA2C", VA = "0x85FA2C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x85FAE0", Offset = "0x85FAE0", VA = "0x85FAE0")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x85FA84", Offset = "0x85FA84", VA = "0x85FA84")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x85EF00", Offset = "0x85EF00", VA = "0x85EF00")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x85F804", Offset = "0x85F804", VA = "0x85F804")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x8602B0", Offset = "0x8602B0", VA = "0x8602B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x8603C8", Offset = "0x8603C8", VA = "0x8603C8")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200019F")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000104")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x860A70", Offset = "0x860A70", VA = "0x860A70")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000105")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x860A7C", Offset = "0x860A7C", VA = "0x860A7C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x8606F4", Offset = "0x8606F4", VA = "0x8606F4")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x86072C", Offset = "0x86072C", VA = "0x86072C")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x8609E0", Offset = "0x8609E0", VA = "0x8609E0")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x860A44", Offset = "0x860A44", VA = "0x860A44")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000A53")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x8608E4", Offset = "0x8608E4", VA = "0x8608E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x860AAC", Offset = "0x860AAC", VA = "0x860AAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x860AB0", Offset = "0x860AB0", VA = "0x860AB0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x860AD8", Offset = "0x860AD8", VA = "0x860AD8")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x860BAC", Offset = "0x860BAC", VA = "0x860BAC")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x860E04", Offset = "0x860E04", VA = "0x860E04")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x860F58", Offset = "0x860F58", VA = "0x860F58")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20001A0")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x860FB8", Offset = "0x860FB8", VA = "0x860FB8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x860FFC", Offset = "0x860FFC", VA = "0x860FFC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x861040", Offset = "0x861040", VA = "0x861040")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x861084", Offset = "0x861084", VA = "0x861084")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x8610C8", Offset = "0x8610C8", VA = "0x8610C8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x861100", Offset = "0x861100", VA = "0x861100")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x861424", Offset = "0x861424", VA = "0x861424")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20001A1")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x861434", Offset = "0x861434", VA = "0x861434")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x861478", Offset = "0x861478", VA = "0x861478")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x8614BC", Offset = "0x8614BC", VA = "0x8614BC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x861500", Offset = "0x861500", VA = "0x861500")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x861544", Offset = "0x861544", VA = "0x861544", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x861560", Offset = "0x861560", VA = "0x861560")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x8617A8", Offset = "0x8617A8", VA = "0x8617A8")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20001A2")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20001A3")]
		public class ReachCone
		{
			[Token(Token = "0x4000A0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000A10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000A11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000A12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000106")]
			public Vector3 o
			{
				[Token(Token = "0x6000A79")]
				[Address(RVA = "0x86353C", Offset = "0x86353C", VA = "0x86353C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000107")]
			public Vector3 a
			{
				[Token(Token = "0x6000A7A")]
				[Address(RVA = "0x863568", Offset = "0x863568", VA = "0x863568")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000108")]
			public Vector3 b
			{
				[Token(Token = "0x6000A7B")]
				[Address(RVA = "0x863598", Offset = "0x863598", VA = "0x863598")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000109")]
			public Vector3 c
			{
				[Token(Token = "0x6000A7C")]
				[Address(RVA = "0x8635C8", Offset = "0x8635C8", VA = "0x8635C8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010A")]
			public bool isValid
			{
				[Token(Token = "0x6000A7E")]
				[Address(RVA = "0x862A84", Offset = "0x862A84", VA = "0x862A84")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x862F28", Offset = "0x862F28", VA = "0x862F28")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x86308C", Offset = "0x86308C", VA = "0x86308C")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A4")]
		public class LimitPoint
		{
			[Token(Token = "0x4000A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x862A94", Offset = "0x862A94", VA = "0x862A94")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public LimitPoint[] points;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		public Vector3[] P;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x86180C", Offset = "0x86180C", VA = "0x86180C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x861850", Offset = "0x861850", VA = "0x861850")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x861894", Offset = "0x861894", VA = "0x861894")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x8618D8", Offset = "0x8618D8", VA = "0x8618D8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x86191C", Offset = "0x86191C", VA = "0x86191C")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x861F54", Offset = "0x861F54", VA = "0x861F54", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x861FDC", Offset = "0x861FDC", VA = "0x861FDC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x8625BC", Offset = "0x8625BC", VA = "0x8625BC")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x8619A8", Offset = "0x8619A8", VA = "0x8619A8")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x862AF8", Offset = "0x862AF8", VA = "0x862AF8")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x863300", Offset = "0x863300", VA = "0x863300")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x863348", Offset = "0x863348", VA = "0x863348")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x8633A8", Offset = "0x8633A8", VA = "0x8633A8")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x862318", Offset = "0x862318", VA = "0x862318")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x863414", Offset = "0x863414", VA = "0x863414")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x8634E0", Offset = "0x8634E0", VA = "0x8634E0")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public AnimationCurve spline;

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x8635F8", Offset = "0x8635F8", VA = "0x8635F8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x86363C", Offset = "0x86363C", VA = "0x86363C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x863680", Offset = "0x863680", VA = "0x863680")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x8636C4", Offset = "0x8636C4", VA = "0x8636C4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x863708", Offset = "0x863708", VA = "0x863708")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x863724", Offset = "0x863724", VA = "0x863724", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x86375C", Offset = "0x86375C", VA = "0x86375C")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x863B08", Offset = "0x863B08", VA = "0x863B08")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Master weight of the IK solver.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		[Header("Turning Towards The Target")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("RootRotation")]
		[Range(0f, 180f)]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		public float maxRootAngle;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool rotationAllowed;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		[Header("Mode")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform lastTarget;

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float switchWeight;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float switchWeightV;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float weightV;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 dir;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x1700010B")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x863B90", Offset = "0x863B90", VA = "0x863B90")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x863B14", Offset = "0x863B14", VA = "0x863B14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x863C14", Offset = "0x863C14", VA = "0x863C14")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x86412C", Offset = "0x86412C", VA = "0x86412C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x8642B0", Offset = "0x8642B0", VA = "0x8642B0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x8644FC", Offset = "0x8644FC", VA = "0x8644FC")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A8")]
		public class Pose
		{
			[Token(Token = "0x4000A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x8646A0", Offset = "0x8646A0", VA = "0x8646A0")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x864C10", Offset = "0x864C10", VA = "0x864C10")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x864C18", Offset = "0x864C18", VA = "0x864C18")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x8645D0", Offset = "0x8645D0", VA = "0x8645D0")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x864B50", Offset = "0x864B50", VA = "0x864B50")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x864BB0", Offset = "0x864BB0", VA = "0x864BB0")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20001A9")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001AA")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001AB")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A40")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A41")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000A9A")]
				[Address(RVA = "0x8650DC", Offset = "0x8650DC", VA = "0x8650DC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x4000A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x4000A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x4000A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x4000A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x4000A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x864D84", Offset = "0x864D84", VA = "0x864D84")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x8650B4", Offset = "0x8650B4", VA = "0x8650B4")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x8650C4", Offset = "0x8650C4", VA = "0x8650C4")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x864C34", Offset = "0x864C34", VA = "0x864C34", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x865094", Offset = "0x865094", VA = "0x865094")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20001AC")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x8650E4", Offset = "0x8650E4", VA = "0x8650E4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x86514C", Offset = "0x86514C", VA = "0x86514C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x8653EC", Offset = "0x8653EC", VA = "0x8653EC")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20001AD")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001AE")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime;

			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700010D")]
			public bool inProgress
			{
				[Token(Token = "0x6000AA2")]
				[Address(RVA = "0x8654A4", Offset = "0x8654A4", VA = "0x8654A4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700010E")]
			protected float crossFader
			{
				[Token(Token = "0x6000AA3")]
				[Address(RVA = "0x8659A4", Offset = "0x8659A4", VA = "0x8659A4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000AA4")]
				[Address(RVA = "0x8659AC", Offset = "0x8659AC", VA = "0x8659AC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700010F")]
			protected float timer
			{
				[Token(Token = "0x6000AA5")]
				[Address(RVA = "0x8659B4", Offset = "0x8659B4", VA = "0x8659B4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000AA6")]
				[Address(RVA = "0x8659BC", Offset = "0x8659BC", VA = "0x8659BC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000110")]
			protected Vector3 force
			{
				[Token(Token = "0x6000AA7")]
				[Address(RVA = "0x8659C4", Offset = "0x8659C4", VA = "0x8659C4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000AA8")]
				[Address(RVA = "0x8659D0", Offset = "0x8659D0", VA = "0x8659D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000111")]
			protected Vector3 point
			{
				[Token(Token = "0x6000AA9")]
				[Address(RVA = "0x8659DC", Offset = "0x8659DC", VA = "0x8659DC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000AAA")]
				[Address(RVA = "0x8659E8", Offset = "0x8659E8", VA = "0x8659E8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x86586C", Offset = "0x86586C", VA = "0x86586C")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x865578", Offset = "0x865578", VA = "0x865578")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000AAD")]
			protected abstract float GetLength();

			[Token(Token = "0x6000AAE")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000AAF")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x8659F4", Offset = "0x8659F4", VA = "0x8659F4")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AF")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001B0")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A57")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A58")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000A59")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000A5A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000AB5")]
				[Address(RVA = "0x865D28", Offset = "0x865D28", VA = "0x865D28")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000AB6")]
				[Address(RVA = "0x865B84", Offset = "0x865B84", VA = "0x865B84")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000AB7")]
				[Address(RVA = "0x865DD8", Offset = "0x865DD8", VA = "0x865DD8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x865A08", Offset = "0x865A08", VA = "0x865A08", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x865B24", Offset = "0x865B24", VA = "0x865B24", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x865B98", Offset = "0x865B98", VA = "0x865B98", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x865DC4", Offset = "0x865DC4", VA = "0x865DC4")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B1")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001B2")]
			public class BoneLink
			{
				[Token(Token = "0x4000A5E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x4000A5F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x4000A60")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000A61")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000ABC")]
				[Address(RVA = "0x866098", Offset = "0x866098", VA = "0x866098")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000ABD")]
				[Address(RVA = "0x865EC4", Offset = "0x865EC4", VA = "0x865EC4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000ABE")]
				[Address(RVA = "0x866238", Offset = "0x866238", VA = "0x866238")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x865DE0", Offset = "0x865DE0", VA = "0x865DE0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x865E6C", Offset = "0x865E6C", VA = "0x865E6C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x865ED0", Offset = "0x865ED0", VA = "0x865ED0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x866224", Offset = "0x866224", VA = "0x866224")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700010C")]
		public bool inProgress
		{
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x865408", Offset = "0x865408", VA = "0x865408")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x8654B8", Offset = "0x8654B8", VA = "0x8654B8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x865650", Offset = "0x865650", VA = "0x865650")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x865994", Offset = "0x865994", VA = "0x865994")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20001B4")]
		public abstract class Offset
		{
			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime;

			[Token(Token = "0x4000A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000112")]
			protected float crossFader
			{
				[Token(Token = "0x6000AC2")]
				[Address(RVA = "0x8667A8", Offset = "0x8667A8", VA = "0x8667A8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000AC3")]
				[Address(RVA = "0x8667B0", Offset = "0x8667B0", VA = "0x8667B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000113")]
			protected float timer
			{
				[Token(Token = "0x6000AC4")]
				[Address(RVA = "0x8667B8", Offset = "0x8667B8", VA = "0x8667B8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000AC5")]
				[Address(RVA = "0x8667C0", Offset = "0x8667C0", VA = "0x8667C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000114")]
			protected Vector3 force
			{
				[Token(Token = "0x6000AC6")]
				[Address(RVA = "0x8667C8", Offset = "0x8667C8", VA = "0x8667C8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000AC7")]
				[Address(RVA = "0x8667D4", Offset = "0x8667D4", VA = "0x8667D4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000115")]
			protected Vector3 point
			{
				[Token(Token = "0x6000AC8")]
				[Address(RVA = "0x8667E0", Offset = "0x8667E0", VA = "0x8667E0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000AC9")]
				[Address(RVA = "0x8667EC", Offset = "0x8667EC", VA = "0x8667EC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x866658", Offset = "0x866658", VA = "0x866658")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0x866354", Offset = "0x866354", VA = "0x866354")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000ACC")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000ACD")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000ACE")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x8667F8", Offset = "0x8667F8", VA = "0x8667F8")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B5")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001B6")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000A72")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000A73")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000A74")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000A75")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000AD4")]
				[Address(RVA = "0x866BDC", Offset = "0x866BDC", VA = "0x866BDC")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000AD5")]
				[Address(RVA = "0x866A00", Offset = "0x866A00", VA = "0x866A00")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000AD6")]
				[Address(RVA = "0x866C70", Offset = "0x866C70", VA = "0x866C70")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x86680C", Offset = "0x86680C", VA = "0x86680C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x8669A0", Offset = "0x8669A0", VA = "0x8669A0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x866A14", Offset = "0x866A14", VA = "0x866A14", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x866C54", Offset = "0x866C54", VA = "0x866C54")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B7")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001B8")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000A79")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000A7A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x4000A7B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000A7C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000ADB")]
				[Address(RVA = "0x867030", Offset = "0x867030", VA = "0x867030")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000ADC")]
				[Address(RVA = "0x866DA8", Offset = "0x866DA8", VA = "0x866DA8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000ADD")]
				[Address(RVA = "0x86714C", Offset = "0x86714C", VA = "0x86714C")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x4000A77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x866C78", Offset = "0x866C78", VA = "0x866C78", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x866D50", Offset = "0x866D50", VA = "0x866D50", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x866DB4", Offset = "0x866DB4", VA = "0x866DB4", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x867138", Offset = "0x867138", VA = "0x867138")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x86629C", Offset = "0x86629C", VA = "0x86629C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x866434", Offset = "0x866434", VA = "0x866434")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x866788", Offset = "0x866788", VA = "0x866788")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20001B9")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001BA")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001BB")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A8A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A8B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000AE4")]
				[Address(RVA = "0x867714", Offset = "0x867714", VA = "0x867714")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x4000A80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000A81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x4000A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x4000A83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Range(0f, 1f)]
			[Tooltip("Matching target velocity")]
			public float matchVelocity;

			[Token(Token = "0x4000A84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x4000A85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000A86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000A87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000A88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000A89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0x86721C", Offset = "0x86721C", VA = "0x86721C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x86739C", Offset = "0x86739C", VA = "0x86739C")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0x8676F8", Offset = "0x8676F8", VA = "0x8676F8")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000A7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x4000A7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x8671B0", Offset = "0x8671B0", VA = "0x8671B0")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x8672F8", Offset = "0x8672F8", VA = "0x8672F8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x8676E8", Offset = "0x8676E8", VA = "0x8676E8")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20001BC")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001BD")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000A8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000A90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x4000A91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x4000A92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x4000A93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x4000A94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x4000A95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x4000A96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x4000A97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x4000A98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x4000A99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x867880", Offset = "0x867880", VA = "0x867880")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x867AF0", Offset = "0x867AF0", VA = "0x867AF0")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x867B60", Offset = "0x867B60", VA = "0x867B60")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x867BA8", Offset = "0x867BA8", VA = "0x867BA8")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20001BE")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x17000117")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AF4")]
				[Address(RVA = "0x867D04", Offset = "0x867D04", VA = "0x867D04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000118")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AF6")]
				[Address(RVA = "0x867D4C", Offset = "0x867D4C", VA = "0x867D4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x867784", Offset = "0x867784", VA = "0x867784")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x867BB0", Offset = "0x867BB0", VA = "0x867BB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0x867BB4", Offset = "0x867BB4", VA = "0x867BB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x867D0C", Offset = "0x867D0C", VA = "0x867D0C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000116")]
		protected float deltaTime
		{
			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0x864D64", Offset = "0x864D64", VA = "0x864D64")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000AE6")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x86512C", Offset = "0x86512C", VA = "0x86512C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x86771C", Offset = "0x86771C", VA = "0x86771C")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x8677AC", Offset = "0x8677AC", VA = "0x8677AC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x867640", Offset = "0x867640", VA = "0x867640")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x8679E4", Offset = "0x8679E4", VA = "0x8679E4", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x8650A4", Offset = "0x8650A4", VA = "0x8650A4")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20001BF")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20001C0")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x1700011A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B01")]
				[Address(RVA = "0x868158", Offset = "0x868158", VA = "0x868158", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B03")]
				[Address(RVA = "0x8681A0", Offset = "0x8681A0", VA = "0x8681A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x867DFC", Offset = "0x867DFC", VA = "0x867DFC")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0x868004", Offset = "0x868004", VA = "0x868004", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B00")]
			[Address(RVA = "0x868008", Offset = "0x868008", VA = "0x868008", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B02")]
			[Address(RVA = "0x868160", Offset = "0x868160", VA = "0x868160", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x4000A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000119")]
		protected float deltaTime
		{
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x867D54", Offset = "0x867D54", VA = "0x867D54")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000AF8")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x867D74", Offset = "0x867D74", VA = "0x867D74", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x867D94", Offset = "0x867D94", VA = "0x867D94")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x867E24", Offset = "0x867E24", VA = "0x867E24")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x867EF8", Offset = "0x867EF8", VA = "0x867EF8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x866798", Offset = "0x866798", VA = "0x866798")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001C2")]
		public class EffectorLink
		{
			[Token(Token = "0x4000AA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000AA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000AA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000AA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x8681A8", Offset = "0x8681A8", VA = "0x8681A8")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x8684F4", Offset = "0x8684F4", VA = "0x8684F4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x865338", Offset = "0x865338", VA = "0x865338")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x8683F8", Offset = "0x8683F8", VA = "0x8683F8")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x86849C", Offset = "0x86849C", VA = "0x86849C")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20001C3")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001C4")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20001C5")]
			public class EffectorLink
			{
				[Token(Token = "0x4000AC5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000AC6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000B18")]
				[Address(RVA = "0x869848", Offset = "0x869848", VA = "0x869848")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000ABF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x4000AC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			public float additivity;

			[Token(Token = "0x4000AC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000AC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000AC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000AC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000B15")]
			[Address(RVA = "0x868698", Offset = "0x868698", VA = "0x868698")]
			public void Start()
			{
			}

			[Token(Token = "0x6000B16")]
			[Address(RVA = "0x8691F4", Offset = "0x8691F4", VA = "0x8691F4")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x869834", Offset = "0x869834", VA = "0x869834")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C6")]
		public enum Handedness
		{
			[Token(Token = "0x4000AC8")]
			Right,
			[Token(Token = "0x4000AC9")]
			Left
		}

		[Token(Token = "0x4000AA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x4000AA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000AAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x4000AAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x4000AAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x4000AAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000AAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000AB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x4000AB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000AB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x4000AB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x4000ABA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x4000ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x4000ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x1700011C")]
		public bool isFinished
		{
			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x8684FC", Offset = "0x8684FC", VA = "0x8684FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011D")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x8693F8", Offset = "0x8693F8", VA = "0x8693F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011E")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x869434", Offset = "0x869434", VA = "0x869434")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011F")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x8693C0", Offset = "0x8693C0", VA = "0x8693C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000120")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x8693DC", Offset = "0x8693DC", VA = "0x8693DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x868520", Offset = "0x868520", VA = "0x868520")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x86854C", Offset = "0x86854C", VA = "0x86854C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x86876C", Offset = "0x86876C", VA = "0x86876C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x869470", Offset = "0x869470", VA = "0x869470")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x869588", Offset = "0x869588", VA = "0x869588")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x8695D8", Offset = "0x8695D8", VA = "0x8695D8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x8697A8", Offset = "0x8697A8", VA = "0x8697A8")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20001C7")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x4000ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x4000ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x869850", Offset = "0x869850", VA = "0x869850")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x869940", Offset = "0x869940", VA = "0x869940")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x869A1C", Offset = "0x869A1C", VA = "0x869A1C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x869E20", Offset = "0x869E20", VA = "0x869E20")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x869E54", Offset = "0x869E54", VA = "0x869E54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x869F60", Offset = "0x869F60", VA = "0x869F60")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20001C8")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20001C9")]
		public class Settings
		{
			[Token(Token = "0x4000ACE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000ACF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000AD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Local axis of the body tracker towards the player's forward direction.")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000AD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("Local axis of the body tracker towards the up direction.")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000AD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000AD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000AD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000AD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000AD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			[Space(10f)]
			public Vector3 headOffset;

			[Token(Token = "0x4000AD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x4000AD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x4000AD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x4000ADA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Range(-180f, 180f)]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			public float footHeadingOffset;

			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x86B718", Offset = "0x86B718", VA = "0x86B718")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x869F74", Offset = "0x869F74", VA = "0x869F74")]
		public static void Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x86AF70", Offset = "0x86AF70", VA = "0x86AF70")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20001CA")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 pelvisTargetRight;

		[Token(Token = "0x4000ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x86B90C", Offset = "0x86B90C", VA = "0x86B90C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x86B628", Offset = "0x86B628", VA = "0x86B628")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x86B9FC", Offset = "0x86B9FC", VA = "0x86B9FC")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x86BCE4", Offset = "0x86BCE4", VA = "0x86BCE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x86BDF0", Offset = "0x86BDF0", VA = "0x86BDF0")]
		public VRIKRootController()
		{
		}
	}
}
