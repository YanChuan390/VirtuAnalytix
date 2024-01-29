using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using Il2CppDummyDll;
using Poly2Tri;
using ProgressBar.Utils;
using RogoDigital.Lipsync;
using UltimateFracturing;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class FireFlicker : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Light thisLight;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Color originalColor;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float timePassed;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float changeValue;

	[Token(Token = "0x17000001")]
	public Light ThisLight
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xC1ED68", Offset = "0xC1ED68", VA = "0xC1ED68")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public Color OriginalColor
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xC1ED70", Offset = "0xC1ED70", VA = "0xC1ED70")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000003")]
	public float TimePassed
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xC1ED7C", Offset = "0xC1ED7C", VA = "0xC1ED7C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xC1ED84", Offset = "0xC1ED84", VA = "0xC1ED84")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public float ChangeValue
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0xC1ED8C", Offset = "0xC1ED8C", VA = "0xC1ED8C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0xC1ED94", Offset = "0xC1ED94", VA = "0xC1ED94")]
		set
		{
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xC1ED9C", Offset = "0xC1ED9C", VA = "0xC1ED9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xC1ED60", Offset = "0xC1ED60", VA = "0xC1ED60")]
	public FireFlicker()
	{
	}
}
[Token(Token = "0x2000003")]
public class Fire : FireFlicker
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int calmTime;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int intenseTime;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float changeFireOn;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float stopChangeFireOn;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xC1EB64", Offset = "0xC1EB64", VA = "0xC1EB64")]
	private void Start()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xC1EBA8", Offset = "0xC1EBA8", VA = "0xC1EBA8")]
	private void Update()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xC1EC20", Offset = "0xC1EC20", VA = "0xC1EC20")]
	private float UpdateLightSource()
	{
		return default(float);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xC1ED4C", Offset = "0xC1ED4C", VA = "0xC1ED4C")]
	public Fire()
	{
	}
}
[Token(Token = "0x2000004")]
public static class ResonanceAudio
{
	[StructLayout(0)]
	[Token(Token = "0x2000122")]
	private class RoomProperties
	{
		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float positionX;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float positionY;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float positionZ;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rotationX;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationY;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationZ;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rotationW;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float dimensionsX;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float dimensionsY;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float dimensionsZ;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ResonanceAudioRoomManager.SurfaceMaterial materialLeft;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public ResonanceAudioRoomManager.SurfaceMaterial materialRight;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ResonanceAudioRoomManager.SurfaceMaterial materialBottom;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public ResonanceAudioRoomManager.SurfaceMaterial materialTop;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ResonanceAudioRoomManager.SurfaceMaterial materialFront;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public ResonanceAudioRoomManager.SurfaceMaterial materialBack;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float reflectionScalar;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float reverbGain;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float reverbTime;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float reverbBrightness;

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x9D93F0", Offset = "0x9D93F0", VA = "0x9D93F0")]
		public RoomProperties()
		{
		}
	}

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Transform listenerTransform;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly Color listenerDirectivityColor;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly Color sourceDirectivityColor;

	[Token(Token = "0x400000C")]
	public const float distanceEpsilon = 0.01f;

	[Token(Token = "0x400000D")]
	public const float maxDistanceLimit = 1000000f;

	[Token(Token = "0x400000E")]
	public const float minDistanceLimit = 990099f;

	[Token(Token = "0x400000F")]
	public const float maxGainDb = 24f;

	[Token(Token = "0x4000010")]
	public const float minGainDb = -24f;

	[Token(Token = "0x4000011")]
	public const float maxReverbBrightness = 1f;

	[Token(Token = "0x4000012")]
	public const float minReverbBrightness = -1f;

	[Token(Token = "0x4000013")]
	public const float maxReverbTime = 10f;

	[Token(Token = "0x4000014")]
	public const float maxReflectivity = 2f;

	[Token(Token = "0x4000015")]
	public const int maxNumOcclusionHits = 12;

	[Token(Token = "0x4000016")]
	public const float occlusionDetectionInterval = 0.2f;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly Matrix4x4 flipZ;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static RaycastHit[] occlusionHits;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static int occlusionMaskValue;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static float[] roomPosition;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static RoomProperties roomProperties;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr roomPropertiesPtr;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static Matrix4x4 transformMatrix;

	[Token(Token = "0x400001E")]
	private const string pluginName = "audiopluginresonanceaudio";

	[Token(Token = "0x17000005")]
	public static Transform ListenerTransform
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x9D7BBC", Offset = "0x9D7BBC", VA = "0x9D7BBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x9D7D04", Offset = "0x9D7D04", VA = "0x9D7D04")]
	public static void UpdateAudioListener(ResonanceAudioListener listener)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x9D7F20", Offset = "0x9D7F20", VA = "0x9D7F20")]
	public static void DisableRoomEffects()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x9D809C", Offset = "0x9D809C", VA = "0x9D809C")]
	public static void UpdateRoom(ResonanceAudioRoom room)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x9D83EC", Offset = "0x9D83EC", VA = "0x9D83EC")]
	public static void UpdateReverbProbe(ResonanceAudioReverbProbe reverbPobe)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x9D869C", Offset = "0x9D869C", VA = "0x9D869C")]
	public static bool StartRecording()
	{
		return default(bool);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x9D86A4", Offset = "0x9D86A4", VA = "0x9D86A4")]
	public static bool StopRecordingAndSaveToFile(string filePath, bool seamless)
	{
		return default(bool);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x9D86AC", Offset = "0x9D86AC", VA = "0x9D86AC")]
	public static void InitializeReverbComputer(float[] vertices, int[] triangles, int[] materialIndices, float scatteringCoefficient)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x9D86B0", Offset = "0x9D86B0", VA = "0x9D86B0")]
	public static bool ComputeRt60sAndProxyRoom(ResonanceAudioReverbProbe reverbProbe, int totalNumPaths, int numPathsPerBatch, int maxDepth, float energyThreshold, float listenerSphereRadius)
	{
		return default(bool);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x9D86B8", Offset = "0x9D86B8", VA = "0x9D86B8")]
	public static float ComputeOcclusion(Transform sourceTransform)
	{
		return default(float);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x9D7DA4", Offset = "0x9D7DA4", VA = "0x9D7DA4")]
	public static float ConvertAmplitudeFromDb(float db)
	{
		return default(float);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x9D89D8", Offset = "0x9D89D8", VA = "0x9D89D8")]
	public static Vector2[] Generate2dPolarPattern(float alpha, float order, int resolution)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x9D8B4C", Offset = "0x9D8B4C", VA = "0x9D8B4C")]
	private static void ConvertAudioTransformFromUnity(ref Vector3 position, ref Quaternion rotation)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x9D8E3C", Offset = "0x9D8E3C", VA = "0x9D8E3C")]
	private static void SetProxyRoomProperties(ResonanceAudioReverbProbe reverbProbe, RoomProperties proxyRoomProperties)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x9D825C", Offset = "0x9D825C", VA = "0x9D825C")]
	private static void UpdateRoomProperties(ResonanceAudioRoom room)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x9D85B4", Offset = "0x9D85B4", VA = "0x9D85B4")]
	private static void UpdateRoomProperties(ResonanceAudioReverbProbe reverbProbe)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x9D8ED8", Offset = "0x9D8ED8", VA = "0x9D8ED8")]
	private static void FillGeometryOfRoomProperties(Vector3 position, Quaternion rotation, Vector3 scale)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x9D9028", Offset = "0x9D9028", VA = "0x9D9028")]
	private static void FillWallMaterialsOfRoomProperties(ResonanceAudioRoomManager.SurfaceMaterial leftWall, ResonanceAudioRoomManager.SurfaceMaterial rightWall, ResonanceAudioRoomManager.SurfaceMaterial floor, ResonanceAudioRoomManager.SurfaceMaterial ceiling, ResonanceAudioRoomManager.SurfaceMaterial frontWall, ResonanceAudioRoomManager.SurfaceMaterial backWall)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x9D911C", Offset = "0x9D911C", VA = "0x9D911C")]
	private static void FillModifiersOfRoomProperties(float reverbGainDb, float reverbTime, float reverbBrightness, float reflectivity)
	{
	}

	[PreserveSig]
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x9D7E1C", Offset = "0x9D7E1C", VA = "0x9D7E1C")]
	private static extern void SetListenerGain(float gain);

	[PreserveSig]
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x9D7EA0", Offset = "0x9D7EA0", VA = "0x9D7EA0")]
	private static extern void SetListenerStereoSpeakerMode(bool enableStereoSpeakerMode);

	[PreserveSig]
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x9D8004", Offset = "0x9D8004", VA = "0x9D8004")]
	private static extern void SetRoomProperties(IntPtr roomProperties, float[] rt60s);
}
[Token(Token = "0x2000005")]
public class ResonanceAudioAcousticMesh
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C31F4", Offset = "0x6C31F4")]
	private Mesh <mesh>k__BackingField;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3204", Offset = "0x6C3204")]
	private GameObject <sourceObject>k__BackingField;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isIncludedByObjectFiltering;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ResonanceAudioRoomManager.SurfaceMaterial[] surfaceMaterialsFromSubMesh;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RangeInt[] triangleRangesFromSubMesh;

	[Token(Token = "0x4000024")]
	private const int unityMaxNumVerticesPerMesh = 65000;

	[Token(Token = "0x4000025")]
	private const int maxNumSubMeshes = 256;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material visualizationMaterial;

	[Token(Token = "0x17000006")]
	public Mesh mesh
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x9D93F8", Offset = "0x9D93F8", VA = "0x9D93F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C583C", Offset = "0x6C583C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x9D9400", Offset = "0x9D9400", VA = "0x9D9400")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C584C", Offset = "0x6C584C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public GameObject sourceObject
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x9D9408", Offset = "0x9D9408", VA = "0x9D9408")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C585C", Offset = "0x6C585C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x9D9410", Offset = "0x9D9410", VA = "0x9D9410")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C586C", Offset = "0x6C586C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x9D9418", Offset = "0x9D9418", VA = "0x9D9418")]
	public static ResonanceAudioAcousticMesh GenerateFromMeshFilter(MeshFilter meshFilter, Shader surfaceMaterialShader)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x9D9D00", Offset = "0x9D9D00", VA = "0x9D9D00")]
	public static ResonanceAudioAcousticMesh GenerateFromTerrain(Terrain terrain, Shader surfaceMaterialShader)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x9DA404", Offset = "0x9DA404", VA = "0x9DA404")]
	public int[] GetSurfaceMaterialIndicesFromTriangle()
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x9DA55C", Offset = "0x9DA55C", VA = "0x9DA55C")]
	public void SetSurfaceMaterialToAllSubMeshes(ResonanceAudioRoomManager.SurfaceMaterial surfaceMaterial)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x9DA6B0", Offset = "0x9DA6B0", VA = "0x9DA6B0")]
	public void SetSurfaceMaterialToSubMesh(ResonanceAudioRoomManager.SurfaceMaterial surfaceMaterial, int subMeshIndex)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x9DA8F0", Offset = "0x9DA8F0", VA = "0x9DA8F0")]
	public bool Render()
	{
		return default(bool);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x9DA9F8", Offset = "0x9DA9F8", VA = "0x9DA9F8")]
	public bool IsIncluded()
	{
		return default(bool);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x9DAAD4", Offset = "0x9DAAD4", VA = "0x9DAAD4")]
	public bool IsSubMeshTriangular(int subMeshIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x9D9628", Offset = "0x9D9628", VA = "0x9D9628")]
	private static int CountTriangleIndices(Mesh sourceMesh)
	{
		return default(int);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x9D9F68", Offset = "0x9D9F68", VA = "0x9D9F68")]
	private static void SubSampleHeightMap(int originalM, int originalN, out int m, out int n, out int subSampleStep, out int subSampledNumTriangleIndices)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x9D96C0", Offset = "0x9D96C0", VA = "0x9D96C0")]
	private void InitializeMesh(int numTriangleIndices, int numVertices, out int[] triangles, out Vector3[] vertices)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x9D9B90", Offset = "0x9D9B90", VA = "0x9D9B90")]
	private void InitializeSubMeshMaterials()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x9D9C54", Offset = "0x9D9C54", VA = "0x9D9C54")]
	private void InitializeVisualizationMaterial(Shader surfaceMaterialShader)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x9D97DC", Offset = "0x9D97DC", VA = "0x9D97DC")]
	private void FillVerticesAndTrianglesFromMesh(Mesh sourceMesh, Transform sourceObjectTransform, ref Vector3[] vertices, ref int[] triangles)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x9DA014", Offset = "0x9DA014", VA = "0x9DA014")]
	private void FillTrianglesAndVerticesFromHeightMap(Vector3 terrainPosition, Vector3 terrainSize, float[,] heightMap, int m, int n, int subSampleStep, ref int[] triangles, ref Vector3[] vertices)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x9DAB18", Offset = "0x9DAB18", VA = "0x9DAB18")]
	private void SetSubMeshEnds()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x9DA5B0", Offset = "0x9DA5B0", VA = "0x9DA5B0")]
	private void SetSubMeshSurfaceMaterials()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x9D96B8", Offset = "0x9D96B8", VA = "0x9D96B8")]
	public ResonanceAudioAcousticMesh()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6C2100", Offset = "0x6C2100")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6C2100", Offset = "0x6C2100")]
[ExecuteInEditMode]
public class ResonanceAudioListener : MonoBehaviour
{
	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C3214", Offset = "0x6C3214")]
	public float globalGainDb;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C324C", Offset = "0x6C324C")]
	public LayerMask occlusionMask;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C3284", Offset = "0x6C3284")]
	public bool stereoSpeakerModeEnabled;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C32BC", Offset = "0x6C32BC")]
	public bool recorderSeamless;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C32F4", Offset = "0x6C32F4")]
	public string recorderSourceTag;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C332C", Offset = "0x6C332C")]
	private bool <IsRecording>k__BackingField;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[SerializeField]
	private bool recorderFoldout;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<AudioSource> recorderTaggedSources;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private double recorderStartTime;

	[Token(Token = "0x17000008")]
	public bool IsRecording
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x9DAE54", Offset = "0x9DAE54", VA = "0x9DAE54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C587C", Offset = "0x6C587C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x9DAE5C", Offset = "0x9DAE5C", VA = "0x9DAE5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C588C", Offset = "0x6C588C")]
		private set
		{
		}
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x9DAE68", Offset = "0x9DAE68", VA = "0x9DAE68")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x9DAEF0", Offset = "0x9DAEF0", VA = "0x9DAEF0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x9DB11C", Offset = "0x9DB11C", VA = "0x9DB11C")]
	private void Update()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x9DB334", Offset = "0x9DB334", VA = "0x9DB334")]
	public double GetCurrentRecordDuration()
	{
		return default(double);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x9DB370", Offset = "0x9DB370", VA = "0x9DB370")]
	public void StartSoundfieldRecorder()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x9DAF88", Offset = "0x9DAF88", VA = "0x9DAF88")]
	public void StopSoundfieldRecorder(string filePath)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x9DB1B0", Offset = "0x9DB1B0", VA = "0x9DB1B0")]
	private void UpdateTaggedSources()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x9DB598", Offset = "0x9DB598", VA = "0x9DB598")]
	public ResonanceAudioListener()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x6C2198", Offset = "0x6C2198")]
public class ResonanceAudioMaterialMap : ScriptableObject
{
	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Color[] surfaceMaterialColors;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ResonanceAudioRoomManager.SurfaceMaterialDictionary surfaceMaterialFromGuid;

	[Token(Token = "0x4000032")]
	private const ResonanceAudioRoomManager.SurfaceMaterial defaultSurfaceMaterial = ResonanceAudioRoomManager.SurfaceMaterial.Transparent;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x9DB600", Offset = "0x9DB600", VA = "0x9DB600")]
	public List<string> GuidList()
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x9DB668", Offset = "0x9DB668", VA = "0x9DB668")]
	public ResonanceAudioRoomManager.SurfaceMaterial GetMaterialFromGuid(string guid)
	{
		return default(ResonanceAudioRoomManager.SurfaceMaterial);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x9DB6D0", Offset = "0x9DB6D0", VA = "0x9DB6D0")]
	public void AddDefaultMaterialIfGuidUnmapped(string guid)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x9DB76C", Offset = "0x9DB76C", VA = "0x9DB76C")]
	public ResonanceAudioMaterialMap()
	{
	}
}
[Token(Token = "0x2000008")]
public class ResonanceAudioMaterialMapper : ScriptableObject
{
	[Token(Token = "0x2000123")]
	private class UnityMaterialAcousticMeshData
	{
		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<ResonanceAudioAcousticMesh> acousticMeshes;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> subMeshIndices;

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x9DC9C0", Offset = "0x9DC9C0", VA = "0x9DC9C0")]
		public UnityMaterialAcousticMeshData()
		{
		}
	}

	[Token(Token = "0x2000124")]
	private class TerrainAcousticMeshData
	{
		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<ResonanceAudioAcousticMesh> acousticMeshes;

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x9DCA5C", Offset = "0x9DCA5C", VA = "0x9DCA5C")]
		public TerrainAcousticMeshData()
		{
		}
	}

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ResonanceAudioMaterialMap materialMap;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<string, UnityMaterialAcousticMeshData> unityMaterialAcousticMeshDataFromGuid;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<string, TerrainAcousticMeshData> terrainAcousticMeshDataFromGuid;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private LayerMask reverbLayerMask;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool includeNonStaticGameObjects;

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x9DBD64", Offset = "0x9DBD64", VA = "0x9DBD64")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x9DBDF4", Offset = "0x9DBDF4", VA = "0x9DBDF4")]
	public void ApplyMaterialMapping(MeshRenderer[] meshRenderers, List<string>[] guidsForMeshRenderers, Terrain[] activeTerrains, string[] guidsForTerrains, Shader surfaceMaterialShader)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x9DC608", Offset = "0x9DC608", VA = "0x9DC608")]
	public void RenderAcousticMeshes()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x9DC6A0", Offset = "0x9DC6A0", VA = "0x9DC6A0")]
	public List<ResonanceAudioAcousticMesh> GetIncludedAcousticMeshes()
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x9DBE60", Offset = "0x9DBE60", VA = "0x9DBE60")]
	private void BuildUnityMaterialData(MeshRenderer[] meshRenderers, List<string>[] guidsForMeshRenderers, Shader surfaceMaterialShader)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x9DC124", Offset = "0x9DC124", VA = "0x9DC124")]
	private void BuildTerrainData(Terrain[] activeTerrains, string[] guidsForTerrains, Shader surfaceMaterialShader)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x9DC300", Offset = "0x9DC300", VA = "0x9DC300")]
	private void ApplyMaterialMappingToGuids(List<string> guids)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x9DCAD0", Offset = "0x9DCAD0", VA = "0x9DCAD0")]
	private void ApplySurfaceMaterialToGameObjects(ResonanceAudioRoomManager.SurfaceMaterial surfaceMaterial, string guid)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x9DCD94", Offset = "0x9DCD94", VA = "0x9DCD94")]
	private void ApplySurfaceMaterialToTerrains(ResonanceAudioRoomManager.SurfaceMaterial surfaceMaterial, string guid)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x9DC41C", Offset = "0x9DC41C", VA = "0x9DC41C")]
	private void ApplyObjectFiltering()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x9DCE6C", Offset = "0x9DCE6C", VA = "0x9DCE6C")]
	private bool IsIncludedByObjectFiltering(GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x9DCEF4", Offset = "0x9DCEF4", VA = "0x9DCEF4")]
	public ResonanceAudioMaterialMapper()
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6C21EC", Offset = "0x6C21EC")]
[ExecuteInEditMode]
public class ResonanceAudioMaterialMapperUpdater : MonoBehaviour
{
	[Token(Token = "0x2000125")]
	public delegate void RefreshMaterialMapperDelegate();

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RefreshMaterialMapperDelegate RefreshMaterialMapper;

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x9DCF30", Offset = "0x9DCF30", VA = "0x9DCF30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x9DD184", Offset = "0x9DD184", VA = "0x9DD184")]
	public ResonanceAudioMaterialMapperUpdater()
	{
	}
}
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6C2238", Offset = "0x6C2238")]
[ExecuteInEditMode]
public class ResonanceAudioReverbProbe : MonoBehaviour
{
	[Token(Token = "0x2000126")]
	public enum RegionShape
	{
		[Token(Token = "0x40005EB")]
		Sphere,
		[Token(Token = "0x40005EC")]
		Box
	}

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C338C", Offset = "0x6C338C")]
	public float[] rt60s;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C33C4", Offset = "0x6C33C4")]
	public float reverbGainDb;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C33FC", Offset = "0x6C33FC")]
	public float reverbBrightness;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C3434", Offset = "0x6C3434")]
	public float reverbTime;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C346C", Offset = "0x6C346C")]
	public RegionShape regionShape;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C34A4", Offset = "0x6C34A4")]
	public Vector3 boxRegionSize;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C34DC", Offset = "0x6C34DC")]
	public float sphereRegionRadius;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C3514", Offset = "0x6C3514")]
	public bool onlyApplyWhenVisible;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 proxyRoomPosition;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Quaternion proxyRoomRotation;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 proxyRoomSize;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public ResonanceAudioRoomManager.SurfaceMaterial proxyRoomLeftWall;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ResonanceAudioRoomManager.SurfaceMaterial proxyRoomRightWall;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public ResonanceAudioRoomManager.SurfaceMaterial proxyRoomFloor;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ResonanceAudioRoomManager.SurfaceMaterial proxyRoomCeiling;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public ResonanceAudioRoomManager.SurfaceMaterial proxyRoomBackWall;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ResonanceAudioRoomManager.SurfaceMaterial proxyRoomFrontWall;

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x9DD1D4", Offset = "0x9DD1D4", VA = "0x9DD1D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x9DD2AC", Offset = "0x9DD2AC", VA = "0x9DD2AC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x9DD37C", Offset = "0x9DD37C", VA = "0x9DD37C")]
	private void Update()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x9DD3E0", Offset = "0x9DD3E0", VA = "0x9DD3E0")]
	public float GetScaledSphericalRegionRadius()
	{
		return default(float);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x9DD49C", Offset = "0x9DD49C", VA = "0x9DD49C")]
	public Vector3 GetScaledBoxRegionSize()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x9DD560", Offset = "0x9DD560", VA = "0x9DD560")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x9DD6A4", Offset = "0x9DD6A4", VA = "0x9DD6A4")]
	public ResonanceAudioReverbProbe()
	{
	}
}
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6C2284", Offset = "0x6C2284")]
public class ResonanceAudioRoom : MonoBehaviour
{
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C354C", Offset = "0x6C354C")]
	public ResonanceAudioRoomManager.SurfaceMaterial leftWall;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C3584", Offset = "0x6C3584")]
	public ResonanceAudioRoomManager.SurfaceMaterial rightWall;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C35BC", Offset = "0x6C35BC")]
	public ResonanceAudioRoomManager.SurfaceMaterial floor;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C35F4", Offset = "0x6C35F4")]
	public ResonanceAudioRoomManager.SurfaceMaterial ceiling;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C362C", Offset = "0x6C362C")]
	public ResonanceAudioRoomManager.SurfaceMaterial backWall;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C3664", Offset = "0x6C3664")]
	public ResonanceAudioRoomManager.SurfaceMaterial frontWall;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C369C", Offset = "0x6C369C")]
	public float reflectivity;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C36D4", Offset = "0x6C36D4")]
	public float reverbGainDb;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C370C", Offset = "0x6C370C")]
	public float reverbBrightness;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C3744", Offset = "0x6C3744")]
	public float reverbTime;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C377C", Offset = "0x6C377C")]
	public Vector3 size;

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x9DD7A0", Offset = "0x9DD7A0", VA = "0x9DD7A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x9DD878", Offset = "0x9DD878", VA = "0x9DD878")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x9DD948", Offset = "0x9DD948", VA = "0x9DD948")]
	private void Update()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x9DD9AC", Offset = "0x9DD9AC", VA = "0x9DD9AC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x9DDA78", Offset = "0x9DDA78", VA = "0x9DDA78")]
	public ResonanceAudioRoom()
	{
	}
}
[Token(Token = "0x200000C")]
public static class ResonanceAudioRoomManager
{
	[Token(Token = "0x2000127")]
	public enum SurfaceMaterial
	{
		[Token(Token = "0x40005EE")]
		Transparent,
		[Token(Token = "0x40005EF")]
		AcousticCeilingTiles,
		[Token(Token = "0x40005F0")]
		BrickBare,
		[Token(Token = "0x40005F1")]
		BrickPainted,
		[Token(Token = "0x40005F2")]
		ConcreteBlockCoarse,
		[Token(Token = "0x40005F3")]
		ConcreteBlockPainted,
		[Token(Token = "0x40005F4")]
		CurtainHeavy,
		[Token(Token = "0x40005F5")]
		FiberglassInsulation,
		[Token(Token = "0x40005F6")]
		GlassThin,
		[Token(Token = "0x40005F7")]
		GlassThick,
		[Token(Token = "0x40005F8")]
		Grass,
		[Token(Token = "0x40005F9")]
		LinoleumOnConcrete,
		[Token(Token = "0x40005FA")]
		Marble,
		[Token(Token = "0x40005FB")]
		Metal,
		[Token(Token = "0x40005FC")]
		ParquetOnConcrete,
		[Token(Token = "0x40005FD")]
		PlasterRough,
		[Token(Token = "0x40005FE")]
		PlasterSmooth,
		[Token(Token = "0x40005FF")]
		PlywoodPanel,
		[Token(Token = "0x4000600")]
		PolishedConcreteOrTile,
		[Token(Token = "0x4000601")]
		Sheetrock,
		[Token(Token = "0x4000602")]
		WaterOrIceSurface,
		[Token(Token = "0x4000603")]
		WoodCeiling,
		[Token(Token = "0x4000604")]
		WoodPanel
	}

	[Serializable]
	[Token(Token = "0x2000128")]
	public class SurfaceMaterialDictionary : Dictionary<string, SurfaceMaterial>, ISerializationCallbackReceiver
	{
		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<string> guids;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<SurfaceMaterial> surfaceMaterials;

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x9DEC0C", Offset = "0x9DEC0C", VA = "0x9DEC0C")]
		public SurfaceMaterialDictionary()
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x9DECB0", Offset = "0x9DECB0", VA = "0x9DECB0", Slot = "35")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x9DEE20", Offset = "0x9DEE20", VA = "0x9DEE20", Slot = "36")]
		public void OnAfterDeserialize()
		{
		}
	}

	[Token(Token = "0x2000129")]
	private struct RoomEffectsRegion
	{
		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ResonanceAudioRoom room;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ResonanceAudioReverbProbe reverbProbe;

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x9DEAF8", Offset = "0x9DEAF8", VA = "0x9DEAF8")]
		public RoomEffectsRegion(ResonanceAudioRoom room, ResonanceAudioReverbProbe reverbProbe)
		{
		}
	}

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<RoomEffectsRegion> roomEffectsRegions;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Bounds bounds;

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x9DDB10", Offset = "0x9DDB10", VA = "0x9DDB10")]
	public static float ComputeRoomEffectsGain(Vector3 sourcePosition)
	{
		return default(float);
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x9DD804", Offset = "0x9DD804", VA = "0x9DD804")]
	public static void UpdateRoom(ResonanceAudioRoom room)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x9DD8DC", Offset = "0x9DD8DC", VA = "0x9DD8DC")]
	public static void RemoveRoom(ResonanceAudioRoom room)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x9DD238", Offset = "0x9DD238", VA = "0x9DD238")]
	public static void UpdateReverbProbe(ResonanceAudioReverbProbe reverbProbe)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x9DD310", Offset = "0x9DD310", VA = "0x9DD310")]
	public static void RemoveReverbProbe(ResonanceAudioReverbProbe reverbProbe)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x9DE2F0", Offset = "0x9DE2F0", VA = "0x9DE2F0")]
	private static void UpdateRoomEffectsRegions(ResonanceAudioRoom room, bool isEnabled)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x9DE914", Offset = "0x9DE914", VA = "0x9DE914")]
	private static void UpdateRoomEffectsRegions(ResonanceAudioReverbProbe reverbProbe, bool isEnabled)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x9DE4D4", Offset = "0x9DE4D4", VA = "0x9DE4D4")]
	private static void UpdateRoomEffects()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x9DE004", Offset = "0x9DE004", VA = "0x9DE004")]
	private static float ComputeRoomEffectsAttenuation(float distanceToRoom)
	{
		return default(float);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x9DE07C", Offset = "0x9DE07C", VA = "0x9DE07C")]
	private static bool IsListenerInsideRoom(ResonanceAudioRoom room)
	{
		return default(bool);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x9DE63C", Offset = "0x9DE63C", VA = "0x9DE63C")]
	private static bool IsListenerInsideVisibleReverbProbe(ResonanceAudioReverbProbe reverbProbe)
	{
		return default(bool);
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6C22BC", Offset = "0x6C22BC")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6C22BC", Offset = "0x6C22BC")]
[ExecuteInEditMode]
public class ResonanceAudioSource : MonoBehaviour
{
	[Token(Token = "0x200012A")]
	public enum Quality
	{
		[Token(Token = "0x400060A")]
		Stereo,
		[Token(Token = "0x400060B")]
		Low,
		[Token(Token = "0x400060C")]
		High
	}

	[Token(Token = "0x200012B")]
	private enum EffectData
	{
		[Token(Token = "0x400060E")]
		Id,
		[Token(Token = "0x400060F")]
		DistanceAttenuation,
		[Token(Token = "0x4000610")]
		RoomEffectsGain,
		[Token(Token = "0x4000611")]
		Gain,
		[Token(Token = "0x4000612")]
		DirectivityAlpha,
		[Token(Token = "0x4000613")]
		DirectivitySharpness,
		[Token(Token = "0x4000614")]
		ListenerDirectivityAlpha,
		[Token(Token = "0x4000615")]
		ListenerDirectivitySharpness,
		[Token(Token = "0x4000616")]
		Occlusion,
		[Token(Token = "0x4000617")]
		Quality,
		[Token(Token = "0x4000618")]
		NearFieldEffectGain,
		[Token(Token = "0x4000619")]
		Volume
	}

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C37B4", Offset = "0x6C37B4")]
	public bool bypassRoomEffects;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C37EC", Offset = "0x6C37EC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C37EC", Offset = "0x6C37EC")]
	public float directivityAlpha;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C3840", Offset = "0x6C3840")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C3840", Offset = "0x6C3840")]
	public float directivitySharpness;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C3894", Offset = "0x6C3894")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C3894", Offset = "0x6C3894")]
	public float listenerDirectivityAlpha;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C38E8", Offset = "0x6C38E8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C38E8", Offset = "0x6C38E8")]
	public float listenerDirectivitySharpness;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C393C", Offset = "0x6C393C")]
	public float gainDb;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C3974", Offset = "0x6C3974")]
	public bool nearFieldEffectEnabled;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C39AC", Offset = "0x6C39AC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C39AC", Offset = "0x6C39AC")]
	public float nearFieldEffectGain;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C3A00", Offset = "0x6C3A00")]
	public bool occlusionEnabled;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C3A38", Offset = "0x6C3A38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C3A38", Offset = "0x6C3A38")]
	public float occlusionIntensity;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C3A8C", Offset = "0x6C3A8C")]
	public Quality quality;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3AC4", Offset = "0x6C3AC4")]
	private AudioSource <audioSource>k__BackingField;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float currentOcclusion;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float nextOcclusionUpdate;

	[Token(Token = "0x17000009")]
	public AudioSource audioSource
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x9DEF0C", Offset = "0x9DEF0C", VA = "0x9DEF0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C589C", Offset = "0x6C589C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x9DEF14", Offset = "0x9DEF14", VA = "0x9DEF14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C58AC", Offset = "0x6C58AC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x9DEF1C", Offset = "0x9DEF1C", VA = "0x9DEF1C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x9DEF74", Offset = "0x9DEF74", VA = "0x9DEF74")]
	private void Update()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x9DF044", Offset = "0x9DF044", VA = "0x9DF044")]
	private void UpdateSource()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x9DF36C", Offset = "0x9DF36C", VA = "0x9DF36C")]
	public ResonanceAudioSource()
	{
	}
}
[Token(Token = "0x200000E")]
public class Arrow : MonoBehaviour
{
	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float textureSpeed;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float lifeSpan;

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xEFA944", Offset = "0xEFA944", VA = "0xEFA944")]
	private void Update()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xEFAAA4", Offset = "0xEFAAA4", VA = "0xEFAAA4")]
	public Arrow()
	{
	}
}
[Token(Token = "0x200000F")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6C2354", Offset = "0x6C2354")]
public class CursorManager : MonoBehaviour
{
	[Token(Token = "0x200012C")]
	public enum AxisPair
	{
		[Token(Token = "0x400061B")]
		XY,
		[Token(Token = "0x400061C")]
		YZ,
		[Token(Token = "0x400061D")]
		XZ
	}

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CursorManager instance;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6C3AD4", Offset = "0x6C3AD4")]
	public AudioClip clickAudio;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject clickMarker;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject clickEffect;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6C3B0C", Offset = "0x6C3B0C")]
	public int markerLimit;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool limitMarkers;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public List<GameObject> activeMarkers;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool destroyOldestMarker;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6C3B54", Offset = "0x6C3B54")]
	public bool hideMouseCursor;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public AxisPair axisPair;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform effectContainer;

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xC14384", Offset = "0xC14384", VA = "0xC14384")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xC144AC", Offset = "0xC144AC", VA = "0xC144AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xC144EC", Offset = "0xC144EC", VA = "0xC144EC")]
	private void Update()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xC14764", Offset = "0xC14764", VA = "0xC14764")]
	public void GenerateMarker()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xC14AA0", Offset = "0xC14AA0", VA = "0xC14AA0")]
	public CursorManager()
	{
	}
}
[Token(Token = "0x2000010")]
public class DestroyEmpty : MonoBehaviour
{
	[Token(Token = "0x600007C")]
	[Address(RVA = "0xC14AB0", Offset = "0xC14AB0", VA = "0xC14AB0")]
	private void Update()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xC14B58", Offset = "0xC14B58", VA = "0xC14B58")]
	public DestroyEmpty()
	{
	}
}
[Token(Token = "0x2000011")]
public class MarkerBehaviour : MonoBehaviour
{
	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool canSpin;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float spinRate;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float currentScale;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float initialScale;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool canScale;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float scalePulseAmount;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float scalePulseSpeed;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool isShrinking;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float shrinkScale;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float scaleThreshold;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float markerLifespan;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float shrinkRate;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float timer;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float markerTimer;

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xE6FEE8", Offset = "0xE6FEE8", VA = "0xE6FEE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xE6FF2C", Offset = "0xE6FF2C", VA = "0xE6FF2C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xE70214", Offset = "0xE70214", VA = "0xE70214")]
	public MarkerBehaviour()
	{
	}
}
[Token(Token = "0x2000012")]
public class Spinner : MonoBehaviour
{
	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float spinRate;

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x9723D8", Offset = "0x9723D8", VA = "0x9723D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x972430", Offset = "0x972430", VA = "0x972430")]
	public Spinner()
	{
	}
}
[Token(Token = "0x2000013")]
public class BonesOnlyBlendSystem : BlendSystem
{
	[Token(Token = "0x6000083")]
	[Address(RVA = "0xC107F8", Offset = "0xC107F8", VA = "0xC107F8", Slot = "6")]
	public override void OnVariableChanged()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xC10804", Offset = "0xC10804", VA = "0xC10804")]
	public BonesOnlyBlendSystem()
	{
	}
}
[Serializable]
[Token(Token = "0x2000014")]
public class GestureInstance
{
	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string gesture;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public AnimationClip clip;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string triggerName;

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xC249DC", Offset = "0xC249DC", VA = "0xC249DC")]
	public GestureInstance(string gesture, AnimationClip clip, string triggerName)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xC24A1C", Offset = "0xC24A1C", VA = "0xC24A1C")]
	public bool IsValid(Animator animator)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000015")]
public class LogicArcsAndColumns : MonoBehaviour
{
	[Token(Token = "0x6000087")]
	[Address(RVA = "0xE6D990", Offset = "0xE6D990", VA = "0xE6D990")]
	private void Start()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xE6D994", Offset = "0xE6D994", VA = "0xE6D994")]
	private void Update()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xE6D998", Offset = "0xE6D998", VA = "0xE6D998")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xE6E2EC", Offset = "0xE6E2EC", VA = "0xE6E2EC")]
	public LogicArcsAndColumns()
	{
	}
}
[Token(Token = "0x2000016")]
public class LogicCollidingSphere : MonoBehaviour
{
	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Rigidbody ObjectToDrop;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool bDropped;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int nChunksDetached;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int nChunkCollisions;

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xE6E2F4", Offset = "0xE6E2F4", VA = "0xE6E2F4")]
	private void Start()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xE6E2FC", Offset = "0xE6E2FC", VA = "0xE6E2FC")]
	private void Update()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xE6E364", Offset = "0xE6E364", VA = "0xE6E364")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xE6EB88", Offset = "0xE6EB88", VA = "0xE6EB88")]
	private void OnChunkDetach(FracturedChunk.CollisionInfo info)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xE6EBAC", Offset = "0xE6EBAC", VA = "0xE6EBAC")]
	private void OnFreeChunkCollision(FracturedChunk.CollisionInfo info)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xE6EBD0", Offset = "0xE6EBD0", VA = "0xE6EBD0")]
	public LogicCollidingSphere()
	{
	}
}
[Token(Token = "0x2000017")]
public class LogicCompoundObject : MonoBehaviour
{
	[Token(Token = "0x6000091")]
	[Address(RVA = "0xE6EBD8", Offset = "0xE6EBD8", VA = "0xE6EBD8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xE6F398", Offset = "0xE6F398", VA = "0xE6F398")]
	public LogicCompoundObject()
	{
	}
}
[Token(Token = "0x2000018")]
public class LogicExplodingFloor : MonoBehaviour
{
	[Token(Token = "0x6000093")]
	[Address(RVA = "0xE6F3A0", Offset = "0xE6F3A0", VA = "0xE6F3A0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xE6F770", Offset = "0xE6F770", VA = "0xE6F770")]
	public LogicExplodingFloor()
	{
	}
}
[Token(Token = "0x2000019")]
public class LogicExplodingGoblin : MonoBehaviour
{
	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float ExplosionForce;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FracturedObject TargetFracturedObject;

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xE6F778", Offset = "0xE6F778", VA = "0xE6F778")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xE6FD14", Offset = "0xE6FD14", VA = "0xE6FD14")]
	public LogicExplodingGoblin()
	{
	}
}
[Token(Token = "0x200001A")]
public class LogicGlobalFracturing : MonoBehaviour
{
	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[HideInInspector]
	public static bool HelpVisible;

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xE6FD24", Offset = "0xE6FD24", VA = "0xE6FD24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xE6E034", Offset = "0xE6E034", VA = "0xE6E034")]
	public static void GlobalGUI()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xE6FD90", Offset = "0xE6FD90", VA = "0xE6FD90")]
	private void Update()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xE6FE8C", Offset = "0xE6FE8C", VA = "0xE6FE8C")]
	public LogicGlobalFracturing()
	{
	}
}
[Token(Token = "0x200001B")]
public class UltimateFracturingFPS : MonoBehaviour
{
	[Token(Token = "0x200012D")]
	public enum Mode
	{
		[Token(Token = "0x400061F")]
		ShootObjects,
		[Token(Token = "0x4000620")]
		ExplodeRaycast
	}

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mode ShootMode;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float MouseSpeed;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture HUDTexture;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float HUDSize;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color HUDColorNormal;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Color HUDColorRaycast;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform Weapon;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioClip AudioWeaponShot;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float WeaponShotVolume;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float ExplosionForce;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float ExplosionRadius;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float RecoilDuration;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float RecoilIntensity;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject ObjectToShoot;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float InitialObjectSpeed;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float ObjectScale;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float ObjectMass;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float ObjectLife;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 m_v3MousePosition;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private bool m_bRaycastFound;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float m_fRecoilTimer;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Vector3 m_v3InitialWeaponPos;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Quaternion m_qInitialWeaponRot;

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xF6E9E0", Offset = "0xF6E9E0", VA = "0xF6E9E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xF6EAA0", Offset = "0xF6EAA0", VA = "0xF6EAA0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xF6ECEC", Offset = "0xF6ECEC", VA = "0xF6ECEC")]
	private void Update()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xF6F48C", Offset = "0xF6F48C", VA = "0xF6F48C")]
	public UltimateFracturingFPS()
	{
	}
}
[Token(Token = "0x200001C")]
public class CheckDynamicCollision : MonoBehaviour
{
	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xC1080C", Offset = "0xC1080C", VA = "0xC1080C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xC10B00", Offset = "0xC10B00", VA = "0xC10B00")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xC109E0", Offset = "0xC109E0", VA = "0xC109E0")]
	private void EnableObjectColliders(GameObject chunk, bool bEnable)
	{
	}

	[Token(Token = "0x60000A3")]
	private static void SearchForAllComponentsInHierarchy<T>(GameObject current, ref List<T> listOut) where T : Component
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xC1125C", Offset = "0xC1125C", VA = "0xC1125C")]
	public CheckDynamicCollision()
	{
	}
}
[Token(Token = "0x200001D")]
public class ExplosionSource : MonoBehaviour
{
	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float InfluenceRadius;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float Force;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool CheckStructureIntegrity;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool MoveManually;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 PosStart;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 PosEnd;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float MoveDuration;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private FracturedObject[] m_aFracturedObjects;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float m_fStartTime;

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xC14B60", Offset = "0xC14B60", VA = "0xC14B60")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xC14C2C", Offset = "0xC14C2C", VA = "0xC14C2C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xC152A8", Offset = "0xC152A8", VA = "0xC152A8")]
	public ExplosionSource()
	{
	}
}
[Serializable]
[Token(Token = "0x200001E")]
[ExecuteInEditMode]
public class FracturedChunk : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200012E")]
	public class AdjacencyInfo
	{
		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FracturedChunk chunk;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float fArea;

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xC2131C", Offset = "0xC2131C", VA = "0xC2131C")]
		public AdjacencyInfo(FracturedChunk chunk, float fArea)
		{
		}
	}

	[Token(Token = "0x200012F")]
	public class CollisionInfo
	{
		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FracturedChunk chunk;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 collisionPoint;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool bIsMain;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool bCancelCollisionEvent;

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xC1FC68", Offset = "0xC1FC68", VA = "0xC1FC68")]
		public CollisionInfo(FracturedChunk chunk, Vector3 collisionPoint, bool bIsMain)
		{
		}
	}

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FracturedObject FracturedObjectSource;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int SplitSubMeshIndex;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool DontDeleteAfterBroken;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool IsSupportChunk;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool IsNonSupportedChunk;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
	public bool IsDetachedChunk;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float RelativeVolume;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float Volume;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool HasConcaveCollider;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float PreviewDecompositionValue;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color RandomMaterialColor;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool Visited;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<AdjacencyInfo> ListAdjacentChunks;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Vector3 m_v3InitialLocalPosition;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private Quaternion m_qInitialLocalRotation;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	private Vector3 m_v3InitialLocalScale;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private bool m_bInitialLocalRotScaleInitialized;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<AdjacencyInfo> ListAdjacentChunksCopy;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float m_fInvisibleTimer;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool m_bNonSupportedChunkStored;

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xC1EF80", Offset = "0xC1EF80", VA = "0xC1EF80")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xC1F080", Offset = "0xC1F080", VA = "0xC1F080")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xC1F1BC", Offset = "0xC1F1BC", VA = "0xC1F1BC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xC1FA4C", Offset = "0xC1FA4C", VA = "0xC1FA4C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xC1F2A4", Offset = "0xC1F2A4", VA = "0xC1F2A4")]
	private void HandleCollision(Collider other, Vector3 v3CollisionPos, float relativeSpeed)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xC1FBC8", Offset = "0xC1FBC8", VA = "0xC1FBC8")]
	public bool IsDestructibleChunk()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xC20420", Offset = "0xC20420", VA = "0xC20420")]
	public void ResetChunk(FracturedObject fracturedObjectSource)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xC20598", Offset = "0xC20598", VA = "0xC20598")]
	public void Impact(Vector3 v3Position, float fExplosionForce, float fRadius, bool bAlsoImpactFreeChunks)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xC20DB0", Offset = "0xC20DB0", VA = "0xC20DB0")]
	public void OnCreateFromFracturedObject(FracturedObject fracturedComponent, int nSplitSubMeshIndex)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xC20E9C", Offset = "0xC20E9C", VA = "0xC20E9C")]
	public void UpdatePreviewDecompositionPosition()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xC21004", Offset = "0xC21004", VA = "0xC21004")]
	public void ConnectTo(FracturedChunk chunk, float fArea)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xC21358", Offset = "0xC21358", VA = "0xC21358")]
	public void DisconnectFrom(FracturedChunk chunk)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xC21138", Offset = "0xC21138", VA = "0xC21138")]
	public bool IsConnectedTo(FracturedChunk chunk)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xC1FE74", Offset = "0xC1FE74", VA = "0xC1FE74")]
	public void DetachFromObject(bool bCheckStructureIntegrity = true)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xC2152C", Offset = "0xC2152C", VA = "0xC2152C")]
	private void RemoveConnectionInfo()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xC1FDAC", Offset = "0xC1FDAC", VA = "0xC1FDAC")]
	public List<FracturedChunk> ComputeRandomConnectionBreaks()
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xC21B84", Offset = "0xC21B84", VA = "0xC21B84")]
	private static void ComputeRandomConnectionBreaksRecursive(FracturedChunk chunk, List<FracturedChunk> listBreaksOut, int nLevel)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xC21DE8", Offset = "0xC21DE8", VA = "0xC21DE8")]
	public static FracturedChunk ChunkRaycast(Vector3 v3Pos, Vector3 v3Forward, out RaycastHit hitInfo)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xC21F7C", Offset = "0xC21F7C", VA = "0xC21F7C")]
	public FracturedChunk()
	{
	}
}
[Token(Token = "0x200001F")]
[ExecuteInEditMode]
public class FracturedObject : MonoBehaviour
{
	[Token(Token = "0x2000130")]
	public enum EFracturePattern
	{
		[Token(Token = "0x4000628")]
		BSP,
		[Token(Token = "0x4000629")]
		Voronoi
	}

	[Serializable]
	[Token(Token = "0x2000131")]
	public class PrefabInfo
	{
		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float MinLifeTime;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float MaxLifeTime;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject GameObject;

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xC2499C", Offset = "0xC2499C", VA = "0xC2499C")]
		public PrefabInfo()
		{
		}
	}

	[Token(Token = "0x2000132")]
	public enum ECCAlgorithm
	{
		[Token(Token = "0x400062E")]
		Fast,
		[Token(Token = "0x400062F")]
		Normal,
		[Token(Token = "0x4000630")]
		Legacy
	}

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool GUIExpandMain;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject SourceObject;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool GenerateIslands;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool GenerateChunkConnectionInfo;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool StartStatic;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float ChunkConnectionMinArea;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float ChunkConnectionStrength;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float ChunkHorizontalRadiusSupportStrength;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool SupportChunksAreIndestructible;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float ChunkIslandConnectionMaxDistance;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float TotalMass;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public PhysicMaterial ChunkPhysicMaterial;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float MinColliderVolumeForBox;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float CapPrecisionFix;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool InvertCapNormals;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool GUIExpandSplits;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public EFracturePattern FracturePattern;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool VoronoiVolumeOptimization;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool VoronoiProximityOptimization;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	public bool VoronoiMultithreading;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int VoronoiCellsXCount;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int VoronoiCellsYCount;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int VoronoiCellsZCount;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float VoronoiCellsXSizeVariation;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float VoronoiCellsYSizeVariation;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float VoronoiCellsZSizeVariation;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public int GenerateNumChunks;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool SplitsWorldSpace;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	public bool SplitRegularly;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float SplitXProbability;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float SplitYProbability;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float SplitZProbability;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float SplitSizeVariation;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float SplitXVariation;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float SplitYVariation;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float SplitZVariation;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Material SplitMaterial;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float SplitMappingTileU;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float SplitMappingTileV;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public bool GUIExpandEvents;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float EventDetachMinMass;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float EventDetachMinVelocity;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public float EventDetachExitForce;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float EventDetachUpwardsModifier;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public AudioClip EventDetachSound;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public PrefabInfo[] EventDetachPrefabsArray;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public string EventDetachCollisionCallMethod;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public GameObject EventDetachCollisionCallGameObject;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public float EventDetachedMinLifeTime;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public float EventDetachedMaxLifeTime;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public float EventDetachedOffscreenLifeTime;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public float EventDetachedMinMass;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float EventDetachedMinVelocity;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public int EventDetachedMaxSounds;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public AudioClip[] EventDetachedSoundArray;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public int EventDetachedMaxPrefabs;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public PrefabInfo[] EventDetachedPrefabsArray;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public string EventDetachedCollisionCallMethod;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public GameObject EventDetachedCollisionCallGameObject;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public AudioClip EventExplosionSound;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public int EventExplosionPrefabsInstanceCount;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public PrefabInfo[] EventExplosionPrefabsArray;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public AudioClip EventImpactSound;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public PrefabInfo[] EventImpactPrefabsArray;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public string EventDetachedAnyCallMethod;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public GameObject EventDetachedAnyCallGameObject;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public bool GUIExpandSupportPlanes;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	public int RandomSeed;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public float DecomposePreview;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	public bool AlwaysComputeColliders;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
	public bool ShowChunkConnectionLines;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16E")]
	public bool ShowChunkColoredState;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16F")]
	public bool ShowChunkColoredRandomly;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public bool SaveMeshDataToAsset;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public string MeshAssetDataFile;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public bool Verbose;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
	public bool IntegrateWithConcaveCollider;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	public ECCAlgorithm ConcaveColliderAlgorithm;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public int ConcaveColliderMaxHulls;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	public int ConcaveColliderMaxHullVertices;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public int ConcaveColliderLegacySteps;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[HideInInspector]
	public List<SupportPlane> ListSupportPlanes;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	[HideInInspector]
	public List<FracturedChunk> ListFracturedChunks;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[HideInInspector]
	public GameObject SingleMeshObject;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	[HideInInspector]
	public bool IsUsingSingleMeshObjectDraw;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	[HideInInspector]
	public float DecomposeRadius;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Color GizmoColorSupport;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Color GizmoColorNonSupport;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private bool m_bCheckDetachNonSupportedChunkds;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
	private bool m_bExploded;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
	private bool m_bDetached;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private float[] m_afFreeChunkSoundTimers;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private float[] m_afFreeChunkPrefabTimers;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private Material m_GizmosMaterial;

	[Token(Token = "0x1700000A")]
	public Material GizmosMaterial
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xC22010", Offset = "0xC22010", VA = "0xC22010")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xC220DC", Offset = "0xC220DC", VA = "0xC220DC")]
		set
		{
		}
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xC220E4", Offset = "0xC220E4", VA = "0xC220E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xC220E8", Offset = "0xC220E8", VA = "0xC220E8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xC22508", Offset = "0xC22508", VA = "0xC22508")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xC22EDC", Offset = "0xC22EDC", VA = "0xC22EDC")]
	private void OnRenderObject()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xC22EE0", Offset = "0xC22EE0", VA = "0xC22EE0")]
	public void OnCreateFracturedObject()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xC22318", Offset = "0xC22318", VA = "0xC22318")]
	public void SetSingleMeshVisibility(bool bEnabled)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xC22FC4", Offset = "0xC22FC4", VA = "0xC22FC4")]
	public bool ResetChunks()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xC2090C", Offset = "0xC2090C", VA = "0xC2090C")]
	public List<FracturedChunk> GetDestructibleChunksInRadius(Vector3 v3Position, float fRadius, bool bAlsoIncludeFreeChunks)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xC10DCC", Offset = "0xC10DCC", VA = "0xC10DCC")]
	public void Explode(Vector3 v3ExplosionPosition, float fExplosionForce)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xC14DE0", Offset = "0xC14DE0", VA = "0xC14DE0")]
	public void Explode(Vector3 v3ExplosionPosition, float fExplosionForce, float fRadius, bool bPlayExplosionSound, bool bInstanceExplosionPrefabs, bool bAlsoExplodeFree, bool bCheckStructureIntegrityAfter)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xC231E0", Offset = "0xC231E0", VA = "0xC231E0")]
	public void DeleteChunks()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xC233C0", Offset = "0xC233C0", VA = "0xC233C0")]
	public void CollapseChunks()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xC23548", Offset = "0xC23548", VA = "0xC23548")]
	public void ExplodeChunks(float fExplosionForce, Vector3 v3ExplosionPosition, float fUpwardsModifier)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xC2374C", Offset = "0xC2374C", VA = "0xC2374C")]
	public void ComputeChunksRelativeVolume()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xC23C28", Offset = "0xC23C28", VA = "0xC23C28")]
	public void ComputeChunksMass(float fTotalMass)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xC23E04", Offset = "0xC23E04", VA = "0xC23E04")]
	public bool HasDetachedChunks()
	{
		return default(bool);
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xC21808", Offset = "0xC21808", VA = "0xC21808")]
	public void NotifyChunkDetach(FracturedChunk chunk)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xC1FCD0", Offset = "0xC1FCD0", VA = "0xC1FCD0")]
	public void NotifyDetachChunkCollision(FracturedChunk.CollisionInfo collisionInfo)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xC23E0C", Offset = "0xC23E0C", VA = "0xC23E0C")]
	public void NotifyDetachChunkCollision(Vector3 v3Position, bool bIsMain)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xC20064", Offset = "0xC20064", VA = "0xC20064")]
	public void NotifyFreeChunkCollision(FracturedChunk.CollisionInfo collisionInfo)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xC20B90", Offset = "0xC20B90", VA = "0xC20B90")]
	public void NotifyImpact(Vector3 v3Position)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xC21A54", Offset = "0xC21A54", VA = "0xC21A54")]
	public void ResetAllChunkVisitedFlags()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xC21A3C", Offset = "0xC21A3C", VA = "0xC21A3C")]
	public void CheckDetachNonSupportedChunks(bool bForceImmediate = false)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xC24038", Offset = "0xC24038", VA = "0xC24038")]
	public void MarkNonSupportedChunks()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xC22688", Offset = "0xC22688", VA = "0xC22688")]
	private void CheckDetachNonSupportedChunksInternal(bool bOnlyMarkThem = false)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xC24174", Offset = "0xC24174", VA = "0xC24174")]
	private static bool AreSupportedChunksRecursive(FracturedChunk chunk, List<FracturedChunk> listChunksVisited, List<FracturedChunk> listChunksSupport)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xC243F0", Offset = "0xC243F0", VA = "0xC243F0")]
	public void AddSupportPlane()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xC244A4", Offset = "0xC244A4", VA = "0xC244A4")]
	public void ComputeSupportPlaneIntersections()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xC2473C", Offset = "0xC2473C", VA = "0xC2473C")]
	public FracturedObject()
	{
	}
}
[Token(Token = "0x2000020")]
public class CombinedMesh : MonoBehaviour
{
	[Token(Token = "0x2000133")]
	public delegate void CombineProgressDelegate(string strMessage, float fT);

	[Serializable]
	[Token(Token = "0x2000134")]
	public class ObjectInfo
	{
		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material[] aMaterials;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mesh mesh;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 v3LocalPosition;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Quaternion qLocalRotation;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 v3LocalScale;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Matrix4x4 mtxLocal;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Matrix4x4 mtxWorld;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Vector3[] av3NormalsWorld;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector4[] av4TangentsWorld;

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xC13F58", Offset = "0xC13F58", VA = "0xC13F58")]
		public ObjectInfo(Material[] aMaterials, Mesh mesh, Transform transform, Matrix4x4 mtxLocal)
		{
		}
	}

	[Token(Token = "0x2000135")]
	private class MaterialMeshInfo
	{
		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mesh mesh;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int nSubMesh;

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xC13F18", Offset = "0xC13F18", VA = "0xC13F18")]
		public MaterialMeshInfo(Transform transform, Mesh mesh, int nSubMesh)
		{
		}
	}

	[Token(Token = "0x2000136")]
	public enum EPivotMode
	{
		[Token(Token = "0x400063E")]
		Keep,
		[Token(Token = "0x400063F")]
		Center,
		[Token(Token = "0x4000640")]
		BottomCenter,
		[Token(Token = "0x4000641")]
		TopCenter,
		[Token(Token = "0x4000642")]
		Min,
		[Token(Token = "0x4000643")]
		Max
	}

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool SaveMeshAsset;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool KeepPosition;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public EPivotMode PivotMode;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter[] MeshObjects;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject RootNode;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool m_bCancelled;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<ObjectInfo> m_listObjectInfo;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<Material, List<MaterialMeshInfo>> m_dicMeshEntries;

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xC11264", Offset = "0xC11264", VA = "0xC11264")]
	public void CancelCombining()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xC11270", Offset = "0xC11270", VA = "0xC11270")]
	public bool CombiningCancelled()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xC11278", Offset = "0xC11278", VA = "0xC11278")]
	public void TransformObjInfoMeshVectorsToLocal(Transform newTransform)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xC11628", Offset = "0xC11628", VA = "0xC11628")]
	public int GetObjectCount()
	{
		return default(int);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xC11678", Offset = "0xC11678", VA = "0xC11678")]
	public ObjectInfo GetObjectInfo(int nIndex)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xC116F0", Offset = "0xC116F0", VA = "0xC116F0")]
	public void Combine(CombineProgressDelegate progress)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xC14228", Offset = "0xC14228", VA = "0xC14228")]
	public CombinedMesh()
	{
	}
}
[Token(Token = "0x2000021")]
public class popup : MonoBehaviour
{
	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Rigidbody rb;

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xF77700", Offset = "0xF77700", VA = "0xF77700")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xF77758", Offset = "0xF77758", VA = "0xF77758")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xF7786C", Offset = "0xF7786C", VA = "0xF7786C")]
	public popup()
	{
	}
}
[Token(Token = "0x2000022")]
public class FlickerCandleLight : MonoBehaviour
{
	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light candleLight;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float flickerSpeed;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float maxLightIntensity;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float xPosition;

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xC1EE94", Offset = "0xC1EE94", VA = "0xC1EE94")]
	private void FlickerLight(Light candleLight)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xC1EF58", Offset = "0xC1EF58", VA = "0xC1EF58")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xC1EF60", Offset = "0xC1EF60", VA = "0xC1EF60")]
	public FlickerCandleLight()
	{
	}
}
[Token(Token = "0x2000023")]
public class sceneSwitch : MonoBehaviour
{
	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xF77874", Offset = "0xF77874", VA = "0xF77874")]
	public sceneSwitch()
	{
	}
}
[Token(Token = "0x2000024")]
public class test : StateMachineBehaviour
{
	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xF7787C", Offset = "0xF7787C", VA = "0xF7787C")]
	public test()
	{
	}
}
namespace UltimateFracturing
{
	[Token(Token = "0x2000025")]
	public static class ConcaveColliderInterface
	{
		[Token(Token = "0x2000137")]
		private struct SConvexDecompositionInfoInOut
		{
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint uMaxHullVertices;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint uMaxHulls;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float fPrecision;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float fBackFaceDistanceFactor;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint uLegacyDepth;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint uNormalizeInputMesh;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint uUseFastVersion;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public uint uTriangleCount;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint uVertexCount;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int nHullsOut;
		}

		[Token(Token = "0x2000138")]
		private struct SConvexDecompositionHullInfo
		{
			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int nVertexCount;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int nTriangleCount;
		}

		[Token(Token = "0x2000139")]
		public delegate void LogDelegate(string message);

		[PreserveSig]
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x9724F0", Offset = "0x9724F0", VA = "0x9724F0")]
		private static extern void DllInit(bool bUseMultithreading);

		[PreserveSig]
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x972570", Offset = "0x972570", VA = "0x972570")]
		private static extern void DllClose();

		[PreserveSig]
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x9725E0", Offset = "0x9725E0", VA = "0x9725E0")]
		private static extern void SetLogFunctionPointer(IntPtr pfnUnity3DLog);

		[PreserveSig]
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x972660", Offset = "0x972660", VA = "0x972660")]
		private static extern void SetProgressFunctionPointer(IntPtr pfnUnity3DProgress);

		[PreserveSig]
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x9726E0", Offset = "0x9726E0", VA = "0x9726E0")]
		private static extern void CancelConvexDecomposition();

		[PreserveSig]
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x972750", Offset = "0x972750", VA = "0x972750")]
		private static extern bool DoConvexDecomposition(ref SConvexDecompositionInfoInOut infoInOut, Vector3[] pfVertices, int[] puIndices);

		[PreserveSig]
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x972800", Offset = "0x972800", VA = "0x972800")]
		private static extern bool GetHullInfo(uint uHullIndex, ref SConvexDecompositionHullInfo infoOut);

		[PreserveSig]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x972898", Offset = "0x972898", VA = "0x972898")]
		private static extern bool FillHullMeshData(uint uHullIndex, ref float pfVolumeOut, int[] pnIndicesOut, Vector3[] pfVerticesOut);

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x972958", Offset = "0x972958", VA = "0x972958")]
		public static int ComputeHull(GameObject gameObject, FracturedObject fracturedObject)
		{
			return default(int);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x972AD4", Offset = "0x972AD4", VA = "0x972AD4")]
		private static bool ComputeHull(GameObject gameObject, FracturedObject.ECCAlgorithm eAlgorithm, int nMaxHulls, int nMaxHullVertices, int nLegacySteps, bool bVerbose, out int nTotalTrianglesOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x973138", Offset = "0x973138", VA = "0x973138")]
		private static void Log(string message)
		{
		}
	}
	[Token(Token = "0x2000026")]
	public static class Fracturer
	{
		[Token(Token = "0x200013A")]
		private class FracturingStats
		{
			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int nChunkCount;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int nTotalChunks;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int nSplitCount;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool bCancelFracturing;

			[Token(Token = "0x6000918")]
			[Address(RVA = "0xF647C0", Offset = "0xF647C0", VA = "0xF647C0")]
			public FracturingStats()
			{
			}
		}

		[Token(Token = "0x200013B")]
		private class VoronoiCell
		{
			[Token(Token = "0x20001A0")]
			public class Face
			{
				[Token(Token = "0x400075D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Plane plane;

				[Token(Token = "0x400075E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Matrix4x4 mtxPlane;

				[Token(Token = "0x400075F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				public int nAdjacentCell;

				[Token(Token = "0x6000A38")]
				[Address(RVA = "0xF6588C", Offset = "0xF6588C", VA = "0xF6588C")]
				public Face(Plane plane, Matrix4x4 mtxPlane, int nAdjacentCell)
				{
				}
			}

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int nIndex;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int x;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int y;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int z;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 v3Center;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 v3Min;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 v3Max;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<Face> listCellFaces;

			[Token(Token = "0x6000919")]
			[Address(RVA = "0xF657C0", Offset = "0xF657C0", VA = "0xF657C0")]
			public VoronoiCell(int nIndex, int x, int y, int z)
			{
			}
		}

		[Token(Token = "0x200013C")]
		private class VoronoiPointDistance
		{
			[Token(Token = "0x20001A1")]
			public class IncreasingDistanceComparer : IComparer<VoronoiPointDistance>
			{
				[Token(Token = "0x6000A39")]
				[Address(RVA = "0xF659E8", Offset = "0xF659E8", VA = "0xF659E8", Slot = "4")]
				public int Compare(VoronoiPointDistance a, VoronoiPointDistance b)
				{
					return default(int);
				}

				[Token(Token = "0x6000A3A")]
				[Address(RVA = "0xF65A1C", Offset = "0xF65A1C", VA = "0xF65A1C")]
				public IncreasingDistanceComparer()
				{
				}
			}

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int nIndex;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float fDistanceSqr;

			[Token(Token = "0x600091A")]
			[Address(RVA = "0xF659AC", Offset = "0xF659AC", VA = "0xF659AC")]
			public VoronoiPointDistance(int nIndex, float fDistanceSqr)
			{
			}
		}

		[Token(Token = "0x200013D")]
		public struct VoronoiCellKey
		{
			[Token(Token = "0x20001A2")]
			public class EqualityComparer : IEqualityComparer<VoronoiCellKey>
			{
				[Token(Token = "0x6000A3B")]
				[Address(RVA = "0xF65908", Offset = "0xF65908", VA = "0xF65908", Slot = "4")]
				public bool Equals(VoronoiCellKey x, VoronoiCellKey y)
				{
					return default(bool);
				}

				[Token(Token = "0x6000A3C")]
				[Address(RVA = "0xF65938", Offset = "0xF65938", VA = "0xF65938", Slot = "5")]
				public int GetHashCode(VoronoiCellKey x)
				{
					return default(int);
				}

				[Token(Token = "0x6000A3D")]
				[Address(RVA = "0xF659A4", Offset = "0xF659A4", VA = "0xF659A4")]
				public EqualityComparer()
				{
				}
			}

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;

			[Token(Token = "0x600091B")]
			[Address(RVA = "0xF658FC", Offset = "0xF658FC", VA = "0xF658FC")]
			public VoronoiCellKey(int x, int y, int z)
			{
			}
		}

		[Token(Token = "0x200013E")]
		private class VoronoiThreadData
		{
			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<VoronoiCell> listVoronoiCells;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MeshData meshDataCube;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<MeshData> listMeshDatasObject;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MeshData> listMeshDatasChunks;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SpaceTreeNode spaceTree;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public FracturedObject fracturedComponent;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int nCurrentCell;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public int nTotalCells;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int nCellsProcessed;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public ProgressDelegate progress;

			[Token(Token = "0x600091C")]
			[Address(RVA = "0xF65A24", Offset = "0xF65A24", VA = "0xF65A24")]
			public VoronoiThreadData()
			{
			}
		}

		[Token(Token = "0x200013F")]
		public delegate void ProgressDelegate(string strTitle, string message, float fT);

		[Token(Token = "0x2000140")]
		private class SpaceTreeNode
		{
			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private SpaceTreeNode nodeOneSide;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private SpaceTreeNode nodeOtherSide;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int nLevel;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int nSplitsX;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int nSplitsY;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int nSplitsZ;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 v3Min;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 v3Max;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<MeshData> listMeshDatasSpace;

			[Token(Token = "0x6000921")]
			[Address(RVA = "0xF64CBC", Offset = "0xF64CBC", VA = "0xF64CBC")]
			public SpaceTreeNode()
			{
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0xF64D38", Offset = "0xF64D38", VA = "0xF64D38")]
			public bool ContainsCompletely(Vector3 v3Min, Vector3 v3Max)
			{
				return default(bool);
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0xF64DA8", Offset = "0xF64DA8", VA = "0xF64DA8")]
			public static List<MeshData> GetSmallestPossibleMeshData(SpaceTreeNode root, Vector3 v3Min, Vector3 v3Max)
			{
				return null;
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0xF64E6C", Offset = "0xF64E6C", VA = "0xF64E6C")]
			public static SpaceTreeNode BuildSpaceTree(MeshData meshDataIn, int nSubdivisionLevels, FracturedObject fracturedComponent, [Optional] ProgressDelegate progress)
			{
				return null;
			}
		}

		[Token(Token = "0x2000141")]
		public class SplitOptions
		{
			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static SplitOptions Default;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool bForceNoProgressInfo;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool bForceNoIslandGeneration;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			public bool bForceNoChunkConnectionInfo;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
			public bool bForceNoIslandConnectionInfo;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool bForceNoCap;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			public bool bForceCapVertexSoup;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			public bool bIgnoreNegativeSide;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
			public bool bVerticesAreLocal;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int nForceMeshConnectivityHash;

			[Token(Token = "0x6000925")]
			[Address(RVA = "0xF65720", Offset = "0xF65720", VA = "0xF65720")]
			public SplitOptions()
			{
			}
		}

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FracturingStats s_FracturingStats;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VoronoiThreadData s_VoronoiThreadData;

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x9737DC", Offset = "0x9737DC", VA = "0x9737DC")]
		public static void CancelFracturing()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x9738E0", Offset = "0x9738E0", VA = "0x9738E0")]
		public static bool IsFracturingCancelled()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x9739F0", Offset = "0x9739F0", VA = "0x9739F0")]
		public static bool FractureToChunks(FracturedObject fracturedComponent, bool bPositionOnSourceAndHideOriginal, out List<GameObject> listGameObjectsOut, [Optional] ProgressDelegate progress)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x974038", Offset = "0x974038", VA = "0x974038")]
		private static Mesh CopyMesh(MeshFilter meshfIn)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x974444", Offset = "0x974444", VA = "0x974444")]
		private static bool FractureToChunksBSP(FracturedObject fracturedComponent, bool bPositionOnSourceAndHideOriginal, out List<GameObject> listGameObjectsOut, [Optional] ProgressDelegate progress)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x975DC8", Offset = "0x975DC8", VA = "0x975DC8")]
		private static bool FractureToChunksVoronoi(FracturedObject fracturedComponent, bool bPositionOnSourceAndHideOriginal, out List<GameObject> listGameObjectsOut, [Optional] ProgressDelegate progress)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x98338C", Offset = "0x98338C", VA = "0x98338C")]
		public static void ThreadVoronoiComputePlaneDependencies()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x98412C", Offset = "0x98412C", VA = "0x98412C")]
		public static void ThreadVoronoiComputeCells()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x978C04", Offset = "0x978C04", VA = "0x978C04")]
		public static List<MeshData> ComputeMeshDataIslands(MeshData meshDataIn, bool bVerticesAreLocal, FracturedObject fracturedComponent, ProgressDelegate progress)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x98291C", Offset = "0x98291C", VA = "0x98291C")]
		public static void ComputeChunkColliders(FracturedObject fracturedComponent, ProgressDelegate progress)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x985374", Offset = "0x985374", VA = "0x985374")]
		public static void DeleteChunkColliders(FracturedObject fracturedComponent)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x97A168", Offset = "0x97A168", VA = "0x97A168")]
		private static Matrix4x4 GetRandomPlaneSplitMatrix(MeshData meshDataIn, FracturedObject fracturedComponent, out int nSplitAxisPerformed)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x98227C", Offset = "0x98227C", VA = "0x98227C")]
		private static GameObject CreateNewSplitGameObject(GameObject gameObjectIn, FracturedObject fracturedComponent, string strName, bool bTransformVerticesBackToLocal, MeshData meshData)
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x984FF4", Offset = "0x984FF4", VA = "0x984FF4")]
		private static int CreateMeshConnectivityVoronoiHash(int nCell1, int nCell2)
		{
			return default(int);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x982648", Offset = "0x982648", VA = "0x982648")]
		private static void ComputeChunkConnections(FracturedObject fracturedObject, List<GameObject> listGameObjects, List<MeshData> listMeshDatas, [Optional] ProgressDelegate progress)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x985094", Offset = "0x985094", VA = "0x985094")]
		private static void RemoveEmptySubmeshes(FracturedChunk fracturedChunk)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x985634", Offset = "0x985634", VA = "0x985634")]
		public static bool SplitMeshUsingPlane(GameObject gameObjectIn, FracturedObject fracturedComponent, SplitOptions splitOptions, Transform transformPlaneSplit, out List<GameObject> listGameObjectsPosOut, out List<GameObject> listGameObjectsNegOut, [Optional] ProgressDelegate progress)
		{
			return default(bool);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x97AB4C", Offset = "0x97AB4C", VA = "0x97AB4C")]
		private static bool SplitMeshUsingPlane(MeshData meshDataIn, FracturedObject fracturedComponent, SplitOptions splitOptions, Vector3 v3PlaneNormal, Vector3 v3PlaneRight, Vector3 v3PlanePoint, out List<MeshData> listMeshDatasPosOut, out List<MeshData> listMeshDatasNegOut, [Optional] ProgressDelegate progress)
		{
			return default(bool);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x97923C", Offset = "0x97923C", VA = "0x97923C")]
		private static bool ComputeIslandsMeshDataConnectivity(FracturedObject fracturedComponent, bool bVerticesAreLocal, MeshData meshData1, MeshData meshData2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x988670", Offset = "0x988670", VA = "0x988670")]
		public static bool IntersectEdges2D(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
		{
			return default(bool);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x9888AC", Offset = "0x9888AC", VA = "0x9888AC")]
		private static float CrossProduct2D(Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x986928", Offset = "0x986928", VA = "0x986928")]
		private static void TriangulateConstrainedDelaunay(List<List<Vector3>> listlistPointsConstrainedDelaunay, List<List<int>> listlistHashValuesConstrainedDelaunay, bool bForceVertexSoup, FracturedObject fracturedComponent, bool bConnectivityPostprocess, MeshFaceConnectivity faceConnectivityPos, MeshFaceConnectivity faceConnectivityNeg, MeshDataConnectivity meshConnectivityPos, MeshDataConnectivity meshConnectivityNeg, int nForceMeshConnectivityHash, int nSplitCloseSubMesh, Matrix4x4 mtxPlane, Matrix4x4 mtxToLocalPos, Matrix4x4 mtxToLocalNeg, Vector3 v3CenterPos, Vector3 v3CenterNeg, List<int>[] aListIndicesPosInOut, List<VertexData> listVertexDataPosInOut, List<int>[] aListIndicesNegInOut, List<VertexData> listVertexDataNegInOut)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x9888BC", Offset = "0x9888BC", VA = "0x9888BC")]
		private static void CreateIndexedMesh(IList<DelaunayTriangle> listTriangles, List<Vector3> listVerticesOut, List<int> listIndicesOut, Matrix4x4 mtxTransform, bool bTransform)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x988EF8", Offset = "0x988EF8", VA = "0x988EF8")]
		private static void Triangulate(List<Vector3> listVertices, List<int> listIndices, FracturedObject fracturedComponent, List<List<Vector3>> listlistPointsConstrainedDelaunay, List<List<int>> listlistHashValuesConstrainedDelaunay, bool bConnectivityPostprocess, MeshFaceConnectivity faceConnectivityPos, MeshFaceConnectivity faceConnectivityNeg, MeshDataConnectivity meshConnectivityPos, MeshDataConnectivity meshConnectivityNeg, int nForceMeshConnectivityHash, int nSplitCloseSubMesh, Matrix4x4 mtxPlane, Matrix4x4 mtxToLocalPos, Matrix4x4 mtxToLocalNeg, Vector3 v3CenterPos, Vector3 v3CenterNeg, List<int>[] aListIndicesPosInOut, List<VertexData> listVertexDataPosInOut, List<int>[] aListIndicesNegInOut, List<VertexData> listVertexDataNegInOut)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x989E98", Offset = "0x989E98", VA = "0x989E98")]
		private static int ComputeVertexHash(Vector3 v3Vertex, List<List<Vector3>> listlistPointsConstrainedDelaunay, List<List<int>> listlistHashValuesConstrainedDelaunay)
		{
			return default(int);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x985EEC", Offset = "0x985EEC", VA = "0x985EEC")]
		private static bool AddCapEdge(Dictionary<EdgeKeyByHash, CapEdge> dicCapEdges, int nVertexHash1, int nVertexHash2, Vector3 v3Vertex1, Vector3 v3Vertex2)
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x986020", Offset = "0x986020", VA = "0x986020")]
		private static bool ResolveCap(Dictionary<EdgeKeyByHash, CapEdge> dicCapEdges, List<List<Vector3>> listlistResolvedCapVertices, List<List<int>> listlistResolvedCapHashValues, FracturedObject fracturedComponent)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000027")]
	public class DieTimer : MonoBehaviour
	{
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float SecondsToDie;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float OffscreenLifeTime;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_fTimer;

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x973564", Offset = "0x973564", VA = "0x973564")]
		private void Start()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x97356C", Offset = "0x97356C", VA = "0x97356C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x973620", Offset = "0x973620", VA = "0x973620")]
		public DieTimer()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public static class Parameters
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float EPSILONDISTANCEPLANE;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float EPSILONDISTANCEVERTEX;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float EPSILONCAPPRECISIONMIN;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static float EPSILONCROSSPRODUCT;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static float EPSILONINSIDETRIANGLE;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static int VERTICESSPACESUBDIVISION;
	}
	[Token(Token = "0x2000029")]
	public class VertexData
	{
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int nVertexHash;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 v3Vertex;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 v3Normal;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector4 v4Tangent;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color32 color32;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector2 v2Mapping1;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2 v2Mapping2;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool bHasNormal;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool bHasTangent;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool bHasColor32;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		public bool bHasMapping1;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool bHasMapping2;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xF677B4", Offset = "0xF677B4", VA = "0xF677B4")]
		public VertexData(int nVertexHash)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xF6E2E4", Offset = "0xF6E2E4", VA = "0xF6E2E4")]
		public VertexData(int nVertexHash, Vector3 v3Vertex, Vector3 v3Normal, Vector3 v4Tangent, Color32 color32, Vector2 v2Mapping1, Vector2 v2Mapping2, bool bHasNormal, bool bHasTangent, bool bHasColor32, bool bHasMapping1, bool bHasMapping2)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xF6ABF4", Offset = "0xF6ABF4", VA = "0xF6ABF4")]
		public VertexData Copy()
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xF6E470", Offset = "0xF6E470", VA = "0xF6E470")]
		public static VertexData Lerp(int nVertexHash, VertexData vd1, VertexData vd2, float fT)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xF6E788", Offset = "0xF6E788", VA = "0xF6E788")]
		public static bool ClipAgainstPlane(VertexData[] aVertexDataInput, int nIndexA, int nIndexB, Vector3 v3A, Vector3 v3B, Plane planeSplit, ref VertexData clippedVertexDataOut)
		{
			return default(bool);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xF66CA0", Offset = "0xF66CA0", VA = "0xF66CA0")]
		public static VertexData[] BuildVertexDataArray(Mesh mesh, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xF683D4", Offset = "0xF683D4", VA = "0xF683D4")]
		public static void SetMeshDataFromVertexDataArray(MeshFilter meshFilter, MeshData meshData, bool bTransformVertexToLocal)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public struct EdgeKeyByIndex
	{
		[Token(Token = "0x2000142")]
		public class EqualityComparer : IEqualityComparer<EdgeKeyByIndex>
		{
			[Token(Token = "0x6000927")]
			[Address(RVA = "0x973754", Offset = "0x973754", VA = "0x973754", Slot = "4")]
			public bool Equals(EdgeKeyByIndex x, EdgeKeyByIndex y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x97378C", Offset = "0x97378C", VA = "0x97378C", Slot = "5")]
			public int GetHashCode(EdgeKeyByIndex x)
			{
				return default(int);
			}

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x9737D4", Offset = "0x9737D4", VA = "0x9737D4")]
			public EqualityComparer()
			{
			}
		}

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nIndexA;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int nIndexB;

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x973708", Offset = "0x973708", VA = "0x973708")]
		public EdgeKeyByIndex(int nIndexA, int nIndexB)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x973710", Offset = "0x973710", VA = "0x973710")]
		public void Set(int nIndexA, int nIndexB)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x973718", Offset = "0x973718", VA = "0x973718")]
		public bool CompareTo(int nIndexA, int nIndexB)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002B")]
	public struct EdgeKeyByHash
	{
		[Token(Token = "0x2000143")]
		public class EqualityComparer : IEqualityComparer<EdgeKeyByHash>
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x973680", Offset = "0x973680", VA = "0x973680", Slot = "4")]
			public bool Equals(EdgeKeyByHash x, EdgeKeyByHash y)
			{
				return default(bool);
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x9736B8", Offset = "0x9736B8", VA = "0x9736B8", Slot = "5")]
			public int GetHashCode(EdgeKeyByHash x)
			{
				return default(int);
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x973700", Offset = "0x973700", VA = "0x973700")]
			public EqualityComparer()
			{
			}
		}

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nHashA;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int nHashB;

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x973634", Offset = "0x973634", VA = "0x973634")]
		public EdgeKeyByHash(int nHashA, int nHashB)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x97363C", Offset = "0x97363C", VA = "0x97363C")]
		public void Set(int nHashA, int nHashB)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x973644", Offset = "0x973644", VA = "0x973644")]
		public bool CompareTo(int nHashA, int nHashB)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002C")]
	public struct ClippedEdge
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nOldIndexA;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int nOldIndexB;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int nNewIndexA;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int nNewIndexB;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int nClippedIndex;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x9724A8", Offset = "0x9724A8", VA = "0x9724A8")]
		public ClippedEdge(int nOldIndexA, int nOldIndexB, int nNewIndexA, int nNewIndexB, int nClippedIndex)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x9724B8", Offset = "0x9724B8", VA = "0x9724B8")]
		public int GetFirstIndex(int nOldIndexA)
		{
			return default(int);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x9724D4", Offset = "0x9724D4", VA = "0x9724D4")]
		public int GetSecondIndex(int nOldIndexB)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200002D")]
	public struct CapEdge
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 v1;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 v2;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int nHash1;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int nHash2;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fLength;

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x972438", Offset = "0x972438", VA = "0x972438")]
		public CapEdge(int nHash1, int nHash2, Vector3 v1, Vector3 v2, float fLength)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x972450", Offset = "0x972450", VA = "0x972450")]
		public int SharesVertex1Of(CapEdge edge)
		{
			return default(int);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x97247C", Offset = "0x97247C", VA = "0x97247C")]
		public int SharesVertex2Of(CapEdge edge)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200002E")]
	public class MeshFaceConnectivity
	{
		[Token(Token = "0x2000144")]
		public struct EdgeData
		{
			[Token(Token = "0x20001A3")]
			public struct SideData
			{
				[Token(Token = "0x4000760")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int nFace;

				[Token(Token = "0x4000761")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public int nSubMesh;

				[Token(Token = "0x4000762")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public int nSubMeshFace;

				[Token(Token = "0x4000763")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public int nEdgePos;

				[Token(Token = "0x4000764")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public int nVertexDataV1;

				[Token(Token = "0x4000765")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public int nVertexDataV2;

				[Token(Token = "0x6000A3E")]
				[Address(RVA = "0xF6C9CC", Offset = "0xF6C9CC", VA = "0xF6C9CC")]
				public SideData(int nFace, int nSubMesh, int nSubMeshFace, int nEdgePos, int nVertexDataV1, int nVertexDataV2)
				{
				}
			}

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int nEdgeIndex;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private int nVertex1Hash;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int nVertex2Hash;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 v1;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 v2;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<SideData> listSides;

			[Token(Token = "0x600092D")]
			[Address(RVA = "0xF6C708", Offset = "0xF6C708", VA = "0xF6C708")]
			public EdgeData(int nEdgeIndex, int nFace, int nSubMesh, int nSubMeshFace, int nEdgePos, Vector3 v1, Vector3 v2, int nVertex1Hash, int nVertex2Hash, int nVertexDataV1, int nVertexDataV2)
			{
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0xF6C9DC", Offset = "0xF6C9DC", VA = "0xF6C9DC")]
			public bool Compare(int nVertex1Hash, int nVertex2Hash)
			{
				return default(bool);
			}

			[Token(Token = "0x600092F")]
			[Address(RVA = "0xF6C634", Offset = "0xF6C634", VA = "0xF6C634")]
			public void AddSideData(int nFace, int nSubMesh, int nSubMeshFace, int nEdgePos, int nVertexDataV1, int nVertexDataV2)
			{
			}

			[Token(Token = "0x6000930")]
			[Address(RVA = "0xF6CA18", Offset = "0xF6CA18", VA = "0xF6CA18")]
			public bool HasMoreThanOneSide()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000145")]
		public class TriangleData
		{
			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int nSubMesh;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int nTriangle;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int[] anEdges;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<int>[] alistNeighborSubMeshes;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<int>[] alistNeighborTriangles;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool bVisited;

			[Token(Token = "0x6000931")]
			[Address(RVA = "0xF6C82C", Offset = "0xF6C82C", VA = "0xF6C82C")]
			public TriangleData(int nSubMesh, int nTriangle)
			{
			}
		}

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<TriangleData> listTriangles;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<EdgeData> listEdges;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<int> listEdgeIndices;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<EdgeKeyByHash, EdgeData> dicEdges;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int nEdgeCount;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<int, int> dicSubMeshTriangleCount;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xF6B7BC", Offset = "0xF6B7BC", VA = "0xF6B7BC")]
		public MeshFaceConnectivity()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xF6B8FC", Offset = "0xF6B8FC", VA = "0xF6B8FC")]
		public void Clear()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xF6B9BC", Offset = "0xF6B9BC", VA = "0xF6B9BC")]
		public void ResetVisited()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xF6BA50", Offset = "0xF6BA50", VA = "0xF6BA50")]
		public void AddEdge(int nSubMesh, Vector3 v1, Vector3 v2, int nVertex1Hash, int nVertex2Hash, int nVertexDataIndex1, int nVertexDataIndex2)
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class MeshDataConnectivity
	{
		[Token(Token = "0x2000146")]
		public struct Face
		{
			[Token(Token = "0x20001A4")]
			public class EqualityComparer : IEqualityComparer<Face>
			{
				[Token(Token = "0x6000A3F")]
				[Address(RVA = "0xF6B754", Offset = "0xF6B754", VA = "0xF6B754", Slot = "4")]
				public bool Equals(Face x, Face y)
				{
					return default(bool);
				}

				[Token(Token = "0x6000A40")]
				[Address(RVA = "0xF6B774", Offset = "0xF6B774", VA = "0xF6B774", Slot = "5")]
				public int GetHashCode(Face x)
				{
					return default(int);
				}

				[Token(Token = "0x6000A41")]
				[Address(RVA = "0xF6B0F0", Offset = "0xF6B0F0", VA = "0xF6B0F0")]
				public EqualityComparer()
				{
				}
			}

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int nSubMesh;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int nFaceIndex;

			[Token(Token = "0x6000932")]
			[Address(RVA = "0xF6B498", Offset = "0xF6B498", VA = "0xF6B498")]
			public Face(int nSubMesh, int nFaceIndex)
			{
			}
		}

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int s_CurrentSharedFaceHash;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Dictionary<int, List<Face>> dicHash2FaceList;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<Face, List<int>> dicFace2HashList;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<Face, bool> dicFace2IsClipped;

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xF65B60", Offset = "0xF65B60", VA = "0xF65B60")]
		public MeshDataConnectivity()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xF67B30", Offset = "0xF67B30", VA = "0xF67B30")]
		public MeshDataConnectivity GetDeepCopy()
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xF6B0F8", Offset = "0xF6B0F8", VA = "0xF6B0F8")]
		public void NotifyNewClippedFace(MeshData meshDataSource, int nSourceSubMesh, int nSourceFaceIndex, int nDestSubMesh, int nDestFaceIndex)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xF6B4A0", Offset = "0xF6B4A0", VA = "0xF6B4A0")]
		public static int GetNewHash()
		{
			return default(int);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xF6B5B4", Offset = "0xF6B5B4", VA = "0xF6B5B4")]
		public void NotifyNewCapFace(int nHash, int nSubMesh, int nFaceIndex)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xF6A840", Offset = "0xF6A840", VA = "0xF6A840")]
		public void NotifyRemappedFace(MeshDataConnectivity source, int nSourceSubMesh, int nSourceFaceIndex, int nDestSubMesh, int nDestFaceIndex)
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class MeshData
	{
		[Token(Token = "0x2000147")]
		public class IncreasingSizeComparer : IComparer<MeshData>
		{
			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int nSplitAxis;

			[Token(Token = "0x6000933")]
			[Address(RVA = "0xF6AEE0", Offset = "0xF6AEE0", VA = "0xF6AEE0")]
			public IncreasingSizeComparer(int nSplitAxis)
			{
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0xF6AF0C", Offset = "0xF6AF0C", VA = "0xF6AF0C", Slot = "4")]
			public int Compare(MeshData a, MeshData b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000148")]
		public class DecreasingSizeComparer : IComparer<MeshData>
		{
			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int nSplitAxis;

			[Token(Token = "0x6000935")]
			[Address(RVA = "0xF6ACD0", Offset = "0xF6ACD0", VA = "0xF6ACD0")]
			public DecreasingSizeComparer(int nSplitAxis)
			{
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0xF6ACFC", Offset = "0xF6ACFC", VA = "0xF6ACFC", Slot = "4")]
			public int Compare(MeshData a, MeshData b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int nSubMeshCount;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[][] aaIndices;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int nSplitCloseSubMesh;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VertexData[] aVertexData;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 v3Position;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion qRotation;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 v3Scale;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 v3Min;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 v3Max;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int nCurrentVertexHash;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Material[] aMaterials;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MeshDataConnectivity meshDataConnectivity;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xF65AC0", Offset = "0xF65AC0", VA = "0xF65AC0")]
		private MeshData()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xF65C64", Offset = "0xF65C64", VA = "0xF65C64")]
		public MeshData(Material[] aMaterials, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Matrix4x4 mtxTransformVertices, bool bUseTransform, bool bBuildVertexHashData)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xF668F4", Offset = "0xF668F4", VA = "0xF668F4")]
		public MeshData(Transform transform, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xF66A08", Offset = "0xF66A08", VA = "0xF66A08")]
		public MeshData(Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xF6730C", Offset = "0xF6730C", VA = "0xF6730C")]
		public static MeshData CreateBoxMeshData(Vector3 v3Pos, Quaternion qRot, Vector3 v3Scale, Vector3 v3Min, Vector3 v3Max)
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xF678C8", Offset = "0xF678C8", VA = "0xF678C8")]
		public MeshData GetDeepCopy()
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xF68254", Offset = "0xF68254", VA = "0xF68254")]
		public bool FillMeshFilter(MeshFilter meshFilter, bool bTransformVerticesToLocal)
		{
			return default(bool);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xF65F48", Offset = "0xF65F48", VA = "0xF65F48")]
		public static void ComputeMinMax(IEnumerable<VertexData> VertexData, ref Vector3 v3Min, ref Vector3 v3Max)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xF66294", Offset = "0xF66294", VA = "0xF66294")]
		private void BuildVertexHashData()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xF6892C", Offset = "0xF6892C", VA = "0xF6892C")]
		public bool GetSharedFacesArea(FracturedObject fracturedComponent, MeshData meshData2, out float fSharedArea)
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xF692E4", Offset = "0xF692E4", VA = "0xF692E4")]
		private static bool Face2InsideFace1(FracturedObject fracturedComponent, MeshData meshData1, MeshData meshData2, MeshDataConnectivity.Face face1, MeshDataConnectivity.Face face2)
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xF69C50", Offset = "0xF69C50", VA = "0xF69C50")]
		public static List<MeshData> PostProcessConnectivity(MeshData meshDataSource, MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, int nCurrentVertexHash, bool bTransformToLocal)
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xF6A7A4", Offset = "0xF6A7A4", VA = "0xF6A7A4")]
		private static bool StillHasFacesToProcess(List<int>[] alistFacesRemaining)
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xF6A2B0", Offset = "0xF6A2B0", VA = "0xF6A2B0")]
		private static void LookForClosedObjectRecursive(MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, int nSubMeshStart, int nFaceSubMeshStart, List<int>[] alistIndicesIn, List<VertexData> listVertexDataIn, List<int>[] alistFacesRemainingInOut, int[] aLinearFaceIndexStart, List<int>[] alistIndicesOut, List<VertexData> listVertexDataOut, Dictionary<int, int> dicVertexRemap, MeshDataConnectivity meshConnectivityOut)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class SupportPlane
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool GUIExpanded;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string GUIName;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool GUIShowInScene;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 v3PlanePosition;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Quaternion qPlaneRotation;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 v3PlaneScale;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Mesh planeMesh;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public FracturedObject fracturedObject;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xF6CB10", Offset = "0xF6CB10", VA = "0xF6CB10")]
		public SupportPlane(FracturedObject fracturedObject)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xF6D30C", Offset = "0xF6D30C", VA = "0xF6D30C")]
		public Matrix4x4 GetLocalMatrix()
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xF6D3E4", Offset = "0xF6D3E4", VA = "0xF6D3E4")]
		public Vector3[] GetBoundingBoxSegments(Bounds bounds)
		{
			return null;
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xF6D834", Offset = "0xF6D834", VA = "0xF6D834")]
		public bool IntersectsWith(GameObject otherGameObject, bool bBelowIsAlsoValid = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xF6E020", Offset = "0xF6E020", VA = "0xF6E020")]
		private static bool TestSegmentVsPlane(Vector3 v1, Vector3 v2, Plane plane, Matrix4x4 mtxToPlaneLocal, float fLimitRight, float fLimitUp, float fLimitForward)
		{
			return default(bool);
		}
	}
}
namespace Poly2Tri
{
	[Token(Token = "0x2000032")]
	public static class P2T
	{
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static TriangulationAlgorithm _defaultAlgorithm;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1100040", Offset = "0x1100040", VA = "0x1100040")]
		public static void Triangulate(PolygonSet ps)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x11002C0", Offset = "0x11002C0", VA = "0x11002C0")]
		public static void Triangulate(Polygon p)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x11003B4", Offset = "0x11003B4", VA = "0x11003B4")]
		public static void Triangulate(ConstrainedPointSet cps)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1100424", Offset = "0x1100424", VA = "0x1100424")]
		public static void Triangulate(PointSet ps)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1100494", Offset = "0x1100494", VA = "0x1100494")]
		public static TriangulationContext CreateContext(TriangulationAlgorithm algorithm)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1100330", Offset = "0x1100330", VA = "0x1100330")]
		public static void Triangulate(TriangulationAlgorithm algorithm, ITriangulatable t)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x11004F0", Offset = "0x11004F0", VA = "0x11004F0")]
		public static void Triangulate(TriangulationContext tcx)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x110058C", Offset = "0x110058C", VA = "0x110058C")]
		public static void Warmup()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class DelaunayTriangle
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FixedArray3<TriangulationPoint> Points;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FixedArray3<DelaunayTriangle> Neighbors;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FixedBitArray3 mEdgeIsConstrained;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
		public FixedBitArray3 EdgeIsDelaunay;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3C48", Offset = "0x6C3C48")]
		private bool <IsInterior>k__BackingField;

		[Token(Token = "0x1700000B")]
		public FixedBitArray3 EdgeIsConstrained
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x10FD814", Offset = "0x10FD814", VA = "0x10FD814")]
			get
			{
				return default(FixedBitArray3);
			}
		}

		[Token(Token = "0x1700000C")]
		public bool IsInterior
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x10FD824", Offset = "0x10FD824", VA = "0x10FD824")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C58BC", Offset = "0x6C58BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x10FD82C", Offset = "0x10FD82C", VA = "0x10FD82C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C58CC", Offset = "0x6C58CC")]
			set
			{
			}
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x10FD838", Offset = "0x10FD838", VA = "0x10FD838")]
		public DelaunayTriangle(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x10FD8EC", Offset = "0x10FD8EC", VA = "0x10FD8EC")]
		public int IndexOf(TriangulationPoint p)
		{
			return default(int);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x10FD994", Offset = "0x10FD994", VA = "0x10FD994")]
		public int IndexCWFrom(TriangulationPoint p)
		{
			return default(int);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x10FD9CC", Offset = "0x10FD9CC", VA = "0x10FD9CC")]
		public int IndexCCWFrom(TriangulationPoint p)
		{
			return default(int);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x10FDA04", Offset = "0x10FDA04", VA = "0x10FDA04")]
		public bool Contains(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x10FDA64", Offset = "0x10FDA64", VA = "0x10FDA64")]
		private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x10FDC1C", Offset = "0x10FDC1C", VA = "0x10FDC1C")]
		public void MarkNeighbor(DelaunayTriangle t)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x10FDDEC", Offset = "0x10FDDEC", VA = "0x10FDDEC")]
		public void ClearNeighbors()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x10FDE70", Offset = "0x10FDE70", VA = "0x10FDE70")]
		public void ClearNeighbor(DelaunayTriangle triangle)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x10FDF60", Offset = "0x10FDF60", VA = "0x10FDF60")]
		public void Clear()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x10FE02C", Offset = "0x10FE02C", VA = "0x10FE02C")]
		public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p)
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x10FE0F4", Offset = "0x10FE0F4", VA = "0x10FE0F4")]
		public DelaunayTriangle NeighborCWFrom(TriangulationPoint point)
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x10FE190", Offset = "0x10FE190", VA = "0x10FE190")]
		public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point)
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x10FE22C", Offset = "0x10FE22C", VA = "0x10FE22C")]
		public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point)
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x10FE2A8", Offset = "0x10FE2A8", VA = "0x10FE2A8")]
		public TriangulationPoint PointCCWFrom(TriangulationPoint point)
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x10FE064", Offset = "0x10FE064", VA = "0x10FE064")]
		public TriangulationPoint PointCWFrom(TriangulationPoint point)
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x10FE338", Offset = "0x10FE338", VA = "0x10FE338")]
		private void RotateCW()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x10FE400", Offset = "0x10FE400", VA = "0x10FE400")]
		public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x10FE4A0", Offset = "0x10FE4A0", VA = "0x10FE4A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x10FE64C", Offset = "0x10FE64C", VA = "0x10FE64C")]
		public void MarkNeighborEdges()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x10FE870", Offset = "0x10FE870", VA = "0x10FE870")]
		public void MarkEdge(DelaunayTriangle triangle)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x10FE97C", Offset = "0x10FE97C", VA = "0x10FE97C")]
		public void MarkEdge(List<DelaunayTriangle> tList)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x10FEB38", Offset = "0x10FEB38", VA = "0x10FEB38")]
		public void MarkConstrainedEdge(int index)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x10FEBF8", Offset = "0x10FEBF8", VA = "0x10FEBF8")]
		public void MarkConstrainedEdge(DTSweepConstraint edge)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x10FE830", Offset = "0x10FE830", VA = "0x10FE830")]
		public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x10FED50", Offset = "0x10FED50", VA = "0x10FED50")]
		public double Area()
		{
			return default(double);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x10FEE74", Offset = "0x10FEE74", VA = "0x10FEE74")]
		public TriangulationPoint Centroid()
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x10FDB2C", Offset = "0x10FDB2C", VA = "0x10FDB2C")]
		public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2)
		{
			return default(int);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x10FF074", Offset = "0x10FF074", VA = "0x10FF074")]
		public bool GetConstrainedEdgeCCW(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x10FF0D0", Offset = "0x10FF0D0", VA = "0x10FF0D0")]
		public bool GetConstrainedEdgeCW(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x10FF12C", Offset = "0x10FF12C", VA = "0x10FF12C")]
		public bool GetConstrainedEdgeAcross(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x10FF168", Offset = "0x10FF168", VA = "0x10FF168")]
		protected void SetConstrainedEdge(int idx, bool ce)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x10FF174", Offset = "0x10FF174", VA = "0x10FF174")]
		public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x10FF1C4", Offset = "0x10FF1C4", VA = "0x10FF1C4")]
		public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x10FF214", Offset = "0x10FF214", VA = "0x10FF214")]
		public void SetConstrainedEdgeAcross(TriangulationPoint p, bool ce)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x10FF248", Offset = "0x10FF248", VA = "0x10FF248")]
		public bool GetDelaunayEdgeCCW(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x10FF290", Offset = "0x10FF290", VA = "0x10FF290")]
		public bool GetDelaunayEdgeCW(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x10FF2D8", Offset = "0x10FF2D8", VA = "0x10FF2D8")]
		public bool GetDelaunayEdgeAcross(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x10FF300", Offset = "0x10FF300", VA = "0x10FF300")]
		public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x10FF350", Offset = "0x10FF350", VA = "0x10FF350")]
		public void SetDelaunayEdgeCW(TriangulationPoint p, bool ce)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x10FF3A0", Offset = "0x10FF3A0", VA = "0x10FF3A0")]
		public void SetDelaunayEdgeAcross(TriangulationPoint p, bool ce)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x10FF3D0", Offset = "0x10FF3D0", VA = "0x10FF3D0")]
		public bool GetEdge(int idx, out DTSweepConstraint edge)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x10FF6FC", Offset = "0x10FF6FC", VA = "0x10FF6FC")]
		public bool GetEdgeCCW(TriangulationPoint p, out DTSweepConstraint edge)
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x10FF74C", Offset = "0x10FF74C", VA = "0x10FF74C")]
		public bool GetEdgeCW(TriangulationPoint p, out DTSweepConstraint edge)
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x10FF79C", Offset = "0x10FF79C", VA = "0x10FF79C")]
		public bool GetEdgeAcross(TriangulationPoint p, out DTSweepConstraint edge)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000034")]
	public class AdvancingFront
	{
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AdvancingFrontNode Head;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancingFrontNode Tail;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected AdvancingFrontNode Search;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xE7023C", Offset = "0xE7023C", VA = "0xE7023C")]
		public AdvancingFront(AdvancingFrontNode head, AdvancingFrontNode tail)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xE70278", Offset = "0xE70278", VA = "0xE70278")]
		public void AddNode(AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xE7027C", Offset = "0xE7027C", VA = "0xE7027C")]
		public void RemoveNode(AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xE70280", Offset = "0xE70280", VA = "0xE70280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xE70378", Offset = "0xE70378", VA = "0xE70378")]
		private AdvancingFrontNode FindSearchNode(double x)
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xE70380", Offset = "0xE70380", VA = "0xE70380")]
		public AdvancingFrontNode LocateNode(TriangulationPoint point)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xE703BC", Offset = "0xE703BC", VA = "0xE703BC")]
		private AdvancingFrontNode LocateNode(double x)
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xE70424", Offset = "0xE70424", VA = "0xE70424")]
		public AdvancingFrontNode LocatePoint(TriangulationPoint point)
		{
			return null;
		}
	}
	[Token(Token = "0x2000035")]
	public class AdvancingFrontNode
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AdvancingFrontNode Next;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancingFrontNode Prev;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double Value;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TriangulationPoint Point;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DelaunayTriangle Triangle;

		[Token(Token = "0x1700000D")]
		public bool HasNext
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xE705B0", Offset = "0xE705B0", VA = "0xE705B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		public bool HasPrev
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xE705C0", Offset = "0xE705C0", VA = "0xE705C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xE70568", Offset = "0xE70568", VA = "0xE70568")]
		public AdvancingFrontNode(TriangulationPoint point)
		{
		}
	}
	[Token(Token = "0x2000036")]
	public static class DTSweep
	{
		[Token(Token = "0x400017C")]
		private const double PI_div2 = Math.PI / 2.0;

		[Token(Token = "0x400017D")]
		private const double PI_3div4 = Math.PI * 3.0 / 4.0;

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xE74C2C", Offset = "0xE74C2C", VA = "0xE74C2C")]
		public static void Triangulate(DTSweepContext tcx)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xE74E6C", Offset = "0xE74E6C", VA = "0xE74E6C")]
		private static void Sweep(DTSweepContext tcx)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xE75070", Offset = "0xE75070", VA = "0xE75070")]
		private static void FixupConstrainedEdges(DTSweepContext tcx)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xE752AC", Offset = "0xE752AC", VA = "0xE752AC")]
		private static void FinalizationConvexHull(DTSweepContext tcx)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xE75AA8", Offset = "0xE75AA8", VA = "0xE75AA8")]
		private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xE75230", Offset = "0xE75230", VA = "0xE75230")]
		private static void FinalizationPolygon(DTSweepContext tcx)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xE760FC", Offset = "0xE760FC", VA = "0xE760FC")]
		private static void FinalizationConstraints(DTSweepContext tcx)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xE756E8", Offset = "0xE756E8", VA = "0xE756E8")]
		private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point)
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xE76188", Offset = "0xE76188", VA = "0xE76188")]
		private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node)
		{
			return null;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE75830", Offset = "0xE75830", VA = "0xE75830")]
		private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xE7675C", Offset = "0xE7675C", VA = "0xE7675C")]
		private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xE76C7C", Offset = "0xE76C7C", VA = "0xE76C7C")]
		private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xE76D58", Offset = "0xE76D58", VA = "0xE76D58")]
		private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xE76E40", Offset = "0xE76E40", VA = "0xE76E40")]
		private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xE76A40", Offset = "0xE76A40", VA = "0xE76A40")]
		private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xE76F50", Offset = "0xE76F50", VA = "0xE76F50")]
		private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xE77030", Offset = "0xE77030", VA = "0xE77030")]
		private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xE77104", Offset = "0xE77104", VA = "0xE77104")]
		private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xE76B60", Offset = "0xE76B60", VA = "0xE76B60")]
		private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xE7669C", Offset = "0xE7669C", VA = "0xE7669C")]
		private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq)
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xE7678C", Offset = "0xE7678C", VA = "0xE7678C")]
		private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xE77210", Offset = "0xE77210", VA = "0xE77210")]
		private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xE77658", Offset = "0xE77658", VA = "0xE77658")]
		private static bool NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op, out TriangulationPoint newP)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xE77584", Offset = "0xE77584", VA = "0xE77584")]
		private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xE77760", Offset = "0xE77760", VA = "0xE77760")]
		private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xE762FC", Offset = "0xE762FC", VA = "0xE762FC")]
		private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xE77BB0", Offset = "0xE77BB0", VA = "0xE77BB0")]
		private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xE77E24", Offset = "0xE77E24", VA = "0xE77E24")]
		private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xE77F54", Offset = "0xE77F54", VA = "0xE77F54")]
		private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xE7795C", Offset = "0xE7795C", VA = "0xE7795C")]
		private static double HoleAngle(AdvancingFrontNode node)
		{
			return default(double);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xE77AAC", Offset = "0xE77AAC", VA = "0xE77AAC")]
		private static double BasinAngle(AdvancingFrontNode node)
		{
			return default(double);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE75FB8", Offset = "0xE75FB8", VA = "0xE75FB8")]
		private static void Fill(DTSweepContext tcx, AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xE76404", Offset = "0xE76404", VA = "0xE76404")]
		private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xE75BB8", Offset = "0xE75BB8", VA = "0xE75BB8")]
		private static void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op)
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class DTSweepBasin
	{
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AdvancingFrontNode leftNode;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancingFrontNode bottomNode;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AdvancingFrontNode rightNode;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double width;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool leftHighest;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE78008", Offset = "0xE78008", VA = "0xE78008")]
		public DTSweepBasin()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class DTSweepConstraint : TriangulationConstraint
	{
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xE78010", Offset = "0xE78010", VA = "0xE78010")]
		public DTSweepConstraint(TriangulationPoint p1, TriangulationPoint p2)
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class DTSweepContext : TriangulationContext
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly float ALPHA;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AdvancingFront Front;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3C58", Offset = "0x6C3C58")]
		private TriangulationPoint <Head>k__BackingField;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3C68", Offset = "0x6C3C68")]
		private TriangulationPoint <Tail>k__BackingField;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DTSweepBasin Basin;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public DTSweepEdgeEvent EdgeEvent;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DTSweepPointComparator _comparator;

		[Token(Token = "0x1700000F")]
		public TriangulationPoint Head
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xE78050", Offset = "0xE78050", VA = "0xE78050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C58DC", Offset = "0x6C58DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xE78058", Offset = "0xE78058", VA = "0xE78058")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C58EC", Offset = "0x6C58EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public TriangulationPoint Tail
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xE78060", Offset = "0xE78060", VA = "0xE78060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C58FC", Offset = "0x6C58FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xE78068", Offset = "0xE78068", VA = "0xE78068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C590C", Offset = "0x6C590C")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public override TriangulationAlgorithm Algorithm
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xE78070", Offset = "0xE78070", VA = "0xE78070", Slot = "4")]
			get
			{
				return default(TriangulationAlgorithm);
			}
		}

		[Token(Token = "0x17000012")]
		public override bool IsDebugEnabled
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xE7813C", Offset = "0xE7813C", VA = "0xE7813C", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xE78144", Offset = "0xE78144", VA = "0xE78144", Slot = "9")]
			protected set
			{
			}
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xE78078", Offset = "0xE78078", VA = "0xE78078")]
		public DTSweepContext()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xE75F50", Offset = "0xE75F50", VA = "0xE75F50")]
		public void RemoveFromList(DelaunayTriangle triangle)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xE760F8", Offset = "0xE760F8", VA = "0xE760F8")]
		public void MeshClean(DelaunayTriangle triangle)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xE781C8", Offset = "0xE781C8", VA = "0xE781C8")]
		private void MeshCleanReq(DelaunayTriangle triangle)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xE78310", Offset = "0xE78310", VA = "0xE78310", Slot = "7")]
		public override void Clear()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xE762E4", Offset = "0xE762E4", VA = "0xE762E4")]
		public void AddNode(AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xE77FF0", Offset = "0xE77FF0", VA = "0xE77FF0")]
		public void RemoveNode(AdvancingFrontNode node)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xE76170", Offset = "0xE76170", VA = "0xE76170")]
		public AdvancingFrontNode LocateNode(TriangulationPoint point)
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xE74C90", Offset = "0xE74C90", VA = "0xE74C90")]
		public void CreateAdvancingFront()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xE75E74", Offset = "0xE75E74", VA = "0xE75E74")]
		public void MapTriangleToNodes(DelaunayTriangle t)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xE78374", Offset = "0xE78374", VA = "0xE78374", Slot = "5")]
		public override void PrepareTriangulation(ITriangulatable t)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xE7560C", Offset = "0xE7560C", VA = "0xE7560C")]
		public void FinalizeTriangulation()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xE78664", Offset = "0xE78664", VA = "0xE78664", Slot = "6")]
		public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b)
		{
			return null;
		}
	}
	[Token(Token = "0x200003A")]
	public class DTSweepDebugContext : TriangulationDebugContext
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DelaunayTriangle _primaryTriangle;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DelaunayTriangle _secondaryTriangle;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TriangulationPoint _activePoint;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AdvancingFrontNode _activeNode;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DTSweepConstraint _activeConstraint;

		[Token(Token = "0x17000013")]
		public DelaunayTriangle PrimaryTriangle
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x10FD468", Offset = "0x10FD468", VA = "0x10FD468")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x10FD470", Offset = "0x10FD470", VA = "0x10FD470")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public DelaunayTriangle SecondaryTriangle
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x10FD4D0", Offset = "0x10FD4D0", VA = "0x10FD4D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x10FD4D8", Offset = "0x10FD4D8", VA = "0x10FD4D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public TriangulationPoint ActivePoint
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x10FD534", Offset = "0x10FD534", VA = "0x10FD534")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x10FD53C", Offset = "0x10FD53C", VA = "0x10FD53C")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public AdvancingFrontNode ActiveNode
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x10FD598", Offset = "0x10FD598", VA = "0x10FD598")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x10FD5A0", Offset = "0x10FD5A0", VA = "0x10FD5A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public DTSweepConstraint ActiveConstraint
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x10FD5FC", Offset = "0x10FD5FC", VA = "0x10FD5FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x10FD604", Offset = "0x10FD604", VA = "0x10FD604")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public bool IsDebugContext
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x10FD6B8", Offset = "0x10FD6B8", VA = "0x10FD6B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x10FD660", Offset = "0x10FD660", VA = "0x10FD660")]
		public DTSweepDebugContext(DTSweepContext tcx)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x10FD6C0", Offset = "0x10FD6C0", VA = "0x10FD6C0", Slot = "4")]
		public override void Clear()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class DTSweepEdgeEvent
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DTSweepConstraint ConstrainedEdge;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Right;

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x10FD710", Offset = "0x10FD710", VA = "0x10FD710")]
		public DTSweepEdgeEvent()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class DTSweepPointComparator : IComparer<TriangulationPoint>
	{
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x10FD718", Offset = "0x10FD718", VA = "0x10FD718", Slot = "4")]
		public int Compare(TriangulationPoint p1, TriangulationPoint p2)
		{
			return default(int);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x10FD80C", Offset = "0x10FD80C", VA = "0x10FD80C")]
		public DTSweepPointComparator()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class PointOnEdgeException : NotImplementedException
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public readonly TriangulationPoint A;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public readonly TriangulationPoint B;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public readonly TriangulationPoint C;

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x110624C", Offset = "0x110624C", VA = "0x110624C")]
		public PointOnEdgeException(string message, TriangulationPoint a, TriangulationPoint b, TriangulationPoint c)
		{
		}
	}
	[Token(Token = "0x200003E")]
	public interface ITriangulatable
	{
		[Token(Token = "0x17000019")]
		IList<DelaunayTriangle> Triangles
		{
			[Token(Token = "0x60001D3")]
			get;
		}

		[Token(Token = "0x1700001A")]
		TriangulationMode TriangulationMode
		{
			[Token(Token = "0x60001D4")]
			get;
		}

		[Token(Token = "0x1700001B")]
		string FileName
		{
			[Token(Token = "0x60001D5")]
			get;
			[Token(Token = "0x60001D6")]
			set;
		}

		[Token(Token = "0x1700001C")]
		bool DisplayFlipX
		{
			[Token(Token = "0x60001D7")]
			get;
			[Token(Token = "0x60001D8")]
			set;
		}

		[Token(Token = "0x1700001D")]
		bool DisplayFlipY
		{
			[Token(Token = "0x60001D9")]
			get;
			[Token(Token = "0x60001DA")]
			set;
		}

		[Token(Token = "0x1700001E")]
		float DisplayRotate
		{
			[Token(Token = "0x60001DB")]
			get;
			[Token(Token = "0x60001DC")]
			set;
		}

		[Token(Token = "0x1700001F")]
		double Precision
		{
			[Token(Token = "0x60001DD")]
			get;
			[Token(Token = "0x60001DE")]
			set;
		}

		[Token(Token = "0x17000020")]
		double MinX
		{
			[Token(Token = "0x60001DF")]
			get;
		}

		[Token(Token = "0x17000021")]
		double MaxX
		{
			[Token(Token = "0x60001E0")]
			get;
		}

		[Token(Token = "0x17000022")]
		double MinY
		{
			[Token(Token = "0x60001E1")]
			get;
		}

		[Token(Token = "0x17000023")]
		double MaxY
		{
			[Token(Token = "0x60001E2")]
			get;
		}

		[Token(Token = "0x17000024")]
		Rect2D Bounds
		{
			[Token(Token = "0x60001E3")]
			get;
		}

		[Token(Token = "0x60001E4")]
		void Prepare(TriangulationContext tcx);

		[Token(Token = "0x60001E5")]
		void AddTriangle(DelaunayTriangle t);

		[Token(Token = "0x60001E6")]
		void AddTriangles(IEnumerable<DelaunayTriangle> list);

		[Token(Token = "0x60001E7")]
		void ClearTriangles();
	}
	[Token(Token = "0x200003F")]
	public enum Orientation
	{
		[Token(Token = "0x4000195")]
		CW,
		[Token(Token = "0x4000196")]
		CCW,
		[Token(Token = "0x4000197")]
		Collinear
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6C23D8", Offset = "0x6C23D8")]
	public class Contour : Point2DList, ITriangulatable, IEnumerable<TriangulationPoint>, IEnumerable, IList<TriangulationPoint>, ICollection<TriangulationPoint>
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Contour> mHoles;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ITriangulatable mParent;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mName;

		[Token(Token = "0x17000025")]
		public new TriangulationPoint Item
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xE719F8", Offset = "0xE719F8", VA = "0xE719F8", Slot = "49")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xE73458", Offset = "0xE73458", VA = "0xE73458", Slot = "50")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public string Name
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xE734C8", Offset = "0xE734C8", VA = "0xE734C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xE734D0", Offset = "0xE734D0", VA = "0xE734D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public IList<DelaunayTriangle> Triangles
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xE734D8", Offset = "0xE734D8", VA = "0xE734D8", Slot = "27")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xE73544", Offset = "0xE73544", VA = "0xE73544")]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public TriangulationMode TriangulationMode
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xE73548", Offset = "0xE73548", VA = "0xE73548", Slot = "28")]
			get
			{
				return default(TriangulationMode);
			}
		}

		[Token(Token = "0x17000029")]
		public string FileName
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xE735FC", Offset = "0xE735FC", VA = "0xE735FC", Slot = "29")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xE736B0", Offset = "0xE736B0", VA = "0xE736B0", Slot = "30")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public bool DisplayFlipX
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xE736B4", Offset = "0xE736B4", VA = "0xE736B4", Slot = "31")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xE73768", Offset = "0xE73768", VA = "0xE73768", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public bool DisplayFlipY
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xE7376C", Offset = "0xE7376C", VA = "0xE7376C", Slot = "33")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xE73820", Offset = "0xE73820", VA = "0xE73820", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public float DisplayRotate
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xE73824", Offset = "0xE73824", VA = "0xE73824", Slot = "35")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xE738D8", Offset = "0xE738D8", VA = "0xE738D8", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public double Precision
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xE738DC", Offset = "0xE738DC", VA = "0xE738DC", Slot = "37")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0xE73990", Offset = "0xE73990", VA = "0xE73990", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public double MinX
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0xE73994", Offset = "0xE73994", VA = "0xE73994", Slot = "39")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700002F")]
		public double MaxX
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0xE739B0", Offset = "0xE739B0", VA = "0xE739B0", Slot = "40")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000030")]
		public double MinY
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0xE739CC", Offset = "0xE739CC", VA = "0xE739CC", Slot = "41")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000031")]
		public double MaxY
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0xE739E8", Offset = "0xE739E8", VA = "0xE739E8", Slot = "42")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000032")]
		public Rect2D Bounds
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0xE73A04", Offset = "0xE73A04", VA = "0xE73A04", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xE71AB0", Offset = "0xE71AB0", VA = "0xE71AB0")]
		public Contour(ITriangulatable parent)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xE71928", Offset = "0xE71928", VA = "0xE71928")]
		public Contour(ITriangulatable parent, IList<TriangulationPoint> points, WindingOrderType windingOrder)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xE73CC8", Offset = "0xE73CC8", VA = "0xE73CC8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xE73D30", Offset = "0xE73D30", VA = "0xE73D30", Slot = "48")]
		private IEnumerator<TriangulationPoint> System.Collections.Generic.IEnumerable<Poly2Tri.TriangulationPoint>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xE73D98", Offset = "0xE73D98", VA = "0xE73D98", Slot = "51")]
		public int IndexOf(TriangulationPoint p)
		{
			return default(int);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xE73E00", Offset = "0xE73E00", VA = "0xE73E00", Slot = "56")]
		public void Add(TriangulationPoint p)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xE73E18", Offset = "0xE73E18", VA = "0xE73E18", Slot = "20")]
		protected override void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xE73F78", Offset = "0xE73F78", VA = "0xE73F78", Slot = "22")]
		public override void AddRange(IEnumerator<Point2D> iter, WindingOrderType windingOrder)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xE73A0C", Offset = "0xE73A0C", VA = "0xE73A0C")]
		public void AddRange(IList<TriangulationPoint> points, WindingOrderType windingOrder)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE74400", Offset = "0xE74400", VA = "0xE74400", Slot = "52")]
		public void Insert(int idx, TriangulationPoint p)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xE74420", Offset = "0xE74420", VA = "0xE74420", Slot = "60")]
		public bool Remove(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xE74430", Offset = "0xE74430", VA = "0xE74430", Slot = "58")]
		public bool Contains(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xE74498", Offset = "0xE74498", VA = "0xE74498", Slot = "59")]
		public void CopyTo(TriangulationPoint[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xE74664", Offset = "0xE74664", VA = "0xE74664")]
		protected void AddHole(Contour c)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xE71D9C", Offset = "0xE71D9C", VA = "0xE71D9C")]
		public int GetNumHoles(bool parentIsHole)
		{
			return default(int);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xE746D4", Offset = "0xE746D4", VA = "0xE746D4")]
		public int GetNumHoles()
		{
			return default(int);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xE74724", Offset = "0xE74724", VA = "0xE74724")]
		public Contour GetHole(int idx)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xE72078", Offset = "0xE72078", VA = "0xE72078")]
		public void GetActualHoles(bool parentIsHole, ref List<Contour> holes)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xE747AC", Offset = "0xE747AC", VA = "0xE747AC")]
		public List<Contour>.Enumerator GetHoleEnumerator()
		{
			return default(List<Contour>.Enumerator);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xE73150", Offset = "0xE73150", VA = "0xE73150")]
		public void InitializeHoles(ConstrainedPointSet cps)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xE722B4", Offset = "0xE722B4", VA = "0xE722B4")]
		public static void InitializeHoles(List<Contour> holes, ITriangulatable parent, ConstrainedPointSet cps)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xE74818", Offset = "0xE74818", VA = "0xE74818", Slot = "44")]
		public void Prepare(TriangulationContext tcx)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xE74884", Offset = "0xE74884", VA = "0xE74884", Slot = "45")]
		public void AddTriangle(DelaunayTriangle t)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xE748F0", Offset = "0xE748F0", VA = "0xE748F0", Slot = "46")]
		public void AddTriangles(IEnumerable<DelaunayTriangle> list)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xE7495C", Offset = "0xE7495C", VA = "0xE7495C", Slot = "47")]
		public void ClearTriangles()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xE749C8", Offset = "0xE749C8", VA = "0xE749C8")]
		public Point2D FindPointInContour()
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xE74AF4", Offset = "0xE74AF4", VA = "0xE74AF4")]
		public bool IsPointInsideContour(Point2D p)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6C2410", Offset = "0x6C2410")]
	public class Polygon : Point2DList, ITriangulatable, IEnumerable<TriangulationPoint>, IEnumerable, IList<TriangulationPoint>, ICollection<TriangulationPoint>
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Dictionary<uint, TriangulationPoint> mPointMap;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<DelaunayTriangle> mTriangles;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3C78", Offset = "0x6C3C78")]
		private string <FileName>k__BackingField;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3C88", Offset = "0x6C3C88")]
		private bool <DisplayFlipX>k__BackingField;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3C98", Offset = "0x6C3C98")]
		private bool <DisplayFlipY>k__BackingField;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3CA8", Offset = "0x6C3CA8")]
		private float <DisplayRotate>k__BackingField;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private double mPrecision;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected List<Polygon> mHoles;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected List<TriangulationPoint> mSteinerPoints;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected PolygonPoint _last;

		[Token(Token = "0x17000033")]
		public IList<TriangulationPoint> Points
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x1107B24", Offset = "0x1107B24", VA = "0x1107B24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public IList<DelaunayTriangle> Triangles
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x1107B28", Offset = "0x1107B28", VA = "0x1107B28", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public TriangulationMode TriangulationMode
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x1107B30", Offset = "0x1107B30", VA = "0x1107B30", Slot = "28")]
			get
			{
				return default(TriangulationMode);
			}
		}

		[Token(Token = "0x17000036")]
		public string FileName
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x1107B38", Offset = "0x1107B38", VA = "0x1107B38", Slot = "29")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C591C", Offset = "0x6C591C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x1107B40", Offset = "0x1107B40", VA = "0x1107B40", Slot = "30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C592C", Offset = "0x6C592C")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool DisplayFlipX
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x1107B48", Offset = "0x1107B48", VA = "0x1107B48", Slot = "31")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C593C", Offset = "0x6C593C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x1107B50", Offset = "0x1107B50", VA = "0x1107B50", Slot = "32")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C594C", Offset = "0x6C594C")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool DisplayFlipY
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x1107B5C", Offset = "0x1107B5C", VA = "0x1107B5C", Slot = "33")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C595C", Offset = "0x6C595C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x1107B64", Offset = "0x1107B64", VA = "0x1107B64", Slot = "34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C596C", Offset = "0x6C596C")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public float DisplayRotate
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x1107B70", Offset = "0x1107B70", VA = "0x1107B70", Slot = "35")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C597C", Offset = "0x6C597C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x1107B78", Offset = "0x1107B78", VA = "0x1107B78", Slot = "36")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C598C", Offset = "0x6C598C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public double Precision
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x1107B80", Offset = "0x1107B80", VA = "0x1107B80", Slot = "37")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x1107B88", Offset = "0x1107B88", VA = "0x1107B88", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public double MinX
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x1107B90", Offset = "0x1107B90", VA = "0x1107B90", Slot = "39")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700003C")]
		public double MaxX
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x1107BAC", Offset = "0x1107BAC", VA = "0x1107BAC", Slot = "40")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700003D")]
		public double MinY
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x1107BC8", Offset = "0x1107BC8", VA = "0x1107BC8", Slot = "41")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700003E")]
		public double MaxY
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x1107BE4", Offset = "0x1107BE4", VA = "0x1107BE4", Slot = "42")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700003F")]
		public Rect2D Bounds
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x1107C00", Offset = "0x1107C00", VA = "0x1107C00", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public new TriangulationPoint Item
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x1107C08", Offset = "0x1107C08", VA = "0x1107C08", Slot = "49")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x1107CC0", Offset = "0x1107CC0", VA = "0x1107CC0", Slot = "50")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public IList<Polygon> Holes
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x1107D30", Offset = "0x1107D30", VA = "0x1107D30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1107D38", Offset = "0x1107D38", VA = "0x1107D38")]
		public Polygon(IList<PolygonPoint> points)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1108190", Offset = "0x1108190", VA = "0x1108190")]
		public Polygon(IEnumerable<PolygonPoint> points)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x110821C", Offset = "0x110821C", VA = "0x110821C")]
		public Polygon(params PolygonPoint[] points)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1108220", Offset = "0x1108220", VA = "0x1108220", Slot = "48")]
		private IEnumerator<TriangulationPoint> System.Collections.Generic.IEnumerable<Poly2Tri.TriangulationPoint>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1108290", Offset = "0x1108290", VA = "0x1108290", Slot = "51")]
		public int IndexOf(TriangulationPoint p)
		{
			return default(int);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x11082F8", Offset = "0x11082F8", VA = "0x11082F8", Slot = "19")]
		public override void Add(Point2D p)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1108310", Offset = "0x1108310", VA = "0x1108310", Slot = "56")]
		public void Add(TriangulationPoint p)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1108328", Offset = "0x1108328", VA = "0x1108328")]
		public void Add(PolygonPoint p)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1108340", Offset = "0x1108340", VA = "0x1108340", Slot = "20")]
		protected override void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1107ED0", Offset = "0x1107ED0", VA = "0x1107ED0")]
		public void AddRange(IList<PolygonPoint> points, WindingOrderType windingOrder)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1108498", Offset = "0x1108498", VA = "0x1108498")]
		public void AddRange(IList<TriangulationPoint> points, WindingOrderType windingOrder)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1108758", Offset = "0x1108758", VA = "0x1108758", Slot = "52")]
		public void Insert(int idx, TriangulationPoint p)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1108778", Offset = "0x1108778", VA = "0x1108778", Slot = "60")]
		public bool Remove(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x110877C", Offset = "0x110877C", VA = "0x110877C")]
		public void RemovePoint(PolygonPoint p)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1108914", Offset = "0x1108914", VA = "0x1108914", Slot = "58")]
		public bool Contains(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x110897C", Offset = "0x110897C", VA = "0x110897C", Slot = "59")]
		public void CopyTo(TriangulationPoint[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1108B44", Offset = "0x1108B44", VA = "0x1108B44")]
		public void AddSteinerPoint(TriangulationPoint point)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1108BDC", Offset = "0x1108BDC", VA = "0x1108BDC")]
		public void AddSteinerPoints(List<TriangulationPoint> points)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1108C74", Offset = "0x1108C74", VA = "0x1108C74")]
		public void ClearSteinerPoints()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1108CD4", Offset = "0x1108CD4", VA = "0x1108CD4")]
		public void AddHole(Polygon poly)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1108D6C", Offset = "0x1108D6C", VA = "0x1108D6C", Slot = "45")]
		public void AddTriangle(DelaunayTriangle t)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1108DD4", Offset = "0x1108DD4", VA = "0x1108DD4", Slot = "46")]
		public void AddTriangles(IEnumerable<DelaunayTriangle> list)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1108E3C", Offset = "0x1108E3C", VA = "0x1108E3C", Slot = "47")]
		public void ClearTriangles()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1108E9C", Offset = "0x1108E9C", VA = "0x1108E9C")]
		public bool IsPointInside(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x110923C", Offset = "0x110923C", VA = "0x110923C", Slot = "44")]
		public void Prepare(TriangulationContext tcx)
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class PolygonPoint : TriangulationPoint
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3CB8", Offset = "0x6C3CB8")]
		private PolygonPoint <Next>k__BackingField;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3CC8", Offset = "0x6C3CC8")]
		private PolygonPoint <Previous>k__BackingField;

		[Token(Token = "0x17000042")]
		public PolygonPoint Next
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x110AAA8", Offset = "0x110AAA8", VA = "0x110AAA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C599C", Offset = "0x6C599C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x110AAB0", Offset = "0x110AAB0", VA = "0x110AAB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C59AC", Offset = "0x6C59AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public PolygonPoint Previous
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x110AAB8", Offset = "0x110AAB8", VA = "0x110AAB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C59BC", Offset = "0x6C59BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x110AAC0", Offset = "0x110AAC0", VA = "0x110AAC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C59CC", Offset = "0x6C59CC")]
			set
			{
			}
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x110985C", Offset = "0x110985C", VA = "0x110985C")]
		public PolygonPoint(double x, double y)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x110AAC8", Offset = "0x110AAC8", VA = "0x110AAC8")]
		public static Point2D ToBasePoint(PolygonPoint p)
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x110AACC", Offset = "0x110AACC", VA = "0x110AACC")]
		public static TriangulationPoint ToTriangulationPoint(PolygonPoint p)
		{
			return null;
		}
	}
	[Token(Token = "0x2000043")]
	public class PolygonSet
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected List<Polygon> _polygons;

		[Token(Token = "0x17000044")]
		public IEnumerable<Polygon> Polygons
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x110AC44", Offset = "0x110AC44", VA = "0x110AC44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x110AAD0", Offset = "0x110AAD0", VA = "0x110AAD0")]
		public PolygonSet()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x110AB40", Offset = "0x110AB40", VA = "0x110AB40")]
		public PolygonSet(Polygon poly)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x110ABDC", Offset = "0x110ABDC", VA = "0x110ABDC")]
		public void Add(Polygon p)
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class PolygonUtil
	{
		[Token(Token = "0x2000149")]
		public enum PolyUnionError
		{
			[Token(Token = "0x400068F")]
			None,
			[Token(Token = "0x4000690")]
			NoIntersections,
			[Token(Token = "0x4000691")]
			Poly1InsidePoly2,
			[Token(Token = "0x4000692")]
			InfiniteLoop
		}

		[Token(Token = "0x200014A")]
		[Flags]
		public enum PolyOperation : uint
		{
			[Token(Token = "0x4000694")]
			None = 0u,
			[Token(Token = "0x4000695")]
			Union = 1u,
			[Token(Token = "0x4000696")]
			Intersect = 2u,
			[Token(Token = "0x4000697")]
			Subtract = 4u
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x110AC4C", Offset = "0x110AC4C", VA = "0x110AC4C")]
		public static Point2DList.WindingOrderType CalculateWindingOrder(IList<Point2D> l)
		{
			return default(Point2DList.WindingOrderType);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x110AFB8", Offset = "0x110AFB8", VA = "0x110AFB8")]
		public static bool PolygonsAreSame2D(IList<Point2D> poly1, IList<Point2D> poly2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1108EA0", Offset = "0x1108EA0", VA = "0x1108EA0")]
		public static bool PointInPolygon2D(IList<Point2D> polygon, Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x110B3AC", Offset = "0x110B3AC", VA = "0x110B3AC")]
		public static bool PolygonsIntersect2D(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x110B910", Offset = "0x110B910", VA = "0x110B910")]
		public bool PolygonContainsPolygon(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x110B92C", Offset = "0x110B92C", VA = "0x110B92C")]
		public static bool PolygonContainsPolygon(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2, bool runIntersectionTest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x110BBF0", Offset = "0x110BBF0", VA = "0x110BBF0")]
		public static void ClipPolygonToEdge2D(Point2D edgeBegin, Point2D edgeEnd, IList<Point2D> poly, out List<Point2D> outPoly)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x110C968", Offset = "0x110C968", VA = "0x110C968")]
		public static void ClipPolygonToPolygon(IList<Point2D> poly, IList<Point2D> clipPoly, out List<Point2D> outPoly)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x110CC8C", Offset = "0x110CC8C", VA = "0x110CC8C")]
		public static PolyUnionError PolygonUnion(Point2DList polygon1, Point2DList polygon2, out Point2DList union)
		{
			return default(PolyUnionError);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x110CD28", Offset = "0x110CD28", VA = "0x110CD28")]
		protected static void PolygonUnionInternal(PolygonOperationContext ctx)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x110D1A4", Offset = "0x110D1A4", VA = "0x110D1A4")]
		public static PolyUnionError PolygonIntersect(Point2DList polygon1, Point2DList polygon2, out Point2DList intersectOut)
		{
			return default(PolyUnionError);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x110D240", Offset = "0x110D240", VA = "0x110D240")]
		protected static void PolygonIntersectInternal(PolygonOperationContext ctx)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x110D714", Offset = "0x110D714", VA = "0x110D714")]
		public static PolyUnionError PolygonSubtract(Point2DList polygon1, Point2DList polygon2, out Point2DList subtract)
		{
			return default(PolyUnionError);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x110D7B0", Offset = "0x110D7B0", VA = "0x110D7B0")]
		public static void PolygonSubtractInternal(PolygonOperationContext ctx)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x110DCD0", Offset = "0x110DCD0", VA = "0x110DCD0")]
		public static PolyUnionError PolygonOperation(PolyOperation operations, Point2DList polygon1, Point2DList polygon2, out Dictionary<uint, Point2DList> results)
		{
			return default(PolyUnionError);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x110DD6C", Offset = "0x110DD6C", VA = "0x110DD6C")]
		public static PolyUnionError PolygonOperation(PolygonOperationContext ctx)
		{
			return default(PolyUnionError);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x110DDD0", Offset = "0x110DDD0", VA = "0x110DDD0")]
		public static List<Point2DList> SplitComplexPolygon(Point2DList verts, double epsilon)
		{
			return null;
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x110F34C", Offset = "0x110F34C", VA = "0x110F34C")]
		private static List<Point2DList> SplitComplexPolygonCleanup(IList<Point2D> orig)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x110F910", Offset = "0x110F910", VA = "0x110F910")]
		public PolygonUtil()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class EdgeIntersectInfo
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3CD8", Offset = "0x6C3CD8")]
		private Edge <EdgeOne>k__BackingField;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3CE8", Offset = "0x6C3CE8")]
		private Edge <EdgeTwo>k__BackingField;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3CF8", Offset = "0x6C3CF8")]
		private Point2D <IntersectionPoint>k__BackingField;

		[Token(Token = "0x17000045")]
		public Edge EdgeOne
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x10FF88C", Offset = "0x10FF88C", VA = "0x10FF88C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C59DC", Offset = "0x6C59DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x10FF894", Offset = "0x10FF894", VA = "0x10FF894")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C59EC", Offset = "0x6C59EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public Edge EdgeTwo
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x10FF89C", Offset = "0x10FF89C", VA = "0x10FF89C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C59FC", Offset = "0x6C59FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x10FF8A4", Offset = "0x10FF8A4", VA = "0x10FF8A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5A0C", Offset = "0x6C5A0C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public Point2D IntersectionPoint
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x10FF8AC", Offset = "0x10FF8AC", VA = "0x10FF8AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5A1C", Offset = "0x6C5A1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x10FF8B4", Offset = "0x10FF8B4", VA = "0x10FF8B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5A2C", Offset = "0x6C5A2C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x10FF84C", Offset = "0x10FF84C", VA = "0x10FF84C")]
		public EdgeIntersectInfo(Edge edgeOne, Edge edgeTwo, Point2D intersectionPoint)
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6C2448", Offset = "0x6C2448")]
	public class SplitComplexPolygonNode
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<SplitComplexPolygonNode> mConnected;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Point2D mPosition;

		[Token(Token = "0x17000048")]
		public int NumConnected
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x110F1D4", Offset = "0x110F1D4", VA = "0x110F1D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000049")]
		public Point2D Position
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x111042C", Offset = "0x111042C", VA = "0x111042C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x1110434", Offset = "0x1110434", VA = "0x1110434")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public SplitComplexPolygonNode Item
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x110EC28", Offset = "0x110EC28", VA = "0x110EC28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x111043C", Offset = "0x111043C", VA = "0x111043C")]
		public SplitComplexPolygonNode()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x110EAFC", Offset = "0x110EAFC", VA = "0x110EAFC")]
		public SplitComplexPolygonNode(Point2D pos)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x11104AC", Offset = "0x11104AC", VA = "0x11104AC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1110574", Offset = "0x1110574", VA = "0x1110574")]
		public bool Equals(SplitComplexPolygonNode pn)
		{
			return default(bool);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1110598", Offset = "0x1110598", VA = "0x1110598", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x110ECA0", Offset = "0x110ECA0", VA = "0x110ECA0")]
		public static bool operator ==(SplitComplexPolygonNode lhs, SplitComplexPolygonNode rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x110F224", Offset = "0x110F224", VA = "0x110F224")]
		public static bool operator !=(SplitComplexPolygonNode lhs, SplitComplexPolygonNode rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x11105A0", Offset = "0x11105A0", VA = "0x11105A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x11106F4", Offset = "0x11106F4", VA = "0x11106F4")]
		private bool IsRighter(double sinA, double cosA, double sinB, double cosB)
		{
			return default(bool);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1110734", Offset = "0x1110734", VA = "0x1110734")]
		private int remainder(int x, int modulus)
		{
			return default(int);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x110EB80", Offset = "0x110EB80", VA = "0x110EB80")]
		public void AddConnection(SplitComplexPolygonNode toMe)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x110F16C", Offset = "0x110F16C", VA = "0x110F16C")]
		public void RemoveConnection(SplitComplexPolygonNode fromMe)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x111074C", Offset = "0x111074C", VA = "0x111074C")]
		private void RemoveConnectionByIndex(int index)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x110F270", Offset = "0x110F270", VA = "0x110F270")]
		public void ClearConnections()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x11107D4", Offset = "0x11107D4", VA = "0x11107D4")]
		private bool IsConnectedTo(SplitComplexPolygonNode me)
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x110F608", Offset = "0x110F608", VA = "0x110F608")]
		public SplitComplexPolygonNode GetRightestConnection(SplitComplexPolygonNode incoming)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x110F2C8", Offset = "0x110F2C8", VA = "0x110F2C8")]
		public SplitComplexPolygonNode GetRightestConnection(Point2D incomingDir)
		{
			return null;
		}
	}
	[Token(Token = "0x2000047")]
	public class PolygonOperationContext
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PolygonUtil.PolyOperation mOperations;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Point2DList mOriginalPolygon1;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Point2DList mOriginalPolygon2;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Point2DList mPoly1;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Point2DList mPoly2;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<EdgeIntersectInfo> mIntersections;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int mStartingIndex;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public PolygonUtil.PolyUnionError mError;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<int> mPoly1VectorAngles;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<int> mPoly2VectorAngles;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Dictionary<uint, Point2DList> mOutput;

		[Token(Token = "0x1700004B")]
		public Point2DList Union
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x1109BA0", Offset = "0x1109BA0", VA = "0x1109BA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public Point2DList Intersect
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x1109C54", Offset = "0x1109C54", VA = "0x1109C54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public Point2DList Subtract
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x1109D08", Offset = "0x1109D08", VA = "0x1109D08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1109DBC", Offset = "0x1109DBC", VA = "0x1109DBC")]
		public PolygonOperationContext()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1109E2C", Offset = "0x1109E2C", VA = "0x1109E2C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1109EB8", Offset = "0x1109EB8", VA = "0x1109EB8")]
		public bool Init(PolygonUtil.PolyOperation operations, Point2DList polygon1, Point2DList polygon2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x110A5B8", Offset = "0x110A5B8", VA = "0x110A5B8")]
		private bool VerticesIntersect(Point2DList polygon1, Point2DList polygon2, out List<EdgeIntersectInfo> intersections)
		{
			return default(bool);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x110A858", Offset = "0x110A858", VA = "0x110A858")]
		public bool PointInPolygonAngle(Point2D point, Point2DList polygon)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x110A974", Offset = "0x110A974", VA = "0x110A974")]
		public double VectorAngle(Point2D p1, Point2D p2)
		{
			return default(double);
		}
	}
	[Token(Token = "0x2000048")]
	public class ConstrainedPointSet : PointSet
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Dictionary<uint, TriangulationConstraint> mConstraintMap;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected List<Contour> mHoles;

		[Token(Token = "0x1700004E")]
		public override TriangulationMode TriangulationMode
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0xE705D0", Offset = "0xE705D0", VA = "0xE705D0", Slot = "61")]
			get
			{
				return default(TriangulationMode);
			}
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xE705D8", Offset = "0xE705D8", VA = "0xE705D8")]
		public ConstrainedPointSet(List<TriangulationPoint> bounds)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xE70A14", Offset = "0xE70A14", VA = "0xE70A14")]
		public ConstrainedPointSet(List<TriangulationPoint> bounds, List<TriangulationConstraint> constraints)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xE70CAC", Offset = "0xE70CAC", VA = "0xE70CAC")]
		public ConstrainedPointSet(List<TriangulationPoint> bounds, int[] indices)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xE70688", Offset = "0xE70688", VA = "0xE70688")]
		protected void AddBoundaryConstraints()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xE71090", Offset = "0xE71090", VA = "0xE71090", Slot = "19")]
		public override void Add(Point2D p)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xE7112C", Offset = "0xE7112C", VA = "0xE7112C", Slot = "62")]
		public override void Add(TriangulationPoint p)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xE7113C", Offset = "0xE7113C", VA = "0xE7113C", Slot = "63")]
		public override bool AddRange(List<TriangulationPoint> points)
		{
			return default(bool);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xE7124C", Offset = "0xE7124C", VA = "0xE7124C")]
		public bool AddHole(List<TriangulationPoint> points, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xE70AD4", Offset = "0xE70AD4", VA = "0xE70AD4")]
		public bool AddConstraints(List<TriangulationConstraint> constraints)
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xE70E9C", Offset = "0xE70E9C", VA = "0xE70E9C")]
		public bool AddConstraint(TriangulationConstraint tc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xE71B64", Offset = "0xE71B64", VA = "0xE71B64")]
		public bool TryGetConstraint(uint constraintCode, out TriangulationConstraint tc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xE71BD4", Offset = "0xE71BD4", VA = "0xE71BD4")]
		public int GetNumConstraints()
		{
			return default(int);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xE71C2C", Offset = "0xE71C2C", VA = "0xE71C2C")]
		public Dictionary<uint, TriangulationConstraint>.Enumerator GetConstraintEnumerator()
		{
			return default(Dictionary<uint, TriangulationConstraint>.Enumerator);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xE71C98", Offset = "0xE71C98", VA = "0xE71C98")]
		public int GetNumHoles()
		{
			return default(int);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xE71EB4", Offset = "0xE71EB4", VA = "0xE71EB4")]
		public Contour GetHole(int idx)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xE71F3C", Offset = "0xE71F3C", VA = "0xE71F3C")]
		public int GetActualHoles(out List<Contour> holes)
		{
			return default(int);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xE721AC", Offset = "0xE721AC", VA = "0xE721AC")]
		protected void InitializeHoles()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xE73264", Offset = "0xE73264", VA = "0xE73264", Slot = "65")]
		public override bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xE7328C", Offset = "0xE7328C", VA = "0xE7328C", Slot = "66")]
		public override void Prepare(TriangulationContext tcx)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xE73394", Offset = "0xE73394", VA = "0xE73394", Slot = "64")]
		public override void AddTriangle(DelaunayTriangle t)
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6C2480", Offset = "0x6C2480")]
	public class PointSet : Point2DList, ITriangulatable, IEnumerable<TriangulationPoint>, IEnumerable, IList<TriangulationPoint>, ICollection<TriangulationPoint>
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Dictionary<uint, TriangulationPoint> mPointMap;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3D08", Offset = "0x6C3D08")]
		private IList<DelaunayTriangle> <Triangles>k__BackingField;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3D18", Offset = "0x6C3D18")]
		private string <FileName>k__BackingField;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3D28", Offset = "0x6C3D28")]
		private bool <DisplayFlipX>k__BackingField;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3D38", Offset = "0x6C3D38")]
		private bool <DisplayFlipY>k__BackingField;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3D48", Offset = "0x6C3D48")]
		private float <DisplayRotate>k__BackingField;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected double mPrecision;

		[Token(Token = "0x1700004F")]
		public IList<TriangulationPoint> Points
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x110628C", Offset = "0x110628C", VA = "0x110628C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x1106290", Offset = "0x1106290", VA = "0x1106290")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public IList<DelaunayTriangle> Triangles
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x1106294", Offset = "0x1106294", VA = "0x1106294", Slot = "27")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5A3C", Offset = "0x6C5A3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x110629C", Offset = "0x110629C", VA = "0x110629C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5A4C", Offset = "0x6C5A4C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public string FileName
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x11062A4", Offset = "0x11062A4", VA = "0x11062A4", Slot = "29")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5A5C", Offset = "0x6C5A5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x11062AC", Offset = "0x11062AC", VA = "0x11062AC", Slot = "30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5A6C", Offset = "0x6C5A6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public bool DisplayFlipX
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x11062B4", Offset = "0x11062B4", VA = "0x11062B4", Slot = "31")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5A7C", Offset = "0x6C5A7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x11062BC", Offset = "0x11062BC", VA = "0x11062BC", Slot = "32")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5A8C", Offset = "0x6C5A8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool DisplayFlipY
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x11062C8", Offset = "0x11062C8", VA = "0x11062C8", Slot = "33")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5A9C", Offset = "0x6C5A9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x11062D0", Offset = "0x11062D0", VA = "0x11062D0", Slot = "34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5AAC", Offset = "0x6C5AAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public float DisplayRotate
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x11062DC", Offset = "0x11062DC", VA = "0x11062DC", Slot = "35")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5ABC", Offset = "0x6C5ABC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x11062E4", Offset = "0x11062E4", VA = "0x11062E4", Slot = "36")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5ACC", Offset = "0x6C5ACC")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public double Precision
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x11062EC", Offset = "0x11062EC", VA = "0x11062EC", Slot = "37")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x11062F4", Offset = "0x11062F4", VA = "0x11062F4", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public double MinX
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x11062FC", Offset = "0x11062FC", VA = "0x11062FC", Slot = "39")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000057")]
		public double MaxX
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x1106318", Offset = "0x1106318", VA = "0x1106318", Slot = "40")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000058")]
		public double MinY
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x1106334", Offset = "0x1106334", VA = "0x1106334", Slot = "41")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000059")]
		public double MaxY
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x1106350", Offset = "0x1106350", VA = "0x1106350", Slot = "42")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700005A")]
		public Rect2D Bounds
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x110636C", Offset = "0x110636C", VA = "0x110636C", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public virtual TriangulationMode TriangulationMode
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x1106374", Offset = "0x1106374", VA = "0x1106374", Slot = "61")]
			get
			{
				return default(TriangulationMode);
			}
		}

		[Token(Token = "0x1700005C")]
		public new TriangulationPoint Item
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x110637C", Offset = "0x110637C", VA = "0x110637C", Slot = "49")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1106434", Offset = "0x1106434", VA = "0x1106434", Slot = "50")]
			set
			{
			}
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x11064A4", Offset = "0x11064A4", VA = "0x11064A4")]
		public PointSet(List<TriangulationPoint> bounds)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x110676C", Offset = "0x110676C", VA = "0x110676C", Slot = "48")]
		private IEnumerator<TriangulationPoint> System.Collections.Generic.IEnumerable<Poly2Tri.TriangulationPoint>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1106810", Offset = "0x1106810", VA = "0x1106810", Slot = "51")]
		public int IndexOf(TriangulationPoint p)
		{
			return default(int);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1106878", Offset = "0x1106878", VA = "0x1106878", Slot = "19")]
		public override void Add(Point2D p)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1106910", Offset = "0x1106910", VA = "0x1106910", Slot = "62")]
		public virtual void Add(TriangulationPoint p)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x110691C", Offset = "0x110691C", VA = "0x110691C", Slot = "20")]
		protected override void Add(Point2D p, int idx, bool constrainToBounds)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1106670", Offset = "0x1106670", VA = "0x1106670")]
		protected bool Add(TriangulationPoint p, int idx, bool constrainToBounds)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1106B9C", Offset = "0x1106B9C", VA = "0x1106B9C", Slot = "22")]
		public override void AddRange(IEnumerator<Point2D> iter, WindingOrderType windingOrder)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1106D40", Offset = "0x1106D40", VA = "0x1106D40", Slot = "63")]
		public virtual bool AddRange(List<TriangulationPoint> points)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1106E4C", Offset = "0x1106E4C", VA = "0x1106E4C")]
		public bool TryGetPoint(double x, double y, out TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1106FE8", Offset = "0x1106FE8", VA = "0x1106FE8", Slot = "52")]
		public void Insert(int idx, TriangulationPoint item)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1107058", Offset = "0x1107058", VA = "0x1107058", Slot = "24")]
		public override bool Remove(Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x11070C0", Offset = "0x11070C0", VA = "0x11070C0", Slot = "60")]
		public bool Remove(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1107128", Offset = "0x1107128", VA = "0x1107128", Slot = "25")]
		public override void RemoveAt(int idx)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x11071B4", Offset = "0x11071B4", VA = "0x11071B4", Slot = "58")]
		public bool Contains(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x110721C", Offset = "0x110721C", VA = "0x110721C", Slot = "59")]
		public void CopyTo(TriangulationPoint[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x11073E4", Offset = "0x11073E4", VA = "0x11073E4")]
		protected bool ConstrainPointToBounds(Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x11069C4", Offset = "0x11069C4", VA = "0x11069C4")]
		protected bool ConstrainPointToBounds(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x11075BC", Offset = "0x11075BC", VA = "0x11075BC", Slot = "64")]
		public virtual void AddTriangle(DelaunayTriangle t)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1107680", Offset = "0x1107680", VA = "0x1107680", Slot = "46")]
		public void AddTriangles(IEnumerable<DelaunayTriangle> list)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x11078E4", Offset = "0x11078E4", VA = "0x11078E4", Slot = "47")]
		public void ClearTriangles()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1107998", Offset = "0x1107998", VA = "0x1107998", Slot = "65")]
		public virtual bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x11079A0", Offset = "0x11079A0", VA = "0x11079A0", Slot = "66")]
		public virtual void Prepare(TriangulationContext tcx)
		{
		}
	}
	[Token(Token = "0x200004A")]
	public enum TriangulationAlgorithm
	{
		[Token(Token = "0x40001C2")]
		DTSweep
	}
	[Token(Token = "0x200004B")]
	public class Edge
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected Point2D mP;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Point2D mQ;

		[Token(Token = "0x1700005D")]
		public Point2D EdgeStart
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x10FF7CC", Offset = "0x10FF7CC", VA = "0x10FF7CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x10FF7D4", Offset = "0x10FF7D4", VA = "0x10FF7D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public Point2D EdgeEnd
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x10FF7DC", Offset = "0x10FF7DC", VA = "0x10FF7DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x10FF7E4", Offset = "0x10FF7E4", VA = "0x10FF7E4")]
			set
			{
			}
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x10FF7EC", Offset = "0x10FF7EC", VA = "0x10FF7EC")]
		public Edge()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x10FF814", Offset = "0x10FF814", VA = "0x10FF814")]
		public Edge(Point2D edgeStart, Point2D edgeEnd)
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class TriangulationConstraint : Edge
	{
		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private uint mContraintCode;

		[Token(Token = "0x1700005F")]
		public TriangulationPoint P
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x10FEC48", Offset = "0x10FEC48", VA = "0x10FEC48")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x111083C", Offset = "0x111083C", VA = "0x111083C")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public TriangulationPoint Q
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x10FECCC", Offset = "0x10FECCC", VA = "0x10FECCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x1110894", Offset = "0x1110894", VA = "0x1110894")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public uint ConstraintCode
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x11108B0", Offset = "0x11108B0", VA = "0x11108B0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x11108B8", Offset = "0x11108B8", VA = "0x11108B8")]
		public TriangulationConstraint(TriangulationPoint p1, TriangulationPoint p2)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x11109B4", Offset = "0x11109B4", VA = "0x11109B4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1110858", Offset = "0x1110858", VA = "0x1110858")]
		public void CalculateContraintCode()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1110BC8", Offset = "0x1110BC8", VA = "0x1110BC8")]
		public static uint CalculateContraintCode(TriangulationPoint p, TriangulationPoint q)
		{
			return default(uint);
		}
	}
	[Token(Token = "0x200004D")]
	public abstract class TriangulationContext
	{
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3D58", Offset = "0x6C3D58")]
		private TriangulationDebugContext <DebugContext>k__BackingField;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly List<DelaunayTriangle> Triangles;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly List<TriangulationPoint> Points;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3D68", Offset = "0x6C3D68")]
		private TriangulationMode <TriangulationMode>k__BackingField;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3D78", Offset = "0x6C3D78")]
		private ITriangulatable <Triangulatable>k__BackingField;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3D88", Offset = "0x6C3D88")]
		private int <StepCount>k__BackingField;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3D98", Offset = "0x6C3D98")]
		private bool <IsDebugEnabled>k__BackingField;

		[Token(Token = "0x17000062")]
		public TriangulationDebugContext DebugContext
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x1110CC8", Offset = "0x1110CC8", VA = "0x1110CC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5ADC", Offset = "0x6C5ADC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x1110CD0", Offset = "0x1110CD0", VA = "0x1110CD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5AEC", Offset = "0x6C5AEC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public TriangulationMode TriangulationMode
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x1110CD8", Offset = "0x1110CD8", VA = "0x1110CD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5AFC", Offset = "0x6C5AFC")]
			get
			{
				return default(TriangulationMode);
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x1110CE0", Offset = "0x1110CE0", VA = "0x1110CE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5B0C", Offset = "0x6C5B0C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public ITriangulatable Triangulatable
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x1110CE8", Offset = "0x1110CE8", VA = "0x1110CE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5B1C", Offset = "0x6C5B1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x1110CF0", Offset = "0x1110CF0", VA = "0x1110CF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5B2C", Offset = "0x6C5B2C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public int StepCount
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x1110CF8", Offset = "0x1110CF8", VA = "0x1110CF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5B3C", Offset = "0x6C5B3C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x1110D00", Offset = "0x1110D00", VA = "0x1110D00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5B4C", Offset = "0x6C5B4C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public abstract TriangulationAlgorithm Algorithm
		{
			[Token(Token = "0x60002E4")]
			get;
		}

		[Token(Token = "0x17000067")]
		public virtual bool IsDebugEnabled
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x1110EB8", Offset = "0x1110EB8", VA = "0x1110EB8", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5B5C", Offset = "0x6C5B5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x1110EC0", Offset = "0x1110EC0", VA = "0x1110EC0", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5B6C", Offset = "0x6C5B6C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public DTSweepDebugContext DTDebugContext
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x1110ECC", Offset = "0x1110ECC", VA = "0x1110ECC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1110D08", Offset = "0x1110D08", VA = "0x1110D08")]
		public void Done()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1110D18", Offset = "0x1110D18", VA = "0x1110D18", Slot = "5")]
		public virtual void PrepareTriangulation(ITriangulatable t)
		{
		}

		[Token(Token = "0x60002E6")]
		public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b);

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x10FD4CC", Offset = "0x10FD4CC", VA = "0x10FD4CC")]
		public void Update(string message)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1110E44", Offset = "0x1110E44", VA = "0x1110E44", Slot = "7")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1110F50", Offset = "0x1110F50", VA = "0x1110F50")]
		protected TriangulationContext()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public abstract class TriangulationDebugContext
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected TriangulationContext _tcx;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x10FD68C", Offset = "0x10FD68C", VA = "0x10FD68C")]
		public TriangulationDebugContext(TriangulationContext tcx)
		{
		}

		[Token(Token = "0x60002EE")]
		public abstract void Clear();
	}
	[Token(Token = "0x200004F")]
	public enum TriangulationMode
	{
		[Token(Token = "0x40001CF")]
		Unconstrained,
		[Token(Token = "0x40001D0")]
		Constrained,
		[Token(Token = "0x40001D1")]
		Polygon
	}
	[Token(Token = "0x2000050")]
	public class TriangulationPoint : Point2D
	{
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly double kVertexCodeDefaultPrecision;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected uint mVertexCode;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3DA8", Offset = "0x6C3DA8")]
		private List<DTSweepConstraint> <Edges>k__BackingField;

		[Token(Token = "0x17000069")]
		public override double X
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x1110FEC", Offset = "0x1110FEC", VA = "0x1110FEC", Slot = "5")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x1110FF4", Offset = "0x1110FF4", VA = "0x1110FF4", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public override double Y
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x1111090", Offset = "0x1111090", VA = "0x1111090", Slot = "7")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x1111098", Offset = "0x1111098", VA = "0x1111098", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public uint VertexCode
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x1111134", Offset = "0x1111134", VA = "0x1111134")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700006C")]
		public List<DTSweepConstraint> Edges
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x111113C", Offset = "0x111113C", VA = "0x111113C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5B7C", Offset = "0x6C5B7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x1111144", Offset = "0x1111144", VA = "0x1111144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5B8C", Offset = "0x6C5B8C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public bool HasEdges
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x111114C", Offset = "0x111114C", VA = "0x111114C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x10FEFEC", Offset = "0x10FEFEC", VA = "0x10FEFEC")]
		public TriangulationPoint(double x, double y)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x111115C", Offset = "0x111115C", VA = "0x111115C")]
		public TriangulationPoint(double x, double y, double precision)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x11111FC", Offset = "0x11111FC", VA = "0x11111FC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1111278", Offset = "0x1111278", VA = "0x1111278", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1111280", Offset = "0x1111280", VA = "0x1111280", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x111132C", Offset = "0x111132C", VA = "0x111132C", Slot = "9")]
		public override void Set(double x, double y)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1106F08", Offset = "0x1106F08", VA = "0x1106F08")]
		public static uint CreateVertexCode(double x, double y, double precision)
		{
			return default(uint);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x11113D4", Offset = "0x11113D4", VA = "0x11113D4")]
		public void AddEdge(DTSweepConstraint e)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x111146C", Offset = "0x111146C", VA = "0x111146C")]
		public bool HasEdge(TriangulationPoint p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x10FF4EC", Offset = "0x10FF4EC", VA = "0x10FF4EC")]
		public bool GetEdge(TriangulationPoint p, out DTSweepConstraint edge)
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1111494", Offset = "0x1111494", VA = "0x1111494")]
		public static Point2D ToPoint2D(TriangulationPoint p)
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	public class TriangulationPointEnumerator : IEnumerator<TriangulationPoint>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected IList<Point2D> mPoints;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int position;

		[Token(Token = "0x1700006E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x11115CC", Offset = "0x11115CC", VA = "0x11115CC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public TriangulationPoint Current
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x11115D0", Offset = "0x11115D0", VA = "0x11115D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x11067DC", Offset = "0x11067DC", VA = "0x11067DC")]
		public TriangulationPointEnumerator(IList<Point2D> points)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x11114EC", Offset = "0x11114EC", VA = "0x11114EC", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x11115BC", Offset = "0x11115BC", VA = "0x11115BC", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x11115C8", Offset = "0x11115C8", VA = "0x11115C8", Slot = "5")]
		private void System.IDisposable.Dispose()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class TriangulationPointList : Point2DList
	{
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1111754", Offset = "0x1111754", VA = "0x1111754")]
		public TriangulationPointList()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class PointGenerator
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly System.Random RNG;

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1105F5C", Offset = "0x1105F5C", VA = "0x1105F5C")]
		public static List<TriangulationPoint> UniformDistribution(int n, double scale)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x11060B4", Offset = "0x11060B4", VA = "0x11060B4")]
		public static List<TriangulationPoint> UniformGrid(int n, double scale)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x11061D8", Offset = "0x11061D8", VA = "0x11061D8")]
		public PointGenerator()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class PolygonGenerator
	{
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly System.Random RNG;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static double PI_2;

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1109550", Offset = "0x1109550", VA = "0x1109550")]
		public static Polygon RandomCircleSweep(double scale, int vertexCount)
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x11098D8", Offset = "0x11098D8", VA = "0x11098D8")]
		public static Polygon RandomCircleSweep2(double scale, int vertexCount)
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1109B10", Offset = "0x1109B10", VA = "0x1109B10")]
		public PolygonGenerator()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class TriangulationUtil
	{
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x11117B8", Offset = "0x11117B8", VA = "0x11117B8")]
		public static bool SmartIncircle(Point2D pa, Point2D pb, Point2D pc, Point2D pd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x111193C", Offset = "0x111193C", VA = "0x111193C")]
		public static bool InScanArea(Point2D pa, Point2D pb, Point2D pc, Point2D pd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x11044CC", Offset = "0x11044CC", VA = "0x11044CC")]
		public static Orientation Orient2d(Point2D pa, Point2D pb, Point2D pc)
		{
			return default(Orientation);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1111A70", Offset = "0x1111A70", VA = "0x1111A70")]
		public static bool PointInBoundingBox(double xmin, double xmax, double ymin, double ymax, Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1111B18", Offset = "0x1111B18", VA = "0x1111B18")]
		public static bool PointOnLineSegment2D(Point2D lineStart, Point2D lineEnd, Point2D p, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1111BFC", Offset = "0x1111BFC", VA = "0x1111BFC")]
		public static bool PointOnLineSegment2D(double x1, double y1, double x2, double y2, double x, double y, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x11102EC", Offset = "0x11102EC", VA = "0x11102EC")]
		public static bool RectsIntersect(Rect2D r1, Rect2D r2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x110ECD8", Offset = "0x110ECD8", VA = "0x110ECD8")]
		public static bool LinesIntersect2D(Point2D ptStart0, Point2D ptEnd0, Point2D ptStart1, Point2D ptEnd1, bool firstIsSegment, bool secondIsSegment, bool coincidentEndPointCollisions, ref Point2D pIntersectionPt, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1104A44", Offset = "0x1104A44", VA = "0x1104A44")]
		public static bool LinesIntersect2D(Point2D ptStart0, Point2D ptEnd0, Point2D ptStart1, Point2D ptEnd1, ref Point2D pIntersectionPt, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1111D8C", Offset = "0x1111D8C", VA = "0x1111D8C")]
		public static double LI2DDotProduct(Point2D v0, Point2D v1)
		{
			return default(double);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x110C680", Offset = "0x110C680", VA = "0x110C680")]
		public static bool RaysIntersect2D(Point2D ptRayOrigin0, Point2D ptRayVector0, Point2D ptRayOrigin1, Point2D ptRayVector1, ref Point2D ptIntersection)
		{
			return default(bool);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1111E1C", Offset = "0x1111E1C", VA = "0x1111E1C")]
		public TriangulationUtil()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6C24B8", Offset = "0x6C24B8")]
	public struct FixedArray3<T> : IEnumerable<T>, IEnumerable where T : class
	{
		[Token(Token = "0x200014B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C30BC", Offset = "0x6C30BC")]
		private sealed class <Enumerate>d__10 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T <>2__current;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FixedArray3<T> <>4__this;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FixedArray3<T> <>3__<>4__this;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <i>5__2;

			[Token(Token = "0x1700019F")]
			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Token(Token = "0x600093A")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600093C")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000937")]
			[DebuggerHidden]
			public <Enumerate>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000938")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000939")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600093B")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600093D")]
			[DebuggerHidden]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600093E")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T _0;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T _1;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T _2;

		[Token(Token = "0x17000070")]
		public T Item
		{
			[Token(Token = "0x600031E")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031F")]
			set
			{
			}
		}

		[Token(Token = "0x6000320")]
		public bool Contains(T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		public int IndexOf(T value)
		{
			return default(int);
		}

		[Token(Token = "0x6000322")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000323")]
		public void Clear(T value)
		{
		}

		[Token(Token = "0x6000324")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6C5B9C", Offset = "0x6C5B9C")]
		private IEnumerable<T> Enumerate()
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6C24F0", Offset = "0x6C24F0")]
	public struct FixedBitArray3 : IEnumerable<bool>, IEnumerable
	{
		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C30CC", Offset = "0x6C30CC")]
		private sealed class <Enumerate>d__10 : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool <>2__current;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public FixedBitArray3 <>4__this;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
			public FixedBitArray3 <>3__<>4__this;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int <i>5__2;

			[Token(Token = "0x170001A1")]
			private bool System.Collections.Generic.IEnumerator<System.Boolean>.Current
			{
				[Token(Token = "0x6000942")]
				[Address(RVA = "0x10FFBD0", Offset = "0x10FFBD0", VA = "0x10FFBD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170001A2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000944")]
				[Address(RVA = "0x10FFC38", Offset = "0x10FFC38", VA = "0x10FFC38", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x10FFA5C", Offset = "0x10FFA5C", VA = "0x10FFA5C")]
			[DebuggerHidden]
			public <Enumerate>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0x10FFB50", Offset = "0x10FFB50", VA = "0x10FFB50", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0x10FFB54", Offset = "0x10FFB54", VA = "0x10FFB54", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000943")]
			[Address(RVA = "0x10FFBD8", Offset = "0x10FFBD8", VA = "0x10FFBD8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000945")]
			[Address(RVA = "0x10FFC9C", Offset = "0x10FFC9C", VA = "0x10FFC9C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<bool> System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000946")]
			[Address(RVA = "0x10FFD50", Offset = "0x10FFD50", VA = "0x10FFD50", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool _0;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public bool _1;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public bool _2;

		[Token(Token = "0x17000071")]
		public bool Item
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x10FE790", Offset = "0x10FE790", VA = "0x10FE790")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x10FEB44", Offset = "0x10FEB44", VA = "0x10FEB44")]
			set
			{
			}
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x10FF8BC", Offset = "0x10FF8BC", VA = "0x10FF8BC")]
		public bool Contains(bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x10FF914", Offset = "0x10FF914", VA = "0x10FF914")]
		public int IndexOf(bool value)
		{
			return default(int);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x10FF968", Offset = "0x10FF968", VA = "0x10FF968")]
		public void Clear()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x10FF974", Offset = "0x10FF974", VA = "0x10FF974")]
		public void Clear(bool value)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x10FF9D0", Offset = "0x10FF9D0", VA = "0x10FF9D0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6C5C00", Offset = "0x6C5C00")]
		private IEnumerable<bool> Enumerate()
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x10FFA94", Offset = "0x10FFA94", VA = "0x10FFA94", Slot = "4")]
		public IEnumerator<bool> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x10FFB4C", Offset = "0x10FFB4C", VA = "0x10FFB4C", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000058")]
	public class MathUtil
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static double EPSILON;

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x10FFD54", Offset = "0x10FFD54", VA = "0x10FFD54")]
		public static bool AreValuesEqual(double val1, double val2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x10FFDE8", Offset = "0x10FFDE8", VA = "0x10FFDE8")]
		public static bool AreValuesEqual(double val1, double val2, double tolerance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x10FFE08", Offset = "0x10FFE08", VA = "0x10FFE08")]
		public static bool IsValueBetween(double val, double min, double max, double tolerance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x10FFE40", Offset = "0x10FFE40", VA = "0x10FFE40")]
		public static double RoundWithPrecision(double f, double precision)
		{
			return default(double);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x10FFED4", Offset = "0x10FFED4", VA = "0x10FFED4")]
		public static double Clamp(double a, double low, double high)
		{
			return default(double);
		}

		[Token(Token = "0x6000335")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x10FFF68", Offset = "0x10FFF68", VA = "0x10FFF68")]
		public static uint Jenkins32Hash(byte[] data, uint nInitialValue)
		{
			return default(uint);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x10FFFD8", Offset = "0x10FFFD8", VA = "0x10FFFD8")]
		public MathUtil()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class Point2D : IComparable<Point2D>
	{
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected double mX;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected double mY;

		[Token(Token = "0x17000072")]
		public virtual double X
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x1100594", Offset = "0x1100594", VA = "0x1100594", Slot = "5")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x110059C", Offset = "0x110059C", VA = "0x110059C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public virtual double Y
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x11005A4", Offset = "0x11005A4", VA = "0x11005A4", Slot = "7")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x11005AC", Offset = "0x11005AC", VA = "0x11005AC", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public float Xf
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x11005B4", Offset = "0x11005B4", VA = "0x11005B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000075")]
		public float Yf
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x11005D4", Offset = "0x11005D4", VA = "0x11005D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x11005F4", Offset = "0x11005F4", VA = "0x11005F4")]
		public Point2D()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x110061C", Offset = "0x110061C", VA = "0x110061C")]
		public Point2D(double x, double y)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1100654", Offset = "0x1100654", VA = "0x1100654")]
		public Point2D(Point2D p)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x11006AC", Offset = "0x11006AC", VA = "0x11006AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x110086C", Offset = "0x110086C", VA = "0x110086C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1100874", Offset = "0x1100874", VA = "0x1100874", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1100920", Offset = "0x1100920", VA = "0x1100920")]
		public bool Equals(Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1100928", Offset = "0x1100928", VA = "0x1100928")]
		public bool Equals(Point2D p, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1100A50", Offset = "0x1100A50", VA = "0x1100A50", Slot = "4")]
		public int CompareTo(Point2D other)
		{
			return default(int);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1100B40", Offset = "0x1100B40", VA = "0x1100B40", Slot = "9")]
		public virtual void Set(double x, double y)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1100B84", Offset = "0x1100B84", VA = "0x1100B84", Slot = "10")]
		public virtual void Set(Point2D p)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1100BE8", Offset = "0x1100BE8", VA = "0x1100BE8")]
		public void Add(Point2D p)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1100C84", Offset = "0x1100C84", VA = "0x1100C84")]
		public void Add(double scalar)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1100CEC", Offset = "0x1100CEC", VA = "0x1100CEC")]
		public void Subtract(Point2D p)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1100D88", Offset = "0x1100D88", VA = "0x1100D88")]
		public void Subtract(double scalar)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1100DF0", Offset = "0x1100DF0", VA = "0x1100DF0")]
		public void Multiply(Point2D p)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1100E8C", Offset = "0x1100E8C", VA = "0x1100E8C")]
		public void Multiply(double scalar)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1100EF4", Offset = "0x1100EF4", VA = "0x1100EF4")]
		public void Divide(Point2D p)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1100F90", Offset = "0x1100F90", VA = "0x1100F90")]
		public void Divide(double scalar)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1100FF8", Offset = "0x1100FF8", VA = "0x1100FF8")]
		public void Negate()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1101054", Offset = "0x1101054", VA = "0x1101054")]
		public double Magnitude()
		{
			return default(double);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1101144", Offset = "0x1101144", VA = "0x1101144")]
		public double MagnitudeSquared()
		{
			return default(double);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x11011C4", Offset = "0x11011C4", VA = "0x11011C4")]
		public double MagnitudeReciprocal()
		{
			return default(double);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x11011E0", Offset = "0x11011E0", VA = "0x11011E0")]
		public void Normalize()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x110120C", Offset = "0x110120C", VA = "0x110120C")]
		public double Dot(Point2D p)
		{
			return default(double);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x110129C", Offset = "0x110129C", VA = "0x110129C")]
		public double Cross(Point2D p)
		{
			return default(double);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x110132C", Offset = "0x110132C", VA = "0x110132C")]
		public void Clamp(Point2D low, Point2D high)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1101488", Offset = "0x1101488", VA = "0x1101488")]
		public void Abs()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1101538", Offset = "0x1101538", VA = "0x1101538")]
		public void Reciprocal()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x11015E0", Offset = "0x11015E0", VA = "0x11015E0")]
		public void Translate(Point2D vector)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x11015E4", Offset = "0x11015E4", VA = "0x11015E4")]
		public void Translate(double x, double y)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1101650", Offset = "0x1101650", VA = "0x1101650")]
		public void Scale(Point2D vector)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1101654", Offset = "0x1101654", VA = "0x1101654")]
		public void Scale(double scalar)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1101658", Offset = "0x1101658", VA = "0x1101658")]
		public void Scale(double x, double y)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x11016C4", Offset = "0x11016C4", VA = "0x11016C4")]
		public void Rotate(double radians)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x11017AC", Offset = "0x11017AC", VA = "0x11017AC")]
		public void RotateDegrees(double degrees)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x11017C8", Offset = "0x11017C8", VA = "0x11017C8")]
		public static double Dot(Point2D lhs, Point2D rhs)
		{
			return default(double);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1101858", Offset = "0x1101858", VA = "0x1101858")]
		public static double Cross(Point2D lhs, Point2D rhs)
		{
			return default(double);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x11018E8", Offset = "0x11018E8", VA = "0x11018E8")]
		public static Point2D Clamp(Point2D a, Point2D low, Point2D high)
		{
			return null;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1101970", Offset = "0x1101970", VA = "0x1101970")]
		public static Point2D Min(Point2D a, Point2D b)
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1101AA4", Offset = "0x1101AA4", VA = "0x1101AA4")]
		public static Point2D Max(Point2D a, Point2D b)
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1101BD8", Offset = "0x1101BD8", VA = "0x1101BD8")]
		public static Point2D Abs(Point2D a)
		{
			return null;
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1101C98", Offset = "0x1101C98", VA = "0x1101C98")]
		public static Point2D Reciprocal(Point2D a)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1101D40", Offset = "0x1101D40", VA = "0x1101D40")]
		public static Point2D Perpendicular(Point2D lhs, double scalar)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1101DF0", Offset = "0x1101DF0", VA = "0x1101DF0")]
		public static Point2D Perpendicular(double scalar, Point2D rhs)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1101EA0", Offset = "0x1101EA0", VA = "0x1101EA0")]
		public static Point2D operator +(Point2D lhs, Point2D rhs)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1101F20", Offset = "0x1101F20", VA = "0x1101F20")]
		public static Point2D operator +(Point2D lhs, double scalar)
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1101FA0", Offset = "0x1101FA0", VA = "0x1101FA0")]
		public static Point2D operator -(Point2D lhs, Point2D rhs)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1102020", Offset = "0x1102020", VA = "0x1102020")]
		public static Point2D operator -(Point2D lhs, double scalar)
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x11020A0", Offset = "0x11020A0", VA = "0x11020A0")]
		public static Point2D operator *(Point2D lhs, Point2D rhs)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1102120", Offset = "0x1102120", VA = "0x1102120")]
		public static Point2D operator *(Point2D lhs, double scalar)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x11021A0", Offset = "0x11021A0", VA = "0x11021A0")]
		public static Point2D operator *(double scalar, Point2D lhs)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1102220", Offset = "0x1102220", VA = "0x1102220")]
		public static Point2D operator /(Point2D lhs, Point2D rhs)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x11022A0", Offset = "0x11022A0", VA = "0x11022A0")]
		public static Point2D operator /(Point2D lhs, double scalar)
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1102320", Offset = "0x1102320", VA = "0x1102320")]
		public static Point2D operator -(Point2D p)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1102390", Offset = "0x1102390", VA = "0x1102390")]
		public static bool operator <(Point2D lhs, Point2D rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x11023B4", Offset = "0x11023B4", VA = "0x11023B4")]
		public static bool operator >(Point2D lhs, Point2D rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x11023D8", Offset = "0x11023D8", VA = "0x11023D8")]
		public static bool operator <=(Point2D lhs, Point2D rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x11023FC", Offset = "0x11023FC", VA = "0x11023FC")]
		public static bool operator >=(Point2D lhs, Point2D rhs)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005A")]
	public class Point2DEnumerator : IEnumerator<Point2D>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected IList<Point2D> mPoints;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int position;

		[Token(Token = "0x17000076")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x1102534", Offset = "0x1102534", VA = "0x1102534", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public Point2D Current
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x1102538", Offset = "0x1102538", VA = "0x1102538", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1102420", Offset = "0x1102420", VA = "0x1102420")]
		public Point2DEnumerator(IList<Point2D> points)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1102454", Offset = "0x1102454", VA = "0x1102454", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1102524", Offset = "0x1102524", VA = "0x1102524", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1102530", Offset = "0x1102530", VA = "0x1102530", Slot = "5")]
		private void System.IDisposable.Dispose()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6C2528", Offset = "0x6C2528")]
	public class Point2DList : IEnumerable<Point2D>, IEnumerable, IList<Point2D>, ICollection<Point2D>
	{
		[Token(Token = "0x200014D")]
		public enum WindingOrderType
		{
			[Token(Token = "0x40006A5")]
			CW = 0,
			[Token(Token = "0x40006A6")]
			CCW = 1,
			[Token(Token = "0x40006A7")]
			Unknown = 2,
			[Token(Token = "0x40006A8")]
			Default = 1
		}

		[Token(Token = "0x200014E")]
		[Flags]
		public enum PolygonError : uint
		{
			[Token(Token = "0x40006AA")]
			None = 0u,
			[Token(Token = "0x40006AB")]
			NotEnoughVertices = 1u,
			[Token(Token = "0x40006AC")]
			NotConvex = 2u,
			[Token(Token = "0x40006AD")]
			NotSimple = 4u,
			[Token(Token = "0x40006AE")]
			AreaTooSmall = 8u,
			[Token(Token = "0x40006AF")]
			SidesTooCloseToParallel = 0x10u,
			[Token(Token = "0x40006B0")]
			TooThin = 0x20u,
			[Token(Token = "0x40006B1")]
			Degenerate = 0x40u,
			[Token(Token = "0x40006B2")]
			Unknown = 0x40000000u
		}

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int kMaxPolygonVertices;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly double kLinearSlop;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly double kAngularSlop;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected List<Point2D> mPoints;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Rect2D mBoundingBox;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected WindingOrderType mWindingOrder;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected double mEpsilon;

		[Token(Token = "0x17000078")]
		public Rect2D BoundingBox
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x110268C", Offset = "0x110268C", VA = "0x110268C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public WindingOrderType WindingOrder
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x1102694", Offset = "0x1102694", VA = "0x1102694")]
			get
			{
				return default(WindingOrderType);
			}
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x110269C", Offset = "0x110269C", VA = "0x110269C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public double Epsilon
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x1102768", Offset = "0x1102768", VA = "0x1102768")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700007B")]
		public Point2D Item
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x1102770", Offset = "0x1102770", VA = "0x1102770", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x11027E8", Offset = "0x11027E8", VA = "0x11027E8", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public int Count
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x1102858", Offset = "0x1102858", VA = "0x1102858", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007D")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x11028A8", Offset = "0x11028A8", VA = "0x11028A8", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x11028B0", Offset = "0x11028B0", VA = "0x11028B0")]
		public Point2DList()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x11029B4", Offset = "0x11029B4", VA = "0x11029B4")]
		public Point2DList(int capacity)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1102AB4", Offset = "0x1102AB4", VA = "0x1102AB4")]
		public Point2DList(IList<Point2D> l)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1102C20", Offset = "0x1102C20", VA = "0x1102C20")]
		public Point2DList(Point2DList l)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1102DD8", Offset = "0x1102DD8", VA = "0x1102DD8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1102ED8", Offset = "0x1102ED8", VA = "0x1102ED8", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1102F64", Offset = "0x1102F64", VA = "0x1102F64", Slot = "4")]
		private IEnumerator<Point2D> System.Collections.Generic.IEnumerable<Poly2Tri.Point2D>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1102FD4", Offset = "0x1102FD4", VA = "0x1102FD4", Slot = "14")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x110308C", Offset = "0x110308C", VA = "0x110308C", Slot = "8")]
		public int IndexOf(Point2D p)
		{
			return default(int);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x11030F4", Offset = "0x11030F4", VA = "0x11030F4", Slot = "19")]
		public virtual void Add(Point2D p)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x110310C", Offset = "0x110310C", VA = "0x110310C", Slot = "20")]
		protected virtual void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x11033E4", Offset = "0x11033E4", VA = "0x11033E4", Slot = "21")]
		public virtual void AddRange(Point2DList l)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x110349C", Offset = "0x110349C", VA = "0x110349C", Slot = "22")]
		public virtual void AddRange(IEnumerator<Point2D> iter, WindingOrderType windingOrder)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1103794", Offset = "0x1103794", VA = "0x1103794", Slot = "23")]
		public virtual void Insert(int idx, Point2D item)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x11037B4", Offset = "0x11037B4", VA = "0x11037B4", Slot = "24")]
		public virtual bool Remove(Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1103950", Offset = "0x1103950", VA = "0x1103950", Slot = "25")]
		public virtual void RemoveAt(int idx)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x11039E4", Offset = "0x11039E4", VA = "0x11039E4", Slot = "26")]
		public virtual void RemoveRange(int idxStart, int count)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1103A84", Offset = "0x1103A84", VA = "0x1103A84", Slot = "15")]
		public bool Contains(Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1103AEC", Offset = "0x1103AEC", VA = "0x1103AEC", Slot = "16")]
		public void CopyTo(Point2D[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1103844", Offset = "0x1103844", VA = "0x1103844")]
		public void CalculateBounds()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1103310", Offset = "0x1103310", VA = "0x1103310")]
		public double CalculateEpsilon()
		{
			return default(double);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1102738", Offset = "0x1102738", VA = "0x1102738")]
		public WindingOrderType CalculateWindingOrder()
		{
			return default(WindingOrderType);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1103D5C", Offset = "0x1103D5C", VA = "0x1103D5C")]
		public int NextIndex(int index)
		{
			return default(int);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1103D88", Offset = "0x1103D88", VA = "0x1103D88")]
		public int PreviousIndex(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1103C48", Offset = "0x1103C48", VA = "0x1103C48")]
		public double GetSignedArea()
		{
			return default(double);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1103DA8", Offset = "0x1103DA8", VA = "0x1103DA8")]
		public double GetArea()
		{
			return default(double);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1103EC8", Offset = "0x1103EC8", VA = "0x1103EC8")]
		public Point2D GetCentroid()
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1104040", Offset = "0x1104040", VA = "0x1104040")]
		public void Translate(Point2D vector)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x11040B0", Offset = "0x11040B0", VA = "0x11040B0")]
		public void Scale(Point2D value)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1104120", Offset = "0x1104120", VA = "0x1104120")]
		public void Rotate(double radians)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x11042D8", Offset = "0x11042D8", VA = "0x11042D8")]
		public bool IsDegenerate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1104674", Offset = "0x1104674", VA = "0x1104674")]
		public bool IsConvex()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1104858", Offset = "0x1104858", VA = "0x1104858")]
		public bool IsSimple()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1104A74", Offset = "0x1104A74", VA = "0x1104A74")]
		public PolygonError CheckPolygon()
		{
			return default(PolygonError);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1104F30", Offset = "0x1104F30", VA = "0x1104F30")]
		public static string GetErrorString(PolygonError error)
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1105574", Offset = "0x1105574", VA = "0x1105574")]
		public void RemoveDuplicateNeighborPoints()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1105700", Offset = "0x1105700", VA = "0x1105700")]
		public void Simplify()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1105708", Offset = "0x1105708", VA = "0x1105708")]
		public void Simplify(double bias)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1105844", Offset = "0x1105844", VA = "0x1105844")]
		public void MergeParallelEdges(double tolerance)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1105E1C", Offset = "0x1105E1C", VA = "0x1105E1C")]
		public void ProjectToAxis(Point2D axis, out double min, out double max)
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class Rect2D
	{
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double mMinX;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private double mMaxX;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private double mMinY;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private double mMaxY;

		[Token(Token = "0x1700007E")]
		public double MinX
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x110F918", Offset = "0x110F918", VA = "0x110F918")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x110F920", Offset = "0x110F920", VA = "0x110F920")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public double MaxX
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x110F928", Offset = "0x110F928", VA = "0x110F928")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x110F930", Offset = "0x110F930", VA = "0x110F930")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public double MinY
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x110F938", Offset = "0x110F938", VA = "0x110F938")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x110F940", Offset = "0x110F940", VA = "0x110F940")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public double MaxY
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x110F948", Offset = "0x110F948", VA = "0x110F948")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x110F950", Offset = "0x110F950", VA = "0x110F950")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public double Left
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x110F958", Offset = "0x110F958", VA = "0x110F958")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x110F960", Offset = "0x110F960", VA = "0x110F960")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public double Right
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x110F968", Offset = "0x110F968", VA = "0x110F968")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x110F970", Offset = "0x110F970", VA = "0x110F970")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public double Top
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x110F978", Offset = "0x110F978", VA = "0x110F978")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x110F980", Offset = "0x110F980", VA = "0x110F980")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public double Bottom
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x110F988", Offset = "0x110F988", VA = "0x110F988")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x110F990", Offset = "0x110F990", VA = "0x110F990")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public double Width
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x1103C30", Offset = "0x1103C30", VA = "0x1103C30")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000087")]
		public double Height
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x1103C3C", Offset = "0x1103C3C", VA = "0x1103C3C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000088")]
		public bool Empty
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x110F998", Offset = "0x110F998", VA = "0x110F998")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1102984", Offset = "0x1102984", VA = "0x1102984")]
		public Rect2D()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x110F9BC", Offset = "0x110F9BC", VA = "0x110F9BC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x110F9C4", Offset = "0x110F9C4", VA = "0x110F9C4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x110FA6C", Offset = "0x110FA6C", VA = "0x110FA6C")]
		public bool Equals(Rect2D r)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x110FAEC", Offset = "0x110FAEC", VA = "0x110FAEC")]
		public bool Equals(Rect2D r, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x110307C", Offset = "0x110307C", VA = "0x110307C")]
		public void Clear()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x110FC40", Offset = "0x110FC40", VA = "0x110FC40")]
		public void Set(double xmin, double xmax, double ymin, double ymax)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1102DA4", Offset = "0x1102DA4", VA = "0x1102DA4")]
		public void Set(Rect2D b)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x110FD3C", Offset = "0x110FD3C", VA = "0x110FD3C")]
		public void SetSize(double w, double h)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x110FD58", Offset = "0x110FD58", VA = "0x110FD58")]
		public bool Contains(double x, double y)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x110FD94", Offset = "0x110FD94", VA = "0x110FD94")]
		public bool Contains(Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x110FE20", Offset = "0x110FE20", VA = "0x110FE20")]
		public bool Contains(Rect2D r)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x110FE7C", Offset = "0x110FE7C", VA = "0x110FE7C")]
		public bool ContainsInclusive(double x, double y)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x110FEB8", Offset = "0x110FEB8", VA = "0x110FEB8")]
		public bool ContainsInclusive(double x, double y, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x110FF04", Offset = "0x110FF04", VA = "0x110FF04")]
		public bool ContainsInclusive(Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x110FF90", Offset = "0x110FF90", VA = "0x110FF90")]
		public bool ContainsInclusive(Point2D p, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1110030", Offset = "0x1110030", VA = "0x1110030")]
		public bool ContainsInclusive(Rect2D r)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x111008C", Offset = "0x111008C", VA = "0x111008C")]
		public bool ContainsInclusive(Rect2D r, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x110B8B4", Offset = "0x110B8B4", VA = "0x110B8B4")]
		public bool Intersects(Rect2D r)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x11100F8", Offset = "0x11100F8", VA = "0x11100F8")]
		public Point2D GetCenter()
		{
			return null;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1110188", Offset = "0x1110188", VA = "0x1110188")]
		public bool IsNormalized()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x110FC4C", Offset = "0x110FC4C", VA = "0x110FC4C")]
		public void Normalize()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x11031F0", Offset = "0x11031F0", VA = "0x11031F0")]
		public void AddPoint(Point2D p)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x11101AC", Offset = "0x11101AC", VA = "0x11101AC")]
		public void Inflate(double w, double h)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x11101D0", Offset = "0x11101D0", VA = "0x11101D0")]
		public void Inflate(double left, double top, double right, double bottom)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x11101F4", Offset = "0x11101F4", VA = "0x11101F4")]
		public void Offset(double w, double h)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1110210", Offset = "0x1110210", VA = "0x1110210")]
		public void SetPosition(double x, double y)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x111023C", Offset = "0x111023C", VA = "0x111023C")]
		public bool Intersection(Rect2D r1, Rect2D r2)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1110350", Offset = "0x1110350", VA = "0x1110350")]
		public void Union(Rect2D r1, Rect2D r2)
		{
		}
	}
}
namespace RogoDigital
{
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6C2560", Offset = "0x6C2560")]
	public class EyeController : BlendSystemUser
	{
		[Token(Token = "0x200014F")]
		public enum ControlMode
		{
			[Token(Token = "0x40006B4")]
			Classic,
			[Token(Token = "0x40006B5")]
			PoseBased
		}

		[Token(Token = "0x2000150")]
		public enum Axis
		{
			[Token(Token = "0x40006B7")]
			X_Positive,
			[Token(Token = "0x40006B8")]
			X_Negative,
			[Token(Token = "0x40006B9")]
			Y_Positive,
			[Token(Token = "0x40006BA")]
			Y_Negative,
			[Token(Token = "0x40006BB")]
			Z_Positive,
			[Token(Token = "0x40006BC")]
			Z_Negative
		}

		[Token(Token = "0x2000151")]
		public class BoneShapeInfo
		{
			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Transform bone;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 m_storedPosition;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion m_storedRotation;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Quaternion targetRotation;

			[Token(Token = "0x170001A3")]
			public Vector3 storedPosition
			{
				[Token(Token = "0x6000947")]
				[Address(RVA = "0x9E69E8", Offset = "0x9E69E8", VA = "0x9E69E8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000948")]
				[Address(RVA = "0x9E54AC", Offset = "0x9E54AC", VA = "0x9E54AC")]
				set
				{
				}
			}

			[Token(Token = "0x170001A4")]
			public Quaternion storedRotation
			{
				[Token(Token = "0x6000949")]
				[Address(RVA = "0x9E69F4", Offset = "0x9E69F4", VA = "0x9E69F4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600094A")]
				[Address(RVA = "0x9E54D4", Offset = "0x9E54D4", VA = "0x9E54D4")]
				set
				{
				}
			}

			[Token(Token = "0x600094B")]
			[Address(RVA = "0x9E0408", Offset = "0x9E0408", VA = "0x9E0408")]
			public BoneShapeInfo(BoneShape boneShape)
			{
			}
		}

		[Token(Token = "0x2000152")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C30EC", Offset = "0x6C30EC")]
		private sealed class <CloseEyes>d__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EyeController <>4__this;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool <end>5__2;

			[Token(Token = "0x170001A5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600094F")]
				[Address(RVA = "0x9E6088", Offset = "0x9E6088", VA = "0x9E6088", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000951")]
				[Address(RVA = "0x9E60F0", Offset = "0x9E60F0", VA = "0x9E60F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600094C")]
			[Address(RVA = "0x9E54FC", Offset = "0x9E54FC", VA = "0x9E54FC")]
			[DebuggerHidden]
			public <CloseEyes>d__58(int <>1__state)
			{
			}

			[Token(Token = "0x600094D")]
			[Address(RVA = "0x9E5808", Offset = "0x9E5808", VA = "0x9E5808", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600094E")]
			[Address(RVA = "0x9E580C", Offset = "0x9E580C", VA = "0x9E580C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000950")]
			[Address(RVA = "0x9E6090", Offset = "0x9E6090", VA = "0x9E6090", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000153")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C30FC", Offset = "0x6C30FC")]
		private sealed class <OpenEyes>d__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EyeController <>4__this;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool <end>5__2;

			[Token(Token = "0x170001A7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000955")]
				[Address(RVA = "0x9E6978", Offset = "0x9E6978", VA = "0x9E6978", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000957")]
				[Address(RVA = "0x9E69E0", Offset = "0x9E69E0", VA = "0x9E69E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0x9E5528", Offset = "0x9E5528", VA = "0x9E5528")]
			[DebuggerHidden]
			public <OpenEyes>d__59(int <>1__state)
			{
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0x9E60F8", Offset = "0x9E60F8", VA = "0x9E60F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000954")]
			[Address(RVA = "0x9E60FC", Offset = "0x9E60FC", VA = "0x9E60FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0x9E6980", Offset = "0x9E6980", VA = "0x9E6980", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool blinkingEnabled;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ControlMode blinkingControlMode;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shape blinkingShape;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C3DB8", Offset = "0x6C3DB8")]
		public int leftEyeBlinkBlendable;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C3DF0", Offset = "0x6C3DF0")]
		public int rightEyeBlinkBlendable;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float minimumBlinkGap;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float maximumBlinkGap;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C3E28", Offset = "0x6C3E28")]
		public float blinkDuration;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool randomLookingEnabled;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ControlMode lookingControlMode;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shape lookingUpShape;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shape lookingDownShape;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shape lookingLeftShape;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shape lookingRightShape;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C3E60", Offset = "0x6C3E60")]
		private Transform _leftEyeLookAtBone;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C3EAC", Offset = "0x6C3EAC")]
		private Transform _rightEyeLookAtBone;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector2 eyeRotationRangeX;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Vector2 eyeRotationRangeY;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 eyeLookOffset;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Axis eyeForwardAxis;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float eyeTurnSpeed;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float minimumChangeDirectionGap;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float maximumChangeDirectionGap;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool targetEnabled;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		public bool autoTarget;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string autoTargetTag;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float autoTargetDistance;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Transform viewTarget;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float targetWeight;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool boneUpdateAnimation;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float blinkTimer;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool blinking;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
		private bool _keepEyesClosed;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD6")]
		private bool _asyncBlending;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Transform leftEyeDummy;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Transform rightEyeDummy;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion leftRotation;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion rightRotation;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3[] axisOffsets;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float lookTimer;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Quaternion randomAngle;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector2 randomBlend;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Transform target;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Quaternion leftTargetAngle;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion rightTargetAngle;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Transform[] markedTargets;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Dictionary<Transform, BoneShapeInfo> boneShapes;

		[Token(Token = "0x17000089")]
		public bool keepEyesClosed
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x9DF390", Offset = "0x9DF390", VA = "0x9DF390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x9DF398", Offset = "0x9DF398", VA = "0x9DF398")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public Transform LeftEyeLookAtBone
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x9DF4E0", Offset = "0x9DF4E0", VA = "0x9DF4E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x9DF4E8", Offset = "0x9DF4E8", VA = "0x9DF4E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public Transform RightEyeLookAtBone
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x9DF9B4", Offset = "0x9DF9B4", VA = "0x9DF9B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x9DF9BC", Offset = "0x9DF9BC", VA = "0x9DF9BC")]
			set
			{
			}
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x9DFA64", Offset = "0x9DFA64", VA = "0x9DFA64")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x9E04D4", Offset = "0x9E04D4", VA = "0x9E04D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x9DF400", Offset = "0x9DF400", VA = "0x9DF400")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6C5C64", Offset = "0x6C5C64")]
		private IEnumerator CloseEyes()
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x9DF470", Offset = "0x9DF470", VA = "0x9DF470")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6C5CC8", Offset = "0x6C5CC8")]
		private IEnumerator OpenEyes()
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x9DF590", Offset = "0x9DF590", VA = "0x9DF590")]
		private void FixDummyHierarchy()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x9E0300", Offset = "0x9E0300", VA = "0x9E0300")]
		public void FindTargets()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x9E53A0", Offset = "0x9E53A0", VA = "0x9E53A0")]
		public static Vector3 Vector3LerpAngle(Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x9E5554", Offset = "0x9E5554", VA = "0x9E5554")]
		public void SetLookAtAmount(float amount)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x9E555C", Offset = "0x9E555C", VA = "0x9E555C")]
		public EyeController()
		{
		}
	}
}
namespace RogoDigital.Lipsync
{
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6C2598", Offset = "0x6C2598")]
	public class AdvancedBlendshapeBlendSystem : BlendSystem
	{
		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BlendshapeManager manager;

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x9E6A00", Offset = "0x9E6A00", VA = "0x9E6A00", Slot = "4")]
		public override void OnEnable()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x9E6BF8", Offset = "0x9E6BF8", VA = "0x9E6BF8", Slot = "9")]
		public override string[] GetBlendables()
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x9E6F30", Offset = "0x9E6F30", VA = "0x9E6F30", Slot = "5")]
		public override void SetBlendableValue(int blendable, float value)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x9E7144", Offset = "0x9E7144", VA = "0x9E7144")]
		public AdvancedBlendshapeBlendSystem()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class BlendshapeBlendSystem : BlendSystem
	{
		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SkinnedMeshRenderer characterMesh;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public SkinnedMeshRenderer[] optionalOtherMeshes;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool wireframeVisible;

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x9E7B64", Offset = "0x9E7B64", VA = "0x9E7B64", Slot = "4")]
		public override void OnEnable()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x9E7C10", Offset = "0x9E7C10", VA = "0x9E7C10", Slot = "5")]
		public override void SetBlendableValue(int blendable, float value)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x9E7D50", Offset = "0x9E7D50", VA = "0x9E7D50", Slot = "9")]
		public override string[] GetBlendables()
		{
			return null;
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x9E7F3C", Offset = "0x9E7F3C", VA = "0x9E7F3C", Slot = "6")]
		public override void OnVariableChanged()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x9E7FB8", Offset = "0x9E7FB8", VA = "0x9E7FB8")]
		[AttributeAttribute(Name = "BlendSystemButton", RVA = "0x6C5D2C", Offset = "0x6C5D2C")]
		public void ToggleWireframe()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x9E803C", Offset = "0x9E803C", VA = "0x9E803C")]
		public BlendshapeBlendSystem()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class BlendshapeManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000154")]
		public struct AdvancedBlendShape
		{
			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public BlendShapeMapping[] mappings;
		}

		[Serializable]
		[Token(Token = "0x2000155")]
		public struct BlendShapeMapping
		{
			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SkinnedMeshRenderer skinnedMeshRenderer;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int blendShapeIndex;
		}

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6C3F08", Offset = "0x6C3F08")]
		public AdvancedBlendShape[] blendShapes;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public AdvancedBlendshapeBlendSystem blendSystem;

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x9E8048", Offset = "0x9E8048", VA = "0x9E8048")]
		public BlendshapeManager()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6C25FC", Offset = "0x6C25FC")]
	public class SpriteBlendSystem : BlendSystem
	{
		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SpriteManager manager;

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x96E930", Offset = "0x96E930", VA = "0x96E930", Slot = "4")]
		public override void OnEnable()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x96EAB8", Offset = "0x96EAB8", VA = "0x96EAB8", Slot = "5")]
		public override void SetBlendableValue(int blendable, float value)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x96ED50", Offset = "0x96ED50", VA = "0x96ED50", Slot = "9")]
		public override string[] GetBlendables()
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x96F160", Offset = "0x96F160", VA = "0x96F160", Slot = "6")]
		public override void OnVariableChanged()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x96F16C", Offset = "0x96F16C", VA = "0x96F16C")]
		[AttributeAttribute(Name = "BlendSystemButton", RVA = "0x6C5D64", Offset = "0x6C5D64")]
		public void ShowHelp()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x96F1B8", Offset = "0x96F1B8", VA = "0x96F1B8")]
		public SpriteBlendSystem()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class SpriteManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000156")]
		public class SpriteGroup
		{
			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string groupName;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			public SpriteRenderer spriteRenderer;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			public Sprite defaultSprite;

			[Token(Token = "0x6000958")]
			[Address(RVA = "0x96F258", Offset = "0x96F258", VA = "0x96F258")]
			public SpriteGroup(string groupName)
			{
			}
		}

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<Sprite> availableSprites;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public List<SpriteGroup> groups;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SpriteBlendSystem blendSystem;

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x96F1C0", Offset = "0x96F1C0", VA = "0x96F1C0")]
		public SpriteManager()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6C2660", Offset = "0x6C2660")]
	public class TextureOffsetBlendSystem : BlendSystem
	{
		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextureOffsetManager manager;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<int, int> groupLookup;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<string, int> reverseGroupLookup;

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x96F52C", Offset = "0x96F52C", VA = "0x96F52C", Slot = "4")]
		public override void OnEnable()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x96F6BC", Offset = "0x96F6BC", VA = "0x96F6BC")]
		private void CacheGroups()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x96FA1C", Offset = "0x96FA1C", VA = "0x96FA1C", Slot = "5")]
		public override void SetBlendableValue(int blendable, float value)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x96FD90", Offset = "0x96FD90", VA = "0x96FD90", Slot = "9")]
		public override string[] GetBlendables()
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x97016C", Offset = "0x97016C", VA = "0x97016C", Slot = "6")]
		public override void OnVariableChanged()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x970178", Offset = "0x970178", VA = "0x970178")]
		public TextureOffsetBlendSystem()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class TextureOffsetManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000157")]
		public class MaterialTextureGroup
		{
			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string displayName;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6C5440", Offset = "0x6C5440")]
			[SerializeField]
			public Material material;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			public string texturePropertyName;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6C5488", Offset = "0x6C5488")]
			[SerializeField]
			public Texture2D defaultTexture;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			public Vector2 defaultTextureOffset;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[SerializeField]
			public Vector2 defaultTextureScale;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6C54E0", Offset = "0x6C54E0")]
			[SerializeField]
			public TextureSetting[] textureSettings;

			[Token(Token = "0x6000959")]
			[Address(RVA = "0x9701E0", Offset = "0x9701E0", VA = "0x9701E0")]
			public MaterialTextureGroup()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000158")]
		public class TextureSetting
		{
			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string displayName;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6C5528", Offset = "0x6C5528")]
			[SerializeField]
			public Texture2D texture;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			public Vector2 textureOffset;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			public Vector2 textureScale;

			[Token(Token = "0x600095A")]
			[Address(RVA = "0x970254", Offset = "0x970254", VA = "0x970254")]
			public TextureSetting()
			{
			}
		}

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public MaterialTextureGroup[] materialGroups;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public TextureOffsetBlendSystem blendSystem;

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x970180", Offset = "0x970180", VA = "0x970180")]
		public TextureOffsetManager()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[ExecuteInEditMode]
	public class BlendSystem : MonoBehaviour
	{
		[Token(Token = "0x2000159")]
		public delegate void BlendSystemGenericDelegate();

		[NonSerialized]
		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string blendableDisplayName;

		[NonSerialized]
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string blendableDisplayNamePlural;

		[NonSerialized]
		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string noBlendablesMessage;

		[NonSerialized]
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string notReadyMessage;

		[NonSerialized]
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blendRangeLow;

		[NonSerialized]
		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float blendRangeHigh;

		[NonSerialized]
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool allowResyncing;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isReady;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlendSystemUser[] users;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BlendSystemGenericDelegate onBlendablesChanged;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private List<Blendable> _blendables;

		[Token(Token = "0x1700008C")]
		public int blendableCount
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x9E6DE8", Offset = "0x9E6DE8", VA = "0x9E6DE8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x9E6BB4", Offset = "0x9E6BB4", VA = "0x9E6BB4", Slot = "4")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x9E71F0", Offset = "0x9E71F0", VA = "0x9E71F0")]
		public void Register(BlendSystemUser user)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x9E74AC", Offset = "0x9E74AC", VA = "0x9E74AC")]
		public void Unregister(BlendSystemUser user)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x9E76A4", Offset = "0x9E76A4", VA = "0x9E76A4", Slot = "5")]
		public virtual void SetBlendableValue(int blendable, float value)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x9E52F4", Offset = "0x9E52F4", VA = "0x9E52F4")]
		public float GetBlendableValue(int blendable)
		{
			return default(float);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x9E76A8", Offset = "0x9E76A8", VA = "0x9E76A8", Slot = "6")]
		public virtual void OnVariableChanged()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x9E76AC", Offset = "0x9E76AC", VA = "0x9E76AC", Slot = "7")]
		public virtual void OnBlendSystemAdded()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x9E76B0", Offset = "0x9E76B0", VA = "0x9E76B0", Slot = "8")]
		public virtual void OnBlendSystemRemoved()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x9E76B4", Offset = "0x9E76B4", VA = "0x9E76B4", Slot = "9")]
		public virtual string[] GetBlendables()
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x9E76BC", Offset = "0x9E76BC", VA = "0x9E76BC", Slot = "10")]
		public virtual void OnBlendableAddedToPose(int blendable)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x9E76C0", Offset = "0x9E76C0", VA = "0x9E76C0", Slot = "11")]
		public virtual void OnBlendableRemovedFromPose(int blendable)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x9E6E64", Offset = "0x9E6E64", VA = "0x9E6E64")]
		public void AddBlendable(int blendable, float currentValue)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x9E7700", Offset = "0x9E7700", VA = "0x9E7700")]
		public void ClearBlendables()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x9E7054", Offset = "0x9E7054", VA = "0x9E7054")]
		public void SetInternalValue(int blendable, float value)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x9E7148", Offset = "0x9E7148", VA = "0x9E7148")]
		public BlendSystem()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C26D4", Offset = "0x6C26D4")]
	public class BlendSystemButton : Attribute
	{
		[Token(Token = "0x200015A")]
		public struct Reference
		{
			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string displayName;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MethodInfo method;

			[Token(Token = "0x600095F")]
			[Address(RVA = "0x9E79E8", Offset = "0x9E79E8", VA = "0x9E79E8")]
			public Reference(string displayName, MethodInfo method)
			{
			}
		}

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string displayName;

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x9E79BC", Offset = "0x9E79BC", VA = "0x9E79BC")]
		public BlendSystemButton(string displayName)
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class BlendSystemUser : MonoBehaviour
	{
		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BlendSystem blendSystem;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x9E79F0", Offset = "0x9E79F0", VA = "0x9E79F0")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x9E7A0C", Offset = "0x9E7A0C", VA = "0x9E7A0C")]
		protected void CleanUpBlendSystems()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x9E5800", Offset = "0x9E5800", VA = "0x9E5800")]
		public BlendSystemUser()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class Blendable
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int number;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float currentWeight;

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x9E76C4", Offset = "0x9E76C4", VA = "0x9E76C4")]
		public Blendable(int number, float currentWeight)
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6C2708", Offset = "0x6C2708")]
	public class BlendshapePreset : ScriptableObject
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<PhonemeShape> phonemeShapes;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public List<EmotionShape> emotionShapes;

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x9E80A8", Offset = "0x9E80A8", VA = "0x9E80A8")]
		public BlendshapePreset()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class BoneShape
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public Transform bone;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Vector3 endPosition;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		public Vector3 endRotation;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public Vector3 endScale;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public bool lockPosition;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[SerializeField]
		public bool lockRotation;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 neutralPosition;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 neutralRotation;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 neutralScale;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x9E80B0", Offset = "0x9E80B0", VA = "0x9E80B0")]
		public void SetNeutral()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x9E8174", Offset = "0x9E8174", VA = "0x9E8174")]
		public BoneShape(Transform bone, Vector3 endPosition, Vector3 endRotation, Vector3 endScale)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x9E8268", Offset = "0x9E8268", VA = "0x9E8268")]
		public BoneShape(Transform bone, Vector3 endPosition, Vector3 endRotation)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x9E835C", Offset = "0x9E835C", VA = "0x9E835C")]
		public BoneShape()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class EmotionMarker
	{
		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string emotion;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public bool isMixer;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public EmotionMixer mixer;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public float startTime;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		public float endTime;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public float blendInTime;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		public float blendOutTime;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public bool blendToMarker;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[SerializeField]
		public bool blendFromMarker;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		[SerializeField]
		public bool customBlendIn;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		[SerializeField]
		public bool customBlendOut;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public float intensity;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public bool continuousVariation;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		public float variationFrequency;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public float intensityVariation;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		public float blendableVariation;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public float bonePositionVariation;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		public float boneRotationVariation;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool invalid;

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x9E83E4", Offset = "0x9E83E4", VA = "0x9E83E4")]
		public EmotionMarker(string emotion, float startTime, float endTime, float blendInTime, float blendOutTime, bool blendToMarker, bool blendFromMarker, bool customBlendIn, bool customBlendOut)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x9E8498", Offset = "0x9E8498", VA = "0x9E8498")]
		public EmotionMarker(EmotionMixer mixer, float startTime, float endTime, float blendInTime, float blendOutTime, bool blendToMarker, bool blendFromMarker, bool customBlendIn, bool customBlendOut)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x9E8554", Offset = "0x9E8554", VA = "0x9E8554")]
		public EmotionMarker(string emotion, float startTime, float endTime, float blendInTime, float blendOutTime, bool blendToMarker, bool blendFromMarker, bool customBlendIn, bool customBlendOut, float intensity)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x9E8618", Offset = "0x9E8618", VA = "0x9E8618")]
		public EmotionMarker CreateCopy()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class EmotionMixer
	{
		[Serializable]
		[Token(Token = "0x200015B")]
		public struct EmotionComponent
		{
			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string emotion;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float weight;

			[Token(Token = "0x6000960")]
			[Address(RVA = "0x9E9448", Offset = "0x9E9448", VA = "0x9E9448")]
			public EmotionComponent(string emotion, float weight)
			{
			}
		}

		[Token(Token = "0x200015C")]
		public enum MixingMode
		{
			[Token(Token = "0x40006E1")]
			Normal,
			[Token(Token = "0x40006E2")]
			Additive
		}

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public List<EmotionComponent> emotions;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public MixingMode mixingMode;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Color displayColor;

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x9E8710", Offset = "0x9E8710", VA = "0x9E8710")]
		public EmotionMixer()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x9E87B0", Offset = "0x9E87B0", VA = "0x9E87B0")]
		public EmotionShape GetShape(LipSync character)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x9E908C", Offset = "0x9E908C", VA = "0x9E908C")]
		public void SetWeight(int index, float weight)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x9E9094", Offset = "0x9E9094", VA = "0x9E9094")]
		public void SetWeight(int index, float weight, bool bypassMinChecks)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class EmotionShape : Shape
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public string emotion;

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x9E8FB8", Offset = "0x9E8FB8", VA = "0x9E8FB8")]
		public EmotionShape(string eEmotion)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class GestureMarker
	{
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string gesture;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public float time;

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x9E9454", Offset = "0x9E9454", VA = "0x9E9454")]
		public GestureMarker(string gesture, float time)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x9E9490", Offset = "0x9E9490", VA = "0x9E9490")]
		public GestureMarker CreateCopy()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public class LipSyncData : ScriptableObject
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip clip;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PhonemeMarker[] phonemeData;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmotionMarker[] emotionData;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GestureMarker[] gestureData;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float version;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float length;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string transcript;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve[] phonemePoseCurves;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve[] emotionPoseCurves;

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x96BCB0", Offset = "0x96BCB0", VA = "0x96BCB0")]
		public void GenerateCurves(int phonemeCount, int emotionCount)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x96C0C8", Offset = "0x96C0C8", VA = "0x96C0C8")]
		public static explicit operator LipSyncData(TemporaryLipSyncData data)
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x96C424", Offset = "0x96C424", VA = "0x96C424")]
		public LipSyncData()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public static class LipSyncExtensions
	{
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x96C494", Offset = "0x96C494", VA = "0x96C494")]
		public static Transform FindDeepChild(this Transform aParent, string aName)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x96C7B8", Offset = "0x96C7B8", VA = "0x96C7B8")]
		public static Vector3 InverseTransformEulerAngle(this Transform transform, Vector3 eulerAngle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x96C8DC", Offset = "0x96C8DC", VA = "0x96C8DC")]
		public static Vector3 TransformEulerAngle(this Transform transform, Vector3 eulerAngle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x96C87C", Offset = "0x96C87C", VA = "0x96C87C")]
		public static Vector3 ToPositiveEuler(this Vector3 eulerAngle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x96CA0C", Offset = "0x96CA0C", VA = "0x96CA0C")]
		public static Vector3 ToNegativeEuler(this Vector3 eulerAngle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x96C9A0", Offset = "0x96C9A0", VA = "0x96C9A0")]
		private static Vector3 ClampRange(Vector3 eulerAngle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x96CA74", Offset = "0x96CA74", VA = "0x96CA74")]
		public static EmotionMarker PreviousMarker(this List<EmotionMarker> list, EmotionMarker current)
		{
			return null;
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x96CB10", Offset = "0x96CB10", VA = "0x96CB10")]
		public static EmotionMarker NextMarker(this List<EmotionMarker> list, EmotionMarker current)
		{
			return null;
		}
	}
	[Token(Token = "0x2000071")]
	public class LipSyncPreset : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200015D")]
		public struct PhonemeShapeInfo
		{
			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string phonemeName;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6C5590", Offset = "0x6C5590")]
			public Phoneme phoneme;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public BlendableInfo[] blendables;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			public BoneInfo[] bones;
		}

		[Serializable]
		[Token(Token = "0x200015E")]
		public struct EmotionShapeInfo
		{
			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string emotion;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			public BlendableInfo[] blendables;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public BoneInfo[] bones;
		}

		[Serializable]
		[Token(Token = "0x200015F")]
		public struct BlendableInfo
		{
			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public int blendableNumber;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			public string blendableName;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public float weight;
		}

		[Serializable]
		[Token(Token = "0x2000160")]
		public struct BoneInfo
		{
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string path;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			public string name;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public Vector3 localPosition;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			public Vector3 localRotation;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			public bool lockPosition;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[SerializeField]
			public bool lockRotation;
		}

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isRelative;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public PhonemeShapeInfo[] phonemeShapes;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public EmotionShapeInfo[] emotionShapes;

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x96CBB0", Offset = "0x96CBB0", VA = "0x96CBB0")]
		public int FindBlendable(BlendableInfo blendable, BlendSystem blendSystem)
		{
			return default(int);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x96D0B8", Offset = "0x96D0B8", VA = "0x96D0B8")]
		public Transform FindBone(BoneInfo bone, Transform searchRoot)
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x96D180", Offset = "0x96D180", VA = "0x96D180")]
		public void CreateFromShapes(PhonemeShape[] phonemes, EmotionShape[] emotions, BlendSystem blendSystem, bool relative)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x96E0E0", Offset = "0x96E0E0", VA = "0x96E0E0")]
		public LipSyncPreset()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class LipSyncProject : ScriptableObject
	{
		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public string[] emotions;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Color[] emotionColors;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public List<string> gestures;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public PhonemeSet phonemeSet;

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x96E0E8", Offset = "0x96E0E8", VA = "0x96E0E8")]
		public LipSyncProject()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class PhonemeMarker
	{
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6C4210", Offset = "0x6C4210")]
		public Phoneme phoneme;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		public int phonemeNumber;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public float time;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		public float intensity;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public bool sustain;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		public bool useRandomness;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		public float intensityRandomness;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public float blendableRandomness;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		public float bonePositionRandomness;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public float boneRotationRandomness;

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x96E158", Offset = "0x96E158", VA = "0x96E158")]
		public PhonemeMarker(int phonemeNumber, float time, float intensity, bool sustain)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x96E1C0", Offset = "0x96E1C0", VA = "0x96E1C0")]
		public PhonemeMarker(int phonemeNumber, float time)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x96E210", Offset = "0x96E210", VA = "0x96E210")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6C5E0C", Offset = "0x6C5E0C")]
		public PhonemeMarker(Phoneme phoneme, float time, float intensity, bool sustain)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x96E278", Offset = "0x96E278", VA = "0x96E278")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6C5E44", Offset = "0x6C5E44")]
		public PhonemeMarker(Phoneme phoneme, float time)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x96C358", Offset = "0x96C358", VA = "0x96C358")]
		public PhonemeMarker CreateCopy()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x6C2750", Offset = "0x6C2750")]
	public class PhonemeSet : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6C310C", Offset = "0x6C310C")]
		public class PhonemeCollection
		{
			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<string> phonemeNames;

			[Token(Token = "0x170001A9")]
			public int Length
			{
				[Token(Token = "0x6000961")]
				[Address(RVA = "0x96E3DC", Offset = "0x96E3DC", VA = "0x96E3DC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170001AA")]
			public Phoneme Item
			{
				[Token(Token = "0x6000962")]
				[Address(RVA = "0x96E42C", Offset = "0x96E42C", VA = "0x96E42C")]
				get
				{
					return default(Phoneme);
				}
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0x96E32C", Offset = "0x96E32C", VA = "0x96E32C")]
			public PhonemeCollection()
			{
			}
		}

		[Token(Token = "0x2000162")]
		public struct Phoneme
		{
			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C56BC", Offset = "0x6C56BC")]
			private string <name>k__BackingField;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C56CC", Offset = "0x6C56CC")]
			private int <number>k__BackingField;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C56DC", Offset = "0x6C56DC")]
			private int <flag>k__BackingField;

			[Token(Token = "0x170001AB")]
			public string name
			{
				[Token(Token = "0x6000964")]
				[Address(RVA = "0x96E3A0", Offset = "0x96E3A0", VA = "0x96E3A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C657C", Offset = "0x6C657C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000965")]
				[Address(RVA = "0x96E3A8", Offset = "0x96E3A8", VA = "0x96E3A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C658C", Offset = "0x6C658C")]
				private set
				{
				}
			}

			[Token(Token = "0x170001AC")]
			public int number
			{
				[Token(Token = "0x6000966")]
				[Address(RVA = "0x96E3B0", Offset = "0x96E3B0", VA = "0x96E3B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C659C", Offset = "0x6C659C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000967")]
				[Address(RVA = "0x96E3B8", Offset = "0x96E3B8", VA = "0x96E3B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C65AC", Offset = "0x6C65AC")]
				private set
				{
				}
			}

			[Token(Token = "0x170001AD")]
			public int flag
			{
				[Token(Token = "0x6000968")]
				[Address(RVA = "0x96E3C0", Offset = "0x96E3C0", VA = "0x96E3C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C65BC", Offset = "0x6C65BC")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000969")]
				[Address(RVA = "0x96E3C8", Offset = "0x96E3C8", VA = "0x96E3C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C65CC", Offset = "0x6C65CC")]
				private set
				{
				}
			}

			[Token(Token = "0x600096A")]
			[Address(RVA = "0x96E3D0", Offset = "0x96E3D0", VA = "0x96E3D0")]
			public Phoneme(string name, int number, int flag)
			{
			}
		}

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public string scriptingName;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public PhonemeCollection phonemes;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public Texture2D[] guideImages;

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x96E2C8", Offset = "0x96E2C8", VA = "0x96E2C8")]
		public PhonemeSet()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public class PhonemeShape : Shape
	{
		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public string phonemeName;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6C432C", Offset = "0x6C432C")]
		public Phoneme phoneme;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x96E4E4", Offset = "0x96E4E4", VA = "0x96E4E4")]
		public PhonemeShape(string phonemeName)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x96E6A4", Offset = "0x96E6A4", VA = "0x96E6A4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6C5E7C", Offset = "0x6C5E7C")]
		public PhonemeShape(Phoneme ePhoneme)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class Shape
	{
		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public List<int> blendShapes;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<string> blendableNames;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public List<float> weights;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public List<BoneShape> bones;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public bool verified;

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x96E774", Offset = "0x96E774", VA = "0x96E774")]
		public bool HasBone(Transform bone)
		{
			return default(bool);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x96E854", Offset = "0x96E854", VA = "0x96E854")]
		public int IndexOfBone(Transform bone)
		{
			return default(int);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x96E5B4", Offset = "0x96E5B4", VA = "0x96E5B4")]
		public Shape()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class TemporaryLipSyncData : ScriptableObject
	{
		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip clip;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<PhonemeMarker> phonemeData;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<EmotionMarker> emotionData;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<GestureMarker> gestureData;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float version;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float length;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string transcript;

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x96F284", Offset = "0x96F284", VA = "0x96F284")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x96F290", Offset = "0x96F290", VA = "0x96F290")]
		public static explicit operator TemporaryLipSyncData(LipSyncData data)
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x96F4CC", Offset = "0x96F4CC", VA = "0x96F4CC")]
		public TemporaryLipSyncData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public class TransformAnimationCurve
	{
		[Token(Token = "0x2000163")]
		public struct TransformKeyframe
		{
			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float time;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Quaternion rotation;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 position;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 scale;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float inTangent;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float outTangent;

			[Token(Token = "0x600096B")]
			[Address(RVA = "0x97077C", Offset = "0x97077C", VA = "0x97077C")]
			public TransformKeyframe(float time, Vector3 position, Quaternion rotation, Vector3 scale, float inTangent, float outTangent)
			{
			}
		}

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimationCurve _posX;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimationCurve _posY;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimationCurve _posZ;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AnimationCurve _rotX;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AnimationCurve _rotY;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AnimationCurve _rotZ;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AnimationCurve _rotW;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AnimationCurve _scaleX;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AnimationCurve _scaleY;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AnimationCurve _scaleZ;

		[Token(Token = "0x1700008D")]
		public TransformKeyframe[] keys
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x9702C8", Offset = "0x9702C8", VA = "0x9702C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public int length
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x9707AC", Offset = "0x9707AC", VA = "0x9707AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008F")]
		public WrapMode postWrapMode
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x9707C8", Offset = "0x9707C8", VA = "0x9707C8")]
			get
			{
				return default(WrapMode);
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x9707E4", Offset = "0x9707E4", VA = "0x9707E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public WrapMode preWrapMode
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x9708C8", Offset = "0x9708C8", VA = "0x9708C8")]
			get
			{
				return default(WrapMode);
			}
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x9708E4", Offset = "0x9708E4", VA = "0x9708E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x9709C8", Offset = "0x9709C8", VA = "0x9709C8")]
		public int AddKey(float time, Vector3 position, Quaternion rotation, Vector3 scale, float inTangent, float outTangent)
		{
			return default(int);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x970DFC", Offset = "0x970DFC", VA = "0x970DFC")]
		public int AddKey(float time, Vector3 position, Quaternion rotation, float inTangent, float outTangent)
		{
			return default(int);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x971130", Offset = "0x971130", VA = "0x971130")]
		public int AddKey(float time, Quaternion rotation, float inTangent, float outTangent)
		{
			return default(int);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x971364", Offset = "0x971364", VA = "0x971364")]
		public int AddKey(float time, Vector3 position, float inTangent, float outTangent)
		{
			return default(int);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x9714B4", Offset = "0x9714B4", VA = "0x9714B4")]
		public int AddKey(float time, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			return default(int);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x971684", Offset = "0x971684", VA = "0x971684")]
		public int AddKey(float time, Vector3 position, Quaternion rotation)
		{
			return default(int);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x97180C", Offset = "0x97180C", VA = "0x97180C")]
		public int AddKey(float time, Quaternion rotation)
		{
			return default(int);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x971940", Offset = "0x971940", VA = "0x971940")]
		public int AddKey(float time, Vector3 position)
		{
			return default(int);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x9719C8", Offset = "0x9719C8", VA = "0x9719C8")]
		public int AddKey(TransformKeyframe keyframe)
		{
			return default(int);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x971CC8", Offset = "0x971CC8", VA = "0x971CC8")]
		public Vector3 EvaluateScale(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x971D6C", Offset = "0x971D6C", VA = "0x971D6C")]
		public Vector3 EvaluatePosition(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x971E10", Offset = "0x971E10", VA = "0x971E10")]
		public Quaternion EvaluateRotation(float time)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x971ECC", Offset = "0x971ECC", VA = "0x971ECC")]
		public TransformAnimationCurve()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x970DF8", Offset = "0x970DF8", VA = "0x970DF8")]
		private Vector3 CentreAngles(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x972018", Offset = "0x972018", VA = "0x972018")]
		public void FixQuaternionContinuity()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6C279C", Offset = "0x6C279C")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6C279C", Offset = "0x6C279C")]
	public class LipSync : BlendSystemUser
	{
		[Token(Token = "0x2000164")]
		public delegate void ResetDelegate();

		[Token(Token = "0x2000165")]
		public enum AnimationTimingMode
		{
			[Token(Token = "0x40006FE")]
			AudioPlayback,
			[Token(Token = "0x40006FF")]
			CustomTimer,
			[Token(Token = "0x4000700")]
			FixedFrameRate
		}

		[Token(Token = "0x2000166")]
		public enum CurveGenerationMode
		{
			[Token(Token = "0x4000702")]
			Tight,
			[Token(Token = "0x4000703")]
			Loose
		}

		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3144", Offset = "0x6C3144")]
		private sealed class <StopAudioSource>d__92 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LipSync <>4__this;

			[Token(Token = "0x170001AE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000973")]
				[Address(RVA = "0x96B9EC", Offset = "0x96B9EC", VA = "0x96B9EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000975")]
				[Address(RVA = "0x96BA54", Offset = "0x96BA54", VA = "0x96BA54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000970")]
			[Address(RVA = "0x96B900", Offset = "0x96B900", VA = "0x96B900")]
			[DebuggerHidden]
			public <StopAudioSource>d__92(int <>1__state)
			{
			}

			[Token(Token = "0x6000971")]
			[Address(RVA = "0x96B92C", Offset = "0x96B92C", VA = "0x96B92C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000972")]
			[Address(RVA = "0x96B930", Offset = "0x96B930", VA = "0x96B930", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0x96B9F4", Offset = "0x96B9F4", VA = "0x96B9F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource audioSource;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool useBones;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool boneUpdateAnimation;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public List<PhonemeShape> phonemes;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public List<EmotionShape> emotions;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool playOnAwake;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool loop;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LipSyncData defaultClip;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float defaultDelay;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool scaleAudioSpeed;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationTimingMode m_animationTimingMode;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int frameRate;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float restTime;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float restHoldTime;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public CurveGenerationMode phonemeCurveGenerationMode;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public CurveGenerationMode emotionCurveGenerationMode;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool keepEmotionWhenFinished;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C43F8", Offset = "0x6C43F8")]
		private bool <IsPlaying>k__BackingField;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C4408", Offset = "0x6C4408")]
		private bool <IsPaused>k__BackingField;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C4418", Offset = "0x6C4418")]
		private bool <IsStopping>k__BackingField;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Animator gesturesAnimator;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int gesturesLayer;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<GestureInstance> gestures;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UnityEvent onFinishedPlaying;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioClip audioClip;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool ready;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Dictionary<string, EmotionShape> emotionCache;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int currentFileID;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private LipSyncData lastClip;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float emotionBlendTime;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float emotionTimer;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool changingEmotion;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int customEmotion;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float customTimer;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool isDelaying;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<PhonemeMarker> phonemeMarkers;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private List<EmotionMarker> emotionMarkers;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<GestureMarker> gestureMarkers;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float fileLength;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int nextGesture;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<int> indexBlendables;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public List<AnimationCurve> animCurves;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private List<Transform> bones;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<TransformAnimationCurve> boneCurves;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<Vector3> boneNeutralPositions;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private List<Vector3> boneNeutralScales;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private List<Quaternion> boneNeutralRotations;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public ResetDelegate reset;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public float lastUsedVersion;

		[Token(Token = "0x17000091")]
		public AnimationTimingMode animationTimingMode
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x9E9508", Offset = "0x9E9508", VA = "0x9E9508")]
			get
			{
				return default(AnimationTimingMode);
			}
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x9E9510", Offset = "0x9E9510", VA = "0x9E9510")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x9E9518", Offset = "0x9E9518", VA = "0x9E9518")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5EB4", Offset = "0x6C5EB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x9E9520", Offset = "0x9E9520", VA = "0x9E9520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5EC4", Offset = "0x6C5EC4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool IsPaused
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x9E952C", Offset = "0x9E952C", VA = "0x9E952C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5ED4", Offset = "0x6C5ED4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x9E9534", Offset = "0x9E9534", VA = "0x9E9534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5EE4", Offset = "0x6C5EE4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool IsStopping
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x9E9540", Offset = "0x9E9540", VA = "0x9E9540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5EF4", Offset = "0x6C5EF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x9E9548", Offset = "0x9E9548", VA = "0x9E9548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5F04", Offset = "0x6C5F04")]
			private set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public float CurrentTime
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x9E9554", Offset = "0x9E9554", VA = "0x9E9554")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x9E9590", Offset = "0x9E9590", VA = "0x9E9590")]
		private void Reset()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x9E95C8", Offset = "0x9E95C8", VA = "0x9E95C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x9EA180", Offset = "0x9EA180", VA = "0x9EA180")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x9EB110", Offset = "0x9EB110", VA = "0x9EB110")]
		public void SetEmotion(string emotion, float blendTime)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x9EC7A8", Offset = "0x9EC7A8", VA = "0x9EC7A8")]
		public void ResetEmotion(float blendTime)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x9E9EFC", Offset = "0x9E9EFC", VA = "0x9E9EFC")]
		public void Play(LipSyncData dataFile, float delay)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x9EB108", Offset = "0x9EB108", VA = "0x9EB108")]
		public void Play(LipSyncData dataFile)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x9F64EC", Offset = "0x9F64EC", VA = "0x9F64EC")]
		public void Play(TextAsset xmlFile, AudioClip clip, float delay)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x9F748C", Offset = "0x9F748C", VA = "0x9F748C")]
		public void Play(TextAsset xmlFile, AudioClip clip)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x9F7494", Offset = "0x9F7494", VA = "0x9F7494")]
		public void PlayFromTime(LipSyncData dataFile, float delay, float time)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x9F7688", Offset = "0x9F7688", VA = "0x9F7688")]
		public void PlayFromTime(LipSyncData dataFile, float time)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x9F7694", Offset = "0x9F7694", VA = "0x9F7694")]
		public void PlayFromTime(TextAsset xmlFile, AudioClip clip, float delay, float time)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x9F7868", Offset = "0x9F7868", VA = "0x9F7868")]
		public void PlayFromTime(TextAsset xmlFile, AudioClip clip, float time)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x9F7874", Offset = "0x9F7874", VA = "0x9F7874")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x9F78D4", Offset = "0x9F78D4", VA = "0x9F78D4")]
		public void Resume()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x9EABD4", Offset = "0x9EABD4", VA = "0x9EABD4")]
		public void Stop(bool stopAudio)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x9F7930", Offset = "0x9F7930", VA = "0x9F7930")]
		public void PreviewAtTime(float time)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x9F7C54", Offset = "0x9F7C54", VA = "0x9F7C54")]
		public void DisplayEmotionPose(int emotion, float intensity)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x9F80A0", Offset = "0x9F80A0", VA = "0x9F80A0")]
		public void ResetDisplayedEmotions()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x9F84A8", Offset = "0x9F84A8", VA = "0x9F84A8")]
		public void PreviewAudioAtTime(float time, float length)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x9F863C", Offset = "0x9F863C", VA = "0x9F863C")]
		public void TempLoad(List<PhonemeMarker> pData, List<EmotionMarker> eData, AudioClip clip, float duration)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x9F86F0", Offset = "0x9F86F0", VA = "0x9F86F0")]
		public void TempLoad(PhonemeMarker[] pData, EmotionMarker[] eData, AudioClip clip, float duration)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x9ECDD0", Offset = "0x9ECDD0", VA = "0x9ECDD0")]
		public void ProcessData()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x9F89DC", Offset = "0x9F89DC", VA = "0x9F89DC")]
		public void ClearDataCache()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x9F89E4", Offset = "0x9F89E4", VA = "0x9F89E4")]
		private void FixEmotionBlends(ref List<EmotionMarker> data)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x9F8AE0", Offset = "0x9F8AE0", VA = "0x9F8AE0")]
		private void FixEmotionBlends(ref EmotionMarker[] data)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x9F6660", Offset = "0x9F6660", VA = "0x9F6660")]
		private void LoadXML(TextAsset xmlFile, AudioClip linkedClip)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x9EC808", Offset = "0x9EC808", VA = "0x9EC808")]
		private bool LoadData(LipSyncData dataFile)
		{
			return default(bool);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x9F85BC", Offset = "0x9F85BC", VA = "0x9F85BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6C5F14", Offset = "0x6C5F14")]
		private IEnumerator StopAudioSource(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x9EAAF4", Offset = "0x9EAAF4", VA = "0x9EAAF4")]
		private GestureInstance GetGesture(string name)
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x9F8D48", Offset = "0x9F8D48", VA = "0x9F8D48")]
		public LipSync()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x9F8E18", Offset = "0x9F8E18", VA = "0x9F8E18")]
		public static int SortTime(PhonemeMarker a, PhonemeMarker b)
		{
			return default(int);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x9F8E58", Offset = "0x9F8E58", VA = "0x9F8E58")]
		public static int SortTime(GestureMarker a, GestureMarker b)
		{
			return default(int);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x9F8E98", Offset = "0x9F8E98", VA = "0x9F8E98")]
		private static int EmotionSort(EmotionMarker a, EmotionMarker b)
		{
			return default(int);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x9F8CA0", Offset = "0x9F8CA0", VA = "0x9F8CA0")]
		public static string ReadXML(XmlDocument xml, string parentElement, string elementName)
		{
			return null;
		}
	}
	[Token(Token = "0x200007A")]
	public enum Phoneme
	{
		[Token(Token = "0x40002C8")]
		AI,
		[Token(Token = "0x40002C9")]
		E,
		[Token(Token = "0x40002CA")]
		U,
		[Token(Token = "0x40002CB")]
		O,
		[Token(Token = "0x40002CC")]
		CDGKNRSThYZ,
		[Token(Token = "0x40002CD")]
		FV,
		[Token(Token = "0x40002CE")]
		L,
		[Token(Token = "0x40002CF")]
		MBP,
		[Token(Token = "0x40002D0")]
		WQ,
		[Token(Token = "0x40002D1")]
		Rest
	}
}
namespace ProgressBar
{
	[Token(Token = "0x200007B")]
	public class ProgressBarBehaviour : MonoBehaviour, IIncrementable, IDecrementable
	{
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform m_FillRect;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FillerProperty m_FillerInfo;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ProgressValue m_Value;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C4438", Offset = "0x6C4438")]
		private float <TransitoryValue>k__BackingField;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text m_AttachedText;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C4458", Offset = "0x6C4458")]
		public int ProgressSpeed;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool TriggerOnComplete;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private OnCompleteEvent OnCompleteMethods;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_XOffset;

		[Token(Token = "0x17000096")]
		public FillerProperty FillerInfo
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x1111E24", Offset = "0x1111E24", VA = "0x1111E24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public float Value
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x1111ED8", Offset = "0x1111ED8", VA = "0x1111ED8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x1111FE8", Offset = "0x1111FE8", VA = "0x1111FE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public float TransitoryValue
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x1112078", Offset = "0x1112078", VA = "0x1112078")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5F78", Offset = "0x6C5F78")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x1112080", Offset = "0x1112080", VA = "0x1112080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5F88", Offset = "0x6C5F88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool isDone
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x1112088", Offset = "0x1112088", VA = "0x1112088")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009A")]
		public bool isPaused
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x11120BC", Offset = "0x11120BC", VA = "0x11120BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009B")]
		public float XOffset
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x11120E4", Offset = "0x11120E4", VA = "0x11120E4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x11121CC", Offset = "0x11121CC", VA = "0x11121CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x111240C", Offset = "0x111240C", VA = "0x111240C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x111225C", Offset = "0x111225C", VA = "0x111225C")]
		public void SetFillerSize(float Width)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1111FEC", Offset = "0x1111FEC", VA = "0x1111FEC")]
		public void SetFillerSizeAsPercentage(float Percent)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1112544", Offset = "0x1112544", VA = "0x1112544")]
		public void OnComplete()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1112560", Offset = "0x1112560", VA = "0x1112560", Slot = "4")]
		public void IncrementValue(float inc)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x11125C8", Offset = "0x11125C8", VA = "0x11125C8", Slot = "5")]
		public void DecrementValue(float dec)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1112628", Offset = "0x1112628", VA = "0x1112628")]
		public ProgressBarBehaviour()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6C280C", Offset = "0x6C280C")]
	public class ProgressRadialBehaviour : MonoBehaviour, IIncrementable, IDecrementable
	{
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Image m_Fill;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_Value;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C4484", Offset = "0x6C4484")]
		private float <TransitoryValue>k__BackingField;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_AttachedText;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float ProgressSpeed;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool TriggerOnComplete;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private OnCompleteEvent OnCompleteMethods;

		[Token(Token = "0x1700009C")]
		public float Value
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x1112638", Offset = "0x1112638", VA = "0x1112638")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x1112724", Offset = "0x1112724", VA = "0x1112724")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public float TransitoryValue
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x1112784", Offset = "0x1112784", VA = "0x1112784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5F98", Offset = "0x6C5F98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x111278C", Offset = "0x111278C", VA = "0x111278C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5FA8", Offset = "0x6C5FA8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public bool isDone
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x1112794", Offset = "0x1112794", VA = "0x1112794")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009F")]
		public bool isPaused
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x11127A8", Offset = "0x11127A8", VA = "0x11127A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x11127B8", Offset = "0x11127B8", VA = "0x11127B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1112930", Offset = "0x1112930", VA = "0x1112930")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x111281C", Offset = "0x111281C", VA = "0x111281C")]
		public void SetFillerSize(float fill)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1112754", Offset = "0x1112754", VA = "0x1112754")]
		public void SetFillerSizeAsPercentage(float Percent)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1112A30", Offset = "0x1112A30", VA = "0x1112A30")]
		public void OnComplete()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1112A4C", Offset = "0x1112A4C", VA = "0x1112A4C", Slot = "4")]
		public void IncrementValue(float inc)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1112A70", Offset = "0x1112A70", VA = "0x1112A70", Slot = "5")]
		public void DecrementValue(float dec)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1112A94", Offset = "0x1112A94", VA = "0x1112A94")]
		public ProgressRadialBehaviour()
		{
		}
	}
}
namespace ProgressBar.Utils
{
	[Token(Token = "0x200007D")]
	public interface IIncrementable
	{
		[Token(Token = "0x60004AB")]
		void IncrementValue(float inc);
	}
	[Token(Token = "0x200007E")]
	public interface IDecrementable
	{
		[Token(Token = "0x60004AC")]
		void DecrementValue(float dec);
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class OnCompleteEvent : UnityEvent
	{
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x9D7AEC", Offset = "0x9D7AEC", VA = "0x9D7AEC")]
		public OnCompleteEvent()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class FillerProperty
	{
		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float MaxWidth;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float MinWidth;

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x9D7AB4", Offset = "0x9D7AB4", VA = "0x9D7AB4")]
		public FillerProperty(float Min, float Max)
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class ProgressValue
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_Value;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float m_MaxValue;

		[Token(Token = "0x170000A0")]
		public float AsFloat
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x9D7B34", Offset = "0x9D7B34", VA = "0x9D7B34")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A1")]
		public int AsInt
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x9D7B3C", Offset = "0x9D7B3C", VA = "0x9D7B3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A2")]
		public float Normalized
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x9D7B60", Offset = "0x9D7B60", VA = "0x9D7B60")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A3")]
		public float PercentAsFloat
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x9D7B6C", Offset = "0x9D7B6C", VA = "0x9D7B6C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A4")]
		public float PercentAsInt
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x9D7B84", Offset = "0x9D7B84", VA = "0x9D7B84")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x9D7AF4", Offset = "0x9D7AF4", VA = "0x9D7AF4")]
		public ProgressValue(float value, float MaxValue)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x9D7B2C", Offset = "0x9D7B2C", VA = "0x9D7B2C")]
		public void Set(float newValue)
		{
		}
	}
}
namespace JBrothers.PreIntegratedSkinShader2
{
	[Token(Token = "0x2000082")]
	public class PreIntegratedSkinProfile : ScriptableObject
	{
		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector4 gauss6_1;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector4 gauss6_2;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector4 gauss6_3;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector4 gauss6_4;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector4 gauss6_5;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector4 gauss6_6;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileHigh_weighths1_var1;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileHigh_weighths2_var2;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileHigh_weighths3_var3;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileHigh_weighths4_var4;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileHigh_weighths5_var5;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileHigh_weighths6_var6;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileHigh_sqrtvar1234;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileHigh_transl123_sqrtvar5;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileHigh_transl456_sqrtvar6;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileMedium_weighths1_var1;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileMedium_weighths2_var2;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileMedium_weighths3_var3;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileMedium_transl123;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileMedium_sqrtvar123;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileLow_weighths1_var1;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileLow_weighths2_var2;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileLow_sqrtvar12;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[HideInInspector]
		[SerializeField]
		private Vector4 _PSSProfileLow_transl;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[HideInInspector]
		public bool needsRenormalize;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x199")]
		[HideInInspector]
		public bool needsRecalcDerived;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[HideInInspector]
		public Texture2D referenceTexture;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xC24AD8", Offset = "0xC24AD8", VA = "0xC24AD8")]
		public void NormalizeOriginalWeights()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xC24B5C", Offset = "0xC24B5C", VA = "0xC24B5C")]
		public void RecalculateDerived()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xC2551C", Offset = "0xC2551C", VA = "0xC2551C")]
		public void ApplyProfile(Material material)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xC25524", Offset = "0xC25524", VA = "0xC25524")]
		public void ApplyProfile(Material material, bool noWarn)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xC25810", Offset = "0xC25810", VA = "0xC25810")]
		public PreIntegratedSkinProfile()
		{
		}
	}
}
namespace VLB
{
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6C2870", Offset = "0x6C2870")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6C2870", Offset = "0x6C2870")]
	public class BeamGeometry : MonoBehaviour
	{
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C48D4", Offset = "0x6C48D4")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C48E4", Offset = "0x6C48E4")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C48F4", Offset = "0x6C48F4")]
		private Material <material>k__BackingField;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C4904", Offset = "0x6C4904")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x170000A5")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xF6F4D4", Offset = "0xF6F4D4", VA = "0xF6F4D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5FB8", Offset = "0x6C5FB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xF6F4DC", Offset = "0xF6F4DC", VA = "0xF6F4DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5FC8", Offset = "0x6C5FC8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0xF6F4E4", Offset = "0xF6F4E4", VA = "0xF6F4E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5FD8", Offset = "0x6C5FD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0xF6F4EC", Offset = "0xF6F4EC", VA = "0xF6F4EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5FE8", Offset = "0x6C5FE8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public Material material
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xF6F4F4", Offset = "0xF6F4F4", VA = "0xF6F4F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C5FF8", Offset = "0x6C5FF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xF6F4FC", Offset = "0xF6F4FC", VA = "0xF6F4FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C6008", Offset = "0x6C6008")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public Mesh coneMesh
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0xF6F504", Offset = "0xF6F504", VA = "0xF6F504")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C6018", Offset = "0x6C6018")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xF6F50C", Offset = "0xF6F50C", VA = "0xF6F50C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C6028", Offset = "0x6C6028")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public bool visible
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0xF6F514", Offset = "0xF6F514", VA = "0xF6F514")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xF6F530", Offset = "0xF6F530", VA = "0xF6F530")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public int sortingLayerID
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xF6F550", Offset = "0xF6F550", VA = "0xF6F550")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0xF6F56C", Offset = "0xF6F56C", VA = "0xF6F56C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public int sortingOrder
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xF6F588", Offset = "0xF6F588", VA = "0xF6F588")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xF6F5A4", Offset = "0xF6F5A4", VA = "0xF6F5A4")]
			set
			{
			}
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xF6F5C0", Offset = "0xF6F5C0", VA = "0xF6F5C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xF6F680", Offset = "0xF6F680", VA = "0xF6F680")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xF6F728", Offset = "0xF6F728", VA = "0xF6F728")]
		public void Initialize(VolumetricLightBeam master, Shader shader)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xF6FBD8", Offset = "0xF6FBD8", VA = "0xF6FBD8")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xF713A4", Offset = "0xF713A4", VA = "0xF713A4")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xF70B2C", Offset = "0xF70B2C", VA = "0xF70B2C")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xF71CC4", Offset = "0xF71CC4", VA = "0xF71CC4")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xF71DB0", Offset = "0xF71DB0", VA = "0xF71DB0")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xF71E0C", Offset = "0xF71E0C", VA = "0xF71E0C")]
		private void OnBeginCameraRendering(Camera cam)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xF72108", Offset = "0xF72108", VA = "0xF72108")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xF71E10", Offset = "0xF71E10", VA = "0xF71E10")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xF7233C", Offset = "0xF7233C", VA = "0xF7233C")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6C28E0", Offset = "0x6C28E0")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool forceSinglePass;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader1Pass;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C494C", Offset = "0x6C494C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C494C", Offset = "0x6C494C")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader2Pass;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int sharedMeshSides;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C49CC", Offset = "0x6C49CC")]
		public float globalNoiseScale;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int noise3DSize;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x170000AC")]
		public Shader beamShader
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xF72344", Offset = "0xF72344", VA = "0xF72344")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xF72360", Offset = "0xF72360", VA = "0xF72360")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x170000AE")]
		public static Config Instance
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xF6FEB0", Offset = "0xF6FEB0", VA = "0xF6FEB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xF72398", Offset = "0xF72398", VA = "0xF72398")]
		public void Reset()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xF72554", Offset = "0xF72554", VA = "0xF72554")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xF726E8", Offset = "0xF726E8", VA = "0xF726E8")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public static class Consts
	{
		[Token(Token = "0x4000317")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x4000318")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x4000319")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x400031A")]
		public const string HelpUrlDynamicOcclusion = "http://saladgamer.com/vlb-doc/comp-dynocclusion/";

		[Token(Token = "0x400031B")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x400031C")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x400031F")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x4000320")]
		public const float Alpha = 1f;

		[Token(Token = "0x4000321")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x4000322")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x4000323")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x4000324")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x4000325")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x4000326")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x4000327")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x4000328")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x4000329")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x400032A")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x400032B")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x400032C")]
		public const bool GeomCap = false;

		[Token(Token = "0x400032D")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x400032E")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x400032F")]
		public const float FadeStart = 0f;

		[Token(Token = "0x4000330")]
		public const float FadeEnd = 3f;

		[Token(Token = "0x4000331")]
		public const float FadeMinThreshold = 0.01f;

		[Token(Token = "0x4000332")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x4000333")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x4000334")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x4000335")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x4000336")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x4000337")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x4000338")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x4000339")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x400033A")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x400033B")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x400033C")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x400033D")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x400033F")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x4000343")]
		public const float DynOcclusionMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x4000344")]
		public const float DynOcclusionMinSurfaceRatioMin = 50f;

		[Token(Token = "0x4000345")]
		public const float DynOcclusionMinSurfaceRatioMax = 100f;

		[Token(Token = "0x4000346")]
		public const float DynOcclusionMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x4000347")]
		public const float DynOcclusionMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x4000348")]
		public const float DynOcclusionMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x4000349")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x400034A")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x400034B")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x400034C")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x400034D")]
		public const bool ConfigGeometryForceSinglePassDefault = false;

		[Token(Token = "0x400034E")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x400034F")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x4000350")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x170000AF")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0xF6FA40", Offset = "0xF6FA40", VA = "0xF6FA40")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x2000086")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6C2918", Offset = "0x6C2918")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6C2918", Offset = "0x6C2918")]
	public class DynamicOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000168")]
		private enum Direction
		{
			[Token(Token = "0x4000709")]
			Up,
			[Token(Token = "0x400070A")]
			Right,
			[Token(Token = "0x400070B")]
			Down,
			[Token(Token = "0x400070C")]
			Left
		}

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask layerMask;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minOccluderArea;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int waitFrameCount;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minSurfaceRatio;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float maxSurfaceDot;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float planeOffset;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_FrameCountToWait;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_RangeMultiplier;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xF72924", Offset = "0xF72924", VA = "0xF72924")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xF729BC", Offset = "0xF729BC", VA = "0xF729BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xF72A14", Offset = "0xF72A14", VA = "0xF72A14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xF72A44", Offset = "0xF72A44", VA = "0xF72A44")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xF72B24", Offset = "0xF72B24", VA = "0xF72B24")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xF72FA8", Offset = "0xF72FA8", VA = "0xF72FA8")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xF730A4", Offset = "0xF730A4", VA = "0xF730A4")]
		private RaycastHit GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xF733D0", Offset = "0xF733D0", VA = "0xF733D0")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xF735D0", Offset = "0xF735D0", VA = "0xF735D0")]
		private bool IsHitValid(RaycastHit hit)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xF72B64", Offset = "0xF72B64", VA = "0xF72B64")]
		private void ProcessRaycasts()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xF73720", Offset = "0xF73720", VA = "0xF73720")]
		private void SetHit(RaycastHit hit)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xF72A2C", Offset = "0xF72A2C", VA = "0xF72A2C")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xF7384C", Offset = "0xF7384C", VA = "0xF7384C")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xF73984", Offset = "0xF73984", VA = "0xF73984")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xF73C04", Offset = "0xF73C04", VA = "0xF73C04")]
		public DynamicOcclusion()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public enum ColorMode
	{
		[Token(Token = "0x400035D")]
		Flat,
		[Token(Token = "0x400035E")]
		Gradient
	}
	[Token(Token = "0x2000088")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x4000360")]
		Linear,
		[Token(Token = "0x4000361")]
		Quadratic,
		[Token(Token = "0x4000362")]
		Blend
	}
	[Token(Token = "0x2000089")]
	public enum BlendingMode
	{
		[Token(Token = "0x4000364")]
		Additive,
		[Token(Token = "0x4000365")]
		SoftAdditive,
		[Token(Token = "0x4000366")]
		TraditionalTransparency
	}
	[Token(Token = "0x200008A")]
	public enum MeshType
	{
		[Token(Token = "0x4000368")]
		Shared,
		[Token(Token = "0x4000369")]
		Custom
	}
	[Token(Token = "0x200008B")]
	public enum RenderQueue
	{
		[Token(Token = "0x400036B")]
		Custom = 0,
		[Token(Token = "0x400036C")]
		Background = 1000,
		[Token(Token = "0x400036D")]
		Geometry = 2000,
		[Token(Token = "0x400036E")]
		AlphaTest = 2450,
		[Token(Token = "0x400036F")]
		GeometryLast = 2500,
		[Token(Token = "0x4000370")]
		Transparent = 3000,
		[Token(Token = "0x4000371")]
		Overlay = 4000
	}
	[Token(Token = "0x200008C")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x4000373")]
		Surface,
		[Token(Token = "0x4000374")]
		Beam
	}
	[Token(Token = "0x200008D")]
	public static class GlobalMesh
	{
		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x170000B0")]
		public static Mesh mesh
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xF7098C", Offset = "0xF7098C", VA = "0xF7098C")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x200008E")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xF73C64", Offset = "0xF73C64", VA = "0xF73C64")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public static class MeshGenerator
	{
		[Token(Token = "0x4000376")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xF73C6C", Offset = "0xF73C6C", VA = "0xF73C6C")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xF73D38", Offset = "0xF73D38", VA = "0xF73D38")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xF6FFD8", Offset = "0xF6FFD8", VA = "0xF6FFD8")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xF73D4C", Offset = "0xF73D4C", VA = "0xF73D4C")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xF73D68", Offset = "0xF73D68", VA = "0xF73D68")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xF73D90", Offset = "0xF73D90", VA = "0xF73D90")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xF73E24", Offset = "0xF73E24", VA = "0xF73E24")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000090")]
	public static class Noise3D
	{
		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x400037A")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x400037B")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x170000B1")]
		public static bool isSupported
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xF71954", Offset = "0xF71954", VA = "0xF71954")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B2")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0xF73F5C", Offset = "0xF73F5C", VA = "0xF73F5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B3")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0xF73EBC", Offset = "0xF73EBC", VA = "0xF73EBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xF73FF4", Offset = "0xF73FF4", VA = "0xF73FF4")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6C6038", Offset = "0x6C6038")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xF71AA4", Offset = "0xF71AA4", VA = "0xF71AA4")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xF74050", Offset = "0xF74050", VA = "0xF74050")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x2000091")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6C29C0", Offset = "0x6C29C0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6C29C0", Offset = "0x6C29C0")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x400037E")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh m_Mesh;

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xF74398", Offset = "0xF74398", VA = "0xF74398")]
		private void Update()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xF745B8", Offset = "0xF745B8", VA = "0xF745B8")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public static class Utils
	{
		[Token(Token = "0x2000169")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x400070E")]
			High = 64,
			[Token(Token = "0x400070F")]
			Low = 8,
			[Token(Token = "0x4000710")]
			Undef = 0
		}

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x4000381")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xF6FAB4", Offset = "0xF6FAB4", VA = "0xF6FAB4")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000502")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000503")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xF745D0", Offset = "0xF745D0", VA = "0xF745D0")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xF746B4", Offset = "0xF746B4", VA = "0xF746B4")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xF746E0", Offset = "0xF746E0", VA = "0xF746E0")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xF74710", Offset = "0xF74710", VA = "0xF74710")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xF74744", Offset = "0xF74744", VA = "0xF74744")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xF7477C", Offset = "0xF7477C", VA = "0xF7477C")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xF747B0", Offset = "0xF747B0", VA = "0xF747B0")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xF747E0", Offset = "0xF747E0", VA = "0xF747E0")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xF732E4", Offset = "0xF732E4", VA = "0xF732E4")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xF74834", Offset = "0xF74834", VA = "0xF74834")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xF74868", Offset = "0xF74868", VA = "0xF74868")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xF7399C", Offset = "0xF7399C", VA = "0xF7399C")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xF74C7C", Offset = "0xF74C7C", VA = "0xF74C7C")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xF716E4", Offset = "0xF716E4", VA = "0xF716E4")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xF74DC4", Offset = "0xF74DC4", VA = "0xF74DC4")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xF74ECC", Offset = "0xF74ECC", VA = "0xF74ECC")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xF74CC8", Offset = "0xF74CC8", VA = "0xF74CC8")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xF71614", Offset = "0xF71614", VA = "0xF71614")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xF74F78", Offset = "0xF74F78", VA = "0xF74F78")]
		public static void MarkCurrentSceneDirty()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public static class Version
	{
		[Token(Token = "0x4000382")]
		public const int Current = 1520;
	}
	[Token(Token = "0x2000094")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6C2A68", Offset = "0x6C2A68")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6C2A68", Offset = "0x6C2A68")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x200016A")]
		public enum Direction
		{
			[Token(Token = "0x4000712")]
			Beam,
			[Token(Token = "0x4000713")]
			Random
		}

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C4A08", Offset = "0x6C4A08")]
		public float alpha;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C4A20", Offset = "0x6C4A20")]
		public float size;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Direction direction;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C4A40", Offset = "0x6C4A40")]
		public float spawnMaxDistance;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool cullingEnabled;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float cullingMaxDistance;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C4A58", Offset = "0x6C4A58")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x170000B4")]
		public bool isCulled
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0xF74F80", Offset = "0xF74F80", VA = "0xF74F80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C6158", Offset = "0x6C6158")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0xF74F88", Offset = "0xF74F88", VA = "0xF74F88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C6168", Offset = "0x6C6168")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0xF74F94", Offset = "0xF74F94", VA = "0xF74F94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B6")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0xF75000", Offset = "0xF75000", VA = "0xF75000")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B7")]
		public int particlesMaxCount
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0xF75094", Offset = "0xF75094", VA = "0xF75094")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B8")]
		public Camera mainCamera
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0xF75140", Offset = "0xF75140", VA = "0xF75140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xF75398", Offset = "0xF75398", VA = "0xF75398")]
		private void Start()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xF75400", Offset = "0xF75400", VA = "0xF75400")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xF7566C", Offset = "0xF7566C", VA = "0xF7566C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xF755B0", Offset = "0xF755B0", VA = "0xF755B0")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xF75C50", Offset = "0xF75C50", VA = "0xF75C50")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xF75CF0", Offset = "0xF75CF0", VA = "0xF75CF0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xF75DB0", Offset = "0xF75DB0", VA = "0xF75DB0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xF75670", Offset = "0xF75670", VA = "0xF75670")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xF75DE4", Offset = "0xF75DE4", VA = "0xF75DE4")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xF76144", Offset = "0xF76144", VA = "0xF76144")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6C2B10", Offset = "0x6C2B10")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3154", Offset = "0x6C3154")]
		private sealed class <CoPlaytimeUpdate>d__96 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x170001B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000979")]
				[Address(RVA = "0xF77690", Offset = "0xF77690", VA = "0xF77690", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600097B")]
				[Address(RVA = "0xF776F8", Offset = "0xF776F8", VA = "0xF776F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000976")]
			[Address(RVA = "0xF77150", Offset = "0xF77150", VA = "0xF77150")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__96(int <>1__state)
			{
			}

			[Token(Token = "0x6000977")]
			[Address(RVA = "0xF77608", Offset = "0xF77608", VA = "0xF77608", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0xF7760C", Offset = "0xF7760C", VA = "0xF7760C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0xF77698", Offset = "0xF77698", VA = "0xF77698", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x6C4A68", Offset = "0x6C4A68")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C4A68", Offset = "0x6C4A68")]
		public Color color;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C4ABC", Offset = "0x6C4ABC")]
		public float alphaInside;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C4AD4", Offset = "0x6C4AD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C4AD4", Offset = "0x6C4AD4")]
		public float alphaOutside;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BlendingMode blendingMode;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C4B28", Offset = "0x6C4B28")]
		public bool spotAngleFromLight;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C4B60", Offset = "0x6C4B60")]
		public float spotAngle;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C4B80", Offset = "0x6C4B80")]
		public float coneRadiusStart;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MeshType geomMeshType;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C4BB8", Offset = "0x6C4BB8")]
		public int geomCustomSides;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int geomCustomSegments;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool geomCap;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		public bool fadeEndFromLight;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C4BF0", Offset = "0x6C4BF0")]
		public float attenuationCustomBlending;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float fadeStart;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float fadeEnd;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float depthBlendDistance;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float cameraClippingDistance;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C4C08", Offset = "0x6C4C08")]
		public float glareFrontal;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C4C20", Offset = "0x6C4C20")]
		public float glareBehind;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6C4C38", Offset = "0x6C4C38")]
		public float boostDistanceInside;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6C4C70", Offset = "0x6C4C70")]
		public float fresnelPowInside;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C4CA8", Offset = "0x6C4CA8")]
		public float fresnelPow;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool noiseEnabled;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C4CE0", Offset = "0x6C4CE0")]
		public float noiseIntensity;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6C4CF8", Offset = "0x6C4CF8")]
		public float noiseScaleLocal;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Plane m_PlaneWS;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C4D24", Offset = "0x6C4D24")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Light _CachedLight;

		[Token(Token = "0x170000B9")]
		public float coneAngle
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0xF7151C", Offset = "0xF7151C", VA = "0xF7151C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000BA")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0xF71490", Offset = "0xF71490", VA = "0xF71490")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000BB")]
		public float coneVolume
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0xF761F0", Offset = "0xF761F0", VA = "0xF761F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000BC")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0xF715BC", Offset = "0xF715BC", VA = "0xF715BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000BD")]
		public int geomSides
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0xF76244", Offset = "0xF76244", VA = "0xF76244")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0xF762CC", Offset = "0xF762CC", VA = "0xF762CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public int geomSegments
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0xF7634C", Offset = "0xF7634C", VA = "0xF7634C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0xF763D4", Offset = "0xF763D4", VA = "0xF763D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0xF7192C", Offset = "0xF7192C", VA = "0xF7192C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C0")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0xF76454", Offset = "0xF76454", VA = "0xF76454")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000533")]
			[Address(RVA = "0xF7645C", Offset = "0xF7645C", VA = "0xF7645C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public string sortingLayerName
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0xF7650C", Offset = "0xF7650C", VA = "0xF7650C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000535")]
			[Address(RVA = "0xF76518", Offset = "0xF76518", VA = "0xF76518")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public int sortingOrder
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0xF76548", Offset = "0xF76548", VA = "0xF76548")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000537")]
			[Address(RVA = "0xF76550", Offset = "0xF76550", VA = "0xF76550")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0xF76600", Offset = "0xF76600", VA = "0xF76600")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000539")]
			[Address(RVA = "0xF76608", Offset = "0xF76608", VA = "0xF76608")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0xF76668", Offset = "0xF76668", VA = "0xF76668")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C5")]
		public bool hasGeometry
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0xF75FA8", Offset = "0xF75FA8", VA = "0xF75FA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C6")]
		public Bounds bounds
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0xF76018", Offset = "0xF76018", VA = "0xF76018")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x170000C7")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0xF71834", Offset = "0xF71834", VA = "0xF71834")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C8")]
		public string meshStats
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0xF7679C", Offset = "0xF7679C", VA = "0xF7679C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		public int meshVerticesCount
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0xF76924", Offset = "0xF76924", VA = "0xF76924")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CA")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0xF76A00", Offset = "0xF76A00", VA = "0xF76A00")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CB")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0xF76AF4", Offset = "0xF76AF4", VA = "0xF76AF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xF73ABC", Offset = "0xF73ABC", VA = "0xF73ABC")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xF73B78", Offset = "0xF73B78", VA = "0xF73B78")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xF76678", Offset = "0xF76678", VA = "0xF76678")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xF76BEC", Offset = "0xF76BEC", VA = "0xF76BEC")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xF721A0", Offset = "0xF721A0", VA = "0xF721A0")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xF76C4C", Offset = "0xF76C4C", VA = "0xF76C4C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6C6178", Offset = "0x6C6178")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xF76C58", Offset = "0xF76C58", VA = "0xF76C58", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xF76F10", Offset = "0xF76F10", VA = "0xF76F10", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xF76FA4", Offset = "0xF76FA4", VA = "0xF76FA4")]
		private void Start()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xF76FB0", Offset = "0xF76FB0", VA = "0xF76FB0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xF77048", Offset = "0xF77048", VA = "0xF77048")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xF76614", Offset = "0xF76614", VA = "0xF76614")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xF770E0", Offset = "0xF770E0", VA = "0xF770E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6C61B0", Offset = "0x6C61B0")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xF7717C", Offset = "0xF7717C", VA = "0xF7717C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xF77180", Offset = "0xF77180", VA = "0xF77180")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xF77240", Offset = "0xF77240", VA = "0xF77240")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xF77324", Offset = "0xF77324", VA = "0xF77324")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xF76EE0", Offset = "0xF76EE0", VA = "0xF76EE0")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xF76E2C", Offset = "0xF76E2C", VA = "0xF76E2C")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xF774FC", Offset = "0xF774FC", VA = "0xF774FC")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace AdvancedInspector
{
	[Token(Token = "0x2000096")]
	public delegate void AdvancedInspectorForceRefresh(bool rebuil);
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2B7C", Offset = "0x6C2B7C")]
	public class AdvancedInspectorAttribute : Attribute
	{
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool inspectDefaultItems;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool showScript;

		[Token(Token = "0x170000CC")]
		public bool InspectDefaultItems
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0xEE6B68", Offset = "0xEE6B68", VA = "0xEE6B68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055E")]
			[Address(RVA = "0xEE6B70", Offset = "0xEE6B70", VA = "0xEE6B70")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public bool ShowScript
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0xEE6B7C", Offset = "0xEE6B7C", VA = "0xEE6B7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xEE6B84", Offset = "0xEE6B84", VA = "0xEE6B84")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event AdvancedInspectorForceRefresh OnForceRefresh
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0xEE6728", Offset = "0xEE6728", VA = "0xEE6728")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C6214", Offset = "0x6C6214")]
			add
			{
			}
			[Token(Token = "0x600055B")]
			[Address(RVA = "0xEE67DC", Offset = "0xEE67DC", VA = "0xEE67DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C6224", Offset = "0x6C6224")]
			remove
			{
			}
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xEE6890", Offset = "0xEE6890", VA = "0xEE6890")]
		public static void Refresh(bool rebuild = false)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xEE6B90", Offset = "0xEE6B90", VA = "0xEE6B90")]
		public AdvancedInspectorAttribute()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xEE6BA0", Offset = "0xEE6BA0", VA = "0xEE6BA0")]
		public AdvancedInspectorAttribute(bool inspectDefaultItems)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xEE6BD8", Offset = "0xEE6BD8", VA = "0xEE6BD8")]
		public AdvancedInspectorAttribute(bool inspectDefaultItems, bool showScript)
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2BB4", Offset = "0x6C2BB4")]
	public class AngleAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float snap;

		[Token(Token = "0x170000CE")]
		public float Snap
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0xEE6CD0", Offset = "0xEE6CD0", VA = "0xEE6CD0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000565")]
			[Address(RVA = "0xEE6CD8", Offset = "0xEE6CD8", VA = "0xEE6CD8")]
			set
			{
			}
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xEE6CE0", Offset = "0xEE6CE0", VA = "0xEE6CE0")]
		public AngleAttribute()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xEE6CF0", Offset = "0xEE6CF0", VA = "0xEE6CF0")]
		public AngleAttribute(float snap)
		{
		}
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2BC8", Offset = "0x6C2BC8")]
	public class BackgroundAttribute : Attribute, IRuntimeAttribute<Color>, IRuntimeAttribute
	{
		[Token(Token = "0x200016C")]
		public delegate Color BackgroundDelegate();

		[Token(Token = "0x200016D")]
		public delegate Color BackgroundStaticDelegate(BackgroundAttribute background, object instance, object value);

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Color color;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string methodName;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Delegate> delegates;

		[Token(Token = "0x170000CF")]
		public Color Color
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xEE6D2C", Offset = "0xEE6D2C", VA = "0xEE6D2C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000569")]
			[Address(RVA = "0xEE6D38", Offset = "0xEE6D38", VA = "0xEE6D38")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public string MethodName
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0xEE6D44", Offset = "0xEE6D44", VA = "0xEE6D44", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056B")]
			[Address(RVA = "0xEE6D4C", Offset = "0xEE6D4C", VA = "0xEE6D4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public Type Template
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0xEE6D54", Offset = "0xEE6D54", VA = "0xEE6D54", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D2")]
		public Type TemplateStatic
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0xEE6DC4", Offset = "0xEE6DC4", VA = "0xEE6DC4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0xEE6E34", Offset = "0xEE6E34", VA = "0xEE6E34", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056F")]
			[Address(RVA = "0xEE6E3C", Offset = "0xEE6E3C", VA = "0xEE6E3C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xEE6E44", Offset = "0xEE6E44", VA = "0xEE6E44", Slot = "6")]
		public Color Invoke(int index, object instance, object value)
		{
			return default(Color);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xEE727C", Offset = "0xEE727C", VA = "0xEE727C")]
		public BackgroundAttribute(string methodName)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xEE7320", Offset = "0xEE7320", VA = "0xEE7320")]
		public BackgroundAttribute(Delegate method)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xEE73DC", Offset = "0xEE73DC", VA = "0xEE73DC")]
		public BackgroundAttribute(float r, float g, float b)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xEE73E4", Offset = "0xEE73E4", VA = "0xEE73E4")]
		public BackgroundAttribute(float r, float g, float b, float a)
		{
		}
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2BDC", Offset = "0x6C2BDC")]
	public class BypassAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x6000575")]
		[Address(RVA = "0xEE80CC", Offset = "0xEE80CC", VA = "0xEE80CC")]
		public BypassAttribute()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2BF0", Offset = "0x6C2BF0")]
	public class CollectionAttribute : Attribute, IListAttribute, IRuntimeAttribute<string[]>, IRuntimeAttribute
	{
		[Token(Token = "0x200016E")]
		public delegate string[] CollectionDelegate();

		[Token(Token = "0x200016F")]
		public delegate string[] CollectionStaticDelegate(CollectionAttribute collection, object instance, object value);

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int size;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool sortable;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CollectionDisplay display;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int maxDisplayedItems;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int maxItemsPerRow;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool alwaysExpanded;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		private bool expandElements;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Type enumType;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string methodName;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Delegate> delegates;

		[Token(Token = "0x170000D4")]
		public int Size
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0xEE80D4", Offset = "0xEE80D4", VA = "0xEE80D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000577")]
			[Address(RVA = "0xEE80DC", Offset = "0xEE80DC", VA = "0xEE80DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public bool Sortable
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xEE80E4", Offset = "0xEE80E4", VA = "0xEE80E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000579")]
			[Address(RVA = "0xEE80EC", Offset = "0xEE80EC", VA = "0xEE80EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public CollectionDisplay Display
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0xEE80F8", Offset = "0xEE80F8", VA = "0xEE80F8")]
			get
			{
				return default(CollectionDisplay);
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0xEE8100", Offset = "0xEE8100", VA = "0xEE8100")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public int MaxDisplayedItems
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0xEE8108", Offset = "0xEE8108", VA = "0xEE8108")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0xEE8110", Offset = "0xEE8110", VA = "0xEE8110")]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public int MaxItemsPerRow
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0xEE8118", Offset = "0xEE8118", VA = "0xEE8118")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600057F")]
			[Address(RVA = "0xEE8120", Offset = "0xEE8120", VA = "0xEE8120")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public bool AlwaysExpanded
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0xEE8128", Offset = "0xEE8128", VA = "0xEE8128")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xEE8130", Offset = "0xEE8130", VA = "0xEE8130")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public bool ExpandElements
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0xEE813C", Offset = "0xEE813C", VA = "0xEE813C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000583")]
			[Address(RVA = "0xEE8144", Offset = "0xEE8144", VA = "0xEE8144")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public Type EnumType
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0xEE8150", Offset = "0xEE8150", VA = "0xEE8150")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000585")]
			[Address(RVA = "0xEE8158", Offset = "0xEE8158", VA = "0xEE8158")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public string MethodName
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0xEE8424", Offset = "0xEE8424", VA = "0xEE8424", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000587")]
			[Address(RVA = "0xEE842C", Offset = "0xEE842C", VA = "0xEE842C")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public Type Template
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0xEE8434", Offset = "0xEE8434", VA = "0xEE8434", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0xEE84A4", Offset = "0xEE84A4", VA = "0xEE84A4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DF")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0xEE8514", Offset = "0xEE8514", VA = "0xEE8514", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600058B")]
			[Address(RVA = "0xEE851C", Offset = "0xEE851C", VA = "0xEE851C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xEE8524", Offset = "0xEE8524", VA = "0xEE8524", Slot = "6")]
		public string[] Invoke(int index, object instance, object value)
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xEE8944", Offset = "0xEE8944", VA = "0xEE8944")]
		public CollectionAttribute()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xEE89E0", Offset = "0xEE89E0", VA = "0xEE89E0")]
		public CollectionAttribute(int size)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xEE8A54", Offset = "0xEE8A54", VA = "0xEE8A54")]
		public CollectionAttribute(Type enumType)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xEE8A6C", Offset = "0xEE8A6C", VA = "0xEE8A6C")]
		public CollectionAttribute(bool sortable)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xEE8A78", Offset = "0xEE8A78", VA = "0xEE8A78")]
		public CollectionAttribute(string methodName)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xEE8B5C", Offset = "0xEE8B5C", VA = "0xEE8B5C")]
		public CollectionAttribute(CollectionDisplay display)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xEE89E8", Offset = "0xEE89E8", VA = "0xEE89E8")]
		public CollectionAttribute(int size, bool sortable)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xEE8A60", Offset = "0xEE8A60", VA = "0xEE8A60")]
		public CollectionAttribute(Type enumType, bool sortable)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xEE8C90", Offset = "0xEE8C90", VA = "0xEE8C90")]
		public CollectionAttribute(int size, CollectionDisplay display)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xEE8CFC", Offset = "0xEE8CFC", VA = "0xEE8CFC")]
		public CollectionAttribute(Type enumType, CollectionDisplay display)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xEE8A88", Offset = "0xEE8A88", VA = "0xEE8A88")]
		public CollectionAttribute(string methodName, int size, bool sortable, CollectionDisplay display)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xEE8BC4", Offset = "0xEE8BC4", VA = "0xEE8BC4")]
		public CollectionAttribute(Type enumType, bool sortable, CollectionDisplay display)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xEE8D08", Offset = "0xEE8D08", VA = "0xEE8D08")]
		public CollectionAttribute(Delegate method)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xEE8E04", Offset = "0xEE8E04", VA = "0xEE8E04")]
		public CollectionAttribute(Delegate method, int size)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xEE8E10", Offset = "0xEE8E10", VA = "0xEE8E10")]
		public CollectionAttribute(Delegate method, bool sortable)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xEE8E20", Offset = "0xEE8E20", VA = "0xEE8E20")]
		public CollectionAttribute(Delegate method, CollectionDisplay display)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xEE8D18", Offset = "0xEE8D18", VA = "0xEE8D18")]
		public CollectionAttribute(Delegate method, int size, bool sortable, CollectionDisplay display)
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2C04", Offset = "0x6C2C04")]
	public class ConstructorAttribute : Attribute, IRuntimeAttribute<object>, IRuntimeAttribute
	{
		[Token(Token = "0x2000170")]
		public delegate object ConstructorDelegate();

		[Token(Token = "0x2000171")]
		public delegate object ConstructorStaticDelegate(ConstructorAttribute constructor, object instance, object value);

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string methodName;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Delegate> delegates;

		[Token(Token = "0x170000E0")]
		public string MethodName
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0xEEAF28", Offset = "0xEEAF28", VA = "0xEEAF28", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E1")]
		public Type Template
		{
			[Token(Token = "0x600059F")]
			[Address(RVA = "0xEEAF30", Offset = "0xEEAF30", VA = "0xEEAF30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E2")]
		public Type TemplateStatic
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0xEEAFA0", Offset = "0xEEAFA0", VA = "0xEEAFA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E3")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xEEB010", Offset = "0xEEB010", VA = "0xEEB010", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xEEB018", Offset = "0xEEB018", VA = "0xEEB018", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xEEB020", Offset = "0xEEB020", VA = "0xEEB020", Slot = "6")]
		public object Invoke(int index, object instance, object value)
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xEEB3D4", Offset = "0xEEB3D4", VA = "0xEEB3D4")]
		public ConstructorAttribute(string methodName)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xEEB468", Offset = "0xEEB468", VA = "0xEEB468")]
		public ConstructorAttribute(Delegate method)
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2C18", Offset = "0x6C2C18")]
	public class CreateDerivedAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool hideClassName;

		[Token(Token = "0x170000E4")]
		public bool HideClassName
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xEEBBDC", Offset = "0xEEBBDC", VA = "0xEEBBDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xEEBBE4", Offset = "0xEEBBE4", VA = "0xEEBBE4")]
			set
			{
			}
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xEEBBF0", Offset = "0xEEBBF0", VA = "0xEEBBF0")]
		public CreateDerivedAttribute()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xEEBBF8", Offset = "0xEEBBF8", VA = "0xEEBBF8")]
		public CreateDerivedAttribute(bool hideClassName)
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2C2C", Offset = "0x6C2C2C")]
	public class DescriptorAttribute : Attribute, IRuntimeAttribute, IDescriptor
	{
		[Token(Token = "0x2000172")]
		public delegate Description DescriptorDelegate();

		[Token(Token = "0x2000173")]
		public delegate Description DescriptorStaticDelegate(DescriptorAttribute descriptor, object instance, object value);

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Color TRANSPARENT;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string name;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string comment;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string url;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Texture icon;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color color;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string methodName;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Delegate> delegates;

		[Token(Token = "0x170000E5")]
		public string Name
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xEEC790", Offset = "0xEEC790", VA = "0xEEC790")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xEEC798", Offset = "0xEEC798", VA = "0xEEC798")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public string Comment
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xEEC7A0", Offset = "0xEEC7A0", VA = "0xEEC7A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xEEC7A8", Offset = "0xEEC7A8", VA = "0xEEC7A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public string URL
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0xEEC7B0", Offset = "0xEEC7B0", VA = "0xEEC7B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xEEC7B8", Offset = "0xEEC7B8", VA = "0xEEC7B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public Texture Icon
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xEEC7C0", Offset = "0xEEC7C0", VA = "0xEEC7C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xEEC7C8", Offset = "0xEEC7C8", VA = "0xEEC7C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public Color Color
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0xEEC7D0", Offset = "0xEEC7D0", VA = "0xEEC7D0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xEEC7DC", Offset = "0xEEC7DC", VA = "0xEEC7DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public string MethodName
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xEECBE8", Offset = "0xEECBE8", VA = "0xEECBE8", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EB")]
		public Type Template
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0xEECBF0", Offset = "0xEECBF0", VA = "0xEECBF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		public Type TemplateStatic
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xEECC60", Offset = "0xEECC60", VA = "0xEECC60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xEECCD0", Offset = "0xEECCD0", VA = "0xEECCD0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xEECCD8", Offset = "0xEECCD8", VA = "0xEECCD8", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xEEC7E8", Offset = "0xEEC7E8", VA = "0xEEC7E8", Slot = "11")]
		public Description GetDescription(object[] instances, object[] values)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xEECCE0", Offset = "0xEECCE0", VA = "0xEECCE0")]
		public DescriptorAttribute()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xEECD7C", Offset = "0xEECD7C", VA = "0xEECD7C")]
		public DescriptorAttribute(string methodName)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xEECE2C", Offset = "0xEECE2C", VA = "0xEECE2C")]
		public DescriptorAttribute(float r, float g, float b)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xEECFC4", Offset = "0xEECFC4", VA = "0xEECFC4")]
		public DescriptorAttribute(string name, string description)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xEED03C", Offset = "0xEED03C", VA = "0xEED03C")]
		public DescriptorAttribute(string name, string description, string url)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xEED050", Offset = "0xEED050", VA = "0xEED050")]
		public DescriptorAttribute(string name, string description, string url, float r, float g, float b)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xEECEB0", Offset = "0xEECEB0", VA = "0xEECEB0")]
		private DescriptorAttribute(string name, string description, string url, float r, float g, float b, float a)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xEED058", Offset = "0xEED058", VA = "0xEED058")]
		public DescriptorAttribute(string name, string description, Texture icon)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xEED0F4", Offset = "0xEED0F4", VA = "0xEED0F4")]
		public DescriptorAttribute(string name, string description, Texture icon, Color color)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xEED1E0", Offset = "0xEED1E0", VA = "0xEED1E0")]
		public static Description GetDescriptor(Type type)
		{
			return null;
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xEED338", Offset = "0xEED338", VA = "0xEED338")]
		public static List<Description> GetDescriptors(List<Type> types)
		{
			return null;
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2C60", Offset = "0x6C2C60")]
	public class DisplayAsParentAttribute : Attribute
	{
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool hideParent;

		[Token(Token = "0x170000EE")]
		public bool HideParent
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xEEDBE0", Offset = "0xEEDBE0", VA = "0xEEDBE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xEEDBE8", Offset = "0xEEDBE8", VA = "0xEEDBE8")]
			set
			{
			}
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xEEDBF4", Offset = "0xEEDBF4", VA = "0xEEDBF4")]
		public DisplayAsParentAttribute()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xEEDC04", Offset = "0xEEDC04", VA = "0xEEDC04")]
		public DisplayAsParentAttribute(bool hideParent)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2C74", Offset = "0x6C2C74")]
	public class DontAllowSceneObjectAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xEEDC3C", Offset = "0xEEDC3C", VA = "0xEEDC3C")]
		public DontAllowSceneObjectAttribute()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2C88", Offset = "0x6C2C88")]
	public class EnumAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool masked;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private EnumDisplay display;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int maxItemsPerRow;

		[Token(Token = "0x170000EF")]
		public bool Masked
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xEEDC44", Offset = "0xEEDC44", VA = "0xEEDC44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0xEEDC4C", Offset = "0xEEDC4C", VA = "0xEEDC4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public EnumDisplay Display
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xEEDC58", Offset = "0xEEDC58", VA = "0xEEDC58")]
			get
			{
				return default(EnumDisplay);
			}
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xEEDC60", Offset = "0xEEDC60", VA = "0xEEDC60")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public int MaxItemsPerRow
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xEEDC68", Offset = "0xEEDC68", VA = "0xEEDC68")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xEEDC70", Offset = "0xEEDC70", VA = "0xEEDC70")]
			set
			{
			}
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xEEDC78", Offset = "0xEEDC78", VA = "0xEEDC78")]
		public EnumAttribute(bool masked)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xEEDCB0", Offset = "0xEEDCB0", VA = "0xEEDCB0")]
		public EnumAttribute(EnumDisplay display)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xEEDCE4", Offset = "0xEEDCE4", VA = "0xEEDCE4")]
		public EnumAttribute(bool masked, EnumDisplay display)
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2C9C", Offset = "0x6C2C9C")]
	public class ExpandableAttribute : Attribute, IExpandable, IListAttribute
	{
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool expanded;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool expandable;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		private bool alwaysExpanded;

		[Token(Token = "0x170000F2")]
		public bool Expanded
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xEEDD2C", Offset = "0xEEDD2C", VA = "0xEEDD2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xEEDD34", Offset = "0xEEDD34", VA = "0xEEDD34")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public bool Expandable
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0xEEDD40", Offset = "0xEEDD40", VA = "0xEEDD40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xEEDD48", Offset = "0xEEDD48", VA = "0xEEDD48")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public bool AlwaysExpanded
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0xEEDD54", Offset = "0xEEDD54", VA = "0xEEDD54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xEEDD5C", Offset = "0xEEDD5C", VA = "0xEEDD5C")]
			set
			{
			}
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xEEDD68", Offset = "0xEEDD68", VA = "0xEEDD68")]
		public ExpandableAttribute()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xEEDD78", Offset = "0xEEDD78", VA = "0xEEDD78")]
		public ExpandableAttribute(bool expandable)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xEEDDB0", Offset = "0xEEDDB0", VA = "0xEEDDB0")]
		public ExpandableAttribute(bool expandable, bool expanded)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xEEDDFC", Offset = "0xEEDDFC", VA = "0xEEDDFC", Slot = "6")]
		public bool IsExpandable(object[] instances, object[] values)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xEEDE04", Offset = "0xEEDE04", VA = "0xEEDE04", Slot = "7")]
		public bool IsExpanded(object[] instances, object[] values)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xEEDE0C", Offset = "0xEEDE0C", VA = "0xEEDE0C", Slot = "8")]
		public bool IsAlwaysExpanded(object[] instances, object[] values)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2CD4", Offset = "0x6C2CD4")]
	public abstract class FieldAttribute : Attribute
	{
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int order;

		[Token(Token = "0x170000F5")]
		public int Order
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0xEEDE14", Offset = "0xEEDE14", VA = "0xEEDE14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0xEEDE1C", Offset = "0xEEDE1C", VA = "0xEEDE1C")]
			set
			{
			}
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xEEDE24", Offset = "0xEEDE24", VA = "0xEEDE24")]
		protected FieldAttribute()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2CE8", Offset = "0x6C2CE8")]
	public class FieldEditorAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string type;

		[Token(Token = "0x170000F6")]
		public string Type
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0xEEDE2C", Offset = "0xEEDE2C", VA = "0xEEDE2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xEEDE34", Offset = "0xEEDE34", VA = "0xEEDE34")]
		public FieldEditorAttribute(string type)
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2CFC", Offset = "0x6C2CFC")]
	public class GroupAttribute : Attribute
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string name;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string description;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string style;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int priority;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool expandable;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color color;

		[Token(Token = "0x170000F7")]
		public string Name
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xEEE5AC", Offset = "0xEEE5AC", VA = "0xEEE5AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xEEE5B4", Offset = "0xEEE5B4", VA = "0xEEE5B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public string Description
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xEEE5BC", Offset = "0xEEE5BC", VA = "0xEEE5BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0xEEE5C4", Offset = "0xEEE5C4", VA = "0xEEE5C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public string Style
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xEEE5CC", Offset = "0xEEE5CC", VA = "0xEEE5CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xEEE5D4", Offset = "0xEEE5D4", VA = "0xEEE5D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public int Priority
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xEEE5DC", Offset = "0xEEE5DC", VA = "0xEEE5DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xEEE5E4", Offset = "0xEEE5E4", VA = "0xEEE5E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public bool Expandable
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xEEE5EC", Offset = "0xEEE5EC", VA = "0xEEE5EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xEEE5F4", Offset = "0xEEE5F4", VA = "0xEEE5F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public Color Color
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xEEE600", Offset = "0xEEE600", VA = "0xEEE600")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xEEE60C", Offset = "0xEEE60C", VA = "0xEEE60C")]
			set
			{
			}
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xEEE618", Offset = "0xEEE618", VA = "0xEEE618")]
		public GroupAttribute(string name)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xEEE704", Offset = "0xEEE704", VA = "0xEEE704")]
		public GroupAttribute(string name, int priority)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xEEE76C", Offset = "0xEEE76C", VA = "0xEEE76C")]
		public GroupAttribute(string name, string style)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xEEE774", Offset = "0xEEE774", VA = "0xEEE774")]
		public GroupAttribute(string name, float r, float g, float b)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xEEE8FC", Offset = "0xEEE8FC", VA = "0xEEE8FC")]
		public GroupAttribute(string name, float r, float g, float b, float a)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xEEE67C", Offset = "0xEEE67C", VA = "0xEEE67C")]
		public GroupAttribute(string name, string style, int priority)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xEEE994", Offset = "0xEEE994", VA = "0xEEE994")]
		public GroupAttribute(string name, string style, float r, float g, float b)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xEEEA2C", Offset = "0xEEEA2C", VA = "0xEEEA2C")]
		public GroupAttribute(string name, string style, float r, float g, float b, float a)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xEEEAC8", Offset = "0xEEEAC8", VA = "0xEEEAC8")]
		public GroupAttribute(string name, string style, int priority, float r, float g, float b)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xEEEB6C", Offset = "0xEEEB6C", VA = "0xEEEB6C")]
		public GroupAttribute(string name, string style, int priority, float r, float g, float b, float a)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xEEE808", Offset = "0xEEE808", VA = "0xEEE808")]
		public GroupAttribute(string name, string description, string style, int priority, float r, float g, float b, float a)
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2D10", Offset = "0x6C2D10")]
	public class HelpAttribute : Attribute, IRuntimeAttribute, IHelp
	{
		[Token(Token = "0x2000174")]
		public delegate HelpItem HelpDelegate();

		[Token(Token = "0x2000175")]
		public delegate HelpItem HelpStaticDelegate(HelpAttribute help, object instance, object value);

		[Token(Token = "0x40003E5")]
		public const string IsNull = "HelpAttribute.IsValueNull";

		[Token(Token = "0x40003E6")]
		public const string IsNullOrEmpty = "HelpAttribute.IsStringNullOrEmpty";

		[Token(Token = "0x40003E7")]
		public const string IsMatch = "HelpAttribute.IsRegexMatch";

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HelpType type;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string message;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HelpPosition position;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string regex;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string methodName;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Delegate> delegates;

		[Token(Token = "0x170000FD")]
		public HelpType Type
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xEEEC14", Offset = "0xEEEC14", VA = "0xEEEC14")]
			get
			{
				return default(HelpType);
			}
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xEEEC1C", Offset = "0xEEEC1C", VA = "0xEEEC1C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public string Message
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xEEEC24", Offset = "0xEEEC24", VA = "0xEEEC24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xEEEC2C", Offset = "0xEEEC2C", VA = "0xEEEC2C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public HelpPosition Position
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0xEEEC34", Offset = "0xEEEC34", VA = "0xEEEC34")]
			get
			{
				return default(HelpPosition);
			}
			[Token(Token = "0x6000601")]
			[Address(RVA = "0xEEEC3C", Offset = "0xEEEC3C", VA = "0xEEEC3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public string Regex
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0xEEEC44", Offset = "0xEEEC44", VA = "0xEEEC44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000603")]
			[Address(RVA = "0xEEEC4C", Offset = "0xEEEC4C", VA = "0xEEEC4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public string MethodName
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0xEEF228", Offset = "0xEEF228", VA = "0xEEF228", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		public Type Template
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0xEEF230", Offset = "0xEEF230", VA = "0xEEF230", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000103")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0xEEF2A0", Offset = "0xEEF2A0", VA = "0xEEF2A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0xEEF310", Offset = "0xEEF310", VA = "0xEEF310", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000609")]
			[Address(RVA = "0xEEF318", Offset = "0xEEF318", VA = "0xEEF318", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xEEEC54", Offset = "0xEEEC54", VA = "0xEEEC54", Slot = "11")]
		public IList<HelpItem> GetHelp(object[] instances, object[] values)
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xEEF320", Offset = "0xEEF320", VA = "0xEEF320")]
		public HelpAttribute(string methodName)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xEEF43C", Offset = "0xEEF43C", VA = "0xEEF43C")]
		public HelpAttribute(string methodName, HelpType type, string message)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xEEF448", Offset = "0xEEF448", VA = "0xEEF448")]
		public HelpAttribute(HelpType type, string message)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xEEF4B4", Offset = "0xEEF4B4", VA = "0xEEF4B4")]
		public HelpAttribute(HelpType type, HelpPosition position, string message)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xEEF388", Offset = "0xEEF388", VA = "0xEEF388")]
		public HelpAttribute(string methodName, HelpType type, HelpPosition position, string message)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xEEF52C", Offset = "0xEEF52C", VA = "0xEEF52C")]
		public HelpAttribute(Delegate method)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xEEF5D8", Offset = "0xEEF5D8", VA = "0xEEF5D8")]
		private static HelpItem IsValueNull(HelpAttribute help, object instance, object value)
		{
			return null;
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xEEF744", Offset = "0xEEF744", VA = "0xEEF744")]
		private static HelpItem IsStringNullOrEmpty(HelpAttribute help, object instance, object value)
		{
			return null;
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xEEF804", Offset = "0xEEF804", VA = "0xEEF804")]
		private static HelpItem IsRegexMatch(HelpAttribute help, object instance, object value)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A7")]
	public enum HelpType
	{
		[Token(Token = "0x40003EF")]
		None,
		[Token(Token = "0x40003F0")]
		Info,
		[Token(Token = "0x40003F1")]
		Warning,
		[Token(Token = "0x40003F2")]
		Error
	}
	[Token(Token = "0x20000A8")]
	public enum HelpPosition
	{
		[Token(Token = "0x40003F4")]
		After,
		[Token(Token = "0x40003F5")]
		Before
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2D48", Offset = "0x6C2D48")]
	public class IgnoreBase : Attribute
	{
		[Token(Token = "0x6000613")]
		[Address(RVA = "0xEF00F4", Offset = "0xEF00F4", VA = "0xEF00F4")]
		public IgnoreBase()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2D5C", Offset = "0x6C2D5C")]
	public class InspectAttribute : Attribute, IRuntimeAttribute, IVisibility
	{
		[Token(Token = "0x2000176")]
		public delegate bool InspectDelegate();

		[Token(Token = "0x2000177")]
		public delegate bool InspectStaticDelegate(InspectAttribute inspect, object instance, object value);

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private InspectorLevel level;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool condition;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int priority;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string methodName;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Delegate> delegates;

		[Token(Token = "0x17000105")]
		public InspectorLevel Level
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0xEF00FC", Offset = "0xEF00FC", VA = "0xEF00FC")]
			get
			{
				return default(InspectorLevel);
			}
			[Token(Token = "0x6000615")]
			[Address(RVA = "0xEF0104", Offset = "0xEF0104", VA = "0xEF0104")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public bool Condition
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0xEF010C", Offset = "0xEF010C", VA = "0xEF010C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000617")]
			[Address(RVA = "0xEF0114", Offset = "0xEF0114", VA = "0xEF0114")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public int Priority
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0xEF0120", Offset = "0xEF0120", VA = "0xEF0120")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000619")]
			[Address(RVA = "0xEF0128", Offset = "0xEF0128", VA = "0xEF0128")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public string MethodName
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0xEF08F0", Offset = "0xEF08F0", VA = "0xEF08F0", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600061E")]
			[Address(RVA = "0xEF08F8", Offset = "0xEF08F8", VA = "0xEF08F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public Type Template
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0xEF0900", Offset = "0xEF0900", VA = "0xEF0900", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010A")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0xEF0970", Offset = "0xEF0970", VA = "0xEF0970", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010B")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0xEF09E0", Offset = "0xEF09E0", VA = "0xEF09E0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0xEF09E8", Offset = "0xEF09E8", VA = "0xEF09E8", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xEF0130", Offset = "0xEF0130", VA = "0xEF0130", Slot = "11")]
		public bool IsItemVisible(object[] instances, object[] values)
		{
			return default(bool);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xEF08E0", Offset = "0xEF08E0", VA = "0xEF08E0", Slot = "12")]
		public InspectorLevel GetItemLevel(object[] parents, object[] values)
		{
			return default(InspectorLevel);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xEF08E8", Offset = "0xEF08E8", VA = "0xEF08E8", Slot = "13")]
		public int GetItemPriority(object[] parents, object[] values)
		{
			return default(int);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xEF09F0", Offset = "0xEF09F0", VA = "0xEF09F0")]
		public InspectAttribute()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xEF0B0C", Offset = "0xEF0B0C", VA = "0xEF0B0C")]
		public InspectAttribute(int priority)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xEF0B74", Offset = "0xEF0B74", VA = "0xEF0B74")]
		public InspectAttribute(InspectorLevel level)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xEF0BDC", Offset = "0xEF0BDC", VA = "0xEF0BDC")]
		public InspectAttribute(InspectorLevel level, int priority)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xEF0C48", Offset = "0xEF0C48", VA = "0xEF0C48")]
		public InspectAttribute(InspectorLevel level, string methodName)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xEF0C54", Offset = "0xEF0C54", VA = "0xEF0C54")]
		public InspectAttribute(InspectorLevel level, string methodName, int priority)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xEF0C60", Offset = "0xEF0C60", VA = "0xEF0C60")]
		public InspectAttribute(InspectorLevel level, string methodName, bool condition)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xEF0C6C", Offset = "0xEF0C6C", VA = "0xEF0C6C")]
		public InspectAttribute(string methodName)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xEF0C80", Offset = "0xEF0C80", VA = "0xEF0C80")]
		public InspectAttribute(string methodName, int priority)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xEF0C94", Offset = "0xEF0C94", VA = "0xEF0C94")]
		public InspectAttribute(string methodName, bool condition)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xEF0CAC", Offset = "0xEF0CAC", VA = "0xEF0CAC")]
		public InspectAttribute(string methodName, bool condition, int priority)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xEF0A4C", Offset = "0xEF0A4C", VA = "0xEF0A4C")]
		public InspectAttribute(InspectorLevel level, string methodName, bool condition, int priority)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xEF0CC4", Offset = "0xEF0CC4", VA = "0xEF0CC4")]
		public InspectAttribute(Delegate method)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xEF0DB0", Offset = "0xEF0DB0", VA = "0xEF0DB0")]
		public InspectAttribute(Delegate method, int priority)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xEF0DC4", Offset = "0xEF0DC4", VA = "0xEF0DC4")]
		public InspectAttribute(Delegate method, bool condition)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xEF0DDC", Offset = "0xEF0DDC", VA = "0xEF0DDC")]
		public InspectAttribute(Delegate method, bool condition, int priority)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xEF0DF4", Offset = "0xEF0DF4", VA = "0xEF0DF4")]
		public InspectAttribute(InspectorLevel level, Delegate method)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xEF0E00", Offset = "0xEF0E00", VA = "0xEF0E00")]
		public InspectAttribute(InspectorLevel level, Delegate method, int priority)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xEF0CD8", Offset = "0xEF0CD8", VA = "0xEF0CD8")]
		public InspectAttribute(InspectorLevel level, Delegate method, bool condition, int priority)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2D70", Offset = "0x6C2D70")]
	public class MenuAttribute : Attribute, IListAttribute, IMenu, IRuntimeAttribute
	{
		[Token(Token = "0x2000178")]
		public delegate void MenuDelegate();

		[Token(Token = "0x2000179")]
		public delegate void MenuStaticDelegate(MenuAttribute fieldMenuItem, object instance, object value);

		[Token(Token = "0x200017A")]
		public delegate bool MenuEnabledDelegate();

		[Token(Token = "0x200017B")]
		public delegate bool MenuIsOnDelegate();

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string menuItemName;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool enabled;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MenuEnabledDelegate enabledDelegate;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isOn;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MenuIsOnDelegate isOnDelegate;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string methodName;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Delegate> delegates;

		[Token(Token = "0x1700010C")]
		public string MenuItemName
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0xEF19D8", Offset = "0xEF19D8", VA = "0xEF19D8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010D")]
		public bool Enabled
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0xEF19E0", Offset = "0xEF19E0", VA = "0xEF19E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010E")]
		public bool IsOn
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0xEF1C10", Offset = "0xEF1C10", VA = "0xEF1C10", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010F")]
		public string MethodName
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0xEF1E40", Offset = "0xEF1E40", VA = "0xEF1E40", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000110")]
		public Type Template
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0xEF1E48", Offset = "0xEF1E48", VA = "0xEF1E48", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000111")]
		public Type TemplateStatic
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0xEF1EB8", Offset = "0xEF1EB8", VA = "0xEF1EB8", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000112")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0xEF1F28", Offset = "0xEF1F28", VA = "0xEF1F28", Slot = "13")]
			get
			{
				return null;
			}
			[Token(Token = "0x600063D")]
			[Address(RVA = "0xEF1F30", Offset = "0xEF1F30", VA = "0xEF1F30", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xEF1F38", Offset = "0xEF1F38", VA = "0xEF1F38", Slot = "6")]
		public void Invoke(int index, object instance, object value)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xEF22E8", Offset = "0xEF22E8", VA = "0xEF22E8")]
		public MenuAttribute(string menuItemName, string methodName)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xEF2390", Offset = "0xEF2390", VA = "0xEF2390")]
		public MenuAttribute(string menuItemName, Delegate method)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xEF2474", Offset = "0xEF2474", VA = "0xEF2474")]
		public MenuAttribute(string menuItemName, Delegate method, MenuEnabledDelegate enabledDelegate)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xEF239C", Offset = "0xEF239C", VA = "0xEF239C")]
		public MenuAttribute(string menuItemName, Delegate method, MenuEnabledDelegate enabledDelegate, MenuIsOnDelegate isOnDelegate)
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2D84", Offset = "0x6C2D84")]
	public class MethodAttribute : Attribute
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private MethodDisplay display;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string undoMessageOnClick;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isCoroutine;

		[Token(Token = "0x17000113")]
		public MethodDisplay Display
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0xEF2BFC", Offset = "0xEF2BFC", VA = "0xEF2BFC")]
			get
			{
				return default(MethodDisplay);
			}
			[Token(Token = "0x6000644")]
			[Address(RVA = "0xEF2C04", Offset = "0xEF2C04", VA = "0xEF2C04")]
			set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public string UndoMessageOnClick
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0xEF2C0C", Offset = "0xEF2C0C", VA = "0xEF2C0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000646")]
			[Address(RVA = "0xEF2C14", Offset = "0xEF2C14", VA = "0xEF2C14")]
			set
			{
			}
		}

		[Token(Token = "0x17000115")]
		public bool IsCoroutine
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0xEF2C1C", Offset = "0xEF2C1C", VA = "0xEF2C1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000648")]
			[Address(RVA = "0xEF2C24", Offset = "0xEF2C24", VA = "0xEF2C24")]
			set
			{
			}
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xEF2C30", Offset = "0xEF2C30", VA = "0xEF2C30")]
		public MethodAttribute()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xEF2C88", Offset = "0xEF2C88", VA = "0xEF2C88")]
		public MethodAttribute(MethodDisplay display)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xEF2CF4", Offset = "0xEF2CF4", VA = "0xEF2CF4")]
		public MethodAttribute(bool isCoroutine)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xEF2DD0", Offset = "0xEF2DD0", VA = "0xEF2DD0")]
		public MethodAttribute(string undoMessageOnClick)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xEF2D54", Offset = "0xEF2D54", VA = "0xEF2D54")]
		public MethodAttribute(bool isCoroutine, string undoMessageOnClick)
		{
		}
	}
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2D98", Offset = "0x6C2D98")]
	public class NoPicker : Attribute, IPicker, IListAttribute
	{
		[Token(Token = "0x600064E")]
		[Address(RVA = "0xEF2DDC", Offset = "0xEF2DDC", VA = "0xEF2DDC", Slot = "6")]
		public bool IsPickingAvailable(object[] instances, object[] values)
		{
			return default(bool);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xEF2DE4", Offset = "0xEF2DE4", VA = "0xEF2DE4")]
		public NoPicker()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2DAC", Offset = "0x6C2DAC")]
	public class RangeValueAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float min;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float max;

		[Token(Token = "0x17000116")]
		public float Min
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0xEF3230", Offset = "0xEF3230", VA = "0xEF3230")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000651")]
			[Address(RVA = "0xEF3238", Offset = "0xEF3238", VA = "0xEF3238")]
			set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public float Max
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0xEF3240", Offset = "0xEF3240", VA = "0xEF3240")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000653")]
			[Address(RVA = "0xEF3248", Offset = "0xEF3248", VA = "0xEF3248")]
			set
			{
			}
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xEF3250", Offset = "0xEF3250", VA = "0xEF3250")]
		public RangeValueAttribute(float min, float max)
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2DC0", Offset = "0x6C2DC0")]
	public class ReadOnlyAttribute : Attribute, IReadOnly, IListAttribute, IRuntimeAttribute<bool>, IRuntimeAttribute
	{
		[Token(Token = "0x200017C")]
		public delegate bool ReadOnlyDelegate();

		[Token(Token = "0x200017D")]
		public delegate bool ReadOnlyStaticDelegate(ReadOnlyAttribute readOnly, object instance, object value);

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool condition;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string methodName;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Delegate> delegates;

		[Token(Token = "0x17000118")]
		public bool Condition
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0xEF3288", Offset = "0xEF3288", VA = "0xEF3288")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000656")]
			[Address(RVA = "0xEF3290", Offset = "0xEF3290", VA = "0xEF3290")]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public string MethodName
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0xEF329C", Offset = "0xEF329C", VA = "0xEF329C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011A")]
		public Type Template
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0xEF32A4", Offset = "0xEF32A4", VA = "0xEF32A4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011B")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0xEF3314", Offset = "0xEF3314", VA = "0xEF3314", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011C")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0xEF3384", Offset = "0xEF3384", VA = "0xEF3384", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x600065B")]
			[Address(RVA = "0xEF338C", Offset = "0xEF338C", VA = "0xEF338C", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xEF3394", Offset = "0xEF3394", VA = "0xEF3394", Slot = "7")]
		public bool Invoke(int index, object instance, object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xEF3A40", Offset = "0xEF3A40", VA = "0xEF3A40", Slot = "6")]
		public bool IsReadOnly(object[] instances, object[] values)
		{
			return default(bool);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xEF3B98", Offset = "0xEF3B98", VA = "0xEF3B98")]
		public ReadOnlyAttribute()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xEF3C20", Offset = "0xEF3C20", VA = "0xEF3C20")]
		public ReadOnlyAttribute(bool condition)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xEF3CC0", Offset = "0xEF3CC0", VA = "0xEF3CC0")]
		public ReadOnlyAttribute(Delegate method)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xEF3CC8", Offset = "0xEF3CC8", VA = "0xEF3CC8")]
		public ReadOnlyAttribute(Delegate method, bool condition)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xEF3D8C", Offset = "0xEF3D8C", VA = "0xEF3D8C")]
		public ReadOnlyAttribute(string methodName)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xEF3D94", Offset = "0xEF3D94", VA = "0xEF3D94")]
		public ReadOnlyAttribute(string methodName, bool condition)
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2DF4", Offset = "0x6C2DF4")]
	public class RestrictAttribute : Attribute, IRestrict, IListAttribute, IRuntimeAttribute
	{
		[Token(Token = "0x200017E")]
		public delegate IList RestrictDelegate();

		[Token(Token = "0x200017F")]
		public delegate IList RestrictStaticDelegate(RestrictAttribute restrict, object instance, object value);

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RestrictDisplay display;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int maxItemsPerRow;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string methodName;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Delegate> delegates;

		[Token(Token = "0x1700011D")]
		public RestrictDisplay Display
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0xEF4544", Offset = "0xEF4544", VA = "0xEF4544")]
			get
			{
				return default(RestrictDisplay);
			}
			[Token(Token = "0x6000665")]
			[Address(RVA = "0xEF454C", Offset = "0xEF454C", VA = "0xEF454C")]
			set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public int MaxItemsPerRow
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0xEF4554", Offset = "0xEF4554", VA = "0xEF4554")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000667")]
			[Address(RVA = "0xEF455C", Offset = "0xEF455C", VA = "0xEF455C")]
			set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		public string MethodName
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0xEF48F8", Offset = "0xEF48F8", VA = "0xEF48F8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000120")]
		public Type Template
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0xEF4900", Offset = "0xEF4900", VA = "0xEF4900", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000121")]
		public Type TemplateStatic
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0xEF4970", Offset = "0xEF4970", VA = "0xEF4970", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000122")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0xEF49E0", Offset = "0xEF49E0", VA = "0xEF49E0", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x600066F")]
			[Address(RVA = "0xEF49E8", Offset = "0xEF49E8", VA = "0xEF49E8", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xEF4564", Offset = "0xEF4564", VA = "0xEF4564", Slot = "6")]
		public IList GetRestricted(object[] instances, object[] values)
		{
			return null;
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xEF48E8", Offset = "0xEF48E8", VA = "0xEF48E8", Slot = "7")]
		public RestrictDisplay GetDisplay(object[] instances, object[] values)
		{
			return default(RestrictDisplay);
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xEF48F0", Offset = "0xEF48F0", VA = "0xEF48F0", Slot = "8")]
		public int GetItemsPerRow(object[] instances, object[] values)
		{
			return default(int);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xEF49F0", Offset = "0xEF49F0", VA = "0xEF49F0")]
		public RestrictAttribute(string methodName)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xEF49F8", Offset = "0xEF49F8", VA = "0xEF49F8")]
		public RestrictAttribute(string methodName, RestrictDisplay display)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xEF4A9C", Offset = "0xEF4A9C", VA = "0xEF4A9C")]
		public RestrictAttribute(Delegate method)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xEF4AA4", Offset = "0xEF4AA4", VA = "0xEF4AA4")]
		public RestrictAttribute(Delegate method, RestrictDisplay display)
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2E08", Offset = "0x6C2E08")]
	public class RuntimeResolveAttribute : Attribute, IListAttribute, IRuntimeAttribute<Type>, IRuntimeAttribute, IRuntimeType
	{
		[Token(Token = "0x2000180")]
		public delegate Type RuntimeResolveDelegate();

		[Token(Token = "0x2000181")]
		public delegate Type RuntimeResolveStaticDelegate(RuntimeResolveAttribute runtimeResolve, object instance, object value);

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string methodName;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Delegate> delegates;

		[Token(Token = "0x17000123")]
		public string MethodName
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0xEF57CC", Offset = "0xEF57CC", VA = "0xEF57CC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000124")]
		public Type Template
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0xEF57D4", Offset = "0xEF57D4", VA = "0xEF57D4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000125")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0xEF5844", Offset = "0xEF5844", VA = "0xEF5844", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000126")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0xEF58B4", Offset = "0xEF58B4", VA = "0xEF58B4", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000679")]
			[Address(RVA = "0xEF58BC", Offset = "0xEF58BC", VA = "0xEF58BC", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xEF5224", Offset = "0xEF5224", VA = "0xEF5224", Slot = "12")]
		public Type GetType(object[] instances, object[] values)
		{
			return null;
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xEF53D8", Offset = "0xEF53D8", VA = "0xEF53D8", Slot = "6")]
		public Type Invoke(int index, object instance, object value)
		{
			return null;
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xEF58C4", Offset = "0xEF58C4", VA = "0xEF58C4")]
		public RuntimeResolveAttribute()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xEF5944", Offset = "0xEF5944", VA = "0xEF5944")]
		public RuntimeResolveAttribute(string methodName)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xEF59D8", Offset = "0xEF59D8", VA = "0xEF59D8")]
		public RuntimeResolveAttribute(Delegate method)
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2E1C", Offset = "0x6C2E1C")]
	public class SpacingAttribute : Attribute, ISpacing
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int before;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int after;

		[Token(Token = "0x17000127")]
		public int Before
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0xEF7398", Offset = "0xEF7398", VA = "0xEF7398")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600067F")]
			[Address(RVA = "0xEF73A0", Offset = "0xEF73A0", VA = "0xEF73A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public int After
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0xEF73A8", Offset = "0xEF73A8", VA = "0xEF73A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000681")]
			[Address(RVA = "0xEF73B0", Offset = "0xEF73B0", VA = "0xEF73B0")]
			set
			{
			}
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xEF73B8", Offset = "0xEF73B8", VA = "0xEF73B8")]
		public SpacingAttribute()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xEF73C0", Offset = "0xEF73C0", VA = "0xEF73C0")]
		public SpacingAttribute(int after)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xEF73EC", Offset = "0xEF73EC", VA = "0xEF73EC")]
		public SpacingAttribute(int before, int after)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xEF7424", Offset = "0xEF7424", VA = "0xEF7424", Slot = "6")]
		public int GetAfter(object[] instances, object[] values)
		{
			return default(int);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xEF742C", Offset = "0xEF742C", VA = "0xEF742C", Slot = "7")]
		public int GetBefore(object[] instances, object[] values)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2E30", Offset = "0x6C2E30")]
	public class StyleAttribute : Attribute
	{
		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string style;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool label;

		[Token(Token = "0x17000129")]
		public string Style
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0xEF7868", Offset = "0xEF7868", VA = "0xEF7868")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000688")]
			[Address(RVA = "0xEF7870", Offset = "0xEF7870", VA = "0xEF7870")]
			set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public bool Label
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0xEF7878", Offset = "0xEF7878", VA = "0xEF7878")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600068A")]
			[Address(RVA = "0xEF7880", Offset = "0xEF7880", VA = "0xEF7880")]
			set
			{
			}
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xEF788C", Offset = "0xEF788C", VA = "0xEF788C")]
		public StyleAttribute(string style)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xEF7894", Offset = "0xEF7894", VA = "0xEF7894")]
		public StyleAttribute(string style, bool label)
		{
		}
	}
	[Token(Token = "0x20000B4")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2E44", Offset = "0x6C2E44")]
	public class TabAttribute : Attribute, IRuntimeAttribute<Enum>, IRuntimeAttribute
	{
		[Token(Token = "0x2000182")]
		public delegate Enum DescriptorDelegate();

		[Token(Token = "0x2000183")]
		public delegate Enum DescriptorStaticDelegate(TabAttribute descriptor, object instance, object value);

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Enum tab;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string methodName;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Delegate> delegates;

		[Token(Token = "0x1700012B")]
		public Enum Tab
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0xEF7914", Offset = "0xEF7914", VA = "0xEF7914")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068E")]
			[Address(RVA = "0xEF791C", Offset = "0xEF791C", VA = "0xEF791C")]
			set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public string MethodName
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0xEF7924", Offset = "0xEF7924", VA = "0xEF7924", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012D")]
		public Type Template
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0xEF792C", Offset = "0xEF792C", VA = "0xEF792C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012E")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0xEF799C", Offset = "0xEF799C", VA = "0xEF799C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012F")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0xEF7A0C", Offset = "0xEF7A0C", VA = "0xEF7A0C", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000693")]
			[Address(RVA = "0xEF7A14", Offset = "0xEF7A14", VA = "0xEF7A14", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xEF7A1C", Offset = "0xEF7A1C", VA = "0xEF7A1C", Slot = "6")]
		public Enum Invoke(int index, object instance, object value)
		{
			return null;
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xEF7E44", Offset = "0xEF7E44", VA = "0xEF7E44")]
		public TabAttribute(object tab)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xEF7F18", Offset = "0xEF7F18", VA = "0xEF7F18")]
		public TabAttribute(string methodName)
		{
		}
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2E58", Offset = "0x6C2E58")]
	public class TextFieldAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x4000417")]
		private const string TITLE = "Select Path...";

		[Token(Token = "0x4000418")]
		private const string PATH = "";

		[Token(Token = "0x4000419")]
		private const string EXTENSION = "";

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string title;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string path;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string extension;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextFieldType type;

		[Token(Token = "0x17000130")]
		public string Title
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0xEF866C", Offset = "0xEF866C", VA = "0xEF866C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000698")]
			[Address(RVA = "0xEF8674", Offset = "0xEF8674", VA = "0xEF8674")]
			set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public string Path
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0xEF867C", Offset = "0xEF867C", VA = "0xEF867C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600069A")]
			[Address(RVA = "0xEF8684", Offset = "0xEF8684", VA = "0xEF8684")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public string Extension
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0xEF868C", Offset = "0xEF868C", VA = "0xEF868C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600069C")]
			[Address(RVA = "0xEF8694", Offset = "0xEF8694", VA = "0xEF8694")]
			set
			{
			}
		}

		[Token(Token = "0x17000133")]
		public TextFieldType Type
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0xEF869C", Offset = "0xEF869C", VA = "0xEF869C")]
			get
			{
				return default(TextFieldType);
			}
			[Token(Token = "0x600069E")]
			[Address(RVA = "0xEF86A4", Offset = "0xEF86A4", VA = "0xEF86A4")]
			set
			{
			}
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xEF86AC", Offset = "0xEF86AC", VA = "0xEF86AC")]
		public TextFieldAttribute(TextFieldType type)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xEF87B4", Offset = "0xEF87B4", VA = "0xEF87B4")]
		public TextFieldAttribute(TextFieldType type, string title)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xEF8820", Offset = "0xEF8820", VA = "0xEF8820")]
		public TextFieldAttribute(TextFieldType type, string title, string path)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xEF871C", Offset = "0xEF871C", VA = "0xEF871C")]
		public TextFieldAttribute(TextFieldType type, string title, string path, string extension)
		{
		}
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2E6C", Offset = "0x6C2E6C")]
	public class TitleAttribute : Attribute, IRuntimeAttribute<TitleAttribute>, IRuntimeAttribute
	{
		[Token(Token = "0x2000184")]
		public delegate TitleAttribute TitleDelegate();

		[Token(Token = "0x2000185")]
		public delegate TitleAttribute TitleStaticDelegate(TitleAttribute title, object instance, object value);

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string message;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FontStyle style;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string methodName;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Delegate> delegates;

		[Token(Token = "0x17000134")]
		public string Message
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xEF8898", Offset = "0xEF8898", VA = "0xEF8898")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xEF88A0", Offset = "0xEF88A0", VA = "0xEF88A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public FontStyle Style
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xEF88A8", Offset = "0xEF88A8", VA = "0xEF88A8")]
			get
			{
				return default(FontStyle);
			}
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xEF88B0", Offset = "0xEF88B0", VA = "0xEF88B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public string MethodName
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xEF88B8", Offset = "0xEF88B8", VA = "0xEF88B8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000137")]
		public Type Template
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xEF88C0", Offset = "0xEF88C0", VA = "0xEF88C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		public Type TemplateStatic
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0xEF8930", Offset = "0xEF8930", VA = "0xEF8930", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000139")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xEF89A0", Offset = "0xEF89A0", VA = "0xEF89A0", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xEF89A8", Offset = "0xEF89A8", VA = "0xEF89A8", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xEF89B0", Offset = "0xEF89B0", VA = "0xEF89B0", Slot = "6")]
		public TitleAttribute Invoke(int index, object instance, object value)
		{
			return null;
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xEF8D8C", Offset = "0xEF8D8C", VA = "0xEF8D8C")]
		public TitleAttribute(string methodName)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xEF8E28", Offset = "0xEF8E28", VA = "0xEF8E28")]
		public TitleAttribute(FontStyle style, string message)
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xEF8ECC", Offset = "0xEF8ECC", VA = "0xEF8ECC")]
		public TitleAttribute(Delegate method)
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6C2E80", Offset = "0x6C2E80")]
	public class ToolbarAttribute : Attribute
	{
		[Token(Token = "0x4000422")]
		public const string ToolbarStyle = "Toolbar";

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string name;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string style;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool label;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool flexible;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int priority;

		[Token(Token = "0x1700013A")]
		public string Name
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xEF9640", Offset = "0xEF9640", VA = "0xEF9640")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xEF9648", Offset = "0xEF9648", VA = "0xEF9648")]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public string Style
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xEF9650", Offset = "0xEF9650", VA = "0xEF9650")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0xEF9658", Offset = "0xEF9658", VA = "0xEF9658")]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public bool Label
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0xEF9660", Offset = "0xEF9660", VA = "0xEF9660")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xEF9668", Offset = "0xEF9668", VA = "0xEF9668")]
			set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public bool Flexible
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xEF9674", Offset = "0xEF9674", VA = "0xEF9674")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xEF967C", Offset = "0xEF967C", VA = "0xEF967C")]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public int Priority
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xEF9688", Offset = "0xEF9688", VA = "0xEF9688")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0xEF9690", Offset = "0xEF9690", VA = "0xEF9690")]
			set
			{
			}
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xEF9698", Offset = "0xEF9698", VA = "0xEF9698")]
		public ToolbarAttribute(string name)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xEF97A4", Offset = "0xEF97A4", VA = "0xEF97A4")]
		public ToolbarAttribute(string name, int priority)
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xEF9814", Offset = "0xEF9814", VA = "0xEF9814")]
		public ToolbarAttribute(string name, string style)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xEF9824", Offset = "0xEF9824", VA = "0xEF9824")]
		public ToolbarAttribute(string name, string style, int priority)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xEF9834", Offset = "0xEF9834", VA = "0xEF9834")]
		public ToolbarAttribute(string name, bool label)
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xEF98A4", Offset = "0xEF98A4", VA = "0xEF98A4")]
		public ToolbarAttribute(string name, bool label, int priority)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xEF9920", Offset = "0xEF9920", VA = "0xEF9920")]
		public ToolbarAttribute(string name, string style, bool label)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xEF9930", Offset = "0xEF9930", VA = "0xEF9930")]
		public ToolbarAttribute(string name, string style, bool label, int priority)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xEF9940", Offset = "0xEF9940", VA = "0xEF9940")]
		public ToolbarAttribute(string name, string style, bool label, bool flexible)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xEF9704", Offset = "0xEF9704", VA = "0xEF9704")]
		public ToolbarAttribute(string name, string style, bool label, bool flexible, int priority)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "AdvancedInspectorAttribute", RVA = "0x6C2E94", Offset = "0x6C2E94")]
	public class ActionBinding : ICopiable
	{
		[Serializable]
		[Token(Token = "0x2000186")]
		[AttributeAttribute(Name = "AdvancedInspectorAttribute", RVA = "0x6C3164", Offset = "0x6C3164")]
		public class BindingParameter : ICopy, ICopiable
		{
			[Token(Token = "0x20001A5")]
			public enum BindingType
			{
				[Token(Token = "0x4000767")]
				Internal,
				[Token(Token = "0x4000768")]
				Static,
				[Token(Token = "0x4000769")]
				External
			}

			[Token(Token = "0x20001A6")]
			private enum BindingValueType
			{
				[Token(Token = "0x400076B")]
				None,
				[Token(Token = "0x400076C")]
				Boolean,
				[Token(Token = "0x400076D")]
				Integer,
				[Token(Token = "0x400076E")]
				Float,
				[Token(Token = "0x400076F")]
				String,
				[Token(Token = "0x4000770")]
				Vector2,
				[Token(Token = "0x4000771")]
				Vector3,
				[Token(Token = "0x4000772")]
				Vector4,
				[Token(Token = "0x4000773")]
				Color,
				[Token(Token = "0x4000774")]
				Rect,
				[Token(Token = "0x4000775")]
				Bounds,
				[Token(Token = "0x4000776")]
				Reference
			}

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6C56EC", Offset = "0x6C56EC")]
			[AttributeAttribute(Name = "RestrictAttribute", RVA = "0x6C56EC", Offset = "0x6C56EC")]
			public BindingType binding;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool canBeInternal;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private BindingValueType type;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private string qualifiedTypeName;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private bool boolValue;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private int intValue;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			private float floatValue;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[SerializeField]
			private string stringValue;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Vector2 vector2Value;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[SerializeField]
			private Vector3 vector3Value;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[SerializeField]
			private Vector4 vector4Value;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[SerializeField]
			private Color colorValue;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[SerializeField]
			private Rect rectValue;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[SerializeField]
			private Bounds boundsValue;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[SerializeField]
			private UnityEngine.Object referenceValue;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[SerializeField]
			private GameObject gameObject;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[SerializeField]
			private Component component;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[SerializeField]
			private string method;

			[Token(Token = "0x170001B2")]
			private bool CanBeInternal
			{
				[Token(Token = "0x60009E5")]
				[Address(RVA = "0xEE5304", Offset = "0xEE5304", VA = "0xEE5304")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170001B3")]
			public Type Type
			{
				[Token(Token = "0x60009E6")]
				[Address(RVA = "0xEE41F4", Offset = "0xEE41F4", VA = "0xEE41F4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60009E7")]
				[Address(RVA = "0xEE3284", Offset = "0xEE3284", VA = "0xEE3284")]
				set
				{
				}
			}

			[Token(Token = "0x170001B4")]
			[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6C6840", Offset = "0x6C6840")]
			public string BoundType
			{
				[Token(Token = "0x60009E8")]
				[Address(RVA = "0xEE530C", Offset = "0xEE530C", VA = "0xEE530C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001B5")]
			[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6C6854", Offset = "0x6C6854")]
			[AttributeAttribute(Name = "RuntimeResolveAttribute", RVA = "0x6C6854", Offset = "0x6C6854")]
			public object Value
			{
				[Token(Token = "0x60009E9")]
				[Address(RVA = "0xEE47C0", Offset = "0xEE47C0", VA = "0xEE47C0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60009EA")]
				[Address(RVA = "0xEE54E0", Offset = "0xEE54E0", VA = "0xEE54E0")]
				set
				{
				}
			}

			[Token(Token = "0x170001B6")]
			[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6C68B4", Offset = "0x6C68B4")]
			public GameObject GameObject
			{
				[Token(Token = "0x60009EB")]
				[Address(RVA = "0xEE57A4", Offset = "0xEE57A4", VA = "0xEE57A4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60009EC")]
				[Address(RVA = "0xEE57AC", Offset = "0xEE57AC", VA = "0xEE57AC")]
				set
				{
				}
			}

			[Token(Token = "0x170001B7")]
			[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6C68EC", Offset = "0x6C68EC")]
			[AttributeAttribute(Name = "RestrictAttribute", RVA = "0x6C68EC", Offset = "0x6C68EC")]
			public Component Component
			{
				[Token(Token = "0x60009ED")]
				[Address(RVA = "0xEE58EC", Offset = "0xEE58EC", VA = "0xEE58EC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60009EE")]
				[Address(RVA = "0xEE584C", Offset = "0xEE584C", VA = "0xEE584C")]
				set
				{
				}
			}

			[Token(Token = "0x170001B8")]
			[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6C694C", Offset = "0x6C694C")]
			[AttributeAttribute(Name = "RestrictAttribute", RVA = "0x6C694C", Offset = "0x6C694C")]
			public MethodInfo Method
			{
				[Token(Token = "0x60009F0")]
				[Address(RVA = "0xEE5B80", Offset = "0xEE5B80", VA = "0xEE5B80")]
				get
				{
					return null;
				}
				[Token(Token = "0x60009F1")]
				[Address(RVA = "0xEE58F4", Offset = "0xEE58F4", VA = "0xEE58F4")]
				set
				{
				}
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0xEE51F0", Offset = "0xEE51F0", VA = "0xEE51F0")]
			private IList RestrictBinding()
			{
				return null;
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0xEE599C", Offset = "0xEE599C", VA = "0xEE599C")]
			private IList GetComponents()
			{
				return null;
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0xEE5C7C", Offset = "0xEE5C7C", VA = "0xEE5C7C")]
			private IList GetMethods()
			{
				return null;
			}

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0xEE6088", Offset = "0xEE6088", VA = "0xEE6088")]
			private bool IsMethodValid(MethodInfo info)
			{
				return default(bool);
			}

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0xEE5B84", Offset = "0xEE5B84", VA = "0xEE5B84")]
			private MethodInfo GetMethodInfo()
			{
				return null;
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0xEE6264", Offset = "0xEE6264", VA = "0xEE6264")]
			private bool IsStatic()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0xEE6274", Offset = "0xEE6274", VA = "0xEE6274")]
			private bool IsExternal()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0xEE6284", Offset = "0xEE6284", VA = "0xEE6284")]
			private Type GetRuntimeType()
			{
				return null;
			}

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0xEE6288", Offset = "0xEE6288", VA = "0xEE6288")]
			public BindingParameter()
			{
			}

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0xEE30B8", Offset = "0xEE30B8", VA = "0xEE30B8")]
			public BindingParameter(bool canBeInternal)
			{
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0xEE3EA0", Offset = "0xEE3EA0", VA = "0xEE3EA0")]
			public static bool IsValidType(Type type)
			{
				return default(bool);
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0xEE53C0", Offset = "0xEE53C0", VA = "0xEE53C0")]
			private object Invoke()
			{
				return null;
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0xEE6440", Offset = "0xEE6440", VA = "0xEE6440", Slot = "5")]
			public bool Copiable(object destination)
			{
				return default(bool);
			}

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0xEE64FC", Offset = "0xEE64FC", VA = "0xEE64FC", Slot = "4")]
			public object Copy(object destination)
			{
				return null;
			}

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0xEE664C", Offset = "0xEE664C", VA = "0xEE664C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string[] internalParameters;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject gameObject;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Component component;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string method;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6C4DE0", Offset = "0x6C4DE0")]
		[AttributeAttribute(Name = "CollectionAttribute", RVA = "0x6C4DE0", Offset = "0x6C4DE0")]
		[SerializeField]
		private BindingParameter[] parameters;

		[Token(Token = "0x1700013F")]
		[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6C674C", Offset = "0x6C674C")]
		public GameObject GameObject
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0xEE28E8", Offset = "0xEE28E8", VA = "0xEE28E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0xEE28F0", Offset = "0xEE28F0", VA = "0xEE28F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000140")]
		[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6C675C", Offset = "0x6C675C")]
		[AttributeAttribute(Name = "RestrictAttribute", RVA = "0x6C675C", Offset = "0x6C675C")]
		public Component Component
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0xEE2A30", Offset = "0xEE2A30", VA = "0xEE2A30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0xEE2990", Offset = "0xEE2990", VA = "0xEE2990")]
			set
			{
			}
		}

		[Token(Token = "0x17000141")]
		[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6C67A8", Offset = "0x6C67A8")]
		[AttributeAttribute(Name = "RestrictAttribute", RVA = "0x6C67A8", Offset = "0x6C67A8")]
		public MethodInfo Method
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0xEE2F00", Offset = "0xEE2F00", VA = "0xEE2F00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0xEE2A38", Offset = "0xEE2A38", VA = "0xEE2A38")]
			set
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event ActionEventHandler OnInvoke
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0xEE42A0", Offset = "0xEE42A0", VA = "0xEE42A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C6234", Offset = "0x6C6234")]
			add
			{
			}
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0xEE4344", Offset = "0xEE4344", VA = "0xEE4344")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C6244", Offset = "0x6C6244")]
			remove
			{
			}
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xEE2C70", Offset = "0xEE2C70", VA = "0xEE2C70")]
		private IList GetComponents()
		{
			return null;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xEE365C", Offset = "0xEE365C", VA = "0xEE365C")]
		private IList GetMethods()
		{
			return null;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xEE3BE4", Offset = "0xEE3BE4", VA = "0xEE3BE4")]
		private bool IsMethodValid(MethodInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xEE3D80", Offset = "0xEE3D80", VA = "0xEE3D80")]
		private string GetParamNames(string name, ParameterInfo[] param)
		{
			return null;
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xEE2F04", Offset = "0xEE2F04", VA = "0xEE2F04")]
		private MethodInfo GetMethodInfo()
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xEE43E8", Offset = "0xEE43E8", VA = "0xEE43E8")]
		public ActionBinding()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xEE4460", Offset = "0xEE4460", VA = "0xEE4460")]
		public ActionBinding(Type[] types)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xEE45A4", Offset = "0xEE45A4", VA = "0xEE45A4")]
		public void Invoke(params object[] args)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xEE4DCC", Offset = "0xEE4DCC", VA = "0xEE4DCC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xEE50C0", Offset = "0xEE50C0", VA = "0xEE50C0", Slot = "4")]
		public bool Copiable(object destination)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B9")]
	public enum CollectionDisplay
	{
		[Token(Token = "0x400042F")]
		List,
		[Token(Token = "0x4000430")]
		DropDown,
		[Token(Token = "0x4000431")]
		Button
	}
	[Token(Token = "0x20000BA")]
	public abstract class ComponentMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private MonoBehaviour owner;

		[Token(Token = "0x17000142")]
		public MonoBehaviour Owner
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0xEE9D58", Offset = "0xEE9D58", VA = "0xEE9D58")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xEE9D60", Offset = "0xEE9D60", VA = "0xEE9D60")]
			set
			{
			}
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xEE9DE4", Offset = "0xEE9DE4", VA = "0xEE9DE4", Slot = "4")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xEE9DF0", Offset = "0xEE9DF0", VA = "0xEE9DF0")]
		public void Erase()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xEEA240", Offset = "0xEEA240", VA = "0xEEA240")]
		public ComponentMonoBehaviour Instantiate()
		{
			return null;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xEEA310", Offset = "0xEEA310", VA = "0xEEA310")]
		public ComponentMonoBehaviour Instantiate(MonoBehaviour owner)
		{
			return null;
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xEEA270", Offset = "0xEEA270", VA = "0xEEA270")]
		public ComponentMonoBehaviour Instantiate(GameObject go, MonoBehaviour owner)
		{
			return null;
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xEEA344", Offset = "0xEEA344", VA = "0xEEA344")]
		private static object CopyObject(GameObject go, MonoBehaviour owner, object original)
		{
			return null;
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xEEA7A8", Offset = "0xEEA7A8", VA = "0xEEA7A8")]
		private static IList CopyList(GameObject go, MonoBehaviour owner, IList original)
		{
			return null;
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xEEABBC", Offset = "0xEEABBC", VA = "0xEEABBC")]
		private static ComponentMonoBehaviour CopyComponent(GameObject go, MonoBehaviour owner, ComponentMonoBehaviour original)
		{
			return null;
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xEEAD98", Offset = "0xEEAD98", VA = "0xEEAD98")]
		private static object CopyClass(GameObject go, MonoBehaviour owner, object original)
		{
			return null;
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xEEAF20", Offset = "0xEEAF20", VA = "0xEEAF20")]
		protected ComponentMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6C2EA4", Offset = "0x6C2EA4")]
	public class CoroutineMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xEEBBD4", Offset = "0xEEBBD4", VA = "0xEEBBD4")]
		public CoroutineMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class Description
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string name;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string comment;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string url;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Texture icon;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color color;

		[Token(Token = "0x17000143")]
		public string Name
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0xEEBC28", Offset = "0xEEBC28", VA = "0xEEBC28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000144")]
		public string Comment
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0xEEBC30", Offset = "0xEEBC30", VA = "0xEEBC30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000145")]
		public string URL
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0xEEBC38", Offset = "0xEEBC38", VA = "0xEEBC38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000146")]
		public Texture Icon
		{
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0xEEBC40", Offset = "0xEEBC40", VA = "0xEEBC40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000147")]
		public Color Color
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0xEEBC48", Offset = "0xEEBC48", VA = "0xEEBC48")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xEEBC54", Offset = "0xEEBC54", VA = "0xEEBC54")]
		public Description(string name)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xEEBD84", Offset = "0xEEBD84", VA = "0xEEBD84")]
		public Description(string name, Texture icon)
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xEEBDF8", Offset = "0xEEBDF8", VA = "0xEEBDF8")]
		public Description(string name, Color color)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xEEBE90", Offset = "0xEEBE90", VA = "0xEEBE90")]
		public Description(string name, Texture icon, Color color)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xEE2E54", Offset = "0xEE2E54", VA = "0xEE2E54")]
		public Description(string name, string comment)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xEEBF2C", Offset = "0xEEBF2C", VA = "0xEEBF2C")]
		public Description(string name, string comment, Texture icon)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xEEBFAC", Offset = "0xEEBFAC", VA = "0xEEBFAC")]
		public Description(string name, string comment, Color color)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xEEC048", Offset = "0xEEC048", VA = "0xEEC048")]
		public Description(string name, string comment, Texture icon, Color color)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xEEC0F0", Offset = "0xEEC0F0", VA = "0xEEC0F0")]
		public Description(string name, string comment, string url)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xEEC13C", Offset = "0xEEC13C", VA = "0xEEC13C")]
		public Description(string name, string comment, string url, Texture icon)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xEEC194", Offset = "0xEEC194", VA = "0xEEC194")]
		public Description(string name, string comment, string url, Color color)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xEEBCC4", Offset = "0xEEBCC4", VA = "0xEEBCC4")]
		public Description(string name, string comment, string url, Texture icon, Color color)
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class DescriptionPair
	{
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private object value;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Description description;

		[Token(Token = "0x17000148")]
		public object Value
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xEEC19C", Offset = "0xEEC19C", VA = "0xEEC19C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000149")]
		public Description Description
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xEEC1A4", Offset = "0xEEC1A4", VA = "0xEEC1A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xEE2EC8", Offset = "0xEE2EC8", VA = "0xEE2EC8")]
		public DescriptionPair(object value, Description descriptor)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xEEC1AC", Offset = "0xEEC1AC", VA = "0xEEC1AC")]
		public DescriptionPair(object value, string name)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xEEC234", Offset = "0xEEC234", VA = "0xEEC234")]
		public DescriptionPair(object value, string name, string description)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xEEC2C0", Offset = "0xEEC2C0", VA = "0xEEC2C0")]
		public static bool operator ==(DescriptionPair a, DescriptionPair b)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xEEC2EC", Offset = "0xEEC2EC", VA = "0xEEC2EC")]
		public static bool operator !=(DescriptionPair a, DescriptionPair b)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xEEC32C", Offset = "0xEEC32C", VA = "0xEEC32C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xEEC3DC", Offset = "0xEEC3DC", VA = "0xEEC3DC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xEEC3E4", Offset = "0xEEC3E4", VA = "0xEEC3E4")]
		public static DescriptionPair GetDescription(object item)
		{
			return null;
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xEEC4F0", Offset = "0xEEC4F0", VA = "0xEEC4F0")]
		public static IList<DescriptionPair> GetDescriptions(IList items)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BE")]
	public enum EnumDisplay
	{
		[Token(Token = "0x400043B")]
		DropDown,
		[Token(Token = "0x400043C")]
		Button,
		[Token(Token = "0x400043D")]
		Checkbox
	}
	[Token(Token = "0x20000BF")]
	public class HelpItem : IEquatable<HelpItem>
	{
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HelpType type;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string message;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HelpPosition position;

		[Token(Token = "0x1700014A")]
		public HelpType Type
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0xEEFFA0", Offset = "0xEEFFA0", VA = "0xEEFFA0")]
			get
			{
				return default(HelpType);
			}
			[Token(Token = "0x6000700")]
			[Address(RVA = "0xEEFFA8", Offset = "0xEEFFA8", VA = "0xEEFFA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public string Message
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0xEEFFB0", Offset = "0xEEFFB0", VA = "0xEEFFB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000702")]
			[Address(RVA = "0xEEFFB8", Offset = "0xEEFFB8", VA = "0xEEFFB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700014C")]
		public HelpPosition Position
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0xEEFFC0", Offset = "0xEEFFC0", VA = "0xEEFFC0")]
			get
			{
				return default(HelpPosition);
			}
			[Token(Token = "0x6000704")]
			[Address(RVA = "0xEEFFC8", Offset = "0xEEFFC8", VA = "0xEEFFC8")]
			set
			{
			}
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xEEF704", Offset = "0xEEF704", VA = "0xEEF704")]
		public HelpItem(HelpType type, string message)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xEEF1E4", Offset = "0xEEF1E4", VA = "0xEEF1E4")]
		public HelpItem(HelpType type, string message, HelpPosition position)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xEEFFD0", Offset = "0xEEFFD0", VA = "0xEEFFD0", Slot = "4")]
		public bool Equals(HelpItem help)
		{
			return default(bool);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xEF001C", Offset = "0xEF001C", VA = "0xEF001C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xEF00EC", Offset = "0xEF00EC", VA = "0xEF00EC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000C0")]
	public enum IconPreviewSize
	{
		[Token(Token = "0x4000442")]
		Smallest,
		[Token(Token = "0x4000443")]
		Small,
		[Token(Token = "0x4000444")]
		Normal,
		[Token(Token = "0x4000445")]
		Large,
		[Token(Token = "0x4000446")]
		Largest
	}
	[Token(Token = "0x20000C1")]
	public enum InspectorLevel
	{
		[Token(Token = "0x4000448")]
		Basic,
		[Token(Token = "0x4000449")]
		Advanced,
		[Token(Token = "0x400044A")]
		Debug
	}
	[Token(Token = "0x20000C2")]
	public enum MethodDisplay
	{
		[Token(Token = "0x400044C")]
		Button,
		[Token(Token = "0x400044D")]
		Invoke
	}
	[Serializable]
	[Token(Token = "0x20000C3")]
	public struct RangeFloat
	{
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float max;

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xEF3220", Offset = "0xEF3220", VA = "0xEF3220")]
		public RangeFloat(float min, float max)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C4")]
	public struct RangeInt
	{
		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int min;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int max;

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xEF3228", Offset = "0xEF3228", VA = "0xEF3228")]
		public RangeInt(int min, int max)
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public enum RestrictDisplay
	{
		[Token(Token = "0x4000453")]
		DropDown,
		[Token(Token = "0x4000454")]
		Toolbox,
		[Token(Token = "0x4000455")]
		Button
	}
	[Token(Token = "0x20000C6")]
	public class ScriptableComponent : ScriptableObject
	{
		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private ScriptableObject owner;

		[Token(Token = "0x1700014D")]
		public ScriptableObject Owner
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0xEF6144", Offset = "0xEF6144", VA = "0xEF6144")]
			get
			{
				return null;
			}
			[Token(Token = "0x600070D")]
			[Address(RVA = "0xEF614C", Offset = "0xEF614C", VA = "0xEF614C")]
			set
			{
			}
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xEF61D0", Offset = "0xEF61D0", VA = "0xEF61D0", Slot = "4")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xEF61DC", Offset = "0xEF61DC", VA = "0xEF61DC")]
		public void Erase()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xEF63C8", Offset = "0xEF63C8", VA = "0xEF63C8")]
		public ScriptableComponent Instantiate()
		{
			return null;
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xEF63D0", Offset = "0xEF63D0", VA = "0xEF63D0")]
		public ScriptableComponent Instantiate(ScriptableObject owner)
		{
			return null;
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xEF6468", Offset = "0xEF6468", VA = "0xEF6468")]
		private static object CopyObject(ScriptableObject owner, object original)
		{
			return null;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xEF68A4", Offset = "0xEF68A4", VA = "0xEF68A4")]
		private static IList CopyList(ScriptableObject owner, IList original)
		{
			return null;
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xEF6CAC", Offset = "0xEF6CAC", VA = "0xEF6CAC")]
		private static ScriptableComponent CopyComponent(ScriptableObject owner, ScriptableComponent original)
		{
			return null;
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xEF6E3C", Offset = "0xEF6E3C", VA = "0xEF6E3C")]
		private static object CopyClass(ScriptableObject owner, object original)
		{
			return null;
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xEF6FBC", Offset = "0xEF6FBC", VA = "0xEF6FBC")]
		public ScriptableComponent()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public abstract class AIStateMachineBehaviour : StateMachineBehaviour
	{
		[Token(Token = "0x6000717")]
		[Address(RVA = "0xEE28E0", Offset = "0xEE28E0", VA = "0xEE28E0")]
		protected AIStateMachineBehaviour()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public enum TextFieldType
	{
		[Token(Token = "0x4000458")]
		Standard,
		[Token(Token = "0x4000459")]
		Password,
		[Token(Token = "0x400045A")]
		Area,
		[Token(Token = "0x400045B")]
		Tag,
		[Token(Token = "0x400045C")]
		File,
		[Token(Token = "0x400045D")]
		Folder
	}
	[Serializable]
	[Token(Token = "0x20000C9")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6C2EF0", Offset = "0x6C2EF0")]
	[AttributeAttribute(Name = "ComVisibleAttribute", RVA = "0x6C2EF0", Offset = "0x6C2EF0")]
	[AttributeAttribute(Name = "DebuggerDisplayAttribute", RVA = "0x6C2EF0", Offset = "0x6C2EF0")]
	public class UDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, ISerializable, IDeserializationCallback, ISerializationCallbackReceiver
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> keys;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TValue> values;

		[NonSerialized]
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue> dictionary;

		[Token(Token = "0x1700014E")]
		public bool IsFixedSize
		{
			[Token(Token = "0x6000722")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014F")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6000723")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000150")]
		private ICollection System.Collections.IDictionary.Keys
		{
			[Token(Token = "0x6000724")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000151")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6000725")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000152")]
		private ICollection System.Collections.IDictionary.Values
		{
			[Token(Token = "0x6000726")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000153")]
		public TValue Item
		{
			[Token(Token = "0x6000727")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x6000728")]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		private object System.Collections.IDictionary.Item
		{
			[Token(Token = "0x6000729")]
			get
			{
				return null;
			}
			[Token(Token = "0x600072A")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public int Count
		{
			[Token(Token = "0x6000733")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000156")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000734")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000157")]
		public bool IsSynchronized
		{
			[Token(Token = "0x6000735")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000158")]
		public object SyncRoot
		{
			[Token(Token = "0x6000736")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000718")]
		public UDictionary()
		{
		}

		[Token(Token = "0x6000719")]
		public UDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x600071A")]
		public UDictionary(IDictionary<TKey, TValue> dictionary)
		{
		}

		[Token(Token = "0x600071B")]
		public UDictionary(int capacity)
		{
		}

		[Token(Token = "0x600071C")]
		public UDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x600071D")]
		public UDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x600071E")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600071F")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000720")]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000721")]
		public void OnDeserialization(object sender)
		{
		}

		[Token(Token = "0x600072B")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x600072C")]
		private void System.Collections.IDictionary.Add(object key, object value)
		{
		}

		[Token(Token = "0x600072D")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x600072E")]
		private bool System.Collections.IDictionary.Contains(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x600072F")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000730")]
		private void System.Collections.IDictionary.Remove(object key)
		{
		}

		[Token(Token = "0x6000731")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000732")]
		private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000737")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		[Token(Token = "0x6000738")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000739")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x600073A")]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x600073B")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600073C")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x600073D")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600073E")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x20000CA")]
	public delegate void GenericEventHandler();
	[Token(Token = "0x20000CB")]
	public delegate void SenderEventHandler(object sender);
	[Token(Token = "0x20000CC")]
	public delegate void BoolEventHandler(object sender, bool value);
	[Token(Token = "0x20000CD")]
	public delegate void IntEventHandler(object sender, int value);
	[Token(Token = "0x20000CE")]
	public delegate void FloatEventHandler(object sender, float value);
	[Token(Token = "0x20000CF")]
	public delegate void StringEventHandler(object sender, string value);
	[Token(Token = "0x20000D0")]
	public delegate void ObjectEventHandler(object sender, object value);
	[Token(Token = "0x20000D1")]
	public delegate void Vector2EventHandler(object sender, Vector2 value);
	[Token(Token = "0x20000D2")]
	public delegate void Vector3EventHandler(object sender, Vector3 value);
	[Token(Token = "0x20000D3")]
	public delegate void Vector4EventHandler(object sender, Vector4 value);
	[Token(Token = "0x20000D4")]
	public delegate void CollisionEventHandler(object sender, Collision value);
	[Token(Token = "0x20000D5")]
	public delegate void ColliderEventHandler(object sender, Collider value);
	[Token(Token = "0x20000D6")]
	public delegate void ActionEventHandler(object sender, object[] args);
	[Token(Token = "0x20000D7")]
	public interface ICopiable
	{
		[Token(Token = "0x6000773")]
		bool Copiable(object destination);
	}
	[Token(Token = "0x20000D8")]
	public interface ICopy
	{
		[Token(Token = "0x6000774")]
		object Copy(object destination);
	}
	[Token(Token = "0x20000D9")]
	public interface IDataChanged
	{
		[Token(Token = "0x14000003")]
		event GenericEventHandler OnDataChanged;

		[Token(Token = "0x6000775")]
		void DataChanged();
	}
	[Token(Token = "0x20000DA")]
	public interface IDescriptor
	{
		[Token(Token = "0x6000778")]
		Description GetDescription(object[] instances, object[] values);
	}
	[Token(Token = "0x20000DB")]
	public interface IExpandable
	{
		[Token(Token = "0x6000779")]
		bool IsExpandable(object[] instances, object[] values);

		[Token(Token = "0x600077A")]
		bool IsExpanded(object[] instances, object[] values);

		[Token(Token = "0x600077B")]
		bool IsAlwaysExpanded(object[] instances, object[] values);
	}
	[Token(Token = "0x20000DC")]
	public interface IHelp
	{
		[Token(Token = "0x600077C")]
		IList<HelpItem> GetHelp(object[] instances, object[] values);
	}
	[Token(Token = "0x20000DD")]
	public interface IInspect
	{
		[Token(Token = "0x17000159")]
		object[] Inspect
		{
			[Token(Token = "0x600077D")]
			get;
		}
	}
	[Token(Token = "0x20000DE")]
	public interface IInspectorRunning
	{
		[Token(Token = "0x600077E")]
		void OnHeaderGUI();

		[Token(Token = "0x600077F")]
		void OnFooterGUI();
	}
	[Token(Token = "0x20000DF")]
	public interface IListAttribute
	{
	}
	[Token(Token = "0x20000E0")]
	public interface IMenu : IRuntimeAttribute
	{
		[Token(Token = "0x1700015A")]
		string MenuItemName
		{
			[Token(Token = "0x6000781")]
			get;
		}

		[Token(Token = "0x1700015B")]
		bool Enabled
		{
			[Token(Token = "0x6000782")]
			get;
		}

		[Token(Token = "0x1700015C")]
		bool IsOn
		{
			[Token(Token = "0x6000783")]
			get;
		}

		[Token(Token = "0x6000780")]
		void Invoke(int index, object instance, object value);
	}
	[Token(Token = "0x20000E1")]
	public interface IPicker
	{
		[Token(Token = "0x6000784")]
		bool IsPickingAvailable(object[] instances, object[] values);
	}
	[Token(Token = "0x20000E2")]
	public interface IPreview
	{
		[Token(Token = "0x1700015D")]
		UnityEngine.Object[] Preview
		{
			[Token(Token = "0x6000785")]
			get;
		}
	}
	[Token(Token = "0x20000E3")]
	public interface IReadOnly
	{
		[Token(Token = "0x6000786")]
		bool IsReadOnly(object[] instances, object[] values);
	}
	[Token(Token = "0x20000E4")]
	public interface IRestrict
	{
		[Token(Token = "0x6000787")]
		IList GetRestricted(object[] instances, object[] values);

		[Token(Token = "0x6000788")]
		RestrictDisplay GetDisplay(object[] instances, object[] values);

		[Token(Token = "0x6000789")]
		int GetItemsPerRow(object[] instances, object[] values);
	}
	[Token(Token = "0x20000E5")]
	public interface IRuntimeAttribute<T> : IRuntimeAttribute
	{
		[Token(Token = "0x600078A")]
		T Invoke(int index, object instance, object value);
	}
	[Token(Token = "0x20000E6")]
	public interface IRuntimeAttribute
	{
		[Token(Token = "0x1700015E")]
		string MethodName
		{
			[Token(Token = "0x600078B")]
			get;
		}

		[Token(Token = "0x1700015F")]
		Type Template
		{
			[Token(Token = "0x600078C")]
			get;
		}

		[Token(Token = "0x17000160")]
		Type TemplateStatic
		{
			[Token(Token = "0x600078D")]
			get;
		}

		[Token(Token = "0x17000161")]
		List<Delegate> Delegates
		{
			[Token(Token = "0x600078E")]
			get;
			[Token(Token = "0x600078F")]
			set;
		}
	}
	[Token(Token = "0x20000E7")]
	public interface IRuntimeType
	{
		[Token(Token = "0x6000790")]
		Type GetType(object[] instances, object[] values);
	}
	[Token(Token = "0x20000E8")]
	public interface ISpacing
	{
		[Token(Token = "0x6000791")]
		int GetAfter(object[] instances, object[] values);

		[Token(Token = "0x6000792")]
		int GetBefore(object[] instances, object[] values);
	}
	[Token(Token = "0x20000E9")]
	public interface IVisibility
	{
		[Token(Token = "0x6000793")]
		bool IsItemVisible(object[] instances, object[] values);

		[Token(Token = "0x6000794")]
		InspectorLevel GetItemLevel(object[] instances, object[] values);

		[Token(Token = "0x6000795")]
		int GetItemPriority(object[] instances, object[] values);
	}
	[Token(Token = "0x20000EA")]
	public class TypeUtility
	{
		[Token(Token = "0x6000796")]
		[Address(RVA = "0xEF9950", Offset = "0xEF9950", VA = "0xEF9950")]
		public static Type GetTypeByName(string name)
		{
			return null;
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xEE9FD0", Offset = "0xEE9FD0", VA = "0xEE9FD0")]
		public static List<FieldInfo> GetFields(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xEF9A50", Offset = "0xEF9A50", VA = "0xEF9A50")]
		public TypeUtility()
		{
		}
	}
}
namespace FSG.MeshAnimator
{
	[Token(Token = "0x20000EB")]
	[ExecuteInEditMode]
	public class AttachObjectToFace : MonoBehaviour
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MeshAnimator meshAnimator;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int faceIndex;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 offset;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool drawFaceDebugInfo;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color debugColor;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform mTransform;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform mMeshAnimatorTransform;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int[] triangles;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] vertices;

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xC152C0", Offset = "0xC152C0", VA = "0xC152C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xC153C4", Offset = "0xC153C4", VA = "0xC153C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xC15DD4", Offset = "0xC15DD4", VA = "0xC15DD4")]
		public AttachObjectToFace()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class MecanimMeshAnimatorController : MonoBehaviour
	{
		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MeshAnimator meshAnimator;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool crossFade;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<int, string> animHashes;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string cAnim;

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xC171E0", Offset = "0xC171E0", VA = "0xC171E0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xC17388", Offset = "0xC17388", VA = "0xC17388", Slot = "5")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xC1757C", Offset = "0xC1757C", VA = "0xC1757C")]
		public MecanimMeshAnimatorController()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000ED")]
	public class MeshAnimation : ScriptableObject
	{
		[Token(Token = "0x2000187")]
		public enum RootMotionMode
		{
			[Token(Token = "0x400072A")]
			None,
			[Token(Token = "0x400072B")]
			Baked,
			[Token(Token = "0x400072C")]
			AppliedToTransform
		}

		[Token(Token = "0x2000188")]
		private sealed class VertexEntry
		{
			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _reserved;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int[] TriangleIndex;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int[] VertexIndex;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _count;

			[Token(Token = "0x170001B9")]
			public int Count
			{
				[Token(Token = "0x60009FF")]
				[Address(RVA = "0xC1A030", Offset = "0xC1A030", VA = "0xC1A030")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0xC1A038", Offset = "0xC1A038", VA = "0xC1A038")]
			public VertexEntry()
			{
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0xC19AFC", Offset = "0xC19AFC", VA = "0xC19AFC")]
			public void Add(int vertIndex, int triIndex)
			{
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0xC19A68", Offset = "0xC19A68", VA = "0xC19A68")]
			public void PopulateArrays()
			{
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0xC19BF8", Offset = "0xC19BF8", VA = "0xC19BF8")]
			public void Clear()
			{
			}
		}

		[Token(Token = "0x2000189")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3174", Offset = "0x6C3174")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MeshAnimation <>4__this;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh mesh;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float angle;

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0xC19A50", Offset = "0xC19A50", VA = "0xC19A50")]
			public <>c__DisplayClass37_0()
			{
			}
		}

		[Token(Token = "0x200018A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3184", Offset = "0x6C3184")]
		private sealed class <>c__DisplayClass37_1
		{
			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int[] triangles;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3[] vertices;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass37_0 CS$<>8__locals1;

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0xC19A58", Offset = "0xC19A58", VA = "0xC19A58")]
			public <>c__DisplayClass37_1()
			{
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0xC19F2C", Offset = "0xC19F2C", VA = "0xC19F2C")]
			internal void <RecalculateNormals>b__0(object <p0>)
			{
			}
		}

		[Token(Token = "0x200018B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C3194", Offset = "0x6C3194")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Mesh mesh;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3[] normals;

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0xC19A60", Offset = "0xC19A60", VA = "0xC19A60")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0xC19F64", Offset = "0xC19F64", VA = "0xC19F64")]
			internal void <RecalculateNormals>b__0()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C31A4", Offset = "0x6C31A4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0xC19ED0", Offset = "0xC19ED0", VA = "0xC19ED0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0xC19ED8", Offset = "0xC19ED8", VA = "0xC19ED8")]
			internal bool <.cctor>b__42_0(Vector3 x, Vector3 y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0xC19F00", Offset = "0xC19F00", VA = "0xC19F00")]
			internal int <.cctor>b__42_1(Vector3 x)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static Dictionary<Mesh, Dictionary<MeshAnimation, Mesh[]>> generatedFrames;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string animationName;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool preGenerateFrames;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float playbackSpeed;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int smoothNormalsAngle;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool instantNormalCalculation;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool recalculateNormalsOnRotation;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WrapMode wrapMode;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public RootMotionMode rootMotionMode;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public DeltaCompressedFrameData compressedFrameData;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public string[] exposedTransforms;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MeshAnimationEvent[] events;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float length;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[HideInInspector]
		public int frameSkip;

		[NonSerialized]
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Mesh[] frames;

		[NonSerialized]
		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int totalFrames;

		[NonSerialized]
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool[] generatedMeshes;

		[NonSerialized]
		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool completelyGenerated;

		[NonSerialized]
		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private MeshFrameData[] decompressedFrameData;

		[NonSerialized]
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Queue<Action> mainThreadActions;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<Mesh, KeyValuePair<int[], Vector3[]>> meshInfoCache;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static IEqualityComparer<Vector3> VectorComparer;

		[Token(Token = "0x17000162")]
		[HideInInspector]
		public MeshFrameData[] frameData
		{
			[Token(Token = "0x600079F")]
			[Address(RVA = "0xC17604", Offset = "0xC17604", VA = "0xC17604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xC176A0", Offset = "0xC176A0", VA = "0xC176A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xC17738", Offset = "0xC17738", VA = "0xC17738")]
		public void GenerateFrames(Mesh baseMesh)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xC17E5C", Offset = "0xC17E5C", VA = "0xC17E5C")]
		public void GenerateFrameIfNeeded(Mesh baseMesh, int frame)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xC15A48", Offset = "0xC15A48", VA = "0xC15A48")]
		public Vector3[] GetFrame(int frame)
		{
			return null;
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xC18304", Offset = "0xC18304", VA = "0xC18304")]
		public float GetInterpolatingFrames(int frame, out MeshFrameData previousFrame, out MeshFrameData nextFrame)
		{
			return default(float);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xC18584", Offset = "0xC18584", VA = "0xC18584")]
		public MeshFrameData GetNearestFrame(int frame)
		{
			return null;
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xC1868C", Offset = "0xC1868C", VA = "0xC1868C")]
		public void DisplayFrame(MeshFilter meshFilter, int frame, int previousFrame)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xC1951C", Offset = "0xC1951C", VA = "0xC1951C")]
		public void FireEvents(GameObject eventReciever, int frame)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xC196AC", Offset = "0xC196AC", VA = "0xC196AC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xC197E4", Offset = "0xC197E4", VA = "0xC197E4")]
		public bool IsName(string animationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xC18274", Offset = "0xC18274", VA = "0xC18274")]
		private void CheckFullGeneration(int newFrame)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xC179D8", Offset = "0xC179D8", VA = "0xC179D8")]
		private Mesh GenerateFrame(Mesh baseMesh, int frame)
		{
			return null;
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xC19834", Offset = "0xC19834", VA = "0xC19834")]
		private void RecalculateNormals(Mesh mesh, float angle)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xC18834", Offset = "0xC18834", VA = "0xC18834")]
		private void RecalculateNormals(Mesh mesh, float angle, int[] triangles, Vector3[] vertices, bool instant = false)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xC19C98", Offset = "0xC19C98", VA = "0xC19C98")]
		public MeshAnimation()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EE")]
	public class MeshAnimationEvent
	{
		[Token(Token = "0x200018D")]
		public enum Mode : byte
		{
			[Token(Token = "0x400073B")]
			Data,
			[Token(Token = "0x400073C")]
			String,
			[Token(Token = "0x400073D")]
			Float
		}

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string methodName;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int frame;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Mode eventType;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string stringValue;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float floatValue;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEngine.Object data;

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xC195A4", Offset = "0xC195A4", VA = "0xC195A4")]
		public void FireEvent(GameObject eventReciever)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xC1A048", Offset = "0xC1A048", VA = "0xC1A048")]
		public MeshAnimationEvent()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6C2F74", Offset = "0x6C2F74")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6C2F74", Offset = "0x6C2F74")]
	public class MeshAnimator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200018E")]
		public class MeshAnimatorLODLevel
		{
			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int fps;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float distance;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float distanceSquared;

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0xC1E100", Offset = "0xC1E100", VA = "0xC1E100")]
			public MeshAnimatorLODLevel()
			{
			}
		}

		[Token(Token = "0x200018F")]
		private struct CurrentCrossFade
		{
			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MeshFrameData fromFrame;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MeshFrameData toFrame;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int framesNeeded;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int currentFrame;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int generatedFrame;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool isFading;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float endTime;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CrossFadeFrameData frame;

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0xC1AAF0", Offset = "0xC1AAF0", VA = "0xC1AAF0")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0xC1BBB0", Offset = "0xC1BBB0", VA = "0xC1BBB0")]
			public void PopulateFrame(int length)
			{
			}

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0xC1D310", Offset = "0xC1D310", VA = "0xC1D310")]
			public void ReturnFrame()
			{
			}
		}

		[Token(Token = "0x2000190")]
		private class CrossFadeFrameData
		{
			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] positions;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3[] normals;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Bounds bounds;

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0xC1E0F8", Offset = "0xC1E0F8", VA = "0xC1E0F8")]
			public CrossFadeFrameData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000191")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C31B4", Offset = "0x6C31B4")]
		private sealed class <>c
		{
			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<string> <>9__80_0;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action <>9__80_1;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Action<bool> <>9__80_2;

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0xC1E0E4", Offset = "0xC1E0E4", VA = "0xC1E0E4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0xC1E0EC", Offset = "0xC1E0EC", VA = "0xC1E0EC")]
			internal void <.ctor>b__80_0(string <p0>)
			{
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0xC1E0F0", Offset = "0xC1E0F0", VA = "0xC1E0F0")]
			internal void <.ctor>b__80_1()
			{
			}

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0xC1E0F4", Offset = "0xC1E0F4", VA = "0xC1E0F4")]
			internal void <.ctor>b__80_2(bool <p0>)
			{
			}
		}

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Mesh, int> s_meshCount;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<Thread> s_crossfadeThreads;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool s_shutDownThreads;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Queue<MeshAnimator> s_crossfadeAnimators;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<Stack<Mesh>> s_crossFadePool;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Dictionary<Mesh, int> s_crossFadeIndex;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mesh baseMesh;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MeshAnimation defaultAnimation;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MeshAnimation[] animations;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float speed;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool updateWhenOffscreen;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool playAutomatically;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public bool resetOnEnable;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject eventReciever;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int FPS;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool skipLastLoopFrame;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		public bool recalculateCrossfadeNormals;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action<string> OnAnimationFinished;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action OnFrameUpdated;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Action<bool> OnVisibilityChanged;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int currentFrame;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform LODCamera;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public MeshAnimatorLODLevel[] LODLevels;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public float nextTick;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public MeshFilter meshFilter;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public MeshAnimation currentAnimation;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public MeshTriangleData[] meshTriangleData;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector2[] uv1Data;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector2[] uv2Data;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		public Vector2[] uv3Data;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public Vector2[] uv4Data;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int currentAnimIndex;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool isVisible;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float lastFrameTime;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool pingPong;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC5")]
		private bool isPaused;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float currentAnimTime;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Mesh crossFadeMesh;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Queue<string> queuedAnims;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private CurrentCrossFade currentCrossFade;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int currentLodLevel;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform mTransform;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Dictionary<string, Transform> childMap;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool initialized;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int previousEventFrame;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool hasExposedTransforms;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private int crossFadePoolIndex;

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xC1A050", Offset = "0xC1A050", VA = "0xC1A050")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xC1A6B0", Offset = "0xC1A6B0", VA = "0xC1A6B0")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xC1A714", Offset = "0xC1A714", VA = "0xC1A714")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xC1A774", Offset = "0xC1A774", VA = "0xC1A774")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xC1A9BC", Offset = "0xC1A9BC", VA = "0xC1A9BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xC1AB0C", Offset = "0xC1AB0C", VA = "0xC1AB0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xC1B49C", Offset = "0xC1B49C", VA = "0xC1B49C")]
		private void FireAnimationEvents(MeshAnimation cAnim, float totalSpeed, bool finished)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xC1B624", Offset = "0xC1B624", VA = "0xC1B624")]
		private Mesh GetCrossfadeFromPool()
		{
			return null;
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xC1B188", Offset = "0xC1B188", VA = "0xC1B188")]
		private void ReturnCrossfadeToPool()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xC1B81C", Offset = "0xC1B81C", VA = "0xC1B81C")]
		private void GenerateCrossfadeFrame()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xC1BCB4", Offset = "0xC1BCB4", VA = "0xC1BCB4")]
		private static void EnqueueAnimatorForCrossfade(MeshAnimator animator)
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xC1BDC8", Offset = "0xC1BDC8", VA = "0xC1BDC8")]
		private static MeshAnimator DequeueAnimatorForCrossfade()
		{
			return null;
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xC1BF28", Offset = "0xC1BF28", VA = "0xC1BF28")]
		private static Matrix4x4 MatrixLerp(Matrix4x4 from, Matrix4x4 to, float time)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xC1C034", Offset = "0xC1C034", VA = "0xC1C034")]
		private static void GenerateThreadedCrossfade()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xC1C2D0", Offset = "0xC1C2D0", VA = "0xC1C2D0")]
		public void UpdateTick(float time)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xC1D3FC", Offset = "0xC1D3FC", VA = "0xC1D3FC")]
		public void Crossfade(int index)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xC174DC", Offset = "0xC174DC", VA = "0xC174DC")]
		public void Crossfade(string animationName)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xC1D408", Offset = "0xC1D408", VA = "0xC1D408")]
		public void Crossfade(int index, float speed)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xC1D5A4", Offset = "0xC1D5A4", VA = "0xC1D5A4")]
		public void Crossfade(string animationName, float speed)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xC1D64C", Offset = "0xC1D64C", VA = "0xC1D64C")]
		public void Play()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xC174E8", Offset = "0xC174E8", VA = "0xC174E8")]
		public void Play(string animationName)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xC1D230", Offset = "0xC1D230", VA = "0xC1D230")]
		public void Play(int index)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xC1D654", Offset = "0xC1D654", VA = "0xC1D654")]
		public void PlayRandom(params string[] animationNames)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xC1D710", Offset = "0xC1D710", VA = "0xC1D710")]
		public void PlayQueued(string animationName)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xC1D7A8", Offset = "0xC1D7A8", VA = "0xC1D7A8")]
		public void Pause()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xC1D7B4", Offset = "0xC1D7B4", VA = "0xC1D7B4")]
		public void RestartAnim()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xC1D7BC", Offset = "0xC1D7BC", VA = "0xC1D7BC")]
		public void SetTime(float time, bool instantUpdate = false)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xC1D8B4", Offset = "0xC1D8B4", VA = "0xC1D8B4")]
		public void SetTimeNormalized(float time, bool instantUpdate = false)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xC1D9A8", Offset = "0xC1D9A8", VA = "0xC1D9A8")]
		public MeshAnimation GetClip(string animationName)
		{
			return null;
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xC1DA44", Offset = "0xC1DA44", VA = "0xC1DA44")]
		public void PrepopulateCrossfadePool(int count)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xC1DD10", Offset = "0xC1DD10", VA = "0xC1DD10")]
		public MeshAnimator()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class MeshAnimatorManager : MonoBehaviour
	{
		[Token(Token = "0x2000192")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C31C4", Offset = "0x6C31C4")]
		private sealed class <UnscaledUpdate>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MeshAnimatorManager <>4__this;

			[Token(Token = "0x170001BA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A1A")]
				[Address(RVA = "0xC1E920", Offset = "0xC1E920", VA = "0xC1E920", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001BB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A1C")]
				[Address(RVA = "0xC1E988", Offset = "0xC1E988", VA = "0xC1E988", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0xC1E4D4", Offset = "0xC1E4D4", VA = "0xC1E4D4")]
			[DebuggerHidden]
			public <UnscaledUpdate>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0xC1E85C", Offset = "0xC1E85C", VA = "0xC1E85C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0xC1E860", Offset = "0xC1E860", VA = "0xC1E860", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0xC1E928", Offset = "0xC1E928", VA = "0xC1E928", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AnimatorUpdateMode mode;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MeshAnimatorManager mInstance;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<MeshAnimator> mAnimators;

		[Token(Token = "0x17000163")]
		public static int AnimatorCount
		{
			[Token(Token = "0x60007D2")]
			[Address(RVA = "0xC1A5E0", Offset = "0xC1A5E0", VA = "0xC1A5E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000164")]
		public static MeshAnimatorManager Instance
		{
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0xC1E108", Offset = "0xC1E108", VA = "0xC1E108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xC1A8CC", Offset = "0xC1A8CC", VA = "0xC1A8CC")]
		public static void AddAnimator(MeshAnimator animator)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xC1AA6C", Offset = "0xC1AA6C", VA = "0xC1AA6C")]
		public static void RemoveAnimator(MeshAnimator animator)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xC1E2B0", Offset = "0xC1E2B0", VA = "0xC1E2B0")]
		public static void SetUpdateMode(AnimatorUpdateMode updateMode)
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xC1E440", Offset = "0xC1E440", VA = "0xC1E440")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xC1E3D0", Offset = "0xC1E3D0", VA = "0xC1E3D0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6C6274", Offset = "0x6C6274")]
		private IEnumerator UnscaledUpdate()
		{
			return null;
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xC1E500", Offset = "0xC1E500", VA = "0xC1E500")]
		private void Update()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xC1E740", Offset = "0xC1E740", VA = "0xC1E740")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xC1E580", Offset = "0xC1E580", VA = "0xC1E580")]
		private void UpdateTick(float time)
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xC1E7C4", Offset = "0xC1E7C4", VA = "0xC1E7C4")]
		public MeshAnimatorManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F1")]
	public class MeshFrameData
	{
		[NonSerialized]
		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3[] decompressed;

		[NonSerialized]
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Matrix4x4[] exposedTransforms;

		[NonSerialized]
		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 rootMotionPosition;

		[NonSerialized]
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Quaternion rootMotionRotation;

		[Token(Token = "0x17000165")]
		public Vector3[] verts
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0xC1E990", Offset = "0xC1E990", VA = "0xC1E990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xC1E998", Offset = "0xC1E998", VA = "0xC1E998")]
		public void SetVerts(Vector3[] v)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xC1E9A0", Offset = "0xC1E9A0", VA = "0xC1E9A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xC1EB54", Offset = "0xC1EB54", VA = "0xC1EB54", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xC1645C", Offset = "0xC1645C", VA = "0xC1645C")]
		public MeshFrameData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F2")]
	public class MeshTriangleData
	{
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int submesh;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] triangles;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xC1EB5C", Offset = "0xC1EB5C", VA = "0xC1EB5C")]
		public MeshTriangleData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F3")]
	public class DeltaCompressedFrameData
	{
		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float compressionAccuracy;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float accuracy;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int sizeOffset;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int vertLength;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int exposedLength;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public short[] positionsUShort;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public int[] positions;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public int[] frameIndexes;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public Matrix4x4[] exposedTransforms;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public Vector3[] rootMotionPositions;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Quaternion[] rootMotionRotations;

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xC16044", Offset = "0xC16044", VA = "0xC16044")]
		public static implicit operator MeshFrameData[](DeltaCompressedFrameData s)
		{
			return null;
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xC16464", Offset = "0xC16464", VA = "0xC16464")]
		public static implicit operator DeltaCompressedFrameData(MeshFrameData[] frames)
		{
			return null;
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xC16DD0", Offset = "0xC16DD0", VA = "0xC16DD0")]
		public DeltaCompressedFrameData()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public static class AllocatedArray<T>
	{
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T defaultValue;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<T[]> allocatedArrays;

		[Token(Token = "0x60007E8")]
		private static T[] AllocateArray(int size)
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		public static T[] Get(int size)
		{
			return null;
		}

		[Token(Token = "0x60007EA")]
		public static void Return(T[] array, bool resetValues = true)
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public static class Comparers
	{
		[Serializable]
		[Token(Token = "0x2000193")]
		public class StringComparer : IEqualityComparer<string>
		{
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0xC16014", Offset = "0xC16014", VA = "0xC16014", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.String>.Equals(string x, string y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0xC16024", Offset = "0xC16024", VA = "0xC16024", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.String>.GetHashCode(string obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0xC15F14", Offset = "0xC15F14", VA = "0xC15F14")]
			public StringComparer()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000194")]
		public class FloatComparer : IEqualityComparer<float>
		{
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0xC15FAC", Offset = "0xC15FAC", VA = "0xC15FAC", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Single>.Equals(float x, float y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0xC15FB8", Offset = "0xC15FB8", VA = "0xC15FB8", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Single>.GetHashCode(float obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0xC15F1C", Offset = "0xC15F1C", VA = "0xC15F1C")]
			public FloatComparer()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000195")]
		public class IntComparer : IEqualityComparer<int>
		{
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0xC15FE0", Offset = "0xC15FE0", VA = "0xC15FE0", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Int32>.Equals(int x, int y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0xC15FEC", Offset = "0xC15FEC", VA = "0xC15FEC", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Int32>.GetHashCode(int obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0xC15F24", Offset = "0xC15F24", VA = "0xC15F24")]
			public IntComparer()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000196")]
		public class ByteComparer : IEqualityComparer<byte>
		{
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0xC15F74", Offset = "0xC15F74", VA = "0xC15F74", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Byte>.Equals(byte x, byte y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A27")]
			[Address(RVA = "0xC15F84", Offset = "0xC15F84", VA = "0xC15F84", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Byte>.GetHashCode(byte obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0xC15F2C", Offset = "0xC15F2C", VA = "0xC15F2C")]
			public ByteComparer()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000197")]
		public class BoolComparer : IEqualityComparer<bool>
		{
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0xC15F3C", Offset = "0xC15F3C", VA = "0xC15F3C", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Boolean>.Equals(bool x, bool y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0xC15F48", Offset = "0xC15F48", VA = "0xC15F48", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Boolean>.GetHashCode(bool obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0xC15F34", Offset = "0xC15F34", VA = "0xC15F34")]
			public BoolComparer()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000198")]
		private class FuncEqualityComparer<T> : EqualityComparer<T>
		{
			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<T, T, bool> equals;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<T, int> hash;

			[Token(Token = "0x6000A2C")]
			public FuncEqualityComparer(Func<T, T, bool> equals, Func<T, int> hash)
			{
			}

			[Token(Token = "0x6000A2D")]
			public override bool Equals(T a, T b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A2E")]
			public override int GetHashCode(T obj)
			{
				return default(int);
			}
		}

		[Serializable]
		[Token(Token = "0x2000199")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C31D4", Offset = "0x6C31D4")]
		private sealed class <>c__10<T>
		{
			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__10<T> <>9;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<T, int> <>9__10_0;

			[Token(Token = "0x6000A30")]
			public <>c__10()
			{
			}

			[Token(Token = "0x6000A31")]
			internal int <Create>b__10_0(T t)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly StringComparer String;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly FloatComparer Float;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly IntComparer Int;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly ByteComparer Byte;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly BoolComparer Bool;

		[Token(Token = "0x60007EC")]
		public static IEqualityComparer<T> Create<T>(Func<T, T, bool> equals, [Optional] Func<T, int> hash)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F6")]
	public static class GenericObjectPool<T>
	{
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Stack<T> pool;

		[Token(Token = "0x17000166")]
		public static int Count
		{
			[Token(Token = "0x60007EE")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007EF")]
		public static void InitPool(int count)
		{
		}

		[Token(Token = "0x60007F0")]
		public static T Get()
		{
			return (T)null;
		}

		[Token(Token = "0x60007F1")]
		public static void Return(T obj)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public static class MatrixUtils
	{
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xC16E38", Offset = "0xC16E38", VA = "0xC16E38")]
		public static void FromMatrix4x4(Transform transform, Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xC16F78", Offset = "0xC16F78", VA = "0xC16F78")]
		public static Quaternion GetRotation(Matrix4x4 matrix)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xC16ED4", Offset = "0xC16ED4", VA = "0xC16ED4")]
		public static Vector3 GetPosition(Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xC1711C", Offset = "0xC1711C", VA = "0xC1711C")]
		public static Vector3 GetScale(Matrix4x4 m)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000F8")]
	public class PooledDictionary<T, T2> : Dictionary<T, T2>
	{
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Stack<PooledDictionary<T, T2>> stack;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint checkedOut;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint returned;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C4FF0", Offset = "0x6C4FF0")]
		private bool <recycleable>k__BackingField;

		[Token(Token = "0x17000167")]
		public bool recycleable
		{
			[Token(Token = "0x60007F7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C62D8", Offset = "0x6C62D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C62E8", Offset = "0x6C62E8")]
			set
			{
			}
		}

		[Token(Token = "0x60007F9")]
		public static void Init(int initialPoolSize = 10)
		{
		}

		[Token(Token = "0x60007FA")]
		public static PooledDictionary<T, T2> Get(int capacity, [Optional] IEqualityComparer<T> comparer)
		{
			return null;
		}

		[Token(Token = "0x60007FB")]
		public static PooledDictionary<T, T2> Get()
		{
			return null;
		}

		[Token(Token = "0x60007FC")]
		public static PooledDictionary<T, T2> Get(IEqualityComparer<T> comparer)
		{
			return null;
		}

		[Token(Token = "0x60007FD")]
		public PooledDictionary()
		{
		}

		[Token(Token = "0x60007FE")]
		public PooledDictionary(int capacity)
		{
		}

		[Token(Token = "0x60007FF")]
		public PooledDictionary(int capacity, IEqualityComparer<T> comparer)
		{
		}

		[Token(Token = "0x6000800")]
		public void ReturnToPool(bool force = false)
		{
		}
	}
}
namespace LIV.SDK.Unity
{
	[Token(Token = "0x20000F9")]
	[Flags]
	public enum INVALIDATION_FLAGS : uint
	{
		[Token(Token = "0x40004DD")]
		NONE = 0u,
		[Token(Token = "0x40004DE")]
		HMD_CAMERA = 1u,
		[Token(Token = "0x40004DF")]
		STAGE = 2u,
		[Token(Token = "0x40004E0")]
		MR_CAMERA_PREFAB = 4u,
		[Token(Token = "0x40004E1")]
		EXCLUDE_BEHAVIOURS = 8u
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6C300C", Offset = "0x6C300C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6C300C", Offset = "0x6C300C")]
	public class LIV : MonoBehaviour
	{
		[Token(Token = "0x200019A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C31E4", Offset = "0x6C31E4")]
		private sealed class <WaitForUnityEndOfFrame>d__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LIV <>4__this;

			[Token(Token = "0x170001BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A35")]
				[Address(RVA = "0xE650E0", Offset = "0xE650E0", VA = "0xE650E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A37")]
				[Address(RVA = "0xE65148", Offset = "0xE65148", VA = "0xE65148", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0xE645E4", Offset = "0xE645E4", VA = "0xE645E4")]
			[DebuggerHidden]
			public <WaitForUnityEndOfFrame>d__68(int <>1__state)
			{
			}

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0xE64F34", Offset = "0xE64F34", VA = "0xE64F34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0xE64F38", Offset = "0xE64F38", VA = "0xE64F38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A36")]
			[Address(RVA = "0xE650E8", Offset = "0xE650E8", VA = "0xE650E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onActivate;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<SDKRender> onPreRender;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<SDKRender> onPreRenderBackground;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<SDKRender> onPostRenderBackground;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<SDKRender> onPreRenderForeground;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<SDKRender> onPostRenderForeground;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action<SDKRender> onPostRender;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action onDeactivate;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C5000", Offset = "0x6C5000")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C5000", Offset = "0x6C5000")]
		[SerializeField]
		private Transform _stage;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C5070", Offset = "0x6C5070")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C5070", Offset = "0x6C5070")]
		[SerializeField]
		private Transform _stageTransform;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C50E0", Offset = "0x6C50E0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C50E0", Offset = "0x6C50E0")]
		[SerializeField]
		private Camera _HMDCamera;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C5150", Offset = "0x6C5150")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C5150", Offset = "0x6C5150")]
		[SerializeField]
		private Camera _MRCameraPrefab;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C51C0", Offset = "0x6C51C0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C51C0", Offset = "0x6C51C0")]
		[SerializeField]
		private bool _disableStandardAssets;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C5230", Offset = "0x6C5230")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C5230", Offset = "0x6C5230")]
		[SerializeField]
		private LayerMask _spectatorLayerMask;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C52A0", Offset = "0x6C52A0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C52A0", Offset = "0x6C52A0")]
		[SerializeField]
		private string[] _excludeBehaviours;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6C5310", Offset = "0x6C5310")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6C5310", Offset = "0x6C5310")]
		[SerializeField]
		private bool _fixPostEffectsAlpha;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool _isActive;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private SDKRender _render;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _wasReady;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private INVALIDATION_FLAGS _invalidate;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Transform _stageCandidate;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Camera _HMDCameraCandidate;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera _MRCameraPrefabCandidate;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string[] _excludeBehavioursCandidate;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool _enabled;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Coroutine _waitForEndOfFrameCoroutine;

		[Token(Token = "0x17000168")]
		public Transform stage
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0xE63C38", Offset = "0xE63C38", VA = "0xE63C38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000803")]
			[Address(RVA = "0xE63CD8", Offset = "0xE63CD8", VA = "0xE63CD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6C6808", Offset = "0x6C6808")]
		public Transform trackedSpaceOrigin
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0xE63DE0", Offset = "0xE63DE0", VA = "0xE63DE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000805")]
			[Address(RVA = "0xE63DE4", Offset = "0xE63DE4", VA = "0xE63DE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700016A")]
		public Matrix4x4 stageLocalToWorldMatrix
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0xE63DE8", Offset = "0xE63DE8", VA = "0xE63DE8")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x1700016B")]
		public Matrix4x4 stageWorldToLocalMatrix
		{
			[Token(Token = "0x6000807")]
			[Address(RVA = "0xE63EC8", Offset = "0xE63EC8", VA = "0xE63EC8")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x1700016C")]
		public Transform stageTransform
		{
			[Token(Token = "0x6000808")]
			[Address(RVA = "0xE63FA8", Offset = "0xE63FA8", VA = "0xE63FA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000809")]
			[Address(RVA = "0xE63FB0", Offset = "0xE63FB0", VA = "0xE63FB0")]
			set
			{
			}
		}

		[Token(Token = "0x1700016D")]
		public Camera HMDCamera
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0xE63FB8", Offset = "0xE63FB8", VA = "0xE63FB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600080B")]
			[Address(RVA = "0xE63FC0", Offset = "0xE63FC0", VA = "0xE63FC0")]
			set
			{
			}
		}

		[Token(Token = "0x1700016E")]
		public Camera MRCameraPrefab
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0xE640B4", Offset = "0xE640B4", VA = "0xE640B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600080D")]
			[Address(RVA = "0xE640BC", Offset = "0xE640BC", VA = "0xE640BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700016F")]
		public bool disableStandardAssets
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0xE64150", Offset = "0xE64150", VA = "0xE64150")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600080F")]
			[Address(RVA = "0xE64158", Offset = "0xE64158", VA = "0xE64158")]
			set
			{
			}
		}

		[Token(Token = "0x17000170")]
		public LayerMask spectatorLayerMask
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0xE64164", Offset = "0xE64164", VA = "0xE64164")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000811")]
			[Address(RVA = "0xE6416C", Offset = "0xE6416C", VA = "0xE6416C")]
			set
			{
			}
		}

		[Token(Token = "0x17000171")]
		public string[] excludeBehaviours
		{
			[Token(Token = "0x6000812")]
			[Address(RVA = "0xE64174", Offset = "0xE64174", VA = "0xE64174")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000813")]
			[Address(RVA = "0xE6417C", Offset = "0xE6417C", VA = "0xE6417C")]
			set
			{
			}
		}

		[Token(Token = "0x17000172")]
		public bool fixPostEffectsAlpha
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0xE6419C", Offset = "0xE6419C", VA = "0xE6419C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000815")]
			[Address(RVA = "0xE641A4", Offset = "0xE641A4", VA = "0xE641A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000173")]
		public bool isValid
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0xE641B0", Offset = "0xE641B0", VA = "0xE641B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000174")]
		public bool isActive
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0xE64320", Offset = "0xE64320", VA = "0xE64320")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000175")]
		private bool _isReady
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0xE64328", Offset = "0xE64328", VA = "0xE64328")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000176")]
		public SDKRender render
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0xE64464", Offset = "0xE64464", VA = "0xE64464")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xE6446C", Offset = "0xE6446C", VA = "0xE6446C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xE644D0", Offset = "0xE644D0", VA = "0xE644D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xE6456C", Offset = "0xE6456C", VA = "0xE6456C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xE64574", Offset = "0xE64574", VA = "0xE64574")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6C62F8", Offset = "0x6C62F8")]
		private IEnumerator WaitForUnityEndOfFrame()
		{
			return null;
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xE64478", Offset = "0xE64478", VA = "0xE64478")]
		private void UpdateSDKReady()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xE64610", Offset = "0xE64610", VA = "0xE64610")]
		private void OnSDKReadyChanged(bool value)
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xE6461C", Offset = "0xE6461C", VA = "0xE6461C")]
		private void OnSDKActivate()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xE646C4", Offset = "0xE646C4", VA = "0xE646C4")]
		private void OnSDKDeactivate()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xE648E0", Offset = "0xE648E0", VA = "0xE648E0")]
		private void CreateAssets()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xE649D0", Offset = "0xE649D0", VA = "0xE649D0")]
		private void DestroyAssets()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xE64950", Offset = "0xE64950", VA = "0xE64950")]
		private void StartRenderCoroutine()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xE649A0", Offset = "0xE649A0", VA = "0xE649A0")]
		private void StopRenderCoroutine()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xE64774", Offset = "0xE64774", VA = "0xE64774")]
		private void SubmitSDKOutput()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xE644F4", Offset = "0xE644F4", VA = "0xE644F4")]
		private void Invalidate()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xE64D98", Offset = "0xE64D98", VA = "0xE64D98")]
		public LIV()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public static class SDKBridge
	{
		[Token(Token = "0x200019B")]
		public struct SDKInjection<T>
		{
			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool active;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action action;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T data;
		}

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SDKInjection<SDKInputFrame> _injection_SDKInputFrame;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static SDKInjection<SDKResolution> _injection_SDKResolution;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static SDKInjection<bool> _injection_IsActive;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static bool _injection_DisableSubmit;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x199")]
		private static bool _injection_DisableSubmitApplicationOutput;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19A")]
		private static bool _injection_DisableAddTexture;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19B")]
		private static bool _injection_DisableCreateFrame;

		[Token(Token = "0x17000177")]
		public static bool IsActive
		{
			[Token(Token = "0x600083B")]
			[Address(RVA = "0xE643AC", Offset = "0xE643AC", VA = "0xE643AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xE6538C", Offset = "0xE6538C", VA = "0xE6538C")]
		public static int AddStringToChannel(int slot, IntPtr str, int length, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xE65394", Offset = "0xE65394", VA = "0xE65394")]
		public static int addtexture(IntPtr sourcetexture, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xE6539C", Offset = "0xE6539C", VA = "0xE6539C")]
		public static ulong GetObjectTimeStamp(IntPtr obj)
		{
			return default(ulong);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xE653A4", Offset = "0xE653A4", VA = "0xE653A4")]
		public static ulong GetCurrentTimeTicks()
		{
			return default(ulong);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xE653AC", Offset = "0xE653AC", VA = "0xE653AC")]
		private static bool GetIsCaptureActive()
		{
			return default(bool);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xE653B4", Offset = "0xE653B4", VA = "0xE653B4")]
		public static IntPtr GetRenderEventFunc()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xE653F4", Offset = "0xE653F4", VA = "0xE653F4")]
		public static IntPtr GetCompositorChannelObject(int slot, ulong tag, ulong timestamp)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xE65434", Offset = "0xE65434", VA = "0xE65434")]
		public static int AddObjectToCompositorChannel(int slot, IntPtr obj, int objectsize, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xE6543C", Offset = "0xE6543C", VA = "0xE6543C")]
		public static int AddObjectToFrame(IntPtr obj, int objectsize, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xE65444", Offset = "0xE65444", VA = "0xE65444")]
		public static IntPtr updatinputframe(IntPtr InputFrame)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xE65484", Offset = "0xE65484", VA = "0xE65484")]
		public static IntPtr GetViewportTexture()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xE654C4", Offset = "0xE654C4", VA = "0xE654C4")]
		public static IntPtr GetChannelObject(int slot, ulong tag, ulong timestamp)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xE65504", Offset = "0xE65504", VA = "0xE65504")]
		public static int AddObjectToChannel(int slot, IntPtr obj, int objectsize, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xE6550C", Offset = "0xE6550C", VA = "0xE6550C")]
		public static ulong Tag(string str)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xE65594", Offset = "0xE65594", VA = "0xE65594")]
		public static void AddString(string tag, string value, int slot)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xE65690", Offset = "0xE65690", VA = "0xE65690")]
		public static void AddTexture(SDKTexture texture, ulong tag)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xE6574C", Offset = "0xE6574C", VA = "0xE6574C")]
		public static ulong GetObjectTime(IntPtr objectptr)
		{
			return default(ulong);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xE657B8", Offset = "0xE657B8", VA = "0xE657B8")]
		public static ulong GetCurrentTime()
		{
			return default(ulong);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xE65824", Offset = "0xE65824", VA = "0xE65824")]
		public static void IssuePluginEvent()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xE64BFC", Offset = "0xE64BFC", VA = "0xE64BFC")]
		public static void SubmitApplicationOutput(SDKApplicationOutput applicationOutput)
		{
		}

		[Token(Token = "0x600083E")]
		public static bool GetStructFromGlobalChannel<T>(ref T mystruct, int channel, ulong tag)
		{
			return default(bool);
		}

		[Token(Token = "0x600083F")]
		public static int AddStructToGlobalChannel<T>(ref T mystruct, int channel, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000840")]
		public static bool GetStructFromLocalChannel<T>(ref T mystruct, int channel, ulong tag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000841")]
		public static int AddStructToLocalChannel<T>(ref T mystruct, int channel, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000842")]
		public static void AddStructToFrame<T>(ref T mystruct, ulong tag)
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xE658E0", Offset = "0xE658E0", VA = "0xE658E0")]
		public static bool UpdateInputFrame(ref SDKInputFrame setframe)
		{
			return default(bool);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xE65C98", Offset = "0xE65C98", VA = "0xE65C98")]
		public static SDKTexture GetViewfinderTexture()
		{
			return default(SDKTexture);
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xE65E80", Offset = "0xE65E80", VA = "0xE65E80")]
		public static void AddTexture(SDKTexture texture)
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xE65F98", Offset = "0xE65F98", VA = "0xE65F98")]
		public static void CreateFrame(SDKOutputFrame frame)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xE660E8", Offset = "0xE660E8", VA = "0xE660E8")]
		public static void SetGroundPlane(SDKPlane groundPlane)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xE66180", Offset = "0xE66180", VA = "0xE66180")]
		public static bool GetResolution(ref SDKResolution sdkResolution)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000FC")]
	public class SDKRender : IDisposable
	{
		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CommandBuffer _clipPlaneCommandBuffer;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CommandBuffer _combineAlphaCommandBuffer;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CommandBuffer _captureTextureCommandBuffer;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CommandBuffer _applyTextureCommandBuffer;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CommandBuffer _optimizedRenderingCommandBuffer;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CameraEvent _clipPlaneCameraEvent;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private CameraEvent _clipPlaneCombineAlphaCameraEvent;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CameraEvent _captureTextureEvent;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private CameraEvent _applyTextureEvent;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CameraEvent _optimizedRenderingCameraEvent;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Mesh _clipPlaneMesh;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material _clipPlaneSimpleMaterial;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material _clipPlaneSimpleDebugMaterial;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material _clipPlaneComplexMaterial;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _clipPlaneComplexDebugMaterial;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material _writeOpaqueToAlphaMaterial;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material _combineAlphaMaterial;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material _writeMaterial;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material _forceForwardRenderingMaterial;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RenderTexture _backgroundRenderTexture;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RenderTexture _foregroundRenderTexture;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RenderTexture _optimizedRenderTexture;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RenderTexture _complexClipPlaneRenderTexture;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private LIV _liv;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private SDKOutputFrame _outputFrame;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private SDKInputFrame _inputFrame;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private SDKResolution _resolution;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private Camera _cameraInstance;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private SDKPose _requestedPose;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private int _requestedPoseFrameIndex;

		[Token(Token = "0x17000178")]
		private bool useDeferredRendering
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0xE68360", Offset = "0xE68360", VA = "0xE68360")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000179")]
		private bool interlacedRendering
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0xE683B8", Offset = "0xE683B8", VA = "0xE683B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017A")]
		private bool canRenderBackground
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0xE683D0", Offset = "0xE683D0", VA = "0xE683D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017B")]
		private bool canRenderForeground
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0xE6846C", Offset = "0xE6846C", VA = "0xE6846C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017C")]
		private bool canRenderOptimized
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0xE6851C", Offset = "0xE6851C", VA = "0xE6851C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017D")]
		public LIV liv
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0xE6BDC8", Offset = "0xE6BDC8", VA = "0xE6BDC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017E")]
		public SDKOutputFrame outputFrame
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0xE6BDD0", Offset = "0xE6BDD0", VA = "0xE6BDD0")]
			get
			{
				return default(SDKOutputFrame);
			}
		}

		[Token(Token = "0x1700017F")]
		public SDKInputFrame inputFrame
		{
			[Token(Token = "0x600085B")]
			[Address(RVA = "0xE6BDE0", Offset = "0xE6BDE0", VA = "0xE6BDE0")]
			get
			{
				return default(SDKInputFrame);
			}
		}

		[Token(Token = "0x17000180")]
		public SDKResolution resolution
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0xE6BDF0", Offset = "0xE6BDF0", VA = "0xE6BDF0")]
			get
			{
				return default(SDKResolution);
			}
		}

		[Token(Token = "0x17000181")]
		public Camera cameraInstance
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0xE6BDF8", Offset = "0xE6BDF8", VA = "0xE6BDF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000182")]
		public Camera cameraReference
		{
			[Token(Token = "0x600085E")]
			[Address(RVA = "0xE6B1F0", Offset = "0xE6B1F0", VA = "0xE6B1F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000183")]
		public Camera hmdCamera
		{
			[Token(Token = "0x600085F")]
			[Address(RVA = "0xE6BE00", Offset = "0xE6BE00", VA = "0xE6BE00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000184")]
		public Transform stage
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0xE6BE1C", Offset = "0xE6BE1C", VA = "0xE6BE1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000185")]
		public Transform stageTransform
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0xE6BE34", Offset = "0xE6BE34", VA = "0xE6BE34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000186")]
		public Matrix4x4 stageLocalToWorldMatrix
		{
			[Token(Token = "0x6000862")]
			[Address(RVA = "0xE6BE50", Offset = "0xE6BE50", VA = "0xE6BE50")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x17000187")]
		public Matrix4x4 localToWorldMatrix
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0xE6A5A4", Offset = "0xE6A5A4", VA = "0xE6A5A4")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x17000188")]
		public int spectatorLayerMask
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0xE6A664", Offset = "0xE6A664", VA = "0xE6A664")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000189")]
		public bool disableStandardAssets
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0xE6ABF4", Offset = "0xE6ABF4", VA = "0xE6ABF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700018A")]
		public bool canSetPose
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0xE6BF38", Offset = "0xE6BF38", VA = "0xE6BF38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xE68188", Offset = "0xE68188", VA = "0xE68188")]
		private Material GetClipPlaneMaterial(bool debugClipPlane, bool complexClipPlane, ColorWriteMask colorWriteMask)
		{
			return null;
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xE682B4", Offset = "0xE682B4", VA = "0xE682B4")]
		private Material GetGroundClipPlaneMaterial(bool debugClipPlane, ColorWriteMask colorWriteMask)
		{
			return null;
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xE649FC", Offset = "0xE649FC", VA = "0xE649FC")]
		public SDKRender(LIV liv)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xE6500C", Offset = "0xE6500C", VA = "0xE6500C")]
		public void Render()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xE691FC", Offset = "0xE691FC", VA = "0xE691FC")]
		private void RenderBackground()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xE694E4", Offset = "0xE694E4", VA = "0xE694E4")]
		private void RenderForeground()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xE69E84", Offset = "0xE69E84", VA = "0xE69E84")]
		private void RenderOptimized()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xE685A4", Offset = "0xE685A4", VA = "0xE685A4")]
		private void CreateAssets()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xE6BB30", Offset = "0xE6BB30", VA = "0xE6BB30")]
		private void DestroyAssets()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xE64B44", Offset = "0xE64B44", VA = "0xE64B44", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xE6BF58", Offset = "0xE6BF58", VA = "0xE6BF58")]
		public bool SetPose(Vector3 position, Quaternion rotation, float verticalFieldOfView = 60f, bool useLocalSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xE6C3E8", Offset = "0xE6C3E8", VA = "0xE6C3E8")]
		public void SetGroundPlane(float distance, Vector3 normal, bool useLocalSpace = false)
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xE6C5DC", Offset = "0xE6C5DC", VA = "0xE6C5DC")]
		public void SetGroundPlane(Plane plane, bool useLocalSpace = false)
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xE6C658", Offset = "0xE6C658", VA = "0xE6C658")]
		public void SetGroundPlane(Transform transform, bool useLocalSpace = false)
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xE6BCB0", Offset = "0xE6BCB0", VA = "0xE6BCB0")]
		private void ReleaseBridgePoseControl()
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xE68B94", Offset = "0xE68B94", VA = "0xE68B94")]
		private void UpdateBridgeResolution()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xE68BFC", Offset = "0xE68BFC", VA = "0xE68BFC")]
		private void UpdateBridgeInputFrame()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xE6918C", Offset = "0xE6918C", VA = "0xE6918C")]
		private void InvokePreRender()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xE6A398", Offset = "0xE6A398", VA = "0xE6A398")]
		private void IvokePostRender()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xE6A978", Offset = "0xE6A978", VA = "0xE6A978")]
		private void InvokePreRenderBackground()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xE6AAEC", Offset = "0xE6AAEC", VA = "0xE6AAEC")]
		private void InvokePostRenderBackground()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xE6B028", Offset = "0xE6B028", VA = "0xE6B028")]
		private void InvokePreRenderForeground()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xE6B098", Offset = "0xE6B098", VA = "0xE6B098")]
		private void InvokePostRenderForeground()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xE6C830", Offset = "0xE6C830", VA = "0xE6C830")]
		private void CreateBackgroundTexture()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xE6CA34", Offset = "0xE6CA34", VA = "0xE6CA34")]
		private void CreateForegroundTexture()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xE6CACC", Offset = "0xE6CACC", VA = "0xE6CACC")]
		private void CreateOptimizedTexture()
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xE6CB64", Offset = "0xE6CB64", VA = "0xE6CB64")]
		private void CreateComplexClipPlaneTexture()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xE68ECC", Offset = "0xE68ECC", VA = "0xE68ECC")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xE6A9E8", Offset = "0xE6A9E8", VA = "0xE6A9E8")]
		private void SendTextureToBridge(RenderTexture texture, TEXTURE_ID id)
		{
		}
	}
	[Token(Token = "0x20000FD")]
	internal static class SDKShaders
	{
		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int LIV_COLOR_MASK;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int LIV_TESSELLATION_PROPERTY;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int LIV_CLIP_PLANE_HEIGHT_MAP_PROPERTY;

		[Token(Token = "0x4000524")]
		public const string LIV_MR_FOREGROUND_KEYWORD = "LIV_MR_FOREGROUND";

		[Token(Token = "0x4000525")]
		public const string LIV_MR_BACKGROUND_KEYWORD = "LIV_MR_BACKGROUND";

		[Token(Token = "0x4000526")]
		public const string LIV_MR_KEYWORD = "LIV_MR";

		[Token(Token = "0x4000527")]
		public const string LIV_CLIP_PLANE_SIMPLE_SHADER = "Hidden/LIV_ClipPlaneSimple";

		[Token(Token = "0x4000528")]
		public const string LIV_CLIP_PLANE_SIMPLE_DEBUG_SHADER = "Hidden/LIV_ClipPlaneSimpleDebug";

		[Token(Token = "0x4000529")]
		public const string LIV_CLIP_PLANE_COMPLEX_SHADER = "Hidden/LIV_ClipPlaneComplex";

		[Token(Token = "0x400052A")]
		public const string LIV_CLIP_PLANE_COMPLEX_DEBUG_SHADER = "Hidden/LIV_ClipPlaneComplexDebug";

		[Token(Token = "0x400052B")]
		public const string LIV_WRITE_OPAQUE_TO_ALPHA_SHADER = "Hidden/LIV_WriteOpaqueToAlpha";

		[Token(Token = "0x400052C")]
		public const string LIV_COMBINE_ALPHA_SHADER = "Hidden/LIV_CombineAlpha";

		[Token(Token = "0x400052D")]
		public const string LIV_WRITE_SHADER = "Hidden/LIV_Write";

		[Token(Token = "0x400052E")]
		public const string LIV_FORCE_FORWARD_RENDERING_SHADER = "Hidden/LIV_ForceForwardRendering";

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xE6A8E0", Offset = "0xE6A8E0", VA = "0xE6A8E0")]
		public static void StartRendering()
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xE6ABA8", Offset = "0xE6ABA8", VA = "0xE6ABA8")]
		public static void StopRendering()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xE6AFDC", Offset = "0xE6AFDC", VA = "0xE6AFDC")]
		public static void StartForegroundRendering()
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xE6B108", Offset = "0xE6B108", VA = "0xE6B108")]
		public static void StopForegroundRendering()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xE6A92C", Offset = "0xE6A92C", VA = "0xE6A92C")]
		public static void StartBackgroundRendering()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xE6AB5C", Offset = "0xE6AB5C", VA = "0xE6AB5C")]
		public static void StopBackgroundRendering()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public struct SDKConstants
	{
		[Token(Token = "0x400052F")]
		public const string SDK_ID = "BCSWNL2DLRVAB03D9ZE8HLMGYMGFHY9T";

		[Token(Token = "0x4000530")]
		public const string SDK_VERSION = "1.5.4";

		[Token(Token = "0x4000531")]
		public const string ENGINE_NAME = "unity";
	}
	[Token(Token = "0x20000FF")]
	public enum PRIORITY : sbyte
	{
		[Token(Token = "0x4000533")]
		NONE = 0,
		[Token(Token = "0x4000534")]
		GAME = 63
	}
	[Token(Token = "0x2000100")]
	[Flags]
	public enum FEATURES : ulong
	{
		[Token(Token = "0x4000536")]
		NONE = 0uL,
		[Token(Token = "0x4000537")]
		BACKGROUND_RENDER = 1uL,
		[Token(Token = "0x4000538")]
		FOREGROUND_RENDER = 2uL,
		[Token(Token = "0x4000539")]
		COMPLEX_CLIP_PLANE = 4uL,
		[Token(Token = "0x400053A")]
		BACKGROUND_DEPTH_RENDER = 8uL,
		[Token(Token = "0x400053B")]
		OVERRIDE_POST_PROCESSING = 0x10uL,
		[Token(Token = "0x400053C")]
		FIX_FOREGROUND_ALPHA = 0x20uL,
		[Token(Token = "0x400053D")]
		GROUND_CLIP_PLANE = 0x40uL,
		[Token(Token = "0x400053E")]
		RELEASE_CONTROL = 0x8000uL,
		[Token(Token = "0x400053F")]
		OPTIMIZED_RENDER = 0x10000000uL,
		[Token(Token = "0x4000540")]
		INTERLACED_RENDER = 0x20000000uL,
		[Token(Token = "0x4000541")]
		DEBUG_CLIP_PLANE = 0x1000000000000uL
	}
	[Token(Token = "0x2000101")]
	public enum TEXTURE_ID : uint
	{
		[Token(Token = "0x4000543")]
		UNDEFINED = 0u,
		[Token(Token = "0x4000544")]
		BACKGROUND_COLOR_BUFFER_ID = 10u,
		[Token(Token = "0x4000545")]
		FOREGROUND_COLOR_BUFFER_ID = 20u,
		[Token(Token = "0x4000546")]
		OPTIMIZED_COLOR_BUFFER_ID = 30u
	}
	[Token(Token = "0x2000102")]
	public enum TEXTURE_TYPE : uint
	{
		[Token(Token = "0x4000548")]
		UNDEFINED,
		[Token(Token = "0x4000549")]
		COLOR_BUFFER
	}
	[Token(Token = "0x2000103")]
	public enum TEXTURE_FORMAT : uint
	{
		[Token(Token = "0x400054B")]
		UNDEFINED = 0u,
		[Token(Token = "0x400054C")]
		ARGB32 = 10u
	}
	[Token(Token = "0x2000104")]
	public enum TEXTURE_DEVICE : uint
	{
		[Token(Token = "0x400054E")]
		UNDEFINED,
		[Token(Token = "0x400054F")]
		RAW,
		[Token(Token = "0x4000550")]
		DIRECTX,
		[Token(Token = "0x4000551")]
		OPENGL,
		[Token(Token = "0x4000552")]
		VULKAN,
		[Token(Token = "0x4000553")]
		METAL
	}
	[Token(Token = "0x2000105")]
	public enum TEXTURE_COLOR_SPACE : uint
	{
		[Token(Token = "0x4000555")]
		UNDEFINED,
		[Token(Token = "0x4000556")]
		LINEAR,
		[Token(Token = "0x4000557")]
		SRGB
	}
	[Token(Token = "0x2000106")]
	public enum RENDERING_PIPELINE : uint
	{
		[Token(Token = "0x4000559")]
		UNDEFINED,
		[Token(Token = "0x400055A")]
		FORWARD,
		[Token(Token = "0x400055B")]
		DEFERRED,
		[Token(Token = "0x400055C")]
		VERTEX_LIT,
		[Token(Token = "0x400055D")]
		UNIVERSAL,
		[Token(Token = "0x400055E")]
		HIGH_DEFINITION
	}
	[Token(Token = "0x2000107")]
	public struct SDKResolution
	{
		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int width;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int height;

		[Token(Token = "0x1700018B")]
		public static SDKResolution zero
		{
			[Token(Token = "0x6000881")]
			[Address(RVA = "0xE66370", Offset = "0xE66370", VA = "0xE66370")]
			get
			{
				return default(SDKResolution);
			}
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xE6CCFC", Offset = "0xE6CCFC", VA = "0xE6CCFC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000108")]
	public struct SDKVector3
	{
		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x1700018C")]
		public static SDKVector3 zero
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0xE665E0", Offset = "0xE665E0", VA = "0xE665E0")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x1700018D")]
		public static SDKVector3 one
		{
			[Token(Token = "0x6000884")]
			[Address(RVA = "0xE6D3B4", Offset = "0xE6D3B4", VA = "0xE6D3B4")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x1700018E")]
		public static SDKVector3 forward
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0xE6D870", Offset = "0xE6D870", VA = "0xE6D870")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x1700018F")]
		public static SDKVector3 up
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0xE67818", Offset = "0xE67818", VA = "0xE67818")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x17000190")]
		public static SDKVector3 right
		{
			[Token(Token = "0x6000887")]
			[Address(RVA = "0xE6D880", Offset = "0xE6D880", VA = "0xE6D880")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xE6D5B0", Offset = "0xE6D5B0", VA = "0xE6D5B0")]
		public static implicit operator Vector3(SDKVector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xE67800", Offset = "0xE67800", VA = "0xE67800")]
		public static implicit operator SDKVector3(Vector3 v)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xE6D890", Offset = "0xE6D890", VA = "0xE6D890")]
		public static SDKVector3 operator +(SDKVector3 lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xE6D8A0", Offset = "0xE6D8A0", VA = "0xE6D8A0")]
		public static SDKVector3 operator -(SDKVector3 lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xE6D8B0", Offset = "0xE6D8B0", VA = "0xE6D8B0")]
		public static SDKVector3 operator *(SDKVector3 lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xE6D8C0", Offset = "0xE6D8C0", VA = "0xE6D8C0")]
		public static SDKVector3 operator *(SDKVector3 lhs, float rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xE6D8D0", Offset = "0xE6D8D0", VA = "0xE6D8D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000109")]
	public struct SDKQuaternion
	{
		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float w;

		[Token(Token = "0x17000191")]
		public static SDKQuaternion identity
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0xE665F0", Offset = "0xE665F0", VA = "0xE665F0")]
			get
			{
				return default(SDKQuaternion);
			}
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xE67D84", Offset = "0xE67D84", VA = "0xE67D84")]
		public static implicit operator Quaternion(SDKQuaternion v)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xE67DB4", Offset = "0xE67DB4", VA = "0xE67DB4")]
		public static implicit operator SDKQuaternion(Quaternion v)
		{
			return default(SDKQuaternion);
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xE67DB8", Offset = "0xE67DB8", VA = "0xE67DB8")]
		public static SDKQuaternion Euler(float pitch, float yaw, float roll)
		{
			return default(SDKQuaternion);
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xE67ECC", Offset = "0xE67ECC", VA = "0xE67ECC")]
		public static SDKQuaternion operator *(SDKQuaternion lhs, SDKQuaternion rhs)
		{
			return default(SDKQuaternion);
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xE67F40", Offset = "0xE67F40", VA = "0xE67F40")]
		public static SDKVector3 operator *(SDKQuaternion lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xE67FE4", Offset = "0xE67FE4", VA = "0xE67FE4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200010A")]
	public struct SDKMatrix4x4
	{
		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m00;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m01;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m02;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m03;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m10;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m11;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m12;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m13;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m20;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m21;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m22;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m23;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m30;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m31;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m32;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float m33;

		[Token(Token = "0x17000192")]
		public static SDKMatrix4x4 identity
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0xE663AC", Offset = "0xE663AC", VA = "0xE663AC")]
			get
			{
				return default(SDKMatrix4x4);
			}
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xE66D18", Offset = "0xE66D18", VA = "0xE66D18")]
		public static implicit operator Matrix4x4(SDKMatrix4x4 v)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xE66D5C", Offset = "0xE66D5C", VA = "0xE66D5C")]
		public static implicit operator SDKMatrix4x4(Matrix4x4 v)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xE66DA0", Offset = "0xE66DA0", VA = "0xE66DA0")]
		public static SDKMatrix4x4 Perspective(float vFov, float aspect, float zNear, float zFar)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xE66EA8", Offset = "0xE66EA8", VA = "0xE66EA8")]
		public static SDKMatrix4x4 operator *(SDKMatrix4x4 lhs, SDKMatrix4x4 rhs)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xE66F54", Offset = "0xE66F54", VA = "0xE66F54")]
		public static SDKVector3 operator *(SDKMatrix4x4 lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xE66FAC", Offset = "0xE66FAC", VA = "0xE66FAC")]
		public static SDKMatrix4x4 Translate(SDKVector3 value)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xE66FE8", Offset = "0xE66FE8", VA = "0xE66FE8")]
		public static SDKMatrix4x4 Rotate(SDKQuaternion value)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xE6707C", Offset = "0xE6707C", VA = "0xE6707C")]
		public static SDKMatrix4x4 Scale(SDKVector3 value)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xE670A8", Offset = "0xE670A8", VA = "0xE670A8")]
		public static SDKMatrix4x4 TRS(SDKVector3 translation, SDKQuaternion rotation, SDKVector3 scale)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xE67194", Offset = "0xE67194", VA = "0xE67194", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200010B")]
	public struct SDKPlane
	{
		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float distance;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SDKVector3 normal;

		[Token(Token = "0x17000193")]
		public static SDKPlane empty
		{
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0xE67804", Offset = "0xE67804", VA = "0xE67804")]
			get
			{
				return default(SDKPlane);
			}
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xE677A0", Offset = "0xE677A0", VA = "0xE677A0")]
		public static implicit operator SDKPlane(Plane v)
		{
			return default(SDKPlane);
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xE67828", Offset = "0xE67828", VA = "0xE67828", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200010C")]
	public struct SDKPriority
	{
		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public sbyte pose;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public sbyte clipPlane;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public sbyte stage;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public sbyte resolution;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public sbyte feature;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public sbyte nearFarAdjustment;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public sbyte groundPlane;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public sbyte reserved2;

		[Token(Token = "0x17000194")]
		public static SDKPriority empty
		{
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xE669F0", Offset = "0xE669F0", VA = "0xE669F0")]
			get
			{
				return default(SDKPriority);
			}
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xE67B20", Offset = "0xE67B20", VA = "0xE67B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200010D")]
	public struct SDKApplicationOutput
	{
		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FEATURES supportedFeatures;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string engineName;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string engineVersion;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string applicationName;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string applicationVersion;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string xrDeviceName;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string graphicsAPI;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string sdkID;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string sdkVersion;

		[Token(Token = "0x17000195")]
		public static SDKApplicationOutput empty
		{
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0xE64B88", Offset = "0xE64B88", VA = "0xE64B88")]
			get
			{
				return default(SDKApplicationOutput);
			}
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xE65150", Offset = "0xE65150", VA = "0xE65150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200010E")]
	public struct SDKInputFrame
	{
		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKPose pose;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SDKClipPlane clipPlane;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public SDKTransform stageTransform;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public FEATURES features;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public SDKClipPlane groundClipPlane;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public ulong frameid;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public ulong referenceframe;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public SDKPriority priority;

		[Token(Token = "0x17000196")]
		public static SDKInputFrame empty
		{
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0xE65B88", Offset = "0xE65B88", VA = "0xE65B88")]
			get
			{
				return default(SDKInputFrame);
			}
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xE669FC", Offset = "0xE669FC", VA = "0xE669FC")]
		public void ReleaseControl()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xE66A0C", Offset = "0xE66A0C", VA = "0xE66A0C")]
		public void ObtainControl()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xE66A20", Offset = "0xE66A20", VA = "0xE66A20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200010F")]
	public struct SDKOutputFrame
	{
		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RENDERING_PIPELINE renderingPipeline;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SDKTrackedSpace trackedSpace;

		[Token(Token = "0x17000197")]
		public static SDKOutputFrame empty
		{
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0xE67638", Offset = "0xE67638", VA = "0xE67638")]
			get
			{
				return default(SDKOutputFrame);
			}
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xE676F4", Offset = "0xE676F4", VA = "0xE676F4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000110")]
	public struct SDKTrackedSpace
	{
		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKVector3 trackedSpaceWorldPosition;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public SDKQuaternion trackedSpaceWorldRotation;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SDKVector3 trackedSpaceLocalScale;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SDKMatrix4x4 trackedSpaceLocalToWorldMatrix;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public SDKMatrix4x4 trackedSpaceWorldToLocalMatrix;

		[Token(Token = "0x17000198")]
		public static SDKTrackedSpace empty
		{
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0xE67698", Offset = "0xE67698", VA = "0xE67698")]
			get
			{
				return default(SDKTrackedSpace);
			}
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xE6D190", Offset = "0xE6D190", VA = "0xE6D190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000111")]
	public struct SDKTexture
	{
		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TEXTURE_ID id;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr texturePtr;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr SharedHandle;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TEXTURE_DEVICE device;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int dummy;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TEXTURE_TYPE type;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public TEXTURE_FORMAT format;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TEXTURE_COLOR_SPACE colorSpace;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int width;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int height;

		[Token(Token = "0x17000199")]
		public static SDKTexture empty
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0xE65E30", Offset = "0xE65E30", VA = "0xE65E30")]
			get
			{
				return default(SDKTexture);
			}
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xE6CE3C", Offset = "0xE6CE3C", VA = "0xE6CE3C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000112")]
	public struct SDKTransform
	{
		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKVector3 localPosition;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public SDKQuaternion localRotation;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SDKVector3 localScale;

		[Token(Token = "0x1700019A")]
		public static SDKTransform empty
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0xE669DC", Offset = "0xE669DC", VA = "0xE669DC")]
			get
			{
				return default(SDKTransform);
			}
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xE6D3C4", Offset = "0xE6D3C4", VA = "0xE6D3C4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000113")]
	public struct SDKClipPlane
	{
		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKMatrix4x4 transform;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int width;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int height;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float tesselation;

		[Token(Token = "0x1700019B")]
		public static SDKClipPlane empty
		{
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0xE66378", Offset = "0xE66378", VA = "0xE66378")]
			get
			{
				return default(SDKClipPlane);
			}
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xE663D8", Offset = "0xE663D8", VA = "0xE663D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000114")]
	public struct SDKControllerState
	{
		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKVector3 hmdposition;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public SDKQuaternion hmdrotation;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SDKVector3 calibrationcameraposition;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SDKQuaternion calibrationcamerarotation;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SDKVector3 cameraposition;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public SDKQuaternion camerarotation;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SDKVector3 leftposition;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SDKQuaternion leftrotation;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SDKVector3 rightposition;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public SDKQuaternion rightrotation;

		[Token(Token = "0x1700019C")]
		public static SDKControllerState empty
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0xE66594", Offset = "0xE66594", VA = "0xE66594")]
			get
			{
				return default(SDKControllerState);
			}
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xE66604", Offset = "0xE66604", VA = "0xE66604", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000115")]
	public struct SDKPose
	{
		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKMatrix4x4 projectionMatrix;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SDKVector3 localPosition;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public SDKQuaternion localRotation;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float verticalFieldOfView;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float nearClipPlane;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float farClipPlane;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int unused0;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int unused1;

		[Token(Token = "0x1700019D")]
		public static SDKPose empty
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0xE66960", Offset = "0xE66960", VA = "0xE66960")]
			get
			{
				return default(SDKPose);
			}
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xE678D4", Offset = "0xE678D4", VA = "0xE678D4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000116")]
	public static class SDKUtils
	{
		[Token(Token = "0x1700019E")]
		public static TEXTURE_COLOR_SPACE GetDefaultColorSpace
		{
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0xE6D4B4", Offset = "0xE6D4B4", VA = "0xE6D4B4")]
			get
			{
				return default(TEXTURE_COLOR_SPACE);
			}
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xE6B5A0", Offset = "0xE6B5A0", VA = "0xE6B5A0")]
		public static void CreateClipPlane(Mesh mesh, int resX, int resY, bool useQuads, float skirtLength)
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xE6D49C", Offset = "0xE6D49C", VA = "0xE6D49C")]
		public static RenderTextureReadWrite GetReadWriteFromColorSpace(TEXTURE_COLOR_SPACE colorSpace)
		{
			return default(RenderTextureReadWrite);
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xE6CC60", Offset = "0xE6CC60", VA = "0xE6CC60")]
		public static TEXTURE_COLOR_SPACE GetColorSpace(RenderTexture renderTexture)
		{
			return default(TEXTURE_COLOR_SPACE);
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xE6D4E4", Offset = "0xE6D4E4", VA = "0xE6D4E4")]
		public static RENDERING_PIPELINE GetRenderingPipeline(RenderingPath renderingPath)
		{
			return default(RENDERING_PIPELINE);
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xE6CBFC", Offset = "0xE6CBFC", VA = "0xE6CBFC")]
		public static TEXTURE_DEVICE GetDevice()
		{
			return default(TEXTURE_DEVICE);
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xE64D8C", Offset = "0xE64D8C", VA = "0xE64D8C")]
		public static bool ContainsFlag(ulong flags, ulong flag)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xE63DCC", Offset = "0xE63DCC", VA = "0xE63DCC")]
		public static ulong SetFlag(ulong flags, ulong flag, bool enabled)
		{
			return default(ulong);
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xE6D504", Offset = "0xE6D504", VA = "0xE6D504")]
		public static void GetCameraPositionAndRotation(SDKPose pose, Matrix4x4 originLocalToWorldMatrix, out Vector3 position, out Quaternion rotation)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xE6B28C", Offset = "0xE6B28C", VA = "0xE6B28C")]
		public static void CleanCameraBehaviours(Camera camera, string[] excludeBehaviours)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xE6A684", Offset = "0xE6A684", VA = "0xE6A684")]
		public static void SetCamera(Camera camera, Transform cameraTransform, SDKInputFrame inputFrame, Matrix4x4 originLocalToWorldMatrix, int layerMask)
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xE6C2C4", Offset = "0xE6C2C4", VA = "0xE6C2C4")]
		public static Quaternion RotateQuaternionByMatrix(Matrix4x4 matrix, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xE6D5E4", Offset = "0xE6D5E4", VA = "0xE6D5E4")]
		public static SDKTrackedSpace GetTrackedSpace(Transform transform)
		{
			return default(SDKTrackedSpace);
		}

		[Token(Token = "0x60008C7")]
		public static bool DestroyObject<T>(ref T reference) where T : UnityEngine.Object
		{
			return default(bool);
		}

		[Token(Token = "0x60008C8")]
		public static bool DisposeObject<T>(ref T reference) where T : IDisposable
		{
			return default(bool);
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xE6C8C8", Offset = "0xE6C8C8", VA = "0xE6C8C8")]
		public static bool CreateTexture(ref RenderTexture renderTexture, int width, int height, int depth, RenderTextureFormat format)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xE6BD24", Offset = "0xE6BD24", VA = "0xE6BD24")]
		public static void DestroyTexture(ref RenderTexture _renderTexture)
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xE68D84", Offset = "0xE68D84", VA = "0xE68D84")]
		public static void ApplyUserSpaceTransform(SDKRender render)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xE6A408", Offset = "0xE6A408", VA = "0xE6A408")]
		public static void CreateBridgeOutputFrame(SDKRender render)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xE683C4", Offset = "0xE683C4", VA = "0xE683C4")]
		public static bool FeatureEnabled(FEATURES features, FEATURES feature)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xE6AC10", Offset = "0xE6AC10", VA = "0xE6AC10")]
		public static void DisableStandardAssets(Camera cameraInstance, ref MonoBehaviour[] behaviours, ref bool[] wasBehaviourEnabled)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xE6B154", Offset = "0xE6B154", VA = "0xE6B154")]
		public static void RestoreStandardAssets(ref MonoBehaviour[] behaviours, ref bool[] wasBehaviourEnabled)
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xE6AD78", Offset = "0xE6AD78", VA = "0xE6AD78")]
		public static void ForceForwardRendering(Camera cameraInstance, Mesh clipPlaneMesh, Material forceForwardRenderingMaterial)
		{
		}
	}
}
namespace Battlehub.MeshTools
{
	[Token(Token = "0x2000117")]
	public class MeshTransform
	{
		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh Mesh;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Matrix4x4 Transform;

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xEFB99C", Offset = "0xEFB99C", VA = "0xEFB99C")]
		public MeshTransform(Mesh mesh, Matrix4x4 transform)
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class CombineResult
	{
		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject GameObject;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mesh Mesh;

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xEFB964", Offset = "0xEFB964", VA = "0xEFB964")]
		public CombineResult(GameObject gameObject, Mesh mesh)
		{
		}
	}
	[Token(Token = "0x2000119")]
	public static class MeshUtils
	{
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xEFB9EC", Offset = "0xEFB9EC", VA = "0xEFB9EC")]
		public static CombineResult Combine(GameObject[] gameObjects, [Optional] GameObject target)
		{
			return null;
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xEFD644", Offset = "0xEFD644", VA = "0xEFD644")]
		private static Mesh RemoveRotation(Mesh mesh, Matrix4x4 targetRotationMatrix, bool merge)
		{
			return null;
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xEFCEB8", Offset = "0xEFCEB8", VA = "0xEFCEB8")]
		private static bool BuildCombineInstance(Matrix4x4 targetToLocal, List<MeshFilter> allMeshFilters, List<SkinnedMeshRenderer> allSkinned, out CombineInstance[] combineInstances, out Material[] materials)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xEFD960", Offset = "0xEFD960", VA = "0xEFD960")]
		private static void PopulateMeshGroups(Dictionary<Material, List<MeshTransform>> meshGroups, GameObject go, Mesh mesh)
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xEFC6A8", Offset = "0xEFC6A8", VA = "0xEFC6A8")]
		private static void DestroyChildren(GameObject gameObject)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xEFCC7C", Offset = "0xEFCC7C", VA = "0xEFCC7C")]
		private static List<Mesh> GetColliderMeshes(GameObject obj)
		{
			return null;
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xEFDBE0", Offset = "0xEFDBE0", VA = "0xEFDBE0")]
		public static Vector3 CenterOfMass(GameObject gameObject)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xEFDC88", Offset = "0xEFDC88", VA = "0xEFDC88")]
		public static Vector3 CenterOfMass(Mesh mesh)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xEFDEC4", Offset = "0xEFDEC4", VA = "0xEFDEC4")]
		public static Vector3 BoundsCenter(GameObject gameObject)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xEFDF6C", Offset = "0xEFDF6C", VA = "0xEFDF6C")]
		public static Vector3 BoundsCenter(Mesh mesh)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xEFDFD4", Offset = "0xEFDFD4", VA = "0xEFDFD4")]
		public static Mesh SetPivot(Mesh mesh, Vector3 position)
		{
			return null;
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xEFE360", Offset = "0xEFE360", VA = "0xEFE360")]
		public static Mesh SetPivot(Transform transform, Mesh mesh, Vector3 position)
		{
			return null;
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xEFE0D0", Offset = "0xEFE0D0", VA = "0xEFE0D0")]
		public static Mesh EditPivot(Mesh mesh, Vector3 offset)
		{
			return null;
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xEFE4B0", Offset = "0xEFE4B0", VA = "0xEFE4B0")]
		public static Mesh EditPivot(Transform transform, Vector3 worldOffset, Collider[] colliders)
		{
			return null;
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xEFD800", Offset = "0xEFD800", VA = "0xEFD800")]
		public static Mesh[] Separate(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xEFE854", Offset = "0xEFE854", VA = "0xEFE854")]
		public static Mesh ExtractSubmesh(Mesh mesh, int submeshIndex)
		{
			return null;
		}
	}
	[Token(Token = "0x200011A")]
	[ExecuteInEditMode]
	public class Pivot : MonoBehaviour
	{
		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Transform Target;

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xC100B4", Offset = "0xC100B4", VA = "0xC100B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xC1021C", Offset = "0xC1021C", VA = "0xC1021C")]
		public Pivot()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[ExecuteInEditMode]
	public class PivotDesignTime : MonoBehaviour
	{
		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 m_prevPosition;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 m_prevTargetPosition;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Pivot m_origin;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Collider[] m_colliders;

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xC10224", Offset = "0xC10224", VA = "0xC10224")]
		private void Start()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xC1032C", Offset = "0xC1032C", VA = "0xC1032C")]
		public void ToBoundsCenter()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xC10384", Offset = "0xC10384", VA = "0xC10384")]
		public void ToCenterOffMass()
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xC103DC", Offset = "0xC103DC", VA = "0xC103DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xC107F0", Offset = "0xC107F0", VA = "0xC107F0")]
		public PivotDesignTime()
		{
		}
	}
}
namespace Battlehub.Integration
{
	[Token(Token = "0x200011C")]
	public class IntegrationArgs
	{
		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject GameObject;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mesh Mesh;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Cancel;

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xEFAAAC", Offset = "0xEFAAAC", VA = "0xEFAAAC")]
		public IntegrationArgs()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xEFAAB4", Offset = "0xEFAAB4", VA = "0xEFAAB4")]
		public IntegrationArgs(GameObject gameObject)
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xEFAAE0", Offset = "0xEFAAE0", VA = "0xEFAAE0")]
		public IntegrationArgs(GameObject gameObject, Mesh mesh)
		{
		}
	}
	[Token(Token = "0x200011D")]
	public delegate void IntegrationHandler(IntegrationArgs args);
	[Token(Token = "0x200011E")]
	public static class MeshCombinerIntegration
	{
		[Token(Token = "0x14000004")]
		public static event IntegrationHandler Combined
		{
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0xEFAEEC", Offset = "0xEFAEEC", VA = "0xEFAEEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C635C", Offset = "0x6C635C")]
			add
			{
			}
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0xEFAFA0", Offset = "0xEFAFA0", VA = "0xEFAFA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C636C", Offset = "0x6C636C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public static event IntegrationHandler BeginEditPivot
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0xEFB054", Offset = "0xEFB054", VA = "0xEFB054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C637C", Offset = "0x6C637C")]
			add
			{
			}
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0xEFB10C", Offset = "0xEFB10C", VA = "0xEFB10C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C638C", Offset = "0x6C638C")]
			remove
			{
			}
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0xEFB1C4", Offset = "0xEFB1C4", VA = "0xEFB1C4")]
		public static void RaiseCombined(GameObject go, Mesh mesh)
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0xEFB260", Offset = "0xEFB260", VA = "0xEFB260")]
		public static bool RaiseBeginEditPivot(GameObject go, Mesh mesh)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200011F")]
	public static class MeshDeformerIntegration
	{
		[Token(Token = "0x14000006")]
		public static event IntegrationHandler BeforeDeform
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0xEFB318", Offset = "0xEFB318", VA = "0xEFB318")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C639C", Offset = "0x6C639C")]
			add
			{
			}
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0xEFB3CC", Offset = "0xEFB3CC", VA = "0xEFB3CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C63AC", Offset = "0x6C63AC")]
			remove
			{
			}
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xEFB480", Offset = "0xEFB480", VA = "0xEFB480")]
		public static bool RaiseBeforeDeform(GameObject gameObject, Mesh mesh)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000120")]
	public static class WiresIntegration
	{
		[Token(Token = "0x14000007")]
		public static event IntegrationHandler WireParamsChanged
		{
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0xEFB538", Offset = "0xEFB538", VA = "0xEFB538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C63BC", Offset = "0x6C63BC")]
			add
			{
			}
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0xEFB5EC", Offset = "0xEFB5EC", VA = "0xEFB5EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C63CC", Offset = "0x6C63CC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public static event IntegrationHandler BeforeWireCreated
		{
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0xEFB6A0", Offset = "0xEFB6A0", VA = "0xEFB6A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C63DC", Offset = "0x6C63DC")]
			add
			{
			}
			[Token(Token = "0x60008FD")]
			[Address(RVA = "0xEFB758", Offset = "0xEFB758", VA = "0xEFB758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C63EC", Offset = "0x6C63EC")]
			remove
			{
			}
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xEFB810", Offset = "0xEFB810", VA = "0xEFB810")]
		public static bool RaiseBeforeWireCreated(GameObject gameObject, Mesh mesh)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xEFB8C8", Offset = "0xEFB8C8", VA = "0xEFB8C8")]
		public static void RaiseWireParamsChanged(GameObject gameObject, Mesh mesh)
		{
		}
	}
}
