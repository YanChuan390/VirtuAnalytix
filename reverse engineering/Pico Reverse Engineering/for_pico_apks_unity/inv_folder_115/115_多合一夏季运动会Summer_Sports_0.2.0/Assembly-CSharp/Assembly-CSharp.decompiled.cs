using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BrainFailProductions.PolyFew.AsImpL;
using BrainFailProductions.PolyFewRuntime;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using Photon.Chat;
using Photon.Pun;
using Photon.Realtime;
using Photon.Voice.PUN;
using Photon.Voice.Unity;
using Photon.Voice.Unity.UtilityScripts;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityMeshSimplifier;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class GetReference : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000003")]
	private class GearShifts
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int GearShiftNumber;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float ShiftAt;

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xCAA4A4", Offset = "0xCAA4A4", VA = "0xCAA4A4")]
		public GearShifts()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Rigidbody rb;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float CurrentSpeedMps;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float CurrentSpeedKmph;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int currentGear;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GearShifts[] gearShifts;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xCAA264", Offset = "0xCAA264", VA = "0xCAA264")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xCAA2B4", Offset = "0xCAA2B4", VA = "0xCAA2B4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xCAA304", Offset = "0xCAA304", VA = "0xCAA304")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xCAA31C", Offset = "0xCAA31C", VA = "0xCAA31C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xCAA49C", Offset = "0xCAA49C", VA = "0xCAA49C")]
	public GetReference()
	{
	}
}
[Token(Token = "0x2000004")]
public class GravityCustom : MonoBehaviour
{
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Rigidbody rb;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float gravity;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xCAA4AC", Offset = "0xCAA4AC", VA = "0xCAA4AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xCAA50C", Offset = "0xCAA50C", VA = "0xCAA50C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xCAA5B4", Offset = "0xCAA5B4", VA = "0xCAA5B4")]
	public GravityCustom()
	{
	}
}
[Token(Token = "0x2000005")]
public static class ResonanceAudio
{
	[StructLayout(0)]
	[Token(Token = "0x2000006")]
	private class RoomProperties
	{
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float positionX;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float positionY;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float positionZ;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rotationX;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationY;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationZ;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rotationW;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float dimensionsX;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float dimensionsY;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float dimensionsZ;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ResonanceAudioRoomManager.SurfaceMaterial materialLeft;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public ResonanceAudioRoomManager.SurfaceMaterial materialRight;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ResonanceAudioRoomManager.SurfaceMaterial materialBottom;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public ResonanceAudioRoomManager.SurfaceMaterial materialTop;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ResonanceAudioRoomManager.SurfaceMaterial materialFront;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public ResonanceAudioRoomManager.SurfaceMaterial materialBack;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float reflectionScalar;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float reverbGain;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float reverbTime;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float reverbBrightness;

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xCABA40", Offset = "0xCABA40", VA = "0xCABA40")]
		public RoomProperties()
		{
		}
	}

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Transform listenerTransform;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly Color listenerDirectivityColor;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly Color sourceDirectivityColor;

	[Token(Token = "0x400000D")]
	public const float distanceEpsilon = 0.01f;

	[Token(Token = "0x400000E")]
	public const float maxDistanceLimit = 1000000f;

	[Token(Token = "0x400000F")]
	public const float minDistanceLimit = 990099f;

	[Token(Token = "0x4000010")]
	public const float maxGainDb = 24f;

	[Token(Token = "0x4000011")]
	public const float minGainDb = -24f;

	[Token(Token = "0x4000012")]
	public const float maxReverbBrightness = 1f;

	[Token(Token = "0x4000013")]
	public const float minReverbBrightness = -1f;

	[Token(Token = "0x4000014")]
	public const float maxReverbTime = 10f;

	[Token(Token = "0x4000015")]
	public const float maxReflectivity = 2f;

	[Token(Token = "0x4000016")]
	public const int maxNumOcclusionHits = 12;

	[Token(Token = "0x4000017")]
	public const float occlusionDetectionInterval = 0.2f;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly Matrix4x4 flipZ;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static RaycastHit[] occlusionHits;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static int occlusionMaskValue;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static float[] roomPosition;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static RoomProperties roomProperties;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr roomPropertiesPtr;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static Matrix4x4 transformMatrix;

	[Token(Token = "0x400001F")]
	private const string pluginName = "audiopluginresonanceaudio";

	[Token(Token = "0x17000001")]
	public static Transform ListenerTransform
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0xCAA5C4", Offset = "0xCAA5C4", VA = "0xCAA5C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xCAA6EC", Offset = "0xCAA6EC", VA = "0xCAA6EC")]
	public static void UpdateAudioListener(ResonanceAudioListener listener)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xCAA88C", Offset = "0xCAA88C", VA = "0xCAA88C")]
	public static void DisableRoomEffects()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xCAAA1C", Offset = "0xCAAA1C", VA = "0xCAAA1C")]
	public static void UpdateRoom(ResonanceAudioRoom room)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xCAAD34", Offset = "0xCAAD34", VA = "0xCAAD34")]
	public static void UpdateReverbProbe(ResonanceAudioReverbProbe reverbPobe)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xCAAFEC", Offset = "0xCAAFEC", VA = "0xCAAFEC")]
	public static bool StartRecording()
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xCAAFF4", Offset = "0xCAAFF4", VA = "0xCAAFF4")]
	public static bool StopRecordingAndSaveToFile(string filePath, bool seamless)
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xCAAFFC", Offset = "0xCAAFFC", VA = "0xCAAFFC")]
	public static void InitializeReverbComputer(float[] vertices, int[] triangles, int[] materialIndices, float scatteringCoefficient)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xCAB000", Offset = "0xCAB000", VA = "0xCAB000")]
	public static bool ComputeRt60sAndProxyRoom(ResonanceAudioReverbProbe reverbProbe, int totalNumPaths, int numPathsPerBatch, int maxDepth, float energyThreshold, float listenerSphereRadius)
	{
		return default(bool);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xCAB008", Offset = "0xCAB008", VA = "0xCAB008")]
	public static float ComputeOcclusion(Transform sourceTransform)
	{
		return default(float);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xCAA784", Offset = "0xCAA784", VA = "0xCAA784")]
	public static float ConvertAmplitudeFromDb(float db)
	{
		return default(float);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xCAB2D4", Offset = "0xCAB2D4", VA = "0xCAB2D4")]
	public static Vector2[] Generate2dPolarPattern(float alpha, float order, int resolution)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xCAB3EC", Offset = "0xCAB3EC", VA = "0xCAB3EC")]
	private static void ConvertAudioTransformFromUnity(ref Vector3 position, ref Quaternion rotation)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xCAB64C", Offset = "0xCAB64C", VA = "0xCAB64C")]
	private static void SetProxyRoomProperties(ResonanceAudioReverbProbe reverbProbe, RoomProperties proxyRoomProperties)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xCAABFC", Offset = "0xCAABFC", VA = "0xCAABFC")]
	private static void UpdateRoomProperties(ResonanceAudioRoom room)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xCAAF14", Offset = "0xCAAF14", VA = "0xCAAF14")]
	private static void UpdateRoomProperties(ResonanceAudioReverbProbe reverbProbe)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xCAB690", Offset = "0xCAB690", VA = "0xCAB690")]
	private static void FillGeometryOfRoomProperties(Vector3 position, Quaternion rotation, Vector3 scale)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xCAB744", Offset = "0xCAB744", VA = "0xCAB744")]
	private static void FillWallMaterialsOfRoomProperties(ResonanceAudioRoomManager.SurfaceMaterial leftWall, ResonanceAudioRoomManager.SurfaceMaterial rightWall, ResonanceAudioRoomManager.SurfaceMaterial floor, ResonanceAudioRoomManager.SurfaceMaterial ceiling, ResonanceAudioRoomManager.SurfaceMaterial frontWall, ResonanceAudioRoomManager.SurfaceMaterial backWall)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xCAB7E0", Offset = "0xCAB7E0", VA = "0xCAB7E0")]
	private static void FillModifiersOfRoomProperties(float reverbGainDb, float reverbTime, float reverbBrightness, float reflectivity)
	{
	}

	[PreserveSig]
	[Token(Token = "0x600001D")]
	[Address(RVA = "0xCAA798", Offset = "0xCAA798", VA = "0xCAA798")]
	private static extern void SetListenerGain(float gain);

	[PreserveSig]
	[Token(Token = "0x600001E")]
	[Address(RVA = "0xCAA810", Offset = "0xCAA810", VA = "0xCAA810")]
	private static extern void SetListenerStereoSpeakerMode(bool enableStereoSpeakerMode);

	[PreserveSig]
	[Token(Token = "0x600001F")]
	[Address(RVA = "0xCAA990", Offset = "0xCAA990", VA = "0xCAA990")]
	private static extern void SetRoomProperties(IntPtr roomProperties, float[] rt60s);
}
[Token(Token = "0x2000007")]
public class ResonanceAudioAcousticMesh
{
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isIncludedByObjectFiltering;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ResonanceAudioRoomManager.SurfaceMaterial[] surfaceMaterialsFromSubMesh;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RangeInt[] triangleRangesFromSubMesh;

	[Token(Token = "0x4000039")]
	private const int unityMaxNumVerticesPerMesh = 65000;

	[Token(Token = "0x400003A")]
	private const int maxNumSubMeshes = 256;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material visualizationMaterial;

	[Token(Token = "0x17000002")]
	public Mesh mesh
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0xCABA48", Offset = "0xCABA48", VA = "0xCABA48")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0xCABA50", Offset = "0xCABA50", VA = "0xCABA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public GameObject sourceObject
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0xCABA58", Offset = "0xCABA58", VA = "0xCABA58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0xCABA60", Offset = "0xCABA60", VA = "0xCABA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xCABA68", Offset = "0xCABA68", VA = "0xCABA68")]
	public static ResonanceAudioAcousticMesh GenerateFromMeshFilter(MeshFilter meshFilter, Shader surfaceMaterialShader)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xCAC308", Offset = "0xCAC308", VA = "0xCAC308")]
	public static ResonanceAudioAcousticMesh GenerateFromTerrain(Terrain terrain, Shader surfaceMaterialShader)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xCAC8F4", Offset = "0xCAC8F4", VA = "0xCAC8F4")]
	public int[] GetSurfaceMaterialIndicesFromTriangle()
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xCACA34", Offset = "0xCACA34", VA = "0xCACA34")]
	public void SetSurfaceMaterialToAllSubMeshes(ResonanceAudioRoomManager.SurfaceMaterial surfaceMaterial)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xCACB94", Offset = "0xCACB94", VA = "0xCACB94")]
	public void SetSurfaceMaterialToSubMesh(ResonanceAudioRoomManager.SurfaceMaterial surfaceMaterial, int subMeshIndex)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xCACDD4", Offset = "0xCACDD4", VA = "0xCACDD4")]
	public bool Render()
	{
		return default(bool);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xCACEF4", Offset = "0xCACEF4", VA = "0xCACEF4")]
	public bool IsIncluded()
	{
		return default(bool);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xCACFAC", Offset = "0xCACFAC", VA = "0xCACFAC")]
	public bool IsSubMeshTriangular(int subMeshIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xCABC98", Offset = "0xCABC98", VA = "0xCABC98")]
	private static int CountTriangleIndices(Mesh sourceMesh)
	{
		return default(int);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xCAC564", Offset = "0xCAC564", VA = "0xCAC564")]
	private static void SubSampleHeightMap(int originalM, int originalN, out int m, out int n, out int subSampleStep, out int subSampledNumTriangleIndices)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xCABD24", Offset = "0xCABD24", VA = "0xCABD24")]
	private void InitializeMesh(int numTriangleIndices, int numVertices, out int[] triangles, out Vector3[] vertices)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xCAC1AC", Offset = "0xCAC1AC", VA = "0xCAC1AC")]
	private void InitializeSubMeshMaterials()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xCAC258", Offset = "0xCAC258", VA = "0xCAC258")]
	private void InitializeVisualizationMaterial(Shader surfaceMaterialShader)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xCABE58", Offset = "0xCABE58", VA = "0xCABE58")]
	private void FillVerticesAndTrianglesFromMesh(Mesh sourceMesh, Transform sourceObjectTransform, ref Vector3[] vertices, ref int[] triangles)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xCAC610", Offset = "0xCAC610", VA = "0xCAC610")]
	private void FillTrianglesAndVerticesFromHeightMap(Vector3 terrainPosition, Vector3 terrainSize, float[,] heightMap, int m, int n, int subSampleStep, ref int[] triangles, ref Vector3[] vertices)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xCACFE4", Offset = "0xCACFE4", VA = "0xCACFE4")]
	private void SetSubMeshEnds()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xCACA84", Offset = "0xCACA84", VA = "0xCACA84")]
	private void SetSubMeshSurfaceMaterials()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xCABD1C", Offset = "0xCABD1C", VA = "0xCABD1C")]
	public ResonanceAudioAcousticMesh()
	{
	}
}
[Token(Token = "0x2000008")]
[ExecuteInEditMode]
[RequireComponent(typeof(AudioListener))]
[AddComponentMenu("ResonanceAudio/ResonanceAudioListener")]
public class ResonanceAudioListener : MonoBehaviour
{
	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Sets the global gain for all spatialized audio sources. Can be used to adjust the overall output volume.")]
	public float globalGainDb;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("Sets the global layer mask for occlusion detection.")]
	public LayerMask occlusionMask;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Disables HRTF-based rendering and force stereo-panning only rendering for all spatialized audio sources. This mode is recommended only when the audio output is routed to a stereo loudspeaker configuration.")]
	public bool stereoSpeakerModeEnabled;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	[Tooltip("Sets whether the recorded soundfield clip should be saved as a seamless loop.")]
	public bool recorderSeamless;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Specify by tag which spatialized audio sources will be recorded. Choose \"Untagged\" to include all enabled spatialized audio sources in the scene.")]
	public string recorderSourceTag;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[SerializeField]
	private bool recorderFoldout;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<AudioSource> recorderTaggedSources;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private double recorderStartTime;

	[Token(Token = "0x17000004")]
	public bool IsRecording
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0xCAD34C", Offset = "0xCAD34C", VA = "0xCAD34C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000039")]
		[Address(RVA = "0xCAD354", Offset = "0xCAD354", VA = "0xCAD354")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xCAD360", Offset = "0xCAD360", VA = "0xCAD360")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xCAD3F4", Offset = "0xCAD3F4", VA = "0xCAD3F4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xCAD614", Offset = "0xCAD614", VA = "0xCAD614")]
	private void Update()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xCAD890", Offset = "0xCAD890", VA = "0xCAD890")]
	public double GetCurrentRecordDuration()
	{
		return default(double);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xCAD8C0", Offset = "0xCAD8C0", VA = "0xCAD8C0")]
	public void StartSoundfieldRecorder()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xCAD488", Offset = "0xCAD488", VA = "0xCAD488")]
	public void StopSoundfieldRecorder(string filePath)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xCAD698", Offset = "0xCAD698", VA = "0xCAD698")]
	private void UpdateTaggedSources()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xCADAE0", Offset = "0xCADAE0", VA = "0xCADAE0")]
	public ResonanceAudioListener()
	{
	}
}
[Token(Token = "0x2000009")]
[CreateAssetMenu(fileName = "New Material Map", menuName = "ResonanceAudio/Material Map", order = 1000)]
public class ResonanceAudioMaterialMap : ScriptableObject
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Color[] surfaceMaterialColors;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ResonanceAudioRoomManager.SurfaceMaterialDictionary surfaceMaterialFromGuid;

	[Token(Token = "0x4000047")]
	private const ResonanceAudioRoomManager.SurfaceMaterial defaultSurfaceMaterial = ResonanceAudioRoomManager.SurfaceMaterial.Transparent;

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xCADB40", Offset = "0xCADB40", VA = "0xCADB40")]
	public List<string> GuidList()
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xCADBAC", Offset = "0xCADBAC", VA = "0xCADBAC")]
	public ResonanceAudioRoomManager.SurfaceMaterial GetMaterialFromGuid(string guid)
	{
		return default(ResonanceAudioRoomManager.SurfaceMaterial);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xCADC04", Offset = "0xCADC04", VA = "0xCADC04")]
	public void AddDefaultMaterialIfGuidUnmapped(string guid)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xCADC98", Offset = "0xCADC98", VA = "0xCADC98")]
	public ResonanceAudioMaterialMap()
	{
	}
}
[Token(Token = "0x200000A")]
public class ResonanceAudioMaterialMapper : ScriptableObject
{
	[Token(Token = "0x200000B")]
	private class UnityMaterialAcousticMeshData
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<ResonanceAudioAcousticMesh> acousticMeshes;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> subMeshIndices;

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xCAEEC0", Offset = "0xCAEEC0", VA = "0xCAEEC0")]
		public UnityMaterialAcousticMeshData()
		{
		}
	}

	[Token(Token = "0x200000C")]
	private class TerrainAcousticMeshData
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<ResonanceAudioAcousticMesh> acousticMeshes;

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xCAEF84", Offset = "0xCAEF84", VA = "0xCAEF84")]
		public TerrainAcousticMeshData()
		{
		}
	}

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ResonanceAudioMaterialMap materialMap;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<string, UnityMaterialAcousticMeshData> unityMaterialAcousticMeshDataFromGuid;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<string, TerrainAcousticMeshData> terrainAcousticMeshDataFromGuid;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private LayerMask reverbLayerMask;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool includeNonStaticGameObjects;

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xCADEE0", Offset = "0xCADEE0", VA = "0xCADEE0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xCADF98", Offset = "0xCADF98", VA = "0xCADF98")]
	public void ApplyMaterialMapping(MeshRenderer[] meshRenderers, List<string>[] guidsForMeshRenderers, Terrain[] activeTerrains, string[] guidsForTerrains, Shader surfaceMaterialShader)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xCAE98C", Offset = "0xCAE98C", VA = "0xCAE98C")]
	public void RenderAcousticMeshes()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xCAEA24", Offset = "0xCAEA24", VA = "0xCAEA24")]
	public List<ResonanceAudioAcousticMesh> GetIncludedAcousticMeshes()
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xCAE000", Offset = "0xCAE000", VA = "0xCAE000")]
	private void BuildUnityMaterialData(MeshRenderer[] meshRenderers, List<string>[] guidsForMeshRenderers, Shader surfaceMaterialShader)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xCAE3B0", Offset = "0xCAE3B0", VA = "0xCAE3B0")]
	private void BuildTerrainData(Terrain[] activeTerrains, string[] guidsForTerrains, Shader surfaceMaterialShader)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xCAE608", Offset = "0xCAE608", VA = "0xCAE608")]
	private void ApplyMaterialMappingToGuids(List<string> guids)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xCAF004", Offset = "0xCAF004", VA = "0xCAF004")]
	private void ApplySurfaceMaterialToGameObjects(ResonanceAudioRoomManager.SurfaceMaterial surfaceMaterial, string guid)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xCAF318", Offset = "0xCAF318", VA = "0xCAF318")]
	private void ApplySurfaceMaterialToTerrains(ResonanceAudioRoomManager.SurfaceMaterial surfaceMaterial, string guid)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xCAE744", Offset = "0xCAE744", VA = "0xCAE744")]
	private void ApplyObjectFiltering()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xCAF408", Offset = "0xCAF408", VA = "0xCAF408")]
	private bool IsIncludedByObjectFiltering(GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xCAF480", Offset = "0xCAF480", VA = "0xCAF480")]
	public ResonanceAudioMaterialMapper()
	{
	}
}
[Token(Token = "0x200000D")]
[AddComponentMenu("")]
[ExecuteInEditMode]
public class ResonanceAudioMaterialMapperUpdater : MonoBehaviour
{
	[Token(Token = "0x200000E")]
	public delegate void RefreshMaterialMapperDelegate();

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RefreshMaterialMapperDelegate RefreshMaterialMapper;

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xCAF4B0", Offset = "0xCAF4B0", VA = "0xCAF4B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xCAF4F4", Offset = "0xCAF4F4", VA = "0xCAF4F4")]
	public ResonanceAudioMaterialMapperUpdater()
	{
	}
}
[Token(Token = "0x200000F")]
[ExecuteInEditMode]
[AddComponentMenu("ResonanceAudio/ResonanceAudioReverbProbe")]
public class ResonanceAudioReverbProbe : MonoBehaviour
{
	[Token(Token = "0x2000010")]
	public enum RegionShape
	{
		[Token(Token = "0x4000063")]
		Sphere,
		[Token(Token = "0x4000064")]
		Box
	}

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Time required in seconds for the reverb to decay by 60 dB for each frequency band.")]
	public float[] rt60s;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Adjusts the reverb gain in the room.")]
	public float reverbGainDb;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Adjusts the balance between high and low frequencies in the reverb. Increasing this value will increase high frequencies in the reverb, while decreasing the low frequencies respectively.")]
	public float reverbBrightness;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Adjusts the overall duration of the reverb by a positive scaling factor.")]
	public float reverbTime;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("Shape of the region of application of this reverb.")]
	public RegionShape regionShape;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Sets the dimensions of a box-shaped region of application in meters relative to the scale of the game object.")]
	public Vector3 boxRegionSize;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[Tooltip("Sets the radius of a spherical region of application in meters relative to the scale of the game object.")]
	public float sphereRegionRadius;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("Applies this reverb only when the center of the probe is visible from the listener. The visibility check will be done using physics raycast with respect to the Occlusion Mask selection in the ResonanceAudioListener component.")]
	public bool onlyApplyWhenVisible;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 proxyRoomPosition;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Quaternion proxyRoomRotation;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 proxyRoomSize;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public ResonanceAudioRoomManager.SurfaceMaterial proxyRoomLeftWall;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ResonanceAudioRoomManager.SurfaceMaterial proxyRoomRightWall;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public ResonanceAudioRoomManager.SurfaceMaterial proxyRoomFloor;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ResonanceAudioRoomManager.SurfaceMaterial proxyRoomCeiling;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public ResonanceAudioRoomManager.SurfaceMaterial proxyRoomBackWall;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ResonanceAudioRoomManager.SurfaceMaterial proxyRoomFrontWall;

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xCAF5F8", Offset = "0xCAF5F8", VA = "0xCAF5F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xCAF6B0", Offset = "0xCAF6B0", VA = "0xCAF6B0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xCAF760", Offset = "0xCAF760", VA = "0xCAF760")]
	private void Update()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xCAF7B4", Offset = "0xCAF7B4", VA = "0xCAF7B4")]
	public float GetScaledSphericalRegionRadius()
	{
		return default(float);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xCAF7F4", Offset = "0xCAF7F4", VA = "0xCAF7F4")]
	public Vector3 GetScaledBoxRegionSize()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xCAF830", Offset = "0xCAF830", VA = "0xCAF830")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xCAF96C", Offset = "0xCAF96C", VA = "0xCAF96C")]
	public ResonanceAudioReverbProbe()
	{
	}
}
[Token(Token = "0x2000011")]
[AddComponentMenu("ResonanceAudio/ResonanceAudioRoom")]
public class ResonanceAudioRoom : MonoBehaviour
{
	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Left wall surface material used to calculate the acoustic properties of the room.")]
	public ResonanceAudioRoomManager.SurfaceMaterial leftWall;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("Right wall surface material used to calculate the acoustic properties of the room.")]
	public ResonanceAudioRoomManager.SurfaceMaterial rightWall;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Floor surface material used to calculate the acoustic properties of the room.")]
	public ResonanceAudioRoomManager.SurfaceMaterial floor;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Ceiling surface material used to calculate the acoustic properties of the room.")]
	public ResonanceAudioRoomManager.SurfaceMaterial ceiling;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Back wall surface material used to calculate the acoustic properties of the room.")]
	public ResonanceAudioRoomManager.SurfaceMaterial backWall;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("Front wall surface material used to calculate the acoustic properties of the room.")]
	public ResonanceAudioRoomManager.SurfaceMaterial frontWall;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Adjusts what proportion of the direct sound is reflected back by each surface, after an appropriate delay. Reverberation is unaffected by this setting.")]
	public float reflectivity;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("Adjusts the reverb gain in the room.")]
	public float reverbGainDb;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Adjusts the balance between high and low frequencies in the reverb. Increasing this value will increase high frequencies in the reverb, while decreasing the low frequencies respectively.")]
	public float reverbBrightness;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[Tooltip("Adjusts the overall duration of the reverb by a positive scaling factor.")]
	public float reverbTime;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("Sets the room dimensions in meters relative to the scale of the game object.")]
	public Vector3 size;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xCAFAC0", Offset = "0xCAFAC0", VA = "0xCAFAC0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xCAFB78", Offset = "0xCAFB78", VA = "0xCAFB78")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xCAFC28", Offset = "0xCAFC28", VA = "0xCAFC28")]
	private void Update()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xCAFC7C", Offset = "0xCAFC7C", VA = "0xCAFC7C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xCAFD48", Offset = "0xCAFD48", VA = "0xCAFD48")]
	public ResonanceAudioRoom()
	{
	}
}
[Token(Token = "0x2000012")]
public static class ResonanceAudioRoomManager
{
	[Token(Token = "0x2000013")]
	public enum SurfaceMaterial
	{
		[Token(Token = "0x4000073")]
		Transparent,
		[Token(Token = "0x4000074")]
		AcousticCeilingTiles,
		[Token(Token = "0x4000075")]
		BrickBare,
		[Token(Token = "0x4000076")]
		BrickPainted,
		[Token(Token = "0x4000077")]
		ConcreteBlockCoarse,
		[Token(Token = "0x4000078")]
		ConcreteBlockPainted,
		[Token(Token = "0x4000079")]
		CurtainHeavy,
		[Token(Token = "0x400007A")]
		FiberglassInsulation,
		[Token(Token = "0x400007B")]
		GlassThin,
		[Token(Token = "0x400007C")]
		GlassThick,
		[Token(Token = "0x400007D")]
		Grass,
		[Token(Token = "0x400007E")]
		LinoleumOnConcrete,
		[Token(Token = "0x400007F")]
		Marble,
		[Token(Token = "0x4000080")]
		Metal,
		[Token(Token = "0x4000081")]
		ParquetOnConcrete,
		[Token(Token = "0x4000082")]
		PlasterRough,
		[Token(Token = "0x4000083")]
		PlasterSmooth,
		[Token(Token = "0x4000084")]
		PlywoodPanel,
		[Token(Token = "0x4000085")]
		PolishedConcreteOrTile,
		[Token(Token = "0x4000086")]
		Sheetrock,
		[Token(Token = "0x4000087")]
		WaterOrIceSurface,
		[Token(Token = "0x4000088")]
		WoodCeiling,
		[Token(Token = "0x4000089")]
		WoodPanel
	}

	[Serializable]
	[Token(Token = "0x2000014")]
	public class SurfaceMaterialDictionary : Dictionary<string, SurfaceMaterial>, ISerializationCallbackReceiver
	{
		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<string> guids;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<SurfaceMaterial> surfaceMaterials;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xCB0C9C", Offset = "0xCB0C9C", VA = "0xCB0C9C")]
		public SurfaceMaterialDictionary()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xCB0D7C", Offset = "0xCB0D7C", VA = "0xCB0D7C", Slot = "46")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xCB1030", Offset = "0xCB1030", VA = "0xCB1030", Slot = "47")]
		public void OnAfterDeserialize()
		{
		}
	}

	[Token(Token = "0x2000015")]
	private struct RoomEffectsRegion
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ResonanceAudioRoom room;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ResonanceAudioReverbProbe reverbProbe;

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xCB0B94", Offset = "0xCB0B94", VA = "0xCB0B94")]
		public RoomEffectsRegion(ResonanceAudioRoom room, ResonanceAudioReverbProbe reverbProbe)
		{
		}
	}

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<RoomEffectsRegion> roomEffectsRegions;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Bounds bounds;

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xCAFDC8", Offset = "0xCAFDC8", VA = "0xCAFDC8")]
	public static float ComputeRoomEffectsGain(Vector3 sourcePosition)
	{
		return default(float);
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xCAFB14", Offset = "0xCAFB14", VA = "0xCAFB14")]
	public static void UpdateRoom(ResonanceAudioRoom room)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xCAFBCC", Offset = "0xCAFBCC", VA = "0xCAFBCC")]
	public static void RemoveRoom(ResonanceAudioRoom room)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xCAF64C", Offset = "0xCAF64C", VA = "0xCAF64C")]
	public static void UpdateReverbProbe(ResonanceAudioReverbProbe reverbProbe)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xCAF704", Offset = "0xCAF704", VA = "0xCAF704")]
	public static void RemoveReverbProbe(ResonanceAudioReverbProbe reverbProbe)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xCB0378", Offset = "0xCB0378", VA = "0xCB0378")]
	private static void UpdateRoomEffectsRegions(ResonanceAudioRoom room, bool isEnabled)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xCB0964", Offset = "0xCB0964", VA = "0xCB0964")]
	private static void UpdateRoomEffectsRegions(ResonanceAudioReverbProbe reverbProbe, bool isEnabled)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xCB05AC", Offset = "0xCB05AC", VA = "0xCB05AC")]
	private static void UpdateRoomEffects()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xCB0158", Offset = "0xCB0158", VA = "0xCB0158")]
	private static float ComputeRoomEffectsAttenuation(float distanceToRoom)
	{
		return default(float);
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xCB016C", Offset = "0xCB016C", VA = "0xCB016C")]
	private static bool IsListenerInsideRoom(ResonanceAudioRoom room)
	{
		return default(bool);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xCB0708", Offset = "0xCB0708", VA = "0xCB0708")]
	private static bool IsListenerInsideVisibleReverbProbe(ResonanceAudioReverbProbe reverbProbe)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000016")]
[ExecuteInEditMode]
[RequireComponent(typeof(AudioSource))]
[AddComponentMenu("ResonanceAudio/ResonanceAudioSource")]
public class ResonanceAudioSource : MonoBehaviour
{
	[Token(Token = "0x2000017")]
	public enum Quality
	{
		[Token(Token = "0x400009D")]
		Stereo,
		[Token(Token = "0x400009E")]
		Low,
		[Token(Token = "0x400009F")]
		High
	}

	[Token(Token = "0x2000018")]
	private enum EffectData
	{
		[Token(Token = "0x40000A1")]
		Id,
		[Token(Token = "0x40000A2")]
		DistanceAttenuation,
		[Token(Token = "0x40000A3")]
		RoomEffectsGain,
		[Token(Token = "0x40000A4")]
		Gain,
		[Token(Token = "0x40000A5")]
		DirectivityAlpha,
		[Token(Token = "0x40000A6")]
		DirectivitySharpness,
		[Token(Token = "0x40000A7")]
		ListenerDirectivityAlpha,
		[Token(Token = "0x40000A8")]
		ListenerDirectivitySharpness,
		[Token(Token = "0x40000A9")]
		Occlusion,
		[Token(Token = "0x40000AA")]
		Quality,
		[Token(Token = "0x40000AB")]
		NearFieldEffectGain,
		[Token(Token = "0x40000AC")]
		Volume
	}

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Sets whether the room effects for the source should be bypassed.")]
	public bool bypassRoomEffects;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 1f)]
	[Tooltip("Controls the balance between a dipole pattern and an omnidirectional pattern for source emission. By varying this value, different directivity patterns can be formed.")]
	public float directivityAlpha;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(1f, 10f)]
	[Tooltip("Sets the sharpness of the source directivity pattern. Higher values will result in increased directivity.")]
	public float directivitySharpness;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0f, 1f)]
	[Tooltip("Controls the balance between a dipole pattern and an omnidirectional pattern for listener sensitivity. By varying this value, different directivity patterns can be formed.")]
	public float listenerDirectivityAlpha;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(1f, 10f)]
	[Tooltip("Sets the sharpness of the listener directivity pattern. Higher values will result in increased directivity.")]
	public float listenerDirectivitySharpness;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("Applies a gain to the source for adjustment of relative loudness.")]
	public float gainDb;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Sets whether the near field effect should be applied when the distance between the source and the listener is less than 1m (in Unity units).")]
	public bool nearFieldEffectEnabled;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("Sets the nearfield effect gain. Note that the near field effect could result in up to ~9x gain boost on the source input, therefore, it is advised to set smaller gain values for louder sound sources to avoid clipping of the output signal.")]
	[Range(0f, 9f)]
	public float nearFieldEffectGain;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Sets whether the sound of the source should be occluded when there are other objects between the source and the listener.")]
	public bool occlusionEnabled;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[Range(0f, 10f)]
	[Tooltip("Sets the occlusion effect intensity. Higher values will result in a stronger effect when the source is occluded.")]
	public float occlusionIntensity;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("Sets the quality mode in which the spatial audio will be rendered. Higher quality modes allow increased fidelity at the cost of greater CPU usage.")]
	public Quality quality;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float currentOcclusion;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float nextOcclusionUpdate;

	[Token(Token = "0x17000005")]
	public AudioSource audioSource
	{
		[Token(Token = "0x6000077")]
		[Address(RVA = "0xCB1138", Offset = "0xCB1138", VA = "0xCB1138")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000078")]
		[Address(RVA = "0xCB1140", Offset = "0xCB1140", VA = "0xCB1140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xCB1148", Offset = "0xCB1148", VA = "0xCB1148")]
	private void Awake()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xCB1198", Offset = "0xCB1198", VA = "0xCB1198")]
	private void Update()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xCB1258", Offset = "0xCB1258", VA = "0xCB1258")]
	private void UpdateSource()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xCB1580", Offset = "0xCB1580", VA = "0xCB1580")]
	public ResonanceAudioSource()
	{
	}
}
[Token(Token = "0x2000019")]
public static class JsonUtilityArrays
{
	[Serializable]
	[Token(Token = "0x200001A")]
	private class Wrapper<T>
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] Items;

		[Token(Token = "0x6000080")]
		public Wrapper()
		{
		}
	}

	[Token(Token = "0x600007D")]
	public static T[] FromJson<T>(string json)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	public static string ToJson<T>(T[] array)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	public static string ToJson<T>(T[] array, bool prettyPrint)
	{
		return null;
	}
}
[Token(Token = "0x200001B")]
[RequireComponent(typeof(Camera))]
public class GhostFreeRoamCamera : MonoBehaviour
{
	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float initialSpeed;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float increaseSpeed;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool allowMovement;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool allowRotation;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public KeyCode forwardButton;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public KeyCode backwardButton;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public KeyCode rightButton;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public KeyCode leftButton;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float cursorSensitivity;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool cursorToggleAllowed;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public KeyCode cursorToggleButton;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float currentSpeed;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool moving;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	private bool togglePressed;

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xCB15A4", Offset = "0xCB15A4", VA = "0xCB15A4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xCB15D4", Offset = "0xCB15D4", VA = "0xCB15D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xCB198C", Offset = "0xCB198C", VA = "0xCB198C")]
	private void CheckMove(KeyCode keyCode, ref Vector3 deltaPosition, Vector3 directionVector)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xCB19FC", Offset = "0xCB19FC", VA = "0xCB19FC")]
	public GhostFreeRoamCamera()
	{
	}
}
[Token(Token = "0x200001C")]
public class WaterEffectCtrl : MonoBehaviour
{
	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem par;

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xCB1A40", Offset = "0xCB1A40", VA = "0xCB1A40")]
	private void Start()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xCB1A44", Offset = "0xCB1A44", VA = "0xCB1A44")]
	private void Update()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xCB1A88", Offset = "0xCB1A88", VA = "0xCB1A88")]
	public void PlayEffect(float force)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xCB1C70", Offset = "0xCB1C70", VA = "0xCB1C70")]
	public WaterEffectCtrl()
	{
	}
}
[Token(Token = "0x200001D")]
public class WaveEffCtrl : MonoBehaviour
{
	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material mat_baseSurface;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material mat_wave_test;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed_wave_test;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float waveP_test;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve animCurve_waveP;

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xCB1C78", Offset = "0xCB1C78", VA = "0xCB1C78")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xCB1E88", Offset = "0xCB1E88", VA = "0xCB1E88")]
	public WaveEffCtrl()
	{
	}
}
[Token(Token = "0x200001E")]
public class Rot_CTRL : MonoBehaviour
{
	[Token(Token = "0x600008B")]
	[Address(RVA = "0xCB1E9C", Offset = "0xCB1E9C", VA = "0xCB1E9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xCB1EA0", Offset = "0xCB1EA0", VA = "0xCB1EA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xCB1F1C", Offset = "0xCB1F1C", VA = "0xCB1F1C")]
	public Rot_CTRL()
	{
	}
}
[Token(Token = "0x200001F")]
public static class AppSettingsExtensions
{
	[Token(Token = "0x600008E")]
	[Address(RVA = "0xCB1F24", Offset = "0xCB1F24", VA = "0xCB1F24")]
	public static ChatAppSettings GetChatSettings(this AppSettings appSettings)
	{
		return null;
	}
}
[Token(Token = "0x2000020")]
public class ChannelSelector : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string Channel;

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xCB1FF0", Offset = "0xCB1FF0", VA = "0xCB1FF0")]
	public void SetChannel(string channel)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xCB2064", Offset = "0xCB2064", VA = "0xCB2064", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xCB2364", Offset = "0xCB2364", VA = "0xCB2364")]
	public ChannelSelector()
	{
	}
}
[Token(Token = "0x2000021")]
[ExecuteInEditMode]
public class ChatAppIdCheckerUI : MonoBehaviour
{
	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text Description;

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xCB236C", Offset = "0xCB236C", VA = "0xCB236C")]
	public void Update()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xCB249C", Offset = "0xCB249C", VA = "0xCB249C")]
	public ChatAppIdCheckerUI()
	{
	}
}
[Token(Token = "0x2000022")]
public class ChatGui : MonoBehaviour, IChatClientListener
{
	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string[] ChannelsToJoinOnConnect;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] FriendsList;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int HistoryLengthToFetch;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string selectedChannelName;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ChatClient chatClient;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected internal ChatAppSettings chatAppSettings;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject missingAppIdErrorPanel;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject ConnectingLabel;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RectTransform ChatPanel;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject UserIdFormPanel;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public InputField InputFieldChat;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Text CurrentChannelText;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Toggle ChannelToggleToInstantiate;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject FriendListUiItemtoInstantiate;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Dictionary<string, Toggle> channelToggles;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly Dictionary<string, FriendItem> friendListItemLUT;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool ShowState;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject Title;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Text StateText;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Text UserIdText;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string HelpText;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public int TestLength;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private byte[] testBytes;

	[Token(Token = "0x17000006")]
	public string UserName
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0xCB24A4", Offset = "0xCB24A4", VA = "0xCB24A4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000095")]
		[Address(RVA = "0xCB24AC", Offset = "0xCB24AC", VA = "0xCB24AC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xCB24B4", Offset = "0xCB24B4", VA = "0xCB24B4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xCB2754", Offset = "0xCB2754", VA = "0xCB2754")]
	public void Connect()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xCB28C4", Offset = "0xCB28C4", VA = "0xCB28C4")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xCB28DC", Offset = "0xCB28DC", VA = "0xCB28DC")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xCB28F4", Offset = "0xCB28F4", VA = "0xCB28F4")]
	public void Update()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xCB29C4", Offset = "0xCB29C4", VA = "0xCB29C4")]
	public void OnEnterSend()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xCB349C", Offset = "0xCB349C", VA = "0xCB349C")]
	public void OnClickSend()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xCB2A58", Offset = "0xCB2A58", VA = "0xCB2A58")]
	private void SendChatMessage(string inputLine)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xCB354C", Offset = "0xCB354C", VA = "0xCB354C")]
	public void PostHelpToCurrentChannel()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xCB35F0", Offset = "0xCB35F0", VA = "0xCB35F0", Slot = "4")]
	public void DebugReturn(DebugLevel level, string message)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xCB3698", Offset = "0xCB3698", VA = "0xCB3698", Slot = "6")]
	public void OnConnected()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xCB39D4", Offset = "0xCB39D4", VA = "0xCB39D4", Slot = "5")]
	public void OnDisconnected()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xCB39F4", Offset = "0xCB39F4", VA = "0xCB39F4", Slot = "7")]
	public void OnChatStateChange(ChatState state)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xCB3A88", Offset = "0xCB3A88", VA = "0xCB3A88", Slot = "10")]
	public void OnSubscribed(string[] channels, bool[] results)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xCB3DD8", Offset = "0xCB3DD8", VA = "0xCB3DD8")]
	public void OnSubscribed(string channel, string[] users, Dictionary<object, object> properties)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xCB3C1C", Offset = "0xCB3C1C", VA = "0xCB3C1C")]
	private void InstantiateChannelButton(string channelName)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xCB387C", Offset = "0xCB387C", VA = "0xCB387C")]
	private void InstantiateFriendButton(string friendId)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xCB3F9C", Offset = "0xCB3F9C", VA = "0xCB3F9C", Slot = "11")]
	public void OnUnsubscribed(string[] channels)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xCB43E0", Offset = "0xCB43E0", VA = "0xCB43E0", Slot = "8")]
	public void OnGetMessages(string channelName, string[] senders, object[] messages)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xCB4420", Offset = "0xCB4420", VA = "0xCB4420", Slot = "9")]
	public void OnPrivateMessage(string sender, object message, string channelName)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xCB4534", Offset = "0xCB4534", VA = "0xCB4534", Slot = "12")]
	public void OnStatusUpdate(string user, int status, bool gotMessage, object message)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xCB4874", Offset = "0xCB4874", VA = "0xCB4874", Slot = "13")]
	public void OnUserSubscribed(string channel, string user)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xCB4978", Offset = "0xCB4978", VA = "0xCB4978", Slot = "14")]
	public void OnUserUnsubscribed(string channel, string user)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xCB4A7C", Offset = "0xCB4A7C", VA = "0xCB4A7C")]
	public void OnChannelPropertiesChanged(string channel, string userId, Dictionary<object, object> properties)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xCB4BE0", Offset = "0xCB4BE0", VA = "0xCB4BE0")]
	public void OnUserPropertiesChanged(string channel, string targetUserId, string senderUserId, Dictionary<object, object> properties)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xCB4D78", Offset = "0xCB4D78", VA = "0xCB4D78")]
	public void OnErrorInfo(string channel, string error, object data)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xCB4EA8", Offset = "0xCB4EA8", VA = "0xCB4EA8")]
	public void AddMessageToSelectedChannel(string msg)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xCB20DC", Offset = "0xCB20DC", VA = "0xCB20DC")]
	public void ShowChannel(string channelName)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xCB4F94", Offset = "0xCB4F94", VA = "0xCB4F94")]
	public void OpenDashboard()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xCB4FD8", Offset = "0xCB4FD8", VA = "0xCB4FD8")]
	public ChatGui()
	{
	}
}
[Token(Token = "0x2000023")]
public class FriendItem : MonoBehaviour
{
	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text NameLabel;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text StatusLabel;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text Health;

	[Token(Token = "0x17000007")]
	[HideInInspector]
	public string FriendId
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xCB512C", Offset = "0xCB512C", VA = "0xCB512C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xCB3F78", Offset = "0xCB3F78", VA = "0xCB3F78")]
		set
		{
		}
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xCB5150", Offset = "0xCB5150", VA = "0xCB5150")]
	public void Awake()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xCB46F4", Offset = "0xCB46F4", VA = "0xCB46F4")]
	public void OnFriendStatusUpdate(int status, bool gotMessage, object message)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xCB51B4", Offset = "0xCB51B4", VA = "0xCB51B4")]
	public FriendItem()
	{
	}
}
[Token(Token = "0x2000024")]
public class IgnoreUiRaycastWhenInactive : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xCB51BC", Offset = "0xCB51BC", VA = "0xCB51BC", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xCB51DC", Offset = "0xCB51DC", VA = "0xCB51DC")]
	public IgnoreUiRaycastWhenInactive()
	{
	}
}
[Token(Token = "0x2000025")]
[RequireComponent(typeof(ChatGui))]
public class NamePickGui : MonoBehaviour
{
	[Token(Token = "0x40000DF")]
	private const string UserNamePlayerPref = "NamePickUserName";

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ChatGui chatNewComponent;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public InputField idInput;

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xCB51E4", Offset = "0xCB51E4", VA = "0xCB51E4")]
	public void Start()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xCB52A4", Offset = "0xCB52A4", VA = "0xCB52A4")]
	public void EndEditOnEnter()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xCB52E0", Offset = "0xCB52E0", VA = "0xCB52E0")]
	public void StartChat()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xCB53AC", Offset = "0xCB53AC", VA = "0xCB53AC")]
	public NamePickGui()
	{
	}
}
[Token(Token = "0x2000026")]
[RequireComponent(typeof(PhotonView))]
[RequireComponent(typeof(Renderer))]
public class ChangeColor : MonoBehaviour
{
	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PhotonView photonView;

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xCB53B4", Offset = "0xCB53B4", VA = "0xCB53B4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xCB54FC", Offset = "0xCB54FC", VA = "0xCB54FC")]
	[PunRPC]
	private void ChangeColour(Vector3 randomColor)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xCB55A4", Offset = "0xCB55A4", VA = "0xCB55A4")]
	public ChangeColor()
	{
	}
}
[Token(Token = "0x2000027")]
[RequireComponent(typeof(PhotonView))]
public class ChangeName : MonoBehaviour
{
	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xCB55AC", Offset = "0xCB55AC", VA = "0xCB55AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xCB5668", Offset = "0xCB5668", VA = "0xCB5668")]
	public ChangeName()
	{
	}
}
[Token(Token = "0x2000028")]
[RequireComponent(typeof(PhotonVoiceView))]
public class PointersController : MonoBehaviour
{
	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject pointerDown;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject pointerUp;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private PhotonVoiceView photonVoiceView;

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xCB5670", Offset = "0xCB5670", VA = "0xCB5670")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xCB577C", Offset = "0xCB577C", VA = "0xCB577C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xCB56D4", Offset = "0xCB56D4", VA = "0xCB56D4")]
	private void SetActiveSafe(GameObject go, bool active)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xCB57D4", Offset = "0xCB57D4", VA = "0xCB57D4")]
	public PointersController()
	{
	}
}
[Token(Token = "0x2000029")]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class ProximityVoiceTrigger : VoiceComponent
{
	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<byte> groupsToAdd;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<byte> groupsToRemove;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private byte[] subscribedGroups;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PhotonVoiceView photonVoiceView;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private PhotonView photonView;

	[Token(Token = "0x17000008")]
	public byte TargetInterestGroup
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xCB57DC", Offset = "0xCB57DC", VA = "0xCB57DC")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xCB585C", Offset = "0xCB585C", VA = "0xCB585C", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xCB5A84", Offset = "0xCB5A84", VA = "0xCB5A84")]
	private void ToggleTransmission()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xCB5D6C", Offset = "0xCB5D6C", VA = "0xCB5D6C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xCB5FC8", Offset = "0xCB5FC8", VA = "0xCB5FC8")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xCB6264", Offset = "0xCB6264", VA = "0xCB6264")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xCB5910", Offset = "0xCB5910", VA = "0xCB5910")]
	private bool IsLocalCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xCB68B0", Offset = "0xCB68B0", VA = "0xCB68B0")]
	public ProximityVoiceTrigger()
	{
	}
}
[Serializable]
[Token(Token = "0x200002A")]
public class MouseLookHelper
{
	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float XSensitivity;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float YSensitivity;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool clampVerticalRotation;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float MinimumX;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float MaximumX;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool smooth;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float smoothTime;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Quaternion m_CharacterTargetRot;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Quaternion m_CameraTargetRot;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xCB6950", Offset = "0xCB6950", VA = "0xCB6950")]
	public void Init(Transform character, Transform camera)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xCB69A0", Offset = "0xCB69A0", VA = "0xCB69A0")]
	public void LookRotation(Transform character, Transform camera)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xCB6D30", Offset = "0xCB6D30", VA = "0xCB6D30")]
	private Quaternion ClampRotationAroundXAxis(Quaternion q)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xCB6D94", Offset = "0xCB6D94", VA = "0xCB6D94")]
	public MouseLookHelper()
	{
	}
}
[Token(Token = "0x200002B")]
public class SoundsForJoinAndLeave : MonoBehaviourPunCallbacks
{
	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip JoinClip;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioClip LeaveClip;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource source;

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xCB6DC0", Offset = "0xCB6DC0", VA = "0xCB6DC0", Slot = "42")]
	public override void OnPlayerEnteredRoom(Player newPlayer)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xCB6EA8", Offset = "0xCB6EA8", VA = "0xCB6EA8", Slot = "43")]
	public override void OnPlayerLeftRoom(Player otherPlayer)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xCB6F90", Offset = "0xCB6F90", VA = "0xCB6F90")]
	public SoundsForJoinAndLeave()
	{
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200002C")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xCB6F98", Offset = "0xCB6F98", VA = "0xCB6F98")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xCB71E8", Offset = "0xCB71E8", VA = "0xCB71E8")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xCB7364", Offset = "0xCB7364", VA = "0xCB7364")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xCB73D4", Offset = "0xCB73D4", VA = "0xCB73D4", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xCB74A0", Offset = "0xCB74A0", VA = "0xCB74A0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xCB7504", Offset = "0xCB7504", VA = "0xCB7504")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xCB7568", Offset = "0xCB7568", VA = "0xCB7568")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xCB756C", Offset = "0xCB756C", VA = "0xCB756C")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xCB7634", Offset = "0xCB7634", VA = "0xCB7634")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xCB76FC", Offset = "0xCB76FC", VA = "0xCB76FC")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xCB77C4", Offset = "0xCB77C4", VA = "0xCB77C4")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xCB788C", Offset = "0xCB788C", VA = "0xCB788C")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xCB7954", Offset = "0xCB7954", VA = "0xCB7954")]
		public void Update()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xCB7958", Offset = "0xCB7958", VA = "0xCB7958")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200002F")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x4000102")]
			Hardware,
			[Token(Token = "0x4000103")]
			Touch
		}

		[Token(Token = "0x2000030")]
		public class VirtualAxis
		{
			[Token(Token = "0x4000105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x1700000A")]
			public string name
			{
				[Token(Token = "0x60000FF")]
				[Address(RVA = "0xCB868C", Offset = "0xCB868C", VA = "0xCB868C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000100")]
				[Address(RVA = "0xCB8694", Offset = "0xCB8694", VA = "0xCB8694")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700000B")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000101")]
				[Address(RVA = "0xCB869C", Offset = "0xCB869C", VA = "0xCB869C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000102")]
				[Address(RVA = "0xCB86A4", Offset = "0xCB86A4", VA = "0xCB86A4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700000C")]
			public float GetValue
			{
				[Token(Token = "0x6000107")]
				[Address(RVA = "0xCB86EC", Offset = "0xCB86EC", VA = "0xCB86EC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700000D")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000108")]
				[Address(RVA = "0xCB86F4", Offset = "0xCB86F4", VA = "0xCB86F4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000103")]
			[Address(RVA = "0xCB70E8", Offset = "0xCB70E8", VA = "0xCB70E8")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0xCB86B0", Offset = "0xCB86B0", VA = "0xCB86B0")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000105")]
			[Address(RVA = "0xCB737C", Offset = "0xCB737C", VA = "0xCB737C")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000106")]
			[Address(RVA = "0xCB86E4", Offset = "0xCB86E4", VA = "0xCB86E4")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000031")]
		public class VirtualButton
		{
			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x1700000E")]
			public string name
			{
				[Token(Token = "0x6000109")]
				[Address(RVA = "0xCB86FC", Offset = "0xCB86FC", VA = "0xCB86FC")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600010A")]
				[Address(RVA = "0xCB8704", Offset = "0xCB8704", VA = "0xCB8704")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700000F")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600010B")]
				[Address(RVA = "0xCB870C", Offset = "0xCB870C", VA = "0xCB870C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600010C")]
				[Address(RVA = "0xCB8714", Offset = "0xCB8714", VA = "0xCB8714")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000010")]
			public bool GetButton
			{
				[Token(Token = "0x6000112")]
				[Address(RVA = "0xCB8838", Offset = "0xCB8838", VA = "0xCB8838")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000011")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000113")]
				[Address(RVA = "0xCB8840", Offset = "0xCB8840", VA = "0xCB8840")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000012")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000114")]
				[Address(RVA = "0xCB8864", Offset = "0xCB8864", VA = "0xCB8864")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600010D")]
			[Address(RVA = "0xCB8720", Offset = "0xCB8720", VA = "0xCB8720")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x600010E")]
			[Address(RVA = "0xCB8758", Offset = "0xCB8758", VA = "0xCB8758")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600010F")]
			[Address(RVA = "0xCB8794", Offset = "0xCB8794", VA = "0xCB8794")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000110")]
			[Address(RVA = "0xCB87C0", Offset = "0xCB87C0", VA = "0xCB87C0")]
			public void Released()
			{
			}

			[Token(Token = "0x6000111")]
			[Address(RVA = "0xCB87E0", Offset = "0xCB87E0", VA = "0xCB87E0")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000009")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xCB84B8", Offset = "0xCB84B8", VA = "0xCB84B8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xCB7960", Offset = "0xCB7960", VA = "0xCB7960")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xCB7A18", Offset = "0xCB7A18", VA = "0xCB7A18")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xCB7080", Offset = "0xCB7080", VA = "0xCB7080")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xCB7B00", Offset = "0xCB7B00", VA = "0xCB7B00")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xCB7118", Offset = "0xCB7118", VA = "0xCB7118")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xCB7D48", Offset = "0xCB7D48", VA = "0xCB7D48")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xCB7F38", Offset = "0xCB7F38", VA = "0xCB7F38")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xCB8080", Offset = "0xCB8080", VA = "0xCB8080")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xCB7180", Offset = "0xCB7180", VA = "0xCB7180")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xCB6CD8", Offset = "0xCB6CD8", VA = "0xCB6CD8")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xCB828C", Offset = "0xCB828C", VA = "0xCB828C")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xCB820C", Offset = "0xCB820C", VA = "0xCB820C")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xCB82E4", Offset = "0xCB82E4", VA = "0xCB82E4")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xCB8354", Offset = "0xCB8354", VA = "0xCB8354")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xCB83C4", Offset = "0xCB83C4", VA = "0xCB83C4")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xCB75C4", Offset = "0xCB75C4", VA = "0xCB75C4")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xCB768C", Offset = "0xCB768C", VA = "0xCB768C")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xCB7754", Offset = "0xCB7754", VA = "0xCB7754")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xCB78E4", Offset = "0xCB78E4", VA = "0xCB78E4")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xCB781C", Offset = "0xCB781C", VA = "0xCB781C")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xCB8434", Offset = "0xCB8434", VA = "0xCB8434")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xCB8524", Offset = "0xCB8524", VA = "0xCB8524")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xCB859C", Offset = "0xCB859C", VA = "0xCB859C")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xCB8614", Offset = "0xCB8614", VA = "0xCB8614")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xCB8888", Offset = "0xCB8888", VA = "0xCB8888")]
		private void Update()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xCB888C", Offset = "0xCB888C", VA = "0xCB888C")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xCB88FC", Offset = "0xCB88FC", VA = "0xCB88FC")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000034")]
		public enum AxisOption
		{
			[Token(Token = "0x4000117")]
			Both,
			[Token(Token = "0x4000118")]
			OnlyHorizontal,
			[Token(Token = "0x4000119")]
			OnlyVertical
		}

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xCB8904", Offset = "0xCB8904", VA = "0xCB8904")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xCB8A2C", Offset = "0xCB8A2C", VA = "0xCB8A2C")]
		private void Start()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xCB8A5C", Offset = "0xCB8A5C", VA = "0xCB8A5C")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xCB8908", Offset = "0xCB8908", VA = "0xCB8908")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xCB8ABC", Offset = "0xCB8ABC", VA = "0xCB8ABC", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xCB8C08", Offset = "0xCB8C08", VA = "0xCB8C08", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xCB8C44", Offset = "0xCB8C44", VA = "0xCB8C44", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xCB8C48", Offset = "0xCB8C48", VA = "0xCB8C48")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xCB8C88", Offset = "0xCB8C88", VA = "0xCB8C88")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0xCB8D04", Offset = "0xCB8D04", VA = "0xCB8D04")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xCB8D14", Offset = "0xCB8D14", VA = "0xCB8D14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xCB8D0C", Offset = "0xCB8D0C", VA = "0xCB8D0C")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xCB8E1C", Offset = "0xCB8E1C", VA = "0xCB8E1C")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xCB9194", Offset = "0xCB9194", VA = "0xCB9194")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000037")]
		public enum AxisOption
		{
			[Token(Token = "0x400012D")]
			Both,
			[Token(Token = "0x400012E")]
			OnlyHorizontal,
			[Token(Token = "0x400012F")]
			OnlyVertical
		}

		[Token(Token = "0x2000038")]
		public enum ControlStyle
		{
			[Token(Token = "0x4000131")]
			Absolute,
			[Token(Token = "0x4000132")]
			Relative,
			[Token(Token = "0x4000133")]
			Swipe
		}

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xCB919C", Offset = "0xCB919C", VA = "0xCB919C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xCB92C4", Offset = "0xCB92C4", VA = "0xCB92C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xCB91A0", Offset = "0xCB91A0", VA = "0xCB91A0")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xCB9338", Offset = "0xCB9338", VA = "0xCB9338")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xCB9438", Offset = "0xCB9438", VA = "0xCB9438", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xCB9470", Offset = "0xCB9470", VA = "0xCB9470")]
		private void Update()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xCB9648", Offset = "0xCB9648", VA = "0xCB9648", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xCB96A8", Offset = "0xCB96A8", VA = "0xCB96A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xCB9768", Offset = "0xCB9768", VA = "0xCB9768")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x17000013")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0xCB97EC", Offset = "0xCB97EC", VA = "0xCB97EC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xCB97F8", Offset = "0xCB97F8", VA = "0xCB97F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xCB7AA8", Offset = "0xCB7AA8", VA = "0xCB7AA8")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xCB7B68", Offset = "0xCB7B68", VA = "0xCB7B68")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xCB7BC0", Offset = "0xCB7BC0", VA = "0xCB7BC0")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xCB7DB0", Offset = "0xCB7DB0", VA = "0xCB7DB0")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xCB7FF0", Offset = "0xCB7FF0", VA = "0xCB7FF0")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xCB80E8", Offset = "0xCB80E8", VA = "0xCB80E8")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xCB8178", Offset = "0xCB8178", VA = "0xCB8178")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xCB8594", Offset = "0xCB8594", VA = "0xCB8594")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xCB860C", Offset = "0xCB860C", VA = "0xCB860C")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xCB8684", Offset = "0xCB8684", VA = "0xCB8684")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x600013B")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x600013C")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x600013D")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x600013E")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x600013F")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000140")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000141")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000142")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000143")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000144")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000145")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xCB9804", Offset = "0xCB9804", VA = "0xCB9804")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x200003A")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000147")]
		[Address(RVA = "0xCB9908", Offset = "0xCB9908", VA = "0xCB9908")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xCB99A0", Offset = "0xCB99A0", VA = "0xCB99A0")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xCB9A30", Offset = "0xCB9A30", VA = "0xCB9A30", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xCB9AC8", Offset = "0xCB9AC8", VA = "0xCB9AC8", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xCB9B7C", Offset = "0xCB9B7C", VA = "0xCB9B7C", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xCB9C24", Offset = "0xCB9C24", VA = "0xCB9C24", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xCB9CC0", Offset = "0xCB9CC0", VA = "0xCB9CC0", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xCB9D5C", Offset = "0xCB9D5C", VA = "0xCB9D5C", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xCB9DF4", Offset = "0xCB9DF4", VA = "0xCB9DF4", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xCB9E98", Offset = "0xCB9E98", VA = "0xCB9E98", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xCB9F44", Offset = "0xCB9F44", VA = "0xCB9F44", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xCB9FF0", Offset = "0xCB9FF0", VA = "0xCB9FF0", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xCBA088", Offset = "0xCBA088", VA = "0xCBA088", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xCB7A10", Offset = "0xCB7A10", VA = "0xCB7A10")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000155")]
		[Address(RVA = "0xCBA094", Offset = "0xCBA094", VA = "0xCBA094", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xCBA0A8", Offset = "0xCBA0A8", VA = "0xCBA0A8", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xCBA0B4", Offset = "0xCBA0B4", VA = "0xCBA0B4", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xCBA0C0", Offset = "0xCBA0C0", VA = "0xCBA0C0", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xCBA0CC", Offset = "0xCBA0CC", VA = "0xCBA0CC", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xCBA11C", Offset = "0xCBA11C", VA = "0xCBA11C", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xCBA16C", Offset = "0xCBA16C", VA = "0xCBA16C", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xCBA1BC", Offset = "0xCBA1BC", VA = "0xCBA1BC", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xCBA20C", Offset = "0xCBA20C", VA = "0xCBA20C", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xCBA25C", Offset = "0xCBA25C", VA = "0xCBA25C", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xCBA2AC", Offset = "0xCBA2AC", VA = "0xCBA2AC", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xCB7A14", Offset = "0xCB7A14", VA = "0xCB7A14")]
		public StandaloneInput()
		{
		}
	}
}
namespace ExitGames.Demos.DemoPunVoice
{
	[Token(Token = "0x200003C")]
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(PhotonView))]
	public abstract class BaseController : MonoBehaviour
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera ControllerCamera;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Rigidbody rigidBody;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Animator animator;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform camTrans;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float h;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float v;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected float speed;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float cameraDistance;

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xCBA2B4", Offset = "0xCBA2B4", VA = "0xCBA2B4", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xCBA4AC", Offset = "0xCBA4AC", VA = "0xCBA4AC", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xCBA5D0", Offset = "0xCBA5D0", VA = "0xCBA5D0", Slot = "6")]
		protected virtual void ChangePOV_CameraChanged(Camera camera)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xCBA678", Offset = "0xCBA678", VA = "0xCBA678", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xCBA708", Offset = "0xCBA708", VA = "0xCBA708", Slot = "8")]
		protected virtual void Init()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xCBA784", Offset = "0xCBA784", VA = "0xCBA784", Slot = "9")]
		protected virtual void SetCamera()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xCBA81C", Offset = "0xCBA81C", VA = "0xCBA81C", Slot = "10")]
		protected virtual void UpdateAnimator(float h, float v)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xCBA894", Offset = "0xCBA894", VA = "0xCBA894", Slot = "11")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xCBA988", Offset = "0xCBA988", VA = "0xCBA988", Slot = "12")]
		protected virtual void ShowCamera(Camera camera)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xCBAA18", Offset = "0xCBAA18", VA = "0xCBAA18", Slot = "13")]
		protected virtual void HideCamera(Camera camera)
		{
		}

		[Token(Token = "0x600016B")]
		protected abstract void Move(float h, float v);

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xCBAAA8", Offset = "0xCBAAA8", VA = "0xCBAAA8")]
		protected BaseController()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[RequireComponent(typeof(Toggle))]
	[DisallowMultipleComponent]
	public class BetterToggle : MonoBehaviour
	{
		[Token(Token = "0x200003E")]
		public delegate void OnToggle(Toggle toggle);

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Toggle toggle;

		[Token(Token = "0x14000001")]
		public static event OnToggle ToggleValueChanged
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0xCBAAB8", Offset = "0xCBAAB8", VA = "0xCBAAB8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xCBAB70", Offset = "0xCBAB70", VA = "0xCBAB70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xCBAC28", Offset = "0xCBAC28", VA = "0xCBAC28")]
		private void Start()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xCBACF0", Offset = "0xCBACF0", VA = "0xCBACF0")]
		public void OnToggleValueChanged()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xCBAD5C", Offset = "0xCBAD5C", VA = "0xCBAD5C")]
		public BetterToggle()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class ChangePOV : MonoBehaviour, IMatchmakingCallbacks
	{
		[Token(Token = "0x2000040")]
		public delegate void OnCameraChanged(Camera newCamera);

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FirstPersonController firstPersonController;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ThirdPersonController thirdPersonController;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OrthographicController orthographicController;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 initialCameraPosition;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion initialCameraRotation;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Camera defaultCamera;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject ButtonsHolder;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button FirstPersonCamActivator;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button ThirdPersonCamActivator;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button OrthographicCamActivator;

		[Token(Token = "0x14000002")]
		public static event OnCameraChanged CameraChanged
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xCBA3F4", Offset = "0xCBA3F4", VA = "0xCBA3F4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0xCBA518", Offset = "0xCBA518", VA = "0xCBA518")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xCBAED4", Offset = "0xCBAED4", VA = "0xCBAED4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xCBB108", Offset = "0xCBB108", VA = "0xCBB108")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xCBB268", Offset = "0xCBB268", VA = "0xCBB268")]
		private void Start()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xCBB478", Offset = "0xCBB478", VA = "0xCBB478")]
		private void OnCharacterInstantiated(GameObject character)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xCBB550", Offset = "0xCBB550", VA = "0xCBB550")]
		private void FirstPersonMode()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xCBB6D4", Offset = "0xCBB6D4", VA = "0xCBB6D4")]
		private void ThirdPersonMode()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xCBB6DC", Offset = "0xCBB6DC", VA = "0xCBB6DC")]
		private void OrthographicMode()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xCBB558", Offset = "0xCBB558", VA = "0xCBB558")]
		private void ToggleMode(BaseController controller)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xCBB6E4", Offset = "0xCBB6E4", VA = "0xCBB6E4")]
		private void BroadcastChange(Camera camera)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xCBB788", Offset = "0xCBB788", VA = "0xCBB788", Slot = "4")]
		public void OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xCBB78C", Offset = "0xCBB78C", VA = "0xCBB78C", Slot = "5")]
		public void OnCreatedRoom()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xCBB790", Offset = "0xCBB790", VA = "0xCBB790", Slot = "6")]
		public void OnCreateRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xCBB794", Offset = "0xCBB794", VA = "0xCBB794", Slot = "7")]
		public void OnJoinedRoom()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xCBB798", Offset = "0xCBB798", VA = "0xCBB798", Slot = "8")]
		public void OnJoinRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xCBB79C", Offset = "0xCBB79C", VA = "0xCBB79C", Slot = "9")]
		public void OnJoinRandomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xCBB7A0", Offset = "0xCBB7A0", VA = "0xCBB7A0", Slot = "10")]
		public void OnLeftRoom()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xCBB8B4", Offset = "0xCBB8B4", VA = "0xCBB8B4")]
		public ChangePOV()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class CharacterInstantiation : MonoBehaviourPunCallbacks, IOnEventCallback
	{
		[Token(Token = "0x2000042")]
		public enum SpawnSequence
		{
			[Token(Token = "0x400015C")]
			Connection,
			[Token(Token = "0x400015D")]
			Random,
			[Token(Token = "0x400015E")]
			RoundRobin
		}

		[Token(Token = "0x2000043")]
		public delegate void OnCharacterInstantiated(GameObject character);

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform SpawnPosition;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float PositionOffset;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject[] PrefabsToInstantiate;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Transform> SpawnPoints;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool AutoSpawn;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool UseRandomOffset;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public SpawnSequence Sequence;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private byte manualInstantiationEventCode;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		protected int lastUsedSpawnPointIndex;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool manualInstantiation;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool differentPrefabs;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string localPrefabSuffix;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string remotePrefabSuffix;

		[Token(Token = "0x14000003")]
		public static event OnCharacterInstantiated CharacterInstantiated
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0xCBB050", Offset = "0xCBB050", VA = "0xCBB050")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0xCBB1B0", Offset = "0xCBB1B0", VA = "0xCBB1B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xCBB8FC", Offset = "0xCBB8FC", VA = "0xCBB8FC", Slot = "41")]
		public override void OnJoinedRoom()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xCBBB10", Offset = "0xCBBB10", VA = "0xCBBB10")]
		private void ManualInstantiation(int index, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xCBC00C", Offset = "0xCBC00C", VA = "0xCBC00C", Slot = "54")]
		public void OnEvent(EventData photonEvent)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xCBC36C", Offset = "0xCBC36C", VA = "0xCBC36C", Slot = "55")]
		protected virtual void GetSpawnPoint(out Vector3 spawnPos, out Quaternion spawnRot)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xCBC584", Offset = "0xCBC584", VA = "0xCBC584", Slot = "56")]
		protected virtual Transform GetSpawnPoint()
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xCBC6A4", Offset = "0xCBC6A4", VA = "0xCBC6A4")]
		public CharacterInstantiation()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class FirstPersonController : BaseController
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MouseLookHelper mouseLook;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float oldYRotation;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Quaternion velRotation;

		[Token(Token = "0x17000014")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0xCBC70C", Offset = "0xCBC70C", VA = "0xCBC70C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xCBC728", Offset = "0xCBC728", VA = "0xCBC728", Slot = "9")]
		protected override void SetCamera()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xCBC768", Offset = "0xCBC768", VA = "0xCBC768", Slot = "14")]
		protected override void Move(float h, float v)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xCBC7F0", Offset = "0xCBC7F0", VA = "0xCBC7F0")]
		private void Update()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xCBC7F4", Offset = "0xCBC7F4", VA = "0xCBC7F4")]
		private void RotateView()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xCBC918", Offset = "0xCBC918", VA = "0xCBC918")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[RequireComponent(typeof(Canvas))]
	public class Highlighter : MonoBehaviour
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Canvas canvas;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PhotonVoiceView photonVoiceView;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image recorderSprite;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image speakerSprite;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text bufferLagText;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool showSpeakerLag;

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xCBC9A8", Offset = "0xCBC9A8", VA = "0xCBC9A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xCBCBE8", Offset = "0xCBCBE8", VA = "0xCBCBE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xCBCD64", Offset = "0xCBCD64", VA = "0xCBCD64")]
		private void VoiceDemoUI_DebugToggled(bool debugMode)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xCBCD70", Offset = "0xCBCD70", VA = "0xCBCD70")]
		private void ChangePOV_CameraChanged(Camera camera)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xCBCD8C", Offset = "0xCBCD8C", VA = "0xCBCD8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xCBCEA4", Offset = "0xCBCEA4", VA = "0xCBCEA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xCBD004", Offset = "0xCBD004", VA = "0xCBD004")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xCBD11C", Offset = "0xCBD11C", VA = "0xCBD11C")]
		public Highlighter()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class OrthographicController : ThirdPersonController
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float smoothing;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 offset;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xCBD124", Offset = "0xCBD124", VA = "0xCBD124", Slot = "8")]
		protected override void Init()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xCBD144", Offset = "0xCBD144", VA = "0xCBD144", Slot = "9")]
		protected override void SetCamera()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xCBD1B4", Offset = "0xCBD1B4", VA = "0xCBD1B4", Slot = "14")]
		protected override void Move(float h, float v)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xCBD348", Offset = "0xCBD348", VA = "0xCBD348")]
		private void CameraFollow()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xCBD41C", Offset = "0xCBD41C", VA = "0xCBD41C")]
		public OrthographicController()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class ThirdPersonController : BaseController
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float movingTurnSpeed;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xCBD1CC", Offset = "0xCBD1CC", VA = "0xCBD1CC", Slot = "14")]
		protected override void Move(float h, float v)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xCBD438", Offset = "0xCBD438", VA = "0xCBD438")]
		public ThirdPersonController()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class VoiceDemoUI : MonoBehaviour
	{
		[Token(Token = "0x2000049")]
		public delegate void OnDebugToggle(bool debugMode);

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text punState;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text voiceState;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PhotonVoiceNetwork punVoiceNetwork;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Canvas canvas;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button punSwitch;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text punSwitchText;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button voiceSwitch;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Text voiceSwitchText;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button calibrateButton;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Text calibrateText;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text voiceDebugText;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Recorder recorder;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject inGameSettings;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject globalSettings;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text devicesInfoText;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GameObject debugGO;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool debugMode;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float volumeBeforeMute;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private DebugLevel previousDebugLevel;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private int calibrationMilliSeconds;

		[Token(Token = "0x17000015")]
		public bool DebugMode
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xCBD450", Offset = "0xCBD450", VA = "0xCBD450")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xCBD458", Offset = "0xCBD458", VA = "0xCBD458")]
			set
			{
			}
		}

		[Token(Token = "0x14000004")]
		public static event OnDebugToggle DebugToggled
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xCBCB30", Offset = "0xCBCB30", VA = "0xCBCB30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xCBCCAC", Offset = "0xCBCCAC", VA = "0xCBCCAC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xCBD588", Offset = "0xCBD588", VA = "0xCBD588")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xCBD5E4", Offset = "0xCBD5E4", VA = "0xCBD5E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xCBD7E8", Offset = "0xCBD7E8", VA = "0xCBD7E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xCBD9EC", Offset = "0xCBD9EC", VA = "0xCBD9EC")]
		private void CharacterInstantiation_CharacterInstantiated(GameObject character)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xCBDA98", Offset = "0xCBDA98", VA = "0xCBDA98")]
		private void InitToggles(Toggle[] toggles)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xCBDE18", Offset = "0xCBDE18", VA = "0xCBDE18")]
		private void BetterToggle_ToggleValueChanged(Toggle toggle)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xCBE16C", Offset = "0xCBE16C", VA = "0xCBE16C")]
		private void OnCameraChanged(Camera newCamera)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xCBE188", Offset = "0xCBE188", VA = "0xCBE188")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xCBE728", Offset = "0xCBE728", VA = "0xCBE728")]
		private void PunSwitchOnClick()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xCBE7F8", Offset = "0xCBE7F8", VA = "0xCBE7F8")]
		private void VoiceSwitchOnClick()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xCBE878", Offset = "0xCBE878", VA = "0xCBE878")]
		private void CalibrateButtonOnClick()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xCBE914", Offset = "0xCBE914", VA = "0xCBE914")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xCBEB24", Offset = "0xCBEB24", VA = "0xCBEB24")]
		private void PunClientStateChanged(ClientState fromState, ClientState toState)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xCBF0EC", Offset = "0xCBF0EC", VA = "0xCBF0EC")]
		private void VoiceClientStateChanged(ClientState fromState, ClientState toState)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xCBECB8", Offset = "0xCBECB8", VA = "0xCBECB8")]
		private void UpdateUiBasedOnVoiceState(ClientState voiceClientState)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xCBF0F4", Offset = "0xCBF0F4", VA = "0xCBF0F4")]
		public VoiceDemoUI()
		{
		}
	}
}
namespace Photon.Voice.Unity.Demos
{
	[Token(Token = "0x200004A")]
	public class BackgroundMusicController : MonoBehaviour
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text volumeText;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Slider volumeSlider;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float initialVolume;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xCBF1B0", Offset = "0xCBF1B0", VA = "0xCBF1B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xCBF2F0", Offset = "0xCBF2F0", VA = "0xCBF2F0")]
		private void OnVolumeChanged(float newValue)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xCBF3BC", Offset = "0xCBF3BC", VA = "0xCBF3BC")]
		public BackgroundMusicController()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class SidebarToggle : MonoBehaviour
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button sidebarButton;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform panelsHolder;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float sidebarWidth;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool sidebarOpen;

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xCBF3CC", Offset = "0xCBF3CC", VA = "0xCBF3CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xCBF49C", Offset = "0xCBF49C", VA = "0xCBF49C")]
		[ContextMenu("ToggleSidebar")]
		private void ToggleSidebar()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xCBF484", Offset = "0xCBF484", VA = "0xCBF484")]
		private void ToggleSidebar(bool open)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xCBF500", Offset = "0xCBF500", VA = "0xCBF500")]
		public SidebarToggle()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public static class UiExtensions
	{
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xCBF4B4", Offset = "0xCBF4B4", VA = "0xCBF4B4")]
		public static void SetPosX(this RectTransform rectTransform, float x)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xCBF518", Offset = "0xCBF518", VA = "0xCBF518")]
		public static void SetHeight(this RectTransform rectTransform, float h)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xCBF530", Offset = "0xCBF530", VA = "0xCBF530")]
		public static void SetValue(this Toggle toggle, bool isOn)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xCBF548", Offset = "0xCBF548", VA = "0xCBF548")]
		public static void SetValue(this Slider slider, float v)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xCBF568", Offset = "0xCBF568", VA = "0xCBF568")]
		public static void SetValue(this InputField inputField, string v)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xCBF57C", Offset = "0xCBF57C", VA = "0xCBF57C")]
		public static void DestroyChildren(this Transform transform)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xCBF684", Offset = "0xCBF684", VA = "0xCBF684")]
		public static void Hide(this CanvasGroup canvasGroup, bool blockRaycasts = false, bool interactable = false)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xCBF6D4", Offset = "0xCBF6D4", VA = "0xCBF6D4")]
		public static void Show(this CanvasGroup canvasGroup, bool blockRaycasts = true, bool interactable = true)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xCBF724", Offset = "0xCBF724", VA = "0xCBF724")]
		public static bool IsHidden(this CanvasGroup canvasGroup)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xCBF748", Offset = "0xCBF748", VA = "0xCBF748")]
		public static bool IsShown(this CanvasGroup canvasGroup)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xCBF76C", Offset = "0xCBF76C", VA = "0xCBF76C")]
		public static void SetSingleOnClickCallback(this Button button, UnityAction action)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xCBF7B0", Offset = "0xCBF7B0", VA = "0xCBF7B0")]
		public static void SetSingleOnValueChangedCallback(this Toggle toggle, UnityAction<bool> action)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xCBF81C", Offset = "0xCBF81C", VA = "0xCBF81C")]
		public static void SetSingleOnValueChangedCallback(this InputField inputField, UnityAction<string> action)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xCBF888", Offset = "0xCBF888", VA = "0xCBF888")]
		public static void SetSingleOnEndEditCallback(this InputField inputField, UnityAction<string> action)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xCBF8F4", Offset = "0xCBF8F4", VA = "0xCBF8F4")]
		public static void SetSingleOnValueChangedCallback(this Dropdown inputField, UnityAction<int> action)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xCBF284", Offset = "0xCBF284", VA = "0xCBF284")]
		public static void SetSingleOnValueChangedCallback(this Slider slider, UnityAction<float> action)
		{
		}
	}
}
namespace Photon.Voice.Unity.Demos.DemoVoiceUI
{
	[Token(Token = "0x200004D")]
	public class CodecSettingsUI : MonoBehaviour
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Dropdown frameDurationDropdown;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Dropdown samplingRateDropdown;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InputField bitrateInputField;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Recorder recorder;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<string> frameDurationOptions;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<string> samplingRateOptions;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xCBF960", Offset = "0xCBF960", VA = "0xCBF960")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xCBFC70", Offset = "0xCBFC70", VA = "0xCBFC70")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xCBFC90", Offset = "0xCBFC90", VA = "0xCBFC90")]
		private void OnBitrateChanged(string newBitrateString)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xCBFCF8", Offset = "0xCBFCF8", VA = "0xCBFCF8")]
		private void OnFrameDurationChanged(int index)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xCBFD58", Offset = "0xCBFD58", VA = "0xCBFD58")]
		private void OnSamplingRateChanged(int index)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xCBFB2C", Offset = "0xCBFB2C", VA = "0xCBFB2C")]
		private void InitFrameDuration()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xCBFBB8", Offset = "0xCBFBB8", VA = "0xCBFBB8")]
		private void InitSamplingRate()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xCBFC20", Offset = "0xCBFC20", VA = "0xCBFC20")]
		private void InitBitrate()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xCBFDB8", Offset = "0xCBFDB8", VA = "0xCBFDB8")]
		public CodecSettingsUI()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[RequireComponent(typeof(VoiceConnection), typeof(ConnectAndJoin))]
	public class DemoVoiceUI : MonoBehaviour, IInRoomCallbacks, IMatchmakingCallbacks
	{
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text connectionStatusText;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text serverStatusText;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text roomStatusText;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text inputWarningText;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text rttText;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text rttVariationText;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text packetLossWarningText;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InputField localNicknameText;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Toggle debugEchoToggle;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Toggle reliableTransmissionToggle;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Toggle encryptionToggle;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject webRtcDspGameObject;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Toggle aecToggle;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Toggle aecHighPassToggle;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InputField reverseStreamDelayInputField;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Toggle noiseSuppressionToggle;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Toggle agcToggle;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Slider agcCompressionGainSlider;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Toggle vadToggle;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Toggle muteToggle;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Toggle streamAudioClipToggle;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Toggle audioToneToggle;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Toggle dspToggle;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Toggle highPassToggle;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Toggle photonVadToggle;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject microphoneSetupGameObject;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private bool defaultTransmitEnabled;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private int screenWidth;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private int screenHeight;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private bool fullScreen;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private InputField roomNameInputField;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private InputField globalMinDelaySoftInputField;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private InputField globalMaxDelaySoftInputField;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private InputField globalMaxDelayHardInputField;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private int rttYellowThreshold;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private int rttRedThreshold;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private int rttVariationYellowThreshold;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[SerializeField]
		private int rttVariationRedThreshold;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private GameObject compressionGainGameObject;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Text compressionGainText;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private GameObject aecOptionsGameObject;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Transform RemoteVoicesPanel;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		protected VoiceConnection voiceConnection;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private WebRtcAudioDsp voiceAudioPreprocessor;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private ConnectAndJoin connectAndJoin;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private readonly Color warningColor;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private readonly Color okColor;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private readonly Color redColor;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private readonly Color defaultColor;

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xCC030C", Offset = "0xCC030C", VA = "0xCC030C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xCC0FF0", Offset = "0xCC0FF0", VA = "0xCC0FF0", Slot = "16")]
		protected virtual void SetDefaults()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xCC101C", Offset = "0xCC101C", VA = "0xCC101C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xCC10B8", Offset = "0xCC10B8", VA = "0xCC10B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xCC0F54", Offset = "0xCC0F54", VA = "0xCC0F54")]
		private void GetSavedNickname()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xCC1154", Offset = "0xCC1154", VA = "0xCC1154", Slot = "17")]
		protected virtual void OnSpeakerCreated(Speaker speaker)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xCC1278", Offset = "0xCC1278", VA = "0xCC1278")]
		private void OnRemoteVoiceRemove(Speaker speaker)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xCC131C", Offset = "0xCC131C", VA = "0xCC131C")]
		private void ToggleMute(bool isOn)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xCC1568", Offset = "0xCC1568", VA = "0xCC1568", Slot = "18")]
		protected virtual void ToggleIsRecording(bool isRecording)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xCC1598", Offset = "0xCC1598", VA = "0xCC1598")]
		private void ToggleDebugEcho(bool isOn)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xCC15C8", Offset = "0xCC15C8", VA = "0xCC15C8")]
		private void ToggleReliable(bool isOn)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xCC15F8", Offset = "0xCC15F8", VA = "0xCC15F8")]
		private void ToggleEncryption(bool isOn)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xCC1628", Offset = "0xCC1628", VA = "0xCC1628")]
		private void ToggleAEC(bool isOn)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xCC166C", Offset = "0xCC166C", VA = "0xCC166C")]
		private void ToggleNoiseSuppression(bool isOn)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xCC168C", Offset = "0xCC168C", VA = "0xCC168C")]
		private void ToggleAGC(bool isOn)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xCC16D0", Offset = "0xCC16D0", VA = "0xCC16D0")]
		private void ToggleVAD(bool isOn)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xCC16F0", Offset = "0xCC16F0", VA = "0xCC16F0")]
		private void ToggleHighPass(bool isOn)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xCC1710", Offset = "0xCC1710", VA = "0xCC1710")]
		private void ToggleDsp(bool isOn)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xCC1770", Offset = "0xCC1770", VA = "0xCC1770")]
		private void ToggleAudioClipStreaming(bool isOn)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xCC1864", Offset = "0xCC1864", VA = "0xCC1864")]
		private void ToggleAudioToneFactory(bool isOn)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xCC1A5C", Offset = "0xCC1A5C", VA = "0xCC1A5C")]
		private void TogglePhotonVAD(bool isOn)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xCC1A8C", Offset = "0xCC1A8C", VA = "0xCC1A8C")]
		private void ToggleAecHighPass(bool isOn)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xCC1AAC", Offset = "0xCC1AAC", VA = "0xCC1AAC")]
		private void OnAgcCompressionGainChanged(float agcCompressionGain)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xCC1B7C", Offset = "0xCC1B7C", VA = "0xCC1B7C")]
		private void OnGlobalPlaybackDelayMinSoftChanged(string newMinDelaySoftString)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xCC1C4C", Offset = "0xCC1C4C", VA = "0xCC1C4C")]
		private void OnGlobalPlaybackDelayMaxSoftChanged(string newMaxDelaySoftString)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xCC1D18", Offset = "0xCC1D18", VA = "0xCC1D18")]
		private void OnGlobalPlaybackDelayMaxHardChanged(string newMaxDelayHardString)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xCC1DE4", Offset = "0xCC1DE4", VA = "0xCC1DE4")]
		private void OnReverseStreamDelayChanged(string newReverseStreamString)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xCC1E70", Offset = "0xCC1E70", VA = "0xCC1E70")]
		private void UpdateSyncedNickname(string nickname)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xCC1F18", Offset = "0xCC1F18", VA = "0xCC1F18")]
		private void JoinOrCreateRoom(string roomName)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xCC2034", Offset = "0xCC2034", VA = "0xCC2034", Slot = "19")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xCC25C0", Offset = "0xCC25C0", VA = "0xCC25C0")]
		private void SetTextColor(int textValue, Text text, int yellowThreshold, int redThreshold)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xCC2588", Offset = "0xCC2588", VA = "0xCC2588")]
		private void ResetTextColor(Text text)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xCC0478", Offset = "0xCC0478", VA = "0xCC0478")]
		private void InitUiCallbacks()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xCC0B04", Offset = "0xCC0B04", VA = "0xCC0B04")]
		private void InitUiValues()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xCC2708", Offset = "0xCC2708", VA = "0xCC2708")]
		private void SetRoomDebugText()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xCC2A18", Offset = "0xCC2A18", VA = "0xCC2A18", Slot = "20")]
		protected virtual void OnActorPropertiesChanged(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xCC2A88", Offset = "0xCC2A88", VA = "0xCC2A88", Slot = "4")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerEnteredRoom(Player newPlayer)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xCC2A8C", Offset = "0xCC2A8C", VA = "0xCC2A8C", Slot = "5")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerLeftRoom(Player otherPlayer)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xCC2A90", Offset = "0xCC2A90", VA = "0xCC2A90", Slot = "6")]
		private void Photon.Realtime.IInRoomCallbacks.OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xCC2A94", Offset = "0xCC2A94", VA = "0xCC2A94", Slot = "7")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xCC2AA4", Offset = "0xCC2AA4", VA = "0xCC2AA4", Slot = "8")]
		private void Photon.Realtime.IInRoomCallbacks.OnMasterClientSwitched(Player newMasterClient)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xCC2AA8", Offset = "0xCC2AA8", VA = "0xCC2AA8", Slot = "9")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xCC2AAC", Offset = "0xCC2AAC", VA = "0xCC2AAC", Slot = "10")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnCreatedRoom()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xCC2AB0", Offset = "0xCC2AB0", VA = "0xCC2AB0", Slot = "11")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnCreateRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xCC2AB4", Offset = "0xCC2AB4", VA = "0xCC2AB4", Slot = "12")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnJoinedRoom()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xCC2AB8", Offset = "0xCC2AB8", VA = "0xCC2AB8", Slot = "13")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnJoinRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xCC2ABC", Offset = "0xCC2ABC", VA = "0xCC2ABC", Slot = "14")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnJoinRandomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xCC2AC0", Offset = "0xCC2AC0", VA = "0xCC2AC0", Slot = "15")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnLeftRoom()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xCC2B34", Offset = "0xCC2B34", VA = "0xCC2B34")]
		public DemoVoiceUI()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public struct MicRef
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Recorder.MicType MicType;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int PhotonId;

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xCC2C78", Offset = "0xCC2C78", VA = "0xCC2C78")]
		public MicRef(string name, int id)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xCC2C8C", Offset = "0xCC2C8C", VA = "0xCC2C8C")]
		public MicRef(string name)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xCC2CA0", Offset = "0xCC2CA0", VA = "0xCC2CA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	public class MicrophoneDropdownFiller : MonoBehaviour
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<MicRef> micOptions;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Dropdown micDropdown;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Recorder recorder;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("RefreshButton")]
		private GameObject refreshButton;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[FormerlySerializedAs("ToggleButton")]
		private GameObject toggleButton;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Toggle photonToggle;

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xCC2CEC", Offset = "0xCC2CEC", VA = "0xCC2CEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xCC2D68", Offset = "0xCC2D68", VA = "0xCC2D68")]
		private void SetupMicDropdown()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xCC3070", Offset = "0xCC3070", VA = "0xCC3070")]
		private void MicDropdownValueChanged(MicRef mic)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xCC3104", Offset = "0xCC3104", VA = "0xCC3104")]
		private void SetCurrentValue()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xCC34A0", Offset = "0xCC34A0", VA = "0xCC34A0")]
		public void PhotonMicToggled(bool on)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xCC2D50", Offset = "0xCC2D50", VA = "0xCC2D50")]
		public void RefreshMicrophones()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xCC3534", Offset = "0xCC3534", VA = "0xCC3534")]
		private void PhotonVoiceCreated()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xCC354C", Offset = "0xCC354C", VA = "0xCC354C")]
		public MicrophoneDropdownFiller()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public static class PhotonDemoExtensions
	{
		[Token(Token = "0x40001CA")]
		internal const string IS_MUTED_PROPERTY_KEY = "mute";

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xCC1384", Offset = "0xCC1384", VA = "0xCC1384")]
		public static bool Mute(this Player player)
		{
			return default(bool);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xCC1478", Offset = "0xCC1478", VA = "0xCC1478")]
		public static bool Unmute(this Player player)
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xCC263C", Offset = "0xCC263C", VA = "0xCC263C")]
		public static bool IsMuted(this Player player)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000053")]
	[RequireComponent(typeof(Speaker))]
	public class RemoteSpeakerUI : MonoBehaviour, IInRoomCallbacks
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text nameText;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Image remoteIsMuting;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image remoteIsTalking;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InputField minDelaySoftInputField;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InputField maxDelaySoftInputField;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private InputField maxDelayHardInputField;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text bufferLagText;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Speaker speaker;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected VoiceConnection voiceConnection;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xCC35DC", Offset = "0xCC35DC", VA = "0xCC35DC", Slot = "9")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xCC38F4", Offset = "0xCC38F4", VA = "0xCC38F4")]
		private void OnMinDelaySoftChanged(string newMinDelaySoftString)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xCC39C4", Offset = "0xCC39C4", VA = "0xCC39C4")]
		private void OnMaxDelaySoftChanged(string newMaxDelaySoftString)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xCC3A90", Offset = "0xCC3A90", VA = "0xCC3A90")]
		private void OnMaxDelayHardChanged(string newMaxDelayHardString)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xCC3B5C", Offset = "0xCC3B5C", VA = "0xCC3B5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xCC3C3C", Offset = "0xCC3C3C", VA = "0xCC3C3C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xCC37DC", Offset = "0xCC37DC", VA = "0xCC37DC")]
		private void SetNickname()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xCC38C0", Offset = "0xCC38C0", VA = "0xCC38C0")]
		private void SetMutedState()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xCC3C6C", Offset = "0xCC3C6C", VA = "0xCC3C6C", Slot = "10")]
		protected virtual void SetMutedState(bool isMuted)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xCC3C8C", Offset = "0xCC3C8C", VA = "0xCC3C8C", Slot = "11")]
		protected virtual void OnActorPropertiesChanged(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xCC3CD8", Offset = "0xCC3CD8", VA = "0xCC3CD8", Slot = "12")]
		public virtual void Init(VoiceConnection vC)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xCC3D0C", Offset = "0xCC3D0C", VA = "0xCC3D0C", Slot = "4")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerEnteredRoom(Player newPlayer)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xCC3D10", Offset = "0xCC3D10", VA = "0xCC3D10", Slot = "5")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerLeftRoom(Player otherPlayer)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xCC3D14", Offset = "0xCC3D14", VA = "0xCC3D14", Slot = "6")]
		private void Photon.Realtime.IInRoomCallbacks.OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xCC3D18", Offset = "0xCC3D18", VA = "0xCC3D18", Slot = "7")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xCC3D24", Offset = "0xCC3D24", VA = "0xCC3D24", Slot = "8")]
		private void Photon.Realtime.IInRoomCallbacks.OnMasterClientSwitched(Player newMasterClient)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xCC3D28", Offset = "0xCC3D28", VA = "0xCC3D28")]
		public RemoteSpeakerUI()
		{
		}
	}
}
namespace Photon.Realtime.Demo
{
	[Token(Token = "0x2000054")]
	public class ConnectAndJoinRandomLb : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks, ILobbyCallbacks
	{
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AppSettings appSettings;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LoadBalancingClient lbc;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ConnectionHandler ch;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text StateUiText;

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xCC3D30", Offset = "0xCC3D30", VA = "0xCC3D30")]
		public void Start()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xCC3E90", Offset = "0xCC3E90", VA = "0xCC3E90")]
		public void Update()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xCC3FC4", Offset = "0xCC3FC4", VA = "0xCC3FC4", Slot = "4")]
		public void OnConnected()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xCC3FC8", Offset = "0xCC3FC8", VA = "0xCC3FC8", Slot = "5")]
		public void OnConnectedToMaster()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xCC404C", Offset = "0xCC404C", VA = "0xCC404C", Slot = "6")]
		public void OnDisconnected(DisconnectCause cause)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xCC4138", Offset = "0xCC4138", VA = "0xCC4138", Slot = "8")]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xCC413C", Offset = "0xCC413C", VA = "0xCC413C", Slot = "9")]
		public void OnCustomAuthenticationFailed(string debugMessage)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xCC4140", Offset = "0xCC4140", VA = "0xCC4140", Slot = "7")]
		public void OnRegionListReceived(RegionHandler regionHandler)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xCC421C", Offset = "0xCC421C", VA = "0xCC421C", Slot = "19")]
		public void OnRoomListUpdate(List<RoomInfo> roomList)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xCC4220", Offset = "0xCC4220", VA = "0xCC4220", Slot = "20")]
		public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xCC4224", Offset = "0xCC4224", VA = "0xCC4224", Slot = "17")]
		public void OnJoinedLobby()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xCC4228", Offset = "0xCC4228", VA = "0xCC4228", Slot = "18")]
		public void OnLeftLobby()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xCC422C", Offset = "0xCC422C", VA = "0xCC422C", Slot = "10")]
		public void OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xCC4230", Offset = "0xCC4230", VA = "0xCC4230", Slot = "11")]
		public void OnCreatedRoom()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xCC4234", Offset = "0xCC4234", VA = "0xCC4234", Slot = "12")]
		public void OnCreateRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xCC4238", Offset = "0xCC4238", VA = "0xCC4238", Slot = "13")]
		public void OnJoinedRoom()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xCC42A0", Offset = "0xCC42A0", VA = "0xCC42A0", Slot = "14")]
		public void OnJoinRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xCC42A4", Offset = "0xCC42A4", VA = "0xCC42A4", Slot = "15")]
		public void OnJoinRandomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xCC4358", Offset = "0xCC4358", VA = "0xCC4358", Slot = "16")]
		public void OnLeftRoom()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xCC435C", Offset = "0xCC435C", VA = "0xCC435C")]
		private void OnRegionPingCompleted(RegionHandler regionHandler)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xCC4480", Offset = "0xCC4480", VA = "0xCC4480")]
		public ConnectAndJoinRandomLb()
		{
		}
	}
}
namespace Photon.Chat.UtilityScripts
{
	[Token(Token = "0x2000055")]
	public class EventSystemSpawner : MonoBehaviour
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0xCC44E8", Offset = "0xCC44E8", VA = "0xCC44E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xCC45F0", Offset = "0xCC45F0", VA = "0xCC45F0")]
		public EventSystemSpawner()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class OnStartDelete : MonoBehaviour
	{
		[Token(Token = "0x6000253")]
		[Address(RVA = "0xCC45F8", Offset = "0xCC45F8", VA = "0xCC45F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xCC4664", Offset = "0xCC4664", VA = "0xCC4664")]
		public OnStartDelete()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[RequireComponent(typeof(Text))]
	public class TextButtonTransition : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Text _text;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Selectable Selectable;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color NormalColor;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color HoverColor;

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xCC466C", Offset = "0xCC466C", VA = "0xCC466C")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xCC46BC", Offset = "0xCC46BC", VA = "0xCC46BC")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xCC46EC", Offset = "0xCC46EC", VA = "0xCC46EC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xCC471C", Offset = "0xCC471C", VA = "0xCC471C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xCC47CC", Offset = "0xCC47CC", VA = "0xCC47CC", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xCC487C", Offset = "0xCC487C", VA = "0xCC487C")]
		public TextButtonTransition()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[RequireComponent(typeof(Text))]
	public class TextToggleIsOnTransition : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle toggle;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text _text;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color NormalOnColor;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color NormalOffColor;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color HoverOnColor;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color HoverOffColor;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isHover;

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xCC4898", Offset = "0xCC4898", VA = "0xCC4898")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xCC49DC", Offset = "0xCC49DC", VA = "0xCC49DC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xCC4978", Offset = "0xCC4978", VA = "0xCC4978")]
		public void OnValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xCC4A84", Offset = "0xCC4A84", VA = "0xCC4A84", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xCC4AF8", Offset = "0xCC4AF8", VA = "0xCC4AF8", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xCC4B68", Offset = "0xCC4B68", VA = "0xCC4B68")]
		public TextToggleIsOnTransition()
		{
		}
	}
}
namespace FXV
{
	[Token(Token = "0x2000059")]
	public enum FXVRenderSidesOptions
	{
		[Token(Token = "0x40001E4")]
		OUTSIDE_ONLY,
		[Token(Token = "0x40001E5")]
		OUTSIDE_AND_INSIDE,
		[Token(Token = "0x40001E6")]
		INSIDE_ONLY
	}
	[Token(Token = "0x200005A")]
	public class FXVShield : MonoBehaviour
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool shieldActive;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float shieldActivationSpeed;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float shieldActivationRim;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float hitEffectDuration;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Light shieldLight;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Material hitMaterial;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color hitColor;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool autoHitPatternScale;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public FXVRenderSidesOptions renderSides;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Color lightColor;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject inside;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Renderer insideRenderer;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material baseMaterial;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material activationMaterial;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material postprocessMaterial;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material postprocessActivationMaterial;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private CommandBuffer cmdBuffer;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Renderer myRenderer;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float shieldActivationTime;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float shieldActivationDir;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int activationTimeProperty;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int shieldDirectionProperty;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int currentHitIndex;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, Mesh> insideMeshes;

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xCC4B8C", Offset = "0xCC4B8C", VA = "0xCC4B8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xCC592C", Offset = "0xCC592C", VA = "0xCC592C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xCC5C20", Offset = "0xCC5C20", VA = "0xCC5C20")]
		public void SetHitMaterial(Material newMat)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xCC5400", Offset = "0xCC5400", VA = "0xCC5400")]
		public void SetMaterial(Material newMat)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xCC5D14", Offset = "0xCC5D14", VA = "0xCC5D14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xCC5FBC", Offset = "0xCC5FBC", VA = "0xCC5FBC")]
		public bool GetIsShieldActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xCC5FE4", Offset = "0xCC5FE4", VA = "0xCC5FE4")]
		public bool GetIsDuringActivationAnim()
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xCC5FF4", Offset = "0xCC5FF4", VA = "0xCC5FF4")]
		public void SetShieldActive(bool active, bool animated = true)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xCC5C28", Offset = "0xCC5C28", VA = "0xCC5C28")]
		public void SetShieldEffectDirection(Vector3 dir)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xCC6210", Offset = "0xCC6210", VA = "0xCC6210")]
		public void OnHit(Vector3 hitPos, float hitScale)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xCC6320", Offset = "0xCC6320", VA = "0xCC6320")]
		private void AddHitMeshAtPos(Mesh mesh, Vector3 hitPos, float hitScale)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xCC6AE4", Offset = "0xCC6AE4", VA = "0xCC6AE4")]
		public void RenderPostprocess(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xCC6C40", Offset = "0xCC6C40", VA = "0xCC6C40")]
		public Material GetPostprocessMaterial()
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xCC6C5C", Offset = "0xCC6C5C", VA = "0xCC6C5C")]
		public Renderer GetRenderer()
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xCC6C64", Offset = "0xCC6C64", VA = "0xCC6C64")]
		public FXVShield()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class FXVShieldHit : MonoBehaviour
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float lifeTime;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float lifeStart;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float coveringTime;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MeshRenderer myRenderer;

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xCC6D1C", Offset = "0xCC6D1C", VA = "0xCC6D1C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xCC6D20", Offset = "0xCC6D20", VA = "0xCC6D20")]
		private void Update()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xCC6A24", Offset = "0xCC6A24", VA = "0xCC6A24")]
		public void StartHitFX(float time)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xCC6E98", Offset = "0xCC6E98", VA = "0xCC6E98")]
		public FXVShieldHit()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class FXVShieldPostprocess : MonoBehaviour
	{
		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float postprocessPower;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RenderTexture screenTex;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material blendAddMaterial;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material blurHorizontalMaterial;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material blurVerticalMaterial;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<FXVShield> shieldObjects;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color clearToTransparentColor;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CommandBuffer cmdBuffer;

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xCC6EB4", Offset = "0xCC6EB4", VA = "0xCC6EB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xCC7124", Offset = "0xCC7124", VA = "0xCC7124")]
		private void Start()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xCC7128", Offset = "0xCC7128", VA = "0xCC7128")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xCC532C", Offset = "0xCC532C", VA = "0xCC532C")]
		public void AddShield(FXVShield s)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xCC5B90", Offset = "0xCC5B90", VA = "0xCC5B90")]
		public void RemoveShield(FXVShield s)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xCC7130", Offset = "0xCC7130", VA = "0xCC7130")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xCC7230", Offset = "0xCC7230", VA = "0xCC7230")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xCC7714", Offset = "0xCC7714", VA = "0xCC7714")]
		public FXVShieldPostprocess()
		{
		}
	}
}
namespace BrainFailProductions.PolyFew
{
	[Token(Token = "0x200005D")]
	public class CombiningInformation
	{
		[Token(Token = "0x200005E")]
		public enum DiffuseColorSpace
		{
			[Token(Token = "0x4000210")]
			NON_LINEAR,
			[Token(Token = "0x4000211")]
			LINEAR
		}

		[Token(Token = "0x200005F")]
		public enum CompressionType
		{
			[Token(Token = "0x4000213")]
			UNCOMPRESSED,
			[Token(Token = "0x4000214")]
			DXT1,
			[Token(Token = "0x4000215")]
			ETC2_RGB,
			[Token(Token = "0x4000216")]
			PVRTC_RGB4,
			[Token(Token = "0x4000217")]
			ASTC_RGB
		}

		[Token(Token = "0x2000060")]
		public enum CompressionQuality
		{
			[Token(Token = "0x4000219")]
			LOW,
			[Token(Token = "0x400021A")]
			MEDIUM,
			[Token(Token = "0x400021B")]
			HIGH
		}

		[Serializable]
		[Token(Token = "0x2000061")]
		public struct Resolution
		{
			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int width;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int height;
		}

		[Serializable]
		[Token(Token = "0x2000062")]
		public class TextureArrayUserSettings
		{
			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Resolution resolution;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FilterMode filteringMode;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public CompressionType compressionType;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CompressionQuality compressionQuality;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int anisotropicFilteringLevel;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int choiceResolutionW;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int choiceResolutionH;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int choiceFilteringMode;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int choiceCompressionQuality;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int choiceCompressionType;

			[Token(Token = "0x6000287")]
			[Address(RVA = "0xCC87A4", Offset = "0xCC87A4", VA = "0xCC87A4")]
			public TextureArrayUserSettings(Resolution resolution, FilterMode filteringMode, CompressionType compressionType, CompressionQuality compressionQuality = CompressionQuality.MEDIUM, int anisotropicFilteringLevel = 1)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000063")]
		public class TextureArrayGroup
		{
			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TextureArrayUserSettings diffuseArraySettings;

			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TextureArrayUserSettings metallicArraySettings;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextureArrayUserSettings specularArraySettings;

			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TextureArrayUserSettings normalArraySettings;

			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public TextureArrayUserSettings heightArraySettings;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public TextureArrayUserSettings occlusionArraySettings;

			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public TextureArrayUserSettings emissiveArraySettings;

			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public TextureArrayUserSettings detailMaskArraySettings;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public TextureArrayUserSettings detailAlbedoArraySettings;

			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public TextureArrayUserSettings detailNormalArraySettings;

			[Token(Token = "0x6000288")]
			[Address(RVA = "0xCC8804", Offset = "0xCC8804", VA = "0xCC8804")]
			public void InitializeDefaultArraySettings(Resolution resolution, FilterMode filteringMode, CompressionType compressionType, CompressionQuality compressionQuality = CompressionQuality.MEDIUM, int anisotropicFilteringLevel = 1)
			{
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0xCC879C", Offset = "0xCC879C", VA = "0xCC879C")]
			public TextureArrayGroup()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000064")]
		public class MaterialProperties
		{
			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool foldOut;

			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int texArrIndex;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int matIndex;

			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string materialName;

			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Material originalMaterial;

			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Color albedoTint;

			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector4 uvTileOffset;

			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public float normalIntensity;

			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float occlusionIntensity;

			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float smoothnessIntensity;

			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float glossMapScale;

			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float metalIntensity;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public Color emissionColor;

			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector4 detailUVTileOffset;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public float alphaCutoff;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Color specularColor;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public float detailNormalScale;

			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public float heightIntensity;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public float uvSec;

			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			public int alphaMode;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public bool specularWorkflow;

			[Token(Token = "0x600028A")]
			[Address(RVA = "0xCC8A84", Offset = "0xCC8A84", VA = "0xCC8A84")]
			public bool IsSameAs(MaterialProperties toCompare)
			{
				return default(bool);
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0xCC8CBC", Offset = "0xCC8CBC", VA = "0xCC8CBC")]
			public static Texture2D NewTexture()
			{
				return null;
			}

			[Token(Token = "0x600028C")]
			[Address(RVA = "0xCC8D88", Offset = "0xCC8D88", VA = "0xCC8D88")]
			public void BurnAttrToImg(ref Texture2D burnOn, int index, int textureArrayIndex)
			{
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0xCC90C4", Offset = "0xCC90C4", VA = "0xCC90C4")]
			public void FillPropertiesFromMaterial(Material material, CombiningInformation combineInfo)
			{
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0xCC96BC", Offset = "0xCC96BC", VA = "0xCC96BC")]
			public MaterialProperties()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000065")]
		public class MeshData
		{
			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<MeshFilter> meshFilters;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<MeshRenderer> meshRenderers;

			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<SkinnedMeshRenderer> skinnedMeshRenderers;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Material[] originalMaterials;

			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Mesh[] outputMeshes;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Matrix4x4[] outputMatrices;

			[Token(Token = "0x600028F")]
			[Address(RVA = "0xCC971C", Offset = "0xCC971C", VA = "0xCC971C")]
			public MeshData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000066")]
		public class CombineMetaData
		{
			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material material;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MaterialProperties materialProperties;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MaterialProperties tempMaterialProperties;

			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MeshData> meshesData;

			[Token(Token = "0x6000290")]
			[Address(RVA = "0xCC9724", Offset = "0xCC9724", VA = "0xCC9724")]
			public CombineMetaData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000067")]
		public class MaterialEntity
		{
			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<CombineMetaData> combinedMats;

			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int textArrIndex;

			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Texture2D diffuseMap;

			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Texture2D metallicMap;

			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Texture2D specularMap;

			[Token(Token = "0x4000256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Texture2D normalMap;

			[Token(Token = "0x4000257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Texture2D heightMap;

			[Token(Token = "0x4000258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Texture2D occlusionMap;

			[Token(Token = "0x4000259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Texture2D emissionMap;

			[Token(Token = "0x400025A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Texture2D detailMaskMap;

			[Token(Token = "0x400025B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Texture2D detailAlbedoMap;

			[Token(Token = "0x400025C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Texture2D detailNormalMap;

			[Token(Token = "0x6000291")]
			[Address(RVA = "0xCC97A0", Offset = "0xCC97A0", VA = "0xCC97A0")]
			public bool HasAnyTextures()
			{
				return default(bool);
			}

			[Token(Token = "0x6000292")]
			[Address(RVA = "0xCC9978", Offset = "0xCC9978", VA = "0xCC9978")]
			public MaterialEntity()
			{
			}
		}

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<MaterialEntity> materialEntities;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextureArrayGroup textureArraysSettings;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DiffuseColorSpace diffuseColorSpace;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Material[] combinedMaterials;

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xCC779C", Offset = "0xCC779C", VA = "0xCC779C")]
		public bool ShouldGenerateMetallicArray()
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xCC7950", Offset = "0xCC7950", VA = "0xCC7950")]
		public bool ShouldGenerateSpecularArray()
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xCC7B04", Offset = "0xCC7B04", VA = "0xCC7B04")]
		public bool ShouldGenerateNormalArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xCC7CB8", Offset = "0xCC7CB8", VA = "0xCC7CB8")]
		public bool ShouldGenerateHeightArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xCC7E6C", Offset = "0xCC7E6C", VA = "0xCC7E6C")]
		public bool ShouldGenerateOcclusionArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xCC8020", Offset = "0xCC8020", VA = "0xCC8020")]
		public bool ShouldGenerateEmissionArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xCC81D4", Offset = "0xCC81D4", VA = "0xCC81D4")]
		public bool ShouldGenerateDetailMaskArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xCC8388", Offset = "0xCC8388", VA = "0xCC8388")]
		public bool ShouldGenerateDetailAlbedoArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xCC853C", Offset = "0xCC853C", VA = "0xCC853C")]
		public bool ShouldGenerateDetailNormalArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xCC86F0", Offset = "0xCC86F0", VA = "0xCC86F0")]
		public CombiningInformation()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[ExecuteInEditMode]
	public class ObjectMaterialLinks : MonoBehaviour
	{
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CombiningInformation.MaterialEntity> linkedEntities;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<PolyfewRuntime.MaterialProperties> materialsProperties;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D linkedAttrImg;

		[Token(Token = "0x17000016")]
		public List<CombiningInformation.MaterialEntity> linkedMaterialEntities
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0xCC99F4", Offset = "0xCC99F4", VA = "0xCC99F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000294")]
			[Address(RVA = "0xCC99FC", Offset = "0xCC99FC", VA = "0xCC99FC")]
			set
			{
			}
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xCC9D80", Offset = "0xCC9D80", VA = "0xCC9D80")]
		private void Start()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xCCA050", Offset = "0xCCA050", VA = "0xCCA050")]
		public ObjectMaterialLinks()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class PolyFew : MonoBehaviour
	{
		[Token(Token = "0x6000297")]
		[Address(RVA = "0xCCA058", Offset = "0xCCA058", VA = "0xCCA058")]
		public PolyFew()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[ExecuteInEditMode]
	public class RefreshEnforcer : MonoBehaviour
	{
		[Token(Token = "0x6000298")]
		[Address(RVA = "0xCCA060", Offset = "0xCCA060", VA = "0xCCA060")]
		private void Start()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xCCA0B8", Offset = "0xCCA0B8", VA = "0xCCA0B8")]
		private void Update()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xCCA0BC", Offset = "0xCCA0BC", VA = "0xCCA0BC")]
		public RefreshEnforcer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	[DebuggerDisplay("Count = {Count}")]
	public class SerializableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		[Token(Token = "0x200006C")]
		private static class PrimeHelper
		{
			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int[] Primes;

			[Token(Token = "0x60002BB")]
			public static bool IsPrime(int candidate)
			{
				return default(bool);
			}

			[Token(Token = "0x60002BC")]
			public static int GetPrime(int min)
			{
				return default(int);
			}

			[Token(Token = "0x60002BD")]
			public static int ExpandPrime(int oldSize)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200006D")]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly SerializableDictionary<TKey, TValue> _Dictionary;

			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _Version;

			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _Index;

			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private KeyValuePair<TKey, TValue> _Current;

			[Token(Token = "0x1700001E")]
			public KeyValuePair<TKey, TValue> Current
			{
				[Token(Token = "0x60002BF")]
				get
				{
					return default(KeyValuePair<TKey, TValue>);
				}
			}

			[Token(Token = "0x1700001F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002C3")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002C0")]
			internal Enumerator(SerializableDictionary<TKey, TValue> dictionary)
			{
			}

			[Token(Token = "0x60002C1")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002C2")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002C4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int[] _Buckets;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int[] _HashCodes;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int[] _Next;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int _Count;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int _Version;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int _FreeList;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int _FreeCount;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private TKey[] _Keys;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private TValue[] _Values;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IEqualityComparer<TKey> _Comparer;

		[Token(Token = "0x17000017")]
		public Dictionary<TKey, TValue> AsDictionary
		{
			[Token(Token = "0x600029B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public int Count
		{
			[Token(Token = "0x600029C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000019")]
		public TValue this[TKey key, TValue defaultValue]
		{
			[Token(Token = "0x600029D")]
			get
			{
				return (TValue)null;
			}
		}

		[Token(Token = "0x1700001A")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x600029E")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x600029F")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x60002B1")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x60002B2")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60002B6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002A0")]
		public SerializableDictionary()
		{
		}

		[Token(Token = "0x60002A1")]
		public SerializableDictionary(int capacity)
		{
		}

		[Token(Token = "0x60002A2")]
		public SerializableDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x60002A3")]
		public SerializableDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x60002A4")]
		public SerializableDictionary(IDictionary<TKey, TValue> dictionary)
		{
		}

		[Token(Token = "0x60002A5")]
		public SerializableDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x60002A6")]
		public bool ContainsValue(TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002A9")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x60002AA")]
		private void Resize(int newSize, bool forceNewHashCodes)
		{
		}

		[Token(Token = "0x60002AB")]
		private void Resize()
		{
		}

		[Token(Token = "0x60002AC")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		private void Insert(TKey key, TValue value, bool add)
		{
		}

		[Token(Token = "0x60002AE")]
		private void Initialize(int capacity)
		{
		}

		[Token(Token = "0x60002AF")]
		private int FindIndex(TKey key)
		{
			return default(int);
		}

		[Token(Token = "0x60002B0")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		[Token(Token = "0x60002B4")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B5")]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		[Token(Token = "0x60002B7")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60002B9")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class ToleranceSphere : ScriptableObject
	{
		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 worldPosition;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float diameter;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color color;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float preservationStrength;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool isHidden;

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xCCA0C4", Offset = "0xCCA0C4", VA = "0xCCA0C4")]
		public ToleranceSphere(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xCCA148", Offset = "0xCCA148", VA = "0xCCA148")]
		public void SetProperties(ToleranceSphereJson tSphereJson)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xCCA18C", Offset = "0xCCA18C", VA = "0xCCA18C")]
		public void SetProperties(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public class ToleranceSphereJson
	{
		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 worldPosition;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float diameter;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float preservationStrength;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isHidden;

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xCCA1B0", Offset = "0xCCA1B0", VA = "0xCCA1B0")]
		public ToleranceSphereJson(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xCCA234", Offset = "0xCCA234", VA = "0xCCA234")]
		public ToleranceSphereJson(ToleranceSphere toleranceSphere)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xCCA370", Offset = "0xCCA370", VA = "0xCCA370")]
		public void SetProperties(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xCCA2C8", Offset = "0xCCA2C8", VA = "0xCCA2C8")]
		public void DumpFromToleranceSphere(ToleranceSphere toleranceSphere)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xCCA394", Offset = "0xCCA394", VA = "0xCCA394")]
		public void DumpToToleranceSphere(ref ToleranceSphere toleranceSphere)
		{
		}
	}
	[Token(Token = "0x2000070")]
	public static class SystemServices
	{
		[Serializable]
		[Token(Token = "0x2000071")]
		public struct RegexPatterns
		{
			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string netError;

			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string nullOrEmpty;

			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string generalError;

			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string apiMistmatch;

			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string parametersMismatch;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string nothing;
		}

		[Token(Token = "0x2000072")]
		public struct MessagePatternPair
		{
			[Token(Token = "0x17000020")]
			public string patternAppended
			{
				[Token(Token = "0x60002DF")]
				[Address(RVA = "0xCCC9E8", Offset = "0xCCC9E8", VA = "0xCCC9E8")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x60002DE")]
				[Address(RVA = "0xCCC9E0", Offset = "0xCCC9E0", VA = "0xCCC9E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000021")]
			public string parsedMessage
			{
				[Token(Token = "0x60002E1")]
				[Address(RVA = "0xCCC9F8", Offset = "0xCCC9F8", VA = "0xCCC9F8")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x60002E0")]
				[Address(RVA = "0xCCC9F0", Offset = "0xCCC9F0", VA = "0xCCC9F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xCCC4D4", Offset = "0xCCC4D4", VA = "0xCCC4D4")]
			public MessagePatternPair(string patternAppended, string parsedMessage)
			{
			}
		}

		[Token(Token = "0x2000073")]
		public class HTTPMethod
		{
			[Token(Token = "0x2000074")]
			public enum HTTPMethods
			{
				[Token(Token = "0x4000284")]
				POST,
				[Token(Token = "0x4000285")]
				GET
			}

			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string methodName;

			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xCCC108", Offset = "0xCCC108", VA = "0xCCC108")]
			public HTTPMethod(HTTPMethods method)
			{
			}
		}

		[Token(Token = "0x2000075")]
		public enum ImageFormat
		{
			[Token(Token = "0x4000287")]
			PNG,
			[Token(Token = "0x4000288")]
			JPG,
			[Token(Token = "0x4000289")]
			EXR
		}

		[Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class <UnityAsyncGETRequest>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string encodedUrl;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int? timeout;

			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Dictionary<string, string> headers;

			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<string, long> callback;

			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <webRequest>5__2;

			[Token(Token = "0x17000022")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002E7")]
				[Address(RVA = "0xCCCDE0", Offset = "0xCCCDE0", VA = "0xCCCDE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000023")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002E9")]
				[Address(RVA = "0xCCCE28", Offset = "0xCCCE28", VA = "0xCCCE28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xCCA600", Offset = "0xCCA600", VA = "0xCCA600")]
			[DebuggerHidden]
			public <UnityAsyncGETRequest>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xCCCA00", Offset = "0xCCCA00", VA = "0xCCCA00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0xCCCA04", Offset = "0xCCCA04", VA = "0xCCCA04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002E8")]
			[Address(RVA = "0xCCCDE8", Offset = "0xCCCDE8", VA = "0xCCCDE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class <UnityAsyncPOSTRequest>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string baseUrl;

			[Token(Token = "0x4000294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int? timeout;

			[Token(Token = "0x4000295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public byte[] data;

			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Dictionary<string, string> headers;

			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<string, long> callback;

			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UnityWebRequest <webRequest>5__2;

			[Token(Token = "0x17000024")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002ED")]
				[Address(RVA = "0xCCD2A0", Offset = "0xCCD2A0", VA = "0xCCD2A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000025")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002EF")]
				[Address(RVA = "0xCCD2E8", Offset = "0xCCD2E8", VA = "0xCCD2E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xCCAE1C", Offset = "0xCCAE1C", VA = "0xCCAE1C")]
			[DebuggerHidden]
			public <UnityAsyncPOSTRequest>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xCCCE30", Offset = "0xCCCE30", VA = "0xCCCE30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xCCCE34", Offset = "0xCCCE34", VA = "0xCCCE34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xCCD2A8", Offset = "0xCCD2A8", VA = "0xCCD2A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HttpWebRequest request;

			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] postData;

			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HttpWebResponse httpResponse;

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xCCD2F0", Offset = "0xCCD2F0", VA = "0xCCD2F0")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xCCD2F8", Offset = "0xCCD2F8", VA = "0xCCD2F8")]
			internal void <SendHTTPRequestAsync>b__0()
			{
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xCCD4A0", Offset = "0xCCD4A0", VA = "0xCCD4A0")]
			internal void <SendHTTPRequestAsync>b__1()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000079")]
		[CompilerGenerated]
		private struct <SendHTTPRequestAsync>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public byte[] postData;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass7_0 <>8__1;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string baseUrl;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<string, HttpStatusCode?> callback;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int? timeout;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public HTTPMethod requestMethod;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Dictionary<string, string> header;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Dictionary<string, string> requestParameters;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private byte[] <paramsData>5__2;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private TaskAwaiter<Stream> <>u__2;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private TaskAwaiter<string> <>u__3;

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xCCD558", Offset = "0xCCD558", VA = "0xCCD558", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xCCE88C", Offset = "0xCCE88C", VA = "0xCCE88C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HttpWebResponse httpResponse;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HttpWebRequest request;

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xCCE898", Offset = "0xCCE898", VA = "0xCCE898")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xCCE8A0", Offset = "0xCCE8A0", VA = "0xCCE8A0")]
			internal void <AsyncResourceDownload>b__0()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200007B")]
		[CompilerGenerated]
		private struct <AsyncResourceDownload>d__9 : IAsyncStateMachine
		{
			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private <>c__DisplayClass9_0 <>8__1;

			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string resourceUrl;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<byte[], string, HttpStatusCode?> callback;

			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int? timeout;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xCCE958", Offset = "0xCCE958", VA = "0xCCE958", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xCCF660", Offset = "0xCCF660", VA = "0xCCF660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200007D")]
		[CompilerGenerated]
		private struct <AsyncReachabilityCheck>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<bool> callback;

			[Token(Token = "0x40002B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string testUrl;

			[Token(Token = "0x40002B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xCCF708", Offset = "0xCCF708", VA = "0xCCF708", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xCCF978", Offset = "0xCCF978", VA = "0xCCF978", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200007F")]
		[CompilerGenerated]
		private struct <RunDelayedCommand>d__17 : IAsyncStateMachine
		{
			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float secs;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action command;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0xCCFA18", Offset = "0xCCFA18", VA = "0xCCFA18", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0xCCFC04", Offset = "0xCCFC04", VA = "0xCCFC04", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000080")]
		[CompilerGenerated]
		private struct <WriteTextureAsync>d__19 : IAsyncStateMachine
		{
			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ImageFormat format;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Texture2D texture;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string fileName;

			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string path;

			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<string> callback;

			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private byte[] <data>5__2;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private FileStream <fileStream>5__3;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000301")]
			[Address(RVA = "0xCCFC10", Offset = "0xCCFC10", VA = "0xCCFC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0xCD0328", Offset = "0xCD0328", VA = "0xCD0328", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000081")]
		[CompilerGenerated]
		private struct <WriteBytesAsync>d__20 : IAsyncStateMachine
		{
			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string fullPath;

			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public byte[] data;

			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> callback;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private FileStream <fileStream>5__2;

			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000303")]
			[Address(RVA = "0xCD0334", Offset = "0xCD0334", VA = "0xCD0334", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0xCD07E0", Offset = "0xCD07E0", VA = "0xCD07E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static RegexPatterns regexPatterns;

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xCCA46C", Offset = "0xCCA46C", VA = "0xCCA46C")]
		private static void SetPatterns()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xCCA578", Offset = "0xCCA578", VA = "0xCCA578")]
		[IteratorStateMachine(typeof(<UnityAsyncGETRequest>d__3))]
		public static IEnumerator UnityAsyncGETRequest(string encodedUrl, Action<string, long> callback, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
			return null;
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xCCA628", Offset = "0xCCA628", VA = "0xCCA628")]
		public static void UnityBlockingGETRequest(string encodedUrl, Action<string, long> callback, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xCCA998", Offset = "0xCCA998", VA = "0xCCA998")]
		public static void UnityBlockingPOSTRequest(string baseUrl, Action<string, long> callback, byte[] data, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xCCAD8C", Offset = "0xCCAD8C", VA = "0xCCAD8C")]
		[IteratorStateMachine(typeof(<UnityAsyncPOSTRequest>d__6))]
		public static IEnumerator UnityAsyncPOSTRequest(string baseUrl, Action<string, long> callback, byte[] data, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xCCAE44", Offset = "0xCCAE44", VA = "0xCCAE44")]
		[AsyncStateMachine(typeof(<SendHTTPRequestAsync>d__7))]
		public static Task SendHTTPRequestAsync(string baseUrl, HTTPMethod requestMethod, Action<string, HttpStatusCode?> callback, Dictionary<string, string> requestParameters, byte[] postData, string contentType, [Optional] int? timeout, [Optional] Dictionary<string, string> header)
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xCCAF60", Offset = "0xCCAF60", VA = "0xCCAF60")]
		public static void SendHTTPRequestBlocking(string baseUrl, HTTPMethod requestMethod, Action<string, HttpStatusCode?> callback, Dictionary<string, string> requestParameters, byte[] postData, string contentType, [Optional] int? timeout, [Optional] Dictionary<string, string> header)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xCCBE20", Offset = "0xCCBE20", VA = "0xCCBE20")]
		[AsyncStateMachine(typeof(<AsyncResourceDownload>d__9))]
		public static Task AsyncResourceDownload(string resourceUrl, Action<byte[], string, HttpStatusCode?> callback, [Optional] int? timeout)
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xCCBF04", Offset = "0xCCBF04", VA = "0xCCBF04")]
		[AsyncStateMachine(typeof(<AsyncReachabilityCheck>d__10))]
		public static Task AsyncReachabilityCheck(string testUrl, Action<bool> callback)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xCCBFE0", Offset = "0xCCBFE0", VA = "0xCCBFE0")]
		public static void BlockingReachabilityCheck(string url, Action<bool> callback)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xCCC204", Offset = "0xCCC204", VA = "0xCCC204")]
		public static MessagePatternPair ParseResponseMessage(string message)
		{
			return default(MessagePatternPair);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xCCC4DC", Offset = "0xCCC4DC", VA = "0xCCC4DC")]
		public static bool IsSuccessStatusCode(long statusCode)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xCCBB78", Offset = "0xCCBB78", VA = "0xCCBB78")]
		public static string GetQueryStringFromKeyValues(Dictionary<string, string> parameters)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xCCC4EC", Offset = "0xCCC4EC", VA = "0xCCC4EC")]
		[AsyncStateMachine(typeof(<RunDelayedCommand>d__17))]
		public static Task RunDelayedCommand(float secs, Action command)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xCCC5CC", Offset = "0xCCC5CC", VA = "0xCCC5CC")]
		public static byte[] ReadAllBytes(Stream source)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xCCC808", Offset = "0xCCC808", VA = "0xCCC808")]
		[AsyncStateMachine(typeof(<WriteTextureAsync>d__19))]
		public static Task WriteTextureAsync(Texture2D texture, ImageFormat format, string fileName, string path, Action<string> callback)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xCCC900", Offset = "0xCCC900", VA = "0xCCC900")]
		[AsyncStateMachine(typeof(<WriteBytesAsync>d__20))]
		public static Task WriteBytesAsync(byte[] data, string fullPath, Action<string> callback)
		{
			return null;
		}
	}
}
namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000082")]
	public class DataSet
	{
		[Token(Token = "0x2000083")]
		public struct FaceIndices
		{
			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int vertIdx;

			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int uvIdx;

			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int normIdx;
		}

		[Token(Token = "0x2000084")]
		public class ObjectData
		{
			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<FaceGroupData> faceGroups;

			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<FaceIndices> allFaces;

			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool hasNormals;

			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public bool hasColors;

			[Token(Token = "0x6000313")]
			[Address(RVA = "0xCD0DAC", Offset = "0xCD0DAC", VA = "0xCD0DAC")]
			public ObjectData()
			{
			}
		}

		[Token(Token = "0x2000085")]
		public class FaceGroupData
		{
			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string materialName;

			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<FaceIndices> faces;

			[Token(Token = "0x17000028")]
			public bool IsEmpty
			{
				[Token(Token = "0x6000315")]
				[Address(RVA = "0xCD12B0", Offset = "0xCD12B0", VA = "0xCD12B0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0xCD0E6C", Offset = "0xCD0E6C", VA = "0xCD0E6C")]
			public FaceGroupData()
			{
			}
		}

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<ObjectData> objectList;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Vector3> vertList;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Vector2> uvList;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Vector3> normalList;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Color> colorList;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int unnamedGroupIndex;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ObjectData currObjData;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FaceGroupData currGroup;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool noFaceDefined;

		[Token(Token = "0x17000026")]
		public string CurrGroupName
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0xCD07EC", Offset = "0xCD07EC", VA = "0xCD07EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0xCD0840", Offset = "0xCD0840", VA = "0xCD0840")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xCD0890", Offset = "0xCD0890", VA = "0xCD0890")]
		public static string GetFaceIndicesKey(FaceIndices fi)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xCD0A28", Offset = "0xCD0A28", VA = "0xCD0A28")]
		public static string FixMaterialName(string mtlName)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xCD0AD4", Offset = "0xCD0AD4", VA = "0xCD0AD4")]
		public DataSet()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xCD0EEC", Offset = "0xCD0EEC", VA = "0xCD0EEC")]
		public void AddObject(string objectName)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xCD10F4", Offset = "0xCD10F4", VA = "0xCD10F4")]
		public void AddGroup(string groupName)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xCD1300", Offset = "0xCD1300", VA = "0xCD1300")]
		public void AddMaterialName(string matName)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xCD1398", Offset = "0xCD1398", VA = "0xCD1398")]
		public void AddVertex(Vector3 vertex)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xCD1470", Offset = "0xCD1470", VA = "0xCD1470")]
		public void AddUV(Vector2 uv)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xCD152C", Offset = "0xCD152C", VA = "0xCD152C")]
		public void AddNormal(Vector3 normal)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xCD1604", Offset = "0xCD1604", VA = "0xCD1604")]
		public void AddColor(Color color)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xCD16E4", Offset = "0xCD16E4", VA = "0xCD16E4")]
		public void AddFaceIndices(FaceIndices faceIdx)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xCD1838", Offset = "0xCD1838", VA = "0xCD1838")]
		public void PrintSummary()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class MaterialData
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string materialName;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color ambientColor;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color diffuseColor;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color specularColor;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color emissiveColor;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float shininess;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float overallAlpha;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int illumType;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool hasReflectionTex;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string diffuseTexPath;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Texture2D diffuseTex;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string bumpTexPath;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D bumpTex;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string specularTexPath;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D specularTex;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string opacityTexPath;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Texture2D opacityTex;

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xCD2258", Offset = "0xCD2258", VA = "0xCD2258")]
		public MaterialData()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class ModelUtil
	{
		[Token(Token = "0x2000088")]
		public enum MtlBlendMode
		{
			[Token(Token = "0x40002F6")]
			OPAQUE,
			[Token(Token = "0x40002F7")]
			CUTOUT,
			[Token(Token = "0x40002F8")]
			FADE,
			[Token(Token = "0x40002F9")]
			TRANSPARENT
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xCD2268", Offset = "0xCD2268", VA = "0xCD2268")]
		public static void SetupMaterialWithBlendMode(Material mtl, MtlBlendMode mode)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xCD2670", Offset = "0xCD2670", VA = "0xCD2670")]
		public static bool ScanTransparentPixels(Texture2D texture, ref MtlBlendMode mode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xCD2824", Offset = "0xCD2824", VA = "0xCD2824")]
		public static void DetectMtlBlendFadeOrCutout(float alpha, ref MtlBlendMode mode, ref bool noDoubt)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xCD286C", Offset = "0xCD286C", VA = "0xCD286C")]
		public static Texture2D HeightToNormalMap(Texture2D bumpMap, float amount = 1f)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xCD2C20", Offset = "0xCD2C20", VA = "0xCD2C20")]
		private static int WrapInt(int pos, int boundary)
		{
			return default(int);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xCD2C3C", Offset = "0xCD2C3C", VA = "0xCD2C3C")]
		public ModelUtil()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class ObjectBuilder
	{
		[Token(Token = "0x200008A")]
		public class ProgressInfo
		{
			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int materialsLoaded;

			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int objectsLoaded;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int groupsLoaded;

			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int numGroups;

			[Token(Token = "0x600032B")]
			[Address(RVA = "0xCD645C", Offset = "0xCD645C", VA = "0xCD645C")]
			public ProgressInfo()
			{
			}
		}

		[Token(Token = "0x200008B")]
		private class BuildStatus
		{
			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool newObject;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int objCount;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int subObjCount;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int idxCount;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int grpIdx;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int numGroups;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int grpFaceIdx;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int meshPartIdx;

			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int totFaceIdxCount;

			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public GameObject currObjGameObject;

			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal GameObject subObjParent;

			[Token(Token = "0x600032C")]
			[Address(RVA = "0xCD6464", Offset = "0xCD6464", VA = "0xCD6464")]
			public BuildStatus()
			{
			}
		}

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ImportOptions buildOptions;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BuildStatus buildStatus;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DataSet currDataSet;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject currParentObj;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, Material> currMaterials;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<MaterialData> materialData;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int MAX_VERTICES_LIMIT_FOR_A_MESH;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int MAX_INDICES_LIMIT_FOR_A_MESH;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int MAX_VERT_COUNT;

		[Token(Token = "0x17000029")]
		public Dictionary<string, Material> ImportedMaterials
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0xCD2C44", Offset = "0xCD2C44", VA = "0xCD2C44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public int NumImportedMaterials
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0xCD2C4C", Offset = "0xCD2C4C", VA = "0xCD2C4C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xCD2CA4", Offset = "0xCD2CA4", VA = "0xCD2CA4")]
		public void InitBuildMaterials(List<MaterialData> materialData, bool hasColors)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xCD2EFC", Offset = "0xCD2EFC", VA = "0xCD2EFC")]
		public bool BuildMaterials(ProgressInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xCD3C48", Offset = "0xCD3C48", VA = "0xCD3C48")]
		public void StartBuildObjectAsync(DataSet dataSet, GameObject parentObj, [Optional] Dictionary<string, Material> materials)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xCD3C58", Offset = "0xCD3C58", VA = "0xCD3C58")]
		public bool BuildObjectAsync(ref ProgressInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xCD485C", Offset = "0xCD485C", VA = "0xCD485C")]
		public static void Solve(Mesh origMesh)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xCD4FA0", Offset = "0xCD4FA0", VA = "0xCD4FA0")]
		public static void BuildMeshCollider(GameObject targetObject, bool convex = false, bool isTrigger = false, bool inflateMesh = false, float skinWidth = 0.01f)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xCD3CA8", Offset = "0xCD3CA8", VA = "0xCD3CA8")]
		protected bool BuildNextObject(GameObject parentObj, Dictionary<string, Material> mats)
		{
			return default(bool);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xCD519C", Offset = "0xCD519C", VA = "0xCD519C")]
		private GameObject ImportSubObject(GameObject parentObj, DataSet.ObjectData objData, Dictionary<string, Material> mats)
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xCD30C4", Offset = "0xCD30C4", VA = "0xCD30C4")]
		private Material BuildMaterial(MaterialData md)
		{
			return null;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xCD50F4", Offset = "0xCD50F4", VA = "0xCD50F4")]
		private bool Using32bitIndices()
		{
			return default(bool);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xCD639C", Offset = "0xCD639C", VA = "0xCD639C")]
		public ObjectBuilder()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public static class Triangulator
	{
		[Token(Token = "0x600032D")]
		[Address(RVA = "0xCD6474", Offset = "0xCD6474", VA = "0xCD6474")]
		public static void Triangulate(DataSet dataSet, DataSet.FaceIndices[] face)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xCD67C4", Offset = "0xCD67C4", VA = "0xCD67C4")]
		public static Vector3 FindPlaneNormal(DataSet dataSet, DataSet.FaceIndices[] face)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200008D")]
	public class ImportOptions
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("load the OBJ file assuming its vertical axis is Z instead of Y")]
		public bool zUp;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[Tooltip("Consider diffuse map as already lit (disable lighting) if no other texture is present")]
		public bool litDiffuse;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		[Tooltip("Consider to double-sided (duplicate and flip faces and normals")]
		public bool convertToDoubleSided;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Rescaling for the model (1 = no rescaling)")]
		public float modelScaling;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reuse a model in memory if already loaded")]
		public bool reuseLoaded;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Tooltip("Inherit parent layer")]
		public bool inheritLayer;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[Tooltip("Generate mesh colliders")]
		public bool buildColliders;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[Tooltip("Generate convex mesh colliders (only active if buildColliders = true)\nNote: it could not work for meshes with too many smooth surface regions.")]
		public bool colliderConvex;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Mesh colliders as trigger (only active if colliderConvex = true)")]
		public bool colliderTrigger;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[Tooltip("Use 32 bit indices when needed, if available")]
		public bool use32bitIndices;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		[Tooltip("Hide the loaded object during the loading process")]
		public bool hideWhileLoading;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Local Transform for the imported game object")]
		[Tooltip("Position of the object")]
		public Vector3 localPosition;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Rotation of the object\n(Euler angles)")]
		public Vector3 localEulerAngles;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Scaling of the object\n([1,1,1] = no rescaling)")]
		public Vector3 localScale;

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xCD6A40", Offset = "0xCD6A40", VA = "0xCD6A40")]
		public ImportOptions()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public abstract class Loader : MonoBehaviour
	{
		[Token(Token = "0x200008F")]
		protected struct BuildStats
		{
			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float texturesTime;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float materialsTime;

			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float objectsTime;
		}

		[Token(Token = "0x2000090")]
		protected struct Stats
		{
			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float modelParseTime;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float materialsParseTime;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float buildTime;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public BuildStats buildStats;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float totalTime;
		}

		[StructLayout(3)]
		[Token(Token = "0x2000091")]
		[CompilerGenerated]
		private struct <Load>d__33 : IAsyncStateMachine
		{
			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> <>t__builder;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string objAbsolutePath;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string objName;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Loader <>4__this;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string texturesFolderPath;

			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string materialsFolderPath;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform parentObj;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <lastTime>5__2;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float <startTime>5__3;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter <>u__2;

			[Token(Token = "0x6000358")]
			[Address(RVA = "0xCD8880", Offset = "0xCD8880", VA = "0xCD8880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000359")]
			[Address(RVA = "0xCD9070", Offset = "0xCD9070", VA = "0xCD9070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct <LoadFromNetwork>d__34 : IAsyncStateMachine
		{
			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> <>t__builder;

			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string objName;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Loader <>4__this;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objURL;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string materialURL;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string diffuseTexURL;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string bumpTexURL;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string specularTexURL;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string opacityTexURL;

			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float <lastTime>5__2;

			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float <startTime>5__3;

			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private TaskAwaiter <>u__2;

			[Token(Token = "0x600035A")]
			[Address(RVA = "0xCD90C8", Offset = "0xCD90C8", VA = "0xCD90C8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0xCD9A38", Offset = "0xCD9A38", VA = "0xCD9A38", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000093")]
		[CompilerGenerated]
		private sealed class <LoadFromNetworkWebGL>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string objName;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Loader <>4__this;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objURL;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<Exception> OnError;

			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string materialURL;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string diffuseTexURL;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string bumpTexURL;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string specularTexURL;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public string opacityTexURL;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private float <lastTime>5__2;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private float <startTime>5__3;

			[Token(Token = "0x1700002E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600035F")]
				[Address(RVA = "0xCD9FEC", Offset = "0xCD9FEC", VA = "0xCD9FEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000361")]
				[Address(RVA = "0xCDA034", Offset = "0xCDA034", VA = "0xCDA034", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0xCD7428", Offset = "0xCD7428", VA = "0xCD7428")]
			[DebuggerHidden]
			public <LoadFromNetworkWebGL>d__35(int <>1__state)
			{
			}

			[Token(Token = "0x600035D")]
			[Address(RVA = "0xCD9A90", Offset = "0xCD9A90", VA = "0xCD9A90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0xCD9A94", Offset = "0xCD9A94", VA = "0xCD9A94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000360")]
			[Address(RVA = "0xCD9FF4", Offset = "0xCD9FF4", VA = "0xCD9FF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000094")]
		[CompilerGenerated]
		private struct <Build>d__43 : IAsyncStateMachine
		{
			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string absolutePath;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string texturesFolderPath;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string objName;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform parentTransform;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <prevTime>5__2;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string <basePath>5__3;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int <count>5__4;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private List<MaterialData>.Enumerator <>7__wrap4;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private MaterialData <mtl>5__6;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000362")]
			[Address(RVA = "0xCDA03C", Offset = "0xCDA03C", VA = "0xCDA03C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000363")]
			[Address(RVA = "0xCDACD0", Offset = "0xCDACD0", VA = "0xCDACD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000095")]
		[CompilerGenerated]
		private struct <NetworkedBuild>d__44 : IAsyncStateMachine
		{
			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string diffuseTexURL;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bumpTexURL;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string specularTexURL;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string opacityTexURL;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string objName;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform parentTransform;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string objURL;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float <prevTime>5__2;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private ObjectBuilder.ProgressInfo <info>5__3;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private float <objInitPerc>5__4;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private GameObject <newObj>5__5;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private float <initProgress>5__6;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private int <count>5__7;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private List<MaterialData>.Enumerator <>7__wrap7;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private MaterialData <mtl>5__9;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000364")]
			[Address(RVA = "0xCDACDC", Offset = "0xCDACDC", VA = "0xCDACDC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0xCDBEF4", Offset = "0xCDBEF4", VA = "0xCDBEF4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000096")]
		[CompilerGenerated]
		private sealed class <NetworkedBuildWebGL>d__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string diffuseTexURL;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bumpTexURL;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string specularTexURL;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string opacityTexURL;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string objName;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform parentTransform;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string objURL;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float <prevTime>5__2;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private int <count>5__3;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private List<MaterialData>.Enumerator <>7__wrap3;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private MaterialData <mtl>5__5;

			[Token(Token = "0x17000030")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600036A")]
				[Address(RVA = "0xCDCBB0", Offset = "0xCDCBB0", VA = "0xCDCBB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000031")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600036C")]
				[Address(RVA = "0xCDCBF8", Offset = "0xCDCBF8", VA = "0xCDCBF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000366")]
			[Address(RVA = "0xCD7714", Offset = "0xCD7714", VA = "0xCD7714")]
			[DebuggerHidden]
			public <NetworkedBuildWebGL>d__45(int <>1__state)
			{
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0xCDBF00", Offset = "0xCDBF00", VA = "0xCDBF00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000368")]
			[Address(RVA = "0xCDBF20", Offset = "0xCDBF20", VA = "0xCDBF20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000369")]
			[Address(RVA = "0xCDCB60", Offset = "0xCDCB60", VA = "0xCDCB60")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0xCDCBB8", Offset = "0xCDCBB8", VA = "0xCDCBB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000097")]
		[CompilerGenerated]
		private struct <LoadMaterialTexture>d__51 : IAsyncStateMachine
		{
			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string texturesFolderPath;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string basePath;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string path;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private byte[] <result>5__2;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private FileStream <stream>5__3;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private TaskAwaiter<int> <>u__1;

			[Token(Token = "0x600036D")]
			[Address(RVA = "0xCDCC00", Offset = "0xCDCC00", VA = "0xCDCC00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600036E")]
			[Address(RVA = "0xCDD330", Offset = "0xCDD330", VA = "0xCDD330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass52_0
		{
			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] downloadedBytes;

			[Token(Token = "0x600036F")]
			[Address(RVA = "0xCDD33C", Offset = "0xCDD33C", VA = "0xCDD33C")]
			public <>c__DisplayClass52_0()
			{
			}

			[Token(Token = "0x6000370")]
			[Address(RVA = "0xCDD344", Offset = "0xCDD344", VA = "0xCDD344")]
			internal void <LoadMaterialTexture>b__0(byte[] bytes)
			{
			}

			[Token(Token = "0x6000371")]
			[Address(RVA = "0xCDD350", Offset = "0xCDD350", VA = "0xCDD350")]
			internal void <LoadMaterialTexture>b__1(string error)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000099")]
		[CompilerGenerated]
		private struct <LoadMaterialTexture>d__52 : IAsyncStateMachine
		{
			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string textureURL;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass52_0 <>8__1;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000372")]
			[Address(RVA = "0xCDD414", Offset = "0xCDD414", VA = "0xCDD414", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000373")]
			[Address(RVA = "0xCDDA40", Offset = "0xCDDA40", VA = "0xCDDA40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass53_0
		{
			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Loader <>4__this;

			[Token(Token = "0x6000374")]
			[Address(RVA = "0xCDDA4C", Offset = "0xCDDA4C", VA = "0xCDDA4C")]
			public <>c__DisplayClass53_0()
			{
			}

			[Token(Token = "0x6000375")]
			[Address(RVA = "0xCDDA54", Offset = "0xCDDA54", VA = "0xCDDA54")]
			internal void <LoadMaterialTextureWebGL>b__0(Texture2D texture)
			{
			}

			[Token(Token = "0x6000376")]
			[Address(RVA = "0xCDDA74", Offset = "0xCDDA74", VA = "0xCDDA74")]
			internal void <LoadMaterialTextureWebGL>b__1(string error)
			{
			}
		}

		[Token(Token = "0x200009B")]
		[CompilerGenerated]
		private sealed class <LoadMaterialTextureWebGL>d__53 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string textureURL;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass53_0 <>8__1;

			[Token(Token = "0x17000032")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600037A")]
				[Address(RVA = "0xCDDFB4", Offset = "0xCDDFB4", VA = "0xCDDFB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000033")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600037C")]
				[Address(RVA = "0xCDDFFC", Offset = "0xCDDFFC", VA = "0xCDDFFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000377")]
			[Address(RVA = "0xCD7FA8", Offset = "0xCD7FA8", VA = "0xCD7FA8")]
			[DebuggerHidden]
			public <LoadMaterialTextureWebGL>d__53(int <>1__state)
			{
			}

			[Token(Token = "0x6000378")]
			[Address(RVA = "0xCDDB38", Offset = "0xCDDB38", VA = "0xCDDB38", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000379")]
			[Address(RVA = "0xCDDB3C", Offset = "0xCDDB3C", VA = "0xCDDB3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600037B")]
			[Address(RVA = "0xCDDFBC", Offset = "0xCDDFBC", VA = "0xCDDFBC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class <DownloadFile>d__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> OnError;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Loader <>4__this;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<byte[]> DownloadComplete;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private WWW <www>5__2;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <oldProgress>5__3;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Coroutine <progress>5__4;

			[Token(Token = "0x17000034")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000380")]
				[Address(RVA = "0xCDE340", Offset = "0xCDE340", VA = "0xCDE340", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000035")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000382")]
				[Address(RVA = "0xCDE388", Offset = "0xCDE388", VA = "0xCDE388", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600037D")]
			[Address(RVA = "0xCD8398", Offset = "0xCD8398", VA = "0xCD8398")]
			[DebuggerHidden]
			public <DownloadFile>d__57(int <>1__state)
			{
			}

			[Token(Token = "0x600037E")]
			[Address(RVA = "0xCDE004", Offset = "0xCDE004", VA = "0xCDE004", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600037F")]
			[Address(RVA = "0xCDE008", Offset = "0xCDE008", VA = "0xCDE008", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000381")]
			[Address(RVA = "0xCDE348", Offset = "0xCDE348", VA = "0xCDE348", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class <GetProgress>d__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public WWW www;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldProgress>5__2;

			[Token(Token = "0x17000036")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000386")]
				[Address(RVA = "0xCDE5A0", Offset = "0xCDE5A0", VA = "0xCDE5A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000037")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000388")]
				[Address(RVA = "0xCDE5E8", Offset = "0xCDE5E8", VA = "0xCDE5E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0xCD8434", Offset = "0xCD8434", VA = "0xCD8434")]
			[DebuggerHidden]
			public <GetProgress>d__58(int <>1__state)
			{
			}

			[Token(Token = "0x6000384")]
			[Address(RVA = "0xCDE390", Offset = "0xCDE390", VA = "0xCDE390", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000385")]
			[Address(RVA = "0xCDE394", Offset = "0xCDE394", VA = "0xCDE394", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000387")]
			[Address(RVA = "0xCDE5A8", Offset = "0xCDE5A8", VA = "0xCDE5A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class <DownloadFileWebGL>d__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> OnError;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Loader <>4__this;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<string> DownloadComplete;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private WWW <www>5__2;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <oldProgress>5__3;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Coroutine <progress>5__4;

			[Token(Token = "0x17000038")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600038C")]
				[Address(RVA = "0xCDE99C", Offset = "0xCDE99C", VA = "0xCDE99C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600038E")]
				[Address(RVA = "0xCDE9E4", Offset = "0xCDE9E4", VA = "0xCDE9E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000389")]
			[Address(RVA = "0xCD84EC", Offset = "0xCD84EC", VA = "0xCD84EC")]
			[DebuggerHidden]
			public <DownloadFileWebGL>d__59(int <>1__state)
			{
			}

			[Token(Token = "0x600038A")]
			[Address(RVA = "0xCDE5F0", Offset = "0xCDE5F0", VA = "0xCDE5F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600038B")]
			[Address(RVA = "0xCDE5F4", Offset = "0xCDE5F4", VA = "0xCDE5F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0xCDE9A4", Offset = "0xCDE9A4", VA = "0xCDE9A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class <DownloadTexFileWebGL>d__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> OnError;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Loader <>4__this;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<Texture2D> DownloadComplete;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private WWW <www>5__2;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <oldProgress>5__3;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Coroutine <progress>5__4;

			[Token(Token = "0x1700003A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000392")]
				[Address(RVA = "0xCDED28", Offset = "0xCDED28", VA = "0xCDED28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000394")]
				[Address(RVA = "0xCDED70", Offset = "0xCDED70", VA = "0xCDED70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600038F")]
			[Address(RVA = "0xCD85A4", Offset = "0xCD85A4", VA = "0xCD85A4")]
			[DebuggerHidden]
			public <DownloadTexFileWebGL>d__60(int <>1__state)
			{
			}

			[Token(Token = "0x6000390")]
			[Address(RVA = "0xCDE9EC", Offset = "0xCDE9EC", VA = "0xCDE9EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000391")]
			[Address(RVA = "0xCDE9F0", Offset = "0xCDE9F0", VA = "0xCDE9F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000393")]
			[Address(RVA = "0xCDED30", Offset = "0xCDED30", VA = "0xCDED30", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LoadingProgress totalProgress;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ImportOptions buildOptions;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PolyfewRuntime.ReferencedNumeric<float> individualProgress;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static float LOAD_PHASE_PERC;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected static float TEXTURE_PHASE_PERC;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static float MATERIAL_PHASE_PERC;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected static float BUILD_PHASE_PERC;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected static Dictionary<string, GameObject> loadedModels;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected static Dictionary<string, int> instanceCount;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected DataSet dataSet;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected ObjectBuilder objectBuilder;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<MaterialData> materialData;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected SingleLoadingProgress objLoadingProgress;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Stats loadStats;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Texture2D loadedTexture;

		[Token(Token = "0x1700002B")]
		public bool ConvertVertAxis
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0xCD6AF8", Offset = "0xCD6AF8", VA = "0xCD6AF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000331")]
			[Address(RVA = "0xCD6B18", Offset = "0xCD6B18", VA = "0xCD6B18")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public float Scaling
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0xCD6B88", Offset = "0xCD6B88", VA = "0xCD6B88")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000333")]
			[Address(RVA = "0xCD6BA0", Offset = "0xCD6BA0", VA = "0xCD6BA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		protected abstract bool HasMaterialLibrary
		{
			[Token(Token = "0x6000334")]
			get;
		}

		[Token(Token = "0x14000005")]
		public event Action<GameObject, string> ModelCreated
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0xCD6C14", Offset = "0xCD6C14", VA = "0xCD6C14")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000336")]
			[Address(RVA = "0xCD6CC4", Offset = "0xCD6CC4", VA = "0xCD6CC4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event Action<GameObject, string> ModelLoaded
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0xCD6D74", Offset = "0xCD6D74", VA = "0xCD6D74")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000338")]
			[Address(RVA = "0xCD6E24", Offset = "0xCD6E24", VA = "0xCD6E24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event Action<string> ModelError
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0xCD6ED4", Offset = "0xCD6ED4", VA = "0xCD6ED4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600033A")]
			[Address(RVA = "0xCD6F84", Offset = "0xCD6F84", VA = "0xCD6F84")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xCD7034", Offset = "0xCD7034", VA = "0xCD7034")]
		public static GameObject GetModelByPath(string absolutePath)
		{
			return null;
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xCD7108", Offset = "0xCD7108", VA = "0xCD7108")]
		[AsyncStateMachine(typeof(<Load>d__33))]
		public Task<GameObject> Load(string objName, string objAbsolutePath, Transform parentObj, string texturesFolderPath = "", string materialsFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xCD7230", Offset = "0xCD7230", VA = "0xCD7230")]
		[AsyncStateMachine(typeof(<LoadFromNetwork>d__34))]
		public Task<GameObject> LoadFromNetwork(string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, string objName)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xCD7370", Offset = "0xCD7370", VA = "0xCD7370")]
		[IteratorStateMachine(typeof(<LoadFromNetworkWebGL>d__35))]
		public IEnumerator LoadFromNetworkWebGL(string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, string objName, Action<GameObject> OnSuccess, Action<Exception> OnError)
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		public abstract string[] ParseTexturePaths(string absolutePath);

		[Token(Token = "0x6000340")]
		protected abstract Task LoadModelFile(string absolutePath, string texturesFolderPath = "", string materialsFolderPath = "");

		[Token(Token = "0x6000341")]
		protected abstract Task LoadModelFileNetworked(string objURL);

		[Token(Token = "0x6000342")]
		protected abstract IEnumerator LoadModelFileNetworkedWebGL(string objURL, Action<Exception> OnError);

		[Token(Token = "0x6000343")]
		protected abstract Task LoadMaterialLibrary(string absolutePath, string materialsFolderPath = "");

		[Token(Token = "0x6000344")]
		protected abstract Task LoadMaterialLibrary(string materialURL);

		[Token(Token = "0x6000345")]
		protected abstract IEnumerator LoadMaterialLibraryWebGL(string materialURL);

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xCD7450", Offset = "0xCD7450", VA = "0xCD7450")]
		[AsyncStateMachine(typeof(<Build>d__43))]
		protected Task Build(string absolutePath, string objName, Transform parentTransform, string texturesFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xCD754C", Offset = "0xCD754C", VA = "0xCD754C")]
		[AsyncStateMachine(typeof(<NetworkedBuild>d__44))]
		protected Task NetworkedBuild(Transform parentTransform, string objName, string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xCD7664", Offset = "0xCD7664", VA = "0xCD7664")]
		[IteratorStateMachine(typeof(<NetworkedBuildWebGL>d__45))]
		protected IEnumerator NetworkedBuildWebGL(Transform parentTransform, string objName, string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xCD773C", Offset = "0xCD773C", VA = "0xCD773C")]
		protected string GetDirName(string absolutePath)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xCD7864", Offset = "0xCD7864", VA = "0xCD7864", Slot = "12")]
		protected virtual void OnLoaded(GameObject obj, string absolutePath)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xCD7B18", Offset = "0xCD7B18", VA = "0xCD7B18", Slot = "13")]
		protected virtual void OnCreated(GameObject obj, string absolutePath)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xCD7BE0", Offset = "0xCD7BE0", VA = "0xCD7BE0", Slot = "14")]
		protected virtual void OnLoadFailed(string absolutePath)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xCD7BFC", Offset = "0xCD7BFC", VA = "0xCD7BFC")]
		private string GetTextureUrl(string basePath, string texturePath)
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xCD7D68", Offset = "0xCD7D68", VA = "0xCD7D68")]
		[AsyncStateMachine(typeof(<LoadMaterialTexture>d__51))]
		private Task LoadMaterialTexture(string basePath, string path, string texturesFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xCD7E5C", Offset = "0xCD7E5C", VA = "0xCD7E5C")]
		[AsyncStateMachine(typeof(<LoadMaterialTexture>d__52))]
		private Task LoadMaterialTexture(string textureURL)
		{
			return null;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xCD7F34", Offset = "0xCD7F34", VA = "0xCD7F34")]
		[IteratorStateMachine(typeof(<LoadMaterialTextureWebGL>d__53))]
		private IEnumerator LoadMaterialTextureWebGL(string textureURL)
		{
			return null;
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xCD7FD0", Offset = "0xCD7FD0", VA = "0xCD7FD0")]
		private Texture2D LoadTexture(UnityWebRequest loader)
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xCD8308", Offset = "0xCD8308", VA = "0xCD8308")]
		[IteratorStateMachine(typeof(<DownloadFile>d__57))]
		public IEnumerator DownloadFile(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<byte[]> DownloadComplete, Action<string> OnError)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xCD83C0", Offset = "0xCD83C0", VA = "0xCD83C0")]
		[IteratorStateMachine(typeof(<GetProgress>d__58))]
		private IEnumerator GetProgress(WWW www, PolyfewRuntime.ReferencedNumeric<float> downloadProgress)
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xCD845C", Offset = "0xCD845C", VA = "0xCD845C")]
		[IteratorStateMachine(typeof(<DownloadFileWebGL>d__59))]
		public IEnumerator DownloadFileWebGL(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<string> DownloadComplete, Action<string> OnError)
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xCD8514", Offset = "0xCD8514", VA = "0xCD8514")]
		[IteratorStateMachine(typeof(<DownloadTexFileWebGL>d__60))]
		public IEnumerator DownloadTexFileWebGL(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<Texture2D> DownloadComplete, Action<string> OnError)
		{
			return null;
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xCD85CC", Offset = "0xCD85CC", VA = "0xCD85CC")]
		protected Loader()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class LoaderObj : Loader
	{
		[Token(Token = "0x20000A1")]
		private class BumpParamDef
		{
			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string optionName;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string valueType;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int valueNumMin;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int valueNumMax;

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xCE1C60", Offset = "0xCE1C60", VA = "0xCE1C60")]
			public BumpParamDef(string name, string type, int numMin, int numMax)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private struct <LoadModelFile>d__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string absolutePath;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LoaderObj <>4__this;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private StreamReader <sr>5__2;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<string> <>u__1;

			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xCE1D9C", Offset = "0xCE1D9C", VA = "0xCE1D9C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xCE227C", Offset = "0xCE227C", VA = "0xCE227C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] downloadedBytes;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Exception ex;

			[Token(Token = "0x60003AB")]
			[Address(RVA = "0xCE2288", Offset = "0xCE2288", VA = "0xCE2288")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xCE2290", Offset = "0xCE2290", VA = "0xCE2290")]
			internal void <LoadModelFileNetworked>b__0(byte[] bytes)
			{
			}

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xCE229C", Offset = "0xCE229C", VA = "0xCE229C")]
			internal void <LoadModelFileNetworked>b__1(string error)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private struct <LoadModelFileNetworked>d__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string objURL;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass4_0 <>8__1;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private StreamReader <sr>5__2;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<string> <>u__2;

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xCE236C", Offset = "0xCE236C", VA = "0xCE236C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003AF")]
			[Address(RVA = "0xCE2D80", Offset = "0xCE2D80", VA = "0xCE2D80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LoaderObj <>4__this;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Exception ex;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<Exception> OnError;

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xCE2D8C", Offset = "0xCE2D8C", VA = "0xCE2D8C")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xCE2D94", Offset = "0xCE2D94", VA = "0xCE2D94")]
			internal void <LoadModelFileNetworkedWebGL>b__0(string text)
			{
			}

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xCE2DB4", Offset = "0xCE2DB4", VA = "0xCE2DB4")]
			internal void <LoadModelFileNetworkedWebGL>b__1(string error)
			{
			}
		}

		[Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class <LoadModelFileNetworkedWebGL>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<Exception> OnError;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objURL;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private <>c__DisplayClass5_0 <>8__1;

			[Token(Token = "0x1700003D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003B6")]
				[Address(RVA = "0xCE3464", Offset = "0xCE3464", VA = "0xCE3464", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B8")]
				[Address(RVA = "0xCE34AC", Offset = "0xCE34AC", VA = "0xCE34AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xCE0200", Offset = "0xCE0200", VA = "0xCE0200")]
			[DebuggerHidden]
			public <LoadModelFileNetworkedWebGL>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xCE2EB0", Offset = "0xCE2EB0", VA = "0xCE2EB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0xCE2EB4", Offset = "0xCE2EB4", VA = "0xCE2EB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B7")]
			[Address(RVA = "0xCE346C", Offset = "0xCE346C", VA = "0xCE346C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private struct <LoadMaterialLibrary>d__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string absolutePath;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string materialsFolderPath;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private StreamReader <sr>5__2;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<string> <>u__1;

			[Token(Token = "0x60003B9")]
			[Address(RVA = "0xCE34B4", Offset = "0xCE34B4", VA = "0xCE34B4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0xCE3AE0", Offset = "0xCE3AE0", VA = "0xCE3AE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] downloadedBytes;

			[Token(Token = "0x60003BB")]
			[Address(RVA = "0xCE3AEC", Offset = "0xCE3AEC", VA = "0xCE3AEC")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60003BC")]
			[Address(RVA = "0xCE3AF4", Offset = "0xCE3AF4", VA = "0xCE3AF4")]
			internal void <LoadMaterialLibrary>b__0(byte[] bytes)
			{
			}

			[Token(Token = "0x60003BD")]
			[Address(RVA = "0xCE3B00", Offset = "0xCE3B00", VA = "0xCE3B00")]
			internal void <LoadMaterialLibrary>b__1(string error)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A9")]
		[CompilerGenerated]
		private struct <LoadMaterialLibrary>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string materialURL;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass7_0 <>8__1;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private StreamReader <sr>5__2;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<string> <>u__2;

			[Token(Token = "0x60003BE")]
			[Address(RVA = "0xCE3BC4", Offset = "0xCE3BC4", VA = "0xCE3BC4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003BF")]
			[Address(RVA = "0xCE4488", Offset = "0xCE4488", VA = "0xCE4488", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LoaderObj <>4__this;

			[Token(Token = "0x60003C0")]
			[Address(RVA = "0xCE4494", Offset = "0xCE4494", VA = "0xCE4494")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60003C1")]
			[Address(RVA = "0xCE449C", Offset = "0xCE449C", VA = "0xCE449C")]
			internal void <LoadMaterialLibraryWebGL>b__0(string text)
			{
			}

			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xCE44BC", Offset = "0xCE44BC", VA = "0xCE44BC")]
			internal void <LoadMaterialLibraryWebGL>b__1(string error)
			{
			}
		}

		[Token(Token = "0x20000AB")]
		[CompilerGenerated]
		private sealed class <LoadMaterialLibraryWebGL>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string materialURL;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass8_0 <>8__1;

			[Token(Token = "0x1700003F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003C6")]
				[Address(RVA = "0xCE4824", Offset = "0xCE4824", VA = "0xCE4824", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000040")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003C8")]
				[Address(RVA = "0xCE486C", Offset = "0xCE486C", VA = "0xCE486C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003C3")]
			[Address(RVA = "0xCE0458", Offset = "0xCE0458", VA = "0xCE0458")]
			[DebuggerHidden]
			public <LoadMaterialLibraryWebGL>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xCE4580", Offset = "0xCE4580", VA = "0xCE4580", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003C5")]
			[Address(RVA = "0xCE4584", Offset = "0xCE4584", VA = "0xCE4584", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003C7")]
			[Address(RVA = "0xCE482C", Offset = "0xCE482C", VA = "0xCE482C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class <LoadOrDownloadText>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool notifyErrors;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest <uwr>5__2;

			[Token(Token = "0x17000041")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003CC")]
				[Address(RVA = "0xCE49AC", Offset = "0xCE49AC", VA = "0xCE49AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000042")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003CE")]
				[Address(RVA = "0xCE49F4", Offset = "0xCE49F4", VA = "0xCE49F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003C9")]
			[Address(RVA = "0xCE1D20", Offset = "0xCE1D20", VA = "0xCE1D20")]
			[DebuggerHidden]
			public <LoadOrDownloadText>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x60003CA")]
			[Address(RVA = "0xCE4874", Offset = "0xCE4874", VA = "0xCE4874", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003CB")]
			[Address(RVA = "0xCE4878", Offset = "0xCE4878", VA = "0xCE4878", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003CD")]
			[Address(RVA = "0xCE49B4", Offset = "0xCE49B4", VA = "0xCE49B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string mtlLib;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string loadedText;

		[Token(Token = "0x1700003C")]
		protected override bool HasMaterialLibrary
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0xCE111C", Offset = "0xCE111C", VA = "0xCE111C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xCDED78", Offset = "0xCDED78", VA = "0xCDED78", Slot = "5")]
		public override string[] ParseTexturePaths(string absolutePath)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xCDFFD0", Offset = "0xCDFFD0", VA = "0xCDFFD0", Slot = "6")]
		[AsyncStateMachine(typeof(<LoadModelFile>d__3))]
		protected override Task LoadModelFile(string absolutePath, string texturesFolderPath = "", string materialsFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xCE00A8", Offset = "0xCE00A8", VA = "0xCE00A8", Slot = "7")]
		[AsyncStateMachine(typeof(<LoadModelFileNetworked>d__4))]
		protected override Task LoadModelFileNetworked(string objURL)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xCE0184", Offset = "0xCE0184", VA = "0xCE0184", Slot = "8")]
		[IteratorStateMachine(typeof(<LoadModelFileNetworkedWebGL>d__5))]
		protected override IEnumerator LoadModelFileNetworkedWebGL(string objURL, Action<Exception> OnError)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xCE0228", Offset = "0xCE0228", VA = "0xCE0228", Slot = "9")]
		[AsyncStateMachine(typeof(<LoadMaterialLibrary>d__6))]
		protected override Task LoadMaterialLibrary(string absolutePath, string materialsFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xCE0308", Offset = "0xCE0308", VA = "0xCE0308", Slot = "10")]
		[AsyncStateMachine(typeof(<LoadMaterialLibrary>d__7))]
		protected override Task LoadMaterialLibrary(string materialURL)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xCE03E4", Offset = "0xCE03E4", VA = "0xCE03E4", Slot = "11")]
		[IteratorStateMachine(typeof(<LoadMaterialLibraryWebGL>d__8))]
		protected override IEnumerator LoadMaterialLibraryWebGL(string materialURL)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xCE0480", Offset = "0xCE0480", VA = "0xCE0480")]
		private void GetFaceIndicesByOneFaceLine(DataSet.FaceIndices[] faces, string[] p, bool isFaceIndexPlus)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xCE07D0", Offset = "0xCE07D0", VA = "0xCE07D0")]
		private Vector3 ConvertVec3(float x, float y, float z)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xCE0818", Offset = "0xCE0818", VA = "0xCE0818")]
		private float ParseFloat(string floatString)
		{
			return default(float);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xCE0894", Offset = "0xCE0894", VA = "0xCE0894")]
		protected void ParseGeometryData(string objDataText)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xCDF1BC", Offset = "0xCDF1BC", VA = "0xCDF1BC")]
		private string ParseMaterialLibName(string path)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xCE112C", Offset = "0xCE112C", VA = "0xCE112C")]
		private void ParseMaterialData(string data)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xCDF2D0", Offset = "0xCDF2D0", VA = "0xCDF2D0")]
		private void ParseMaterialData(string[] lines, List<MaterialData> mtlData)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xCE128C", Offset = "0xCE128C", VA = "0xCE128C")]
		private void ParseBumpParameters(string[] param, MaterialData mtlData)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xCE1214", Offset = "0xCE1214", VA = "0xCE1214")]
		private Color StringsToColor(string[] p)
		{
			return default(Color);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xCE1CA0", Offset = "0xCE1CA0", VA = "0xCE1CA0")]
		[IteratorStateMachine(typeof(<LoadOrDownloadText>d__20))]
		private IEnumerator LoadOrDownloadText(string url, bool notifyErrors = true)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xCE1D48", Offset = "0xCE1D48", VA = "0xCE1D48")]
		public LoaderObj()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class TextureLoader : MonoBehaviour
	{
		[Token(Token = "0x20000AE")]
		private class TgaHeader
		{
			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public byte identSize;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public byte colorMapType;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			public byte imageType;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ushort colorMapStart;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			public ushort colorMapLength;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte colorMapBits;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			public ushort xStart;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ushort ySstart;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
			public ushort width;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ushort height;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
			public byte bits;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
			public byte descriptor;

			[Token(Token = "0x60003D6")]
			[Address(RVA = "0xCE5A34", Offset = "0xCE5A34", VA = "0xCE5A34")]
			public TgaHeader()
			{
			}
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xCD8260", Offset = "0xCD8260", VA = "0xCD8260")]
		public static Texture2D LoadTextureFromUrl(string url)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xCE49FC", Offset = "0xCE49FC", VA = "0xCE49FC")]
		public static Texture2D LoadTexture(string fileName)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xCE4F48", Offset = "0xCE4F48", VA = "0xCE4F48")]
		public static Texture2D LoadTGA(string fileName)
		{
			return null;
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xCE4BE0", Offset = "0xCE4BE0", VA = "0xCE4BE0")]
		public static Texture2D LoadDDSManual(string ddsPath)
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xCE50C4", Offset = "0xCE50C4", VA = "0xCE50C4")]
		public static Texture2D LoadTGA(Stream TGAStream)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xCE5648", Offset = "0xCE5648", VA = "0xCE5648")]
		private static TgaHeader LoadTgaHeader(BinaryReader r)
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xCE5A3C", Offset = "0xCE5A3C", VA = "0xCE5A3C")]
		public TextureLoader()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class SingleLoadingProgress
	{
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string fileName;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string message;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float percentage;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int numObjects;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numSubObjects;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool error;

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xCD86DC", Offset = "0xCD86DC", VA = "0xCD86DC")]
		public SingleLoadingProgress()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class LoadingProgress
	{
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<SingleLoadingProgress> singleProgress;

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xCD8804", Offset = "0xCD8804", VA = "0xCD8804")]
		public LoadingProgress()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class ModelImportInfo
	{
		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Name for the game object created\n(leave it blank to use its file name)")]
		public string name;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Path relative to the project folder")]
		public string path;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Check this to skip this model")]
		public bool skip;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ImportOptions loaderOptions;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xCE5A44", Offset = "0xCE5A44", VA = "0xCE5A44")]
		public ModelImportInfo()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class MultiObjectImporter : ObjectImporter
	{
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Load models in the list on start")]
		public bool autoLoadOnStart;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Models to load on startup")]
		public List<ModelImportInfo> objectsList;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Default import options")]
		public ImportOptions defaultImportOptions;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private PathSettings pathSettings;

		[Token(Token = "0x17000043")]
		public string RootPath
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0xCE5A4C", Offset = "0xCE5A4C", VA = "0xCE5A4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xCE5AE8", Offset = "0xCE5AE8", VA = "0xCE5AE8")]
		public void ImportModelListAsync(ModelImportInfo[] modelsInfo)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xCE5E1C", Offset = "0xCE5E1C", VA = "0xCE5E1C", Slot = "10")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xCE5E8C", Offset = "0xCE5E8C", VA = "0xCE5E8C")]
		public MultiObjectImporter()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class ObjectImporter : MonoBehaviour
	{
		[Token(Token = "0x20000B4")]
		private enum ImportPhase
		{
			[Token(Token = "0x4000436")]
			Idle,
			[Token(Token = "0x4000437")]
			TextureImport,
			[Token(Token = "0x4000438")]
			ObjLoad,
			[Token(Token = "0x4000439")]
			AssetBuild,
			[Token(Token = "0x400043A")]
			Done
		}

		[StructLayout(3)]
		[Token(Token = "0x20000B5")]
		[CompilerGenerated]
		private struct <ImportModelAsync>d__31 : IAsyncStateMachine
		{
			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> <>t__builder;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ObjectImporter <>4__this;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string filePath;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ImportOptions options;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string objName;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform parentObj;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string texturesFolderPath;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string materialsFolderPath;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private TaskAwaiter<GameObject> <>u__1;

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0xCE6FDC", Offset = "0xCE6FDC", VA = "0xCE6FDC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xCE749C", Offset = "0xCE749C", VA = "0xCE749C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000B6")]
		[CompilerGenerated]
		private struct <ImportModelFromNetwork>d__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> <>t__builder;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ObjectImporter <>4__this;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ImportOptions options;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objName;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string objURL;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string diffuseTexURL;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string bumpTexURL;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string specularTexURL;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public string opacityTexURL;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public string materialURL;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private TaskAwaiter<GameObject> <>u__1;

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xCE74F4", Offset = "0xCE74F4", VA = "0xCE74F4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0xCE79BC", Offset = "0xCE79BC", VA = "0xCE79BC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int activeDownloads;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static float objDownloadProgress;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static float textureDownloadProgress;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static float materialDownloadProgress;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isException;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int numTotalImports;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected bool allLoaded;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ImportOptions buildOptions;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected List<Loader> loaderList;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ImportPhase importPhase;

		[Token(Token = "0x17000044")]
		public int NumImportRequests
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xCE6688", Offset = "0xCE6688", VA = "0xCE6688")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000008")]
		public event Action ImportingStart
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0xCE5FF8", Offset = "0xCE5FF8", VA = "0xCE5FF8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0xCE6094", Offset = "0xCE6094", VA = "0xCE6094")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event Action ImportingComplete
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0xCE6130", Offset = "0xCE6130", VA = "0xCE6130")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0xCE61CC", Offset = "0xCE61CC", VA = "0xCE61CC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event Action<GameObject, string> CreatedModel
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xCE6268", Offset = "0xCE6268", VA = "0xCE6268")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0xCE6318", Offset = "0xCE6318", VA = "0xCE6318")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event Action<GameObject, string> ImportedModel
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0xCE63C8", Offset = "0xCE63C8", VA = "0xCE63C8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xCE6478", Offset = "0xCE6478", VA = "0xCE6478")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event Action<string> ImportError
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xCE6528", Offset = "0xCE6528", VA = "0xCE6528")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xCE65D8", Offset = "0xCE65D8", VA = "0xCE65D8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xCE5F30", Offset = "0xCE5F30", VA = "0xCE5F30")]
		public ObjectImporter()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xCE6690", Offset = "0xCE6690", VA = "0xCE6690")]
		private Loader CreateLoader(string absolutePath, bool isNetwork = false)
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xCE5CEC", Offset = "0xCE5CEC", VA = "0xCE5CEC")]
		[AsyncStateMachine(typeof(<ImportModelAsync>d__31))]
		public Task<GameObject> ImportModelAsync(string objName, string filePath, Transform parentObj, ImportOptions options, string texturesFolderPath = "", string materialsFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xCE6964", Offset = "0xCE6964", VA = "0xCE6964")]
		[AsyncStateMachine(typeof(<ImportModelFromNetwork>d__32))]
		public Task<GameObject> ImportModelFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, ImportOptions options)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xCE6AAC", Offset = "0xCE6AAC", VA = "0xCE6AAC")]
		public void ImportModelFromNetworkWebGL(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, ImportOptions options, Action<GameObject> OnSuccess, Action<Exception> OnError)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xCE6D48", Offset = "0xCE6D48", VA = "0xCE6D48", Slot = "4")]
		public virtual void UpdateStatus()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xCE6F60", Offset = "0xCE6F60", VA = "0xCE6F60", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xCE6F6C", Offset = "0xCE6F6C", VA = "0xCE6F6C", Slot = "6")]
		protected virtual void OnImportingComplete()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xCE6F88", Offset = "0xCE6F88", VA = "0xCE6F88", Slot = "7")]
		protected virtual void OnModelCreated(GameObject obj, string absolutePath)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xCE6FA4", Offset = "0xCE6FA4", VA = "0xCE6FA4", Slot = "8")]
		protected virtual void OnImported(GameObject obj, string absolutePath)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xCE6FC0", Offset = "0xCE6FC0", VA = "0xCE6FC0", Slot = "9")]
		protected virtual void OnImportError(string absolutePath)
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[RequireComponent(typeof(ObjectImporter))]
	public class ObjectImporterUI : MonoBehaviour
	{
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Text for activity messages")]
		public Text progressText;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Slider for the overall progress")]
		public Slider progressSlider;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Panel with the Image Type set to Filled")]
		public Image progressImage;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ObjectImporter objImporter;

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xCE7A14", Offset = "0xCE7A14", VA = "0xCE7A14")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xCE7B6C", Offset = "0xCE7B6C", VA = "0xCE7B6C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xCE7C44", Offset = "0xCE7C44", VA = "0xCE7C44")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xCE7D1C", Offset = "0xCE7D1C", VA = "0xCE7D1C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xCE846C", Offset = "0xCE846C", VA = "0xCE846C")]
		private void OnImportStart()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xCE8304", Offset = "0xCE8304", VA = "0xCE8304")]
		private void OnImportComplete()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xCE85D0", Offset = "0xCE85D0", VA = "0xCE85D0")]
		public ObjectImporterUI()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public enum RootPathEnum
	{
		[Token(Token = "0x4000457")]
		Url,
		[Token(Token = "0x4000458")]
		DataPath,
		[Token(Token = "0x4000459")]
		DataPathParent,
		[Token(Token = "0x400045A")]
		PersistentDataPath,
		[Token(Token = "0x400045B")]
		CurrentPath
	}
	[Token(Token = "0x20000B9")]
	public class PathSettings : MonoBehaviour
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Default root path for models")]
		public RootPathEnum defaultRootPath;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Root path for models on mobile devices")]
		public RootPathEnum mobileRootPath;

		[Token(Token = "0x17000045")]
		public string RootPath
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0xCE85D8", Offset = "0xCE85D8", VA = "0xCE85D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xCE8688", Offset = "0xCE8688", VA = "0xCE8688")]
		public static PathSettings FindPathComponent(GameObject obj)
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xCE879C", Offset = "0xCE879C", VA = "0xCE879C")]
		public string FullPath(string path)
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xCE882C", Offset = "0xCE882C", VA = "0xCE882C")]
		public PathSettings()
		{
		}
	}
}
namespace BrainFailProductions.PolyFew.AsImpL.MathUtil
{
	[Token(Token = "0x20000BA")]
	public class Triangle
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vertex v1;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vertex v2;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vertex v3;

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xCE8834", Offset = "0xCE8834", VA = "0xCE8834")]
		public Triangle(Vertex v1, Vertex v2, Vertex v3)
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class Vertex
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vertex prevVertex;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vertex nextVertex;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float triangleArea;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool triangleHasChanged;

		[Token(Token = "0x17000046")]
		public Vector3 Position
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0xCE8870", Offset = "0xCE8870", VA = "0xCE8870")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xCE887C", Offset = "0xCE887C", VA = "0xCE887C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public int OriginalIndex
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xCE8888", Offset = "0xCE8888", VA = "0xCE8888")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000407")]
			[Address(RVA = "0xCE8890", Offset = "0xCE8890", VA = "0xCE8890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public Vertex PreviousVertex
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0xCE8898", Offset = "0xCE8898", VA = "0xCE8898")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000409")]
			[Address(RVA = "0xCE88A0", Offset = "0xCE88A0", VA = "0xCE88A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public Vertex NextVertex
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0xCE88B8", Offset = "0xCE88B8", VA = "0xCE88B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600040B")]
			[Address(RVA = "0xCE88C0", Offset = "0xCE88C0", VA = "0xCE88C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public float TriangleArea
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0xCE88D8", Offset = "0xCE88D8", VA = "0xCE88D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xCE89F8", Offset = "0xCE89F8", VA = "0xCE89F8")]
		public Vertex(int originalIndex, Vector3 position)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xCE8A44", Offset = "0xCE8A44", VA = "0xCE8A44")]
		public Vector2 GetPosOnPlane(Vector3 planeNormal)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xCE88FC", Offset = "0xCE88FC", VA = "0xCE88FC")]
		private void ComputeTriangleArea()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public static class MathUtility
	{
		[Token(Token = "0x6000410")]
		[Address(RVA = "0xCE8AD0", Offset = "0xCE8AD0", VA = "0xCE8AD0")]
		public static int ClampListIndex(int index, int listSize)
		{
			return default(int);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xCE8AE8", Offset = "0xCE8AE8", VA = "0xCE8AE8")]
		public static bool IsPointInTriangle(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xCE8B78", Offset = "0xCE8B78", VA = "0xCE8B78")]
		public static bool IsTriangleOrientedClockwise(Vector2 v1, Vector2 v2, Vector2 v3)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xCE8BB0", Offset = "0xCE8BB0", VA = "0xCE8BB0")]
		public static Vector3 ComputeNormal(Vector3 vert, Vector3 vNext, Vector3 vPrev)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000BD")]
	public static class Triangulation
	{
		[Token(Token = "0x6000414")]
		[Address(RVA = "0xCE8CC8", Offset = "0xCE8CC8", VA = "0xCE8CC8")]
		public static List<Triangle> TriangulateConvexPolygon(List<Vertex> vertices, bool preserveOriginalVertices = true)
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xCE91C8", Offset = "0xCE91C8", VA = "0xCE91C8")]
		public static List<Triangle> TriangulateByEarClipping(List<Vertex> origVertices, Vector3 planeNormal, string meshName, bool preserveOriginalVertices = true)
		{
			return null;
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xCE90F4", Offset = "0xCE90F4", VA = "0xCE90F4")]
		public static Triangle ClipTriangle(Vertex vertex, List<Vertex> vertices)
		{
			return null;
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xCE97C0", Offset = "0xCE97C0", VA = "0xCE97C0")]
		private static Triangle ClipEar(Vertex earVertex, List<Vertex> earVertices, List<Vertex> vertices, Vector3 planeNormal)
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xCE8F20", Offset = "0xCE8F20", VA = "0xCE8F20")]
		private static Vertex FindMaxAreaEarVertex(List<Vertex> earVertices)
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xCE9640", Offset = "0xCE9640", VA = "0xCE9640")]
		private static List<Vertex> FindEarVertices(List<Vertex> vertices, Vector3 planeNormal)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xCE9B8C", Offset = "0xCE9B8C", VA = "0xCE9B8C")]
		private static bool IsVertexReflex(Vertex v, Vector3 vNormal)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xCE9994", Offset = "0xCE9994", VA = "0xCE9994")]
		private static bool IsVertexEar(Vertex v, List<Vertex> vertices, Vector3 planeNormal)
		{
			return default(bool);
		}
	}
}
namespace BrainFailProductions.PolyFewRuntime
{
	[Token(Token = "0x20000BE")]
	public class FlyCamera : MonoBehaviour
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float distance;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float xSpeed;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ySpeed;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float panSpeed;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yMinLimit;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float yMaxLimit;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float distanceMin;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float distanceMax;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody rigidbody;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float x;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float y;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool deactivated;

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xCE9C4C", Offset = "0xCE9C4C", VA = "0xCE9C4C")]
		private void Start()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xCE9D14", Offset = "0xCE9D14", VA = "0xCE9D14")]
		private void Update()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xCEA030", Offset = "0xCEA030", VA = "0xCEA030")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xCEA06C", Offset = "0xCEA06C", VA = "0xCEA06C")]
		public FlyCamera()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class PolygonReduction : MonoBehaviour
	{
		[Token(Token = "0x20000C4")]
		[CompilerGenerated]
		private sealed class <ShowMessage>d__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string message;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PolygonReduction <>4__this;

			[Token(Token = "0x1700004B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000442")]
				[Address(RVA = "0xCEE7A8", Offset = "0xCEE7A8", VA = "0xCEE7A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000444")]
				[Address(RVA = "0xCEE7F0", Offset = "0xCEE7F0", VA = "0xCEE7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0xCEDE48", Offset = "0xCEDE48", VA = "0xCEDE48")]
			[DebuggerHidden]
			public <ShowMessage>d__40(int <>1__state)
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0xCEE684", Offset = "0xCEE684", VA = "0xCEE684", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0xCEE688", Offset = "0xCEE688", VA = "0xCEE688", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0xCEE7B0", Offset = "0xCEE7B0", VA = "0xCEE7B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class <UpdateProgress>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolygonReduction <>4__this;

			[Token(Token = "0x1700004D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000448")]
				[Address(RVA = "0xCEE94C", Offset = "0xCEE94C", VA = "0xCEE94C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600044A")]
				[Address(RVA = "0xCEE994", Offset = "0xCEE994", VA = "0xCEE994", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0xCEDE70", Offset = "0xCEDE70", VA = "0xCEDE70")]
			[DebuggerHidden]
			public <UpdateProgress>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x6000446")]
			[Address(RVA = "0xCEE7F8", Offset = "0xCEE7F8", VA = "0xCEE7F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0xCEE7FC", Offset = "0xCEE7FC", VA = "0xCEE7FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0xCEE954", Offset = "0xCEE954", VA = "0xCEE954", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Slider reductionStrength;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Slider preservationStrength;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Toggle preserveUVFoldover;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Toggle preserveUVSeams;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Toggle preserveBorders;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Toggle enableSmartLinking;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Toggle preserveFace;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Toggle recalculateNormals;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Toggle regardCurvature;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InputField trianglesCount;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Text message;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Text progress;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Button exportButton;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Button importFromFileSystem;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Button importFromWeb;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Slider progressSlider;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject uninteractivePanel;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GameObject targetObject;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Transform preservationSphere;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public EventSystem eventSystem;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private PolyfewRuntime.ObjectMeshPairs objectMeshPairs;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool didApplyLosslessLast;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool disableTemporary;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject barabarianRef;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool isImportingFromNetwork;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private bool isWebGL;

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xCEA088", Offset = "0xCEA088", VA = "0xCEA088")]
		private void Start()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xCEA82C", Offset = "0xCEA82C", VA = "0xCEA82C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xCEA990", Offset = "0xCEA990", VA = "0xCEA990")]
		public void OnReductionChange(float value)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xCECC9C", Offset = "0xCECC9C", VA = "0xCECC9C")]
		public void SimplifyLossless()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xCECEA4", Offset = "0xCECEA4", VA = "0xCECEA4")]
		public void ImportOBJ()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xCED1D8", Offset = "0xCED1D8", VA = "0xCED1D8")]
		public void ImportOBJFromNetwork()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xCED5E8", Offset = "0xCED5E8", VA = "0xCED5E8")]
		public void ExportGameObjectToOBJ()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xCED964", Offset = "0xCED964", VA = "0xCED964")]
		public void OnToggleStateChanged(bool isOn)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xCED9FC", Offset = "0xCED9FC", VA = "0xCED9FC")]
		public void OnPreservationStrengthChange(float value)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xCEDA04", Offset = "0xCEDA04", VA = "0xCEDA04")]
		public void Reset()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xCEDCCC", Offset = "0xCEDCCC", VA = "0xCEDCCC")]
		public static void OnSliderSelect()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xCEDD18", Offset = "0xCEDD18", VA = "0xCEDD18")]
		public static void OnSliderDeselect()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xCEDD60", Offset = "0xCEDD60", VA = "0xCEDD60")]
		private bool IsMouseOverUI(RectTransform uiElement)
		{
			return default(bool);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xCEDDD4", Offset = "0xCEDDD4", VA = "0xCEDDD4")]
		[IteratorStateMachine(typeof(<ShowMessage>d__40))]
		private IEnumerator ShowMessage(string message)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xCEDBF0", Offset = "0xCEDBF0", VA = "0xCEDBF0")]
		private void ResetSettings()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xCED490", Offset = "0xCED490", VA = "0xCED490")]
		[IteratorStateMachine(typeof(<UpdateProgress>d__42))]
		private IEnumerator UpdateProgress()
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xCEAD7C", Offset = "0xCEAD7C", VA = "0xCEAD7C")]
		private void AssignMeshesFromPairs()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xCEDE98", Offset = "0xCEDE98", VA = "0xCEDE98")]
		public PolygonReduction()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public static class MeshCombiner
	{
		[Token(Token = "0x20000C7")]
		public struct StaticRenderer
		{
			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool isNewMesh;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh mesh;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Material[] materials;
		}

		[Token(Token = "0x20000C8")]
		public struct SkinnedRenderer
		{
			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool hasBlendShapes;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string name;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isNewMesh;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform transform;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Mesh mesh;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Material[] materials;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform rootBone;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform[] bones;
		}

		[Serializable]
		[Token(Token = "0x20000C9")]
		public struct BlendShape
		{
			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string ShapeName;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public BlendShapeFrame[] Frames;

			[Token(Token = "0x6000461")]
			[Address(RVA = "0xCF445C", Offset = "0xCF445C", VA = "0xCF445C")]
			public BlendShape(string shapeName, BlendShapeFrame[] frames)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CA")]
		public struct BlendShapeFrame
		{
			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string shapeName;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float frameWeight;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] deltaVertices;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3[] deltaNormals;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3[] deltaTangents;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int vertexOffset;

			[Token(Token = "0x6000462")]
			[Address(RVA = "0xCF4464", Offset = "0xCF4464", VA = "0xCF4464")]
			public BlendShapeFrame(float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents)
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0xCF21C0", Offset = "0xCF21C0", VA = "0xCF21C0")]
			public BlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents, int vertexOffset)
			{
			}
		}

		[Token(Token = "0x20000CB")]
		public static class MeshUtils
		{
			[Token(Token = "0x40004BA")]
			public const int UVChannelCount = 8;

			[Token(Token = "0x6000464")]
			[Address(RVA = "0xCF44E8", Offset = "0xCF44E8", VA = "0xCF44E8")]
			public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs, Matrix4x4[] bindposes, BlendShape[] blendShapes)
			{
				return null;
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0xCF4014", Offset = "0xCF4014", VA = "0xCF4014")]
			public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector4>[] uvs, Matrix4x4[] bindposes, BlendShape[] blendShapes)
			{
				return null;
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0xCF4510", Offset = "0xCF4510", VA = "0xCF4510")]
			public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs2D, List<Vector3>[] uvs3D, List<Vector4>[] uvs4D, Matrix4x4[] bindposes, BlendShape[] blendShapes)
			{
				return null;
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0xCF4B9C", Offset = "0xCF4B9C", VA = "0xCF4B9C")]
			public static BlendShape[] GetMeshBlendShapes(Mesh mesh)
			{
				return null;
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0xCF4A34", Offset = "0xCF4A34", VA = "0xCF4A34")]
			public static void ApplyMeshBlendShapes(Mesh mesh, BlendShape[] blendShapes)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0xCF38D0", Offset = "0xCF38D0", VA = "0xCF38D0")]
			public static List<Vector4>[] GetMeshUVs(Mesh mesh)
			{
				return null;
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0xCF4E74", Offset = "0xCF4E74", VA = "0xCF4E74")]
			public static List<Vector4> GetMeshUVs(Mesh mesh, int channel)
			{
				return null;
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0xCF4FE8", Offset = "0xCF4FE8", VA = "0xCF4FE8")]
			public static int GetUsedUVComponents(List<Vector4> uvs)
			{
				return default(int);
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0xCF518C", Offset = "0xCF518C", VA = "0xCF518C")]
			public static Vector2[] ConvertUVsTo2D(List<Vector4> uvs)
			{
				return null;
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0xCF5264", Offset = "0xCF5264", VA = "0xCF5264")]
			public static Vector3[] ConvertUVsTo3D(List<Vector4> uvs)
			{
				return null;
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0xCF48B0", Offset = "0xCF48B0", VA = "0xCF48B0")]
			public static Vector2Int[] GetSubMeshIndexMinMax(int[][] indices, out IndexFormat indexFormat)
			{
				return null;
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0xCF533C", Offset = "0xCF533C", VA = "0xCF533C")]
			private static void GetIndexMinMax(int[] indices, out int minIndex, out int maxIndex)
			{
			}
		}

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MeshRenderer[] unityCombinedMeshRenderers;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Material[] unityCombinedMeshesMats;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool didUseUnityCombine;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public static bool generateUV2;

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xCEE99C", Offset = "0xCEE99C", VA = "0xCEE99C")]
		public static StaticRenderer[] GetStaticRenderers(MeshRenderer[] renderers)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xCEECC0", Offset = "0xCEECC0", VA = "0xCEECC0")]
		public static SkinnedRenderer[] GetSkinnedRenderers(SkinnedMeshRenderer[] renderers)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xCEEF68", Offset = "0xCEEF68", VA = "0xCEEF68")]
		public static StaticRenderer[] CombineStaticMeshes(Transform transform, int levelIndex, MeshRenderer[] renderers, bool autoName = true, string combinedBaseName = "")
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xCF0AB0", Offset = "0xCF0AB0", VA = "0xCF0AB0")]
		public static SkinnedRenderer[] CombineSkinnedMeshes(Transform transform, int levelIndex, SkinnedMeshRenderer[] renderers, ref SkinnedMeshRenderer[] renderersActuallyCombined, bool autoName = true, string combinedBaseName = "")
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xCF0260", Offset = "0xCF0260", VA = "0xCF0260")]
		public static Mesh CombineMeshes(Transform rootTransform, MeshRenderer[] renderers, out Material[] resultMaterials, [Optional] Dictionary<Transform, Transform> topLevelParents, [Optional] Dictionary<string, BlendShapeFrame> blendShapes)
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xCF11CC", Offset = "0xCF11CC", VA = "0xCF11CC")]
		public static Mesh CombineMeshes(Transform rootTransform, SkinnedMeshRenderer[] renderers, out Material[] resultMaterials, out Transform[] resultBones)
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xCF20F4", Offset = "0xCF20F4", VA = "0xCF20F4")]
		public static Mesh CombineMeshes(Mesh[] meshes, Matrix4x4[] transforms, Tuple<Matrix4x4, bool>[] normalsTransforms, Material[][] materials, out Material[] resultMaterials, [Optional] Dictionary<string, BlendShapeFrame> blendShapes)
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xCF21D8", Offset = "0xCF21D8", VA = "0xCF21D8")]
		public static Mesh CombineMeshes(Mesh[] meshes, Matrix4x4[] transforms, Tuple<Matrix4x4, bool>[] normalsTransforms, Material[][] materials, Transform[][] bones, out Material[] resultMaterials, out Transform[] resultBones, [Optional] Dictionary<string, BlendShapeFrame> blendShapes)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xCF4040", Offset = "0xCF4040", VA = "0xCF4040")]
		private static void ParentAndResetTransform(Transform transform, Transform parentTransform)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xCF4128", Offset = "0xCF4128", VA = "0xCF4128")]
		private static void ParentAndOffsetTransform(Transform transform, Transform parentTransform, Transform originalTransform)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xCF1F50", Offset = "0xCF1F50", VA = "0xCF1F50")]
		private static Transform FindBestRootBone(Transform transform, SkinnedMeshRenderer[] skinnedMeshRenderers)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xCF41AC", Offset = "0xCF41AC", VA = "0xCF41AC")]
		private static Transform FindBestRootBone(Dictionary<Transform, Transform> topLevelParents, SkinnedMeshRenderer[] skinnedMeshRenderers)
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xCF43A0", Offset = "0xCF43A0", VA = "0xCF43A0")]
		private static Transform GetTopLevelParent(Transform forObject)
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xCF3F18", Offset = "0xCF3F18", VA = "0xCF3F18")]
		private static void CopyVertexPositions(List<Vector3> list, Vector3[] arr)
		{
		}

		[Token(Token = "0x6000459")]
		private static void CopyVertexAttributes<T>(ref List<T> dest, IEnumerable<T> src, int previousVertexCount, int meshVertexCount, int totalVertexCount, T defaultValue)
		{
		}

		[Token(Token = "0x600045A")]
		private static T[] MergeArrays<T>(T[] arr1, T[] arr2)
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xCF3C0C", Offset = "0xCF3C0C", VA = "0xCF3C0C")]
		private static void TransformVertices(Vector3[] vertices, ref Matrix4x4 transform)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xCF3C90", Offset = "0xCF3C90", VA = "0xCF3C90")]
		private static void TransformNormals(Vector3[] normals, ref Tuple<Matrix4x4, bool> transform)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xCF3E48", Offset = "0xCF3E48", VA = "0xCF3E48")]
		private static void TransformTangents(Vector4[] tangents, ref Tuple<Matrix4x4, bool> transform)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xCF3A14", Offset = "0xCF3A14", VA = "0xCF3A14")]
		private static void RemapBones(BoneWeight[] boneWeights, int[] boneIndices)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xCF4438", Offset = "0xCF4438", VA = "0xCF4438")]
		private static Matrix4x4 ScaleMatrix(ref Matrix4x4 matrix, float scale)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xCEF544", Offset = "0xCEF544", VA = "0xCEF544")]
		private static void CombineMeshesUnity(Transform parentTransform, MeshFilter[] meshFilters)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[AddComponentMenu("")]
	public class PolyfewRuntime : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CE")]
		public class ObjectMeshPairs : Dictionary<GameObject, MeshRendererPair>
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0xCFE210", Offset = "0xCFE210", VA = "0xCFE210")]
			public ObjectMeshPairs()
			{
			}
		}

		[Token(Token = "0x20000CF")]
		public enum MeshCombineTarget
		{
			[Token(Token = "0x40004C2")]
			SkinnedAndStatic,
			[Token(Token = "0x40004C3")]
			StaticOnly,
			[Token(Token = "0x40004C4")]
			SkinnedOnly
		}

		[Serializable]
		[Token(Token = "0x20000D0")]
		public class MeshRendererPair
		{
			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool attachedToMeshFilter;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh mesh;

			[Token(Token = "0x600048C")]
			[Address(RVA = "0xCFE258", Offset = "0xCFE258", VA = "0xCFE258")]
			public MeshRendererPair(bool attachedToMeshFilter, Mesh mesh)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0xCFE288", Offset = "0xCFE288", VA = "0xCFE288")]
			public void Destruct()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D1")]
		public class CustomMeshActionStructure
		{
			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MeshRendererPair meshRendererPair;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject gameObject;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action action;

			[Token(Token = "0x600048E")]
			[Address(RVA = "0xCFE318", Offset = "0xCFE318", VA = "0xCFE318")]
			public CustomMeshActionStructure(MeshRendererPair meshRendererPair, GameObject gameObject, Action action)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D2")]
		public class SimplificationOptions
		{
			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float simplificationStrength;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool simplifyMeshLossless;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			public bool enableSmartlinking;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			public bool recalculateNormals;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
			public bool preserveUVSeamEdges;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool preserveUVFoldoverEdges;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool preserveBorderEdges;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			public bool regardPreservationSpheres;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<PreservationSphere> preservationSpheres;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool regardCurvature;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int maxIterations;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float aggressiveness;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool useEdgeSort;

			[Token(Token = "0x600048F")]
			[Address(RVA = "0xCFE354", Offset = "0xCFE354", VA = "0xCFE354")]
			public SimplificationOptions()
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0xCFE3E4", Offset = "0xCFE3E4", VA = "0xCFE3E4")]
			public SimplificationOptions(float simplificationStrength, bool simplifyOptimal, bool enableSmartlink, bool recalculateNormals, bool preserveUVSeamEdges, bool preserveUVFoldoverEdges, bool preserveBorderEdges, bool regardToleranceSphere, List<PreservationSphere> preservationSpheres, bool regardCurvature, int maxIterations, float aggressiveness, bool useEdgeSort)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D3")]
		public class PreservationSphere
		{
			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 worldPosition;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float diameter;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float preservationStrength;

			[Token(Token = "0x6000491")]
			[Address(RVA = "0xCFE544", Offset = "0xCFE544", VA = "0xCFE544")]
			public PreservationSphere(Vector3 worldPosition, float diameter, float preservationStrength)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D4")]
		public class OBJImportOptions : ImportOptions
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0xCFE59C", Offset = "0xCFE59C", VA = "0xCFE59C")]
			public OBJImportOptions()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D5")]
		public class OBJExportOptions
		{
			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly bool applyPosition;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public readonly bool applyRotation;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			public readonly bool applyScale;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
			public readonly bool generateMaterials;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public readonly bool exportTextures;

			[Token(Token = "0x6000493")]
			[Address(RVA = "0xCFE5A4", Offset = "0xCFE5A4", VA = "0xCFE5A4")]
			public OBJExportOptions(bool applyPosition, bool applyRotation, bool applyScale, bool generateMaterials, bool exportTextures)
			{
			}
		}

		[Token(Token = "0x20000D6")]
		public class ReferencedNumeric<T> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T val;

			[Token(Token = "0x1700004F")]
			public T Value
			{
				[Token(Token = "0x6000494")]
				get
				{
					return (T)null;
				}
				[Token(Token = "0x6000495")]
				set
				{
				}
			}

			[Token(Token = "0x6000496")]
			public ReferencedNumeric(T value)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D7")]
		public class MaterialProperties
		{
			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly int texArrIndex;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public readonly int matIndex;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly string materialName;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public readonly Material originalMaterial;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Color albedoTint;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector4 uvTileOffset;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float normalIntensity;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float occlusionIntensity;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public float smoothnessIntensity;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float glossMapScale;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float metalIntensity;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Color emissionColor;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Vector4 detailUVTileOffset;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public float alphaCutoff;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Color specularColor;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public float detailNormalScale;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public float heightIntensity;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public readonly float uvSec;

			[Token(Token = "0x6000497")]
			[Address(RVA = "0xCFE608", Offset = "0xCFE608", VA = "0xCFE608")]
			public MaterialProperties(int texArrIndex, int matIndex, string materialName, Material originalMaterial, Color albedoTint, Vector4 uvTileOffset, float normalIntensity, float occlusionIntensity, float smoothnessIntensity, float glossMapScale, float metalIntensity, Color emissionColor, Vector4 detailUVTileOffset, float alphaCutoff, Color specularColor, float detailNormalScale, float heightIntensity, float uvSec)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0xCFE7A4", Offset = "0xCFE7A4", VA = "0xCFE7A4")]
			public void BurnAttrToImg(ref Texture2D burnOn, int index, int textureArrayIndex)
			{
			}
		}

		[Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0xD0115C", Offset = "0xD0115C", VA = "0xD0115C")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xD01164", Offset = "0xD01164", VA = "0xD01164")]
			internal void <ImportOBJFromFileSystem>b__0(GameObject importedObject)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private struct <ImportOBJFromFileSystem>d__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objAbsolutePath;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string texturesFolderPath;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string materialsFolderPath;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public OBJImportOptions importOptions;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private <>c__DisplayClass20_0 <>8__1;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Action<Exception> OnError;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xD0118C", Offset = "0xD0118C", VA = "0xD0118C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0xD016B4", Offset = "0xD016B4", VA = "0xD016B4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<Exception> OnError;

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xD016C0", Offset = "0xD016C0", VA = "0xD016C0")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0xD016C8", Offset = "0xD016C8", VA = "0xD016C8")]
			internal void <ImportOBJFromNetwork>b__0(GameObject importedObject)
			{
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xD016F0", Offset = "0xD016F0", VA = "0xD016F0")]
			internal void <ImportOBJFromNetwork>b__1(Exception ex)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private struct <ImportOBJFromNetwork>d__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<Exception> OnError;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string objURL;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string objName;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string diffuseTexURL;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string bumpTexURL;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string specularTexURL;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public string opacityTexURL;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public string materialURL;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public OBJImportOptions importOptions;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private <>c__DisplayClass21_0 <>8__1;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xD01718", Offset = "0xD01718", VA = "0xD01718", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0xD01B70", Offset = "0xD01B70", VA = "0xD01B70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action OnSuccess;

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xD01B7C", Offset = "0xD01B7C", VA = "0xD01B7C")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xD01B84", Offset = "0xD01B84", VA = "0xD01B84")]
			internal void <ExportGameObjectToOBJ>b__0()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000E6")]
		[CompilerGenerated]
		private struct <ExportGameObjectToOBJ>d__22 : IAsyncStateMachine
		{
			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action OnSuccess;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject toExport;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string exportPath;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public OBJExportOptions exportOptions;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action<Exception> OnError;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private <>c__DisplayClass22_0 <>8__1;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60004C9")]
			[Address(RVA = "0xD01BAC", Offset = "0xD01BAC", VA = "0xD01BAC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004CA")]
			[Address(RVA = "0xD02FA4", Offset = "0xD02FA4", VA = "0xD02FA4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40004C0")]
		private const int MAX_LOD_COUNT = 8;

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xCF564C", Offset = "0xCF564C", VA = "0xCF564C")]
		public static int SimplifyObjectDeep(GameObject toSimplify, SimplificationOptions simplificationOptions, Action<GameObject, MeshRendererPair> OnEachMeshSimplified)
		{
			return default(int);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xCF787C", Offset = "0xCF787C", VA = "0xCF787C")]
		public static ObjectMeshPairs SimplifyObjectDeep(GameObject toSimplify, SimplificationOptions simplificationOptions)
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xCEB0B0", Offset = "0xCEB0B0", VA = "0xCEB0B0")]
		public static int SimplifyObjectDeep(ObjectMeshPairs objectMeshPairs, SimplificationOptions simplificationOptions, Action<GameObject, MeshRendererPair> OnEachMeshSimplified)
		{
			return default(int);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xCF9338", Offset = "0xCF9338", VA = "0xCF9338")]
		public static List<Mesh> SimplifyMeshes(List<Mesh> meshesToSimplify, SimplificationOptions simplificationOptions, Action<Mesh> OnEachMeshSimplified)
		{
			return null;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xCEA160", Offset = "0xCEA160", VA = "0xCEA160")]
		public static ObjectMeshPairs GetObjectMeshPairs(GameObject forObject, bool includeInactive)
		{
			return null;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xCFA2B4", Offset = "0xCFA2B4", VA = "0xCFA2B4")]
		public static void CombineMeshesInGameObject(GameObject forObject, bool skipInactiveRenderers, Action<string, string> OnError, MeshCombineTarget combineTarget = MeshCombineTarget.SkinnedAndStatic)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xCFB538", Offset = "0xCFB538", VA = "0xCFB538")]
		public static GameObject CombineMeshesFromRenderers(Transform rootTransform, MeshRenderer[] originalMeshRenderers, SkinnedMeshRenderer[] originalSkinnedMeshRenderers, Action<string, string> OnError)
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xCFBC9C", Offset = "0xCFBC9C", VA = "0xCFBC9C")]
		public static void ConvertSkinnedMeshesInGameObject(GameObject forObject, bool skipInactiveRenderers, Action<string, string> OnError)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xCFC478", Offset = "0xCFC478", VA = "0xCFC478")]
		public static Tuple<SkinnedMeshRenderer, MeshRenderer, Mesh>[] ConvertSkinnedMeshesFromRenderers(SkinnedMeshRenderer[] renderersToConvert, Action<string, string> OnError)
		{
			return null;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xCED108", Offset = "0xCED108", VA = "0xCED108")]
		[AsyncStateMachine(typeof(<ImportOBJFromFileSystem>d__20))]
		public static void ImportOBJFromFileSystem(string objAbsolutePath, string texturesFolderPath, string materialsFolderPath, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] OBJImportOptions importOptions)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xCED4F8", Offset = "0xCED4F8", VA = "0xCED4F8")]
		[AsyncStateMachine(typeof(<ImportOBJFromNetwork>d__21))]
		public static void ImportOBJFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] OBJImportOptions importOptions)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xCED8A8", Offset = "0xCED8A8", VA = "0xCED8A8")]
		[AsyncStateMachine(typeof(<ExportGameObjectToOBJ>d__22))]
		public static void ExportGameObjectToOBJ(GameObject toExport, string exportPath, Action OnSuccess, Action<Exception> OnError, [Optional] OBJExportOptions exportOptions)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xCEA490", Offset = "0xCEA490", VA = "0xCEA490")]
		public static int CountTriangles(bool countDeep, GameObject forObject)
		{
			return default(int);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xCFA0BC", Offset = "0xCFA0BC", VA = "0xCFA0BC")]
		public static int CountTriangles(List<Mesh> toCount)
		{
			return default(int);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xCFC9F4", Offset = "0xCFC9F4", VA = "0xCFC9F4")]
		public static List<MaterialProperties> GetMaterialsProperties(GameObject forObject)
		{
			return null;
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xCFCF40", Offset = "0xCFCF40", VA = "0xCFCF40")]
		public static void ChangeMaterialProperties(MaterialProperties changeTo, GameObject forObject)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xCF7818", Offset = "0xCF7818", VA = "0xCF7818")]
		private static void SetParametersForSimplifier(SimplificationOptions simplificationOptions, MeshSimplifier meshSimplifier)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xCF72B4", Offset = "0xCF72B4", VA = "0xCF72B4")]
		private static bool AreAnyFeasibleMeshes(ObjectMeshPairs objectMeshPairs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xCFD024", Offset = "0xCFD024", VA = "0xCFD024")]
		private static void AssignReducedMesh(GameObject gameObject, Mesh originalMesh, Mesh reducedMesh, bool attachedToMeshfilter, bool assignBindposes)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xCF75E0", Offset = "0xCF75E0", VA = "0xCF75E0")]
		private static int CountTriangles(ObjectMeshPairs objectMeshPairs)
		{
			return default(int);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xCFD208", Offset = "0xCFD208", VA = "0xCFD208")]
		public PolyfewRuntime()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class UtilityServicesRuntime : MonoBehaviour
	{
		[Token(Token = "0x20000E8")]
		public class OBJExporterImporter
		{
			[StructLayout(3)]
			[Token(Token = "0x20000E9")]
			[CompilerGenerated]
			private struct <ExportMeshToOBJ>d__15 : IAsyncStateMachine
			{
				[Token(Token = "0x4000579")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int <>1__state;

				[Token(Token = "0x400057A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Token(Token = "0x400057B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public OBJExporterImporter <>4__this;

				[Token(Token = "0x400057C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Mesh mesh;

				[Token(Token = "0x400057D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public string exportPath;

				[Token(Token = "0x400057E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private string <objectName>5__2;

				[Token(Token = "0x400057F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private StringBuilder <sb>5__3;

				[Token(Token = "0x4000580")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private int <lastIndex>5__4;

				[Token(Token = "0x4000581")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
				private int <faceOrder>5__5;

				[Token(Token = "0x4000582")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private Vector3[] <>7__wrap5;

				[Token(Token = "0x4000583")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private int <>7__wrap6;

				[Token(Token = "0x4000584")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
				private Vector3 <vx>5__8;

				[Token(Token = "0x4000585")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private TaskAwaiter <>u__1;

				[Token(Token = "0x4000586")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private Vector2[] <>7__wrap8;

				[Token(Token = "0x4000587")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private Vector2 <v>5__10;

				[Token(Token = "0x4000588")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private int[] <tris>5__11;

				[Token(Token = "0x4000589")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private int <t>5__12;

				[Token(Token = "0x60004E1")]
				[Address(RVA = "0xD04FB8", Offset = "0xD04FB8", VA = "0xD04FB8", Slot = "4")]
				private void MoveNext()
				{
				}

				[Token(Token = "0x60004E2")]
				[Address(RVA = "0xD061D8", Offset = "0xD061D8", VA = "0xD061D8", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout(3)]
			[Token(Token = "0x20000EA")]
			[CompilerGenerated]
			private struct <ImportFromLocalFileSystem>d__20 : IAsyncStateMachine
			{
				[Token(Token = "0x400058A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int <>1__state;

				[Token(Token = "0x400058B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Token(Token = "0x400058C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public string objPath;

				[Token(Token = "0x400058D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public string texturesFolderPath;

				[Token(Token = "0x400058E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public string materialsFolderPath;

				[Token(Token = "0x400058F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public PolyfewRuntime.OBJImportOptions importOptions;

				[Token(Token = "0x4000590")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public Action<GameObject> Callback;

				[Token(Token = "0x4000591")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private GameObject <objectToPopulate>5__2;

				[Token(Token = "0x4000592")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private ObjectImporter <objImporter>5__3;

				[Token(Token = "0x4000593")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private TaskAwaiter<GameObject> <>u__1;

				[Token(Token = "0x60004E3")]
				[Address(RVA = "0xD061E4", Offset = "0xD061E4", VA = "0xD061E4", Slot = "4")]
				private void MoveNext()
				{
				}

				[Token(Token = "0x60004E4")]
				[Address(RVA = "0xD06C30", Offset = "0xD06C30", VA = "0xD06C30", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout(3)]
			[Token(Token = "0x20000EB")]
			[CompilerGenerated]
			private struct <ImportFromNetwork>d__21 : IAsyncStateMachine
			{
				[Token(Token = "0x4000594")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int <>1__state;

				[Token(Token = "0x4000595")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Token(Token = "0x4000596")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public string objURL;

				[Token(Token = "0x4000597")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public string diffuseTexURL;

				[Token(Token = "0x4000598")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public string materialURL;

				[Token(Token = "0x4000599")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

				[Token(Token = "0x400059A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public PolyfewRuntime.OBJImportOptions importOptions;

				[Token(Token = "0x400059B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public string objName;

				[Token(Token = "0x400059C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public string bumpTexURL;

				[Token(Token = "0x400059D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				public string specularTexURL;

				[Token(Token = "0x400059E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				public string opacityTexURL;

				[Token(Token = "0x400059F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				public Action<GameObject> OnSuccess;

				[Token(Token = "0x40005A0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				public Action<Exception> OnError;

				[Token(Token = "0x40005A1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private GameObject <objectToPopulate>5__2;

				[Token(Token = "0x40005A2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private ObjectImporter <objImporter>5__3;

				[Token(Token = "0x40005A3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				private TaskAwaiter<GameObject> <>u__1;

				[Token(Token = "0x60004E5")]
				[Address(RVA = "0xD06C3C", Offset = "0xD06C3C", VA = "0xD06C3C", Slot = "4")]
				private void MoveNext()
				{
				}

				[Token(Token = "0x60004E6")]
				[Address(RVA = "0xD07194", Offset = "0xD07194", VA = "0xD07194", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout(3)]
			[Token(Token = "0x20000ED")]
			[CompilerGenerated]
			private struct <ImportFromNetworkWebGL>d__22 : IAsyncStateMachine
			{
				[Token(Token = "0x40005A8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int <>1__state;

				[Token(Token = "0x40005A9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Token(Token = "0x40005AA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Action<GameObject> OnSuccess;

				[Token(Token = "0x40005AB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public Action<Exception> OnError;

				[Token(Token = "0x40005AC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public string objURL;

				[Token(Token = "0x40005AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public string diffuseTexURL;

				[Token(Token = "0x40005AE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public string materialURL;

				[Token(Token = "0x40005AF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

				[Token(Token = "0x40005B0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public PolyfewRuntime.OBJImportOptions importOptions;

				[Token(Token = "0x40005B1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				public string objName;

				[Token(Token = "0x40005B2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				public string bumpTexURL;

				[Token(Token = "0x40005B3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				public string specularTexURL;

				[Token(Token = "0x40005B4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				public string opacityTexURL;

				[Token(Token = "0x60004EA")]
				[Address(RVA = "0xD072B8", Offset = "0xD072B8", VA = "0xD072B8", Slot = "4")]
				private void MoveNext()
				{
				}

				[Token(Token = "0x60004EB")]
				[Address(RVA = "0xD0779C", Offset = "0xD0779C", VA = "0xD0779C", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool applyPosition;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private bool applyRotation;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			private bool applyScale;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
			private bool generateMaterials;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool exportTextures;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string exportPath;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private MeshFilter meshFilter;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Mesh meshToExport;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private MeshRenderer meshRenderer;

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0xD015AC", Offset = "0xD015AC", VA = "0xD015AC")]
			public OBJExporterImporter()
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xD03B78", Offset = "0xD03B78", VA = "0xD03B78")]
			private void InitializeExporter(GameObject toExport, string exportPath, PolyfewRuntime.OBJExportOptions exportOptions)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xD03F04", Offset = "0xD03F04", VA = "0xD03F04")]
			private void InitializeExporter(Mesh toExport, string exportPath)
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xD040C8", Offset = "0xD040C8", VA = "0xD040C8")]
			private Vector3 RotateAroundPoint(Vector3 point, Vector3 pivot, Quaternion angle)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xD04124", Offset = "0xD04124", VA = "0xD04124")]
			private Vector3 MultiplyVec3s(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0xD01F4C", Offset = "0xD01F4C", VA = "0xD01F4C")]
			public void ExportGameObjectToOBJ(GameObject toExport, string exportPath, [Optional] PolyfewRuntime.OBJExportOptions exportOptions, [Optional] Action OnSuccess)
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xD049B0", Offset = "0xD049B0", VA = "0xD049B0")]
			[AsyncStateMachine(typeof(<ExportMeshToOBJ>d__15))]
			public Task ExportMeshToOBJ(Mesh mesh, string exportPath)
			{
				return null;
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xD04A98", Offset = "0xD04A98", VA = "0xD04A98")]
			private string TryExportTexture(string propertyName, Material m, string exportPath)
			{
				return null;
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xD04BA0", Offset = "0xD04BA0", VA = "0xD04BA0")]
			private string ExportTexture(Texture2D t, string exportPath)
			{
				return null;
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0xD04840", Offset = "0xD04840", VA = "0xD04840")]
			private string ConstructOBJString(int index)
			{
				return null;
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xD04134", Offset = "0xD04134", VA = "0xD04134")]
			private string MaterialToString(Material m)
			{
				return null;
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xD015C0", Offset = "0xD015C0", VA = "0xD015C0")]
			[AsyncStateMachine(typeof(<ImportFromLocalFileSystem>d__20))]
			public Task ImportFromLocalFileSystem(string objPath, string texturesFolderPath, string materialsFolderPath, Action<GameObject> Callback, [Optional] PolyfewRuntime.OBJImportOptions importOptions)
			{
				return null;
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xD01A88", Offset = "0xD01A88", VA = "0xD01A88")]
			[AsyncStateMachine(typeof(<ImportFromNetwork>d__21))]
			public void ImportFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] PolyfewRuntime.OBJImportOptions importOptions)
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xD04ED8", Offset = "0xD04ED8", VA = "0xD04ED8")]
			[AsyncStateMachine(typeof(<ImportFromNetworkWebGL>d__22))]
			public void ImportFromNetworkWebGL(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] PolyfewRuntime.OBJImportOptions importOptions)
			{
			}
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xD02FB0", Offset = "0xD02FB0", VA = "0xD02FB0")]
		public static Texture2D DuplicateTexture(Texture2D source)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xD03174", Offset = "0xD03174", VA = "0xD03174")]
		public static Renderer[] GetChildRenderersForCombining(GameObject forObject, bool skipInactiveChildObjects)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xD03590", Offset = "0xD03590", VA = "0xD03590")]
		public static MeshRenderer CreateStaticLevelRenderer(string name, Transform parentTransform, Transform originalTransform, Mesh mesh, Material[] materials)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xD03954", Offset = "0xD03954", VA = "0xD03954")]
		public static SkinnedMeshRenderer CreateSkinnedLevelRenderer(string name, Transform parentTransform, Transform originalTransform, Mesh mesh, Material[] materials, Transform rootBone, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xD03368", Offset = "0xD03368", VA = "0xD03368")]
		private static void CollectChildRenderersForCombining(Transform transform, List<Renderer> resultRenderers, bool skipInactiveChildObjects)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xD0386C", Offset = "0xD0386C", VA = "0xD0386C")]
		private static void ParentAndResetTransform(Transform transform, Transform parentTransform)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xD037E8", Offset = "0xD037E8", VA = "0xD037E8")]
		public static void ParentAndOffsetTransform(Transform transform, Transform parentTransform, Transform originalTransform)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xD03B70", Offset = "0xD03B70", VA = "0xD03B70")]
		public UtilityServicesRuntime()
		{
		}
	}
}
