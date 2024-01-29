using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UltimateGameTools.MeshSimplifier;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class SimplifyMeshPreview : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000089")]
	public class ShowcaseObject
	{
		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MeshSimplify m_meshSimplify;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 m_position;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 m_angles;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 m_rotationAxis;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string m_description;

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xA7FAEC", Offset = "0xA7FAEC", VA = "0xA7FAEC")]
		public ShowcaseObject()
		{
		}
	}

	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3BF8", Offset = "0x7D3BF8")]
	private sealed class <ComputeMeshWithVertices>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SimplifyMeshPreview <>4__this;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fAmount;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<GameObject, Material[]>.Enumerator <>7__wrap1;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshSimplify <meshSimplify>5__3;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshFilter <meshFilter>5__4;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SkinnedMeshRenderer <skin>5__5;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Mesh <newMesh>5__6;

		[Token(Token = "0x170000A4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xA7FA7C", Offset = "0xA7FA7C", VA = "0xA7FA7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xA7FAE4", Offset = "0xA7FAE4", VA = "0xA7FAE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xA7F304", Offset = "0xA7F304", VA = "0xA7F304")]
		[DebuggerHidden]
		public <ComputeMeshWithVertices>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xA7F3B8", Offset = "0xA7F3B8", VA = "0xA7F3B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xA7F42C", Offset = "0xA7F42C", VA = "0xA7F42C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xA7F3D4", Offset = "0xA7F3D4", VA = "0xA7F3D4")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xA7FA84", Offset = "0xA7FA84", VA = "0xA7FA84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ShowcaseObject[] ShowcaseObjects;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material WireframeMaterial;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float MouseSensitvity;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float MouseReleaseSpeed;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<GameObject, Material[]> m_objectMaterials;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MeshSimplify m_selectedMeshSimplify;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int m_nSelectedIndex;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool m_bWireframe;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float m_fRotationSpeed;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float m_fLastMouseX;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Mesh m_newMesh;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int m_nLastProgress;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string m_strLastTitle;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string m_strLastMessage;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float m_fVertexAmount;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool m_bGUIEnabled;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xA7DA00", Offset = "0xA7DA00", VA = "0xA7DA00")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xA7DD30", Offset = "0xA7DD30", VA = "0xA7DD30")]
	private void Progress(string strTitle, string strMessage, float fT)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xA7DE00", Offset = "0xA7DE00", VA = "0xA7DE00")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xA7E2B0", Offset = "0xA7E2B0", VA = "0xA7E2B0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xA7DB50", Offset = "0xA7DB50", VA = "0xA7DB50")]
	private void SetActiveObject(int index)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xA7F160", Offset = "0xA7F160", VA = "0xA7F160")]
	private void AddMaterials(GameObject theGameObject, Dictionary<GameObject, Material[]> dicMaterials)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xA7E07C", Offset = "0xA7E07C", VA = "0xA7E07C")]
	private void SetWireframe(bool bEnabled)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xA7F0E0", Offset = "0xA7F0E0", VA = "0xA7F0E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D59B0", Offset = "0x7D59B0")]
	private IEnumerator ComputeMeshWithVertices(float fAmount)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xA7F330", Offset = "0xA7F330", VA = "0xA7F330")]
	public SimplifyMeshPreview()
	{
	}
}
[Token(Token = "0x2000003")]
public class MeshSimplify : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Mesh m_originalMesh;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Mesh m_simplifiedMesh;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public bool m_bEnablePrefabUsage;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public float m_fVertexAmount;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public string m_strAssetPath;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public MeshSimplify m_meshSimplifyRoot;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public List<MeshSimplify> m_listDependentChildren;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public bool m_bExpandRelevanceSpheres;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RelevanceSphere[] m_aRelevanceSpheres;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	[HideInInspector]
	private Simplifier m_meshSimplifier;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[HideInInspector]
	private bool m_bGenerateIncludeChildren;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	[SerializeField]
	[HideInInspector]
	private bool m_bOverrideRootSettings;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	[SerializeField]
	[HideInInspector]
	private bool m_bUseEdgeLength;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	[SerializeField]
	[HideInInspector]
	private bool m_bUseCurvature;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	[HideInInspector]
	private bool m_bProtectTexture;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	[SerializeField]
	[HideInInspector]
	private bool m_bLockBorder;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
	[SerializeField]
	[HideInInspector]
	private bool m_bDataDirty;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
	[SerializeField]
	[HideInInspector]
	private bool m_bExcludedFromTree;

	[Token(Token = "0x17000001")]
	public bool RecurseIntoChildren
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0xA79D98", Offset = "0xA79D98", VA = "0xA79D98")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000002")]
	public Simplifier MeshSimplifier
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0xA79DA0", Offset = "0xA79DA0", VA = "0xA79DA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600000C")]
		[Address(RVA = "0xA79DA8", Offset = "0xA79DA8", VA = "0xA79DA8")]
		set
		{
		}
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xA79DB0", Offset = "0xA79DB0", VA = "0xA79DB0")]
	public static bool HasValidMeshData(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xA79EA4", Offset = "0xA79EA4", VA = "0xA79EA4")]
	public static bool IsRootOrBelongsToTree(MeshSimplify meshSimplify, MeshSimplify root)
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xA7A00C", Offset = "0xA7A00C", VA = "0xA7A00C")]
	public bool IsGenerateIncludeChildrenActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xA7A014", Offset = "0xA7A014", VA = "0xA7A014")]
	public bool HasDependentChildren()
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xA7A070", Offset = "0xA7A070", VA = "0xA7A070")]
	public bool HasDataDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xA7A078", Offset = "0xA7A078", VA = "0xA7A078")]
	public bool SetDataDirty(bool bDirty)
	{
		return default(bool);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xA7A088", Offset = "0xA7A088", VA = "0xA7A088")]
	public bool HasNonMeshSimplifyGameObjectsInTree()
	{
		return default(bool);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xA7A0B8", Offset = "0xA7A0B8", VA = "0xA7A0B8")]
	private bool HasNonMeshSimplifyGameObjectsInTreeRecursive(MeshSimplify root, GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xA7A1EC", Offset = "0xA7A1EC", VA = "0xA7A1EC")]
	public void ConfigureSimplifier()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xA7A398", Offset = "0xA7A398", VA = "0xA7A398")]
	public Simplifier GetMeshSimplifier()
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xA7A3A0", Offset = "0xA7A3A0", VA = "0xA7A3A0")]
	public void ComputeData(bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xA7A3E4", Offset = "0xA7A3E4", VA = "0xA7A3E4")]
	private static void ComputeDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xA7AD64", Offset = "0xA7AD64", VA = "0xA7AD64")]
	public bool HasData()
	{
		return default(bool);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xA7AE38", Offset = "0xA7AE38", VA = "0xA7AE38")]
	public bool HasSimplifiedMesh()
	{
		return default(bool);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xA7AED4", Offset = "0xA7AED4", VA = "0xA7AED4")]
	public void ComputeMesh(bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xA7AF18", Offset = "0xA7AF18", VA = "0xA7AF18")]
	private static void ComputeMeshRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xA7B52C", Offset = "0xA7B52C", VA = "0xA7B52C")]
	public void AssignSimplifiedMesh(bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xA7B560", Offset = "0xA7B560", VA = "0xA7B560")]
	private static void AssignSimplifiedMeshRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xA7B788", Offset = "0xA7B788", VA = "0xA7B788")]
	public void RestoreOriginalMesh(bool bDeleteData, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xA7B7CC", Offset = "0xA7B7CC", VA = "0xA7B7CC")]
	private static void RestoreOriginalMeshRecursive(MeshSimplify root, GameObject gameObject, bool bDeleteData, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xA7BA3C", Offset = "0xA7BA3C", VA = "0xA7BA3C")]
	public bool HasOriginalMeshActive(bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xA7BA70", Offset = "0xA7BA70", VA = "0xA7BA70")]
	private static bool HasOriginalMeshActiveRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xA7BCEC", Offset = "0xA7BCEC", VA = "0xA7BCEC")]
	public bool HasVertexData(bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xA7BD20", Offset = "0xA7BD20", VA = "0xA7BD20")]
	private static bool HasVertexDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xA7BEB8", Offset = "0xA7BEB8", VA = "0xA7BEB8")]
	public int GetOriginalVertexCount(bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xA7BF04", Offset = "0xA7BF04", VA = "0xA7BF04")]
	private static void GetOriginalVertexCountRecursive(MeshSimplify root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xA7C090", Offset = "0xA7C090", VA = "0xA7C090")]
	public int GetOriginalTriangleCount(bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xA7C0DC", Offset = "0xA7C0DC", VA = "0xA7C0DC")]
	private static void GetOriginalTriangleCountRecursive(MeshSimplify root, GameObject gameObject, ref int nTriangleCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xA7C288", Offset = "0xA7C288", VA = "0xA7C288")]
	public int GetSimplifiedVertexCount(bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xA7C2D4", Offset = "0xA7C2D4", VA = "0xA7C2D4")]
	private static void GetSimplifiedVertexCountRecursive(MeshSimplify root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xA7C460", Offset = "0xA7C460", VA = "0xA7C460")]
	public int GetSimplifiedTriangleCount(bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xA7C4AC", Offset = "0xA7C4AC", VA = "0xA7C4AC")]
	private static void GetSimplifiedTriangleCountRecursive(MeshSimplify root, GameObject gameObject, ref int nTriangleCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xA7C658", Offset = "0xA7C658", VA = "0xA7C658")]
	public void RemoveFromTree()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xA7AC8C", Offset = "0xA7AC8C", VA = "0xA7AC8C")]
	public void FreeData(bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xA7C720", Offset = "0xA7C720", VA = "0xA7C720")]
	private static void FreeDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xA7B398", Offset = "0xA7B398", VA = "0xA7B398")]
	private static Mesh CreateNewEmptyMesh(MeshSimplify meshSimplify)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xA7C97C", Offset = "0xA7C97C", VA = "0xA7C97C")]
	public MeshSimplify()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D2E5C", Offset = "0x7D2E5C")]
public class RuntimeMeshSimplifier : MonoBehaviour
{
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3C08", Offset = "0x7D3C08")]
	private sealed class <ComputeMeshWithVertices>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RuntimeMeshSimplifier <>4__this;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fAmount;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<GameObject, Material[]>.Enumerator <>7__wrap1;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private KeyValuePair<GameObject, Material[]> <pair>5__3;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MeshSimplify <meshSimplify>5__4;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MeshFilter <meshFilter>5__5;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private SkinnedMeshRenderer <skin>5__6;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Mesh <newMesh>5__7;

		[Token(Token = "0x170000A6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0xA7D990", Offset = "0xA7D990", VA = "0xA7D990", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0xA7D9F8", Offset = "0xA7D9F8", VA = "0xA7D9F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xA7CEC0", Offset = "0xA7CEC0", VA = "0xA7CEC0")]
		[DebuggerHidden]
		public <ComputeMeshWithVertices>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xA7CF4C", Offset = "0xA7CF4C", VA = "0xA7CF4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xA7CFD0", Offset = "0xA7CFD0", VA = "0xA7CFD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xA7CF78", Offset = "0xA7CF78", VA = "0xA7CF78")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xA7D998", Offset = "0xA7D998", VA = "0xA7D998", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<GameObject, Material[]> m_objectMaterials;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshSimplify m_selectedMeshSimplify;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_bFinished;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Mesh m_newMesh;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_nLastProgress;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string m_strLastTitle;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string m_strLastMessage;

	[Token(Token = "0x17000003")]
	public string ProgressTitle
	{
		[Token(Token = "0x6000032")]
		[Address(RVA = "0xA7CA38", Offset = "0xA7CA38", VA = "0xA7CA38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public string ProgressMessage
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0xA7CA40", Offset = "0xA7CA40", VA = "0xA7CA40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	public int ProgressPercent
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0xA7CA48", Offset = "0xA7CA48", VA = "0xA7CA48")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public bool Finished
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0xA7CA50", Offset = "0xA7CA50", VA = "0xA7CA50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xA7CA58", Offset = "0xA7CA58", VA = "0xA7CA58")]
	public void Simplify(float percent)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xA7CB84", Offset = "0xA7CB84", VA = "0xA7CB84")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xA7CC2C", Offset = "0xA7CC2C", VA = "0xA7CC2C")]
	private void AddMaterials(GameObject theGameObject, Dictionary<GameObject, Material[]> dicMaterials)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xA7CDF0", Offset = "0xA7CDF0", VA = "0xA7CDF0")]
	private void Progress(string strTitle, string strMessage, float fT)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xA7CB04", Offset = "0xA7CB04", VA = "0xA7CB04")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D5A14", Offset = "0x7D5A14")]
	private IEnumerator ComputeMeshWithVertices(float fAmount)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xA7CEEC", Offset = "0xA7CEEC", VA = "0xA7CEEC")]
	public RuntimeMeshSimplifier()
	{
	}
}
[Token(Token = "0x2000005")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xA6A340", Offset = "0xA6A340", VA = "0xA6A340")]
	public void Start()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xA6A4F0", Offset = "0xA6A4F0", VA = "0xA6A4F0", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xA6A7FC", Offset = "0xA6A7FC", VA = "0xA6A7FC")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000006")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x600003F")]
	[Address(RVA = "0xA6A804", Offset = "0xA6A804", VA = "0xA6A804")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xA6A8E0", Offset = "0xA6A8E0", VA = "0xA6A8E0")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D2EC0", Offset = "0x7D2EC0")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x6000041")]
	[Address(RVA = "0xA6A8E8", Offset = "0xA6A8E8", VA = "0xA6A8E8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xA6A984", Offset = "0xA6A984", VA = "0xA6A984")]
	public ForcedReset()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000008")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x200008C")]
		public enum Mode
		{
			[Token(Token = "0x4000387")]
			Trigger,
			[Token(Token = "0x4000388")]
			Replace,
			[Token(Token = "0x4000389")]
			Activate,
			[Token(Token = "0x400038A")]
			Enable,
			[Token(Token = "0x400038B")]
			Animate,
			[Token(Token = "0x400038C")]
			Deactivate
		}

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xA64080", Offset = "0xA64080", VA = "0xA64080")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xA644E8", Offset = "0xA644E8", VA = "0xA644E8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xA644EC", Offset = "0xA644EC", VA = "0xA644EC")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008D")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0xA64E6C", Offset = "0xA64E6C", VA = "0xA64E6C")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008E")]
		public class ReplacementList
		{
			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0xA64E74", Offset = "0xA64E74", VA = "0xA64E74")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xA64504", Offset = "0xA64504", VA = "0xA64504")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xA64E64", Offset = "0xA64E64", VA = "0xA64E64")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008F")]
		public class Vector3andSpace
		{
			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0xA65044", Offset = "0xA65044", VA = "0xA65044")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xA64ED4", Offset = "0xA64ED4", VA = "0xA64ED4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xA64EFC", Offset = "0xA64EFC", VA = "0xA64EFC")]
		private void Update()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xA6503C", Offset = "0xA6503C", VA = "0xA6503C")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class CameraRefocus
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xA65054", Offset = "0xA65054", VA = "0xA65054")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xA650B4", Offset = "0xA650B4", VA = "0xA650B4")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xA650BC", Offset = "0xA650BC", VA = "0xA650BC")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xA650C4", Offset = "0xA650C4", VA = "0xA650C4")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xA65224", Offset = "0xA65224", VA = "0xA65224")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class CurveControlledBob
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xA59C90", Offset = "0xA59C90", VA = "0xA59C90")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xA5A9F4", Offset = "0xA5A9F4", VA = "0xA5A9F4")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xA5B168", Offset = "0xA5B168", VA = "0xA5B168")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3C18", Offset = "0x7D3C18")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x170000A8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003F7")]
				[Address(RVA = "0xA65984", Offset = "0xA65984", VA = "0xA65984", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003F9")]
				[Address(RVA = "0xA659EC", Offset = "0xA659EC", VA = "0xA659EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0xA6570C", Offset = "0xA6570C", VA = "0xA6570C")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xA65740", Offset = "0xA65740", VA = "0xA65740", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xA65744", Offset = "0xA65744", VA = "0xA65744", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0xA6598C", Offset = "0xA6598C", VA = "0xA6598C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000043")]
		private const float k_Spring = 50f;

		[Token(Token = "0x4000044")]
		private const float k_Damper = 5f;

		[Token(Token = "0x4000045")]
		private const float k_Drag = 10f;

		[Token(Token = "0x4000046")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x4000047")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x4000048")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xA65278", Offset = "0xA65278", VA = "0xA65278")]
		private void Update()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xA6568C", Offset = "0xA6568C", VA = "0xA6568C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D5A78", Offset = "0x7D5A78")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xA655DC", Offset = "0xA655DC", VA = "0xA655DC")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xA65738", Offset = "0xA65738", VA = "0xA65738")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xA659F4", Offset = "0xA659F4", VA = "0xA659F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xA65A28", Offset = "0xA65A28", VA = "0xA65A28")]
		private void Update()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xA65C9C", Offset = "0xA65C9C", VA = "0xA65C9C")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class FOVKick
	{
		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3C28", Offset = "0x7D3C28")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x170000AA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003FD")]
				[Address(RVA = "0xA6615C", Offset = "0xA6615C", VA = "0xA6615C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003FF")]
				[Address(RVA = "0xA661C4", Offset = "0xA661C4", VA = "0xA661C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0xA65DB8", Offset = "0xA65DB8", VA = "0xA65DB8")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0xA65FF8", Offset = "0xA65FF8", VA = "0xA65FF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xA65FFC", Offset = "0xA65FFC", VA = "0xA65FFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xA66164", Offset = "0xA66164", VA = "0xA66164", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3C38", Offset = "0x7D3C38")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x170000AC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000403")]
				[Address(RVA = "0xA65F88", Offset = "0xA65F88", VA = "0xA65F88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000405")]
				[Address(RVA = "0xA65FF0", Offset = "0xA65FF0", VA = "0xA65FF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000400")]
			[Address(RVA = "0xA65DE4", Offset = "0xA65DE4", VA = "0xA65DE4")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0xA65E10", Offset = "0xA65E10", VA = "0xA65E10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000402")]
			[Address(RVA = "0xA65E14", Offset = "0xA65E14", VA = "0xA65E14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000404")]
			[Address(RVA = "0xA65F90", Offset = "0xA65F90", VA = "0xA65F90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xA59C50", Offset = "0xA59C50", VA = "0xA59C50")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xA65CD0", Offset = "0xA65CD0", VA = "0xA65CD0")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xA65DB0", Offset = "0xA65DB0", VA = "0xA65DB0")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xA5AB84", Offset = "0xA5AB84", VA = "0xA5AB84")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D5ADC", Offset = "0x7D5ADC")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xA5AB14", Offset = "0xA5AB14", VA = "0xA5AB14")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D5B40", Offset = "0x7D5B40")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xA5B14C", Offset = "0xA5B14C", VA = "0xA5B14C")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D2F24", Offset = "0x7D2F24")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x400005B")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x400005F")]
		private const string display = "{0} FPS";

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xA661CC", Offset = "0xA661CC", VA = "0xA661CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xA66238", Offset = "0xA66238", VA = "0xA66238")]
		private void Update()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xA6631C", Offset = "0xA6631C", VA = "0xA6631C")]
		public FPSCounter()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xA66324", Offset = "0xA66324", VA = "0xA66324")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xA66404", Offset = "0xA66404", VA = "0xA66404")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3C48", Offset = "0x7D3C48")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x170000AE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000409")]
				[Address(RVA = "0xA6667C", Offset = "0xA6667C", VA = "0xA6667C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600040B")]
				[Address(RVA = "0xA666E4", Offset = "0xA666E4", VA = "0xA666E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000406")]
			[Address(RVA = "0xA6646C", Offset = "0xA6646C", VA = "0xA6646C")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0xA66498", Offset = "0xA66498", VA = "0xA66498", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000408")]
			[Address(RVA = "0xA6649C", Offset = "0xA6649C", VA = "0xA6649C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600040A")]
			[Address(RVA = "0xA66684", Offset = "0xA66684", VA = "0xA66684", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xA66464", Offset = "0xA66464", VA = "0xA66464")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xA59F70", Offset = "0xA59F70", VA = "0xA59F70")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D5BA4", Offset = "0x7D5BA4")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xA5B3A8", Offset = "0xA5B3A8", VA = "0xA5B3A8")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3C58", Offset = "0x7D3C58")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x170000B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600040F")]
				[Address(RVA = "0xA66AC0", Offset = "0xA66AC0", VA = "0xA66AC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000411")]
				[Address(RVA = "0xA66B28", Offset = "0xA66B28", VA = "0xA66B28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0xA66858", Offset = "0xA66858", VA = "0xA66858")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0xA6688C", Offset = "0xA6688C", VA = "0xA6688C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600040E")]
			[Address(RVA = "0xA66890", Offset = "0xA66890", VA = "0xA66890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000410")]
			[Address(RVA = "0xA66AC8", Offset = "0xA66AC8", VA = "0xA66AC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xA666EC", Offset = "0xA666EC", VA = "0xA666EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xA63444", Offset = "0xA63444", VA = "0xA63444")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xA667D8", Offset = "0xA667D8", VA = "0xA667D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D5C08", Offset = "0x7D5C08")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xA66884", Offset = "0xA66884", VA = "0xA66884")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3C68", Offset = "0x7D3C68")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x170000B2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000415")]
				[Address(RVA = "0xA66F24", Offset = "0xA66F24", VA = "0xA66F24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000417")]
				[Address(RVA = "0xA66F8C", Offset = "0xA66F8C", VA = "0xA66F8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000412")]
			[Address(RVA = "0xA66BA0", Offset = "0xA66BA0", VA = "0xA66BA0")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0xA66BEC", Offset = "0xA66BEC", VA = "0xA66BEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0xA66BF0", Offset = "0xA66BF0", VA = "0xA66BF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0xA66F2C", Offset = "0xA66F2C", VA = "0xA66F2C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xA66B30", Offset = "0xA66B30", VA = "0xA66B30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D5C6C", Offset = "0x7D5C6C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xA66BCC", Offset = "0xA66BCC", VA = "0xA66BCC")]
		public void Stop()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xA66BD8", Offset = "0xA66BD8", VA = "0xA66BD8")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000096")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x40003AF")]
			Standalone,
			[Token(Token = "0x40003B0")]
			Mobile
		}

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xA66F94", Offset = "0xA66F94", VA = "0xA66F94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xA66F98", Offset = "0xA66F98", VA = "0xA66F98")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xA66FB4", Offset = "0xA66FB4", VA = "0xA66FB4")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xA67320", Offset = "0xA67320", VA = "0xA67320")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] objects;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentActiveObject;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xA67398", Offset = "0xA67398", VA = "0xA67398")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xA673A0", Offset = "0xA673A0", VA = "0xA673A0")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xA6743C", Offset = "0xA6743C", VA = "0xA6743C")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xA67444", Offset = "0xA67444", VA = "0xA67444")]
		private void Start()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xA67480", Offset = "0xA67480", VA = "0xA67480")]
		private void Update()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xA678B4", Offset = "0xA678B4", VA = "0xA678B4")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xA67974", Offset = "0xA67974", VA = "0xA67974")]
		private void Start()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xA67978", Offset = "0xA67978", VA = "0xA67978")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xA67CA4", Offset = "0xA67CA4", VA = "0xA67CA4")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000097")]
		public enum Action
		{
			[Token(Token = "0x40003B2")]
			Activate,
			[Token(Token = "0x40003B3")]
			Deactivate,
			[Token(Token = "0x40003B4")]
			Destroy,
			[Token(Token = "0x40003B5")]
			ReloadLevel,
			[Token(Token = "0x40003B6")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000098")]
		public class Entry
		{
			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000418")]
			[Address(RVA = "0xA683EC", Offset = "0xA683EC", VA = "0xA683EC")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000099")]
		public class Entries
		{
			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000419")]
			[Address(RVA = "0xA68020", Offset = "0xA68020", VA = "0xA68020")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3C78", Offset = "0x7D3C78")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170000B4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600041D")]
				[Address(RVA = "0xA680F4", Offset = "0xA680F4", VA = "0xA680F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600041F")]
				[Address(RVA = "0xA6815C", Offset = "0xA6815C", VA = "0xA6815C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041A")]
			[Address(RVA = "0xA67F34", Offset = "0xA67F34", VA = "0xA67F34")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0xA68028", Offset = "0xA68028", VA = "0xA68028", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600041C")]
			[Address(RVA = "0xA6802C", Offset = "0xA6802C", VA = "0xA6802C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0xA680FC", Offset = "0xA680FC", VA = "0xA680FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3C88", Offset = "0x7D3C88")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170000B6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000423")]
				[Address(RVA = "0xA68230", Offset = "0xA68230", VA = "0xA68230", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000425")]
				[Address(RVA = "0xA68298", Offset = "0xA68298", VA = "0xA68298", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0xA67F60", Offset = "0xA67F60", VA = "0xA67F60")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0xA68164", Offset = "0xA68164", VA = "0xA68164", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0xA68168", Offset = "0xA68168", VA = "0xA68168", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0xA68238", Offset = "0xA68238", VA = "0xA68238", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3C98", Offset = "0x7D3C98")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170000B8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000429")]
				[Address(RVA = "0xA6837C", Offset = "0xA6837C", VA = "0xA6837C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600042B")]
				[Address(RVA = "0xA683E4", Offset = "0xA683E4", VA = "0xA683E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0xA67F8C", Offset = "0xA67F8C", VA = "0xA67F8C")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0xA682A0", Offset = "0xA682A0", VA = "0xA682A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0xA682A4", Offset = "0xA682A4", VA = "0xA682A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600042A")]
			[Address(RVA = "0xA68384", Offset = "0xA68384", VA = "0xA68384", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xA67CB8", Offset = "0xA67CB8", VA = "0xA67CB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xA67DE4", Offset = "0xA67DE4", VA = "0xA67DE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D5CD0", Offset = "0x7D5CD0")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xA67E54", Offset = "0xA67E54", VA = "0xA67E54")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D5D34", Offset = "0x7D5D34")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xA67EC4", Offset = "0xA67EC4", VA = "0xA67EC4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D5D98", Offset = "0x7D5D98")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xA67FB8", Offset = "0xA67FB8", VA = "0xA67FB8")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xA683F4", Offset = "0xA683F4", VA = "0xA683F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xA6844C", Offset = "0xA6844C", VA = "0xA6844C")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xA684EC", Offset = "0xA684EC", VA = "0xA684EC")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009D")]
		public class WaypointList
		{
			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x600042C")]
			[Address(RVA = "0xCE3DF0", Offset = "0xCE3DF0", VA = "0xCE3DF0")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x200009E")]
		public struct RoutePoint
		{
			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x600042D")]
			[Address(RVA = "0x6D88E0", Offset = "0x6D88E0", VA = "0x6D88E0")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D40A0", Offset = "0x7D40A0")]
		private float <Length>k__BackingField;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000007")]
		public float Length
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xA684FC", Offset = "0xA684FC", VA = "0xA684FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5DFC", Offset = "0x7D5DFC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0xA68504", Offset = "0xA68504", VA = "0xA68504")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5E0C", Offset = "0x7D5E0C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0xA6850C", Offset = "0xA6850C", VA = "0xA6850C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xA68528", Offset = "0xA68528", VA = "0xA68528")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xA68850", Offset = "0xA68850", VA = "0xA68850")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xA68980", Offset = "0xA68980", VA = "0xA68980")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xA68CD8", Offset = "0xA68CD8", VA = "0xA68CD8")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xA68584", Offset = "0xA68584", VA = "0xA68584")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xA69040", Offset = "0xA69040", VA = "0xA69040")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xA692C0", Offset = "0xA692C0", VA = "0xA692C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xA69048", Offset = "0xA69048", VA = "0xA69048")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xA692C8", Offset = "0xA692C8", VA = "0xA692C8")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x200009F")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40003C9")]
			SmoothAlongRoute,
			[Token(Token = "0x40003CA")]
			PointToPoint
		}

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4120", Offset = "0x7D4120")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4130", Offset = "0x7D4130")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4140", Offset = "0x7D4140")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000009")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xCE3E50", Offset = "0xCE3E50", VA = "0xCE3E50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5E1C", Offset = "0x7D5E1C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0xCE3E64", Offset = "0xCE3E64", VA = "0xCE3E64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5E2C", Offset = "0x7D5E2C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0xCE3E78", Offset = "0xCE3E78", VA = "0xCE3E78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5E3C", Offset = "0x7D5E3C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0xCE3E8C", Offset = "0xCE3E8C", VA = "0xCE3E8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5E4C", Offset = "0x7D5E4C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0xCE3EA0", Offset = "0xCE3EA0", VA = "0xCE3EA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5E5C", Offset = "0x7D5E5C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000095")]
			[Address(RVA = "0xCE3EB4", Offset = "0xCE3EB4", VA = "0xCE3EB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5E6C", Offset = "0x7D5E6C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xCE3EC8", Offset = "0xCE3EC8", VA = "0xCE3EC8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xCE3FAC", Offset = "0xCE3FAC", VA = "0xCE3FAC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xCE4088", Offset = "0xCE4088", VA = "0xCE4088")]
		private void Update()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xCE45F0", Offset = "0xCE45F0", VA = "0xCE45F0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xCE47CC", Offset = "0xCE47CC", VA = "0xCE47CC")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D2F88", Offset = "0x7D2F88")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xA618D8", Offset = "0xA618D8", VA = "0xA618D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xA61970", Offset = "0xA61970", VA = "0xA61970")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xA61E1C", Offset = "0xA61E1C", VA = "0xA61E1C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xA62360", Offset = "0xA62360", VA = "0xA62360")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3CA8", Offset = "0x7D3CA8")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x170000BA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000431")]
				[Address(RVA = "0xA62B8C", Offset = "0xA62B8C", VA = "0xA62B8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000433")]
				[Address(RVA = "0xA62BF4", Offset = "0xA62BF4", VA = "0xA62BF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600042E")]
			[Address(RVA = "0xA623E4", Offset = "0xA623E4", VA = "0xA623E4")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600042F")]
			[Address(RVA = "0xA6259C", Offset = "0xA6259C", VA = "0xA6259C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000430")]
			[Address(RVA = "0xA625A0", Offset = "0xA625A0", VA = "0xA625A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0xA62B94", Offset = "0xA62B94", VA = "0xA62B94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xA62374", Offset = "0xA62374", VA = "0xA62374")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D5E7C", Offset = "0x7D5E7C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xA62410", Offset = "0xA62410", VA = "0xA62410")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xA62594", Offset = "0xA62594", VA = "0xA62594")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3CB8", Offset = "0x7D3CB8")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000437")]
				[Address(RVA = "0xA62FB0", Offset = "0xA62FB0", VA = "0xA62FB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000439")]
				[Address(RVA = "0xA63018", Offset = "0xA63018", VA = "0xA63018", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0xA62C6C", Offset = "0xA62C6C", VA = "0xA62C6C")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0xA62CA8", Offset = "0xA62CA8", VA = "0xA62CA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0xA62CAC", Offset = "0xA62CAC", VA = "0xA62CAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0xA62FB8", Offset = "0xA62FB8", VA = "0xA62FB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xA62BFC", Offset = "0xA62BFC", VA = "0xA62BFC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D5EE0", Offset = "0x7D5EE0")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xA62C98", Offset = "0xA62C98", VA = "0xA62C98")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3CC8", Offset = "0x7D3CC8")]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x170000BE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600043D")]
				[Address(RVA = "0xA63470", Offset = "0xA63470", VA = "0xA63470", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600043F")]
				[Address(RVA = "0xA634D8", Offset = "0xA634D8", VA = "0xA634D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0xA630F4", Offset = "0xA630F4", VA = "0xA630F4")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0xA6314C", Offset = "0xA6314C", VA = "0xA6314C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0xA63150", Offset = "0xA63150", VA = "0xA63150", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0xA63478", Offset = "0xA63478", VA = "0xA63478", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xA63020", Offset = "0xA63020", VA = "0xA63020")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xA63078", Offset = "0xA63078", VA = "0xA63078")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D5F44", Offset = "0x7D5F44")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xA63120", Offset = "0xA63120", VA = "0xA63120")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xA63128", Offset = "0xA63128", VA = "0xA63128")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xA634E0", Offset = "0xA634E0", VA = "0xA634E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xA63538", Offset = "0xA63538", VA = "0xA63538")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xA635C4", Offset = "0xA635C4", VA = "0xA635C4")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xA635D4", Offset = "0xA635D4", VA = "0xA635D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xA63644", Offset = "0xA63644", VA = "0xA63644")]
		private void Update()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xA638A4", Offset = "0xA638A4", VA = "0xA638A4")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xA638CC", Offset = "0xA638CC", VA = "0xA638CC")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xA638DC", Offset = "0xA638DC", VA = "0xA638DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xA63AA0", Offset = "0xA63AA0", VA = "0xA63AA0")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xA63ABC", Offset = "0xA63ABC", VA = "0xA63ABC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xA63C48", Offset = "0xA63C48", VA = "0xA63C48")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xA63C58", Offset = "0xA63C58", VA = "0xA63C58")]
		private void Start()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xA63D18", Offset = "0xA63D18", VA = "0xA63D18")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xA63D20", Offset = "0xA63D20", VA = "0xA63D20")]
		private void Start()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xA63D78", Offset = "0xA63D78", VA = "0xA63D78")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xA64008", Offset = "0xA64008", VA = "0xA64008")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xCEF350", Offset = "0xCEF350", VA = "0xCEF350")]
		private void Update()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xCEF594", Offset = "0xCEF594", VA = "0xCEF594")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D2FFC", Offset = "0x7D2FFC")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xCEB180", Offset = "0xCEB180", VA = "0xCEB180")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xCEB1A4", Offset = "0xCEB1A4", VA = "0xCEB1A4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xCEB204", Offset = "0xCEB204", VA = "0xCEB204")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xCEB264", Offset = "0xCEB264", VA = "0xCEB264")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3070", Offset = "0x7D3070")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xCEB26C", Offset = "0xCEB26C", VA = "0xCEB26C")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class MeshContainer
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xCEB274", Offset = "0xCEB274", VA = "0xCEB274")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xCEB2C8", Offset = "0xCEB2C8", VA = "0xCEB2C8")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D30E4", Offset = "0x7D30E4")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xCEB30C", Offset = "0xCEB30C", VA = "0xCEB30C")]
		public void Start()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xCEB3FC", Offset = "0xCEB3FC", VA = "0xCEB3FC")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xCEB704", Offset = "0xCEB704", VA = "0xCEB704")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xCEB7B8", Offset = "0xCEB7B8", VA = "0xCEB7B8")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xCEB8C0", Offset = "0xCEB8C0", VA = "0xCEB8C0")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xCEC188", Offset = "0xCEC188", VA = "0xCEC188")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xCEC1E8", Offset = "0xCEC1E8", VA = "0xCEC1E8")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xCEC2E0", Offset = "0xCEC2E0", VA = "0xCEC2E0")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xCEC340", Offset = "0xCEC340", VA = "0xCEC340")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xCEBA28", Offset = "0xCEBA28", VA = "0xCEBA28")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xCEC3A0", Offset = "0xCEC3A0", VA = "0xCEC3A0")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xCEC8A0", Offset = "0xCEC8A0", VA = "0xCEC8A0")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xCEC404", Offset = "0xCEC404", VA = "0xCEC404")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xCECAD8", Offset = "0xCECAD8", VA = "0xCECAD8")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xCEC6BC", Offset = "0xCEC6BC", VA = "0xCEC6BC")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xCECAF8", Offset = "0xCECAF8", VA = "0xCECAF8")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3158", Offset = "0x7D3158")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xCECB6C", Offset = "0xCECB6C", VA = "0xCECB6C")]
		public void Start()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xCECC58", Offset = "0xCECC58", VA = "0xCECC58")]
		public void Update()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xCECE80", Offset = "0xCECE80", VA = "0xCECE80")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x20000A3")]
		public enum WaterMode
		{
			[Token(Token = "0x40003D7")]
			Simple,
			[Token(Token = "0x40003D8")]
			Reflective,
			[Token(Token = "0x40003D9")]
			Refractive
		}

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xCECE88", Offset = "0xCECE88", VA = "0xCECE88")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xCEEA2C", Offset = "0xCEEA2C", VA = "0xCEEA2C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xCEED18", Offset = "0xCEED18", VA = "0xCEED18")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xCEE348", Offset = "0xCEE348", VA = "0xCEE348")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xCED940", Offset = "0xCED940", VA = "0xCED940")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xCED92C", Offset = "0xCED92C", VA = "0xCED92C")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xCED7E4", Offset = "0xCED7E4", VA = "0xCED7E4")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xCEE848", Offset = "0xCEE848", VA = "0xCEE848")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xCEE5A4", Offset = "0xCEE5A4", VA = "0xCEE5A4")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xCEEFA4", Offset = "0xCEEFA4", VA = "0xCEEFA4")]
		public Water()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public enum WaterQuality
	{
		[Token(Token = "0x40000E5")]
		High = 2,
		[Token(Token = "0x40000E6")]
		Medium = 1,
		[Token(Token = "0x40000E7")]
		Low = 0
	}
	[Token(Token = "0x200002F")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xCEF080", Offset = "0xCEF080", VA = "0xCEF080")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xCEF200", Offset = "0xCEF200", VA = "0xCEF200")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xCEF2B4", Offset = "0xCEF2B4", VA = "0xCEF2B4")]
		public void Update()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xCEF338", Offset = "0xCEF338", VA = "0xCEF338")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xCEF59C", Offset = "0xCEF59C", VA = "0xCEF59C")]
		public void Start()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xCEF5A0", Offset = "0xCEF5A0", VA = "0xCEF5A0")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xCEF744", Offset = "0xCEF744", VA = "0xCEF744")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xCEF84C", Offset = "0xCEF84C", VA = "0xCEF84C")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000031")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xA5DE6C", Offset = "0xA5DE6C", VA = "0xA5DE6C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xA5E0FC", Offset = "0xA5E0FC", VA = "0xA5E0FC")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xA5E27C", Offset = "0xA5E27C", VA = "0xA5E27C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xA5E2FC", Offset = "0xA5E2FC", VA = "0xA5E2FC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xA5E3E4", Offset = "0xA5E3E4", VA = "0xA5E3E4", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xA5E48C", Offset = "0xA5E48C", VA = "0xA5E48C")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xA5E4F8", Offset = "0xA5E4F8", VA = "0xA5E4F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xA5E4FC", Offset = "0xA5E4FC", VA = "0xA5E4FC")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xA5E5E4", Offset = "0xA5E5E4", VA = "0xA5E5E4")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xA5E6CC", Offset = "0xA5E6CC", VA = "0xA5E6CC")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xA5E7B4", Offset = "0xA5E7B4", VA = "0xA5E7B4")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xA5E89C", Offset = "0xA5E89C", VA = "0xA5E89C")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xA5E984", Offset = "0xA5E984", VA = "0xA5E984")]
		public void Update()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xA5E988", Offset = "0xA5E988", VA = "0xA5E988")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x20000A4")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x40003DB")]
			Hardware,
			[Token(Token = "0x40003DC")]
			Touch
		}

		[Token(Token = "0x20000A5")]
		public class VirtualAxis
		{
			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D58E8", Offset = "0x7D58E8")]
			private string <name>k__BackingField;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D58F8", Offset = "0x7D58F8")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x170000C0")]
			public string name
			{
				[Token(Token = "0x6000440")]
				[Address(RVA = "0xA5F7F0", Offset = "0xA5F7F0", VA = "0xA5F7F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6B80", Offset = "0x7D6B80")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000441")]
				[Address(RVA = "0xA5F7F8", Offset = "0xA5F7F8", VA = "0xA5F7F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6B90", Offset = "0x7D6B90")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000442")]
				[Address(RVA = "0xA5F800", Offset = "0xA5F800", VA = "0xA5F800")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6BA0", Offset = "0x7D6BA0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000443")]
				[Address(RVA = "0xA5F808", Offset = "0xA5F808", VA = "0xA5F808")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6BB0", Offset = "0x7D6BB0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			public float GetValue
			{
				[Token(Token = "0x6000448")]
				[Address(RVA = "0xA5F85C", Offset = "0xA5F85C", VA = "0xA5F85C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C3")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000449")]
				[Address(RVA = "0xA5F864", Offset = "0xA5F864", VA = "0xA5F864")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0xA5DFD8", Offset = "0xA5DFD8", VA = "0xA5DFD8")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0xA5F814", Offset = "0xA5F814", VA = "0xA5F814")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000446")]
			[Address(RVA = "0xA5E294", Offset = "0xA5E294", VA = "0xA5E294")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0xA5F854", Offset = "0xA5F854", VA = "0xA5F854")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x20000A6")]
		public class VirtualButton
		{
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5908", Offset = "0x7D5908")]
			private string <name>k__BackingField;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5918", Offset = "0x7D5918")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x170000C4")]
			public string name
			{
				[Token(Token = "0x600044A")]
				[Address(RVA = "0xA5F86C", Offset = "0xA5F86C", VA = "0xA5F86C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6BC0", Offset = "0x7D6BC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600044B")]
				[Address(RVA = "0xA5F874", Offset = "0xA5F874", VA = "0xA5F874")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6BD0", Offset = "0x7D6BD0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C5")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0xA5F87C", Offset = "0xA5F87C", VA = "0xA5F87C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6BE0", Offset = "0x7D6BE0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600044D")]
				[Address(RVA = "0xA5F884", Offset = "0xA5F884", VA = "0xA5F884")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6BF0", Offset = "0x7D6BF0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C6")]
			public bool GetButton
			{
				[Token(Token = "0x6000453")]
				[Address(RVA = "0xA5F9E4", Offset = "0xA5F9E4", VA = "0xA5F9E4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000C7")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000454")]
				[Address(RVA = "0xA5F9EC", Offset = "0xA5F9EC", VA = "0xA5F9EC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000C8")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0xA5FA1C", Offset = "0xA5FA1C", VA = "0xA5FA1C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0xA5F890", Offset = "0xA5F890", VA = "0xA5F890")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0xA5F8CC", Offset = "0xA5F8CC", VA = "0xA5F8CC")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0xA5F914", Offset = "0xA5F914", VA = "0xA5F914")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0xA5F950", Offset = "0xA5F950", VA = "0xA5F950")]
			public void Released()
			{
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0xA5F97C", Offset = "0xA5F97C", VA = "0xA5F97C")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x1700000C")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0xA5F470", Offset = "0xA5F470", VA = "0xA5F470")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xA5E990", Offset = "0xA5E990", VA = "0xA5E990")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xA5EA30", Offset = "0xA5EA30", VA = "0xA5EA30")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xA5DF60", Offset = "0xA5DF60", VA = "0xA5DF60")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xA5EB48", Offset = "0xA5EB48", VA = "0xA5EB48")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xA5E00C", Offset = "0xA5E00C", VA = "0xA5E00C")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xA5ED50", Offset = "0xA5ED50", VA = "0xA5ED50")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xA5EEF0", Offset = "0xA5EEF0", VA = "0xA5EEF0")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xA5F040", Offset = "0xA5F040", VA = "0xA5F040")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xA5E084", Offset = "0xA5E084", VA = "0xA5E084")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xA5889C", Offset = "0xA5889C", VA = "0xA5889C")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xA5F274", Offset = "0xA5F274", VA = "0xA5F274")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xA5F1E4", Offset = "0xA5F1E4", VA = "0xA5F1E4")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xA5F2DC", Offset = "0xA5F2DC", VA = "0xA5F2DC")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xA59EF0", Offset = "0xA59EF0", VA = "0xA59EF0")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xA5F35C", Offset = "0xA5F35C", VA = "0xA5F35C")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xA5E564", Offset = "0xA5E564", VA = "0xA5E564")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xA5E64C", Offset = "0xA5E64C", VA = "0xA5E64C")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xA5E734", Offset = "0xA5E734", VA = "0xA5E734")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xA5E904", Offset = "0xA5E904", VA = "0xA5E904")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xA5E81C", Offset = "0xA5E81C", VA = "0xA5E81C")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xA5F3DC", Offset = "0xA5F3DC", VA = "0xA5F3DC")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xA5F4EC", Offset = "0xA5F4EC", VA = "0xA5F4EC")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xA5F5E8", Offset = "0xA5F5E8", VA = "0xA5F5E8")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xA5F6F0", Offset = "0xA5F6F0", VA = "0xA5F6F0")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xA5FA4C", Offset = "0xA5FA4C", VA = "0xA5FA4C")]
		private void Update()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xA5FA50", Offset = "0xA5FA50", VA = "0xA5FA50")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xA5FAD0", Offset = "0xA5FAD0", VA = "0xA5FAD0")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x20000A7")]
		public enum AxisOption
		{
			[Token(Token = "0x40003E6")]
			Both,
			[Token(Token = "0x40003E7")]
			OnlyHorizontal,
			[Token(Token = "0x40003E8")]
			OnlyVertical
		}

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xA5FAD8", Offset = "0xA5FAD8", VA = "0xA5FAD8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xA5FC18", Offset = "0xA5FC18", VA = "0xA5FC18")]
		private void Start()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xA5FC54", Offset = "0xA5FC54", VA = "0xA5FC54")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xA5FADC", Offset = "0xA5FADC", VA = "0xA5FADC")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xA5FD44", Offset = "0xA5FD44", VA = "0xA5FD44", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xA5FF04", Offset = "0xA5FF04", VA = "0xA5FF04", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xA5FF4C", Offset = "0xA5FF4C", VA = "0xA5FF4C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xA5FF50", Offset = "0xA5FF50", VA = "0xA5FF50")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xA5FFA0", Offset = "0xA5FFA0", VA = "0xA5FFA0")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0xA60010", Offset = "0xA60010", VA = "0xA60010")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xA60020", Offset = "0xA60020", VA = "0xA60020")]
		private void Start()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xA60018", Offset = "0xA60018", VA = "0xA60018")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xA600FC", Offset = "0xA600FC", VA = "0xA600FC")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xA60378", Offset = "0xA60378", VA = "0xA60378")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x20000A8")]
		public enum AxisOptions
		{
			[Token(Token = "0x40003EA")]
			ForwardAxis,
			[Token(Token = "0x40003EB")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x20000A9")]
		public class AxisMapping
		{
			[Token(Token = "0x20000D1")]
			public enum MappingType
			{
				[Token(Token = "0x400049D")]
				NamedAxis,
				[Token(Token = "0x400049E")]
				MousePositionX,
				[Token(Token = "0x400049F")]
				MousePositionY,
				[Token(Token = "0x40004A0")]
				MousePositionZ
			}

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000456")]
			[Address(RVA = "0xA61228", Offset = "0xA61228", VA = "0xA61228")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xA60EB4", Offset = "0xA60EB4", VA = "0xA60EB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xA60F74", Offset = "0xA60F74", VA = "0xA60F74")]
		private void Update()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xA61200", Offset = "0xA61200", VA = "0xA61200")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xA61218", Offset = "0xA61218", VA = "0xA61218")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D320C", Offset = "0x7D320C")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x20000AA")]
		public enum AxisOption
		{
			[Token(Token = "0x40003EF")]
			Both,
			[Token(Token = "0x40003F0")]
			OnlyHorizontal,
			[Token(Token = "0x40003F1")]
			OnlyVertical
		}

		[Token(Token = "0x20000AB")]
		public enum ControlStyle
		{
			[Token(Token = "0x40003F3")]
			Absolute,
			[Token(Token = "0x40003F4")]
			Relative,
			[Token(Token = "0x40003F5")]
			Swipe
		}

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xA61230", Offset = "0xA61230", VA = "0xA61230")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xA61370", Offset = "0xA61370", VA = "0xA61370")]
		private void Start()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xA61234", Offset = "0xA61234", VA = "0xA61234")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xA613EC", Offset = "0xA613EC", VA = "0xA613EC")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xA61458", Offset = "0xA61458", VA = "0xA61458", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xA61508", Offset = "0xA61508", VA = "0xA61508")]
		private void Update()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xA616DC", Offset = "0xA616DC", VA = "0xA616DC", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xA61754", Offset = "0xA61754", VA = "0xA61754")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xA61848", Offset = "0xA61848", VA = "0xA61848")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4150", Offset = "0x7D4150")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700000D")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0xA618C0", Offset = "0xA618C0", VA = "0xA618C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5FA8", Offset = "0x7D5FA8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600012C")]
			[Address(RVA = "0xA618CC", Offset = "0xA618CC", VA = "0xA618CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5FB8", Offset = "0x7D5FB8")]
			private set
			{
			}
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xA5EAE0", Offset = "0xA5EAE0", VA = "0xA5EAE0")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xA5EBC0", Offset = "0xA5EBC0", VA = "0xA5EBC0")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xA5EC28", Offset = "0xA5EC28", VA = "0xA5EC28")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xA5EDC8", Offset = "0xA5EDC8", VA = "0xA5EDC8")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xA5EFA8", Offset = "0xA5EFA8", VA = "0xA5EFA8")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xA5F0B8", Offset = "0xA5F0B8", VA = "0xA5F0B8")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xA5F150", Offset = "0xA5F150", VA = "0xA5F150")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xA5F59C", Offset = "0xA5F59C", VA = "0xA5F59C")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xA5F69C", Offset = "0xA5F69C", VA = "0xA5F69C")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xA5F7A0", Offset = "0xA5F7A0", VA = "0xA5F7A0")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x6000137")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000138")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x6000139")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x600013A")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x600013B")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x600013C")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x600013D")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x600013E")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x600013F")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000140")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000141")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xA60B2C", Offset = "0xA60B2C", VA = "0xA60B2C")]
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
		[Token(Token = "0x6000143")]
		[Address(RVA = "0xA60380", Offset = "0xA60380", VA = "0xA60380")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xA60414", Offset = "0xA60414", VA = "0xA60414")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xA604A0", Offset = "0xA604A0", VA = "0xA604A0", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xA6053C", Offset = "0xA6053C", VA = "0xA6053C", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xA605F4", Offset = "0xA605F4", VA = "0xA605F4", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xA606A0", Offset = "0xA606A0", VA = "0xA606A0", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xA60740", Offset = "0xA60740", VA = "0xA60740", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xA607E0", Offset = "0xA607E0", VA = "0xA607E0", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xA6087C", Offset = "0xA6087C", VA = "0xA6087C", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xA60924", Offset = "0xA60924", VA = "0xA60924", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xA609D4", Offset = "0xA609D4", VA = "0xA609D4", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xA60A84", Offset = "0xA60A84", VA = "0xA60A84", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xA60B20", Offset = "0xA60B20", VA = "0xA60B20", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xA5EA28", Offset = "0xA5EA28", VA = "0xA5EA28")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0xA60BEC", Offset = "0xA60BEC", VA = "0xA60BEC", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xA60C00", Offset = "0xA60C00", VA = "0xA60C00", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xA60C0C", Offset = "0xA60C0C", VA = "0xA60C0C", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xA60C18", Offset = "0xA60C18", VA = "0xA60C18", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xA60C24", Offset = "0xA60C24", VA = "0xA60C24", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xA60C90", Offset = "0xA60C90", VA = "0xA60C90", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xA60CFC", Offset = "0xA60CFC", VA = "0xA60CFC", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xA60D68", Offset = "0xA60D68", VA = "0xA60D68", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xA60DD4", Offset = "0xA60DD4", VA = "0xA60DD4", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xA60E40", Offset = "0xA60E40", VA = "0xA60E40", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xA60EAC", Offset = "0xA60EAC", VA = "0xA60EAC", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xA5EA2C", Offset = "0xA5EA2C", VA = "0xA5EA2C")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Car
{
	[Token(Token = "0x200003C")]
	public class BrakeLight : MonoBehaviour
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CarController car;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Renderer m_Renderer;

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xCE7900", Offset = "0xCE7900", VA = "0xCE7900")]
		private void Start()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xCE7958", Offset = "0xCE7958", VA = "0xCE7958")]
		private void Update()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xCE798C", Offset = "0xCE798C", VA = "0xCE798C")]
		public BrakeLight()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3270", Offset = "0x7D3270")]
	public class CarAIControl : MonoBehaviour
	{
		[Token(Token = "0x20000AC")]
		public enum BrakeCondition
		{
			[Token(Token = "0x40003F7")]
			NeverBrake,
			[Token(Token = "0x40003F8")]
			TargetDirectionDifference,
			[Token(Token = "0x40003F9")]
			TargetDistance
		}

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D4160", Offset = "0x7D4160")]
		private float m_CautiousSpeedFactor;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D41A0", Offset = "0x7D41A0")]
		private float m_CautiousMaxAngle;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_CautiousMaxDistance;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_CautiousAngularVelocityFactor;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_SteerSensitivity;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_AccelSensitivity;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_BrakeSensitivity;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_LateralWanderDistance;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_LateralWanderSpeed;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D4254", Offset = "0x7D4254")]
		private float m_AccelWanderAmount;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_AccelWanderSpeed;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private BrakeCondition m_BrakeCondition;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool m_Driving;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_StopWhenTargetReached;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_ReachTargetThreshold;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_RandomPerlin;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CarController m_CarController;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_AvoidOtherCarTime;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float m_AvoidOtherCarSlowdown;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float m_AvoidPathOffset;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xCE7994", Offset = "0xCE7994", VA = "0xCE7994")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xCE7A1C", Offset = "0xCE7A1C", VA = "0xCE7A1C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xCE83C0", Offset = "0xCE83C0", VA = "0xCE83C0")]
		private void OnCollisionStay(Collision col)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xCE865C", Offset = "0xCE865C", VA = "0xCE865C")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xCE866C", Offset = "0xCE866C", VA = "0xCE866C")]
		public CarAIControl()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D32D4", Offset = "0x7D32D4")]
	public class CarAudio : MonoBehaviour
	{
		[Token(Token = "0x20000AD")]
		public enum EngineAudioOptions
		{
			[Token(Token = "0x40003FB")]
			Simple,
			[Token(Token = "0x40003FC")]
			FourChannel
		}

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EngineAudioOptions engineSoundStyle;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip lowAccelClip;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip lowDecelClip;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip highAccelClip;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip highDecelClip;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchMultiplier;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float lowPitchMin;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float lowPitchMax;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float highPitchMultiplier;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float maxRolloffDistance;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dopplerLevel;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool useDoppler;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource m_LowAccel;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioSource m_LowDecel;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AudioSource m_HighAccel;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AudioSource m_HighDecel;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_StartedSound;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CarController m_CarController;

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xCE86B4", Offset = "0xCE86B4", VA = "0xCE86B4")]
		private void StartSound()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xCE8870", Offset = "0xCE8870", VA = "0xCE8870")]
		private void StopSound()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xCE8950", Offset = "0xCE8950", VA = "0xCE8950")]
		private void Update()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xCE8760", Offset = "0xCE8760", VA = "0xCE8760")]
		private AudioSource SetUpEngineAudioSource(AudioClip clip)
		{
			return null;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xCE8D48", Offset = "0xCE8D48", VA = "0xCE8D48")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xCE8D60", Offset = "0xCE8D60", VA = "0xCE8D60")]
		public CarAudio()
		{
		}
	}
	[Token(Token = "0x200003F")]
	internal enum CarDriveType
	{
		[Token(Token = "0x4000147")]
		FrontWheelDrive,
		[Token(Token = "0x4000148")]
		RearWheelDrive,
		[Token(Token = "0x4000149")]
		FourWheelDrive,
		[Token(Token = "0x400014A")]
		SixWheelDrive
	}
	[Token(Token = "0x2000040")]
	internal enum SpeedType
	{
		[Token(Token = "0x400014C")]
		MPH,
		[Token(Token = "0x400014D")]
		KPH
	}
	[Token(Token = "0x2000041")]
	public class CarController : MonoBehaviour
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CarDriveType m_CarDriveType;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WheelCollider[] m_WheelColliders;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] m_WheelMeshes;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private WheelEffects[] m_WheelEffects;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 m_CentreOfMassOffset;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_MaximumSteerAngle;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D4354", Offset = "0x7D4354")]
		[SerializeField]
		private float m_SteerHelper;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D4394", Offset = "0x7D4394")]
		[SerializeField]
		private float m_TractionControl;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_FullTorqueOverAllWheels;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_ReverseTorque;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_MaxHandbrakeTorque;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_Downforce;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SpeedType m_SpeedType;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_Topspeed;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private static int NoOfGears;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_RevRangeBoundary;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_SlipLimit;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float m_BrakeTorque;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] m_WheelMeshLocalRotations;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Prevpos;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 m_Pos;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float m_SteerAngle;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int m_GearNum;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float m_GearFactor;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float m_OldRotation;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float m_CurrentTorque;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000169")]
		private const float k_ReversingThreshold = 0.01f;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4474", Offset = "0x7D4474")]
		private bool <Skidding>k__BackingField;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4484", Offset = "0x7D4484")]
		private float <BrakeInput>k__BackingField;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4494", Offset = "0x7D4494")]
		private float <Revs>k__BackingField;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D44A4", Offset = "0x7D44A4")]
		private float <AccelInput>k__BackingField;

		[Token(Token = "0x1700000E")]
		public bool Skidding
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0xCE8D8C", Offset = "0xCE8D8C", VA = "0xCE8D8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5FC8", Offset = "0x7D5FC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0xCE8D94", Offset = "0xCE8D94", VA = "0xCE8D94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5FD8", Offset = "0x7D5FD8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public float BrakeInput
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0xCE8DA0", Offset = "0xCE8DA0", VA = "0xCE8DA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5FE8", Offset = "0x7D5FE8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xCE8DA8", Offset = "0xCE8DA8", VA = "0xCE8DA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5FF8", Offset = "0x7D5FF8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public float CurrentSteerAngle
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0xCE8DB0", Offset = "0xCE8DB0", VA = "0xCE8DB0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000011")]
		public float CurrentSpeed
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0xCE836C", Offset = "0xCE836C", VA = "0xCE836C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000012")]
		public float MaxSpeed
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xCE8DB8", Offset = "0xCE8DB8", VA = "0xCE8DB8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000013")]
		public float Revs
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xCE8DC0", Offset = "0xCE8DC0", VA = "0xCE8DC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6008", Offset = "0x7D6008")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xCE8DC8", Offset = "0xCE8DC8", VA = "0xCE8DC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6018", Offset = "0x7D6018")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public float AccelInput
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xCE8DD0", Offset = "0xCE8DD0", VA = "0xCE8DD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6028", Offset = "0x7D6028")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xCE8DD8", Offset = "0xCE8DD8", VA = "0xCE8DD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6038", Offset = "0x7D6038")]
			private set
			{
			}
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xCE8DE0", Offset = "0xCE8DE0", VA = "0xCE8DE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xCE8F38", Offset = "0xCE8F38", VA = "0xCE8F38")]
		private void GearChanging()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xCE9070", Offset = "0xCE9070", VA = "0xCE9070")]
		private static float CurveFactor(float factor)
		{
			return default(float);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xCE9084", Offset = "0xCE9084", VA = "0xCE9084")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xCE909C", Offset = "0xCE909C", VA = "0xCE909C")]
		private void CalculateGearFactor()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xCE91A8", Offset = "0xCE91A8", VA = "0xCE91A8")]
		private void CalculateRevs()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xCE8090", Offset = "0xCE8090", VA = "0xCE8090")]
		public void Move(float steering, float accel, float footbrake, float handbrake)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xCE9850", Offset = "0xCE9850", VA = "0xCE9850")]
		private void CapSpeed()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xCE94F8", Offset = "0xCE94F8", VA = "0xCE94F8")]
		private void ApplyDrive(float accel, float footbrake)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xCE927C", Offset = "0xCE927C", VA = "0xCE927C")]
		private void SteerHelper()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xCE998C", Offset = "0xCE998C", VA = "0xCE998C")]
		private void AddDownForce()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xCE9AF8", Offset = "0xCE9AF8", VA = "0xCE9AF8")]
		private void CheckForWheelSpin()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xCE9CD0", Offset = "0xCE9CD0", VA = "0xCE9CD0")]
		private void TractionControl()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xCEA2FC", Offset = "0xCEA2FC", VA = "0xCEA2FC")]
		private void AdjustTorque(float forwardSlip)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xCEA160", Offset = "0xCEA160", VA = "0xCEA160")]
		private bool AnySkidSoundPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xCEA344", Offset = "0xCEA344", VA = "0xCEA344")]
		public CarController()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class CarSelfRighting : MonoBehaviour
	{
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_WaitTime;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_VelocityThreshold;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_LastOkTime;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xCEA444", Offset = "0xCEA444", VA = "0xCEA444")]
		private void Start()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xCEA49C", Offset = "0xCEA49C", VA = "0xCEA49C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xCEA548", Offset = "0xCEA548", VA = "0xCEA548")]
		private void RightCar()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xCEA68C", Offset = "0xCEA68C", VA = "0xCEA68C")]
		public CarSelfRighting()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3338", Offset = "0x7D3338")]
	public class CarUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CarController m_Car;

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xCEA6A0", Offset = "0xCEA6A0", VA = "0xCEA6A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xCEA6F8", Offset = "0xCEA6F8", VA = "0xCEA6F8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xCEA7A8", Offset = "0xCEA7A8", VA = "0xCEA7A8")]
		public CarUserControl()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class Mudguard : MonoBehaviour
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CarController carController;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xCEA7B0", Offset = "0xCEA7B0", VA = "0xCEA7B0")]
		private void Start()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xCEA7EC", Offset = "0xCEA7EC", VA = "0xCEA7EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xCEA8D4", Offset = "0xCEA8D4", VA = "0xCEA8D4")]
		public Mudguard()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class SkidTrail : MonoBehaviour
	{
		[Token(Token = "0x20000AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3CD8", Offset = "0x7D3CD8")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkidTrail <>4__this;

			[Token(Token = "0x170000C9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600045A")]
				[Address(RVA = "0xCEAAB8", Offset = "0xCEAAB8", VA = "0xCEAAB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600045C")]
				[Address(RVA = "0xCEAB20", Offset = "0xCEAB20", VA = "0xCEAB20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0xCEA94C", Offset = "0xCEA94C", VA = "0xCEA94C")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0xCEA980", Offset = "0xCEA980", VA = "0xCEA980", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0xCEA984", Offset = "0xCEA984", VA = "0xCEA984", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0xCEAAC0", Offset = "0xCEAAC0", VA = "0xCEAAC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_PersistTime;

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xCEA8DC", Offset = "0xCEA8DC", VA = "0xCEA8DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D6048", Offset = "0x7D6048")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xCEA978", Offset = "0xCEA978", VA = "0xCEA978")]
		public SkidTrail()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class Suspension : MonoBehaviour
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject wheel;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 m_TargetOriginalPosition;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_Origin;

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xCEAB28", Offset = "0xCEAB28", VA = "0xCEAB28")]
		private void Start()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xCEAB8C", Offset = "0xCEAB8C", VA = "0xCEAB8C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xCEACB4", Offset = "0xCEACB4", VA = "0xCEACB4")]
		public Suspension()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D339C", Offset = "0x7D339C")]
	public class WheelEffects : MonoBehaviour
	{
		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3CE8", Offset = "0x7D3CE8")]
		private sealed class <StartSkidTrail>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WheelEffects <>4__this;

			[Token(Token = "0x170000CB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000460")]
				[Address(RVA = "0xCEB110", Offset = "0xCEB110", VA = "0xCEB110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0xCEB178", Offset = "0xCEB178", VA = "0xCEB178", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0xCEAF20", Offset = "0xCEAF20", VA = "0xCEAF20")]
			[DebuggerHidden]
			public <StartSkidTrail>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0xCEAF54", Offset = "0xCEAF54", VA = "0xCEAF54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0xCEAF58", Offset = "0xCEAF58", VA = "0xCEAF58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0xCEB118", Offset = "0xCEB118", VA = "0xCEB118", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform SkidTrailPrefab;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Transform skidTrailsDetachedParent;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem skidParticles;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D44E4", Offset = "0x7D44E4")]
		private bool <skidding>k__BackingField;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D44F4", Offset = "0x7D44F4")]
		private bool <PlayingAudio>k__BackingField;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_SkidTrail;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WheelCollider m_WheelCollider;

		[Token(Token = "0x17000015")]
		public bool skidding
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0xCEACBC", Offset = "0xCEACBC", VA = "0xCEACBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D60AC", Offset = "0x7D60AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0xCEACC4", Offset = "0xCEACC4", VA = "0xCEACC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D60BC", Offset = "0x7D60BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public bool PlayingAudio
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0xCEACD0", Offset = "0xCEACD0", VA = "0xCEACD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D60CC", Offset = "0x7D60CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0xCEACD8", Offset = "0xCEACD8", VA = "0xCEACD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D60DC", Offset = "0x7D60DC")]
			private set
			{
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xCEACE4", Offset = "0xCEACE4", VA = "0xCEACE4")]
		private void Start()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xCE9FD8", Offset = "0xCE9FD8", VA = "0xCE9FD8")]
		public void EmitTyreSmoke()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xCEA1CC", Offset = "0xCEA1CC", VA = "0xCEA1CC")]
		public void PlayAudio()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xCEA204", Offset = "0xCEA204", VA = "0xCEA204")]
		public void StopAudio()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xCEAEB0", Offset = "0xCEAEB0", VA = "0xCEAEB0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D60EC", Offset = "0x7D60EC")]
		public IEnumerator StartSkidTrail()
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xCEA238", Offset = "0xCEA238", VA = "0xCEA238")]
		public void EndSkidTrail()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xCEAF4C", Offset = "0xCEAF4C", VA = "0xCEAF4C")]
		public WheelEffects()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Aeroplane
{
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3400", Offset = "0x7D3400")]
	public class AeroplaneAiControl : MonoBehaviour
	{
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_RollSensitivity;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_PitchSensitivity;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_LateralWanderDistance;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_LateralWanderSpeed;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_MaxClimbAngle;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MaxRollAngle;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_SpeedEffect;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_TakeoffHeight;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform m_Target;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AeroplaneController m_AeroplaneController;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_RandomPerlin;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool m_TakenOff;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xCE47E8", Offset = "0xCE47E8", VA = "0xCE47E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xCE4858", Offset = "0xCE4858", VA = "0xCE4858")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xCE4860", Offset = "0xCE4860", VA = "0xCE4860")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xCE4BA0", Offset = "0xCE4BA0", VA = "0xCE4BA0")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xCE4BA8", Offset = "0xCE4BA8", VA = "0xCE4BA8")]
		public AeroplaneAiControl()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class AeroplaneAudio : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B0")]
		public class AdvancedSetttings
		{
			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float engineMinDistance;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float engineMaxDistance;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float engineDopplerLevel;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D5928", Offset = "0x7D5928")]
			public float engineMasterVolume;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float windMinDistance;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float windMaxDistance;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float windDopplerLevel;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D5940", Offset = "0x7D5940")]
			public float windMasterVolume;

			[Token(Token = "0x6000463")]
			[Address(RVA = "0xCE5020", Offset = "0xCE5020", VA = "0xCE5020")]
			public AdvancedSetttings()
			{
			}
		}

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioClip m_EngineSound;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_EngineMinThrottlePitch;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_EngineMaxThrottlePitch;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_EngineFwdSpeedMultiplier;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip m_WindSound;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_WindBasePitch;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_WindSpeedPitchFactor;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_WindMaxSpeedVolume;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AdvancedSetttings m_AdvancedSetttings;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AudioSource m_EngineSoundSource;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AudioSource m_WindSoundSource;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xCE4BC8", Offset = "0xCE4BC8", VA = "0xCE4BC8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xCE4DB8", Offset = "0xCE4DB8", VA = "0xCE4DB8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xCE4F78", Offset = "0xCE4F78", VA = "0xCE4F78")]
		public AeroplaneAudio()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class AeroplaneControlSurfaceAnimator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		public class ControlSurface
		{
			[Token(Token = "0x20000D2")]
			public enum Type
			{
				[Token(Token = "0x40004A2")]
				Aileron,
				[Token(Token = "0x40004A3")]
				Elevator,
				[Token(Token = "0x40004A4")]
				Rudder,
				[Token(Token = "0x40004A5")]
				RuddervatorNegative,
				[Token(Token = "0x40004A6")]
				RuddervatorPositive
			}

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float amount;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Type type;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[HideInInspector]
			public Quaternion originalLocalRotation;

			[Token(Token = "0x6000464")]
			[Address(RVA = "0xCE543C", Offset = "0xCE543C", VA = "0xCE543C")]
			public ControlSurface()
			{
			}
		}

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Smoothing;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ControlSurface[] m_ControlSurfaces;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xCE503C", Offset = "0xCE503C", VA = "0xCE503C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xCE5100", Offset = "0xCE5100", VA = "0xCE5100")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xCE52D8", Offset = "0xCE52D8", VA = "0xCE52D8")]
		private void RotateSurface(ControlSurface surface, Quaternion rotation)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xCE542C", Offset = "0xCE542C", VA = "0xCE542C")]
		public AeroplaneControlSurfaceAnimator()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3464", Offset = "0x7D3464")]
	public class AeroplaneController : MonoBehaviour
	{
		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxEnginePower;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_Lift;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_ZeroLiftSpeed;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_RollEffect;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_PitchEffect;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_YawEffect;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_BankedTurnEffect;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_AerodynamicEffect;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_AutoTurnPitch;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_AutoRollLevel;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_AutoPitchLevel;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_AirBrakesEffect;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_ThrottleChangeSpeed;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_DragIncreaseFactor;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4724", Offset = "0x7D4724")]
		private float <Altitude>k__BackingField;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4734", Offset = "0x7D4734")]
		private float <Throttle>k__BackingField;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4744", Offset = "0x7D4744")]
		private bool <AirBrakes>k__BackingField;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4754", Offset = "0x7D4754")]
		private float <ForwardSpeed>k__BackingField;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4764", Offset = "0x7D4764")]
		private float <EnginePower>k__BackingField;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4774", Offset = "0x7D4774")]
		private float <RollAngle>k__BackingField;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4784", Offset = "0x7D4784")]
		private float <PitchAngle>k__BackingField;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4794", Offset = "0x7D4794")]
		private float <RollInput>k__BackingField;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D47A4", Offset = "0x7D47A4")]
		private float <PitchInput>k__BackingField;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D47B4", Offset = "0x7D47B4")]
		private float <YawInput>k__BackingField;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D47C4", Offset = "0x7D47C4")]
		private float <ThrottleInput>k__BackingField;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float m_OriginalDrag;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_OriginalAngularDrag;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float m_AeroFactor;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_Immobilized;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float m_BankedTurnAmount;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private WheelCollider[] m_WheelColliders;

		[Token(Token = "0x17000017")]
		public float Altitude
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xCE5444", Offset = "0xCE5444", VA = "0xCE5444")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6150", Offset = "0x7D6150")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xCE544C", Offset = "0xCE544C", VA = "0xCE544C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6160", Offset = "0x7D6160")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public float Throttle
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xCE5454", Offset = "0xCE5454", VA = "0xCE5454")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6170", Offset = "0x7D6170")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xCE545C", Offset = "0xCE545C", VA = "0xCE545C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6180", Offset = "0x7D6180")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool AirBrakes
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xCE5464", Offset = "0xCE5464", VA = "0xCE5464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6190", Offset = "0x7D6190")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xCE546C", Offset = "0xCE546C", VA = "0xCE546C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D61A0", Offset = "0x7D61A0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public float ForwardSpeed
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xCE5478", Offset = "0xCE5478", VA = "0xCE5478")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D61B0", Offset = "0x7D61B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xCE5480", Offset = "0xCE5480", VA = "0xCE5480")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D61C0", Offset = "0x7D61C0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public float EnginePower
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xCE5488", Offset = "0xCE5488", VA = "0xCE5488")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D61D0", Offset = "0x7D61D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xCE5490", Offset = "0xCE5490", VA = "0xCE5490")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D61E0", Offset = "0x7D61E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public float MaxEnginePower
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xCE5498", Offset = "0xCE5498", VA = "0xCE5498")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001D")]
		public float RollAngle
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xCE54A0", Offset = "0xCE54A0", VA = "0xCE54A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D61F0", Offset = "0x7D61F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xCE54A8", Offset = "0xCE54A8", VA = "0xCE54A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6200", Offset = "0x7D6200")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public float PitchAngle
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xCE54B0", Offset = "0xCE54B0", VA = "0xCE54B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6210", Offset = "0x7D6210")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xCE54B8", Offset = "0xCE54B8", VA = "0xCE54B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6220", Offset = "0x7D6220")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public float RollInput
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xCE54C0", Offset = "0xCE54C0", VA = "0xCE54C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6230", Offset = "0x7D6230")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0xCE54C8", Offset = "0xCE54C8", VA = "0xCE54C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6240", Offset = "0x7D6240")]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public float PitchInput
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xCE54D0", Offset = "0xCE54D0", VA = "0xCE54D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6250", Offset = "0x7D6250")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xCE54D8", Offset = "0xCE54D8", VA = "0xCE54D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6260", Offset = "0x7D6260")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public float YawInput
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xCE54E0", Offset = "0xCE54E0", VA = "0xCE54E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6270", Offset = "0x7D6270")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xCE54E8", Offset = "0xCE54E8", VA = "0xCE54E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6280", Offset = "0x7D6280")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public float ThrottleInput
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0xCE54F0", Offset = "0xCE54F0", VA = "0xCE54F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6290", Offset = "0x7D6290")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xCE54F8", Offset = "0xCE54F8", VA = "0xCE54F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D62A0", Offset = "0x7D62A0")]
			private set
			{
			}
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xCE5500", Offset = "0xCE5500", VA = "0xCE5500")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xCE4B2C", Offset = "0xCE4B2C", VA = "0xCE4B2C")]
		public void Move(float rollInput, float pitchInput, float yawInput, float throttleInput, bool airBrakes)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xCE565C", Offset = "0xCE565C", VA = "0xCE565C")]
		private void ClampInputs()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xCE5744", Offset = "0xCE5744", VA = "0xCE5744")]
		private void CalculateRollAndPitchAngles()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xCE58C0", Offset = "0xCE58C0", VA = "0xCE58C0")]
		private void AutoLevel()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xCE59AC", Offset = "0xCE59AC", VA = "0xCE59AC")]
		private void CalculateForwardSpeed()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xCE5A64", Offset = "0xCE5A64", VA = "0xCE5A64")]
		private void ControlThrottle()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xCE5B28", Offset = "0xCE5B28", VA = "0xCE5B28")]
		private void CalculateDrag()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xCE5BD4", Offset = "0xCE5BD4", VA = "0xCE5BD4")]
		private void CaluclateAerodynamicEffect()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xCE5EA0", Offset = "0xCE5EA0", VA = "0xCE5EA0")]
		private void CalculateLinearForces()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xCE60C4", Offset = "0xCE60C4", VA = "0xCE60C4")]
		private void CalculateTorque()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xCE6330", Offset = "0xCE6330", VA = "0xCE6330")]
		private void CalculateAltitude()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xCE64C0", Offset = "0xCE64C0", VA = "0xCE64C0")]
		public void Immobilize()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xCE64CC", Offset = "0xCE64CC", VA = "0xCE64CC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xCE64D4", Offset = "0xCE64D4", VA = "0xCE64D4")]
		public AeroplaneController()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class AeroplanePropellerAnimator : MonoBehaviour
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_PropellorModel;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_PropellorBlur;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Texture2D[] m_PropellorBlurTextures;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D4804", Offset = "0x7D4804")]
		private float m_ThrottleBlurStart;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D4844", Offset = "0x7D4844")]
		private float m_ThrottleBlurEnd;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_MaxRpm;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_PropellorBlurState;

		[Token(Token = "0x40001C5")]
		private const float k_RpmToDps = 60f;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Renderer m_PropellorModelRenderer;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Renderer m_PropellorBlurRenderer;

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xCE6514", Offset = "0xCE6514", VA = "0xCE6514")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xCE65BC", Offset = "0xCE65BC", VA = "0xCE65BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xCE679C", Offset = "0xCE679C", VA = "0xCE679C")]
		public AeroplanePropellerAnimator()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D34C8", Offset = "0x7D34C8")]
	public class AeroplaneUserControl2Axis : MonoBehaviour
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxRollAngle;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxPitchAngle;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AeroplaneController m_Aeroplane;

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xCE67C0", Offset = "0xCE67C0", VA = "0xCE67C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xCE6818", Offset = "0xCE6818", VA = "0xCE6818")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xCE6918", Offset = "0xCE6918", VA = "0xCE6918")]
		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xCE6A50", Offset = "0xCE6A50", VA = "0xCE6A50")]
		public AeroplaneUserControl2Axis()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D352C", Offset = "0x7D352C")]
	public class AeroplaneUserControl4Axis : MonoBehaviour
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxRollAngle;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxPitchAngle;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AeroplaneController m_Aeroplane;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_Throttle;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_AirBrakes;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_Yaw;

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xCE6A64", Offset = "0xCE6A64", VA = "0xCE6A64")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xCE6ABC", Offset = "0xCE6ABC", VA = "0xCE6ABC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xCE6BD4", Offset = "0xCE6BD4", VA = "0xCE6BD4")]
		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xCE6CCC", Offset = "0xCE6CCC", VA = "0xCE6CCC")]
		public AeroplaneUserControl4Axis()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3590", Offset = "0x7D3590")]
	public class JetParticleEffect : MonoBehaviour
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color minColour;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AeroplaneController m_Jet;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem m_System;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_OriginalStartSize;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_OriginalLifetime;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color m_OriginalStartColor;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xCE6CE0", Offset = "0xCE6CE0", VA = "0xCE6CE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xCE6F6C", Offset = "0xCE6F6C", VA = "0xCE6F6C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xCE6E3C", Offset = "0xCE6E3C", VA = "0xCE6E3C")]
		private AeroplaneController FindAeroplaneParent()
		{
			return null;
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xCE70F4", Offset = "0xCE70F4", VA = "0xCE70F4")]
		public JetParticleEffect()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class LandingGear : MonoBehaviour
	{
		[Token(Token = "0x20000B2")]
		private enum GearState
		{
			[Token(Token = "0x4000410")]
			Raised = -1,
			[Token(Token = "0x4000411")]
			Lowered = 1
		}

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float raiseAtAltitude;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float lowerAtAltitude;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GearState m_State;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator m_Animator;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AeroplaneController m_Plane;

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xCE70FC", Offset = "0xCE70FC", VA = "0xCE70FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xCE7184", Offset = "0xCE7184", VA = "0xCE7184")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xCE7270", Offset = "0xCE7270", VA = "0xCE7270")]
		public LandingGear()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Ball
{
	[Token(Token = "0x2000051")]
	public class Ball : MonoBehaviour
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovePower;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_UseTorque;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MaxAngularVelocity;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x40001E1")]
		private const float k_GroundRayLength = 1f;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xCE728C", Offset = "0xCE728C", VA = "0xCE728C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xCE7300", Offset = "0xCE7300", VA = "0xCE7300")]
		public void Move(Vector3 moveDirection, bool jump)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xCE74FC", Offset = "0xCE74FC", VA = "0xCE74FC")]
		public Ball()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class BallUserControl : MonoBehaviour
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Ball ball;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 move;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform cam;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 camForward;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool jump;

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xCE7520", Offset = "0xCE7520", VA = "0xCE7520")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xCE7614", Offset = "0xCE7614", VA = "0xCE7614")]
		private void Update()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xCE78BC", Offset = "0xCE78BC", VA = "0xCE78BC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xCE78F8", Offset = "0xCE78F8", VA = "0xCE78F8")]
		public BallUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D35F4", Offset = "0x7D35F4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D35F4", Offset = "0x7D35F4")]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D48D4", Offset = "0x7D48D4")]
		private NavMeshAgent <agent>k__BackingField;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D48E4", Offset = "0x7D48E4")]
		private ThirdPersonCharacter <character>k__BackingField;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x17000023")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xA5C918", Offset = "0xA5C918", VA = "0xA5C918")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D62B0", Offset = "0x7D62B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xA5C920", Offset = "0xA5C920", VA = "0xA5C920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D62C0", Offset = "0x7D62C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xA5C928", Offset = "0xA5C928", VA = "0xA5C928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D62D0", Offset = "0x7D62D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xA5C930", Offset = "0xA5C930", VA = "0xA5C930")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D62E0", Offset = "0x7D62E0")]
			private set
			{
			}
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xA5C938", Offset = "0xA5C938", VA = "0xA5C938")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xA5C9D4", Offset = "0xA5C9D4", VA = "0xA5C9D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xA5CCB0", Offset = "0xA5CCB0", VA = "0xA5CCB0")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xA5CCB8", Offset = "0xA5CCB8", VA = "0xA5CCB8")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3680", Offset = "0x7D3680")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3680", Offset = "0x7D3680")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3680", Offset = "0x7D3680")]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D4924", Offset = "0x7D4924")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsGrounded;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x40001F7")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_TurnAmount;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_ForwardAmount;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_CapsuleHeight;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_Crouching;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xA5CCC0", Offset = "0xA5CCC0", VA = "0xA5CCC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xA5CAF8", Offset = "0xA5CAF8", VA = "0xA5CAF8")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xA5D248", Offset = "0xA5D248", VA = "0xA5D248")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xA5D4E4", Offset = "0xA5D4E4", VA = "0xA5D4E4")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xA5D69C", Offset = "0xA5D69C", VA = "0xA5D69C")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xA5D134", Offset = "0xA5D134", VA = "0xA5D134")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xA5CFF4", Offset = "0xA5CFF4", VA = "0xA5CFF4")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xA5CF24", Offset = "0xA5CF24", VA = "0xA5CF24")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xA5D8E8", Offset = "0xA5D8E8", VA = "0xA5D8E8")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xA5CD90", Offset = "0xA5CD90", VA = "0xA5CD90")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xA5DA18", Offset = "0xA5DA18", VA = "0xA5DA18")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3734", Offset = "0x7D3734")]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ThirdPersonCharacter m_Character;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_Cam;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_CamForward;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_Move;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_Jump;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xA5DA38", Offset = "0xA5DA38", VA = "0xA5DA38")]
		private void Start()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xA5DB40", Offset = "0xA5DB40", VA = "0xA5DB40")]
		private void Update()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xA5DBC0", Offset = "0xA5DBC0", VA = "0xA5DBC0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xA5DE64", Offset = "0xA5DE64", VA = "0xA5DE64")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3798", Offset = "0x7D3798")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3798", Offset = "0x7D3798")]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D49D4", Offset = "0x7D49D4")]
		private float m_RunstepLenghten;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_Jump;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float m_YRotation;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 m_Input;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float m_StepCycle;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float m_NextStep;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool m_Jumping;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xA59B4C", Offset = "0xA59B4C", VA = "0xA59B4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xA59D88", Offset = "0xA59D88", VA = "0xA59D88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xA59FE0", Offset = "0xA59FE0", VA = "0xA59FE0")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xA5A034", Offset = "0xA5A034", VA = "0xA5A034")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xA5A590", Offset = "0xA5A590", VA = "0xA5A590")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xA5A5D0", Offset = "0xA5A5D0", VA = "0xA5A5D0")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xA5A8A8", Offset = "0xA5A8A8", VA = "0xA5A8A8")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xA5A6D4", Offset = "0xA5A6D4", VA = "0xA5A6D4")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xA5A3F8", Offset = "0xA5A3F8", VA = "0xA5A3F8")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xA59E9C", Offset = "0xA59E9C", VA = "0xA59E9C")]
		private void RotateView()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xA5AEE4", Offset = "0xA5AEE4", VA = "0xA5AEE4")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xA5B064", Offset = "0xA5B064", VA = "0xA5B064")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D4AE4", Offset = "0x7D4AE4")]
		public float RunningStrideLengthen;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xA5B3B0", Offset = "0xA5B3B0", VA = "0xA5B3B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xA5B408", Offset = "0xA5B408", VA = "0xA5B408")]
		private void Update()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xA5B618", Offset = "0xA5B618", VA = "0xA5B618")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class MouseLook
	{
		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xA59D34", Offset = "0xA59D34", VA = "0xA59D34")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xA5ABF4", Offset = "0xA5ABF4", VA = "0xA5ABF4")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xA5B764", Offset = "0xA5B764", VA = "0xA5B764")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xA5A898", Offset = "0xA5A898", VA = "0xA5A898")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xA5B798", Offset = "0xA5B798", VA = "0xA5B798")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xA5B69C", Offset = "0xA5B69C", VA = "0xA5B69C")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xA5B814", Offset = "0xA5B814", VA = "0xA5B814")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3824", Offset = "0x7D3824")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3824", Offset = "0x7D3824")]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B3")]
		public class MovementSettings
		{
			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x6000465")]
			[Address(RVA = "0xA5C594", Offset = "0xA5C594", VA = "0xA5C594")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0xA5C744", Offset = "0xA5C744", VA = "0xA5C744")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B4")]
		public class AdvancedSettings
		{
			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5978", Offset = "0x7D5978")]
			public float shellOffset;

			[Token(Token = "0x6000467")]
			[Address(RVA = "0xA5C8FC", Offset = "0xA5C8FC", VA = "0xA5C8FC")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		[Token(Token = "0x17000025")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xA5B5F4", Offset = "0xA5B5F4", VA = "0xA5B5F4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000026")]
		public bool Grounded
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0xA5B848", Offset = "0xA5B848", VA = "0xA5B848")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public bool Jumping
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xA5B850", Offset = "0xA5B850", VA = "0xA5B850")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000028")]
		public bool Running
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0xA5B610", Offset = "0xA5B610", VA = "0xA5B610")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xA5B858", Offset = "0xA5B858", VA = "0xA5B858")]
		private void Start()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xA5B904", Offset = "0xA5B904", VA = "0xA5B904")]
		private void Update()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xA5BB98", Offset = "0xA5BB98", VA = "0xA5BB98")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xA5C25C", Offset = "0xA5C25C", VA = "0xA5C25C")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xA5C314", Offset = "0xA5C314", VA = "0xA5C314")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xA5C1AC", Offset = "0xA5C1AC", VA = "0xA5C1AC")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xA5B990", Offset = "0xA5B990", VA = "0xA5B990")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xA5BFC4", Offset = "0xA5BFC4", VA = "0xA5BFC4")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xA5C660", Offset = "0xA5C660", VA = "0xA5C660")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x200005A")]
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		[Token(Token = "0x20000B5")]
		public enum UpdateType
		{
			[Token(Token = "0x4000420")]
			FixedUpdate,
			[Token(Token = "0x4000421")]
			LateUpdate,
			[Token(Token = "0x4000422")]
			ManualUpdate
		}

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x17000029")]
		public Transform Target
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0xA57BA8", Offset = "0xA57BA8", VA = "0xA57BA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xA577B8", Offset = "0xA577B8", VA = "0xA577B8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xA5791C", Offset = "0xA5791C", VA = "0xA5791C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xA579F0", Offset = "0xA579F0", VA = "0xA579F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xA57AC8", Offset = "0xA57AC8", VA = "0xA57AC8")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x600022A")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xA57860", Offset = "0xA57860", VA = "0xA57860")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xA57BA0", Offset = "0xA57BA0", VA = "0xA57BA0", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xA57BB0", Offset = "0xA57BB0", VA = "0xA57BB0")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_RollSpeed;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_FollowVelocity;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool m_FollowTilt;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_SpinTurnLimit;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_TargetVelocityLowerLimit;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SmoothTurnTime;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_LastFlatAngle;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 m_RollUp;

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xA57BC0", Offset = "0xA57BC0", VA = "0xA57BC0", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xA58134", Offset = "0xA58134", VA = "0xA58134")]
		public AutoCam()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class FreeLookCam : PivotBasedCameraRig
	{
		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D4BBC", Offset = "0x7D4BBC")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_TurnSmoothing;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TiltMax;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_TiltMin;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_LockCursor;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_VerticalAutoReturn;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_LookAngle;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_TiltAngle;

		[Token(Token = "0x400025A")]
		private const float k_LookDistance = 100f;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 m_PivotEulers;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion m_PivotTargetRot;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion m_TransformTargetRot;

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xA581F0", Offset = "0xA581F0", VA = "0xA581F0", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xA58328", Offset = "0xA58328", VA = "0xA58328")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xA58718", Offset = "0xA58718", VA = "0xA58718")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xA5873C", Offset = "0xA5873C", VA = "0xA5873C", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xA58388", Offset = "0xA58388", VA = "0xA58388")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xA58904", Offset = "0xA58904", VA = "0xA58904")]
		public FreeLookCam()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class HandHeldCam : LookatTarget
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SwaySpeed;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_BaseSwayAmount;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_TrackingSwayAmount;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D4C7C", Offset = "0x7D4C7C")]
		[SerializeField]
		private float m_TrackingBias;

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xA5892C", Offset = "0xA5892C", VA = "0xA5892C", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xA58DD0", Offset = "0xA58DD0", VA = "0xA58DD0")]
		public HandHeldCam()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class LookatTarget : AbstractTargetFollower
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 m_RotationRange;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FollowSpeed;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Vector3 m_FollowVelocity;

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xA58E10", Offset = "0xA58E10", VA = "0xA58E10", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xA58ABC", Offset = "0xA58ABC", VA = "0xA58ABC", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xA58DF8", Offset = "0xA58DF8", VA = "0xA58DF8")]
		public LookatTarget()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform m_Cam;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Transform m_Pivot;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xA582B0", Offset = "0xA582B0", VA = "0xA582B0", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xA581E0", Offset = "0xA581E0", VA = "0xA581E0")]
		protected PivotBasedCameraRig()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x20000B6")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0xA5962C", Offset = "0xA5962C", VA = "0xA5962C", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0xA58F40", Offset = "0xA58F40", VA = "0xA58F40")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4CDC", Offset = "0x7D4CDC")]
		private bool <protecting>k__BackingField;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x1700002A")]
		public bool protecting
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0xA58E54", Offset = "0xA58E54", VA = "0xA58E54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D62F0", Offset = "0x7D62F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023F")]
			[Address(RVA = "0xA58E5C", Offset = "0xA58E5C", VA = "0xA58E5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6300", Offset = "0x7D6300")]
			private set
			{
			}
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xA58E68", Offset = "0xA58E68", VA = "0xA58E68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xA58F48", Offset = "0xA58F48", VA = "0xA58F48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xA595B4", Offset = "0xA595B4", VA = "0xA595B4")]
		public ProtectCameraFromWallClip()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FovAdjustTime;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ZoomAmountMultiplier;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_BoundSize;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_FovAdjustVelocity;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Cam;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform m_LastTarget;

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xA59734", Offset = "0xA59734", VA = "0xA59734", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xA59984", Offset = "0xA59984", VA = "0xA59984", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xA59B00", Offset = "0xA59B00", VA = "0xA59B00", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xA597A4", Offset = "0xA597A4", VA = "0xA597A4")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xA59B30", Offset = "0xA59B30", VA = "0xA59B30")]
		public TargetFieldOfView()
		{
		}
	}
}
namespace UnityStandardAssets._2D
{
	[Token(Token = "0x2000062")]
	public class Camera2DFollow : MonoBehaviour
	{
		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float damping;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float lookAheadFactor;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float lookAheadReturnSpeed;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float lookAheadMoveThreshold;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_OffsetZ;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_LastTargetPosition;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 m_CurrentVelocity;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_LookAheadPos;

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xCEF854", Offset = "0xCEF854", VA = "0xCEF854")]
		private void Start()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xCEF964", Offset = "0xCEF964", VA = "0xCEF964")]
		private void Update()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xCEFC84", Offset = "0xCEFC84", VA = "0xCEFC84")]
		public Camera2DFollow()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class CameraFollow : MonoBehaviour
	{
		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float xMargin;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMargin;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float xSmooth;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ySmooth;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 maxXAndY;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 minXAndY;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Player;

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xCEFC98", Offset = "0xCEFC98", VA = "0xCEFC98")]
		private void Awake()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xCEFD00", Offset = "0xCEFD00", VA = "0xCEFD00")]
		private bool CheckXMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xCEFDAC", Offset = "0xCEFDAC", VA = "0xCEFDAC")]
		private bool CheckYMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xCEFE58", Offset = "0xCEFE58", VA = "0xCEFE58")]
		private void Update()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xCEFE5C", Offset = "0xCEFE5C", VA = "0xCEFE5C")]
		private void TrackPlayer()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xCF00B4", Offset = "0xCF00B4", VA = "0xCF00B4")]
		public CameraFollow()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D38C0", Offset = "0x7D38C0")]
	public class Platformer2DUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlatformerCharacter2D m_Character;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Jump;

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xCF00C8", Offset = "0xCF00C8", VA = "0xCF00C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xCF0120", Offset = "0xCF0120", VA = "0xCF0120")]
		private void Update()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xCF01A4", Offset = "0xCF01A4", VA = "0xCF01A4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xCF0528", Offset = "0xCF0528", VA = "0xCF0528")]
		public Platformer2DUserControl()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class PlatformerCharacter2D : MonoBehaviour
	{
		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxSpeed;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_JumpForce;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D4D3C", Offset = "0x7D4D3C")]
		[SerializeField]
		private float m_CrouchSpeed;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_AirControl;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask m_WhatIsGround;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_GroundCheck;

		[Token(Token = "0x4000298")]
		private const float k_GroundedRadius = 0.2f;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_Grounded;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_CeilingCheck;

		[Token(Token = "0x400029B")]
		private const float k_CeilingRadius = 0.01f;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator m_Anim;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody2D m_Rigidbody2D;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_FacingRight;

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xCF0530", Offset = "0xCF0530", VA = "0xCF0530")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xCF05F4", Offset = "0xCF05F4", VA = "0xCF05F4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xCF0248", Offset = "0xCF0248", VA = "0xCF0248")]
		public void Move(float move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xCF0800", Offset = "0xCF0800", VA = "0xCF0800")]
		private void Flip()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xCF087C", Offset = "0xCF087C", VA = "0xCF087C")]
		public PlatformerCharacter2D()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class Restarter : MonoBehaviour
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0xCF08A4", Offset = "0xCF08A4", VA = "0xCF08A4")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xCF0940", Offset = "0xCF0940", VA = "0xCF0940")]
		public Restarter()
		{
		}
	}
}
namespace UltimateGameTools.MeshSimplifier
{
	[Serializable]
	[Token(Token = "0x2000067")]
	public class MeshUniqueVertices
	{
		[Serializable]
		[Token(Token = "0x20000B7")]
		public class ListIndices
		{
			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<int> m_listIndices;

			[Token(Token = "0x600046A")]
			[Address(RVA = "0xA80120", Offset = "0xA80120", VA = "0xA80120")]
			public ListIndices()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B8")]
		public class SerializableBoneWeight
		{
			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int _boneIndex0;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int _boneIndex1;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int _boneIndex2;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int _boneIndex3;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float _boneWeight0;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float _boneWeight1;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float _boneWeight2;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float _boneWeight3;

			[Token(Token = "0x600046B")]
			[Address(RVA = "0xA80328", Offset = "0xA80328", VA = "0xA80328")]
			public SerializableBoneWeight(BoneWeight boneWeight)
			{
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0xA803F0", Offset = "0xA803F0", VA = "0xA803F0")]
			public BoneWeight ToBoneWeight()
			{
				return default(BoneWeight);
			}
		}

		[Token(Token = "0x20000B9")]
		public class UniqueVertex
		{
			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int m_nFixedX;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int m_nFixedY;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int m_nFixedZ;

			[Token(Token = "0x400042F")]
			private const float fDecimalMultiplier = 100000f;

			[Token(Token = "0x600046D")]
			[Address(RVA = "0xA804A8", Offset = "0xA804A8", VA = "0xA804A8", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0xA80568", Offset = "0xA80568", VA = "0xA80568", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0xA80194", Offset = "0xA80194", VA = "0xA80194")]
			public UniqueVertex(Vector3 v3Vertex)
			{
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0xA805C8", Offset = "0xA805C8", VA = "0xA805C8")]
			public Vector3 ToVertex()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0xA80678", Offset = "0xA80678", VA = "0xA80678")]
			public static bool operator ==(UniqueVertex a, UniqueVertex b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0xA80694", Offset = "0xA80694", VA = "0xA80694")]
			public static bool operator !=(UniqueVertex a, UniqueVertex b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0xA8057C", Offset = "0xA8057C", VA = "0xA8057C")]
			private void FromVertex(Vector3 vertex)
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0xA806C0", Offset = "0xA806C0", VA = "0xA806C0")]
			private int CoordToFixed(float fCoord)
			{
				return default(int);
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0xA80654", Offset = "0xA80654", VA = "0xA80654")]
			private float FixedToCoord(int nFixed)
			{
				return default(float);
			}
		}

		[Token(Token = "0x20000BA")]
		private class RepeatedVertex
		{
			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _nFaceIndex;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int _nOriginalVertexIndex;

			[Token(Token = "0x170000CD")]
			public int FaceIndex
			{
				[Token(Token = "0x6000476")]
				[Address(RVA = "0xA803D8", Offset = "0xA803D8", VA = "0xA803D8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170000CE")]
			public int OriginalVertexIndex
			{
				[Token(Token = "0x6000477")]
				[Address(RVA = "0xA803E0", Offset = "0xA803E0", VA = "0xA803E0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0xA801E4", Offset = "0xA801E4", VA = "0xA801E4")]
			public RepeatedVertex(int nFaceIndex, int nOriginalVertexIndex)
			{
			}
		}

		[Token(Token = "0x20000BB")]
		private class RepeatedVertexList
		{
			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int m_nUniqueIndex;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<RepeatedVertex> m_listRepeatedVertices;

			[Token(Token = "0x170000CF")]
			public int UniqueIndex
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0xA803E8", Offset = "0xA803E8", VA = "0xA803E8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0xA80284", Offset = "0xA80284", VA = "0xA80284")]
			public RepeatedVertexList(int nUniqueIndex, RepeatedVertex repeatedVertex)
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0xA8021C", Offset = "0xA8021C", VA = "0xA8021C")]
			public void Add(RepeatedVertex repeatedVertex)
			{
			}
		}

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<Vector3> m_listVertices;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Vector3> m_listVerticesWorld;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<SerializableBoneWeight> m_listBoneWeights;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ListIndices[] m_aFaceList;

		[Token(Token = "0x1700002B")]
		public ListIndices[] SubmeshesFaceList
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0xA7FB64", Offset = "0xA7FB64", VA = "0xA7FB64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public List<Vector3> ListVertices
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0xA7FB6C", Offset = "0xA7FB6C", VA = "0xA7FB6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public List<Vector3> ListVerticesWorld
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xA7FB74", Offset = "0xA7FB74", VA = "0xA7FB74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public List<SerializableBoneWeight> ListBoneWeights
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xA7FB7C", Offset = "0xA7FB7C", VA = "0xA7FB7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xA7FB84", Offset = "0xA7FB84", VA = "0xA7FB84")]
		public void BuildData(Mesh sourceMesh, Vector3[] av3VerticesWorld)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xA803D0", Offset = "0xA803D0", VA = "0xA803D0")]
		public MeshUniqueVertices()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class RelevanceSphere
	{
		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bExpanded;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 m_v3Position;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 m_v3Rotation;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 m_v3Scale;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m_fRelevance;

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xA80758", Offset = "0xA80758", VA = "0xA80758")]
		public RelevanceSphere()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xA807D4", Offset = "0xA807D4", VA = "0xA807D4")]
		public void SetDefault(Transform target, float fRelevance)
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class Simplifier : MonoBehaviour
	{
		[Token(Token = "0x20000BC")]
		public delegate void ProgressDelegate(string strTitle, string strProgressMessage, float fT);

		[Token(Token = "0x20000BD")]
		private class Triangle
		{
			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vertex[] m_aVertices;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool m_bUVData;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int[] m_aUV;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int[] m_aIndices;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 m_v3Normal;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int m_nSubMesh;

			[Token(Token = "0x170000D0")]
			public Vertex[] Vertices
			{
				[Token(Token = "0x6000480")]
				[Address(RVA = "0xA56408", Offset = "0xA56408", VA = "0xA56408")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			public bool HasUVData
			{
				[Token(Token = "0x6000481")]
				[Address(RVA = "0xA56410", Offset = "0xA56410", VA = "0xA56410")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000D2")]
			public int[] IndicesUV
			{
				[Token(Token = "0x6000482")]
				[Address(RVA = "0xA56418", Offset = "0xA56418", VA = "0xA56418")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D3")]
			public Vector3 Normal
			{
				[Token(Token = "0x6000483")]
				[Address(RVA = "0xA56420", Offset = "0xA56420", VA = "0xA56420")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D4")]
			public int[] Indices
			{
				[Token(Token = "0x6000484")]
				[Address(RVA = "0xA5642C", Offset = "0xA5642C", VA = "0xA5642C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0xA56434", Offset = "0xA56434", VA = "0xA56434")]
			public Triangle(Simplifier simplifier, int nSubMesh, Vertex v0, Vertex v1, Vertex v2, bool bUVData, int nIndex1, int nIndex2, int nIndex3)
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0xA56914", Offset = "0xA56914", VA = "0xA56914")]
			public void Destructor(Simplifier simplifier)
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0xA56B78", Offset = "0xA56B78", VA = "0xA56B78")]
			public bool HasVertex(Vertex v)
			{
				return default(bool);
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0xA56788", Offset = "0xA56788", VA = "0xA56788")]
			public void ComputeNormal()
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0xA56BE4", Offset = "0xA56BE4", VA = "0xA56BE4")]
			public int TexAt(Vertex vertex)
			{
				return default(int);
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0xA56CD0", Offset = "0xA56CD0", VA = "0xA56CD0")]
			public int TexAt(int i)
			{
				return default(int);
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0xA56D0C", Offset = "0xA56D0C", VA = "0xA56D0C")]
			public void SetTexAt(Vertex vertex, int uv)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0xA56E00", Offset = "0xA56E00", VA = "0xA56E00")]
			public void SetTexAt(int i, int uv)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0xA56E3C", Offset = "0xA56E3C", VA = "0xA56E3C")]
			public void ReplaceVertex(Vertex vold, Vertex vnew)
			{
			}
		}

		[Token(Token = "0x20000BE")]
		private class TriangleList
		{
			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Triangle> m_listTriangles;

			[Token(Token = "0x600048E")]
			[Address(RVA = "0xA54648", Offset = "0xA54648", VA = "0xA54648")]
			public TriangleList()
			{
			}
		}

		[Token(Token = "0x20000BF")]
		private class Vertex
		{
			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 m_v3Position;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 m_v3PositionWorld;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool m_bHasBoneWeight;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public BoneWeight m_boneWeight;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public int m_nID;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public List<Vertex> m_listNeighbors;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<Triangle> m_listFaces;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float m_fObjDist;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Vertex m_collapse;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public int m_nHeapSpot;

			[Token(Token = "0x600048F")]
			[Address(RVA = "0xA570A4", Offset = "0xA570A4", VA = "0xA570A4")]
			public Vertex(Simplifier simplifier, Vector3 v, Vector3 v3World, bool bHasBoneWeight, BoneWeight boneWeight, int nID)
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0xA571D4", Offset = "0xA571D4", VA = "0xA571D4")]
			public void Destructor(Simplifier simplifier)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0xA56A8C", Offset = "0xA56A8C", VA = "0xA56A8C")]
			public void RemoveIfNonNeighbor(Vertex n)
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0xA572A8", Offset = "0xA572A8", VA = "0xA572A8")]
			public bool IsBorder()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C0")]
		private class VertexDataHashComparer : IEqualityComparer<VertexDataHash>
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0xA5760C", Offset = "0xA5760C", VA = "0xA5760C", Slot = "4")]
			public bool Equals(VertexDataHash a, VertexDataHash b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0xA57798", Offset = "0xA57798", VA = "0xA57798", Slot = "5")]
			public int GetHashCode(VertexDataHash vdata)
			{
				return default(int);
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0xA55780", Offset = "0xA55780", VA = "0xA55780")]
			public VertexDataHashComparer()
			{
			}
		}

		[Token(Token = "0x20000C1")]
		private class VertexDataHash
		{
			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector3 _v3Vertex;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector3 _v3Normal;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector2 _v2Mapping1;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector2 _v2Mapping2;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Color32 _color;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private MeshUniqueVertices.UniqueVertex _uniqueVertex;

			[Token(Token = "0x170000D5")]
			public Vector3 Vertex
			{
				[Token(Token = "0x6000496")]
				[Address(RVA = "0xA573B8", Offset = "0xA573B8", VA = "0xA573B8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D6")]
			public Vector3 Normal
			{
				[Token(Token = "0x6000497")]
				[Address(RVA = "0xA573C4", Offset = "0xA573C4", VA = "0xA573C4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D7")]
			public Vector2 UV1
			{
				[Token(Token = "0x6000498")]
				[Address(RVA = "0xA573D0", Offset = "0xA573D0", VA = "0xA573D0")]
				get
				{
					return default(Vector2);
				}
			}

			[Token(Token = "0x170000D8")]
			public Vector2 UV2
			{
				[Token(Token = "0x6000499")]
				[Address(RVA = "0xA573D8", Offset = "0xA573D8", VA = "0xA573D8")]
				get
				{
					return default(Vector2);
				}
			}

			[Token(Token = "0x170000D9")]
			public Color32 Color
			{
				[Token(Token = "0x600049A")]
				[Address(RVA = "0xA573E0", Offset = "0xA573E0", VA = "0xA573E0")]
				get
				{
					return default(Color32);
				}
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0xA55788", Offset = "0xA55788", VA = "0xA55788")]
			public VertexDataHash(Vector3 v3Vertex, Vector3 v3Normal, Vector2 v2Mapping1, Vector2 v2Mapping2, Color32 color)
			{
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0xA573E8", Offset = "0xA573E8", VA = "0xA573E8", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0xA575A4", Offset = "0xA575A4", VA = "0xA575A4", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0xA575C4", Offset = "0xA575C4", VA = "0xA575C4")]
			public static bool operator ==(VertexDataHash a, VertexDataHash b)
			{
				return default(bool);
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0xA575E0", Offset = "0xA575E0", VA = "0xA575E0")]
			public static bool operator !=(VertexDataHash a, VertexDataHash b)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3CF8", Offset = "0x7D3CF8")]
		private sealed class <ProgressiveMesh>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Simplifier <>4__this;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Mesh sourceMesh;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject gameObject;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ProgressDelegate progress;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string strProgressDisplayObjectName;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public RelevanceSphere[] aRelevanceSpheres;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int <nVertices>5__2;

			[Token(Token = "0x170000DA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004A3")]
				[Address(RVA = "0xA562DC", Offset = "0xA562DC", VA = "0xA562DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004A5")]
				[Address(RVA = "0xA56344", Offset = "0xA56344", VA = "0xA56344", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xA558E0", Offset = "0xA558E0", VA = "0xA558E0")]
			[DebuggerHidden]
			public <ProgressiveMesh>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xA5590C", Offset = "0xA5590C", VA = "0xA5590C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xA55910", Offset = "0xA55910", VA = "0xA55910", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xA562E4", Offset = "0xA562E4", VA = "0xA562E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3D08", Offset = "0x7D3D08")]
		private sealed class <ComputeMeshWithVertexCount>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Simplifier <>4__this;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int nVertices;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Mesh meshOut;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public GameObject gameObject;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public ProgressDelegate progress;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string strProgressDisplayObjectName;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private List<Vertex> <listVertices>5__2;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int <nTotalVertices>5__3;

			[Token(Token = "0x170000DC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004A9")]
				[Address(RVA = "0xA546BC", Offset = "0xA546BC", VA = "0xA546BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004AB")]
				[Address(RVA = "0xA54724", Offset = "0xA54724", VA = "0xA54724", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xA53AEC", Offset = "0xA53AEC", VA = "0xA53AEC")]
			[DebuggerHidden]
			public <ComputeMeshWithVertexCount>d__25(int <>1__state)
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xA53B18", Offset = "0xA53B18", VA = "0xA53B18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xA53B1C", Offset = "0xA53B1C", VA = "0xA53B1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xA546C4", Offset = "0xA546C4", VA = "0xA546C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3D18", Offset = "0x7D3D18")]
		private sealed class <ConsolidateMesh>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Mesh meshIn;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TriangleList[] aListTriangles;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ProgressDelegate progress;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string strProgressDisplayObjectName;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Mesh meshOut;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public GameObject gameObject;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Vector3[] <av3NormalsIn>5__2;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector4[] <av4TangentsIn>5__3;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector2[] <av2Mapping1In>5__4;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector2[] <av2Mapping2In>5__5;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Color[] <acolColorsIn>5__6;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Color32[] <aColors32In>5__7;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private List<List<int>> <listlistIndicesOut>5__8;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private List<Vector3> <listVerticesOut>5__9;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private List<Vector3> <listNormalsOut>5__10;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private List<Vector4> <listTangentsOut>5__11;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private List<Vector2> <listMapping1Out>5__12;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private List<Vector2> <listMapping2Out>5__13;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private List<Color32> <listColors32Out>5__14;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private List<BoneWeight> <listBoneWeightsOut>5__15;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Dictionary<VertexDataHash, int> <dicVertexDataHash2Index>5__16;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private bool <bUV1>5__17;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
			private bool <bUV2>5__18;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
			private bool <bNormal>5__19;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCB")]
			private bool <bTangent>5__20;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int <nSubMesh>5__21;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private List<int> <listIndicesOut>5__22;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private string <strMesh>5__23;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private int <i>5__24;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004AF")]
				[Address(RVA = "0xA55870", Offset = "0xA55870", VA = "0xA55870", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004B1")]
				[Address(RVA = "0xA558D8", Offset = "0xA558D8", VA = "0xA558D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xA5472C", Offset = "0xA5472C", VA = "0xA5472C")]
			[DebuggerHidden]
			public <ConsolidateMesh>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xA54758", Offset = "0xA54758", VA = "0xA54758", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0xA5475C", Offset = "0xA5475C", VA = "0xA5475C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0xA55878", Offset = "0xA55878", VA = "0xA55878", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3D28", Offset = "0x7D3D28")]
		private sealed class <ComputeAllEdgeCollapseCosts>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ProgressDelegate progress;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string strProgressDisplayObjectName;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Simplifier <>4__this;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform transform;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RelevanceSphere[] aRelevanceSpheres;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <i>5__2;

			[Token(Token = "0x170000E0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004B5")]
				[Address(RVA = "0xA53A7C", Offset = "0xA53A7C", VA = "0xA53A7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004B7")]
				[Address(RVA = "0xA53AE4", Offset = "0xA53AE4", VA = "0xA53AE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0xA532BC", Offset = "0xA532BC", VA = "0xA532BC")]
			[DebuggerHidden]
			public <ComputeAllEdgeCollapseCosts>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0xA532E8", Offset = "0xA532E8", VA = "0xA532E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0xA532EC", Offset = "0xA532EC", VA = "0xA532EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xA53A84", Offset = "0xA53A84", VA = "0xA53A84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4DDC", Offset = "0x7D4DDC")]
		private static bool <Cancelled>k__BackingField;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D4DEC", Offset = "0x7D4DEC")]
		private bool <CoroutineEnded>k__BackingField;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int m_nCoroutineFrameMiliseconds;

		[Token(Token = "0x40002AB")]
		private const float MAX_VERTEX_COLLAPSE_COST = 10000000f;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Vertex> m_listVertices;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Vertex> m_listHeap;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TriangleList[] m_aListTriangles;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private int m_nOriginalMeshVertexCount;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		private float m_fOriginalMeshSize;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private List<int> m_listVertexMap;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private List<int> m_listVertexPermutationBack;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private MeshUniqueVertices m_meshUniqueVertices;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private Mesh m_meshOriginal;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private bool m_bUseEdgeLength;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		[HideInInspector]
		private bool m_bUseCurvature;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		[SerializeField]
		[HideInInspector]
		private bool m_bProtectTexture;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		[SerializeField]
		[HideInInspector]
		private bool m_bLockBorder;

		[Token(Token = "0x1700002F")]
		public static bool Cancelled
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0xA808F0", Offset = "0xA808F0", VA = "0xA808F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6310", Offset = "0x7D6310")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xA80958", Offset = "0xA80958", VA = "0xA80958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6320", Offset = "0x7D6320")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public static int CoroutineFrameMiliseconds
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xA809C8", Offset = "0xA809C8", VA = "0xA809C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0xA80A30", Offset = "0xA80A30", VA = "0xA80A30")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool CoroutineEnded
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0xA80A9C", Offset = "0xA80A9C", VA = "0xA80A9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6330", Offset = "0x7D6330")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0xA80AA4", Offset = "0xA80AA4", VA = "0xA80AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6340", Offset = "0x7D6340")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public bool UseEdgeLength
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0xA80AB0", Offset = "0xA80AB0", VA = "0xA80AB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0xA80AB8", Offset = "0xA80AB8", VA = "0xA80AB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool UseCurvature
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0xA80AC4", Offset = "0xA80AC4", VA = "0xA80AC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0xA80ACC", Offset = "0xA80ACC", VA = "0xA80ACC")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool ProtectTexture
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xA80AD8", Offset = "0xA80AD8", VA = "0xA80AD8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xA80AE0", Offset = "0xA80AE0", VA = "0xA80AE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public bool LockBorder
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xA80AEC", Offset = "0xA80AEC", VA = "0xA80AEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xA80AF4", Offset = "0xA80AF4", VA = "0xA80AF4")]
			set
			{
			}
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xA7ACC0", Offset = "0xA7ACC0", VA = "0xA7ACC0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D6350", Offset = "0x7D6350")]
		public IEnumerator ProgressiveMesh(GameObject gameObject, Mesh sourceMesh, RelevanceSphere[] aRelevanceSpheres, string strProgressDisplayObjectName = "", [Optional] ProgressDelegate progress)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xA7B484", Offset = "0xA7B484", VA = "0xA7B484")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D63B4", Offset = "0x7D63B4")]
		public IEnumerator ComputeMeshWithVertexCount(GameObject gameObject, Mesh meshOut, int nVertices, string strProgressDisplayObjectName = "", [Optional] ProgressDelegate progress)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xA80B00", Offset = "0xA80B00", VA = "0xA80B00")]
		public int GetOriginalMeshUniqueVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xA80B08", Offset = "0xA80B08", VA = "0xA80B08")]
		public int GetOriginalMeshTriangleCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xA80B4C", Offset = "0xA80B4C", VA = "0xA80B4C")]
		public static Vector3[] GetWorldVertices(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xA81454", Offset = "0xA81454", VA = "0xA81454")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D6418", Offset = "0x7D6418")]
		private IEnumerator ConsolidateMesh(GameObject gameObject, Mesh meshIn, Mesh meshOut, TriangleList[] aListTriangles, Vector3[] av3Vertices, string strProgressDisplayObjectName = "", [Optional] ProgressDelegate progress)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xA814F8", Offset = "0xA814F8", VA = "0xA814F8")]
		private int MapVertex(int nVertex, int nMax)
		{
			return default(int);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xA81590", Offset = "0xA81590", VA = "0xA81590")]
		private float ComputeEdgeCollapseCost(Vertex u, Vertex v, float fRelevanceBias)
		{
			return default(float);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xA81A4C", Offset = "0xA81A4C", VA = "0xA81A4C")]
		private void ComputeEdgeCostAtVertex(Vertex v, Transform transform, RelevanceSphere[] aRelevanceSpheres)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xA81D5C", Offset = "0xA81D5C", VA = "0xA81D5C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7D647C", Offset = "0x7D647C")]
		private IEnumerator ComputeAllEdgeCollapseCosts(string strProgressDisplayObjectName, Transform transform, RelevanceSphere[] aRelevanceSpheres, [Optional] ProgressDelegate progress)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xA81DF4", Offset = "0xA81DF4", VA = "0xA81DF4")]
		private void Collapse(Vertex u, Vertex v, bool bRecompute, Transform transform, RelevanceSphere[] aRelevanceSpheres)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xA82708", Offset = "0xA82708", VA = "0xA82708")]
		private void AddVertices(List<Vector3> listVertices, List<Vector3> listVerticesWorld, List<MeshUniqueVertices.SerializableBoneWeight> listBoneWeights)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xA828C0", Offset = "0xA828C0", VA = "0xA828C0")]
		private void AddFaceListSubMesh(int nSubMesh, List<int> listTriangles, int[] anIndices, Vector2[] v2Mapping)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xA82B60", Offset = "0xA82B60", VA = "0xA82B60")]
		private void ShareUV(Vector2[] aMapping, Triangle t)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xA82D74", Offset = "0xA82D74", VA = "0xA82D74")]
		private Vertex MinimumCostEdge()
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xA82E18", Offset = "0xA82E18", VA = "0xA82E18")]
		private float HeapValue(int i)
		{
			return default(float);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xA8233C", Offset = "0xA8233C", VA = "0xA8233C")]
		private void HeapSortUp(int k)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xA82510", Offset = "0xA82510", VA = "0xA82510")]
		private void HeapSortDown(int k)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xA82EE4", Offset = "0xA82EE4", VA = "0xA82EE4")]
		private void HeapAdd(Vertex v)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xA82D78", Offset = "0xA82D78", VA = "0xA82D78")]
		private Vertex HeapPop()
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xA82F64", Offset = "0xA82F64", VA = "0xA82F64")]
		public Simplifier()
		{
		}
	}
}
namespace PolyPups
{
	[Token(Token = "0x200006A")]
	public enum ControllerType
	{
		[Token(Token = "0x40002BA")]
		GearVR,
		[Token(Token = "0x40002BB")]
		Daydream
	}
	[Token(Token = "0x200006B")]
	public class PPVRInput : MonoBehaviour
	{
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool AppButton;

		[Token(Token = "0x17000036")]
		public static bool ClickButtonDown
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0xA6D7D4", Offset = "0xA6D7D4", VA = "0xA6D7D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public static bool ClickButtonUp
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0xA6D834", Offset = "0xA6D834", VA = "0xA6D834")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public static bool ClickButton
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0xA6D804", Offset = "0xA6D804", VA = "0xA6D804")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public static bool TouchDown
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0xA6D83C", Offset = "0xA6D83C", VA = "0xA6D83C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public static bool IsTouching
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0xA6D844", Offset = "0xA6D844", VA = "0xA6D844")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public static bool TouchUp
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xA6D84C", Offset = "0xA6D84C", VA = "0xA6D84C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public static Vector2 TouchPos
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0xA6D854", Offset = "0xA6D854", VA = "0xA6D854")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x1700003D")]
		public static bool PrimaryIndexTriggerDown
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0xA7CA0C", Offset = "0xA7CA0C", VA = "0xA7CA0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		public static bool PrimaryIndexTrigger
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0xA7CA10", Offset = "0xA7CA10", VA = "0xA7CA10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public static bool PrimaryIndexTriggerUp
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0xA7CA14", Offset = "0xA7CA14", VA = "0xA7CA14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public static bool AppButtonDown
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0xA7CA18", Offset = "0xA7CA18", VA = "0xA7CA18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		public static bool AppButtonUp
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0xA7CA1C", Offset = "0xA7CA1C", VA = "0xA7CA1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		public static Quaternion Orientation
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0xA7CA20", Offset = "0xA7CA20", VA = "0xA7CA20")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000043")]
		public static Vector3 Gyro
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0xA7CA24", Offset = "0xA7CA24", VA = "0xA7CA24")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000044")]
		public static ControllerType Platform
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0xA7CA28", Offset = "0xA7CA28", VA = "0xA7CA28")]
			get
			{
				return default(ControllerType);
			}
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xA7CA30", Offset = "0xA7CA30", VA = "0xA7CA30")]
		public PPVRInput()
		{
		}
	}
}
namespace KN
{
	[Token(Token = "0x200006C")]
	public interface IKN_ArmModelReciever
	{
		[Token(Token = "0x17000045")]
		KN_BaseArmModel ArmModel
		{
			[Token(Token = "0x6000298")]
			get;
			[Token(Token = "0x6000299")]
			set;
		}
	}
	[Token(Token = "0x200006D")]
	public class KN_ArmModel : KN_BaseArmModel
	{
		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 elbowRestPosition;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 wristRestPosition;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 controllerRestPosition;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 armExtensionOffset;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D502C", Offset = "0x7D502C")]
		public float elbowBendRatio;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D5044", Offset = "0x7D5044")]
		public float fadeControllerOffset;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D5060", Offset = "0x7D5060")]
		public float fadeDistanceFromHeadForward;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D507C", Offset = "0x7D507C")]
		public float fadeDistanceFromHeadSide;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D5098", Offset = "0x7D5098")]
		public float tooltipMinDistanceFromFace;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D50B8", Offset = "0x7D50B8")]
		public int tooltipMaxAngleFromCamera;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool isLockedToNeck;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected Vector3 neckPosition;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Vector3 elbowPosition;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected Quaternion elbowRotation;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected Vector3 wristPosition;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Quaternion wristRotation;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected Vector3 controllerPosition;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		protected Quaternion controllerRotation;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		protected float preferredAlpha;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected float tooltipAlphaValue;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		protected Vector3 handedMultiplier;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected Vector3 torsoDirection;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		protected Quaternion torsoRotation;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector3 DEFAULT_ELBOW_REST_POSITION;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly Vector3 DEFAULT_WRIST_REST_POSITION;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Vector3 DEFAULT_CONTROLLER_REST_POSITION;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly Vector3 DEFAULT_ARM_EXTENSION_OFFSET;

		[Token(Token = "0x40002D8")]
		public const float DEFAULT_ELBOW_BEND_RATIO = 0.6f;

		[Token(Token = "0x40002D9")]
		protected const float EXTENSION_WEIGHT = 0.4f;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected static readonly Vector3 SHOULDER_POSITION;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected static readonly Vector3 NECK_OFFSET;

		[Token(Token = "0x40002DC")]
		protected const float DELTA_ALPHA = 4f;

		[Token(Token = "0x40002DD")]
		protected const float MIN_EXTENSION_ANGLE = 7f;

		[Token(Token = "0x40002DE")]
		protected const float MAX_EXTENSION_ANGLE = 60f;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x17000046")]
		public override Vector3 ControllerPositionFromHead
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0xA6B660", Offset = "0xA6B660", VA = "0xA6B660", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000047")]
		public override Quaternion ControllerRotationFromHead
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0xA6B66C", Offset = "0xA6B66C", VA = "0xA6B66C", Slot = "5")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000048")]
		public override float PreferredAlpha
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0xA6B678", Offset = "0xA6B678", VA = "0xA6B678", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000049")]
		public override float TooltipAlphaValue
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0xA6B680", Offset = "0xA6B680", VA = "0xA6B680", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004A")]
		public Vector3 NeckPosition
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0xA6B688", Offset = "0xA6B688", VA = "0xA6B688")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004B")]
		public Vector3 ShoulderPosition
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0xA6B694", Offset = "0xA6B694", VA = "0xA6B694")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004C")]
		public Quaternion ShoulderRotation
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0xA6B800", Offset = "0xA6B800", VA = "0xA6B800")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700004D")]
		public Vector3 ElbowPosition
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0xA6B80C", Offset = "0xA6B80C", VA = "0xA6B80C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004E")]
		public Quaternion ElbowRotation
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0xA6B818", Offset = "0xA6B818", VA = "0xA6B818")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700004F")]
		public Vector3 WristPosition
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0xA6B824", Offset = "0xA6B824", VA = "0xA6B824")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000050")]
		public Quaternion WristRotation
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0xA6B830", Offset = "0xA6B830", VA = "0xA6B830")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xA6B83C", Offset = "0xA6B83C", VA = "0xA6B83C", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xA6B98C", Offset = "0xA6B98C", VA = "0xA6B98C", Slot = "9")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xA6BAB8", Offset = "0xA6BAB8", VA = "0xA6BAB8", Slot = "10")]
		protected virtual void OnControllerInputUpdated()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xA6BB2C", Offset = "0xA6BB2C", VA = "0xA6BB2C", Slot = "11")]
		protected virtual void UpdateHandedness()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xA6BBF4", Offset = "0xA6BBF4", VA = "0xA6BBF4", Slot = "12")]
		protected virtual void UpdateTorsoDirection(bool forceImmediate)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xA6C100", Offset = "0xA6C100", VA = "0xA6C100", Slot = "13")]
		protected virtual void UpdateNeckPosition()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xA6C200", Offset = "0xA6C200", VA = "0xA6C200", Slot = "14")]
		protected virtual void ApplyArmModel()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xA6C4B8", Offset = "0xA6C4B8", VA = "0xA6C4B8", Slot = "15")]
		protected virtual void SetUntransformedJointPositions()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xA6C5C0", Offset = "0xA6C5C0", VA = "0xA6C5C0", Slot = "16")]
		protected virtual float CalculateExtensionRatio(float xAngle)
		{
			return default(float);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xA6C648", Offset = "0xA6C648", VA = "0xA6C648", Slot = "17")]
		protected virtual void ApplyExtensionOffset(float extensionRatio)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xA6C738", Offset = "0xA6C738", VA = "0xA6C738", Slot = "18")]
		protected virtual Quaternion CalculateLerpRotation(Quaternion xyRotation, float extensionRatio)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xA6C880", Offset = "0xA6C880", VA = "0xA6C880", Slot = "19")]
		protected virtual void CalculateFinalJointRotations(Quaternion controllerOrientation, Quaternion xyRotation, Quaternion lerpRotation)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xA6C9D0", Offset = "0xA6C9D0", VA = "0xA6C9D0", Slot = "20")]
		protected virtual void ApplyRotationToJoints()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xA6CB84", Offset = "0xA6CB84", VA = "0xA6CB84", Slot = "21")]
		protected virtual Vector3 ApplyInverseNeckModel(Vector3 headPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xA6CD70", Offset = "0xA6CD70", VA = "0xA6CD70", Slot = "22")]
		protected virtual void UpdateTransparency()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xA6C324", Offset = "0xA6C324", VA = "0xA6C324")]
		protected void GetControllerRotation(out Quaternion rotation, out Quaternion xyRotation, out float xAngle)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xA6D30C", Offset = "0xA6D30C", VA = "0xA6D30C")]
		public KN_ArmModel()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public abstract class KN_BaseArmModel : MonoBehaviour
	{
		[Token(Token = "0x17000051")]
		public abstract Vector3 ControllerPositionFromHead
		{
			[Token(Token = "0x60002B7")]
			get;
		}

		[Token(Token = "0x17000052")]
		public abstract Quaternion ControllerRotationFromHead
		{
			[Token(Token = "0x60002B8")]
			get;
		}

		[Token(Token = "0x17000053")]
		public abstract float PreferredAlpha
		{
			[Token(Token = "0x60002B9")]
			get;
		}

		[Token(Token = "0x17000054")]
		public abstract float TooltipAlphaValue
		{
			[Token(Token = "0x60002BA")]
			get;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xA6D3EC", Offset = "0xA6D3EC", VA = "0xA6D3EC")]
		protected KN_BaseArmModel()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class ControllerState
	{
		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal KN_ConnectionState connectionState;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal Quaternion orientation;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal Vector3 gyro;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal Vector3 accel;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal bool isTouching;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal Vector2 touchPos;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal bool touchDown;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		internal bool touchUp;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		internal bool recentered;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		internal bool clickButtonState;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal bool clickButtonDown;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		internal bool clickButtonUp;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		internal bool appButtonState;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		internal bool appButtonDown;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal bool appButtonUp;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		internal bool homeButtonDown;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		internal bool homeButtonUp;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		internal bool homeButtonState;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal string errorDetails;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal bool isCharging;

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xA6A98C", Offset = "0xA6A98C", VA = "0xA6A98C")]
		public void CopyFrom(ControllerState other)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xA6AA50", Offset = "0xA6AA50", VA = "0xA6AA50")]
		public void ClearTransientState()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xA6AA64", Offset = "0xA6AA64", VA = "0xA6AA64")]
		public ControllerState()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class MouseControllerProvider
	{
		[Token(Token = "0x40002F4")]
		private const string AXIS_MOUSE_X = "Mouse X";

		[Token(Token = "0x40002F5")]
		private const string AXIS_MOUSE_Y = "Mouse Y";

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ControllerState state;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 mouseDelta;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool wasClickButton;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool wasAppButton;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private bool wasHomeButton;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		private bool wasTouching;

		[Token(Token = "0x40002FC")]
		private const float ROTATE_SENSITIVITY = 4.5f;

		[Token(Token = "0x40002FD")]
		private const float TOUCH_SENSITIVITY = 0.12f;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 INVERT_Y;

		[Token(Token = "0x17000055")]
		public static bool IsMouseAvailable
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xA792A4", Offset = "0xA792A4", VA = "0xA792A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public static bool IsActivateButtonPressed
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xA7931C", Offset = "0xA7931C", VA = "0xA7931C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		public static bool IsClickButtonPressed
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xA79350", Offset = "0xA79350", VA = "0xA79350")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		public static bool IsAppButtonPressed
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xA7935C", Offset = "0xA7935C", VA = "0xA7935C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		public static bool IsHomeButtonPressed
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xA79368", Offset = "0xA79368", VA = "0xA79368")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005A")]
		public static bool IsTouching
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xA79374", Offset = "0xA79374", VA = "0xA79374")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		public bool SupportsBatteryStatus
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xA793A8", Offset = "0xA793A8", VA = "0xA793A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xA6F870", Offset = "0xA6F870", VA = "0xA6F870")]
		internal MouseControllerProvider()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xA793B0", Offset = "0xA793B0", VA = "0xA793B0")]
		public void ReadState(ControllerState outState)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xA795A0", Offset = "0xA795A0", VA = "0xA795A0")]
		public void OnPause()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xA795A4", Offset = "0xA795A4", VA = "0xA795A4")]
		public void OnResume()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xA79488", Offset = "0xA79488", VA = "0xA79488")]
		private void UpdateState()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xA7986C", Offset = "0xA7986C", VA = "0xA7986C")]
		private void UpdateTouchPos()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xA79974", Offset = "0xA79974", VA = "0xA79974")]
		private void UpdateOrientation()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xA79610", Offset = "0xA79610", VA = "0xA79610")]
		private void UpdateButtonStates()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xA79BFC", Offset = "0xA79BFC", VA = "0xA79BFC")]
		private void Recenter()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xA79BB8", Offset = "0xA79BB8", VA = "0xA79BB8")]
		private void ClearTouchPos()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xA795A8", Offset = "0xA795A8", VA = "0xA795A8")]
		private void ClearState()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7D3924", Offset = "0x7D3924")]
	public class KN_ControllerInput : MonoBehaviour
	{
		[Token(Token = "0x20000C6")]
		public delegate void OnStateChangedEvent(KN_ConnectionState state, KN_ConnectionState oldState);

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static KN_ControllerInput instance;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private KN_ConnectionState connectionState;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MouseControllerProvider controllerProvider;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ControllerState controllerState;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int lastUpdatedFrameCount;

		[Token(Token = "0x1700005C")]
		public static KN_ConnectionState State
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xA6E690", Offset = "0xA6E690", VA = "0xA6E690")]
			get
			{
				return default(KN_ConnectionState);
			}
		}

		[Token(Token = "0x1700005D")]
		public static Quaternion Orientation
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0xA6D1A4", Offset = "0xA6D1A4", VA = "0xA6D1A4")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700005E")]
		public static Vector3 Gyro
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0xA6C00C", Offset = "0xA6C00C", VA = "0xA6C00C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700005F")]
		public static bool Recentered
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xA6BEDC", Offset = "0xA6BEDC", VA = "0xA6BEDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		public static bool ClickButtonDown
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xA6EB8C", Offset = "0xA6EB8C", VA = "0xA6EB8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		public static bool ClickButtonUp
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xA6EC64", Offset = "0xA6EC64", VA = "0xA6EC64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000062")]
		public static bool ClickButton
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xA6ED3C", Offset = "0xA6ED3C", VA = "0xA6ED3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000063")]
		public static bool TouchDown
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xA6EE14", Offset = "0xA6EE14", VA = "0xA6EE14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		public static bool IsTouching
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xA6EEEC", Offset = "0xA6EEEC", VA = "0xA6EEEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		public static bool TouchUp
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xA6EFC4", Offset = "0xA6EFC4", VA = "0xA6EFC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		public static Vector2 TouchPos
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xA6F09C", Offset = "0xA6F09C", VA = "0xA6F09C")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000067")]
		public static bool AppButtonDown
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xA6F238", Offset = "0xA6F238", VA = "0xA6F238")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		public static bool AppButtonUp
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xA6F310", Offset = "0xA6F310", VA = "0xA6F310")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		public static bool AppButton
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xA6F3E8", Offset = "0xA6F3E8", VA = "0xA6F3E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		public static bool PrimaryIndexTriggerDown
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0xA6F4C0", Offset = "0xA6F4C0", VA = "0xA6F4C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		public static bool PrimaryIndexTrigger
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xA6F598", Offset = "0xA6F598", VA = "0xA6F598")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		public static bool PrimaryIndexTriggerUp
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0xA6F670", Offset = "0xA6F670", VA = "0xA6F670")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action OnControllerInputUpdated
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xA6B8D4", Offset = "0xA6B8D4", VA = "0xA6B8D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D64E0", Offset = "0x7D64E0")]
			add
			{
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0xA6BA00", Offset = "0xA6BA00", VA = "0xA6BA00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D64F0", Offset = "0x7D64F0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public static event Action OnPostControllerInputUpdated
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xA6E8AC", Offset = "0xA6E8AC", VA = "0xA6E8AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6500", Offset = "0x7D6500")]
			add
			{
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0xA6E964", Offset = "0xA6E964", VA = "0xA6E964")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6510", Offset = "0x7D6510")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public static event OnStateChangedEvent OnStateChanged
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0xA6EA1C", Offset = "0xA6EA1C", VA = "0xA6EA1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6520", Offset = "0x7D6520")]
			add
			{
			}
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0xA6EAD4", Offset = "0xA6EAD4", VA = "0xA6EAD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6530", Offset = "0x7D6530")]
			remove
			{
			}
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xA6F748", Offset = "0xA6F748", VA = "0xA6F748")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xA6E748", Offset = "0xA6E748", VA = "0xA6E748")]
		private void Update()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xA6FB5C", Offset = "0xA6FB5C", VA = "0xA6FB5C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xA6FBBC", Offset = "0xA6FBBC", VA = "0xA6FBBC")]
		public KN_ControllerInput()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public enum KN_ConnectionState
	{
		[Token(Token = "0x4000308")]
		Error = -1,
		[Token(Token = "0x4000309")]
		Disconnected,
		[Token(Token = "0x400030A")]
		Connected
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D395C", Offset = "0x7D395C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D395C", Offset = "0x7D395C")]
	public class KN_ControllerReticleVisual : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C7")]
		public struct FaceCameraData
		{
			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool alongXAxis;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool alongYAxis;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool alongZAxis;

			[Token(Token = "0x170000E2")]
			public bool IsAnyAxisOff
			{
				[Token(Token = "0x60004BC")]
				[Address(RVA = "0x6CE26C", Offset = "0x6CE26C", VA = "0x6CE26C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x6CE294", Offset = "0x6CE294", VA = "0x6CE294")]
			public FaceCameraData(bool startEnabled)
			{
			}
		}

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5104", Offset = "0x7D5104")]
		public bool isSizeBasedOnCameraDistance;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D513C", Offset = "0x7D513C")]
		public float sizeMeters;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5174", Offset = "0x7D5174")]
		public FaceCameraData doesReticleFaceCamera;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D51AC", Offset = "0x7D51AC")]
		public int sortingOrder;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D51CC", Offset = "0x7D51CC")]
		private float <ReticleMeshSizeMeters>k__BackingField;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D51DC", Offset = "0x7D51DC")]
		private float <ReticleMeshSizeRatio>k__BackingField;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected MeshRenderer meshRenderer;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected MeshFilter meshFilter;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 preRenderLocalScale;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion preRenderLocalRotation;

		[Token(Token = "0x1700006D")]
		public float ReticleMeshSizeMeters
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xA6FCE4", Offset = "0xA6FCE4", VA = "0xA6FCE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6540", Offset = "0x7D6540")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xA6FCEC", Offset = "0xA6FCEC", VA = "0xA6FCEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6550", Offset = "0x7D6550")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public float ReticleMeshSizeRatio
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xA6FCF4", Offset = "0xA6FCF4", VA = "0xA6FCF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6560", Offset = "0x7D6560")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xA6FCFC", Offset = "0xA6FCFC", VA = "0xA6FCFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6570", Offset = "0x7D6570")]
			private set
			{
			}
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xA6FD04", Offset = "0xA6FD04", VA = "0xA6FD04")]
		public void RefreshMesh()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xA6FE7C", Offset = "0xA6FE7C", VA = "0xA6FE7C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xA6FEEC", Offset = "0xA6FEEC", VA = "0xA6FEEC", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xA6FEF0", Offset = "0xA6FEF0", VA = "0xA6FEF0", Slot = "6")]
		protected virtual void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xA6FF7C", Offset = "0xA6FF7C", VA = "0xA6FF7C", Slot = "7")]
		protected virtual void OnRenderObject()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xA6FFD4", Offset = "0xA6FFD4", VA = "0xA6FFD4", Slot = "8")]
		protected virtual void UpdateReticleSize(Camera camera)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xA70188", Offset = "0xA70188", VA = "0xA70188", Slot = "9")]
		protected virtual void UpdateReticleOrientation(Camera camera)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xA703EC", Offset = "0xA703EC", VA = "0xA703EC", Slot = "10")]
		protected virtual void OnValidate()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xA70434", Offset = "0xA70434", VA = "0xA70434")]
		public KN_ControllerReticleVisual()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D39E8", Offset = "0x7D39E8")]
	public class KN_LaserPointer : KN_BasePointer
	{
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D51EC", Offset = "0x7D51EC")]
		public float maxPointerDistance;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5224", Offset = "0x7D5224")]
		public float defaultReticleDistance;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D525C", Offset = "0x7D525C")]
		public float overrideCameraRayIntersectionDistance;

		[Token(Token = "0x4000318")]
		private const float RETICLE_VISUAL_RATIO = 0.1f;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5294", Offset = "0x7D5294")]
		private KN_LaserVisual <LaserVisual>k__BackingField;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isHittingTarget;

		[Token(Token = "0x1700006F")]
		public KN_LaserVisual LaserVisual
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0xA70B0C", Offset = "0xA70B0C", VA = "0xA70B0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6580", Offset = "0x7D6580")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xA70B14", Offset = "0xA70B14", VA = "0xA70B14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6590", Offset = "0x7D6590")]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public override float MaxPointerDistance
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xA70B1C", Offset = "0xA70B1C", VA = "0xA70B1C", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000071")]
		public override float CameraRayIntersectionDistance
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xA70B24", Offset = "0xA70B24", VA = "0xA70B24", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xA70BC0", Offset = "0xA70BC0", VA = "0xA70BC0", Slot = "16")]
		public override void OnPointerEnter(RaycastResult raycastResult, bool isInteractive)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xA70C04", Offset = "0xA70C04", VA = "0xA70C04", Slot = "17")]
		public override void OnPointerHover(RaycastResult raycastResult, bool isInteractive)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xA70C48", Offset = "0xA70C48", VA = "0xA70C48", Slot = "18")]
		public override void OnPointerExit(GameObject previousObject)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xA70C50", Offset = "0xA70C50", VA = "0xA70C50", Slot = "19")]
		public override void OnPointerClickDown()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xA70C54", Offset = "0xA70C54", VA = "0xA70C54", Slot = "20")]
		public override void OnPointerClickUp()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xA70C58", Offset = "0xA70C58", VA = "0xA70C58", Slot = "21")]
		public override void GetPointerRadius(out float enterRadius, out float exitRadius)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xA70D68", Offset = "0xA70D68", VA = "0xA70D68")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xA70DC0", Offset = "0xA70DC0", VA = "0xA70DC0", Slot = "22")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xA70E68", Offset = "0xA70E68", VA = "0xA70E68")]
		private void Update()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xA70EA0", Offset = "0xA70EA0", VA = "0xA70EA0")]
		public KN_LaserPointer()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3A4C", Offset = "0x7D3A4C")]
	public class KN_LaserVisual : MonoBehaviour, IKN_ArmModelReciever
	{
		[Token(Token = "0x20000C8")]
		public delegate Vector3 GetPointForDistanceDelegate(float distance);

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D52A4", Offset = "0x7D52A4")]
		public KN_ControllerReticleVisual reticle;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D52DC", Offset = "0x7D52DC")]
		public Transform controller;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5314", Offset = "0x7D5314")]
		public Color laserColor;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D534C", Offset = "0x7D534C")]
		public Color laserColorEnd;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5384", Offset = "0x7D5384")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D5384", Offset = "0x7D5384")]
		public float maxLaserDistance;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D53D8", Offset = "0x7D53D8")]
		public float lerpSpeed;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5410", Offset = "0x7D5410")]
		public float lerpThreshold;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5448", Offset = "0x7D5448")]
		public bool shrinkLaser;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D5480", Offset = "0x7D5480")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5480", Offset = "0x7D5480")]
		public float shrunkScale;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D54D4", Offset = "0x7D54D4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D54D4", Offset = "0x7D54D4")]
		public float beginShrinkAngleDegrees;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D5528", Offset = "0x7D5528")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5528", Offset = "0x7D5528")]
		public float endShrinkAngleDegrees;

		[Token(Token = "0x4000326")]
		private const float LERP_CLAMP_THRESHOLD = 0.02f;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D557C", Offset = "0x7D557C")]
		private KN_BaseArmModel <ArmModel>k__BackingField;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D558C", Offset = "0x7D558C")]
		private LineRenderer <Laser>k__BackingField;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D559C", Offset = "0x7D559C")]
		private GetPointForDistanceDelegate <GetPointForDistanceFunction>k__BackingField;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected float shrinkRatio;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float targetDistance;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected float currentDistance;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected Vector3 currentPosition;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 currentLocalPosition;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected Quaternion currentLocalRotation;

		[Token(Token = "0x17000072")]
		public KN_BaseArmModel ArmModel
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0xA70EB8", Offset = "0xA70EB8", VA = "0xA70EB8", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D65A0", Offset = "0x7D65A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000309")]
			[Address(RVA = "0xA70EC0", Offset = "0xA70EC0", VA = "0xA70EC0", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D65B0", Offset = "0x7D65B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public LineRenderer Laser
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0xA70EC8", Offset = "0xA70EC8", VA = "0xA70EC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D65C0", Offset = "0x7D65C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030B")]
			[Address(RVA = "0xA70ED0", Offset = "0xA70ED0", VA = "0xA70ED0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D65D0", Offset = "0x7D65D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public GetPointForDistanceDelegate GetPointForDistanceFunction
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xA70ED8", Offset = "0xA70ED8", VA = "0xA70ED8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D65E0", Offset = "0x7D65E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030D")]
			[Address(RVA = "0xA70EE0", Offset = "0xA70EE0", VA = "0xA70EE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D65F0", Offset = "0x7D65F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public float CurrentDistance
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0xA70F08", Offset = "0xA70F08", VA = "0xA70F08")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xA70EE8", Offset = "0xA70EE8", VA = "0xA70EE8", Slot = "6")]
		public virtual void SetDistance(float distance, bool immediate = false)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xA70F10", Offset = "0xA70F10", VA = "0xA70F10", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xA70F68", Offset = "0xA70F68", VA = "0xA70F68", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xA70FE0", Offset = "0xA70FE0", VA = "0xA70FE0", Slot = "9")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xA7104C", Offset = "0xA7104C", VA = "0xA7104C", Slot = "10")]
		protected virtual void UpdateCurrentPosition()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xA71514", Offset = "0xA71514", VA = "0xA71514", Slot = "11")]
		protected virtual void UpdateControllerOrientation()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xA715B0", Offset = "0xA715B0", VA = "0xA715B0", Slot = "12")]
		protected virtual void UpdateReticlePosition()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xA71658", Offset = "0xA71658", VA = "0xA71658", Slot = "13")]
		protected virtual void UpdateLaserEndPoint()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xA71C34", Offset = "0xA71C34", VA = "0xA71C34", Slot = "14")]
		protected virtual void UpdateLaserAlpha()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xA71DEC", Offset = "0xA71DEC", VA = "0xA71DEC", Slot = "15")]
		protected virtual float GetSpeed()
		{
			return default(float);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xA71E24", Offset = "0xA71E24", VA = "0xA71E24")]
		public KN_LaserVisual()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class KN_TrackedController : MonoBehaviour
	{
		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D55AC", Offset = "0x7D55AC")]
		private KN_BaseArmModel armModel;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D55F8", Offset = "0x7D55F8")]
		private bool isDeactivatedWhenDisconnected;

		[Token(Token = "0x17000076")]
		public KN_BaseArmModel ArmModel
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0xA78CB4", Offset = "0xA78CB4", VA = "0xA78CB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031B")]
			[Address(RVA = "0xA78CBC", Offset = "0xA78CBC", VA = "0xA78CBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public bool IsDeactivatedWhenDisconnected
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0xA78E80", Offset = "0xA78E80", VA = "0xA78E80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600031D")]
			[Address(RVA = "0xA78E88", Offset = "0xA78E88", VA = "0xA78E88")]
			set
			{
			}
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xA78D58", Offset = "0xA78D58", VA = "0xA78D58")]
		public void PropagateArmModel()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xA78F44", Offset = "0xA78F44", VA = "0xA78F44")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xA78FAC", Offset = "0xA78FAC", VA = "0xA78FAC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xA79130", Offset = "0xA79130", VA = "0xA79130")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xA791A0", Offset = "0xA791A0", VA = "0xA791A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xA791D4", Offset = "0xA791D4", VA = "0xA791D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xA7923C", Offset = "0xA7923C", VA = "0xA7923C")]
		private void OnPostControllerInputUpdated()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xA78EE4", Offset = "0xA78EE4", VA = "0xA78EE4")]
		private void OnControllerStateChanged(KN_ConnectionState state, KN_ConnectionState oldState)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xA7903C", Offset = "0xA7903C", VA = "0xA7903C")]
		private void UpdatePose()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xA79240", Offset = "0xA79240", VA = "0xA79240")]
		public KN_TrackedController()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public interface IKN_ScrollSettings
	{
		[Token(Token = "0x17000078")]
		bool InertiaOverride
		{
			[Token(Token = "0x6000328")]
			get;
		}

		[Token(Token = "0x17000079")]
		float DecelerationRateOverride
		{
			[Token(Token = "0x6000329")]
			get;
		}
	}
	[Token(Token = "0x2000078")]
	public interface IKN_EventExecutor
	{
		[Token(Token = "0x600032A")]
		bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) where T : IEventSystemHandler;

		[Token(Token = "0x600032B")]
		GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction) where T : IEventSystemHandler;

		[Token(Token = "0x600032C")]
		GameObject GetEventHandler<T>(GameObject root) where T : IEventSystemHandler;
	}
	[Token(Token = "0x2000079")]
	public interface IKN_InputModuleController
	{
		[Token(Token = "0x1700007A")]
		EventSystem eventSystem
		{
			[Token(Token = "0x600032D")]
			get;
		}

		[Token(Token = "0x1700007B")]
		List<RaycastResult> RaycastResultCache
		{
			[Token(Token = "0x600032E")]
			get;
		}

		[Token(Token = "0x600032F")]
		bool ShouldActivate();

		[Token(Token = "0x6000330")]
		void Deactivate();

		[Token(Token = "0x6000331")]
		GameObject FindCommonRoot(GameObject g1, GameObject g2);

		[Token(Token = "0x6000332")]
		BaseEventData GetBaseEventData();

		[Token(Token = "0x6000333")]
		RaycastResult FindFirstRaycast(List<RaycastResult> candidates);
	}
	[Token(Token = "0x200007A")]
	public class KN_AllEventsTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public class TriggerEvent : UnityEvent<GameObject, PointerEventData>
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xA6B610", Offset = "0xA6B610", VA = "0xA6B610")]
			public TriggerEvent()
			{
			}
		}

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TriggerEvent OnPointerClick;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TriggerEvent OnPointerDown;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TriggerEvent OnPointerUp;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TriggerEvent OnPointerEnter;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TriggerEvent OnPointerExit;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TriggerEvent OnScroll;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool listenersAdded;

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xA6AB58", Offset = "0xA6AB58", VA = "0xA6AB58")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xA6ACD0", Offset = "0xA6ACD0", VA = "0xA6ACD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xA6AE44", Offset = "0xA6AE44", VA = "0xA6AE44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xA6AB5C", Offset = "0xA6AB5C", VA = "0xA6AB5C")]
		private void AddListeners()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xA6ACD4", Offset = "0xA6ACD4", VA = "0xA6ACD4")]
		private void RemoveListeners()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xA6B368", Offset = "0xA6B368", VA = "0xA6B368")]
		private void OnPointerClickHandler(GameObject target, PointerEventData eventData)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xA6B3D8", Offset = "0xA6B3D8", VA = "0xA6B3D8")]
		private void OnPointerDownHandler(GameObject target, PointerEventData eventData)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xA6B448", Offset = "0xA6B448", VA = "0xA6B448")]
		private void OnPointerUpHandler(GameObject target, PointerEventData eventData)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xA6B4B8", Offset = "0xA6B4B8", VA = "0xA6B4B8")]
		private void OnPointerEnterHandler(GameObject target, PointerEventData eventData)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xA6B528", Offset = "0xA6B528", VA = "0xA6B528")]
		private void OnPointerExitHandler(GameObject target, PointerEventData eventData)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xA6B598", Offset = "0xA6B598", VA = "0xA6B598")]
		private void OnScrollHandler(GameObject target, PointerEventData eventData)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xA6B608", Offset = "0xA6B608", VA = "0xA6B608")]
		public KN_AllEventsTrigger()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class KN_EventExecutor : IKN_EventExecutor
	{
		[Token(Token = "0x20000CA")]
		public delegate void EventDelegate(GameObject target, PointerEventData eventData);

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<Type, EventDelegate> eventTable;

		[Token(Token = "0x14000004")]
		public event EventDelegate OnPointerClick
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0xA6AEE8", Offset = "0xA6AEE8", VA = "0xA6AEE8")]
			add
			{
			}
			[Token(Token = "0x6000341")]
			[Address(RVA = "0xA6B128", Offset = "0xA6B128", VA = "0xA6B128")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event EventDelegate OnPointerDown
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0xA6AF48", Offset = "0xA6AF48", VA = "0xA6AF48")]
			add
			{
			}
			[Token(Token = "0x6000343")]
			[Address(RVA = "0xA6B188", Offset = "0xA6B188", VA = "0xA6B188")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event EventDelegate OnPointerUp
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0xA6AFA8", Offset = "0xA6AFA8", VA = "0xA6AFA8")]
			add
			{
			}
			[Token(Token = "0x6000345")]
			[Address(RVA = "0xA6B1E8", Offset = "0xA6B1E8", VA = "0xA6B1E8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event EventDelegate OnPointerEnter
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0xA6B008", Offset = "0xA6B008", VA = "0xA6B008")]
			add
			{
			}
			[Token(Token = "0x6000347")]
			[Address(RVA = "0xA6B248", Offset = "0xA6B248", VA = "0xA6B248")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event EventDelegate OnPointerExit
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0xA6B068", Offset = "0xA6B068", VA = "0xA6B068")]
			add
			{
			}
			[Token(Token = "0x6000349")]
			[Address(RVA = "0xA6B2A8", Offset = "0xA6B2A8", VA = "0xA6B2A8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event EventDelegate OnScroll
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0xA6B0C8", Offset = "0xA6B0C8", VA = "0xA6B0C8")]
			add
			{
			}
			[Token(Token = "0x600034B")]
			[Address(RVA = "0xA6B308", Offset = "0xA6B308", VA = "0xA6B308")]
			remove
			{
			}
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xA70478", Offset = "0xA70478", VA = "0xA70478")]
		public KN_EventExecutor()
		{
		}

		[Token(Token = "0x600034D")]
		public bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) where T : IEventSystemHandler
		{
			return default(bool);
		}

		[Token(Token = "0x600034E")]
		public GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction) where T : IEventSystemHandler
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		public GameObject GetEventHandler<T>(GameObject root) where T : IEventSystemHandler
		{
			return null;
		}

		[Token(Token = "0x6000350")]
		private void CallEventDelegate<T>(GameObject target, BaseEventData eventData) where T : IEventSystemHandler
		{
		}

		[Token(Token = "0x6000351")]
		private void AddEventDelegate<T>(EventDelegate eventDelegate)
		{
		}

		[Token(Token = "0x6000352")]
		private void RemoveEventDelegate<T>(EventDelegate eventDelegate)
		{
		}
	}
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7D3AB0", Offset = "0x7D3AB0")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x7D3AB0", Offset = "0x7D3AB0")]
	public class KN_PointerInputModule : BaseInputModule, IKN_InputModuleController
	{
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5644", Offset = "0x7D5644")]
		public bool vrModeOnly;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D567C", Offset = "0x7D567C")]
		public KN_PointerScrollInput scrollInput;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D56B4", Offset = "0x7D56B4")]
		private KN_PointerInputModuleImpl <Impl>k__BackingField;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D56C4", Offset = "0x7D56C4")]
		private KN_EventExecutor <EventExecutor>k__BackingField;

		[Token(Token = "0x1700007C")]
		public KN_PointerInputModuleImpl Impl
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0xA73800", Offset = "0xA73800", VA = "0xA73800")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6600", Offset = "0x7D6600")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000354")]
			[Address(RVA = "0xA73808", Offset = "0xA73808", VA = "0xA73808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6610", Offset = "0x7D6610")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public KN_EventExecutor EventExecutor
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0xA73810", Offset = "0xA73810", VA = "0xA73810")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6620", Offset = "0x7D6620")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000356")]
			[Address(RVA = "0xA73818", Offset = "0xA73818", VA = "0xA73818")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6630", Offset = "0x7D6630")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public new EventSystem eventSystem
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0xA73820", Offset = "0xA73820", VA = "0xA73820", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public List<RaycastResult> RaycastResultCache
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0xA73828", Offset = "0xA73828", VA = "0xA73828", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public static KN_BasePointer Pointer
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0xA6E3EC", Offset = "0xA6E3EC", VA = "0xA6E3EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035A")]
			[Address(RVA = "0xA73958", Offset = "0xA73958", VA = "0xA73958")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public static RaycastResult CurrentRaycastResult
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0xA6D5C8", Offset = "0xA6D5C8", VA = "0xA6D5C8")]
			get
			{
				return default(RaycastResult);
			}
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xA6E1E8", Offset = "0xA6E1E8", VA = "0xA6E1E8")]
		public static void OnPointerCreated(KN_BasePointer createdPointer)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xA6AE48", Offset = "0xA6AE48", VA = "0xA6AE48")]
		public static KN_EventExecutor FindEventExecutor()
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xA73830", Offset = "0xA73830", VA = "0xA73830")]
		public static KN_PointerInputModule FindInputModule()
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xA73A88", Offset = "0xA73A88", VA = "0xA73A88", Slot = "21")]
		public override bool ShouldActivateModule()
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xA73B9C", Offset = "0xA73B9C", VA = "0xA73B9C", Slot = "22")]
		public override void DeactivateModule()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xA73D8C", Offset = "0xA73D8C", VA = "0xA73D8C", Slot = "20")]
		public override bool IsPointerOverGameObject(int pointerId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xA73E2C", Offset = "0xA73E2C", VA = "0xA73E2C", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xA73FB8", Offset = "0xA73FB8", VA = "0xA73FB8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xA7404C", Offset = "0xA7404C", VA = "0xA7404C", Slot = "28")]
		public bool ShouldActivate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xA74054", Offset = "0xA74054", VA = "0xA74054", Slot = "29")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xA7405C", Offset = "0xA7405C", VA = "0xA7405C", Slot = "30")]
		public new GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xA7406C", Offset = "0xA7406C", VA = "0xA7406C", Slot = "31")]
		public new BaseEventData GetBaseEventData()
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xA74074", Offset = "0xA74074", VA = "0xA74074", Slot = "32")]
		public new RaycastResult FindFirstRaycast(List<RaycastResult> candidates)
		{
			return default(RaycastResult);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xA73E58", Offset = "0xA73E58", VA = "0xA73E58")]
		private void UpdateImplProperties()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xA74080", Offset = "0xA74080", VA = "0xA74080")]
		public KN_PointerInputModule()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class KN_PointerInputModuleImpl
	{
		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D56D4", Offset = "0x7D56D4")]
		private IKN_InputModuleController <ModuleController>k__BackingField;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D56E4", Offset = "0x7D56E4")]
		private IKN_EventExecutor <EventExecutor>k__BackingField;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D56F4", Offset = "0x7D56F4")]
		private bool <VrModeOnly>k__BackingField;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5704", Offset = "0x7D5704")]
		private KN_PointerScrollInput <ScrollInput>k__BackingField;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5714", Offset = "0x7D5714")]
		private PointerEventData <CurrentEventData>k__BackingField;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private KN_BasePointer pointer;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 lastPose;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isPointerHovering;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool isActive;

		[Token(Token = "0x17000082")]
		public IKN_InputModuleController ModuleController
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0xA74190", Offset = "0xA74190", VA = "0xA74190")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6640", Offset = "0x7D6640")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036C")]
			[Address(RVA = "0xA74198", Offset = "0xA74198", VA = "0xA74198")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6650", Offset = "0x7D6650")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public IKN_EventExecutor EventExecutor
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0xA741A0", Offset = "0xA741A0", VA = "0xA741A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6660", Offset = "0x7D6660")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0xA741A8", Offset = "0xA741A8", VA = "0xA741A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6670", Offset = "0x7D6670")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool VrModeOnly
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0xA741B0", Offset = "0xA741B0", VA = "0xA741B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6680", Offset = "0x7D6680")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0xA741B8", Offset = "0xA741B8", VA = "0xA741B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6690", Offset = "0x7D6690")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public KN_PointerScrollInput ScrollInput
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0xA741C4", Offset = "0xA741C4", VA = "0xA741C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D66A0", Offset = "0x7D66A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000372")]
			[Address(RVA = "0xA741CC", Offset = "0xA741CC", VA = "0xA741CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D66B0", Offset = "0x7D66B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public PointerEventData CurrentEventData
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0xA741D4", Offset = "0xA741D4", VA = "0xA741D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D66C0", Offset = "0x7D66C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000374")]
			[Address(RVA = "0xA741DC", Offset = "0xA741DC", VA = "0xA741DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D66D0", Offset = "0x7D66D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public KN_BasePointer Pointer
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0xA741E4", Offset = "0xA741E4", VA = "0xA741E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0xA739F8", Offset = "0xA739F8", VA = "0xA739F8")]
			set
			{
			}
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xA73AA0", Offset = "0xA73AA0", VA = "0xA73AA0")]
		public bool ShouldActivateModule()
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xA73BB4", Offset = "0xA73BB4", VA = "0xA73BB4")]
		public void DeactivateModule()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xA73DA4", Offset = "0xA73DA4", VA = "0xA73DA4")]
		public bool IsPointerOverGameObject(int pointerId)
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xA73EA8", Offset = "0xA73EA8", VA = "0xA73EA8")]
		public void Process()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xA75150", Offset = "0xA75150", VA = "0xA75150")]
		private void CastRay()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xA75B10", Offset = "0xA75B10", VA = "0xA75B10")]
		private void UpdateCurrentObject(GameObject previousObject)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xA760A0", Offset = "0xA760A0", VA = "0xA760A0")]
		private void UpdatePointer(GameObject previousObject)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xA77424", Offset = "0xA77424", VA = "0xA77424")]
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xA764A4", Offset = "0xA764A4", VA = "0xA764A4")]
		private void HandleDrag()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xA742D4", Offset = "0xA742D4", VA = "0xA742D4")]
		private void HandlePendingClick()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xA76A20", Offset = "0xA76A20", VA = "0xA76A20")]
		private void HandleTriggerDown()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xA75138", Offset = "0xA75138", VA = "0xA75138")]
		private GameObject GetCurrentGameObject()
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xA748D8", Offset = "0xA748D8", VA = "0xA748D8")]
		private void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xA741EC", Offset = "0xA741EC", VA = "0xA741EC")]
		private void TryExitPointer()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xA75098", Offset = "0xA75098", VA = "0xA75098")]
		private bool IsPointerActiveAndAvailable()
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xA77260", Offset = "0xA77260", VA = "0xA77260")]
		private void RaycastAll()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xA74044", Offset = "0xA74044", VA = "0xA74044")]
		public KN_PointerInputModuleImpl()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public abstract class KN_BasePointer : MonoBehaviour
	{
		[Token(Token = "0x20000CB")]
		public enum RaycastMode
		{
			[Token(Token = "0x4000489")]
			Camera,
			[Token(Token = "0x400048A")]
			Direct,
			[Token(Token = "0x400048B")]
			Hybrid
		}

		[Token(Token = "0x20000CC")]
		public struct PointerRay
		{
			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Ray ray;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float distanceFromStart;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float distance;
		}

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5724", Offset = "0x7D5724")]
		public RaycastMode raycastMode;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D575C", Offset = "0x7D575C")]
		public Camera overridePointerCamera;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D5794", Offset = "0x7D5794")]
		private bool <ShouldUseExitRadiusForRaycast>k__BackingField;

		[Token(Token = "0x17000088")]
		public RaycastResult CurrentRaycastResult
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0xA6D5C4", Offset = "0xA6D5C4", VA = "0xA6D5C4")]
			get
			{
				return default(RaycastResult);
			}
		}

		[Token(Token = "0x17000089")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7D6DE0", Offset = "0x7D6DE0")]
		public Vector3 PointerIntersection
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0xA6D688", Offset = "0xA6D688", VA = "0xA6D688")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008A")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7D6E18", Offset = "0x7D6E18")]
		public bool IsPointerIntersecting
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0xA6D6B0", Offset = "0xA6D6B0", VA = "0xA6D6B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public bool ShouldUseExitRadiusForRaycast
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0xA6D734", Offset = "0xA6D734", VA = "0xA6D734")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D66E0", Offset = "0x7D66E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038C")]
			[Address(RVA = "0xA6D73C", Offset = "0xA6D73C", VA = "0xA6D73C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D66F0", Offset = "0x7D66F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public float CurrentPointerRadius
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0xA6D748", Offset = "0xA6D748", VA = "0xA6D748")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008D")]
		public virtual Transform PointerTransform
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0xA6D7A0", Offset = "0xA6D7A0", VA = "0xA6D7A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public virtual bool TriggerDown
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0xA6D7A8", Offset = "0xA6D7A8", VA = "0xA6D7A8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008F")]
		public virtual bool Triggering
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0xA6D7D8", Offset = "0xA6D7D8", VA = "0xA6D7D8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		public virtual bool TriggerUp
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0xA6D808", Offset = "0xA6D808", VA = "0xA6D808", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		public virtual bool TouchDown
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0xA6D838", Offset = "0xA6D838", VA = "0xA6D838", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000092")]
		public virtual bool IsTouching
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0xA6D840", Offset = "0xA6D840", VA = "0xA6D840", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000093")]
		public virtual bool TouchUp
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0xA6D848", Offset = "0xA6D848", VA = "0xA6D848", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000094")]
		public virtual Vector2 TouchPos
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0xA6D850", Offset = "0xA6D850", VA = "0xA6D850", Slot = "11")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000095")]
		public virtual Vector3 MaxPointerEndPoint
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0xA6D858", Offset = "0xA6D858", VA = "0xA6D858", Slot = "12")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000096")]
		public virtual bool IsAvailable
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0xA6D9BC", Offset = "0xA6D9BC", VA = "0xA6D9BC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000097")]
		public virtual float CameraRayIntersectionDistance
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0xA6DA84", Offset = "0xA6DA84", VA = "0xA6DA84", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000098")]
		public Camera PointerCamera
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0xA6DA94", Offset = "0xA6DA94", VA = "0xA6DA94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public abstract float MaxPointerDistance
		{
			[Token(Token = "0x600039A")]
			get;
		}

		[Token(Token = "0x600039B")]
		public abstract void OnPointerEnter(RaycastResult raycastResult, bool isInteractive);

		[Token(Token = "0x600039C")]
		public abstract void OnPointerHover(RaycastResult raycastResultResult, bool isInteractive);

		[Token(Token = "0x600039D")]
		public abstract void OnPointerExit(GameObject previousObject);

		[Token(Token = "0x600039E")]
		public abstract void OnPointerClickDown();

		[Token(Token = "0x600039F")]
		public abstract void OnPointerClickUp();

		[Token(Token = "0x60003A0")]
		public abstract void GetPointerRadius(out float enterRadius, out float exitRadius);

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xA6D970", Offset = "0xA6D970", VA = "0xA6D970")]
		public Vector3 GetPointAlongPointer(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xA6DB20", Offset = "0xA6DB20", VA = "0xA6DB20")]
		public PointerRay GetRayForDistance(float distance)
		{
			return default(PointerRay);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xA6DD4C", Offset = "0xA6DD4C", VA = "0xA6DD4C")]
		public static PointerRay CalculateRay(KN_BasePointer pointer, RaycastMode mode)
		{
			return default(PointerRay);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xA6DBB8", Offset = "0xA6DBB8", VA = "0xA6DBB8")]
		public static PointerRay CalculateHybridRay(KN_BasePointer pointer, RaycastMode hybridMode)
		{
			return default(PointerRay);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xA6E1E4", Offset = "0xA6E1E4", VA = "0xA6E1E4", Slot = "22")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xA6E2CC", Offset = "0xA6E2CC", VA = "0xA6E2CC")]
		protected KN_BasePointer()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public abstract class KN_BasePointerRaycaster : BaseRaycaster
	{
		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private KN_BasePointer.PointerRay lastRay;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D57A4", Offset = "0x7D57A4")]
		private KN_BasePointer.RaycastMode <CurrentRaycastModeForHybrid>k__BackingField;

		[Token(Token = "0x1700009A")]
		protected KN_BasePointer.RaycastMode CurrentRaycastModeForHybrid
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0xA6E2DC", Offset = "0xA6E2DC", VA = "0xA6E2DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6700", Offset = "0x7D6700")]
			get
			{
				return default(KN_BasePointer.RaycastMode);
			}
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xA6E2E4", Offset = "0xA6E2E4", VA = "0xA6E2E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D6710", Offset = "0x7D6710")]
			private set
			{
			}
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xA6E2EC", Offset = "0xA6E2EC", VA = "0xA6E2EC")]
		protected KN_BasePointerRaycaster()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xA6E2F4", Offset = "0xA6E2F4", VA = "0xA6E2F4")]
		public KN_BasePointer.PointerRay GetLastRay()
		{
			return default(KN_BasePointer.PointerRay);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xA6E300", Offset = "0xA6E300", VA = "0xA6E300", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x60003AC")]
		protected abstract bool PerformRaycast(KN_BasePointer.PointerRay pointerRay, float radius, PointerEventData eventData, List<RaycastResult> resultAppendList);

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xA6E48C", Offset = "0xA6E48C", VA = "0xA6E48C")]
		private void RaycastHybrid(KN_BasePointer pointer, PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xA6E5C4", Offset = "0xA6E5C4", VA = "0xA6E5C4")]
		private void RaycastDefault(KN_BasePointer pointer, PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}
	}
	[Token(Token = "0x2000080")]
	public interface IKN_PointerHoverHandler : IEventSystemHandler
	{
		[Token(Token = "0x60003AF")]
		void OnKNPointerHover(PointerEventData eventData);
	}
	[Token(Token = "0x2000081")]
	public static class KN_ExecuteEventsExtension
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ExecuteEvents.EventFunction<IKN_PointerHoverHandler> s_HoverHandler;

		[Token(Token = "0x1700009B")]
		public static ExecuteEvents.EventFunction<IKN_PointerHoverHandler> pointerHoverHandler
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xA70A20", Offset = "0xA70A20", VA = "0xA70A20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xA7092C", Offset = "0xA7092C", VA = "0xA7092C")]
		private static void Execute(IKN_PointerHoverHandler handler, BaseEventData eventData)
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7D3B00", Offset = "0x7D3B00")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7D3B00", Offset = "0x7D3B00")]
	public class KN_PointerGraphicRaycaster : KN_BasePointerRaycaster
	{
		[Token(Token = "0x20000CD")]
		public enum BlockingObjects
		{
			[Token(Token = "0x4000490")]
			None,
			[Token(Token = "0x4000491")]
			TwoD,
			[Token(Token = "0x4000492")]
			ThreeD,
			[Token(Token = "0x4000493")]
			All
		}

		[Serializable]
		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7D3D38", Offset = "0x7D3D38")]
		private sealed class <>c
		{
			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<Graphic> <>9__17_0;

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xA737A0", Offset = "0xA737A0", VA = "0xA737A0")]
			public <>c()
			{
			}

			[Token(Token = "0x60004C9")]
			[Address(RVA = "0xA737A8", Offset = "0xA737A8", VA = "0xA737A8")]
			internal int <Raycast>b__17_0(Graphic g1, Graphic g2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400034D")]
		private const int NO_EVENT_MASK_SET = -1;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool ignoreReversedGraphics;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlockingObjects blockingObjects;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LayerMask blockingMask;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas targetCanvas;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Graphic> raycastResults;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Camera cachedPointerEventCamera;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Graphic> sortedGraphics;

		[Token(Token = "0x1700009C")]
		public override Camera eventCamera
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xA72554", Offset = "0xA72554", VA = "0xA72554", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		private Canvas canvas
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xA72730", Offset = "0xA72730", VA = "0xA72730")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xA727C8", Offset = "0xA727C8", VA = "0xA727C8")]
		protected KN_PointerGraphicRaycaster()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xA72858", Offset = "0xA72858", VA = "0xA72858", Slot = "22")]
		protected override bool PerformRaycast(KN_BasePointer.PointerRay pointerRay, float radius, PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xA72604", Offset = "0xA72604", VA = "0xA72604")]
		private Camera GetCameraForRaycastMode(KN_BasePointer pointer, KN_BasePointer.RaycastMode mode)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xA73624", Offset = "0xA73624", VA = "0xA73624")]
		private Camera AddDummyCameraToPointer(KN_BasePointer pointer)
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xA73138", Offset = "0xA73138", VA = "0xA73138")]
		private static void Raycast(Canvas canvas, Ray ray, Camera cam, float distance, List<Graphic> results, out Ray finalRay)
		{
		}
	}
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7D3B88", Offset = "0x7D3B88")]
	public class KN_PointerPhysicsRaycaster : KN_BasePointerRaycaster
	{
		[Token(Token = "0x20000CF")]
		private class HitComparer : IComparer<RaycastHit>
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0xA77D8C", Offset = "0xA77D8C", VA = "0xA77D8C", Slot = "4")]
			public int Compare(RaycastHit lhs, RaycastHit rhs)
			{
				return default(int);
			}

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xA777AC", Offset = "0xA777AC", VA = "0xA777AC")]
			public HitComparer()
			{
			}
		}

		[Token(Token = "0x4000355")]
		protected const int NO_EVENT_MASK_SET = -1;

		[Token(Token = "0x4000356")]
		private const int MAX_RAYCAST_HITS_MAX = 512;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected LayerMask raycasterEventMask;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7D57C4", Offset = "0x7D57C4")]
		private int maxRaycastHits;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RaycastHit[] hits;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private HitComparer hitComparer;

		[Token(Token = "0x1700009E")]
		public int MaxRaycastHits
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0xA774F4", Offset = "0xA774F4", VA = "0xA774F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0xA774FC", Offset = "0xA774FC", VA = "0xA774FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public override Camera eventCamera
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0xA775B4", Offset = "0xA775B4", VA = "0xA775B4", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public int finalEventMask
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0xA7764C", Offset = "0xA7764C", VA = "0xA7764C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A1")]
		public LayerMask eventMask
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0xA77720", Offset = "0xA77720", VA = "0xA77720")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0xA77728", Offset = "0xA77728", VA = "0xA77728")]
			set
			{
			}
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xA77730", Offset = "0xA77730", VA = "0xA77730")]
		protected KN_PointerPhysicsRaycaster()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xA777B4", Offset = "0xA777B4", VA = "0xA777B4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xA77818", Offset = "0xA77818", VA = "0xA77818", Slot = "22")]
		protected override bool PerformRaycast(KN_BasePointer.PointerRay pointerRay, float radius, PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class KN_PointerScrollInput
	{
		[Token(Token = "0x20000D0")]
		private class ScrollInfo
		{
			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isScrollingX;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool isScrollingY;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector2 initScroll;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector2 lastScroll;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector2 scrollVelocity;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IKN_ScrollSettings scrollSettings;

			[Token(Token = "0x170000E3")]
			public bool IsScrolling
			{
				[Token(Token = "0x60004CC")]
				[Address(RVA = "0xA78950", Offset = "0xA78950", VA = "0xA78950")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004CD")]
			[Address(RVA = "0xA78BFC", Offset = "0xA78BFC", VA = "0xA78BFC")]
			public ScrollInfo()
			{
			}
		}

		[Token(Token = "0x400035B")]
		public const string PROPERTY_NAME_INERTIA = "inertia";

		[Token(Token = "0x400035C")]
		public const string PROPERTY_NAME_DECELERATION_RATE = "decelerationRate";

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5808", Offset = "0x7D5808")]
		public bool inertia;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5840", Offset = "0x7D5840")]
		public float decelerationRate;

		[Token(Token = "0x400035F")]
		public const float SCROLL_DELTA_MULTIPLIER = 1000f;

		[Token(Token = "0x4000360")]
		private const float CUTOFF_HZ = 10f;

		[Token(Token = "0x4000361")]
		private const float RC = 1f / (20f * (float)Math.PI);

		[Token(Token = "0x4000362")]
		private const float SPEED_CLAMP_RATIO = 0.05f;

		[Token(Token = "0x4000363")]
		private const float SPEED_CLAMP = 50f;

		[Token(Token = "0x4000364")]
		private const float SPEED_CLAMP_SQUARED = 2500f;

		[Token(Token = "0x4000365")]
		private const float INERTIA_THRESHOLD_RATIO = 0.2f;

		[Token(Token = "0x4000366")]
		private const float INERTIA_THRESHOLD = 200f;

		[Token(Token = "0x4000367")]
		private const float INERTIA_THRESHOLD_SQUARED = 40000f;

		[Token(Token = "0x4000368")]
		private const float SLOP_VERTICAL = 165f;

		[Token(Token = "0x4000369")]
		private const float SLOP_HORIZONTAL = 150f;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<GameObject, ScrollInfo> scrollHandlers;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<GameObject> scrollingObjects;

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xA76EEC", Offset = "0xA76EEC", VA = "0xA76EEC")]
		public void HandleScroll(GameObject currentGameObject, PointerEventData pointerData, KN_BasePointer pointer, IKN_EventExecutor eventExecutor)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xA77E98", Offset = "0xA77E98", VA = "0xA77E98")]
		private void OnTouchingScrollHandler(GameObject currentScrollHandler, PointerEventData pointerData, Vector2 currentScroll, IKN_EventExecutor eventExecutor)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xA78194", Offset = "0xA78194", VA = "0xA78194")]
		private void OnReleaseScrollHandler(GameObject currentScrollHandler)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xA78970", Offset = "0xA78970", VA = "0xA78970")]
		private void UpdateVelocity(ScrollInfo scrollInfo, Vector2 scrollDisplacement)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xA7824C", Offset = "0xA7824C", VA = "0xA7824C")]
		private void StopScrollingIfNecessary(bool touching, GameObject currentScrollHandler)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xA783EC", Offset = "0xA783EC", VA = "0xA783EC")]
		private void UpdateInertiaScrollHandlers(bool touching, GameObject currentScrollHandler, PointerEventData pointerData, IKN_EventExecutor eventExecutor)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xA78750", Offset = "0xA78750", VA = "0xA78750")]
		private ScrollInfo AddScrollHandler(GameObject scrollHandler, Vector2 currentScroll)
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xA77DD0", Offset = "0xA77DD0", VA = "0xA77DD0")]
		private void RemoveScrollHandler(GameObject scrollHandler)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xA78A58", Offset = "0xA78A58", VA = "0xA78A58")]
		private bool ShouldUseInertia(ScrollInfo scrollInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xA78B28", Offset = "0xA78B28", VA = "0xA78B28")]
		private float GetDecelerationRate(ScrollInfo scrollInfo)
		{
			return default(float);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xA78830", Offset = "0xA78830", VA = "0xA78830")]
		private static bool CanScrollStartX(ScrollInfo scrollInfo, Vector2 currentScroll)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xA788C0", Offset = "0xA788C0", VA = "0xA788C0")]
		private static bool CanScrollStartY(ScrollInfo scrollInfo, Vector2 currentScroll)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xA740E4", Offset = "0xA740E4", VA = "0xA740E4")]
		public KN_PointerScrollInput()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class KN_ScrollSettings : MonoBehaviour, IKN_ScrollSettings
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D5878", Offset = "0x7D5878")]
		public bool inertiaOverride;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7D58B0", Offset = "0x7D58B0")]
		public float decelerationRateOverride;

		[Token(Token = "0x170000A2")]
		public bool InertiaOverride
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0xA78C88", Offset = "0xA78C88", VA = "0xA78C88", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A3")]
		public float DecelerationRateOverride
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0xA78C90", Offset = "0xA78C90", VA = "0xA78C90", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xA78C98", Offset = "0xA78C98", VA = "0xA78C98")]
		public KN_ScrollSettings()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7D3BC0", Offset = "0x7D3BC0")]
	public class KN_EditorEmulator : MonoBehaviour
	{
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xA70470", Offset = "0xA70470", VA = "0xA70470")]
		public KN_EditorEmulator()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class KN_MathHelpers
	{
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xA71F9C", Offset = "0xA71F9C", VA = "0xA71F9C")]
		public static Vector3 GetIntersectionPosition(Camera cam, RaycastResult raycastResult)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xA7213C", Offset = "0xA7213C", VA = "0xA7213C")]
		public static Vector2 NormalizedCartesianToSpherical(Vector3 cartCoords)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xA71A10", Offset = "0xA71A10", VA = "0xA71A10")]
		public static float EaseOutCubic(float min, float max, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xA72250", Offset = "0xA72250", VA = "0xA72250")]
		public static Matrix4x4 ConvertFloatArrayToMatrix(float[] floatArray)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xA7254C", Offset = "0xA7254C", VA = "0xA7254C")]
		public KN_MathHelpers()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class KN_VRHelpers
	{
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xA771DC", Offset = "0xA771DC", VA = "0xA771DC")]
		public static Vector2 GetViewportCenter()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xA6BDF8", Offset = "0xA6BDF8", VA = "0xA6BDF8")]
		public static Vector3 GetHeadForward()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xA6CD0C", Offset = "0xA6CD0C", VA = "0xA6CD0C")]
		public static Quaternion GetHeadRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xA6C19C", Offset = "0xA6C19C", VA = "0xA6C19C")]
		public static Vector3 GetHeadPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xA79250", Offset = "0xA79250", VA = "0xA79250")]
		public static float GetRecommendedMaxLaserDistance(KN_BasePointer.RaycastMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xA79270", Offset = "0xA79270", VA = "0xA79270")]
		public static float GetRayIntersection(KN_BasePointer.RaycastMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xA79290", Offset = "0xA79290", VA = "0xA79290")]
		public static bool GetShrinkLaser(KN_BasePointer.RaycastMode mode)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xA7929C", Offset = "0xA7929C", VA = "0xA7929C")]
		public KN_VRHelpers()
		{
		}
	}
}
