using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using MagicLightProbes;
using UnityEngine;
using UnityEngine.Events;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class MLPForceSaveProbes : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1054074", Offset = "0x1054074", VA = "0x1054074")]
	public MLPForceSaveProbes()
	{
	}
}
[Token(Token = "0x2000003")]
[CreateAssetMenu(fileName = "New MLP Settings Asset", menuName = "Magic Tools/Magic Light Probes/Create New Settings Asset", order = 1)]
public class MLPSettings : ScriptableObject
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public global::MagicLightProbes.MagicLightProbes.Workflow workflow;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float probesSpacing;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float cornersDetectionThreshold;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float cornerProbesSpacing;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float distanceFromGeometry;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int divideVolumeOnProbesCount;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool useVolumeBottom;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool selectedObjectsAsGlobal;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float maxHeightAboveGeometry;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float maxHeightAboveTerrain;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public LayerMask collisionDetectionLayers;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float collisionDetectionRadius;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool considerDistanceToLights;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public global::MagicLightProbes.MagicLightProbes.FillingMode fillingMode;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float lightIntensityThreshold;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool cullByColor;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float colorThreshold;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool fillEquivalentVolume;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float equivalentVolumeFillingRate;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool fillUnlitVolume;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float unlitVolumeFillingRate;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool optimizeForMixedLighting;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool tryPreventLightLeakage;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public global::MagicLightProbes.MagicLightProbes.BoundsDisplayMode boundsDisplayMode;

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x105407C", Offset = "0x105407C", VA = "0x105407C")]
	public MLPSettings()
	{
	}
}
namespace MagicLightProbes
{
	[Token(Token = "0x2000004")]
	[ExecuteInEditMode]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/main-component")]
	public class MagicLightProbes : MonoBehaviour
	{
		[Token(Token = "0x2000005")]
		public struct VolumeParameters
		{
			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int volumeIndex;

			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector3 position;

			[Token(Token = "0x40000D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 demensions;

			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1054D8C", Offset = "0x1054D8C", VA = "0x1054D8C")]
			public VolumeParameters(int _volumeIndex, Vector3 _position, Vector3 _demensions)
			{
			}
		}

		[Token(Token = "0x2000006")]
		public enum FillingMode
		{
			[Token(Token = "0x40000D3")]
			VerticalDublicating,
			[Token(Token = "0x40000D4")]
			FullFilling,
			[Token(Token = "0x40000D5")]
			SeparateFilling
		}

		[Token(Token = "0x2000007")]
		public enum ExcludingLightsMode
		{
			[Token(Token = "0x40000D7")]
			AllInList,
			[Token(Token = "0x40000D8")]
			AllExceptInList
		}

		[Token(Token = "0x2000008")]
		public enum Workflow
		{
			[Token(Token = "0x40000DA")]
			Simple,
			[Token(Token = "0x40000DB")]
			Advanced
		}

		[Token(Token = "0x2000009")]
		public enum BoundsDisplayMode
		{
			[Token(Token = "0x40000DD")]
			Always,
			[Token(Token = "0x40000DE")]
			OnSelection
		}

		[Token(Token = "0x200000A")]
		public enum DebugPasses
		{
			[Token(Token = "0x40000E0")]
			MaximumHeight,
			[Token(Token = "0x40000E1")]
			GeometryCollision,
			[Token(Token = "0x40000E2")]
			GeometryIntersections,
			[Token(Token = "0x40000E3")]
			NearGeometry,
			[Token(Token = "0x40000E4")]
			OutOfRange,
			[Token(Token = "0x40000E5")]
			OutOfRangeBorders,
			[Token(Token = "0x40000E6")]
			ShadingBorders,
			[Token(Token = "0x40000E7")]
			ContrastAreas,
			[Token(Token = "0x40000E8")]
			NearLights,
			[Token(Token = "0x40000E9")]
			LightIntensity,
			[Token(Token = "0x40000EA")]
			UnlitProbes,
			[Token(Token = "0x40000EB")]
			EqualProbes,
			[Token(Token = "0x40000EC")]
			GeometryEdges,
			[Token(Token = "0x40000ED")]
			EqualColor
		}

		[Token(Token = "0x200000B")]
		public enum DrawModes
		{
			[Token(Token = "0x40000EF")]
			Accepted,
			[Token(Token = "0x40000F0")]
			Culled,
			[Token(Token = "0x40000F1")]
			Both
		}

		[Token(Token = "0x200000C")]
		public enum CalculationTarget
		{
			[Token(Token = "0x40000F3")]
			GeometryEdges,
			[Token(Token = "0x40000F4")]
			GeneralCalculation
		}

		[Serializable]
		[Token(Token = "0x200000D")]
		private struct TempPointData
		{
			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float xPos;

			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float yPos;

			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float zPos;

			[Token(Token = "0x6000009")]
			[Address(RVA = "0x1054DA0", Offset = "0x1054DA0", VA = "0x1054DA0")]
			public TempPointData(Vector3 _position)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200000E")]
		public class WorkPathFoundEvent : UnityEvent<string>
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x1054DAC", Offset = "0x1054DAC", VA = "0x1054DAC")]
			public WorkPathFoundEvent()
			{
			}
		}

		[Token(Token = "0x4000019")]
		private const string COMPUTE_SHADERS_FOLDER = "/Passes/Compute Shaders/";

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator colorThresholdRecalculationRoutine;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator lightProbesVolumeCalculatingRoutine;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator lightProbesVolumeCalculatingSubRoutine;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IEnumerator executingPassesRoutine;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IEnumerator volumeDivideingRoutine;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool autoSaveSettings;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MLPSettings lastSettingsAsset;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<string> groundAndFloorObjects;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<string> storedGroundAndFloorKeywords;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject probesVolume;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useDynamicDensity;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float volumeSpacing;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float volumeSpacingMin;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float volumeSpacingMax;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float cornersDetectionThreshold;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float cornersDetectionThresholdMin;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float cornersDetectionThresholdMax;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float lastCornersDetectionThreshold;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float lastCornersDetectionThresholdMin;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float lastCornersDetectionThresholdMax;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int lastMaxProbesInVolume;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int maxProbesInVolume;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int defaultMaxProbesCount;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float lastVolumeSpacing;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float lastVolumeSpacingMin;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float lastVolumeSpacingMax;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool volumeSpacingChanged;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool tooManySubVolumes;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public FillingMode fillingMode;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public ExcludingLightsMode excludingLightsMode;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public MLPSettings settingsAsset;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Workflow workflow;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float maxHeightAboveGeometry;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float lastMaxHeightAboveGeometry;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float maxHeightAboveTerrain;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool considerDistanceToLights;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float lightIntensityTreshold;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float colorTreshold;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float collisionDetectionRadius;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool saveProbesNearbyGeometry;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float cornerProbesSpacing;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float nearbyGeometryDetectionRadius;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public float nearbyGeometryDetectionRadiusMin;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float nearbyGeometryDetectionRadiusMax;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public float distanceFromNearbyGeometry;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool fillEquivalentVolume;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public float equivalentVolumeFillingRate;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public bool fillUnlitVolume;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		public bool fillFreeVolume;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public float unlitVolumeFillingRate;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float freeVolumeFillingRate;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool cullAcceptedVolume;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float acceptedVolumeFillingRate;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public float nearbyGeometryVolumeFillingRate;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public float verticalDublicatingHeight;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public float verticalDublicatingStep;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public LayerMask raycastFilter;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public List<MLPLight> excludedLights;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public LayerMask layerMask;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public int firstCollisionLayer;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool useMultithreading;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public GameObject previousSelection;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool unloaded;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		public bool sceneChanging;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		public bool waitForPrevious;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public MagicLightProbes previousVolume;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public bool optimizeForMixedLighting;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		public bool lastOptimizeForMixedLightingValue;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
		public bool lastUseDynamicDensityValue;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
		public bool preventLeakageThroughWalls;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public bool useVolumeBottom;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15D")]
		public bool placeProbesOnGeometryEdges;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float lastColorThreshold;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public float lastLightIntensityThreshold;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public float lastEquivalentVolumeFillingRate;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public float lastUnlitVolumeFillingRate;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public float lastFreeVolumeFillingRate;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public float lastCornerProbesSpacing;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public float lastDistanceFromGeometry;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public bool debugMode;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public float debugObjectScale;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public BoundsDisplayMode boundsDisplayMode;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public DebugPasses debugPass;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public DrawModes drawMode;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public bool debugShowLightIntensity;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x191")]
		public bool showPreviewGrid;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x192")]
		public bool nextStep;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x193")]
		public bool cullByColor;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		public bool forceSaveProbesOnShadingBorders;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public string dataPath;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public string workPath;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public bool workPathFound;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public List<Vector3> localFinishedPositions;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public ComputeShader calculateVolumeFilling;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public ComputeShader calculateProbeSpacing;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public ComputeShader calculateDistanceFromGeometry;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public MLPVolume currentVolume;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool recalculationRequired;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private List<Collider> lightColliders;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private List<Collider> objectColliders;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private List<MLPPointData> finalDebugAcceptedPoints;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private List<MLPPointData> finalDebugCulledPoints;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private List<GameObject> tempObjects;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private List<GameObject> temporarilyDisabledDynamicObjects;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private List<GameObject> staticObjectsWithoutCollider;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public List<GameObject> finalStaticGameObjectsList;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private GameObject combinedVolumeObject;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private VolumeParameters currentEditingVolume;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		private Vector3 currentSelectedObjectLastPosition;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private GameObject lastSelectedObject;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		public bool cancelCombination;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		public List<IEnumerator> passesToExecute;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		public List<GameObject> staticObjects;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		public List<MLPLight> lights;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		public List<MLPPointData> tmpSharedPointsArray;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		public List<MLPPointData> tmpOutOfRangePoints;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public List<MLPPointData> tmpOutOfMaxHeightPoints;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		public List<MLPPointData> tmpGeometryCollisionPoints;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		public List<MLPPointData> tmpContrastOnOutOfRangePoints;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		public List<MLPPointData> tmpContrastShadingBordersPoints;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		public List<MLPPointData> tmpUnlitPoints;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		public List<MLPPointData> tmpFreePoints;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		public List<MLPPointData> tmpNearbyGeometryPoints;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		public List<MLPPointData> tmpPointsNearGeometryIntersections;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		public List<MLPPointData> tmpNearbyLightsPoints;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		public List<MLPPointData> tmpEqualPoints;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		public List<MLPPointData> debugCulledPoints;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		public List<MLPPointData> debugAcceptedPoints;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		public List<GameObject> subVolumesDivided;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		public List<Vector3> points;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		public List<VolumeParameters> innerVolumes;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		public List<VolumeParameters> subVolumesParameters;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		public List<MagicLightProbes> innerVolumesObjects;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		public List<LayerMask> layerMasks;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		public List<Vector3> transformedPoints;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		public string assetEditorPath;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		public MagicLightProbes parentVolume;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool operationalDataLost;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		public bool localOperationalDataLost;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x331")]
		public bool recombinationNeeded;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x332")]
		public bool isInBackground;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x333")]
		public bool realtimeEditing;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x334")]
		public bool calculated;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x335")]
		public bool calculatingError;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		public int xPointsCount;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
		public int yPointsCount;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		public int zPointsCount;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
		public float prevVolumeScaleX;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		public float prevVolumeScaleY;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34C")]
		public float prevVolumeScaleZ;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		public int totalProbes;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x354")]
		public int totalProbesInSubVolume;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		public int totalProbesInVolume;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35C")]
		public bool calculatingVolume;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35D")]
		public bool calculatingVolumeSubPass;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		public string currentPass;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		public int currentPassProgressCounter;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
		public int currentPassProgressFrameSkipper;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		public float totalProgress;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
		public float currentPassProgress;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		public int selectedTab;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37C")]
		public bool showOptionsInManagerWindow;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37D")]
		public bool restored;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		public int currentVolumePart;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x384")]
		public float eta;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		public bool changed;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x389")]
		public bool redivideParts;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38A")]
		public bool combinedVolumeError;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38B")]
		public bool isInPrefab;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38C")]
		public Vector3 prefabPosition;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		public GameObject prefabRoot;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		public MLPPrefab prefabConnectionObject;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		public string prefabRootName;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		public bool calculatedFromPrefab;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		public string prefabUID;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private bool passesExecuting;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C4")]
		private int totalProgressCounter;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private int totalProgressFrameSkipper;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3CC")]
		private float startTime;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private float endTime;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D4")]
		private bool scenePreparing;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1054084", Offset = "0x1054084", VA = "0x1054084")]
		public void CheckForNearContrast(MLPPointData pointForCheck)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x105446C", Offset = "0x105446C", VA = "0x105446C")]
		public bool UpdateProgress(int count, int period = 100)
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x10544B4", Offset = "0x10544B4", VA = "0x10544B4")]
		private bool UpdateTotalProgress(int count, int period = 100)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x10544FC", Offset = "0x10544FC", VA = "0x10544FC")]
		public MagicLightProbes()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[ExecuteInEditMode]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-combined-volume")]
	public class MLPCombinedVolume : MonoBehaviour
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1054DF4", Offset = "0x1054DF4", VA = "0x1054DF4")]
		public MLPCombinedVolume()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-light")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class MLPLight : MonoBehaviour
	{
		[Token(Token = "0x2000011")]
		public enum CalculationMode
		{
			[Token(Token = "0x400011D")]
			AccurateShadows,
			[Token(Token = "0x400011E")]
			LightIntensity
		}

		[Token(Token = "0x2000012")]
		public enum MLPLightType
		{
			[Token(Token = "0x4000120")]
			Spot,
			[Token(Token = "0x4000121")]
			Directional,
			[Token(Token = "0x4000122")]
			Point,
			[Token(Token = "0x4000123")]
			Area,
			[Token(Token = "0x4000124")]
			Mesh
		}

		[Token(Token = "0x2000013")]
		public enum MLPLightTypeMA
		{
			[Token(Token = "0x4000126")]
			Area = 3,
			[Token(Token = "0x4000127")]
			Mesh
		}

		[Token(Token = "0x2000014")]
		public enum TracePointSettingMode
		{
			[Token(Token = "0x4000129")]
			Auto,
			[Token(Token = "0x400012A")]
			Custom
		}

		[Token(Token = "0x2000015")]
		public enum ShadowmaskMode
		{
			[Token(Token = "0x400012C")]
			Shadowmask,
			[Token(Token = "0x400012D")]
			DistanceShadowmask
		}

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MLPLightType lightType;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MLPLightType lastLightType;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MLPLightTypeMA lightTypeMA;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CalculationMode calculationMode;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TracePointSettingMode tracePointSettingType;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LightmapBakeType lightMode;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ShadowmaskMode shadowmaskMode;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Light targetLight;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject parentGameObject;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 position;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 forward;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool saveNearbyProbes;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float saveRadius;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float range;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool useSourceParameters;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool reverseDirection;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float angle;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool customTracePoints;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		public bool accurateTrace;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int accuracy;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int lastAccuracy;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool isDirectional;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float tracePointSize;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float lastTracePointSize;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public MeshFilter lastMesh;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<GameObject> tracePoints;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<MLPTracePoint> tracePointsData;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public MLPTracePoint mainTracePoint;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public MagicLightProbes parentVolume;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool showOptionsInManagerWindow;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float intensity;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool resetEditor;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		public bool showLightOnScene;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		public bool saveOnOutOfRange;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC3")]
		public bool isHDRP;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector2 hdrpAreaSize;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1054DFC", Offset = "0x1054DFC", VA = "0x1054DFC")]
		public MLPLight()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class MLPPointData
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float lightIntensity;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxIntencity;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 position;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int col;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int row;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int depth;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<float> distancesToLights;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Vector3> collisionPoints;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<MLPPointData> nearbyPoints;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<MLPPointData> nearbyPointsOptimaziable;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool removed;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool outOfRange;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool inSaveRange;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		public bool savedNearGeometry;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool contrastOnOutOfRangeArea;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool inRangeOfLight;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		public bool contrastOnShadingArea;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		public bool equalIntensity;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool equalColor;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool borderPoint;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool outOfMaxHeight;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float angleToLight;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 contactPoint;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool inCorner;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool lockForCull;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		public bool onGeometryEdge;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F")]
		public bool lightLeakLocked;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 collisionNormal;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<MLPLight> inRangeForLights;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MLPLight> inShadowForLights;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject temporaryObject;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject collisionObject;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color averagedColor;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool xEndPoint;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool yEndPoint;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		public bool zEndPoint;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB3")]
		public bool xStartPoint;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool yStartPoint;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public bool zStartPoint;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int equivalent;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float avaragedColorValue;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool isUnlit;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1054EE0", Offset = "0x1054EE0", VA = "0x1054EE0")]
		public void SetPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1054EEC", Offset = "0x1054EEC", VA = "0x1054EEC")]
		public void SetOutOfRange(bool visibility)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1054EF8", Offset = "0x1054EF8", VA = "0x1054EF8")]
		public void SetLightIntensity(float intensity)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1054F00", Offset = "0x1054F00", VA = "0x1054F00")]
		public void SetInSaveRange(bool value)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1054F0C", Offset = "0x1054F0C", VA = "0x1054F0C")]
		public void SetInContrastArea(bool value)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1054F18", Offset = "0x1054F18", VA = "0x1054F18")]
		public MLPPointData()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	public class MLPPrefab : MonoBehaviour
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public new string name;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string uid;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x10550E8", Offset = "0x10550E8", VA = "0x10550E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1055164", Offset = "0x1055164", VA = "0x1055164")]
		public MLPPrefab()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-quick-editing")]
	public class MLPQuickEditing : MonoBehaviour
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MagicLightProbes parent;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float gizmoScale;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float drawDistance;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 _lastPrefabPosition;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion _lastPrefabRotation;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x105516C", Offset = "0x105516C", VA = "0x105516C")]
		public MLPQuickEditing()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public class MLPTracePoint
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 forward;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject pointGameObject;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x105520C", Offset = "0x105520C", VA = "0x105520C")]
		public MLPTracePoint()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	public class MLPVolume : MonoBehaviour
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public MagicLightProbes parentRootComponent;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public MeshRenderer selfRenderer;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool showGizmo;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool showGizmoSelected;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool isPartVolume;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool isSubdividedPart;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool isCalculated;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool isInProcess;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		public bool skipped;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int id;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color colorOnSelection;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<MLPPointData> localAcceptedPoints;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<MLPPointData> localNearbyGeometryPoints;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<MLPPointData> localContrastPoints;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<MLPPointData> localCornerPoints;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<Vector3> localNearbyGeometryPointsPositions;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<Vector3> resultNearbyGeometryPointsPositions;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<Vector3> localCornerPointsPositions;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<Vector3> resultLocalCornerPointsPositions;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<Vector3> localEquivalentPointsPositions;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<Vector3> resultLocalEquivalentPointsPositions;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<Vector3> resultLocalFreePointsPositions;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<Vector3> localUnlitPointsPositions;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public List<Vector3> localFreePointsPositions;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public List<Vector3> resultLocalUnlitPointsPositions;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public List<Vector3> localDirections;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<Vector3> localAvaragedDirections;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<MLPPointData> localColorThresholdEditingPoints;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int objectsInside;

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1055214", Offset = "0x1055214", VA = "0x1055214")]
		public MLPVolume()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class DublicateVertical
	{
		[Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MagicLightProbes parent;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <steps>5__2;

			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<MLPPointData> <candidates>5__3;

			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<MLPPointData> <savedNearGeometry>5__4;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <i>5__5;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<MLPPointData>.Enumerator <>7__wrap5;

			[Token(Token = "0x17000001")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600001E")]
				[Address(RVA = "0x10561FC", Offset = "0x10561FC", VA = "0x10561FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000002")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000020")]
				[Address(RVA = "0x1056244", Offset = "0x1056244", VA = "0x1056244", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600001A")]
			[Address(RVA = "0x10555C8", Offset = "0x10555C8", VA = "0x10555C8")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x600001B")]
			[Address(RVA = "0x10555F8", Offset = "0x10555F8", VA = "0x10555F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1055614", Offset = "0x1055614", VA = "0x1055614", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600001D")]
			[Address(RVA = "0x10561AC", Offset = "0x10561AC", VA = "0x10561AC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600001F")]
			[Address(RVA = "0x1056204", Offset = "0x1056204", VA = "0x1056204", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1055554", Offset = "0x1055554", VA = "0x1055554")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x10555F0", Offset = "0x10555F0", VA = "0x10555F0")]
		public DublicateVertical()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public static class RandomGen
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random _global;

		[Token(Token = "0x4000189")]
		[ThreadStatic]
		private static System.Random _local;

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x105624C", Offset = "0x105624C", VA = "0x105624C")]
		public static int Next(int min, int max)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200001E")]
	public class EquivalentProbesOptimization
	{
		[Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MagicLightProbes parent;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MLPVolume currentVolume;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool realtimeEditing;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3[] <exit>5__2;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<MLPPointData> <tempList>5__3;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <i>5__4;

			[Token(Token = "0x17000003")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000028")]
				[Address(RVA = "0x1056D30", Offset = "0x1056D30", VA = "0x1056D30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600002A")]
				[Address(RVA = "0x1056D78", Offset = "0x1056D78", VA = "0x1056D78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000025")]
			[Address(RVA = "0x105656C", Offset = "0x105656C", VA = "0x105656C")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x105659C", Offset = "0x105659C", VA = "0x105659C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0x10565A0", Offset = "0x10565A0", VA = "0x10565A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0x1056D38", Offset = "0x1056D38", VA = "0x1056D38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x10564D0", Offset = "0x10564D0", VA = "0x10564D0")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent, [Optional] MLPVolume currentVolume, bool realtimeEditing = false)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1056594", Offset = "0x1056594", VA = "0x1056594")]
		public EquivalentProbesOptimization()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class PartialVolumeFilling
	{
		[Token(Token = "0x2000021")]
		public enum TargetPoint
		{
			[Token(Token = "0x4000193")]
			Unlit,
			[Token(Token = "0x4000194")]
			Equivalent,
			[Token(Token = "0x4000195")]
			Free
		}

		[Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TargetPoint targetPoint;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MagicLightProbes parent;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MLPVolume currentVolume;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool realtimeEditing;

			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<MLPPointData> <tempList>5__2;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<Vector3> <realTimeEditingList>5__3;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private List<Vector3> <targetPoints>5__4;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private float <fillingRate>5__5;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3[] <exit>5__6;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int <i>5__7;

			[Token(Token = "0x17000005")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000030")]
				[Address(RVA = "0x1057E90", Offset = "0x1057E90", VA = "0x1057E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000006")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000032")]
				[Address(RVA = "0x1057ED8", Offset = "0x1057ED8", VA = "0x1057ED8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600002D")]
			[Address(RVA = "0x1056E2C", Offset = "0x1056E2C", VA = "0x1056E2C")]
			[DebuggerHidden]
			public <ExecutePass>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x1056E5C", Offset = "0x1056E5C", VA = "0x1056E5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600002F")]
			[Address(RVA = "0x1056E60", Offset = "0x1056E60", VA = "0x1056E60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000031")]
			[Address(RVA = "0x1057E98", Offset = "0x1057E98", VA = "0x1057E98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1056D80", Offset = "0x1056D80", VA = "0x1056D80")]
		[IteratorStateMachine(typeof(<ExecutePass>d__1))]
		public IEnumerator ExecutePass(MagicLightProbes parent, TargetPoint targetPoint, [Optional] MLPVolume currentVolume, bool realtimeEditing = false)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1056E54", Offset = "0x1056E54", VA = "0x1056E54")]
		public PartialVolumeFilling()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class RemoveUnusedPoints
	{
		[Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MagicLightProbes parent;

			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<MLPPointData> <pointsToRemove>5__2;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <i>5__3;

			[Token(Token = "0x17000007")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000038")]
				[Address(RVA = "0x1058310", Offset = "0x1058310", VA = "0x1058310", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600003A")]
				[Address(RVA = "0x1058358", Offset = "0x1058358", VA = "0x1058358", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1057F54", Offset = "0x1057F54", VA = "0x1057F54")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1057F84", Offset = "0x1057F84", VA = "0x1057F84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1057F88", Offset = "0x1057F88", VA = "0x1057F88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000039")]
			[Address(RVA = "0x1058318", Offset = "0x1058318", VA = "0x1058318", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1057EE0", Offset = "0x1057EE0", VA = "0x1057EE0")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1057F7C", Offset = "0x1057F7C", VA = "0x1057F7C")]
		public RemoveUnusedPoints()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class SetDistanceFromGeometry
	{
		[Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class <ExecutePass>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MLPVolume currentVolume;

			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MagicLightProbes parent;

			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[] <exit>5__2;

			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <i>5__3;

			[Token(Token = "0x17000009")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000040")]
				[Address(RVA = "0x10589C4", Offset = "0x10589C4", VA = "0x10589C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000042")]
				[Address(RVA = "0x1058A0C", Offset = "0x1058A0C", VA = "0x1058A0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600003D")]
			[Address(RVA = "0x10583F0", Offset = "0x10583F0", VA = "0x10583F0")]
			[DebuggerHidden]
			public <ExecutePass>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0x1058420", Offset = "0x1058420", VA = "0x1058420", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600003F")]
			[Address(RVA = "0x1058424", Offset = "0x1058424", VA = "0x1058424", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000041")]
			[Address(RVA = "0x10589CC", Offset = "0x10589CC", VA = "0x10589CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1058360", Offset = "0x1058360", VA = "0x1058360")]
		[IteratorStateMachine(typeof(<ExecutePass>d__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent, MLPVolume currentVolume)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1058418", Offset = "0x1058418", VA = "0x1058418")]
		public SetDistanceFromGeometry()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout(3, CharSet = CharSet.Auto)]
	[Token(Token = "0x2000027")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
	{
	}
}
