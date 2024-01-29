using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using JetBrains.Annotations;
using LevelEditorAPI;
using LevelEditorAPI.InternalPrefab;
using LevelEditorAPI.Utility;
using LevelEditorAPI.VR;
using PlayFab;
using PlayFab.ClientModels;
using RGCommon;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.XR;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000003")]
public class BakeTexturesAtRuntime : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float elapsedTime;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MB3_TextureCombiner.CreateAtlasesCoroutineResult result;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x7C6F2C", Offset = "0x7C6F2C", VA = "0x7C6F2C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x7C7434", Offset = "0x7C7434", VA = "0x7C7434")]
	private void OnBuiltAtlasesSuccess()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x7C7628", Offset = "0x7C7628", VA = "0x7C7628")]
	public BakeTexturesAtRuntime()
	{
	}
}
[Token(Token = "0x2000004")]
public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x7C7690", Offset = "0x7C7690", VA = "0x7C7690")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x7C7728", Offset = "0x7C7728", VA = "0x7C7728")]
	public MB_BatchPrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x2000005")]
public class MB_SwapShirts : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer[] clothingAndBodyPartsBareTorso;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer[] clothingAndBodyPartsBareTorsoDamagedArm;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Renderer[] clothingAndBodyPartsHoodie;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x7C7730", Offset = "0x7C7730", VA = "0x7C7730")]
	private void Start()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x7C7864", Offset = "0x7C7864", VA = "0x7C7864")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x7C79FC", Offset = "0x7C79FC", VA = "0x7C79FC")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x7C802C", Offset = "0x7C802C", VA = "0x7C802C")]
	public MB_SwapShirts()
	{
	}
}
[Token(Token = "0x2000006")]
public class MB_PrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x7C8034", Offset = "0x7C8034", VA = "0x7C8034")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x7C80CC", Offset = "0x7C80CC", VA = "0x7C80CC")]
	public MB_PrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x2000007")]
public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	[Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class <largeNumber>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MB_DynamicAddDeleteExample <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x7C8878", Offset = "0x7C8878", VA = "0x7C8878", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x7C88C0", Offset = "0x7C88C0", VA = "0x7C88C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x7C85E4", Offset = "0x7C85E4", VA = "0x7C85E4")]
		[DebuggerHidden]
		public <largeNumber>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x7C8720", Offset = "0x7C8720", VA = "0x7C8720", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x7C8724", Offset = "0x7C8724", VA = "0x7C8724", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x7C8880", Offset = "0x7C8880", VA = "0x7C8880", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject prefab;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<GameObject> objsInCombined;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MB3_MultiMeshBaker mbd;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject[] objs;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x7C80D4", Offset = "0x7C80D4", VA = "0x7C80D4")]
	private float GaussianValue()
	{
		return default(float);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x7C8158", Offset = "0x7C8158", VA = "0x7C8158")]
	private void Start()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x7C857C", Offset = "0x7C857C", VA = "0x7C857C")]
	[IteratorStateMachine(typeof(<largeNumber>d__6))]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x7C860C", Offset = "0x7C860C", VA = "0x7C860C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x7C86A4", Offset = "0x7C86A4", VA = "0x7C86A4")]
	public MB_DynamicAddDeleteExample()
	{
	}
}
[Token(Token = "0x2000009")]
public class MB_Example : MonoBehaviour
{
	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshbaker;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] objsToCombine;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x7C88C8", Offset = "0x7C88C8", VA = "0x7C88C8")]
	private void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x7C8918", Offset = "0x7C8918", VA = "0x7C8918")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x7C8998", Offset = "0x7C8998", VA = "0x7C8998")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x7C8A30", Offset = "0x7C8A30", VA = "0x7C8A30")]
	public MB_Example()
	{
	}
}
[Token(Token = "0x200000A")]
public class MB_ExampleMover : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int axis;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x7C8A38", Offset = "0x7C8A38", VA = "0x7C8A38")]
	private void Update()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x7C8B68", Offset = "0x7C8B68", VA = "0x7C8B68")]
	public MB_ExampleMover()
	{
	}
}
[Token(Token = "0x200000B")]
public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x7C8B70", Offset = "0x7C8B70", VA = "0x7C8B70")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x7C8C08", Offset = "0x7C8C08", VA = "0x7C8C08")]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
[Token(Token = "0x200000C")]
public class MB_SkinnedMeshSceneController : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject swordPrefab;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject hatPrefab;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject glassesPrefab;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject workerPrefab;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject targetCharacter;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MB3_MeshBaker skinnedMeshBaker;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject swordInstance;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject glassesInstance;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject hatInstance;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x7C8C10", Offset = "0x7C8C10", VA = "0x7C8C10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x7C8DF8", Offset = "0x7C8DF8", VA = "0x7C8DF8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x7C99D4", Offset = "0x7C99D4", VA = "0x7C99D4")]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x7C9AE0", Offset = "0x7C9AE0", VA = "0x7C9AE0")]
	public MB_SkinnedMeshSceneController()
	{
	}
}
[Token(Token = "0x200000D")]
public class MB_SwitchBakedObjectsTexture : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer targetRenderer;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material[] materials;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x7C9AE8", Offset = "0x7C9AE8", VA = "0x7C9AE8")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x7C9B80", Offset = "0x7C9B80", VA = "0x7C9B80")]
	public void Start()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x7C9C20", Offset = "0x7C9C20", VA = "0x7C9C20")]
	public void Update()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x7C9EB0", Offset = "0x7C9EB0", VA = "0x7C9EB0")]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public struct SerializableVector3
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x7C9EB8", Offset = "0x7C9EB8", VA = "0x7C9EB8")]
	public SerializableVector3(float rX, float rY, float rZ)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x7C9EC4", Offset = "0x7C9EC4", VA = "0x7C9EC4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x7C9F88", Offset = "0x7C9F88", VA = "0x7C9F88")]
	public static implicit operator Vector3(SerializableVector3 rValue)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x7C9F8C", Offset = "0x7C9F8C", VA = "0x7C9F8C")]
	public static implicit operator SerializableVector3(Vector3 rValue)
	{
		return default(SerializableVector3);
	}
}
[Serializable]
[Token(Token = "0x200000F")]
public struct SerializableQuaternion
{
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float w;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x7C9F90", Offset = "0x7C9F90", VA = "0x7C9F90")]
	public SerializableQuaternion(float rX, float rY, float rZ, float rW)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x7C9F9C", Offset = "0x7C9F9C", VA = "0x7C9F9C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x7CA148", Offset = "0x7CA148", VA = "0x7CA148")]
	public static implicit operator Quaternion(SerializableQuaternion rValue)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x7CA14C", Offset = "0x7CA14C", VA = "0x7CA14C")]
	public static implicit operator SerializableQuaternion(Quaternion rValue)
	{
		return default(SerializableQuaternion);
	}
}
[Token(Token = "0x2000010")]
public sealed class Vector3SerializationSurrogate : ISerializationSurrogate
{
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x7CA150", Offset = "0x7CA150", VA = "0x7CA150", Slot = "4")]
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x7CA244", Offset = "0x7CA244", VA = "0x7CA244", Slot = "5")]
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x7CA440", Offset = "0x7CA440", VA = "0x7CA440")]
	public Vector3SerializationSurrogate()
	{
	}
}
[Token(Token = "0x2000011")]
public sealed class QuaternionSerializationSurrogate : ISerializationSurrogate
{
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x7CA448", Offset = "0x7CA448", VA = "0x7CA448", Slot = "4")]
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x7CA574", Offset = "0x7CA574", VA = "0x7CA574", Slot = "5")]
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x7CA7D0", Offset = "0x7CA7D0", VA = "0x7CA7D0")]
	public QuaternionSerializationSurrogate()
	{
	}
}
[Token(Token = "0x2000012")]
public class GhostComponent : MonoBehaviour
{
	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Collider col;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Rigidbody rb;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Animator anim;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 snapPosition;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Quaternion snapRotation;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Renderer[] renderers;

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x7CA7D8", Offset = "0x7CA7D8", VA = "0x7CA7D8")]
	public GhostComponent()
	{
	}
}
[Token(Token = "0x2000013")]
public class PigEvenListener : MonoBehaviour
{
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool muted;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x7CA7E0", Offset = "0x7CA7E0", VA = "0x7CA7E0")]
	public void piglaughlong()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x7CA888", Offset = "0x7CA888", VA = "0x7CA888")]
	public void bosspiglaugh()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x7CA930", Offset = "0x7CA930", VA = "0x7CA930")]
	public void piglaugshort()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x7CA9D8", Offset = "0x7CA9D8", VA = "0x7CA9D8")]
	public void pigtaunt()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x7CAA80", Offset = "0x7CAA80", VA = "0x7CAA80")]
	public void bosspigtaunt()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x7CAB28", Offset = "0x7CAB28", VA = "0x7CAB28")]
	public void pignoff()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x7CABD0", Offset = "0x7CABD0", VA = "0x7CABD0")]
	public void bosspignoff()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x7CAC78", Offset = "0x7CAC78", VA = "0x7CAC78")]
	public void pighello()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x7CAD20", Offset = "0x7CAD20", VA = "0x7CAD20")]
	public void piggrunt()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x7CADC8", Offset = "0x7CADC8", VA = "0x7CADC8")]
	public void pigfart()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x7CAE70", Offset = "0x7CAE70", VA = "0x7CAE70")]
	public void pigburp()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x7CAF18", Offset = "0x7CAF18", VA = "0x7CAF18")]
	public void piglaugh()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x7CAFC0", Offset = "0x7CAFC0", VA = "0x7CAFC0")]
	public void pigerf()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x7CB068", Offset = "0x7CB068", VA = "0x7CB068")]
	public void bosspigerf()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x7CB110", Offset = "0x7CB110", VA = "0x7CB110")]
	public void pigsnore()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x7CB1B8", Offset = "0x7CB1B8", VA = "0x7CB1B8")]
	public void pigangry()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x7CB260", Offset = "0x7CB260", VA = "0x7CB260")]
	public void bosspigangry()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x7CB308", Offset = "0x7CB308", VA = "0x7CB308")]
	public void pigjump()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x7CB3B0", Offset = "0x7CB3B0", VA = "0x7CB3B0")]
	public void bosspigjump()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x7CB458", Offset = "0x7CB458", VA = "0x7CB458")]
	public void pigscared()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x7CB45C", Offset = "0x7CB45C", VA = "0x7CB45C")]
	public void bosspigscared()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x7CB504", Offset = "0x7CB504", VA = "0x7CB504")]
	public void bosspigfrustrated()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x7CB5AC", Offset = "0x7CB5AC", VA = "0x7CB5AC")]
	public void pigterror()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x7CB654", Offset = "0x7CB654", VA = "0x7CB654")]
	public void pigfear()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x7CB6FC", Offset = "0x7CB6FC", VA = "0x7CB6FC")]
	public void hatchlingscore()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x7CB7A4", Offset = "0x7CB7A4", VA = "0x7CB7A4")]
	public void redscore()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x7CB84C", Offset = "0x7CB84C", VA = "0x7CB84C")]
	public void chuckscore()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x7CB8F4", Offset = "0x7CB8F4", VA = "0x7CB8F4")]
	public void bombscore()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x7CB99C", Offset = "0x7CB99C", VA = "0x7CB99C")]
	public void frankenhit()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x7CBA88", Offset = "0x7CBA88", VA = "0x7CBA88")]
	public PigEvenListener()
	{
	}
}
[Token(Token = "0x2000014")]
public class NetworkTest : MonoBehaviour
{
	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string levelIdToGet;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public NetworkHandler networkHandler;

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x7CBA90", Offset = "0x7CBA90", VA = "0x7CBA90")]
	public void Post(Level level)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x7CBA94", Offset = "0x7CBA94", VA = "0x7CBA94")]
	public void Get()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x7CBAB8", Offset = "0x7CBAB8", VA = "0x7CBAB8")]
	public NetworkTest()
	{
	}
}
[Token(Token = "0x2000015")]
public static class PalazzoTracking
{
	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string birdShot;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int iBird;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string location;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int timeSinceLastShot;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public static bool editedBirds;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public static bool editedTeleports;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static float editingStartTime;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static int numberOfBlockPlacements;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static int numberOfDeletes;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public static int numberOfTryPlays;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static int numberOfRotations;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public static int numberOfToolboxMoves;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static int numberOfTutorialPresses;

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x7CBAC0", Offset = "0x7CBAC0", VA = "0x7CBAC0")]
	[RuntimeInitializeOnLoadMethod]
	public static void Start()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x7CBB1C", Offset = "0x7CBB1C", VA = "0x7CBB1C")]
	private static void ResetSaveTrackingStats()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x7CBB64", Offset = "0x7CBB64", VA = "0x7CBB64")]
	private static void ResetEditingTrackingStats()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x7CBBB4", Offset = "0x7CBBB4", VA = "0x7CBBB4")]
	public static void SendLevelEndEvent(string type, int unusedBirdsCount, int score, int nStars, int levelIndex, string world, int remainingPigCount, int time)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x7CC0CC", Offset = "0x7CC0CC", VA = "0x7CC0CC")]
	public static void SendCustomLevelEndEvent(string type, int unusedBirdsCount, int levelIndex, int remainingPigCount, int time)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x7CC448", Offset = "0x7CC448", VA = "0x7CC448")]
	public static void SendOnlineLevelEndEvent(string type, int remainingBirdsCount, string levelCode, int remainingPigCount, int time, string authToken)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x7CC844", Offset = "0x7CC844", VA = "0x7CC844")]
	public static void SendLevelSaveEvent(string type, Level level, int blockMeter, bool anotherSlot)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x7CD0CC", Offset = "0x7CD0CC", VA = "0x7CD0CC")]
	public static void SendLeaveEditorEvent()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x7CCCB0", Offset = "0x7CCCB0", VA = "0x7CCCB0")]
	private static string GetBlockTypes(Level level)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x7CD610", Offset = "0x7CD610", VA = "0x7CD610")]
	public static void SetBirdShotEventData(string birdShot, int iBird, string location, int timeSinceLastShot)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x7CD68C", Offset = "0x7CD68C", VA = "0x7CD68C")]
	public static void SendBirdShotEvent(string hitTargetType, int levelIndex)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x7CDAB4", Offset = "0x7CDAB4", VA = "0x7CDAB4")]
	public static void SendRequestFailureEvent(string message, string url, string errorCode, float time)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x7CDDA0", Offset = "0x7CDDA0", VA = "0x7CDDA0")]
	public static void SendOnlineLevelSkippedEvent(string levelCode, float time, string authToken)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x7CE000", Offset = "0x7CE000", VA = "0x7CE000")]
	public static void SendOnlineLevelFavoritedEvent(string levelCode, string authToken)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x7CE1D0", Offset = "0x7CE1D0", VA = "0x7CE1D0")]
	public static void SendOnlineLevelUnfavoritedEvent(string levelCode, string authToken)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x7CE3A0", Offset = "0x7CE3A0", VA = "0x7CE3A0")]
	public static void SendOnlineLevelLikedEvent(string levelCode, string authToken)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x7CE570", Offset = "0x7CE570", VA = "0x7CE570")]
	public static void SendOnlineLevelDislikedEvent(string levelCode, string authToken)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x7CE740", Offset = "0x7CE740", VA = "0x7CE740")]
	public static void SendOnlineLevelRetriedEvent(string levelCode, float time, string authToken)
	{
	}
}
[Token(Token = "0x2000016")]
public class DbgInputDevice : PalazzoInputDevice
{
	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private DbgInputHand left;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private DbgInputHand right;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private DbgInputHand main;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private PlayerHandedness handedness;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform cameraPos;

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x7CE9A0", Offset = "0x7CE9A0", VA = "0x7CE9A0")]
	public DbgInputDevice(ARTransforms arTransforms)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x7CECC0", Offset = "0x7CECC0", VA = "0x7CECC0", Slot = "6")]
	public override void Tick()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x7CED30", Offset = "0x7CED30", VA = "0x7CED30")]
	public DbgInputHand GetHand(XRNode hand)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x7CED5C", Offset = "0x7CED5C", VA = "0x7CED5C", Slot = "9")]
	public override void Recenter()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x7CED60", Offset = "0x7CED60", VA = "0x7CED60", Slot = "10")]
	public override void PlayHaptic(HapticType hapticType, XRNode hand, [Optional] float? amplitude, bool playUntilStop = false)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x7CED64", Offset = "0x7CED64", VA = "0x7CED64", Slot = "11")]
	public override void StopHaptic(HapticType hapticType, XRNode hand)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x7CED68", Offset = "0x7CED68", VA = "0x7CED68", Slot = "12")]
	public override void SetHapticAmplitude(HapticType hapticType, XRNode hand, float amplitude)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x7CED6C", Offset = "0x7CED6C", VA = "0x7CED6C", Slot = "13")]
	public override bool TriggerPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x7CEDA0", Offset = "0x7CEDA0", VA = "0x7CEDA0", Slot = "14")]
	public override bool TriggerPress()
	{
		return default(bool);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x7CEDBC", Offset = "0x7CEDBC", VA = "0x7CEDBC", Slot = "15")]
	public override bool TriggerPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x7CEDF0", Offset = "0x7CEDF0", VA = "0x7CEDF0", Slot = "16")]
	public override bool MenuPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x7CEE24", Offset = "0x7CEE24", VA = "0x7CEE24", Slot = "17")]
	public override bool MenuPress()
	{
		return default(bool);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x7CEE40", Offset = "0x7CEE40", VA = "0x7CEE40", Slot = "18")]
	public override bool MenuPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x7CEE74", Offset = "0x7CEE74", VA = "0x7CEE74", Slot = "19")]
	public override bool SecondaryMenuPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x7CEEA8", Offset = "0x7CEEA8", VA = "0x7CEEA8", Slot = "20")]
	public override bool SecondaryMenuPress()
	{
		return default(bool);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x7CEEC4", Offset = "0x7CEEC4", VA = "0x7CEEC4", Slot = "21")]
	public override bool SecondaryMenuPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x7CEEF8", Offset = "0x7CEEF8", VA = "0x7CEEF8", Slot = "22")]
	public override bool StampItem(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x7CEF2C", Offset = "0x7CEF2C", VA = "0x7CEF2C", Slot = "23")]
	public override bool DeleteItem(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x7CEF60", Offset = "0x7CEF60", VA = "0x7CEF60", Slot = "24")]
	public override bool ToolboxRecenterPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x7CEF68", Offset = "0x7CEF68", VA = "0x7CEF68", Slot = "25")]
	public override bool TouchPadPress()
	{
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x7CEF9C", Offset = "0x7CEF9C", VA = "0x7CEF9C", Slot = "26")]
	public override bool TouchpadPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x7CEFB8", Offset = "0x7CEFB8", VA = "0x7CEFB8", Slot = "27")]
	public override bool TouchpadPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x7CEFEC", Offset = "0x7CEFEC", VA = "0x7CEFEC", Slot = "30")]
	public override float Trigger(XRNode hand)
	{
		return default(float);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x7CF034", Offset = "0x7CF034", VA = "0x7CF034", Slot = "31")]
	public override bool TriggerDown(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x7CF0A8", Offset = "0x7CF0A8", VA = "0x7CF0A8", Slot = "32")]
	public override bool TriggerUp(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x7CF11C", Offset = "0x7CF11C", VA = "0x7CF11C", Slot = "33")]
	public override Vector2 ThumbstickAxis(XRNode hand)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x7CF15C", Offset = "0x7CF15C", VA = "0x7CF15C", Slot = "34")]
	public override Vector3 TouchpadSwipeVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x7CF1A0", Offset = "0x7CF1A0", VA = "0x7CF1A0", Slot = "35")]
	public override Vector3 GetHeadLocalPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x7CF1BC", Offset = "0x7CF1BC", VA = "0x7CF1BC", Slot = "36")]
	public override Quaternion GetHeadLocalRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x7CF1D8", Offset = "0x7CF1D8", VA = "0x7CF1D8", Slot = "37")]
	public override Vector3 GetHandLocalPosition(XRNode hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x7CF21C", Offset = "0x7CF21C", VA = "0x7CF21C", Slot = "38")]
	public override Quaternion GetHandLocalRotation(XRNode hand)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x7CF260", Offset = "0x7CF260", VA = "0x7CF260", Slot = "39")]
	public override Vector3 GetHandLocalPositionWhileAiming(XRNode hand)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000017")]
public class DbgInputHand : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000018")]
	public struct State
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool trigger;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public bool menuPress;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public bool secondaryMenuPress;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public bool touchpad;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool stamp;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public bool delete;
	}

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public State state;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public State intermediate;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public State was;

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x7CF270", Offset = "0x7CF270", VA = "0x7CF270")]
	public DbgInputHand()
	{
	}
}
[Token(Token = "0x2000019")]
public class PicoCameraOptionsHandler : MonoBehaviour
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera[] cameras;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Camera masterCamera;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float lastFarClip;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float lastNearClip;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CameraClearFlags lastClearFlags;

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x7CF278", Offset = "0x7CF278", VA = "0x7CF278")]
	private void Awake()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x7CF2F8", Offset = "0x7CF2F8", VA = "0x7CF2F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x7CF444", Offset = "0x7CF444", VA = "0x7CF444")]
	public PicoCameraOptionsHandler()
	{
	}
}
[Token(Token = "0x200001A")]
public class PicoControllerContainer : MonoBehaviour
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject controller0;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject controller1;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PicoControllerContainer instance;

	[Token(Token = "0x17000003")]
	public static GameObject GetController0
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x7CF44C", Offset = "0x7CF44C", VA = "0x7CF44C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public static GameObject GetController1
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x7CF4A0", Offset = "0x7CF4A0", VA = "0x7CF4A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x7CF4F4", Offset = "0x7CF4F4", VA = "0x7CF4F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x7CF5B4", Offset = "0x7CF5B4", VA = "0x7CF5B4")]
	public PicoControllerContainer()
	{
	}
}
[Token(Token = "0x200001B")]
public class PicoControllerOffsetOverride : MonoBehaviour
{
	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Overrides the ElbowDepth and ElbowHeight properties of the Pvr_Controller")]
	public float elbowDepth;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float elbowHeight;

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x7CF5BC", Offset = "0x7CF5BC", VA = "0x7CF5BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x7CF5C0", Offset = "0x7CF5C0", VA = "0x7CF5C0")]
	public PicoControllerOffsetOverride()
	{
	}
}
[Token(Token = "0x200001C")]
public class PicoInit : MonoBehaviour
{
	[Token(Token = "0x17000005")]
	public static PicoInit Instance
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x7CF5C8", Offset = "0x7CF5C8", VA = "0x7CF5C8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x7CF610", Offset = "0x7CF610", VA = "0x7CF610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x7CF65C", Offset = "0x7CF65C", VA = "0x7CF65C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x7CF79C", Offset = "0x7CF79C", VA = "0x7CF79C")]
	private void Start()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x7CF8F0", Offset = "0x7CF8F0", VA = "0x7CF8F0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x7CF970", Offset = "0x7CF970", VA = "0x7CF970")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x7CF7A0", Offset = "0x7CF7A0", VA = "0x7CF7A0")]
	public void Init()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x7CF9F0", Offset = "0x7CF9F0", VA = "0x7CF9F0")]
	private void PicoEntitlementCheck(int code)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x7CFA74", Offset = "0x7CFA74", VA = "0x7CFA74")]
	public PicoInit()
	{
	}
}
[Token(Token = "0x200001D")]
public sealed class PicoInputDevice : PalazzoInputDevice
{
	[Token(Token = "0x200001E")]
	private enum Hand
	{
		[Token(Token = "0x4000063")]
		LEFT,
		[Token(Token = "0x4000064")]
		RIGHT
	}

	[Token(Token = "0x200001F")]
	private enum VectorAxis
	{
		[Token(Token = "0x4000066")]
		X,
		[Token(Token = "0x4000067")]
		Y
	}

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool pausePrev;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool hmdUnmounted;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private PlayerHandedness currentHandness;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool hasTwoHandedSupport;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool triggerHeld;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	private bool triggerHeldLastFrame;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	private bool menuButtonHeldLastFrame;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int currButtonFrame;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int currButtonPress;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int lastButtonPress;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float axis;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<InputFeatureUsage<bool>, float> buttonForceMap;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Hand> Hands;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<InputDevice> sources;

	[Token(Token = "0x17000006")]
	private bool IsHeadsetOnHead
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x7CFC64", Offset = "0x7CFC64", VA = "0x7CFC64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x7CFA7C", Offset = "0x7CFA7C", VA = "0x7CFA7C")]
	public PicoInputDevice(ARTransforms arTransforms)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x7CFCC0", Offset = "0x7CFCC0", VA = "0x7CFCC0", Slot = "6")]
	public override void Tick()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x7CFFB4", Offset = "0x7CFFB4", VA = "0x7CFFB4", Slot = "10")]
	public override void PlayHaptic(HapticType hapticType, XRNode hand, float? amplitude, bool playUntilStop = false)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x7D0290", Offset = "0x7D0290", VA = "0x7D0290", Slot = "12")]
	public override void SetHapticAmplitude(HapticType hapticType, XRNode hand, float amplitude)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x7D0294", Offset = "0x7D0294", VA = "0x7D0294", Slot = "11")]
	public override void StopHaptic(HapticType hapticType, XRNode hand)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x7D0430", Offset = "0x7D0430", VA = "0x7D0430")]
	private void OnHMDMounted()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x7D0438", Offset = "0x7D0438", VA = "0x7D0438")]
	private void OnHMDUnmounted()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x7D0444", Offset = "0x7D0444", VA = "0x7D0444", Slot = "9")]
	public override void Recenter()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x7CFF9C", Offset = "0x7CFF9C", VA = "0x7CFF9C")]
	private void GetSources(Hand hand, List<InputDevice> sources)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x7D0448", Offset = "0x7D0448", VA = "0x7D0448", Slot = "13")]
	public override bool TriggerPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x7D0468", Offset = "0x7D0468", VA = "0x7D0468", Slot = "14")]
	public override bool TriggerPress()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x7D0480", Offset = "0x7D0480", VA = "0x7D0480", Slot = "15")]
	public override bool TriggerPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x7D04A0", Offset = "0x7D04A0", VA = "0x7D04A0", Slot = "30")]
	public override float Trigger(XRNode hand)
	{
		return default(float);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x7D04A8", Offset = "0x7D04A8", VA = "0x7D04A8", Slot = "31")]
	public override bool TriggerDown(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x7D04B0", Offset = "0x7D04B0", VA = "0x7D04B0", Slot = "32")]
	public override bool TriggerUp(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x7D04B8", Offset = "0x7D04B8", VA = "0x7D04B8", Slot = "16")]
	public override bool MenuPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x7D07F8", Offset = "0x7D07F8", VA = "0x7D07F8", Slot = "17")]
	public override bool MenuPress()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x7D0800", Offset = "0x7D0800", VA = "0x7D0800", Slot = "18")]
	public override bool MenuPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x7D0808", Offset = "0x7D0808", VA = "0x7D0808", Slot = "19")]
	public override bool SecondaryMenuPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x7D0810", Offset = "0x7D0810", VA = "0x7D0810", Slot = "20")]
	public override bool SecondaryMenuPress()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x7D0818", Offset = "0x7D0818", VA = "0x7D0818", Slot = "21")]
	public override bool SecondaryMenuPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x7D0820", Offset = "0x7D0820", VA = "0x7D0820", Slot = "22")]
	public override bool StampItem(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x7D0828", Offset = "0x7D0828", VA = "0x7D0828", Slot = "23")]
	public override bool DeleteItem(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x7D0830", Offset = "0x7D0830", VA = "0x7D0830", Slot = "24")]
	public override bool ToolboxRecenterPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x7D0838", Offset = "0x7D0838", VA = "0x7D0838", Slot = "25")]
	public override bool TouchPadPress()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x7D0840", Offset = "0x7D0840", VA = "0x7D0840", Slot = "26")]
	public override bool TouchpadPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x7D0848", Offset = "0x7D0848", VA = "0x7D0848", Slot = "27")]
	public override bool TouchpadPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x7D0850", Offset = "0x7D0850", VA = "0x7D0850", Slot = "34")]
	public override Vector3 TouchpadSwipeVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x7D0894", Offset = "0x7D0894", VA = "0x7D0894", Slot = "33")]
	public override Vector2 ThumbstickAxis(XRNode hand)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x7D08D4", Offset = "0x7D08D4", VA = "0x7D08D4", Slot = "35")]
	public override Vector3 GetHeadLocalPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x7D08F8", Offset = "0x7D08F8", VA = "0x7D08F8", Slot = "36")]
	public override Quaternion GetHeadLocalRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x7D091C", Offset = "0x7D091C", VA = "0x7D091C", Slot = "37")]
	public override Vector3 GetHandLocalPosition(XRNode hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x7D09E4", Offset = "0x7D09E4", VA = "0x7D09E4", Slot = "38")]
	public override Quaternion GetHandLocalRotation(XRNode hand)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x7D0AB8", Offset = "0x7D0AB8", VA = "0x7D0AB8", Slot = "39")]
	public override Vector3 GetHandLocalPositionWhileAiming(XRNode hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x7D0AC8", Offset = "0x7D0AC8", VA = "0x7D0AC8", Slot = "29")]
	public override PlayerHandedness GetHandedness()
	{
		return default(PlayerHandedness);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x7D0AD0", Offset = "0x7D0AD0", VA = "0x7D0AD0", Slot = "28")]
	public override void SetHandedness(PlayerHandedness handedness)
	{
	}
}
[Token(Token = "0x2000020")]
public class PicoMultiCameraManager : MonoBehaviour
{
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject sdkObject;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GameObject currentActiveCamera;

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x7D0AD8", Offset = "0x7D0AD8", VA = "0x7D0AD8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x7D0B90", Offset = "0x7D0B90", VA = "0x7D0B90")]
	public PicoMultiCameraManager()
	{
	}
}
[Token(Token = "0x2000021")]
public enum PicoModel
{
	[Token(Token = "0x400006B")]
	unknown,
	[Token(Token = "0x400006C")]
	Goblin,
	[Token(Token = "0x400006D")]
	Neo,
	[Token(Token = "0x400006E")]
	G2,
	[Token(Token = "0x400006F")]
	Neo2
}
[Serializable]
[Token(Token = "0x2000022")]
public sealed class HapticAudioClips
{
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AudioClip onSlingshotFire;

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x7D0B98", Offset = "0x7D0B98", VA = "0x7D0B98")]
	public HapticAudioClips()
	{
	}
}
[Token(Token = "0x2000023")]
public sealed class PicoWorldTracker : WorldTracker
{
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x7D0BA0", Offset = "0x7D0BA0", VA = "0x7D0BA0")]
	public PicoWorldTracker()
	{
	}
}
[Token(Token = "0x2000024")]
public sealed class PicoPlatform : PalazzoPlatform
{
	[Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class <GetManager>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x7D1008", Offset = "0x7D1008", VA = "0x7D1008", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x7D1050", Offset = "0x7D1050", VA = "0x7D1050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x7D0C28", Offset = "0x7D0C28", VA = "0x7D0C28")]
		[DebuggerHidden]
		public <GetManager>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x7D0FD0", Offset = "0x7D0FD0", VA = "0x7D0FD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x7D0FD4", Offset = "0x7D0FD4", VA = "0x7D0FD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x7D1010", Offset = "0x7D1010", VA = "0x7D1010", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private HapticAudioClips hapticAudioClips;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject cameraPrefab;

	[Token(Token = "0x4000073")]
	private const string Pico3DofAppID = "7f5413f6710ec519b2145b2ce12a8f1c";

	[Token(Token = "0x4000074")]
	private const string Pico6DofAppID = "c89e834bcb3879e41ecfd6efe89a7d49";

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x7D0BA8", Offset = "0x7D0BA8", VA = "0x7D0BA8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x7D0BC8", Offset = "0x7D0BC8", VA = "0x7D0BC8")]
	[IteratorStateMachine(typeof(<GetManager>d__5))]
	private IEnumerator GetManager()
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x7D0C50", Offset = "0x7D0C50", VA = "0x7D0C50", Slot = "6")]
	public override bool HasTwoHandedSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x7D0C58", Offset = "0x7D0C58", VA = "0x7D0C58", Slot = "7")]
	public override bool IsUserEntitled()
	{
		return default(bool);
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x7D0C60", Offset = "0x7D0C60", VA = "0x7D0C60", Slot = "10")]
	protected override PalazzoInputDevice CreateInputDeviceInternal(ARTransforms arTransforms)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x7D0CC0", Offset = "0x7D0CC0", VA = "0x7D0CC0", Slot = "11")]
	protected override WorldTracker CreateWorldTrackerInternal(ARTransforms arTransforms, PalazzoTriggers palazzoTriggers)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x7D0D1C", Offset = "0x7D0D1C", VA = "0x7D0D1C", Slot = "8")]
	public override Theme[] GetEnabledThemes()
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x7D0D84", Offset = "0x7D0D84", VA = "0x7D0D84")]
	public static void CreateSplashScreenSetup(Camera logoCamera)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x7D0FC8", Offset = "0x7D0FC8", VA = "0x7D0FC8")]
	public PicoPlatform()
	{
	}
}
[Token(Token = "0x2000026")]
public sealed class ViveFocusPlusInputDevice : PalazzoInputDevice
{
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x7D1058", Offset = "0x7D1058", VA = "0x7D1058")]
	public ViveFocusPlusInputDevice(ARTransforms arTransforms)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x7D1060", Offset = "0x7D1060", VA = "0x7D1060", Slot = "9")]
	public override void Recenter()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x7D1064", Offset = "0x7D1064", VA = "0x7D1064", Slot = "10")]
	public override void PlayHaptic(HapticType hapticType, XRNode hand, [Optional] float? amplitude, bool playUntilStop = false)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x7D1068", Offset = "0x7D1068", VA = "0x7D1068", Slot = "11")]
	public override void StopHaptic(HapticType hapticType, XRNode hand)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x7D106C", Offset = "0x7D106C", VA = "0x7D106C", Slot = "12")]
	public override void SetHapticAmplitude(HapticType hapticType, XRNode hand, float amplitude)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x7D1070", Offset = "0x7D1070", VA = "0x7D1070", Slot = "13")]
	public override bool TriggerPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x7D1078", Offset = "0x7D1078", VA = "0x7D1078", Slot = "14")]
	public override bool TriggerPress()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x7D1080", Offset = "0x7D1080", VA = "0x7D1080", Slot = "15")]
	public override bool TriggerPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x7D1088", Offset = "0x7D1088", VA = "0x7D1088", Slot = "16")]
	public override bool MenuPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x7D1090", Offset = "0x7D1090", VA = "0x7D1090", Slot = "17")]
	public override bool MenuPress()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x7D1098", Offset = "0x7D1098", VA = "0x7D1098", Slot = "18")]
	public override bool MenuPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x7D10A0", Offset = "0x7D10A0", VA = "0x7D10A0", Slot = "19")]
	public override bool SecondaryMenuPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x7D10A8", Offset = "0x7D10A8", VA = "0x7D10A8", Slot = "20")]
	public override bool SecondaryMenuPress()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x7D10B0", Offset = "0x7D10B0", VA = "0x7D10B0", Slot = "21")]
	public override bool SecondaryMenuPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x7D10B8", Offset = "0x7D10B8", VA = "0x7D10B8", Slot = "22")]
	public override bool StampItem(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x7D10C0", Offset = "0x7D10C0", VA = "0x7D10C0", Slot = "23")]
	public override bool DeleteItem(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x7D10C8", Offset = "0x7D10C8", VA = "0x7D10C8", Slot = "24")]
	public override bool ToolboxRecenterPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x7D10D0", Offset = "0x7D10D0", VA = "0x7D10D0", Slot = "25")]
	public override bool TouchPadPress()
	{
		return default(bool);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x7D10D8", Offset = "0x7D10D8", VA = "0x7D10D8", Slot = "26")]
	public override bool TouchpadPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x7D10E0", Offset = "0x7D10E0", VA = "0x7D10E0", Slot = "27")]
	public override bool TouchpadPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x7D10E8", Offset = "0x7D10E8", VA = "0x7D10E8", Slot = "30")]
	public override float Trigger(XRNode hand)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x7D10F0", Offset = "0x7D10F0", VA = "0x7D10F0", Slot = "31")]
	public override bool TriggerDown(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x7D10F8", Offset = "0x7D10F8", VA = "0x7D10F8", Slot = "32")]
	public override bool TriggerUp(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x7D1100", Offset = "0x7D1100", VA = "0x7D1100", Slot = "33")]
	public override Vector2 ThumbstickAxis(XRNode hand)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x7D1140", Offset = "0x7D1140", VA = "0x7D1140", Slot = "34")]
	public override Vector3 TouchpadSwipeVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x7D1184", Offset = "0x7D1184", VA = "0x7D1184", Slot = "35")]
	public override Vector3 GetHeadLocalPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x7D11C8", Offset = "0x7D11C8", VA = "0x7D11C8", Slot = "36")]
	public override Quaternion GetHeadLocalRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x7D120C", Offset = "0x7D120C", VA = "0x7D120C", Slot = "37")]
	public override Vector3 GetHandLocalPosition(XRNode hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x7D1250", Offset = "0x7D1250", VA = "0x7D1250", Slot = "38")]
	public override Quaternion GetHandLocalRotation(XRNode hand)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x7D1294", Offset = "0x7D1294", VA = "0x7D1294", Slot = "39")]
	public override Vector3 GetHandLocalPositionWhileAiming(XRNode hand)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000027")]
public sealed class ViveFocusPlusWorldTracker : WorldTracker
{
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x7D12D8", Offset = "0x7D12D8", VA = "0x7D12D8")]
	public ViveFocusPlusWorldTracker()
	{
	}
}
[Token(Token = "0x2000028")]
public sealed class ViveFocusPlusPlatform : PalazzoPlatform
{
	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x7D12E0", Offset = "0x7D12E0", VA = "0x7D12E0", Slot = "6")]
	public override bool HasTwoHandedSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x7D12E8", Offset = "0x7D12E8", VA = "0x7D12E8", Slot = "10")]
	protected override PalazzoInputDevice CreateInputDeviceInternal(ARTransforms arTransforms)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x7D1348", Offset = "0x7D1348", VA = "0x7D1348", Slot = "11")]
	protected override WorldTracker CreateWorldTrackerInternal(ARTransforms arTransforms, PalazzoTriggers palazzoTriggers)
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x7D13A4", Offset = "0x7D13A4", VA = "0x7D13A4")]
	public ViveFocusPlusPlatform()
	{
	}
}
[Token(Token = "0x2000029")]
public class GodRayDust : MonoBehaviour
{
	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int materialIndex;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector2 uvAnimationRate;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Renderer dustRenderer;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector2 uvOffset;

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x7D13AC", Offset = "0x7D13AC", VA = "0x7D13AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x7D13FC", Offset = "0x7D13FC", VA = "0x7D13FC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x7D1450", Offset = "0x7D1450", VA = "0x7D1450")]
	public GodRayDust()
	{
	}
}
[Token(Token = "0x200002A")]
public class AchievementHandler
{
	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoWorld[] worldPrefabs;

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x7D14B4", Offset = "0x7D14B4", VA = "0x7D14B4")]
	public AchievementHandler(InputHandler inputHandler, PalazzoGameDataPersistent gameDataPersistent, PalazzoWorld[] worldPrefabs)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x7D14F0", Offset = "0x7D14F0", VA = "0x7D14F0")]
	public void UnlockAchievement(Achievements achievement)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x7D150C", Offset = "0x7D150C", VA = "0x7D150C")]
	public void UnlockAlreadyFulfilledAchievements()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x7D1610", Offset = "0x7D1610", VA = "0x7D1610")]
	public bool ValidateAchievement(Achievements achievement)
	{
		return default(bool);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x7D195C", Offset = "0x7D195C", VA = "0x7D195C")]
	public int GetWorldStarCount(WorldType worldType)
	{
		return default(int);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x7D185C", Offset = "0x7D185C", VA = "0x7D185C")]
	private bool HasClearedLevel(WorldType worldType, int levelIndexInWorld)
	{
		return default(bool);
	}
}
[Token(Token = "0x200002B")]
[RequireComponent(typeof(Collider))]
[DisallowMultipleComponent]
[RequireComponent(typeof(DamageComponent))]
[RequireComponent(typeof(PalazzoComponentLevelBlock))]
[RequireComponent(typeof(Rigidbody))]
public class AlchemyComponent : MonoBehaviour
{
	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool hasBeenAlchemised;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public BlockType originalBlockType;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PalazzoComponentLevelBlock iceReferenceBlock;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public PalazzoComponentLevelBlock woodReferenceBlock;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public PalazzoComponentLevelBlock rockReferenceBlock;

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x7D1A80", Offset = "0x7D1A80", VA = "0x7D1A80")]
	public AlchemyComponent()
	{
	}
}
[Token(Token = "0x200002C")]
[RequireComponent(typeof(DamageComponent))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
[DisallowMultipleComponent]
[RequireComponent(typeof(PalazzoComponentLevelBlock))]
public class AlchemyExplosionComponent : MonoBehaviour
{
	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PalazzoComponentLevelBlock levelBlock;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BlockType targetBlockType;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float explosionRadius;

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x7D1A88", Offset = "0x7D1A88", VA = "0x7D1A88")]
	public AlchemyExplosionComponent()
	{
	}
}
[Token(Token = "0x200002D")]
public class AlchemyHandler
{
	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelBlockHelper levelBlockHelper;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly AchievementHandler achievementHandler;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool firstTime;

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x7D1A98", Offset = "0x7D1A98", VA = "0x7D1A98")]
	public AlchemyHandler(LevelBlockHelper levelBlockHelper, AchievementHandler achievementHandler)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x7D1AC4", Offset = "0x7D1AC4", VA = "0x7D1AC4")]
	public void AlchemiseBlock(PalazzoComponentLevelBlock block, BlockType targetBlockType)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x7D1DA8", Offset = "0x7D1DA8", VA = "0x7D1DA8")]
	public void ResetBlock(PalazzoComponentLevelBlock block)
	{
	}
}
[Token(Token = "0x200002E")]
public sealed class AmbientAudioComponent : MonoBehaviour
{
	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform right;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform left;

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x7D1F0C", Offset = "0x7D1F0C", VA = "0x7D1F0C")]
	public AmbientAudioComponent()
	{
	}
}
[Token(Token = "0x200002F")]
[DisallowMultipleComponent]
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(DamageComponent))]
[RequireComponent(typeof(PalazzoComponentLevelBlock))]
[RequireComponent(typeof(Rigidbody))]
public sealed class BalloonComponent : MonoBehaviour
{
	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Rigidbody rb;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SpringJoint joint;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LineRenderer rope;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 startUpVector;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float speedVariationAmplitude;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float speedVariationFrequency;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float buoyancyMultiplier;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public PalazzoComponentLevelBlock connectedBody;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public bool connectedToPig;

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x7D1F14", Offset = "0x7D1F14", VA = "0x7D1F14")]
	public BalloonComponent()
	{
	}
}
[Token(Token = "0x2000030")]
public sealed class BirdSelectionHandler
{
	[Token(Token = "0x2000031")]
	private class BirdFlyingBackToToolbox
	{
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ToolboxItemComponent bird;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 targetPosition;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion targetRotation;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float timeInFlight;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ToolboxItemComponent item;

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x7D4AA8", Offset = "0x7D4AA8", VA = "0x7D4AA8")]
		public BirdFlyingBackToToolbox()
		{
		}
	}

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelEditorComponent levelEditor;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly ToolboxItemInteractionHandler itemInteractionHandler;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly LevelEditorVRController vrController;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly ToolboxTabComponent tab;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly BirdTabComponent birdTab;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly LevelEditorSettings levelEditorSettings;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly ToolboxSettings toolboxSettings;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ToolboxItemComponent[] grabbedItems;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] grabbedItemStartingPostions;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Quaternion[] grabbedItemStartingRotations;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int[] grabbedItemIntersectedSlot;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<BirdFlyingBackToToolbox> birdsFlyingBackToToolbox;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ToolboxItemComponent[][] birdPool;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int idle;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int fly;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly int inHand;

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x7D1F30", Offset = "0x7D1F30", VA = "0x7D1F30")]
	public BirdSelectionHandler(LevelEditorContext levelEditorContext, LevelEditorComponent levelEditor, InputHandler inputHandler, LevelEditorVRController vrController, ToolboxTabComponent tab, BirdTabComponent birdTab, LevelEditorSettings levelEditorSettings, PalazzoTriggers palazzoTriggers, ToolboxSettings toolboxSettings)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x7D23CC", Offset = "0x7D23CC", VA = "0x7D23CC")]
	public void Tick()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x7D3028", Offset = "0x7D3028", VA = "0x7D3028")]
	public void SetBirds()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x7D35DC", Offset = "0x7D35DC", VA = "0x7D35DC")]
	public void Reset()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x7D3BA4", Offset = "0x7D3BA4", VA = "0x7D3BA4")]
	private void OnInteract(ToolboxItemComponent item, VRGrab grab)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x7D41DC", Offset = "0x7D41DC", VA = "0x7D41DC")]
	private void OnRelease(ToolboxItemComponent item, VRGrab grab)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x7D3290", Offset = "0x7D3290", VA = "0x7D3290")]
	private void SelectBird(ToolboxItemComponent bird, int pos)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x7D3F44", Offset = "0x7D3F44", VA = "0x7D3F44")]
	private ToolboxItemComponent SpawnBirdFromPool(int birdId)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x7D2F98", Offset = "0x7D2F98", VA = "0x7D2F98")]
	private void CopyAnimationState(Animator source, Animator target)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x7D2DA4", Offset = "0x7D2DA4", VA = "0x7D2DA4")]
	private bool BirdIsFlyingOrGrabbed(ToolboxItemComponent bird, int iHand)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000034")]
public sealed class BirdSpecialAbilityHandler
{
	[Token(Token = "0x40000B0")]
	private const float BLUE_SPLIT_SPAWN_OFFSET = 5f;

	[Token(Token = "0x40000B1")]
	private const float BLUE_SPLIT_RIGHT_ANGLE = 8f;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly float[] BLUE_SPLIT_FORWARD_ANGLES;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly PhysicsSettings physicsSettings;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly LevelBlockFactory levelBlockFactory;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly PalazzoComponentLevelBlock blueLevelBlockPrefab;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly AchievementHandler achievementHandler;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x7D4CB0", Offset = "0x7D4CB0", VA = "0x7D4CB0")]
	public BirdSpecialAbilityHandler(ARTransforms arTransforms, InputHandler inputHandler, LevelContext levelContext, PalazzoTriggers palazzoTriggers, PhysicsSettings physicsSettings, LevelBlockFactory levelBlockFactory, PalazzoComponentLevelBlock[] levelBlockPrefabs, AchievementHandler achievementHandler)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x7D4DE8", Offset = "0x7D4DE8", VA = "0x7D4DE8")]
	public void ActivateSpecialAbilities()
	{
	}
}
[Token(Token = "0x2000035")]
public sealed class BirdsRemainingHandler
{
	[Token(Token = "0x40000BB")]
	private const float START_ROTATE_ANGLE_THRESHOLD = 20f;

	[Token(Token = "0x40000BC")]
	private const float STOP_MOVE_DISTANCE_TRHESHOLD = 0.05f;

	[Token(Token = "0x40000BD")]
	private const float START_MOVE_DISTANCE_THRESHOLD = 0.05f;

	[Token(Token = "0x40000BE")]
	private const float ROTATE_MAX_DEGREES_DELTA = 150f;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x7D5600", Offset = "0x7D5600", VA = "0x7D5600")]
	public BirdsRemainingHandler(ARTransforms arTransforms, LevelContext levelContext, InputHandler inputHandler, PalazzoComponentBirdPlatform birdPlatform)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x7D5640", Offset = "0x7D5640", VA = "0x7D5640")]
	private Vector3 CalcTargetDirection(Vector3 src, Vector3 dst)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x7D5730", Offset = "0x7D5730", VA = "0x7D5730")]
	private Quaternion CalcTargetRotation(Vector3 myPosition)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x7D5840", Offset = "0x7D5840", VA = "0x7D5840")]
	private void RotateToTargetEnter(PalazzoComponentBird bird, Vector3 myPosition, Vector3 targetPosition)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x7D5A60", Offset = "0x7D5A60", VA = "0x7D5A60")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x7D5BA4", Offset = "0x7D5BA4", VA = "0x7D5BA4")]
	public void Tick()
	{
	}
}
[Token(Token = "0x2000036")]
public class BirdTabComponent : MonoBehaviour
{
	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<ToolboxItemComponent> selectedBirds;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<ToolboxItemComponent> redPool;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<ToolboxItemComponent> chuckPool;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<ToolboxItemComponent> bombPool;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ToolboxItemComponent> bluesPool;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Collider> selectionSlots;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float scaleFactor;

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x7D661C", Offset = "0x7D661C", VA = "0x7D661C")]
	public BirdTabComponent()
	{
	}
}
[Token(Token = "0x2000037")]
[DisallowMultipleComponent]
public sealed class BlockTypeData : MonoBehaviour
{
	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BlockType type;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string soundSpawn;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string soundDespawn;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string soundDamage;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string soundDestroy;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string soundDestroyExtra;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string soundDestroyExtra2;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string soundFuse;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ScoreEffectComponent scoreFx;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ParticleEffectComponent prefabSpawnFx;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ParticleEffectComponent prefabDespawnFx;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ParticleEffectComponent prefabImpactFx;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ParticleEffectComponent prefabDamageFx;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ParticleEffectComponent prefabDestroyFx;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ParticleEffectComponent prefabFuseFx;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public ParticleEffectComponent prefabHitFx;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public ParticleEffectComponent prefabScoreFx;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public string soundImpactLight;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public string soundImpactMedium;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public string soundImpactHeavy;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public string soundImpactHit;

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x7D6624", Offset = "0x7D6624", VA = "0x7D6624")]
	public BlockTypeData()
	{
	}
}
[Token(Token = "0x2000038")]
public sealed class BuildingBlockFactory
{
	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelEditorComponent levelEditor;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly Material[][] greenMaterials;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Material[][] grayMaterials;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly int defaultLayer;

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x7D662C", Offset = "0x7D662C", VA = "0x7D662C")]
	public BuildingBlockFactory(LevelEditorComponent levelEditor, Material[][] greenMaterials, Material[][] grayMaterials)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x7D66AC", Offset = "0x7D66AC", VA = "0x7D66AC")]
	public LevelBuildingBlock CreateLevelBuildBlock(int prefabId)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x7D75F8", Offset = "0x7D75F8", VA = "0x7D75F8")]
	public void DestroyLevelBuildingBlock(LevelBuildingBlock block)
	{
	}
}
[Token(Token = "0x2000039")]
public sealed class CameraFadeComponent : MonoBehaviour
{
	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Material fadeMaterial;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MeshRenderer meshRenderer;

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x7D76FC", Offset = "0x7D76FC", VA = "0x7D76FC")]
	public CameraFadeComponent()
	{
	}
}
[Token(Token = "0x200003A")]
public class CharacterLookAtHandler
{
	[Token(Token = "0x40000E5")]
	private const float MIN_LOOK_OR_LOOK_AWAY_TIME = 0.5f;

	[Token(Token = "0x40000E6")]
	private const float MAX_TILT_RADIANS_FOR_GLOBAL_LOOK_AT = 0.12217305f;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly Transform[] characterLookAtTargets;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float blendedNeckLookWeight;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform target;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform neckTarget;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float switchTargetDelay;

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x7D7704", Offset = "0x7D7704", VA = "0x7D7704")]
	public CharacterLookAtHandler(LevelContext levelContext, Transform[] characterLookAtTargets)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x7D77A0", Offset = "0x7D77A0", VA = "0x7D77A0")]
	public void Reset()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x7D77A8", Offset = "0x7D77A8", VA = "0x7D77A8")]
	public void LateTick()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x7D7E2C", Offset = "0x7D7E2C", VA = "0x7D7E2C")]
	private void TurnPupilTowardsTargetLocal(InteractiveCharacterComponent character, Transform eyeTransform, Vector3 targetPosition, Vector3 eyeCenterRotation)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x7D80AC", Offset = "0x7D80AC", VA = "0x7D80AC")]
	private void TurnPupilTowardsTargetGlobal(InteractiveCharacterComponent character, Transform eyeTransform, Vector3 targetPosition, Vector3 eyeCenterRotation)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x7D7750", Offset = "0x7D7750", VA = "0x7D7750")]
	private void SetNewTarget()
	{
	}
}
[Token(Token = "0x200003B")]
public class ThreadJob<T>
{
	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private T result;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool isDone;

	[Token(Token = "0x6000131")]
	public bool TryGetResult(out T result)
	{
		return default(bool);
	}

	[Token(Token = "0x6000132")]
	public void SetResult(T result)
	{
	}

	[Token(Token = "0x6000133")]
	public ThreadJob()
	{
	}
}
[Token(Token = "0x200003C")]
public static class Compression
{
	[Token(Token = "0x200003D")]
	private struct DataToDecompress
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ThreadJob<Level> job;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string data;
	}

	[Token(Token = "0x200003E")]
	private struct LevelToCompress
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ThreadJob<string> job;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Level data;
	}

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Thread compressionThread;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Thread decompressionThread;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Queue<DataToDecompress> dataToDecompress;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Queue<LevelToCompress> levelsToCompress;

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x7D8314", Offset = "0x7D8314", VA = "0x7D8314")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x7D8518", Offset = "0x7D8518", VA = "0x7D8518")]
	public static ThreadJob<Level> Decompress(string data)
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x7D8684", Offset = "0x7D8684", VA = "0x7D8684")]
	public static ThreadJob<string> EnqueueCompression(Level level)
	{
		return null;
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x7D87F0", Offset = "0x7D87F0", VA = "0x7D87F0")]
	private static void CompressionThread()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x7D897C", Offset = "0x7D897C", VA = "0x7D897C")]
	private static void DecompressionThread()
	{
	}
}
[Token(Token = "0x200003F")]
public class ConnectionHandler
{
	[Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class <MaintainConnection>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ConnectionHandler <>4__this;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityWebRequest <request>5__2;

		[Token(Token = "0x1700000B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x7D9270", Offset = "0x7D9270", VA = "0x7D9270", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x7D92B8", Offset = "0x7D92B8", VA = "0x7D92B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x7D8C30", Offset = "0x7D8C30", VA = "0x7D8C30")]
		[DebuggerHidden]
		public <MaintainConnection>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x7D8D28", Offset = "0x7D8D28", VA = "0x7D8D28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x7D8D2C", Offset = "0x7D8D2C", VA = "0x7D8D2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x7D9278", Offset = "0x7D9278", VA = "0x7D9278", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly WaitForSecondsRealtime twoSeconds;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool shouldFetchNewAuthToken;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool shouldFetchPlayfabId;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Future<string> authTokenFuture;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Future<string> loginFuture;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool canReachGoogleServices;

	[Token(Token = "0x17000009")]
	public string AuthToken
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x7D8B10", Offset = "0x7D8B10", VA = "0x7D8B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x7D8B08", Offset = "0x7D8B08", VA = "0x7D8B08")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public string PlayfabId
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x7D8B20", Offset = "0x7D8B20", VA = "0x7D8B20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x7D8B18", Offset = "0x7D8B18", VA = "0x7D8B18")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x7D8B28", Offset = "0x7D8B28", VA = "0x7D8B28")]
	public ConnectionHandler(MonoBehaviour monoBehaviour)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x7D8BC8", Offset = "0x7D8BC8", VA = "0x7D8BC8")]
	[IteratorStateMachine(typeof(<MaintainConnection>d__15))]
	private IEnumerator MaintainConnection()
	{
		return null;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x7D8C58", Offset = "0x7D8C58", VA = "0x7D8C58")]
	public bool IsConnectionEstablished()
	{
		return default(bool);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x7D8C9C", Offset = "0x7D8C9C", VA = "0x7D8C9C")]
	public void Reconnect()
	{
	}
}
[Token(Token = "0x2000041")]
public class CreateUserMenu : UiMenuBase<CreateUserMenuButton, CreateUserMenuButtonType>
{
	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SpriteRenderer spriteRenderer;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject spriteRoot;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float spriteChangeSpeed;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float spriteAccelerationTime;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SlotMachine[] slotMachines;

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x7D92C0", Offset = "0x7D92C0", VA = "0x7D92C0")]
	public CreateUserMenu()
	{
	}
}
[Token(Token = "0x2000042")]
public enum CreateUserMenuButtonType
{
	[Token(Token = "0x4000109")]
	Randomize,
	[Token(Token = "0x400010A")]
	Create,
	[Token(Token = "0x400010B")]
	Cancel
}
[Token(Token = "0x2000043")]
public class CreateUserMenuButton : PalazzoButton<CreateUserMenuButtonType>
{
	[Token(Token = "0x6000148")]
	[Address(RVA = "0x7D9308", Offset = "0x7D9308", VA = "0x7D9308")]
	public CreateUserMenuButton()
	{
	}
}
[Token(Token = "0x2000044")]
[DisallowMultipleComponent]
[RequireComponent(typeof(PlayableDirector))]
public sealed class CutsceneComponent : MonoBehaviour
{
	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string guid;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int levelIndex;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public CutSceneQueue queue;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool requiresPlayerFocus;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public PlayableDirector director;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CutsceneSoundTrigger[] soundTriggers;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform customPlayerPose;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Animator idleAnimator;

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x7D9350", Offset = "0x7D9350", VA = "0x7D9350")]
	public CutsceneComponent()
	{
	}
}
[Token(Token = "0x2000045")]
public sealed class CutsceneHandler
{
	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x4000118")]
	private const float FOCUS_THRESHOLD = 0.87f;

	[Token(Token = "0x4000119")]
	private const float FOCUS_TIME_REQUIRED = 3f;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<int, CutsceneComponent> cutsceneLookup;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CutsceneComponent currentPlayingCutscene;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float focusTimer;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool waitingForFocus;

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x7D9358", Offset = "0x7D9358", VA = "0x7D9358")]
	public CutsceneHandler(ARTransforms arTransforms, CutsceneComponent[] cutscenes, PalazzoTriggers palazzoTriggers, InputHandler inputHandler, PalazzoGameDataPersistent gameDataPersistent)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x7D9648", Offset = "0x7D9648", VA = "0x7D9648")]
	public void Tick()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x7D9990", Offset = "0x7D9990", VA = "0x7D9990")]
	private bool HasCutsceneBeenWatched()
	{
		return default(bool);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x7D9BE8", Offset = "0x7D9BE8", VA = "0x7D9BE8")]
	public bool LevelHasCutsceneBefore(int levelIndex, out CutsceneComponent cutscene)
	{
		return default(bool);
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x7D9C74", Offset = "0x7D9C74", VA = "0x7D9C74")]
	public bool LevelHasCutsceneAfter(int levelIndex, out CutsceneComponent cutscene)
	{
		return default(bool);
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x7D9D00", Offset = "0x7D9D00", VA = "0x7D9D00")]
	public void PlayCutscene(CutsceneComponent cutscene)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x7D99F4", Offset = "0x7D99F4", VA = "0x7D99F4")]
	private void OnCutsceneStopped(PlayableDirector director)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x7D9ED0", Offset = "0x7D9ED0", VA = "0x7D9ED0")]
	public bool IsPlayingCutscene()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000046")]
public class CutsceneSoundTrigger : MonoBehaviour
{
	[Token(Token = "0x2000047")]
	public delegate void PlaySoundDelegate(Component obj, string sound);

	[Token(Token = "0x2000048")]
	public delegate void StopSoundDelegate(Component obj, string sound);

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string sound;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PlaySoundDelegate playSoundDelegate;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public PlaySoundDelegate stopSoundDelegate;

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x7D9F30", Offset = "0x7D9F30", VA = "0x7D9F30")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x7D9F54", Offset = "0x7D9F54", VA = "0x7D9F54")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x7D9F78", Offset = "0x7D9F78", VA = "0x7D9F78")]
	public CutsceneSoundTrigger()
	{
	}
}
[Token(Token = "0x2000049")]
[DisallowMultipleComponent]
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(PalazzoComponentLevelBlock))]
public sealed class DamageComponent : MonoBehaviour
{
	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PalazzoComponentLevelBlock levelBlock;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter meshFilter;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Mesh optionalHalfBrokenMesh;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Mesh optionalBrokenMesh;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ProgressMeter optionalHealthBar;

	[NonSerialized]
	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public DamageQueue damageQueue;

	[NonSerialized]
	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public DamageState damageState;

	[NonSerialized]
	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float maxHealth;

	[NonSerialized]
	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float health;

	[NonSerialized]
	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float damage;

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x7DA114", Offset = "0x7DA114", VA = "0x7DA114")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x7DA13C", Offset = "0x7DA13C", VA = "0x7DA13C")]
	public DamageComponent()
	{
	}
}
[Token(Token = "0x200004A")]
public sealed class DamageHandler
{
	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int impactLookupLength;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelBlockFactory levelBlockFactory;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly DamageQueue damageQueue;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly BirdImpactQueue birdImpactQueue;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly float impactMagnitudeThreshold;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly LevelBlockHelper levelBlockHelper;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly HealthBarData healthBarData;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly EffectQueue effectQueue;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly AlchemyHandler alchemyHandler;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly float[] impactDamageMultiplierLookup;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly float[] impactVelocityRetainLookup;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly List<DamageComponent> damageBlocksToDestroy;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly List<ExplosionComponent> explosionsToDetonate;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly List<int> impactBirdOnPigLookup;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly int impactGroundPig;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private readonly int impactGroundBossPig;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly List<AlchemyExplosionComponent> alchemyExplosionsToDetonate;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly float maxDistanceBelowLevelForBlocks;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private readonly int scoreMultiplier;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private bool triggerHaptics;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int emissionAddId;

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x7DA144", Offset = "0x7DA144", VA = "0x7DA144")]
	public DamageHandler(GameStateData gameStateData, ARTransforms arTransforms, InputHandler inputHandler, LevelContext levelContext, PalazzoTriggers palazzoTriggers, LevelBlockFactory levelBlockFactory, DamageSettings damageSettings, DamageQueue damageQueue, BirdImpactQueue birdImpactQueue, float impactMagnitudeThreshold, LevelBlockHelper levelBlockHelper, HealthBarData healthBarData, EffectQueue effectQueue, AlchemyHandler alchemyHandler, WorldContext worldContext)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x7DAC4C", Offset = "0x7DAC4C", VA = "0x7DAC4C")]
	public void FixedTick()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x7DC274", Offset = "0x7DC274", VA = "0x7DC274")]
	public void Tick()
	{
	}
}
[Token(Token = "0x200004B")]
public class DebugText : MonoBehaviour
{
	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static DebugText _instance;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text textField;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int numLines;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<string, string> logsByKeyword;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string[] logTextLines;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int currentLogIndex;

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x7DC5F0", Offset = "0x7DC5F0", VA = "0x7DC5F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x7DC858", Offset = "0x7DC858", VA = "0x7DC858")]
	public static void Print(string msg, string keyword)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x7DC85C", Offset = "0x7DC85C", VA = "0x7DC85C")]
	public static void Print(string msg, params object[] args)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x7DC860", Offset = "0x7DC860", VA = "0x7DC860")]
	public static void Clear(string keyword = "")
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x7DC864", Offset = "0x7DC864", VA = "0x7DC864")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x7DC8AC", Offset = "0x7DC8AC", VA = "0x7DC8AC")]
	private void AddText(string text, string keyword = "")
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x7DCDA4", Offset = "0x7DCDA4", VA = "0x7DCDA4")]
	private void ClearText(string keyword = "")
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x7DCA58", Offset = "0x7DCA58", VA = "0x7DCA58")]
	private void UpdateText()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x7DCE68", Offset = "0x7DCE68", VA = "0x7DCE68")]
	public DebugText()
	{
	}
}
[Token(Token = "0x200004C")]
public class EffectOnImpactComponent : MonoBehaviour
{
	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform optionalRotationRoot;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem optionalParticleSystem;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string audioTriggerEvent;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool triggerAchievement;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Achievements typeOfAchievement;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public EffectOnImpactQueue effectOnImpactQueue;

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x7DCE78", Offset = "0x7DCE78", VA = "0x7DCE78")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x7DCF58", Offset = "0x7DCF58", VA = "0x7DCF58")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x7DCEA4", Offset = "0x7DCEA4", VA = "0x7DCEA4")]
	private void TriggerEffect(Collider collider)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x7DCF5C", Offset = "0x7DCF5C", VA = "0x7DCF5C")]
	public EffectOnImpactComponent()
	{
	}
}
[Token(Token = "0x200004D")]
public class EnvironmentEffectsHandler
{
	[Token(Token = "0x200004E")]
	private class ImpactEffectData
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform rootTransform;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float time;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion originalRotation;

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x7DD624", Offset = "0x7DD624", VA = "0x7DD624")]
		public ImpactEffectData()
		{
		}
	}

	[Token(Token = "0x4000152")]
	private const float EFFECT_TIME = 0.33f;

	[Token(Token = "0x4000153")]
	private const float MAX_ROTATION = 5f;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly EffectOnImpactQueue effectOnImpactQueue;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly AchievementHandler achievementHandler;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly EnvironmentEffects environmentEffects;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly List<ImpactEffectData> impacts;

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x7DCF64", Offset = "0x7DCF64", VA = "0x7DCF64")]
	public EnvironmentEffectsHandler(WorldContext worldContext, ARTransforms arTransforms, EffectOnImpactQueue effectOnImpactQueue, PalazzoTriggers palazzoTriggers, AchievementHandler achievementHandler, EnvironmentEffects environmentEffects)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x7DD024", Offset = "0x7DD024", VA = "0x7DD024")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x7DD65C", Offset = "0x7DD65C", VA = "0x7DD65C")]
	public void UpdateSceneEffects()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x7DD62C", Offset = "0x7DD62C", VA = "0x7DD62C")]
	private static float CalcTimeUntilEffect(EnvironmentParticleComponent particle)
	{
		return default(float);
	}
}
[Token(Token = "0x200004F")]
public class EnvironmentParticleComponent : MonoBehaviour
{
	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem particleSystem;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float interval;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float intervalVariation;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string audioTriggerEvent;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public float timer;

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x7DD6BC", Offset = "0x7DD6BC", VA = "0x7DD6BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x7DD6C8", Offset = "0x7DD6C8", VA = "0x7DD6C8")]
	public EnvironmentParticleComponent()
	{
	}
}
[Token(Token = "0x2000050")]
public class NightmareSceneLightningTrigger : MonoBehaviour
{
	[Token(Token = "0x2000051")]
	public delegate void LightningStrikeDelegate(GameObject lightning);

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem[] lightnings;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float emitInterval;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float emitIntervalRandomness;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float emitTimer;

	[Token(Token = "0x14000001")]
	public static event LightningStrikeDelegate LightningStrike
	{
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x7DD6DC", Offset = "0x7DD6DC", VA = "0x7DD6DC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x7DD794", Offset = "0x7DD794", VA = "0x7DD794")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x7DD84C", Offset = "0x7DD84C", VA = "0x7DD84C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x7DD87C", Offset = "0x7DD87C", VA = "0x7DD87C")]
	private void Update()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x7DD980", Offset = "0x7DD980", VA = "0x7DD980")]
	public NightmareSceneLightningTrigger()
	{
	}
}
[Token(Token = "0x2000052")]
public sealed class RandomSpeakerEffectPosition : MonoBehaviour
{
	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform[] positions;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float effectDuration;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float timer;

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x7DDA6C", Offset = "0x7DDA6C", VA = "0x7DDA6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x7DDA90", Offset = "0x7DDA90", VA = "0x7DDA90")]
	private void Update()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x7DDB94", Offset = "0x7DDB94", VA = "0x7DDB94")]
	public RandomSpeakerEffectPosition()
	{
	}
}
[Token(Token = "0x2000053")]
public sealed class EnvironmentPhysicsHandler
{
	[Token(Token = "0x2000054")]
	private struct ForceData
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 forceVector;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 forcePosition;
	}

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 fluidBuoyancyDirection;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PhysicsSettings physicsSettings;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly WorldImpactQueue worldImpactQueue;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly List<ForceData> forcesToApply;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Vector3 birdWindVelocity;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private readonly Vector3 balloonWindVelocity;

	[Token(Token = "0x4000176")]
	private const int ROPE_STEPS = 10;

	[Token(Token = "0x4000177")]
	private const int BALLON_TICK_FREQUENCY = 2;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int frameCounter;

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x7DDB9C", Offset = "0x7DDB9C", VA = "0x7DDB9C")]
	public EnvironmentPhysicsHandler(GameStateData gameStateData, ARTransforms arTransforms, LevelContext levelContext, PhysicsSettings physicsSettings, PalazzoTriggers palazzoTriggers, WorldImpactQueue worldImpactQueue, WorldContext worldContext)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x7DDCBC", Offset = "0x7DDCBC", VA = "0x7DDCBC")]
	private void ApplyBuoyancy(Rigidbody rb, float depth, float invDensity, float fluidDensityMul, float buoyancyMultiplier, int frameFrequency = 1)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x7DDDA0", Offset = "0x7DDDA0", VA = "0x7DDDA0")]
	private void ApplyDrag(Rigidbody rb, Vector3 fluidVelocity, float fluidDragMul, float windMultiplier = 1f, int frameFrequency = 1)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x7DDF60", Offset = "0x7DDF60", VA = "0x7DDF60")]
	public void FixedTick()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x7DF148", Offset = "0x7DF148", VA = "0x7DF148")]
	public static void DrawRope(BalloonComponent balloon, Rigidbody connectedBody, float physicalLevelScaleUp)
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x7DF02C", Offset = "0x7DF02C", VA = "0x7DF02C")]
	private bool PointInOABB(Vector3 point, BoxCollider box)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000055")]
[RequireComponent(typeof(PalazzoComponentLevelBlock))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
[DisallowMultipleComponent]
public sealed class ExplosionComponent : MonoBehaviour
{
	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float explosionRadius;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float explosionDamage;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float explosionForce;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float explosionMultiplierForPigs;

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x7DF5DC", Offset = "0x7DF5DC", VA = "0x7DF5DC")]
	public ExplosionComponent()
	{
	}
}
[Token(Token = "0x2000056")]
public class FadeHandler
{
	[Token(Token = "0x2000057")]
	private abstract class FadeState
	{
		[Token(Token = "0x6000197")]
		public abstract bool AllowedTransitionTo(FadeState nextState);

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x7DFC58", Offset = "0x7DFC58", VA = "0x7DFC58", Slot = "5")]
		public virtual void Enter(FadeHandler fader)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x7DFC5C", Offset = "0x7DFC5C", VA = "0x7DFC5C", Slot = "6")]
		public virtual void Tick(FadeHandler fader)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x7DFC60", Offset = "0x7DFC60", VA = "0x7DFC60", Slot = "7")]
		public virtual void Exit(FadeHandler fader)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x7DFC64", Offset = "0x7DFC64", VA = "0x7DFC64")]
		protected FadeState()
		{
		}
	}

	[Token(Token = "0x2000058")]
	private class IdleState : FadeState
	{
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x7DFC6C", Offset = "0x7DFC6C", VA = "0x7DFC6C", Slot = "4")]
		public override bool AllowedTransitionTo(FadeState nextState)
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x7DFCE4", Offset = "0x7DFCE4", VA = "0x7DFCE4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x7DFD24", Offset = "0x7DFD24", VA = "0x7DFD24", Slot = "5")]
		public override void Enter(FadeHandler fader)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x7DFD54", Offset = "0x7DFD54", VA = "0x7DFD54", Slot = "7")]
		public override void Exit(FadeHandler fader)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x7DF908", Offset = "0x7DF908", VA = "0x7DF908")]
		public IdleState()
		{
		}
	}

	[Token(Token = "0x2000059")]
	private class FadingOutState : FadeState
	{
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x7DFD84", Offset = "0x7DFD84", VA = "0x7DFD84", Slot = "4")]
		public override bool AllowedTransitionTo(FadeState nextState)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x7DFE3C", Offset = "0x7DFE3C", VA = "0x7DFE3C", Slot = "5")]
		public override void Enter(FadeHandler fader)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x7DFE68", Offset = "0x7DFE68", VA = "0x7DFE68", Slot = "6")]
		public override void Tick(FadeHandler fader)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x7DFF38", Offset = "0x7DFF38", VA = "0x7DFF38", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x7DF910", Offset = "0x7DF910", VA = "0x7DF910")]
		public FadingOutState()
		{
		}
	}

	[Token(Token = "0x200005A")]
	private class FullyFadedState : FadeState
	{
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x7DFF78", Offset = "0x7DFF78", VA = "0x7DFF78", Slot = "4")]
		public override bool AllowedTransitionTo(FadeState nextState)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x7DFFF0", Offset = "0x7DFFF0", VA = "0x7DFFF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x7DF918", Offset = "0x7DF918", VA = "0x7DF918")]
		public FullyFadedState()
		{
		}
	}

	[Token(Token = "0x200005B")]
	private class FadingInState : FadeState
	{
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x7E0030", Offset = "0x7E0030", VA = "0x7E0030", Slot = "4")]
		public override bool AllowedTransitionTo(FadeState nextState)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x7E00A8", Offset = "0x7E00A8", VA = "0x7E00A8", Slot = "5")]
		public override void Enter(FadeHandler fader)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x7E00C0", Offset = "0x7E00C0", VA = "0x7E00C0", Slot = "6")]
		public override void Tick(FadeHandler fader)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x7E017C", Offset = "0x7E017C", VA = "0x7E017C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x7DF920", Offset = "0x7DF920", VA = "0x7DF920")]
		public FadingInState()
		{
		}
	}

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly CameraFadeComponent cameraFadeComponent;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Material fadeMaterial;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly FadeState idleState;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly FadeState fadingOutState;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly FadeState fullyFadedState;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly FadeState fadingInState;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private FadeState currentState;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private FadeState nextState;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float targetAlpha;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Color color;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float duration;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int fadeCounter;

	[Token(Token = "0x1700000D")]
	public bool IsIdle
	{
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x7DF5F0", Offset = "0x7DF5F0", VA = "0x7DF5F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x7DF5F8", Offset = "0x7DF5F8", VA = "0x7DF5F8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public bool IsFullyFaded
	{
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x7DF604", Offset = "0x7DF604", VA = "0x7DF604")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x7DF60C", Offset = "0x7DF60C", VA = "0x7DF60C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public bool IsFading
	{
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x7DF618", Offset = "0x7DF618", VA = "0x7DF618")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x7DF620", Offset = "0x7DF620", VA = "0x7DF620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x7DF62C", Offset = "0x7DF62C", VA = "0x7DF62C")]
	private void ChangeState(FadeState newState)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x7DF7E4", Offset = "0x7DF7E4", VA = "0x7DF7E4")]
	public FadeHandler(CameraFadeComponent cameraFadeComponent, PalazzoTriggers palazzoTriggers)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x7DF928", Offset = "0x7DF928", VA = "0x7DF928")]
	public void FadeOut(float duration = 0.4f)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x7DF9C4", Offset = "0x7DF9C4", VA = "0x7DF9C4")]
	public void FadeIn(float duration = 0.2f)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x7DFA5C", Offset = "0x7DFA5C", VA = "0x7DFA5C")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x7DFBB0", Offset = "0x7DFBB0", VA = "0x7DFBB0")]
	private void Lerp()
	{
	}
}
[Token(Token = "0x200005C")]
[RequireComponent(typeof(PalazzoComponentLevelBlock))]
[DisallowMultipleComponent]
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public sealed class FanComponent : MonoBehaviour
{
	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PalazzoComponentLevelBlock levelBlock;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform windFX;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public WindVortexComponent windVortex;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public BoxCollider windVortexCol;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rigidbody rb;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform optionalBlades;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float range;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float outwardsForce;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float speed;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float speedVariationAmplitude;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float speedVariationFrequency;

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x7E01BC", Offset = "0x7E01BC", VA = "0x7E01BC")]
	public FanComponent()
	{
	}
}
[Token(Token = "0x200005D")]
public sealed class CutsceneState : GameStateBase
{
	[Token(Token = "0x200005E")]
	private enum State
	{
		[Token(Token = "0x40001A3")]
		TeleportToStartPosition,
		[Token(Token = "0x40001A4")]
		Cutscene
	}

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly CutsceneHandler cutsceneHandler;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly LevelFactory levelFactory;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private State state;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private State prevState;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CutsceneComponent cutsceneToPlay;

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x7E01D8", Offset = "0x7E01D8", VA = "0x7E01D8")]
	public CutsceneState(CutsceneHandler cutsceneHandler, LevelContext levelContext, TeleportationHandler teleportationHandler, LevelFactory levelFactory, FadeHandler fadeHandler)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x7E0274", Offset = "0x7E0274", VA = "0x7E0274", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x7E02C4", Offset = "0x7E02C4", VA = "0x7E02C4", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}
}
[Token(Token = "0x200005F")]
public sealed class ErrorState : GameStateBase
{
	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ErrorMenu menu;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly UiMenuHandlerBase<ErrorMenuButton, ErrorMenuButtonType> menuHandler;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly MenuSettings menuSettings;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameState nextGameState;

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x7E03EC", Offset = "0x7E03EC", VA = "0x7E03EC")]
	public ErrorState(ErrorMenu menu, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, ARTransforms arTransforms, WorldContext worldContext, MenuSettings menuSettings, GameStateData gameStateData, LevelEditorPlayContext levelEditorPlayContext)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x7E0540", Offset = "0x7E0540", VA = "0x7E0540", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x7E05F8", Offset = "0x7E05F8", VA = "0x7E05F8", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x7E0650", Offset = "0x7E0650", VA = "0x7E0650", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x7E06EC", Offset = "0x7E06EC", VA = "0x7E06EC")]
	private void OnButtonClick(int buttonType)
	{
	}
}
[Token(Token = "0x2000060")]
public enum GameState
{
	[Token(Token = "0x40001AF")]
	PlaceLevel,
	[Token(Token = "0x40001B0")]
	Start,
	[Token(Token = "0x40001B1")]
	SelectWorld,
	[Token(Token = "0x40001B2")]
	SelectLevel,
	[Token(Token = "0x40001B3")]
	Settings,
	[Token(Token = "0x40001B4")]
	Privacy,
	[Token(Token = "0x40001B5")]
	NoEntitlement,
	[Token(Token = "0x40001B6")]
	LevelEditor,
	[Token(Token = "0x40001B7")]
	Error,
	[Token(Token = "0x40001B8")]
	SpawnLevel,
	[Token(Token = "0x40001B9")]
	Play,
	[Token(Token = "0x40001BA")]
	Pause,
	[Token(Token = "0x40001BB")]
	Win,
	[Token(Token = "0x40001BC")]
	Scoreboard,
	[Token(Token = "0x40001BD")]
	Lose,
	[Token(Token = "0x40001BE")]
	Outro,
	[Token(Token = "0x40001BF")]
	Cutscene,
	[Token(Token = "0x40001C0")]
	Initialize
}
[Token(Token = "0x2000061")]
public sealed class GameStateData
{
	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameState gameState;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public GameState gameStatePrev;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameState gameStateNext;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public PlayType playType;

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x7E07BC", Offset = "0x7E07BC", VA = "0x7E07BC")]
	public GameStateData()
	{
	}
}
[Token(Token = "0x2000062")]
public abstract class GameStateBase : StateBase<GameState>
{
	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x7E07C4", Offset = "0x7E07C4", VA = "0x7E07C4", Slot = "7")]
	public virtual void FixedTick()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x7E07C8", Offset = "0x7E07C8", VA = "0x7E07C8", Slot = "8")]
	public virtual void LateTick()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x7E022C", Offset = "0x7E022C", VA = "0x7E022C")]
	protected GameStateBase()
	{
	}
}
[Token(Token = "0x2000063")]
public abstract class StateBase<T>
{
	[Token(Token = "0x60001BB")]
	public abstract void Enter();

	[Token(Token = "0x60001BC")]
	public abstract T Tick();

	[Token(Token = "0x60001BD")]
	public virtual void Exit()
	{
	}

	[Token(Token = "0x60001BE")]
	protected StateBase()
	{
	}
}
[Token(Token = "0x2000064")]
public enum LevelEditorStateType
{
	[Token(Token = "0x40001C6")]
	Editing,
	[Token(Token = "0x40001C7")]
	Menu,
	[Token(Token = "0x40001C8")]
	ManageMenu,
	[Token(Token = "0x40001C9")]
	SaveMenu,
	[Token(Token = "0x40001CA")]
	Recovery,
	[Token(Token = "0x40001CB")]
	WaitForPreviewDespawn,
	[Token(Token = "0x40001CC")]
	WaitForPreviewSpawn,
	[Token(Token = "0x40001CD")]
	WaitForLoadEnvironment,
	[Token(Token = "0x40001CE")]
	TransitionToWorldSelect,
	[Token(Token = "0x40001CF")]
	TransitionToTryPlay,
	[Token(Token = "0x40001D0")]
	TransitionToEditing,
	[Token(Token = "0x40001D1")]
	TransitionToManageMenu,
	[Token(Token = "0x40001D2")]
	TransitionToSaveMenu,
	[Token(Token = "0x40001D3")]
	TransitionToUploadTrial,
	[Token(Token = "0x40001D4")]
	TransitionToBuildLevelsPlay,
	[Token(Token = "0x40001D5")]
	TransitionToFavoriteLevelsPlay,
	[Token(Token = "0x40001D6")]
	TransitionToError,
	[Token(Token = "0x40001D7")]
	TransitionToDiscoveryLevelsPlay,
	[Token(Token = "0x40001D8")]
	TransitionToSearchLevelPlay,
	[Token(Token = "0x40001D9")]
	TransitionToUserProfilePlay,
	[Token(Token = "0x40001DA")]
	TransitionToPreviousPlay
}
[Token(Token = "0x2000065")]
public abstract class LevelEditorStateBase : StateBase<LevelEditorStateType>
{
	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x7E07CC", Offset = "0x7E07CC", VA = "0x7E07CC")]
	protected LevelEditorStateBase()
	{
	}
}
[Token(Token = "0x2000066")]
public sealed class LevelEditorState : GameStateBase
{
	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly IntroComponent intro;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly Func<WorldType, IEnumerator> loadEnvironment;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly LevelEditorComponent levelEditor;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly TensionHand tensionHand;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly LevelEditorVRController vrControllerLevelEditor;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly Toolbox toolbox;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly SplitMenu manageLevels;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly LevelBuildingHandler levelBuildingHandler;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly PlayerConstraintsHandler playerConstraintsHandler;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly RecoveryMenu recoveryMenu;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly UiMenuHandlerBase<RecoveryMenuButton, RecoveryMenuButtonType> recoveryMenuHandler;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly MenuSettings menuSettings;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly LevelEditorVRControllerHandler levelEditorVRControllerHandler;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly SplitMenuHandler[] splitMenuHandlers;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private uint saveIndex;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private GameObject editingPlatform;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Transform levelTransform;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private int yStep;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly LevelEditorStateBase[] states;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private LevelEditorStateType state;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private LevelEditorStateType prevState;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool isAtMenuPosition;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private GameState nextGameState;

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x7E0814", Offset = "0x7E0814", VA = "0x7E0814")]
	public LevelEditorState(GameStateData gameStateData, NetworkHandler networkHandler, WorldContext worldContext, PalazzoTriggers palazzoTriggers, InputHandler inputHandler, TeleportationHandler teleportationHandler, IntroComponent intro, MonoBehaviour monoBehaviour, LevelEditorComponent levelEditor, Func<WorldType, IEnumerator> loadEnvironment, ARTransforms arTransforms, TrajectoryHandler trajectoryHandler, SplitMenu[] splitMenus, MenuSettings menuSettings, LevelContext levelContext, PalazzoComponentSlingshot slingshot, TensionHand tensionHand, PalazzoComponentBirdPlatform birdPlatform, LevelEditorVRController vrControllerLevelEditor, Toolbox toolbox, FadeHandler fadeHandler, ToolboxSettings toolboxSettings, LevelEditorContext levelEditorContext, LevelEditorPlayContext levelEditorPlayContext, LevelEditorSettings levelEditorSettings, LevelFactory levelFactory, PlayerConstraintsHandler playerConstraintsHandler, RecoveryMenu recoveryMenu, CreateUserMenu createUserMenu, ReportMenu reportMenu, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x7E0C40", Offset = "0x7E0C40", VA = "0x7E0C40", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x7E0E0C", Offset = "0x7E0E0C", VA = "0x7E0E0C", Slot = "7")]
	public override void FixedTick()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x7E0E40", Offset = "0x7E0E40", VA = "0x7E0E40", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x7E1A5C", Offset = "0x7E1A5C", VA = "0x7E1A5C", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x7E1B70", Offset = "0x7E1B70", VA = "0x7E1B70")]
	private void OnRecoveryMenuButtonClick(int buttonTypeInt)
	{
	}
}
[Token(Token = "0x2000067")]
public sealed class LoseState : GameStateBase
{
	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly BirdsRemainingHandler birdsRemainingHandler;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LoseScreenHandler[] loseScreenHandlers;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly HealthBarHandler healthBarHandler;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly EnvironmentPhysicsHandler environmentPhysicsHandler;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isCustomLevel;

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x7E1DA0", Offset = "0x7E1DA0", VA = "0x7E1DA0")]
	public LoseState(GameStateData gameStateData, LoseScreen[] loseScreens, BirdsRemainingHandler birdsRemainingHandler, HealthBarHandler healthBarHandler, LevelContext levelContext, LevelEditorContext levelEditorContext, LevelEditorPlayContext levelEditorPlayContext, EnvironmentPhysicsHandler environmentPhysicsHandler, WorldContext worldContext, ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, PalazzoGameDataPersistent gameDataPersistent, MenuSettings menuSettings, PalazzoWorld[] worldPrefabs, MonoBehaviour monoBehaviour, Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen, NetworkHandler networkHandler, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x7E2030", Offset = "0x7E2030", VA = "0x7E2030", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x7E2300", Offset = "0x7E2300", VA = "0x7E2300", Slot = "7")]
	public override void FixedTick()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x7E2318", Offset = "0x7E2318", VA = "0x7E2318", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x7E2360", Offset = "0x7E2360", VA = "0x7E2360", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x7E25D4", Offset = "0x7E25D4", VA = "0x7E25D4")]
	public void PositionGui()
	{
	}
}
[Token(Token = "0x2000068")]
public sealed class NoEntitlementState : GameStateBase
{
	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameObject noEntitlementScreen;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly MenuSettings menuSettings;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float showNoEntitlementTimer;

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x7E261C", Offset = "0x7E261C", VA = "0x7E261C")]
	public NoEntitlementState(GameObject noEntitlementScreen, MenuSettings menuSettings)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x7E264C", Offset = "0x7E264C", VA = "0x7E264C", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x7E26D8", Offset = "0x7E26D8", VA = "0x7E26D8", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}
}
[Token(Token = "0x2000069")]
public sealed class OutroState : GameStateBase
{
	[Token(Token = "0x200006A")]
	private enum State
	{
		[Token(Token = "0x4000215")]
		Setup,
		[Token(Token = "0x4000216")]
		WaitForFade,
		[Token(Token = "0x4000217")]
		PlayOutro
	}

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly OutroHandler outroHandler;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly OutroComponent outro;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Func<IEnumerator> despawnLevel;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private State state;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private State prevState;

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x7E2718", Offset = "0x7E2718", VA = "0x7E2718")]
	public OutroState(OutroHandler outroHandler, MonoBehaviour monoBehaviour, LevelContext levelContext, TeleportationHandler teleportationHandler, PalazzoTriggers palazzoTriggers, OutroComponent outro, Func<IEnumerator> despawnLevel, FadeHandler fadeHandler)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x7E2784", Offset = "0x7E2784", VA = "0x7E2784", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x7E278C", Offset = "0x7E278C", VA = "0x7E278C", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}
}
[Token(Token = "0x200006B")]
public sealed class PauseState : GameStateBase
{
	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly TrajectoryMarkerSettings trajectoryMarkerSettings;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PauseScreenHandler[] pauseScreenHandlers;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly EnvironmentPhysicsHandler environmentPhysicsHandler;

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x7E2928", Offset = "0x7E2928", VA = "0x7E2928")]
	public PauseState(GameStateData gameStateData, PauseScreen[] pauseScreens, WorldContext worldContext, TrajectoryMarkerSettings trajectoryMarkerSettings, ARTransforms arTransforms, InputHandler inputHandler, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, PalazzoTriggers palazzoTriggers, PalazzoGameDataPersistent gameDataPersistent, MonoBehaviour monoBehaviour, LevelContext levelContext, PalazzoWorld[] worldPrefabs, Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen, LevelEditorPlayContext levelEditorPlayContext, NetworkHandler networkHandler, CreateUserSettings createUserSettings, EnvironmentPhysicsHandler environmentPhysicsHandler)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x7E2B78", Offset = "0x7E2B78", VA = "0x7E2B78", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x7E2BF4", Offset = "0x7E2BF4", VA = "0x7E2BF4", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x7E2CB4", Offset = "0x7E2CB4", VA = "0x7E2CB4", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x7E2CFC", Offset = "0x7E2CFC", VA = "0x7E2CFC", Slot = "7")]
	public override void FixedTick()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x7E2D14", Offset = "0x7E2D14", VA = "0x7E2D14")]
	public void PositionGui()
	{
	}
}
[Token(Token = "0x200006C")]
public sealed class PlaceLevelState : GameStateBase
{
	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly WorldTracker worldTracker;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Action<Vector3> onPlaceLevel;

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x7E2D5C", Offset = "0x7E2D5C", VA = "0x7E2D5C")]
	public PlaceLevelState(ARTransforms arTransforms, WorldTracker worldTracker, Action<Vector3> onPlaceLevel)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x7E2D94", Offset = "0x7E2D94", VA = "0x7E2D94", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x7E2E68", Offset = "0x7E2E68", VA = "0x7E2E68", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}
}
[Token(Token = "0x200006D")]
public sealed class PlayState : GameStateBase
{
	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly TutorialHandler tutorialHandler;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly TeleportAimHandler teleportAimHandler;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly BirdSpecialAbilityHandler birdSpecialAbilityHandler;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly SlingshotLoader slingshotLoader;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly SlingshotAimHandler slingshotAimHandler;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly TelePointHandler telePointHandler;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly BirdsRemainingHandler birdsRemainingHandler;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly HealthBarHandler healthBarHandler;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly DamageHandler damageHandler;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly PigEmotionalStateHandler pigEmotionalStateHandler;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly LevelFactory levelFactory;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly CharacterLookAtHandler characterLookAtHandler;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly PlayStateSettings playStateSettings;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly LevelEditorVRController levelEditorVrController;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly EnvironmentPhysicsHandler environmentPhysicsHandler;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float noPigsTimer;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float noBirdsTimer;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool waitingOnDespawn;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private GameState nextGameState;

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x7E2EB8", Offset = "0x7E2EB8", VA = "0x7E2EB8")]
	public PlayState(GameStateData gameStateData, InputHandler inputHandler, LevelContext levelContext, TrajectoryHandler trajectoryHandler, TutorialHandler tutorialHandler, TeleportationHandler teleportationHandler, BirdSpecialAbilityHandler birdSpecialAbilityHandler, SlingshotLoader slingshotLoader, SlingshotAimHandler slingshotAimHandler, TeleportAimHandler teleportAimHandler, TelePointHandler telePointHandler, BirdsRemainingHandler birdsRemainingHandler, HealthBarHandler healthBarHandler, DamageHandler damageHandler, PigEmotionalStateHandler pigEmotionalStateHandler, LevelFactory levelFactory, ARTransforms arTransforms, PalazzoComponentSlingshot slingshot, CharacterLookAtHandler characterLookAtHandler, PlayStateSettings playStateSettings, EnvironmentPhysicsHandler environmentPhysicsHandler, PalazzoTriggers palazzoTriggers)
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x7E2F98", Offset = "0x7E2F98", VA = "0x7E2F98", Slot = "7")]
	public override void FixedTick()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x7E3004", Offset = "0x7E3004", VA = "0x7E3004", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x7E3090", Offset = "0x7E3090", VA = "0x7E3090", Slot = "8")]
	public override void LateTick()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x7E30C0", Offset = "0x7E30C0", VA = "0x7E30C0", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x7E34F0", Offset = "0x7E34F0", VA = "0x7E34F0", Slot = "6")]
	public override void Exit()
	{
	}
}
[Token(Token = "0x200006E")]
public sealed class PrivacyState : GameStateBase
{
	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly UiMenuHandlerBase<PrivacyButton, PrivacyButtonType> menuHandler;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PrivacyMenu privacyMenu;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly ButtonHandler<PrivacyButton> buttonHandler;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action OnAccept;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly IntroComponent introComponent;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameState nextGameState;

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x7E3554", Offset = "0x7E3554", VA = "0x7E3554")]
	public PrivacyState(ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, PrivacyMenu privacyMenu, MenuSettings menuSettings, PalazzoGameDataPersistent gameDataPersistent, IntroComponent introComponent, WorldContext worldContext)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x7E36A0", Offset = "0x7E36A0", VA = "0x7E36A0", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x7E374C", Offset = "0x7E374C", VA = "0x7E374C", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x7E37A4", Offset = "0x7E37A4", VA = "0x7E37A4")]
	private void OnClickButton(int buttonIndex)
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x7E38C4", Offset = "0x7E38C4", VA = "0x7E38C4", Slot = "6")]
	public override void Exit()
	{
	}
}
[Token(Token = "0x200006F")]
public class ScoreboardState : GameStateBase
{
	[Token(Token = "0x2000070")]
	private enum State
	{
		[Token(Token = "0x400024D")]
		Scoreboard,
		[Token(Token = "0x400024E")]
		RatingScreen
	}

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly BirdsRemainingHandler birdsRemainingHandler;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly EnvironmentPhysicsHandler environmentPhysicsHandler;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PlayMenuHandlerBase[] menuHandlers;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly RatingScreenHandler ratingScreenHandler;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private State state;

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x7E3914", Offset = "0x7E3914", VA = "0x7E3914")]
	public ScoreboardState(GameStateData gameStateData, PlayMenuBase<ScoreboardButton>[] scoreboards, RatingScreen ratingScreen, BirdsRemainingHandler birdsRemainingHandler, EnvironmentPhysicsHandler environmentPhysicsHandler, ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, ScoreboardContext scoreboardContext, ScoreboardSettings scoreboardSettings, WorldContext worldContext, MenuSettings menuSettings, PalazzoWorld[] worldPrefabs, MonoBehaviour monoBehaviour, Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen, NetworkHandler networkHandler, LevelEditorPlayContext levelEditorPlayContext, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x7E3D08", Offset = "0x7E3D08", VA = "0x7E3D08", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x7E3DC0", Offset = "0x7E3DC0", VA = "0x7E3DC0", Slot = "7")]
	public override void FixedTick()
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x7E3DD8", Offset = "0x7E3DD8", VA = "0x7E3DD8", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x7E3E50", Offset = "0x7E3E50", VA = "0x7E3E50", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x7E3EC0", Offset = "0x7E3EC0", VA = "0x7E3EC0")]
	public void PositionGui()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x7E3F20", Offset = "0x7E3F20", VA = "0x7E3F20")]
	private void OnRatingScreenButtonClicked()
	{
	}
}
[Token(Token = "0x2000071")]
public sealed class SelectLevelState : GameStateBase
{
	[Token(Token = "0x2000072")]
	private enum State
	{
		[Token(Token = "0x4000269")]
		WaitForInput,
		[Token(Token = "0x400026A")]
		TransitionOutToSpawnLevel,
		[Token(Token = "0x400026B")]
		TransitionOutToWorldSelect,
		[Token(Token = "0x400026C")]
		TeleportToStart
	}

	[Token(Token = "0x400024F")]
	private const float TRANSITION_OUT_SECONDS = 0.5f;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly MenuContext menuContext;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelSelect levelSelect;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<string> levelSelectGuids;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly PalazzoWorld[] worldPrefabs;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly PalazzoComponentLevel[] levelPrefabs;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly LevelSelectSettings levelSelectSettings;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly UiMenuHandlerBase<LevelButton, LevelSelectButtonType> menuHandler;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly LevelButton[] buttons;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly int numberOfLevels;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int selectedLevelIndex;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private State state;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private State prevState;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GameState nextGameState;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float transitionOutTimer;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3? startPosition;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float? startRotation;

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x7E3F54", Offset = "0x7E3F54", VA = "0x7E3F54")]
	public SelectLevelState(MenuContext menuContext, GameStateData gameStateData, ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, LevelContext levelContext, LevelSelect levelSelect, List<string> levelSelectGuids, PalazzoGameDataPersistent gameDataPersistent, WorldContext worldContext, MenuSettings menuSettings, PalazzoWorld[] worldPrefabs, PalazzoComponentLevel[] levelPrefabs, LevelSelectSettings levelSelectSettings, TeleportationHandler teleportationHandler, FadeHandler fadeHandler, PalazzoComponentBirdPlatform birdPlatform)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x7E4160", Offset = "0x7E4160", VA = "0x7E4160", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x7E41C8", Offset = "0x7E41C8", VA = "0x7E41C8", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x7E4268", Offset = "0x7E4268", VA = "0x7E4268", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x7E4D44", Offset = "0x7E4D44", VA = "0x7E4D44")]
	private void OnClickLevelButton(int buttonIndex)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x7E4EE4", Offset = "0x7E4EE4", VA = "0x7E4EE4")]
	private void OnHoverLevelButton(int buttonIndex)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x7E4E6C", Offset = "0x7E4E6C", VA = "0x7E4E6C")]
	private int ButtonIndexToLevelIndex(int buttonIndex)
	{
		return default(int);
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x7E4778", Offset = "0x7E4778", VA = "0x7E4778")]
	private void RefreshLevelButtons()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x7E4B5C", Offset = "0x7E4B5C", VA = "0x7E4B5C")]
	private void SetMaterials()
	{
	}
}
[Token(Token = "0x2000073")]
public sealed class SelectWorldState : GameStateBase
{
	[Token(Token = "0x2000074")]
	private enum State
	{
		[Token(Token = "0x400029A")]
		WaitForInputModeSelect,
		[Token(Token = "0x400029B")]
		WaitForInputWorldSelect,
		[Token(Token = "0x400029C")]
		TeleportToStartPosition,
		[Token(Token = "0x400029D")]
		LoadEnvironment,
		[Token(Token = "0x400029E")]
		TransitionToQuickPlay,
		[Token(Token = "0x400029F")]
		TransitionToGameState,
		[Token(Token = "0x40002A0")]
		TransitionToProfile
	}

	[Token(Token = "0x400026D")]
	private const float TRANSITION_OUT_SECONDS = 0.5f;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly MenuContext menuContext;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly WorldSelectMenu worldSelectMenu;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly WorldSelectSubMenu modeMenu;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly WorldSelectSubMenu worldMenus;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelSelect levelSelect;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly PalazzoWorld[] worldPrefabs;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly List<string> levelGuids;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly WorldSelectButton spookyModeButton;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly WorldSelectButton levelEditorModeButton;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly IntroComponent intro;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly Func<WorldType, IEnumerator> loadEnvironment;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly GameObject spookyRain;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly AchievementHandler achievementHandler;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly UiMenuHandlerBase<WorldSelectButton, WorldSelectButtonType> modeMenuHandler;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly UiMenuHandlerBase<WorldSelectButton, WorldSelectButtonType> worldMenusHandler;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000287")]
	private const string PRIVACY_POLICY_URL = "http://www.resolutiongames.com";

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private State state;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private State prevState;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int worldIndex;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float transitionTimer;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly WorldSelectButton[] worldButtons;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool shouldUnlock;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
	private bool hasFinishedPlayingAnimation;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float unlockTimer;

	[Token(Token = "0x4000290")]
	private const float UNLOCK_DELAY = 1f;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private WorldSelectButton buttonToUnlock;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Vector3? startPosition;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private float? startRotation;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private bool isInModeSelect;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Future<ServerLevelMetaData> quickplayLevelFuture;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Future<User> getUserDataFuture;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private GameState nextGameState;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private GameState postTransitionState;

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x7E5098", Offset = "0x7E5098", VA = "0x7E5098")]
	public SelectWorldState(MenuContext menuContext, GameStateData gameStateData, ARTransforms arTransforms, WorldSelectMenu worldSelectMenu, LevelSelect levelSelect, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, PalazzoWorld[] worldPrefabs, PalazzoGameDataPersistent gameDataPersistent, WorldContext worldContext, MenuSettings menuSettings, List<string> levelGuids, TeleportationHandler teleportationHandler, FadeHandler fadeHandler, IntroComponent intro, MonoBehaviour monoBehaviour, Func<WorldType, IEnumerator> loadEnvironment, GameObject spookyRain, AchievementHandler achievementHandler, NetworkHandler networkHandler, LevelEditorPlayContext levelEditorPlayContext, LevelContext levelContext)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x7E5A58", Offset = "0x7E5A58", VA = "0x7E5A58")]
	private void UpdateButtons()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x7E5BC0", Offset = "0x7E5BC0", VA = "0x7E5BC0", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x7E5D84", Offset = "0x7E5D84", VA = "0x7E5D84", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x7E5DE4", Offset = "0x7E5DE4", VA = "0x7E5DE4", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x7E6FC0", Offset = "0x7E6FC0", VA = "0x7E6FC0")]
	private void OnClickWorldSelectButton(int buttonIndex)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x7E58E0", Offset = "0x7E58E0", VA = "0x7E58E0")]
	private bool IsNightmareModeUnlocked()
	{
		return default(bool);
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x7E6DD4", Offset = "0x7E6DD4", VA = "0x7E6DD4")]
	private void UnlockSpookyIfNeeded()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x7E6C40", Offset = "0x7E6C40", VA = "0x7E6C40")]
	private void UnlockWorldButtonsIfNeeded()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x7E6A0C", Offset = "0x7E6A0C", VA = "0x7E6A0C")]
	private void UpdateWorldButtonStarText()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x7E7168", Offset = "0x7E7168", VA = "0x7E7168")]
	private void UnlockButton(WorldSelectButton button)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x7E7180", Offset = "0x7E7180", VA = "0x7E7180")]
	private void OnClickModeButton(int buttonIndex)
	{
	}
}
[Token(Token = "0x2000076")]
public sealed class SettingsState : GameStateBase
{
	[Token(Token = "0x2000077")]
	private enum ConfirmType
	{
		[Token(Token = "0x40002B7")]
		Quit,
		[Token(Token = "0x40002B8")]
		Reset
	}

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly SettingsMenu settingsMenu;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly AudioMixerGroup musicAudioGroup;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly AudioMixerGroup soundAudioGroup;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly SettingsMenuButton[] buttons;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly UiMenuHandlerBase<SettingsMenuButton, SettingsMenuButtonType> menuHandler;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly float defaultMusicVolume;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private readonly float defaultSoundVolume;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly string confirmQuitId;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly string confirmResetId;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly string resetFeedbackId;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly string privacyFeedbackId;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly string termsFeedbackId;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool init;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private ConfirmType confirmType;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameState nextGameState;

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x7E7358", Offset = "0x7E7358", VA = "0x7E7358")]
	public SettingsState(ARTransforms arTransforms, SettingsMenu settingsMenu, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, AudioMixerGroup musicAudioGroup, AudioMixerGroup soundAudioGroup, PalazzoGameDataPersistent gameDataPersistent, MenuSettings menuSettings, WorldContext worldContext)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x7E7A50", Offset = "0x7E7A50", VA = "0x7E7A50", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x7E7AB0", Offset = "0x7E7AB0", VA = "0x7E7AB0", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x7E7B08", Offset = "0x7E7B08", VA = "0x7E7B08", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x7E7BC8", Offset = "0x7E7BC8", VA = "0x7E7BC8")]
	private void OnClickButton(int buttonIndex)
	{
	}
}
[Token(Token = "0x2000078")]
public sealed class SpawnLevelState : GameStateBase
{
	[Token(Token = "0x2000079")]
	private enum State
	{
		[Token(Token = "0x40002D0")]
		LoadEnvironment,
		[Token(Token = "0x40002D1")]
		WaitOnCutscene,
		[Token(Token = "0x40002D2")]
		WaitOnSpawnEffect,
		[Token(Token = "0x40002D3")]
		FadeAfterCutScene,
		[Token(Token = "0x40002D4")]
		StartLevel,
		[Token(Token = "0x40002D5")]
		TeleportToStartPosition
	}

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly TutorialHandler tutorialHandler;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly IntroComponent intro;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly BirdsRemainingHandler birdsRemainingHandler;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly HealthBarHandler healthBarHandler;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly CutsceneHandler cutsceneHandler;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly PalazzoComponentLevel[] levelPrefabs;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly LevelFactory levelFactory;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OutroComponent outro;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Func<WorldType, IEnumerator> loadEnvironment;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly EnvironmentPhysicsHandler environmentPhysicsHandler;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private State state;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private State prevState;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameState nextGameState;

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x7E8300", Offset = "0x7E8300", VA = "0x7E8300")]
	public SpawnLevelState(GameStateData gameStateData, TutorialHandler tutorialHandler, IntroComponent intro, PalazzoTriggers palazzoTriggers, BirdsRemainingHandler birdsRemainingHandler, HealthBarHandler healthBarHandler, LevelContext levelContext, CutsceneHandler cutsceneHandler, TeleportationHandler teleportationHandler, FadeHandler fadeHandler, PalazzoComponentLevel[] levelPrefabs, LevelFactory levelFactory, OutroComponent outro, PalazzoComponentBirdPlatform birdPlatform, WorldContext worldContext, MonoBehaviour monoBehaviour, Func<WorldType, IEnumerator> loadEnvironment, LevelEditorPlayContext levelEditorPlayContext, EnvironmentPhysicsHandler environmentPhysicsHandler)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x7E83C8", Offset = "0x7E83C8", VA = "0x7E83C8", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x7E8534", Offset = "0x7E8534", VA = "0x7E8534", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x7E8894", Offset = "0x7E8894", VA = "0x7E8894", Slot = "7")]
	public override void FixedTick()
	{
	}
}
[Token(Token = "0x200007A")]
public sealed class StartState : GameStateBase
{
	[Token(Token = "0x200007B")]
	private enum State
	{
		[Token(Token = "0x40002E8")]
		Init,
		[Token(Token = "0x40002E9")]
		LoadEnvironment,
		[Token(Token = "0x40002EA")]
		Start
	}

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly Func<WorldType, IEnumerator> loadEnvironment;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly TensionHand tensionHand;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly UiMenuHandlerBase<PalazzoButton, StartButtonType> menuHandler;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly IntroComponent introComponent;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly AmbientAudioComponent ambientAudioComponent;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool gameHasStarted;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private State state;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private State prevState;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private GameState nextGameState;

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x7E88AC", Offset = "0x7E88AC", VA = "0x7E88AC")]
	public StartState(IntroComponent introComponent, StartScreen startScreen, ARTransforms arTransforms, InputHandler inputHandler, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, PalazzoGameDataPersistent gameDataPersistent, FadeHandler fadeHandler, AmbientAudioComponent ambientAudioComponent, PalazzoTriggers palazzoTriggers, Func<WorldType, IEnumerator> loadEnvironment, MonoBehaviour monoBehaviour, WorldContext worldContext, TeleportationHandler teleportationHandler, PalazzoComponentSlingshot slingshot, TensionHand tensionHand)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x7E8A48", Offset = "0x7E8A48", VA = "0x7E8A48", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x7E8AB0", Offset = "0x7E8AB0", VA = "0x7E8AB0", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x7E8C90", Offset = "0x7E8C90", VA = "0x7E8C90")]
	private void OnButtonClicked(int buttonIndex)
	{
	}
}
[Token(Token = "0x200007C")]
public class WinState : GameStateBase
{
	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly SlingshotAimHandler slingshotAimHandler;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly SlingshotLoader slingshotLoader;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly ScoreboardContext scoreboardContext;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly CutsceneHandler cutsceneHandler;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly PalazzoComponentLevel[] levelPrefabs;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly AchievementHandler achievementHandler;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly EnvironmentPhysicsHandler environmentPhysicsHandler;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x40002FA")]
	private const int NUM_LEVEL_STARS_PER_WORLD = 39;

	[Token(Token = "0x40002FB")]
	private const int NUM_TOTAL_LEVEL_STARS_VACATION = 156;

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x7E8DE8", Offset = "0x7E8DE8", VA = "0x7E8DE8")]
	public WinState(GameStateData gameStateData, LevelContext levelContext, LevelEditorContext levelEditorContext, InputHandler inputHandler, SlingshotAimHandler slingshotAimHandler, SlingshotLoader slingshotLoader, PalazzoTriggers palazzoTriggers, ScoreboardContext scoreboardContext, CutsceneHandler cutsceneHandler, PalazzoGameDataPersistent gameDataPersistent, PalazzoComponentLevel[] levelPrefabs, AchievementHandler achievementHandler, EnvironmentPhysicsHandler environmentPhysicsHandler, LevelEditorPlayContext levelEditorPlayContext, NetworkHandler networkHandler)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x7E8E90", Offset = "0x7E8E90", VA = "0x7E8E90", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x7E8E94", Offset = "0x7E8E94", VA = "0x7E8E94", Slot = "7")]
	public override void FixedTick()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x7E8EAC", Offset = "0x7E8EAC", VA = "0x7E8EAC", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}
}
[Token(Token = "0x200007D")]
public sealed class HealthBarHandler
{
	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x7E9930", Offset = "0x7E9930", VA = "0x7E9930")]
	public HealthBarHandler(ARTransforms arTransforms, LevelContext levelContext, InputHandler inputHandler)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x7E23C8", Offset = "0x7E23C8", VA = "0x7E23C8")]
	public void Tick()
	{
	}
}
[Token(Token = "0x200007E")]
public sealed class HistoryHandler
{
	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly BuildingBlockFactory buildingBlockFactory;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Stack<IHistoryEvent> undoStack;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Stack<IHistoryEvent> redoStack;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Dictionary<int, LevelBuildingBlock> blockLookup;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Stack<int> idStack;

	[Token(Token = "0x17000010")]
	public bool IsRecording
	{
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x7E996C", Offset = "0x7E996C", VA = "0x7E996C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x7E9974", Offset = "0x7E9974", VA = "0x7E9974")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x7E9980", Offset = "0x7E9980", VA = "0x7E9980")]
	public HistoryHandler(LevelEditorContext levelEditorContext, BuildingBlockFactory buildingBlockFactory)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x7E9C30", Offset = "0x7E9C30", VA = "0x7E9C30")]
	public IHistoryEvent Do(IHistoryEvent historyEvent, bool clearRedo = true)
	{
		return null;
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x7EA398", Offset = "0x7EA398", VA = "0x7EA398")]
	public void Undo()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x7EA8DC", Offset = "0x7EA8DC", VA = "0x7EA8DC")]
	public void Redo()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x7EA958", Offset = "0x7EA958", VA = "0x7EA958")]
	public IHistoryEvent PeekRedo()
	{
		return null;
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x7EA874", Offset = "0x7EA874", VA = "0x7EA874")]
	public IHistoryEvent PeekUndo()
	{
		return null;
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x7EA9C0", Offset = "0x7EA9C0", VA = "0x7EA9C0")]
	public static bool IsUndoEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x7EAA28", Offset = "0x7EAA28", VA = "0x7EAA28")]
	public static bool IsRedoEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x7EAA90", Offset = "0x7EAA90", VA = "0x7EAA90")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x7E9AE4", Offset = "0x7E9AE4", VA = "0x7E9AE4")]
	private void RefreshIdStack([Optional] ICollection<int> excludedIds)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x7EAB10", Offset = "0x7EAB10", VA = "0x7EAB10")]
	public void BuildLevel(List<BlockData> blocks)
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x7EADB0", Offset = "0x7EADB0", VA = "0x7EADB0")]
	public void RedoHistory()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x7EA2A8", Offset = "0x7EA2A8", VA = "0x7EA2A8")]
	public LevelBuildingBlock GetLevelBuildingBlock(int id)
	{
		return null;
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x7EA1A4", Offset = "0x7EA1A4", VA = "0x7EA1A4")]
	private LevelBuildingBlock CreateLevelBuildingBlock(int prefabId, [Optional] int? id)
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x7EA300", Offset = "0x7EA300", VA = "0x7EA300")]
	private void DestroyLevelBuildingBlock(LevelBuildingBlock block)
	{
	}
}
[Token(Token = "0x200007F")]
public interface IHistoryEvent
{
}
[Token(Token = "0x2000080")]
public struct MoveEvent : IHistoryEvent
{
	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int blockId;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Vector3 newPosition;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Quaternion newRotation;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 oldPosition;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Quaternion oldRotation;

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x7EBF5C", Offset = "0x7EBF5C", VA = "0x7EBF5C")]
	public MoveEvent(int blockId, Vector3 oldPosition, Quaternion oldRotation, Vector3 newPosition, Quaternion newRotation)
	{
	}
}
[Token(Token = "0x2000081")]
public struct SpawnEvent : IHistoryEvent
{
	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int prefabId;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Vector3 localPosition;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Quaternion localRotation;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int blockId;

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x7EBF8C", Offset = "0x7EBF8C", VA = "0x7EBF8C")]
	public SpawnEvent(int prefabId, Vector3 localPosition, Quaternion localRotation)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x7EBFAC", Offset = "0x7EBFAC", VA = "0x7EBFAC")]
	public SpawnEvent(BlockData data)
	{
	}
}
[Token(Token = "0x2000082")]
public struct DespawnEvent : IHistoryEvent
{
	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int blockId;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int prefabId;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Vector3 localPosition;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Quaternion localRotation;

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x7EC000", Offset = "0x7EC000", VA = "0x7EC000")]
	public DespawnEvent(int blockId, Vector3 oldPosition, Quaternion oldRotation)
	{
	}
}
[Token(Token = "0x2000083")]
public struct ClearLevelEvent : IHistoryEvent
{
	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int blockCount;
}
[Token(Token = "0x2000084")]
public abstract class ImpactQueue<T> where T : struct
{
	[Token(Token = "0x4000314")]
	private const double INV_LOG2 = 1.44269504088896;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected T[] buffer;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int maxCapacity;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int capacity;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int size;

	[Token(Token = "0x17000011")]
	public int Size
	{
		[Token(Token = "0x600022E")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000012")]
	public T[] Buffer
	{
		[Token(Token = "0x600022F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000230")]
	protected ImpactQueue(int capacity, int maxCapacity)
	{
	}

	[Token(Token = "0x6000231")]
	private void IncreaseCapacity(int n)
	{
	}

	[Token(Token = "0x6000232")]
	protected int Allocate()
	{
		return default(int);
	}

	[Token(Token = "0x6000233")]
	public void Clear()
	{
	}
}
[Token(Token = "0x2000085")]
public sealed class BirdImpactQueue : ImpactQueue<BirdImpactQueue.Data>
{
	[Token(Token = "0x2000086")]
	public struct Data
	{
		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PalazzoComponentBird bird;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public BlockType hitBlockType;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int impactType;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float impactMagnitude;
	}

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Dictionary<int, WorldImpactComponent> colliderWorldImpactLookup;

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x7EC01C", Offset = "0x7EC01C", VA = "0x7EC01C")]
	public BirdImpactQueue(int capacity, Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup, Dictionary<int, WorldImpactComponent> colliderWorldImpactLookup)
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x7EC090", Offset = "0x7EC090", VA = "0x7EC090")]
	public void Enqueue(PalazzoComponentBird dst, Collision collision)
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x7EC31C", Offset = "0x7EC31C", VA = "0x7EC31C")]
	public void Enqueue(PalazzoComponentBird dst, Collider collider)
	{
	}
}
[Token(Token = "0x2000087")]
public sealed class DamageQueue : ImpactQueue<DamageQueue.Data>
{
	[Token(Token = "0x2000088")]
	public struct Data
	{
		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DamageComponent damageComponent;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int damageType;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float damageMagnitude;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 impactPosition;
	}

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Dictionary<int, WorldImpactComponent> colliderWorldImpactLookup;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private PalazzoComponentLevelBlock otherBlock;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private WorldImpactComponent worldImpact;

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x7EC4F4", Offset = "0x7EC4F4", VA = "0x7EC4F4")]
	public DamageQueue(int capacity, Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup, Dictionary<int, WorldImpactComponent> colliderWorldImpactLookup)
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x7EC568", Offset = "0x7EC568", VA = "0x7EC568")]
	public void Enqueue(DamageComponent dst, Collision collision)
	{
	}
}
[Token(Token = "0x2000089")]
public sealed class WorldImpactQueue : ImpactQueue<WorldImpactQueue.Data>
{
	[Token(Token = "0x200008A")]
	public struct Data
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WorldImpactComponent worldImpactComponent;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PalazzoComponentLevelBlock levelBlock;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 impactPosition;
	}

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup;

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x7EC8D0", Offset = "0x7EC8D0", VA = "0x7EC8D0")]
	public WorldImpactQueue(int capacity, Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x7EC938", Offset = "0x7EC938", VA = "0x7EC938")]
	public void Enqueue(WorldImpactComponent dst, Collision collision)
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x7ECA5C", Offset = "0x7ECA5C", VA = "0x7ECA5C")]
	public void Enqueue(WorldImpactComponent dst, Collider collider)
	{
	}
}
[Token(Token = "0x200008B")]
public sealed class EffectOnImpactQueue : ImpactQueue<EffectOnImpactQueue.Data>
{
	[Token(Token = "0x200008C")]
	public struct Data
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EffectOnImpactComponent effectOnImpactComponent;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Quaternion originalRotation;
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x7ECB74", Offset = "0x7ECB74", VA = "0x7ECB74")]
	public EffectOnImpactQueue(int capacity)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x7ECBD0", Offset = "0x7ECBD0", VA = "0x7ECBD0")]
	public void Enqueue(EffectOnImpactComponent effectOnImpactComponent)
	{
	}
}
[Token(Token = "0x200008D")]
public sealed class WindVortexImpactQueue : ImpactQueue<WindVortexImpactQueue.Data>
{
	[Token(Token = "0x200008E")]
	public struct Data
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FanComponent fan;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WindComponent windComponent;
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x7ECCCC", Offset = "0x7ECCCC", VA = "0x7ECCCC")]
	public WindVortexImpactQueue(int capacity)
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x7ECD28", Offset = "0x7ECD28", VA = "0x7ECD28")]
	public void Enqueue(WindComponent windComponent, FanComponent fan)
	{
	}
}
[Token(Token = "0x200008F")]
public enum EffectType
{
	[Token(Token = "0x4000330")]
	OnImpact,
	[Token(Token = "0x4000331")]
	OnBirdImpactPig,
	[Token(Token = "0x4000332")]
	OnDamageComponentSwitchState,
	[Token(Token = "0x4000333")]
	OnBlockScore,
	[Token(Token = "0x4000334")]
	OnPigScore,
	[Token(Token = "0x4000335")]
	OnLevelBlockDestroy
}
[Token(Token = "0x2000090")]
public sealed class EffectQueue : FIFOQueue<EffectQueue.Data>
{
	[Token(Token = "0x2000091")]
	public struct Data
	{
		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EffectType effectType;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Vector3 impactPosition;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DamageComponent damageComponent;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PalazzoComponentLevelBlock block;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PalazzoComponentPig pig;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int score;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int scoreMultiplier;
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x7ECDA8", Offset = "0x7ECDA8", VA = "0x7ECDA8")]
	public EffectQueue(int capacity)
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x7ECE04", Offset = "0x7ECE04", VA = "0x7ECE04")]
	public int Dequeue()
	{
		return default(int);
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x7ECE4C", Offset = "0x7ECE4C", VA = "0x7ECE4C")]
	public void EnqueueOnImpact(Vector3 impactPosition, DamageComponent damageComponent)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x7ECF14", Offset = "0x7ECF14", VA = "0x7ECF14")]
	public void EnqueueOnBirdImpactPig(Vector3 impactPosition, DamageComponent damageComponent)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x7ECFE0", Offset = "0x7ECFE0", VA = "0x7ECFE0")]
	public void EnqueueOnDamageComponentSwitchState(DamageComponent damageComponent)
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x7ED068", Offset = "0x7ED068", VA = "0x7ED068")]
	public void EnquequeOnBlockScore(PalazzoComponentLevelBlock block)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x7ED0F0", Offset = "0x7ED0F0", VA = "0x7ED0F0")]
	public void EnquequeOnPigScore(PalazzoComponentPig pig, int score, int scoreMultiplier)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x7ED18C", Offset = "0x7ED18C", VA = "0x7ED18C")]
	public void EnqueueOnLevelBlockDestroy(PalazzoComponentLevelBlock block)
	{
	}
}
[Token(Token = "0x2000092")]
public abstract class FIFOQueue<T> where T : struct
{
	[Token(Token = "0x400033D")]
	private const double INV_LOG2 = 1.44269504088896;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected T[] buffer;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int maxCapacity;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int endIndex;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int startIndex;

	[Token(Token = "0x17000013")]
	public int Size
	{
		[Token(Token = "0x6000248")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000014")]
	public T[] Buffer
	{
		[Token(Token = "0x6000249")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000015")]
	public int capacity
	{
		[Token(Token = "0x600024A")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000016")]
	public int StartIndex
	{
		[Token(Token = "0x600024B")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000017")]
	public int EndIndex
	{
		[Token(Token = "0x600024C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600024D")]
	protected FIFOQueue(int capacity, int maxCapacity)
	{
	}

	[Token(Token = "0x600024E")]
	protected int Allocate()
	{
		return default(int);
	}

	[Token(Token = "0x600024F")]
	protected int Deallocate()
	{
		return default(int);
	}

	[Token(Token = "0x6000250")]
	public void Clear()
	{
	}
}
[Token(Token = "0x2000093")]
public sealed class ImpactTypeData : MonoBehaviour
{
	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string soundImpactHeavy;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string soundImpactMedium;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string soundImpactLight;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ParticleEffectComponent prefabImpactFx;

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x7ED214", Offset = "0x7ED214", VA = "0x7ED214")]
	public ImpactTypeData()
	{
	}
}
[Token(Token = "0x2000094")]
public enum InputType
{
	[Token(Token = "0x4000347")]
	MenuHand,
	[Token(Token = "0x4000348")]
	TensionHand,
	[Token(Token = "0x4000349")]
	SlingshotHand
}
[Token(Token = "0x2000095")]
public abstract class InputHandler
{
	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static readonly XRNode[] handLookup;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected readonly ARTransforms arTransforms;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected readonly PalazzoInputDevice inputDevice;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected readonly Transform slingshotTransform;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly bool[] triggerLastState;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Vector3[] handPositionCache;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Vector3[] handPostionWhileAimingCache;

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x7ED2A4", Offset = "0x7ED2A4", VA = "0x7ED2A4")]
	protected InputHandler(ARTransforms arTransforms, PalazzoInputDevice inputDevice, PalazzoComponentSlingshot slingshot, LevelContext levelContext, PalazzoGameDataPersistent gameDataPersistent)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x7ED3B8", Offset = "0x7ED3B8", VA = "0x7ED3B8")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x7ED8D0", Offset = "0x7ED8D0", VA = "0x7ED8D0", Slot = "4")]
	protected virtual void TickInternal()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x7ED8D4", Offset = "0x7ED8D4", VA = "0x7ED8D4")]
	public void Recenter()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x7ED8F4", Offset = "0x7ED8F4", VA = "0x7ED8F4")]
	public void PlayHapticOnce(HapticType hapticType, InputType hand, [Optional] float? amplitude)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x7ED9C4", Offset = "0x7ED9C4", VA = "0x7ED9C4")]
	public void PlayHapticUntilStop(HapticType hapticType, InputType hand, [Optional] float? amplitude)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x7EDA94", Offset = "0x7EDA94", VA = "0x7EDA94")]
	public void SetHapticAmplitude(HapticType hapticType, InputType hand, float amplitude)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x7EDB6C", Offset = "0x7EDB6C", VA = "0x7EDB6C")]
	public void StopHaptic(HapticType hapticType, InputType hand)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x7EDC30", Offset = "0x7EDC30", VA = "0x7EDC30", Slot = "5")]
	public virtual void SetHandedness(PlayerHandedness handedness)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x7EDC54", Offset = "0x7EDC54", VA = "0x7EDC54", Slot = "6")]
	public virtual bool TriggerPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x7EDC78", Offset = "0x7EDC78", VA = "0x7EDC78")]
	public bool TriggerPress()
	{
		return default(bool);
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x7EDC9C", Offset = "0x7EDC9C", VA = "0x7EDC9C")]
	public bool TriggerPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x7EDCC0", Offset = "0x7EDCC0", VA = "0x7EDCC0")]
	public bool MenuPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x7EDCE4", Offset = "0x7EDCE4", VA = "0x7EDCE4")]
	public bool MenuPress()
	{
		return default(bool);
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x7EDD08", Offset = "0x7EDD08", VA = "0x7EDD08")]
	public bool MenuPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x7EDD2C", Offset = "0x7EDD2C", VA = "0x7EDD2C")]
	public bool SecondaryMenuPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x7EDD50", Offset = "0x7EDD50", VA = "0x7EDD50")]
	public bool SecondaryMenuPress()
	{
		return default(bool);
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x7EDD74", Offset = "0x7EDD74", VA = "0x7EDD74")]
	public bool SecondaryMenuPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x7EDD98", Offset = "0x7EDD98", VA = "0x7EDD98")]
	public bool ToolboxRecenterPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x7EDDBC", Offset = "0x7EDDBC", VA = "0x7EDDBC")]
	public bool TouchpadPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x7EDDE0", Offset = "0x7EDDE0", VA = "0x7EDDE0")]
	public Vector3 TouchpadSwipeVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x7EDE04", Offset = "0x7EDE04", VA = "0x7EDE04")]
	public float Trigger(InputType hand)
	{
		return default(float);
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x7EDEA4", Offset = "0x7EDEA4", VA = "0x7EDEA4")]
	public bool TriggerUp(InputType hand)
	{
		return default(bool);
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x7EDF44", Offset = "0x7EDF44", VA = "0x7EDF44")]
	public bool TriggerDown(InputType hand)
	{
		return default(bool);
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x7EDFE4", Offset = "0x7EDFE4", VA = "0x7EDFE4")]
	public bool StampItem(InputType hand)
	{
		return default(bool);
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x7EE084", Offset = "0x7EE084", VA = "0x7EE084")]
	public bool DeleteItem(InputType hand)
	{
		return default(bool);
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x7EE124", Offset = "0x7EE124", VA = "0x7EE124")]
	public Vector2 ThumbstickAxis(InputType hand)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x7EE1C4", Offset = "0x7EE1C4", VA = "0x7EE1C4")]
	public Vector3 GetHeadLevelPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x7EE220", Offset = "0x7EE220", VA = "0x7EE220")]
	public Vector3 GetHeadPalazzoWorldPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x7EE278", Offset = "0x7EE278", VA = "0x7EE278")]
	public Quaternion GetHeadPalazzoWorldRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x7EE34C", Offset = "0x7EE34C", VA = "0x7EE34C")]
	public Vector3 GetHandPalazzoWorldPosition(InputType hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x7EE378", Offset = "0x7EE378", VA = "0x7EE378")]
	public Quaternion GetHandPalazzoWorldRotation(InputType hand)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x7EE4BC", Offset = "0x7EE4BC", VA = "0x7EE4BC")]
	public Vector3 GetHeadUnityWorldPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x7EE4FC", Offset = "0x7EE4FC", VA = "0x7EE4FC")]
	public Quaternion GetHeadUnityWorldRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x7EE5C0", Offset = "0x7EE5C0", VA = "0x7EE5C0")]
	public Vector3 GetHandUnityWorldPosition(InputType hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x7ED774", Offset = "0x7ED774", VA = "0x7ED774")]
	public Quaternion GetHandUnityWorldRotation(InputType hand)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x7EE67C", Offset = "0x7EE67C", VA = "0x7EE67C")]
	public Vector3 GetHeadLocalPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x7ED55C", Offset = "0x7ED55C", VA = "0x7ED55C")]
	public Vector3 GetHandLocalPosition(InputType hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x7ED6D4", Offset = "0x7ED6D4", VA = "0x7ED6D4")]
	public Quaternion GetHandLocalRotation(InputType hand)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x7EE6A0", Offset = "0x7EE6A0", VA = "0x7EE6A0", Slot = "7")]
	public virtual Vector3 GetHandLocalPositionWhileAiming(InputType hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600027A")]
	public abstract Vector3 GetBirdWorldPositionWhileWaitingForAim();

	[Token(Token = "0x600027B")]
	public abstract InputType GetBirdHandWhileWaitingForAim();

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x7EE818", Offset = "0x7EE818", VA = "0x7EE818")]
	public void HandleAchievement(Achievements type)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x7EE838", Offset = "0x7EE838", VA = "0x7EE838")]
	public bool ShouldHandlePrivacyPolicy()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000096")]
public sealed class InputHandlerOneHanded : InputHandler
{
	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 savedHandPosition;

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x7EE8E8", Offset = "0x7EE8E8", VA = "0x7EE8E8")]
	static InputHandlerOneHanded()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x7EE978", Offset = "0x7EE978", VA = "0x7EE978")]
	public InputHandlerOneHanded(ARTransforms arTransforms, PalazzoInputDevice inputDevice, PalazzoComponentSlingshot slingshot, LevelContext levelContext, PalazzoGameDataPersistent gameDataPersistent)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x7EEAD8", Offset = "0x7EEAD8", VA = "0x7EEAD8", Slot = "6")]
	public override bool TriggerPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x7EEB28", Offset = "0x7EEB28", VA = "0x7EEB28", Slot = "7")]
	public override Vector3 GetHandLocalPositionWhileAiming(InputType hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x7EEB4C", Offset = "0x7EEB4C", VA = "0x7EEB4C", Slot = "8")]
	public override Vector3 GetBirdWorldPositionWhileWaitingForAim()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x7EEB70", Offset = "0x7EEB70", VA = "0x7EEB70", Slot = "9")]
	public override InputType GetBirdHandWhileWaitingForAim()
	{
		return default(InputType);
	}
}
[Token(Token = "0x2000097")]
public class InputHandlerTwoHanded : InputHandler
{
	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 slingshotHandTensionOffset;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly TensionHandSettings tensionHandSettings;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly Transform tensionHandTransform;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly float timeNormalizer;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool isAiming;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int scaling;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float scalingValueBasedOntime;

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x7EEB78", Offset = "0x7EEB78", VA = "0x7EEB78")]
	static InputHandlerTwoHanded()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x7EEC80", Offset = "0x7EEC80", VA = "0x7EEC80")]
	public InputHandlerTwoHanded(ARTransforms arTransforms, PalazzoInputDevice inputDevice, PalazzoComponentSlingshot slingshot, LevelContext levelContext, TensionHandSettings tensionHandSettings, TensionHand tensionHand, PalazzoGameDataPersistent gameDataPersistent)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x7EEE1C", Offset = "0x7EEE1C", VA = "0x7EEE1C", Slot = "4")]
	protected override void TickInternal()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x7EEFB4", Offset = "0x7EEFB4", VA = "0x7EEFB4", Slot = "7")]
	public override Vector3 GetHandLocalPositionWhileAiming(InputType hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x7EF098", Offset = "0x7EF098", VA = "0x7EF098", Slot = "8")]
	public override Vector3 GetBirdWorldPositionWhileWaitingForAim()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x7EF0A0", Offset = "0x7EF0A0", VA = "0x7EF0A0", Slot = "9")]
	public override InputType GetBirdHandWhileWaitingForAim()
	{
		return default(InputType);
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x7EF0A8", Offset = "0x7EF0A8", VA = "0x7EF0A8", Slot = "5")]
	public override void SetHandedness(PlayerHandedness handedness)
	{
	}
}
[Token(Token = "0x2000098")]
public sealed class InteractiveCharacterComponent : MonoBehaviour
{
	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform leftEye;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform rightEye;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform neck;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator anim;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Number of seconds between switching targets")]
	public float targetSwitchDelay;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[Tooltip("Variation in number of seconds between switching targets")]
	public float targetSwitchDelayVariation;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("When the neck is automatically looking at a target, how much should that automatic look affect the join? 0=0%, 1=100% (looking straight at")]
	[Range(0f, 1f)]
	public float neckLookWeight;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("How quickly should the neck look come into play. If you want to specify in seconds you use x=1/s where s is the number of seconds you want and x is the value you want. If you want it to take 2 seconds you specify 0.5 because 1/2=0.5. If you want it to take 4 seconds you specify 0.25 because 1/4=0.25 - This is used when switching from an animation that use automatick neck look to an animation that do NOT use automatic neck look.")]
	public float neckBlendSwitchTimescale;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float neckLookDotMin;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float eyesLookDotMin;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool alsoLookBehind;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 frontDirectionEyes;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 upDirectionEyes;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 frontRotationEyes;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3 frontRotationNeck;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Vector3 rightEyeCenterRotation;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Vector3 leftEyeCenterRotation;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float maxDegreesFromCenter;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool useLocal;

	[NonSerialized]
	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float timeLooking;

	[NonSerialized]
	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float timeNotLooking;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private Quaternion frontEyeRotation;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion frontNeckRotation;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float maxRadiansFromCenter;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool initialized;

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x7EF188", Offset = "0x7EF188", VA = "0x7EF188")]
	private void Init()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x7EF204", Offset = "0x7EF204", VA = "0x7EF204")]
	public float GetMaxRadiansFromCenter()
	{
		return default(float);
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x7EF228", Offset = "0x7EF228", VA = "0x7EF228")]
	public Quaternion GetFrontEyeRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x7EF250", Offset = "0x7EF250", VA = "0x7EF250")]
	public Quaternion GetFrontNeckRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x7EF278", Offset = "0x7EF278", VA = "0x7EF278")]
	public void LookAtPlayer()
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x7EF2D0", Offset = "0x7EF2D0", VA = "0x7EF2D0")]
	public void StopLookingAtPlayer()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x7EF328", Offset = "0x7EF328", VA = "0x7EF328")]
	public InteractiveCharacterComponent()
	{
	}
}
[Token(Token = "0x2000099")]
public class IntroComponent : MonoBehaviour
{
	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PlayableDirector timeLine;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject balloon;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public readonly float TIME_TO_REACH_TOP;

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x7EF35C", Offset = "0x7EF35C", VA = "0x7EF35C")]
	public IntroComponent()
	{
	}
}
[Token(Token = "0x200009A")]
public class EditingState : LevelEditorStateBase
{
	[Token(Token = "0x200009B")]
	private enum State
	{
		[Token(Token = "0x4000397")]
		Editing,
		[Token(Token = "0x4000398")]
		MovingToEditingPosition
	}

	[Token(Token = "0x200009C")]
	private enum PositionState
	{
		[Token(Token = "0x400039A")]
		Idle,
		[Token(Token = "0x400039B")]
		FadeUp,
		[Token(Token = "0x400039C")]
		FadeDown
	}

	[Token(Token = "0x4000378")]
	private const float TELEPORTATION_STEP = 0.5f;

	[Token(Token = "0x4000379")]
	private const int PLATFORM_ROTATION_STEP = 20;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelEditorComponent levelEditor;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly ToolboxHandler toolboxHandler;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly Toolbox toolbox;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly LevelBuildingHandler levelBuildingHandler;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly LevelEditorSettings levelEditorSettings;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly LevelFactory levelFactory;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Transform scenePlatform;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int yStep;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private bool positionToolbox;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int prevRotationStep;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private LevelEditorStateType nextState;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool teleportReady;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	private bool isTransitioning;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
	private bool isTransitioningPrev;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private State state;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private State prevState;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private PositionState posState;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private PositionState prevPosState;

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x7EF36C", Offset = "0x7EF36C", VA = "0x7EF36C")]
	public EditingState(WorldContext worldContext, PalazzoTriggers palazzoTriggers, InputHandler inputHandler, TeleportationHandler teleportationHandler, MonoBehaviour monoBehaviour, LevelEditorComponent levelEditor, LevelContext levelContext, ARTransforms arTransforms, Toolbox toolbox, FadeHandler fadeHandler, LevelBuildingHandler levelBuildingHandler, LevelEditorContext levelEditorContext, LevelEditorPlayContext levelEditorPlayContext, LevelEditorSettings levelEditorSettings, LevelFactory levelFactory, TrajectoryHandler trajectoryHandler, LevelEditorVRController vrControllerLevelEditor, ToolboxSettings toolboxSettings)
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x7EF62C", Offset = "0x7EF62C", VA = "0x7EF62C", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x7EF638", Offset = "0x7EF638", VA = "0x7EF638", Slot = "5")]
	public override LevelEditorStateType Tick()
	{
		return default(LevelEditorStateType);
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x7F14E8", Offset = "0x7F14E8", VA = "0x7F14E8", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x7F15D4", Offset = "0x7F15D4", VA = "0x7F15D4")]
	private void OpenMenu(MenuType menuType)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x7F160C", Offset = "0x7F160C", VA = "0x7F160C")]
	private void OnTryPlay()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x7F15FC", Offset = "0x7F15FC", VA = "0x7F15FC")]
	private void SetNextState(LevelEditorStateType nextState)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x7F1620", Offset = "0x7F1620", VA = "0x7F1620")]
	private void ClearBuildingLevel()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x7F1640", Offset = "0x7F1640", VA = "0x7F1640")]
	private void OnToolboxItemGrab(ToolboxItemComponent item, VRGrab hand)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x7F1040", Offset = "0x7F1040", VA = "0x7F1040")]
	private void HandleEditingPosition()
	{
	}
}
[Token(Token = "0x200009D")]
public class LevelEditorMenuState : LevelEditorStateBase
{
	[Token(Token = "0x200009E")]
	private enum State
	{
		[Token(Token = "0x40003AA")]
		ShowMenu,
		[Token(Token = "0x40003AB")]
		TransitionOut,
		[Token(Token = "0x40003AC")]
		MoveToMenuPosition,
		[Token(Token = "0x40003AD")]
		WaitForPreviewDespawn
	}

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelEditorComponent levelEditor;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly IMenuHandler[] menuHandlers;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly LevelFactory levelFactory;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private LevelEditorStateType nextState;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private State state;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private State prevState;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private MenuType? nextMenuType;

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x7F1B8C", Offset = "0x7F1B8C", VA = "0x7F1B8C")]
	public LevelEditorMenuState(GameStateData gameStateData, NetworkHandler networkHandler, LevelEditorContext levelEditorContext, LevelEditorPlayContext levelEditorPlayContext, LevelEditorComponent levelEditor, IEnumerable<SplitMenu> splitMenus, WorldContext worldContext, PalazzoTriggers palazzoTriggers, InputHandler inputHandler, ARTransforms arTransforms, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, LevelBuildingHandler levelBuildingHandler, TeleportationHandler teleportationHandler, FadeHandler fadeHandler, LevelFactory levelFactory, LevelContext levelContext, MonoBehaviour monoBehaviour, PalazzoComponentBirdPlatform birdPlatform, CreateUserMenu createUserMenu, ReportMenu reportMenu, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x7F29C4", Offset = "0x7F29C4", VA = "0x7F29C4", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x7F2A08", Offset = "0x7F2A08", VA = "0x7F2A08", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x7F2B0C", Offset = "0x7F2B0C", VA = "0x7F2B0C", Slot = "5")]
	public override LevelEditorStateType Tick()
	{
		return default(LevelEditorStateType);
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x7F3358", Offset = "0x7F3358", VA = "0x7F3358")]
	private void SetState(LevelEditorStateType nextState)
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x7F3494", Offset = "0x7F3494", VA = "0x7F3494")]
	private void SetMenuType(MenuType menuType)
	{
	}
}
[Token(Token = "0x200009F")]
public enum MenuType
{
	[Token(Token = "0x40003AF")]
	BuildLevels,
	[Token(Token = "0x40003B0")]
	SaveLevels,
	[Token(Token = "0x40003B1")]
	FavoriteLevels,
	[Token(Token = "0x40003B2")]
	Discovery,
	[Token(Token = "0x40003B3")]
	UserProfile,
	[Token(Token = "0x40003B4")]
	CreateUser,
	[Token(Token = "0x40003B5")]
	Report,
	[Token(Token = "0x40003B6")]
	MyProfile
}
[Token(Token = "0x20000A0")]
public sealed class LevelBlockFactory
{
	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ComponentPrefabPool<PalazzoComponentLevelBlock>[] levelBlockPrefabPoolLookup;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly DamageQueue damageQueue;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly BirdImpactQueue birdImpactQueue;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly HealthBarData healthBarData;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly AlchemyHandler alchemyHandler;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] zeroPositions;

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x7F35B8", Offset = "0x7F35B8", VA = "0x7F35B8")]
	public LevelBlockFactory(ComponentPrefabPool<PalazzoComponentLevelBlock>[] levelBlockPrefabPoolLookup, DamageQueue damageQueue, BirdImpactQueue birdImpactQueue, HealthBarData healthBarData, Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup, AlchemyHandler alchemyHandler)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x7F3650", Offset = "0x7F3650", VA = "0x7F3650")]
	public PalazzoComponentLevelBlock Create(PalazzoComponentLevelBlock prefab, Transform levelTransform, Vector3 localPosition, Quaternion localRotation)
	{
		return null;
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x7F3EE4", Offset = "0x7F3EE4", VA = "0x7F3EE4")]
	public void Destroy(PalazzoComponentLevelBlock levelBlock)
	{
	}
}
[Token(Token = "0x20000A1")]
public sealed class LevelBlockHelper
{
	[Token(Token = "0x40003BE")]
	private const float SPHERE_VOLUME_FACTOR = 4.1887903f;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PhysicsSettings physicsSettings;

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x7F3F60", Offset = "0x7F3F60", VA = "0x7F3F60")]
	public LevelBlockHelper(ARTransforms arTransforms, PhysicsSettings physicsSettings)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x7F3F8C", Offset = "0x7F3F8C", VA = "0x7F3F8C")]
	public float CalcVolume(PalazzoComponentLevelBlock block)
	{
		return default(float);
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x7F42F8", Offset = "0x7F42F8", VA = "0x7F42F8")]
	public float CalcMass(PalazzoComponentLevelBlock block, float volume)
	{
		return default(float);
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x7F4510", Offset = "0x7F4510", VA = "0x7F4510")]
	public float CalcHealth(PalazzoComponentLevelBlock block)
	{
		return default(float);
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x7F4730", Offset = "0x7F4730", VA = "0x7F4730")]
	public float CalcImpactMagnitudeThreshold()
	{
		return default(float);
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x7F4764", Offset = "0x7F4764", VA = "0x7F4764")]
	public float CalcExplosionRadius(ExplosionComponent xpl)
	{
		return default(float);
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x7F478C", Offset = "0x7F478C", VA = "0x7F478C")]
	public float CalcExplosionDamage(ExplosionComponent xpl)
	{
		return default(float);
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x7F47B4", Offset = "0x7F47B4", VA = "0x7F47B4")]
	public float CalcExplosionForce(ExplosionComponent xpl)
	{
		return default(float);
	}
}
[Token(Token = "0x20000A2")]
public struct LevelBlockProxyComparer : IEqualityComparer<LevelBlockProxy>
{
	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x7F47FC", Offset = "0x7F47FC", VA = "0x7F47FC", Slot = "4")]
	public bool Equals(LevelBlockProxy x, LevelBlockProxy y)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x7F4864", Offset = "0x7F4864", VA = "0x7F4864", Slot = "5")]
	public int GetHashCode(LevelBlockProxy obj)
	{
		return default(int);
	}
}
[Token(Token = "0x20000A3")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
public sealed class LevelBlockProxy : MonoBehaviour
{
	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PalazzoComponentLevelBlock levelBlockPrefab;

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x7F4884", Offset = "0x7F4884", VA = "0x7F4884")]
	public LevelBlockProxy()
	{
	}
}
[Token(Token = "0x20000A4")]
[RequireComponent(typeof(LevelBlockProxy))]
[DisallowMultipleComponent]
public sealed class LevelBlockProxyAttachment : MonoBehaviour
{
	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LevelBlockProxy connectedBlock;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 connectedAnchor;

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x7F488C", Offset = "0x7F488C", VA = "0x7F488C")]
	public LevelBlockProxyAttachment()
	{
	}
}
[Token(Token = "0x20000A5")]
public class LevelBlockProxyBalloon : MonoBehaviour
{
	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speedVariationAmplitude;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float speedVariationFrequency;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float buoyancyMultiplier;

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x7F4894", Offset = "0x7F4894", VA = "0x7F4894")]
	public LevelBlockProxyBalloon()
	{
	}
}
[Token(Token = "0x20000A6")]
[DisallowMultipleComponent]
[RequireComponent(typeof(LevelBlockProxy))]
public sealed class LevelBlockProxyBossPig : MonoBehaviour
{
	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public WorldType bossType;

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x7F48B0", Offset = "0x7F48B0", VA = "0x7F48B0")]
	public LevelBlockProxyBossPig()
	{
	}
}
[Token(Token = "0x20000A7")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
[RequireComponent(typeof(LevelBlockProxy))]
public sealed class LevelBlockProxyFan : MonoBehaviour
{
	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float range;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float outwardsForce;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float speedVariationAmplitude;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speedVariationFrequency;

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x7F48B8", Offset = "0x7F48B8", VA = "0x7F48B8")]
	public LevelBlockProxyFan()
	{
	}
}
[Token(Token = "0x20000A8")]
[DisallowMultipleComponent]
[RequireComponent(typeof(LevelBlockProxy))]
public sealed class LevelBlockProxyTeleportationPoint : MonoBehaviour
{
	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool useCustomPlacement;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 birdPlatformOffset;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 birdPlatformRotation;

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x7F48D4", Offset = "0x7F48D4", VA = "0x7F48D4")]
	public LevelBlockProxyTeleportationPoint()
	{
	}
}
[Token(Token = "0x20000A9")]
public class LevelBuildingBlock : MonoBehaviour
{
	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Prefab prefab;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BlockTypeData blockTypeData;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Collider col;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator anim;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GhostComponent ghost;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GhostComponent lastPlacement;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GhostComponent placementRepresentation;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Renderer[] renderers;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material[][] originalMaterials;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int blockId;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector3 lastValidPosition;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Quaternion lastValidRotation;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool isColliding;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int isLastValidTransformEmpty;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector3 originalScale;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool isInDeletionCollider;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool isSnapping;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
	public bool isInteractable;

	[Token(Token = "0x17000018")]
	public BlockType BlockType
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x7F48DC", Offset = "0x7F48DC", VA = "0x7F48DC")]
		get
		{
			return default(BlockType);
		}
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x7F48F8", Offset = "0x7F48F8", VA = "0x7F48F8")]
	public LevelBuildingBlock()
	{
	}
}
[Token(Token = "0x20000AA")]
public sealed class LevelBuildingHandler
{
	[Token(Token = "0x20000AB")]
	public enum State
	{
		[Token(Token = "0x4000405")]
		Building,
		[Token(Token = "0x4000406")]
		FadeUndo,
		[Token(Token = "0x4000407")]
		FadeRedo,
		[Token(Token = "0x4000408")]
		FadeClearLevel
	}

	[Token(Token = "0x20000AC")]
	private struct BlockMovingBackToToolbox
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LevelBuildingBlock block;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ToolboxItemComponent toolboxItem;
	}

	[Token(Token = "0x20000AD")]
	private struct DataOnGrab
	{
		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int blockId;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Vector3 localPosition;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Quaternion localRotation;
	}

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Toolbox toolbox;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly LevelEditorVRController vrController;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelEditorSettings levelEditorSettings;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly LevelBuildingBlock[] blocksInHand;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly LevelBuildingBlock[] highlightedBlocks;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly ToolboxItemComponent[] hiddenToolboxItems;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly LevelEditorComponent levelEditor;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly BuildingBlockFactory buildingBlockFactory;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly List<BlockMovingBackToToolbox> blocksMovingBackToToolbox;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly Transform levelParent;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly HistoryHandler historyHandler;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Material[][] redMaterials;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Material[][] greenMaterials;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Material[][] grayMaterials;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Collider[] resultColliders;

	[Token(Token = "0x40003F6")]
	private const float POSITION_LERP_SPEED = 50f;

	[Token(Token = "0x40003F7")]
	private const float ROTATION_LERP_SPEED = 25f;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly DataOnGrab?[] dataOnGrab;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly Quaternion[] grabbedRotationOffset;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly Vector3[] grabbedPositionOffset;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly int idle;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static readonly int hangBalloon;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Level uneditedLevel;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private uint previousLevelId;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool isRotating;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector3 adjustmentBasePos;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Quaternion adjustmentBaseRot;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private State prevState;

	[Token(Token = "0x17000019")]
	public State state
	{
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x7F4908", Offset = "0x7F4908", VA = "0x7F4908")]
		[CompilerGenerated]
		get
		{
			return default(State);
		}
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x7F4910", Offset = "0x7F4910", VA = "0x7F4910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x7F4918", Offset = "0x7F4918", VA = "0x7F4918")]
	public LevelBuildingHandler(InputHandler inputHandler, ARTransforms arTransforms, Toolbox toolbox, LevelEditorVRController vrController, LevelEditorContext levelEditorContext, LevelEditorSettings levelEditorSettings, LevelEditorComponent levelEditor, PalazzoTriggers palazzoTriggers, FadeHandler fadeHandler)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x7F4ED8", Offset = "0x7F4ED8", VA = "0x7F4ED8")]
	public void Reset()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x7EFD9C", Offset = "0x7EFD9C", VA = "0x7EFD9C")]
	public void StartEditingLevel(Level level)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x7F4FAC", Offset = "0x7F4FAC", VA = "0x7F4FAC")]
	public void FixedTick()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x7EFFA8", Offset = "0x7EFFA8", VA = "0x7EFFA8")]
	public void Tick()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x7F5848", Offset = "0x7F5848", VA = "0x7F5848")]
	private void ReleaseItem(int iHand, LevelBuildingBlock block, ToolboxItemComponent toolboxItem, bool isSnapping, bool isInDeletionCollider, bool isCloseToToolbox)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x7F5E84", Offset = "0x7F5E84", VA = "0x7F5E84")]
	private void StampItem(int iHand, bool isSnapping)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x7F649C", Offset = "0x7F649C", VA = "0x7F649C")]
	private void DeleteItem(int iHand, LevelBuildingBlock block, bool isCloseToToolbox, bool isInDeletionCollider)
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x7F4EE4", Offset = "0x7F4EE4", VA = "0x7F4EE4")]
	private void RemoveGrabbedItemOnEnter(int iHand, LevelBuildingBlock block)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x7F69DC", Offset = "0x7F69DC", VA = "0x7F69DC")]
	private void GrabItem(Vector3 handPosition, Quaternion handRotation, LevelBuildingBlock grabbedBlock, int iHand)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x7F1658", Offset = "0x7F1658", VA = "0x7F1658")]
	public void OnToolboxItemGrabbed(ToolboxItemComponent toolboxItemComponent, VRGrab hand)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x7F66AC", Offset = "0x7F66AC", VA = "0x7F66AC")]
	private LevelBuildingBlock HighlightItem(Vector3 handPosition, int iHand)
	{
		return null;
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x7F701C", Offset = "0x7F701C", VA = "0x7F701C")]
	private void AddHighlight(LevelBuildingBlock block)
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x7F6F98", Offset = "0x7F6F98", VA = "0x7F6F98")]
	private void RemoveHighlight(LevelBuildingBlock block)
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x7F54AC", Offset = "0x7F54AC", VA = "0x7F54AC")]
	private bool IsColliding(Collider col, params Collider[] colToIgnore)
	{
		return default(bool);
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x7F6F5C", Offset = "0x7F6F5C", VA = "0x7F6F5C")]
	private bool IsBlockAffordable(int blockCost)
	{
		return default(bool);
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x7F4F74", Offset = "0x7F4F74", VA = "0x7F4F74")]
	private void EnableHandArrow(VRHand hand, bool enabled)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x7F70A0", Offset = "0x7F70A0", VA = "0x7F70A0")]
	public void Undo()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x7F7204", Offset = "0x7F7204", VA = "0x7F7204")]
	public void Redo()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x7F152C", Offset = "0x7F152C", VA = "0x7F152C")]
	public void ClearBuildingLevel(bool isRecording, bool fade = false)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x7F7368", Offset = "0x7F7368", VA = "0x7F7368")]
	private void SetLayerRecursively(GameObject obj, int newLayer)
	{
	}
}
[Token(Token = "0x20000AE")]
public sealed class LevelButton : PalazzoButton<LevelSelectButtonType>
{
	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public PalazzoComponentStar[] levelStars;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject levelLock;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TextMeshPro levelTextDefault;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public TextMeshPro levelTextHover;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public SpriteRenderer optionalBossSprite;

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x7F778C", Offset = "0x7F778C", VA = "0x7F778C")]
	public LevelButton()
	{
	}
}
[Token(Token = "0x20000AF")]
public class LevelEditorComponent : MonoBehaviour
{
	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform levelParent;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform toolboxParent;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public PlatformHandleRotation platform;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Toolbox toolbox;

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x7F77D4", Offset = "0x7F77D4", VA = "0x7F77D4")]
	public LevelEditorComponent()
	{
	}
}
[Token(Token = "0x20000B0")]
public class LevelEditorEnvironment : SingleInstanceBehavior<LevelEditorEnvironment>
{
	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform editingTransform;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject telePointsRoot;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] teleportationPointPositions;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform startTeleportationPoint;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject editingPlatform;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform birdPlatformPreviewPosition;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TelePointLevelEditor[] telePoints;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject orientationIndicator;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform splitMenuPosition;

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x7F77DC", Offset = "0x7F77DC", VA = "0x7F77DC")]
	public LevelEditorEnvironment()
	{
	}
}
[Token(Token = "0x20000B1")]
public class LevelEditorVRController : MonoBehaviour
{
	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRGrab leftHand;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRGrab rightHand;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MeshRenderer leftArrow;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshRenderer rightArrow;

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x7F7848", Offset = "0x7F7848", VA = "0x7F7848")]
	public LevelEditorVRController()
	{
	}
}
[Token(Token = "0x20000B2")]
public class LevelEditorVRControllerHandler
{
	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelEditorVRController vrController;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private VRGrab leftHand;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VRGrab rightHand;

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x7F7850", Offset = "0x7F7850", VA = "0x7F7850")]
	public LevelEditorVRControllerHandler(LevelEditorVRController vrController)
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x7F7888", Offset = "0x7F7888", VA = "0x7F7888")]
	public void Tick()
	{
	}
}
[Token(Token = "0x20000B3")]
public sealed class LevelFactory
{
	[Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class <SpawnLevelBlockByBlock>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelContext levelContext;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LevelFactory <>4__this;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Level level;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform <levelTransform>5__2;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform <lockedObjectsParent>5__3;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PalazzoComponentLevelBlock> <blocks>5__4;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<DamageComponent> <damages>5__5;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<FanComponent> <fans>5__6;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<PalazzoComponentPig> <pigs>5__7;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<PalazzoComponentBird> <birds>5__8;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<InteractiveCharacterComponent> <characters>5__9;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<TeleportationComponent> <teleportationPoints>5__10;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int <numberOfBlocks>5__11;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<BlockData> <blockDatas>5__12;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int <blocksPerTick>5__13;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int <pigsToSpawnPerFrame>5__14;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private YieldInstruction <pigsSpawnWait>5__15;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float <maxDepenetrationVelocity>5__16;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float <depenetrationVelocitySettle>5__17;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int <iBlock>5__18;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int <nBlock>5__19;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private PalazzoComponentLevelBlock <block>5__20;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x7FA3D0", Offset = "0x7FA3D0", VA = "0x7FA3D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x7FA418", Offset = "0x7FA418", VA = "0x7FA418", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x7F85A0", Offset = "0x7F85A0", VA = "0x7F85A0")]
		[DebuggerHidden]
		public <SpawnLevelBlockByBlock>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x7F9178", Offset = "0x7F9178", VA = "0x7F9178", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x7F917C", Offset = "0x7F917C", VA = "0x7F917C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x7FA3D8", Offset = "0x7FA3D8", VA = "0x7FA3D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class <SpawnLevelBlockByBlock>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelFactory <>4__this;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int levelIndex;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LevelContext levelContext;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PalazzoComponentLevel <levelPrefab>5__2;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform <levelTransform>5__3;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PalazzoComponentLevelBlock> <blocks>5__4;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<DamageComponent> <damages>5__5;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<FanComponent> <fans>5__6;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<BalloonComponent> <balloons>5__7;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<PalazzoComponentPig> <pigs>5__8;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<PalazzoComponentBird> <birds>5__9;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<InteractiveCharacterComponent> <characters>5__10;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<TeleportationComponent> <teleportationPoints>5__11;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int <teleportationPointCounter>5__12;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int <blocksPerTick>5__13;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float <maxDepenetrationVelocity>5__14;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float <depenetrationVelocitySettle>5__15;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int <iBlock>5__16;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int <nBlock>5__17;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private PalazzoComponentLevelBlock <block>5__18;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x7FBE14", Offset = "0x7FBE14", VA = "0x7FBE14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x7FBE5C", Offset = "0x7FBE5C", VA = "0x7FBE5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x7F85C8", Offset = "0x7F85C8", VA = "0x7F85C8")]
		[DebuggerHidden]
		public <SpawnLevelBlockByBlock>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x7FA420", Offset = "0x7FA420", VA = "0x7FA420", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x7FA424", Offset = "0x7FA424", VA = "0x7FA424", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x7FBE1C", Offset = "0x7FBE1C", VA = "0x7FBE1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class <NukeLevelFromOrbit>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelContext levelContext;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LevelFactory <>4__this;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<PalazzoComponentLevelBlock> <blocks>5__2;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<DamageComponent> <damages>5__3;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<InteractiveCharacterComponent> <characters>5__4;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PalazzoComponentPig> <pigs>5__5;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int <pigsToDespawnPerFrame>5__6;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private YieldInstruction <pigsDepawnWait>5__7;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<PalazzoComponentBird> <birds>5__8;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int <blocksPerTick>5__9;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int <iPig>5__10;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int <nPig>5__11;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PalazzoComponentLevelBlock <block>5__12;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x7FC81C", Offset = "0x7FC81C", VA = "0x7FC81C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x7FC864", Offset = "0x7FC864", VA = "0x7FC864", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x7F85F0", Offset = "0x7F85F0", VA = "0x7F85F0")]
		[DebuggerHidden]
		public <NukeLevelFromOrbit>d__36(int <>1__state)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x7FBE64", Offset = "0x7FBE64", VA = "0x7FBE64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x7FBE68", Offset = "0x7FBE68", VA = "0x7FBE68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x7FC824", Offset = "0x7FC824", VA = "0x7FC824", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class <PreviewLevelBlockByBlock>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelContext levelContext;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Level level;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LevelFactory <>4__this;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform levelParent;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform birdPlatformPosition;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PalazzoComponentLevelBlock> <blocks>5__2;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<FanComponent> <fans>5__3;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int <birdCount>5__4;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int <blocksPerTick>5__5;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int <iBlock>5__6;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int <nBlock>5__7;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private PalazzoComponentLevelBlock <block>5__8;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x7FD094", Offset = "0x7FD094", VA = "0x7FD094", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x7FD0DC", Offset = "0x7FD0DC", VA = "0x7FD0DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x7FC86C", Offset = "0x7FC86C", VA = "0x7FC86C")]
		[DebuggerHidden]
		public <PreviewLevelBlockByBlock>d__39(int <>1__state)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x7FC894", Offset = "0x7FC894", VA = "0x7FC894", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x7FC898", Offset = "0x7FC898", VA = "0x7FC898", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x7FD09C", Offset = "0x7FD09C", VA = "0x7FD09C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class <DespawnPreviewLevelBlockByBlock>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelContext levelContext;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LevelFactory <>4__this;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<PalazzoComponentLevelBlock> <blocks>5__2;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <blocksPerTick>5__3;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int <iBlock>5__4;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x7FD388", Offset = "0x7FD388", VA = "0x7FD388", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x7FD3D0", Offset = "0x7FD3D0", VA = "0x7FD3D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x7FD0E4", Offset = "0x7FD0E4", VA = "0x7FD0E4")]
		[DebuggerHidden]
		public <DespawnPreviewLevelBlockByBlock>d__43(int <>1__state)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x7FD10C", Offset = "0x7FD10C", VA = "0x7FD10C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x7FD110", Offset = "0x7FD110", VA = "0x7FD110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x7FD390", Offset = "0x7FD390", VA = "0x7FD390", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly WaitForSeconds spawnBlockDuration;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly WaitForSeconds spawnPigAndBirdDelay;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly WaitForSeconds spawnPigDuration;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly WaitForSeconds spawnBirdDuration;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly WaitForSeconds despawnPigDuration;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly WaitForSeconds despawnBirdDuration;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly WaitForSeconds despawnBlockDuration;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly WaitForEndOfFrame waitForEndOfFrame;

	[Token(Token = "0x4000430")]
	private const int LEVEL_SETTLE_FRAMES = 30;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoComponentLevel[] levelPrefabs;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelBlockFactory levelBlockFactory;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly AlchemyHandler alchemyHandler;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly List<LevelBlockProxy> levelBlockProxyCache;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Dictionary<LevelBlockProxy, PalazzoComponentLevelBlock> levelBlockLookupCache;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly List<LevelBlockProxyBalloon> levelBlockProxyBalloonCache;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly List<LevelBlockProxyAttachment> levelBlockProxyAttachmentCache;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly List<LevelBlockProxyFan> levelBlockProxyFanCache;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly List<LevelBlockProxyTeleportationPoint> levelBlockProxyTeleportationPointCache;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly List<BlockData> previewLevelBlockByBlockCache;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static readonly int emissionAdd;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool isDespawning;

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x7F79E8", Offset = "0x7F79E8", VA = "0x7F79E8")]
	public LevelFactory(MonoBehaviour monoBehaviour, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, PalazzoComponentLevel[] levelPrefabs, LevelBlockFactory levelBlockFactory, AlchemyHandler alchemyHandler, PalazzoComponentBirdPlatform birdPlatform)
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x7F7CA0", Offset = "0x7F7CA0", VA = "0x7F7CA0")]
	public void Create(LevelContext levelContext, int levelIndex)
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x7F7E5C", Offset = "0x7F7E5C", VA = "0x7F7E5C")]
	public void Create(LevelContext levelContext, Level levelStorage)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x7F812C", Offset = "0x7F812C", VA = "0x7F812C")]
	public void Destroy(LevelContext levelContext)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x7F81E0", Offset = "0x7F81E0", VA = "0x7F81E0")]
	[Conditional("UNITY_EDITOR")]
	public void DebugCreate(LevelContext levelContext, int levelIndex)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x7F8370", Offset = "0x7F8370", VA = "0x7F8370")]
	[Conditional("UNITY_EDITOR")]
	public void DebugDestroy(LevelContext levelContext)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x7F8428", Offset = "0x7F8428", VA = "0x7F8428")]
	private static int ShortestDistanceToOrigo(LevelBlockProxy r1, LevelBlockProxy r2)
	{
		return default(int);
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x7F84C0", Offset = "0x7F84C0", VA = "0x7F84C0")]
	private static int ShortestDistanceToOrigo(BlockData r1, BlockData r2)
	{
		return default(int);
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x7F8508", Offset = "0x7F8508", VA = "0x7F8508")]
	private static int FurthestDistanceToOrigo(PalazzoComponentLevelBlock r1, PalazzoComponentLevelBlock r2)
	{
		return default(int);
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x7F80B0", Offset = "0x7F80B0", VA = "0x7F80B0")]
	[IteratorStateMachine(typeof(<SpawnLevelBlockByBlock>d__34))]
	private IEnumerator SpawnLevelBlockByBlock(LevelContext levelContext, Level level)
	{
		return null;
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x7F7DDC", Offset = "0x7F7DDC", VA = "0x7F7DDC")]
	[IteratorStateMachine(typeof(<SpawnLevelBlockByBlock>d__35))]
	private IEnumerator SpawnLevelBlockByBlock(LevelContext levelContext, int levelIndex)
	{
		return null;
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x7F816C", Offset = "0x7F816C", VA = "0x7F816C")]
	[IteratorStateMachine(typeof(<NukeLevelFromOrbit>d__36))]
	private IEnumerator NukeLevelFromOrbit(LevelContext levelContext)
	{
		return null;
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x7F8618", Offset = "0x7F8618", VA = "0x7F8618")]
	public void PreviewLevel(Transform levelParent, Level level, LevelContext levelContext, Transform birdPlatformPosition, bool blockByBlock = false)
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x7F8714", Offset = "0x7F8714", VA = "0x7F8714")]
	private void PreviewLevelInstant(Transform levelParent, Level level, LevelContext levelContext, Transform birdPlatformPosition)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x7F8684", Offset = "0x7F8684", VA = "0x7F8684")]
	[IteratorStateMachine(typeof(<PreviewLevelBlockByBlock>d__39))]
	private IEnumerator PreviewLevelBlockByBlock(Transform levelParent, Level level, LevelContext levelContext, Transform birdPlatformPosition)
	{
		return null;
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x7F8D94", Offset = "0x7F8D94", VA = "0x7F8D94")]
	public void DespawnPreviewLevel(LevelContext levelContext, bool blockByBlock)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x7F8F88", Offset = "0x7F8F88", VA = "0x7F8F88")]
	public bool IsDespawningPreview()
	{
		return default(bool);
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x7F8E68", Offset = "0x7F8E68", VA = "0x7F8E68")]
	private void DespawnPreviewLevelInstant(LevelContext levelContext)
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x7F8DF4", Offset = "0x7F8DF4", VA = "0x7F8DF4")]
	[IteratorStateMachine(typeof(<DespawnPreviewLevelBlockByBlock>d__43))]
	private IEnumerator DespawnPreviewLevelBlockByBlock(LevelContext levelContext)
	{
		return null;
	}
}
[Token(Token = "0x20000B9")]
public class LevelListContext
{
	[Token(Token = "0x20000BA")]
	private struct Settings
	{
		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly bool isLocalOnly;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string orderBy;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string timeFilter;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string sorting;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CanBeNull]
		public readonly string userId;

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x7FD830", Offset = "0x7FD830", VA = "0x7FD830")]
		public Settings(bool isLocalOnly, string orderBy, string timeFilter, string sorting, [CanBeNull] string userId)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x7FDD28", Offset = "0x7FDD28", VA = "0x7FDD28")]
		public Settings(bool isLocalOnly)
		{
		}
	}

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly Settings settings;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Future<Page>> pages;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int currentPageIndex;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int currentLevelIndex;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public readonly string endpoint;

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x7FD3D8", Offset = "0x7FD3D8", VA = "0x7FD3D8")]
	public LevelListContext(NetworkHandler networkHandler, string orderBy, string timeFilter = "all_time", string sorting = "desc", [Optional] string userId)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x7FD844", Offset = "0x7FD844", VA = "0x7FD844")]
	public LevelListContext(IReadOnlyList<ServerLevelMetaData> metaDatas)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x7FDD88", Offset = "0x7FDD88", VA = "0x7FDD88")]
	public bool TryGetLevel(int pageIndex, int levelIndex, out ServerLevelMetaData serverLevelMetaData, bool setCurrentIndices = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x7FE488", Offset = "0x7FE488", VA = "0x7FE488")]
	public bool TryGetNextLevel(out ServerLevelMetaData serverLevelMetaData)
	{
		return default(bool);
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x7FE8CC", Offset = "0x7FE8CC", VA = "0x7FE8CC")]
	public int GetCurrentPageIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x7FE8D4", Offset = "0x7FE8D4", VA = "0x7FE8D4")]
	public int GetCurrentLevelIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x7FE878", Offset = "0x7FE878", VA = "0x7FE878")]
	public Future<Page> GetCurrentPage()
	{
		return null;
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x7FE764", Offset = "0x7FE764", VA = "0x7FE764")]
	public void ToNextPage()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x7FE8DC", Offset = "0x7FE8DC", VA = "0x7FE8DC")]
	public void ToPreviousPage()
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x7FE8EC", Offset = "0x7FE8EC", VA = "0x7FE8EC")]
	public void ToFirstPage()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x7FE0A0", Offset = "0x7FE0A0", VA = "0x7FE0A0")]
	private bool HasCachedNextPage([Optional] int? nextPageIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x7FE8F4", Offset = "0x7FE8F4", VA = "0x7FE8F4")]
	public bool ContainsPageAtIndex(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x7FE1B0", Offset = "0x7FE1B0", VA = "0x7FE1B0")]
	public bool DoesNextPageExist()
	{
		return default(bool);
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x7FE948", Offset = "0x7FE948", VA = "0x7FE948")]
	public void Refresh()
	{
	}
}
[Token(Token = "0x20000BB")]
[DisallowMultipleComponent]
public class MeshParticleSystemComponent : MonoBehaviour
{
	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystemRenderer particleSystemRenderer;

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x7FEE38", Offset = "0x7FEE38", VA = "0x7FEE38")]
	public MeshParticleSystemComponent()
	{
	}
}
[Token(Token = "0x20000BC")]
public class APIError : Exception
{
	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public string title;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string description;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public string code;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public UnityWebRequest request;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public PlayFabException playFabException;

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x7FEE40", Offset = "0x7FEE40", VA = "0x7FEE40")]
	public APIError(UnityWebRequest request, [Optional] PlayFabException pfException)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x7FEEB0", Offset = "0x7FEEB0", VA = "0x7FEEB0")]
	public APIError(string title, UnityWebRequest request, [Optional] Exception innerException)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x7FEF78", Offset = "0x7FEF78", VA = "0x7FEF78")]
	public APIError(string title, string exceptionDescription)
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x7FF01C", Offset = "0x7FF01C", VA = "0x7FF01C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x20000BD")]
public class Future<T>
{
	[Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class <WaitUntilResolved>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Future<T> <>4__this;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000329")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600032B")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000326")]
		[DebuggerHidden]
		public <WaitUntilResolved>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000327")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000328")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private T result;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool resolved;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Exception exc;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float startingTime;

	[Token(Token = "0x600031E")]
	public Future()
	{
	}

	[Token(Token = "0x600031F")]
	public bool IsResolved()
	{
		return default(bool);
	}

	[Token(Token = "0x6000320")]
	public void SetResult(T r)
	{
	}

	[Token(Token = "0x6000321")]
	public void SetError(Exception e, string url = "", string errorCode = "")
	{
	}

	[Token(Token = "0x6000322")]
	public T GetResult()
	{
		return (T)null;
	}

	[Token(Token = "0x6000323")]
	public bool TryGetResult(out T result)
	{
		return default(bool);
	}

	[Token(Token = "0x6000324")]
	[IteratorStateMachine(typeof(Future<>.<WaitUntilResolved>d__10))]
	public IEnumerator WaitUntilResolved()
	{
		return null;
	}

	[Token(Token = "0x6000325")]
	public void Reset()
	{
	}
}
[Token(Token = "0x20000BF")]
public sealed class NetworkHandler
{
	[Token(Token = "0x20000C0")]
	private class RequestData
	{
		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RequestType type;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WWWForm optionalForm;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string optionalPostData;

		[Token(Token = "0x1700002A")]
		public string Url
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x8006C4", Offset = "0x8006C4", VA = "0x8006C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x8006BC", Offset = "0x8006BC", VA = "0x8006BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x8006CC", Offset = "0x8006CC", VA = "0x8006CC")]
		public UnityWebRequest ToUnityWebRequest()
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x7FF950", Offset = "0x7FF950", VA = "0x7FF950")]
		public static RequestData Get(string url)
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x7FFBD0", Offset = "0x7FFBD0", VA = "0x7FFBD0")]
		public static RequestData Post(string url, WWWForm form)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x7FFE1C", Offset = "0x7FFE1C", VA = "0x7FFE1C")]
		public static RequestData Post(string url, string postData)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x80075C", Offset = "0x80075C", VA = "0x80075C")]
		public RequestData()
		{
		}
	}

	[Token(Token = "0x20000C1")]
	private enum RequestType
	{
		[Token(Token = "0x40004B8")]
		Get,
		[Token(Token = "0x40004B9")]
		Post
	}

	[Serializable]
	[Token(Token = "0x20000C2")]
	private class ServerLevelMetaDataCollection
	{
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ServerLevelMetaData[] levels;

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x800764", Offset = "0x800764", VA = "0x800764")]
		public ServerLevelMetaDataCollection()
		{
		}
	}

	[Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class <PerformHttpRequest>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RequestData requestData;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NetworkHandler <>4__this;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<APIError> onFailure;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<UnityWebRequest> onSuccess;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <request>5__2;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool <hasSucceededOrRetried>5__3;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x800FB8", Offset = "0x800FB8", VA = "0x800FB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x801000", Offset = "0x801000", VA = "0x801000", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x7FF440", Offset = "0x7FF440", VA = "0x7FF440")]
		[DebuggerHidden]
		public <PerformHttpRequest>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x80076C", Offset = "0x80076C", VA = "0x80076C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x800770", Offset = "0x800770", VA = "0x800770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x800FC0", Offset = "0x800FC0", VA = "0x800FC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ConnectionHandler connectionHandler;

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string url;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly WaitForSeconds oneAndAHalfSecond;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int numberOfRetries;

	[Token(Token = "0x40004B0")]
	private const int TOTAL_NUMBER_OF_RETRIES = 3;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Future<User> getUserDataFuture;

	[Token(Token = "0x17000026")]
	public bool HasFetchedUser
	{
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x7FF268", Offset = "0x7FF268", VA = "0x7FF268")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000027")]
	public string ClientUserId
	{
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x7FF278", Offset = "0x7FF278", VA = "0x7FF278")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000028")]
	public string ClientAuthToken
	{
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x7FF294", Offset = "0x7FF294", VA = "0x7FF294")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000029")]
	public User User
	{
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x7FF2B0", Offset = "0x7FF2B0", VA = "0x7FF2B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x7FF2B8", Offset = "0x7FF2B8", VA = "0x7FF2B8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x7FF2C0", Offset = "0x7FF2C0", VA = "0x7FF2C0")]
	public NetworkHandler(MonoBehaviour monoBehaviour)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x7FF39C", Offset = "0x7FF39C", VA = "0x7FF39C")]
	public bool HasInternetConnection()
	{
		return default(bool);
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x7FF3B8", Offset = "0x7FF3B8", VA = "0x7FF3B8")]
	[IteratorStateMachine(typeof(<PerformHttpRequest>d__22))]
	private IEnumerator PerformHttpRequest(RequestData requestData, Action<UnityWebRequest> onSuccess, Action<APIError> onFailure)
	{
		return null;
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x7FF468", Offset = "0x7FF468", VA = "0x7FF468")]
	public Future<User> GetUserData(string playFabId)
	{
		return null;
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x7FF510", Offset = "0x7FF510", VA = "0x7FF510")]
	public Future<bool> SetUserData(params (string, object)[] data)
	{
		return null;
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x7FF7A8", Offset = "0x7FF7A8", VA = "0x7FF7A8")]
	public Future<string[]> RetrieveUsernameSuggestions()
	{
		return null;
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x7FF9B8", Offset = "0x7FF9B8", VA = "0x7FF9B8")]
	public Future<string> UploadLevel(Level level)
	{
		return null;
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x7FFC4C", Offset = "0x7FFC4C", VA = "0x7FFC4C")]
	public Future<bool> SelectUsername(string username)
	{
		return null;
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x7FFE98", Offset = "0x7FFE98", VA = "0x7FFE98")]
	public Future<bool> UnshareLevel(string levelId)
	{
		return null;
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x800048", Offset = "0x800048", VA = "0x800048")]
	public Future<ServerLevelMetaData> RequestLevel(string levelId)
	{
		return null;
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x8001F8", Offset = "0x8001F8", VA = "0x8001F8")]
	public Future<ServerLevelMetaData> RequestRandomLevel()
	{
		return null;
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x8003A0", Offset = "0x8003A0", VA = "0x8003A0")]
	public Future<ServerLevelMetaData[]> UpdateMetadata(string[] levelCodes)
	{
		return null;
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x800580", Offset = "0x800580", VA = "0x800580")]
	public void ReportLevel(ServerLevelMetaData metaData, string reportMessage)
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x7FE304", Offset = "0x7FE304", VA = "0x7FE304")]
	public Future<Page> FetchPageOfLevels(string url)
	{
		return null;
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x8005F0", Offset = "0x8005F0", VA = "0x8005F0")]
	public LevelListContext GetLevelsList(string orderBy, string sorting = "desc", bool lastWeekOnly = false, [Optional] string userId)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x20000CC")]
public sealed class TempLevelId
{
	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string level_id;

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x80186C", Offset = "0x80186C", VA = "0x80186C")]
	public TempLevelId()
	{
	}
}
[Serializable]
[Token(Token = "0x20000CD")]
public class ServerLevelMetaData
{
	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint successes;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public uint dislikes;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public uint reports;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public uint plays;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public uint favorites;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public uint likes;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint fails;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public long delete_ts;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public long uploaded_ts;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float popularity;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float difficulty;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string code;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string user_id;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string data;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Level levelCache;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ThreadJob<Level> loadLevelJob;

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x801874", Offset = "0x801874", VA = "0x801874")]
	public ThreadJob<Level> GetLevelJob()
	{
		return null;
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x80189C", Offset = "0x80189C", VA = "0x80189C")]
	public Level GetLevel()
	{
		return null;
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x801948", Offset = "0x801948", VA = "0x801948")]
	public ServerLevelMetaData(string code)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x801970", Offset = "0x801970", VA = "0x801970")]
	public ServerLevelMetaData()
	{
	}
}
[Serializable]
[Token(Token = "0x20000CE")]
public class User
{
	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string username;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int imageId;

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x801978", Offset = "0x801978", VA = "0x801978")]
	public User(Dictionary<string, UserDataRecord> data)
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x7FF5D8", Offset = "0x7FF5D8", VA = "0x7FF5D8")]
	public void SetUserData(params (string, object)[] data)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x801BF0", Offset = "0x801BF0", VA = "0x801BF0")]
	public Dictionary<string, string> ToDictionary()
	{
		return null;
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x801CDC", Offset = "0x801CDC", VA = "0x801CDC")]
	public bool HasCreatedProfile()
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x20000CF")]
public class AuthenticationInfo
{
	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string token;

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x801DC8", Offset = "0x801DC8", VA = "0x801DC8")]
	public AuthenticationInfo()
	{
	}
}
[Token(Token = "0x20000D0")]
[CreateAssetMenu]
public class NetworkSettings : SingletonScriptableObject<NetworkSettings>
{
	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string levelStorageUrl;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int timeout;

	[Token(Token = "0x1700002D")]
	protected override bool KeepInResources
	{
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x801DD0", Offset = "0x801DD0", VA = "0x801DD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002E")]
	public string LevelStorageUrl
	{
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x801DD8", Offset = "0x801DD8", VA = "0x801DD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002F")]
	public int Timeout
	{
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x801DE0", Offset = "0x801DE0", VA = "0x801DE0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x801DE8", Offset = "0x801DE8", VA = "0x801DE8")]
	public NetworkSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x20000D1")]
public class ServerLevelMetaDataCollections
{
	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<ServerLevelMetaData> levelOnlineMetaDatas;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<ServerLevelMetaDataUserPair> favoritesMetaDataUserPairs;

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x801E30", Offset = "0x801E30", VA = "0x801E30")]
	public ServerLevelMetaDataCollections()
	{
	}
}
[Serializable]
[Token(Token = "0x20000D2")]
public class ServerLevelMetaDataUserPair
{
	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ServerLevelMetaData metadata;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public User user;

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x801E38", Offset = "0x801E38", VA = "0x801E38")]
	public ServerLevelMetaDataUserPair(ServerLevelMetaData metadata, User user)
	{
	}
}
[Token(Token = "0x20000D3")]
public class OutroComponent : MonoBehaviour
{
	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator balloonAnimator;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleEffectComponent despawnEffect;

	[NonSerialized]
	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool done;

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x801E64", Offset = "0x801E64", VA = "0x801E64")]
	public OutroComponent()
	{
	}
}
[Token(Token = "0x20000D4")]
public class OutroHandler
{
	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly OutroSettings outroSettings;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly OutroComponent outro;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool playing;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private GameState nextGameState;

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x801E74", Offset = "0x801E74", VA = "0x801E74")]
	public OutroHandler(InputHandler inputHandler, PalazzoTriggers palazzoTriggers, OutroSettings outroSettings, OutroComponent outro, PalazzoGameDataPersistent gameDataPersistent)
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x801F6C", Offset = "0x801F6C", VA = "0x801F6C")]
	public GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x802258", Offset = "0x802258", VA = "0x802258")]
	public void Start()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x801EC8", Offset = "0x801EC8", VA = "0x801EC8")]
	public void Reset()
	{
	}
}
[Token(Token = "0x20000D5")]
public static class PalazzoAux
{
	[Token(Token = "0x20000D6")]
	public sealed class PidScalar
	{
		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float kp;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float ki;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float kd;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float integral;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float errorPrev;

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x804D30", Offset = "0x804D30", VA = "0x804D30")]
		public void ResetCache()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x804D38", Offset = "0x804D38", VA = "0x804D38")]
		public float Tick(float error, float dt)
		{
			return default(float);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x804D74", Offset = "0x804D74", VA = "0x804D74")]
		public PidScalar()
		{
		}
	}

	[Token(Token = "0x20000D7")]
	private struct VertInfo
	{
		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 vert;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int origIndex;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 normal;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 averagedNormal;
	}

	[Token(Token = "0x40004F6")]
	private const float SHOW_NEXT_DOT_TIME = 0.2f;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float dotTimer;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int dotIndex;

	[Token(Token = "0x40004F9")]
	private const float TRAJECTORY_VELOCITY_MUL = 0.015f;

	[Token(Token = "0x40004FA")]
	private const float GUI_ANGLE_THRESHOLD = 15f;

	[Token(Token = "0x600037B")]
	public static void ReplaceWithLast<T>(List<T> li, ref int i, ref int n)
	{
	}

	[Token(Token = "0x600037C")]
	public static void ReplaceWithLast<T>(List<T> li, T obj)
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x80226C", Offset = "0x80226C", VA = "0x80226C")]
	public static int Mod(int a, int b)
	{
		return default(int);
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x8022F4", Offset = "0x8022F4", VA = "0x8022F4")]
	public static float Mod(float a, float b)
	{
		return default(float);
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x7FD038", Offset = "0x7FD038", VA = "0x7FD038")]
	public static Vector3 x0z(Vector3 v)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x80236C", Offset = "0x80236C", VA = "0x80236C")]
	public static Vector3 xy0(Vector3 v)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000381")]
	public static T[] EnumToArray<T>()
	{
		return null;
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x802374", Offset = "0x802374", VA = "0x802374")]
	public static void DisconnectFromJointBeforeDestroy(SpringJoint joint)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x8023A8", Offset = "0x8023A8", VA = "0x8023A8")]
	public static Vector3 CalcTrajectoryVelocity(Vector3 handDirection)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x802508", Offset = "0x802508", VA = "0x802508")]
	public static Vector3 CalcLevelGuiPosition(ARTransforms arTransforms, InputHandler inputHandler, WorldContext worldContext, MenuSettings menuSettings)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x802804", Offset = "0x802804", VA = "0x802804")]
	public static Quaternion CalcLevelGuiRotation(ARTransforms arTransforms, InputHandler inputHandler, WorldContext worldContext)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x8029C8", Offset = "0x8029C8", VA = "0x8029C8")]
	public static bool CalcLevelGuiTransformHasChanged(ARTransforms arTransforms, InputHandler inputHandler, WorldContext worldContext, Transform tfm)
	{
		return default(bool);
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x802A8C", Offset = "0x802A8C", VA = "0x802A8C")]
	public static string CalcVisibleLevelName(int levelIndex, string levelNameStringId, PalazzoWorld[] worldPrefabs)
	{
		return null;
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x802B70", Offset = "0x802B70", VA = "0x802B70")]
	public static string GetLocalizedString(string stringId)
	{
		return null;
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x802DEC", Offset = "0x802DEC", VA = "0x802DEC")]
	public static void SetVisisbleLevelName(LocalizedText localizedText, TMP_Text tmpText, int levelIndex, string levelNameStringId, PalazzoWorld[] worldPrefabs)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x802F14", Offset = "0x802F14", VA = "0x802F14")]
	public static void SetCustomLevelString(LocalizedText localizedText, TMP_Text tmpText, int levelId)
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x802FCC", Offset = "0x802FCC", VA = "0x802FCC")]
	public static void SetUserNameString(LocalizedText localizedText, TMP_Text tmpText, string userName)
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x803048", Offset = "0x803048", VA = "0x803048")]
	public static Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x7FD040", Offset = "0x7FD040", VA = "0x7FD040")]
	public static void SetKinematic(Rigidbody rb, bool isKinematic)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x8030E0", Offset = "0x8030E0", VA = "0x8030E0")]
	public static float CalcVolume(Bounds bounds)
	{
		return default(float);
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x8030FC", Offset = "0x8030FC", VA = "0x8030FC")]
	public static void AddHighlight(Renderer renderer, Material highlightMaterial)
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x803260", Offset = "0x803260", VA = "0x803260")]
	public static void RemoveHighlight(Renderer renderer, Material highlightMaterial)
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x8033EC", Offset = "0x8033EC", VA = "0x8033EC")]
	public static void AvarageMeshNormals(Mesh[] meshes)
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x8040B0", Offset = "0x8040B0", VA = "0x8040B0")]
	public static Vector3 CalcLocalSpaceInOtherTransformSpace(Transform local, Transform otherTransform)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x804148", Offset = "0x804148", VA = "0x804148")]
	public static void SpinWheel(Transform spinTransform, bool clockwise = false)
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x8041A8", Offset = "0x8041A8", VA = "0x8041A8")]
	public static void ResetLoadingDots(LoadingDots loadingDots)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x804254", Offset = "0x804254", VA = "0x804254")]
	public static void UpdateLoadingDots(LoadingDots loadingDots)
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x80439C", Offset = "0x80439C", VA = "0x80439C")]
	public static bool TryToggleFavorite(PalazzoButton button, ServerLevelMetaData metaData, User user, NetworkHandler networkHandler)
	{
		return default(bool);
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x804990", Offset = "0x804990", VA = "0x804990")]
	private static bool Requires(Type obj, Type requirement)
	{
		return default(bool);
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x804B30", Offset = "0x804B30", VA = "0x804B30")]
	public static bool CanDestroy(this GameObject go, Type t)
	{
		return default(bool);
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x804C44", Offset = "0x804C44", VA = "0x804C44")]
	public static bool CanMoveToNextLevel(LevelContext levelContext, List<string> levelGuids, PalazzoGameDataPersistent gameDataPersistent)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000DC")]
public enum BirdFlightState
{
	[Token(Token = "0x400050B")]
	OnGround,
	[Token(Token = "0x400050C")]
	OnPlatform,
	[Token(Token = "0x400050D")]
	MovingToPlatform,
	[Token(Token = "0x400050E")]
	MovingToSlingshot,
	[Token(Token = "0x400050F")]
	InSlingshot,
	[Token(Token = "0x4000510")]
	InFlight,
	[Token(Token = "0x4000511")]
	Dead
}
[Token(Token = "0x20000DD")]
public enum BirdMoveState
{
	[Token(Token = "0x4000513")]
	Init,
	[Token(Token = "0x4000514")]
	Idle,
	[Token(Token = "0x4000515")]
	RotateToMoveEnter,
	[Token(Token = "0x4000516")]
	RotateToMove,
	[Token(Token = "0x4000517")]
	Move,
	[Token(Token = "0x4000518")]
	RotateToStopEnter,
	[Token(Token = "0x4000519")]
	RotateToStop
}
[Token(Token = "0x20000DE")]
[RequireComponent(typeof(InteractiveCharacterComponent))]
[RequireComponent(typeof(PalazzoComponentLevelBlock))]
[RequireComponent(typeof(SphereCollider))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(ParticleSystem))]
[RequireComponent(typeof(Animator))]
[DisallowMultipleComponent]
public sealed class PalazzoComponentBird : MonoBehaviour
{
	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PalazzoComponentLevelBlock levelBlock;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Rigidbody rb;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SphereCollider col;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator anim;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public InteractiveCharacterComponent character;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem trail;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float birdStartScale;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string soundStretch;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string soundLaunch;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string soundJumpToSlingshot;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string soundSpecialAbility;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string soundHitTeleportationPoint;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ParticleEffectComponent prefabLaunchFx;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ParticleEffectComponent prefabSpecialAbilityFx;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TrailRenderer optionalSpeedTrail;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public ParticleSystem optionalFuseEffect;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public SkinnedMeshRenderer optionalSkinnedMeshRenderer;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float optionalExplosionCountdown;

	[NonSerialized]
	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public BirdImpactQueue birdImpactQueue;

	[NonSerialized]
	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public BirdFlightState flightState;

	[NonSerialized]
	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public BirdMoveState moveState;

	[NonSerialized]
	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Vector3 lastVelocity;

	[NonSerialized]
	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public float stayAliveForSeconds;

	[NonSerialized]
	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float impactMagnitude;

	[NonSerialized]
	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public float velocityRetainValue;

	[NonSerialized]
	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public bool hasImpacted;

	[NonSerialized]
	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
	public bool hasUsedSpecialAbility;

	[NonSerialized]
	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public readonly PalazzoAux.PidScalar pidRotation;

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x804E4C", Offset = "0x804E4C", VA = "0x804E4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x804F28", Offset = "0x804F28", VA = "0x804F28")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x804F54", Offset = "0x804F54", VA = "0x804F54")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x804F7C", Offset = "0x804F7C", VA = "0x804F7C")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x804FA4", Offset = "0x804FA4", VA = "0x804FA4")]
	public PalazzoComponentBird()
	{
	}
}
[Token(Token = "0x20000DF")]
[DisallowMultipleComponent]
public class PalazzoComponentBirdPlatform : MonoBehaviour
{
	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject highLight;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform[] birdPositions;

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x8050AC", Offset = "0x8050AC", VA = "0x8050AC")]
	public PalazzoComponentBirdPlatform()
	{
	}
}
[Token(Token = "0x20000E0")]
[DisallowMultipleComponent]
public sealed class PalazzoComponentLevel : MonoBehaviour
{
	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LevelSettings levelSettings;

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x8050B4", Offset = "0x8050B4", VA = "0x8050B4")]
	public PalazzoComponentLevel()
	{
	}
}
[Token(Token = "0x20000E1")]
[RequireComponent(typeof(Collider))]
[DisallowMultipleComponent]
public sealed class PalazzoComponentLevelBlock : MonoBehaviour
{
	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public int prefabPoolToken;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BlockTypeData blockTypeData;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Vector3 accumulatedExplosionForce;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Collider col;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Rigidbody optionalRigidbody;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public DamageComponent optionalDamageComponent;

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public FanComponent optionalFanComponent;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public BalloonComponent optionalBalloonComponent;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ExplosionComponent optionalExplosionComponent;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public PalazzoComponentPig optionalPigComponent;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public PalazzoComponentBird optionalBirdComponent;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TeleportationComponent optionalTeleportationComponent;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public WindComponent optionalWindComponent;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public bool hasRigidbody;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public AlchemyComponent optionalAlchemyComponent;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public AlchemyExplosionComponent optionalAlchemyExplosionComponent;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Renderer optionalRendererComponent;

	[Token(Token = "0x17000030")]
	public BlockType BlockType
	{
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x8050BC", Offset = "0x8050BC", VA = "0x8050BC")]
		get
		{
			return default(BlockType);
		}
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x8050D8", Offset = "0x8050D8", VA = "0x8050D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x805144", Offset = "0x805144", VA = "0x805144")]
	public PalazzoComponentLevelBlock()
	{
	}
}
[Token(Token = "0x20000E2")]
public enum PigReactionState
{
	[Token(Token = "0x400054B")]
	Wait,
	[Token(Token = "0x400054C")]
	Scared,
	[Token(Token = "0x400054D")]
	Relieved,
	[Token(Token = "0x400054E")]
	Happy,
	[Token(Token = "0x400054F")]
	Mad,
	[Token(Token = "0x4000550")]
	ShowOff,
	[Token(Token = "0x4000551")]
	Falling,
	[Token(Token = "0x4000552")]
	Hanging
}
[Token(Token = "0x20000E3")]
[RequireComponent(typeof(InteractiveCharacterComponent))]
[RequireComponent(typeof(DamageComponent))]
[RequireComponent(typeof(PalazzoComponentLevelBlock))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
[DisallowMultipleComponent]
[RequireComponent(typeof(SphereCollider))]
public sealed class PalazzoComponentPig : MonoBehaviour
{
	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PalazzoComponentLevelBlock levelBlock;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Rigidbody rb;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SphereCollider col;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator anim;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public InteractiveCharacterComponent character;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SkinnedMeshRenderer skinnedMeshRenderer;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material halfBrokenMaterial;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material brokenMaterial;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public MeshFilter optionalHatMesh;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public MeshRenderer optionalHatMeshRenderer;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float optionalOtherBlockVelocityThreshold;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float optionalBossPigDamageMultiplier;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ParticleSystem scaredParticleSystem;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public PigEvenListener pigEvenListener;

	[NonSerialized]
	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public PigReactionState reactionState;

	[NonSerialized]
	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int? animationToPlayAfterDelay;

	[NonSerialized]
	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float delayBeforeAnimation;

	[NonSerialized]
	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool screaming;

	[NonSerialized]
	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool inFan;

	[NonSerialized]
	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
	public bool isHanging;

	[NonSerialized]
	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
	public bool isFalling;

	[NonSerialized]
	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool isGrounded;

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x80514C", Offset = "0x80514C", VA = "0x80514C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x805170", Offset = "0x805170", VA = "0x805170")]
	public PalazzoComponentPig()
	{
	}
}
[Token(Token = "0x20000E4")]
public sealed class PalazzoComponentPigBalloon : MonoBehaviour
{
	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x805178", Offset = "0x805178", VA = "0x805178")]
	public PalazzoComponentPigBalloon()
	{
	}
}
[Token(Token = "0x20000E5")]
[DisallowMultipleComponent]
[RequireComponent(typeof(Animator))]
public sealed class PalazzoComponentSlingshot : MonoBehaviour
{
	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator anim;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform projectileLocation;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ParticleSystem pulseFX;

	[NonSerialized]
	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isAiming;

	[NonSerialized]
	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool isRubberbandInGrabRange;

	[NonSerialized]
	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float tensionMagnitude;

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x805180", Offset = "0x805180", VA = "0x805180")]
	public PalazzoComponentSlingshot()
	{
	}
}
[Token(Token = "0x20000E6")]
[DisallowMultipleComponent]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(GameObject))]
public sealed class PalazzoComponentStar : MonoBehaviour
{
	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject starFX;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Animator animator;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string audioEventName;

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x805188", Offset = "0x805188", VA = "0x805188")]
	public PalazzoComponentStar()
	{
	}
}
[Token(Token = "0x20000E7")]
public static class PalazzoDebug
{
	[Token(Token = "0x4000573")]
	public const KeyCode WIN_KEY = KeyCode.K;

	[Token(Token = "0x4000574")]
	public const KeyCode LOSE_KEY = KeyCode.L;

	[Token(Token = "0x4000575")]
	public const KeyCode RESET_LEVEL_KEY = KeyCode.R;

	[Token(Token = "0x4000576")]
	public const KeyCode TRIGGER_KEY = KeyCode.X;

	[Token(Token = "0x4000577")]
	public const KeyCode MENU_KEY = KeyCode.Z;

	[Token(Token = "0x4000578")]
	public const KeyCode SECONDARY_MENU_KEY = KeyCode.C;

	[Token(Token = "0x4000579")]
	public const KeyCode SWITCH_DESKTOP_MODE_KEY = KeyCode.Alpha1;

	[Token(Token = "0x400057A")]
	public const KeyCode SWITCH_FOV_MODE_KEY = KeyCode.Alpha2;

	[Token(Token = "0x400057B")]
	public const KeyCode PLACE_LEVEL_KEY = KeyCode.P;

	[Token(Token = "0x400057C")]
	public const KeyCode MOVE_LEFT_KEY = KeyCode.A;

	[Token(Token = "0x400057D")]
	public const KeyCode MOVE_RIGHT_KEY = KeyCode.D;

	[Token(Token = "0x400057E")]
	public const KeyCode MOVE_UP_KEY = KeyCode.E;

	[Token(Token = "0x400057F")]
	public const KeyCode MOVE_DOWN_KEY = KeyCode.Q;

	[Token(Token = "0x4000580")]
	public const KeyCode MOVE_FORWARD_KEY = KeyCode.W;

	[Token(Token = "0x4000581")]
	public const KeyCode MOVE_BACK_KEY = KeyCode.S;

	[Token(Token = "0x4000582")]
	public const KeyCode TURN_RIGHT = KeyCode.V;

	[Token(Token = "0x4000583")]
	public const KeyCode TURN_LEFT = KeyCode.C;

	[Token(Token = "0x4000584")]
	public const KeyCode STAMP_KEY = KeyCode.B;

	[Token(Token = "0x4000585")]
	public const KeyCode DELETE_KEY = KeyCode.N;

	[Token(Token = "0x4000586")]
	public const float MOVE_SPEED = 1f;

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x805190", Offset = "0x805190", VA = "0x805190")]
	[Conditional("DEBUG")]
	public static void Spam(string msg)
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x805370", Offset = "0x805370", VA = "0x805370")]
	public static void Log(string msg)
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x802C0C", Offset = "0x802C0C", VA = "0x802C0C")]
	public static void Warn(string msg)
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x805550", Offset = "0x805550", VA = "0x805550")]
	public static void Error(string msg)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x805730", Offset = "0x805730", VA = "0x805730")]
	public static bool SwitchFovMode()
	{
		return default(bool);
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x80573C", Offset = "0x80573C", VA = "0x80573C")]
	public static bool PlaceLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x805748", Offset = "0x805748", VA = "0x805748")]
	[Conditional("UNITY_EDITOR")]
	public static void CheckWin(LevelContext levelContext)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x80584C", Offset = "0x80584C", VA = "0x80584C")]
	[Conditional("UNITY_EDITOR")]
	public static void CheckLose(LevelContext levelContext)
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x8058FC", Offset = "0x8058FC", VA = "0x8058FC")]
	[Conditional("UNITY_EDITOR")]
	public static void CheckResetLevel(LevelFactory levelFactory, LevelContext levelContext, SlingshotAimHandler slingshotAimHandler, SlingshotLoader slingshotLoader, BirdsRemainingHandler birdsRemainingHandler, InputHandler inputHandler)
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x80598C", Offset = "0x80598C", VA = "0x80598C")]
	[Conditional("UNITY_EDITOR")]
	public static void DrawHandForward(ARTransforms arTransforms, InputHandler inputHandler, InputType hand)
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x805B0C", Offset = "0x805B0C", VA = "0x805B0C")]
	[Conditional("UNITY_EDITOR")]
	public static void DrawHeadForward(ARTransforms arTransforms, InputHandler inputHandler)
	{
	}
}
[Token(Token = "0x20000E8")]
public sealed class PalazzoEntryPoint : MonoBehaviour
{
	[Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class <Start>d__139 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PalazzoEntryPoint <>4__this;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <loadPlatformSceneAsync>5__2;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AsyncOperation <loadAdditiveSceneAsync>5__3;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private LevelBlockHelper <levelBlockHelper>5__4;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <impactMagnitudeThreshold>5__5;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PalazzoPlatform <palazzoPlatform>5__6;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextGroup[] <textGroups>5__7;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<GameObject, bool> <activeSelfLookup>5__8;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<GameObject, Transform> <parentLookup>5__9;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ShaderVariantCollection <svc>5__10;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int <i>5__11;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int <n>5__12;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int <i>5__13;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private WorldType[] <scenes>5__14;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string <sceneName>5__15;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x80C5B8", Offset = "0x80C5B8", VA = "0x80C5B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x80C600", Offset = "0x80C600", VA = "0x80C600", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x806AB4", Offset = "0x806AB4", VA = "0x806AB4")]
		[DebuggerHidden]
		public <Start>d__139(int <>1__state)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x8081A4", Offset = "0x8081A4", VA = "0x8081A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x8081A8", Offset = "0x8081A8", VA = "0x8081A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x80C5C0", Offset = "0x80C5C0", VA = "0x80C5C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class <LoadEnvironment>d__148 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WorldType newWorldScene;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PalazzoEntryPoint <>4__this;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AsyncOperation <async>5__2;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WorldType <world>5__3;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <scene>5__4;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x80CC48", Offset = "0x80CC48", VA = "0x80CC48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x80CC90", Offset = "0x80CC90", VA = "0x80CC90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x8075F8", Offset = "0x8075F8", VA = "0x8075F8")]
		[DebuggerHidden]
		public <LoadEnvironment>d__148(int <>1__state)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x80C608", Offset = "0x80C608", VA = "0x80C608", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x80C60C", Offset = "0x80C60C", VA = "0x80C60C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x80CC50", Offset = "0x80CC50", VA = "0x80CC50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class <DespawnLevel>d__149 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PalazzoEntryPoint <>4__this;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x80CE30", Offset = "0x80CE30", VA = "0x80CE30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x80CE78", Offset = "0x80CE78", VA = "0x80CE78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x807688", Offset = "0x807688", VA = "0x807688")]
		[DebuggerHidden]
		public <DespawnLevel>d__149(int <>1__state)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x80CC98", Offset = "0x80CC98", VA = "0x80CC98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x80CC9C", Offset = "0x80CC9C", VA = "0x80CC9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x80CE38", Offset = "0x80CE38", VA = "0x80CE38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class <DelayedClickEndOfLevelScreen>d__150 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PalazzoEntryPoint <>4__this;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ScoreBoardButtonType buttonType;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<GameState> nextGameState;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ThreadJob<Level> <getLevelJob>5__2;

		[Token(Token = "0x17000037")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x80D500", Offset = "0x80D500", VA = "0x80D500", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x80D548", Offset = "0x80D548", VA = "0x80D548", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x807730", Offset = "0x807730", VA = "0x807730")]
		[DebuggerHidden]
		public <DelayedClickEndOfLevelScreen>d__150(int <>1__state)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x80CE80", Offset = "0x80CE80", VA = "0x80CE80", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x80CE84", Offset = "0x80CE84", VA = "0x80CE84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x80D508", Offset = "0x80D508", VA = "0x80D508", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000587")]
	public const string PLATFORM_NAME = "Pico";

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly WaitForSeconds endOfLevelDelaySeconds;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool isShaderWarmedUp;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("Prefabs")]
	private Transform prefabPoolContainer;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ScoreEffectComponent blockScoreEffectComponentPrefab;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ScoreEffectComponent birdScoreEffectComponentPrefab;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ScoreEffectComponent pigScoreEffectComponentPrefab;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private PalazzoWorld[] worldPrefabs;

	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ParticleEffectComponent[] particleEffectPrefabs;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private PalazzoComponentLevelBlock[] levelBlockPrefabs;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private int[] levelBlockPrefabMaxCount;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private CutsceneComponent[] cutscenes;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private LevelEditorVRController vrControllerLevelEditor;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Header("Data Fields")]
	[SerializeField]
	private bool isTwoHanded;

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Material[] allMaterials;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Mesh warmUpMesh;

	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private PalazzoShaderVariant[] arShaderVariantCollection;

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private TensionHand tensionHand;

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private CameraFadeComponent cameraFadeComponent;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Transform tutorialPlacement;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private IntroComponent intro;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private OutroComponent outro;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private GameObject outOfBoundsText;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private AudioMixerGroup musicAudioGroup;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private AudioMixerGroup soundAudioGroup;

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private AmbientAudioComponent ambientAudioComponent;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private PlayStateSettings playStateSettings;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private EnvironmentEffects environmentEffects;

	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private UiPrefabs uiPrefabs;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private StartScreen startScreen;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private WorldSelectMenu worldSelectMenu;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private LevelSelect levelSelect;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private SettingsMenu settingsMenu;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private PrivacyMenu privacyMenu;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private GameObject noEntitlementScreen;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private RecoveryMenu recoveryMenu;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private ErrorMenu errorMenu;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private TutorialComponent tutorialComponent;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private LevelEditorComponent levelEditor;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Toolbox toolbox;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private PauseScreen[] pauseScreens;

	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private ScoreboardBase[] scoreboards;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private LoseScreen[] loseScreens;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private SplitMenu[] splitMenus;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private RatingScreen ratingScreen;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private CreateUserMenu createUserMenu;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ReportMenu reportMenu;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[SerializeField]
	[Header("Foldouts")]
	private ARTransforms arTransforms;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[SerializeField]
	private PhysicsSettings physicsSettings;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[SerializeField]
	private DamageSettings damageSettings;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	private SlingshotSettings slingshotSettingsOneHanded;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	private SlingshotSettings slingshotSettingsTwoHanded;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	private TrajectoryMarkerSettings trajectoryMarkerSettings;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	private TensionHandSettings tensionHandSettings;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	private ScoreboardSettings scoreboardSettings;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	private Transform[] characterLookAtTargets;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	private LevelSelectSettings levelSelectSettings;

	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	private MenuSettings menuSettings;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	private TutorialSettings tutorialSettings;

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	private OutroSettings outroSettings;

	[Token(Token = "0x40005C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	[SerializeField]
	private ToolboxSettings toolboxSettings;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	private LevelEditorSettings levelEditorSettings;

	[Token(Token = "0x40005C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	[SerializeField]
	private FontSettings fontSettings;

	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	[SerializeField]
	private CreateUserSettings createUserSettings;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private int[] themeLevelCount;

	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private float defaultMusicVolume;

	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	private float defaultSoundVolume;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private GameStateData gameStateData;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private PalazzoComponentLevel[] levelPrefabs;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private readonly MenuContext menuContext;

	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private readonly ScoreboardContext scoreboardContext;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private readonly List<string> levelSelectGuids;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private LimitedPool<ScoreEffectComponent>[] scoreEffectPrefabPoolLookup;

	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private ParticleEffectComponent[] particleEffectPrefabPoolLookup;

	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private ComponentPrefabPool<PalazzoComponentLevelBlock>[] levelBlockPrefabPoolLookup;

	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private DamageQueue damageQueue;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private BirdImpactQueue birdImpactQueue;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private WorldImpactQueue worldImpactQueue;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	private HealthBarData healthBarData;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private EffectQueue effectQueue;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	private readonly Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	private readonly Dictionary<int, WorldImpactComponent> colliderWorldImpactLookup;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private EffectOnImpactQueue effectOnImpactQueue;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	private InputHandler inputHandler;

	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	private AchievementHandler achievementHandler;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	private NetworkHandler networkHandler;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	private PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	private LevelBlockFactory levelBlockFactory;

	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	private LevelFactory levelFactory;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	private TeleportationHandler teleportationHandler;

	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	private WorldTracker worldTracker;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	private TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	private SlingshotLoader slingshotLoader;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	private SlingshotAimHandler slingshotAimHandler;

	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	private TeleportAimHandler teleportAimHandler;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	private SlingshotSettings slingshotSettings;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	private BirdsRemainingHandler birdsRemainingHandler;

	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	private DamageHandler damageHandler;

	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	private BirdSpecialAbilityHandler birdSpecialAbilityHandler;

	[Token(Token = "0x40005F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	private EnvironmentPhysicsHandler environmentPhysicsHandler;

	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	private PigEmotionalStateHandler pigEmotionalStateHandler;

	[Token(Token = "0x40005F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	private CharacterLookAtHandler characterLookAtHandler;

	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	private TutorialHandler tutorialHandler;

	[Token(Token = "0x40005F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	private TelePointHandler telePointHandler;

	[Token(Token = "0x40005F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	private HealthBarHandler healthBarHandler;

	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	private FadeHandler fadeHandler;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	private PlayerConstraintsHandler playerConstraintsHandler;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	private OutroHandler outroHandler;

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	private AlchemyHandler alchemyHandler;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	private CutsceneHandler cutsceneHandler;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	private EnvironmentEffectsHandler environmentEffectsHandler;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
	private ToolboxHandler toolboxHandler;

	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
	private PlaceLevelState placeLevelState;

	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
	private StartState startState;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
	private SelectWorldState selectWorldState;

	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
	private SelectLevelState selectLevelState;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	private SpawnLevelState spawnLevelState;

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
	private PlayState playState;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	private PauseState pauseState;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
	private WinState winState;

	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
	private ScoreboardState scoreboardState;

	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	private LoseState loseState;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
	private CutsceneState cutsceneState;

	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
	private OutroState outroState;

	[Token(Token = "0x400060A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
	private SettingsState settingsState;

	[Token(Token = "0x400060B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
	private PrivacyState privacyState;

	[Token(Token = "0x400060C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
	private NoEntitlementState noEntitlementState;

	[Token(Token = "0x400060D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
	private LevelEditorState levelEditorState;

	[Token(Token = "0x400060E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
	private ErrorState errorState;

	[Token(Token = "0x400060F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
	private GameStateBase[] gameStates;

	[Token(Token = "0x4000610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
	private bool viveInit;

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x805C7C", Offset = "0x805C7C", VA = "0x805C7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x806A4C", Offset = "0x806A4C", VA = "0x806A4C")]
	[IteratorStateMachine(typeof(<Start>d__139))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x806ADC", Offset = "0x806ADC", VA = "0x806ADC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x806C64", Offset = "0x806C64", VA = "0x806C64")]
	private void Update()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x806F48", Offset = "0x806F48", VA = "0x806F48")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x806FA0", Offset = "0x806FA0", VA = "0x806FA0")]
	private void ChangeState(GameState newGameState)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x807064", Offset = "0x807064", VA = "0x807064")]
	private void OnPlaceLevel(Vector3 arWorldPosition)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x8071A4", Offset = "0x8071A4", VA = "0x8071A4")]
	private void OnPauseGame(bool pause)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x807458", Offset = "0x807458", VA = "0x807458")]
	private void OnTeleport(TeleportationData teleportationData)
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x807560", Offset = "0x807560", VA = "0x807560")]
	private void OnTeleportHovering(bool hovering)
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x807580", Offset = "0x807580", VA = "0x807580")]
	[IteratorStateMachine(typeof(<LoadEnvironment>d__148))]
	private IEnumerator LoadEnvironment(WorldType newWorldScene)
	{
		return null;
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x807620", Offset = "0x807620", VA = "0x807620")]
	[IteratorStateMachine(typeof(<DespawnLevel>d__149))]
	private IEnumerator DespawnLevel()
	{
		return null;
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x8076B0", Offset = "0x8076B0", VA = "0x8076B0")]
	[IteratorStateMachine(typeof(<DelayedClickEndOfLevelScreen>d__150))]
	private IEnumerator DelayedClickEndOfLevelScreen(ScoreBoardButtonType buttonType, Action<GameState> nextGameState)
	{
		return null;
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x807758", Offset = "0x807758", VA = "0x807758")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x807810", Offset = "0x807810", VA = "0x807810")]
	public PalazzoEntryPoint()
	{
	}
}
[Token(Token = "0x20000EE")]
public enum HapticType
{
	[Token(Token = "0x4000636")]
	OnHover,
	[Token(Token = "0x4000637")]
	OnClick,
	[Token(Token = "0x4000638")]
	OnDisabled,
	[Token(Token = "0x4000639")]
	SlingshotTension,
	[Token(Token = "0x400063A")]
	OnSlingshotFire,
	[Token(Token = "0x400063B")]
	OnBirdLandInSlingshot,
	[Token(Token = "0x400063C")]
	OnBirdSpecialAbility,
	[Token(Token = "0x400063D")]
	OnExplosion,
	[Token(Token = "0x400063E")]
	OnScorebarTick,
	[Token(Token = "0x400063F")]
	OnStarLightUp,
	[Token(Token = "0x4000640")]
	OnTeleport
}
[Token(Token = "0x20000EF")]
public abstract class PalazzoInputDevice : IDisposable
{
	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected readonly ARTransforms arTransforms;

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x80D550", Offset = "0x80D550", VA = "0x80D550")]
	protected PalazzoInputDevice(ARTransforms arTransforms)
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x80D578", Offset = "0x80D578", VA = "0x80D578", Slot = "1")]
	~PalazzoInputDevice()
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x80D618", Offset = "0x80D618", VA = "0x80D618", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x80D684", Offset = "0x80D684", VA = "0x80D684", Slot = "5")]
	protected virtual void DisposeInternal(bool disposeManagedResources)
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x80D688", Offset = "0x80D688", VA = "0x80D688", Slot = "6")]
	public virtual void Tick()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x80D68C", Offset = "0x80D68C", VA = "0x80D68C", Slot = "7")]
	public virtual void HandleAchievement(Achievements type)
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x80D690", Offset = "0x80D690", VA = "0x80D690", Slot = "8")]
	public virtual bool ShouldHandlePrivacyPolicy()
	{
		return default(bool);
	}

	[Token(Token = "0x60003F9")]
	public abstract void Recenter();

	[Token(Token = "0x60003FA")]
	public abstract void PlayHaptic(HapticType hapticType, XRNode hand, [Optional] float? amplitude, bool playUntilStop = false);

	[Token(Token = "0x60003FB")]
	public abstract void StopHaptic(HapticType hapticType, XRNode hand);

	[Token(Token = "0x60003FC")]
	public abstract void SetHapticAmplitude(HapticType hapticType, XRNode hand, float amplitude);

	[Token(Token = "0x60003FD")]
	public abstract bool TriggerPressDown();

	[Token(Token = "0x60003FE")]
	public abstract bool TriggerPress();

	[Token(Token = "0x60003FF")]
	public abstract bool TriggerPressUp();

	[Token(Token = "0x6000400")]
	public abstract bool MenuPressDown();

	[Token(Token = "0x6000401")]
	public abstract bool MenuPress();

	[Token(Token = "0x6000402")]
	public abstract bool MenuPressUp();

	[Token(Token = "0x6000403")]
	public abstract bool SecondaryMenuPressDown();

	[Token(Token = "0x6000404")]
	public abstract bool SecondaryMenuPress();

	[Token(Token = "0x6000405")]
	public abstract bool SecondaryMenuPressUp();

	[Token(Token = "0x6000406")]
	public abstract bool StampItem(XRNode hand);

	[Token(Token = "0x6000407")]
	public abstract bool DeleteItem(XRNode hand);

	[Token(Token = "0x6000408")]
	public abstract bool ToolboxRecenterPressDown();

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x80D698", Offset = "0x80D698", VA = "0x80D698", Slot = "25")]
	public virtual bool TouchPadPress()
	{
		return default(bool);
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x80D6A0", Offset = "0x80D6A0", VA = "0x80D6A0", Slot = "26")]
	public virtual bool TouchpadPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x80D6A8", Offset = "0x80D6A8", VA = "0x80D6A8", Slot = "27")]
	public virtual bool TouchpadPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x80D6B0", Offset = "0x80D6B0", VA = "0x80D6B0", Slot = "28")]
	public virtual void SetHandedness(PlayerHandedness handedness)
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x80D6B4", Offset = "0x80D6B4", VA = "0x80D6B4", Slot = "29")]
	public virtual PlayerHandedness GetHandedness()
	{
		return default(PlayerHandedness);
	}

	[Token(Token = "0x600040E")]
	public abstract float Trigger(XRNode hand);

	[Token(Token = "0x600040F")]
	public abstract bool TriggerDown(XRNode hand);

	[Token(Token = "0x6000410")]
	public abstract bool TriggerUp(XRNode hand);

	[Token(Token = "0x6000411")]
	public abstract Vector2 ThumbstickAxis(XRNode hand);

	[Token(Token = "0x6000412")]
	public abstract Vector3 TouchpadSwipeVelocity();

	[Token(Token = "0x6000413")]
	public abstract Vector3 GetHeadLocalPosition();

	[Token(Token = "0x6000414")]
	public abstract Quaternion GetHeadLocalRotation();

	[Token(Token = "0x6000415")]
	public abstract Vector3 GetHandLocalPosition(XRNode hand);

	[Token(Token = "0x6000416")]
	public abstract Quaternion GetHandLocalRotation(XRNode hand);

	[Token(Token = "0x6000417")]
	public abstract Vector3 GetHandLocalPositionWhileAiming(XRNode hand);
}
[Token(Token = "0x20000F0")]
public static class PalazzoLoadSave
{
	[Serializable]
	[Token(Token = "0x20000F1")]
	private class PlayedOnlineLevelsCollection
	{
		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public HashSet<string> playedOnlineLevelIds;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x80F3B8", Offset = "0x80F3B8", VA = "0x80F3B8")]
		public PlayedOnlineLevelsCollection()
		{
		}
	}

	[Token(Token = "0x4000642")]
	private const string PALAZZO_GAME_DATA = "PalazzoGameData";

	[Token(Token = "0x4000643")]
	private const string PALAZZO_ONLINE_METADATAS = "PalazzoOnlineMetaDatas";

	[Token(Token = "0x4000644")]
	private const string PALAZZO_REQUEST_QUEUE = "PalazzoRequestQueue";

	[Token(Token = "0x4000645")]
	private const string PALAZZO_PLAYED_ONLINE_LEVELS = "PalazzoPlayedOnlineLevels";

	[Token(Token = "0x4000646")]
	private const string DATA_FOLDER_NAME = "level_editor";

	[Token(Token = "0x4000647")]
	private const string RECOVERY_FILE_NAME = "recovery.json";

	[Token(Token = "0x4000648")]
	private const string FILE_SUFFIX = "_leveldata.json";

	[Token(Token = "0x4000649")]
	private const uint LEVEL_SAVE_FILE_VERSION = 1u;

	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string recoveryFilePath;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<uint, string> filePaths;

	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Dictionary<uint, LevelMetaData> metaDataCache;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static ServerLevelMetaDataCollections onlineMetaDataCollections;

	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static HashSet<string> playedOnlineLevelIds;

	[Token(Token = "0x400064F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int maxNumberOfLevels;

	[Token(Token = "0x17000039")]
	private static string LevelEditorDataPath
	{
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x80D6BC", Offset = "0x80D6BC", VA = "0x80D6BC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x80D704", Offset = "0x80D704", VA = "0x80D704")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x80C2AC", Offset = "0x80C2AC", VA = "0x80C2AC")]
	public static void Init(int maxNumberOfLevels)
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x80C4D4", Offset = "0x80C4D4", VA = "0x80C4D4")]
	public static bool HasData()
	{
		return default(bool);
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x80C518", Offset = "0x80C518", VA = "0x80C518")]
	public static bool TryLoad(out PalazzoGameDataPersistent deserialized)
	{
		return default(bool);
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x8021C4", Offset = "0x8021C4", VA = "0x8021C4")]
	public static bool TrySave(PalazzoGameDataPersistent deserialized)
	{
		return default(bool);
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x80DE58", Offset = "0x80DE58", VA = "0x80DE58")]
	public static Level CreateNewLevel(uint saveIndex)
	{
		return null;
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x80E428", Offset = "0x80E428", VA = "0x80E428")]
	public static Level DuplicateLevel(uint saveIndex, Level levelToDuplicate)
	{
		return null;
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x80E5EC", Offset = "0x80E5EC", VA = "0x80E5EC")]
	public static void SaveRecoveryLevelToDisk(Level level)
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x80E668", Offset = "0x80E668", VA = "0x80E668")]
	public static bool HasRecoveryLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x8077A0", Offset = "0x8077A0", VA = "0x8077A0")]
	public static void DeleteRecoveryLevelFromDisk()
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x80E6B4", Offset = "0x80E6B4", VA = "0x80E6B4")]
	public static Level LoadRecoveryLevelFromDisk()
	{
		return null;
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x80E260", Offset = "0x80E260", VA = "0x80E260")]
	public static void SaveLevelToDisk(Level level)
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x80E760", Offset = "0x80E760", VA = "0x80E760")]
	public static void SaveOnlineMetaDataToDisk(uint id, ServerLevelMetaData onlineMetaData)
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x80E860", Offset = "0x80E860", VA = "0x80E860")]
	public static LevelMetaData[] GetAvailableLevelsOnDisk()
	{
		return null;
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x80E950", Offset = "0x80E950", VA = "0x80E950")]
	public static ServerLevelMetaData GetLocalLevelOnlineMetaData(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x80E4E4", Offset = "0x80E4E4", VA = "0x80E4E4")]
	public static Level LoadLevelFromDisk(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x80E9C8", Offset = "0x80E9C8", VA = "0x80E9C8")]
	public static void DeleteLevelFromDisk(uint id)
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x80477C", Offset = "0x80477C", VA = "0x80477C")]
	public static bool TryAddOnlineLevelToFavorites(ServerLevelMetaData metadata, User user)
	{
		return default(bool);
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x804624", Offset = "0x804624", VA = "0x804624")]
	public static void RemoveOnlineLevelFromFavorites(string onlineId)
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x80EC38", Offset = "0x80EC38", VA = "0x80EC38")]
	public static void UpdateFavoriteLevelsMetaDatas(ServerLevelMetaData[] metaDatas)
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x80EF7C", Offset = "0x80EF7C", VA = "0x80EF7C")]
	public static void UpdateFavoriteLevelUser(string id, User user)
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x80D3FC", Offset = "0x80D3FC", VA = "0x80D3FC")]
	public static Level LoadLevelFromFavorites(string id)
	{
		return null;
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x80F098", Offset = "0x80F098", VA = "0x80F098")]
	public static User GetFavoriteLevelUser(string id)
	{
		return null;
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x80F1A0", Offset = "0x80F1A0", VA = "0x80F1A0")]
	public static ServerLevelMetaData[] GetFavoriteLevelsOnDisk()
	{
		return null;
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x80452C", Offset = "0x80452C", VA = "0x80452C")]
	public static bool IsFavoriteLevel(string id)
	{
		return default(bool);
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x80F2D8", Offset = "0x80F2D8", VA = "0x80F2D8")]
	public static void MarkOnlineLevelAsPlayed(string id)
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x80F3C0", Offset = "0x80F3C0", VA = "0x80F3C0")]
	public static bool IsOnlineLevelPlayed(string id)
	{
		return default(bool);
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x80E710", Offset = "0x80E710", VA = "0x80E710")]
	private static Level LoadLevelFromDisk(string levelFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x80E7EC", Offset = "0x80E7EC", VA = "0x80E7EC")]
	private static void SaveOnlineMetaDataCollection()
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x80D750", Offset = "0x80D750", VA = "0x80D750")]
	private static void CacheLevelsOnDisk()
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x80E16C", Offset = "0x80E16C", VA = "0x80E16C")]
	private static string GetLevelFilePath(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x80DD74", Offset = "0x80DD74", VA = "0x80DD74")]
	private static void CachePlayedLevelsOnDisk()
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x80F430", Offset = "0x80F430", VA = "0x80F430")]
	public static bool DoesLevelExist(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x80F4A0", Offset = "0x80F4A0", VA = "0x80F4A0")]
	public static bool IsLocalLevelUploaded(uint id)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000F8")]
public abstract class PalazzoPlatform : SingleInstanceBehavior<PalazzoPlatform>
{
	[Token(Token = "0x1700003A")]
	protected PalazzoInputDevice InputDevice
	{
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x80F660", Offset = "0x80F660", VA = "0x80F660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x80F668", Offset = "0x80F668", VA = "0x80F668")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	protected WorldTracker WorldTracker
	{
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x80F670", Offset = "0x80F670", VA = "0x80F670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x80F678", Offset = "0x80F678", VA = "0x80F678")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600044E")]
	public abstract bool HasTwoHandedSupport();

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x80F680", Offset = "0x80F680", VA = "0x80F680", Slot = "7")]
	public virtual bool IsUserEntitled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x80F688", Offset = "0x80F688", VA = "0x80F688", Slot = "8")]
	public virtual Theme[] GetEnabledThemes()
	{
		return null;
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x80F6CC", Offset = "0x80F6CC", VA = "0x80F6CC", Slot = "9")]
	public virtual void OnMainSetupDone()
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x80F6D0", Offset = "0x80F6D0", VA = "0x80F6D0", Slot = "5")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x80F6E4", Offset = "0x80F6E4", VA = "0x80F6E4")]
	public PalazzoInputDevice CreateInputDevice(ARTransforms arTransforms)
	{
		return null;
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x80F710", Offset = "0x80F710", VA = "0x80F710")]
	public WorldTracker CreateWorldTracker(ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldImpactQueue worldImpactQueue)
	{
		return null;
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x80F73C", Offset = "0x80F73C", VA = "0x80F73C")]
	public bool IsThemeEnabledOnPlatform(Theme theme)
	{
		return default(bool);
	}

	[Token(Token = "0x6000456")]
	protected abstract PalazzoInputDevice CreateInputDeviceInternal(ARTransforms arTransforms);

	[Token(Token = "0x6000457")]
	protected abstract WorldTracker CreateWorldTrackerInternal(ARTransforms arTransforms, PalazzoTriggers palazzoTriggers);

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x80F7B8", Offset = "0x80F7B8", VA = "0x80F7B8")]
	protected PalazzoPlatform()
	{
	}
}
[Token(Token = "0x20000F9")]
public sealed class PalazzoPlatformVR : SingleInstanceBehavior<PalazzoPlatformVR>
{
	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform enviromentTransform;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform playerStartPosition;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public WorldImpactComponent[] impactComponents;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public EffectOnImpactComponent[] effectOnImpactComponents;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public EnvironmentParticleComponent[] environmentParticles;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Transform startPosition;

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x80F824", Offset = "0x80F824", VA = "0x80F824", Slot = "4")]
	public override void Awake()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x80F89C", Offset = "0x80F89C", VA = "0x80F89C", Slot = "5")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x80F958", Offset = "0x80F958", VA = "0x80F958")]
	public PalazzoPlatformVR()
	{
	}
}
[Token(Token = "0x20000FA")]
public static class PalazzoPlayFabApi
{
	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<string, User> usersCache;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool isFetchingUserData;

	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly GetUserDataRequest getUserDataRequest;

	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly ReportPlayerClientRequest reportPlayerRequest;

	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly LoginWithCustomIDRequest loginWithCustomIdRequest;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly ExecuteCloudScriptRequest createAuthTokenRequest;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly UpdateUserDataRequest updateUserDataRequest;

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x80F9C4", Offset = "0x80F9C4", VA = "0x80F9C4")]
	public static void ReportLevel(ServerLevelMetaData metaData, string reportMessage)
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x80FC98", Offset = "0x80FC98", VA = "0x80FC98")]
	public static void UpdateUserData(Future<bool> future, User user)
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x80FF88", Offset = "0x80FF88", VA = "0x80FF88")]
	public static void GetUserData(Future<User> future, string playFabId)
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x810378", Offset = "0x810378", VA = "0x810378")]
	public static void GetAuthToken(Future<string> future)
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x8105C8", Offset = "0x8105C8", VA = "0x8105C8")]
	public static void LoginWithCustomId(Future<string> future)
	{
	}
}
[Token(Token = "0x2000101")]
[Flags]
public enum BlockType
{
	[Token(Token = "0x4000671")]
	Invalid = 0,
	[Token(Token = "0x4000672")]
	Ice = 1,
	[Token(Token = "0x4000673")]
	Wood = 2,
	[Token(Token = "0x4000674")]
	Rock = 3,
	[Token(Token = "0x4000675")]
	Pig = 4,
	[Token(Token = "0x4000676")]
	Tnt = 5,
	[Token(Token = "0x4000677")]
	Fan = 6,
	[Token(Token = "0x4000678")]
	Balloon = 7,
	[Token(Token = "0x4000679")]
	Red = 8,
	[Token(Token = "0x400067A")]
	Yellow = 9,
	[Token(Token = "0x400067B")]
	Blue = 0xA,
	[Token(Token = "0x400067C")]
	Black = 0xB,
	[Token(Token = "0x400067D")]
	Water = 0xC,
	[Token(Token = "0x400067E")]
	TeleportationPoint = 0xD,
	[Token(Token = "0x400067F")]
	BossPig = 0xE,
	[Token(Token = "0x4000680")]
	RockSphere = 0xF,
	[Token(Token = "0x4000681")]
	Ground = 0x10,
	[Token(Token = "0x4000682")]
	AlchemyBomb = 0x11
}
[Token(Token = "0x2000102")]
public enum PlayerHandedness
{
	[Token(Token = "0x4000684")]
	Right,
	[Token(Token = "0x4000685")]
	Left
}
[Token(Token = "0x2000103")]
public static class BlockTypeHelper
{
	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly BlockType[] blockTypeArray;

	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly int blockTypeCount;
}
[Serializable]
[Token(Token = "0x2000104")]
public struct PalazzoShaderVariant
{
	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Shader shader;

	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public PassType passType;

	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string[] keywords;

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x8114E0", Offset = "0x8114E0", VA = "0x8114E0")]
	public ShaderVariantCollection.ShaderVariant AsUnityVariant()
	{
		return default(ShaderVariantCollection.ShaderVariant);
	}
}
[Token(Token = "0x2000105")]
public enum DamageState
{
	[Token(Token = "0x400068C")]
	Whole,
	[Token(Token = "0x400068D")]
	HalfBroken,
	[Token(Token = "0x400068E")]
	Broken
}
[Token(Token = "0x2000106")]
public enum Theme
{
	[Token(Token = "0x4000690")]
	Normal,
	[Token(Token = "0x4000691")]
	Nightmare,
	[Token(Token = "0x4000692")]
	LevelEditor
}
[Token(Token = "0x2000107")]
public sealed class LevelContext
{
	[Token(Token = "0x4000693")]
	public const float LEVEL_RADIUS = 15f;

	[Token(Token = "0x4000694")]
	public const int BLOCK_SCORE = 500;

	[Token(Token = "0x4000695")]
	public const int PIG_SCORE = 5000;

	[Token(Token = "0x4000696")]
	public const int BIRD_SCORE = 10000;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public PalazzoComponentLevel level;

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform lockedObjectsParent;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int levelIndex;

	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float levelRotation;

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int customLevelIndex;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Coroutine levelSpawnEffect;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Coroutine levelDespawnEffect;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int pigScore;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int blockScore;

	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int unusedBirdScore;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int birdCountLaunched;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public WorldType world;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool isInitialized;

	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int fixedFrameCounter;

	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool isPreview;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool hasFirstBirdReachedSlingshot;

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<ServerLevelMetaData> favoriteLevels;

	[Token(Token = "0x40006A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float playTimer;

	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public readonly List<PalazzoComponentLevelBlock> blocks;

	[Token(Token = "0x40006AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public readonly List<FanComponent> fans;

	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public readonly List<DamageComponent> damages;

	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public readonly List<BalloonComponent> balloons;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public readonly List<PalazzoComponentPig> pigs;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public readonly List<PalazzoComponentBird> birds;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public readonly List<InteractiveCharacterComponent> characters;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public readonly List<TeleportationComponent> teleportationPoints;

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x8114FC", Offset = "0x8114FC", VA = "0x8114FC")]
	public LevelContext()
	{
	}
}
[Token(Token = "0x2000108")]
public sealed class MenuContext
{
	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IMenuHandler activeMenuToHide;

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x8117B8", Offset = "0x8117B8", VA = "0x8117B8")]
	public MenuContext()
	{
	}
}
[Token(Token = "0x2000109")]
public sealed class LevelEditorContext
{
	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Level editingLevel;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isInteracting;

	[Token(Token = "0x40006B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float performanceCost;

	[Token(Token = "0x40006B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float reserveCost;

	[Token(Token = "0x40006B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool isTryingLevel;

	[Token(Token = "0x40006B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool isRecoveringLevel;

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x8117C0", Offset = "0x8117C0", VA = "0x8117C0")]
	public LevelEditorContext()
	{
	}
}
[Token(Token = "0x200010A")]
public sealed class LevelEditorPlayContext
{
	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LevelListContext playListContext;

	[Token(Token = "0x40006B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Level playLevel;

	[Token(Token = "0x40006BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ServerLevelMetaData playLevelOnlineMetaData;

	[Token(Token = "0x40006BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MenuType menuType;

	[Token(Token = "0x40006BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public MenuType prevMenuType;

	[Token(Token = "0x40006BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ErrorType errorType;

	[Token(Token = "0x40006BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string profileUserId;

	[Token(Token = "0x40006BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string currentlyViewedUser;

	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool reportOpenedFromMenu;

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x8117C8", Offset = "0x8117C8", VA = "0x8117C8")]
	public LevelEditorPlayContext()
	{
	}
}
[Serializable]
[Token(Token = "0x200010B")]
public sealed class LevelEditorSettings : ISerializationCallbackReceiver
{
	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int MaxLevelCost;

	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int maxLevelCost;

	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material deletionMaterial;

	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material greenMaterial;

	[Token(Token = "0x40006C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float buildingRadius;

	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int platformRotationTickSound;

	[Token(Token = "0x40006C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float platformDefaultYRotation;

	[Token(Token = "0x40006C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int maxNumberOfLevels;

	[Token(Token = "0x40006C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("Outline Materials")]
	public Material toolboxItemHighlightMaterial;

	[Token(Token = "0x40006CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material toolboxCharacterHighlightMaterial;

	[Token(Token = "0x40006CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material buildingItemHighlightMaterial;

	[Token(Token = "0x40006CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material buildingCharacterHighlightMaterial;

	[Token(Token = "0x40006CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Header("Height Teleportation")]
	public int maxStepY;

	[Token(Token = "0x40006CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int minStepY;

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x8117D0", Offset = "0x8117D0", VA = "0x8117D0", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x8117D4", Offset = "0x8117D4", VA = "0x8117D4", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x811824", Offset = "0x811824", VA = "0x811824")]
	public LevelEditorSettings()
	{
	}
}
[Token(Token = "0x200010C")]
public sealed class ScoreboardContext
{
	[Token(Token = "0x40006CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<BlockType> unusedBirds;

	[Token(Token = "0x40006D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LevelSettings levelSettings;

	[Token(Token = "0x40006D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int levelIndex;

	[Token(Token = "0x40006D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int pigScore;

	[Token(Token = "0x40006D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int blockScore;

	[Token(Token = "0x40006D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int unusedBirdScore;

	[Token(Token = "0x40006D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int birdCountLaunched;

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x81182C", Offset = "0x81182C", VA = "0x81182C")]
	public ScoreboardContext()
	{
	}
}
[Token(Token = "0x200010D")]
public sealed class WorldContext
{
	[Token(Token = "0x40006D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] WorldNames;

	[Token(Token = "0x40006D7")]
	public const WorldType START_SCENE = WorldType.Start;

	[Token(Token = "0x40006D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public WorldType activeWorldScene;

	[Token(Token = "0x40006D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int currentTheme;

	[Token(Token = "0x40006DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isEditing;

	[Token(Token = "0x40006DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public EnvironmentParticleComponent[] environmentParticles;

	[Token(Token = "0x40006DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Coroutine loadEnvironment;

	[Token(Token = "0x40006DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3? lastActiveTeleportationPosition;

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x8118AC", Offset = "0x8118AC", VA = "0x8118AC")]
	public WorldContext()
	{
	}
}
[Token(Token = "0x200010E")]
public enum PlayType
{
	[Token(Token = "0x40006DF")]
	UploadTrial,
	[Token(Token = "0x40006E0")]
	BaseGame,
	[Token(Token = "0x40006E1")]
	TryPlay,
	[Token(Token = "0x40006E2")]
	Favorite,
	[Token(Token = "0x40006E3")]
	Discovery,
	[Token(Token = "0x40006E4")]
	QuickPlay,
	[Token(Token = "0x40006E5")]
	BuildLevelsPlay,
	[Token(Token = "0x40006E6")]
	UserProfile,
	[Token(Token = "0x40006E7")]
	Search
}
[Serializable]
[Token(Token = "0x200010F")]
public sealed class LevelSelectSettings
{
	[Token(Token = "0x40006E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("Button materials")]
	public Material[] worldBossMaterials;

	[Token(Token = "0x40006E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sprite[] worldBossSprites;

	[Token(Token = "0x40006EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Border materials")]
	public Material beachBorder;

	[Token(Token = "0x40006EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material cliffBorder;

	[Token(Token = "0x40006EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material snowBorder;

	[Token(Token = "0x40006ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material peakBorder;

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x811BF4", Offset = "0x811BF4", VA = "0x811BF4")]
	public LevelSelectSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x2000110")]
public sealed class PlayStateSettings
{
	[Token(Token = "0x40006EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	public float noPigsEndGameSeconds;

	[Token(Token = "0x40006EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	public float noBirdsEndGameSeconds;

	[Token(Token = "0x40006F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float noBirdsEndGameAlwaysWaitSeconds;

	[Token(Token = "0x40006F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float gameEndSpeedThreshold;

	[Token(Token = "0x40006F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float gameEndAngularSpeedThreshold;

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x811BFC", Offset = "0x811BFC", VA = "0x811BFC")]
	public PlayStateSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x2000111")]
public sealed class PalazzoGameDataPersistent : ISerializationCallbackReceiver
{
	[Token(Token = "0x40006F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<string> levelGuid;

	[Token(Token = "0x40006F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> levelStarCount;

	[Token(Token = "0x40006F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<string> cutscenesWatched;

	[Token(Token = "0x40006F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool[] worldUnlocked;

	[Token(Token = "0x40006F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool musicEnabled;

	[Token(Token = "0x40006F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool soundEnabled;

	[Token(Token = "0x40006F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool hapticsEnabled;

	[Token(Token = "0x40006FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool acceptedPrivacyPolicy;

	[Token(Token = "0x40006FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool hasAcceptedTermsOfUse;

	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool hasSeenOutro;

	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int handedness;

	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool useSlingshotAim;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int totalStarCount;

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x811C1C", Offset = "0x811C1C", VA = "0x811C1C", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x811C68", Offset = "0x811C68", VA = "0x811C68", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x811C6C", Offset = "0x811C6C", VA = "0x811C6C")]
	public PalazzoGameDataPersistent()
	{
	}
}
[Serializable]
[Token(Token = "0x2000112")]
public sealed class ARTransforms
{
	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float vrVisualScaleUpMultiplier;

	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float visualLevelScaleDown;

	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float physicalLevelScaleUp;

	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("ARLevelRoot")]
	public Transform levelRoot;

	[Token(Token = "0x4000704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("ARWorldRoot")]
	public Transform worldRoot;

	[Token(Token = "0x4000705")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("ARCameraRoot")]
	public Transform cameraRoot;

	[Token(Token = "0x4000706")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform scoreEffectRoot;

	[Token(Token = "0x4000707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform particleEffectRoot;

	[Token(Token = "0x4000708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform arCamera;

	[Token(Token = "0x4000709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Camera arCameraComponent;

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x811DA8", Offset = "0x811DA8", VA = "0x811DA8")]
	public Vector3 ARWorldToLevelWorld(Vector3 position)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x811DC4", Offset = "0x811DC4", VA = "0x811DC4")]
	public Quaternion ARWorldToLevelWorld(Quaternion orientation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x811E74", Offset = "0x811E74", VA = "0x811E74")]
	public float ARWorldToLevelWorld(float distance)
	{
		return default(float);
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x811E84", Offset = "0x811E84", VA = "0x811E84")]
	public Vector3 LevelWorldToARWorld(Vector3 position)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x811EB8", Offset = "0x811EB8", VA = "0x811EB8")]
	public Quaternion LevelWorldToARWorld(Quaternion orientation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x811F70", Offset = "0x811F70", VA = "0x811F70")]
	public Vector3 ARWorldToLevelWorldInXZ(Vector3 worldPosition)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x811F94", Offset = "0x811F94", VA = "0x811F94")]
	public Quaternion ARWorldToLevelWorldLookRotationInXZ(Vector3 worldPosition)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x812008", Offset = "0x812008", VA = "0x812008")]
	public ARTransforms()
	{
	}
}
[Serializable]
[Token(Token = "0x2000113")]
public sealed class TrajectoryMarkerSettings
{
	[Token(Token = "0x400070A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float markerScale;

	[Token(Token = "0x400070B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float specialMarkerScale;

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int numMarkersToFade;

	[Token(Token = "0x400070D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Mesh markerMesh;

	[Token(Token = "0x400070E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material markerMaterial;

	[Token(Token = "0x400070F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Mesh specialMarkerMesh;

	[Token(Token = "0x4000710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material specialMarkerMaterial;

	[Token(Token = "0x4000711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public float markerAlphaValue;

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x812024", Offset = "0x812024", VA = "0x812024")]
	public TrajectoryMarkerSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x2000114")]
public sealed class DamageSettings
{
	[Token(Token = "0x4000712")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("Score")]
	public int scoreMultiplier;

	[Token(Token = "0x4000713")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Header("Damage")]
	public float damageMultiplier;

	[Token(Token = "0x4000714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float impactLightMax;

	[Token(Token = "0x4000715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float impactMediumMax;

	[Token(Token = "0x4000716")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float impactHeavyMax;

	[Token(Token = "0x4000717")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Header("Red Damage Mult")]
	public float redIceDamageMult;

	[Token(Token = "0x4000718")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float redWoodDamageMult;

	[Token(Token = "0x4000719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float redRockDamageMult;

	[Token(Token = "0x400071A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float redBossPigDamageMult;

	[Token(Token = "0x400071B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Header("Yellow Damage Mult")]
	public float yellowIceDamageMult;

	[Token(Token = "0x400071C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float yellowWoodDamageMult;

	[Token(Token = "0x400071D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float yellowRockDamageMult;

	[Token(Token = "0x400071E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float yellowBossPigDamageMult;

	[Token(Token = "0x400071F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Header("Blue Damage Mult")]
	public float blueIceDamageMult;

	[Token(Token = "0x4000720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float blueWoodDamageMult;

	[Token(Token = "0x4000721")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float blueRockDamageMult;

	[Token(Token = "0x4000722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float blueBossPigDamageMult;

	[Token(Token = "0x4000723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[Header("Black Damage Mult")]
	public float blackIceDamageMult;

	[Token(Token = "0x4000724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float blackWoodDamageMult;

	[Token(Token = "0x4000725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float blackRockDamageMult;

	[Token(Token = "0x4000726")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float blackBossPigDamageMult;

	[Token(Token = "0x4000727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[Header("Red Velocity Retain")]
	public float redIceVelocityRetain;

	[Token(Token = "0x4000728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float redWoodVelocityRetain;

	[Token(Token = "0x4000729")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float redRockVelocityRetain;

	[Token(Token = "0x400072A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float redBossPigVelocityRetain;

	[Token(Token = "0x400072B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float redBalloonVelocityRetain;

	[Token(Token = "0x400072C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Header("Yellow Velocity Retain")]
	public float yellowIceVelocityRetain;

	[Token(Token = "0x400072D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float yellowWoodVelocityRetain;

	[Token(Token = "0x400072E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float yellowRockVelocityRetain;

	[Token(Token = "0x400072F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float yellowBossPigVelocityRetain;

	[Token(Token = "0x4000730")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float yellowBalloonVelocityRetain;

	[Token(Token = "0x4000731")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[Header("Blue Velocity Retain")]
	public float blueIceVelocityRetain;

	[Token(Token = "0x4000732")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float blueWoodVelocityRetain;

	[Token(Token = "0x4000733")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float blueRockVelocityRetain;

	[Token(Token = "0x4000734")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float blueBossPigVelocityRetain;

	[Token(Token = "0x4000735")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float blueBalloonVelocityRetain;

	[Token(Token = "0x4000736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[Header("Black Velocity Retain")]
	public float blackIceVelocityRetain;

	[Token(Token = "0x4000737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float blackWoodVelocityRetain;

	[Token(Token = "0x4000738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float blackRockVelocityRetain;

	[Token(Token = "0x4000739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float blackBossPigVelocityRetain;

	[Token(Token = "0x400073A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float blackBalloonVelocityRetain;

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x812048", Offset = "0x812048", VA = "0x812048")]
	public DamageSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x2000115")]
public sealed class SlingshotSettings
{
	[Token(Token = "0x400073B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float stringTensionMin;

	[Token(Token = "0x400073C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float stringTensionMax;

	[Token(Token = "0x400073D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float stringTensionAnimationMax;

	[Token(Token = "0x400073E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float launchVelocityMin;

	[Token(Token = "0x400073F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float launchVelocityMax;

	[Token(Token = "0x4000740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float birdStayAliveForSeconds;

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x8120D8", Offset = "0x8120D8", VA = "0x8120D8")]
	public SlingshotSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x2000116")]
public sealed class PhysicsSettings
{
	[Token(Token = "0x4000741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 gravity;

	[Token(Token = "0x4000742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxAngularVelocity;

	[Token(Token = "0x4000743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float densityMultiplier;

	[Token(Token = "0x4000744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float impactMagnitudeThreshold;

	[Token(Token = "0x4000745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float birdVelocityMultiplier;

	[Token(Token = "0x4000746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Header("Bird")]
	public float birdAirDragMul;

	[Token(Token = "0x4000747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float redDensity;

	[Token(Token = "0x4000748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float yellowDensity;

	[Token(Token = "0x4000749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float blueDensity;

	[Token(Token = "0x400074A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float blackDensity;

	[Token(Token = "0x400074B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float yellowDashDensityMul;

	[Token(Token = "0x400074C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float yellowDashVelocityMul;

	[Token(Token = "0x400074D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Header("Pig")]
	public float pigDensity;

	[Token(Token = "0x400074E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float pigHealth;

	[Token(Token = "0x400074F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Header("Boss Pig")]
	public float bossPigDensity;

	[Token(Token = "0x4000750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float bossPigHealth;

	[Token(Token = "0x4000751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Header("Ice")]
	public float iceDensity;

	[Token(Token = "0x4000752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float iceHealth;

	[Token(Token = "0x4000753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Header("Rock")]
	public float rockDensity;

	[Token(Token = "0x4000754")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float rockHealth;

	[Token(Token = "0x4000755")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Header("RockSphere")]
	public float rockSphereDensity;

	[Token(Token = "0x4000756")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float rockSphereHealth;

	[Token(Token = "0x4000757")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Header("Wood")]
	public float woodDensity;

	[Token(Token = "0x4000758")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float woodHealth;

	[Token(Token = "0x4000759")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Header("Tnt")]
	public float tntDensity;

	[Token(Token = "0x400075A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float tntHealth;

	[Token(Token = "0x400075B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Header("AlchemyBomb")]
	public float alchBombDensity;

	[Token(Token = "0x400075C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float alchBombHealth;

	[Token(Token = "0x400075D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[Header("Fan")]
	public float fanAirDragMul;

	[Token(Token = "0x400075E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float fanDensity;

	[Token(Token = "0x400075F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float fanHealth;

	[Token(Token = "0x4000760")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float fanStrengthTweakMultiplier;

	[Token(Token = "0x4000761")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Header("Balloon")]
	public float balloonBuoyancyStartHeight;

	[Token(Token = "0x4000762")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float balloonAirDragMul;

	[Token(Token = "0x4000763")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float balloonAirDensityMul;

	[Token(Token = "0x4000764")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float balloonDensity;

	[Token(Token = "0x4000765")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float balloonHealth;

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x8120F8", Offset = "0x8120F8", VA = "0x8120F8")]
	public PhysicsSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x2000117")]
public sealed class FieldOfViewSettings
{
	[Token(Token = "0x4000766")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool active;

	[Token(Token = "0x4000767")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ARClippingMask;

	[Token(Token = "0x4000768")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float width;

	[Token(Token = "0x4000769")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float height;

	[Token(Token = "0x400076A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fovVertical;

	[Token(Token = "0x400076B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float fovHorizontal;

	[Token(Token = "0x400076C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float distanceToMask;

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x8121E0", Offset = "0x8121E0", VA = "0x8121E0")]
	public FieldOfViewSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x2000118")]
public sealed class EnvironmentEffects
{
	[Token(Token = "0x400076D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject spookyRain;

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x812200", Offset = "0x812200", VA = "0x812200")]
	public EnvironmentEffects()
	{
	}
}
[Token(Token = "0x2000119")]
public enum WorldType
{
	[Token(Token = "0x400076F")]
	Beach,
	[Token(Token = "0x4000770")]
	Cliff,
	[Token(Token = "0x4000771")]
	Snow,
	[Token(Token = "0x4000772")]
	Peak,
	[Token(Token = "0x4000773")]
	NightmareBeach,
	[Token(Token = "0x4000774")]
	NightmareCliff,
	[Token(Token = "0x4000775")]
	NightmareSnow,
	[Token(Token = "0x4000776")]
	NightmarePeak,
	[Token(Token = "0x4000777")]
	Start,
	[Token(Token = "0x4000778")]
	StartNightmare,
	[Token(Token = "0x4000779")]
	LevelEditor
}
[Serializable]
[Token(Token = "0x200011A")]
public sealed class LevelSettings
{
	[Token(Token = "0x400077A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string guid;

	[Token(Token = "0x400077B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string levelNameId;

	[Token(Token = "0x400077C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string levelDescriptionId;

	[Token(Token = "0x400077D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float birdsRemainingRadius;

	[Token(Token = "0x400077E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int scoreStar1;

	[Token(Token = "0x400077F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int scoreStar2;

	[Token(Token = "0x4000780")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int scoreStar3;

	[Token(Token = "0x4000781")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LevelBlockProxyTeleportationPoint startPoint;

	[Token(Token = "0x4000782")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string levelMusic;

	[Token(Token = "0x4000783")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TutorialType tutorialType;

	[Token(Token = "0x4000784")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public WorldType worldType;

	[NonSerialized]
	[Token(Token = "0x4000785")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool finished;

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x812208", Offset = "0x812208", VA = "0x812208")]
	public LevelSettings Clone()
	{
		return null;
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x81226C", Offset = "0x81226C", VA = "0x81226C")]
	public LevelSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x200011B")]
public sealed class HealthBarData
{
	[Token(Token = "0x200011C")]
	public struct ParameterIds
	{
		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int mainProgress;
	}

	[NonSerialized]
	[Token(Token = "0x4000786")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public MaterialPropertyBlock properties;

	[NonSerialized]
	[Token(Token = "0x4000787")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParameterIds parameterIds;

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x812290", Offset = "0x812290", VA = "0x812290")]
	public void Init()
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x812314", Offset = "0x812314", VA = "0x812314")]
	public HealthBarData()
	{
	}
}
[Serializable]
[Token(Token = "0x200011D")]
public sealed class TensionHandSettings
{
	[Token(Token = "0x4000789")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float maxScale;

	[Token(Token = "0x400078A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float timeToScaleUp;

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x81231C", Offset = "0x81231C", VA = "0x81231C")]
	public TensionHandSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x200011E")]
public sealed class ScoreboardSettings
{
	[Token(Token = "0x400078B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float timeBeforeStart;

	[Token(Token = "0x400078C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float blockScalingTime;

	[Token(Token = "0x400078D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float blockMinScale;

	[Token(Token = "0x400078E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float blockMaxScale;

	[Token(Token = "0x400078F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve blockScalingCurve;

	[Token(Token = "0x4000790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float textShowAfterTime;

	[Token(Token = "0x4000791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float textShowForTime;

	[Token(Token = "0x4000792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float particleFxScale;

	[Token(Token = "0x4000793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ParticleEffectComponent despawnEffect;

	[Token(Token = "0x4000794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string despawnEffectSound;

	[Token(Token = "0x4000795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color[] blockScoreColorTop;

	[Token(Token = "0x4000796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Color[] blockScoreColorBottom;

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x812330", Offset = "0x812330", VA = "0x812330")]
	public ScoreboardSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x200011F")]
public sealed class MenuSettings
{
	[Token(Token = "0x4000797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 startMenuPosition;

	[Token(Token = "0x4000798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 worldMenuStartPosition;

	[Token(Token = "0x4000799")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationComponent menuAnimationComponent;

	[Token(Token = "0x400079A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float distanceFromFace;

	[Token(Token = "0x400079B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float heightOffset;

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x81234C", Offset = "0x81234C", VA = "0x81234C")]
	public MenuSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x2000120")]
public sealed class TutorialSettings
{
	[Token(Token = "0x400079C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Sprite red;

	[Token(Token = "0x400079D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sprite chuck;

	[Token(Token = "0x400079E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite bomb;

	[Token(Token = "0x400079F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Sprite blues;

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x812360", Offset = "0x812360", VA = "0x812360")]
	public TutorialSettings()
	{
	}
}
[Token(Token = "0x2000121")]
public enum OutroClipState
{
	[Token(Token = "0x40007A1")]
	Init,
	[Token(Token = "0x40007A2")]
	Playing,
	[Token(Token = "0x40007A3")]
	Done
}
[Serializable]
[Token(Token = "0x2000122")]
public sealed class OutroClip
{
	[Token(Token = "0x40007A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject obj;

	[Token(Token = "0x40007A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float startAfterXSec;

	[Token(Token = "0x40007A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float duration;

	[Token(Token = "0x40007A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string sound;

	[NonSerialized]
	[Token(Token = "0x40007A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OutroClipState state;

	[NonSerialized]
	[Token(Token = "0x40007A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float timer;

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x812368", Offset = "0x812368", VA = "0x812368")]
	public OutroClip()
	{
	}
}
[Serializable]
[Token(Token = "0x2000123")]
public sealed class OutroSettings
{
	[Token(Token = "0x40007AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public OutroClip[] clips;

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x812370", Offset = "0x812370", VA = "0x812370")]
	public OutroSettings()
	{
	}
}
[Token(Token = "0x2000124")]
public enum CutSceneQueue
{
	[Token(Token = "0x40007AC")]
	BeforeLevel,
	[Token(Token = "0x40007AD")]
	AfterLevel
}
[Token(Token = "0x2000125")]
public enum Achievements
{
	[Token(Token = "0x40007AF")]
	ClearFirstLevel,
	[Token(Token = "0x40007B0")]
	Collect10Stars,
	[Token(Token = "0x40007B1")]
	UnlockSecondWorld,
	[Token(Token = "0x40007B2")]
	DefeatBossPig1,
	[Token(Token = "0x40007B3")]
	DefeatBossPig2,
	[Token(Token = "0x40007B4")]
	DefeatBossPig3,
	[Token(Token = "0x40007B5")]
	DefeatBossPig4,
	[Token(Token = "0x40007B6")]
	CollectAllStarsOnBeach,
	[Token(Token = "0x40007B7")]
	CollectAllStarsOnCliffs,
	[Token(Token = "0x40007B8")]
	CollectAllStarsOnSnow,
	[Token(Token = "0x40007B9")]
	CollectAllStarsOnPeak,
	[Token(Token = "0x40007BA")]
	CollectAllStarsInVacation,
	[Token(Token = "0x40007BB")]
	ActivateChucksAbility,
	[Token(Token = "0x40007BC")]
	ActivateBombsAbility,
	[Token(Token = "0x40007BD")]
	ActivateBluesAbility,
	[Token(Token = "0x40007BE")]
	UnlockSpookyMode,
	[Token(Token = "0x40007BF")]
	AlchemyBomb,
	[Token(Token = "0x40007C0")]
	EasterEgg1,
	[Token(Token = "0x40007C1")]
	CollectAllStarsOnMalibooBeach,
	[Token(Token = "0x40007C2")]
	DefeatBossPig5,
	[Token(Token = "0x40007C3")]
	EasterEgg2,
	[Token(Token = "0x40007C4")]
	CollectAllStarsOnCreepyClimb,
	[Token(Token = "0x40007C5")]
	DefeatBossPig6
}
[Serializable]
[Token(Token = "0x2000126")]
public class ToolboxSettings
{
	[Token(Token = "0x40007C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("Spawn items settings")]
	public ParticleEffectComponent effect;

	[Token(Token = "0x40007C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeToSpawn;

	[Token(Token = "0x40007C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Header("Positioning settings")]
	public bool lockToolboxToPlayer;

	[Token(Token = "0x40007C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 positionToPlayer;

	[Token(Token = "0x40007CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 rotationToPlayer;

	[Token(Token = "0x40007CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("Materials")]
	public Material unaffordableMat;

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x812378", Offset = "0x812378", VA = "0x812378")]
	public ToolboxSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x2000127")]
public class FontSettings
{
	[Token(Token = "0x40007CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TMP_FontAsset alwaysOnTopLatin;

	[Token(Token = "0x40007CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_FontAsset alwaysOnTopAsia;

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x812380", Offset = "0x812380", VA = "0x812380")]
	public FontSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x2000128")]
public class CreateUserSettings
{
	[Token(Token = "0x40007CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Sprite[] userImages;

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x812388", Offset = "0x812388", VA = "0x812388")]
	public CreateUserSettings()
	{
	}
}
[Token(Token = "0x2000129")]
public sealed class PalazzoTriggers
{
	[Token(Token = "0x40007CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x40007D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40007D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly DamageSettings damageSettings;

	[Token(Token = "0x40007D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40007D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40007D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Action<bool> onPauseGame;

	[Token(Token = "0x40007D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LimitedPool<ScoreEffectComponent>[] scoreEffectPrefabPoolLookup;

	[Token(Token = "0x40007D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly ParticleEffectComponent[] particleEffectPrefabPoolLookup;

	[Token(Token = "0x40007D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly List<ScoreEffectComponent> activeScoreEffects;

	[Token(Token = "0x40007D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly List<KeyValuePair<string, float>> delayedSounds;

	[Token(Token = "0x40007D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x40007DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly string[] zoneUpEvents;

	[Token(Token = "0x40007DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly string[] zoneDownEvents;

	[Token(Token = "0x40007DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly int tauntID;

	[Token(Token = "0x40007DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private readonly int happyID;

	[Token(Token = "0x40007DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly int madID;

	[Token(Token = "0x40007DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private readonly int scaredID;

	[Token(Token = "0x40007E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly int showOffID;

	[Token(Token = "0x40007E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private readonly int flinchID;

	[Token(Token = "0x40007E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly int fallID;

	[Token(Token = "0x40007E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly string impactMagnitudeName;

	[Token(Token = "0x40007E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float impactMagnitudePrev;

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x812390", Offset = "0x812390", VA = "0x812390")]
	public PalazzoTriggers(GameStateData gameStateData, ARTransforms arTransforms, DamageSettings damageSettings, InputHandler inputHandler, LevelContext levelContext, Action<bool> onPauseGame, LimitedPool<ScoreEffectComponent>[] scoreEffectPrefabPoolLookup, ParticleEffectComponent[] particleEffectPrefabPoolLookup, LevelEditorContext levelEditorContext)
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x8127D8", Offset = "0x8127D8", VA = "0x8127D8")]
	public void Tick()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x812D68", Offset = "0x812D68", VA = "0x812D68")]
	private void SetSoundParameter(string eventName, string parameterName, float value, [Optional] Component parent)
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x812E18", Offset = "0x812E18", VA = "0x812E18")]
	public void PlaySound(Component obj, string eventName)
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x812EA8", Offset = "0x812EA8", VA = "0x812EA8")]
	private void PlaySoundAfterDelay(string eventName, float delay)
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x813028", Offset = "0x813028", VA = "0x813028")]
	public void StopSound(Component obj, string eventName)
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x8130C0", Offset = "0x8130C0", VA = "0x8130C0")]
	private void ResetEventQueue()
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x813174", Offset = "0x813174", VA = "0x813174")]
	private ScoreEffectComponent SpawnScoreEffect(Vector3 levelLocalPosition, ScoreEffectComponent prefab)
	{
		return null;
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x813434", Offset = "0x813434", VA = "0x813434")]
	private ParticleEffectComponent SpawnEffect(Vector3 levelLocalPosition, ParticleEffectComponent prefab, bool rotateToLevelPosition, float scaleFactor = -99f)
	{
		return null;
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x8135AC", Offset = "0x8135AC", VA = "0x8135AC")]
	private ParticleEffectComponent SpawnEffectInToolbox(Vector3 itemPosition, ParticleEffectComponent prefab)
	{
		return null;
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x813694", Offset = "0x813694", VA = "0x813694")]
	private ParticleEffectComponent SpawnBlockScoreEffect(Vector3 levelLocalPosition, ParticleEffectComponent prefab)
	{
		return null;
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x8138A4", Offset = "0x8138A4", VA = "0x8138A4")]
	public static void OnPauseAudio()
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x81390C", Offset = "0x81390C", VA = "0x81390C")]
	public static void OnUnpauseAudio()
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x813974", Offset = "0x813974", VA = "0x813974")]
	public void OnStartGame()
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x813A54", Offset = "0x813A54", VA = "0x813A54")]
	public void OnIntroStart(IntroComponent intro)
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x813B0C", Offset = "0x813B0C", VA = "0x813B0C")]
	public void OnIntroStop(IntroComponent intro)
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x813BC0", Offset = "0x813BC0", VA = "0x813BC0")]
	public void OnOutroStart(OutroComponent outro)
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x813CB0", Offset = "0x813CB0", VA = "0x813CB0")]
	public void OnOutroSkip(OutroComponent outro)
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x813D74", Offset = "0x813D74", VA = "0x813D74")]
	public void OnPlayOutroClip(Transform obj, string sound)
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x813D78", Offset = "0x813D78", VA = "0x813D78")]
	public void OnStopOutroClip(Transform obj, string sound)
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x813D7C", Offset = "0x813D7C", VA = "0x813D7C")]
	public void OnEnterPartyPeak(OutroComponent outro)
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x813E00", Offset = "0x813E00", VA = "0x813E00")]
	public void OnButtonHover(PalazzoButton button)
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x813E48", Offset = "0x813E48", VA = "0x813E48")]
	public void OnButtonClick(PalazzoButton button)
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x813E90", Offset = "0x813E90", VA = "0x813E90")]
	public void OnDisabledButtonClick(PalazzoButton button)
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x813ED8", Offset = "0x813ED8", VA = "0x813ED8")]
	public void OnWorldImpact(WorldImpactComponent worldImpactComponent, Vector3 levelPosition, PalazzoComponentLevelBlock levelBlock)
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x813FA8", Offset = "0x813FA8", VA = "0x813FA8")]
	public void OnImpact(Vector3 levelPosition, BlockTypeData blockTypeData, float impactMagnitude)
	{
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x814138", Offset = "0x814138", VA = "0x814138")]
	public void OnBirdImpactPig(Vector3 levelPosition, BlockTypeData blockTypeData)
	{
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x81415C", Offset = "0x81415C", VA = "0x81415C")]
	public void OnTeleport()
	{
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x8141D4", Offset = "0x8141D4", VA = "0x8141D4")]
	public void OnHoverTeleportationPoint(TeleportationComponent teleportationComponent)
	{
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x81421C", Offset = "0x81421C", VA = "0x81421C")]
	public void OnFadeOutStart(CameraFadeComponent camera)
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x814220", Offset = "0x814220", VA = "0x814220")]
	public void OnFadeInDone(CameraFadeComponent camera)
	{
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x814224", Offset = "0x814224", VA = "0x814224")]
	public void OnScoreboardObjectDespawn(Vector3 levelPosition, Vector3 localScale, ParticleEffectComponent prefabDespawnFx, string soundDespawn)
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x813F4C", Offset = "0x813F4C", VA = "0x813F4C")]
	private bool ShouldRotateToLevel(PalazzoComponentLevelBlock levelBlock)
	{
		return default(bool);
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x814318", Offset = "0x814318", VA = "0x814318")]
	public void OnLevelBlockDestroy(PalazzoComponentLevelBlock levelBlock)
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x814414", Offset = "0x814414", VA = "0x814414")]
	public void OnLevelBlockSpawn(PalazzoComponentLevelBlock levelBlock)
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x814488", Offset = "0x814488", VA = "0x814488")]
	public void OnLevelBlockDespawn(PalazzoComponentLevelBlock levelBlock)
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x8144FC", Offset = "0x8144FC", VA = "0x8144FC")]
	public void OnBlockScore(PalazzoComponentLevelBlock levelBlock)
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x814548", Offset = "0x814548", VA = "0x814548")]
	public void OnBirdScore(PalazzoComponentBird bird, int score)
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x81463C", Offset = "0x81463C", VA = "0x81463C")]
	public void OnPigScore(PalazzoComponentPig pig, int score, int scoreMultiplier)
	{
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x814748", Offset = "0x814748", VA = "0x814748")]
	public void OnSlingshotTensionStart(PalazzoComponentSlingshot slingshot)
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x8147B8", Offset = "0x8147B8", VA = "0x8147B8")]
	public void OnSlingshotTensionStartBird(PalazzoComponentSlingshot slingshot, PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x81484C", Offset = "0x81484C", VA = "0x81484C")]
	public void OnSlingshotTensionTick(PalazzoComponentSlingshot slingshot, float stringTensionNormalized, float tensionDeltaPerSecond)
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x814914", Offset = "0x814914", VA = "0x814914")]
	public void OnSlingshotTensionStop(PalazzoComponentSlingshot slingshot)
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x81495C", Offset = "0x81495C", VA = "0x81495C")]
	public void OnSlingshotTensionStopBird(PalazzoComponentSlingshot slingshot, PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x8149C8", Offset = "0x8149C8", VA = "0x8149C8")]
	public void OnSlingshotLaunch(PalazzoComponentSlingshot slingshot)
	{
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x814A40", Offset = "0x814A40", VA = "0x814A40")]
	public void OnSlingshotMaxStart(PalazzoComponentSlingshot slingshot)
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x814A44", Offset = "0x814A44", VA = "0x814A44")]
	public void OnSlingshotMaxStop(PalazzoComponentSlingshot slingshot)
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x814A48", Offset = "0x814A48", VA = "0x814A48")]
	public void OnDamageComponentSwitchState(DamageComponent damage)
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x814AC4", Offset = "0x814AC4", VA = "0x814AC4")]
	public void OnPigSurviveAtLevelEnd(PalazzoComponentPig pig, float delay)
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x814B3C", Offset = "0x814B3C", VA = "0x814B3C")]
	public void OnPigHappyReaction(PalazzoComponentPig pig, float delay)
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x814BB4", Offset = "0x814BB4", VA = "0x814BB4")]
	public void OnPigMadReaction(PalazzoComponentPig pig, float delay)
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x814C2C", Offset = "0x814C2C", VA = "0x814C2C")]
	public void OnPigScaredReaction(PalazzoComponentPig pig, float delay)
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x814CA4", Offset = "0x814CA4", VA = "0x814CA4")]
	public void OnPigShowOffReaction(PalazzoComponentPig pig, float delay)
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x814D1C", Offset = "0x814D1C", VA = "0x814D1C")]
	public void OnPigFlinchReaction(PalazzoComponentPig pig, float delay)
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x814D94", Offset = "0x814D94", VA = "0x814D94")]
	public void OnPigScreamReactionStart(PalazzoComponentPig pig)
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x814DDC", Offset = "0x814DDC", VA = "0x814DDC")]
	public void OnPigScreamReactionStop(PalazzoComponentPig pig)
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x814E24", Offset = "0x814E24", VA = "0x814E24")]
	public void OnBossPigScreamReactionStart(PalazzoComponentPig bossPig)
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x814E28", Offset = "0x814E28", VA = "0x814E28")]
	public void OnBossPigScreamReactionStop(PalazzoComponentPig bossPig)
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x814E2C", Offset = "0x814E2C", VA = "0x814E2C")]
	public void OnPigFallStart(PalazzoComponentPig pig)
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x814EA0", Offset = "0x814EA0", VA = "0x814EA0")]
	public void OnPigFallStop(PalazzoComponentPig pig)
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x814EA4", Offset = "0x814EA4", VA = "0x814EA4")]
	public void OnPigSpawn(PalazzoComponentPig pig)
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x814F60", Offset = "0x814F60", VA = "0x814F60")]
	public void OnPigHanging(PalazzoComponentPig pig)
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x814FB8", Offset = "0x814FB8", VA = "0x814FB8")]
	public void OnBirdJumpToSlingshot(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x81502C", Offset = "0x81502C", VA = "0x81502C")]
	public void OnBirdLandInSlingshot(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x815084", Offset = "0x815084", VA = "0x815084")]
	public void OnBirdLandInTensionHand(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x8150DC", Offset = "0x8150DC", VA = "0x8150DC")]
	public void OnBirdGrabbed(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x815154", Offset = "0x815154", VA = "0x815154")]
	public void OnBirdDropped(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x8151B0", Offset = "0x8151B0", VA = "0x8151B0")]
	public void OnBirdLaunch(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x81527C", Offset = "0x81527C", VA = "0x81527C")]
	public void OnBirdActivateAbility(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x815314", Offset = "0x815314", VA = "0x815314")]
	public void OnBirdSpawn(PalazzoComponentBird bird, bool rotateToLevelPosition = false)
	{
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x8153D8", Offset = "0x8153D8", VA = "0x8153D8")]
	public void OnBirdStartFuse(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x815440", Offset = "0x815440", VA = "0x815440")]
	public void OnBirdStopFuse(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x8154A8", Offset = "0x8154A8", VA = "0x8154A8")]
	public void OnBirdHitTeleportationPoint(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x8154C0", Offset = "0x8154C0", VA = "0x8154C0")]
	public void OnBirdBlink(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x8154C4", Offset = "0x8154C4", VA = "0x8154C4")]
	public void OnScoreboardWin(Scoreboard scoreboard, LevelSettings levelSettings)
	{
	}

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x815560", Offset = "0x815560", VA = "0x815560")]
	public void OnScoreboardLose(LoseScreen loseScreen, PalazzoComponentLevel level)
	{
	}

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x815604", Offset = "0x815604", VA = "0x815604")]
	public void OnScoreboardClose()
	{
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x815608", Offset = "0x815608", VA = "0x815608")]
	public void OnScoreboardStar(Scoreboard scoreboard, PalazzoComponentStar star)
	{
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x81569C", Offset = "0x81569C", VA = "0x81569C")]
	public void OnScoreboardCounterStart(Scoreboard scoreboard)
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x8156E4", Offset = "0x8156E4", VA = "0x8156E4")]
	public void OnScoreboardCounterPause(Scoreboard scoreboard)
	{
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x81572C", Offset = "0x81572C", VA = "0x81572C")]
	public void OnScoreboardCounterStop(Scoreboard scoreboard)
	{
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x815774", Offset = "0x815774", VA = "0x815774")]
	public void OnScaleScoreObject(ScoreboardBreakdownComponent comp)
	{
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x815818", Offset = "0x815818", VA = "0x815818")]
	public void OnEnterLevelSelect(Theme currentTheme)
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x81591C", Offset = "0x81591C", VA = "0x81591C")]
	public void OnSelectLevel(PalazzoComponentLevel level)
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x815994", Offset = "0x815994", VA = "0x815994")]
	public void OnStartLevel(PalazzoComponentLevel level)
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x815A08", Offset = "0x815A08", VA = "0x815A08")]
	public void OnGameDataReset()
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x815A0C", Offset = "0x815A0C", VA = "0x815A0C")]
	public void OnSwitchWorld(WorldType world, Transform right, Transform left)
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x8175C8", Offset = "0x8175C8", VA = "0x8175C8")]
	public void OnUnlockVacationWorld()
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x817640", Offset = "0x817640", VA = "0x817640")]
	public void OnUnlockSpookyWorld()
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x8176E4", Offset = "0x8176E4", VA = "0x8176E4")]
	public void OnTutorialSpawn(TutorialComponent tutorial)
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x81772C", Offset = "0x81772C", VA = "0x81772C")]
	public void OnTutorialDespawn(TutorialComponent tutorial)
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x817730", Offset = "0x817730", VA = "0x817730")]
	public void SortLevels(OnlineSplitMenu menu)
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x817778", Offset = "0x817778", VA = "0x817778")]
	public static void OnFavorite(PalazzoButton button, bool isFavorited)
	{
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x8178A8", Offset = "0x8178A8", VA = "0x8178A8")]
	public void CreateUserProfile(PalazzoButton button)
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x8178F0", Offset = "0x8178F0", VA = "0x8178F0")]
	public void RandomizeUsernameStart(CreateUserMenu menu)
	{
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x817960", Offset = "0x817960", VA = "0x817960")]
	public void RandomizeUsernameStop(CreateUserMenu menu)
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x8179A8", Offset = "0x8179A8", VA = "0x8179A8")]
	public void Unshare(SideMenu sideMenu)
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x8179F0", Offset = "0x8179F0", VA = "0x8179F0")]
	public void UploadComplete(LevelEditorScoreboard scoreboard)
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x817A38", Offset = "0x817A38", VA = "0x817A38")]
	public void LikeLevel(PalazzoButton button)
	{
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x817A98", Offset = "0x817A98", VA = "0x817A98")]
	public void DislikeLevel(PalazzoButton button)
	{
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x817AF8", Offset = "0x817AF8", VA = "0x817AF8")]
	public void LevelFound(SideMenu sideMenu)
	{
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x817AFC", Offset = "0x817AFC", VA = "0x817AFC")]
	public void LevelNotFound(SideMenu sideMenu)
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x817B44", Offset = "0x817B44", VA = "0x817B44")]
	public void TypeLevelCode(PalazzoButton button)
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x817B48", Offset = "0x817B48", VA = "0x817B48")]
	public void EraseLevelCode(PalazzoButton button)
	{
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x817B4C", Offset = "0x817B4C", VA = "0x817B4C")]
	public void LevelEditorWin()
	{
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x817BEC", Offset = "0x817BEC", VA = "0x817BEC")]
	public void LevelEditorLose()
	{
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x817C8C", Offset = "0x817C8C", VA = "0x817C8C")]
	public void LevelEditorMusic()
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x817D04", Offset = "0x817D04", VA = "0x817D04")]
	public void CustomLevelMusic()
	{
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x817D7C", Offset = "0x817D7C", VA = "0x817D7C")]
	public void BirdSelected()
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x817DF4", Offset = "0x817DF4", VA = "0x817DF4")]
	public void PerformanceBarFilled(ParticleEffectComponent meterMaxedFx)
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x817E98", Offset = "0x817E98", VA = "0x817E98")]
	public void PhysicalButtonPress(PhysicalButton button, ParticleSystem buttonFx)
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x817F14", Offset = "0x817F14", VA = "0x817F14")]
	public void PhysicalButtonPauseEffect(PhysicalButton button, ParticleSystem buttonFx)
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x817F2C", Offset = "0x817F2C", VA = "0x817F2C")]
	public void PhysicalButtonResumeEffect(PhysicalButton button, ParticleSystem buttonFx)
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x817F44", Offset = "0x817F44", VA = "0x817F44")]
	public void PlayButtonPress()
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x818014", Offset = "0x818014", VA = "0x818014")]
	public void OnTriggerPlatformRotation()
	{
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x81808C", Offset = "0x81808C", VA = "0x81808C")]
	public void ToolboxObjectSpawn(ToolboxItemComponent block, ParticleEffectComponent spawnFx)
	{
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x8180D0", Offset = "0x8180D0", VA = "0x8180D0")]
	public void OnGrabObject(LevelBuildingBlock block)
	{
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x818118", Offset = "0x818118", VA = "0x818118")]
	public void OnPlaceObject(LevelBuildingBlock block)
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x818160", Offset = "0x818160", VA = "0x818160")]
	public void VRGrab(VRGrab hand)
	{
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x8181A8", Offset = "0x8181A8", VA = "0x8181A8")]
	public void OnSaveLevel(PhysicalButton button)
	{
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x81824C", Offset = "0x81824C", VA = "0x81824C")]
	public void OnSaveLevel(PalazzoButton button)
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x818294", Offset = "0x818294", VA = "0x818294")]
	public void OnToggleFinishedCheckbox(bool finished)
	{
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x81830C", Offset = "0x81830C", VA = "0x81830C")]
	public void OnDeletingLevel()
	{
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x818384", Offset = "0x818384", VA = "0x818384")]
	public void OnClearLevel()
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x8183FC", Offset = "0x8183FC", VA = "0x8183FC")]
	public void OnSpawnCutscene(int levelIndex, GameObject cutSceneGamobject)
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x81848C", Offset = "0x81848C", VA = "0x81848C")]
	public void OnStartCutscene(int levelIndex, GameObject cutSceneGamobject)
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x81851C", Offset = "0x81851C", VA = "0x81851C")]
	public void OnStopCutscene(int levelIndex, GameObject cutSceneGamobject)
	{
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x8185AC", Offset = "0x8185AC", VA = "0x8185AC")]
	public void OnRain(bool on)
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x8185B0", Offset = "0x8185B0", VA = "0x8185B0")]
	public void OnEnvironmentEffect(Component effectOnImpact, string eventName)
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x8185B4", Offset = "0x8185B4", VA = "0x8185B4")]
	private void OnNightmareLightningStrike(GameObject lightning)
	{
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x8133D0", Offset = "0x8133D0", VA = "0x8133D0")]
	private Vector3 RotateToLevelPosition(Vector3 localPosition)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200012A")]
public class PalazzoWorld : MonoBehaviour
{
	[Token(Token = "0x40007E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Theme theme;

	[Token(Token = "0x40007E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public WorldType worldType;

	[Token(Token = "0x40007E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PalazzoComponentLevel[] levels;

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x818650", Offset = "0x818650", VA = "0x818650")]
	public PalazzoWorld()
	{
	}
}
[Token(Token = "0x200012B")]
[DisallowMultipleComponent]
public sealed class ParticleEffectComponent : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200012C")]
	public struct ParticleEffectData
	{
		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ParticleSystem particleSystem;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int emitterCount;
	}

	[Token(Token = "0x40007E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public int prefabPoolToken;

	[Token(Token = "0x40007E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ttl;

	[Token(Token = "0x40007EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleEffectData[] particleEffects;

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x818658", Offset = "0x818658", VA = "0x818658")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x818850", Offset = "0x818850", VA = "0x818850")]
	public ParticleEffectComponent()
	{
	}
}
[Token(Token = "0x200012D")]
[RequireComponent(typeof(ParticleSystem))]
[DisallowMultipleComponent]
public sealed class ParticleSystemPlayOnEnable : MonoBehaviour
{
	[Token(Token = "0x40007ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem system;

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x8188A8", Offset = "0x8188A8", VA = "0x8188A8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x8188E0", Offset = "0x8188E0", VA = "0x8188E0")]
	public ParticleSystemPlayOnEnable()
	{
	}
}
[Token(Token = "0x200012E")]
[DisallowMultipleComponent]
public class PhysicalButton : MonoBehaviour
{
	[Token(Token = "0x40007EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer disabledMesh;

	[Token(Token = "0x40007EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer enabledMesh;

	[Token(Token = "0x40007F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject defaultSprite;

	[Token(Token = "0x40007F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject hoverSprite;

	[Token(Token = "0x40007F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Collider col;

	[Token(Token = "0x40007F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform pushable;

	[Token(Token = "0x40007F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ParticleEffectComponent buttonPressFx;

	[Token(Token = "0x40007F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ParticleEffectComponent optionalSaveFx;

	[Token(Token = "0x40007F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public bool isInteractable;

	[Token(Token = "0x40007F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	[HideInInspector]
	public bool isToggled;

	[Token(Token = "0x40007F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	[HideInInspector]
	public bool isInteracting;

	[Token(Token = "0x40007F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public ParticleSystem currentFx;

	[Token(Token = "0x40007FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public bool buttonPressed;

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x8188E8", Offset = "0x8188E8", VA = "0x8188E8")]
	public PhysicalButton()
	{
	}
}
[Token(Token = "0x200012F")]
public class PhysicalButton<T> : PhysicalButton
{
	[Token(Token = "0x40007FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T buttonType;

	[Token(Token = "0x6000528")]
	public PhysicalButton()
	{
	}
}
[Token(Token = "0x2000130")]
public sealed class PhysicalButtonHandler<TButton> where TButton : PhysicalButton
{
	[Token(Token = "0x40007FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40007FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly IList<TButton> buttons;

	[Token(Token = "0x40007FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Action<int> onInteract;

	[Token(Token = "0x40007FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly LevelEditorVRController vrController;

	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Collider[] interactedColliders;

	[Token(Token = "0x4000802")]
	private const float OVERLAP_RADIUS = 0.1f;

	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Vector3 buttonDepth;

	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Vector3[] handMovementDirection;

	[Token(Token = "0x4000805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Vector3[] handPositionPrev;

	[Token(Token = "0x4000806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly bool[] handHasInteracted;

	[Token(Token = "0x4000807")]
	private const float DIRECTION_ANGLE_THRESHOLD = 70f;

	[Token(Token = "0x4000808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private TButton currentButton;

	[Token(Token = "0x6000529")]
	public PhysicalButtonHandler(InputHandler inputHandler, IList<TButton> buttons, Action<int> onInteract, LevelEditorVRController vrController, PalazzoTriggers palazzoTriggers)
	{
	}

	[Token(Token = "0x600052A")]
	public void Tick()
	{
	}
}
[Token(Token = "0x2000131")]
public sealed class PigEmotionalStateHandler
{
	[Token(Token = "0x4000809")]
	private const float TIME_BEFORE_REACTION = 1f;

	[Token(Token = "0x400080A")]
	private const float MIN_ANIMATION_DELAY = 0f;

	[Token(Token = "0x400080B")]
	private const float MAX_ANIMATION_DELAY = 0.3f;

	[Token(Token = "0x400080C")]
	private const float PLAYER_TOO_CLOSE_DISTANCE = 10f;

	[Token(Token = "0x400080D")]
	private const float AIM_TOO_CLOSE_DISTANCE = 2f;

	[Token(Token = "0x400080E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x400080F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x4000812")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x4000813")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int launchedBirdAtLastHitReaction;

	[Token(Token = "0x4000814")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int launchedBirdAtLastLaunchReaction;

	[Token(Token = "0x4000815")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int alivePigsAtLastReaction;

	[Token(Token = "0x4000816")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float timeSinceChange;

	[Token(Token = "0x4000817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RaycastHit[] raycastHitResult;

	[Token(Token = "0x4000818")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int defaultLayerMask;

	[Token(Token = "0x4000819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 offSet;

	[Token(Token = "0x600052B")]
	[Address(RVA = "0x8188F8", Offset = "0x8188F8", VA = "0x8188F8")]
	public PigEmotionalStateHandler(LevelContext levelContext, PalazzoTriggers palazzoTriggers, InputHandler inputHandler, PalazzoComponentSlingshot slingshot, TrajectoryHandler trajectoryHandler)
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0x818A74", Offset = "0x818A74", VA = "0x818A74")]
	public void Reset()
	{
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0x818A80", Offset = "0x818A80", VA = "0x818A80")]
	public void Tick()
	{
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0x819048", Offset = "0x819048", VA = "0x819048")]
	private float CalcDistanceFromPlayerToPig(PalazzoComponentPig pig)
	{
		return default(float);
	}

	[Token(Token = "0x600052F")]
	[Address(RVA = "0x818F8C", Offset = "0x818F8C", VA = "0x818F8C")]
	private float CalcDistanceFromAimToPig(PalazzoComponentPig pig)
	{
		return default(float);
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0x819114", Offset = "0x819114", VA = "0x819114")]
	private float CalcDistanceFromFlyingBirdToPig(PalazzoComponentPig pig)
	{
		return default(float);
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x81911C", Offset = "0x81911C", VA = "0x81911C")]
	private bool IsLevelFalling()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000132")]
public sealed class PlaceLevelHandler
{
	[Token(Token = "0x400081A")]
	private const float LEVEL_HEIGHT = 0.4f;

	[Token(Token = "0x400081B")]
	private const float LEVEL_RADIUS = 0.4f;

	[Token(Token = "0x400081C")]
	private const float SPHERE_CAST_RADIUS = 0f;

	[Token(Token = "0x400081D")]
	private const float SPHERE_CAST_DIFF = 0.05f;

	[Token(Token = "0x400081E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400081F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly GameObject placeLevelIndicator;

	[Token(Token = "0x4000821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x4000822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<Vector3> onPlaceCallback;

	[Token(Token = "0x4000823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Transform placeLevelIndicatorTransform;

	[Token(Token = "0x4000824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly GameObject placementPossibleObject;

	[Token(Token = "0x4000825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly GameObject placementNotPossibleObject;

	[Token(Token = "0x4000826")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RaycastHit trajectoryHit;

	[Token(Token = "0x4000827")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly Vector3[] rayOffsetDirections;

	[Token(Token = "0x4000828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly List<float> medianHeightCache;

	[Token(Token = "0x6000532")]
	[Address(RVA = "0x819124", Offset = "0x819124", VA = "0x819124")]
	public PlaceLevelHandler(ARTransforms arTransforms, InputHandler inputHandler, GameObject placeLevelIndicator, TrajectoryHandler trajectoryHandler, Action<Vector3> onPlaceCallback)
	{
	}

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x819768", Offset = "0x819768", VA = "0x819768")]
	private bool IsIntersectingTrajectory(Vector3 pos, Vector3 dir, float len)
	{
		return default(bool);
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x819840", Offset = "0x819840", VA = "0x819840")]
	public void Tick()
	{
	}
}
[Token(Token = "0x2000133")]
public sealed class PlayerConstraintsHandler
{
	[Token(Token = "0x2000134")]
	private enum State
	{
		[Token(Token = "0x4000838")]
		Init,
		[Token(Token = "0x4000839")]
		Play,
		[Token(Token = "0x400083A")]
		Restrict
	}

	[Token(Token = "0x4000829")]
	private const float TOO_CLOSE_TO_LEVEL = 6f;

	[Token(Token = "0x400082A")]
	private const float TOO_FAR_AWAY_FROM_CAMERA_ORIGIN = 1.5f;

	[Token(Token = "0x400082B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400082C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x400082D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly GameObject outOfBoundsGameObject;

	[Token(Token = "0x400082E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TMP_Text outOfBoundsText;

	[Token(Token = "0x400082F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000830")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly FontSettings fontSettings;

	[Token(Token = "0x4000831")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Collider[] hitCollider;

	[Token(Token = "0x4000832")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly int layerMask;

	[Token(Token = "0x4000833")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool fade;

	[Token(Token = "0x4000834")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private TMP_FontAsset alwaysOnTopFont;

	[Token(Token = "0x4000835")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private State state;

	[Token(Token = "0x4000836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private State prevState;

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x81A44C", Offset = "0x81A44C", VA = "0x81A44C")]
	public PlayerConstraintsHandler(ARTransforms arTransforms, FadeHandler fadeHandler, GameObject outOfBoundsGameObject, WorldContext worldContext, FontSettings fontSettings)
	{
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x81A5D0", Offset = "0x81A5D0", VA = "0x81A5D0")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x81A958", Offset = "0x81A958", VA = "0x81A958")]
	public bool IsPlayerOutOfBounds()
	{
		return default(bool);
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x81A880", Offset = "0x81A880", VA = "0x81A880")]
	private bool IsTooCloseToLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x81A910", Offset = "0x81A910", VA = "0x81A910")]
	private bool IsTooFarAwayFromCameraOrigin()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000135")]
public abstract class PrefabPool<T> where T : UnityEngine.Object
{
	[Token(Token = "0x400083B")]
	private const int MAX_CAPACITY = 4096;

	[Token(Token = "0x400083C")]
	private const double INV_LOG2 = 1.44269504088896;

	[Token(Token = "0x400083D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected readonly Transform disabledParentTransform;

	[Token(Token = "0x400083E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public readonly T prefab;

	[Token(Token = "0x400083F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T[] buffer;

	[Token(Token = "0x4000840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected int capacity;

	[Token(Token = "0x4000841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int size;

	[Token(Token = "0x4000842")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int head;

	[Token(Token = "0x4000843")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int tail;

	[Token(Token = "0x600053B")]
	protected PrefabPool(Transform disabledParentTransform, T prefab, int capacity)
	{
	}

	[Token(Token = "0x600053C")]
	public void AssertSizeZero()
	{
	}

	[Token(Token = "0x600053D")]
	public void AssertAllObjectsAlive()
	{
	}

	[Token(Token = "0x600053E")]
	protected virtual void IncreaseCapacity(int n)
	{
	}

	[Token(Token = "0x600053F")]
	protected T PopInternal()
	{
		return null;
	}

	[Token(Token = "0x6000540")]
	protected void PushInternal(T obj)
	{
	}
}
[Token(Token = "0x2000136")]
public sealed class GameObjectPrefabPool : PrefabPool<GameObject>
{
	[Token(Token = "0x6000541")]
	[Address(RVA = "0x81A99C", Offset = "0x81A99C", VA = "0x81A99C")]
	public GameObjectPrefabPool(Transform disabledParentTransform, GameObject prefab, int capacity)
	{
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x81AA0C", Offset = "0x81AA0C", VA = "0x81AA0C")]
	public GameObject Pop(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x81AA90", Offset = "0x81AA90", VA = "0x81AA90")]
	public GameObject Pop(Transform parent, Vector3 localPosition, Quaternion localRotation)
	{
		return null;
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x81AB88", Offset = "0x81AB88", VA = "0x81AB88")]
	public void Push(GameObject obj)
	{
	}
}
[Token(Token = "0x2000137")]
public sealed class ComponentPrefabPool<T> : PrefabPool<T> where T : Component
{
	[Token(Token = "0x6000545")]
	public ComponentPrefabPool(Transform disabledParentTransform, T prefab, int capacity)
	{
	}

	[Token(Token = "0x6000546")]
	protected override void IncreaseCapacity(int n)
	{
	}

	[Token(Token = "0x6000547")]
	public T Pop(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000548")]
	public T Pop(Transform parent, Vector3 localPosition, Quaternion localRotation)
	{
		return null;
	}

	[Token(Token = "0x6000549")]
	public void Push(T obj)
	{
	}
}
[Token(Token = "0x2000138")]
public class LimitedPool<T> where T : Component
{
	[Token(Token = "0x4000844")]
	private const double INV_LOG2 = 1.44269504088896;

	[Token(Token = "0x4000845")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Transform disabledParentTransform;

	[Token(Token = "0x4000846")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected T[] buffer;

	[Token(Token = "0x4000847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int capacity;

	[Token(Token = "0x4000848")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int endIndex;

	[Token(Token = "0x4000849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int startIndex;

	[Token(Token = "0x1700003C")]
	public int Size
	{
		[Token(Token = "0x600054A")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003D")]
	private T[] Buffer
	{
		[Token(Token = "0x600054B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003E")]
	public int Capacity
	{
		[Token(Token = "0x600054C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003F")]
	public int StartIndex
	{
		[Token(Token = "0x600054D")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000040")]
	public int EndIndex
	{
		[Token(Token = "0x600054E")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600054F")]
	public LimitedPool(Transform disabledParentTransform, T prefab, int capacity)
	{
	}

	[Token(Token = "0x6000550")]
	public T Pop(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000551")]
	public T Pop(Transform parent, Vector3 localPosition, Quaternion localRotation)
	{
		return null;
	}

	[Token(Token = "0x6000552")]
	public void Push(T obj)
	{
	}

	[Token(Token = "0x6000553")]
	private T PopInternal()
	{
		return null;
	}

	[Token(Token = "0x6000554")]
	private void PushInternal(T obj)
	{
	}

	[Token(Token = "0x6000555")]
	protected int Allocate()
	{
		return default(int);
	}

	[Token(Token = "0x6000556")]
	protected int Deallocate()
	{
		return default(int);
	}

	[Token(Token = "0x6000557")]
	public void Clear()
	{
	}
}
[Token(Token = "0x2000139")]
public class PreviewHandler
{
	[Token(Token = "0x200013A")]
	private enum State
	{
		[Token(Token = "0x4000853")]
		Init,
		[Token(Token = "0x4000854")]
		Despawning,
		[Token(Token = "0x4000855")]
		Spawning,
		[Token(Token = "0x4000856")]
		Preview
	}

	[Token(Token = "0x400084A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private State state;

	[Token(Token = "0x400084B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private State prevState;

	[Token(Token = "0x400084C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x400084D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelFactory levelFactory;

	[Token(Token = "0x400084E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x400084F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Transform levelRoot;

	[Token(Token = "0x4000850")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Level currentLevelBeingPreviewed;

	[Token(Token = "0x4000851")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Level queuedPreviewLevel;

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x81AC00", Offset = "0x81AC00", VA = "0x81AC00")]
	public PreviewHandler(LevelContext levelContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelRoot)
	{
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x81AC40", Offset = "0x81AC40", VA = "0x81AC40")]
	public void Tick()
	{
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x81AE78", Offset = "0x81AE78", VA = "0x81AE78")]
	public void Preview(Level level)
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x81AF00", Offset = "0x81AF00", VA = "0x81AF00")]
	public void InstantDespawn()
	{
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x81AF88", Offset = "0x81AF88", VA = "0x81AF88")]
	public void Despawn()
	{
	}
}
[Token(Token = "0x200013B")]
public sealed class ProgressMeter : MonoBehaviour
{
	[Token(Token = "0x4000857")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Renderer renderer;

	[NonSerialized]
	[Token(Token = "0x4000858")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float mainProgress;

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x81AF94", Offset = "0x81AF94", VA = "0x81AF94")]
	public ProgressMeter()
	{
	}
}
[Token(Token = "0x200013C")]
[DisallowMultipleComponent]
public sealed class ScoreEffectComponent : MonoBehaviour
{
	[Token(Token = "0x4000859")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public int prefabPoolToken;

	[Token(Token = "0x400085A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform effectTransform;

	[Token(Token = "0x400085B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro scoreText;

	[Token(Token = "0x400085C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float stayAliveForSeconds;

	[Token(Token = "0x400085D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AnimationCurve alphaAnimation;

	[Token(Token = "0x400085E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve scaleAnimation;

	[Token(Token = "0x400085F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AnimationCurve forwardAnimation;

	[Token(Token = "0x4000860")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve heightAnimation;

	[NonSerialized]
	[Token(Token = "0x4000861")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float elapsedTimeNormalized;

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x81AF9C", Offset = "0x81AF9C", VA = "0x81AF9C")]
	public ScoreEffectComponent()
	{
	}
}
[Token(Token = "0x200013D")]
[DisallowMultipleComponent]
public class SettingsControlsComponent : MonoBehaviour
{
	[Token(Token = "0x4000862")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshPro trigger;

	[Token(Token = "0x4000863")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshPro pause;

	[Token(Token = "0x4000864")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro recenter;

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x81AFA4", Offset = "0x81AFA4", VA = "0x81AFA4")]
	public SettingsControlsComponent()
	{
	}
}
[Token(Token = "0x200013E")]
public class SlideIndicator : MonoBehaviour
{
	[Token(Token = "0x4000865")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("defaultSprite")]
	[FormerlySerializedAs("unselected")]
	public GameObject deselected;

	[Token(Token = "0x4000866")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("selectedSprite")]
	public GameObject selected;

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x81AFAC", Offset = "0x81AFAC", VA = "0x81AFAC")]
	public SlideIndicator()
	{
	}
}
[Token(Token = "0x200013F")]
public sealed class SlingshotAimHandler
{
	[Token(Token = "0x4000867")]
	private const float STRING_TENSION_THRESHOLD = 0.1f;

	[Token(Token = "0x4000868")]
	private const float HANDS_DISTANCE_THRESHOLD = 0.015f;

	[Token(Token = "0x4000869")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400086A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PhysicsSettings physicsSettings;

	[Token(Token = "0x400086B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly SlingshotSettings slingshotSettings;

	[Token(Token = "0x400086C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TrajectoryMarkerSettings trajectoryMarkerSettings;

	[Token(Token = "0x400086D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x400086E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x400086F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000870")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000871")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x4000872")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly TensionHand tensionHand;

	[Token(Token = "0x4000873")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x4000874")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly Transform slingshotTransform;

	[Token(Token = "0x4000875")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly int slingshotStateNameHash;

	[Token(Token = "0x4000876")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private readonly float tensionDistanceMax;

	[Token(Token = "0x4000877")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly int layerMask;

	[Token(Token = "0x4000878")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float stringTensionNormalizedPrev;

	[Token(Token = "0x4000879")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool prevEnoughForce;

	[Token(Token = "0x400087A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool prevIsAiming;

	[Token(Token = "0x400087B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
	private bool hasReleased;

	[Token(Token = "0x400087C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
	private bool isTensionMax;

	[Token(Token = "0x400087D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private readonly Vector3 slingshotPocketOriginalPositionInSlingshotSpace;

	[Token(Token = "0x400087E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 launchBirdPosition;

	[Token(Token = "0x400087F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float onLaunchMagnitude;

	[Token(Token = "0x4000880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float onLaunchFactor;

	[Token(Token = "0x4000881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Quaternion slingshotLaunchRotation;

	[Token(Token = "0x4000882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float timeSinceLastBird;

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x81AFB4", Offset = "0x81AFB4", VA = "0x81AFB4")]
	public SlingshotAimHandler(ARTransforms arTransforms, PhysicsSettings physicsSettings, SlingshotSettings slingshotSettings, TrajectoryMarkerSettings trajectoryMarkerSettings, PalazzoComponentSlingshot slingshot, InputHandler inputHandler, LevelContext levelContext, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, TensionHand tensionHand, PalazzoGameDataPersistent gameDataPersistent)
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x81B1F0", Offset = "0x81B1F0", VA = "0x81B1F0")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x81B3A0", Offset = "0x81B3A0", VA = "0x81B3A0")]
	private bool IsIntersectingTrajectory(Vector3 pos, Vector3 dir, float len)
	{
		return default(bool);
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x81B404", Offset = "0x81B404", VA = "0x81B404")]
	public void LateTick()
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x81B5A8", Offset = "0x81B5A8", VA = "0x81B5A8")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x81C444", Offset = "0x81C444", VA = "0x81C444")]
	private void HandleSlingshotRelease(PalazzoComponentBird releasedBird)
	{
	}
}
[Token(Token = "0x2000140")]
public sealed class SlingshotLoader
{
	[Token(Token = "0x2000141")]
	private enum State
	{
		[Token(Token = "0x400088E")]
		IdleEnter,
		[Token(Token = "0x400088F")]
		Idle,
		[Token(Token = "0x4000890")]
		Cooldown,
		[Token(Token = "0x4000891")]
		JumpEnter,
		[Token(Token = "0x4000892")]
		Jump,
		[Token(Token = "0x4000893")]
		JumpExit
	}

	[Token(Token = "0x4000883")]
	private const float BIRD_JUMP_COOLDOWN = 1f;

	[Token(Token = "0x4000884")]
	private const float BIRD_JUMP_STEP = 0.2f;

	[Token(Token = "0x4000885")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000886")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000887")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x4000888")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Vector3> birdBaseScale;

	[Token(Token = "0x400088A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private State state;

	[Token(Token = "0x400088B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float timeInJump;

	[Token(Token = "0x400088C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float cooldown;

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x81C5E8", Offset = "0x81C5E8", VA = "0x81C5E8")]
	public SlingshotLoader(LevelContext levelContext, PalazzoTriggers palazzoTriggers, PalazzoComponentSlingshot slingshot, InputHandler inputHandler)
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x81C690", Offset = "0x81C690", VA = "0x81C690")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000569")]
	[Address(RVA = "0x81C698", Offset = "0x81C698", VA = "0x81C698")]
	public void Tick()
	{
	}

	[Token(Token = "0x600056A")]
	[Address(RVA = "0x81CD28", Offset = "0x81CD28", VA = "0x81CD28")]
	public void OnTeleport(TeleportationData teleportationData)
	{
	}
}
[Token(Token = "0x2000142")]
public class LookAtPlayer : StateMachineBehaviour
{
	[Token(Token = "0x4000894")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string lookAtParameterName;

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x81CE98", Offset = "0x81CE98", VA = "0x81CE98", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x81CEF4", Offset = "0x81CEF4", VA = "0x81CEF4", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x81CF50", Offset = "0x81CF50", VA = "0x81CF50")]
	public LookAtPlayer()
	{
	}
}
[Token(Token = "0x2000143")]
public sealed class PigScared : StateMachineBehaviour
{
	[Token(Token = "0x4000895")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem scaredParticles;

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x81CFA0", Offset = "0x81CFA0", VA = "0x81CFA0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x81D0B4", Offset = "0x81D0B4", VA = "0x81D0B4")]
	public PigScared()
	{
	}
}
[Token(Token = "0x2000144")]
public class RandomAnimationChooser : StateMachineBehaviour
{
	[Token(Token = "0x4000896")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int numOfAvailableAnimations;

	[Token(Token = "0x4000897")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string intParameterName;

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x81D0BC", Offset = "0x81D0BC", VA = "0x81D0BC", Slot = "9")]
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x81D10C", Offset = "0x81D10C", VA = "0x81D10C")]
	public RandomAnimationChooser()
	{
	}
}
[Token(Token = "0x2000145")]
public class SetBoolTrueOnExit : StateMachineBehaviour
{
	[Token(Token = "0x4000898")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string boolParameterName;

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x81D114", Offset = "0x81D114", VA = "0x81D114", Slot = "10")]
	public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
	{
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x81D150", Offset = "0x81D150", VA = "0x81D150")]
	public SetBoolTrueOnExit()
	{
	}
}
[Token(Token = "0x2000146")]
public class TelePointHandler
{
	[Token(Token = "0x2000147")]
	private enum State
	{
		[Token(Token = "0x40008AE")]
		Init,
		[Token(Token = "0x40008AF")]
		Hidden,
		[Token(Token = "0x40008B0")]
		Show,
		[Token(Token = "0x40008B1")]
		WaitForBirdToLandInSlingshot,
		[Token(Token = "0x40008B2")]
		FadeAndTeleport
	}

	[Token(Token = "0x4000899")]
	private const float CONSIDERED_SAME_POINT_DISTANCE_THRESHOLD = 5f;

	[Token(Token = "0x400089A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x400089B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x400089C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400089D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400089E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x400089F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40008A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x40008A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly Action<TeleportationData> onTeleport;

	[Token(Token = "0x40008A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x40008A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40008A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly Vector3 originalPosition;

	[Token(Token = "0x40008A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private readonly Vector3 originalScale;

	[Token(Token = "0x40008A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float timer;

	[Token(Token = "0x40008A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private State state;

	[Token(Token = "0x40008A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private State prevState;

	[Token(Token = "0x40008A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly List<TeleportationComponent> points;

	[Token(Token = "0x40008AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private TeleportationComponent currentTeleportationPoint;

	[Token(Token = "0x40008AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private TeleportationComponent pointToTeleportTo;

	[Token(Token = "0x40008AC")]
	private const float HOVER_AMPLITUDE = 0.5f;

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x81D158", Offset = "0x81D158", VA = "0x81D158")]
	public TelePointHandler(TeleportationHandler teleportationHandler, GameStateData gameStateData, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, LevelContext levelContext, FadeHandler fadeHandler, Action<TeleportationData> onTeleport, PalazzoComponentBirdPlatform birdPlatform, LevelEditorPlayContext levelEditorPlayContext)
	{
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x81D2BC", Offset = "0x81D2BC", VA = "0x81D2BC")]
	public void Reset(bool isRestartingLevel = false)
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x81D388", Offset = "0x81D388", VA = "0x81D388")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x81E27C", Offset = "0x81E27C", VA = "0x81E27C")]
	private static bool IsConsideredSamePoint(Vector3 position1, Vector3 position2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0x81E160", Offset = "0x81E160", VA = "0x81E160")]
	private void SetCurrentPoint(TeleportationComponent point)
	{
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x81D740", Offset = "0x81D740", VA = "0x81D740")]
	private void SetClosestPointAsCurrent()
	{
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x81D9A8", Offset = "0x81D9A8", VA = "0x81D9A8")]
	private void HandlePointState(TeleportationComponent point)
	{
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0x81E2AC", Offset = "0x81E2AC", VA = "0x81E2AC")]
	private void UpdatePointVisuals(TeleportationComponent point)
	{
	}
}
[Token(Token = "0x2000148")]
public class TelePointLevelEditor : MonoBehaviour
{
	[Token(Token = "0x40008B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public new GameObject enabled;

	[Token(Token = "0x40008B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject disabled;

	[Token(Token = "0x40008B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject hover;

	[Token(Token = "0x40008B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform meshRoot;

	[Token(Token = "0x40008B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform rotatingGeo;

	[Token(Token = "0x40008B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public bool isEnabled;

	[Token(Token = "0x40008B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[HideInInspector]
	public bool isEnabledPrev;

	[Token(Token = "0x40008BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	[HideInInspector]
	public bool isHovered;

	[Token(Token = "0x40008BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public float timer;

	[Token(Token = "0x600057C")]
	[Address(RVA = "0x81E410", Offset = "0x81E410", VA = "0x81E410")]
	public TelePointLevelEditor()
	{
	}
}
[Token(Token = "0x2000149")]
public class TelePointLevelEditorHandler
{
	[Token(Token = "0x200014A")]
	private enum State
	{
		[Token(Token = "0x40008CC")]
		Init,
		[Token(Token = "0x40008CD")]
		Editing
	}

	[Token(Token = "0x40008BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40008BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x40008BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelEditorVRController vrController;

	[Token(Token = "0x40008BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x40008C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly int layerMask;

	[Token(Token = "0x40008C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly TelePointLevelEditor[] hoveredTelePoint;

	[Token(Token = "0x40008C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly RaycastHit[] hits;

	[Token(Token = "0x40008C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private TelePointLevelEditor[] telePoints;

	[Token(Token = "0x40008C4")]
	private const float ORIGINAL_HEIGHT = -3.5f;

	[Token(Token = "0x40008C5")]
	private const float HOVER_AMPLITUDE = 0.5f;

	[Token(Token = "0x40008C6")]
	private const float HOVER_FREQUENCY = 1.5625f;

	[Token(Token = "0x40008C7")]
	private const float SCALE_AMPLITUDE = 0.2f;

	[Token(Token = "0x40008C8")]
	private const float SCALE_FREQUENCY = 3.5f;

	[Token(Token = "0x40008C9")]
	private const float LERP_SPEED = 5f;

	[Token(Token = "0x40008CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private State state;

	[Token(Token = "0x600057D")]
	[Address(RVA = "0x81E418", Offset = "0x81E418", VA = "0x81E418")]
	public TelePointLevelEditorHandler(InputHandler inputHandler, TrajectoryHandler trajectoryHandler, LevelEditorContext levelEditorContext, LevelEditorVRController vrController)
	{
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0x81E550", Offset = "0x81E550", VA = "0x81E550")]
	public void Tick()
	{
	}

	[Token(Token = "0x600057F")]
	[Address(RVA = "0x81EE3C", Offset = "0x81EE3C", VA = "0x81EE3C")]
	public void Reset()
	{
	}
}
[Token(Token = "0x200014B")]
public class TeleportAimHandler
{
	[Token(Token = "0x40008CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x40008CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40008D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40008D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x40008D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x40008D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly PlayerConstraintsHandler playerConstraintsHandler;

	[Token(Token = "0x40008D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x40008D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly TensionHand tensionHand;

	[Token(Token = "0x40008D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool> onTeleportHovering;

	[Token(Token = "0x40008D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly int layerMask;

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x81EF20", Offset = "0x81EF20", VA = "0x81EF20")]
	public TeleportAimHandler(PalazzoComponentSlingshot slingshot, InputHandler inputHandler, LevelContext levelContext, TrajectoryHandler trajectoryHandler, TeleportationHandler teleportationHandler, PlayerConstraintsHandler playerConstraintsHandler, FadeHandler fadeHandler, TensionHand tensionHand, Action<bool> onTeleportHovering)
	{
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x81F034", Offset = "0x81F034", VA = "0x81F034")]
	public void Tick()
	{
	}
}
[Token(Token = "0x200014C")]
[RequireComponent(typeof(PalazzoComponentLevelBlock))]
[DisallowMultipleComponent]
public sealed class TeleportationComponent : MonoBehaviour
{
	[Token(Token = "0x40008D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PalazzoComponentLevelBlock levelBlock;

	[Token(Token = "0x40008D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject regularMarkerGeo;

	[Token(Token = "0x40008DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject arrowIconGeo;

	[Token(Token = "0x40008DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject hoverVisual;

	[Token(Token = "0x40008DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool useCustomPlacement;

	[Token(Token = "0x40008DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 birdPlatformOffset;

	[Token(Token = "0x40008DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 birdPlatformRotation;

	[Token(Token = "0x40008DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public TeleportationPointState state;

	[Token(Token = "0x40008E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TeleportationPointState prevState;

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x81F438", Offset = "0x81F438", VA = "0x81F438")]
	public TeleportationComponent()
	{
	}
}
[Token(Token = "0x200014D")]
public enum TeleportationPointState
{
	[Token(Token = "0x40008E2")]
	Idle,
	[Token(Token = "0x40008E3")]
	Hover,
	[Token(Token = "0x40008E4")]
	Current
}
[Token(Token = "0x200014E")]
public sealed class TeleportationHandler
{
	[Token(Token = "0x200014F")]
	private struct PositionData
	{
		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 playerOffset;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 forward;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 scale;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 birdPlatformPosition;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion birdPlatformRotation;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool birdPlatformActive;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3? lastActivePosition;
	}

	[Token(Token = "0x40008E5")]
	private const float CONSIDERED_SAME_POINT_DISTANCE_THRESHOLD = 5f;

	[Token(Token = "0x40008E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40008E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x40008E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x40008E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x40008EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<TeleportationData> onTeleport;

	[Token(Token = "0x40008EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 defaultBirdPlatformOffset;

	[Token(Token = "0x40008EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly Quaternion defaultBirdPlatformRotation;

	[Token(Token = "0x40008ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float timer;

	[Token(Token = "0x40008EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private PositionData nextPositionData;

	[Token(Token = "0x40008EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private readonly Vector3 playerHeight;

	[Token(Token = "0x40008F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool isTeleportingPrev;

	[Token(Token = "0x17000041")]
	public bool IsTeleporting
	{
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x81F468", Offset = "0x81F468", VA = "0x81F468")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x81F45C", Offset = "0x81F45C", VA = "0x81F45C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x81F470", Offset = "0x81F470", VA = "0x81F470")]
	public TeleportationHandler(ARTransforms arTransforms, WorldContext worldContext, FadeHandler fadeHandler, PalazzoComponentBirdPlatform birdPlatform, Action<TeleportationData> onTeleport)
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x81F528", Offset = "0x81F528", VA = "0x81F528")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x81F5A0", Offset = "0x81F5A0", VA = "0x81F5A0")]
	private void MoveToNextPositionData()
	{
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x81DEA0", Offset = "0x81DEA0", VA = "0x81DEA0")]
	public void GoToTeleportationPoint(TeleportationComponent pointToTeleportTo)
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x81F890", Offset = "0x81F890", VA = "0x81F890")]
	public void GoToSceneStartPosition(bool enableBirdPlatform = true, bool instantly = false)
	{
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x81FC08", Offset = "0x81FC08", VA = "0x81FC08")]
	public void GoToLevelEditingPosition(bool instantly = true)
	{
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x81F7A0", Offset = "0x81F7A0", VA = "0x81F7A0")]
	private void SetNextPositionData(PositionData positionData)
	{
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x81FEB4", Offset = "0x81FEB4", VA = "0x81FEB4")]
	public bool IsAtSceneStartPosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x81FFFC", Offset = "0x81FFFC", VA = "0x81FFFC")]
	public bool IsAtPreviousTeleportPosition()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000150")]
public class TeleportationData
{
	[Token(Token = "0x40008FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform previousTransform;

	[Token(Token = "0x40008FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform newTransform;

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x81E158", Offset = "0x81E158", VA = "0x81E158")]
	public TeleportationData()
	{
	}
}
[Token(Token = "0x2000151")]
public class TensionHand : MonoBehaviour
{
	[Token(Token = "0x40008FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer tensionHandMarker;

	[Token(Token = "0x40008FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer hoverHandMarker;

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x82014C", Offset = "0x82014C", VA = "0x82014C")]
	public TensionHand()
	{
	}
}
[Token(Token = "0x2000152")]
public sealed class Toolbox : MonoBehaviour
{
	[Token(Token = "0x40008FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<ToolboxButton> buttons;

	[Token(Token = "0x40008FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<ToolboxTabComponent> tabs;

	[Token(Token = "0x4000900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public BirdTabComponent birdTab;

	[Token(Token = "0x4000901")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TutorialTabComponent tutorialTab;

	[Token(Token = "0x4000902")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject blockMaterials;

	[Token(Token = "0x4000903")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Collider deletionCollider;

	[Token(Token = "0x4000904")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public VRGrabbable grabbable;

	[Token(Token = "0x4000905")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Header("Block Meter")]
	public MeshRenderer blockMeterRenderer;

	[Token(Token = "0x4000906")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material blockMeterMaterial;

	[Token(Token = "0x4000907")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ParticleEffectComponent meterMaxedFx;

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x820154", Offset = "0x820154", VA = "0x820154")]
	public Toolbox()
	{
	}
}
[Token(Token = "0x2000153")]
public sealed class ToolboxBarHandler
{
	[Token(Token = "0x4000908")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly MeshRenderer barRenderer;

	[Token(Token = "0x4000909")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x400090A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelEditorSettings levelEditorSettings;

	[Token(Token = "0x400090B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly MaterialPropertyBlock materialPropertyBlock;

	[Token(Token = "0x400090C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int fillRate;

	[Token(Token = "0x400090D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int reserveRate;

	[Token(Token = "0x400090E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly int reserveFrequency;

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x82015C", Offset = "0x82015C", VA = "0x82015C")]
	public ToolboxBarHandler(MeshRenderer barRenderer, LevelEditorContext levelEditorContext, LevelEditorSettings levelEditorSettings)
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x820264", Offset = "0x820264", VA = "0x820264")]
	public void Tick()
	{
	}
}
[Token(Token = "0x2000154")]
public enum ToolboxButtonType
{
	[Token(Token = "0x4000910")]
	Blocks,
	[Token(Token = "0x4000911")]
	Blocks_Wood,
	[Token(Token = "0x4000912")]
	Blocks_Ice,
	[Token(Token = "0x4000913")]
	Blocks_Rock,
	[Token(Token = "0x4000914")]
	Pigs,
	[Token(Token = "0x4000915")]
	Special,
	[Token(Token = "0x4000916")]
	Decoration,
	[Token(Token = "0x4000917")]
	Birds,
	[Token(Token = "0x4000918")]
	Menu,
	[Token(Token = "0x4000919")]
	TryPlay,
	[Token(Token = "0x400091A")]
	Save,
	[Token(Token = "0x400091B")]
	NewSave,
	[Token(Token = "0x400091C")]
	ManageLevels,
	[Token(Token = "0x400091D")]
	Quit,
	[Token(Token = "0x400091E")]
	Yes,
	[Token(Token = "0x400091F")]
	No,
	[Token(Token = "0x4000920")]
	EditTools,
	[Token(Token = "0x4000921")]
	ToggleTelePoints,
	[Token(Token = "0x4000922")]
	Undo,
	[Token(Token = "0x4000923")]
	Redo,
	[Token(Token = "0x4000924")]
	Clear,
	[Token(Token = "0x4000925")]
	Tutorial,
	[Token(Token = "0x4000926")]
	Next,
	[Token(Token = "0x4000927")]
	Back
}
[Token(Token = "0x2000155")]
public sealed class ToolboxButton : PhysicalButton<ToolboxButtonType>
{
	[Token(Token = "0x6000595")]
	[Address(RVA = "0x8204E4", Offset = "0x8204E4", VA = "0x8204E4")]
	public ToolboxButton()
	{
	}
}
[Token(Token = "0x2000156")]
public sealed class ToolboxHandler
{
	[Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class <ShowItems>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ToolboxHandler <>4__this;

		[Token(Token = "0x17000042")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x822558", Offset = "0x822558", VA = "0x822558", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x8225A0", Offset = "0x8225A0", VA = "0x8225A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x8220F8", Offset = "0x8220F8", VA = "0x8220F8")]
		[DebuggerHidden]
		public <ShowItems>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x822120", Offset = "0x822120", VA = "0x822120", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x822124", Offset = "0x822124", VA = "0x822124", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x822560", Offset = "0x822560", VA = "0x822560", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000928")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x4000929")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400092A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Toolbox toolbox;

	[Token(Token = "0x400092B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PhysicalButtonHandler<ToolboxButton> buttonHandler;

	[Token(Token = "0x400092C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action onTryPlay;

	[Token(Token = "0x400092D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400092E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<MenuType> openMenu;

	[Token(Token = "0x400092F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly Action<ToolboxItemComponent, VRGrab> onGrab;

	[Token(Token = "0x4000930")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action onClearLevel;

	[Token(Token = "0x4000931")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly ToolboxSettings toolboxSettings;

	[Token(Token = "0x4000932")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x4000933")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000934")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly LevelEditorSettings levelEditorSettings;

	[Token(Token = "0x4000935")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly Action undo;

	[Token(Token = "0x4000936")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly Action redo;

	[Token(Token = "0x4000937")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly ToolboxTabComponent[] tabs;

	[Token(Token = "0x4000938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly List<ToolboxButton> tabButtons;

	[Token(Token = "0x4000939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly ToolboxButton saveButton;

	[Token(Token = "0x400093A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly ToolboxButton undoButton;

	[Token(Token = "0x400093B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly ToolboxButton redoButton;

	[Token(Token = "0x400093C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly ToolboxButton clearButton;

	[Token(Token = "0x400093D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly ToolboxItemInteractionHandler[] itemInteractionHandlers;

	[Token(Token = "0x400093E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly BirdSelectionHandler birdSelectionHandler;

	[Token(Token = "0x400093F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly TutorialTabHandler tutorialTabHandler;

	[Token(Token = "0x4000940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly ToolboxBarHandler toolboxBarHandler;

	[Token(Token = "0x4000941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly TelePointLevelEditorHandler telePointHandler;

	[Token(Token = "0x4000942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private TabType activeTab;

	[Token(Token = "0x4000943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private TabType prevBlockTab;

	[Token(Token = "0x4000944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ToolboxButtonType prevButtonPress;

	[Token(Token = "0x4000945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private ToolboxButton toggleTelepointButton;

	[Token(Token = "0x4000946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly WaitForSeconds toolboxSpawnTime;

	[Token(Token = "0x4000947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly Material[][] unaffordableMats;

	[Token(Token = "0x4000948")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool isEditingTelePoints;

	[Token(Token = "0x4000949")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	private bool isEditingTelePointsPrev;

	[Token(Token = "0x400094A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
	private bool isClearConfirmation;

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x82052C", Offset = "0x82052C", VA = "0x82052C")]
	public ToolboxHandler(MonoBehaviour monoBehaviour, ARTransforms arTransforms, InputHandler inputHandler, Toolbox toolbox, LevelEditorVRController vrController, Action onTryPlay, PalazzoTriggers palazzoTriggers, Action<MenuType> openMenu, Action<ToolboxItemComponent, VRGrab> onGrab, Action onClearLevel, ToolboxSettings toolboxSettings, LevelEditorContext levelEditorContext, LevelEditorPlayContext levelEditorPlayContext, LevelEditorSettings levelEditorSettings, LevelEditorComponent levelEditor, TrajectoryHandler trajectoryHandler, Action redo, Action undo)
	{
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x820E8C", Offset = "0x820E8C", VA = "0x820E8C")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x820FEC", Offset = "0x820FEC", VA = "0x820FEC")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x8212A4", Offset = "0x8212A4", VA = "0x8212A4")]
	private void TickAffordableItems()
	{
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x8214D8", Offset = "0x8214D8", VA = "0x8214D8")]
	public void SetPositionByPlayer()
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x821614", Offset = "0x821614", VA = "0x821614")]
	private void OnButtonInteract(int buttonIndex)
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x82200C", Offset = "0x82200C", VA = "0x82200C")]
	[IteratorStateMachine(typeof(<ShowItems>d__41))]
	public IEnumerator ShowItems()
	{
		return null;
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x822074", Offset = "0x822074", VA = "0x822074")]
	private void OnItemInteract(ToolboxItemComponent item, VRGrab grab)
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x822098", Offset = "0x822098", VA = "0x822098")]
	public void SetBirds()
	{
	}
}
[Token(Token = "0x2000159")]
public sealed class ToolboxItemComponent : MonoBehaviour
{
	[Token(Token = "0x400094F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Prefab prefabReference;

	[Token(Token = "0x4000950")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Collider col;

	[Token(Token = "0x4000951")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public bool increaseSize;

	[Token(Token = "0x4000952")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public Vector3 defaultScale;

	[Token(Token = "0x4000953")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Transform child;

	[Token(Token = "0x4000954")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public bool isAfforded;

	[Token(Token = "0x4000955")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public Material[][] originalMaterials;

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x8225A8", Offset = "0x8225A8", VA = "0x8225A8")]
	public ToolboxItemComponent()
	{
	}
}
[Token(Token = "0x200015A")]
public class ToolboxItemInteractionHandler
{
	[Token(Token = "0x4000956")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000957")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly IEnumerable<ToolboxItemComponent> items;

	[Token(Token = "0x4000958")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Action<ToolboxItemComponent, VRGrab> onInteract;

	[Token(Token = "0x4000959")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action<ToolboxItemComponent, VRGrab> onDrag;

	[Token(Token = "0x400095A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<ToolboxItemComponent, VRGrab> onRelease;

	[Token(Token = "0x400095B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelEditorVRController vrController;

	[Token(Token = "0x400095C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400095D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly LevelEditorSettings levelEditorSettings;

	[Token(Token = "0x400095E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x400095F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly ToolboxItemComponent[] grabbedItems;

	[Token(Token = "0x4000960")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly ToolboxItemComponent[] highlightedItems;

	[Token(Token = "0x4000961")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly VRGrab[] grabs;

	[Token(Token = "0x4000962")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly Collider[] overlapColliders;

	[Token(Token = "0x4000963")]
	private const float GRAB_RADIUS = 0.3f;

	[Token(Token = "0x4000964")]
	private const float MAX_TIME = 1f;

	[Token(Token = "0x4000965")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float timer;

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x8225B8", Offset = "0x8225B8", VA = "0x8225B8")]
	public ToolboxItemInteractionHandler(InputHandler inputHandler, IEnumerable<ToolboxItemComponent> items, LevelEditorVRController vrController, LevelEditorSettings levelEditorSettings, LevelEditorContext levelEditorContext, Action<ToolboxItemComponent, VRGrab> onInteract, [Optional] Action<ToolboxItemComponent, VRGrab> onRelease, [Optional] Action<ToolboxItemComponent, VRGrab> onDrag)
	{
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x822BC8", Offset = "0x822BC8", VA = "0x822BC8")]
	public void Tick()
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x823690", Offset = "0x823690", VA = "0x823690")]
	public void ClearGrabbedItem(int iHand)
	{
	}

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x82360C", Offset = "0x82360C", VA = "0x82360C")]
	private void AddHighlight(ToolboxItemComponent item)
	{
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x823588", Offset = "0x823588", VA = "0x823588")]
	private void RemoveHighlight(ToolboxItemComponent item)
	{
	}
}
[Token(Token = "0x200015B")]
public enum TabType
{
	[Token(Token = "0x4000967")]
	Blocks_Wood,
	[Token(Token = "0x4000968")]
	Blocks_Rock,
	[Token(Token = "0x4000969")]
	Blocks_Ice,
	[Token(Token = "0x400096A")]
	Pigs,
	[Token(Token = "0x400096B")]
	Special,
	[Token(Token = "0x400096C")]
	Decoration,
	[Token(Token = "0x400096D")]
	Birds,
	[Token(Token = "0x400096E")]
	Menu,
	[Token(Token = "0x400096F")]
	EditTools,
	[Token(Token = "0x4000970")]
	ConfirmQuit,
	[Token(Token = "0x4000971")]
	ConfirmClear,
	[Token(Token = "0x4000972")]
	Tutorial
}
[Token(Token = "0x200015C")]
public sealed class ToolboxTabComponent : MonoBehaviour
{
	[Token(Token = "0x4000973")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TabType type;

	[Token(Token = "0x4000974")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<ToolboxItemComponent> items;

	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x8236C0", Offset = "0x8236C0", VA = "0x8236C0")]
	public ToolboxTabComponent()
	{
	}
}
[Token(Token = "0x200015D")]
public sealed class TrajectoryHandler
{
	[Token(Token = "0x4000975")]
	private const int MAX_NUMBER_TRAJECTORY_MARKERS = 16;

	[Token(Token = "0x4000976")]
	private const int MAX_NUMBER_SPECIAL_TRAJECTORY_MARKERS = 5;

	[Token(Token = "0x4000977")]
	private const float STEP_SIZE = 1.5f;

	[Token(Token = "0x4000978")]
	private const float INVERSE_STEP_SIZE = 2f / 3f;

	[Token(Token = "0x4000979")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly TrajectoryMarkerSettings settings;

	[Token(Token = "0x400097A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly MaterialPropertyBlock fadeMarkerMaterialPropertyBlock;

	[Token(Token = "0x400097B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Vector3[] trajectoryMarkerVertices;

	[Token(Token = "0x400097C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Matrix4x4[] trajectoryMarkerMatrices;

	[Token(Token = "0x400097D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Matrix4x4[] trajectorySpecialMarkerMatrices;

	[Token(Token = "0x400097E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int numberTrajectoryMarkers;

	[Token(Token = "0x400097F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool doFadeTrajectoryMarkers;

	[Token(Token = "0x4000980")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 trajectoryHitPosition;

	[Token(Token = "0x4000981")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int colorId;

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x8236C8", Offset = "0x8236C8", VA = "0x8236C8")]
	public TrajectoryHandler(TrajectoryMarkerSettings settings)
	{
	}

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x823A48", Offset = "0x823A48", VA = "0x823A48")]
	public void SetNumberTrajectoryMarkers(int newNumberTrajectoryMarkers)
	{
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x823A64", Offset = "0x823A64", VA = "0x823A64")]
	public void SetDoFadeTrajectoryMarkers(bool flag)
	{
	}

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x823A70", Offset = "0x823A70", VA = "0x823A70")]
	public Vector3 GetLatestTrajectoryHitWorldPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x823A7C", Offset = "0x823A7C", VA = "0x823A7C")]
	public bool DrawLinearTrajectoryWithSpecialMarker(Vector3 startPoint, Vector3 direction)
	{
		return default(bool);
	}

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x823EEC", Offset = "0x823EEC", VA = "0x823EEC")]
	public bool UpdateTrajectory(Vector3 worldPosition, Vector3 worldVelocity, Vector3 worldAcceleration, float dragFactor, Func<Vector3, Vector3, float, bool> evalIsIntersectingBool)
	{
		return default(bool);
	}

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x8245B8", Offset = "0x8245B8", VA = "0x8245B8")]
	public bool UpdateLinearTrajectory(Vector3 startPoint, Vector3 direction, float maxDistance, Func<Vector3, Vector3, float, (bool, float)> evalIsIntersecting)
	{
		return default(bool);
	}
}
[Token(Token = "0x200015E")]
[DisallowMultipleComponent]
public class TutorialComponent : MonoBehaviour
{
	[Token(Token = "0x4000982")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_Text tutorialTextComponent;

	[Token(Token = "0x4000983")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LocalizedText tutorialLocalizedText;

	[Token(Token = "0x4000984")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MeshRenderer board;

	[Token(Token = "0x4000985")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SpriteRenderer character;

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x824884", Offset = "0x824884", VA = "0x824884")]
	public TutorialComponent()
	{
	}
}
[Token(Token = "0x200015F")]
public enum TutorialType
{
	[Token(Token = "0x4000987")]
	Gameplay,
	[Token(Token = "0x4000988")]
	Introduction,
	[Token(Token = "0x4000989")]
	Teleportation,
	[Token(Token = "0x400098A")]
	Chuck,
	[Token(Token = "0x400098B")]
	Blues,
	[Token(Token = "0x400098C")]
	Bomb
}
[Token(Token = "0x2000160")]
public sealed class TutorialHandler
{
	[Token(Token = "0x2000161")]
	private enum State
	{
		[Token(Token = "0x40009B0")]
		Hide,
		[Token(Token = "0x40009B1")]
		Show
	}

	[Token(Token = "0x400098D")]
	private const float SCALE_THRESHOLD = 0.01f;

	[Token(Token = "0x400098E")]
	private const float SCALE_SPEED = 10f;

	[Token(Token = "0x400098F")]
	private const float FOLLOW_SPEED = 30f;

	[Token(Token = "0x4000990")]
	private const float TOO_CLOSE_TO_HEAD = 2f;

	[Token(Token = "0x4000991")]
	private const float TRIGGER_DISTANCE_TO_LEVEL = 30f;

	[Token(Token = "0x4000992")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly float stringTensionThreshold;

	[Token(Token = "0x4000993")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly TutorialComponent tutorial;

	[Token(Token = "0x4000994")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Transform tutorialPlacement;

	[Token(Token = "0x4000995")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000996")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000997")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000998")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x4000999")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly string[][] tutorialStringIds;

	[Token(Token = "0x400099A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly TutorialSettings tutorialSettings;

	[Token(Token = "0x400099B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TutorialType tutorialType;

	[Token(Token = "0x400099C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timeWithoutAction;

	[Token(Token = "0x400099D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float timeToTutorial;

	[Token(Token = "0x400099E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool specialAbilityTutorialTriggered;

	[Token(Token = "0x400099F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private State state;

	[Token(Token = "0x40009A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private State prevState;

	[Token(Token = "0x40009A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private BirdFlightState prevBirdState;

	[Token(Token = "0x40009A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool prevEnoughForceState;

	[Token(Token = "0x40009A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int teleportCounter;

	[Token(Token = "0x40009A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int prevTeleportCounter;

	[Token(Token = "0x40009A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool hasTutorialShown;

	[Token(Token = "0x40009A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool hide;

	[Token(Token = "0x40009A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private PalazzoComponentBird targetBird;

	[Token(Token = "0x40009A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 targetScale;

	[Token(Token = "0x40009A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float targetAlpha;

	[Token(Token = "0x40009AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float targetTimeScale;

	[Token(Token = "0x40009AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private string targetLine;

	[Token(Token = "0x40009AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool teleportHovering;

	[Token(Token = "0x40009AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
	private bool prevTeleportHovering;

	[Token(Token = "0x40009AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
	private bool prevIsRubberInRange;

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x82488C", Offset = "0x82488C", VA = "0x82488C")]
	public TutorialHandler(TutorialComponent tutorial, Transform tutorialPlacement, InputHandler inputHandler, LevelContext levelContext, PalazzoTriggers palazzoTriggers, PalazzoComponentSlingshot slingshot, SlingshotSettings slingshotSettings, TutorialSettings tutorialSettings)
	{
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x824F28", Offset = "0x824F28", VA = "0x824F28")]
	public void Reset()
	{
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x8251DC", Offset = "0x8251DC", VA = "0x8251DC")]
	public void Tick()
	{
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x8254E8", Offset = "0x8254E8", VA = "0x8254E8")]
	private void ShowTutorial()
	{
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x825294", Offset = "0x825294", VA = "0x825294")]
	private void HideTutorial()
	{
	}

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x825EB8", Offset = "0x825EB8", VA = "0x825EB8")]
	public void ToggleTutorial(bool shouldHide)
	{
	}

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x825EF8", Offset = "0x825EF8", VA = "0x825EF8")]
	public void OnTeleportHovering(bool hovering)
	{
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x825F04", Offset = "0x825F04", VA = "0x825F04")]
	public void OnTeleport()
	{
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x825C78", Offset = "0x825C78", VA = "0x825C78")]
	private void UpdateTutorialText()
	{
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x825E0C", Offset = "0x825E0C", VA = "0x825E0C")]
	private PalazzoComponentBird GetActiveBird()
	{
		return null;
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x8258B4", Offset = "0x8258B4", VA = "0x8258B4")]
	private void Lerp()
	{
	}
}
[Token(Token = "0x2000162")]
public class TutorialTabComponent : MonoBehaviour
{
	[Token(Token = "0x40009B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> pages;

	[Token(Token = "0x40009B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<SlideIndicator> slideIndicators;

	[Token(Token = "0x40009B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject backButton;

	[Token(Token = "0x40009B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject nextButton;

	[Token(Token = "0x40009B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("Controls")]
	public int controlsIndex;

	[Token(Token = "0x40009B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject riftControls;

	[Token(Token = "0x40009B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject viveControls;

	[Token(Token = "0x40009B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject moveControls;

	[Token(Token = "0x40009BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject questControls;

	[Token(Token = "0x40009BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject riftSControls;

	[Token(Token = "0x40009BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject cosmosControls;

	[Token(Token = "0x40009BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject indexControls;

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x825F14", Offset = "0x825F14", VA = "0x825F14")]
	public TutorialTabComponent()
	{
	}
}
[Token(Token = "0x2000163")]
public class TutorialTabHandler
{
	[Token(Token = "0x40009BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly TutorialTabComponent tutorialTab;

	[Token(Token = "0x40009BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentPageId;

	[Token(Token = "0x40009C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<GameObject> pages;

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x825F1C", Offset = "0x825F1C", VA = "0x825F1C")]
	public TutorialTabHandler(TutorialTabComponent tutorialTab)
	{
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x826120", Offset = "0x826120", VA = "0x826120")]
	public void Next()
	{
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x8262F4", Offset = "0x8262F4", VA = "0x8262F4")]
	public void Back()
	{
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x8264C0", Offset = "0x8264C0", VA = "0x8264C0")]
	public void OpenPigInfo()
	{
	}
}
[Token(Token = "0x2000164")]
public sealed class AnimationComponent : MonoBehaviour
{
	[Token(Token = "0x40009C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform animationRoot;

	[Token(Token = "0x40009C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator animator;

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x82668C", Offset = "0x82668C", VA = "0x82668C")]
	public AnimationComponent()
	{
	}
}
[Token(Token = "0x2000165")]
public sealed class BuildLevelsMenu : SplitMenu
{
	[Token(Token = "0x40009C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject unshareButton;

	[Token(Token = "0x40009C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("spinningWheelButton")]
	public GameObject unshareSpinningWheelButton;

	[Token(Token = "0x40009C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("spinningWheel")]
	public GameObject unshareSpinningWheel;

	[Token(Token = "0x40009C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject shareButton;

	[Token(Token = "0x40009C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("spinningWheelButton")]
	public GameObject shareSpinningWheelButton;

	[Token(Token = "0x40009C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[FormerlySerializedAs("spinningWheel")]
	public GameObject shareSpinningWheel;

	[Token(Token = "0x40009C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public LevelGridButton[] unusedLevelSlots;

	[Token(Token = "0x40009CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshPro levelCodeText;

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x826694", Offset = "0x826694", VA = "0x826694")]
	public BuildLevelsMenu()
	{
	}
}
[Token(Token = "0x2000166")]
public enum BuildLevelsMenuButtonType
{
	[Token(Token = "0x40009CC")]
	Yes,
	[Token(Token = "0x40009CD")]
	No,
	[Token(Token = "0x40009CE")]
	SelectSlot,
	[Token(Token = "0x40009CF")]
	EditLevel,
	[Token(Token = "0x40009D0")]
	DeleteLevel,
	[Token(Token = "0x40009D1")]
	SaveLevel,
	[Token(Token = "0x40009D2")]
	TryLevel,
	[Token(Token = "0x40009D3")]
	CloseMenu,
	[Token(Token = "0x40009D4")]
	UploadLevel,
	[Token(Token = "0x40009D5")]
	NextSlide,
	[Token(Token = "0x40009D6")]
	PreviousSlide,
	[Token(Token = "0x40009D7")]
	FavoriteLevel,
	[Token(Token = "0x40009D8")]
	Duplicate,
	[Token(Token = "0x40009D9")]
	Cancel,
	[Token(Token = "0x40009DA")]
	Disabled,
	[Token(Token = "0x40009DB")]
	Overwrite,
	[Token(Token = "0x40009DC")]
	Delete,
	[Token(Token = "0x40009DD")]
	BuildNewLevel,
	[Token(Token = "0x40009DE")]
	NoConfirmation
}
[Token(Token = "0x2000167")]
public class BuildLevelsMenuButton : PalazzoButton<BuildLevelsMenuButtonType>
{
	[Token(Token = "0x40009DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[Header("Save Slot Options")]
	public GameObject optionalEmptySlotGeo;

	[Token(Token = "0x40009E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject optionalSavedSlotGeo;

	[Token(Token = "0x40009E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject optionalSaveIndicator;

	[Token(Token = "0x40009E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject optionalFinishedIndicator;

	[Token(Token = "0x40009E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject optionalSelectedIndicator;

	[NonSerialized]
	[Token(Token = "0x40009E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool slotTaken;

	[NonSerialized]
	[Token(Token = "0x40009E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public int slideIndex;

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x82669C", Offset = "0x82669C", VA = "0x82669C")]
	public BuildLevelsMenuButton()
	{
	}
}
[Token(Token = "0x2000168")]
public class BuildLevelsMenuHandler : SplitMenuHandler
{
	[Token(Token = "0x40009E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly LevelBuildingHandler levelBuildingHandler;

	[Token(Token = "0x40009E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x40009E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40009E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x40009EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly BuildLevelsMenu buildLevelsMenu;

	[Token(Token = "0x40009EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40009EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x40009ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly Action<MenuType> setMenuType;

	[Token(Token = "0x40009EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly ButtonHandler<LevelGridButton> unusedLevelSlotsButtonHandler;

	[Token(Token = "0x40009EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool isDuplicating;

	[Token(Token = "0x40009F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private uint duplicateIndex;

	[Token(Token = "0x40009F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private uint unshareIndex;

	[Token(Token = "0x40009F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private uint prevSelectedButtonIndex;

	[Token(Token = "0x40009F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Future<bool> unshareFuture;

	[Token(Token = "0x40009F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool firstEnter;

	[Token(Token = "0x40009F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
	private bool justEnteredMenu;

	[Token(Token = "0x40009F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x122")]
	private bool isUnsharing;

	[Token(Token = "0x40009F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x123")]
	private bool isVerifyingLevelUploadable;

	[Token(Token = "0x40009F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private bool isVerifyingLevelUploadablePrev;

	[Token(Token = "0x40009F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
	private bool newSave;

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x8266E4", Offset = "0x8266E4", VA = "0x8266E4")]
	public BuildLevelsMenuHandler(LevelBuildingHandler levelBuildingHandler, LevelEditorContext levelEditorContext, LevelEditorPlayContext levelEditorPlayContext, Action<LevelEditorStateType> setState, NetworkHandler networkHandler, SplitMenu splitMenu, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, InputHandler inputHandler, LevelContext levelContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelParent, Action<MenuType> setMenuType)
	{
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x826A24", Offset = "0x826A24", VA = "0x826A24", Slot = "9")]
	public override void Tick()
	{
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x827198", Offset = "0x827198", VA = "0x827198", Slot = "12")]
	protected override void OnSideMenuButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x8276EC", Offset = "0x8276EC", VA = "0x8276EC")]
	private void ToggleButton(SideMenuButton button, bool active)
	{
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x827764", Offset = "0x827764", VA = "0x827764", Slot = "10")]
	protected override void OnGridMenuButtonClick(int buttonIndex)
	{
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x826F7C", Offset = "0x826F7C", VA = "0x826F7C")]
	private void SelectLevel()
	{
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x827820", Offset = "0x827820", VA = "0x827820", Slot = "13")]
	protected override void UpdateLevelSlotButtons()
	{
	}

	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x827B18", Offset = "0x827B18", VA = "0x827B18", Slot = "7")]
	public override void Show()
	{
	}
}
[Serializable]
[Token(Token = "0x200016A")]
public sealed class ButtonSettings
{
	[Token(Token = "0x40009FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("buttonAnimPrefab")]
	public AnimationComponent animPrefab;

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x827C20", Offset = "0x827C20", VA = "0x827C20")]
	public ButtonSettings()
	{
	}
}
[Token(Token = "0x200016B")]
public sealed class ButtonHandler<TBUTTON> where TBUTTON : PalazzoButton
{
	[Token(Token = "0x40009FE")]
	private const float REGISTER_SELECTED_MIN_SQR_DISTANCE = 0.36f;

	[Token(Token = "0x40009FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000A00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000A01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x4000A02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly IList<TBUTTON> buttons;

	[Token(Token = "0x4000A03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Action<int> onClick;

	[Token(Token = "0x4000A04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Action<int> onHover;

	[Token(Token = "0x4000A05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Action<int> onRelease;

	[Token(Token = "0x4000A06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000A07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int minDistanceIndex;

	[Token(Token = "0x4000A08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool scoreboardIsPlaying;

	[Token(Token = "0x4000A09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool skipScoreboard;

	[Token(Token = "0x4000A0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int uiLayerMask;

	[Token(Token = "0x4000A0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int buttonLayerMask;

	[Token(Token = "0x4000A0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int hooverAnimId;

	[Token(Token = "0x4000A0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly RaycastHit[] hits;

	[Token(Token = "0x17000044")]
	public bool ScoreboardIsPlaying
	{
		[Token(Token = "0x60005D7")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public bool SkipScoreboard
	{
		[Token(Token = "0x60005D8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005D9")]
		set
		{
		}
	}

	[Token(Token = "0x60005DA")]
	public ButtonHandler(InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, IList<TBUTTON> buttons, Action<int> onClick, [Optional] Action<int> onHover, [Optional] Action<int> onRelease, [Optional] NetworkHandler networkHandler, [Optional] ButtonSettings buttonSettings)
	{
	}

	[Token(Token = "0x60005DB")]
	private (bool, float) IsIntersectingTrajectory(Vector3 pos, Vector3 dir, float len)
	{
		return default((bool, float));
	}

	[Token(Token = "0x60005DC")]
	public void ResetButtons()
	{
	}

	[Token(Token = "0x60005DD")]
	private static Vector3 CalcClosestPointOnLine(Vector3 vA, Vector3 vB, Vector3 vPoint)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60005DE")]
	public void DisableButtons()
	{
	}

	[Token(Token = "0x60005DF")]
	public void TickButtons()
	{
	}

	[Token(Token = "0x60005E0")]
	private static void UpdateButtonVisuals(PalazzoButton button)
	{
	}

	[Token(Token = "0x60005E1")]
	private static void UpdateButtonPosition(PalazzoButton button)
	{
	}
}
[Token(Token = "0x200016D")]
public sealed class ConnectionIndicator : MonoBehaviour
{
	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x827C28", Offset = "0x827C28", VA = "0x827C28")]
	public ConnectionIndicator()
	{
	}
}
[Token(Token = "0x200016E")]
public class CreateUserMenuHandler : IMenuHandler
{
	[Token(Token = "0x200016F")]
	private enum State
	{
		[Token(Token = "0x4000A22")]
		Generating,
		[Token(Token = "0x4000A23")]
		ProposeName
	}

	[Token(Token = "0x4000A11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000A12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly UiMenuHandlerBase<CreateUserMenuButton, CreateUserMenuButtonType> menuHandler;

	[Token(Token = "0x4000A13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly CreateUserMenu menu;

	[Token(Token = "0x4000A14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x4000A15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<MenuType> setMenuType;

	[Token(Token = "0x4000A16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000A17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly CreateUserSettings createUserSettings;

	[Token(Token = "0x4000A18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Future<string[]> generateUsernamesFuture;

	[Token(Token = "0x4000A19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000A1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly SlotMachineHandler slotMachineHandler;

	[Token(Token = "0x4000A1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private State state;

	[Token(Token = "0x4000A1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private State prevState;

	[Token(Token = "0x4000A1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int nameSuggestionIndex;

	[Token(Token = "0x4000A1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private CreateUserMenuButton createButton;

	[Token(Token = "0x4000A1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string[] generatedNames;

	[Token(Token = "0x4000A20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool generationDone;

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x827C30", Offset = "0x827C30", VA = "0x827C30")]
	public CreateUserMenuHandler(NetworkHandler networkHandler, Action<MenuType> setMenuType, Action<LevelEditorStateType> setState, UiMenuBase<CreateUserMenuButton, CreateUserMenuButtonType> menu, ARTransforms arTransforms, InputHandler inputHandler, WorldContext worldContext, MenuSettings menuSettings, TrajectoryHandler trajectoryHandler, PalazzoTriggers palazzoTriggers, LevelEditorPlayContext levelEditorPlayContext, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x827EAC", Offset = "0x827EAC", VA = "0x827EAC")]
	private void OnButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x8282D8", Offset = "0x8282D8", VA = "0x8282D8", Slot = "6")]
	public void Tick()
	{
	}

	[Token(Token = "0x60005EA")]
	[Address(RVA = "0x82867C", Offset = "0x82867C", VA = "0x82867C", Slot = "5")]
	public void Hide()
	{
	}

	[Token(Token = "0x60005EB")]
	[Address(RVA = "0x8286E0", Offset = "0x8286E0", VA = "0x8286E0", Slot = "4")]
	public void Show()
	{
	}
}
[Token(Token = "0x2000170")]
public class DifficultyGauge : MonoBehaviour
{
	[Token(Token = "0x4000A24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float maxRotation;

	[Token(Token = "0x4000A25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float animationTime;

	[Token(Token = "0x4000A26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject pointer;

	[Token(Token = "0x60005EC")]
	[Address(RVA = "0x828744", Offset = "0x828744", VA = "0x828744")]
	public DifficultyGauge()
	{
	}
}
[Token(Token = "0x2000171")]
public class DifficultyGaugeHandler
{
	[Token(Token = "0x4000A27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly DifficultyGauge difficultyGauge;

	[Token(Token = "0x4000A28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float currentDifficulty;

	[Token(Token = "0x4000A29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float animationStartTime;

	[Token(Token = "0x4000A2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float animationStartingDifficulty;

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x82874C", Offset = "0x82874C", VA = "0x82874C")]
	public DifficultyGaugeHandler(DifficultyGauge difficultyGauge)
	{
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x828774", Offset = "0x828774", VA = "0x828774")]
	public void Tick()
	{
	}

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x828880", Offset = "0x828880", VA = "0x828880")]
	public void SetDifficulty(float difficulty)
	{
	}
}
[Token(Token = "0x2000172")]
public sealed class DiscoveryMenu : OnlineSplitMenu
{
	[Token(Token = "0x4000A2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject searchLayout;

	[Token(Token = "0x4000A2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Keypad keypad;

	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x8288B0", Offset = "0x8288B0", VA = "0x8288B0")]
	public DiscoveryMenu()
	{
	}
}
[Token(Token = "0x2000173")]
public sealed class DiscoveryMenuHandler : OnlineSplitMenuHandler
{
	[Token(Token = "0x2000174")]
	private enum SearchState
	{
		[Token(Token = "0x4000A3D")]
		EnterCode,
		[Token(Token = "0x4000A3E")]
		NotFound,
		[Token(Token = "0x4000A3F")]
		Searching,
		[Token(Token = "0x4000A40")]
		PresentInfo
	}

	[Token(Token = "0x4000A2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000A2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000A2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x4000A30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly DiscoveryMenu discoveryMenu;

	[Token(Token = "0x4000A31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly Keypad keypad;

	[Token(Token = "0x4000A32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private readonly ButtonHandler<KeypadButton> keypadButtonHandler;

	[Token(Token = "0x4000A33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000A34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private SearchState searchState;

	[Token(Token = "0x4000A35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private SearchState prevSearchState;

	[Token(Token = "0x4000A36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private Future<ServerLevelMetaData> levelFuture;

	[Token(Token = "0x4000A37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private bool isEraseButtonPressed;

	[Token(Token = "0x4000A38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private float erasePressedTimer;

	[Token(Token = "0x4000A39")]
	private const float ERASE_NEXT_CHARACTER_TIME = 0.2f;

	[Token(Token = "0x4000A3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private int numberOfErasedCharactersDuringPress;

	[Token(Token = "0x4000A3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private KeypadButton eraseButton;

	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x8288C0", Offset = "0x8288C0", VA = "0x8288C0")]
	public DiscoveryMenuHandler(LevelEditorPlayContext levelEditorPlayContext, NetworkHandler networkHandler, Action<LevelEditorStateType> setState, Action<MenuType> setMenuType, SplitMenu splitMenu, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, InputHandler inputHandler, LevelContext levelContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelParent, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x829160", Offset = "0x829160", VA = "0x829160", Slot = "7")]
	public override void Show()
	{
	}

	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x829718", Offset = "0x829718", VA = "0x829718", Slot = "9")]
	public override void Tick()
	{
	}

	[Token(Token = "0x60005F4")]
	[Address(RVA = "0x82AABC", Offset = "0x82AABC", VA = "0x82AABC", Slot = "10")]
	protected override void OnGridMenuButtonClick(int buttonIndex)
	{
	}

	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x82B03C", Offset = "0x82B03C", VA = "0x82B03C", Slot = "12")]
	protected override void OnSideMenuButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x82B3E0", Offset = "0x82B3E0", VA = "0x82B3E0")]
	private void OnKeypadClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x82B7B8", Offset = "0x82B7B8", VA = "0x82B7B8")]
	private void OnKeypadRelease(int buttonIndex)
	{
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x82A8B0", Offset = "0x82A8B0", VA = "0x82A8B0")]
	private void EraseInputCharacter(PalazzoButton button)
	{
	}

	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x82B5C0", Offset = "0x82B5C0", VA = "0x82B5C0")]
	private void AddNumberToInputText(int number, PalazzoButton button)
	{
	}

	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x82A7FC", Offset = "0x82A7FC", VA = "0x82A7FC")]
	private static bool IsCodeValid(string code)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000176")]
public enum ErrorType
{
	[Token(Token = "0x4000A44")]
	Network,
	[Token(Token = "0x4000A45")]
	Favoriting
}
[Token(Token = "0x2000177")]
public sealed class ErrorMenu : UiMenuBase<ErrorMenuButton, ErrorMenuButtonType>
{
	[Token(Token = "0x4000A46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject networkErrorText;

	[Token(Token = "0x4000A47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject favoritingErrorText;

	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x82B874", Offset = "0x82B874", VA = "0x82B874")]
	public ErrorMenu()
	{
	}
}
[Token(Token = "0x2000178")]
public enum ErrorMenuButtonType
{
	[Token(Token = "0x4000A49")]
	OK
}
[Token(Token = "0x2000179")]
public sealed class ErrorMenuButton : PalazzoButton<ErrorMenuButtonType>
{
	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x82B8BC", Offset = "0x82B8BC", VA = "0x82B8BC")]
	public ErrorMenuButton()
	{
	}
}
[Token(Token = "0x200017A")]
public class FavoriteLevelsMenu : SplitMenu
{
	[Token(Token = "0x4000A4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject levelsLayout;

	[Token(Token = "0x4000A4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject loadingLayout;

	[Token(Token = "0x6000600")]
	[Address(RVA = "0x82B904", Offset = "0x82B904", VA = "0x82B904")]
	public FavoriteLevelsMenu()
	{
	}
}
[Token(Token = "0x200017B")]
public class FavoriteLevelsMenuHandler : SplitMenuHandler
{
	[Token(Token = "0x4000A4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x4000A4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly Action<MenuType> setMenuType;

	[Token(Token = "0x4000A4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000A4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000A50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly FavoriteLevelsMenu favoriteLevelsMenu;

	[Token(Token = "0x4000A51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly OnlineSideMenu onlineSideMenu;

	[Token(Token = "0x4000A52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly CreateUserSettings createUserSettings;

	[Token(Token = "0x4000A53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private ServerLevelMetaData[] favoriteLevels;

	[Token(Token = "0x4000A54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int selectedButtonIndex;

	[Token(Token = "0x4000A55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private LevelListContext favoriteLevelsContext;

	[Token(Token = "0x4000A56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Future<ServerLevelMetaData[]> updateMetaDataFuture;

	[Token(Token = "0x4000A57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private bool processingRequest;

	[Token(Token = "0x4000A58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Future<User> getUserDataFuture;

	[Token(Token = "0x4000A59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private DifficultyGaugeHandler difficultyGaugeHandler;

	[Token(Token = "0x4000A5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private uint prevSelectedLevelId;

	[Token(Token = "0x4000A5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private bool justEnteredMenu;

	[Token(Token = "0x6000601")]
	[Address(RVA = "0x82B90C", Offset = "0x82B90C", VA = "0x82B90C")]
	public FavoriteLevelsMenuHandler(LevelEditorPlayContext levelEditorPlayContext, Action<LevelEditorStateType> setState, Action<MenuType> setMenuType, SplitMenu splitMenu, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, InputHandler inputHandler, LevelContext levelContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelParent, NetworkHandler networkHandler, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x6000602")]
	[Address(RVA = "0x82BB64", Offset = "0x82BB64", VA = "0x82BB64", Slot = "7")]
	public override void Show()
	{
	}

	[Token(Token = "0x6000603")]
	[Address(RVA = "0x82BDC4", Offset = "0x82BDC4", VA = "0x82BDC4", Slot = "9")]
	public override void Tick()
	{
	}

	[Token(Token = "0x6000604")]
	[Address(RVA = "0x82C314", Offset = "0x82C314", VA = "0x82C314", Slot = "10")]
	protected override void OnGridMenuButtonClick(int buttonIndex)
	{
	}

	[Token(Token = "0x6000605")]
	[Address(RVA = "0x82C85C", Offset = "0x82C85C", VA = "0x82C85C", Slot = "12")]
	protected override void OnSideMenuButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0x82CC50", Offset = "0x82CC50", VA = "0x82CC50", Slot = "13")]
	protected override void UpdateLevelSlotButtons()
	{
	}

	[Token(Token = "0x6000607")]
	[Address(RVA = "0x82BD50", Offset = "0x82BD50", VA = "0x82BD50")]
	private void LoadFavoriteLevels()
	{
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0x82C490", Offset = "0x82C490", VA = "0x82C490")]
	protected void PopulateStats(ServerLevelMetaData data)
	{
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0x82C194", Offset = "0x82C194", VA = "0x82C194")]
	private void PopulateUser(User user)
	{
	}
}
[Token(Token = "0x200017D")]
public interface IMenuHandler
{
	[Token(Token = "0x600060D")]
	void Show();

	[Token(Token = "0x600060E")]
	void Hide();

	[Token(Token = "0x600060F")]
	void Tick();
}
[Token(Token = "0x200017E")]
public class Keypad : MonoBehaviour
{
	[Token(Token = "0x4000A5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshPro inputText;

	[Token(Token = "0x4000A5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public KeypadButton[] buttons;

	[Token(Token = "0x4000A60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color redColor;

	[Token(Token = "0x4000A61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color defaultColor;

	[Token(Token = "0x6000610")]
	[Address(RVA = "0x82CDC4", Offset = "0x82CDC4", VA = "0x82CDC4")]
	public Keypad()
	{
	}
}
[Token(Token = "0x200017F")]
public enum KeypadButtonType
{
	[Token(Token = "0x4000A63")]
	Key0,
	[Token(Token = "0x4000A64")]
	Key1,
	[Token(Token = "0x4000A65")]
	Key2,
	[Token(Token = "0x4000A66")]
	Key3,
	[Token(Token = "0x4000A67")]
	Key4,
	[Token(Token = "0x4000A68")]
	Key5,
	[Token(Token = "0x4000A69")]
	Key6,
	[Token(Token = "0x4000A6A")]
	Key7,
	[Token(Token = "0x4000A6B")]
	Key8,
	[Token(Token = "0x4000A6C")]
	Key9,
	[Token(Token = "0x4000A6D")]
	Erase,
	[Token(Token = "0x4000A6E")]
	Search
}
[Token(Token = "0x2000180")]
public class KeypadButton : PalazzoButton<KeypadButtonType>
{
	[Token(Token = "0x6000611")]
	[Address(RVA = "0x82CDCC", Offset = "0x82CDCC", VA = "0x82CDCC")]
	public KeypadButton()
	{
	}
}
[Token(Token = "0x2000181")]
[DisallowMultipleComponent]
public class LevelEditorMenu : MonoBehaviour
{
	[Token(Token = "0x4000A6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] menuRoots;

	[Token(Token = "0x4000A70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject levelSelectedMenuRoot;

	[Token(Token = "0x4000A71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject levelUploadedMenuRoot;

	[Token(Token = "0x4000A72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject createLevelMenuRoot;

	[Token(Token = "0x4000A73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject deleteLevelMenuRoot;

	[Token(Token = "0x4000A74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject saveLevelMenuRoot;

	[Token(Token = "0x4000A75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject confirmOverwriteMenuRoot;

	[Token(Token = "0x4000A76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject previousSlideButton;

	[Token(Token = "0x4000A77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject nextSlideButton;

	[Token(Token = "0x4000A78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject instructionText;

	[Token(Token = "0x4000A79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject sideMenuTitleText;

	[Token(Token = "0x4000A7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject[] favoriteButtonTypes;

	[Token(Token = "0x4000A7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshPro titleText;

	[Token(Token = "0x4000A7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public LocalizedText localizedTitleText;

	[Token(Token = "0x4000A7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<LevelEditorMenuButton> levelEditorMenuButtons;

	[Token(Token = "0x4000A7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<GameObject> levelSlideMenus;

	[Token(Token = "0x4000A7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<SlideIndicator> slideIndicators;

	[NonSerialized]
	[Token(Token = "0x4000A80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<LevelEditorMenuButton> saveSlotButtons;

	[NonSerialized]
	[Token(Token = "0x4000A81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public uint saveIndex;

	[NonSerialized]
	[Token(Token = "0x4000A82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public LevelEditorMenuButton selectedButton;

	[NonSerialized]
	[Token(Token = "0x4000A83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public int nbrOfSlides;

	[Token(Token = "0x6000612")]
	[Address(RVA = "0x82CE14", Offset = "0x82CE14", VA = "0x82CE14")]
	public LevelEditorMenu()
	{
	}
}
[Token(Token = "0x2000182")]
public enum LevelEditorMenuButtonType
{
	[Token(Token = "0x4000A85")]
	Yes,
	[Token(Token = "0x4000A86")]
	No,
	[Token(Token = "0x4000A87")]
	SelectSlot,
	[Token(Token = "0x4000A88")]
	EditLevel,
	[Token(Token = "0x4000A89")]
	DeleteLevel,
	[Token(Token = "0x4000A8A")]
	SaveLevel,
	[Token(Token = "0x4000A8B")]
	TryLevel,
	[Token(Token = "0x4000A8C")]
	CloseMenu,
	[Token(Token = "0x4000A8D")]
	UploadLevel,
	[Token(Token = "0x4000A8E")]
	NextSlide,
	[Token(Token = "0x4000A8F")]
	PreviousSlide,
	[Token(Token = "0x4000A90")]
	FavoriteLevel,
	[Token(Token = "0x4000A91")]
	Duplicate,
	[Token(Token = "0x4000A92")]
	Cancel,
	[Token(Token = "0x4000A93")]
	Disabled
}
[Token(Token = "0x2000183")]
public enum FromConfirmationMenu
{
	[Token(Token = "0x4000A95")]
	Overwrite,
	[Token(Token = "0x4000A96")]
	Delete,
	[Token(Token = "0x4000A97")]
	BuildNewLevel,
	[Token(Token = "0x4000A98")]
	NoConfirmation
}
[Token(Token = "0x2000184")]
public sealed class LevelEditorMenuButton : PalazzoButton<LevelEditorMenuButtonType>
{
	[Token(Token = "0x4000A99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public FromConfirmationMenu fromConfirmationMenu;

	[Token(Token = "0x4000A9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[Header("Save Slot Options")]
	public GameObject optionalEmptySlotGeo;

	[Token(Token = "0x4000A9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject optionalSavedSlotGeo;

	[Token(Token = "0x4000A9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject optionalSaveIndicator;

	[Token(Token = "0x4000A9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject optionalFinishedIndicator;

	[Token(Token = "0x4000A9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject optionalSelectedIndicator;

	[NonSerialized]
	[Token(Token = "0x4000A9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public bool slotTaken;

	[NonSerialized]
	[Token(Token = "0x4000AA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public int slideIndex;

	[Token(Token = "0x6000613")]
	[Address(RVA = "0x82CE98", Offset = "0x82CE98", VA = "0x82CE98")]
	public LevelEditorMenuButton()
	{
	}
}
[Token(Token = "0x2000185")]
public class LevelEditorScoreboard : ScoreboardBase
{
	[Token(Token = "0x4000AA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject winScreen;

	[Token(Token = "0x4000AA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject levelUploadedScreen;

	[Token(Token = "0x4000AA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject loadingScreen;

	[Token(Token = "0x4000AA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject spinningWheel;

	[Token(Token = "0x4000AA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject optionalConfetti;

	[Token(Token = "0x4000AA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TMP_Text optionalUsernameText;

	[Token(Token = "0x4000AA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TMP_Text optionalUsernameHoverText;

	[Token(Token = "0x4000AA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TMP_Text optionalLevelCodeText;

	[Token(Token = "0x4000AA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public SpriteRenderer optionalUserImage;

	[Token(Token = "0x4000AAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public LoadingDots optionalLoadingDots;

	[Token(Token = "0x4000AAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ConnectionIndicator connectionIndicator;

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x82CEE0", Offset = "0x82CEE0", VA = "0x82CEE0")]
	public LevelEditorScoreboard()
	{
	}
}
[Token(Token = "0x2000186")]
public sealed class LevelEditorScoreboardHandler : PlayMenuHandlerBase
{
	[Token(Token = "0x2000187")]
	private enum ScoreboardState
	{
		[Token(Token = "0x4000ABE")]
		Init,
		[Token(Token = "0x4000ABF")]
		WaitForInput,
		[Token(Token = "0x4000AC0")]
		TransitionToMenu,
		[Token(Token = "0x4000AC1")]
		IsProcessingUpload
	}

	[Token(Token = "0x4000AAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000AAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly LevelEditorScoreboard scoreboard;

	[Token(Token = "0x4000AAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x4000AAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen;

	[Token(Token = "0x4000AB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000AB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000AB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000AB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly CreateUserSettings createUserSettings;

	[Token(Token = "0x4000AB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private new ScoreboardState state;

	[Token(Token = "0x4000AB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private new ScoreboardState prevState;

	[Token(Token = "0x4000AB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameState nextGameState;

	[Token(Token = "0x4000AB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool handleNetworkResponse;

	[Token(Token = "0x4000AB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private PalazzoButton nextButton;

	[Token(Token = "0x4000AB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Future<string> uploadFuture;

	[Token(Token = "0x4000ABA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Future<ServerLevelMetaData> quickplayLevelFuture;

	[Token(Token = "0x4000ABB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Future<User> getUserDataFuture;

	[Token(Token = "0x4000ABC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private User user;

	[Token(Token = "0x6000615")]
	[Address(RVA = "0x82CEE8", Offset = "0x82CEE8", VA = "0x82CEE8")]
	public LevelEditorScoreboardHandler(ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, LevelEditorScoreboard scoreboard, WorldContext worldContext, MenuSettings menuSettings, MonoBehaviour monoBehaviour, Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen, NetworkHandler networkHandler, LevelEditorPlayContext levelEditorPlayContext, GameStateData gameStateData, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x82CF78", Offset = "0x82CF78", VA = "0x82CF78", Slot = "4")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x82D014", Offset = "0x82D014", VA = "0x82D014", Slot = "6")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x82DD28", Offset = "0x82DD28", VA = "0x82DD28", Slot = "7")]
	protected override void OnButtonClicked(int buttonIndex)
	{
	}
}
[Token(Token = "0x2000188")]
[Flags]
public enum LevelGridButtonType
{
	[Token(Token = "0x4000AC3")]
	LevelSlot = 0,
	[Token(Token = "0x4000AC4")]
	NextSlide = 1,
	[Token(Token = "0x4000AC5")]
	PreviousSlide = 2,
	[Token(Token = "0x4000AC6")]
	Close = 3,
	[Token(Token = "0x4000AC7")]
	Custom = 4,
	[Token(Token = "0x4000AC8")]
	BackToStart = 5
}
[Token(Token = "0x2000189")]
public class LevelGridButton : PalazzoButton<LevelGridButtonType>
{
	[Token(Token = "0x4000AC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public TextMeshPro numberTextDefault;

	[Token(Token = "0x4000ACA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMeshPro numberTextHover;

	[Token(Token = "0x4000ACB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMeshPro numberTextDisabled;

	[Token(Token = "0x4000ACC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[Header("Inidicators")]
	public GameObject optionalUploadedIndicator;

	[Token(Token = "0x4000ACD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject optionalEditingIndicator;

	[Token(Token = "0x4000ACE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject optionalSelectedIndicator;

	[Token(Token = "0x4000ACF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject optionalLoadingIndicator;

	[Token(Token = "0x4000AD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject optionalFavoriteIndicator;

	[Token(Token = "0x600061C")]
	[Address(RVA = "0x82DF90", Offset = "0x82DF90", VA = "0x82DF90")]
	public LevelGridButton()
	{
	}
}
[Token(Token = "0x200018A")]
public class LevelGridMenu : UiMenuBase<LevelGridButton, LevelGridButtonType>
{
	[Token(Token = "0x4000AD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro title;

	[Token(Token = "0x4000AD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LocalizedText optionalLocalizedTitle;

	[Token(Token = "0x4000AD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public SlideIndicator[] slideIndicators;

	[Token(Token = "0x600061D")]
	[Address(RVA = "0x82DFD8", Offset = "0x82DFD8", VA = "0x82DFD8")]
	public LevelGridMenu()
	{
	}
}
[Token(Token = "0x200018B")]
[DisallowMultipleComponent]
public sealed class LevelSelect : UiMenuBase<LevelButton, LevelSelectButtonType>
{
	[Token(Token = "0x4000AD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro levelName;

	[Token(Token = "0x4000AD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LocalizedText localizedLevelName;

	[Token(Token = "0x4000AD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MeshRenderer backDrop;

	[Token(Token = "0x4000AD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material darkStar;

	[Token(Token = "0x4000AD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material litStar;

	[Token(Token = "0x4000AD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public LevelButton[] levelSelectButtons;

	[Token(Token = "0x4000ADA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LevelButton[] levelButtons;

	[Token(Token = "0x4000ADB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public LevelButton bossButton;

	[Token(Token = "0x4000ADC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public WorldType world;

	[Token(Token = "0x600061E")]
	[Address(RVA = "0x82E020", Offset = "0x82E020", VA = "0x82E020")]
	public LevelSelect()
	{
	}
}
[Token(Token = "0x200018C")]
public enum LevelSelectButtonType
{
	[Token(Token = "0x4000ADE")]
	PlaceLevel,
	[Token(Token = "0x4000ADF")]
	SelectLevel,
	[Token(Token = "0x4000AE0")]
	ExitToWorldSelect,
	[Token(Token = "0x4000AE1")]
	NextSlide,
	[Token(Token = "0x4000AE2")]
	PreviousSlide,
	[Token(Token = "0x4000AE3")]
	Play,
	[Token(Token = "0x4000AE4")]
	UnfavoriteLevel,
	[Token(Token = "0x4000AE5")]
	ReportLevel,
	[Token(Token = "0x4000AE6")]
	Yes,
	[Token(Token = "0x4000AE7")]
	No
}
[Token(Token = "0x200018D")]
public sealed class LevelSelectButton : PalazzoButton<LevelSelectButtonType>
{
	[Token(Token = "0x600061F")]
	[Address(RVA = "0x82E068", Offset = "0x82E068", VA = "0x82E068")]
	public LevelSelectButton()
	{
	}
}
[Token(Token = "0x200018E")]
public class LoadingDots : MonoBehaviour
{
	[Token(Token = "0x4000AE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject backgroundDots;

	[Token(Token = "0x4000AE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] loadingDots;

	[Token(Token = "0x6000620")]
	[Address(RVA = "0x82E0B0", Offset = "0x82E0B0", VA = "0x82E0B0")]
	public LoadingDots()
	{
	}
}
[Token(Token = "0x200018F")]
[DisallowMultipleComponent]
public sealed class LoseScreen : PlayMenuBase<ScoreboardButton>
{
	[Token(Token = "0x4000AEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshPro levelName;

	[Token(Token = "0x4000AEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LocalizedText localizedLevelName;

	[Token(Token = "0x4000AEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocalizedText levelDescription;

	[Token(Token = "0x4000AED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject optionalSpinningWheel;

	[Token(Token = "0x4000AEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TMP_Text optionalUsernameText;

	[Token(Token = "0x4000AEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TMP_Text optionalUsernameHoverText;

	[Token(Token = "0x4000AF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TMP_Text optionalLevelCodeText;

	[Token(Token = "0x4000AF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public SpriteRenderer optionalUserImage;

	[Token(Token = "0x4000AF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public LoadingDots optionalLoadingDots;

	[Token(Token = "0x4000AF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ConnectionIndicator connectionIndicator;

	[Token(Token = "0x6000621")]
	[Address(RVA = "0x82E0B8", Offset = "0x82E0B8", VA = "0x82E0B8")]
	public LoseScreen()
	{
	}
}
[Token(Token = "0x2000190")]
public sealed class LoseScreenHandler : PlayMenuHandlerBase
{
	[Token(Token = "0x4000AF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000AF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000AF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly LoseScreen loseScreen;

	[Token(Token = "0x4000AF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x4000AF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly PalazzoWorld[] worldPrefabs;

	[Token(Token = "0x4000AF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly List<string> levelGuids;

	[Token(Token = "0x4000AFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x4000AFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen;

	[Token(Token = "0x4000AFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000AFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000AFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000AFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly CreateUserSettings createUserSettings;

	[Token(Token = "0x4000B00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private GameState nextGameState;

	[Token(Token = "0x4000B01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool handleNetworkResponse;

	[Token(Token = "0x4000B02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Future<ServerLevelMetaData> quickplayLevelFuture;

	[Token(Token = "0x4000B03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Future<User> getUserDataFuture;

	[Token(Token = "0x4000B04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private User user;

	[Token(Token = "0x4000B05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private PalazzoButton nextButton;

	[Token(Token = "0x6000622")]
	[Address(RVA = "0x82E100", Offset = "0x82E100", VA = "0x82E100")]
	public LoseScreenHandler(ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, LevelContext levelContext, LoseScreen loseScreen, PalazzoGameDataPersistent gameDataPersistent, WorldContext worldContext, MenuSettings menuSettings, PalazzoWorld[] worldPrefabs, List<string> levelGuids, MonoBehaviour monoBehaviour, Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen, LevelEditorPlayContext levelEditorPlayContext, NetworkHandler networkHandler, GameStateData gameStateData, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x82E1AC", Offset = "0x82E1AC", VA = "0x82E1AC", Slot = "6")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x82ED0C", Offset = "0x82ED0C", VA = "0x82ED0C", Slot = "7")]
	protected override void OnButtonClicked(int buttonIndex)
	{
	}
}
[Token(Token = "0x2000191")]
public class OnlineSideMenu : SideMenu
{
	[Token(Token = "0x4000B06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshPro levelCodeText;

	[Token(Token = "0x4000B07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshPro likesText;

	[Token(Token = "0x4000B08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshPro playsText;

	[Token(Token = "0x4000B09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshPro difficultyText;

	[Token(Token = "0x4000B0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SpriteRenderer userImage;

	[Token(Token = "0x4000B0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LoadingDots optionalLoadingDots;

	[Token(Token = "0x4000B0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform spinningWheel;

	[Token(Token = "0x4000B0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public DifficultyGauge difficultyGauge;

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x82EEC8", Offset = "0x82EEC8", VA = "0x82EEC8")]
	public OnlineSideMenu()
	{
	}
}
[Token(Token = "0x2000192")]
public class OnlineSplitMenu : SplitMenu
{
	[Token(Token = "0x4000B0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject levelsLayout;

	[Token(Token = "0x4000B0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject loadingLayout;

	[Token(Token = "0x4000B10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ConnectionIndicator connectionIndicator;

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x8288B8", Offset = "0x8288B8", VA = "0x8288B8")]
	public OnlineSplitMenu()
	{
	}
}
[Token(Token = "0x2000193")]
public enum OnlineSplitMenuButtonType
{
	[Token(Token = "0x4000B12")]
	NewTab,
	[Token(Token = "0x4000B13")]
	DifficultyTab,
	[Token(Token = "0x4000B14")]
	MostLikedTab,
	[Token(Token = "0x4000B15")]
	Weekly,
	[Token(Token = "0x4000B16")]
	AllTime,
	[Token(Token = "0x4000B17")]
	Custom,
	[Token(Token = "0x4000B18")]
	Sort
}
[Token(Token = "0x2000194")]
public class OnlineSplitMenuButton : LevelGridButton
{
	[Token(Token = "0x4000B19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public OnlineSplitMenuButtonType type;

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x82EED0", Offset = "0x82EED0", VA = "0x82EED0")]
	public OnlineSplitMenuButton()
	{
	}
}
[Token(Token = "0x2000195")]
public class OnlineSplitMenuHandler : SplitMenuHandler
{
	[Token(Token = "0x2000196")]
	protected enum State
	{
		[Token(Token = "0x4000B35")]
		Like,
		[Token(Token = "0x4000B36")]
		Difficulty,
		[Token(Token = "0x4000B37")]
		New,
		[Token(Token = "0x4000B38")]
		Custom
	}

	[Token(Token = "0x2000197")]
	protected enum TimespanOption
	{
		[Token(Token = "0x4000B3A")]
		Weekly,
		[Token(Token = "0x4000B3B")]
		AllTime
	}

	[Token(Token = "0x2000198")]
	protected enum SortingOption
	{
		[Token(Token = "0x4000B3D")]
		Descending,
		[Token(Token = "0x4000B3E")]
		Ascending
	}

	[Token(Token = "0x4000B1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000B1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x4000B1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly Action<MenuType> setMenuType;

	[Token(Token = "0x4000B1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly OnlineSplitMenu onlineSplitMenu;

	[Token(Token = "0x4000B1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly OnlineSideMenu onlineSideMenu;

	[Token(Token = "0x4000B1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000B20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly CreateUserSettings createUserSettings;

	[Token(Token = "0x4000B21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000B22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	protected LevelListContext currentListContext;

	[Token(Token = "0x4000B23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	protected LevelListContext[] levelListContexts;

	[Token(Token = "0x4000B24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	protected ServerLevelMetaData currentPreviewLevelData;

	[Token(Token = "0x4000B25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly int[] selectedLevelIdPerContext;

	[Token(Token = "0x4000B26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	protected bool isTransitionToPlay;

	[Token(Token = "0x4000B27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
	private bool reinitializeState;

	[Token(Token = "0x4000B28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private SortingOption sorting;

	[Token(Token = "0x4000B29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private TimespanOption timespan;

	[Token(Token = "0x4000B2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	protected State state;

	[Token(Token = "0x4000B2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	protected State prevState;

	[Token(Token = "0x4000B2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private bool stateHasInitialized;

	[Token(Token = "0x4000B2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private int selectedButtonIndex;

	[Token(Token = "0x4000B2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Future<User> getUserDataFuture;

	[Token(Token = "0x4000B2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private User selectedLevelsUser;

	[Token(Token = "0x4000B30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly DifficultyGaugeHandler difficultyGaugeHandler;

	[Token(Token = "0x4000B31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private bool isPlayingSortEffect;

	[Token(Token = "0x4000B32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private float sortingEffectTimer;

	[Token(Token = "0x4000B33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private int sortingEffectButtonIndex;

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x828B5C", Offset = "0x828B5C", VA = "0x828B5C")]
	protected OnlineSplitMenuHandler(LevelEditorPlayContext levelEditorPlayContext, NetworkHandler networkHandler, Action<LevelEditorStateType> setState, Action<MenuType> SetMenuType, SplitMenu splitMenu, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, InputHandler inputHandler, LevelContext levelContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelParent, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x829D54", Offset = "0x829D54", VA = "0x829D54", Slot = "9")]
	public override void Tick()
	{
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x829194", Offset = "0x829194", VA = "0x829194", Slot = "7")]
	public override void Show()
	{
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x82F094", Offset = "0x82F094", VA = "0x82F094", Slot = "13")]
	protected override void UpdateLevelSlotButtons()
	{
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x82F3B4", Offset = "0x82F3B4", VA = "0x82F3B4", Slot = "14")]
	protected override void UpdateNavigationButtons()
	{
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x82F514", Offset = "0x82F514", VA = "0x82F514", Slot = "15")]
	protected virtual void UpdateTabButtons(State state)
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x82ABAC", Offset = "0x82ABAC", VA = "0x82ABAC", Slot = "10")]
	protected override void OnGridMenuButtonClick(int buttonIndex)
	{
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0x82B0FC", Offset = "0x82B0FC", VA = "0x82B0FC", Slot = "12")]
	protected override void OnSideMenuButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0x829330", Offset = "0x829330", VA = "0x829330")]
	protected void PopulateStats(ServerLevelMetaData data)
	{
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x82EEF0", Offset = "0x82EEF0", VA = "0x82EEF0")]
	private void PopulateUser(User user)
	{
	}

	[Token(Token = "0x6000634")]
	[Address(RVA = "0x82EED4", Offset = "0x82EED4", VA = "0x82EED4")]
	protected static int GetContextLookupId(State state, SortingOption sorting, TimespanOption timespan)
	{
		return default(int);
	}
}
[Token(Token = "0x2000199")]
public sealed class Page
{
	[Token(Token = "0x4000B3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ServerLevelMetaData[] levels;

	[Token(Token = "0x4000B40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string next_page;

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x82F7D8", Offset = "0x82F7D8", VA = "0x82F7D8")]
	public Page()
	{
	}
}
[Token(Token = "0x200019A")]
public class PalazzoButton : MonoBehaviour
{
	[Token(Token = "0x200019B")]
	public enum State
	{
		[Token(Token = "0x4000B57")]
		Pressed,
		[Token(Token = "0x4000B58")]
		Hover,
		[Token(Token = "0x4000B59")]
		Idle,
		[Token(Token = "0x4000B5A")]
		Disabled
	}

	[Token(Token = "0x4000B41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("defaultSprite")]
	public GameObject enabledGeo;

	[Token(Token = "0x4000B42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("hoverGeo")]
	[FormerlySerializedAs("hoverSprite")]
	public GameObject optionalHoverGeo;

	[Token(Token = "0x4000B43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("disabledSprite")]
	[FormerlySerializedAs("disabledGeo")]
	public GameObject optionalDisabledGeo;

	[Token(Token = "0x4000B44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject optionalPressedGeo;

	[Token(Token = "0x4000B45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool useCollider;

	[Token(Token = "0x4000B46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Collider optionalCollider;

	[Token(Token = "0x4000B47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject[] optionalToggleSprites;

	[Token(Token = "0x4000B48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool isStationary;

	[Token(Token = "0x4000B49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	[FormerlySerializedAs("useCustomEnablingLogic")]
	public bool isUsingCustomEnablingLogic;

	[Token(Token = "0x4000B4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ParticleSystem optionalActivateParticle;

	[Token(Token = "0x4000B4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ParticleSystem optionalDeactivateParticle;

	[Token(Token = "0x4000B4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ParticleSystem optionalDefaultParticle;

	[Token(Token = "0x4000B4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public State state;

	[Token(Token = "0x4000B4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public State prevState;

	[NonSerialized]
	[Token(Token = "0x4000B4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float elapsedNormalized;

	[NonSerialized]
	[Token(Token = "0x4000B50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool isEnabled;

	[NonSerialized]
	[Token(Token = "0x4000B51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Vector3 rootPosition;

	[NonSerialized]
	[Token(Token = "0x4000B52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool isUsingCustomAnim;

	[NonSerialized]
	[Token(Token = "0x4000B53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Animator optionalAnimator;

	[NonSerialized]
	[Token(Token = "0x4000B54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool needsUserLoaded;

	[NonSerialized]
	[Token(Token = "0x4000B55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool needsInternetConnection;

	[Token(Token = "0x6000636")]
	[Address(RVA = "0x82F7E0", Offset = "0x82F7E0", VA = "0x82F7E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x82F8A0", Offset = "0x82F8A0", VA = "0x82F8A0")]
	public PalazzoButton()
	{
	}
}
[Token(Token = "0x200019C")]
public abstract class PalazzoButton<T> : PalazzoButton
{
	[Token(Token = "0x4000B5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T buttonType;

	[Token(Token = "0x6000638")]
	protected PalazzoButton()
	{
	}
}
[Token(Token = "0x200019D")]
public class ParticleSystemTimeScaleFix : MonoBehaviour
{
	[Token(Token = "0x4000B5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem particleSystem;

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x82F8B0", Offset = "0x82F8B0", VA = "0x82F8B0")]
	private void Update()
	{
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x82F960", Offset = "0x82F960", VA = "0x82F960")]
	public ParticleSystemTimeScaleFix()
	{
	}
}
[Token(Token = "0x200019E")]
[DisallowMultipleComponent]
public sealed class PauseScreen : PlayMenuBase<ScoreboardButton>
{
	[Token(Token = "0x4000B5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TMP_Text levelNameText;

	[Token(Token = "0x4000B5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LocalizedText levelNameLocalized;

	[Token(Token = "0x4000B5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocalizedText levelDescription;

	[Token(Token = "0x4000B60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject optionalSpinningWheel;

	[Token(Token = "0x4000B61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TMP_Text optionalUsernameText;

	[Token(Token = "0x4000B62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TMP_Text optionalUsernameHoverText;

	[Token(Token = "0x4000B63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TMP_Text optionalLevelCodeText;

	[Token(Token = "0x4000B64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public SpriteRenderer optionalUserImage;

	[Token(Token = "0x4000B65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public LoadingDots optionalLoadingDots;

	[Token(Token = "0x4000B66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ConnectionIndicator connectionIndicator;

	[Token(Token = "0x600063B")]
	[Address(RVA = "0x82F968", Offset = "0x82F968", VA = "0x82F968")]
	public PauseScreen()
	{
	}
}
[Token(Token = "0x200019F")]
public sealed class PauseScreenHandler : PlayMenuHandlerBase
{
	[Token(Token = "0x4000B67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000B68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly PauseScreen pauseScreen;

	[Token(Token = "0x4000B69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000B6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000B6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x4000B6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly PalazzoWorld[] worldPrefabs;

	[Token(Token = "0x4000B6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly List<string> levelGuids;

	[Token(Token = "0x4000B6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000B6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x4000B70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen;

	[Token(Token = "0x4000B71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000B72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000B73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly CreateUserSettings createUserSettings;

	[Token(Token = "0x4000B74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameState nextGameState;

	[Token(Token = "0x4000B75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private bool handleNetworkResponse;

	[Token(Token = "0x4000B76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Future<ServerLevelMetaData> quickplayLevelFuture;

	[Token(Token = "0x4000B77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Future<User> getUserDataFuture;

	[Token(Token = "0x4000B78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private User user;

	[Token(Token = "0x4000B79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private PalazzoButton nextButton;

	[Token(Token = "0x600063C")]
	[Address(RVA = "0x82F9B0", Offset = "0x82F9B0", VA = "0x82F9B0")]
	public PauseScreenHandler(ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, LevelContext levelContext, PauseScreen pauseScreen, PalazzoGameDataPersistent gameDataPersistent, WorldContext worldContext, MenuSettings menuSettings, PalazzoWorld[] worldPrefabs, MonoBehaviour monoBehaviour, Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen, LevelEditorPlayContext levelEditorPlayContext, NetworkHandler networkHandler, GameStateData gameStateData, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x600063D")]
	[Address(RVA = "0x82FA6C", Offset = "0x82FA6C", VA = "0x82FA6C", Slot = "7")]
	protected override void OnButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x600063E")]
	[Address(RVA = "0x82FD60", Offset = "0x82FD60", VA = "0x82FD60", Slot = "6")]
	public override GameState Tick()
	{
		return default(GameState);
	}
}
[Token(Token = "0x20001A0")]
public abstract class PlayMenuBase<T> : MonoBehaviour where T : PalazzoButton
{
	[Token(Token = "0x4000B7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public PlayType playType;

	[Token(Token = "0x4000B7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T[] buttons;

	[Token(Token = "0x4000B7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ButtonSettings buttonSettings;

	[Token(Token = "0x6000641")]
	protected PlayMenuBase()
	{
	}
}
[Token(Token = "0x20001A1")]
public abstract class PlayMenuHandlerBase
{
	[Token(Token = "0x20001A2")]
	protected enum MenuState
	{
		[Token(Token = "0x4000B86")]
		Init,
		[Token(Token = "0x4000B87")]
		WaitForInput,
		[Token(Token = "0x4000B88")]
		Hide,
		[Token(Token = "0x4000B89")]
		TransitionOut
	}

	[Token(Token = "0x4000B7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly PlayMenuBase<ScoreboardButton> menu;

	[Token(Token = "0x4000B7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000B7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000B80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000B81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly MenuSettings menuSettings;

	[Token(Token = "0x4000B82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected readonly ButtonHandler<PalazzoButton> buttonHandler;

	[Token(Token = "0x4000B83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected MenuState state;

	[Token(Token = "0x4000B84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected MenuState prevState;

	[Token(Token = "0x6000642")]
	[Address(RVA = "0x830858", Offset = "0x830858", VA = "0x830858")]
	protected PlayMenuHandlerBase(PlayMenuBase<ScoreboardButton> menu, IList<PalazzoButton> buttons, ARTransforms arTransforms, MenuSettings menuSettings, WorldContext worldContext, InputHandler inputHandler, TrajectoryHandler trajectoryHandler, PalazzoTriggers palazzoTriggers)
	{
	}

	[Token(Token = "0x6000643")]
	[Address(RVA = "0x830A3C", Offset = "0x830A3C", VA = "0x830A3C")]
	protected void Show()
	{
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x830ABC", Offset = "0x830ABC", VA = "0x830ABC")]
	protected void Hide()
	{
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x830AF8", Offset = "0x830AF8", VA = "0x830AF8", Slot = "4")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0x830B10", Offset = "0x830B10", VA = "0x830B10", Slot = "5")]
	public virtual void PositionGui()
	{
	}

	[Token(Token = "0x6000647")]
	public abstract GameState Tick();

	[Token(Token = "0x6000648")]
	protected abstract void OnButtonClicked(int buttonIndex);

	[Token(Token = "0x6000649")]
	[Address(RVA = "0x830B7C", Offset = "0x830B7C", VA = "0x830B7C", Slot = "8")]
	protected virtual void OnButtonHovered(int buttonIndex)
	{
	}
}
[Token(Token = "0x20001A4")]
public enum PrivacyButtonType
{
	[Token(Token = "0x4000B8D")]
	Checkbox,
	[Token(Token = "0x4000B8E")]
	Accept
}
[Token(Token = "0x20001A5")]
public class PrivacyButton : PalazzoButton
{
	[Token(Token = "0x4000B8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[Header("Settings Button")]
	public PrivacyButtonType type;

	[Token(Token = "0x4000B90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject optionalCheck;

	[Token(Token = "0x4000B91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMeshPro[] optionalText;

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x830BF0", Offset = "0x830BF0", VA = "0x830BF0")]
	public PrivacyButton()
	{
	}
}
[Token(Token = "0x20001A6")]
public class PrivacyMenu : UiMenuBase<PrivacyButton, PrivacyButtonType>
{
	[Token(Token = "0x4000B92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro title;

	[Token(Token = "0x4000B93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshPro description;

	[Token(Token = "0x600064E")]
	[Address(RVA = "0x830BF8", Offset = "0x830BF8", VA = "0x830BF8")]
	public PrivacyMenu()
	{
	}
}
[Token(Token = "0x20001A7")]
public class ProfileMenuHandler : OnlineSplitMenuHandler
{
	[Token(Token = "0x4000B94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly Action closeProfileMenu;

	[Token(Token = "0x4000B95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000B96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000B97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x4000B98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly Action<MenuType> setMenuType;

	[Token(Token = "0x4000B99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000B9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private bool hasPlayed;

	[Token(Token = "0x4000B9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x199")]
	private bool isOldInstance;

	[Token(Token = "0x4000B9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private MenuType? returnMenu;

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x830C40", Offset = "0x830C40", VA = "0x830C40")]
	public ProfileMenuHandler(Action<LevelEditorStateType> setState, Action<MenuType> setMenuType, SplitMenu splitMenu, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, InputHandler inputHandler, NetworkHandler networkHandler, LevelContext levelContext, LevelEditorPlayContext levelEditorPlayContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelParent, CreateUserSettings createUserSettings, GameStateData gameStateData)
	{
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x830D64", Offset = "0x830D64", VA = "0x830D64", Slot = "7")]
	public override void Show()
	{
	}

	[Token(Token = "0x6000651")]
	[Address(RVA = "0x8312F4", Offset = "0x8312F4", VA = "0x8312F4", Slot = "10")]
	protected override void OnGridMenuButtonClick(int buttonIndex)
	{
	}

	[Token(Token = "0x6000652")]
	[Address(RVA = "0x831458", Offset = "0x831458", VA = "0x831458", Slot = "12")]
	protected override void OnSideMenuButtonClicked(int buttonIndex)
	{
	}
}
[Token(Token = "0x20001A8")]
[DisallowMultipleComponent]
public sealed class RatingScreen : PlayMenuBase<ScoreboardButton>
{
	[Token(Token = "0x6000653")]
	[Address(RVA = "0x8314C4", Offset = "0x8314C4", VA = "0x8314C4")]
	public RatingScreen()
	{
	}
}
[Token(Token = "0x20001A9")]
public sealed class RatingScreenHandler : PlayMenuHandlerBase
{
	[Token(Token = "0x4000B9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000B9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000B9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly RatingScreen ratingScreen;

	[Token(Token = "0x4000BA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly Action onButtonClicked;

	[Token(Token = "0x4000BA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000BA2")]
	private const float FX_TIMER = 1f;

	[Token(Token = "0x4000BA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float timer;

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x83150C", Offset = "0x83150C", VA = "0x83150C")]
	public RatingScreenHandler(NetworkHandler networkHandler, LevelEditorPlayContext levelEditorPlayContext, RatingScreen ratingScreen, ARTransforms arTransforms, MenuSettings menuSettings, WorldContext worldContext, InputHandler inputHandler, TrajectoryHandler trajectoryHandler, PalazzoTriggers palazzoTriggers, Action onButtonClicked)
	{
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x831588", Offset = "0x831588", VA = "0x831588", Slot = "6")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0x831654", Offset = "0x831654", VA = "0x831654", Slot = "7")]
	protected override void OnButtonClicked(int buttonIndex)
	{
	}
}
[Token(Token = "0x20001AA")]
public class RecoveryMenu : UiMenuBase<RecoveryMenuButton, RecoveryMenuButtonType>
{
	[Token(Token = "0x6000657")]
	[Address(RVA = "0x831754", Offset = "0x831754", VA = "0x831754")]
	public RecoveryMenu()
	{
	}
}
[Token(Token = "0x20001AB")]
public enum RecoveryMenuButtonType
{
	[Token(Token = "0x4000BA5")]
	Yes,
	[Token(Token = "0x4000BA6")]
	No
}
[Token(Token = "0x20001AC")]
public class RecoveryMenuButton : PalazzoButton<RecoveryMenuButtonType>
{
	[Token(Token = "0x6000658")]
	[Address(RVA = "0x83179C", Offset = "0x83179C", VA = "0x83179C")]
	public RecoveryMenuButton()
	{
	}
}
[Token(Token = "0x20001AD")]
public class ReportMenu : UiMenuBase<ReportMenuButton, ReportMenuButtonType>
{
	[Token(Token = "0x4000BA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject report;

	[Token(Token = "0x4000BA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject thanks;

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x8317E4", Offset = "0x8317E4", VA = "0x8317E4")]
	public ReportMenu()
	{
	}
}
[Token(Token = "0x20001AE")]
public enum ReportMenuButtonType
{
	[Token(Token = "0x4000BAA")]
	Cancel,
	[Token(Token = "0x4000BAB")]
	Impossible,
	[Token(Token = "0x4000BAC")]
	Offensive
}
[Token(Token = "0x20001AF")]
public class ReportMenuButton : PalazzoButton<ReportMenuButtonType>
{
	[Token(Token = "0x600065A")]
	[Address(RVA = "0x83182C", Offset = "0x83182C", VA = "0x83182C")]
	public ReportMenuButton()
	{
	}
}
[Token(Token = "0x20001B0")]
public class ReportMenuHandler : IMenuHandler
{
	[Token(Token = "0x4000BAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly UiMenuHandlerBase<ReportMenuButton, ReportMenuButtonType> menuHandler;

	[Token(Token = "0x4000BAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ReportMenu menu;

	[Token(Token = "0x4000BAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000BB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x4000BB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<MenuType> setMenuType;

	[Token(Token = "0x4000BB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000BB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x600065B")]
	[Address(RVA = "0x831874", Offset = "0x831874", VA = "0x831874")]
	public ReportMenuHandler(UiMenuBase<ReportMenuButton, ReportMenuButtonType> menu, ARTransforms arTransforms, InputHandler inputHandler, WorldContext worldContext, MenuSettings menuSettings, TrajectoryHandler trajectoryHandler, PalazzoTriggers palazzoTriggers, LevelEditorPlayContext levelEditorPlayContext, Action<LevelEditorStateType> setState, Action<MenuType> setMenuType, NetworkHandler networkHandler, GameStateData gameStateData)
	{
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0x831A44", Offset = "0x831A44", VA = "0x831A44")]
	private void OnButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x600065D")]
	[Address(RVA = "0x831CC4", Offset = "0x831CC4", VA = "0x831CC4", Slot = "5")]
	public void Hide()
	{
	}

	[Token(Token = "0x600065E")]
	[Address(RVA = "0x831D14", Offset = "0x831D14", VA = "0x831D14", Slot = "4")]
	public void Show()
	{
	}

	[Token(Token = "0x600065F")]
	[Address(RVA = "0x831DA4", Offset = "0x831DA4", VA = "0x831DA4", Slot = "6")]
	public void Tick()
	{
	}
}
[Token(Token = "0x20001B1")]
public class SaveLevelsMenu : SplitMenu
{
	[Token(Token = "0x4000BB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LevelGridButton[] unusedLevelSlots;

	[Token(Token = "0x6000660")]
	[Address(RVA = "0x831DF4", Offset = "0x831DF4", VA = "0x831DF4")]
	public SaveLevelsMenu()
	{
	}
}
[Token(Token = "0x20001B2")]
public class SaveLevelsMenuHandler : SplitMenuHandler
{
	[Token(Token = "0x4000BB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly SaveLevelsMenu saveLevelsMenu;

	[Token(Token = "0x4000BB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x4000BB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x4000BB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly ButtonHandler<LevelGridButton> unusedLevelSlotsButtonHandler;

	[Token(Token = "0x6000661")]
	[Address(RVA = "0x831E04", Offset = "0x831E04", VA = "0x831E04")]
	public SaveLevelsMenuHandler(LevelEditorContext levelEditorContext, Action<LevelEditorStateType> setState, SplitMenu splitMenu, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, InputHandler inputHandler, LevelContext levelContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelParent)
	{
	}

	[Token(Token = "0x6000662")]
	[Address(RVA = "0x832590", Offset = "0x832590", VA = "0x832590", Slot = "10")]
	protected override void OnGridMenuButtonClick(int buttonIndex)
	{
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0x832810", Offset = "0x832810", VA = "0x832810", Slot = "12")]
	protected override void OnSideMenuButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x832948", Offset = "0x832948", VA = "0x832948", Slot = "9")]
	public override void Tick()
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x832764", Offset = "0x832764", VA = "0x832764")]
	private void SelectLevel()
	{
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x832BA4", Offset = "0x832BA4", VA = "0x832BA4", Slot = "13")]
	protected override void UpdateLevelSlotButtons()
	{
	}
}
[Token(Token = "0x20001B4")]
public class ScoreboardBase : PlayMenuBase<ScoreboardButton>
{
	[Token(Token = "0x600066B")]
	[Address(RVA = "0x833114", Offset = "0x833114", VA = "0x833114")]
	public ScoreboardBase()
	{
	}
}
[Token(Token = "0x20001B5")]
[DisallowMultipleComponent]
public sealed class Scoreboard : ScoreboardBase
{
	[Token(Token = "0x4000BBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator scoreBarAnimator;

	[Token(Token = "0x4000BBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material darkStar;

	[Token(Token = "0x4000BBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material litStar;

	[Token(Token = "0x4000BBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshPro levelText;

	[Token(Token = "0x4000BC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public LocalizedText localizedLevelName;

	[Token(Token = "0x4000BC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshPro scoreText;

	[Token(Token = "0x4000BC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshPro scoreBreakdownText;

	[Token(Token = "0x4000BC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ScoreboardBreakdownComponent levelBlock;

	[Token(Token = "0x4000BC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ScoreboardBreakdownComponent pig;

	[Token(Token = "0x4000BC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ScoreboardBreakdownComponent red;

	[Token(Token = "0x4000BC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ScoreboardBreakdownComponent yellow;

	[Token(Token = "0x4000BC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ScoreboardBreakdownComponent blue;

	[Token(Token = "0x4000BC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public ScoreboardBreakdownComponent black;

	[Token(Token = "0x4000BC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public PalazzoComponentStar[] stars;

	[Token(Token = "0x4000BCA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform despawnEffectTransform;

	[NonSerialized]
	[Token(Token = "0x4000BCB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float animationTimeBlend;

	[NonSerialized]
	[Token(Token = "0x4000BCC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public bool disableButtons;

	[Token(Token = "0x600066C")]
	[Address(RVA = "0x83315C", Offset = "0x83315C", VA = "0x83315C")]
	public Scoreboard()
	{
	}
}
[Token(Token = "0x20001B6")]
public class ScoreboardBreakdownComponent : MonoBehaviour
{
	[Token(Token = "0x4000BCD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool hasAnimation;

	[Token(Token = "0x4000BCE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator anim;

	[Token(Token = "0x4000BCF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string animationTrigger;

	[Token(Token = "0x600066D")]
	[Address(RVA = "0x833160", Offset = "0x833160", VA = "0x833160")]
	public ScoreboardBreakdownComponent()
	{
	}
}
[Token(Token = "0x20001B7")]
public enum ScoreBoardButtonType
{
	[Token(Token = "0x4000BD1")]
	LevelSelect,
	[Token(Token = "0x4000BD2")]
	Retry,
	[Token(Token = "0x4000BD3")]
	NextLevel,
	[Token(Token = "0x4000BD4")]
	Close,
	[Token(Token = "0x4000BD5")]
	BackToEdit,
	[Token(Token = "0x4000BD6")]
	Upload,
	[Token(Token = "0x4000BD7")]
	WorldSelect,
	[Token(Token = "0x4000BD8")]
	Favorite,
	[Token(Token = "0x4000BD9")]
	Report,
	[Token(Token = "0x4000BDA")]
	User,
	[Token(Token = "0x4000BDB")]
	Like,
	[Token(Token = "0x4000BDC")]
	Dislike
}
[Token(Token = "0x20001B8")]
public sealed class ScoreboardButton : PalazzoButton<ScoreBoardButtonType>
{
	[Token(Token = "0x600066E")]
	[Address(RVA = "0x833168", Offset = "0x833168", VA = "0x833168")]
	public ScoreboardButton()
	{
	}
}
[Token(Token = "0x20001B9")]
public sealed class ScoreboardHandler : PlayMenuHandlerBase
{
	[Token(Token = "0x20001BA")]
	private enum ScoreboardState
	{
		[Token(Token = "0x4000BFD")]
		Init,
		[Token(Token = "0x4000BFE")]
		Wait,
		[Token(Token = "0x4000BFF")]
		ShowGeometry,
		[Token(Token = "0x4000C00")]
		TickScore,
		[Token(Token = "0x4000C01")]
		AnimateStars,
		[Token(Token = "0x4000C02")]
		Skip,
		[Token(Token = "0x4000C03")]
		Done,
		[Token(Token = "0x4000C04")]
		Hide
	}

	[Token(Token = "0x4000BDD")]
	private const float INVERSE_GAME_OVER_COUNTER_DURATION = 2f / 3f;

	[Token(Token = "0x4000BDE")]
	private const float GAME_OVER_STAR_DURATION_PER_STAR = 0.3f;

	[Token(Token = "0x4000BDF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000BE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000BE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000BE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly ScoreboardContext scoreboardContext;

	[Token(Token = "0x4000BE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly Scoreboard scoreboard;

	[Token(Token = "0x4000BE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly ScoreboardSettings scoreboardSettings;

	[Token(Token = "0x4000BE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly PalazzoWorld[] worldPrefabs;

	[Token(Token = "0x4000BE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x4000BE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen;

	[Token(Token = "0x4000BE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Animator scoreBarAnimator;

	[Token(Token = "0x4000BE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly int scoreBarStateNameHash;

	[Token(Token = "0x4000BEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private ScoreboardState scoreboardState;

	[Token(Token = "0x4000BEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private ScoreboardState prevScoreboardState;

	[Token(Token = "0x4000BEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float timeSinceStartActivatingStars;

	[Token(Token = "0x4000BED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float timeSinceStartActivatingStarsPrevious;

	[Token(Token = "0x4000BEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private float timeScaling;

	[Token(Token = "0x4000BEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float timeToWait;

	[Token(Token = "0x4000BF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private int score1;

	[Token(Token = "0x4000BF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int score2;

	[Token(Token = "0x4000BF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private int score3;

	[Token(Token = "0x4000BF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int numOfStars;

	[Token(Token = "0x4000BF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private bool isButtonsDisabled;

	[Token(Token = "0x4000BF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameState nextGameState;

	[Token(Token = "0x4000BF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly List<ScoreboardBreakdownComponent> scalingLevelBlocks;

	[Token(Token = "0x4000BF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly float[] animationTimeBlendTargets;

	[Token(Token = "0x4000BF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly int[] targetScores;

	[Token(Token = "0x4000BF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly int[] separateScores;

	[Token(Token = "0x4000BFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private int currentBreakDownPhase;

	[Token(Token = "0x4000BFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private int scalingBlocksShown;

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x8331B0", Offset = "0x8331B0", VA = "0x8331B0")]
	public ScoreboardHandler(ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, ScoreboardContext scoreboardContext, Scoreboard scoreboard, ScoreboardSettings scoreboardSettings, WorldContext worldContext, MenuSettings menuSettings, PalazzoWorld[] worldPrefabs, MonoBehaviour monoBehaviour, Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen)
	{
	}

	[Token(Token = "0x6000670")]
	[Address(RVA = "0x8333F4", Offset = "0x8333F4", VA = "0x8333F4", Slot = "5")]
	public override void PositionGui()
	{
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0x833494", Offset = "0x833494", VA = "0x833494")]
	private void ShowScalingObject()
	{
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0x833668", Offset = "0x833668", VA = "0x833668", Slot = "4")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0x833684", Offset = "0x833684", VA = "0x833684", Slot = "6")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000674")]
	[Address(RVA = "0x834938", Offset = "0x834938", VA = "0x834938", Slot = "7")]
	protected override void OnButtonClicked(int buttonIndex)
	{
	}
}
[Token(Token = "0x20001BB")]
public sealed class SettingsMenu : UiMenuBase<SettingsMenuButton, SettingsMenuButtonType>
{
	[Token(Token = "0x4000C05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SettingsMenuButton closeButton;

	[Token(Token = "0x4000C06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject main;

	[Token(Token = "0x4000C07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject confirmPrompt;

	[Token(Token = "0x4000C08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocalizedText confirmText;

	[Token(Token = "0x4000C09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocalizedText confirmFeedbackText;

	[Token(Token = "0x4000C0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject confirmFeedback;

	[Token(Token = "0x4000C0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject riftControls;

	[Token(Token = "0x4000C0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject viveControls;

	[Token(Token = "0x4000C0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject viveFocusPlusControls;

	[Token(Token = "0x4000C0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject moveControls;

	[Token(Token = "0x4000C0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject questControls;

	[Token(Token = "0x4000C10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject riftSControls;

	[Token(Token = "0x4000C11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject indexControls;

	[Token(Token = "0x4000C12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject qiyuControls;

	[Token(Token = "0x4000C13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[FormerlySerializedAs("picoControls")]
	public GameObject picoNeo3Controls;

	[Token(Token = "0x4000C14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject pico4Controls;

	[Token(Token = "0x4000C15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	public GameObject controls;

	[Token(Token = "0x6000676")]
	[Address(RVA = "0x834A38", Offset = "0x834A38", VA = "0x834A38")]
	public SettingsMenu()
	{
	}
}
[Token(Token = "0x20001BC")]
public enum SettingsMenuButtonType
{
	[Token(Token = "0x4000C17")]
	MuteSound,
	[Token(Token = "0x4000C18")]
	MuteMusic,
	[Token(Token = "0x4000C19")]
	Vibration,
	[Token(Token = "0x4000C1A")]
	Reset,
	[Token(Token = "0x4000C1B")]
	Exit,
	[Token(Token = "0x4000C1C")]
	Cancel,
	[Token(Token = "0x4000C1D")]
	Yes,
	[Token(Token = "0x4000C1E")]
	No,
	[Token(Token = "0x4000C1F")]
	Ok,
	[Token(Token = "0x4000C20")]
	Controls,
	[Token(Token = "0x4000C21")]
	BackControlsOculus,
	[Token(Token = "0x4000C22")]
	BackControlsVive,
	[Token(Token = "0x4000C23")]
	BackControlsMove,
	[Token(Token = "0x4000C24")]
	BackControlsQuest,
	[Token(Token = "0x4000C25")]
	BackControlsRiftS,
	[Token(Token = "0x4000C26")]
	PrivacyPolicy,
	[Token(Token = "0x4000C27")]
	SwapHandedness,
	[Token(Token = "0x4000C28")]
	UseSlingshotAim,
	[Token(Token = "0x4000C29")]
	BackControlsIndex,
	[Token(Token = "0x4000C2A")]
	BackControlsViveFocusPlus,
	[Token(Token = "0x4000C2B")]
	TermsOfUse
}
[Token(Token = "0x20001BD")]
public sealed class SettingsMenuButton : PalazzoButton
{
	[Token(Token = "0x4000C2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[Header("Settings Button")]
	public SettingsMenuButtonType type;

	[Token(Token = "0x4000C2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject optionalCheck;

	[Token(Token = "0x6000677")]
	[Address(RVA = "0x834A80", Offset = "0x834A80", VA = "0x834A80")]
	public SettingsMenuButton()
	{
	}
}
[Token(Token = "0x20001BE")]
public class SideMenu : UiMenuBase<SideMenuButton, SideMenuButtonType>
{
	[Token(Token = "0x4000C2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SubSideMenu[] subSideMenus;

	[Token(Token = "0x6000678")]
	[Address(RVA = "0x834A88", Offset = "0x834A88", VA = "0x834A88")]
	public SideMenu()
	{
	}
}
[Token(Token = "0x20001BF")]
public enum SideMenuButtonType
{
	[Token(Token = "0x4000C30")]
	Play,
	[Token(Token = "0x4000C31")]
	Edit,
	[Token(Token = "0x4000C32")]
	Duplicate,
	[Token(Token = "0x4000C33")]
	Upload,
	[Token(Token = "0x4000C34")]
	Favorite,
	[Token(Token = "0x4000C35")]
	Delete,
	[Token(Token = "0x4000C36")]
	Yes,
	[Token(Token = "0x4000C37")]
	No,
	[Token(Token = "0x4000C38")]
	Build,
	[Token(Token = "0x4000C39")]
	Save,
	[Token(Token = "0x4000C3A")]
	Overwrite,
	[Token(Token = "0x4000C3B")]
	Cancel,
	[Token(Token = "0x4000C3C")]
	Unshare,
	[Token(Token = "0x4000C3D")]
	Disabled,
	[Token(Token = "0x4000C3E")]
	Report,
	[Token(Token = "0x4000C3F")]
	User,
	[Token(Token = "0x4000C40")]
	CreateUser,
	[Token(Token = "0x4000C41")]
	PlayTrial
}
[Token(Token = "0x20001C0")]
public class SideMenuButton : PalazzoButton<SideMenuButtonType>
{
	[Token(Token = "0x4000C42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public TextMeshPro optionalUserNameDefault;

	[Token(Token = "0x4000C43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMeshPro optionalUserNameHover;

	[Token(Token = "0x6000679")]
	[Address(RVA = "0x834AD0", Offset = "0x834AD0", VA = "0x834AD0")]
	public SideMenuButton()
	{
	}
}
[Token(Token = "0x20001C1")]
public class SlotMachine : MonoBehaviour
{
	[Token(Token = "0x4000C44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SlotMachineWords slotMachineWords;

	[Token(Token = "0x4000C45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] textFieldRoots;

	[Token(Token = "0x4000C46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro[] textFields;

	[Token(Token = "0x4000C47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float rotationSpeedUpTime;

	[Token(Token = "0x4000C48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float rotationTopSpeed;

	[Token(Token = "0x4000C49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float rotationInterval;

	[Token(Token = "0x4000C4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem borderParticles;

	[Token(Token = "0x4000C4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Animator scrollVFX;

	[Token(Token = "0x600067A")]
	[Address(RVA = "0x834B18", Offset = "0x834B18", VA = "0x834B18")]
	public SlotMachine()
	{
	}
}
[Token(Token = "0x20001C2")]
public class SlotMachineHandler
{
	[Token(Token = "0x20001C3")]
	private enum State
	{
		[Token(Token = "0x4000C5F")]
		Stop,
		[Token(Token = "0x4000C60")]
		Accelerate,
		[Token(Token = "0x4000C61")]
		Rotate,
		[Token(Token = "0x4000C62")]
		Select
	}

	[Token(Token = "0x4000C4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly SlotMachine[] slotMachines;

	[Token(Token = "0x4000C4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly GameObject spriteRoot;

	[Token(Token = "0x4000C4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly SpriteRenderer spriteRenderer;

	[Token(Token = "0x4000C4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly float spriteMaxSpeed;

	[Token(Token = "0x4000C50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private readonly float spriteAccelerationTime;

	[Token(Token = "0x4000C51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Sprite[] images;

	[Token(Token = "0x4000C52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string[] selectedNames;

	[Token(Token = "0x4000C53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private State state;

	[Token(Token = "0x4000C54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] currentWordIndex;

	[Token(Token = "0x4000C55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float[] currentSlotMachineSpeed;

	[Token(Token = "0x4000C56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float rotationStartTime;

	[Token(Token = "0x4000C57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool readyToSelect;

	[Token(Token = "0x4000C58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool[] isDecelarating;

	[Token(Token = "0x4000C59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] selectedFieldIndex;

	[Token(Token = "0x4000C5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool[] stopped;

	[Token(Token = "0x4000C5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool[] playedScrollVFX;

	[Token(Token = "0x4000C5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float spriteDirection;

	[Token(Token = "0x4000C5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int currentImageIndex;

	[Token(Token = "0x600067B")]
	[Address(RVA = "0x834B20", Offset = "0x834B20", VA = "0x834B20")]
	public SlotMachineHandler(SlotMachine[] slotMachines, GameObject spriteRoot, SpriteRenderer spriteRenderer, float spriteMaxSpeed, float spriteAccelerationTime, Sprite[] images)
	{
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0x834EB4", Offset = "0x834EB4", VA = "0x834EB4")]
	public void Tick()
	{
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0x835EFC", Offset = "0x835EFC", VA = "0x835EFC")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0x835F0C", Offset = "0x835F0C", VA = "0x835F0C")]
	public void StartRotation()
	{
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0x835F78", Offset = "0x835F78", VA = "0x835F78")]
	public void Select(string[] nameParts)
	{
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x8360DC", Offset = "0x8360DC", VA = "0x8360DC")]
	public int GetSpriteIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0x83580C", Offset = "0x83580C", VA = "0x83580C")]
	private void MoveTextFields(int slotMachineIndex)
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0x835D6C", Offset = "0x835D6C", VA = "0x835D6C")]
	private bool TryMoveSprite(float speed, bool stopOnNextSprite)
	{
		return default(bool);
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0x8357BC", Offset = "0x8357BC", VA = "0x8357BC")]
	private float EaseInCubic(float x)
	{
		return default(float);
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0x834DBC", Offset = "0x834DBC", VA = "0x834DBC")]
	private void ShuffleArray(string[] array)
	{
	}
}
[Token(Token = "0x20001C5")]
[CreateAssetMenu]
public class SlotMachineWords : ScriptableObject
{
	[Token(Token = "0x4000C65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string[] words;

	[Token(Token = "0x6000688")]
	[Address(RVA = "0x836158", Offset = "0x836158", VA = "0x836158")]
	public SlotMachineWords()
	{
	}
}
[Token(Token = "0x20001C6")]
public sealed class SplashScreenHandler : MonoBehaviour
{
	[Token(Token = "0x20001C7")]
	[CompilerGenerated]
	private sealed class <Start>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplashScreenHandler <>4__this;

		[Token(Token = "0x4000C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <async>5__2;

		[Token(Token = "0x17000046")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x836748", Offset = "0x836748", VA = "0x836748", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x836790", Offset = "0x836790", VA = "0x836790", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x8362EC", Offset = "0x8362EC", VA = "0x8362EC")]
		[DebuggerHidden]
		public <Start>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x83645C", Offset = "0x83645C", VA = "0x83645C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x836460", Offset = "0x836460", VA = "0x836460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x836750", Offset = "0x836750", VA = "0x836750", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001C8")]
	[CompilerGenerated]
	private sealed class <UpdateDot>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplashScreenHandler <>4__this;

		[Token(Token = "0x17000048")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x8368C8", Offset = "0x8368C8", VA = "0x8368C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x836910", Offset = "0x836910", VA = "0x836910", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x83637C", Offset = "0x83637C", VA = "0x83637C")]
		[DebuggerHidden]
		public <UpdateDot>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x836798", Offset = "0x836798", VA = "0x836798", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x83679C", Offset = "0x83679C", VA = "0x83679C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x8368D0", Offset = "0x8368D0", VA = "0x8368D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000C66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float warmupShaderProgress;

	[Token(Token = "0x4000C67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static bool done;

	[Token(Token = "0x4000C68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly WaitForSeconds halfASecond;

	[Token(Token = "0x4000C69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly WaitForSeconds logoShowForSeconds;

	[Token(Token = "0x4000C6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Camera logoCamera;

	[Token(Token = "0x4000C6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject rovioLogo;

	[Token(Token = "0x4000C6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject resolutionLogo;

	[Token(Token = "0x4000C6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject gameLogo;

	[Token(Token = "0x4000C6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject[] dots;

	[Token(Token = "0x4000C6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject backgroundDots;

	[Token(Token = "0x4000C70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int dotIndex;

	[Token(Token = "0x6000689")]
	[Address(RVA = "0x836160", Offset = "0x836160", VA = "0x836160")]
	private void Awake()
	{
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0x836284", Offset = "0x836284", VA = "0x836284")]
	[IteratorStateMachine(typeof(<Start>d__12))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600068B")]
	[Address(RVA = "0x836314", Offset = "0x836314", VA = "0x836314")]
	[IteratorStateMachine(typeof(<UpdateDot>d__13))]
	private IEnumerator UpdateDot()
	{
		return null;
	}

	[Token(Token = "0x600068C")]
	[Address(RVA = "0x8363A4", Offset = "0x8363A4", VA = "0x8363A4")]
	public SplashScreenHandler()
	{
	}
}
[Token(Token = "0x20001C9")]
public class SplitMenu : MonoBehaviour
{
	[Token(Token = "0x4000C78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LevelGridMenu levelGridMenu;

	[Token(Token = "0x4000C79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SideMenu sideMenu;

	[Token(Token = "0x4000C7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MenuType menuType;

	[Token(Token = "0x600069A")]
	[Address(RVA = "0x831DFC", Offset = "0x831DFC", VA = "0x831DFC")]
	public SplitMenu()
	{
	}
}
[Token(Token = "0x20001CA")]
public class SplitMenuHandler : IMenuHandler
{
	[Token(Token = "0x4000C7B")]
	public const int NUMBER_OF_LEVELS_PER_PAGE = 12;

	[Token(Token = "0x4000C7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected readonly SplitMenu splitMenu;

	[Token(Token = "0x4000C7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly UiMenuHandlerBase<LevelGridButton, LevelGridButtonType> gridMenuHandler;

	[Token(Token = "0x4000C7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly UiMenuHandlerBase<SideMenuButton, SideMenuButtonType> sideMenuHandler;

	[Token(Token = "0x4000C7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly SubSideMenu[] subSideMenus;

	[Token(Token = "0x4000C80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelGridButton[] gridButtons;

	[Token(Token = "0x4000C81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly SlideIndicator[] slideIndicators;

	[Token(Token = "0x4000C82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly AnimationComponent animationComponent;

	[Token(Token = "0x4000C83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly Transform menuTransform;

	[Token(Token = "0x4000C84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000C85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000C86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly MenuSettings menuSettings;

	[Token(Token = "0x4000C87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000C88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly PreviewHandler previewHandler;

	[Token(Token = "0x4000C89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected SideMenuButtonType lastButtonClicked;

	[Token(Token = "0x4000C8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected int pageIndex;

	[Token(Token = "0x4000C8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected uint selectedButtonLevelId;

	[Token(Token = "0x4000C8C")]
	private const int BUTTONS_PER_PAGE = 12;

	[Token(Token = "0x4000C8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private readonly int totalNumberOfPages;

	[Token(Token = "0x4000C8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3? startPosition;

	[Token(Token = "0x4000C8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Quaternion? startRotation;

	[Token(Token = "0x4000C90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool isShowing;

	[Token(Token = "0x4000C91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float showTimer;

	[Token(Token = "0x4000C92")]
	private const float SHOW_DELAY = 0.5f;

	[Token(Token = "0x4000C93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int uiSpawnId;

	[Token(Token = "0x4000C94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private bool isLoadingLevel;

	[Token(Token = "0x4000C95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private ThreadJob<Level> loadLevelJob;

	[Token(Token = "0x600069B")]
	[Address(RVA = "0x832128", Offset = "0x832128", VA = "0x832128")]
	protected SplitMenuHandler(SplitMenu splitMenu, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, InputHandler inputHandler, LevelContext levelContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelParent, [Optional] NetworkHandler networkHandler)
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0x836918", Offset = "0x836918", VA = "0x836918", Slot = "7")]
	public virtual void Show()
	{
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0x836B58", Offset = "0x836B58", VA = "0x836B58", Slot = "8")]
	public virtual void Hide()
	{
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0x8329A0", Offset = "0x8329A0", VA = "0x8329A0", Slot = "9")]
	public virtual void Tick()
	{
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0x836BD8", Offset = "0x836BD8", VA = "0x836BD8")]
	protected void SelectLevel(uint levelId)
	{
	}

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x832B10", Offset = "0x832B10", VA = "0x832B10")]
	protected void SetSideMenu(SubSideMenuType subSideMenuType)
	{
	}

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x8369DC", Offset = "0x8369DC", VA = "0x8369DC")]
	private void PositionGui()
	{
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x83263C", Offset = "0x83263C", VA = "0x83263C", Slot = "10")]
	protected virtual void OnGridMenuButtonClick(int buttonIndex)
	{
	}

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x836C28", Offset = "0x836C28", VA = "0x836C28", Slot = "11")]
	protected virtual void OnGridMenuButtonHover(int buttonIndex)
	{
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x832944", Offset = "0x832944", VA = "0x832944", Slot = "12")]
	protected virtual void OnSideMenuButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x832E90", Offset = "0x832E90", VA = "0x832E90", Slot = "13")]
	protected virtual void UpdateLevelSlotButtons()
	{
	}

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x836C2C", Offset = "0x836C2C", VA = "0x836C2C", Slot = "14")]
	protected virtual void UpdateNavigationButtons()
	{
	}

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x833090", Offset = "0x833090", VA = "0x833090")]
	protected uint GetLevelIdFromButtonIndex(int buttonIndex)
	{
		return default(uint);
	}

	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x836CF4", Offset = "0x836CF4", VA = "0x836CF4")]
	protected void Preview(ThreadJob<Level> loadLevelJob)
	{
	}

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x832AF4", Offset = "0x832AF4", VA = "0x832AF4")]
	protected void Preview(Level level)
	{
	}

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x83143C", Offset = "0x83143C", VA = "0x83143C")]
	protected void Despawn()
	{
	}

	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x8327F4", Offset = "0x8327F4", VA = "0x8327F4")]
	protected void InstantDespawn()
	{
	}
}
[Token(Token = "0x20001CC")]
public enum StartButtonType
{
	[Token(Token = "0x4000C99")]
	Start
}
[Token(Token = "0x20001CD")]
public class StartScreen : UiMenuBase<PalazzoButton, StartButtonType>
{
	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x836DDC", Offset = "0x836DDC", VA = "0x836DDC")]
	public StartScreen()
	{
	}
}
[Token(Token = "0x20001CE")]
public enum SubSideMenuType
{
	[Token(Token = "0x4000C9B")]
	Nothing,
	[Token(Token = "0x4000C9C")]
	Default,
	[Token(Token = "0x4000C9D")]
	BuildNew,
	[Token(Token = "0x4000C9E")]
	Delete,
	[Token(Token = "0x4000C9F")]
	Upload,
	[Token(Token = "0x4000CA0")]
	Save,
	[Token(Token = "0x4000CA1")]
	Overwrite,
	[Token(Token = "0x4000CA2")]
	Stats,
	[Token(Token = "0x4000CA3")]
	DoesNotExist,
	[Token(Token = "0x4000CA4")]
	EnterCode,
	[Token(Token = "0x4000CA5")]
	Loading,
	[Token(Token = "0x4000CA6")]
	Unfavorite,
	[Token(Token = "0x4000CA7")]
	NeedProfile,
	[Token(Token = "0x4000CA8")]
	NeedPigToUpload,
	[Token(Token = "0x4000CA9")]
	NeedPlay,
	[Token(Token = "0x4000CAA")]
	LoadLevels,
	[Token(Token = "0x4000CAB")]
	NeedPigToPlay,
	[Token(Token = "0x4000CAC")]
	ConfirmUnshare,
	[Token(Token = "0x4000CAD")]
	NoLevels,
	[Token(Token = "0x4000CAE")]
	CannotSaveToSharedSlot
}
[Token(Token = "0x20001CF")]
public class SubSideMenu : MonoBehaviour
{
	[Token(Token = "0x4000CAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SubSideMenuType type;

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x836E24", Offset = "0x836E24", VA = "0x836E24")]
	public SubSideMenu()
	{
	}
}
[Token(Token = "0x20001D0")]
public abstract class UiMenuBase<T1, T2> : MonoBehaviour where T1 : PalazzoButton where T2 : Enum
{
	[Token(Token = "0x4000CB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T1[] buttons;

	[Token(Token = "0x4000CB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ButtonSettings buttonSettings;

	[Token(Token = "0x60006B2")]
	protected UiMenuBase()
	{
	}
}
[Token(Token = "0x20001D1")]
public sealed class UiMenuHandlerBase<T1, T2> : IMenuHandler where T1 : PalazzoButton where T2 : Enum
{
	[Token(Token = "0x4000CB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Transform menuTransform;

	[Token(Token = "0x4000CB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly UiMenuBase<T1, T2> menu;

	[Token(Token = "0x4000CB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000CB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000CB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000CB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly MenuSettings menuSettings;

	[Token(Token = "0x4000CB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly ButtonHandler<PalazzoButton> buttonHandler;

	[Token(Token = "0x4000CB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x4000CBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly AnimationComponent animationComponent;

	[Token(Token = "0x4000CBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly bool useAnimationRoot;

	[Token(Token = "0x4000CBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Vector3? startPosition;

	[Token(Token = "0x4000CBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float? startRotation;

	[Token(Token = "0x4000CBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int uiSpawnId;

	[Token(Token = "0x4000CBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool isShowing;

	[Token(Token = "0x4000CC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float showTimer;

	[Token(Token = "0x4000CC1")]
	private const float SHOW_DELAY = 0.5f;

	[Token(Token = "0x60006B3")]
	public UiMenuHandlerBase(UiMenuBase<T1, T2> menu, IList<PalazzoButton> buttons, ARTransforms arTransforms, InputHandler inputHandler, WorldContext worldContext, MenuSettings menuSettings, TrajectoryHandler trajectoryHandler, PalazzoTriggers palazzoTriggers, Action<int> onButtonClicked, [Optional] Action<int> onButtonHovered, [Optional] NetworkHandler networkHandler, bool useAnimationRoot = true)
	{
	}

	[Token(Token = "0x60006B4")]
	public void Spawn(bool positionGui = true, bool resetButtons = true)
	{
	}

	[Token(Token = "0x60006B5")]
	public void Despawn()
	{
	}

	[Token(Token = "0x60006B6")]
	public void Show()
	{
	}

	[Token(Token = "0x60006B7")]
	public void Hide()
	{
	}

	[Token(Token = "0x60006B8")]
	private void PositionGui()
	{
	}

	[Token(Token = "0x60006B9")]
	public void Tick()
	{
	}

	[Token(Token = "0x60006BA")]
	public void UpdateTrajectory()
	{
	}
}
[Token(Token = "0x20001D3")]
[CreateAssetMenu]
public class UiPrefabs : ScriptableObject
{
	[Token(Token = "0x4000CC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public StartScreen startScreen;

	[Token(Token = "0x4000CC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public WorldSelectMenu worldSelectMenu;

	[Token(Token = "0x4000CC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public LevelSelect levelSelect;

	[Token(Token = "0x4000CC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public ScoreboardBase[] scoreboards;

	[Token(Token = "0x4000CC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public PauseScreen[] pauseScreens;

	[Token(Token = "0x4000CCA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public LoseScreen[] loseScreens;

	[Token(Token = "0x4000CCB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public RatingScreen ratingScreen;

	[Token(Token = "0x4000CCC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public SplitMenu[] splitMenus;

	[Token(Token = "0x4000CCD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public SettingsMenu settingsMenu;

	[Token(Token = "0x4000CCE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	public PrivacyMenu privacyMenu;

	[Token(Token = "0x4000CCF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	public GameObject noEntitlementScreen;

	[Token(Token = "0x4000CD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	public RecoveryMenu recoveryMenu;

	[Token(Token = "0x4000CD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	public ErrorMenu errorMenu;

	[Token(Token = "0x4000CD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	public TutorialComponent tutorialComponent;

	[Token(Token = "0x4000CD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	public LevelEditorComponent levelEditor;

	[Token(Token = "0x4000CD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	public CreateUserMenu createUserMenu;

	[Token(Token = "0x4000CD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	public ReportMenu reportMenu;

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x836E2C", Offset = "0x836E2C", VA = "0x836E2C")]
	public UiPrefabs()
	{
	}
}
[Token(Token = "0x20001D4")]
public enum WorldSelectButtonType
{
	[Token(Token = "0x4000CD7")]
	Beach,
	[Token(Token = "0x4000CD8")]
	Cliff,
	[Token(Token = "0x4000CD9")]
	Snow,
	[Token(Token = "0x4000CDA")]
	Peak,
	[Token(Token = "0x4000CDB")]
	NightmareBeach,
	[Token(Token = "0x4000CDC")]
	NightmareCliff,
	[Token(Token = "0x4000CDD")]
	NightmareSnow,
	[Token(Token = "0x4000CDE")]
	NightmarePeak,
	[Token(Token = "0x4000CDF")]
	Settings,
	[Token(Token = "0x4000CE0")]
	ExitToModeSelect,
	[Token(Token = "0x4000CE1")]
	PrivacyPolicy,
	[Token(Token = "0x4000CE2")]
	ModeNormal,
	[Token(Token = "0x4000CE3")]
	ModeNightmare,
	[Token(Token = "0x4000CE4")]
	MyFavorites,
	[Token(Token = "0x4000CE5")]
	LevelEditor,
	[Token(Token = "0x4000CE6")]
	BuildLevels,
	[Token(Token = "0x4000CE7")]
	PlayerProfile,
	[Token(Token = "0x4000CE8")]
	Search,
	[Token(Token = "0x4000CE9")]
	Discovery,
	[Token(Token = "0x4000CEA")]
	QuickPlay,
	[Token(Token = "0x4000CEB")]
	ComingSoon
}
[Token(Token = "0x20001D5")]
public class WorldSelectButton : PalazzoButton<WorldSelectButtonType>
{
	[Token(Token = "0x4000CEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool unlocked;

	[Token(Token = "0x4000CED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject worldLock;

	[Token(Token = "0x4000CEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Animator worldLockAnimator;

	[Token(Token = "0x4000CEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TextMeshPro starText;

	[Token(Token = "0x4000CF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public ParticleSystem unlockParticleSystem;

	[Token(Token = "0x4000CF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public ParticleSystem optionalSpookyUnlockedSystem;

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0x836E34", Offset = "0x836E34", VA = "0x836E34")]
	public WorldSelectButton()
	{
	}
}
[Token(Token = "0x20001D6")]
public class WorldSelectMenu : MonoBehaviour
{
	[Token(Token = "0x4000CF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public WorldSelectSubMenu modeMenu;

	[Token(Token = "0x4000CF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public WorldSelectSubMenu worldMenus;

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x836E7C", Offset = "0x836E7C", VA = "0x836E7C")]
	public WorldSelectMenu()
	{
	}
}
[Token(Token = "0x20001D7")]
public sealed class WorldSelectSubMenu : UiMenuBase<WorldSelectButton, WorldSelectButtonType>
{
	[Token(Token = "0x4000CF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] normalModeObjects;

	[Token(Token = "0x4000CF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] nightmareModeObjects;

	[Token(Token = "0x4000CF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] levelEditorModeObjects;

	[Token(Token = "0x4000CF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject[] modeSelectionObjects;

	[Token(Token = "0x4000CF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject spookyButtonIcon;

	[Token(Token = "0x4000CF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject quickPlayIcon;

	[Token(Token = "0x4000CFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject quickPlaySpinningWheel;

	[Token(Token = "0x4000CFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject[] profileIcons;

	[Token(Token = "0x4000CFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject profileSpinningWheel;

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x836E84", Offset = "0x836E84", VA = "0x836E84")]
	public WorldSelectSubMenu()
	{
	}
}
[Token(Token = "0x20001D8")]
public class VRPostReprojection : MonoBehaviour
{
	[Token(Token = "0x4000CFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Camera mainCamera;

	[Token(Token = "0x4000CFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject loadingScreen;

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x836ECC", Offset = "0x836ECC", VA = "0x836ECC")]
	public VRPostReprojection()
	{
	}
}
[Token(Token = "0x20001D9")]
[DisallowMultipleComponent]
public sealed class WindComponent : MonoBehaviour
{
	[Token(Token = "0x4000CFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform blockTransform;

	[Token(Token = "0x4000D00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Rigidbody rb;

	[Token(Token = "0x4000D01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int maxWindPoints;

	[Token(Token = "0x4000D02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float windMultiplier;

	[Token(Token = "0x4000D03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int activeWindPoints;

	[Token(Token = "0x4000D04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3[] localWindPoints;

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x836ED4", Offset = "0x836ED4", VA = "0x836ED4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0x8370DC", Offset = "0x8370DC", VA = "0x8370DC")]
	public WindComponent()
	{
	}
}
[Token(Token = "0x20001DA")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
[RequireComponent(typeof(Collider))]
public sealed class WindVortexComponent : MonoBehaviour
{
	[NonSerialized]
	[Token(Token = "0x4000D05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public WindVortexImpactQueue windVortexImpactQueue;

	[Token(Token = "0x4000D06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup;

	[Token(Token = "0x4000D07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private FanComponent fan;

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x8370EC", Offset = "0x8370EC", VA = "0x8370EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0x83713C", Offset = "0x83713C", VA = "0x83713C")]
	private void OnTriggerStay(Collider collider)
	{
	}

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x837258", Offset = "0x837258", VA = "0x837258")]
	public WindVortexComponent()
	{
	}
}
[Token(Token = "0x20001DB")]
[DisallowMultipleComponent]
public sealed class WorldImpactComponent : MonoBehaviour
{
	[Token(Token = "0x4000D08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BlockType blockType;

	[Token(Token = "0x4000D09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleEffectComponent prefabImpactFx;

	[Token(Token = "0x4000D0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string soundImpact;

	[Token(Token = "0x4000D0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Collider[] cols;

	[NonSerialized]
	[Token(Token = "0x4000D0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public WorldImpactQueue worldImpactQueue;

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x837260", Offset = "0x837260", VA = "0x837260")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x8372E4", Offset = "0x8372E4", VA = "0x8372E4")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x83730C", Offset = "0x83730C", VA = "0x83730C")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x837360", Offset = "0x837360", VA = "0x837360")]
	public WorldImpactComponent()
	{
	}
}
[Token(Token = "0x20001DC")]
public enum WorldTrackerRenderMode
{
	[Token(Token = "0x4000D0E")]
	Wireframe,
	[Token(Token = "0x4000D0F")]
	Occlusion
}
[Token(Token = "0x20001DD")]
public abstract class WorldTracker
{
	[Token(Token = "0x4000D10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected ARTransforms arTransforms;

	[Token(Token = "0x4000D11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected bool isLevelPlaced;

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x837368", Offset = "0x837368", VA = "0x837368", Slot = "4")]
	public virtual void SetRenderMode(WorldTrackerRenderMode mode)
	{
	}

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x83736C", Offset = "0x83736C", VA = "0x83736C", Slot = "5")]
	public virtual void OnPlaceLevel()
	{
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x837378", Offset = "0x837378", VA = "0x837378", Slot = "6")]
	public virtual void OnLevelUnplaced()
	{
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x837380", Offset = "0x837380", VA = "0x837380", Slot = "7")]
	public virtual void Tick()
	{
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x837384", Offset = "0x837384", VA = "0x837384")]
	protected WorldTracker()
	{
	}
}
[Token(Token = "0x20001DE")]
public class DestroyIfReleaseOrQuest : MonoBehaviour
{
	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x83738C", Offset = "0x83738C", VA = "0x83738C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x8373F8", Offset = "0x8373F8", VA = "0x8373F8")]
	public DestroyIfReleaseOrQuest()
	{
	}
}
[Token(Token = "0x20001DF")]
public class PalazzoFollowPose : MonoBehaviour
{
	[Token(Token = "0x4000D12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool pause;

	[Token(Token = "0x4000D13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera theCamera;

	[Token(Token = "0x4000D14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private KeyCode increaseFov;

	[Token(Token = "0x4000D15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private KeyCode decreaseFov;

	[Token(Token = "0x4000D16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private KeyCode resetFov;

	[Token(Token = "0x4000D17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("The object to follow if not main camera")]
	public Transform[] objectsToFollow;

	[Token(Token = "0x4000D18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private KeyCode switchTarget;

	[Token(Token = "0x4000D19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RotateAroundComponent[] rotatingObjects;

	[Token(Token = "0x4000D1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float rotatingObjectSpeed;

	[Token(Token = "0x4000D1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private KeyCode increaseRotationSpeed;

	[Token(Token = "0x4000D1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private KeyCode decreaseRotationSpeed;

	[Token(Token = "0x4000D1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private KeyCode resetRotationSpeed;

	[Token(Token = "0x4000D1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Tooltip("How long it takes for the object to settle at the target object's position")]
	[SerializeField]
	private float movementSmoothTime;

	[Token(Token = "0x4000D1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private KeyCode increaseMovementSmoothing;

	[Token(Token = "0x4000D20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private KeyCode decreaseMovementSmoothing;

	[Token(Token = "0x4000D21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private KeyCode resetMovementSmoothing;

	[Token(Token = "0x4000D22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Tooltip("How long it takes for the object to settle at the target object's rotation")]
	[SerializeField]
	private float rotationSmoothTime;

	[Token(Token = "0x4000D23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	private KeyCode increaseRotationSmoothing;

	[Token(Token = "0x4000D24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private KeyCode decreaseRotationSmoothing;

	[Token(Token = "0x4000D25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private KeyCode resetRotationSmoothing;

	[Token(Token = "0x4000D26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Tooltip("Offset from target object's global position")]
	[SerializeField]
	private Vector3 globalPositionOffset;

	[Token(Token = "0x4000D27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[Tooltip("Offset from target object's local position")]
	[SerializeField]
	private Vector3 localPositionOffset;

	[Token(Token = "0x4000D28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Tooltip("Offset from target object's local position")]
	[SerializeField]
	private Vector3 rotationOffset;

	[Token(Token = "0x4000D29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[Tooltip("Make sure the horizon stays straight")]
	[SerializeField]
	private bool keepHorizontal;

	[Token(Token = "0x4000D2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private float tweekSpeed;

	[Token(Token = "0x4000D2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private new Transform transform;

	[Token(Token = "0x4000D2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Vector3 movementVelocity;

	[Token(Token = "0x4000D2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private Quaternion rotationVelocity;

	[Token(Token = "0x4000D2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public int currentTarget;

	[Token(Token = "0x4000D2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private bool active;

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x837400", Offset = "0x837400", VA = "0x837400")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x83741C", Offset = "0x83741C", VA = "0x83741C")]
	private void Update()
	{
	}

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x837FC4", Offset = "0x837FC4", VA = "0x837FC4")]
	private static Quaternion SmoothDamp(Quaternion rot, Quaternion target, ref Quaternion deriv, float time)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x838238", Offset = "0x838238", VA = "0x838238")]
	public PalazzoFollowPose()
	{
	}
}
[Token(Token = "0x20001E0")]
public class RotateAroundComponent : MonoBehaviour
{
	[Token(Token = "0x4000D30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000D31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool active;

	[NonSerialized]
	[Token(Token = "0x4000D32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool prevState;

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x838310", Offset = "0x838310", VA = "0x838310")]
	public RotateAroundComponent()
	{
	}
}
[Token(Token = "0x20001E1")]
public class TextGroup : MonoBehaviour
{
	[Token(Token = "0x4000D33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_Text[] texts;

	[Token(Token = "0x4000D34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool hasReformated;

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x838320", Offset = "0x838320", VA = "0x838320")]
	public void Update()
	{
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x838620", Offset = "0x838620", VA = "0x838620")]
	public TextGroup()
	{
	}
}
[Token(Token = "0x20001E2")]
public abstract class RGVersion
{
	[Token(Token = "0x4000D35")]
	public const string VERSION = "3.3.179993";

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x838628", Offset = "0x838628", VA = "0x838628")]
	protected RGVersion()
	{
	}
}
namespace RGCommon
{
	[Token(Token = "0x20001E3")]
	public static class SynthesizedAudio
	{
		[Token(Token = "0x20001E4")]
		private abstract class Generator
		{
			[Token(Token = "0x4000D37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly float frequency;

			[Token(Token = "0x4000D38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public readonly float amplitude;

			[Token(Token = "0x4000D39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			protected int position;

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x838858", Offset = "0x838858", VA = "0x838858")]
			public Generator(float frequency, float amplitude)
			{
			}

			[Token(Token = "0x60006DF")]
			public abstract void OnAudioRead(float[] data);

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x838884", Offset = "0x838884", VA = "0x838884")]
			public void OnAudioSetPosition(int newPosition)
			{
			}
		}

		[Token(Token = "0x20001E5")]
		private class SineGenerator : Generator
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x83882C", Offset = "0x83882C", VA = "0x83882C")]
			public SineGenerator(float frequency, float amplitude)
			{
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x83888C", Offset = "0x83888C", VA = "0x83888C", Slot = "4")]
			public override void OnAudioRead(float[] data)
			{
			}
		}

		[Token(Token = "0x4000D36")]
		private const int sampleRate = 44100;

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x838630", Offset = "0x838630", VA = "0x838630")]
		public static AudioClip GenerateSineBeep(float frequency, float amplitude, float lengthInSeconds)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20001E6")]
	public class BuildInformation
	{
		[Token(Token = "0x4000D3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string platform;

		[Token(Token = "0x4000D3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string versionString;

		[Token(Token = "0x4000D3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] versionArray;

		[Token(Token = "0x4000D3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int buildNumber;

		[Token(Token = "0x4000D3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool release;

		[Token(Token = "0x4000D3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool debug;

		[Token(Token = "0x4000D40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string targetDirectory;

		[Token(Token = "0x4000D41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool loaded;

		[Token(Token = "0x4000D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static BuildInformation instance;

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x838918", Offset = "0x838918", VA = "0x838918", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x838920", Offset = "0x838920", VA = "0x838920")]
		public static BuildInformation GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x838B7C", Offset = "0x838B7C", VA = "0x838B7C")]
		public int GetAndroidVersionCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x838BD4", Offset = "0x838BD4", VA = "0x838BD4")]
		public BuildInformation()
		{
		}
	}
	[Token(Token = "0x20001E7")]
	public class VersionDisplay : MonoBehaviour
	{
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x838BDC", Offset = "0x838BDC", VA = "0x838BDC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x838E24", Offset = "0x838E24", VA = "0x838E24")]
		public VersionDisplay()
		{
		}
	}
	[Token(Token = "0x20001E8")]
	public static class VersionInformation
	{
		[Token(Token = "0x1700004A")]
		public static string Version
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x838DD4", Offset = "0x838DD4", VA = "0x838DD4")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20001E9")]
	public static class BestMatch
	{
		[Token(Token = "0x60006EA")]
		public static void UpdateIfGreater<T>(ref T currentBest, ref float bestValue, T candidate, float candidateValue)
		{
		}

		[Token(Token = "0x60006EB")]
		public static void UpdateIfLess<T>(ref T currentBest, ref float bestValue, T candidate, float candidateValue)
		{
		}
	}
	[Token(Token = "0x20001EA")]
	public static class Collections
	{
		[Token(Token = "0x60006EC")]
		public static void Shuffle<T>(T[] values)
		{
		}

		[Token(Token = "0x60006ED")]
		public static void Shuffle<T>(List<T> values)
		{
		}
	}
	[Token(Token = "0x20001EB")]
	public class CSVTable
	{
		[Token(Token = "0x20001EC")]
		public struct Row
		{
			[Token(Token = "0x4000D48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int index;

			[Token(Token = "0x4000D49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Dictionary<string, int> headerIndexes;

			[Token(Token = "0x4000D4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string[] columns;

			[Token(Token = "0x1700004D")]
			public int Count
			{
				[Token(Token = "0x6000704")]
				[Address(RVA = "0x83A07C", Offset = "0x83A07C", VA = "0x83A07C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x839520", Offset = "0x839520", VA = "0x839520")]
			internal Row(int index, Dictionary<string, int> headerIndexes, string[] columns)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x839938", Offset = "0x839938", VA = "0x839938")]
			private void ValidateHeader(string header)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x839B74", Offset = "0x839B74", VA = "0x839B74")]
			private void ValidateIndex(int i)
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x839DAC", Offset = "0x839DAC", VA = "0x839DAC")]
			public bool HasValue(int i)
			{
				return default(bool);
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x839E00", Offset = "0x839E00", VA = "0x839E00")]
			public bool NotEmpty(string header)
			{
				return default(bool);
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x839E70", Offset = "0x839E70", VA = "0x839E70")]
			public string GetColumn(int i)
			{
				return null;
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x839EB4", Offset = "0x839EB4", VA = "0x839EB4")]
			public string GetColumn(string header)
			{
				return null;
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x839F24", Offset = "0x839F24", VA = "0x839F24")]
			public int GetColumnInt(string header)
			{
				return default(int);
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x839F38", Offset = "0x839F38", VA = "0x839F38")]
			public int GetColumnInt(int i)
			{
				return default(int);
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x839F4C", Offset = "0x839F4C", VA = "0x839F4C")]
			public float GetColumnFloat(string header)
			{
				return default(float);
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x839F60", Offset = "0x839F60", VA = "0x839F60")]
			public float GetColumnFloat(int i)
			{
				return default(float);
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x839F74", Offset = "0x839F74", VA = "0x839F74")]
			public bool GetColumnBool(string header)
			{
				return default(bool);
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x839FD8", Offset = "0x839FD8", VA = "0x839FD8")]
			public bool GetColumnBool(int i)
			{
				return default(bool);
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x83A098", Offset = "0x83A098", VA = "0x83A098")]
			public int Index()
			{
				return default(int);
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x83A0A0", Offset = "0x83A0A0", VA = "0x83A0A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x4000D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string path;

		[Token(Token = "0x4000D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isLoaded;

		[Token(Token = "0x4000D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Row[] rows;

		[Token(Token = "0x4000D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string[] headers;

		[Token(Token = "0x4000D47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, int> headerIndexes;

		[Token(Token = "0x1700004B")]
		public int NumRows
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x839694", Offset = "0x839694", VA = "0x839694")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		public int NumColumns
		{
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x8396B4", Offset = "0x8396B4", VA = "0x8396B4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x838E2C", Offset = "0x838E2C", VA = "0x838E2C")]
		public void LoadFromResources(string path)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x83952C", Offset = "0x83952C", VA = "0x83952C")]
		public string GetHeader(int i)
		{
			return null;
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x8395E4", Offset = "0x8395E4", VA = "0x8395E4")]
		public int GetHeaderIndex(string name)
		{
			return default(int);
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x83963C", Offset = "0x83963C", VA = "0x83963C")]
		public bool HasHeader(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x8396D0", Offset = "0x8396D0", VA = "0x8396D0")]
		public Row GetRow(int i)
		{
			return default(Row);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x839798", Offset = "0x839798", VA = "0x839798", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x839930", Offset = "0x839930", VA = "0x839930")]
		public CSVTable()
		{
		}
	}
	[Token(Token = "0x20001ED")]
	public class PerFrameCounter : MonoBehaviour
	{
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x83A184", Offset = "0x83A184", VA = "0x83A184")]
		[Conditional("UNITY_EDITOR")]
		public static void Add(string name, int amount = 1)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x83A188", Offset = "0x83A188", VA = "0x83A188")]
		public PerFrameCounter()
		{
		}
	}
	[Token(Token = "0x20001EE")]
	public class SpeedControl : MonoBehaviour
	{
		[Token(Token = "0x4000D4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool enableOnDevice;

		[Token(Token = "0x4000D4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public KeyCode activationKey;

		[Token(Token = "0x4000D4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedFactorWhenActivated;

		[Token(Token = "0x4000D4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool activated;

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x83A190", Offset = "0x83A190", VA = "0x83A190")]
		private void Start()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x83A19C", Offset = "0x83A19C", VA = "0x83A19C")]
		private void Update()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x83A1E4", Offset = "0x83A1E4", VA = "0x83A1E4")]
		public SpeedControl()
		{
		}
	}
	[Token(Token = "0x20001EF")]
	public class ToggleActive : MonoBehaviour
	{
		[Token(Token = "0x4000D4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] objects;

		[Token(Token = "0x4000D50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public KeyCode key;

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x83A1FC", Offset = "0x83A1FC", VA = "0x83A1FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x83A288", Offset = "0x83A288", VA = "0x83A288")]
		public ToggleActive()
		{
		}
	}
	[Token(Token = "0x20001F0")]
	public class CameraControl : MonoBehaviour
	{
		[Token(Token = "0x20001F1")]
		private struct Pose
		{
			[Token(Token = "0x4000D60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x4000D61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x83B14C", Offset = "0x83B14C", VA = "0x83B14C")]
			public Pose(Vector3 position, Quaternion rotation)
			{
			}
		}

		[Token(Token = "0x4000D51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The size of one step. (Can be scaled with the shift/ctrl/alt keys.)")]
		public float stepSize;

		[Token(Token = "0x4000D52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("In desktop mode, move smoothly instead of in discrete steps")]
		public bool smoothOnDesktop;

		[Token(Token = "0x4000D53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("When moving smoothly, move at this speed")]
		public float smoothMovementSpeed;

		[Token(Token = "0x4000D54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private new Transform transform;

		[Token(Token = "0x4000D55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Camera camera;

		[Token(Token = "0x4000D56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform cameraTransform;

		[Token(Token = "0x4000D57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private InputDevice hmdDevice;

		[Token(Token = "0x4000D58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] stepSizes;

		[Token(Token = "0x4000D59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] rotationAngles;

		[Token(Token = "0x4000D5A")]
		private const float mouseSpeed = 2f;

		[Token(Token = "0x4000D5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool mouseEnabled;

		[Token(Token = "0x4000D5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool userIsWearingHeadset;

		[Token(Token = "0x4000D5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool desktopMode;

		[Token(Token = "0x4000D5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Pose? poseInDesktopMode;

		[Token(Token = "0x4000D5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Pose? poseInXRMode;

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x83A298", Offset = "0x83A298", VA = "0x83A298")]
		public bool IsDesktopMode()
		{
			return default(bool);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x83A2A0", Offset = "0x83A2A0", VA = "0x83A2A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x83A360", Offset = "0x83A360", VA = "0x83A360")]
		private void Update()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x83AC4C", Offset = "0x83AC4C", VA = "0x83AC4C")]
		private bool IsUserPresent()
		{
			return default(bool);
		}

		[Token(Token = "0x6000712")]
		private T GetKeyAmount<T>(KeyCode key, T value)
		{
			return (T)null;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x83AD08", Offset = "0x83AD08", VA = "0x83AD08")]
		private void SetDesktopMode(bool newDesktopMode)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x83B018", Offset = "0x83B018", VA = "0x83B018")]
		private void SetTrackingEnabled(bool enable)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x83B078", Offset = "0x83B078", VA = "0x83B078")]
		public CameraControl()
		{
		}
	}
	[Token(Token = "0x20001F2")]
	public class CaptureCamera : MonoBehaviour
	{
		[Token(Token = "0x20001F3")]
		public enum FileFormat
		{
			[Token(Token = "0x4000D68")]
			PNG,
			[Token(Token = "0x4000D69")]
			PNGWithAlpha,
			[Token(Token = "0x4000D6A")]
			JPG,
			[Token(Token = "0x4000D6B")]
			EXR
		}

		[Token(Token = "0x4000D62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Name of input in InputManager that triggers capturing the camera")]
		public string inputName;

		[Token(Token = "0x4000D63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2Int resolution;

		[Token(Token = "0x4000D64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FileFormat fileFormat;

		[Token(Token = "0x4000D65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string[] extensions;

		[Token(Token = "0x4000D66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Camera to capture. Default is main camera")]
		public Camera cameraToCapture;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x83B160", Offset = "0x83B160", VA = "0x83B160")]
		public void Update()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x83B368", Offset = "0x83B368", VA = "0x83B368")]
		private void Capture(Camera cam)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x83B768", Offset = "0x83B768", VA = "0x83B768")]
		private TextureFormat GetTargetTextureFormat()
		{
			return default(TextureFormat);
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x83B78C", Offset = "0x83B78C", VA = "0x83B78C")]
		public CaptureCamera()
		{
		}
	}
	[Token(Token = "0x20001F4")]
	public class EditorCameraControl : MonoBehaviour
	{
		[Token(Token = "0x4000D6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float mouseSpeed;

		[Token(Token = "0x4000D6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxKeyboardRotation;

		[Token(Token = "0x4000D6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public KeyCode freezeKey;

		[Token(Token = "0x4000D6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float touchRotationSpeed;

		[Token(Token = "0x4000D70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float keyboardRotationSpeed;

		[Token(Token = "0x4000D71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public KeyCode turnLeftKey;

		[Token(Token = "0x4000D72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public KeyCode turnRightKey;

		[Token(Token = "0x4000D73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public KeyCode lookUpKey;

		[Token(Token = "0x4000D74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public KeyCode lookDownKey;

		[Token(Token = "0x4000D75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public KeyCode recenterKey;

		[Token(Token = "0x4000D76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool startMouseEnabled;

		[Token(Token = "0x4000D77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("If set, rotate the camera in the opposite direction of this object's orientation to disable head rotation tracking")]
		public Transform vrHead;

		[Token(Token = "0x4000D78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion startRotation;

		[Token(Token = "0x4000D79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 currentRotation;

		[Token(Token = "0x4000D7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3? currentPosition;

		[Token(Token = "0x4000D7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool mouseEnabled;

		[Token(Token = "0x4000D7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private XRInputSubsystem XRInputSubsystem;

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x83B94C", Offset = "0x83B94C", VA = "0x83B94C")]
		private void Start()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x83B9E4", Offset = "0x83B9E4", VA = "0x83B9E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x83BA40", Offset = "0x83BA40", VA = "0x83BA40")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x83BA6C", Offset = "0x83BA6C", VA = "0x83BA6C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x83BA88", Offset = "0x83BA88", VA = "0x83BA88")]
		public void SetPosition(Vector3 localPosition)
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x83BB60", Offset = "0x83BB60", VA = "0x83BB60")]
		private void Update()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x83BFC8", Offset = "0x83BFC8", VA = "0x83BFC8")]
		public EditorCameraControl()
		{
		}
	}
	[Token(Token = "0x20001F5")]
	public class Fader : MonoBehaviour
	{
		[Token(Token = "0x4000D7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float targetAlpha;

		[Token(Token = "0x4000D7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fadeTime;

		[Token(Token = "0x4000D7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader fadeShader;

		[Token(Token = "0x4000D80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color color;

		[Token(Token = "0x4000D81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected float currentAlpha;

		[Token(Token = "0x4000D82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fadeMaterial;

		[Token(Token = "0x1700004E")]
		public bool Done
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x83C020", Offset = "0x83C020", VA = "0x83C020")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x83C00C", Offset = "0x83C00C", VA = "0x83C00C")]
		public void FadeIn()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x83C014", Offset = "0x83C014", VA = "0x83C014")]
		public void FadeOut()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x83C034", Offset = "0x83C034", VA = "0x83C034")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x83C200", Offset = "0x83C200", VA = "0x83C200")]
		private void Start()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x83C20C", Offset = "0x83C20C", VA = "0x83C20C")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x83C0B4", Offset = "0x83C0B4", VA = "0x83C0B4")]
		private void Setup()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x83C210", Offset = "0x83C210", VA = "0x83C210")]
		private void Update()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x83C29C", Offset = "0x83C29C", VA = "0x83C29C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x83C340", Offset = "0x83C340", VA = "0x83C340")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x83C3E4", Offset = "0x83C3E4", VA = "0x83C3E4")]
		private void SceneWasLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x83C3EC", Offset = "0x83C3EC", VA = "0x83C3EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x83C47C", Offset = "0x83C47C", VA = "0x83C47C")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x83C55C", Offset = "0x83C55C", VA = "0x83C55C")]
		public Fader()
		{
		}
	}
	[Token(Token = "0x20001F6")]
	public class FpsDisplay : MonoBehaviour
	{
		[Token(Token = "0x4000D83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float updateInterval;

		[Token(Token = "0x4000D84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public KeyCode toggleKey;

		[Token(Token = "0x4000D85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool visible;

		[Token(Token = "0x4000D86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float warningTime;

		[Token(Token = "0x4000D87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color standardColor;

		[Token(Token = "0x4000D88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color warningColor;

		[Token(Token = "0x4000D89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMesh textMesh;

		[Token(Token = "0x4000D8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Renderer rendererComponent;

		[Token(Token = "0x4000D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int frameCount;

		[Token(Token = "0x4000D8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int warningCount;

		[Token(Token = "0x4000D8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float elapsed;

		[Token(Token = "0x4000D8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float fps;

		[Token(Token = "0x4000D8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float msPerFrame;

		[Token(Token = "0x4000D90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float maxTime;

		[Token(Token = "0x4000D91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float minTime;

		[Token(Token = "0x4000D92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string text;

		[Token(Token = "0x4000D93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float lastUpdate;

		[Token(Token = "0x4000D94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float collectionStartTime;

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x83C578", Offset = "0x83C578", VA = "0x83C578")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x83C5F4", Offset = "0x83C5F4", VA = "0x83C5F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x83C648", Offset = "0x83C648", VA = "0x83C648")]
		private void Update()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x83C778", Offset = "0x83C778", VA = "0x83C778")]
		public void ToggleVisibility()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x83C7C4", Offset = "0x83C7C4", VA = "0x83C7C4")]
		private void UpdateDisplay()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x83C9F8", Offset = "0x83C9F8", VA = "0x83C9F8")]
		public FpsDisplay()
		{
		}
	}
	[Token(Token = "0x20001F7")]
	public class Screenshot : MonoBehaviour
	{
		[Token(Token = "0x4000D95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode screenshotKey;

		[Token(Token = "0x4000D96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int superSize;

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x83CA34", Offset = "0x83CA34", VA = "0x83CA34")]
		public void Start()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x83CA8C", Offset = "0x83CA8C", VA = "0x83CA8C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x83CB58", Offset = "0x83CB58", VA = "0x83CB58")]
		public static string ScreenShotName()
		{
			return null;
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x83CAB8", Offset = "0x83CAB8", VA = "0x83CAB8")]
		public void TakeScreenshot()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x83CC00", Offset = "0x83CC00", VA = "0x83CC00")]
		public Screenshot()
		{
		}
	}
	[Token(Token = "0x20001F8")]
	public static class Find
	{
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x83CC14", Offset = "0x83CC14", VA = "0x83CC14")]
		public static GameObject ChildByName(Component tag, string path)
		{
			return null;
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x83CD74", Offset = "0x83CD74", VA = "0x83CD74")]
		public static GameObject ChildByName(object tag, GameObject go, string path)
		{
			return null;
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x83CDBC", Offset = "0x83CDBC", VA = "0x83CDBC")]
		public static Transform ChildTransformByName(Component tag, string path)
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x83CDF4", Offset = "0x83CDF4", VA = "0x83CDF4")]
		public static Transform ChildTransformByName(object tag, Transform go, string path)
		{
			return null;
		}

		[Token(Token = "0x6000740")]
		public static T ComponentOnGameObject<T>(Component tag) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000741")]
		public static T ComponentOnGameObject<T>(GameObject tag) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000742")]
		public static T ComponentOnGameObject<T>(object tag, GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000743")]
		public static T ComponentOrCreate<T>(GameObject gameObject) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000744")]
		public static T ComponentOnChild<T>(Component tag, string path) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000745")]
		public static T ComponentOnChild<T>(object tag, GameObject go, string path) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000746")]
		public static T ComponentInChildren<T>(Component tag) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000747")]
		public static T ComponentInChildren<T>(object tag, GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000748")]
		public static T ComponentOrNull<T>(GameObject container) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000749")]
		public static List<T> ComponentsInActiveScene<T>(bool includeInactive) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600074A")]
		public static List<T> ComponentsInScene<T>(Scene scene, bool includeInactive) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x83CC58", Offset = "0x83CC58", VA = "0x83CC58")]
		private static Transform InternalFindChildByName(object tag, Transform transform, string path)
		{
			return null;
		}

		[Token(Token = "0x600074C")]
		private static T InternalFindComponentOnGameObject<T>(object tag, GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600074D")]
		private static T InternalFindComponentOnChild<T>(object tag, GameObject go, string path) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600074E")]
		private static T InternalFindComponentInChildren<T>(object tag, GameObject go)
		{
			return (T)null;
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x83CDF8", Offset = "0x83CDF8", VA = "0x83CDF8")]
		private static string FormatError(string template, object tag, GameObject go, string path, Type t, string reason)
		{
			return null;
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x83CE38", Offset = "0x83CE38", VA = "0x83CE38")]
		private static string FormatTag(object theTag)
		{
			return null;
		}
	}
	[Token(Token = "0x20001F9")]
	public static class ComponentValidation
	{
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x83CF6C", Offset = "0x83CF6C", VA = "0x83CF6C")]
		public static bool DisableIfNull(MonoBehaviour component, object attributeValue, string attributeName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x83D144", Offset = "0x83D144", VA = "0x83D144")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void FailIfNull(object component, object attributeValue, string attributeName)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x83D0A4", Offset = "0x83D0A4", VA = "0x83D0A4")]
		public static bool IsNull(object o)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001FA")]
	public class DontDestroyOnLoad : MonoBehaviour
	{
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x83D30C", Offset = "0x83D30C", VA = "0x83D30C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x83D378", Offset = "0x83D378", VA = "0x83D378")]
		public DontDestroyOnLoad()
		{
		}
	}
	[Token(Token = "0x20001FB")]
	public class Loader : MonoBehaviour
	{
		[Token(Token = "0x20001FC")]
		[CompilerGenerated]
		private sealed class <Start>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000D99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000D9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000D9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			[Token(Token = "0x4000D9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Fader[] <faders>5__2;

			[Token(Token = "0x4000D9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startTime>5__3;

			[Token(Token = "0x4000D9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private AsyncOperation <async>5__4;

			[Token(Token = "0x1700004F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600075B")]
				[Address(RVA = "0x83D78C", Offset = "0x83D78C", VA = "0x83D78C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000050")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600075D")]
				[Address(RVA = "0x83D7D4", Offset = "0x83D7D4", VA = "0x83D7D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x83D3E8", Offset = "0x83D3E8", VA = "0x83D3E8")]
			[DebuggerHidden]
			public <Start>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x83D418", Offset = "0x83D418", VA = "0x83D418", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x83D41C", Offset = "0x83D41C", VA = "0x83D41C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x83D794", Offset = "0x83D794", VA = "0x83D794", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000D97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string scene;

		[Token(Token = "0x4000D98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minimumTime;

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x83D380", Offset = "0x83D380", VA = "0x83D380")]
		[IteratorStateMachine(typeof(<Start>d__2))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x83D410", Offset = "0x83D410", VA = "0x83D410")]
		public Loader()
		{
		}
	}
	[Token(Token = "0x20001FD")]
	public struct ObjectAndTransform
	{
		[Token(Token = "0x4000D9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly GameObject gameObject;

		[Token(Token = "0x4000DA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly Transform transform;

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x83D7DC", Offset = "0x83D7DC", VA = "0x83D7DC")]
		public ObjectAndTransform(GameObject obj)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x83D808", Offset = "0x83D808", VA = "0x83D808")]
		public ObjectAndTransform(Transform t)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x83D83C", Offset = "0x83D83C", VA = "0x83D83C")]
		public ObjectAndTransform(GameObject obj, Transform t)
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x83D870", Offset = "0x83D870", VA = "0x83D870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x83D8DC", Offset = "0x83D8DC", VA = "0x83D8DC")]
		public bool IsNull()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001FE")]
	public class SingleInstanceBehavior<T> : MonoBehaviour where T : SingleInstanceBehavior<T>
	{
		[Token(Token = "0x4000DA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T instance;

		[Token(Token = "0x4000DA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string noInstanceMessage;

		[Token(Token = "0x17000051")]
		public static T Instance
		{
			[Token(Token = "0x6000766")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000763")]
		static SingleInstanceBehavior()
		{
		}

		[Token(Token = "0x6000764")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x6000765")]
		public virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000767")]
		public static T GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000768")]
		public SingleInstanceBehavior()
		{
		}
	}
	[Token(Token = "0x20001FF")]
	public class Singleton<T> where T : Singleton<T>, new()
	{
		[Token(Token = "0x4000DA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T instance;

		[Token(Token = "0x17000052")]
		public static T Instance
		{
			[Token(Token = "0x600076A")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000769")]
		public Singleton()
		{
		}

		[Token(Token = "0x600076B")]
		public static T GetInstance()
		{
			return null;
		}
	}
	[Token(Token = "0x2000200")]
	public class SingletonBehavior<T> : MonoBehaviour where T : SingletonBehavior<T>
	{
		[Token(Token = "0x4000DA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T instance;

		[Token(Token = "0x17000053")]
		public static T Instance
		{
			[Token(Token = "0x600076E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600076C")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x600076D")]
		public virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600076F")]
		public static T GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000770")]
		public SingletonBehavior()
		{
		}
	}
	[Token(Token = "0x2000201")]
	public class Locale : Singleton<Locale>
	{
		[Token(Token = "0x4000DA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string language;

		[Token(Token = "0x4000DA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string country;

		[Token(Token = "0x4000DA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string explicitlySetLocale;

		[Token(Token = "0x4000DA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string currentLocale;

		[Token(Token = "0x4000DA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string[] availableLocales;

		[Token(Token = "0x4000DAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string[] stringIDs;

		[Token(Token = "0x4000DAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> strings;

		[Token(Token = "0x4000DAC")]
		private const string resourceFolder = "Text";

		[Token(Token = "0x4000DAD")]
		private const string binaryResourceSuffix = "_Strings";

		[Token(Token = "0x4000DAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, string> countrySpecificLocales;

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x83D93C", Offset = "0x83D93C", VA = "0x83D93C")]
		public Locale()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x83E12C", Offset = "0x83E12C", VA = "0x83E12C")]
		public string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x83E1BC", Offset = "0x83E1BC", VA = "0x83E1BC")]
		public bool TryGetString(string key, out string localized)
		{
			return default(bool);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x83E24C", Offset = "0x83E24C", VA = "0x83E24C")]
		public string Format(string key, params object[] templateArguments)
		{
			return null;
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x83E40C", Offset = "0x83E40C", VA = "0x83E40C")]
		public bool TryFormat(string key, out string localized, params object[] templateArguments)
		{
			return default(bool);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x83E5F0", Offset = "0x83E5F0", VA = "0x83E5F0")]
		public string GetDefaultLanguageOrLocale()
		{
			return null;
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x83E60C", Offset = "0x83E60C", VA = "0x83E60C")]
		public string GetDefaultCountry()
		{
			return null;
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x83E614", Offset = "0x83E614", VA = "0x83E614")]
		public string GetCurrentLocale()
		{
			return null;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x83E61C", Offset = "0x83E61C", VA = "0x83E61C")]
		public void SetLocale(string localeCode)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x83E624", Offset = "0x83E624", VA = "0x83E624")]
		public string[] GetAvailableLocales()
		{
			return null;
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x83DDF8", Offset = "0x83DDF8", VA = "0x83DDF8")]
		public string GetLocale(string[] availableLocales)
		{
			return null;
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x83E654", Offset = "0x83E654", VA = "0x83E654")]
		public string[] GetStringIDs()
		{
			return null;
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x83E6B0", Offset = "0x83E6B0", VA = "0x83E6B0")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x83D9AC", Offset = "0x83D9AC", VA = "0x83D9AC")]
		private void LoadAvailableLocales()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x83E00C", Offset = "0x83E00C", VA = "0x83E00C")]
		private void LoadStrings()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x83E6C8", Offset = "0x83E6C8", VA = "0x83E6C8")]
		private bool TryLoadStrings()
		{
			return default(bool);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x83E808", Offset = "0x83E808", VA = "0x83E808")]
		private bool TryLoadStringsFromBinaryAssets()
		{
			return default(bool);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x83DB28", Offset = "0x83DB28", VA = "0x83DB28")]
		private void SetDefaultLanguageAndCountry()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x83EAE4", Offset = "0x83EAE4", VA = "0x83EAE4")]
		[Obsolete("GetLanguage is deprecated, use GetResourceLocale instead.")]
		public string GetLanguage()
		{
			return null;
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x83EAEC", Offset = "0x83EAEC", VA = "0x83EAEC")]
		[Obsolete("SetLanguage is deprecated, use SetLocale instead.")]
		public void SetLanguage(string languageCode)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x83EAF4", Offset = "0x83EAF4", VA = "0x83EAF4")]
		[Obsolete("GetAvailableLanguages is deprecated, use GetAvailableLocales instead.")]
		public string[] GetAvailableLanguages()
		{
			return null;
		}
	}
	[Token(Token = "0x2000202")]
	public class LocaleFonts : SingleInstanceBehavior<LocaleFonts>
	{
		[Serializable]
		[Token(Token = "0x2000203")]
		public class Settings
		{
			[Token(Token = "0x4000DB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Locale code (language or language-region)")]
			public string locale;

			[Token(Token = "0x4000DB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The font to use for text in this locale")]
			public Font font;

			[Token(Token = "0x4000DB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The TMPro font to use for text in this locale")]
			public TMP_FontAsset fontTMPro;

			[Token(Token = "0x4000DB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Optional material applied only on TMPro GUI components, use to fix the TMPro UGUI disappears bug.")]
			public Material materialTMProGUI;

			[Token(Token = "0x4000DB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The size of the text relative to the original font")]
			public float scale;

			[Token(Token = "0x6000789")]
			[Address(RVA = "0x83F128", Offset = "0x83F128", VA = "0x83F128")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x4000DAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Locales that should use a specific font")]
		private Settings[] localeSettings;

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x83EFDC", Offset = "0x83EFDC", VA = "0x83EFDC")]
		public Settings GetCurrentLocaleSettings()
		{
			return null;
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x83F0BC", Offset = "0x83F0BC", VA = "0x83F0BC")]
		public LocaleFonts()
		{
		}
	}
	[Token(Token = "0x2000204")]
	[DisallowMultipleComponent]
	public class LocalizedText : MonoBehaviour
	{
		[Token(Token = "0x2000205")]
		private struct FontProxy
		{
			[Token(Token = "0x4000DBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Font font;

			[Token(Token = "0x4000DBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public TMP_FontAsset fontTMPro;

			[Token(Token = "0x4000DBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material materialTMProGUI;
		}

		[Token(Token = "0x2000206")]
		private interface ITextComponent
		{
			[Token(Token = "0x17000054")]
			string Text
			{
				[Token(Token = "0x6000794")]
				get;
				[Token(Token = "0x6000795")]
				set;
			}

			[Token(Token = "0x17000055")]
			FontProxy Font
			{
				[Token(Token = "0x6000796")]
				get;
				[Token(Token = "0x6000797")]
				set;
			}

			[Token(Token = "0x17000056")]
			float FontSize
			{
				[Token(Token = "0x6000798")]
				get;
				[Token(Token = "0x6000799")]
				set;
			}
		}

		[Token(Token = "0x2000207")]
		private sealed class TextComponent : ITextComponent
		{
			[Token(Token = "0x4000DC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Text textComponent;

			[Token(Token = "0x17000057")]
			public string Text
			{
				[Token(Token = "0x600079B")]
				[Address(RVA = "0x84007C", Offset = "0x84007C", VA = "0x84007C", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600079C")]
				[Address(RVA = "0x8400A0", Offset = "0x8400A0", VA = "0x8400A0", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x17000058")]
			public FontProxy Font
			{
				[Token(Token = "0x600079D")]
				[Address(RVA = "0x8400C4", Offset = "0x8400C4", VA = "0x8400C4", Slot = "6")]
				get
				{
					return default(FontProxy);
				}
				[Token(Token = "0x600079E")]
				[Address(RVA = "0x840100", Offset = "0x840100", VA = "0x840100", Slot = "7")]
				set
				{
				}
			}

			[Token(Token = "0x17000059")]
			public float FontSize
			{
				[Token(Token = "0x600079F")]
				[Address(RVA = "0x840120", Offset = "0x840120", VA = "0x840120", Slot = "8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007A0")]
				[Address(RVA = "0x840144", Offset = "0x840144", VA = "0x840144", Slot = "9")]
				set
				{
				}
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x83FF78", Offset = "0x83FF78", VA = "0x83FF78")]
			public TextComponent(Text text)
			{
			}
		}

		[Token(Token = "0x2000208")]
		private sealed class TextMeshComponent : ITextComponent
		{
			[Token(Token = "0x4000DC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly TextMesh textComponent;

			[Token(Token = "0x1700005A")]
			public string Text
			{
				[Token(Token = "0x60007A2")]
				[Address(RVA = "0x840238", Offset = "0x840238", VA = "0x840238", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007A3")]
				[Address(RVA = "0x840254", Offset = "0x840254", VA = "0x840254", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x1700005B")]
			public FontProxy Font
			{
				[Token(Token = "0x60007A4")]
				[Address(RVA = "0x840270", Offset = "0x840270", VA = "0x840270", Slot = "6")]
				get
				{
					return default(FontProxy);
				}
				[Token(Token = "0x60007A5")]
				[Address(RVA = "0x8402AC", Offset = "0x8402AC", VA = "0x8402AC", Slot = "7")]
				set
				{
				}
			}

			[Token(Token = "0x1700005C")]
			public float FontSize
			{
				[Token(Token = "0x60007A6")]
				[Address(RVA = "0x8402CC", Offset = "0x8402CC", VA = "0x8402CC", Slot = "8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007A7")]
				[Address(RVA = "0x8402F0", Offset = "0x8402F0", VA = "0x8402F0", Slot = "9")]
				set
				{
				}
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x83FFA0", Offset = "0x83FFA0", VA = "0x83FFA0")]
			public TextMeshComponent(TextMesh text)
			{
			}
		}

		[Token(Token = "0x2000209")]
		private sealed class TextComponentTMPro : ITextComponent
		{
			[Token(Token = "0x4000DC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly TMP_Text textComponent;

			[Token(Token = "0x1700005D")]
			public string Text
			{
				[Token(Token = "0x60007A9")]
				[Address(RVA = "0x8403E4", Offset = "0x8403E4", VA = "0x8403E4", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007AA")]
				[Address(RVA = "0x840408", Offset = "0x840408", VA = "0x840408", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x1700005E")]
			public FontProxy Font
			{
				[Token(Token = "0x60007AB")]
				[Address(RVA = "0x84042C", Offset = "0x84042C", VA = "0x84042C", Slot = "6")]
				get
				{
					return default(FontProxy);
				}
				[Token(Token = "0x60007AC")]
				[Address(RVA = "0x840450", Offset = "0x840450", VA = "0x840450", Slot = "7")]
				set
				{
				}
			}

			[Token(Token = "0x1700005F")]
			public float FontSize
			{
				[Token(Token = "0x60007AD")]
				[Address(RVA = "0x840570", Offset = "0x840570", VA = "0x840570", Slot = "8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007AE")]
				[Address(RVA = "0x84058C", Offset = "0x84058C", VA = "0x84058C", Slot = "9")]
				set
				{
				}
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x83FFC8", Offset = "0x83FFC8", VA = "0x83FFC8")]
			public TextComponentTMPro(TMP_Text text)
			{
			}
		}

		[Token(Token = "0x4000DB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string stringID;

		[Token(Token = "0x4000DB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool shouldUpdateFont;

		[Token(Token = "0x4000DB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ITextComponent textComponent;

		[Token(Token = "0x4000DB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string[] templateArguments;

		[Token(Token = "0x4000DB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int?[] templateArgumentsInts;

		[Token(Token = "0x4000DBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool fontOverridden;

		[Token(Token = "0x4000DBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FontProxy? originalFont;

		[Token(Token = "0x4000DBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float originalFontSize;

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x83F138", Offset = "0x83F138", VA = "0x83F138")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x83FC78", Offset = "0x83FC78", VA = "0x83FC78")]
		private void Start()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x83FC98", Offset = "0x83FC98", VA = "0x83FC98")]
		public void ShowString(string stringID)
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x83FCA0", Offset = "0x83FCA0", VA = "0x83FCA0")]
		public void SetTemplateArgument(int index, string value)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x83FD74", Offset = "0x83FD74", VA = "0x83FD74")]
		public void SetTemplateArgument(int index, int value)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x83FEB8", Offset = "0x83FEB8", VA = "0x83FEB8")]
		public void ShowRawText(string text)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x83F4B8", Offset = "0x83F4B8", VA = "0x83F4B8")]
		public void UpdateText()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x83F758", Offset = "0x83F758", VA = "0x83F758")]
		public void UpdateFont()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x83F158", Offset = "0x83F158", VA = "0x83F158")]
		private void FindComponents()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x83FFF0", Offset = "0x83FFF0", VA = "0x83FFF0")]
		public LocalizedText()
		{
		}
	}
	[Token(Token = "0x200020A")]
	public struct SeparatedStringReader
	{
		[Token(Token = "0x4000DC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte[] bytes;

		[Token(Token = "0x4000DC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int index;

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x83EA04", Offset = "0x83EA04", VA = "0x83EA04")]
		public SeparatedStringReader(byte[] bytes, int startingIndex = 0)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x83EABC", Offset = "0x83EABC", VA = "0x83EABC")]
		public bool HasNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x83EA10", Offset = "0x83EA10", VA = "0x83EA10")]
		public string GetNext()
		{
			return null;
		}
	}
	[Token(Token = "0x200020B")]
	public class TextTemplateDemo : MonoBehaviour
	{
		[Token(Token = "0x4000DC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool useIntegerArgument;

		[Token(Token = "0x4000DC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int number;

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x8405A8", Offset = "0x8405A8", VA = "0x8405A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x840678", Offset = "0x840678", VA = "0x840678")]
		public TextTemplateDemo()
		{
		}
	}
	[Token(Token = "0x200020C")]
	public class Translations : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200020D")]
		public struct StringEntry
		{
			[Token(Token = "0x4000DC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string id;

			[Token(Token = "0x4000DC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string translation;
		}

		[Token(Token = "0x4000DC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StringEntry[] entries;

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x840688", Offset = "0x840688", VA = "0x840688")]
		public Translations()
		{
		}
	}
	[Token(Token = "0x200020E")]
	public static class Interpolation
	{
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x840690", Offset = "0x840690", VA = "0x840690")]
		public static float EaseInEaseOut(float progress, int depth)
		{
			return default(float);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x8406EC", Offset = "0x8406EC", VA = "0x8406EC")]
		public static bool ProgressOverTime(float startTime, float totalTime, ref float progress)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200020F")]
	public abstract class TwoD
	{
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x840758", Offset = "0x840758", VA = "0x840758")]
		public static bool TriangleIsInBounds(Rect bounds, Vector2 p0, Vector2 p1, Vector2 p2)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x840BDC", Offset = "0x840BDC", VA = "0x840BDC")]
		public static bool TriangleContainsPoint(Vector2 vertex0, Vector2 vertex1, Vector2 vertex2, Vector2 point)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x840C94", Offset = "0x840C94", VA = "0x840C94")]
		public static bool PointsOnSameSide(Vector2 line0, Vector2 line1, Vector2 point0, Vector2 point1)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x840D10", Offset = "0x840D10", VA = "0x840D10")]
		public static Vector3 ToBarycentric(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x840CE0", Offset = "0x840CE0", VA = "0x840CE0")]
		public static float Determinant(Vector2 p0, Vector2 p1, Vector2 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x8408E8", Offset = "0x8408E8", VA = "0x8408E8")]
		public static bool TriangleIntersectsRectangle(Vector2 vertex0, Vector2 vertex1, Vector2 vertex2, Rect rect)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x840D68", Offset = "0x840D68", VA = "0x840D68")]
		[Obsolete("Use VectorExtensions.SwizzleXZ instead")]
		public static Vector2 SwizzleXZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x840D70", Offset = "0x840D70", VA = "0x840D70")]
		protected TwoD()
		{
		}
	}
	[Token(Token = "0x2000210")]
	public class MeasurePoint : MonoBehaviour
	{
		[Token(Token = "0x4000DCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int nextNumber;

		[Token(Token = "0x4000DCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int number;

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x840D78", Offset = "0x840D78", VA = "0x840D78")]
		public MeasurePoint()
		{
		}
	}
	[Token(Token = "0x2000211")]
	public class DummyEvent : Tracking.TrackingEvent
	{
		[Token(Token = "0x4000DCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static DummyEvent instance;

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x840D80", Offset = "0x840D80", VA = "0x840D80", Slot = "6")]
		public Tracking.TrackingEvent AddParameter(string name, float value)
		{
			return null;
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x840D84", Offset = "0x840D84", VA = "0x840D84", Slot = "8")]
		public Tracking.TrackingEvent AddParameter(string name, bool value)
		{
			return null;
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x840D88", Offset = "0x840D88", VA = "0x840D88", Slot = "7")]
		public Tracking.TrackingEvent AddParameter(string name, double value)
		{
			return null;
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x840D8C", Offset = "0x840D8C", VA = "0x840D8C", Slot = "5")]
		public Tracking.TrackingEvent AddParameter(string name, int value)
		{
			return null;
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x840D90", Offset = "0x840D90", VA = "0x840D90", Slot = "4")]
		public Tracking.TrackingEvent AddParameter(string name, string value)
		{
			return null;
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x840D94", Offset = "0x840D94", VA = "0x840D94", Slot = "9")]
		public void Submit()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x840D98", Offset = "0x840D98", VA = "0x840D98", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x840DD8", Offset = "0x840DD8", VA = "0x840DD8")]
		public DummyEvent()
		{
		}
	}
	[Token(Token = "0x2000212")]
	public class ErrorCheckingTracker : Tracking.Tracker
	{
		[Token(Token = "0x2000213")]
		public class Failure : ApplicationException
		{
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x841038", Offset = "0x841038", VA = "0x841038")]
			public Failure(string message)
			{
			}
		}

		[Token(Token = "0x2000214")]
		private class ErrorCheckingEvent : Tracking.TrackingEvent
		{
			[Token(Token = "0x4000DCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string eventName;

			[Token(Token = "0x4000DCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Dictionary<string, string> parameters;

			[Token(Token = "0x4000DD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool revenueSet;

			[Token(Token = "0x4000DD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool isSubmitted;

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x841040", Offset = "0x841040", VA = "0x841040")]
			public ErrorCheckingEvent(string eventName)
			{
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x8410D8", Offset = "0x8410D8", VA = "0x8410D8", Slot = "4")]
			public Tracking.TrackingEvent AddParameter(string name, string value)
			{
				return null;
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x841380", Offset = "0x841380", VA = "0x841380", Slot = "6")]
			public Tracking.TrackingEvent AddParameter(string name, float value)
			{
				return null;
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x8413C0", Offset = "0x8413C0", VA = "0x8413C0", Slot = "7")]
			public Tracking.TrackingEvent AddParameter(string name, double value)
			{
				return null;
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x841400", Offset = "0x841400", VA = "0x841400", Slot = "5")]
			public Tracking.TrackingEvent AddParameter(string name, int value)
			{
				return null;
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x841440", Offset = "0x841440", VA = "0x841440", Slot = "8")]
			public Tracking.TrackingEvent AddParameter(string name, bool value)
			{
				return null;
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x841484", Offset = "0x841484", VA = "0x841484", Slot = "9")]
			public void Submit()
			{
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x84151C", Offset = "0x84151C", VA = "0x84151C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x4000DCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ErrorCheckingEvent currentEvent;

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x840E44", Offset = "0x840E44", VA = "0x840E44", Slot = "4")]
		public Tracking.TrackingEvent Track(string eventName)
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x8410D0", Offset = "0x8410D0", VA = "0x8410D0")]
		public ErrorCheckingTracker()
		{
		}
	}
	[Token(Token = "0x2000215")]
	public class FirebaseTracking : MonoBehaviour, Tracking.Tracker
	{
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x841568", Offset = "0x841568", VA = "0x841568", Slot = "4")]
		private Tracking.TrackingEvent RGCommon.Tracking.Tracker.Track(string eventName)
		{
			return null;
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x8415B8", Offset = "0x8415B8", VA = "0x8415B8")]
		public FirebaseTracking()
		{
		}
	}
	[Token(Token = "0x2000216")]
	public class HTTPTracking : MonoBehaviour, Tracking.Tracker, Tracking.TrackingEvent
	{
		[Token(Token = "0x2000217")]
		private struct Timing
		{
			[Token(Token = "0x4000DE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float time;

			[Token(Token = "0x4000DE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float variation;
		}

		[Token(Token = "0x2000218")]
		[CompilerGenerated]
		private sealed class <Quit>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000DE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000DE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000DE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HTTPTracking <>4__this;

			[Token(Token = "0x17000060")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007EF")]
				[Address(RVA = "0x8427E0", Offset = "0x8427E0", VA = "0x8427E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000061")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F1")]
				[Address(RVA = "0x842828", Offset = "0x842828", VA = "0x842828", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x8423A4", Offset = "0x8423A4", VA = "0x8423A4")]
			[DebuggerHidden]
			public <Quit>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x8426DC", Offset = "0x8426DC", VA = "0x8426DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x8426E0", Offset = "0x8426E0", VA = "0x8426E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x8427E8", Offset = "0x8427E8", VA = "0x8427E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000219")]
		[CompilerGenerated]
		private sealed class <Start>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000DEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000DEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000DEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HTTPTracking <>4__this;

			[Token(Token = "0x4000DED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <nextSendTime>5__2;

			[Token(Token = "0x17000062")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F5")]
				[Address(RVA = "0x84296C", Offset = "0x84296C", VA = "0x84296C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000063")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F7")]
				[Address(RVA = "0x8429B4", Offset = "0x8429B4", VA = "0x8429B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x842434", Offset = "0x842434", VA = "0x842434")]
			[DebuggerHidden]
			public <Start>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x842830", Offset = "0x842830", VA = "0x842830", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x842834", Offset = "0x842834", VA = "0x842834", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x842974", Offset = "0x842974", VA = "0x842974", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200021A")]
		[CompilerGenerated]
		private sealed class <SendPending>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000DEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000DEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000DF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HTTPTracking <>4__this;

			[Token(Token = "0x4000DF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string <prefsKey>5__2;

			[Token(Token = "0x17000064")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007FB")]
				[Address(RVA = "0x842E88", Offset = "0x842E88", VA = "0x842E88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007FD")]
				[Address(RVA = "0x842ED0", Offset = "0x842ED0", VA = "0x842ED0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x8424C4", Offset = "0x8424C4", VA = "0x8424C4")]
			[DebuggerHidden]
			public <SendPending>d__35(int <>1__state)
			{
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x8429BC", Offset = "0x8429BC", VA = "0x8429BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x8429C0", Offset = "0x8429C0", VA = "0x8429C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x842E90", Offset = "0x842E90", VA = "0x842E90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200021B")]
		[CompilerGenerated]
		private sealed class <SendBatch>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000DF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000DF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000DF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int batchNumber;

			[Token(Token = "0x4000DF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string eventsData;

			[Token(Token = "0x4000DF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public HTTPTracking <>4__this;

			[Token(Token = "0x4000DF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest <request>5__2;

			[Token(Token = "0x17000066")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000802")]
				[Address(RVA = "0x843B08", Offset = "0x843B08", VA = "0x843B08", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000804")]
				[Address(RVA = "0x843B50", Offset = "0x843B50", VA = "0x843B50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x842568", Offset = "0x842568", VA = "0x842568")]
			[DebuggerHidden]
			public <SendBatch>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x842ED8", Offset = "0x842ED8", VA = "0x842ED8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x842EF4", Offset = "0x842EF4", VA = "0x842EF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x843A58", Offset = "0x843A58", VA = "0x843A58")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x843B10", Offset = "0x843B10", VA = "0x843B10", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000DD2")]
		private const float highFrequencyTime = 300f;

		[Token(Token = "0x4000DD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Timing highFrequencyTimeBetweenSends;

		[Token(Token = "0x4000DD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Timing standardTimeBetweenSends;

		[Token(Token = "0x4000DD5")]
		private const string serverUrl = "https://e.resgam.com/";

		[Token(Token = "0x4000DD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly DateTime epoch;

		[Token(Token = "0x4000DD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string baseUrl;

		[Token(Token = "0x4000DD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private StringBuilder eventLog;

		[Token(Token = "0x4000DD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool eventOngoing;

		[Token(Token = "0x4000DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool quitting;

		[Token(Token = "0x4000DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool sendNow;

		[Token(Token = "0x4000DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		private bool stopped;

		[Token(Token = "0x4000DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly string NEXT_BATCH_NUMBER_KEY;

		[Token(Token = "0x4000DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string FIRST_UNSENT_BATCH_KEY;

		[Token(Token = "0x4000DDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string BATCH_KEY_PREFIX;

		[Token(Token = "0x4000DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int currentBatchNumber;

		[Token(Token = "0x4000DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int firstUnsentBatch;

		[Token(Token = "0x4000DE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool lastSendFailed;

		[Token(Token = "0x4000DE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int lastResponseCode;

		[Token(Token = "0x4000DE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int consecutiveSendFailures;

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x8415C0", Offset = "0x8415C0", VA = "0x8415C0", Slot = "5")]
		public Tracking.TrackingEvent AddParameter(string name, string value)
		{
			return null;
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x841798", Offset = "0x841798", VA = "0x841798", Slot = "7")]
		public Tracking.TrackingEvent AddParameter(string name, float value)
		{
			return null;
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x8418B0", Offset = "0x8418B0", VA = "0x8418B0", Slot = "9")]
		public Tracking.TrackingEvent AddParameter(string name, bool value)
		{
			return null;
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x841990", Offset = "0x841990", VA = "0x841990", Slot = "8")]
		public Tracking.TrackingEvent AddParameter(string name, double value)
		{
			return null;
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x841AA8", Offset = "0x841AA8", VA = "0x841AA8", Slot = "6")]
		public Tracking.TrackingEvent AddParameter(string name, int value)
		{
			return null;
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x841BC0", Offset = "0x841BC0", VA = "0x841BC0", Slot = "10")]
		public void Submit()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x841BE8", Offset = "0x841BE8", VA = "0x841BE8", Slot = "4")]
		public Tracking.TrackingEvent Track(string eventName)
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x841DBC", Offset = "0x841DBC", VA = "0x841DBC")]
		public void Awake()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x84203C", Offset = "0x84203C", VA = "0x84203C")]
		public bool HasOutgoingEvents()
		{
			return default(bool);
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x842080", Offset = "0x842080", VA = "0x842080")]
		public void SendNow()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x84208C", Offset = "0x84208C", VA = "0x84208C")]
		private bool OnWantsToQuit()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x842194", Offset = "0x842194", VA = "0x842194")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x842370", Offset = "0x842370", VA = "0x842370")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x84212C", Offset = "0x84212C", VA = "0x84212C")]
		[IteratorStateMachine(typeof(<Quit>d__33))]
		private IEnumerator Quit()
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x8423CC", Offset = "0x8423CC", VA = "0x8423CC")]
		[IteratorStateMachine(typeof(<Start>d__34))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x84245C", Offset = "0x84245C", VA = "0x84245C")]
		[IteratorStateMachine(typeof(<SendPending>d__35))]
		private IEnumerator SendPending()
		{
			return null;
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x8421A0", Offset = "0x8421A0", VA = "0x8421A0")]
		private void EndBatch()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x8424EC", Offset = "0x8424EC", VA = "0x8424EC")]
		[IteratorStateMachine(typeof(<SendBatch>d__37))]
		private IEnumerator SendBatch(int batchNumber, string eventsData)
		{
			return null;
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x841690", Offset = "0x841690", VA = "0x841690")]
		private static string Encode(string v)
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x841D10", Offset = "0x841D10", VA = "0x841D10")]
		private static double GetTimestamp()
		{
			return default(double);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x842590", Offset = "0x842590", VA = "0x842590")]
		public HTTPTracking()
		{
		}
	}
	[Token(Token = "0x200021C")]
	public class LifecycleTracking : MonoBehaviour
	{
		[Token(Token = "0x4000DF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string platform;

		[Token(Token = "0x4000DF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string PRODUCT_VERSION_KEY;

		[Token(Token = "0x4000DFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool hasSentStopEvent;

		[Token(Token = "0x4000DFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool? lastKnownPause;

		[Token(Token = "0x4000DFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string androidVersion;

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x843B58", Offset = "0x843B58", VA = "0x843B58")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x843BB0", Offset = "0x843BB0", VA = "0x843BB0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x844440", Offset = "0x844440", VA = "0x844440")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x8445B0", Offset = "0x8445B0", VA = "0x8445B0")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x843FA8", Offset = "0x843FA8", VA = "0x843FA8")]
		private Tracking.TrackingEvent AddCommonParameters(Tracking.TrackingEvent ev)
		{
			return null;
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x844684", Offset = "0x844684", VA = "0x844684")]
		public LifecycleTracking()
		{
		}
	}
	[Token(Token = "0x200021D")]
	internal class MultiTracker : Tracking.Tracker
	{
		[Token(Token = "0x200021E")]
		private class MultiEvent : Tracking.TrackingEvent
		{
			[Token(Token = "0x4000DFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Tracking.TrackingEvent[] events;

			[Token(Token = "0x600080E")]
			[Address(RVA = "0x844A90", Offset = "0x844A90", VA = "0x844A90")]
			public MultiEvent(Tracking.TrackingEvent[] events)
			{
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x844B34", Offset = "0x844B34", VA = "0x844B34", Slot = "5")]
			public Tracking.TrackingEvent AddParameter(string name, int value)
			{
				return null;
			}

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x844C40", Offset = "0x844C40", VA = "0x844C40", Slot = "7")]
			public Tracking.TrackingEvent AddParameter(string name, double value)
			{
				return null;
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x844D54", Offset = "0x844D54", VA = "0x844D54", Slot = "8")]
			public Tracking.TrackingEvent AddParameter(string name, bool value)
			{
				return null;
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x844E64", Offset = "0x844E64", VA = "0x844E64", Slot = "6")]
			public Tracking.TrackingEvent AddParameter(string name, float value)
			{
				return null;
			}

			[Token(Token = "0x6000813")]
			[Address(RVA = "0x844F78", Offset = "0x844F78", VA = "0x844F78", Slot = "4")]
			public Tracking.TrackingEvent AddParameter(string name, string value)
			{
				return null;
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0x845080", Offset = "0x845080", VA = "0x845080", Slot = "9")]
			public void Submit()
			{
			}
		}

		[Token(Token = "0x4000DFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Tracking.Tracker> trackers;

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x8446EC", Offset = "0x8446EC", VA = "0x8446EC", Slot = "4")]
		public Tracking.TrackingEvent Track(string eventName)
		{
			return null;
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x844AB8", Offset = "0x844AB8", VA = "0x844AB8")]
		public MultiTracker()
		{
		}
	}
	[Token(Token = "0x200021F")]
	public static class SimpleTracking
	{
		[Token(Token = "0x2000220")]
		public struct Settings
		{
			[Token(Token = "0x4000E01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string productName;

			[Token(Token = "0x4000E02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string platform;
		}

		[Token(Token = "0x4000DFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool started;

		[Token(Token = "0x4000E00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static HTTPTracking httpTracking;

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x845310", Offset = "0x845310", VA = "0x845310")]
		public static void Start(Settings settings)
		{
		}
	}
	[Token(Token = "0x2000221")]
	public static class Tracking
	{
		[Token(Token = "0x2000222")]
		public interface TrackingEvent
		{
			[Token(Token = "0x600081D")]
			TrackingEvent AddParameter(string name, string value);

			[Token(Token = "0x600081E")]
			TrackingEvent AddParameter(string name, int value);

			[Token(Token = "0x600081F")]
			TrackingEvent AddParameter(string name, float value);

			[Token(Token = "0x6000820")]
			TrackingEvent AddParameter(string name, double value);

			[Token(Token = "0x6000821")]
			TrackingEvent AddParameter(string name, bool value);

			[Token(Token = "0x6000822")]
			void Submit();
		}

		[Token(Token = "0x2000223")]
		public interface Tracker
		{
			[Token(Token = "0x6000823")]
			TrackingEvent Track(string eventName);
		}

		[Token(Token = "0x4000E03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string installationId;

		[Token(Token = "0x4000E04")]
		private const string installationIdPrefsKey = "installationId";

		[Token(Token = "0x4000E05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string productId;

		[Token(Token = "0x4000E06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Tracker tracker;

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x842D90", Offset = "0x842D90", VA = "0x842D90")]
		public static TrackingEvent Track(string eventName)
		{
			return null;
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x841EA0", Offset = "0x841EA0", VA = "0x841EA0")]
		public static void RegisterTracker(Tracker newTracker)
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x8454C8", Offset = "0x8454C8", VA = "0x8454C8")]
		public static void DeregisterTracker(Tracker trackerToBeRemoved)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x8455A0", Offset = "0x8455A0", VA = "0x8455A0")]
		public static void SetProduct(string product)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x8438D0", Offset = "0x8438D0", VA = "0x8438D0")]
		public static string GetProduct()
		{
			return null;
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x843968", Offset = "0x843968", VA = "0x843968")]
		public static string GetVersion()
		{
			return null;
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x843970", Offset = "0x843970", VA = "0x843970")]
		public static string GetUserId()
		{
			return null;
		}
	}
	[Token(Token = "0x2000224")]
	public static class TrackingNames
	{
		[Token(Token = "0x4000E07")]
		public const string eventAddPaymentInfo = "add_payment_info";

		[Token(Token = "0x4000E08")]
		public const string eventAddToCart = "add_to_cart";

		[Token(Token = "0x4000E09")]
		public const string eventAddToWishlist = "add_to_wishlist";

		[Token(Token = "0x4000E0A")]
		public const string eventAppOpen = "app_open";

		[Token(Token = "0x4000E0B")]
		public const string eventBeginCheckout = "begin_checkout";

		[Token(Token = "0x4000E0C")]
		public const string eventCampaignDetails = "campaign_details";

		[Token(Token = "0x4000E0D")]
		public const string eventCheckoutProgress = "checkout_progress";

		[Token(Token = "0x4000E0E")]
		public const string eventEarnVirtualCurrency = "earn_virtual_currency";

		[Token(Token = "0x4000E0F")]
		public const string eventEcommercePurchase = "ecommerce_purchase";

		[Token(Token = "0x4000E10")]
		public const string eventGenerateLead = "generate_lead";

		[Token(Token = "0x4000E11")]
		public const string eventJoinGroup = "join_group";

		[Token(Token = "0x4000E12")]
		public const string eventLevelUp = "level_up";

		[Token(Token = "0x4000E13")]
		public const string eventLogin = "login";

		[Token(Token = "0x4000E14")]
		public const string eventPostScore = "post_score";

		[Token(Token = "0x4000E15")]
		public const string eventPresentOffer = "present_offer";

		[Token(Token = "0x4000E16")]
		public const string eventPurchaseRefund = "purchase_refund";

		[Token(Token = "0x4000E17")]
		public const string eventRemoveFromCart = "remove_from_cart";

		[Token(Token = "0x4000E18")]
		public const string eventSearch = "search";

		[Token(Token = "0x4000E19")]
		public const string eventSelectContent = "select_content";

		[Token(Token = "0x4000E1A")]
		public const string eventSetCheckoutOption = "set_checkout_option";

		[Token(Token = "0x4000E1B")]
		public const string eventShare = "share";

		[Token(Token = "0x4000E1C")]
		public const string eventSignUp = "sign_up";

		[Token(Token = "0x4000E1D")]
		public const string eventSpendVirtualCurrency = "spend_virtual_currency";

		[Token(Token = "0x4000E1E")]
		public const string eventTutorialBegin = "tutorial_begin";

		[Token(Token = "0x4000E1F")]
		public const string eventTutorialComplete = "tutorial_complete";

		[Token(Token = "0x4000E20")]
		public const string eventUnlockAchievement = "unlock_achievement";

		[Token(Token = "0x4000E21")]
		public const string eventViewItem = "view_item";

		[Token(Token = "0x4000E22")]
		public const string eventViewItemList = "view_item_list";

		[Token(Token = "0x4000E23")]
		public const string eventViewSearchResults = "view_search_results";

		[Token(Token = "0x4000E24")]
		public const string parameterAchievementId = "achievement_id";

		[Token(Token = "0x4000E25")]
		public const string parameterAdNetworkClickID = "aclid";

		[Token(Token = "0x4000E26")]
		public const string parameterAffiliation = "affiliation";

		[Token(Token = "0x4000E27")]
		public const string parameterCampaign = "campaign";

		[Token(Token = "0x4000E28")]
		public const string parameterCharacter = "character";

		[Token(Token = "0x4000E29")]
		public const string parameterCheckoutOption = "checkout_option";

		[Token(Token = "0x4000E2A")]
		public const string parameterCheckoutStep = "checkout_step";

		[Token(Token = "0x4000E2B")]
		public const string parameterContent = "content";

		[Token(Token = "0x4000E2C")]
		public const string parameterContentType = "content_type";

		[Token(Token = "0x4000E2D")]
		public const string parameterCoupon = "coupon";

		[Token(Token = "0x4000E2E")]
		public const string parameterCP1 = "cp1";

		[Token(Token = "0x4000E2F")]
		public const string parameterCreativeName = "creative_name";

		[Token(Token = "0x4000E30")]
		public const string parameterCreativeSlot = "creative_slot";

		[Token(Token = "0x4000E31")]
		public const string parameterCurrency = "currency";

		[Token(Token = "0x4000E32")]
		public const string parameterDestination = "destination";

		[Token(Token = "0x4000E33")]
		public const string parameterEndDate = "end_date";

		[Token(Token = "0x4000E34")]
		public const string parameterFlightNumber = "flight_number";

		[Token(Token = "0x4000E35")]
		public const string parameterGroupId = "group_id";

		[Token(Token = "0x4000E36")]
		public const string parameterItemBrand = "item_brand";

		[Token(Token = "0x4000E37")]
		public const string parameterItemCategory = "item_category";

		[Token(Token = "0x4000E38")]
		public const string parameterItemId = "item_id";

		[Token(Token = "0x4000E39")]
		public const string parameterItemList = "item_list";

		[Token(Token = "0x4000E3A")]
		public const string parameterItemLocationId = "item_location_id";

		[Token(Token = "0x4000E3B")]
		public const string parameterItemName = "item_name";

		[Token(Token = "0x4000E3C")]
		public const string parameterItemVariant = "item_variant";

		[Token(Token = "0x4000E3D")]
		public const string parameterLevel = "level";

		[Token(Token = "0x4000E3E")]
		public const string parameterLocation = "location";

		[Token(Token = "0x4000E3F")]
		public const string parameterMedium = "medium";

		[Token(Token = "0x4000E40")]
		public const string parameterNumberOfNights = "number_of_nights";

		[Token(Token = "0x4000E41")]
		public const string parameterNumberOfPassengers = "number_of_passengers";

		[Token(Token = "0x4000E42")]
		public const string parameterNumberOfRooms = "number_of_rooms";

		[Token(Token = "0x4000E43")]
		public const string parameterOrigin = "origin";

		[Token(Token = "0x4000E44")]
		public const string parameterPrice = "price";

		[Token(Token = "0x4000E45")]
		public const string parameterQuantity = "quantity";

		[Token(Token = "0x4000E46")]
		public const string parameterScore = "score";

		[Token(Token = "0x4000E47")]
		public const string parameterSearchTerm = "search_term";

		[Token(Token = "0x4000E48")]
		public const string parameterShipping = "shipping";

		[Token(Token = "0x4000E49")]
		public const string parameterSignUpMethod = "sign_up_method";

		[Token(Token = "0x4000E4A")]
		public const string parameterSource = "source";

		[Token(Token = "0x4000E4B")]
		public const string parameterStartDate = "start_date";

		[Token(Token = "0x4000E4C")]
		public const string parameterTax = "tax";

		[Token(Token = "0x4000E4D")]
		public const string parameterTerm = "term";

		[Token(Token = "0x4000E4E")]
		public const string parameterTransactionId = "transaction_id";

		[Token(Token = "0x4000E4F")]
		public const string parameterTravelClass = "travel_class";

		[Token(Token = "0x4000E50")]
		public const string parameterValue = "value";

		[Token(Token = "0x4000E51")]
		public const string parameterVirtualCurrencyName = "virtual_currency_name";

		[Token(Token = "0x4000E52")]
		public const string userPropertySignUpMethod = "sign_up_method";
	}
	[Token(Token = "0x2000225")]
	public class TrackingPlatformNames
	{
		[Token(Token = "0x4000E53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Quest;

		[Token(Token = "0x4000E54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Quest2;

		[Token(Token = "0x4000E55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string Rift;

		[Token(Token = "0x4000E56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string SteamVR;

		[Token(Token = "0x4000E57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string Windows;

		[Token(Token = "0x4000E58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] SuggestedPlarformNames;

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x8455EC", Offset = "0x8455EC", VA = "0x8455EC")]
		public TrackingPlatformNames()
		{
		}
	}
	[Token(Token = "0x2000226")]
	public class FollowPose : MonoBehaviour
	{
		[Token(Token = "0x4000E59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to follow if not main camera")]
		public Transform objectToFollow;

		[Token(Token = "0x4000E5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long it takes for the object to settle at the target object's position")]
		[SerializeField]
		private float movementSmoothTime;

		[Token(Token = "0x4000E5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("How long it takes for the object to settle at the target object's rotation")]
		[SerializeField]
		private float rotationSmoothTime;

		[Token(Token = "0x4000E5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Offset from target object's global position")]
		[SerializeField]
		private Vector3 globalPositionOffset;

		[Token(Token = "0x4000E5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Tooltip("Offset from target object's local position")]
		private Vector3 localPositionOffset;

		[Token(Token = "0x4000E5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Offset from target object's local position")]
		private Vector3 rotationOffset;

		[Token(Token = "0x4000E5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Make sure the horizon stays straight")]
		[SerializeField]
		private bool keepHorizontal;

		[Token(Token = "0x4000E60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private new Transform transform;

		[Token(Token = "0x4000E61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 movementVelocity;

		[Token(Token = "0x4000E62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion rotationVelocity;

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x8457F8", Offset = "0x8457F8", VA = "0x8457F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x845814", Offset = "0x845814", VA = "0x845814")]
		private void Update()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x845B70", Offset = "0x845B70", VA = "0x845B70")]
		private static Quaternion SmoothDamp(Quaternion rot, Quaternion target, ref Quaternion deriv, float time)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x845DE4", Offset = "0x845DE4", VA = "0x845DE4")]
		public FollowPose()
		{
		}
	}
	[Token(Token = "0x2000227")]
	public class VideoSlate : MonoBehaviour
	{
		[Token(Token = "0x4000E63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode visibilityKey;

		[Token(Token = "0x4000E64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public KeyCode slateKey;

		[Token(Token = "0x4000E65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GUIStyle guiStyle;

		[Token(Token = "0x4000E66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int framesLeft;

		[Token(Token = "0x4000E67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Texture2D bgTexture;

		[Token(Token = "0x4000E68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int slateNumber;

		[Token(Token = "0x4000E69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool showSlateNumber;

		[Token(Token = "0x4000E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AudioSource audioSource;

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x845E7C", Offset = "0x845E7C", VA = "0x845E7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x845FD0", Offset = "0x845FD0", VA = "0x845FD0")]
		private void Update()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x84609C", Offset = "0x84609C", VA = "0x84609C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x846464", Offset = "0x846464", VA = "0x846464")]
		public VideoSlate()
		{
		}
	}
}
namespace RGCommon.VectorExtensions
{
	[Token(Token = "0x2000228")]
	public static class VectorComponentReplacement
	{
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x8464E0", Offset = "0x8464E0", VA = "0x8464E0")]
		public static Vector3 WithX(this Vector3 original, float newX)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x8464E8", Offset = "0x8464E8", VA = "0x8464E8")]
		public static Vector3 WithY(this Vector3 original, float newY)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x8464F0", Offset = "0x8464F0", VA = "0x8464F0")]
		public static Vector3 WithZ(this Vector3 original, float newZ)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x8464F8", Offset = "0x8464F8", VA = "0x8464F8")]
		public static Vector2 WithX(this Vector2 original, float newX)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x846500", Offset = "0x846500", VA = "0x846500")]
		public static Vector2 WithY(this Vector2 original, float newY)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x846508", Offset = "0x846508", VA = "0x846508")]
		public static Vector3 NegX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x846510", Offset = "0x846510", VA = "0x846510")]
		public static Vector3 NegY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x846518", Offset = "0x846518", VA = "0x846518")]
		public static Vector3 NegZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x846520", Offset = "0x846520", VA = "0x846520")]
		public static Vector2 NegX(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x846528", Offset = "0x846528", VA = "0x846528")]
		public static Vector2 NegY(this Vector2 original)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x2000229")]
	public static class VectorSwizzle
	{
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x846530", Offset = "0x846530", VA = "0x846530")]
		public static Vector2 Swizzle00(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x84653C", Offset = "0x84653C", VA = "0x84653C")]
		public static Vector2 Swizzle0X(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x846548", Offset = "0x846548", VA = "0x846548")]
		public static Vector2 Swizzle0Y(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x846550", Offset = "0x846550", VA = "0x846550")]
		public static Vector2 Swizzle0Z(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x84655C", Offset = "0x84655C", VA = "0x84655C")]
		public static Vector2 SwizzleX0(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x846564", Offset = "0x846564", VA = "0x846564")]
		public static Vector2 SwizzleXX(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x84656C", Offset = "0x84656C", VA = "0x84656C")]
		public static Vector2 SwizzleXY(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x846570", Offset = "0x846570", VA = "0x846570")]
		public static Vector2 SwizzleXZ(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x846578", Offset = "0x846578", VA = "0x846578")]
		public static Vector2 SwizzleY0(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x846584", Offset = "0x846584", VA = "0x846584")]
		public static Vector2 SwizzleYX(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x846594", Offset = "0x846594", VA = "0x846594")]
		public static Vector2 SwizzleYY(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x84659C", Offset = "0x84659C", VA = "0x84659C")]
		public static Vector2 SwizzleYZ(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x8465A8", Offset = "0x8465A8", VA = "0x8465A8")]
		public static Vector2 SwizzleZ0(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x8465B4", Offset = "0x8465B4", VA = "0x8465B4")]
		public static Vector2 SwizzleZX(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x8465C0", Offset = "0x8465C0", VA = "0x8465C0")]
		public static Vector2 SwizzleZY(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x8465C8", Offset = "0x8465C8", VA = "0x8465C8")]
		public static Vector2 SwizzleZZ(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x8465D4", Offset = "0x8465D4", VA = "0x8465D4")]
		public static Vector3 Swizzle000(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x8465E4", Offset = "0x8465E4", VA = "0x8465E4")]
		public static Vector3 Swizzle00X(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x8465F4", Offset = "0x8465F4", VA = "0x8465F4")]
		public static Vector3 Swizzle00Y(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x846604", Offset = "0x846604", VA = "0x846604")]
		public static Vector3 Swizzle00Z(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x846610", Offset = "0x846610", VA = "0x846610")]
		public static Vector3 Swizzle0X0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x846620", Offset = "0x846620", VA = "0x846620")]
		public static Vector3 Swizzle0XX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x846630", Offset = "0x846630", VA = "0x846630")]
		public static Vector3 Swizzle0XY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x846648", Offset = "0x846648", VA = "0x846648")]
		public static Vector3 Swizzle0XZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x846654", Offset = "0x846654", VA = "0x846654")]
		public static Vector3 Swizzle0Y0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x846660", Offset = "0x846660", VA = "0x846660")]
		public static Vector3 Swizzle0YX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x84666C", Offset = "0x84666C", VA = "0x84666C")]
		public static Vector3 Swizzle0YY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x846678", Offset = "0x846678", VA = "0x846678")]
		public static Vector3 Swizzle0YZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x846680", Offset = "0x846680", VA = "0x846680")]
		public static Vector3 Swizzle0Z0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x846690", Offset = "0x846690", VA = "0x846690")]
		public static Vector3 Swizzle0ZX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x8466A4", Offset = "0x8466A4", VA = "0x8466A4")]
		public static Vector3 Swizzle0ZY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x8466B8", Offset = "0x8466B8", VA = "0x8466B8")]
		public static Vector3 Swizzle0ZZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x8466C4", Offset = "0x8466C4", VA = "0x8466C4")]
		public static Vector3 SwizzleX00(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x8466D0", Offset = "0x8466D0", VA = "0x8466D0")]
		public static Vector3 SwizzleX0X(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x8466DC", Offset = "0x8466DC", VA = "0x8466DC")]
		public static Vector3 SwizzleX0Y(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x8466E8", Offset = "0x8466E8", VA = "0x8466E8")]
		public static Vector3 SwizzleX0Z(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x8466F0", Offset = "0x8466F0", VA = "0x8466F0")]
		public static Vector3 SwizzleXX0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x8466FC", Offset = "0x8466FC", VA = "0x8466FC")]
		public static Vector3 SwizzleXXX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x846708", Offset = "0x846708", VA = "0x846708")]
		public static Vector3 SwizzleXXY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x846714", Offset = "0x846714", VA = "0x846714")]
		public static Vector3 SwizzleXXZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x84671C", Offset = "0x84671C", VA = "0x84671C")]
		public static Vector3 SwizzleXY0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x846724", Offset = "0x846724", VA = "0x846724")]
		public static Vector3 SwizzleXYX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x84672C", Offset = "0x84672C", VA = "0x84672C")]
		public static Vector3 SwizzleXYY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x846734", Offset = "0x846734", VA = "0x846734")]
		public static Vector3 SwizzleXYZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x846738", Offset = "0x846738", VA = "0x846738")]
		public static Vector3 SwizzleXZ0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x846744", Offset = "0x846744", VA = "0x846744")]
		public static Vector3 SwizzleXZX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x846750", Offset = "0x846750", VA = "0x846750")]
		public static Vector3 SwizzleXZY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x846760", Offset = "0x846760", VA = "0x846760")]
		public static Vector3 SwizzleXZZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x846768", Offset = "0x846768", VA = "0x846768")]
		public static Vector3 SwizzleY00(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x846778", Offset = "0x846778", VA = "0x846778")]
		public static Vector3 SwizzleY0X(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x846790", Offset = "0x846790", VA = "0x846790")]
		public static Vector3 SwizzleY0Y(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x8467A0", Offset = "0x8467A0", VA = "0x8467A0")]
		public static Vector3 SwizzleY0Z(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x8467AC", Offset = "0x8467AC", VA = "0x8467AC")]
		public static Vector3 SwizzleYX0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x8467C0", Offset = "0x8467C0", VA = "0x8467C0")]
		public static Vector3 SwizzleYXX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x8467D0", Offset = "0x8467D0", VA = "0x8467D0")]
		public static Vector3 SwizzleYXY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x8467E0", Offset = "0x8467E0", VA = "0x8467E0")]
		public static Vector3 SwizzleYXZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x8467F0", Offset = "0x8467F0", VA = "0x8467F0")]
		public static Vector3 SwizzleYY0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x8467FC", Offset = "0x8467FC", VA = "0x8467FC")]
		public static Vector3 SwizzleYYX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x846808", Offset = "0x846808", VA = "0x846808")]
		public static Vector3 SwizzleYYY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x846814", Offset = "0x846814", VA = "0x846814")]
		public static Vector3 SwizzleYYZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x84681C", Offset = "0x84681C", VA = "0x84681C")]
		public static Vector3 SwizzleYZ0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x846830", Offset = "0x846830", VA = "0x846830")]
		public static Vector3 SwizzleYZX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x846844", Offset = "0x846844", VA = "0x846844")]
		public static Vector3 SwizzleYZY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x846854", Offset = "0x846854", VA = "0x846854")]
		public static Vector3 SwizzleYZZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x846860", Offset = "0x846860", VA = "0x846860")]
		public static Vector3 SwizzleZ00(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x846870", Offset = "0x846870", VA = "0x846870")]
		public static Vector3 SwizzleZ0X(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x846884", Offset = "0x846884", VA = "0x846884")]
		public static Vector3 SwizzleZ0Y(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x846898", Offset = "0x846898", VA = "0x846898")]
		public static Vector3 SwizzleZ0Z(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x8468A4", Offset = "0x8468A4", VA = "0x8468A4")]
		public static Vector3 SwizzleZX0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x8468BC", Offset = "0x8468BC", VA = "0x8468BC")]
		public static Vector3 SwizzleZXX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x8468CC", Offset = "0x8468CC", VA = "0x8468CC")]
		public static Vector3 SwizzleZXY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x8468E0", Offset = "0x8468E0", VA = "0x8468E0")]
		public static Vector3 SwizzleZXZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x8468EC", Offset = "0x8468EC", VA = "0x8468EC")]
		public static Vector3 SwizzleZY0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x8468F8", Offset = "0x8468F8", VA = "0x8468F8")]
		public static Vector3 SwizzleZYX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x846908", Offset = "0x846908", VA = "0x846908")]
		public static Vector3 SwizzleZYY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x846914", Offset = "0x846914", VA = "0x846914")]
		public static Vector3 SwizzleZYZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x84691C", Offset = "0x84691C", VA = "0x84691C")]
		public static Vector3 SwizzleZZ0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x84692C", Offset = "0x84692C", VA = "0x84692C")]
		public static Vector3 SwizzleZZX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x84693C", Offset = "0x84693C", VA = "0x84693C")]
		public static Vector3 SwizzleZZY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x84694C", Offset = "0x84694C", VA = "0x84694C")]
		public static Vector3 SwizzleZZZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x846958", Offset = "0x846958", VA = "0x846958")]
		public static Vector2 Swizzle00(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x846964", Offset = "0x846964", VA = "0x846964")]
		public static Vector2 Swizzle0X(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x846970", Offset = "0x846970", VA = "0x846970")]
		public static Vector2 Swizzle0Y(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x846978", Offset = "0x846978", VA = "0x846978")]
		public static Vector2 SwizzleX0(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x846980", Offset = "0x846980", VA = "0x846980")]
		public static Vector2 SwizzleXX(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x846988", Offset = "0x846988", VA = "0x846988")]
		public static Vector2 SwizzleXY(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x84698C", Offset = "0x84698C", VA = "0x84698C")]
		public static Vector2 SwizzleY0(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x846998", Offset = "0x846998", VA = "0x846998")]
		public static Vector2 SwizzleYX(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x8469A8", Offset = "0x8469A8", VA = "0x8469A8")]
		public static Vector2 SwizzleYY(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x8469B0", Offset = "0x8469B0", VA = "0x8469B0")]
		public static Vector3 Swizzle000(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x8469C0", Offset = "0x8469C0", VA = "0x8469C0")]
		public static Vector3 Swizzle00X(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x8469D0", Offset = "0x8469D0", VA = "0x8469D0")]
		public static Vector3 Swizzle00Y(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x8469E0", Offset = "0x8469E0", VA = "0x8469E0")]
		public static Vector3 Swizzle0X0(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x8469F0", Offset = "0x8469F0", VA = "0x8469F0")]
		public static Vector3 Swizzle0XX(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x846A00", Offset = "0x846A00", VA = "0x846A00")]
		public static Vector3 Swizzle0XY(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x846A18", Offset = "0x846A18", VA = "0x846A18")]
		public static Vector3 Swizzle0Y0(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x846A24", Offset = "0x846A24", VA = "0x846A24")]
		public static Vector3 Swizzle0YX(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x846A30", Offset = "0x846A30", VA = "0x846A30")]
		public static Vector3 Swizzle0YY(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x846A3C", Offset = "0x846A3C", VA = "0x846A3C")]
		public static Vector3 SwizzleX00(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x846A48", Offset = "0x846A48", VA = "0x846A48")]
		public static Vector3 SwizzleX0X(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x846A54", Offset = "0x846A54", VA = "0x846A54")]
		public static Vector3 SwizzleX0Y(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x846A60", Offset = "0x846A60", VA = "0x846A60")]
		public static Vector3 SwizzleXX0(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x846A6C", Offset = "0x846A6C", VA = "0x846A6C")]
		public static Vector3 SwizzleXXX(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x846A78", Offset = "0x846A78", VA = "0x846A78")]
		public static Vector3 SwizzleXXY(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x846A84", Offset = "0x846A84", VA = "0x846A84")]
		public static Vector3 SwizzleXY0(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x846A8C", Offset = "0x846A8C", VA = "0x846A8C")]
		public static Vector3 SwizzleXYX(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x846A94", Offset = "0x846A94", VA = "0x846A94")]
		public static Vector3 SwizzleXYY(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x846A9C", Offset = "0x846A9C", VA = "0x846A9C")]
		public static Vector3 SwizzleY00(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x846AAC", Offset = "0x846AAC", VA = "0x846AAC")]
		public static Vector3 SwizzleY0X(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x846AC4", Offset = "0x846AC4", VA = "0x846AC4")]
		public static Vector3 SwizzleY0Y(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x846AD4", Offset = "0x846AD4", VA = "0x846AD4")]
		public static Vector3 SwizzleYX0(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x846AE8", Offset = "0x846AE8", VA = "0x846AE8")]
		public static Vector3 SwizzleYXX(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x846AF8", Offset = "0x846AF8", VA = "0x846AF8")]
		public static Vector3 SwizzleYXY(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x846B08", Offset = "0x846B08", VA = "0x846B08")]
		public static Vector3 SwizzleYY0(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x846B14", Offset = "0x846B14", VA = "0x846B14")]
		public static Vector3 SwizzleYYX(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x846B20", Offset = "0x846B20", VA = "0x846B20")]
		public static Vector3 SwizzleYYY(this Vector2 original)
		{
			return default(Vector3);
		}
	}
}
namespace Zi.MergeScenes
{
	[Token(Token = "0x200022A")]
	public abstract class MergeSceneBaseComponent : MonoBehaviour
	{
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x846B2C", Offset = "0x846B2C", VA = "0x846B2C", Slot = "4")]
		public virtual void ExecutePostMerge(GameObject target)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x846B30", Offset = "0x846B30", VA = "0x846B30")]
		protected MergeSceneBaseComponent()
		{
		}
	}
	[Token(Token = "0x200022B")]
	public class MergeSceneChangeTransform : MergeSceneBaseComponent
	{
		[Token(Token = "0x200022C")]
		public enum TransformPolicy
		{
			[Token(Token = "0x4000E6F")]
			UseDestination,
			[Token(Token = "0x4000E70")]
			UseSource,
			[Token(Token = "0x4000E71")]
			Custom
		}

		[Serializable]
		[Token(Token = "0x200022D")]
		public struct TransformVector3
		{
			[Token(Token = "0x4000E72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TransformPolicy policy;

			[Token(Token = "0x4000E73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector3 customValue;
		}

		[Serializable]
		[Token(Token = "0x200022E")]
		public struct TransformQuaternion
		{
			[Token(Token = "0x4000E74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TransformPolicy policy;

			[Token(Token = "0x4000E75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Quaternion customValue;
		}

		[Token(Token = "0x4000E6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TransformVector3 localPosition;

		[Token(Token = "0x4000E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TransformQuaternion localRotation;

		[Token(Token = "0x4000E6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public TransformVector3 localScale;

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x846B38", Offset = "0x846B38", VA = "0x846B38", Slot = "4")]
		public override void ExecutePostMerge(GameObject target)
		{
		}

		[Token(Token = "0x60008AF")]
		private T SetValue<T>(T destination, TransformPolicy policy, T source, T custom)
		{
			return (T)null;
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x846D40", Offset = "0x846D40", VA = "0x846D40")]
		public MergeSceneChangeTransform()
		{
		}
	}
	[Token(Token = "0x200022F")]
	public class MergeSceneRemoveGameObject : MergeSceneBaseComponent
	{
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x846D48", Offset = "0x846D48", VA = "0x846D48", Slot = "4")]
		public override void ExecutePostMerge(GameObject target)
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x846DA4", Offset = "0x846DA4", VA = "0x846DA4")]
		public MergeSceneRemoveGameObject()
		{
		}
	}
	[Token(Token = "0x2000230")]
	public class MergeSceneRename : MergeSceneBaseComponent
	{
		[Token(Token = "0x4000E76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string newName;

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x846DAC", Offset = "0x846DAC", VA = "0x846DAC", Slot = "4")]
		public override void ExecutePostMerge(GameObject target)
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x846DD0", Offset = "0x846DD0", VA = "0x846DD0")]
		public MergeSceneRename()
		{
		}
	}
	[Token(Token = "0x2000231")]
	public class MergeSceneData : ScriptableObject
	{
		[Token(Token = "0x2000232")]
		public enum OutputOptions
		{
			[Token(Token = "0x4000E7D")]
			MainSceneFolder,
			[Token(Token = "0x4000E7E")]
			SaveOverMainScene,
			[Token(Token = "0x4000E7F")]
			ChangeSceneFolder,
			[Token(Token = "0x4000E80")]
			ManualSave,
			[Token(Token = "0x4000E81")]
			Custom
		}

		[Token(Token = "0x4000E77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string mainScenePath;

		[Token(Token = "0x4000E78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string sceneWithChangesPath;

		[Token(Token = "0x4000E79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OutputOptions outputOptions;

		[Token(Token = "0x4000E7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customOutputPath;

		[Token(Token = "0x4000E7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string outputName;

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x846DD8", Offset = "0x846DD8", VA = "0x846DD8")]
		public MergeSceneData()
		{
		}
	}
}
namespace LevelEditorAPI
{
	[Serializable]
	[Token(Token = "0x2000233")]
	public struct BlockData
	{
		[Token(Token = "0x4000E82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int id;

		[Token(Token = "0x4000E83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int prefabId;

		[Token(Token = "0x4000E84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 localPosition;

		[Token(Token = "0x4000E85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Quaternion localRotation;

		[Token(Token = "0x17000068")]
		public Prefab Prefab
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x846DE0", Offset = "0x846DE0", VA = "0x846DE0")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Token(Token = "0x2000234")]
	public class Level
	{
		[Token(Token = "0x4000E86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LevelMetaData MetaData;

		[Token(Token = "0x4000E87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LevelBlockCollection LevelBlocks;

		[Token(Token = "0x4000E88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isDirty;

		[Token(Token = "0x17000069")]
		public int BlockCount
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x846E3C", Offset = "0x846E3C", VA = "0x846E3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x846E8C", Offset = "0x846E8C", VA = "0x846E8C")]
		public Level(string name, uint id)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x847088", Offset = "0x847088", VA = "0x847088")]
		public Level(LevelMetaData metaData, LevelBlockCollection blockData)
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x8470B4", Offset = "0x8470B4", VA = "0x8470B4")]
		public Level Clone()
		{
			return null;
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x847464", Offset = "0x847464", VA = "0x847464")]
		public void AddBlock(BlockData blockData)
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x847570", Offset = "0x847570", VA = "0x847570")]
		public void SetBlock(BlockData blockData)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x8476E4", Offset = "0x8476E4", VA = "0x8476E4")]
		public void RemoveBlock(int id)
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x8477E4", Offset = "0x8477E4", VA = "0x8477E4")]
		public bool ContainsPig()
		{
			return default(bool);
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x8478A4", Offset = "0x8478A4", VA = "0x8478A4")]
		public BlockData GetBlock(int index)
		{
			return default(BlockData);
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x847934", Offset = "0x847934", VA = "0x847934")]
		public void Sort(Comparison<BlockData> comparison)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x847990", Offset = "0x847990", VA = "0x847990")]
		public static Level Decompress(string data)
		{
			return null;
		}
	}
	[Token(Token = "0x2000235")]
	public static class LevelExtensions
	{
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x8480BC", Offset = "0x8480BC", VA = "0x8480BC")]
		public static string Compress(this Level level)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000236")]
	public class LevelBlockCollection
	{
		[Token(Token = "0x4000E89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<BlockData> blocks;

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x84700C", Offset = "0x84700C", VA = "0x84700C")]
		public LevelBlockCollection()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x8473D4", Offset = "0x8473D4", VA = "0x8473D4")]
		public LevelBlockCollection(List<BlockData> blocks)
		{
		}
	}
	[Token(Token = "0x2000237")]
	[CreateAssetMenu(fileName = "Prefab", menuName = "Prototyping/Database/Prefab", order = 1)]
	public class Prefab : ScriptableObject, IPrefab
	{
		[Token(Token = "0x4000E8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("The Category the object should be assigned to.")]
		[Header("Level Editor")]
		private string category;

		[Token(Token = "0x4000E8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("(-1) will use infinite blocks.")]
		private int maxObjects;

		[Token(Token = "0x4000E8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("Whether this should be hidden in the level editor.")]
		private bool hidden;

		[Token(Token = "0x4000E8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool locked;

		[Token(Token = "0x4000E8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Prefab Settings")]
		[SerializeField]
		private string prefabName;

		[Token(Token = "0x4000E8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject gameObject;

		[Token(Token = "0x4000E90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Material[] materials;

		[Token(Token = "0x4000E91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool special;

		[Token(Token = "0x4000E92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool character;

		[Token(Token = "0x4000E93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		public int cost;

		[Token(Token = "0x4000E94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Used by code generation for pathing and some editor scripts")]
		[SerializeField]
		private string path;

		[Token(Token = "0x4000E95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int id;

		[NonSerialized]
		[Token(Token = "0x4000E96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshDrawerInstance[] meshDrawerInstances;

		[NonSerialized]
		[Token(Token = "0x4000E97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Bounds? meshDrawerTotalBounds;

		[Token(Token = "0x1700006A")]
		public string Category
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x8484D0", Offset = "0x8484D0", VA = "0x8484D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x8484D8", Offset = "0x8484D8", VA = "0x8484D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public int MaxObjects
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x848504", Offset = "0x848504", VA = "0x848504")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006C")]
		public bool Hidden
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x84850C", Offset = "0x84850C", VA = "0x84850C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public bool Locked
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x848514", Offset = "0x848514", VA = "0x848514")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		public string PrefabName
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x84851C", Offset = "0x84851C", VA = "0x84851C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public string Path
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x848524", Offset = "0x848524", VA = "0x848524")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public GameObject GameObject
		{
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x84852C", Offset = "0x84852C", VA = "0x84852C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public Material[] Materials
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x848534", Offset = "0x848534", VA = "0x848534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public bool Special
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x84853C", Offset = "0x84853C", VA = "0x84853C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		public bool Character
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x848544", Offset = "0x848544", VA = "0x848544")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		public int Id
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x84854C", Offset = "0x84854C", VA = "0x84854C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000075")]
		public IPrefab Edit
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x84862C", Offset = "0x84862C", VA = "0x84862C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		private string LevelEditorAPI.InternalPrefab.IPrefab.PrefabName
		{
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x848E10", Offset = "0x848E10", VA = "0x848E10", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x848E18", Offset = "0x848E18", VA = "0x848E18", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		private GameObject LevelEditorAPI.InternalPrefab.IPrefab.GameObject
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x848E20", Offset = "0x848E20", VA = "0x848E20", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x848E28", Offset = "0x848E28", VA = "0x848E28", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		private int LevelEditorAPI.InternalPrefab.IPrefab.Id
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x848E30", Offset = "0x848E30", VA = "0x848E30", Slot = "8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x848E38", Offset = "0x848E38", VA = "0x848E38", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public MeshDrawerInstance[] MeshDrawerInstances
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x848F28", Offset = "0x848F28", VA = "0x848F28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public Bounds MeshDrawerTotalBounds
		{
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x848FFC", Offset = "0x848FFC", VA = "0x848FFC")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x848630", Offset = "0x848630", VA = "0x848630", Slot = "10")]
		private void LevelEditorAPI.InternalPrefab.IPrefab.Initialize()
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x848634", Offset = "0x848634", VA = "0x848634")]
		public GameObject Instantiate()
		{
			return null;
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x848894", Offset = "0x848894", VA = "0x848894")]
		public GameObject Instantiate(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x848998", Offset = "0x848998", VA = "0x848998")]
		public GameObject Instantiate(Vector3 position)
		{
			return null;
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x848A6C", Offset = "0x848A6C", VA = "0x848A6C")]
		public GameObject Instantiate(Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x848AC4", Offset = "0x848AC4", VA = "0x848AC4")]
		public GameObject Instantiate(Vector3 position, Quaternion rotation, Vector3 scale)
		{
			return null;
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x848BF0", Offset = "0x848BF0", VA = "0x848BF0")]
		public GameObject Instantiate(Vector3 position, Quaternion rotation, Vector3 scale, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x848CF4", Offset = "0x848CF4", VA = "0x848CF4")]
		public GameObject Instantiate(Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x848710", Offset = "0x848710", VA = "0x848710")]
		public GameObject Instantiate(InstantiateData data)
		{
			return null;
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x848D4C", Offset = "0x848D4C", VA = "0x848D4C")]
		public void Destroy(GameObject gameObject)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x848DA4", Offset = "0x848DA4", VA = "0x848DA4")]
		public bool HasGameObject(GameObject gameObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x848E40", Offset = "0x848E40", VA = "0x848E40")]
		public static implicit operator int(Prefab prefab)
		{
			return default(int);
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x848E58", Offset = "0x848E58", VA = "0x848E58")]
		public static implicit operator GameObject(Prefab prefab)
		{
			return null;
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x848E70", Offset = "0x848E70", VA = "0x848E70")]
		public static implicit operator string(Prefab prefab)
		{
			return null;
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x848E88", Offset = "0x848E88", VA = "0x848E88")]
		[ContextMenu("Set Name to Prefab")]
		private void SetNameToPrefab()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x848F4C", Offset = "0x848F4C", VA = "0x848F4C")]
		public void RecalculateMeshInstances()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x8496A8", Offset = "0x8496A8", VA = "0x8496A8")]
		public void Draw(Transform transform)
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x84986C", Offset = "0x84986C", VA = "0x84986C")]
		public void Draw(Transform transform, Material material)
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x8498D0", Offset = "0x8498D0", VA = "0x8498D0")]
		public void Draw(Matrix4x4 offset)
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x849700", Offset = "0x849700", VA = "0x849700")]
		public void Draw(Matrix4x4 offset, Material material)
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x849AF0", Offset = "0x849AF0", VA = "0x849AF0")]
		public Prefab()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000238")]
	public class LevelMetaData
	{
		[Token(Token = "0x4000E98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint version;

		[Token(Token = "0x4000E99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000E9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint id;

		[Token(Token = "0x4000E9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BlockData[] birds;

		[Token(Token = "0x4000E9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yRotation;

		[Token(Token = "0x4000E9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool[] enabledTelePoints;

		[Token(Token = "0x4000E9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int birdCount;

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x846F38", Offset = "0x846F38", VA = "0x846F38")]
		public LevelMetaData(string levelName, uint id)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x8471AC", Offset = "0x8471AC", VA = "0x8471AC")]
		public LevelMetaData Clone()
		{
			return null;
		}
	}
	[Token(Token = "0x2000239")]
	public static class ArrayExtensions
	{
		[Token(Token = "0x60008F1")]
		public static T RandomElement<T>(this IReadOnlyList<T> array)
		{
			return (T)null;
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x849B5C", Offset = "0x849B5C", VA = "0x849B5C")]
		public static string CombineToList(this IReadOnlyList<string> list)
		{
			return null;
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x849D48", Offset = "0x849D48", VA = "0x849D48")]
		public static string CombineToListWithNumbers(this IReadOnlyList<string> list)
		{
			return null;
		}

		[Token(Token = "0x60008F4")]
		public static void ReplaceWithLast<T>(this List<T> li, int i)
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x849FA0", Offset = "0x849FA0", VA = "0x849FA0")]
		public static string FindNextLineStartingWith(this IReadOnlyList<string> list, string startsWith, int index = 0)
		{
			return null;
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x84A16C", Offset = "0x84A16C", VA = "0x84A16C")]
		public static string FindNextLineStartingWith(this IReadOnlyList<string> list, string startsWith, ref int index)
		{
			return null;
		}
	}
	[Token(Token = "0x200023A")]
	public static class BoundsExtensions
	{
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x84A354", Offset = "0x84A354", VA = "0x84A354")]
		public static Bounds Scale(this Bounds bounds, Vector3 scale)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x84A3EC", Offset = "0x84A3EC", VA = "0x84A3EC")]
		public static Bounds Scale(this Bounds bounds, float scale)
		{
			return default(Bounds);
		}
	}
	[Token(Token = "0x200023B")]
	public static class ComponentExtensions
	{
		[Token(Token = "0x60008F9")]
		public static T AddComponent<T>(this Component component) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x84A464", Offset = "0x84A464", VA = "0x84A464")]
		public static Component AddComponent(this Component component, Type type)
		{
			return null;
		}

		[Token(Token = "0x60008FB")]
		public static T GetOrAddComponent<T>(this Component component) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60008FC")]
		public static void SetActive<T>(this T component, bool active) where T : Component
		{
		}

		[Token(Token = "0x60008FD")]
		public static void SetActive<T>(this IReadOnlyList<T> component, bool active) where T : Component
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x84A490", Offset = "0x84A490", VA = "0x84A490")]
		public static void SetActive(this IReadOnlyList<GameObject> gameObjects, bool active)
		{
		}
	}
	[Token(Token = "0x200023C")]
	public static class EnumExtensions
	{
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x84A5F8", Offset = "0x84A5F8", VA = "0x84A5F8")]
		public static int GetLength(this Type enumType)
		{
			return default(int);
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x84A660", Offset = "0x84A660", VA = "0x84A660")]
		public static int GetLength(this Enum enu)
		{
			return default(int);
		}

		[Token(Token = "0x6000901")]
		public static int GetLength<T>(T item) where T : Enum
		{
			return default(int);
		}

		[Token(Token = "0x6000902")]
		public static int GetLength<T>() where T : Enum
		{
			return default(int);
		}

		[Token(Token = "0x6000903")]
		public static int ToInt<T>(this T @enum) where T : Enum
		{
			return default(int);
		}

		[Token(Token = "0x6000904")]
		public static T ToEnum<T>(this int value) where T : Enum
		{
			return (T)null;
		}

		[Token(Token = "0x6000905")]
		public static T ToEnum<T>(this string value) where T : struct, Enum
		{
			return (T)null;
		}
	}
	[Token(Token = "0x200023D")]
	public static class FloatExtensions
	{
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x84A6E0", Offset = "0x84A6E0", VA = "0x84A6E0")]
		public static float Snap(this float value, float snapValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x84A774", Offset = "0x84A774", VA = "0x84A774")]
		public static Vector3 ToVector3(this float value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x84A780", Offset = "0x84A780", VA = "0x84A780")]
		public static Vector2 ToVector2(this float value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x84A788", Offset = "0x84A788", VA = "0x84A788")]
		public static Quaternion ToRotation(this float angle, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x84A790", Offset = "0x84A790", VA = "0x84A790")]
		public static float Sqr(this float value)
		{
			return default(float);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x84A798", Offset = "0x84A798", VA = "0x84A798")]
		public static float Pow(this float value, float power)
		{
			return default(float);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x84A79C", Offset = "0x84A79C", VA = "0x84A79C")]
		public static float Cube(this float value)
		{
			return default(float);
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x84A7A8", Offset = "0x84A7A8", VA = "0x84A7A8")]
		public static float Clamp(this float value, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x84A7BC", Offset = "0x84A7BC", VA = "0x84A7BC")]
		public static float Clamp01(this float value)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200023E")]
	public static class Matrix4x4Extensions
	{
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x84A7D4", Offset = "0x84A7D4", VA = "0x84A7D4")]
		public static Matrix4x4 SetScale(this Matrix4x4 matrix, float scale)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x84A880", Offset = "0x84A880", VA = "0x84A880")]
		public static Matrix4x4 MultiplyScale(this Matrix4x4 matrix, float scale)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x84A94C", Offset = "0x84A94C", VA = "0x84A94C")]
		public static Vector3 GetPosition(this Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x84A958", Offset = "0x84A958", VA = "0x84A958")]
		public static Quaternion GetRotation(this Matrix4x4 matrix)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x84A960", Offset = "0x84A960", VA = "0x84A960")]
		public static Vector3 GetScale(this Matrix4x4 matrix)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200023F")]
	public static class QuaternionsExtensions
	{
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x84A968", Offset = "0x84A968", VA = "0x84A968")]
		public static Vector3 ToAngularVelocity(this Quaternion delta)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x84A9C8", Offset = "0x84A9C8", VA = "0x84A9C8")]
		public static Quaternion GetDelta(this Quaternion rotation, Quaternion oldRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x84AA7C", Offset = "0x84AA7C", VA = "0x84AA7C")]
		public static Vector4 ToVector4(this Quaternion rotation)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x84AA80", Offset = "0x84AA80", VA = "0x84AA80")]
		public static float GetAngle(this Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x84AB38", Offset = "0x84AB38", VA = "0x84AB38")]
		public static float GetAngle(this Quaternion rotation, Vector3 axis)
		{
			return default(float);
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x84AD10", Offset = "0x84AD10", VA = "0x84AD10")]
		public static Quaternion Snap(this Quaternion quat, float degrees)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x84ADAC", Offset = "0x84ADAC", VA = "0x84ADAC")]
		public static Quaternion Snap(this Quaternion quat, float degrees, Quaternion currentSnapRotation, float thresholdPercentage)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000240")]
	public static class StringExtensions
	{
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x848574", Offset = "0x848574", VA = "0x848574")]
		public static int GetDeterministicHashCode(this string str)
		{
			return default(int);
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x84AE8C", Offset = "0x84AE8C", VA = "0x84AE8C")]
		public static string SplitCamelCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x84AF40", Offset = "0x84AF40", VA = "0x84AF40")]
		public static string FirstCharToUpper(this string input)
		{
			return null;
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x84B0F0", Offset = "0x84B0F0", VA = "0x84B0F0")]
		public static string FindNextWord(this string str, int index)
		{
			return null;
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x84B288", Offset = "0x84B288", VA = "0x84B288")]
		public static string FindNextWord(this string str, ref int index)
		{
			return null;
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x84B1DC", Offset = "0x84B1DC", VA = "0x84B1DC")]
		public static int FindNextWhitespace(this string str, int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x84B378", Offset = "0x84B378", VA = "0x84B378")]
		public static string FindFirstWordBetween(this string str, char c)
		{
			return null;
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x84B3F0", Offset = "0x84B3F0", VA = "0x84B3F0")]
		public static string GetFileName(this string value, bool includeExtension = true)
		{
			return null;
		}
	}
	[Token(Token = "0x2000241")]
	public static class TransformExtensions
	{
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x84B468", Offset = "0x84B468", VA = "0x84B468")]
		public static void SetActive(this Transform transform, bool active)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x84B494", Offset = "0x84B494", VA = "0x84B494")]
		public static void SetActive(this IList<Transform> transforms, bool active)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x84B5EC", Offset = "0x84B5EC", VA = "0x84B5EC")]
		public static void DestroyAllChildren(this Transform transform)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x84B698", Offset = "0x84B698", VA = "0x84B698")]
		public static void DestroyAllChildren(this Transform transform, bool pooling)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x84B69C", Offset = "0x84B69C", VA = "0x84B69C")]
		public static void DestroyImmediateAllChildren(this Transform transform)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x84B748", Offset = "0x84B748", VA = "0x84B748")]
		public static Transform FindChildByName(this Transform transform, string name)
		{
			return null;
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x84B864", Offset = "0x84B864", VA = "0x84B864")]
		public static void Mirror(this Transform transform, InstantiateData data, bool setParent = true)
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x84B938", Offset = "0x84B938", VA = "0x84B938")]
		public static void Mirror(this Transform target, Transform toCopy, bool setParent = true)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x84BAD4", Offset = "0x84BAD4", VA = "0x84BAD4")]
		public static void Mirror(this Transform target, Matrix4x4 toCopy, Space space = Space.Self)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x84BA0C", Offset = "0x84BA0C", VA = "0x84BA0C")]
		public static void SetLossyScale(this Transform transform, Vector3 lossyScale)
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x84BBD4", Offset = "0x84BBD4", VA = "0x84BBD4")]
		public static void Reset(this Transform transform)
		{
		}
	}
	[Token(Token = "0x2000242")]
	public static class Vector3Extensions
	{
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x84BCB4", Offset = "0x84BCB4", VA = "0x84BCB4")]
		public static Vector3 ToVector3_XZ(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x84BCBC", Offset = "0x84BCBC", VA = "0x84BCBC")]
		public static Vector3 ToVector3_XY(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x84BCC4", Offset = "0x84BCC4", VA = "0x84BCC4")]
		public static Vector3 ToVector3_YZ(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x84BCCC", Offset = "0x84BCCC", VA = "0x84BCCC")]
		public static Vector2 ToVector2_XZ(this Vector3 vector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x84BCD4", Offset = "0x84BCD4", VA = "0x84BCD4")]
		public static Vector2 ToVector2_XY(this Vector3 vector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x84BCD8", Offset = "0x84BCD8", VA = "0x84BCD8")]
		public static Vector2 ToVector2_YZ(this Vector3 vector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x84BCE4", Offset = "0x84BCE4", VA = "0x84BCE4")]
		public static Vector3 ClampMagnitudeXZ(this Vector3 vector, float magnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x84BD90", Offset = "0x84BD90", VA = "0x84BD90")]
		public static Vector3 ClampMagnitudeXY(this Vector3 vector, float magnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x84BE3C", Offset = "0x84BE3C", VA = "0x84BE3C")]
		public static Vector3 ClampMagnitudeYZ(this Vector3 vector, float magnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x84BEE8", Offset = "0x84BEE8", VA = "0x84BEE8")]
		public static Vector3 Snap(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x84AD6C", Offset = "0x84AD6C", VA = "0x84AD6C")]
		public static Vector3 Snap(this Vector3 vector, float snapValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x84C080", Offset = "0x84C080", VA = "0x84C080")]
		public static Vector3 Snap(this Vector3 vector, float snapValue, Vector3 currentSnapValue, float thresholdPercentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x84A3DC", Offset = "0x84A3DC", VA = "0x84A3DC")]
		public static Vector3 ScaleLink(this Vector3 target, Vector3 other)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000243")]
	[AddComponentMenu("Prototyping/Init", -1)]
	public class Init : MonoBehaviour
	{
		[Token(Token = "0x4000E9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Init instance;

		[Token(Token = "0x4000EA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool isClosingGame;

		[Token(Token = "0x1700007B")]
		private static Init Instance
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x84C284", Offset = "0x84C284", VA = "0x84C284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public static bool IsClosingGame
		{
			[Token(Token = "0x600093C")]
			[Address(RVA = "0x84C3A4", Offset = "0x84C3A4", VA = "0x84C3A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x84C3EC", Offset = "0x84C3EC", VA = "0x84C3EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x84C4E8", Offset = "0x84C4E8", VA = "0x84C4E8")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x84C534", Offset = "0x84C534", VA = "0x84C534")]
		public Init()
		{
		}
	}
	[Token(Token = "0x2000244")]
	public class LevelEditorScene : MonoBehaviour
	{
		[Token(Token = "0x1700007D")]
		public static Transform LevelParent
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x84C53C", Offset = "0x84C53C", VA = "0x84C53C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x84C584", Offset = "0x84C584", VA = "0x84C584")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x84C5D0", Offset = "0x84C5D0", VA = "0x84C5D0")]
		public LevelEditorScene()
		{
		}
	}
	[Token(Token = "0x2000245")]
	public class Platform : MonoBehaviour, VRGrabInterface
	{
		[Token(Token = "0x4000EA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Readonly]
		[Tooltip("Set Start scale through settings")]
		private float scale;

		[Token(Token = "0x4000EA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform parent;

		[Token(Token = "0x4000EA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRGrab hand;

		[Token(Token = "0x4000EA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PositionRotation positionRotation;

		[Token(Token = "0x1700007E")]
		private MonoBehaviour LevelEditorAPI.VR.VRGrabInterface.Mono
		{
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x84CB10", Offset = "0x84CB10", VA = "0x84CB10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x84C5D8", Offset = "0x84C5D8", VA = "0x84C5D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x84C700", Offset = "0x84C700", VA = "0x84C700")]
		public void Update()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x84C784", Offset = "0x84C784", VA = "0x84C784")]
		private void Rotate(float deltaTime)
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x84C818", Offset = "0x84C818", VA = "0x84C818")]
		private void Scale(float deltaTime)
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x84CB14", Offset = "0x84CB14", VA = "0x84CB14", Slot = "5")]
		private bool LevelEditorAPI.VR.VRGrabInterface.CanGrab(VRGrab grab)
		{
			return default(bool);
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x84CB1C", Offset = "0x84CB1C", VA = "0x84CB1C", Slot = "6")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrab(VRGrab grab)
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x84CDF0", Offset = "0x84CDF0", VA = "0x84CDF0", Slot = "7")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrabUpdate(VRGrab grab, float input, float deltaTime)
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x84CFE8", Offset = "0x84CFE8", VA = "0x84CFE8", Slot = "8")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnRelease(VRGrab grab)
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x84CFF0", Offset = "0x84CFF0", VA = "0x84CFF0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x84D1D4", Offset = "0x84D1D4", VA = "0x84D1D4")]
		public Platform()
		{
		}
	}
	[Token(Token = "0x2000246")]
	public class PlatformHandleRotation : MonoBehaviour, VRGrabInterface
	{
		[Token(Token = "0x4000EA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 axis;

		[Token(Token = "0x4000EA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion oldRotation;

		[Token(Token = "0x4000EA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform parent;

		[Token(Token = "0x4000EA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform editingPlatform;

		[Token(Token = "0x4000EAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public VRGrab currentGrab;

		[Token(Token = "0x4000EAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int index;

		[Token(Token = "0x4000EAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float deltaTimeToFixed;

		[Token(Token = "0x4000EAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion storedInertia;

		[Token(Token = "0x4000EAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] inertiaArray;

		[Token(Token = "0x4000EAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion inertia;

		[Token(Token = "0x4000EB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool doLateUpdate;

		[Token(Token = "0x1700007F")]
		private Quaternion AverageInertia
		{
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x84D1DC", Offset = "0x84D1DC", VA = "0x84D1DC")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000080")]
		private MonoBehaviour LevelEditorAPI.VR.VRGrabInterface.Mono
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x84D538", Offset = "0x84D538", VA = "0x84D538", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x84D304", Offset = "0x84D304", VA = "0x84D304")]
		private void Start()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x84D354", Offset = "0x84D354", VA = "0x84D354")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x84D53C", Offset = "0x84D53C", VA = "0x84D53C", Slot = "5")]
		private bool LevelEditorAPI.VR.VRGrabInterface.CanGrab(VRGrab grab)
		{
			return default(bool);
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x84D544", Offset = "0x84D544", VA = "0x84D544", Slot = "6")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrab(VRGrab grab)
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x84D7EC", Offset = "0x84D7EC", VA = "0x84D7EC", Slot = "7")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrabUpdate(VRGrab grab, float input, float deltaTime)
		{
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x84DB34", Offset = "0x84DB34", VA = "0x84DB34", Slot = "8")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnRelease(VRGrab grab)
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x84DC44", Offset = "0x84DC44", VA = "0x84DC44")]
		public PlatformHandleRotation()
		{
		}
	}
	[Token(Token = "0x2000247")]
	public struct InstantiateData
	{
		[Token(Token = "0x4000EB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x4000EB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion rotation;

		[Token(Token = "0x4000EB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3? scale;

		[Token(Token = "0x4000EB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform parent;

		[Token(Token = "0x17000081")]
		public static InstantiateData Default
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x848660", Offset = "0x848660", VA = "0x848660")]
			get
			{
				return default(InstantiateData);
			}
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x8489EC", Offset = "0x8489EC", VA = "0x8489EC")]
		public InstantiateData(Vector3 position)
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x848AA4", Offset = "0x848AA4", VA = "0x848AA4")]
		public InstantiateData(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x848B28", Offset = "0x848B28", VA = "0x848B28")]
		public InstantiateData(Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x848D2C", Offset = "0x848D2C", VA = "0x848D2C")]
		public InstantiateData(Vector3 position, Quaternion rotation, Transform parent)
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x8488E8", Offset = "0x8488E8", VA = "0x8488E8")]
		public InstantiateData(Transform parent)
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x848CD4", Offset = "0x848CD4", VA = "0x848CD4")]
		public InstantiateData(Vector3 position, Quaternion rotation, Vector3? scale, Transform parent)
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x84DD48", Offset = "0x84DD48", VA = "0x84DD48")]
		public InstantiateData SetParent(Transform parent)
		{
			return default(InstantiateData);
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x84DD64", Offset = "0x84DD64", VA = "0x84DD64")]
		public InstantiateData SetPosition(Vector3 position)
		{
			return default(InstantiateData);
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x84DD88", Offset = "0x84DD88", VA = "0x84DD88")]
		public InstantiateData SetRotation(Quaternion rotation)
		{
			return default(InstantiateData);
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x84DDAC", Offset = "0x84DDAC", VA = "0x84DDAC")]
		public InstantiateData SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
			return default(InstantiateData);
		}
	}
	[Token(Token = "0x2000248")]
	[CreateAssetMenu(fileName = "PrefabDatabase", menuName = "Prototyping/Database/Prefab Database", order = 1)]
	public class PrefabDatabase : SingletonScriptableObject<PrefabDatabase>, IPrefabDatabase
	{
		[Token(Token = "0x4000EB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Prefab> items;

		[Token(Token = "0x4000EB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, Prefab> prefabLookUp;

		[Token(Token = "0x17000082")]
		protected override bool KeepInResources
		{
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x84DDD8", Offset = "0x84DDD8", VA = "0x84DDD8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		protected override bool AllowAssignInstance
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x84DDE0", Offset = "0x84DDE0", VA = "0x84DDE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public Prefab this[int index]
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x84DF38", Offset = "0x84DF38", VA = "0x84DF38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public Prefab this[string name]
		{
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x84DF90", Offset = "0x84DF90", VA = "0x84DF90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public int Length
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x84E06C", Offset = "0x84E06C", VA = "0x84E06C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000087")]
		public IPrefabDatabase Edit
		{
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x84E0B4", Offset = "0x84E0B4", VA = "0x84E0B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x84DDE8", Offset = "0x84DDE8", VA = "0x84DDE8", Slot = "6")]
		protected override void OnSingletonCreation()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x84E0B8", Offset = "0x84E0B8", VA = "0x84E0B8")]
		public bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x84E178", Offset = "0x84E178", VA = "0x84E178")]
		[Conditional("UNITY_EDITOR")]
		public void Editor_Initialize()
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x84E1EC", Offset = "0x84E1EC", VA = "0x84E1EC")]
		public Prefab GetPrefabById(int id)
		{
			return null;
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x84E280", Offset = "0x84E280", VA = "0x84E280")]
		public Prefab GetPrefabByIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x84E2FC", Offset = "0x84E2FC", VA = "0x84E2FC")]
		public Prefab GetPrefabByName(string name)
		{
			return null;
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x84E300", Offset = "0x84E300", VA = "0x84E300")]
		public bool HasId(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x84E014", Offset = "0x84E014", VA = "0x84E014")]
		public bool HasId(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x84E320", Offset = "0x84E320", VA = "0x84E320")]
		public bool IsNull(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x84E340", Offset = "0x84E340", VA = "0x84E340")]
		public bool IsNull(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x84E3F4", Offset = "0x84E3F4", VA = "0x84E3F4")]
		public bool HasGameObject(GameObject gameObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x84E498", Offset = "0x84E498", VA = "0x84E498")]
		public bool HasGameObject(GameObject gameObject, out int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x84E544", Offset = "0x84E544", VA = "0x84E544")]
		public int GetId(GameObject gameObject)
		{
			return default(int);
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x84E614", Offset = "0x84E614", VA = "0x84E614")]
		public int GetIndex(GameObject gameObject)
		{
			return default(int);
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x84E6B4", Offset = "0x84E6B4", VA = "0x84E6B4")]
		public static int NameToId(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x846DE8", Offset = "0x846DE8", VA = "0x846DE8")]
		public static Prefab GetPrefab(int id)
		{
			return null;
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x84E6B8", Offset = "0x84E6B8", VA = "0x84E6B8")]
		public static Prefab GetPrefab(string name)
		{
			return null;
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x84E70C", Offset = "0x84E70C", VA = "0x84E70C")]
		public static bool HasIdCheck(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x84E760", Offset = "0x84E760", VA = "0x84E760")]
		public static bool HasIdCheck(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x84E7C4", Offset = "0x84E7C4", VA = "0x84E7C4")]
		public static bool IsNullCheck(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x84E818", Offset = "0x84E818", VA = "0x84E818")]
		public static bool IsNullCheck(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x84E87C", Offset = "0x84E87C", VA = "0x84E87C")]
		public static void Destroy(GameObject gameObject)
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x84E928", Offset = "0x84E928", VA = "0x84E928")]
		public static void Destroy(GameObject gameObject, Prefab prefab)
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x84E93C", Offset = "0x84E93C", VA = "0x84E93C")]
		public static void Destroy(GameObject gameObject, int prefabId)
		{
		}

		[Token(Token = "0x6000980")]
		public static void Destroy<T>(T component) where T : Component
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x84E9EC", Offset = "0x84E9EC", VA = "0x84E9EC", Slot = "8")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.AddItem(Prefab prefab)
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x84EB34", Offset = "0x84EB34", VA = "0x84EB34", Slot = "9")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.AddItems(IReadOnlyList<Prefab> prefabs)
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x84ECE0", Offset = "0x84ECE0", VA = "0x84ECE0", Slot = "10")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.RemoveItem(Prefab prefab)
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x84EDB4", Offset = "0x84EDB4", VA = "0x84EDB4", Slot = "11")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.RemoveItem(int id)
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x84EE7C", Offset = "0x84EE7C", VA = "0x84EE7C", Slot = "12")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.RemoveItem(string name)
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x84EF30", Offset = "0x84EF30", VA = "0x84EF30", Slot = "13")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.RemoveItemByIndex(int index)
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x84F050", Offset = "0x84F050", VA = "0x84F050", Slot = "14")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.Clear()
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x84F0D8", Offset = "0x84F0D8", VA = "0x84F0D8", Slot = "15")]
		private Prefab LevelEditorAPI.InternalPrefab.IPrefabDatabase.GetItemByIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x84F130", Offset = "0x84F130", VA = "0x84F130", Slot = "16")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.SetItemByIndex(int index, Prefab prefab)
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x84F198", Offset = "0x84F198", VA = "0x84F198")]
		public Prefab[] Where(Func<Prefab, bool> predicate)
		{
			return null;
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x84F20C", Offset = "0x84F20C", VA = "0x84F20C")]
		public PrefabDatabase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000249")]
	[CreateAssetMenu(fileName = "PlatformSettings", menuName = "Level Editor/Settings/Platform Settings", order = 5)]
	public class PlatformSettings : SingletonScriptableObject<PlatformSettings>
	{
		[Token(Token = "0x200024A")]
		[Flags]
		public enum MovementMode
		{
			[Token(Token = "0x4000EC0")]
			None = 0,
			[Token(Token = "0x4000EC1")]
			Flat_XZ = 1,
			[Token(Token = "0x4000EC2")]
			Pole_Y = 2,
			[Token(Token = "0x4000EC3")]
			Free_XYZ = 3
		}

		[Token(Token = "0x200024B")]
		public enum RotationMode
		{
			[Token(Token = "0x4000EC5")]
			None,
			[Token(Token = "0x4000EC6")]
			HandleOnly,
			[Token(Token = "0x4000EC7")]
			FreeRotation
		}

		[Token(Token = "0x4000EB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Movement")]
		[SerializeField]
		private MovementMode movementMode;

		[Token(Token = "0x4000EB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Header("Rotation")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x4000EB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool recordInertiaOnHandle;

		[Token(Token = "0x4000EBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool inverse;

		[Token(Token = "0x4000EBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 360f)]
		[SerializeField]
		[Tooltip("Degrees per second.")]
		private float platformRotationSpeed;

		[Token(Token = "0x4000EBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Scale")]
		[Tooltip("Range between 0 and 1, scale value is set through platform scale curve")]
		[SerializeField]
		[Range(0f, 1f)]
		private float startScale;

		[Token(Token = "0x4000EBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("1sec / platformScaleSpeed = duration from smallest to largest scale.")]
		[SerializeField]
		[Range(0f, 5f)]
		private float platfromScaleSpeed;

		[Token(Token = "0x4000EBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The scale the platform should be at certain values between [0->1]")]
		[SerializeField]
		private AnimationCurve platformScaleCurve;

		[Token(Token = "0x17000088")]
		protected override bool AllowAssignInstance
		{
			[Token(Token = "0x600098C")]
			[Address(RVA = "0x84F2E0", Offset = "0x84F2E0", VA = "0x84F2E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		public bool AllowMovementXZ
		{
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x84CFC0", Offset = "0x84CFC0", VA = "0x84CFC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008A")]
		public bool AllowMovementY
		{
			[Token(Token = "0x600098F")]
			[Address(RVA = "0x84CFCC", Offset = "0x84CFCC", VA = "0x84CFCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public bool IsFreeMovement
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0x84F330", Offset = "0x84F330", VA = "0x84F330")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008C")]
		public bool AllowFreeRotation
		{
			[Token(Token = "0x6000991")]
			[Address(RVA = "0x84CFD8", Offset = "0x84CFD8", VA = "0x84CFD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008D")]
		public bool AllowHandleRotation
		{
			[Token(Token = "0x6000992")]
			[Address(RVA = "0x84C774", Offset = "0x84C774", VA = "0x84C774")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008E")]
		public bool RecordInertia
		{
			[Token(Token = "0x6000993")]
			[Address(RVA = "0x84F340", Offset = "0x84F340", VA = "0x84F340")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008F")]
		public float PlatformRotationSpeed
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x84F348", Offset = "0x84F348", VA = "0x84F348")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000090")]
		public float PlatformStartScale
		{
			[Token(Token = "0x6000995")]
			[Address(RVA = "0x84F350", Offset = "0x84F350", VA = "0x84F350")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000091")]
		public float PlatformScaleSpeed
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x84F358", Offset = "0x84F358", VA = "0x84F358")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000092")]
		public AnimationCurve PlatformScaleCurve
		{
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x84F360", Offset = "0x84F360", VA = "0x84F360")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x84F2E8", Offset = "0x84F2E8", VA = "0x84F2E8")]
		public void Assign()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x84CA00", Offset = "0x84CA00", VA = "0x84CA00")]
		public Quaternion GetRotation(Quaternion rotation, float deltaTime, float input)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x84C6A4", Offset = "0x84C6A4", VA = "0x84C6A4")]
		public Vector3 GetScale(ref float scale, float deltaTime, float input)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x84C894", Offset = "0x84C894", VA = "0x84C894")]
		public void SetScaleToFitCurve(ref float scale)
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x84F368", Offset = "0x84F368", VA = "0x84F368")]
		public void SetMovementMode(MovementMode mode)
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x84F370", Offset = "0x84F370", VA = "0x84F370")]
		public void SetRotationMode(RotationMode mode)
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x84F378", Offset = "0x84F378", VA = "0x84F378")]
		public void SetInertiaOnHandle(bool active)
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x84F384", Offset = "0x84F384", VA = "0x84F384")]
		public void SetPlatformRotationSpeed(float degreesPerSecond, bool inverse = true)
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x84F398", Offset = "0x84F398", VA = "0x84F398")]
		public void SetPlatformScaleSpeed(float value)
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x84F3A0", Offset = "0x84F3A0", VA = "0x84F3A0")]
		public void SetPlatformScaleCurve(AnimationCurve curve)
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x84F3A8", Offset = "0x84F3A8", VA = "0x84F3A8")]
		public PlatformSettings()
		{
		}
	}
	[Token(Token = "0x200024C")]
	[CreateAssetMenu(fileName = "SceneSettings", menuName = "Level Editor/Settings/Scene Settings", order = 8)]
	public class SceneSettings : SingletonScriptableObject<SceneSettings>
	{
		[Token(Token = "0x4000EC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Readonly(true)]
		[SerializeField]
		private bool forceDisableAllScenes;

		[Token(Token = "0x4000EC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Readonly(true)]
		[SerializeField]
		private bool setEditorSceneActive;

		[NonSerialized]
		[Token(Token = "0x4000ECA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Scene nonLevelEditor;

		[Token(Token = "0x17000093")]
		protected override bool AllowAssignInstance
		{
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x84F430", Offset = "0x84F430", VA = "0x84F430", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000094")]
		public bool ForceDisableAllScenes
		{
			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x84F480", Offset = "0x84F480", VA = "0x84F480")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000095")]
		public bool SetEditorSceneActive
		{
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x84F488", Offset = "0x84F488", VA = "0x84F488")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x84F438", Offset = "0x84F438", VA = "0x84F438")]
		public void Assign()
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x84F490", Offset = "0x84F490", VA = "0x84F490")]
		public SceneSettings()
		{
		}
	}
	[Token(Token = "0x200024D")]
	public static class Settings
	{
		[Token(Token = "0x17000096")]
		public static VisualSettings Visual
		{
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x84F4E0", Offset = "0x84F4E0", VA = "0x84F4E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public static SnapSettings Snap
		{
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x84F520", Offset = "0x84F520", VA = "0x84F520")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public static PlatformSettings Platform
		{
			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x84C664", Offset = "0x84C664", VA = "0x84C664")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public static SceneSettings Scene
		{
			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x84F560", Offset = "0x84F560", VA = "0x84F560")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Token(Token = "0x200024E")]
	[CreateAssetMenu(fileName = "SnapSettings", menuName = "Level Editor/Settings/Snap Settings", order = 2)]
	public class SnapSettings : SingletonScriptableObject<SnapSettings>
	{
		[Token(Token = "0x4000ECB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Snap Settings")]
		[SerializeField]
		private bool useSnap;

		[Token(Token = "0x4000ECC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool useDeadzone;

		[Token(Token = "0x4000ECD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool useGroundCalculation;

		[Token(Token = "0x4000ECE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private SnapPhysicsMode physicsMode;

		[Token(Token = "0x4000ECF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Position Snap")]
		[SerializeField]
		private float gridSnapSize;

		[Token(Token = "0x4000ED0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float maxSweepTestDistance;

		[Token(Token = "0x4000ED1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[SerializeField]
		private float gridSnapDeadzone;

		[Token(Token = "0x4000ED2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Header("Rotation Snap")]
		[SerializeField]
		private float rotationSnapDegrees;

		[Token(Token = "0x4000ED3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[SerializeField]
		private float rotationSnapDeadzone;

		[Token(Token = "0x1700009A")]
		protected override bool AllowAssignInstance
		{
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x84F5A0", Offset = "0x84F5A0", VA = "0x84F5A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009B")]
		public SnapPhysicsMode PhysicsMode
		{
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x84F5F0", Offset = "0x84F5F0", VA = "0x84F5F0")]
			get
			{
				return default(SnapPhysicsMode);
			}
		}

		[Token(Token = "0x1700009C")]
		public bool UseSnap
		{
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x84F5F8", Offset = "0x84F5F8", VA = "0x84F5F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		public bool UseDeadzone
		{
			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x84F600", Offset = "0x84F600", VA = "0x84F600")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009E")]
		public bool UseGroundCalculation
		{
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x84F608", Offset = "0x84F608", VA = "0x84F608")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009F")]
		public float GridSnapSize
		{
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x84F610", Offset = "0x84F610", VA = "0x84F610")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A0")]
		public float GridSnapDeadzone
		{
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x84F618", Offset = "0x84F618", VA = "0x84F618")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A1")]
		public float RotationSnapDegrees
		{
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x84F620", Offset = "0x84F620", VA = "0x84F620")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A2")]
		public float RotationSnapDeadzone
		{
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x84F628", Offset = "0x84F628", VA = "0x84F628")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x84F5A8", Offset = "0x84F5A8", VA = "0x84F5A8")]
		public void Assign()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x84F630", Offset = "0x84F630", VA = "0x84F630")]
		public Vector3 GridSnap(Vector3 currentPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x84F638", Offset = "0x84F638", VA = "0x84F638")]
		public Vector3 GridSnap(Vector3 currentPosition, Vector3 oldSnapPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x84F650", Offset = "0x84F650", VA = "0x84F650")]
		public Quaternion RotationSnap(Quaternion currentRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x84F658", Offset = "0x84F658", VA = "0x84F658")]
		public Quaternion RotationSnap(Quaternion currentRotation, Quaternion oldRotationSnap)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x84F684", Offset = "0x84F684", VA = "0x84F684")]
		public bool Snap(GhostComponent ghost, Transform transform, Vector3 position, Quaternion rotation, LevelBuildingBlock block)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x84FC88", Offset = "0x84FC88", VA = "0x84FC88")]
		public void SetSnap(bool active)
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x84FC94", Offset = "0x84FC94", VA = "0x84FC94")]
		public void SetDeadzone(bool active)
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x84FCA0", Offset = "0x84FCA0", VA = "0x84FCA0")]
		public void SetGroundCalculations(bool active)
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x84FCAC", Offset = "0x84FCAC", VA = "0x84FCAC")]
		public void SetPhysicsMode(SnapPhysicsMode mode)
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x84FCB4", Offset = "0x84FCB4", VA = "0x84FCB4")]
		public void SetGridSize(float value)
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x84FCC4", Offset = "0x84FCC4", VA = "0x84FCC4")]
		public void SetGridDeadzone(float value)
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x84FCE0", Offset = "0x84FCE0", VA = "0x84FCE0")]
		public void SetRotationDegrees(float degrees)
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x84FCE8", Offset = "0x84FCE8", VA = "0x84FCE8")]
		public void SetRotationDeadzone(float value)
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x84FD04", Offset = "0x84FD04", VA = "0x84FD04")]
		public SnapSettings()
		{
		}
	}
	[Token(Token = "0x200024F")]
	public enum SnapPhysicsMode
	{
		[Token(Token = "0x4000ED5")]
		None,
		[Token(Token = "0x4000ED6")]
		Visual,
		[Token(Token = "0x4000ED7")]
		Revert
	}
	[Serializable]
	[Token(Token = "0x2000250")]
	[CreateAssetMenu(fileName = "VisualSettings", menuName = "Level Editor/Settings/Visual Settings", order = 0)]
	public class VisualSettings : SingletonScriptableObject<VisualSettings>
	{
		[Token(Token = "0x2000251")]
		public enum RenderSetting
		{
			[Token(Token = "0x4000EE3")]
			Normal,
			[Token(Token = "0x4000EE4")]
			Wireframe,
			[Token(Token = "0x4000EE5")]
			Ghost,
			[Token(Token = "0x4000EE6")]
			Hidden
		}

		[Token(Token = "0x4000ED8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Draw Grabbed")]
		private RenderSetting grabbedMainRenderSetting;

		[Token(Token = "0x4000ED9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RenderSetting grabbedSubRenderSetting;

		[Token(Token = "0x4000EDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Draw Non-Grabbed")]
		[SerializeField]
		private RenderSetting nonGrabbedRenderingSetting;

		[Token(Token = "0x4000EDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Level Block Visuals")]
		[SerializeField]
		private Material wireframe;

		[Token(Token = "0x4000EDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Material hidden;

		[Token(Token = "0x4000EDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Material ghost;

		[Token(Token = "0x4000EDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Material hover;

		[Token(Token = "0x4000EDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool useHoverRendering;

		[Token(Token = "0x4000EE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Space]
		[SerializeField]
		private Material blockIntersection;

		[Token(Token = "0x4000EE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Material blockSelected;

		[Token(Token = "0x170000A3")]
		protected override bool AllowAssignInstance
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x84FD7C", Offset = "0x84FD7C", VA = "0x84FD7C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A4")]
		public Material Wireframe
		{
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x84FDCC", Offset = "0x84FDCC", VA = "0x84FDCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public Material Hidden
		{
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x84FDD4", Offset = "0x84FDD4", VA = "0x84FDD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		public Material Ghost
		{
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x84FDDC", Offset = "0x84FDDC", VA = "0x84FDDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public Material OnHoverMaterial
		{
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x84FDE4", Offset = "0x84FDE4", VA = "0x84FDE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public bool UseHoverRendering
		{
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x84FDEC", Offset = "0x84FDEC", VA = "0x84FDEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A9")]
		public Material BlockIntersection
		{
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x84FDF4", Offset = "0x84FDF4", VA = "0x84FDF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		public Material BlockSelected
		{
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x84FDFC", Offset = "0x84FDFC", VA = "0x84FDFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public Material NonGrabbed
		{
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x84FE04", Offset = "0x84FE04", VA = "0x84FE04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		public Material GrabbedMainObject
		{
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x84FE44", Offset = "0x84FE44", VA = "0x84FE44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		public Material GrabbedSubObject
		{
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x84FE84", Offset = "0x84FE84", VA = "0x84FE84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x84FD84", Offset = "0x84FD84", VA = "0x84FD84")]
		public void Assign()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x84FEC4", Offset = "0x84FEC4", VA = "0x84FEC4")]
		public void InvertGrabbedRenderingMode()
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x84FED4", Offset = "0x84FED4", VA = "0x84FED4")]
		public void SetGrabbedRenderingSetting(bool main, RenderSetting setting)
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x84FEE8", Offset = "0x84FEE8", VA = "0x84FEE8")]
		public void SetNonGrabbedRenderingSetting(RenderSetting setting)
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x84FEF0", Offset = "0x84FEF0", VA = "0x84FEF0")]
		public VisualSettings()
		{
		}
	}
	[Token(Token = "0x2000252")]
	public class SingletonScriptableObject<T> : ScriptableObject where T : SingletonScriptableObject<T>
	{
		[Token(Token = "0x4000EE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T instance;

		[Token(Token = "0x170000AE")]
		public static T Instance
		{
			[Token(Token = "0x60009D3")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D4")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public static bool HasInstance
		{
			[Token(Token = "0x60009D5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		protected virtual bool KeepInResources
		{
			[Token(Token = "0x60009D6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		protected virtual bool AllowAssignInstance
		{
			[Token(Token = "0x60009D7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009D8")]
		protected void AssignInstance(T newInstance)
		{
		}

		[Token(Token = "0x60009D9")]
		protected virtual void OnSingletonCreation()
		{
		}

		[Token(Token = "0x60009DA")]
		protected virtual void OnSingletonRemoved()
		{
		}

		[Token(Token = "0x60009DB")]
		public SingletonScriptableObject()
		{
		}
	}
	[Token(Token = "0x2000253")]
	[AddComponentMenu("Prototyping/Rendering/Prefab Mesh Drawer")]
	[ExecuteInEditMode]
	public class PrefabMeshDrawer : MonoBehaviour
	{
		[Token(Token = "0x4000EE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject prefab;

		[Token(Token = "0x4000EE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Optional")]
		private Transform target;

		[Token(Token = "0x4000EEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Material overrideMaterial;

		[Token(Token = "0x4000EEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MeshDrawerInstance[] meshDrawerInstances;

		[Token(Token = "0x170000B2")]
		public GameObject GameObject
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x84FF40", Offset = "0x84FF40", VA = "0x84FF40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x84FF48", Offset = "0x84FF48", VA = "0x84FF48")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public Material OverrideMaterial
		{
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x84FFDC", Offset = "0x84FFDC", VA = "0x84FFDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x84FFE4", Offset = "0x84FFE4", VA = "0x84FFE4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public bool HasOverrideMaterial
		{
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x84FFEC", Offset = "0x84FFEC", VA = "0x84FFEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B5")]
		public Transform Target
		{
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x85004C", Offset = "0x85004C", VA = "0x85004C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x8500CC", Offset = "0x8500CC", VA = "0x8500CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public MeshDrawerInstance[] MeshDrawerInstances
		{
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x8500D4", Offset = "0x8500D4", VA = "0x8500D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x8500DC", Offset = "0x8500DC", VA = "0x8500DC")]
		private void ValidateMeshDrawerInstance()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x85017C", Offset = "0x85017C", VA = "0x85017C")]
		private void Start()
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x850180", Offset = "0x850180", VA = "0x850180")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x85029C", Offset = "0x85029C", VA = "0x85029C")]
		public void Draw()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x850188", Offset = "0x850188", VA = "0x850188")]
		public void Draw(Material material)
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x8504D4", Offset = "0x8504D4", VA = "0x8504D4")]
		public void Draw(Material material, Matrix4x4 offset)
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x850704", Offset = "0x850704", VA = "0x850704")]
		public void Assign(GameObject gameObject)
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x84FF4C", Offset = "0x84FF4C", VA = "0x84FF4C")]
		public void SetGameObject(GameObject gameObject)
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x850708", Offset = "0x850708", VA = "0x850708")]
		public void Unload()
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x850714", Offset = "0x850714", VA = "0x850714")]
		public GameObject GetGameObject()
		{
			return null;
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x85071C", Offset = "0x85071C", VA = "0x85071C")]
		public void SetOverrideMaterial(Material material)
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x850724", Offset = "0x850724", VA = "0x850724")]
		public Material GetOverrideMaterial()
		{
			return null;
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x85072C", Offset = "0x85072C", VA = "0x85072C")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x850734", Offset = "0x850734", VA = "0x850734")]
		public Transform GetTarget()
		{
			return null;
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x85073C", Offset = "0x85073C", VA = "0x85073C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x850744", Offset = "0x850744", VA = "0x850744")]
		[Conditional("UNITY_EDITOR")]
		public static void Editor_CreatePrefabMeshDrawer()
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x8507D0", Offset = "0x8507D0", VA = "0x8507D0")]
		public PrefabMeshDrawer()
		{
		}
	}
	[Token(Token = "0x2000254")]
	public class Readonly : PropertyAttribute
	{
		[Token(Token = "0x4000EEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool onlyActiveInRuntime;

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x8507D8", Offset = "0x8507D8", VA = "0x8507D8")]
		public Readonly()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x8507E0", Offset = "0x8507E0", VA = "0x8507E0")]
		public Readonly(bool onlyActiveInRuntime)
		{
		}
	}
	[Token(Token = "0x2000255")]
	public class RGLinkedList<T>
	{
		[Token(Token = "0x4000EED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LinkedNode<T> node;

		[Token(Token = "0x4000EEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int length;

		[Token(Token = "0x170000B7")]
		public int Length
		{
			[Token(Token = "0x60009F7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60009F8")]
		public LinkedNode<T> Add(T item)
		{
			return null;
		}

		[Token(Token = "0x60009F9")]
		public LinkedNode<T> InsertAfter(T item, LinkedNode<T> node)
		{
			return null;
		}

		[Token(Token = "0x60009FA")]
		public LinkedNode<T> InsertBefore(T item, LinkedNode<T> node)
		{
			return null;
		}

		[Token(Token = "0x60009FB")]
		public void Remove(LinkedNode<T> node)
		{
		}

		[Token(Token = "0x60009FC")]
		public void Remove(T obj)
		{
		}

		[Token(Token = "0x60009FD")]
		public T First()
		{
			return (T)null;
		}

		[Token(Token = "0x60009FE")]
		public T Last()
		{
			return (T)null;
		}

		[Token(Token = "0x60009FF")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000A00")]
		public LinkedNode<T> Find(T obj)
		{
			return null;
		}

		[Token(Token = "0x6000A01")]
		public T[] ToArray()
		{
			return null;
		}

		[Token(Token = "0x6000A02")]
		public List<T> ToList()
		{
			return null;
		}

		[Token(Token = "0x6000A03")]
		public Iterator<T> GetIterator()
		{
			return default(Iterator<T>);
		}

		[Token(Token = "0x6000A04")]
		public RGLinkedList()
		{
		}
	}
	[Token(Token = "0x2000256")]
	public struct Iterator<T>
	{
		[Token(Token = "0x4000EEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LinkedNode<T> currentNode;

		[Token(Token = "0x4000EF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LinkedNode<T> startNode;

		[Token(Token = "0x6000A05")]
		public Iterator(LinkedNode<T> startNode)
		{
		}

		[Token(Token = "0x6000A06")]
		public bool Next(out LinkedNode<T> node)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A07")]
		public bool Next(out T node)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A08")]
		public void RemoveCurrent()
		{
		}
	}
	[Token(Token = "0x2000257")]
	public class LinkedNode<T>
	{
		[Token(Token = "0x4000EF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Item;

		[Token(Token = "0x4000EF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RGLinkedList<T> List;

		[Token(Token = "0x4000EF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LinkedNode<T> Prev;

		[Token(Token = "0x4000EF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LinkedNode<T> Next;

		[Token(Token = "0x6000A09")]
		public LinkedNode(T item, RGLinkedList<T> list)
		{
		}

		[Token(Token = "0x6000A0A")]
		public void InsertAfter(LinkedNode<T> node)
		{
		}

		[Token(Token = "0x6000A0B")]
		public void InsertBefore(LinkedNode<T> node)
		{
		}

		[Token(Token = "0x6000A0C")]
		public void Remove()
		{
		}
	}
	[Token(Token = "0x2000258")]
	public static class Sort
	{
		[Token(Token = "0x6000A0D")]
		public static void Merge<T>(IList<T> array, Comparison<T> comparison)
		{
		}
	}
	[Token(Token = "0x2000259")]
	public static class Sort<T>
	{
		[Token(Token = "0x4000EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T[] subArray;

		[Token(Token = "0x6000A0E")]
		public static void Merge(IList<T> array, Comparison<T> comparison)
		{
		}

		[Token(Token = "0x6000A0F")]
		private static void InternalMerge(IList<T> array, Comparison<T> comparison, int from, int to)
		{
		}
	}
	[Token(Token = "0x200025A")]
	public static class SortExtensions
	{
		[Token(Token = "0x6000A10")]
		public static void MergeSort<T>(this IList<T> array, Comparison<T> comparison)
		{
		}
	}
	[Serializable]
	[StructLayout(2)]
	[Token(Token = "0x200025B")]
	public struct TextField : ISerializationCallbackReceiver
	{
		[Token(Token = "0x200025C")]
		private enum TextType
		{
			[Token(Token = "0x4000EFB")]
			None,
			[Token(Token = "0x4000EFC")]
			UI,
			[Token(Token = "0x4000EFD")]
			TextMesh,
			[Token(Token = "0x4000EFE")]
			TextMeshPro
		}

		[Token(Token = "0x4000EF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private UnityEngine.Object labelObject;

		[NonSerialized]
		[Token(Token = "0x4000EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Text label;

		[NonSerialized]
		[Token(Token = "0x4000EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TextMesh textMesh;

		[NonSerialized]
		[Token(Token = "0x4000EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private TextType textType;

		[Token(Token = "0x170000B8")]
		public bool HasTextField
		{
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x850808", Offset = "0x850808", VA = "0x850808")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B9")]
		public string Text
		{
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x850868", Offset = "0x850868", VA = "0x850868")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x850900", Offset = "0x850900", VA = "0x850900")]
			set
			{
			}
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x8509A4", Offset = "0x8509A4", VA = "0x8509A4")]
		public TextField(Text label)
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x8509B4", Offset = "0x8509B4", VA = "0x8509B4")]
		public TextField(TextMesh textMesh)
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x8509C4", Offset = "0x8509C4", VA = "0x8509C4")]
		public static implicit operator TextField(Text label)
		{
			return default(TextField);
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x8509CC", Offset = "0x8509CC", VA = "0x8509CC")]
		public static implicit operator TextField(TextMesh label)
		{
			return default(TextField);
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x8509D4", Offset = "0x8509D4", VA = "0x8509D4", Slot = "4")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x8509D8", Offset = "0x8509D8", VA = "0x8509D8", Slot = "5")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x850A80", Offset = "0x850A80", VA = "0x850A80")]
		public static TextField GetTextField(GameObject gameObject)
		{
			return default(TextField);
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x850B70", Offset = "0x850B70", VA = "0x850B70")]
		public static TextField GetTextField(Component component)
		{
			return default(TextField);
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x850B8C", Offset = "0x850B8C", VA = "0x850B8C")]
		public static TextField GetTextFieldInChildren(GameObject gameObject)
		{
			return default(TextField);
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x850C7C", Offset = "0x850C7C", VA = "0x850C7C")]
		public static TextField GetTextFieldInChildren(Component component)
		{
			return default(TextField);
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x850C98", Offset = "0x850C98", VA = "0x850C98")]
		public static TextField GetTextFieldInParent(GameObject gameObject)
		{
			return default(TextField);
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x850D88", Offset = "0x850D88", VA = "0x850D88")]
		public static TextField GetTextFieldInParent(Component component)
		{
			return default(TextField);
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x850DA4", Offset = "0x850DA4", VA = "0x850DA4")]
		public static TextField[] GetTextFields(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x850FCC", Offset = "0x850FCC", VA = "0x850FCC")]
		public static TextField[] GetTextFields(Component component)
		{
			return null;
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x850FE8", Offset = "0x850FE8", VA = "0x850FE8")]
		public static TextField[] GetTextFieldsInChildren(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x851210", Offset = "0x851210", VA = "0x851210")]
		public static TextField[] GetTextFieldsInChildren(Component component)
		{
			return null;
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x85122C", Offset = "0x85122C", VA = "0x85122C")]
		public static TextField[] GetTextFieldsInParent(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x851454", Offset = "0x851454", VA = "0x851454")]
		public static TextField[] GetTextFieldsInParent(Component component)
		{
			return null;
		}
	}
	[Token(Token = "0x200025D")]
	public class UnityObjectFilter : PropertyAttribute
	{
		[Token(Token = "0x4000EFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type type;

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x851470", Offset = "0x851470", VA = "0x851470")]
		public UnityObjectFilter(Type type)
		{
		}
	}
	[Token(Token = "0x200025E")]
	public class UnityObjectFilterScene : PropertyAttribute
	{
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x851498", Offset = "0x851498", VA = "0x851498")]
		public UnityObjectFilterScene()
		{
		}
	}
}
namespace LevelEditorAPI.VR
{
	[Token(Token = "0x200025F")]
	public enum VRHand
	{
		[Token(Token = "0x4000F01")]
		None,
		[Token(Token = "0x4000F02")]
		Left,
		[Token(Token = "0x4000F03")]
		Right
	}
	[Token(Token = "0x2000260")]
	public static class VRHandExtensions
	{
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x8514A0", Offset = "0x8514A0", VA = "0x8514A0")]
		public static InputType ToXRNode(this VRHand hand)
		{
			return default(InputType);
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x8514BC", Offset = "0x8514BC", VA = "0x8514BC")]
		public static VRHand ToVRHand(this XRNode node)
		{
			return default(VRHand);
		}
	}
	[Token(Token = "0x2000261")]
	public static class VRInput
	{
		[Token(Token = "0x2000262")]
		public enum DeviceType
		{
			[Token(Token = "0x4000F07")]
			Oculus
		}

		[Token(Token = "0x4000F04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IVRInput_ActionMap actionMap;

		[Token(Token = "0x4000F05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DeviceType deviceType;

		[Token(Token = "0x170000BA")]
		public static IVRInput_ActionMap ActionMap
		{
			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x8514DC", Offset = "0x8514DC", VA = "0x8514DC")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x851524", Offset = "0x851524", VA = "0x851524")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public static float LeftGrab
		{
			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x851570", Offset = "0x851570", VA = "0x851570")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000BC")]
		public static float RightGrab
		{
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x851634", Offset = "0x851634", VA = "0x851634")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000BD")]
		public static float LeftEventSystem
		{
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x8516FC", Offset = "0x8516FC", VA = "0x8516FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000BE")]
		public static bool LeftEventSystem_Button
		{
			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x8517C4", Offset = "0x8517C4", VA = "0x8517C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BF")]
		public static float RightEventSystem
		{
			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x85188C", Offset = "0x85188C", VA = "0x85188C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C0")]
		public static bool RightEventSystem_Button
		{
			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x851954", Offset = "0x851954", VA = "0x851954")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C1")]
		public static bool Recenter
		{
			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x851A1C", Offset = "0x851A1C", VA = "0x851A1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x851AE4", Offset = "0x851AE4", VA = "0x851AE4")]
		public static void SetDeviceType(DeviceType type)
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x851B30", Offset = "0x851B30", VA = "0x851B30")]
		public static DeviceType GetDeviceType()
		{
			return default(DeviceType);
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x851B78", Offset = "0x851B78", VA = "0x851B78")]
		public static float Grab(VRHand hand)
		{
			return default(float);
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x851B98", Offset = "0x851B98", VA = "0x851B98")]
		public static float EventSystem(VRHand hand)
		{
			return default(float);
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x851BB8", Offset = "0x851BB8", VA = "0x851BB8")]
		public static Vector3 LocalPosition(InputType node)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x851C90", Offset = "0x851C90", VA = "0x851C90")]
		public static Quaternion LocalRotation(InputType node)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000263")]
	public interface IVRInput_ActionMap
	{
		[Token(Token = "0x170000C2")]
		float LeftGrab
		{
			[Token(Token = "0x6000A39")]
			get;
		}

		[Token(Token = "0x170000C3")]
		float RightGrab
		{
			[Token(Token = "0x6000A3A")]
			get;
		}

		[Token(Token = "0x170000C4")]
		bool Recenter
		{
			[Token(Token = "0x6000A3B")]
			get;
		}

		[Token(Token = "0x170000C5")]
		float LeftEventSystem
		{
			[Token(Token = "0x6000A3C")]
			get;
		}

		[Token(Token = "0x170000C6")]
		bool LeftEventSystem_Button
		{
			[Token(Token = "0x6000A3D")]
			get;
		}

		[Token(Token = "0x170000C7")]
		float RightEventSystem
		{
			[Token(Token = "0x6000A3E")]
			get;
		}

		[Token(Token = "0x170000C8")]
		bool RightEventSystem_Button
		{
			[Token(Token = "0x6000A3F")]
			get;
		}

		[Token(Token = "0x6000A40")]
		Vector3 LocalPosition(InputType node);

		[Token(Token = "0x6000A41")]
		Quaternion LocalRotation(InputType node);
	}
	[Token(Token = "0x2000264")]
	public sealed class VRInput_Palazzo : IVRInput_ActionMap
	{
		[Token(Token = "0x4000F08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly InputHandler inputHandler;

		[Token(Token = "0x170000C9")]
		public float LeftGrab
		{
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x851D90", Offset = "0x851D90", VA = "0x851D90", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CA")]
		public float RightGrab
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x851DB0", Offset = "0x851DB0", VA = "0x851DB0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CB")]
		public float LeftEventSystem
		{
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x851DD0", Offset = "0x851DD0", VA = "0x851DD0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CC")]
		public bool LeftEventSystem_Button
		{
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x851DD8", Offset = "0x851DD8", VA = "0x851DD8", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CD")]
		public float RightEventSystem
		{
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x851E70", Offset = "0x851E70", VA = "0x851E70", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CE")]
		public bool RightEventSystem_Button
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x851E78", Offset = "0x851E78", VA = "0x851E78", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		public bool Recenter
		{
			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x851F18", Offset = "0x851F18", VA = "0x851F18", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x851D68", Offset = "0x851D68", VA = "0x851D68")]
		public VRInput_Palazzo(InputHandler inputHandler)
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x851F20", Offset = "0x851F20", VA = "0x851F20", Slot = "11")]
		public Vector3 LocalPosition(InputType node)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x851F3C", Offset = "0x851F3C", VA = "0x851F3C", Slot = "12")]
		public Quaternion LocalRotation(InputType node)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000265")]
	public static class VRSimplify
	{
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x84CCAC", Offset = "0x84CCAC", VA = "0x84CCAC")]
		public static PositionRotation Grab(VRGrab hand, Transform target)
		{
			return default(PositionRotation);
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x84CE9C", Offset = "0x84CE9C", VA = "0x84CE9C")]
		public static PositionRotation Update(VRGrab hand, PositionRotation positionRotation)
		{
			return default(PositionRotation);
		}
	}
	[Token(Token = "0x2000266")]
	[AddComponentMenu("Prototyping/VR/Grab")]
	public class VRGrab : MonoBehaviour
	{
		[Token(Token = "0x4000F09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Settings")]
		[SerializeField]
		private VRHand hand;

		[Token(Token = "0x4000F0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grabThreshold;

		[Token(Token = "0x4000F0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0f, 32f)]
		[Header("Physics")]
		private int maxGrabObjects;

		[Token(Token = "0x4000F0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float grabRadius;

		[Token(Token = "0x4000F0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform targetGrabPosition;

		[Token(Token = "0x4000F0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool raycastGrab;

		[Token(Token = "0x4000F0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<VRGrabInterface> grabbedTargets;

		[Token(Token = "0x4000F10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float inputValue;

		[Token(Token = "0x4000F11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool hasGrabbed;

		[Token(Token = "0x4000F12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Collider[] colliders;

		[Token(Token = "0x4000F13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static RaycastHit[] hits;

		[Token(Token = "0x4000F14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LayerMask mask;

		[Token(Token = "0x4000F15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float? scale;

		[Token(Token = "0x4000F18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public PalazzoTriggers palazzoTriggers;

		[Token(Token = "0x4000F19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool aimHit;

		[Token(Token = "0x4000F1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		public bool locked;

		[Token(Token = "0x170000D0")]
		public VRHand Hand
		{
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x852260", Offset = "0x852260", VA = "0x852260")]
			get
			{
				return default(VRHand);
			}
		}

		[Token(Token = "0x170000D1")]
		public int MaxObjects
		{
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x852268", Offset = "0x852268", VA = "0x852268")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D2")]
		public int CurrentObjects
		{
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x852270", Offset = "0x852270", VA = "0x852270")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D3")]
		public float InputValue
		{
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x8522B8", Offset = "0x8522B8", VA = "0x8522B8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D4")]
		public float GrabRadius
		{
			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x8522C0", Offset = "0x8522C0", VA = "0x8522C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D5")]
		public float GrabThreshold
		{
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x85236C", Offset = "0x85236C", VA = "0x85236C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D6")]
		public Vector3 GrabPosition
		{
			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x84D768", Offset = "0x84D768", VA = "0x84D768")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D7")]
		public Quaternion GrabRotation
		{
			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x851F58", Offset = "0x851F58", VA = "0x851F58")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x170000D8")]
		public Transform Target
		{
			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x8522F0", Offset = "0x8522F0", VA = "0x8522F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		public float Scale
		{
			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x852374", Offset = "0x852374", VA = "0x852374")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000DA")]
		public bool IsGrabbing
		{
			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x85241C", Offset = "0x85241C", VA = "0x85241C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000002")]
		public event Action onGrab
		{
			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x851FF0", Offset = "0x851FF0", VA = "0x851FF0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x85208C", Offset = "0x85208C", VA = "0x85208C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action onRelease
		{
			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x852128", Offset = "0x852128", VA = "0x852128")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x8521C4", Offset = "0x8521C4", VA = "0x8521C4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x85246C", Offset = "0x85246C", VA = "0x85246C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x852928", Offset = "0x852928", VA = "0x852928")]
		public void Grab()
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x852784", Offset = "0x852784", VA = "0x852784")]
		private void RaycastGrab()
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x85287C", Offset = "0x85287C", VA = "0x85287C")]
		public void Release()
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x852B40", Offset = "0x852B40", VA = "0x852B40")]
		public void Grab(VRGrabInterface grabInterface)
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x84CBD0", Offset = "0x84CBD0", VA = "0x84CBD0")]
		public void Release(VRGrabInterface grabInterface)
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x852C78", Offset = "0x852C78", VA = "0x852C78")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x852CC4", Offset = "0x852CC4", VA = "0x852CC4")]
		public VRGrab()
		{
		}
	}
	[Token(Token = "0x2000267")]
	[AddComponentMenu("Prototyping/VR/Grabbable")]
	public class VRGrabbable : MonoBehaviour, VRGrabInterface, VRGrabDataInterface, VRGrabEventInterface
	{
		[Token(Token = "0x2000268")]
		public enum GrabbableSnapType
		{
			[Token(Token = "0x4000F31")]
			None,
			[Token(Token = "0x4000F32")]
			Lerp,
			[Token(Token = "0x4000F33")]
			Snap
		}

		[Token(Token = "0x4000F1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Settings")]
		private bool setAsChild;

		[Token(Token = "0x4000F1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool canSwitchHand;

		[Token(Token = "0x4000F1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Header("Snap Settings")]
		private GrabbableSnapType snapType;

		[Token(Token = "0x4000F1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0f, 20f)]
		private float lerpSpeed;

		[Token(Token = "0x4000F1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool enablePosition;

		[Token(Token = "0x4000F20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 localPosition;

		[Token(Token = "0x4000F21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool enableRotation;

		[Token(Token = "0x4000F22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 localRotation;

		[Token(Token = "0x4000F23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("Components")]
		private Rigidbody body;

		[Token(Token = "0x4000F24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool? hasGravity;

		[Token(Token = "0x4000F25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool? isKinematic;

		[Token(Token = "0x4000F26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int timesGrabbed;

		[Token(Token = "0x4000F27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform parent;

		[Token(Token = "0x4000F28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float grabValue;

		[Token(Token = "0x4000F29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 onGrabPosition;

		[Token(Token = "0x4000F2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion onGrabRotation;

		[Token(Token = "0x4000F2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private VRGrab currentGrabber;

		[Token(Token = "0x4000F2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Action<VRGrabbableRequest> onCanGrab;

		[Token(Token = "0x4000F2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Action<VRGrab> onGrab;

		[Token(Token = "0x4000F2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Action<VRGrab, float, float> onGrabUpdate;

		[Token(Token = "0x4000F2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action<VRGrab> onRelease;

		[Token(Token = "0x170000DB")]
		public GrabbableSnapType SnapType
		{
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x852E0C", Offset = "0x852E0C", VA = "0x852E0C")]
			get
			{
				return default(GrabbableSnapType);
			}
		}

		[Token(Token = "0x170000DC")]
		public bool IsGrabbed
		{
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x852E14", Offset = "0x852E14", VA = "0x852E14", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DD")]
		public bool IsFree
		{
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x852E74", Offset = "0x852E74", VA = "0x852E74", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DE")]
		public bool HasBeenGrabbed
		{
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x852ED4", Offset = "0x852ED4", VA = "0x852ED4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DF")]
		public int TimesGrabbed
		{
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x852EE4", Offset = "0x852EE4", VA = "0x852EE4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E0")]
		public float GrabValue
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x852EEC", Offset = "0x852EEC", VA = "0x852EEC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E1")]
		public VRGrab CurrentGrabbing
		{
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x852EF4", Offset = "0x852EF4", VA = "0x852EF4", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E2")]
		private MonoBehaviour LevelEditorAPI.VR.VRGrabInterface.Mono
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x852EFC", Offset = "0x852EFC", VA = "0x852EFC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E3")]
		public Vector3 GrabPositionOffset
		{
			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x852F00", Offset = "0x852F00", VA = "0x852F00", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x852F0C", Offset = "0x852F0C", VA = "0x852F0C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public Quaternion GrabRotationOffset
		{
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x852F18", Offset = "0x852F18", VA = "0x852F18", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x852F24", Offset = "0x852F24", VA = "0x852F24", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x852F30", Offset = "0x852F30", VA = "0x852F30")]
		public void ForceRelease()
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x852FB4", Offset = "0x852FB4", VA = "0x852FB4", Slot = "5")]
		private bool LevelEditorAPI.VR.VRGrabInterface.CanGrab(VRGrab grab)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x853090", Offset = "0x853090", VA = "0x853090", Slot = "6")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrab(VRGrab grab)
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x85381C", Offset = "0x85381C", VA = "0x85381C", Slot = "7")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrabUpdate(VRGrab grab, float value, float time)
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x8540B0", Offset = "0x8540B0", VA = "0x8540B0", Slot = "8")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnRelease(VRGrab grab)
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x854204", Offset = "0x854204", VA = "0x854204", Slot = "16")]
		public void SubscribeOnCanGrab(Action<VRGrabbableRequest> method)
		{
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x8542AC", Offset = "0x8542AC", VA = "0x8542AC", Slot = "18")]
		public void SubscribeOnGrab(Action<VRGrab> method)
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x854354", Offset = "0x854354", VA = "0x854354", Slot = "20")]
		public void SubscribeOnGrabUpdate(Action<VRGrab, float, float> method)
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x8543FC", Offset = "0x8543FC", VA = "0x8543FC", Slot = "22")]
		public void SubscribeOnRelease(Action<VRGrab> method)
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x8544A4", Offset = "0x8544A4", VA = "0x8544A4", Slot = "17")]
		public void UnsubscribeOnCanGrab(Action<VRGrabbableRequest> method)
		{
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x85454C", Offset = "0x85454C", VA = "0x85454C", Slot = "19")]
		public void UnsubscribeOnGrab(Action<VRGrab> method)
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x8545F8", Offset = "0x8545F8", VA = "0x8545F8", Slot = "21")]
		public void UnsubscribeOnGrabUpdate(Action<VRGrab, float, float> method)
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x8546A4", Offset = "0x8546A4", VA = "0x8546A4", Slot = "23")]
		public void UnsubscribeOnRelease(Action<VRGrab> method)
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x854750", Offset = "0x854750", VA = "0x854750")]
		[ContextMenu("Attach Components")]
		public void AttachComponents()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x8547A0", Offset = "0x8547A0", VA = "0x8547A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x8548D8", Offset = "0x8548D8", VA = "0x8548D8")]
		public VRGrabbable()
		{
		}
	}
	[Token(Token = "0x2000269")]
	public class VRGrabbableRequest
	{
		[Token(Token = "0x4000F34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int noGrab;

		[Token(Token = "0x170000E5")]
		public bool CanGrab
		{
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x853080", Offset = "0x853080", VA = "0x853080")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E6")]
		public int DisabledStrength
		{
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x854968", Offset = "0x854968", VA = "0x854968")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x854970", Offset = "0x854970", VA = "0x854970")]
		public void Response(bool value)
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x854984", Offset = "0x854984", VA = "0x854984")]
		public void Yes()
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x854988", Offset = "0x854988", VA = "0x854988")]
		public void No()
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x853078", Offset = "0x853078", VA = "0x853078")]
		public VRGrabbableRequest()
		{
		}
	}
	[Token(Token = "0x200026A")]
	public interface VRGrabInterface
	{
		[Token(Token = "0x170000E7")]
		MonoBehaviour Mono
		{
			[Token(Token = "0x6000A88")]
			get;
		}

		[Token(Token = "0x6000A89")]
		bool CanGrab(VRGrab grab);

		[Token(Token = "0x6000A8A")]
		void OnGrab(VRGrab grab);

		[Token(Token = "0x6000A8B")]
		void OnGrabUpdate(VRGrab grab, float input, float deltaTime);

		[Token(Token = "0x6000A8C")]
		void OnRelease(VRGrab grab);
	}
	[Token(Token = "0x200026B")]
	public interface VRGrabDataInterface
	{
		[Token(Token = "0x170000E8")]
		bool IsGrabbed
		{
			[Token(Token = "0x6000A8D")]
			get;
		}

		[Token(Token = "0x170000E9")]
		bool IsFree
		{
			[Token(Token = "0x6000A8E")]
			get;
		}

		[Token(Token = "0x170000EA")]
		VRGrab CurrentGrabbing
		{
			[Token(Token = "0x6000A8F")]
			get;
		}

		[Token(Token = "0x170000EB")]
		Vector3 GrabPositionOffset
		{
			[Token(Token = "0x6000A90")]
			get;
			[Token(Token = "0x6000A91")]
			set;
		}

		[Token(Token = "0x170000EC")]
		Quaternion GrabRotationOffset
		{
			[Token(Token = "0x6000A92")]
			get;
			[Token(Token = "0x6000A93")]
			set;
		}
	}
	[Token(Token = "0x200026C")]
	public interface VRGrabEventInterface
	{
		[Token(Token = "0x6000A94")]
		void SubscribeOnCanGrab(Action<VRGrabbableRequest> method);

		[Token(Token = "0x6000A95")]
		void UnsubscribeOnCanGrab(Action<VRGrabbableRequest> method);

		[Token(Token = "0x6000A96")]
		void SubscribeOnGrab(Action<VRGrab> method);

		[Token(Token = "0x6000A97")]
		void UnsubscribeOnGrab(Action<VRGrab> method);

		[Token(Token = "0x6000A98")]
		void SubscribeOnGrabUpdate(Action<VRGrab, float, float> method);

		[Token(Token = "0x6000A99")]
		void UnsubscribeOnGrabUpdate(Action<VRGrab, float, float> method);

		[Token(Token = "0x6000A9A")]
		void SubscribeOnRelease(Action<VRGrab> method);

		[Token(Token = "0x6000A9B")]
		void UnsubscribeOnRelease(Action<VRGrab> method);
	}
	[Token(Token = "0x200026D")]
	[AddComponentMenu("Prototyping/VR/Grab Relay")]
	public class VRGrabRelay : MonoBehaviour, VRGrabInterface, ISerializationCallbackReceiver
	{
		[Token(Token = "0x4000F35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[UnityObjectFilter(typeof(VRGrabInterface))]
		private UnityEngine.Object grabbableObject;

		[Token(Token = "0x4000F36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VRGrabInterface grabInterface;

		[Token(Token = "0x170000ED")]
		private MonoBehaviour LevelEditorAPI.VR.VRGrabInterface.Mono
		{
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x854A88", Offset = "0x854A88", VA = "0x854A88", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x854998", Offset = "0x854998", VA = "0x854998")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x854B34", Offset = "0x854B34", VA = "0x854B34", Slot = "5")]
		private bool LevelEditorAPI.VR.VRGrabInterface.CanGrab(VRGrab grab)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x854BE0", Offset = "0x854BE0", VA = "0x854BE0", Slot = "6")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrab(VRGrab grab)
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x854C5C", Offset = "0x854C5C", VA = "0x854C5C", Slot = "7")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrabUpdate(VRGrab grab, float value, float time)
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x854C60", Offset = "0x854C60", VA = "0x854C60", Slot = "8")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnRelease(VRGrab grab)
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x854C64", Offset = "0x854C64", VA = "0x854C64", Slot = "10")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x854CC0", Offset = "0x854CC0", VA = "0x854CC0", Slot = "9")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x854CC4", Offset = "0x854CC4", VA = "0x854CC4")]
		public VRGrabRelay()
		{
		}
	}
	[Token(Token = "0x200026E")]
	public class VRInstantiateOnGrab : MonoBehaviour, VRGrabInterface
	{
		[Token(Token = "0x4000F37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject prefab;

		[Token(Token = "0x4000F38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 offset;

		[Token(Token = "0x4000F39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 rotationOffset;

		[Token(Token = "0x4000F3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform parent;

		[Token(Token = "0x170000EE")]
		public Vector3 Position
		{
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x854CCC", Offset = "0x854CCC", VA = "0x854CCC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000EF")]
		public Quaternion Rotation
		{
			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x854DC4", Offset = "0x854DC4", VA = "0x854DC4")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x170000F0")]
		public GameObject Prefab
		{
			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x854F04", Offset = "0x854F04", VA = "0x854F04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x854F0C", Offset = "0x854F0C", VA = "0x854F0C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		private MonoBehaviour LevelEditorAPI.VR.VRGrabInterface.Mono
		{
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x854F14", Offset = "0x854F14", VA = "0x854F14", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x854F18", Offset = "0x854F18", VA = "0x854F18", Slot = "5")]
		private bool LevelEditorAPI.VR.VRGrabInterface.CanGrab(VRGrab grab)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x854F20", Offset = "0x854F20", VA = "0x854F20", Slot = "6")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrab(VRGrab grab)
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x855070", Offset = "0x855070", VA = "0x855070", Slot = "7")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrabUpdate(VRGrab grab, float value, float time)
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x855074", Offset = "0x855074", VA = "0x855074", Slot = "8")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnRelease(VRGrab grab)
		{
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x855078", Offset = "0x855078", VA = "0x855078")]
		public VRInstantiateOnGrab()
		{
		}
	}
}
namespace LevelEditorAPI.Utility
{
	[Serializable]
	[Token(Token = "0x200026F")]
	public class MeshDrawerInstance
	{
		[Token(Token = "0x4000F3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Header("Mesh Drawer Instance")]
		[SerializeField]
		private Mesh mesh;

		[Token(Token = "0x4000F3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material material;

		[Token(Token = "0x4000F3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int layer;

		[Token(Token = "0x4000F3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Space]
		[SerializeField]
		private Matrix4x4 offset;

		[Token(Token = "0x170000F2")]
		public Mesh Mesh
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x8550EC", Offset = "0x8550EC", VA = "0x8550EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x8550F4", Offset = "0x8550F4", VA = "0x8550F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public Material Material
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x8550FC", Offset = "0x8550FC", VA = "0x8550FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x855104", Offset = "0x855104", VA = "0x855104")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public LayerMask Layer
		{
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x85510C", Offset = "0x85510C", VA = "0x85510C")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x855128", Offset = "0x855128", VA = "0x855128")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public int LayerInt
		{
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x855154", Offset = "0x855154", VA = "0x855154")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x85515C", Offset = "0x85515C", VA = "0x85515C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public int LayerBitmask
		{
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x8551C0", Offset = "0x8551C0", VA = "0x8551C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F7")]
		public Vector3 OffsetPosition
		{
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x8551D0", Offset = "0x8551D0", VA = "0x8551D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000F8")]
		public Quaternion OffsetRotation
		{
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x8551E0", Offset = "0x8551E0", VA = "0x8551E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x170000F9")]
		public Vector3 OffsetScale
		{
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x855248", Offset = "0x855248", VA = "0x855248")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000FA")]
		public Bounds Bounds
		{
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x855254", Offset = "0x855254", VA = "0x855254")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x8552D8", Offset = "0x8552D8", VA = "0x8552D8")]
		public MeshDrawerInstance()
		{
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x855340", Offset = "0x855340", VA = "0x855340")]
		public MeshDrawerInstance(Mesh mesh)
		{
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x8553B4", Offset = "0x8553B4", VA = "0x8553B4")]
		public MeshDrawerInstance(Mesh mesh, Material material)
		{
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x8553D8", Offset = "0x8553D8", VA = "0x8553D8")]
		public MeshDrawerInstance(Mesh mesh, Material material, int layer)
		{
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x855404", Offset = "0x855404", VA = "0x855404")]
		public MeshDrawerInstance(Mesh mesh, Material material, Transform localOffset, int layer)
		{
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x85547C", Offset = "0x85547C", VA = "0x85547C")]
		public MeshDrawerInstance(Mesh mesh, Material material, Matrix4x4 localOffset, int layer)
		{
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x8554CC", Offset = "0x8554CC", VA = "0x8554CC")]
		public void Draw()
		{
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x8503C0", Offset = "0x8503C0", VA = "0x8503C0")]
		public void Draw(Transform target)
		{
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x8499FC", Offset = "0x8499FC", VA = "0x8499FC")]
		public void Draw(Matrix4x4 offset)
		{
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x855578", Offset = "0x855578", VA = "0x855578")]
		public void Draw(Material overrideMaterial)
		{
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x8502A4", Offset = "0x8502A4", VA = "0x8502A4")]
		public void Draw(Transform target, Material overrideMaterial)
		{
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x85562C", Offset = "0x85562C", VA = "0x85562C")]
		public void Draw(Transform target, int overrideLayer)
		{
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x855740", Offset = "0x855740", VA = "0x855740")]
		public void Draw(Transform target, Material overrideMaterial, int overrideLayer)
		{
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x849900", Offset = "0x849900", VA = "0x849900")]
		public void Draw(Matrix4x4 offset, Material overrideMaterial)
		{
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x85585C", Offset = "0x85585C", VA = "0x85585C")]
		public void SetMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x855864", Offset = "0x855864", VA = "0x855864")]
		public Mesh GetMesh()
		{
			return null;
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x85586C", Offset = "0x85586C", VA = "0x85586C")]
		public void SetMaterial(Material material)
		{
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x855874", Offset = "0x855874", VA = "0x855874")]
		public Material GetMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x85587C", Offset = "0x85587C", VA = "0x85587C")]
		public void SetLayer(LayerMask layer)
		{
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x8558A8", Offset = "0x8558A8", VA = "0x8558A8")]
		public LayerMask GetLayer()
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x8558C4", Offset = "0x8558C4", VA = "0x8558C4")]
		public void DrawGizmosMesh()
		{
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x85597C", Offset = "0x85597C", VA = "0x85597C")]
		public void DrawGizmosMesh(Transform location)
		{
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x855AB4", Offset = "0x855AB4", VA = "0x855AB4")]
		public void DrawGizmosWireMesh()
		{
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x855B6C", Offset = "0x855B6C", VA = "0x855B6C")]
		public void DrawGizmosWireMesh(Transform location)
		{
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x855CA4", Offset = "0x855CA4", VA = "0x855CA4")]
		public static MeshDrawerInstance CreateInstance(SkinnedMeshRenderer target)
		{
			return null;
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x855D50", Offset = "0x855D50", VA = "0x855D50")]
		public static MeshDrawerInstance CreateInstance(MeshFilter target)
		{
			return null;
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x855E3C", Offset = "0x855E3C", VA = "0x855E3C")]
		public static MeshDrawerInstance CreateInstance(MeshRenderer target)
		{
			return null;
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x855F70", Offset = "0x855F70", VA = "0x855F70")]
		public static MeshDrawerInstance[] CreateInstance(Prefab prefab)
		{
			return null;
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x855F88", Offset = "0x855F88", VA = "0x855F88")]
		public static MeshDrawerInstance[] CreateInstance(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x85625C", Offset = "0x85625C", VA = "0x85625C")]
		public static MeshDrawerInstance[] CreateInstances(Prefab prefab)
		{
			return null;
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x8493D8", Offset = "0x8493D8", VA = "0x8493D8")]
		public static MeshDrawerInstance[] CreateInstances(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x8490FC", Offset = "0x8490FC", VA = "0x8490FC")]
		public static Bounds GetTotalBounds(IReadOnlyList<MeshDrawerInstance> instances)
		{
			return default(Bounds);
		}
	}
	[Token(Token = "0x2000270")]
	public static class PhysicsHelper
	{
		[Token(Token = "0x4000F3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<Collider> colliders;

		[Token(Token = "0x4000F40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Collider[] colliderArray;

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x856274", Offset = "0x856274", VA = "0x856274")]
		public static void SetMaxColliders(int amount)
		{
		}

		[Token(Token = "0x6000ADD")]
		public static Collider[] Copy<T>(Prefab from, T to, bool childrenIncluded = false) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000ADE")]
		public static Collider[] Copy<T>(GameObject from, T to, bool childrenIncluded = false) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x856328", Offset = "0x856328", VA = "0x856328")]
		public static Collider[] Copy(Prefab from, GameObject to, bool childrenIncluded = false)
		{
			return null;
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x8563A0", Offset = "0x8563A0", VA = "0x8563A0")]
		public static Collider[] Copy(GameObject from, GameObject to, bool childrenIncluded = false)
		{
			return null;
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x856614", Offset = "0x856614", VA = "0x856614")]
		private static void CopyChildren(Transform current, Transform target, List<Collider> colliderList, [Optional] Action<GameObject> onCreatedObject)
		{
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x856984", Offset = "0x856984", VA = "0x856984")]
		public static Collider AddCollider(Collider referenceCollider, GameObject to)
		{
			return null;
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x856CB4", Offset = "0x856CB4", VA = "0x856CB4")]
		public static SphereCollider AddSphereCollider(SphereCollider refCol, GameObject to)
		{
			return null;
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x856D4C", Offset = "0x856D4C", VA = "0x856D4C")]
		public static BoxCollider AddBoxCollider(BoxCollider refCol, GameObject to)
		{
			return null;
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x856DE4", Offset = "0x856DE4", VA = "0x856DE4")]
		public static CapsuleCollider AddCapsuleCollider(CapsuleCollider refCol, GameObject to)
		{
			return null;
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x856EB0", Offset = "0x856EB0", VA = "0x856EB0")]
		public static MeshCollider AddMeshCollider(MeshCollider refCol, GameObject to)
		{
			return null;
		}

		[Token(Token = "0x6000AE7")]
		public static Collider[] CopyFromRenderers<T>(Prefab from, T to) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x856F6C", Offset = "0x856F6C", VA = "0x856F6C")]
		public static Collider[] CopyFromRenderers(Prefab from, GameObject to, bool useBoundingBox = true)
		{
			return null;
		}

		[Token(Token = "0x6000AE9")]
		public static void Clear<T>(T target, bool includeChildren = false) where T : Component
		{
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x8570A4", Offset = "0x8570A4", VA = "0x8570A4")]
		public static void Clear(GameObject target, bool includeChildren = false)
		{
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x857298", Offset = "0x857298", VA = "0x857298")]
		public static Bounds TotalBounds(GameObject target, bool includeChildren = false, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x8573A8", Offset = "0x8573A8", VA = "0x8573A8")]
		public static Bounds TotalBounds(IReadOnlyList<Collider> colliders, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x8576D4", Offset = "0x8576D4", VA = "0x8576D4")]
		public static Bounds TotalBounds(IReadOnlyList<Collider> colliders, Quaternion rotation, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x857A54", Offset = "0x857A54", VA = "0x857A54")]
		public static bool IsColliding(Collider collider, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x857C90", Offset = "0x857C90", VA = "0x857C90")]
		public static bool IsColliding(GameObject gameObject, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x857EA8", Offset = "0x857EA8", VA = "0x857EA8")]
		public static bool IsColliding(IReadOnlyList<Collider> colliders, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x857B6C", Offset = "0x857B6C", VA = "0x857B6C")]
		public static bool IsColliding(Collider collider, Vector3 positionOffset, Quaternion rotationOffset, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x857DA8", Offset = "0x857DA8", VA = "0x857DA8")]
		public static bool IsColliding(GameObject gameObject, Vector3 positionOffset, Quaternion rotationOffset, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x857FC0", Offset = "0x857FC0", VA = "0x857FC0")]
		public static bool IsColliding(IReadOnlyList<Collider> colliders, Vector3 positionOffset, Quaternion rotationOffset, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000271")]
	public struct PositionRotation
	{
		[Token(Token = "0x4000F41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 Position;

		[Token(Token = "0x4000F42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion Rotation;

		[Token(Token = "0x170000FB")]
		public Matrix4x4 Matrix4X4
		{
			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x858594", Offset = "0x858594", VA = "0x858594")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x170000FC")]
		public InstantiateData InstantiateData
		{
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x85865C", Offset = "0x85865C", VA = "0x85865C")]
			get
			{
				return default(InstantiateData);
			}
		}

		[Token(Token = "0x170000FD")]
		public static PositionRotation Default
		{
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x85868C", Offset = "0x85868C", VA = "0x85868C")]
			get
			{
				return default(PositionRotation);
			}
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x858724", Offset = "0x858724", VA = "0x858724")]
		public PositionRotation(Vector3 position)
		{
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x85877C", Offset = "0x85877C", VA = "0x85877C")]
		public PositionRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x851FDC", Offset = "0x851FDC", VA = "0x851FDC")]
		public PositionRotation(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x8587FC", Offset = "0x8587FC", VA = "0x8587FC")]
		public PositionRotation(InstantiateData instantiateData, Space space = Space.Self)
		{
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x8589D4", Offset = "0x8589D4", VA = "0x8589D4")]
		public PositionRotation(Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x858A1C", Offset = "0x858A1C", VA = "0x858A1C")]
		public static implicit operator Vector3(PositionRotation positionRotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x858A28", Offset = "0x858A28", VA = "0x858A28")]
		public static implicit operator Quaternion(PositionRotation positionRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x858A34", Offset = "0x858A34", VA = "0x858A34")]
		public static implicit operator InstantiateData(PositionRotation positionRotation)
		{
			return default(InstantiateData);
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x858A64", Offset = "0x858A64", VA = "0x858A64")]
		public static implicit operator Matrix4x4(PositionRotation positionRotation)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x858B2C", Offset = "0x858B2C", VA = "0x858B2C")]
		public PositionRotation WorldToLocal(Transform transform)
		{
			return default(PositionRotation);
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x858C20", Offset = "0x858C20", VA = "0x858C20")]
		public void SetTransform(Transform transform, Space space = Space.Self)
		{
		}
	}
}
namespace LevelEditorAPI.InternalPrefab
{
	[Token(Token = "0x2000272")]
	[AddComponentMenu("Prototyping/Init Prefab Database")]
	public class InitPrefabDatabase : MonoBehaviour
	{
		[Token(Token = "0x4000F43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Readonly(true)]
		private PrefabDatabase optionalDatabaseReference;

		[Token(Token = "0x4000F44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool throwError;

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x858C94", Offset = "0x858C94", VA = "0x858C94")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x858E38", Offset = "0x858E38", VA = "0x858E38")]
		public InitPrefabDatabase()
		{
		}
	}
	[Token(Token = "0x2000273")]
	public interface IPrefab
	{
		[Token(Token = "0x170000FE")]
		string PrefabName
		{
			[Token(Token = "0x6000B05")]
			get;
			[Token(Token = "0x6000B06")]
			set;
		}

		[Token(Token = "0x170000FF")]
		GameObject GameObject
		{
			[Token(Token = "0x6000B07")]
			get;
			[Token(Token = "0x6000B08")]
			set;
		}

		[Token(Token = "0x17000100")]
		int Id
		{
			[Token(Token = "0x6000B09")]
			get;
			[Token(Token = "0x6000B0A")]
			set;
		}

		[Token(Token = "0x6000B0B")]
		void Initialize();
	}
	[Token(Token = "0x2000274")]
	public interface IPrefabDatabase
	{
		[Token(Token = "0x6000B0C")]
		void AddItem(Prefab prefab);

		[Token(Token = "0x6000B0D")]
		void AddItems(IReadOnlyList<Prefab> prefabs);

		[Token(Token = "0x6000B0E")]
		void RemoveItem(Prefab prefab);

		[Token(Token = "0x6000B0F")]
		void RemoveItem(int id);

		[Token(Token = "0x6000B10")]
		void RemoveItem(string name);

		[Token(Token = "0x6000B11")]
		void RemoveItemByIndex(int index);

		[Token(Token = "0x6000B12")]
		void Clear();

		[Token(Token = "0x6000B13")]
		Prefab GetItemByIndex(int index);

		[Token(Token = "0x6000B14")]
		void SetItemByIndex(int index, Prefab prefab);
	}
}
namespace LevelEditorAPI.InputSys
{
	[Token(Token = "0x2000275")]
	[CreateAssetMenu(fileName = "InputManager", menuName = "Prototyping/Input/New Input Manager")]
	public class InputManager : ScriptableObject
	{
		[Token(Token = "0x4000F45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string @namespace;

		[Token(Token = "0x4000F46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string inputName;

		[Token(Token = "0x4000F47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string defaultDevice;

		[Token(Token = "0x4000F48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string[] devices;

		[Token(Token = "0x4000F49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Action[] actions;

		[Token(Token = "0x4000F4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[TextArea(3, 80)]
		[SerializeField]
		private string customCode;

		[Token(Token = "0x4000F4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool includeXRNodeTracking;

		[Token(Token = "0x17000101")]
		public string Namespace
		{
			[Token(Token = "0x6000B15")]
			[Address(RVA = "0x858E48", Offset = "0x858E48", VA = "0x858E48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		public string InputName
		{
			[Token(Token = "0x6000B16")]
			[Address(RVA = "0x858E50", Offset = "0x858E50", VA = "0x858E50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000103")]
		public string DefaultDevice
		{
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x858E58", Offset = "0x858E58", VA = "0x858E58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		public string[] Devices
		{
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x858E60", Offset = "0x858E60", VA = "0x858E60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000105")]
		public Action[] Actions
		{
			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x858E68", Offset = "0x858E68", VA = "0x858E68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		public bool XRNodeTracking
		{
			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x858E70", Offset = "0x858E70", VA = "0x858E70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000107")]
		public string CustomCode
		{
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x858E78", Offset = "0x858E78", VA = "0x858E78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x858E80", Offset = "0x858E80", VA = "0x858E80")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x858EB0", Offset = "0x858EB0", VA = "0x858EB0")]
		public InputManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000276")]
	public class Action
	{
		[Token(Token = "0x4000F4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string name;

		[Token(Token = "0x4000F4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActionType actionType;

		[Token(Token = "0x4000F4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Axis[] axisX;

		[Token(Token = "0x4000F4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Axis[] axisY;

		[Token(Token = "0x17000108")]
		public string Name
		{
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x858F74", Offset = "0x858F74", VA = "0x858F74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000109")]
		public ActionType ActionType
		{
			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x858F7C", Offset = "0x858F7C", VA = "0x858F7C")]
			get
			{
				return default(ActionType);
			}
		}

		[Token(Token = "0x1700010A")]
		public Axis[] AxisX
		{
			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x858F84", Offset = "0x858F84", VA = "0x858F84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010B")]
		public Axis[] AxisY
		{
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x858F8C", Offset = "0x858F8C", VA = "0x858F8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x858F94", Offset = "0x858F94", VA = "0x858F94")]
		public int Validate()
		{
			return default(int);
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x859134", Offset = "0x859134", VA = "0x859134")]
		public Action()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000277")]
	public class Axis
	{
		[Token(Token = "0x4000F50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string name;

		[Token(Token = "0x4000F51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AxisTypee axisType;

		[Token(Token = "0x4000F52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string deviceOverride;

		[Token(Token = "0x4000F53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int buttonId;

		[Token(Token = "0x4000F54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Readonly]
		[SerializeField]
		private string buttonName;

		[Token(Token = "0x4000F55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool invert;

		[Token(Token = "0x4000F56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int axisId;

		[Token(Token = "0x1700010C")]
		public string Name
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x859184", Offset = "0x859184", VA = "0x859184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010D")]
		public AxisTypee AxisType
		{
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x859274", Offset = "0x859274", VA = "0x859274")]
			get
			{
				return default(AxisTypee);
			}
		}

		[Token(Token = "0x1700010E")]
		public string Device
		{
			[Token(Token = "0x6000B26")]
			[Address(RVA = "0x8591FC", Offset = "0x8591FC", VA = "0x8591FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010F")]
		public int ButtonId
		{
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0x85927C", Offset = "0x85927C", VA = "0x85927C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000110")]
		public string ButtonName
		{
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x859284", Offset = "0x859284", VA = "0x859284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000111")]
		public bool Invert
		{
			[Token(Token = "0x6000B29")]
			[Address(RVA = "0x85928C", Offset = "0x85928C", VA = "0x85928C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000112")]
		public int AxisId
		{
			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0x859294", Offset = "0x859294", VA = "0x859294")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000113")]
		public float Dead
		{
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x85929C", Offset = "0x85929C", VA = "0x85929C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000114")]
		public float Sensitivity
		{
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x8592A8", Offset = "0x8592A8", VA = "0x8592A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000115")]
		public float Gravity
		{
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0x8592C4", Offset = "0x8592C4", VA = "0x8592C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x8590A4", Offset = "0x8590A4", VA = "0x8590A4")]
		public int Validate()
		{
			return default(int);
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x8592D0", Offset = "0x8592D0", VA = "0x8592D0")]
		public Axis()
		{
		}
	}
	[Token(Token = "0x2000278")]
	public enum ActionType
	{
		[Token(Token = "0x4000F58")]
		Button,
		[Token(Token = "0x4000F59")]
		Float,
		[Token(Token = "0x4000F5A")]
		Float2D
	}
	[Token(Token = "0x2000279")]
	public enum AxisTypee
	{
		[Token(Token = "0x4000F5C")]
		Button,
		[Token(Token = "0x4000F5D")]
		Axis
	}
	[Token(Token = "0x200027A")]
	public static class InputSystem
	{
		[Token(Token = "0x200027B")]
		public enum DeviceType
		{
			[Token(Token = "0x4000F61")]
			Default
		}

		[Token(Token = "0x4000F5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IInputSystem_ActionMap actionMap;

		[Token(Token = "0x4000F5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DeviceType deviceType;

		[Token(Token = "0x17000116")]
		public static IInputSystem_ActionMap ActionMap
		{
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x85A328", Offset = "0x85A328", VA = "0x85A328")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000B31")]
			[Address(RVA = "0x85A370", Offset = "0x85A370", VA = "0x85A370")]
			set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public static bool Stamp
		{
			[Token(Token = "0x6000B32")]
			[Address(RVA = "0x85A3BC", Offset = "0x85A3BC", VA = "0x85A3BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000118")]
		public static bool Destroy
		{
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x85A480", Offset = "0x85A480", VA = "0x85A480")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000119")]
		public static bool Redo
		{
			[Token(Token = "0x6000B34")]
			[Address(RVA = "0x85A548", Offset = "0x85A548", VA = "0x85A548")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011A")]
		public static bool Undo
		{
			[Token(Token = "0x6000B35")]
			[Address(RVA = "0x85A610", Offset = "0x85A610", VA = "0x85A610")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011B")]
		public static float PlatformScale
		{
			[Token(Token = "0x6000B36")]
			[Address(RVA = "0x85A6D8", Offset = "0x85A6D8", VA = "0x85A6D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700011C")]
		public static float PlatformRotate
		{
			[Token(Token = "0x6000B37")]
			[Address(RVA = "0x85A7A0", Offset = "0x85A7A0", VA = "0x85A7A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700011D")]
		public static bool PlatformRecenter
		{
			[Token(Token = "0x6000B38")]
			[Address(RVA = "0x85A868", Offset = "0x85A868", VA = "0x85A868")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011E")]
		public static bool ToolboxRecenter
		{
			[Token(Token = "0x6000B39")]
			[Address(RVA = "0x85A930", Offset = "0x85A930", VA = "0x85A930")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x85A9EC", Offset = "0x85A9EC", VA = "0x85A9EC")]
		public static void SetDeviceType(DeviceType type)
		{
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x85AA38", Offset = "0x85AA38", VA = "0x85AA38")]
		public static DeviceType GetDeviceType()
		{
			return default(DeviceType);
		}
	}
	[Token(Token = "0x200027C")]
	public interface IInputSystem_ActionMap
	{
		[Token(Token = "0x1700011F")]
		bool Stamp
		{
			[Token(Token = "0x6000B3C")]
			get;
		}

		[Token(Token = "0x17000120")]
		bool Destroy
		{
			[Token(Token = "0x6000B3D")]
			get;
		}

		[Token(Token = "0x17000121")]
		bool Redo
		{
			[Token(Token = "0x6000B3E")]
			get;
		}

		[Token(Token = "0x17000122")]
		bool Undo
		{
			[Token(Token = "0x6000B3F")]
			get;
		}

		[Token(Token = "0x17000123")]
		float PlatformScale
		{
			[Token(Token = "0x6000B40")]
			get;
		}

		[Token(Token = "0x17000124")]
		float PlatformRotate
		{
			[Token(Token = "0x6000B41")]
			get;
		}

		[Token(Token = "0x17000125")]
		bool PlatformRecenter
		{
			[Token(Token = "0x6000B42")]
			get;
		}

		[Token(Token = "0x17000126")]
		bool ToolboxRecenter
		{
			[Token(Token = "0x6000B43")]
			get;
		}
	}
	[Token(Token = "0x200027D")]
	public class InputSystem_Palazzo : IInputSystem_ActionMap
	{
		[Token(Token = "0x4000F62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly InputHandler inputHandler;

		[Token(Token = "0x17000127")]
		public bool Stamp
		{
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x85AAA8", Offset = "0x85AAA8", VA = "0x85AAA8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000128")]
		public bool Destroy
		{
			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x85AAC4", Offset = "0x85AAC4", VA = "0x85AAC4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000129")]
		public bool Redo
		{
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x85AAE0", Offset = "0x85AAE0", VA = "0x85AAE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012A")]
		public bool Undo
		{
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x85AAE8", Offset = "0x85AAE8", VA = "0x85AAE8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012B")]
		public float PlatformScale
		{
			[Token(Token = "0x6000B49")]
			[Address(RVA = "0x85AAF0", Offset = "0x85AAF0", VA = "0x85AAF0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700012C")]
		public float PlatformRotate
		{
			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0x85AAF8", Offset = "0x85AAF8", VA = "0x85AAF8", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700012D")]
		public bool PlatformRecenter
		{
			[Token(Token = "0x6000B4B")]
			[Address(RVA = "0x85AB58", Offset = "0x85AB58", VA = "0x85AB58", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012E")]
		public bool ToolboxRecenter
		{
			[Token(Token = "0x6000B4C")]
			[Address(RVA = "0x85AB60", Offset = "0x85AB60", VA = "0x85AB60", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x85AA80", Offset = "0x85AA80", VA = "0x85AA80")]
		public InputSystem_Palazzo(InputHandler inputHandler)
		{
		}
	}
	[Token(Token = "0x200027E")]
	public static class InputUtility
	{
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x85AB7C", Offset = "0x85AB7C", VA = "0x85AB7C")]
		public static float GetAxis(string[] values)
		{
			return default(float);
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x85ABF8", Offset = "0x85ABF8", VA = "0x85ABF8")]
		public static string GetAxisName(InputManager manager, Action action, Axis axis)
		{
			return null;
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x85AEF4", Offset = "0x85AEF4", VA = "0x85AEF4")]
		public static string GetDefaultConstantName(InputManager manager, Action action)
		{
			return null;
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x85AF60", Offset = "0x85AF60", VA = "0x85AF60")]
		public static string[] GetConstantNames(InputManager manager, Action action)
		{
			return null;
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x85B26C", Offset = "0x85B26C", VA = "0x85B26C")]
		public static string[] GetOverrides(InputManager manager, Action action)
		{
			return null;
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x85B56C", Offset = "0x85B56C", VA = "0x85B56C")]
		public static bool IsAxisValid(InputManager manager, Action action, Axis axis)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200027F")]
	public class State
	{
		[Token(Token = "0x4000F63")]
		private const float THRESHOLD = 0.05f;

		[Token(Token = "0x4000F64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int frame;

		[Token(Token = "0x4000F65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float oldInput;

		[Token(Token = "0x4000F66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isDown;

		[Token(Token = "0x4000F67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool isUp;

		[Token(Token = "0x4000F68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private bool isHold;

		[Token(Token = "0x1700012F")]
		public bool Down
		{
			[Token(Token = "0x6000B53")]
			[Address(RVA = "0x85B610", Offset = "0x85B610", VA = "0x85B610")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000130")]
		public bool Up
		{
			[Token(Token = "0x6000B54")]
			[Address(RVA = "0x85B618", Offset = "0x85B618", VA = "0x85B618")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000131")]
		public bool Hold
		{
			[Token(Token = "0x6000B55")]
			[Address(RVA = "0x85B620", Offset = "0x85B620", VA = "0x85B620")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000132")]
		private bool IsUpdated
		{
			[Token(Token = "0x6000B56")]
			[Address(RVA = "0x85B628", Offset = "0x85B628", VA = "0x85B628")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x85B648", Offset = "0x85B648", VA = "0x85B648")]
		public State Update(string[] axes)
		{
			return null;
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x85B6FC", Offset = "0x85B6FC", VA = "0x85B6FC")]
		public State Update(float input)
		{
			return null;
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x85B7B0", Offset = "0x85B7B0", VA = "0x85B7B0")]
		public static implicit operator bool(State state)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x85B7C8", Offset = "0x85B7C8", VA = "0x85B7C8")]
		public State()
		{
		}
	}
}
namespace Fabric
{
	[Token(Token = "0x2000280")]
	[ExecuteInEditMode]
	public class FabricSpringBoard : MonoBehaviour
	{
		[Token(Token = "0x4000F69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string _fabricManagerPrefabPath;

		[Token(Token = "0x4000F6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _isPresent;

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x85B7D0", Offset = "0x85B7D0", VA = "0x85B7D0")]
		public FabricSpringBoard()
		{
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x85B82C", Offset = "0x85B82C", VA = "0x85B82C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x85B878", Offset = "0x85B878", VA = "0x85B878")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x85B87C", Offset = "0x85B87C", VA = "0x85B87C")]
		public void Load()
		{
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x85B9CC", Offset = "0x85B9CC", VA = "0x85B9CC")]
		public static FabricManager GetFabricManagerInEditor()
		{
			return null;
		}
	}
}
