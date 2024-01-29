using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class BakeTexturesAtRuntime : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	private float elapsedTime;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	private MB3_TextureCombiner.CreateAtlasesCoroutineResult result;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1735688", Offset = "0x1735688", VA = "0x1735688")]
	public string GetShaderNameForPipeline()
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1735718", Offset = "0x1735718", VA = "0x1735718")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1735CE4", Offset = "0x1735CE4", VA = "0x1735CE4")]
	private void OnBuiltAtlasesSuccess()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1735EEC", Offset = "0x1735EEC", VA = "0x1735EEC")]
	public BakeTexturesAtRuntime()
	{
	}
}
[Token(Token = "0x2000003")]
public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1735F50", Offset = "0x1735F50", VA = "0x1735F50")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1736030", Offset = "0x1736030", VA = "0x1736030")]
	public MB_BatchPrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x2000004")]
public class MB_SwapShirts : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x20")]
	public Renderer[] clothingAndBodyPartsBareTorso;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x28")]
	public Renderer[] clothingAndBodyPartsBareTorsoDamagedArm;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x30")]
	public Renderer[] clothingAndBodyPartsHoodie;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x17379CC", Offset = "0x17379CC", VA = "0x17379CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1737B14", Offset = "0x1737B14", VA = "0x1737B14")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1737D88", Offset = "0x1737D88", VA = "0x1737D88")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1738314", Offset = "0x1738314", VA = "0x1738314")]
	public MB_SwapShirts()
	{
	}
}
[Token(Token = "0x2000005")]
public class MB_PrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x17369FC", Offset = "0x17369FC", VA = "0x17369FC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1736ADC", Offset = "0x1736ADC", VA = "0x1736ADC")]
	public MB_PrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x2000006")]
public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C1808", Offset = "0x6C1808")]
	private sealed class <largeNumber>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x20")]
		public MB_DynamicAddDeleteExample <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x17389B8", Offset = "0x17389B8", VA = "0x17389B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x1738A00", Offset = "0x1738A00", VA = "0x1738A00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1736518", Offset = "0x1736518", VA = "0x1736518")]
		[DebuggerHidden]
		public <largeNumber>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1738854", Offset = "0x1738854", VA = "0x1738854", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1738858", Offset = "0x1738858", VA = "0x1738858", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x17389C0", Offset = "0x17389C0", VA = "0x17389C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x18")]
	public GameObject prefab;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x20")]
	private List<GameObject> objsInCombined;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x28")]
	private MB3_MultiMeshBaker mbd;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x30")]
	private GameObject[] objs;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1736038", Offset = "0x1736038", VA = "0x1736038")]
	private float GaussianValue()
	{
		return default(float);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x17360D0", Offset = "0x17360D0", VA = "0x17360D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x17364AC", Offset = "0x17364AC", VA = "0x17364AC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6C1828", Offset = "0x6C1828")]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1736544", Offset = "0x1736544", VA = "0x1736544")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1736624", Offset = "0x1736624", VA = "0x1736624")]
	public MB_DynamicAddDeleteExample()
	{
	}
}
[Token(Token = "0x2000008")]
public class MB_Example : MonoBehaviour
{
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshbaker;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] objsToCombine;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x173669C", Offset = "0x173669C", VA = "0x173669C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x17366F8", Offset = "0x17366F8", VA = "0x17366F8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1736784", Offset = "0x1736784", VA = "0x1736784")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1736864", Offset = "0x1736864", VA = "0x1736864")]
	public MB_Example()
	{
	}
}
[Token(Token = "0x2000009")]
public class MB_ExampleMover : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x18")]
	public int axis;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x173686C", Offset = "0x173686C", VA = "0x173686C")]
	private void Update()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1736904", Offset = "0x1736904", VA = "0x1736904")]
	public MB_ExampleMover()
	{
	}
}
[Token(Token = "0x200000A")]
public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x173690C", Offset = "0x173690C", VA = "0x173690C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x17369EC", Offset = "0x17369EC", VA = "0x17369EC")]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
[Token(Token = "0x200000B")]
[ExecuteInEditMode]
public class MB_MigrateMaterialsToDifferentPipeline : MonoBehaviour
{
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x17369F4", Offset = "0x17369F4", VA = "0x17369F4")]
	public MB_MigrateMaterialsToDifferentPipeline()
	{
	}
}
[Token(Token = "0x200000C")]
public class MB_SkinnedMeshSceneController : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x18")]
	public GameObject swordPrefab;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x20")]
	public GameObject hatPrefab;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x28")]
	public GameObject glassesPrefab;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x30")]
	public GameObject workerPrefab;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x38")]
	public GameObject targetCharacter;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x40")]
	public MB3_MeshBaker skinnedMeshBaker;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x48")]
	private GameObject swordInstance;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x50")]
	private GameObject glassesInstance;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x58")]
	private GameObject hatInstance;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1736AE4", Offset = "0x1736AE4", VA = "0x1736AE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1736CD8", Offset = "0x1736CD8", VA = "0x1736CD8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x17378AC", Offset = "0x17378AC", VA = "0x17378AC")]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x17379C4", Offset = "0x17379C4", VA = "0x17379C4")]
	public MB_SkinnedMeshSceneController()
	{
	}
}
[Token(Token = "0x200000D")]
public class MB_SwitchBakedObjectsTexture : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x18")]
	public MeshRenderer targetRenderer;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x20")]
	public Material[] materials;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x28")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x173831C", Offset = "0x173831C", VA = "0x173831C")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x17383FC", Offset = "0x17383FC", VA = "0x17383FC")]
	public void Start()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x17384A0", Offset = "0x17384A0", VA = "0x17384A0")]
	public void Update()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1738740", Offset = "0x1738740", VA = "0x1738740")]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
[Token(Token = "0x200000E")]
public class SCS : MonoBehaviour
{
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x18")]
	public Transform Player;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x20")]
	public float CloudsSpeed;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1738748", Offset = "0x1738748", VA = "0x1738748")]
	private void Update()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x173884C", Offset = "0x173884C", VA = "0x173884C")]
	public SCS()
	{
	}
}
