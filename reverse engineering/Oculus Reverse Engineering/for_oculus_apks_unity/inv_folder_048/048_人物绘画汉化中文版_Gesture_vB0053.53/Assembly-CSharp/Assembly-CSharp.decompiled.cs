using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using Oculus.Spatializer.Propagation;
using Photon.Chat;
using Photon.Pun;
using Photon.Realtime;
using Photon.Voice.PUN;
using Photon.Voice.Unity;
using Photon.Voice.Unity.UtilityScripts;
using Proto;
using TMPro;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SpatialTracking;
using UnityEngine.UI;
using UnityEngine.XR;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AssetBundleHandler : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	private sealed class <Load>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AssetBundleHandler <>4__this;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AssetBundleCreateRequest <asyncBundleRequest>5__2;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x1249210", Offset = "0x1249210", VA = "0x1249210", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x1249258", Offset = "0x1249258", VA = "0x1249258", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1249048", Offset = "0x1249048", VA = "0x1249048")]
		[DebuggerHidden]
		public <Load>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1249074", Offset = "0x1249074", VA = "0x1249074", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1249078", Offset = "0x1249078", VA = "0x1249078", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1249218", Offset = "0x1249218", VA = "0x1249218", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEngine.Object[] bundleObjects;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<string> bundleNames;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int bundleIndex;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UnityEvent onLoad;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public UnityEvent onUnload;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject lastSpawned;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<AssetBundle> localAssetBundles;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool addedBundle;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material mat;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<int> loadedBundleIndexs;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private AssetBundleCreateRequest asyncBundleRequest;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1211B74", Offset = "0x1211B74", VA = "0x1211B74")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1211B7C", Offset = "0x1211B7C", VA = "0x1211B7C")]
	private void GetNames()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1211C60", Offset = "0x1211C60", VA = "0x1211C60")]
	private void LoadBundle()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1211DF4", Offset = "0x1211DF4", VA = "0x1211DF4")]
	public void LoadBundle(int targetIndex)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1211E88", Offset = "0x1211E88", VA = "0x1211E88")]
	public void UnloadBundle(int targetIndex)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1211D7C", Offset = "0x1211D7C", VA = "0x1211D7C")]
	private IEnumerator Load()
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1212024", Offset = "0x1212024", VA = "0x1212024")]
	private void ChangeMat()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x12121E0", Offset = "0x12121E0", VA = "0x12121E0")]
	private void LoadDelay()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x12121FC", Offset = "0x12121FC", VA = "0x12121FC")]
	public GameObject SpawnFromBundle(int BundleIndex, Transform targetParent)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1212450", Offset = "0x1212450", VA = "0x1212450")]
	public void LoadBundleByName(string Name)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1212590", Offset = "0x1212590", VA = "0x1212590")]
	private void Update()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x121263C", Offset = "0x121263C", VA = "0x121263C")]
	public GameObject SpawnByName(string Name, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x12124A4", Offset = "0x12124A4", VA = "0x12124A4")]
	public void UnloadBundle()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1212770", Offset = "0x1212770", VA = "0x1212770")]
	public AssetBundleHandler()
	{
	}
}
[Token(Token = "0x2000004")]
public class Bezier
{
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1213A14", Offset = "0x1213A14", VA = "0x1213A14")]
	public static Vector3 Quadratic(Vector3 a, Vector3 b, Vector3 c, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1213A78", Offset = "0x1213A78", VA = "0x1213A78")]
	public static Vector3 QuadraticDeduced(Vector3 a, Vector3 b, Vector3 c, float t, out Vector3 handle_dbg)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000005")]
public class Brush2DCanvas : MonoBehaviour, IBrushSurface
{
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material drawMat;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material eraseMat;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material canvasMat;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float canvasWidth;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float canvasHeight;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform canvasTransform;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MeshRenderer[] canvasMeshesForTweakingTransparency;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float aspectRatio;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material[] canvasExtraMaterials;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private RenderTexture drawingBuffer;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private CommandBuffer clearCmd;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Drawing <drawing>k__BackingField;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private BrushMeshCache meshCache;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool renderingInProgress;

	[Token(Token = "0x17000003")]
	public Drawing drawing
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1213E00", Offset = "0x1213E00", VA = "0x1213E00")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1213E08", Offset = "0x1213E08", VA = "0x1213E08")]
		private set
		{
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1213E10", Offset = "0x1213E10", VA = "0x1213E10", Slot = "9")]
	public void Init(Drawing drawing)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x12145B0", Offset = "0x12145B0", VA = "0x12145B0", Slot = "10")]
	public void Destroy()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1214600", Offset = "0x1214600", VA = "0x1214600", Slot = "11")]
	public void SwitchDrawing(Drawing drawing)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1214650", Offset = "0x1214650", VA = "0x1214650")]
	public void SetCanvasTransparency(float alpha)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1214718", Offset = "0x1214718", VA = "0x1214718")]
	public float GetCropPercent()
	{
		return default(float);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1214720", Offset = "0x1214720", VA = "0x1214720")]
	public RenderTexture GetCanvasTextureForSaving()
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1214728", Offset = "0x1214728", VA = "0x1214728", Slot = "12")]
	public void StartRender()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x12149B0", Offset = "0x12149B0", VA = "0x12149B0", Slot = "13")]
	public void FinishRender()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1214D28", Offset = "0x1214D28", VA = "0x1214D28", Slot = "4")]
	public void RenderVisualization(Matrix4x4 matrix, Color col, float size)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x12150F8", Offset = "0x12150F8", VA = "0x12150F8", Slot = "5")]
	public void RenderLazybrushVisuals(Vector3 startPos, Vector3 cursorPos, Vector3 endPos)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x12152C8", Offset = "0x12152C8", VA = "0x12152C8", Slot = "14")]
	public void BeginFrame()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1215324", Offset = "0x1215324", VA = "0x1215324")]
	private static Vector3 ProjectPointOnPlane(Vector3 pos, Vector3 planeNormal, Vector3 planePoint)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1215368", Offset = "0x1215368", VA = "0x1215368")]
	private static float DistPointToPlane(Vector3 pos, Vector3 planeNormal, Vector3 planePoint)
	{
		return default(float);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x12153A0", Offset = "0x12153A0", VA = "0x12153A0")]
	private Vector3 MapWorldSpaceToProjectedWorldSpace(Vector3 worldSpacePos, out float outWorldSpacePlaneDist)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x121548C", Offset = "0x121548C", VA = "0x121548C")]
	private Vector3 MapProjectedWorldSpaceToCanvasSpace(Vector3 projectedWorldSpacePos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1215068", Offset = "0x1215068", VA = "0x1215068")]
	private Vector3 MapCanvasSpaceToUVSpace(Vector3 canvasSpacePos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1214FCC", Offset = "0x1214FCC", VA = "0x1214FCC")]
	public bool ProjectCoordOnSurfaceIfPossible(Vector3 pos, out Vector3 outProjectedWorldPos, out Vector3 outUp, out float outDist, out Vector3 outCanvasSpacePos)
	{
		return default(bool);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x12155D8", Offset = "0x12155D8", VA = "0x12155D8", Slot = "8")]
	public bool GetCoordOnSurfaceIfAvailable(Matrix4x4 matrix, out Vector3 outPos, out Vector3 outUp)
	{
		return default(bool);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1215680", Offset = "0x1215680", VA = "0x1215680", Slot = "6")]
	public float GetBrushRadiusMultForVisualization()
	{
		return default(float);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x121568C", Offset = "0x121568C", VA = "0x121568C", Slot = "7")]
	public float GetBrushRadiusMult()
	{
		return default(float);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x12156C4", Offset = "0x12156C4", VA = "0x12156C4")]
	public Brush2DCanvas()
	{
	}
}
[Token(Token = "0x2000006")]
public class Brush3DRender : MonoBehaviour, IBrushSurface
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mesh visualizationMesh;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material drawMaterial;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform meshRoot;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material lazybrushSphereMat;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material lazybrushLineSegmentMat;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material lazybrushCursorSphereMat;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Mesh lazybrushSphere;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Mesh lazybrushLineSegment;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Drawing <drawing>k__BackingField;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private BrushMeshCache meshCache;

	[Token(Token = "0x17000004")]
	public Drawing drawing
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x12156D4", Offset = "0x12156D4", VA = "0x12156D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x12156DC", Offset = "0x12156DC", VA = "0x12156DC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x12156E4", Offset = "0x12156E4", VA = "0x12156E4", Slot = "9")]
	public void Init(Drawing drawing)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1215768", Offset = "0x1215768", VA = "0x1215768", Slot = "10")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x12157A4", Offset = "0x12157A4", VA = "0x12157A4", Slot = "11")]
	public void SwitchDrawing(Drawing drawing)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x12157E8", Offset = "0x12157E8", VA = "0x12157E8")]
	private Matrix4x4 ConvertLocalToWorld(Matrix4x4 mat)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x12157FC", Offset = "0x12157FC", VA = "0x12157FC")]
	private Matrix4x4 ConvertWorldToLocal(Matrix4x4 mat)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1215810", Offset = "0x1215810", VA = "0x1215810", Slot = "8")]
	public bool GetCoordOnSurfaceIfAvailable(Matrix4x4 matrix, out Vector3 outPos, out Vector3 outUp)
	{
		return default(bool);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x121588C", Offset = "0x121588C", VA = "0x121588C", Slot = "12")]
	public void BeginFrame()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1215890", Offset = "0x1215890", VA = "0x1215890", Slot = "13")]
	public void StartRender()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x12158A8", Offset = "0x12158A8", VA = "0x12158A8", Slot = "14")]
	public void FinishRender()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x12159E0", Offset = "0x12159E0", VA = "0x12159E0", Slot = "4")]
	public void RenderVisualization(Matrix4x4 matrix, Color col, float size)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x12159E4", Offset = "0x12159E4", VA = "0x12159E4", Slot = "5")]
	public void RenderLazybrushVisuals(Vector3 startPos, Vector3 cursorPos, Vector3 endPos)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1215F34", Offset = "0x1215F34", VA = "0x1215F34", Slot = "6")]
	public float GetBrushRadiusMultForVisualization()
	{
		return default(float);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1215F3C", Offset = "0x1215F3C", VA = "0x1215F3C", Slot = "7")]
	public float GetBrushRadiusMult()
	{
		return default(float);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1215F44", Offset = "0x1215F44", VA = "0x1215F44")]
	public Brush3DRender()
	{
	}
}
[Token(Token = "0x2000007")]
public struct BrushPoint
{
	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 upVector;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float size;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color color;
}
[Token(Token = "0x2000008")]
[Flags]
public enum BrushLineFlags : ushort
{
	[Token(Token = "0x400002D")]
	IsEraser = 1,
	[Token(Token = "0x400002E")]
	RequestMeshRefresh = 2
}
[Token(Token = "0x2000009")]
public struct BrushLine
{
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ushort pointOffset;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public ushort pointCount;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public BrushLineFlags flags;
}
[Token(Token = "0x200000A")]
public class Drawing
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Matrix4x4 offsetMatrix;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<BrushLine> brushLines;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int brushLinesTop;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool lastLineInProgress;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool hasAnyMeshRefreshRequests;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<BrushPoint> points;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1216BA4", Offset = "0x1216BA4", VA = "0x1216BA4")]
	public void ClearAfterTop()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1223380", Offset = "0x1223380", VA = "0x1223380")]
	public Drawing Clone()
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1216B48", Offset = "0x1216B48", VA = "0x1216B48")]
	public bool CanAddMorePoints()
	{
		return default(bool);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x121DBA8", Offset = "0x121DBA8", VA = "0x121DBA8")]
	public Drawing()
	{
	}
}
[Token(Token = "0x200000B")]
public class BrushMeshCache
{
	[Token(Token = "0x200000C")]
	private struct MeshGenTask
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int meshIndex;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public JobHandle resampleJobHandle;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public JobHandle meshGenJobHandle;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NativeArray<BrushPoint> resampleBuffer;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public NativeArray<LineMeshVertex> vertBuffer;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public NativeArray<ushort> indexBuffer;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public NativeArray<MeshChunkInfo> chunks;
	}

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Mesh[] meshes;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int <meshCount>k__BackingField;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshGenTask[] genTasks;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int pendingTaskCount;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Drawing drawing;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private NativeArray<BrushPoint> drawingPointsTempBuffer;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool is3D;

	[Token(Token = "0x17000005")]
	public int meshCount
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1215F4C", Offset = "0x1215F4C", VA = "0x1215F4C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1215F54", Offset = "0x1215F54", VA = "0x1215F54")]
		private set
		{
		}
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1214418", Offset = "0x1214418", VA = "0x1214418")]
	public BrushMeshCache(Drawing drawing, bool is3D)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x12145F8", Offset = "0x12145F8", VA = "0x12145F8")]
	public void Flush()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1214644", Offset = "0x1214644", VA = "0x1214644")]
	public void SwitchDrawing(Drawing newDrawing)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x121474C", Offset = "0x121474C", VA = "0x121474C")]
	public void StartGenerating()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1214C40", Offset = "0x1214C40", VA = "0x1214C40")]
	public void FinishGenerating()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1215F5C", Offset = "0x1215F5C", VA = "0x1215F5C")]
	private void StartGenerateMesh(int index, NativeArray<BrushPoint> drawingPoints)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x12162D4", Offset = "0x12162D4", VA = "0x12162D4")]
	private void FinishGenerateMesh(ref MeshGenTask task)
	{
	}
}
[Token(Token = "0x200000D")]
public interface IBrushSurface
{
	[Token(Token = "0x600004B")]
	void RenderVisualization(Matrix4x4 matrix, Color col, float size);

	[Token(Token = "0x600004C")]
	void RenderLazybrushVisuals(Vector3 startPos, Vector3 cursorPos, Vector3 endPos);

	[Token(Token = "0x600004D")]
	float GetBrushRadiusMultForVisualization();

	[Token(Token = "0x600004E")]
	float GetBrushRadiusMult();

	[Token(Token = "0x600004F")]
	bool GetCoordOnSurfaceIfAvailable(Matrix4x4 matrix, out Vector3 outPos, out Vector3 outUp);
}
[Token(Token = "0x200000E")]
public struct LineMeshVertex
{
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 pos;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Color32 col;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector2 uv;
}
[Token(Token = "0x200000F")]
public static class LineMeshVertexAttrDescriptor
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly VertexAttributeDescriptor[] descriptors;
}
[Token(Token = "0x2000010")]
public struct MeshChunkInfo
{
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int vertCount;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int indexCount;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Vector3 minBounds;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector3 maxBounds;
}
[Token(Token = "0x2000011")]
public static class MeshGenUtil
{
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1227038", Offset = "0x1227038", VA = "0x1227038")]
	public static void ExpandBounds(Vector3 v, ref Vector3 min, ref Vector3 max)
	{
	}
}
[Token(Token = "0x2000012")]
public struct GenFlatMeshJob : IJob
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[WriteOnly]
	public NativeArray<MeshChunkInfo> chunks;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int chunkIdx;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[WriteOnly]
	public NativeArray<LineMeshVertex> verts;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[WriteOnly]
	public NativeArray<ushort> indices;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[ReadOnly]
	public NativeArray<BrushPoint> points;

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1228B10", Offset = "0x1228B10", VA = "0x1228B10", Slot = "4")]
	public void Execute()
	{
	}
}
[Token(Token = "0x2000013")]
public struct GenCubeMeshJob : IJob
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[WriteOnly]
	public NativeArray<MeshChunkInfo> chunks;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int chunkIdx;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[WriteOnly]
	public NativeArray<LineMeshVertex> verts;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[WriteOnly]
	public NativeArray<ushort> indices;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[ReadOnly]
	public NativeArray<BrushPoint> points;

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x122822C", Offset = "0x122822C", VA = "0x122822C", Slot = "4")]
	public void Execute()
	{
	}
}
[Token(Token = "0x2000014")]
public class CameraPreset : MonoBehaviour
{
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1217F58", Offset = "0x1217F58", VA = "0x1217F58")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1217FAC", Offset = "0x1217FAC", VA = "0x1217FAC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1218000", Offset = "0x1218000", VA = "0x1218000")]
	public CameraPreset()
	{
	}
}
[Token(Token = "0x2000015")]
public class CaptureImage : MonoBehaviour
{
	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera cam;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshPro takePhotoText;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RenderTexture previewMSAA4xRT;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RenderTexture previewMSAA8xRT;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RenderTexture exportMSAA4xRT;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RenderTexture exportMSAA8xRT;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture rt;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private VRRig vrRig;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private MeshRenderer previewRenderer;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float flashValue;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool pictureTakeRequested;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	private bool pictureTakeFirstFramePassed;

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1218008", Offset = "0x1218008", VA = "0x1218008")]
	private void Start()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1218094", Offset = "0x1218094", VA = "0x1218094")]
	private void Update()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x12181D4", Offset = "0x12181D4", VA = "0x12181D4")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x121858C", Offset = "0x121858C", VA = "0x121858C")]
	public void SaveTexture()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1218614", Offset = "0x1218614", VA = "0x1218614")]
	private void ResetText()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1218674", Offset = "0x1218674", VA = "0x1218674")]
	public CaptureImage()
	{
	}
}
[Token(Token = "0x2000016")]
public class ControllerTypeDetector : MonoBehaviour
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform leftControllerAnchor;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform rightControllerAnchor;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string lastLeftName;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string currentLeftName;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int controllerIndex;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 vivePos;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 indexPos;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 oculusPos;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 viveEuler;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 indexEuler;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 oculusEuler;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject[] oculusControllers;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject[] indexControllers;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject[] viveControllers;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public TextMeshPro uiButtonText;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMeshPro undoButtonText;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMeshPro eraserButtonText;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TextMeshPro nextButtonText;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public TextMeshPro[] stickTexts;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject[] hidingButtons;

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x121EDB8", Offset = "0x121EDB8", VA = "0x121EDB8")]
	private void Update()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x121EE44", Offset = "0x121EE44", VA = "0x121EE44")]
	private void SwapController(InputDevice leftDevice)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x121F57C", Offset = "0x121F57C", VA = "0x121F57C")]
	public void PositionController()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x121F0B4", Offset = "0x121F0B4", VA = "0x121F0B4")]
	private void ChangeVisuals(bool vive, bool index, bool oculus)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x121F790", Offset = "0x121F790", VA = "0x121F790")]
	public ControllerTypeDetector()
	{
	}
}
[Token(Token = "0x2000017")]
public class ControllerVibration : MonoBehaviour
{
	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve timerEndVibration;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve timerSecondVibration;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve uiTouchVibration;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve uiUntouchVibration;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AnimationCurve brushStartVibration;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float brushVibrationIntensity;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float frequency;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AnimationCurve current;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float playhead;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float length;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float constantVibrationAmplitude;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private VRRig vrRig;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x121F830", Offset = "0x121F830", VA = "0x121F830")]
	private void Start()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x121FA48", Offset = "0x121FA48", VA = "0x121FA48")]
	private void Update()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x121FB70", Offset = "0x121FB70", VA = "0x121FB70")]
	public void PlayVibration(AnimationCurve curve)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x121FB64", Offset = "0x121FB64", VA = "0x121FB64")]
	public void StopVibration()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x121FC20", Offset = "0x121FC20", VA = "0x121FC20")]
	private void HandleEvent(DrawingEvent msg)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x121FC24", Offset = "0x121FC24", VA = "0x121FC24")]
	private void HandleEvent(UITouchEvent msg)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x121FC54", Offset = "0x121FC54", VA = "0x121FC54")]
	private void HandleEvent(StartDrawingEvent msg)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x121FC90", Offset = "0x121FC90", VA = "0x121FC90")]
	public ControllerVibration()
	{
	}
}
[Token(Token = "0x2000018")]
public class DebugBezier : MonoBehaviour
{
	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform interpDebugObj;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Transform> pointObjects;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool explicitHandles;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float counter;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Vector3> debugHandles;

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1220024", Offset = "0x1220024", VA = "0x1220024")]
	private void Update()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1220664", Offset = "0x1220664", VA = "0x1220664")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x12207A0", Offset = "0x12207A0", VA = "0x12207A0")]
	public DebugBezier()
	{
	}
}
[Token(Token = "0x2000019")]
public static class DrawingSerialization
{
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x12234D0", Offset = "0x12234D0", VA = "0x12234D0")]
	public static void SaveDrawings(List<Drawing> drawings2D, List<Drawing> drawings3D, int drawingCount)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1223CF4", Offset = "0x1223CF4", VA = "0x1223CF4")]
	public static bool LoadDrawings(List<Drawing> drawings2D, List<Drawing> drawings3D)
	{
		return default(bool);
	}
}
[Token(Token = "0x200001A")]
public class EaselPositioner : MonoBehaviour
{
	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform hmd;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform easelTargetHolder;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform easelTarget;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool done;

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1225258", Offset = "0x1225258", VA = "0x1225258")]
	private void Start()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x12252D4", Offset = "0x12252D4", VA = "0x12252D4")]
	private void Done()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x12252E0", Offset = "0x12252E0", VA = "0x12252E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x12252F0", Offset = "0x12252F0", VA = "0x12252F0")]
	public void ApplyOffset()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x12254AC", Offset = "0x12254AC", VA = "0x12254AC")]
	public EaselPositioner()
	{
	}
}
[Token(Token = "0x200001B")]
public class ForceExceptionTest : MonoBehaviour
{
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x122794C", Offset = "0x122794C", VA = "0x122794C")]
	public void ForceException()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x12279A0", Offset = "0x12279A0", VA = "0x12279A0")]
	public ForceExceptionTest()
	{
	}
}
[Token(Token = "0x200001C")]
public static class EventBus
{
	[Token(Token = "0x200001D")]
	private class UnityEventImpl<T> : UnityEvent<T>
	{
		[Token(Token = "0x600007A")]
		public UnityEventImpl()
		{
		}
	}

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<Type, object> events;

	[Token(Token = "0x6000076")]
	private static UnityEventImpl<T> GetEventOfType<T>()
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	public static void Emit<T>(T msg)
	{
	}

	[Token(Token = "0x6000078")]
	public static void AddListener<T>(UnityAction<T> listener)
	{
	}
}
[Token(Token = "0x200001E")]
internal struct TimerEndEvent
{
}
[Token(Token = "0x200001F")]
internal struct StartDrawingEvent
{
	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool is3D;
}
[Token(Token = "0x2000020")]
internal struct DrawingEvent
{
	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float pressure;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float distance;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public bool is3D;
}
[Token(Token = "0x2000021")]
internal struct StopDrawingEvent
{
	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Drawing drawing;
}
[Token(Token = "0x2000022")]
internal struct ClearSceneEvent
{
}
[Token(Token = "0x2000023")]
internal struct UndoEvent
{
}
[Token(Token = "0x2000024")]
internal struct RedoEvent
{
}
[Token(Token = "0x2000025")]
internal struct DrawingSwitchedEvent
{
	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Drawing drawing;
}
[Token(Token = "0x2000026")]
internal struct TimerSecondPassEvent
{
	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float seconds;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float total;
}
[Token(Token = "0x2000027")]
internal struct UITouchEvent
{
	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 pos;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool unclick;
}
[Token(Token = "0x2000028")]
internal struct PictureTakenEvent
{
}
[Token(Token = "0x2000029")]
internal struct FileSavedEvent
{
}
[Token(Token = "0x200002A")]
internal struct ShadowRenderRequestedEvent
{
}
[Token(Token = "0x200002B")]
public static class Exporting
{
	[Token(Token = "0x200002C")]
	private struct ExportDrawing2DJob : IJob
	{
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<byte> buffer;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NativeArray<byte> exportBuffer;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x124A0C0", Offset = "0x124A0C0", VA = "0x124A0C0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool useTransparency;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string <outputDir>k__BackingField;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static NativeArray<byte> canvasTextureBuffer;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static NativeArray<byte> canvasTextureBufferExtra;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int canvasWidth;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static int canvasHeight;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static bool flipVertical;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private static bool flipHorizontal;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	private static bool withGammaCorrection;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	private static bool export2DInProgress;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static JobHandle exportDrawing2DJob;

	[Token(Token = "0x17000006")]
	public static string outputDir
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x122580C", Offset = "0x122580C", VA = "0x122580C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1225858", Offset = "0x1225858", VA = "0x1225858")]
		private set
		{
		}
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x12258AC", Offset = "0x12258AC", VA = "0x12258AC")]
	public static void Init()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x12259E8", Offset = "0x12259E8", VA = "0x12259E8")]
	public static void DisposeResources()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1225AAC", Offset = "0x1225AAC", VA = "0x1225AAC")]
	public static void OpenExportFolder()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x12185B8", Offset = "0x12185B8", VA = "0x12185B8")]
	public static bool CanExport()
	{
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x12182F0", Offset = "0x12182F0", VA = "0x12182F0")]
	public static bool ExportDrawing2D(RenderTexture canvasTexture, bool flipVertical = true, bool flipHorizontal = false, bool withGammaCorrection = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1225AEC", Offset = "0x1225AEC", VA = "0x1225AEC")]
	private static void CompleteExportDrawing2D(AsyncGPUReadbackRequest request)
	{
	}
}
[Token(Token = "0x200002D")]
public class FadeInSphere : MonoBehaviour
{
	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material material;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float targetAlpha;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float fadeDuration;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float lerpParam;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float startAlpha;

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1225C28", Offset = "0x1225C28", VA = "0x1225C28")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1225CEC", Offset = "0x1225CEC", VA = "0x1225CEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1225D80", Offset = "0x1225D80", VA = "0x1225D80")]
	public void FadeTo(float alpha, float duration = 1f)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1225CA0", Offset = "0x1225CA0", VA = "0x1225CA0")]
	private void SetMaterialAlpha(float alpha)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1225DCC", Offset = "0x1225DCC", VA = "0x1225DCC")]
	public FadeInSphere()
	{
	}
}
[Token(Token = "0x200002E")]
public class HandednessToggle : MonoBehaviour
{
	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform leftHand;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform leftControllerAnchor;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform leftController;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform rightHand;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform rightControllerAnchor;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform rightController;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform vrUI;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform sidePannel;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform learnPage;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform settingsPage;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform keyboard;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject leftUIButton;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject rightUIButton;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform nextPoseIconRight;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Transform nextPoseIconLeft;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Transform undoIcon;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public VRToggle vrToggle;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool isOn;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Vector3 lefttargetScale;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 righttargetScale;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Vector3 nextPoseTargetScale;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Vector3 undoTargetScale;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private Vector3 uiPos;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Vector3 sidePannelPos;

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x122AFF8", Offset = "0x122AFF8", VA = "0x122AFF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x122B130", Offset = "0x122B130", VA = "0x122B130")]
	private void Start()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x122B150", Offset = "0x122B150", VA = "0x122B150")]
	private void Update()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x122B190", Offset = "0x122B190", VA = "0x122B190")]
	public void UpdateHand()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x122B1E8", Offset = "0x122B1E8", VA = "0x122B1E8")]
	private void HandUpdateDelay()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x122B598", Offset = "0x122B598", VA = "0x122B598")]
	public void ToggleHands()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x122B824", Offset = "0x122B824", VA = "0x122B824")]
	public HandednessToggle()
	{
	}
}
[Token(Token = "0x200002F")]
public class HideHandsOnPause : MonoBehaviour
{
	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] hands;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action focusEvent;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] listOfObjectsToHideOnPause;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x122B82C", Offset = "0x122B82C", VA = "0x122B82C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x122B838", Offset = "0x122B838", VA = "0x122B838")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x122B8F0", Offset = "0x122B8F0", VA = "0x122B8F0")]
	public HideHandsOnPause()
	{
	}
}
[Token(Token = "0x2000030")]
public class PlayerOculusInput
{
	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private UndoSystem undosys;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform trackingSpace;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform rightHand;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private HandBehaviour mainHand;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool interacting3D;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool interactingCanvas;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	private bool interactingCanvas_PendingTriggerRelease;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	private bool toolstickWithinHoverRange;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool undoRedoDown;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	private bool repositioningStick;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	private bool stickSwapped;

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x7BA278", Offset = "0x7BA278", VA = "0x7BA278")]
	public PlayerOculusInput(Transform trackingSpace, Transform rightHand, UndoSystem undosys)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x7BAAD8", Offset = "0x7BAAD8", VA = "0x7BAAD8")]
	public void Update(ITool tool, ToolStick stick, VRRig vrRig)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x7BB860", Offset = "0x7BB860", VA = "0x7BB860")]
	public void UpdateToolStick(ITool tool, ToolStick stick, Brush2DCanvas canvas, VRRig vrRig)
	{
	}
}
[Token(Token = "0x2000031")]
public class LoadMainScene : MonoBehaviour
{
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x122CAF4", Offset = "0x122CAF4", VA = "0x122CAF4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x122CB6C", Offset = "0x122CB6C", VA = "0x122CB6C")]
	public LoadMainScene()
	{
	}
}
[Token(Token = "0x2000032")]
public class LookAt : MonoBehaviour
{
	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool lookAtMainCam;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform up;

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x122CC60", Offset = "0x122CC60", VA = "0x122CC60")]
	private void Update()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x122CFE8", Offset = "0x122CFE8", VA = "0x122CFE8")]
	public LookAt()
	{
	}
}
[Token(Token = "0x2000033")]
public class ModelSpawner : MonoBehaviour
{
	[Token(Token = "0x2000034")]
	private enum State
	{
		[Token(Token = "0x40000F3")]
		FADE_IN,
		[Token(Token = "0x40000F4")]
		FADE_OUT,
		[Token(Token = "0x40000F5")]
		MODEL,
		[Token(Token = "0x40000F6")]
		WAIT
	}

	[Token(Token = "0x40000D3")]
	private const int modelMeshLayer = 16;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform root;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material modelMaterial;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material censorMaterialFullQuality;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material censorMaterialLowQuality;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material boxMaterial;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float modelSize;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float rotationAmount;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float seconds;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float fadeOutSeconds;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float fadeInSeconds;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool waitBetweenPoses;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool skipFadeOutWhenManual;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int indexForNextModel;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private VRRig vrRig;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private HandBehaviour mainHand;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float <timer>k__BackingField;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshPro artistNameText;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private State state;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool shouldWait;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private ModelTable modelTable;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int[] modelIndices;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int currentModelIdxIdx;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Transform model;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Transform modelCensorBars;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Transform modelBox;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Material censorMaterial;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private bool isBox;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
	private bool isCensored;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
	private bool ditheringEnabledInShader;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private AssetBundleHandler bundleHandler;

	[Token(Token = "0x17000007")]
	public float timer
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x122E6C8", Offset = "0x122E6C8", VA = "0x122E6C8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x122E6D0", Offset = "0x122E6D0", VA = "0x122E6D0")]
		private set
		{
		}
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x122E6D8", Offset = "0x122E6D8", VA = "0x122E6D8")]
	public void SwitchToSpecifiedModel()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x122E80C", Offset = "0x122E80C", VA = "0x122E80C")]
	public void NextModel()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x122E970", Offset = "0x122E970", VA = "0x122E970")]
	public void SetTimer(float seconds)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x122E6E0", Offset = "0x122E6E0", VA = "0x122E6E0")]
	public void SwitchToModel(int index)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x122EBC0", Offset = "0x122EBC0", VA = "0x122EBC0")]
	private void ShadowDelay()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x122EC34", Offset = "0x122EC34", VA = "0x122EC34")]
	public void SetModelSet(ModelTable table)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x122ED20", Offset = "0x122ED20", VA = "0x122ED20")]
	public void SetCensor(bool on)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x122EE28", Offset = "0x122EE28", VA = "0x122EE28")]
	public void SetBoxMode(bool on)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x122E8F8", Offset = "0x122E8F8", VA = "0x122E8F8")]
	private void ShowNextModel(float fadeAlpha = 1f)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x122E9D8", Offset = "0x122E9D8", VA = "0x122E9D8")]
	private void SwitchModelInternal(int indirectIndex, float fadeAlpha = 1f)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x122EFA4", Offset = "0x122EFA4", VA = "0x122EFA4")]
	public void SpawnModel()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x122E85C", Offset = "0x122E85C", VA = "0x122E85C")]
	private void HideModel()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x122E964", Offset = "0x122E964", VA = "0x122E964")]
	private void SetState(State nextState)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x122F570", Offset = "0x122F570", VA = "0x122F570")]
	private void SetModelFade(float alpha)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x122F638", Offset = "0x122F638", VA = "0x122F638")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x122F644", Offset = "0x122F644", VA = "0x122F644")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x122F830", Offset = "0x122F830", VA = "0x122F830")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x122FAF8", Offset = "0x122FAF8", VA = "0x122FAF8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x122FBA4", Offset = "0x122FBA4", VA = "0x122FBA4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x122FC18", Offset = "0x122FC18", VA = "0x122FC18")]
	public ModelSpawner()
	{
	}
}
[Token(Token = "0x2000035")]
public class ChangeEnvironment : MonoBehaviour
{
	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Transform> environments;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SpriteRenderer[] selectionSprites;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color selectedColor;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color startColor;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int index;

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x12188D4", Offset = "0x12188D4", VA = "0x12188D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1218A20", Offset = "0x1218A20", VA = "0x1218A20")]
	public void SetActiveEnvironment(int environmentIndex)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1218BC4", Offset = "0x1218BC4", VA = "0x1218BC4")]
	public ChangeEnvironment()
	{
	}
}
[Token(Token = "0x2000036")]
public class GetOculusUserName : MonoBehaviour
{
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1228E98", Offset = "0x1228E98", VA = "0x1228E98")]
	public GetOculusUserName()
	{
	}
}
[Token(Token = "0x2000037")]
public class NetworkPlayer : MonoBehaviourPunCallbacks, IPunObservable
{
	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TrackedPoseDriver[] poseDrivers;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] remoteObjects;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] localObjects;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Camera[] remoteCameras;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioListener audioListener;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Teleport teleport;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Grabbable grabbable;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ToolStick toolStick;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Brush2DCanvas brush2DCanvas;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Brush3DRender brush3DRender;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public PlayerDelegate playerDelegate;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GrabManager grabManager;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public OVRManager oVRManager;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public OVRCameraRig oVRCameraRig;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TextMeshPro nameText;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string savedName;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private RemoteDrawingManager remoteDrawingManager;

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x122FF50", Offset = "0x122FF50", VA = "0x122FF50")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x12304C8", Offset = "0x12304C8", VA = "0x12304C8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x12305A0", Offset = "0x12305A0", VA = "0x12305A0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x12305EC", Offset = "0x12305EC", VA = "0x12305EC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1230600", Offset = "0x1230600", VA = "0x1230600")]
	[PunRPC]
	private void RequestFullDrawingSync()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1230644", Offset = "0x1230644", VA = "0x1230644", Slot = "54")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x12308DC", Offset = "0x12308DC", VA = "0x12308DC")]
	public NetworkPlayer()
	{
	}
}
[Token(Token = "0x2000038")]
public class ParabolaController : MonoBehaviour
{
	[Token(Token = "0x2000039")]
	public class ParabolaFly
	{
		[Serializable]
		[Token(Token = "0x200003A")]
		private sealed class <>c
		{
			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Converter<Component, Transform> <>9__4_0;

			[Token(Token = "0x400011B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Comparison<Transform> <>9__4_1;

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x124EA70", Offset = "0x124EA70", VA = "0x124EA70")]
			public <>c()
			{
			}

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x124EA78", Offset = "0x124EA78", VA = "0x124EA78")]
			internal Transform <.ctor>b__4_0(Component c)
			{
				return null;
			}

			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x124EAF8", Offset = "0x124EAF8", VA = "0x124EAF8")]
			internal int <.ctor>b__4_1(Transform a, Transform b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] Points;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Parabola3D[] parabolas;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected float[] partDuration;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float completeDuration;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x124D9D4", Offset = "0x124D9D4", VA = "0x124D9D4")]
		public ParabolaFly(Transform ParabolaRoot)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x124DE08", Offset = "0x124DE08", VA = "0x124DE08")]
		public Vector3 GetPositionAtTime(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x124DF24", Offset = "0x124DF24", VA = "0x124DF24")]
		public void GetParabolaIndexAtTime(float time, out int parabolaIndex)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x124DE9C", Offset = "0x124DE9C", VA = "0x124DE9C")]
		public void GetParabolaIndexAtTime(float time, out int parabolaIndex, out float timeInParabola)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x124DF48", Offset = "0x124DF48", VA = "0x124DF48")]
		public float GetDuration()
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x124DF50", Offset = "0x124DF50", VA = "0x124DF50")]
		public Vector3 getHighestPoint(int parabolaIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x124DF90", Offset = "0x124DF90", VA = "0x124DF90")]
		public void RefreshTransforms(float speed)
		{
		}
	}

	[Token(Token = "0x200003B")]
	public class Parabola3D
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float <Length>k__BackingField;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 A;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 B;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 C;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Parabola2D parabola2D;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Vector3 h;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		protected bool tooClose;

		[Token(Token = "0x17000008")]
		public float Length
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x124D3C8", Offset = "0x124D3C8", VA = "0x124D3C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x124D3D0", Offset = "0x124D3D0", VA = "0x124D3D0")]
			private set
			{
			}
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x124D3D8", Offset = "0x124D3D8", VA = "0x124D3D8")]
		public Parabola3D()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x124D3E0", Offset = "0x124D3E0", VA = "0x124D3E0")]
		public void Set(Vector3 A, Vector3 B, Vector3 C)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x124D4C8", Offset = "0x124D4C8", VA = "0x124D4C8")]
		public Vector3 getHighestPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x124D5C8", Offset = "0x124D5C8", VA = "0x124D5C8")]
		public Vector3 GetPositionAtLength(float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x124D400", Offset = "0x124D400", VA = "0x124D400")]
		private void refreshCurve()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x124D6FC", Offset = "0x124D6FC", VA = "0x124D6FC")]
		private void refreshCurveNormal()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x124D8C4", Offset = "0x124D8C4", VA = "0x124D8C4")]
		private void refreshCurveClose()
		{
		}
	}

	[Token(Token = "0x200003C")]
	public class Parabola2D
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float <a>k__BackingField;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <b>k__BackingField;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float <c>k__BackingField;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector2 <E>k__BackingField;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float <Length>k__BackingField;

		[Token(Token = "0x17000009")]
		public float a
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x124D144", Offset = "0x124D144", VA = "0x124D144")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x124D14C", Offset = "0x124D14C", VA = "0x124D14C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float b
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x124D154", Offset = "0x124D154", VA = "0x124D154")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x124D15C", Offset = "0x124D15C", VA = "0x124D15C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public float c
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x124D164", Offset = "0x124D164", VA = "0x124D164")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x124D16C", Offset = "0x124D16C", VA = "0x124D16C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Vector2 E
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x124D174", Offset = "0x124D174", VA = "0x124D174")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x124D17C", Offset = "0x124D17C", VA = "0x124D17C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public float Length
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x124D184", Offset = "0x124D184", VA = "0x124D184")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x124D18C", Offset = "0x124D18C", VA = "0x124D18C")]
			private set
			{
			}
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x124D194", Offset = "0x124D194", VA = "0x124D194")]
		public Parabola2D(float a, float b, float c, float length)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x124D234", Offset = "0x124D234", VA = "0x124D234")]
		public Parabola2D(Vector2 A, Vector2 B, Vector2 C)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x124D3A8", Offset = "0x124D3A8", VA = "0x124D3A8")]
		public float f(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x124D204", Offset = "0x124D204", VA = "0x124D204")]
		private void setMetadata()
		{
		}
	}

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Speed;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject ParabolaRoot;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool Autostart;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool Animation;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	internal bool nextParbola;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	protected float animationTime;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected ParabolaFly gizmo;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected ParabolaFly parabolaFly;

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x7B8654", Offset = "0x7B8654", VA = "0x7B8654")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x7B8858", Offset = "0x7B8858", VA = "0x7B8858")]
	private void Start()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x7B89CC", Offset = "0x7B89CC", VA = "0x7B89CC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x7B8938", Offset = "0x7B8938", VA = "0x7B8938")]
	public void FollowParabola()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x7B8ABC", Offset = "0x7B8ABC", VA = "0x7B8ABC")]
	public Vector3 getHighestPoint(int parabolaIndex)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x7B8AD8", Offset = "0x7B8AD8", VA = "0x7B8AD8")]
	public Transform[] getPoints()
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x7B8AF4", Offset = "0x7B8AF4", VA = "0x7B8AF4")]
	public Vector3 GetPositionAtTime(float time)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x7B8B10", Offset = "0x7B8B10", VA = "0x7B8B10")]
	public float GetDuration()
	{
		return default(float);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x7B8B2C", Offset = "0x7B8B2C", VA = "0x7B8B2C")]
	public void StopFollow()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x7B891C", Offset = "0x7B891C", VA = "0x7B891C")]
	public void RefreshTransforms(float speed)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x7B8B38", Offset = "0x7B8B38", VA = "0x7B8B38")]
	public static float DistanceToLine(Ray ray, Vector3 point)
	{
		return default(float);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x7B8BD4", Offset = "0x7B8BD4", VA = "0x7B8BD4")]
	public static Vector3 ClosestPointInLine(Ray ray, Vector3 point)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x7B8CB8", Offset = "0x7B8CB8", VA = "0x7B8CB8")]
	public ParabolaController()
	{
	}
}
[Token(Token = "0x200003D")]
public class PenPositionSync : MonoBehaviour
{
	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x7B8E98", Offset = "0x7B8E98", VA = "0x7B8E98")]
	public PenPositionSync()
	{
	}
}
[Token(Token = "0x200003E")]
public class RemoteDrawingManager : IDisposable
{
	[Token(Token = "0x200003F")]
	private struct Payload
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public NativeArray<byte> data;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int totalChunks;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int chunksTransmitted;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isDiff;

		[Token(Token = "0x4000134")]
		public const int chunkSize = 8192;
	}

	[Token(Token = "0x2000040")]
	private struct DrawingCache
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public NativeArray<BrushPoint> prevPoints;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NativeArray<BrushLine> prevLines;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int prevPointsCount;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int prevLinesCount;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int brushLinesTop;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool needSend;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool needFlushRenderer;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int drawingRevision;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Payload payload;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int totalMemoryUsage;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int memoryUsage;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x124E430", Offset = "0x124E430", VA = "0x124E430")]
		public DrawingCache(int pointBufferSize, int lineBufferSize)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x124E600", Offset = "0x124E600", VA = "0x124E600")]
		public void Flush()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x124E688", Offset = "0x124E688", VA = "0x124E688")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x2000041")]
	private struct DeltaPayloadHeader
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int pointChunkCount;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int lineChunkCount;
	}

	[Token(Token = "0x2000042")]
	private struct ChunkHeader
	{
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int offset;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int size;
	}

	[Token(Token = "0x4000128")]
	private const int cachePointBufferSize = 2097152;

	[Token(Token = "0x4000129")]
	private const int cacheLineBufferSize = 131072;

	[Token(Token = "0x400012A")]
	private const int tempDiffBufferSize = 4194304;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private DrawingCache drawing2DCache;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private DrawingCache drawing3DCache;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Brush3DRender brush3DRender;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Brush2DCanvas brush2DCanvas;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public bool requestedFullDrawingSync;

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x7C0520", Offset = "0x7C0520", VA = "0x7C0520")]
	public RemoteDrawingManager(Brush2DCanvas brush2DCanvas, Brush3DRender brush3DRender)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x7C08F0", Offset = "0x7C08F0", VA = "0x7C08F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x7C0920", Offset = "0x7C0920", VA = "0x7C0920")]
	private void HandleEvent(StopDrawingEvent msg)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x7C0970", Offset = "0x7C0970", VA = "0x7C0970")]
	private void HandleEvent(DrawingSwitchedEvent msg)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x7C09D0", Offset = "0x7C09D0", VA = "0x7C09D0")]
	private void HandleEvent(UndoEvent msg)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x7C09E0", Offset = "0x7C09E0", VA = "0x7C09E0")]
	private void HandleEvent(RedoEvent msg)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x7C09F0", Offset = "0x7C09F0", VA = "0x7C09F0")]
	private void HandleEvent(ClearDrawingAction msg)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x7C0A00", Offset = "0x7C0A00", VA = "0x7C0A00")]
	public void StartRender()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x7C0A7C", Offset = "0x7C0A7C", VA = "0x7C0A7C")]
	public void FinishRender()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x7C0AB8", Offset = "0x7C0AB8", VA = "0x7C0AB8")]
	private int GenerateDiff(NativeArray<byte> prev, NativeArray<byte> current, NativeArray<byte> temp, ref int bufTop)
	{
		return default(int);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x7C0DAC", Offset = "0x7C0DAC", VA = "0x7C0DAC")]
	private int ApplyDiff(NativeArray<byte> prev, NativeArray<byte> dest, NativeArray<byte> deltaBuf, int chunkCount)
	{
		return default(int);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x7C0F24", Offset = "0x7C0F24", VA = "0x7C0F24")]
	private void SerializeSingle(PhotonStream stream, Drawing drawing, ref DrawingCache cache)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x7C1748", Offset = "0x7C1748", VA = "0x7C1748")]
	private void DeserializeSingle(PhotonStream stream, Drawing drawing, ref DrawingCache cache)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x7C210C", Offset = "0x7C210C", VA = "0x7C210C")]
	public void Serialize(PhotonStream stream)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x7C2194", Offset = "0x7C2194", VA = "0x7C2194")]
	public void Deserialize(PhotonStream stream)
	{
	}
}
[Token(Token = "0x2000043")]
public class RoomController : MonoBehaviourPunCallbacks
{
	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject playerPrefab;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject localPlayerManager;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform spawnPoint;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<GameObject> rooms;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private TypedLobby typedLobby;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool done;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshPro roomInput;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string roomName;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string logText;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool tooManyPlayers;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private bool requestPlayerSpawn;

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x7C2FE4", Offset = "0x7C2FE4", VA = "0x7C2FE4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x7C3050", Offset = "0x7C3050", VA = "0x7C3050")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x7B74C0", Offset = "0x7B74C0", VA = "0x7B74C0")]
	public void Connect()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x7B75FC", Offset = "0x7B75FC", VA = "0x7B75FC")]
	public void Disconnect()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x7C32D0", Offset = "0x7C32D0", VA = "0x7C32D0", Slot = "31")]
	public override void OnLeftRoom()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x7C332C", Offset = "0x7C332C", VA = "0x7C332C", Slot = "38")]
	public override void OnDisconnected(DisconnectCause cause)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x7C3414", Offset = "0x7C3414", VA = "0x7C3414")]
	public void LoadSceneBuffer()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x7C34A0", Offset = "0x7C34A0", VA = "0x7C34A0", Slot = "45")]
	public override void OnConnectedToMaster()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x7C362C", Offset = "0x7C362C", VA = "0x7C362C", Slot = "36")]
	public override void OnJoinedLobby()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x7C3630", Offset = "0x7C3630", VA = "0x7C3630")]
	public void CreateRoom()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x7C3724", Offset = "0x7C3724", VA = "0x7C3724", Slot = "33")]
	public override void OnCreateRoomFailed(short returnCode, string message)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x7C37C4", Offset = "0x7C37C4", VA = "0x7C37C4", Slot = "34")]
	public override void OnJoinRoomFailed(short returnCode, string message)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x7C37C8", Offset = "0x7C37C8", VA = "0x7C37C8", Slot = "41")]
	public override void OnJoinedRoom()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x7C3074", Offset = "0x7C3074", VA = "0x7C3074")]
	public void SpawnPlayer()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x7C3948", Offset = "0x7C3948", VA = "0x7C3948")]
	public RoomController()
	{
	}
}
[Token(Token = "0x2000044")]
public class SmoothCameraToggle : MonoBehaviour
{
	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform hmd;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera smoothCam;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool useSmoothCam;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float lerpSpeed;

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x7C3F8C", Offset = "0x7C3F8C", VA = "0x7C3F8C")]
	private void Start()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x7C405C", Offset = "0x7C405C", VA = "0x7C405C")]
	private void Update()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x7C424C", Offset = "0x7C424C", VA = "0x7C424C")]
	public void ToggleSmoothing()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x7C4348", Offset = "0x7C4348", VA = "0x7C4348")]
	public SmoothCameraToggle()
	{
	}
}
[Token(Token = "0x2000045")]
public class SpawnLocalPlayer : MonoBehaviour
{
	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject playerPrefab;

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x7C513C", Offset = "0x7C513C", VA = "0x7C513C")]
	public SpawnLocalPlayer()
	{
	}
}
[Token(Token = "0x2000046")]
public class SpotLightController : MonoBehaviour
{
	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private VRRig vrRig;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform lightHolder;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private PhotonView lightHolderView;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Quaternion targetRot;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PhotonView photonView;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform visuals;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform figureRoot;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool settingLight;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool rotateModel;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion startRot;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 startPos;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject rotaterVisuals;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject rotaterSlider;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private HandBehaviour mainHand;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GrabManager grabManager;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public SyncModelPose syncModelPose;

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x7C5144", Offset = "0x7C5144", VA = "0x7C5144")]
	private void Start()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x7C53E4", Offset = "0x7C53E4", VA = "0x7C53E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x7C5BB0", Offset = "0x7C5BB0", VA = "0x7C5BB0")]
	public SpotLightController()
	{
	}
}
[Token(Token = "0x2000047")]
public class SyncModelPose : MonoBehaviourPunCallbacks, IPunObservable
{
	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int targetPoseIndex;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int poseIndex;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private new PhotonView photonView;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ModelSpawner modelSpawner;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public VRToggle syncPoses;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int targetDatabaseIndex;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int useIndex;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float targetRotation;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float targetTimerLength;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float timerLength;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ModelSetResponder modelSetResponder;

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x7C5DD4", Offset = "0x7C5DD4", VA = "0x7C5DD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x7C5E60", Offset = "0x7C5E60", VA = "0x7C5E60")]
	private void Update()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x7C62F4", Offset = "0x7C62F4", VA = "0x7C62F4")]
	public void RequestOwnership()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x7BDAE4", Offset = "0x7BDAE4", VA = "0x7BDAE4")]
	public void SetIndex(int poseIndex, VRToggle syncPoseToggle)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x7BDC04", Offset = "0x7BDC04", VA = "0x7BDC04")]
	public void ChangeModelSet(int index)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x7C63D0", Offset = "0x7C63D0", VA = "0x7C63D0", Slot = "54")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x7C656C", Offset = "0x7C656C", VA = "0x7C656C")]
	public SyncModelPose()
	{
	}
}
[Token(Token = "0x2000048")]
public class Teleport : MonoBehaviour
{
	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRRig vrRig;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LineRenderer lineRenderer;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform playSpace;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform trackedObjects;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform leftBeamOrigin;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform easelProp;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform beamOrigin;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform endPoint;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject teleportGuide;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform playerPreview;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform lookTarget;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Transform recenterPoint;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private RaycastHit hit;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool teleportReady;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
	private bool teleporting;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float resolution;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float distance;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float height;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private bool turned;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
	private bool lookAtTarget;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB6")]
	private bool initialized;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Vector3 easelStartPos;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private Quaternion easelStartRot;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private HandBehaviour targetHand;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public TeleportConstraits teleportConstraits;

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x7C6AD8", Offset = "0x7C6AD8", VA = "0x7C6AD8")]
	private void Start()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x7C6BF0", Offset = "0x7C6BF0", VA = "0x7C6BF0")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x7C6DD4", Offset = "0x7C6DD4", VA = "0x7C6DD4")]
	private void Update()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x7C718C", Offset = "0x7C718C", VA = "0x7C718C")]
	private void HandleInputs()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x7C6C28", Offset = "0x7C6C28", VA = "0x7C6C28")]
	public void RecenterPlayer()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x7C7420", Offset = "0x7C7420", VA = "0x7C7420")]
	private void StartTeleport(Transform origin)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x7C7314", Offset = "0x7C7314", VA = "0x7C7314")]
	private void StopTeleport()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x7C73F8", Offset = "0x7C73F8", VA = "0x7C73F8")]
	private void CancelTeleport()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x7C7538", Offset = "0x7C7538", VA = "0x7C7538")]
	private bool CalculateTeleportPoint()
	{
		return default(bool);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x7C748C", Offset = "0x7C748C", VA = "0x7C748C")]
	private void RotatePlayer(bool isNegative)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x7C76FC", Offset = "0x7C76FC", VA = "0x7C76FC")]
	private void SetLineRenderPoints()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x7C77E4", Offset = "0x7C77E4", VA = "0x7C77E4")]
	public Teleport()
	{
	}
}
[Token(Token = "0x2000049")]
public class TeleportArch : MonoBehaviour
{
	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform localZPoint;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float xRot;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float lerpSpeed;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float archHeigh;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float distanceMultiplier;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform teleportOrigin;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform topPoint;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform teleportPoint;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int archResolution;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3[] archPoints;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float lerpValue;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public LineRenderer lineRenderer;

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x123E77C", Offset = "0x123E77C", VA = "0x123E77C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x123E7F0", Offset = "0x123E7F0", VA = "0x123E7F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x123EBE8", Offset = "0x123EBE8", VA = "0x123EBE8")]
	public TeleportArch()
	{
	}
}
[Token(Token = "0x200004A")]
public class TeleportConstraits : MonoBehaviour
{
	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool canTeleport;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TeleportArch arch;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SphereCollider sphereCollider;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Transform> colliderPoints;

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x123EC10", Offset = "0x123EC10", VA = "0x123EC10")]
	private void Awake()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x123ED70", Offset = "0x123ED70", VA = "0x123ED70")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x123ED7C", Offset = "0x123ED7C", VA = "0x123ED7C")]
	private void Update()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x123EE68", Offset = "0x123EE68", VA = "0x123EE68")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x123EEB0", Offset = "0x123EEB0", VA = "0x123EEB0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x123EEFC", Offset = "0x123EEFC", VA = "0x123EEFC")]
	public TeleportConstraits()
	{
	}
}
[Token(Token = "0x200004B")]
public class VoiceChatHelper : MonoBehaviour
{
	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Speaker speaker;

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x12460DC", Offset = "0x12460DC", VA = "0x12460DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1246138", Offset = "0x1246138", VA = "0x1246138")]
	public VoiceChatHelper()
	{
	}
}
[Token(Token = "0x200004C")]
public class PassthroughToggler : MonoBehaviour
{
	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRManager oVRManager;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform modelSpawner;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 modelSpawnerStart;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Color skyboxColor;

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x7B8CD8", Offset = "0x7B8CD8", VA = "0x7B8CD8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x7B8D98", Offset = "0x7B8D98", VA = "0x7B8D98")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x7B8E1C", Offset = "0x7B8E1C", VA = "0x7B8E1C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x7B8E90", Offset = "0x7B8E90", VA = "0x7B8E90")]
	public PassthroughToggler()
	{
	}
}
[Token(Token = "0x200004D")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F480", Offset = "0x57F480")]
public class PenSound : MonoBehaviour
{
	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SoundTable table;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource source;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool eventHandled;

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x7B8EA0", Offset = "0x7B8EA0", VA = "0x7B8EA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x7B9078", Offset = "0x7B9078", VA = "0x7B9078")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x7B90A8", Offset = "0x7B90A8", VA = "0x7B90A8")]
	private void HandleEvent(DrawingEvent msg)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x7B921C", Offset = "0x7B921C", VA = "0x7B921C")]
	private void HandleEvent(StopDrawingEvent msg)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x7B9260", Offset = "0x7B9260", VA = "0x7B9260")]
	public PenSound()
	{
	}
}
[Token(Token = "0x200004E")]
public class PlayerDelegate : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200004F")]
	private sealed class <>c
	{
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static UnityAction<bool> <>9__22_3;

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x124E290", Offset = "0x124E290", VA = "0x124E290")]
		public <>c()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x124E298", Offset = "0x124E298", VA = "0x124E298")]
		internal void <Start>b__22_3(bool val)
		{
		}
	}

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PlayerState state;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UIResponder ui;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ModelSpawner spawner;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform rightHand;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ToolStick toolStick;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabManager grabManager;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public PlayerOculusInput playerInput;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Brush3DRender brush3DRender;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Brush2DCanvas brush2DCanvas;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public BrushSettings brushSettings;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public BrushSettings eraserSettings;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Texture blueNoiseTex;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private BrushTool brushTool2D;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private BrushTool eraserTool2D;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private BrushTool brushTool3D;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private TintTool tintTool3D;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private ITool tool2D;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private ITool tool3D;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Matrix4x4 eraserToolPenPosition;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Matrix4x4 defaultToolPenPosition;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private ClearDrawingAction clearDrawingAction;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public VRRig vrRig;

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x7B9608", Offset = "0x7B9608", VA = "0x7B9608")]
	private void Start()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x7BA4B4", Offset = "0x7BA4B4", VA = "0x7BA4B4")]
	public void OnEraserToggle(bool isEraser)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x7BA628", Offset = "0x7BA628", VA = "0x7BA628")]
	private void SwitchTools(ITool newTool2D, ITool newTool3D)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x7BA7F8", Offset = "0x7BA7F8", VA = "0x7BA7F8")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x7BA92C", Offset = "0x7BA92C", VA = "0x7BA92C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x7BA944", Offset = "0x7BA944", VA = "0x7BA944")]
	private void Update()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x7BBDE0", Offset = "0x7BBDE0", VA = "0x7BBDE0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x7BA804", Offset = "0x7BA804", VA = "0x7BA804")]
	public void SaveSessionDrawings()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x7BA2DC", Offset = "0x7BA2DC", VA = "0x7BA2DC")]
	public void LoadSessionDrawings()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x7BC220", Offset = "0x7BC220", VA = "0x7BC220")]
	private void OnLazybrushLevelChanged(float percent)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x7BC280", Offset = "0x7BC280", VA = "0x7BC280")]
	public void OnExportDrawing()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x7BBE1C", Offset = "0x7BBE1C", VA = "0x7BBE1C")]
	public void OnSwitchDrawing()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x7BC0C4", Offset = "0x7BC0C4", VA = "0x7BC0C4")]
	public void AddNewDrawing()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x7BC31C", Offset = "0x7BC31C", VA = "0x7BC31C")]
	public void DeleteCurrentDrawing()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x7BC428", Offset = "0x7BC428", VA = "0x7BC428")]
	public void SwitchToDrawingIdx(int idx)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x7BC4A4", Offset = "0x7BC4A4", VA = "0x7BC4A4")]
	public void PrevDrawing()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x7BC4C4", Offset = "0x7BC4C4", VA = "0x7BC4C4")]
	public void NextDrawing()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x7BC4E4", Offset = "0x7BC4E4", VA = "0x7BC4E4")]
	public void ReplaceDrawing3D(Drawing drawing3D)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x7BC55C", Offset = "0x7BC55C", VA = "0x7BC55C")]
	public void QuitApp()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x7BC564", Offset = "0x7BC564", VA = "0x7BC564")]
	public PlayerDelegate()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x7BC6D4", Offset = "0x7BC6D4", VA = "0x7BC6D4")]
	private void <Start>b__22_0(bool val)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x7BC6F4", Offset = "0x7BC6F4", VA = "0x7BC6F4")]
	private void <Start>b__22_1(bool val)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x7BC714", Offset = "0x7BC714", VA = "0x7BC714")]
	private void <Start>b__22_2(Color val)
	{
	}
}
[Token(Token = "0x2000050")]
public class ClearDrawingAction : IUndoable<ClearDrawingAction.UndoInfo>
{
	[Token(Token = "0x2000051")]
	public struct UndoInfo
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Drawing oldDrawing2D;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Drawing oldDrawing3D;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Drawing newDrawing2D;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Drawing newDrawing3D;
	}

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private PlayerDelegate player;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private IUndoSaver<UndoInfo> undoStack;

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x121D7B4", Offset = "0x121D7B4", VA = "0x121D7B4")]
	public ClearDrawingAction(PlayerDelegate player)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x121D850", Offset = "0x121D850", VA = "0x121D850", Slot = "4")]
	public void Undo(ref UndoInfo info)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x121D900", Offset = "0x121D900", VA = "0x121D900", Slot = "5")]
	public void Redo(ref UndoInfo info)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x121DA4C", Offset = "0x121DA4C", VA = "0x121DA4C")]
	public void Do()
	{
	}
}
[Token(Token = "0x2000052")]
public enum Modifier
{
	[Token(Token = "0x40001BF")]
	None,
	[Token(Token = "0x40001C0")]
	Pressure
}
[Token(Token = "0x2000053")]
public class PlayerState
{
	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Modifier opacityModifier;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Modifier sizeModifier;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isEraser;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color brushColor;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Drawing> drawings2D;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Drawing> drawings3D;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<UndoStackGroup> drawingUndoGroups;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int currentDrawing;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UndoSystem undosys;

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x7BC5D0", Offset = "0x7BC5D0", VA = "0x7BC5D0")]
	public PlayerState()
	{
	}
}
[Token(Token = "0x2000054")]
public static class MatrixExtensions
{
	[Token(Token = "0x600015A")]
	[Address(RVA = "0x122AC18", Offset = "0x122AC18", VA = "0x122AC18")]
	public static Quaternion ExtractRotation(Matrix4x4 matrix)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x122AC0C", Offset = "0x122AC0C", VA = "0x122AC0C")]
	public static Vector3 ExtractPosition(Matrix4x4 matrix)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x122AC30", Offset = "0x122AC30", VA = "0x122AC30")]
	public static Vector3 ExtractScale(Matrix4x4 matrix)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000055")]
public class PresetCamSwitcher : MonoBehaviour
{
	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool addDefaultView;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform cameraTransform;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Transform> views;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int viewIndex;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 offsetPosition;

	[Token(Token = "0x1700000E")]
	public int currentViewIndex
	{
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x7BDCB4", Offset = "0x7BDCB4", VA = "0x7BDCB4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x7BDCBC", Offset = "0x7BDCBC", VA = "0x7BDCBC")]
	public void SwitchToView(int n)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x7BDEA0", Offset = "0x7BDEA0", VA = "0x7BDEA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x7BDDAC", Offset = "0x7BDDAC", VA = "0x7BDDAC")]
	private void SwitchView()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x7BE26C", Offset = "0x7BE26C", VA = "0x7BE26C")]
	private void NextView()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x7BE2D4", Offset = "0x7BE2D4", VA = "0x7BE2D4")]
	public PresetCamSwitcher()
	{
	}
}
[Token(Token = "0x2000056")]
public class Radio : MonoBehaviour
{
	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<AudioClip> songs;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<AudioClip> songsCopy;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioSource audioSource;

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x7C035C", Offset = "0x7C035C", VA = "0x7C035C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x7C03D8", Offset = "0x7C03D8", VA = "0x7C03D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x7C0518", Offset = "0x7C0518", VA = "0x7C0518")]
	public Radio()
	{
	}
}
[Token(Token = "0x2000057")]
public class DitherMSAAManager : MonoBehaviour
{
	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D[] blueNoiseTextures;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int msaaLevel;

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x122316C", Offset = "0x122316C", VA = "0x122316C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1223198", Offset = "0x1223198", VA = "0x1223198")]
	private void OnMSAASwitched()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1223200", Offset = "0x1223200", VA = "0x1223200")]
	private void Update()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1223378", Offset = "0x1223378", VA = "0x1223378")]
	public DitherMSAAManager()
	{
	}
}
[Token(Token = "0x2000058")]
public class FigureShadowmapRenderer : MonoBehaviour
{
	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform directionalLight;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform renderMeshesRoot;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float distFromCenter;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float nearPlane;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float farPlane;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float shadowBias;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool needsRender;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RenderTexture shadowmap;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CommandBuffer clearCmd;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Shader depthShader;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material depthMaterial;

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1225DDC", Offset = "0x1225DDC", VA = "0x1225DDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x12261DC", Offset = "0x12261DC", VA = "0x12261DC")]
	private void HandleEvent(ShadowRenderRequestedEvent msg)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x12261E8", Offset = "0x12261E8", VA = "0x12261E8")]
	private void Update()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1227094", Offset = "0x1227094", VA = "0x1227094")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x12270D0", Offset = "0x12270D0", VA = "0x12270D0")]
	public FigureShadowmapRenderer()
	{
	}
}
[Token(Token = "0x2000059")]
public class LogoCenterer : MonoBehaviour
{
	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform targetTrans;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 targetPos;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool done;

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x122CB74", Offset = "0x122CB74", VA = "0x122CB74")]
	private void Start()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x122CBC8", Offset = "0x122CBC8", VA = "0x122CBC8")]
	private void Delay()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x122CBD4", Offset = "0x122CBD4", VA = "0x122CBD4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x122CC58", Offset = "0x122CC58", VA = "0x122CC58")]
	public LogoCenterer()
	{
	}
}
[Token(Token = "0x200005A")]
public class StudioAdditiveScene : MonoBehaviour
{
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x7C5DCC", Offset = "0x7C5DCC", VA = "0x7C5DCC")]
	public StudioAdditiveScene()
	{
	}
}
[Token(Token = "0x200005B")]
[SerializeField]
public class BrushSettings : ScriptableObject
{
	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mesh visualizationMesh;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material visualizationMaterial;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve sizePressureCurve2D;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve opacityPressureCurve2D;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AnimationCurve sizePressureCurve3D;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve opacityPressureCurve3D;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float brushSize;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float brushSizeMin;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float brushSizeMax;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool lazybrush;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float lazybrushDist;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float lazybrushMin;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float lazybrushMax;

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x12165D0", Offset = "0x12165D0", VA = "0x12165D0")]
	public BrushSettings()
	{
	}
}
[Token(Token = "0x200005C")]
public class ModelSetTable : ScriptableObject
{
	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ModelTable male;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ModelTable female;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ModelTable misc;

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x122E6C0", Offset = "0x122E6C0", VA = "0x122E6C0")]
	public ModelSetTable()
	{
	}
}
[Serializable]
[Token(Token = "0x200005D")]
public struct ModelParams
{
	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string prefabName;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public GameObject censorPrefab;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject boxPrefab;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D normalMap;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string artistName;
}
[Token(Token = "0x200005E")]
[SerializeField]
public class ModelTable : ScriptableObject
{
	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<ModelParams> models;

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x122FC44", Offset = "0x122FC44", VA = "0x122FC44")]
	public ModelTable()
	{
	}
}
[Token(Token = "0x200005F")]
public class PaletteTable : ScriptableObject
{
	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color[] colorPalette;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int defaultColorIndex;

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x7B85EC", Offset = "0x7B85EC", VA = "0x7B85EC")]
	public PaletteTable()
	{
	}
}
[Serializable]
[Token(Token = "0x2000060")]
public struct SoundEffect
{
	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public AudioClip clip;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float volumeBias;
}
[Token(Token = "0x2000061")]
public class SoundTable : ScriptableObject
{
	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float overallVolume;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve penPressureVolumeCurve;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve penSpeedPitchCurve;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve penSpeedVolumeCurve;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public SoundEffect clearScene;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public SoundEffect menuSelect;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public SoundEffect pencilLoop;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public SoundEffect undo;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public SoundEffect redo;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public SoundEffect timerEnd;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public SoundEffect cameraShutter;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public SoundEffect fileSaved;

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x7C4E4C", Offset = "0x7C4E4C", VA = "0x7C4E4C")]
	public SoundTable()
	{
	}
}
[Token(Token = "0x2000062")]
public class SoundManager : MonoBehaviour
{
	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SoundTable soundTable;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource[] sources;

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x7C4358", Offset = "0x7C4358", VA = "0x7C4358")]
	private void Awake()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x7C4854", Offset = "0x7C4854", VA = "0x7C4854")]
	private void PlaySound(SoundEffect effect, bool loop = false, bool randomTime = false, bool randomFrequency = false)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x7C4BCC", Offset = "0x7C4BCC", VA = "0x7C4BCC")]
	private void StopLoopingSound(SoundEffect effect)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x7C4CEC", Offset = "0x7C4CEC", VA = "0x7C4CEC")]
	private void HandleEvent(ClearSceneEvent msg)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x7C4D14", Offset = "0x7C4D14", VA = "0x7C4D14")]
	private void HandleEvent(TimerEndEvent msg)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x7C4D3C", Offset = "0x7C4D3C", VA = "0x7C4D3C")]
	private void HandleEvent(UndoEvent msg)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x7C4D64", Offset = "0x7C4D64", VA = "0x7C4D64")]
	private void HandleEvent(RedoEvent msg)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x7C4D8C", Offset = "0x7C4D8C", VA = "0x7C4D8C")]
	private void HandleEvent(StartDrawingEvent msg)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x7C4D90", Offset = "0x7C4D90", VA = "0x7C4D90")]
	private void HandleEvent(StopDrawingEvent msg)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x7C4D94", Offset = "0x7C4D94", VA = "0x7C4D94")]
	private void HandleEvent(PictureTakenEvent msg)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x7C4DBC", Offset = "0x7C4DBC", VA = "0x7C4DBC")]
	private void HandleEvent(FileSavedEvent msg)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x7C4DE4", Offset = "0x7C4DE4", VA = "0x7C4DE4")]
	public SoundManager()
	{
	}
}
[Token(Token = "0x2000063")]
public class DrawingStressTest : MonoBehaviour
{
	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PlayerDelegate player;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int pointCount;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int pointsPerLine;

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1224924", Offset = "0x1224924", VA = "0x1224924")]
	private void Start()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1224D6C", Offset = "0x1224D6C", VA = "0x1224D6C")]
	public DrawingStressTest()
	{
	}
}
[Token(Token = "0x2000064")]
public class RenderTextureTest : MonoBehaviour
{
	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mesh testMesh;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material testMeshMaterial;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material triMeshMaterial;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Camera drawCam;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Mesh triMesh;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RenderTexture renderTexture;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Material mat;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer meshRenderer;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private CommandBuffer cmd;

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x7C29C4", Offset = "0x7C29C4", VA = "0x7C29C4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x7C2F38", Offset = "0x7C2F38", VA = "0x7C2F38")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x7C2F74", Offset = "0x7C2F74", VA = "0x7C2F74")]
	private void Update()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x7C2FDC", Offset = "0x7C2FDC", VA = "0x7C2FDC")]
	public RenderTextureTest()
	{
	}
}
[Token(Token = "0x2000065")]
public class BrushTool : ITool, IUndoable<BrushTool.UndoInfo>
{
	[Token(Token = "0x2000066")]
	public struct UndoInfo
	{
	}

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private IUndoSaver<UndoInfo> undoStack;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PlayerState state;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private BrushSettings settings;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Drawing drawing;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IBrushSurface surface;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 prevPosForFeedbackPurposes;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool is3D;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 lazybrushPos;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 prevInputPos;

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x12166D0", Offset = "0x12166D0", VA = "0x12166D0")]
	public BrushTool(IBrushSurface surface, Drawing drawing, PlayerState state, BrushSettings settings, bool is3D)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1216804", Offset = "0x1216804", VA = "0x1216804", Slot = "4")]
	public void SetDrawing(Drawing drawing)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x121680C", Offset = "0x121680C", VA = "0x121680C", Slot = "5")]
	public void InteractStart(Matrix4x4 xform, float pressure)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x121709C", Offset = "0x121709C", VA = "0x121709C", Slot = "6")]
	public void Interacting(Matrix4x4 xform, float pressure)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x12175BC", Offset = "0x12175BC", VA = "0x12175BC", Slot = "7")]
	public void InteractEnd(Matrix4x4 xform, float pressure)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x12176E8", Offset = "0x12176E8", VA = "0x12176E8", Slot = "8")]
	public void Scroll(float amount)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x121777C", Offset = "0x121777C", VA = "0x121777C", Slot = "9")]
	public void AuxilaryAction(Matrix4x4 xform)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x1217780", Offset = "0x1217780", VA = "0x1217780", Slot = "12")]
	public void Undo(ref UndoInfo info)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x12177B0", Offset = "0x12177B0", VA = "0x12177B0", Slot = "13")]
	public void Redo(ref UndoInfo info)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1217820", Offset = "0x1217820", VA = "0x1217820", Slot = "10")]
	public void RenderVisualization(Matrix4x4 xform)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1217964", Offset = "0x1217964", VA = "0x1217964", Slot = "11")]
	public void UpdateStickVisuals(ToolStick stick)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1216D40", Offset = "0x1216D40", VA = "0x1216D40")]
	private void AddPointToLine(ref BrushLine brushLine, Vector3 pos, Vector3 up, float sizePressure, float opacityPressure)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x1216CA8", Offset = "0x1216CA8", VA = "0x1216CA8")]
	private float MappedSizePressure(float pressure)
	{
		return default(float);
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1216CF4", Offset = "0x1216CF4", VA = "0x1216CF4")]
	private float MappedOpacityPressure(float pressure)
	{
		return default(float);
	}
}
[Token(Token = "0x2000067")]
public interface ITool
{
	[Token(Token = "0x6000199")]
	void SetDrawing(Drawing drawing);

	[Token(Token = "0x600019A")]
	void InteractStart(Matrix4x4 xform, float pressure);

	[Token(Token = "0x600019B")]
	void Interacting(Matrix4x4 xform, float pressure);

	[Token(Token = "0x600019C")]
	void InteractEnd(Matrix4x4 xform, float pressure);

	[Token(Token = "0x600019D")]
	void Scroll(float amount);

	[Token(Token = "0x600019E")]
	void AuxilaryAction(Matrix4x4 xform);

	[Token(Token = "0x600019F")]
	void RenderVisualization(Matrix4x4 xform);

	[Token(Token = "0x60001A0")]
	void UpdateStickVisuals(ToolStick stick);
}
[Token(Token = "0x2000068")]
public class TintTool : ITool, IUndoable<TintTool.UndoInfo>
{
	[Token(Token = "0x2000069")]
	public struct UndoInfo
	{
		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Drawing prevDrawing;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Drawing nextDrawing;
	}

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private IUndoSaver<UndoInfo> undoStack;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Drawing prevDrawing;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private PlayerDelegate player;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private PlayerState state;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private BrushSettings settings;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Drawing drawing;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private IBrushSurface surface;

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x123F880", Offset = "0x123F880", VA = "0x123F880")]
	public TintTool(IBrushSurface surface, Drawing drawing, PlayerState state, BrushSettings settings, PlayerDelegate player)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x123F974", Offset = "0x123F974", VA = "0x123F974", Slot = "4")]
	public void SetDrawing(Drawing drawing)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x123F97C", Offset = "0x123F97C", VA = "0x123F97C", Slot = "12")]
	public void Undo(ref UndoInfo info)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x123F99C", Offset = "0x123F99C", VA = "0x123F99C", Slot = "13")]
	public void Redo(ref UndoInfo info)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x123F9BC", Offset = "0x123F9BC", VA = "0x123F9BC", Slot = "9")]
	public void AuxilaryAction(Matrix4x4 xform)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x123F9C0", Offset = "0x123F9C0", VA = "0x123F9C0", Slot = "5")]
	public void InteractStart(Matrix4x4 xform, float pressure)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x123FED0", Offset = "0x123FED0", VA = "0x123FED0", Slot = "7")]
	public void InteractEnd(Matrix4x4 xform, float pressure)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x123FA58", Offset = "0x123FA58", VA = "0x123FA58", Slot = "6")]
	public void Interacting(Matrix4x4 xform, float pressure)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1240010", Offset = "0x1240010", VA = "0x1240010", Slot = "10")]
	public void RenderVisualization(Matrix4x4 xform)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1240154", Offset = "0x1240154", VA = "0x1240154", Slot = "8")]
	public void Scroll(float amount)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x12401E8", Offset = "0x12401E8", VA = "0x12401E8", Slot = "11")]
	public void UpdateStickVisuals(ToolStick stick)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x123FFD8", Offset = "0x123FFD8", VA = "0x123FFD8")]
	private float MappedPressure(float pressure)
	{
		return default(float);
	}
}
[Token(Token = "0x200006A")]
public class ToolStick : MonoBehaviour
{
	[Token(Token = "0x4000228")]
	public const float minDist = 0f;

	[Token(Token = "0x4000229")]
	public const float maxDist = 0.07f;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform baseTransform;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform tipTransform;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform tipTranform3D;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshRenderer stickMeshRenderer;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public VRUIStickPointer uiPointer;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform visualTransformPen;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform visualTransformSphere;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material stickBrushColMat;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool <positionAdjustAllowed>k__BackingField;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool <isParented>k__BackingField;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	private bool scaleYAxis;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform visualTransform;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform originalParent;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 localStickPos;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Vector3 localStickEuler;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool initialized;

	[Token(Token = "0x1700000F")]
	public bool positionAdjustAllowed
	{
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x12403B4", Offset = "0x12403B4", VA = "0x12403B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x12403BC", Offset = "0x12403BC", VA = "0x12403BC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public bool isParented
	{
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x12403C8", Offset = "0x12403C8", VA = "0x12403C8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x12403D0", Offset = "0x12403D0", VA = "0x12403D0")]
		private set
		{
		}
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x12403DC", Offset = "0x12403DC", VA = "0x12403DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x124098C", Offset = "0x124098C", VA = "0x124098C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1240A0C", Offset = "0x1240A0C", VA = "0x1240A0C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1240634", Offset = "0x1240634", VA = "0x1240634")]
	public static Vector3 Parse(string str)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x124081C", Offset = "0x124081C", VA = "0x124081C")]
	public void SetCanAdjustPen(bool canAdjust)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x1240D14", Offset = "0x1240D14", VA = "0x1240D14")]
	public void Unparent()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1240A94", Offset = "0x1240A94", VA = "0x1240A94")]
	public void Reparent()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1240BB8", Offset = "0x1240BB8", VA = "0x1240BB8")]
	public void ResetStick()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1240D50", Offset = "0x1240D50", VA = "0x1240D50")]
	public bool IsRepositioning()
	{
		return default(bool);
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x1240DDC", Offset = "0x1240DDC", VA = "0x1240DDC")]
	public Matrix4x4 GetPosition()
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x1240EA8", Offset = "0x1240EA8", VA = "0x1240EA8")]
	public void SetPosition(Matrix4x4 mat)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x1240F50", Offset = "0x1240F50", VA = "0x1240F50")]
	public void UncollideStick()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x1240F84", Offset = "0x1240F84", VA = "0x1240F84")]
	public void CollideStick(Vector3 posOnCanvas, float distFromCanvas)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x1241040", Offset = "0x1241040", VA = "0x1241040")]
	public void CollideStick(Brush2DCanvas canvas)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x12402E0", Offset = "0x12402E0", VA = "0x12402E0")]
	public void SetStickSize(float radius)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x1240320", Offset = "0x1240320", VA = "0x1240320")]
	public void SetStickColour(Color col)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x124114C", Offset = "0x124114C", VA = "0x124114C")]
	public void Show()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x124117C", Offset = "0x124117C", VA = "0x124117C")]
	public void Hide()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x12411AC", Offset = "0x12411AC", VA = "0x12411AC")]
	public void SwitchToSphereVisuals()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x12407A8", Offset = "0x12407A8", VA = "0x12407A8")]
	public void SwitchToPenVisuals()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x1241224", Offset = "0x1241224", VA = "0x1241224")]
	public ToolStick()
	{
	}
}
[Token(Token = "0x200006B")]
public interface IUndoable<T>
{
	[Token(Token = "0x60001C6")]
	void Undo(ref T info);

	[Token(Token = "0x60001C7")]
	void Redo(ref T info);
}
[Token(Token = "0x200006C")]
public interface IUndoSaver<T>
{
	[Token(Token = "0x60001C8")]
	void PushAction(T action);
}
[Token(Token = "0x200006D")]
public interface IUndoStack
{
	[Token(Token = "0x60001C9")]
	void Undo();

	[Token(Token = "0x60001CA")]
	void Redo();

	[Token(Token = "0x60001CB")]
	void FlushRedo();
}
[Token(Token = "0x200006E")]
public class UndoStackHandle<T> : UndoStackHandleBase, IUndoSaver<T>
{
	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private UndoSystem system;

	[Token(Token = "0x60001CC")]
	public UndoStackHandle(IUndoable<T> undoable, UndoSystem system)
	{
	}

	[Token(Token = "0x60001CD")]
	public void PushAction(T action)
	{
	}
}
[Token(Token = "0x200006F")]
public class UndoStackHandleBase
{
	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private object <undoable>k__BackingField;

	[Token(Token = "0x17000011")]
	public object undoable
	{
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x12428BC", Offset = "0x12428BC", VA = "0x12428BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x12428C4", Offset = "0x12428C4", VA = "0x12428C4")]
		protected set
		{
		}
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x12428CC", Offset = "0x12428CC", VA = "0x12428CC")]
	public UndoStackHandleBase()
	{
	}
}
[Token(Token = "0x2000070")]
public class UndoSystem : IUndoStack
{
	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UndoStackGroup currentGroup;

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x12428D4", Offset = "0x12428D4", VA = "0x12428D4")]
	public UndoSystem(UndoStackGroup group)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x1242908", Offset = "0x1242908", VA = "0x1242908")]
	public void SwitchUndoGroup(UndoStackGroup group)
	{
	}

	[Token(Token = "0x60001D3")]
	public IUndoSaver<T> CreateUndoStackFor<T>(IUndoable<T> undoable)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	public IUndoSaver<T> GetStackForHandle<T>(UndoStackHandle<T> handle)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x1242910", Offset = "0x1242910", VA = "0x1242910", Slot = "6")]
	public void FlushRedo()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x1242928", Offset = "0x1242928", VA = "0x1242928", Slot = "5")]
	public void Redo()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x12429B0", Offset = "0x12429B0", VA = "0x12429B0", Slot = "4")]
	public void Undo()
	{
	}
}
[Token(Token = "0x2000071")]
public class UndoStackGroup : IUndoStack
{
	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<IUndoStack> uniqueUndoStacks;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<UndoStackHandleBase, IUndoStack> handleMap;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<IUndoStack> globalUndoStack;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int top;

	[Token(Token = "0x60001D8")]
	public IUndoSaver<T> GetStackForHandle<T>(UndoStackHandle<T> handle)
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x12423C4", Offset = "0x12423C4", VA = "0x12423C4", Slot = "4")]
	public void Undo()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x12424C4", Offset = "0x12424C4", VA = "0x12424C4", Slot = "5")]
	public void Redo()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x12425D4", Offset = "0x12425D4", VA = "0x12425D4", Slot = "6")]
	public void FlushRedo()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x1242714", Offset = "0x1242714", VA = "0x1242714")]
	public void PushActionForStack(IUndoStack stack)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x12427B4", Offset = "0x12427B4", VA = "0x12427B4")]
	public UndoStackGroup()
	{
	}
}
[Token(Token = "0x2000072")]
public class UndoStack<T> : IUndoSaver<T>, IUndoStack
{
	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private UndoStackGroup group;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private IUndoable<T> undoable;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<T> undoStack;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int top;

	[Token(Token = "0x60001DE")]
	public void PushAction(T action)
	{
	}

	[Token(Token = "0x60001DF")]
	public UndoStack(IUndoable<T> undoable, UndoStackGroup globalStack)
	{
	}

	[Token(Token = "0x60001E0")]
	public void Undo()
	{
	}

	[Token(Token = "0x60001E1")]
	public void Redo()
	{
	}

	[Token(Token = "0x60001E2")]
	public void FlushRedo()
	{
	}
}
[Token(Token = "0x2000073")]
public interface IInteractible
{
	[Token(Token = "0x60001E3")]
	bool StartPressing(Vector3 location);

	[Token(Token = "0x60001E4")]
	void Pressing(Vector3 location);

	[Token(Token = "0x60001E5")]
	void Cancelling(Vector3 location);

	[Token(Token = "0x60001E6")]
	void Unpress();

	[Token(Token = "0x60001E7")]
	void UnpressCancel();
}
[Token(Token = "0x2000074")]
public class KeyBehaviour : MonoBehaviour
{
	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer rend;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color hoverColor;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Color orgColor;

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x122C398", Offset = "0x122C398", VA = "0x122C398")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x122C3DC", Offset = "0x122C3DC", VA = "0x122C3DC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x122C41C", Offset = "0x122C41C", VA = "0x122C41C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x122C45C", Offset = "0x122C45C", VA = "0x122C45C")]
	public KeyBehaviour()
	{
	}
}
[Token(Token = "0x2000075")]
public class KeyboardCreator : MonoBehaviour
{
	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private char[] keyCharacters;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform[] firstRow;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] secondRow;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform[] thirdRow;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 rowOffsets;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float keySpacing;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float rowSpacing;

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x122C464", Offset = "0x122C464", VA = "0x122C464")]
	private void UpdateKeyboard()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x122C92C", Offset = "0x122C92C", VA = "0x122C92C")]
	public KeyboardCreator()
	{
	}
}
[Token(Token = "0x2000076")]
public class OnlineMenuController : MonoBehaviour
{
	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform keyboardRoot;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject keyPrefab;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject onlineScreen;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject offlineScreen;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshPro nameText;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshPro roomText;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshPro logText;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject roomTextPlaceHolder;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject nameTextPlaceHolder;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int textboxIndex;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject backButton;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public MeshRenderer[] nameInputBackgrounds;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float blinkRate;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Material lightMat;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Material darkMat;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Color darkColor;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private RoomController roomController;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool isOnline;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private SyncModelPose syncModelPose;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public VRToggle syncPoses;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public ModelSetResponder modelSetResponder;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private char[] keyCharacters;

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x7B6AB0", Offset = "0x7B6AB0", VA = "0x7B6AB0")]
	private void CreateKeyboard()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x7B6CA8", Offset = "0x7B6CA8", VA = "0x7B6CA8")]
	private void UpdateKeys()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x7B702C", Offset = "0x7B702C", VA = "0x7B702C")]
	public void TypeLetter(GameObject key)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x7B7180", Offset = "0x7B7180", VA = "0x7B7180")]
	public void Backspace()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x7B7358", Offset = "0x7B7358", VA = "0x7B7358")]
	public void SelectTextbox(int index)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x7B7360", Offset = "0x7B7360", VA = "0x7B7360")]
	public void Clear()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x7B7404", Offset = "0x7B7404", VA = "0x7B7404")]
	public void JoinRoom()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x7B75E4", Offset = "0x7B75E4", VA = "0x7B75E4")]
	public void LeaveRoom()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x7B765C", Offset = "0x7B765C", VA = "0x7B765C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x7B79A4", Offset = "0x7B79A4", VA = "0x7B79A4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x7B7A58", Offset = "0x7B7A58", VA = "0x7B7A58")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x7B7D18", Offset = "0x7B7D18", VA = "0x7B7D18")]
	public void BackToRoomEntry()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x7B7910", Offset = "0x7B7910", VA = "0x7B7910")]
	private void BlinkSelection()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x7B7D34", Offset = "0x7B7D34", VA = "0x7B7D34")]
	private void UndoBlink()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x7B7DBC", Offset = "0x7B7DBC", VA = "0x7B7DBC")]
	public OnlineMenuController()
	{
	}
}
[Token(Token = "0x2000077")]
public class PlayerUIManager : MonoBehaviour
{
	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<Collider, IInteractible> interactibleLookup;

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x7BC748", Offset = "0x7BC748", VA = "0x7BC748")]
	private void Start()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x7BC900", Offset = "0x7BC900", VA = "0x7BC900")]
	public PlayerUIManager()
	{
	}
}
[Token(Token = "0x2000078")]
public class TempVRButton : MonoBehaviour
{
	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent onClick;

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x123EF04", Offset = "0x123EF04", VA = "0x123EF04")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x123EF94", Offset = "0x123EF94", VA = "0x123EF94")]
	public TempVRButton()
	{
	}
}
[Token(Token = "0x2000079")]
public class UIManager : MonoBehaviour
{
	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRRig vrRig;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HandBehaviour mainHand;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject vrUI;

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x124184C", Offset = "0x124184C", VA = "0x124184C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x1241938", Offset = "0x1241938", VA = "0x1241938")]
	public UIManager()
	{
	}
}
[Token(Token = "0x200007A")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F500", Offset = "0x57F500")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F500", Offset = "0x57F500")]
public class VRButton : VRWidgetBase, IInteractible
{
	[Token(Token = "0x200007B")]
	protected enum State
	{
		[Token(Token = "0x400027B")]
		DEFAULT,
		[Token(Token = "0x400027C")]
		PRESSING,
		[Token(Token = "0x400027D")]
		LONG_PRESS_DONE
	}

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color visualTint;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool hasLongPress;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public VRRing longPressRing;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UnityEvent onClick;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UnityEvent onLongPress;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioSource _uiAudioSource;

	[Token(Token = "0x4000270")]
	private const float longPressTime = 1f;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected SpriteRenderer sprite;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected MeshRenderer meshRenderer;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected MeshFilter meshFilter;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Material material;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected State state;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected Vector3 initialInteraction;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected Vector3 prevInteraction;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	protected float stateTimeCounter;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Color extraTint;

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x1242B78", Offset = "0x1242B78", VA = "0x1242B78", Slot = "9")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x1242D60", Offset = "0x1242D60", VA = "0x1242D60", Slot = "4")]
	public bool StartPressing(Vector3 location)
	{
		return default(bool);
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1242D78", Offset = "0x1242D78", VA = "0x1242D78", Slot = "5")]
	public void Pressing(Vector3 location)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x1242EAC", Offset = "0x1242EAC", VA = "0x1242EAC", Slot = "6")]
	public void Cancelling(Vector3 location)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x1242ECC", Offset = "0x1242ECC", VA = "0x1242ECC", Slot = "7")]
	public void Unpress()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x1242EBC", Offset = "0x1242EBC", VA = "0x1242EBC", Slot = "8")]
	public void UnpressCancel()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x1242F14", Offset = "0x1242F14", VA = "0x1242F14", Slot = "10")]
	public virtual void UpdateVisuals()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x1243200", Offset = "0x1243200", VA = "0x1243200", Slot = "11")]
	protected virtual void Clicked()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x1242E80", Offset = "0x1242E80", VA = "0x1242E80")]
	private void SetState(State nextState, Vector3 location)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x1243250", Offset = "0x1243250", VA = "0x1243250")]
	public VRButton()
	{
	}
}
[Token(Token = "0x200007C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F594", Offset = "0x57F594")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F594", Offset = "0x57F594")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F594", Offset = "0x57F594")]
public class VRColorPicker : VRWidgetBase, IInteractible
{
	[Token(Token = "0x200007D")]
	private enum State
	{
		[Token(Token = "0x400028A")]
		NotPicking,
		[Token(Token = "0x400028B")]
		PickRing,
		[Token(Token = "0x400028C")]
		PickTriangle
	}

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float ringThickness;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Mesh mesh;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform xform;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 currentHSV;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool awakePending;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private UnityAction<Color> currentPickCallback;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private State state;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Vector3> vertBuf;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<Color32> colBuf;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<int> indexBuf;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int triangleIndexStart;

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1243314", Offset = "0x1243314", VA = "0x1243314")]
	public void StartColorPick(Color initialColor, UnityAction<Color> callback)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x124337C", Offset = "0x124337C", VA = "0x124337C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x124350C", Offset = "0x124350C", VA = "0x124350C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x1243D68", Offset = "0x1243D68", VA = "0x1243D68")]
	private bool HitWidgetTriangle(Vector3 localPos, out Vector3 bary)
	{
		return default(bool);
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x1243F24", Offset = "0x1243F24", VA = "0x1243F24")]
	private bool DoInteraction(Vector3 location)
	{
		return default(bool);
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x1244150", Offset = "0x1244150", VA = "0x1244150", Slot = "4")]
	public bool StartPressing(Vector3 location)
	{
		return default(bool);
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x1244154", Offset = "0x1244154", VA = "0x1244154", Slot = "5")]
	public void Pressing(Vector3 location)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x1244158", Offset = "0x1244158", VA = "0x1244158", Slot = "6")]
	public void Cancelling(Vector3 location)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x124415C", Offset = "0x124415C", VA = "0x124415C", Slot = "7")]
	public void Unpress()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x1244164", Offset = "0x1244164", VA = "0x1244164", Slot = "8")]
	public void UnpressCancel()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x124416C", Offset = "0x124416C", VA = "0x124416C")]
	public VRColorPicker()
	{
	}
}
[Token(Token = "0x200007E")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F66C", Offset = "0x57F66C")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F66C", Offset = "0x57F66C")]
public class VRRing : VRWidgetBase
{
	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float percent;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float ringThickness;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool withHoleInCenter;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Mesh mesh;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool awakePending;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> vertBuf;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<Color32> colBuf;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<int> indexBuf;

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x12442AC", Offset = "0x12442AC", VA = "0x12442AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x1244420", Offset = "0x1244420", VA = "0x1244420")]
	private void Update()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x124319C", Offset = "0x124319C", VA = "0x124319C")]
	public void Show()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x1243174", Offset = "0x1243174", VA = "0x1243174")]
	public void Hide()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x12446DC", Offset = "0x12446DC", VA = "0x12446DC")]
	public VRRing()
	{
	}
}
[Token(Token = "0x200007F")]
public class BoolEvent : UnityEvent<bool>
{
	[Token(Token = "0x600021D")]
	[Address(RVA = "0x1213DB4", Offset = "0x1213DB4", VA = "0x1213DB4")]
	public BoolEvent()
	{
	}
}
[Token(Token = "0x2000080")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F710", Offset = "0x57F710")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F710", Offset = "0x57F710")]
public class VRToggle : VRButton
{
	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool saveValue;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	public bool isOn;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
	public bool useTint;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Sprite enabledSprite;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Sprite disabledSprite;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Mesh enabledMesh;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Mesh disabledMesh;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public BoolEvent onValueChanged;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public BoolEvent onValueChangedByGroup;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public VRToggleGroup toggleGroup;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private AudioSource uiAudioSource;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private string keyName;

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x1244810", Offset = "0x1244810", VA = "0x1244810", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x1244990", Offset = "0x1244990", VA = "0x1244990")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x1244950", Offset = "0x1244950", VA = "0x1244950")]
	private bool GetBool(string keyName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x1244AA4", Offset = "0x1244AA4", VA = "0x1244AA4")]
	private void SetBool(bool value, string keyName)
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x1244AC4", Offset = "0x1244AC4", VA = "0x1244AC4", Slot = "11")]
	protected override void Clicked()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x1244D6C", Offset = "0x1244D6C", VA = "0x1244D6C", Slot = "10")]
	public override void UpdateVisuals()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x1244EC8", Offset = "0x1244EC8", VA = "0x1244EC8")]
	public VRToggle()
	{
	}
}
[Token(Token = "0x2000081")]
public class VRToggleGroup : MonoBehaviour
{
	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<VRToggle> toggles;

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x1244F60", Offset = "0x1244F60", VA = "0x1244F60")]
	private void Start()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x1245094", Offset = "0x1245094", VA = "0x1245094")]
	public VRToggleGroup()
	{
	}
}
[Token(Token = "0x2000082")]
public class VRUIStickPointer : MonoBehaviour
{
	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PlayerUIManager uiManager;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ToolStick stick;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float buttonCancelRegion;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IInteractible lastWidget;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Collider lastWidgetCollider;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 prevTipPos;

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x124509C", Offset = "0x124509C", VA = "0x124509C")]
	public void UpdateStick()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x1245690", Offset = "0x1245690", VA = "0x1245690")]
	private void Start()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x12456D0", Offset = "0x12456D0", VA = "0x12456D0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x1245710", Offset = "0x1245710", VA = "0x1245710")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x12450B0", Offset = "0x12450B0", VA = "0x12450B0")]
	private void ProcessWidgetPress(bool isFirstPress)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x12458DC", Offset = "0x12458DC", VA = "0x12458DC")]
	public VRUIStickPointer()
	{
	}
}
[Token(Token = "0x2000083")]
public class VRUIStyle : ScriptableObject
{
	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color buttonDefault;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color buttonHovering;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color buttonPressed;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color toggleUnselected;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Color accentColor;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Material vertexColHSVMat;

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x1245918", Offset = "0x1245918", VA = "0x1245918")]
	public VRUIStyle()
	{
	}
}
[Token(Token = "0x2000084")]
[DisallowMultipleComponent]
public class VRWidgetBase : MonoBehaviour
{
	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRUIStyle style;

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x124330C", Offset = "0x124330C", VA = "0x124330C")]
	public VRWidgetBase()
	{
	}
}
[Token(Token = "0x2000085")]
public class VideoPlayerBehaviour : MonoBehaviour
{
	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshPro pageText;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int videoIndex;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] videos;

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x1245A08", Offset = "0x1245A08", VA = "0x1245A08")]
	private void Update()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x1245A9C", Offset = "0x1245A9C", VA = "0x1245A9C")]
	public void ChangeIndex(int amount)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x1245B58", Offset = "0x1245B58", VA = "0x1245B58")]
	public VideoPlayerBehaviour()
	{
	}
}
[Token(Token = "0x2000086")]
public class WriteToInputField : MonoBehaviour
{
	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_InputField inputField;

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x1248F88", Offset = "0x1248F88", VA = "0x1248F88")]
	public void Write(int inputChar)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x1248FE8", Offset = "0x1248FE8", VA = "0x1248FE8")]
	public void Delete()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x1249040", Offset = "0x1249040", VA = "0x1249040")]
	public WriteToInputField()
	{
	}
}
[Token(Token = "0x2000087")]
public class EditorDebugDraw : MonoBehaviour
{
	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color color;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color selectedColor;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool wireframe;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool sphere;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float radius;

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x12254B4", Offset = "0x12254B4", VA = "0x12254B4")]
	private void Draw()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x1225558", Offset = "0x1225558", VA = "0x1225558")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x12255B4", Offset = "0x12255B4", VA = "0x12255B4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x1225610", Offset = "0x1225610", VA = "0x1225610")]
	public EditorDebugDraw()
	{
	}
}
[Token(Token = "0x2000088")]
public class VolumeControl : MonoBehaviour
{
	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshPro musicVolumeText;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshPro voiceVolumeText;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro menuVolumeText;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource musicAudioSource;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioSource[] voiceAudioSources;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioSource menuAudioSource;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float musicVolume;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float voiceVolume;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float menuVolume;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float maxVolume;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float menuMaxVolume;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public SoundManager soundManager;

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x1248410", Offset = "0x1248410", VA = "0x1248410")]
	private void Start()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x124862C", Offset = "0x124862C", VA = "0x124862C")]
	private void Update()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x12488C4", Offset = "0x12488C4", VA = "0x12488C4")]
	public void ChangeVolume(bool positive)
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x1248968", Offset = "0x1248968", VA = "0x1248968")]
	public void ChangeMenuVolume(bool positive)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x1248AB4", Offset = "0x1248AB4", VA = "0x1248AB4")]
	public void ChangeVoiceVolume(bool positive)
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x1248C50", Offset = "0x1248C50", VA = "0x1248C50")]
	public VolumeControl()
	{
	}
}
[Token(Token = "0x2000089")]
public class Watch : MonoBehaviour
{
	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform watchHand;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material mat;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 watchHandDefaultRot;

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x1248C68", Offset = "0x1248C68", VA = "0x1248C68")]
	private void Start()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x1248D54", Offset = "0x1248D54", VA = "0x1248D54")]
	private void Update()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x1248ED8", Offset = "0x1248ED8", VA = "0x1248ED8")]
	private void HandleEvent(TimerSecondPassEvent msg)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x1248F24", Offset = "0x1248F24", VA = "0x1248F24")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x1248F80", Offset = "0x1248F80", VA = "0x1248F80")]
	public Watch()
	{
	}
}
[Token(Token = "0x200008A")]
public class CameraPanelResponder : MonoBehaviour
{
	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRButton exploreButton;

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x1217ECC", Offset = "0x1217ECC", VA = "0x1217ECC")]
	public void SetCallbacks([Optional] UnityAction explorePressed)
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x1217F50", Offset = "0x1217F50", VA = "0x1217F50")]
	public CameraPanelResponder()
	{
	}
}
[Token(Token = "0x200008B")]
public class ColorPickerPanelResponder : MonoBehaviour
{
	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRButton doneButton;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRColorPicker picker;

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x121E3F0", Offset = "0x121E3F0", VA = "0x121E3F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x121E48C", Offset = "0x121E48C", VA = "0x121E48C")]
	public void PickColor(Color initialColor, UnityAction<Color> callback)
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x121E508", Offset = "0x121E508", VA = "0x121E508")]
	public ColorPickerPanelResponder()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x121E510", Offset = "0x121E510", VA = "0x121E510")]
	private void <Start>b__2_0()
	{
	}
}
[Token(Token = "0x200008C")]
public class DebugUI : MonoBehaviour
{
	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ModelSpawner spawner;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text durationText;

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x122082C", Offset = "0x122082C", VA = "0x122082C")]
	private void Update()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x1220904", Offset = "0x1220904", VA = "0x1220904")]
	public DebugUI()
	{
	}
}
[Token(Token = "0x200008D")]
public class DurationResponder : MonoBehaviour
{
	[Token(Token = "0x200008E")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityAction<float> durationChanged;

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x124A048", Offset = "0x124A048", VA = "0x124A048")]
		public <>c__DisplayClass0_0()
		{
		}
	}

	[Token(Token = "0x200008F")]
	private sealed class <>c__DisplayClass0_1
	{
		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UIDuration dur;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass0_0 CS$<>8__locals1;

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x124A050", Offset = "0x124A050", VA = "0x124A050")]
		public <>c__DisplayClass0_1()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x124A058", Offset = "0x124A058", VA = "0x124A058")]
		internal void <SetCallbacks>b__0(bool val)
		{
		}
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x1224D80", Offset = "0x1224D80", VA = "0x1224D80")]
	public void SetCallbacks(UnityAction<float> durationChanged)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x1225250", Offset = "0x1225250", VA = "0x1225250")]
	public DurationResponder()
	{
	}
}
[Token(Token = "0x2000090")]
public class FilePanelResponder : MonoBehaviour
{
	[Token(Token = "0x2000091")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityAction exportPressed;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x124A914", Offset = "0x124A914", VA = "0x124A914")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x124A91C", Offset = "0x124A91C", VA = "0x124A91C")]
		internal void <SetCallbacks>b__0()
		{
		}
	}

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRButton exportButton;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRToggle pngAlphaToggle;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public VRButton exploreButton;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public VRRing loadingRing;

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x12270EC", Offset = "0x12270EC", VA = "0x12270EC")]
	public void SetCallbacks([Optional] UnityAction exportPressed, [Optional] UnityAction<bool> pngAlphaToggled, [Optional] UnityAction explorePressed)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x122729C", Offset = "0x122729C", VA = "0x122729C")]
	public void Update()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x1227380", Offset = "0x1227380", VA = "0x1227380")]
	public FilePanelResponder()
	{
	}
}
[Token(Token = "0x2000092")]
public class GrabManager : MonoBehaviour
{
	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Grabber[] grabbers;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool <isGrabbing>k__BackingField;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Grabbable[] grabbables;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Proto.Physics.Sphere[] grabberSpheres;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Grabbable currentObject;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float scaleGrabInitDistance;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool isScaling;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int prevFirst;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int prevSecond;

	[Token(Token = "0x17000012")]
	public bool isGrabbing
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1229A3C", Offset = "0x1229A3C", VA = "0x1229A3C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1229A44", Offset = "0x1229A44", VA = "0x1229A44")]
		private set
		{
		}
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x1229A50", Offset = "0x1229A50", VA = "0x1229A50")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x1229B14", Offset = "0x1229B14", VA = "0x1229B14")]
	public void ExplicitUpdate()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x1229B38", Offset = "0x1229B38", VA = "0x1229B38")]
	private void UpdateIfInRange()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x1229C18", Offset = "0x1229C18", VA = "0x1229C18")]
	private void UpdateGrabbing()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x122A3E8", Offset = "0x122A3E8", VA = "0x122A3E8")]
	private Grabbable FindClosestGrabbable(int grabberID)
	{
		return null;
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x122AB10", Offset = "0x122AB10", VA = "0x122AB10")]
	public GrabManager()
	{
	}
}
[Token(Token = "0x2000093")]
public class Grabbable : MonoBehaviour
{
	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform toMove;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool translateX;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool translateY;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool translateZ;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool rotation;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool scalable;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private SphereCollider <sphereCollider>k__BackingField;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private BoxCollider <boxCollider>k__BackingField;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform <xform>k__BackingField;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isGrabbed;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 offsetPos;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Matrix4x4 offsetMatrix;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 origScale;

	[Token(Token = "0x17000013")]
	public SphereCollider sphereCollider
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x122AB20", Offset = "0x122AB20", VA = "0x122AB20")]
		get
		{
			return null;
		}
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x122AB28", Offset = "0x122AB28", VA = "0x122AB28")]
		private set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public BoxCollider boxCollider
	{
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x122AB30", Offset = "0x122AB30", VA = "0x122AB30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x122AB38", Offset = "0x122AB38", VA = "0x122AB38")]
		private set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public Transform xform
	{
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x122AB40", Offset = "0x122AB40", VA = "0x122AB40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x122AB48", Offset = "0x122AB48", VA = "0x122AB48")]
		private set
		{
		}
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x122AB50", Offset = "0x122AB50", VA = "0x122AB50")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x122AB08", Offset = "0x122AB08", VA = "0x122AB08")]
	public void StoppedGrabbing()
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x122A830", Offset = "0x122A830", VA = "0x122A830")]
	public void ResetOffset(Matrix4x4 grabMatrix, Matrix4x4 grabInverseMatrix)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x122A944", Offset = "0x122A944", VA = "0x122A944")]
	public void Grabbing(Matrix4x4 grabMatrix, Matrix4x4 grabInverseMatrix)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x122ACC4", Offset = "0x122ACC4", VA = "0x122ACC4")]
	public Grabbable()
	{
	}
}
[Token(Token = "0x2000094")]
public class Grabber : MonoBehaviour
{
	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isWithinRange;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool isGrabbing;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SphereCollider sphereCollider;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform xform;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isLeftSide;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private VRRig vrRig;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private HandBehaviour mainHand;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color startColor;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Color targetColor;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Color gripColor;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Color grabbingColor;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Renderer[] gripRends;

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x122ACD4", Offset = "0x122ACD4", VA = "0x122ACD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x122A74C", Offset = "0x122A74C", VA = "0x122A74C")]
	public bool IsPressing()
	{
		return default(bool);
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x122AE0C", Offset = "0x122AE0C", VA = "0x122AE0C")]
	private void Update()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x122AFF0", Offset = "0x122AFF0", VA = "0x122AFF0")]
	public Grabber()
	{
	}
}
[Token(Token = "0x2000095")]
public class ModelSetResponder : MonoBehaviour
{
	[Token(Token = "0x2000096")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityAction<ModelTable> modelSetChanged;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ModelSetResponder <>4__this;

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x124A960", Offset = "0x124A960", VA = "0x124A960")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x124A968", Offset = "0x124A968", VA = "0x124A968")]
		internal void <SetCallbacks>b__0(bool val)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x124A9F0", Offset = "0x124A9F0", VA = "0x124A9F0")]
		internal void <SetCallbacks>b__1(bool val)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x124AA78", Offset = "0x124AA78", VA = "0x124AA78")]
		internal void <SetCallbacks>b__2(bool val)
		{
		}
	}

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ModelSetTable modelSets;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRToggle femaleToggle;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public VRToggle maleToggle;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public VRToggle miscToggle;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int setIndex;

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x122E428", Offset = "0x122E428", VA = "0x122E428")]
	public void SetCallbacks([Optional] UnityAction<ModelTable> modelSetChanged)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x122E6B8", Offset = "0x122E6B8", VA = "0x122E6B8")]
	public ModelSetResponder()
	{
	}
}
[Token(Token = "0x2000097")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F7B4", Offset = "0x57F7B4")]
public class OVRLaserPointer : MonoBehaviour
{
	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LineRenderer line;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool <hovering>k__BackingField;

	[Token(Token = "0x17000016")]
	public bool hovering
	{
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x7B4BFC", Offset = "0x7B4BFC", VA = "0x7B4BFC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x7B4C04", Offset = "0x7B4C04", VA = "0x7B4C04")]
		private set
		{
		}
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x7B4C10", Offset = "0x7B4C10", VA = "0x7B4C10")]
	public void SetCursorRay(Transform ray)
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x7B4C18", Offset = "0x7B4C18", VA = "0x7B4C18")]
	public void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x7B4C8C", Offset = "0x7B4C8C", VA = "0x7B4C8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x7B4CE8", Offset = "0x7B4CE8", VA = "0x7B4CE8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x7B4D0C", Offset = "0x7B4D0C", VA = "0x7B4D0C")]
	public OVRLaserPointer()
	{
	}
}
[Token(Token = "0x2000098")]
public class PaletteResponder : MonoBehaviour
{
	[Token(Token = "0x2000099")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityAction<Color> colorChanged;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PaletteResponder <>4__this;

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x124CDB4", Offset = "0x124CDB4", VA = "0x124CDB4")]
		public <>c__DisplayClass5_0()
		{
		}
	}

	[Token(Token = "0x200009A")]
	private sealed class <>c__DisplayClass5_1
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idx;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass5_0 CS$<>8__locals1;

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x124CDBC", Offset = "0x124CDBC", VA = "0x124CDBC")]
		public <>c__DisplayClass5_1()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x124CDC4", Offset = "0x124CDC4", VA = "0x124CDC4")]
		internal void <SetCallbacks>b__0(bool val)
		{
		}
	}

	[Token(Token = "0x200009B")]
	private sealed class <>c__DisplayClass5_2
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idx;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass5_0 CS$<>8__locals2;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityAction<Color> <>9__2;

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x124CE60", Offset = "0x124CE60", VA = "0x124CE60")]
		public <>c__DisplayClass5_2()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x124CE68", Offset = "0x124CE68", VA = "0x124CE68")]
		internal void <SetCallbacks>b__1()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x124CFF4", Offset = "0x124CFF4", VA = "0x124CFF4")]
		internal void <SetCallbacks>b__2(Color col)
		{
		}
	}

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PaletteTable palette;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ColorPickerPanelResponder picker;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private VRToggle[] colorToggles;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private VRToggle eraserToggle;

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x7B803C", Offset = "0x7B803C", VA = "0x7B803C")]
	private void Init()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x7B8230", Offset = "0x7B8230", VA = "0x7B8230")]
	public void SetCallbacks([Optional] UnityAction<Color> colorChanged, [Optional] UnityAction<bool> eraserToggled)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x7B85E4", Offset = "0x7B85E4", VA = "0x7B85E4")]
	public PaletteResponder()
	{
	}
}
[Token(Token = "0x200009C")]
public class PosePicker : MonoBehaviour
{
	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int targetPose;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int pageIndex;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int selectonPage;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro pageIndexText;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform selectionOutline;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D[] modelTextures;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MeshRenderer[] buttonMeshes;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject maleFemaleToggleGroup;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject miscToggleGroup;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public VRToggle[] filters;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Texture2D> onScreenTextures;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private SyncModelPose syncModelPose;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public VRToggle syncPosesToggle;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int pageCount;

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x7BCB10", Offset = "0x7BCB10", VA = "0x7BCB10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x7BCC00", Offset = "0x7BCC00", VA = "0x7BCC00")]
	private bool CheckList(Texture2D texture2D)
	{
		return default(bool);
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x7BCBA8", Offset = "0x7BCBA8", VA = "0x7BCBA8")]
	public void UpdateFilter()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x7BCC64", Offset = "0x7BCC64", VA = "0x7BCC64")]
	private void FilterDelay()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x7BD954", Offset = "0x7BD954", VA = "0x7BD954")]
	public void ChangePages(int amount)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x7BD998", Offset = "0x7BD998", VA = "0x7BD998")]
	public void SelectPose(int index)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x7BDBD0", Offset = "0x7BDBD0", VA = "0x7BDBD0")]
	public void ChangeModelSet(int index)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x7BDC2C", Offset = "0x7BDC2C", VA = "0x7BDC2C")]
	public void ChangeNetworkedTimer(float timerValue)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x7BDC30", Offset = "0x7BDC30", VA = "0x7BDC30")]
	public PosePicker()
	{
	}
}
[Token(Token = "0x200009D")]
public class ProtoDurationResponder : MonoBehaviour
{
	[Token(Token = "0x200009E")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image img;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UIDuration dur;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ProtoDurationResponder <>4__this;

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x124E2EC", Offset = "0x124E2EC", VA = "0x124E2EC")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x124E2F4", Offset = "0x124E2F4", VA = "0x124E2F4")]
		internal void <SetCallbacks>b__0()
		{
		}
	}

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button defaultDuration;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color selectedColor;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Image current;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private UnityAction<float> durationChanged;

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x7BE358", Offset = "0x7BE358", VA = "0x7BE358")]
	public void SetButton(Image img, UIDuration dur)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x7BE424", Offset = "0x7BE424", VA = "0x7BE424")]
	public void SetCallbacks(UnityAction<float> durationChanged)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x7BE8AC", Offset = "0x7BE8AC", VA = "0x7BE8AC")]
	public ProtoDurationResponder()
	{
	}
}
[Token(Token = "0x200009F")]
public class ProtoPaletteResponder : MonoBehaviour
{
	[Token(Token = "0x20000A0")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityAction<Color> colorChanged;

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x124E318", Offset = "0x124E318", VA = "0x124E318")]
		public <>c__DisplayClass2_0()
		{
		}
	}

	[Token(Token = "0x20000A1")]
	private sealed class <>c__DisplayClass2_1
	{
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image img;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass2_0 CS$<>8__locals1;

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x124E320", Offset = "0x124E320", VA = "0x124E320")]
		public <>c__DisplayClass2_1()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x124E328", Offset = "0x124E328", VA = "0x124E328")]
		internal void <SetCallbacks>b__0()
		{
		}
	}

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Image defaultColor;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private UnityAction<Color> colorChanged;

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x7BE904", Offset = "0x7BE904", VA = "0x7BE904")]
	public void SetCallbacks([Optional] UnityAction<Color> colorChanged)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x7BED74", Offset = "0x7BED74", VA = "0x7BED74")]
	public ProtoPaletteResponder()
	{
	}
}
[Token(Token = "0x20000A2")]
public class ProtoUIResponder : MonoBehaviour
{
	[Token(Token = "0x20000A3")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityAction<int> positionChanged;

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x124E3A0", Offset = "0x124E3A0", VA = "0x124E3A0")]
		public <>c__DisplayClass11_0()
		{
		}
	}

	[Token(Token = "0x20000A4")]
	private sealed class <>c__DisplayClass11_1
	{
		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idx;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass11_0 CS$<>8__locals1;

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x124E3A8", Offset = "0x124E3A8", VA = "0x124E3A8")]
		public <>c__DisplayClass11_1()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x124E3B0", Offset = "0x124E3B0", VA = "0x124E3B0")]
		internal void <SetCallbacks>b__0(bool v)
		{
		}
	}

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Toggle opacityToggle;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Toggle sizeToggle;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Toggle canvasSnapToggle;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button quitButton;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Button clearButton;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button skipButton;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ProtoPaletteResponder palette;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ProtoDurationResponder duration;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Toggle censorToggle;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Toggle> positionButtons;

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x7BED7C", Offset = "0x7BED7C", VA = "0x7BED7C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x7BED9C", Offset = "0x7BED9C", VA = "0x7BED9C")]
	public void SetCallbacks([Optional] UnityAction<bool> opacityToggled, [Optional] UnityAction<bool> sizeToggled, [Optional] UnityAction<bool> snapToggled, [Optional] UnityAction quitPressed, [Optional] UnityAction clearPressed, [Optional] UnityAction<Color> colorChanged, [Optional] UnityAction<float> durationChanged, [Optional] UnityAction skipPressed, [Optional] UnityAction<int> positionChanged, [Optional] UnityAction<bool> censorChanged)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x7BF0AC", Offset = "0x7BF0AC", VA = "0x7BF0AC")]
	public ProtoUIResponder()
	{
	}
}
[Token(Token = "0x20000A5")]
public class SettingsPanelResponder : MonoBehaviour
{
	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TabBarResponder tabBarResponder;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject creditsPanel;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public VRButton creditsButton;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public VRToggle adjustPenToggle;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public VRButton easelOpacityDownButton;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public VRButton easelOpacityUpButton;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshPro easelOpacityValueLabel;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private UnityAction<float> easelOpacityChanged_Cached;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int cachedTransparencyLevel;

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x7C3950", Offset = "0x7C3950", VA = "0x7C3950")]
	private void Awake()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x7C39EC", Offset = "0x7C39EC", VA = "0x7C39EC")]
	private void SetEaselOpacity(int newValue)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x7C3AD0", Offset = "0x7C3AD0", VA = "0x7C3AD0")]
	public void SetCallbacks([Optional] UnityAction<bool> adjustPenToggled, [Optional] UnityAction<float> easelOpacityChanged)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x7C3CD8", Offset = "0x7C3CD8", VA = "0x7C3CD8")]
	public SettingsPanelResponder()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x7C3CE0", Offset = "0x7C3CE0", VA = "0x7C3CE0")]
	private void <Awake>b__9_0()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x7C3E60", Offset = "0x7C3E60", VA = "0x7C3E60")]
	private void <SetCallbacks>b__11_0()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x7C3E6C", Offset = "0x7C3E6C", VA = "0x7C3E6C")]
	private void <SetCallbacks>b__11_1()
	{
	}
}
[Token(Token = "0x20000A6")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F814", Offset = "0x57F814")]
public class TabBarResponder : MonoBehaviour
{
	[Token(Token = "0x20000A7")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TabBarResponder <>4__this;

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x124E840", Offset = "0x124E840", VA = "0x124E840")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x124E848", Offset = "0x124E848", VA = "0x124E848")]
		internal void <Awake>b__0(bool val)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x124E874", Offset = "0x124E874", VA = "0x124E874")]
		internal void <Awake>b__1(bool val)
		{
		}
	}

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private VRToggleGroup toggleGroup;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject extraPanel;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject[] panels;

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x7C6574", Offset = "0x7C6574", VA = "0x7C6574")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x7C3D00", Offset = "0x7C3D00", VA = "0x7C3D00")]
	public void PushExtraPanel(GameObject panel)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x7C6920", Offset = "0x7C6920", VA = "0x7C6920")]
	public void SwitchToPanel(int index)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x7C6AD0", Offset = "0x7C6AD0", VA = "0x7C6AD0")]
	public TabBarResponder()
	{
	}
}
[Token(Token = "0x20000A8")]
public class TimerFill : MonoBehaviour
{
	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private VRRing ring;

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x123F6C4", Offset = "0x123F6C4", VA = "0x123F6C4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x123F83C", Offset = "0x123F83C", VA = "0x123F83C")]
	private void HandleEvent(TimerSecondPassEvent msg)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x123F85C", Offset = "0x123F85C", VA = "0x123F85C")]
	private void HandleEvent(TimerEndEvent msg)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x123F878", Offset = "0x123F878", VA = "0x123F878")]
	public TimerFill()
	{
	}
}
[Token(Token = "0x20000A9")]
public class UIDuration : MonoBehaviour
{
	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float duration;

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x1241844", Offset = "0x1241844", VA = "0x1241844")]
	public UIDuration()
	{
	}
}
[Token(Token = "0x20000AA")]
public class UIResponder : MonoBehaviour
{
	[Token(Token = "0x20000AB")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityAction<int> positionChanged;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UIResponder <>4__this;

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1241F5C", Offset = "0x1241F5C", VA = "0x1241F5C")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x124E8A0", Offset = "0x124E8A0", VA = "0x124E8A0")]
		internal void <SetCallbacks>b__0()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x124E8C0", Offset = "0x124E8C0", VA = "0x124E8C0")]
		internal void <SetCallbacks>b__1()
		{
		}
	}

	[Token(Token = "0x20000AC")]
	private sealed class <>c__DisplayClass25_1
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idx;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass25_0 CS$<>8__locals1;

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1241F64", Offset = "0x1241F64", VA = "0x1241F64")]
		public <>c__DisplayClass25_1()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x124E8E0", Offset = "0x124E8E0", VA = "0x124E8E0")]
		internal void <SetCallbacks>b__2(bool v)
		{
		}
	}

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRToggle opacityToggle;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRToggle sizeToggle;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public VRButton quitButton;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public VRButton clearButton;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public VRButton prevDrawingButton;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public VRButton nextDrawingButton;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public VRButton addDrawingButton;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshPro drawingNumberLabel;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public VRButton skipButton;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public VRToggle censorToggle;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public VRToggle boxModeToggle;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public PaletteResponder palette;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public DurationResponder duration;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ModelSetResponder models;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public FilePanelResponder filePanel;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public CameraPanelResponder cameraPanel;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public SettingsPanelResponder settingsPanel;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public VRButton lazyDownButton;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public VRButton lazyUpButton;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMeshPro lazyText;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<VRToggle> positionButtons;

	[Token(Token = "0x4000356")]
	private const int lazyLevels = 5;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int cachedLazyLevel;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private UnityAction<float> lazybrushLevelChanged_Cached;

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x1241940", Offset = "0x1241940", VA = "0x1241940")]
	private void SetLazyLevel(int newValue)
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x1241A08", Offset = "0x1241A08", VA = "0x1241A08")]
	public void SetCallbacks([Optional] UnityAction<bool> opacityToggled, [Optional] UnityAction<bool> sizeToggled, [Optional] UnityAction<bool> eraserToggled, [Optional] UnityAction quitPressed, [Optional] UnityAction clearPressed, [Optional] UnityAction prevPressed, [Optional] UnityAction nextPressed, [Optional] UnityAction addPressed, [Optional] UnityAction deletePressed, [Optional] UnityAction<Color> colorChanged, [Optional] UnityAction<float> durationChanged, [Optional] UnityAction skipPressed, [Optional] UnityAction<int> positionChanged, [Optional] UnityAction<bool> censorChanged, [Optional] UnityAction<bool> boxModeChanged, [Optional] UnityAction<ModelTable> modelSetChanged, [Optional] UnityAction exportPressed, [Optional] UnityAction<bool> pngAlphaToggled, [Optional] UnityAction explorePressed, [Optional] UnityAction<bool> adjustPenToggled, [Optional] UnityAction<float> easelOpacityChanged, [Optional] UnityAction<float> lazybrushLevelChanged)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x1241F6C", Offset = "0x1241F6C", VA = "0x1241F6C")]
	public void UpdateDrawingNumberLabel(int current, int total)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x124203C", Offset = "0x124203C", VA = "0x124203C")]
	public UIResponder()
	{
	}
}
[Token(Token = "0x20000AD")]
public class ONSPAmbisonicsNative : MonoBehaviour
{
	[Token(Token = "0x20000AE")]
	public enum ovrAmbisonicsNativeStatus
	{
		[Token(Token = "0x4000362")]
		Uninitialized = -1,
		[Token(Token = "0x4000363")]
		NotEnabled,
		[Token(Token = "0x4000364")]
		Success,
		[Token(Token = "0x4000365")]
		StreamError,
		[Token(Token = "0x4000366")]
		ProcessError,
		[Token(Token = "0x4000367")]
		MaxStatValue
	}

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource source;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int numFOAChannels;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int paramAmbiStat;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAmbisonicsNativeStatus currentStatus;

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x12308E4", Offset = "0x12308E4", VA = "0x12308E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x1230B78", Offset = "0x1230B78", VA = "0x1230B78")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x1230DCC", Offset = "0x1230DCC", VA = "0x1230DCC")]
	public ONSPAmbisonicsNative()
	{
	}
}
[Token(Token = "0x20000AF")]
public class ONSPAudioSource : MonoBehaviour
{
	[Token(Token = "0x4000368")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool enableSpatialization;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float gain;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool useInvSqr;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float near;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float far;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float volumetricRadius;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float reverbSend;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool enableRfl;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ONSPAudioSource RoomReflectionGizmoAS;

	[Token(Token = "0x17000017")]
	public bool EnableSpatialization
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1231010", Offset = "0x1231010", VA = "0x1231010")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1231018", Offset = "0x1231018", VA = "0x1231018")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public float Gain
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1231024", Offset = "0x1231024", VA = "0x1231024")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x123102C", Offset = "0x123102C", VA = "0x123102C")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public bool UseInvSqr
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x123105C", Offset = "0x123105C", VA = "0x123105C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1231064", Offset = "0x1231064", VA = "0x1231064")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public float Near
	{
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1231070", Offset = "0x1231070", VA = "0x1231070")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1231078", Offset = "0x1231078", VA = "0x1231078")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public float Far
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x12310AC", Offset = "0x12310AC", VA = "0x12310AC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x12310B4", Offset = "0x12310B4", VA = "0x12310B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public float VolumetricRadius
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x12310E8", Offset = "0x12310E8", VA = "0x12310E8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x12310F0", Offset = "0x12310F0", VA = "0x12310F0")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public float ReverbSend
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1231124", Offset = "0x1231124", VA = "0x1231124")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x123112C", Offset = "0x123112C", VA = "0x123112C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public bool EnableRfl
	{
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1231160", Offset = "0x1231160", VA = "0x1231160")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1231168", Offset = "0x1231168", VA = "0x1231168")]
		set
		{
		}
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x1230E3C", Offset = "0x1230E3C", VA = "0x1230E3C")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x58064C", Offset = "0x58064C")]
	private static void OnBeforeSceneLoadRuntimeMethod()
	{
	}

	[PreserveSig]
	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x1230F30", Offset = "0x1230F30", VA = "0x1230F30")]
	private static extern void ONSP_GetGlobalRoomReflectionValues(ref bool reflOn, ref bool reverbOn, ref float width, ref float height, ref float length);

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x1231174", Offset = "0x1231174", VA = "0x1231174")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x12312E4", Offset = "0x12312E4", VA = "0x12312E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x12312E8", Offset = "0x12312E8", VA = "0x12312E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x12311DC", Offset = "0x12311DC", VA = "0x12311DC")]
	public void SetParameters(ref AudioSource source)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x12313AC", Offset = "0x12313AC", VA = "0x12313AC")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x12317A4", Offset = "0x12317A4", VA = "0x12317A4")]
	private void OnDestroy()
	{
	}

	[PreserveSig]
	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x1230EB0", Offset = "0x1230EB0", VA = "0x1230EB0")]
	private static extern int OSP_SetGlobalVoiceLimit(int VoiceLimit);

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x1231890", Offset = "0x1231890", VA = "0x1231890")]
	public ONSPAudioSource()
	{
	}
}
[Token(Token = "0x20000B0")]
public class ONSPProfiler : MonoBehaviour
{
	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool profilerEnabled;

	[Token(Token = "0x4000373")]
	private const int DEFAULT_PORT = 2121;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int port;

	[Token(Token = "0x4000375")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x12318B0", Offset = "0x12318B0", VA = "0x12318B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x12318BC", Offset = "0x12318BC", VA = "0x12318BC")]
	private void Update()
	{
	}

	[PreserveSig]
	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x1231974", Offset = "0x1231974", VA = "0x1231974")]
	private static extern int ONSP_SetProfilerEnabled(bool enabled);

	[PreserveSig]
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x12318F4", Offset = "0x12318F4", VA = "0x12318F4")]
	private static extern int ONSP_SetProfilerPort(int port);

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x12319F4", Offset = "0x12319F4", VA = "0x12319F4")]
	public ONSPProfiler()
	{
	}
}
[Token(Token = "0x20000B1")]
public class ONSPPropagationGeometry : MonoBehaviour
{
	[Token(Token = "0x20000B2")]
	private struct MeshMaterial
	{
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MeshFilter meshFilter;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ONSPPropagationMaterial[] materials;
	}

	[Token(Token = "0x20000B3")]
	private struct TerrainMaterial
	{
		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Terrain terrain;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ONSPPropagationMaterial[] materials;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh[] treePrototypeMeshes;
	}

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string GeometryAssetDirectory;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string filePathRelative;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool fileEnabled;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool includeChildMeshes;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IntPtr geometryHandle;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int OSPSuccess;

	[Token(Token = "0x400037C")]
	public const string GEOMETRY_FILE_EXTENSION = "ovramesh";

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int terrainDecimation;

	[Token(Token = "0x1700001F")]
	public static string GeometryAssetPath
	{
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1231D04", Offset = "0x1231D04", VA = "0x1231D04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000020")]
	public string filePath
	{
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1231D98", Offset = "0x1231D98", VA = "0x1231D98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x1231E18", Offset = "0x1231E18", VA = "0x1231E18")]
	private static string GetPath(Transform current)
	{
		return null;
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x1231F80", Offset = "0x1231F80", VA = "0x1231F80")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x1231F84", Offset = "0x1231F84", VA = "0x1231F84")]
	private void CreatePropagationGeometry()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x123255C", Offset = "0x123255C", VA = "0x123255C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x1232908", Offset = "0x1232908", VA = "0x1232908")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x1232A84", Offset = "0x1232A84", VA = "0x1232A84")]
	private static void traverseMeshHierarchy(GameObject obj, ONSPPropagationMaterial[] currentMaterials, bool includeChildren, List<MeshMaterial> meshMaterials, List<TerrainMaterial> terrainMaterials, bool ignoreStatic, ref int ignoredMeshCount)
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x12333EC", Offset = "0x12333EC", VA = "0x12333EC")]
	private int uploadMesh(IntPtr geometryHandle, GameObject meshObject, Matrix4x4 worldToLocal)
	{
		return default(int);
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x1233428", Offset = "0x1233428", VA = "0x1233428")]
	private int uploadMesh(IntPtr geometryHandle, GameObject meshObject, Matrix4x4 worldToLocal, bool ignoreStatic, ref int ignoredMeshCount)
	{
		return default(int);
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x1234CF0", Offset = "0x1234CF0", VA = "0x1234CF0")]
	private static void uploadMeshFilter(List<Vector3> tempVertices, List<int> tempIndices, MeshGroup[] groups, float[] vertices, int[] indices, ref int vertexOffset, ref int indexOffset, ref int groupOffset, Mesh mesh, ONSPPropagationMaterial[] materials, Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x1234A34", Offset = "0x1234A34", VA = "0x1234A34")]
	private static void updateCountsForMesh(ref int totalVertexCount, ref uint totalIndexCount, ref int totalFaceCount, ref int totalMaterialCount, Mesh mesh)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x1232374", Offset = "0x1232374", VA = "0x1232374")]
	public void UploadGeometry()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x123217C", Offset = "0x123217C", VA = "0x123217C")]
	public bool ReadFile()
	{
		return default(bool);
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x1235378", Offset = "0x1235378", VA = "0x1235378")]
	public bool WriteToObj()
	{
		return default(bool);
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x1235810", Offset = "0x1235810", VA = "0x1235810")]
	public ONSPPropagationGeometry()
	{
	}
}
[Token(Token = "0x20000B4")]
internal class ONSPPropagation
{
	[Token(Token = "0x20000B5")]
	public enum ovrAudioScalarType : uint
	{
		[Token(Token = "0x4000385")]
		Int8,
		[Token(Token = "0x4000386")]
		UInt8,
		[Token(Token = "0x4000387")]
		Int16,
		[Token(Token = "0x4000388")]
		UInt16,
		[Token(Token = "0x4000389")]
		Int32,
		[Token(Token = "0x400038A")]
		UInt32,
		[Token(Token = "0x400038B")]
		Int64,
		[Token(Token = "0x400038C")]
		UInt64,
		[Token(Token = "0x400038D")]
		Float16,
		[Token(Token = "0x400038E")]
		Float32,
		[Token(Token = "0x400038F")]
		Float64
	}

	[Token(Token = "0x20000B6")]
	public interface PropagationInterface
	{
		[Token(Token = "0x60002EF")]
		int SetPropagationQuality(float quality);

		[Token(Token = "0x60002F0")]
		int CreateAudioGeometry(out IntPtr geometry);

		[Token(Token = "0x60002F1")]
		int DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x60002F2")]
		int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount);

		[Token(Token = "0x60002F3")]
		int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x60002F4")]
		int AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60002F5")]
		int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x60002F6")]
		int CreateAudioMaterial(out IntPtr material);

		[Token(Token = "0x60002F7")]
		int DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x60002F8")]
		int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x60002F9")]
		int AudioMaterialReset(IntPtr material, MaterialProperty property);
	}

	[Token(Token = "0x20000B7")]
	public class UnityNativeInterface : PropagationInterface
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x17000022")]
		private IntPtr context
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x124B4DC", Offset = "0x124B4DC", VA = "0x124B4DC")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x124B53C", Offset = "0x124B53C", VA = "0x124B53C")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x124B5CC", Offset = "0x124B5CC", VA = "0x124B5CC")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x124B65C", Offset = "0x124B65C", VA = "0x124B65C", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x124B680", Offset = "0x124B680", VA = "0x124B680")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x124B70C", Offset = "0x124B70C", VA = "0x124B70C", Slot = "5")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x124B730", Offset = "0x124B730", VA = "0x124B730")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x124B7B0", Offset = "0x124B7B0", VA = "0x124B7B0", Slot = "6")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x124B7B8", Offset = "0x124B7B8", VA = "0x124B7B8")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x124B8D8", Offset = "0x124B8D8", VA = "0x124B8D8", Slot = "7")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x124B9CC", Offset = "0x124B9CC", VA = "0x124B9CC")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x124BA64", Offset = "0x124BA64", VA = "0x124BA64", Slot = "8")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x124BA70", Offset = "0x124BA70", VA = "0x124BA70")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x124BB1C", Offset = "0x124BB1C", VA = "0x124BB1C", Slot = "9")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x124BB28", Offset = "0x124BB28", VA = "0x124BB28")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x124BBD4", Offset = "0x124BBD4", VA = "0x124BBD4", Slot = "10")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x124BBE0", Offset = "0x124BBE0", VA = "0x124BBE0")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x124BC6C", Offset = "0x124BC6C", VA = "0x124BC6C", Slot = "11")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x124BC90", Offset = "0x124BC90", VA = "0x124BC90")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x124BD10", Offset = "0x124BD10", VA = "0x124BD10", Slot = "12")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x124BD18", Offset = "0x124BD18", VA = "0x124BD18")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x124BDC0", Offset = "0x124BDC0", VA = "0x124BDC0", Slot = "13")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x124BDCC", Offset = "0x124BDCC", VA = "0x124BDCC")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x124BE5C", Offset = "0x124BE5C", VA = "0x124BE5C", Slot = "14")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x124BE68", Offset = "0x124BE68", VA = "0x124BE68")]
		public UnityNativeInterface()
		{
		}
	}

	[Token(Token = "0x20000B8")]
	public class WwisePluginInterface : PropagationInterface
	{
		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x17000023")]
		private IntPtr context
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x124BEB0", Offset = "0x124BEB0", VA = "0x124BEB0")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x124BF10", Offset = "0x124BF10", VA = "0x124BF10")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x124BFA0", Offset = "0x124BFA0", VA = "0x124BFA0")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x124C030", Offset = "0x124C030", VA = "0x124C030", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x124C054", Offset = "0x124C054", VA = "0x124C054")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x124C0E4", Offset = "0x124C0E4", VA = "0x124C0E4", Slot = "5")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x124C108", Offset = "0x124C108", VA = "0x124C108")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x124C188", Offset = "0x124C188", VA = "0x124C188", Slot = "6")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x124C190", Offset = "0x124C190", VA = "0x124C190")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x124C2B0", Offset = "0x124C2B0", VA = "0x124C2B0", Slot = "7")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x124C3A4", Offset = "0x124C3A4", VA = "0x124C3A4")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x124C43C", Offset = "0x124C43C", VA = "0x124C43C", Slot = "8")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x124C448", Offset = "0x124C448", VA = "0x124C448")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x124C4F4", Offset = "0x124C4F4", VA = "0x124C4F4", Slot = "9")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x124C500", Offset = "0x124C500", VA = "0x124C500")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x124C5AC", Offset = "0x124C5AC", VA = "0x124C5AC", Slot = "10")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x124C5B8", Offset = "0x124C5B8", VA = "0x124C5B8")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x124C648", Offset = "0x124C648", VA = "0x124C648", Slot = "11")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x124C66C", Offset = "0x124C66C", VA = "0x124C66C")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x124C6EC", Offset = "0x124C6EC", VA = "0x124C6EC", Slot = "12")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x124C6F4", Offset = "0x124C6F4", VA = "0x124C6F4")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x124C79C", Offset = "0x124C79C", VA = "0x124C79C", Slot = "13")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x124C7A8", Offset = "0x124C7A8", VA = "0x124C7A8")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x124C838", Offset = "0x124C838", VA = "0x124C838", Slot = "14")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x124C844", Offset = "0x124C844", VA = "0x124C844")]
		public WwisePluginInterface()
		{
		}
	}

	[Token(Token = "0x20000B9")]
	public class FMODPluginInterface : PropagationInterface
	{
		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x17000024")]
		private IntPtr context
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x124AB00", Offset = "0x124AB00", VA = "0x124AB00")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x124AB60", Offset = "0x124AB60", VA = "0x124AB60")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x124ABF0", Offset = "0x124ABF0", VA = "0x124ABF0")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x124AC80", Offset = "0x124AC80", VA = "0x124AC80", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x124ACA4", Offset = "0x124ACA4", VA = "0x124ACA4")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x124AD34", Offset = "0x124AD34", VA = "0x124AD34", Slot = "5")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x124AD58", Offset = "0x124AD58", VA = "0x124AD58")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x124ADD8", Offset = "0x124ADD8", VA = "0x124ADD8", Slot = "6")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x124ADE0", Offset = "0x124ADE0", VA = "0x124ADE0")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x124AF00", Offset = "0x124AF00", VA = "0x124AF00", Slot = "7")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x124AFF4", Offset = "0x124AFF4", VA = "0x124AFF4")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x124B08C", Offset = "0x124B08C", VA = "0x124B08C", Slot = "8")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x124B098", Offset = "0x124B098", VA = "0x124B098")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x124B144", Offset = "0x124B144", VA = "0x124B144", Slot = "9")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x124B150", Offset = "0x124B150", VA = "0x124B150")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x124B1FC", Offset = "0x124B1FC", VA = "0x124B1FC", Slot = "10")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x124B208", Offset = "0x124B208", VA = "0x124B208")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x124B298", Offset = "0x124B298", VA = "0x124B298", Slot = "11")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x124B2BC", Offset = "0x124B2BC", VA = "0x124B2BC")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x124B33C", Offset = "0x124B33C", VA = "0x124B33C", Slot = "12")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x124B344", Offset = "0x124B344", VA = "0x124B344")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x124B3EC", Offset = "0x124B3EC", VA = "0x124B3EC", Slot = "13")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x124B3F8", Offset = "0x124B3F8", VA = "0x124B3F8")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x124B488", Offset = "0x124B488", VA = "0x124B488", Slot = "14")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x124B494", Offset = "0x124B494", VA = "0x124B494")]
		public FMODPluginInterface()
		{
		}
	}

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PropagationInterface CachedInterface;

	[Token(Token = "0x17000021")]
	public static PropagationInterface Interface
	{
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1231A04", Offset = "0x1231A04", VA = "0x1231A04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x1231A7C", Offset = "0x1231A7C", VA = "0x1231A7C")]
	private static PropagationInterface FindInterface()
	{
		return null;
	}
}
[Token(Token = "0x20000BA")]
public sealed class ONSPPropagationMaterial : MonoBehaviour
{
	[Token(Token = "0x20000BB")]
	public enum Preset
	{
		[Token(Token = "0x4000399")]
		Custom,
		[Token(Token = "0x400039A")]
		AcousticTile,
		[Token(Token = "0x400039B")]
		Brick,
		[Token(Token = "0x400039C")]
		BrickPainted,
		[Token(Token = "0x400039D")]
		Carpet,
		[Token(Token = "0x400039E")]
		CarpetHeavy,
		[Token(Token = "0x400039F")]
		CarpetHeavyPadded,
		[Token(Token = "0x40003A0")]
		CeramicTile,
		[Token(Token = "0x40003A1")]
		Concrete,
		[Token(Token = "0x40003A2")]
		ConcreteRough,
		[Token(Token = "0x40003A3")]
		ConcreteBlock,
		[Token(Token = "0x40003A4")]
		ConcreteBlockPainted,
		[Token(Token = "0x40003A5")]
		Curtain,
		[Token(Token = "0x40003A6")]
		Foliage,
		[Token(Token = "0x40003A7")]
		Glass,
		[Token(Token = "0x40003A8")]
		GlassHeavy,
		[Token(Token = "0x40003A9")]
		Grass,
		[Token(Token = "0x40003AA")]
		Gravel,
		[Token(Token = "0x40003AB")]
		GypsumBoard,
		[Token(Token = "0x40003AC")]
		PlasterOnBrick,
		[Token(Token = "0x40003AD")]
		PlasterOnConcreteBlock,
		[Token(Token = "0x40003AE")]
		Soil,
		[Token(Token = "0x40003AF")]
		SoundProof,
		[Token(Token = "0x40003B0")]
		Snow,
		[Token(Token = "0x40003B1")]
		Steel,
		[Token(Token = "0x40003B2")]
		Water,
		[Token(Token = "0x40003B3")]
		WoodThin,
		[Token(Token = "0x40003B4")]
		WoodThick,
		[Token(Token = "0x40003B5")]
		WoodFloor,
		[Token(Token = "0x40003B6")]
		WoodOnConcrete
	}

	[Serializable]
	[Token(Token = "0x20000BC")]
	public sealed class Point
	{
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float frequency;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float data;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x124C88C", Offset = "0x124C88C", VA = "0x124C88C")]
		public Point(float frequency = 0f, float data = 0f)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x57F874", Offset = "0x57F874")]
	public sealed class Spectrum
	{
		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int selection;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Point> points;

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x124C8C4", Offset = "0x124C8C4", VA = "0x124C8C4")]
		public Spectrum()
		{
		}
	}

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr materialHandle;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Spectrum absorption;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Spectrum transmission;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Spectrum scattering;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Preset preset_;

	[Token(Token = "0x17000025")]
	public Preset preset
	{
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1235904", Offset = "0x1235904", VA = "0x1235904")]
		get
		{
			return default(Preset);
		}
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x123590C", Offset = "0x123590C", VA = "0x123590C")]
		set
		{
		}
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x1235934", Offset = "0x1235934", VA = "0x1235934")]
	private void Start()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x12351EC", Offset = "0x12351EC", VA = "0x12351EC")]
	public void StartInternal()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x1235FA4", Offset = "0x1235FA4", VA = "0x1235FA4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x1235FA8", Offset = "0x1235FA8", VA = "0x1235FA8")]
	public void DestroyInternal()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x1235938", Offset = "0x1235938", VA = "0x1235938")]
	public void UploadMaterial()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x1234B5C", Offset = "0x1234B5C", VA = "0x1234B5C")]
	public void SetPreset(Preset preset)
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x1236094", Offset = "0x1236094", VA = "0x1236094")]
	private static void AcousticTile(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x1236574", Offset = "0x1236574", VA = "0x1236574")]
	private static void Brick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x1236A58", Offset = "0x1236A58", VA = "0x1236A58")]
	private static void BrickPainted(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x1236F38", Offset = "0x1236F38", VA = "0x1236F38")]
	private static void Carpet(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x123742C", Offset = "0x123742C", VA = "0x123742C")]
	private static void CarpetHeavy(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x123790C", Offset = "0x123790C", VA = "0x123790C")]
	private static void CarpetHeavyPadded(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x1237DEC", Offset = "0x1237DEC", VA = "0x1237DEC")]
	private static void CeramicTile(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x12382D4", Offset = "0x12382D4", VA = "0x12382D4")]
	private static void Concrete(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x12387BC", Offset = "0x12387BC", VA = "0x12387BC")]
	private static void ConcreteRough(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x1238CA8", Offset = "0x1238CA8", VA = "0x1238CA8")]
	private static void ConcreteBlock(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x1239190", Offset = "0x1239190", VA = "0x1239190")]
	private static void ConcreteBlockPainted(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x1239680", Offset = "0x1239680", VA = "0x1239680")]
	private static void Curtain(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x1239B60", Offset = "0x1239B60", VA = "0x1239B60")]
	private static void Foliage(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x123A054", Offset = "0x123A054", VA = "0x123A054")]
	private static void Glass(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x123A524", Offset = "0x123A524", VA = "0x123A524")]
	private static void GlassHeavy(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x123AA00", Offset = "0x123AA00", VA = "0x123AA00")]
	private static void Grass(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x123ADC8", Offset = "0x123ADC8", VA = "0x123ADC8")]
	private static void Gravel(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x123B188", Offset = "0x123B188", VA = "0x123B188")]
	private static void GypsumBoard(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x123B678", Offset = "0x123B678", VA = "0x123B678")]
	private static void PlasterOnBrick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x123BB64", Offset = "0x123BB64", VA = "0x123BB64")]
	private static void PlasterOnConcreteBlock(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x123C048", Offset = "0x123C048", VA = "0x123C048")]
	private static void Soil(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x123C414", Offset = "0x123C414", VA = "0x123C414")]
	private static void SoundProof(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x123C5B8", Offset = "0x123C5B8", VA = "0x123C5B8")]
	private static void Snow(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x123C974", Offset = "0x123C974", VA = "0x123C974")]
	private static void Steel(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x123CE44", Offset = "0x123CE44", VA = "0x123CE44")]
	private static void Water(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x123D328", Offset = "0x123D328", VA = "0x123D328")]
	private static void WoodThin(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x123D800", Offset = "0x123D800", VA = "0x123D800")]
	private static void WoodThick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x123DCE0", Offset = "0x123DCE0", VA = "0x123DCE0")]
	private static void WoodFloor(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x123E1C8", Offset = "0x123E1C8", VA = "0x123E1C8")]
	private static void WoodOnConcrete(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x123E6AC", Offset = "0x123E6AC", VA = "0x123E6AC")]
	public ONSPPropagationMaterial()
	{
	}
}
[Token(Token = "0x20000BE")]
public class ONSPPropagationSettings : MonoBehaviour
{
	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float quality;

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x7B41B4", Offset = "0x7B41B4", VA = "0x7B41B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x7B4284", Offset = "0x7B4284", VA = "0x7B4284")]
	public ONSPPropagationSettings()
	{
	}
}
[Token(Token = "0x20000BF")]
public sealed class ONSPSettings : ScriptableObject
{
	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int voiceLimit;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ONSPSettings instance;

	[Token(Token = "0x17000026")]
	public static ONSPSettings Instance
	{
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x7B48D4", Offset = "0x7B48D4", VA = "0x7B48D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x7B4A2C", Offset = "0x7B4A2C", VA = "0x7B4A2C")]
	public ONSPSettings()
	{
	}
}
[Token(Token = "0x20000C0")]
public class ONSPVersion : MonoBehaviour
{
	[Token(Token = "0x40003BE")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[PreserveSig]
	[Token(Token = "0x6000371")]
	[Address(RVA = "0x7B4A3C", Offset = "0x7B4A3C", VA = "0x7B4A3C")]
	private static extern void ONSP_GetVersion(ref int Major, ref int Minor, ref int Patch);

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x7B4AD4", Offset = "0x7B4AD4", VA = "0x7B4AD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x7B4BF4", Offset = "0x7B4BF4", VA = "0x7B4BF4")]
	public ONSPVersion()
	{
	}
}
[Token(Token = "0x20000C1")]
public class OculusSpatializerUnity : MonoBehaviour
{
	[Token(Token = "0x20000C2")]
	public delegate void AudioRaycastCallback(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data);

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LayerMask layerMask;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool visualizeRoom;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	private bool roomVisualizationInitialized;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int raysPerSecond;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float roomInterpSpeed;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maxWallDistance;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int rayCacheSize;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool dynamicReflectionsEnabled;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float particleSize;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float particleOffset;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject room;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Renderer[] wallRenderer;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float[] dims;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float[] coefs;

	[Token(Token = "0x40003CD")]
	private const int HIT_COUNT = 2048;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] points;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] normals;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ParticleSystem sys;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LayerMask gLayerMask;

	[Token(Token = "0x40003D3")]
	private const string strOSP = "AudioPluginOculusSpatializer";

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x7B4E84", Offset = "0x7B4E84", VA = "0x7B4E84")]
	private static Vector3 swapHandedness(Vector3 vec)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x7B4D14", Offset = "0x7B4D14", VA = "0x7B4D14")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x580660", Offset = "0x580660")]
	private static void AudioRaycast(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data)
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x7B4E8C", Offset = "0x7B4E8C", VA = "0x7B4E8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x7B4FD0", Offset = "0x7B4FD0", VA = "0x7B4FD0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x7B50CC", Offset = "0x7B50CC", VA = "0x7B50CC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x7B59E8", Offset = "0x7B59E8", VA = "0x7B59E8")]
	private void inititalizeRoomVisualization()
	{
	}

	[PreserveSig]
	[Token(Token = "0x600037A")]
	[Address(RVA = "0x7B4F3C", Offset = "0x7B4F3C", VA = "0x7B4F3C")]
	private static extern int OSP_Unity_AssignRaycastCallback(AudioRaycastCallback callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x600037B")]
	[Address(RVA = "0x7B503C", Offset = "0x7B503C", VA = "0x7B503C")]
	private static extern int OSP_Unity_AssignRaycastCallback(IntPtr callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x600037C")]
	[Address(RVA = "0x7B5750", Offset = "0x7B5750", VA = "0x7B5750")]
	private static extern int OSP_Unity_SetDynamicRoomRaysPerSecond(int RaysPerSecond);

	[PreserveSig]
	[Token(Token = "0x600037D")]
	[Address(RVA = "0x7B57D0", Offset = "0x7B57D0", VA = "0x7B57D0")]
	private static extern int OSP_Unity_SetDynamicRoomInterpSpeed(float InterpSpeed);

	[PreserveSig]
	[Token(Token = "0x600037E")]
	[Address(RVA = "0x7B5858", Offset = "0x7B5858", VA = "0x7B5858")]
	private static extern int OSP_Unity_SetDynamicRoomMaxWallDistance(float MaxWallDistance);

	[PreserveSig]
	[Token(Token = "0x600037F")]
	[Address(RVA = "0x7B58E0", Offset = "0x7B58E0", VA = "0x7B58E0")]
	private static extern int OSP_Unity_SetDynamicRoomRaysRayCacheSize(int RayCacheSize);

	[PreserveSig]
	[Token(Token = "0x6000380")]
	[Address(RVA = "0x7B5960", Offset = "0x7B5960", VA = "0x7B5960")]
	private static extern int OSP_Unity_UpdateRoomModel(float wetLevel);

	[PreserveSig]
	[Token(Token = "0x6000381")]
	[Address(RVA = "0x7B66E8", Offset = "0x7B66E8", VA = "0x7B66E8")]
	private static extern int OSP_Unity_GetRoomDimensions(float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position);

	[PreserveSig]
	[Token(Token = "0x6000382")]
	[Address(RVA = "0x7B6790", Offset = "0x7B6790", VA = "0x7B6790")]
	private static extern int OSP_Unity_GetRaycastHits(Vector3[] points, Vector3[] normals, int length);

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x7B6838", Offset = "0x7B6838", VA = "0x7B6838")]
	public OculusSpatializerUnity()
	{
	}
}
[Token(Token = "0x20000C3")]
public struct ReflectionSnapshot
{
	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public AudioMixerSnapshot mixerSnapshot;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float fadeTime;
}
[Token(Token = "0x20000C4")]
public class ONSPReflectionZone : MonoBehaviour
{
	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioMixerSnapshot mixerSnapshot;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fadeTime;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Stack<ReflectionSnapshot> snapshotList;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ReflectionSnapshot currentSnapshot;

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x7B4294", Offset = "0x7B4294", VA = "0x7B4294")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x7B440C", Offset = "0x7B440C", VA = "0x7B440C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x7B42E0", Offset = "0x7B42E0", VA = "0x7B42E0")]
	private bool CheckForAudioListener(GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x7B4378", Offset = "0x7B4378", VA = "0x7B4378")]
	private void PushCurrentMixerShapshot()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x7B4458", Offset = "0x7B4458", VA = "0x7B4458")]
	private void PopCurrentMixerSnapshot()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x7B44F8", Offset = "0x7B44F8", VA = "0x7B44F8")]
	private void SetReflectionValues()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x7B4694", Offset = "0x7B4694", VA = "0x7B4694")]
	private void SetReflectionValues(ref ReflectionSnapshot mss)
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x7B4830", Offset = "0x7B4830", VA = "0x7B4830")]
	public ONSPReflectionZone()
	{
	}
}
[Token(Token = "0x20000C5")]
public static class AppSettingsExtensions
{
	[Token(Token = "0x6000392")]
	[Address(RVA = "0x1211A74", Offset = "0x1211A74", VA = "0x1211A74")]
	public static ChatAppSettings GetChatSettings(AppSettings appSettings)
	{
		return null;
	}
}
[Token(Token = "0x20000C6")]
public class ChannelSelector : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string Channel;

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x1219658", Offset = "0x1219658", VA = "0x1219658")]
	public void SetChannel(string channel)
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x12196E0", Offset = "0x12196E0", VA = "0x12196E0", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x12199F0", Offset = "0x12199F0", VA = "0x12199F0")]
	public ChannelSelector()
	{
	}
}
[Token(Token = "0x20000C7")]
[ExecuteInEditMode]
public class ChatAppIdCheckerUI : MonoBehaviour
{
	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text Description;

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x121A854", Offset = "0x121A854", VA = "0x121A854")]
	public void Update()
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x121A9B8", Offset = "0x121A9B8", VA = "0x121A9B8")]
	public ChatAppIdCheckerUI()
	{
	}
}
[Token(Token = "0x20000C8")]
public class ChatGui : MonoBehaviour, IChatClientListener
{
	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string[] ChannelsToJoinOnConnect;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] FriendsList;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int HistoryLengthToFetch;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string <UserName>k__BackingField;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string selectedChannelName;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ChatClient chatClient;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected internal ChatAppSettings chatAppSettings;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject missingAppIdErrorPanel;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject ConnectingLabel;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RectTransform ChatPanel;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject UserIdFormPanel;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public InputField InputFieldChat;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Text CurrentChannelText;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Toggle ChannelToggleToInstantiate;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject FriendListUiItemtoInstantiate;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Dictionary<string, Toggle> channelToggles;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly Dictionary<string, FriendItem> friendListItemLUT;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool ShowState;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject Title;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Text StateText;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Text UserIdText;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string HelpText;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public int TestLength;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private byte[] testBytes;

	[Token(Token = "0x17000027")]
	public string UserName
	{
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x121A9C0", Offset = "0x121A9C0", VA = "0x121A9C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x121A9C8", Offset = "0x121A9C8", VA = "0x121A9C8")]
		set
		{
		}
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x121A9D0", Offset = "0x121A9D0", VA = "0x121A9D0")]
	public void Start()
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x121ACB0", Offset = "0x121ACB0", VA = "0x121ACB0")]
	public void Connect()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x121AE58", Offset = "0x121AE58", VA = "0x121AE58")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x121AE70", Offset = "0x121AE70", VA = "0x121AE70")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x121AE88", Offset = "0x121AE88", VA = "0x121AE88")]
	public void Update()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x121AF78", Offset = "0x121AF78", VA = "0x121AF78")]
	public void OnEnterSend()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x121BA0C", Offset = "0x121BA0C", VA = "0x121BA0C")]
	public void OnClickSend()
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x121B010", Offset = "0x121B010", VA = "0x121B010")]
	private void SendChatMessage(string inputLine)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x121BAC8", Offset = "0x121BAC8", VA = "0x121BAC8")]
	public void PostHelpToCurrentChannel()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x121BB80", Offset = "0x121BB80", VA = "0x121BB80", Slot = "4")]
	public void DebugReturn(DebugLevel level, string message)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x121BC64", Offset = "0x121BC64", VA = "0x121BC64", Slot = "6")]
	public void OnConnected()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x121BFC8", Offset = "0x121BFC8", VA = "0x121BFC8", Slot = "5")]
	public void OnDisconnected()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x121BFE8", Offset = "0x121BFE8", VA = "0x121BFE8", Slot = "7")]
	public void OnChatStateChange(ChatState state)
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x121C090", Offset = "0x121C090", VA = "0x121C090", Slot = "10")]
	public void OnSubscribed(string[] channels, bool[] results)
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x121C410", Offset = "0x121C410", VA = "0x121C410")]
	public void OnSubscribed(string channel, string[] users, Dictionary<object, object> properties)
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x121C240", Offset = "0x121C240", VA = "0x121C240")]
	private void InstantiateChannelButton(string channelName)
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x121BE74", Offset = "0x121BE74", VA = "0x121BE74")]
	private void InstantiateFriendButton(string friendId)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x121C5F0", Offset = "0x121C5F0", VA = "0x121C5F0", Slot = "11")]
	public void OnUnsubscribed(string[] channels)
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x121CA70", Offset = "0x121CA70", VA = "0x121CA70", Slot = "8")]
	public void OnGetMessages(string channelName, string[] senders, object[] messages)
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x121CAC0", Offset = "0x121CAC0", VA = "0x121CAC0", Slot = "9")]
	public void OnPrivateMessage(string sender, object message, string channelName)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x121CBE0", Offset = "0x121CBE0", VA = "0x121CBE0", Slot = "12")]
	public void OnStatusUpdate(string user, int status, bool gotMessage, object message)
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x121CDB0", Offset = "0x121CDB0", VA = "0x121CDB0", Slot = "13")]
	public void OnUserSubscribed(string channel, string user)
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x121CEE0", Offset = "0x121CEE0", VA = "0x121CEE0", Slot = "14")]
	public void OnUserUnsubscribed(string channel, string user)
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x121D010", Offset = "0x121D010", VA = "0x121D010")]
	public void OnChannelPropertiesChanged(string channel, string userId, Dictionary<object, object> properties)
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x121D1B4", Offset = "0x121D1B4", VA = "0x121D1B4")]
	public void OnUserPropertiesChanged(string channel, string targetUserId, string senderUserId, Dictionary<object, object> properties)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x121D398", Offset = "0x121D398", VA = "0x121D398")]
	public void OnErrorInfo(string channel, string error, object data)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x121D500", Offset = "0x121D500", VA = "0x121D500")]
	public void AddMessageToSelectedChannel(string msg)
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x1219764", Offset = "0x1219764", VA = "0x1219764")]
	public void ShowChannel(string channelName)
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x121D5F8", Offset = "0x121D5F8", VA = "0x121D5F8")]
	public void OpenDashboard()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x121D640", Offset = "0x121D640", VA = "0x121D640")]
	public ChatGui()
	{
	}
}
[Token(Token = "0x20000C9")]
public class FriendItem : MonoBehaviour
{
	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text NameLabel;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text StatusLabel;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text Health;

	[Token(Token = "0x17000028")]
	public string FriendId
	{
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1228008", Offset = "0x1228008", VA = "0x1228008")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1227FE4", Offset = "0x1227FE4", VA = "0x1227FE4")]
		set
		{
		}
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x122802C", Offset = "0x122802C", VA = "0x122802C")]
	public void Awake()
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x1228094", Offset = "0x1228094", VA = "0x1228094")]
	public void OnFriendStatusUpdate(int status, bool gotMessage, object message)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x1228224", Offset = "0x1228224", VA = "0x1228224")]
	public FriendItem()
	{
	}
}
[Token(Token = "0x20000CA")]
public class IgnoreUiRaycastWhenInactive : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x122BE94", Offset = "0x122BE94", VA = "0x122BE94", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x122BEB8", Offset = "0x122BEB8", VA = "0x122BEB8")]
	public IgnoreUiRaycastWhenInactive()
	{
	}
}
[Token(Token = "0x20000CB")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F8BC", Offset = "0x57F8BC")]
public class NamePickGui : MonoBehaviour
{
	[Token(Token = "0x40003F7")]
	private const string UserNamePlayerPref = "NamePickUserName";

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ChatGui chatNewComponent;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public InputField idInput;

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x122FD30", Offset = "0x122FD30", VA = "0x122FD30")]
	public void Start()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x122FE08", Offset = "0x122FE08", VA = "0x122FE08")]
	public void EndEditOnEnter()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x122FE54", Offset = "0x122FE54", VA = "0x122FE54")]
	public void StartChat()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x122FF48", Offset = "0x122FF48", VA = "0x122FF48")]
	public NamePickGui()
	{
	}
}
[Token(Token = "0x20000CC")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F91C", Offset = "0x57F91C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F91C", Offset = "0x57F91C")]
public class ChangeColor : MonoBehaviour
{
	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PhotonView photonView;

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x121867C", Offset = "0x121867C", VA = "0x121867C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x12187F8", Offset = "0x12187F8", VA = "0x12187F8")]
	[PunRPC]
	private void ChangeColour(Vector3 randomColor)
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x12188CC", Offset = "0x12188CC", VA = "0x12188CC")]
	public ChangeColor()
	{
	}
}
[Token(Token = "0x20000CD")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57F9B0", Offset = "0x57F9B0")]
public class ChangeName : MonoBehaviour
{
	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x1218BCC", Offset = "0x1218BCC", VA = "0x1218BCC")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x1218C8C", Offset = "0x1218C8C", VA = "0x1218C8C")]
	public ChangeName()
	{
	}
}
[Token(Token = "0x20000CE")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57FA10", Offset = "0x57FA10")]
public class PointersController : MonoBehaviour
{
	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject pointerDown;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject pointerUp;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private PhotonVoiceView photonVoiceView;

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x7BC984", Offset = "0x7BC984", VA = "0x7BC984")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x7BCAAC", Offset = "0x7BCAAC", VA = "0x7BCAAC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x7BC9F8", Offset = "0x7BC9F8", VA = "0x7BC9F8")]
	private void SetActiveSafe(GameObject go, bool active)
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x7BCB08", Offset = "0x7BCB08", VA = "0x7BCB08")]
	public PointersController()
	{
	}
}
[Token(Token = "0x20000CF")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57FA70", Offset = "0x57FA70")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x57FA70", Offset = "0x57FA70")]
public class ProximityVoiceTrigger : VoiceComponent
{
	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<byte> groupsToAdd;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<byte> groupsToRemove;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private byte[] subscribedGroups;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PhotonVoiceView photonVoiceView;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private PhotonView photonView;

	[Token(Token = "0x17000029")]
	public byte TargetInterestGroup
	{
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x7BF130", Offset = "0x7BF130", VA = "0x7BF130")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x7BF1BC", Offset = "0x7BF1BC", VA = "0x7BF1BC", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x7BF418", Offset = "0x7BF418", VA = "0x7BF418")]
	private void ToggleTransmission()
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x7BF734", Offset = "0x7BF734", VA = "0x7BF734")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x7BF968", Offset = "0x7BF968", VA = "0x7BF968")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x7BFBDC", Offset = "0x7BFBDC", VA = "0x7BFBDC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x7BF284", Offset = "0x7BF284", VA = "0x7BF284")]
	private bool IsLocalCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x7C02AC", Offset = "0x7C02AC", VA = "0x7C02AC")]
	public ProximityVoiceTrigger()
	{
	}
}
[Serializable]
[Token(Token = "0x20000D0")]
public class MouseLookHelper
{
	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float XSensitivity;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float YSensitivity;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool clampVerticalRotation;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float MinimumX;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float MaximumX;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool smooth;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float smoothTime;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Quaternion m_CharacterTargetRot;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Quaternion m_CameraTargetRot;

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x12273EC", Offset = "0x12273EC", VA = "0x12273EC")]
	public void Init(Transform character, Transform camera)
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x12275E8", Offset = "0x12275E8", VA = "0x12275E8")]
	public void LookRotation(Transform character, Transform camera)
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x122FCC8", Offset = "0x122FCC8", VA = "0x122FCC8")]
	private Quaternion ClampRotationAroundXAxis(Quaternion q)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x1227920", Offset = "0x1227920", VA = "0x1227920")]
	public MouseLookHelper()
	{
	}
}
[Token(Token = "0x20000D1")]
public class SoundsForJoinAndLeave : MonoBehaviourPunCallbacks
{
	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip JoinClip;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioClip LeaveClip;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource source;

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x7C4F04", Offset = "0x7C4F04", VA = "0x7C4F04", Slot = "42")]
	public override void OnPlayerEnteredRoom(Player newPlayer)
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x7C501C", Offset = "0x7C501C", VA = "0x7C501C", Slot = "43")]
	public override void OnPlayerLeftRoom(Player otherPlayer)
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x7C5134", Offset = "0x7C5134", VA = "0x7C5134")]
	public SoundsForJoinAndLeave()
	{
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x20000D2")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1212778", Offset = "0x1212778", VA = "0x1212778")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x12129F4", Offset = "0x12129F4", VA = "0x12129F4")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1212BA4", Offset = "0x1212BA4", VA = "0x1212BA4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1212BC0", Offset = "0x1212BC0", VA = "0x1212BC0", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1212C80", Offset = "0x1212C80", VA = "0x1212C80", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1212CD4", Offset = "0x1212CD4", VA = "0x1212CD4")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1217A64", Offset = "0x1217A64", VA = "0x1217A64")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1217B44", Offset = "0x1217B44", VA = "0x1217B44")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1217C24", Offset = "0x1217C24", VA = "0x1217C24")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1217D04", Offset = "0x1217D04", VA = "0x1217D04")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1217DE4", Offset = "0x1217DE4", VA = "0x1217DE4")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1217EC4", Offset = "0x1217EC4", VA = "0x1217EC4")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x20000D5")]
		public class VirtualAxis
		{
			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string <name>k__BackingField;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x1700002A")]
			public string name
			{
				[Token(Token = "0x60003F7")]
				[Address(RVA = "0x1249D4C", Offset = "0x1249D4C", VA = "0x1249D4C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003F8")]
				[Address(RVA = "0x1249D54", Offset = "0x1249D54", VA = "0x1249D54")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60003F9")]
				[Address(RVA = "0x1249D5C", Offset = "0x1249D5C", VA = "0x1249D5C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003FA")]
				[Address(RVA = "0x1249D64", Offset = "0x1249D64", VA = "0x1249D64")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002C")]
			public float GetValue
			{
				[Token(Token = "0x60003FF")]
				[Address(RVA = "0x1249E2C", Offset = "0x1249E2C", VA = "0x1249E2C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x1241454", Offset = "0x1241454", VA = "0x1241454")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x1249D70", Offset = "0x1249D70", VA = "0x1249D70")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x1249DBC", Offset = "0x1249DBC", VA = "0x1249DBC")]
			public void Remove()
			{
			}

			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x1249E24", Offset = "0x1249E24", VA = "0x1249E24")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x20000D6")]
		public class VirtualButton
		{
			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string <name>k__BackingField;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x1700002D")]
			public string name
			{
				[Token(Token = "0x6000400")]
				[Address(RVA = "0x1249E34", Offset = "0x1249E34", VA = "0x1249E34")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000401")]
				[Address(RVA = "0x1249E3C", Offset = "0x1249E3C", VA = "0x1249E3C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002E")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000402")]
				[Address(RVA = "0x1249E44", Offset = "0x1249E44", VA = "0x1249E44")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000403")]
				[Address(RVA = "0x1249E4C", Offset = "0x1249E4C", VA = "0x1249E4C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000404")]
			[Address(RVA = "0x1249E58", Offset = "0x1249E58", VA = "0x1249E58")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000405")]
			[Address(RVA = "0x1249EA0", Offset = "0x1249EA0", VA = "0x1249EA0")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000406")]
			[Address(RVA = "0x1249EF4", Offset = "0x1249EF4", VA = "0x1249EF4")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0x1249F30", Offset = "0x1249F30", VA = "0x1249F30")]
			public void Released()
			{
			}
		}

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x121FCA4", Offset = "0x121FCA4", VA = "0x121FCA4")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x121288C", Offset = "0x121288C", VA = "0x121288C")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1212904", Offset = "0x1212904", VA = "0x1212904")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x121FD6C", Offset = "0x121FD6C", VA = "0x121FD6C")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x121FDE4", Offset = "0x121FDE4", VA = "0x121FDE4")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x121297C", Offset = "0x121297C", VA = "0x121297C")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x121FEA8", Offset = "0x121FEA8", VA = "0x121FEA8")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1213588", Offset = "0x1213588", VA = "0x1213588")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x121FF0C", Offset = "0x121FF0C", VA = "0x121FF0C")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1217AC8", Offset = "0x1217AC8", VA = "0x1217AC8")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1217BA8", Offset = "0x1217BA8", VA = "0x1217BA8")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1217C88", Offset = "0x1217C88", VA = "0x1217C88")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1217E48", Offset = "0x1217E48", VA = "0x1217E48")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1217D68", Offset = "0x1217D68", VA = "0x1217D68")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x121FF98", Offset = "0x121FF98", VA = "0x121FF98")]
		public static void SetAxis(string name, float value)
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x122BEC0", Offset = "0x122BEC0", VA = "0x122BEC0")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x122BF40", Offset = "0x122BF40", VA = "0x122BF40")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x20000D9")]
		public enum AxisOption
		{
			[Token(Token = "0x400042C")]
			Both,
			[Token(Token = "0x400042D")]
			OnlyHorizontal,
			[Token(Token = "0x400042E")]
			OnlyVertical
		}

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x122BF48", Offset = "0x122BF48", VA = "0x122BF48")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x122C0A8", Offset = "0x122C0A8", VA = "0x122C0A8")]
		private void Start()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x122C0E4", Offset = "0x122C0E4", VA = "0x122C0E4")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x122BF4C", Offset = "0x122BF4C", VA = "0x122BF4C")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x122C148", Offset = "0x122C148", VA = "0x122C148", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x122C26C", Offset = "0x122C26C", VA = "0x122C26C", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x122C2B4", Offset = "0x122C2B4", VA = "0x122C2B4", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x122C2B8", Offset = "0x122C2B8", VA = "0x122C2B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x122C310", Offset = "0x122C310", VA = "0x122C310")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x122D9FC", Offset = "0x122D9FC", VA = "0x122D9FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x122DA0C", Offset = "0x122DA0C", VA = "0x122DA0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x122DA04", Offset = "0x122DA04", VA = "0x122DA04")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x122DB20", Offset = "0x122DB20", VA = "0x122DB20")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x122DE68", Offset = "0x122DE68", VA = "0x122DE68")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x57FB14", Offset = "0x57FB14")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x20000DC")]
		public enum AxisOption
		{
			[Token(Token = "0x4000442")]
			Both,
			[Token(Token = "0x4000443")]
			OnlyHorizontal,
			[Token(Token = "0x4000444")]
			OnlyVertical
		}

		[Token(Token = "0x20000DD")]
		public enum ControlStyle
		{
			[Token(Token = "0x4000446")]
			Absolute,
			[Token(Token = "0x4000447")]
			Relative,
			[Token(Token = "0x4000448")]
			Swipe
		}

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1241244", Offset = "0x1241244", VA = "0x1241244")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x12413CC", Offset = "0x12413CC", VA = "0x12413CC")]
		private void Start()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1241248", Offset = "0x1241248", VA = "0x1241248")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1241494", Offset = "0x1241494", VA = "0x1241494")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1241500", Offset = "0x1241500", VA = "0x1241500", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1241538", Offset = "0x1241538", VA = "0x1241538")]
		private void Update()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1241680", Offset = "0x1241680", VA = "0x1241680", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x12416B4", Offset = "0x12416B4", VA = "0x12416B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x12417B4", Offset = "0x12417B4", VA = "0x12417B4")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1245B60", Offset = "0x1245B60", VA = "0x1245B60")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1245BC4", Offset = "0x1245BC4", VA = "0x1245BC4")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1245D24", Offset = "0x1245D24", VA = "0x1245D24")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1245E84", Offset = "0x1245E84", VA = "0x1245E84")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1245F24", Offset = "0x1245F24", VA = "0x1245F24")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000427")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000428")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000429")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x600042A")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x600042B")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x600042C")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1245FC0", Offset = "0x1245FC0", VA = "0x1245FC0")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x20000DF")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x122DE70", Offset = "0x122DE70", VA = "0x122DE70")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x122DF00", Offset = "0x122DF00", VA = "0x122DF00")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x122DF90", Offset = "0x122DF90", VA = "0x122DF90", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x122E034", Offset = "0x122E034", VA = "0x122E034", Slot = "5")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x122E0D8", Offset = "0x122E0D8", VA = "0x122E0D8", Slot = "6")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x122E17C", Offset = "0x122E17C", VA = "0x122E17C", Slot = "7")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x122E224", Offset = "0x122E224", VA = "0x122E224", Slot = "8")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x122E2CC", Offset = "0x122E2CC", VA = "0x122E2CC", Slot = "9")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x122E370", Offset = "0x122E370", VA = "0x122E370", Slot = "10")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x122E420", Offset = "0x122E420", VA = "0x122E420")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x7C5BB8", Offset = "0x7C5BB8", VA = "0x7C5BB8", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x7C5BCC", Offset = "0x7C5BCC", VA = "0x7C5BCC", Slot = "5")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x7C5C20", Offset = "0x7C5C20", VA = "0x7C5C20", Slot = "6")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x7C5C74", Offset = "0x7C5C74", VA = "0x7C5C74", Slot = "7")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x7C5CC8", Offset = "0x7C5CC8", VA = "0x7C5CC8", Slot = "8")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x7C5D1C", Offset = "0x7C5D1C", VA = "0x7C5D1C", Slot = "9")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x7C5D70", Offset = "0x7C5D70", VA = "0x7C5D70", Slot = "10")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x7C5DC4", Offset = "0x7C5DC4", VA = "0x7C5DC4")]
		public StandaloneInput()
		{
		}
	}
}
namespace ExitGames.Demos.DemoPunVoice
{
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x57FB74", Offset = "0x57FB74")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x57FB74", Offset = "0x57FB74")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x57FB74", Offset = "0x57FB74")]
	public abstract class BaseController : MonoBehaviour
	{
		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera ControllerCamera;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Rigidbody rigidBody;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Animator animator;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform camTrans;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float h;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float v;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected float speed;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float cameraDistance;

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1212F08", Offset = "0x1212F08", VA = "0x1212F08", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1213034", Offset = "0x1213034", VA = "0x1213034", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1213160", Offset = "0x1213160", VA = "0x1213160", Slot = "6")]
		protected virtual void ChangePOV_CameraChanged(Camera camera)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1213214", Offset = "0x1213214", VA = "0x1213214", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x12132A8", Offset = "0x12132A8", VA = "0x12132A8", Slot = "8")]
		protected virtual void Init()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1213334", Offset = "0x1213334", VA = "0x1213334", Slot = "9")]
		protected virtual void SetCamera()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x12133E4", Offset = "0x12133E4", VA = "0x12133E4", Slot = "10")]
		protected virtual void UpdateAnimator(float h, float v)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1213460", Offset = "0x1213460", VA = "0x1213460", Slot = "11")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x12135EC", Offset = "0x12135EC", VA = "0x12135EC", Slot = "12")]
		protected virtual void ShowCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1213688", Offset = "0x1213688", VA = "0x1213688", Slot = "13")]
		protected virtual void HideCamera(Camera camera)
		{
		}

		[Token(Token = "0x600044A")]
		protected abstract void Move(float h, float v);

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1213724", Offset = "0x1213724", VA = "0x1213724")]
		protected BaseController()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x57FC3C", Offset = "0x57FC3C")]
	public class BetterToggle : MonoBehaviour
	{
		[Token(Token = "0x20000E3")]
		public delegate void OnToggle(Toggle toggle);

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Toggle toggle;

		[Token(Token = "0x14000001")]
		public static event OnToggle ToggleValueChanged
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x1213734", Offset = "0x1213734", VA = "0x1213734")]
			add
			{
			}
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x12137F0", Offset = "0x12137F0", VA = "0x12137F0")]
			remove
			{
			}
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x12138AC", Offset = "0x12138AC", VA = "0x12138AC")]
		private void Start()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x12139A0", Offset = "0x12139A0", VA = "0x12139A0")]
		public void OnToggleValueChanged()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1213A08", Offset = "0x1213A08", VA = "0x1213A08")]
		public BetterToggle()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1213A10", Offset = "0x1213A10", VA = "0x1213A10")]
		private void <Start>b__5_0(bool <p0>)
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class ChangePOV : MonoBehaviour, IMatchmakingCallbacks
	{
		[Token(Token = "0x20000E5")]
		public delegate void OnCameraChanged(Camera newCamera);

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FirstPersonController firstPersonController;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ThirdPersonController thirdPersonController;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OrthographicController orthographicController;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 initialCameraPosition;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion initialCameraRotation;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Camera defaultCamera;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject ButtonsHolder;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button FirstPersonCamActivator;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button ThirdPersonCamActivator;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button OrthographicCamActivator;

		[Token(Token = "0x14000002")]
		public static event OnCameraChanged CameraChanged
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1212F78", Offset = "0x1212F78", VA = "0x1212F78")]
			add
			{
			}
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x12130A4", Offset = "0x12130A4", VA = "0x12130A4")]
			remove
			{
			}
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1218C94", Offset = "0x1218C94", VA = "0x1218C94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1218E00", Offset = "0x1218E00", VA = "0x1218E00")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1218F6C", Offset = "0x1218F6C", VA = "0x1218F6C")]
		private void Start()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x12191B4", Offset = "0x12191B4", VA = "0x12191B4")]
		private void OnCharacterInstantiated(GameObject character)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x12192C8", Offset = "0x12192C8", VA = "0x12192C8")]
		private void FirstPersonMode()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1219468", Offset = "0x1219468", VA = "0x1219468")]
		private void ThirdPersonMode()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1219470", Offset = "0x1219470", VA = "0x1219470")]
		private void OrthographicMode()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x12192D0", Offset = "0x12192D0", VA = "0x12192D0")]
		private void ToggleMode(BaseController controller)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1219478", Offset = "0x1219478", VA = "0x1219478")]
		private void BroadcastChange(Camera camera)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1219520", Offset = "0x1219520", VA = "0x1219520", Slot = "4")]
		public void OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1219524", Offset = "0x1219524", VA = "0x1219524", Slot = "5")]
		public void OnCreatedRoom()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1219528", Offset = "0x1219528", VA = "0x1219528", Slot = "6")]
		public void OnCreateRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x121952C", Offset = "0x121952C", VA = "0x121952C", Slot = "7")]
		public void OnJoinedRoom()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1219530", Offset = "0x1219530", VA = "0x1219530", Slot = "8")]
		public void OnJoinRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1219534", Offset = "0x1219534", VA = "0x1219534", Slot = "9")]
		public void OnJoinRandomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1219538", Offset = "0x1219538", VA = "0x1219538", Slot = "10")]
		public void OnLeftRoom()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1219650", Offset = "0x1219650", VA = "0x1219650")]
		public ChangePOV()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class CharacterInstantiation : MonoBehaviourPunCallbacks, IOnEventCallback
	{
		[Token(Token = "0x20000E7")]
		public enum SpawnSequence
		{
			[Token(Token = "0x4000470")]
			Connection,
			[Token(Token = "0x4000471")]
			Random,
			[Token(Token = "0x4000472")]
			RoundRobin
		}

		[Token(Token = "0x20000E8")]
		public delegate void OnCharacterInstantiated(GameObject character);

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform SpawnPosition;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float PositionOffset;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject[] PrefabsToInstantiate;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Transform> SpawnPoints;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool AutoSpawn;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool UseRandomOffset;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public SpawnSequence Sequence;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private byte manualInstantiationEventCode;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		protected int lastUsedSpawnPointIndex;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool manualInstantiation;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool differentPrefabs;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string localPrefabSuffix;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string remotePrefabSuffix;

		[Token(Token = "0x14000003")]
		public static event OnCharacterInstantiated CharacterInstantiated
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x1218D44", Offset = "0x1218D44", VA = "0x1218D44")]
			add
			{
			}
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x1218EB0", Offset = "0x1218EB0", VA = "0x1218EB0")]
			remove
			{
			}
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x12199F8", Offset = "0x12199F8", VA = "0x12199F8", Slot = "41")]
		public override void OnJoinedRoom()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1219C2C", Offset = "0x1219C2C", VA = "0x1219C2C")]
		private void ManualInstantiation(int index, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x121A1B8", Offset = "0x121A1B8", VA = "0x121A1B8", Slot = "54")]
		public void OnEvent(EventData photonEvent)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x121A518", Offset = "0x121A518", VA = "0x121A518", Slot = "55")]
		protected virtual void GetSpawnPoint(out Vector3 spawnPos, out Quaternion spawnRot)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x121A6B8", Offset = "0x121A6B8", VA = "0x121A6B8", Slot = "56")]
		protected virtual Transform GetSpawnPoint()
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x121A82C", Offset = "0x121A82C", VA = "0x121A82C")]
		public CharacterInstantiation()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class FirstPersonController : BaseController
	{
		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MouseLookHelper mouseLook;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float oldYRotation;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Quaternion velRotation;

		[Token(Token = "0x1700002F")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x1227388", Offset = "0x1227388", VA = "0x1227388")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x12273A4", Offset = "0x12273A4", VA = "0x12273A4", Slot = "9")]
		protected override void SetCamera()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1227440", Offset = "0x1227440", VA = "0x1227440", Slot = "14")]
		protected override void Move(float h, float v)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x12274D4", Offset = "0x12274D4", VA = "0x12274D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x12274D8", Offset = "0x12274D8", VA = "0x12274D8")]
		private void RotateView()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x122788C", Offset = "0x122788C", VA = "0x122788C")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x57FCAC", Offset = "0x57FCAC")]
	public class Highlighter : MonoBehaviour
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Canvas canvas;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PhotonVoiceView photonVoiceView;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image recorderSprite;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image speakerSprite;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text bufferLagText;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool showSpeakerLag;

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x122B8F8", Offset = "0x122B8F8", VA = "0x122B8F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x122B9C4", Offset = "0x122B9C4", VA = "0x122B9C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x122BA90", Offset = "0x122BA90", VA = "0x122BA90")]
		private void VoiceDemoUI_DebugToggled(bool debugMode)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x122BA9C", Offset = "0x122BA9C", VA = "0x122BA9C")]
		private void ChangePOV_CameraChanged(Camera camera)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x122BAB8", Offset = "0x122BAB8", VA = "0x122BAB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x122BBFC", Offset = "0x122BBFC", VA = "0x122BBFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x122BD60", Offset = "0x122BD60", VA = "0x122BD60")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x122BE8C", Offset = "0x122BE8C", VA = "0x122BE8C")]
		public Highlighter()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class OrthographicController : ThirdPersonController
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float smoothing;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 offset;

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x7B7E80", Offset = "0x7B7E80", VA = "0x7B7E80", Slot = "8")]
		protected override void Init()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x7B7EB8", Offset = "0x7B7EB8", VA = "0x7B7EB8", Slot = "9")]
		protected override void SetCamera()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x7B7F38", Offset = "0x7B7F38", VA = "0x7B7F38", Slot = "14")]
		protected override void Move(float h, float v)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x7B7F60", Offset = "0x7B7F60", VA = "0x7B7F60")]
		private void CameraFollow()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x7B802C", Offset = "0x7B802C", VA = "0x7B802C")]
		public OrthographicController()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class ThirdPersonController : BaseController
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float movingTurnSpeed;

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x123F594", Offset = "0x123F594", VA = "0x123F594", Slot = "14")]
		protected override void Move(float h, float v)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x123F6B4", Offset = "0x123F6B4", VA = "0x123F6B4")]
		public ThirdPersonController()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class VoiceDemoUI : MonoBehaviour
	{
		[Token(Token = "0x20000EE")]
		public delegate void OnDebugToggle(bool debugMode);

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text punState;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text voiceState;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PhotonVoiceNetwork punVoiceNetwork;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Canvas canvas;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button punSwitch;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text punSwitchText;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button voiceSwitch;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Text voiceSwitchText;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button calibrateButton;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Text calibrateText;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text voiceDebugText;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Recorder recorder;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject inGameSettings;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject globalSettings;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text devicesInfoText;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GameObject debugGO;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool debugMode;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float volumeBeforeMute;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private DebugLevel previousDebugLevel;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private int calibrationMilliSeconds;

		[Token(Token = "0x17000030")]
		public bool DebugMode
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x1246140", Offset = "0x1246140", VA = "0x1246140")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x1246148", Offset = "0x1246148", VA = "0x1246148")]
			set
			{
			}
		}

		[Token(Token = "0x14000004")]
		public static event OnDebugToggle DebugToggled
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x1246498", Offset = "0x1246498", VA = "0x1246498")]
			add
			{
			}
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x1246554", Offset = "0x1246554", VA = "0x1246554")]
			remove
			{
			}
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1246610", Offset = "0x1246610", VA = "0x1246610")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1246680", Offset = "0x1246680", VA = "0x1246680")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1246910", Offset = "0x1246910", VA = "0x1246910")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1246B64", Offset = "0x1246B64", VA = "0x1246B64")]
		private void CharacterInstantiation_CharacterInstantiated(GameObject character)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1246C30", Offset = "0x1246C30", VA = "0x1246C30")]
		private void InitToggles(Toggle[] toggles)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1246FD8", Offset = "0x1246FD8", VA = "0x1246FD8")]
		private void BetterToggle_ToggleValueChanged(Toggle toggle)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x124735C", Offset = "0x124735C", VA = "0x124735C")]
		private void OnCameraChanged(Camera newCamera)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1247378", Offset = "0x1247378", VA = "0x1247378")]
		private void Start()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x12479B4", Offset = "0x12479B4", VA = "0x12479B4")]
		private void PunSwitchOnClick()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1247AB8", Offset = "0x1247AB8", VA = "0x1247AB8")]
		private void VoiceSwitchOnClick()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1247B4C", Offset = "0x1247B4C", VA = "0x1247B4C")]
		private void CalibrateButtonOnClick()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1247BF4", Offset = "0x1247BF4", VA = "0x1247BF4")]
		private void Update()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1247E20", Offset = "0x1247E20", VA = "0x1247E20")]
		private void PunClientStateChanged(ClientState fromState, ClientState toState)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x12483F8", Offset = "0x12483F8", VA = "0x12483F8")]
		private void VoiceClientStateChanged(ClientState fromState, ClientState toState)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1247FB0", Offset = "0x1247FB0", VA = "0x1247FB0")]
		private void UpdateUiBasedOnVoiceState(ClientState voiceClientState)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1248400", Offset = "0x1248400", VA = "0x1248400")]
		public VoiceDemoUI()
		{
		}
	}
}
namespace Photon.Voice.Unity.Demos
{
	[Token(Token = "0x20000EF")]
	public class BackgroundMusicController : MonoBehaviour
	{
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text volumeText;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Slider volumeSlider;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float initialVolume;

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1212D44", Offset = "0x1212D44", VA = "0x1212D44")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1212E38", Offset = "0x1212E38", VA = "0x1212E38")]
		private void OnVolumeChanged(float newValue)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1212EF8", Offset = "0x1212EF8", VA = "0x1212EF8")]
		public BackgroundMusicController()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class SidebarToggle : MonoBehaviour
	{
		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button sidebarButton;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform panelsHolder;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float sidebarWidth;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool sidebarOpen;

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x7C3E78", Offset = "0x7C3E78", VA = "0x7C3E78")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x7C3F5C", Offset = "0x7C3F5C", VA = "0x7C3F5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x5806D0", Offset = "0x5806D0")]
		private void ToggleSidebar()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x7C3F38", Offset = "0x7C3F38", VA = "0x7C3F38")]
		private void ToggleSidebar(bool open)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x7C3F74", Offset = "0x7C3F74", VA = "0x7C3F74")]
		public SidebarToggle()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public static class UiExtensions
	{
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x12420C0", Offset = "0x12420C0", VA = "0x12420C0")]
		public static void SetPosX(RectTransform rectTransform, float x)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1242118", Offset = "0x1242118", VA = "0x1242118")]
		public static void SetValue(Toggle toggle, bool isOn)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1242134", Offset = "0x1242134", VA = "0x1242134")]
		public static void SetValue(Slider slider, float v)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1242154", Offset = "0x1242154", VA = "0x1242154")]
		public static void SetValue(InputField inputField, string v)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x124216C", Offset = "0x124216C", VA = "0x124216C")]
		public static void SetSingleOnValueChangedCallback(Toggle toggle, UnityAction<bool> action)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x12421E4", Offset = "0x12421E4", VA = "0x12421E4")]
		public static void SetSingleOnValueChangedCallback(InputField inputField, UnityAction<string> action)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x124225C", Offset = "0x124225C", VA = "0x124225C")]
		public static void SetSingleOnEndEditCallback(InputField inputField, UnityAction<string> action)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x12422D4", Offset = "0x12422D4", VA = "0x12422D4")]
		public static void SetSingleOnValueChangedCallback(Dropdown inputField, UnityAction<int> action)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x124234C", Offset = "0x124234C", VA = "0x124234C")]
		public static void SetSingleOnValueChangedCallback(Slider slider, UnityAction<float> action)
		{
		}
	}
}
namespace Photon.Voice.Unity.Demos.DemoVoiceUI
{
	[Token(Token = "0x20000F2")]
	public class CodecSettingsUI : MonoBehaviour
	{
		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Dropdown frameDurationDropdown;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Dropdown samplingRateDropdown;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InputField bitrateInputField;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Recorder recorder;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<string> frameDurationOptions;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<string> samplingRateOptions;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x121DCB4", Offset = "0x121DCB4", VA = "0x121DCB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x121E000", Offset = "0x121E000", VA = "0x121E000")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x121E02C", Offset = "0x121E02C", VA = "0x121E02C")]
		private void OnBitrateChanged(string newBitrateString)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x121E098", Offset = "0x121E098", VA = "0x121E098")]
		private void OnFrameDurationChanged(int index)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x121E108", Offset = "0x121E108", VA = "0x121E108")]
		private void OnSamplingRateChanged(int index)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x121DEB0", Offset = "0x121DEB0", VA = "0x121DEB0")]
		private void InitFrameDuration()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x121DF40", Offset = "0x121DF40", VA = "0x121DF40")]
		private void InitSamplingRate()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x121DFAC", Offset = "0x121DFAC", VA = "0x121DFAC")]
		private void InitBitrate()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x121E178", Offset = "0x121E178", VA = "0x121E178")]
		public CodecSettingsUI()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x57FD0C", Offset = "0x57FD0C")]
	public class DemoVoiceUI : MonoBehaviour, IInRoomCallbacks, IMatchmakingCallbacks
	{
		[Serializable]
		[Token(Token = "0x20000F4")]
		private sealed class <>c
		{
			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<IAudioDesc> <>9__68_0;

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x1249FC0", Offset = "0x1249FC0", VA = "0x1249FC0")]
			public <>c()
			{
			}

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x1249FC8", Offset = "0x1249FC8", VA = "0x1249FC8")]
			internal IAudioDesc <ToggleAudioToneFactory>b__68_0()
			{
				return null;
			}
		}

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text connectionStatusText;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text serverStatusText;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text roomStatusText;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text inputWarningText;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text rttText;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text rttVariationText;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text packetLossWarningText;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InputField localNicknameText;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Toggle debugEchoToggle;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Toggle reliableTransmissionToggle;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Toggle encryptionToggle;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject webRtcDspGameObject;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Toggle aecToggle;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Toggle aecHighPassToggle;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InputField reverseStreamDelayInputField;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Toggle noiseSuppressionToggle;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Toggle agcToggle;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Slider agcCompressionGainSlider;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Toggle vadToggle;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Toggle muteToggle;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Toggle streamAudioClipToggle;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Toggle audioToneToggle;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Toggle dspToggle;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Toggle highPassToggle;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Toggle photonVadToggle;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject microphoneSetupGameObject;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private bool defaultTransmitEnabled;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private int screenWidth;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private int screenHeight;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private bool fullScreen;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private InputField roomNameInputField;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private InputField globalMinDelaySoftInputField;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private InputField globalMaxDelaySoftInputField;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private InputField globalMaxDelayHardInputField;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private int rttYellowThreshold;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private int rttRedThreshold;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private int rttVariationYellowThreshold;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[SerializeField]
		private int rttVariationRedThreshold;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private GameObject compressionGainGameObject;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Text compressionGainText;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private GameObject aecOptionsGameObject;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Transform RemoteVoicesPanel;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		protected VoiceConnection voiceConnection;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private WebRtcAudioDsp voiceAudioPreprocessor;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private ConnectAndJoin connectAndJoin;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private readonly Color warningColor;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private readonly Color okColor;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private readonly Color redColor;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private readonly Color defaultColor;

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x122090C", Offset = "0x122090C", VA = "0x122090C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x122163C", Offset = "0x122163C", VA = "0x122163C", Slot = "16")]
		protected virtual void SetDefaults()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1221668", Offset = "0x1221668", VA = "0x1221668")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1221724", Offset = "0x1221724", VA = "0x1221724")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x122159C", Offset = "0x122159C", VA = "0x122159C")]
		private void GetSavedNickname()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x12217E0", Offset = "0x12217E0", VA = "0x12217E0", Slot = "17")]
		protected virtual void OnSpeakerCreated(Speaker speaker)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1221924", Offset = "0x1221924", VA = "0x1221924")]
		private void OnRemoteVoiceRemove(Speaker speaker)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x12219DC", Offset = "0x12219DC", VA = "0x12219DC")]
		private void ToggleMute(bool isOn)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1221A4C", Offset = "0x1221A4C", VA = "0x1221A4C", Slot = "18")]
		protected virtual void ToggleIsRecording(bool isRecording)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1221A88", Offset = "0x1221A88", VA = "0x1221A88")]
		private void ToggleDebugEcho(bool isOn)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1221AC4", Offset = "0x1221AC4", VA = "0x1221AC4")]
		private void ToggleReliable(bool isOn)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1221B00", Offset = "0x1221B00", VA = "0x1221B00")]
		private void ToggleEncryption(bool isOn)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1221B3C", Offset = "0x1221B3C", VA = "0x1221B3C")]
		private void ToggleAEC(bool isOn)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1221B84", Offset = "0x1221B84", VA = "0x1221B84")]
		private void ToggleNoiseSuppression(bool isOn)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1221BA4", Offset = "0x1221BA4", VA = "0x1221BA4")]
		private void ToggleAGC(bool isOn)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1221BEC", Offset = "0x1221BEC", VA = "0x1221BEC")]
		private void ToggleVAD(bool isOn)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1221C0C", Offset = "0x1221C0C", VA = "0x1221C0C")]
		private void ToggleHighPass(bool isOn)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1221C2C", Offset = "0x1221C2C", VA = "0x1221C2C")]
		private void ToggleDsp(bool isOn)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1221C90", Offset = "0x1221C90", VA = "0x1221C90")]
		private void ToggleAudioClipStreaming(bool isOn)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1221D90", Offset = "0x1221D90", VA = "0x1221D90")]
		private void ToggleAudioToneFactory(bool isOn)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1221FC8", Offset = "0x1221FC8", VA = "0x1221FC8")]
		private void TogglePhotonVAD(bool isOn)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1222004", Offset = "0x1222004", VA = "0x1222004")]
		private void ToggleAecHighPass(bool isOn)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1222024", Offset = "0x1222024", VA = "0x1222024")]
		private void OnAgcCompressionGainChanged(float agcCompressionGain)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x12220FC", Offset = "0x12220FC", VA = "0x12220FC")]
		private void OnGlobalPlaybackDelayMinSoftChanged(string newMinDelaySoftString)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x12221D8", Offset = "0x12221D8", VA = "0x12221D8")]
		private void OnGlobalPlaybackDelayMaxSoftChanged(string newMaxDelaySoftString)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x12222B0", Offset = "0x12222B0", VA = "0x12222B0")]
		private void OnGlobalPlaybackDelayMaxHardChanged(string newMaxDelayHardString)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1222388", Offset = "0x1222388", VA = "0x1222388")]
		private void OnReverseStreamDelayChanged(string newReverseStreamString)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x122241C", Offset = "0x122241C", VA = "0x122241C")]
		private void UpdateSyncedNickname(string nickname)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x12224D4", Offset = "0x12224D4", VA = "0x12224D4")]
		private void JoinOrCreateRoom(string roomName)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1222620", Offset = "0x1222620", VA = "0x1222620", Slot = "19")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1222BDC", Offset = "0x1222BDC", VA = "0x1222BDC")]
		private void SetTextColor(int textValue, Text text, int yellowThreshold, int redThreshold)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1222BA4", Offset = "0x1222BA4", VA = "0x1222BA4")]
		private void ResetTextColor(Text text)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1220ABC", Offset = "0x1220ABC", VA = "0x1220ABC")]
		private void InitUiCallbacks()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1221134", Offset = "0x1221134", VA = "0x1221134")]
		private void InitUiValues()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1222C5C", Offset = "0x1222C5C", VA = "0x1222C5C")]
		private void SetRoomDebugText()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1222F40", Offset = "0x1222F40", VA = "0x1222F40", Slot = "20")]
		protected virtual void OnActorPropertiesChanged(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1222FB8", Offset = "0x1222FB8", VA = "0x1222FB8", Slot = "4")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerEnteredRoom(Player newPlayer)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1222FBC", Offset = "0x1222FBC", VA = "0x1222FBC", Slot = "5")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerLeftRoom(Player otherPlayer)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1222FC0", Offset = "0x1222FC0", VA = "0x1222FC0", Slot = "6")]
		private void Photon.Realtime.IInRoomCallbacks.OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1222FC4", Offset = "0x1222FC4", VA = "0x1222FC4", Slot = "7")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1222FD4", Offset = "0x1222FD4", VA = "0x1222FD4", Slot = "8")]
		private void Photon.Realtime.IInRoomCallbacks.OnMasterClientSwitched(Player newMasterClient)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1222FD8", Offset = "0x1222FD8", VA = "0x1222FD8", Slot = "9")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1222FDC", Offset = "0x1222FDC", VA = "0x1222FDC", Slot = "10")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnCreatedRoom()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1222FE0", Offset = "0x1222FE0", VA = "0x1222FE0", Slot = "11")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnCreateRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1222FE4", Offset = "0x1222FE4", VA = "0x1222FE4", Slot = "12")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnJoinedRoom()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1222FE8", Offset = "0x1222FE8", VA = "0x1222FE8", Slot = "13")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnJoinRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1222FEC", Offset = "0x1222FEC", VA = "0x1222FEC", Slot = "14")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnJoinRandomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1222FF0", Offset = "0x1222FF0", VA = "0x1222FF0", Slot = "15")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnLeftRoom()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1223068", Offset = "0x1223068", VA = "0x1223068")]
		public DemoVoiceUI()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public struct MicRef
	{
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Recorder.MicType MicType;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int PhotonId;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string PhotonIdString;

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x122CFF0", Offset = "0x122CFF0", VA = "0x122CFF0")]
		public MicRef(string name)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x122D070", Offset = "0x122D070", VA = "0x122D070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000F6")]
	public class MicrophoneDropdownFiller : MonoBehaviour
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<MicRef> micOptions;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Dropdown micDropdown;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Recorder recorder;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5804D4", Offset = "0x5804D4")]
		private GameObject refreshButton;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x580520", Offset = "0x580520")]
		private GameObject toggleButton;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Toggle photonToggle;

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x122D0C0", Offset = "0x122D0C0", VA = "0x122D0C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x122D158", Offset = "0x122D158", VA = "0x122D158")]
		private void SetupMicDropdown()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x122D3F4", Offset = "0x122D3F4", VA = "0x122D3F4")]
		private void MicDropdownValueChanged(MicRef mic)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x122D48C", Offset = "0x122D48C", VA = "0x122D48C")]
		private void SetCurrentValue()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x122D88C", Offset = "0x122D88C", VA = "0x122D88C")]
		public void PhotonMicToggled(bool on)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x122D134", Offset = "0x122D134", VA = "0x122D134")]
		public void RefreshMicrophones()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x122D93C", Offset = "0x122D93C", VA = "0x122D93C")]
		private void PhotonVoiceCreated()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x122D960", Offset = "0x122D960", VA = "0x122D960")]
		public MicrophoneDropdownFiller()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x122D968", Offset = "0x122D968", VA = "0x122D968")]
		private void <SetupMicDropdown>b__7_0(int <p0>)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public static class PhotonDemoExtensions
	{
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x7B9268", Offset = "0x7B9268", VA = "0x7B9268")]
		public static bool Mute(Player player)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x7B9358", Offset = "0x7B9358", VA = "0x7B9358")]
		public static bool Unmute(Player player)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x7B9444", Offset = "0x7B9444", VA = "0x7B9444")]
		public static bool IsMuted(Player player)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x57FD94", Offset = "0x57FD94")]
	public class RemoteSpeakerUI : MonoBehaviour, IInRoomCallbacks
	{
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text nameText;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Image remoteIsMuting;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image remoteIsTalking;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InputField minDelaySoftInputField;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InputField maxDelaySoftInputField;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private InputField maxDelayHardInputField;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text bufferLagText;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Speaker speaker;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected VoiceConnection voiceConnection;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected LoadBalancingClient loadBalancingClient;

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x7C21E4", Offset = "0x7C21E4", VA = "0x7C21E4", Slot = "9")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x7C2538", Offset = "0x7C2538", VA = "0x7C2538")]
		private void OnMinDelaySoftChanged(string newMinDelaySoftString)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x7C2614", Offset = "0x7C2614", VA = "0x7C2614")]
		private void OnMaxDelaySoftChanged(string newMaxDelaySoftString)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x7C26EC", Offset = "0x7C26EC", VA = "0x7C26EC")]
		private void OnMaxDelayHardChanged(string newMaxDelayHardString)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x7C27C4", Offset = "0x7C27C4", VA = "0x7C27C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x7C28A8", Offset = "0x7C28A8", VA = "0x7C28A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x7C2408", Offset = "0x7C2408", VA = "0x7C2408")]
		private void SetNickname()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x7C24F8", Offset = "0x7C24F8", VA = "0x7C24F8")]
		private void SetMutedState()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x7C28C0", Offset = "0x7C28C0", VA = "0x7C28C0", Slot = "10")]
		protected virtual void SetMutedState(bool isMuted)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x7C28E0", Offset = "0x7C28E0", VA = "0x7C28E0", Slot = "11")]
		protected virtual void OnActorPropertiesChanged(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x7C293C", Offset = "0x7C293C", VA = "0x7C293C", Slot = "12")]
		public virtual void Init(VoiceConnection vC)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x7C29A0", Offset = "0x7C29A0", VA = "0x7C29A0", Slot = "4")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerEnteredRoom(Player newPlayer)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x7C29A4", Offset = "0x7C29A4", VA = "0x7C29A4", Slot = "5")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerLeftRoom(Player otherPlayer)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x7C29A8", Offset = "0x7C29A8", VA = "0x7C29A8", Slot = "6")]
		private void Photon.Realtime.IInRoomCallbacks.OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x7C29AC", Offset = "0x7C29AC", VA = "0x7C29AC", Slot = "7")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x7C29B8", Offset = "0x7C29B8", VA = "0x7C29B8", Slot = "8")]
		private void Photon.Realtime.IInRoomCallbacks.OnMasterClientSwitched(Player newMasterClient)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x7C29BC", Offset = "0x7C29BC", VA = "0x7C29BC")]
		public RemoteSpeakerUI()
		{
		}
	}
}
namespace Photon.Realtime.Demo
{
	[Token(Token = "0x20000F9")]
	public class ConnectAndJoinRandomLb : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks, ILobbyCallbacks
	{
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AppSettings appSettings;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LoadBalancingClient lbc;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ConnectionHandler ch;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text StateUiText;

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x121E538", Offset = "0x121E538", VA = "0x121E538")]
		public void Start()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x121E6E0", Offset = "0x121E6E0", VA = "0x121E6E0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x121E830", Offset = "0x121E830", VA = "0x121E830", Slot = "4")]
		public void OnConnected()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x121E834", Offset = "0x121E834", VA = "0x121E834", Slot = "5")]
		public void OnConnectedToMaster()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x121E8C4", Offset = "0x121E8C4", VA = "0x121E8C4", Slot = "6")]
		public void OnDisconnected(DisconnectCause cause)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x121E9C4", Offset = "0x121E9C4", VA = "0x121E9C4", Slot = "8")]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x121E9C8", Offset = "0x121E9C8", VA = "0x121E9C8", Slot = "9")]
		public void OnCustomAuthenticationFailed(string debugMessage)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x121E9CC", Offset = "0x121E9CC", VA = "0x121E9CC", Slot = "7")]
		public void OnRegionListReceived(RegionHandler regionHandler)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x121EAC4", Offset = "0x121EAC4", VA = "0x121EAC4", Slot = "19")]
		public void OnRoomListUpdate(List<RoomInfo> roomList)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x121EAC8", Offset = "0x121EAC8", VA = "0x121EAC8", Slot = "20")]
		public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x121EACC", Offset = "0x121EACC", VA = "0x121EACC", Slot = "17")]
		public void OnJoinedLobby()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x121EAD0", Offset = "0x121EAD0", VA = "0x121EAD0", Slot = "18")]
		public void OnLeftLobby()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x121EAD4", Offset = "0x121EAD4", VA = "0x121EAD4", Slot = "10")]
		public void OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x121EAD8", Offset = "0x121EAD8", VA = "0x121EAD8", Slot = "11")]
		public void OnCreatedRoom()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x121EADC", Offset = "0x121EADC", VA = "0x121EADC", Slot = "12")]
		public void OnCreateRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x121EAE0", Offset = "0x121EAE0", VA = "0x121EAE0", Slot = "13")]
		public void OnJoinedRoom()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x121EB54", Offset = "0x121EB54", VA = "0x121EB54", Slot = "14")]
		public void OnJoinRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x121EB58", Offset = "0x121EB58", VA = "0x121EB58", Slot = "15")]
		public void OnJoinRandomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x121EC14", Offset = "0x121EC14", VA = "0x121EC14", Slot = "16")]
		public void OnLeftRoom()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x121EC18", Offset = "0x121EC18", VA = "0x121EC18")]
		private void OnRegionPingCompleted(RegionHandler regionHandler)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x121ED48", Offset = "0x121ED48", VA = "0x121ED48")]
		public ConnectAndJoinRandomLb()
		{
		}
	}
}
namespace Photon.Chat.UtilityScripts
{
	[Token(Token = "0x20000FA")]
	public class EventSystemSpawner : MonoBehaviour
	{
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x12256F0", Offset = "0x12256F0", VA = "0x12256F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1225804", Offset = "0x1225804", VA = "0x1225804")]
		public EventSystemSpawner()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class OnStartDelete : MonoBehaviour
	{
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x7B6A30", Offset = "0x7B6A30", VA = "0x7B6A30")]
		private void Start()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x7B6AA8", Offset = "0x7B6AA8", VA = "0x7B6AA8")]
		public OnStartDelete()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x57FDF4", Offset = "0x57FDF4")]
	public class TextButtonTransition : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Text _text;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Selectable Selectable;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color NormalColor;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color HoverColor;

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x123EF9C", Offset = "0x123EF9C", VA = "0x123EF9C")]
		public void Awake()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x123EFF8", Offset = "0x123EFF8", VA = "0x123EFF8")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x123F028", Offset = "0x123F028", VA = "0x123F028")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x123F058", Offset = "0x123F058", VA = "0x123F058", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x123F114", Offset = "0x123F114", VA = "0x123F114", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x123F1D0", Offset = "0x123F1D0", VA = "0x123F1D0")]
		public TextButtonTransition()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x57FE54", Offset = "0x57FE54")]
	public class TextToggleIsOnTransition : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle toggle;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text _text;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color NormalOnColor;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color NormalOffColor;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color HoverOnColor;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color HoverOffColor;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isHover;

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x123F214", Offset = "0x123F214", VA = "0x123F214")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x123F380", Offset = "0x123F380", VA = "0x123F380")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x123F31C", Offset = "0x123F31C", VA = "0x123F31C")]
		public void OnValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x123F444", Offset = "0x123F444", VA = "0x123F444", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x123F4BC", Offset = "0x123F4BC", VA = "0x123F4BC", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x123F530", Offset = "0x123F530", VA = "0x123F530")]
		public TextToggleIsOnTransition()
		{
		}
	}
}
namespace Oculus.Spatializer.Propagation
{
	[Token(Token = "0x20000FE")]
	public enum FaceType : uint
	{
		[Token(Token = "0x40004F9")]
		TRIANGLES,
		[Token(Token = "0x40004FA")]
		QUADS
	}
	[Token(Token = "0x20000FF")]
	public enum MaterialProperty : uint
	{
		[Token(Token = "0x40004FC")]
		ABSORPTION,
		[Token(Token = "0x40004FD")]
		TRANSMISSION,
		[Token(Token = "0x40004FE")]
		SCATTERING
	}
	[Token(Token = "0x2000100")]
	public struct MeshGroup
	{
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UIntPtr indexOffset;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UIntPtr faceCount;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FaceType faceType;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public IntPtr material;
	}
}
namespace Proto
{
	[Token(Token = "0x2000101")]
	public static class Physics
	{
		[Token(Token = "0x2000102")]
		public struct Sphere
		{
			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 pos;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float radius;
		}

		[Token(Token = "0x2000103")]
		public struct AABB
		{
			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 min;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 max;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x7B951C", Offset = "0x7B951C", VA = "0x7B951C")]
		public static bool SphereCollideSphere(ref Sphere a, ref Sphere b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x7B9568", Offset = "0x7B9568", VA = "0x7B9568")]
		public static bool SphereCollideAABB(ref Sphere sphere, ref AABB aabb)
		{
			return default(bool);
		}
	}
}
namespace GestureVR
{
	[Token(Token = "0x2000104")]
	public static class GfxUtil
	{
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1228EA0", Offset = "0x1228EA0", VA = "0x1228EA0")]
		public static float Fract(float f)
		{
			return default(float);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1228EAC", Offset = "0x1228EAC", VA = "0x1228EAC")]
		public static Vector3 RGBToHSV(Color col)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1228FCC", Offset = "0x1228FCC", VA = "0x1228FCC")]
		public static Color HSVToRGB(Vector3 hsv)
		{
			return default(Color);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x122914C", Offset = "0x122914C", VA = "0x122914C")]
		public static float GammaToLinearSingle(float x)
		{
			return default(float);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1229194", Offset = "0x1229194", VA = "0x1229194")]
		public static float LinearToGammaSingle(float x)
		{
			return default(float);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x12291E8", Offset = "0x12291E8", VA = "0x12291E8")]
		public static Color GammaToLinear(Color col)
		{
			return default(Color);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x122930C", Offset = "0x122930C", VA = "0x122930C")]
		public static Color LinearToGamma(Color col)
		{
			return default(Color);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1229420", Offset = "0x1229420", VA = "0x1229420")]
		public static Vector3 BarycentricFromPoint(Vector3 p, Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x12294DC", Offset = "0x12294DC", VA = "0x12294DC")]
		public static void GenRing(List<Vector3> vertBuf, List<Color32> colBuf, List<int> indexBuf, float radius, float thickness, Vector3 startCol, Vector3 endCol, int pointCount, Vector3 posOffset, float completion = 1f)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1229840", Offset = "0x1229840", VA = "0x1229840")]
		public static void GenQuad(List<Vector3> vertBuf, List<Color32> colBuf, List<int> indexBuf, Vector3 center, Vector2 size, Color32 col)
		{
		}
	}
	[Token(Token = "0x2000105")]
	public static class Utils
	{
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1242A38", Offset = "0x1242A38", VA = "0x1242A38")]
		public static Color32 Color32FromFloat(float r, float g, float b, float a = 1f)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1242B24", Offset = "0x1242B24", VA = "0x1242B24")]
		public static int Modulo(int a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1242B5C", Offset = "0x1242B5C", VA = "0x1242B5C")]
		public static float RemapRange(float value, float oldMin, float oldMax, float newMin, float newMax)
		{
			return default(float);
		}
	}
}
namespace Performance
{
	[Token(Token = "0x2000106")]
	public class FpsToText : MonoBehaviour
	{
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool GroupSampling;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int SampleSize;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text TargetText;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int UpdateTextEvery;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int MaxTextLength;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool Smoothed;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool ForceIntResult;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool UseSystemTick;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool UseColors;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color Good;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color Okay;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Color Bad;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int OkayBelow;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int BadBelow;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected float[] FpsSamples;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected int SampleIndex;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected int TextUpdateIndex;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _fps;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int _sysLastSysTick;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _sysLastFrameRate;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _sysFrameRate;

		[Token(Token = "0x17000031")]
		public float Framerate
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x12279A8", Offset = "0x12279A8", VA = "0x12279A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x12279B0", Offset = "0x12279B0", VA = "0x12279B0", Slot = "4")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1227A2C", Offset = "0x1227A2C", VA = "0x1227A2C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1227B34", Offset = "0x1227B34", VA = "0x1227B34", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1227D60", Offset = "0x1227D60", VA = "0x1227D60", Slot = "7")]
		protected virtual void SingleFrame()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1227DF0", Offset = "0x1227DF0", VA = "0x1227DF0", Slot = "8")]
		protected virtual void Group()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1227F08", Offset = "0x1227F08", VA = "0x1227F08", Slot = "9")]
		protected virtual int GetSystemFramerate()
		{
			return default(int);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1227F5C", Offset = "0x1227F5C", VA = "0x1227F5C")]
		public FpsToText()
		{
		}
	}
}
