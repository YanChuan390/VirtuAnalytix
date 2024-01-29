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
	[Address(RVA = "0x197E4AC", Offset = "0x197E4AC", VA = "0x197E4AC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x197EAA4", Offset = "0x197EAA4", VA = "0x197EAA4")]
	private void OnBuiltAtlasesSuccess()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x197ECAC", Offset = "0x197ECAC", VA = "0x197ECAC")]
	public BakeTexturesAtRuntime()
	{
	}
}
[Token(Token = "0x2000003")]
public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x197ED1C", Offset = "0x197ED1C", VA = "0x197ED1C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x197EDFC", Offset = "0x197EDFC", VA = "0x197EDFC")]
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

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x19808A0", Offset = "0x19808A0", VA = "0x19808A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1980A00", Offset = "0x1980A00", VA = "0x1980A00")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1980C74", Offset = "0x1980C74", VA = "0x1980C74")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1981200", Offset = "0x1981200", VA = "0x1981200")]
	public MB_SwapShirts()
	{
	}
}
[Token(Token = "0x2000005")]
public class MB_PrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x197F80C", Offset = "0x197F80C", VA = "0x197F80C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x197F8EC", Offset = "0x197F8EC", VA = "0x197F8EC")]
	public MB_PrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x2000006")]
public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DC18C", Offset = "0x6DC18C")]
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
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x19817C0", Offset = "0x19817C0", VA = "0x19817C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x1981808", Offset = "0x1981808", VA = "0x1981808", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x197F324", Offset = "0x197F324", VA = "0x197F324")]
		[DebuggerHidden]
		public <largeNumber>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1981640", Offset = "0x1981640", VA = "0x1981640", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1981644", Offset = "0x1981644", VA = "0x1981644", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x19817C8", Offset = "0x19817C8", VA = "0x19817C8", Slot = "8")]
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

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x197EE04", Offset = "0x197EE04", VA = "0x197EE04")]
	private float GaussianValue()
	{
		return default(float);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x197EE9C", Offset = "0x197EE9C", VA = "0x197EE9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x197F2AC", Offset = "0x197F2AC", VA = "0x197F2AC")]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x197F350", Offset = "0x197F350", VA = "0x197F350")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x197F430", Offset = "0x197F430", VA = "0x197F430")]
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

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x197F4B4", Offset = "0x197F4B4", VA = "0x197F4B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x197F510", Offset = "0x197F510", VA = "0x197F510")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x197F59C", Offset = "0x197F59C", VA = "0x197F59C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x197F67C", Offset = "0x197F67C", VA = "0x197F67C")]
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

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x197F684", Offset = "0x197F684", VA = "0x197F684")]
	private void Update()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x197F71C", Offset = "0x197F71C", VA = "0x197F71C")]
	public MB_ExampleMover()
	{
	}
}
[Token(Token = "0x200000A")]
public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x197F724", Offset = "0x197F724", VA = "0x197F724")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x197F804", Offset = "0x197F804", VA = "0x197F804")]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
[Token(Token = "0x200000B")]
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

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x197F8F4", Offset = "0x197F8F4", VA = "0x197F8F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x197FAF4", Offset = "0x197FAF4", VA = "0x197FAF4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1980780", Offset = "0x1980780", VA = "0x1980780")]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1980898", Offset = "0x1980898", VA = "0x1980898")]
	public MB_SkinnedMeshSceneController()
	{
	}
}
[Token(Token = "0x200000C")]
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

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1981208", Offset = "0x1981208", VA = "0x1981208")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x19812E8", Offset = "0x19812E8", VA = "0x19812E8")]
	public void Start()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x198138C", Offset = "0x198138C", VA = "0x198138C")]
	public void Update()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1981638", Offset = "0x1981638", VA = "0x1981638")]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
