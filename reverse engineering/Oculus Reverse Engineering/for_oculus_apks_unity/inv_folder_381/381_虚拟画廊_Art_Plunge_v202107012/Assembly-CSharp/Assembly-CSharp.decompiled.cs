using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using CapturePanorama;
using CapturePanorama.Internals;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using Oculus.Platform;
using SpUnityHelpers;
using SpacePlunge;
using SpacePlunge.SimpleReactive;
using SpacePlunge.Utils;
using TMPro;
using UIFromCode;
using UltimateGameTools.MeshSimplifier;
using UniRx;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
using teadrinker;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7785D0", Offset = "0x7785D0")]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xA4F31C", Offset = "0xA4F31C", VA = "0xA4F31C")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778608", Offset = "0x778608")]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xA4C5CC", Offset = "0xA4C5CC", VA = "0xA4C5CC")]
		public IsReadOnlyAttribute()
		{
		}
	}
}
[Token(Token = "0x2000004")]
public class SimplifyMeshPreview : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200012B")]
	public class ShowcaseObject
	{
		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MeshSimplify m_meshSimplify;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 m_position;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 m_angles;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 m_rotationAxis;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string m_description;

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xA5CF40", Offset = "0xA5CF40", VA = "0xA5CF40")]
		public ShowcaseObject()
		{
		}
	}

	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778A7C", Offset = "0x778A7C")]
	private sealed class <ComputeMeshWithVertices>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SimplifyMeshPreview <>4__this;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fAmount;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<GameObject, Material[]>.Enumerator <>7__wrap1;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshSimplify <meshSimplify>5__3;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshFilter <meshFilter>5__4;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SkinnedMeshRenderer <skin>5__5;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Mesh <newMesh>5__6;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0xA5CED0", Offset = "0xA5CED0", VA = "0xA5CED0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0xA5CF38", Offset = "0xA5CF38", VA = "0xA5CF38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xA5C754", Offset = "0xA5C754", VA = "0xA5C754")]
		[DebuggerHidden]
		public <ComputeMeshWithVertices>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xA5C808", Offset = "0xA5C808", VA = "0xA5C808", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xA5C87C", Offset = "0xA5C87C", VA = "0xA5C87C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xA5C824", Offset = "0xA5C824", VA = "0xA5C824")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xA5CED8", Offset = "0xA5CED8", VA = "0xA5CED8", Slot = "8")]
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

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xA5AE78", Offset = "0xA5AE78", VA = "0xA5AE78")]
	private void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xA5B1A8", Offset = "0xA5B1A8", VA = "0xA5B1A8")]
	private void Progress(string strTitle, string strMessage, float fT)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xA5B278", Offset = "0xA5B278", VA = "0xA5B278")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xA5B728", Offset = "0xA5B728", VA = "0xA5B728")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xA5AFC8", Offset = "0xA5AFC8", VA = "0xA5AFC8")]
	private void SetActiveObject(int index)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xA5C5B0", Offset = "0xA5C5B0", VA = "0xA5C5B0")]
	private void AddMaterials(GameObject theGameObject, Dictionary<GameObject, Material[]> dicMaterials)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xA5B4F4", Offset = "0xA5B4F4", VA = "0xA5B4F4")]
	private void SetWireframe(bool bEnabled)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xA5C530", Offset = "0xA5C530", VA = "0xA5C530")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77A654", Offset = "0x77A654")]
	private IEnumerator ComputeMeshWithVertices(float fAmount)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xA5C780", Offset = "0xA5C780", VA = "0xA5C780")]
	public SimplifyMeshPreview()
	{
	}
}
[Token(Token = "0x2000005")]
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

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xE53598", Offset = "0xE53598", VA = "0xE53598")]
	public static bool HasValidMeshData(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xE5368C", Offset = "0xE5368C", VA = "0xE5368C")]
	public static bool IsRootOrBelongsToTree(MeshSimplify meshSimplify, MeshSimplify root)
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xE537F4", Offset = "0xE537F4", VA = "0xE537F4")]
	public bool IsGenerateIncludeChildrenActive()
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xE537FC", Offset = "0xE537FC", VA = "0xE537FC")]
	public bool HasDependentChildren()
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xE53858", Offset = "0xE53858", VA = "0xE53858")]
	public bool HasDataDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xE53860", Offset = "0xE53860", VA = "0xE53860")]
	public bool SetDataDirty(bool bDirty)
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE53870", Offset = "0xE53870", VA = "0xE53870")]
	public bool HasNonMeshSimplifyGameObjectsInTree()
	{
		return default(bool);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xE538A0", Offset = "0xE538A0", VA = "0xE538A0")]
	private bool HasNonMeshSimplifyGameObjectsInTreeRecursive(MeshSimplify root, GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xE539D4", Offset = "0xE539D4", VA = "0xE539D4")]
	private void ConfigureSimplifier()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xE53B80", Offset = "0xE53B80", VA = "0xE53B80")]
	public Simplifier GetMeshSimplifier()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xE53B88", Offset = "0xE53B88", VA = "0xE53B88")]
	public void ComputeData(bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xE53BCC", Offset = "0xE53BCC", VA = "0xE53BCC")]
	private static void ComputeDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xE544B0", Offset = "0xE544B0", VA = "0xE544B0")]
	public bool HasData()
	{
		return default(bool);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xE54584", Offset = "0xE54584", VA = "0xE54584")]
	public bool HasSimplifiedMesh()
	{
		return default(bool);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xE54620", Offset = "0xE54620", VA = "0xE54620")]
	public void ComputeMesh(bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xE54664", Offset = "0xE54664", VA = "0xE54664")]
	private static void ComputeMeshRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xE54BD4", Offset = "0xE54BD4", VA = "0xE54BD4")]
	public void AssignSimplifiedMesh(bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xE54C08", Offset = "0xE54C08", VA = "0xE54C08")]
	private static void AssignSimplifiedMeshRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xE54E30", Offset = "0xE54E30", VA = "0xE54E30")]
	public void RestoreOriginalMesh(bool bDeleteData, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xE54E74", Offset = "0xE54E74", VA = "0xE54E74")]
	private static void RestoreOriginalMeshRecursive(MeshSimplify root, GameObject gameObject, bool bDeleteData, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xE550E4", Offset = "0xE550E4", VA = "0xE550E4")]
	public bool HasOriginalMeshActive(bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xE55118", Offset = "0xE55118", VA = "0xE55118")]
	private static bool HasOriginalMeshActiveRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xE55394", Offset = "0xE55394", VA = "0xE55394")]
	public bool HasVertexData(bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xE553C8", Offset = "0xE553C8", VA = "0xE553C8")]
	private static bool HasVertexDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xE55560", Offset = "0xE55560", VA = "0xE55560")]
	public int GetOriginalVertexCount(bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xE555AC", Offset = "0xE555AC", VA = "0xE555AC")]
	private static void GetOriginalVertexCountRecursive(MeshSimplify root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xE55738", Offset = "0xE55738", VA = "0xE55738")]
	public int GetSimplifiedVertexCount(bool bRecurseIntoChildren)
	{
		return default(int);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xE55784", Offset = "0xE55784", VA = "0xE55784")]
	private static void GetSimplifiedVertexCountRecursive(MeshSimplify root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xE55910", Offset = "0xE55910", VA = "0xE55910")]
	public void RemoveFromTree()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xE5447C", Offset = "0xE5447C", VA = "0xE5447C")]
	public void FreeData(bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xE559D8", Offset = "0xE559D8", VA = "0xE559D8")]
	private static void FreeDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xE54AE8", Offset = "0xE54AE8", VA = "0xE54AE8")]
	private static Mesh CreateNewEmptyMesh(MeshSimplify meshSimplify)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xE55C34", Offset = "0xE55C34", VA = "0xE55C34")]
	public MeshSimplify()
	{
	}
}
[Token(Token = "0x2000006")]
public class FPSCounter : MonoBehaviour
{
	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int frameRange;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x779484", Offset = "0x779484")]
	private int <AverageFPS>k__BackingField;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x779494", Offset = "0x779494")]
	private int <HighestFPS>k__BackingField;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7794A4", Offset = "0x7794A4")]
	private int <LowestFPS>k__BackingField;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int[] fpsBuffer;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int fpsBufferIndex;

	[Token(Token = "0x17000001")]
	public int AverageFPS
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0xABD338", Offset = "0xABD338", VA = "0xABD338")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77A6B8", Offset = "0x77A6B8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600002E")]
		[Address(RVA = "0xABD340", Offset = "0xABD340", VA = "0xABD340")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77A6C8", Offset = "0x77A6C8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public int HighestFPS
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0xABD348", Offset = "0xABD348", VA = "0xABD348")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77A6D8", Offset = "0x77A6D8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000030")]
		[Address(RVA = "0xABD350", Offset = "0xABD350", VA = "0xABD350")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77A6E8", Offset = "0x77A6E8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public int LowestFPS
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0xABD358", Offset = "0xABD358", VA = "0xABD358")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77A6F8", Offset = "0x77A6F8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000032")]
		[Address(RVA = "0xABD360", Offset = "0xABD360", VA = "0xABD360")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77A708", Offset = "0x77A708")]
		private set
		{
		}
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xABD368", Offset = "0xABD368", VA = "0xABD368")]
	private void Update()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xABD3B0", Offset = "0xABD3B0", VA = "0xABD3B0")]
	private void InitializeBuffer()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xABD41C", Offset = "0xABD41C", VA = "0xABD41C")]
	private void UpdateBuffer()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xABD4A0", Offset = "0xABD4A0", VA = "0xABD4A0")]
	private void CalculateFPS()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xABD540", Offset = "0xABD540", VA = "0xABD540")]
	public FPSCounter()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x778640", Offset = "0x778640")]
public class FPSDisplay : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200012D")]
	private struct FPSColor
	{
		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Color color;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int minimumFPS;
	}

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string[] stringsFrom00To99;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text highestFPSLabel;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text averageFPSLabel;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text lowestFPSLabel;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private FPSColor[] coloring;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private FPSCounter fpsCounter;

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xABD550", Offset = "0xABD550", VA = "0xABD550")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xABD5A8", Offset = "0xABD5A8", VA = "0xABD5A8")]
	private void Update()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xABD608", Offset = "0xABD608", VA = "0xABD608")]
	private void Display(Text label, int fps)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xABD770", Offset = "0xABD770", VA = "0xABD770")]
	public FPSDisplay()
	{
	}
}
[Token(Token = "0x2000008")]
public class FlyCamera : MonoBehaviour
{
	[Token(Token = "0x600003D")]
	[Address(RVA = "0xABEC70", Offset = "0xABEC70", VA = "0xABEC70")]
	public FlyCamera()
	{
	}
}
[Token(Token = "0x2000009")]
public class GlobalParticleEmitter : MonoBehaviour
{
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GlobalParticleEmitter Instance;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TeaParticles _particles;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xE42AD4", Offset = "0xE42AD4", VA = "0xE42AD4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xE42B40", Offset = "0xE42B40", VA = "0xE42B40")]
	public void Emit(bool emitAllNow, float flow, Vector3 pos, float rad)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xE42C30", Offset = "0xE42C30", VA = "0xE42C30")]
	public GlobalParticleEmitter()
	{
	}
}
[Token(Token = "0x200000A")]
public class HandGestureDetect : MonoBehaviour
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool GlobalTriggingEnabled;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float GlobalDegreeFilter;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static bool GlobalUseTooltip;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int waitFramesAfterTracking;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7794C4", Offset = "0x7794C4")]
	public float openPinchThreshold;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7794DC", Offset = "0x7794DC")]
	public float trigPinchThreshold;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7794F4", Offset = "0x7794F4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7794F4", Offset = "0x7794F4")]
	private bool _lastEmit;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	private bool _waitingForOpenPinch;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	private bool _touching;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _blockRad;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float particleRad;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float particleFlow;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float trigRadius;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float avoidRetrig;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77952C", Offset = "0x77952C")]
	public VRCursor cursor;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject tooltip;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector2 tooltipOffset;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77953C", Offset = "0x77953C")]
	public bool verboseLog;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand _hand;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private OVRBone _indexTip;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private OVRBone _thumbTip;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool _lastPinched;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	private bool _lastValid;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int _framesTrackedWithHighConfidence;

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xE42EDC", Offset = "0xE42EDC", VA = "0xE42EDC")]
	private void TryToInit()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xE43190", Offset = "0xE43190", VA = "0xE43190")]
	public bool IsPinching()
	{
		return default(bool);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xE43198", Offset = "0xE43198", VA = "0xE43198")]
	private void Update()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xE43A80", Offset = "0xE43A80", VA = "0xE43A80")]
	public HandGestureDetect()
	{
	}
}
[Token(Token = "0x200000B")]
public class Render360Stereo : MonoBehaviour
{
	[Token(Token = "0x200012E")]
	public enum Output
	{
		[Token(Token = "0x4000726")]
		Audio,
		[Token(Token = "0x4000727")]
		CapturePanorama,
		[Token(Token = "0x4000728")]
		AVProHack
	}

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Output output;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool startNow;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool running;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float time;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float initialWait;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float totalDuration;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77954C", Offset = "0x77954C")]
	public bool hideInfo;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool disableGazeClick;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool muteInteractionSounds;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
	public bool disableFocusHighlight;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77955C", Offset = "0x77955C")]
	public float overlayEndDuration;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject overlay;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material overlayMat1;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material overlayMat2;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77956C", Offset = "0x77956C")]
	private DumpAudio _CaptureAudio;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _triggered;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77957C", Offset = "0x77957C")]
	public global::CapturePanorama.CapturePanorama capturePanorama;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xA59C58", Offset = "0xA59C58", VA = "0xA59C58")]
	public Render360Stereo()
	{
	}
}
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7786A4", Offset = "0x7786A4")]
public class ReplaceShaderForCamera : MonoBehaviour
{
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string argument;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Shader shader;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Shader curShader;

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xA59C84", Offset = "0xA59C84", VA = "0xA59C84")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xA59CF4", Offset = "0xA59CF4", VA = "0xA59CF4")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xA59D54", Offset = "0xA59D54", VA = "0xA59D54")]
	public void Update()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xA59E1C", Offset = "0xA59E1C", VA = "0xA59E1C")]
	public ReplaceShaderForCamera()
	{
	}
}
[Serializable]
[Token(Token = "0x200000D")]
public struct SerializableQuaternion
{
	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float w;

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xA59E74", Offset = "0xA59E74", VA = "0xA59E74")]
	public SerializableQuaternion(float rX, float rY, float rZ, float rW)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xA59E80", Offset = "0xA59E80", VA = "0xA59E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xA5A024", Offset = "0xA5A024", VA = "0xA5A024")]
	public static implicit operator Quaternion(SerializableQuaternion rValue)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xA5A054", Offset = "0xA5A054", VA = "0xA5A054")]
	public static implicit operator SerializableQuaternion(Quaternion rValue)
	{
		return default(SerializableQuaternion);
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public struct SerializableVector3
{
	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xA5A058", Offset = "0xA5A058", VA = "0xA5A058")]
	public SerializableVector3(float rX, float rY, float rZ)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xA5A064", Offset = "0xA5A064", VA = "0xA5A064", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xA5A124", Offset = "0xA5A124", VA = "0xA5A124")]
	public static implicit operator Vector3(SerializableVector3 rValue)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xA5A158", Offset = "0xA5A158", VA = "0xA5A158")]
	public static implicit operator SerializableVector3(Vector3 rValue)
	{
		return default(SerializableVector3);
	}
}
[Token(Token = "0x200000F")]
public class SortMesh
{
	[Token(Token = "0x6000053")]
	[Address(RVA = "0xA63D18", Offset = "0xA63D18", VA = "0xA63D18")]
	public SortMesh()
	{
	}
}
[Token(Token = "0x2000010")]
internal static class WriteEXR
{
	[Token(Token = "0x200012F")]
	internal static class HalfHelper
	{
		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint[] mantissaTable;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static uint[] exponentTable;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static ushort[] offsetTable;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static ushort[] baseTable;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static sbyte[] shiftTable;

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xD4311C", Offset = "0xD4311C", VA = "0xD4311C")]
		private static uint ConvertMantissa(int i)
		{
			return default(uint);
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xD4314C", Offset = "0xD4314C", VA = "0xD4314C")]
		private static uint[] GenerateMantissaTable()
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xD43264", Offset = "0xD43264", VA = "0xD43264")]
		private static uint[] GenerateExponentTable()
		{
			return null;
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xD4335C", Offset = "0xD4335C", VA = "0xD4335C")]
		private static ushort[] GenerateOffsetTable()
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xD43428", Offset = "0xD43428", VA = "0xD43428")]
		private static ushort[] GenerateBaseTable()
		{
			return null;
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xD43578", Offset = "0xD43578", VA = "0xD43578")]
		private static sbyte[] GenerateShiftTable()
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xD436B0", Offset = "0xD436B0", VA = "0xD436B0")]
		public static float HalfToSingle(ushort half)
		{
			return default(float);
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xD43014", Offset = "0xD43014", VA = "0xD43014")]
		public static ushort SingleToHalf(float single)
		{
			return default(ushort);
		}
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xD426D8", Offset = "0xD426D8", VA = "0xD426D8")]
	public static void Write(string _filePath, uint _width, uint _height, uint _channels, float[] _rgbaArray)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xD42EAC", Offset = "0xD42EAC", VA = "0xD42EAC")]
	public static void Write(string _filePath, uint _width, uint _height, Color[] _colorArray)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xD42EE4", Offset = "0xD42EE4", VA = "0xD42EE4")]
	public static byte[] Write(uint _width, uint _height, Color[] _colorArray)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xD42714", Offset = "0xD42714", VA = "0xD42714")]
	public static byte[] Write(uint _width, uint _height, uint _channels, float[] _rgbaArray)
	{
		return null;
	}
}
[Token(Token = "0x2000011")]
[ExecuteInEditMode]
public class AALinesFromMesh : MonoBehaviour
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool GenerateNow;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material LineMaterial;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject MeshRoot;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float CompressResolution;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77958C", Offset = "0x77958C")]
	public float CompressSpace;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float MaxDistance;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<GameObject> OutObjects;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool SkipTransparent;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int MaxPoints;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float Precision;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject Center;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject MinRef;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject MaxRef;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool UsePreciseCut;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	public bool UseSectionCut;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject SectionCut;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool DebugPoints;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int MaxDebugPoints;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Material _prevMat;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float CompressResolutionInv;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Vector3 _center;

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xD4B90C", Offset = "0xD4B90C", VA = "0xD4B90C")]
	private static float rscomp(float x, float a)
	{
		return default(float);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xD4B940", Offset = "0xD4B940", VA = "0xD4B940")]
	private Vector3Int warp(Vector3 v)
	{
		return default(Vector3Int);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xD4BB9C", Offset = "0xD4BB9C", VA = "0xD4BB9C")]
	private Vector3 warpInv(Vector3Int vi)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xD4BDF4", Offset = "0xD4BDF4", VA = "0xD4BDF4")]
	public static int MeshByteSizeEstimation(List<Mesh> meshes)
	{
		return default(int);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xD4BEA4", Offset = "0xD4BEA4", VA = "0xD4BEA4")]
	public static List<GameObject> GenerateGameObjectsForLineMeshes(List<Mesh> meshes, GameObject root, Material linemat)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xD4C14C", Offset = "0xD4C14C", VA = "0xD4C14C")]
	private float GetPrecison()
	{
		return default(float);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xD4C170", Offset = "0xD4C170", VA = "0xD4C170")]
	private bool skipOtherRoots(Renderer renderer)
	{
		return default(bool);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xD4C224", Offset = "0xD4C224", VA = "0xD4C224")]
	private void GenerateLineMeshesAndGameObjects()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xD4C69C", Offset = "0xD4C69C", VA = "0xD4C69C")]
	private void debugGenerateCloudMesh(HashSet<Vector3Int> verts, Vector3 center)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xD4CA50", Offset = "0xD4CA50", VA = "0xD4CA50")]
	private void AddMeshToScene(List<int> tris, List<Vector3> verts)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xD4CBBC", Offset = "0xD4CBBC", VA = "0xD4CBBC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xD4CC98", Offset = "0xD4CC98", VA = "0xD4CC98")]
	private void Update()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xD4CCAC", Offset = "0xD4CCAC", VA = "0xD4CCAC")]
	public AALinesFromMesh()
	{
	}
}
[Token(Token = "0x2000012")]
public class AdjustVRHeight : MonoBehaviour
{
	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float ReferenceEyeHeight;

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xD4CD4C", Offset = "0xD4CD4C", VA = "0xD4CD4C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xD4CE3C", Offset = "0xD4CE3C", VA = "0xD4CE3C")]
	public AdjustVRHeight()
	{
	}
}
[Token(Token = "0x2000013")]
[ExecuteInEditMode]
public class AimBoneToCamera : MonoBehaviour
{
	[Token(Token = "0x2000130")]
	public enum CombineMethod
	{
		[Token(Token = "0x400072F")]
		IgnoreAnimation,
		[Token(Token = "0x4000730")]
		AddToAnimation,
		[Token(Token = "0x4000731")]
		RespondToAnimation
	}

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CombineMethod Combine;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float SmoothingDuration;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7795A4", Offset = "0x7795A4")]
	public float DeadAngle;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7795C0", Offset = "0x7795C0")]
	public float LimitAngle;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 NormalMul;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 BonePositionOffset;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7795DC", Offset = "0x7795DC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7795DC", Offset = "0x7795DC")]
	public float RandomDropoutProbability;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float RandomDropoutSpeed;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x779630", Offset = "0x779630")]
	public GameObject ReferencePoint;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Quaternion BaseRotation;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Quaternion ReferenceLocalTargetDelta;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool tempDebug;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	public bool tempDebug2;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private RotationSmoother _smoothDiffRot;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xD4CE50", Offset = "0xD4CE50", VA = "0xD4CE50")]
	private float GetAngle(Quaternion q)
	{
		return default(float);
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xD4CE8C", Offset = "0xD4CE8C", VA = "0xD4CE8C")]
	private Vector3 GetCurrentBonePos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xD4CF50", Offset = "0xD4CF50", VA = "0xD4CF50")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xD4D610", Offset = "0xD4D610", VA = "0xD4D610")]
	public AimBoneToCamera()
	{
	}
}
[Token(Token = "0x2000014")]
public class AnimateEyes : MonoBehaviour
{
	[Token(Token = "0x2000131")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778A8C", Offset = "0x778A8C")]
	private sealed class <WaitAndActivate>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimateEyes <>4__this;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject obj;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0xD4E030", Offset = "0xD4E030", VA = "0xD4E030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0xD4E098", Offset = "0xD4E098", VA = "0xD4E098", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xD4DE44", Offset = "0xD4DE44", VA = "0xD4DE44")]
		[DebuggerHidden]
		public <WaitAndActivate>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xD4DF2C", Offset = "0xD4DF2C", VA = "0xD4DF2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xD4DF30", Offset = "0xD4DF30", VA = "0xD4DF30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xD4E038", Offset = "0xD4E038", VA = "0xD4E038", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778A9C", Offset = "0x778A9C")]
	private sealed class <WaitAndInactivate>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimateEyes <>4__this;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject obj;

		[Token(Token = "0x1700003C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0xD4E1A4", Offset = "0xD4E1A4", VA = "0xD4E1A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0xD4E20C", Offset = "0xD4E20C", VA = "0xD4E20C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xD4DEEC", Offset = "0xD4DEEC", VA = "0xD4DEEC")]
		[DebuggerHidden]
		public <WaitAndInactivate>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xD4E0A0", Offset = "0xD4E0A0", VA = "0xD4E0A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xD4E0A4", Offset = "0xD4E0A4", VA = "0xD4E0A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xD4E1AC", Offset = "0xD4E1AC", VA = "0xD4E1AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<GameObject> eyePairs;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject eyePair1;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject eyePair2;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject eyePair3;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject eyePair4;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject eyePair5;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject eyePair6;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject eyePair7;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject eyePair8;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float blinkWait;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float blinkWaitRandom;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float blinkDuration;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float blinkDurationRandom;

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xD4D6D4", Offset = "0xD4D6D4", VA = "0xD4D6D4")]
	private List<GameObject> getChildren(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xD4D978", Offset = "0xD4D978", VA = "0xD4D978")]
	private void hookupEyes()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xD4DC58", Offset = "0xD4DC58", VA = "0xD4DC58")]
	private void Start()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xD4DDA4", Offset = "0xD4DDA4", VA = "0xD4DDA4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xD4DC7C", Offset = "0xD4DC7C", VA = "0xD4DC7C")]
	private void StartAnimCoroutines()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xD4DDC8", Offset = "0xD4DDC8", VA = "0xD4DDC8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77A718", Offset = "0x77A718")]
	private IEnumerator WaitAndActivate(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xD4DE70", Offset = "0xD4DE70", VA = "0xD4DE70")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77A77C", Offset = "0x77A77C")]
	private IEnumerator WaitAndInactivate(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xD4DF18", Offset = "0xD4DF18", VA = "0xD4DF18")]
	public AnimateEyes()
	{
	}
}
[Token(Token = "0x2000015")]
public class ArtPlungeSceneRoot : MonoBehaviour, ProcessBeforeSceneSaveCallback.Callback
{
	[Serializable]
	[Token(Token = "0x2000133")]
	public class TransitionAdjustment
	{
		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<GameObject> nodes;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject forGallery;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject forCamera;

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xD51334", Offset = "0xD51334", VA = "0xD51334")]
		public TransitionAdjustment()
		{
		}
	}

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> Behind;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<TransitionAdjustment> TransitionAdjustments;

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xD50D04", Offset = "0xD50D04", VA = "0xD50D04")]
	private void _getObjectsWithNameRec(GameObject go, string name, List<GameObject> li, int depth)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xD51040", Offset = "0xD51040", VA = "0xD51040")]
	private List<GameObject> getObjectsWithNameRecursive(GameObject root, string name)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xD510D0", Offset = "0xD510D0", VA = "0xD510D0", Slot = "4")]
	private void ProcessBeforeSceneSaveCallback.Callback.OnBeforeSceneSave(string sceneName)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xD5133C", Offset = "0xD5133C", VA = "0xD5133C")]
	public ArtPlungeSceneRoot()
	{
	}
}
[Token(Token = "0x2000016")]
public class CameraMainGameObject : MonoBehaviour
{
	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject MainFallback;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GameObject _MainFallback;

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xD57024", Offset = "0xD57024", VA = "0xD57024")]
	public static Vector3 Position()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xD5709C", Offset = "0xD5709C", VA = "0xD5709C")]
	public static Vector3 Forward()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xD57114", Offset = "0xD57114", VA = "0xD57114")]
	public static Quaternion Rotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xD4D544", Offset = "0xD4D544", VA = "0xD4D544")]
	public static GameObject Get()
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xD5718C", Offset = "0xD5718C", VA = "0xD5718C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xD571FC", Offset = "0xD571FC", VA = "0xD571FC")]
	public CameraMainGameObject()
	{
	}
}
[Token(Token = "0x2000017")]
public class DelaySound : MonoBehaviour
{
	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool triggerOnStartAndEnable;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float delay;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource audioSource;

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xAB6804", Offset = "0xAB6804", VA = "0xAB6804")]
	private void Start()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xAB68C8", Offset = "0xAB68C8", VA = "0xAB68C8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xAB6968", Offset = "0xAB6968", VA = "0xAB6968")]
	public DelaySound()
	{
	}
}
[Token(Token = "0x2000018")]
public class DrawOffline : MonoBehaviour
{
	[Token(Token = "0x2000134")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778AAC", Offset = "0x778AAC")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material mat;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mesh mesh;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Matrix4x4 matrix;

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xAB74DC", Offset = "0xAB74DC", VA = "0xAB74DC")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xAB7574", Offset = "0xAB7574", VA = "0xAB7574")]
		internal void <Mesh>b__0()
		{
		}
	}

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static DrawOffline _instance;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera _cam;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action _render;

	[Token(Token = "0x17000004")]
	public static DrawOffline Static
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0xAB6980", Offset = "0xAB6980", VA = "0xAB6980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xAB6A6C", Offset = "0xAB6A6C", VA = "0xAB6A6C")]
	public static DrawOffline Create()
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xAB6AF4", Offset = "0xAB6AF4", VA = "0xAB6AF4")]
	public void ValidateCamera()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xAB6C08", Offset = "0xAB6C08", VA = "0xAB6C08")]
	public void RemoveAndCleanup()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xAB6C84", Offset = "0xAB6C84", VA = "0xAB6C84")]
	public static RenderTexture Custom(Material mat, Action<RenderTexture> render, [Optional] RenderTexture renderTex, int w = 512, int h = 512, int depth = 0, RenderTextureFormat fmt = RenderTextureFormat.ARGBFloat)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xAB6F14", Offset = "0xAB6F14", VA = "0xAB6F14")]
	public static RenderTexture ProcessUsingMaterial(Material mat, RenderTexture source, [Optional] RenderTexture renderTex)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xAB7050", Offset = "0xAB7050", VA = "0xAB7050")]
	public static RenderTexture GenerateUsingMaterial(Material mat, [Optional] RenderTexture renderTex, int w = 512, int h = 512, int depth = 0, RenderTextureFormat fmt = RenderTextureFormat.ARGBFloat)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xAB7170", Offset = "0xAB7170", VA = "0xAB7170")]
	public RenderTexture Custom(Action render, [Optional] RenderTexture renderTex, int w = 512, int h = 512, int depth = 0, RenderTextureFormat fmt = RenderTextureFormat.ARGBFloat)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xAB73E4", Offset = "0xAB73E4", VA = "0xAB73E4")]
	public RenderTexture Mesh(Mesh mesh, Material mat, Matrix4x4 matrix, [Optional] RenderTexture renderTex, int w = 512, int h = 512, int depth = 0, RenderTextureFormat fmt = RenderTextureFormat.ARGBFloat)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xAB74E4", Offset = "0xAB74E4", VA = "0xAB74E4")]
	public void OnPostRender()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xAB7568", Offset = "0xAB7568", VA = "0xAB7568")]
	public DrawOffline()
	{
	}
}
[Token(Token = "0x2000019")]
public class DumpAudio : MonoBehaviour
{
	[Token(Token = "0x600008E")]
	[Address(RVA = "0xABC368", Offset = "0xABC368", VA = "0xABC368")]
	public DumpAudio()
	{
	}
}
[Token(Token = "0x200001A")]
public class DumpFrames : MonoBehaviour
{
	[Token(Token = "0x600008F")]
	[Address(RVA = "0xABC370", Offset = "0xABC370", VA = "0xABC370")]
	public DumpFrames()
	{
	}
}
[Token(Token = "0x200001B")]
public class DumpGlobal : MonoBehaviour
{
	[Token(Token = "0x6000090")]
	[Address(RVA = "0xABCC38", Offset = "0xABCC38", VA = "0xABCC38")]
	public DumpGlobal()
	{
	}
}
[Token(Token = "0x200001C")]
public class EnableByKey : MonoBehaviour
{
	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Target;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string Key;

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xABCC40", Offset = "0xABCC40", VA = "0xABCC40")]
	private void Update()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xABCCA4", Offset = "0xABCCA4", VA = "0xABCCA4")]
	public EnableByKey()
	{
	}
}
[Token(Token = "0x200001D")]
public class EyeBlink : MonoBehaviour
{
	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778ABC", Offset = "0x778ABC")]
	private sealed class <WaitAndActivate>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EyeBlink <>4__this;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0xABD02C", Offset = "0xABD02C", VA = "0xABD02C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0xABD094", Offset = "0xABD094", VA = "0xABD094", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xABCE44", Offset = "0xABCE44", VA = "0xABCE44")]
		[DebuggerHidden]
		public <WaitAndActivate>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xABCF2C", Offset = "0xABCF2C", VA = "0xABCF2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xABCF30", Offset = "0xABCF30", VA = "0xABCF30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xABD034", Offset = "0xABD034", VA = "0xABD034", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000136")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778ACC", Offset = "0x778ACC")]
	private sealed class <WaitAndInactivate>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EyeBlink <>4__this;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <totalDuration>5__2;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <t1>5__3;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <t2>5__4;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0xABD2C8", Offset = "0xABD2C8", VA = "0xABD2C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600088E")]
			[Address(RVA = "0xABD330", Offset = "0xABD330", VA = "0xABD330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xABCEE0", Offset = "0xABCEE0", VA = "0xABCEE0")]
		[DebuggerHidden]
		public <WaitAndInactivate>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xABD09C", Offset = "0xABD09C", VA = "0xABD09C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xABD0A0", Offset = "0xABD0A0", VA = "0xABD0A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xABD2D0", Offset = "0xABD2D0", VA = "0xABD2D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject eyePairClosed;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject eyePairHalfClosed;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float blinkWait;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float blinkWaitRandom;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float blinkDuration;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float blinkDurationRandom;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779668", Offset = "0x779668")]
	public float OpeningDurationPercentage;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779684", Offset = "0x779684")]
	public float FullyClosedDurationPercentage;

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xABCD70", Offset = "0xABCD70", VA = "0xABCD70")]
	private void Start()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xABCDD0", Offset = "0xABCDD0", VA = "0xABCDD0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xABCD74", Offset = "0xABCD74", VA = "0xABCD74")]
	private void StartAnimCoroutines()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xABCDD4", Offset = "0xABCDD4", VA = "0xABCDD4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77A7E0", Offset = "0x77A7E0")]
	private IEnumerator WaitAndActivate()
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xABCE70", Offset = "0xABCE70", VA = "0xABCE70")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77A844", Offset = "0x77A844")]
	private IEnumerator WaitAndInactivate()
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xABCF0C", Offset = "0xABCF0C", VA = "0xABCF0C")]
	public EyeBlink()
	{
	}
}
[Token(Token = "0x200001E")]
public class ForceSwitchMaterial : MonoBehaviour
{
	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material material;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Shader shader;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool copyMaterial;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool keepTexture;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool setColor;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color color;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int renderQueue;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xABEC78", Offset = "0xABEC78", VA = "0xABEC78")]
	private void Update()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xABF100", Offset = "0xABF100", VA = "0xABF100")]
	public ForceSwitchMaterial()
	{
	}
}
[Token(Token = "0x200001F")]
public class GameObjectLookup : MonoBehaviour
{
	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, GameObject> _nameLookup;

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xAC83B0", Offset = "0xAC83B0", VA = "0xAC83B0")]
	public static GameObject Find(string name)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xAC918C", Offset = "0xAC918C", VA = "0xAC918C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xAC92B4", Offset = "0xAC92B4", VA = "0xAC92B4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xAC9418", Offset = "0xAC9418", VA = "0xAC9418")]
	public GameObjectLookup()
	{
	}
}
[Token(Token = "0x2000020")]
[ExecuteInEditMode]
public class GenGeometry : MonoBehaviour
{
	[Token(Token = "0x2000137")]
	public enum geometryType
	{
		[Token(Token = "0x400074A")]
		Frame,
		[Token(Token = "0x400074B")]
		L_Shape,
		[Token(Token = "0x400074C")]
		SpecialTube,
		[Token(Token = "0x400074D")]
		FrameWithCornerquality,
		[Token(Token = "0x400074E")]
		Sphere,
		[Token(Token = "0x400074F")]
		SphereFlipFaceNormals,
		[Token(Token = "0x4000750")]
		WindowSkyDome,
		[Token(Token = "0x4000751")]
		PartialSphere
	}

	[Token(Token = "0x2000138")]
	public enum uvStyle
	{
		[Token(Token = "0x4000753")]
		Front,
		[Token(Token = "0x4000754")]
		FrontFreeAspect,
		[Token(Token = "0x4000755")]
		FrontFromCorners,
		[Token(Token = "0x4000756")]
		SegmentColumnIds,
		[Token(Token = "0x4000757")]
		SegmentColumnIdsFlipU
	}

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float innerWidth;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float innerHeight;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float outerWidth;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float outerHeight;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float depth;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public geometryType type;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public uvStyle uvMap;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool reuseFirstAsLast;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float uvScale;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector2 uvScale2;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float uOffset;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float vOffset;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int quality;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float expandBound;

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xE42A50", Offset = "0xE42A50", VA = "0xE42A50")]
	public GenGeometry()
	{
	}
}
[Token(Token = "0x2000021")]
[ExecuteInEditMode]
public class GenLines : MonoBehaviour
{
	[Token(Token = "0x2000139")]
	public enum lineType
	{
		[Token(Token = "0x4000759")]
		Cube,
		[Token(Token = "0x400075A")]
		Grid,
		[Token(Token = "0x400075B")]
		GridNoOverlap,
		[Token(Token = "0x400075C")]
		LinesFromImage
	}

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public lineType type;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float width;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float height;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float depth;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float gridSpace;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float margin;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float noisePoints;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float noiseLine;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 noiseDir;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float expandBound;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D image;

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xE42AB8", Offset = "0xE42AB8", VA = "0xE42AB8")]
	public GenLines()
	{
	}
}
[Token(Token = "0x2000022")]
public class HideByPlaneSide : MonoBehaviour
{
	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Target;

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xE43B18", Offset = "0xE43B18", VA = "0xE43B18")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xE43C84", Offset = "0xE43C84", VA = "0xE43C84")]
	public HideByPlaneSide()
	{
	}
}
[Token(Token = "0x2000023")]
public static class InstanceId
{
	[Token(Token = "0x200013A")]
	public static class AddressHelper
	{
		[StructLayout(2)]
		[Token(Token = "0x2000241")]
		private struct ObjectReinterpreter
		{
			[Token(Token = "0x4000BE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ObjectWrapper AsObject;

			[Token(Token = "0x4000BE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtrWrapper AsIntPtr;
		}

		[Token(Token = "0x2000242")]
		private class ObjectWrapper
		{
			[Token(Token = "0x4000BE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object Object;

			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0xE43D2C", Offset = "0xE43D2C", VA = "0xE43D2C")]
			public ObjectWrapper()
			{
			}
		}

		[Token(Token = "0x2000243")]
		private class IntPtrWrapper
		{
			[Token(Token = "0x4000BE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IntPtr Value;

			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0xE43E5C", Offset = "0xE43E5C", VA = "0xE43E5C")]
			public IntPtrWrapper()
			{
			}
		}

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object mutualObject;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ObjectReinterpreter reinterpreter;

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xE43C8C", Offset = "0xE43C8C", VA = "0xE43C8C")]
		static AddressHelper()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xE43D34", Offset = "0xE43D34", VA = "0xE43D34")]
		public static IntPtr GetAddress(object obj)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000891")]
		public static T GetInstance<T>(IntPtr address)
		{
			return (T)null;
		}
	}

	[Token(Token = "0x60000A4")]
	public static IntPtr Get<T>(this T obj) where T : class
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60000A5")]
	public static string GetString<T>(this T obj) where T : class
	{
		return null;
	}
}
[Token(Token = "0x2000024")]
public class LineWorldCameraBound : MonoBehaviour
{
	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float GlobalAmount;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource SoundL;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource SoundR;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource SoundHead2D;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject BoundMesh;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float TransparentBoundRange;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float MaxHoleRadiusForHands;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool DebugVRInput;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool DebugShaderOutput;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public bool OverrideVRInput;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject DebugLHand;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject DebugRHand;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject DebugHead;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject DebugLHandOut;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject DebugRHandOut;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject DebugHeadOut;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject TurnBackMessage;

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xE4CF08", Offset = "0xE4CF08", VA = "0xE4CF08")]
	private void GetDirAndMag(Vector3 from, Vector3 to, out Vector3 dir, out float mag)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xE4D05C", Offset = "0xE4D05C", VA = "0xE4D05C")]
	private void UpdateSound(AudioSource audio, float amount, [Optional] Vector3 pos)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xE4D1E4", Offset = "0xE4D1E4", VA = "0xE4D1E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xE4D204", Offset = "0xE4D204", VA = "0xE4D204")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xE4D284", Offset = "0xE4D284", VA = "0xE4D284")]
	private Vector3 GetCalibratedHeadPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xE4D354", Offset = "0xE4D354", VA = "0xE4D354")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xE4E4D0", Offset = "0xE4E4D0", VA = "0xE4E4D0")]
	public LineWorldCameraBound()
	{
	}
}
[Token(Token = "0x2000025")]
public class LineWorldEnabler : MonoBehaviour
{
	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool LineWorldsEnabled;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AALinesFromMesh _aalines;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _prevEnabled;

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xE4E4E8", Offset = "0xE4E4E8", VA = "0xE4E4E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xE4E578", Offset = "0xE4E578", VA = "0xE4E578")]
	private void UpdateLineWorld()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xE4E784", Offset = "0xE4E784", VA = "0xE4E784")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xE4E788", Offset = "0xE4E788", VA = "0xE4E788")]
	public LineWorldEnabler()
	{
	}
}
[Token(Token = "0x2000026")]
public class LookHover : MonoBehaviour
{
	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool useControllerIfAvalable;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float angleThreshold;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float angleFalloff;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float distThreshold;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float distFalloff;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float smooth;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float fadeInTime;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float fadeOutTime;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float fadeInDelay;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float fadeOutDelay;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 spinRotOff;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector3 spinRotOn;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material material;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string materialProperty;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float materialPropertyOff;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float materialPropertyOn;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string optionName;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float groupId;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float maxAngleAmount;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static LookHover maxAngleObj;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static LookHover currentHover;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static int currentFrame;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private softAction action;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Quaternion rot;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject obj;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GameObject transformOn;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private GameObject transformOff;

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xE4EBEC", Offset = "0xE4EBEC", VA = "0xE4EBEC")]
	public static string GetHoveringOptionName(int group = 0)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xE4ECC4", Offset = "0xE4ECC4", VA = "0xE4ECC4")]
	private void hookUpObjects()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xE4F180", Offset = "0xE4F180", VA = "0xE4F180")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xE4F184", Offset = "0xE4F184", VA = "0xE4F184")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xE4FD18", Offset = "0xE4FD18", VA = "0xE4FD18")]
	public LookHover()
	{
	}
}
[Token(Token = "0x2000027")]
public class MeshParticlePoint : MonoBehaviour
{
	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Scale;

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xE510AC", Offset = "0xE510AC", VA = "0xE510AC")]
	public MeshParticlePoint()
	{
	}
}
[Token(Token = "0x2000028")]
[ExecuteInEditMode]
public class MeshParticleSystem : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200013B")]
	public class SimParams
	{
		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float TimeScale;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 Gravity;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Drag;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float DragRotational;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask Collision;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CollisionRadius;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float CollisionAdjustVel;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float ParticleColRadius;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float ParticleColAdjustVel;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject MoveAlongWith;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77A5F4", Offset = "0x77A5F4")]
		public float RandomFlux;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float RandomFluxRotational;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float RandomFluxScale;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float RandomFluxDisplaceSpeed;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public float _globalFluxOffset;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[HideInInspector]
		public int _globalSelfCollisionIdCycle;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77A624", Offset = "0x77A624")]
		public bool VortexEnabled;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject VortexCenter;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float VortexTargetRadius;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float VortexAttract;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float VortexAmount;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77A634", Offset = "0x77A634")]
		public bool DirectionalEnabled;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public GameObject Directional;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float DirectionalCutoffAngle;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float DirectionalFalloff;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float DirectionalAmount;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float DirectionalMaxDist;

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xE53534", Offset = "0xE53534", VA = "0xE53534")]
		public SimParams()
		{
		}
	}

	[Token(Token = "0x200013C")]
	public struct SimPoint
	{
		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 pos;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 posvel;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Quaternion rot;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 rotvel;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 fluxOffset;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float invmass;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 lastNoise;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int nextNoiseCounter;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int nearestId;

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xE517B0", Offset = "0xE517B0", VA = "0xE517B0")]
		public void AddForce(Vector3 v)
		{
		}
	}

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool FollowGameObjects;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool Simulate;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float BaseScale;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float previewFPS;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimParams SimulationParams;

	[NonSerialized]
	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MeshParticlePoint[] _points;

	[NonSerialized]
	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Texture2D _transformsInTexture;

	[NonSerialized]
	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Color[] _transformData;

	[NonSerialized]
	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int _texWidth;

	[NonSerialized]
	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool _inited;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private SimPoint[] _particles;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private uint _hashRandPrev;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector3 _prevMoveAlongPos;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Collider[] _tmpColliders;

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xE510BC", Offset = "0xE510BC", VA = "0xE510BC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xE510C4", Offset = "0xE510C4", VA = "0xE510C4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xE510CC", Offset = "0xE510CC", VA = "0xE510CC")]
	public static Vector3 Sin3D(Vector3 p)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xE511B4", Offset = "0xE511B4", VA = "0xE511B4")]
	public static Vector3 Cos3D(Vector3 p)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xE5129C", Offset = "0xE5129C", VA = "0xE5129C")]
	public static Vector3 Noise3D(Vector3 p)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xE5139C", Offset = "0xE5139C", VA = "0xE5139C")]
	public static void SimulatePoint(ref SimPoint p, float dt, SimParams globals)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xE51888", Offset = "0xE51888", VA = "0xE51888")]
	private void Init()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xE51DD8", Offset = "0xE51DD8", VA = "0xE51DD8")]
	private uint hash(uint a)
	{
		return default(uint);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xE51E3C", Offset = "0xE51E3C", VA = "0xE51E3C")]
	private void hashSeed(uint v)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xE51E44", Offset = "0xE51E44", VA = "0xE51E44")]
	private float hashRand()
	{
		return default(float);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xE51ED0", Offset = "0xE51ED0", VA = "0xE51ED0")]
	private float hashRand0()
	{
		return default(float);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xE51EF0", Offset = "0xE51EF0", VA = "0xE51EF0")]
	private float hashRand0_t3()
	{
		return default(float);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xE51F54", Offset = "0xE51F54", VA = "0xE51F54")]
	private Vector3 hashRandV3()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xE51FE0", Offset = "0xE51FE0", VA = "0xE51FE0")]
	private static Quaternion Normalized(Quaternion q)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xE51A7C", Offset = "0xE51A7C", VA = "0xE51A7C")]
	private void ResetParticles()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xE520C4", Offset = "0xE520C4", VA = "0xE520C4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xE52300", Offset = "0xE52300", VA = "0xE52300")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xE53474", Offset = "0xE53474", VA = "0xE53474")]
	public MeshParticleSystem()
	{
	}
}
[Token(Token = "0x2000029")]
public class OVRScreenFadeSP : MonoBehaviour
{
	[Token(Token = "0x200013D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778ADC", Offset = "0x778ADC")]
	private sealed class <doFade>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OVRScreenFadeSP <>4__this;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isFadeIn;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color <color>5__3;

		[Token(Token = "0x17000042")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0xA51E1C", Offset = "0xA51E1C", VA = "0xA51E1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xA51E84", Offset = "0xA51E84", VA = "0xA51E84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xA51B04", Offset = "0xA51B04", VA = "0xA51B04")]
		[DebuggerHidden]
		public <doFade>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xA51CC0", Offset = "0xA51CC0", VA = "0xA51CC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xA51CC4", Offset = "0xA51CC4", VA = "0xA51CC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xA51E24", Offset = "0xA51E24", VA = "0xA51E24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float fadeTime;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color fadeColor;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material fadeMaterial;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool isFading;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private YieldInstruction fadeInstruction;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private IEnumerator coroutine;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _inited;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static OVRScreenFadeSP instance1;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static OVRScreenFadeSP instance2;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static OVRScreenFadeSP instance3;

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xA517C0", Offset = "0xA517C0", VA = "0xA517C0")]
	private void Init()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xA51918", Offset = "0xA51918", VA = "0xA51918")]
	public void triggerFade(bool isFadeIn = true)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xA51A14", Offset = "0xA51A14", VA = "0xA51A14")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xA51A50", Offset = "0xA51A50", VA = "0xA51A50")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xA51990", Offset = "0xA51990", VA = "0xA51990")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77A8C8", Offset = "0x77A8C8")]
	private IEnumerator doFade(bool isFadeIn = true)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xA51B30", Offset = "0xA51B30", VA = "0xA51B30")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xA51C1C", Offset = "0xA51C1C", VA = "0xA51C1C")]
	public OVRScreenFadeSP()
	{
	}
}
[Token(Token = "0x200002A")]
[ExecuteInEditMode]
public class ParticleBaseMesh : MonoBehaviour
{
	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int count;

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xA53F0C", Offset = "0xA53F0C", VA = "0xA53F0C")]
	public ParticleBaseMesh()
	{
	}
}
[Token(Token = "0x200002B")]
public class ProcessBeforeSceneSaveCallback
{
	[Token(Token = "0x200013E")]
	public interface Callback
	{
		[Token(Token = "0x600089A")]
		void OnBeforeSceneSave(string sceneName);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xA53F1C", Offset = "0xA53F1C", VA = "0xA53F1C")]
	public ProcessBeforeSceneSaveCallback()
	{
	}
}
[Token(Token = "0x200002C")]
public class Render2DQuad : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200013F")]
	public class Quad
	{
		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 Position;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 Handle;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Size;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Material RenderMaterial;

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xA59BCC", Offset = "0xA59BCC", VA = "0xA59BCC")]
		public Quad()
		{
		}
	}

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Padding;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Quad> Quads;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material mat;

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xA597A8", Offset = "0xA597A8", VA = "0xA597A8")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xA59BB8", Offset = "0xA59BB8", VA = "0xA59BB8")]
	public Render2DQuad()
	{
	}
}
[Token(Token = "0x200002D")]
public class SetCameraNearAndFar : MonoBehaviour
{
	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Near;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float Far;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool SetFallback;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Camera> _result;

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xA5A15C", Offset = "0xA5A15C", VA = "0xA5A15C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xA5A33C", Offset = "0xA5A33C", VA = "0xA5A33C")]
	public SetCameraNearAndFar()
	{
	}
}
[Token(Token = "0x200002E")]
public class ShowUnityLogOnTextMesh : MonoBehaviour
{
	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool ignoreLog;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool ignoreWarnings;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int _maxLines;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Queue<string> _lines;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _warnings;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int _errors;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int _exceptions;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private TextMesh _textMesh;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ShowUnityLogOnTextMesh _instance;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _debugTmp;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string _linesStr;

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xA5A824", Offset = "0xA5A824", VA = "0xA5A824")]
	public static void DebugTmp(string s)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xA5A8E8", Offset = "0xA5A8E8", VA = "0xA5A8E8")]
	public static void Log(string text)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xA5AB04", Offset = "0xA5AB04", VA = "0xA5AB04")]
	private void UpdateLinesCache()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xA5A8A8", Offset = "0xA5A8A8", VA = "0xA5A8A8")]
	private void UpdateText()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xA5AA00", Offset = "0xA5AA00", VA = "0xA5AA00")]
	public void LogCallback(string condition, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xA5AC8C", Offset = "0xA5AC8C", VA = "0xA5AC8C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xA5AD48", Offset = "0xA5AD48", VA = "0xA5AD48")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xA5ADEC", Offset = "0xA5ADEC", VA = "0xA5ADEC")]
	public ShowUnityLogOnTextMesh()
	{
	}
}
[Token(Token = "0x200002F")]
public static class GameObjectExtensions
{
	[Token(Token = "0x60000E2")]
	public static T GetOrCreate<T>(this GameObject go) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xAC6A3C", Offset = "0xAC6A3C", VA = "0xAC6A3C")]
	public static void SetActiveSmooth(this GameObject go, bool active, float smoothDuration = 0.1f, [Optional] Func<float, Color> smoothvalToColor)
	{
	}
}
[Token(Token = "0x2000030")]
public class SmoothEnable : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778AEC", Offset = "0x778AEC")]
	private sealed class <>c
	{
		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Renderer> <>9__4_0;

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xA5D5F0", Offset = "0xA5D5F0", VA = "0xA5D5F0")]
		public <>c()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xA5D5F8", Offset = "0xA5D5F8", VA = "0xA5D5F8")]
		internal bool <ValidateRends>b__4_0(Renderer r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<Renderer> _rends;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float SmoothDuration;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool SmoothEnableTarget;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ValueSmoother _enableSmoothed;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Func<float, Color> smoothvalToColor;

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xA5CFB8", Offset = "0xA5CFB8", VA = "0xA5CFB8")]
	private void ValidateRends()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xA5D0F4", Offset = "0xA5D0F4", VA = "0xA5D0F4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xA5D0F8", Offset = "0xA5D0F8", VA = "0xA5D0F8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xA5D0FC", Offset = "0xA5D0FC", VA = "0xA5D0FC")]
	public void Set(bool active, float smoothDuration)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xA5D188", Offset = "0xA5D188", VA = "0xA5D188")]
	private void UpdateRenderers()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xA5D498", Offset = "0xA5D498", VA = "0xA5D498")]
	private void Update()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xA5D504", Offset = "0xA5D504", VA = "0xA5D504")]
	public SmoothEnable()
	{
	}
}
[Token(Token = "0x2000031")]
[ExecuteInEditMode]
public class SpAction : MonoBehaviour, SpAction.floatValue
{
	[Token(Token = "0x2000141")]
	public interface floatValue
	{
		[Token(Token = "0x600089F")]
		float GetActionValue();
	}

	[Token(Token = "0x2000142")]
	public enum LinearSourceMapping
	{
		[Token(Token = "0x4000790")]
		NoChange,
		[Token(Token = "0x4000791")]
		Inverse,
		[Token(Token = "0x4000792")]
		TriangularWindow,
		[Token(Token = "0x4000793")]
		InverseTriangularWindow
	}

	[Token(Token = "0x2000143")]
	public enum NonLinearSourceMapping
	{
		[Token(Token = "0x4000795")]
		None,
		[Token(Token = "0x4000796")]
		Smoothstep,
		[Token(Token = "0x4000797")]
		Smootherstep
	}

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Source;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7796A0", Offset = "0x7796A0")]
	public float SourceOverride;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LinearSourceMapping SourceTranform;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public NonLinearSourceMapping SourceEasing;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7796BC", Offset = "0x7796BC")]
	public float InFade;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float OutFade;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float InDelay;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float OutDelay;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7796D0", Offset = "0x7796D0")]
	public float Smoothness;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private softAction _action;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private floatValue _parentSource;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float _lastTime;

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xA63EB0", Offset = "0xA63EB0", VA = "0xA63EB0")]
	private static float smoothstepc(float x)
	{
		return default(float);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xA63EC8", Offset = "0xA63EC8", VA = "0xA63EC8")]
	private static float smootherstepc(float x)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xA63EF4", Offset = "0xA63EF4", VA = "0xA63EF4")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xA63FC8", Offset = "0xA63FC8", VA = "0xA63FC8")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xA63FCC", Offset = "0xA63FCC", VA = "0xA63FCC", Slot = "4")]
	private float SpAction.floatValue.GetActionValue()
	{
		return default(float);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xA63FD0", Offset = "0xA63FD0", VA = "0xA63FD0")]
	private float UpdateActionVal()
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xA64270", Offset = "0xA64270", VA = "0xA64270")]
	public SpAction()
	{
	}
}
[Token(Token = "0x2000032")]
[ExecuteInEditMode]
public class SpActionFromAudioSource : MonoBehaviour, SpAction.floatValue
{
	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float ActionStartTime;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ActionEndTime;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float _curValue;

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xA642E4", Offset = "0xA642E4", VA = "0xA642E4", Slot = "4")]
	private float SpAction.floatValue.GetActionValue()
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xA642EC", Offset = "0xA642EC", VA = "0xA642EC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xA643E0", Offset = "0xA643E0", VA = "0xA643E0")]
	public SpActionFromAudioSource()
	{
	}
}
[Token(Token = "0x2000033")]
[ExecuteInEditMode]
public class SpActionToBlendshape : SpAction
{
	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7796E4", Offset = "0x7796E4")]
	public float ValueOff;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float ValueOn;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string BlendShapeName;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject TargetOverride;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int _blendShapeId;

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xA643F0", Offset = "0xA643F0", VA = "0xA643F0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xA64648", Offset = "0xA64648", VA = "0xA64648")]
	public SpActionToBlendshape()
	{
	}
}
[Token(Token = "0x2000034")]
[ExecuteInEditMode]
public class SpActionToHardcoded : SpAction, SpUnityHelpers.Util.SpUnityEditorUpdate
{
	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public MeshParticleSystem ParticleSystem;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float maxDirectional;

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xA646AC", Offset = "0xA646AC", VA = "0xA646AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xA64774", Offset = "0xA64774", VA = "0xA64774")]
	private new void OnEnable()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xA647A0", Offset = "0xA647A0", VA = "0xA647A0")]
	private new void OnDisable()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xA647AC", Offset = "0xA647AC", VA = "0xA647AC", Slot = "5")]
	private void SpUnityHelpers.Util.SpUnityEditorUpdate.EditorUpdate()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xA647B0", Offset = "0xA647B0", VA = "0xA647B0")]
	public SpActionToHardcoded()
	{
	}
}
[Token(Token = "0x2000035")]
[ExecuteInEditMode]
public class SpActionToMaterialProperty : SpAction, SpUnityHelpers.Util.SpUnityEditorUpdate
{
	[Token(Token = "0x2000144")]
	public enum Style
	{
		[Token(Token = "0x4000799")]
		Value,
		[Token(Token = "0x400079A")]
		CreateScaledTime
	}

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string MaterialProperty;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float MaterialProperty0;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float MaterialProperty1;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Material> Materials;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Style ProcessStyle;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float _scaledTime;

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xA647BC", Offset = "0xA647BC", VA = "0xA647BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xA64AA0", Offset = "0xA64AA0", VA = "0xA64AA0")]
	private new void OnEnable()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xA64ACC", Offset = "0xA64ACC", VA = "0xA64ACC")]
	private new void OnDisable()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xA64AD8", Offset = "0xA64AD8", VA = "0xA64AD8", Slot = "5")]
	private void SpUnityHelpers.Util.SpUnityEditorUpdate.EditorUpdate()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xA64ADC", Offset = "0xA64ADC", VA = "0xA64ADC")]
	public SpActionToMaterialProperty()
	{
	}
}
[Token(Token = "0x2000036")]
[ExecuteInEditMode]
public class SpActionToTransform : SpAction, SpUnityHelpers.Util.SpUnityEditorUpdate
{
	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7796F8", Offset = "0x7796F8")]
	public GameObject TransformOff;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject TransformOn;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject TargetOverride;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77970C", Offset = "0x77970C")]
	public GameObject ActivateByValue;

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xA64B60", Offset = "0xA64B60", VA = "0xA64B60")]
	private void Update()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xA64FD8", Offset = "0xA64FD8", VA = "0xA64FD8")]
	private new void OnEnable()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xA65004", Offset = "0xA65004", VA = "0xA65004")]
	private new void OnDisable()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xA65010", Offset = "0xA65010", VA = "0xA65010", Slot = "5")]
	private void SpUnityHelpers.Util.SpUnityEditorUpdate.EditorUpdate()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xA65014", Offset = "0xA65014", VA = "0xA65014")]
	public SpActionToTransform()
	{
	}
}
[Token(Token = "0x2000037")]
public class SpBillboard : SpMeshStack, SpMeshStack.IMeshGenerator
{
	[Token(Token = "0x2000145")]
	public struct ArgsData
	{
		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Width;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Rect UVRect;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector2 Handle;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Quality;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool UseColor;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color Color;
	}

	[Token(Token = "0x2000146")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778AFC", Offset = "0x778AFC")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rect r;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 Handle;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float scaleX;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float scaleY;

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xA6552C", Offset = "0xA6552C", VA = "0xA6552C")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xA65708", Offset = "0xA65708", VA = "0xA65708")]
		internal Vector2 <Process>b__0(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xA657B0", Offset = "0xA657B0", VA = "0xA657B0")]
		internal Vector3 <Process>b__1(Vector3 v)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float Width;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private CheckForUpdate<float> WidthT;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Rect UVRect;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private CheckForUpdate<Rect> UVRectT;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector2 Handle;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private CheckForUpdate<Vector2> HandleT;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int Quality;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private CheckForUpdate<int> QualityT;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool UseColor;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private CheckForUpdate<bool> UseColorT;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Color Color;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private CheckForUpdate<Color> ColorT;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SpGCache.RegisteredProcess<MeshItem, ArgsData> process;

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xA65018", Offset = "0xA65018", VA = "0xA65018", Slot = "4")]
	private bool SpMeshStack.IMeshGenerator.CheckForChange(GameObject meshStack)
	{
		return default(bool);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xA65110", Offset = "0xA65110", VA = "0xA65110", Slot = "5")]
	private SpGCache.Job SpMeshStack.IMeshGenerator.GetJob(GameObject meshStack)
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xA651D8", Offset = "0xA651D8", VA = "0xA651D8")]
	public static MeshItem Process(ref ArgsData d, out SpGCache.ProcessMetrics outMetrics)
	{
		return null;
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xA65534", Offset = "0xA65534", VA = "0xA65534")]
	public SpBillboard()
	{
	}
}
[Token(Token = "0x2000038")]
public class SpDome : SpMeshStack, SpMeshStack.IMeshGenerator
{
	[Token(Token = "0x2000147")]
	public struct ArgsData
	{
		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int QualityW;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int QualityH;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Distance;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float WidthInDegrees;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HeightInDegrees;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool Ground;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float GroundDistance;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float GroundFade;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ShiftCenterPoint;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ShiftHorizon;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ShiftHorizonUV;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float WarpY;
	}

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float Quality;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private CheckForUpdate<float> QualityT;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float Distance;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CheckForUpdate<float> DistanceT;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779720", Offset = "0x779720")]
	public float WidthInDegrees;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private CheckForUpdate<float> WidthInDegreesT;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77973C", Offset = "0x77973C")]
	public float HeightInDegrees;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private CheckForUpdate<float> HeightInDegreesT;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool Ground;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private CheckForUpdate<bool> GroundT;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float GroundDistance;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private CheckForUpdate<float> GroundDistanceT;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float GroundFade;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private CheckForUpdate<float> GroundFadeT;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779758", Offset = "0x779758")]
	public float ShiftCenterPoint;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private CheckForUpdate<float> ShiftCenterPointT;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779778", Offset = "0x779778")]
	public float ShiftHorizon;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private CheckForUpdate<float> ShiftHorizonT;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779798", Offset = "0x779798")]
	public float ShiftHorizonUV;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private CheckForUpdate<float> ShiftHorizonUVT;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7797B8", Offset = "0x7797B8")]
	public float WarpY;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private CheckForUpdate<float> WarpYT;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SpGCache.RegisteredProcess<MeshItem, ArgsData> process;

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xF69ED8", Offset = "0xF69ED8", VA = "0xF69ED8", Slot = "4")]
	private bool SpMeshStack.IMeshGenerator.CheckForChange(GameObject meshStack)
	{
		return default(bool);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xF69EE0", Offset = "0xF69EE0", VA = "0xF69EE0", Slot = "5")]
	private SpGCache.Job SpMeshStack.IMeshGenerator.GetJob(GameObject meshStack)
	{
		return null;
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xF6A054", Offset = "0xF6A054", VA = "0xF6A054")]
	public static MeshItem Process(ref ArgsData d, out SpGCache.ProcessMetrics outMetrics)
	{
		return null;
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xF6B488", Offset = "0xF6B488", VA = "0xF6B488")]
	public SpDome()
	{
	}
}
[Token(Token = "0x2000039")]
public class SpGCache
{
	[Token(Token = "0x2000148")]
	public interface IProcess
	{
		[Token(Token = "0x60008A3")]
		object Process(ImmutableStruct args, JobSpecInput[] inputs, out ProcessMetrics outMetrics);

		[Token(Token = "0x60008A4")]
		string GetName();
	}

	[Token(Token = "0x2000149")]
	public struct JobSpecInput
	{
		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int NameId;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Job Source;
	}

	[Token(Token = "0x200014A")]
	public struct ImmutableStruct : IEquatable<ImmutableStruct>
	{
		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly object Data;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly int QuickHash;

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xF6B97C", Offset = "0xF6B97C", VA = "0xF6B97C")]
		public ImmutableStruct(object data)
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xF6D478", Offset = "0xF6D478", VA = "0xF6D478", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xF6D480", Offset = "0xF6D480", VA = "0xF6D480", Slot = "4")]
		public bool Equals(ImmutableStruct other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xF6D4B4", Offset = "0xF6D4B4", VA = "0xF6D4B4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200014B")]
	public class JobSpec
	{
		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int QuickHash;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly int ProcessFuncId;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly JobSpecInput[] Inputs;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly ImmutableStruct Args;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int RefCount;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int RefCountUsedAsInput;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public object CachedResult;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IProcess ProcessFunc;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ProcessMetrics Metrics;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int LastRequestTick;

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xF6C6A4", Offset = "0xF6C6A4", VA = "0xF6C6A4")]
		public JobSpec(int _ProcessFuncId, ImmutableStruct _Args, JobSpecInput[] _Inputs)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xF6B7A8", Offset = "0xF6B7A8", VA = "0xF6B7A8")]
		public JobSpec(object result, int hash)
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xF6D638", Offset = "0xF6D638", VA = "0xF6D638", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xF6D640", Offset = "0xF6D640", VA = "0xF6D640", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xF6D6D0", Offset = "0xF6D6D0", VA = "0xF6D6D0")]
		public bool Equals(JobSpec obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xF6D07C", Offset = "0xF6D07C", VA = "0xF6D07C")]
		public void MarkAsDeleted()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xF6CB38", Offset = "0xF6CB38", VA = "0xF6CB38")]
		public bool WasDeleted()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200014C")]
	public class Job
	{
		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public JobSpec Spec;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpGCache _context;

		[Token(Token = "0x17000044")]
		public SpGCache Context
		{
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0xF6D584", Offset = "0xF6D584", VA = "0xF6D584")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xF6B884", Offset = "0xF6B884", VA = "0xF6B884")]
		public Job(JobSpec spec, SpGCache context)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xF6D564", Offset = "0xF6D564", VA = "0xF6D564")]
		public object Request()
		{
			return null;
		}

		[Token(Token = "0x60008B2")]
		public T Request<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xF6D58C", Offset = "0xF6D58C", VA = "0xF6D58C", Slot = "1")]
		~Job()
		{
		}
	}

	[Token(Token = "0x200014D")]
	public struct ProcessMetrics
	{
		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int ByteSize;

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xF6D7C4", Offset = "0xF6D7C4", VA = "0xF6D7C4")]
		public ProcessMetrics(int byteSize)
		{
		}
	}

	[Token(Token = "0x200014E")]
	public class RegisteredProcessBase
	{
		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected int JobFuncId;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string Name;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected SpGCache Context;

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xF6D7CC", Offset = "0xF6D7CC", VA = "0xF6D7CC")]
		public void Init(SpGCache context, string name, int jobFuncId)
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xF6D7D8", Offset = "0xF6D7D8", VA = "0xF6D7D8")]
		public RegisteredProcessBase()
		{
		}
	}

	[Token(Token = "0x200014F")]
	public class RegisteredProcess<returnT, argsT> : RegisteredProcessBase, IProcess where argsT : struct
	{
		[Token(Token = "0x2000244")]
		public delegate returnT TypedFunc(ref argsT args, out ProcessMetrics outMetrics);

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TypedFunc ProcessFunc;

		[Token(Token = "0x60008B8")]
		public string GetName()
		{
			return null;
		}

		[Token(Token = "0x60008B9")]
		public returnT Run(ref argsT args)
		{
			return (returnT)null;
		}

		[Token(Token = "0x60008BA")]
		public Job CreateJob(ref argsT args)
		{
			return null;
		}

		[Token(Token = "0x60008BB")]
		public object Process(ImmutableStruct args, JobSpecInput[] inputs, out ProcessMetrics outMetrics)
		{
			return null;
		}

		[Token(Token = "0x60008BC")]
		public RegisteredProcess()
		{
		}
	}

	[Token(Token = "0x2000150")]
	public class RegisteredProcess<returnT, argsT, inputT> : RegisteredProcessBase, IProcess where argsT : struct
	{
		[Token(Token = "0x2000245")]
		public delegate returnT TypedFunc(ref argsT args, inputT input, out ProcessMetrics outMetrics);

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TypedFunc ProcessFunc;

		[Token(Token = "0x60008BD")]
		public string GetName()
		{
			return null;
		}

		[Token(Token = "0x60008BE")]
		public returnT Run(ref argsT args, inputT input)
		{
			return (returnT)null;
		}

		[Token(Token = "0x60008BF")]
		public Job CreateJob(ref argsT args, inputT input)
		{
			return null;
		}

		[Token(Token = "0x60008C0")]
		public Job CreateJob(ref argsT args, Job input)
		{
			return null;
		}

		[Token(Token = "0x60008C1")]
		public Job CreateJob(ImmutableStruct args, Job input)
		{
			return null;
		}

		[Token(Token = "0x60008C2")]
		public object Process(ImmutableStruct args, JobSpecInput[] inputs, out ProcessMetrics outMetrics)
		{
			return null;
		}

		[Token(Token = "0x60008C3")]
		public RegisteredProcess()
		{
		}
	}

	[Token(Token = "0x2000151")]
	private class processFuncForClientInstance : IProcess
	{
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xF6D7E0", Offset = "0xF6D7E0", VA = "0xF6D7E0", Slot = "4")]
		public object Process(ImmutableStruct args, JobSpecInput[] inputs, out ProcessMetrics outMetrics)
		{
			return null;
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xF6D7EC", Offset = "0xF6D7EC", VA = "0xF6D7EC", Slot = "5")]
		public string GetName()
		{
			return null;
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xF6D3D8", Offset = "0xF6D3D8", VA = "0xF6D3D8")]
		public processFuncForClientInstance()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000152")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778B0C", Offset = "0x778B0C")]
	private sealed class <>c
	{
		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<JobSpec> <>9__29_0;

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xF6D444", Offset = "0xF6D444", VA = "0xF6D444")]
		public <>c()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xF6D44C", Offset = "0xF6D44C", VA = "0xF6D44C")]
		internal int <CorePruneCache>b__29_0(JobSpec a, JobSpec b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool LoggingEnabled;

	[Token(Token = "0x4000170")]
	private const int CacheSizeInBytes = 500000000;

	[Token(Token = "0x4000171")]
	private const int CacheMaxSpecs = 2000;

	[Token(Token = "0x4000172")]
	private const int CLIENT_INSTANCE_REF = -666;

	[Token(Token = "0x4000173")]
	private const int MARKED_AS_DELETED = -6666;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static JobSpecInput[] _zeroInput;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IProcess _processFuncForClientInstance;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int _prunedCache;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int _prunedSpecs;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<JobSpec, JobSpec> _cache;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int CurrentTick;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int CurrentCacheSizeInBytes;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<string, int> nameToJobFunc;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<IProcess> ProcessLibrary;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static SpGCache _Instance;

	[Token(Token = "0x17000005")]
	public static SpGCache Instance
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0xF6B620", Offset = "0xF6B620", VA = "0xF6B620")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000110")]
	public static ImmutableStruct MakeImmutable<T>(ref T data) where T : struct
	{
		return default(ImmutableStruct);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xF6B6E0", Offset = "0xF6B6E0", VA = "0xF6B6E0")]
	public Job CreateFromInstanceNoInterning(object result)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xF6B8D0", Offset = "0xF6B8D0", VA = "0xF6B8D0")]
	public Job CreateFromInstance(object result)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	public static T RequestTypedInput<T>(JobSpecInput inp, string DebugName)
	{
		return (T)null;
	}

	[Token(Token = "0x6000114")]
	public RegisteredProcess<returnT, argsT, inputT> RegisterProcess<returnT, argsT, inputT>(string name, RegisteredProcess<returnT, argsT, inputT>.TypedFunc f) where argsT : struct
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	public RegisteredProcess<returnT, argsT> RegisterProcess<returnT, argsT>(string name, RegisteredProcess<returnT, argsT>.TypedFunc f) where argsT : struct
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xF6C154", Offset = "0xF6C154", VA = "0xF6C154")]
	public Job CoreCreateJob(int jobFuncId, ImmutableStruct args, Job[] inputs)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xF6C39C", Offset = "0xF6C39C", VA = "0xF6C39C")]
	private void AdjustUsedRefCounts(JobSpecInput[] inputs, int diff)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xF6B9BC", Offset = "0xF6B9BC", VA = "0xF6B9BC")]
	public Job CoreCreateJob(int jobFuncId, ImmutableStruct args, [Optional] JobSpecInput[] inputs)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xF6C7D4", Offset = "0xF6C7D4", VA = "0xF6C7D4")]
	private object CoreRequest(JobSpec spec)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xF6CB4C", Offset = "0xF6CB4C", VA = "0xF6CB4C")]
	private void CorePruneCache()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xF6CFB8", Offset = "0xF6CFB8", VA = "0xF6CFB8")]
	private void CoreJobSpecFreeCachedResult(JobSpec spec)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xF6CFF8", Offset = "0xF6CFF8", VA = "0xF6CFF8")]
	private void CoreJobSpecRemoveInterning(JobSpec spec)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xF6C554", Offset = "0xF6C554", VA = "0xF6C554")]
	private void CoreValidateLifeSpan(JobSpec spec)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xF6D088", Offset = "0xF6D088", VA = "0xF6D088")]
	public int CoreNameToJobFunc(string name)
	{
		return default(int);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xF6D110", Offset = "0xF6D110", VA = "0xF6D110")]
	public int CoreRegisterJobFunc(string name, IProcess f)
	{
		return default(int);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xF6D24C", Offset = "0xF6D24C", VA = "0xF6D24C")]
	public SpGCache()
	{
	}
}
[Token(Token = "0x200003A")]
public static class GCache
{
	[Token(Token = "0x2000153")]
	public struct Job<ReturnT>
	{
		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SpGCache.Job job;

		[Token(Token = "0x60008CA")]
		public Job(SpGCache.Job _job)
		{
		}

		[Token(Token = "0x60008CB")]
		public ReturnT Run()
		{
			return (ReturnT)null;
		}
	}

	[Token(Token = "0x2000154")]
	public class FloatTensor
	{
		[Token(Token = "0x2000246")]
		public enum TransposePair
		{
			[Token(Token = "0x4000BE5")]
			None,
			[Token(Token = "0x4000BE6")]
			XY,
			[Token(Token = "0x4000BE7")]
			XZ,
			[Token(Token = "0x4000BE8")]
			YZ
		}

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int nx;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int ny;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int nz;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int strideX;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int strideY;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int strideZ;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int dataOffset;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float[] data;

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xABF7E8", Offset = "0xABF7E8", VA = "0xABF7E8")]
		public FloatTensor(int _nx, int _ny = 1, int _nz = 1)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xAC0768", Offset = "0xAC0768", VA = "0xAC0768")]
		public float safeGet(int x, int y)
		{
			return default(float);
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xAC06F0", Offset = "0xAC06F0", VA = "0xAC06F0")]
		public FloatTensor NewWithSameShape()
		{
			return null;
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xAC07D8", Offset = "0xAC07D8", VA = "0xAC07D8")]
		private static void swap(ref int a, ref int b)
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xAC0468", Offset = "0xAC0468", VA = "0xAC0468")]
		public FloatTensor RearrangeTool(TransposePair trans)
		{
			return null;
		}
	}

	[Token(Token = "0x2000155")]
	public struct ImageLoadArg
	{
		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Path;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool FlipY;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public bool OnlyAlpha;

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xABF514", Offset = "0xABF514", VA = "0xABF514")]
		public ImageLoadArg(string path, bool flipY = false, bool onlyAlpha = false)
		{
		}
	}

	[Token(Token = "0x2000156")]
	public struct DownSampleArgs
	{
		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float a;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float b;

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xABF9F0", Offset = "0xABF9F0", VA = "0xABF9F0")]
		public DownSampleArgs(float _a, float _b)
		{
		}
	}

	[Token(Token = "0x2000157")]
	public struct NoArgs : IEquatable<NoArgs>
	{
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xAC0C0C", Offset = "0xAC0C0C", VA = "0xAC0C0C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xAC0C18", Offset = "0xAC0C18", VA = "0xAC0C18", Slot = "4")]
		public bool Equals(NoArgs other)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000158")]
	public struct Args1<T> : IEquatable<Args1<T>>
	{
		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T a1;

		[Token(Token = "0x60008D5")]
		public Args1(T v)
		{
		}

		[Token(Token = "0x60008D6")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008D7")]
		public bool Equals(Args1<T> other)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000159")]
	public struct Args2<T1, T2> : IEquatable<Args2<T1, T2>>
	{
		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T1 a1;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T2 a2;

		[Token(Token = "0x60008D8")]
		public Args2(T1 v1, T2 v2)
		{
		}

		[Token(Token = "0x60008D9")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008DA")]
		public bool Equals(Args2<T1, T2> other)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200015A")]
	public struct MetaData<T>
	{
		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T data;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int sizeInBytes;

		[Token(Token = "0x60008DB")]
		public MetaData(T _data, int _sizeInBytes)
		{
		}
	}

	[Token(Token = "0x200015B")]
	public class LambdaFunc : SpGCache.IProcess
	{
		[Token(Token = "0x2000247")]
		public delegate object processDelegate(SpGCache.ImmutableStruct args, SpGCache.JobSpecInput[] inputs, out SpGCache.ProcessMetrics outMetrics);

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string _name;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private processDelegate _process;

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xAC07EC", Offset = "0xAC07EC", VA = "0xAC07EC", Slot = "4")]
		public object Process(SpGCache.ImmutableStruct args, SpGCache.JobSpecInput[] inputs, out SpGCache.ProcessMetrics outMetrics)
		{
			return null;
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xAC0ADC", Offset = "0xAC0ADC", VA = "0xAC0ADC", Slot = "5")]
		public string GetName()
		{
			return null;
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xAC0AE4", Offset = "0xAC0AE4", VA = "0xAC0AE4")]
		public LambdaFunc(string name, processDelegate process)
		{
		}
	}

	[Token(Token = "0x200015C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778B1C", Offset = "0x778B1C")]
	private sealed class <>c__DisplayClass17_0<inT, outT>
	{
		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<inT, MetaData<outT>> f;

		[Token(Token = "0x60008DF")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60008E0")]
		internal outT <Inline>b__0(ref NoArgs args, inT srcT, out SpGCache.ProcessMetrics outMetrics)
		{
			return (outT)null;
		}
	}

	[Token(Token = "0x200015D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778B2C", Offset = "0x778B2C")]
	private sealed class <>c__DisplayClass18_0<inT, outT, A1>
	{
		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<A1, inT, MetaData<outT>> f;

		[Token(Token = "0x60008E1")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60008E2")]
		internal outT <Inline>b__0(ref Args1<A1> args, inT srcT, out SpGCache.ProcessMetrics outMetrics)
		{
			return (outT)null;
		}
	}

	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778B3C", Offset = "0x778B3C")]
	private sealed class <>c__DisplayClass19_0<inT, outT, A1, A2>
	{
		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<A1, A2, inT, MetaData<outT>> f;

		[Token(Token = "0x60008E3")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60008E4")]
		internal outT <Inline>b__0(ref Args2<A1, A2> args, inT srcT, out SpGCache.ProcessMetrics outMetrics)
		{
			return (outT)null;
		}
	}

	[Token(Token = "0x200015F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778B4C", Offset = "0x778B4C")]
	private sealed class <>c__DisplayClass21_0<inT, inT2, outT>
	{
		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string name;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<inT, inT2, MetaData<outT>> f;

		[Token(Token = "0x60008E5")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60008E6")]
		internal object <InlineCombine>b__0(SpGCache.ImmutableStruct args, SpGCache.JobSpecInput[] inputs, out SpGCache.ProcessMetrics outMetrics)
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000160")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778B5C", Offset = "0x778B5C")]
	private sealed class <>c
	{
		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<float, Vector4, SpPixels.RawImageRGBA, MetaData<FloatTensor>> <>9__22_0;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<Matrix4x4, List<Vector3>, MetaData<List<Vector3>>> <>9__24_0;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<int, FloatTensor, MetaData<FloatTensor>> <>9__25_0;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<int, float, FloatTensor, MetaData<FloatTensor>> <>9__26_0;

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xABFFC8", Offset = "0xABFFC8", VA = "0xABFFC8")]
		public <>c()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xABFFD0", Offset = "0xABFFD0", VA = "0xABFFD0")]
		internal MetaData<FloatTensor> <ToFloatTensor>b__22_0(float preMul, Vector4 channelMix, SpPixels.RawImageRGBA img)
		{
			return default(MetaData<FloatTensor>);
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xAC026C", Offset = "0xAC026C", VA = "0xAC026C")]
		internal MetaData<List<Vector3>> <Transform>b__24_0(Matrix4x4 _mat, List<Vector3> inL)
		{
			return default(MetaData<List<Vector3>>);
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xAC03BC", Offset = "0xAC03BC", VA = "0xAC03BC")]
		internal MetaData<FloatTensor> <Transpose>b__25_0(int _tp, FloatTensor inT)
		{
			return default(MetaData<FloatTensor>);
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xAC0620", Offset = "0xAC0620", VA = "0xAC0620")]
		internal MetaData<FloatTensor> <SobelFilter>b__26_0(int _offset, float _mul, FloatTensor inT)
		{
			return default(MetaData<FloatTensor>);
		}
	}

	[Token(Token = "0x2000161")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778B6C", Offset = "0x778B6C")]
	private sealed class <>c__DisplayClass23_0<T>
	{
		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int sizePerItem;

		[Token(Token = "0x60008ED")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60008EE")]
		internal MetaData<List<T>> <Concat>b__0(List<T> a, List<T> b)
		{
			return default(MetaData<List<T>>);
		}
	}

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SpGCache.RegisteredProcess<SpPixels.RawImageRGBA, ImageLoadArg> _ImageLoad;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static SpGCache.RegisteredProcess<FloatTensor, DownSampleArgs, FloatTensor> _DownSample;

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xABF144", Offset = "0xABF144", VA = "0xABF144")]
	public static Color32[] GetImageData(string path, out int width, out int height)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xABF350", Offset = "0xABF350", VA = "0xABF350")]
	private static SpPixels.RawImageRGBA _GetImageLoadProcess(ref ImageLoadArg arg, out SpGCache.ProcessMetrics outMetrics)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xABF1FC", Offset = "0xABF1FC", VA = "0xABF1FC")]
	public static SpGCache.RegisteredProcess<SpPixels.RawImageRGBA, ImageLoadArg> ImageLoadProc()
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xABF468", Offset = "0xABF468", VA = "0xABF468")]
	public static Job<SpPixels.RawImageRGBA> ImageLoad(string path, bool flipY = false, bool onlyAlpha = false)
	{
		return default(Job<SpPixels.RawImageRGBA>);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xABF52C", Offset = "0xABF52C", VA = "0xABF52C")]
	public static FloatTensor DownSampleProcess(ref DownSampleArgs args, FloatTensor srcT, out SpGCache.ProcessMetrics outMetrics)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xABF880", Offset = "0xABF880", VA = "0xABF880")]
	public static Job<FloatTensor> DownSample(this Job<FloatTensor> inp, float a = 0.5f, float b = 0.25f)
	{
		return default(Job<FloatTensor>);
	}

	[Token(Token = "0x6000129")]
	public static MetaData<T> WithMetaData<T>(T _data, int _sizeInBytes)
	{
		return default(MetaData<T>);
	}

	[Token(Token = "0x600012A")]
	public static Job<outT> Inline<inT, outT>(this Job<inT> inp, string name, Func<inT, MetaData<outT>> f)
	{
		return default(Job<outT>);
	}

	[Token(Token = "0x600012B")]
	public static Job<outT> Inline<inT, outT, A1>(this Job<inT> inp, string name, A1 a1, Func<A1, inT, MetaData<outT>> f)
	{
		return default(Job<outT>);
	}

	[Token(Token = "0x600012C")]
	public static Job<outT> Inline<inT, outT, A1, A2>(this Job<inT> inp, string name, A1 a1, A2 a2, Func<A1, A2, inT, MetaData<outT>> f)
	{
		return default(Job<outT>);
	}

	[Token(Token = "0x600012D")]
	public static Job<outT> InlineCombine<inT, inT2, outT>(this Job<inT> inp, Job<inT2> inp2, string name, Func<inT, inT2, MetaData<outT>> f)
	{
		return default(Job<outT>);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xABF9F8", Offset = "0xABF9F8", VA = "0xABF9F8")]
	public static Job<FloatTensor> ToFloatTensor(this Job<SpPixels.RawImageRGBA> inp, float preMul_, Vector4 channelMix_)
	{
		return default(Job<FloatTensor>);
	}

	[Token(Token = "0x600012F")]
	public static Job<List<T>> Concat<T>(this Job<List<T>> inp, Job<List<T>> inp2, int sizePerItem)
	{
		return default(Job<List<T>>);
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xABFB5C", Offset = "0xABFB5C", VA = "0xABFB5C")]
	public static Job<List<Vector3>> Transform(this Job<List<Vector3>> inp, Matrix4x4 m)
	{
		return default(Job<List<Vector3>>);
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xABFCF8", Offset = "0xABFCF8", VA = "0xABFCF8")]
	public static Job<FloatTensor> Transpose(this Job<FloatTensor> inp, FloatTensor.TransposePair tp = FloatTensor.TransposePair.XY)
	{
		return default(Job<FloatTensor>);
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xABFE24", Offset = "0xABFE24", VA = "0xABFE24")]
	public static Job<FloatTensor> SobelFilter(this Job<FloatTensor> inp, int offset = 1, float mul = 1f)
	{
		return default(Job<FloatTensor>);
	}
}
[Token(Token = "0x200003B")]
public class SpGenMesh : SpMeshStack, SpMeshStack.IMeshGenerator
{
	[Token(Token = "0x2000162")]
	public enum MeshPreset
	{
		[Token(Token = "0x40007EA")]
		SphereWithBoxDents,
		[Token(Token = "0x40007EB")]
		RoundedBox,
		[Token(Token = "0x40007EC")]
		RoundedBox2
	}

	[Token(Token = "0x2000163")]
	public struct ArgsData
	{
		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MeshPreset Preset;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Option;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 Size;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool Flip;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rect UVRect;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int Quality;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool UseColor;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color Color;
	}

	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778B7C", Offset = "0x778B7C")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rect r;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 size;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float option;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Func<Vector3, float> <>9__1;

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xF6E560", Offset = "0xF6E560", VA = "0xF6E560")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xF6E740", Offset = "0xF6E740", VA = "0xF6E740")]
		internal Vector2 <Process>b__0(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0xF6E7E8", Offset = "0xF6E7E8", VA = "0xF6E7E8")]
		internal float <Process>b__1(Vector3 v)
		{
			return default(float);
		}
	}

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshPreset Preset;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private CheckForUpdate<MeshPreset> PresetT;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7797D0", Offset = "0x7797D0")]
	public float Option;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CheckForUpdate<float> OptionT;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 Size;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private CheckForUpdate<Vector3> SizeT;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool Flip;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	private CheckForUpdate<bool> FlipT;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int Quality;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private CheckForUpdate<int> QualityT;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public Rect UVRect;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private CheckForUpdate<Rect> UVRectT;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool UseColor;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	private CheckForUpdate<bool> UseColorT;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public Color Color;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private CheckForUpdate<Color> ColorT;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SpGCache.RegisteredProcess<MeshItem, ArgsData> process;

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xF6D834", Offset = "0xF6D834", VA = "0xF6D834", Slot = "4")]
	private bool SpMeshStack.IMeshGenerator.CheckForChange(GameObject meshStack)
	{
		return default(bool);
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xF6D964", Offset = "0xF6D964", VA = "0xF6D964", Slot = "5")]
	private SpGCache.Job SpMeshStack.IMeshGenerator.GetJob(GameObject meshStack)
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xF6DA48", Offset = "0xF6DA48", VA = "0xF6DA48")]
	public static float gencos(float x)
	{
		return default(float);
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xF6DAC0", Offset = "0xF6DAC0", VA = "0xF6DAC0")]
	public static float cosToRect(float x, float a)
	{
		return default(float);
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xF6DBC0", Offset = "0xF6DBC0", VA = "0xF6DBC0")]
	public static Vector2 roundedRect(float x, float a)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xF6DC84", Offset = "0xF6DC84", VA = "0xF6DC84")]
	public static Vector2 halfRoundedRect(float x, float a)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xF6DD48", Offset = "0xF6DD48", VA = "0xF6DD48")]
	public static MeshItem Process(ref ArgsData d, out SpGCache.ProcessMetrics outMetrics)
	{
		return null;
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xF6E568", Offset = "0xF6E568", VA = "0xF6E568")]
	public SpGenMesh()
	{
	}
}
[Token(Token = "0x200003C")]
public class SpMesh
{
	[Token(Token = "0x2000165")]
	private class CVertexWeight
	{
		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 localPosition;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float weight;

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0xF6EF38", Offset = "0xF6EF38", VA = "0xF6EF38")]
		public CVertexWeight(int i, Vector3 p, float w)
		{
		}
	}

	[Token(Token = "0x2000166")]
	private class CWeightList
	{
		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ArrayList weights;

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0xF6EECC", Offset = "0xF6EECC", VA = "0xF6EECC")]
		public CWeightList()
		{
		}
	}

	[Token(Token = "0x2000167")]
	public class MeshBuilder
	{
		[Token(Token = "0x2000248")]
		private struct TessellateOptions
		{
			[Token(Token = "0x4000BE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<uint, int> SplitLines;

			[Token(Token = "0x4000BEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float StopSizeSqr;

			[Token(Token = "0x4000BEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int Recursions;

			[Token(Token = "0x4000BEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float Falloff;

			[Token(Token = "0x4000BED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool UseCurvature;

			[Token(Token = "0x4000BEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Matrix4x4 Transform;
		}

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int tEnd;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int vEnd;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3[] pos;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3[] norm;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] col;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2[] uvs;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2[] uvs2;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2[] uvs3;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int[] tris;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool[] faceRemove;

		[Token(Token = "0x17000045")]
		public int vertexCount
		{
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0xF72CB0", Offset = "0xF72CB0", VA = "0xF72CB0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000046")]
		public int faceCount
		{
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0xF72CB8", Offset = "0xF72CB8", VA = "0xF72CB8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0xF72B1C", Offset = "0xF72B1C", VA = "0xF72B1C")]
		public Vector3 GetPos(int i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0xF72B64", Offset = "0xF72B64", VA = "0xF72B64")]
		public Vector3 GetNormal(int i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0xF72BAC", Offset = "0xF72BAC", VA = "0xF72BAC")]
		public Color GetColor(int i)
		{
			return default(Color);
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xF72BF0", Offset = "0xF72BF0", VA = "0xF72BF0")]
		public Vector2 GetUv(int i)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xF72C30", Offset = "0xF72C30", VA = "0xF72C30")]
		public Vector2 GetUv2(int i)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xF72C70", Offset = "0xF72C70", VA = "0xF72C70")]
		public Vector2 GetUv3(int i)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xF72CC0", Offset = "0xF72CC0", VA = "0xF72CC0")]
		public void Clear()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xF72CC8", Offset = "0xF72CC8", VA = "0xF72CC8")]
		public int AddVertex()
		{
			return default(int);
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xF72E34", Offset = "0xF72E34", VA = "0xF72E34")]
		public int AddVertex(MeshBuilder other, int id)
		{
			return default(int);
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xF73284", Offset = "0xF73284", VA = "0xF73284")]
		public int AddTriangle(int v1, int v2, int v3)
		{
			return default(int);
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xF733E0", Offset = "0xF733E0", VA = "0xF733E0")]
		public void RemoveFace(int i)
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xF72FC4", Offset = "0xF72FC4", VA = "0xF72FC4")]
		public int VertexCopy(int dest, int src, [Optional] MeshBuilder m)
		{
			return default(int);
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xF73480", Offset = "0xF73480", VA = "0xF73480")]
		public int AverageVertexWithCurvature(int dest, int i1, int i2, bool useCurvature)
		{
			return default(int);
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xF7375C", Offset = "0xF7375C", VA = "0xF7375C")]
		public int InterpolateVertex(int dest, int i1, int i2, float t)
		{
			return default(int);
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xF73B18", Offset = "0xF73B18", VA = "0xF73B18")]
		public void FromUnityMesh(Mesh m)
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xF743F8", Offset = "0xF743F8", VA = "0xF743F8")]
		public void RemoveUnusedVerticesAndRemapIndices()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0xF74764", Offset = "0xF74764", VA = "0xF74764")]
		public void CleanTriangleBufferFromRemovedFaces()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0xF74874", Offset = "0xF74874", VA = "0xF74874")]
		public Mesh ToUnityMesh([Optional] Mesh m, bool tryToRemoveUnusedVertices = true)
		{
			return null;
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0xF74AAC", Offset = "0xF74AAC", VA = "0xF74AAC")]
		public int AddQuad(int i1, int i2, int i3, int i4)
		{
			return default(int);
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0xF74C94", Offset = "0xF74C94", VA = "0xF74C94")]
		private uint PackAndSort2Ints(int i1, int i2)
		{
			return default(uint);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xF74CA8", Offset = "0xF74CA8", VA = "0xF74CA8")]
		private void TessellateQuad(int i1, int i2, int i3, int i4, int depth, ref TessellateOptions o)
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xF74EB8", Offset = "0xF74EB8", VA = "0xF74EB8")]
		private bool TessellateTriangle(int i1, int i2, int i3, int depth, ref TessellateOptions o)
		{
			return default(bool);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xF75424", Offset = "0xF75424", VA = "0xF75424")]
		public bool Tessellate(float StopSize, int Recursions, float Falloff, Matrix4x4 Transform, bool UseCurvature = true, int firstFace = 0, int count = -1)
		{
			return default(bool);
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xF755E0", Offset = "0xF755E0", VA = "0xF755E0")]
		private void LineTringleSlicing(int i1, int i2, int i3, float intersec_i1_i2, float intersec_i2_i3)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xF756C4", Offset = "0xF756C4", VA = "0xF756C4")]
		private bool SliceUVByLineSegment(Vector2 l1, Vector2 l2, int i1, int i2, int i3)
		{
			return default(bool);
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xF75ADC", Offset = "0xF75ADC", VA = "0xF75ADC")]
		public bool SliceUVByLineSegment(Vector2 l1, Vector2 l2, int firstFace = 0, int count = -1)
		{
			return default(bool);
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xF75C14", Offset = "0xF75C14", VA = "0xF75C14")]
		private bool Contains(Vector2 p, Rect r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xF75C9C", Offset = "0xF75C9C", VA = "0xF75C9C")]
		private bool TriangleMidPointIsOnPositiveSideOfPlane(Vector3 p1, Vector3 p2, Vector3 p3, Plane p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xF75DA0", Offset = "0xF75DA0", VA = "0xF75DA0")]
		private bool AnyTrianglePointIsOnPositiveSideOfPlane(Vector3 p1, Vector3 p2, Vector3 p3, Plane p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xF75E28", Offset = "0xF75E28", VA = "0xF75E28")]
		private bool AllTrianglePointsAreOnPositiveSideOfPlane(Vector3 p1, Vector3 p2, Vector3 p3, Plane p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xF75EB0", Offset = "0xF75EB0", VA = "0xF75EB0")]
		private bool TriangleIsInsideRect(Vector2 p1, Vector2 p2, Vector2 p3, Rect r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xF75F64", Offset = "0xF75F64", VA = "0xF75F64")]
		public void ApplyUVMatrix(Vector2 scale, Vector2 offset, int uvset = 1)
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xF761FC", Offset = "0xF761FC", VA = "0xF761FC")]
		public MeshBuilder SeparateByPlanes(Plane[] planes, bool cut = false)
		{
			return null;
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xF76548", Offset = "0xF76548", VA = "0xF76548")]
		public MeshBuilder[] SeparateByUV(Rect[] rects, bool cut = true)
		{
			return null;
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xF76540", Offset = "0xF76540", VA = "0xF76540")]
		public MeshBuilder()
		{
		}
	}

	[Token(Token = "0x2000168")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778B8C", Offset = "0x778B8C")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float quality;

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xF70504", Offset = "0xF70504", VA = "0xF70504")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xF72918", Offset = "0xF72918", VA = "0xF72918")]
		internal Vector3Int <IterateSurfacePoints>b__0(Vector3 v)
		{
			return default(Vector3Int);
		}
	}

	[Token(Token = "0x2000169")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778B9C", Offset = "0x778B9C")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float precision;

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xF705C4", Offset = "0xF705C4", VA = "0xF705C4")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xF72A38", Offset = "0xF72A38", VA = "0xF72A38")]
		internal Vector3 <GenerateAALinesFromDecimatedPoints>b__0(Vector3Int vi)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xF6E810", Offset = "0xF6E810", VA = "0xF6E810")]
	private static void InsertPoint(Vector3 v, Vector3 min, Vector3 max, HashSet<Vector3Int> verts, Func<Vector3, Vector3Int> pointToInteger)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xF6E934", Offset = "0xF6E934", VA = "0xF6E934")]
	private static CWeightList[] GetNodeWeights(SkinnedMeshRenderer skinnedMeshRenderer)
	{
		return null;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xF6EF8C", Offset = "0xF6EF8C", VA = "0xF6EF8C")]
	private static void IterateMeshSurfacePoints(HashSet<Vector3Int> outVerts, Mesh srcMesh, Renderer renderer, SkinnedMeshRenderer skinnedMeshRenderer, Matrix4x4 mat, Func<Vector3, Vector3Int> pointToInteger, Vector3 min, Vector3 max, bool usePreciseCut, float quality, int maxPoints, bool skipTransparent)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xF6FFA8", Offset = "0xF6FFA8", VA = "0xF6FFA8")]
	public static HashSet<Vector3Int> IterateSurfacePoints(GameObject root, float precision, [Optional] Func<Vector3, Vector3Int> pointToInteger, [Optional] Func<Renderer, bool> skipCustom, bool skipTransparent = false, int maxPoints = -1)
	{
		return null;
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xF7050C", Offset = "0xF7050C", VA = "0xF7050C")]
	public static List<Vector3> GenerateAALinesFromDecimatedPoints(HashSet<Vector3Int> iv, float precision)
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xF705CC", Offset = "0xF705CC", VA = "0xF705CC")]
	public static List<Vector3> GenerateAALinesFromDecimatedPoints(HashSet<Vector3Int> iv, Func<Vector3Int, Vector3> pointToFloat)
	{
		return null;
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xF70B30", Offset = "0xF70B30", VA = "0xF70B30")]
	public static void WriteLinesToMesh(Mesh dst, List<Vector3> lineData, int lineCount, int sourceOffsetInLines, float expandBound = 0f)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xF713B8", Offset = "0xF713B8", VA = "0xF713B8")]
	public static List<Mesh> GenerateLineMeshes(List<Vector3> lineData)
	{
		return null;
	}

	[Token(Token = "0x6000145")]
	public static T[] SubArray<T>(T[] data, int index, int length)
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xF714F8", Offset = "0xF714F8", VA = "0xF714F8")]
	public static Vector3 GetFaceNormal(Vector3 a, Vector3 b, Vector3 c)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xF71628", Offset = "0xF71628", VA = "0xF71628")]
	public static bool Backface3D(Vector3 viewPoint, Vector3 a, Vector3 b, Vector3 c)
	{
		return default(bool);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xF717A4", Offset = "0xF717A4", VA = "0xF717A4")]
	public static int LineLineIntersects(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, out float intersectionT, out int colinear)
	{
		return default(int);
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xF71870", Offset = "0xF71870", VA = "0xF71870")]
	public static Vector3 Bend3DCoord1Axis(Vector3 v, float amount, int d1, int d2)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xF6A6D0", Offset = "0xF6A6D0", VA = "0xF6A6D0")]
	public static Vector3[] CreateGridPoints(int w, int h, bool quads = true)
	{
		return null;
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xF6A868", Offset = "0xF6A868", VA = "0xF6A868")]
	public static Mesh CreateMeshGrid(int numColumns, int numSegments, Vector3[] pos, Vector2[] uv, bool alternateTesselation = false, bool closed = false, bool duplicateFirstToMakeUniqueEndUvs = false, bool flipFaces = false, bool normalsFromVerts = false, bool useTextureAlpha = false, int discardMapW = -1, int discardMapH = -1, [Optional] float[] discardMap, bool trimSemiTransparent = false)
	{
		return null;
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xF71E84", Offset = "0xF71E84", VA = "0xF71E84")]
	public static Vector3 Bend3DCoord(Vector3 v, float amountX, float amountY)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600014D")]
	private static void Swap<T>(ref T obj1, ref T obj2)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xF72068", Offset = "0xF72068", VA = "0xF72068")]
	private static void JoinOrMerge(Dictionary<int, List<int>> vIdToElement, ref List<int> idList, int index, List<int> curList)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xF72238", Offset = "0xF72238", VA = "0xF72238")]
	private static void CalcTriMeshElements(int[] triIndices, out Dictionary<int, List<int>> VertexIdToElementList, out Dictionary<List<int>, int> ElementVertexListToElementId)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xF726C4", Offset = "0xF726C4", VA = "0xF726C4")]
	public static int CalcTriMeshElements(int[] triIndices, int[] outElementIdPerTriangle, [Optional] List<List<int>> outElementTriIds)
	{
		return default(int);
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xF72910", Offset = "0xF72910", VA = "0xF72910")]
	public SpMesh()
	{
	}
}
[Token(Token = "0x200003D")]
public class SpMeshStack : MonoBehaviour
{
	[Token(Token = "0x200016A")]
	public interface IMeshGenerator
	{
		[Token(Token = "0x600091D")]
		bool CheckForChange(GameObject meshStack);

		[Token(Token = "0x600091E")]
		SpGCache.Job GetJob(GameObject meshStack);
	}

	[Token(Token = "0x200016B")]
	public abstract class MeshProcessor : MonoBehaviour, IComparable<MeshProcessor>
	{
		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Priority;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int CreatedId;

		[Token(Token = "0x600091F")]
		public abstract bool CheckForChange(GameObject meshStack);

		[Token(Token = "0x6000920")]
		public abstract SpGCache.Job GetJob(GameObject meshStack, SpGCache.Job input);

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xF76F50", Offset = "0xF76F50", VA = "0xF76F50", Slot = "4")]
		private int System.IComparable<SpMeshStack.MeshProcessor>.CompareTo(MeshProcessor obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xF76FA0", Offset = "0xF76FA0", VA = "0xF76FA0")]
		protected MeshProcessor()
		{
		}
	}

	[Token(Token = "0x200016C")]
	public class MeshItem
	{
		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh[] UnityMeshes;

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xF76E0C", Offset = "0xF76E0C", VA = "0xF76E0C")]
		public MeshItem(Mesh[] unityMeshes)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xF76E98", Offset = "0xF76E98", VA = "0xF76E98")]
		public MeshItem(Mesh mesh)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xF69EC8", Offset = "0xF69EC8", VA = "0xF69EC8")]
		public MeshItem()
		{
		}
	}

	[Token(Token = "0x200016D")]
	public interface IMeshSupplier
	{
		[Token(Token = "0x6000926")]
		MeshItem Request();
	}

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool DoLog;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mesh MeshInput;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool RecalcBounds;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IMeshSupplier MainSupplier;

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xF6B3A8", Offset = "0xF6B3A8", VA = "0xF6B3A8")]
	public static MeshItem CreateMeshItemAndCalcMetrics(Mesh[] unityMeshes, out SpGCache.ProcessMetrics outMetrics)
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xF76E38", Offset = "0xF76E38", VA = "0xF76E38")]
	public void SetMainInput(MeshItem m)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xF76E3C", Offset = "0xF76E3C", VA = "0xF76E3C")]
	public void SetMainInputSupplier(IMeshSupplier m)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xF6B618", Offset = "0xF6B618", VA = "0xF6B618")]
	public SpMeshStack()
	{
	}
}
[Token(Token = "0x200003E")]
[ExecuteInEditMode]
public class SpMeshStack_Deform : SpMeshStack.MeshProcessor
{
	[Token(Token = "0x200016E")]
	public enum TargetArray
	{
		[Token(Token = "0x400080E")]
		Position,
		[Token(Token = "0x400080F")]
		UV,
		[Token(Token = "0x4000810")]
		UV2,
		[Token(Token = "0x4000811")]
		UV3,
		[Token(Token = "0x4000812")]
		UV4
	}

	[Token(Token = "0x200016F")]
	public struct ArgsData
	{
		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Size;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Falloff;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SCurve;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public bool Decay;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public bool ExtraSoft;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		public bool Invert;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public TargetArray Target;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 DeformCenter;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Matrix4x4 DiffTransform;
	}

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Size;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private CheckForUpdate<float> SizeT;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7797E8", Offset = "0x7797E8")]
	public float Falloff;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CheckForUpdate<float> FalloffT;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool SCurve;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private CheckForUpdate<bool> SCurveT;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	public bool Decay;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private CheckForUpdate<bool> DecayT;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	public bool ExtraSoft;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	private CheckForUpdate<bool> ExtraSoftT;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool Invert;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	private CheckForUpdate<bool> InvertT;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public TargetArray Target;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CheckForUpdate<TargetArray> TargetT;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private CheckForRelativeTransformUpdate TransformT;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private CheckForTransformUpdate ParentT;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SpGCache.RegisteredProcess<SpMeshStack.MeshItem, ArgsData, SpMeshStack.MeshItem> process;

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xF76FA8", Offset = "0xF76FA8", VA = "0xF76FA8", Slot = "5")]
	public override bool CheckForChange(GameObject meshStack)
	{
		return default(bool);
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xF77830", Offset = "0xF77830", VA = "0xF77830")]
	private static float Smoothstep(float a, float b, float x, float smooth)
	{
		return default(float);
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xF77904", Offset = "0xF77904", VA = "0xF77904", Slot = "6")]
	public override SpGCache.Job GetJob(GameObject meshStack, SpGCache.Job input)
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xF77ED8", Offset = "0xF77ED8", VA = "0xF77ED8")]
	public static SpMeshStack.MeshItem Process(ref ArgsData d, SpMeshStack.MeshItem inputItem, out SpGCache.ProcessMetrics outMetrics)
	{
		return null;
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xF78630", Offset = "0xF78630", VA = "0xF78630")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xF7875C", Offset = "0xF7875C", VA = "0xF7875C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xF787F8", Offset = "0xF787F8", VA = "0xF787F8")]
	public SpMeshStack_Deform()
	{
	}
}
[Token(Token = "0x200003F")]
[ExecuteInEditMode]
public class SpMeshStack_Split : MonoBehaviour
{
	[Token(Token = "0x600015F")]
	[Address(RVA = "0xF78AD8", Offset = "0xF78AD8", VA = "0xF78AD8")]
	public SpMeshStack_Split()
	{
	}
}
[Token(Token = "0x2000040")]
[ExecuteInEditMode]
public class SpMeshStack_SplitByUV : MonoBehaviour
{
	[Token(Token = "0x6000160")]
	[Address(RVA = "0xF78AE0", Offset = "0xF78AE0", VA = "0xF78AE0")]
	public SpMeshStack_SplitByUV()
	{
	}
}
[Token(Token = "0x2000041")]
[ExecuteInEditMode]
public class SpMeshStack_Tessellate : SpMeshStack.MeshProcessor
{
	[Token(Token = "0x2000170")]
	public struct ArgsData
	{
		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool Enable;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float StopSize;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int Recursions;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool UseCurvature;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Falloff;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Matrix4x4 Transform;
	}

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool Enable;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private CheckForUpdate<bool> EnableT;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float StopSize;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CheckForUpdate<float> StopSizeT;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float Falloff;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private CheckForUpdate<float> FalloffT;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool UseCurvature;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	private CheckForUpdate<bool> UseCurvatureT;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int Recursions;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private CheckForUpdate<int> RecursionsT;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private CheckForRelativeTransformUpdate TransformT;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SpGCache.RegisteredProcess<SpMeshStack.MeshItem, ArgsData, SpMeshStack.MeshItem> process;

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xF78AE8", Offset = "0xF78AE8", VA = "0xF78AE8", Slot = "5")]
	public override bool CheckForChange(GameObject meshStack)
	{
		return default(bool);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xF78BFC", Offset = "0xF78BFC", VA = "0xF78BFC", Slot = "6")]
	public override SpGCache.Job GetJob(GameObject meshStack, SpGCache.Job input)
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xF78E64", Offset = "0xF78E64", VA = "0xF78E64")]
	public static SpMeshStack.MeshItem Process(ref ArgsData d, SpMeshStack.MeshItem inputItem, out SpGCache.ProcessMetrics outMetrics)
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xF790BC", Offset = "0xF790BC", VA = "0xF790BC")]
	public SpMeshStack_Tessellate()
	{
	}
}
[Token(Token = "0x2000042")]
[ExecuteInEditMode]
public class SpMeshStack_UVProject : SpMeshStack.MeshProcessor
{
	[Token(Token = "0x2000171")]
	public struct ArgsData
	{
		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float FovW;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float FovH;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float ShiftHorizon;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool ClampU;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool ClampV;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public bool Spherical;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Matrix4x4 Transform;
	}

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Fov;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private CheckForUpdate<float> FovT;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float FovWidth;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CheckForUpdate<float> FovWidthT;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float FovHeight;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private CheckForUpdate<float> FovHeightT;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float ShiftHorizon;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CheckForUpdate<float> ShiftHorizonT;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool ClampU;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private CheckForUpdate<bool> ClampUT;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
	public bool ClampV;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private CheckForUpdate<bool> ClampVT;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool Spherical;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
	private CheckForUpdate<bool> SphericalT;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private CheckForRelativeTransformUpdate TransformT;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SpGCache.RegisteredProcess<SpMeshStack.MeshItem, ArgsData, SpMeshStack.MeshItem> process;

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xF7923C", Offset = "0xF7923C", VA = "0xF7923C", Slot = "5")]
	public override bool CheckForChange(GameObject meshStack)
	{
		return default(bool);
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xF79370", Offset = "0xF79370", VA = "0xF79370", Slot = "6")]
	public override SpGCache.Job GetJob(GameObject meshStack, SpGCache.Job input)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xF795F0", Offset = "0xF795F0", VA = "0xF795F0")]
	public static SpMeshStack.MeshItem Process(ref ArgsData d, SpMeshStack.MeshItem inputItem, out SpGCache.ProcessMetrics outMetrics)
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xF79BB8", Offset = "0xF79BB8", VA = "0xF79BB8")]
	public SpMeshStack_UVProject()
	{
	}
}
[Token(Token = "0x2000043")]
[ExecuteInEditMode]
public class SpMeshStack_VertexColor : SpMeshStack.MeshProcessor
{
	[Token(Token = "0x2000172")]
	public struct ArgsData
	{
		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Size;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Falloff;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SCurve;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public bool Decay;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public bool ExtraSoft;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		public bool Invert;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 DeformCenter;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color Color;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float RandomVariationAmount;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float RandomVariationAmountGray;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float RandomVariationAmountAlpha;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color RandomVariationColor;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int RandomVariationEvery;
	}

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color Color;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CheckForUpdate<Color> ColorT;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float Size;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CheckForUpdate<float> SizeT;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779800", Offset = "0x779800")]
	public float Falloff;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private CheckForUpdate<float> FalloffT;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool SCurve;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private CheckForUpdate<bool> SCurveT;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
	public bool Decay;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private CheckForUpdate<bool> DecayT;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	public bool ExtraSoft;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	private CheckForUpdate<bool> ExtraSoftT;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	public bool Invert;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
	private CheckForUpdate<bool> InvertT;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool RandomVariation;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private CheckForUpdate<bool> RandomVariationT;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779818", Offset = "0x779818")]
	public float RandomVariationAmount;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private CheckForUpdate<float> RandomVariationAmountT;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779830", Offset = "0x779830")]
	public float RandomVariationAmountGray;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private CheckForUpdate<float> RandomVariationAmountGrayT;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779848", Offset = "0x779848")]
	public float RandomVariationAmountAlpha;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private CheckForUpdate<float> RandomVariationAmountAlphaT;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Color RandomVariationColor;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private CheckForUpdate<Color> RandomVariationColorT;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public int RandomVariationEvery;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private CheckForUpdate<int> RandomVariationEveryT;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private CheckForRelativeTransformUpdate TransformT;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SpGCache.RegisteredProcess<SpMeshStack.MeshItem, ArgsData, SpMeshStack.MeshItem> process;

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xF79D28", Offset = "0xF79D28", VA = "0xF79D28", Slot = "5")]
	public override bool CheckForChange(GameObject meshStack)
	{
		return default(bool);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xF79FDC", Offset = "0xF79FDC", VA = "0xF79FDC")]
	private static float Smoothstep(float a, float b, float x, float smooth)
	{
		return default(float);
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xF7A0B0", Offset = "0xF7A0B0", VA = "0xF7A0B0", Slot = "6")]
	public override SpGCache.Job GetJob(GameObject meshStack, SpGCache.Job input)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xF7A380", Offset = "0xF7A380", VA = "0xF7A380")]
	public static SpMeshStack.MeshItem Process(ref ArgsData d, SpMeshStack.MeshItem inputItem, out SpGCache.ProcessMetrics outMetrics)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xF7A988", Offset = "0xF7A988", VA = "0xF7A988")]
	public SpMeshStack_VertexColor()
	{
	}
}
[Token(Token = "0x2000044")]
[ExecuteInEditMode]
public class SpMeshStack_VertexColorFromMap : MonoBehaviour
{
	[Token(Token = "0x6000171")]
	[Address(RVA = "0xF7AB30", Offset = "0xF7AB30", VA = "0xF7AB30")]
	public SpMeshStack_VertexColorFromMap()
	{
	}
}
[Token(Token = "0x2000045")]
public class SpPixels
{
	[Token(Token = "0x2000173")]
	public class RawImageRGBA
	{
		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Width;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Height;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color32[] Data;

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xF7DC98", Offset = "0xF7DC98", VA = "0xF7DC98")]
		public RawImageRGBA(int _width, int _height, Color32[] _data)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xF7DCD8", Offset = "0xF7DCD8", VA = "0xF7DCD8")]
		public RawImageRGBA()
		{
		}
	}

	[Token(Token = "0x2000174")]
	public class RawImageRGBAFloat
	{
		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Width;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Height;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color[] Data;

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xF7DD00", Offset = "0xF7DD00", VA = "0xF7DD00")]
		public RawImageRGBAFloat(int _width, int _height, Color[] _data)
		{
		}
	}

	[Token(Token = "0x2000175")]
	public delegate void PixelFunc<DATA>(int x, int y, ref DATA data);

	[Token(Token = "0x2000176")]
	private struct CoverageInfo
	{
		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int mapSize;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int[] map;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int pixelCount;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int coverageSum;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int coverageMin;

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xF7D6D0", Offset = "0xF7D6D0", VA = "0xF7D6D0")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xF7AB38", Offset = "0xF7AB38", VA = "0xF7AB38")]
	internal static int Clamp(int v, int mi, int ma)
	{
		return default(int);
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xF7AB54", Offset = "0xF7AB54", VA = "0xF7AB54")]
	internal static float Clamp(float v, float mi, float ma)
	{
		return default(float);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xF7AB70", Offset = "0xF7AB70", VA = "0xF7AB70")]
	public static void BoxBlurDimensionAndFlipAxis(int w, int h, int radius, float[] src, float[] dst, int srcStride = -1, int dstStride = -1)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xF7AF3C", Offset = "0xF7AF3C", VA = "0xF7AF3C")]
	public static float[] BoxBlur(int radius, int iterations, int w, int h, float[] src, [Optional] float[] dst, [Optional] float[] tmp)
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xF7B088", Offset = "0xF7B088", VA = "0xF7B088")]
	public static void FloatArrayTransform(float[] dst, float mul, float add)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xF7B0EC", Offset = "0xF7B0EC", VA = "0xF7B0EC")]
	public static void FloatArrayMul(float[] dst, float mul)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xF7B14C", Offset = "0xF7B14C", VA = "0xF7B14C")]
	public static void FloatArrayMul(float[] dst, float[] a, float[] b)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xF7B1D8", Offset = "0xF7B1D8", VA = "0xF7B1D8")]
	public static void FloatArrayAdd(float[] dst, float add)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xF7B238", Offset = "0xF7B238", VA = "0xF7B238")]
	public static void FloatArrayMix(float[] dst, float[] a, float[] b, float mix)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xF7B2CC", Offset = "0xF7B2CC", VA = "0xF7B2CC")]
	public static void FloatArrayMax(float[] dst, float[] a, float[] b)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xF7B35C", Offset = "0xF7B35C", VA = "0xF7B35C")]
	public static void FloatArrayMin(float[] dst, float[] a, float[] b)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xF7B3EC", Offset = "0xF7B3EC", VA = "0xF7B3EC")]
	public static void FloatArrayMin(float[] dst, float[] a, float b)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xF7B464", Offset = "0xF7B464", VA = "0xF7B464")]
	public static void FloatArrayMax(float[] dst, float[] a, float b)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xF7B4DC", Offset = "0xF7B4DC", VA = "0xF7B4DC")]
	public static float[] CopyArray(float[] src, [Optional] float[] dst, int count = -1)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xF7B57C", Offset = "0xF7B57C", VA = "0xF7B57C")]
	public static void CopyColorChannel(int count, Color[] src, int colorIndex, float[] dst)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xF7B624", Offset = "0xF7B624", VA = "0xF7B624")]
	public static void ReplaceColorChannel(int count, float[] src, Color[] dst, int colorIndex = -1)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xF7B730", Offset = "0xF7B730", VA = "0xF7B730")]
	public static void ArrayMul(float[] data, float mul)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xF7B790", Offset = "0xF7B790", VA = "0xF7B790")]
	public static float ArrayMax(float[] data, float startingMax = -1E+16f)
	{
		return default(float);
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xF7B7D4", Offset = "0xF7B7D4", VA = "0xF7B7D4")]
	private void ArrayNormalize(float[] data, float mul = 1f)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xF7B814", Offset = "0xF7B814", VA = "0xF7B814")]
	public static void SobelFilter(int offset, int w, int h, float[] src, float[] dst, float mul = 1f)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xF7BB08", Offset = "0xF7BB08", VA = "0xF7BB08")]
	public static void FogBlur(float radius, int w, int h, float[] dst, bool useMax, int quality = 5)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xF7BDAC", Offset = "0xF7BDAC", VA = "0xF7BDAC")]
	private void BoxBlurDimensionAndFlipAxis(int w, int h, int radius, Color[] src, Color[] dst, int srcStride = -1, int dstStride = -1)
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xF7C0D8", Offset = "0xF7C0D8", VA = "0xF7C0D8")]
	private void BoxBlurDimensionColorData(int w, int h, int radius, Color[] src, Color[] dst, bool horizontal, int srcStride = -1, int dstStride = -1)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xF7C684", Offset = "0xF7C684", VA = "0xF7C684")]
	private static float Square(float x)
	{
		return default(float);
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xF7C68C", Offset = "0xF7C68C", VA = "0xF7C68C")]
	private static float Lerp(float a, float b, float t)
	{
		return default(float);
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xF7C69C", Offset = "0xF7C69C", VA = "0xF7C69C")]
	private static Vector2 Lerp(Vector2 a, Vector2 b, float t)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xF7C76C", Offset = "0xF7C76C", VA = "0xF7C76C")]
	private static float Sample5Bilineari(int ix, int iy, float x, float y, int w, float[] map)
	{
		return default(float);
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xF7C818", Offset = "0xF7C818", VA = "0xF7C818")]
	public static float Sample5Bilinear(float x, float y, int w, int h, float[] map)
	{
		return default(float);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xF7C994", Offset = "0xF7C994", VA = "0xF7C994")]
	public static float SampleBilinear(float x, float y, int w, int h, float[] map)
	{
		return default(float);
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xF7CA98", Offset = "0xF7CA98", VA = "0xF7CA98")]
	public static Color32 SampleBilinear(float x, float y, int w, int h, Color32[] map)
	{
		return default(Color32);
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xF7CBD4", Offset = "0xF7CBD4", VA = "0xF7CBD4")]
	public static Color SampleBilinear(float x, float y, int w, int h, Color[] map)
	{
		return default(Color);
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xF7CD74", Offset = "0xF7CD74", VA = "0xF7CD74")]
	private static float SampleNearest(float x, float y, int w, int h, float[] map)
	{
		return default(float);
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xF7CDF0", Offset = "0xF7CDF0", VA = "0xF7CDF0")]
	private static float LerpClamp(float min, float max, float gradient)
	{
		return default(float);
	}

	[Token(Token = "0x6000193")]
	private static void TraceTriangleLine<DATA>(int y, Vector2 pa, Vector2 pb, Vector2 pc, Vector2 pd, ref DATA data, PixelFunc<DATA> p)
	{
	}

	[Token(Token = "0x6000194")]
	public static void TraceTriangle<DATA>(Vector2 p1, Vector2 p2, Vector2 p3, ref DATA data, PixelFunc<DATA> p)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xF7CE80", Offset = "0xF7CE80", VA = "0xF7CE80")]
	private static void PixelCollectData(int x, int y, ref CoverageInfo data)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xF7CF7C", Offset = "0xF7CF7C", VA = "0xF7CF7C")]
	private static void PixelAddOne(int x, int y, ref CoverageInfo data)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xF7D05C", Offset = "0xF7D05C", VA = "0xF7D05C")]
	private static void PixelAdd(int x, int y, int v, ref CoverageInfo data)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xF7D148", Offset = "0xF7D148", VA = "0xF7D148")]
	public static bool[] ReduceOverdraw(Vector2[][] ElementTriVerts, int mapSize = 1024, int minCoverageThreshold = 1, float averageThreshold = 2f)
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xF719C0", Offset = "0xF719C0", VA = "0xF719C0")]
	public static bool DoesTriangleMatchMapValue(Vector2 v1, Vector2 v2, Vector2 v3, int w, int h, float[] map, float matchingValue)
	{
		return default(bool);
	}

	[Token(Token = "0x600019A")]
	public static T[] FlipY<T>(T[] data, int w, int h)
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xF7D6DC", Offset = "0xF7D6DC", VA = "0xF7D6DC")]
	public static Color[] GetPixelsFromTexture(Texture2D tex)
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xF7D87C", Offset = "0xF7D87C", VA = "0xF7D87C")]
	public static Color[] GetPixelsFromRenderTexture(RenderTexture rt)
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xF7D910", Offset = "0xF7D910", VA = "0xF7D910")]
	public static Texture2D GetTextureFromRenderTexture(RenderTexture rt)
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xF7DA5C", Offset = "0xF7DA5C", VA = "0xF7DA5C")]
	public static Texture2D ResizeTexture(Texture2D source, int newWidth, int newHeight, bool updateMipmaps, bool makeNoLongerReadable)
	{
		return null;
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xF7DBC4", Offset = "0xF7DBC4", VA = "0xF7DBC4")]
	public static Texture2D GetReadableTextureIgnoreUnityOptions(Texture2D intex, int maxSize = 1024, bool needMipMaps = false)
	{
		return null;
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xF7DBCC", Offset = "0xF7DBCC", VA = "0xF7DBCC")]
	public static Texture2D GetReadableTextureIgnoreUnityOptions(string filePath, int maxSize = 1024, bool needMipMaps = false)
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xF7DBD4", Offset = "0xF7DBD4", VA = "0xF7DBD4")]
	public static float[] GetChannelFromTexture(Texture2D tex, int channelIndex)
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xF7DC90", Offset = "0xF7DC90", VA = "0xF7DC90")]
	public SpPixels()
	{
	}
}
[Token(Token = "0x2000046")]
[ExecuteInEditMode]
public class SpSetGlobalShaderParam : MonoBehaviour
{
	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableEdit;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779860", Offset = "0x779860")]
	public float eyeRes;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77987C", Offset = "0x77987C")]
	public float res;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779898", Offset = "0x779898")]
	public float f1;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7798B0", Offset = "0x7798B0")]
	public float f2;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7798C8", Offset = "0x7798C8")]
	public float f3;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7798E0", Offset = "0x7798E0")]
	public float f4;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7798F8", Offset = "0x7798F8")]
	public float f5;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779910", Offset = "0x779910")]
	public float f6;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779928", Offset = "0x779928")]
	public float f7;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string[] cmd;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool b1;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool b2;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool b3;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
	public bool b4;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool b5;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string[] cmdBool;

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xF7DD40", Offset = "0xF7DD40", VA = "0xF7DD40")]
	private void SetParams()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xF7DFF4", Offset = "0xF7DFF4", VA = "0xF7DFF4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xF7DFF8", Offset = "0xF7DFF8", VA = "0xF7DFF8")]
	public SpSetGlobalShaderParam()
	{
	}
}
[Token(Token = "0x2000047")]
[ExecuteInEditMode]
public class SpSplit : MonoBehaviour
{
	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xF7E01C", Offset = "0xF7E01C", VA = "0xF7E01C")]
	public SpSplit()
	{
	}
}
[Token(Token = "0x2000048")]
public class SpSplitByUV : MonoBehaviour
{
	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xF7E024", Offset = "0xF7E024", VA = "0xF7E024")]
	public SpSplitByUV()
	{
	}
}
[Token(Token = "0x2000049")]
public class SpVRIncDec : MonoBehaviour
{
	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float min;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float max;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float stepSize;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string displayPrefix;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject inc;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject dec;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject text;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string ShaderParam;

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xA34DBC", Offset = "0xA34DBC", VA = "0xA34DBC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xA34EF4", Offset = "0xA34EF4", VA = "0xA34EF4")]
	private float cmd(string cmd, string param, float value = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xA35550", Offset = "0xA35550", VA = "0xA35550")]
	private void Update()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xA357F0", Offset = "0xA357F0", VA = "0xA357F0")]
	public SpVRIncDec()
	{
	}
}
[Token(Token = "0x200004A")]
public class StaticBatchRoot : MonoBehaviour
{
	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xA4C5A8", Offset = "0xA4C5A8", VA = "0xA4C5A8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xA4C5C4", Offset = "0xA4C5C4", VA = "0xA4C5C4")]
	public StaticBatchRoot()
	{
	}
}
[Token(Token = "0x200004B")]
public class TensorCache
{
	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xA4C5D4", Offset = "0xA4C5D4", VA = "0xA4C5D4")]
	public TensorCache()
	{
	}
}
[Token(Token = "0x200004C")]
[ExecuteInEditMode]
public class TexturedMeshToLines : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000177")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778BAC", Offset = "0x778BAC")]
	private sealed class <>c
	{
		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<float, int, GCache.FloatTensor, GCache.MetaData<List<Vector3>>> <>9__14_0;

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xA4C8A0", Offset = "0xA4C8A0", VA = "0xA4C8A0")]
		public <>c()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xA4C8A8", Offset = "0xA4C8A8", VA = "0xA4C8A8")]
		internal GCache.MetaData<List<Vector3>> <CreateLinesFromFilteredImage>b__14_0(float _simplify, int _scanPixelsPerLine, GCache.FloatTensor _horiz)
		{
			return default(GCache.MetaData<List<Vector3>>);
		}
	}

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779940", Offset = "0x779940")]
	public float ImageAlphaPreMul;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector4 ImageChannelMixer;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779958", Offset = "0x779958")]
	public int DownSampleCount;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779970", Offset = "0x779970")]
	public float SobelFilterMul;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779988", Offset = "0x779988")]
	public int SobelFilterOffset;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7799A0", Offset = "0x7799A0")]
	public int ScanPixelsPerLine;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7799BC", Offset = "0x7799BC")]
	public float Simplify;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float _prevImageAlphaPreMul;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector4 _prevImageChannelMixer;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int _prevDownSampleCount;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float _prevSobelFilterMul;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int _prevSobelFilterOffset;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int _prevScanPixelsPerLine;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float _prevSimplify;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture2D DebugOut;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Texture2D _DebugOutStatic;

	[NonSerialized]
	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GCache.Job<Mesh> _curMeshAsJob;

	[NonSerialized]
	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Mesh _curMesh;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Material LineMaterial;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<GameObject> OutObjects;

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xA4C5DC", Offset = "0xA4C5DC", VA = "0xA4C5DC")]
	private static GCache.Job<List<Vector3>> CreateLinesFromFilteredImage(GCache.Job<GCache.FloatTensor> tex, float simplify, int scanPixelsPerLine)
	{
		return default(GCache.Job<List<Vector3>>);
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xA4C718", Offset = "0xA4C718", VA = "0xA4C718")]
	private static List<Mesh> TextureToLines(GameObject go, float simplify, float imageAlphaPreMul, Vector4 imageChannelMixer, int downSampleCount, float sobelFilterMul, int sobelFilterOffset, int scanPixelsPerLine, ref Texture2D DebugOut)
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xA4C720", Offset = "0xA4C720", VA = "0xA4C720")]
	public TexturedMeshToLines()
	{
	}
}
[Token(Token = "0x200004D")]
public class TransformByCameraDistance : MonoBehaviour
{
	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject FarTransform;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject NearTransform;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject ReferencePoint;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float FarDistance;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float NearDistance;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool UseSmoothCurve;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int DescreetPlaces;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float DescreetPlacesDuration;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7799D4", Offset = "0x7799D4")]
	public float DescreetPlacesOverlap;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 AxisDiffMul;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 AxisDiffMulForHands;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject CameraOverride;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float _DescreetPlacesT;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float _DescreetPlacesV;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float _prevT;

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x9821C8", Offset = "0x9821C8", VA = "0x9821C8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x9829EC", Offset = "0x9829EC", VA = "0x9829EC")]
	public TransformByCameraDistance()
	{
	}
}
[Token(Token = "0x200004E")]
public class spAnimateMaterial : MonoBehaviour
{
	[Token(Token = "0x2000178")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778BBC", Offset = "0x778BBC")]
	private sealed class <MyUpdate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public spAnimateMaterial <>4__this;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0xD43B44", Offset = "0xD43B44", VA = "0xD43B44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0xD43BAC", Offset = "0xD43BAC", VA = "0xD43BAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xD43930", Offset = "0xD43930", VA = "0xD43930")]
		[DebuggerHidden]
		public <MyUpdate>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xD4396C", Offset = "0xD4396C", VA = "0xD4396C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xD43970", Offset = "0xD43970", VA = "0xD43970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xD43B4C", Offset = "0xD43B4C", VA = "0xD43B4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float delay;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float duration;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material material;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string floatName;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float floatStart;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float floatEnd;

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xD43864", Offset = "0xD43864", VA = "0xD43864")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xD43868", Offset = "0xD43868", VA = "0xD43868")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xD438C0", Offset = "0xD438C0", VA = "0xD438C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77A9EC", Offset = "0x77A9EC")]
	private IEnumerator MyUpdate()
	{
		return null;
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xD4395C", Offset = "0xD4395C", VA = "0xD4395C")]
	public spAnimateMaterial()
	{
	}
}
[Token(Token = "0x200004F")]
public class spCameraBound : MonoBehaviour
{
	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cameraObj;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject idealCameraPos;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject cameraBoundEffect;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool useCameraBound;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 cameraMoveBoundWorldOffset;

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xD43BB4", Offset = "0xD43BB4", VA = "0xD43BB4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xD43F80", Offset = "0xD43F80", VA = "0xD43F80")]
	public spCameraBound()
	{
	}
}
[Token(Token = "0x2000050")]
public class spEnableOnMouseButton : MonoBehaviour
{
	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool setCurrentOnStart;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int current;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] roots;

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xD44000", Offset = "0xD44000", VA = "0xD44000")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xD44080", Offset = "0xD44080", VA = "0xD44080")]
	private void ValidateCurrent()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xD440F8", Offset = "0xD440F8", VA = "0xD440F8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xD44158", Offset = "0xD44158", VA = "0xD44158")]
	public spEnableOnMouseButton()
	{
	}
}
[Token(Token = "0x2000051")]
public class spSync : MonoBehaviour
{
	[Token(Token = "0x2000179")]
	public enum HttpMethod
	{
		[Token(Token = "0x4000848")]
		Automatic,
		[Token(Token = "0x4000849")]
		Get,
		[Token(Token = "0x400084A")]
		Post
	}

	[Token(Token = "0x200017A")]
	public enum SecurityOption
	{
		[Token(Token = "0x400084C")]
		unsecureLocalHashedServer,
		[Token(Token = "0x400084D")]
		hashed,
		[Token(Token = "0x400084E")]
		unsecure
	}

	[Token(Token = "0x200017B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778BCC", Offset = "0x778BCC")]
	private sealed class <spSync_saveToServer>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public spSync <>4__this;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int version;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string data;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <job>5__2;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WWW <www>5__3;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0xD46A1C", Offset = "0xD46A1C", VA = "0xD46A1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600093D")]
			[Address(RVA = "0xD46A84", Offset = "0xD46A84", VA = "0xD46A84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xD45954", Offset = "0xD45954", VA = "0xD45954")]
		[DebuggerHidden]
		public <spSync_saveToServer>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0xD465B8", Offset = "0xD465B8", VA = "0xD465B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0xD465BC", Offset = "0xD465BC", VA = "0xD465BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0xD46A24", Offset = "0xD46A24", VA = "0xD46A24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200017C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778BDC", Offset = "0x778BDC")]
	private sealed class <spSync_GetDataFromURL>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int version;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public spSync <>4__this;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <listening>5__2;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <job>5__3;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WWW <www>5__4;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0xD46548", Offset = "0xD46548", VA = "0xD46548", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000943")]
			[Address(RVA = "0xD465B0", Offset = "0xD465B0", VA = "0xD465B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0xD45A00", Offset = "0xD45A00", VA = "0xD45A00")]
		[DebuggerHidden]
		public <spSync_GetDataFromURL>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xD45FFC", Offset = "0xD45FFC", VA = "0xD45FFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xD46000", Offset = "0xD46000", VA = "0xD46000", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0xD46550", Offset = "0xD46550", VA = "0xD46550", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool runInEditor;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool logEvents;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool useLocalUrl;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string localUrl;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string serverUrl;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string serverContextName;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public HttpMethod httpMethod;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string serverSecret;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool preferServerDataOverLocal;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string syncTagName;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool _toggle_nothing;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private SecurityOption security;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool initialServerCheckStarted;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool initialServerCheckCompleted;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int lastVersion;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool lastVersionInvalid;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string lastServerJson;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string lastSyncedJsonGuess;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string lastJsonSentToServer;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool serverStuffChanged;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	private bool listeningForUpdates;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
	private bool waitingForWrite;

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xD441B8", Offset = "0xD441B8", VA = "0xD441B8")]
	private string serializeData(bool justMerged = false)
	{
		return null;
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xD44A48", Offset = "0xD44A48", VA = "0xD44A48")]
	private void unserializeAndMerge(string jsonText)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xD4504C", Offset = "0xD4504C", VA = "0xD4504C")]
	private void resetState()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xD450B4", Offset = "0xD450B4", VA = "0xD450B4")]
	private static string sha256(string password)
	{
		return null;
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xD4522C", Offset = "0xD4522C", VA = "0xD4522C")]
	public string escape_uri(string str)
	{
		return null;
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xD45428", Offset = "0xD45428", VA = "0xD45428")]
	private string substr(string s, int b, int e = -1)
	{
		return null;
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xD45470", Offset = "0xD45470", VA = "0xD45470")]
	private WWW createServerJob(string jobSpec)
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xD44FC4", Offset = "0xD44FC4", VA = "0xD44FC4")]
	private void doLog(string msg)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xD457E0", Offset = "0xD457E0", VA = "0xD457E0")]
	private string versionToString(int v)
	{
		return null;
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xD4581C", Offset = "0xD4581C", VA = "0xD4581C")]
	private int intParse(string i)
	{
		return default(int);
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xD458CC", Offset = "0xD458CC", VA = "0xD458CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77AA50", Offset = "0x77AA50")]
	private IEnumerator spSync_saveToServer(string data, int version)
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xD45980", Offset = "0xD45980", VA = "0xD45980")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77AAB4", Offset = "0x77AAB4")]
	private IEnumerator spSync_GetDataFromURL(int version)
	{
		return null;
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xD45A2C", Offset = "0xD45A2C", VA = "0xD45A2C")]
	private bool spSync_Sync()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xD45F38", Offset = "0xD45F38", VA = "0xD45F38")]
	private void wrapStartCoroutine(IEnumerator cr)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xD45F40", Offset = "0xD45F40", VA = "0xD45F40")]
	private void Start()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xD45F4C", Offset = "0xD45F4C", VA = "0xD45F4C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xD45F50", Offset = "0xD45F50", VA = "0xD45F50")]
	public spSync()
	{
	}
}
[Token(Token = "0x2000052")]
public class spTouchpadGalleryBrowser
{
	[Token(Token = "0x200017D")]
	public delegate void ActivePageChangedDelegate(RectTransform activePage, int activePageIndex, RectTransform previousPage, int previousPageIndex);

	[Token(Token = "0x200017E")]
	private enum SnapDirection
	{
		[Token(Token = "0x400085E")]
		Left,
		[Token(Token = "0x400085F")]
		Right,
		[Token(Token = "0x4000860")]
		Closest
	}

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7799EC", Offset = "0x7799EC")]
	public float ScrollSensitivity;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x779A24", Offset = "0x779A24")]
	public float SnapSpeed;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x779A5C", Offset = "0x779A5C")]
	public int StartPage;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x779A94", Offset = "0x779A94")]
	public bool loop;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x779ACC", Offset = "0x779ACC")]
	public int numExtraPagesShown;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float pageSpacing;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int pageCount;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool isTrackingTouches;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector2 initialTouchPos;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector2 previousTouchPos;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float previousTouchTimestamp;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector2 overallVelocity;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool canScroll;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	private bool isScrolling;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float scrollOffset;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float targetScrollOffset;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float lastReturnedScrollOffset;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int activeSnapCoroutineTargetId;

	[Token(Token = "0x4000250")]
	private const float kClickThreshold = 0.125f;

	[Token(Token = "0x4000251")]
	private const float kSwipeThreshold = 1f;

	[Token(Token = "0x4000252")]
	private const float kTimestampDeltaThreshold = 1E-07f;

	[Token(Token = "0x4000253")]
	private const float kIsMovingThresholdCoeff = 0.2f;

	[Token(Token = "0x4000254")]
	private const float kSnapScrollOffsetThresholdCoeff = 0.02f;

	[Token(Token = "0x4000255")]
	private const float kCuttoffHz = 10f;

	[Token(Token = "0x4000256")]
	private const float kRc = 1f / (20f * (float)Math.PI);

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool inputstate_IsTouching;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector2 inputstate_TouchPos;

	[Token(Token = "0x17000006")]
	public int PageCount
	{
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xD46B90", Offset = "0xD46B90", VA = "0xD46B90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xD46B98", Offset = "0xD46B98", VA = "0xD46B98")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public float ScrollOffset
	{
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xD46BA0", Offset = "0xD46BA0", VA = "0xD46BA0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xD46BA8", Offset = "0xD46BA8", VA = "0xD46BA8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public bool CanScroll
	{
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xD46C30", Offset = "0xD46C30", VA = "0xD46C30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xD46C38", Offset = "0xD46C38", VA = "0xD46C38")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public bool IsMoving
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xD46D7C", Offset = "0xD46D7C", VA = "0xD46D7C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xD46A8C", Offset = "0xD46A8C", VA = "0xD46A8C")]
	public spTouchpadGalleryBrowser()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xD46B68", Offset = "0xD46B68", VA = "0xD46B68")]
	private float getScrollOffset()
	{
		return default(float);
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xD46B74", Offset = "0xD46B74", VA = "0xD46B74")]
	private bool getIsScrolling()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xD46B84", Offset = "0xD46B84", VA = "0xD46B84")]
	private void setScrollOffset(float offset)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xD46E28", Offset = "0xD46E28", VA = "0xD46E28")]
	public void SnapToPage(int index, bool immediate = false)
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xD46B4C", Offset = "0xD46B4C", VA = "0xD46B4C")]
	private void Start_()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xD46F50", Offset = "0xD46F50", VA = "0xD46F50")]
	private void updateLerp()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xD470FC", Offset = "0xD470FC", VA = "0xD470FC")]
	public void ResetScrollOffset(float scrollPos)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xD47108", Offset = "0xD47108", VA = "0xD47108")]
	public float ScrollPages(float scrollPos, bool isTouching, Vector2 touchPos)
	{
		return default(float);
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xD473E8", Offset = "0xD473E8", VA = "0xD473E8")]
	private void StartScrolling()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xD46C8C", Offset = "0xD46C8C", VA = "0xD46C8C")]
	private void StopScrolling()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xD4735C", Offset = "0xD4735C", VA = "0xD4735C")]
	private void StartTouchTracking()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xD46CF0", Offset = "0xD46CF0", VA = "0xD46CF0")]
	private void StopTouchTracking()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xD47410", Offset = "0xD47410", VA = "0xD47410")]
	private void TrackTouch()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xD47560", Offset = "0xD47560", VA = "0xD47560")]
	private void SnapToPageInDirection(SnapDirection snapDirection)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xD46BC0", Offset = "0xD46BC0", VA = "0xD46BC0")]
	private void OnScrolled()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xD46F98", Offset = "0xD46F98", VA = "0xD46F98")]
	private bool LerpTowardsOffset(float targetOffset)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xD46F40", Offset = "0xD46F40", VA = "0xD46F40")]
	private float OffsetFromIndex(int index)
	{
		return default(float);
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xD4767C", Offset = "0xD4767C", VA = "0xD4767C")]
	private int IndexFromOffset(float offset, out bool didClamp)
	{
		return default(int);
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xD47760", Offset = "0xD47760", VA = "0xD47760")]
	private int PageIndexFromRealIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xD477EC", Offset = "0xD477EC", VA = "0xD477EC")]
	private bool ShouldShowIndexForOffset(float offset, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xD47758", Offset = "0xD47758", VA = "0xD47758")]
	private bool IsPageVisible(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xD46E14", Offset = "0xD46E14", VA = "0xD46E14")]
	private float GetMovingThreshold()
	{
		return default(float);
	}
}
[Token(Token = "0x2000053")]
public class testMoveByMouse : MonoBehaviour
{
	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 prevPos;

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x1512BC8", Offset = "0x1512BC8", VA = "0x1512BC8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x1512BCC", Offset = "0x1512BCC", VA = "0x1512BCC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x1512D58", Offset = "0x1512D58", VA = "0x1512D58")]
	public testMoveByMouse()
	{
	}
}
[Token(Token = "0x2000054")]
[ExecuteInEditMode]
public class tmpscript : MonoBehaviour
{
	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x1512D60", Offset = "0x1512D60", VA = "0x1512D60")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x1512D64", Offset = "0x1512D64", VA = "0x1512D64")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x1512D68", Offset = "0x1512D68", VA = "0x1512D68")]
	public tmpscript()
	{
	}
}
[Token(Token = "0x2000055")]
public class uvAnimate : MonoBehaviour
{
	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float uAnimate;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float vAnimate;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool useSharedMaterial;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Renderer rendererCache;

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1512D70", Offset = "0x1512D70", VA = "0x1512D70")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x1512DC8", Offset = "0x1512DC8", VA = "0x1512DC8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1512F3C", Offset = "0x1512F3C", VA = "0x1512F3C")]
	public uvAnimate()
	{
	}
}
[Token(Token = "0x2000056")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7788A8", Offset = "0x7788A8")]
public class wireframe : MonoBehaviour
{
	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Shader wireshader;

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x1512F44", Offset = "0x1512F44", VA = "0x1512F44")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1513010", Offset = "0x1513010", VA = "0x1513010")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x1513080", Offset = "0x1513080", VA = "0x1513080")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x15130E0", Offset = "0x15130E0", VA = "0x15130E0")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x1513150", Offset = "0x1513150", VA = "0x1513150")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x15131C0", Offset = "0x15131C0", VA = "0x15131C0")]
	public wireframe()
	{
	}
}
[Token(Token = "0x2000057")]
[ExecuteInEditMode]
public class GlobalShaderFloatControl : MonoBehaviour
{
	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public new string name;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float value;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779B04", Offset = "0x779B04")]
	public float slider;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 Slider_Min_Middle_Max;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float _prevSlider;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float _prevValue;

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xE42C38", Offset = "0xE42C38", VA = "0xE42C38")]
	public static float Curve(float x, float a)
	{
		return default(float);
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xE42C5C", Offset = "0xE42C5C", VA = "0xE42C5C")]
	public static float CurveFit3(float x, float y0, float y0_5, float y1)
	{
		return default(float);
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xE42D14", Offset = "0xE42D14", VA = "0xE42D14")]
	public static float CurveFit3i(float x, float y0, float y0_5, float y1)
	{
		return default(float);
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xE42D50", Offset = "0xE42D50", VA = "0xE42D50")]
	private void Update()
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xE42E40", Offset = "0xE42E40", VA = "0xE42E40")]
	public GlobalShaderFloatControl()
	{
	}
}
[Token(Token = "0x2000058")]
public class MiVRSwitchController : MonoBehaviour
{
	[Token(Token = "0x6000202")]
	[Address(RVA = "0xA4F310", Offset = "0xA4F310", VA = "0xA4F310")]
	private void Start()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xA4F314", Offset = "0xA4F314", VA = "0xA4F314")]
	public MiVRSwitchController()
	{
	}
}
[Token(Token = "0x2000059")]
public class OculusFixRequirement : MonoBehaviour
{
	[Token(Token = "0x6000204")]
	[Address(RVA = "0xA522EC", Offset = "0xA522EC", VA = "0xA522EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xA5245C", Offset = "0xA5245C", VA = "0xA5245C")]
	public OculusFixRequirement()
	{
	}
}
[Token(Token = "0x200005A")]
public class OverrideControllerMat : MonoBehaviour
{
	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material defaultMaterial;

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xA52464", Offset = "0xA52464", VA = "0xA52464")]
	public OverrideControllerMat()
	{
	}
}
[Token(Token = "0x200005B")]
public class ArtPlungeAddGemToMenu : MonoBehaviour
{
	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Message;

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xD50BFC", Offset = "0xD50BFC", VA = "0xD50BFC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xD50CFC", Offset = "0xD50CFC", VA = "0xD50CFC")]
	public ArtPlungeAddGemToMenu()
	{
	}
}
[Token(Token = "0x200005C")]
public class CalibrateViewText : MonoBehaviour
{
	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject calibrateInfo;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject bound;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool Calibrated;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool _showText;

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xD56C8C", Offset = "0xD56C8C", VA = "0xD56C8C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xD56CF8", Offset = "0xD56CF8", VA = "0xD56CF8")]
	private void Update()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xD57018", Offset = "0xD57018", VA = "0xD57018")]
	public CalibrateViewText()
	{
	}
}
[Token(Token = "0x200005D")]
public class Gallery : MonoBehaviour
{
	[Token(Token = "0x200017F")]
	private struct FrameInput
	{
		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double timeStamp;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SerializableVector3 cameraPos;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SerializableQuaternion cameraRot;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint buttonFlags;
	}

	[Token(Token = "0x2000180")]
	private class GalleryItem
	{
		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject root;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject painting;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject frame;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject litFrame;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject info;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject loading;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> behind;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<ArtPlungeSceneRoot.TransitionAdjustment> transitionAdjustments;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float hilight;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float hilightFrame;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int id;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool isLoaded;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float widthSumOffset;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject main;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject tunnel;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GameObject tunnelSound;

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xAC83A8", Offset = "0xAC83A8", VA = "0xAC83A8")]
		public GalleryItem()
		{
		}
	}

	[Token(Token = "0x2000181")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778BEC", Offset = "0x778BEC")]
	private sealed class <FadeOut>d__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource audioSource;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float FadeTime;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <startVolume>5__2;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600094C")]
			[Address(RVA = "0xAC6E24", Offset = "0xAC6E24", VA = "0xAC6E24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600094E")]
			[Address(RVA = "0xAC6E8C", Offset = "0xAC6E8C", VA = "0xAC6E8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xAC0D38", Offset = "0xAC0D38", VA = "0xAC0D38")]
		[DebuggerHidden]
		public <FadeOut>d__46(int <>1__state)
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xAC6CE8", Offset = "0xAC6CE8", VA = "0xAC6CE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xAC6CEC", Offset = "0xAC6CEC", VA = "0xAC6CEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xAC6E2C", Offset = "0xAC6E2C", VA = "0xAC6E2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000182")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778BFC", Offset = "0x778BFC")]
	private sealed class <LoadScene>d__99 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Gallery <>4__this;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GalleryItem gi;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject <o>5__2;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ArtPlungeSceneRoot.TransitionAdjustment <ta>5__3;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <postfix>5__4;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<GameObject> <transition>5__5;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<GameObject> <transition2>5__6;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000952")]
			[Address(RVA = "0xAC910C", Offset = "0xAC910C", VA = "0xAC910C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000954")]
			[Address(RVA = "0xAC9174", Offset = "0xAC9174", VA = "0xAC9174", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xAC1E48", Offset = "0xAC1E48", VA = "0xAC1E48")]
		[DebuggerHidden]
		public <LoadScene>d__99(int <>1__state)
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xAC84BC", Offset = "0xAC84BC", VA = "0xAC84BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xAC84C0", Offset = "0xAC84C0", VA = "0xAC84C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xAC9114", Offset = "0xAC9114", VA = "0xAC9114", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000183")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778C0C", Offset = "0x778C0C")]
	private sealed class <InitGallery>d__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Gallery <>4__this;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <useFade>5__2;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<GalleryItem>.Enumerator <>7__wrap2;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <zoomTime>5__4;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float <t>5__5;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float <infoAnimDuration>5__6;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0xAC844C", Offset = "0xAC844C", VA = "0xAC844C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0xAC84B4", Offset = "0xAC84B4", VA = "0xAC84B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0xAC1E74", Offset = "0xAC1E74", VA = "0xAC1E74")]
		[DebuggerHidden]
		public <InitGallery>d__102(int <>1__state)
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0xAC6E94", Offset = "0xAC6E94", VA = "0xAC6E94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0xAC6F08", Offset = "0xAC6F08", VA = "0xAC6F08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0xAC6EB0", Offset = "0xAC6EB0", VA = "0xAC6EB0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0xAC8454", Offset = "0xAC8454", VA = "0xAC8454", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool ExperimentalBuild;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool useBackgroundLoading;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool _______________________doLog;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool GoPrev;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool GoNext;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRInteractable BackNav;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public VRInteractable BackNav2;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioMixerGroup GalleryMixer;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioMixerGroup PortalMixer;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioMixerGroup Environment;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioSource GlobalSound;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AudioSource GlobalSoundEnterPortal;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioClip Click;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioClip Click2;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AudioClip enterportal;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AudioClip exitportal;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AudioClip hover;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject cameraFolder;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject idealCameraPos;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject cameraBound;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool hideAllInfo;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool disableGazeClick;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
	public bool muteInteractionSounds;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9B")]
	public bool disableFocusHighlight;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public CalibrateViewText camCalibration;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject fatalError;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public bool useCameraBound;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public Vector3 cameraPosLoading;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Vector3 cameraPosDoneLoading;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject InfoRoot;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject InfoRootHideLocation;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private GameObject InfoTransformStart;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private GameObject InfoTransform;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool ShowInfoAtStart;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public GameObject InfoHintObj;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public VRButton PrevArrow;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public VRButton NextArrow;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public TouchUIEvents MenuUI;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float _galleryTime;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private softAction _infoHintSmoother;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool _infoHasBeenShown;

	[Token(Token = "0x4000294")]
	private const uint INPUT_CLICK = 1u;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private List<GalleryItem> galleryItems;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private GameObject GalleryItemsRoot;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private GameObject GalleryRoot;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public GameObject GalleryMainWall;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private bool initedGallery;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
	private bool allLoadingDone;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x152")]
	private bool initialZoomHalfDone;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x153")]
	public bool initialZoomDone;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private bool requestBack;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x155")]
	private bool insidePainting;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private GalleryItem hoverItem;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GalleryItem currentlySelectedItem;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private float selectionTarget;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	private float currentSelection;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private bool instantSelect;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private int MoveBoundLayerMask;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private int GazePointLayerMask;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	private bool MovingToGazeTarget;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Vector3 GazeTarget;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private Vector3 prevCamDir;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private float cameraRotationSpeed;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private float cameraRotationSpeedVel;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private Vector3 sceneCamera;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	private Vector3 sceneCameraVel;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private bool blockInput;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private softAction infoFader;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private softAction tapToEnter;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private bool _userHasSuccessfullyEnteredAPainting;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public GameObject tapToEnterObj;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public GameObject tapToEnterOverlayObj;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public GameObject welcomeObj;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public GameObject welcomeDarkenObj;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public GameObject welcomeSpinner;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public SwipeAndGyroControl swipeAndGyro;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Gallery Instance;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public GameObject GemMessage;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public GameObject Gem;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private float GalleryMixerStartFade;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	private bool _showInfoAtStart;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private float _initialZoomT;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	private int _maxScenesLoaded;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private Dictionary<int, GalleryItem> _loadedScenes;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private spTouchpadGalleryBrowser _touchpadBrowse;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private float targetT;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	private float transT;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private float prevTransT;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
	private float lastTransitionStoppedTime;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private bool duringTransition;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x249")]
	private bool actionRequested;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private GalleryItem triggerActionAfterLoad;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private bool _DoActionInjected;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x259")]
	private bool _skipAutoInc;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
	public int ResetExperienceNow;

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xAC0C20", Offset = "0xAC0C20", VA = "0xAC0C20")]
	private void Log(string txt)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xAC0CA8", Offset = "0xAC0CA8", VA = "0xAC0CA8")]
	public Vector3 GetCameraPosLoading()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xAC0CB4", Offset = "0xAC0CB4", VA = "0xAC0CB4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xAC0CB8", Offset = "0xAC0CB8", VA = "0xAC0CB8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77AB18", Offset = "0x77AB18")]
	public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xAC0D64", Offset = "0xAC0D64", VA = "0xAC0D64")]
	private List<GameObject> getChildren(GameObject go, bool includeInactive = true)
	{
		return null;
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xAC1064", Offset = "0xAC1064", VA = "0xAC1064")]
	private GameObject getChildWithName(GameObject go, string name)
	{
		return null;
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xAC1358", Offset = "0xAC1358", VA = "0xAC1358")]
	private void _getObjectsWithNameRec(GameObject go, string name, List<GameObject> li, int depth)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xAC1694", Offset = "0xAC1694", VA = "0xAC1694")]
	private List<GameObject> getObjectsWithNameRecursive(GameObject root, string name)
	{
		return null;
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xAC1724", Offset = "0xAC1724", VA = "0xAC1724")]
	private float DotFromViewCenter(Vector3 ro, Vector3 rd, GameObject dest)
	{
		return default(float);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xAC184C", Offset = "0xAC184C", VA = "0xAC184C")]
	private void LerpTransform(GameObject dst, GameObject from, GameObject to, float t, bool doScale = true)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xAC1B24", Offset = "0xAC1B24", VA = "0xAC1B24")]
	public void StopBlockingInput()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xAC1B2C", Offset = "0xAC1B2C", VA = "0xAC1B2C")]
	public void LanguageAlterOptionsAtRuntimeStartup(Dictionary<string, LanguageSupport.Variation> options)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xAC1C94", Offset = "0xAC1C94", VA = "0xAC1C94")]
	public void GoBack()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xAC1CA8", Offset = "0xAC1CA8", VA = "0xAC1CA8")]
	public bool tryToGoBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xAC1CC8", Offset = "0xAC1CC8", VA = "0xAC1CC8")]
	private void Start()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xAC1DCC", Offset = "0xAC1DCC", VA = "0xAC1DCC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77AB7C", Offset = "0x77AB7C")]
	private IEnumerator LoadScene(GalleryItem gi)
	{
		return null;
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xAC1D5C", Offset = "0xAC1D5C", VA = "0xAC1D5C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77ABE0", Offset = "0x77ABE0")]
	private IEnumerator InitGallery()
	{
		return null;
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xAC1EA0", Offset = "0xAC1EA0", VA = "0xAC1EA0")]
	private void FadeToBlack()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xAC2000", Offset = "0xAC2000", VA = "0xAC2000")]
	private void FadeFromBlack()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xAC2160", Offset = "0xAC2160", VA = "0xAC2160")]
	private float Square(float a)
	{
		return default(float);
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xAC2168", Offset = "0xAC2168", VA = "0xAC2168")]
	private float toDB(float a)
	{
		return default(float);
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xAC21FC", Offset = "0xAC21FC", VA = "0xAC21FC")]
	private float fromDB(float db)
	{
		return default(float);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xAC2274", Offset = "0xAC2274", VA = "0xAC2274")]
	public void ClickOnPainting(string name)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xAC2470", Offset = "0xAC2470", VA = "0xAC2470")]
	public void UIMessage(string msg)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xAC2598", Offset = "0xAC2598", VA = "0xAC2598")]
	private void ResetExperience(int selection)
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xAC2448", Offset = "0xAC2448", VA = "0xAC2448")]
	private void PlayInteractionSound(AudioClip clip, float volume = 1f)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xAC25E8", Offset = "0xAC25E8", VA = "0xAC25E8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xAC6ACC", Offset = "0xAC6ACC", VA = "0xAC6ACC")]
	public Gallery()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xAC6C68", Offset = "0xAC6C68", VA = "0xAC6C68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AC44", Offset = "0x77AC44")]
	private void <InitGallery>b__102_0()
	{
	}
}
[Token(Token = "0x200005E")]
public class GalleryItem : MonoBehaviour
{
	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool CanEnter;

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xAC6994", Offset = "0xAC6994", VA = "0xAC6994")]
	public static bool CanEnterItem(GameObject o)
	{
		return default(bool);
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xAC917C", Offset = "0xAC917C", VA = "0xAC917C")]
	public GalleryItem()
	{
	}
}
[Token(Token = "0x200005F")]
public class LoadingSceneScript : MonoBehaviour
{
	[Token(Token = "0x2000184")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778C1C", Offset = "0x778C1C")]
	private sealed class <LoadFirstScene>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoadingSceneScript <>4__this;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <wait>5__2;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <fadeVal>5__3;

		[Token(Token = "0x17000053")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0xE4EB7C", Offset = "0xE4EB7C", VA = "0xE4EB7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0xE4EBE4", Offset = "0xE4EBE4", VA = "0xE4EBE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0xE4E804", Offset = "0xE4E804", VA = "0xE4E804")]
		[DebuggerHidden]
		public <LoadFirstScene>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0xE4E8D4", Offset = "0xE4E8D4", VA = "0xE4E8D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0xE4E8D8", Offset = "0xE4E8D8", VA = "0xE4E8D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0xE4EB84", Offset = "0xE4EB84", VA = "0xE4EB84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float fadeDuration;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string sceneName;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material fadeMaterial;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string fadeProperty;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float fadeMaxValue;

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xE4E794", Offset = "0xE4E794", VA = "0xE4E794")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77AC54", Offset = "0x77AC54")]
	private IEnumerator LoadFirstScene()
	{
		return null;
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xE4E830", Offset = "0xE4E830", VA = "0xE4E830")]
	private void Start()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xE4E85C", Offset = "0xE4E85C", VA = "0xE4E85C")]
	public LoadingSceneScript()
	{
	}
}
[Token(Token = "0x2000060")]
public class OVRPlatformMenuArtPlunge : MonoBehaviour
{
	[Token(Token = "0x2000185")]
	private enum eBackButtonAction
	{
		[Token(Token = "0x4000891")]
		NONE,
		[Token(Token = "0x4000892")]
		DOUBLE_TAP,
		[Token(Token = "0x4000893")]
		SHORT_PRESS,
		[Token(Token = "0x4000894")]
		LONG_PRESS
	}

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorTimer;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color cursorTimerColor;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float fixedDepth;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject instantiatedCursorTimer;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material cursorTimerMaterial;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float doubleTapDelay;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float shortPressDelay;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float longPressDelay;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int downCount;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int upCount;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float initialDownTime;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool waitForUp;

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xA50D5C", Offset = "0xA50D5C", VA = "0xA50D5C")]
	private eBackButtonAction ResetAndSendAction(eBackButtonAction action)
	{
		return default(eBackButtonAction);
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xA50EE8", Offset = "0xA50EE8", VA = "0xA50EE8")]
	private eBackButtonAction HandleBackButtonState()
	{
		return default(eBackButtonAction);
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xA51334", Offset = "0xA51334", VA = "0xA51334")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xA514E8", Offset = "0xA514E8", VA = "0xA514E8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xA5159C", Offset = "0xA5159C", VA = "0xA5159C")]
	private void OnApplicationFocus(bool focusState)
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xA515A0", Offset = "0xA515A0", VA = "0xA515A0")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xA515B0", Offset = "0xA515B0", VA = "0xA515B0")]
	private void ShowConfirmQuitMenu()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xA51684", Offset = "0xA51684", VA = "0xA51684")]
	private void Update()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xA510A0", Offset = "0xA510A0", VA = "0xA510A0")]
	private void UpdateCursor(float timerRotateRatio)
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xA50E1C", Offset = "0xA50E1C", VA = "0xA50E1C")]
	private void ResetCursor()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xA51744", Offset = "0xA51744", VA = "0xA51744")]
	public OVRPlatformMenuArtPlunge()
	{
	}
}
[Token(Token = "0x2000061")]
public class TouchUIEvents : MonoBehaviour
{
	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SwipeAndGyroControl swipeAndGyro;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool ShowBackButton;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Selection;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject StretchToScreenWidth;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject NonRotated;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject Menu;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public VRButton OpenMenu;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public VRButton CloseMenu;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public VRButton CardboardButton;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject ScreenCornerL;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject ScreenCornerR;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private softAction smoothSel;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private softAction rollSmooth;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float _selTarget;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _validRollSmooth;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
	[HideInInspector]
	public bool IsMenuActive;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _prevFov;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float _prevW;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float _prevH;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float _prevRolln;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float DebugRollTest;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private bool _vrWasEnabled;

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xA4CB88", Offset = "0xA4CB88", VA = "0xA4CB88")]
	public void SetMenuActive(bool active)
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xA4CC30", Offset = "0xA4CC30", VA = "0xA4CC30")]
	public void UIMessage(string msg)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xA4CDDC", Offset = "0xA4CDDC", VA = "0xA4CDDC")]
	private void UpdateSelected()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xA4CE28", Offset = "0xA4CE28", VA = "0xA4CE28")]
	private void Start()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xA4CEC0", Offset = "0xA4CEC0", VA = "0xA4CEC0")]
	private float smoothstepc(float x)
	{
		return default(float);
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xA4CED8", Offset = "0xA4CED8", VA = "0xA4CED8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xA4E1C4", Offset = "0xA4E1C4", VA = "0xA4E1C4")]
	private static float raycast(Plane plane, Ray ray)
	{
		return default(float);
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xA4E008", Offset = "0xA4E008", VA = "0xA4E008")]
	private static Vector3 raycastToPos(Plane plane, Ray ray, bool ignoreOrigin)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xA4E21C", Offset = "0xA4E21C", VA = "0xA4E21C")]
	public TouchUIEvents()
	{
	}
}
[Token(Token = "0x2000062")]
public class SpAccessKinectDepth : MonoBehaviour
{
	[Token(Token = "0x6000244")]
	[Address(RVA = "0xA63D20", Offset = "0xA63D20", VA = "0xA63D20")]
	private void Update()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xA63EA8", Offset = "0xA63EA8", VA = "0xA63EA8")]
	public SpAccessKinectDepth()
	{
	}
}
[Token(Token = "0x2000063")]
public class SpKinectDepth : MonoBehaviour
{
	[Token(Token = "0x2000186")]
	public enum Filter
	{
		[Token(Token = "0x4000896")]
		none,
		[Token(Token = "0x4000897")]
		filter6db,
		[Token(Token = "0x4000898")]
		filter12db,
		[Token(Token = "0x4000899")]
		filter18db,
		[Token(Token = "0x400089A")]
		filter24db
	}

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float gain;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float max;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float frontCut;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float filterAmount;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Filter filter;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int width;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int height;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Texture2D texture;

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xF6E7F8", Offset = "0xF6E7F8", VA = "0xF6E7F8")]
	public SpKinectDepth()
	{
	}
}
[Token(Token = "0x2000064")]
public class MeshStackCore : MonoBehaviour
{
	[Token(Token = "0x2000187")]
	public interface IMeshGenerator
	{
		[Token(Token = "0x6000962")]
		void ForceMeshGeneration();

		[Token(Token = "0x6000963")]
		void InvalidateMesh();
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xA4F2D8", Offset = "0xA4F2D8", VA = "0xA4F2D8")]
	public static void ForceMeshGeneration(GameObject go)
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xA4F2DC", Offset = "0xA4F2DC", VA = "0xA4F2DC")]
	public static void InvalidateMesh(GameObject go)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xA4F2E0", Offset = "0xA4F2E0", VA = "0xA4F2E0")]
	public static Mesh ProcessStack(GameObject go, Mesh m)
	{
		return null;
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0xA4F2E8", Offset = "0xA4F2E8", VA = "0xA4F2E8")]
	public MeshStackCore()
	{
	}
}
[Token(Token = "0x2000065")]
public class MeshStack_BendAndDeform : MonoBehaviour
{
	[Token(Token = "0x600024C")]
	[Address(RVA = "0xA4F2F0", Offset = "0xA4F2F0", VA = "0xA4F2F0")]
	public MeshStack_BendAndDeform()
	{
	}
}
[Token(Token = "0x2000066")]
public class MeshStack_Slice : MonoBehaviour
{
	[Token(Token = "0x600024D")]
	[Address(RVA = "0xA4F2F8", Offset = "0xA4F2F8", VA = "0xA4F2F8")]
	public MeshStack_Slice()
	{
	}
}
[Token(Token = "0x2000067")]
public class MeshStack_UVMap : MonoBehaviour
{
	[Token(Token = "0x600024E")]
	[Address(RVA = "0xA4F300", Offset = "0xA4F300", VA = "0xA4F300")]
	public MeshStack_UVMap()
	{
	}
}
[Token(Token = "0x2000068")]
public class MeshStack_VertexColorFromImage : MonoBehaviour
{
	[Token(Token = "0x600024F")]
	[Address(RVA = "0xA4F308", Offset = "0xA4F308", VA = "0xA4F308")]
	public MeshStack_VertexColorFromImage()
	{
	}
}
[Token(Token = "0x2000069")]
[ExecuteInEditMode]
public class SpDeepCombineMeshes : MonoBehaviour, MeshStackCore.IMeshGenerator, SpMeshStack.IMeshSupplier
{
	[Token(Token = "0x6000250")]
	[Address(RVA = "0xF69E64", Offset = "0xF69E64", VA = "0xF69E64", Slot = "4")]
	private void MeshStackCore.IMeshGenerator.ForceMeshGeneration()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xF69E68", Offset = "0xF69E68", VA = "0xF69E68", Slot = "5")]
	private void MeshStackCore.IMeshGenerator.InvalidateMesh()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xF69E6C", Offset = "0xF69E6C", VA = "0xF69E6C", Slot = "6")]
	private SpMeshStack.MeshItem SpMeshStack.IMeshSupplier.Request()
	{
		return null;
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xF69ED0", Offset = "0xF69ED0", VA = "0xF69ED0")]
	public SpDeepCombineMeshes()
	{
	}
}
[Token(Token = "0x200006A")]
[ExecuteInEditMode]
public class SpMeshFromImageAlpha : MonoBehaviour, MeshStackCore.IMeshGenerator, SpMeshStack.IMeshSupplier
{
	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float quality;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float size;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float aspectShift;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 handle;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779B2C", Offset = "0x779B2C")]
	public float cropW;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779B48", Offset = "0x779B48")]
	public float cropH;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector2 cropOffset;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool flip;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool useDepthMap;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D depthMap;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float prevDepthMapSmooth;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float depthMapSmooth;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float depthMapScale;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float depthMapOffset;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool simpleDepthMap;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool clearBlurCacheNow;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	public bool useTextureAlpha;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	public bool trimSemiTransparent;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture2D inputTexture;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float warpCoarseAmount;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float warpAmount;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float softDepth;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float softDepthOffset;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float depthSize;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float depthCircular;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float depthAspect;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool quads;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779B64", Offset = "0x779B64")]
	public float bendX;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779B7C", Offset = "0x779B7C")]
	public float bendY;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779B94", Offset = "0x779B94")]
	public float bendZ;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool bendToSphere;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	public bool centerSphere;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Vector2 preBendScale;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Vector4 projPlane;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool projection;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
	public bool projectBackwards;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public float projMax;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public bool projMaxSmooth;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public float projMaxSmooth1;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float projMaxSmooth2;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public Vector3 projCameraPos;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Vector3 projObjPos;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public Quaternion projObjRot;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public Vector3 projObjScale;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private float[] depthCache;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float[] depthBlurCache;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private float[] blurCache;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float[] blurCacheRaw;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float[] blurCacheSobel;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private int blurCacheW;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private int blurCacheH;

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xF76A9C", Offset = "0xF76A9C", VA = "0xF76A9C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xF76BE4", Offset = "0xF76BE4", VA = "0xF76BE4", Slot = "4")]
	private void MeshStackCore.IMeshGenerator.ForceMeshGeneration()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xF76BE8", Offset = "0xF76BE8", VA = "0xF76BE8", Slot = "5")]
	private void MeshStackCore.IMeshGenerator.InvalidateMesh()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xF76BEC", Offset = "0xF76BEC", VA = "0xF76BEC", Slot = "6")]
	private SpMeshStack.MeshItem SpMeshStack.IMeshSupplier.Request()
	{
		return null;
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xF76C48", Offset = "0xF76C48", VA = "0xF76C48")]
	public SpMeshFromImageAlpha()
	{
	}
}
[Token(Token = "0x200006B")]
[ExecuteInEditMode]
public class birdSprites : MonoBehaviour
{
	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int count;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float expandBounds;

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xD43850", Offset = "0xD43850", VA = "0xD43850")]
	public birdSprites()
	{
	}
}
[Token(Token = "0x200006C")]
public class testDiff : MonoBehaviour
{
	[Token(Token = "0x600025A")]
	[Address(RVA = "0x1512BB8", Offset = "0x1512BB8", VA = "0x1512BB8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x1512BC0", Offset = "0x1512BC0", VA = "0x1512BC0")]
	public testDiff()
	{
	}
}
[Token(Token = "0x200006D")]
public static class PLYReader
{
	[Token(Token = "0x2000188")]
	private enum DataProperty
	{
		[Token(Token = "0x400089C")]
		Invalid,
		[Token(Token = "0x400089D")]
		R8,
		[Token(Token = "0x400089E")]
		G8,
		[Token(Token = "0x400089F")]
		B8,
		[Token(Token = "0x40008A0")]
		A8,
		[Token(Token = "0x40008A1")]
		R16,
		[Token(Token = "0x40008A2")]
		G16,
		[Token(Token = "0x40008A3")]
		B16,
		[Token(Token = "0x40008A4")]
		A16,
		[Token(Token = "0x40008A5")]
		SingleX,
		[Token(Token = "0x40008A6")]
		SingleY,
		[Token(Token = "0x40008A7")]
		SingleZ,
		[Token(Token = "0x40008A8")]
		DoubleX,
		[Token(Token = "0x40008A9")]
		DoubleY,
		[Token(Token = "0x40008AA")]
		DoubleZ,
		[Token(Token = "0x40008AB")]
		Data8,
		[Token(Token = "0x40008AC")]
		Data16,
		[Token(Token = "0x40008AD")]
		Data32,
		[Token(Token = "0x40008AE")]
		Data64
	}

	[Token(Token = "0x2000189")]
	private class DataHeader
	{
		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<DataProperty> properties;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int vertexCount;

		[Token(Token = "0x6000964")]
		[Address(RVA = "0xA53D6C", Offset = "0xA53D6C", VA = "0xA53D6C")]
		public DataHeader()
		{
		}
	}

	[Token(Token = "0x200018A")]
	public class CloudData
	{
		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Vector3> vertices;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Color32> colors;

		[Token(Token = "0x6000965")]
		[Address(RVA = "0xA53B8C", Offset = "0xA53B8C", VA = "0xA53B8C")]
		public CloudData(int vertexCount)
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xA53DE4", Offset = "0xA53DE4", VA = "0xA53DE4")]
		public void AddPoint(Vector3 v)
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xA53E64", Offset = "0xA53E64", VA = "0xA53E64")]
		public void AddPoint(Vector3 v, Color32 col)
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xA53C3C", Offset = "0xA53C3C", VA = "0xA53C3C")]
		public void AddPoint(float x, float y, float z, byte r, byte g, byte b, byte a)
		{
		}
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xA5246C", Offset = "0xA5246C", VA = "0xA5246C")]
	public static void SavePLY(string filepath, CloudData data)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xA52944", Offset = "0xA52944", VA = "0xA52944")]
	public static CloudData LoadPLY(string filepath)
	{
		return null;
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xA53D48", Offset = "0xA53D48", VA = "0xA53D48")]
	private static int GetPropertySize(DataProperty p)
	{
		return default(int);
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xA53294", Offset = "0xA53294", VA = "0xA53294")]
	private static DataHeader ReadDataHeader(StreamReader reader)
	{
		return null;
	}
}
[Token(Token = "0x200006E")]
public static class ShapeOptimization
{
	[Token(Token = "0x6000260")]
	[Address(RVA = "0xA5A3C0", Offset = "0xA5A3C0", VA = "0xA5A3C0")]
	public static List<Vector2> DouglasPeuckerReduction(List<Vector2> Points, double Tolerance)
	{
		return null;
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xA5A4E0", Offset = "0xA5A4E0", VA = "0xA5A4E0")]
	private static void DouglasPeuckerReductionRecursive(List<Vector2> points, int firstPoint, int lastPoint, double tolerance, ref List<Vector2> returnPoints)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xA5A81C", Offset = "0xA5A81C", VA = "0xA5A81C")]
	public static double sq(double x)
	{
		return default(double);
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xA5A6A4", Offset = "0xA5A6A4", VA = "0xA5A6A4")]
	public static double PerpendicularDistance(Vector2 Point1, Vector2 Point2, Vector2 Point)
	{
		return default(double);
	}
}
[Token(Token = "0x200006F")]
public class MTLLoader
{
	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<string> SearchPaths;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private FileInfo _objFileInfo;

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xE4FE40", Offset = "0xE4FE40", VA = "0xE4FE40", Slot = "4")]
	public virtual Texture2D TextureLoadFunction(string path, bool isNormalMap)
	{
		return null;
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xE5004C", Offset = "0xE5004C", VA = "0xE5004C")]
	private Texture2D TryLoadTexture(string texturePath, bool normalMap = false)
	{
		return null;
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xE50110", Offset = "0xE50110", VA = "0xE50110")]
	private int GetArgValueCount(string arg)
	{
		return default(int);
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xE502F0", Offset = "0xE502F0", VA = "0xE502F0")]
	private int GetTexNameIndex(string[] components)
	{
		return default(int);
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xE50364", Offset = "0xE50364", VA = "0xE50364")]
	private float GetArgValue(string[] components, string arg, float fallback = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xE50434", Offset = "0xE50434", VA = "0xE50434")]
	private string GetTexPathFromMapStatement(string processedLine, string[] splitLine)
	{
		return null;
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xE5053C", Offset = "0xE5053C", VA = "0xE5053C")]
	public Dictionary<string, Material> Load(Stream input)
	{
		return null;
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xE50E5C", Offset = "0xE50E5C", VA = "0xE50E5C")]
	public Dictionary<string, Material> Load(string path)
	{
		return null;
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xE50FEC", Offset = "0xE50FEC", VA = "0xE50FEC")]
	public MTLLoader()
	{
	}
}
[Token(Token = "0x2000070")]
public class ObjFromFile : MonoBehaviour
{
	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string objPath;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string error;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject loadedObject;

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xA51E8C", Offset = "0xA51E8C", VA = "0xA51E8C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xA52164", Offset = "0xA52164", VA = "0xA52164")]
	public ObjFromFile()
	{
	}
}
[Token(Token = "0x2000071")]
public class ObjFromStream : MonoBehaviour
{
	[Token(Token = "0x600026F")]
	[Address(RVA = "0xA521D0", Offset = "0xA521D0", VA = "0xA521D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xA522E4", Offset = "0xA522E4", VA = "0xA522E4")]
	public ObjFromStream()
	{
	}
}
[Token(Token = "0x2000072")]
public class Triangulator
{
	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<Vector2> m_points;

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x982AA4", Offset = "0x982AA4", VA = "0x982AA4")]
	public Triangulator(Vector2[] points)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x982B48", Offset = "0x982B48", VA = "0x982B48")]
	public int[] Triangulate()
	{
		return null;
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x982DD4", Offset = "0x982DD4", VA = "0x982DD4")]
	private float Area()
	{
		return default(float);
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x982EF0", Offset = "0x982EF0", VA = "0x982EF0")]
	private bool Snip(int u, int v, int w, int n, int[] V)
	{
		return default(bool);
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x983144", Offset = "0x983144", VA = "0x983144")]
	private bool InsideTriangle(Vector2 A, Vector2 B, Vector2 C, Vector2 P)
	{
		return default(bool);
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x9831C0", Offset = "0x9831C0", VA = "0x9831C0")]
	public static Mesh CreateMesh(Vector2[] poly, float extrusion)
	{
		return null;
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x983614", Offset = "0x983614", VA = "0x983614")]
	private static Mesh SideExtrusion(Mesh mesh)
	{
		return null;
	}
}
[Token(Token = "0x2000073")]
public class ExportSubtree : MonoBehaviour
{
	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string destinationPath;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string Name;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool prefixResourcesWithName;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool skipResourceExport;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool skipInactiveParts;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x779BAC", Offset = "0x779BAC")]
	public bool exportNow;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x779BBC", Offset = "0x779BBC")]
	public bool testExportedNow;

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xABCCFC", Offset = "0xABCCFC", VA = "0xABCCFC")]
	public ExportSubtree()
	{
	}
}
[Token(Token = "0x2000074")]
public class ReactiveResourceRef : MonoBehaviour
{
	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private IDisposableHook _resource;

	[Token(Token = "0x6000279")]
	public static void StartUsing<T>(GameObject parent, IResources iResources, string relativePath, Action<T> onUpdated) where T : class
	{
	}

	[Token(Token = "0x600027A")]
	public void StartUsingResource<T>(IResources iResources, string relativePath, Action<T> onUpdated) where T : class
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xA553AC", Offset = "0xA553AC", VA = "0xA553AC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xA553BC", Offset = "0xA553BC", VA = "0xA553BC")]
	public ReactiveResourceRef()
	{
	}
}
[Token(Token = "0x2000075")]
public class RaycastTargetOnly : Graphic
{
	[Token(Token = "0x600027D")]
	[Address(RVA = "0xA53F24", Offset = "0xA53F24", VA = "0xA53F24", Slot = "29")]
	public override void SetMaterialDirty()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xA53F28", Offset = "0xA53F28", VA = "0xA53F28", Slot = "28")]
	public override void SetVerticesDirty()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xA53F2C", Offset = "0xA53F2C", VA = "0xA53F2C", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0xA53F48", Offset = "0xA53F48", VA = "0xA53F48")]
	public RaycastTargetOnly()
	{
	}
}
[Token(Token = "0x2000076")]
public class ReactiveDict : IEnumerable<KeyValuePair<string, object>>, IEnumerable
{
	[Token(Token = "0x200018B")]
	public class SubscriptionContext : IDisposable
	{
		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ReactiveDict Owner;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<IDisposable> _stuffToDispose;

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xA54F6C", Offset = "0xA54F6C", VA = "0xA54F6C")]
		public SubscriptionContext()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0xA54664", Offset = "0xA54664", VA = "0xA54664")]
		public SubscriptionContext(ReactiveDict from)
		{
		}

		[Token(Token = "0x600096B")]
		public void OnChange<T>(string key, Action<T> action)
		{
		}

		[Token(Token = "0x600096C")]
		public void Subscribe<T>(string key, Action<T> action)
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xA55208", Offset = "0xA55208", VA = "0xA55208")]
		public void SubscribeMultiple(List<string> keys, Action action, bool doInitiation = true, float throttleTime = 0f)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xA54F04", Offset = "0xA54F04", VA = "0xA54F04")]
		public void Add(IDisposable o)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0xA54FF4", Offset = "0xA54FF4", VA = "0xA54FF4")]
		public void DisposeAll()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xA553A8", Offset = "0xA553A8", VA = "0xA553A8", Slot = "4")]
		private void System.IDisposable.Dispose()
		{
		}
	}

	[Token(Token = "0x200018C")]
	public class MultiChangeResult : IDisposable
	{
		[Token(Token = "0x2000249")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7791CC", Offset = "0x7791CC")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000BEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MultiChangeResult <>4__this;

			[Token(Token = "0x4000BF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string key;

			[Token(Token = "0x6000BED")]
			[Address(RVA = "0xA54EFC", Offset = "0xA54EFC", VA = "0xA54EFC")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0xA551A4", Offset = "0xA551A4", VA = "0xA551A4")]
			internal void <AddDependency>b__0(object _)
			{
			}
		}

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _needSetOfChanges;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HashSet<string> Changes;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action ThrottledCallback;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SubscriptionContext _subscriptions;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _anyChanged;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IObservable<object> _combObs;

		[Token(Token = "0x6000971")]
		[Address(RVA = "0xA54E3C", Offset = "0xA54E3C", VA = "0xA54E3C")]
		public bool WasAnyChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xA54E44", Offset = "0xA54E44", VA = "0xA54E44")]
		public HashSet<string> GetChanges()
		{
			return null;
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0xA5427C", Offset = "0xA5427C", VA = "0xA5427C")]
		public void AddDependency(ReactiveDict owner, string key, bool doInitiation = true)
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0xA54488", Offset = "0xA54488", VA = "0xA54488")]
		public void Start(float throttleTime)
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xA541D4", Offset = "0xA541D4", VA = "0xA541D4")]
		public MultiChangeResult(bool needSetOfChanges)
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xA54FDC", Offset = "0xA54FDC", VA = "0xA54FDC")]
		public void StopAndDispose()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0xA5516C", Offset = "0xA5516C", VA = "0xA5516C", Slot = "4")]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0xA55184", Offset = "0xA55184", VA = "0xA55184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77C0EC", Offset = "0x77C0EC")]
		private void <Start>b__9_0(object _)
		{
		}
	}

	[Token(Token = "0x200018D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778C2C", Offset = "0x778C2C")]
	private sealed class <GetEnumerator>d__5 : IEnumerator<KeyValuePair<string, object>>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private KeyValuePair<string, object> <>2__current;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ReactiveDict <>4__this;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, ReactiveProperty<object>>.Enumerator <>7__wrap1;

		[Token(Token = "0x17000055")]
		private KeyValuePair<string, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0xA54D6C", Offset = "0xA54D6C", VA = "0xA54D6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, object>);
			}
		}

		[Token(Token = "0x17000056")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0xA54DD8", Offset = "0xA54DD8", VA = "0xA54DD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0xA54758", Offset = "0xA54758", VA = "0xA54758")]
		[DebuggerHidden]
		public <GetEnumerator>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0xA54B6C", Offset = "0xA54B6C", VA = "0xA54B6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0xA54BE0", Offset = "0xA54BE0", VA = "0xA54BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0xA54B88", Offset = "0xA54B88", VA = "0xA54B88")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0xA54D78", Offset = "0xA54D78", VA = "0xA54D78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200018E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778C3C", Offset = "0x778C3C")]
	private sealed class <>c__9<T>
	{
		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c__9<T> <>9;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<object, T> <>9__9_0;

		[Token(Token = "0x6000981")]
		public <>c__9()
		{
		}

		[Token(Token = "0x6000982")]
		internal T <GetValueAsObservable>b__9_0(object x)
		{
			return (T)null;
		}
	}

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<string, ReactiveProperty<object>> _dict;

	[Token(Token = "0x6000281")]
	[Address(RVA = "0xA53FB0", Offset = "0xA53FB0", VA = "0xA53FB0")]
	public MultiChangeResult listenToAnyChange(bool needSetOfChanges, float throttleTime, bool doInitiation, [Optional] List<string> keys)
	{
		return null;
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0xA54604", Offset = "0xA54604", VA = "0xA54604")]
	public SubscriptionContext createSubscriptionContext()
	{
		return null;
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0xA546E8", Offset = "0xA546E8", VA = "0xA546E8", Slot = "4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77ACB8", Offset = "0x77ACB8")]
	public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0xA54784", Offset = "0xA54784", VA = "0xA54784", Slot = "5")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xA54788", Offset = "0xA54788", VA = "0xA54788")]
	public void Add(string key, object o)
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xA54820", Offset = "0xA54820", VA = "0xA54820")]
	public void Remove(string key)
	{
	}

	[Token(Token = "0x6000287")]
	public IObservable<T> GetValueAsObservable<T>(string key)
	{
		return null;
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xA548CC", Offset = "0xA548CC", VA = "0xA548CC")]
	public ReactiveProperty<object> GetReactiveProperty(string key)
	{
		return null;
	}

	[Token(Token = "0x6000289")]
	public T GetValue<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xA5499C", Offset = "0xA5499C", VA = "0xA5499C")]
	public object GetValueAsObject(string key)
	{
		return null;
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xA54A10", Offset = "0xA54A10", VA = "0xA54A10")]
	public void SetValue(string key, object obj)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xA54A94", Offset = "0xA54A94", VA = "0xA54A94")]
	public bool ContainsKey(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xA54AFC", Offset = "0xA54AFC", VA = "0xA54AFC")]
	public ReactiveDict()
	{
	}
}
[Token(Token = "0x2000077")]
public class ReactiveStruct : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200018F")]
	public class ValueUI
	{
		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Key;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Value;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public string PrevValue;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsNumber;

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xA56514", Offset = "0xA56514", VA = "0xA56514")]
		public ValueUI()
		{
		}
	}

	[Token(Token = "0x2000190")]
	public delegate void JsonSyncDelegate(string SynchronizeType, string SynchronizeGuid, string jsonstr);

	[Token(Token = "0x2000191")]
	public delegate void FastPropertySyncDelegate(string reactiveStructPrefix, string propertyName, object data);

	[Token(Token = "0x2000192")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778C4C", Offset = "0x778C4C")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ValueUI item;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ReactiveStruct <>4__this;

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xA55ED4", Offset = "0xA55ED4", VA = "0xA55ED4")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xA56D9C", Offset = "0xA56D9C", VA = "0xA56D9C")]
		internal void <OnEnable>b__0(object x)
		{
		}
	}

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string GlobalContextName;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, ReactiveStruct> _globalNameSpace;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<ValueUI> StartValues;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x779BCC", Offset = "0x779BCC")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x779BCC", Offset = "0x779BCC")]
	public bool Synchronize;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float SynchronizeThrottleTime;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string SynchronizeType;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x779C18", Offset = "0x779C18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x779C18", Offset = "0x779C18")]
	public bool PhotonSync;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string PhotonSyncPrefix;

	[NonSerialized]
	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool Synchronizing;

	[NonSerialized]
	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string SynchronizeGuid;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x779C64", Offset = "0x779C64")]
	public bool DebugInUnity;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool prevDebugInUnity;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<ValueUI> DebugValues;

	[NonSerialized]
	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static JsonSyncDelegate JsonSyncBackend;

	[NonSerialized]
	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static FastPropertySyncDelegate FastPropertySyncBackend;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ReactiveDict _dict;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ReactiveDict.MultiChangeResult _debugHook;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ReactiveDict.MultiChangeResult _syncHook;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ReactiveDict.SubscriptionContext _photonSyncCtx;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private HashSet<string> _emptyHashSet;

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xA553C4", Offset = "0xA553C4", VA = "0xA553C4")]
	public static Dictionary<string, ReactiveStruct> GetGlobalStructs()
	{
		return null;
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xA5542C", Offset = "0xA5542C", VA = "0xA5542C")]
	public static ReactiveDict GetGlobalDict(string name)
	{
		return null;
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xA554EC", Offset = "0xA554EC", VA = "0xA554EC")]
	public static ReactiveStruct GetGlobalStruct(string name)
	{
		return null;
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xA55A48", Offset = "0xA55A48", VA = "0xA55A48")]
	public ReactiveDict.SubscriptionContext createSubscriptionContext()
	{
		return null;
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xA555CC", Offset = "0xA555CC", VA = "0xA555CC")]
	public ReactiveDict GetDict()
	{
		return null;
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xA555F0", Offset = "0xA555F0", VA = "0xA555F0")]
	private void CheckDict()
	{
	}

	[Token(Token = "0x6000294")]
	public static IDisposable OnChangeGlobalValue<T>(string structName, string propertyName, Action<T> f)
	{
		return null;
	}

	[Token(Token = "0x6000295")]
	public static IObservable<T> ObserveGlobalValue<T>(string structName, string propertyName)
	{
		return null;
	}

	[Token(Token = "0x6000296")]
	public static T GetGlobalValue<T>(string structName, string propertyName)
	{
		return (T)null;
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xA55AB4", Offset = "0xA55AB4", VA = "0xA55AB4")]
	public static void SetGlobalValue(string structName, string propertyName, object value)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xA55C74", Offset = "0xA55C74", VA = "0xA55C74")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xA55EDC", Offset = "0xA55EDC", VA = "0xA55EDC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xA55FC0", Offset = "0xA55FC0", VA = "0xA55FC0")]
	private void Update()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xA56578", Offset = "0xA56578", VA = "0xA56578")]
	public ReactiveStruct()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xA566D4", Offset = "0xA566D4", VA = "0xA566D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AD1C", Offset = "0x77AD1C")]
	private void <Update>b__35_0()
	{
	}
}
[Token(Token = "0x2000078")]
public class UIFromCodeTest : MonoBehaviour
{
	[Token(Token = "0x2000193")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778C5C", Offset = "0x778C5C")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ReactiveProperty<float> radioSelection;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UIFromCodeTest <>4__this;

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x98F484", Offset = "0x98F484", VA = "0x98F484")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x98FBB0", Offset = "0x98FBB0", VA = "0x98FBB0")]
		internal void <CreateTestPanel>b__0(UIContext ui, string selection)
		{
		}
	}

	[Token(Token = "0x2000194")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778C6C", Offset = "0x778C6C")]
	private sealed class <>c__DisplayClass10_1
	{
		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UIContext ui;

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x991518", Offset = "0x991518", VA = "0x991518")]
		public <>c__DisplayClass10_1()
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x991528", Offset = "0x991528", VA = "0x991528")]
		internal void <CreateTestPanel>b__15(UIContext ctx, string str)
		{
		}
	}

	[Token(Token = "0x2000195")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778C7C", Offset = "0x778C7C")]
	private sealed class <>c__DisplayClass10_2
	{
		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject go;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action forceRefresh;

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x98FBA4", Offset = "0x98FBA4", VA = "0x98FBA4")]
		public <>c__DisplayClass10_2()
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x9915E8", Offset = "0x9915E8", VA = "0x9915E8")]
		internal void <CreateTestPanel>b__13()
		{
		}
	}

	[Token(Token = "0x2000196")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778C8C", Offset = "0x778C8C")]
	private sealed class <>c__DisplayClass10_3
	{
		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ReactiveCollection<string> col;

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x991520", Offset = "0x991520", VA = "0x991520")]
		public <>c__DisplayClass10_3()
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x991668", Offset = "0x991668", VA = "0x991668")]
		internal void <CreateTestPanel>b__14(int x)
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x99170C", Offset = "0x99170C", VA = "0x99170C")]
		internal void <CreateTestPanel>b__16(long x)
		{
		}
	}

	[Token(Token = "0x2000197")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778C9C", Offset = "0x778C9C")]
	private sealed class <>c__DisplayClass10_4
	{
		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string str;

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x9915E0", Offset = "0x9915E0", VA = "0x9915E0")]
		public <>c__DisplayClass10_4()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x9917B4", Offset = "0x9917B4", VA = "0x9917B4")]
		internal void <CreateTestPanel>b__17()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000198")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778CAC", Offset = "0x778CAC")]
	private sealed class <>c
	{
		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action <>9__10_1;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<float, string> <>9__10_2;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action <>9__10_3;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action <>9__10_4;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Action <>9__10_5;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action <>9__10_6;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Action <>9__10_7;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Action <>9__10_8;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Action <>9__10_9;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Action <>9__10_10;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Action <>9__10_12;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Action<UIContext, GameObject, Action> <>9__10_11;

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x98F55C", Offset = "0x98F55C", VA = "0x98F55C")]
		public <>c()
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x98F564", Offset = "0x98F564", VA = "0x98F564")]
		internal void <CreateTestPanel>b__10_1()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x98F5D0", Offset = "0x98F5D0", VA = "0x98F5D0")]
		internal string <CreateTestPanel>b__10_2(float val)
		{
			return null;
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x98F68C", Offset = "0x98F68C", VA = "0x98F68C")]
		internal void <CreateTestPanel>b__10_3()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x98F6F8", Offset = "0x98F6F8", VA = "0x98F6F8")]
		internal void <CreateTestPanel>b__10_4()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x98F764", Offset = "0x98F764", VA = "0x98F764")]
		internal void <CreateTestPanel>b__10_5()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x98F7D0", Offset = "0x98F7D0", VA = "0x98F7D0")]
		internal void <CreateTestPanel>b__10_6()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x98F83C", Offset = "0x98F83C", VA = "0x98F83C")]
		internal void <CreateTestPanel>b__10_7()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x98F8A8", Offset = "0x98F8A8", VA = "0x98F8A8")]
		internal void <CreateTestPanel>b__10_8()
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x98F914", Offset = "0x98F914", VA = "0x98F914")]
		internal void <CreateTestPanel>b__10_9()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x98F980", Offset = "0x98F980", VA = "0x98F980")]
		internal void <CreateTestPanel>b__10_10()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x98F9EC", Offset = "0x98F9EC", VA = "0x98F9EC")]
		internal void <CreateTestPanel>b__10_11(UIContext ctx, GameObject go, Action forceRefresh)
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x98FBAC", Offset = "0x98FBAC", VA = "0x98FBAC")]
		internal void <CreateTestPanel>b__10_12()
		{
		}
	}

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isLeft;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int width;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string overridePrefix;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject testHierarchy;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private UIContext _panel;

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x98EE2C", Offset = "0x98EE2C", VA = "0x98EE2C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x98EE58", Offset = "0x98EE58", VA = "0x98EE58")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x98EF68", Offset = "0x98EF68", VA = "0x98EF68")]
	private void Deactivate()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x98EF90", Offset = "0x98EF90", VA = "0x98EF90")]
	private static void IterateChildren(GameObject go, Action<GameObject> forEachChild)
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x98F210", Offset = "0x98F210", VA = "0x98F210")]
	private static bool HasChildren(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x98F244", Offset = "0x98F244", VA = "0x98F244")]
	private void CreateTestPanel()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x98F48C", Offset = "0x98F48C", VA = "0x98F48C")]
	public UIFromCodeTest()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x98F4F4", Offset = "0x98F4F4", VA = "0x98F4F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AD2C", Offset = "0x77AD2C")]
	private void <OnEnable>b__6_0(long _)
	{
	}
}
[Serializable]
[Token(Token = "0x2000079")]
public struct VRCButtonColorScheme
{
	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Color Disable;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color SelectedDisable;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color Normal;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool DarkenNormalHover;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Color Selected;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool DarkenSelectedHover;
}
[Token(Token = "0x200007A")]
public class AnimationClipData
{
	[Token(Token = "0x2000199")]
	public struct Keyframe
	{
		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float time;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float value;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float inTangent;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float outTangent;
	}

	[Token(Token = "0x200019A")]
	public class Curve
	{
		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string relativePath;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string propertyName;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string customScriptGuid;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int classId;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Keyframe[] keys;

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xD4F78C", Offset = "0xD4F78C", VA = "0xD4F78C")]
		public Curve()
		{
		}
	}

	[Token(Token = "0x200019B")]
	public class AnimParser
	{
		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimationClipData state_clip;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string[] state_lines;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int state_pos;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string state_path;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string state_attribute;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool state_skipcurve;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int state_classId;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string state_scriptGuid;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int state_classId_default;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string[] state_curvetargets;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Keyframe>[] state_keyframes;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool state_have_keyframe_data;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool state_have_curve_data;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Keyframe[] state_keyframe;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string[] separatingGuid;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string[] separatingStrings;

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xD4EA28", Offset = "0xD4EA28", VA = "0xD4EA28")]
		public void ParseToDestination(string anim, AnimationClipData dst)
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xD50054", Offset = "0xD50054", VA = "0xD50054")]
		private string NextLine()
		{
			return null;
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xD50238", Offset = "0xD50238", VA = "0xD50238")]
		private void BeginCurve()
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xD5038C", Offset = "0xD5038C", VA = "0xD5038C")]
		private void FlushKeyFrame()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xD500A4", Offset = "0xD500A4", VA = "0xD500A4")]
		private void FlushCurve()
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xD50BD0", Offset = "0xD50BD0", VA = "0xD50BD0")]
		private bool EOF()
		{
			return default(bool);
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xD505C0", Offset = "0xD505C0", VA = "0xD505C0")]
		private bool checkAndParse(string line, string prefix, ref Vector4 v4)
		{
			return default(bool);
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xD5047C", Offset = "0xD5047C", VA = "0xD5047C")]
		private bool checkAndParse(string line, string prefix, ref float f)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xD5032C", Offset = "0xD5032C", VA = "0xD5032C")]
		private bool prefixEquals(string s, string prefix)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xD4E728", Offset = "0xD4E728", VA = "0xD4E728")]
		public AnimParser()
		{
		}
	}

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Curve> curves;

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xD4E214", Offset = "0xD4E214", VA = "0xD4E214")]
	public static AnimationClipData LoadAnimation(byte[] filedata)
	{
		return null;
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xD4F454", Offset = "0xD4F454", VA = "0xD4F454")]
	public void ParseFromAnim(string anim)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xD4F4E4", Offset = "0xD4F4E4", VA = "0xD4F4E4")]
	public byte[] SaveBinary()
	{
		return null;
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xD4E380", Offset = "0xD4E380", VA = "0xD4E380")]
	public void LoadBinary(byte[] data)
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xD4F794", Offset = "0xD4F794", VA = "0xD4F794")]
	public Keyframe KeyframeConvertFromUnity(ref UnityEngine.Keyframe k)
	{
		return default(Keyframe);
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xD4F80C", Offset = "0xD4F80C", VA = "0xD4F80C")]
	public void FromAnimationClip(AnimationClip clip)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xD4F898", Offset = "0xD4F898", VA = "0xD4F898")]
	public UnityEngine.Keyframe KeyframeConvert(ref Keyframe k)
	{
		return default(UnityEngine.Keyframe);
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xD4F8B8", Offset = "0xD4F8B8", VA = "0xD4F8B8")]
	public AnimationClip CreateUnityAnimationClip([Optional] AnimationClip clip, [Optional] Func<string, string, int, Type> typeMapping)
	{
		return null;
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xD4E310", Offset = "0xD4E310", VA = "0xD4E310")]
	public AnimationClipData()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xD5003C", Offset = "0xD5003C", VA = "0xD5003C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AD3C", Offset = "0x77AD3C")]
	private UnityEngine.Keyframe <CreateUnityAnimationClip>b__10_0(Keyframe x)
	{
		return default(UnityEngine.Keyframe);
	}
}
[Token(Token = "0x200007B")]
public class DumpFramesToDisk : MonoBehaviour
{
	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Camera targetCamera;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int width;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int height;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool useStereoODS;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float stereoSeparationIPD;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool takeHiResShot;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int frame;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string realFolder;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string filename;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool dumping;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture _cubemap_left;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private RenderTexture _cubemap_right;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private RenderTexture _equirect;

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xABC378", Offset = "0xABC378", VA = "0xABC378")]
	public void BeginCapture([Optional] Camera cam)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xABC408", Offset = "0xABC408", VA = "0xABC408")]
	public void StopCapture()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xABC410", Offset = "0xABC410", VA = "0xABC410")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xABC4F0", Offset = "0xABC4F0", VA = "0xABC4F0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xABCB10", Offset = "0xABCB10", VA = "0xABCB10")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0xABC884", Offset = "0xABC884", VA = "0xABC884")]
	private void RenderStereoODS(Camera camera, Texture2D outputTex)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xABCBC8", Offset = "0xABCBC8", VA = "0xABCBC8")]
	public DumpFramesToDisk()
	{
	}
}
[Token(Token = "0x200007C")]
public class KeyValueStore
{
	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<string, float> propertiesF;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, KeyValuePair<string, string>> propertiesS;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<float> _tmp;

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xE43E64", Offset = "0xE43E64", VA = "0xE43E64")]
	public bool ContainsKeyToFloat(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xE43ECC", Offset = "0xE43ECC", VA = "0xE43ECC")]
	public bool ContainsKeyToNonFloat(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xE43F34", Offset = "0xE43F34", VA = "0xE43F34")]
	public object GetAsType(string name, Type t)
	{
		return null;
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xE44A40", Offset = "0xE44A40", VA = "0xE44A40")]
	public float Get(string name, float defaultval)
	{
		return default(float);
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xE44390", Offset = "0xE44390", VA = "0xE44390")]
	public string Get(string name, string defaultval)
	{
		return null;
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xE44AD4", Offset = "0xE44AD4", VA = "0xE44AD4")]
	public string Get(string name, out string meta)
	{
		return null;
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xE44418", Offset = "0xE44418", VA = "0xE44418")]
	public bool Get(string name, bool defaultval)
	{
		return default(bool);
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xE444AC", Offset = "0xE444AC", VA = "0xE444AC")]
	public int Get(string name, int defaultval)
	{
		return default(int);
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xE44C10", Offset = "0xE44C10", VA = "0xE44C10")]
	public void AddProperty(string name, float val)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xE44CB8", Offset = "0xE44CB8", VA = "0xE44CB8")]
	public void AddProperty(string name, bool val)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xE44D64", Offset = "0xE44D64", VA = "0xE44D64")]
	public void AddProperty(string name, string value, string meta = "")
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xE44E3C", Offset = "0xE44E3C", VA = "0xE44E3C")]
	public void ForEachTextProperty(Action<string, string, string> f)
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xE44F50", Offset = "0xE44F50", VA = "0xE44F50")]
	public void ForEachFloatProperty(Action<string, float> f)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xE45068", Offset = "0xE45068", VA = "0xE45068", Slot = "4")]
	public virtual void SaveData(BinaryWriter w)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xE4532C", Offset = "0xE4532C", VA = "0xE4532C", Slot = "5")]
	public virtual void LoadData(BinaryReader r)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xE44B74", Offset = "0xE44B74", VA = "0xE44B74")]
	private static int toInt(string s)
	{
		return default(int);
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xE45570", Offset = "0xE45570", VA = "0xE45570")]
	private static float toFloat(string s)
	{
		return default(float);
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xE4560C", Offset = "0xE4560C", VA = "0xE4560C")]
	private static string str(int i)
	{
		return null;
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xE45684", Offset = "0xE45684", VA = "0xE45684")]
	private static string str(float f)
	{
		return null;
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0xE456FC", Offset = "0xE456FC", VA = "0xE456FC")]
	public List<float> ParseFloatArray(string s)
	{
		return null;
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0xE44560", Offset = "0xE44560", VA = "0xE44560")]
	public Vector2 Get(string name, Vector2 def)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xE44688", Offset = "0xE44688", VA = "0xE44688")]
	public Vector3 Get(string name, Vector3 def)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xE447C8", Offset = "0xE447C8", VA = "0xE447C8")]
	public Vector4 Get(string name, Vector4 def)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xE44904", Offset = "0xE44904", VA = "0xE44904")]
	public Color Get(string name, Color def)
	{
		return default(Color);
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xE45884", Offset = "0xE45884", VA = "0xE45884")]
	public Quaternion Get(string name, Quaternion def)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xE459C0", Offset = "0xE459C0", VA = "0xE459C0")]
	public void AddProperty(string name, int v, string meta = "")
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xE45A50", Offset = "0xE45A50", VA = "0xE45A50")]
	public void AddProperty(string name, Vector2 v, string meta = "")
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xE45B10", Offset = "0xE45B10", VA = "0xE45B10")]
	public void AddProperty(string name, Vector3 v, string meta = "")
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xE45CF4", Offset = "0xE45CF4", VA = "0xE45CF4")]
	public void AddProperty(string name, Vector4 v, string meta = "")
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xE45F3C", Offset = "0xE45F3C", VA = "0xE45F3C")]
	public void AddProperty(string name, Color col, string meta = "")
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xE46184", Offset = "0xE46184", VA = "0xE46184")]
	public void AddProperty(string name, Quaternion q, string meta = "")
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xE463CC", Offset = "0xE463CC", VA = "0xE463CC")]
	public void AddPropertyAsJson(string name, string json)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xE46434", Offset = "0xE46434", VA = "0xE46434")]
	public KeyValueStore()
	{
	}
}
[Token(Token = "0x200007D")]
public static class DDS
{
	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xAB65FC", Offset = "0xAB65FC", VA = "0xAB65FC")]
	public static Texture2D LoadTexture(byte[] ddsBytes, bool readable = true)
	{
		return null;
	}
}
[Token(Token = "0x200007E")]
public class AutoSinePos : MonoBehaviour
{
	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool animating;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 speed;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 size;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 center;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool o_animating;

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xD513D4", Offset = "0xD513D4", VA = "0xD513D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xD513E8", Offset = "0xD513E8", VA = "0xD513E8")]
	private void InternalUpdate()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xD515B0", Offset = "0xD515B0", VA = "0xD515B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xD515B4", Offset = "0xD515B4", VA = "0xD515B4")]
	public AutoSinePos()
	{
	}
}
[Token(Token = "0x200007F")]
public class AutoSpin : MonoBehaviour
{
	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 axis;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool resetOnEnable;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 initialRotation;

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xD51680", Offset = "0xD51680", VA = "0xD51680")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xD5174C", Offset = "0xD5174C", VA = "0xD5174C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xD517B4", Offset = "0xD517B4", VA = "0xD517B4")]
	public AutoSpin()
	{
	}
}
[Token(Token = "0x2000080")]
public class AutoWobble : MonoBehaviour
{
	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 speed;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 amount;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 rotation;

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xD51870", Offset = "0xD51870", VA = "0xD51870")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xD519F0", Offset = "0xD519F0", VA = "0xD519F0")]
	public AutoWobble()
	{
	}
}
[Token(Token = "0x2000081")]
public class SoftPrefab
{
	[Token(Token = "0x200019C")]
	public class Object : KeyValueStore
	{
		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object src;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string type;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int parentId;

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xA63C50", Offset = "0xA63C50", VA = "0xA63C50", Slot = "4")]
		public override void SaveData(BinaryWriter w)
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xA63CB4", Offset = "0xA63CB4", VA = "0xA63CB4", Slot = "5")]
		public override void LoadData(BinaryReader r)
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xA5D870", Offset = "0xA5D870", VA = "0xA5D870")]
		public Object()
		{
		}
	}

	[Token(Token = "0x200019D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778CBC", Offset = "0x778CBC")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material[] materials;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<Component, Material[]> setData;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Component comp;

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xA5EB54", Offset = "0xA5EB54", VA = "0xA5EB54")]
		public <>c__DisplayClass23_0()
		{
		}
	}

	[Token(Token = "0x200019E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778CCC", Offset = "0x778CCC")]
	private sealed class <>c__DisplayClass23_1
	{
		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int matRefId;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass23_0 CS$<>8__locals1;

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xA5EB5C", Offset = "0xA5EB5C", VA = "0xA5EB5C")]
		public <>c__DisplayClass23_1()
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xA63998", Offset = "0xA63998", VA = "0xA63998")]
		internal void <SetupMaterials>b__0(MaterialResource mat)
		{
		}
	}

	[Token(Token = "0x200019F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778CDC", Offset = "0x778CDC")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<Component, Material> setData;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Component comp;

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xA61FD8", Offset = "0xA61FD8", VA = "0xA61FD8")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xA63A6C", Offset = "0xA63A6C", VA = "0xA63A6C")]
		internal void <ComponentMemberSerialization>b__30(MaterialResource mat)
		{
		}
	}

	[Token(Token = "0x20001A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778CEC", Offset = "0x778CEC")]
	private sealed class <>c__DisplayClass35_1
	{
		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<Component, Texture2D> setData;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Component comp;

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xA62120", Offset = "0xA62120", VA = "0xA62120")]
		public <>c__DisplayClass35_1()
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xA63AE0", Offset = "0xA63AE0", VA = "0xA63AE0")]
		internal void <ComponentMemberSerialization>b__31(TextureResource tex)
		{
		}
	}

	[Token(Token = "0x20001A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778CFC", Offset = "0x778CFC")]
	private sealed class <>c__DisplayClass35_2
	{
		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<Component, Mesh> setData;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Component comp;

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xA62268", Offset = "0xA62268", VA = "0xA62268")]
		public <>c__DisplayClass35_2()
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xA63B54", Offset = "0xA63B54", VA = "0xA63B54")]
		internal void <ComponentMemberSerialization>b__32(MeshResource mesh)
		{
		}
	}

	[Token(Token = "0x20001A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778D0C", Offset = "0x778D0C")]
	private sealed class <>c__DisplayClass35_3
	{
		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<Component, AnimationClip> setData;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Component comp;

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xA623B0", Offset = "0xA623B0", VA = "0xA623B0")]
		public <>c__DisplayClass35_3()
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0xA63BDC", Offset = "0xA63BDC", VA = "0xA63BDC")]
		internal void <ComponentMemberSerialization>b__33(AnimationResource anim)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001A3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778D1C", Offset = "0x778D1C")]
	private sealed class <>c
	{
		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_0;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_1;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_2;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_3;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_4;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_5;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_6;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_7;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_8;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_9;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_10;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_11;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_12;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_13;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_14;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_15;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_16;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_17;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_28;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> <>9__35_29;

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0xA627DC", Offset = "0xA627DC", VA = "0xA627DC")]
		public <>c()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0xA627E4", Offset = "0xA627E4", VA = "0xA627E4")]
		internal void <ComponentMemberSerialization>b__35_0(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0xA6288C", Offset = "0xA6288C", VA = "0xA6288C")]
		internal void <ComponentMemberSerialization>b__35_1(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xA62930", Offset = "0xA62930", VA = "0xA62930")]
		internal void <ComponentMemberSerialization>b__35_2(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xA62A14", Offset = "0xA62A14", VA = "0xA62A14")]
		internal void <ComponentMemberSerialization>b__35_3(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0xA62ACC", Offset = "0xA62ACC", VA = "0xA62ACC")]
		internal void <ComponentMemberSerialization>b__35_4(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xA62B80", Offset = "0xA62B80", VA = "0xA62B80")]
		internal void <ComponentMemberSerialization>b__35_5(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xA62C34", Offset = "0xA62C34", VA = "0xA62C34")]
		internal void <ComponentMemberSerialization>b__35_6(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0xA62CE8", Offset = "0xA62CE8", VA = "0xA62CE8")]
		internal void <ComponentMemberSerialization>b__35_7(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0xA62D9C", Offset = "0xA62D9C", VA = "0xA62D9C")]
		internal void <ComponentMemberSerialization>b__35_8(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0xA62E6C", Offset = "0xA62E6C", VA = "0xA62E6C")]
		internal void <ComponentMemberSerialization>b__35_9(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0xA62F1C", Offset = "0xA62F1C", VA = "0xA62F1C")]
		internal void <ComponentMemberSerialization>b__35_10(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0xA62FEC", Offset = "0xA62FEC", VA = "0xA62FEC")]
		internal void <ComponentMemberSerialization>b__35_11(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0xA6309C", Offset = "0xA6309C", VA = "0xA6309C")]
		internal void <ComponentMemberSerialization>b__35_12(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0xA6316C", Offset = "0xA6316C", VA = "0xA6316C")]
		internal void <ComponentMemberSerialization>b__35_13(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0xA6321C", Offset = "0xA6321C", VA = "0xA6321C")]
		internal void <ComponentMemberSerialization>b__35_14(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0xA632CC", Offset = "0xA632CC", VA = "0xA632CC")]
		internal void <ComponentMemberSerialization>b__35_15(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xA6337C", Offset = "0xA6337C", VA = "0xA6337C")]
		internal void <ComponentMemberSerialization>b__35_16(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xA6344C", Offset = "0xA6344C", VA = "0xA6344C")]
		internal void <ComponentMemberSerialization>b__35_17(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xA634FC", Offset = "0xA634FC", VA = "0xA634FC")]
		internal void <ComponentMemberSerialization>b__35_28(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xA6367C", Offset = "0xA6367C", VA = "0xA6367C")]
		internal void <ComponentMemberSerialization>b__35_29(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
		{
		}
	}

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool SkipResourceExport;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool SkipInactiveParts;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool PrefixResourcesWithName;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string OutFileName;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action<string, byte[]> _saveFile;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IResources _resources;

	[NonSerialized]
	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool UseAnimParserForExport;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Object> objects;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Dictionary<UnityEngine.Object, int> objToId;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Dictionary<string, UnityEngine.Object> _resourceProcessedForExport;

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xA5D6A0", Offset = "0xA5D6A0", VA = "0xA5D6A0", Slot = "4")]
	public virtual void SaveData(BinaryWriter w)
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xA5D774", Offset = "0xA5D774", VA = "0xA5D774", Slot = "5")]
	public virtual void LoadData(BinaryReader r)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xA5D8D8", Offset = "0xA5D8D8", VA = "0xA5D8D8")]
	public byte[] SaveBinary()
	{
		return null;
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xA5D958", Offset = "0xA5D958", VA = "0xA5D958")]
	public void LoadBinary(byte[] data)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xA5D9E8", Offset = "0xA5D9E8", VA = "0xA5D9E8")]
	public void Load(ResourceManager res, string relname)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xA5DA80", Offset = "0xA5DA80", VA = "0xA5DA80")]
	public Object AddGO(GameObject obj, string type, int parentId, [Optional] string name)
	{
		return null;
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xA5DB78", Offset = "0xA5DB78", VA = "0xA5DB78")]
	public Object AddComponent(Component comp, int parentId)
	{
		return null;
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xA5DC38", Offset = "0xA5DC38", VA = "0xA5DC38")]
	public void ExportSubtree(Transform t, Action<string, byte[]> saveFile)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xA5DCE8", Offset = "0xA5DCE8", VA = "0xA5DCE8")]
	public void ExportSubtreeRec(Transform t, int parentId = -1)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xA5E5A8", Offset = "0xA5E5A8", VA = "0xA5E5A8")]
	public int TransformToId(Transform t)
	{
		return default(int);
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xA5E630", Offset = "0xA5E630", VA = "0xA5E630")]
	public int ObjToId(UnityEngine.Object o)
	{
		return default(int);
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xA5E6B8", Offset = "0xA5E6B8", VA = "0xA5E6B8")]
	public string GetGlobalReference(UnityEngine.Object obj)
	{
		return null;
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xA5E538", Offset = "0xA5E538", VA = "0xA5E538")]
	public void SaveResource(string relpath, byte[] data)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xA5E974", Offset = "0xA5E974", VA = "0xA5E974")]
	public void SetupMaterials(string mats, Component comp, Action<Component, Material[]> setData)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xA5EB64", Offset = "0xA5EB64", VA = "0xA5EB64")]
	public string ExportMaterials(Material[] mats, UnityEngine.Object comp)
	{
		return null;
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xA5ED10", Offset = "0xA5ED10", VA = "0xA5ED10")]
	public bool FindUniqueNameAndCheckForProcessStatus(ref string relPath, string dot_ext, UnityEngine.Object o)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xA5EF28", Offset = "0xA5EF28", VA = "0xA5EF28")]
	public string TypeToExt(Type t)
	{
		return null;
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xA5EC94", Offset = "0xA5EC94", VA = "0xA5EC94")]
	public string ExportResource(UnityEngine.Object o, Component comp)
	{
		return null;
	}

	[Token(Token = "0x60002F5")]
	public T ReadReference<T>(string refstr, UnityReflectionWrapper.TypeInfo.Member member) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x60002F6")]
	public Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> ReadReferenceFuncs<T>() where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x60002F7")]
	public Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> ReadReferenceFunc<T>() where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xA5F0B4", Offset = "0xA5F0B4", VA = "0xA5F0B4")]
	public string StoreReference(UnityEngine.Object obj)
	{
		return null;
	}

	[Token(Token = "0x60002F9")]
	public Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> StoreReferenceFuncs<T>() where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x60002FA")]
	public Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> StoreReferenceFunc<T>() where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xA5F0EC", Offset = "0xA5F0EC", VA = "0xA5F0EC")]
	public Action<UnityReflectionWrapper.TypeInfo.Member, Component, KeyValueStore> ComponentMemberSerialization(Type t, bool isDeserializing)
	{
		return null;
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xA60ADC", Offset = "0xA60ADC", VA = "0xA60ADC")]
	public GameObject CreateUnityObjects(IResources resources)
	{
		return null;
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xA5EEB0", Offset = "0xA5EEB0", VA = "0xA5EEB0")]
	private static string str(int i)
	{
		return null;
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xA61C68", Offset = "0xA61C68", VA = "0xA61C68")]
	private static int atoi(string str)
	{
		return default(int);
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xA5E020", Offset = "0xA5E020", VA = "0xA5E020")]
	public void ExportData()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0xA61D04", Offset = "0xA61D04", VA = "0xA61D04")]
	public SoftPrefab()
	{
	}

	[Token(Token = "0x6000301")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AD4C", Offset = "0x77AD4C")]
	private void <ReadReferenceFuncs>b__30_0<T>(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj) where T : UnityEngine.Object
	{
	}

	[Token(Token = "0x6000302")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AD5C", Offset = "0x77AD5C")]
	private void <ReadReferenceFunc>b__31_0<T>(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj) where T : UnityEngine.Object
	{
	}

	[Token(Token = "0x6000303")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AD6C", Offset = "0x77AD6C")]
	private void <StoreReferenceFuncs>b__33_0<T>(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj) where T : UnityEngine.Object
	{
	}

	[Token(Token = "0x6000304")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AD7C", Offset = "0x77AD7C")]
	private void <StoreReferenceFunc>b__34_0<T>(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj) where T : UnityEngine.Object
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xA61DDC", Offset = "0xA61DDC", VA = "0xA61DDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AD8C", Offset = "0x77AD8C")]
	private void <ComponentMemberSerialization>b__35_18(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xA61E98", Offset = "0xA61E98", VA = "0xA61E98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AD9C", Offset = "0x77AD9C")]
	private void <ComponentMemberSerialization>b__35_19(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xA61FE0", Offset = "0xA61FE0", VA = "0xA61FE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77ADAC", Offset = "0x77ADAC")]
	private void <ComponentMemberSerialization>b__35_20(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xA62128", Offset = "0xA62128", VA = "0xA62128")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77ADBC", Offset = "0x77ADBC")]
	private void <ComponentMemberSerialization>b__35_21(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0xA62270", Offset = "0xA62270", VA = "0xA62270")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77ADCC", Offset = "0x77ADCC")]
	private void <ComponentMemberSerialization>b__35_22(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0xA623B8", Offset = "0xA623B8", VA = "0xA623B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77ADDC", Offset = "0x77ADDC")]
	private void <ComponentMemberSerialization>b__35_23(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0xA62488", Offset = "0xA62488", VA = "0xA62488")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77ADEC", Offset = "0x77ADEC")]
	private void <ComponentMemberSerialization>b__35_24(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0xA62544", Offset = "0xA62544", VA = "0xA62544")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77ADFC", Offset = "0x77ADFC")]
	private void <ComponentMemberSerialization>b__35_25(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0xA62600", Offset = "0xA62600", VA = "0xA62600")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AE0C", Offset = "0x77AE0C")]
	private void <ComponentMemberSerialization>b__35_26(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0xA626BC", Offset = "0xA626BC", VA = "0xA626BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AE1C", Offset = "0x77AE1C")]
	private void <ComponentMemberSerialization>b__35_27(UnityReflectionWrapper.TypeInfo.Member member, Component comp, KeyValueStore obj)
	{
	}
}
[Token(Token = "0x2000082")]
public static class UnityClassIds
{
	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<int, string> _unityClassIdToClassname;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, int> _unityClassnameToClassId;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Dictionary<Type, string> _unityTypeToStringId;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Dictionary<string, Type> _unityStringIdToType;

	[Token(Token = "0x600030F")]
	[Address(RVA = "0xD351F4", Offset = "0xD351F4", VA = "0xD351F4")]
	public static string TypeToId(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0xD36E9C", Offset = "0xD36E9C", VA = "0xD36E9C")]
	private static bool isDigitsOnly(string s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xD36F60", Offset = "0xD36F60", VA = "0xD36F60")]
	public static Type IdToType(string id)
	{
		return null;
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xD372EC", Offset = "0xD372EC", VA = "0xD372EC")]
	public static string IdToClassname(int id)
	{
		return null;
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xD35410", Offset = "0xD35410", VA = "0xD35410")]
	public static int ClassnameToId(string name)
	{
		return default(int);
	}
}
[Token(Token = "0x2000083")]
public static class UnityReflectionWrapper
{
	[Token(Token = "0x20001A4")]
	public class TypeInfo
	{
		[Token(Token = "0x200024A")]
		public class Member
		{
			[Token(Token = "0x4000BF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type Type;

			[Token(Token = "0x4000BF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type InternalType;

			[Token(Token = "0x4000BF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string Name;

			[Token(Token = "0x4000BF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object SetFunc;

			[Token(Token = "0x4000BF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object GetFunc;

			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0xD3E850", Offset = "0xD3E850", VA = "0xD3E850")]
			public Member()
			{
			}
		}

		[Token(Token = "0x200024B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7791DC", Offset = "0x7791DC")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000BF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PropertyInfo info;

			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0xD3E848", Offset = "0xD3E848", VA = "0xD3E848")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0xD3E860", Offset = "0xD3E860", VA = "0xD3E860")]
			internal void <Add>b__0(Component comp, float x)
			{
			}

			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0xD3E8F8", Offset = "0xD3E8F8", VA = "0xD3E8F8")]
			internal float <Add>b__1(Component comp)
			{
				return default(float);
			}

			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0xD3E98C", Offset = "0xD3E98C", VA = "0xD3E98C")]
			internal void <Add>b__2(Component comp, int x)
			{
			}

			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0xD3EA1C", Offset = "0xD3EA1C", VA = "0xD3EA1C")]
			internal int <Add>b__3(Component comp)
			{
				return default(int);
			}

			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0xD3EAB0", Offset = "0xD3EAB0", VA = "0xD3EAB0")]
			internal void <Add>b__4(Component comp, bool x)
			{
			}

			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0xD3EB40", Offset = "0xD3EB40", VA = "0xD3EB40")]
			internal bool <Add>b__5(Component comp)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0xD3EBD4", Offset = "0xD3EBD4", VA = "0xD3EBD4")]
			internal void <Add>b__6(Component comp, string x)
			{
			}

			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0xD3EBF0", Offset = "0xD3EBF0", VA = "0xD3EBF0")]
			internal string <Add>b__7(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0xD3EC74", Offset = "0xD3EC74", VA = "0xD3EC74")]
			internal void <Add>b__8(Component comp, Vector2 x)
			{
			}

			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0xD3ED08", Offset = "0xD3ED08", VA = "0xD3ED08")]
			internal Vector2 <Add>b__9(Component comp)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0xD3ED9C", Offset = "0xD3ED9C", VA = "0xD3ED9C")]
			internal void <Add>b__10(Component comp, Vector3 x)
			{
			}

			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0xD3EE48", Offset = "0xD3EE48", VA = "0xD3EE48")]
			internal Vector3 <Add>b__11(Component comp)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000BFD")]
			[Address(RVA = "0xD3EEE0", Offset = "0xD3EEE0", VA = "0xD3EEE0")]
			internal void <Add>b__12(Component comp, Vector4 x)
			{
			}

			[Token(Token = "0x6000BFE")]
			[Address(RVA = "0xD3EF94", Offset = "0xD3EF94", VA = "0xD3EF94")]
			internal Vector4 <Add>b__13(Component comp)
			{
				return default(Vector4);
			}

			[Token(Token = "0x6000BFF")]
			[Address(RVA = "0xD3F02C", Offset = "0xD3F02C", VA = "0xD3F02C")]
			internal void <Add>b__14(Component comp, Color x)
			{
			}

			[Token(Token = "0x6000C00")]
			[Address(RVA = "0xD3F0E0", Offset = "0xD3F0E0", VA = "0xD3F0E0")]
			internal Color <Add>b__15(Component comp)
			{
				return default(Color);
			}

			[Token(Token = "0x6000C01")]
			[Address(RVA = "0xD3F178", Offset = "0xD3F178", VA = "0xD3F178")]
			internal void <Add>b__16(Component comp, Quaternion x)
			{
			}

			[Token(Token = "0x6000C02")]
			[Address(RVA = "0xD3F22C", Offset = "0xD3F22C", VA = "0xD3F22C")]
			internal Quaternion <Add>b__17(Component comp)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000C03")]
			[Address(RVA = "0xD3F2C4", Offset = "0xD3F2C4", VA = "0xD3F2C4")]
			internal void <Add>b__18(Component comp, GameObject x)
			{
			}

			[Token(Token = "0x6000C04")]
			[Address(RVA = "0xD3F2E0", Offset = "0xD3F2E0", VA = "0xD3F2E0")]
			internal GameObject <Add>b__19(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C05")]
			[Address(RVA = "0xD3F364", Offset = "0xD3F364", VA = "0xD3F364")]
			internal void <Add>b__20(Component comp, Transform x)
			{
			}

			[Token(Token = "0x6000C06")]
			[Address(RVA = "0xD3F380", Offset = "0xD3F380", VA = "0xD3F380")]
			internal Transform <Add>b__21(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C07")]
			[Address(RVA = "0xD3F420", Offset = "0xD3F420", VA = "0xD3F420")]
			internal void <Add>b__22(Component comp, GameObject[] x)
			{
			}

			[Token(Token = "0x6000C08")]
			[Address(RVA = "0xD3F43C", Offset = "0xD3F43C", VA = "0xD3F43C")]
			internal GameObject[] <Add>b__23(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C09")]
			[Address(RVA = "0xD3F4CC", Offset = "0xD3F4CC", VA = "0xD3F4CC")]
			internal void <Add>b__24(Component comp, Transform[] x)
			{
			}

			[Token(Token = "0x6000C0A")]
			[Address(RVA = "0xD3F4E8", Offset = "0xD3F4E8", VA = "0xD3F4E8")]
			internal Transform[] <Add>b__25(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C0B")]
			[Address(RVA = "0xD3F578", Offset = "0xD3F578", VA = "0xD3F578")]
			internal void <Add>b__26(Component comp, MeshRenderer x)
			{
			}

			[Token(Token = "0x6000C0C")]
			[Address(RVA = "0xD3F594", Offset = "0xD3F594", VA = "0xD3F594")]
			internal MeshRenderer <Add>b__27(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C0D")]
			[Address(RVA = "0xD3F634", Offset = "0xD3F634", VA = "0xD3F634")]
			internal void <Add>b__28(Component comp, SkinnedMeshRenderer x)
			{
			}

			[Token(Token = "0x6000C0E")]
			[Address(RVA = "0xD3F650", Offset = "0xD3F650", VA = "0xD3F650")]
			internal SkinnedMeshRenderer <Add>b__29(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C0F")]
			[Address(RVA = "0xD3F6F0", Offset = "0xD3F6F0", VA = "0xD3F6F0")]
			internal void <Add>b__30(Component comp, MeshFilter x)
			{
			}

			[Token(Token = "0x6000C10")]
			[Address(RVA = "0xD3F70C", Offset = "0xD3F70C", VA = "0xD3F70C")]
			internal MeshFilter <Add>b__31(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C11")]
			[Address(RVA = "0xD3F790", Offset = "0xD3F790", VA = "0xD3F790")]
			internal void <Add>b__32(Component comp, Material[] x)
			{
			}

			[Token(Token = "0x6000C12")]
			[Address(RVA = "0xD3F7AC", Offset = "0xD3F7AC", VA = "0xD3F7AC")]
			internal Material[] <Add>b__33(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C13")]
			[Address(RVA = "0xD3F83C", Offset = "0xD3F83C", VA = "0xD3F83C")]
			internal void <Add>b__34(Component comp, Material x)
			{
			}

			[Token(Token = "0x6000C14")]
			[Address(RVA = "0xD3F858", Offset = "0xD3F858", VA = "0xD3F858")]
			internal Material <Add>b__35(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C15")]
			[Address(RVA = "0xD3F8F8", Offset = "0xD3F8F8", VA = "0xD3F8F8")]
			internal void <Add>b__36(Component comp, Texture2D x)
			{
			}

			[Token(Token = "0x6000C16")]
			[Address(RVA = "0xD3F914", Offset = "0xD3F914", VA = "0xD3F914")]
			internal Texture2D <Add>b__37(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C17")]
			[Address(RVA = "0xD3F998", Offset = "0xD3F998", VA = "0xD3F998")]
			internal void <Add>b__38(Component comp, Mesh x)
			{
			}

			[Token(Token = "0x6000C18")]
			[Address(RVA = "0xD3F9B4", Offset = "0xD3F9B4", VA = "0xD3F9B4")]
			internal Mesh <Add>b__39(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C19")]
			[Address(RVA = "0xD3FA38", Offset = "0xD3FA38", VA = "0xD3FA38")]
			internal void <Add>b__40(Component comp, AnimationClip x)
			{
			}

			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0xD3FA54", Offset = "0xD3FA54", VA = "0xD3FA54")]
			internal AnimationClip <Add>b__41(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C1B")]
			[Address(RVA = "0xD3FAD8", Offset = "0xD3FAD8", VA = "0xD3FAD8")]
			internal void <Add>b__42(Component comp, object x)
			{
			}

			[Token(Token = "0x6000C1C")]
			[Address(RVA = "0xD3FAF4", Offset = "0xD3FAF4", VA = "0xD3FAF4")]
			internal object <Add>b__43(Component comp)
			{
				return null;
			}
		}

		[Token(Token = "0x200024C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7791EC", Offset = "0x7791EC")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000BF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FieldInfo info;

			[Token(Token = "0x6000C1D")]
			[Address(RVA = "0xD3E858", Offset = "0xD3E858", VA = "0xD3E858")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000C1E")]
			[Address(RVA = "0xD3FB10", Offset = "0xD3FB10", VA = "0xD3FB10")]
			internal void <Add>b__0(Component comp, float x)
			{
			}

			[Token(Token = "0x6000C1F")]
			[Address(RVA = "0xD3FBA8", Offset = "0xD3FBA8", VA = "0xD3FBA8")]
			internal float <Add>b__1(Component comp)
			{
				return default(float);
			}

			[Token(Token = "0x6000C20")]
			[Address(RVA = "0xD3FC44", Offset = "0xD3FC44", VA = "0xD3FC44")]
			internal void <Add>b__2(Component comp, int x)
			{
			}

			[Token(Token = "0x6000C21")]
			[Address(RVA = "0xD3FCD4", Offset = "0xD3FCD4", VA = "0xD3FCD4")]
			internal int <Add>b__3(Component comp)
			{
				return default(int);
			}

			[Token(Token = "0x6000C22")]
			[Address(RVA = "0xD3FD70", Offset = "0xD3FD70", VA = "0xD3FD70")]
			internal void <Add>b__4(Component comp, bool x)
			{
			}

			[Token(Token = "0x6000C23")]
			[Address(RVA = "0xD3FE00", Offset = "0xD3FE00", VA = "0xD3FE00")]
			internal bool <Add>b__5(Component comp)
			{
				return default(bool);
			}

			[Token(Token = "0x6000C24")]
			[Address(RVA = "0xD3FE9C", Offset = "0xD3FE9C", VA = "0xD3FE9C")]
			internal void <Add>b__6(Component comp, string x)
			{
			}

			[Token(Token = "0x6000C25")]
			[Address(RVA = "0xD3FEB8", Offset = "0xD3FEB8", VA = "0xD3FEB8")]
			internal string <Add>b__7(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C26")]
			[Address(RVA = "0xD3FF44", Offset = "0xD3FF44", VA = "0xD3FF44")]
			internal void <Add>b__8(Component comp, Vector2 x)
			{
			}

			[Token(Token = "0x6000C27")]
			[Address(RVA = "0xD3FFD8", Offset = "0xD3FFD8", VA = "0xD3FFD8")]
			internal Vector2 <Add>b__9(Component comp)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000C28")]
			[Address(RVA = "0xD40074", Offset = "0xD40074", VA = "0xD40074")]
			internal void <Add>b__10(Component comp, Vector3 x)
			{
			}

			[Token(Token = "0x6000C29")]
			[Address(RVA = "0xD40120", Offset = "0xD40120", VA = "0xD40120")]
			internal Vector3 <Add>b__11(Component comp)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0xD401C0", Offset = "0xD401C0", VA = "0xD401C0")]
			internal void <Add>b__12(Component comp, Vector4 x)
			{
			}

			[Token(Token = "0x6000C2B")]
			[Address(RVA = "0xD40274", Offset = "0xD40274", VA = "0xD40274")]
			internal Vector4 <Add>b__13(Component comp)
			{
				return default(Vector4);
			}

			[Token(Token = "0x6000C2C")]
			[Address(RVA = "0xD40314", Offset = "0xD40314", VA = "0xD40314")]
			internal void <Add>b__14(Component comp, Color x)
			{
			}

			[Token(Token = "0x6000C2D")]
			[Address(RVA = "0xD403C8", Offset = "0xD403C8", VA = "0xD403C8")]
			internal Color <Add>b__15(Component comp)
			{
				return default(Color);
			}

			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0xD40468", Offset = "0xD40468", VA = "0xD40468")]
			internal void <Add>b__16(Component comp, Quaternion x)
			{
			}

			[Token(Token = "0x6000C2F")]
			[Address(RVA = "0xD4051C", Offset = "0xD4051C", VA = "0xD4051C")]
			internal Quaternion <Add>b__17(Component comp)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000C30")]
			[Address(RVA = "0xD405BC", Offset = "0xD405BC", VA = "0xD405BC")]
			internal void <Add>b__18(Component comp, GameObject x)
			{
			}

			[Token(Token = "0x6000C31")]
			[Address(RVA = "0xD405D8", Offset = "0xD405D8", VA = "0xD405D8")]
			internal GameObject <Add>b__19(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C32")]
			[Address(RVA = "0xD40664", Offset = "0xD40664", VA = "0xD40664")]
			internal void <Add>b__20(Component comp, Transform x)
			{
			}

			[Token(Token = "0x6000C33")]
			[Address(RVA = "0xD40680", Offset = "0xD40680", VA = "0xD40680")]
			internal Transform <Add>b__21(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C34")]
			[Address(RVA = "0xD40728", Offset = "0xD40728", VA = "0xD40728")]
			internal void <Add>b__22(Component comp, GameObject[] x)
			{
			}

			[Token(Token = "0x6000C35")]
			[Address(RVA = "0xD40744", Offset = "0xD40744", VA = "0xD40744")]
			internal GameObject[] <Add>b__23(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C36")]
			[Address(RVA = "0xD407DC", Offset = "0xD407DC", VA = "0xD407DC")]
			internal void <Add>b__24(Component comp, Transform[] x)
			{
			}

			[Token(Token = "0x6000C37")]
			[Address(RVA = "0xD407F8", Offset = "0xD407F8", VA = "0xD407F8")]
			internal Transform[] <Add>b__25(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C38")]
			[Address(RVA = "0xD40890", Offset = "0xD40890", VA = "0xD40890")]
			internal void <Add>b__26(Component comp, MeshRenderer x)
			{
			}

			[Token(Token = "0x6000C39")]
			[Address(RVA = "0xD408AC", Offset = "0xD408AC", VA = "0xD408AC")]
			internal MeshRenderer <Add>b__27(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C3A")]
			[Address(RVA = "0xD40954", Offset = "0xD40954", VA = "0xD40954")]
			internal void <Add>b__28(Component comp, SkinnedMeshRenderer x)
			{
			}

			[Token(Token = "0x6000C3B")]
			[Address(RVA = "0xD40970", Offset = "0xD40970", VA = "0xD40970")]
			internal SkinnedMeshRenderer <Add>b__29(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C3C")]
			[Address(RVA = "0xD40A18", Offset = "0xD40A18", VA = "0xD40A18")]
			internal void <Add>b__30(Component comp, MeshFilter x)
			{
			}

			[Token(Token = "0x6000C3D")]
			[Address(RVA = "0xD40A34", Offset = "0xD40A34", VA = "0xD40A34")]
			internal MeshFilter <Add>b__31(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0xD40AC0", Offset = "0xD40AC0", VA = "0xD40AC0")]
			internal void <Add>b__32(Component comp, Material[] x)
			{
			}

			[Token(Token = "0x6000C3F")]
			[Address(RVA = "0xD40ADC", Offset = "0xD40ADC", VA = "0xD40ADC")]
			internal Material[] <Add>b__33(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C40")]
			[Address(RVA = "0xD40B74", Offset = "0xD40B74", VA = "0xD40B74")]
			internal void <Add>b__34(Component comp, Material x)
			{
			}

			[Token(Token = "0x6000C41")]
			[Address(RVA = "0xD40B90", Offset = "0xD40B90", VA = "0xD40B90")]
			internal Material <Add>b__35(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C42")]
			[Address(RVA = "0xD40C38", Offset = "0xD40C38", VA = "0xD40C38")]
			internal void <Add>b__36(Component comp, Texture2D x)
			{
			}

			[Token(Token = "0x6000C43")]
			[Address(RVA = "0xD40C54", Offset = "0xD40C54", VA = "0xD40C54")]
			internal Texture2D <Add>b__37(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C44")]
			[Address(RVA = "0xD40CE0", Offset = "0xD40CE0", VA = "0xD40CE0")]
			internal void <Add>b__38(Component comp, Mesh x)
			{
			}

			[Token(Token = "0x6000C45")]
			[Address(RVA = "0xD40CFC", Offset = "0xD40CFC", VA = "0xD40CFC")]
			internal Mesh <Add>b__39(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C46")]
			[Address(RVA = "0xD40D88", Offset = "0xD40D88", VA = "0xD40D88")]
			internal void <Add>b__40(Component comp, AnimationClip x)
			{
			}

			[Token(Token = "0x6000C47")]
			[Address(RVA = "0xD40DA4", Offset = "0xD40DA4", VA = "0xD40DA4")]
			internal AnimationClip <Add>b__41(Component comp)
			{
				return null;
			}

			[Token(Token = "0x6000C48")]
			[Address(RVA = "0xD40E30", Offset = "0xD40E30", VA = "0xD40E30")]
			internal void <Add>b__42(Component comp, object x)
			{
			}

			[Token(Token = "0x6000C49")]
			[Address(RVA = "0xD40E4C", Offset = "0xD40E4C", VA = "0xD40E4C")]
			internal object <Add>b__43(Component comp)
			{
				return null;
			}
		}

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Member> members;

		[Token(Token = "0x60009D6")]
		public void Add<T>(string name, Action<Component, T> _set, Func<Component, T> _get)
		{
		}

		[Token(Token = "0x60009D7")]
		public static void AddFuncs<T>(Member m, Action<Component, T> setf, Func<Component, T> getf)
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xD3BDC4", Offset = "0xD3BDC4", VA = "0xD3BDC4")]
		public void Add(PropertyInfo info)
		{
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xD3ABFC", Offset = "0xD3ABFC", VA = "0xD3ABFC")]
		public void Add(FieldInfo info)
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xD3AB8C", Offset = "0xD3AB8C", VA = "0xD3AB8C")]
		public TypeInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001A5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778D2C", Offset = "0x778D2C")]
	private sealed class <>c
	{
		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Component, bool> <>9__3_0;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<Component, bool> <>9__3_1;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action<Component, Material[]> <>9__3_2;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<Component, Material[]> <>9__3_3;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Action<Component, bool> <>9__3_4;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Func<Component, bool> <>9__3_5;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Action<Component, Mesh> <>9__3_6;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Func<Component, Mesh> <>9__3_7;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Action<Component, Transform> <>9__3_8;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Func<Component, Transform> <>9__3_9;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Action<Component, Transform[]> <>9__3_10;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Func<Component, Transform[]> <>9__3_11;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Action<Component, Material[]> <>9__3_12;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static Func<Component, Material[]> <>9__3_13;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static Action<Component, Mesh> <>9__3_14;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static Func<Component, Mesh> <>9__3_15;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static Action<Component, bool> <>9__3_16;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static Func<Component, bool> <>9__3_17;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static Action<Component, AnimationClip> <>9__3_18;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static Func<Component, AnimationClip> <>9__3_19;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static Action<Component, bool> <>9__3_20;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static Func<Component, bool> <>9__3_21;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static Action<Component, bool> <>9__3_22;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static Func<Component, bool> <>9__3_23;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static Action<Component, AnimationClip> <>9__3_24;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static Func<Component, AnimationClip> <>9__3_25;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static Action<Component, bool> <>9__3_26;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static Func<Component, bool> <>9__3_27;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static Action<Component, bool> <>9__3_28;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static Func<Component, bool> <>9__3_29;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public static Action<Component, Vector3> <>9__3_30;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static Func<Component, Vector3> <>9__3_31;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static Action<Component, Vector3> <>9__3_32;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static Func<Component, Vector3> <>9__3_33;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public static Action<Component, bool> <>9__3_34;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public static Func<Component, bool> <>9__3_35;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public static Action<Component, Vector3> <>9__3_36;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public static Func<Component, Vector3> <>9__3_37;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public static Action<Component, float> <>9__3_38;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public static Func<Component, float> <>9__3_39;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public static Func<object, bool> <>9__3_40;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public static Func<object, bool> <>9__3_41;

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xD3D064", Offset = "0xD3D064", VA = "0xD3D064")]
		public <>c()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xD3D06C", Offset = "0xD3D06C", VA = "0xD3D06C")]
		internal void <GetTypeInfoInternal>b__3_0(Component comp, bool v)
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xD3D108", Offset = "0xD3D108", VA = "0xD3D108")]
		internal bool <GetTypeInfoInternal>b__3_1(Component comp)
		{
			return default(bool);
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xD3D194", Offset = "0xD3D194", VA = "0xD3D194")]
		internal void <GetTypeInfoInternal>b__3_2(Component comp, Material[] v)
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xD3D230", Offset = "0xD3D230", VA = "0xD3D230")]
		internal Material[] <GetTypeInfoInternal>b__3_3(Component comp)
		{
			return null;
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xD3D2BC", Offset = "0xD3D2BC", VA = "0xD3D2BC")]
		internal void <GetTypeInfoInternal>b__3_4(Component comp, bool v)
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xD3D358", Offset = "0xD3D358", VA = "0xD3D358")]
		internal bool <GetTypeInfoInternal>b__3_5(Component comp)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xD3D3E4", Offset = "0xD3D3E4", VA = "0xD3D3E4")]
		internal void <GetTypeInfoInternal>b__3_6(Component comp, Mesh v)
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xD3D480", Offset = "0xD3D480", VA = "0xD3D480")]
		internal Mesh <GetTypeInfoInternal>b__3_7(Component comp)
		{
			return null;
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xD3D50C", Offset = "0xD3D50C", VA = "0xD3D50C")]
		internal void <GetTypeInfoInternal>b__3_8(Component comp, Transform v)
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xD3D5A8", Offset = "0xD3D5A8", VA = "0xD3D5A8")]
		internal Transform <GetTypeInfoInternal>b__3_9(Component comp)
		{
			return null;
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xD3D634", Offset = "0xD3D634", VA = "0xD3D634")]
		internal void <GetTypeInfoInternal>b__3_10(Component comp, Transform[] v)
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xD3D6D0", Offset = "0xD3D6D0", VA = "0xD3D6D0")]
		internal Transform[] <GetTypeInfoInternal>b__3_11(Component comp)
		{
			return null;
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xD3D75C", Offset = "0xD3D75C", VA = "0xD3D75C")]
		internal void <GetTypeInfoInternal>b__3_12(Component comp, Material[] v)
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xD3D7F8", Offset = "0xD3D7F8", VA = "0xD3D7F8")]
		internal Material[] <GetTypeInfoInternal>b__3_13(Component comp)
		{
			return null;
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xD3D884", Offset = "0xD3D884", VA = "0xD3D884")]
		internal void <GetTypeInfoInternal>b__3_14(Component comp, Mesh v)
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xD3D900", Offset = "0xD3D900", VA = "0xD3D900")]
		internal Mesh <GetTypeInfoInternal>b__3_15(Component comp)
		{
			return null;
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xD3D96C", Offset = "0xD3D96C", VA = "0xD3D96C")]
		internal void <GetTypeInfoInternal>b__3_16(Component comp, bool v)
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xD3D9EC", Offset = "0xD3D9EC", VA = "0xD3D9EC")]
		internal bool <GetTypeInfoInternal>b__3_17(Component comp)
		{
			return default(bool);
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xD3DA58", Offset = "0xD3DA58", VA = "0xD3DA58")]
		internal void <GetTypeInfoInternal>b__3_18(Component comp, AnimationClip v)
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xD3DAD4", Offset = "0xD3DAD4", VA = "0xD3DAD4")]
		internal AnimationClip <GetTypeInfoInternal>b__3_19(Component comp)
		{
			return null;
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xD3DB40", Offset = "0xD3DB40", VA = "0xD3DB40")]
		internal void <GetTypeInfoInternal>b__3_20(Component comp, bool v)
		{
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xD3DBC0", Offset = "0xD3DBC0", VA = "0xD3DBC0")]
		internal bool <GetTypeInfoInternal>b__3_21(Component comp)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xD3DC2C", Offset = "0xD3DC2C", VA = "0xD3DC2C")]
		internal void <GetTypeInfoInternal>b__3_22(Component comp, bool v)
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0xD3DCC8", Offset = "0xD3DCC8", VA = "0xD3DCC8")]
		internal bool <GetTypeInfoInternal>b__3_23(Component comp)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xD3DD54", Offset = "0xD3DD54", VA = "0xD3DD54")]
		internal void <GetTypeInfoInternal>b__3_24(Component comp, AnimationClip v)
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0xD3DD58", Offset = "0xD3DD58", VA = "0xD3DD58")]
		internal AnimationClip <GetTypeInfoInternal>b__3_25(Component comp)
		{
			return null;
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xD3E004", Offset = "0xD3E004", VA = "0xD3E004")]
		internal void <GetTypeInfoInternal>b__3_26(Component comp, bool v)
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xD3E008", Offset = "0xD3E008", VA = "0xD3E008")]
		internal bool <GetTypeInfoInternal>b__3_27(Component comp)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xD3E010", Offset = "0xD3E010", VA = "0xD3E010")]
		internal void <GetTypeInfoInternal>b__3_28(Component comp, bool v)
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0xD3E0AC", Offset = "0xD3E0AC", VA = "0xD3E0AC")]
		internal bool <GetTypeInfoInternal>b__3_29(Component comp)
		{
			return default(bool);
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0xD3E138", Offset = "0xD3E138", VA = "0xD3E138")]
		internal void <GetTypeInfoInternal>b__3_30(Component comp, Vector3 v)
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0xD3E1EC", Offset = "0xD3E1EC", VA = "0xD3E1EC")]
		internal Vector3 <GetTypeInfoInternal>b__3_31(Component comp)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xD3E278", Offset = "0xD3E278", VA = "0xD3E278")]
		internal void <GetTypeInfoInternal>b__3_32(Component comp, Vector3 v)
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xD3E32C", Offset = "0xD3E32C", VA = "0xD3E32C")]
		internal Vector3 <GetTypeInfoInternal>b__3_33(Component comp)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0xD3E3B8", Offset = "0xD3E3B8", VA = "0xD3E3B8")]
		internal void <GetTypeInfoInternal>b__3_34(Component comp, bool v)
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0xD3E454", Offset = "0xD3E454", VA = "0xD3E454")]
		internal bool <GetTypeInfoInternal>b__3_35(Component comp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0xD3E4E0", Offset = "0xD3E4E0", VA = "0xD3E4E0")]
		internal void <GetTypeInfoInternal>b__3_36(Component comp, Vector3 v)
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0xD3E594", Offset = "0xD3E594", VA = "0xD3E594")]
		internal Vector3 <GetTypeInfoInternal>b__3_37(Component comp)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0xD3E620", Offset = "0xD3E620", VA = "0xD3E620")]
		internal void <GetTypeInfoInternal>b__3_38(Component comp, float v)
		{
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0xD3E6BC", Offset = "0xD3E6BC", VA = "0xD3E6BC")]
		internal float <GetTypeInfoInternal>b__3_39(Component comp)
		{
			return default(float);
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0xD3E748", Offset = "0xD3E748", VA = "0xD3E748")]
		internal bool <GetTypeInfoInternal>b__3_40(object attr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0xD3E7C8", Offset = "0xD3E7C8", VA = "0xD3E7C8")]
		internal bool <GetTypeInfoInternal>b__3_41(object attr)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<Type, TypeInfo> _cache;

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xD38D74", Offset = "0xD38D74", VA = "0xD38D74")]
	public static TypeInfo GetTypeInfo(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xD38E30", Offset = "0xD38E30", VA = "0xD38E30")]
	private static TypeInfo GetTypeInfoInternal(Type type)
	{
		return null;
	}
}
[Token(Token = "0x2000084")]
public static class spUnityGameObjectExt
{
	[Token(Token = "0x6000318")]
	public static T GetOrCreateComp<T>(this GameObject gameObject) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000319")]
	public static INTERFACE_T GetInterfaceWithFallback<INTERFACE_T, DEFAULT_T>(this GameObject gameObject) where DEFAULT_T : Component, INTERFACE_T
	{
		return (INTERFACE_T)null;
	}
}
[Token(Token = "0x2000085")]
public class WASDRecorder : MonoBehaviour
{
	[Token(Token = "0x20001A6")]
	private class RecordedFrame
	{
		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 pos;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rot;

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0xD42210", Offset = "0xD42210", VA = "0xD42210")]
		public RecordedFrame(Vector3 _pos, Quaternion _rot)
		{
		}
	}

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float smoothing;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float mainSpeed;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float shiftMul;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float maxShift;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float mouseRotSens;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float mousePanSens;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float mouseWheelSens;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool mousePanReverse;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x779C74", Offset = "0x779C74")]
	public bool SupportRecording;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x779C84", Offset = "0x779C84")]
	public float framerate;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject inactivate1;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject inactivate2;

	[NonSerialized]
	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public Vector3 LastMouseCursorPosInWorldSpace;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector3 _prevMousePos;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3 _prevMousePos2;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float totalRun;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool wasMoved;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Vector3 _pos;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool wasRotated;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Vector3 _eulerRot;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private PositionSmoother _smoothP;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private RotationSmoother _smoothR;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float _panDragMul;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool recording;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
	private bool playing;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float _lastPlayOrRecord;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private List<RecordedFrame> _frames;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int _curFrame;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private long _configTimestamp;

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xD40E70", Offset = "0xD40E70", VA = "0xD40E70")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xD40E7C", Offset = "0xD40E7C", VA = "0xD40E7C")]
	private void Stop()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xD40FA4", Offset = "0xD40FA4", VA = "0xD40FA4")]
	private string GetConfigPath()
	{
		return null;
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xD40FF8", Offset = "0xD40FF8", VA = "0xD40FF8")]
	private void Update()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xD42280", Offset = "0xD42280", VA = "0xD42280")]
	private Vector3 GetVectorFromKeys()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xD425BC", Offset = "0xD425BC", VA = "0xD425BC")]
	public WASDRecorder()
	{
	}
}
namespace UIFromCode
{
	[Token(Token = "0x2000086")]
	public interface IReactiveBindingImpl<T>
	{
		[Token(Token = "0x6000320")]
		bool HasReactiveConnection();

		[Token(Token = "0x6000321")]
		T GetValue();

		[Token(Token = "0x6000322")]
		void SetValue(T val);

		[Token(Token = "0x6000323")]
		void StartToListen(Action<T> callback);

		[Token(Token = "0x6000324")]
		void StopListening();
	}
	[Token(Token = "0x2000087")]
	public interface IChangeBinding
	{
		[Token(Token = "0x6000325")]
		void ChangeBinding(UIBinding binding);
	}
	[Token(Token = "0x2000088")]
	public class ReactiveStructBinding<T> : IChangeBinding, IDisposable
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Binding;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _started;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UIBinding _bindingSpec;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IReactiveBindingImpl<T> _impl;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<T> _curAction;

		[Token(Token = "0x1700000A")]
		public T Value
		{
			[Token(Token = "0x6000326")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000327")]
			set
			{
			}
		}

		[Token(Token = "0x6000328")]
		public bool HasReactiveConnection()
		{
			return default(bool);
		}

		[Token(Token = "0x6000329")]
		private void validateImpl()
		{
		}

		[Token(Token = "0x600032A")]
		public void ChangeBinding(UIBinding binding)
		{
		}

		[Token(Token = "0x600032B")]
		public void StartToListen(Action<T> callback)
		{
		}

		[Token(Token = "0x600032C")]
		public void StopListening()
		{
		}

		[Token(Token = "0x600032D")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600032E")]
		public ReactiveStructBinding()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class RxReactivePropertyBindingImpl<T, TSOURCE> : IReactiveBindingImpl<T>
	{
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ReactiveProperty<T> _propt;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ReactiveProperty<TSOURCE> _propObj;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<T> _clientCallback;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IDisposable _subscription;

		[Token(Token = "0x600032F")]
		public T _convertToT(TSOURCE val)
		{
			return (T)null;
		}

		[Token(Token = "0x6000330")]
		public void _clientCallbackWithConversion(TSOURCE val)
		{
		}

		[Token(Token = "0x6000331")]
		public RxReactivePropertyBindingImpl(object reactiveProperty)
		{
		}

		[Token(Token = "0x6000332")]
		public bool HasReactiveConnection()
		{
			return default(bool);
		}

		[Token(Token = "0x6000333")]
		public T GetValue()
		{
			return (T)null;
		}

		[Token(Token = "0x6000334")]
		public void SetValue(T val)
		{
		}

		[Token(Token = "0x6000335")]
		public void StartToListen(Action<T> callback)
		{
		}

		[Token(Token = "0x6000336")]
		public void StopListening()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class ReactiveDictBindingImpl<T> : IReactiveBindingImpl<T>
	{
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ReactiveDict.SubscriptionContext _ctx;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ReactiveDict _rs;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string _propertyName;

		[Token(Token = "0x6000337")]
		public ReactiveDictBindingImpl(string unityEditorBinding, string bindingFromCode, ReactiveDict rs)
		{
		}

		[Token(Token = "0x6000338")]
		public bool HasReactiveConnection()
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		public T GetValue()
		{
			return (T)null;
		}

		[Token(Token = "0x600033A")]
		public void SetValue(T val)
		{
		}

		[Token(Token = "0x600033B")]
		public void StartToListen(Action<T> callback)
		{
		}

		[Token(Token = "0x600033C")]
		public void StopListening()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public static class DisposableExtension
	{
		[Token(Token = "0x600033D")]
		public static T AddTo<T>(this T disposable, UIContext uiContext) where T : IDisposable
		{
			return (T)null;
		}
	}
	[Token(Token = "0x200008C")]
	public struct Range
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Min;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Middle;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Max;

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x9854FC", Offset = "0x9854FC", VA = "0x9854FC")]
		public Range(float max)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x98551C", Offset = "0x98551C", VA = "0x98551C")]
		public Range(float min, float max)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x985510", Offset = "0x985510", VA = "0x985510")]
		public Range(float min, float middle, float max)
		{
		}
	}
	[Token(Token = "0x200008D")]
	public struct UIBinding
	{
		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ReactiveDict reactiveDict;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public object reactiveProperty;

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x985534", Offset = "0x985534", VA = "0x985534")]
		public UIBinding(string _name, [Optional] ReactiveDict dict)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x985540", Offset = "0x985540", VA = "0x985540")]
		public UIBinding(object _reactiveProperty)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x985718", Offset = "0x985718", VA = "0x985718")]
		public bool Defined()
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x985758", Offset = "0x985758", VA = "0x985758")]
		public static implicit operator UIBinding(string name)
		{
			return default(UIBinding);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x984CB8", Offset = "0x984CB8", VA = "0x984CB8")]
		public static implicit operator UIBinding(ReactiveProperty<string> str)
		{
			return default(UIBinding);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x985764", Offset = "0x985764", VA = "0x985764")]
		public static implicit operator UIBinding(ReactiveProperty<float> f)
		{
			return default(UIBinding);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x985778", Offset = "0x985778", VA = "0x985778")]
		public static implicit operator UIBinding(ReactiveProperty<bool> b)
		{
			return default(UIBinding);
		}
	}
	[Token(Token = "0x200008E")]
	public interface IUIView
	{
		[Token(Token = "0x1700000B")]
		GameObject gameObject
		{
			[Token(Token = "0x6000349")]
			get;
		}

		[Token(Token = "0x6000348")]
		IUIView Bind(string propertyName, UIBinding newBinding);
	}
	[Token(Token = "0x200008F")]
	public class UIViewBase : MonoBehaviour, IUIView
	{
		[Token(Token = "0x20001A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778D3C", Offset = "0x778D3C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject gameObject;

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x98A4C0", Offset = "0x98A4C0", VA = "0x98A4C0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x98A5E8", Offset = "0x98A5E8", VA = "0x98A5E8")]
			internal void <BindFallback>b__0(bool x)
			{
			}

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x98A608", Offset = "0x98A608", VA = "0x98A608")]
			internal void <BindFallback>b__1(string x)
			{
			}
		}

		[Token(Token = "0x20001A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778D4C", Offset = "0x778D4C")]
		private sealed class <>c__DisplayClass2_1
		{
			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement le;

			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x98A4C8", Offset = "0x98A4C8", VA = "0x98A4C8")]
			public <>c__DisplayClass2_1()
			{
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x98A6E4", Offset = "0x98A6E4", VA = "0x98A6E4")]
			internal void <BindFallback>b__2(float x)
			{
			}

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x98A75C", Offset = "0x98A75C", VA = "0x98A75C")]
			internal void <BindFallback>b__3(float x)
			{
			}

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x98A7D4", Offset = "0x98A7D4", VA = "0x98A7D4")]
			internal void <BindFallback>b__4(float x)
			{
			}
		}

		[Token(Token = "0x20001A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778D5C", Offset = "0x778D5C")]
		private sealed class <>c__DisplayClass2_2
		{
			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform rt;

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x98A4D0", Offset = "0x98A4D0", VA = "0x98A4D0")]
			public <>c__DisplayClass2_2()
			{
			}

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x98A8A0", Offset = "0x98A8A0", VA = "0x98A8A0")]
			internal void <BindFallback>b__5(float x)
			{
			}
		}

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, IChangeBinding> _props;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, Action<object>> _actions;

		[Token(Token = "0x1700000C")]
		private GameObject UIFromCode.IUIView.gameObject
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x98A548", Offset = "0x98A548", VA = "0x98A548", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x98A1AC", Offset = "0x98A1AC", VA = "0x98A1AC")]
		private static Color StringToColor(string s)
		{
			return default(Color);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x98A364", Offset = "0x98A364", VA = "0x98A364", Slot = "4")]
		public IUIView Bind(string propertyName, UIBinding newBinding)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x986274", Offset = "0x986274", VA = "0x986274")]
		public static void BindFallback(GameObject gameObject, string propertyName, UIBinding newBinding)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x98A4D8", Offset = "0x98A4D8", VA = "0x98A4D8")]
		public void RegisterBinding(string propertyName, IChangeBinding newBinding)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x989074", Offset = "0x989074", VA = "0x989074")]
		public IUIView SetAction(string actionName, Action<object> action)
		{
			return null;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x98A550", Offset = "0x98A550", VA = "0x98A550")]
		public UIViewBase()
		{
		}
	}
	[Token(Token = "0x2000090")]
	internal class UIViewNull : IUIView
	{
		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GameObject _gameObject;

		[Token(Token = "0x1700000D")]
		public GameObject gameObject
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x98A960", Offset = "0x98A960", VA = "0x98A960", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x98A930", Offset = "0x98A930", VA = "0x98A930", Slot = "4")]
		public IUIView Bind(string propertyName, UIBinding newBinding)
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x98A934", Offset = "0x98A934", VA = "0x98A934")]
		public UIViewNull(GameObject go)
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class Ref<T> where T : struct
	{
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T _value;

		[Token(Token = "0x1700000E")]
		public T Value
		{
			[Token(Token = "0x6000355")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000356")]
			set
			{
			}
		}

		[Token(Token = "0x6000354")]
		public Ref(T value)
		{
		}

		[Token(Token = "0x6000357")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		public static implicit operator T(Ref<T> wrapper)
		{
			return (T)null;
		}

		[Token(Token = "0x6000359")]
		public static implicit operator Ref<T>(T value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000092")]
	public class UIContext : IDisposable, IUIView
	{
		[Token(Token = "0x20001AA")]
		public struct Translated
		{
			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string String;

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x989840", Offset = "0x989840", VA = "0x989840")]
			public static implicit operator Translated(string str)
			{
				return default(Translated);
			}
		}

		[Token(Token = "0x20001AB")]
		private struct SettingsThatArePassedOn
		{
			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int hPad;

			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int vPad;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<string> overridePrefabs;
		}

		[Token(Token = "0x20001AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778D6C", Offset = "0x778D6C")]
		private sealed class <>c__DisplayClass5_0<T, R>
		{
			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReactiveProperty<R> rValOut;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T, R> f;

			[Token(Token = "0x6000A12")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000A13")]
			internal void <Transform>b__0(T x)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778D7C", Offset = "0x778D7C")]
		private sealed class <>c__6<T>
		{
			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__6<T> <>9;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<T, T> <>9__6_0;

			[Token(Token = "0x6000A15")]
			public <>c__6()
			{
			}

			[Token(Token = "0x6000A16")]
			internal T <PropertyFromObservable>b__6_0(T x)
			{
				return (T)null;
			}
		}

		[Token(Token = "0x20001AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778D8C", Offset = "0x778D8C")]
		private sealed class <>c__DisplayClass8_0<T1, T2, R>
		{
			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReactiveProperty<R> rValOut;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T1, T2, R> f;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReactiveProperty<T1> input1;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReactiveProperty<T2> input2;

			[Token(Token = "0x6000A17")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000A18")]
			internal void <Combine>b__0(T1 x)
			{
			}

			[Token(Token = "0x6000A19")]
			internal void <Combine>b__1(T2 x)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778D9C", Offset = "0x778D9C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<bool, bool, bool> <>9__9_0;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<bool, bool, bool> <>9__10_0;

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<bool, bool> <>9__11_0;

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x9897E8", Offset = "0x9897E8", VA = "0x9897E8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x9897F0", Offset = "0x9897F0", VA = "0x9897F0")]
			internal bool <CombineOr>b__9_0(bool a, bool b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x9897FC", Offset = "0x9897FC", VA = "0x9897FC")]
			internal bool <CombineAnd>b__10_0(bool a, bool b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x989808", Offset = "0x989808", VA = "0x989808")]
			internal bool <Not>b__11_0(bool x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778DAC", Offset = "0x778DAC")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string iconNameTrue;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string iconNameFalse;

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x987F40", Offset = "0x987F40", VA = "0x987F40")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x989814", Offset = "0x989814", VA = "0x989814")]
			internal string <IconButtonBool>b__0(bool enabled)
			{
				return null;
			}
		}

		[Token(Token = "0x20001B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778DBC", Offset = "0x778DBC")]
		private sealed class <>c__DisplayClass56_0
		{
			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action OnSubmit;

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x98906C", Offset = "0x98906C", VA = "0x98906C")]
			public <>c__DisplayClass56_0()
			{
			}

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x98982C", Offset = "0x98982C", VA = "0x98982C")]
			internal void <InputField>b__0(object o)
			{
			}
		}

		[Token(Token = "0x20001B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778DCC", Offset = "0x778DCC")]
		private sealed class <>c__DisplayClass63_0<T> where T : class
		{
			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<UIContext, T> setupUnsafe;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UIContext listGroupCtx;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<UIContext, T> setup;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<T, UIContext> itemToCtx;

			[Token(Token = "0x6000A23")]
			public <>c__DisplayClass63_0()
			{
			}

			[Token(Token = "0x6000A24")]
			internal void <ListInternal>b__0(UIContext a, T b)
			{
			}

			[Token(Token = "0x6000A25")]
			internal void <ListInternal>b__1(CollectionAddEvent<T> _)
			{
			}

			[Token(Token = "0x6000A26")]
			internal void <ListInternal>b__2(CollectionRemoveEvent<T> _)
			{
			}
		}

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, GameObject> _cache;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GameObject _parent;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Action<UIContext, string> _sectionHeader;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _curColumn;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _columnCount;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _horizontal;

		[Token(Token = "0x40003C2")]
		private const int HPadDefault = 15;

		[Token(Token = "0x40003C3")]
		private const int VPadDefault = 0;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SettingsThatArePassedOn _cfg;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _uiContextContainer;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject _uiContainerPrefabRoot;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<GameObject> _uiObjects;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<IDisposable> _disposableObjects;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject _curTableRow;

		[Token(Token = "0x1700000F")]
		private GameObject UIFromCode.IUIView.gameObject
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x98692C", Offset = "0x98692C", VA = "0x98692C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x98578C", Offset = "0x98578C", VA = "0x98578C")]
		public static GameObject GetInternalPrefabByName(string typeName, bool allowMissing = false)
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x98594C", Offset = "0x98594C", VA = "0x98594C")]
		public GameObject GetPrefabByName(string typeName)
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		public void OnChanged<T>(IObservable<T> input, Action<T> f)
		{
		}

		[Token(Token = "0x600035D")]
		public void SubscribeTo<T>(IObservable<T> input, Action<T> f)
		{
		}

		[Token(Token = "0x600035E")]
		public ReactiveProperty<R> Transform<T, R>(IObservable<T> input, Func<T, R> f)
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		public ReactiveProperty<T> PropertyFromObservable<T>(IObservable<T> input)
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		public ReactiveProperty<T> GlobalProperty<T>(string structName, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		public ReactiveProperty<R> Combine<T1, T2, R>(ReactiveProperty<T1> input1, ReactiveProperty<T2> input2, Func<T1, T2, R> f)
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x985AB4", Offset = "0x985AB4", VA = "0x985AB4")]
		public ReactiveProperty<bool> CombineOr(ReactiveProperty<bool> input1, ReactiveProperty<bool> input2)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x985BC0", Offset = "0x985BC0", VA = "0x985BC0")]
		public ReactiveProperty<bool> CombineAnd(ReactiveProperty<bool> input1, ReactiveProperty<bool> input2)
		{
			return null;
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x985CCC", Offset = "0x985CCC", VA = "0x985CCC")]
		public ReactiveProperty<bool> Not(ReactiveProperty<bool> input1)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x985DD0", Offset = "0x985DD0", VA = "0x985DD0")]
		public void AddAsSubObject(IDisposable obj)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x985E38", Offset = "0x985E38", VA = "0x985E38")]
		private static void MakeSureHasLayouting(GameObject go, bool vertical = true)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x986070", Offset = "0x986070", VA = "0x986070")]
		public UIContext Bind(string propertyName, UIBinding newBinding)
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x986198", Offset = "0x986198", VA = "0x986198", Slot = "5")]
		private IUIView UIFromCode.IUIView.Bind(string propertyName, UIBinding newBinding)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x984800", Offset = "0x984800", VA = "0x984800")]
		public UIContext CreateSubContext()
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x984D9C", Offset = "0x984D9C", VA = "0x984D9C")]
		public UIContext CreateSubContextScrollable()
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x986B94", Offset = "0x986B94", VA = "0x986B94")]
		public UIContext CreateSubContextSkipContainer()
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x986934", Offset = "0x986934", VA = "0x986934")]
		private UIContext CreateSubContextInternal(bool skipContainer, bool scrollable = false, bool vertical = true)
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x986CA0", Offset = "0x986CA0", VA = "0x986CA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x986CA4", Offset = "0x986CA4", VA = "0x986CA4")]
		public void Cleanup()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x98524C", Offset = "0x98524C", VA = "0x98524C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x986DAC", Offset = "0x986DAC", VA = "0x986DAC")]
		public UIContext(GameObject parent, bool makeSureHasLayouting = true, bool isVertical = true)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x986BA4", Offset = "0x986BA4", VA = "0x986BA4")]
		private UIContext(UIContext parent, GameObject parentGO)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x986F24", Offset = "0x986F24", VA = "0x986F24")]
		public IUIView Button(string text, [Optional] Action OnClick, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x984A40", Offset = "0x984A40", VA = "0x984A40")]
		public IUIView IconButton(string text, string iconName, [Optional] Action OnClick, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x987C5C", Offset = "0x987C5C", VA = "0x987C5C")]
		public IUIView IconButtonWithLabel(string text, string iconName, [Optional] Action OnClick, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x987D18", Offset = "0x987D18", VA = "0x987D18")]
		public IUIView IconButtonBool(string text, string iconNameFalse, string iconNameTrue, ReactiveProperty<bool> toggleVal)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x987F48", Offset = "0x987F48", VA = "0x987F48")]
		public IUIView TextButton(string text, [Optional] Action OnClick)
		{
			return null;
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x98803C", Offset = "0x98803C", VA = "0x98803C")]
		public IUIView ListItemButton(string text, [Optional] Action OnClick, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x9880F4", Offset = "0x9880F4", VA = "0x9880F4")]
		public IUIView ListItemButton(string text, string iconName, [Optional] Action OnClick, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x9881B0", Offset = "0x9881B0", VA = "0x9881B0")]
		public IUIView RadioButton(string text, UIBinding binding, object optionValue, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x988274", Offset = "0x988274", VA = "0x988274")]
		public IUIView RadioButtonAsButton(string text, UIBinding binding, object optionValue, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x988338", Offset = "0x988338", VA = "0x988338")]
		public IUIView RadioButtonAsTextButton(string text, UIBinding binding, object optionValue)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x98840C", Offset = "0x98840C", VA = "0x98840C")]
		public IUIView TabButtonAsIconButton(string text, string iconName, UIBinding binding, object optionValue)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x9884E4", Offset = "0x9884E4", VA = "0x9884E4")]
		public IUIView TabButtonAsIconButtonWithLabel(string text, string iconName, UIBinding binding, object optionValue)
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x984CCC", Offset = "0x984CCC", VA = "0x984CCC")]
		public IUIView TabButton(string text, UIBinding binding, object optionValue, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x9885BC", Offset = "0x9885BC", VA = "0x9885BC")]
		public IUIView Checkbox(string text, UIBinding binding, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x98867C", Offset = "0x98867C", VA = "0x98867C")]
		public IUIView CheckboxAsButton(string text, UIBinding binding, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x98873C", Offset = "0x98873C", VA = "0x98873C")]
		public IUIView CheckboxAsTextButton(string text, UIBinding binding)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x988804", Offset = "0x988804", VA = "0x988804")]
		public IUIView Checkbox(string text, [Optional] Action OnClick, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x9888BC", Offset = "0x9888BC", VA = "0x9888BC")]
		public IUIView Slider(string text, UIBinding binding, [Optional] Range range, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x988998", Offset = "0x988998", VA = "0x988998")]
		public IUIView Slider(UIBinding binding, [Optional] Range range, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x988A68", Offset = "0x988A68", VA = "0x988A68")]
		public IUIView Slider(Func<float, string> text, UIBinding binding, [Optional] Range range, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x988B6C", Offset = "0x988B6C", VA = "0x988B6C")]
		public IUIView LineDivider(float height = 15f, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x988C1C", Offset = "0x988C1C", VA = "0x988C1C")]
		public IUIView LineDividerWithoutMargins(float spaceBelow = 0f, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x984838", Offset = "0x984838", VA = "0x984838")]
		public IUIView Space(float amount = 15f, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x9848E8", Offset = "0x9848E8", VA = "0x9848E8")]
		public IUIView SpaceFill(float amount = 1f, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x988CD0", Offset = "0x988CD0", VA = "0x988CD0")]
		public IUIView TextLabel([Optional] string text, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x988D7C", Offset = "0x988D7C", VA = "0x988D7C")]
		public IUIView TextLabelFaded([Optional] string text, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x984998", Offset = "0x984998", VA = "0x984998")]
		public IUIView TextMultiLine([Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x988E48", Offset = "0x988E48", VA = "0x988E48")]
		public IUIView InputField(UIBinding binding, [Optional] Action OnSubmit, [Optional] Action OnCancel, [Optional] GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x9890EC", Offset = "0x9890EC", VA = "0x9890EC")]
		public void OverrideSectionHeader(Action<UIContext, string> header)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x9890F4", Offset = "0x9890F4", VA = "0x9890F4")]
		public void SectionHeader([Optional] string text)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x9891CC", Offset = "0x9891CC", VA = "0x9891CC")]
		public void AddOverride(string text)
		{
		}

		[Token(Token = "0x6000392")]
		public IUIView List<T>(IReadOnlyReactiveCollection<T> collection, Action<UIContext, T> setup) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		public IUIView ListScrollable<T>(IReadOnlyReactiveCollection<T> collection, Action<UIContext, T> setup) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		private IUIView ListInternal<T>(bool scrollable, IReadOnlyReactiveCollection<T> collection, Action<UIContext, T> setupUnsafe) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x984CB0", Offset = "0x984CB0", VA = "0x984CB0")]
		public void ColumnLayoutBegin(int columnCount)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x984D90", Offset = "0x984D90", VA = "0x984D90")]
		public void ColumnLayoutEnd()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x984820", Offset = "0x984820", VA = "0x984820")]
		public void HorizontalLayoutBegin()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x984AFC", Offset = "0x984AFC", VA = "0x984AFC")]
		public void HorizontalLayoutEnd()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x989264", Offset = "0x989264", VA = "0x989264")]
		public void UseHorizontalPadding(bool paddingEnabled)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x989278", Offset = "0x989278", VA = "0x989278")]
		public void UseHorizontalPadding(bool paddingEnabled, int padding)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x989288", Offset = "0x989288", VA = "0x989288")]
		public void UsePadding(bool paddingEnabled)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x984810", Offset = "0x984810", VA = "0x984810")]
		public void UsePadding(bool paddingEnabled, int padding)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x98929C", Offset = "0x98929C", VA = "0x98929C")]
		public void UsePadding(bool paddingEnabled, int horizontalPadding, int verticalPadding)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x9892B0", Offset = "0x9892B0", VA = "0x9892B0")]
		private bool isHorizontal()
		{
			return default(bool);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x9892C0", Offset = "0x9892C0", VA = "0x9892C0")]
		public void DestroyOnClear(GameObject o)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x989328", Offset = "0x989328", VA = "0x989328")]
		public void DisposeOnClear(IDisposable o)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x986FDC", Offset = "0x986FDC", VA = "0x986FDC")]
		private IUIView CreateComponent(string typeName, string text_translated, float size, Action OnClick, GameObject prefab, [Optional] UIBinding binding, [Optional] object radioButtonOptionValue, [Optional] UIBinding textBinding, [Optional] string iconName, [Optional] Range sliderRange)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		public static void DisposeAndSetToNull<T>(ref T r) where T : class, IDisposable
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x989390", Offset = "0x989390", VA = "0x989390")]
		private static object GetDefaultValue(Type t)
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x9893D8", Offset = "0x9893D8", VA = "0x9893D8")]
		public static object ChangeTypeNoExp(object val, Type t, string failReference = "unknown")
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		public static T ChangeTypeNoExp<T>(object val, string failReference = "unknown")
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000093")]
	public class CallOnDispose : IDisposable
	{
		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Action _f;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x98454C", Offset = "0x98454C", VA = "0x98454C")]
		public CallOnDispose(Action f)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x984578", Offset = "0x984578", VA = "0x984578", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class UISystem : MonoBehaviour
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _refCount;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static UISystem _global;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject _canvasRoot;

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x989844", Offset = "0x989844", VA = "0x989844")]
		public static UIContext CreateSidePanel(bool leftSide, int size = 350, [Optional] GameObject canvasRootArg)
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x989CD4", Offset = "0x989CD4", VA = "0x989CD4")]
		public static UISystem RegisterUsage()
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x989DFC", Offset = "0x989DFC", VA = "0x989DFC")]
		public static void UnregisterUsage()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x989F34", Offset = "0x989F34", VA = "0x989F34")]
		public GameObject GetCanvasRoot()
		{
			return null;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x989F3C", Offset = "0x989F3C", VA = "0x989F3C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x98A120", Offset = "0x98A120", VA = "0x98A120")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x98A1A0", Offset = "0x98A1A0", VA = "0x98A1A0")]
		public UISystem()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class FoldableSettings
	{
		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float refreshIntervalInSeconds;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string foldedIcon;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string unfoldedIcon;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float iconSize;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float indentSize;

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x984594", Offset = "0x984594", VA = "0x984594")]
		public FoldableSettings()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public static class IUIViewExtentions
	{
		[Token(Token = "0x20001B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778DDC", Offset = "0x778DDC")]
		private sealed class <>c__DisplayClass2_0<T>
		{
			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UIContext rootCtx;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T root;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<T, ReactiveProperty<bool>> clientNodeToFoldableState;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T, bool> isFoldable;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, Action<T>> iterateChildren;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<UIContext, T, Action> generateItem;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action refresh;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FoldableSettings settings;

			[Token(Token = "0x6000A27")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000A28")]
			internal void <Foldable>b__0()
			{
			}

			[Token(Token = "0x6000A29")]
			internal void <Foldable>b__1(long cnt)
			{
			}
		}

		[Token(Token = "0x20001B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778DEC", Offset = "0x778DEC")]
		private sealed class <>c__DisplayClass3_0<T>
		{
			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UIContext content;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, Action<T>> iterateChildren;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T clientNode;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int indent;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<T, ReactiveProperty<bool>> clientNodeToFoldableState;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T, bool> isFoldable;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<UIContext, T, Action> generateItem;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action refresh;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FoldableSettings settings;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> <>9__1;

			[Token(Token = "0x6000A2A")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000A2B")]
			internal void <FoldableRec>b__0(bool unfoldedVal)
			{
			}

			[Token(Token = "0x6000A2C")]
			internal void <FoldableRec>b__1(T child)
			{
			}
		}

		[Token(Token = "0x20001B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778DFC", Offset = "0x778DFC")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIContext ui;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<UIContext, string> onTabCreate;

			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x984CA8", Offset = "0x984CA8", VA = "0x984CA8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x9851D4", Offset = "0x9851D4", VA = "0x9851D4")]
			internal void <TabView>b__0(string selectionValue)
			{
			}
		}

		[Token(Token = "0x20001B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778E0C", Offset = "0x778E0C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIContext ui;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<UIContext, string> onTabCreate;

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x984F94", Offset = "0x984F94", VA = "0x984F94")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x98540C", Offset = "0x98540C", VA = "0x98540C")]
			internal void <TabView>b__0(string selectionValue)
			{
			}
		}

		[Token(Token = "0x20001B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778E1C", Offset = "0x778E1C")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIContext ui;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<UIContext, string> onTabCreate;

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x9851CC", Offset = "0x9851CC", VA = "0x9851CC")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x985484", Offset = "0x985484", VA = "0x985484")]
			internal void <TabView>b__0(string selectionValue)
			{
			}
		}

		[Token(Token = "0x60003B2")]
		public static IUIView Set<T>(this IUIView uiView, string propertyName, T value)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x984604", Offset = "0x984604", VA = "0x984604")]
		public static IUIView CreateTitleBar(this UIContext context, string title, [Optional] Action onClose)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		public static Action Foldable<T>(this UIContext context, T root, Func<T, bool> isFoldable, Action<T, Action<T>> iterateChildren, FoldableSettings settings, Action<UIContext, T, Action> generateItem)
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		private static void FoldableRec<T>(int indent, UIContext ui, T clientNode, Dictionary<T, ReactiveProperty<bool>> clientNodeToFoldableState, Func<T, bool> isFoldable, Action<T, Action<T>> iterateChildren, Action<UIContext, T, Action> generateItem, Action refresh, FoldableSettings settings)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x984B0C", Offset = "0x984B0C", VA = "0x984B0C")]
		public static IUIView TabView(this UIContext context, ReactiveProperty<string> selection, string displayNameTab1, string internalNameTab1, string displayNameTab2, string internalNameTab2, Action<UIContext, string> onTabCreate)
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x984DAC", Offset = "0x984DAC", VA = "0x984DAC")]
		public static IUIView TabView(this UIContext context, ReactiveProperty<string> selection, string displayNameTab1, string internalNameTab1, string displayNameTab2, string internalNameTab2, string displayNameTab3, string internalNameTab3, Action<UIContext, string> onTabCreate)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x984F9C", Offset = "0x984F9C", VA = "0x984F9C")]
		public static IUIView TabView(this UIContext context, ReactiveProperty<string> selection, string displayNameTab1, string internalNameTab1, string displayNameTab2, string internalNameTab2, string displayNameTab3, string internalNameTab3, string displayNameTab4, string internalNameTab4, Action<UIContext, string> onTabCreate)
		{
			return null;
		}
	}
	[Token(Token = "0x2000097")]
	public static class Util
	{
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static TMP_FontAsset FallbackFont;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<Font, TMP_FontAsset> tmpFontCache;

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x98A968", Offset = "0x98A968", VA = "0x98A968")]
		public static void ConvertToTextMeshPro(Text old)
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class VRUIButtonBinding : UIViewBase, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IBeginDragHandler, IDragHandler
	{
		[Serializable]
		[Token(Token = "0x20001B8")]
		public class ReactiveStructBindingObject : ReactiveStructBinding<object>
		{
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x98D5C0", Offset = "0x98D5C0", VA = "0x98D5C0")]
			public ReactiveStructBindingObject()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B9")]
		public class ReactiveStructBindingString : ReactiveStructBinding<string>
		{
			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x98D610", Offset = "0x98D610", VA = "0x98D610")]
			public ReactiveStructBindingString()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001BA")]
		public class ReactiveStructBindingBool : ReactiveStructBinding<bool>
		{
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x98D660", Offset = "0x98D660", VA = "0x98D660")]
			public ReactiveStructBindingBool()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001BB")]
		public class ReactiveStructBindingFloat : ReactiveStructBinding<float>
		{
			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x98D6B0", Offset = "0x98D6B0", VA = "0x98D6B0")]
			public ReactiveStructBindingFloat()
			{
			}
		}

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<string, Color> VRUIColorCode;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ReactiveStructBindingObject ButtonValue;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ReactiveStructBindingString Text;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ReactiveStructBindingBool Disable;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ReactiveStructBindingString Icon;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ReactiveStructBindingFloat Opacity;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ReactiveStructBindingFloat TextOpacity;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ReactiveStructBindingBool Selected;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool UseAsRadioButton;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string RadioButtonValue;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Button _button;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI[] ExtraTextComponents;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public TextMeshProUGUI TextComponent;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Image NormalState;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Image ActiveState;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Graphic HoverOverlay;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Graphic ActiveOverlay;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool ChangeTextColor;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool UseCheckBoxStyle;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool DisableHoverForActiveState;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public Action OnButtonClicked;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float ColorMultiplier;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Image _currentStateImage;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _hovering;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool DarkenHoverStyle;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
		public bool UseColorScheme;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCB")]
		public bool DisableHaptics;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool _issueHaptics;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public VRCButtonColorScheme ColorScheme;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool _customColor;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Color _color;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float _originMultiplier;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public UnityEvent PostClickCustomEvent;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Dictionary<string, Color> _colorCode;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Transform, bool> DoesButtonWantHoverHaptics;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<PointerEventData> SendHaptics;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private float _dragAccum;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private bool _convertedToContentDrag;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x145")]
		private bool _buttonDown;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x146")]
		private bool _unityHovering;

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x98AF70", Offset = "0x98AF70", VA = "0x98AF70")]
		public void ButtonOnClick()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x98B114", Offset = "0x98B114", VA = "0x98B114")]
		private bool StateIsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x98B300", Offset = "0x98B300", VA = "0x98B300")]
		private bool IsButtonDisabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x98B384", Offset = "0x98B384", VA = "0x98B384")]
		public void SetText(string text)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x98B42C", Offset = "0x98B42C", VA = "0x98B42C")]
		public void UpdateAppearance()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x98BA60", Offset = "0x98BA60", VA = "0x98BA60")]
		private void setColor(Color col, Color colorIgnoreSelection, bool disabled, bool isStateActive)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x98C0F0", Offset = "0x98C0F0", VA = "0x98C0F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x98C1DC", Offset = "0x98C1DC", VA = "0x98C1DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x98C770", Offset = "0x98C770", VA = "0x98C770")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x98C858", Offset = "0x98C858", VA = "0x98C858")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x98C92C", Offset = "0x98C92C", VA = "0x98C92C", Slot = "10")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x98C0D0", Offset = "0x98C0D0", VA = "0x98C0D0")]
		private bool isButtonDown()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x98C934", Offset = "0x98C934", VA = "0x98C934", Slot = "11")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x98CAB8", Offset = "0x98CAB8", VA = "0x98CAB8", Slot = "8")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x98CAE4", Offset = "0x98CAE4", VA = "0x98CAE4", Slot = "9")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x98CC30", Offset = "0x98CC30", VA = "0x98CC30", Slot = "6")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x98CD80", Offset = "0x98CD80", VA = "0x98CD80", Slot = "7")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x98CE54", Offset = "0x98CE54", VA = "0x98CE54")]
		public void SetColor(Color color, bool recover = false, bool darkenHover = false)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x98D1FC", Offset = "0x98D1FC", VA = "0x98D1FC")]
		public VRUIButtonBinding()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x98D8B0", Offset = "0x98D8B0", VA = "0x98D8B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AEBC", Offset = "0x77AEBC")]
		private void <OnEnable>b__45_0(object x)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x98D8B4", Offset = "0x98D8B4", VA = "0x98D8B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AECC", Offset = "0x77AECC")]
		private void <OnEnable>b__45_1(string x)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x98D8B8", Offset = "0x98D8B8", VA = "0x98D8B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AEDC", Offset = "0x77AEDC")]
		private void <OnEnable>b__45_2(bool x)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x98D978", Offset = "0x98D978", VA = "0x98D978")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AEEC", Offset = "0x77AEEC")]
		private void <OnEnable>b__45_3(string x)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x98DA8C", Offset = "0x98DA8C", VA = "0x98DA8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AEFC", Offset = "0x77AEFC")]
		private void <OnEnable>b__45_4(float x)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x98DA90", Offset = "0x98DA90", VA = "0x98DA90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF0C", Offset = "0x77AF0C")]
		private void <OnEnable>b__45_5(float x)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x98DA94", Offset = "0x98DA94", VA = "0x98DA94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF1C", Offset = "0x77AF1C")]
		private void <OnEnable>b__45_6(bool x)
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class VRUIInputFieldBinding : UIViewBase
	{
		[Serializable]
		[Token(Token = "0x20001BC")]
		public class ReactiveStructBindingString : ReactiveStructBinding<string>
		{
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x98E1B4", Offset = "0x98E1B4", VA = "0x98E1B4")]
			public ReactiveStructBindingString()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001BD")]
		public class ReactiveStructBindingBool : ReactiveStructBinding<bool>
		{
			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x98E204", Offset = "0x98E204", VA = "0x98E204")]
			public ReactiveStructBindingBool()
			{
			}
		}

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ReactiveStructBindingString InputFieldValue;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ReactiveStructBindingString InputFieldPlaceholder;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ReactiveStructBindingBool Disable;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TMP_InputField Inputfield;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI PlaceholderText;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string _valock;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool focused;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public TextMeshProUGUI TextComponent;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<RectTransform, bool> UpdateGlobalFocusState;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x98DA98", Offset = "0x98DA98", VA = "0x98DA98")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x98DB1C", Offset = "0x98DB1C", VA = "0x98DB1C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x98DD48", Offset = "0x98DD48", VA = "0x98DD48")]
		private void CheckSubmit(string s)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x98DD84", Offset = "0x98DD84", VA = "0x98DD84")]
		public void OnSubmit()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x98DE48", Offset = "0x98DE48", VA = "0x98DE48")]
		private void UpdateInputFieldValue(string x)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x98DEC8", Offset = "0x98DEC8", VA = "0x98DEC8")]
		private void InputValueUpdated(string x)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x98DF58", Offset = "0x98DF58", VA = "0x98DF58")]
		private void Update()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x98E048", Offset = "0x98E048", VA = "0x98E048")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x98E11C", Offset = "0x98E11C", VA = "0x98E11C")]
		public VRUIInputFieldBinding()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x98E254", Offset = "0x98E254", VA = "0x98E254")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF2C", Offset = "0x77AF2C")]
		private void <OnEnable>b__11_0(string str)
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class VRUISliderBinding : UIViewBase
	{
		[Serializable]
		[Token(Token = "0x20001BE")]
		public class ReactiveStructBindingBool : ReactiveStructBinding<bool>
		{
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x98E9D0", Offset = "0x98E9D0", VA = "0x98E9D0")]
			public ReactiveStructBindingBool()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001BF")]
		public class ReactiveStructBindingFloat : ReactiveStructBinding<float>
		{
			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x98E914", Offset = "0x98E914", VA = "0x98E914")]
			public ReactiveStructBindingFloat()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C0")]
		public class ReactiveStructBindingString : ReactiveStructBinding<string>
		{
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x98E964", Offset = "0x98E964", VA = "0x98E964")]
			public ReactiveStructBindingString()
			{
			}
		}

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ReactiveStructBindingFloat SliderValue;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ReactiveStructBindingString Text;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ReactiveStructBindingString Disable;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Slider Slider;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool UseScaling;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float SliderMin;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float SliderMiddle;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float SliderMax;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _valock;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public TextMeshProUGUI TextComponent;

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x98E270", Offset = "0x98E270", VA = "0x98E270")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x98E2F4", Offset = "0x98E2F4", VA = "0x98E2F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x98E4D4", Offset = "0x98E4D4", VA = "0x98E4D4")]
		public static float Curve(float x, float a)
		{
			return default(float);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x98E4F8", Offset = "0x98E4F8", VA = "0x98E4F8")]
		public static float CurveFit3(float x, float y0, float y0_5, float y1)
		{
			return default(float);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x98E5B0", Offset = "0x98E5B0", VA = "0x98E5B0")]
		public static float CurveFit3i(float x, float y0, float y0_5, float y1)
		{
			return default(float);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x98E66C", Offset = "0x98E66C", VA = "0x98E66C")]
		private void UpdateUISlider(float x)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x98E6F0", Offset = "0x98E6F0", VA = "0x98E6F0")]
		private void SliderValueUpdated(float x)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x98E798", Offset = "0x98E798", VA = "0x98E798")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x98E86C", Offset = "0x98E86C", VA = "0x98E86C")]
		public VRUISliderBinding()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x98E9B4", Offset = "0x98E9B4", VA = "0x98E9B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF3C", Offset = "0x77AF3C")]
		private void <OnEnable>b__14_0(string str)
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class VRUITextBinding : UIViewBase
	{
		[Serializable]
		[Token(Token = "0x20001C1")]
		public class ReactiveStructBindingString : ReactiveStructBinding<string>
		{
			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x98ED8C", Offset = "0x98ED8C", VA = "0x98ED8C")]
			public ReactiveStructBindingString()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C2")]
		public class ReactiveStructBindingFloat : ReactiveStructBinding<float>
		{
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x98EDDC", Offset = "0x98EDDC", VA = "0x98EDDC")]
			public ReactiveStructBindingFloat()
			{
			}
		}

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ReactiveStructBindingString Value;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ReactiveStructBindingFloat Opacity;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public TextMeshProUGUI TextComponent;

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x98EA20", Offset = "0x98EA20", VA = "0x98EA20")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x98EAA4", Offset = "0x98EAA4", VA = "0x98EAA4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x98EC28", Offset = "0x98EC28", VA = "0x98EC28")]
		private void UpdateText(string x)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x98EC44", Offset = "0x98EC44", VA = "0x98EC44")]
		private void UpdateOpacity(float a)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x98ECA0", Offset = "0x98ECA0", VA = "0x98ECA0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x98ED10", Offset = "0x98ED10", VA = "0x98ED10")]
		public VRUITextBinding()
		{
		}
	}
}
namespace Triangulator3
{
	[Token(Token = "0x200009C")]
	internal struct Triangle
	{
		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int p1;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int p2;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int p3;

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x98385C", Offset = "0x98385C", VA = "0x98385C")]
		public Triangle(int point1, int point2, int point3)
		{
		}
	}
	[Token(Token = "0x200009D")]
	internal class Edge
	{
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int p1;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int p2;

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x9837A0", Offset = "0x9837A0", VA = "0x9837A0")]
		public Edge(int point1, int point2)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x9837D8", Offset = "0x9837D8", VA = "0x9837D8")]
		public Edge()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x983800", Offset = "0x983800", VA = "0x983800")]
		public bool Equals(Edge other)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200009E")]
	public class Triangulator
	{
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x983868", Offset = "0x983868", VA = "0x983868")]
		private bool TriangulatePolygonSubFunc_InCircle(Vector2 p, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x983A88", Offset = "0x983A88", VA = "0x983A88")]
		private GameObject CreateInfluencePolygon(Vector2[] XZofVertices)
		{
			return null;
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x983C54", Offset = "0x983C54", VA = "0x983C54")]
		private int[] TriangulatePolygon(Vector2[] XZofVertices)
		{
			return null;
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x984544", Offset = "0x984544", VA = "0x984544")]
		public Triangulator()
		{
		}
	}
}
namespace RectpackSharp
{
	[Token(Token = "0x200009F")]
	[Flags]
	public enum PackingHints
	{
		[Token(Token = "0x4000419")]
		TryByArea = 1,
		[Token(Token = "0x400041A")]
		TryByPerimeter = 2,
		[Token(Token = "0x400041B")]
		TryByBiggerSide = 4,
		[Token(Token = "0x400041C")]
		TryByWidth = 8,
		[Token(Token = "0x400041D")]
		TryByHeight = 0x10,
		[Token(Token = "0x400041E")]
		TryByPathologicalMultiplier = 0x20,
		[Token(Token = "0x400041F")]
		FindBest = 0x3F,
		[Token(Token = "0x4000420")]
		UnusualSizes = 0x26,
		[Token(Token = "0x4000421")]
		MostlySquared = 0x1D
	}
	[Token(Token = "0x20000A0")]
	internal static class PackingHintExtensions
	{
		[Token(Token = "0x20001C3")]
		private delegate uint GetSortKeyDelegate(in PackingRectangle rectangle);

		[Token(Token = "0x4000422")]
		internal const int MaxHintCount = 6;

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xA5736C", Offset = "0xA5736C", VA = "0xA5736C")]
		public static uint GetArea(in PackingRectangle rectangle)
		{
			return default(uint);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xA57384", Offset = "0xA57384", VA = "0xA57384")]
		public static uint GetPerimeter(in PackingRectangle rectangle)
		{
			return default(uint);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xA573A4", Offset = "0xA573A4", VA = "0xA573A4")]
		public static uint GetBiggerSide(in PackingRectangle rectangle)
		{
			return default(uint);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xA57444", Offset = "0xA57444", VA = "0xA57444")]
		public static uint GetWidth(in PackingRectangle rectangle)
		{
			return default(uint);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xA5744C", Offset = "0xA5744C", VA = "0xA5744C")]
		public static uint GetHeight(in PackingRectangle rectangle)
		{
			return default(uint);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xA57454", Offset = "0xA57454", VA = "0xA57454")]
		public static uint GetPathologicalMultiplier(in PackingRectangle rectangle)
		{
			return default(uint);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xA57494", Offset = "0xA57494", VA = "0xA57494")]
		public static void GetFlagsFrom(PackingHints packingHint, ref PackingHints[] span)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xA5776C", Offset = "0xA5776C", VA = "0xA5776C")]
		private static GetSortKeyDelegate SortByPackingHintSw(PackingHints packingHint)
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xA57890", Offset = "0xA57890", VA = "0xA57890")]
		public static void SortByPackingHint(PackingRectangle[] rectangles, PackingHints packingHint)
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public struct PackingRectangle : IEquatable<PackingRectangle>, IComparable<PackingRectangle>
	{
		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Id;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint SortKey;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint X;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint Y;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint Width;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint Height;

		[Token(Token = "0x17000010")]
		public uint Right
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0xA57C78", Offset = "0xA57C78", VA = "0xA57C78")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xA57C88", Offset = "0xA57C88", VA = "0xA57C88")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public uint Bottom
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xA57C98", Offset = "0xA57C98", VA = "0xA57C98")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000404")]
			[Address(RVA = "0xA57CA8", Offset = "0xA57CA8", VA = "0xA57CA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public uint Area
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xA57378", Offset = "0xA57378", VA = "0xA57378")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000013")]
		public uint Perimeter
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xA57394", Offset = "0xA57394", VA = "0xA57394")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000014")]
		public uint BiggerSide
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0xA573D4", Offset = "0xA573D4", VA = "0xA573D4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000015")]
		public uint PathologicalMultiplier
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0xA57474", Offset = "0xA57474", VA = "0xA57474")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xA57CB8", Offset = "0xA57CB8", VA = "0xA57CB8")]
		public PackingRectangle(uint x, uint y, uint width, uint height, int id = 0)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xA57CC8", Offset = "0xA57CC8", VA = "0xA57CC8")]
		public static bool operator ==(PackingRectangle left, PackingRectangle right)
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xA57D80", Offset = "0xA57D80", VA = "0xA57D80")]
		public static bool operator !=(PackingRectangle left, PackingRectangle right)
		{
			return default(bool);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xA57DDC", Offset = "0xA57DDC", VA = "0xA57DDC")]
		public bool Contains(in PackingRectangle other)
		{
			return default(bool);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xA57E38", Offset = "0xA57E38", VA = "0xA57E38")]
		public bool Intersects(in PackingRectangle other)
		{
			return default(bool);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xA57E94", Offset = "0xA57E94", VA = "0xA57E94")]
		public PackingRectangle Intersection(in PackingRectangle other)
		{
			return default(PackingRectangle);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xA57FBC", Offset = "0xA57FBC", VA = "0xA57FBC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xA58270", Offset = "0xA58270", VA = "0xA58270", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xA57D24", Offset = "0xA57D24", VA = "0xA57D24", Slot = "4")]
		public bool Equals(PackingRectangle other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xA582BC", Offset = "0xA582BC", VA = "0xA582BC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xA58384", Offset = "0xA58384", VA = "0xA58384", Slot = "5")]
		public int CompareTo(PackingRectangle other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000A2")]
	public static class RectanglePacker
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static WeakReference<List<PackingRectangle>> oldListReference;

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xA583A8", Offset = "0xA583A8", VA = "0xA583A8")]
		public static void Pack(PackingRectangle[] rectangles, out PackingRectangle bounds, PackingHints packingHint = PackingHints.FindBest, float acceptableDensity = 1f, uint stepSize = 1u)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xA5896C", Offset = "0xA5896C", VA = "0xA5896C")]
		private static bool TryFindBestBin(List<PackingRectangle> emptySpaces, ref PackingRectangle[] rectangles, ref PackingRectangle[] tmpArray, uint binSize, uint stepSize, uint acceptableArea, out PackingRectangle bounds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xA58C60", Offset = "0xA58C60", VA = "0xA58C60")]
		private static bool TryPackAsOrdered(List<PackingRectangle> emptySpaces, PackingRectangle[] unpacked, PackingRectangle[] packed, uint binWidth, uint binHeight, out uint boundsWidth, out uint boundsHeight)
		{
			return default(bool);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xA59048", Offset = "0xA59048", VA = "0xA59048")]
		private static bool TryFindBestSpace(in PackingRectangle rectangle, List<PackingRectangle> emptySpaces, out int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xA587DC", Offset = "0xA587DC", VA = "0xA587DC")]
		private static List<PackingRectangle> GetList(int preferredCapacity)
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xA58AB0", Offset = "0xA58AB0", VA = "0xA58AB0")]
		private static void ReturnList(List<PackingRectangle> list)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xA59138", Offset = "0xA59138", VA = "0xA59138")]
		private static void AddSorted(this List<PackingRectangle> list, PackingRectangle rectangle)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xA59294", Offset = "0xA59294", VA = "0xA59294")]
		private static void EnsureSorted(List<PackingRectangle> list, int index)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xA5876C", Offset = "0xA5876C", VA = "0xA5876C")]
		public static uint CalculateTotalArea(PackingRectangle[] rectangles)
		{
			return default(uint);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xA59548", Offset = "0xA59548", VA = "0xA59548")]
		public static PackingRectangle FindBounds(PackingRectangle[] rectangles)
		{
			return default(PackingRectangle);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xA596CC", Offset = "0xA596CC", VA = "0xA596CC")]
		public static bool AnyIntersects(PackingRectangle[] rectangles)
		{
			return default(bool);
		}
	}
}
namespace Dummiesman
{
	[Token(Token = "0x20000A3")]
	public class CharWordReader
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public char[] word;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int wordSize;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool endReached;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private StreamReader reader;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int bufferSize;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private char[] buffer;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public char currentChar;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int currentPosition;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int maxPosition;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xAB7858", Offset = "0xAB7858", VA = "0xAB7858")]
		public CharWordReader(StreamReader reader, int bufferSize)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xAB79A4", Offset = "0xAB79A4", VA = "0xAB79A4")]
		public void SkipWhitespaces()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xAB7A24", Offset = "0xAB7A24", VA = "0xAB7A24")]
		public void SkipWhitespaces(out bool newLinePassed)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xAB7AD8", Offset = "0xAB7AD8", VA = "0xAB7AD8")]
		public void SkipUntilNewLine()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xAB7B88", Offset = "0xAB7B88", VA = "0xAB7B88")]
		public void ReadUntilWhiteSpace()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xAB7C5C", Offset = "0xAB7C5C", VA = "0xAB7C5C")]
		public void ReadUntilNewLine()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xAB7D10", Offset = "0xAB7D10", VA = "0xAB7D10")]
		public bool Is(string other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xAB7DB8", Offset = "0xAB7DB8", VA = "0xAB7DB8")]
		public string GetString(int startIndex = 0)
		{
			return null;
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xAB7E4C", Offset = "0xAB7E4C", VA = "0xAB7E4C")]
		public Vector3 ReadVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xAB7FE4", Offset = "0xAB7FE4", VA = "0xAB7FE4")]
		public int ReadInt()
		{
			return default(int);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xAB7EE8", Offset = "0xAB7EE8", VA = "0xAB7EE8")]
		public float ReadFloat()
		{
			return default(float);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xAB805C", Offset = "0xAB805C", VA = "0xAB805C")]
		private float ReadFloatEnd()
		{
			return default(float);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xAB7B4C", Offset = "0xAB7B4C", VA = "0xAB7B4C")]
		private void SkipNewLineSymbols()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xAB78E8", Offset = "0xAB78E8", VA = "0xAB78E8")]
		public void MoveNext()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public enum SplitMode
	{
		[Token(Token = "0x4000434")]
		None,
		[Token(Token = "0x4000435")]
		Object,
		[Token(Token = "0x4000436")]
		Material
	}
	[Token(Token = "0x20000A5")]
	public class OBJLoader
	{
		[Token(Token = "0x20001C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778E2C", Offset = "0x778E2C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<string, OBJObjectBuilder> builderDict;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public OBJObjectBuilder currentBuilder;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OBJLoader <>4__this;

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0xAB9F78", Offset = "0xAB9F78", VA = "0xAB9F78")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0xABB55C", Offset = "0xABB55C", VA = "0xABB55C")]
			internal void <LoadInternal>b__0(string objectName)
			{
			}
		}

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SplitMode SplitMode;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal List<Vector3> Vertices;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal List<Vector3> Normals;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal List<Vector2> UVs;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal Dictionary<string, Material> Materials;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FileInfo _objInfo;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xAB9814", Offset = "0xAB9814", VA = "0xAB9814")]
		private void LoadMaterialLibrary(string mtlLibPath)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xAB9988", Offset = "0xAB9988", VA = "0xAB9988")]
		public Dictionary<string, OBJObjectBuilder> LoadInternal(Stream input)
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xABA5A4", Offset = "0xABA5A4", VA = "0xABA5A4")]
		public GameObject Load(Stream input)
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xABAC70", Offset = "0xABAC70", VA = "0xABAC70")]
		public Dictionary<string, KeyValuePair<string[], Mesh>> LoadOnlyMeshes(Stream input)
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xABB134", Offset = "0xABB134", VA = "0xABB134")]
		public GameObject Load(Stream input, Stream mtlInput)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xABB1C4", Offset = "0xABB1C4", VA = "0xABB1C4")]
		public GameObject Load(string path, string mtlPath)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xABB494", Offset = "0xABB494", VA = "0xABB494")]
		public GameObject Load(string path)
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xABB49C", Offset = "0xABB49C", VA = "0xABB49C")]
		public OBJLoader()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public static class OBJLoaderHelper
	{
		[Token(Token = "0x6000435")]
		[Address(RVA = "0xABB744", Offset = "0xABB744", VA = "0xABB744")]
		public static void EnableMaterialTransparency(Material mtl)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xABB850", Offset = "0xABB850", VA = "0xABB850")]
		public static float FastFloatParse(string input)
		{
			return default(float);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xABBA50", Offset = "0xABBA50", VA = "0xABBA50")]
		public static int FastIntParse(string input)
		{
			return default(int);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xABBAE8", Offset = "0xABBAE8", VA = "0xABBAE8")]
		public static Material CreateNullMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xABBB64", Offset = "0xABBB64", VA = "0xABBB64")]
		public static Vector3 VectorFromStrArray(string[] cmps)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xABBC84", Offset = "0xABBC84", VA = "0xABBC84")]
		public static Color ColorFromStrArray(string[] cmps, float scalar = 1f)
		{
			return default(Color);
		}
	}
	[Token(Token = "0x20000A7")]
	public class OBJObjectBuilder
	{
		[Token(Token = "0x20001C5")]
		private class ObjLoopHash
		{
			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int vertexIndex;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int normalIndex;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int uvIndex;

			[Token(Token = "0x6000A44")]
			[Address(RVA = "0xABBE18", Offset = "0xABBE18", VA = "0xABBE18", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A45")]
			[Address(RVA = "0xABBED4", Offset = "0xABBED4", VA = "0xABBED4", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000A46")]
			[Address(RVA = "0xABBE10", Offset = "0xABBE10", VA = "0xABBE10")]
			public ObjLoopHash()
			{
			}
		}

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x779CF4", Offset = "0x779CF4")]
		private int <PushedFaceCount>k__BackingField;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private OBJLoader _loader;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _name;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<ObjLoopHash, int> _globalIndexRemap;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, List<int>> _materialIndices;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<int> _currentIndexList;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _lastMaterial;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Vector3> _vertices;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Vector3> _normals;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Vector2> _uvs;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool recalculateNormals;

		[Token(Token = "0x17000016")]
		public int PushedFaceCount
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0xABBD38", Offset = "0xABBD38", VA = "0xABBD38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF5C", Offset = "0x77AF5C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600043C")]
			[Address(RVA = "0xABBD40", Offset = "0xABBD40", VA = "0xABBD40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77AF6C", Offset = "0x77AF6C")]
			private set
			{
			}
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xABA7F4", Offset = "0xABA7F4", VA = "0xABA7F4")]
		public GameObject Build()
		{
			return null;
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xABADF4", Offset = "0xABADF4", VA = "0xABADF4")]
		public KeyValuePair<string[], Mesh> BuildOnlyMeshes()
		{
			return default(KeyValuePair<string[], Mesh>);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xABBD48", Offset = "0xABBD48", VA = "0xABBD48")]
		public void SetMaterial(string name)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xAB9F80", Offset = "0xAB9F80", VA = "0xAB9F80")]
		public void PushFace(string material, List<int> vertexIndices, List<int> normalIndices, List<int> uvIndices)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xABB624", Offset = "0xABB624", VA = "0xABB624")]
		public OBJObjectBuilder(string name, OBJLoader loader)
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public static class StringExtensions
	{
		[Token(Token = "0x6000442")]
		[Address(RVA = "0xABBF00", Offset = "0xABBF00", VA = "0xABBF00")]
		public static string Clean(this string str)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A9")]
	public static class BinaryExtensions
	{
		[Token(Token = "0x6000443")]
		[Address(RVA = "0xAB765C", Offset = "0xAB765C", VA = "0xAB765C")]
		public static Color32 ReadColor32RGBR(this BinaryReader r)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xAB76DC", Offset = "0xAB76DC", VA = "0xAB76DC")]
		public static Color32 ReadColor32RGBA(this BinaryReader r)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xAB7764", Offset = "0xAB7764", VA = "0xAB7764")]
		public static Color32 ReadColor32RGB(this BinaryReader r)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xAB77E4", Offset = "0xAB77E4", VA = "0xAB77E4")]
		public static Color32 ReadColor32BGR(this BinaryReader r)
		{
			return default(Color32);
		}
	}
	[Token(Token = "0x20000AA")]
	public static class DDSLoader
	{
		[Token(Token = "0x6000447")]
		[Address(RVA = "0xAB80E0", Offset = "0xAB80E0", VA = "0xAB80E0")]
		public static Texture2D Load(Stream ddsStream)
		{
			return null;
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xAB845C", Offset = "0xAB845C", VA = "0xAB845C")]
		public static Texture2D Load(string ddsPath)
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xAB8188", Offset = "0xAB8188", VA = "0xAB8188")]
		public static Texture2D Load(byte[] ddsBytes)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AB")]
	public class ImageLoader
	{
		[Token(Token = "0x20001C6")]
		public enum TextureFormat
		{
			[Token(Token = "0x4000980")]
			DDS,
			[Token(Token = "0x4000981")]
			TGA,
			[Token(Token = "0x4000982")]
			BMP,
			[Token(Token = "0x4000983")]
			PNG,
			[Token(Token = "0x4000984")]
			JPG,
			[Token(Token = "0x4000985")]
			CRN
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xAB84EC", Offset = "0xAB84EC", VA = "0xAB84EC")]
		public static void SetNormalMap(ref Texture2D tex)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xAB8590", Offset = "0xAB8590", VA = "0xAB8590")]
		public static Texture2D LoadTexture(Stream stream, TextureFormat format)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xAB8AD0", Offset = "0xAB8AD0", VA = "0xAB8AD0")]
		public static Texture2D LoadTexture(string fn)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xAB93D0", Offset = "0xAB93D0", VA = "0xAB93D0")]
		public ImageLoader()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class ImageLoaderHelper
	{
		[Token(Token = "0x600044E")]
		[Address(RVA = "0xAB9254", Offset = "0xAB9254", VA = "0xAB9254")]
		public static Texture2D VerifyFormat(Texture2D tex)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xAB93D8", Offset = "0xAB93D8", VA = "0xAB93D8")]
		public static void FillPixelArray(Color32[] fillArray, byte[] pixelData, int bytesPerPixel, bool bgra = false)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xAB96B0", Offset = "0xAB96B0", VA = "0xAB96B0")]
		public ImageLoaderHelper()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public static class ImageUtils
	{
		[Token(Token = "0x6000451")]
		[Address(RVA = "0xAB96B8", Offset = "0xAB96B8", VA = "0xAB96B8")]
		public static Texture2D ConvertToNormalMap(Texture2D tex)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AE")]
	public class TGALoader
	{
		[Token(Token = "0x6000452")]
		[Address(RVA = "0xABBFB4", Offset = "0xABBFB4", VA = "0xABBFB4")]
		private static int GetBits(byte b, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xABBFCC", Offset = "0xABBFCC", VA = "0xABBFCC")]
		private static Color32[] LoadRawTGAData(BinaryReader r, int bitDepth, int width, int height)
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xABC08C", Offset = "0xABC08C", VA = "0xABC08C")]
		private static Color32[] LoadRLETGAData(BinaryReader r, int bitDepth, int width, int height)
		{
			return null;
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xABC258", Offset = "0xABC258", VA = "0xABC258")]
		public static Texture2D Load(string fileName)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xAB9138", Offset = "0xAB9138", VA = "0xAB9138")]
		public static Texture2D Load(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xAB8710", Offset = "0xAB8710", VA = "0xAB8710")]
		public static Texture2D Load(Stream TGAStream)
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xABC360", Offset = "0xABC360", VA = "0xABC360")]
		public TGALoader()
		{
		}
	}
}
namespace Dummiesman.Extensions
{
	[Token(Token = "0x20000AF")]
	public static class ColorExtensions
	{
		[Token(Token = "0x6000459")]
		[Address(RVA = "0xAB8474", Offset = "0xAB8474", VA = "0xAB8474")]
		public static Color FlipRB(this Color color)
		{
			return default(Color);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xAB84B0", Offset = "0xAB84B0", VA = "0xAB84B0")]
		public static Color32 FlipRB(this Color32 color)
		{
			return default(Color32);
		}
	}
}
namespace LibTessDotNet
{
	[Token(Token = "0x20000B0")]
	internal class Dict<TValue> where TValue : class
	{
		[Token(Token = "0x20001C7")]
		public class Node
		{
			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _prev;

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _next;

			[Token(Token = "0x17000057")]
			public TValue Key
			{
				[Token(Token = "0x6000A47")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000058")]
			public Node Prev
			{
				[Token(Token = "0x6000A48")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000059")]
			public Node Next
			{
				[Token(Token = "0x6000A49")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A4A")]
			public Node()
			{
			}
		}

		[Token(Token = "0x20001C8")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Node _head;

		[Token(Token = "0x600045B")]
		public Dict(LessOrEqual leq)
		{
		}

		[Token(Token = "0x600045C")]
		public Node Insert(TValue key)
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		public Node InsertBefore(Node node, TValue key)
		{
			return null;
		}

		[Token(Token = "0x600045E")]
		public Node Find(TValue key)
		{
			return null;
		}

		[Token(Token = "0x600045F")]
		public Node Min()
		{
			return null;
		}

		[Token(Token = "0x6000460")]
		public void Remove(Node node)
		{
		}
	}
	[Token(Token = "0x20000B1")]
	internal static class Geom
	{
		[Token(Token = "0x6000461")]
		[Address(RVA = "0xE46A98", Offset = "0xE46A98", VA = "0xE46A98")]
		public static bool IsWindingInside(WindingRule rule, int n)
		{
			return default(bool);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xE46B74", Offset = "0xE46B74", VA = "0xE46B74")]
		public static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(bool);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xE46BC8", Offset = "0xE46BC8", VA = "0xE46BC8")]
		public static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xE46C0C", Offset = "0xE46C0C", VA = "0xE46C0C")]
		public static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xE46C5C", Offset = "0xE46C5C", VA = "0xE46C5C")]
		public static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xE46CD0", Offset = "0xE46CD0", VA = "0xE46CD0")]
		public static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xE46D34", Offset = "0xE46D34", VA = "0xE46D34")]
		public static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xE46D84", Offset = "0xE46D84", VA = "0xE46D84")]
		public static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xE46DF8", Offset = "0xE46DF8", VA = "0xE46DF8")]
		public static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xE46E5C", Offset = "0xE46E5C", VA = "0xE46E5C")]
		public static bool EdgeGoesLeft(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xE46EA4", Offset = "0xE46EA4", VA = "0xE46EA4")]
		public static bool EdgeGoesRight(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xE46ECC", Offset = "0xE46ECC", VA = "0xE46ECC")]
		public static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v)
		{
			return default(float);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xE46F68", Offset = "0xE46F68", VA = "0xE46F68")]
		public static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xE46FB4", Offset = "0xE46FB4", VA = "0xE46FB4")]
		public static float Interpolate(float a, float x, float b, float y)
		{
			return default(float);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xE47010", Offset = "0xE47010", VA = "0xE47010")]
		private static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xE47024", Offset = "0xE47024", VA = "0xE47024")]
		public static void EdgeIntersect(MeshUtils.Vertex o1, MeshUtils.Vertex d1, MeshUtils.Vertex o2, MeshUtils.Vertex d2, MeshUtils.Vertex v)
		{
		}
	}
	[Token(Token = "0x20000B2")]
	internal class Mesh : Pooled<Mesh>
	{
		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal MeshUtils.Vertex _vHead;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal MeshUtils.Face _fHead;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal MeshUtils.Edge _eHead;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal MeshUtils.Edge _eHeadSym;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xE47384", Offset = "0xE47384", VA = "0xE47384", Slot = "4")]
		public void Init(IPool pool)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xE4755C", Offset = "0xE4755C", VA = "0xE4755C", Slot = "5")]
		public void Reset(IPool pool)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xE476F8", Offset = "0xE476F8", VA = "0xE476F8")]
		public MeshUtils.Edge MakeEdge(IPool pool)
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xE47998", Offset = "0xE47998", VA = "0xE47998")]
		public void Splice(IPool pool, MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xE47C40", Offset = "0xE47C40", VA = "0xE47C40")]
		public void Delete(IPool pool, MeshUtils.Edge eDel)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xE47EB4", Offset = "0xE47EB4", VA = "0xE47EB4")]
		public MeshUtils.Edge AddEdgeVertex(IPool pool, MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xE47F34", Offset = "0xE47F34", VA = "0xE47F34")]
		public MeshUtils.Edge SplitEdge(IPool pool, MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xE48028", Offset = "0xE48028", VA = "0xE48028")]
		public MeshUtils.Edge Connect(IPool pool, MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xE48108", Offset = "0xE48108", VA = "0xE48108")]
		public void ZapFace(IPool pool, MeshUtils.Face fZap)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xE4826C", Offset = "0xE4826C", VA = "0xE4826C")]
		public void MergeConvexFaces(IPool pool, int maxVertsPerFace)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xE48444", Offset = "0xE48444", VA = "0xE48444")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x77AFEC", Offset = "0x77AFEC")]
		public void Check()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xE484E0", Offset = "0xE484E0", VA = "0xE484E0")]
		public Mesh()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x7789CC", Offset = "0x7789CC")]
	public struct Vec3
	{
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vec3 Zero;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float X;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Y;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Z;

		[Token(Token = "0x17000017")]
		public float Item
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0xE4BB9C", Offset = "0xE4BB9C", VA = "0xE4BB9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600047E")]
			[Address(RVA = "0xE4B6C8", Offset = "0xE4B6C8", VA = "0xE4B6C8")]
			set
			{
			}
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xE4B580", Offset = "0xE4B580", VA = "0xE4B580")]
		public Vec3(float x, float y, float z)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xE4B58C", Offset = "0xE4B58C", VA = "0xE4B58C")]
		public static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xE4B888", Offset = "0xE4B888", VA = "0xE4B888")]
		public static void Neg(ref Vec3 v)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xE4BC3C", Offset = "0xE4BC3C", VA = "0xE4BC3C")]
		public static void Dot(ref Vec3 u, ref Vec3 v, out float dot)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xE4CD8C", Offset = "0xE4CD8C", VA = "0xE4CD8C")]
		public static void Normalize(ref Vec3 v)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xE4B5C0", Offset = "0xE4B5C0", VA = "0xE4B5C0")]
		public static int LongAxis(ref Vec3 v)
		{
			return default(int);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xE4CE44", Offset = "0xE4CE44", VA = "0xE4CE44", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000B4")]
	public interface ITypePool
	{
		[Token(Token = "0x6000487")]
		object Get();

		[Token(Token = "0x6000488")]
		void Return(object obj);
	}
	[Token(Token = "0x20000B5")]
	public class DefaultTypePool<T> : ITypePool where T : class, Pooled<T>, new()
	{
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T> _pool;

		[Token(Token = "0x6000489")]
		public object Get()
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		public void Return(object obj)
		{
		}

		[Token(Token = "0x600048B")]
		public DefaultTypePool()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public abstract class IPool
	{
		[Token(Token = "0x600048C")]
		[Address(RVA = "0xE468F0", Offset = "0xE468F0", VA = "0xE468F0")]
		public IPool()
		{
		}

		[Token(Token = "0x600048D")]
		public abstract void Register<T>(ITypePool typePool) where T : class, Pooled<T>, new();

		[Token(Token = "0x600048E")]
		public abstract T Get<T>() where T : class, Pooled<T>, new();

		[Token(Token = "0x600048F")]
		public abstract void Return<T>(T obj) where T : class, Pooled<T>, new();
	}
	[Token(Token = "0x20000B7")]
	public class NullPool : IPool
	{
		[Token(Token = "0x6000490")]
		public override T Get<T>()
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		public override void Register<T>(ITypePool typePool)
		{
		}

		[Token(Token = "0x6000492")]
		public override void Return<T>(T obj)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xE487AC", Offset = "0xE487AC", VA = "0xE487AC")]
		public NullPool()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class DefaultPool : IPool
	{
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IDictionary<Type, ITypePool> _register;

		[Token(Token = "0x6000494")]
		public override void Register<T>(ITypePool typePool)
		{
		}

		[Token(Token = "0x6000495")]
		public override T Get<T>()
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		public override void Return<T>(T obj)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xE468EC", Offset = "0xE468EC", VA = "0xE468EC")]
		public DefaultPool()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public interface Pooled<T> where T : class, Pooled<T>, new()
	{
		[Token(Token = "0x6000498")]
		void Init(IPool pool);

		[Token(Token = "0x6000499")]
		void Reset(IPool pool);
	}
	[Token(Token = "0x20000BA")]
	internal static class MeshUtils
	{
		[Token(Token = "0x20001C9")]
		internal class Vertex : Pooled<Vertex>
		{
			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Vertex _prev;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Vertex _next;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Vec3 _coords;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal float _s;

			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal float _t;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal PQHandle _pqHandle;

			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int _n;

			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal object _data;

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0xE48714", Offset = "0xE48714", VA = "0xE48714", Slot = "4")]
			public void Init(IPool pool)
			{
			}

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0xE48718", Offset = "0xE48718", VA = "0xE48718", Slot = "5")]
			public void Reset(IPool pool)
			{
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0xE487A4", Offset = "0xE487A4", VA = "0xE487A4")]
			public Vertex()
			{
			}
		}

		[Token(Token = "0x20001CA")]
		internal class Face : Pooled<Face>
		{
			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Face _prev;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Face _next;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Face _trail;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int _n;

			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool _marked;

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
			internal bool _inside;

			[Token(Token = "0x1700005A")]
			internal int VertsCount
			{
				[Token(Token = "0x6000A52")]
				[Address(RVA = "0xE483F4", Offset = "0xE483F4", VA = "0xE483F4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0xE486F8", Offset = "0xE486F8", VA = "0xE486F8", Slot = "4")]
			public void Init(IPool pool)
			{
			}

			[Token(Token = "0x6000A54")]
			[Address(RVA = "0xE486FC", Offset = "0xE486FC", VA = "0xE486FC", Slot = "5")]
			public void Reset(IPool pool)
			{
			}

			[Token(Token = "0x6000A55")]
			[Address(RVA = "0xE4870C", Offset = "0xE4870C", VA = "0xE4870C")]
			public Face()
			{
			}
		}

		[Token(Token = "0x20001CB")]
		internal struct EdgePair
		{
			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Edge _e;

			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Edge _eSym;

			[Token(Token = "0x6000A56")]
			[Address(RVA = "0xE474A0", Offset = "0xE474A0", VA = "0xE474A0")]
			public static EdgePair Create(IPool pool)
			{
				return default(EdgePair);
			}

			[Token(Token = "0x6000A57")]
			[Address(RVA = "0xE486E8", Offset = "0xE486E8", VA = "0xE486E8")]
			public void Reset(IPool pool)
			{
			}
		}

		[Token(Token = "0x20001CC")]
		internal class Edge : Pooled<Edge>
		{
			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal EdgePair _pair;

			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _next;

			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Edge _Sym;

			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Edge _Onext;

			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Edge _Lnext;

			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Vertex _Org;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Face _Lface;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Tess.ActiveRegion _activeRegion;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal int _winding;

			[Token(Token = "0x1700005B")]
			internal Face _Rface
			{
				[Token(Token = "0x6000A58")]
				[Address(RVA = "0xE47D80", Offset = "0xE47D80", VA = "0xE47D80")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A59")]
				[Address(RVA = "0xE4800C", Offset = "0xE4800C", VA = "0xE4800C")]
				set
				{
				}
			}

			[Token(Token = "0x1700005C")]
			internal Vertex _Dst
			{
				[Token(Token = "0x6000A5A")]
				[Address(RVA = "0xE46E88", Offset = "0xE46E88", VA = "0xE46E88")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A5B")]
				[Address(RVA = "0xE47FF0", Offset = "0xE47FF0", VA = "0xE47FF0")]
				set
				{
				}
			}

			[Token(Token = "0x1700005D")]
			internal Edge _Oprev
			{
				[Token(Token = "0x6000A5C")]
				[Address(RVA = "0xE47D9C", Offset = "0xE47D9C", VA = "0xE47D9C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A5D")]
				[Address(RVA = "0xE4857C", Offset = "0xE4857C", VA = "0xE4857C")]
				set
				{
				}
			}

			[Token(Token = "0x1700005E")]
			internal Edge _Lprev
			{
				[Token(Token = "0x6000A5E")]
				[Address(RVA = "0xE48428", Offset = "0xE48428", VA = "0xE48428")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A5F")]
				[Address(RVA = "0xE48598", Offset = "0xE48598", VA = "0xE48598")]
				set
				{
				}
			}

			[Token(Token = "0x1700005F")]
			internal Edge _Dprev
			{
				[Token(Token = "0x6000A60")]
				[Address(RVA = "0xE485B4", Offset = "0xE485B4", VA = "0xE485B4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A61")]
				[Address(RVA = "0xE485D0", Offset = "0xE485D0", VA = "0xE485D0")]
				set
				{
				}
			}

			[Token(Token = "0x17000060")]
			internal Edge _Rprev
			{
				[Token(Token = "0x6000A62")]
				[Address(RVA = "0xE485EC", Offset = "0xE485EC", VA = "0xE485EC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A63")]
				[Address(RVA = "0xE48608", Offset = "0xE48608", VA = "0xE48608")]
				set
				{
				}
			}

			[Token(Token = "0x17000061")]
			internal Edge _Dnext
			{
				[Token(Token = "0x6000A64")]
				[Address(RVA = "0xE48624", Offset = "0xE48624", VA = "0xE48624")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A65")]
				[Address(RVA = "0xE4864C", Offset = "0xE4864C", VA = "0xE4864C")]
				set
				{
				}
			}

			[Token(Token = "0x17000062")]
			internal Edge _Rnext
			{
				[Token(Token = "0x6000A66")]
				[Address(RVA = "0xE48674", Offset = "0xE48674", VA = "0xE48674")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A67")]
				[Address(RVA = "0xE4869C", Offset = "0xE4869C", VA = "0xE4869C")]
				set
				{
				}
			}

			[Token(Token = "0x6000A68")]
			[Address(RVA = "0xE484E8", Offset = "0xE484E8", VA = "0xE484E8")]
			internal static void EnsureFirst(ref Edge e)
			{
			}

			[Token(Token = "0x6000A69")]
			[Address(RVA = "0xE486C4", Offset = "0xE486C4", VA = "0xE486C4", Slot = "4")]
			public void Init(IPool pool)
			{
			}

			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0xE486C8", Offset = "0xE486C8", VA = "0xE486C8", Slot = "5")]
			public void Reset(IPool pool)
			{
			}

			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0xE486F0", Offset = "0xE486F0", VA = "0xE486F0")]
			public Edge()
			{
			}
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xE47BF4", Offset = "0xE47BF4", VA = "0xE47BF4")]
		public static void Splice(Edge a, Edge b)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xE47804", Offset = "0xE47804", VA = "0xE47804")]
		public static void MakeVertex(IPool pool, Edge eOrig, Vertex vNext)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xE478C8", Offset = "0xE478C8", VA = "0xE478C8")]
		public static void MakeFace(IPool pool, Edge eOrig, Face fNext)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xE47770", Offset = "0xE47770", VA = "0xE47770")]
		public static Edge MakeEdge(IPool pool, Edge eNext)
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xE47DB8", Offset = "0xE47DB8", VA = "0xE47DB8")]
		public static void KillEdge(IPool pool, Edge eDel)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xE47A74", Offset = "0xE47A74", VA = "0xE47A74")]
		public static void KillVertex(IPool pool, Vertex vDel, Vertex newOrg)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xE47B34", Offset = "0xE47B34", VA = "0xE47B34")]
		public static void KillFace(IPool pool, Face fDel, Face newLFace)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xE48518", Offset = "0xE48518", VA = "0xE48518")]
		public static float FaceArea(Face f)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000BB")]
	internal struct PQHandle
	{
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int Invalid;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int _handle;
	}
	[Token(Token = "0x20000BC")]
	internal class PriorityHeap<TValue> where TValue : class
	{
		[Token(Token = "0x20001CD")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x20001CE")]
		protected class HandleElem
		{
			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _node;

			[Token(Token = "0x6000A70")]
			public HandleElem()
			{
			}
		}

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _nodes;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HandleElem[] _handles;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _freeList;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x17000018")]
		public bool Empty
		{
			[Token(Token = "0x60004A3")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004A4")]
		public PriorityHeap(int initialSize, LessOrEqual leq)
		{
		}

		[Token(Token = "0x60004A5")]
		private void FloatDown(int curr)
		{
		}

		[Token(Token = "0x60004A6")]
		private void FloatUp(int curr)
		{
		}

		[Token(Token = "0x60004A7")]
		public void Init()
		{
		}

		[Token(Token = "0x60004A8")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x60004A9")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x20000BD")]
	internal class PriorityQueue<TValue> where TValue : class
	{
		[Token(Token = "0x20001CF")]
		private class StackItem
		{
			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int p;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int r;

			[Token(Token = "0x6000A71")]
			public StackItem()
			{
			}
		}

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue>.LessOrEqual _leq;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue> _heap;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TValue[] _keys;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _order;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x17000019")]
		public bool Empty
		{
			[Token(Token = "0x60004AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004AD")]
		public PriorityQueue(int initialSize, PriorityHeap<TValue>.LessOrEqual leq)
		{
		}

		[Token(Token = "0x60004AE")]
		private static void Swap(ref int a, ref int b)
		{
		}

		[Token(Token = "0x60004AF")]
		public void Init()
		{
		}

		[Token(Token = "0x60004B0")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x60004B1")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x60004B3")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class Tess
	{
		[Token(Token = "0x20001D0")]
		internal class ActiveRegion : Pooled<ActiveRegion>
		{
			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MeshUtils.Edge _eUp;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Dict<ActiveRegion>.Node _nodeUp;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int _windingNumber;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool _inside;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			internal bool _sentinel;

			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			internal bool _dirty;

			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
			internal bool _fixUpperEdge;

			[Token(Token = "0x6000A72")]
			[Address(RVA = "0xE4CD74", Offset = "0xE4CD74", VA = "0xE4CD74", Slot = "4")]
			public void Init(IPool pool)
			{
			}

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0xE4CD78", Offset = "0xE4CD78", VA = "0xE4CD78", Slot = "5")]
			public void Reset(IPool pool)
			{
			}

			[Token(Token = "0x6000A74")]
			[Address(RVA = "0xE4CD84", Offset = "0xE4CD84", VA = "0xE4CD84")]
			public ActiveRegion()
			{
			}
		}

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IPool _pool;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Mesh _mesh;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vec3 _normal;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vec3 _sUnit;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vec3 _tUnit;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _bminX;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _bminY;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _bmaxX;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _bmaxY;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private WindingRule _windingRule;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dict<ActiveRegion> _dict;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PriorityQueue<MeshUtils.Vertex> _pq;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MeshUtils.Vertex _event;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private CombineCallback _combineCallback;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ContourVertex[] _vertices;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _vertexCount;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int[] _elements;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _elementCount;

		[Token(Token = "0x4000476")]
		public const int Undef = -1;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float SUnitX;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float SUnitY;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float SentinelCoord;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool NoEmptyPolygons;

		[Token(Token = "0x1700001A")]
		public Vec3 Normal
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0xE4ADD0", Offset = "0xE4ADD0", VA = "0xE4ADD0")]
			get
			{
				return default(Vec3);
			}
		}

		[Token(Token = "0x1700001B")]
		public ContourVertex[] Vertices
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xE4ADDC", Offset = "0xE4ADDC", VA = "0xE4ADDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public int VertexCount
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xE4ADE4", Offset = "0xE4ADE4", VA = "0xE4ADE4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001D")]
		public int[] Elements
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xE4ADEC", Offset = "0xE4ADEC", VA = "0xE4ADEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public int ElementCount
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xE4ADF4", Offset = "0xE4ADF4", VA = "0xE4ADF4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xE48804", Offset = "0xE48804", VA = "0xE48804")]
		private ActiveRegion RegionBelow(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xE48830", Offset = "0xE48830", VA = "0xE48830")]
		private ActiveRegion RegionAbove(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xE4885C", Offset = "0xE4885C", VA = "0xE4885C")]
		private bool EdgeLeq(ActiveRegion reg1, ActiveRegion reg2)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xE48970", Offset = "0xE48970", VA = "0xE48970")]
		private void DeleteRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xE48A24", Offset = "0xE48A24", VA = "0xE48A24")]
		private void FixUpperEdge(ActiveRegion reg, MeshUtils.Edge newEdge)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xE48A70", Offset = "0xE48A70", VA = "0xE48A70")]
		private ActiveRegion TopLeftRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xE48B34", Offset = "0xE48B34", VA = "0xE48B34")]
		private ActiveRegion TopRightRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xE48B94", Offset = "0xE48B94", VA = "0xE48B94")]
		private ActiveRegion AddRegionBelow(ActiveRegion regAbove, MeshUtils.Edge eNewUp)
		{
			return null;
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xE48C68", Offset = "0xE48C68", VA = "0xE48C68")]
		private void ComputeWinding(ActiveRegion reg)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xE48CC0", Offset = "0xE48CC0", VA = "0xE48CC0")]
		private void FinishRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xE48CF4", Offset = "0xE48CF4", VA = "0xE48CF4")]
		private MeshUtils.Edge FinishLeftRegions(ActiveRegion regFirst, ActiveRegion regLast)
		{
			return null;
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xE48E34", Offset = "0xE48E34", VA = "0xE48E34")]
		private void AddRightEdges(ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xE49400", Offset = "0xE49400", VA = "0xE49400")]
		private void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xE49424", Offset = "0xE49424", VA = "0xE49424")]
		private void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xE49520", Offset = "0xE49520", VA = "0xE49520")]
		private void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xE49000", Offset = "0xE49000", VA = "0xE49000")]
		private bool CheckForRightSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xE49798", Offset = "0xE49798", VA = "0xE49798")]
		private bool CheckForLeftSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xE49918", Offset = "0xE49918", VA = "0xE49918")]
		private bool CheckForIntersect(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xE491C4", Offset = "0xE491C4", VA = "0xE491C4")]
		private void WalkDirtyRegions(ActiveRegion regUp)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xE4A01C", Offset = "0xE4A01C", VA = "0xE4A01C")]
		private void ConnectRightVertex(ActiveRegion regUp, MeshUtils.Edge eBottomLeft)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xE4A228", Offset = "0xE4A228", VA = "0xE4A228")]
		private void ConnectLeftDegenerate(ActiveRegion regUp, MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xE4A41C", Offset = "0xE4A41C", VA = "0xE4A41C")]
		private void ConnectLeftVertex(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xE4A344", Offset = "0xE4A344", VA = "0xE4A344")]
		private void SweepEvent(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xE4A6A0", Offset = "0xE4A6A0", VA = "0xE4A6A0")]
		private void AddSentinel(float smin, float smax, float t)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xE4A7DC", Offset = "0xE4A7DC", VA = "0xE4A7DC")]
		private void InitEdgeDict()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xE4A8A8", Offset = "0xE4A8A8", VA = "0xE4A8A8")]
		private void DoneEdgeDict()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xE4A924", Offset = "0xE4A924", VA = "0xE4A924")]
		private void RemoveDegenerateEdges()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xE4AA70", Offset = "0xE4AA70", VA = "0xE4AA70")]
		private void InitPriorityQ()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xE4AC2C", Offset = "0xE4AC2C", VA = "0xE4AC2C")]
		private void DonePriorityQ()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xE4AC34", Offset = "0xE4AC34", VA = "0xE4AC34")]
		private void RemoveDegenerateFaces()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xE4ACD0", Offset = "0xE4ACD0", VA = "0xE4ACD0")]
		protected void ComputeInterior()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xE4ADFC", Offset = "0xE4ADFC", VA = "0xE4ADFC")]
		public Tess()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xE4AE5C", Offset = "0xE4AE5C", VA = "0xE4AE5C")]
		public Tess(IPool pool)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xE4AF44", Offset = "0xE4AF44", VA = "0xE4AF44")]
		private void ComputeNormal(ref Vec3 norm)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xE4B774", Offset = "0xE4B774", VA = "0xE4B774")]
		private void CheckOrientation()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xE4B8A4", Offset = "0xE4B8A4", VA = "0xE4B8A4")]
		private void ProjectPolygon()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xE4BC68", Offset = "0xE4BC68", VA = "0xE4BC68")]
		private void TessellateMonoRegion(MeshUtils.Face face)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xE4BE64", Offset = "0xE4BE64", VA = "0xE4BE64")]
		private void TessellateInterior()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xE4BED0", Offset = "0xE4BED0", VA = "0xE4BED0")]
		private void DiscardExterior()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xE4BF3C", Offset = "0xE4BF3C", VA = "0xE4BF3C")]
		private void SetWindingNumber(int value, bool keepOnlyBoundary)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xE4C010", Offset = "0xE4C010", VA = "0xE4C010")]
		private int GetNeighbourFace(MeshUtils.Edge edge)
		{
			return default(int);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xE4C04C", Offset = "0xE4C04C", VA = "0xE4C04C")]
		private void OutputPolymesh(ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xE4C484", Offset = "0xE4C484", VA = "0xE4C484")]
		private void OutputContours()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xE4C698", Offset = "0xE4C698", VA = "0xE4C698")]
		private float SignedArea(IList<ContourVertex> vertices)
		{
			return default(float);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xE4C8E8", Offset = "0xE4C8E8", VA = "0xE4C8E8")]
		public void AddContour(ContourVertex[] vertices, ContourOrientation forceOrientation = ContourOrientation.Original)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xE4CC44", Offset = "0xE4CC44", VA = "0xE4CC44")]
		public void AddContour(IList<ContourVertex> vertices, ContourOrientation forceOrientation = ContourOrientation.Original)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xE4C8EC", Offset = "0xE4C8EC", VA = "0xE4C8EC")]
		private void AddContourInternal(IList<ContourVertex> vertices, ContourOrientation forceOrientation)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xE4CC48", Offset = "0xE4CC48", VA = "0xE4CC48")]
		public void Tessellate(WindingRule windingRule = WindingRule.EvenOdd, ElementType elementType = ElementType.Polygons, int polySize = 3, [Optional] CombineCallback combineCallback, [Optional] Vec3 normal)
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public enum WindingRule
	{
		[Token(Token = "0x400047C")]
		EvenOdd,
		[Token(Token = "0x400047D")]
		NonZero,
		[Token(Token = "0x400047E")]
		Positive,
		[Token(Token = "0x400047F")]
		Negative,
		[Token(Token = "0x4000480")]
		AbsGeqTwo
	}
	[Token(Token = "0x20000C0")]
	public enum ElementType
	{
		[Token(Token = "0x4000482")]
		Polygons,
		[Token(Token = "0x4000483")]
		ConnectedPolygons,
		[Token(Token = "0x4000484")]
		BoundaryContours
	}
	[Token(Token = "0x20000C1")]
	public enum ContourOrientation
	{
		[Token(Token = "0x4000486")]
		Original,
		[Token(Token = "0x4000487")]
		Clockwise,
		[Token(Token = "0x4000488")]
		CounterClockwise
	}
	[Token(Token = "0x20000C2")]
	public struct ContourVertex
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vec3 Position;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public object Data;

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xE46850", Offset = "0xE46850", VA = "0xE46850")]
		public ContourVertex(Vec3 position, [Optional] object data)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xE46860", Offset = "0xE46860", VA = "0xE46860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000C3")]
	public delegate object CombineCallback(Vec3 position, object[] data, float[] weights);
}
namespace B83.Image.BMP
{
	[Token(Token = "0x20000C4")]
	public enum BMPComressionMode
	{
		[Token(Token = "0x400048C")]
		BI_RGB = 0,
		[Token(Token = "0x400048D")]
		BI_RLE8 = 1,
		[Token(Token = "0x400048E")]
		BI_RLE4 = 2,
		[Token(Token = "0x400048F")]
		BI_BITFIELDS = 3,
		[Token(Token = "0x4000490")]
		BI_JPEG = 4,
		[Token(Token = "0x4000491")]
		BI_PNG = 5,
		[Token(Token = "0x4000492")]
		BI_ALPHABITFIELDS = 6,
		[Token(Token = "0x4000493")]
		BI_CMYK = 11,
		[Token(Token = "0x4000494")]
		BI_CMYKRLE8 = 12,
		[Token(Token = "0x4000495")]
		BI_CMYKRLE4 = 13
	}
	[Token(Token = "0x20000C5")]
	public struct BMPFileHeader
	{
		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ushort magic;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint filesize;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint reserved;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint offset;
	}
	[Token(Token = "0x20000C6")]
	public struct BitmapInfoHeader
	{
		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint size;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int width;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int height;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ushort nColorPlanes;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public ushort nBitsPerPixel;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BMPComressionMode compressionMethod;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint rawImageSize;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int xPPM;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int yPPM;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint nPaletteColors;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint nImportantColors;

		[Token(Token = "0x1700001F")]
		public int absWidth
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xD51B70", Offset = "0xD51B70", VA = "0xD51B70")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000020")]
		public int absHeight
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xD51BDC", Offset = "0xD51BDC", VA = "0xD51BDC")]
			get
			{
				return default(int);
			}
		}
	}
	[Token(Token = "0x20000C7")]
	public class BMPImage
	{
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BMPFileHeader header;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BitmapInfoHeader info;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public uint rMask;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public uint gMask;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public uint bMask;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public uint aMask;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<Color32> palette;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Color32[] imageData;

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xD51ABC", Offset = "0xD51ABC", VA = "0xD51ABC")]
		public Texture2D ToTexture2D()
		{
			return null;
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xD51C48", Offset = "0xD51C48", VA = "0xD51C48")]
		public BMPImage()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class BMPLoader
	{
		[Token(Token = "0x40004AD")]
		private const ushort MAGIC = 19778;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool ReadPaletteAlpha;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool ForceAlphaReadWhenPossible;

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xD51C60", Offset = "0xD51C60", VA = "0xD51C60")]
		public BMPImage LoadBMP(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xD51E98", Offset = "0xD51E98", VA = "0xD51E98")]
		public BMPImage LoadBMP(byte[] aData)
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xD51D74", Offset = "0xD51D74", VA = "0xD51D74")]
		public BMPImage LoadBMP(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xD51FBC", Offset = "0xD51FBC", VA = "0xD51FBC")]
		public BMPImage LoadBMP(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xD52890", Offset = "0xD52890", VA = "0xD52890")]
		private static void Read32BitImage(BinaryReader aReader, BMPImage bmp)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xD52B44", Offset = "0xD52B44", VA = "0xD52B44")]
		private static void Read24BitImage(BinaryReader aReader, BMPImage bmp)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xD5302C", Offset = "0xD5302C", VA = "0xD5302C")]
		private static void Read16BitImage(BinaryReader aReader, BMPImage bmp)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xD53C5C", Offset = "0xD53C5C", VA = "0xD53C5C")]
		private static void ReadIndexedImage(BinaryReader aReader, BMPImage bmp)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xD53530", Offset = "0xD53530", VA = "0xD53530")]
		private static void ReadIndexedImageRLE4(BinaryReader aReader, BMPImage bmp)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xD53980", Offset = "0xD53980", VA = "0xD53980")]
		private static void ReadIndexedImageRLE8(BinaryReader aReader, BMPImage bmp)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xD54118", Offset = "0xD54118", VA = "0xD54118")]
		private static int GetShiftCount(uint mask)
		{
			return default(int);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xD52708", Offset = "0xD52708", VA = "0xD52708")]
		private static uint GetMask(int bitCount)
		{
			return default(uint);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xD52504", Offset = "0xD52504", VA = "0xD52504")]
		private static bool ReadFileHeader(BinaryReader aReader, ref BMPFileHeader aFileHeader)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xD525A4", Offset = "0xD525A4", VA = "0xD525A4")]
		private static bool ReadInfoHeader(BinaryReader aReader, ref BitmapInfoHeader aHeader)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xD52738", Offset = "0xD52738", VA = "0xD52738")]
		public static List<Color32> ReadPalette(BinaryReader aReader, BMPImage aBmp, bool aReadAlpha)
		{
			return null;
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xD5423C", Offset = "0xD5423C", VA = "0xD5423C")]
		public BMPLoader()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class BitStreamReader
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BinaryReader m_Reader;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private byte m_Data;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_Bits;

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xD54140", Offset = "0xD54140", VA = "0xD54140")]
		public BitStreamReader(BinaryReader aReader)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xD54244", Offset = "0xD54244", VA = "0xD54244")]
		public BitStreamReader(Stream aStream)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xD542C0", Offset = "0xD542C0", VA = "0xD542C0")]
		public byte ReadBit()
		{
			return default(byte);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xD5416C", Offset = "0xD5416C", VA = "0xD5416C")]
		public ulong ReadBits(int aCount)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xD54230", Offset = "0xD54230", VA = "0xD54230")]
		public void Flush()
		{
		}
	}
}
namespace B83.MeshTools
{
	[Serializable]
	[Token(Token = "0x20000CA")]
	public class MeshData
	{
		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		private byte[] m_Data;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Mesh m_Mesh;

		[Token(Token = "0x17000021")]
		public byte[] Data
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0xD54D98", Offset = "0xD54D98", VA = "0xD54D98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xD54DA0", Offset = "0xD54DA0", VA = "0xD54DA0")]
		public void SetMesh(Mesh aMesh)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xD54F74", Offset = "0xD54F74", VA = "0xD54F74")]
		public Mesh GetMesh()
		{
			return null;
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xD55128", Offset = "0xD55128", VA = "0xD55128")]
		public MeshData()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public static class MeshSerializer
	{
		[Token(Token = "0x20001D1")]
		private enum EChunkID : byte
		{
			[Token(Token = "0x40009B0")]
			End,
			[Token(Token = "0x40009B1")]
			Name,
			[Token(Token = "0x40009B2")]
			Normals,
			[Token(Token = "0x40009B3")]
			Tangents,
			[Token(Token = "0x40009B4")]
			Colors,
			[Token(Token = "0x40009B5")]
			BoneWeights,
			[Token(Token = "0x40009B6")]
			UV0,
			[Token(Token = "0x40009B7")]
			UV1,
			[Token(Token = "0x40009B8")]
			UV2,
			[Token(Token = "0x40009B9")]
			UV3,
			[Token(Token = "0x40009BA")]
			Submesh,
			[Token(Token = "0x40009BB")]
			Bindposes,
			[Token(Token = "0x40009BC")]
			BlendShape
		}

		[Token(Token = "0x40004B5")]
		private const uint m_Magic = 1752393037u;

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xD54E38", Offset = "0xD54E38", VA = "0xD54E38")]
		public static byte[] SerializeMesh(Mesh aMesh)
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xD55130", Offset = "0xD55130", VA = "0xD55130")]
		public static void SerializeMesh(MemoryStream aStream, Mesh aMesh)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xD55248", Offset = "0xD55248", VA = "0xD55248")]
		public static void SerializeMesh(BinaryWriter aWriter, Mesh aMesh)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xD55004", Offset = "0xD55004", VA = "0xD55004")]
		public static Mesh DeserializeMesh(byte[] aData, [Optional] Mesh aTarget)
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xD56110", Offset = "0xD56110", VA = "0xD56110")]
		public static Mesh DeserializeMesh(MemoryStream aStream, [Optional] Mesh aTarget)
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xD56234", Offset = "0xD56234", VA = "0xD56234")]
		public static Mesh DeserializeMesh(BinaryReader aReader, [Optional] Mesh aTarget)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CC")]
	public static class BinaryReaderWriterUnityExt
	{
		[Token(Token = "0x6000512")]
		[Address(RVA = "0xD54328", Offset = "0xD54328", VA = "0xD54328")]
		public static void WriteVector2(this BinaryWriter aWriter, Vector2 aVec)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xD5437C", Offset = "0xD5437C", VA = "0xD5437C")]
		public static Vector2 ReadVector2(this BinaryReader aReader)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xD543F4", Offset = "0xD543F4", VA = "0xD543F4")]
		public static void WriteVector3(this BinaryWriter aWriter, Vector3 aVec)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xD54464", Offset = "0xD54464", VA = "0xD54464")]
		public static Vector3 ReadVector3(this BinaryReader aReader)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xD54500", Offset = "0xD54500", VA = "0xD54500")]
		public static void WriteVector4(this BinaryWriter aWriter, Vector4 aVec)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xD54594", Offset = "0xD54594", VA = "0xD54594")]
		public static Vector4 ReadVector4(this BinaryReader aReader)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xD54650", Offset = "0xD54650", VA = "0xD54650")]
		public static void WriteColor32(this BinaryWriter aWriter, Color32 aCol)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xD546D0", Offset = "0xD546D0", VA = "0xD546D0")]
		public static Color32 ReadColor32(this BinaryReader aReader)
		{
			return default(Color32);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xD54770", Offset = "0xD54770", VA = "0xD54770")]
		public static void WriteMatrix4x4(this BinaryWriter aWriter, Matrix4x4 aMat)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xD54910", Offset = "0xD54910", VA = "0xD54910")]
		public static Matrix4x4 ReadMatrix4x4(this BinaryReader aReader)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xD54B18", Offset = "0xD54B18", VA = "0xD54B18")]
		public static void WriteBoneWeight(this BinaryWriter aWriter, BoneWeight aWeight)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xD54C4C", Offset = "0xD54C4C", VA = "0xD54C4C")]
		public static BoneWeight ReadBoneWeight(this BinaryReader aReader)
		{
			return default(BoneWeight);
		}
	}
}
namespace teadrinker
{
	[Token(Token = "0x20000CD")]
	internal interface CustomReflectionSupport
	{
		[Token(Token = "0x600051E")]
		CustomReflection GetCustomReflection();
	}
	[Token(Token = "0x20000CE")]
	public class CRData
	{
		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type Type;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public object Default;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public object SetFunc;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public object GetFunc;

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xDDB944", Offset = "0xDDB944", VA = "0xDDB944")]
		public CRData()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class CustomReflection
	{
		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, CRData> _members;

		[Token(Token = "0x6000520")]
		public void Add<T>(string name, T _default, Action<T> set, Func<T> get)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xDDCCC8", Offset = "0xDDCCC8", VA = "0xDDCCC8", Slot = "4")]
		public virtual void ForEachMember(Action<string, CRData> callback)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xDDCDE0", Offset = "0xDDCDE0", VA = "0xDDCDE0", Slot = "5")]
		public virtual void LoadData(BinaryReader r)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xDDCE74", Offset = "0xDDCE74", VA = "0xDDCE74", Slot = "6")]
		public virtual void RecallFromKeyValueStore(KeyValueStore kvin)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xDDD7C8", Offset = "0xDDD7C8", VA = "0xDDD7C8", Slot = "7")]
		public virtual KeyValueStore StoreToKeyValueStore()
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xDDE244", Offset = "0xDDE244", VA = "0xDDE244", Slot = "8")]
		public virtual void SaveData(BinaryWriter w)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xDDE284", Offset = "0xDDE284", VA = "0xDDE284")]
		public CustomReflection()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class MonoBehaviourCR : MonoBehaviour, CustomReflectionSupport
	{
		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CustomReflection _customRefl;

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xDE0A00", Offset = "0xDE0A00", VA = "0xDE0A00", Slot = "4")]
		public CustomReflection GetCustomReflection()
		{
			return null;
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xDE9EA4", Offset = "0xDE9EA4", VA = "0xDE9EA4", Slot = "5")]
		public virtual CustomReflection GenerateCustomReflection()
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xDE60D8", Offset = "0xDE60D8", VA = "0xDE60D8")]
		public MonoBehaviourCR()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class CompressedDepthStream
	{
		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int W;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int H;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int WOrg;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int HOrg;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int XOffset;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int YOffset;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<uint[]> Frames;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint[] GridOptimizeBitmap;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public KeyValueStore MetaData;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xDDB94C", Offset = "0xDDB94C", VA = "0xDDB94C")]
		public void SaveData(BinaryWriter w)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xDDC3C8", Offset = "0xDDC3C8", VA = "0xDDC3C8")]
		public void LoadData(BinaryReader r)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xDDCC38", Offset = "0xDDCC38", VA = "0xDDCC38")]
		public CompressedDepthStream()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class DepthStream : MonoBehaviourCR
	{
		[Token(Token = "0x20001D2")]
		public enum RenderStyle
		{
			[Token(Token = "0x40009BE")]
			Additive,
			[Token(Token = "0x40009BF")]
			Alpha,
			[Token(Token = "0x40009C0")]
			OpaqueWithDepth
		}

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x779D3C", Offset = "0x779D3C")]
		public bool ShowLive;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Record;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool PlayRecording;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float FPS;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779D74", Offset = "0x779D74")]
		public float FramePosition;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _prevFramePos;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2Int ActiveCrop;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x779D8C", Offset = "0x779D8C")]
		public bool SaveRecording;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool LoadRecording;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool ScheduleLoadOnStart;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string RecordingPath;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string RecordingName;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool UseRawFormat;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool AllowPartialLoad;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x779DC4", Offset = "0x779DC4")]
		public int RecorderMaxFrames;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int sensorIndex;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MeshFilter PointCloudExtraTarget;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Material debugView;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x779DFC", Offset = "0x779DFC")]
		public bool PreviewDepth;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779E34", Offset = "0x779E34")]
		public float DepthPreviewMul;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779E4C", Offset = "0x779E4C")]
		public float DepthPreviewAdd;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool PreviewInfra;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int InfraredPreviewDiv;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x779E64", Offset = "0x779E64")]
		public bool PointCloud;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public bool SelfieMirror;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		public bool Portrait;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int PointCloudXSkip;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public int PointCloudYSkip;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x779E9C", Offset = "0x779E9C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x779E9C", Offset = "0x779E9C")]
		public bool ProcessAndCompressAll;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool ProcessDepth;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int MinDepth;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int MaxDepth;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector2 SkewBack;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779EE8", Offset = "0x779EE8")]
		public float Top;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 TopPlane;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779F00", Offset = "0x779F00")]
		public float Bottom;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Vector3 BottomPlane;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779F18", Offset = "0x779F18")]
		public float Left;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Vector3 LeftPlane;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779F30", Offset = "0x779F30")]
		public float Right;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Vector3 RightPlane;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x779F48", Offset = "0x779F48")]
		public bool FilterIR;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779F80", Offset = "0x779F80")]
		public float NoiseDither;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public bool CompressTest;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		public bool DebugNearFar;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float CompTolerance;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public string CompressionRate;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x779F98", Offset = "0x779F98")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x779F98", Offset = "0x779F98")]
		public bool VerticalLines;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		public bool HorisontalLines;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779FE4", Offset = "0x779FE4")]
		public float LineOffset;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x779FFC", Offset = "0x779FFC")]
		public float PointSize;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A014", Offset = "0x77A014")]
		public float ReduceStray;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A02C", Offset = "0x77A02C")]
		public float InfraToSize;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77A044", Offset = "0x77A044")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A044", Offset = "0x77A044")]
		public float DepthToSize;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A084", Offset = "0x77A084")]
		public float DepthToSizeRange;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A09C", Offset = "0x77A09C")]
		public float DepthToSizeCurve;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77A0B4", Offset = "0x77A0B4")]
		public RenderStyle PointCloudRenderStyle;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A0C4", Offset = "0x77A0C4")]
		public float TrailFrames;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77A0DC", Offset = "0x77A0DC")]
		public float InfraredScale;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public float InfraredOffset;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77A0EC", Offset = "0x77A0EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A0EC", Offset = "0x77A0EC")]
		public float ColorAmount;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A12C", Offset = "0x77A12C")]
		public float InfraToColor;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77A144", Offset = "0x77A144")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A144", Offset = "0x77A144")]
		public float analyticalAntialias;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77A188", Offset = "0x77A188")]
		public bool glowEnable;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A198", Offset = "0x77A198")]
		public float glow;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public bool debugGlowSize;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Shader _shader;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Shader _shaderTransparent;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private MeshFilter _pointCloudTarget;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Material _pointCloudMat;

		[Token(Token = "0x400050C")]
		private const int DepthBits = 11;

		[Token(Token = "0x400050D")]
		private const int IntRangeInMM = 2047;

		[Token(Token = "0x400050E")]
		private const int DepthCamNearLimit = 360;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private ushort[] _depthData;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private ComputeBuffer _depthDataBuf;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private ushort[] _infraData;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private ComputeBuffer _infraDataBuf;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Color32[] _infraredPlaybackBuffer;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Texture2D _infraredPlaybackTex;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private List<ushort[]> _infraredRecorderFrames;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private List<ushort[]> _depthRecorderFrames;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private List<RenderTexture> _colorRecorderFrames;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private CompressedDepthStream _compressed;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int _CurFrame;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private RenderTexture _colorTex;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private RenderTexture _colorTex2;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private ulong _lastDepthFrameTime;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static MethodInfo _setNativeDataMethod;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static object[] _setNativeDataArgs;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private bool _dataAvailableForPlay;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private int _depthW;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private int _depthH;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private int _depthWDS;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private int _depthHDS;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private int _depthXOffsetDS;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private int _depthYOffsetDS;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool _prevRecord;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Vector2[] s_depthCalibration;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Vector2[] _depthCalibrationDS;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private ComputeBuffer _depthCalibrationBuf;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Mesh _cloudMesh;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private int _cloudMeshHash;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private List<uint> _compressedStream;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private ushort[] _prevDepthData;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private ushort[] _depthDataDS;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private ushort[] _infraDataDS;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private float _frameFraction;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		private int _lastFrameValid;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private int _frameCounter;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		private float _curSize;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private float _curIntensity;

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xDDE2F4", Offset = "0xDDE2F4", VA = "0xDDE2F4")]
		private static Shader GetShader(bool transparent)
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xDDE45C", Offset = "0xDDE45C", VA = "0xDDE45C", Slot = "5")]
		public override CustomReflection GenerateCustomReflection()
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xDDF4A0", Offset = "0xDDF4A0", VA = "0xDDF4A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xDDF4B4", Offset = "0xDDF4B4", VA = "0xDDF4B4")]
		private string GetPath()
		{
			return null;
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xDDF52C", Offset = "0xDDF52C", VA = "0xDDF52C")]
		public void SetCompressed(CompressedDepthStream data)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xDDF5BC", Offset = "0xDDF5BC", VA = "0xDDF5BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xDDF5C0", Offset = "0xDDF5C0", VA = "0xDDF5C0")]
		public static void SetComputeBufferData(ComputeBuffer computeBuffer, Array data, int elemCount, int elemSize, int destOffset = 0)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xDDF694", Offset = "0xDDF694", VA = "0xDDF694")]
		public static void SetComputeBufferDataI(ComputeBuffer computeBuffer, IntPtr dataPointer, int elemCount, int elemSize, int destOffset)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xDDF9A4", Offset = "0xDDF9A4", VA = "0xDDF9A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xDDFAF4", Offset = "0xDDFAF4", VA = "0xDDFAF4")]
		private string GetSingleFilename()
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xDDFB50", Offset = "0xDDFB50", VA = "0xDDFB50")]
		private string GetSequenceFilename(int i, bool color = false)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xDDFD3C", Offset = "0xDDFD3C", VA = "0xDDFD3C")]
		private void LoadRaw()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xDE0410", Offset = "0xDE0410", VA = "0xDE0410")]
		private void SaveRaw()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xDE0808", Offset = "0xDE0808", VA = "0xDE0808")]
		private void LoadAsSingleFile()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xDE0A38", Offset = "0xDE0A38", VA = "0xDE0A38")]
		private void SaveAsSingleFile()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xDE0E3C", Offset = "0xDE0E3C", VA = "0xDE0E3C")]
		private void ProcessAndCompressAllNow()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xDE1C60", Offset = "0xDE1C60", VA = "0xDE1C60")]
		private void Update()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xDE3E00", Offset = "0xDE3E00", VA = "0xDE3E00")]
		public static RenderTexture CreateRenderTexture(RenderTexture currentTex, int width, int height, RenderTextureFormat texFormat = RenderTextureFormat.Default)
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xDE3F08", Offset = "0xDE3F08", VA = "0xDE3F08")]
		public static ComputeBuffer CreateComputeBuffer(ComputeBuffer currentBuf, int bufLen, int bufStride)
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xDE3F9C", Offset = "0xDE3F9C", VA = "0xDE3F9C")]
		private static void CopyBuffer(ushort[] src, ushort[] dst)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xDE0224", Offset = "0xDE0224", VA = "0xDE0224")]
		private void ForceSize(List<RenderTexture> textures, int length, int w, int h)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xDE0124", Offset = "0xDE0124", VA = "0xDE0124")]
		private void ForceSize(List<ushort[]> textures, int length, int pixelCount)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xDE4074", Offset = "0xDE4074", VA = "0xDE4074")]
		private int GetTargetYMin()
		{
			return default(int);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xDE4090", Offset = "0xDE4090", VA = "0xDE4090")]
		private int GetTargetYMax()
		{
			return default(int);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xDE40B4", Offset = "0xDE40B4", VA = "0xDE40B4")]
		private int GetTargetXMin()
		{
			return default(int);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xDE40D0", Offset = "0xDE40D0", VA = "0xDE40D0")]
		private int GetTargetXMax()
		{
			return default(int);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xDE40F4", Offset = "0xDE40F4", VA = "0xDE40F4")]
		private bool UsingPreProcessed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xDE411C", Offset = "0xDE411C", VA = "0xDE411C")]
		private bool UsingProcessed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xDE1D00", Offset = "0xDE1D00", VA = "0xDE1D00")]
		private void ValidateBuffersAndFormats()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xDE414C", Offset = "0xDE414C", VA = "0xDE414C")]
		private void GeneratePreview(ushort[] infra, ushort[] depth, RenderTexture dest)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xDE4488", Offset = "0xDE4488", VA = "0xDE4488")]
		private ushort[] GetRawInfraredMap(int sensorIndex)
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xDE4490", Offset = "0xDE4490", VA = "0xDE4490")]
		private int ClipLength()
		{
			return default(int);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xDE44D0", Offset = "0xDE44D0", VA = "0xDE44D0")]
		private void AdvanceFrame()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xDE45E0", Offset = "0xDE45E0", VA = "0xDE45E0")]
		private static float abs(float x)
		{
			return default(float);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xDE45F0", Offset = "0xDE45F0", VA = "0xDE45F0")]
		private static float max(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xDE45FC", Offset = "0xDE45FC", VA = "0xDE45FC")]
		private static float clamp01(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xDE4618", Offset = "0xDE4618", VA = "0xDE4618")]
		private static float linstep(float a, float b, float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xDE46B0", Offset = "0xDE46B0", VA = "0xDE46B0")]
		private void ProcessDebugNearFar(ushort[] dest)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xDE11B4", Offset = "0xDE11B4", VA = "0xDE11B4")]
		private void ProcessAndCompress(ushort[] depthÌnput, ushort[] infraInput, bool generateCompressedFrame, bool testCompressedFrame)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xDE4798", Offset = "0xDE4798", VA = "0xDE4798")]
		public void SetIntensity(float intensity)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xDE47A0", Offset = "0xDE47A0", VA = "0xDE47A0")]
		public void SetFrame(float frame)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xDE48B4", Offset = "0xDE48B4", VA = "0xDE48B4")]
		private void EnableRenderers(bool enable)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xDE24F8", Offset = "0xDE24F8", VA = "0xDE24F8")]
		private void HandleRecordAndPlay()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xDE5DEC", Offset = "0xDE5DEC", VA = "0xDE5DEC")]
		public DepthStream()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xDE6144", Offset = "0xDE6144", VA = "0xDE6144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B0E4", Offset = "0x77B0E4")]
		private void <GenerateCustomReflection>b__72_0(bool val)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xDE6150", Offset = "0xDE6150", VA = "0xDE6150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B0F4", Offset = "0x77B0F4")]
		private bool <GenerateCustomReflection>b__72_1()
		{
			return default(bool);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xDE6158", Offset = "0xDE6158", VA = "0xDE6158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B104", Offset = "0x77B104")]
		private void <GenerateCustomReflection>b__72_2(bool val)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xDE6164", Offset = "0xDE6164", VA = "0xDE6164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B114", Offset = "0x77B114")]
		private bool <GenerateCustomReflection>b__72_3()
		{
			return default(bool);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xDE616C", Offset = "0xDE616C", VA = "0xDE616C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B124", Offset = "0x77B124")]
		private void <GenerateCustomReflection>b__72_4(float val)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xDE6174", Offset = "0xDE6174", VA = "0xDE6174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B134", Offset = "0x77B134")]
		private float <GenerateCustomReflection>b__72_5()
		{
			return default(float);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xDE617C", Offset = "0xDE617C", VA = "0xDE617C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B144", Offset = "0x77B144")]
		private void <GenerateCustomReflection>b__72_6(float val)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xDE6184", Offset = "0xDE6184", VA = "0xDE6184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B154", Offset = "0x77B154")]
		private float <GenerateCustomReflection>b__72_7()
		{
			return default(float);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xDE618C", Offset = "0xDE618C", VA = "0xDE618C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B164", Offset = "0x77B164")]
		private void <GenerateCustomReflection>b__72_8(float val)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xDE6194", Offset = "0xDE6194", VA = "0xDE6194")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B174", Offset = "0x77B174")]
		private float <GenerateCustomReflection>b__72_9()
		{
			return default(float);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xDE619C", Offset = "0xDE619C", VA = "0xDE619C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B184", Offset = "0x77B184")]
		private void <GenerateCustomReflection>b__72_10(float val)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xDE61A4", Offset = "0xDE61A4", VA = "0xDE61A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B194", Offset = "0x77B194")]
		private float <GenerateCustomReflection>b__72_11()
		{
			return default(float);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xDE61AC", Offset = "0xDE61AC", VA = "0xDE61AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B1A4", Offset = "0x77B1A4")]
		private void <GenerateCustomReflection>b__72_12(float val)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xDE61B4", Offset = "0xDE61B4", VA = "0xDE61B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B1B4", Offset = "0x77B1B4")]
		private float <GenerateCustomReflection>b__72_13()
		{
			return default(float);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xDE61BC", Offset = "0xDE61BC", VA = "0xDE61BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B1C4", Offset = "0x77B1C4")]
		private void <GenerateCustomReflection>b__72_14(int val)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xDE61C4", Offset = "0xDE61C4", VA = "0xDE61C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B1D4", Offset = "0x77B1D4")]
		private int <GenerateCustomReflection>b__72_15()
		{
			return default(int);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xDE61CC", Offset = "0xDE61CC", VA = "0xDE61CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B1E4", Offset = "0x77B1E4")]
		private void <GenerateCustomReflection>b__72_16(float val)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xDE61D4", Offset = "0xDE61D4", VA = "0xDE61D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B1F4", Offset = "0x77B1F4")]
		private float <GenerateCustomReflection>b__72_17()
		{
			return default(float);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xDE61DC", Offset = "0xDE61DC", VA = "0xDE61DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B204", Offset = "0x77B204")]
		private void <GenerateCustomReflection>b__72_18(int val)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xDE61E4", Offset = "0xDE61E4", VA = "0xDE61E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B214", Offset = "0x77B214")]
		private int <GenerateCustomReflection>b__72_19()
		{
			return default(int);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xDE61EC", Offset = "0xDE61EC", VA = "0xDE61EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B224", Offset = "0x77B224")]
		private void <GenerateCustomReflection>b__72_20(int val)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xDE61F4", Offset = "0xDE61F4", VA = "0xDE61F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B234", Offset = "0x77B234")]
		private int <GenerateCustomReflection>b__72_21()
		{
			return default(int);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xDE61FC", Offset = "0xDE61FC", VA = "0xDE61FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B244", Offset = "0x77B244")]
		private void <GenerateCustomReflection>b__72_22(Vector2 val)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xDE6204", Offset = "0xDE6204", VA = "0xDE6204")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B254", Offset = "0x77B254")]
		private Vector2 <GenerateCustomReflection>b__72_23()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xDE620C", Offset = "0xDE620C", VA = "0xDE620C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B264", Offset = "0x77B264")]
		private void <GenerateCustomReflection>b__72_24(float val)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xDE6214", Offset = "0xDE6214", VA = "0xDE6214")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B274", Offset = "0x77B274")]
		private float <GenerateCustomReflection>b__72_25()
		{
			return default(float);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xDE621C", Offset = "0xDE621C", VA = "0xDE621C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B284", Offset = "0x77B284")]
		private void <GenerateCustomReflection>b__72_26(bool val)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xDE6228", Offset = "0xDE6228", VA = "0xDE6228")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B294", Offset = "0x77B294")]
		private bool <GenerateCustomReflection>b__72_27()
		{
			return default(bool);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xDE6230", Offset = "0xDE6230", VA = "0xDE6230")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B2A4", Offset = "0x77B2A4")]
		private void <GenerateCustomReflection>b__72_28(bool val)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xDE623C", Offset = "0xDE623C", VA = "0xDE623C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B2B4", Offset = "0x77B2B4")]
		private bool <GenerateCustomReflection>b__72_29()
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xDE6244", Offset = "0xDE6244", VA = "0xDE6244")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B2C4", Offset = "0x77B2C4")]
		private void <GenerateCustomReflection>b__72_30(int val)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xDE624C", Offset = "0xDE624C", VA = "0xDE624C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B2D4", Offset = "0x77B2D4")]
		private int <GenerateCustomReflection>b__72_31()
		{
			return default(int);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xDE6254", Offset = "0xDE6254", VA = "0xDE6254")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B2E4", Offset = "0x77B2E4")]
		private void <GenerateCustomReflection>b__72_32(int val)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xDE625C", Offset = "0xDE625C", VA = "0xDE625C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B2F4", Offset = "0x77B2F4")]
		private int <GenerateCustomReflection>b__72_33()
		{
			return default(int);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xDE6264", Offset = "0xDE6264", VA = "0xDE6264")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B304", Offset = "0x77B304")]
		private void <GenerateCustomReflection>b__72_34(float val)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xDE626C", Offset = "0xDE626C", VA = "0xDE626C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B314", Offset = "0x77B314")]
		private float <GenerateCustomReflection>b__72_35()
		{
			return default(float);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xDE6274", Offset = "0xDE6274", VA = "0xDE6274")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B324", Offset = "0x77B324")]
		private void <GenerateCustomReflection>b__72_36(float val)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xDE627C", Offset = "0xDE627C", VA = "0xDE627C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B334", Offset = "0x77B334")]
		private float <GenerateCustomReflection>b__72_37()
		{
			return default(float);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xDE6284", Offset = "0xDE6284", VA = "0xDE6284")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B344", Offset = "0x77B344")]
		private void <GenerateCustomReflection>b__72_38(float val)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xDE628C", Offset = "0xDE628C", VA = "0xDE628C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B354", Offset = "0x77B354")]
		private float <GenerateCustomReflection>b__72_39()
		{
			return default(float);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xDE6294", Offset = "0xDE6294", VA = "0xDE6294")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B364", Offset = "0x77B364")]
		private void <GenerateCustomReflection>b__72_40(float val)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xDE629C", Offset = "0xDE629C", VA = "0xDE629C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B374", Offset = "0x77B374")]
		private float <GenerateCustomReflection>b__72_41()
		{
			return default(float);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xDE62A4", Offset = "0xDE62A4", VA = "0xDE62A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B384", Offset = "0x77B384")]
		private void <GenerateCustomReflection>b__72_42(Vector3 val)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xDE62B0", Offset = "0xDE62B0", VA = "0xDE62B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B394", Offset = "0x77B394")]
		private Vector3 <GenerateCustomReflection>b__72_43()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xDE62BC", Offset = "0xDE62BC", VA = "0xDE62BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B3A4", Offset = "0x77B3A4")]
		private void <GenerateCustomReflection>b__72_44(Vector3 val)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xDE62C8", Offset = "0xDE62C8", VA = "0xDE62C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B3B4", Offset = "0x77B3B4")]
		private Vector3 <GenerateCustomReflection>b__72_45()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xDE62D4", Offset = "0xDE62D4", VA = "0xDE62D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B3C4", Offset = "0x77B3C4")]
		private void <GenerateCustomReflection>b__72_46(Vector3 val)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xDE62E0", Offset = "0xDE62E0", VA = "0xDE62E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B3D4", Offset = "0x77B3D4")]
		private Vector3 <GenerateCustomReflection>b__72_47()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xDE62EC", Offset = "0xDE62EC", VA = "0xDE62EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B3E4", Offset = "0x77B3E4")]
		private void <GenerateCustomReflection>b__72_48(Vector3 val)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xDE62F8", Offset = "0xDE62F8", VA = "0xDE62F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B3F4", Offset = "0x77B3F4")]
		private Vector3 <GenerateCustomReflection>b__72_49()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xDE6304", Offset = "0xDE6304", VA = "0xDE6304")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B404", Offset = "0x77B404")]
		private void <GenerateCustomReflection>b__72_50(float val)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xDE630C", Offset = "0xDE630C", VA = "0xDE630C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B414", Offset = "0x77B414")]
		private float <GenerateCustomReflection>b__72_51()
		{
			return default(float);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xDE6314", Offset = "0xDE6314", VA = "0xDE6314")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B424", Offset = "0x77B424")]
		private void <GenerateCustomReflection>b__72_52(float val)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xDE631C", Offset = "0xDE631C", VA = "0xDE631C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B434", Offset = "0x77B434")]
		private float <GenerateCustomReflection>b__72_53()
		{
			return default(float);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xDE6324", Offset = "0xDE6324", VA = "0xDE6324")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B444", Offset = "0x77B444")]
		private void <GenerateCustomReflection>b__72_54(float val)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xDE632C", Offset = "0xDE632C", VA = "0xDE632C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B454", Offset = "0x77B454")]
		private float <GenerateCustomReflection>b__72_55()
		{
			return default(float);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xDE6334", Offset = "0xDE6334", VA = "0xDE6334")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B464", Offset = "0x77B464")]
		private void <GenerateCustomReflection>b__72_56(float val)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xDE633C", Offset = "0xDE633C", VA = "0xDE633C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B474", Offset = "0x77B474")]
		private float <GenerateCustomReflection>b__72_57()
		{
			return default(float);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xDE6344", Offset = "0xDE6344", VA = "0xDE6344")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B484", Offset = "0x77B484")]
		private void <GenerateCustomReflection>b__72_58(float val)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xDE634C", Offset = "0xDE634C", VA = "0xDE634C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B494", Offset = "0x77B494")]
		private float <GenerateCustomReflection>b__72_59()
		{
			return default(float);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xDE6354", Offset = "0xDE6354", VA = "0xDE6354")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B4A4", Offset = "0x77B4A4")]
		private void <GenerateCustomReflection>b__72_60(float val)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xDE635C", Offset = "0xDE635C", VA = "0xDE635C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B4B4", Offset = "0x77B4B4")]
		private float <GenerateCustomReflection>b__72_61()
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000D3")]
	public static class DiffRLE
	{
		[Token(Token = "0x20001D3")]
		private class EncoderStream
		{
			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private uint cur;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int curShift;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<uint> outEncoded;

			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int[] collectTypeStats;

			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int[] collectLenStats;

			[Token(Token = "0x6000A75")]
			[Address(RVA = "0xDE6F28", Offset = "0xDE6F28", VA = "0xDE6F28")]
			public void Flush()
			{
			}

			[Token(Token = "0x6000A76")]
			[Address(RVA = "0xDE81B8", Offset = "0xDE81B8", VA = "0xDE81B8")]
			private void ForceFlush()
			{
			}

			[Token(Token = "0x6000A77")]
			[Address(RVA = "0xDE821C", Offset = "0xDE821C", VA = "0xDE821C")]
			private void AllocBits(uint bits)
			{
			}

			[Token(Token = "0x6000A78")]
			[Address(RVA = "0xDE8234", Offset = "0xDE8234", VA = "0xDE8234")]
			private bool HasBits(uint bits)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A79")]
			[Address(RVA = "0xDE6D84", Offset = "0xDE6D84", VA = "0xDE6D84")]
			public void Write4(uint value)
			{
			}

			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0xDE6E38", Offset = "0xDE6E38", VA = "0xDE6E38")]
			public void Write8(uint value)
			{
			}

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0xDE8248", Offset = "0xDE8248", VA = "0xDE8248")]
			public void Write12(uint value)
			{
			}

			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0xDE6CA4", Offset = "0xDE6CA4", VA = "0xDE6CA4")]
			public void Write16(uint value)
			{
			}

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0xDE6F18", Offset = "0xDE6F18", VA = "0xDE6F18")]
			public void WriteEOS()
			{
			}

			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0xDE6B14", Offset = "0xDE6B14", VA = "0xDE6B14")]
			public void WriteOPAndLength(uint setTypeOp, uint len, bool protect = true)
			{
			}

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0xDE6AE8", Offset = "0xDE6AE8", VA = "0xDE6AE8")]
			public EncoderStream(List<uint> _outEncoded)
			{
			}
		}

		[Token(Token = "0x4000535")]
		private const uint OP__SET_TYPE_REP = 0u;

		[Token(Token = "0x4000536")]
		private const uint OP__SET_TYPE_DIFF_INT4 = 1u;

		[Token(Token = "0x4000537")]
		private const uint OP__SET_TYPE_DIFF_INT8 = 2u;

		[Token(Token = "0x4000538")]
		private const uint OP__SET_TYPE_UINT16 = 3u;

		[Token(Token = "0x4000539")]
		private const uint OP__LENGTH1 = 0u;

		[Token(Token = "0x400053A")]
		private const uint OP__LENGTH2 = 4u;

		[Token(Token = "0x400053B")]
		private const uint OP__LENGTH_UINT4 = 8u;

		[Token(Token = "0x400053C")]
		private const uint OP__LENGTH_UINT12 = 12u;

		[Token(Token = "0x400053D")]
		private const int opBits = 4;

		[Token(Token = "0x400053E")]
		private const uint opMask = 15u;

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xDE6364", Offset = "0xDE6364", VA = "0xDE6364")]
		private static string debugOpType(uint i)
		{
			return null;
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xDE6400", Offset = "0xDE6400", VA = "0xDE6400")]
		private static string debugLenType(uint i)
		{
			return null;
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xDE6498", Offset = "0xDE6498", VA = "0xDE6498")]
		private static string debugUint(uint cur)
		{
			return null;
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xDE66C4", Offset = "0xDE66C4", VA = "0xDE66C4")]
		private static string debugUintdataShift(uint cur)
		{
			return null;
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xDE6AA8", Offset = "0xDE6AA8", VA = "0xDE6AA8")]
		private static int errorMetric(int x)
		{
			return default(int);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xDE6AB4", Offset = "0xDE6AB4", VA = "0xDE6AB4")]
		private static int abs(int x)
		{
			return default(int);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xDE6AC0", Offset = "0xDE6AC0", VA = "0xDE6AC0")]
		private static int min(int a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xDE6ACC", Offset = "0xDE6ACC", VA = "0xDE6ACC")]
		private static int clamp(int x, int mi, int ma)
		{
			return default(int);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xDDBC6C", Offset = "0xDDBC6C", VA = "0xDDBC6C")]
		public static void Encode(ushort[] prevBuf, ushort[] buf, List<uint> outEncoded, float errorTolerance = 0f, bool printStats = false)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xDE4720", Offset = "0xDE4720", VA = "0xDE4720")]
		public static void Decode(ushort[] buf, List<uint> encoded)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xDE6F38", Offset = "0xDE6F38", VA = "0xDE6F38")]
		public static void advanceBits(int n, ref int dataShift, ref uint data, ref uint dataNext, ref int i, uint[] encodedData, int endOffset)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xDDC788", Offset = "0xDDC788", VA = "0xDDC788")]
		public static void Decode(ushort[] _buf, uint[] _encodedData, int startOffset = 0, int endOffset = -1)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xDE6FE8", Offset = "0xDE6FE8", VA = "0xDE6FE8")]
		private static void Check(ushort[] a, ushort[] b, ushort[] org_a, string test, List<uint> encoded)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xDE746C", Offset = "0xDE746C", VA = "0xDE746C")]
		private static void RunTest(string name, ushort[] a, ushort[] b)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xDE774C", Offset = "0xDE774C", VA = "0xDE774C")]
		public static void RunTests()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public static class DiffRLEV1
	{
		[Token(Token = "0x20001D4")]
		private class EncoderStream
		{
			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private uint cur;

			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int curShift;

			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<uint> outEncoded;

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0xDE86B4", Offset = "0xDE86B4", VA = "0xDE86B4")]
			public void Flush()
			{
			}

			[Token(Token = "0x6000A81")]
			[Address(RVA = "0xDE997C", Offset = "0xDE997C", VA = "0xDE997C")]
			private void ForceFlush()
			{
			}

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0xDE99E0", Offset = "0xDE99E0", VA = "0xDE99E0")]
			private void AllocBits(uint bits)
			{
			}

			[Token(Token = "0x6000A83")]
			[Address(RVA = "0xDE99F8", Offset = "0xDE99F8", VA = "0xDE99F8")]
			private bool HasBits(uint bits)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A84")]
			[Address(RVA = "0xDE9A0C", Offset = "0xDE9A0C", VA = "0xDE9A0C")]
			private void Write4(uint value)
			{
			}

			[Token(Token = "0x6000A85")]
			[Address(RVA = "0xDE9A68", Offset = "0xDE9A68", VA = "0xDE9A68")]
			private void Write8(uint value)
			{
			}

			[Token(Token = "0x6000A86")]
			[Address(RVA = "0xDE9AEC", Offset = "0xDE9AEC", VA = "0xDE9AEC")]
			private void Write16(uint value)
			{
			}

			[Token(Token = "0x6000A87")]
			[Address(RVA = "0xDE8668", Offset = "0xDE8668", VA = "0xDE8668")]
			public void WriteOP(uint op)
			{
			}

			[Token(Token = "0x6000A88")]
			[Address(RVA = "0xDE85D4", Offset = "0xDE85D4", VA = "0xDE85D4")]
			public void Write(int value)
			{
			}

			[Token(Token = "0x6000A89")]
			[Address(RVA = "0xDE9B64", Offset = "0xDE9B64", VA = "0xDE9B64")]
			public void Write(uint value)
			{
			}

			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0xDE85A8", Offset = "0xDE85A8", VA = "0xDE85A8")]
			public EncoderStream(List<uint> _outEncoded)
			{
			}
		}

		[Token(Token = "0x400053F")]
		private const uint OP__READ_UINT16 = 0u;

		[Token(Token = "0x4000540")]
		private const uint OP__READ_UINT8 = 1u;

		[Token(Token = "0x4000541")]
		private const uint OP__READ_UINT4 = 2u;

		[Token(Token = "0x4000542")]
		private const uint OP__ADD_AND_WRITE = 3u;

		[Token(Token = "0x4000543")]
		private const uint OP__SUB_AND_WRITE = 4u;

		[Token(Token = "0x4000544")]
		private const uint OP__PREV_ADD_AND_WRITE = 5u;

		[Token(Token = "0x4000545")]
		private const uint OP__PREV_SUB_AND_WRITE = 6u;

		[Token(Token = "0x4000546")]
		private const uint OP__ADVANCE_POS = 7u;

		[Token(Token = "0x4000547")]
		private const int opBits = 3;

		[Token(Token = "0x4000548")]
		private const uint opMask = 7u;

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xDE8354", Offset = "0xDE8354", VA = "0xDE8354")]
		private static string debugOp(uint i)
		{
			return null;
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xDE83C4", Offset = "0xDE83C4", VA = "0xDE83C4")]
		public static int abs(int x)
		{
			return default(int);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xDE83D0", Offset = "0xDE83D0", VA = "0xDE83D0")]
		public static void Encode(ushort[] prevBuf, ushort[] buf, List<uint> outEncoded)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xDE86C4", Offset = "0xDE86C4", VA = "0xDE86C4")]
		public static void Decode(ushort[] buf, List<uint> encoded)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xDE873C", Offset = "0xDE873C", VA = "0xDE873C")]
		public static void Decode(ushort[] _buf, uint[] _encodedData, int startOffset, int endOffset)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xDE88B8", Offset = "0xDE88B8", VA = "0xDE88B8")]
		private static void Check(ushort[] a, ushort[] b, ushort[] org_a, string test, List<uint> encoded)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xDE8D3C", Offset = "0xDE8D3C", VA = "0xDE8D3C")]
		private static void RunTest(string name, ushort[] a, ushort[] b)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xDE9018", Offset = "0xDE9018", VA = "0xDE9018")]
		public static void RunTests()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class ASTNode
	{
		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string token;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ASTNode left;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ASTNode right;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string leftBracket;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string rightBracket;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<ASTNode> items;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string wsEmptyBracket;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string ws1;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string ws2;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int dataId;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string stringData;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public double numberData;

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xD47DDC", Offset = "0xD47DDC", VA = "0xD47DDC")]
		public ASTNode()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class ASTParser
	{
		[Token(Token = "0x20001D5")]
		public class Configuration
		{
			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<string> joinTokens;

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> brackets;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dictionary<string, int> unaryOperators;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Dictionary<string, int> binaryOperators;

			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<object> outData;

			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0xDDA8F0", Offset = "0xDDA8F0", VA = "0xDDA8F0")]
			public Configuration()
			{
			}
		}

		[Token(Token = "0x20001D6")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x778E3C", Offset = "0x778E3C")]
		public class Dict<TKey, TValue> : Dictionary<TKey, TValue> where TValue : class
		{
			[Token(Token = "0x17000063")]
			public new TValue Item
			{
				[Token(Token = "0x6000A8C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A8D")]
				set
				{
				}
			}

			[Token(Token = "0x6000A8E")]
			public Dict()
			{
			}
		}

		[Token(Token = "0x20001D7")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x778E74", Offset = "0x778E74")]
		public class Array<T> : List<T> where T : class
		{
			[Token(Token = "0x17000064")]
			public new T Item
			{
				[Token(Token = "0x6000A8F")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A90")]
				set
				{
				}
			}

			[Token(Token = "0x6000A91")]
			public Array()
			{
			}
		}

		[Token(Token = "0x20001D8")]
		private class stringIterator
		{
			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string str;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int pos;

			[Token(Token = "0x40009D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int length;

			[Token(Token = "0x6000A92")]
			[Address(RVA = "0xDDB8F4", Offset = "0xDDB8F4", VA = "0xDDB8F4")]
			public stringIterator(string _str, int _pos, int _length)
			{
			}

			[Token(Token = "0x6000A93")]
			[Address(RVA = "0xDDB934", Offset = "0xDDB934", VA = "0xDDB934")]
			public bool eos()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001D9")]
		public class TokenIterator
		{
			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string ws;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int pos;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int wsp;

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int curLine;

			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool parsedNewLine;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Array<string> arrayOfTokens;

			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<KeyValuePair<int, int>> metaComments;

			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<string> commentBackend;

			[Token(Token = "0x6000A94")]
			[Address(RVA = "0xDDAF0C", Offset = "0xDDAF0C", VA = "0xDDAF0C")]
			public TokenIterator(Array<string> ar)
			{
			}

			[Token(Token = "0x6000A95")]
			[Address(RVA = "0xDDB010", Offset = "0xDDB010", VA = "0xDDB010")]
			public bool eos()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A96")]
			[Address(RVA = "0xDDB06C", Offset = "0xDDB06C", VA = "0xDDB06C")]
			public void resetPos()
			{
			}

			[Token(Token = "0x6000A97")]
			[Address(RVA = "0xDDB078", Offset = "0xDDB078", VA = "0xDDB078")]
			private void parse()
			{
			}

			[Token(Token = "0x6000A98")]
			[Address(RVA = "0xDDB4A0", Offset = "0xDDB4A0", VA = "0xDDB4A0")]
			public string getStringForError()
			{
				return null;
			}

			[Token(Token = "0x6000A99")]
			[Address(RVA = "0xDDB57C", Offset = "0xDDB57C", VA = "0xDDB57C")]
			public bool peekLineFeed()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0xDDB5A0", Offset = "0xDDB5A0", VA = "0xDDB5A0")]
			public string peek()
			{
				return null;
			}

			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0xDDB604", Offset = "0xDDB604", VA = "0xDDB604")]
			public string rawPeek(int offset)
			{
				return null;
			}

			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0xDDB670", Offset = "0xDDB670", VA = "0xDDB670")]
			public string proceed(bool onlyWS = false)
			{
				return null;
			}

			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0xDDB6B4", Offset = "0xDDB6B4", VA = "0xDDB6B4")]
			public string simpleGet()
			{
				return null;
			}

			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0xDDB750", Offset = "0xDDB750", VA = "0xDDB750")]
			public string parseQuotedString()
			{
				return null;
			}

			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0xDDB858", Offset = "0xDDB858", VA = "0xDDB858")]
			public int getTokenPos()
			{
				return default(int);
			}

			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0xDDB860", Offset = "0xDDB860", VA = "0xDDB860")]
			public void setTokenPos(int p)
			{
			}

			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0xDDB86C", Offset = "0xDDB86C", VA = "0xDDB86C")]
			public int getLine()
			{
				return default(int);
			}

			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0xDDB874", Offset = "0xDDB874", VA = "0xDDB874")]
			public List<KeyValuePair<int, int>> getCommentsRanges()
			{
				return null;
			}

			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0xDDB87C", Offset = "0xDDB87C", VA = "0xDDB87C")]
			public string getTokenRange(int p1, int p2)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20001DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778EAC", Offset = "0x778EAC")]
		private sealed class <>c
		{
			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<string> <>9__30_0;

			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<ASTNode, string> <>9__40_0;

			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0xDDA764", Offset = "0xDDA764", VA = "0xDDA764")]
			public <>c()
			{
			}

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0xDDA76C", Offset = "0xDDA76C", VA = "0xDDA76C")]
			internal void <initJoinTok>b__30_0(string v)
			{
			}

			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0xDDA8C4", Offset = "0xDDA8C4", VA = "0xDDA8C4")]
			internal string <UnparseExpression>b__40_0(ASTNode node)
			{
				return null;
			}
		}

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<string> _currentJoinTok;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dict<string, Dict<string, string>> _expandedJoinTok;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Configuration config;

		[Token(Token = "0x60005B0")]
		private static void forV<T>(IList<T> c, Action<T> f)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xD47DEC", Offset = "0xD47DEC", VA = "0xD47DEC")]
		private static string r_concat(string s1, string s2)
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xD47DF4", Offset = "0xD47DF4", VA = "0xD47DF4")]
		private static string r_concat(string s1, char s2)
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xD47E30", Offset = "0xD47E30", VA = "0xD47E30")]
		private static char r_charCodeAt(string s, int i)
		{
			return default(char);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xD48094", Offset = "0xD48094", VA = "0xD48094")]
		private static string r_substring(string s, int i1, int i2)
		{
			return null;
		}

		[Token(Token = "0x60005B5")]
		private static void r_setLast<T>(List<T> r, T item)
		{
		}

		[Token(Token = "0x60005B6")]
		private static void r_push<T>(List<T> r, T item)
		{
		}

		[Token(Token = "0x60005B7")]
		private static int r_len<T>(List<T> l)
		{
			return default(int);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xD482FC", Offset = "0xD482FC", VA = "0xD482FC")]
		private static int r_len(string s)
		{
			return default(int);
		}

		[Token(Token = "0x60005B9")]
		private static List<T> r_subarray<T>(List<T> l, int id, int len)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		private static string r_arrayConcatToString<T>(List<T> l)
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xD48314", Offset = "0xD48314", VA = "0xD48314")]
		private static int r_max(int a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xD4802C", Offset = "0xD4802C", VA = "0xD4802C")]
		private static void r_throw(string txt)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xD48320", Offset = "0xD48320", VA = "0xD48320")]
		private static double r_toNumber(string str)
		{
			return default(double);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xD483BC", Offset = "0xD483BC", VA = "0xD483BC")]
		private static string r_parseWhile(stringIterator p, Func<char, bool> f)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xD48480", Offset = "0xD48480", VA = "0xD48480")]
		private static bool r_isWhite(char t)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xD484B0", Offset = "0xD484B0", VA = "0xD484B0")]
		private static bool r_isDigit(char t)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xD484C4", Offset = "0xD484C4", VA = "0xD484C4")]
		private static bool r_isAlpha(char t)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xD48500", Offset = "0xD48500", VA = "0xD48500")]
		private static bool isSymbol(char t)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xD4854C", Offset = "0xD4854C", VA = "0xD4854C")]
		private static string parseWhileDigit(stringIterator p)
		{
			return null;
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xD485C8", Offset = "0xD485C8", VA = "0xD485C8")]
		private static string parseWhileSymbol(stringIterator p)
		{
			return null;
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xD48644", Offset = "0xD48644", VA = "0xD48644")]
		private static string parseSingleChar(stringIterator p)
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xD48698", Offset = "0xD48698", VA = "0xD48698")]
		private static string parseNumber(stringIterator p)
		{
			return null;
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xD4889C", Offset = "0xD4889C", VA = "0xD4889C")]
		private static Array<string> parseToTokensI(stringIterator p, Dict<string, Dict<string, string>> joinTok)
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xD48A4C", Offset = "0xD48A4C", VA = "0xD48A4C")]
		private void initJoinTok(List<string> joinTok)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xD48BA8", Offset = "0xD48BA8", VA = "0xD48BA8")]
		private Array<string> parseToTokens(string s, List<string> jt)
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xD48C48", Offset = "0xD48C48", VA = "0xD48C48")]
		private static bool isEndBracket(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xD48CE4", Offset = "0xD48CE4", VA = "0xD48CE4")]
		private static string bracketEnd(string s)
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xD48DA4", Offset = "0xD48DA4", VA = "0xD48DA4")]
		private static ASTNode tryToParseAssignment(TokenIterator it)
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xD48FB0", Offset = "0xD48FB0", VA = "0xD48FB0")]
		private static ASTNode parseExpressionR(TokenIterator it, int prec, Configuration parseContext, string debuginfo, bool isFunctorArg = false)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xD49B64", Offset = "0xD49B64", VA = "0xD49B64")]
		public ASTNode ParseExpression(string txt)
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xD49C00", Offset = "0xD49C00", VA = "0xD49C00")]
		private static void unparseRec(ASTNode t, List<string> outa, Func<ASTNode, string> unparseData)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xD49E48", Offset = "0xD49E48", VA = "0xD49E48")]
		public string UnparseExpression(ASTNode tree, [Optional] Func<ASTNode, string> unparseData)
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xD49F6C", Offset = "0xD49F6C", VA = "0xD49F6C")]
		public static string DebugTree(ASTNode n)
		{
			return null;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xD4A5D4", Offset = "0xD4A5D4", VA = "0xD4A5D4")]
		private static string debugWS(ASTNode n)
		{
			return null;
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xD49FF0", Offset = "0xD49FF0", VA = "0xD49FF0")]
		private static void debugTreeR(ASTNode n, List<string> ar, int depth)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xD4A684", Offset = "0xD4A684", VA = "0xD4A684")]
		private static string SimpleEscapeInner(string s)
		{
			return null;
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xD4A710", Offset = "0xD4A710", VA = "0xD4A710")]
		public static string SimpleEscape(string s)
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xD49964", Offset = "0xD49964", VA = "0xD49964")]
		public static string SimpleUnescape(string s)
		{
			return null;
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xD4A824", Offset = "0xD4A824", VA = "0xD4A824")]
		public ASTParser()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public static class MiscExtensions
	{
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xDE9E9C", Offset = "0xDE9E9C", VA = "0xDE9E9C")]
		public static string DebugTree(this ASTNode n)
		{
			return null;
		}

		[Token(Token = "0x60005D9")]
		public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
		{
			return (TValue)null;
		}

		[Token(Token = "0x60005DA")]
		public static TValue GetValueOrAddNew<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key) where TValue : class, new()
		{
			return null;
		}
	}
	[Token(Token = "0x20000D8")]
	public class RefCount
	{
		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int refCount;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onLastDisposed;

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xDEAFF8", Offset = "0xDEAFF8", VA = "0xDEAFF8")]
		public RefCount()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class RefCountedHandle : IDisposable
	{
		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RefCount owner;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool disposed;

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xDEAEE0", Offset = "0xDEAEE0", VA = "0xDEAEE0")]
		public RefCountedHandle(RefCount _owner)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xDEF8E4", Offset = "0xDEF8E4", VA = "0xDEF8E4", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class RNSExpression
	{
		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ReactiveProperty<object> prop;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ASTNode root;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string expression;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ReactiveValue reactiveVal;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RefCount refCount;

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xDEAF20", Offset = "0xDEAF20", VA = "0xDEAF20")]
		public RNSExpression()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xDEB000", Offset = "0xDEB000", VA = "0xDEB000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B4F4", Offset = "0x77B4F4")]
		private void <.ctor>b__5_0()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class RNSExprHandle : RefCountedHandle
	{
		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RNSExpression Expression;

		[Token(Token = "0x17000022")]
		public ReactiveValue Value
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0xDEAE90", Offset = "0xDEAE90", VA = "0xDEAE90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xDEAEAC", Offset = "0xDEAEAC", VA = "0xDEAEAC")]
		public RNSExprHandle(RNSExpression expr)
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class DisposeList : IDisposable
	{
		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<IDisposable> _disposeOnDispose;

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xDE9CF4", Offset = "0xDE9CF4", VA = "0xDE9CF4")]
		public void DisposeOnDispose(IDisposable v)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xDE9D8C", Offset = "0xDE9D8C", VA = "0xDE9D8C", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xDE9E94", Offset = "0xDE9E94", VA = "0xDE9E94")]
		public DisposeList()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class ReactiveValue : DisposeList
	{
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string debugInfo;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object value;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private double numberValue;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ReactiveListeners listeners;

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xDED974", Offset = "0xDED974", VA = "0xDED974")]
		public ReactiveValue()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xDEF510", Offset = "0xDEF510", VA = "0xDEF510")]
		public ReactiveValue(int i)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xDEF5B0", Offset = "0xDEF5B0", VA = "0xDEF5B0")]
		public ReactiveValue(float f)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xDED134", Offset = "0xDED134", VA = "0xDED134")]
		public ReactiveValue(double f)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xDEA5A8", Offset = "0xDEA5A8", VA = "0xDEA5A8")]
		public ReactiveValue(object obj, string _debugInfo)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xDEF650", Offset = "0xDEF650", VA = "0xDEF650", Slot = "5")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xDEA14C", Offset = "0xDEA14C", VA = "0xDEA14C")]
		public IDisposableHook OnChange(Action f)
		{
			return null;
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xDEA1B8", Offset = "0xDEA1B8", VA = "0xDEA1B8")]
		public IDisposableHook Subscribe(Action f)
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xDEE2D0", Offset = "0xDEE2D0", VA = "0xDEE2D0")]
		public static string GetValueAsTextForDebug(ReactiveValue rv)
		{
			return null;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xDEA240", Offset = "0xDEA240", VA = "0xDEA240")]
		public string GetValueAsTextForDebug()
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xDEDD4C", Offset = "0xDEDD4C", VA = "0xDEDD4C")]
		public object Get()
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xDEF6B4", Offset = "0xDEF6B4", VA = "0xDEF6B4")]
		public int GetInteger()
		{
			return default(int);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xDEF6C8", Offset = "0xDEF6C8", VA = "0xDEF6C8")]
		public double GetNumber()
		{
			return default(double);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xDEF6D0", Offset = "0xDEF6D0", VA = "0xDEF6D0")]
		public float GetFloat()
		{
			return default(float);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xDEF3DC", Offset = "0xDEF3DC", VA = "0xDEF3DC")]
		public ReactiveArray GetReactiveArray()
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xDEF6DC", Offset = "0xDEF6DC", VA = "0xDEF6DC")]
		public void CopyValueFrom(ReactiveValue val)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xDEF738", Offset = "0xDEF738", VA = "0xDEF738")]
		public void Set(ReactiveArray val)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xDEF760", Offset = "0xDEF760", VA = "0xDEF760")]
		public void Set(ReactiveArray val, IDisposableHook hook)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xDEE338", Offset = "0xDEE338", VA = "0xDEE338")]
		public void Set(double val)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xDEAD9C", Offset = "0xDEAD9C", VA = "0xDEAD9C")]
		public void Set(double val, IDisposableHook hook)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xDEF648", Offset = "0xDEF648", VA = "0xDEF648")]
		public void Set(float val)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xDEF78C", Offset = "0xDEF78C", VA = "0xDEF78C")]
		public void Set(float val, IDisposableHook hook)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xDEF5A8", Offset = "0xDEF5A8", VA = "0xDEF5A8")]
		public void Set(int val)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xDEF794", Offset = "0xDEF794", VA = "0xDEF794")]
		public void Set(int val, IDisposableHook hook)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xDEE330", Offset = "0xDEE330", VA = "0xDEE330")]
		public void Set(object val)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xDEF7A0", Offset = "0xDEF7A0", VA = "0xDEF7A0")]
		public void Set(object val, IDisposableHook hook)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xDEF2F0", Offset = "0xDEF2F0", VA = "0xDEF2F0")]
		public bool isReactiveArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xDEAD1C", Offset = "0xDEAD1C", VA = "0xDEAD1C")]
		public bool isNumber()
		{
			return default(bool);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xDEF220", Offset = "0xDEF220", VA = "0xDEF220")]
		public bool isNil()
		{
			return default(bool);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xDEF8D4", Offset = "0xDEF8D4", VA = "0xDEF8D4")]
		public bool isNumberAndEqualTo(double number)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000DE")]
	public class ReactiveArray
	{
		[Token(Token = "0x20001DB")]
		private class InternalProperty
		{
			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Key;

			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ReactiveValue Value;

			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int Index;

			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0xDEBAB8", Offset = "0xDEBAB8", VA = "0xDEBAB8")]
			public InternalProperty()
			{
			}
		}

		[Token(Token = "0x20001DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778EBC", Offset = "0x778EBC")]
		private sealed class <>c__DisplayClass4_0<T>
		{
			[Token(Token = "0x40009DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string k;

			[Token(Token = "0x40009E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReactiveValue rv;

			[Token(Token = "0x40009E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T valueIfMissing;

			[Token(Token = "0x6000AA9")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000AAA")]
			internal void <HookKey>b__0(ReactiveValue val)
			{
			}
		}

		[Token(Token = "0x20001DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778ECC", Offset = "0x778ECC")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40009E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<ReactiveValue> callback;

			[Token(Token = "0x40009E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InternalProperty ival;

			[Token(Token = "0x40009E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string key;

			[Token(Token = "0x40009E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IDisposableHook[] hook;

			[Token(Token = "0x40009E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IDisposable h;

			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0xDEB668", Offset = "0xDEB668", VA = "0xDEB668")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0xDEC4A8", Offset = "0xDEC4A8", VA = "0xDEC4A8")]
			internal void <ListenToValueOf>b__0()
			{
			}

			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0xDEC50C", Offset = "0xDEC50C", VA = "0xDEC50C")]
			internal void <ListenToValueOf>b__1(string _key, ReactiveValue val)
			{
			}

			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0xDEC628", Offset = "0xDEC628", VA = "0xDEC628")]
			internal void <ListenToValueOf>b__2(string _key, ReactiveValue cal)
			{
			}

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0xDEC6E0", Offset = "0xDEC6E0", VA = "0xDEC6E0")]
			internal void <ListenToValueOf>b__3()
			{
			}
		}

		[Token(Token = "0x20001DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778EDC", Offset = "0x778EDC")]
		private sealed class <>c__DisplayClass6_1
		{
			[Token(Token = "0x40009E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReactiveValue val;

			[Token(Token = "0x40009E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass6_0 CS$<>8__locals1;

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0xDEC620", Offset = "0xDEC620", VA = "0xDEC620")]
			public <>c__DisplayClass6_1()
			{
			}

			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0xDEC760", Offset = "0xDEC760", VA = "0xDEC760")]
			internal void <ListenToValueOf>b__4()
			{
			}
		}

		[Token(Token = "0x20001DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778EEC", Offset = "0x778EEC")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40009E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<string, ReactiveValue> addFunc;

			[Token(Token = "0x40009EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<string, ReactiveValue> removeFunc;

			[Token(Token = "0x40009EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IDisposable addH;

			[Token(Token = "0x40009EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IDisposable remH;

			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0xDEBC60", Offset = "0xDEBC60", VA = "0xDEBC60")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0xDEBFF4", Offset = "0xDEBFF4", VA = "0xDEBFF4")]
			internal void <Map>b__0(DictionaryAddEvent<string, InternalProperty> evt)
			{
			}

			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0xDEC068", Offset = "0xDEC068", VA = "0xDEC068")]
			internal void <Map>b__1(DictionaryRemoveEvent<string, InternalProperty> evt)
			{
			}

			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0xDEC0DC", Offset = "0xDEC0DC", VA = "0xDEC0DC")]
			internal void <Map>b__2()
			{
			}
		}

		[Token(Token = "0x20001E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778EFC", Offset = "0x778EFC")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x40009ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<string, IDisposable> mapDestr;

			[Token(Token = "0x40009EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<string, ReactiveValue, IDisposable> replicate;

			[Token(Token = "0x40009EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IDisposable addH;

			[Token(Token = "0x40009F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IDisposable remH;

			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0xDEBF50", Offset = "0xDEBF50", VA = "0xDEBF50")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0xDEC1FC", Offset = "0xDEC1FC", VA = "0xDEC1FC")]
			internal void <Map>b__0(DictionaryAddEvent<string, InternalProperty> evt)
			{
			}

			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0xDEC294", Offset = "0xDEC294", VA = "0xDEC294")]
			internal void <Map>b__1(DictionaryRemoveEvent<string, InternalProperty> evt)
			{
			}

			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0xDEC388", Offset = "0xDEC388", VA = "0xDEC388")]
			internal void <Map>b__2()
			{
			}
		}

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ReactiveDictionary<string, InternalProperty> _dict;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<InternalProperty> _order;

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xDEB09C", Offset = "0xDEB09C", VA = "0xDEB09C")]
		public string DebugString()
		{
			return null;
		}

		[Token(Token = "0x6000604")]
		public ReactiveValue HookKey<T>(string k, T valueIfMissing)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xDEB3F0", Offset = "0xDEB3F0", VA = "0xDEB3F0")]
		public IDisposable ListenToValueOfIndex(int index, Action<ReactiveValue> callback)
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xDEB438", Offset = "0xDEB438", VA = "0xDEB438")]
		public IDisposable ListenToValueOf(string key, Action<ReactiveValue> callback)
		{
			return null;
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xDEB904", Offset = "0xDEB904", VA = "0xDEB904")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xDEB96C", Offset = "0xDEB96C", VA = "0xDEB96C")]
		public ReactiveValue Get(string key)
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xDEB9F8", Offset = "0xDEB9F8", VA = "0xDEB9F8")]
		public void Add(string k, ReactiveValue v)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xDEBAC0", Offset = "0xDEBAC0", VA = "0xDEBAC0")]
		public string Add(ReactiveValue v)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xDEBB48", Offset = "0xDEBB48", VA = "0xDEBB48")]
		public void Remove(string key)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xDEB670", Offset = "0xDEB670", VA = "0xDEB670")]
		public IDisposable Map(Action<string, ReactiveValue> addFunc, Action<string, ReactiveValue> removeFunc, bool doInit = true)
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xDEBC68", Offset = "0xDEBC68", VA = "0xDEBC68")]
		public IDisposable Map(Func<string, ReactiveValue, IDisposable> replicate, bool doInit = true)
		{
			return null;
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xDEBF58", Offset = "0xDEBF58", VA = "0xDEBF58")]
		public void Check()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xDEBF5C", Offset = "0xDEBF5C", VA = "0xDEBF5C")]
		public ReactiveArray()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	internal class Operator
	{
		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ReactiveValue a;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ReactiveValue b;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ReactiveValue r;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private double aVal;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private double bVal;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private double rVal;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IDisposableHook aHandle;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IDisposableHook bHandle;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IDisposableHook rHandle;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DelayedAction processAction;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private DelayedActionQueue queue;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Func<double, double, double> forward;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Func<double, double, double> backward;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Func<double, double, double> dif;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Func<double, double, double> applyDif;

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xDE9EFC", Offset = "0xDE9EFC", VA = "0xDE9EFC")]
		private Operator(ReactiveValue _r, ReactiveValue _a, ReactiveValue _b, string debugInfo, DelayedActionQueue _queue, Func<double, double, double> _forward, Func<double, double, double> _backward, Func<double, double, double> _dif, Func<double, double, double> _applyDif)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xDEA46C", Offset = "0xDEA46C", VA = "0xDEA46C")]
		public static ReactiveValue Create(ReactiveValue _a, ReactiveValue _b, string debugInfo, DelayedActionQueue _queue, Func<double, double, double> _forward, Func<double, double, double> _backward, Func<double, double, double> _dif, Func<double, double, double> _applyDif)
		{
			return null;
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xDEA650", Offset = "0xDEA650", VA = "0xDEA650")]
		private void Cleanup()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xDEA880", Offset = "0xDEA880", VA = "0xDEA880")]
		public void ScheduleProcess()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xDEA964", Offset = "0xDEA964", VA = "0xDEA964")]
		public void Process()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class ReactiveNamespace : IDisposable
	{
		[Token(Token = "0x20001E1")]
		public class nil
		{
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0xDEE04C", Offset = "0xDEE04C", VA = "0xDEE04C")]
			public nil()
			{
			}
		}

		[Token(Token = "0x20001E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778F0C", Offset = "0x778F0C")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string debugInfo;

			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<double, double> f;

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0xDED764", Offset = "0xDED764", VA = "0xDED764")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0xDEE054", Offset = "0xDEE054", VA = "0xDEE054")]
			internal IDisposable <WrapToReactive>b__0(ReactiveArray args, ReactiveValue rvOut)
			{
				return null;
			}
		}

		[Token(Token = "0x20001E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778F1C", Offset = "0x778F1C")]
		private sealed class <>c__DisplayClass15_1
		{
			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReactiveValue rvOut;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass15_0 CS$<>8__locals1;

			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0xDEE178", Offset = "0xDEE178", VA = "0xDEE178")]
			public <>c__DisplayClass15_1()
			{
			}

			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0xDEE180", Offset = "0xDEE180", VA = "0xDEE180")]
			internal void <WrapToReactive>b__1(ReactiveValue rv)
			{
			}
		}

		[Token(Token = "0x20001E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778F2C", Offset = "0x778F2C")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x40009F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Func<double, double, double> f;

			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0xDED76C", Offset = "0xDED76C", VA = "0xDED76C")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0xDEE418", Offset = "0xDEE418", VA = "0xDEE418")]
			internal IDisposable <WrapToReactive>b__0(ReactiveArray args, ReactiveValue rvOut)
			{
				return null;
			}
		}

		[Token(Token = "0x20001E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778F3C", Offset = "0x778F3C")]
		private sealed class <>c__DisplayClass16_1
		{
			[Token(Token = "0x40009F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReactiveValue rv0;

			[Token(Token = "0x40009F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ReactiveValue rv1;

			[Token(Token = "0x40009F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ReactiveValue rvOut;

			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action updateN2;

			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IDisposable h0;

			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public IDisposable h1;

			[Token(Token = "0x40009FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public <>c__DisplayClass16_0 CS$<>8__locals1;

			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0xDEE5C8", Offset = "0xDEE5C8", VA = "0xDEE5C8")]
			public <>c__DisplayClass16_1()
			{
			}

			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0xDEE5D0", Offset = "0xDEE5D0", VA = "0xDEE5D0")]
			internal void <WrapToReactive>b__1()
			{
			}

			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0xDEE6C8", Offset = "0xDEE6C8", VA = "0xDEE6C8")]
			internal void <WrapToReactive>b__2(ReactiveValue rv)
			{
			}

			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0xDEE6EC", Offset = "0xDEE6EC", VA = "0xDEE6EC")]
			internal void <WrapToReactive>b__3(ReactiveValue rv)
			{
			}

			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0xDEE710", Offset = "0xDEE710", VA = "0xDEE710")]
			internal void <WrapToReactive>b__4()
			{
			}
		}

		[Token(Token = "0x20001E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778F4C", Offset = "0x778F4C")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x40009FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Func<double, double, IObservable<double>> f;

			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0xDED814", Offset = "0xDED814", VA = "0xDED814")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0xDEE76C", Offset = "0xDEE76C", VA = "0xDEE76C")]
			internal IDisposable <WrapReactiveArgs>b__0(ReactiveArray args, ReactiveValue rvOut)
			{
				return null;
			}
		}

		[Token(Token = "0x20001E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778F5C", Offset = "0x778F5C")]
		private sealed class <>c__DisplayClass17_1
		{
			[Token(Token = "0x40009FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReactiveValue rv0;

			[Token(Token = "0x40009FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ReactiveValue rv1;

			[Token(Token = "0x4000A00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ReactiveValue rvOut;

			[Token(Token = "0x4000A01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IDisposable innerSubs;

			[Token(Token = "0x4000A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action updateN2;

			[Token(Token = "0x4000A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public IDisposable h0;

			[Token(Token = "0x4000A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public IDisposable h1;

			[Token(Token = "0x4000A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public <>c__DisplayClass17_0 CS$<>8__locals1;

			[Token(Token = "0x4000A06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Action<double> <>9__5;

			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0xDEE91C", Offset = "0xDEE91C", VA = "0xDEE91C")]
			public <>c__DisplayClass17_1()
			{
			}

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0xDEE924", Offset = "0xDEE924", VA = "0xDEE924")]
			internal void <WrapReactiveArgs>b__1()
			{
			}

			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0xDEEA94", Offset = "0xDEEA94", VA = "0xDEEA94")]
			internal void <WrapReactiveArgs>b__5(double x)
			{
			}

			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0xDEEAAC", Offset = "0xDEEAAC", VA = "0xDEEAAC")]
			internal void <WrapReactiveArgs>b__2(ReactiveValue rv)
			{
			}

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0xDEEAD0", Offset = "0xDEEAD0", VA = "0xDEEAD0")]
			internal void <WrapReactiveArgs>b__3(ReactiveValue rv)
			{
			}

			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0xDEEAF4", Offset = "0xDEEAF4", VA = "0xDEEAF4")]
			internal void <WrapReactiveArgs>b__4()
			{
			}
		}

		[Token(Token = "0x20001E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778F6C", Offset = "0x778F6C")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000A07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReactiveValue a;

			[Token(Token = "0x4000A08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ReactiveValue b;

			[Token(Token = "0x4000A09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IDisposable funcHandle;

			[Token(Token = "0x4000A0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string debugInfo;

			[Token(Token = "0x4000A0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ReactiveValue r;

			[Token(Token = "0x4000A0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public IDisposableHook aHandle;

			[Token(Token = "0x4000A0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public IDisposableHook bHandle;

			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0xDED96C", Offset = "0xDED96C", VA = "0xDED96C")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0xDEEB5C", Offset = "0xDEEB5C", VA = "0xDEEB5C")]
			internal void <OPFunctor>b__0()
			{
			}

			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0xDEF4A0", Offset = "0xDEF4A0", VA = "0xDEF4A0")]
			internal void <OPFunctor>b__1()
			{
			}
		}

		[Token(Token = "0x20001E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778F7C", Offset = "0x778F7C")]
		private sealed class <>c__DisplayClass30_0<T>
		{
			[Token(Token = "0x4000A0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x4000A0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReactiveNamespace <>4__this;

			[Token(Token = "0x6000AD1")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000AD2")]
			internal void <Eval>b__0()
			{
			}
		}

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static nil const_nil;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DelayedActionQueue _delayedQueue;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, Func<ReactiveNamespace, string, ReactiveValue, ReactiveValue>> UnaryOps;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<string, Func<ReactiveNamespace, string, ReactiveValue, ReactiveValue, ReactiveValue>> BinaryOps;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ASTParser _parser;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, RNSExpression> _cache;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ReactiveArray _ns;

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xDEC7C4", Offset = "0xDEC7C4", VA = "0xDEC7C4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xDEC7C8", Offset = "0xDEC7C8", VA = "0xDEC7C8")]
		public void AddReactiveFunc(string name, Func<ReactiveArray, ReactiveValue, IDisposable> f)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xDEC878", Offset = "0xDEC878", VA = "0xDEC878")]
		public void AddFunc(string name, Func<double, double> f)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xDEC9AC", Offset = "0xDEC9AC", VA = "0xDEC9AC")]
		public void AddFunc(string name, Func<double, double, double> f)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xDECAD0", Offset = "0xDECAD0", VA = "0xDECAD0")]
		public ReactiveNamespace(DelayedActionQueue delayedQueue)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xDED1CC", Offset = "0xDED1CC", VA = "0xDED1CC")]
		private static ReactiveValue OPAdd(ReactiveNamespace ns, string debugInfo, ReactiveValue a, ReactiveValue b)
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xDED300", Offset = "0xDED300", VA = "0xDED300")]
		private static ReactiveValue OPSub(ReactiveNamespace ns, string debugInfo, ReactiveValue a, ReactiveValue b)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xDED434", Offset = "0xDED434", VA = "0xDED434")]
		private static ReactiveValue OPMul(ReactiveNamespace ns, string debugInfo, ReactiveValue a, ReactiveValue b)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xDED568", Offset = "0xDED568", VA = "0xDED568")]
		private static ReactiveValue OPDiv(ReactiveNamespace ns, string debugInfo, ReactiveValue a, ReactiveValue b)
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xDED69C", Offset = "0xDED69C", VA = "0xDED69C")]
		private static ReactiveValue OPMod(ReactiveNamespace ns, string debugInfo, ReactiveValue a, ReactiveValue b)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xDEC900", Offset = "0xDEC900", VA = "0xDEC900")]
		public static Func<ReactiveArray, ReactiveValue, IDisposable> WrapToReactive(ReactiveNamespace ns, string debugInfo, Func<double, double> f)
		{
			return null;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xDECA30", Offset = "0xDECA30", VA = "0xDECA30")]
		public static Func<ReactiveArray, ReactiveValue, IDisposable> WrapToReactive(ReactiveNamespace ns, string debugInfo, Func<double, double, double> f)
		{
			return null;
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xDED774", Offset = "0xDED774", VA = "0xDED774")]
		public static Func<ReactiveArray, ReactiveValue, IDisposable> WrapReactiveArgs(ReactiveNamespace ns, Func<double, double, IObservable<double>> f)
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xDED81C", Offset = "0xDED81C", VA = "0xDED81C")]
		private static ReactiveValue OPFunctor(ReactiveNamespace ns, string debugInfo, ReactiveValue a, ReactiveValue b)
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xDEDA2C", Offset = "0xDEDA2C", VA = "0xDEDA2C")]
		private static double RawAdd(double a, double b)
		{
			return default(double);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xDEDA34", Offset = "0xDEDA34", VA = "0xDEDA34")]
		private static double RawSub(double a, double b)
		{
			return default(double);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xDEDA3C", Offset = "0xDEDA3C", VA = "0xDEDA3C")]
		private static double RawMul(double a, double b)
		{
			return default(double);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xDEDA44", Offset = "0xDEDA44", VA = "0xDEDA44")]
		private static double RawDiv(double a, double b)
		{
			return default(double);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xDEDA4C", Offset = "0xDEDA4C", VA = "0xDEDA4C")]
		private static double RawMod(double a, double b)
		{
			return default(double);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xDEDA50", Offset = "0xDEDA50", VA = "0xDEDA50")]
		public ReactiveArray GetReactiveArray()
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xDEDA58", Offset = "0xDEDA58", VA = "0xDEDA58")]
		public RNSExprHandle GetOrCreate(string spec)
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		public RNSExprHandle GetOrCreate<T>(string spec, T state)
		{
			return null;
		}

		[Token(Token = "0x600062B")]
		private ReactiveValue Eval<T>(ASTNode node, T state)
		{
			return null;
		}

		[Token(Token = "0x600062C")]
		private ReactiveValue EvalRec<T>(ASTNode t, int depth, T state)
		{
			return null;
		}

		[Token(Token = "0x600062D")]
		private static void AssertEqual<T>(T a, T b, string testName)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xDEDABC", Offset = "0xDEDABC", VA = "0xDEDABC")]
		private static void RunNumberTest(string test, double expectedResult, ReactiveNamespace ns, DelayedActionQueue queue)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xDEDC04", Offset = "0xDEDC04", VA = "0xDEDC04")]
		private static void RunTest(string test, object expectedResult, ReactiveNamespace ns, DelayedActionQueue queue)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xDEDDE4", Offset = "0xDEDDE4", VA = "0xDEDDE4")]
		public static void RunTests()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class TeaParticles : MonoBehaviour
	{
		[Token(Token = "0x20001EA")]
		public enum KernelUpdate
		{
			[Token(Token = "0x4000A11")]
			Basic,
			[Token(Token = "0x4000A12")]
			TextureData,
			[Token(Token = "0x4000A13")]
			Grid
		}

		[Token(Token = "0x20001EB")]
		public enum RenderBlend
		{
			[Token(Token = "0x4000A15")]
			Additive,
			[Token(Token = "0x4000A16")]
			Alpha,
			[Token(Token = "0x4000A17")]
			OpaqueWithDepth
		}

		[Token(Token = "0x20001EC")]
		public enum RenderStyle
		{
			[Token(Token = "0x4000A19")]
			Round = 0,
			[Token(Token = "0x4000A1A")]
			Circle = 1,
			[Token(Token = "0x4000A1B")]
			Streak = 16,
			[Token(Token = "0x4000A1C")]
			Drop = 17,
			[Token(Token = "0x4000A1D")]
			Trail = 32,
			[Token(Token = "0x4000A1E")]
			TrailHeavy = 33
		}

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x77A1B8", Offset = "0x77A1B8")]
		public KernelUpdate kernelUpdate;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int maxParticles;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2Int uvResolution;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77A1F0", Offset = "0x77A1F0")]
		public Texture2D textureData;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D textureColor;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x77A200", Offset = "0x77A200")]
		public bool enableSimulation;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool runSimulation;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public RenderBlend renderBlend;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RenderStyle renderStyle;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool forceQuads;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A238", Offset = "0x77A238")]
		public float analyticalAntialias;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77A254", Offset = "0x77A254")]
		public bool glowEnable;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A264", Offset = "0x77A264")]
		public float glow;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool debugGlowSize;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x77A284", Offset = "0x77A284")]
		public bool emitAll;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A294", Offset = "0x77A294")]
		public float flow;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float timeMul;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lifeDuration;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A2AC", Offset = "0x77A2AC")]
		public float lifeDurationV;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float size;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A2C4", Offset = "0x77A2C4")]
		public float sizeV;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float tail;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float tailFromSpeed;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float near;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A2DC", Offset = "0x77A2DC")]
		public float nearFade;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float far;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A2F4", Offset = "0x77A2F4")]
		public float farFade;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Vector3 emitterPosition;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Vector3 emitterSize;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 direction;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float minSpeed;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float maxSpeed;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A30C", Offset = "0x77A30C")]
		public float spread;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float noiseAmplitude;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float noiseFrequency;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float noiseSpeed;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Color color;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int RenderQueue;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public int randomSeed;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public bool debug;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Shader _shaderTPDrop;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Shader _shaderTPDrop_tr;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Shader _shaderTPSimple;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Shader _shaderTPSimple_tr;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Shader _shaderTPGrid_tr;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Material _kernelMaterial;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material _kernelMaterialMRT;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Material _lineMaterial;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material _debugMaterial;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool _useBoxCut;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Matrix4x4 _boxMatrix;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private Vector4 _boxGradient;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private RenderTexture _particleBuffer1;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private RenderTexture _particleBuffer2;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Mesh _mesh;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _needsReset;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float _noiseTime;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Shader _prevShader;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private bool _prevUseQuads;

		[Token(Token = "0x17000023")]
		private int BufferWidth
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0xDEFAC4", Offset = "0xDEFAC4", VA = "0xDEFAC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000024")]
		private int BufferHeight
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0xDEFB0C", Offset = "0xDEFB0C", VA = "0xDEFB0C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		private static float deltaTime
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0xDEFBC0", Offset = "0xDEFBC0", VA = "0xDEFBC0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xDEF944", Offset = "0xDEF944", VA = "0xDEF944")]
		public void DisableBoxCut()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xDEF94C", Offset = "0xDEF94C", VA = "0xDEF94C")]
		public void SetBoxCut(Vector3 position, Quaternion rotation, Vector3 boxRadius, Vector3 gradientLength)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xDEFC00", Offset = "0xDEFC00", VA = "0xDEFC00")]
		private Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xDEFC7C", Offset = "0xDEFC7C", VA = "0xDEFC7C")]
		private RenderTexture CreateBuffer()
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xDE4A5C", Offset = "0xDE4A5C", VA = "0xDE4A5C")]
		public static Mesh CreateParticleMesh(int width, int height, int depth, bool useQuads, int wstep = 1, int hstep = 1, int zstep = 1, int uvFramesW = 1, int uvFramesH = 1, int zFirstFrame = 0, int zLastFrame = 0, [Optional] uint[] optBitmap)
		{
			return null;
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xDEFD48", Offset = "0xDEFD48", VA = "0xDEFD48")]
		private void UpdateKernelShader()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xDEFFFC", Offset = "0xDEFFFC", VA = "0xDEFFFC")]
		private Shader GetShader(string name)
		{
			return null;
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xDF0060", Offset = "0xDF0060", VA = "0xDF0060")]
		private void ResetResources()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xDF0360", Offset = "0xDF0360", VA = "0xDF0360")]
		private void InitializeAndPrewarmBuffers()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xDF0448", Offset = "0xDF0448", VA = "0xDF0448")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xDF06B8", Offset = "0xDF06B8", VA = "0xDF06B8")]
		private void BlitMRT(Texture source, RenderTexture out0, RenderTexture out1, Material mat, int pass)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xDF093C", Offset = "0xDF093C", VA = "0xDF093C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xDF11D4", Offset = "0xDF11D4", VA = "0xDF11D4")]
		private static float rsi(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xDE5CA4", Offset = "0xDE5CA4", VA = "0xDE5CA4")]
		public static void SetGlow(Material lineMaterial, bool glowEnable, float glow, out float sizeMul, bool debugGlowSize)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xDF103C", Offset = "0xDF103C", VA = "0xDF103C")]
		public static void SetBoxCut(Material lineMaterial, bool useBoxCut, Transform trans, Matrix4x4 boxMatrix, Vector4 boxGradient)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xDE4988", Offset = "0xDE4988", VA = "0xDE4988")]
		public static void SetAdditive(Material lineMaterial, bool additive)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xDF11B0", Offset = "0xDF11B0", VA = "0xDF11B0")]
		private static void KeywordEnable(Material m, string keyword, bool enable)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xDF124C", Offset = "0xDF124C", VA = "0xDF124C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xDF13FC", Offset = "0xDF13FC", VA = "0xDF13FC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xDF1488", Offset = "0xDF1488", VA = "0xDF1488")]
		public TeaParticles()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class TeaParticlesBoxCut : MonoBehaviour
	{
		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TeaParticles target;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeDistance;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 fadeDistanceMul;

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x15128A4", Offset = "0x15128A4", VA = "0x15128A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1512938", Offset = "0x1512938", VA = "0x1512938")]
		private void Update()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1512B34", Offset = "0x1512B34", VA = "0x1512B34")]
		public TeaParticlesBoxCut()
		{
		}
	}
}
namespace SpUnityHelpers
{
	[Token(Token = "0x20000E3")]
	public class SpMath
	{
		[Token(Token = "0x600064C")]
		[Address(RVA = "0xF7E800", Offset = "0xF7E800", VA = "0xF7E800")]
		public static Vector3 ToNormalizedSpherical(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xF7E8F0", Offset = "0xF7E8F0", VA = "0xF7E8F0")]
		public static Vector3 FromNormalizedSpherical(Vector3 magnitude_leftright_updown)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xF7E9E8", Offset = "0xF7E9E8", VA = "0xF7E9E8")]
		public static float SubstractCircular(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xF75A18", Offset = "0xF75A18", VA = "0xF75A18")]
		public static bool IsPointInTriangle(Vector2 p, Vector2 p0, Vector2 p1, Vector2 p2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xF7EA84", Offset = "0xF7EA84", VA = "0xF7EA84")]
		public static bool Approximately(float a, float b, float threshold = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xF7E02C", Offset = "0xF7E02C", VA = "0xF7E02C")]
		public static bool Approximately(Matrix4x4 a, Matrix4x4 b, float threshold = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xF7EAA0", Offset = "0xF7EAA0", VA = "0xF7EAA0")]
		public SpMath()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class CheckForRelativeTransformUpdate
	{
		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CheckForTransformUpdate parent;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CheckForTransformUpdate child;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Matrix4x4 lastMat;

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xF77560", Offset = "0xF77560", VA = "0xF77560")]
		public bool WasUpdated(GameObject childGameObject, GameObject parentGameObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xF7E238", Offset = "0xF7E238", VA = "0xF7E238")]
		public Matrix4x4 GetRelativeTransform()
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xF78984", Offset = "0xF78984", VA = "0xF78984")]
		public CheckForRelativeTransformUpdate()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class CheckForTransformUpdate
	{
		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 nullvec;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 prev;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Matrix4x4 prevM;

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xF78A4C", Offset = "0xF78A4C", VA = "0xF78A4C")]
		public CheckForTransformUpdate()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xF7745C", Offset = "0xF7745C", VA = "0xF7745C")]
		public bool WasUpdated(GameObject cur, bool onlyCheckPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xF7E428", Offset = "0xF7E428", VA = "0xF7E428")]
		public bool WasUpdated(Matrix4x4 cur)
		{
			return default(bool);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xF7E2CC", Offset = "0xF7E2CC", VA = "0xF7E2CC")]
		public bool WasUpdated(Vector3 cur)
		{
			return default(bool);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xF7E24C", Offset = "0xF7E24C", VA = "0xF7E24C")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public struct CheckForUpdate<T>
	{
		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T LastValue;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool LastValueValid;

		[Token(Token = "0x600065C")]
		public CheckForUpdate(bool useStartingValue = false, [Optional] T startingValue)
		{
		}

		[Token(Token = "0x600065D")]
		public bool WasUpdated(T cur)
		{
			return default(bool);
		}

		[Token(Token = "0x600065E")]
		public void SetCurrentValue(T val)
		{
		}

		[Token(Token = "0x600065F")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class Util
	{
		[Token(Token = "0x20001ED")]
		public interface SpUnityEditorUpdate
		{
			[Token(Token = "0x6000AD3")]
			void EditorUpdate();
		}

		[Serializable]
		[Token(Token = "0x20001EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778F8C", Offset = "0x778F8C")]
		private sealed class <>c__2<T> where T : new()
		{
			[Token(Token = "0x4000A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__2<T> <>9;

			[Token(Token = "0x4000A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<byte, byte> <>9__2_0;

			[Token(Token = "0x4000A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<byte, string> <>9__2_1;

			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<string, string, string> <>9__2_2;

			[Token(Token = "0x4000A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<byte, string> <>9__2_3;

			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<string, string, string> <>9__2_4;

			[Token(Token = "0x6000AD5")]
			public <>c__2()
			{
			}

			[Token(Token = "0x6000AD6")]
			internal byte <StructHasPaddingHoles>b__2_0(byte x)
			{
				return default(byte);
			}

			[Token(Token = "0x6000AD7")]
			internal string <StructHasPaddingHoles>b__2_1(byte x)
			{
				return null;
			}

			[Token(Token = "0x6000AD8")]
			internal string <StructHasPaddingHoles>b__2_2(string c, string n)
			{
				return null;
			}

			[Token(Token = "0x6000AD9")]
			internal string <StructHasPaddingHoles>b__2_3(byte x)
			{
				return null;
			}

			[Token(Token = "0x6000ADA")]
			internal string <StructHasPaddingHoles>b__2_4(string c, string n)
			{
				return null;
			}
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xA34DB0", Offset = "0xA34DB0", VA = "0xA34DB0")]
		public static void RegisterForEditorUpdate(SpUnityEditorUpdate obj, bool add)
		{
		}

		[Token(Token = "0x6000661")]
		public static bool StructHasPaddingHoles<T>() where T : new()
		{
			return default(bool);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xA34DB4", Offset = "0xA34DB4", VA = "0xA34DB4")]
		public Util()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	internal class Dimworldtest
	{
		[Token(Token = "0x20001EF")]
		private struct GenerateSphereArgs
		{
			[Token(Token = "0x4000A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float Quality;

			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0xF7E7F8", Offset = "0xF7E7F8", VA = "0xF7E7F8")]
			public GenerateSphereArgs(float quality)
			{
			}
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xF7E5B8", Offset = "0xF7E5B8", VA = "0xF7E5B8")]
		private Mesh GenerateSphere(ref GenerateSphereArgs args, int a, out SpGCache.ProcessMetrics outMetrics)
		{
			return null;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xF7E668", Offset = "0xF7E668", VA = "0xF7E668")]
		public void Test()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xF7E7F0", Offset = "0xF7E7F0", VA = "0xF7E7F0")]
		public Dimworldtest()
		{
		}
	}
}
namespace SpacePlunge
{
	[Token(Token = "0x20000E9")]
	public static class SDF
	{
		[Token(Token = "0x20001F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778F9C", Offset = "0x778F9C")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x4000A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 sdRoundBoxSize;

			[Token(Token = "0x4000A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float cornerRadius;

			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0xA3BD74", Offset = "0xA3BD74", VA = "0xA3BD74")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0xA3C06C", Offset = "0xA3C06C", VA = "0xA3C06C")]
			internal float <RaymarchRoundedBox>b__0(Vector3 v)
			{
				return default(float);
			}

			[Token(Token = "0x6000ADE")]
			[Address(RVA = "0xA3C078", Offset = "0xA3C078", VA = "0xA3C078")]
			internal float <RaymarchRoundedBox>b__1(Vector3 v)
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xA3ABA0", Offset = "0xA3ABA0", VA = "0xA3ABA0")]
		private static Vector2 vec2(float x, float y)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xA3ABCC", Offset = "0xA3ABCC", VA = "0xA3ABCC")]
		private static Vector3 vec3(float x, float y, float z)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xA3AC00", Offset = "0xA3AC00", VA = "0xA3AC00")]
		private static float length(Vector3 p)
		{
			return default(float);
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xA3AC2C", Offset = "0xA3AC2C", VA = "0xA3AC2C")]
		private static float min(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xA3ACA4", Offset = "0xA3ACA4", VA = "0xA3ACA4")]
		private static float max(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xA3AD1C", Offset = "0xA3AD1C", VA = "0xA3AD1C")]
		private static float abs(float a)
		{
			return default(float);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xA3AD88", Offset = "0xA3AD88", VA = "0xA3AD88")]
		private static Vector3 max(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xA3AE30", Offset = "0xA3AE30", VA = "0xA3AE30")]
		private static Vector3 min(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xA3AED8", Offset = "0xA3AED8", VA = "0xA3AED8")]
		private static float dot(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xA3AF80", Offset = "0xA3AF80", VA = "0xA3AF80")]
		private static Vector2 xy(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xA3AFAC", Offset = "0xA3AFAC", VA = "0xA3AFAC")]
		private static Vector2 xz(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xA3AFDC", Offset = "0xA3AFDC", VA = "0xA3AFDC")]
		private static Vector3 float2vec(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xA3B018", Offset = "0xA3B018", VA = "0xA3B018")]
		private static Vector3 max(Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xA3B0EC", Offset = "0xA3B0EC", VA = "0xA3B0EC")]
		private static Vector3 min(Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xA3B1C0", Offset = "0xA3B1C0", VA = "0xA3B1C0")]
		private static Vector3 abs(Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xA3B218", Offset = "0xA3B218", VA = "0xA3B218")]
		private static Vector3 mulInv(Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xA3B25C", Offset = "0xA3B25C", VA = "0xA3B25C")]
		private static Vector3 mul(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xA3B304", Offset = "0xA3B304", VA = "0xA3B304")]
		public static float sdSphere(Vector3 p, float s)
		{
			return default(float);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xA3B340", Offset = "0xA3B340", VA = "0xA3B340")]
		public static float sdBox(Vector3 p, Vector3 b)
		{
			return default(float);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xA3B460", Offset = "0xA3B460", VA = "0xA3B460")]
		public static float sdRoundBox(Vector3 p, Vector3 b, float r)
		{
			return default(float);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xA3B590", Offset = "0xA3B590", VA = "0xA3B590")]
		public static float sdTorus(Vector3 p, Vector2 t)
		{
			return default(float);
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xA3B69C", Offset = "0xA3B69C", VA = "0xA3B69C")]
		public static float sdCylinder(Vector3 p, Vector3 c)
		{
			return default(float);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xA3B79C", Offset = "0xA3B79C", VA = "0xA3B79C")]
		public static float sdCone(Vector3 p, Vector2 c)
		{
			return default(float);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xA3B8CC", Offset = "0xA3B8CC", VA = "0xA3B8CC")]
		public static Vector2 iBox(Vector3 ro, Vector3 rd, Vector3 rad)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xA3BA8C", Offset = "0xA3BA8C", VA = "0xA3BA8C")]
		public static float RaymarchRoundedBox(Vector3 ro, Vector3 rd, Vector3 size, float cornerRadius, bool alsoCheckBehind = false)
		{
			return default(float);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xA3BD7C", Offset = "0xA3BD7C", VA = "0xA3BD7C")]
		public static float Raymarch(Vector3 ro, Vector3 rd, Func<Vector3, float> map, float startNudge = 0.0001f, float maxDist = 20f, int maxIter = 70)
		{
			return default(float);
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xA3BED8", Offset = "0xA3BED8", VA = "0xA3BED8")]
		public static Vector2 Raymarch(Vector3 ro, Vector3 rd, Func<Vector3, Vector2> map, int maxIter = 70, float maxDist = 20f, float startNudge = 0.0001f)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x20000EA")]
	public class softAction
	{
		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float IgnoreTarget;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float vel;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float val;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float timer;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool prevIsFadingIn;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float filterAmount;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float filterShape;

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xA4C2D4", Offset = "0xA4C2D4", VA = "0xA4C2D4")]
		private float specialFilter(float target, float ootime, float dt, float cur, ref float vel, float filterShape, float filterAmount)
		{
			return default(float);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xA3D784", Offset = "0xA3D784", VA = "0xA3D784")]
		public softAction()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xA3FC20", Offset = "0xA3FC20", VA = "0xA3FC20")]
		public softAction(float _filterShape, float _filterAmount = 1f)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xA3CE34", Offset = "0xA3CE34", VA = "0xA3CE34")]
		public void reset(float v)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xA4C540", Offset = "0xA4C540", VA = "0xA4C540")]
		public void resetValueKeepDirection(float v)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xA4C548", Offset = "0xA4C548", VA = "0xA4C548")]
		public float get()
		{
			return default(float);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xA3F9C0", Offset = "0xA3F9C0", VA = "0xA3F9C0")]
		public float processPeriodic(float period, float dt, float input, float inFade, float outFade, float inDelay, float outDelay)
		{
			return default(float);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xA3D5F4", Offset = "0xA3D5F4", VA = "0xA3D5F4")]
		public float process(float dt, float input, float inFade, float outFade, float inDelay, float outDelay)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000EB")]
	public class VRDebugMovement : MonoBehaviour
	{
		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Sensitivity;

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xA47AA0", Offset = "0xA47AA0", VA = "0xA47AA0")]
		private void Update()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xA47D88", Offset = "0xA47D88", VA = "0xA47D88")]
		public VRDebugMovement()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class VRSyncTransform : MonoBehaviour
	{
		[Token(Token = "0x20001F1")]
		public enum SyncType
		{
			[Token(Token = "0x4000A29")]
			LeftHand,
			[Token(Token = "0x4000A2A")]
			RightHand,
			[Token(Token = "0x4000A2B")]
			HeadCamera
		}

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<bool> _ignoreSync;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<GameObject> _lastUpdated;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SyncType Sync;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject Target;

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xA4B79C", Offset = "0xA4B79C", VA = "0xA4B79C")]
		public static GameObject GetLastUpdated(SyncType t)
		{
			return null;
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xA4B830", Offset = "0xA4B830", VA = "0xA4B830")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xA49E58", Offset = "0xA49E58", VA = "0xA49E58")]
		public static void IgnoreControllers(bool ignore)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xA4B850", Offset = "0xA4B850", VA = "0xA4B850")]
		public static void IgnoreControllers(bool IgnoreLeft, bool IgnoreRight)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xA4B904", Offset = "0xA4B904", VA = "0xA4B904")]
		private void Update()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xA4BAB8", Offset = "0xA4BAB8", VA = "0xA4BAB8")]
		public VRSyncTransform()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class VRThumbStickNav : MonoBehaviour
	{
		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Speed;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Smoothing;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PositionSmoother _posSmoother;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _lastTimeStamp;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool _thumbStickClicked;

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xA4BBE8", Offset = "0xA4BBE8", VA = "0xA4BBE8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xA4BC30", Offset = "0xA4BC30", VA = "0xA4BC30")]
		private void Update()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xA4C258", Offset = "0xA4C258", VA = "0xA4C258")]
		public VRThumbStickNav()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class AdjustLaserPosForSteamVR : MonoBehaviour
	{
		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsLeft;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _xrDevice;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isRift;

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xA35858", Offset = "0xA35858", VA = "0xA35858")]
		public AdjustLaserPosForSteamVR()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class CrossPlatformInit : MonoBehaviour
	{
		[Token(Token = "0x20001F2")]
		public enum VRPlatform
		{
			[Token(Token = "0x4000A2D")]
			SteamVR = 0,
			[Token(Token = "0x4000A2E")]
			Oculus = 1,
			[Token(Token = "0x4000A2F")]
			Daydream = 2,
			[Token(Token = "0x4000A30")]
			Cardboard = 3,
			[Token(Token = "0x4000A31")]
			Wave = 4,
			[Token(Token = "0x4000A32")]
			Nolo = 5,
			[Token(Token = "0x4000A33")]
			Others = 999
		}

		[Token(Token = "0x20001F3")]
		public enum Platform
		{
			[Token(Token = "0x4000A35")]
			All = 0,
			[Token(Token = "0x4000A36")]
			StandaloneOnly = 1,
			[Token(Token = "0x4000A37")]
			MobileOnly = 2,
			[Token(Token = "0x4000A38")]
			IOSOnly = 3,
			[Token(Token = "0x4000A39")]
			AndroidOnly = 4,
			[Token(Token = "0x4000A3A")]
			OculusQuestOnly = 5,
			[Token(Token = "0x4000A3B")]
			None = 999
		}

		[Serializable]
		[Token(Token = "0x20001F4")]
		public class InstantiateOnAwake
		{
			[Token(Token = "0x4000A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public VRPlatform vrplatform;

			[Token(Token = "0x4000A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Platform platform;

			[Token(Token = "0x4000A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject prefab;

			[Token(Token = "0x4000A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string relativePath;

			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0xA35EA0", Offset = "0xA35EA0", VA = "0xA35EA0")]
			public InstantiateOnAwake()
			{
			}
		}

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<InstantiateOnAwake> prefabs;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool created;

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xA358FC", Offset = "0xA358FC", VA = "0xA358FC")]
		private Transform GetByRelativePath(string path)
		{
			return null;
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xA35AF4", Offset = "0xA35AF4", VA = "0xA35AF4")]
		private void InstantiatePrefab(InstantiateOnAwake entry)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xA35D60", Offset = "0xA35D60", VA = "0xA35D60")]
		private void Awake()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xA35E98", Offset = "0xA35E98", VA = "0xA35E98")]
		public CrossPlatformInit()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class DisableByPlatform : MonoBehaviour
	{
		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Disable_for_SP_USE_STEAMVR;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool Disable_for_SP_USE_OCULUS;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool Disable_for_SP_USE_GVR;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool Disable_for_SP_USE_CARDBOARD;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool Disable_for_SP_USE_WAVE;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool Disable_for_SP_USE_NOLO;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool Disable_for_others;

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xA36360", Offset = "0xA36360", VA = "0xA36360")]
		private void Awake()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xA36398", Offset = "0xA36398", VA = "0xA36398")]
		public DisableByPlatform()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class LanguageSupport : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001F5")]
		public class Translation
		{
			[Token(Token = "0x4000A40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool Enabled;

			[Token(Token = "0x4000A41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public SystemLanguage Language;

			[Token(Token = "0x4000A42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string TextureFolder;

			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0xA36DDC", Offset = "0xA36DDC", VA = "0xA36DDC")]
			public Translation()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001F6")]
		public class Variation
		{
			[Token(Token = "0x4000A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x4000A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string CurrentOption;

			[Token(Token = "0x4000A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string CurrentFallback;

			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0xA36DF4", Offset = "0xA36DF4", VA = "0xA36DF4")]
			public Variation()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001F7")]
		public class AlterOptionsAtRuntimeStartupEvent : UnityEvent<Dictionary<string, Variation>>
		{
			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0xA36D8C", Offset = "0xA36D8C", VA = "0xA36D8C")]
			public AlterOptionsAtRuntimeStartupEvent()
			{
			}
		}

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Translation> Translations;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Variation> Variations;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AlterOptionsAtRuntimeStartupEvent AlterOptionsAtRuntimeStartup;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Material> Materials;

		[NonSerialized]
		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _curFolder;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, Variation> _variationLookup;

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xA363A0", Offset = "0xA363A0", VA = "0xA363A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xA36414", Offset = "0xA36414", VA = "0xA36414")]
		public void UpdateLanguage(SystemLanguage lang, SystemLanguage fallbackLang)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xA36BCC", Offset = "0xA36BCC", VA = "0xA36BCC")]
		private void ValidateVarationLookup()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xA368F4", Offset = "0xA368F4", VA = "0xA368F4")]
		private Texture GetTextureWithVariationFallback(string langFolder, string resourceName)
		{
			return null;
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xA36D34", Offset = "0xA36D34", VA = "0xA36D34")]
		public LanguageSupport()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class SmoothActive : MonoBehaviour
	{
		[Token(Token = "0x20001F8")]
		public interface SmoothActiveSupport
		{
			[Token(Token = "0x6000AE3")]
			void SetSmoothActive(float amount);
		}

		[Token(Token = "0x20001F9")]
		private struct SmoothActiveSupportItem
		{
			[Token(Token = "0x4000A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SmoothActiveSupport smoothActive;

			[Token(Token = "0x4000A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameObject gameObject;
		}

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float smooth;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fadeInTime;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeOutTime;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fadeInDelay;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeOutDelay;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Material material;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string materialProperty;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float materialPropertyOff;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float materialPropertyOn;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private softAction action;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject obj;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject transformOn;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject transformOff;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float targetValue;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<SmoothActiveSupportItem> _smoothActiveNotify;

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xA3C7A4", Offset = "0xA3C7A4", VA = "0xA3C7A4")]
		public static bool IsActive(GameObject o)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xA3C894", Offset = "0xA3C894", VA = "0xA3C894")]
		public static void SetActive(GameObject o, bool value)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xA3C8A8", Offset = "0xA3C8A8", VA = "0xA3C8A8")]
		public static void SetActive(GameObject o, float value)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xA3CB20", Offset = "0xA3CB20", VA = "0xA3CB20")]
		private void hookUpObjects()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xA3CE30", Offset = "0xA3CE30", VA = "0xA3CE30")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xA3CA9C", Offset = "0xA3CA9C", VA = "0xA3CA9C")]
		public void SetTargetValue(float f)
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xA3D4F4", Offset = "0xA3D4F4", VA = "0xA3D4F4")]
		public void RegisterSmoothActive(SmoothActiveSupport obj, GameObject _gameObject)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xA3D564", Offset = "0xA3D564", VA = "0xA3D564")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xA3CE40", Offset = "0xA3CE40", VA = "0xA3CE40")]
		private void UpdateStuff()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xA3D580", Offset = "0xA3D580", VA = "0xA3D580")]
		private void Update()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xA3D6C4", Offset = "0xA3D6C4", VA = "0xA3D6C4")]
		public SmoothActive()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class SmoothActiveRoot : MonoBehaviour
	{
		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SmoothActive[] All;

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xA3CA24", Offset = "0xA3CA24", VA = "0xA3CA24")]
		public void SetAllActive(float v)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xA3D794", Offset = "0xA3D794", VA = "0xA3D794")]
		private void Start()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xA3D7EC", Offset = "0xA3D7EC", VA = "0xA3D7EC")]
		public SmoothActiveRoot()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class SwipeAndGyroControl : MonoBehaviour
	{
		[Token(Token = "0x20001FA")]
		public enum RotationBehaviour
		{
			[Token(Token = "0x4000A49")]
			OnlyTouch,
			[Token(Token = "0x4000A4A")]
			OnlyGyro,
			[Token(Token = "0x4000A4B")]
			AutoSwitch,
			[Token(Token = "0x4000A4C")]
			Combined
		}

		[Token(Token = "0x20001FB")]
		private struct EventItem
		{
			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VRInteractable target;

			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public VRInteractable.Event eventData;

			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0xA3F8C4", Offset = "0xA3F8C4", VA = "0xA3F8C4")]
			public EventItem(VRInteractable _target, VRInteractable.Event _eventData)
			{
			}
		}

		[Token(Token = "0x20001FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778FAC", Offset = "0x778FAC")]
		private sealed class <LoadDevice>d__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SwipeAndGyroControl <>4__this;

			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool enable;

			[Token(Token = "0x17000065")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AE8")]
				[Address(RVA = "0xA3FE38", Offset = "0xA3FE38", VA = "0xA3FE38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AEA")]
				[Address(RVA = "0xA3FEA0", Offset = "0xA3FEA0", VA = "0xA3FEA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0xA3DB44", Offset = "0xA3DB44", VA = "0xA3DB44")]
			[DebuggerHidden]
			public <LoadDevice>d__41(int <>1__state)
			{
			}

			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0xA3FC60", Offset = "0xA3FC60", VA = "0xA3FC60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0xA3FC64", Offset = "0xA3FC64", VA = "0xA3FC64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0xA3FE40", Offset = "0xA3FE40", VA = "0xA3FE40", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RotationBehaviour Behaviour;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _prevUsingGyro;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool _usingGyro;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _lastTouchTime;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 _accumSwitch;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LayerMask layerMask;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float RotationLeftRight;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float RotationUpDown;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float RotationRoll;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _touchRotationLeftRight;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _touchRotationUpDown;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _gyroRotationOffset;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A324", Offset = "0x77A324")]
		public float Zoom;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float TouchRotateSensitivity;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x77A33C", Offset = "0x77A33C")]
		public float RotateSensByFov;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float ZoomSensitivity;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector2 ZoomFovRange;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector2 ZoomDollyRange;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject TargetOverride;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GameObject TargetCameraForZoom;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool SetTargetFrameRate;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public int TargetFrameRate;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool SupportCardboardVR;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool UseCardboardCornerButton;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Material CardboardLogo;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _isZooming;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _zoomStartDiff;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _zoomStartZoom;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _waitingForModeSwitch;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float Smoothing;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private softAction _smoothZoom;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private softAction _smoothRoll;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private softAction _smoothRotUpDown;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private softAction _smoothRotLeftRight;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool _touchWithoutMoveOrZoom;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int _prevTouchCount;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector2 _orgPos;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Dictionary<int, EventItem> interactiveItems;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xA3D7F8", Offset = "0xA3D7F8", VA = "0xA3D7F8")]
		public bool IsUsingTouch()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xA3D88C", Offset = "0xA3D88C", VA = "0xA3D88C")]
		public bool IsUsingGyro()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xA3D830", Offset = "0xA3D830", VA = "0xA3D830")]
		public bool IsUsingTouchOrGyro()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xA3D934", Offset = "0xA3D934", VA = "0xA3D934")]
		public float TimeSinceLastTouch()
		{
			return default(float);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xA3D960", Offset = "0xA3D960", VA = "0xA3D960")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xA3D994", Offset = "0xA3D994", VA = "0xA3D994")]
		public Quaternion GetMagicWindowRot()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xA3DAC0", Offset = "0xA3DAC0", VA = "0xA3DAC0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77B504", Offset = "0x77B504")]
		private IEnumerator LoadDevice(bool enable)
		{
			return null;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xA3DB70", Offset = "0xA3DB70", VA = "0xA3DB70")]
		public void EnableVR(bool enable)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xA3D8C4", Offset = "0xA3D8C4", VA = "0xA3D8C4")]
		public bool IsVREnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xA3DBA8", Offset = "0xA3DBA8", VA = "0xA3DBA8")]
		private float GetScreenSize()
		{
			return default(float);
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xA3DC74", Offset = "0xA3DC74", VA = "0xA3DC74")]
		public bool IsTablet()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xA3DC7C", Offset = "0xA3DC7C", VA = "0xA3DC7C")]
		private bool SupportsCardBoard()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xA3DC84", Offset = "0xA3DC84", VA = "0xA3DC84")]
		private float LogScale(float x, float from, float to)
		{
			return default(float);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xA3DD18", Offset = "0xA3DD18", VA = "0xA3DD18")]
		private float InvScale(float x, float from, float to)
		{
			return default(float);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xA3DDAC", Offset = "0xA3DDAC", VA = "0xA3DDAC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xA3FA24", Offset = "0xA3FA24", VA = "0xA3FA24")]
		public SwipeAndGyroControl()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class VRButton : VRInteractable, SmoothActive.SmoothActiveSupport
	{
		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float globalRotationAngle;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float globalScale;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject NormalState;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject DownState;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool SetMaterialOpacityByState;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private softAction _smoothOpacity;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float NormalOpacity;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float ButtonDownOpacity;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float DisabledOpacity;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool UseGlobalRotationAndScale;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		public bool DisableVertical;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _parentGroupOpacity;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _prevState;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool _isDown;

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xA45E84", Offset = "0xA45E84", VA = "0xA45E84")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xA45F40", Offset = "0xA45F40", VA = "0xA45F40", Slot = "10")]
		private void SpacePlunge.SmoothActive.SmoothActiveSupport.SetSmoothActive(float amount)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xA45F54", Offset = "0xA45F54", VA = "0xA45F54")]
		private void UpdateStuff()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xA463B0", Offset = "0xA463B0", VA = "0xA463B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xA4642C", Offset = "0xA4642C", VA = "0xA4642C")]
		private void SetDownState(bool isDown)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xA46518", Offset = "0xA46518", VA = "0xA46518", Slot = "8")]
		public override void OnEnable()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xA465D4", Offset = "0xA465D4", VA = "0xA465D4", Slot = "5")]
		public override void OnButtonDown(Event e)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xA465DC", Offset = "0xA465DC", VA = "0xA465DC", Slot = "6")]
		public override void OnButtonCancel()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xA465E4", Offset = "0xA465E4", VA = "0xA465E4", Slot = "7")]
		public override void OnButtonUp()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xA46634", Offset = "0xA46634", VA = "0xA46634")]
		public VRButton()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class VRCursor : MonoBehaviour
	{
		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool GlobalEnabled;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsLeft;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Priority;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SoftBlinkAmount;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float SoftBlinkHz;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject AnimationOverride;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool ExtraEnable;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool EffectBound;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Hidden;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Opacity;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<VRCursor> _activeInstances;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VRCursor _currentR;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static VRCursor _currentL;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool _laserEnabledR;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private static bool _laserEnabledL;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private softAction _smoothActive;

		[Token(Token = "0x17000026")]
		public static VRCursor CurrentR
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0xA46FC8", Offset = "0xA46FC8", VA = "0xA46FC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public static VRCursor CurrentL
		{
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0xA47030", Offset = "0xA47030", VA = "0xA47030")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public static bool LaserEnabledR
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0xA47098", Offset = "0xA47098", VA = "0xA47098")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000029")]
		public static bool LaserEnabledL
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0xA47100", Offset = "0xA47100", VA = "0xA47100")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public static VRCursor CurrentLastUsed
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0xA47168", Offset = "0xA47168", VA = "0xA47168")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xA46764", Offset = "0xA46764", VA = "0xA46764")]
		public static bool hasR()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xA46838", Offset = "0xA46838", VA = "0xA46838")]
		public static bool hasL()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xA4690C", Offset = "0xA4690C", VA = "0xA4690C")]
		public static int controllerCount()
		{
			return default(int);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xA4699C", Offset = "0xA4699C", VA = "0xA4699C")]
		public static void GlobalUpdate()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xA47360", Offset = "0xA47360", VA = "0xA47360")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xA473F4", Offset = "0xA473F4", VA = "0xA473F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xA4747C", Offset = "0xA4747C", VA = "0xA4747C")]
		private static void SetMaterialAlpha(Material m, float a)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xA474C0", Offset = "0xA474C0", VA = "0xA474C0")]
		private static void SetMaterialAlpha(GameObject o, float val)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xA4764C", Offset = "0xA4764C", VA = "0xA4764C")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xA47678", Offset = "0xA47678", VA = "0xA47678")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xA4779C", Offset = "0xA4779C", VA = "0xA4779C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xA47964", Offset = "0xA47964", VA = "0xA47964")]
		public VRCursor()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class VRGazeControl : MonoBehaviour
	{
		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool GlobalEnabled;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material material;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float size;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float fadeDuration;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float CameraRotationMovementThreshold;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Mesh> countDownMesh;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _go;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private VRInteractable _cur;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _curCounter;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _curColliderOffset;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _prevCounter;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _cameraRotationSpeed;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _cameraRotationSpeedVel;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 _cameraPrevForward;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<Vector3> _lines;

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xA47D98", Offset = "0xA47D98", VA = "0xA47D98")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xA47F0C", Offset = "0xA47F0C", VA = "0xA47F0C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xA47F7C", Offset = "0xA47F7C", VA = "0xA47F7C")]
		private float AngleFromViewCenter(Vector3 ro, Vector3 rd, Vector3 pos)
		{
			return default(float);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xA48078", Offset = "0xA48078", VA = "0xA48078")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xA48A90", Offset = "0xA48A90", VA = "0xA48A90")]
		private Color smoothValToCol(float smoothval)
		{
			return default(Color);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xA48AD8", Offset = "0xA48AD8", VA = "0xA48AD8")]
		private static Vector2 mul(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xA48B68", Offset = "0xA48B68", VA = "0xA48B68")]
		private static Vector2 mul(Vector2 a, float b)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xA48BF0", Offset = "0xA48BF0", VA = "0xA48BF0")]
		private void GenerateCountDownLines(int count, Action<Vector2, Vector2> line, int N = 12)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xA48FD4", Offset = "0xA48FD4", VA = "0xA48FD4")]
		private Mesh GenCountDownMesh(int i)
		{
			return null;
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xA490AC", Offset = "0xA490AC", VA = "0xA490AC")]
		public VRGazeControl()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xA49164", Offset = "0xA49164", VA = "0xA49164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B568", Offset = "0x77B568")]
		private void <GenCountDownMesh>b__25_0(Vector2 v1, Vector2 v2)
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class VRInput : MonoBehaviour
	{
		[Token(Token = "0x20001FD")]
		public enum Button
		{
			[Token(Token = "0x4000A54")]
			MainOrTrigger,
			[Token(Token = "0x4000A55")]
			Main,
			[Token(Token = "0x4000A56")]
			Trigger,
			[Token(Token = "0x4000A57")]
			Back,
			[Token(Token = "0x4000A58")]
			Left,
			[Token(Token = "0x4000A59")]
			Right,
			[Token(Token = "0x4000A5A")]
			TouchPadTouch,
			[Token(Token = "0x4000A5B")]
			TouchPadClick,
			[Token(Token = "0x4000A5C")]
			ThumbStickClick,
			[Token(Token = "0x4000A5D")]
			Grab,
			[Token(Token = "0x4000A5E")]
			_NONE
		}

		[Token(Token = "0x20001FE")]
		public enum Axis2D
		{
			[Token(Token = "0x4000A60")]
			TouchPad,
			[Token(Token = "0x4000A61")]
			ThumbStick
		}

		[Token(Token = "0x20001FF")]
		public enum TrackedPosition
		{
			[Token(Token = "0x4000A63")]
			Head,
			[Token(Token = "0x4000A64")]
			LeftHand,
			[Token(Token = "0x4000A65")]
			RightHand
		}

		[Token(Token = "0x400064D")]
		private const int _firstButtonId = 1;

		[Token(Token = "0x400064E")]
		private const int _lastButtonId = 9;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _slots;

		[Token(Token = "0x4000650")]
		private const int isDown = 0;

		[Token(Token = "0x4000651")]
		private const int wasPressed = 1;

		[Token(Token = "0x4000652")]
		private const int wasReleased = 2;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static float[] _injected;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static float[] _prevInjected;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Vector2? _clickPosition;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject[] _claimed;

		[Token(Token = "0x4000657")]
		private const bool simulateTouchpadWithMiddleMouse = false;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static bool _forceGaze;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private static bool _lastWasLeft;

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xA4923C", Offset = "0xA4923C", VA = "0xA4923C")]
		public static bool GetButton(Button button, [Optional] GameObject requester)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xA35778", Offset = "0xA35778", VA = "0xA35778")]
		public static bool GetButtonDown(Button button, [Optional] GameObject requester)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xA495B0", Offset = "0xA495B0", VA = "0xA495B0")]
		public static bool GetButtonUp(Button button, [Optional] GameObject requester)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xA49628", Offset = "0xA49628", VA = "0xA49628")]
		public static bool HasClickPosition()
		{
			return default(bool);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xA49690", Offset = "0xA49690", VA = "0xA49690")]
		public static Vector2 GetClickPosition()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xA3F8CC", Offset = "0xA3F8CC", VA = "0xA3F8CC")]
		public static void InjectButton(Button button, float time = 0f, [Optional] Vector2? clickPosition)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xA49704", Offset = "0xA49704", VA = "0xA49704")]
		public static void SwapActiveHand()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xA3F718", Offset = "0xA3F718", VA = "0xA3F718")]
		public static void ClaimButtonEvent(Button button, GameObject owner)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xA47D24", Offset = "0xA47D24", VA = "0xA47D24")]
		public static Vector2 GetAxis2D(Axis2D axis)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xA4988C", Offset = "0xA4988C", VA = "0xA4988C")]
		private static Vector3 GetCameraMainPos()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xA492B4", Offset = "0xA492B4", VA = "0xA492B4")]
		private static bool wrap_Button(Button button, int check, GameObject requester)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xA49B84", Offset = "0xA49B84", VA = "0xA49B84")]
		public static void globalLateUpdate()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xA49DB4", Offset = "0xA49DB4", VA = "0xA49DB4")]
		public static void ForceGaze(bool forcedGazeMode)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xA49EC0", Offset = "0xA49EC0", VA = "0xA49EC0")]
		public static bool isUsingGazeClick()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xA49F28", Offset = "0xA49F28", VA = "0xA49F28")]
		private static bool HMDHaveActionButton()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xA49F90", Offset = "0xA49F90", VA = "0xA49F90")]
		public static bool has6DofHandControllers()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xA49F88", Offset = "0xA49F88", VA = "0xA49F88")]
		public static bool isGearVR()
		{
			return default(bool);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xA49F98", Offset = "0xA49F98", VA = "0xA49F98")]
		public static void EntitlementResult(Message msg)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xA354A0", Offset = "0xA354A0", VA = "0xA354A0")]
		public static float[] displayFrequenciesAvailable()
		{
			return null;
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xA4A0D4", Offset = "0xA4A0D4", VA = "0xA4A0D4")]
		public static bool isOculusGo()
		{
			return default(bool);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xA4A0DC", Offset = "0xA4A0DC", VA = "0xA4A0DC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xA4A278", Offset = "0xA4A278", VA = "0xA4A278")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xA49B7C", Offset = "0xA49B7C", VA = "0xA49B7C")]
		private static bool standard_Button(Button button, int check)
		{
			return default(bool);
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xA4A2D4", Offset = "0xA4A2D4", VA = "0xA4A2D4")]
		public static bool IsLastUsedControllerLeft()
		{
			return default(bool);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xA4A33C", Offset = "0xA4A33C", VA = "0xA4A33C")]
		public static bool IsAvailable(TrackedPosition which)
		{
			return default(bool);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xA4A3E8", Offset = "0xA4A3E8", VA = "0xA4A3E8")]
		public static Vector3 GetTrackedPosition(TrackedPosition which)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xA4A7D8", Offset = "0xA4A7D8", VA = "0xA4A7D8")]
		public static Ray GetTrackedMainCursorRay()
		{
			return default(Ray);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xA4AADC", Offset = "0xA4AADC", VA = "0xA4AADC")]
		private void blockMainAndTrigger()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xA4AC20", Offset = "0xA4AC20", VA = "0xA4AC20")]
		private void Update()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xA4AF18", Offset = "0xA4AF18", VA = "0xA4AF18")]
		private static OVRInput.Controller oculus_getCurControl()
		{
			return default(OVRInput.Controller);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xA49908", Offset = "0xA49908", VA = "0xA49908")]
		private static bool input_Button(Button button, int check)
		{
			return default(bool);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xA49794", Offset = "0xA49794", VA = "0xA49794")]
		private static Vector2 input_Axis2D(Axis2D axis)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xA4AFDC", Offset = "0xA4AFDC", VA = "0xA4AFDC")]
		public VRInput()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class VRInteractable : MonoBehaviour
	{
		[Token(Token = "0x2000200")]
		public class Event
		{
			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool captureEvent;

			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0xA3F8BC", Offset = "0xA3F8BC", VA = "0xA3F8BC")]
			public Event()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000201")]
		public class ButtonClickEvent : UnityEvent
		{
			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0xA4B1C0", Offset = "0xA4B1C0", VA = "0xA4B1C0")]
			public ButtonClickEvent()
			{
			}
		}

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Disabled;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IgnoreGaze;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float GazeAngleLimit;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float GazeDelayMul;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ButtonClickEvent ButtonClick;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<VRInteractable> AllEnabled;

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xA4B0BC", Offset = "0xA4B0BC", VA = "0xA4B0BC", Slot = "4")]
		public virtual void OnVRDrag()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xA4B0C0", Offset = "0xA4B0C0", VA = "0xA4B0C0", Slot = "5")]
		public virtual void OnButtonDown(Event e)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xA4B0C4", Offset = "0xA4B0C4", VA = "0xA4B0C4", Slot = "6")]
		public virtual void OnButtonCancel()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xA46618", Offset = "0xA46618", VA = "0xA46618", Slot = "7")]
		public virtual void OnButtonUp()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xA46550", Offset = "0xA46550", VA = "0xA46550", Slot = "8")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xA4B0C8", Offset = "0xA4B0C8", VA = "0xA4B0C8", Slot = "9")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xA466F0", Offset = "0xA466F0", VA = "0xA466F0")]
		public VRInteractable()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class VRResetViewAfterHMDSleep : MonoBehaviour
	{
		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject CameraIdealPosition;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject CameraCalibration;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool CalibrateNow;

		[Token(Token = "0x14000001")]
		public static event Action HeadsetWokeup
		{
			[Token(Token = "0x6000713")]
			[Address(RVA = "0xA4B1C8", Offset = "0xA4B1C8", VA = "0xA4B1C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B578", Offset = "0x77B578")]
			add
			{
			}
			[Token(Token = "0x6000714")]
			[Address(RVA = "0xA4B2B4", Offset = "0xA4B2B4", VA = "0xA4B2B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77B588", Offset = "0x77B588")]
			remove
			{
			}
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xA4B3A0", Offset = "0xA4B3A0", VA = "0xA4B3A0")]
		public static void Calibrate()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xA4B450", Offset = "0xA4B450", VA = "0xA4B450")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xA4B544", Offset = "0xA4B544", VA = "0xA4B544")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xA4B638", Offset = "0xA4B638", VA = "0xA4B638")]
		private void HeadsetWokeupCallback()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xA4B6E0", Offset = "0xA4B6E0", VA = "0xA4B6E0")]
		private void ResetView()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xA4B790", Offset = "0xA4B790", VA = "0xA4B790")]
		public VRResetViewAfterHMDSleep()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class DelayedActionQueue
	{
		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int MaxNumberOfRecursions;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<DelayedAction> _curList;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<DelayedAction> _nextList;

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xA35F00", Offset = "0xA35F00", VA = "0xA35F00")]
		public void AddRequestInternal(DelayedAction item)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xA35F78", Offset = "0xA35F78", VA = "0xA35F78")]
		public void ProcessQueue()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xA360F0", Offset = "0xA360F0", VA = "0xA360F0")]
		public DelayedActionQueue()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class DelayedAction
	{
		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DelayedActionQueue _owner;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action callback;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool scheduled;

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xA35EA8", Offset = "0xA35EA8", VA = "0xA35EA8")]
		public void Init(DelayedActionQueue owner)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xA35EB0", Offset = "0xA35EB0", VA = "0xA35EB0")]
		public void Init(DelayedActionQueue owner, Action _callback)
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xA35EB8", Offset = "0xA35EB8", VA = "0xA35EB8")]
		public void Request(Action action)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xA35EC0", Offset = "0xA35EC0", VA = "0xA35EC0")]
		public void Request()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xA35F68", Offset = "0xA35F68", VA = "0xA35F68")]
		public void Cancel()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xA35F70", Offset = "0xA35F70", VA = "0xA35F70")]
		public DelayedAction()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class ResourceManager : IResources
	{
		[Token(Token = "0x2000202")]
		public class ResourceInfo
		{
			[Token(Token = "0x4000A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long LastModified;

			[Token(Token = "0x6000AED")]
			[Address(RVA = "0xA3A26C", Offset = "0xA3A26C", VA = "0xA3A26C")]
			public ResourceInfo()
			{
			}
		}

		[Token(Token = "0x2000203")]
		public interface IRuntimeResource
		{
			[Token(Token = "0x6000AEE")]
			void UpdateResourceFromBinarySource(string relative_path);

			[Token(Token = "0x6000AEF")]
			void PushResource<T>(T newVersion);

			[Token(Token = "0x6000AF0")]
			T GetResource<T>();

			[Token(Token = "0x6000AF1")]
			object GetResource();

			[Token(Token = "0x6000AF2")]
			IDisposableHook SyncFile<T>(Action<T> onUpdated) where T : class;

			[Token(Token = "0x6000AF3")]
			void RefCount(int delta);
		}

		[Token(Token = "0x2000204")]
		public enum SourceType
		{
			[Token(Token = "0x4000A69")]
			Binary,
			[Token(Token = "0x4000A6A")]
			String,
			[Token(Token = "0x4000A6B")]
			Stream
		}

		[Token(Token = "0x2000205")]
		public class RuntimeResource<T> : IRuntimeResource where T : class
		{
			[Token(Token = "0x200024D")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7791FC", Offset = "0x7791FC")]
			private sealed class <>c__DisplayClass7_0<T2> where T2 : class
			{
				[Token(Token = "0x4000BF8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public Action<T2> onUpdated;

				[Token(Token = "0x6000C4A")]
				public <>c__DisplayClass7_0()
				{
				}

				[Token(Token = "0x6000C4B")]
				internal void <SyncFile>b__0(T x)
				{
				}
			}

			[Token(Token = "0x4000A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string RelativePath;

			[Token(Token = "0x4000A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public object Resource;

			[Token(Token = "0x4000A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ReactiveListeners<T> _listeners;

			[Token(Token = "0x4000A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private List<IDisposableHook> _dependencies;

			[Token(Token = "0x4000A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ResourceManager Owner;

			[Token(Token = "0x4000A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _refCount;

			[Token(Token = "0x6000AF4")]
			public T2 GetResource<T2>()
			{
				return (T2)null;
			}

			[Token(Token = "0x6000AF5")]
			public object GetResource()
			{
				return null;
			}

			[Token(Token = "0x6000AF6")]
			public void AddDependency(IDisposableHook dep)
			{
			}

			[Token(Token = "0x6000AF7")]
			public IDisposableHook SyncFile<T2>(Action<T2> onUpdated) where T2 : class
			{
				return null;
			}

			[Token(Token = "0x6000AF8")]
			private void OnListenerDisposed(bool _unused)
			{
			}

			[Token(Token = "0x6000AF9")]
			public virtual SourceType GetSourceType()
			{
				return default(SourceType);
			}

			[Token(Token = "0x6000AFA")]
			public virtual T LoadResource(byte[] file)
			{
				return null;
			}

			[Token(Token = "0x6000AFB")]
			public virtual T LoadResource(string file)
			{
				return null;
			}

			[Token(Token = "0x6000AFC")]
			public virtual T LoadResource(Stream file)
			{
				return null;
			}

			[Token(Token = "0x6000AFD")]
			public virtual void OnCleanup()
			{
			}

			[Token(Token = "0x6000AFE")]
			public void UpdateResourceFromBinarySource(string _relativePath)
			{
			}

			[Token(Token = "0x6000AFF")]
			public void PushResource<T2>(T2 newVersion)
			{
			}

			[Token(Token = "0x6000B00")]
			public void CleanupDependencies()
			{
			}

			[Token(Token = "0x6000B01")]
			public void RefCount(int delta)
			{
			}

			[Token(Token = "0x6000B02")]
			public RuntimeResource()
			{
			}
		}

		[Token(Token = "0x2000206")]
		private class RawResource
		{
			[Token(Token = "0x4000A72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public byte[] data;

			[Token(Token = "0x6000B03")]
			[Address(RVA = "0xA3A274", Offset = "0xA3A274", VA = "0xA3A274")]
			public RawResource()
			{
			}
		}

		[Token(Token = "0x2000207")]
		private class RuntimeResourceRaw : RuntimeResource<RawResource>
		{
			[Token(Token = "0x6000B04")]
			[Address(RVA = "0xA3A27C", Offset = "0xA3A27C", VA = "0xA3A27C", Slot = "11")]
			public override RawResource LoadResource(byte[] file)
			{
				return null;
			}

			[Token(Token = "0x6000B05")]
			[Address(RVA = "0xA3A2E8", Offset = "0xA3A2E8", VA = "0xA3A2E8")]
			public RuntimeResourceRaw()
			{
			}
		}

		[Token(Token = "0x2000208")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778FBC", Offset = "0x778FBC")]
		private sealed class <>c__DisplayClass5_0<T>
		{
			[Token(Token = "0x4000A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ResourceManager <>4__this;

			[Token(Token = "0x4000A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<string, T, IDisposableHook> doForeachItem;

			[Token(Token = "0x6000B06")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000B07")]
			internal void <SubscribeToAllItemsWithFileExtension>b__0(bool isCreate, string relpath, ResourceInfo info)
			{
			}

			[Token(Token = "0x6000B08")]
			internal IDisposableHook <SubscribeToAllItemsWithFileExtension>b__1(string relPath, ResourceInfo info)
			{
				return null;
			}
		}

		[Token(Token = "0x2000209")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778FCC", Offset = "0x778FCC")]
		private sealed class <>c__DisplayClass5_1<T>
		{
			[Token(Token = "0x4000A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T obj;

			[Token(Token = "0x6000B09")]
			public <>c__DisplayClass5_1()
			{
			}

			[Token(Token = "0x6000B0A")]
			internal void <SubscribeToAllItemsWithFileExtension>b__2(IRuntimeResource rtr)
			{
			}
		}

		[Token(Token = "0x200020A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778FDC", Offset = "0x778FDC")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Func<string, string> transformFunc;

			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0xA38C80", Offset = "0xA38C80", VA = "0xA38C80")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0xA39D04", Offset = "0xA39D04", VA = "0xA39D04")]
			internal byte[] <AtomicResourceWrite>b__0(byte[] bytes)
			{
				return null;
			}
		}

		[Token(Token = "0x200020B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778FEC", Offset = "0x778FEC")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000A77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object resource;

			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0xA38F08", Offset = "0xA38F08", VA = "0xA38F08")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0xA39DC0", Offset = "0xA39DC0", VA = "0xA39DC0")]
			internal void <SaveResource>b__0(IRuntimeResource rtr)
			{
			}
		}

		[Token(Token = "0x200020C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x778FFC", Offset = "0x778FFC")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object resource;

			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0xA39240", Offset = "0xA39240", VA = "0xA39240")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000B10")]
			[Address(RVA = "0xA39E98", Offset = "0xA39E98", VA = "0xA39E98")]
			internal void <SaveResource>b__0(IRuntimeResource rtr)
			{
			}
		}

		[Token(Token = "0x200020D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77900C", Offset = "0x77900C")]
		private sealed class <>c__DisplayClass23_0<T> where T : class
		{
			[Token(Token = "0x4000A79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T newVersion;

			[Token(Token = "0x6000B11")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000B12")]
			internal void <PushVirtualResource>b__0(IRuntimeResource rtr)
			{
			}
		}

		[Token(Token = "0x200020E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77901C", Offset = "0x77901C")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x4000A7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string relativePath;

			[Token(Token = "0x4000A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<long> onDateUpdated;

			[Token(Token = "0x6000B13")]
			[Address(RVA = "0xA395B8", Offset = "0xA395B8", VA = "0xA395B8")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000B14")]
			[Address(RVA = "0xA39F70", Offset = "0xA39F70", VA = "0xA39F70")]
			internal void <SyncModifiedDate>b__0(bool added, string relPath, ResourceInfo info)
			{
			}
		}

		[Token(Token = "0x200020F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77902C", Offset = "0x77902C")]
		private sealed class <>c__DisplayClass25_0<T> where T : class
		{
			[Token(Token = "0x4000A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IDisposableHook ret;

			[Token(Token = "0x4000A7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> func;

			[Token(Token = "0x6000B15")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000B16")]
			internal void <SyncFile>b__0(IRuntimeResource rtr)
			{
			}
		}

		[Token(Token = "0x2000210")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77903C", Offset = "0x77903C")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000A7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string root;

			[Token(Token = "0x4000A7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ResourceManager <>4__this;

			[Token(Token = "0x4000A80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool databaseChanged;

			[Token(Token = "0x6000B17")]
			[Address(RVA = "0xA395C0", Offset = "0xA395C0", VA = "0xA395C0")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000B18")]
			[Address(RVA = "0xA3A004", Offset = "0xA3A004", VA = "0xA3A004")]
			internal void <Scan>b__0(string path, FileInfo info)
			{
			}
		}

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string ProjectDirectory;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, SyncableDictionary<string, ResourceInfo>> _byExtension;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IDisposableHook _extensionProcessing;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SyncableDictionary<string, ResourceInfo> ResourceDB;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, IRuntimeResource> ResourceDBReferenced;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<string> _scanned;

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xA37E0C", Offset = "0xA37E0C", VA = "0xA37E0C")]
		public string GetDir()
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xA37E84", Offset = "0xA37E84", VA = "0xA37E84", Slot = "1")]
		~ResourceManager()
		{
		}

		[Token(Token = "0x6000727")]
		public IDisposableHook SubscribeToAllItemsWithFileExtension<T>(string fileExtension, Func<string, T, IDisposableHook> doForeachItem)
		{
			return null;
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xA37FB8", Offset = "0xA37FB8", VA = "0xA37FB8")]
		private IRuntimeResource GetRuntimeResource(string relativePath, bool doHardCheckForNewFiles)
		{
			return null;
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xA38BA8", Offset = "0xA38BA8", VA = "0xA38BA8")]
		public void UpdateSyncedResource(string relativePath, byte[] binData, string stringData)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xA38BAC", Offset = "0xA38BAC", VA = "0xA38BAC", Slot = "11")]
		public void AtomicResourceWrite(string relativePath, Func<string, string> transformFunc)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xA38C88", Offset = "0xA38C88", VA = "0xA38C88", Slot = "10")]
		public void AtomicResourceWrite(string relativePath, Func<byte[], byte[]> transformFunc)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xA38E00", Offset = "0xA38E00", VA = "0xA38E00", Slot = "8")]
		public void SaveResource(string relativePath, string contents, [Optional] object resource)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xA39138", Offset = "0xA39138", VA = "0xA39138", Slot = "9")]
		public void SaveResource(string relativePath, byte[] contents, [Optional] object resource)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xA38CB8", Offset = "0xA38CB8", VA = "0xA38CB8")]
		public void LL_AtomicResourceWrite(string relativePath, Func<byte[], byte[]> transformFunc, out byte[] outData)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xA3883C", Offset = "0xA3883C", VA = "0xA3883C")]
		public bool LL_Exists(string relativePath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xA39280", Offset = "0xA39280", VA = "0xA39280")]
		public string LL_LoadTextResource(string relativePath)
		{
			return null;
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xA392B0", Offset = "0xA392B0", VA = "0xA392B0")]
		public byte[] LL_LoadResource(string relativePath)
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xA38F10", Offset = "0xA38F10", VA = "0xA38F10")]
		public void LL_SaveResource(string relativePath, string contents)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xA39248", Offset = "0xA39248", VA = "0xA39248")]
		public void LL_SaveResource(string relativePath, byte[] contents)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xA38F48", Offset = "0xA38F48", VA = "0xA38F48")]
		public bool RunTimeResourceAction(string relativePath, Action<IRuntimeResource> func, [Optional] Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000735")]
		public void PushVirtualResource<T>(string relativePath, T newVersion) where T : class
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xA394F0", Offset = "0xA394F0", VA = "0xA394F0", Slot = "4")]
		public IDisposableHook SyncModifiedDate(string relativePath, Action<long> onDateUpdated)
		{
			return null;
		}

		[Token(Token = "0x6000737")]
		public IDisposableHook SyncFile<T>(string relativePath, Action<T> func) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xA3886C", Offset = "0xA3886C", VA = "0xA3886C")]
		public bool Scan()
		{
			return default(bool);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xA39C38", Offset = "0xA39C38", VA = "0xA39C38")]
		public string GetResourceDBPath()
		{
			return null;
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xA392E0", Offset = "0xA392E0", VA = "0xA392E0")]
		private void ValidateResourceDB()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xA39C90", Offset = "0xA39C90", VA = "0xA39C90")]
		private void TestPsd()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xA395C8", Offset = "0xA395C8", VA = "0xA395C8")]
		public static void ProcessDirectory(string targetDirectory, Action<string, FileInfo> ProcessFile)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xA39C94", Offset = "0xA39C94", VA = "0xA39C94")]
		public ResourceManager()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class ResourceManagerInstance : MonoBehaviour
	{
		[Token(Token = "0x2000211")]
		private class ScriptLine
		{
			[Token(Token = "0x4000A81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string CodeText;

			[Token(Token = "0x6000B19")]
			[Address(RVA = "0xA3AA0C", Offset = "0xA3AA0C", VA = "0xA3AA0C")]
			public ScriptLine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000212")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77904C", Offset = "0x77904C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000A83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, bool> <>9__6_0;

			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0xA3A994", Offset = "0xA3A994", VA = "0xA3A994")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0xA3A99C", Offset = "0xA3A99C", VA = "0xA3A99C")]
			internal bool <ScriptNewOrChanged>b__6_0(string x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ResourceManager Global;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ResourceManager _resources;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProjectDirectory;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ScanNow;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<ScriptLine> Lines;

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xA3A338", Offset = "0xA3A338", VA = "0xA3A338")]
		public static bool IsEmptyOrWhiteSpace(string value)
		{
			return default(bool);
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xA3A3C0", Offset = "0xA3A3C0", VA = "0xA3A3C0")]
		public ResourceManager GetResourceManager()
		{
			return null;
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xA3A524", Offset = "0xA3A524", VA = "0xA3A524")]
		private IDisposableHook ScriptNewOrChanged(string path, TextResource data)
		{
			return null;
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xA3A6B0", Offset = "0xA3A6B0", VA = "0xA3A6B0")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xA3A6C0", Offset = "0xA3A6C0", VA = "0xA3A6C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xA3A6F0", Offset = "0xA3A6F0", VA = "0xA3A6F0")]
		private void a_plus_b(float a, float a_old, bool a_changed, float b, float b_old, bool b_changed, float r, float r_old, bool r_changed)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xA3A6F4", Offset = "0xA3A6F4", VA = "0xA3A6F4")]
		private void ScriptUpdated(TextResource newScript)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xA3A8BC", Offset = "0xA3A8BC", VA = "0xA3A8BC")]
		public ResourceManagerInstance()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public static class ResourceTypes
	{
		[Token(Token = "0x2000213")]
		public enum Category
		{
			[Token(Token = "0x4000A85")]
			Ignored,
			[Token(Token = "0x4000A86")]
			Texture,
			[Token(Token = "0x4000A87")]
			Mesh,
			[Token(Token = "0x4000A88")]
			Prefab,
			[Token(Token = "0x4000A89")]
			Animation,
			[Token(Token = "0x4000A8A")]
			Material,
			[Token(Token = "0x4000A8B")]
			Scene_,
			[Token(Token = "0x4000A8C")]
			Sound,
			[Token(Token = "0x4000A8D")]
			Script,
			[Token(Token = "0x4000A8E")]
			DepthStreamAnimation
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xA3AA14", Offset = "0xA3AA14", VA = "0xA3AA14")]
		public static string CategoryToExt(Category cat)
		{
			return null;
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xA381F4", Offset = "0xA381F4", VA = "0xA381F4")]
		public static Category GetFileCategoryFromExtension(string path)
		{
			return default(Category);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xA38658", Offset = "0xA38658", VA = "0xA38658")]
		public static ResourceManager.IRuntimeResource Create(ResourceManager owner, Category cat)
		{
			return null;
		}
	}
	[Token(Token = "0x2000100")]
	public class MeshResource : ResourceManager.RuntimeResource<MeshResource>
	{
		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Dictionary<string, KeyValuePair<string[], Mesh>> Meshes;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MeshArray meshItem;

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xA378A8", Offset = "0xA378A8", VA = "0xA378A8", Slot = "11")]
		public override MeshResource LoadResource(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xA37A5C", Offset = "0xA37A5C", VA = "0xA37A5C")]
		public Mesh GetUnityMesh()
		{
			return null;
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xA37AA4", Offset = "0xA37AA4", VA = "0xA37AA4")]
		public MeshArray GetMeshItem()
		{
			return null;
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xA37C5C", Offset = "0xA37C5C", VA = "0xA37C5C")]
		public SpGCache.Job GetMeshItemJob()
		{
			return null;
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xA37CE4", Offset = "0xA37CE4", VA = "0xA37CE4")]
		public MeshResource()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class TextureResource : ResourceManager.RuntimeResource<TextureResource>
	{
		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D Texture;

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xA3FF50", Offset = "0xA3FF50", VA = "0xA3FF50", Slot = "11")]
		public override TextureResource LoadResource(byte[] file)
		{
			return null;
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xA3AAB0", Offset = "0xA3AAB0", VA = "0xA3AAB0")]
		public TextureResource()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class AnimationResource : ResourceManager.RuntimeResource<AnimationResource>
	{
		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationClip AnimClip;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationClipData AnimClipData;

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xA35860", Offset = "0xA35860", VA = "0xA35860", Slot = "11")]
		public override AnimationResource LoadResource(byte[] file)
		{
			return null;
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xA358AC", Offset = "0xA358AC", VA = "0xA358AC")]
		public AnimationResource()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class MaterialResource : ResourceManager.RuntimeResource<MaterialResource>
	{
		[Token(Token = "0x2000214")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77905C", Offset = "0x77905C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000A8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MaterialResource <>4__this;

			[Token(Token = "0x4000A90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public KeyValueStore matData;

			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0xA373BC", Offset = "0xA373BC", VA = "0xA373BC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0xA37414", Offset = "0xA37414", VA = "0xA37414")]
			internal void <LoadResource>b__0(string name, float val)
			{
			}

			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0xA3743C", Offset = "0xA3743C", VA = "0xA3743C")]
			internal void <LoadResource>b__1(string name, string val, string meta)
			{
			}
		}

		[Token(Token = "0x2000215")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77906C", Offset = "0x77906C")]
		private sealed class <>c__DisplayClass2_1
		{
			[Token(Token = "0x4000A91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000A92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass2_0 CS$<>8__locals1;

			[Token(Token = "0x6000B20")]
			[Address(RVA = "0xA37770", Offset = "0xA37770", VA = "0xA37770")]
			public <>c__DisplayClass2_1()
			{
			}

			[Token(Token = "0x6000B21")]
			[Address(RVA = "0xA37778", Offset = "0xA37778", VA = "0xA37778")]
			internal void <LoadResource>b__2(TextureResource tex)
			{
			}
		}

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Material Mat;

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xA36E50", Offset = "0xA36E50", VA = "0xA36E50")]
		public static byte[] Save(Material m, Func<Texture, string> textureToString)
		{
			return null;
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xA37088", Offset = "0xA37088", VA = "0xA37088", Slot = "11")]
		public override MaterialResource LoadResource(byte[] file)
		{
			return null;
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xA373C4", Offset = "0xA373C4", VA = "0xA373C4")]
		public MaterialResource()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class PrefabResource : ResourceManager.RuntimeResource<PrefabResource>
	{
		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SoftPrefab Prefab;

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xA37D34", Offset = "0xA37D34", VA = "0xA37D34", Slot = "11")]
		public override PrefabResource LoadResource(byte[] file)
		{
			return null;
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xA37DBC", Offset = "0xA37DBC", VA = "0xA37DBC")]
		public PrefabResource()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class SoundResource : ResourceManager.RuntimeResource<SoundResource>
	{
		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip Audio;

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xA3D7F4", Offset = "0xA3D7F4", VA = "0xA3D7F4", Slot = "11")]
		public override SoundResource LoadResource(byte[] file)
		{
			return null;
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xA3AB00", Offset = "0xA3AB00", VA = "0xA3AB00")]
		public SoundResource()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class TextResource : ResourceManager.RuntimeResource<TextResource>
	{
		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string[] Lines;

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xA3FEA8", Offset = "0xA3FEA8", VA = "0xA3FEA8", Slot = "10")]
		public override ResourceManager.SourceType GetSourceType()
		{
			return default(ResourceManager.SourceType);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xA3FEB0", Offset = "0xA3FEB0", VA = "0xA3FEB0", Slot = "12")]
		public override TextResource LoadResource(string file)
		{
			return null;
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xA3AB50", Offset = "0xA3AB50", VA = "0xA3AB50")]
		public TextResource()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class DepthStreamAnimationResource : ResourceManager.RuntimeResource<DepthStreamAnimationResource>
	{
		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CompressedDepthStream Data;

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xA36188", Offset = "0xA36188", VA = "0xA36188", Slot = "11")]
		public override DepthStreamAnimationResource LoadResource(byte[] file)
		{
			return null;
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xA362F0", Offset = "0xA362F0", VA = "0xA362F0")]
		public DepthStreamAnimationResource()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class MeshArray
	{
		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh[] UnityMeshes;

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xA377BC", Offset = "0xA377BC", VA = "0xA377BC")]
		public MeshArray(Mesh[] unityMeshes)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xA377E8", Offset = "0xA377E8", VA = "0xA377E8")]
		public MeshArray(Mesh mesh)
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xA378A0", Offset = "0xA378A0", VA = "0xA378A0")]
		public MeshArray()
		{
		}
	}
}
namespace SpacePlunge.Utils
{
	[Token(Token = "0x2000109")]
	public class PositionSmoother
	{
		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int N;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3[] cur;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float timeExp;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float minSpeed;

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xA41018", Offset = "0xA41018", VA = "0xA41018")]
		public void setTime(float time, float minspeed = 0.004f)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xA41020", Offset = "0xA41020", VA = "0xA41020")]
		public PositionSmoother(int _N = 2)
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xA410A0", Offset = "0xA410A0", VA = "0xA410A0")]
		public PositionSmoother(float time, float minspeed = 0.004f, int _N = 2)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xA41128", Offset = "0xA41128", VA = "0xA41128")]
		public Vector3 smoothWithoutInput(float dt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xA4173C", Offset = "0xA4173C", VA = "0xA4173C")]
		public Vector3 smoothWithoutInput(float dt, float time, float minspeed = 0.72f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xA4177C", Offset = "0xA4177C", VA = "0xA4177C")]
		public Vector3 smooth(Vector3 x, float dt, float time, float minspeed = 0.004f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xA41164", Offset = "0xA41164", VA = "0xA41164")]
		public Vector3 smooth(Vector3 x, float dt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xA418F4", Offset = "0xA418F4", VA = "0xA418F4")]
		public void reset(Vector3 x)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xA4195C", Offset = "0xA4195C", VA = "0xA4195C")]
		public bool isSmoothComplete()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010A")]
	public class RotationSmoother
	{
		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int N;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Quaternion[] cur;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float timeExp;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float minSpeed;

		[Token(Token = "0x1700002B")]
		public Quaternion last
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0xA41A7C", Offset = "0xA41A7C", VA = "0xA41A7C")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xA41AC8", Offset = "0xA41AC8", VA = "0xA41AC8")]
		public void setTime(float time, float minspeed = 0.72f)
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xA41AD0", Offset = "0xA41AD0", VA = "0xA41AD0")]
		public RotationSmoother(int _N = 2)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xA41BE8", Offset = "0xA41BE8", VA = "0xA41BE8")]
		public RotationSmoother(float time, float minspeed = 0.72f, int _N = 2)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xA41CA0", Offset = "0xA41CA0", VA = "0xA41CA0")]
		public Quaternion smoothWithoutInput(float dt)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xA41F30", Offset = "0xA41F30", VA = "0xA41F30")]
		public Quaternion smoothWithoutInput(float dt, float time, float minspeed = 0.72f)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xA41F70", Offset = "0xA41F70", VA = "0xA41F70")]
		public Quaternion smooth(Quaternion x, float dt, float time, float minspeed = 0.72f)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xA41CDC", Offset = "0xA41CDC", VA = "0xA41CDC")]
		public Quaternion smooth(Quaternion x, float dt)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xA41B80", Offset = "0xA41B80", VA = "0xA41B80")]
		public void reset(Quaternion x)
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class ValueSmoother
	{
		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int N;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] cur;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float timeLin;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float timeExp;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float minSpeed;

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xA45898", Offset = "0xA45898", VA = "0xA45898")]
		public void setTime(float time, float smoothness = 1f, float minspeed = 0.004f)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xA458C0", Offset = "0xA458C0", VA = "0xA458C0")]
		public ValueSmoother(float time = 0.5f, float smoothness = 1f, float minspeed = 0.004f, int _N = 2)
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xA45974", Offset = "0xA45974", VA = "0xA45974")]
		public float smoothWithoutInput(float dt)
		{
			return default(float);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xA45D5C", Offset = "0xA45D5C", VA = "0xA45D5C")]
		public float smoothWithoutInput(float dt, float time, float minspeed = 0.72f)
		{
			return default(float);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xA45DC4", Offset = "0xA45DC4", VA = "0xA45DC4")]
		public float smooth(float x, float dt, float time, float smoothness = 1f, float minspeed = 0.004f)
		{
			return default(float);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xA459AC", Offset = "0xA459AC", VA = "0xA459AC")]
		public float smooth(float x, float dt)
		{
			return default(float);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xA45DEC", Offset = "0xA45DEC", VA = "0xA45DEC")]
		public float getLastValue()
		{
			return default(float);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xA45E2C", Offset = "0xA45E2C", VA = "0xA45E2C")]
		public void reset(float x)
		{
		}
	}
	[Token(Token = "0x200010C")]
	public static class UnityUtils
	{
		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, Shader> _shaderCache;

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xA421F0", Offset = "0xA421F0", VA = "0xA421F0")]
		private static string str(float f)
		{
			return null;
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xA42268", Offset = "0xA42268", VA = "0xA42268")]
		public static string ToStr(this float f)
		{
			return null;
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xA422D4", Offset = "0xA422D4", VA = "0xA422D4")]
		public static string ToStr(this Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xA4236C", Offset = "0xA4236C", VA = "0xA4236C")]
		public static string ToStr(this Vector3 v)
		{
			return null;
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xA42528", Offset = "0xA42528", VA = "0xA42528")]
		public static string ToStr(this Vector4 v)
		{
			return null;
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xA42748", Offset = "0xA42748", VA = "0xA42748")]
		public static string ToStr(this Quaternion v)
		{
			return null;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xA42968", Offset = "0xA42968", VA = "0xA42968")]
		public static string ToStr(this Color v)
		{
			return null;
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xA42B88", Offset = "0xA42B88", VA = "0xA42B88")]
		public static void DestroyCorrectly(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000784")]
		public static void DestroyCorrectly<T>(ref T obj) where T : UnityEngine.Object
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xA42BF0", Offset = "0xA42BF0", VA = "0xA42BF0")]
		public static uint IntHash(uint a)
		{
			return default(uint);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xA42C54", Offset = "0xA42C54", VA = "0xA42C54")]
		public static float FloatHash(int x)
		{
			return default(float);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xA42D2C", Offset = "0xA42D2C", VA = "0xA42D2C")]
		public static float HashNoise(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xA42DCC", Offset = "0xA42DCC", VA = "0xA42DCC")]
		public static float HashNoiseLinear(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xA42E90", Offset = "0xA42E90", VA = "0xA42E90")]
		public static float HashNoiseCubic(float x)
		{
			return default(float);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xA42FC4", Offset = "0xA42FC4", VA = "0xA42FC4")]
		public static float CubicInterpolate(float m1, float p0, float p1, float p2, float t)
		{
			return default(float);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xA43024", Offset = "0xA43024", VA = "0xA43024")]
		public static float MapRange(float x, float sourceStart, float sourceEnd, float dstStart, float dstEnd)
		{
			return default(float);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xA43178", Offset = "0xA43178", VA = "0xA43178")]
		public static float MapRangeSmooth(float x, float sourceStart, float sourceEnd, float dstStart, float dstEnd)
		{
			return default(float);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xA432B0", Offset = "0xA432B0", VA = "0xA432B0")]
		public static float MapRangeSmoother(float x, float sourceStart, float sourceEnd, float dstStart, float dstEnd)
		{
			return default(float);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xA4326C", Offset = "0xA4326C", VA = "0xA4326C")]
		public static float Smoothstep(float a, float b, float x)
		{
			return default(float);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xA43410", Offset = "0xA43410", VA = "0xA43410")]
		public static float Smoothstepc(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xA43428", Offset = "0xA43428", VA = "0xA43428")]
		public static float Smoothstepc_inv(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xA434EC", Offset = "0xA434EC", VA = "0xA434EC")]
		public static float Smoothstepc_bi(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xA43508", Offset = "0xA43508", VA = "0xA43508")]
		public static float Smoothstepc_easeIn(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xA433B8", Offset = "0xA433B8", VA = "0xA433B8")]
		public static float Smootherstep(float a, float b, float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xA43524", Offset = "0xA43524", VA = "0xA43524")]
		public static float Smootherstepc(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xA43550", Offset = "0xA43550", VA = "0xA43550")]
		public static float Smootherstepc_easeIn(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xA430F0", Offset = "0xA430F0", VA = "0xA430F0")]
		public static float Linstep(float a, float b, float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xA43584", Offset = "0xA43584", VA = "0xA43584")]
		public static float Calc6dbFilterConstFor12dbFilter(float time, float dt)
		{
			return default(float);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xA43608", Offset = "0xA43608", VA = "0xA43608")]
		public static float Filter12db(float target, float time, float dt, ref float cur, ref float vel)
		{
			return default(float);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xA436E4", Offset = "0xA436E4", VA = "0xA436E4")]
		public static Vector3 Filter12db(Vector3 target, float time, float dt, ref Vector3 cur, ref Vector3 vel)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xA438DC", Offset = "0xA438DC", VA = "0xA438DC")]
		public static float StepTowards(float x, float target, float linearSpeed, float expSpeed, float dt)
		{
			return default(float);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xA43A1C", Offset = "0xA43A1C", VA = "0xA43A1C")]
		public static float StepTowardsLin(float x, float target, float speed, float dt)
		{
			return default(float);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xA41784", Offset = "0xA41784", VA = "0xA41784")]
		public static Vector3 StepTowardsLin(Vector3 x, Vector3 target, float speed, float dt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xA43B04", Offset = "0xA43B04", VA = "0xA43B04")]
		public static Quaternion StepTowardsLin(Quaternion x, Quaternion target, float speed, float dt)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xA43C74", Offset = "0xA43C74", VA = "0xA43C74")]
		public static float ReversedMul(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xA43C8C", Offset = "0xA43C8C", VA = "0xA43C8C")]
		public static void KeywordEnable(Material m, string keyword, bool enable)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xA43D64", Offset = "0xA43D64", VA = "0xA43D64")]
		public static float Curve(float x, float a)
		{
			return default(float);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xA43D88", Offset = "0xA43D88", VA = "0xA43D88")]
		public static float CurveSigned(float x, float a)
		{
			return default(float);
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xA43DB8", Offset = "0xA43DB8", VA = "0xA43DB8")]
		public static float CurveFit3(float x, float y0, float y0_5, float y1)
		{
			return default(float);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xA43E90", Offset = "0xA43E90", VA = "0xA43E90")]
		public static float CurveFit3i(float x, float y0, float y0_5, float y1)
		{
			return default(float);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xA43F44", Offset = "0xA43F44", VA = "0xA43F44")]
		public static float CurveAmount(float x, float amount)
		{
			return default(float);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xA43F68", Offset = "0xA43F68", VA = "0xA43F68")]
		public static Vector3 ToNormalizedSpherical(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xA44058", Offset = "0xA44058", VA = "0xA44058")]
		public static Vector3 FromNormalizedSpherical(Vector3 magnitude_leftright_updown)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xA44150", Offset = "0xA44150", VA = "0xA44150")]
		public static float SubstractCircular(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xA441EC", Offset = "0xA441EC", VA = "0xA441EC")]
		public static bool IsPointInTriangle(Vector2 p, Vector2 p0, Vector2 p1, Vector2 p2)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xA442B0", Offset = "0xA442B0", VA = "0xA442B0")]
		public static float DistanceToLine(Ray ray, Vector3 point)
		{
			return default(float);
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xA443D0", Offset = "0xA443D0", VA = "0xA443D0")]
		public static Vector3 ClosestPointOnRay(Ray ray, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xA44528", Offset = "0xA44528", VA = "0xA44528")]
		public static bool RaySphereIntersect(Vector3 ro, Vector3 rd, Vector3 sphereCenter, float sphereRadius, out Vector3 intersection)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xA44990", Offset = "0xA44990", VA = "0xA44990")]
		public static float Square(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xA44998", Offset = "0xA44998", VA = "0xA44998")]
		public static float Cube(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xA449A4", Offset = "0xA449A4", VA = "0xA449A4")]
		public static float SoftSelect(float x, float falloff, bool shapeS, bool softDec, bool extrasmooth)
		{
			return default(float);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xA44784", Offset = "0xA44784", VA = "0xA44784")]
		public static Vector3 GetClosestPointOnLine(Vector3 A, Vector3 B, Vector3 P, bool lineSegment = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xA44D64", Offset = "0xA44D64", VA = "0xA44D64")]
		public static Texture2D LoadImageToTexture(string filePath)
		{
			return null;
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xA44E04", Offset = "0xA44E04", VA = "0xA44E04")]
		public static byte[] GetBytes(object str)
		{
			return null;
		}

		[Token(Token = "0x60007B2")]
		public static void FromBytes<T>(byte[] arr, out T ret)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xA44EE4", Offset = "0xA44EE4", VA = "0xA44EE4")]
		public static Texture2D CopyWithBlit(Texture2D source, bool flipY, TextureFormat destFormat = TextureFormat.RGBA32)
		{
			return null;
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xA451A0", Offset = "0xA451A0", VA = "0xA451A0")]
		public static Texture2D MakeSureReadableAndUncompressed(ref Texture2D source, bool releaseOldIfReallocated = true)
		{
			return null;
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xA45218", Offset = "0xA45218", VA = "0xA45218")]
		public static Texture2D MakeSureReadable(ref Texture2D source, bool releaseOldIfReallocated = true, bool makeSureUncompressed = false)
		{
			return null;
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xA453C8", Offset = "0xA453C8", VA = "0xA453C8")]
		public static Texture2D ExtendToDoubleSize_KeepPixels(Texture2D source)
		{
			return null;
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xA40808", Offset = "0xA40808", VA = "0xA40808")]
		public static void ArrangeCylinderAsLineSegment(GameObject o, Vector3 v1, Vector3 v2, float radius)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xA4048C", Offset = "0xA4048C", VA = "0xA4048C")]
		public static Shader GetShader(string name)
		{
			return null;
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xA40188", Offset = "0xA40188", VA = "0xA40188")]
		public static GameObject CreatePrimitiveWithoutCollider(PrimitiveType t)
		{
			return null;
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xA455D8", Offset = "0xA455D8", VA = "0xA455D8")]
		public static Vector3 GetPosition(Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xA4567C", Offset = "0xA4567C", VA = "0xA4567C")]
		public static void ApplyMatrixToTransform(Matrix4x4 matrix, Transform t)
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class GizmoDefaultMaterial
	{
		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected Material _opaq;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Material _trans;

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xA40228", Offset = "0xA40228", VA = "0xA40228")]
		protected void ValidateMaterial()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xA4059C", Offset = "0xA4059C", VA = "0xA4059C")]
		protected void SetColor(GameObject gameObject, Color color)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xA40484", Offset = "0xA40484", VA = "0xA40484")]
		public GizmoDefaultMaterial()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class BaseGizmo : GizmoDefaultMaterial
	{
		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected GameObject _go;

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xA40028", Offset = "0xA40028", VA = "0xA40028", Slot = "4")]
		public virtual void OnInit(out PrimitiveType t, out string name)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xA40088", Offset = "0xA40088", VA = "0xA40088")]
		public void Validate()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xA40338", Offset = "0xA40338", VA = "0xA40338")]
		public void Cleanup()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xA403E4", Offset = "0xA403E4", VA = "0xA403E4")]
		public void Hide()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xA4047C", Offset = "0xA4047C", VA = "0xA4047C")]
		public BaseGizmo()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class SphereGizmo : BaseGizmo
	{
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xA41F78", Offset = "0xA41F78", VA = "0xA41F78")]
		public void Update(Vector3 center, float radius, Color c)
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xA420B4", Offset = "0xA420B4", VA = "0xA420B4")]
		public void Update(Vector3 center, float radius, Material mat)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xA421E8", Offset = "0xA421E8", VA = "0xA421E8")]
		public SphereGizmo()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class Line3D : BaseGizmo
	{
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xA406A0", Offset = "0xA406A0", VA = "0xA406A0", Slot = "4")]
		public override void OnInit(out PrimitiveType t, out string name)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xA40704", Offset = "0xA40704", VA = "0xA40704")]
		public void Update(Vector3 p0, Vector3 p1, float radius, Color c)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xA40AFC", Offset = "0xA40AFC", VA = "0xA40AFC")]
		public Line3D()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public static class Parse
	{
		[Serializable]
		[Token(Token = "0x2000216")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77907C", Offset = "0x77907C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000A93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000A94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<float, string> <>9__3_0;

			[Token(Token = "0x6000B23")]
			[Address(RVA = "0xA40F98", Offset = "0xA40F98", VA = "0xA40F98")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B24")]
			[Address(RVA = "0xA40FA0", Offset = "0xA40FA0", VA = "0xA40FA0")]
			internal string <FloatsToString>b__3_0(float x)
			{
				return null;
			}
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xA40B04", Offset = "0xA40B04", VA = "0xA40B04")]
		private static float toFloat(string s)
		{
			return default(float);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xA40BA0", Offset = "0xA40BA0", VA = "0xA40BA0")]
		private static string str(int i)
		{
			return null;
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xA40C18", Offset = "0xA40C18", VA = "0xA40C18")]
		private static string str(float f)
		{
			return null;
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xA40C90", Offset = "0xA40C90", VA = "0xA40C90")]
		public static string FloatsToString(List<float> list, string separator = " ")
		{
			return null;
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xA40D98", Offset = "0xA40D98", VA = "0xA40D98")]
		public static List<float> StringToFloats(string s, [Optional] List<float> outList, char separator = ' ')
		{
			return null;
		}
	}
	[Token(Token = "0x2000112")]
	public static class Memoize
	{
		[Token(Token = "0x60007D0")]
		public static T2 GetWithCache<T, T2>(Func<T, T2> baseFunc, T arg, Dictionary<T, T2> cache)
		{
			return (T2)null;
		}
	}
	[Token(Token = "0x2000113")]
	public static class Binary
	{
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xA36F9C", Offset = "0xA36F9C", VA = "0xA36F9C")]
		public static byte[] SaveToByteArray(Action<BinaryWriter> f)
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xA3621C", Offset = "0xA3621C", VA = "0xA3621C")]
		public static void LoadFromByteArray(byte[] data, Action<BinaryReader> f)
		{
		}
	}
}
namespace SpacePlunge.SimpleReactive
{
	[Token(Token = "0x2000114")]
	public interface IResources
	{
		[Token(Token = "0x60007D3")]
		IDisposableHook SyncModifiedDate(string relativePath, Action<long> onDateUpdated);

		[Token(Token = "0x60007D4")]
		IDisposableHook SyncFile<T>(string relativePath, Action<T> onUpdated) where T : class;

		[Token(Token = "0x60007D5")]
		IDisposableHook SubscribeToAllItemsWithFileExtension<T>(string fileExtension, Func<string, T, IDisposableHook> doForeachItem);

		[Token(Token = "0x60007D6")]
		void PushVirtualResource<T>(string relativePath, T onUpdated) where T : class;

		[Token(Token = "0x60007D7")]
		void SaveResource(string relativePath, string contents, [Optional] object resource);

		[Token(Token = "0x60007D8")]
		void SaveResource(string relativePath, byte[] contents, [Optional] object resource);

		[Token(Token = "0x60007D9")]
		void AtomicResourceWrite(string relativePath, Func<byte[], byte[]> transformFunc);

		[Token(Token = "0x60007DA")]
		void AtomicResourceWrite(string relativePath, Func<string, string> transformFunc);
	}
	[Token(Token = "0x2000115")]
	public interface IDisposableHook
	{
		[Token(Token = "0x60007DB")]
		void DisposeNow(bool parentIsBeingDisposed = false);
	}
	[Token(Token = "0x2000116")]
	public class MergeDisposables : IDisposableHook
	{
		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<IDisposableHook> list;

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xA3C2E8", Offset = "0xA3C2E8", VA = "0xA3C2E8")]
		public MergeDisposables(IDisposableHook a, IDisposableHook b)
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xA3C39C", Offset = "0xA3C39C", VA = "0xA3C39C", Slot = "4")]
		public void DisposeNow(bool parentIsBeingDisposed)
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class CallbackOnDisposeNow : IDisposableHook
	{
		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Action<bool> onDisposeNow;

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xA3C1A8", Offset = "0xA3C1A8", VA = "0xA3C1A8")]
		public CallbackOnDisposeNow(Action<bool> onDelete)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xA3C23C", Offset = "0xA3C23C", VA = "0xA3C23C", Slot = "4")]
		public void DisposeNow(bool parentIsBeingDisposed)
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class CallbackOnDispose : IDisposable
	{
		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Action onDispose;

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xA3C084", Offset = "0xA3C084", VA = "0xA3C084")]
		public CallbackOnDispose(Action onDelete)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xA3C118", Offset = "0xA3C118", VA = "0xA3C118", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class DisposableHook<T> : IDisposableHook
	{
		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T callback;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<bool> onDisposeNow;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LinkedListNode<DisposableHook<T>> link;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LinkedList<DisposableHook<T>> list;

		[Token(Token = "0x60007E2")]
		public DisposableHook(T _callback, [Optional] Action<bool> onDelete)
		{
		}

		[Token(Token = "0x60007E3")]
		public void DisposeNow(bool parentIsBeingDisposed)
		{
		}

		[Token(Token = "0x60007E4")]
		public void InsertToList(LinkedList<DisposableHook<T>> listeners)
		{
		}
	}
	[Token(Token = "0x200011A")]
	internal class ReactiveListenersT<T>
	{
		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected LinkedList<DisposableHook<T>> _list;

		[Token(Token = "0x60007E5")]
		public IDisposableHook Add(T callback, [Optional] Action<bool> onDelete)
		{
			return null;
		}

		[Token(Token = "0x60007E6")]
		public void ForceDisposeAll(bool parentIsBeingDisposed)
		{
		}

		[Token(Token = "0x60007E7")]
		public ReactiveListenersT()
		{
		}
	}
	[Token(Token = "0x200011B")]
	internal class ReactiveListeners : ReactiveListenersT<Action>
	{
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xA3C528", Offset = "0xA3C528", VA = "0xA3C528")]
		public void Notify()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xA3C634", Offset = "0xA3C634", VA = "0xA3C634")]
		public void NotifyAllExcept(IDisposableHook hook)
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xA3C754", Offset = "0xA3C754", VA = "0xA3C754")]
		public ReactiveListeners()
		{
		}
	}
	[Token(Token = "0x200011C")]
	internal class ReactiveListeners<T> : ReactiveListenersT<Action<T>>
	{
		[Token(Token = "0x60007EB")]
		public void Notify(T val)
		{
		}

		[Token(Token = "0x60007EC")]
		public void NotifyAllExcept(IDisposableHook hook, T val)
		{
		}

		[Token(Token = "0x60007ED")]
		public ReactiveListeners()
		{
		}
	}
	[Token(Token = "0x200011D")]
	internal class ReactiveListeners<T, T2> : ReactiveListenersT<Action<T, T2>>
	{
		[Token(Token = "0x60007EE")]
		public void Notify(T val, T2 val2)
		{
		}

		[Token(Token = "0x60007EF")]
		public void NotifyAllExcept(IDisposableHook hook, T val, T2 val2)
		{
		}

		[Token(Token = "0x60007F0")]
		public ReactiveListeners()
		{
		}
	}
	[Token(Token = "0x200011E")]
	internal class ReactiveListeners<T, T2, T3> : ReactiveListenersT<Action<T, T2, T3>>
	{
		[Token(Token = "0x60007F1")]
		public void Notify(T val, T2 val2, T3 val3)
		{
		}

		[Token(Token = "0x60007F2")]
		public void NotifyAllExcept(IDisposableHook hook, T val, T2 val2, T3 val3)
		{
		}

		[Token(Token = "0x60007F3")]
		public ReactiveListeners()
		{
		}
	}
	[Token(Token = "0x200011F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x778A34", Offset = "0x778A34")]
	internal class SyncableDictionary<TKey, TValue> : Dictionary<TKey, TValue>
	{
		[Token(Token = "0x2000217")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77908C", Offset = "0x77908C")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000A95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IDisposableHook structureListen;

			[Token(Token = "0x4000A96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SyncableDictionary<TKey, TValue> <>4__this;

			[Token(Token = "0x4000A97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<bool, TKey, TValue> syncFunc;

			[Token(Token = "0x6000B25")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000B26")]
			internal void <Sync>b__0(bool _)
			{
			}
		}

		[Token(Token = "0x2000218")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77909C", Offset = "0x77909C")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000A98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<TKey, TValue, IDisposableHook> createFunc;

			[Token(Token = "0x4000A99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<TKey, IDisposableHook> mapd;

			[Token(Token = "0x4000A9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IDisposableHook structureListen;

			[Token(Token = "0x6000B27")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000B28")]
			internal void <SyncObjects>b__0(bool isCreate, TKey key, TValue val)
			{
			}

			[Token(Token = "0x6000B29")]
			internal void <SyncObjects>b__1(bool _)
			{
			}
		}

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ReactiveListeners<bool, TKey, TValue> _structureListeners;

		[Token(Token = "0x1700002C")]
		public new TValue Item
		{
			[Token(Token = "0x60007F6")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x60007F7")]
			set
			{
			}
		}

		[Token(Token = "0x60007F4")]
		public SyncableDictionary()
		{
		}

		[Token(Token = "0x60007F5")]
		public SyncableDictionary(Dictionary<TKey, TValue> t)
		{
		}

		[Token(Token = "0x60007F8")]
		public new void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x60007F9")]
		public new bool Remove(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FA")]
		public void InjectAddAndRemove(TKey key)
		{
		}

		[Token(Token = "0x60007FB")]
		public IDisposableHook Sync(Action<bool, TKey, TValue> syncFunc)
		{
			return null;
		}

		[Token(Token = "0x60007FC")]
		public IDisposableHook SyncObjects(Func<TKey, TValue, IDisposableHook> createFunc)
		{
			return null;
		}
	}
	[Token(Token = "0x2000120")]
	public static class ReactiveUtil
	{
		[Token(Token = "0x60007FD")]
		public static void Dispose<T>(ref T handle) where T : class, IDisposable
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xA37EF4", Offset = "0xA37EF4", VA = "0xA37EF4")]
		public static void DisposeNow(ref IDisposableHook hook, bool parentIsBeingDisposed = false)
		{
		}
	}
}
namespace MiniJSON
{
	[Token(Token = "0x2000121")]
	public static class Json
	{
		[Token(Token = "0x2000219")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x200024E")]
			private enum TOKEN
			{
				[Token(Token = "0x4000BFA")]
				NONE,
				[Token(Token = "0x4000BFB")]
				CURLY_OPEN,
				[Token(Token = "0x4000BFC")]
				CURLY_CLOSE,
				[Token(Token = "0x4000BFD")]
				SQUARED_OPEN,
				[Token(Token = "0x4000BFE")]
				SQUARED_CLOSE,
				[Token(Token = "0x4000BFF")]
				COLON,
				[Token(Token = "0x4000C00")]
				COMMA,
				[Token(Token = "0x4000C01")]
				STRING,
				[Token(Token = "0x4000C02")]
				NUMBER,
				[Token(Token = "0x4000C03")]
				TRUE,
				[Token(Token = "0x4000C04")]
				FALSE,
				[Token(Token = "0x4000C05")]
				NULL
			}

			[Token(Token = "0x4000A9B")]
			private const string WORD_BREAK = "{}[],:\"";

			[Token(Token = "0x4000A9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x17000067")]
			private char PeekChar
			{
				[Token(Token = "0x6000B35")]
				[Address(RVA = "0xA4FFBC", Offset = "0xA4FFBC", VA = "0xA4FFBC")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000068")]
			private char NextChar
			{
				[Token(Token = "0x6000B36")]
				[Address(RVA = "0xA4FDC4", Offset = "0xA4FDC4", VA = "0xA4FDC4")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000069")]
			private string NextWord
			{
				[Token(Token = "0x6000B37")]
				[Address(RVA = "0xA4FE4C", Offset = "0xA4FE4C", VA = "0xA4FE4C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006A")]
			private TOKEN NextToken
			{
				[Token(Token = "0x6000B38")]
				[Address(RVA = "0xA4F768", Offset = "0xA4F768", VA = "0xA4F768")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0xA4F4DC", Offset = "0xA4F4DC", VA = "0xA4F4DC")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0xA4F57C", Offset = "0xA4F57C", VA = "0xA4F57C")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0xA4F330", Offset = "0xA4F330", VA = "0xA4F330")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0xA4F620", Offset = "0xA4F620", VA = "0xA4F620", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0xA4F654", Offset = "0xA4F654", VA = "0xA4F654")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0xA4FB98", Offset = "0xA4FB98", VA = "0xA4FB98")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6000B30")]
			[Address(RVA = "0xA4F5F8", Offset = "0xA4F5F8", VA = "0xA4F5F8")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x6000B31")]
			[Address(RVA = "0xA4FC6C", Offset = "0xA4FC6C", VA = "0xA4FC6C")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x6000B32")]
			[Address(RVA = "0xA4F918", Offset = "0xA4F918", VA = "0xA4F918")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x6000B33")]
			[Address(RVA = "0xA4FD48", Offset = "0xA4FD48", VA = "0xA4FD48")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x6000B34")]
			[Address(RVA = "0xA4FF08", Offset = "0xA4FF08", VA = "0xA4FF08")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x200021A")]
		private sealed class Serializer
		{
			[Token(Token = "0x4000A9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x6000B39")]
			[Address(RVA = "0xA50044", Offset = "0xA50044", VA = "0xA50044")]
			private Serializer()
			{
			}

			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0xA4F460", Offset = "0xA4F460", VA = "0xA4F460")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0xA500B0", Offset = "0xA500B0", VA = "0xA500B0")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0xA50768", Offset = "0xA50768", VA = "0xA50768")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0xA504AC", Offset = "0xA504AC", VA = "0xA504AC")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0xA5024C", Offset = "0xA5024C", VA = "0xA5024C")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0xA50B50", Offset = "0xA50B50", VA = "0xA50B50")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xA4F324", Offset = "0xA4F324", VA = "0xA4F324")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xA4F45C", Offset = "0xA4F45C", VA = "0xA4F45C")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
namespace CapturePanorama
{
	[Token(Token = "0x2000122")]
	public class CapturePanorama : MonoBehaviour
	{
		[Token(Token = "0x200021B")]
		public enum ImageFormat
		{
			[Token(Token = "0x4000A9F")]
			PNG,
			[Token(Token = "0x4000AA0")]
			JPEG,
			[Token(Token = "0x4000AA1")]
			BMP
		}

		[Token(Token = "0x200021C")]
		public enum AntiAliasing
		{
			[Token(Token = "0x4000AA3")]
			_1 = 1,
			[Token(Token = "0x4000AA4")]
			_2 = 2,
			[Token(Token = "0x4000AA5")]
			_4 = 4,
			[Token(Token = "0x4000AA6")]
			_8 = 8
		}

		[Token(Token = "0x200021D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7790AC", Offset = "0x7790AC")]
		private sealed class <FadeOut>d__105 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CapturePanorama <>4__this;

			[Token(Token = "0x4000AAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerable<ScreenFadeControl> fadeControls;

			[Token(Token = "0x4000AAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <elapsedTime>5__2;

			[Token(Token = "0x4000AAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Color <color>5__3;

			[Token(Token = "0x1700006B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B43")]
				[Address(RVA = "0xAB4120", Offset = "0xAB4120", VA = "0xAB4120", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B45")]
				[Address(RVA = "0xAB4188", Offset = "0xAB4188", VA = "0xAB4188", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B40")]
			[Address(RVA = "0xAB3F78", Offset = "0xAB3F78", VA = "0xAB3F78")]
			[DebuggerHidden]
			public <FadeOut>d__105(int <>1__state)
			{
			}

			[Token(Token = "0x6000B41")]
			[Address(RVA = "0xAB3FA4", Offset = "0xAB3FA4", VA = "0xAB3FA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B42")]
			[Address(RVA = "0xAB3FA8", Offset = "0xAB3FA8", VA = "0xAB3FA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B44")]
			[Address(RVA = "0xAB4128", Offset = "0xAB4128", VA = "0xAB4128", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200021E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7790BC", Offset = "0x7790BC")]
		private sealed class <FadeIn>d__106 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CapturePanorama <>4__this;

			[Token(Token = "0x4000AB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerable<ScreenFadeControl> fadeControls;

			[Token(Token = "0x4000AB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <elapsedTime>5__2;

			[Token(Token = "0x4000AB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Color <color>5__3;

			[Token(Token = "0x1700006D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B49")]
				[Address(RVA = "0xAB3F08", Offset = "0xAB3F08", VA = "0xAB3F08", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B4B")]
				[Address(RVA = "0xAB3F70", Offset = "0xAB3F70", VA = "0xAB3F70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B46")]
			[Address(RVA = "0xAB3D4C", Offset = "0xAB3D4C", VA = "0xAB3D4C")]
			[DebuggerHidden]
			public <FadeIn>d__106(int <>1__state)
			{
			}

			[Token(Token = "0x6000B47")]
			[Address(RVA = "0xAB3D78", Offset = "0xAB3D78", VA = "0xAB3D78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B48")]
			[Address(RVA = "0xAB3D7C", Offset = "0xAB3D7C", VA = "0xAB3D7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0xAB3F10", Offset = "0xAB3F10", VA = "0xAB3F10", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200021F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7790CC", Offset = "0x7790CC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000AB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000AB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<Camera> <>9__107_0;

			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0xD5A184", Offset = "0xD5A184", VA = "0xD5A184")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0xD5A18C", Offset = "0xD5A18C", VA = "0xD5A18C")]
			internal int <CaptureScreenshotAsyncHelper>b__107_0(Camera x, Camera y)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000220")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7790DC", Offset = "0x7790DC")]
		private sealed class <CaptureScreenshotAsyncHelper>d__107 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool async;

			[Token(Token = "0x4000AB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CapturePanorama <>4__this;

			[Token(Token = "0x4000AB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string filenameBase;

			[Token(Token = "0x4000ABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera[] <cameras>5__2;

			[Token(Token = "0x4000ABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<ScreenFadeControl> <fadeControls>5__3;

			[Token(Token = "0x4000ABC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ComputeBuffer <convertPanoramaResultBuffer>5__4;

			[Token(Token = "0x4000ABD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private ComputeBuffer <forceWaitResultConvertPanoramaStereoBuffer>5__5;

			[Token(Token = "0x4000ABE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private ComputeBuffer <cameraPixelsBuffer>5__6;

			[Token(Token = "0x4000ABF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private ComputeBuffer <forceWaitResultTextureToBufferBuffer>5__7;

			[Token(Token = "0x4000AC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private float <startTime>5__8;

			[Token(Token = "0x4000AC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private string <suffix>5__9;

			[Token(Token = "0x4000AC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private string <filePath>5__10;

			[Token(Token = "0x4000AC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private string <imagePath>5__11;

			[Token(Token = "0x4000AC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private bool <producedImageSuccess>5__12;

			[Token(Token = "0x4000AC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private int <i>5__13;

			[Token(Token = "0x4000AC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private byte[] <pixelValues>5__14;

			[Token(Token = "0x1700006F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B52")]
				[Address(RVA = "0xD5CD88", Offset = "0xD5CD88", VA = "0xD5CD88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B54")]
				[Address(RVA = "0xD5CDF0", Offset = "0xD5CDF0", VA = "0xD5CDF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0xD58E20", Offset = "0xD58E20", VA = "0xD58E20")]
			[DebuggerHidden]
			public <CaptureScreenshotAsyncHelper>d__107(int <>1__state)
			{
			}

			[Token(Token = "0x6000B50")]
			[Address(RVA = "0xD5A1E0", Offset = "0xD5A1E0", VA = "0xD5A1E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B51")]
			[Address(RVA = "0xD5A1E4", Offset = "0xD5A1E4", VA = "0xD5A1E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B53")]
			[Address(RVA = "0xD5CD90", Offset = "0xD5CD90", VA = "0xD5CD90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000221")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7790EC", Offset = "0x7790EC")]
		private sealed class <UploadImage>d__116 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CapturePanorama <>4__this;

			[Token(Token = "0x4000ACA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public byte[] imageFileBytes;

			[Token(Token = "0x4000ACB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string filename;

			[Token(Token = "0x4000ACC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string mimeType;

			[Token(Token = "0x4000ACD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startTime>5__2;

			[Token(Token = "0x4000ACE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private WWW <w>5__3;

			[Token(Token = "0x17000071")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B58")]
				[Address(RVA = "0xAB4524", Offset = "0xAB4524", VA = "0xAB4524", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B5A")]
				[Address(RVA = "0xAB458C", Offset = "0xAB458C", VA = "0xAB458C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B55")]
			[Address(RVA = "0xAB4190", Offset = "0xAB4190", VA = "0xAB4190")]
			[DebuggerHidden]
			public <UploadImage>d__116(int <>1__state)
			{
			}

			[Token(Token = "0x6000B56")]
			[Address(RVA = "0xAB41BC", Offset = "0xAB41BC", VA = "0xAB41BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B57")]
			[Address(RVA = "0xAB41C0", Offset = "0xAB41C0", VA = "0xAB41C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B59")]
			[Address(RVA = "0xAB452C", Offset = "0xAB452C", VA = "0xAB452C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000222")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7790FC", Offset = "0x7790FC")]
		private sealed class <CubemapToEquirectangular>d__117 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000ACF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CapturePanorama <>4__this;

			[Token(Token = "0x4000AD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ComputeBuffer convertPanoramaResultBuffer;

			[Token(Token = "0x4000AD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public byte[] pixelValues;

			[Token(Token = "0x4000AD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int stride;

			[Token(Token = "0x4000AD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int panoramaWidth;

			[Token(Token = "0x4000AD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int panoramaHeight;

			[Token(Token = "0x4000AD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public uint[] cameraPixels;

			[Token(Token = "0x4000AD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool async;

			[Token(Token = "0x4000AD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public int cameraWidth;

			[Token(Token = "0x4000ADA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public int cameraHeight;

			[Token(Token = "0x4000ADB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public int ssaaFactor;

			[Token(Token = "0x4000ADC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float <processingTimePerFrame>5__2;

			[Token(Token = "0x4000ADD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private int <y>5__3;

			[Token(Token = "0x4000ADE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int <x>5__4;

			[Token(Token = "0x17000073")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B5E")]
				[Address(RVA = "0xD5D9F0", Offset = "0xD5D9F0", VA = "0xD5D9F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B60")]
				[Address(RVA = "0xD5DA58", Offset = "0xD5DA58", VA = "0xD5DA58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B5B")]
			[Address(RVA = "0xD595CC", Offset = "0xD595CC", VA = "0xD595CC")]
			[DebuggerHidden]
			public <CubemapToEquirectangular>d__117(int <>1__state)
			{
			}

			[Token(Token = "0x6000B5C")]
			[Address(RVA = "0xD5CDF8", Offset = "0xD5CDF8", VA = "0xD5CDF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B5D")]
			[Address(RVA = "0xD5CDFC", Offset = "0xD5CDFC", VA = "0xD5CDFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B5F")]
			[Address(RVA = "0xD5D9F8", Offset = "0xD5D9F8", VA = "0xD5D9F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000223")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77910C", Offset = "0x77910C")]
		private sealed class <CubemapToEquirectangularCpu>d__119 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000ADF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CapturePanorama <>4__this;

			[Token(Token = "0x4000AE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int cameraWidth;

			[Token(Token = "0x4000AE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int cameraHeight;

			[Token(Token = "0x4000AE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int ssaaFactor;

			[Token(Token = "0x4000AE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int panoramaHeight;

			[Token(Token = "0x4000AE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int panoramaWidth;

			[Token(Token = "0x4000AE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool async;

			[Token(Token = "0x4000AE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint[] cameraPixels;

			[Token(Token = "0x4000AE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public byte[] pixelValues;

			[Token(Token = "0x4000AEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int stride;

			[Token(Token = "0x4000AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float <startTime>5__2;

			[Token(Token = "0x4000AEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private float <processingTimePerFrame>5__3;

			[Token(Token = "0x4000AED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private float <maxWidth>5__4;

			[Token(Token = "0x4000AEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float <maxHeight>5__5;

			[Token(Token = "0x4000AEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private int <numPixelsAveraged>5__6;

			[Token(Token = "0x4000AF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int <endYPositive>5__7;

			[Token(Token = "0x4000AF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private int <startYNegative>5__8;

			[Token(Token = "0x4000AF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int <endTopMixedRegion>5__9;

			[Token(Token = "0x4000AF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private int <startBottomMixedRegion>5__10;

			[Token(Token = "0x4000AF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private int <startXNegative>5__11;

			[Token(Token = "0x4000AF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private int <endXNegative>5__12;

			[Token(Token = "0x4000AF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private int <startZPositive>5__13;

			[Token(Token = "0x4000AF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private int <endZPositive>5__14;

			[Token(Token = "0x4000AF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private int <startXPositive>5__15;

			[Token(Token = "0x4000AF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private int <endXPositive>5__16;

			[Token(Token = "0x4000AFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private int <startZNegative>5__17;

			[Token(Token = "0x4000AFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private int <endZNegative>5__18;

			[Token(Token = "0x17000075")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B64")]
				[Address(RVA = "0xD5E99C", Offset = "0xD5E99C", VA = "0xD5E99C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000076")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B66")]
				[Address(RVA = "0xD5EA04", Offset = "0xD5EA04", VA = "0xD5EA04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B61")]
			[Address(RVA = "0xD597C4", Offset = "0xD597C4", VA = "0xD597C4")]
			[DebuggerHidden]
			public <CubemapToEquirectangularCpu>d__119(int <>1__state)
			{
			}

			[Token(Token = "0x6000B62")]
			[Address(RVA = "0xD5DA60", Offset = "0xD5DA60", VA = "0xD5DA60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B63")]
			[Address(RVA = "0xD5DA64", Offset = "0xD5DA64", VA = "0xD5DA64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B65")]
			[Address(RVA = "0xD5E9A4", Offset = "0xD5E9A4", VA = "0xD5E9A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000224")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77911C", Offset = "0x77911C")]
		private sealed class <CubemapToEquirectangularCpuPositiveY>d__120 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int startY;

			[Token(Token = "0x4000AFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int startX;

			[Token(Token = "0x4000B00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int ssaaFactor;

			[Token(Token = "0x4000B01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int panoramaWidth;

			[Token(Token = "0x4000B02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int panoramaHeight;

			[Token(Token = "0x4000B03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CapturePanorama <>4__this;

			[Token(Token = "0x4000B04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint[] cameraPixels;

			[Token(Token = "0x4000B05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int stride;

			[Token(Token = "0x4000B06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public byte[] pixelValues;

			[Token(Token = "0x4000B07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public int numPixelsAveraged;

			[Token(Token = "0x4000B08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float startTime;

			[Token(Token = "0x4000B09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float processingTimePerFrame;

			[Token(Token = "0x4000B0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public int endX;

			[Token(Token = "0x4000B0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public int endY;

			[Token(Token = "0x4000B0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private int <y>5__2;

			[Token(Token = "0x4000B0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int <x>5__3;

			[Token(Token = "0x17000077")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B6A")]
				[Address(RVA = "0xAB3888", Offset = "0xAB3888", VA = "0xAB3888", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000078")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B6C")]
				[Address(RVA = "0xAB38F0", Offset = "0xAB38F0", VA = "0xAB38F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B67")]
			[Address(RVA = "0xAB34A4", Offset = "0xAB34A4", VA = "0xAB34A4")]
			[DebuggerHidden]
			public <CubemapToEquirectangularCpuPositiveY>d__120(int <>1__state)
			{
			}

			[Token(Token = "0x6000B68")]
			[Address(RVA = "0xAB34D0", Offset = "0xAB34D0", VA = "0xAB34D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B69")]
			[Address(RVA = "0xAB34D4", Offset = "0xAB34D4", VA = "0xAB34D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0xAB3890", Offset = "0xAB3890", VA = "0xAB3890", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000225")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77912C", Offset = "0x77912C")]
		private sealed class <CubemapToEquirectangularCpuNegativeY>d__121 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int startY;

			[Token(Token = "0x4000B11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int startX;

			[Token(Token = "0x4000B12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int ssaaFactor;

			[Token(Token = "0x4000B13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int panoramaWidth;

			[Token(Token = "0x4000B14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int panoramaHeight;

			[Token(Token = "0x4000B15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CapturePanorama <>4__this;

			[Token(Token = "0x4000B16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint[] cameraPixels;

			[Token(Token = "0x4000B17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int stride;

			[Token(Token = "0x4000B18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public byte[] pixelValues;

			[Token(Token = "0x4000B19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public int numPixelsAveraged;

			[Token(Token = "0x4000B1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float startTime;

			[Token(Token = "0x4000B1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float processingTimePerFrame;

			[Token(Token = "0x4000B1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public int endX;

			[Token(Token = "0x4000B1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public int endY;

			[Token(Token = "0x4000B1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private int <y>5__2;

			[Token(Token = "0x4000B1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int <x>5__3;

			[Token(Token = "0x17000079")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B70")]
				[Address(RVA = "0xD5F76C", Offset = "0xD5F76C", VA = "0xD5F76C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B72")]
				[Address(RVA = "0xD5F7D4", Offset = "0xD5F7D4", VA = "0xD5F7D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0xD599C8", Offset = "0xD599C8", VA = "0xD599C8")]
			[DebuggerHidden]
			public <CubemapToEquirectangularCpuNegativeY>d__121(int <>1__state)
			{
			}

			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0xD5F3B8", Offset = "0xD5F3B8", VA = "0xD5F3B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0xD5F3BC", Offset = "0xD5F3BC", VA = "0xD5F3BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B71")]
			[Address(RVA = "0xD5F774", Offset = "0xD5F774", VA = "0xD5F774", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000226")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77913C", Offset = "0x77913C")]
		private sealed class <CubemapToEquirectangularCpuPositiveX>d__122 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int startY;

			[Token(Token = "0x4000B23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int startX;

			[Token(Token = "0x4000B24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int ssaaFactor;

			[Token(Token = "0x4000B25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int panoramaWidth;

			[Token(Token = "0x4000B26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int panoramaHeight;

			[Token(Token = "0x4000B27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CapturePanorama <>4__this;

			[Token(Token = "0x4000B28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint[] cameraPixels;

			[Token(Token = "0x4000B29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int stride;

			[Token(Token = "0x4000B2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public byte[] pixelValues;

			[Token(Token = "0x4000B2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public int numPixelsAveraged;

			[Token(Token = "0x4000B2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float startTime;

			[Token(Token = "0x4000B2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float processingTimePerFrame;

			[Token(Token = "0x4000B2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public int endX;

			[Token(Token = "0x4000B2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public int endY;

			[Token(Token = "0x4000B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private int <y>5__2;

			[Token(Token = "0x4000B31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int <x>5__3;

			[Token(Token = "0x1700007B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B76")]
				[Address(RVA = "0xAB3434", Offset = "0xAB3434", VA = "0xAB3434", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B78")]
				[Address(RVA = "0xAB349C", Offset = "0xAB349C", VA = "0xAB349C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B73")]
			[Address(RVA = "0xAB3050", Offset = "0xAB3050", VA = "0xAB3050")]
			[DebuggerHidden]
			public <CubemapToEquirectangularCpuPositiveX>d__122(int <>1__state)
			{
			}

			[Token(Token = "0x6000B74")]
			[Address(RVA = "0xAB307C", Offset = "0xAB307C", VA = "0xAB307C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B75")]
			[Address(RVA = "0xAB3080", Offset = "0xAB3080", VA = "0xAB3080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B77")]
			[Address(RVA = "0xAB343C", Offset = "0xAB343C", VA = "0xAB343C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000227")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77914C", Offset = "0x77914C")]
		private sealed class <CubemapToEquirectangularCpuNegativeX>d__123 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int startY;

			[Token(Token = "0x4000B35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int startX;

			[Token(Token = "0x4000B36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int ssaaFactor;

			[Token(Token = "0x4000B37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int panoramaWidth;

			[Token(Token = "0x4000B38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int panoramaHeight;

			[Token(Token = "0x4000B39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CapturePanorama <>4__this;

			[Token(Token = "0x4000B3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint[] cameraPixels;

			[Token(Token = "0x4000B3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int stride;

			[Token(Token = "0x4000B3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public byte[] pixelValues;

			[Token(Token = "0x4000B3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public int numPixelsAveraged;

			[Token(Token = "0x4000B3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float startTime;

			[Token(Token = "0x4000B3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float processingTimePerFrame;

			[Token(Token = "0x4000B40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public int endX;

			[Token(Token = "0x4000B41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public int endY;

			[Token(Token = "0x4000B42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private int <y>5__2;

			[Token(Token = "0x4000B43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int <x>5__3;

			[Token(Token = "0x1700007D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B7C")]
				[Address(RVA = "0xD5F348", Offset = "0xD5F348", VA = "0xD5F348", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B7E")]
				[Address(RVA = "0xD5F3B0", Offset = "0xD5F3B0", VA = "0xD5F3B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B79")]
			[Address(RVA = "0xD59BCC", Offset = "0xD59BCC", VA = "0xD59BCC")]
			[DebuggerHidden]
			public <CubemapToEquirectangularCpuNegativeX>d__123(int <>1__state)
			{
			}

			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0xD5EF94", Offset = "0xD5EF94", VA = "0xD5EF94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0xD5EF98", Offset = "0xD5EF98", VA = "0xD5EF98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B7D")]
			[Address(RVA = "0xD5F350", Offset = "0xD5F350", VA = "0xD5F350", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000228")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77915C", Offset = "0x77915C")]
		private sealed class <CubemapToEquirectangularCpuPositiveZ>d__124 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int startY;

			[Token(Token = "0x4000B47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int startX;

			[Token(Token = "0x4000B48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int ssaaFactor;

			[Token(Token = "0x4000B49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int panoramaWidth;

			[Token(Token = "0x4000B4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int panoramaHeight;

			[Token(Token = "0x4000B4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CapturePanorama <>4__this;

			[Token(Token = "0x4000B4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint[] cameraPixels;

			[Token(Token = "0x4000B4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int stride;

			[Token(Token = "0x4000B4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public byte[] pixelValues;

			[Token(Token = "0x4000B4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public int numPixelsAveraged;

			[Token(Token = "0x4000B50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float startTime;

			[Token(Token = "0x4000B51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float processingTimePerFrame;

			[Token(Token = "0x4000B52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public int endX;

			[Token(Token = "0x4000B53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public int endY;

			[Token(Token = "0x4000B54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private int <y>5__2;

			[Token(Token = "0x4000B55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int <x>5__3;

			[Token(Token = "0x1700007F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B82")]
				[Address(RVA = "0xAB3CDC", Offset = "0xAB3CDC", VA = "0xAB3CDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000080")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B84")]
				[Address(RVA = "0xAB3D44", Offset = "0xAB3D44", VA = "0xAB3D44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0xAB38F8", Offset = "0xAB38F8", VA = "0xAB38F8")]
			[DebuggerHidden]
			public <CubemapToEquirectangularCpuPositiveZ>d__124(int <>1__state)
			{
			}

			[Token(Token = "0x6000B80")]
			[Address(RVA = "0xAB3924", Offset = "0xAB3924", VA = "0xAB3924", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B81")]
			[Address(RVA = "0xAB3928", Offset = "0xAB3928", VA = "0xAB3928", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B83")]
			[Address(RVA = "0xAB3CE4", Offset = "0xAB3CE4", VA = "0xAB3CE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000229")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77916C", Offset = "0x77916C")]
		private sealed class <CubemapToEquirectangularCpuNegativeZ>d__125 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int startY;

			[Token(Token = "0x4000B59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int startX;

			[Token(Token = "0x4000B5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int ssaaFactor;

			[Token(Token = "0x4000B5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int panoramaWidth;

			[Token(Token = "0x4000B5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int panoramaHeight;

			[Token(Token = "0x4000B5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CapturePanorama <>4__this;

			[Token(Token = "0x4000B5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint[] cameraPixels;

			[Token(Token = "0x4000B5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int stride;

			[Token(Token = "0x4000B60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public byte[] pixelValues;

			[Token(Token = "0x4000B61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public int numPixelsAveraged;

			[Token(Token = "0x4000B62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float startTime;

			[Token(Token = "0x4000B63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float processingTimePerFrame;

			[Token(Token = "0x4000B64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public int endX;

			[Token(Token = "0x4000B65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public int endY;

			[Token(Token = "0x4000B66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private int <y>5__2;

			[Token(Token = "0x4000B67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int <x>5__3;

			[Token(Token = "0x17000081")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B88")]
				[Address(RVA = "0xD5FB90", Offset = "0xD5FB90", VA = "0xD5FB90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000082")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B8A")]
				[Address(RVA = "0xD5FBF8", Offset = "0xD5FBF8", VA = "0xD5FBF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B85")]
			[Address(RVA = "0xD59DD0", Offset = "0xD59DD0", VA = "0xD59DD0")]
			[DebuggerHidden]
			public <CubemapToEquirectangularCpuNegativeZ>d__125(int <>1__state)
			{
			}

			[Token(Token = "0x6000B86")]
			[Address(RVA = "0xD5F7DC", Offset = "0xD5F7DC", VA = "0xD5F7DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B87")]
			[Address(RVA = "0xD5F7E0", Offset = "0xD5F7E0", VA = "0xD5F7E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B89")]
			[Address(RVA = "0xD5FB98", Offset = "0xD5FB98", VA = "0xD5FB98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200022A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77917C", Offset = "0x77917C")]
		private sealed class <CubemapToEquirectangularCpuGeneralCase>d__126 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int startY;

			[Token(Token = "0x4000B6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int startX;

			[Token(Token = "0x4000B6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int ssaaFactor;

			[Token(Token = "0x4000B6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int panoramaWidth;

			[Token(Token = "0x4000B6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int panoramaHeight;

			[Token(Token = "0x4000B6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float maxWidth;

			[Token(Token = "0x4000B70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float maxHeight;

			[Token(Token = "0x4000B71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public CapturePanorama <>4__this;

			[Token(Token = "0x4000B72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public uint[] cameraPixels;

			[Token(Token = "0x4000B73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int stride;

			[Token(Token = "0x4000B74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public byte[] pixelValues;

			[Token(Token = "0x4000B75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public int numPixelsAveraged;

			[Token(Token = "0x4000B76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float startTime;

			[Token(Token = "0x4000B77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float processingTimePerFrame;

			[Token(Token = "0x4000B78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public int endX;

			[Token(Token = "0x4000B79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public int endY;

			[Token(Token = "0x4000B7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private int <y>5__2;

			[Token(Token = "0x4000B7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private int <x>5__3;

			[Token(Token = "0x17000083")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B8E")]
				[Address(RVA = "0xD5EF24", Offset = "0xD5EF24", VA = "0xD5EF24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000084")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B90")]
				[Address(RVA = "0xD5EF8C", Offset = "0xD5EF8C", VA = "0xD5EF8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0xD59EFC", Offset = "0xD59EFC", VA = "0xD59EFC")]
			[DebuggerHidden]
			public <CubemapToEquirectangularCpuGeneralCase>d__126(int <>1__state)
			{
			}

			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0xD5EA0C", Offset = "0xD5EA0C", VA = "0xD5EA0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0xD5EA10", Offset = "0xD5EA10", VA = "0xD5EA10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B8F")]
			[Address(RVA = "0xD5EF2C", Offset = "0xD5EF2C", VA = "0xD5EF2C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string panoramaName;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string qualitySetting;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public KeyCode captureKey;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ImageFormat imageFormat;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool captureStereoscopic;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float interpupillaryDistance;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int numCirclePoints;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int panoramaWidth;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool downscale;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public AntiAliasing antiAliasing;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int ssaaFactor;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string saveImagePath;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool saveCubemap;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool uploadImages;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool useDefaultOrientation;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		public bool useGpuTransform;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float cpuMillisecondsPerFrame;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool captureEveryFrame;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int frameRate;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int maxFramesToRecord;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int frameNumberDigits;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioClip startSound;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioClip doneSound;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioClip failSound;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool fadeDuringCapture;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float fadeTime;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Color fadeColor;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Material fadeMaterial;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public ComputeShader convertPanoramaShader;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public ComputeShader convertPanoramaStereoShader;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public ComputeShader textureToBufferShader;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool enableDebugging;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private string apiUrl;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private string apiKey;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private GameObject[] camGos;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Camera cam;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ImageEffectCopyCamera copyCameraScript;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool capturingEveryFrame;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool usingGpuTransform;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private CubemapFace[] faces;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int panoramaHeight;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int cameraWidth;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int cameraHeight;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private RenderTexture cubemapRenderTexture;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Texture2D forceWaitTexture;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int convertPanoramaKernelIdx;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private int convertPanoramaYPositiveKernelIdx;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int convertPanoramaYNegativeKernelIdx;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int textureToBufferIdx;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private int renderStereoIdx;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int[] convertPanoramaKernelIdxs;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private byte[] imageFileBytes;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private string videoBaseName;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private int frameNumber;

		[Token(Token = "0x40006D0")]
		private const int ResultBufferSlices = 8;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private float hFov;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float vFov;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float hFovAdjustDegrees;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float vFovAdjustDegrees;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float circleRadius;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int threadsX;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int threadsY;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private int numCameras;

		[Token(Token = "0x40006D9")]
		private const int CamerasPerCirclePoint = 4;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private uint[] cameraPixels;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private uint[] resultPixels;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float tanHalfHFov;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float tanHalfVFov;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private float hFovAdjust;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private float vFovAdjust;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private int overlapTextures;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private bool initializeFailed;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private AudioSource audioSource;

		[Token(Token = "0x40006E3")]
		private const uint BufferSentinelValue = 1419455993u;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int lastConfiguredPanoramaWidth;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private int lastConfiguredNumCirclePoints;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private int lastConfiguredSsaaFactor;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private float lastConfiguredInterpupillaryDistance;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private bool lastConfiguredCaptureStereoscopic;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		private bool lastConfiguredSaveCubemap;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		private bool lastConfiguredUseGpuTransform;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private AntiAliasing lastConfiguredAntiAliasing;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CapturePanorama instance;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		internal bool Capturing;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<Process> resizingProcessList;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<string> resizingFilenames;

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xD57208", Offset = "0xD57208", VA = "0xD57208")]
		public bool IsCapturingEveryFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xD57210", Offset = "0xD57210", VA = "0xD57210")]
		private string FormatMimeType(ImageFormat format)
		{
			return null;
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xD57274", Offset = "0xD57274", VA = "0xD57274")]
		private string FormatToExtension(ImageFormat format)
		{
			return null;
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xD572D8", Offset = "0xD572D8", VA = "0xD572D8")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xD573E8", Offset = "0xD573E8", VA = "0xD573E8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xD5754C", Offset = "0xD5754C", VA = "0xD5754C")]
		private float IpdScaleFunction(float latitudeNormalized)
		{
			return default(float);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xD575D4", Offset = "0xD575D4", VA = "0xD575D4")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xD575D8", Offset = "0xD575D8", VA = "0xD575D8")]
		private void Cleanup()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xD57474", Offset = "0xD57474", VA = "0xD57474")]
		private void Reinitialize()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xD57838", Offset = "0xD57838", VA = "0xD57838")]
		private void ReinitializeBody()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xD58478", Offset = "0xD58478", VA = "0xD58478")]
		private void Log(string s)
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xD58508", Offset = "0xD58508", VA = "0xD58508")]
		public void Update()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xD589CC", Offset = "0xD589CC", VA = "0xD589CC")]
		public void StartCaptureEveryFrame()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xD588CC", Offset = "0xD588CC", VA = "0xD588CC")]
		public void StopCaptureEveryFrame()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xD588F8", Offset = "0xD588F8", VA = "0xD588F8")]
		public void CaptureScreenshotSync(string filenameBase)
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xD58A08", Offset = "0xD58A08", VA = "0xD58A08")]
		public void CaptureScreenshotAsync(string filenameBase)
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xD58AC0", Offset = "0xD58AC0", VA = "0xD58AC0")]
		private void SetFadersEnabled(IEnumerable<ScreenFadeControl> fadeControls, bool value)
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xD58D28", Offset = "0xD58D28", VA = "0xD58D28")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77B5F8", Offset = "0x77B5F8")]
		public IEnumerator FadeOut(IEnumerable<ScreenFadeControl> fadeControls)
		{
			return null;
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xD58DA4", Offset = "0xD58DA4", VA = "0xD58DA4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77B65C", Offset = "0x77B65C")]
		public IEnumerator FadeIn(IEnumerable<ScreenFadeControl> fadeControls)
		{
			return null;
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xD58A38", Offset = "0xD58A38", VA = "0xD58A38")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77B6C0", Offset = "0x77B6C0")]
		public IEnumerator CaptureScreenshotAsyncHelper(string filenameBase, bool async)
		{
			return null;
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xD58E4C", Offset = "0xD58E4C", VA = "0xD58E4C", Slot = "4")]
		public virtual bool OnCaptureStart()
		{
			return default(bool);
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xD58E54", Offset = "0xD58E54", VA = "0xD58E54", Slot = "5")]
		public virtual Camera[] GetCaptureCameras()
		{
			return null;
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xD58F48", Offset = "0xD58F48", VA = "0xD58F48", Slot = "6")]
		public virtual void BeforeRenderPanorama()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xD58F4C", Offset = "0xD58F4C", VA = "0xD58F4C", Slot = "7")]
		public virtual void AfterRenderPanorama()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xD58F50", Offset = "0xD58F50", VA = "0xD58F50")]
		private static void ReportOutOfGraphicsMemory()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xD58FBC", Offset = "0xD58FBC", VA = "0xD58FBC")]
		private void SaveCubemapImage(uint[] cameraPixels, string filenameBase, string suffix, string imagePath, int i, int bufferIdx)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xD59028", Offset = "0xD59028", VA = "0xD59028")]
		private Color32 GetCameraPixelBilinear(uint[] cameraPixels, int cameraNum, float u, float v)
		{
			return default(Color32);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xD5932C", Offset = "0xD5932C", VA = "0xD5932C")]
		internal void ClearProcessQueue()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xD5946C", Offset = "0xD5946C", VA = "0xD5946C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77B724", Offset = "0x77B724")]
		private IEnumerator UploadImage(byte[] imageFileBytes, string filename, string mimeType, bool async)
		{
			return null;
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xD594FC", Offset = "0xD594FC", VA = "0xD594FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77B788", Offset = "0x77B788")]
		private IEnumerator CubemapToEquirectangular(ComputeBuffer cameraPixelsBuffer, uint[] cameraPixels, ComputeBuffer convertPanoramaResultBuffer, int cameraWidth, int cameraHeight, byte[] pixelValues, int stride, int panoramaWidth, int panoramaHeight, int ssaaFactor, bool async)
		{
			return null;
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xD595F8", Offset = "0xD595F8", VA = "0xD595F8")]
		private void writeOutputPixels(byte[] pixelValues, int stride, int bitmapWidth, int inHeight, int outHeight, int yStart)
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xD596F4", Offset = "0xD596F4", VA = "0xD596F4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77B7EC", Offset = "0x77B7EC")]
		private IEnumerator CubemapToEquirectangularCpu(uint[] cameraPixels, int cameraWidth, int cameraHeight, byte[] pixelValues, int stride, int panoramaWidth, int panoramaHeight, int ssaaFactor, bool async)
		{
			return null;
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xD597F0", Offset = "0xD597F0", VA = "0xD597F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77B850", Offset = "0x77B850")]
		private IEnumerator CubemapToEquirectangularCpuPositiveY(uint[] cameraPixels, byte[] pixelValues, int stride, int panoramaWidth, int panoramaHeight, int ssaaFactor, float startTime, float processingTimePerFrame, int numPixelsAveraged, int startX, int startY, int endX, int endY)
		{
			return null;
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xD598DC", Offset = "0xD598DC", VA = "0xD598DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77B8B4", Offset = "0x77B8B4")]
		private IEnumerator CubemapToEquirectangularCpuNegativeY(uint[] cameraPixels, byte[] pixelValues, int stride, int panoramaWidth, int panoramaHeight, int ssaaFactor, float startTime, float processingTimePerFrame, int numPixelsAveraged, int startX, int startY, int endX, int endY)
		{
			return null;
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xD599F4", Offset = "0xD599F4", VA = "0xD599F4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77B918", Offset = "0x77B918")]
		private IEnumerator CubemapToEquirectangularCpuPositiveX(uint[] cameraPixels, byte[] pixelValues, int stride, int panoramaWidth, int panoramaHeight, int ssaaFactor, float startTime, float processingTimePerFrame, int numPixelsAveraged, int startX, int startY, int endX, int endY)
		{
			return null;
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xD59AE0", Offset = "0xD59AE0", VA = "0xD59AE0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77B97C", Offset = "0x77B97C")]
		private IEnumerator CubemapToEquirectangularCpuNegativeX(uint[] cameraPixels, byte[] pixelValues, int stride, int panoramaWidth, int panoramaHeight, int ssaaFactor, float startTime, float processingTimePerFrame, int numPixelsAveraged, int startX, int startY, int endX, int endY)
		{
			return null;
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xD59BF8", Offset = "0xD59BF8", VA = "0xD59BF8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77B9E0", Offset = "0x77B9E0")]
		private IEnumerator CubemapToEquirectangularCpuPositiveZ(uint[] cameraPixels, byte[] pixelValues, int stride, int panoramaWidth, int panoramaHeight, int ssaaFactor, float startTime, float processingTimePerFrame, int numPixelsAveraged, int startX, int startY, int endX, int endY)
		{
			return null;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xD59CE4", Offset = "0xD59CE4", VA = "0xD59CE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77BA44", Offset = "0x77BA44")]
		private IEnumerator CubemapToEquirectangularCpuNegativeZ(uint[] cameraPixels, byte[] pixelValues, int stride, int panoramaWidth, int panoramaHeight, int ssaaFactor, float startTime, float processingTimePerFrame, int numPixelsAveraged, int startX, int startY, int endX, int endY)
		{
			return null;
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xD59DFC", Offset = "0xD59DFC", VA = "0xD59DFC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77BAA8", Offset = "0x77BAA8")]
		private IEnumerator CubemapToEquirectangularCpuGeneralCase(uint[] cameraPixels, byte[] pixelValues, int stride, int panoramaWidth, int panoramaHeight, int ssaaFactor, float startTime, float processingTimePerFrame, float maxWidth, float maxHeight, int numPixelsAveraged, int startX, int startY, int endX, int endY)
		{
			return null;
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xD59F28", Offset = "0xD59F28", VA = "0xD59F28")]
		public CapturePanorama()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public static class Icosphere
	{
		[Token(Token = "0x600082A")]
		[Address(RVA = "0xAB4594", Offset = "0xAB4594", VA = "0xAB4594")]
		public static Mesh BuildIcosphere(float radius, int iterations)
		{
			return null;
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xAB45C0", Offset = "0xAB45C0", VA = "0xAB45C0")]
		public static Mesh BuildIcosahedron(float radius)
		{
			return null;
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xAB4A80", Offset = "0xAB4A80", VA = "0xAB4A80")]
		private static void Refine(Mesh m)
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class ReadPanoConfig : MonoBehaviour
	{
		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string iniPath;

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xAB5568", Offset = "0xAB5568", VA = "0xAB5568")]
		private void Start()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xAB5E9C", Offset = "0xAB5E9C", VA = "0xAB5E9C")]
		private void WriteConfig(string path, CapturePanorama pano)
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xAB65F4", Offset = "0xAB65F4", VA = "0xAB65F4")]
		public ReadPanoConfig()
		{
		}
	}
}
namespace CapturePanorama.Internals
{
	[Token(Token = "0x2000125")]
	internal class ImageEffectCopyCamera : MonoBehaviour
	{
		[Token(Token = "0x200022B")]
		public struct InstanceMethodPair
		{
			[Token(Token = "0x4000B7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public object Instance;

			[Token(Token = "0x4000B7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MethodInfo Method;
		}

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<InstanceMethodPair> onRenderImageMethods;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RenderTexture[] temp;

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xAB4AEC", Offset = "0xAB4AEC", VA = "0xAB4AEC")]
		public static List<InstanceMethodPair> GenerateMethodList(Camera camToCopy)
		{
			return null;
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xAB4D2C", Offset = "0xAB4D2C", VA = "0xAB4D2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xAB4E48", Offset = "0xAB4E48", VA = "0xAB4E48")]
		private void OnRenderImage(RenderTexture src, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xAB5404", Offset = "0xAB5404", VA = "0xAB5404")]
		public ImageEffectCopyCamera()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class ScreenFadeControl : MonoBehaviour
	{
		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material fadeMaterial;

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xAB548C", Offset = "0xAB548C", VA = "0xAB548C")]
		private void OnCustomPostRender()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xAB5560", Offset = "0xAB5560", VA = "0xAB5560")]
		public ScreenFadeControl()
		{
		}
	}
}
namespace UltimateGameTools.MeshSimplifier
{
	[Serializable]
	[Token(Token = "0x2000127")]
	public class MeshUniqueVertices
	{
		[Serializable]
		[Token(Token = "0x200022C")]
		public class ListIndices
		{
			[Token(Token = "0x4000B7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<int> m_listIndices;

			[Token(Token = "0x6000B91")]
			[Address(RVA = "0x991DF8", Offset = "0x991DF8", VA = "0x991DF8")]
			public ListIndices()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200022D")]
		public class SerializableBoneWeight
		{
			[Token(Token = "0x4000B7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int _boneIndex0;

			[Token(Token = "0x4000B80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int _boneIndex1;

			[Token(Token = "0x4000B81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int _boneIndex2;

			[Token(Token = "0x4000B82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int _boneIndex3;

			[Token(Token = "0x4000B83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float _boneWeight0;

			[Token(Token = "0x4000B84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float _boneWeight1;

			[Token(Token = "0x4000B85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float _boneWeight2;

			[Token(Token = "0x4000B86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float _boneWeight3;

			[Token(Token = "0x6000B92")]
			[Address(RVA = "0x992000", Offset = "0x992000", VA = "0x992000")]
			public SerializableBoneWeight(BoneWeight boneWeight)
			{
			}

			[Token(Token = "0x6000B93")]
			[Address(RVA = "0x9920C8", Offset = "0x9920C8", VA = "0x9920C8")]
			public BoneWeight ToBoneWeight()
			{
				return default(BoneWeight);
			}
		}

		[Token(Token = "0x200022E")]
		public class UniqueVertex
		{
			[Token(Token = "0x4000B87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int m_nFixedX;

			[Token(Token = "0x4000B88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int m_nFixedY;

			[Token(Token = "0x4000B89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int m_nFixedZ;

			[Token(Token = "0x4000B8A")]
			private const float fDecimalMultiplier = 100000f;

			[Token(Token = "0x6000B94")]
			[Address(RVA = "0x992180", Offset = "0x992180", VA = "0x992180", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B95")]
			[Address(RVA = "0x992240", Offset = "0x992240", VA = "0x992240", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000B96")]
			[Address(RVA = "0x991E6C", Offset = "0x991E6C", VA = "0x991E6C")]
			public UniqueVertex(Vector3 v3Vertex)
			{
			}

			[Token(Token = "0x6000B97")]
			[Address(RVA = "0x9922A0", Offset = "0x9922A0", VA = "0x9922A0")]
			public Vector3 ToVertex()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000B98")]
			[Address(RVA = "0x992350", Offset = "0x992350", VA = "0x992350")]
			public static bool operator ==(UniqueVertex a, UniqueVertex b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B99")]
			[Address(RVA = "0x99236C", Offset = "0x99236C", VA = "0x99236C")]
			public static bool operator !=(UniqueVertex a, UniqueVertex b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B9A")]
			[Address(RVA = "0x992254", Offset = "0x992254", VA = "0x992254")]
			private void FromVertex(Vector3 vertex)
			{
			}

			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x992398", Offset = "0x992398", VA = "0x992398")]
			private int CoordToFixed(float fCoord)
			{
				return default(int);
			}

			[Token(Token = "0x6000B9C")]
			[Address(RVA = "0x99232C", Offset = "0x99232C", VA = "0x99232C")]
			private float FixedToCoord(int nFixed)
			{
				return default(float);
			}
		}

		[Token(Token = "0x200022F")]
		private class RepeatedVertex
		{
			[Token(Token = "0x4000B8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _nFaceIndex;

			[Token(Token = "0x4000B8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int _nOriginalVertexIndex;

			[Token(Token = "0x17000085")]
			public int FaceIndex
			{
				[Token(Token = "0x6000B9D")]
				[Address(RVA = "0x9920B0", Offset = "0x9920B0", VA = "0x9920B0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000086")]
			public int OriginalVertexIndex
			{
				[Token(Token = "0x6000B9E")]
				[Address(RVA = "0x9920B8", Offset = "0x9920B8", VA = "0x9920B8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000B9F")]
			[Address(RVA = "0x991EBC", Offset = "0x991EBC", VA = "0x991EBC")]
			public RepeatedVertex(int nFaceIndex, int nOriginalVertexIndex)
			{
			}
		}

		[Token(Token = "0x2000230")]
		private class RepeatedVertexList
		{
			[Token(Token = "0x4000B8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int m_nUniqueIndex;

			[Token(Token = "0x4000B8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<RepeatedVertex> m_listRepeatedVertices;

			[Token(Token = "0x17000087")]
			public int UniqueIndex
			{
				[Token(Token = "0x6000BA0")]
				[Address(RVA = "0x9920C0", Offset = "0x9920C0", VA = "0x9920C0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0x991F5C", Offset = "0x991F5C", VA = "0x991F5C")]
			public RepeatedVertexList(int nUniqueIndex, RepeatedVertex repeatedVertex)
			{
			}

			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0x991EF4", Offset = "0x991EF4", VA = "0x991EF4")]
			public void Add(RepeatedVertex repeatedVertex)
			{
			}
		}

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<Vector3> m_listVertices;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Vector3> m_listVerticesWorld;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<SerializableBoneWeight> m_listBoneWeights;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ListIndices[] m_aFaceList;

		[Token(Token = "0x1700002D")]
		public ListIndices[] SubmeshesFaceList
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0x99183C", Offset = "0x99183C", VA = "0x99183C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public List<Vector3> ListVertices
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x991844", Offset = "0x991844", VA = "0x991844")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public List<Vector3> ListVerticesWorld
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0x99184C", Offset = "0x99184C", VA = "0x99184C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public List<SerializableBoneWeight> ListBoneWeights
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x991854", Offset = "0x991854", VA = "0x991854")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x99185C", Offset = "0x99185C", VA = "0x99185C")]
		public void BuildData(Mesh sourceMesh, Vector3[] av3VerticesWorld)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x9920A8", Offset = "0x9920A8", VA = "0x9920A8")]
		public MeshUniqueVertices()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000128")]
	public class RelevanceSphere
	{
		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bExpanded;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 m_v3Position;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 m_v3Rotation;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 m_v3Scale;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m_fRelevance;

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x992430", Offset = "0x992430", VA = "0x992430")]
		public RelevanceSphere()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x9924AC", Offset = "0x9924AC", VA = "0x9924AC")]
		public void SetDefault(Transform target, float fRelevance)
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class Simplifier : MonoBehaviour
	{
		[Token(Token = "0x2000231")]
		public delegate void ProgressDelegate(string strTitle, string strProgressMessage, float fT);

		[Token(Token = "0x2000232")]
		private class Triangle
		{
			[Token(Token = "0x4000B8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vertex[] m_aVertices;

			[Token(Token = "0x4000B90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool m_bUVData;

			[Token(Token = "0x4000B91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int[] m_aUV;

			[Token(Token = "0x4000B92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int[] m_aIndices;

			[Token(Token = "0x4000B93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 m_v3Normal;

			[Token(Token = "0x4000B94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int m_nSubMesh;

			[Token(Token = "0x17000088")]
			public Vertex[] Vertices
			{
				[Token(Token = "0x6000BA7")]
				[Address(RVA = "0xD33D54", Offset = "0xD33D54", VA = "0xD33D54")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			public bool HasUVData
			{
				[Token(Token = "0x6000BA8")]
				[Address(RVA = "0xD33D5C", Offset = "0xD33D5C", VA = "0xD33D5C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008A")]
			public int[] IndicesUV
			{
				[Token(Token = "0x6000BA9")]
				[Address(RVA = "0xD33D64", Offset = "0xD33D64", VA = "0xD33D64")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			public Vector3 Normal
			{
				[Token(Token = "0x6000BAA")]
				[Address(RVA = "0xD33D6C", Offset = "0xD33D6C", VA = "0xD33D6C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008C")]
			public int[] Indices
			{
				[Token(Token = "0x6000BAB")]
				[Address(RVA = "0xD33D78", Offset = "0xD33D78", VA = "0xD33D78")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0xD33D80", Offset = "0xD33D80", VA = "0xD33D80")]
			public Triangle(Simplifier simplifier, int nSubMesh, Vertex v0, Vertex v1, Vertex v2, bool bUVData, int nIndex1, int nIndex2, int nIndex3)
			{
			}

			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0xD34260", Offset = "0xD34260", VA = "0xD34260")]
			public void Destructor(Simplifier simplifier)
			{
			}

			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0xD344C4", Offset = "0xD344C4", VA = "0xD344C4")]
			public bool HasVertex(Vertex v)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BAF")]
			[Address(RVA = "0xD340D4", Offset = "0xD340D4", VA = "0xD340D4")]
			public void ComputeNormal()
			{
			}

			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0xD34530", Offset = "0xD34530", VA = "0xD34530")]
			public int TexAt(Vertex vertex)
			{
				return default(int);
			}

			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0xD3461C", Offset = "0xD3461C", VA = "0xD3461C")]
			public int TexAt(int i)
			{
				return default(int);
			}

			[Token(Token = "0x6000BB2")]
			[Address(RVA = "0xD34658", Offset = "0xD34658", VA = "0xD34658")]
			public void SetTexAt(Vertex vertex, int uv)
			{
			}

			[Token(Token = "0x6000BB3")]
			[Address(RVA = "0xD3474C", Offset = "0xD3474C", VA = "0xD3474C")]
			public void SetTexAt(int i, int uv)
			{
			}

			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0xD34788", Offset = "0xD34788", VA = "0xD34788")]
			public void ReplaceVertex(Vertex vold, Vertex vnew)
			{
			}
		}

		[Token(Token = "0x2000233")]
		private class TriangleList
		{
			[Token(Token = "0x4000B95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Triangle> m_listTriangles;

			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0xD33BB4", Offset = "0xD33BB4", VA = "0xD33BB4")]
			public TriangleList()
			{
			}
		}

		[Token(Token = "0x2000234")]
		private class Vertex
		{
			[Token(Token = "0x4000B96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 m_v3Position;

			[Token(Token = "0x4000B97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 m_v3PositionWorld;

			[Token(Token = "0x4000B98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool m_bHasBoneWeight;

			[Token(Token = "0x4000B99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public BoneWeight m_boneWeight;

			[Token(Token = "0x4000B9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public int m_nID;

			[Token(Token = "0x4000B9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public List<Vertex> m_listNeighbors;

			[Token(Token = "0x4000B9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<Triangle> m_listFaces;

			[Token(Token = "0x4000B9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float m_fObjDist;

			[Token(Token = "0x4000B9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Vertex m_collapse;

			[Token(Token = "0x4000B9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public int m_nHeapSpot;

			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0xD349F0", Offset = "0xD349F0", VA = "0xD349F0")]
			public Vertex(Simplifier simplifier, Vector3 v, Vector3 v3World, bool bHasBoneWeight, BoneWeight boneWeight, int nID)
			{
			}

			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0xD34B20", Offset = "0xD34B20", VA = "0xD34B20")]
			public void Destructor(Simplifier simplifier)
			{
			}

			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0xD343D8", Offset = "0xD343D8", VA = "0xD343D8")]
			public void RemoveIfNonNeighbor(Vertex n)
			{
			}

			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0xD34BF4", Offset = "0xD34BF4", VA = "0xD34BF4")]
			public bool IsBorder()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000235")]
		private class VertexDataHashComparer : IEqualityComparer<VertexDataHash>
		{
			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0xD35040", Offset = "0xD35040", VA = "0xD35040", Slot = "4")]
			public bool Equals(VertexDataHash a, VertexDataHash b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0xD351CC", Offset = "0xD351CC", VA = "0xD351CC", Slot = "5")]
			public int GetHashCode(VertexDataHash vdata)
			{
				return default(int);
			}

			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0xD351EC", Offset = "0xD351EC", VA = "0xD351EC")]
			public VertexDataHashComparer()
			{
			}
		}

		[Token(Token = "0x2000236")]
		private class VertexDataHash
		{
			[Token(Token = "0x4000BA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector3 _v3Vertex;

			[Token(Token = "0x4000BA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector3 _v3Normal;

			[Token(Token = "0x4000BA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector2 _v2Mapping1;

			[Token(Token = "0x4000BA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector2 _v2Mapping2;

			[Token(Token = "0x4000BA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Color32 _color;

			[Token(Token = "0x4000BA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private MeshUniqueVertices.UniqueVertex _uniqueVertex;

			[Token(Token = "0x1700008D")]
			public Vector3 Vertex
			{
				[Token(Token = "0x6000BBD")]
				[Address(RVA = "0xD34D04", Offset = "0xD34D04", VA = "0xD34D04")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008E")]
			public Vector3 Normal
			{
				[Token(Token = "0x6000BBE")]
				[Address(RVA = "0xD34D10", Offset = "0xD34D10", VA = "0xD34D10")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008F")]
			public Vector2 UV1
			{
				[Token(Token = "0x6000BBF")]
				[Address(RVA = "0xD34D1C", Offset = "0xD34D1C", VA = "0xD34D1C")]
				get
				{
					return default(Vector2);
				}
			}

			[Token(Token = "0x17000090")]
			public Vector2 UV2
			{
				[Token(Token = "0x6000BC0")]
				[Address(RVA = "0xD34D24", Offset = "0xD34D24", VA = "0xD34D24")]
				get
				{
					return default(Vector2);
				}
			}

			[Token(Token = "0x17000091")]
			public Color32 Color
			{
				[Token(Token = "0x6000BC1")]
				[Address(RVA = "0xD34D2C", Offset = "0xD34D2C", VA = "0xD34D2C")]
				get
				{
					return default(Color32);
				}
			}

			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0xD34D34", Offset = "0xD34D34", VA = "0xD34D34")]
			public VertexDataHash(Vector3 v3Vertex, Vector3 v3Normal, Vector2 v2Mapping1, Vector2 v2Mapping2, Color32 color)
			{
			}

			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0xD34E1C", Offset = "0xD34E1C", VA = "0xD34E1C", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0xD34FD8", Offset = "0xD34FD8", VA = "0xD34FD8", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0xD34FF8", Offset = "0xD34FF8", VA = "0xD34FF8")]
			public static bool operator ==(VertexDataHash a, VertexDataHash b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0xD35014", Offset = "0xD35014", VA = "0xD35014")]
			public static bool operator !=(VertexDataHash a, VertexDataHash b)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000237")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77918C", Offset = "0x77918C")]
		private sealed class <ProgressiveMesh>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Simplifier <>4__this;

			[Token(Token = "0x4000BA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Mesh sourceMesh;

			[Token(Token = "0x4000BAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject gameObject;

			[Token(Token = "0x4000BAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ProgressDelegate progress;

			[Token(Token = "0x4000BAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string strProgressDisplayObjectName;

			[Token(Token = "0x4000BAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public RelevanceSphere[] aRelevanceSpheres;

			[Token(Token = "0x4000BAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int <nVertices>5__2;

			[Token(Token = "0x17000092")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BCA")]
				[Address(RVA = "0xD33C28", Offset = "0xD33C28", VA = "0xD33C28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BCC")]
				[Address(RVA = "0xD33C90", Offset = "0xD33C90", VA = "0xD33C90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0xD32DA4", Offset = "0xD32DA4", VA = "0xD32DA4")]
			[DebuggerHidden]
			public <ProgressiveMesh>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0xD32DD0", Offset = "0xD32DD0", VA = "0xD32DD0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0xD32DD4", Offset = "0xD32DD4", VA = "0xD32DD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0xD33C30", Offset = "0xD33C30", VA = "0xD33C30", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000238")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77919C", Offset = "0x77919C")]
		private sealed class <ComputeMeshWithVertexCount>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Simplifier <>4__this;

			[Token(Token = "0x4000BB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int nVertices;

			[Token(Token = "0x4000BB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Mesh meshOut;

			[Token(Token = "0x4000BB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public GameObject gameObject;

			[Token(Token = "0x4000BB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public ProgressDelegate progress;

			[Token(Token = "0x4000BB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string strProgressDisplayObjectName;

			[Token(Token = "0x4000BB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private List<Vertex> <listVertices>5__2;

			[Token(Token = "0x4000BB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int <nTotalVertices>5__3;

			[Token(Token = "0x17000094")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BD0")]
				[Address(RVA = "0x995D10", Offset = "0x995D10", VA = "0x995D10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BD2")]
				[Address(RVA = "0x995D78", Offset = "0x995D78", VA = "0x995D78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x992924", Offset = "0x992924", VA = "0x992924")]
			[DebuggerHidden]
			public <ComputeMeshWithVertexCount>d__25(int <>1__state)
			{
			}

			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x995200", Offset = "0x995200", VA = "0x995200", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x995204", Offset = "0x995204", VA = "0x995204", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BD1")]
			[Address(RVA = "0x995D18", Offset = "0x995D18", VA = "0x995D18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000239")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7791AC", Offset = "0x7791AC")]
		private sealed class <ConsolidateMesh>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Mesh meshIn;

			[Token(Token = "0x4000BBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TriangleList[] aListTriangles;

			[Token(Token = "0x4000BBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ProgressDelegate progress;

			[Token(Token = "0x4000BBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string strProgressDisplayObjectName;

			[Token(Token = "0x4000BBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Mesh meshOut;

			[Token(Token = "0x4000BC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public GameObject gameObject;

			[Token(Token = "0x4000BC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Vector3[] <av3NormalsIn>5__2;

			[Token(Token = "0x4000BC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector4[] <av4TangentsIn>5__3;

			[Token(Token = "0x4000BC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector2[] <av2Mapping1In>5__4;

			[Token(Token = "0x4000BC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector2[] <av2Mapping2In>5__5;

			[Token(Token = "0x4000BC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Color[] <acolColorsIn>5__6;

			[Token(Token = "0x4000BC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Color32[] <aColors32In>5__7;

			[Token(Token = "0x4000BC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private List<List<int>> <listlistIndicesOut>5__8;

			[Token(Token = "0x4000BC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private List<Vector3> <listVerticesOut>5__9;

			[Token(Token = "0x4000BC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private List<Vector3> <listNormalsOut>5__10;

			[Token(Token = "0x4000BCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private List<Vector4> <listTangentsOut>5__11;

			[Token(Token = "0x4000BCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private List<Vector2> <listMapping1Out>5__12;

			[Token(Token = "0x4000BCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private List<Vector2> <listMapping2Out>5__13;

			[Token(Token = "0x4000BCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private List<Color32> <listColors32Out>5__14;

			[Token(Token = "0x4000BCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private List<BoneWeight> <listBoneWeightsOut>5__15;

			[Token(Token = "0x4000BCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Dictionary<VertexDataHash, int> <dicVertexDataHash2Index>5__16;

			[Token(Token = "0x4000BD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private bool <bUV1>5__17;

			[Token(Token = "0x4000BD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
			private bool <bUV2>5__18;

			[Token(Token = "0x4000BD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
			private bool <bNormal>5__19;

			[Token(Token = "0x4000BD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCB")]
			private bool <bTangent>5__20;

			[Token(Token = "0x4000BD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int <nSubMesh>5__21;

			[Token(Token = "0x4000BD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private List<int> <listIndicesOut>5__22;

			[Token(Token = "0x4000BD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private string <strMesh>5__23;

			[Token(Token = "0x4000BD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private int <i>5__24;

			[Token(Token = "0x17000096")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BD6")]
				[Address(RVA = "0x996DB4", Offset = "0x996DB4", VA = "0x996DB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BD8")]
				[Address(RVA = "0x996E1C", Offset = "0x996E1C", VA = "0x996E1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x993348", Offset = "0x993348", VA = "0x993348")]
			[DebuggerHidden]
			public <ConsolidateMesh>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x995D80", Offset = "0x995D80", VA = "0x995D80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x995D84", Offset = "0x995D84", VA = "0x995D84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x996DBC", Offset = "0x996DBC", VA = "0x996DBC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200023A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7791BC", Offset = "0x7791BC")]
		private sealed class <ComputeAllEdgeCollapseCosts>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ProgressDelegate progress;

			[Token(Token = "0x4000BDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string strProgressDisplayObjectName;

			[Token(Token = "0x4000BDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Simplifier <>4__this;

			[Token(Token = "0x4000BDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform transform;

			[Token(Token = "0x4000BDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RelevanceSphere[] aRelevanceSpheres;

			[Token(Token = "0x4000BDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <i>5__2;

			[Token(Token = "0x17000098")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BDC")]
				[Address(RVA = "0x995190", Offset = "0x995190", VA = "0x995190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000099")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BDE")]
				[Address(RVA = "0x9951F8", Offset = "0x9951F8", VA = "0x9951F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x993C70", Offset = "0x993C70", VA = "0x993C70")]
			[DebuggerHidden]
			public <ComputeAllEdgeCollapseCosts>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x994E2C", Offset = "0x994E2C", VA = "0x994E2C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x994E30", Offset = "0x994E30", VA = "0x994E30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0x995198", Offset = "0x995198", VA = "0x995198", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77A3A4", Offset = "0x77A3A4")]
		private static bool <Cancelled>k__BackingField;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77A3B4", Offset = "0x77A3B4")]
		private bool <CoroutineEnded>k__BackingField;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int m_nCoroutineFrameMiliseconds;

		[Token(Token = "0x4000700")]
		private const float MAX_VERTEX_COLLAPSE_COST = 10000000f;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Vertex> m_listVertices;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Vertex> m_listHeap;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TriangleList[] m_aListTriangles;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private int m_nOriginalMeshVertexCount;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		private float m_fOriginalMeshSize;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private List<int> m_listVertexMap;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private List<int> m_listVertexPermutationBack;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private MeshUniqueVertices m_meshUniqueVertices;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private Mesh m_meshOriginal;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private bool m_bUseEdgeLength;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		[HideInInspector]
		private bool m_bUseCurvature;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		[SerializeField]
		[HideInInspector]
		private bool m_bProtectTexture;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		[SerializeField]
		[HideInInspector]
		private bool m_bLockBorder;

		[Token(Token = "0x17000031")]
		public static bool Cancelled
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x9925C8", Offset = "0x9925C8", VA = "0x9925C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77BB0C", Offset = "0x77BB0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x992630", Offset = "0x992630", VA = "0x992630")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77BB1C", Offset = "0x77BB1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public static int CoroutineFrameMiliseconds
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x9926A0", Offset = "0x9926A0", VA = "0x9926A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x992708", Offset = "0x992708", VA = "0x992708")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool CoroutineEnded
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x992774", Offset = "0x992774", VA = "0x992774")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77BB2C", Offset = "0x77BB2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x99277C", Offset = "0x99277C", VA = "0x99277C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77BB3C", Offset = "0x77BB3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool UseEdgeLength
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x992788", Offset = "0x992788", VA = "0x992788")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x992790", Offset = "0x992790", VA = "0x992790")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public bool UseCurvature
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x99279C", Offset = "0x99279C", VA = "0x99279C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x9927A4", Offset = "0x9927A4", VA = "0x9927A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public bool ProtectTexture
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x9927B0", Offset = "0x9927B0", VA = "0x9927B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x9927B8", Offset = "0x9927B8", VA = "0x9927B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool LockBorder
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x9927C4", Offset = "0x9927C4", VA = "0x9927C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x9927CC", Offset = "0x9927CC", VA = "0x9927CC")]
			set
			{
			}
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x9927D8", Offset = "0x9927D8", VA = "0x9927D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77BB4C", Offset = "0x77BB4C")]
		public IEnumerator ProgressiveMesh(GameObject gameObject, Mesh sourceMesh, RelevanceSphere[] aRelevanceSpheres, string strProgressDisplayObjectName = "", [Optional] ProgressDelegate progress)
		{
			return null;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x99287C", Offset = "0x99287C", VA = "0x99287C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77BBB0", Offset = "0x77BBB0")]
		public IEnumerator ComputeMeshWithVertexCount(GameObject gameObject, Mesh meshOut, int nVertices, string strProgressDisplayObjectName = "", [Optional] ProgressDelegate progress)
		{
			return null;
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x992950", Offset = "0x992950", VA = "0x992950")]
		public int GetOriginalMeshUniqueVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x992958", Offset = "0x992958", VA = "0x992958")]
		public int GetOriginalMeshTriangleCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x99299C", Offset = "0x99299C", VA = "0x99299C")]
		public static Vector3[] GetWorldVertices(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x9932A4", Offset = "0x9932A4", VA = "0x9932A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77BC14", Offset = "0x77BC14")]
		private IEnumerator ConsolidateMesh(GameObject gameObject, Mesh meshIn, Mesh meshOut, TriangleList[] aListTriangles, Vector3[] av3Vertices, string strProgressDisplayObjectName = "", [Optional] ProgressDelegate progress)
		{
			return null;
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x993374", Offset = "0x993374", VA = "0x993374")]
		private int MapVertex(int nVertex, int nMax)
		{
			return default(int);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x99340C", Offset = "0x99340C", VA = "0x99340C")]
		private float ComputeEdgeCollapseCost(Vertex u, Vertex v, float fRelevanceBias)
		{
			return default(float);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x9938C8", Offset = "0x9938C8", VA = "0x9938C8")]
		private void ComputeEdgeCostAtVertex(Vertex v, Transform transform, RelevanceSphere[] aRelevanceSpheres)
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x993BD8", Offset = "0x993BD8", VA = "0x993BD8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x77BC78", Offset = "0x77BC78")]
		private IEnumerator ComputeAllEdgeCollapseCosts(string strProgressDisplayObjectName, Transform transform, RelevanceSphere[] aRelevanceSpheres, [Optional] ProgressDelegate progress)
		{
			return null;
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x993C9C", Offset = "0x993C9C", VA = "0x993C9C")]
		private void Collapse(Vertex u, Vertex v, bool bRecompute, Transform transform, RelevanceSphere[] aRelevanceSpheres)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x9945B0", Offset = "0x9945B0", VA = "0x9945B0")]
		private void AddVertices(List<Vector3> listVertices, List<Vector3> listVerticesWorld, List<MeshUniqueVertices.SerializableBoneWeight> listBoneWeights)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x994768", Offset = "0x994768", VA = "0x994768")]
		private void AddFaceListSubMesh(int nSubMesh, List<int> listTriangles, int[] anIndices, Vector2[] v2Mapping)
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x994A08", Offset = "0x994A08", VA = "0x994A08")]
		private void ShareUV(Vector2[] aMapping, Triangle t)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x994C1C", Offset = "0x994C1C", VA = "0x994C1C")]
		private Vertex MinimumCostEdge()
		{
			return null;
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x994CC0", Offset = "0x994CC0", VA = "0x994CC0")]
		private float HeapValue(int i)
		{
			return default(float);
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x9941E4", Offset = "0x9941E4", VA = "0x9941E4")]
		private void HeapSortUp(int k)
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x9943B8", Offset = "0x9943B8", VA = "0x9943B8")]
		private void HeapSortDown(int k)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x994D8C", Offset = "0x994D8C", VA = "0x994D8C")]
		private void HeapAdd(Vertex v)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x994C20", Offset = "0x994C20", VA = "0x994C20")]
		private Vertex HeapPop()
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x994E0C", Offset = "0x994E0C", VA = "0x994E0C")]
		public Simplifier()
		{
		}
	}
}
