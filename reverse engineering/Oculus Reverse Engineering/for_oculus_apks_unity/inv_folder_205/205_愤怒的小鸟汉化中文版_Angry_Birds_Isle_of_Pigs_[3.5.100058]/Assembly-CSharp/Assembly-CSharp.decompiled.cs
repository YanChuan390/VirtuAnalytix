using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
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
using Oculus.Platform;
using Oculus.Platform.Models;
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
using UnityEngine.UI;
using UnityEngine.XR;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x765D08", Offset = "0x765D08")]
internal sealed class <>f__AnonymousType0
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x99A93C", Offset = "0x99A93C", VA = "0x99A93C")]
	[DebuggerHidden]
	public <>f__AnonymousType0()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x99A944", Offset = "0x99A944", VA = "0x99A944", Slot = "0")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x99A9A8", Offset = "0x99A9A8", VA = "0x99A9A8", Slot = "2")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x99A9B0", Offset = "0x99A9B0", VA = "0x99A9B0", Slot = "3")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
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
	[Address(RVA = "0x99C210", Offset = "0x99C210", VA = "0x99C210")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x99C6B0", Offset = "0x99C6B0", VA = "0x99C6B0")]
	private void OnBuiltAtlasesSuccess()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x99C8DC", Offset = "0x99C8DC", VA = "0x99C8DC")]
	public BakeTexturesAtRuntime()
	{
	}
}
[Token(Token = "0x2000004")]
public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0xA0EBAC", Offset = "0xA0EBAC", VA = "0xA0EBAC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xA0EC10", Offset = "0xA0EC10", VA = "0xA0EC10")]
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
	[Address(RVA = "0x95BA40", Offset = "0x95BA40", VA = "0x95BA40")]
	private void Start()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x95BC04", Offset = "0x95BC04", VA = "0x95BC04")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x95BCF0", Offset = "0x95BCF0", VA = "0x95BCF0")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x95C254", Offset = "0x95C254", VA = "0x95C254")]
	public MB_SwapShirts()
	{
	}
}
[Token(Token = "0x2000006")]
public class MB_PrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x600000E")]
	[Address(RVA = "0xA0F8C0", Offset = "0xA0F8C0", VA = "0xA0F8C0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xA0F924", Offset = "0xA0F924", VA = "0xA0F924")]
	public MB_PrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x2000007")]
public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	[Token(Token = "0x20001D9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767164", Offset = "0x767164")]
	private sealed class <largeNumber>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000D4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000D4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000D50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MB_DynamicAddDeleteExample <>4__this;

		[Token(Token = "0x170000F7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000997")]
			[Address(RVA = "0xA0F53C", Offset = "0xA0F53C", VA = "0xA0F53C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000999")]
			[Address(RVA = "0xA0F5AC", Offset = "0xA0F5AC", VA = "0xA0F5AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0xA0F260", Offset = "0xA0F260", VA = "0xA0F260")]
		[DebuggerHidden]
		public <largeNumber>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0xA0F360", Offset = "0xA0F360", VA = "0xA0F360", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0xA0F364", Offset = "0xA0F364", VA = "0xA0F364", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xA0F544", Offset = "0xA0F544", VA = "0xA0F544", Slot = "8")]
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
	[Address(RVA = "0xA0EC18", Offset = "0xA0EC18", VA = "0xA0EC18")]
	private float GaussianValue()
	{
		return default(float);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xA0ECFC", Offset = "0xA0ECFC", VA = "0xA0ECFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xA0F1EC", Offset = "0xA0F1EC", VA = "0xA0F1EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76A064", Offset = "0x76A064")]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xA0F28C", Offset = "0xA0F28C", VA = "0xA0F28C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xA0F2F0", Offset = "0xA0F2F0", VA = "0xA0F2F0")]
	public MB_DynamicAddDeleteExample()
	{
	}
}
[Token(Token = "0x2000008")]
public class MB_Example : MonoBehaviour
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshbaker;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] objsToCombine;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xA0F5B4", Offset = "0xA0F5B4", VA = "0xA0F5B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xA0F628", Offset = "0xA0F628", VA = "0xA0F628")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xA0F6D0", Offset = "0xA0F6D0", VA = "0xA0F6D0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xA0F734", Offset = "0xA0F734", VA = "0xA0F734")]
	public MB_Example()
	{
	}
}
[Token(Token = "0x2000009")]
public class MB_ExampleMover : MonoBehaviour
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int axis;

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xA0F73C", Offset = "0xA0F73C", VA = "0xA0F73C")]
	private void Update()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xA0F84C", Offset = "0xA0F84C", VA = "0xA0F84C")]
	public MB_ExampleMover()
	{
	}
}
[Token(Token = "0x200000A")]
public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[Token(Token = "0x600001B")]
	[Address(RVA = "0xA0F854", Offset = "0xA0F854", VA = "0xA0F854")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xA0F8B8", Offset = "0xA0F8B8", VA = "0xA0F8B8")]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
[Token(Token = "0x200000B")]
public class MB_SkinnedMeshSceneController : MonoBehaviour
{
	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject swordPrefab;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject hatPrefab;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject glassesPrefab;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject workerPrefab;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject targetCharacter;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MB3_MeshBaker skinnedMeshBaker;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject swordInstance;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject glassesInstance;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject hatInstance;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xA0F92C", Offset = "0xA0F92C", VA = "0xA0F92C")]
	private void Start()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xA0FBB0", Offset = "0xA0FBB0", VA = "0xA0FBB0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xA10AE0", Offset = "0xA10AE0", VA = "0xA10AE0")]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xA10C14", Offset = "0xA10C14", VA = "0xA10C14")]
	public MB_SkinnedMeshSceneController()
	{
	}
}
[Token(Token = "0x200000C")]
public class MB_SwitchBakedObjectsTexture : MonoBehaviour
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer targetRenderer;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material[] materials;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x95C25C", Offset = "0x95C25C", VA = "0x95C25C")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x95C2C0", Offset = "0x95C2C0", VA = "0x95C2C0")]
	public void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x95C388", Offset = "0x95C388", VA = "0x95C388")]
	public void Update()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x95C6B4", Offset = "0x95C6B4", VA = "0x95C6B4")]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
[Serializable]
[Token(Token = "0x200000D")]
public struct SerializableVector3
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x7D8A00", Offset = "0x7D8A00", VA = "0x7D8A00")]
	public SerializableVector3(float rX, float rY, float rZ)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x7D8A0C", Offset = "0x7D8A0C", VA = "0x7D8A0C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x9E96CC", Offset = "0x9E96CC", VA = "0x9E96CC")]
	public static implicit operator Vector3(SerializableVector3 rValue)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x9E9700", Offset = "0x9E9700", VA = "0x9E9700")]
	public static implicit operator SerializableVector3(Vector3 rValue)
	{
		return default(SerializableVector3);
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public struct SerializableQuaternion
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

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float w;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x7D89EC", Offset = "0x7D89EC", VA = "0x7D89EC")]
	public SerializableQuaternion(float rX, float rY, float rZ, float rW)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x7D89F8", Offset = "0x7D89F8", VA = "0x7D89F8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x9E95CC", Offset = "0x9E95CC", VA = "0x9E95CC")]
	public static implicit operator Quaternion(SerializableQuaternion rValue)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x9E95FC", Offset = "0x9E95FC", VA = "0x9E95FC")]
	public static implicit operator SerializableQuaternion(Quaternion rValue)
	{
		return default(SerializableQuaternion);
	}
}
[Token(Token = "0x200000F")]
public sealed class Vector3SerializationSurrogate : ISerializationSurrogate
{
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x10F63B0", Offset = "0x10F63B0", VA = "0x10F63B0", Slot = "4")]
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x10F64D0", Offset = "0x10F64D0", VA = "0x10F64D0", Slot = "5")]
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x10F665C", Offset = "0x10F665C", VA = "0x10F665C")]
	public Vector3SerializationSurrogate()
	{
	}
}
[Token(Token = "0x2000010")]
public sealed class QuaternionSerializationSurrogate : ISerializationSurrogate
{
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x9CB29C", Offset = "0x9CB29C", VA = "0x9CB29C", Slot = "4")]
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x9CB3FC", Offset = "0x9CB3FC", VA = "0x9CB3FC", Slot = "5")]
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x9CB5CC", Offset = "0x9CB5CC", VA = "0x9CB5CC")]
	public QuaternionSerializationSurrogate()
	{
	}
}
[Token(Token = "0x2000011")]
public class GhostComponent : MonoBehaviour
{
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Collider col;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Rigidbody rb;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Animator anim;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 snapPosition;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Quaternion snapRotation;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Renderer[] renderers;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xA14408", Offset = "0xA14408", VA = "0xA14408")]
	public GhostComponent()
	{
	}
}
[Token(Token = "0x2000012")]
public class PigEvenListener : MonoBehaviour
{
	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool muted;

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x9C5DC4", Offset = "0x9C5DC4", VA = "0x9C5DC4")]
	public void piglaughlong()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x9C5E78", Offset = "0x9C5E78", VA = "0x9C5E78")]
	public void bosspiglaugh()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x9C5F2C", Offset = "0x9C5F2C", VA = "0x9C5F2C")]
	public void piglaugshort()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x9C5FE0", Offset = "0x9C5FE0", VA = "0x9C5FE0")]
	public void pigtaunt()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x9C6094", Offset = "0x9C6094", VA = "0x9C6094")]
	public void bosspigtaunt()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x9C6148", Offset = "0x9C6148", VA = "0x9C6148")]
	public void pignoff()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x9C61FC", Offset = "0x9C61FC", VA = "0x9C61FC")]
	public void bosspignoff()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x9C62B0", Offset = "0x9C62B0", VA = "0x9C62B0")]
	public void pighello()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x9C6364", Offset = "0x9C6364", VA = "0x9C6364")]
	public void piggrunt()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x9C6418", Offset = "0x9C6418", VA = "0x9C6418")]
	public void pigfart()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x9C64CC", Offset = "0x9C64CC", VA = "0x9C64CC")]
	public void pigburp()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x9C6580", Offset = "0x9C6580", VA = "0x9C6580")]
	public void piglaugh()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x9C6634", Offset = "0x9C6634", VA = "0x9C6634")]
	public void pigerf()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x9C66E8", Offset = "0x9C66E8", VA = "0x9C66E8")]
	public void bosspigerf()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x9C679C", Offset = "0x9C679C", VA = "0x9C679C")]
	public void pigsnore()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x9C6850", Offset = "0x9C6850", VA = "0x9C6850")]
	public void pigangry()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x9C6904", Offset = "0x9C6904", VA = "0x9C6904")]
	public void bosspigangry()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x9C69B8", Offset = "0x9C69B8", VA = "0x9C69B8")]
	public void pigjump()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x9C6A6C", Offset = "0x9C6A6C", VA = "0x9C6A6C")]
	public void bosspigjump()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x9C6B20", Offset = "0x9C6B20", VA = "0x9C6B20")]
	public void pigscared()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x9C6B24", Offset = "0x9C6B24", VA = "0x9C6B24")]
	public void bosspigscared()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x9C6BD8", Offset = "0x9C6BD8", VA = "0x9C6BD8")]
	public void bosspigfrustrated()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x9C6C8C", Offset = "0x9C6C8C", VA = "0x9C6C8C")]
	public void pigterror()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x9C6D40", Offset = "0x9C6D40", VA = "0x9C6D40")]
	public void pigfear()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x9C6DF4", Offset = "0x9C6DF4", VA = "0x9C6DF4")]
	public void hatchlingscore()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x9C6EA8", Offset = "0x9C6EA8", VA = "0x9C6EA8")]
	public void redscore()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x9C6F5C", Offset = "0x9C6F5C", VA = "0x9C6F5C")]
	public void chuckscore()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x9C7010", Offset = "0x9C7010", VA = "0x9C7010")]
	public void bombscore()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x9C70C4", Offset = "0x9C70C4", VA = "0x9C70C4")]
	public void frankenhit()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x9C71C8", Offset = "0x9C71C8", VA = "0x9C71C8")]
	public PigEvenListener()
	{
	}
}
[Token(Token = "0x2000013")]
public static class PalazzoTracking
{
	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string birdShot;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int iBird;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string location;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int timeSinceLastShot;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public static bool editedBirds;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public static bool editedTeleports;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static float editingStartTime;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static int numberOfBlockPlacements;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static int numberOfDeletes;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public static int numberOfTryPlays;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static int numberOfRotations;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public static int numberOfToolboxMoves;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static int numberOfTutorialPresses;

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x9B8208", Offset = "0x9B8208", VA = "0x9B8208")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x76A0C8", Offset = "0x76A0C8")]
	public static void Start()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x9B8288", Offset = "0x9B8288", VA = "0x9B8288")]
	private static void ResetSaveTrackingStats()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x9B82E0", Offset = "0x9B82E0", VA = "0x9B82E0")]
	private static void ResetEditingTrackingStats()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x9B8358", Offset = "0x9B8358", VA = "0x9B8358")]
	public static void SendLevelEndEvent(string type, int unusedBirdsCount, int score, int nStars, int levelIndex, string world, int remainingPigCount, int time)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x9B88A4", Offset = "0x9B88A4", VA = "0x9B88A4")]
	public static void SendCustomLevelEndEvent(string type, int unusedBirdsCount, int levelIndex, int remainingPigCount, int time)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x9B8C44", Offset = "0x9B8C44", VA = "0x9B8C44")]
	public static void SendOnlineLevelEndEvent(string type, int remainingBirdsCount, string levelCode, int remainingPigCount, int time, string authToken)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x9B906C", Offset = "0x9B906C", VA = "0x9B906C")]
	public static void SendLevelSaveEvent(string type, Level level, int blockMeter, bool anotherSlot)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x9B9904", Offset = "0x9B9904", VA = "0x9B9904")]
	public static void SendLeaveEditorEvent()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x9B94FC", Offset = "0x9B94FC", VA = "0x9B94FC")]
	private static string GetBlockTypes(Level level)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x9B9E44", Offset = "0x9B9E44", VA = "0x9B9E44")]
	public static void SetBirdShotEventData(string birdShot, int iBird, string location, int timeSinceLastShot)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x9B9ED0", Offset = "0x9B9ED0", VA = "0x9B9ED0")]
	public static void SendBirdShotEvent(string hitTargetType, int levelIndex, string levelCode)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x9BA39C", Offset = "0x9BA39C", VA = "0x9BA39C")]
	public static void SendRequestFailureEvent(string message, string url, string errorCode, float time)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x9BA6AC", Offset = "0x9BA6AC", VA = "0x9BA6AC")]
	public static void SendOnlineLevelSkippedEvent(string levelCode, float time, string authToken)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x9BA938", Offset = "0x9BA938", VA = "0x9BA938")]
	public static void SendOnlineLevelFavoritedEvent(string levelCode, string authToken)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x9BAB34", Offset = "0x9BAB34", VA = "0x9BAB34")]
	public static void SendOnlineLevelUnfavoritedEvent(string levelCode, string authToken)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x9BAD30", Offset = "0x9BAD30", VA = "0x9BAD30")]
	public static void SendOnlineLevelLikedEvent(string levelCode, string authToken)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x9BAF2C", Offset = "0x9BAF2C", VA = "0x9BAF2C")]
	public static void SendOnlineLevelDislikedEvent(string levelCode, string authToken)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x9BB128", Offset = "0x9BB128", VA = "0x9BB128")]
	public static void SendOnlineLevelRetriedEvent(string levelCode, float time, string authToken)
	{
	}
}
[Token(Token = "0x2000014")]
public sealed class SantaCruzInputDevice : PalazzoInputDevice
{
	[Token(Token = "0x20001DA")]
	private struct HapticData
	{
		[Token(Token = "0x4000D51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public OVRHaptics.OVRHapticsChannel channel;

		[Token(Token = "0x4000D52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public HapticType type;

		[Token(Token = "0x4000D53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float? amplitude;

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x7D89DC", Offset = "0x7D89DC", VA = "0x7D89DC")]
		public HapticData(OVRHaptics.OVRHapticsChannel channel, HapticType type, float? amplitude)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001DB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767174", Offset = "0x767174")]
	private sealed class <>c
	{
		[Token(Token = "0x4000D54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000D55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Message<AchievementUpdate>.Callback <>9__13_0;

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x9DF99C", Offset = "0x9DF99C", VA = "0x9DF99C")]
		public <>c()
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x9DF9A4", Offset = "0x9DF9A4", VA = "0x9DF9A4")]
		internal void <HandleAchievement>b__13_0(Message<AchievementUpdate> message)
		{
		}
	}

	[Token(Token = "0x4000036")]
	private const OVRInput.Button TRIGGER_BUTTON = OVRInput.Button.PrimaryIndexTrigger | OVRInput.Button.PrimaryHandTrigger | OVRInput.Button.SecondaryIndexTrigger | OVRInput.Button.SecondaryHandTrigger;

	[Token(Token = "0x4000037")]
	private const OVRInput.RawButton MENU_BUTTON = OVRInput.RawButton.A | OVRInput.RawButton.Start;

	[Token(Token = "0x4000038")]
	private const OVRInput.RawButton SECONDARY_MENU_BUTTON = OVRInput.RawButton.B;

	[Token(Token = "0x4000039")]
	private const OVRInput.RawButton RECENTER_TOOLBOX_BUTTON = OVRInput.RawButton.LThumbstick | OVRInput.RawButton.RThumbstick;

	[Token(Token = "0x400003A")]
	private const byte MAX_HAPTIC_AMPLITUDE = byte.MaxValue;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly OVRHapticsClip[] hapticClips;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool pausePrev;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool hmdUnmounted;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string[] achievementLookupTable;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<int, HapticData> haptics;

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x9DD31C", Offset = "0x9DD31C", VA = "0x9DD31C")]
	public SantaCruzInputDevice(ARTransforms arTransforms, HapticAudioClips hapticAudioClips)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x9DE64C", Offset = "0x9DE64C", VA = "0x9DE64C", Slot = "6")]
	public override void Tick()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x9DE918", Offset = "0x9DE918", VA = "0x9DE918", Slot = "7")]
	public override void HandleAchievement(Achievements type)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x9DEA94", Offset = "0x9DEA94", VA = "0x9DEA94")]
	private void OnHMDMounted()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x9DEA9C", Offset = "0x9DEA9C", VA = "0x9DEA9C")]
	private void OnHMDUnmounted()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x9DEAA8", Offset = "0x9DEAA8", VA = "0x9DEAA8", Slot = "9")]
	public override bool HasInputFocus()
	{
		return default(bool);
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x9DEB08", Offset = "0x9DEB08", VA = "0x9DEB08", Slot = "11")]
	public override void Recenter()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x9DEB80", Offset = "0x9DEB80", VA = "0x9DEB80", Slot = "12")]
	public override void PlayHaptic(HapticType hapticType, XRNode hand, [Optional] float? amplitude, bool playUntilStop = false)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x9DEDC4", Offset = "0x9DEDC4", VA = "0x9DEDC4", Slot = "14")]
	public override void SetHapticAmplitude(HapticType hapticType, XRNode hand, float amplitude)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x9DEEE8", Offset = "0x9DEEE8", VA = "0x9DEEE8", Slot = "13")]
	public override void StopHaptic(HapticType hapticType, XRNode hand)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x9DE4E8", Offset = "0x9DE4E8", VA = "0x9DE4E8")]
	private OVRHapticsClip GenerateVibration(int vibCount, int amplitude, int changeOverTime)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x9DEF60", Offset = "0x9DEF60", VA = "0x9DEF60", Slot = "15")]
	public override bool TriggerPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x9DEFCC", Offset = "0x9DEFCC", VA = "0x9DEFCC", Slot = "16")]
	public override bool TriggerPress()
	{
		return default(bool);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x9DF038", Offset = "0x9DF038", VA = "0x9DF038", Slot = "17")]
	public override bool TriggerPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x9DF0A4", Offset = "0x9DF0A4", VA = "0x9DF0A4", Slot = "28")]
	public override float Trigger(XRNode hand)
	{
		return default(float);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x9DF130", Offset = "0x9DF130", VA = "0x9DF130", Slot = "29")]
	public override bool TriggerDown(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x9DF1BC", Offset = "0x9DF1BC", VA = "0x9DF1BC", Slot = "30")]
	public override bool TriggerUp(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x9DF248", Offset = "0x9DF248", VA = "0x9DF248", Slot = "18")]
	public override bool MenuPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x9DF2B4", Offset = "0x9DF2B4", VA = "0x9DF2B4", Slot = "19")]
	public override bool MenuPress()
	{
		return default(bool);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x9DF320", Offset = "0x9DF320", VA = "0x9DF320", Slot = "20")]
	public override bool MenuPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x9DF38C", Offset = "0x9DF38C", VA = "0x9DF38C", Slot = "21")]
	public override bool SecondaryMenuPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x9DF3F4", Offset = "0x9DF3F4", VA = "0x9DF3F4", Slot = "22")]
	public override bool SecondaryMenuPress()
	{
		return default(bool);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x9DF45C", Offset = "0x9DF45C", VA = "0x9DF45C", Slot = "23")]
	public override bool SecondaryMenuPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x9DF4C4", Offset = "0x9DF4C4", VA = "0x9DF4C4", Slot = "26")]
	public override bool ToolboxRecenterPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x9DF52C", Offset = "0x9DF52C", VA = "0x9DF52C", Slot = "24")]
	public override bool StampItem(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x9DF5B8", Offset = "0x9DF5B8", VA = "0x9DF5B8", Slot = "25")]
	public override bool DeleteItem(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x9DF644", Offset = "0x9DF644", VA = "0x9DF644", Slot = "27")]
	public override bool TouchpadPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x9DF64C", Offset = "0x9DF64C", VA = "0x9DF64C", Slot = "31")]
	public override Vector2 ThumbstickAxis(XRNode hand)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x9DF6D8", Offset = "0x9DF6D8", VA = "0x9DF6D8", Slot = "32")]
	public override Vector3 TouchpadSwipeVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x9DF738", Offset = "0x9DF738", VA = "0x9DF738", Slot = "33")]
	public override Vector3 GetHeadLocalPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x9DF79C", Offset = "0x9DF79C", VA = "0x9DF79C", Slot = "34")]
	public override Quaternion GetHeadLocalRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x9DF800", Offset = "0x9DF800", VA = "0x9DF800", Slot = "35")]
	public override Vector3 GetHandLocalPosition(XRNode hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x9DF868", Offset = "0x9DF868", VA = "0x9DF868", Slot = "37")]
	public override Vector3 GetHandLocalPositionWhileAiming(XRNode hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x9DF8D0", Offset = "0x9DF8D0", VA = "0x9DF8D0", Slot = "36")]
	public override Quaternion GetHandLocalRotation(XRNode hand)
	{
		return default(Quaternion);
	}
}
[Serializable]
[Token(Token = "0x2000015")]
public sealed class HapticAudioClips
{
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AudioClip onSlingshotFire;

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xA14600", Offset = "0xA14600", VA = "0xA14600")]
	public HapticAudioClips()
	{
	}
}
[Token(Token = "0x2000016")]
public sealed class SantaCruzWorldTracker : WorldTracker
{
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x9DFD28", Offset = "0x9DFD28", VA = "0x9DFD28")]
	public SantaCruzWorldTracker()
	{
	}
}
[Token(Token = "0x2000017")]
public sealed class SantaCruzPlatform : PalazzoPlatform
{
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private HapticAudioClips hapticAudioClips;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Message entiteledMessage;

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x9DFAC8", Offset = "0x9DFAC8", VA = "0x9DFAC8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x9DFB90", Offset = "0x9DFB90", VA = "0x9DFB90", Slot = "6")]
	public override bool HasTwoHandedSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x9DFB98", Offset = "0x9DFB98", VA = "0x9DFB98", Slot = "8")]
	public override Theme[] GetEnabledThemes()
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x9DFC1C", Offset = "0x9DFC1C", VA = "0x9DFC1C", Slot = "7")]
	public override bool IsUserEntitled()
	{
		return default(bool);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x9DFC58", Offset = "0x9DFC58", VA = "0x9DFC58", Slot = "11")]
	protected override PalazzoInputDevice CreateInputDeviceInternal(ARTransforms arTransforms)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x9DFCCC", Offset = "0x9DFCCC", VA = "0x9DFCCC", Slot = "12")]
	protected override WorldTracker CreateWorldTrackerInternal(ARTransforms arTransforms, PalazzoTriggers palazzoTriggers)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x9DFD30", Offset = "0x9DFD30", VA = "0x9DFD30")]
	public SantaCruzPlatform()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x9DFD38", Offset = "0x9DFD38", VA = "0x9DFD38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A0D8", Offset = "0x76A0D8")]
	private void <Start>b__2_0(Message message)
	{
	}
}
[Token(Token = "0x2000018")]
public class GodRayDust : MonoBehaviour
{
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int materialIndex;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector2 uvAnimationRate;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Renderer dustRenderer;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector2 uvOffset;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xA14410", Offset = "0xA14410", VA = "0xA14410")]
	private void Start()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xA14468", Offset = "0xA14468", VA = "0xA14468")]
	private void Update()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xA14560", Offset = "0xA14560", VA = "0xA14560")]
	public GodRayDust()
	{
	}
}
[Token(Token = "0x2000019")]
public class AchievementHandler
{
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoWorld[] worldPrefabs;

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x99B434", Offset = "0x99B434", VA = "0x99B434")]
	public AchievementHandler(InputHandler inputHandler, PalazzoGameDataPersistent gameDataPersistent, PalazzoWorld[] worldPrefabs)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x99B474", Offset = "0x99B474", VA = "0x99B474")]
	public void UnlockAchievement(Achievements achievement)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x99B4AC", Offset = "0x99B4AC", VA = "0x99B4AC")]
	public void UnlockAlreadyFulfilledAchievements()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x99B5B0", Offset = "0x99B5B0", VA = "0x99B5B0")]
	public bool ValidateAchievement(Achievements achievement)
	{
		return default(bool);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x99B9EC", Offset = "0x99B9EC", VA = "0x99B9EC")]
	public int GetWorldStarCount(WorldType worldType)
	{
		return default(int);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x99B878", Offset = "0x99B878", VA = "0x99B878")]
	public bool HasClearedLevel(WorldType worldType, int levelIndexInWorld)
	{
		return default(bool);
	}
}
[Token(Token = "0x200001A")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x765D18", Offset = "0x765D18")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x765D18", Offset = "0x765D18")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x765D18", Offset = "0x765D18")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x765D18", Offset = "0x765D18")]
public class AlchemyComponent : MonoBehaviour
{
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool hasBeenAlchemised;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public BlockType originalBlockType;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PalazzoComponentLevelBlock iceReferenceBlock;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public PalazzoComponentLevelBlock woodReferenceBlock;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public PalazzoComponentLevelBlock rockReferenceBlock;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x99BB9C", Offset = "0x99BB9C", VA = "0x99BB9C")]
	public AlchemyComponent()
	{
	}
}
[Token(Token = "0x200001B")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x765E04", Offset = "0x765E04")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x765E04", Offset = "0x765E04")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x765E04", Offset = "0x765E04")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x765E04", Offset = "0x765E04")]
public class AlchemyExplosionComponent : MonoBehaviour
{
	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PalazzoComponentLevelBlock levelBlock;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BlockType targetBlockType;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float explosionRadius;

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x99BBA4", Offset = "0x99BBA4", VA = "0x99BBA4")]
	public AlchemyExplosionComponent()
	{
	}
}
[Token(Token = "0x200001C")]
public class AlchemyHandler
{
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelBlockHelper levelBlockHelper;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly AchievementHandler achievementHandler;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool firstTime;

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x99BBB4", Offset = "0x99BBB4", VA = "0x99BBB4")]
	public AlchemyHandler(LevelBlockHelper levelBlockHelper, AchievementHandler achievementHandler)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x99BBEC", Offset = "0x99BBEC", VA = "0x99BBEC")]
	public void AlchemiseBlock(PalazzoComponentLevelBlock block, BlockType targetBlockType)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x99C04C", Offset = "0x99C04C", VA = "0x99C04C")]
	public void ResetBlock(PalazzoComponentLevelBlock block)
	{
	}
}
[Token(Token = "0x200001D")]
public sealed class AmbientAudioComponent : MonoBehaviour
{
	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform right;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform left;

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x99C1F8", Offset = "0x99C1F8", VA = "0x99C1F8")]
	public AmbientAudioComponent()
	{
	}
}
[Token(Token = "0x200001E")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x765EF0", Offset = "0x765EF0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x765EF0", Offset = "0x765EF0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x765EF0", Offset = "0x765EF0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x765EF0", Offset = "0x765EF0")]
public sealed class BalloonComponent : MonoBehaviour
{
	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Rigidbody rb;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SpringJoint joint;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LineRenderer rope;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 startUpVector;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float speedVariationAmplitude;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float speedVariationFrequency;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float buoyancyMultiplier;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public PalazzoComponentLevelBlock connectedBody;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public bool connectedToPig;

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x99C944", Offset = "0x99C944", VA = "0x99C944")]
	public BalloonComponent()
	{
	}
}
[Token(Token = "0x200001F")]
public sealed class BirdSelectionHandler
{
	[Token(Token = "0x20001DC")]
	private class BirdFlyingBackToToolbox
	{
		[Token(Token = "0x4000D56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ToolboxItemComponent bird;

		[Token(Token = "0x4000D57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 targetPosition;

		[Token(Token = "0x4000D58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion targetRotation;

		[Token(Token = "0x4000D59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float timeInFlight;

		[Token(Token = "0x4000D5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ToolboxItemComponent item;

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x9A07D4", Offset = "0x9A07D4", VA = "0x9A07D4")]
		public BirdFlyingBackToToolbox()
		{
		}
	}

	[Token(Token = "0x20001DD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767184", Offset = "0x767184")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x4000D5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<ToolboxItemComponent> selectedBirds;

		[Token(Token = "0x4000D5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<ToolboxItemComponent, bool> <>9__0;

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x99E658", Offset = "0x99E658", VA = "0x99E658")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x9A0994", Offset = "0x9A0994", VA = "0x9A0994")]
		internal bool <SetBirds>b__0(ToolboxItemComponent y)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x20001DE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767194", Offset = "0x767194")]
	private sealed class <>c
	{
		[Token(Token = "0x4000D5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000D5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<ToolboxItemComponent, bool> <>9__24_0;

		[Token(Token = "0x4000D5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<ToolboxItemComponent, bool> <>9__26_0;

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x9A08E4", Offset = "0x9A08E4", VA = "0x9A08E4")]
		public <>c()
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x9A08EC", Offset = "0x9A08EC", VA = "0x9A08EC")]
		internal bool <OnRelease>b__24_0(ToolboxItemComponent x)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x9A0940", Offset = "0x9A0940", VA = "0x9A0940")]
		internal bool <SpawnBirdFromPool>b__26_0(ToolboxItemComponent x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelEditorComponent levelEditor;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly ToolboxItemInteractionHandler itemInteractionHandler;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly LevelEditorVRController vrController;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly ToolboxTabComponent tab;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly BirdTabComponent birdTab;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly LevelEditorSettings levelEditorSettings;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly ToolboxSettings toolboxSettings;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ToolboxItemComponent[] grabbedItems;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] grabbedItemStartingPostions;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Quaternion[] grabbedItemStartingRotations;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int[] grabbedItemIntersectedSlot;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<BirdFlyingBackToToolbox> birdsFlyingBackToToolbox;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ToolboxItemComponent[][] birdPool;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int idle;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int fly;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly int inHand;

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x99CF98", Offset = "0x99CF98", VA = "0x99CF98")]
	public BirdSelectionHandler(LevelEditorContext levelEditorContext, LevelEditorComponent levelEditor, InputHandler inputHandler, LevelEditorVRController vrController, ToolboxTabComponent tab, BirdTabComponent birdTab, LevelEditorSettings levelEditorSettings, PalazzoTriggers palazzoTriggers, ToolboxSettings toolboxSettings)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x99D468", Offset = "0x99D468", VA = "0x99D468")]
	public void Tick()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x99E3A0", Offset = "0x99E3A0", VA = "0x99E3A0")]
	public void SetBirds()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x99EB8C", Offset = "0x99EB8C", VA = "0x99EB8C")]
	public void Reset()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x99F300", Offset = "0x99F300", VA = "0x99F300")]
	private void OnInteract(ToolboxItemComponent item, VRGrab grab)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x99FBE0", Offset = "0x99FBE0", VA = "0x99FBE0")]
	private void OnRelease(ToolboxItemComponent item, VRGrab grab)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x99E660", Offset = "0x99E660", VA = "0x99E660")]
	private void SelectBird(ToolboxItemComponent bird, int pos)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x99F824", Offset = "0x99F824", VA = "0x99F824")]
	private ToolboxItemComponent SpawnBirdFromPool(int birdId)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x99E2EC", Offset = "0x99E2EC", VA = "0x99E2EC")]
	private void CopyAnimationState(Animator source, Animator target)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x99E108", Offset = "0x99E108", VA = "0x99E108")]
	private bool BirdIsFlyingOrGrabbed(ToolboxItemComponent bird, int iHand)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000020")]
public sealed class BirdSpecialAbilityHandler
{
	[Token(Token = "0x4000072")]
	private const float BLUE_SPLIT_SPAWN_OFFSET = 5f;

	[Token(Token = "0x4000073")]
	private const float BLUE_SPLIT_RIGHT_ANGLE = 8f;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly float[] BLUE_SPLIT_FORWARD_ANGLES;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly PhysicsSettings physicsSettings;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly LevelBlockFactory levelBlockFactory;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly PalazzoComponentLevelBlock blueLevelBlockPrefab;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly AchievementHandler achievementHandler;

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x9A0A10", Offset = "0x9A0A10", VA = "0x9A0A10")]
	public BirdSpecialAbilityHandler(ARTransforms arTransforms, InputHandler inputHandler, LevelContext levelContext, PalazzoTriggers palazzoTriggers, PhysicsSettings physicsSettings, LevelBlockFactory levelBlockFactory, PalazzoComponentLevelBlock[] levelBlockPrefabs, AchievementHandler achievementHandler)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x9A0BB4", Offset = "0x9A0BB4", VA = "0x9A0BB4")]
	public void ActivateSpecialAbilities()
	{
	}
}
[Token(Token = "0x2000021")]
public sealed class BirdsRemainingHandler
{
	[Token(Token = "0x400007D")]
	private const float START_ROTATE_ANGLE_THRESHOLD = 20f;

	[Token(Token = "0x400007E")]
	private const float STOP_MOVE_DISTANCE_TRHESHOLD = 0.05f;

	[Token(Token = "0x400007F")]
	private const float START_MOVE_DISTANCE_THRESHOLD = 0.05f;

	[Token(Token = "0x4000080")]
	private const float ROTATE_MAX_DEGREES_DELTA = 150f;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x9A1524", Offset = "0x9A1524", VA = "0x9A1524")]
	public BirdsRemainingHandler(ARTransforms arTransforms, LevelContext levelContext, InputHandler inputHandler, PalazzoComponentBirdPlatform birdPlatform)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x9A1570", Offset = "0x9A1570", VA = "0x9A1570")]
	private Vector3 CalcTargetDirection(Vector3 src, Vector3 dst)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x9A1620", Offset = "0x9A1620", VA = "0x9A1620")]
	private Quaternion CalcTargetRotation(Vector3 myPosition)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x9A1738", Offset = "0x9A1738", VA = "0x9A1738")]
	private void RotateToTargetEnter(PalazzoComponentBird bird, Vector3 myPosition, Vector3 targetPosition)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x9A1848", Offset = "0x9A1848", VA = "0x9A1848")]
	public void Reset()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x9A1A4C", Offset = "0x9A1A4C", VA = "0x9A1A4C")]
	public void Tick()
	{
	}
}
[Token(Token = "0x2000022")]
public class BirdTabComponent : MonoBehaviour
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<ToolboxItemComponent> selectedBirds;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<ToolboxItemComponent> redPool;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<ToolboxItemComponent> chuckPool;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<ToolboxItemComponent> bombPool;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ToolboxItemComponent> bluesPool;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Collider> selectionSlots;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float scaleFactor;

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x9A151C", Offset = "0x9A151C", VA = "0x9A151C")]
	public BirdTabComponent()
	{
	}
}
[Token(Token = "0x2000023")]
[DisallowMultipleComponent]
public sealed class BlockTypeData : MonoBehaviour
{
	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BlockType type;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string soundSpawn;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string soundDespawn;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string soundDamage;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string soundDestroy;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string soundDestroyExtra;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string soundDestroyExtra2;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string soundFuse;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ScoreEffectComponent scoreFx;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ParticleEffectComponent prefabSpawnFx;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ParticleEffectComponent prefabDespawnFx;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ParticleEffectComponent prefabImpactFx;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ParticleEffectComponent prefabDamageFx;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ParticleEffectComponent prefabDestroyFx;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ParticleEffectComponent prefabFuseFx;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public ParticleEffectComponent prefabHitFx;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public ParticleEffectComponent prefabScoreFx;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public string soundImpactLight;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public string soundImpactMedium;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public string soundImpactHeavy;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public string soundImpactHit;

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x9A2638", Offset = "0x9A2638", VA = "0x9A2638")]
	public BlockTypeData()
	{
	}
}
[Token(Token = "0x2000024")]
public sealed class BuildingBlockFactory
{
	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelEditorComponent levelEditor;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly Material[][] greenMaterials;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Material[][] grayMaterials;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly int defaultLayer;

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x9A44F8", Offset = "0x9A44F8", VA = "0x9A44F8")]
	public BuildingBlockFactory(LevelEditorComponent levelEditor, Material[][] greenMaterials, Material[][] grayMaterials)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x9A4580", Offset = "0x9A4580", VA = "0x9A4580")]
	public LevelBuildingBlock CreateLevelBuildBlock(int prefabId)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x9A5650", Offset = "0x9A5650", VA = "0x9A5650")]
	public void DestroyLevelBuildingBlock(LevelBuildingBlock block)
	{
	}
}
[Token(Token = "0x2000025")]
public sealed class CameraFadeComponent : MonoBehaviour
{
	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Material fadeMaterial;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MeshRenderer meshRenderer;

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x9A57AC", Offset = "0x9A57AC", VA = "0x9A57AC")]
	public CameraFadeComponent()
	{
	}
}
[Token(Token = "0x2000026")]
public class CharacterLookAtHandler
{
	[Token(Token = "0x40000A7")]
	private const float MIN_LOOK_OR_LOOK_AWAY_TIME = 0.5f;

	[Token(Token = "0x40000A8")]
	private const float MAX_TILT_RADIANS_FOR_GLOBAL_LOOK_AT = 0.12217305f;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly Transform[] characterLookAtTargets;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float blendedNeckLookWeight;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform target;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform neckTarget;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float switchTargetDelay;

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x9A57B4", Offset = "0x9A57B4", VA = "0x9A57B4")]
	public CharacterLookAtHandler(LevelContext levelContext, Transform[] characterLookAtTargets)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x9A589C", Offset = "0x9A589C", VA = "0x9A589C")]
	public void Reset()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x9A58A4", Offset = "0x9A58A4", VA = "0x9A58A4")]
	public void LateTick()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x9A6050", Offset = "0x9A6050", VA = "0x9A6050")]
	private void TurnPupilTowardsTargetLocal(InteractiveCharacterComponent character, Transform eyeTransform, Vector3 targetPosition, Vector3 eyeCenterRotation)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x9A62D0", Offset = "0x9A62D0", VA = "0x9A62D0")]
	private void TurnPupilTowardsTargetGlobal(InteractiveCharacterComponent character, Transform eyeTransform, Vector3 targetPosition, Vector3 eyeCenterRotation)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x9A581C", Offset = "0x9A581C", VA = "0x9A581C")]
	private void SetNewTarget()
	{
	}
}
[Token(Token = "0x2000027")]
public class ThreadJob<T>
{
	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private T result;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool isDone;

	[Token(Token = "0x60000BF")]
	public bool TryGetResult(out T result)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C0")]
	public void SetResult(T result)
	{
	}

	[Token(Token = "0x60000C1")]
	public ThreadJob()
	{
	}
}
[Token(Token = "0x2000028")]
public static class Compression
{
	[Token(Token = "0x20001DF")]
	private struct DataToDecompress
	{
		[Token(Token = "0x4000D60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ThreadJob<Level> job;

		[Token(Token = "0x4000D61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string data;
	}

	[Token(Token = "0x20001E0")]
	private struct LevelToCompress
	{
		[Token(Token = "0x4000D62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ThreadJob<string> job;

		[Token(Token = "0x4000D63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Level data;
	}

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Thread compressionThread;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Thread decompressionThread;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Queue<DataToDecompress> dataToDecompress;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Queue<LevelToCompress> levelsToCompress;

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x9A654C", Offset = "0x9A654C", VA = "0x9A654C")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x9A6718", Offset = "0x9A6718", VA = "0x9A6718")]
	public static ThreadJob<Level> Decompress(string data)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x9A6848", Offset = "0x9A6848", VA = "0x9A6848")]
	public static ThreadJob<string> EnqueueCompression(Level level)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x9A6978", Offset = "0x9A6978", VA = "0x9A6978")]
	private static void CompressionThread()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x9A6B14", Offset = "0x9A6B14", VA = "0x9A6B14")]
	private static void DecompressionThread()
	{
	}
}
[Token(Token = "0x2000029")]
public class ConnectionHandler
{
	[Token(Token = "0x20001E1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7671A4", Offset = "0x7671A4")]
	private sealed class <MaintainConnection>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000D64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000D65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000D66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ConnectionHandler <>4__this;

		[Token(Token = "0x4000D67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityWebRequest <request>5__2;

		[Token(Token = "0x170000F9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x9A78BC", Offset = "0x9A78BC", VA = "0x9A78BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x9A792C", Offset = "0x9A792C", VA = "0x9A792C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x9A6E1C", Offset = "0x9A6E1C", VA = "0x9A6E1C")]
		[DebuggerHidden]
		public <MaintainConnection>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x9A6F30", Offset = "0x9A6F30", VA = "0x9A6F30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x9A6F34", Offset = "0x9A6F34", VA = "0x9A6F34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x9A78C4", Offset = "0x9A78C4", VA = "0x9A78C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly WaitForSecondsRealtime twoSeconds;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool shouldFetchNewAuthToken;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7675B4", Offset = "0x7675B4")]
	private string <AuthToken>k__BackingField;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool shouldFetchPlayfabId;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7675C4", Offset = "0x7675C4")]
	private string <PlayfabId>k__BackingField;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7675D4", Offset = "0x7675D4")]
	private User <User>k__BackingField;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7675E4", Offset = "0x7675E4")]
	private bool <IsBanned>k__BackingField;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Future<string> authTokenFuture;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Future<string> loginFuture;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Future<User> getUserDataFuture;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool canReachGoogleServices;

	[Token(Token = "0x17000001")]
	public string AuthToken
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x9A6CB8", Offset = "0x9A6CB8", VA = "0x9A6CB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A0F8", Offset = "0x76A0F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x9A6CB0", Offset = "0x9A6CB0", VA = "0x9A6CB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A0E8", Offset = "0x76A0E8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public string PlayfabId
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x9A6CC8", Offset = "0x9A6CC8", VA = "0x9A6CC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A118", Offset = "0x76A118")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x9A6CC0", Offset = "0x9A6CC0", VA = "0x9A6CC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A108", Offset = "0x76A108")]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public User User
	{
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x9A6CD8", Offset = "0x9A6CD8", VA = "0x9A6CD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A138", Offset = "0x76A138")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x9A6CD0", Offset = "0x9A6CD0", VA = "0x9A6CD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A128", Offset = "0x76A128")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public bool IsBanned
	{
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x9A6CEC", Offset = "0x9A6CEC", VA = "0x9A6CEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A158", Offset = "0x76A158")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x9A6CE0", Offset = "0x9A6CE0", VA = "0x9A6CE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A148", Offset = "0x76A148")]
		private set
		{
		}
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x9A6CF4", Offset = "0x9A6CF4", VA = "0x9A6CF4")]
	public ConnectionHandler(MonoBehaviour monoBehaviour, InputHandler inputHandler)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x9A6DA8", Offset = "0x9A6DA8", VA = "0x9A6DA8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76A168", Offset = "0x76A168")]
	private IEnumerator MaintainConnection()
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x9A6E48", Offset = "0x9A6E48", VA = "0x9A6E48")]
	public bool IsConnectionEstablished()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x9A6EA0", Offset = "0x9A6EA0", VA = "0x9A6EA0")]
	public void Reconnect()
	{
	}
}
[Token(Token = "0x200002A")]
public class CreateUserMenu : UiMenuBase<CreateUserMenuButton, CreateUserMenuButtonType>
{
	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SpriteRenderer spriteRenderer;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject spriteRoot;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float spriteChangeSpeed;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float spriteAccelerationTime;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SlotMachine[] slotMachines;

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x9A793C", Offset = "0x9A793C", VA = "0x9A793C")]
	public CreateUserMenu()
	{
	}
}
[Token(Token = "0x200002B")]
public enum CreateUserMenuButtonType
{
	[Token(Token = "0x40000C7")]
	Randomize,
	[Token(Token = "0x40000C8")]
	Create,
	[Token(Token = "0x40000C9")]
	Cancel
}
[Token(Token = "0x200002C")]
public class CreateUserMenuButton : PalazzoButton<CreateUserMenuButtonType>
{
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x9A798C", Offset = "0x9A798C", VA = "0x9A798C")]
	public CreateUserMenuButton()
	{
	}
}
[Token(Token = "0x200002D")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x765FEC", Offset = "0x765FEC")]
public sealed class CutsceneComponent : MonoBehaviour
{
	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string guid;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int levelIndex;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public CutSceneQueue queue;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool requiresPlayerFocus;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public PlayableDirector director;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CutsceneSoundTrigger[] soundTriggers;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform customPlayerPose;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject levelPlatformComponents;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public WorldType world;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Animator idleAnimator;

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x9A87C0", Offset = "0x9A87C0", VA = "0x9A87C0")]
	public CutsceneComponent()
	{
	}
}
[Token(Token = "0x200002E")]
public sealed class CutsceneHandler
{
	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x40000D8")]
	private const float FOCUS_THRESHOLD = 0.87f;

	[Token(Token = "0x40000D9")]
	private const float FOCUS_TIME_REQUIRED = 3f;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<int, CutsceneComponent> cutsceneLookup;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CutsceneComponent currentPlayingCutscene;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float focusTimer;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool waitingForFocus;

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x9A87C8", Offset = "0x9A87C8", VA = "0x9A87C8")]
	public CutsceneHandler(ARTransforms arTransforms, CutsceneComponent[] cutscenes, PalazzoTriggers palazzoTriggers, InputHandler inputHandler, PalazzoGameDataPersistent gameDataPersistent)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x9A89F4", Offset = "0x9A89F4", VA = "0x9A89F4")]
	public void Tick()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x9A8DB0", Offset = "0x9A8DB0", VA = "0x9A8DB0")]
	private bool HasCutsceneBeenWatched()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x9A90D0", Offset = "0x9A90D0", VA = "0x9A90D0")]
	public bool LevelHasCutsceneBefore(int levelIndex, out CutsceneComponent cutscene)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x9A9174", Offset = "0x9A9174", VA = "0x9A9174")]
	public bool LevelHasCutsceneAfter(int levelIndex, out CutsceneComponent cutscene)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x9A9218", Offset = "0x9A9218", VA = "0x9A9218")]
	public void PlayCutscene(CutsceneComponent cutscene)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x9A8E40", Offset = "0x9A8E40", VA = "0x9A8E40")]
	private void OnCutsceneStopped(PlayableDirector director)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x9A94D0", Offset = "0x9A94D0", VA = "0x9A94D0")]
	public bool IsPlayingCutscene()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x9A9540", Offset = "0x9A9540", VA = "0x9A9540")]
	public void SetTerrorPeakOutroDefaults(WorldType currentWorld, CutsceneComponent[] cutscenes)
	{
	}
}
[Token(Token = "0x200002F")]
public class CutsceneSoundTrigger : MonoBehaviour
{
	[Token(Token = "0x20001E2")]
	public delegate void PlaySoundDelegate(Component obj, string sound);

	[Token(Token = "0x20001E3")]
	public delegate void StopSoundDelegate(Component obj, string sound);

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string sound;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PlaySoundDelegate playSoundDelegate;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public PlaySoundDelegate stopSoundDelegate;

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x9A97F4", Offset = "0x9A97F4", VA = "0x9A97F4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x9A9F90", Offset = "0x9A9F90", VA = "0x9A9F90")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x9A9FAC", Offset = "0x9A9FAC", VA = "0x9A9FAC")]
	public CutsceneSoundTrigger()
	{
	}
}
[Token(Token = "0x2000030")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766060", Offset = "0x766060")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766060", Offset = "0x766060")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766060", Offset = "0x766060")]
public sealed class DamageComponent : MonoBehaviour
{
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PalazzoComponentLevelBlock levelBlock;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter meshFilter;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Mesh optionalHalfBrokenMesh;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Mesh optionalBrokenMesh;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ProgressMeter optionalHealthBar;

	[NonSerialized]
	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public DamageQueue damageQueue;

	[NonSerialized]
	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public DamageState damageState;

	[NonSerialized]
	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float maxHealth;

	[NonSerialized]
	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float health;

	[NonSerialized]
	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float damage;

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x9AAAE8", Offset = "0x9AAAE8", VA = "0x9AAAE8")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x9AAF20", Offset = "0x9AAF20", VA = "0x9AAF20")]
	public DamageComponent()
	{
	}
}
[Token(Token = "0x2000031")]
public sealed class DamageHandler
{
	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int impactLookupLength;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelBlockFactory levelBlockFactory;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly DamageQueue damageQueue;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly BirdImpactQueue birdImpactQueue;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly float impactMagnitudeThreshold;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly LevelBlockHelper levelBlockHelper;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly HealthBarData healthBarData;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly EffectQueue effectQueue;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly AlchemyHandler alchemyHandler;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly float[] impactDamageMultiplierLookup;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly float[] impactVelocityRetainLookup;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly List<DamageComponent> damageBlocksToDestroy;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly List<ExplosionComponent> explosionsToDetonate;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly List<int> impactBirdOnPigLookup;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly int impactGroundPig;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private readonly int impactGroundBossPig;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly List<AlchemyExplosionComponent> alchemyExplosionsToDetonate;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly float maxDistanceBelowLevelForBlocks;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private readonly int scoreMultiplier;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool triggerHaptics;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int emissionAddId;

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x9AAF28", Offset = "0x9AAF28", VA = "0x9AAF28")]
	public DamageHandler(GameStateData gameStateData, ARTransforms arTransforms, InputHandler inputHandler, LevelContext levelContext, PalazzoTriggers palazzoTriggers, LevelBlockFactory levelBlockFactory, DamageSettings damageSettings, DamageQueue damageQueue, BirdImpactQueue birdImpactQueue, float impactMagnitudeThreshold, LevelBlockHelper levelBlockHelper, HealthBarData healthBarData, EffectQueue effectQueue, AlchemyHandler alchemyHandler, WorldContext worldContext, LevelEditorPlayContext levelEditorPlayContext)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x9ABF98", Offset = "0x9ABF98", VA = "0x9ABF98")]
	public void FixedTick()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x9AE398", Offset = "0x9AE398", VA = "0x9AE398")]
	public void Tick()
	{
	}
}
[Token(Token = "0x2000032")]
public class DebugText : MonoBehaviour
{
	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static DebugText _instance;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text textField;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int numLines;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<string, string> logsByKeyword;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string[] logTextLines;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int currentLogIndex;

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x9AE9EC", Offset = "0x9AE9EC", VA = "0x9AE9EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x9AEC5C", Offset = "0x9AEC5C", VA = "0x9AEC5C")]
	public static void Print(string msg, string keyword)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x9AEC60", Offset = "0x9AEC60", VA = "0x9AEC60")]
	public static void Print(string msg, params object[] args)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x9AEC64", Offset = "0x9AEC64", VA = "0x9AEC64")]
	public static void Clear(string keyword = "")
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x9AEC68", Offset = "0x9AEC68", VA = "0x9AEC68")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x9AECB8", Offset = "0x9AECB8", VA = "0x9AECB8")]
	private void AddText(string text, string keyword = "")
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x9AF1EC", Offset = "0x9AF1EC", VA = "0x9AF1EC")]
	private void ClearText(string keyword = "")
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x9AEE80", Offset = "0x9AEE80", VA = "0x9AEE80")]
	private void UpdateText()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x9AF2A8", Offset = "0x9AF2A8", VA = "0x9AF2A8")]
	public DebugText()
	{
	}
}
[Token(Token = "0x2000033")]
public class EffectOnImpactComponent : MonoBehaviour
{
	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform optionalRotationRoot;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem optionalParticleSystem;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string audioTriggerEvent;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool triggerAchievement;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Achievements typeOfAchievement;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool startSnowLift;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Rigidbody optionalRigidBody;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float despawnTimer;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public EffectOnImpactQueue effectOnImpactQueue;

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x9B22C0", Offset = "0x9B22C0", VA = "0x9B22C0")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x9B25F0", Offset = "0x9B25F0", VA = "0x9B25F0")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x9B2520", Offset = "0x9B2520", VA = "0x9B2520")]
	private void TriggerEffect(Collider collider)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x9B2758", Offset = "0x9B2758", VA = "0x9B2758")]
	public EffectOnImpactComponent()
	{
	}
}
[Token(Token = "0x2000034")]
public class EnvironmentEffectsHandler
{
	[Token(Token = "0x20001E4")]
	private class ImpactEffectData
	{
		[Token(Token = "0x4000D68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform rootTransform;

		[Token(Token = "0x4000D69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float time;

		[Token(Token = "0x4000D6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion originalRotation;

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x9B34CC", Offset = "0x9B34CC", VA = "0x9B34CC")]
		public ImpactEffectData()
		{
		}
	}

	[Token(Token = "0x4000116")]
	private const float EFFECT_TIME = 0.33f;

	[Token(Token = "0x4000117")]
	private const float MAX_ROTATION = 5f;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly EffectOnImpactQueue effectOnImpactQueue;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly AchievementHandler achievementHandler;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly EnvironmentEffects environmentEffects;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly List<ImpactEffectData> impacts;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly SnowLiftMovementHandler snowLiftMovementHandler;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly List<GameObject> objectsToDespawn;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly List<float> despawnTimers;

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x9B2830", Offset = "0x9B2830", VA = "0x9B2830")]
	public EnvironmentEffectsHandler(WorldContext worldContext, ARTransforms arTransforms, EffectOnImpactQueue effectOnImpactQueue, PalazzoTriggers palazzoTriggers, AchievementHandler achievementHandler, EnvironmentEffects environmentEffects)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x9B295C", Offset = "0x9B295C", VA = "0x9B295C")]
	public void Tick()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x9B3530", Offset = "0x9B3530", VA = "0x9B3530")]
	public void UpdateSceneEffects()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x9B34D4", Offset = "0x9B34D4", VA = "0x9B34D4")]
	private static float CalcTimeUntilEffect(EnvironmentParticleComponent particle)
	{
		return default(float);
	}
}
[Token(Token = "0x2000035")]
public class EnvironmentParticleComponent : MonoBehaviour
{
	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem particleSystem;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float interval;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float intervalVariation;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string audioTriggerEvent;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public float timer;

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x9B35E0", Offset = "0x9B35E0", VA = "0x9B35E0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x9B35EC", Offset = "0x9B35EC", VA = "0x9B35EC")]
	public EnvironmentParticleComponent()
	{
	}
}
[Token(Token = "0x2000036")]
public class NightmareSceneLightningTrigger : MonoBehaviour
{
	[Token(Token = "0x20001E5")]
	public delegate void LightningStrikeDelegate(GameObject lightning);

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem[] lightnings;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float emitInterval;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float emitIntervalRandomness;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float emitTimer;

	[Token(Token = "0x14000001")]
	public static event LightningStrikeDelegate LightningStrike
	{
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x95EF5C", Offset = "0x95EF5C", VA = "0x95EF5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A1CC", Offset = "0x76A1CC")]
		add
		{
		}
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x95F058", Offset = "0x95F058", VA = "0x95F058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A1DC", Offset = "0x76A1DC")]
		remove
		{
		}
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x95F154", Offset = "0x95F154", VA = "0x95F154")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x95F1EC", Offset = "0x95F1EC", VA = "0x95F1EC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x95FA78", Offset = "0x95FA78", VA = "0x95FA78")]
	public NightmareSceneLightningTrigger()
	{
	}
}
[Token(Token = "0x2000037")]
public sealed class RandomSpeakerEffectPosition : MonoBehaviour
{
	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform[] positions;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float effectDuration;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float timer;

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x9DC524", Offset = "0x9DC524", VA = "0x9DC524")]
	private void Start()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x9DC554", Offset = "0x9DC554", VA = "0x9DC554")]
	private void Update()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x9DC718", Offset = "0x9DC718", VA = "0x9DC718")]
	public RandomSpeakerEffectPosition()
	{
	}
}
[Token(Token = "0x2000038")]
public class SnowLift : MonoBehaviour
{
	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float duration;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float accelerationTime;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float descelerationTime;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator[] carAnimators;

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x9EF85C", Offset = "0x9EF85C", VA = "0x9EF85C")]
	public SnowLift()
	{
	}
}
[Token(Token = "0x2000039")]
public class SnowLiftMovementHandler
{
	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private WorldContext worldContext;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float startTime;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool animationStarted;

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x9EF864", Offset = "0x9EF864", VA = "0x9EF864")]
	public SnowLiftMovementHandler(WorldContext worldContext, PalazzoTriggers palazzoTriggers)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x9EF89C", Offset = "0x9EF89C", VA = "0x9EF89C")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x9EFC10", Offset = "0x9EFC10", VA = "0x9EFC10")]
	public void Start()
	{
	}
}
[Token(Token = "0x200003A")]
public sealed class EnvironmentPhysicsHandler
{
	[Token(Token = "0x20001E6")]
	private struct ForceData
	{
		[Token(Token = "0x4000D6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 forceVector;

		[Token(Token = "0x4000D6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 forcePosition;
	}

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 fluidBuoyancyDirection;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PhysicsSettings physicsSettings;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly WorldImpactQueue worldImpactQueue;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly List<ForceData> forcesToApply;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Vector3 birdWindVelocity;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private readonly Vector3 balloonWindVelocity;

	[Token(Token = "0x4000143")]
	private const int ROPE_STEPS = 10;

	[Token(Token = "0x4000144")]
	private const int BALLON_TICK_FREQUENCY = 2;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int frameCounter;

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x9B3600", Offset = "0x9B3600", VA = "0x9B3600")]
	public EnvironmentPhysicsHandler(GameStateData gameStateData, ARTransforms arTransforms, LevelContext levelContext, PhysicsSettings physicsSettings, PalazzoTriggers palazzoTriggers, WorldImpactQueue worldImpactQueue, WorldContext worldContext)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x9B3700", Offset = "0x9B3700", VA = "0x9B3700")]
	private void ApplyBuoyancy(Rigidbody rb, float depth, float invDensity, float fluidDensityMul, float buoyancyMultiplier, int frameFrequency = 1)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x9B3884", Offset = "0x9B3884", VA = "0x9B3884")]
	private void ApplyDrag(Rigidbody rb, Vector3 fluidVelocity, float fluidDragMul, float windMultiplier = 1f, int frameFrequency = 1)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x9B3A44", Offset = "0x9B3A44", VA = "0x9B3A44")]
	public void FixedTick()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x9B508C", Offset = "0x9B508C", VA = "0x9B508C")]
	public static void DrawRope(BalloonComponent balloon, Rigidbody connectedBody, float physicalLevelScaleUp)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x9B4E98", Offset = "0x9B4E98", VA = "0x9B4E98")]
	private bool PointInOABB(Vector3 point, BoxCollider box)
	{
		return default(bool);
	}
}
[Token(Token = "0x200003B")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766124", Offset = "0x766124")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766124", Offset = "0x766124")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766124", Offset = "0x766124")]
public sealed class ExplosionComponent : MonoBehaviour
{
	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float explosionRadius;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float explosionDamage;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float explosionForce;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float explosionMultiplierForPigs;

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x9B5BC8", Offset = "0x9B5BC8", VA = "0x9B5BC8")]
	public ExplosionComponent()
	{
	}
}
[Token(Token = "0x200003C")]
public class FadeHandler
{
	[Token(Token = "0x20001E7")]
	private abstract class FadeState
	{
		[Token(Token = "0x60009B8")]
		public abstract bool AllowedTransitionTo(FadeState nextState);

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xA112DC", Offset = "0xA112DC", VA = "0xA112DC", Slot = "5")]
		public virtual void Enter(FadeHandler fader)
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xA112E0", Offset = "0xA112E0", VA = "0xA112E0", Slot = "6")]
		public virtual void Tick(FadeHandler fader)
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xA112E4", Offset = "0xA112E4", VA = "0xA112E4", Slot = "7")]
		public virtual void Exit(FadeHandler fader)
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xA112E8", Offset = "0xA112E8", VA = "0xA112E8")]
		protected FadeState()
		{
		}
	}

	[Token(Token = "0x20001E8")]
	private class IdleState : FadeState
	{
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xA117E8", Offset = "0xA117E8", VA = "0xA117E8", Slot = "4")]
		public override bool AllowedTransitionTo(FadeState nextState)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xA11868", Offset = "0xA11868", VA = "0xA11868", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0xA118B0", Offset = "0xA118B0", VA = "0xA118B0", Slot = "5")]
		public override void Enter(FadeHandler fader)
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0xA1190C", Offset = "0xA1190C", VA = "0xA1190C", Slot = "7")]
		public override void Exit(FadeHandler fader)
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0xA10EF0", Offset = "0xA10EF0", VA = "0xA10EF0")]
		public IdleState()
		{
		}
	}

	[Token(Token = "0x20001E9")]
	private class FadingOutState : FadeState
	{
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0xA114B4", Offset = "0xA114B4", VA = "0xA114B4", Slot = "4")]
		public override bool AllowedTransitionTo(FadeState nextState)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0xA11568", Offset = "0xA11568", VA = "0xA11568", Slot = "5")]
		public override void Enter(FadeHandler fader)
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xA115E0", Offset = "0xA115E0", VA = "0xA115E0", Slot = "6")]
		public override void Tick(FadeHandler fader)
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xA116D8", Offset = "0xA116D8", VA = "0xA116D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0xA10EF8", Offset = "0xA10EF8", VA = "0xA10EF8")]
		public FadingOutState()
		{
		}
	}

	[Token(Token = "0x20001EA")]
	private class FullyFadedState : FadeState
	{
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xA11720", Offset = "0xA11720", VA = "0xA11720", Slot = "4")]
		public override bool AllowedTransitionTo(FadeState nextState)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xA117A0", Offset = "0xA117A0", VA = "0xA117A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0xA10F00", Offset = "0xA10F00", VA = "0xA10F00")]
		public FullyFadedState()
		{
		}
	}

	[Token(Token = "0x20001EB")]
	private class FadingInState : FadeState
	{
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0xA112F0", Offset = "0xA112F0", VA = "0xA112F0", Slot = "4")]
		public override bool AllowedTransitionTo(FadeState nextState)
		{
			return default(bool);
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0xA11370", Offset = "0xA11370", VA = "0xA11370", Slot = "5")]
		public override void Enter(FadeHandler fader)
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0xA1139C", Offset = "0xA1139C", VA = "0xA1139C", Slot = "6")]
		public override void Tick(FadeHandler fader)
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0xA1146C", Offset = "0xA1146C", VA = "0xA1146C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0xA10F08", Offset = "0xA10F08", VA = "0xA10F08")]
		public FadingInState()
		{
		}
	}

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767634", Offset = "0x767634")]
	private bool <IsIdle>k__BackingField;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767644", Offset = "0x767644")]
	private bool <IsFullyFaded>k__BackingField;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767654", Offset = "0x767654")]
	private bool <IsFading>k__BackingField;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly CameraFadeComponent cameraFadeComponent;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Material fadeMaterial;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly FadeState idleState;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly FadeState fadingOutState;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly FadeState fullyFadedState;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly FadeState fadingInState;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private FadeState currentState;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private FadeState nextState;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float targetAlpha;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Color color;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float duration;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int fadeCounter;

	[Token(Token = "0x17000005")]
	public bool IsIdle
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0xA10C1C", Offset = "0xA10C1C", VA = "0xA10C1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A1EC", Offset = "0x76A1EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000110")]
		[Address(RVA = "0xA10C24", Offset = "0xA10C24", VA = "0xA10C24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A1FC", Offset = "0x76A1FC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public bool IsFullyFaded
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0xA10C30", Offset = "0xA10C30", VA = "0xA10C30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A20C", Offset = "0x76A20C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000112")]
		[Address(RVA = "0xA10C38", Offset = "0xA10C38", VA = "0xA10C38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A21C", Offset = "0x76A21C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public bool IsFading
	{
		[Token(Token = "0x6000113")]
		[Address(RVA = "0xA10C44", Offset = "0xA10C44", VA = "0xA10C44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A22C", Offset = "0x76A22C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000114")]
		[Address(RVA = "0xA10C4C", Offset = "0xA10C4C", VA = "0xA10C4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A23C", Offset = "0x76A23C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xA10C58", Offset = "0xA10C58", VA = "0xA10C58")]
	private void ChangeState(FadeState newState)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xA10DF4", Offset = "0xA10DF4", VA = "0xA10DF4")]
	public FadeHandler(CameraFadeComponent cameraFadeComponent, PalazzoTriggers palazzoTriggers)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xA10F10", Offset = "0xA10F10", VA = "0xA10F10")]
	public void FadeOut(float duration = 0.4f)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xA10FB0", Offset = "0xA10FB0", VA = "0xA10FB0")]
	public void FadeIn(float duration = 0.2f)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xA1104C", Offset = "0xA1104C", VA = "0xA1104C")]
	public void Tick()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xA111C0", Offset = "0xA111C0", VA = "0xA111C0")]
	private void Lerp()
	{
	}
}
[Token(Token = "0x200003D")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7661E8", Offset = "0x7661E8")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7661E8", Offset = "0x7661E8")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7661E8", Offset = "0x7661E8")]
public sealed class FanComponent : MonoBehaviour
{
	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PalazzoComponentLevelBlock levelBlock;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform windFX;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public WindVortexComponent windVortex;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public BoxCollider windVortexCol;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rigidbody rb;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform optionalBlades;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float range;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float outwardsForce;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float speed;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float speedVariationAmplitude;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float speedVariationFrequency;

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xA11968", Offset = "0xA11968", VA = "0xA11968")]
	public FanComponent()
	{
	}
}
[Token(Token = "0x200003E")]
public sealed class CutsceneState : GameStateBase
{
	[Token(Token = "0x20001EC")]
	private enum State
	{
		[Token(Token = "0x4000D6E")]
		Setup,
		[Token(Token = "0x4000D6F")]
		WaitForFade,
		[Token(Token = "0x4000D70")]
		Cutscene
	}

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly CutsceneHandler cutsceneHandler;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly LevelFactory levelFactory;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Func<IEnumerator> despawnLevel;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private State state;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private State prevState;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private CutsceneComponent cutsceneToPlay;

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x9AA7BC", Offset = "0x9AA7BC", VA = "0x9AA7BC")]
	public CutsceneState(CutsceneHandler cutsceneHandler, LevelContext levelContext, TeleportationHandler teleportationHandler, LevelFactory levelFactory, FadeHandler fadeHandler, MonoBehaviour monoBehaviour, Func<IEnumerator> despawnLevel)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x9AA82C", Offset = "0x9AA82C", VA = "0x9AA82C", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x9AA894", Offset = "0x9AA894", VA = "0x9AA894", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}
}
[Token(Token = "0x200003F")]
public sealed class ErrorState : GameStateBase
{
	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ErrorMenu menu;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly UiMenuHandlerBase<ErrorMenuButton, ErrorMenuButtonType> menuHandler;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly MenuSettings menuSettings;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameState nextGameState;

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x9B5768", Offset = "0x9B5768", VA = "0x9B5768")]
	public ErrorState(ErrorMenu menu, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, ARTransforms arTransforms, WorldContext worldContext, MenuSettings menuSettings, GameStateData gameStateData, LevelEditorPlayContext levelEditorPlayContext)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x9B58A8", Offset = "0x9B58A8", VA = "0x9B58A8", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x9B5918", Offset = "0x9B5918", VA = "0x9B5918", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x9B5980", Offset = "0x9B5980", VA = "0x9B5980", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x9B5A2C", Offset = "0x9B5A2C", VA = "0x9B5A2C")]
	private void OnButtonClick(int buttonType)
	{
	}
}
[Token(Token = "0x2000040")]
public enum GameState
{
	[Token(Token = "0x4000179")]
	PlaceLevel,
	[Token(Token = "0x400017A")]
	Start,
	[Token(Token = "0x400017B")]
	SelectWorld,
	[Token(Token = "0x400017C")]
	SelectLevel,
	[Token(Token = "0x400017D")]
	Settings,
	[Token(Token = "0x400017E")]
	Privacy,
	[Token(Token = "0x400017F")]
	NoEntitlement,
	[Token(Token = "0x4000180")]
	LevelEditor,
	[Token(Token = "0x4000181")]
	Error,
	[Token(Token = "0x4000182")]
	SpawnLevel,
	[Token(Token = "0x4000183")]
	Play,
	[Token(Token = "0x4000184")]
	Pause,
	[Token(Token = "0x4000185")]
	Win,
	[Token(Token = "0x4000186")]
	Scoreboard,
	[Token(Token = "0x4000187")]
	Lose,
	[Token(Token = "0x4000188")]
	Outro,
	[Token(Token = "0x4000189")]
	Cutscene,
	[Token(Token = "0x400018A")]
	Initialize
}
[Token(Token = "0x2000041")]
public sealed class GameStateData
{
	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameState gameState;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public GameState gameStatePrev;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameState gameStateNext;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public PlayType playType;

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xA14400", Offset = "0xA14400", VA = "0xA14400")]
	public GameStateData()
	{
	}
}
[Token(Token = "0x2000042")]
public abstract class GameStateBase : StateBase<GameState>
{
	[Token(Token = "0x6000125")]
	[Address(RVA = "0xA143A8", Offset = "0xA143A8", VA = "0xA143A8", Slot = "7")]
	public virtual void FixedTick()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xA143AC", Offset = "0xA143AC", VA = "0xA143AC", Slot = "8")]
	public virtual void LateTick()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xA143B0", Offset = "0xA143B0", VA = "0xA143B0")]
	protected GameStateBase()
	{
	}
}
[Token(Token = "0x2000043")]
public abstract class StateBase<T>
{
	[Token(Token = "0x6000128")]
	public abstract void Enter();

	[Token(Token = "0x6000129")]
	public abstract T Tick();

	[Token(Token = "0x600012A")]
	public virtual void Exit()
	{
	}

	[Token(Token = "0x600012B")]
	protected StateBase()
	{
	}
}
[Token(Token = "0x2000044")]
public enum LevelEditorStateType
{
	[Token(Token = "0x4000190")]
	Editing,
	[Token(Token = "0x4000191")]
	Menu,
	[Token(Token = "0x4000192")]
	ManageMenu,
	[Token(Token = "0x4000193")]
	SaveMenu,
	[Token(Token = "0x4000194")]
	Recovery,
	[Token(Token = "0x4000195")]
	WaitForPreviewDespawn,
	[Token(Token = "0x4000196")]
	WaitForPreviewSpawn,
	[Token(Token = "0x4000197")]
	WaitForLoadEnvironment,
	[Token(Token = "0x4000198")]
	TransitionToWorldSelect,
	[Token(Token = "0x4000199")]
	TransitionToTryPlay,
	[Token(Token = "0x400019A")]
	TransitionToEditing,
	[Token(Token = "0x400019B")]
	TransitionToManageMenu,
	[Token(Token = "0x400019C")]
	TransitionToSaveMenu,
	[Token(Token = "0x400019D")]
	TransitionToUploadTrial,
	[Token(Token = "0x400019E")]
	TransitionToBuildLevelsPlay,
	[Token(Token = "0x400019F")]
	TransitionToFavoriteLevelsPlay,
	[Token(Token = "0x40001A0")]
	TransitionToError,
	[Token(Token = "0x40001A1")]
	TransitionToDiscoveryLevelsPlay,
	[Token(Token = "0x40001A2")]
	TransitionToSearchLevelPlay,
	[Token(Token = "0x40001A3")]
	TransitionToUserProfilePlay,
	[Token(Token = "0x40001A4")]
	TransitionToPreviousPlay
}
[Token(Token = "0x2000045")]
public abstract class LevelEditorStateBase : StateBase<LevelEditorStateType>
{
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x9FF7B8", Offset = "0x9FF7B8", VA = "0x9FF7B8")]
	protected LevelEditorStateBase()
	{
	}
}
[Token(Token = "0x2000046")]
public sealed class LevelEditorState : GameStateBase
{
	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly IntroComponent intro;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly Func<WorldType, IEnumerator> loadEnvironment;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly LevelEditorComponent levelEditor;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly TensionHand tensionHand;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly LevelEditorVRController vrControllerLevelEditor;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly Toolbox toolbox;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly SplitMenu manageLevels;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly LevelBuildingHandler levelBuildingHandler;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly PlayerConstraintsHandler playerConstraintsHandler;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly RecoveryMenu recoveryMenu;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly UiMenuHandlerBase<RecoveryMenuButton, RecoveryMenuButtonType> recoveryMenuHandler;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly MenuSettings menuSettings;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly LevelEditorVRControllerHandler levelEditorVRControllerHandler;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly SplitMenuHandler[] splitMenuHandlers;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly MenuContext menuContext;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly LevelFactory levelFactory;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private uint saveIndex;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private GameObject editingPlatform;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Transform levelTransform;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private int yStep;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly LevelEditorStateBase[] states;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private LevelEditorStateType state;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private LevelEditorStateType prevState;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool isAtMenuPosition;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private GameState nextGameState;

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xA01CC4", Offset = "0xA01CC4", VA = "0xA01CC4")]
	public LevelEditorState(GameStateData gameStateData, NetworkHandler networkHandler, WorldContext worldContext, PalazzoTriggers palazzoTriggers, InputHandler inputHandler, TeleportationHandler teleportationHandler, IntroComponent intro, MonoBehaviour monoBehaviour, LevelEditorComponent levelEditor, Func<WorldType, IEnumerator> loadEnvironment, ARTransforms arTransforms, TrajectoryHandler trajectoryHandler, SplitMenu[] splitMenus, MenuSettings menuSettings, LevelContext levelContext, PalazzoComponentSlingshot slingshot, TensionHand tensionHand, PalazzoComponentBirdPlatform birdPlatform, LevelEditorVRController vrControllerLevelEditor, Toolbox toolbox, FadeHandler fadeHandler, ToolboxSettings toolboxSettings, LevelEditorContext levelEditorContext, LevelEditorPlayContext levelEditorPlayContext, LevelEditorSettings levelEditorSettings, LevelFactory levelFactory, PlayerConstraintsHandler playerConstraintsHandler, RecoveryMenu recoveryMenu, CreateUserMenu createUserMenu, ReportMenu reportMenu, ErrorMenu errorMenu, CreateUserSettings createUserSettings, MenuContext menuContext)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xA021B0", Offset = "0xA021B0", VA = "0xA021B0", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xA023E4", Offset = "0xA023E4", VA = "0xA023E4", Slot = "7")]
	public override void FixedTick()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xA02428", Offset = "0xA02428", VA = "0xA02428", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xA039A8", Offset = "0xA039A8", VA = "0xA039A8", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xA03AB8", Offset = "0xA03AB8", VA = "0xA03AB8")]
	private void OnRecoveryMenuButtonClick(int buttonTypeInt)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xA038A8", Offset = "0xA038A8", VA = "0xA038A8")]
	private void InstantDespawnPreview()
	{
	}
}
[Token(Token = "0x2000047")]
public sealed class LoseState : GameStateBase
{
	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly BirdsRemainingHandler birdsRemainingHandler;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LoseScreenHandler[] loseScreenHandlers;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly HealthBarHandler healthBarHandler;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly EnvironmentPhysicsHandler environmentPhysicsHandler;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isCustomLevel;

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xA0E30C", Offset = "0xA0E30C", VA = "0xA0E30C")]
	public LoseState(GameStateData gameStateData, LoseScreen[] loseScreens, BirdsRemainingHandler birdsRemainingHandler, HealthBarHandler healthBarHandler, LevelContext levelContext, LevelEditorContext levelEditorContext, LevelEditorPlayContext levelEditorPlayContext, EnvironmentPhysicsHandler environmentPhysicsHandler, WorldContext worldContext, ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, PalazzoGameDataPersistent gameDataPersistent, MenuSettings menuSettings, PalazzoWorld[] worldPrefabs, MonoBehaviour monoBehaviour, Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen, NetworkHandler networkHandler, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xA0E5F0", Offset = "0xA0E5F0", VA = "0xA0E5F0", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xA0E9D8", Offset = "0xA0E9D8", VA = "0xA0E9D8", Slot = "7")]
	public override void FixedTick()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xA0EA08", Offset = "0xA0EA08", VA = "0xA0EA08", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xA0EA80", Offset = "0xA0EA80", VA = "0xA0EA80", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xA0EB34", Offset = "0xA0EB34", VA = "0xA0EB34")]
	public void PositionGui()
	{
	}
}
[Token(Token = "0x2000048")]
public sealed class NoEntitlementState : GameStateBase
{
	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameObject noEntitlementScreen;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly MenuSettings menuSettings;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float showNoEntitlementTimer;

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x95FAC0", Offset = "0x95FAC0", VA = "0x95FAC0")]
	public NoEntitlementState(GameObject noEntitlementScreen, MenuSettings menuSettings)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x95FB00", Offset = "0x95FB00", VA = "0x95FB00", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x95FC64", Offset = "0x95FC64", VA = "0x95FC64", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}
}
[Token(Token = "0x2000049")]
public sealed class OutroState : GameStateBase
{
	[Token(Token = "0x20001ED")]
	private enum State
	{
		[Token(Token = "0x4000D72")]
		Setup,
		[Token(Token = "0x4000D73")]
		WaitForFade,
		[Token(Token = "0x4000D74")]
		PlayOutro
	}

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly OutroHandler outroHandler;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly OutroComponent outro;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Func<IEnumerator> despawnLevel;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private State state;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private State prevState;

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x964704", Offset = "0x964704", VA = "0x964704")]
	public OutroState(OutroHandler outroHandler, MonoBehaviour monoBehaviour, LevelContext levelContext, TeleportationHandler teleportationHandler, PalazzoTriggers palazzoTriggers, OutroComponent outro, Func<IEnumerator> despawnLevel, FadeHandler fadeHandler)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x964780", Offset = "0x964780", VA = "0x964780", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x964788", Offset = "0x964788", VA = "0x964788", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}
}
[Token(Token = "0x200004A")]
public sealed class PauseState : GameStateBase
{
	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly TrajectoryMarkerSettings trajectoryMarkerSettings;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PauseScreenHandler[] pauseScreenHandlers;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly EnvironmentPhysicsHandler environmentPhysicsHandler;

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x9C4B50", Offset = "0x9C4B50", VA = "0x9C4B50")]
	public PauseState(GameStateData gameStateData, PauseScreen[] pauseScreens, WorldContext worldContext, TrajectoryMarkerSettings trajectoryMarkerSettings, ARTransforms arTransforms, InputHandler inputHandler, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, PalazzoTriggers palazzoTriggers, PalazzoGameDataPersistent gameDataPersistent, MonoBehaviour monoBehaviour, LevelContext levelContext, PalazzoWorld[] worldPrefabs, Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen, LevelEditorPlayContext levelEditorPlayContext, NetworkHandler networkHandler, CreateUserSettings createUserSettings, EnvironmentPhysicsHandler environmentPhysicsHandler)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x9C4DF0", Offset = "0x9C4DF0", VA = "0x9C4DF0", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x9C4EBC", Offset = "0x9C4EBC", VA = "0x9C4EBC", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x9C4FE0", Offset = "0x9C4FE0", VA = "0x9C4FE0", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x9C5058", Offset = "0x9C5058", VA = "0x9C5058", Slot = "7")]
	public override void FixedTick()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x9C5088", Offset = "0x9C5088", VA = "0x9C5088")]
	public void PositionGui()
	{
	}
}
[Token(Token = "0x200004B")]
public sealed class PlaceLevelState : GameStateBase
{
	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly WorldTracker worldTracker;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Action<Vector3> onPlaceLevel;

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x9C87EC", Offset = "0x9C87EC", VA = "0x9C87EC")]
	public PlaceLevelState(ARTransforms arTransforms, WorldTracker worldTracker, Action<Vector3> onPlaceLevel)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x9C882C", Offset = "0x9C882C", VA = "0x9C882C", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x9C8978", Offset = "0x9C8978", VA = "0x9C8978", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}
}
[Token(Token = "0x200004C")]
public sealed class PlayState : GameStateBase
{
	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly TutorialHandler tutorialHandler;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly TeleportAimHandler teleportAimHandler;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly BirdSpecialAbilityHandler birdSpecialAbilityHandler;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly SlingshotLoader slingshotLoader;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly SlingshotAimHandler slingshotAimHandler;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly TelePointHandler telePointHandler;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly BirdsRemainingHandler birdsRemainingHandler;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly HealthBarHandler healthBarHandler;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly DamageHandler damageHandler;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly PigEmotionalStateHandler pigEmotionalStateHandler;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly LevelFactory levelFactory;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly CharacterLookAtHandler characterLookAtHandler;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly PlayStateSettings playStateSettings;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly LevelEditorVRController levelEditorVrController;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly EnvironmentPhysicsHandler environmentPhysicsHandler;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float noPigsTimer;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float noBirdsTimer;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool waitingOnDespawn;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private GameState nextGameState;

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x9C8B9C", Offset = "0x9C8B9C", VA = "0x9C8B9C")]
	public PlayState(GameStateData gameStateData, InputHandler inputHandler, LevelContext levelContext, TrajectoryHandler trajectoryHandler, TutorialHandler tutorialHandler, TeleportationHandler teleportationHandler, BirdSpecialAbilityHandler birdSpecialAbilityHandler, SlingshotLoader slingshotLoader, SlingshotAimHandler slingshotAimHandler, TeleportAimHandler teleportAimHandler, TelePointHandler telePointHandler, BirdsRemainingHandler birdsRemainingHandler, HealthBarHandler healthBarHandler, DamageHandler damageHandler, PigEmotionalStateHandler pigEmotionalStateHandler, LevelFactory levelFactory, ARTransforms arTransforms, PalazzoComponentSlingshot slingshot, CharacterLookAtHandler characterLookAtHandler, PlayStateSettings playStateSettings, EnvironmentPhysicsHandler environmentPhysicsHandler, PalazzoTriggers palazzoTriggers)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x9C8CCC", Offset = "0x9C8CCC", VA = "0x9C8CCC", Slot = "7")]
	public override void FixedTick()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x9C8D78", Offset = "0x9C8D78", VA = "0x9C8D78", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x9C8E74", Offset = "0x9C8E74", VA = "0x9C8E74", Slot = "8")]
	public override void LateTick()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x9C8EC4", Offset = "0x9C8EC4", VA = "0x9C8EC4", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x9C94F0", Offset = "0x9C94F0", VA = "0x9C94F0", Slot = "6")]
	public override void Exit()
	{
	}
}
[Token(Token = "0x200004D")]
public sealed class PrivacyState : GameStateBase
{
	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly UiMenuHandlerBase<PrivacyButton, PrivacyButtonType> menuHandler;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PrivacyMenu privacyMenu;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly ButtonHandler<PrivacyButton> buttonHandler;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action OnAccept;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly IntroComponent introComponent;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameState nextGameState;

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x9CA21C", Offset = "0x9CA21C", VA = "0x9CA21C")]
	public PrivacyState(ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, PrivacyMenu privacyMenu, MenuSettings menuSettings, PalazzoGameDataPersistent gameDataPersistent, IntroComponent introComponent, WorldContext worldContext)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x9CA354", Offset = "0x9CA354", VA = "0x9CA354", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x9CA47C", Offset = "0x9CA47C", VA = "0x9CA47C", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x9CA4E4", Offset = "0x9CA4E4", VA = "0x9CA4E4")]
	private void OnClickButton(int buttonIndex)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x9CA6EC", Offset = "0x9CA6EC", VA = "0x9CA6EC", Slot = "6")]
	public override void Exit()
	{
	}
}
[Token(Token = "0x200004E")]
public class ScoreboardState : GameStateBase
{
	[Token(Token = "0x20001EE")]
	private enum State
	{
		[Token(Token = "0x4000D76")]
		Scoreboard,
		[Token(Token = "0x4000D77")]
		RatingScreen
	}

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly BirdsRemainingHandler birdsRemainingHandler;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly EnvironmentPhysicsHandler environmentPhysicsHandler;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PlayMenuHandlerBase[] menuHandlers;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly RatingScreenHandler ratingScreenHandler;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private State state;

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x9E4044", Offset = "0x9E4044", VA = "0x9E4044")]
	public ScoreboardState(GameStateData gameStateData, PlayMenuBase<ScoreboardButton>[] scoreboards, RatingScreen ratingScreen, BirdsRemainingHandler birdsRemainingHandler, EnvironmentPhysicsHandler environmentPhysicsHandler, ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, ScoreboardContext scoreboardContext, ScoreboardSettings scoreboardSettings, WorldContext worldContext, MenuSettings menuSettings, PalazzoWorld[] worldPrefabs, MonoBehaviour monoBehaviour, Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen, NetworkHandler networkHandler, LevelEditorPlayContext levelEditorPlayContext, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x9E44D4", Offset = "0x9E44D4", VA = "0x9E44D4", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x9E45E8", Offset = "0x9E45E8", VA = "0x9E45E8", Slot = "7")]
	public override void FixedTick()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x9E4618", Offset = "0x9E4618", VA = "0x9E4618", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x9E46C0", Offset = "0x9E46C0", VA = "0x9E46C0", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x9E476C", Offset = "0x9E476C", VA = "0x9E476C")]
	public void PositionGui()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x9E4810", Offset = "0x9E4810", VA = "0x9E4810")]
	private void OnRatingScreenButtonClicked()
	{
	}
}
[Token(Token = "0x200004F")]
public sealed class SelectLevelState : GameStateBase
{
	[Token(Token = "0x20001EF")]
	private enum State
	{
		[Token(Token = "0x4000D79")]
		WaitForInput,
		[Token(Token = "0x4000D7A")]
		TransitionOutToSpawnLevel,
		[Token(Token = "0x4000D7B")]
		TransitionOutToWorldSelect,
		[Token(Token = "0x4000D7C")]
		TeleportToStart
	}

	[Token(Token = "0x4000215")]
	private const float TRANSITION_OUT_SECONDS = 0.5f;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly MenuContext menuContext;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelSelect levelSelect;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<string> levelSelectGuids;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly PalazzoWorld[] worldPrefabs;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly PalazzoComponentLevel[] levelPrefabs;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly LevelSelectSettings levelSelectSettings;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly UiMenuHandlerBase<LevelButton, LevelSelectButtonType> menuHandler;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly LevelButton[] buttons;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly int numberOfLevels;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int selectedLevelIndex;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private State state;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private State prevState;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GameState nextGameState;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float transitionOutTimer;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3? startPosition;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float? startRotation;

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x9E485C", Offset = "0x9E485C", VA = "0x9E485C")]
	public SelectLevelState(MenuContext menuContext, GameStateData gameStateData, ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, LevelContext levelContext, LevelSelect levelSelect, List<string> levelSelectGuids, PalazzoGameDataPersistent gameDataPersistent, WorldContext worldContext, MenuSettings menuSettings, PalazzoWorld[] worldPrefabs, PalazzoComponentLevel[] levelPrefabs, LevelSelectSettings levelSelectSettings, TeleportationHandler teleportationHandler, FadeHandler fadeHandler, PalazzoComponentBirdPlatform birdPlatform)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x9E4A70", Offset = "0x9E4A70", VA = "0x9E4A70", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x9E4B14", Offset = "0x9E4B14", VA = "0x9E4B14", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x9E4BD4", Offset = "0x9E4BD4", VA = "0x9E4BD4", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x9E5A68", Offset = "0x9E5A68", VA = "0x9E5A68")]
	private void OnClickLevelButton(int buttonIndex)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x9E5CC8", Offset = "0x9E5CC8", VA = "0x9E5CC8")]
	private void OnHoverLevelButton(int buttonIndex)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x9E5C0C", Offset = "0x9E5C0C", VA = "0x9E5C0C")]
	private int ButtonIndexToLevelIndex(int buttonIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x9E5208", Offset = "0x9E5208", VA = "0x9E5208")]
	private void RefreshLevelButtons()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x9E575C", Offset = "0x9E575C", VA = "0x9E575C")]
	private void SetMaterials()
	{
	}
}
[Token(Token = "0x2000050")]
public sealed class SelectWorldState : GameStateBase
{
	[Token(Token = "0x20001F0")]
	private enum State
	{
		[Token(Token = "0x4000D7E")]
		WaitForInputModeSelect,
		[Token(Token = "0x4000D7F")]
		WaitForInputWorldSelect,
		[Token(Token = "0x4000D80")]
		TeleportToStartPosition,
		[Token(Token = "0x4000D81")]
		LoadEnvironment,
		[Token(Token = "0x4000D82")]
		TransitionToQuickPlay,
		[Token(Token = "0x4000D83")]
		TransitionToGameState,
		[Token(Token = "0x4000D84")]
		TransitionToProfile,
		[Token(Token = "0x4000D85")]
		ShowWarning
	}

	[Serializable]
	[Token(Token = "0x20001F1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7671B4", Offset = "0x7671B4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000D86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000D87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<int> <>9__47_0;

		[Token(Token = "0x4000D88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<int> <>9__47_1;

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x9E9398", Offset = "0x9E9398", VA = "0x9E9398")]
		public <>c()
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x9E93A0", Offset = "0x9E93A0", VA = "0x9E93A0")]
		internal void <.ctor>b__47_0(int i)
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x9E93A4", Offset = "0x9E93A4", VA = "0x9E93A4")]
		internal void <.ctor>b__47_1(int i)
		{
		}
	}

	[Token(Token = "0x400022E")]
	private const float TRANSITION_OUT_SECONDS = 0.5f;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly MenuContext menuContext;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly WorldSelectMenu worldSelectMenu;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly WorldSelectSubMenu modeMenu;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly WorldSelectSubMenu worldMenus;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelSelect levelSelect;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly PalazzoWorld[] worldPrefabs;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly List<string> levelGuids;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly WorldSelectButton spookyModeButton;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly IntroComponent intro;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Func<WorldType, IEnumerator> loadEnvironment;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly GameObject spookyRain;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly AchievementHandler achievementHandler;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly UiMenuHandlerBase<WorldSelectButton, WorldSelectButtonType> modeMenuHandler;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly UiMenuHandlerBase<WorldSelectButton, WorldSelectButtonType> worldMenusHandler;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly UiMenuHandlerBase<WorldSelectButton, WorldSelectButtonType> warningMenuHandler;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000248")]
	private const string PRIVACY_POLICY_URL = "http://www.resolutiongames.com";

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private State state;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private State prevState;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int worldIndex;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float transitionTimer;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly WorldSelectButton[] worldButtons;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool shouldUnlock;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
	private bool hasFinishedPlayingAnimation;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float unlockTimer;

	[Token(Token = "0x4000251")]
	private const float UNLOCK_DELAY = 1f;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private WorldSelectButton buttonToUnlock;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Vector3? startPosition;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private float? startRotation;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private bool isInModeSelect;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Future<ServerLevelMetaData> quickplayLevelFuture;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Future<User> getUserDataFuture;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private bool hasShownBanWarning;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private int finishedLevelCount;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private GameState nextGameState;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private GameState postTransitionState;

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x9E5F18", Offset = "0x9E5F18", VA = "0x9E5F18")]
	public SelectWorldState(MenuContext menuContext, GameStateData gameStateData, ARTransforms arTransforms, WorldSelectMenu worldSelectMenu, LevelSelect levelSelect, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, PalazzoWorld[] worldPrefabs, PalazzoGameDataPersistent gameDataPersistent, WorldContext worldContext, MenuSettings menuSettings, List<string> levelGuids, TeleportationHandler teleportationHandler, FadeHandler fadeHandler, IntroComponent intro, MonoBehaviour monoBehaviour, Func<WorldType, IEnumerator> loadEnvironment, GameObject spookyRain, AchievementHandler achievementHandler, NetworkHandler networkHandler, LevelEditorPlayContext levelEditorPlayContext, LevelContext levelContext)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x9E6A84", Offset = "0x9E6A84", VA = "0x9E6A84")]
	private void UpdateButtons()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x9E6E1C", Offset = "0x9E6E1C", VA = "0x9E6E1C", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x9E713C", Offset = "0x9E713C", VA = "0x9E713C", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x9E71DC", Offset = "0x9E71DC", VA = "0x9E71DC", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x9E8A48", Offset = "0x9E8A48", VA = "0x9E8A48")]
	private void OnClickWorldSelectButton(int buttonIndex)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x9E6880", Offset = "0x9E6880", VA = "0x9E6880")]
	private bool IsNightmareModeUnlocked()
	{
		return default(bool);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x9E86EC", Offset = "0x9E86EC", VA = "0x9E86EC")]
	private void UnlockSpookyIfNeeded()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x9E84A0", Offset = "0x9E84A0", VA = "0x9E84A0")]
	private void UnlockWorldButtonsIfNeeded()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x9E81E8", Offset = "0x9E81E8", VA = "0x9E81E8")]
	private void UpdateWorldButtonStarText()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x9E8C9C", Offset = "0x9E8C9C", VA = "0x9E8C9C")]
	private void UnlockButton(WorldSelectButton button)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x9E8CB4", Offset = "0x9E8CB4", VA = "0x9E8CB4")]
	private void OnClickModeButton(int buttonIndex)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x9E92A0", Offset = "0x9E92A0", VA = "0x9E92A0")]
	private void OnClickWarningScreenButton(int buttonIndex)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x9E8D98", Offset = "0x9E8D98", VA = "0x9E8D98")]
	private void SelectMode(WorldSelectButtonType type)
	{
	}
}
[Token(Token = "0x2000051")]
public sealed class SettingsState : GameStateBase
{
	[Token(Token = "0x20001F2")]
	private enum ConfirmType
	{
		[Token(Token = "0x4000D8A")]
		Quit,
		[Token(Token = "0x4000D8B")]
		Reset
	}

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly SettingsMenu settingsMenu;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly AudioMixerGroup musicAudioGroup;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly AudioMixerGroup soundAudioGroup;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly SettingsMenuButton[] buttons;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly UiMenuHandlerBase<SettingsMenuButton, SettingsMenuButtonType> menuHandler;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly float defaultMusicVolume;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private readonly float defaultSoundVolume;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly string confirmQuitId;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly string confirmResetId;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly string resetFeedbackId;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly string privacyFeedbackId;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly string termsFeedbackId;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool init;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private ConfirmType confirmType;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameState nextGameState;

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x9E985C", Offset = "0x9E985C", VA = "0x9E985C")]
	public SettingsState(ARTransforms arTransforms, SettingsMenu settingsMenu, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, AudioMixerGroup musicAudioGroup, AudioMixerGroup soundAudioGroup, PalazzoGameDataPersistent gameDataPersistent, MenuSettings menuSettings, WorldContext worldContext)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x9EA25C", Offset = "0x9EA25C", VA = "0x9EA25C", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x9EA340", Offset = "0x9EA340", VA = "0x9EA340", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x9EA3A8", Offset = "0x9EA3A8", VA = "0x9EA3A8", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x9EA4C8", Offset = "0x9EA4C8", VA = "0x9EA4C8")]
	private void OnClickButton(int buttonIndex)
	{
	}
}
[Token(Token = "0x2000052")]
public sealed class SpawnLevelState : GameStateBase
{
	[Token(Token = "0x20001F3")]
	private enum State
	{
		[Token(Token = "0x4000D8D")]
		LoadEnvironment,
		[Token(Token = "0x4000D8E")]
		WaitOnCutscene,
		[Token(Token = "0x4000D8F")]
		WaitOnSpawnEffect,
		[Token(Token = "0x4000D90")]
		FadeAfterCutScene,
		[Token(Token = "0x4000D91")]
		StartLevel,
		[Token(Token = "0x4000D92")]
		TeleportToStartPosition
	}

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly TutorialHandler tutorialHandler;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly IntroComponent intro;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly BirdsRemainingHandler birdsRemainingHandler;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly HealthBarHandler healthBarHandler;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly CutsceneHandler cutsceneHandler;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly PalazzoComponentLevel[] levelPrefabs;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly LevelFactory levelFactory;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OutroComponent outro;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Func<WorldType, IEnumerator> loadEnvironment;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly EnvironmentPhysicsHandler environmentPhysicsHandler;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly CutsceneComponent[] cutscenes;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private State state;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private State prevState;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private GameState nextGameState;

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x9EFE28", Offset = "0x9EFE28", VA = "0x9EFE28")]
	public SpawnLevelState(GameStateData gameStateData, TutorialHandler tutorialHandler, IntroComponent intro, PalazzoTriggers palazzoTriggers, BirdsRemainingHandler birdsRemainingHandler, HealthBarHandler healthBarHandler, LevelContext levelContext, CutsceneHandler cutsceneHandler, TeleportationHandler teleportationHandler, FadeHandler fadeHandler, PalazzoComponentLevel[] levelPrefabs, LevelFactory levelFactory, OutroComponent outro, PalazzoComponentBirdPlatform birdPlatform, WorldContext worldContext, MonoBehaviour monoBehaviour, Func<WorldType, IEnumerator> loadEnvironment, LevelEditorPlayContext levelEditorPlayContext, EnvironmentPhysicsHandler environmentPhysicsHandler, CutsceneComponent[] cutscenes)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x9EFF40", Offset = "0x9EFF40", VA = "0x9EFF40", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x9F01E0", Offset = "0x9F01E0", VA = "0x9F01E0", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x9F070C", Offset = "0x9F070C", VA = "0x9F070C", Slot = "7")]
	public override void FixedTick()
	{
	}
}
[Token(Token = "0x2000053")]
public sealed class StartState : GameStateBase
{
	[Token(Token = "0x20001F4")]
	private enum State
	{
		[Token(Token = "0x4000D94")]
		Init,
		[Token(Token = "0x4000D95")]
		LoadEnvironment,
		[Token(Token = "0x4000D96")]
		Start
	}

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly Func<WorldType, IEnumerator> loadEnvironment;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly TensionHand tensionHand;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly UiMenuHandlerBase<PalazzoButton, StartButtonType> menuHandler;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly IntroComponent introComponent;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly AmbientAudioComponent ambientAudioComponent;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool gameHasStarted;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private State state;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private State prevState;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private GameState nextGameState;

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x9F169C", Offset = "0x9F169C", VA = "0x9F169C")]
	public StartState(IntroComponent introComponent, StartScreen startScreen, ARTransforms arTransforms, InputHandler inputHandler, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, PalazzoGameDataPersistent gameDataPersistent, FadeHandler fadeHandler, AmbientAudioComponent ambientAudioComponent, PalazzoTriggers palazzoTriggers, Func<WorldType, IEnumerator> loadEnvironment, MonoBehaviour monoBehaviour, WorldContext worldContext, TeleportationHandler teleportationHandler, PalazzoComponentSlingshot slingshot, TensionHand tensionHand)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x9F1850", Offset = "0x9F1850", VA = "0x9F1850", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x9F1904", Offset = "0x9F1904", VA = "0x9F1904", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x9F1B9C", Offset = "0x9F1B9C", VA = "0x9F1B9C")]
	private void OnButtonClicked(int buttonIndex)
	{
	}
}
[Token(Token = "0x2000054")]
public class WinState : GameStateBase
{
	[Token(Token = "0x20001F5")]
	private enum LevelCountInWorld
	{
		[Token(Token = "0x4000D98")]
		SandyBeach = 12,
		[Token(Token = "0x4000D99")]
		RockyClimb = 25,
		[Token(Token = "0x4000D9A")]
		SnowySlopes = 38,
		[Token(Token = "0x4000D9B")]
		PartyPeak = 51,
		[Token(Token = "0x4000D9C")]
		MalibooBeach = 64,
		[Token(Token = "0x4000D9D")]
		CreepyClimb = 77,
		[Token(Token = "0x4000D9E")]
		SlimeySlopes = 90,
		[Token(Token = "0x4000D9F")]
		TerrorPeak = 103
	}

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly SlingshotAimHandler slingshotAimHandler;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly SlingshotLoader slingshotLoader;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly ScoreboardContext scoreboardContext;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly CutsceneHandler cutsceneHandler;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly PalazzoComponentLevel[] levelPrefabs;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly AchievementHandler achievementHandler;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly EnvironmentPhysicsHandler environmentPhysicsHandler;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x40002A5")]
	private const int NUM_LEVEL_STARS_PER_WORLD = 39;

	[Token(Token = "0x40002A6")]
	private const int NUM_TOTAL_LEVEL_STARS_VACATION = 156;

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x10F6664", Offset = "0x10F6664", VA = "0x10F6664")]
	public WinState(GameStateData gameStateData, LevelContext levelContext, LevelEditorContext levelEditorContext, InputHandler inputHandler, SlingshotAimHandler slingshotAimHandler, SlingshotLoader slingshotLoader, PalazzoTriggers palazzoTriggers, ScoreboardContext scoreboardContext, CutsceneHandler cutsceneHandler, PalazzoGameDataPersistent gameDataPersistent, PalazzoComponentLevel[] levelPrefabs, AchievementHandler achievementHandler, EnvironmentPhysicsHandler environmentPhysicsHandler, LevelEditorPlayContext levelEditorPlayContext, NetworkHandler networkHandler)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x10F6730", Offset = "0x10F6730", VA = "0x10F6730", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x10F6734", Offset = "0x10F6734", VA = "0x10F6734", Slot = "7")]
	public override void FixedTick()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x10F6764", Offset = "0x10F6764", VA = "0x10F6764", Slot = "5")]
	public override GameState Tick()
	{
		return default(GameState);
	}
}
[Token(Token = "0x2000055")]
public sealed class HealthBarHandler
{
	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xA14688", Offset = "0xA14688", VA = "0xA14688")]
	public HealthBarHandler(ARTransforms arTransforms, LevelContext levelContext, InputHandler inputHandler)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xA146C8", Offset = "0xA146C8", VA = "0xA146C8")]
	public void Tick()
	{
	}
}
[Token(Token = "0x2000056")]
public sealed class HistoryHandler
{
	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly BuildingBlockFactory buildingBlockFactory;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Stack<IHistoryEvent> undoStack;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Stack<IHistoryEvent> redoStack;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Dictionary<int, LevelBuildingBlock> blockLookup;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Stack<int> idStack;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767664", Offset = "0x767664")]
	private bool <IsRecording>k__BackingField;

	[Token(Token = "0x17000008")]
	public bool IsRecording
	{
		[Token(Token = "0x6000185")]
		[Address(RVA = "0xA14A28", Offset = "0xA14A28", VA = "0xA14A28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A24C", Offset = "0x76A24C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000186")]
		[Address(RVA = "0xA14A30", Offset = "0xA14A30", VA = "0xA14A30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A25C", Offset = "0x76A25C")]
		set
		{
		}
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xA14A3C", Offset = "0xA14A3C", VA = "0xA14A3C")]
	public HistoryHandler(LevelEditorContext levelEditorContext, BuildingBlockFactory buildingBlockFactory)
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xA14CAC", Offset = "0xA14CAC", VA = "0xA14CAC")]
	public IHistoryEvent Do(IHistoryEvent historyEvent, bool clearRedo = true)
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xA159BC", Offset = "0xA159BC", VA = "0xA159BC")]
	public void Undo()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xA160E0", Offset = "0xA160E0", VA = "0xA160E0")]
	public void Redo()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xA16160", Offset = "0xA16160", VA = "0xA16160")]
	public IHistoryEvent PeekRedo()
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xA16010", Offset = "0xA16010", VA = "0xA16010")]
	public IHistoryEvent PeekUndo()
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xA161CC", Offset = "0xA161CC", VA = "0xA161CC")]
	public static bool IsUndoEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xA16244", Offset = "0xA16244", VA = "0xA16244")]
	public static bool IsRedoEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xA162BC", Offset = "0xA162BC", VA = "0xA162BC")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xA14B54", Offset = "0xA14B54", VA = "0xA14B54")]
	private void RefreshIdStack([Optional] ICollection<int> excludedIds)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xA16354", Offset = "0xA16354", VA = "0xA16354")]
	public void BuildLevel(List<BlockData> blocks)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xA165FC", Offset = "0xA165FC", VA = "0xA165FC")]
	public void RedoHistory()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xA15598", Offset = "0xA15598", VA = "0xA15598")]
	public LevelBuildingBlock GetLevelBuildingBlock(int id)
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xA15360", Offset = "0xA15360", VA = "0xA15360")]
	private LevelBuildingBlock CreateLevelBuildingBlock(int prefabId, [Optional] int? id)
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xA1563C", Offset = "0xA1563C", VA = "0xA1563C")]
	private void DestroyLevelBuildingBlock(LevelBuildingBlock block)
	{
	}
}
[Token(Token = "0x2000057")]
public interface IHistoryEvent
{
}
[Token(Token = "0x2000058")]
public struct MoveEvent : IHistoryEvent
{
	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int blockId;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Vector3 newPosition;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Quaternion newRotation;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 oldPosition;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Quaternion oldRotation;

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x7D81DC", Offset = "0x7D81DC", VA = "0x7D81DC")]
	public MoveEvent(int blockId, Vector3 oldPosition, Quaternion oldRotation, Vector3 newPosition, Quaternion newRotation)
	{
	}
}
[Token(Token = "0x2000059")]
public struct SpawnEvent : IHistoryEvent
{
	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int prefabId;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Vector3 localPosition;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Quaternion localRotation;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int blockId;

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x7D8A14", Offset = "0x7D8A14", VA = "0x7D8A14")]
	public SpawnEvent(int prefabId, Vector3 localPosition, Quaternion localRotation)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x7D8A34", Offset = "0x7D8A34", VA = "0x7D8A34")]
	public SpawnEvent(BlockData data)
	{
	}
}
[Token(Token = "0x200005A")]
public struct DespawnEvent : IHistoryEvent
{
	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int blockId;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int prefabId;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Vector3 localPosition;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Quaternion localRotation;

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x7D84B4", Offset = "0x7D84B4", VA = "0x7D84B4")]
	public DespawnEvent(int blockId, Vector3 oldPosition, Quaternion oldRotation)
	{
	}
}
[Token(Token = "0x200005B")]
public struct ClearLevelEvent : IHistoryEvent
{
	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int blockCount;
}
[Token(Token = "0x200005C")]
public abstract class ImpactQueue<T> where T : struct
{
	[Token(Token = "0x40002BF")]
	private const double INV_LOG2 = 1.44269504088896;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected T[] buffer;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int maxCapacity;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int capacity;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int size;

	[Token(Token = "0x17000009")]
	public int Size
	{
		[Token(Token = "0x600019A")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000A")]
	public T[] Buffer
	{
		[Token(Token = "0x600019B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600019C")]
	protected ImpactQueue(int capacity, int maxCapacity)
	{
	}

	[Token(Token = "0x600019D")]
	private void IncreaseCapacity(int n)
	{
	}

	[Token(Token = "0x600019E")]
	protected int Allocate()
	{
		return default(int);
	}

	[Token(Token = "0x600019F")]
	public void Clear()
	{
	}
}
[Token(Token = "0x200005D")]
public sealed class BirdImpactQueue : ImpactQueue<BirdImpactQueue.Data>
{
	[Token(Token = "0x20001F6")]
	public struct Data
	{
		[Token(Token = "0x4000DA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PalazzoComponentBird bird;

		[Token(Token = "0x4000DA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public BlockType hitBlockType;

		[Token(Token = "0x4000DA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int impactType;

		[Token(Token = "0x4000DA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float impactMagnitude;
	}

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Dictionary<int, WorldImpactComponent> colliderWorldImpactLookup;

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x99C964", Offset = "0x99C964", VA = "0x99C964")]
	public BirdImpactQueue(int capacity, Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup, Dictionary<int, WorldImpactComponent> colliderWorldImpactLookup)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x99C9E0", Offset = "0x99C9E0", VA = "0x99C9E0")]
	public void Enqueue(PalazzoComponentBird dst, Collision collision)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x99CCF8", Offset = "0x99CCF8", VA = "0x99CCF8")]
	public void Enqueue(PalazzoComponentBird dst, Collider collider)
	{
	}
}
[Token(Token = "0x200005E")]
public sealed class DamageQueue : ImpactQueue<DamageQueue.Data>
{
	[Token(Token = "0x20001F7")]
	public struct Data
	{
		[Token(Token = "0x4000DA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DamageComponent damageComponent;

		[Token(Token = "0x4000DA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int damageType;

		[Token(Token = "0x4000DA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float damageMagnitude;

		[Token(Token = "0x4000DA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 impactPosition;
	}

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Dictionary<int, WorldImpactComponent> colliderWorldImpactLookup;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private PalazzoComponentLevelBlock otherBlock;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private WorldImpactComponent worldImpact;

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x9AE8E0", Offset = "0x9AE8E0", VA = "0x9AE8E0")]
	public DamageQueue(int capacity, Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup, Dictionary<int, WorldImpactComponent> colliderWorldImpactLookup)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x9AAB2C", Offset = "0x9AAB2C", VA = "0x9AAB2C")]
	public void Enqueue(DamageComponent dst, Collision collision)
	{
	}
}
[Token(Token = "0x200005F")]
public sealed class WorldImpactQueue : ImpactQueue<WorldImpactQueue.Data>
{
	[Token(Token = "0x20001F8")]
	public struct Data
	{
		[Token(Token = "0x4000DA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WorldImpactComponent worldImpactComponent;

		[Token(Token = "0x4000DA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PalazzoComponentLevelBlock levelBlock;

		[Token(Token = "0x4000DAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 impactPosition;
	}

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup;

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x10F86A8", Offset = "0x10F86A8", VA = "0x10F86A8")]
	public WorldImpactQueue(int capacity, Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x10F82A8", Offset = "0x10F82A8", VA = "0x10F82A8")]
	public void Enqueue(WorldImpactComponent dst, Collision collision)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x10F84E8", Offset = "0x10F84E8", VA = "0x10F84E8")]
	public void Enqueue(WorldImpactComponent dst, Collider collider)
	{
	}
}
[Token(Token = "0x2000060")]
public sealed class EffectOnImpactQueue : ImpactQueue<EffectOnImpactQueue.Data>
{
	[Token(Token = "0x20001F9")]
	public struct Data
	{
		[Token(Token = "0x4000DAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EffectOnImpactComponent effectOnImpactComponent;

		[Token(Token = "0x4000DAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Quaternion originalRotation;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x9B2760", Offset = "0x9B2760", VA = "0x9B2760")]
	public EffectOnImpactQueue(int capacity)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x9B25F4", Offset = "0x9B25F4", VA = "0x9B25F4")]
	public void Enqueue(EffectOnImpactComponent effectOnImpactComponent)
	{
	}
}
[Token(Token = "0x2000061")]
public sealed class WindVortexImpactQueue : ImpactQueue<WindVortexImpactQueue.Data>
{
	[Token(Token = "0x20001FA")]
	public struct Data
	{
		[Token(Token = "0x4000DAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FanComponent fan;

		[Token(Token = "0x4000DAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WindComponent windComponent;
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x10F7D70", Offset = "0x10F7D70", VA = "0x10F7D70")]
	public WindVortexImpactQueue(int capacity)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x10F7C8C", Offset = "0x10F7C8C", VA = "0x10F7C8C")]
	public void Enqueue(WindComponent windComponent, FanComponent fan)
	{
	}
}
[Token(Token = "0x2000062")]
public enum EffectType
{
	[Token(Token = "0x40002CC")]
	OnImpact,
	[Token(Token = "0x40002CD")]
	OnBirdImpactPig,
	[Token(Token = "0x40002CE")]
	OnDamageComponentSwitchState,
	[Token(Token = "0x40002CF")]
	OnBlockScore,
	[Token(Token = "0x40002D0")]
	OnPigScore,
	[Token(Token = "0x40002D1")]
	OnLevelBlockDestroy
}
[Token(Token = "0x2000063")]
public sealed class EffectQueue : FIFOQueue<EffectQueue.Data>
{
	[Token(Token = "0x20001FB")]
	public struct Data
	{
		[Token(Token = "0x4000DAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EffectType effectType;

		[Token(Token = "0x4000DB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Vector3 impactPosition;

		[Token(Token = "0x4000DB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DamageComponent damageComponent;

		[Token(Token = "0x4000DB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PalazzoComponentLevelBlock block;

		[Token(Token = "0x4000DB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PalazzoComponentPig pig;

		[Token(Token = "0x4000DB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int score;

		[Token(Token = "0x4000DB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int scoreMultiplier;
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x9B27C4", Offset = "0x9B27C4", VA = "0x9B27C4")]
	public EffectQueue(int capacity)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x9AE7EC", Offset = "0x9AE7EC", VA = "0x9AE7EC")]
	public int Dequeue()
	{
		return default(int);
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x9ADD14", Offset = "0x9ADD14", VA = "0x9ADD14")]
	public void EnqueueOnImpact(Vector3 impactPosition, DamageComponent damageComponent)
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x9ADE4C", Offset = "0x9ADE4C", VA = "0x9ADE4C")]
	public void EnqueueOnBirdImpactPig(Vector3 impactPosition, DamageComponent damageComponent)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x9ADF88", Offset = "0x9ADF88", VA = "0x9ADF88")]
	public void EnqueueOnDamageComponentSwitchState(DamageComponent damageComponent)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x9AE06C", Offset = "0x9AE06C", VA = "0x9AE06C")]
	public void EnquequeOnBlockScore(PalazzoComponentLevelBlock block)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x9AE150", Offset = "0x9AE150", VA = "0x9AE150")]
	public void EnquequeOnPigScore(PalazzoComponentPig pig, int score, int scoreMultiplier)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x9AE2B4", Offset = "0x9AE2B4", VA = "0x9AE2B4")]
	public void EnqueueOnLevelBlockDestroy(PalazzoComponentLevelBlock block)
	{
	}
}
[Token(Token = "0x2000064")]
public abstract class FIFOQueue<T> where T : struct
{
	[Token(Token = "0x40002D2")]
	private const double INV_LOG2 = 1.44269504088896;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected T[] buffer;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int maxCapacity;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int endIndex;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int startIndex;

	[Token(Token = "0x1700000B")]
	public int Size
	{
		[Token(Token = "0x60001B4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000C")]
	public T[] Buffer
	{
		[Token(Token = "0x60001B5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000D")]
	public int capacity
	{
		[Token(Token = "0x60001B6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000E")]
	public int StartIndex
	{
		[Token(Token = "0x60001B7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000F")]
	public int EndIndex
	{
		[Token(Token = "0x60001B8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60001B9")]
	protected FIFOQueue(int capacity, int maxCapacity)
	{
	}

	[Token(Token = "0x60001BA")]
	protected int Allocate()
	{
		return default(int);
	}

	[Token(Token = "0x60001BB")]
	protected int Deallocate()
	{
		return default(int);
	}

	[Token(Token = "0x60001BC")]
	public void Clear()
	{
	}
}
[Token(Token = "0x2000065")]
public sealed class ImpactTypeData : MonoBehaviour
{
	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string soundImpactHeavy;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string soundImpactMedium;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string soundImpactLight;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ParticleEffectComponent prefabImpactFx;

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xA167D4", Offset = "0xA167D4", VA = "0xA167D4")]
	public ImpactTypeData()
	{
	}
}
[Token(Token = "0x2000066")]
public enum InputType
{
	[Token(Token = "0x40002DC")]
	MenuHand,
	[Token(Token = "0x40002DD")]
	TensionHand,
	[Token(Token = "0x40002DE")]
	SlingshotHand
}
[Token(Token = "0x2000067")]
public abstract class InputHandler
{
	[Token(Token = "0x20001FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7671C4", Offset = "0x7671C4")]
	private sealed class <>c__DisplayClass51_0
	{
		[Token(Token = "0x4000DB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public XRNode hand;

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xA182B0", Offset = "0xA182B0", VA = "0xA182B0")]
		public <>c__DisplayClass51_0()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xA185D4", Offset = "0xA185D4", VA = "0xA185D4")]
		internal bool <GetHandLocalPosition>b__0(XRNode element)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static readonly XRNode[] handLookup;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected readonly ARTransforms arTransforms;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected readonly PalazzoInputDevice inputDevice;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected readonly WorldContext worldContext;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected readonly Transform slingshotTransform;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly bool[] triggerLastState;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected bool hasFocusPrev;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected Vector3[] handPositionCache;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected Vector3[] handPostionWhileAimingCache;

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xA1684C", Offset = "0xA1684C", VA = "0xA1684C")]
	protected InputHandler(ARTransforms arTransforms, PalazzoInputDevice inputDevice, PalazzoComponentSlingshot slingshot, LevelContext levelContext, PalazzoGameDataPersistent gameDataPersistent, WorldContext worldContext)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xA16970", Offset = "0xA16970", VA = "0xA16970")]
	public void Tick()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xA1707C", Offset = "0xA1707C", VA = "0xA1707C", Slot = "4")]
	protected virtual void TickInternal()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xA17080", Offset = "0xA17080", VA = "0xA17080")]
	public void Recenter()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xA170B4", Offset = "0xA170B4", VA = "0xA170B4")]
	public void PlayHapticOnce(HapticType hapticType, InputType hand, [Optional] float? amplitude)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xA171C8", Offset = "0xA171C8", VA = "0xA171C8")]
	public void PlayHapticOnce(HapticType hapticType, XRNode hand, [Optional] float? amplitude)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xA17258", Offset = "0xA17258", VA = "0xA17258")]
	public void PlayHapticUntilStop(HapticType hapticType, InputType hand, [Optional] float? amplitude)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xA1736C", Offset = "0xA1736C", VA = "0xA1736C")]
	public void SetHapticAmplitude(HapticType hapticType, InputType hand, float amplitude)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xA17480", Offset = "0xA17480", VA = "0xA17480")]
	public void StopHaptic(HapticType hapticType, InputType hand)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xA1757C", Offset = "0xA1757C", VA = "0xA1757C", Slot = "5")]
	public virtual void SetHandedness(PlayerHandedness handedness)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xA17580", Offset = "0xA17580", VA = "0xA17580", Slot = "6")]
	public virtual bool TriggerPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xA175B8", Offset = "0xA175B8", VA = "0xA175B8")]
	public bool TriggerPress()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xA175F0", Offset = "0xA175F0", VA = "0xA175F0")]
	public bool TriggerPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xA17628", Offset = "0xA17628", VA = "0xA17628")]
	public bool MenuPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xA17660", Offset = "0xA17660", VA = "0xA17660")]
	public bool MenuPress()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xA17698", Offset = "0xA17698", VA = "0xA17698")]
	public bool MenuPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xA176D0", Offset = "0xA176D0", VA = "0xA176D0")]
	public bool SecondaryMenuPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xA17708", Offset = "0xA17708", VA = "0xA17708")]
	public bool SecondaryMenuPress()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xA17740", Offset = "0xA17740", VA = "0xA17740")]
	public bool SecondaryMenuPressUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xA17778", Offset = "0xA17778", VA = "0xA17778")]
	public bool ToolboxRecenterPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xA177B0", Offset = "0xA177B0", VA = "0xA177B0")]
	public bool TouchpadPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xA177E8", Offset = "0xA177E8", VA = "0xA177E8")]
	public Vector3 TouchpadSwipeVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xA17820", Offset = "0xA17820", VA = "0xA17820")]
	public float Trigger(XRNode hand)
	{
		return default(float);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xA17860", Offset = "0xA17860", VA = "0xA17860")]
	public bool TriggerUp(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xA178A0", Offset = "0xA178A0", VA = "0xA178A0")]
	public bool TriggerDown(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xA178E0", Offset = "0xA178E0", VA = "0xA178E0")]
	public bool StampItem(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xA17920", Offset = "0xA17920", VA = "0xA17920")]
	public bool DeleteItem(XRNode hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xA17960", Offset = "0xA17960", VA = "0xA17960")]
	public Vector2 ThumbstickAxis(XRNode hand)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xA179A0", Offset = "0xA179A0", VA = "0xA179A0")]
	public Vector3 GetHeadLevelPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xA14948", Offset = "0xA14948", VA = "0xA14948")]
	public Vector3 GetHeadPalazzoWorldPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xA17A80", Offset = "0xA17A80", VA = "0xA17A80")]
	public Quaternion GetHeadPalazzoWorldRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xA17B94", Offset = "0xA17B94", VA = "0xA17B94")]
	public Vector3 GetHandPalazzoWorldPosition(InputType hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xA17C18", Offset = "0xA17C18", VA = "0xA17C18")]
	public Quaternion GetHandPalazzoWorldRotation(InputType hand)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xA17D9C", Offset = "0xA17D9C", VA = "0xA17D9C")]
	public Vector3 GetHeadUnityWorldPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xA17E34", Offset = "0xA17E34", VA = "0xA17E34")]
	public Quaternion GetHeadUnityWorldRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xA17F2C", Offset = "0xA17F2C", VA = "0xA17F2C")]
	public Vector3 GetHandUnityWorldPosition(InputType hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xA16F10", Offset = "0xA16F10", VA = "0xA16F10")]
	public Quaternion GetHandUnityWorldRotation(InputType hand)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xA18050", Offset = "0xA18050", VA = "0xA18050")]
	public Vector3 GetHeadLocalPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xA16C88", Offset = "0xA16C88", VA = "0xA16C88")]
	public Vector3 GetHandLocalPosition(InputType hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xA18088", Offset = "0xA18088", VA = "0xA18088")]
	public Vector3 GetHandLocalPosition(XRNode hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xA16E40", Offset = "0xA16E40", VA = "0xA16E40")]
	public Quaternion GetHandLocalRotation(InputType hand)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xA182B8", Offset = "0xA182B8", VA = "0xA182B8")]
	public Quaternion GetHandLocalRotation(XRNode hand)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xA182F8", Offset = "0xA182F8", VA = "0xA182F8", Slot = "7")]
	public virtual Vector3 GetHandLocalPositionWhileAiming(InputType hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001E9")]
	public abstract Vector3 GetBirdWorldPositionWhileWaitingForAim();

	[Token(Token = "0x60001EA")]
	public abstract InputType GetBirdHandWhileWaitingForAim();

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xA184B0", Offset = "0xA184B0", VA = "0xA184B0")]
	public void HandleAchievement(Achievements type)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xA184EC", Offset = "0xA184EC", VA = "0xA184EC")]
	public bool ShouldHandlePrivacyPolicy()
	{
		return default(bool);
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xA18520", Offset = "0xA18520", VA = "0xA18520")]
	public string GetUniqueIdentifier()
	{
		return null;
	}
}
[Token(Token = "0x2000068")]
public sealed class InputHandlerOneHanded : InputHandler
{
	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3 savedHandPosition;

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xA185E4", Offset = "0xA185E4", VA = "0xA185E4")]
	static InputHandlerOneHanded()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xA186F0", Offset = "0xA186F0", VA = "0xA186F0")]
	public InputHandlerOneHanded(ARTransforms arTransforms, PalazzoInputDevice inputDevice, PalazzoComponentSlingshot slingshot, LevelContext levelContext, PalazzoGameDataPersistent gameDataPersistent, WorldContext worldContext)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xA189F0", Offset = "0xA189F0", VA = "0xA189F0", Slot = "6")]
	public override bool TriggerPressDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xA18A54", Offset = "0xA18A54", VA = "0xA18A54", Slot = "7")]
	public override Vector3 GetHandLocalPositionWhileAiming(InputType hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xA18A6C", Offset = "0xA18A6C", VA = "0xA18A6C", Slot = "8")]
	public override Vector3 GetBirdWorldPositionWhileWaitingForAim()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xA18AAC", Offset = "0xA18AAC", VA = "0xA18AAC", Slot = "9")]
	public override InputType GetBirdHandWhileWaitingForAim()
	{
		return default(InputType);
	}
}
[Token(Token = "0x2000069")]
public class InputHandlerTwoHanded : InputHandler
{
	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 slingshotHandTensionOffset;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly TensionHandSettings tensionHandSettings;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly Transform tensionHandTransform;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly LevelEditorVRController levelEditorVRController;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly TrajectoryMarkerSettings trajectoryMarkerSettings;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly float timeNormalizer;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool isAiming;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int scaling;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float scalingValueBasedOntime;

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xA18AB4", Offset = "0xA18AB4", VA = "0xA18AB4")]
	static InputHandlerTwoHanded()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xA18C28", Offset = "0xA18C28", VA = "0xA18C28")]
	public InputHandlerTwoHanded(ARTransforms arTransforms, PalazzoInputDevice inputDevice, PalazzoComponentSlingshot slingshot, LevelContext levelContext, TensionHandSettings tensionHandSettings, TensionHand tensionHand, LevelEditorVRController levelEditorVRController, PalazzoGameDataPersistent gameDataPersistent, WorldContext worldContext, TrajectoryMarkerSettings trajectoryMarkerSettings)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xA18F80", Offset = "0xA18F80", VA = "0xA18F80", Slot = "4")]
	protected override void TickInternal()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xA192F8", Offset = "0xA192F8", VA = "0xA192F8", Slot = "7")]
	public override Vector3 GetHandLocalPositionWhileAiming(InputType hand)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xA19484", Offset = "0xA19484", VA = "0xA19484", Slot = "8")]
	public override Vector3 GetBirdWorldPositionWhileWaitingForAim()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xA1948C", Offset = "0xA1948C", VA = "0xA1948C", Slot = "9")]
	public override InputType GetBirdHandWhileWaitingForAim()
	{
		return default(InputType);
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xA19494", Offset = "0xA19494", VA = "0xA19494", Slot = "5")]
	public override void SetHandedness(PlayerHandedness handedness)
	{
	}
}
[Token(Token = "0x200006A")]
public sealed class InteractiveCharacterComponent : MonoBehaviour
{
	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform leftEye;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform rightEye;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform neck;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator anim;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x767674", Offset = "0x767674")]
	public float targetSwitchDelay;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7676AC", Offset = "0x7676AC")]
	public float targetSwitchDelayVariation;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7676E4", Offset = "0x7676E4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7676E4", Offset = "0x7676E4")]
	public float neckLookWeight;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x767738", Offset = "0x767738")]
	public float neckBlendSwitchTimescale;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float neckLookDotMin;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float eyesLookDotMin;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool alsoLookBehind;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 frontDirectionEyes;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 upDirectionEyes;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 frontRotationEyes;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3 frontRotationNeck;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Vector3 rightEyeCenterRotation;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Vector3 leftEyeCenterRotation;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float maxDegreesFromCenter;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool useLocal;

	[NonSerialized]
	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float timeLooking;

	[NonSerialized]
	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float timeNotLooking;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private Quaternion frontEyeRotation;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion frontNeckRotation;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float maxRadiansFromCenter;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool initialized;

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xA19668", Offset = "0xA19668", VA = "0xA19668")]
	private void Init()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xA1973C", Offset = "0xA1973C", VA = "0xA1973C")]
	public float GetMaxRadiansFromCenter()
	{
		return default(float);
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xA1976C", Offset = "0xA1976C", VA = "0xA1976C")]
	public Quaternion GetFrontEyeRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xA197A0", Offset = "0xA197A0", VA = "0xA197A0")]
	public Quaternion GetFrontNeckRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xA197D4", Offset = "0xA197D4", VA = "0xA197D4")]
	public void LookAtPlayer()
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xA1983C", Offset = "0xA1983C", VA = "0xA1983C")]
	public void StopLookingAtPlayer()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xA198A4", Offset = "0xA198A4", VA = "0xA198A4")]
	public InteractiveCharacterComponent()
	{
	}
}
[Token(Token = "0x200006B")]
public class IntroComponent : MonoBehaviour
{
	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PlayableDirector timeLine;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject balloon;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public readonly float TIME_TO_REACH_TOP;

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xA198D8", Offset = "0xA198D8", VA = "0xA198D8")]
	public IntroComponent()
	{
	}
}
[Token(Token = "0x200006C")]
public class EditingState : LevelEditorStateBase
{
	[Token(Token = "0x20001FD")]
	private enum State
	{
		[Token(Token = "0x4000DB8")]
		Editing,
		[Token(Token = "0x4000DB9")]
		MovingToEditingPosition
	}

	[Token(Token = "0x20001FE")]
	private enum PositionState
	{
		[Token(Token = "0x4000DBB")]
		Idle,
		[Token(Token = "0x4000DBC")]
		FadeUp,
		[Token(Token = "0x4000DBD")]
		FadeDown
	}

	[Token(Token = "0x4000311")]
	private const float TELEPORTATION_STEP = 0.5f;

	[Token(Token = "0x4000312")]
	private const int PLATFORM_ROTATION_STEP = 20;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelEditorComponent levelEditor;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly ToolboxHandler toolboxHandler;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly Toolbox toolbox;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly LevelBuildingHandler levelBuildingHandler;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly LevelEditorSettings levelEditorSettings;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly LevelFactory levelFactory;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Transform scenePlatform;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int yStep;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private bool positionToolbox;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int prevRotationStep;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private LevelEditorStateType nextState;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool teleportReady;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	private bool isTransitioning;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
	private bool isTransitioningPrev;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private State state;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private State prevState;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private PositionState posState;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private PositionState prevPosState;

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x9B0E4C", Offset = "0x9B0E4C", VA = "0x9B0E4C")]
	public EditingState(WorldContext worldContext, PalazzoTriggers palazzoTriggers, InputHandler inputHandler, TeleportationHandler teleportationHandler, MonoBehaviour monoBehaviour, LevelEditorComponent levelEditor, LevelContext levelContext, ARTransforms arTransforms, Toolbox toolbox, FadeHandler fadeHandler, LevelBuildingHandler levelBuildingHandler, LevelEditorContext levelEditorContext, LevelEditorPlayContext levelEditorPlayContext, LevelEditorSettings levelEditorSettings, LevelFactory levelFactory, TrajectoryHandler trajectoryHandler, LevelEditorVRController vrControllerLevelEditor, ToolboxSettings toolboxSettings)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x9B10E4", Offset = "0x9B10E4", VA = "0x9B10E4", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x9B10F0", Offset = "0x9B10F0", VA = "0x9B10F0", Slot = "5")]
	public override LevelEditorStateType Tick()
	{
		return default(LevelEditorStateType);
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x9B2160", Offset = "0x9B2160", VA = "0x9B2160", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x9B21D4", Offset = "0x9B21D4", VA = "0x9B21D4")]
	private void OpenMenu(MenuType menuType)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x9B222C", Offset = "0x9B222C", VA = "0x9B222C")]
	private void OnTryPlay()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x9B221C", Offset = "0x9B221C", VA = "0x9B221C")]
	private void SetNextState(LevelEditorStateType nextState)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x9B2240", Offset = "0x9B2240", VA = "0x9B2240")]
	private void ClearBuildingLevel()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x9B2278", Offset = "0x9B2278", VA = "0x9B2278")]
	private void OnToolboxItemGrab(ToolboxItemComponent item, VRGrab hand)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x9B1B08", Offset = "0x9B1B08", VA = "0x9B1B08")]
	private void HandleEditingPosition()
	{
	}
}
[Token(Token = "0x200006D")]
public class LevelEditorMenuState : LevelEditorStateBase
{
	[Token(Token = "0x20001FF")]
	private enum State
	{
		[Token(Token = "0x4000DBF")]
		ShowMenu,
		[Token(Token = "0x4000DC0")]
		TransitionOut,
		[Token(Token = "0x4000DC1")]
		MoveToMenuPosition,
		[Token(Token = "0x4000DC2")]
		WaitForPreviewDespawn
	}

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelEditorComponent levelEditor;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly IMenuHandler[] menuHandlers;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly LevelFactory levelFactory;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private LevelEditorStateType nextState;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private State state;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private State prevState;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private MenuType? nextMenuType;

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x9FE6AC", Offset = "0x9FE6AC", VA = "0x9FE6AC")]
	public LevelEditorMenuState(GameStateData gameStateData, NetworkHandler networkHandler, LevelEditorContext levelEditorContext, LevelEditorPlayContext levelEditorPlayContext, MenuContext menuContext, LevelEditorComponent levelEditor, IEnumerable<SplitMenu> splitMenus, WorldContext worldContext, PalazzoTriggers palazzoTriggers, InputHandler inputHandler, ARTransforms arTransforms, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, LevelBuildingHandler levelBuildingHandler, TeleportationHandler teleportationHandler, FadeHandler fadeHandler, LevelFactory levelFactory, LevelContext levelContext, MonoBehaviour monoBehaviour, PalazzoComponentBirdPlatform birdPlatform, CreateUserMenu createUserMenu, ReportMenu reportMenu, CreateUserSettings createUserSettings, ErrorMenu errorMenu)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x9FF808", Offset = "0x9FF808", VA = "0x9FF808", Slot = "4")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x9FF860", Offset = "0x9FF860", VA = "0x9FF860", Slot = "6")]
	public override void Exit()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x9FF964", Offset = "0x9FF964", VA = "0x9FF964", Slot = "5")]
	public override LevelEditorStateType Tick()
	{
		return default(LevelEditorStateType);
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xA00384", Offset = "0xA00384", VA = "0xA00384")]
	private void SetState(LevelEditorStateType nextState)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xA004D8", Offset = "0xA004D8", VA = "0xA004D8")]
	private void SetMenuType(MenuType menuType)
	{
	}
}
[Token(Token = "0x200006E")]
public enum MenuType
{
	[Token(Token = "0x400033C")]
	BuildLevels,
	[Token(Token = "0x400033D")]
	SaveLevels,
	[Token(Token = "0x400033E")]
	FavoriteLevels,
	[Token(Token = "0x400033F")]
	Discovery,
	[Token(Token = "0x4000340")]
	UserProfile,
	[Token(Token = "0x4000341")]
	CreateUser,
	[Token(Token = "0x4000342")]
	Report,
	[Token(Token = "0x4000343")]
	MyProfile,
	[Token(Token = "0x4000344")]
	FavoriteError
}
[Token(Token = "0x200006F")]
public sealed class LevelBlockFactory
{
	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ComponentPrefabPool<PalazzoComponentLevelBlock>[] levelBlockPrefabPoolLookup;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly DamageQueue damageQueue;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly BirdImpactQueue birdImpactQueue;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly HealthBarData healthBarData;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly AlchemyHandler alchemyHandler;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] zeroPositions;

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xA19940", Offset = "0xA19940", VA = "0xA19940")]
	public LevelBlockFactory(ComponentPrefabPool<PalazzoComponentLevelBlock>[] levelBlockPrefabPoolLookup, DamageQueue damageQueue, BirdImpactQueue birdImpactQueue, HealthBarData healthBarData, Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup, AlchemyHandler alchemyHandler)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xA199E0", Offset = "0xA199E0", VA = "0xA199E0")]
	public PalazzoComponentLevelBlock Create(PalazzoComponentLevelBlock prefab, Transform levelTransform, Vector3 localPosition, Quaternion localRotation)
	{
		return null;
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xA1A65C", Offset = "0xA1A65C", VA = "0xA1A65C")]
	public void Destroy(PalazzoComponentLevelBlock levelBlock)
	{
	}
}
[Token(Token = "0x2000070")]
public sealed class LevelBlockHelper
{
	[Token(Token = "0x400034C")]
	private const float SPHERE_VOLUME_FACTOR = 4.1887903f;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PhysicsSettings physicsSettings;

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xA1A70C", Offset = "0xA1A70C", VA = "0xA1A70C")]
	public LevelBlockHelper(ARTransforms arTransforms, PhysicsSettings physicsSettings)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xA1A744", Offset = "0xA1A744", VA = "0xA1A744")]
	public float CalcVolume(PalazzoComponentLevelBlock block)
	{
		return default(float);
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xA1AB78", Offset = "0xA1AB78", VA = "0xA1AB78")]
	public float CalcMass(PalazzoComponentLevelBlock block, float volume)
	{
		return default(float);
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xA1AEC0", Offset = "0xA1AEC0", VA = "0xA1AEC0")]
	public float CalcHealth(PalazzoComponentLevelBlock block)
	{
		return default(float);
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xA1B218", Offset = "0xA1B218", VA = "0xA1B218")]
	public float CalcImpactMagnitudeThreshold()
	{
		return default(float);
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xA1B2BC", Offset = "0xA1B2BC", VA = "0xA1B2BC")]
	public float CalcExplosionRadius(ExplosionComponent xpl)
	{
		return default(float);
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xA1B308", Offset = "0xA1B308", VA = "0xA1B308")]
	public float CalcExplosionDamage(ExplosionComponent xpl)
	{
		return default(float);
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xA1B354", Offset = "0xA1B354", VA = "0xA1B354")]
	public float CalcExplosionForce(ExplosionComponent xpl)
	{
		return default(float);
	}
}
[Token(Token = "0x2000071")]
public struct LevelBlockProxyComparer : IEqualityComparer<LevelBlockProxy>
{
	[Token(Token = "0x600021F")]
	[Address(RVA = "0x7D8CAC", Offset = "0x7D8CAC", VA = "0x7D8CAC", Slot = "4")]
	public bool Equals(LevelBlockProxy x, LevelBlockProxy y)
	{
		return default(bool);
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x7D8CB0", Offset = "0x7D8CB0", VA = "0x7D8CB0", Slot = "5")]
	public int GetHashCode(LevelBlockProxy obj)
	{
		return default(int);
	}
}
[Token(Token = "0x2000072")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public sealed class LevelBlockProxy : MonoBehaviour
{
	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PalazzoComponentLevelBlock levelBlockPrefab;

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xA1B3B8", Offset = "0xA1B3B8", VA = "0xA1B3B8")]
	public LevelBlockProxy()
	{
	}
}
[Token(Token = "0x2000073")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7662E4", Offset = "0x7662E4")]
public sealed class LevelBlockProxyAttachment : MonoBehaviour
{
	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LevelBlockProxy connectedBlock;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 connectedAnchor;

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xA1B3C0", Offset = "0xA1B3C0", VA = "0xA1B3C0")]
	public LevelBlockProxyAttachment()
	{
	}
}
[Token(Token = "0x2000074")]
public class LevelBlockProxyBalloon : MonoBehaviour
{
	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speedVariationAmplitude;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float speedVariationFrequency;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float buoyancyMultiplier;

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xA1B3C8", Offset = "0xA1B3C8", VA = "0xA1B3C8")]
	public LevelBlockProxyBalloon()
	{
	}
}
[Token(Token = "0x2000075")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766358", Offset = "0x766358")]
public sealed class LevelBlockProxyBossPig : MonoBehaviour
{
	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public WorldType bossType;

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xA1B3E8", Offset = "0xA1B3E8", VA = "0xA1B3E8")]
	public LevelBlockProxyBossPig()
	{
	}
}
[Token(Token = "0x2000076")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7663CC", Offset = "0x7663CC")]
public sealed class LevelBlockProxyFan : MonoBehaviour
{
	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float range;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float outwardsForce;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float speedVariationAmplitude;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speedVariationFrequency;

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xA1B49C", Offset = "0xA1B49C", VA = "0xA1B49C")]
	public LevelBlockProxyFan()
	{
	}
}
[Token(Token = "0x2000077")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766450", Offset = "0x766450")]
public sealed class LevelBlockProxyTeleportationPoint : MonoBehaviour
{
	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool useCustomPlacement;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 birdPlatformOffset;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 birdPlatformRotation;

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xA1B4B8", Offset = "0xA1B4B8", VA = "0xA1B4B8")]
	public LevelBlockProxyTeleportationPoint()
	{
	}
}
[Token(Token = "0x2000078")]
public class LevelBuildingBlock : MonoBehaviour
{
	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Prefab prefab;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BlockTypeData blockTypeData;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Collider col;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator anim;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GhostComponent ghost;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GhostComponent lastPlacement;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GhostComponent placementRepresentation;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Renderer[] renderers;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material[][] originalMaterials;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int blockId;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector3 lastValidPosition;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Quaternion lastValidRotation;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool isColliding;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int isLastValidTransformEmpty;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector3 originalScale;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool isInDeletionCollider;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool isSnapping;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
	public bool isInteractable;

	[Token(Token = "0x17000010")]
	public BlockType BlockType
	{
		[Token(Token = "0x6000227")]
		[Address(RVA = "0xA1B4C0", Offset = "0xA1B4C0", VA = "0xA1B4C0")]
		get
		{
			return default(BlockType);
		}
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xA1B4EC", Offset = "0xA1B4EC", VA = "0xA1B4EC")]
	public LevelBuildingBlock()
	{
	}
}
[Token(Token = "0x2000079")]
public sealed class LevelBuildingHandler
{
	[Token(Token = "0x2000200")]
	public enum State
	{
		[Token(Token = "0x4000DC4")]
		Building,
		[Token(Token = "0x4000DC5")]
		FadeUndo,
		[Token(Token = "0x4000DC6")]
		FadeRedo,
		[Token(Token = "0x4000DC7")]
		FadeClearLevel
	}

	[Token(Token = "0x2000201")]
	private struct BlockMovingBackToToolbox
	{
		[Token(Token = "0x4000DC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LevelBuildingBlock block;

		[Token(Token = "0x4000DC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ToolboxItemComponent toolboxItem;
	}

	[Token(Token = "0x2000202")]
	private struct DataOnGrab
	{
		[Token(Token = "0x4000DCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int blockId;

		[Token(Token = "0x4000DCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Vector3 localPosition;

		[Token(Token = "0x4000DCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Quaternion localRotation;
	}

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Toolbox toolbox;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly LevelEditorVRController vrController;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelEditorSettings levelEditorSettings;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly LevelBuildingBlock[] blocksInHand;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly LevelBuildingBlock[] highlightedBlocks;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly ToolboxItemComponent[] hiddenToolboxItems;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly LevelEditorComponent levelEditor;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly BuildingBlockFactory buildingBlockFactory;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly List<BlockMovingBackToToolbox> blocksMovingBackToToolbox;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly Transform levelParent;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly HistoryHandler historyHandler;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Material[][] redMaterials;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Material[][] greenMaterials;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Material[][] grayMaterials;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Collider[] resultColliders;

	[Token(Token = "0x4000384")]
	private const float POSITION_LERP_SPEED = 50f;

	[Token(Token = "0x4000385")]
	private const float ROTATION_LERP_SPEED = 25f;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly DataOnGrab?[] dataOnGrab;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly Quaternion[] grabbedRotationOffset;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly Vector3[] grabbedPositionOffset;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly int idle;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static readonly int hangBalloon;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Level uneditedLevel;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private uint previousLevelId;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool isRotating;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767770", Offset = "0x767770")]
	private State <state>k__BackingField;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private State prevState;

	[Token(Token = "0x17000011")]
	public State state
	{
		[Token(Token = "0x6000229")]
		[Address(RVA = "0xA1B4FC", Offset = "0xA1B4FC", VA = "0xA1B4FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A26C", Offset = "0x76A26C")]
		get
		{
			return default(State);
		}
		[Token(Token = "0x600022A")]
		[Address(RVA = "0xA1B504", Offset = "0xA1B504", VA = "0xA1B504")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A27C", Offset = "0x76A27C")]
		private set
		{
		}
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xA1B50C", Offset = "0xA1B50C", VA = "0xA1B50C")]
	public LevelBuildingHandler(InputHandler inputHandler, ARTransforms arTransforms, Toolbox toolbox, LevelEditorVRController vrController, LevelEditorContext levelEditorContext, LevelEditorSettings levelEditorSettings, LevelEditorComponent levelEditor, PalazzoTriggers palazzoTriggers, FadeHandler fadeHandler)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xA1BB6C", Offset = "0xA1BB6C", VA = "0xA1BB6C")]
	public void Reset()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xA1BB78", Offset = "0xA1BB78", VA = "0xA1BB78")]
	public void StartEditingLevel(Level level)
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xA1C0EC", Offset = "0xA1C0EC", VA = "0xA1C0EC")]
	public void FixedTick()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xA1D2BC", Offset = "0xA1D2BC", VA = "0xA1D2BC")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xA1EAE0", Offset = "0xA1EAE0", VA = "0xA1EAE0")]
	private void ReleaseItem(int iHand, LevelBuildingBlock block, ToolboxItemComponent toolboxItem, bool isSnapping, bool isInDeletionCollider, bool isCloseToToolbox)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xA1F3CC", Offset = "0xA1F3CC", VA = "0xA1F3CC")]
	private void StampItem(int iHand, bool isSnapping)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xA1FC94", Offset = "0xA1FC94", VA = "0xA1FC94")]
	private void DeleteItem(int iHand, LevelBuildingBlock block, bool isCloseToToolbox, bool isInDeletionCollider)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xA1BF90", Offset = "0xA1BF90", VA = "0xA1BF90")]
	private void RemoveGrabbedItemOnEnter(int iHand, LevelBuildingBlock block)
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xA20478", Offset = "0xA20478", VA = "0xA20478")]
	private void GrabItem(Vector3 handPosition, Quaternion handRotation, LevelBuildingBlock grabbedBlock, int iHand)
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xA20DCC", Offset = "0xA20DCC", VA = "0xA20DCC")]
	public void OnToolboxItemGrabbed(ToolboxItemComponent toolboxItemComponent, VRGrab hand)
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xA1FFC4", Offset = "0xA1FFC4", VA = "0xA1FFC4")]
	private LevelBuildingBlock HighlightItem(Vector3 handPosition, int iHand)
	{
		return null;
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xA2166C", Offset = "0xA2166C", VA = "0xA2166C")]
	private void AddHighlight(LevelBuildingBlock block)
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xA20D1C", Offset = "0xA20D1C", VA = "0xA20D1C")]
	private void RemoveHighlight(LevelBuildingBlock block)
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xA1CE78", Offset = "0xA1CE78", VA = "0xA1CE78")]
	private bool IsColliding(Collider col, params Collider[] colToIgnore)
	{
		return default(bool);
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xA20CB0", Offset = "0xA20CB0", VA = "0xA20CB0")]
	private bool IsBlockAffordable(int blockCost)
	{
		return default(bool);
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xA1C084", Offset = "0xA1C084", VA = "0xA1C084")]
	private void EnableHandArrow(VRHand hand, bool enabled)
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xA21724", Offset = "0xA21724", VA = "0xA21724")]
	public void Undo()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xA2189C", Offset = "0xA2189C", VA = "0xA2189C")]
	public void Redo()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xA21A14", Offset = "0xA21A14", VA = "0xA21A14")]
	public void ClearBuildingLevel(bool isRecording, bool fade = false)
	{
	}
}
[Token(Token = "0x200007A")]
public sealed class LevelButton : PalazzoButton<LevelSelectButtonType>
{
	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public PalazzoComponentStar[] levelStars;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject levelLock;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TextMeshPro levelTextDefault;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public TextMeshPro levelTextHover;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public SpriteRenderer optionalBossSprite;

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xA21B6C", Offset = "0xA21B6C", VA = "0xA21B6C")]
	public LevelButton()
	{
	}
}
[Token(Token = "0x200007B")]
public class LevelEditorComponent : MonoBehaviour
{
	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform levelParent;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform toolboxParent;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public PlatformHandleRotation platform;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Toolbox toolbox;

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x9FE564", Offset = "0x9FE564", VA = "0x9FE564")]
	public LevelEditorComponent()
	{
	}
}
[Token(Token = "0x200007C")]
public class LevelEditorEnvironment : SingleInstanceBehavior<LevelEditorEnvironment>
{
	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform editingTransform;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject telePointsRoot;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] teleportationPointPositions;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform startTeleportationPoint;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject editingPlatform;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform birdPlatformPreviewPosition;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TelePointLevelEditor[] telePoints;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject orientationIndicator;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform splitMenuPosition;

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x9FE574", Offset = "0x9FE574", VA = "0x9FE574")]
	public LevelEditorEnvironment()
	{
	}
}
[Token(Token = "0x200007D")]
public class LevelEditorVRController : MonoBehaviour
{
	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRGrab leftHand;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRGrab rightHand;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MeshRenderer leftArrow;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshRenderer rightArrow;

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xA03DAC", Offset = "0xA03DAC", VA = "0xA03DAC")]
	public LevelEditorVRController()
	{
	}
}
[Token(Token = "0x200007E")]
public class LevelEditorVRControllerHandler
{
	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelEditorVRController vrController;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private VRGrab leftHand;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VRGrab rightHand;

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xA02150", Offset = "0xA02150", VA = "0xA02150")]
	public LevelEditorVRControllerHandler(LevelEditorVRController vrController)
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xA036DC", Offset = "0xA036DC", VA = "0xA036DC")]
	public void Tick()
	{
	}
}
[Token(Token = "0x200007F")]
public sealed class LevelFactory
{
	[Token(Token = "0x2000203")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7671D4", Offset = "0x7671D4")]
	private sealed class <SpawnLevelBlockByBlock>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000DCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000DCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000DCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelContext levelContext;

		[Token(Token = "0x4000DD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LevelFactory <>4__this;

		[Token(Token = "0x4000DD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Level level;

		[Token(Token = "0x4000DD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform <levelTransform>5__2;

		[Token(Token = "0x4000DD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform <lockedObjectsParent>5__3;

		[Token(Token = "0x4000DD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PalazzoComponentLevelBlock> <blocks>5__4;

		[Token(Token = "0x4000DD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<DamageComponent> <damages>5__5;

		[Token(Token = "0x4000DD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<FanComponent> <fans>5__6;

		[Token(Token = "0x4000DD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<PalazzoComponentPig> <pigs>5__7;

		[Token(Token = "0x4000DD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<PalazzoComponentBird> <birds>5__8;

		[Token(Token = "0x4000DD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<InteractiveCharacterComponent> <characters>5__9;

		[Token(Token = "0x4000DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<TeleportationComponent> <teleportationPoints>5__10;

		[Token(Token = "0x4000DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int <numberOfBlocks>5__11;

		[Token(Token = "0x4000DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<BlockData> <blockDatas>5__12;

		[Token(Token = "0x4000DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int <blocksPerTick>5__13;

		[Token(Token = "0x4000DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int <pigsToSpawnPerFrame>5__14;

		[Token(Token = "0x4000DDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private YieldInstruction <pigsSpawnWait>5__15;

		[Token(Token = "0x4000DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float <maxDepenetrationVelocity>5__16;

		[Token(Token = "0x4000DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float <depenetrationVelocitySettle>5__17;

		[Token(Token = "0x4000DE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int <iBlock>5__18;

		[Token(Token = "0x4000DE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int <nBlock>5__19;

		[Token(Token = "0x4000DE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private PalazzoComponentLevelBlock <block>5__20;

		[Token(Token = "0x170000FB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0xA08D34", Offset = "0xA08D34", VA = "0xA08D34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0xA08DA4", Offset = "0xA08DA4", VA = "0xA08DA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xA04B54", Offset = "0xA04B54", VA = "0xA04B54")]
		[DebuggerHidden]
		public <SpawnLevelBlockByBlock>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xA07640", Offset = "0xA07640", VA = "0xA07640", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xA07644", Offset = "0xA07644", VA = "0xA07644", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xA08D3C", Offset = "0xA08D3C", VA = "0xA08D3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000204")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7671E4", Offset = "0x7671E4")]
	private sealed class <SpawnLevelBlockByBlock>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000DE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000DE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000DE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelFactory <>4__this;

		[Token(Token = "0x4000DE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int levelIndex;

		[Token(Token = "0x4000DE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LevelContext levelContext;

		[Token(Token = "0x4000DEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PalazzoComponentLevel <levelPrefab>5__2;

		[Token(Token = "0x4000DEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform <levelTransform>5__3;

		[Token(Token = "0x4000DEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PalazzoComponentLevelBlock> <blocks>5__4;

		[Token(Token = "0x4000DED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<DamageComponent> <damages>5__5;

		[Token(Token = "0x4000DEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<FanComponent> <fans>5__6;

		[Token(Token = "0x4000DEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<BalloonComponent> <balloons>5__7;

		[Token(Token = "0x4000DF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<PalazzoComponentPig> <pigs>5__8;

		[Token(Token = "0x4000DF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<PalazzoComponentBird> <birds>5__9;

		[Token(Token = "0x4000DF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<InteractiveCharacterComponent> <characters>5__10;

		[Token(Token = "0x4000DF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<TeleportationComponent> <teleportationPoints>5__11;

		[Token(Token = "0x4000DF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int <teleportationPointCounter>5__12;

		[Token(Token = "0x4000DF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int <blocksPerTick>5__13;

		[Token(Token = "0x4000DF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float <maxDepenetrationVelocity>5__14;

		[Token(Token = "0x4000DF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float <depenetrationVelocitySettle>5__15;

		[Token(Token = "0x4000DF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int <iBlock>5__16;

		[Token(Token = "0x4000DF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int <nBlock>5__17;

		[Token(Token = "0x4000DFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private PalazzoComponentLevelBlock <block>5__18;

		[Token(Token = "0x170000FD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0xA0AF58", Offset = "0xA0AF58", VA = "0xA0AF58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0xA0AFC8", Offset = "0xA0AFC8", VA = "0xA0AFC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xA04B80", Offset = "0xA04B80", VA = "0xA04B80")]
		[DebuggerHidden]
		public <SpawnLevelBlockByBlock>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xA08DAC", Offset = "0xA08DAC", VA = "0xA08DAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xA08DB0", Offset = "0xA08DB0", VA = "0xA08DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xA0AF60", Offset = "0xA0AF60", VA = "0xA0AF60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000205")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7671F4", Offset = "0x7671F4")]
	private sealed class <NukeLevelFromOrbit>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000DFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000DFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000DFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelContext levelContext;

		[Token(Token = "0x4000DFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LevelFactory <>4__this;

		[Token(Token = "0x4000DFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<PalazzoComponentLevelBlock> <blocks>5__2;

		[Token(Token = "0x4000E00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<DamageComponent> <damages>5__3;

		[Token(Token = "0x4000E01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<InteractiveCharacterComponent> <characters>5__4;

		[Token(Token = "0x4000E02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PalazzoComponentPig> <pigs>5__5;

		[Token(Token = "0x4000E03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int <pigsToDespawnPerFrame>5__6;

		[Token(Token = "0x4000E04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private YieldInstruction <pigsDepawnWait>5__7;

		[Token(Token = "0x4000E05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<PalazzoComponentBird> <birds>5__8;

		[Token(Token = "0x4000E06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int <blocksPerTick>5__9;

		[Token(Token = "0x4000E07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int <iPig>5__10;

		[Token(Token = "0x4000E08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int <nPig>5__11;

		[Token(Token = "0x4000E09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PalazzoComponentLevelBlock <block>5__12;

		[Token(Token = "0x170000FF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009E4")]
			[Address(RVA = "0xA069BC", Offset = "0xA069BC", VA = "0xA069BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000100")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0xA06A2C", Offset = "0xA06A2C", VA = "0xA06A2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xA04BAC", Offset = "0xA04BAC", VA = "0xA04BAC")]
		[DebuggerHidden]
		public <NukeLevelFromOrbit>d__36(int <>1__state)
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xA05D90", Offset = "0xA05D90", VA = "0xA05D90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xA05D94", Offset = "0xA05D94", VA = "0xA05D94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xA069C4", Offset = "0xA069C4", VA = "0xA069C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000206")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767204", Offset = "0x767204")]
	private sealed class <PreviewLevelBlockByBlock>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000E0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000E0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelContext levelContext;

		[Token(Token = "0x4000E0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Level level;

		[Token(Token = "0x4000E0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LevelFactory <>4__this;

		[Token(Token = "0x4000E0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform levelParent;

		[Token(Token = "0x4000E10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform birdPlatformPosition;

		[Token(Token = "0x4000E11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PalazzoComponentLevelBlock> <blocks>5__2;

		[Token(Token = "0x4000E12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<FanComponent> <fans>5__3;

		[Token(Token = "0x4000E13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int <birdCount>5__4;

		[Token(Token = "0x4000E14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int <blocksPerTick>5__5;

		[Token(Token = "0x4000E15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int <iBlock>5__6;

		[Token(Token = "0x4000E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int <nBlock>5__7;

		[Token(Token = "0x4000E17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private PalazzoComponentLevelBlock <block>5__8;

		[Token(Token = "0x17000101")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0xA075C8", Offset = "0xA075C8", VA = "0xA075C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0xA07638", Offset = "0xA07638", VA = "0xA07638", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xA05638", Offset = "0xA05638", VA = "0xA05638")]
		[DebuggerHidden]
		public <PreviewLevelBlockByBlock>d__39(int <>1__state)
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xA06A34", Offset = "0xA06A34", VA = "0xA06A34", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xA06A38", Offset = "0xA06A38", VA = "0xA06A38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xA075D0", Offset = "0xA075D0", VA = "0xA075D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000207")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767214", Offset = "0x767214")]
	private sealed class <DespawnPreviewLevelBlockByBlock>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000E19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000E1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelContext levelContext;

		[Token(Token = "0x4000E1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LevelFactory <>4__this;

		[Token(Token = "0x4000E1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<PalazzoComponentLevelBlock> <blocks>5__2;

		[Token(Token = "0x4000E1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <blocksPerTick>5__3;

		[Token(Token = "0x4000E1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int <iBlock>5__4;

		[Token(Token = "0x17000103")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0xA05D18", Offset = "0xA05D18", VA = "0xA05D18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0xA05D88", Offset = "0xA05D88", VA = "0xA05D88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xA05838", Offset = "0xA05838", VA = "0xA05838")]
		[DebuggerHidden]
		public <DespawnPreviewLevelBlockByBlock>d__43(int <>1__state)
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xA05A14", Offset = "0xA05A14", VA = "0xA05A14", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xA05A18", Offset = "0xA05A18", VA = "0xA05A18", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xA05D20", Offset = "0xA05D20", VA = "0xA05D20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly WaitForSeconds spawnBlockDuration;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly WaitForSeconds spawnPigAndBirdDelay;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly WaitForSeconds spawnPigDuration;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly WaitForSeconds spawnBirdDuration;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly WaitForSeconds despawnPigDuration;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly WaitForSeconds despawnBirdDuration;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly WaitForSeconds despawnBlockDuration;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly WaitForEndOfFrame waitForEndOfFrame;

	[Token(Token = "0x40003B2")]
	private const int LEVEL_SETTLE_FRAMES = 30;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoComponentLevel[] levelPrefabs;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelBlockFactory levelBlockFactory;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly AlchemyHandler alchemyHandler;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly List<LevelBlockProxy> levelBlockProxyCache;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Dictionary<LevelBlockProxy, PalazzoComponentLevelBlock> levelBlockLookupCache;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly List<LevelBlockProxyBalloon> levelBlockProxyBalloonCache;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly List<LevelBlockProxyAttachment> levelBlockProxyAttachmentCache;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly List<LevelBlockProxyFan> levelBlockProxyFanCache;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly List<LevelBlockProxyTeleportationPoint> levelBlockProxyTeleportationPointCache;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly List<BlockData> previewLevelBlockByBlockCache;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static readonly int emissionAdd;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool isDespawning;

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xA03DB4", Offset = "0xA03DB4", VA = "0xA03DB4")]
	public LevelFactory(MonoBehaviour monoBehaviour, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, PalazzoComponentLevel[] levelPrefabs, LevelBlockFactory levelBlockFactory, AlchemyHandler alchemyHandler, PalazzoComponentBirdPlatform birdPlatform)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xA03FAC", Offset = "0xA03FAC", VA = "0xA03FAC")]
	public void Create(LevelContext levelContext, int levelIndex)
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xA042C4", Offset = "0xA042C4", VA = "0xA042C4")]
	public void Create(LevelContext levelContext, Level levelStorage)
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xA045B8", Offset = "0xA045B8", VA = "0xA045B8")]
	public void Destroy(LevelContext levelContext)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xA046B0", Offset = "0xA046B0", VA = "0xA046B0")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x76A28C", Offset = "0x76A28C")]
	public void DebugCreate(LevelContext levelContext, int levelIndex)
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0xA0489C", Offset = "0xA0489C", VA = "0xA0489C")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x76A2C4", Offset = "0x76A2C4")]
	public void DebugDestroy(LevelContext levelContext)
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xA04970", Offset = "0xA04970", VA = "0xA04970")]
	private static int ShortestDistanceToOrigo(LevelBlockProxy r1, LevelBlockProxy r2)
	{
		return default(int);
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xA04A3C", Offset = "0xA04A3C", VA = "0xA04A3C")]
	private static int ShortestDistanceToOrigo(BlockData r1, BlockData r2)
	{
		return default(int);
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xA04A88", Offset = "0xA04A88", VA = "0xA04A88")]
	private static int FurthestDistanceToOrigo(PalazzoComponentLevelBlock r1, PalazzoComponentLevelBlock r2)
	{
		return default(int);
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xA0450C", Offset = "0xA0450C", VA = "0xA0450C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76A2FC", Offset = "0x76A2FC")]
	private IEnumerator SpawnLevelBlockByBlock(LevelContext levelContext, Level level)
	{
		return null;
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xA04214", Offset = "0xA04214", VA = "0xA04214")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76A360", Offset = "0x76A360")]
	private IEnumerator SpawnLevelBlockByBlock(LevelContext levelContext, int levelIndex)
	{
		return null;
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xA04618", Offset = "0xA04618", VA = "0xA04618")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76A3C4", Offset = "0x76A3C4")]
	private IEnumerator NukeLevelFromOrbit(LevelContext levelContext)
	{
		return null;
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xA04BD8", Offset = "0xA04BD8", VA = "0xA04BD8")]
	public void PreviewLevel(Transform levelParent, Level level, LevelContext levelContext, Transform birdPlatformPosition, bool blockByBlock = false)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xA04DA0", Offset = "0xA04DA0", VA = "0xA04DA0")]
	private void PreviewLevelInstant(Transform levelParent, Level level, LevelContext levelContext, Transform birdPlatformPosition)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xA04CC0", Offset = "0xA04CC0", VA = "0xA04CC0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76A428", Offset = "0x76A428")]
	private IEnumerator PreviewLevelBlockByBlock(Transform levelParent, Level level, LevelContext levelContext, Transform birdPlatformPosition)
	{
		return null;
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xA03D28", Offset = "0xA03D28", VA = "0xA03D28")]
	public void DespawnPreviewLevel(LevelContext levelContext, bool blockByBlock)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xA0037C", Offset = "0xA0037C", VA = "0xA0037C")]
	public bool IsDespawningPreview()
	{
		return default(bool);
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xA056FC", Offset = "0xA056FC", VA = "0xA056FC")]
	private void DespawnPreviewLevelInstant(LevelContext levelContext)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xA05664", Offset = "0xA05664", VA = "0xA05664")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76A48C", Offset = "0x76A48C")]
	private IEnumerator DespawnPreviewLevelBlockByBlock(LevelContext levelContext)
	{
		return null;
	}
}
[Token(Token = "0x2000080")]
public class LevelListContext
{
	[Token(Token = "0x2000208")]
	private struct Settings
	{
		[Token(Token = "0x4000E1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly bool isLocalOnly;

		[Token(Token = "0x4000E20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string orderBy;

		[Token(Token = "0x4000E21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string timeFilter;

		[Token(Token = "0x4000E22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string sorting;

		[Token(Token = "0x4000E23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CanBeNull]
		public readonly string userId;

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x7D8C30", Offset = "0x7D8C30", VA = "0x7D8C30")]
		public Settings(bool isLocalOnly, string orderBy, string timeFilter, string sorting, [CanBeNull] string userId)
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x7D8C44", Offset = "0x7D8C44", VA = "0x7D8C44")]
		public Settings(bool isLocalOnly)
		{
		}
	}

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly Settings settings;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Future<Page>> pages;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int currentPageIndex;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int currentLevelIndex;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public readonly string endpoint;

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xA0B078", Offset = "0xA0B078", VA = "0xA0B078")]
	public LevelListContext(NetworkHandler networkHandler, string orderBy, string timeFilter = "all_time", string sorting = "desc", [Optional] string userId)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xA0B664", Offset = "0xA0B664", VA = "0xA0B664")]
	public LevelListContext(IReadOnlyList<ServerLevelMetaData> metaDatas)
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xA0BC20", Offset = "0xA0BC20", VA = "0xA0BC20")]
	public bool TryGetLevel(int pageIndex, int levelIndex, out ServerLevelMetaData serverLevelMetaData, bool setCurrentIndices = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xA0C230", Offset = "0xA0C230", VA = "0xA0C230")]
	public bool TryGetNextLevel(out ServerLevelMetaData serverLevelMetaData)
	{
		return default(bool);
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xA0C6A4", Offset = "0xA0C6A4", VA = "0xA0C6A4")]
	public int GetCurrentPageIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xA0C6AC", Offset = "0xA0C6AC", VA = "0xA0C6AC")]
	public int GetCurrentLevelIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xA0C63C", Offset = "0xA0C63C", VA = "0xA0C63C")]
	public Future<Page> GetCurrentPage()
	{
		return null;
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xA0C520", Offset = "0xA0C520", VA = "0xA0C520")]
	public void ToNextPage()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xA0C6B4", Offset = "0xA0C6B4", VA = "0xA0C6B4")]
	public void ToPreviousPage()
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xA0C6C4", Offset = "0xA0C6C4", VA = "0xA0C6C4")]
	public void ToFirstPage()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xA0BF50", Offset = "0xA0BF50", VA = "0xA0BF50")]
	private bool HasCachedNextPage([Optional] int? nextPageIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xA0C6CC", Offset = "0xA0C6CC", VA = "0xA0C6CC")]
	public bool ContainsPageAtIndex(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xA0C0AC", Offset = "0xA0C0AC", VA = "0xA0C0AC")]
	public bool DoesNextPageExist()
	{
		return default(bool);
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xA0C744", Offset = "0xA0C744", VA = "0xA0C744")]
	public void Refresh()
	{
	}
}
[Token(Token = "0x2000081")]
[DisallowMultipleComponent]
public class MeshParticleSystemComponent : MonoBehaviour
{
	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystemRenderer particleSystemRenderer;

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x95C6DC", Offset = "0x95C6DC", VA = "0x95C6DC")]
	public MeshParticleSystemComponent()
	{
	}
}
[Token(Token = "0x2000082")]
public class APIError : Exception
{
	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public string title;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public string description;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string code;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public UnityWebRequest request;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public PlayFabException playFabException;

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x99A9F8", Offset = "0x99A9F8", VA = "0x99A9F8")]
	public APIError(UnityWebRequest request, [Optional] PlayFabException pfException)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x99AA78", Offset = "0x99AA78", VA = "0x99AA78")]
	public APIError(string title, UnityWebRequest request, [Optional] Exception innerException)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x99AB48", Offset = "0x99AB48", VA = "0x99AB48")]
	public APIError(string title, string exceptionDescription)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x99ABE8", Offset = "0x99ABE8", VA = "0x99ABE8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000083")]
public class Future<T>
{
	[Token(Token = "0x2000209")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767224", Offset = "0x767224")]
	private sealed class <WaitUntilResolved>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000E25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		[Token(Token = "0x4000E26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Future<T> <>4__this;

		[Token(Token = "0x17000105")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009F8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009FA")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009F5")]
		[DebuggerHidden]
		public <WaitUntilResolved>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60009F6")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009F7")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009F9")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private T result;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool resolved;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Exception exc;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float startingTime;

	[Token(Token = "0x600026D")]
	public Future()
	{
	}

	[Token(Token = "0x600026E")]
	public bool IsResolved()
	{
		return default(bool);
	}

	[Token(Token = "0x600026F")]
	public void SetResult(T r)
	{
	}

	[Token(Token = "0x6000270")]
	public void SetError(Exception e, string url = "", string errorCode = "")
	{
	}

	[Token(Token = "0x6000271")]
	public T GetResult()
	{
		return (T)null;
	}

	[Token(Token = "0x6000272")]
	public bool TryGetResult(out T result)
	{
		return default(bool);
	}

	[Token(Token = "0x6000273")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76A4F0", Offset = "0x76A4F0")]
	public IEnumerator WaitUntilResolved()
	{
		return null;
	}

	[Token(Token = "0x6000274")]
	public void Reset()
	{
	}
}
[Token(Token = "0x2000084")]
public sealed class NetworkHandler
{
	[Token(Token = "0x200020A")]
	private class RequestData
	{
		[Token(Token = "0x4000E27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x769EFC", Offset = "0x769EFC")]
		private string <Url>k__BackingField;

		[Token(Token = "0x4000E28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RequestType type;

		[Token(Token = "0x4000E29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WWWForm optionalForm;

		[Token(Token = "0x4000E2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string optionalPostData;

		[Token(Token = "0x17000107")]
		public string Url
		{
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x95DE08", Offset = "0x95DE08", VA = "0x95DE08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76BE98", Offset = "0x76BE98")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x95EEEC", Offset = "0x95EEEC", VA = "0x95EEEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76BE88", Offset = "0x76BE88")]
			private set
			{
			}
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x95EDAC", Offset = "0x95EDAC", VA = "0x95EDAC")]
		public UnityWebRequest ToUnityWebRequest()
		{
			return null;
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x95CD08", Offset = "0x95CD08", VA = "0x95CD08")]
		public static RequestData Get(string url)
		{
			return null;
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x95CF60", Offset = "0x95CF60", VA = "0x95CF60")]
		public static RequestData Post(string url, WWWForm form)
		{
			return null;
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x95D1B0", Offset = "0x95D1B0", VA = "0x95D1B0")]
		public static RequestData Post(string url, string postData)
		{
			return null;
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x95EEF4", Offset = "0x95EEF4", VA = "0x95EEF4")]
		public RequestData()
		{
		}
	}

	[Token(Token = "0x200020B")]
	private enum RequestType
	{
		[Token(Token = "0x4000E2C")]
		Get,
		[Token(Token = "0x4000E2D")]
		Post
	}

	[Serializable]
	[Token(Token = "0x200020C")]
	private class ServerLevelMetaDataCollection
	{
		[Token(Token = "0x4000E2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ServerLevelMetaData[] levels;

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x95EEFC", Offset = "0x95EEFC", VA = "0x95EEFC")]
		public ServerLevelMetaDataCollection()
		{
		}
	}

	[Token(Token = "0x200020D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767234", Offset = "0x767234")]
	private sealed class <PerformHttpRequest>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000E30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000E31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RequestData requestData;

		[Token(Token = "0x4000E32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NetworkHandler <>4__this;

		[Token(Token = "0x4000E33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<APIError> onFailure;

		[Token(Token = "0x4000E34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<UnityWebRequest> onSuccess;

		[Token(Token = "0x4000E35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <request>5__2;

		[Token(Token = "0x4000E36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool <hasSucceededOrRetried>5__3;

		[Token(Token = "0x17000108")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x95EE74", Offset = "0x95EE74", VA = "0x95EE74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000109")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x95EEE4", Offset = "0x95EEE4", VA = "0x95EEE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x95C9C8", Offset = "0x95C9C8", VA = "0x95C9C8")]
		[DebuggerHidden]
		public <PerformHttpRequest>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x95E6E8", Offset = "0x95E6E8", VA = "0x95E6E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x95E6EC", Offset = "0x95E6EC", VA = "0x95E6EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x95EE7C", Offset = "0x95EE7C", VA = "0x95EE7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200020E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767244", Offset = "0x767244")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000E37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Future<string[]> f;

		[Token(Token = "0x4000E38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RequestData requestData;

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x95CD00", Offset = "0x95CD00", VA = "0x95CD00")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x95DC04", Offset = "0x95DC04", VA = "0x95DC04")]
		internal void <RetrieveUsernameSuggestions>b__0(UnityWebRequest response)
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x95DD70", Offset = "0x95DD70", VA = "0x95DD70")]
		internal void <RetrieveUsernameSuggestions>b__1(APIError error)
		{
		}
	}

	[Token(Token = "0x200020F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767254", Offset = "0x767254")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000E39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Future<ServerLevelMetaData> f;

		[Token(Token = "0x4000E3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RequestData requestData;

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x95CF58", Offset = "0x95CF58", VA = "0x95CF58")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x95DE10", Offset = "0x95DE10", VA = "0x95DE10")]
		internal void <UploadLevel>b__0(UnityWebRequest response)
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x95DEC4", Offset = "0x95DEC4", VA = "0x95DEC4")]
		internal void <UploadLevel>b__1(APIError error)
		{
		}
	}

	[Token(Token = "0x2000210")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767264", Offset = "0x767264")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000E3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Future<bool> f;

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x95D1A8", Offset = "0x95D1A8", VA = "0x95D1A8")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x95DF5C", Offset = "0x95DF5C", VA = "0x95DF5C")]
		internal void <SelectUsername>b__0(UnityWebRequest response)
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x95DFF4", Offset = "0x95DFF4", VA = "0x95DFF4")]
		internal void <SelectUsername>b__1(APIError error)
		{
		}
	}

	[Token(Token = "0x2000211")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767274", Offset = "0x767274")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000E3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Future<bool> f;

		[Token(Token = "0x4000E3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RequestData webRequest;

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x95D404", Offset = "0x95D404", VA = "0x95D404")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x95E0B0", Offset = "0x95E0B0", VA = "0x95E0B0")]
		internal void <UnshareLevel>b__0(UnityWebRequest response)
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x95E114", Offset = "0x95E114", VA = "0x95E114")]
		internal void <UnshareLevel>b__1(APIError error)
		{
		}
	}

	[Token(Token = "0x2000212")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767284", Offset = "0x767284")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000E3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Future<ServerLevelMetaData> f;

		[Token(Token = "0x4000E3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RequestData webRequest;

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x95D5B0", Offset = "0x95D5B0", VA = "0x95D5B0")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x95E1AC", Offset = "0x95E1AC", VA = "0x95E1AC")]
		internal void <RequestLevel>b__0(UnityWebRequest response)
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x95E260", Offset = "0x95E260", VA = "0x95E260")]
		internal void <RequestLevel>b__1(APIError error)
		{
		}
	}

	[Token(Token = "0x2000213")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767294", Offset = "0x767294")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000E40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Future<ServerLevelMetaData> f;

		[Token(Token = "0x4000E41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RequestData webRequest;

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x95D754", Offset = "0x95D754", VA = "0x95D754")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x95E2F8", Offset = "0x95E2F8", VA = "0x95E2F8")]
		internal void <RequestRandomLevel>b__0(UnityWebRequest response)
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x95E3AC", Offset = "0x95E3AC", VA = "0x95E3AC")]
		internal void <RequestRandomLevel>b__1(APIError error)
		{
		}
	}

	[Token(Token = "0x2000214")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7672A4", Offset = "0x7672A4")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x4000E42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Future<ServerLevelMetaData[]> f;

		[Token(Token = "0x4000E43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RequestData webRequest;

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x95D924", Offset = "0x95D924", VA = "0x95D924")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x95E444", Offset = "0x95E444", VA = "0x95E444")]
		internal void <UpdateMetadata>b__0(UnityWebRequest response)
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x95E504", Offset = "0x95E504", VA = "0x95E504")]
		internal void <UpdateMetadata>b__1(APIError error)
		{
		}
	}

	[Token(Token = "0x2000215")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7672B4", Offset = "0x7672B4")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x4000E44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Future<Page> f;

		[Token(Token = "0x4000E45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RequestData webRequest;

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x95DB4C", Offset = "0x95DB4C", VA = "0x95DB4C")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x95E59C", Offset = "0x95E59C", VA = "0x95E59C")]
		internal void <FetchPageOfLevels>b__0(UnityWebRequest response)
		{
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x95E650", Offset = "0x95E650", VA = "0x95E650")]
		internal void <FetchPageOfLevels>b__1(APIError error)
		{
		}
	}

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ConnectionHandler connectionHandler;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string url;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly WaitForSeconds oneAndAHalfSecond;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int numberOfRetries;

	[Token(Token = "0x40003D8")]
	private const int TOTAL_NUMBER_OF_RETRIES = 3;

	[Token(Token = "0x17000012")]
	public bool HasFetchedUser
	{
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x95C718", Offset = "0x95C718", VA = "0x95C718")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public string ClientUserId
	{
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x95C764", Offset = "0x95C764", VA = "0x95C764")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000014")]
	public string ClientAuthToken
	{
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x95C794", Offset = "0x95C794", VA = "0x95C794")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000015")]
	public User User
	{
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x95C734", Offset = "0x95C734", VA = "0x95C734")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x95C7C4", Offset = "0x95C7C4", VA = "0x95C7C4")]
	public NetworkHandler(MonoBehaviour monoBehaviour, InputHandler inputHandler)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x95C89C", Offset = "0x95C89C", VA = "0x95C89C")]
	public bool HasInternetConnection()
	{
		return default(bool);
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x95C8CC", Offset = "0x95C8CC", VA = "0x95C8CC")]
	public bool IsUserBanned()
	{
		return default(bool);
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x95C8FC", Offset = "0x95C8FC", VA = "0x95C8FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76A554", Offset = "0x76A554")]
	private IEnumerator PerformHttpRequest(RequestData requestData, Action<UnityWebRequest> onSuccess, Action<APIError> onFailure)
	{
		return null;
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x95C9F4", Offset = "0x95C9F4", VA = "0x95C9F4")]
	public Future<User> GetUserData(string playFabId)
	{
		return null;
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x95CA8C", Offset = "0x95CA8C", VA = "0x95CA8C")]
	public Future<bool> SetUserData(params (string, object)[] data)
	{
		return null;
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x95CB64", Offset = "0x95CB64", VA = "0x95CB64")]
	public Future<string[]> RetrieveUsernameSuggestions()
	{
		return null;
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x95CD90", Offset = "0x95CD90", VA = "0x95CD90")]
	public Future<ServerLevelMetaData> UploadLevel(Level level)
	{
		return null;
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x95D010", Offset = "0x95D010", VA = "0x95D010")]
	public Future<bool> SelectUsername(string username)
	{
		return null;
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x95D260", Offset = "0x95D260", VA = "0x95D260")]
	public Future<bool> UnshareLevel(string levelId)
	{
		return null;
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x95D40C", Offset = "0x95D40C", VA = "0x95D40C")]
	public Future<ServerLevelMetaData> RequestLevel(string levelId)
	{
		return null;
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x95D5B8", Offset = "0x95D5B8", VA = "0x95D5B8")]
	public Future<ServerLevelMetaData> RequestRandomLevel()
	{
		return null;
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x95D75C", Offset = "0x95D75C", VA = "0x95D75C")]
	public Future<ServerLevelMetaData[]> UpdateMetadata(string[] levelCodes)
	{
		return null;
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x95D92C", Offset = "0x95D92C", VA = "0x95D92C")]
	public void ReportLevel(ServerLevelMetaData metaData, string reportMessage)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x95D9A4", Offset = "0x95D9A4", VA = "0x95D9A4")]
	public Future<Page> FetchPageOfLevels(string url)
	{
		return null;
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x95DB54", Offset = "0x95DB54", VA = "0x95DB54")]
	public LevelListContext GetLevelsList(string orderBy, string sorting = "desc", bool lastWeekOnly = false, [Optional] string userId)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000085")]
public class ServerLevelMetaData
{
	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint successes;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public uint dislikes;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public uint reports;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public uint plays;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public uint favorites;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public uint likes;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint fails;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public long delete_ts;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public long uploaded_ts;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float popularity;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float difficulty;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string code;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string user_id;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string data;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Level levelCache;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ThreadJob<Level> loadLevelJob;

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x9E9704", Offset = "0x9E9704", VA = "0x9E9704")]
	public ThreadJob<Level> GetLevelJob()
	{
		return null;
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x9E8978", Offset = "0x9E8978", VA = "0x9E8978")]
	public Level GetLevel()
	{
		return null;
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x9E9738", Offset = "0x9E9738", VA = "0x9E9738")]
	public ServerLevelMetaData(string code)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x9E9764", Offset = "0x9E9764", VA = "0x9E9764")]
	public ServerLevelMetaData()
	{
	}
}
[Serializable]
[Token(Token = "0x2000086")]
public class User
{
	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string username;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int imageId;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] removedLevels;

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x10F5C20", Offset = "0x10F5C20", VA = "0x10F5C20")]
	public User(Dictionary<string, UserDataRecord> data)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x10F5F9C", Offset = "0x10F5F9C", VA = "0x10F5F9C")]
	public void SetUserData(params (string, object)[] data)
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x10F61F0", Offset = "0x10F61F0", VA = "0x10F61F0")]
	public Dictionary<string, string> ToDictionary()
	{
		return null;
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x10F62CC", Offset = "0x10F62CC", VA = "0x10F62CC")]
	public bool HasCreatedProfile()
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000087")]
public class AuthenticationInfo
{
	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string token;

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x99C208", Offset = "0x99C208", VA = "0x99C208")]
	public AuthenticationInfo()
	{
	}
}
[Token(Token = "0x2000088")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x7664D4", Offset = "0x7664D4")]
public class NetworkSettings : SingletonScriptableObject<NetworkSettings>
{
	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string levelStorageUrl;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int timeout;

	[Token(Token = "0x17000016")]
	protected override bool KeepInResources
	{
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x95EF04", Offset = "0x95EF04", VA = "0x95EF04", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000017")]
	public string LevelStorageUrl
	{
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x95C894", Offset = "0x95C894", VA = "0x95C894")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000018")]
	public int Timeout
	{
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x95EE6C", Offset = "0x95EE6C", VA = "0x95EE6C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x95EF0C", Offset = "0x95EF0C", VA = "0x95EF0C")]
	public NetworkSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x2000089")]
public class ServerLevelMetaDataCollections
{
	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<ServerLevelMetaData> levelOnlineMetaDatas;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<ServerLevelMetaDataUserPair> favoritesMetaDataUserPairs;

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x9E976C", Offset = "0x9E976C", VA = "0x9E976C")]
	public ServerLevelMetaDataCollections()
	{
	}
}
[Serializable]
[Token(Token = "0x200008A")]
public class ServerLevelMetaDataUserPair
{
	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ServerLevelMetaData metadata;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public User user;

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x9E9774", Offset = "0x9E9774", VA = "0x9E9774")]
	public ServerLevelMetaDataUserPair(ServerLevelMetaData metadata, User user)
	{
	}
}
[Token(Token = "0x200008B")]
public class OutroComponent : MonoBehaviour
{
	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator balloonAnimator;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleEffectComponent despawnEffect;

	[NonSerialized]
	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool done;

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x9641B4", Offset = "0x9641B4", VA = "0x9641B4")]
	public OutroComponent()
	{
	}
}
[Token(Token = "0x200008C")]
public class OutroHandler
{
	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly OutroSettings outroSettings;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly OutroComponent outro;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool playing;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private GameState nextGameState;

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x9641C4", Offset = "0x9641C4", VA = "0x9641C4")]
	public OutroHandler(InputHandler inputHandler, PalazzoTriggers palazzoTriggers, OutroSettings outroSettings, OutroComponent outro, PalazzoGameDataPersistent gameDataPersistent)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x96430C", Offset = "0x96430C", VA = "0x96430C")]
	public GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x9646E8", Offset = "0x9646E8", VA = "0x9646E8")]
	public void Start()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x96421C", Offset = "0x96421C", VA = "0x96421C")]
	public void Reset()
	{
	}
}
[Token(Token = "0x200008D")]
public static class PalazzoAux
{
	[Token(Token = "0x2000216")]
	public sealed class PidScalar
	{
		[Token(Token = "0x4000E46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float kp;

		[Token(Token = "0x4000E47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float ki;

		[Token(Token = "0x4000E48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float kd;

		[Token(Token = "0x4000E49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float integral;

		[Token(Token = "0x4000E4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float errorPrev;

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x967990", Offset = "0x967990", VA = "0x967990")]
		public void ResetCache()
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x967998", Offset = "0x967998", VA = "0x967998")]
		public float Tick(float error, float dt)
		{
			return default(float);
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x9679D4", Offset = "0x9679D4", VA = "0x9679D4")]
		public PidScalar()
		{
		}
	}

	[Token(Token = "0x2000217")]
	private struct VertInfo
	{
		[Token(Token = "0x4000E4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 vert;

		[Token(Token = "0x4000E4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int origIndex;

		[Token(Token = "0x4000E4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 normal;

		[Token(Token = "0x4000E4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 averagedNormal;
	}

	[Serializable]
	[Token(Token = "0x2000218")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7672C4", Offset = "0x7672C4")]
	private sealed class <>c__10<T>
	{
		[Token(Token = "0x4000E4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c__10<T> <>9;

		[Token(Token = "0x4000E50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<object, T> <>9__10_0;

		[Token(Token = "0x6000A25")]
		public <>c__10()
		{
		}

		[Token(Token = "0x6000A26")]
		internal T <EnumToArray>b__10_0(object o)
		{
			return (T)null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000219")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7672D4", Offset = "0x7672D4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000E51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000E52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<VertInfo, Vector3> <>9__30_0;

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x9678EC", Offset = "0x9678EC", VA = "0x9678EC")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x9678F4", Offset = "0x9678F4", VA = "0x9678F4")]
		internal Vector3 <AvarageMeshNormals>b__30_0(VertInfo x)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200021A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7672E4", Offset = "0x7672E4")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000E53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type requirement;

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x96765C", Offset = "0x96765C", VA = "0x96765C")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x967900", Offset = "0x967900", VA = "0x967900")]
		internal bool <Requires>b__0(RequireComponent rc)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200021B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7672F4", Offset = "0x7672F4")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000E54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type t;

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x967758", Offset = "0x967758", VA = "0x967758")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x967954", Offset = "0x967954", VA = "0x967954")]
		internal bool <CanDestroy>b__0(Component c)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40003FD")]
	private const float SHOW_NEXT_DOT_TIME = 0.2f;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float dotTimer;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int dotIndex;

	[Token(Token = "0x4000400")]
	private const float TRAJECTORY_VELOCITY_MUL = 0.015f;

	[Token(Token = "0x4000401")]
	private const float GUI_ANGLE_THRESHOLD = 15f;

	[Token(Token = "0x600029D")]
	public static void ReplaceWithLast<T>(List<T> li, ref int i, ref int n)
	{
	}

	[Token(Token = "0x600029E")]
	public static void ReplaceWithLast<T>(List<T> li, T obj)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x964A24", Offset = "0x964A24", VA = "0x964A24")]
	public static int Mod(int a, int b)
	{
		return default(int);
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x964AA4", Offset = "0x964AA4", VA = "0x964AA4")]
	public static float Mod(float a, float b)
	{
		return default(float);
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x964B2C", Offset = "0x964B2C", VA = "0x964B2C")]
	public static Vector3 x0z(Vector3 v)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x964B34", Offset = "0x964B34", VA = "0x964B34")]
	public static Vector3 xy0(Vector3 v)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002A3")]
	public static T[] EnumToArray<T>()
	{
		return null;
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x964B3C", Offset = "0x964B3C", VA = "0x964B3C")]
	public static void DisconnectFromJointBeforeDestroy(SpringJoint joint)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x964BA4", Offset = "0x964BA4", VA = "0x964BA4")]
	public static Vector3 CalcTrajectoryVelocity(Vector3 handDirection)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x964C5C", Offset = "0x964C5C", VA = "0x964C5C")]
	public static Vector3 CalcLevelGuiPosition(ARTransforms arTransforms, InputHandler inputHandler, WorldContext worldContext, MenuSettings menuSettings)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x964F64", Offset = "0x964F64", VA = "0x964F64")]
	public static Quaternion CalcLevelGuiRotation(ARTransforms arTransforms, InputHandler inputHandler, WorldContext worldContext)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x965164", Offset = "0x965164", VA = "0x965164")]
	public static bool CalcLevelGuiTransformHasChanged(ARTransforms arTransforms, InputHandler inputHandler, WorldContext worldContext, Transform tfm)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x96527C", Offset = "0x96527C", VA = "0x96527C")]
	public static string CalcVisibleLevelName(int levelIndex, string levelNameStringId, PalazzoWorld[] worldPrefabs)
	{
		return null;
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x962C24", Offset = "0x962C24", VA = "0x962C24")]
	public static string GetLocalizedString(string stringId)
	{
		return null;
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x965558", Offset = "0x965558", VA = "0x965558")]
	public static void SetVisisbleLevelName(LocalizedText localizedText, TMP_Text tmpText, int levelIndex, string levelNameStringId, PalazzoWorld[] worldPrefabs)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x965708", Offset = "0x965708", VA = "0x965708")]
	public static void SetCustomLevelString(TMP_Text tmpText, int levelId)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x96203C", Offset = "0x96203C", VA = "0x96203C")]
	public static void SetUserNameString(TMP_Text tmpText, string userName)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x9657B4", Offset = "0x9657B4", VA = "0x9657B4")]
	public static void SetSpookyWorldHoverString(TMP_Text tmpText, string completedLevels)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x965838", Offset = "0x965838", VA = "0x965838")]
	public static Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x965A00", Offset = "0x965A00", VA = "0x965A00")]
	public static void SetKinematic(Rigidbody rb, bool isKinematic)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x965A8C", Offset = "0x965A8C", VA = "0x965A8C")]
	public static float CalcVolume(Bounds bounds)
	{
		return default(float);
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x965AAC", Offset = "0x965AAC", VA = "0x965AAC")]
	public static void AddHighlight(Renderer renderer, Material highlightMaterial)
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x965C90", Offset = "0x965C90", VA = "0x965C90")]
	public static void RemoveHighlight(Renderer renderer, Material highlightMaterial)
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x965E58", Offset = "0x965E58", VA = "0x965E58")]
	public static void AvarageMeshNormals(Mesh[] meshes)
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x966C0C", Offset = "0x966C0C", VA = "0x966C0C")]
	public static Vector3 CalcLocalSpaceInOtherTransformSpace(Transform local, Transform otherTransform)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x961698", Offset = "0x961698", VA = "0x961698")]
	public static void SpinWheel(Transform spinTransform, bool clockwise = false)
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x9640B8", Offset = "0x9640B8", VA = "0x9640B8")]
	public static void ResetLoadingDots(LoadingDots loadingDots)
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x9614CC", Offset = "0x9614CC", VA = "0x9614CC")]
	public static void UpdateLoadingDots(LoadingDots loadingDots)
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x963EE4", Offset = "0x963EE4", VA = "0x963EE4")]
	public static bool TryToggleFavorite(PalazzoButton button, ServerLevelMetaData metaData, User user, NetworkHandler networkHandler)
	{
		return default(bool);
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x967084", Offset = "0x967084", VA = "0x967084")]
	public static void ToggleLocalFavorite(PalazzoButton button, Level level)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x9674E0", Offset = "0x9674E0", VA = "0x9674E0")]
	private static bool Requires(Type obj, Type requirement)
	{
		return default(bool);
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x967664", Offset = "0x967664", VA = "0x967664")]
	public static bool CanDestroy(this GameObject go, Type t)
	{
		return default(bool);
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x967760", Offset = "0x967760", VA = "0x967760")]
	public static bool CanMoveToNextLevel(LevelContext levelContext, List<string> levelGuids, PalazzoGameDataPersistent gameDataPersistent)
	{
		return default(bool);
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x962AD4", Offset = "0x962AD4", VA = "0x962AD4")]
	public static string FormatLargeNumber(int number)
	{
		return null;
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x962CC4", Offset = "0x962CC4", VA = "0x962CC4")]
	public static string FormatTimeSpan(long timeStamp)
	{
		return null;
	}
}
[Token(Token = "0x200008E")]
public enum BirdFlightState
{
	[Token(Token = "0x4000403")]
	OnGround,
	[Token(Token = "0x4000404")]
	OnPlatform,
	[Token(Token = "0x4000405")]
	MovingToPlatform,
	[Token(Token = "0x4000406")]
	MovingToSlingshot,
	[Token(Token = "0x4000407")]
	InSlingshot,
	[Token(Token = "0x4000408")]
	InFlight,
	[Token(Token = "0x4000409")]
	Dead
}
[Token(Token = "0x200008F")]
public enum BirdMoveState
{
	[Token(Token = "0x400040B")]
	Init,
	[Token(Token = "0x400040C")]
	Idle,
	[Token(Token = "0x400040D")]
	RotateToMoveEnter,
	[Token(Token = "0x400040E")]
	RotateToMove,
	[Token(Token = "0x400040F")]
	Move,
	[Token(Token = "0x4000410")]
	RotateToStopEnter,
	[Token(Token = "0x4000411")]
	RotateToStop
}
[Token(Token = "0x2000090")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7664F4", Offset = "0x7664F4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7664F4", Offset = "0x7664F4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7664F4", Offset = "0x7664F4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7664F4", Offset = "0x7664F4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7664F4", Offset = "0x7664F4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7664F4", Offset = "0x7664F4")]
public sealed class PalazzoComponentBird : MonoBehaviour
{
	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PalazzoComponentLevelBlock levelBlock;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Rigidbody rb;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SphereCollider col;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator anim;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public InteractiveCharacterComponent character;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem trail;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float birdStartScale;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string soundStretch;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string soundLaunch;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string soundJumpToSlingshot;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string soundSpecialAbility;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string soundHitTeleportationPoint;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ParticleEffectComponent prefabLaunchFx;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ParticleEffectComponent prefabSpecialAbilityFx;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TrailRenderer optionalSpeedTrail;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public ParticleSystem optionalFuseEffect;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public SkinnedMeshRenderer optionalSkinnedMeshRenderer;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float optionalExplosionCountdown;

	[NonSerialized]
	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public BirdImpactQueue birdImpactQueue;

	[NonSerialized]
	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public BirdFlightState flightState;

	[NonSerialized]
	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public BirdMoveState moveState;

	[NonSerialized]
	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Vector3 lastVelocity;

	[NonSerialized]
	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public float stayAliveForSeconds;

	[NonSerialized]
	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float impactMagnitude;

	[NonSerialized]
	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public float velocityRetainValue;

	[NonSerialized]
	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public bool hasImpacted;

	[NonSerialized]
	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
	public bool hasUsedSpecialAbility;

	[NonSerialized]
	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public readonly PalazzoAux.PidScalar pidRotation;

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x967AC4", Offset = "0x967AC4", VA = "0x967AC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x967BF0", Offset = "0x967BF0", VA = "0x967BF0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x967C30", Offset = "0x967C30", VA = "0x967C30")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x967C78", Offset = "0x967C78", VA = "0x967C78")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x967CC0", Offset = "0x967CC0", VA = "0x967CC0")]
	public PalazzoComponentBird()
	{
	}
}
[Token(Token = "0x2000091")]
[DisallowMultipleComponent]
public class PalazzoComponentBirdPlatform : MonoBehaviour
{
	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject highLight;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform[] birdPositions;

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x967DB4", Offset = "0x967DB4", VA = "0x967DB4")]
	public PalazzoComponentBirdPlatform()
	{
	}
}
[Token(Token = "0x2000092")]
[DisallowMultipleComponent]
public sealed class PalazzoComponentLevel : MonoBehaviour
{
	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LevelSettings levelSettings;

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x967DBC", Offset = "0x967DBC", VA = "0x967DBC")]
	public PalazzoComponentLevel()
	{
	}
}
[Token(Token = "0x2000093")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766650", Offset = "0x766650")]
public sealed class PalazzoComponentLevelBlock : MonoBehaviour
{
	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public int prefabPoolToken;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BlockTypeData blockTypeData;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Vector3 accumulatedExplosionForce;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Collider col;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Rigidbody optionalRigidbody;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public DamageComponent optionalDamageComponent;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public FanComponent optionalFanComponent;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public BalloonComponent optionalBalloonComponent;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ExplosionComponent optionalExplosionComponent;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public PalazzoComponentPig optionalPigComponent;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public PalazzoComponentBird optionalBirdComponent;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TeleportationComponent optionalTeleportationComponent;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public WindComponent optionalWindComponent;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public bool hasRigidbody;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public AlchemyComponent optionalAlchemyComponent;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public AlchemyExplosionComponent optionalAlchemyExplosionComponent;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Renderer optionalRendererComponent;

	[Token(Token = "0x17000019")]
	public BlockType BlockType
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x967DC4", Offset = "0x967DC4", VA = "0x967DC4")]
		get
		{
			return default(BlockType);
		}
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x967DF0", Offset = "0x967DF0", VA = "0x967DF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x967E6C", Offset = "0x967E6C", VA = "0x967E6C")]
	public PalazzoComponentLevelBlock()
	{
	}
}
[Token(Token = "0x2000094")]
public enum PigReactionState
{
	[Token(Token = "0x4000443")]
	Wait,
	[Token(Token = "0x4000444")]
	Scared,
	[Token(Token = "0x4000445")]
	Relieved,
	[Token(Token = "0x4000446")]
	Happy,
	[Token(Token = "0x4000447")]
	Mad,
	[Token(Token = "0x4000448")]
	ShowOff,
	[Token(Token = "0x4000449")]
	Falling,
	[Token(Token = "0x400044A")]
	Hanging
}
[Token(Token = "0x2000095")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7666C4", Offset = "0x7666C4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7666C4", Offset = "0x7666C4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7666C4", Offset = "0x7666C4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7666C4", Offset = "0x7666C4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7666C4", Offset = "0x7666C4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7666C4", Offset = "0x7666C4")]
public sealed class PalazzoComponentPig : MonoBehaviour
{
	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PalazzoComponentLevelBlock levelBlock;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Rigidbody rb;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SphereCollider col;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator anim;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public InteractiveCharacterComponent character;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SkinnedMeshRenderer skinnedMeshRenderer;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material halfBrokenMaterial;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material brokenMaterial;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public MeshFilter optionalHatMesh;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public MeshRenderer optionalHatMeshRenderer;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float optionalOtherBlockVelocityThreshold;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float optionalBossPigDamageMultiplier;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ParticleSystem scaredParticleSystem;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public PigEvenListener pigEvenListener;

	[NonSerialized]
	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public PigReactionState reactionState;

	[NonSerialized]
	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int? animationToPlayAfterDelay;

	[NonSerialized]
	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float delayBeforeAnimation;

	[NonSerialized]
	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool screaming;

	[NonSerialized]
	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool inFan;

	[NonSerialized]
	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
	public bool isHanging;

	[NonSerialized]
	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
	public bool isFalling;

	[NonSerialized]
	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool isGrounded;

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x967E74", Offset = "0x967E74", VA = "0x967E74")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x967EAC", Offset = "0x967EAC", VA = "0x967EAC")]
	public PalazzoComponentPig()
	{
	}
}
[Token(Token = "0x2000096")]
public sealed class PalazzoComponentPigBalloon : MonoBehaviour
{
	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x967EB4", Offset = "0x967EB4", VA = "0x967EB4")]
	public PalazzoComponentPigBalloon()
	{
	}
}
[Token(Token = "0x2000097")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766800", Offset = "0x766800")]
public sealed class PalazzoComponentSlingshot : MonoBehaviour
{
	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator anim;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform projectileLocation;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ParticleSystem pulseFX;

	[NonSerialized]
	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isAiming;

	[NonSerialized]
	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool isRubberbandInGrabRange;

	[NonSerialized]
	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float tensionMagnitude;

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x967EBC", Offset = "0x967EBC", VA = "0x967EBC")]
	public PalazzoComponentSlingshot()
	{
	}
}
[Token(Token = "0x2000098")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766874", Offset = "0x766874")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766874", Offset = "0x766874")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766874", Offset = "0x766874")]
public sealed class PalazzoComponentStar : MonoBehaviour
{
	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject starFX;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Animator animator;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string audioEventName;

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x967EC4", Offset = "0x967EC4", VA = "0x967EC4")]
	public PalazzoComponentStar()
	{
	}
}
[Token(Token = "0x2000099")]
public static class PalazzoDebug
{
	[Token(Token = "0x400046B")]
	public const KeyCode WIN_KEY = KeyCode.K;

	[Token(Token = "0x400046C")]
	public const KeyCode LOSE_KEY = KeyCode.L;

	[Token(Token = "0x400046D")]
	public const KeyCode RESET_LEVEL_KEY = KeyCode.R;

	[Token(Token = "0x400046E")]
	public const KeyCode TRIGGER_KEY = KeyCode.X;

	[Token(Token = "0x400046F")]
	public const KeyCode MENU_KEY = KeyCode.Z;

	[Token(Token = "0x4000470")]
	public const KeyCode SECONDARY_MENU_KEY = KeyCode.C;

	[Token(Token = "0x4000471")]
	public const KeyCode SWITCH_DESKTOP_MODE_KEY = KeyCode.Alpha1;

	[Token(Token = "0x4000472")]
	public const KeyCode SWITCH_FOV_MODE_KEY = KeyCode.Alpha2;

	[Token(Token = "0x4000473")]
	public const KeyCode PLACE_LEVEL_KEY = KeyCode.P;

	[Token(Token = "0x4000474")]
	public const KeyCode MOVE_LEFT_KEY = KeyCode.A;

	[Token(Token = "0x4000475")]
	public const KeyCode MOVE_RIGHT_KEY = KeyCode.D;

	[Token(Token = "0x4000476")]
	public const KeyCode MOVE_UP_KEY = KeyCode.E;

	[Token(Token = "0x4000477")]
	public const KeyCode MOVE_DOWN_KEY = KeyCode.Q;

	[Token(Token = "0x4000478")]
	public const KeyCode MOVE_FORWARD_KEY = KeyCode.W;

	[Token(Token = "0x4000479")]
	public const KeyCode MOVE_BACK_KEY = KeyCode.S;

	[Token(Token = "0x400047A")]
	public const KeyCode TURN_RIGHT = KeyCode.V;

	[Token(Token = "0x400047B")]
	public const KeyCode TURN_LEFT = KeyCode.C;

	[Token(Token = "0x400047C")]
	public const KeyCode STAMP_KEY = KeyCode.B;

	[Token(Token = "0x400047D")]
	public const KeyCode DELETE_KEY = KeyCode.N;

	[Token(Token = "0x400047E")]
	public const float MOVE_SPEED = 1f;

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x967ECC", Offset = "0x967ECC", VA = "0x967ECC")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x76A5C8", Offset = "0x76A5C8")]
	public static void Spam(string msg)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x96804C", Offset = "0x96804C", VA = "0x96804C")]
	public static void Log(string msg)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x9653D8", Offset = "0x9653D8", VA = "0x9653D8")]
	public static void Warn(string msg)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x9681CC", Offset = "0x9681CC", VA = "0x9681CC")]
	public static void Error(string msg)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x96834C", Offset = "0x96834C", VA = "0x96834C")]
	public static bool SwitchFovMode()
	{
		return default(bool);
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x968358", Offset = "0x968358", VA = "0x968358")]
	public static bool PlaceLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x968364", Offset = "0x968364", VA = "0x968364")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x76A600", Offset = "0x76A600")]
	public static void CheckWin(LevelContext levelContext)
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x968510", Offset = "0x968510", VA = "0x968510")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x76A638", Offset = "0x76A638")]
	public static void CheckLose(LevelContext levelContext)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x968608", Offset = "0x968608", VA = "0x968608")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x76A670", Offset = "0x76A670")]
	public static void CheckResetLevel(LevelFactory levelFactory, LevelContext levelContext, SlingshotAimHandler slingshotAimHandler, SlingshotLoader slingshotLoader, BirdsRemainingHandler birdsRemainingHandler, InputHandler inputHandler)
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x9686B8", Offset = "0x9686B8", VA = "0x9686B8")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x76A6A8", Offset = "0x76A6A8")]
	public static void DrawHandForward(ARTransforms arTransforms, InputHandler inputHandler, InputType hand)
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x9688F4", Offset = "0x9688F4", VA = "0x9688F4")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x76A6E0", Offset = "0x76A6E0")]
	public static void DrawHeadForward(ARTransforms arTransforms, InputHandler inputHandler)
	{
	}
}
[Token(Token = "0x200009A")]
public sealed class PalazzoEntryPoint : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200021C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767304", Offset = "0x767304")]
	private sealed class <>c
	{
		[Token(Token = "0x4000E55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000E56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<MeshFilter, Mesh> <>9__139_0;

		[Token(Token = "0x4000E57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<SkinnedMeshRenderer, Mesh> <>9__139_1;

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x96C0AC", Offset = "0x96C0AC", VA = "0x96C0AC")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x96C0B4", Offset = "0x96C0B4", VA = "0x96C0B4")]
		internal Mesh <Start>b__139_0(MeshFilter x)
		{
			return null;
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x96C0E4", Offset = "0x96C0E4", VA = "0x96C0E4")]
		internal Mesh <Start>b__139_1(SkinnedMeshRenderer x)
		{
			return null;
		}
	}

	[Token(Token = "0x200021D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767314", Offset = "0x767314")]
	private sealed class <Start>d__139 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000E59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000E5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PalazzoEntryPoint <>4__this;

		[Token(Token = "0x4000E5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <loadPlatformSceneAsync>5__2;

		[Token(Token = "0x4000E5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AsyncOperation <loadAdditiveSceneAsync>5__3;

		[Token(Token = "0x4000E5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private LevelBlockHelper <levelBlockHelper>5__4;

		[Token(Token = "0x4000E5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <impactMagnitudeThreshold>5__5;

		[Token(Token = "0x4000E5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PalazzoPlatform <palazzoPlatform>5__6;

		[Token(Token = "0x4000E60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextGroup[] <textGroups>5__7;

		[Token(Token = "0x4000E61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<GameObject, bool> <activeSelfLookup>5__8;

		[Token(Token = "0x4000E62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<GameObject, Transform> <parentLookup>5__9;

		[Token(Token = "0x4000E63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ShaderVariantCollection <svc>5__10;

		[Token(Token = "0x4000E64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int <i>5__11;

		[Token(Token = "0x4000E65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int <n>5__12;

		[Token(Token = "0x4000E66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int <i>5__13;

		[Token(Token = "0x4000E67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private WorldType[] <scenes>5__14;

		[Token(Token = "0x4000E68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string <sceneName>5__15;

		[Token(Token = "0x1700010A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x9729D4", Offset = "0x9729D4", VA = "0x9729D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x972A44", Offset = "0x972A44", VA = "0x972A44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x96A21C", Offset = "0x96A21C", VA = "0x96A21C")]
		[DebuggerHidden]
		public <Start>d__139(int <>1__state)
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x96DA68", Offset = "0x96DA68", VA = "0x96DA68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x96DA6C", Offset = "0x96DA6C", VA = "0x96DA6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x9729DC", Offset = "0x9729DC", VA = "0x9729DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200021E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767324", Offset = "0x767324")]
	private sealed class <LoadEnvironment>d__148 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000E6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WorldType newWorldScene;

		[Token(Token = "0x4000E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PalazzoEntryPoint <>4__this;

		[Token(Token = "0x4000E6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AsyncOperation <async>5__2;

		[Token(Token = "0x4000E6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WorldType <world>5__3;

		[Token(Token = "0x4000E6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <scene>5__4;

		[Token(Token = "0x1700010C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x96D9F0", Offset = "0x96D9F0", VA = "0x96D9F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x96DA60", Offset = "0x96DA60", VA = "0x96DA60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x96B41C", Offset = "0x96B41C", VA = "0x96B41C")]
		[DebuggerHidden]
		public <LoadEnvironment>d__148(int <>1__state)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x96D0D8", Offset = "0x96D0D8", VA = "0x96D0D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x96D0DC", Offset = "0x96D0DC", VA = "0x96D0DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x96D9F8", Offset = "0x96D9F8", VA = "0x96D9F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200021F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767334", Offset = "0x767334")]
	private sealed class <DespawnLevel>d__149 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000E71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000E72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PalazzoEntryPoint <>4__this;

		[Token(Token = "0x1700010E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x96D060", Offset = "0x96D060", VA = "0x96D060", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x96D0D0", Offset = "0x96D0D0", VA = "0x96D0D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x96B4BC", Offset = "0x96B4BC", VA = "0x96B4BC")]
		[DebuggerHidden]
		public <DespawnLevel>d__149(int <>1__state)
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x96CE34", Offset = "0x96CE34", VA = "0x96CE34", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x96CE38", Offset = "0x96CE38", VA = "0x96CE38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x96D068", Offset = "0x96D068", VA = "0x96D068", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000220")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767344", Offset = "0x767344")]
	private sealed class <DelayedClickEndOfLevelScreen>d__150 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000E74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000E75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PalazzoEntryPoint <>4__this;

		[Token(Token = "0x4000E76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ScoreBoardButtonType buttonType;

		[Token(Token = "0x4000E77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<GameState> nextGameState;

		[Token(Token = "0x4000E78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ThreadJob<Level> <getLevelJob>5__2;

		[Token(Token = "0x17000110")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x96CDBC", Offset = "0x96CDBC", VA = "0x96CDBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000111")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x96CE2C", Offset = "0x96CE2C", VA = "0x96CE2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x96B598", Offset = "0x96B598", VA = "0x96B598")]
		[DebuggerHidden]
		public <DelayedClickEndOfLevelScreen>d__150(int <>1__state)
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x96C114", Offset = "0x96C114", VA = "0x96C114", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x96C118", Offset = "0x96C118", VA = "0x96C118", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x96CDC4", Offset = "0x96CDC4", VA = "0x96CDC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400047F")]
	public const string PLATFORM_NAME = "SantaCruz";

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly WaitForSeconds endOfLevelDelaySeconds;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool isShaderWarmedUp;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7677D0", Offset = "0x7677D0")]
	[SerializeField]
	private Transform prefabPoolContainer;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ScoreEffectComponent blockScoreEffectComponentPrefab;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ScoreEffectComponent birdScoreEffectComponentPrefab;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ScoreEffectComponent pigScoreEffectComponentPrefab;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private PalazzoWorld[] worldPrefabs;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ParticleEffectComponent[] particleEffectPrefabs;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private PalazzoComponentLevelBlock[] levelBlockPrefabs;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private int[] levelBlockPrefabMaxCount;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private CutsceneComponent[] cutscenes;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private LevelEditorVRController vrControllerLevelEditor;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7678AC", Offset = "0x7678AC")]
	[SerializeField]
	private bool isTwoHanded;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Material[] allMaterials;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Mesh warmUpMesh;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private PalazzoShaderVariant[] arShaderVariantCollection;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private TensionHand tensionHand;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private CameraFadeComponent cameraFadeComponent;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Transform tutorialPlacement;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private IntroComponent intro;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private OutroComponent outro;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private GameObject outOfBoundsText;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private AudioMixerGroup musicAudioGroup;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private AudioMixerGroup soundAudioGroup;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private AmbientAudioComponent ambientAudioComponent;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private PlayStateSettings playStateSettings;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private EnvironmentEffects environmentEffects;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private UiPrefabs uiPrefabs;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private StartScreen startScreen;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private WorldSelectMenu worldSelectMenu;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private LevelSelect levelSelect;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private SettingsMenu settingsMenu;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private PrivacyMenu privacyMenu;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private GameObject noEntitlementScreen;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private RecoveryMenu recoveryMenu;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private ErrorMenu networkErrorMenu;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private ErrorMenu favoriteErrorMenu;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private TutorialComponent tutorialComponent;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private LevelEditorComponent levelEditor;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private Toolbox toolbox;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private PauseScreen[] pauseScreens;

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private ScoreboardBase[] scoreboards;

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private LoseScreen[] loseScreens;

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private SplitMenu[] splitMenus;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private RatingScreen ratingScreen;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private CreateUserMenu createUserMenu;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private ReportMenu reportMenu;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767A08", Offset = "0x767A08")]
	[SerializeField]
	private ARTransforms arTransforms;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[SerializeField]
	private PhysicsSettings physicsSettings;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	private DamageSettings damageSettings;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	private SlingshotSettings slingshotSettingsOneHanded;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	private SlingshotSettings slingshotSettingsTwoHanded;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	private TrajectoryMarkerSettings trajectoryMarkerSettings;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	private TensionHandSettings tensionHandSettings;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	private ScoreboardSettings scoreboardSettings;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	private Transform[] characterLookAtTargets;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	private LevelSelectSettings levelSelectSettings;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	private MenuSettings menuSettings;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	private TutorialSettings tutorialSettings;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	[SerializeField]
	private OutroSettings outroSettings;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	private ToolboxSettings toolboxSettings;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	[SerializeField]
	private LevelEditorSettings levelEditorSettings;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	[SerializeField]
	private FontSettings fontSettings;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	[SerializeField]
	private CreateUserSettings createUserSettings;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private int[] themeLevelCount;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private float defaultMusicVolume;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	private float defaultSoundVolume;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private GameStateData gameStateData;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private PalazzoComponentLevel[] levelPrefabs;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private readonly MenuContext menuContext;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private readonly ScoreboardContext scoreboardContext;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private readonly List<string> levelSelectGuids;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private LimitedPool<ScoreEffectComponent>[] scoreEffectPrefabPoolLookup;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private ParticleEffectComponent[] particleEffectPrefabPoolLookup;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private ComponentPrefabPool<PalazzoComponentLevelBlock>[] levelBlockPrefabPoolLookup;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private DamageQueue damageQueue;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private BirdImpactQueue birdImpactQueue;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	private WorldImpactQueue worldImpactQueue;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private HealthBarData healthBarData;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	private EffectQueue effectQueue;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	private readonly Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private readonly Dictionary<int, WorldImpactComponent> colliderWorldImpactLookup;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	private EffectOnImpactQueue effectOnImpactQueue;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	private InputHandler inputHandler;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	private AchievementHandler achievementHandler;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	private NetworkHandler networkHandler;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	private PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	private LevelBlockFactory levelBlockFactory;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	private LevelFactory levelFactory;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	private TeleportationHandler teleportationHandler;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	private WorldTracker worldTracker;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	private TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	private SlingshotLoader slingshotLoader;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	private SlingshotAimHandler slingshotAimHandler;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	private TeleportAimHandler teleportAimHandler;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	private SlingshotSettings slingshotSettings;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	private BirdsRemainingHandler birdsRemainingHandler;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	private DamageHandler damageHandler;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	private BirdSpecialAbilityHandler birdSpecialAbilityHandler;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	private EnvironmentPhysicsHandler environmentPhysicsHandler;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	private PigEmotionalStateHandler pigEmotionalStateHandler;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	private CharacterLookAtHandler characterLookAtHandler;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	private TutorialHandler tutorialHandler;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	private TelePointHandler telePointHandler;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	private HealthBarHandler healthBarHandler;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	private FadeHandler fadeHandler;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	private PlayerConstraintsHandler playerConstraintsHandler;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	private OutroHandler outroHandler;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	private AlchemyHandler alchemyHandler;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	private CutsceneHandler cutsceneHandler;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
	private EnvironmentEffectsHandler environmentEffectsHandler;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
	private ToolboxHandler toolboxHandler;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
	private PlaceLevelState placeLevelState;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
	private StartState startState;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
	private SelectWorldState selectWorldState;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	private SelectLevelState selectLevelState;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
	private SpawnLevelState spawnLevelState;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	private PlayState playState;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
	private PauseState pauseState;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
	private WinState winState;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	private ScoreboardState scoreboardState;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
	private LoseState loseState;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
	private CutsceneState cutsceneState;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
	private OutroState outroState;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
	private SettingsState settingsState;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
	private PrivacyState privacyState;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
	private NoEntitlementState noEntitlementState;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
	private LevelEditorState levelEditorState;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
	private ErrorState errorState;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
	private GameStateBase[] gameStates;

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x968B24", Offset = "0x968B24", VA = "0x968B24")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x96A1A8", Offset = "0x96A1A8", VA = "0x96A1A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76A718", Offset = "0x76A718")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x96A248", Offset = "0x96A248", VA = "0x96A248")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x96A468", Offset = "0x96A468", VA = "0x96A468")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x96A960", Offset = "0x96A960", VA = "0x96A960")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x96AA04", Offset = "0x96AA04", VA = "0x96AA04")]
	private void ChangeState(GameState newGameState)
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x96AAD0", Offset = "0x96AAD0", VA = "0x96AAD0")]
	private void OnPlaceLevel(Vector3 arWorldPosition)
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x96AD88", Offset = "0x96AD88", VA = "0x96AD88")]
	private void OnPauseGame(bool pause)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x96B19C", Offset = "0x96B19C", VA = "0x96B19C")]
	private void OnTeleport(TeleportationData teleportationData)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x96B34C", Offset = "0x96B34C", VA = "0x96B34C")]
	private void OnTeleportHovering(bool hovering)
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x96B384", Offset = "0x96B384", VA = "0x96B384")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76A77C", Offset = "0x76A77C")]
	private IEnumerator LoadEnvironment(WorldType newWorldScene)
	{
		return null;
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x96B448", Offset = "0x96B448", VA = "0x96B448")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76A7E0", Offset = "0x76A7E0")]
	private IEnumerator DespawnLevel()
	{
		return null;
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x96B4E8", Offset = "0x96B4E8", VA = "0x96B4E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76A844", Offset = "0x76A844")]
	private IEnumerator DelayedClickEndOfLevelScreen(ScoreBoardButtonType buttonType, Action<GameState> nextGameState)
	{
		return null;
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x96B5C4", Offset = "0x96B5C4", VA = "0x96B5C4")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x96B6D4", Offset = "0x96B6D4", VA = "0x96B6D4")]
	public PalazzoEntryPoint()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x96B8C8", Offset = "0x96B8C8", VA = "0x96B8C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A8A8", Offset = "0x76A8A8")]
	private PauseScreen <Awake>b__138_0(PauseScreen pauseScreen)
	{
		return null;
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x96B95C", Offset = "0x96B95C", VA = "0x96B95C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A8B8", Offset = "0x76A8B8")]
	private LoseScreen <Awake>b__138_1(LoseScreen loseScreen)
	{
		return null;
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x96B9F0", Offset = "0x96B9F0", VA = "0x96B9F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A8C8", Offset = "0x76A8C8")]
	private ScoreboardBase <Awake>b__138_2(ScoreboardBase scoreboard)
	{
		return null;
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x96BA84", Offset = "0x96BA84", VA = "0x96BA84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A8D8", Offset = "0x76A8D8")]
	private SplitMenu <Awake>b__138_3(SplitMenu menu)
	{
		return null;
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x96BB18", Offset = "0x96BB18", VA = "0x96BB18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A8E8", Offset = "0x76A8E8")]
	private void <Start>g__DrawMaterialMeshes|139_2()
	{
	}
}
[Token(Token = "0x200009B")]
public enum HapticType
{
	[Token(Token = "0x400050A")]
	OnHover,
	[Token(Token = "0x400050B")]
	OnClick,
	[Token(Token = "0x400050C")]
	OnDisabled,
	[Token(Token = "0x400050D")]
	SlingshotTension,
	[Token(Token = "0x400050E")]
	OnSlingshotFire,
	[Token(Token = "0x400050F")]
	OnBirdLandInSlingshot,
	[Token(Token = "0x4000510")]
	OnBirdSpecialAbility,
	[Token(Token = "0x4000511")]
	OnExplosion,
	[Token(Token = "0x4000512")]
	OnScorebarTick,
	[Token(Token = "0x4000513")]
	OnStarLightUp,
	[Token(Token = "0x4000514")]
	OnTeleport
}
[Token(Token = "0x200009C")]
public abstract class PalazzoInputDevice : IDisposable
{
	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected readonly ARTransforms arTransforms;

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x973D80", Offset = "0x973D80", VA = "0x973D80")]
	protected PalazzoInputDevice(ARTransforms arTransforms)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x973DAC", Offset = "0x973DAC", VA = "0x973DAC", Slot = "1")]
	~PalazzoInputDevice()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x973E2C", Offset = "0x973E2C", VA = "0x973E2C", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x973EA8", Offset = "0x973EA8", VA = "0x973EA8", Slot = "5")]
	protected virtual void DisposeInternal(bool disposeManagedResources)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x973EAC", Offset = "0x973EAC", VA = "0x973EAC", Slot = "6")]
	public virtual void Tick()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x973EB0", Offset = "0x973EB0", VA = "0x973EB0", Slot = "7")]
	public virtual void HandleAchievement(Achievements type)
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x973EB4", Offset = "0x973EB4", VA = "0x973EB4", Slot = "8")]
	public virtual bool ShouldHandlePrivacyPolicy()
	{
		return default(bool);
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x973EBC", Offset = "0x973EBC", VA = "0x973EBC", Slot = "9")]
	public virtual bool HasInputFocus()
	{
		return default(bool);
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x973EC4", Offset = "0x973EC4", VA = "0x973EC4", Slot = "10")]
	public virtual string GetUniqueIdentifier()
	{
		return null;
	}

	[Token(Token = "0x60002F8")]
	public abstract void Recenter();

	[Token(Token = "0x60002F9")]
	public abstract void PlayHaptic(HapticType hapticType, XRNode hand, [Optional] float? amplitude, bool playUntilStop = false);

	[Token(Token = "0x60002FA")]
	public abstract void StopHaptic(HapticType hapticType, XRNode hand);

	[Token(Token = "0x60002FB")]
	public abstract void SetHapticAmplitude(HapticType hapticType, XRNode hand, float amplitude);

	[Token(Token = "0x60002FC")]
	public abstract bool TriggerPressDown();

	[Token(Token = "0x60002FD")]
	public abstract bool TriggerPress();

	[Token(Token = "0x60002FE")]
	public abstract bool TriggerPressUp();

	[Token(Token = "0x60002FF")]
	public abstract bool MenuPressDown();

	[Token(Token = "0x6000300")]
	public abstract bool MenuPress();

	[Token(Token = "0x6000301")]
	public abstract bool MenuPressUp();

	[Token(Token = "0x6000302")]
	public abstract bool SecondaryMenuPressDown();

	[Token(Token = "0x6000303")]
	public abstract bool SecondaryMenuPress();

	[Token(Token = "0x6000304")]
	public abstract bool SecondaryMenuPressUp();

	[Token(Token = "0x6000305")]
	public abstract bool StampItem(XRNode hand);

	[Token(Token = "0x6000306")]
	public abstract bool DeleteItem(XRNode hand);

	[Token(Token = "0x6000307")]
	public abstract bool ToolboxRecenterPressDown();

	[Token(Token = "0x6000308")]
	public abstract bool TouchpadPressDown();

	[Token(Token = "0x6000309")]
	public abstract float Trigger(XRNode hand);

	[Token(Token = "0x600030A")]
	public abstract bool TriggerDown(XRNode hand);

	[Token(Token = "0x600030B")]
	public abstract bool TriggerUp(XRNode hand);

	[Token(Token = "0x600030C")]
	public abstract Vector2 ThumbstickAxis(XRNode hand);

	[Token(Token = "0x600030D")]
	public abstract Vector3 TouchpadSwipeVelocity();

	[Token(Token = "0x600030E")]
	public abstract Vector3 GetHeadLocalPosition();

	[Token(Token = "0x600030F")]
	public abstract Quaternion GetHeadLocalRotation();

	[Token(Token = "0x6000310")]
	public abstract Vector3 GetHandLocalPosition(XRNode hand);

	[Token(Token = "0x6000311")]
	public abstract Quaternion GetHandLocalRotation(XRNode hand);

	[Token(Token = "0x6000312")]
	public abstract Vector3 GetHandLocalPositionWhileAiming(XRNode hand);
}
[Token(Token = "0x200009D")]
public static class PalazzoLoadSave
{
	[Serializable]
	[Token(Token = "0x2000221")]
	private class PlayedOnlineLevelsCollection
	{
		[Token(Token = "0x4000E79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<string> playedOnlineLevelIds;

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x9B6204", Offset = "0x9B6204", VA = "0x9B6204")]
		public PlayedOnlineLevelsCollection()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000222")]
	private class LocalFavoritesCollection
	{
		[Token(Token = "0x4000E7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<uint> localFavorites;

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x9B61FC", Offset = "0x9B61FC", VA = "0x9B61FC")]
		public LocalFavoritesCollection()
		{
		}
	}

	[Token(Token = "0x2000223")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767354", Offset = "0x767354")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000E7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string levelCode;

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x9B5FE4", Offset = "0x9B5FE4", VA = "0x9B5FE4")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x9B5FEC", Offset = "0x9B5FEC", VA = "0x9B5FEC")]
		internal bool <ClearLocalLevelOnlineMetaData>b__0(ServerLevelMetaData metaData)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000224")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767364", Offset = "0x767364")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x4000E7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string onlineId;

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x9B6024", Offset = "0x9B6024", VA = "0x9B6024")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x9B602C", Offset = "0x9B602C", VA = "0x9B602C")]
		internal bool <RemoveOnlineLevelFromFavorites>b__0(ServerLevelMetaDataUserPair tuple)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x9B6074", Offset = "0x9B6074", VA = "0x9B6074")]
		internal bool <RemoveOnlineLevelFromFavorites>b__1(ServerLevelMetaDataUserPair tuple)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000225")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767374", Offset = "0x767374")]
	private sealed class <>c__DisplayClass42_0
	{
		[Token(Token = "0x4000E7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x9B60BC", Offset = "0x9B60BC", VA = "0x9B60BC")]
		public <>c__DisplayClass42_0()
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x9B60C4", Offset = "0x9B60C4", VA = "0x9B60C4")]
		internal bool <UpdateFavoriteLevelUser>b__0(ServerLevelMetaDataUserPair tuple)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000226")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767384", Offset = "0x767384")]
	private sealed class <>c__DisplayClass43_0
	{
		[Token(Token = "0x4000E7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x9B610C", Offset = "0x9B610C", VA = "0x9B610C")]
		public <>c__DisplayClass43_0()
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x9B6114", Offset = "0x9B6114", VA = "0x9B6114")]
		internal bool <LoadLevelFromFavorites>b__0(ServerLevelMetaDataUserPair tuple)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000227")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767394", Offset = "0x767394")]
	private sealed class <>c__DisplayClass44_0
	{
		[Token(Token = "0x4000E7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x9B615C", Offset = "0x9B615C", VA = "0x9B615C")]
		public <>c__DisplayClass44_0()
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x9B6164", Offset = "0x9B6164", VA = "0x9B6164")]
		internal bool <GetFavoriteLevelUser>b__0(ServerLevelMetaDataUserPair tuple)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x2000228")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7673A4", Offset = "0x7673A4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000E80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000E81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<ServerLevelMetaDataUserPair, ServerLevelMetaData> <>9__45_0;

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x975FC0", Offset = "0x975FC0", VA = "0x975FC0")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x975FC8", Offset = "0x975FC8", VA = "0x975FC8")]
		internal ServerLevelMetaData <GetFavoriteLevelsOnDisk>b__45_0(ServerLevelMetaDataUserPair tuple)
		{
			return null;
		}
	}

	[Token(Token = "0x2000229")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7673B4", Offset = "0x7673B4")]
	private sealed class <>c__DisplayClass49_0
	{
		[Token(Token = "0x4000E82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x9B61AC", Offset = "0x9B61AC", VA = "0x9B61AC")]
		public <>c__DisplayClass49_0()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x9B61B4", Offset = "0x9B61B4", VA = "0x9B61B4")]
		internal bool <IsFavoriteLevel>b__0(ServerLevelMetaDataUserPair tuple)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000516")]
	private const string PALAZZO_GAME_DATA = "PalazzoGameData";

	[Token(Token = "0x4000517")]
	private const string PALAZZO_ONLINE_METADATAS = "PalazzoOnlineMetaDatas";

	[Token(Token = "0x4000518")]
	private const string PALAZZO_REQUEST_QUEUE = "PalazzoRequestQueue";

	[Token(Token = "0x4000519")]
	private const string PALAZZO_PLAYED_ONLINE_LEVELS = "PalazzoPlayedOnlineLevels";

	[Token(Token = "0x400051A")]
	private const string PALAZZO_LOCAL_FAVORITES = "PalazzoLocalFavorites";

	[Token(Token = "0x400051B")]
	private const string DATA_FOLDER_NAME = "level_editor";

	[Token(Token = "0x400051C")]
	private const string RECOVERY_FILE_NAME = "recovery.json";

	[Token(Token = "0x400051D")]
	private const string FILE_SUFFIX = "_leveldata.json";

	[Token(Token = "0x400051E")]
	private const uint LEVEL_SAVE_FILE_VERSION = 1u;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string recoveryFilePath;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<uint, string> filePaths;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Dictionary<uint, LevelMetaData> metaDataCache;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static ServerLevelMetaDataCollections onlineMetaDataCollections;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static LocalFavoritesCollection localFavoritesCollection;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static HashSet<string> playedOnlineLevelIds;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int maxNumberOfLevels;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767B54", Offset = "0x767B54")]
	private static string <LevelEditorDataPath>k__BackingField;

	[Token(Token = "0x1700001A")]
	private static string LevelEditorDataPath
	{
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x973ECC", Offset = "0x973ECC", VA = "0x973ECC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A8F8", Offset = "0x76A8F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x973F1C", Offset = "0x973F1C", VA = "0x973F1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A908", Offset = "0x76A908")]
		set
		{
		}
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x972604", Offset = "0x972604", VA = "0x972604")]
	public static void Init(int maxNumberOfLevels)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x9727E8", Offset = "0x9727E8", VA = "0x9727E8")]
	public static bool HasData()
	{
		return default(bool);
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x972834", Offset = "0x972834", VA = "0x972834")]
	public static bool TryLoad(out PalazzoGameDataPersistent deserialized)
	{
		return default(bool);
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x964658", Offset = "0x964658", VA = "0x964658")]
	public static bool TrySave(PalazzoGameDataPersistent deserialized)
	{
		return default(bool);
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x974570", Offset = "0x974570", VA = "0x974570")]
	public static Level CreateNewLevel(uint saveIndex)
	{
		return null;
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x9749A4", Offset = "0x9749A4", VA = "0x9749A4")]
	public static Level DuplicateLevel(uint saveIndex, Level levelToDuplicate)
	{
		return null;
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x974A9C", Offset = "0x974A9C", VA = "0x974A9C")]
	public static void SaveRecoveryLevelToDisk(Level level)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x974B2C", Offset = "0x974B2C", VA = "0x974B2C")]
	public static bool HasRecoveryLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x96B65C", Offset = "0x96B65C", VA = "0x96B65C")]
	public static void DeleteRecoveryLevelFromDisk()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x974B80", Offset = "0x974B80", VA = "0x974B80")]
	public static Level LoadRecoveryLevelFromDisk()
	{
		return null;
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x9672E4", Offset = "0x9672E4", VA = "0x9672E4")]
	public static void SaveLevelToDisk(Level level)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x974C44", Offset = "0x974C44", VA = "0x974C44")]
	public static void SaveOnlineMetaDataToDisk(uint id, ServerLevelMetaData onlineMetaData)
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x974D4C", Offset = "0x974D4C", VA = "0x974D4C")]
	public static void ClearLocalLevelOnlineMetaData(string levelCode)
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x974EB4", Offset = "0x974EB4", VA = "0x974EB4")]
	public static LevelMetaData[] GetAvailableLevelsOnDisk()
	{
		return null;
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x974F98", Offset = "0x974F98", VA = "0x974F98")]
	public static ServerLevelMetaData GetLocalLevelOnlineMetaData(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x96CB9C", Offset = "0x96CB9C", VA = "0x96CB9C")]
	public static Level LoadLevelFromDisk(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x97501C", Offset = "0x97501C", VA = "0x97501C")]
	public static void DeleteLevelFromDisk(uint id)
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x966EBC", Offset = "0x966EBC", VA = "0x966EBC")]
	public static bool TryAddOnlineLevelToFavorites(ServerLevelMetaData metadata, User user)
	{
		return default(bool);
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x966D7C", Offset = "0x966D7C", VA = "0x966D7C")]
	public static void RemoveOnlineLevelFromFavorites(string onlineId)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x975260", Offset = "0x975260", VA = "0x975260")]
	public static void UpdateFavoriteLevelsMetaDatas(ServerLevelMetaData[] metaDatas)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x97557C", Offset = "0x97557C", VA = "0x97557C")]
	public static void UpdateFavoriteLevelUser(string id, User user)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x96CCA8", Offset = "0x96CCA8", VA = "0x96CCA8")]
	public static Level LoadLevelFromFavorites(string id)
	{
		return null;
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x975680", Offset = "0x975680", VA = "0x975680")]
	public static User GetFavoriteLevelUser(string id)
	{
		return null;
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x975780", Offset = "0x975780", VA = "0x975780")]
	public static ServerLevelMetaData[] GetFavoriteLevelsOnDisk()
	{
		return null;
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x97589C", Offset = "0x97589C", VA = "0x97589C")]
	public static List<uint> GetLocalFavorites()
	{
		return null;
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x9671AC", Offset = "0x9671AC", VA = "0x9671AC")]
	public static void RemoveFromLocalFavorites(uint id)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x967248", Offset = "0x967248", VA = "0x967248")]
	public static void AddToLocalFavorites(uint id)
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x9629F4", Offset = "0x9629F4", VA = "0x9629F4")]
	public static bool IsFavoriteLevel(string id)
	{
		return default(bool);
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x975D48", Offset = "0x975D48", VA = "0x975D48")]
	public static void MarkOnlineLevelAsPlayed(string id)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x975E38", Offset = "0x975E38", VA = "0x975E38")]
	public static bool IsOnlineLevelPlayed(string id)
	{
		return default(bool);
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x974BEC", Offset = "0x974BEC", VA = "0x974BEC")]
	private static Level LoadLevelFromDisk(string levelFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x974CDC", Offset = "0x974CDC", VA = "0x974CDC")]
	private static void SaveOnlineMetaDataCollection()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x975910", Offset = "0x975910", VA = "0x975910")]
	private static void LoadLocalFavorites()
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x975CD8", Offset = "0x975CD8", VA = "0x975CD8")]
	private static void SaveLocalFavorites()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x973F70", Offset = "0x973F70", VA = "0x973F70")]
	private static void CacheLevelsOnDisk()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x9748BC", Offset = "0x9748BC", VA = "0x9748BC")]
	private static string GetLevelFilePath(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x9744A0", Offset = "0x9744A0", VA = "0x9744A0")]
	private static void CachePlayedLevelsOnDisk()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x975EAC", Offset = "0x975EAC", VA = "0x975EAC")]
	public static bool DoesLevelExist(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x975F20", Offset = "0x975F20", VA = "0x975F20")]
	public static bool IsLocalLevelUploaded(uint id)
	{
		return default(bool);
	}
}
[Token(Token = "0x200009E")]
public abstract class PalazzoPlatform : SingleInstanceBehavior<PalazzoPlatform>
{
	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767B64", Offset = "0x767B64")]
	private PalazzoInputDevice <InputDevice>k__BackingField;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767B74", Offset = "0x767B74")]
	private WorldTracker <WorldTracker>k__BackingField;

	[Token(Token = "0x1700001B")]
	protected PalazzoInputDevice InputDevice
	{
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x9B620C", Offset = "0x9B620C", VA = "0x9B620C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A918", Offset = "0x76A918")]
		get
		{
			return null;
		}
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x9B6214", Offset = "0x9B6214", VA = "0x9B6214")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A928", Offset = "0x76A928")]
		private set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	protected WorldTracker WorldTracker
	{
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x9B621C", Offset = "0x9B621C", VA = "0x9B621C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A938", Offset = "0x76A938")]
		get
		{
			return null;
		}
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x9B6224", Offset = "0x9B6224", VA = "0x9B6224")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A948", Offset = "0x76A948")]
		private set
		{
		}
	}

	[Token(Token = "0x6000340")]
	public abstract bool HasTwoHandedSupport();

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x9B622C", Offset = "0x9B622C", VA = "0x9B622C", Slot = "7")]
	public virtual bool IsUserEntitled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x9B6234", Offset = "0x9B6234", VA = "0x9B6234", Slot = "8")]
	public virtual Theme[] GetEnabledThemes()
	{
		return null;
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x9B6280", Offset = "0x9B6280", VA = "0x9B6280", Slot = "9")]
	public virtual void OnMainSetupDone()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x9B6284", Offset = "0x9B6284", VA = "0x9B6284", Slot = "5")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x9B6298", Offset = "0x9B6298", VA = "0x9B6298")]
	public PalazzoInputDevice CreateInputDevice(ARTransforms arTransforms)
	{
		return null;
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x9B62D0", Offset = "0x9B62D0", VA = "0x9B62D0")]
	public WorldTracker CreateWorldTracker(ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldImpactQueue worldImpactQueue)
	{
		return null;
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x9B6308", Offset = "0x9B6308", VA = "0x9B6308")]
	public bool IsThemeEnabledOnPlatform(Theme theme)
	{
		return default(bool);
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x9B63A4", Offset = "0x9B63A4", VA = "0x9B63A4", Slot = "10")]
	public virtual bool IsOnlineLevelEditorSupported()
	{
		return default(bool);
	}

	[Token(Token = "0x6000349")]
	protected abstract PalazzoInputDevice CreateInputDeviceInternal(ARTransforms arTransforms);

	[Token(Token = "0x600034A")]
	protected abstract WorldTracker CreateWorldTrackerInternal(ARTransforms arTransforms, PalazzoTriggers palazzoTriggers);

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x9B63AC", Offset = "0x9B63AC", VA = "0x9B63AC")]
	protected PalazzoPlatform()
	{
	}
}
[Token(Token = "0x200009F")]
public sealed class PalazzoPlatformVR : SingleInstanceBehavior<PalazzoPlatformVR>
{
	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform enviromentTransform;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform playerStartPosition;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public WorldImpactComponent[] impactComponents;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public EffectOnImpactComponent[] effectOnImpactComponents;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public EnvironmentParticleComponent[] environmentParticles;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SnowLift snowLift;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public PalazzoComponentLevelBlock[] pigStatues;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public Transform startPosition;

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x9B641C", Offset = "0x9B641C", VA = "0x9B641C", Slot = "4")]
	public override void Awake()
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x9B6490", Offset = "0x9B6490", VA = "0x9B6490", Slot = "5")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x9B6568", Offset = "0x9B6568", VA = "0x9B6568")]
	public PalazzoPlatformVR()
	{
	}
}
[Token(Token = "0x20000A0")]
public static class PalazzoPlayFabApi
{
	[Token(Token = "0x200022A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7673C4", Offset = "0x7673C4")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000E83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ServerLevelMetaData metaData;

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x9B68C8", Offset = "0x9B68C8", VA = "0x9B68C8")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x9B7D7C", Offset = "0x9B7D7C", VA = "0x9B7D7C")]
		internal void <ReportLevel>b__0(ReportPlayerClientResult success)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200022B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7673D4", Offset = "0x7673D4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000E84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000E85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<PlayFabError> <>9__7_1;

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x9B7720", Offset = "0x9B7720", VA = "0x9B7720")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x9B7728", Offset = "0x9B7728", VA = "0x9B7728")]
		internal void <ReportLevel>b__7_1(PlayFabError error)
		{
		}
	}

	[Token(Token = "0x200022C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7673E4", Offset = "0x7673E4")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000E86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Future<bool> future;

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x9B6C2C", Offset = "0x9B6C2C", VA = "0x9B6C2C")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x9B7E58", Offset = "0x9B7E58", VA = "0x9B7E58")]
		internal void <UpdateUserData>b__0(UpdateUserDataResult result)
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x9B7EBC", Offset = "0x9B7EBC", VA = "0x9B7EBC")]
		internal void <UpdateUserData>b__1(PlayFabError err)
		{
		}
	}

	[Token(Token = "0x200022D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7673F4", Offset = "0x7673F4")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000E87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string playFabId;

		[Token(Token = "0x4000E88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Future<User> future;

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x9B7098", Offset = "0x9B7098", VA = "0x9B7098")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x9B7F58", Offset = "0x9B7F58", VA = "0x9B7F58")]
		internal void <GetUserData>g__OnSuccessCallback|0(GetUserDataResult result)
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x9B80D0", Offset = "0x9B80D0", VA = "0x9B80D0")]
		internal void <GetUserData>g__OnFailCallback|1(PlayFabError error)
		{
		}
	}

	[Token(Token = "0x200022E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767404", Offset = "0x767404")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000E89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Future<string> future;

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x9B72AC", Offset = "0x9B72AC", VA = "0x9B72AC")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x9B77DC", Offset = "0x9B77DC", VA = "0x9B77DC")]
		internal void <GetAuthToken>b__0(ExecuteCloudScriptResult result)
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x9B7AF0", Offset = "0x9B7AF0", VA = "0x9B7AF0")]
		internal void <GetAuthToken>b__1(PlayFabError err)
		{
		}
	}

	[Token(Token = "0x200022F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767414", Offset = "0x767414")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000E8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Future<string> future;

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x9B74F8", Offset = "0x9B74F8", VA = "0x9B74F8")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x9B7BB0", Offset = "0x9B7BB0", VA = "0x9B7BB0")]
		internal void <LoginWithCustomId>b__0(LoginResult result)
		{
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x9B7C30", Offset = "0x9B7C30", VA = "0x9B7C30")]
		internal void <LoginWithCustomId>b__1(PlayFabError err)
		{
		}
	}

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<string, User> usersCache;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool isFetchingUserData;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly GetUserDataRequest getUserDataRequest;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly ReportPlayerClientRequest reportPlayerRequest;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly LoginWithCustomIDRequest loginWithCustomIdRequest;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly ExecuteCloudScriptRequest createAuthTokenRequest;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly UpdateUserDataRequest updateUserDataRequest;

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x9B65D8", Offset = "0x9B65D8", VA = "0x9B65D8")]
	public static void ReportLevel(ServerLevelMetaData metaData, string reportMessage)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x9B68D0", Offset = "0x9B68D0", VA = "0x9B68D0")]
	public static void UpdateUserData(Future<bool> future, User user)
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x9B6C34", Offset = "0x9B6C34", VA = "0x9B6C34")]
	public static void GetUserData(Future<User> future, string playFabId)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x9B70A0", Offset = "0x9B70A0", VA = "0x9B70A0")]
	public static void GetAuthToken(Future<string> future)
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x9B72B4", Offset = "0x9B72B4", VA = "0x9B72B4")]
	public static void LoginWithCustomId(Future<string> future, string customId)
	{
	}
}
[Token(Token = "0x20000A1")]
[Flags]
public enum BlockType
{
	[Token(Token = "0x4000539")]
	Invalid = 0,
	[Token(Token = "0x400053A")]
	Ice = 1,
	[Token(Token = "0x400053B")]
	Wood = 2,
	[Token(Token = "0x400053C")]
	Rock = 3,
	[Token(Token = "0x400053D")]
	Pig = 4,
	[Token(Token = "0x400053E")]
	Tnt = 5,
	[Token(Token = "0x400053F")]
	Fan = 6,
	[Token(Token = "0x4000540")]
	Balloon = 7,
	[Token(Token = "0x4000541")]
	Red = 8,
	[Token(Token = "0x4000542")]
	Yellow = 9,
	[Token(Token = "0x4000543")]
	Blue = 0xA,
	[Token(Token = "0x4000544")]
	Black = 0xB,
	[Token(Token = "0x4000545")]
	Water = 0xC,
	[Token(Token = "0x4000546")]
	TeleportationPoint = 0xD,
	[Token(Token = "0x4000547")]
	BossPig = 0xE,
	[Token(Token = "0x4000548")]
	RockSphere = 0xF,
	[Token(Token = "0x4000549")]
	Ground = 0x10,
	[Token(Token = "0x400054A")]
	AlchemyBomb = 0x11
}
[Token(Token = "0x20000A2")]
public enum PlayerHandedness
{
	[Token(Token = "0x400054C")]
	Right,
	[Token(Token = "0x400054D")]
	Left
}
[Token(Token = "0x20000A3")]
public static class BlockTypeHelper
{
	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly BlockType[] blockTypeArray;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly int blockTypeCount;
}
[Serializable]
[Token(Token = "0x20000A4")]
public struct PalazzoShaderVariant
{
	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Shader shader;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public PassType passType;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string[] keywords;

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x7D8604", Offset = "0x7D8604", VA = "0x7D8604")]
	public ShaderVariantCollection.ShaderVariant AsUnityVariant()
	{
		return default(ShaderVariantCollection.ShaderVariant);
	}
}
[Token(Token = "0x20000A5")]
public enum DamageState
{
	[Token(Token = "0x4000554")]
	Whole,
	[Token(Token = "0x4000555")]
	HalfBroken,
	[Token(Token = "0x4000556")]
	Broken
}
[Token(Token = "0x20000A6")]
public enum Theme
{
	[Token(Token = "0x4000558")]
	Normal,
	[Token(Token = "0x4000559")]
	Nightmare,
	[Token(Token = "0x400055A")]
	LevelEditor
}
[Token(Token = "0x20000A7")]
public sealed class LevelContext
{
	[Token(Token = "0x400055B")]
	public const float LEVEL_RADIUS = 15f;

	[Token(Token = "0x400055C")]
	public const int BLOCK_SCORE = 500;

	[Token(Token = "0x400055D")]
	public const int PIG_SCORE = 5000;

	[Token(Token = "0x400055E")]
	public const int BIRD_SCORE = 10000;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public PalazzoComponentLevel level;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform lockedObjectsParent;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int levelIndex;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float levelRotation;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int customLevelIndex;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Coroutine levelSpawnEffect;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Coroutine levelDespawnEffect;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int pigScore;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int blockScore;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int unusedBirdScore;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int birdCountLaunched;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public WorldType world;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool isInitialized;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int fixedFrameCounter;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool isPreview;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool hasFirstBirdReachedSlingshot;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<ServerLevelMetaData> favoriteLevels;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float playTimer;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public readonly List<PalazzoComponentLevelBlock> blocks;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public readonly List<FanComponent> fans;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public readonly List<DamageComponent> damages;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public readonly List<BalloonComponent> balloons;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public readonly List<PalazzoComponentPig> pigs;

	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public readonly List<PalazzoComponentBird> birds;

	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public readonly List<InteractiveCharacterComponent> characters;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public readonly List<TeleportationComponent> teleportationPoints;

	[Token(Token = "0x6000357")]
	[Address(RVA = "0xA21BBC", Offset = "0xA21BBC", VA = "0xA21BBC")]
	public LevelContext()
	{
	}
}
[Token(Token = "0x20000A8")]
public sealed class MenuContext
{
	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IMenuHandler activeMenuToHide;

	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool shouldReloadData;

	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool shouldShowModeSelect;

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x95C6BC", Offset = "0x95C6BC", VA = "0x95C6BC")]
	public MenuContext()
	{
	}
}
[Token(Token = "0x20000A9")]
public sealed class LevelEditorContext
{
	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Level editingLevel;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isInteracting;

	[Token(Token = "0x400057E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float performanceCost;

	[Token(Token = "0x400057F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float reserveCost;

	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool isTryingLevel;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool isRecoveringLevel;

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x9FE56C", Offset = "0x9FE56C", VA = "0x9FE56C")]
	public LevelEditorContext()
	{
	}
}
[Token(Token = "0x20000AA")]
public sealed class LevelEditorPlayContext
{
	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LevelListContext playListContext;

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Level playLevel;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ServerLevelMetaData playLevelOnlineMetaData;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MenuType menuType;

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public MenuType prevMenuType;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string profileUserId;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string currentlyViewedUser;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public User selectedLevelsUser;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool reportOpenedFromMenu;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool favoriteErrorFromMenu;

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xA005E4", Offset = "0xA005E4", VA = "0xA005E4")]
	public LevelEditorPlayContext()
	{
	}
}
[Serializable]
[Token(Token = "0x20000AB")]
public sealed class LevelEditorSettings : ISerializationCallbackReceiver
{
	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int MaxLevelCost;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int maxLevelCost;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material deletionMaterial;

	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material greenMaterial;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float buildingRadius;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int platformRotationTickSound;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float platformDefaultYRotation;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int maxNumberOfLevels;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767B94", Offset = "0x767B94")]
	public Material toolboxItemHighlightMaterial;

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material toolboxCharacterHighlightMaterial;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material buildingItemHighlightMaterial;

	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material buildingCharacterHighlightMaterial;

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767BCC", Offset = "0x767BCC")]
	public int maxStepY;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int minStepY;

	[Token(Token = "0x600035B")]
	[Address(RVA = "0xA01C60", Offset = "0xA01C60", VA = "0xA01C60", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xA01C64", Offset = "0xA01C64", VA = "0xA01C64", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xA01CBC", Offset = "0xA01CBC", VA = "0xA01CBC")]
	public LevelEditorSettings()
	{
	}
}
[Token(Token = "0x20000AC")]
public sealed class ScoreboardContext
{
	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<BlockType> unusedBirds;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LevelSettings levelSettings;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int levelIndex;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int pigScore;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int blockScore;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int unusedBirdScore;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int birdCountLaunched;

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x9E18D4", Offset = "0x9E18D4", VA = "0x9E18D4")]
	public ScoreboardContext()
	{
	}
}
[Token(Token = "0x20000AD")]
public sealed class WorldContext
{
	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] WorldNames;

	[Token(Token = "0x40005A2")]
	public const WorldType START_SCENE = WorldType.Start;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public WorldType activeWorldScene;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int currentTheme;

	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isEditing;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public EnvironmentParticleComponent[] environmentParticles;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SnowLift snowLift;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Coroutine loadEnvironment;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3? lastActiveTeleportationPosition;

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x10F7DD4", Offset = "0x10F7DD4", VA = "0x10F7DD4")]
	public WorldContext()
	{
	}
}
[Token(Token = "0x20000AE")]
public enum PlayType
{
	[Token(Token = "0x40005AB")]
	UploadTrial,
	[Token(Token = "0x40005AC")]
	BaseGame,
	[Token(Token = "0x40005AD")]
	TryPlay,
	[Token(Token = "0x40005AE")]
	Favorite,
	[Token(Token = "0x40005AF")]
	Discovery,
	[Token(Token = "0x40005B0")]
	QuickPlay,
	[Token(Token = "0x40005B1")]
	BuildLevelsPlay,
	[Token(Token = "0x40005B2")]
	UserProfile,
	[Token(Token = "0x40005B3")]
	Search,
	[Token(Token = "0x40005B4")]
	LocalFavorite
}
[Serializable]
[Token(Token = "0x20000AF")]
public sealed class LevelSelectSettings
{
	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767C04", Offset = "0x767C04")]
	public Material[] worldBossMaterials;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sprite[] worldBossSprites;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767C3C", Offset = "0x767C3C")]
	public Material beachBorder;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material cliffBorder;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material snowBorder;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material peakBorder;

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xA0CDFC", Offset = "0xA0CDFC", VA = "0xA0CDFC")]
	public LevelSelectSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x20000B0")]
public sealed class PlayStateSettings
{
	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	public float noPigsEndGameSeconds;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	public float noBirdsEndGameSeconds;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float noBirdsEndGameAlwaysWaitSeconds;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float gameEndSpeedThreshold;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float gameEndAngularSpeedThreshold;

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x9C9598", Offset = "0x9C9598", VA = "0x9C9598")]
	public PlayStateSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x20000B1")]
public sealed class PalazzoGameDataPersistent : ISerializationCallbackReceiver
{
	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<string> levelGuid;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> levelStarCount;

	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<string> cutscenesWatched;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool[] worldUnlocked;

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool musicEnabled;

	[Token(Token = "0x40005C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool soundEnabled;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool hapticsEnabled;

	[Token(Token = "0x40005C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool acceptedPrivacyPolicy;

	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool hasAcceptedTermsOfUse;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool hasSeenOutro;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int handedness;

	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool useSlingshotAim;

	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int totalStarCount;

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x973D28", Offset = "0x973D28", VA = "0x973D28", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x973D7C", Offset = "0x973D7C", VA = "0x973D7C", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x9728BC", Offset = "0x9728BC", VA = "0x9728BC")]
	public PalazzoGameDataPersistent()
	{
	}
}
[Serializable]
[Token(Token = "0x20000B2")]
public sealed class ARTransforms
{
	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float vrVisualScaleUpMultiplier;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float visualLevelScaleDown;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float physicalLevelScaleUp;

	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x767CC4", Offset = "0x767CC4")]
	public Transform levelRoot;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x767CFC", Offset = "0x767CFC")]
	public Transform worldRoot;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x767D34", Offset = "0x767D34")]
	public Transform cameraRoot;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform scoreEffectRoot;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform particleEffectRoot;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform arCamera;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Camera arCameraComponent;

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x99B04C", Offset = "0x99B04C", VA = "0x99B04C")]
	public Vector3 ARWorldToLevelWorld(Vector3 position)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x99B0A4", Offset = "0x99B0A4", VA = "0x99B0A4")]
	public Quaternion ARWorldToLevelWorld(Quaternion orientation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x99B184", Offset = "0x99B184", VA = "0x99B184")]
	public float ARWorldToLevelWorld(float distance)
	{
		return default(float);
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x99B194", Offset = "0x99B194", VA = "0x99B194")]
	public Vector3 LevelWorldToARWorld(Vector3 position)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x99B21C", Offset = "0x99B21C", VA = "0x99B21C")]
	public Quaternion LevelWorldToARWorld(Quaternion orientation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x99B304", Offset = "0x99B304", VA = "0x99B304")]
	public Vector3 ARWorldToLevelWorldInXZ(Vector3 worldPosition)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x99B31C", Offset = "0x99B31C", VA = "0x99B31C")]
	public Quaternion ARWorldToLevelWorldLookRotationInXZ(Vector3 worldPosition)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x99B418", Offset = "0x99B418", VA = "0x99B418")]
	public ARTransforms()
	{
	}
}
[Serializable]
[Token(Token = "0x20000B3")]
public sealed class TrajectoryMarkerSettings
{
	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float markerScale;

	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float specialMarkerScale;

	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int numMarkersToFade;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Mesh markerMesh;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material markerMaterial;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Mesh specialMarkerMesh;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material specialMarkerMaterial;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public float markerAlphaValue;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public bool shouldDraw;

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x10F3A88", Offset = "0x10F3A88", VA = "0x10F3A88")]
	public TrajectoryMarkerSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x20000B4")]
public sealed class DamageSettings
{
	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767D8C", Offset = "0x767D8C")]
	public int scoreMultiplier;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767DC4", Offset = "0x767DC4")]
	public float damageMultiplier;

	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float impactLightMax;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float impactMediumMax;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float impactHeavyMax;

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767DFC", Offset = "0x767DFC")]
	public float redIceDamageMult;

	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float redWoodDamageMult;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float redRockDamageMult;

	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float redBossPigDamageMult;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767E34", Offset = "0x767E34")]
	public float yellowIceDamageMult;

	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float yellowWoodDamageMult;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float yellowRockDamageMult;

	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float yellowBossPigDamageMult;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767E6C", Offset = "0x767E6C")]
	public float blueIceDamageMult;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float blueWoodDamageMult;

	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float blueRockDamageMult;

	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float blueBossPigDamageMult;

	[Token(Token = "0x40005F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767EA4", Offset = "0x767EA4")]
	public float blackIceDamageMult;

	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float blackWoodDamageMult;

	[Token(Token = "0x40005F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float blackRockDamageMult;

	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float blackBossPigDamageMult;

	[Token(Token = "0x40005F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767EDC", Offset = "0x767EDC")]
	public float redIceVelocityRetain;

	[Token(Token = "0x40005F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float redWoodVelocityRetain;

	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float redRockVelocityRetain;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float redBossPigVelocityRetain;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float redBalloonVelocityRetain;

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767F14", Offset = "0x767F14")]
	public float yellowIceVelocityRetain;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float yellowWoodVelocityRetain;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float yellowRockVelocityRetain;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float yellowBossPigVelocityRetain;

	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float yellowBalloonVelocityRetain;

	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767F4C", Offset = "0x767F4C")]
	public float blueIceVelocityRetain;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float blueWoodVelocityRetain;

	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float blueRockVelocityRetain;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float blueBossPigVelocityRetain;

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float blueBalloonVelocityRetain;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767F84", Offset = "0x767F84")]
	public float blackIceVelocityRetain;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float blackWoodVelocityRetain;

	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float blackRockVelocityRetain;

	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float blackBossPigVelocityRetain;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float blackBalloonVelocityRetain;

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x9AE95C", Offset = "0x9AE95C", VA = "0x9AE95C")]
	public DamageSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x20000B5")]
public sealed class SlingshotSettings
{
	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float stringTensionMin;

	[Token(Token = "0x400060A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float stringTensionMax;

	[Token(Token = "0x400060B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float stringTensionAnimationMax;

	[Token(Token = "0x400060C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float launchVelocityMin;

	[Token(Token = "0x400060D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float launchVelocityMax;

	[Token(Token = "0x400060E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float birdStayAliveForSeconds;

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x9ED86C", Offset = "0x9ED86C", VA = "0x9ED86C")]
	public SlingshotSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x20000B6")]
public sealed class PhysicsSettings
{
	[Token(Token = "0x400060F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 gravity;

	[Token(Token = "0x4000610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxAngularVelocity;

	[Token(Token = "0x4000611")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float densityMultiplier;

	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float impactMagnitudeThreshold;

	[Token(Token = "0x4000613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float birdVelocityMultiplier;

	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767FBC", Offset = "0x767FBC")]
	public float birdAirDragMul;

	[Token(Token = "0x4000615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float redDensity;

	[Token(Token = "0x4000616")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float yellowDensity;

	[Token(Token = "0x4000617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float blueDensity;

	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float blackDensity;

	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float yellowDashDensityMul;

	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float yellowDashVelocityMul;

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x767FF4", Offset = "0x767FF4")]
	public float pigDensity;

	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float pigHealth;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x76802C", Offset = "0x76802C")]
	public float bossPigDensity;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float bossPigHealth;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x768064", Offset = "0x768064")]
	public float iceDensity;

	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float iceHealth;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x76809C", Offset = "0x76809C")]
	public float rockDensity;

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float rockHealth;

	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7680D4", Offset = "0x7680D4")]
	public float rockSphereDensity;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float rockSphereHealth;

	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x76810C", Offset = "0x76810C")]
	public float woodDensity;

	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float woodHealth;

	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x768144", Offset = "0x768144")]
	public float tntDensity;

	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float tntHealth;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x76817C", Offset = "0x76817C")]
	public float alchBombDensity;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float alchBombHealth;

	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7681B4", Offset = "0x7681B4")]
	public float fanAirDragMul;

	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float fanDensity;

	[Token(Token = "0x400062D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float fanHealth;

	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float fanStrengthTweakMultiplier;

	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7681EC", Offset = "0x7681EC")]
	public float balloonBuoyancyStartHeight;

	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float balloonAirDragMul;

	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float balloonAirDensityMul;

	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float balloonDensity;

	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float balloonHealth;

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x9C5110", Offset = "0x9C5110", VA = "0x9C5110")]
	public PhysicsSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x20000B7")]
public sealed class FieldOfViewSettings
{
	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool active;

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ARClippingMask;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float width;

	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float height;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fovVertical;

	[Token(Token = "0x4000639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float fovHorizontal;

	[Token(Token = "0x400063A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float distanceToMask;

	[Token(Token = "0x6000372")]
	[Address(RVA = "0xA14084", Offset = "0xA14084", VA = "0xA14084")]
	public FieldOfViewSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x20000B8")]
public sealed class EnvironmentEffects
{
	[Token(Token = "0x400063B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject spookyRain;

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x9B2828", Offset = "0x9B2828", VA = "0x9B2828")]
	public EnvironmentEffects()
	{
	}
}
[Token(Token = "0x20000B9")]
public enum WorldType
{
	[Token(Token = "0x400063D")]
	Beach,
	[Token(Token = "0x400063E")]
	Cliff,
	[Token(Token = "0x400063F")]
	Snow,
	[Token(Token = "0x4000640")]
	Peak,
	[Token(Token = "0x4000641")]
	NightmareBeach,
	[Token(Token = "0x4000642")]
	NightmareCliff,
	[Token(Token = "0x4000643")]
	NightmareSnow,
	[Token(Token = "0x4000644")]
	NightmarePeak,
	[Token(Token = "0x4000645")]
	Start,
	[Token(Token = "0x4000646")]
	StartNightmare,
	[Token(Token = "0x4000647")]
	LevelEditor
}
[Serializable]
[Token(Token = "0x20000BA")]
public sealed class LevelSettings
{
	[Token(Token = "0x4000648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string guid;

	[Token(Token = "0x4000649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string levelNameId;

	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string levelDescriptionId;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float birdsRemainingRadius;

	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int scoreStar1;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int scoreStar2;

	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int scoreStar3;

	[Token(Token = "0x400064F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LevelBlockProxyTeleportationPoint startPoint;

	[Token(Token = "0x4000650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string levelMusic;

	[Token(Token = "0x4000651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TutorialType tutorialType;

	[Token(Token = "0x4000652")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public WorldType worldType;

	[NonSerialized]
	[Token(Token = "0x4000653")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool finished;

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xA0415C", Offset = "0xA0415C", VA = "0xA0415C")]
	public LevelSettings Clone()
	{
		return null;
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xA044F0", Offset = "0xA044F0", VA = "0xA044F0")]
	public LevelSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x20000BB")]
public sealed class HealthBarData
{
	[Token(Token = "0x2000230")]
	public struct ParameterIds
	{
		[Token(Token = "0x4000E8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int mainProgress;
	}

	[NonSerialized]
	[Token(Token = "0x4000654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public MaterialPropertyBlock properties;

	[NonSerialized]
	[Token(Token = "0x4000655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParameterIds parameterIds;

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xA14608", Offset = "0xA14608", VA = "0xA14608")]
	public void Init()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xA14680", Offset = "0xA14680", VA = "0xA14680")]
	public HealthBarData()
	{
	}
}
[Serializable]
[Token(Token = "0x20000BC")]
public sealed class TensionHandSettings
{
	[Token(Token = "0x4000656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float maxScale;

	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float timeToScaleUp;

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x10ED8A8", Offset = "0x10ED8A8", VA = "0x10ED8A8")]
	public TensionHandSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x20000BD")]
public sealed class ScoreboardSettings
{
	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float timeBeforeStart;

	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float blockScalingTime;

	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float blockMinScale;

	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float blockMaxScale;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve blockScalingCurve;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float textShowAfterTime;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float textShowForTime;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float particleFxScale;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ParticleEffectComponent despawnEffect;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string despawnEffectSound;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color[] blockScoreColorTop;

	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Color[] blockScoreColorBottom;

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x9E4028", Offset = "0x9E4028", VA = "0x9E4028")]
	public ScoreboardSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x20000BE")]
public sealed class MenuSettings
{
	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 startMenuPosition;

	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 worldMenuStartPosition;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationComponent menuAnimationComponent;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float distanceFromFace;

	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float heightOffset;

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x95C6C4", Offset = "0x95C6C4", VA = "0x95C6C4")]
	public MenuSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x20000BF")]
public sealed class TutorialSettings
{
	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Sprite red;

	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sprite chuck;

	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite bomb;

	[Token(Token = "0x400066C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Sprite blues;

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x10F5C08", Offset = "0x10F5C08", VA = "0x10F5C08")]
	public TutorialSettings()
	{
	}
}
[Token(Token = "0x20000C0")]
public enum OutroClipState
{
	[Token(Token = "0x400066E")]
	Init,
	[Token(Token = "0x400066F")]
	Playing,
	[Token(Token = "0x4000670")]
	Done
}
[Serializable]
[Token(Token = "0x20000C1")]
public sealed class OutroClip
{
	[Token(Token = "0x4000671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject obj;

	[Token(Token = "0x4000672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float startAfterXSec;

	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float duration;

	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string sound;

	[NonSerialized]
	[Token(Token = "0x4000675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OutroClipState state;

	[NonSerialized]
	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float timer;

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x9641AC", Offset = "0x9641AC", VA = "0x9641AC")]
	public OutroClip()
	{
	}
}
[Serializable]
[Token(Token = "0x20000C2")]
public sealed class OutroSettings
{
	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public OutroClip[] clips;

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x9646FC", Offset = "0x9646FC", VA = "0x9646FC")]
	public OutroSettings()
	{
	}
}
[Token(Token = "0x20000C3")]
public enum CutSceneQueue
{
	[Token(Token = "0x4000679")]
	BeforeLevel,
	[Token(Token = "0x400067A")]
	AfterLevel
}
[Token(Token = "0x20000C4")]
public enum Achievements
{
	[Token(Token = "0x400067C")]
	ClearFirstLevel,
	[Token(Token = "0x400067D")]
	Collect10Stars,
	[Token(Token = "0x400067E")]
	UnlockSecondWorld,
	[Token(Token = "0x400067F")]
	DefeatBossPig1,
	[Token(Token = "0x4000680")]
	DefeatBossPig2,
	[Token(Token = "0x4000681")]
	DefeatBossPig3,
	[Token(Token = "0x4000682")]
	DefeatBossPig4,
	[Token(Token = "0x4000683")]
	CollectAllStarsOnBeach,
	[Token(Token = "0x4000684")]
	CollectAllStarsOnCliffs,
	[Token(Token = "0x4000685")]
	CollectAllStarsOnSnow,
	[Token(Token = "0x4000686")]
	CollectAllStarsOnPeak,
	[Token(Token = "0x4000687")]
	CollectAllStarsInVacation,
	[Token(Token = "0x4000688")]
	ActivateChucksAbility,
	[Token(Token = "0x4000689")]
	ActivateBombsAbility,
	[Token(Token = "0x400068A")]
	ActivateBluesAbility,
	[Token(Token = "0x400068B")]
	UnlockSpookyMode,
	[Token(Token = "0x400068C")]
	AlchemyBomb,
	[Token(Token = "0x400068D")]
	EasterEgg1,
	[Token(Token = "0x400068E")]
	CollectAllStarsOnMalibooBeach,
	[Token(Token = "0x400068F")]
	DefeatBossPig5,
	[Token(Token = "0x4000690")]
	EasterEgg2,
	[Token(Token = "0x4000691")]
	CollectAllStarsOnCreepyClimb,
	[Token(Token = "0x4000692")]
	DefeatBossPig6,
	[Token(Token = "0x4000693")]
	CollectAllStarsOnSlimeySlopes,
	[Token(Token = "0x4000694")]
	DefeatBossPig7,
	[Token(Token = "0x4000695")]
	EasterEgg3,
	[Token(Token = "0x4000696")]
	CollectAllStarsOnTerrorPeak,
	[Token(Token = "0x4000697")]
	DefeatBossPig8,
	[Token(Token = "0x4000698")]
	EasterEgg4,
	[Token(Token = "0x4000699")]
	CollectAllStarsInSpooky
}
[Serializable]
[Token(Token = "0x20000C5")]
public class ToolboxSettings
{
	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x768224", Offset = "0x768224")]
	public ParticleEffectComponent effect;

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeToSpawn;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x76825C", Offset = "0x76825C")]
	public bool lockToolboxToPlayer;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 positionToPlayer;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 rotationToPlayer;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x768294", Offset = "0x768294")]
	public Material unaffordableMat;

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x10F28C8", Offset = "0x10F28C8", VA = "0x10F28C8")]
	public ToolboxSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x20000C6")]
public class FontSettings
{
	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TMP_FontAsset alwaysOnTopLatin;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_FontAsset alwaysOnTopAsia;

	[Token(Token = "0x600037F")]
	[Address(RVA = "0xA140A4", Offset = "0xA140A4", VA = "0xA140A4")]
	public FontSettings()
	{
	}
}
[Serializable]
[Token(Token = "0x20000C7")]
public class CreateUserSettings
{
	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Sprite[] userImages;

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x9A87B8", Offset = "0x9A87B8", VA = "0x9A87B8")]
	public CreateUserSettings()
	{
	}
}
[Token(Token = "0x20000C8")]
public sealed class PalazzoTriggers
{
	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly DamageSettings damageSettings;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40006A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Action<bool> onPauseGame;

	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LimitedPool<ScoreEffectComponent>[] scoreEffectPrefabPoolLookup;

	[Token(Token = "0x40006AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly ParticleEffectComponent[] particleEffectPrefabPoolLookup;

	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly List<ScoreEffectComponent> activeScoreEffects;

	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly List<KeyValuePair<string, float>> delayedSounds;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly string[] zoneUpEvents;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly string[] zoneDownEvents;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly int tauntID;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private readonly int happyID;

	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly int madID;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private readonly int scaredID;

	[Token(Token = "0x40006B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly int showOffID;

	[Token(Token = "0x40006B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private readonly int flinchID;

	[Token(Token = "0x40006B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly int fallID;

	[Token(Token = "0x40006B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly string impactMagnitudeName;

	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float impactMagnitudePrev;

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x9BB3B4", Offset = "0x9BB3B4", VA = "0x9BB3B4")]
	public PalazzoTriggers(GameStateData gameStateData, ARTransforms arTransforms, DamageSettings damageSettings, InputHandler inputHandler, LevelContext levelContext, Action<bool> onPauseGame, LimitedPool<ScoreEffectComponent>[] scoreEffectPrefabPoolLookup, ParticleEffectComponent[] particleEffectPrefabPoolLookup, LevelEditorContext levelEditorContext)
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x9BB6FC", Offset = "0x9BB6FC", VA = "0x9BB6FC")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x9BBF58", Offset = "0x9BBF58", VA = "0x9BBF58")]
	private void SetSoundParameter(string eventName, string parameterName, float value, [Optional] Component parent)
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x9BC018", Offset = "0x9BC018", VA = "0x9BC018")]
	public void PlaySound(Component obj, string eventName)
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x9BC0C8", Offset = "0x9BC0C8", VA = "0x9BC0C8")]
	private void PlaySoundAfterDelay(string eventName, float delay)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x9BC1DC", Offset = "0x9BC1DC", VA = "0x9BC1DC")]
	public void StopSound(Component obj, string eventName)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x9BC294", Offset = "0x9BC294", VA = "0x9BC294")]
	private void ResetEventQueue()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x9BC328", Offset = "0x9BC328", VA = "0x9BC328")]
	private ScoreEffectComponent SpawnScoreEffect(Vector3 levelLocalPosition, ScoreEffectComponent prefab)
	{
		return null;
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x9BC63C", Offset = "0x9BC63C", VA = "0x9BC63C")]
	private ParticleEffectComponent SpawnEffect(Vector3 levelLocalPosition, ParticleEffectComponent prefab, bool rotateToLevelPosition)
	{
		return null;
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x9BC7BC", Offset = "0x9BC7BC", VA = "0x9BC7BC")]
	private ParticleEffectComponent SpawnEffectInToolbox(Vector3 itemPosition, ParticleEffectComponent prefab)
	{
		return null;
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x9BC924", Offset = "0x9BC924", VA = "0x9BC924")]
	private ParticleEffectComponent SpawnBlockScoreEffect(Vector3 levelLocalPosition, ParticleEffectComponent prefab)
	{
		return null;
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x9BCC70", Offset = "0x9BCC70", VA = "0x9BCC70")]
	public static void OnPauseAudio()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x9BCCE0", Offset = "0x9BCCE0", VA = "0x9BCCE0")]
	public static void OnUnpauseAudio()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x9BCD50", Offset = "0x9BCD50", VA = "0x9BCD50")]
	public void OnStartGame()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x9BCE24", Offset = "0x9BCE24", VA = "0x9BCE24")]
	public void OnIntroStart(IntroComponent intro)
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x9BCF18", Offset = "0x9BCF18", VA = "0x9BCF18")]
	public void OnIntroStop(IntroComponent intro)
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x9BCFFC", Offset = "0x9BCFFC", VA = "0x9BCFFC")]
	public void OnOutroStart(OutroComponent outro)
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x9BD100", Offset = "0x9BD100", VA = "0x9BD100")]
	public void OnOutroSkip(OutroComponent outro)
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x9BD1D8", Offset = "0x9BD1D8", VA = "0x9BD1D8")]
	public void OnPlayOutroClip(Transform obj, string sound)
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x9BD1DC", Offset = "0x9BD1DC", VA = "0x9BD1DC")]
	public void OnStopOutroClip(Transform obj, string sound)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x9BD1E0", Offset = "0x9BD1E0", VA = "0x9BD1E0")]
	public void OnEnterPartyPeak(OutroComponent outro)
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x9BD27C", Offset = "0x9BD27C", VA = "0x9BD27C")]
	public void OnButtonHover(PalazzoButton button)
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x9BD2CC", Offset = "0x9BD2CC", VA = "0x9BD2CC")]
	public void OnButtonClick(PalazzoButton button)
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x9BD31C", Offset = "0x9BD31C", VA = "0x9BD31C")]
	public void OnDisabledButtonClick(PalazzoButton button)
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x9BD36C", Offset = "0x9BD36C", VA = "0x9BD36C")]
	public void OnWorldImpact(WorldImpactComponent worldImpactComponent, Vector3 levelPosition, PalazzoComponentLevelBlock levelBlock)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x9BD498", Offset = "0x9BD498", VA = "0x9BD498")]
	public void OnImpact(Vector3 levelPosition, BlockTypeData blockTypeData, float impactMagnitude)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x9BD6D4", Offset = "0x9BD6D4", VA = "0x9BD6D4")]
	public void OnBirdImpactPig(Vector3 levelPosition, BlockTypeData blockTypeData)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x9BD734", Offset = "0x9BD734", VA = "0x9BD734")]
	public void OnTeleport()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x9BD7B8", Offset = "0x9BD7B8", VA = "0x9BD7B8")]
	public void OnHoverTeleportationPoint(TeleportationComponent teleportationComponent)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x9BD808", Offset = "0x9BD808", VA = "0x9BD808")]
	public void OnFadeOutStart(CameraFadeComponent camera)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x9BD80C", Offset = "0x9BD80C", VA = "0x9BD80C")]
	public void OnFadeInDone(CameraFadeComponent camera)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x9BD810", Offset = "0x9BD810", VA = "0x9BD810")]
	public void OnScoreboardObjectDespawn(Vector3 levelPosition, Vector3 localScale, ParticleEffectComponent prefabDespawnFx, string soundDespawn)
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x9BD420", Offset = "0x9BD420", VA = "0x9BD420")]
	private bool ShouldRotateToLevel(PalazzoComponentLevelBlock levelBlock)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x9BDA50", Offset = "0x9BDA50", VA = "0x9BDA50")]
	public void OnLevelBlockDestroy(PalazzoComponentLevelBlock levelBlock)
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x9BDBD0", Offset = "0x9BDBD0", VA = "0x9BDBD0")]
	public void OnLevelBlockSpawn(PalazzoComponentLevelBlock levelBlock)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x9BDC9C", Offset = "0x9BDC9C", VA = "0x9BDC9C")]
	public void OnLevelBlockDespawn(PalazzoComponentLevelBlock levelBlock)
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x9BDD68", Offset = "0x9BDD68", VA = "0x9BDD68")]
	public void OnBlockScore(PalazzoComponentLevelBlock levelBlock)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x9BDE0C", Offset = "0x9BDE0C", VA = "0x9BDE0C")]
	public void OnBirdScore(PalazzoComponentBird bird, int score)
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x9BDF68", Offset = "0x9BDF68", VA = "0x9BDF68")]
	public void OnPigScore(PalazzoComponentPig pig, int score, int scoreMultiplier)
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x9BE0DC", Offset = "0x9BE0DC", VA = "0x9BE0DC")]
	public void OnSlingshotTensionStart(PalazzoComponentSlingshot slingshot)
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x9BE140", Offset = "0x9BE140", VA = "0x9BE140")]
	public void OnSlingshotTensionStartBird(PalazzoComponentSlingshot slingshot, PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x9BE210", Offset = "0x9BE210", VA = "0x9BE210")]
	public void OnSlingshotTensionTick(PalazzoComponentSlingshot slingshot, float stringTensionNormalized, float tensionDeltaPerSecond)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x9BE2D8", Offset = "0x9BE2D8", VA = "0x9BE2D8")]
	public void OnSlingshotTensionStop(PalazzoComponentSlingshot slingshot)
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x9BE328", Offset = "0x9BE328", VA = "0x9BE328")]
	public void OnSlingshotTensionStopBird(PalazzoComponentSlingshot slingshot, PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x9BE3D0", Offset = "0x9BE3D0", VA = "0x9BE3D0")]
	public void OnSlingshotLaunch(PalazzoComponentSlingshot slingshot)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x9BE454", Offset = "0x9BE454", VA = "0x9BE454")]
	public void OnSlingshotMaxStart(PalazzoComponentSlingshot slingshot)
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x9BE458", Offset = "0x9BE458", VA = "0x9BE458")]
	public void OnSlingshotMaxStop(PalazzoComponentSlingshot slingshot)
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x9BE45C", Offset = "0x9BE45C", VA = "0x9BE45C")]
	public void OnDamageComponentSwitchState(DamageComponent damage)
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x9BE544", Offset = "0x9BE544", VA = "0x9BE544")]
	public void OnPigSurviveAtLevelEnd(PalazzoComponentPig pig, float delay)
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x9BE5E4", Offset = "0x9BE5E4", VA = "0x9BE5E4")]
	public void OnPigHappyReaction(PalazzoComponentPig pig, float delay)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x9BE684", Offset = "0x9BE684", VA = "0x9BE684")]
	public void OnPigMadReaction(PalazzoComponentPig pig, float delay)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x9BE724", Offset = "0x9BE724", VA = "0x9BE724")]
	public void OnPigScaredReaction(PalazzoComponentPig pig, float delay)
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x9BE7C4", Offset = "0x9BE7C4", VA = "0x9BE7C4")]
	public void OnPigShowOffReaction(PalazzoComponentPig pig, float delay)
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x9BE864", Offset = "0x9BE864", VA = "0x9BE864")]
	public void OnPigFlinchReaction(PalazzoComponentPig pig, float delay)
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x9BE904", Offset = "0x9BE904", VA = "0x9BE904")]
	public void OnPigScreamReactionStart(PalazzoComponentPig pig)
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x9BE954", Offset = "0x9BE954", VA = "0x9BE954")]
	public void OnPigScreamReactionStop(PalazzoComponentPig pig)
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x9BE9A4", Offset = "0x9BE9A4", VA = "0x9BE9A4")]
	public void OnBossPigScreamReactionStart(PalazzoComponentPig bossPig)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x9BE9A8", Offset = "0x9BE9A8", VA = "0x9BE9A8")]
	public void OnBossPigScreamReactionStop(PalazzoComponentPig bossPig)
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x9BE9AC", Offset = "0x9BE9AC", VA = "0x9BE9AC")]
	public void OnPigFallStart(PalazzoComponentPig pig)
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x9BEA38", Offset = "0x9BEA38", VA = "0x9BEA38")]
	public void OnPigFallStop(PalazzoComponentPig pig)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x9BEA3C", Offset = "0x9BEA3C", VA = "0x9BEA3C")]
	public void OnPigSpawn(PalazzoComponentPig pig)
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x9BEB74", Offset = "0x9BEB74", VA = "0x9BEB74")]
	public void OnPigHanging(PalazzoComponentPig pig)
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x9BEBE4", Offset = "0x9BEBE4", VA = "0x9BEBE4")]
	public void OnBirdJumpToSlingshot(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x9BEC7C", Offset = "0x9BEC7C", VA = "0x9BEC7C")]
	public void OnBirdLandInSlingshot(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x9BECEC", Offset = "0x9BECEC", VA = "0x9BECEC")]
	public void OnBirdLandInTensionHand(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x9BED5C", Offset = "0x9BED5C", VA = "0x9BED5C")]
	public void OnBirdGrabbed(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x9BEDE0", Offset = "0x9BEDE0", VA = "0x9BEDE0")]
	public void OnBirdDropped(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x9BEE48", Offset = "0x9BEE48", VA = "0x9BEE48")]
	public void OnBirdLaunch(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x9BEF50", Offset = "0x9BEF50", VA = "0x9BEF50")]
	public void OnBirdActivateAbility(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x9BF00C", Offset = "0x9BF00C", VA = "0x9BF00C")]
	public void OnBirdSpawn(PalazzoComponentBird bird, bool rotateToLevelPosition = false)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x9BF140", Offset = "0x9BF140", VA = "0x9BF140")]
	public void OnBirdStartFuse(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x9BF204", Offset = "0x9BF204", VA = "0x9BF204")]
	public void OnBirdStopFuse(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x9BF2C8", Offset = "0x9BF2C8", VA = "0x9BF2C8")]
	public void OnBirdHitTeleportationPoint(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x9BF2F8", Offset = "0x9BF2F8", VA = "0x9BF2F8")]
	public void OnBirdBlink(PalazzoComponentBird bird)
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x9BF2FC", Offset = "0x9BF2FC", VA = "0x9BF2FC")]
	public void OnScoreboardWin(Scoreboard scoreboard, LevelSettings levelSettings)
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x9BF3AC", Offset = "0x9BF3AC", VA = "0x9BF3AC")]
	public void OnScoreboardLose(LoseScreen loseScreen, PalazzoComponentLevel level)
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x9BF46C", Offset = "0x9BF46C", VA = "0x9BF46C")]
	public void OnScoreboardClose()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x9BF470", Offset = "0x9BF470", VA = "0x9BF470")]
	public void OnScoreboardStar(Scoreboard scoreboard, PalazzoComponentStar star)
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x9BF548", Offset = "0x9BF548", VA = "0x9BF548")]
	public void OnScoreboardCounterStart(Scoreboard scoreboard)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x9BF598", Offset = "0x9BF598", VA = "0x9BF598")]
	public void OnScoreboardCounterPause(Scoreboard scoreboard)
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x9BF5E8", Offset = "0x9BF5E8", VA = "0x9BF5E8")]
	public void OnScoreboardCounterStop(Scoreboard scoreboard)
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x9BF638", Offset = "0x9BF638", VA = "0x9BF638")]
	public void OnScaleScoreObject(ScoreboardBreakdownComponent comp)
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x9BF6E0", Offset = "0x9BF6E0", VA = "0x9BF6E0")]
	public void OnEnterLevelSelect(Theme currentTheme)
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x9BF808", Offset = "0x9BF808", VA = "0x9BF808")]
	public void OnSelectLevel(PalazzoComponentLevel level)
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x9BF88C", Offset = "0x9BF88C", VA = "0x9BF88C")]
	public void OnStartLevel(PalazzoComponentLevel level)
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x9BF930", Offset = "0x9BF930", VA = "0x9BF930")]
	public void OnGameDataReset()
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x9BF934", Offset = "0x9BF934", VA = "0x9BF934")]
	public void OnModeSwitch()
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x9BF9B8", Offset = "0x9BF9B8", VA = "0x9BF9B8")]
	public void OnSwitchWorld(WorldType world, Transform right, Transform left)
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x9C1964", Offset = "0x9C1964", VA = "0x9C1964")]
	public void OnUnlockVacationWorld()
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x9C19E8", Offset = "0x9C19E8", VA = "0x9C19E8")]
	public void OnUnlockSpookyWorld()
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x9C1A98", Offset = "0x9C1A98", VA = "0x9C1A98")]
	public void OnTutorialSpawn(TutorialComponent tutorial)
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x9C1AE8", Offset = "0x9C1AE8", VA = "0x9C1AE8")]
	public void OnTutorialDespawn(TutorialComponent tutorial)
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x9C1AEC", Offset = "0x9C1AEC", VA = "0x9C1AEC")]
	public void SortLevels(OnlineSplitMenu menu)
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x9C1B3C", Offset = "0x9C1B3C", VA = "0x9C1B3C")]
	public static void OnFavorite(PalazzoButton button, bool isFavorited)
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x9C1CE0", Offset = "0x9C1CE0", VA = "0x9C1CE0")]
	public void CreateUserProfile(PalazzoButton button)
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x9C1D30", Offset = "0x9C1D30", VA = "0x9C1D30")]
	public void RandomizeUsernameStart(CreateUserMenu menu)
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x9C1D94", Offset = "0x9C1D94", VA = "0x9C1D94")]
	public void RandomizeUsernameStop(CreateUserMenu menu)
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x9C1DE4", Offset = "0x9C1DE4", VA = "0x9C1DE4")]
	public void Unshare(SideMenu sideMenu)
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x9C1E34", Offset = "0x9C1E34", VA = "0x9C1E34")]
	public void UploadComplete(LevelEditorScoreboard scoreboard)
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x9C1E84", Offset = "0x9C1E84", VA = "0x9C1E84")]
	public void LikeLevel(PalazzoButton button)
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x9C1EFC", Offset = "0x9C1EFC", VA = "0x9C1EFC")]
	public void DislikeLevel(PalazzoButton button)
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x9C1F74", Offset = "0x9C1F74", VA = "0x9C1F74")]
	public void LevelFound(SideMenu sideMenu)
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x9C1F78", Offset = "0x9C1F78", VA = "0x9C1F78")]
	public void LevelNotFound(SideMenu sideMenu)
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x9C1FC8", Offset = "0x9C1FC8", VA = "0x9C1FC8")]
	public void TypeLevelCode(PalazzoButton button)
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x9C1FCC", Offset = "0x9C1FCC", VA = "0x9C1FCC")]
	public void EraseLevelCode(PalazzoButton button)
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x9C1FD0", Offset = "0x9C1FD0", VA = "0x9C1FD0")]
	public void LevelEditorWin()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x9C2070", Offset = "0x9C2070", VA = "0x9C2070")]
	public void LevelEditorLose()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x9C2110", Offset = "0x9C2110", VA = "0x9C2110")]
	public void LevelEditorMusic()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x9C2194", Offset = "0x9C2194", VA = "0x9C2194")]
	public void CustomLevelMusic()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x9C2218", Offset = "0x9C2218", VA = "0x9C2218")]
	public void BirdSelected()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x9C229C", Offset = "0x9C229C", VA = "0x9C229C")]
	public void PerformanceBarFilled(ParticleEffectComponent meterMaxedFx)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x9C2374", Offset = "0x9C2374", VA = "0x9C2374")]
	public void PhysicalButtonPress(PhysicalButton button, ParticleSystem buttonFx)
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x9C241C", Offset = "0x9C241C", VA = "0x9C241C")]
	public void PhysicalButtonPauseEffect(PhysicalButton button, ParticleSystem buttonFx)
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x9C244C", Offset = "0x9C244C", VA = "0x9C244C")]
	public void PhysicalButtonResumeEffect(PhysicalButton button, ParticleSystem buttonFx)
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x9C247C", Offset = "0x9C247C", VA = "0x9C247C")]
	public void PlayButtonPress()
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x9C2558", Offset = "0x9C2558", VA = "0x9C2558")]
	public void OnTriggerPlatformRotation()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x9C25DC", Offset = "0x9C25DC", VA = "0x9C25DC")]
	public void ToolboxObjectSpawn(ToolboxItemComponent block, ParticleEffectComponent spawnFx)
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x9C2640", Offset = "0x9C2640", VA = "0x9C2640")]
	public void OnGrabObject(LevelBuildingBlock block)
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x9C2690", Offset = "0x9C2690", VA = "0x9C2690")]
	public void OnPlaceObject(LevelBuildingBlock block)
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x9C26E0", Offset = "0x9C26E0", VA = "0x9C26E0")]
	public void VRGrab(VRGrab hand)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x9C2730", Offset = "0x9C2730", VA = "0x9C2730")]
	public void OnSaveLevel(PhysicalButton button)
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x9C27F4", Offset = "0x9C27F4", VA = "0x9C27F4")]
	public void OnSaveLevel(PalazzoButton button)
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x9C2844", Offset = "0x9C2844", VA = "0x9C2844")]
	public void OnToggleFinishedCheckbox(bool finished)
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x9C28CC", Offset = "0x9C28CC", VA = "0x9C28CC")]
	public void OnDeletingLevel()
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x9C2950", Offset = "0x9C2950", VA = "0x9C2950")]
	public void OnClearLevel()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x9C29D4", Offset = "0x9C29D4", VA = "0x9C29D4")]
	public void OnSpawnCutscene(int levelIndex, GameObject cutSceneGamobject)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x9C2A70", Offset = "0x9C2A70", VA = "0x9C2A70")]
	public void OnStartCutscene(int levelIndex, GameObject cutSceneGamobject)
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x9C2B54", Offset = "0x9C2B54", VA = "0x9C2B54")]
	public void OnStopCutscene(int levelIndex, GameObject cutSceneGamobject)
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x9C2C38", Offset = "0x9C2C38", VA = "0x9C2C38")]
	public void OnRain(bool on)
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x9C2C3C", Offset = "0x9C2C3C", VA = "0x9C2C3C")]
	public void OnEnvironmentEffect(Component effectOnImpact, string eventName)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x9C2C40", Offset = "0x9C2C40", VA = "0x9C2C40")]
	public void OnEnvironmentAnimateStart(GameObject animatingObject)
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x9C2CF0", Offset = "0x9C2CF0", VA = "0x9C2CF0")]
	public void OnEnvironmentAnimateStop(GameObject animatingObject)
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x9C2DA0", Offset = "0x9C2DA0", VA = "0x9C2DA0")]
	private void OnNightmareLightningStrike(GameObject lightning)
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x9BC588", Offset = "0x9BC588", VA = "0x9BC588")]
	private Vector3 RotateToLevelPosition(Vector3 localPosition)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x20000C9")]
public class PalazzoWorld : MonoBehaviour
{
	[Token(Token = "0x40006B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Theme theme;

	[Token(Token = "0x40006BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public WorldType worldType;

	[Token(Token = "0x40006BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PalazzoComponentLevel[] levels;

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x9C2E50", Offset = "0x9C2E50", VA = "0x9C2E50")]
	public PalazzoWorld()
	{
	}
}
[Token(Token = "0x20000CA")]
[DisallowMultipleComponent]
public sealed class ParticleEffectComponent : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000231")]
	public struct ParticleEffectData
	{
		[Token(Token = "0x4000E8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ParticleSystem particleSystem;

		[Token(Token = "0x4000E8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int emitterCount;
	}

	[Token(Token = "0x40006BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public int prefabPoolToken;

	[Token(Token = "0x40006BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ttl;

	[Token(Token = "0x40006BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleEffectData[] particleEffects;

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x9C2E58", Offset = "0x9C2E58", VA = "0x9C2E58")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x9C30F8", Offset = "0x9C30F8", VA = "0x9C30F8")]
	public ParticleEffectComponent()
	{
	}
}
[Token(Token = "0x20000CB")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766958", Offset = "0x766958")]
public sealed class ParticleSystemPlayOnEnable : MonoBehaviour
{
	[Token(Token = "0x40006BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem system;

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x9C3158", Offset = "0x9C3158", VA = "0x9C3158")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x9C31B0", Offset = "0x9C31B0", VA = "0x9C31B0")]
	public ParticleSystemPlayOnEnable()
	{
	}
}
[Token(Token = "0x20000CC")]
[DisallowMultipleComponent]
public class PhysicalButton : MonoBehaviour
{
	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer disabledMesh;

	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer enabledMesh;

	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject defaultSprite;

	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject hoverSprite;

	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Collider col;

	[Token(Token = "0x40006C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform pushable;

	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ParticleEffectComponent buttonPressFx;

	[Token(Token = "0x40006C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ParticleEffectComponent optionalSaveFx;

	[Token(Token = "0x40006C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public bool isInteractable;

	[Token(Token = "0x40006C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	[HideInInspector]
	public bool isToggled;

	[Token(Token = "0x40006CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	[HideInInspector]
	public bool isInteracting;

	[Token(Token = "0x40006CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public ParticleSystem currentFx;

	[Token(Token = "0x40006CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public bool buttonPressed;

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x9C5100", Offset = "0x9C5100", VA = "0x9C5100")]
	public PhysicalButton()
	{
	}
}
[Token(Token = "0x20000CD")]
public class PhysicalButton<T> : PhysicalButton
{
	[Token(Token = "0x40006CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T buttonType;

	[Token(Token = "0x600040D")]
	public PhysicalButton()
	{
	}
}
[Token(Token = "0x20000CE")]
public sealed class PhysicalButtonHandler<TButton> where TButton : PhysicalButton
{
	[Token(Token = "0x40006CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40006CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly IList<TButton> buttons;

	[Token(Token = "0x40006D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Action<int> onInteract;

	[Token(Token = "0x40006D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly LevelEditorVRController vrController;

	[Token(Token = "0x40006D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40006D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Collider[] interactedColliders;

	[Token(Token = "0x40006D4")]
	private const float OVERLAP_RADIUS = 0.1f;

	[Token(Token = "0x40006D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Vector3 buttonDepth;

	[Token(Token = "0x40006D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Vector3[] handMovementDirection;

	[Token(Token = "0x40006D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Vector3[] handPositionPrev;

	[Token(Token = "0x40006D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly bool[] handHasInteracted;

	[Token(Token = "0x40006D9")]
	private const float DIRECTION_ANGLE_THRESHOLD = 70f;

	[Token(Token = "0x40006DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private TButton currentButton;

	[Token(Token = "0x600040E")]
	public PhysicalButtonHandler(InputHandler inputHandler, IList<TButton> buttons, Action<int> onInteract, LevelEditorVRController vrController, PalazzoTriggers palazzoTriggers)
	{
	}

	[Token(Token = "0x600040F")]
	public void Tick()
	{
	}
}
[Token(Token = "0x20000CF")]
public sealed class PigEmotionalStateHandler
{
	[Token(Token = "0x40006DB")]
	private const float TIME_BEFORE_REACTION = 1f;

	[Token(Token = "0x40006DC")]
	private const float MIN_ANIMATION_DELAY = 0f;

	[Token(Token = "0x40006DD")]
	private const float MAX_ANIMATION_DELAY = 0.3f;

	[Token(Token = "0x40006DE")]
	private const float PLAYER_TOO_CLOSE_DISTANCE = 10f;

	[Token(Token = "0x40006DF")]
	private const float AIM_TOO_CLOSE_DISTANCE = 2f;

	[Token(Token = "0x40006E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40006E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40006E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40006E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x40006E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x40006E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int launchedBirdAtLastHitReaction;

	[Token(Token = "0x40006E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int launchedBirdAtLastLaunchReaction;

	[Token(Token = "0x40006E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int alivePigsAtLastReaction;

	[Token(Token = "0x40006E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float timeSinceChange;

	[Token(Token = "0x40006E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RaycastHit[] raycastHitResult;

	[Token(Token = "0x40006EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int defaultLayerMask;

	[Token(Token = "0x40006EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 offSet;

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x9C5224", Offset = "0x9C5224", VA = "0x9C5224")]
	public PigEmotionalStateHandler(LevelContext levelContext, PalazzoTriggers palazzoTriggers, InputHandler inputHandler, PalazzoComponentSlingshot slingshot, TrajectoryHandler trajectoryHandler)
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x9C53DC", Offset = "0x9C53DC", VA = "0x9C53DC")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x9C53E8", Offset = "0x9C53E8", VA = "0x9C53E8")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x9C5C88", Offset = "0x9C5C88", VA = "0x9C5C88")]
	private float CalcDistanceFromPlayerToPig(PalazzoComponentPig pig)
	{
		return default(float);
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x9C5B5C", Offset = "0x9C5B5C", VA = "0x9C5B5C")]
	private float CalcDistanceFromAimToPig(PalazzoComponentPig pig)
	{
		return default(float);
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x9C5DB4", Offset = "0x9C5DB4", VA = "0x9C5DB4")]
	private float CalcDistanceFromFlyingBirdToPig(PalazzoComponentPig pig)
	{
		return default(float);
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x9C5DBC", Offset = "0x9C5DBC", VA = "0x9C5DBC")]
	private bool IsLevelFalling()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000D0")]
public sealed class PlaceLevelHandler
{
	[Token(Token = "0x40006EC")]
	private const float LEVEL_HEIGHT = 0.4f;

	[Token(Token = "0x40006ED")]
	private const float LEVEL_RADIUS = 0.4f;

	[Token(Token = "0x40006EE")]
	private const float SPHERE_CAST_RADIUS = 0f;

	[Token(Token = "0x40006EF")]
	private const float SPHERE_CAST_DIFF = 0.05f;

	[Token(Token = "0x40006F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40006F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40006F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly GameObject placeLevelIndicator;

	[Token(Token = "0x40006F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x40006F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<Vector3> onPlaceCallback;

	[Token(Token = "0x40006F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Transform placeLevelIndicatorTransform;

	[Token(Token = "0x40006F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly GameObject placementPossibleObject;

	[Token(Token = "0x40006F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly GameObject placementNotPossibleObject;

	[Token(Token = "0x40006F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RaycastHit trajectoryHit;

	[Token(Token = "0x40006F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly Vector3[] rayOffsetDirections;

	[Token(Token = "0x40006FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly List<float> medianHeightCache;

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x9C731C", Offset = "0x9C731C", VA = "0x9C731C")]
	public PlaceLevelHandler(ARTransforms arTransforms, InputHandler inputHandler, GameObject placeLevelIndicator, TrajectoryHandler trajectoryHandler, Action<Vector3> onPlaceCallback)
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x9C7738", Offset = "0x9C7738", VA = "0x9C7738")]
	private bool IsIntersectingTrajectory(Vector3 pos, Vector3 dir, float len)
	{
		return default(bool);
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x9C7820", Offset = "0x9C7820", VA = "0x9C7820")]
	public void Tick()
	{
	}
}
[Token(Token = "0x20000D1")]
public sealed class PlayerConstraintsHandler
{
	[Token(Token = "0x2000232")]
	private enum State
	{
		[Token(Token = "0x4000E8F")]
		Init,
		[Token(Token = "0x4000E90")]
		Play,
		[Token(Token = "0x4000E91")]
		Restrict
	}

	[Token(Token = "0x40006FB")]
	private const float TOO_CLOSE_TO_LEVEL = 6f;

	[Token(Token = "0x40006FC")]
	private const float TOO_FAR_AWAY_FROM_CAMERA_ORIGIN = 1.5f;

	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly GameObject outOfBoundsGameObject;

	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TMP_Text outOfBoundsText;

	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly FontSettings fontSettings;

	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Collider[] hitCollider;

	[Token(Token = "0x4000704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly int layerMask;

	[Token(Token = "0x4000705")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool fade;

	[Token(Token = "0x4000706")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private TMP_FontAsset alwaysOnTopFont;

	[Token(Token = "0x4000707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private State state;

	[Token(Token = "0x4000708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private State prevState;

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x9C95B8", Offset = "0x9C95B8", VA = "0x9C95B8")]
	public PlayerConstraintsHandler(ARTransforms arTransforms, FadeHandler fadeHandler, GameObject outOfBoundsGameObject, WorldContext worldContext, FontSettings fontSettings)
	{
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x9C974C", Offset = "0x9C974C", VA = "0x9C974C")]
	public void Tick()
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x9C9CE0", Offset = "0x9C9CE0", VA = "0x9C9CE0")]
	public bool IsPlayerOutOfBounds()
	{
		return default(bool);
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x9C9AF8", Offset = "0x9C9AF8", VA = "0x9C9AF8")]
	private bool IsTooCloseToLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x9C9C18", Offset = "0x9C9C18", VA = "0x9C9C18")]
	private bool IsTooFarAwayFromCameraOrigin()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000D2")]
public abstract class PrefabPool<T> where T : UnityEngine.Object
{
	[Token(Token = "0x4000709")]
	private const int MAX_CAPACITY = 4096;

	[Token(Token = "0x400070A")]
	private const double INV_LOG2 = 1.44269504088896;

	[Token(Token = "0x400070B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected readonly Transform disabledParentTransform;

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public readonly T prefab;

	[Token(Token = "0x400070D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T[] buffer;

	[Token(Token = "0x400070E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected int capacity;

	[Token(Token = "0x400070F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int size;

	[Token(Token = "0x4000710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int head;

	[Token(Token = "0x4000711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int tail;

	[Token(Token = "0x6000420")]
	protected PrefabPool(Transform disabledParentTransform, T prefab, int capacity)
	{
	}

	[Token(Token = "0x6000421")]
	public void AssertSizeZero()
	{
	}

	[Token(Token = "0x6000422")]
	public void AssertAllObjectsAlive()
	{
	}

	[Token(Token = "0x6000423")]
	protected virtual void IncreaseCapacity(int n)
	{
	}

	[Token(Token = "0x6000424")]
	protected T PopInternal()
	{
		return null;
	}

	[Token(Token = "0x6000425")]
	protected void PushInternal(T obj)
	{
	}
}
[Token(Token = "0x20000D3")]
public sealed class GameObjectPrefabPool : PrefabPool<GameObject>
{
	[Token(Token = "0x6000426")]
	[Address(RVA = "0xA140AC", Offset = "0xA140AC", VA = "0xA140AC")]
	public GameObjectPrefabPool(Transform disabledParentTransform, GameObject prefab, int capacity)
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0xA14124", Offset = "0xA14124", VA = "0xA14124")]
	public GameObject Pop(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0xA141C0", Offset = "0xA141C0", VA = "0xA141C0")]
	public GameObject Pop(Transform parent, Vector3 localPosition, Quaternion localRotation)
	{
		return null;
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0xA1430C", Offset = "0xA1430C", VA = "0xA1430C")]
	public void Push(GameObject obj)
	{
	}
}
[Token(Token = "0x20000D4")]
public sealed class ComponentPrefabPool<T> : PrefabPool<T> where T : Component
{
	[Token(Token = "0x600042A")]
	public ComponentPrefabPool(Transform disabledParentTransform, T prefab, int capacity)
	{
	}

	[Token(Token = "0x600042B")]
	protected override void IncreaseCapacity(int n)
	{
	}

	[Token(Token = "0x600042C")]
	public T Pop(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600042D")]
	public T Pop(Transform parent, Vector3 localPosition, Quaternion localRotation)
	{
		return null;
	}

	[Token(Token = "0x600042E")]
	public void Push(T obj)
	{
	}
}
[Token(Token = "0x20000D5")]
public class LimitedPool<T> where T : Component
{
	[Token(Token = "0x4000712")]
	private const double INV_LOG2 = 1.44269504088896;

	[Token(Token = "0x4000713")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Transform disabledParentTransform;

	[Token(Token = "0x4000714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected T[] buffer;

	[Token(Token = "0x4000715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int capacity;

	[Token(Token = "0x4000716")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int endIndex;

	[Token(Token = "0x4000717")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int startIndex;

	[Token(Token = "0x1700001D")]
	public int Size
	{
		[Token(Token = "0x600042F")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001E")]
	private T[] Buffer
	{
		[Token(Token = "0x6000430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001F")]
	public int Capacity
	{
		[Token(Token = "0x6000431")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000020")]
	public int StartIndex
	{
		[Token(Token = "0x6000432")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000021")]
	public int EndIndex
	{
		[Token(Token = "0x6000433")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000434")]
	public LimitedPool(Transform disabledParentTransform, T prefab, int capacity)
	{
	}

	[Token(Token = "0x6000435")]
	public T Pop(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000436")]
	public T Pop(Transform parent, Vector3 localPosition, Quaternion localRotation)
	{
		return null;
	}

	[Token(Token = "0x6000437")]
	public void Push(T obj)
	{
	}

	[Token(Token = "0x6000438")]
	private T PopInternal()
	{
		return null;
	}

	[Token(Token = "0x6000439")]
	private void PushInternal(T obj)
	{
	}

	[Token(Token = "0x600043A")]
	protected int Allocate()
	{
		return default(int);
	}

	[Token(Token = "0x600043B")]
	protected int Deallocate()
	{
		return default(int);
	}

	[Token(Token = "0x600043C")]
	public void Clear()
	{
	}
}
[Token(Token = "0x20000D6")]
public class PreviewHandler
{
	[Token(Token = "0x2000233")]
	private enum State
	{
		[Token(Token = "0x4000E93")]
		Init,
		[Token(Token = "0x4000E94")]
		Despawning,
		[Token(Token = "0x4000E95")]
		Spawning,
		[Token(Token = "0x4000E96")]
		Preview
	}

	[Token(Token = "0x4000718")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private State state;

	[Token(Token = "0x4000719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private State prevState;

	[Token(Token = "0x400071A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x400071B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelFactory levelFactory;

	[Token(Token = "0x400071C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x400071D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Transform levelRoot;

	[Token(Token = "0x400071E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Level currentLevelBeingPreviewed;

	[Token(Token = "0x400071F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Level queuedPreviewLevel;

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x9C9D3C", Offset = "0x9C9D3C", VA = "0x9C9D3C")]
	public PreviewHandler(LevelContext levelContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelRoot)
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x9C9D88", Offset = "0x9C9D88", VA = "0x9C9D88")]
	public void Tick()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x9C9FE8", Offset = "0x9C9FE8", VA = "0x9C9FE8")]
	public void Preview(Level level)
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x9CA0A8", Offset = "0x9CA0A8", VA = "0x9CA0A8")]
	public void InstantDespawn()
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x9CA1B8", Offset = "0x9CA1B8", VA = "0x9CA1B8")]
	public void Despawn()
	{
	}
}
[Token(Token = "0x20000D7")]
public sealed class ProgressMeter : MonoBehaviour
{
	[Token(Token = "0x4000720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Renderer renderer;

	[NonSerialized]
	[Token(Token = "0x4000721")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float mainProgress;

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x9CB294", Offset = "0x9CB294", VA = "0x9CB294")]
	public ProgressMeter()
	{
	}
}
[Token(Token = "0x20000D8")]
[DisallowMultipleComponent]
public sealed class ScoreEffectComponent : MonoBehaviour
{
	[Token(Token = "0x4000722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public int prefabPoolToken;

	[Token(Token = "0x4000723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform effectTransform;

	[Token(Token = "0x4000724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro scoreText;

	[Token(Token = "0x4000725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float stayAliveForSeconds;

	[Token(Token = "0x4000726")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AnimationCurve alphaAnimation;

	[Token(Token = "0x4000727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve scaleAnimation;

	[Token(Token = "0x4000728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AnimationCurve forwardAnimation;

	[Token(Token = "0x4000729")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve heightAnimation;

	[NonSerialized]
	[Token(Token = "0x400072A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float elapsedTimeNormalized;

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x9E1820", Offset = "0x9E1820", VA = "0x9E1820")]
	public ScoreEffectComponent()
	{
	}
}
[Token(Token = "0x20000D9")]
[DisallowMultipleComponent]
public class SettingsControlsComponent : MonoBehaviour
{
	[Token(Token = "0x400072B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshPro trigger;

	[Token(Token = "0x400072C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshPro pause;

	[Token(Token = "0x400072D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro recenter;

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x9E97FC", Offset = "0x9E97FC", VA = "0x9E97FC")]
	public SettingsControlsComponent()
	{
	}
}
[Token(Token = "0x20000DA")]
public class SlideIndicator : MonoBehaviour
{
	[Token(Token = "0x400072E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x76834C", Offset = "0x76834C")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x76834C", Offset = "0x76834C")]
	public GameObject deselected;

	[Token(Token = "0x400072F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7683AC", Offset = "0x7683AC")]
	public GameObject selected;

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x9EB0A4", Offset = "0x9EB0A4", VA = "0x9EB0A4")]
	public SlideIndicator()
	{
	}
}
[Token(Token = "0x20000DB")]
public sealed class SlingshotAimHandler
{
	[Token(Token = "0x4000730")]
	private const float STRING_TENSION_THRESHOLD = 0.1f;

	[Token(Token = "0x4000731")]
	private const float HANDS_DISTANCE_THRESHOLD = 0.015f;

	[Token(Token = "0x4000732")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000733")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PhysicsSettings physicsSettings;

	[Token(Token = "0x4000734")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly SlingshotSettings slingshotSettings;

	[Token(Token = "0x4000735")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TrajectoryMarkerSettings trajectoryMarkerSettings;

	[Token(Token = "0x4000736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x4000737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400073A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x400073B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly TensionHand tensionHand;

	[Token(Token = "0x400073C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x400073D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly Transform slingshotTransform;

	[Token(Token = "0x400073E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly int slingshotStateNameHash;

	[Token(Token = "0x400073F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private readonly float tensionDistanceMax;

	[Token(Token = "0x4000740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly int layerMask;

	[Token(Token = "0x4000741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float stringTensionNormalizedPrev;

	[Token(Token = "0x4000742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool prevEnoughForce;

	[Token(Token = "0x4000743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool prevIsAiming;

	[Token(Token = "0x4000744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
	private bool hasReleased;

	[Token(Token = "0x4000745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
	private bool isTensionMax;

	[Token(Token = "0x4000746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private readonly Vector3 slingshotPocketOriginalPositionInSlingshotSpace;

	[Token(Token = "0x4000747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 launchBirdPosition;

	[Token(Token = "0x4000748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float onLaunchMagnitude;

	[Token(Token = "0x4000749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float onLaunchFactor;

	[Token(Token = "0x400074A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Quaternion slingshotLaunchRotation;

	[Token(Token = "0x400074B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float timeSinceLastBird;

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x9EB0AC", Offset = "0x9EB0AC", VA = "0x9EB0AC")]
	public SlingshotAimHandler(ARTransforms arTransforms, PhysicsSettings physicsSettings, SlingshotSettings slingshotSettings, TrajectoryMarkerSettings trajectoryMarkerSettings, PalazzoComponentSlingshot slingshot, InputHandler inputHandler, LevelContext levelContext, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, TensionHand tensionHand, PalazzoGameDataPersistent gameDataPersistent)
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x9EB38C", Offset = "0x9EB38C", VA = "0x9EB38C")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x9EB618", Offset = "0x9EB618", VA = "0x9EB618")]
	private bool IsIntersectingTrajectory(Vector3 pos, Vector3 dir, float len)
	{
		return default(bool);
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x9EB688", Offset = "0x9EB688", VA = "0x9EB688")]
	public void LateTick()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x9EB90C", Offset = "0x9EB90C", VA = "0x9EB90C")]
	public void Tick()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x9ECCE0", Offset = "0x9ECCE0", VA = "0x9ECCE0")]
	private void HandleSlingshotRelease(PalazzoComponentBird releasedBird)
	{
	}
}
[Token(Token = "0x20000DC")]
public sealed class SlingshotLoader
{
	[Token(Token = "0x2000234")]
	private enum State
	{
		[Token(Token = "0x4000E98")]
		IdleEnter,
		[Token(Token = "0x4000E99")]
		Idle,
		[Token(Token = "0x4000E9A")]
		Cooldown,
		[Token(Token = "0x4000E9B")]
		JumpEnter,
		[Token(Token = "0x4000E9C")]
		Jump,
		[Token(Token = "0x4000E9D")]
		JumpExit
	}

	[Token(Token = "0x400074C")]
	private const float BIRD_JUMP_COOLDOWN = 1f;

	[Token(Token = "0x400074D")]
	private const float BIRD_JUMP_STEP = 0.2f;

	[Token(Token = "0x400074E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x400074F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x4000751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private State state;

	[Token(Token = "0x4000753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float timeInJump;

	[Token(Token = "0x4000754")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float cooldown;

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x9ECF48", Offset = "0x9ECF48", VA = "0x9ECF48")]
	public SlingshotLoader(LevelContext levelContext, PalazzoTriggers palazzoTriggers, PalazzoComponentSlingshot slingshot, InputHandler inputHandler)
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x9ECF94", Offset = "0x9ECF94", VA = "0x9ECF94")]
	public void Reset()
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x9ECF9C", Offset = "0x9ECF9C", VA = "0x9ECF9C")]
	public void Tick()
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x9ED65C", Offset = "0x9ED65C", VA = "0x9ED65C")]
	public void OnTeleport(TeleportationData teleportationData)
	{
	}
}
[Token(Token = "0x20000DD")]
public class LookAtPlayer : StateMachineBehaviour
{
	[Token(Token = "0x4000755")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string lookAtParameterName;

	[Token(Token = "0x6000450")]
	[Address(RVA = "0xA0CE0C", Offset = "0xA0CE0C", VA = "0xA0CE0C", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0xA0CE7C", Offset = "0xA0CE7C", VA = "0xA0CE7C", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0xA0CEEC", Offset = "0xA0CEEC", VA = "0xA0CEEC")]
	public LookAtPlayer()
	{
	}
}
[Token(Token = "0x20000DE")]
public sealed class PigScared : StateMachineBehaviour
{
	[Token(Token = "0x4000756")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem scaredParticles;

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x9C71D0", Offset = "0x9C71D0", VA = "0x9C71D0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x9C7314", Offset = "0x9C7314", VA = "0x9C7314")]
	public PigScared()
	{
	}
}
[Token(Token = "0x20000DF")]
public class RandomAnimationChooser : StateMachineBehaviour
{
	[Token(Token = "0x4000757")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int numOfAvailableAnimations;

	[Token(Token = "0x4000758")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string intParameterName;

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x9DC4B8", Offset = "0x9DC4B8", VA = "0x9DC4B8", Slot = "9")]
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x9DC51C", Offset = "0x9DC51C", VA = "0x9DC51C")]
	public RandomAnimationChooser()
	{
	}
}
[Token(Token = "0x20000E0")]
public class SetBoolTrueOnExit : StateMachineBehaviour
{
	[Token(Token = "0x4000759")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string boolParameterName;

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x9E97AC", Offset = "0x9E97AC", VA = "0x9E97AC", Slot = "10")]
	public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x9E97F4", Offset = "0x9E97F4", VA = "0x9E97F4")]
	public SetBoolTrueOnExit()
	{
	}
}
[Token(Token = "0x20000E1")]
public class TelePointHandler
{
	[Token(Token = "0x2000235")]
	private enum State
	{
		[Token(Token = "0x4000E9F")]
		Init,
		[Token(Token = "0x4000EA0")]
		Hidden,
		[Token(Token = "0x4000EA1")]
		Show,
		[Token(Token = "0x4000EA2")]
		WaitForBirdToLandInSlingshot,
		[Token(Token = "0x4000EA3")]
		FadeAndTeleport
	}

	[Token(Token = "0x400075A")]
	private const float CONSIDERED_SAME_POINT_DISTANCE_THRESHOLD = 5f;

	[Token(Token = "0x400075B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x400075C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x400075D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400075E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400075F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000760")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000761")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x4000762")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly Action<TeleportationData> onTeleport;

	[Token(Token = "0x4000763")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x4000764")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000765")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly Vector3 originalPosition;

	[Token(Token = "0x4000766")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private readonly Vector3 originalScale;

	[Token(Token = "0x4000767")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float timer;

	[Token(Token = "0x4000768")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private State state;

	[Token(Token = "0x4000769")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private State prevState;

	[Token(Token = "0x400076A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly List<TeleportationComponent> points;

	[Token(Token = "0x400076B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private TeleportationComponent currentTeleportationPoint;

	[Token(Token = "0x400076C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private TeleportationComponent pointToTeleportTo;

	[Token(Token = "0x400076D")]
	private const float HOVER_AMPLITUDE = 0.5f;

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x10E9468", Offset = "0x10E9468", VA = "0x10E9468")]
	public TelePointHandler(TeleportationHandler teleportationHandler, GameStateData gameStateData, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, LevelContext levelContext, FadeHandler fadeHandler, Action<TeleportationData> onTeleport, PalazzoComponentBirdPlatform birdPlatform, LevelEditorPlayContext levelEditorPlayContext)
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x10E961C", Offset = "0x10E961C", VA = "0x10E961C")]
	public void Reset(bool isRestartingLevel = false)
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x10E972C", Offset = "0x10E972C", VA = "0x10E972C")]
	public void Tick()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x10EAB40", Offset = "0x10EAB40", VA = "0x10EAB40")]
	private static bool IsConsideredSamePoint(Vector3 position1, Vector3 position2)
	{
		return default(bool);
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x10EA9FC", Offset = "0x10EA9FC", VA = "0x10EA9FC")]
	private void SetCurrentPoint(TeleportationComponent point)
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x10E9D30", Offset = "0x10E9D30", VA = "0x10E9D30")]
	private void SetClosestPointAsCurrent()
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x10EA0A4", Offset = "0x10EA0A4", VA = "0x10EA0A4")]
	private void HandlePointState(TeleportationComponent point)
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x10EAC00", Offset = "0x10EAC00", VA = "0x10EAC00")]
	private void UpdatePointVisuals(TeleportationComponent point)
	{
	}
}
[Token(Token = "0x20000E2")]
public class TelePointLevelEditor : MonoBehaviour
{
	[Token(Token = "0x400076E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public new GameObject enabled;

	[Token(Token = "0x400076F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject disabled;

	[Token(Token = "0x4000770")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject hover;

	[Token(Token = "0x4000771")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform meshRoot;

	[Token(Token = "0x4000772")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform rotatingGeo;

	[Token(Token = "0x4000773")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public bool isEnabled;

	[Token(Token = "0x4000774")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[HideInInspector]
	public bool isEnabledPrev;

	[Token(Token = "0x4000775")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	[HideInInspector]
	public bool isHovered;

	[Token(Token = "0x4000776")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public float timer;

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x10EAE24", Offset = "0x10EAE24", VA = "0x10EAE24")]
	public TelePointLevelEditor()
	{
	}
}
[Token(Token = "0x20000E3")]
public class TelePointLevelEditorHandler
{
	[Token(Token = "0x2000236")]
	private enum State
	{
		[Token(Token = "0x4000EA5")]
		Init,
		[Token(Token = "0x4000EA6")]
		Editing
	}

	[Token(Token = "0x4000777")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000778")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x4000779")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelEditorVRController vrController;

	[Token(Token = "0x400077A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x400077B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly int layerMask;

	[Token(Token = "0x400077C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly TelePointLevelEditor[] hoveredTelePoint;

	[Token(Token = "0x400077D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly RaycastHit[] hits;

	[Token(Token = "0x400077E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private TelePointLevelEditor[] telePoints;

	[Token(Token = "0x400077F")]
	private const float ORIGINAL_HEIGHT = -3.5f;

	[Token(Token = "0x4000780")]
	private const float HOVER_AMPLITUDE = 0.5f;

	[Token(Token = "0x4000781")]
	private const float HOVER_FREQUENCY = 1.5625f;

	[Token(Token = "0x4000782")]
	private const float SCALE_AMPLITUDE = 0.2f;

	[Token(Token = "0x4000783")]
	private const float SCALE_FREQUENCY = 3.5f;

	[Token(Token = "0x4000784")]
	private const float LERP_SPEED = 5f;

	[Token(Token = "0x4000785")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private State state;

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x10EAE2C", Offset = "0x10EAE2C", VA = "0x10EAE2C")]
	public TelePointLevelEditorHandler(InputHandler inputHandler, TrajectoryHandler trajectoryHandler, LevelEditorContext levelEditorContext, LevelEditorVRController vrController)
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x10EAF58", Offset = "0x10EAF58", VA = "0x10EAF58")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x10EC250", Offset = "0x10EC250", VA = "0x10EC250")]
	public void Reset()
	{
	}
}
[Token(Token = "0x20000E4")]
public class TeleportAimHandler
{
	[Token(Token = "0x4000786")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x4000787")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000788")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000789")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x400078A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly TeleportationHandler teleportationHandler;

	[Token(Token = "0x400078B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly PlayerConstraintsHandler playerConstraintsHandler;

	[Token(Token = "0x400078C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x400078D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly TensionHand tensionHand;

	[Token(Token = "0x400078E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool> onTeleportHovering;

	[Token(Token = "0x400078F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly int layerMask;

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x10EC2F0", Offset = "0x10EC2F0", VA = "0x10EC2F0")]
	public TeleportAimHandler(PalazzoComponentSlingshot slingshot, InputHandler inputHandler, LevelContext levelContext, TrajectoryHandler trajectoryHandler, TeleportationHandler teleportationHandler, PlayerConstraintsHandler playerConstraintsHandler, FadeHandler fadeHandler, TensionHand tensionHand, Action<bool> onTeleportHovering)
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x10EC41C", Offset = "0x10EC41C", VA = "0x10EC41C")]
	public void Tick()
	{
	}
}
[Token(Token = "0x20000E5")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7669FC", Offset = "0x7669FC")]
public sealed class TeleportationComponent : MonoBehaviour
{
	[Token(Token = "0x4000790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PalazzoComponentLevelBlock levelBlock;

	[Token(Token = "0x4000791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject regularMarkerGeo;

	[Token(Token = "0x4000792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject arrowIconGeo;

	[Token(Token = "0x4000793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject hoverVisual;

	[Token(Token = "0x4000794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool useCustomPlacement;

	[Token(Token = "0x4000795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 birdPlatformOffset;

	[Token(Token = "0x4000796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 birdPlatformRotation;

	[Token(Token = "0x4000797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public TeleportationPointState state;

	[Token(Token = "0x4000798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TeleportationPointState prevState;

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x10EC9A0", Offset = "0x10EC9A0", VA = "0x10EC9A0")]
	public TeleportationComponent()
	{
	}
}
[Token(Token = "0x20000E6")]
public enum TeleportationPointState
{
	[Token(Token = "0x400079A")]
	Idle,
	[Token(Token = "0x400079B")]
	Hover,
	[Token(Token = "0x400079C")]
	Current
}
[Token(Token = "0x20000E7")]
public sealed class TeleportationHandler
{
	[Token(Token = "0x2000237")]
	private struct PositionData
	{
		[Token(Token = "0x4000EA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x4000EA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 playerOffset;

		[Token(Token = "0x4000EA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 forward;

		[Token(Token = "0x4000EAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 scale;

		[Token(Token = "0x4000EAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 birdPlatformPosition;

		[Token(Token = "0x4000EAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion birdPlatformRotation;

		[Token(Token = "0x4000EAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool birdPlatformActive;

		[Token(Token = "0x4000EAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3? lastActivePosition;
	}

	[Token(Token = "0x400079D")]
	private const float CONSIDERED_SAME_POINT_DISTANCE_THRESHOLD = 5f;

	[Token(Token = "0x400079E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x400079F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x40007A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly FadeHandler fadeHandler;

	[Token(Token = "0x40007A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PalazzoComponentBirdPlatform birdPlatform;

	[Token(Token = "0x40007A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<TeleportationData> onTeleport;

	[Token(Token = "0x40007A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 defaultBirdPlatformOffset;

	[Token(Token = "0x40007A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly Quaternion defaultBirdPlatformRotation;

	[Token(Token = "0x40007A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float timer;

	[Token(Token = "0x40007A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private PositionData nextPositionData;

	[Token(Token = "0x40007A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private readonly Vector3 playerHeight;

	[Token(Token = "0x40007A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool isTeleportingPrev;

	[Token(Token = "0x40007A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x768424", Offset = "0x768424")]
	private bool <IsTeleporting>k__BackingField;

	[Token(Token = "0x17000022")]
	public bool IsTeleporting
	{
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x10EC998", Offset = "0x10EC998", VA = "0x10EC998")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A968", Offset = "0x76A968")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x10ECA3C", Offset = "0x10ECA3C", VA = "0x10ECA3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A958", Offset = "0x76A958")]
		private set
		{
		}
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x10ECA48", Offset = "0x10ECA48", VA = "0x10ECA48")]
	public TeleportationHandler(ARTransforms arTransforms, WorldContext worldContext, FadeHandler fadeHandler, PalazzoComponentBirdPlatform birdPlatform, Action<TeleportationData> onTeleport)
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x10ECB40", Offset = "0x10ECB40", VA = "0x10ECB40")]
	public void Tick()
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x10ECBF8", Offset = "0x10ECBF8", VA = "0x10ECBF8")]
	private void MoveToNextPositionData()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x10EA744", Offset = "0x10EA744", VA = "0x10EA744")]
	public void GoToTeleportationPoint(TeleportationComponent pointToTeleportTo)
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x10ED024", Offset = "0x10ED024", VA = "0x10ED024")]
	public void GoToSceneStartPosition(bool enableBirdPlatform = true, bool instantly = false)
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x10ED32C", Offset = "0x10ED32C", VA = "0x10ED32C")]
	public void GoToLevelEditingPosition(bool instantly = true)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x10ECF44", Offset = "0x10ECF44", VA = "0x10ECF44")]
	private void SetNextPositionData(PositionData positionData)
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x10ED514", Offset = "0x10ED514", VA = "0x10ED514")]
	public bool IsAtSceneStartPosition()
	{
		return default(bool);
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x10ED674", Offset = "0x10ED674", VA = "0x10ED674")]
	public bool IsAtPreviousTeleportPosition()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000E8")]
public class TeleportationData
{
	[Token(Token = "0x40007AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform previousTransform;

	[Token(Token = "0x40007AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform newTransform;

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x10EA9F4", Offset = "0x10EA9F4", VA = "0x10EA9F4")]
	public TeleportationData()
	{
	}
}
[Token(Token = "0x20000E9")]
public class TensionHand : MonoBehaviour
{
	[Token(Token = "0x40007AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer tensionHandMarker;

	[Token(Token = "0x40007AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer hoverHandMarker;

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x10ED8A0", Offset = "0x10ED8A0", VA = "0x10ED8A0")]
	public TensionHand()
	{
	}
}
[Token(Token = "0x20000EA")]
public sealed class Toolbox : MonoBehaviour
{
	[Token(Token = "0x40007AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<ToolboxButton> buttons;

	[Token(Token = "0x40007AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<ToolboxTabComponent> tabs;

	[Token(Token = "0x40007B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public BirdTabComponent birdTab;

	[Token(Token = "0x40007B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TutorialTabComponent tutorialTab;

	[Token(Token = "0x40007B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject blockMaterials;

	[Token(Token = "0x40007B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Collider deletionCollider;

	[Token(Token = "0x40007B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public VRGrabbable grabbable;

	[Token(Token = "0x40007B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x768434", Offset = "0x768434")]
	public MeshRenderer blockMeterRenderer;

	[Token(Token = "0x40007B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material blockMeterMaterial;

	[Token(Token = "0x40007B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ParticleEffectComponent meterMaxedFx;

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x10EDD0C", Offset = "0x10EDD0C", VA = "0x10EDD0C")]
	public Toolbox()
	{
	}
}
[Token(Token = "0x20000EB")]
public sealed class ToolboxBarHandler
{
	[Token(Token = "0x40007B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly MeshRenderer barRenderer;

	[Token(Token = "0x40007B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x40007BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelEditorSettings levelEditorSettings;

	[Token(Token = "0x40007BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly MaterialPropertyBlock materialPropertyBlock;

	[Token(Token = "0x40007BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int fillRate;

	[Token(Token = "0x40007BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int reserveRate;

	[Token(Token = "0x40007BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly int reserveFrequency;

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x10EDD14", Offset = "0x10EDD14", VA = "0x10EDD14")]
	public ToolboxBarHandler(MeshRenderer barRenderer, LevelEditorContext levelEditorContext, LevelEditorSettings levelEditorSettings)
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x10EDE3C", Offset = "0x10EDE3C", VA = "0x10EDE3C")]
	public void Tick()
	{
	}
}
[Token(Token = "0x20000EC")]
public enum ToolboxButtonType
{
	[Token(Token = "0x40007C0")]
	Blocks,
	[Token(Token = "0x40007C1")]
	Blocks_Wood,
	[Token(Token = "0x40007C2")]
	Blocks_Ice,
	[Token(Token = "0x40007C3")]
	Blocks_Rock,
	[Token(Token = "0x40007C4")]
	Pigs,
	[Token(Token = "0x40007C5")]
	Special,
	[Token(Token = "0x40007C6")]
	Decoration,
	[Token(Token = "0x40007C7")]
	Birds,
	[Token(Token = "0x40007C8")]
	Menu,
	[Token(Token = "0x40007C9")]
	TryPlay,
	[Token(Token = "0x40007CA")]
	Save,
	[Token(Token = "0x40007CB")]
	NewSave,
	[Token(Token = "0x40007CC")]
	ManageLevels,
	[Token(Token = "0x40007CD")]
	Quit,
	[Token(Token = "0x40007CE")]
	Yes,
	[Token(Token = "0x40007CF")]
	No,
	[Token(Token = "0x40007D0")]
	EditTools,
	[Token(Token = "0x40007D1")]
	ToggleTelePoints,
	[Token(Token = "0x40007D2")]
	Undo,
	[Token(Token = "0x40007D3")]
	Redo,
	[Token(Token = "0x40007D4")]
	Clear,
	[Token(Token = "0x40007D5")]
	Tutorial,
	[Token(Token = "0x40007D6")]
	Next,
	[Token(Token = "0x40007D7")]
	Back
}
[Token(Token = "0x20000ED")]
public sealed class ToolboxButton : PhysicalButton<ToolboxButtonType>
{
	[Token(Token = "0x600047A")]
	[Address(RVA = "0x10EE158", Offset = "0x10EE158", VA = "0x10EE158")]
	public ToolboxButton()
	{
	}
}
[Token(Token = "0x20000EE")]
public sealed class ToolboxHandler
{
	[Token(Token = "0x2000238")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767424", Offset = "0x767424")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x4000EAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InputHandler inputHandler;

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x10EEB80", Offset = "0x10EEB80", VA = "0x10EEB80")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x10F212C", Offset = "0x10F212C", VA = "0x10F212C")]
		internal void <.ctor>b__0(VRGrab grab)
		{
		}
	}

	[Token(Token = "0x2000239")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767434", Offset = "0x767434")]
	private sealed class <ShowItems>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000EB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000EB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000EB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ToolboxHandler <>4__this;

		[Token(Token = "0x17000112")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x10F2674", Offset = "0x10F2674", VA = "0x10F2674", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000113")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x10F26E4", Offset = "0x10F26E4", VA = "0x10F26E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x10F2058", Offset = "0x10F2058", VA = "0x10F2058")]
		[DebuggerHidden]
		public <ShowItems>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x10F2190", Offset = "0x10F2190", VA = "0x10F2190", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x10F2194", Offset = "0x10F2194", VA = "0x10F2194", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x10F267C", Offset = "0x10F267C", VA = "0x10F267C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x40007D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40007DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Toolbox toolbox;

	[Token(Token = "0x40007DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly PhysicalButtonHandler<ToolboxButton> buttonHandler;

	[Token(Token = "0x40007DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action onTryPlay;

	[Token(Token = "0x40007DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40007DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<MenuType> openMenu;

	[Token(Token = "0x40007DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly Action<ToolboxItemComponent, VRGrab> onGrab;

	[Token(Token = "0x40007E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action onClearLevel;

	[Token(Token = "0x40007E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly ToolboxSettings toolboxSettings;

	[Token(Token = "0x40007E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x40007E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40007E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly LevelEditorSettings levelEditorSettings;

	[Token(Token = "0x40007E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly Action undo;

	[Token(Token = "0x40007E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly Action redo;

	[Token(Token = "0x40007E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly ToolboxTabComponent[] tabs;

	[Token(Token = "0x40007E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly List<ToolboxButton> tabButtons;

	[Token(Token = "0x40007E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly ToolboxButton saveButton;

	[Token(Token = "0x40007EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly ToolboxButton undoButton;

	[Token(Token = "0x40007EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly ToolboxButton redoButton;

	[Token(Token = "0x40007EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly ToolboxButton clearButton;

	[Token(Token = "0x40007ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly ToolboxItemInteractionHandler[] itemInteractionHandlers;

	[Token(Token = "0x40007EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly BirdSelectionHandler birdSelectionHandler;

	[Token(Token = "0x40007EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly TutorialTabHandler tutorialTabHandler;

	[Token(Token = "0x40007F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly ToolboxBarHandler toolboxBarHandler;

	[Token(Token = "0x40007F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly TelePointLevelEditorHandler telePointHandler;

	[Token(Token = "0x40007F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private TabType activeTab;

	[Token(Token = "0x40007F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private TabType prevBlockTab;

	[Token(Token = "0x40007F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ToolboxButtonType prevButtonPress;

	[Token(Token = "0x40007F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private ToolboxButton toggleTelepointButton;

	[Token(Token = "0x40007F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly WaitForSeconds toolboxSpawnTime;

	[Token(Token = "0x40007F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly Material[][] unaffordableMats;

	[Token(Token = "0x40007F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool isEditingTelePoints;

	[Token(Token = "0x40007F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	private bool isEditingTelePointsPrev;

	[Token(Token = "0x40007FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
	private bool isClearConfirmation;

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x10EE1A8", Offset = "0x10EE1A8", VA = "0x10EE1A8")]
	public ToolboxHandler(MonoBehaviour monoBehaviour, ARTransforms arTransforms, InputHandler inputHandler, Toolbox toolbox, LevelEditorVRController vrController, Action onTryPlay, PalazzoTriggers palazzoTriggers, Action<MenuType> openMenu, Action<ToolboxItemComponent, VRGrab> onGrab, Action onClearLevel, ToolboxSettings toolboxSettings, LevelEditorContext levelEditorContext, LevelEditorPlayContext levelEditorPlayContext, LevelEditorSettings levelEditorSettings, LevelEditorComponent levelEditor, TrajectoryHandler trajectoryHandler, Action redo, Action undo)
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x10EF3DC", Offset = "0x10EF3DC", VA = "0x10EF3DC")]
	public void Reset()
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x10EF600", Offset = "0x10EF600", VA = "0x10EF600")]
	public void Tick()
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x10EFA84", Offset = "0x10EFA84", VA = "0x10EFA84")]
	private void TickAffordableItems()
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x10F08A4", Offset = "0x10F08A4", VA = "0x10F08A4")]
	public void SetPositionByPlayer()
	{
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x10F0A7C", Offset = "0x10F0A7C", VA = "0x10F0A7C")]
	private void OnButtonInteract(int buttonIndex)
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x10F1FE4", Offset = "0x10F1FE4", VA = "0x10F1FE4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76A978", Offset = "0x76A978")]
	public IEnumerator ShowItems()
	{
		return null;
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x10F2084", Offset = "0x10F2084", VA = "0x10F2084")]
	private void OnItemInteract(ToolboxItemComponent item, VRGrab grab)
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x10F20FC", Offset = "0x10F20FC", VA = "0x10F20FC")]
	public void SetBirds()
	{
	}
}
[Token(Token = "0x20000EF")]
public sealed class ToolboxItemComponent : MonoBehaviour
{
	[Token(Token = "0x40007FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Prefab prefabReference;

	[Token(Token = "0x40007FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Collider col;

	[Token(Token = "0x40007FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public bool increaseSize;

	[Token(Token = "0x40007FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public Vector3 defaultScale;

	[Token(Token = "0x40007FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Transform child;

	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public bool isAfforded;

	[Token(Token = "0x4000801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public Material[][] originalMaterials;

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x10F26EC", Offset = "0x10F26EC", VA = "0x10F26EC")]
	public ToolboxItemComponent()
	{
	}
}
[Token(Token = "0x20000F0")]
public class ToolboxItemInteractionHandler
{
	[Token(Token = "0x4000802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly IEnumerable<ToolboxItemComponent> items;

	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Action<ToolboxItemComponent, VRGrab> onInteract;

	[Token(Token = "0x4000805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action<ToolboxItemComponent, VRGrab> onDrag;

	[Token(Token = "0x4000806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<ToolboxItemComponent, VRGrab> onRelease;

	[Token(Token = "0x4000807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelEditorVRController vrController;

	[Token(Token = "0x4000808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly LevelEditorSettings levelEditorSettings;

	[Token(Token = "0x400080A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x400080B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly ToolboxItemComponent[] grabbedItems;

	[Token(Token = "0x400080C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly ToolboxItemComponent[] highlightedItems;

	[Token(Token = "0x400080D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly VRGrab[] grabs;

	[Token(Token = "0x400080E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly Collider[] overlapColliders;

	[Token(Token = "0x400080F")]
	private const float GRAB_RADIUS = 0.3f;

	[Token(Token = "0x4000810")]
	private const float MAX_TIME = 1f;

	[Token(Token = "0x4000811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float timer;

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x10EECCC", Offset = "0x10EECCC", VA = "0x10EECCC")]
	public ToolboxItemInteractionHandler(InputHandler inputHandler, IEnumerable<ToolboxItemComponent> items, LevelEditorVRController vrController, LevelEditorSettings levelEditorSettings, LevelEditorContext levelEditorContext, Action<ToolboxItemComponent, VRGrab> onInteract, [Optional] Action<ToolboxItemComponent, VRGrab> onRelease, [Optional] Action<ToolboxItemComponent, VRGrab> onDrag)
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x10EFDD0", Offset = "0x10EFDD0", VA = "0x10EFDD0")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x10F2874", Offset = "0x10F2874", VA = "0x10F2874")]
	public void ClearGrabbedItem(int iHand)
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x10F27B8", Offset = "0x10F27B8", VA = "0x10F27B8")]
	private void AddHighlight(ToolboxItemComponent item)
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x10F26FC", Offset = "0x10F26FC", VA = "0x10F26FC")]
	private void RemoveHighlight(ToolboxItemComponent item)
	{
	}
}
[Token(Token = "0x20000F1")]
public enum TabType
{
	[Token(Token = "0x4000813")]
	Blocks_Wood,
	[Token(Token = "0x4000814")]
	Blocks_Rock,
	[Token(Token = "0x4000815")]
	Blocks_Ice,
	[Token(Token = "0x4000816")]
	Pigs,
	[Token(Token = "0x4000817")]
	Special,
	[Token(Token = "0x4000818")]
	Decoration,
	[Token(Token = "0x4000819")]
	Birds,
	[Token(Token = "0x400081A")]
	Menu,
	[Token(Token = "0x400081B")]
	EditTools,
	[Token(Token = "0x400081C")]
	ConfirmQuit,
	[Token(Token = "0x400081D")]
	ConfirmClear,
	[Token(Token = "0x400081E")]
	Tutorial
}
[Token(Token = "0x20000F2")]
public sealed class ToolboxTabComponent : MonoBehaviour
{
	[Token(Token = "0x400081F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TabType type;

	[Token(Token = "0x4000820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<ToolboxItemComponent> items;

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x10F28D0", Offset = "0x10F28D0", VA = "0x10F28D0")]
	public ToolboxTabComponent()
	{
	}
}
[Token(Token = "0x20000F3")]
public sealed class TrajectoryHandler
{
	[Token(Token = "0x4000821")]
	private const int MAX_NUMBER_TRAJECTORY_MARKERS = 16;

	[Token(Token = "0x4000822")]
	private const int MAX_NUMBER_SPECIAL_TRAJECTORY_MARKERS = 5;

	[Token(Token = "0x4000823")]
	private const float STEP_SIZE = 1.5f;

	[Token(Token = "0x4000824")]
	private const float INVERSE_STEP_SIZE = 2f / 3f;

	[Token(Token = "0x4000825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly TrajectoryMarkerSettings settings;

	[Token(Token = "0x4000826")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly MaterialPropertyBlock fadeMarkerMaterialPropertyBlock;

	[Token(Token = "0x4000827")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Vector3[] trajectoryMarkerVertices;

	[Token(Token = "0x4000828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Matrix4x4[] trajectoryMarkerMatrices;

	[Token(Token = "0x4000829")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Matrix4x4[] trajectorySpecialMarkerMatrices;

	[Token(Token = "0x400082A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int numberTrajectoryMarkers;

	[Token(Token = "0x400082B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool doFadeTrajectoryMarkers;

	[Token(Token = "0x400082C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 trajectoryHitPosition;

	[Token(Token = "0x400082D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int colorId;

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x10F28D8", Offset = "0x10F28D8", VA = "0x10F28D8")]
	public TrajectoryHandler(TrajectoryMarkerSettings settings)
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x10F2CA0", Offset = "0x10F2CA0", VA = "0x10F2CA0")]
	public void SetNumberTrajectoryMarkers(int newNumberTrajectoryMarkers)
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x10F2D24", Offset = "0x10F2D24", VA = "0x10F2D24")]
	public void SetDoFadeTrajectoryMarkers(bool flag)
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x10F2D30", Offset = "0x10F2D30", VA = "0x10F2D30")]
	public Vector3 GetLatestTrajectoryHitWorldPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x10EBBC4", Offset = "0x10EBBC4", VA = "0x10EBBC4")]
	public bool DrawLinearTrajectoryWithSpecialMarker(Vector3 startPoint, Vector3 direction)
	{
		return default(bool);
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x10F2D3C", Offset = "0x10F2D3C", VA = "0x10F2D3C")]
	public bool UpdateTrajectory(Vector3 worldPosition, Vector3 worldVelocity, Vector3 worldAcceleration, float dragFactor, Func<Vector3, Vector3, float, bool> evalIsIntersectingBool)
	{
		return default(bool);
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x10F362C", Offset = "0x10F362C", VA = "0x10F362C")]
	public bool UpdateLinearTrajectory(Vector3 startPoint, Vector3 direction, float maxDistance, Func<Vector3, Vector3, float, (bool, float)> evalIsIntersecting)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000F4")]
[DisallowMultipleComponent]
public class TutorialComponent : MonoBehaviour
{
	[Token(Token = "0x400082E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_Text tutorialTextComponent;

	[Token(Token = "0x400082F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LocalizedText tutorialLocalizedText;

	[Token(Token = "0x4000830")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MeshRenderer board;

	[Token(Token = "0x4000831")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SpriteRenderer character;

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x10F3AB8", Offset = "0x10F3AB8", VA = "0x10F3AB8")]
	public TutorialComponent()
	{
	}
}
[Token(Token = "0x20000F5")]
public enum TutorialType
{
	[Token(Token = "0x4000833")]
	Gameplay,
	[Token(Token = "0x4000834")]
	Introduction,
	[Token(Token = "0x4000835")]
	Teleportation,
	[Token(Token = "0x4000836")]
	Chuck,
	[Token(Token = "0x4000837")]
	Blues,
	[Token(Token = "0x4000838")]
	Bomb
}
[Token(Token = "0x20000F6")]
public sealed class TutorialHandler
{
	[Token(Token = "0x200023A")]
	private enum State
	{
		[Token(Token = "0x4000EB4")]
		Hide,
		[Token(Token = "0x4000EB5")]
		Show
	}

	[Token(Token = "0x4000839")]
	private const float SCALE_THRESHOLD = 0.01f;

	[Token(Token = "0x400083A")]
	private const float SCALE_SPEED = 10f;

	[Token(Token = "0x400083B")]
	private const float FOLLOW_SPEED = 30f;

	[Token(Token = "0x400083C")]
	private const float TOO_CLOSE_TO_HEAD = 2f;

	[Token(Token = "0x400083D")]
	private const float TRIGGER_DISTANCE_TO_LEVEL = 30f;

	[Token(Token = "0x400083E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly float stringTensionThreshold;

	[Token(Token = "0x400083F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly TutorialComponent tutorial;

	[Token(Token = "0x4000840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Transform tutorialPlacement;

	[Token(Token = "0x4000841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000842")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x4000843")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000844")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly PalazzoComponentSlingshot slingshot;

	[Token(Token = "0x4000845")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly string[][] tutorialStringIds;

	[Token(Token = "0x4000846")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly TutorialSettings tutorialSettings;

	[Token(Token = "0x4000847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TutorialType tutorialType;

	[Token(Token = "0x4000848")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timeWithoutAction;

	[Token(Token = "0x4000849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float timeToTutorial;

	[Token(Token = "0x400084A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool specialAbilityTutorialTriggered;

	[Token(Token = "0x400084B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private State state;

	[Token(Token = "0x400084C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private State prevState;

	[Token(Token = "0x400084D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private BirdFlightState prevBirdState;

	[Token(Token = "0x400084E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool prevEnoughForceState;

	[Token(Token = "0x400084F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int teleportCounter;

	[Token(Token = "0x4000850")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int prevTeleportCounter;

	[Token(Token = "0x4000851")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool hasTutorialShown;

	[Token(Token = "0x4000852")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool hide;

	[Token(Token = "0x4000853")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private PalazzoComponentBird targetBird;

	[Token(Token = "0x4000854")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 targetScale;

	[Token(Token = "0x4000855")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float targetAlpha;

	[Token(Token = "0x4000856")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float targetTimeScale;

	[Token(Token = "0x4000857")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private string targetLine;

	[Token(Token = "0x4000858")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool teleportHovering;

	[Token(Token = "0x4000859")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
	private bool prevTeleportHovering;

	[Token(Token = "0x400085A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
	private bool prevIsRubberInRange;

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x10F3AC0", Offset = "0x10F3AC0", VA = "0x10F3AC0")]
	public TutorialHandler(TutorialComponent tutorial, Transform tutorialPlacement, InputHandler inputHandler, LevelContext levelContext, PalazzoTriggers palazzoTriggers, PalazzoComponentSlingshot slingshot, SlingshotSettings slingshotSettings, TutorialSettings tutorialSettings)
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x10F43A8", Offset = "0x10F43A8", VA = "0x10F43A8")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x10F486C", Offset = "0x10F486C", VA = "0x10F486C")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x10F4C5C", Offset = "0x10F4C5C", VA = "0x10F4C5C")]
	private void ShowTutorial()
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x10F4928", Offset = "0x10F4928", VA = "0x10F4928")]
	private void HideTutorial()
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x10F5B90", Offset = "0x10F5B90", VA = "0x10F5B90")]
	public void ToggleTutorial(bool shouldHide)
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x10F5BEC", Offset = "0x10F5BEC", VA = "0x10F5BEC")]
	public void OnTeleportHovering(bool hovering)
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x10F5BF8", Offset = "0x10F5BF8", VA = "0x10F5BF8")]
	public void OnTeleport()
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x10F5764", Offset = "0x10F5764", VA = "0x10F5764")]
	private void UpdateTutorialText()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x10F5AA8", Offset = "0x10F5AA8", VA = "0x10F5AA8")]
	private PalazzoComponentBird GetActiveBird()
	{
		return null;
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x10F513C", Offset = "0x10F513C", VA = "0x10F513C")]
	private void Lerp()
	{
	}
}
[Token(Token = "0x20000F7")]
public class TutorialTabComponent : MonoBehaviour
{
	[Token(Token = "0x400085B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> pages;

	[Token(Token = "0x400085C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<SlideIndicator> slideIndicators;

	[Token(Token = "0x400085D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject backButton;

	[Token(Token = "0x400085E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject nextButton;

	[Token(Token = "0x400085F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7684BC", Offset = "0x7684BC")]
	public int controlsIndex;

	[Token(Token = "0x4000860")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject riftControls;

	[Token(Token = "0x4000861")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject viveControls;

	[Token(Token = "0x4000862")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject moveControls;

	[Token(Token = "0x4000863")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject questControls;

	[Token(Token = "0x4000864")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject riftSControls;

	[Token(Token = "0x4000865")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject cosmosControls;

	[Token(Token = "0x4000866")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject indexControls;

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x10F5C10", Offset = "0x10F5C10", VA = "0x10F5C10")]
	public TutorialTabComponent()
	{
	}
}
[Token(Token = "0x20000F8")]
public class TutorialTabHandler
{
	[Token(Token = "0x4000867")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly TutorialTabComponent tutorialTab;

	[Token(Token = "0x4000868")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentPageId;

	[Token(Token = "0x4000869")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<GameObject> pages;

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x10EEB88", Offset = "0x10EEB88", VA = "0x10EEB88")]
	public TutorialTabHandler(TutorialTabComponent tutorialTab)
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x10F19F0", Offset = "0x10F19F0", VA = "0x10F19F0")]
	public void Next()
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x10F1CE8", Offset = "0x10F1CE8", VA = "0x10F1CE8")]
	public void Back()
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x10F1700", Offset = "0x10F1700", VA = "0x10F1700")]
	public void OpenPigInfo()
	{
	}
}
[Token(Token = "0x20000F9")]
public sealed class AnimationComponent : MonoBehaviour
{
	[Token(Token = "0x400086A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform animationRoot;

	[Token(Token = "0x400086B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator animator;

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x99C200", Offset = "0x99C200", VA = "0x99C200")]
	public AnimationComponent()
	{
	}
}
[Token(Token = "0x20000FA")]
public sealed class BuildLevelsMenu : SplitMenu
{
	[Token(Token = "0x400086C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject unshareButton;

	[Token(Token = "0x400086D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7684F4", Offset = "0x7684F4")]
	public GameObject unshareSpinningWheelButton;

	[Token(Token = "0x400086E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x76852C", Offset = "0x76852C")]
	public GameObject unshareSpinningWheel;

	[Token(Token = "0x400086F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject shareButton;

	[Token(Token = "0x4000870")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x768564", Offset = "0x768564")]
	public GameObject shareSpinningWheelButton;

	[Token(Token = "0x4000871")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x76859C", Offset = "0x76859C")]
	public GameObject shareSpinningWheel;

	[Token(Token = "0x4000872")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public LevelGridButton[] unusedLevelSlots;

	[Token(Token = "0x4000873")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshPro levelCodeText;

	[Token(Token = "0x4000874")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshPro localLevelIdText;

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x9A26C8", Offset = "0x9A26C8", VA = "0x9A26C8")]
	public BuildLevelsMenu()
	{
	}
}
[Token(Token = "0x20000FB")]
public enum BuildLevelsMenuButtonType
{
	[Token(Token = "0x4000876")]
	Yes,
	[Token(Token = "0x4000877")]
	No,
	[Token(Token = "0x4000878")]
	SelectSlot,
	[Token(Token = "0x4000879")]
	EditLevel,
	[Token(Token = "0x400087A")]
	DeleteLevel,
	[Token(Token = "0x400087B")]
	SaveLevel,
	[Token(Token = "0x400087C")]
	TryLevel,
	[Token(Token = "0x400087D")]
	CloseMenu,
	[Token(Token = "0x400087E")]
	UploadLevel,
	[Token(Token = "0x400087F")]
	NextSlide,
	[Token(Token = "0x4000880")]
	PreviousSlide,
	[Token(Token = "0x4000881")]
	FavoriteLevel,
	[Token(Token = "0x4000882")]
	Duplicate,
	[Token(Token = "0x4000883")]
	Cancel,
	[Token(Token = "0x4000884")]
	Disabled,
	[Token(Token = "0x4000885")]
	Overwrite,
	[Token(Token = "0x4000886")]
	Delete,
	[Token(Token = "0x4000887")]
	BuildNewLevel,
	[Token(Token = "0x4000888")]
	NoConfirmation
}
[Token(Token = "0x20000FC")]
public class BuildLevelsMenuButton : PalazzoButton<BuildLevelsMenuButtonType>
{
	[Token(Token = "0x4000889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7685D4", Offset = "0x7685D4")]
	public GameObject optionalEmptySlotGeo;

	[Token(Token = "0x400088A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject optionalSavedSlotGeo;

	[Token(Token = "0x400088B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject optionalSaveIndicator;

	[Token(Token = "0x400088C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject optionalFinishedIndicator;

	[Token(Token = "0x400088D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject optionalSelectedIndicator;

	[NonSerialized]
	[Token(Token = "0x400088E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool slotTaken;

	[NonSerialized]
	[Token(Token = "0x400088F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public int slideIndex;

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x9A26D0", Offset = "0x9A26D0", VA = "0x9A26D0")]
	public BuildLevelsMenuButton()
	{
	}
}
[Token(Token = "0x20000FD")]
public class BuildLevelsMenuHandler : SplitMenuHandler
{
	[Serializable]
	[Token(Token = "0x200023B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767444", Offset = "0x767444")]
	private sealed class <>c
	{
		[Token(Token = "0x4000EB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000EB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<int> <>9__21_0;

		[Token(Token = "0x4000EB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<int> <>9__21_1;

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x9A44E8", Offset = "0x9A44E8", VA = "0x9A44E8")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x9A44F0", Offset = "0x9A44F0", VA = "0x9A44F0")]
		internal void <.ctor>b__21_0(int i)
		{
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x9A44F4", Offset = "0x9A44F4", VA = "0x9A44F4")]
		internal void <.ctor>b__21_1(int i)
		{
		}
	}

	[Token(Token = "0x4000890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly LevelBuildingHandler levelBuildingHandler;

	[Token(Token = "0x4000891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x4000892")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000893")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly MenuContext menuContext;

	[Token(Token = "0x4000894")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x4000895")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly BuildLevelsMenu buildLevelsMenu;

	[Token(Token = "0x4000896")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000897")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000898")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly Action<MenuType> setMenuType;

	[Token(Token = "0x4000899")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly ButtonHandler<LevelGridButton> unusedLevelSlotsButtonHandler;

	[Token(Token = "0x400089A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private bool isDuplicating;

	[Token(Token = "0x400089B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private uint duplicateIndex;

	[Token(Token = "0x400089C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private uint unshareIndex;

	[Token(Token = "0x400089D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private uint prevSelectedButtonIndex;

	[Token(Token = "0x400089E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Future<bool> unshareFuture;

	[Token(Token = "0x400089F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool firstEnter;

	[Token(Token = "0x40008A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
	private bool justEnteredMenu;

	[Token(Token = "0x40008A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
	private bool isUnsharing;

	[Token(Token = "0x40008A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12B")]
	private bool isVerifyingLevelUploadable;

	[Token(Token = "0x40008A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private bool isVerifyingLevelUploadablePrev;

	[Token(Token = "0x40008A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12D")]
	private bool newSave;

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x9A2720", Offset = "0x9A2720", VA = "0x9A2720")]
	public BuildLevelsMenuHandler(LevelBuildingHandler levelBuildingHandler, LevelEditorContext levelEditorContext, LevelEditorPlayContext levelEditorPlayContext, MenuContext menuContext, Action<LevelEditorStateType> setState, NetworkHandler networkHandler, SplitMenu splitMenu, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, InputHandler inputHandler, LevelContext levelContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelParent, Action<MenuType> setMenuType)
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x9A2A70", Offset = "0x9A2A70", VA = "0x9A2A70", Slot = "10")]
	public override void Tick()
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x9A3558", Offset = "0x9A3558", VA = "0x9A3558", Slot = "13")]
	protected override void OnSideMenuButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x9A3CDC", Offset = "0x9A3CDC", VA = "0x9A3CDC")]
	private void ToggleButton(SideMenuButton button, bool active)
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x9A3D8C", Offset = "0x9A3D8C", VA = "0x9A3D8C", Slot = "11")]
	protected override void OnGridMenuButtonClick(int buttonIndex)
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x9A3154", Offset = "0x9A3154", VA = "0x9A3154")]
	private void SelectLevel()
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x9A3EBC", Offset = "0x9A3EBC", VA = "0x9A3EBC", Slot = "14")]
	protected override void UpdateLevelSlotButtons()
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x9A43B4", Offset = "0x9A43B4", VA = "0x9A43B4", Slot = "8")]
	public override void Show()
	{
	}
}
[Serializable]
[Token(Token = "0x20000FE")]
public sealed class ButtonSettings
{
	[Token(Token = "0x40008A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x76860C", Offset = "0x76860C")]
	public AnimationComponent animPrefab;

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x9A57A4", Offset = "0x9A57A4", VA = "0x9A57A4")]
	public ButtonSettings()
	{
	}
}
[Token(Token = "0x20000FF")]
public sealed class ButtonHandler<TBUTTON> where TBUTTON : PalazzoButton
{
	[Serializable]
	[Token(Token = "0x200023C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767454", Offset = "0x767454")]
	private sealed class <>c
	{
		[Token(Token = "0x4000EB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000EBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<int> <>9__21_0;

		[Token(Token = "0x4000EBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<int> <>9__21_1;

		[Token(Token = "0x6000A7A")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A7B")]
		internal void <.ctor>b__21_0(int buttonIndex)
		{
		}

		[Token(Token = "0x6000A7C")]
		internal void <.ctor>b__21_1(int buttonIndex)
		{
		}
	}

	[Token(Token = "0x40008A6")]
	private const float REGISTER_SELECTED_MIN_SQR_DISTANCE = 0.36f;

	[Token(Token = "0x40008A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40008A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40008A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x40008AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly IList<TBUTTON> buttons;

	[Token(Token = "0x40008AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Action<int> onClick;

	[Token(Token = "0x40008AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Action<int> onHover;

	[Token(Token = "0x40008AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Action<int> onRelease;

	[Token(Token = "0x40008AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x40008AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int minDistanceIndex;

	[Token(Token = "0x40008B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool scoreboardIsPlaying;

	[Token(Token = "0x40008B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool skipScoreboard;

	[Token(Token = "0x40008B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int uiLayerMask;

	[Token(Token = "0x40008B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int buttonLayerMask;

	[Token(Token = "0x40008B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int hooverAnimId;

	[Token(Token = "0x40008B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly RaycastHit[] hits;

	[Token(Token = "0x17000023")]
	public bool ScoreboardIsPlaying
	{
		[Token(Token = "0x60004B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public bool SkipScoreboard
	{
		[Token(Token = "0x60004B1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004B2")]
		set
		{
		}
	}

	[Token(Token = "0x60004B3")]
	public ButtonHandler(InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, IList<TBUTTON> buttons, Action<int> onClick, [Optional] Action<int> onHover, [Optional] Action<int> onRelease, [Optional] NetworkHandler networkHandler, [Optional] ButtonSettings buttonSettings)
	{
	}

	[Token(Token = "0x60004B4")]
	private (bool, float) IsIntersectingTrajectory(Vector3 pos, Vector3 dir, float len)
	{
		return default((bool, float));
	}

	[Token(Token = "0x60004B5")]
	public void ResetButtons()
	{
	}

	[Token(Token = "0x60004B6")]
	private static Vector3 CalcClosestPointOnLine(Vector3 vA, Vector3 vB, Vector3 vPoint)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004B7")]
	public void DisableButtons()
	{
	}

	[Token(Token = "0x60004B8")]
	public void TickButtons()
	{
	}

	[Token(Token = "0x60004B9")]
	private static void UpdateButtonVisuals(PalazzoButton button)
	{
	}

	[Token(Token = "0x60004BA")]
	private static void UpdateButtonPosition(PalazzoButton button)
	{
	}
}
[Token(Token = "0x2000100")]
public sealed class ConnectionIndicator : MonoBehaviour
{
	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x9A7934", Offset = "0x9A7934", VA = "0x9A7934")]
	public ConnectionIndicator()
	{
	}
}
[Token(Token = "0x2000101")]
public class CreateUserMenuHandler : IMenuHandler
{
	[Token(Token = "0x200023D")]
	private enum State
	{
		[Token(Token = "0x4000EBD")]
		Generating,
		[Token(Token = "0x4000EBE")]
		ProposeName
	}

	[Token(Token = "0x40008B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x40008B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly UiMenuHandlerBase<CreateUserMenuButton, CreateUserMenuButtonType> menuHandler;

	[Token(Token = "0x40008B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly CreateUserMenu menu;

	[Token(Token = "0x40008B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x40008BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<MenuType> setMenuType;

	[Token(Token = "0x40008BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40008BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly CreateUserSettings createUserSettings;

	[Token(Token = "0x40008BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Future<string[]> generateUsernamesFuture;

	[Token(Token = "0x40008BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40008BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly SlotMachineHandler slotMachineHandler;

	[Token(Token = "0x40008C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private State state;

	[Token(Token = "0x40008C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private State prevState;

	[Token(Token = "0x40008C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int nameSuggestionIndex;

	[Token(Token = "0x40008C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private CreateUserMenuButton createButton;

	[Token(Token = "0x40008C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string[] generatedNames;

	[Token(Token = "0x40008C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool generationDone;

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x9A79DC", Offset = "0x9A79DC", VA = "0x9A79DC")]
	public CreateUserMenuHandler(NetworkHandler networkHandler, Action<MenuType> setMenuType, Action<LevelEditorStateType> setState, UiMenuBase<CreateUserMenuButton, CreateUserMenuButtonType> menu, ARTransforms arTransforms, InputHandler inputHandler, WorldContext worldContext, MenuSettings menuSettings, TrajectoryHandler trajectoryHandler, PalazzoTriggers palazzoTriggers, LevelEditorPlayContext levelEditorPlayContext, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x9A7CF0", Offset = "0x9A7CF0", VA = "0x9A7CF0")]
	private void OnButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x9A81D0", Offset = "0x9A81D0", VA = "0x9A81D0", Slot = "7")]
	public void Tick()
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x9A8664", Offset = "0x9A8664", VA = "0x9A8664", Slot = "5")]
	public void Hide()
	{
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x9A86E8", Offset = "0x9A86E8", VA = "0x9A86E8", Slot = "6")]
	public void InstantHide()
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x9A8748", Offset = "0x9A8748", VA = "0x9A8748", Slot = "4")]
	public void Show()
	{
	}
}
[Token(Token = "0x2000102")]
public class DifficultyGauge : MonoBehaviour
{
	[Token(Token = "0x40008C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float maxRotation;

	[Token(Token = "0x40008C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float animationTime;

	[Token(Token = "0x40008C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject pointer;

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x9AF358", Offset = "0x9AF358", VA = "0x9AF358")]
	public DifficultyGauge()
	{
	}
}
[Token(Token = "0x2000103")]
public class DifficultyGaugeHandler
{
	[Token(Token = "0x40008C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly DifficultyGauge difficultyGauge;

	[Token(Token = "0x40008CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float currentDifficulty;

	[Token(Token = "0x40008CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float animationStartTime;

	[Token(Token = "0x40008CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float animationStartingDifficulty;

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x9AF360", Offset = "0x9AF360", VA = "0x9AF360")]
	public DifficultyGaugeHandler(DifficultyGauge difficultyGauge)
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x9AF38C", Offset = "0x9AF38C", VA = "0x9AF38C")]
	public void Tick()
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x9AF580", Offset = "0x9AF580", VA = "0x9AF580")]
	public void SetDifficulty(float difficulty)
	{
	}
}
[Token(Token = "0x2000104")]
public sealed class DiscoveryMenu : OnlineSplitMenu
{
	[Token(Token = "0x40008CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject searchLayout;

	[Token(Token = "0x40008CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Keypad keypad;

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x9AF5BC", Offset = "0x9AF5BC", VA = "0x9AF5BC")]
	public DiscoveryMenu()
	{
	}
}
[Token(Token = "0x2000105")]
public sealed class DiscoveryMenuHandler : OnlineSplitMenuHandler
{
	[Token(Token = "0x200023E")]
	private enum SearchState
	{
		[Token(Token = "0x4000EC0")]
		EnterCode,
		[Token(Token = "0x4000EC1")]
		NotFound,
		[Token(Token = "0x4000EC2")]
		Searching,
		[Token(Token = "0x4000EC3")]
		PresentInfo
	}

	[Serializable]
	[Token(Token = "0x200023F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767464", Offset = "0x767464")]
	private sealed class <>c
	{
		[Token(Token = "0x4000EC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000EC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<int> <>9__17_0;

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x9B0E40", Offset = "0x9B0E40", VA = "0x9B0E40")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x9B0E48", Offset = "0x9B0E48", VA = "0x9B0E48")]
		internal void <.ctor>b__17_0(int i)
		{
		}
	}

	[Token(Token = "0x40008CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40008D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x40008D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x40008D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly DiscoveryMenu discoveryMenu;

	[Token(Token = "0x40008D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly Keypad keypad;

	[Token(Token = "0x40008D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private readonly ButtonHandler<KeypadButton> keypadButtonHandler;

	[Token(Token = "0x40008D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40008D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private readonly Action<MenuType> setMenuType;

	[Token(Token = "0x40008D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private SearchState searchState;

	[Token(Token = "0x40008D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	private SearchState prevSearchState;

	[Token(Token = "0x40008D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Future<ServerLevelMetaData> levelFuture;

	[Token(Token = "0x40008DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private bool isEraseButtonPressed;

	[Token(Token = "0x40008DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private float erasePressedTimer;

	[Token(Token = "0x40008DC")]
	private const float ERASE_NEXT_CHARACTER_TIME = 0.2f;

	[Token(Token = "0x40008DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private int numberOfErasedCharactersDuringPress;

	[Token(Token = "0x40008DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private KeypadButton eraseButton;

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x9AF5C4", Offset = "0x9AF5C4", VA = "0x9AF5C4")]
	public DiscoveryMenuHandler(LevelEditorPlayContext levelEditorPlayContext, NetworkHandler networkHandler, Action<LevelEditorStateType> setState, Action<MenuType> setMenuType, SplitMenu splitMenu, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, InputHandler inputHandler, LevelContext levelContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelParent, CreateUserSettings createUserSettings, MenuContext menuContext)
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x9AF880", Offset = "0x9AF880", VA = "0x9AF880", Slot = "8")]
	public override void Show()
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x9AF8CC", Offset = "0x9AF8CC", VA = "0x9AF8CC", Slot = "10")]
	public override void Tick()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x9B0514", Offset = "0x9B0514", VA = "0x9B0514", Slot = "11")]
	protected override void OnGridMenuButtonClick(int buttonIndex)
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x9B06F8", Offset = "0x9B06F8", VA = "0x9B06F8", Slot = "13")]
	protected override void OnSideMenuButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x9B0858", Offset = "0x9B0858", VA = "0x9B0858")]
	private void OnKeypadClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x9B0D50", Offset = "0x9B0D50", VA = "0x9B0D50")]
	private void OnKeypadRelease(int buttonIndex)
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x9B021C", Offset = "0x9B021C", VA = "0x9B021C")]
	private void EraseInputCharacter(PalazzoButton button)
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x9B0AF0", Offset = "0x9B0AF0", VA = "0x9B0AF0")]
	private void AddNumberToInputText(int number, PalazzoButton button)
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x9B0110", Offset = "0x9B0110", VA = "0x9B0110")]
	private static bool IsCodeValid(string code)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000106")]
public sealed class ErrorMenu : UiMenuBase<ErrorMenuButton, ErrorMenuButtonType>
{
	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x9B56C8", Offset = "0x9B56C8", VA = "0x9B56C8")]
	public ErrorMenu()
	{
	}
}
[Token(Token = "0x2000107")]
public enum ErrorMenuButtonType
{
	[Token(Token = "0x40008E0")]
	OK
}
[Token(Token = "0x2000108")]
public sealed class ErrorMenuButton : PalazzoButton<ErrorMenuButtonType>
{
	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x9B5718", Offset = "0x9B5718", VA = "0x9B5718")]
	public ErrorMenuButton()
	{
	}
}
[Token(Token = "0x2000109")]
public class FavoriteErrorMenuHandler : IMenuHandler
{
	[Token(Token = "0x40008E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly UiMenuHandlerBase<ErrorMenuButton, ErrorMenuButtonType> menuHandler;

	[Token(Token = "0x40008E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ErrorMenu menu;

	[Token(Token = "0x40008E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x40008E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action<MenuType> setMenuType;

	[Token(Token = "0x40008E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x40008E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0xA11984", Offset = "0xA11984", VA = "0xA11984")]
	public FavoriteErrorMenuHandler(UiMenuBase<ErrorMenuButton, ErrorMenuButtonType> menu, ARTransforms arTransforms, InputHandler inputHandler, WorldContext worldContext, MenuSettings menuSettings, TrajectoryHandler trajectoryHandler, PalazzoTriggers palazzoTriggers, LevelEditorPlayContext levelEditorPlayContext, Action<LevelEditorStateType> setState, Action<MenuType> setMenuType, GameStateData gameStateData)
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0xA11B5C", Offset = "0xA11B5C", VA = "0xA11B5C")]
	private void OnButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0xA11D6C", Offset = "0xA11D6C", VA = "0xA11D6C", Slot = "5")]
	public void Hide()
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0xA11DCC", Offset = "0xA11DCC", VA = "0xA11DCC", Slot = "6")]
	public void InstantHide()
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0xA11E2C", Offset = "0xA11E2C", VA = "0xA11E2C", Slot = "4")]
	public void Show()
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0xA11E94", Offset = "0xA11E94", VA = "0xA11E94", Slot = "7")]
	public void Tick()
	{
	}
}
[Token(Token = "0x200010A")]
public class FavoriteLevelsMenu : SplitMenu
{
	[Token(Token = "0x40008E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject levelsLayout;

	[Token(Token = "0x40008E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject loadingLayout;

	[Token(Token = "0x40008E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshPro localFavoriteLevelIdText;

	[Token(Token = "0x40008EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject noLevelsInstructionText;

	[Token(Token = "0x40008EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject noLevelsInstructionTextLocal;

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0xA11EF4", Offset = "0xA11EF4", VA = "0xA11EF4")]
	public FavoriteLevelsMenu()
	{
	}
}
[Token(Token = "0x200010B")]
public class FavoriteLevelsMenuHandler : SplitMenuHandler
{
	[Serializable]
	[Token(Token = "0x2000240")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767474", Offset = "0x767474")]
	private sealed class <>c
	{
		[Token(Token = "0x4000EC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000EC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<ServerLevelMetaData, string> <>9__18_0;

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0xA14050", Offset = "0xA14050", VA = "0xA14050")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0xA14058", Offset = "0xA14058", VA = "0xA14058")]
		internal string <Show>b__18_0(ServerLevelMetaData level)
		{
			return null;
		}
	}

	[Token(Token = "0x40008EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x40008ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly Action<MenuType> setMenuType;

	[Token(Token = "0x40008EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40008EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x40008F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly FavoriteLevelsMenu favoriteLevelsMenu;

	[Token(Token = "0x40008F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly OnlineSideMenu onlineSideMenu;

	[Token(Token = "0x40008F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly CreateUserSettings createUserSettings;

	[Token(Token = "0x40008F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly MenuContext menuContext;

	[Token(Token = "0x40008F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private ServerLevelMetaData[] favoriteLevels;

	[Token(Token = "0x40008F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private int selectedButtonIndex;

	[Token(Token = "0x40008F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private LevelListContext favoriteLevelsContext;

	[Token(Token = "0x40008F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Future<ServerLevelMetaData[]> updateMetaDataFuture;

	[Token(Token = "0x40008F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool processingRequest;

	[Token(Token = "0x40008F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Future<User> getUserDataFuture;

	[Token(Token = "0x40008FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private DifficultyGaugeHandler difficultyGaugeHandler;

	[Token(Token = "0x40008FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private uint prevSelectedLevelId;

	[Token(Token = "0x40008FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private bool justEnteredMenu;

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0xA11EFC", Offset = "0xA11EFC", VA = "0xA11EFC")]
	public FavoriteLevelsMenuHandler(LevelEditorPlayContext levelEditorPlayContext, Action<LevelEditorStateType> setState, Action<MenuType> setMenuType, SplitMenu splitMenu, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, InputHandler inputHandler, LevelContext levelContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelParent, NetworkHandler networkHandler, CreateUserSettings createUserSettings, MenuContext menuContext)
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0xA12248", Offset = "0xA12248", VA = "0xA12248", Slot = "8")]
	public override void Show()
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0xA127D8", Offset = "0xA127D8", VA = "0xA127D8", Slot = "10")]
	public override void Tick()
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0xA12E94", Offset = "0xA12E94", VA = "0xA12E94", Slot = "11")]
	protected override void OnGridMenuButtonClick(int buttonIndex)
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0xA1377C", Offset = "0xA1377C", VA = "0xA1377C", Slot = "13")]
	protected override void OnSideMenuButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0xA13EAC", Offset = "0xA13EAC", VA = "0xA13EAC", Slot = "14")]
	protected override void UpdateLevelSlotButtons()
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0xA125A4", Offset = "0xA125A4", VA = "0xA125A4")]
	private void LoadFavoriteLevels()
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0xA132AC", Offset = "0xA132AC", VA = "0xA132AC")]
	protected void PopulateStats(ServerLevelMetaData data)
	{
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0xA12C54", Offset = "0xA12C54", VA = "0xA12C54")]
	private void PopulateUser(User user)
	{
	}
}
[Token(Token = "0x200010C")]
public interface IMenuHandler
{
	[Token(Token = "0x60004E3")]
	void Show();

	[Token(Token = "0x60004E4")]
	void Hide();

	[Token(Token = "0x60004E5")]
	void InstantHide();

	[Token(Token = "0x60004E6")]
	void Tick();
}
[Token(Token = "0x200010D")]
public class Keypad : MonoBehaviour
{
	[Token(Token = "0x40008FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshPro inputText;

	[Token(Token = "0x40008FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public KeypadButton[] buttons;

	[Token(Token = "0x40008FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color redColor;

	[Token(Token = "0x4000900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color defaultColor;

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0xA198E8", Offset = "0xA198E8", VA = "0xA198E8")]
	public Keypad()
	{
	}
}
[Token(Token = "0x200010E")]
public enum KeypadButtonType
{
	[Token(Token = "0x4000902")]
	Key0,
	[Token(Token = "0x4000903")]
	Key1,
	[Token(Token = "0x4000904")]
	Key2,
	[Token(Token = "0x4000905")]
	Key3,
	[Token(Token = "0x4000906")]
	Key4,
	[Token(Token = "0x4000907")]
	Key5,
	[Token(Token = "0x4000908")]
	Key6,
	[Token(Token = "0x4000909")]
	Key7,
	[Token(Token = "0x400090A")]
	Key8,
	[Token(Token = "0x400090B")]
	Key9,
	[Token(Token = "0x400090C")]
	Erase,
	[Token(Token = "0x400090D")]
	Search
}
[Token(Token = "0x200010F")]
public class KeypadButton : PalazzoButton<KeypadButtonType>
{
	[Token(Token = "0x60004E8")]
	[Address(RVA = "0xA198F0", Offset = "0xA198F0", VA = "0xA198F0")]
	public KeypadButton()
	{
	}
}
[Token(Token = "0x2000110")]
[DisallowMultipleComponent]
public class LevelEditorMenu : MonoBehaviour
{
	[Token(Token = "0x400090E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] menuRoots;

	[Token(Token = "0x400090F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject levelSelectedMenuRoot;

	[Token(Token = "0x4000910")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject levelUploadedMenuRoot;

	[Token(Token = "0x4000911")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject createLevelMenuRoot;

	[Token(Token = "0x4000912")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject deleteLevelMenuRoot;

	[Token(Token = "0x4000913")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject saveLevelMenuRoot;

	[Token(Token = "0x4000914")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject confirmOverwriteMenuRoot;

	[Token(Token = "0x4000915")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject previousSlideButton;

	[Token(Token = "0x4000916")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject nextSlideButton;

	[Token(Token = "0x4000917")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject instructionText;

	[Token(Token = "0x4000918")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject sideMenuTitleText;

	[Token(Token = "0x4000919")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject[] favoriteButtonTypes;

	[Token(Token = "0x400091A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshPro titleText;

	[Token(Token = "0x400091B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public LocalizedText localizedTitleText;

	[Token(Token = "0x400091C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<LevelEditorMenuButton> levelEditorMenuButtons;

	[Token(Token = "0x400091D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<GameObject> levelSlideMenus;

	[Token(Token = "0x400091E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<SlideIndicator> slideIndicators;

	[NonSerialized]
	[Token(Token = "0x400091F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<LevelEditorMenuButton> saveSlotButtons;

	[NonSerialized]
	[Token(Token = "0x4000920")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public uint saveIndex;

	[NonSerialized]
	[Token(Token = "0x4000921")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public LevelEditorMenuButton selectedButton;

	[NonSerialized]
	[Token(Token = "0x4000922")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public int nbrOfSlides;

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x9FE5E4", Offset = "0x9FE5E4", VA = "0x9FE5E4")]
	public LevelEditorMenu()
	{
	}
}
[Token(Token = "0x2000111")]
public enum LevelEditorMenuButtonType
{
	[Token(Token = "0x4000924")]
	Yes,
	[Token(Token = "0x4000925")]
	No,
	[Token(Token = "0x4000926")]
	SelectSlot,
	[Token(Token = "0x4000927")]
	EditLevel,
	[Token(Token = "0x4000928")]
	DeleteLevel,
	[Token(Token = "0x4000929")]
	SaveLevel,
	[Token(Token = "0x400092A")]
	TryLevel,
	[Token(Token = "0x400092B")]
	CloseMenu,
	[Token(Token = "0x400092C")]
	UploadLevel,
	[Token(Token = "0x400092D")]
	NextSlide,
	[Token(Token = "0x400092E")]
	PreviousSlide,
	[Token(Token = "0x400092F")]
	FavoriteLevel,
	[Token(Token = "0x4000930")]
	Duplicate,
	[Token(Token = "0x4000931")]
	Cancel,
	[Token(Token = "0x4000932")]
	Disabled
}
[Token(Token = "0x2000112")]
public enum FromConfirmationMenu
{
	[Token(Token = "0x4000934")]
	Overwrite,
	[Token(Token = "0x4000935")]
	Delete,
	[Token(Token = "0x4000936")]
	BuildNewLevel,
	[Token(Token = "0x4000937")]
	NoConfirmation
}
[Token(Token = "0x2000113")]
public sealed class LevelEditorMenuButton : PalazzoButton<LevelEditorMenuButtonType>
{
	[Token(Token = "0x4000938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public FromConfirmationMenu fromConfirmationMenu;

	[Token(Token = "0x4000939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x768644", Offset = "0x768644")]
	public GameObject optionalEmptySlotGeo;

	[Token(Token = "0x400093A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject optionalSavedSlotGeo;

	[Token(Token = "0x400093B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject optionalSaveIndicator;

	[Token(Token = "0x400093C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject optionalFinishedIndicator;

	[Token(Token = "0x400093D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject optionalSelectedIndicator;

	[NonSerialized]
	[Token(Token = "0x400093E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public bool slotTaken;

	[NonSerialized]
	[Token(Token = "0x400093F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public int slideIndex;

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x9FE65C", Offset = "0x9FE65C", VA = "0x9FE65C")]
	public LevelEditorMenuButton()
	{
	}
}
[Token(Token = "0x2000114")]
public class LevelEditorScoreboard : ScoreboardBase
{
	[Token(Token = "0x4000940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject winScreen;

	[Token(Token = "0x4000941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject levelUploadedScreen;

	[Token(Token = "0x4000942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject loadingScreen;

	[Token(Token = "0x4000943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject spinningWheel;

	[Token(Token = "0x4000944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject optionalConfetti;

	[Token(Token = "0x4000945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TMP_Text optionalUsernameText;

	[Token(Token = "0x4000946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TMP_Text optionalUsernameHoverText;

	[Token(Token = "0x4000947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TMP_Text optionalLevelCodeText;

	[Token(Token = "0x4000948")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public SpriteRenderer optionalUserImage;

	[Token(Token = "0x4000949")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public LoadingDots optionalLoadingDots;

	[Token(Token = "0x400094A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ConnectionIndicator connectionIndicator;

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0xA005EC", Offset = "0xA005EC", VA = "0xA005EC")]
	public LevelEditorScoreboard()
	{
	}
}
[Token(Token = "0x2000115")]
public sealed class LevelEditorScoreboardHandler : PlayMenuHandlerBase
{
	[Token(Token = "0x2000241")]
	private enum ScoreboardState
	{
		[Token(Token = "0x4000EC9")]
		Init,
		[Token(Token = "0x4000ECA")]
		WaitForInput,
		[Token(Token = "0x4000ECB")]
		TransitionToMenu,
		[Token(Token = "0x4000ECC")]
		IsProcessingUpload
	}

	[Token(Token = "0x400094B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x400094C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly LevelEditorScoreboard scoreboard;

	[Token(Token = "0x400094D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x400094E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen;

	[Token(Token = "0x400094F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000950")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000951")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000952")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly CreateUserSettings createUserSettings;

	[Token(Token = "0x4000953")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private new ScoreboardState state;

	[Token(Token = "0x4000954")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private new ScoreboardState prevState;

	[Token(Token = "0x4000955")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameState nextGameState;

	[Token(Token = "0x4000956")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool handleNetworkResponse;

	[Token(Token = "0x4000957")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private PalazzoButton nextButton;

	[Token(Token = "0x4000958")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Future<ServerLevelMetaData> uploadFuture;

	[Token(Token = "0x4000959")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Future<ServerLevelMetaData> quickplayLevelFuture;

	[Token(Token = "0x400095A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Future<User> getUserDataFuture;

	[Token(Token = "0x400095B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private User user;

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0xA005F4", Offset = "0xA005F4", VA = "0xA005F4")]
	public LevelEditorScoreboardHandler(ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, LevelEditorScoreboard scoreboard, WorldContext worldContext, MenuSettings menuSettings, MonoBehaviour monoBehaviour, Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen, NetworkHandler networkHandler, LevelEditorPlayContext levelEditorPlayContext, GameStateData gameStateData, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0xA006D4", Offset = "0xA006D4", VA = "0xA006D4", Slot = "4")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0xA007DC", Offset = "0xA007DC", VA = "0xA007DC", Slot = "6")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0xA01954", Offset = "0xA01954", VA = "0xA01954", Slot = "7")]
	protected override void OnButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0xA01C40", Offset = "0xA01C40", VA = "0xA01C40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A9DC", Offset = "0x76A9DC")]
	private void <Tick>b__20_0(GameState nextState)
	{
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0xA01C48", Offset = "0xA01C48", VA = "0xA01C48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A9EC", Offset = "0x76A9EC")]
	private void <OnButtonClicked>b__21_0(GameState nextState)
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0xA01C50", Offset = "0xA01C50", VA = "0xA01C50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76A9FC", Offset = "0x76A9FC")]
	private void <OnButtonClicked>b__21_1(GameState nextState)
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0xA01C58", Offset = "0xA01C58", VA = "0xA01C58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76AA0C", Offset = "0x76AA0C")]
	private void <OnButtonClicked>b__21_2(GameState nextState)
	{
	}
}
[Token(Token = "0x2000116")]
[Flags]
public enum LevelGridButtonType
{
	[Token(Token = "0x400095D")]
	LevelSlot = 0,
	[Token(Token = "0x400095E")]
	NextSlide = 1,
	[Token(Token = "0x400095F")]
	PreviousSlide = 2,
	[Token(Token = "0x4000960")]
	Close = 3,
	[Token(Token = "0x4000961")]
	Custom = 4,
	[Token(Token = "0x4000962")]
	BackToStart = 5
}
[Token(Token = "0x2000117")]
public class LevelGridButton : PalazzoButton<LevelGridButtonType>
{
	[Token(Token = "0x4000963")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public TextMeshPro numberTextDefault;

	[Token(Token = "0x4000964")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMeshPro numberTextHover;

	[Token(Token = "0x4000965")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMeshPro numberTextDisabled;

	[Token(Token = "0x4000966")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x76867C", Offset = "0x76867C")]
	public GameObject optionalUploadedIndicator;

	[Token(Token = "0x4000967")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject optionalEditingIndicator;

	[Token(Token = "0x4000968")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject optionalSelectedIndicator;

	[Token(Token = "0x4000969")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject optionalLoadingIndicator;

	[Token(Token = "0x400096A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject optionalFavoriteIndicator;

	[Token(Token = "0x400096B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7686B4", Offset = "0x7686B4")]
	public TextMeshPro statsTextDefault;

	[Token(Token = "0x400096C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public TextMeshPro statsTextHover;

	[Token(Token = "0x400096D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public TextMeshPro statsTextDisabled;

	[Token(Token = "0x400096E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public LevelGridButtonIcon[] icons;

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0xA0AFD0", Offset = "0xA0AFD0", VA = "0xA0AFD0")]
	public LevelGridButton()
	{
	}
}
[Token(Token = "0x2000118")]
public enum LevelGridButtonIconType
{
	[Token(Token = "0x4000970")]
	Hot,
	[Token(Token = "0x4000971")]
	Difficulty,
	[Token(Token = "0x4000972")]
	New
}
[Token(Token = "0x2000119")]
public class LevelGridButtonIcon : MonoBehaviour
{
	[Token(Token = "0x4000973")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LevelGridButtonIconType type;

	[Token(Token = "0x4000974")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public DifficultyGauge optionalDifficultyGauge;

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0xA0B020", Offset = "0xA0B020", VA = "0xA0B020")]
	public LevelGridButtonIcon()
	{
	}
}
[Token(Token = "0x200011A")]
public class LevelGridMenu : UiMenuBase<LevelGridButton, LevelGridButtonType>
{
	[Token(Token = "0x4000975")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro title;

	[Token(Token = "0x4000976")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LocalizedText optionalLocalizedTitle;

	[Token(Token = "0x4000977")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public SlideIndicator[] slideIndicators;

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0xA0B028", Offset = "0xA0B028", VA = "0xA0B028")]
	public LevelGridMenu()
	{
	}
}
[Token(Token = "0x200011B")]
[DisallowMultipleComponent]
public sealed class LevelSelect : UiMenuBase<LevelButton, LevelSelectButtonType>
{
	[Token(Token = "0x4000978")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro levelName;

	[Token(Token = "0x4000979")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LocalizedText localizedLevelName;

	[Token(Token = "0x400097A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MeshRenderer backDrop;

	[Token(Token = "0x400097B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material darkStar;

	[Token(Token = "0x400097C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material litStar;

	[Token(Token = "0x400097D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public LevelButton[] levelSelectButtons;

	[Token(Token = "0x400097E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LevelButton[] levelButtons;

	[Token(Token = "0x400097F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public LevelButton bossButton;

	[Token(Token = "0x4000980")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public WorldType world;

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0xA0CD5C", Offset = "0xA0CD5C", VA = "0xA0CD5C")]
	public LevelSelect()
	{
	}
}
[Token(Token = "0x200011C")]
public enum LevelSelectButtonType
{
	[Token(Token = "0x4000982")]
	PlaceLevel,
	[Token(Token = "0x4000983")]
	SelectLevel,
	[Token(Token = "0x4000984")]
	ExitToWorldSelect,
	[Token(Token = "0x4000985")]
	NextSlide,
	[Token(Token = "0x4000986")]
	PreviousSlide,
	[Token(Token = "0x4000987")]
	Play,
	[Token(Token = "0x4000988")]
	UnfavoriteLevel,
	[Token(Token = "0x4000989")]
	ReportLevel,
	[Token(Token = "0x400098A")]
	Yes,
	[Token(Token = "0x400098B")]
	No
}
[Token(Token = "0x200011D")]
public sealed class LevelSelectButton : PalazzoButton<LevelSelectButtonType>
{
	[Token(Token = "0x60004F8")]
	[Address(RVA = "0xA0CDAC", Offset = "0xA0CDAC", VA = "0xA0CDAC")]
	public LevelSelectButton()
	{
	}
}
[Token(Token = "0x200011E")]
public class LoadingDots : MonoBehaviour
{
	[Token(Token = "0x400098C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject backgroundDots;

	[Token(Token = "0x400098D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] loadingDots;

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0xA0CE04", Offset = "0xA0CE04", VA = "0xA0CE04")]
	public LoadingDots()
	{
	}
}
[Token(Token = "0x200011F")]
[DisallowMultipleComponent]
public sealed class LoseScreen : PlayMenuBase<ScoreboardButton>
{
	[Token(Token = "0x400098E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshPro levelName;

	[Token(Token = "0x400098F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LocalizedText localizedLevelName;

	[Token(Token = "0x4000990")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocalizedText levelDescription;

	[Token(Token = "0x4000991")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject optionalSpinningWheel;

	[Token(Token = "0x4000992")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TMP_Text optionalUsernameText;

	[Token(Token = "0x4000993")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TMP_Text optionalUsernameHoverText;

	[Token(Token = "0x4000994")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TMP_Text optionalLevelCodeText;

	[Token(Token = "0x4000995")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public SpriteRenderer optionalUserImage;

	[Token(Token = "0x4000996")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public LoadingDots optionalLoadingDots;

	[Token(Token = "0x4000997")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ConnectionIndicator connectionIndicator;

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0xA0CF44", Offset = "0xA0CF44", VA = "0xA0CF44")]
	public LoseScreen()
	{
	}
}
[Token(Token = "0x2000120")]
public sealed class LoseScreenHandler : PlayMenuHandlerBase
{
	[Token(Token = "0x4000998")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000999")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x400099A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly LoseScreen loseScreen;

	[Token(Token = "0x400099B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x400099C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly PalazzoWorld[] worldPrefabs;

	[Token(Token = "0x400099D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly List<string> levelGuids;

	[Token(Token = "0x400099E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x400099F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen;

	[Token(Token = "0x40009A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40009A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x40009A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x40009A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly CreateUserSettings createUserSettings;

	[Token(Token = "0x40009A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private GameState nextGameState;

	[Token(Token = "0x40009A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool handleNetworkResponse;

	[Token(Token = "0x40009A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Future<ServerLevelMetaData> quickplayLevelFuture;

	[Token(Token = "0x40009A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Future<User> getUserDataFuture;

	[Token(Token = "0x40009A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private User user;

	[Token(Token = "0x40009A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private PalazzoButton nextButton;

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0xA0CF94", Offset = "0xA0CF94", VA = "0xA0CF94")]
	public LoseScreenHandler(ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, LevelContext levelContext, LoseScreen loseScreen, PalazzoGameDataPersistent gameDataPersistent, WorldContext worldContext, MenuSettings menuSettings, PalazzoWorld[] worldPrefabs, List<string> levelGuids, MonoBehaviour monoBehaviour, Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen, LevelEditorPlayContext levelEditorPlayContext, NetworkHandler networkHandler, GameStateData gameStateData, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0xA0D0A4", Offset = "0xA0D0A4", VA = "0xA0D0A4", Slot = "6")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0xA0E0D8", Offset = "0xA0E0D8", VA = "0xA0E0D8", Slot = "7")]
	protected override void OnButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0xA0E2FC", Offset = "0xA0E2FC", VA = "0xA0E2FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76AA1C", Offset = "0x76AA1C")]
	private void <Tick>b__19_0(GameState nextState)
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0xA0E304", Offset = "0xA0E304", VA = "0xA0E304")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76AA2C", Offset = "0x76AA2C")]
	private void <OnButtonClicked>b__20_0(GameState nextState)
	{
	}
}
[Token(Token = "0x2000121")]
public class OnlineSideMenu : SideMenu
{
	[Token(Token = "0x40009AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshPro levelCodeText;

	[Token(Token = "0x40009AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshPro likesText;

	[Token(Token = "0x40009AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshPro playsText;

	[Token(Token = "0x40009AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshPro difficultyText;

	[Token(Token = "0x40009AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SpriteRenderer userImage;

	[Token(Token = "0x40009AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LoadingDots optionalLoadingDots;

	[Token(Token = "0x40009B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform spinningWheel;

	[Token(Token = "0x40009B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public DifficultyGauge difficultyGauge;

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x95FCB0", Offset = "0x95FCB0", VA = "0x95FCB0")]
	public OnlineSideMenu()
	{
	}
}
[Token(Token = "0x2000122")]
public class OnlineSplitMenu : SplitMenu
{
	[Token(Token = "0x40009B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject levelsLayout;

	[Token(Token = "0x40009B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject loadingLayout;

	[Token(Token = "0x40009B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ConnectionIndicator connectionIndicator;

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x95FCB8", Offset = "0x95FCB8", VA = "0x95FCB8")]
	public OnlineSplitMenu()
	{
	}
}
[Token(Token = "0x2000123")]
public enum OnlineSplitMenuButtonType
{
	[Token(Token = "0x40009B6")]
	NewTab,
	[Token(Token = "0x40009B7")]
	DifficultyTab,
	[Token(Token = "0x40009B8")]
	MostLikedTab,
	[Token(Token = "0x40009B9")]
	Weekly,
	[Token(Token = "0x40009BA")]
	AllTime,
	[Token(Token = "0x40009BB")]
	Custom,
	[Token(Token = "0x40009BC")]
	Sort
}
[Token(Token = "0x2000124")]
public class OnlineSplitMenuButton : LevelGridButton
{
	[Token(Token = "0x40009BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public OnlineSplitMenuButtonType type;

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x95FCC0", Offset = "0x95FCC0", VA = "0x95FCC0")]
	public OnlineSplitMenuButton()
	{
	}
}
[Token(Token = "0x2000125")]
public class OnlineSplitMenuHandler : SplitMenuHandler
{
	[Token(Token = "0x2000242")]
	protected enum State
	{
		[Token(Token = "0x4000ECE")]
		Like,
		[Token(Token = "0x4000ECF")]
		Difficulty,
		[Token(Token = "0x4000ED0")]
		New,
		[Token(Token = "0x4000ED1")]
		Custom
	}

	[Token(Token = "0x2000243")]
	protected enum TimespanOption
	{
		[Token(Token = "0x4000ED3")]
		Weekly,
		[Token(Token = "0x4000ED4")]
		AllTime
	}

	[Token(Token = "0x2000244")]
	protected enum SortingOption
	{
		[Token(Token = "0x4000ED6")]
		Descending,
		[Token(Token = "0x4000ED7")]
		Ascending
	}

	[Token(Token = "0x40009BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x40009BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x40009C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly Action<MenuType> setMenuType;

	[Token(Token = "0x40009C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly OnlineSplitMenu onlineSplitMenu;

	[Token(Token = "0x40009C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly OnlineSideMenu onlineSideMenu;

	[Token(Token = "0x40009C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x40009C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly CreateUserSettings createUserSettings;

	[Token(Token = "0x40009C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x40009C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly MenuContext menuContext;

	[Token(Token = "0x40009C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	protected LevelListContext currentListContext;

	[Token(Token = "0x40009C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	protected LevelListContext[] levelListContexts;

	[Token(Token = "0x40009C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	protected ServerLevelMetaData currentPreviewLevelData;

	[Token(Token = "0x40009CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly int[] selectedLevelIdPerContext;

	[Token(Token = "0x40009CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	protected bool isTransitionToPlay;

	[Token(Token = "0x40009CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
	private bool reinitializeState;

	[Token(Token = "0x40009CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private SortingOption sorting;

	[Token(Token = "0x40009CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private TimespanOption timespan;

	[Token(Token = "0x40009CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	protected State state;

	[Token(Token = "0x40009D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	protected State prevState;

	[Token(Token = "0x40009D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private bool stateHasInitialized;

	[Token(Token = "0x40009D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private int selectedButtonIndex;

	[Token(Token = "0x40009D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Future<User> getUserDataFuture;

	[Token(Token = "0x40009D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly DifficultyGaugeHandler difficultyGaugeHandler;

	[Token(Token = "0x40009D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private bool isPlayingSortEffect;

	[Token(Token = "0x40009D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private float sortingEffectTimer;

	[Token(Token = "0x40009D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private int sortingEffectButtonIndex;

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x95FCC8", Offset = "0x95FCC8", VA = "0x95FCC8")]
	protected OnlineSplitMenuHandler(LevelEditorPlayContext levelEditorPlayContext, NetworkHandler networkHandler, Action<LevelEditorStateType> setState, Action<MenuType> SetMenuType, SplitMenu splitMenu, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, InputHandler inputHandler, LevelContext levelContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelParent, CreateUserSettings createUserSettings, MenuContext menuContext)
	{
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x960480", Offset = "0x960480", VA = "0x960480", Slot = "10")]
	public override void Tick()
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x961D0C", Offset = "0x961D0C", VA = "0x961D0C", Slot = "8")]
	public override void Show()
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x9620C0", Offset = "0x9620C0", VA = "0x9620C0", Slot = "14")]
	protected override void UpdateLevelSlotButtons()
	{
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x962ED0", Offset = "0x962ED0", VA = "0x962ED0", Slot = "15")]
	protected override void UpdateNavigationButtons()
	{
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x9630B4", Offset = "0x9630B4", VA = "0x9630B4", Slot = "16")]
	protected virtual void UpdateTabButtons(State state)
	{
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x963484", Offset = "0x963484", VA = "0x963484", Slot = "11")]
	protected override void OnGridMenuButtonClick(int buttonIndex)
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x963ACC", Offset = "0x963ACC", VA = "0x963ACC", Slot = "13")]
	protected override void OnSideMenuButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x9617A4", Offset = "0x9617A4", VA = "0x9617A4")]
	protected void PopulateStats(ServerLevelMetaData data)
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x96123C", Offset = "0x96123C", VA = "0x96123C")]
	private void PopulateUser(User user)
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x960464", Offset = "0x960464", VA = "0x960464")]
	protected static int GetContextLookupId(State state, SortingOption sorting, TimespanOption timespan)
	{
		return default(int);
	}
}
[Token(Token = "0x2000126")]
public sealed class Page
{
	[Token(Token = "0x40009D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ServerLevelMetaData[] levels;

	[Token(Token = "0x40009D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string next_page;

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x964A1C", Offset = "0x964A1C", VA = "0x964A1C")]
	public Page()
	{
	}
}
[Token(Token = "0x2000127")]
public class PalazzoButton : MonoBehaviour
{
	[Token(Token = "0x2000245")]
	public enum State
	{
		[Token(Token = "0x4000ED9")]
		Pressed,
		[Token(Token = "0x4000EDA")]
		Hover,
		[Token(Token = "0x4000EDB")]
		Idle,
		[Token(Token = "0x4000EDC")]
		Disabled
	}

	[Token(Token = "0x40009DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7686FC", Offset = "0x7686FC")]
	public GameObject enabledGeo;

	[Token(Token = "0x40009DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x768734", Offset = "0x768734")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x768734", Offset = "0x768734")]
	public GameObject optionalHoverGeo;

	[Token(Token = "0x40009DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x768794", Offset = "0x768794")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x768794", Offset = "0x768794")]
	public GameObject optionalDisabledGeo;

	[Token(Token = "0x40009DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject optionalPressedGeo;

	[Token(Token = "0x40009DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool useCollider;

	[Token(Token = "0x40009DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Collider optionalCollider;

	[Token(Token = "0x40009E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject[] optionalToggleSprites;

	[Token(Token = "0x40009E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool isStationary;

	[Token(Token = "0x40009E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7687F4", Offset = "0x7687F4")]
	public bool isUsingCustomEnablingLogic;

	[Token(Token = "0x40009E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ParticleSystem optionalActivateParticle;

	[Token(Token = "0x40009E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ParticleSystem optionalDeactivateParticle;

	[Token(Token = "0x40009E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ParticleSystem optionalDefaultParticle;

	[Token(Token = "0x40009E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public State state;

	[Token(Token = "0x40009E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public State prevState;

	[NonSerialized]
	[Token(Token = "0x40009E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float elapsedNormalized;

	[NonSerialized]
	[Token(Token = "0x40009E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool isEnabled;

	[NonSerialized]
	[Token(Token = "0x40009EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Vector3 rootPosition;

	[NonSerialized]
	[Token(Token = "0x40009EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool isUsingCustomAnim;

	[NonSerialized]
	[Token(Token = "0x40009EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Animator optionalAnimator;

	[NonSerialized]
	[Token(Token = "0x40009ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool needsUserLoaded;

	[NonSerialized]
	[Token(Token = "0x40009EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool needsInternetConnection;

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x9679DC", Offset = "0x9679DC", VA = "0x9679DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x967AB4", Offset = "0x967AB4", VA = "0x967AB4")]
	public PalazzoButton()
	{
	}
}
[Token(Token = "0x2000128")]
public abstract class PalazzoButton<T> : PalazzoButton
{
	[Token(Token = "0x40009EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T buttonType;

	[Token(Token = "0x6000511")]
	protected PalazzoButton()
	{
	}
}
[Token(Token = "0x2000129")]
public class ParticleSystemTimeScaleFix : MonoBehaviour
{
	[Token(Token = "0x40009F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem particleSystem;

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x9C31B8", Offset = "0x9C31B8", VA = "0x9C31B8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x9C32A0", Offset = "0x9C32A0", VA = "0x9C32A0")]
	public ParticleSystemTimeScaleFix()
	{
	}
}
[Token(Token = "0x200012A")]
[DisallowMultipleComponent]
public sealed class PauseScreen : PlayMenuBase<ScoreboardButton>
{
	[Token(Token = "0x40009F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TMP_Text levelNameText;

	[Token(Token = "0x40009F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LocalizedText levelNameLocalized;

	[Token(Token = "0x40009F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocalizedText levelDescription;

	[Token(Token = "0x40009F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject optionalSpinningWheel;

	[Token(Token = "0x40009F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TMP_Text optionalUsernameText;

	[Token(Token = "0x40009F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TMP_Text optionalUsernameHoverText;

	[Token(Token = "0x40009F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TMP_Text optionalLevelCodeText;

	[Token(Token = "0x40009F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public SpriteRenderer optionalUserImage;

	[Token(Token = "0x40009F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public LoadingDots optionalLoadingDots;

	[Token(Token = "0x40009FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ConnectionIndicator connectionIndicator;

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x9C32A8", Offset = "0x9C32A8", VA = "0x9C32A8")]
	public PauseScreen()
	{
	}
}
[Token(Token = "0x200012B")]
public sealed class PauseScreenHandler : PlayMenuHandlerBase
{
	[Token(Token = "0x40009FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x40009FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly PauseScreen pauseScreen;

	[Token(Token = "0x40009FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x40009FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly LevelContext levelContext;

	[Token(Token = "0x40009FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly PalazzoGameDataPersistent gameDataPersistent;

	[Token(Token = "0x4000A00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly PalazzoWorld[] worldPrefabs;

	[Token(Token = "0x4000A01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly List<string> levelGuids;

	[Token(Token = "0x4000A02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000A03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x4000A04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen;

	[Token(Token = "0x4000A05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000A06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000A07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly CreateUserSettings createUserSettings;

	[Token(Token = "0x4000A08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameState nextGameState;

	[Token(Token = "0x4000A09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private bool handleNetworkResponse;

	[Token(Token = "0x4000A0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Future<ServerLevelMetaData> quickplayLevelFuture;

	[Token(Token = "0x4000A0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Future<User> getUserDataFuture;

	[Token(Token = "0x4000A0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private User user;

	[Token(Token = "0x4000A0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private PalazzoButton nextButton;

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x9C32F8", Offset = "0x9C32F8", VA = "0x9C32F8")]
	public PauseScreenHandler(ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, LevelContext levelContext, PauseScreen pauseScreen, PalazzoGameDataPersistent gameDataPersistent, WorldContext worldContext, MenuSettings menuSettings, PalazzoWorld[] worldPrefabs, MonoBehaviour monoBehaviour, Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen, LevelEditorPlayContext levelEditorPlayContext, NetworkHandler networkHandler, GameStateData gameStateData, CreateUserSettings createUserSettings)
	{
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x9C3630", Offset = "0x9C3630", VA = "0x9C3630", Slot = "7")]
	protected override void OnButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x9C3AEC", Offset = "0x9C3AEC", VA = "0x9C3AEC", Slot = "6")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x9C4B40", Offset = "0x9C4B40", VA = "0x9C4B40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76AA3C", Offset = "0x76AA3C")]
	private void <OnButtonClicked>b__20_0(GameState nextState)
	{
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x9C4B48", Offset = "0x9C4B48", VA = "0x9C4B48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76AA4C", Offset = "0x76AA4C")]
	private void <Tick>b__21_0(GameState nextState)
	{
	}
}
[Token(Token = "0x200012C")]
public abstract class PlayMenuBase<T> : MonoBehaviour where T : PalazzoButton
{
	[Token(Token = "0x4000A0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public PlayType playType;

	[Token(Token = "0x4000A0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T[] buttons;

	[Token(Token = "0x4000A10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ButtonSettings buttonSettings;

	[Token(Token = "0x600051A")]
	protected PlayMenuBase()
	{
	}
}
[Token(Token = "0x200012D")]
public abstract class PlayMenuHandlerBase
{
	[Token(Token = "0x2000246")]
	protected enum MenuState
	{
		[Token(Token = "0x4000EDE")]
		Init,
		[Token(Token = "0x4000EDF")]
		WaitForInput,
		[Token(Token = "0x4000EE0")]
		Hide,
		[Token(Token = "0x4000EE1")]
		TransitionOut
	}

	[Serializable]
	[Token(Token = "0x2000247")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767484", Offset = "0x767484")]
	private sealed class <>c
	{
		[Token(Token = "0x4000EE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000EE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<int> <>9__9_0;

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x9C8B90", Offset = "0x9C8B90", VA = "0x9C8B90")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x9C8B98", Offset = "0x9C8B98", VA = "0x9C8B98")]
		internal void <.ctor>b__9_0(int i)
		{
		}
	}

	[Token(Token = "0x4000A11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly PlayMenuBase<ScoreboardButton> menu;

	[Token(Token = "0x4000A12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000A13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000A14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000A15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly MenuSettings menuSettings;

	[Token(Token = "0x4000A16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected readonly ButtonHandler<PalazzoButton> buttonHandler;

	[Token(Token = "0x4000A17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected MenuState state;

	[Token(Token = "0x4000A18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected MenuState prevState;

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x9C341C", Offset = "0x9C341C", VA = "0x9C341C")]
	protected PlayMenuHandlerBase(PlayMenuBase<ScoreboardButton> menu, IList<PalazzoButton> buttons, ARTransforms arTransforms, MenuSettings menuSettings, WorldContext worldContext, InputHandler inputHandler, TrajectoryHandler trajectoryHandler, PalazzoTriggers palazzoTriggers)
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x9C4A98", Offset = "0x9C4A98", VA = "0x9C4A98")]
	protected void Show()
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x9C3A90", Offset = "0x9C3A90", VA = "0x9C3A90")]
	protected void Hide()
	{
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x9C8A30", Offset = "0x9C8A30", VA = "0x9C8A30", Slot = "4")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x9C8A54", Offset = "0x9C8A54", VA = "0x9C8A54", Slot = "5")]
	public virtual void PositionGui()
	{
	}

	[Token(Token = "0x6000520")]
	public abstract GameState Tick();

	[Token(Token = "0x6000521")]
	protected abstract void OnButtonClicked(int buttonIndex);

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x9C8B28", Offset = "0x9C8B28", VA = "0x9C8B28", Slot = "8")]
	protected virtual void OnButtonHovered(int buttonIndex)
	{
	}
}
[Token(Token = "0x200012E")]
public enum PrivacyButtonType
{
	[Token(Token = "0x4000A1A")]
	Checkbox,
	[Token(Token = "0x4000A1B")]
	Accept
}
[Token(Token = "0x200012F")]
public class PrivacyButton : PalazzoButton
{
	[Token(Token = "0x4000A1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x76883C", Offset = "0x76883C")]
	public PrivacyButtonType type;

	[Token(Token = "0x4000A1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject optionalCheck;

	[Token(Token = "0x4000A1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMeshPro[] optionalText;

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x9CA1C4", Offset = "0x9CA1C4", VA = "0x9CA1C4")]
	public PrivacyButton()
	{
	}
}
[Token(Token = "0x2000130")]
public class PrivacyMenu : UiMenuBase<PrivacyButton, PrivacyButtonType>
{
	[Token(Token = "0x4000A1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro title;

	[Token(Token = "0x4000A20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshPro description;

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x9CA1CC", Offset = "0x9CA1CC", VA = "0x9CA1CC")]
	public PrivacyMenu()
	{
	}
}
[Token(Token = "0x2000131")]
public class ProfileMenuHandler : OnlineSplitMenuHandler
{
	[Token(Token = "0x4000A21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly Action closeProfileMenu;

	[Token(Token = "0x4000A22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000A23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000A24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x4000A25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly Action<MenuType> setMenuType;

	[Token(Token = "0x4000A26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x4000A27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private readonly MenuContext menuContext;

	[Token(Token = "0x4000A28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private bool hasPlayed;

	[Token(Token = "0x4000A29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A1")]
	private bool isOldInstance;

	[Token(Token = "0x4000A2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private MenuType? returnMenu;

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x9CA74C", Offset = "0x9CA74C", VA = "0x9CA74C")]
	public ProfileMenuHandler(Action<LevelEditorStateType> setState, Action<MenuType> setMenuType, SplitMenu splitMenu, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, InputHandler inputHandler, NetworkHandler networkHandler, LevelContext levelContext, LevelEditorPlayContext levelEditorPlayContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelParent, CreateUserSettings createUserSettings, GameStateData gameStateData, MenuContext menuContext)
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x9CA88C", Offset = "0x9CA88C", VA = "0x9CA88C", Slot = "8")]
	public override void Show()
	{
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x9CB030", Offset = "0x9CB030", VA = "0x9CB030", Slot = "11")]
	protected override void OnGridMenuButtonClick(int buttonIndex)
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0x9CB1F0", Offset = "0x9CB1F0", VA = "0x9CB1F0", Slot = "13")]
	protected override void OnSideMenuButtonClicked(int buttonIndex)
	{
	}
}
[Token(Token = "0x2000132")]
[DisallowMultipleComponent]
public sealed class RatingScreen : PlayMenuBase<ScoreboardButton>
{
	[Token(Token = "0x6000529")]
	[Address(RVA = "0x9DC720", Offset = "0x9DC720", VA = "0x9DC720")]
	public RatingScreen()
	{
	}
}
[Token(Token = "0x2000133")]
public sealed class RatingScreenHandler : PlayMenuHandlerBase
{
	[Token(Token = "0x4000A2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000A2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000A2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly RatingScreen ratingScreen;

	[Token(Token = "0x4000A2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly Action onButtonClicked;

	[Token(Token = "0x4000A2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000A30")]
	private const float FX_TIMER = 1f;

	[Token(Token = "0x4000A31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float timer;

	[Token(Token = "0x600052A")]
	[Address(RVA = "0x9DC770", Offset = "0x9DC770", VA = "0x9DC770")]
	public RatingScreenHandler(NetworkHandler networkHandler, LevelEditorPlayContext levelEditorPlayContext, RatingScreen ratingScreen, ARTransforms arTransforms, MenuSettings menuSettings, WorldContext worldContext, InputHandler inputHandler, TrajectoryHandler trajectoryHandler, PalazzoTriggers palazzoTriggers, Action onButtonClicked)
	{
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0x9DC81C", Offset = "0x9DC81C", VA = "0x9DC81C", Slot = "6")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0x9DC904", Offset = "0x9DC904", VA = "0x9DC904", Slot = "7")]
	protected override void OnButtonClicked(int buttonIndex)
	{
	}
}
[Token(Token = "0x2000134")]
public class RecoveryMenu : UiMenuBase<RecoveryMenuButton, RecoveryMenuButtonType>
{
	[Token(Token = "0x600052D")]
	[Address(RVA = "0x9DCA88", Offset = "0x9DCA88", VA = "0x9DCA88")]
	public RecoveryMenu()
	{
	}
}
[Token(Token = "0x2000135")]
public enum RecoveryMenuButtonType
{
	[Token(Token = "0x4000A33")]
	Yes,
	[Token(Token = "0x4000A34")]
	No
}
[Token(Token = "0x2000136")]
public class RecoveryMenuButton : PalazzoButton<RecoveryMenuButtonType>
{
	[Token(Token = "0x600052E")]
	[Address(RVA = "0x9DCAD8", Offset = "0x9DCAD8", VA = "0x9DCAD8")]
	public RecoveryMenuButton()
	{
	}
}
[Token(Token = "0x2000137")]
public class ReportMenu : UiMenuBase<ReportMenuButton, ReportMenuButtonType>
{
	[Token(Token = "0x4000A35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject report;

	[Token(Token = "0x4000A36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject thanks;

	[Token(Token = "0x600052F")]
	[Address(RVA = "0x9DCB28", Offset = "0x9DCB28", VA = "0x9DCB28")]
	public ReportMenu()
	{
	}
}
[Token(Token = "0x2000138")]
public enum ReportMenuButtonType
{
	[Token(Token = "0x4000A38")]
	Cancel,
	[Token(Token = "0x4000A39")]
	Impossible,
	[Token(Token = "0x4000A3A")]
	Offensive
}
[Token(Token = "0x2000139")]
public class ReportMenuButton : PalazzoButton<ReportMenuButtonType>
{
	[Token(Token = "0x6000530")]
	[Address(RVA = "0x9DCB78", Offset = "0x9DCB78", VA = "0x9DCB78")]
	public ReportMenuButton()
	{
	}
}
[Token(Token = "0x200013A")]
public class ReportMenuHandler : IMenuHandler
{
	[Token(Token = "0x4000A3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly UiMenuHandlerBase<ReportMenuButton, ReportMenuButtonType> menuHandler;

	[Token(Token = "0x4000A3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly ReportMenu menu;

	[Token(Token = "0x4000A3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly LevelEditorPlayContext levelEditorPlayContext;

	[Token(Token = "0x4000A3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x4000A3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<MenuType> setMenuType;

	[Token(Token = "0x4000A40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly NetworkHandler networkHandler;

	[Token(Token = "0x4000A41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly GameStateData gameStateData;

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x9DCBC8", Offset = "0x9DCBC8", VA = "0x9DCBC8")]
	public ReportMenuHandler(UiMenuBase<ReportMenuButton, ReportMenuButtonType> menu, ARTransforms arTransforms, InputHandler inputHandler, WorldContext worldContext, MenuSettings menuSettings, TrajectoryHandler trajectoryHandler, PalazzoTriggers palazzoTriggers, LevelEditorPlayContext levelEditorPlayContext, Action<LevelEditorStateType> setState, Action<MenuType> setMenuType, NetworkHandler networkHandler, GameStateData gameStateData)
	{
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0x9DCDC0", Offset = "0x9DCDC0", VA = "0x9DCDC0")]
	private void OnButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x9DD124", Offset = "0x9DD124", VA = "0x9DD124", Slot = "5")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x9DD184", Offset = "0x9DD184", VA = "0x9DD184", Slot = "6")]
	public void InstantHide()
	{
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0x9DD1E4", Offset = "0x9DD1E4", VA = "0x9DD1E4", Slot = "4")]
	public void Show()
	{
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x9DD2AC", Offset = "0x9DD2AC", VA = "0x9DD2AC", Slot = "7")]
	public void Tick()
	{
	}
}
[Token(Token = "0x200013B")]
public class SaveLevelsMenu : SplitMenu
{
	[Token(Token = "0x4000A42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LevelGridButton[] unusedLevelSlots;

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x9DFD40", Offset = "0x9DFD40", VA = "0x9DFD40")]
	public SaveLevelsMenu()
	{
	}
}
[Token(Token = "0x200013C")]
public class SaveLevelsMenuHandler : SplitMenuHandler
{
	[Serializable]
	[Token(Token = "0x2000248")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767494", Offset = "0x767494")]
	private sealed class <>c
	{
		[Token(Token = "0x4000EE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000EE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<int> <>9__5_0;

		[Token(Token = "0x4000EE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<int> <>9__5_1;

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x9E1810", Offset = "0x9E1810", VA = "0x9E1810")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x9E1818", Offset = "0x9E1818", VA = "0x9E1818")]
		internal void <.ctor>b__5_0(int i)
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x9E181C", Offset = "0x9E181C", VA = "0x9E181C")]
		internal void <.ctor>b__5_1(int i)
		{
		}
	}

	[Token(Token = "0x4000A43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly SaveLevelsMenu saveLevelsMenu;

	[Token(Token = "0x4000A44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly LevelEditorContext levelEditorContext;

	[Token(Token = "0x4000A45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly Action<LevelEditorStateType> setState;

	[Token(Token = "0x4000A46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly ButtonHandler<LevelGridButton> unusedLevelSlotsButtonHandler;

	[Token(Token = "0x4000A47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly MenuContext menuContext;

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x9DFD50", Offset = "0x9DFD50", VA = "0x9DFD50")]
	public SaveLevelsMenuHandler(LevelEditorContext levelEditorContext, Action<LevelEditorStateType> setState, SplitMenu splitMenu, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, InputHandler inputHandler, LevelContext levelContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelParent, MenuContext menuContext)
	{
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x9E05D4", Offset = "0x9E05D4", VA = "0x9E05D4", Slot = "11")]
	protected override void OnGridMenuButtonClick(int buttonIndex)
	{
	}

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x9E08F0", Offset = "0x9E08F0", VA = "0x9E08F0", Slot = "13")]
	protected override void OnSideMenuButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x9E0B88", Offset = "0x9E0B88", VA = "0x9E0B88", Slot = "10")]
	public override void Tick()
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x9E086C", Offset = "0x9E086C", VA = "0x9E086C")]
	private void SelectLevel()
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x9E0F0C", Offset = "0x9E0F0C", VA = "0x9E0F0C", Slot = "14")]
	protected override void UpdateLevelSlotButtons()
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x9E1694", Offset = "0x9E1694", VA = "0x9E1694", Slot = "8")]
	public override void Show()
	{
	}
}
[Token(Token = "0x200013D")]
public class ScoreboardBase : PlayMenuBase<ScoreboardButton>
{
	[Token(Token = "0x600053F")]
	[Address(RVA = "0x9E182C", Offset = "0x9E182C", VA = "0x9E182C")]
	public ScoreboardBase()
	{
	}
}
[Token(Token = "0x200013E")]
[DisallowMultipleComponent]
public sealed class Scoreboard : ScoreboardBase
{
	[Token(Token = "0x4000A48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator scoreBarAnimator;

	[Token(Token = "0x4000A49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material darkStar;

	[Token(Token = "0x4000A4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material litStar;

	[Token(Token = "0x4000A4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshPro levelText;

	[Token(Token = "0x4000A4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public LocalizedText localizedLevelName;

	[Token(Token = "0x4000A4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshPro scoreText;

	[Token(Token = "0x4000A4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshPro scoreBreakdownText;

	[Token(Token = "0x4000A4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ScoreboardBreakdownComponent levelBlock;

	[Token(Token = "0x4000A50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ScoreboardBreakdownComponent pig;

	[Token(Token = "0x4000A51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ScoreboardBreakdownComponent red;

	[Token(Token = "0x4000A52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ScoreboardBreakdownComponent yellow;

	[Token(Token = "0x4000A53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ScoreboardBreakdownComponent blue;

	[Token(Token = "0x4000A54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public ScoreboardBreakdownComponent black;

	[Token(Token = "0x4000A55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public PalazzoComponentStar[] stars;

	[Token(Token = "0x4000A56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform despawnEffectTransform;

	[NonSerialized]
	[Token(Token = "0x4000A57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float animationTimeBlend;

	[NonSerialized]
	[Token(Token = "0x4000A58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public bool disableButtons;

	[Token(Token = "0x6000540")]
	[Address(RVA = "0x9E1828", Offset = "0x9E1828", VA = "0x9E1828")]
	public Scoreboard()
	{
	}
}
[Token(Token = "0x200013F")]
public class ScoreboardBreakdownComponent : MonoBehaviour
{
	[Token(Token = "0x4000A59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool hasAnimation;

	[Token(Token = "0x4000A5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator anim;

	[Token(Token = "0x4000A5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string animationTrigger;

	[Token(Token = "0x6000541")]
	[Address(RVA = "0x9E187C", Offset = "0x9E187C", VA = "0x9E187C")]
	public ScoreboardBreakdownComponent()
	{
	}
}
[Token(Token = "0x2000140")]
public enum ScoreBoardButtonType
{
	[Token(Token = "0x4000A5D")]
	LevelSelect,
	[Token(Token = "0x4000A5E")]
	Retry,
	[Token(Token = "0x4000A5F")]
	NextLevel,
	[Token(Token = "0x4000A60")]
	Close,
	[Token(Token = "0x4000A61")]
	BackToEdit,
	[Token(Token = "0x4000A62")]
	Upload,
	[Token(Token = "0x4000A63")]
	WorldSelect,
	[Token(Token = "0x4000A64")]
	Favorite,
	[Token(Token = "0x4000A65")]
	Report,
	[Token(Token = "0x4000A66")]
	User,
	[Token(Token = "0x4000A67")]
	Like,
	[Token(Token = "0x4000A68")]
	Dislike
}
[Token(Token = "0x2000141")]
public sealed class ScoreboardButton : PalazzoButton<ScoreBoardButtonType>
{
	[Token(Token = "0x6000542")]
	[Address(RVA = "0x9E1884", Offset = "0x9E1884", VA = "0x9E1884")]
	public ScoreboardButton()
	{
	}
}
[Token(Token = "0x2000142")]
public sealed class ScoreboardHandler : PlayMenuHandlerBase
{
	[Token(Token = "0x2000249")]
	private enum ScoreboardState
	{
		[Token(Token = "0x4000EE8")]
		Init,
		[Token(Token = "0x4000EE9")]
		Wait,
		[Token(Token = "0x4000EEA")]
		ShowGeometry,
		[Token(Token = "0x4000EEB")]
		TickScore,
		[Token(Token = "0x4000EEC")]
		AnimateStars,
		[Token(Token = "0x4000EED")]
		Skip,
		[Token(Token = "0x4000EEE")]
		Done,
		[Token(Token = "0x4000EEF")]
		Hide
	}

	[Token(Token = "0x4000A69")]
	private const float INVERSE_GAME_OVER_COUNTER_DURATION = 2f / 3f;

	[Token(Token = "0x4000A6A")]
	private const float GAME_OVER_STAR_DURATION_PER_STAR = 0.3f;

	[Token(Token = "0x4000A6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000A6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000A6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly PalazzoTriggers palazzoTriggers;

	[Token(Token = "0x4000A6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly ScoreboardContext scoreboardContext;

	[Token(Token = "0x4000A6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly Scoreboard scoreboard;

	[Token(Token = "0x4000A70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly ScoreboardSettings scoreboardSettings;

	[Token(Token = "0x4000A71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly PalazzoWorld[] worldPrefabs;

	[Token(Token = "0x4000A72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly MonoBehaviour monoBehaviour;

	[Token(Token = "0x4000A73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen;

	[Token(Token = "0x4000A74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Animator scoreBarAnimator;

	[Token(Token = "0x4000A75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly int scoreBarStateNameHash;

	[Token(Token = "0x4000A76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private ScoreboardState scoreboardState;

	[Token(Token = "0x4000A77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private ScoreboardState prevScoreboardState;

	[Token(Token = "0x4000A78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float timeSinceStartActivatingStars;

	[Token(Token = "0x4000A79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float timeSinceStartActivatingStarsPrevious;

	[Token(Token = "0x4000A7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private float timeScaling;

	[Token(Token = "0x4000A7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float timeToWait;

	[Token(Token = "0x4000A7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private int score1;

	[Token(Token = "0x4000A7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int score2;

	[Token(Token = "0x4000A7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private int score3;

	[Token(Token = "0x4000A7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int numOfStars;

	[Token(Token = "0x4000A80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private bool isButtonsDisabled;

	[Token(Token = "0x4000A81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameState nextGameState;

	[Token(Token = "0x4000A82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly List<ScoreboardBreakdownComponent> scalingLevelBlocks;

	[Token(Token = "0x4000A83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly float[] animationTimeBlendTargets;

	[Token(Token = "0x4000A84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly int[] targetScores;

	[Token(Token = "0x4000A85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly int[] separateScores;

	[Token(Token = "0x4000A86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private int currentBreakDownPhase;

	[Token(Token = "0x4000A87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private int scalingBlocksShown;

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x9E1948", Offset = "0x9E1948", VA = "0x9E1948")]
	public ScoreboardHandler(ARTransforms arTransforms, InputHandler inputHandler, PalazzoTriggers palazzoTriggers, TrajectoryHandler trajectoryHandler, ScoreboardContext scoreboardContext, Scoreboard scoreboard, ScoreboardSettings scoreboardSettings, WorldContext worldContext, MenuSettings menuSettings, PalazzoWorld[] worldPrefabs, MonoBehaviour monoBehaviour, Func<ScoreBoardButtonType, Action<GameState>, IEnumerator> delayedClickEndOfLevelScreen)
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x9E1BD0", Offset = "0x9E1BD0", VA = "0x9E1BD0", Slot = "5")]
	public override void PositionGui()
	{
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x9E1C8C", Offset = "0x9E1C8C", VA = "0x9E1C8C")]
	private void ShowScalingObject()
	{
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0x9E204C", Offset = "0x9E204C", VA = "0x9E204C", Slot = "4")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0x9E2074", Offset = "0x9E2074", VA = "0x9E2074", Slot = "6")]
	public override GameState Tick()
	{
		return default(GameState);
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x9E3EE0", Offset = "0x9E3EE0", VA = "0x9E3EE0", Slot = "7")]
	protected override void OnButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0x9E4020", Offset = "0x9E4020", VA = "0x9E4020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76AA5C", Offset = "0x76AA5C")]
	private void <OnButtonClicked>b__37_0(GameState nextState)
	{
	}
}
[Token(Token = "0x2000143")]
public sealed class SettingsMenu : UiMenuBase<SettingsMenuButton, SettingsMenuButtonType>
{
	[Token(Token = "0x4000A88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SettingsMenuButton closeButton;

	[Token(Token = "0x4000A89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject main;

	[Token(Token = "0x4000A8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject confirmPrompt;

	[Token(Token = "0x4000A8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocalizedText confirmText;

	[Token(Token = "0x4000A8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocalizedText confirmFeedbackText;

	[Token(Token = "0x4000A8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject confirmFeedback;

	[Token(Token = "0x4000A8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject riftControls;

	[Token(Token = "0x4000A8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject viveControls;

	[Token(Token = "0x4000A90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject moveControls;

	[Token(Token = "0x4000A91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject questControls;

	[Token(Token = "0x4000A92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject riftSControls;

	[Token(Token = "0x4000A93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject indexControls;

	[Token(Token = "0x4000A94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public GameObject controls;

	[Token(Token = "0x600054A")]
	[Address(RVA = "0x9E9804", Offset = "0x9E9804", VA = "0x9E9804")]
	public SettingsMenu()
	{
	}
}
[Token(Token = "0x2000144")]
public enum SettingsMenuButtonType
{
	[Token(Token = "0x4000A96")]
	MuteSound,
	[Token(Token = "0x4000A97")]
	MuteMusic,
	[Token(Token = "0x4000A98")]
	Vibration,
	[Token(Token = "0x4000A99")]
	Reset,
	[Token(Token = "0x4000A9A")]
	Exit,
	[Token(Token = "0x4000A9B")]
	Cancel,
	[Token(Token = "0x4000A9C")]
	Yes,
	[Token(Token = "0x4000A9D")]
	No,
	[Token(Token = "0x4000A9E")]
	Ok,
	[Token(Token = "0x4000A9F")]
	Controls,
	[Token(Token = "0x4000AA0")]
	BackControlsOculus,
	[Token(Token = "0x4000AA1")]
	BackControlsVive,
	[Token(Token = "0x4000AA2")]
	BackControlsMove,
	[Token(Token = "0x4000AA3")]
	BackControlsQuest,
	[Token(Token = "0x4000AA4")]
	BackControlsRiftS,
	[Token(Token = "0x4000AA5")]
	PrivacyPolicy,
	[Token(Token = "0x4000AA6")]
	SwapHandedness,
	[Token(Token = "0x4000AA7")]
	UseSlingshotAim,
	[Token(Token = "0x4000AA8")]
	BackControlsIndex,
	[Token(Token = "0x4000AA9")]
	TermsOfUse
}
[Token(Token = "0x2000145")]
public sealed class SettingsMenuButton : PalazzoButton
{
	[Token(Token = "0x4000AAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x768884", Offset = "0x768884")]
	public SettingsMenuButtonType type;

	[Token(Token = "0x4000AAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject optionalCheck;

	[Token(Token = "0x600054B")]
	[Address(RVA = "0x9E9854", Offset = "0x9E9854", VA = "0x9E9854")]
	public SettingsMenuButton()
	{
	}
}
[Token(Token = "0x2000146")]
public class SideMenu : UiMenuBase<SideMenuButton, SideMenuButtonType>
{
	[Token(Token = "0x4000AAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SubSideMenu[] subSideMenus;

	[Token(Token = "0x600054C")]
	[Address(RVA = "0x9EB004", Offset = "0x9EB004", VA = "0x9EB004")]
	public SideMenu()
	{
	}
}
[Token(Token = "0x2000147")]
public enum SideMenuButtonType
{
	[Token(Token = "0x4000AAE")]
	Play,
	[Token(Token = "0x4000AAF")]
	Edit,
	[Token(Token = "0x4000AB0")]
	Duplicate,
	[Token(Token = "0x4000AB1")]
	Upload,
	[Token(Token = "0x4000AB2")]
	Favorite,
	[Token(Token = "0x4000AB3")]
	Delete,
	[Token(Token = "0x4000AB4")]
	Yes,
	[Token(Token = "0x4000AB5")]
	No,
	[Token(Token = "0x4000AB6")]
	Build,
	[Token(Token = "0x4000AB7")]
	Save,
	[Token(Token = "0x4000AB8")]
	Overwrite,
	[Token(Token = "0x4000AB9")]
	Cancel,
	[Token(Token = "0x4000ABA")]
	Unshare,
	[Token(Token = "0x4000ABB")]
	Disabled,
	[Token(Token = "0x4000ABC")]
	Report,
	[Token(Token = "0x4000ABD")]
	User,
	[Token(Token = "0x4000ABE")]
	CreateUser,
	[Token(Token = "0x4000ABF")]
	PlayTrial
}
[Token(Token = "0x2000148")]
public class SideMenuButton : PalazzoButton<SideMenuButtonType>
{
	[Token(Token = "0x4000AC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public TextMeshPro optionalUserNameDefault;

	[Token(Token = "0x4000AC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMeshPro optionalUserNameHover;

	[Token(Token = "0x600054D")]
	[Address(RVA = "0x9EB054", Offset = "0x9EB054", VA = "0x9EB054")]
	public SideMenuButton()
	{
	}
}
[Token(Token = "0x2000149")]
public class SlotMachine : MonoBehaviour
{
	[Token(Token = "0x4000AC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SlotMachineWords slotMachineWords;

	[Token(Token = "0x4000AC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] textFieldRoots;

	[Token(Token = "0x4000AC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro[] textFields;

	[Token(Token = "0x4000AC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float rotationSpeedUpTime;

	[Token(Token = "0x4000AC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float rotationTopSpeed;

	[Token(Token = "0x4000AC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float rotationInterval;

	[Token(Token = "0x4000AC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem borderParticles;

	[Token(Token = "0x4000AC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Animator scrollVFX;

	[Token(Token = "0x600054E")]
	[Address(RVA = "0x9ED88C", Offset = "0x9ED88C", VA = "0x9ED88C")]
	public SlotMachine()
	{
	}
}
[Token(Token = "0x200014A")]
public class SlotMachineHandler
{
	[Token(Token = "0x200024A")]
	private enum State
	{
		[Token(Token = "0x4000EF1")]
		Stop,
		[Token(Token = "0x4000EF2")]
		Accelerate,
		[Token(Token = "0x4000EF3")]
		Rotate,
		[Token(Token = "0x4000EF4")]
		Select
	}

	[Serializable]
	[Token(Token = "0x200024B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7674A4", Offset = "0x7674A4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000EF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<bool, bool> <>9__20_0;

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x9EF844", Offset = "0x9EF844", VA = "0x9EF844")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x9EF84C", Offset = "0x9EF84C", VA = "0x9EF84C")]
		internal bool <Tick>b__20_0(bool x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000ACA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly SlotMachine[] slotMachines;

	[Token(Token = "0x4000ACB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly GameObject spriteRoot;

	[Token(Token = "0x4000ACC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly SpriteRenderer spriteRenderer;

	[Token(Token = "0x4000ACD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly float spriteMaxSpeed;

	[Token(Token = "0x4000ACE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private readonly float spriteAccelerationTime;

	[Token(Token = "0x4000ACF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Sprite[] images;

	[Token(Token = "0x4000AD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string[] selectedNames;

	[Token(Token = "0x4000AD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private State state;

	[Token(Token = "0x4000AD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] currentWordIndex;

	[Token(Token = "0x4000AD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float[] currentSlotMachineSpeed;

	[Token(Token = "0x4000AD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float rotationStartTime;

	[Token(Token = "0x4000AD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool readyToSelect;

	[Token(Token = "0x4000AD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool[] isDecelarating;

	[Token(Token = "0x4000AD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] selectedFieldIndex;

	[Token(Token = "0x4000AD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool[] stopped;

	[Token(Token = "0x4000AD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool[] playedScrollVFX;

	[Token(Token = "0x4000ADA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float spriteDirection;

	[Token(Token = "0x4000ADB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int currentImageIndex;

	[Token(Token = "0x600054F")]
	[Address(RVA = "0x9ED894", Offset = "0x9ED894", VA = "0x9ED894")]
	public SlotMachineHandler(SlotMachine[] slotMachines, GameObject spriteRoot, SpriteRenderer spriteRenderer, float spriteMaxSpeed, float spriteAccelerationTime, Sprite[] images)
	{
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0x9EDD88", Offset = "0x9EDD88", VA = "0x9EDD88")]
	public void Tick()
	{
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0x9EF498", Offset = "0x9EF498", VA = "0x9EF498")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x9EF4A8", Offset = "0x9EF4A8", VA = "0x9EF4A8")]
	public void StartRotation()
	{
	}

	[Token(Token = "0x6000553")]
	[Address(RVA = "0x9EF540", Offset = "0x9EF540", VA = "0x9EF540")]
	public void Select(string[] nameParts)
	{
	}

	[Token(Token = "0x6000554")]
	[Address(RVA = "0x9EF7D8", Offset = "0x9EF7D8", VA = "0x9EF7D8")]
	public int GetSpriteIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x9EEAE8", Offset = "0x9EEAE8", VA = "0x9EEAE8")]
	private void MoveTextFields(int slotMachineIndex)
	{
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x9EF27C", Offset = "0x9EF27C", VA = "0x9EF27C")]
	private bool TryMoveSprite(float speed, bool stopOnNextSprite)
	{
		return default(bool);
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x9EEA3C", Offset = "0x9EEA3C", VA = "0x9EEA3C")]
	private float EaseInCubic(float x)
	{
		return default(float);
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x9EDC34", Offset = "0x9EDC34", VA = "0x9EDC34")]
	private void ShuffleArray(string[] array)
	{
	}
}
[Token(Token = "0x200014B")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x766AF0", Offset = "0x766AF0")]
public class SlotMachineWords : ScriptableObject
{
	[Token(Token = "0x4000ADC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string[] words;

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x9EF854", Offset = "0x9EF854", VA = "0x9EF854")]
	public SlotMachineWords()
	{
	}
}
[Token(Token = "0x200014C")]
public sealed class SplashScreenHandler : MonoBehaviour
{
	[Token(Token = "0x200024C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7674B4", Offset = "0x7674B4")]
	private sealed class <Start>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplashScreenHandler <>4__this;

		[Token(Token = "0x4000EFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <async>5__2;

		[Token(Token = "0x17000114")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x9F0E6C", Offset = "0x9F0E6C", VA = "0x9F0E6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000115")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x9F0EDC", Offset = "0x9F0EDC", VA = "0x9F0EDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x9F0944", Offset = "0x9F0944", VA = "0x9F0944")]
		[DebuggerHidden]
		public <Start>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x9F0AC0", Offset = "0x9F0AC0", VA = "0x9F0AC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x9F0AC4", Offset = "0x9F0AC4", VA = "0x9F0AC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x9F0E74", Offset = "0x9F0E74", VA = "0x9F0E74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200024D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7674C4", Offset = "0x7674C4")]
	private sealed class <UpdateDot>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000EFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000EFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplashScreenHandler <>4__this;

		[Token(Token = "0x17000116")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x9F10B4", Offset = "0x9F10B4", VA = "0x9F10B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000117")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x9F1124", Offset = "0x9F1124", VA = "0x9F1124", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x9F09E4", Offset = "0x9F09E4", VA = "0x9F09E4")]
		[DebuggerHidden]
		public <UpdateDot>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x9F0EE4", Offset = "0x9F0EE4", VA = "0x9F0EE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x9F0EE8", Offset = "0x9F0EE8", VA = "0x9F0EE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x9F10BC", Offset = "0x9F10BC", VA = "0x9F10BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000ADD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float warmupShaderProgress;

	[Token(Token = "0x4000ADE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static bool done;

	[Token(Token = "0x4000ADF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly WaitForSeconds halfASecond;

	[Token(Token = "0x4000AE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly WaitForSeconds logoShowForSeconds;

	[Token(Token = "0x4000AE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Camera logoCamera;

	[Token(Token = "0x4000AE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject rovioLogo;

	[Token(Token = "0x4000AE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject resolutionLogo;

	[Token(Token = "0x4000AE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject gameLogo;

	[Token(Token = "0x4000AE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject[] dots;

	[Token(Token = "0x4000AE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject backgroundDots;

	[Token(Token = "0x4000AE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int dotIndex;

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x9F073C", Offset = "0x9F073C", VA = "0x9F073C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x9F08D0", Offset = "0x9F08D0", VA = "0x9F08D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76AA6C", Offset = "0x76AA6C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x9F0970", Offset = "0x9F0970", VA = "0x9F0970")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76AAD0", Offset = "0x76AAD0")]
	private IEnumerator UpdateDot()
	{
		return null;
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x9F0A10", Offset = "0x9F0A10", VA = "0x9F0A10")]
	public SplashScreenHandler()
	{
	}
}
[Token(Token = "0x200014D")]
public class SplitMenu : MonoBehaviour
{
	[Token(Token = "0x4000AE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LevelGridMenu levelGridMenu;

	[Token(Token = "0x4000AE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SideMenu sideMenu;

	[Token(Token = "0x4000AEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MenuType menuType;

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x9DFD48", Offset = "0x9DFD48", VA = "0x9DFD48")]
	public SplitMenu()
	{
	}
}
[Token(Token = "0x200014E")]
public class SplitMenuHandler : IMenuHandler
{
	[Serializable]
	[Token(Token = "0x200024E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7674D4", Offset = "0x7674D4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000EFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<int> <>9__27_0;

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x9F1640", Offset = "0x9F1640", VA = "0x9F1640")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x9F1648", Offset = "0x9F1648", VA = "0x9F1648")]
		internal void <.ctor>b__27_0(int i)
		{
		}
	}

	[Token(Token = "0x4000AEB")]
	public const int NUMBER_OF_LEVELS_PER_PAGE = 12;

	[Token(Token = "0x4000AEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected readonly SplitMenu splitMenu;

	[Token(Token = "0x4000AED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly UiMenuHandlerBase<LevelGridButton, LevelGridButtonType> gridMenuHandler;

	[Token(Token = "0x4000AEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly UiMenuHandlerBase<SideMenuButton, SideMenuButtonType> sideMenuHandler;

	[Token(Token = "0x4000AEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly SubSideMenu[] subSideMenus;

	[Token(Token = "0x4000AF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly LevelGridButton[] gridButtons;

	[Token(Token = "0x4000AF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly SlideIndicator[] slideIndicators;

	[Token(Token = "0x4000AF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly AnimationComponent animationComponent;

	[Token(Token = "0x4000AF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly Transform menuTransform;

	[Token(Token = "0x4000AF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000AF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000AF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly MenuSettings menuSettings;

	[Token(Token = "0x4000AF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000AF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly PreviewHandler previewHandler;

	[Token(Token = "0x4000AF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected SideMenuButtonType lastButtonClicked;

	[Token(Token = "0x4000AFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected int pageIndex;

	[Token(Token = "0x4000AFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected uint selectedButtonLevelId;

	[Token(Token = "0x4000AFC")]
	private const int BUTTONS_PER_PAGE = 12;

	[Token(Token = "0x4000AFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private readonly int totalNumberOfPages;

	[Token(Token = "0x4000AFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3? startPosition;

	[Token(Token = "0x4000AFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Quaternion? startRotation;

	[Token(Token = "0x4000B00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool isShowing;

	[Token(Token = "0x4000B01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float showTimer;

	[Token(Token = "0x4000B02")]
	private const float SHOW_DELAY = 0.5f;

	[Token(Token = "0x4000B03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int uiSpawnId;

	[Token(Token = "0x4000B04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private bool isLoadingLevel;

	[Token(Token = "0x4000B05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private ThreadJob<Level> loadLevelJob;

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x9E00BC", Offset = "0x9E00BC", VA = "0x9E00BC")]
	protected SplitMenuHandler(SplitMenu splitMenu, ARTransforms arTransforms, PalazzoTriggers palazzoTriggers, WorldContext worldContext, TrajectoryHandler trajectoryHandler, MenuSettings menuSettings, InputHandler inputHandler, LevelContext levelContext, LevelFactory levelFactory, MonoBehaviour monoBehaviour, Transform levelParent, [Optional] NetworkHandler networkHandler)
	{
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x9E16D0", Offset = "0x9E16D0", VA = "0x9E16D0", Slot = "8")]
	public virtual void Show()
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x9F1278", Offset = "0x9F1278", VA = "0x9F1278", Slot = "9")]
	public virtual void Hide()
	{
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x9F1320", Offset = "0x9F1320", VA = "0x9F1320", Slot = "6")]
	public void InstantHide()
	{
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x9E0BF0", Offset = "0x9E0BF0", VA = "0x9E0BF0", Slot = "10")]
	public virtual void Tick()
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x9F13A4", Offset = "0x9F13A4", VA = "0x9F13A4")]
	protected void SelectLevel(uint levelId)
	{
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x9E0DF8", Offset = "0x9E0DF8", VA = "0x9E0DF8")]
	protected void SetSideMenu(SubSideMenuType subSideMenuType)
	{
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x9F112C", Offset = "0x9F112C", VA = "0x9F112C")]
	private void PositionGui()
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x9E06F0", Offset = "0x9E06F0", VA = "0x9E06F0", Slot = "11")]
	protected virtual void OnGridMenuButtonClick(int buttonIndex)
	{
	}

	[Token(Token = "0x6000569")]
	[Address(RVA = "0x9F1400", Offset = "0x9F1400", VA = "0x9F1400", Slot = "12")]
	protected virtual void OnGridMenuButtonHover(int buttonIndex)
	{
	}

	[Token(Token = "0x600056A")]
	[Address(RVA = "0x9E0B84", Offset = "0x9E0B84", VA = "0x9E0B84", Slot = "13")]
	protected virtual void OnSideMenuButtonClicked(int buttonIndex)
	{
	}

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x9E1410", Offset = "0x9E1410", VA = "0x9E1410", Slot = "14")]
	protected virtual void UpdateLevelSlotButtons()
	{
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x9F1404", Offset = "0x9F1404", VA = "0x9F1404", Slot = "15")]
	protected virtual void UpdateNavigationButtons()
	{
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x9E1684", Offset = "0x9E1684", VA = "0x9E1684")]
	protected uint GetLevelIdFromButtonIndex(int buttonIndex)
	{
		return default(uint);
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x9F1538", Offset = "0x9F1538", VA = "0x9F1538")]
	protected void Preview(ThreadJob<Level> loadLevelJob)
	{
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x9E0D90", Offset = "0x9E0D90", VA = "0x9E0D90")]
	protected void Preview(Level level)
	{
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x9E0DC8", Offset = "0x9E0DC8", VA = "0x9E0DC8")]
	protected void Despawn()
	{
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x9F1548", Offset = "0x9F1548", VA = "0x9F1548")]
	protected void InstantDespawn()
	{
	}
}
[Token(Token = "0x200014F")]
public enum StartButtonType
{
	[Token(Token = "0x4000B07")]
	Start
}
[Token(Token = "0x2000150")]
public class StartScreen : UiMenuBase<PalazzoButton, StartButtonType>
{
	[Token(Token = "0x6000573")]
	[Address(RVA = "0x9F164C", Offset = "0x9F164C", VA = "0x9F164C")]
	public StartScreen()
	{
	}
}
[Token(Token = "0x2000151")]
public enum SubSideMenuType
{
	[Token(Token = "0x4000B09")]
	Nothing,
	[Token(Token = "0x4000B0A")]
	Default,
	[Token(Token = "0x4000B0B")]
	BuildNew,
	[Token(Token = "0x4000B0C")]
	Delete,
	[Token(Token = "0x4000B0D")]
	Upload,
	[Token(Token = "0x4000B0E")]
	Save,
	[Token(Token = "0x4000B0F")]
	Overwrite,
	[Token(Token = "0x4000B10")]
	Stats,
	[Token(Token = "0x4000B11")]
	DoesNotExist,
	[Token(Token = "0x4000B12")]
	EnterCode,
	[Token(Token = "0x4000B13")]
	Loading,
	[Token(Token = "0x4000B14")]
	Unfavorite,
	[Token(Token = "0x4000B15")]
	NeedProfile,
	[Token(Token = "0x4000B16")]
	NeedPigToUpload,
	[Token(Token = "0x4000B17")]
	NeedPlay,
	[Token(Token = "0x4000B18")]
	LoadLevels,
	[Token(Token = "0x4000B19")]
	NeedPigToPlay,
	[Token(Token = "0x4000B1A")]
	ConfirmUnshare,
	[Token(Token = "0x4000B1B")]
	NoLevels,
	[Token(Token = "0x4000B1C")]
	CannotSaveToSharedSlot,
	[Token(Token = "0x4000B1D")]
	LocalDefault,
	[Token(Token = "0x4000B1E")]
	NeedPigToFavoriteLocal
}
[Token(Token = "0x2000152")]
public class SubSideMenu : MonoBehaviour
{
	[Token(Token = "0x4000B1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SubSideMenuType type;

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x10E9460", Offset = "0x10E9460", VA = "0x10E9460")]
	public SubSideMenu()
	{
	}
}
[Token(Token = "0x2000153")]
public abstract class UiMenuBase<T1, T2> : MonoBehaviour where T1 : PalazzoButton where T2 : Enum
{
	[Token(Token = "0x4000B20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T1[] buttons;

	[Token(Token = "0x4000B21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ButtonSettings buttonSettings;

	[Token(Token = "0x6000575")]
	protected UiMenuBase()
	{
	}
}
[Token(Token = "0x2000154")]
public sealed class UiMenuHandlerBase<T1, T2> : IMenuHandler where T1 : PalazzoButton where T2 : Enum
{
	[Serializable]
	[Token(Token = "0x200024F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7674E4", Offset = "0x7674E4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000F00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000F01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<int> <>9__16_0;

		[Token(Token = "0x4000F02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<Vector3, Vector3, float, (bool, float)> <>9__24_0;

		[Token(Token = "0x6000A9D")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A9E")]
		internal void <.ctor>b__16_0(int i)
		{
		}

		[Token(Token = "0x6000A9F")]
		internal (bool, float) <UpdateTrajectory>b__24_0(Vector3 a, Vector3 b, float c)
		{
			return default((bool, float));
		}
	}

	[Token(Token = "0x4000B22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly Transform menuTransform;

	[Token(Token = "0x4000B23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly UiMenuBase<T1, T2> menu;

	[Token(Token = "0x4000B24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly ARTransforms arTransforms;

	[Token(Token = "0x4000B25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly InputHandler inputHandler;

	[Token(Token = "0x4000B26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly WorldContext worldContext;

	[Token(Token = "0x4000B27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly MenuSettings menuSettings;

	[Token(Token = "0x4000B28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly ButtonHandler<PalazzoButton> buttonHandler;

	[Token(Token = "0x4000B29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly TrajectoryHandler trajectoryHandler;

	[Token(Token = "0x4000B2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly AnimationComponent animationComponent;

	[Token(Token = "0x4000B2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly bool useAnimationRoot;

	[Token(Token = "0x4000B2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Vector3? startPosition;

	[Token(Token = "0x4000B2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float? startRotation;

	[Token(Token = "0x4000B2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int uiSpawnId;

	[Token(Token = "0x4000B2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool isShowing;

	[Token(Token = "0x4000B30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private float showTimer;

	[Token(Token = "0x4000B31")]
	private const float SHOW_DELAY = 0.5f;

	[Token(Token = "0x6000576")]
	public UiMenuHandlerBase(UiMenuBase<T1, T2> menu, IList<PalazzoButton> buttons, ARTransforms arTransforms, InputHandler inputHandler, WorldContext worldContext, MenuSettings menuSettings, TrajectoryHandler trajectoryHandler, PalazzoTriggers palazzoTriggers, Action<int> onButtonClicked, [Optional] Action<int> onButtonHovered, [Optional] NetworkHandler networkHandler, bool useAnimationRoot = true)
	{
	}

	[Token(Token = "0x6000577")]
	public void Spawn(bool positionGui = true, bool resetButtons = true)
	{
	}

	[Token(Token = "0x6000578")]
	public void Despawn()
	{
	}

	[Token(Token = "0x6000579")]
	public void Show()
	{
	}

	[Token(Token = "0x600057A")]
	public void Hide()
	{
	}

	[Token(Token = "0x600057B")]
	public void InstantHide()
	{
	}

	[Token(Token = "0x600057C")]
	private void PositionGui()
	{
	}

	[Token(Token = "0x600057D")]
	public void Tick()
	{
	}

	[Token(Token = "0x600057E")]
	public void UpdateTrajectory()
	{
	}
}
[Token(Token = "0x2000155")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x766B00", Offset = "0x766B00")]
public class UiPrefabs : ScriptableObject
{
	[Token(Token = "0x4000B32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public StartScreen startScreen;

	[Token(Token = "0x4000B33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public WorldSelectMenu worldSelectMenu;

	[Token(Token = "0x4000B34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public LevelSelect levelSelect;

	[Token(Token = "0x4000B35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public ScoreboardBase[] scoreboards;

	[Token(Token = "0x4000B36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public PauseScreen[] pauseScreens;

	[Token(Token = "0x4000B37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public LoseScreen[] loseScreens;

	[Token(Token = "0x4000B38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public RatingScreen ratingScreen;

	[Token(Token = "0x4000B39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public SplitMenu[] splitMenus;

	[Token(Token = "0x4000B3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public SettingsMenu settingsMenu;

	[Token(Token = "0x4000B3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	public PrivacyMenu privacyMenu;

	[Token(Token = "0x4000B3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	public GameObject noEntitlementScreen;

	[Token(Token = "0x4000B3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	public RecoveryMenu recoveryMenu;

	[Token(Token = "0x4000B3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	public ErrorMenu networkErrorMenu;

	[Token(Token = "0x4000B3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	public ErrorMenu favoriteErrorMenu;

	[Token(Token = "0x4000B40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	public TutorialComponent tutorialComponent;

	[Token(Token = "0x4000B41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	public LevelEditorComponent levelEditor;

	[Token(Token = "0x4000B42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	public CreateUserMenu createUserMenu;

	[Token(Token = "0x4000B43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	public ReportMenu reportMenu;

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x10F5C18", Offset = "0x10F5C18", VA = "0x10F5C18")]
	public UiPrefabs()
	{
	}
}
[Token(Token = "0x2000156")]
public enum WorldSelectButtonType
{
	[Token(Token = "0x4000B45")]
	Beach,
	[Token(Token = "0x4000B46")]
	Cliff,
	[Token(Token = "0x4000B47")]
	Snow,
	[Token(Token = "0x4000B48")]
	Peak,
	[Token(Token = "0x4000B49")]
	NightmareBeach,
	[Token(Token = "0x4000B4A")]
	NightmareCliff,
	[Token(Token = "0x4000B4B")]
	NightmareSnow,
	[Token(Token = "0x4000B4C")]
	NightmarePeak,
	[Token(Token = "0x4000B4D")]
	Settings,
	[Token(Token = "0x4000B4E")]
	ExitToModeSelect,
	[Token(Token = "0x4000B4F")]
	PrivacyPolicy,
	[Token(Token = "0x4000B50")]
	ModeNormal,
	[Token(Token = "0x4000B51")]
	ModeNightmare,
	[Token(Token = "0x4000B52")]
	MyFavorites,
	[Token(Token = "0x4000B53")]
	LevelEditor,
	[Token(Token = "0x4000B54")]
	BuildLevels,
	[Token(Token = "0x4000B55")]
	PlayerProfile,
	[Token(Token = "0x4000B56")]
	Search,
	[Token(Token = "0x4000B57")]
	Discovery,
	[Token(Token = "0x4000B58")]
	QuickPlay,
	[Token(Token = "0x4000B59")]
	ComingSoon
}
[Token(Token = "0x2000157")]
public class WorldSelectButton : PalazzoButton<WorldSelectButtonType>
{
	[Token(Token = "0x4000B5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool unlocked;

	[Token(Token = "0x4000B5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject worldLock;

	[Token(Token = "0x4000B5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Animator worldLockAnimator;

	[Token(Token = "0x4000B5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TextMeshPro starText;

	[Token(Token = "0x4000B5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public ParticleSystem unlockParticleSystem;

	[Token(Token = "0x4000B5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public ParticleSystem optionalSpookyUnlockedSystem;

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x10F8718", Offset = "0x10F8718", VA = "0x10F8718")]
	public WorldSelectButton()
	{
	}
}
[Token(Token = "0x2000158")]
public class WorldSelectMenu : MonoBehaviour
{
	[Token(Token = "0x4000B60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public WorldSelectSubMenu modeMenu;

	[Token(Token = "0x4000B61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public WorldSelectSubMenu worldMenus;

	[Token(Token = "0x4000B62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public WorldSelectWarningMenu warningMenu;

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x10F8768", Offset = "0x10F8768", VA = "0x10F8768")]
	public WorldSelectMenu()
	{
	}
}
[Token(Token = "0x2000159")]
public sealed class WorldSelectSubMenu : UiMenuBase<WorldSelectButton, WorldSelectButtonType>
{
	[Token(Token = "0x4000B63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] normalModeObjects;

	[Token(Token = "0x4000B64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] nightmareModeObjects;

	[Token(Token = "0x4000B65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] levelEditorModeObjects;

	[Token(Token = "0x4000B66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject[] localLevelEditorModeObjects;

	[Token(Token = "0x4000B67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject[] modeSelectionObjects;

	[Token(Token = "0x4000B68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject spookyButtonIcon;

	[Token(Token = "0x4000B69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject spookyButtonUnlockedHoverText;

	[Token(Token = "0x4000B6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject spookyButtonLockedHoverText;

	[Token(Token = "0x4000B6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshPro spookyButtonLockedHoverTextField;

	[Token(Token = "0x4000B6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject quickPlayIcon;

	[Token(Token = "0x4000B6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject quickPlaySpinningWheel;

	[Token(Token = "0x4000B6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject[] profileIcons;

	[Token(Token = "0x4000B6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject profileSpinningWheel;

	[Token(Token = "0x6000583")]
	[Address(RVA = "0x10F8770", Offset = "0x10F8770", VA = "0x10F8770")]
	public WorldSelectSubMenu()
	{
	}
}
[Token(Token = "0x200015A")]
public sealed class WorldSelectWarningMenu : UiMenuBase<WorldSelectButton, WorldSelectButtonType>
{
	[Token(Token = "0x4000B70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject levelsRemovedRoot;

	[Token(Token = "0x4000B71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject bannedRoot;

	[Token(Token = "0x4000B72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshPro levelCodesText;

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x10F87C0", Offset = "0x10F87C0", VA = "0x10F87C0")]
	public WorldSelectWarningMenu()
	{
	}
}
[Token(Token = "0x200015B")]
public class VRPostReprojection : MonoBehaviour
{
	[Token(Token = "0x4000B73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Camera mainCamera;

	[Token(Token = "0x4000B74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject loadingScreen;

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x10F63A8", Offset = "0x10F63A8", VA = "0x10F63A8")]
	public VRPostReprojection()
	{
	}
}
[Token(Token = "0x200015C")]
[DisallowMultipleComponent]
public sealed class WindComponent : MonoBehaviour
{
	[Token(Token = "0x4000B75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform blockTransform;

	[Token(Token = "0x4000B76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Rigidbody rb;

	[Token(Token = "0x4000B77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int maxWindPoints;

	[Token(Token = "0x4000B78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float windMultiplier;

	[Token(Token = "0x4000B79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int activeWindPoints;

	[Token(Token = "0x4000B7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3[] localWindPoints;

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x10F7810", Offset = "0x10F7810", VA = "0x10F7810")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x10F7AC4", Offset = "0x10F7AC4", VA = "0x10F7AC4")]
	public WindComponent()
	{
	}
}
[Token(Token = "0x200015D")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x766B20", Offset = "0x766B20")]
public sealed class WindVortexComponent : MonoBehaviour
{
	[NonSerialized]
	[Token(Token = "0x4000B7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public WindVortexImpactQueue windVortexImpactQueue;

	[Token(Token = "0x4000B7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Dictionary<int, PalazzoComponentLevelBlock> colliderBlockLookup;

	[Token(Token = "0x4000B7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private FanComponent fan;

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x10F7AD4", Offset = "0x10F7AD4", VA = "0x10F7AD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x10F7B2C", Offset = "0x10F7B2C", VA = "0x10F7B2C")]
	private void OnTriggerStay(Collider collider)
	{
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x10F7D68", Offset = "0x10F7D68", VA = "0x10F7D68")]
	public WindVortexComponent()
	{
	}
}
[Token(Token = "0x200015E")]
[DisallowMultipleComponent]
public sealed class WorldImpactComponent : MonoBehaviour
{
	[Token(Token = "0x4000B7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BlockType blockType;

	[Token(Token = "0x4000B7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleEffectComponent prefabImpactFx;

	[Token(Token = "0x4000B80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string soundImpact;

	[Token(Token = "0x4000B81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Collider[] cols;

	[NonSerialized]
	[Token(Token = "0x4000B82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public WorldImpactQueue worldImpactQueue;

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x10F81E4", Offset = "0x10F81E4", VA = "0x10F81E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x10F8264", Offset = "0x10F8264", VA = "0x10F8264")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x10F8478", Offset = "0x10F8478", VA = "0x10F8478")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x10F86A0", Offset = "0x10F86A0", VA = "0x10F86A0")]
	public WorldImpactComponent()
	{
	}
}
[Token(Token = "0x200015F")]
public enum WorldTrackerRenderMode
{
	[Token(Token = "0x4000B84")]
	Wireframe,
	[Token(Token = "0x4000B85")]
	Occlusion
}
[Token(Token = "0x2000160")]
public abstract class WorldTracker
{
	[Token(Token = "0x4000B86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected ARTransforms arTransforms;

	[Token(Token = "0x4000B87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected bool isLevelPlaced;

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x10F8810", Offset = "0x10F8810", VA = "0x10F8810", Slot = "4")]
	public virtual void SetRenderMode(WorldTrackerRenderMode mode)
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x10F8814", Offset = "0x10F8814", VA = "0x10F8814", Slot = "5")]
	public virtual void OnPlaceLevel()
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x10F8820", Offset = "0x10F8820", VA = "0x10F8820", Slot = "6")]
	public virtual void OnLevelUnplaced()
	{
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x10F8828", Offset = "0x10F8828", VA = "0x10F8828", Slot = "7")]
	public virtual void Tick()
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x10F882C", Offset = "0x10F882C", VA = "0x10F882C")]
	protected WorldTracker()
	{
	}
}
[Token(Token = "0x2000161")]
public class DestroyIfReleaseOrQuest : MonoBehaviour
{
	[Token(Token = "0x6000594")]
	[Address(RVA = "0x9AF2D4", Offset = "0x9AF2D4", VA = "0x9AF2D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x9AF350", Offset = "0x9AF350", VA = "0x9AF350")]
	public DestroyIfReleaseOrQuest()
	{
	}
}
[Token(Token = "0x2000162")]
public class PalazzoFollowPose : MonoBehaviour
{
	[Token(Token = "0x4000B88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool pause;

	[Token(Token = "0x4000B89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera theCamera;

	[Token(Token = "0x4000B8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private KeyCode increaseFov;

	[Token(Token = "0x4000B8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private KeyCode decreaseFov;

	[Token(Token = "0x4000B8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private KeyCode resetFov;

	[Token(Token = "0x4000B8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768A8C", Offset = "0x768A8C")]
	public Transform[] objectsToFollow;

	[Token(Token = "0x4000B8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private KeyCode switchTarget;

	[Token(Token = "0x4000B8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RotateAroundComponent[] rotatingObjects;

	[Token(Token = "0x4000B90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float rotatingObjectSpeed;

	[Token(Token = "0x4000B91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private KeyCode increaseRotationSpeed;

	[Token(Token = "0x4000B92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private KeyCode decreaseRotationSpeed;

	[Token(Token = "0x4000B93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private KeyCode resetRotationSpeed;

	[Token(Token = "0x4000B94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768B04", Offset = "0x768B04")]
	[SerializeField]
	private float movementSmoothTime;

	[Token(Token = "0x4000B95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private KeyCode increaseMovementSmoothing;

	[Token(Token = "0x4000B96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private KeyCode decreaseMovementSmoothing;

	[Token(Token = "0x4000B97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private KeyCode resetMovementSmoothing;

	[Token(Token = "0x4000B98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768B80", Offset = "0x768B80")]
	[SerializeField]
	private float rotationSmoothTime;

	[Token(Token = "0x4000B99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	private KeyCode increaseRotationSmoothing;

	[Token(Token = "0x4000B9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private KeyCode decreaseRotationSmoothing;

	[Token(Token = "0x4000B9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private KeyCode resetRotationSmoothing;

	[Token(Token = "0x4000B9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768BFC", Offset = "0x768BFC")]
	[SerializeField]
	private Vector3 globalPositionOffset;

	[Token(Token = "0x4000B9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768C48", Offset = "0x768C48")]
	[SerializeField]
	private Vector3 localPositionOffset;

	[Token(Token = "0x4000B9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768C94", Offset = "0x768C94")]
	[SerializeField]
	private Vector3 rotationOffset;

	[Token(Token = "0x4000B9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768CE0", Offset = "0x768CE0")]
	[SerializeField]
	private bool keepHorizontal;

	[Token(Token = "0x4000BA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private float tweekSpeed;

	[Token(Token = "0x4000BA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private new Transform transform;

	[Token(Token = "0x4000BA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Vector3 movementVelocity;

	[Token(Token = "0x4000BA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private Quaternion rotationVelocity;

	[Token(Token = "0x4000BA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public int currentTarget;

	[Token(Token = "0x4000BA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private bool active;

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x972A4C", Offset = "0x972A4C", VA = "0x972A4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x972A74", Offset = "0x972A74", VA = "0x972A74")]
	private void Update()
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x9739A8", Offset = "0x9739A8", VA = "0x9739A8")]
	private static Quaternion SmoothDamp(Quaternion rot, Quaternion target, ref Quaternion deriv, float time)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x973C44", Offset = "0x973C44", VA = "0x973C44")]
	public PalazzoFollowPose()
	{
	}
}
[Token(Token = "0x2000163")]
public class RotateAroundComponent : MonoBehaviour
{
	[Token(Token = "0x4000BA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000BA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool active;

	[NonSerialized]
	[Token(Token = "0x4000BA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool prevState;

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x9DD30C", Offset = "0x9DD30C", VA = "0x9DD30C")]
	public RotateAroundComponent()
	{
	}
}
[Token(Token = "0x2000164")]
public class TextGroup : MonoBehaviour
{
	[Token(Token = "0x4000BA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_Text[] texts;

	[Token(Token = "0x4000BAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool hasReformated;

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x10ED8C4", Offset = "0x10ED8C4", VA = "0x10ED8C4")]
	public void Update()
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x10EDD04", Offset = "0x10EDD04", VA = "0x10EDD04")]
	public TextGroup()
	{
	}
}
[Token(Token = "0x2000165")]
public abstract class RGVersion
{
	[Token(Token = "0x4000BAB")]
	public const string VERSION = "3.5.100058";

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x9DC4B0", Offset = "0x9DC4B0", VA = "0x9DC4B0")]
	protected RGVersion()
	{
	}
}
namespace RGCommon
{
	[Token(Token = "0x2000166")]
	public static class SynthesizedAudio
	{
		[Token(Token = "0x2000250")]
		private abstract class Generator
		{
			[Token(Token = "0x4000F03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly float frequency;

			[Token(Token = "0x4000F04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public readonly float amplitude;

			[Token(Token = "0x4000F05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			protected int position;

			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x9D8EEC", Offset = "0x9D8EEC", VA = "0x9D8EEC")]
			public Generator(float frequency, float amplitude)
			{
			}

			[Token(Token = "0x6000AA1")]
			public abstract void OnAudioRead(float[] data);

			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x9D8F24", Offset = "0x9D8F24", VA = "0x9D8F24")]
			public void OnAudioSetPosition(int newPosition)
			{
			}
		}

		[Token(Token = "0x2000251")]
		private class SineGenerator : Generator
		{
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x9D8EB4", Offset = "0x9D8EB4", VA = "0x9D8EB4")]
			public SineGenerator(float frequency, float amplitude)
			{
			}

			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x9D8F2C", Offset = "0x9D8F2C", VA = "0x9D8F2C", Slot = "4")]
			public override void OnAudioRead(float[] data)
			{
			}
		}

		[Token(Token = "0x4000BAC")]
		private const int sampleRate = 44100;

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x9D8D6C", Offset = "0x9D8D6C", VA = "0x9D8D6C")]
		public static AudioClip GenerateSineBeep(float frequency, float amplitude, float lengthInSeconds)
		{
			return null;
		}
	}
	[Token(Token = "0x2000167")]
	public class VersionDisplay : MonoBehaviour
	{
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x9DBAF8", Offset = "0x9DBAF8", VA = "0x9DBAF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x9DBCB8", Offset = "0x9DBCB8", VA = "0x9DBCB8")]
		public VersionDisplay()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public static class VersionInformation
	{
		[Token(Token = "0x17000025")]
		public static string Version
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x9D9644", Offset = "0x9D9644", VA = "0x9D9644")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000169")]
	public static class BestMatch
	{
		[Token(Token = "0x60005A2")]
		public static void UpdateIfGreater<T>(ref T currentBest, ref float bestValue, T candidate, float candidateValue)
		{
		}

		[Token(Token = "0x60005A3")]
		public static void UpdateIfLess<T>(ref T currentBest, ref float bestValue, T candidate, float candidateValue)
		{
		}
	}
	[Token(Token = "0x200016A")]
	public static class Collections
	{
		[Token(Token = "0x60005A4")]
		public static void Shuffle<T>(T[] values)
		{
		}

		[Token(Token = "0x60005A5")]
		public static void Shuffle<T>(List<T> values)
		{
		}
	}
	[Token(Token = "0x200016B")]
	public class CSVTable
	{
		[Token(Token = "0x2000252")]
		public struct Row
		{
			[Token(Token = "0x4000F06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int index;

			[Token(Token = "0x4000F07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Dictionary<string, int> headerIndexes;

			[Token(Token = "0x4000F08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string[] columns;

			[Token(Token = "0x17000118")]
			public int Count
			{
				[Token(Token = "0x6000AB2")]
				[Address(RVA = "0x7D8774", Offset = "0x7D8774", VA = "0x7D8774")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x7D86B8", Offset = "0x7D86B8", VA = "0x7D86B8")]
			internal Row(int index, Dictionary<string, int> headerIndexes, string[] columns)
			{
			}

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x7D86C4", Offset = "0x7D86C4", VA = "0x7D86C4")]
			private void ValidateHeader(string header)
			{
			}

			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x7D86CC", Offset = "0x7D86CC", VA = "0x7D86CC")]
			private void ValidateIndex(int i)
			{
			}

			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x7D86D4", Offset = "0x7D86D4", VA = "0x7D86D4")]
			public bool HasValue(int i)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x7D86DC", Offset = "0x7D86DC", VA = "0x7D86DC")]
			public bool NotEmpty(string header)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x7D86E4", Offset = "0x7D86E4", VA = "0x7D86E4")]
			public string GetColumn(int i)
			{
				return null;
			}

			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x7D86EC", Offset = "0x7D86EC", VA = "0x7D86EC")]
			public string GetColumn(string header)
			{
				return null;
			}

			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x7D86F4", Offset = "0x7D86F4", VA = "0x7D86F4")]
			public int GetColumnInt(string header)
			{
				return default(int);
			}

			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x7D8710", Offset = "0x7D8710", VA = "0x7D8710")]
			public int GetColumnInt(int i)
			{
				return default(int);
			}

			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x7D872C", Offset = "0x7D872C", VA = "0x7D872C")]
			public float GetColumnFloat(string header)
			{
				return default(float);
			}

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x7D8748", Offset = "0x7D8748", VA = "0x7D8748")]
			public float GetColumnFloat(int i)
			{
				return default(float);
			}

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x7D8764", Offset = "0x7D8764", VA = "0x7D8764")]
			public bool GetColumnBool(string header)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x7D876C", Offset = "0x7D876C", VA = "0x7D876C")]
			public bool GetColumnBool(int i)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x7D87A0", Offset = "0x7D87A0", VA = "0x7D87A0")]
			public int Index()
			{
				return default(int);
			}

			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x7D87A8", Offset = "0x7D87A8", VA = "0x7D87A8", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x4000BAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string path;

		[Token(Token = "0x4000BAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isLoaded;

		[Token(Token = "0x4000BAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Row[] rows;

		[Token(Token = "0x4000BB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string[] headers;

		[Token(Token = "0x4000BB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, int> headerIndexes;

		[Token(Token = "0x17000026")]
		public int NumRows
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x9CC0F4", Offset = "0x9CC0F4", VA = "0x9CC0F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000027")]
		public int NumColumns
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x9CC124", Offset = "0x9CC124", VA = "0x9CC124")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x9CB5D4", Offset = "0x9CB5D4", VA = "0x9CB5D4")]
		public void LoadFromResources(string path)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x9CBEF4", Offset = "0x9CBEF4", VA = "0x9CBEF4")]
		public string GetHeader(int i)
		{
			return null;
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x9CC014", Offset = "0x9CC014", VA = "0x9CC014")]
		public int GetHeaderIndex(string name)
		{
			return default(int);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x9CC084", Offset = "0x9CC084", VA = "0x9CC084")]
		public bool HasHeader(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x9CC150", Offset = "0x9CC150", VA = "0x9CC150")]
		public Row GetRow(int i)
		{
			return default(Row);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x9CC28C", Offset = "0x9CC28C", VA = "0x9CC28C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x9CC498", Offset = "0x9CC498", VA = "0x9CC498")]
		public CSVTable()
		{
		}
	}
	[Token(Token = "0x200016C")]
	public class PerFrameCounter : MonoBehaviour
	{
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x9D87A0", Offset = "0x9D87A0", VA = "0x9D87A0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x76AB34", Offset = "0x76AB34")]
		public static void Add(string name, int amount = 1)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x9D87A4", Offset = "0x9D87A4", VA = "0x9D87A4")]
		public PerFrameCounter()
		{
		}
	}
	[Token(Token = "0x200016D")]
	public class SpeedControl : MonoBehaviour
	{
		[Token(Token = "0x4000BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool enableOnDevice;

		[Token(Token = "0x4000BB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public KeyCode activationKey;

		[Token(Token = "0x4000BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedFactorWhenActivated;

		[Token(Token = "0x4000BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool activated;

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x9D8CF0", Offset = "0x9D8CF0", VA = "0x9D8CF0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x9D8CFC", Offset = "0x9D8CFC", VA = "0x9D8CFC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x9D8D54", Offset = "0x9D8D54", VA = "0x9D8D54")]
		public SpeedControl()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class ToggleActive : MonoBehaviour
	{
		[Token(Token = "0x4000BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] objects;

		[Token(Token = "0x4000BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public KeyCode key;

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x9D9144", Offset = "0x9D9144", VA = "0x9D9144")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x9D9210", Offset = "0x9D9210", VA = "0x9D9210")]
		public ToggleActive()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public class CaptureCamera : MonoBehaviour
	{
		[Token(Token = "0x2000253")]
		public enum FileFormat
		{
			[Token(Token = "0x4000F0A")]
			PNG,
			[Token(Token = "0x4000F0B")]
			PNGWithAlpha,
			[Token(Token = "0x4000F0C")]
			JPG,
			[Token(Token = "0x4000F0D")]
			EXR
		}

		[Token(Token = "0x4000BB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768D3C", Offset = "0x768D3C")]
		public string inputName;

		[Token(Token = "0x4000BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2Int resolution;

		[Token(Token = "0x4000BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FileFormat fileFormat;

		[Token(Token = "0x4000BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string[] extensions;

		[Token(Token = "0x4000BBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768D74", Offset = "0x768D74")]
		public Camera cameraToCapture;

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x9CCDE0", Offset = "0x9CCDE0", VA = "0x9CCDE0")]
		public void Update()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x9CCFB8", Offset = "0x9CCFB8", VA = "0x9CCFB8")]
		private void Capture(Camera cam)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x9CD478", Offset = "0x9CD478", VA = "0x9CD478")]
		private TextureFormat GetTargetTextureFormat()
		{
			return default(TextureFormat);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x9CD49C", Offset = "0x9CD49C", VA = "0x9CD49C")]
		public CaptureCamera()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public class EditorCameraControl : MonoBehaviour
	{
		[Token(Token = "0x4000BBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float mouseSpeed;

		[Token(Token = "0x4000BBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxKeyboardRotation;

		[Token(Token = "0x4000BBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public KeyCode freezeKey;

		[Token(Token = "0x4000BC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float touchRotationSpeed;

		[Token(Token = "0x4000BC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float keyboardRotationSpeed;

		[Token(Token = "0x4000BC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public KeyCode turnLeftKey;

		[Token(Token = "0x4000BC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public KeyCode turnRightKey;

		[Token(Token = "0x4000BC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public KeyCode lookUpKey;

		[Token(Token = "0x4000BC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public KeyCode lookDownKey;

		[Token(Token = "0x4000BC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public KeyCode recenterKey;

		[Token(Token = "0x4000BC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool startMouseEnabled;

		[Token(Token = "0x4000BC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768DAC", Offset = "0x768DAC")]
		public Transform vrHead;

		[Token(Token = "0x4000BC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion startRotation;

		[Token(Token = "0x4000BCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 currentRotation;

		[Token(Token = "0x4000BCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3? currentPosition;

		[Token(Token = "0x4000BCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool mouseEnabled;

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x9CD9C0", Offset = "0x9CD9C0", VA = "0x9CD9C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x9CDA28", Offset = "0x9CDA28", VA = "0x9CDA28")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x9CDA84", Offset = "0x9CDA84", VA = "0x9CDA84")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x9CDAE4", Offset = "0x9CDAE4", VA = "0x9CDAE4")]
		public void SetPosition(Vector3 localPosition)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x9CDBD0", Offset = "0x9CDBD0", VA = "0x9CDBD0")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x9CE148", Offset = "0x9CE148", VA = "0x9CE148")]
		public EditorCameraControl()
		{
		}
	}
	[Token(Token = "0x2000171")]
	public class Fader : MonoBehaviour
	{
		[Token(Token = "0x4000BCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float targetAlpha;

		[Token(Token = "0x4000BCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fadeTime;

		[Token(Token = "0x4000BCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader fadeShader;

		[Token(Token = "0x4000BD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color color;

		[Token(Token = "0x4000BD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected float currentAlpha;

		[Token(Token = "0x4000BD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fadeMaterial;

		[Token(Token = "0x17000028")]
		public bool Done
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x9CE8E4", Offset = "0x9CE8E4", VA = "0x9CE8E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x9CE8D0", Offset = "0x9CE8D0", VA = "0x9CE8D0")]
		public void FadeIn()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x9CE8D8", Offset = "0x9CE8D8", VA = "0x9CE8D8")]
		public void FadeOut()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x9CE8F8", Offset = "0x9CE8F8", VA = "0x9CE8F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x9CEAF4", Offset = "0x9CEAF4", VA = "0x9CEAF4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x9CEB00", Offset = "0x9CEB00", VA = "0x9CEB00")]
		private void Reset()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x9CE9AC", Offset = "0x9CE9AC", VA = "0x9CE9AC")]
		private void Setup()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x9CEB04", Offset = "0x9CEB04", VA = "0x9CEB04")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x9CEBF4", Offset = "0x9CEBF4", VA = "0x9CEBF4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x9CEC70", Offset = "0x9CEC70", VA = "0x9CEC70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x9CECEC", Offset = "0x9CECEC", VA = "0x9CECEC")]
		private void SceneWasLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x9CECF4", Offset = "0x9CECF4", VA = "0x9CECF4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x9CEDA8", Offset = "0x9CEDA8", VA = "0x9CEDA8")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x9CEEAC", Offset = "0x9CEEAC", VA = "0x9CEEAC")]
		public Fader()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class FpsDisplay : MonoBehaviour
	{
		[Token(Token = "0x4000BD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float updateInterval;

		[Token(Token = "0x4000BD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public KeyCode toggleKey;

		[Token(Token = "0x4000BD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool visible;

		[Token(Token = "0x4000BD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float warningTime;

		[Token(Token = "0x4000BD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color standardColor;

		[Token(Token = "0x4000BD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color warningColor;

		[Token(Token = "0x4000BD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMesh textMesh;

		[Token(Token = "0x4000BDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Renderer rendererComponent;

		[Token(Token = "0x4000BDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int frameCount;

		[Token(Token = "0x4000BDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int warningCount;

		[Token(Token = "0x4000BDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float elapsed;

		[Token(Token = "0x4000BDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float fps;

		[Token(Token = "0x4000BDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float msPerFrame;

		[Token(Token = "0x4000BE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float maxTime;

		[Token(Token = "0x4000BE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float minTime;

		[Token(Token = "0x4000BE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string text;

		[Token(Token = "0x4000BE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float lastUpdate;

		[Token(Token = "0x4000BE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float collectionStartTime;

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x9CFA70", Offset = "0x9CFA70", VA = "0x9CFA70")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x9CFAE0", Offset = "0x9CFAE0", VA = "0x9CFAE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x9CFB90", Offset = "0x9CFB90", VA = "0x9CFB90")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x9CFD6C", Offset = "0x9CFD6C", VA = "0x9CFD6C")]
		public void ToggleVisibility()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x9CFDDC", Offset = "0x9CFDDC", VA = "0x9CFDDC")]
		private void UpdateDisplay()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x9D009C", Offset = "0x9D009C", VA = "0x9D009C")]
		public FpsDisplay()
		{
		}
	}
	[Token(Token = "0x2000173")]
	public class Screenshot : MonoBehaviour
	{
		[Token(Token = "0x4000BE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode screenshotKey;

		[Token(Token = "0x4000BE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int superSize;

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x9D87AC", Offset = "0x9D87AC", VA = "0x9D87AC")]
		public void Start()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x9D8814", Offset = "0x9D8814", VA = "0x9D8814")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x9D88EC", Offset = "0x9D88EC", VA = "0x9D88EC")]
		public static string ScreenShotName()
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x9D8850", Offset = "0x9D8850", VA = "0x9D8850")]
		public void TakeScreenshot()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x9D898C", Offset = "0x9D898C", VA = "0x9D898C")]
		public Screenshot()
		{
		}
	}
	[Token(Token = "0x2000174")]
	public static class Find
	{
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x9CEEE8", Offset = "0x9CEEE8", VA = "0x9CEEE8")]
		public static GameObject ChildByName(Component tag, string path)
		{
			return null;
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x9CF06C", Offset = "0x9CF06C", VA = "0x9CF06C")]
		public static GameObject ChildByName(object tag, GameObject go, string path)
		{
			return null;
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x9CF0D4", Offset = "0x9CF0D4", VA = "0x9CF0D4")]
		public static Transform ChildTransformByName(Component tag, string path)
		{
			return null;
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x9CF114", Offset = "0x9CF114", VA = "0x9CF114")]
		public static Transform ChildTransformByName(object tag, Transform go, string path)
		{
			return null;
		}

		[Token(Token = "0x60005DE")]
		public static T ComponentOnGameObject<T>(Component tag) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60005DF")]
		public static T ComponentOnGameObject<T>(GameObject tag) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60005E0")]
		public static T ComponentOnGameObject<T>(object tag, GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60005E1")]
		public static T ComponentOrCreate<T>(GameObject gameObject) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60005E2")]
		public static T ComponentOnChild<T>(Component tag, string path) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60005E3")]
		public static T ComponentOnChild<T>(object tag, GameObject go, string path) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60005E4")]
		public static T ComponentInChildren<T>(Component tag) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		public static T ComponentInChildren<T>(object tag, GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60005E6")]
		public static T ComponentOrNull<T>(GameObject container) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x9CEF40", Offset = "0x9CEF40", VA = "0x9CEF40")]
		private static Transform InternalFindChildByName(object tag, Transform transform, string path)
		{
			return null;
		}

		[Token(Token = "0x60005E8")]
		private static T InternalFindComponentOnGameObject<T>(object tag, GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60005E9")]
		private static T InternalFindComponentOnChild<T>(object tag, GameObject go, string path) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		private static T InternalFindComponentInChildren<T>(object tag, GameObject go)
		{
			return (T)null;
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x9CF118", Offset = "0x9CF118", VA = "0x9CF118")]
		private static string FormatError(string template, object tag, GameObject go, string path, Type t, string reason)
		{
			return null;
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x9CF160", Offset = "0x9CF160", VA = "0x9CF160")]
		private static string FormatTag(object theTag)
		{
			return null;
		}
	}
	[Token(Token = "0x2000175")]
	public static class ComponentValidation
	{
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x9CD6DC", Offset = "0x9CD6DC", VA = "0x9CD6DC")]
		public static bool DisableIfNull(MonoBehaviour component, UnityEngine.Object attributeValue, string attributeName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x9CD86C", Offset = "0x9CD86C", VA = "0x9CD86C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x76AB6C", Offset = "0x76AB6C")]
		public static void FailIfNull(MonoBehaviour component, UnityEngine.Object attributeValue, string attributeName)
		{
		}
	}
	[Token(Token = "0x2000176")]
	public class DontDestroyOnLoad : MonoBehaviour
	{
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x9CD870", Offset = "0x9CD870", VA = "0x9CD870")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x9CD8EC", Offset = "0x9CD8EC", VA = "0x9CD8EC")]
		public DontDestroyOnLoad()
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class Loader : MonoBehaviour
	{
		[Token(Token = "0x2000254")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7674F4", Offset = "0x7674F4")]
		private sealed class <Start>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			[Token(Token = "0x4000F11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Fader[] <faders>5__2;

			[Token(Token = "0x4000F12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startTime>5__3;

			[Token(Token = "0x4000F13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private AsyncOperation <async>5__4;

			[Token(Token = "0x17000119")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AB8")]
				[Address(RVA = "0x9D3844", Offset = "0x9D3844", VA = "0x9D3844", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000ABA")]
				[Address(RVA = "0x9D38B4", Offset = "0x9D38B4", VA = "0x9D38B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x9D33B8", Offset = "0x9D33B8", VA = "0x9D33B8")]
			[DebuggerHidden]
			public <Start>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x9D33EC", Offset = "0x9D33EC", VA = "0x9D33EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x9D33F0", Offset = "0x9D33F0", VA = "0x9D33F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x9D384C", Offset = "0x9D384C", VA = "0x9D384C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000BE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string scene;

		[Token(Token = "0x4000BE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minimumTime;

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x9D3344", Offset = "0x9D3344", VA = "0x9D3344")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76ABA4", Offset = "0x76ABA4")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x9D33E4", Offset = "0x9D33E4", VA = "0x9D33E4")]
		public Loader()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class SingleInstanceBehavior<T> : MonoBehaviour where T : SingleInstanceBehavior<T>
	{
		[Token(Token = "0x4000BE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T instance;

		[Token(Token = "0x4000BEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string noInstanceMessage;

		[Token(Token = "0x17000029")]
		public static T Instance
		{
			[Token(Token = "0x60005F6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F3")]
		static SingleInstanceBehavior()
		{
		}

		[Token(Token = "0x60005F4")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x60005F5")]
		public virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005F7")]
		public static T GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60005F8")]
		public SingleInstanceBehavior()
		{
		}
	}
	[Token(Token = "0x2000179")]
	public class Singleton<T> where T : Singleton<T>, new()
	{
		[Token(Token = "0x4000BEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T instance;

		[Token(Token = "0x1700002A")]
		public static T Instance
		{
			[Token(Token = "0x60005FA")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F9")]
		public Singleton()
		{
		}

		[Token(Token = "0x60005FB")]
		public static T GetInstance()
		{
			return null;
		}
	}
	[Token(Token = "0x200017A")]
	public class SingletonBehavior<T> : MonoBehaviour where T : SingletonBehavior<T>
	{
		[Token(Token = "0x4000BEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T instance;

		[Token(Token = "0x1700002B")]
		public static T Instance
		{
			[Token(Token = "0x60005FE")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005FC")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x60005FD")]
		public virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005FF")]
		public static T GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000600")]
		public SingletonBehavior()
		{
		}
	}
	[Token(Token = "0x200017B")]
	public class Locale : Singleton<Locale>
	{
		[Token(Token = "0x4000BED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string language;

		[Token(Token = "0x4000BEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string country;

		[Token(Token = "0x4000BEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string explicitlySetLocale;

		[Token(Token = "0x4000BF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string currentLocale;

		[Token(Token = "0x4000BF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string[] availableLocales;

		[Token(Token = "0x4000BF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string[] stringIDs;

		[Token(Token = "0x4000BF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> strings;

		[Token(Token = "0x4000BF4")]
		private const string resourceFolder = "Text";

		[Token(Token = "0x4000BF5")]
		private const string binaryResourceSuffix = "_Strings";

		[Token(Token = "0x4000BF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, string> countrySpecificLocales;

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x9D38BC", Offset = "0x9D38BC", VA = "0x9D38BC")]
		public Locale()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x9D40E0", Offset = "0x9D40E0", VA = "0x9D40E0")]
		public string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x9D4180", Offset = "0x9D4180", VA = "0x9D4180")]
		public bool TryGetString(string key, out string localized)
		{
			return default(bool);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x9D4220", Offset = "0x9D4220", VA = "0x9D4220")]
		public string Format(string key, params object[] templateArguments)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x9D448C", Offset = "0x9D448C", VA = "0x9D448C")]
		public bool TryFormat(string key, out string localized, params object[] templateArguments)
		{
			return default(bool);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x9D4720", Offset = "0x9D4720", VA = "0x9D4720")]
		public string GetDefaultLanguageOrLocale()
		{
			return null;
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x9D4738", Offset = "0x9D4738", VA = "0x9D4738")]
		public string GetDefaultCountry()
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x9D4740", Offset = "0x9D4740", VA = "0x9D4740")]
		public string GetCurrentLocale()
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x9D4748", Offset = "0x9D4748", VA = "0x9D4748")]
		public void SetLocale(string localeCode)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x9D4750", Offset = "0x9D4750", VA = "0x9D4750")]
		public string[] GetAvailableLocales()
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x9D3D4C", Offset = "0x9D3D4C", VA = "0x9D3D4C")]
		public string GetLocale(string[] availableLocales)
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x9D478C", Offset = "0x9D478C", VA = "0x9D478C")]
		public string[] GetStringIDs()
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x9D47E8", Offset = "0x9D47E8", VA = "0x9D47E8")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x9D3934", Offset = "0x9D3934", VA = "0x9D3934")]
		private void LoadAvailableLocales()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x9D3FD8", Offset = "0x9D3FD8", VA = "0x9D3FD8")]
		private void LoadStrings()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x9D480C", Offset = "0x9D480C", VA = "0x9D480C")]
		private bool TryLoadStrings()
		{
			return default(bool);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x9D4994", Offset = "0x9D4994", VA = "0x9D4994")]
		private bool TryLoadStringsFromBinaryAssets()
		{
			return default(bool);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x9D3B20", Offset = "0x9D3B20", VA = "0x9D3B20")]
		private void SetDefaultLanguageAndCountry()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x9D4BC0", Offset = "0x9D4BC0", VA = "0x9D4BC0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x76AC08", Offset = "0x76AC08")]
		public string GetLanguage()
		{
			return null;
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x9D4BC8", Offset = "0x9D4BC8", VA = "0x9D4BC8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x76AC40", Offset = "0x76AC40")]
		public void SetLanguage(string languageCode)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x9D4BD0", Offset = "0x9D4BD0", VA = "0x9D4BD0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x76AC78", Offset = "0x76AC78")]
		public string[] GetAvailableLanguages()
		{
			return null;
		}
	}
	[Token(Token = "0x200017C")]
	public class LocaleFonts : SingleInstanceBehavior<LocaleFonts>
	{
		[Serializable]
		[Token(Token = "0x2000255")]
		public class Settings
		{
			[Token(Token = "0x4000F14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x769F0C", Offset = "0x769F0C")]
			public string locale;

			[Token(Token = "0x4000F15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x769F44", Offset = "0x769F44")]
			public Font font;

			[Token(Token = "0x4000F16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x769F7C", Offset = "0x769F7C")]
			public TMP_FontAsset fontTMPro;

			[Token(Token = "0x4000F17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x769FB4", Offset = "0x769FB4")]
			public Material materialTMProGUI;

			[Token(Token = "0x4000F18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x769FEC", Offset = "0x769FEC")]
			public float scale;

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x9D637C", Offset = "0x9D637C", VA = "0x9D637C")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x4000BF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768DE4", Offset = "0x768DE4")]
		private Settings[] localeSettings;

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x9D61D0", Offset = "0x9D61D0", VA = "0x9D61D0")]
		public Settings GetCurrentLocaleSettings()
		{
			return null;
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x9D630C", Offset = "0x9D630C", VA = "0x9D630C")]
		public LocaleFonts()
		{
		}
	}
	[Token(Token = "0x200017D")]
	[DisallowMultipleComponent]
	public class LocalizedText : MonoBehaviour
	{
		[Token(Token = "0x2000256")]
		private struct FontProxy
		{
			[Token(Token = "0x4000F19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Font font;

			[Token(Token = "0x4000F1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public TMP_FontAsset fontTMPro;

			[Token(Token = "0x4000F1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material materialTMProGUI;
		}

		[Token(Token = "0x2000257")]
		private interface ITextComponent
		{
			[Token(Token = "0x1700011B")]
			string Text
			{
				[Token(Token = "0x6000ABC")]
				get;
				[Token(Token = "0x6000ABD")]
				set;
			}

			[Token(Token = "0x1700011C")]
			FontProxy Font
			{
				[Token(Token = "0x6000ABE")]
				get;
				[Token(Token = "0x6000ABF")]
				set;
			}

			[Token(Token = "0x1700011D")]
			int FontSize
			{
				[Token(Token = "0x6000AC0")]
				get;
				[Token(Token = "0x6000AC1")]
				set;
			}
		}

		[Token(Token = "0x2000258")]
		private sealed class TextComponent : ITextComponent
		{
			[Token(Token = "0x4000F1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Text textComponent;

			[Token(Token = "0x1700011E")]
			public string Text
			{
				[Token(Token = "0x6000AC3")]
				[Address(RVA = "0x9D748C", Offset = "0x9D748C", VA = "0x9D748C", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000AC4")]
				[Address(RVA = "0x9D74C4", Offset = "0x9D74C4", VA = "0x9D74C4", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x1700011F")]
			public FontProxy Font
			{
				[Token(Token = "0x6000AC5")]
				[Address(RVA = "0x9D7504", Offset = "0x9D7504", VA = "0x9D7504", Slot = "6")]
				get
				{
					return default(FontProxy);
				}
				[Token(Token = "0x6000AC6")]
				[Address(RVA = "0x9D7554", Offset = "0x9D7554", VA = "0x9D7554", Slot = "7")]
				set
				{
				}
			}

			[Token(Token = "0x17000120")]
			public int FontSize
			{
				[Token(Token = "0x6000AC7")]
				[Address(RVA = "0x9D758C", Offset = "0x9D758C", VA = "0x9D758C", Slot = "8")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000AC8")]
				[Address(RVA = "0x9D75BC", Offset = "0x9D75BC", VA = "0x9D75BC", Slot = "9")]
				set
				{
				}
			}

			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x9D7390", Offset = "0x9D7390", VA = "0x9D7390")]
			public TextComponent(Text text)
			{
			}
		}

		[Token(Token = "0x2000259")]
		private sealed class TextMeshComponent : ITextComponent
		{
			[Token(Token = "0x4000F1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly TextMesh textComponent;

			[Token(Token = "0x17000121")]
			public string Text
			{
				[Token(Token = "0x6000ACA")]
				[Address(RVA = "0x9D7854", Offset = "0x9D7854", VA = "0x9D7854", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000ACB")]
				[Address(RVA = "0x9D7884", Offset = "0x9D7884", VA = "0x9D7884", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x17000122")]
			public FontProxy Font
			{
				[Token(Token = "0x6000ACC")]
				[Address(RVA = "0x9D78BC", Offset = "0x9D78BC", VA = "0x9D78BC", Slot = "6")]
				get
				{
					return default(FontProxy);
				}
				[Token(Token = "0x6000ACD")]
				[Address(RVA = "0x9D790C", Offset = "0x9D790C", VA = "0x9D790C", Slot = "7")]
				set
				{
				}
			}

			[Token(Token = "0x17000123")]
			public int FontSize
			{
				[Token(Token = "0x6000ACE")]
				[Address(RVA = "0x9D7944", Offset = "0x9D7944", VA = "0x9D7944", Slot = "8")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000ACF")]
				[Address(RVA = "0x9D7974", Offset = "0x9D7974", VA = "0x9D7974", Slot = "9")]
				set
				{
				}
			}

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x9D73BC", Offset = "0x9D73BC", VA = "0x9D73BC")]
			public TextMeshComponent(TextMesh text)
			{
			}
		}

		[Token(Token = "0x200025A")]
		private sealed class TextComponentTMPro : ITextComponent
		{
			[Token(Token = "0x4000F1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly TMP_Text textComponent;

			[Token(Token = "0x17000124")]
			public string Text
			{
				[Token(Token = "0x6000AD1")]
				[Address(RVA = "0x9D75F4", Offset = "0x9D75F4", VA = "0x9D75F4", Slot = "4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000AD2")]
				[Address(RVA = "0x9D7624", Offset = "0x9D7624", VA = "0x9D7624", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x17000125")]
			public FontProxy Font
			{
				[Token(Token = "0x6000AD3")]
				[Address(RVA = "0x9D765C", Offset = "0x9D765C", VA = "0x9D765C", Slot = "6")]
				get
				{
					return default(FontProxy);
				}
				[Token(Token = "0x6000AD4")]
				[Address(RVA = "0x9D769C", Offset = "0x9D769C", VA = "0x9D769C", Slot = "7")]
				set
				{
				}
			}

			[Token(Token = "0x17000126")]
			public int FontSize
			{
				[Token(Token = "0x6000AD5")]
				[Address(RVA = "0x9D77E4", Offset = "0x9D77E4", VA = "0x9D77E4", Slot = "8")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000AD6")]
				[Address(RVA = "0x9D781C", Offset = "0x9D781C", VA = "0x9D781C", Slot = "9")]
				set
				{
				}
			}

			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x9D73E8", Offset = "0x9D73E8", VA = "0x9D73E8")]
			public TextComponentTMPro(TMP_Text text)
			{
			}
		}

		[Token(Token = "0x4000BF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string stringID;

		[Token(Token = "0x4000BF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ITextComponent textComponent;

		[Token(Token = "0x4000BFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string[] templateArguments;

		[Token(Token = "0x4000BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int?[] templateArgumentsInts;

		[Token(Token = "0x4000BFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool fontOverridden;

		[Token(Token = "0x4000BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FontProxy? originalFont;

		[Token(Token = "0x4000BFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int originalFontSize;

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x9D638C", Offset = "0x9D638C", VA = "0x9D638C")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x9D6F40", Offset = "0x9D6F40", VA = "0x9D6F40")]
		private void Start()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x9D6F6C", Offset = "0x9D6F6C", VA = "0x9D6F6C")]
		public void ShowString(string stringID)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x9D6F74", Offset = "0x9D6F74", VA = "0x9D6F74")]
		public void SetTemplateArgument(int index, string value)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x9D70E8", Offset = "0x9D70E8", VA = "0x9D70E8")]
		public void SetTemplateArgument(int index, int value)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x9D72B4", Offset = "0x9D72B4", VA = "0x9D72B4")]
		public void ShowRawText(string text)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x9D6708", Offset = "0x9D6708", VA = "0x9D6708")]
		public void UpdateText()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x9D6A08", Offset = "0x9D6A08", VA = "0x9D6A08")]
		public void UpdateFont()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x9D63B8", Offset = "0x9D63B8", VA = "0x9D63B8")]
		private void FindComponents()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x9D7414", Offset = "0x9D7414", VA = "0x9D7414")]
		public LocalizedText()
		{
		}
	}
	[Token(Token = "0x200017E")]
	public struct SeparatedStringReader
	{
		[Token(Token = "0x4000BFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte[] bytes;

		[Token(Token = "0x4000C00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int index;

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x7D87FC", Offset = "0x7D87FC", VA = "0x7D87FC")]
		public SeparatedStringReader(byte[] bytes, int startingIndex = 0)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x7D8808", Offset = "0x7D8808", VA = "0x7D8808")]
		public bool HasNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x7D8840", Offset = "0x7D8840", VA = "0x7D8840")]
		public string GetNext()
		{
			return null;
		}
	}
	[Token(Token = "0x200017F")]
	public class TextTemplateDemo : MonoBehaviour
	{
		[Token(Token = "0x4000C01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool useIntegerArgument;

		[Token(Token = "0x4000C02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int number;

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x9D9048", Offset = "0x9D9048", VA = "0x9D9048")]
		private void Update()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x9D9134", Offset = "0x9D9134", VA = "0x9D9134")]
		public TextTemplateDemo()
		{
		}
	}
	[Token(Token = "0x2000180")]
	public class Translations : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200025B")]
		public struct StringEntry
		{
			[Token(Token = "0x4000F1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string id;

			[Token(Token = "0x4000F20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string translation;
		}

		[Token(Token = "0x4000C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StringEntry[] entries;

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x9D980C", Offset = "0x9D980C", VA = "0x9D980C")]
		public Translations()
		{
		}
	}
	[Token(Token = "0x2000181")]
	public static class Interpolation
	{
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x9D2754", Offset = "0x9D2754", VA = "0x9D2754")]
		public static float EaseInEaseOut(float progress, int depth)
		{
			return default(float);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x9D27F8", Offset = "0x9D27F8", VA = "0x9D27F8")]
		public static bool ProgressOverTime(float startTime, float totalTime, ref float progress)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000182")]
	public abstract class TwoD
	{
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x9D9814", Offset = "0x9D9814", VA = "0x9D9814")]
		public static bool TriangleIsInBounds(Rect bounds, Vector2 p0, Vector2 p1, Vector2 p2)
		{
			return default(bool);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x9D9CF8", Offset = "0x9D9CF8", VA = "0x9D9CF8")]
		public static bool TriangleContainsPoint(Vector2 vertex0, Vector2 vertex1, Vector2 vertex2, Vector2 point)
		{
			return default(bool);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x9D9DB4", Offset = "0x9D9DB4", VA = "0x9D9DB4")]
		public static bool PointsOnSameSide(Vector2 line0, Vector2 line1, Vector2 point0, Vector2 point1)
		{
			return default(bool);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x9D9E44", Offset = "0x9D9E44", VA = "0x9D9E44")]
		public static Vector3 ToBarycentric(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x9D9E14", Offset = "0x9D9E14", VA = "0x9D9E14")]
		public static float Determinant(Vector2 p0, Vector2 p1, Vector2 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x9D99F8", Offset = "0x9D99F8", VA = "0x9D99F8")]
		public static bool TriangleIntersectsRectangle(Vector2 vertex0, Vector2 vertex1, Vector2 vertex2, Rect rect)
		{
			return default(bool);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x9D9ECC", Offset = "0x9D9ECC", VA = "0x9D9ECC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x76ACB0", Offset = "0x76ACB0")]
		public static Vector2 SwizzleXZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x9D9EFC", Offset = "0x9D9EFC", VA = "0x9D9EFC")]
		protected TwoD()
		{
		}
	}
	[Token(Token = "0x2000183")]
	public class MeasurePoint : MonoBehaviour
	{
		[Token(Token = "0x4000C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int nextNumber;

		[Token(Token = "0x4000C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int number;

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x9D79AC", Offset = "0x9D79AC", VA = "0x9D79AC")]
		public MeasurePoint()
		{
		}
	}
	[Token(Token = "0x2000184")]
	public class DummyEvent : Tracking.TrackingEvent
	{
		[Token(Token = "0x4000C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static DummyEvent instance;

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x9CD8F4", Offset = "0x9CD8F4", VA = "0x9CD8F4", Slot = "6")]
		public Tracking.TrackingEvent AddParameter(string name, float value)
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x9CD8F8", Offset = "0x9CD8F8", VA = "0x9CD8F8", Slot = "8")]
		public Tracking.TrackingEvent AddParameter(string name, bool value)
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x9CD8FC", Offset = "0x9CD8FC", VA = "0x9CD8FC", Slot = "7")]
		public Tracking.TrackingEvent AddParameter(string name, double value)
		{
			return null;
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x9CD900", Offset = "0x9CD900", VA = "0x9CD900", Slot = "5")]
		public Tracking.TrackingEvent AddParameter(string name, int value)
		{
			return null;
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x9CD904", Offset = "0x9CD904", VA = "0x9CD904", Slot = "4")]
		public Tracking.TrackingEvent AddParameter(string name, string value)
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x9CD908", Offset = "0x9CD908", VA = "0x9CD908", Slot = "9")]
		public void Submit()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x9CD90C", Offset = "0x9CD90C", VA = "0x9CD90C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x9CD954", Offset = "0x9CD954", VA = "0x9CD954")]
		public DummyEvent()
		{
		}
	}
	[Token(Token = "0x2000185")]
	public class ErrorCheckingTracker : Tracking.Tracker
	{
		[Token(Token = "0x200025C")]
		public class Failure : ApplicationException
		{
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x9CE36C", Offset = "0x9CE36C", VA = "0x9CE36C")]
			public Failure(string message)
			{
			}
		}

		[Token(Token = "0x200025D")]
		private class ErrorCheckingEvent : Tracking.TrackingEvent
		{
			[Token(Token = "0x4000F21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string eventName;

			[Token(Token = "0x4000F22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Dictionary<string, string> parameters;

			[Token(Token = "0x4000F23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool revenueSet;

			[Token(Token = "0x4000F24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool isSubmitted;

			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x9CE374", Offset = "0x9CE374", VA = "0x9CE374")]
			public ErrorCheckingEvent(string eventName)
			{
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x9CE400", Offset = "0x9CE400", VA = "0x9CE400", Slot = "4")]
			public Tracking.TrackingEvent AddParameter(string name, string value)
			{
				return null;
			}

			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x9CE690", Offset = "0x9CE690", VA = "0x9CE690", Slot = "6")]
			public Tracking.TrackingEvent AddParameter(string name, float value)
			{
				return null;
			}

			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x9CE6DC", Offset = "0x9CE6DC", VA = "0x9CE6DC", Slot = "7")]
			public Tracking.TrackingEvent AddParameter(string name, double value)
			{
				return null;
			}

			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x9CE728", Offset = "0x9CE728", VA = "0x9CE728", Slot = "5")]
			public Tracking.TrackingEvent AddParameter(string name, int value)
			{
				return null;
			}

			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0x9CE774", Offset = "0x9CE774", VA = "0x9CE774", Slot = "8")]
			public Tracking.TrackingEvent AddParameter(string name, bool value)
			{
				return null;
			}

			[Token(Token = "0x6000ADE")]
			[Address(RVA = "0x9CE7C4", Offset = "0x9CE7C4", VA = "0x9CE7C4", Slot = "9")]
			public void Submit()
			{
			}

			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0x9CE87C", Offset = "0x9CE87C", VA = "0x9CE87C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x4000C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ErrorCheckingEvent currentEvent;

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x9CE18C", Offset = "0x9CE18C", VA = "0x9CE18C", Slot = "4")]
		public Tracking.TrackingEvent Track(string eventName)
		{
			return null;
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x9CE3F8", Offset = "0x9CE3F8", VA = "0x9CE3F8")]
		public ErrorCheckingTracker()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class FirebaseTracking : MonoBehaviour, Tracking.Tracker
	{
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x9CF2A4", Offset = "0x9CF2A4", VA = "0x9CF2A4", Slot = "4")]
		private Tracking.TrackingEvent RGCommon.Tracking.Tracker.Track(string eventName)
		{
			return null;
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x9CF318", Offset = "0x9CF318", VA = "0x9CF318")]
		public FirebaseTracking()
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class HTTPTracking : MonoBehaviour, Tracking.Tracker, Tracking.TrackingEvent
	{
		[Token(Token = "0x200025E")]
		private struct Timing
		{
			[Token(Token = "0x4000F25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float time;

			[Token(Token = "0x4000F26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float variation;
		}

		[Token(Token = "0x200025F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767504", Offset = "0x767504")]
		private sealed class <Quit>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HTTPTracking <>4__this;

			[Token(Token = "0x17000127")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AE3")]
				[Address(RVA = "0x9D1340", Offset = "0x9D1340", VA = "0x9D1340", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000128")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AE5")]
				[Address(RVA = "0x9D13B0", Offset = "0x9D13B0", VA = "0x9D13B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0x9D0EA4", Offset = "0x9D0EA4", VA = "0x9D0EA4")]
			[DebuggerHidden]
			public <Quit>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0x9D1228", Offset = "0x9D1228", VA = "0x9D1228", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x9D122C", Offset = "0x9D122C", VA = "0x9D122C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0x9D1348", Offset = "0x9D1348", VA = "0x9D1348", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000260")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767514", Offset = "0x767514")]
		private sealed class <Start>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HTTPTracking <>4__this;

			[Token(Token = "0x4000F2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <nextSendTime>5__2;

			[Token(Token = "0x17000129")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AE9")]
				[Address(RVA = "0x9D26DC", Offset = "0x9D26DC", VA = "0x9D26DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AEB")]
				[Address(RVA = "0x9D274C", Offset = "0x9D274C", VA = "0x9D274C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0x9D0F44", Offset = "0x9D0F44", VA = "0x9D0F44")]
			[DebuggerHidden]
			public <Start>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0x9D2564", Offset = "0x9D2564", VA = "0x9D2564", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x9D2568", Offset = "0x9D2568", VA = "0x9D2568", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0x9D26E4", Offset = "0x9D26E4", VA = "0x9D26E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000261")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767524", Offset = "0x767524")]
		private sealed class <SendPending>d__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HTTPTracking <>4__this;

			[Token(Token = "0x4000F31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string <prefsKey>5__2;

			[Token(Token = "0x1700012B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AEF")]
				[Address(RVA = "0x9D24EC", Offset = "0x9D24EC", VA = "0x9D24EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AF1")]
				[Address(RVA = "0x9D255C", Offset = "0x9D255C", VA = "0x9D255C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0x9D0FE4", Offset = "0x9D0FE4", VA = "0x9D0FE4")]
			[DebuggerHidden]
			public <SendPending>d__32(int <>1__state)
			{
			}

			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x9D2018", Offset = "0x9D2018", VA = "0x9D2018", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x9D201C", Offset = "0x9D201C", VA = "0x9D201C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x9D24F4", Offset = "0x9D24F4", VA = "0x9D24F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000262")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x767534", Offset = "0x767534")]
		private sealed class <SendBatch>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000F33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000F34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int batchNumber;

			[Token(Token = "0x4000F35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string eventsData;

			[Token(Token = "0x4000F36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public HTTPTracking <>4__this;

			[Token(Token = "0x4000F37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest <request>5__2;

			[Token(Token = "0x1700012D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AF6")]
				[Address(RVA = "0x9D1FA0", Offset = "0x9D1FA0", VA = "0x9D1FA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AF8")]
				[Address(RVA = "0x9D2010", Offset = "0x9D2010", VA = "0x9D2010", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x9D10C0", Offset = "0x9D10C0", VA = "0x9D10C0")]
			[DebuggerHidden]
			public <SendBatch>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0x9D13B8", Offset = "0x9D13B8", VA = "0x9D13B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x9D1494", Offset = "0x9D1494", VA = "0x9D1494", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x9D13D4", Offset = "0x9D13D4", VA = "0x9D13D4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x9D1FA8", Offset = "0x9D1FA8", VA = "0x9D1FA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000C08")]
		private const float highFrequencyTime = 300f;

		[Token(Token = "0x4000C09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Timing highFrequencyTimeBetweenSends;

		[Token(Token = "0x4000C0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Timing standardTimeBetweenSends;

		[Token(Token = "0x4000C0B")]
		private const string serverUrl = "https://resgam-event-tracking.ew.r.appspot.com/";

		[Token(Token = "0x4000C0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly DateTime epoch;

		[Token(Token = "0x4000C0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string baseUrl;

		[Token(Token = "0x4000C0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private StringBuilder eventLog;

		[Token(Token = "0x4000C0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool eventOngoing;

		[Token(Token = "0x4000C10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool quitting;

		[Token(Token = "0x4000C11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool stopped;

		[Token(Token = "0x4000C12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly string NEXT_BATCH_NUMBER_KEY;

		[Token(Token = "0x4000C13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string FIRST_UNSENT_BATCH_KEY;

		[Token(Token = "0x4000C14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string BATCH_KEY_PREFIX;

		[Token(Token = "0x4000C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int currentBatchNumber;

		[Token(Token = "0x4000C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int firstUnsentBatch;

		[Token(Token = "0x4000C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool lastSendFailed;

		[Token(Token = "0x4000C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int lastResponseCode;

		[Token(Token = "0x4000C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int consecutiveSendFailures;

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x9D0100", Offset = "0x9D0100", VA = "0x9D0100", Slot = "5")]
		public Tracking.TrackingEvent AddParameter(string name, string value)
		{
			return null;
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x9D02E8", Offset = "0x9D02E8", VA = "0x9D02E8", Slot = "7")]
		public Tracking.TrackingEvent AddParameter(string name, float value)
		{
			return null;
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x9D042C", Offset = "0x9D042C", VA = "0x9D042C", Slot = "9")]
		public Tracking.TrackingEvent AddParameter(string name, bool value)
		{
			return null;
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x9D0540", Offset = "0x9D0540", VA = "0x9D0540", Slot = "8")]
		public Tracking.TrackingEvent AddParameter(string name, double value)
		{
			return null;
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x9D0684", Offset = "0x9D0684", VA = "0x9D0684", Slot = "6")]
		public Tracking.TrackingEvent AddParameter(string name, int value)
		{
			return null;
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x9D07C8", Offset = "0x9D07C8", VA = "0x9D07C8", Slot = "10")]
		public void Submit()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x9D0800", Offset = "0x9D0800", VA = "0x9D0800", Slot = "4")]
		public Tracking.TrackingEvent Track(string eventName)
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x9D0A1C", Offset = "0x9D0A1C", VA = "0x9D0A1C")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x9D0B1C", Offset = "0x9D0B1C", VA = "0x9D0B1C")]
		private bool OnWantsToQuit()
		{
			return default(bool);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x9D0C2C", Offset = "0x9D0C2C", VA = "0x9D0C2C")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x9D0E58", Offset = "0x9D0E58", VA = "0x9D0E58")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x9D0BB8", Offset = "0x9D0BB8", VA = "0x9D0BB8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76ACE8", Offset = "0x76ACE8")]
		private IEnumerator Quit()
		{
			return null;
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x9D0ED0", Offset = "0x9D0ED0", VA = "0x9D0ED0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76AD4C", Offset = "0x76AD4C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x9D0F70", Offset = "0x9D0F70", VA = "0x9D0F70")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76ADB0", Offset = "0x76ADB0")]
		private IEnumerator SendPending()
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x9D0C38", Offset = "0x9D0C38", VA = "0x9D0C38")]
		private void EndBatch()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x9D1010", Offset = "0x9D1010", VA = "0x9D1010")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76AE14", Offset = "0x76AE14")]
		private IEnumerator SendBatch(int batchNumber, string eventsData)
		{
			return null;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x9D020C", Offset = "0x9D020C", VA = "0x9D020C")]
		private static string Encode(string v)
		{
			return null;
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x9D095C", Offset = "0x9D095C", VA = "0x9D095C")]
		private static double GetTimestamp()
		{
			return default(double);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x9D10EC", Offset = "0x9D10EC", VA = "0x9D10EC")]
		public HTTPTracking()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class LifecycleTracking : MonoBehaviour
	{
		[Token(Token = "0x4000C1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string platform;

		[Token(Token = "0x4000C1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string PRODUCT_VERSION_KEY;

		[Token(Token = "0x4000C1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool hasSentStopEvent;

		[Token(Token = "0x4000C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool? lastKnownPause;

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x9D28AC", Offset = "0x9D28AC", VA = "0x9D28AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x9D2914", Offset = "0x9D2914", VA = "0x9D2914")]
		private void Start()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x9D2FF4", Offset = "0x9D2FF4", VA = "0x9D2FF4")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x9D31E4", Offset = "0x9D31E4", VA = "0x9D31E4")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x9D2D98", Offset = "0x9D2D98", VA = "0x9D2D98")]
		private Tracking.TrackingEvent AddCommonParameters(Tracking.TrackingEvent ev)
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x9D32E0", Offset = "0x9D32E0", VA = "0x9D32E0")]
		public LifecycleTracking()
		{
		}
	}
	[Token(Token = "0x2000189")]
	internal class MultiTracker : Tracking.Tracker
	{
		[Token(Token = "0x2000263")]
		private class MultiEvent : Tracking.TrackingEvent
		{
			[Token(Token = "0x4000F38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Tracking.TrackingEvent[] events;

			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x9D7DAC", Offset = "0x9D7DAC", VA = "0x9D7DAC")]
			public MultiEvent(Tracking.TrackingEvent[] events)
			{
			}

			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x9D7E48", Offset = "0x9D7E48", VA = "0x9D7E48", Slot = "5")]
			public Tracking.TrackingEvent AddParameter(string name, int value)
			{
				return null;
			}

			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0x9D7F90", Offset = "0x9D7F90", VA = "0x9D7F90", Slot = "7")]
			public Tracking.TrackingEvent AddParameter(string name, double value)
			{
				return null;
			}

			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x9D80D8", Offset = "0x9D80D8", VA = "0x9D80D8", Slot = "8")]
			public Tracking.TrackingEvent AddParameter(string name, bool value)
			{
				return null;
			}

			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x9D8224", Offset = "0x9D8224", VA = "0x9D8224", Slot = "6")]
			public Tracking.TrackingEvent AddParameter(string name, float value)
			{
				return null;
			}

			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x9D836C", Offset = "0x9D836C", VA = "0x9D836C", Slot = "4")]
			public Tracking.TrackingEvent AddParameter(string name, string value)
			{
				return null;
			}

			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0x9D84B0", Offset = "0x9D84B0", VA = "0x9D84B0", Slot = "9")]
			public void Submit()
			{
			}
		}

		[Token(Token = "0x4000C1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Tracking.Tracker> trackers;

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x9D79B4", Offset = "0x9D79B4", VA = "0x9D79B4", Slot = "4")]
		public Tracking.TrackingEvent Track(string eventName)
		{
			return null;
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x9D7DD8", Offset = "0x9D7DD8", VA = "0x9D7DD8")]
		public MultiTracker()
		{
		}
	}
	[Token(Token = "0x200018A")]
	public static class SimpleTracking
	{
		[Token(Token = "0x2000264")]
		public struct Settings
		{
			[Token(Token = "0x4000F39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string productName;

			[Token(Token = "0x4000F3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string platform;
		}

		[Token(Token = "0x4000C1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool started;

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x9D8AF0", Offset = "0x9D8AF0", VA = "0x9D8AF0")]
		public static void Start(Settings settings)
		{
		}
	}
	[Token(Token = "0x200018B")]
	public static class Tracking
	{
		[Token(Token = "0x2000265")]
		public interface TrackingEvent
		{
			[Token(Token = "0x6000B00")]
			TrackingEvent AddParameter(string name, string value);

			[Token(Token = "0x6000B01")]
			TrackingEvent AddParameter(string name, int value);

			[Token(Token = "0x6000B02")]
			TrackingEvent AddParameter(string name, float value);

			[Token(Token = "0x6000B03")]
			TrackingEvent AddParameter(string name, double value);

			[Token(Token = "0x6000B04")]
			TrackingEvent AddParameter(string name, bool value);

			[Token(Token = "0x6000B05")]
			void Submit();
		}

		[Token(Token = "0x2000266")]
		public interface Tracker
		{
			[Token(Token = "0x6000B06")]
			TrackingEvent Track(string eventName);
		}

		[Token(Token = "0x4000C20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string installationId;

		[Token(Token = "0x4000C21")]
		private const string installationIdPrefsKey = "installationId";

		[Token(Token = "0x4000C22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string productId;

		[Token(Token = "0x4000C23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Tracker tracker;

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x9D9220", Offset = "0x9D9220", VA = "0x9D9220")]
		public static TrackingEvent Track(string eventName)
		{
			return null;
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x9D9370", Offset = "0x9D9370", VA = "0x9D9370")]
		public static void RegisterTracker(Tracker newTracker)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x9D8C80", Offset = "0x9D8C80", VA = "0x9D8C80")]
		public static void SetProduct(string product)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x9D9528", Offset = "0x9D9528", VA = "0x9D9528")]
		public static string GetProduct()
		{
			return null;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x9D95FC", Offset = "0x9D95FC", VA = "0x9D95FC")]
		public static string GetVersion()
		{
			return null;
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x9D968C", Offset = "0x9D968C", VA = "0x9D968C")]
		public static string GetUserId()
		{
			return null;
		}
	}
	[Token(Token = "0x200018C")]
	public static class TrackingNames
	{
		[Token(Token = "0x4000C24")]
		public const string eventAddPaymentInfo = "add_payment_info";

		[Token(Token = "0x4000C25")]
		public const string eventAddToCart = "add_to_cart";

		[Token(Token = "0x4000C26")]
		public const string eventAddToWishlist = "add_to_wishlist";

		[Token(Token = "0x4000C27")]
		public const string eventAppOpen = "app_open";

		[Token(Token = "0x4000C28")]
		public const string eventBeginCheckout = "begin_checkout";

		[Token(Token = "0x4000C29")]
		public const string eventCampaignDetails = "campaign_details";

		[Token(Token = "0x4000C2A")]
		public const string eventCheckoutProgress = "checkout_progress";

		[Token(Token = "0x4000C2B")]
		public const string eventEarnVirtualCurrency = "earn_virtual_currency";

		[Token(Token = "0x4000C2C")]
		public const string eventEcommercePurchase = "ecommerce_purchase";

		[Token(Token = "0x4000C2D")]
		public const string eventGenerateLead = "generate_lead";

		[Token(Token = "0x4000C2E")]
		public const string eventJoinGroup = "join_group";

		[Token(Token = "0x4000C2F")]
		public const string eventLevelUp = "level_up";

		[Token(Token = "0x4000C30")]
		public const string eventLogin = "login";

		[Token(Token = "0x4000C31")]
		public const string eventPostScore = "post_score";

		[Token(Token = "0x4000C32")]
		public const string eventPresentOffer = "present_offer";

		[Token(Token = "0x4000C33")]
		public const string eventPurchaseRefund = "purchase_refund";

		[Token(Token = "0x4000C34")]
		public const string eventRemoveFromCart = "remove_from_cart";

		[Token(Token = "0x4000C35")]
		public const string eventSearch = "search";

		[Token(Token = "0x4000C36")]
		public const string eventSelectContent = "select_content";

		[Token(Token = "0x4000C37")]
		public const string eventSetCheckoutOption = "set_checkout_option";

		[Token(Token = "0x4000C38")]
		public const string eventShare = "share";

		[Token(Token = "0x4000C39")]
		public const string eventSignUp = "sign_up";

		[Token(Token = "0x4000C3A")]
		public const string eventSpendVirtualCurrency = "spend_virtual_currency";

		[Token(Token = "0x4000C3B")]
		public const string eventTutorialBegin = "tutorial_begin";

		[Token(Token = "0x4000C3C")]
		public const string eventTutorialComplete = "tutorial_complete";

		[Token(Token = "0x4000C3D")]
		public const string eventUnlockAchievement = "unlock_achievement";

		[Token(Token = "0x4000C3E")]
		public const string eventViewItem = "view_item";

		[Token(Token = "0x4000C3F")]
		public const string eventViewItemList = "view_item_list";

		[Token(Token = "0x4000C40")]
		public const string eventViewSearchResults = "view_search_results";

		[Token(Token = "0x4000C41")]
		public const string parameterAchievementId = "achievement_id";

		[Token(Token = "0x4000C42")]
		public const string parameterAdNetworkClickID = "aclid";

		[Token(Token = "0x4000C43")]
		public const string parameterAffiliation = "affiliation";

		[Token(Token = "0x4000C44")]
		public const string parameterCampaign = "campaign";

		[Token(Token = "0x4000C45")]
		public const string parameterCharacter = "character";

		[Token(Token = "0x4000C46")]
		public const string parameterCheckoutOption = "checkout_option";

		[Token(Token = "0x4000C47")]
		public const string parameterCheckoutStep = "checkout_step";

		[Token(Token = "0x4000C48")]
		public const string parameterContent = "content";

		[Token(Token = "0x4000C49")]
		public const string parameterContentType = "content_type";

		[Token(Token = "0x4000C4A")]
		public const string parameterCoupon = "coupon";

		[Token(Token = "0x4000C4B")]
		public const string parameterCP1 = "cp1";

		[Token(Token = "0x4000C4C")]
		public const string parameterCreativeName = "creative_name";

		[Token(Token = "0x4000C4D")]
		public const string parameterCreativeSlot = "creative_slot";

		[Token(Token = "0x4000C4E")]
		public const string parameterCurrency = "currency";

		[Token(Token = "0x4000C4F")]
		public const string parameterDestination = "destination";

		[Token(Token = "0x4000C50")]
		public const string parameterEndDate = "end_date";

		[Token(Token = "0x4000C51")]
		public const string parameterFlightNumber = "flight_number";

		[Token(Token = "0x4000C52")]
		public const string parameterGroupId = "group_id";

		[Token(Token = "0x4000C53")]
		public const string parameterItemBrand = "item_brand";

		[Token(Token = "0x4000C54")]
		public const string parameterItemCategory = "item_category";

		[Token(Token = "0x4000C55")]
		public const string parameterItemId = "item_id";

		[Token(Token = "0x4000C56")]
		public const string parameterItemList = "item_list";

		[Token(Token = "0x4000C57")]
		public const string parameterItemLocationId = "item_location_id";

		[Token(Token = "0x4000C58")]
		public const string parameterItemName = "item_name";

		[Token(Token = "0x4000C59")]
		public const string parameterItemVariant = "item_variant";

		[Token(Token = "0x4000C5A")]
		public const string parameterLevel = "level";

		[Token(Token = "0x4000C5B")]
		public const string parameterLocation = "location";

		[Token(Token = "0x4000C5C")]
		public const string parameterMedium = "medium";

		[Token(Token = "0x4000C5D")]
		public const string parameterNumberOfNights = "number_of_nights";

		[Token(Token = "0x4000C5E")]
		public const string parameterNumberOfPassengers = "number_of_passengers";

		[Token(Token = "0x4000C5F")]
		public const string parameterNumberOfRooms = "number_of_rooms";

		[Token(Token = "0x4000C60")]
		public const string parameterOrigin = "origin";

		[Token(Token = "0x4000C61")]
		public const string parameterPrice = "price";

		[Token(Token = "0x4000C62")]
		public const string parameterQuantity = "quantity";

		[Token(Token = "0x4000C63")]
		public const string parameterScore = "score";

		[Token(Token = "0x4000C64")]
		public const string parameterSearchTerm = "search_term";

		[Token(Token = "0x4000C65")]
		public const string parameterShipping = "shipping";

		[Token(Token = "0x4000C66")]
		public const string parameterSignUpMethod = "sign_up_method";

		[Token(Token = "0x4000C67")]
		public const string parameterSource = "source";

		[Token(Token = "0x4000C68")]
		public const string parameterStartDate = "start_date";

		[Token(Token = "0x4000C69")]
		public const string parameterTax = "tax";

		[Token(Token = "0x4000C6A")]
		public const string parameterTerm = "term";

		[Token(Token = "0x4000C6B")]
		public const string parameterTransactionId = "transaction_id";

		[Token(Token = "0x4000C6C")]
		public const string parameterTravelClass = "travel_class";

		[Token(Token = "0x4000C6D")]
		public const string parameterValue = "value";

		[Token(Token = "0x4000C6E")]
		public const string parameterVirtualCurrencyName = "virtual_currency_name";

		[Token(Token = "0x4000C6F")]
		public const string userPropertySignUpMethod = "sign_up_method";
	}
	[Token(Token = "0x200018D")]
	public class FollowPose : MonoBehaviour
	{
		[Token(Token = "0x4000C70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768E40", Offset = "0x768E40")]
		public Transform objectToFollow;

		[Token(Token = "0x4000C71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768E78", Offset = "0x768E78")]
		[SerializeField]
		private float movementSmoothTime;

		[Token(Token = "0x4000C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768EC4", Offset = "0x768EC4")]
		[SerializeField]
		private float rotationSmoothTime;

		[Token(Token = "0x4000C73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768F10", Offset = "0x768F10")]
		[SerializeField]
		private Vector3 globalPositionOffset;

		[Token(Token = "0x4000C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768F5C", Offset = "0x768F5C")]
		[SerializeField]
		private Vector3 localPositionOffset;

		[Token(Token = "0x4000C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768FA8", Offset = "0x768FA8")]
		[SerializeField]
		private Vector3 rotationOffset;

		[Token(Token = "0x4000C76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x768FF4", Offset = "0x768FF4")]
		[SerializeField]
		private bool keepHorizontal;

		[Token(Token = "0x4000C77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private new Transform transform;

		[Token(Token = "0x4000C78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 movementVelocity;

		[Token(Token = "0x4000C79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion rotationVelocity;

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x9CF320", Offset = "0x9CF320", VA = "0x9CF320")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x9CF348", Offset = "0x9CF348", VA = "0x9CF348")]
		private void Update()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x9CF784", Offset = "0x9CF784", VA = "0x9CF784")]
		private static Quaternion SmoothDamp(Quaternion rot, Quaternion target, ref Quaternion deriv, float time)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x9CF9C4", Offset = "0x9CF9C4", VA = "0x9CF9C4")]
		public FollowPose()
		{
		}
	}
	[Token(Token = "0x200018E")]
	public class VideoSlate : MonoBehaviour
	{
		[Token(Token = "0x4000C7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode visibilityKey;

		[Token(Token = "0x4000C7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public KeyCode slateKey;

		[Token(Token = "0x4000C7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GUIStyle guiStyle;

		[Token(Token = "0x4000C7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int framesLeft;

		[Token(Token = "0x4000C7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Texture2D bgTexture;

		[Token(Token = "0x4000C7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int slateNumber;

		[Token(Token = "0x4000C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool showSlateNumber;

		[Token(Token = "0x4000C81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AudioSource audioSource;

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x9DBCC0", Offset = "0x9DBCC0", VA = "0x9DBCC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x9DBE78", Offset = "0x9DBE78", VA = "0x9DBE78")]
		private void Update()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x9DBF54", Offset = "0x9DBF54", VA = "0x9DBF54")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x9DC434", Offset = "0x9DC434", VA = "0x9DC434")]
		public VideoSlate()
		{
		}
	}
}
namespace RGCommon.VectorExtensions
{
	[Token(Token = "0x200018F")]
	public static class VectorComponentReplacement
	{
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x9D9F04", Offset = "0x9D9F04", VA = "0x9D9F04")]
		public static Vector3 WithX(this Vector3 original, float newX)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x9D9F3C", Offset = "0x9D9F3C", VA = "0x9D9F3C")]
		public static Vector3 WithY(this Vector3 original, float newY)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x9D9F74", Offset = "0x9D9F74", VA = "0x9D9F74")]
		public static Vector3 WithZ(this Vector3 original, float newZ)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x9D9FAC", Offset = "0x9D9FAC", VA = "0x9D9FAC")]
		public static Vector2 WithX(this Vector2 original, float newX)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x9D9FDC", Offset = "0x9D9FDC", VA = "0x9D9FDC")]
		public static Vector2 WithY(this Vector2 original, float newY)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x2000190")]
	public static class VectorSwizzle
	{
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x9DA00C", Offset = "0x9DA00C", VA = "0x9DA00C")]
		public static Vector2 Swizzle00(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x9DA040", Offset = "0x9DA040", VA = "0x9DA040")]
		public static Vector2 Swizzle0X(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x9DA074", Offset = "0x9DA074", VA = "0x9DA074")]
		public static Vector2 Swizzle0Y(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x9DA0A4", Offset = "0x9DA0A4", VA = "0x9DA0A4")]
		public static Vector2 Swizzle0Z(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x9DA0D8", Offset = "0x9DA0D8", VA = "0x9DA0D8")]
		public static Vector2 SwizzleX0(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x9DA108", Offset = "0x9DA108", VA = "0x9DA108")]
		public static Vector2 SwizzleXX(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x9DA138", Offset = "0x9DA138", VA = "0x9DA138")]
		public static Vector2 SwizzleXY(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x9DA164", Offset = "0x9DA164", VA = "0x9DA164")]
		public static Vector2 SwizzleXZ(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x9DA194", Offset = "0x9DA194", VA = "0x9DA194")]
		public static Vector2 SwizzleY0(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x9DA1C8", Offset = "0x9DA1C8", VA = "0x9DA1C8")]
		public static Vector2 SwizzleYX(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x9DA200", Offset = "0x9DA200", VA = "0x9DA200")]
		public static Vector2 SwizzleYY(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x9DA230", Offset = "0x9DA230", VA = "0x9DA230")]
		public static Vector2 SwizzleYZ(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x9DA264", Offset = "0x9DA264", VA = "0x9DA264")]
		public static Vector2 SwizzleZ0(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x9DA298", Offset = "0x9DA298", VA = "0x9DA298")]
		public static Vector2 SwizzleZX(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x9DA2CC", Offset = "0x9DA2CC", VA = "0x9DA2CC")]
		public static Vector2 SwizzleZY(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x9DA2FC", Offset = "0x9DA2FC", VA = "0x9DA2FC")]
		public static Vector2 SwizzleZZ(this Vector3 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x9DA330", Offset = "0x9DA330", VA = "0x9DA330")]
		public static Vector3 Swizzle000(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x9DA370", Offset = "0x9DA370", VA = "0x9DA370")]
		public static Vector3 Swizzle00X(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x9DA3B0", Offset = "0x9DA3B0", VA = "0x9DA3B0")]
		public static Vector3 Swizzle00Y(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x9DA3F0", Offset = "0x9DA3F0", VA = "0x9DA3F0")]
		public static Vector3 Swizzle00Z(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x9DA42C", Offset = "0x9DA42C", VA = "0x9DA42C")]
		public static Vector3 Swizzle0X0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x9DA46C", Offset = "0x9DA46C", VA = "0x9DA46C")]
		public static Vector3 Swizzle0XX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x9DA4AC", Offset = "0x9DA4AC", VA = "0x9DA4AC")]
		public static Vector3 Swizzle0XY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x9DA4EC", Offset = "0x9DA4EC", VA = "0x9DA4EC")]
		public static Vector3 Swizzle0XZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x9DA528", Offset = "0x9DA528", VA = "0x9DA528")]
		public static Vector3 Swizzle0Y0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x9DA564", Offset = "0x9DA564", VA = "0x9DA564")]
		public static Vector3 Swizzle0YX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x9DA5A0", Offset = "0x9DA5A0", VA = "0x9DA5A0")]
		public static Vector3 Swizzle0YY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x9DA5DC", Offset = "0x9DA5DC", VA = "0x9DA5DC")]
		public static Vector3 Swizzle0YZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x9DA614", Offset = "0x9DA614", VA = "0x9DA614")]
		public static Vector3 Swizzle0Z0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x9DA654", Offset = "0x9DA654", VA = "0x9DA654")]
		public static Vector3 Swizzle0ZX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x9DA698", Offset = "0x9DA698", VA = "0x9DA698")]
		public static Vector3 Swizzle0ZY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x9DA6DC", Offset = "0x9DA6DC", VA = "0x9DA6DC")]
		public static Vector3 Swizzle0ZZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x9DA718", Offset = "0x9DA718", VA = "0x9DA718")]
		public static Vector3 SwizzleX00(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x9DA754", Offset = "0x9DA754", VA = "0x9DA754")]
		public static Vector3 SwizzleX0X(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x9DA790", Offset = "0x9DA790", VA = "0x9DA790")]
		public static Vector3 SwizzleX0Y(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x9DA7CC", Offset = "0x9DA7CC", VA = "0x9DA7CC")]
		public static Vector3 SwizzleX0Z(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x9DA804", Offset = "0x9DA804", VA = "0x9DA804")]
		public static Vector3 SwizzleXX0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x9DA840", Offset = "0x9DA840", VA = "0x9DA840")]
		public static Vector3 SwizzleXXX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x9DA87C", Offset = "0x9DA87C", VA = "0x9DA87C")]
		public static Vector3 SwizzleXXY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x9DA8B8", Offset = "0x9DA8B8", VA = "0x9DA8B8")]
		public static Vector3 SwizzleXXZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x9DA8F0", Offset = "0x9DA8F0", VA = "0x9DA8F0")]
		public static Vector3 SwizzleXY0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x9DA928", Offset = "0x9DA928", VA = "0x9DA928")]
		public static Vector3 SwizzleXYX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x9DA960", Offset = "0x9DA960", VA = "0x9DA960")]
		public static Vector3 SwizzleXYY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x9DA998", Offset = "0x9DA998", VA = "0x9DA998")]
		public static Vector3 SwizzleXYZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x9DA9CC", Offset = "0x9DA9CC", VA = "0x9DA9CC")]
		public static Vector3 SwizzleXZ0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x9DAA08", Offset = "0x9DAA08", VA = "0x9DAA08")]
		public static Vector3 SwizzleXZX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x9DAA44", Offset = "0x9DAA44", VA = "0x9DAA44")]
		public static Vector3 SwizzleXZY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x9DAA84", Offset = "0x9DAA84", VA = "0x9DAA84")]
		public static Vector3 SwizzleXZZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x9DAABC", Offset = "0x9DAABC", VA = "0x9DAABC")]
		public static Vector3 SwizzleY00(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x9DAAFC", Offset = "0x9DAAFC", VA = "0x9DAAFC")]
		public static Vector3 SwizzleY0X(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x9DAB44", Offset = "0x9DAB44", VA = "0x9DAB44")]
		public static Vector3 SwizzleY0Y(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x9DAB84", Offset = "0x9DAB84", VA = "0x9DAB84")]
		public static Vector3 SwizzleY0Z(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x9DABC0", Offset = "0x9DABC0", VA = "0x9DABC0")]
		public static Vector3 SwizzleYX0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x9DAC04", Offset = "0x9DAC04", VA = "0x9DAC04")]
		public static Vector3 SwizzleYXX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x9DAC44", Offset = "0x9DAC44", VA = "0x9DAC44")]
		public static Vector3 SwizzleYXY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x9DAC84", Offset = "0x9DAC84", VA = "0x9DAC84")]
		public static Vector3 SwizzleYXZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x9DACC4", Offset = "0x9DACC4", VA = "0x9DACC4")]
		public static Vector3 SwizzleYY0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x9DAD00", Offset = "0x9DAD00", VA = "0x9DAD00")]
		public static Vector3 SwizzleYYX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x9DAD3C", Offset = "0x9DAD3C", VA = "0x9DAD3C")]
		public static Vector3 SwizzleYYY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x9DAD78", Offset = "0x9DAD78", VA = "0x9DAD78")]
		public static Vector3 SwizzleYYZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x9DADB0", Offset = "0x9DADB0", VA = "0x9DADB0")]
		public static Vector3 SwizzleYZ0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x9DADF4", Offset = "0x9DADF4", VA = "0x9DADF4")]
		public static Vector3 SwizzleYZX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x9DAE38", Offset = "0x9DAE38", VA = "0x9DAE38")]
		public static Vector3 SwizzleYZY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x9DAE78", Offset = "0x9DAE78", VA = "0x9DAE78")]
		public static Vector3 SwizzleYZZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x9DAEB4", Offset = "0x9DAEB4", VA = "0x9DAEB4")]
		public static Vector3 SwizzleZ00(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x9DAEF4", Offset = "0x9DAEF4", VA = "0x9DAEF4")]
		public static Vector3 SwizzleZ0X(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x9DAF38", Offset = "0x9DAF38", VA = "0x9DAF38")]
		public static Vector3 SwizzleZ0Y(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x9DAF7C", Offset = "0x9DAF7C", VA = "0x9DAF7C")]
		public static Vector3 SwizzleZ0Z(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x9DAFB8", Offset = "0x9DAFB8", VA = "0x9DAFB8")]
		public static Vector3 SwizzleZX0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x9DB000", Offset = "0x9DB000", VA = "0x9DB000")]
		public static Vector3 SwizzleZXX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x9DB040", Offset = "0x9DB040", VA = "0x9DB040")]
		public static Vector3 SwizzleZXY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x9DB084", Offset = "0x9DB084", VA = "0x9DB084")]
		public static Vector3 SwizzleZXZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x9DB0C0", Offset = "0x9DB0C0", VA = "0x9DB0C0")]
		public static Vector3 SwizzleZY0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x9DB0FC", Offset = "0x9DB0FC", VA = "0x9DB0FC")]
		public static Vector3 SwizzleZYX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x9DB13C", Offset = "0x9DB13C", VA = "0x9DB13C")]
		public static Vector3 SwizzleZYY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x9DB178", Offset = "0x9DB178", VA = "0x9DB178")]
		public static Vector3 SwizzleZYZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x9DB1B0", Offset = "0x9DB1B0", VA = "0x9DB1B0")]
		public static Vector3 SwizzleZZ0(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x9DB1F0", Offset = "0x9DB1F0", VA = "0x9DB1F0")]
		public static Vector3 SwizzleZZX(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x9DB234", Offset = "0x9DB234", VA = "0x9DB234")]
		public static Vector3 SwizzleZZY(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x9DB278", Offset = "0x9DB278", VA = "0x9DB278")]
		public static Vector3 SwizzleZZZ(this Vector3 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x9DB2B4", Offset = "0x9DB2B4", VA = "0x9DB2B4")]
		public static Vector2 Swizzle00(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x9DB2E8", Offset = "0x9DB2E8", VA = "0x9DB2E8")]
		public static Vector2 Swizzle0X(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x9DB31C", Offset = "0x9DB31C", VA = "0x9DB31C")]
		public static Vector2 Swizzle0Y(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x9DB34C", Offset = "0x9DB34C", VA = "0x9DB34C")]
		public static Vector2 SwizzleX0(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x9DB37C", Offset = "0x9DB37C", VA = "0x9DB37C")]
		public static Vector2 SwizzleXX(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x9DB3AC", Offset = "0x9DB3AC", VA = "0x9DB3AC")]
		public static Vector2 SwizzleXY(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x9DB3D8", Offset = "0x9DB3D8", VA = "0x9DB3D8")]
		public static Vector2 SwizzleY0(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x9DB40C", Offset = "0x9DB40C", VA = "0x9DB40C")]
		public static Vector2 SwizzleYX(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x9DB444", Offset = "0x9DB444", VA = "0x9DB444")]
		public static Vector2 SwizzleYY(this Vector2 original)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x9DB474", Offset = "0x9DB474", VA = "0x9DB474")]
		public static Vector3 Swizzle000(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x9DB4B4", Offset = "0x9DB4B4", VA = "0x9DB4B4")]
		public static Vector3 Swizzle00X(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x9DB4F4", Offset = "0x9DB4F4", VA = "0x9DB4F4")]
		public static Vector3 Swizzle00Y(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x9DB534", Offset = "0x9DB534", VA = "0x9DB534")]
		public static Vector3 Swizzle0X0(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x9DB574", Offset = "0x9DB574", VA = "0x9DB574")]
		public static Vector3 Swizzle0XX(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x9DB5B4", Offset = "0x9DB5B4", VA = "0x9DB5B4")]
		public static Vector3 Swizzle0XY(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x9DB5F4", Offset = "0x9DB5F4", VA = "0x9DB5F4")]
		public static Vector3 Swizzle0Y0(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x9DB630", Offset = "0x9DB630", VA = "0x9DB630")]
		public static Vector3 Swizzle0YX(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x9DB66C", Offset = "0x9DB66C", VA = "0x9DB66C")]
		public static Vector3 Swizzle0YY(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x9DB6A8", Offset = "0x9DB6A8", VA = "0x9DB6A8")]
		public static Vector3 SwizzleX00(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x9DB6E4", Offset = "0x9DB6E4", VA = "0x9DB6E4")]
		public static Vector3 SwizzleX0X(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x9DB720", Offset = "0x9DB720", VA = "0x9DB720")]
		public static Vector3 SwizzleX0Y(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x9DB75C", Offset = "0x9DB75C", VA = "0x9DB75C")]
		public static Vector3 SwizzleXX0(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x9DB798", Offset = "0x9DB798", VA = "0x9DB798")]
		public static Vector3 SwizzleXXX(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x9DB7D4", Offset = "0x9DB7D4", VA = "0x9DB7D4")]
		public static Vector3 SwizzleXXY(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x9DB810", Offset = "0x9DB810", VA = "0x9DB810")]
		public static Vector3 SwizzleXY0(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x9DB848", Offset = "0x9DB848", VA = "0x9DB848")]
		public static Vector3 SwizzleXYX(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x9DB880", Offset = "0x9DB880", VA = "0x9DB880")]
		public static Vector3 SwizzleXYY(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x9DB8B8", Offset = "0x9DB8B8", VA = "0x9DB8B8")]
		public static Vector3 SwizzleY00(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x9DB8F8", Offset = "0x9DB8F8", VA = "0x9DB8F8")]
		public static Vector3 SwizzleY0X(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x9DB940", Offset = "0x9DB940", VA = "0x9DB940")]
		public static Vector3 SwizzleY0Y(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x9DB980", Offset = "0x9DB980", VA = "0x9DB980")]
		public static Vector3 SwizzleYX0(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x9DB9C4", Offset = "0x9DB9C4", VA = "0x9DB9C4")]
		public static Vector3 SwizzleYXX(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x9DBA04", Offset = "0x9DBA04", VA = "0x9DBA04")]
		public static Vector3 SwizzleYXY(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x9DBA44", Offset = "0x9DBA44", VA = "0x9DBA44")]
		public static Vector3 SwizzleYY0(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x9DBA80", Offset = "0x9DBA80", VA = "0x9DBA80")]
		public static Vector3 SwizzleYYX(this Vector2 original)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x9DBABC", Offset = "0x9DBABC", VA = "0x9DBABC")]
		public static Vector3 SwizzleYYY(this Vector2 original)
		{
			return default(Vector3);
		}
	}
}
namespace LevelEditorAPI
{
	[Serializable]
	[Token(Token = "0x2000191")]
	public struct BlockData
	{
		[Token(Token = "0x4000C82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int id;

		[Token(Token = "0x4000C83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int prefabId;

		[Token(Token = "0x4000C84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 localPosition;

		[Token(Token = "0x4000C85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Quaternion localRotation;

		[Token(Token = "0x1700002C")]
		public Prefab Prefab
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x7D8D30", Offset = "0x7D8D30", VA = "0x7D8D30")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Token(Token = "0x2000192")]
	public class Level
	{
		[Token(Token = "0x4000C86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LevelMetaData MetaData;

		[Token(Token = "0x4000C87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LevelBlockCollection LevelBlocks;

		[Token(Token = "0x4000C88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isDirty;

		[Token(Token = "0x1700002D")]
		public int BlockCount
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0xA25698", Offset = "0xA25698", VA = "0xA25698")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xA25708", Offset = "0xA25708", VA = "0xA25708")]
		public Level(string name, uint id)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xA258D4", Offset = "0xA258D4", VA = "0xA258D4")]
		public Level(LevelMetaData metaData, LevelBlockCollection blockData)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xA1BEB0", Offset = "0xA1BEB0", VA = "0xA1BEB0")]
		public Level Clone()
		{
			return null;
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xA154D0", Offset = "0xA154D0", VA = "0xA154D0")]
		public void AddBlock(BlockData blockData)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xA15838", Offset = "0xA15838", VA = "0xA15838")]
		public void SetBlock(BlockData blockData)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xA15708", Offset = "0xA15708", VA = "0xA15708")]
		public void RemoveBlock(int id)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xA25D88", Offset = "0xA25D88", VA = "0xA25D88")]
		public bool ContainsPig()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xA25E80", Offset = "0xA25E80", VA = "0xA25E80")]
		public BlockData GetBlock(int index)
		{
			return default(BlockData);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xA25F08", Offset = "0xA25F08", VA = "0xA25F08")]
		public void Sort(Comparison<BlockData> comparison)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xA25F78", Offset = "0xA25F78", VA = "0xA25F78")]
		public static Level Decompress(string data)
		{
			return null;
		}
	}
	[Token(Token = "0x2000193")]
	public static class LevelExtensions
	{
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xA266F8", Offset = "0xA266F8", VA = "0xA266F8")]
		public static string Compress(this Level level)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000194")]
	public class LevelBlockCollection
	{
		[Token(Token = "0x4000C89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<BlockData> blocks;

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xA25864", Offset = "0xA25864", VA = "0xA25864")]
		public LevelBlockCollection()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xA25D04", Offset = "0xA25D04", VA = "0xA25D04")]
		public LevelBlockCollection(List<BlockData> blocks)
		{
		}
	}
	[Token(Token = "0x2000195")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x766BF4", Offset = "0x766BF4")]
	public class Prefab : ScriptableObject, IPrefab
	{
		[Token(Token = "0x4000C8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x769040", Offset = "0x769040")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x769040", Offset = "0x769040")]
		private string category;

		[Token(Token = "0x4000C8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7690B0", Offset = "0x7690B0")]
		private int maxObjects;

		[Token(Token = "0x4000C8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7690FC", Offset = "0x7690FC")]
		private bool hidden;

		[Token(Token = "0x4000C8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool locked;

		[Token(Token = "0x4000C8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x769158", Offset = "0x769158")]
		[SerializeField]
		private string prefabName;

		[Token(Token = "0x4000C8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject gameObject;

		[Token(Token = "0x4000C90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Material[] materials;

		[Token(Token = "0x4000C91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool special;

		[Token(Token = "0x4000C92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool character;

		[Token(Token = "0x4000C93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		public int cost;

		[Token(Token = "0x4000C94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7691F4", Offset = "0x7691F4")]
		private string path;

		[Token(Token = "0x4000C95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int id;

		[NonSerialized]
		[Token(Token = "0x4000C96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshDrawerInstance[] meshDrawerInstances;

		[NonSerialized]
		[Token(Token = "0x4000C97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Bounds? meshDrawerTotalBounds;

		[Token(Token = "0x1700002E")]
		public string Category
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0xA28CD0", Offset = "0xA28CD0", VA = "0xA28CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xA28CD8", Offset = "0xA28CD8", VA = "0xA28CD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public int MaxObjects
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xA28D08", Offset = "0xA28D08", VA = "0xA28D08")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000030")]
		public bool Hidden
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0xA165F4", Offset = "0xA165F4", VA = "0xA165F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000031")]
		public bool Locked
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0xA28D10", Offset = "0xA28D10", VA = "0xA28D10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000032")]
		public string PrefabName
		{
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0xA28D18", Offset = "0xA28D18", VA = "0xA28D18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public string Path
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0xA28D20", Offset = "0xA28D20", VA = "0xA28D20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public GameObject GameObject
		{
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0xA28D28", Offset = "0xA28D28", VA = "0xA28D28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public Material[] Materials
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0xA28D30", Offset = "0xA28D30", VA = "0xA28D30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public bool Special
		{
			[Token(Token = "0x6000700")]
			[Address(RVA = "0xA28D38", Offset = "0xA28D38", VA = "0xA28D38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public bool Character
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0xA2171C", Offset = "0xA2171C", VA = "0xA2171C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public int Id
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0xA15608", Offset = "0xA15608", VA = "0xA15608")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000039")]
		public IPrefab Edit
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0xA28E20", Offset = "0xA28E20", VA = "0xA28E20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private string LevelEditorAPI.InternalPrefab.IPrefab.PrefabName
		{
			[Token(Token = "0x600070F")]
			[Address(RVA = "0xA293F0", Offset = "0xA293F0", VA = "0xA293F0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000710")]
			[Address(RVA = "0xA293F8", Offset = "0xA293F8", VA = "0xA293F8", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		private GameObject LevelEditorAPI.InternalPrefab.IPrefab.GameObject
		{
			[Token(Token = "0x6000711")]
			[Address(RVA = "0xA29400", Offset = "0xA29400", VA = "0xA29400", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000712")]
			[Address(RVA = "0xA29408", Offset = "0xA29408", VA = "0xA29408", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		private int LevelEditorAPI.InternalPrefab.IPrefab.Id
		{
			[Token(Token = "0x6000713")]
			[Address(RVA = "0xA29410", Offset = "0xA29410", VA = "0xA29410", Slot = "8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000714")]
			[Address(RVA = "0xA29418", Offset = "0xA29418", VA = "0xA29418", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public MeshDrawerInstance[] MeshDrawerInstances
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0xA29540", Offset = "0xA29540", VA = "0xA29540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public Bounds MeshDrawerTotalBounds
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0xA29628", Offset = "0xA29628", VA = "0xA29628")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xA28E24", Offset = "0xA28E24", VA = "0xA28E24", Slot = "10")]
		private void LevelEditorAPI.InternalPrefab.IPrefab.Initialize()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xA28E28", Offset = "0xA28E28", VA = "0xA28E28")]
		public GameObject Instantiate()
		{
			return null;
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xA29058", Offset = "0xA29058", VA = "0xA29058")]
		public GameObject Instantiate(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xA290BC", Offset = "0xA290BC", VA = "0xA290BC")]
		public GameObject Instantiate(Vector3 position)
		{
			return null;
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xA29120", Offset = "0xA29120", VA = "0xA29120")]
		public GameObject Instantiate(Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xA29160", Offset = "0xA29160", VA = "0xA29160")]
		public GameObject Instantiate(Vector3 position, Quaternion rotation, Vector3 scale)
		{
			return null;
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xA291D8", Offset = "0xA291D8", VA = "0xA291D8")]
		public GameObject Instantiate(Vector3 position, Quaternion rotation, Vector3 scale, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xA292CC", Offset = "0xA292CC", VA = "0xA292CC")]
		public GameObject Instantiate(Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xA28E60", Offset = "0xA28E60", VA = "0xA28E60")]
		public GameObject Instantiate(InstantiateData data)
		{
			return null;
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xA2930C", Offset = "0xA2930C", VA = "0xA2930C")]
		public void Destroy(GameObject gameObject)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xA29374", Offset = "0xA29374", VA = "0xA29374")]
		public bool HasGameObject(GameObject gameObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xA29420", Offset = "0xA29420", VA = "0xA29420")]
		public static implicit operator int(Prefab prefab)
		{
			return default(int);
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xA29448", Offset = "0xA29448", VA = "0xA29448")]
		public static implicit operator GameObject(Prefab prefab)
		{
			return null;
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xA29470", Offset = "0xA29470", VA = "0xA29470")]
		public static implicit operator string(Prefab prefab)
		{
			return null;
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xA29498", Offset = "0xA29498", VA = "0xA29498")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x76B618", Offset = "0x76B618")]
		private void SetNameToPrefab()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xA29570", Offset = "0xA29570", VA = "0xA29570")]
		public void RecalculateMeshInstances()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xA29714", Offset = "0xA29714", VA = "0xA29714")]
		public void Draw(Transform transform)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xA29960", Offset = "0xA29960", VA = "0xA29960")]
		public void Draw(Transform transform, Material material)
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xA299D0", Offset = "0xA299D0", VA = "0xA299D0")]
		public void Draw(Matrix4x4 offset)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xA29778", Offset = "0xA29778", VA = "0xA29778")]
		public void Draw(Matrix4x4 offset, Material material)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xA29A14", Offset = "0xA29A14", VA = "0xA29A14")]
		public Prefab()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000196")]
	public class LevelMetaData
	{
		[Token(Token = "0x4000C98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint version;

		[Token(Token = "0x4000C99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000C9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint id;

		[Token(Token = "0x4000C9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BlockData[] birds;

		[Token(Token = "0x4000C9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool markedAsFinished;

		[Token(Token = "0x4000C9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float yRotation;

		[Token(Token = "0x4000C9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool[] enabledTelePoints;

		[Token(Token = "0x4000C9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int birdCount;

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xA257A4", Offset = "0xA257A4", VA = "0xA257A4")]
		public LevelMetaData(string levelName, uint id)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xA2590C", Offset = "0xA2590C", VA = "0xA2590C")]
		public LevelMetaData Clone()
		{
			return null;
		}
	}
	[Token(Token = "0x2000197")]
	public static class ArrayExtensions
	{
		[Token(Token = "0x6000723")]
		public static T RandomElement<T>(this IReadOnlyList<T> array)
		{
			return (T)null;
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xA21D8C", Offset = "0xA21D8C", VA = "0xA21D8C")]
		public static string CombineToList(this IReadOnlyList<string> list)
		{
			return null;
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xA21F90", Offset = "0xA21F90", VA = "0xA21F90")]
		public static string CombineToListWithNumbers(this IReadOnlyList<string> list)
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		public static void ReplaceWithLast<T>(this List<T> li, int i)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xA221F0", Offset = "0xA221F0", VA = "0xA221F0")]
		public static string FindNextLineStartingWith(this IReadOnlyList<string> list, string startsWith, int index = 0)
		{
			return null;
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xA223F8", Offset = "0xA223F8", VA = "0xA223F8")]
		public static string FindNextLineStartingWith(this IReadOnlyList<string> list, string startsWith, ref int index)
		{
			return null;
		}
	}
	[Token(Token = "0x2000198")]
	public static class BoundsExtensions
	{
		[Token(Token = "0x6000729")]
		[Address(RVA = "0xA2261C", Offset = "0xA2261C", VA = "0xA2261C")]
		public static Bounds Scale(this Bounds bounds, Vector3 scale)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xA226D0", Offset = "0xA226D0", VA = "0xA226D0")]
		public static Bounds Scale(this Bounds bounds, float scale)
		{
			return default(Bounds);
		}
	}
	[Token(Token = "0x2000199")]
	public static class ComponentExtensions
	{
		[Token(Token = "0x600072B")]
		public static T AddComponent<T>(this Component component) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xA227CC", Offset = "0xA227CC", VA = "0xA227CC")]
		public static Component AddComponent(this Component component, Type type)
		{
			return null;
		}

		[Token(Token = "0x600072D")]
		public static T GetOrAddComponent<T>(this Component component) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600072E")]
		public static void SetActive<T>(this T component, bool active) where T : Component
		{
		}

		[Token(Token = "0x600072F")]
		public static void SetActive<T>(this IReadOnlyList<T> component, bool active) where T : Component
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xA22818", Offset = "0xA22818", VA = "0xA22818")]
		public static void SetActive(this IReadOnlyList<GameObject> gameObjects, bool active)
		{
		}
	}
	[Token(Token = "0x200019A")]
	public static class EnumExtensions
	{
		[Token(Token = "0x6000731")]
		[Address(RVA = "0xA229A4", Offset = "0xA229A4", VA = "0xA229A4")]
		public static int GetLength(this Type enumType)
		{
			return default(int);
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xA22A24", Offset = "0xA22A24", VA = "0xA22A24")]
		public static int GetLength(this Enum enu)
		{
			return default(int);
		}

		[Token(Token = "0x6000733")]
		public static int GetLength<T>(T item) where T : Enum
		{
			return default(int);
		}

		[Token(Token = "0x6000734")]
		public static int GetLength<T>() where T : Enum
		{
			return default(int);
		}

		[Token(Token = "0x6000735")]
		public static int ToInt<T>(this T @enum) where T : Enum
		{
			return default(int);
		}

		[Token(Token = "0x6000736")]
		public static T ToEnum<T>(this int value) where T : Enum
		{
			return (T)null;
		}

		[Token(Token = "0x6000737")]
		public static T ToEnum<T>(this string value) where T : struct, Enum
		{
			return (T)null;
		}
	}
	[Token(Token = "0x200019B")]
	public static class FloatExtensions
	{
		[Token(Token = "0x6000738")]
		[Address(RVA = "0xA22AC4", Offset = "0xA22AC4", VA = "0xA22AC4")]
		public static float Snap(this float value, float snapValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xA22BAC", Offset = "0xA22BAC", VA = "0xA22BAC")]
		public static Vector3 ToVector3(this float value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xA22BE8", Offset = "0xA22BE8", VA = "0xA22BE8")]
		public static Vector2 ToVector2(this float value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xA22C18", Offset = "0xA22C18", VA = "0xA22C18")]
		public static Quaternion ToRotation(this float angle, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xA22CA8", Offset = "0xA22CA8", VA = "0xA22CA8")]
		public static float Sqr(this float value)
		{
			return default(float);
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xA22CB0", Offset = "0xA22CB0", VA = "0xA22CB0")]
		public static float Pow(this float value, float power)
		{
			return default(float);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xA22D24", Offset = "0xA22D24", VA = "0xA22D24")]
		public static float Cube(this float value)
		{
			return default(float);
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xA22D30", Offset = "0xA22D30", VA = "0xA22D30")]
		public static float Clamp(this float value, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xA22DB8", Offset = "0xA22DB8", VA = "0xA22DB8")]
		public static float Clamp01(this float value)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200019C")]
	public static class Matrix4x4Extensions
	{
		[Token(Token = "0x6000741")]
		[Address(RVA = "0xA26A54", Offset = "0xA26A54", VA = "0xA26A54")]
		public static Matrix4x4 SetScale(this Matrix4x4 matrix, float scale)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xA26BC4", Offset = "0xA26BC4", VA = "0xA26BC4")]
		public static Matrix4x4 MultiplyScale(this Matrix4x4 matrix, float scale)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xA26D54", Offset = "0xA26D54", VA = "0xA26D54")]
		public static Vector3 GetPosition(this Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xA26DF8", Offset = "0xA26DF8", VA = "0xA26DF8")]
		public static Quaternion GetRotation(this Matrix4x4 matrix)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xA26E00", Offset = "0xA26E00", VA = "0xA26E00")]
		public static Vector3 GetScale(this Matrix4x4 matrix)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200019D")]
	public static class QuaternionsExtensions
	{
		[Token(Token = "0x6000746")]
		[Address(RVA = "0xA2B98C", Offset = "0xA2B98C", VA = "0xA2B98C")]
		public static Vector3 ToAngularVelocity(this Quaternion delta)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xA28010", Offset = "0xA28010", VA = "0xA28010")]
		public static Quaternion GetDelta(this Quaternion rotation, Quaternion oldRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xA2BA54", Offset = "0xA2BA54", VA = "0xA2BA54")]
		public static Vector4 ToVector4(this Quaternion rotation)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xA2BA84", Offset = "0xA2BA84", VA = "0xA2BA84")]
		public static float GetAngle(this Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xA280E8", Offset = "0xA280E8", VA = "0xA280E8")]
		public static float GetAngle(this Quaternion rotation, Vector3 axis)
		{
			return default(float);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xA2BB1C", Offset = "0xA2BB1C", VA = "0xA2BB1C")]
		public static Quaternion Snap(this Quaternion quat, float degrees)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xA2BBD4", Offset = "0xA2BBD4", VA = "0xA2BBD4")]
		public static Quaternion Snap(this Quaternion quat, float degrees, Quaternion currentSnapRotation, float thresholdPercentage)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x200019E")]
	public static class StringExtensions
	{
		[Token(Token = "0x600074D")]
		[Address(RVA = "0xA28D40", Offset = "0xA28D40", VA = "0xA28D40")]
		public static int GetDeterministicHashCode(this string str)
		{
			return default(int);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xA2C1B0", Offset = "0xA2C1B0", VA = "0xA2C1B0")]
		public static string SplitCamelCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xA2C248", Offset = "0xA2C248", VA = "0xA2C248")]
		public static string FirstCharToUpper(this string input)
		{
			return null;
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xA2C3D0", Offset = "0xA2C3D0", VA = "0xA2C3D0")]
		public static string FindNextWord(this string str, int index)
		{
			return null;
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xA2C5C0", Offset = "0xA2C5C0", VA = "0xA2C5C0")]
		public static string FindNextWord(this string str, ref int index)
		{
			return null;
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xA2C4F4", Offset = "0xA2C4F4", VA = "0xA2C4F4")]
		public static int FindNextWhitespace(this string str, int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xA2C6EC", Offset = "0xA2C6EC", VA = "0xA2C6EC")]
		public static string FindFirstWordBetween(this string str, char c)
		{
			return null;
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xA2C7B8", Offset = "0xA2C7B8", VA = "0xA2C7B8")]
		public static string GetFileName(this string value, bool includeExtension = true)
		{
			return null;
		}
	}
	[Token(Token = "0x200019F")]
	public static class TransformExtensions
	{
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x9F2CE4", Offset = "0x9F2CE4", VA = "0x9F2CE4")]
		public static void SetActive(this Transform transform, bool active)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x9F2D30", Offset = "0x9F2D30", VA = "0x9F2D30")]
		public static void SetActive(this IList<Transform> transforms, bool active)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x9F2EC4", Offset = "0x9F2EC4", VA = "0x9F2EC4")]
		public static void DestroyAllChildren(this Transform transform)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x9F2F9C", Offset = "0x9F2F9C", VA = "0x9F2F9C")]
		public static void DestroyAllChildren(this Transform transform, bool pooling)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x9F2FA0", Offset = "0x9F2FA0", VA = "0x9F2FA0")]
		public static void DestroyImmediateAllChildren(this Transform transform)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x9F3078", Offset = "0x9F3078", VA = "0x9F3078")]
		public static Transform FindChildByName(this Transform transform, string name)
		{
			return null;
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x9F31C8", Offset = "0x9F31C8", VA = "0x9F31C8")]
		public static void Mirror(this Transform transform, InstantiateData data, bool setParent = true)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x9F331C", Offset = "0x9F331C", VA = "0x9F331C")]
		public static void Mirror(this Transform target, Transform toCopy, bool setParent = true)
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x9F3678", Offset = "0x9F3678", VA = "0x9F3678")]
		public static void Mirror(this Transform target, Matrix4x4 toCopy, Space space = Space.Self)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x9F3534", Offset = "0x9F3534", VA = "0x9F3534")]
		public static void SetLossyScale(this Transform transform, Vector3 lossyScale)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x9F38D4", Offset = "0x9F38D4", VA = "0x9F38D4")]
		public static void Reset(this Transform transform)
		{
		}
	}
	[Token(Token = "0x20001A0")]
	public static class Vector3Extensions
	{
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x9FDB70", Offset = "0x9FDB70", VA = "0x9FDB70")]
		public static Vector3 ToVector3_XZ(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x9FDB78", Offset = "0x9FDB78", VA = "0x9FDB78")]
		public static Vector3 ToVector3_XY(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x9FDB80", Offset = "0x9FDB80", VA = "0x9FDB80")]
		public static Vector3 ToVector3_YZ(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x9FDB88", Offset = "0x9FDB88", VA = "0x9FDB88")]
		public static Vector2 ToVector2_XZ(this Vector3 vector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x9FDBB8", Offset = "0x9FDBB8", VA = "0x9FDBB8")]
		public static Vector2 ToVector2_XY(this Vector3 vector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x9FDBE4", Offset = "0x9FDBE4", VA = "0x9FDBE4")]
		public static Vector2 ToVector2_YZ(this Vector3 vector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x9FDC18", Offset = "0x9FDC18", VA = "0x9FDC18")]
		public static Vector3 ClampMagnitudeXZ(this Vector3 vector, float magnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x9FDCB0", Offset = "0x9FDCB0", VA = "0x9FDCB0")]
		public static Vector3 ClampMagnitudeXY(this Vector3 vector, float magnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x9FDD48", Offset = "0x9FDD48", VA = "0x9FDD48")]
		public static Vector3 ClampMagnitudeYZ(this Vector3 vector, float magnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x9FDDE0", Offset = "0x9FDDE0", VA = "0x9FDDE0")]
		public static Vector3 Snap(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x9FDFE0", Offset = "0x9FDFE0", VA = "0x9FDFE0")]
		public static Vector3 Snap(this Vector3 vector, float snapValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x9FE0A4", Offset = "0x9FE0A4", VA = "0x9FE0A4")]
		public static Vector3 Snap(this Vector3 vector, float snapValue, Vector3 currentSnapValue, float thresholdPercentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x9FE354", Offset = "0x9FE354", VA = "0x9FE354")]
		public static Vector3 ScaleLink(this Vector3 target, Vector3 other)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20001A1")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x766D04", Offset = "0x766D04")]
	public class Init : MonoBehaviour
	{
		[Token(Token = "0x4000CA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Init instance;

		[Token(Token = "0x4000CA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool isClosingGame;

		[Token(Token = "0x1700003F")]
		private static Init Instance
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0xA22E28", Offset = "0xA22E28", VA = "0xA22E28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public static bool IsClosingGame
		{
			[Token(Token = "0x600076E")]
			[Address(RVA = "0xA22F88", Offset = "0xA22F88", VA = "0xA22F88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xA22FF0", Offset = "0xA22FF0", VA = "0xA22FF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xA23134", Offset = "0xA23134", VA = "0xA23134")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xA231A0", Offset = "0xA231A0", VA = "0xA231A0")]
		public Init()
		{
		}
	}
	[Token(Token = "0x20001A2")]
	public class LevelEditorScene : MonoBehaviour
	{
		[Token(Token = "0x4000CA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x769240", Offset = "0x769240")]
		private static Transform <LevelParent>k__BackingField;

		[Token(Token = "0x17000041")]
		public static Transform LevelParent
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0xA26618", Offset = "0xA26618", VA = "0xA26618")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76BAD0", Offset = "0x76BAD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000774")]
			[Address(RVA = "0xA26680", Offset = "0xA26680", VA = "0xA26680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76BAE0", Offset = "0x76BAE0")]
			set
			{
			}
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xA266EC", Offset = "0xA266EC", VA = "0xA266EC")]
		public LevelEditorScene()
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public class Platform : MonoBehaviour, VRGrabInterface
	{
		[Token(Token = "0x4000CA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "Readonly", RVA = "0x769250", Offset = "0x769250")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x769250", Offset = "0x769250")]
		private float scale;

		[Token(Token = "0x4000CA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform parent;

		[Token(Token = "0x4000CA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRGrab hand;

		[Token(Token = "0x4000CA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PositionRotation positionRotation;

		[Token(Token = "0x17000042")]
		private MonoBehaviour LevelEditorAPI.VR.VRGrabInterface.Mono
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0xA27628", Offset = "0xA27628", VA = "0xA27628", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xA26E08", Offset = "0xA26E08", VA = "0xA26E08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xA27040", Offset = "0xA27040", VA = "0xA27040")]
		public void Update()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xA270E4", Offset = "0xA270E4", VA = "0xA270E4")]
		private void Rotate(float deltaTime)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xA27234", Offset = "0xA27234", VA = "0xA27234")]
		private void Scale(float deltaTime)
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xA2762C", Offset = "0xA2762C", VA = "0xA2762C", Slot = "5")]
		private bool LevelEditorAPI.VR.VRGrabInterface.CanGrab(VRGrab grab)
		{
			return default(bool);
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xA27634", Offset = "0xA27634", VA = "0xA27634", Slot = "6")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrab(VRGrab grab)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xA27708", Offset = "0xA27708", VA = "0xA27708", Slot = "7")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrabUpdate(VRGrab grab, float input, float deltaTime)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xA27934", Offset = "0xA27934", VA = "0xA27934", Slot = "8")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnRelease(VRGrab grab)
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xA2793C", Offset = "0xA2793C", VA = "0xA2793C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xA27C2C", Offset = "0xA27C2C", VA = "0xA27C2C")]
		public Platform()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	public class PlatformHandleRotation : MonoBehaviour, VRGrabInterface
	{
		[Token(Token = "0x4000CA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 axis;

		[Token(Token = "0x4000CA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion oldRotation;

		[Token(Token = "0x4000CA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform parent;

		[Token(Token = "0x4000CAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform editingPlatform;

		[Token(Token = "0x4000CAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public VRGrab currentGrab;

		[Token(Token = "0x4000CAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int index;

		[Token(Token = "0x4000CAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float deltaTimeToFixed;

		[Token(Token = "0x4000CAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion storedInertia;

		[Token(Token = "0x4000CAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] inertiaArray;

		[Token(Token = "0x4000CB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion inertia;

		[Token(Token = "0x4000CB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool doLateUpdate;

		[Token(Token = "0x17000043")]
		private Quaternion AverageInertia
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0xA27C34", Offset = "0xA27C34", VA = "0xA27C34")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000044")]
		private MonoBehaviour LevelEditorAPI.VR.VRGrabInterface.Mono
		{
			[Token(Token = "0x6000785")]
			[Address(RVA = "0xA28220", Offset = "0xA28220", VA = "0xA28220", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xA27DA0", Offset = "0xA27DA0", VA = "0xA27DA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xA27E08", Offset = "0xA27E08", VA = "0xA27E08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xA28224", Offset = "0xA28224", VA = "0xA28224", Slot = "5")]
		private bool LevelEditorAPI.VR.VRGrabInterface.CanGrab(VRGrab grab)
		{
			return default(bool);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xA2822C", Offset = "0xA2822C", VA = "0xA2822C", Slot = "6")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrab(VRGrab grab)
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xA284DC", Offset = "0xA284DC", VA = "0xA284DC", Slot = "7")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrabUpdate(VRGrab grab, float input, float deltaTime)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xA288DC", Offset = "0xA288DC", VA = "0xA288DC", Slot = "8")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnRelease(VRGrab grab)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xA28A3C", Offset = "0xA28A3C", VA = "0xA28A3C")]
		public PlatformHandleRotation()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public struct InstantiateData
	{
		[Token(Token = "0x4000CB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x4000CB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion rotation;

		[Token(Token = "0x4000CB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3? scale;

		[Token(Token = "0x4000CB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform parent;

		[Token(Token = "0x17000045")]
		public static InstantiateData Default
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0xA24FC4", Offset = "0xA24FC4", VA = "0xA24FC4")]
			get
			{
				return default(InstantiateData);
			}
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x7D8D84", Offset = "0x7D8D84", VA = "0x7D8D84")]
		public InstantiateData(Vector3 position)
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x7D8D8C", Offset = "0x7D8D8C", VA = "0x7D8D8C")]
		public InstantiateData(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x7D8DAC", Offset = "0x7D8DAC", VA = "0x7D8DAC")]
		public InstantiateData(Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x7D8DC4", Offset = "0x7D8DC4", VA = "0x7D8DC4")]
		public InstantiateData(Vector3 position, Quaternion rotation, Transform parent)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x7D8DE4", Offset = "0x7D8DE4", VA = "0x7D8DE4")]
		public InstantiateData(Transform parent)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x7D8DEC", Offset = "0x7D8DEC", VA = "0x7D8DEC")]
		public InstantiateData(Vector3 position, Quaternion rotation, Vector3? scale, Transform parent)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x7D8E0C", Offset = "0x7D8E0C", VA = "0x7D8E0C")]
		public InstantiateData SetParent(Transform parent)
		{
			return default(InstantiateData);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x7D8E30", Offset = "0x7D8E30", VA = "0x7D8E30")]
		public InstantiateData SetPosition(Vector3 position)
		{
			return default(InstantiateData);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x7D8E5C", Offset = "0x7D8E5C", VA = "0x7D8E5C")]
		public InstantiateData SetRotation(Quaternion rotation)
		{
			return default(InstantiateData);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x7D8E88", Offset = "0x7D8E88", VA = "0x7D8E88")]
		public InstantiateData SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
			return default(InstantiateData);
		}
	}
	[Token(Token = "0x20001A6")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x766D40", Offset = "0x766D40")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x766D40", Offset = "0x766D40")]
	public class PrefabDatabase : SingletonScriptableObject<PrefabDatabase>, IPrefabDatabase
	{
		[Token(Token = "0x4000CB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Prefab> items;

		[Token(Token = "0x4000CB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, Prefab> prefabLookUp;

		[Token(Token = "0x17000046")]
		protected override bool KeepInResources
		{
			[Token(Token = "0x6000796")]
			[Address(RVA = "0xA29A88", Offset = "0xA29A88", VA = "0xA29A88", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		protected override bool AllowAssignInstance
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0xA29A90", Offset = "0xA29A90", VA = "0xA29A90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		public Prefab Item
		{
			[Token(Token = "0x6000799")]
			[Address(RVA = "0xA29C2C", Offset = "0xA29C2C", VA = "0xA29C2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public Prefab Item
		{
			[Token(Token = "0x600079A")]
			[Address(RVA = "0xA29C9C", Offset = "0xA29C9C", VA = "0xA29C9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public int Length
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0xA29DA4", Offset = "0xA29DA4", VA = "0xA29DA4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004B")]
		public IPrefabDatabase Edit
		{
			[Token(Token = "0x600079C")]
			[Address(RVA = "0xA29E04", Offset = "0xA29E04", VA = "0xA29E04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xA29A98", Offset = "0xA29A98", VA = "0xA29A98", Slot = "6")]
		protected override void OnSingletonCreation()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xA255DC", Offset = "0xA255DC", VA = "0xA255DC")]
		public bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xA29E08", Offset = "0xA29E08", VA = "0xA29E08")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x76BAF0", Offset = "0x76BAF0")]
		public void Editor_Initialize()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xA29E80", Offset = "0xA29E80", VA = "0xA29E80")]
		public Prefab GetPrefabById(int id)
		{
			return null;
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xA29F28", Offset = "0xA29F28", VA = "0xA29F28")]
		public Prefab GetPrefabByIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xA29FB8", Offset = "0xA29FB8", VA = "0xA29FB8")]
		public Prefab GetPrefabByName(string name)
		{
			return null;
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xA29FBC", Offset = "0xA29FBC", VA = "0xA29FBC")]
		public bool HasId(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xA29D34", Offset = "0xA29D34", VA = "0xA29D34")]
		public bool HasId(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xA29FE8", Offset = "0xA29FE8", VA = "0xA29FE8")]
		public bool IsNull(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xA2A014", Offset = "0xA2A014", VA = "0xA2A014")]
		public bool IsNull(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xA2A0E0", Offset = "0xA2A0E0", VA = "0xA2A0E0")]
		public bool HasGameObject(GameObject gameObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xA2A1B4", Offset = "0xA2A1B4", VA = "0xA2A1B4")]
		public bool HasGameObject(GameObject gameObject, out int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xA2A294", Offset = "0xA2A294", VA = "0xA2A294")]
		public int GetId(GameObject gameObject)
		{
			return default(int);
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xA2A3A8", Offset = "0xA2A3A8", VA = "0xA2A3A8")]
		public int GetIndex(GameObject gameObject)
		{
			return default(int);
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xA2A47C", Offset = "0xA2A47C", VA = "0xA2A47C")]
		public static int NameToId(string name)
		{
			return default(int);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xA1607C", Offset = "0xA1607C", VA = "0xA1607C")]
		public static Prefab GetPrefab(int id)
		{
			return null;
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xA2A480", Offset = "0xA2A480", VA = "0xA2A480")]
		public static Prefab GetPrefab(string name)
		{
			return null;
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xA2A4E4", Offset = "0xA2A4E4", VA = "0xA2A4E4")]
		public static bool HasIdCheck(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xA2A548", Offset = "0xA2A548", VA = "0xA2A548")]
		public static bool HasIdCheck(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xA2A5B4", Offset = "0xA2A5B4", VA = "0xA2A5B4")]
		public static bool IsNullCheck(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xA2A618", Offset = "0xA2A618", VA = "0xA2A618")]
		public static bool IsNullCheck(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xA2A684", Offset = "0xA2A684", VA = "0xA2A684")]
		public static void Destroy(GameObject gameObject)
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xA2A760", Offset = "0xA2A760", VA = "0xA2A760")]
		public static void Destroy(GameObject gameObject, Prefab prefab)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xA2A78C", Offset = "0xA2A78C", VA = "0xA2A78C")]
		public static void Destroy(GameObject gameObject, int prefabId)
		{
		}

		[Token(Token = "0x60007B4")]
		public static void Destroy<T>(T component) where T : Component
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xA2A858", Offset = "0xA2A858", VA = "0xA2A858", Slot = "8")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.AddItem(Prefab prefab)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xA2A978", Offset = "0xA2A978", VA = "0xA2A978", Slot = "9")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.AddItems(IReadOnlyList<Prefab> prefabs)
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xA2AB44", Offset = "0xA2AB44", VA = "0xA2AB44", Slot = "10")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.RemoveItem(Prefab prefab)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xA2AC44", Offset = "0xA2AC44", VA = "0xA2AC44", Slot = "11")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.RemoveItem(int id)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xA2AD24", Offset = "0xA2AD24", VA = "0xA2AD24", Slot = "12")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.RemoveItem(string name)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xA2ADF4", Offset = "0xA2ADF4", VA = "0xA2ADF4", Slot = "13")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.RemoveItemByIndex(int index)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xA2AF24", Offset = "0xA2AF24", VA = "0xA2AF24", Slot = "14")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.Clear()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xA2AFA8", Offset = "0xA2AFA8", VA = "0xA2AFA8", Slot = "15")]
		private Prefab LevelEditorAPI.InternalPrefab.IPrefabDatabase.GetItemByIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xA2B018", Offset = "0xA2B018", VA = "0xA2B018", Slot = "16")]
		private void LevelEditorAPI.InternalPrefab.IPrefabDatabase.SetItemByIndex(int index, Prefab prefab)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xA2B090", Offset = "0xA2B090", VA = "0xA2B090")]
		public Prefab[] Where(Func<Prefab, bool> predicate)
		{
			return null;
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xA2B100", Offset = "0xA2B100", VA = "0xA2B100")]
		public PrefabDatabase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001A7")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x766DD8", Offset = "0x766DD8")]
	public class PlatformSettings : SingletonScriptableObject<PlatformSettings>
	{
		[Token(Token = "0x2000267")]
		[Flags]
		public enum MovementMode
		{
			[Token(Token = "0x4000F3C")]
			None = 0,
			[Token(Token = "0x4000F3D")]
			Flat_XZ = 1,
			[Token(Token = "0x4000F3E")]
			Pole_Y = 2,
			[Token(Token = "0x4000F3F")]
			Free_XYZ = 3
		}

		[Token(Token = "0x2000268")]
		public enum RotationMode
		{
			[Token(Token = "0x4000F41")]
			None,
			[Token(Token = "0x4000F42")]
			HandleOnly,
			[Token(Token = "0x4000F43")]
			FreeRotation
		}

		[Token(Token = "0x4000CB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7692BC", Offset = "0x7692BC")]
		[SerializeField]
		private MovementMode movementMode;

		[Token(Token = "0x4000CB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x769308", Offset = "0x769308")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x4000CBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool recordInertiaOnHandle;

		[Token(Token = "0x4000CBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool inverse;

		[Token(Token = "0x4000CBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x769374", Offset = "0x769374")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x769374", Offset = "0x769374")]
		private float platformRotationSpeed;

		[Token(Token = "0x4000CBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7693DC", Offset = "0x7693DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7693DC", Offset = "0x7693DC")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7693DC", Offset = "0x7693DC")]
		private float startScale;

		[Token(Token = "0x4000CBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x769464", Offset = "0x769464")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x769464", Offset = "0x769464")]
		private float platfromScaleSpeed;

		[Token(Token = "0x4000CBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7694C8", Offset = "0x7694C8")]
		[SerializeField]
		private AnimationCurve platformScaleCurve;

		[Token(Token = "0x1700004C")]
		protected override bool AllowAssignInstance
		{
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0xA28B0C", Offset = "0xA28B0C", VA = "0xA28B0C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		public bool AllowMovementXZ
		{
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xA277E4", Offset = "0xA277E4", VA = "0xA277E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public bool AllowMovementY
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0xA27884", Offset = "0xA27884", VA = "0xA27884")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		public bool IsFreeMovement
		{
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0xA28B64", Offset = "0xA28B64", VA = "0xA28B64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		public bool AllowFreeRotation
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0xA27924", Offset = "0xA27924", VA = "0xA27924")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		public bool AllowHandleRotation
		{
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0xA270D4", Offset = "0xA270D4", VA = "0xA270D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000052")]
		public bool RecordInertia
		{
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0xA284D4", Offset = "0xA284D4", VA = "0xA284D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public float PlatformRotationSpeed
		{
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0xA28B74", Offset = "0xA28B74", VA = "0xA28B74")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000054")]
		public float PlatformStartScale
		{
			[Token(Token = "0x60007C9")]
			[Address(RVA = "0xA26F3C", Offset = "0xA26F3C", VA = "0xA26F3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000055")]
		public float PlatformScaleSpeed
		{
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xA28B7C", Offset = "0xA28B7C", VA = "0xA28B7C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000056")]
		public AnimationCurve PlatformScaleCurve
		{
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0xA28B84", Offset = "0xA28B84", VA = "0xA28B84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xA28B14", Offset = "0xA28B14", VA = "0xA28B14")]
		public void Assign()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xA27508", Offset = "0xA27508", VA = "0xA27508")]
		public Quaternion GetRotation(Quaternion rotation, float deltaTime, float input)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xA26F44", Offset = "0xA26F44", VA = "0xA26F44")]
		public Vector3 GetScale(ref float scale, float deltaTime, float input)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xA27338", Offset = "0xA27338", VA = "0xA27338")]
		public void SetScaleToFitCurve(ref float scale)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xA28B8C", Offset = "0xA28B8C", VA = "0xA28B8C")]
		public void SetMovementMode(MovementMode mode)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xA28B94", Offset = "0xA28B94", VA = "0xA28B94")]
		public void SetRotationMode(RotationMode mode)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xA28B9C", Offset = "0xA28B9C", VA = "0xA28B9C")]
		public void SetInertiaOnHandle(bool active)
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xA28BA8", Offset = "0xA28BA8", VA = "0xA28BA8")]
		public void SetPlatformRotationSpeed(float degreesPerSecond, bool inverse = true)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xA28C30", Offset = "0xA28C30", VA = "0xA28C30")]
		public void SetPlatformScaleSpeed(float value)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xA28C38", Offset = "0xA28C38", VA = "0xA28C38")]
		public void SetPlatformScaleCurve(AnimationCurve curve)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xA28C40", Offset = "0xA28C40", VA = "0xA28C40")]
		public PlatformSettings()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x766E48", Offset = "0x766E48")]
	public class SceneSettings : SingletonScriptableObject<SceneSettings>
	{
		[Token(Token = "0x4000CC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "Readonly", RVA = "0x769514", Offset = "0x769514")]
		private bool forceDisableAllScenes;

		[Token(Token = "0x4000CC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		[AttributeAttribute(Name = "Readonly", RVA = "0x769550", Offset = "0x769550")]
		private bool setEditorSceneActive;

		[NonSerialized]
		[Token(Token = "0x4000CC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Scene nonLevelEditor;

		[Token(Token = "0x17000057")]
		protected override bool AllowAssignInstance
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0xA2BCF4", Offset = "0xA2BCF4", VA = "0xA2BCF4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		public bool ForceDisableAllScenes
		{
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0xA2BD4C", Offset = "0xA2BD4C", VA = "0xA2BD4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		public bool SetEditorSceneActive
		{
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0xA2BD54", Offset = "0xA2BD54", VA = "0xA2BD54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xA2BCFC", Offset = "0xA2BCFC", VA = "0xA2BCFC")]
		public void Assign()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xA2BD5C", Offset = "0xA2BD5C", VA = "0xA2BD5C")]
		public SceneSettings()
		{
		}
	}
	[Token(Token = "0x20001A9")]
	public static class Settings
	{
		[Token(Token = "0x1700005A")]
		public static VisualSettings Visual
		{
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0xA2BDB4", Offset = "0xA2BDB4", VA = "0xA2BDB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public static SnapSettings Snap
		{
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0xA2BDFC", Offset = "0xA2BDFC", VA = "0xA2BDFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public static PlatformSettings Platform
		{
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0xA26EF4", Offset = "0xA26EF4", VA = "0xA26EF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public static SceneSettings Scene
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0xA2BE44", Offset = "0xA2BE44", VA = "0xA2BE44")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Token(Token = "0x20001AA")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x766EB8", Offset = "0x766EB8")]
	public class SnapSettings : SingletonScriptableObject<SnapSettings>
	{
		[Token(Token = "0x4000CC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x76958C", Offset = "0x76958C")]
		[SerializeField]
		private bool useSnap;

		[Token(Token = "0x4000CC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool useDeadzone;

		[Token(Token = "0x4000CC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool useGroundCalculation;

		[Token(Token = "0x4000CC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private SnapPhysicsMode physicsMode;

		[Token(Token = "0x4000CC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x769608", Offset = "0x769608")]
		[SerializeField]
		private float gridSnapSize;

		[Token(Token = "0x4000CC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float maxSweepTestDistance;

		[Token(Token = "0x4000CC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x769664", Offset = "0x769664")]
		private float gridSnapDeadzone;

		[Token(Token = "0x4000CCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7696A4", Offset = "0x7696A4")]
		[SerializeField]
		private float rotationSnapDegrees;

		[Token(Token = "0x4000CCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7696F0", Offset = "0x7696F0")]
		private float rotationSnapDeadzone;

		[Token(Token = "0x1700005E")]
		protected override bool AllowAssignInstance
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0xA2BE8C", Offset = "0xA2BE8C", VA = "0xA2BE8C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		public SnapPhysicsMode PhysicsMode
		{
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0xA2BEE4", Offset = "0xA2BEE4", VA = "0xA2BEE4")]
			get
			{
				return default(SnapPhysicsMode);
			}
		}

		[Token(Token = "0x17000060")]
		public bool UseSnap
		{
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0xA2BEEC", Offset = "0xA2BEEC", VA = "0xA2BEEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		public bool UseDeadzone
		{
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0xA2BEF4", Offset = "0xA2BEF4", VA = "0xA2BEF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000062")]
		public bool UseGroundCalculation
		{
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0xA2BEFC", Offset = "0xA2BEFC", VA = "0xA2BEFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000063")]
		public float GridSnapSize
		{
			[Token(Token = "0x60007E5")]
			[Address(RVA = "0xA2BF04", Offset = "0xA2BF04", VA = "0xA2BF04")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000064")]
		public float GridSnapDeadzone
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0xA2BF0C", Offset = "0xA2BF0C", VA = "0xA2BF0C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000065")]
		public float RotationSnapDegrees
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0xA2BF14", Offset = "0xA2BF14", VA = "0xA2BF14")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000066")]
		public float RotationSnapDeadzone
		{
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0xA2BF1C", Offset = "0xA2BF1C", VA = "0xA2BF1C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xA2BE94", Offset = "0xA2BE94", VA = "0xA2BE94")]
		public void Assign()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xA2BF24", Offset = "0xA2BF24", VA = "0xA2BF24")]
		public Vector3 GridSnap(Vector3 currentPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xA2BF30", Offset = "0xA2BF30", VA = "0xA2BF30")]
		public Vector3 GridSnap(Vector3 currentPosition, Vector3 oldSnapPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xA2BF4C", Offset = "0xA2BF4C", VA = "0xA2BF4C")]
		public Quaternion RotationSnap(Quaternion currentRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xA2BF54", Offset = "0xA2BF54", VA = "0xA2BF54")]
		public Quaternion RotationSnap(Quaternion currentRotation, Quaternion oldRotationSnap)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xA1C7A8", Offset = "0xA1C7A8", VA = "0xA1C7A8")]
		public bool Snap(GhostComponent ghost, Transform transform, Vector3 position, Quaternion rotation, LevelBuildingBlock block)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xA2BF84", Offset = "0xA2BF84", VA = "0xA2BF84")]
		public void SetSnap(bool active)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xA2BF90", Offset = "0xA2BF90", VA = "0xA2BF90")]
		public void SetDeadzone(bool active)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xA2BF9C", Offset = "0xA2BF9C", VA = "0xA2BF9C")]
		public void SetGroundCalculations(bool active)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xA2BFA8", Offset = "0xA2BFA8", VA = "0xA2BFA8")]
		public void SetPhysicsMode(SnapPhysicsMode mode)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xA2BFB0", Offset = "0xA2BFB0", VA = "0xA2BFB0")]
		public void SetGridSize(float value)
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xA2C030", Offset = "0xA2C030", VA = "0xA2C030")]
		public void SetGridDeadzone(float value)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xA2C0AC", Offset = "0xA2C0AC", VA = "0xA2C0AC")]
		public void SetRotationDegrees(float degrees)
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xA2C0B4", Offset = "0xA2C0B4", VA = "0xA2C0B4")]
		public void SetRotationDeadzone(float value)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xA2C130", Offset = "0xA2C130", VA = "0xA2C130")]
		public SnapSettings()
		{
		}
	}
	[Token(Token = "0x20001AB")]
	public enum SnapPhysicsMode
	{
		[Token(Token = "0x4000CCD")]
		None,
		[Token(Token = "0x4000CCE")]
		Visual,
		[Token(Token = "0x4000CCF")]
		Revert
	}
	[Serializable]
	[Token(Token = "0x20001AC")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x766F28", Offset = "0x766F28")]
	public class VisualSettings : SingletonScriptableObject<VisualSettings>
	{
		[Token(Token = "0x2000269")]
		public enum RenderSetting
		{
			[Token(Token = "0x4000F45")]
			Normal,
			[Token(Token = "0x4000F46")]
			Wireframe,
			[Token(Token = "0x4000F47")]
			Ghost,
			[Token(Token = "0x4000F48")]
			Hidden
		}

		[Token(Token = "0x4000CD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x769730", Offset = "0x769730")]
		[SerializeField]
		private RenderSetting grabbedMainRenderSetting;

		[Token(Token = "0x4000CD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RenderSetting grabbedSubRenderSetting;

		[Token(Token = "0x4000CD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x76978C", Offset = "0x76978C")]
		[SerializeField]
		private RenderSetting nonGrabbedRenderingSetting;

		[Token(Token = "0x4000CD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7697D8", Offset = "0x7697D8")]
		[SerializeField]
		private Material wireframe;

		[Token(Token = "0x4000CD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Material hidden;

		[Token(Token = "0x4000CD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Material ghost;

		[Token(Token = "0x4000CD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Material hover;

		[Token(Token = "0x4000CD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool useHoverRendering;

		[Token(Token = "0x4000CD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x769864", Offset = "0x769864")]
		[SerializeField]
		private Material blockIntersection;

		[Token(Token = "0x4000CD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Material blockSelected;

		[Token(Token = "0x17000067")]
		protected override bool AllowAssignInstance
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x9FE394", Offset = "0x9FE394", VA = "0x9FE394", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		public Material Wireframe
		{
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x9FE3EC", Offset = "0x9FE3EC", VA = "0x9FE3EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public Material Hidden
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x9FE3F4", Offset = "0x9FE3F4", VA = "0x9FE3F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public Material Ghost
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x9FE3FC", Offset = "0x9FE3FC", VA = "0x9FE3FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public Material OnHoverMaterial
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x9FE404", Offset = "0x9FE404", VA = "0x9FE404")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public bool UseHoverRendering
		{
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x9FE40C", Offset = "0x9FE40C", VA = "0x9FE40C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public Material BlockIntersection
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x9FE414", Offset = "0x9FE414", VA = "0x9FE414")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public Material BlockSelected
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x9FE41C", Offset = "0x9FE41C", VA = "0x9FE41C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public Material NonGrabbed
		{
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x9FE424", Offset = "0x9FE424", VA = "0x9FE424")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public Material GrabbedMainObject
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x9FE464", Offset = "0x9FE464", VA = "0x9FE464")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public Material GrabbedSubObject
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x9FE4A4", Offset = "0x9FE4A4", VA = "0x9FE4A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x9FE39C", Offset = "0x9FE39C", VA = "0x9FE39C")]
		public void Assign()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x9FE4E4", Offset = "0x9FE4E4", VA = "0x9FE4E4")]
		public void InvertGrabbedRenderingMode()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x9FE4F0", Offset = "0x9FE4F0", VA = "0x9FE4F0")]
		public void SetGrabbedRenderingSetting(bool main, RenderSetting setting)
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x9FE504", Offset = "0x9FE504", VA = "0x9FE504")]
		public void SetNonGrabbedRenderingSetting(RenderSetting setting)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x9FE50C", Offset = "0x9FE50C", VA = "0x9FE50C")]
		public VisualSettings()
		{
		}
	}
	[Token(Token = "0x20001AD")]
	public class SingletonScriptableObject<T> : ScriptableObject where T : SingletonScriptableObject<T>
	{
		[Token(Token = "0x4000CDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T instance;

		[Token(Token = "0x17000072")]
		public static T Instance
		{
			[Token(Token = "0x6000807")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000808")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public static bool HasInstance
		{
			[Token(Token = "0x6000809")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		protected virtual bool KeepInResources
		{
			[Token(Token = "0x600080A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		protected virtual bool AllowAssignInstance
		{
			[Token(Token = "0x600080B")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600080C")]
		protected void AssignInstance(T newInstance)
		{
		}

		[Token(Token = "0x600080D")]
		protected virtual void OnSingletonCreation()
		{
		}

		[Token(Token = "0x600080E")]
		protected virtual void OnSingletonRemoved()
		{
		}

		[Token(Token = "0x600080F")]
		public SingletonScriptableObject()
		{
		}
	}
	[Token(Token = "0x20001AE")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x766F98", Offset = "0x766F98")]
	[ExecuteInEditMode]
	public class PrefabMeshDrawer : MonoBehaviour
	{
		[Token(Token = "0x4000CDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject prefab;

		[Token(Token = "0x4000CDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7698BC", Offset = "0x7698BC")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000CDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Material overrideMaterial;

		[Token(Token = "0x4000CDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MeshDrawerInstance[] meshDrawerInstances;

		[Token(Token = "0x17000076")]
		public GameObject GameObject
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0xA2B1A0", Offset = "0xA2B1A0", VA = "0xA2B1A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000811")]
			[Address(RVA = "0xA2B1A8", Offset = "0xA2B1A8", VA = "0xA2B1A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public Material OverrideMaterial
		{
			[Token(Token = "0x6000812")]
			[Address(RVA = "0xA2B24C", Offset = "0xA2B24C", VA = "0xA2B24C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000813")]
			[Address(RVA = "0xA2B254", Offset = "0xA2B254", VA = "0xA2B254")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public bool HasOverrideMaterial
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0xA2B264", Offset = "0xA2B264", VA = "0xA2B264")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000079")]
		public Transform Target
		{
			[Token(Token = "0x6000815")]
			[Address(RVA = "0xA2B2D4", Offset = "0xA2B2D4", VA = "0xA2B2D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000816")]
			[Address(RVA = "0xA2B364", Offset = "0xA2B364", VA = "0xA2B364")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public MeshDrawerInstance[] MeshDrawerInstances
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0xA2B36C", Offset = "0xA2B36C", VA = "0xA2B36C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xA2B374", Offset = "0xA2B374", VA = "0xA2B374")]
		private void ValidateMeshDrawerInstance()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xA2B41C", Offset = "0xA2B41C", VA = "0xA2B41C")]
		private void Start()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xA2B420", Offset = "0xA2B420", VA = "0xA2B420")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xA2B5C8", Offset = "0xA2B5C8", VA = "0xA2B5C8")]
		public void Draw()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xA2B428", Offset = "0xA2B428", VA = "0xA2B428")]
		public void Draw(Material material)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xA2B5D0", Offset = "0xA2B5D0", VA = "0xA2B5D0")]
		public void Draw(Material material, Matrix4x4 offset)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xA2B8CC", Offset = "0xA2B8CC", VA = "0xA2B8CC")]
		public void Assign(GameObject gameObject)
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xA2B1AC", Offset = "0xA2B1AC", VA = "0xA2B1AC")]
		public void SetGameObject(GameObject gameObject)
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xA2B8D0", Offset = "0xA2B8D0", VA = "0xA2B8D0")]
		public void Unload()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xA2B8DC", Offset = "0xA2B8DC", VA = "0xA2B8DC")]
		public GameObject GetGameObject()
		{
			return null;
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xA2B25C", Offset = "0xA2B25C", VA = "0xA2B25C")]
		public void SetOverrideMaterial(Material material)
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xA2B8E4", Offset = "0xA2B8E4", VA = "0xA2B8E4")]
		public Material GetOverrideMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xA2B8EC", Offset = "0xA2B8EC", VA = "0xA2B8EC")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xA2B8F4", Offset = "0xA2B8F4", VA = "0xA2B8F4")]
		public Transform GetTarget()
		{
			return null;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xA2B8FC", Offset = "0xA2B8FC", VA = "0xA2B8FC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xA2B904", Offset = "0xA2B904", VA = "0xA2B904")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x76BB28", Offset = "0x76BB28")]
		public static void Editor_CreatePrefabMeshDrawer()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xA2B984", Offset = "0xA2B984", VA = "0xA2B984")]
		public PrefabMeshDrawer()
		{
		}
	}
	[Token(Token = "0x20001AF")]
	public class Readonly : PropertyAttribute
	{
		[Token(Token = "0x4000CDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool onlyActiveInRuntime;

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xA2BCBC", Offset = "0xA2BCBC", VA = "0xA2BCBC")]
		public Readonly()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xA2BCC4", Offset = "0xA2BCC4", VA = "0xA2BCC4")]
		public Readonly(bool onlyActiveInRuntime)
		{
		}
	}
	[Token(Token = "0x20001B0")]
	public class RGLinkedList<T>
	{
		[Token(Token = "0x4000CE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LinkedNode<T> node;

		[Token(Token = "0x4000CE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int length;

		[Token(Token = "0x1700007B")]
		public int Length
		{
			[Token(Token = "0x600082B")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600082C")]
		public LinkedNode<T> Add(T item)
		{
			return null;
		}

		[Token(Token = "0x600082D")]
		public LinkedNode<T> InsertAfter(T item, LinkedNode<T> node)
		{
			return null;
		}

		[Token(Token = "0x600082E")]
		public LinkedNode<T> InsertBefore(T item, LinkedNode<T> node)
		{
			return null;
		}

		[Token(Token = "0x600082F")]
		public void Remove(LinkedNode<T> node)
		{
		}

		[Token(Token = "0x6000830")]
		public void Remove(T obj)
		{
		}

		[Token(Token = "0x6000831")]
		public T First()
		{
			return (T)null;
		}

		[Token(Token = "0x6000832")]
		public T Last()
		{
			return (T)null;
		}

		[Token(Token = "0x6000833")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000834")]
		public LinkedNode<T> Find(T obj)
		{
			return null;
		}

		[Token(Token = "0x6000835")]
		public T[] ToArray()
		{
			return null;
		}

		[Token(Token = "0x6000836")]
		public List<T> ToList()
		{
			return null;
		}

		[Token(Token = "0x6000837")]
		public Iterator<T> GetIterator()
		{
			return default(Iterator<T>);
		}

		[Token(Token = "0x6000838")]
		public RGLinkedList()
		{
		}
	}
	[Token(Token = "0x20001B1")]
	public struct Iterator<T>
	{
		[Token(Token = "0x4000CE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LinkedNode<T> currentNode;

		[Token(Token = "0x4000CE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LinkedNode<T> startNode;

		[Token(Token = "0x6000839")]
		public Iterator(LinkedNode<T> startNode)
		{
		}

		[Token(Token = "0x600083A")]
		public bool Next(out LinkedNode<T> node)
		{
			return default(bool);
		}

		[Token(Token = "0x600083B")]
		public bool Next(out T node)
		{
			return default(bool);
		}

		[Token(Token = "0x600083C")]
		public void RemoveCurrent()
		{
		}
	}
	[Token(Token = "0x20001B2")]
	public class LinkedNode<T>
	{
		[Token(Token = "0x4000CE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Item;

		[Token(Token = "0x4000CE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RGLinkedList<T> List;

		[Token(Token = "0x4000CE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LinkedNode<T> Prev;

		[Token(Token = "0x4000CE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LinkedNode<T> Next;

		[Token(Token = "0x600083D")]
		public LinkedNode(T item, RGLinkedList<T> list)
		{
		}

		[Token(Token = "0x600083E")]
		public void InsertAfter(LinkedNode<T> node)
		{
		}

		[Token(Token = "0x600083F")]
		public void InsertBefore(LinkedNode<T> node)
		{
		}

		[Token(Token = "0x6000840")]
		public void Remove()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	public static class Sort
	{
		[Token(Token = "0x6000841")]
		public static void Merge<T>(IList<T> array, Comparison<T> comparison)
		{
		}
	}
	[Token(Token = "0x20001B4")]
	public static class Sort<T>
	{
		[Token(Token = "0x4000CE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T[] subArray;

		[Token(Token = "0x6000842")]
		public static void Merge(IList<T> array, Comparison<T> comparison)
		{
		}

		[Token(Token = "0x6000843")]
		private static void InternalMerge(IList<T> array, Comparison<T> comparison, int from, int to)
		{
		}
	}
	[Token(Token = "0x20001B5")]
	public static class SortExtensions
	{
		[Token(Token = "0x6000844")]
		public static void MergeSort<T>(this IList<T> array, Comparison<T> comparison)
		{
		}
	}
	[Serializable]
	[StructLayout(2)]
	[Token(Token = "0x20001B6")]
	public struct TextField : ISerializationCallbackReceiver
	{
		[Token(Token = "0x200026A")]
		private enum TextType
		{
			[Token(Token = "0x4000F4A")]
			None,
			[Token(Token = "0x4000F4B")]
			UI,
			[Token(Token = "0x4000F4C")]
			TextMesh,
			[Token(Token = "0x4000F4D")]
			TextMeshPro
		}

		[Token(Token = "0x4000CE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private UnityEngine.Object labelObject;

		[NonSerialized]
		[Token(Token = "0x4000CEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Text label;

		[NonSerialized]
		[Token(Token = "0x4000CEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TextMesh textMesh;

		[NonSerialized]
		[Token(Token = "0x4000CEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private TextType textType;

		[Token(Token = "0x1700007C")]
		public bool HasTextField
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x7D8F08", Offset = "0x7D8F08", VA = "0x7D8F08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007D")]
		public string Text
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x7D8F10", Offset = "0x7D8F10", VA = "0x7D8F10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x7D8F18", Offset = "0x7D8F18", VA = "0x7D8F18")]
			set
			{
			}
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x7D8F20", Offset = "0x7D8F20", VA = "0x7D8F20")]
		public TextField(Text label)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x7D8F30", Offset = "0x7D8F30", VA = "0x7D8F30")]
		public TextField(TextMesh textMesh)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xA2CACC", Offset = "0xA2CACC", VA = "0xA2CACC")]
		public static implicit operator TextField(Text label)
		{
			return default(TextField);
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xA2CAD4", Offset = "0xA2CAD4", VA = "0xA2CAD4")]
		public static implicit operator TextField(TextMesh label)
		{
			return default(TextField);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x7D8F40", Offset = "0x7D8F40", VA = "0x7D8F40", Slot = "4")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x7D8F44", Offset = "0x7D8F44", VA = "0x7D8F44", Slot = "5")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xA2CB88", Offset = "0xA2CB88", VA = "0xA2CB88")]
		public static TextField GetTextField(GameObject gameObject)
		{
			return default(TextField);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xA2CC90", Offset = "0xA2CC90", VA = "0xA2CC90")]
		public static TextField GetTextField(Component component)
		{
			return default(TextField);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xA2CCC0", Offset = "0xA2CCC0", VA = "0xA2CCC0")]
		public static TextField GetTextFieldInChildren(GameObject gameObject)
		{
			return default(TextField);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xA2CDC8", Offset = "0xA2CDC8", VA = "0xA2CDC8")]
		public static TextField GetTextFieldInChildren(Component component)
		{
			return default(TextField);
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xA2CDF8", Offset = "0xA2CDF8", VA = "0xA2CDF8")]
		public static TextField GetTextFieldInParent(GameObject gameObject)
		{
			return default(TextField);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xA2CF00", Offset = "0xA2CF00", VA = "0xA2CF00")]
		public static TextField GetTextFieldInParent(Component component)
		{
			return default(TextField);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xA2CF30", Offset = "0xA2CF30", VA = "0xA2CF30")]
		public static TextField[] GetTextFields(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xA2D0E0", Offset = "0xA2D0E0", VA = "0xA2D0E0")]
		public static TextField[] GetTextFields(Component component)
		{
			return null;
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xA2D110", Offset = "0xA2D110", VA = "0xA2D110")]
		public static TextField[] GetTextFieldsInChildren(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xA2D2C0", Offset = "0xA2D2C0", VA = "0xA2D2C0")]
		public static TextField[] GetTextFieldsInChildren(Component component)
		{
			return null;
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xA2D2F0", Offset = "0xA2D2F0", VA = "0xA2D2F0")]
		public static TextField[] GetTextFieldsInParent(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xA2D4A0", Offset = "0xA2D4A0", VA = "0xA2D4A0")]
		public static TextField[] GetTextFieldsInParent(Component component)
		{
			return null;
		}
	}
	[Token(Token = "0x20001B7")]
	public class UnityObjectFilter : PropertyAttribute
	{
		[Token(Token = "0x4000CED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type type;

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x9F3A10", Offset = "0x9F3A10", VA = "0x9F3A10")]
		public UnityObjectFilter(Type type)
		{
		}
	}
	[Token(Token = "0x20001B8")]
	public class UnityObjectFilterScene : PropertyAttribute
	{
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x9F3A3C", Offset = "0x9F3A3C", VA = "0x9F3A3C")]
		public UnityObjectFilterScene()
		{
		}
	}
}
namespace LevelEditorAPI.VR
{
	[Token(Token = "0x20001B9")]
	public enum VRHand
	{
		[Token(Token = "0x4000CEF")]
		None,
		[Token(Token = "0x4000CF0")]
		Left,
		[Token(Token = "0x4000CF1")]
		Right
	}
	[Token(Token = "0x20001BA")]
	public static class VRHandExtensions
	{
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x9FC6AC", Offset = "0x9FC6AC", VA = "0x9FC6AC")]
		public static XRNode ToXRNode(this VRHand hand)
		{
			return default(XRNode);
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x9FC6CC", Offset = "0x9FC6CC", VA = "0x9FC6CC")]
		public static VRHand ToVRHand(this XRNode node)
		{
			return default(VRHand);
		}
	}
	[Token(Token = "0x20001BB")]
	public static class VRInput
	{
		[Token(Token = "0x200026B")]
		public enum DeviceType
		{
			[Token(Token = "0x4000F4F")]
			Oculus
		}

		[Token(Token = "0x4000CF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IVRInput_ActionMap actionMap;

		[Token(Token = "0x4000CF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DeviceType deviceType;

		[Token(Token = "0x1700007E")]
		public static IVRInput_ActionMap ActionMap
		{
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x9FC6EC", Offset = "0x9FC6EC", VA = "0x9FC6EC")]
			private get
			{
				return null;
			}
			[Token(Token = "0x600085F")]
			[Address(RVA = "0x9FC73C", Offset = "0x9FC73C", VA = "0x9FC73C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public static float LeftGrab
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x9FC790", Offset = "0x9FC790", VA = "0x9FC790")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000080")]
		public static float RightGrab
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x9FC874", Offset = "0x9FC874", VA = "0x9FC874")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000081")]
		public static float LeftEventSystem
		{
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x9FC95C", Offset = "0x9FC95C", VA = "0x9FC95C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000082")]
		public static bool LeftEventSystem_Button
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x9FCA44", Offset = "0x9FCA44", VA = "0x9FCA44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		public static float RightEventSystem
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x9FCB2C", Offset = "0x9FCB2C", VA = "0x9FCB2C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000084")]
		public static bool RightEventSystem_Button
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x9FCC14", Offset = "0x9FCC14", VA = "0x9FCC14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public static bool Recenter
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x9FCCFC", Offset = "0x9FCCFC", VA = "0x9FCCFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x9FCDE4", Offset = "0x9FCDE4", VA = "0x9FCDE4")]
		public static void SetDeviceType(DeviceType type)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x9FCE38", Offset = "0x9FCE38", VA = "0x9FCE38")]
		public static DeviceType GetDeviceType()
		{
			return default(DeviceType);
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x9F98F4", Offset = "0x9F98F4", VA = "0x9F98F4")]
		public static float Grab(VRHand hand)
		{
			return default(float);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x9FCE88", Offset = "0x9FCE88", VA = "0x9FCE88")]
		public static float EventSystem(VRHand hand)
		{
			return default(float);
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x9FCEA8", Offset = "0x9FCEA8", VA = "0x9FCEA8")]
		public static Vector3 LocalPosition(XRNode node)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x9FCF98", Offset = "0x9FCF98", VA = "0x9FCF98")]
		public static Quaternion LocalRotation(XRNode node)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x20001BC")]
	public interface IVRInput_ActionMap
	{
		[Token(Token = "0x17000086")]
		float LeftGrab
		{
			[Token(Token = "0x600086D")]
			get;
		}

		[Token(Token = "0x17000087")]
		float RightGrab
		{
			[Token(Token = "0x600086E")]
			get;
		}

		[Token(Token = "0x17000088")]
		bool Recenter
		{
			[Token(Token = "0x600086F")]
			get;
		}

		[Token(Token = "0x17000089")]
		float LeftEventSystem
		{
			[Token(Token = "0x6000870")]
			get;
		}

		[Token(Token = "0x1700008A")]
		bool LeftEventSystem_Button
		{
			[Token(Token = "0x6000871")]
			get;
		}

		[Token(Token = "0x1700008B")]
		float RightEventSystem
		{
			[Token(Token = "0x6000872")]
			get;
		}

		[Token(Token = "0x1700008C")]
		bool RightEventSystem_Button
		{
			[Token(Token = "0x6000873")]
			get;
		}

		[Token(Token = "0x6000874")]
		Vector3 LocalPosition(XRNode node);

		[Token(Token = "0x6000875")]
		Quaternion LocalRotation(XRNode node);
	}
	[Token(Token = "0x20001BD")]
	public sealed class VRInput_Palazzo : IVRInput_ActionMap
	{
		[Token(Token = "0x4000CF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly InputHandler inputHandler;

		[Token(Token = "0x1700008D")]
		public float LeftGrab
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x9FD0B4", Offset = "0x9FD0B4", VA = "0x9FD0B4", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008E")]
		public float RightGrab
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x9FD0E8", Offset = "0x9FD0E8", VA = "0x9FD0E8", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008F")]
		public float LeftEventSystem
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x9FD11C", Offset = "0x9FD11C", VA = "0x9FD11C", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000090")]
		public bool LeftEventSystem_Button
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x9FD124", Offset = "0x9FD124", VA = "0x9FD124", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		public float RightEventSystem
		{
			[Token(Token = "0x600087B")]
			[Address(RVA = "0x9FD1BC", Offset = "0x9FD1BC", VA = "0x9FD1BC", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000092")]
		public bool RightEventSystem_Button
		{
			[Token(Token = "0x600087C")]
			[Address(RVA = "0x9FD1C4", Offset = "0x9FD1C4", VA = "0x9FD1C4", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000093")]
		public bool Recenter
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0x9FD25C", Offset = "0x9FD25C", VA = "0x9FD25C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x9FD088", Offset = "0x9FD088", VA = "0x9FD088")]
		public VRInput_Palazzo(InputHandler inputHandler)
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x9FD264", Offset = "0x9FD264", VA = "0x9FD264", Slot = "11")]
		public Vector3 LocalPosition(XRNode node)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x9FD29C", Offset = "0x9FD29C", VA = "0x9FD29C", Slot = "12")]
		public Quaternion LocalRotation(XRNode node)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x20001BE")]
	public static class VRSimplify
	{
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x9FD7F4", Offset = "0x9FD7F4", VA = "0x9FD7F4")]
		public static PositionRotation Grab(VRGrab hand, Transform target)
		{
			return default(PositionRotation);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x9FD9E8", Offset = "0x9FD9E8", VA = "0x9FD9E8")]
		public static PositionRotation Update(VRGrab hand, PositionRotation positionRotation)
		{
			return default(PositionRotation);
		}
	}
	[Token(Token = "0x20001BF")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x767004", Offset = "0x767004")]
	public class VRGrab : MonoBehaviour
	{
		[Token(Token = "0x4000CF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x769928", Offset = "0x769928")]
		[SerializeField]
		private VRHand hand;

		[Token(Token = "0x4000CF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x769974", Offset = "0x769974")]
		[SerializeField]
		private float grabThreshold;

		[Token(Token = "0x4000CF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7699B4", Offset = "0x7699B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7699B4", Offset = "0x7699B4")]
		[SerializeField]
		private int maxGrabObjects;

		[Token(Token = "0x4000CF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float grabRadius;

		[Token(Token = "0x4000CF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform targetGrabPosition;

		[Token(Token = "0x4000CFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<VRGrabInterface> grabbedTargets;

		[Token(Token = "0x4000CFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float inputValue;

		[Token(Token = "0x4000CFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool hasGrabbed;

		[Token(Token = "0x4000CFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Collider[] colliders;

		[Token(Token = "0x4000CFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float? scale;

		[Token(Token = "0x4000D01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public PalazzoTriggers palazzoTriggers;

		[Token(Token = "0x17000094")]
		public VRHand Hand
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x9F9260", Offset = "0x9F9260", VA = "0x9F9260")]
			get
			{
				return default(VRHand);
			}
		}

		[Token(Token = "0x17000095")]
		public int MaxObjects
		{
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x9F9268", Offset = "0x9F9268", VA = "0x9F9268")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000096")]
		public int CurrentObjects
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x9F9270", Offset = "0x9F9270", VA = "0x9F9270")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000097")]
		public float InputValue
		{
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x9F92D0", Offset = "0x9F92D0", VA = "0x9F92D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000098")]
		public float GrabRadius
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x9F92D8", Offset = "0x9F92D8", VA = "0x9F92D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000099")]
		public float GrabThreshold
		{
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x9F93A8", Offset = "0x9F93A8", VA = "0x9F93A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009A")]
		public Vector3 GrabPosition
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x9F93B0", Offset = "0x9F93B0", VA = "0x9F93B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700009B")]
		public Quaternion GrabRotation
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x9F944C", Offset = "0x9F944C", VA = "0x9F944C")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700009C")]
		public Transform Target
		{
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x9F931C", Offset = "0x9F931C", VA = "0x9F931C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public float Scale
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x9F94E8", Offset = "0x9F94E8", VA = "0x9F94E8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009E")]
		public bool IsGrabbing
		{
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x9F95A0", Offset = "0x9F95A0", VA = "0x9F95A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000002")]
		public event Action onGrab
		{
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x9F8EB0", Offset = "0x9F8EB0", VA = "0x9F8EB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76BB90", Offset = "0x76BB90")]
			add
			{
			}
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x9F8F9C", Offset = "0x9F8F9C", VA = "0x9F8F9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76BBA0", Offset = "0x76BBA0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action onRelease
		{
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x9F9088", Offset = "0x9F9088", VA = "0x9F9088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76BBB0", Offset = "0x76BBB0")]
			add
			{
			}
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x9F9174", Offset = "0x9F9174", VA = "0x9F9174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76BBC0", Offset = "0x76BBC0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x9F95A8", Offset = "0x9F95A8", VA = "0x9F95A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x9F99E0", Offset = "0x9F99E0", VA = "0x9F99E0")]
		public void Grab()
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x9F9914", Offset = "0x9F9914", VA = "0x9F9914")]
		public void Release()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x9F9C18", Offset = "0x9F9C18", VA = "0x9F9C18")]
		public void Grab(VRGrabInterface grabInterface)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x9F9D2C", Offset = "0x9F9D2C", VA = "0x9F9D2C")]
		public void Release(VRGrabInterface grabInterface)
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x9F9E20", Offset = "0x9F9E20", VA = "0x9F9E20")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x9F9E78", Offset = "0x9F9E78", VA = "0x9F9E78")]
		public VRGrab()
		{
		}
	}
	[Token(Token = "0x20001C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x76703C", Offset = "0x76703C")]
	public class VRGrabbable : MonoBehaviour, VRGrabInterface, VRGrabDataInterface, VRGrabEventInterface
	{
		[Token(Token = "0x200026C")]
		public enum GrabbableSnapType
		{
			[Token(Token = "0x4000F51")]
			None,
			[Token(Token = "0x4000F52")]
			Lerp,
			[Token(Token = "0x4000F53")]
			Snap
		}

		[Token(Token = "0x4000D02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x769A5C", Offset = "0x769A5C")]
		[SerializeField]
		private bool setAsChild;

		[Token(Token = "0x4000D03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool canSwitchHand;

		[Token(Token = "0x4000D04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x769AB8", Offset = "0x769AB8")]
		[SerializeField]
		private GrabbableSnapType snapType;

		[Token(Token = "0x4000D05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x769B04", Offset = "0x769B04")]
		private float lerpSpeed;

		[Token(Token = "0x4000D06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool enablePosition;

		[Token(Token = "0x4000D07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 localPosition;

		[Token(Token = "0x4000D08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool enableRotation;

		[Token(Token = "0x4000D09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 localRotation;

		[Token(Token = "0x4000D0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x769B84", Offset = "0x769B84")]
		[SerializeField]
		private Rigidbody body;

		[Token(Token = "0x4000D0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool? hasGravity;

		[Token(Token = "0x4000D0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool? isKinematic;

		[Token(Token = "0x4000D0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int timesGrabbed;

		[Token(Token = "0x4000D0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform parent;

		[Token(Token = "0x4000D0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float grabValue;

		[Token(Token = "0x4000D10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 onGrabPosition;

		[Token(Token = "0x4000D11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion onGrabRotation;

		[Token(Token = "0x4000D12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private VRGrab currentGrabber;

		[Token(Token = "0x4000D13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Action<VRGrabbableRequest> onCanGrab;

		[Token(Token = "0x4000D14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Action<VRGrab> onGrab;

		[Token(Token = "0x4000D15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Action<VRGrab, float, float> onGrabUpdate;

		[Token(Token = "0x4000D16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action<VRGrab> onRelease;

		[Token(Token = "0x1700009F")]
		public GrabbableSnapType SnapType
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0x9FA30C", Offset = "0x9FA30C", VA = "0x9FA30C")]
			get
			{
				return default(GrabbableSnapType);
			}
		}

		[Token(Token = "0x170000A0")]
		public bool IsGrabbed
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0x9FA314", Offset = "0x9FA314", VA = "0x9FA314", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A1")]
		public bool IsFree
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x9FA384", Offset = "0x9FA384", VA = "0x9FA384", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A2")]
		public bool HasBeenGrabbed
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x9FA3F4", Offset = "0x9FA3F4", VA = "0x9FA3F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A3")]
		public int TimesGrabbed
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x9FA404", Offset = "0x9FA404", VA = "0x9FA404")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A4")]
		public float GrabValue
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x9FA40C", Offset = "0x9FA40C", VA = "0x9FA40C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A5")]
		public VRGrab CurrentGrabbing
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x9FA414", Offset = "0x9FA414", VA = "0x9FA414", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		private MonoBehaviour LevelEditorAPI.VR.VRGrabInterface.Mono
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x9FA41C", Offset = "0x9FA41C", VA = "0x9FA41C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public Vector3 GrabPositionOffset
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x9FA420", Offset = "0x9FA420", VA = "0x9FA420", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x9FA42C", Offset = "0x9FA42C", VA = "0x9FA42C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public Quaternion GrabRotationOffset
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x9FA438", Offset = "0x9FA438", VA = "0x9FA438", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x9FA444", Offset = "0x9FA444", VA = "0x9FA444", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x9FA450", Offset = "0x9FA450", VA = "0x9FA450")]
		public void ForceRelease()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x9FA4EC", Offset = "0x9FA4EC", VA = "0x9FA4EC", Slot = "5")]
		private bool LevelEditorAPI.VR.VRGrabInterface.CanGrab(VRGrab grab)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x9FA5E0", Offset = "0x9FA5E0", VA = "0x9FA5E0", Slot = "6")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrab(VRGrab grab)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x9FB09C", Offset = "0x9FB09C", VA = "0x9FB09C", Slot = "7")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrabUpdate(VRGrab grab, float value, float time)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x9FBC28", Offset = "0x9FBC28", VA = "0x9FBC28", Slot = "8")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnRelease(VRGrab grab)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x9FBDAC", Offset = "0x9FBDAC", VA = "0x9FBDAC", Slot = "16")]
		public void SubscribeOnCanGrab(Action<VRGrabbableRequest> method)
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x9FBE70", Offset = "0x9FBE70", VA = "0x9FBE70", Slot = "18")]
		public void SubscribeOnGrab(Action<VRGrab> method)
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x9FBF34", Offset = "0x9FBF34", VA = "0x9FBF34", Slot = "20")]
		public void SubscribeOnGrabUpdate(Action<VRGrab, float, float> method)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x9FBFF8", Offset = "0x9FBFF8", VA = "0x9FBFF8", Slot = "22")]
		public void SubscribeOnRelease(Action<VRGrab> method)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x9FC0BC", Offset = "0x9FC0BC", VA = "0x9FC0BC", Slot = "17")]
		public void UnsubscribeOnCanGrab(Action<VRGrabbableRequest> method)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x9FC180", Offset = "0x9FC180", VA = "0x9FC180", Slot = "19")]
		public void UnsubscribeOnGrab(Action<VRGrab> method)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x9FC248", Offset = "0x9FC248", VA = "0x9FC248", Slot = "21")]
		public void UnsubscribeOnGrabUpdate(Action<VRGrab, float, float> method)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x9FC310", Offset = "0x9FC310", VA = "0x9FC310", Slot = "23")]
		public void UnsubscribeOnRelease(Action<VRGrab> method)
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x9FC3D8", Offset = "0x9FC3D8", VA = "0x9FC3D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x76BBD0", Offset = "0x76BBD0")]
		public void AttachComponents()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x9FC430", Offset = "0x9FC430", VA = "0x9FC430")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x9FC5D4", Offset = "0x9FC5D4", VA = "0x9FC5D4")]
		public VRGrabbable()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	public class VRGrabbableRequest
	{
		[Token(Token = "0x4000D17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int noGrab;

		[Token(Token = "0x170000A9")]
		public bool CanGrab
		{
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x9FA5D0", Offset = "0x9FA5D0", VA = "0x9FA5D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AA")]
		public int DisabledStrength
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x9FC67C", Offset = "0x9FC67C", VA = "0x9FC67C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x9FC684", Offset = "0x9FC684", VA = "0x9FC684")]
		public void Response(bool value)
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x9FC698", Offset = "0x9FC698", VA = "0x9FC698")]
		public void Yes()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x9FC69C", Offset = "0x9FC69C", VA = "0x9FC69C")]
		public void No()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x9FA5C8", Offset = "0x9FA5C8", VA = "0x9FA5C8")]
		public VRGrabbableRequest()
		{
		}
	}
	[Token(Token = "0x20001C2")]
	public interface VRGrabInterface
	{
		[Token(Token = "0x170000AB")]
		MonoBehaviour Mono
		{
			[Token(Token = "0x60008BB")]
			get;
		}

		[Token(Token = "0x60008BC")]
		bool CanGrab(VRGrab grab);

		[Token(Token = "0x60008BD")]
		void OnGrab(VRGrab grab);

		[Token(Token = "0x60008BE")]
		void OnGrabUpdate(VRGrab grab, float input, float deltaTime);

		[Token(Token = "0x60008BF")]
		void OnRelease(VRGrab grab);
	}
	[Token(Token = "0x20001C3")]
	public interface VRGrabDataInterface
	{
		[Token(Token = "0x170000AC")]
		bool IsGrabbed
		{
			[Token(Token = "0x60008C0")]
			get;
		}

		[Token(Token = "0x170000AD")]
		bool IsFree
		{
			[Token(Token = "0x60008C1")]
			get;
		}

		[Token(Token = "0x170000AE")]
		VRGrab CurrentGrabbing
		{
			[Token(Token = "0x60008C2")]
			get;
		}

		[Token(Token = "0x170000AF")]
		Vector3 GrabPositionOffset
		{
			[Token(Token = "0x60008C3")]
			get;
			[Token(Token = "0x60008C4")]
			set;
		}

		[Token(Token = "0x170000B0")]
		Quaternion GrabRotationOffset
		{
			[Token(Token = "0x60008C5")]
			get;
			[Token(Token = "0x60008C6")]
			set;
		}
	}
	[Token(Token = "0x20001C4")]
	public interface VRGrabEventInterface
	{
		[Token(Token = "0x60008C7")]
		void SubscribeOnCanGrab(Action<VRGrabbableRequest> method);

		[Token(Token = "0x60008C8")]
		void UnsubscribeOnCanGrab(Action<VRGrabbableRequest> method);

		[Token(Token = "0x60008C9")]
		void SubscribeOnGrab(Action<VRGrab> method);

		[Token(Token = "0x60008CA")]
		void UnsubscribeOnGrab(Action<VRGrab> method);

		[Token(Token = "0x60008CB")]
		void SubscribeOnGrabUpdate(Action<VRGrab, float, float> method);

		[Token(Token = "0x60008CC")]
		void UnsubscribeOnGrabUpdate(Action<VRGrab, float, float> method);

		[Token(Token = "0x60008CD")]
		void SubscribeOnRelease(Action<VRGrab> method);

		[Token(Token = "0x60008CE")]
		void UnsubscribeOnRelease(Action<VRGrab> method);
	}
	[Token(Token = "0x20001C5")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x767074", Offset = "0x767074")]
	public class VRGrabRelay : MonoBehaviour, VRGrabInterface, ISerializationCallbackReceiver
	{
		[Token(Token = "0x4000D18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "UnityObjectFilter", RVA = "0x769BD0", Offset = "0x769BD0")]
		private UnityEngine.Object grabbableObject;

		[Token(Token = "0x4000D19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VRGrabInterface grabInterface;

		[Token(Token = "0x170000B1")]
		private MonoBehaviour LevelEditorAPI.VR.VRGrabInterface.Mono
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x9FA084", Offset = "0x9FA084", VA = "0x9FA084", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x9F9F68", Offset = "0x9F9F68", VA = "0x9F9F68")]
		private void Start()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x9FA140", Offset = "0x9FA140", VA = "0x9FA140", Slot = "5")]
		private bool LevelEditorAPI.VR.VRGrabInterface.CanGrab(VRGrab grab)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x9FA208", Offset = "0x9FA208", VA = "0x9FA208", Slot = "6")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrab(VRGrab grab)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x9FA2A0", Offset = "0x9FA2A0", VA = "0x9FA2A0", Slot = "7")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrabUpdate(VRGrab grab, float value, float time)
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x9FA2A4", Offset = "0x9FA2A4", VA = "0x9FA2A4", Slot = "8")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnRelease(VRGrab grab)
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x9FA2A8", Offset = "0x9FA2A8", VA = "0x9FA2A8", Slot = "10")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x9FA300", Offset = "0x9FA300", VA = "0x9FA300", Slot = "9")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x9FA304", Offset = "0x9FA304", VA = "0x9FA304")]
		public VRGrabRelay()
		{
		}
	}
	[Token(Token = "0x20001C6")]
	public class VRInstantiateOnGrab : MonoBehaviour, VRGrabInterface
	{
		[Token(Token = "0x4000D1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject prefab;

		[Token(Token = "0x4000D1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 offset;

		[Token(Token = "0x4000D1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 rotationOffset;

		[Token(Token = "0x4000D1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform parent;

		[Token(Token = "0x170000B2")]
		public Vector3 Position
		{
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x9FD2D4", Offset = "0x9FD2D4", VA = "0x9FD2D4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B3")]
		public Quaternion Rotation
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x9FD4A8", Offset = "0x9FD4A8", VA = "0x9FD4A8")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x170000B4")]
		public GameObject Prefab
		{
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x9FD5E0", Offset = "0x9FD5E0", VA = "0x9FD5E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x9FD5E8", Offset = "0x9FD5E8", VA = "0x9FD5E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		private MonoBehaviour LevelEditorAPI.VR.VRGrabInterface.Mono
		{
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x9FD5F0", Offset = "0x9FD5F0", VA = "0x9FD5F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x9FD5F4", Offset = "0x9FD5F4", VA = "0x9FD5F4", Slot = "5")]
		private bool LevelEditorAPI.VR.VRGrabInterface.CanGrab(VRGrab grab)
		{
			return default(bool);
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x9FD5FC", Offset = "0x9FD5FC", VA = "0x9FD5FC", Slot = "6")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrab(VRGrab grab)
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x9FD764", Offset = "0x9FD764", VA = "0x9FD764", Slot = "7")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnGrabUpdate(VRGrab grab, float value, float time)
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x9FD768", Offset = "0x9FD768", VA = "0x9FD768", Slot = "8")]
		private void LevelEditorAPI.VR.VRGrabInterface.OnRelease(VRGrab grab)
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x9FD76C", Offset = "0x9FD76C", VA = "0x9FD76C")]
		public VRInstantiateOnGrab()
		{
		}
	}
}
namespace LevelEditorAPI.Utility
{
	[Serializable]
	[Token(Token = "0x20001C7")]
	public class MeshDrawerInstance
	{
		[Token(Token = "0x4000D1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x769C84", Offset = "0x769C84")]
		[SerializeField]
		private Mesh mesh;

		[Token(Token = "0x4000D1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material material;

		[Token(Token = "0x4000D20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int layer;

		[Token(Token = "0x4000D21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x769CF0", Offset = "0x769CF0")]
		[SerializeField]
		private Matrix4x4 offset;

		[Token(Token = "0x170000B6")]
		public Mesh Mesh
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x9F3A44", Offset = "0x9F3A44", VA = "0x9F3A44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x9F3A4C", Offset = "0x9F3A4C", VA = "0x9F3A4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public Material Material
		{
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x9F3A54", Offset = "0x9F3A54", VA = "0x9F3A54")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x9F3A5C", Offset = "0x9F3A5C", VA = "0x9F3A5C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public LayerMask Layer
		{
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x9F3A64", Offset = "0x9F3A64", VA = "0x9F3A64")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x9F3A84", Offset = "0x9F3A84", VA = "0x9F3A84")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public int LayerInt
		{
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x9F3AB4", Offset = "0x9F3AB4", VA = "0x9F3AB4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x9F3ABC", Offset = "0x9F3ABC", VA = "0x9F3ABC")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public int LayerBitmask
		{
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x9F3B58", Offset = "0x9F3B58", VA = "0x9F3B58")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BB")]
		public Vector3 OffsetPosition
		{
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x9F3B6C", Offset = "0x9F3B6C", VA = "0x9F3B6C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BC")]
		public Quaternion OffsetRotation
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x9F3C10", Offset = "0x9F3C10", VA = "0x9F3C10")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x170000BD")]
		public Vector3 OffsetScale
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x9F3D30", Offset = "0x9F3D30", VA = "0x9F3D30")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BE")]
		public Bounds Bounds
		{
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x9F3D3C", Offset = "0x9F3D3C", VA = "0x9F3D3C")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x9F3DB8", Offset = "0x9F3DB8", VA = "0x9F3DB8")]
		public MeshDrawerInstance()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x9F3E58", Offset = "0x9F3E58", VA = "0x9F3E58")]
		public MeshDrawerInstance(Mesh mesh)
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x9F3F08", Offset = "0x9F3F08", VA = "0x9F3F08")]
		public MeshDrawerInstance(Mesh mesh, Material material)
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x9F3F30", Offset = "0x9F3F30", VA = "0x9F3F30")]
		public MeshDrawerInstance(Mesh mesh, Material material, int layer)
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x9F3F68", Offset = "0x9F3F68", VA = "0x9F3F68")]
		public MeshDrawerInstance(Mesh mesh, Material material, Transform localOffset, int layer)
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x9F3FE8", Offset = "0x9F3FE8", VA = "0x9F3FE8")]
		public MeshDrawerInstance(Mesh mesh, Material material, Matrix4x4 localOffset, int layer)
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x9F403C", Offset = "0x9F403C", VA = "0x9F403C")]
		public void Draw()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x9F40FC", Offset = "0x9F40FC", VA = "0x9F40FC")]
		public void Draw(Transform target)
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x9F4234", Offset = "0x9F4234", VA = "0x9F4234")]
		public void Draw(Matrix4x4 offset)
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x9F4370", Offset = "0x9F4370", VA = "0x9F4370")]
		public void Draw(Material overrideMaterial)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x9F4434", Offset = "0x9F4434", VA = "0x9F4434")]
		public void Draw(Transform target, Material overrideMaterial)
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x9F4574", Offset = "0x9F4574", VA = "0x9F4574")]
		public void Draw(Transform target, int overrideLayer)
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x9F46AC", Offset = "0x9F46AC", VA = "0x9F46AC")]
		public void Draw(Transform target, Material overrideMaterial, int overrideLayer)
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x9F47EC", Offset = "0x9F47EC", VA = "0x9F47EC")]
		public void Draw(Matrix4x4 offset, Material overrideMaterial)
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x9F4930", Offset = "0x9F4930", VA = "0x9F4930")]
		public void SetMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x9F4938", Offset = "0x9F4938", VA = "0x9F4938")]
		public Mesh GetMesh()
		{
			return null;
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x9F4940", Offset = "0x9F4940", VA = "0x9F4940")]
		public void SetMaterial(Material material)
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x9F4948", Offset = "0x9F4948", VA = "0x9F4948")]
		public Material GetMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x9F4950", Offset = "0x9F4950", VA = "0x9F4950")]
		public void SetLayer(LayerMask layer)
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x9F4980", Offset = "0x9F4980", VA = "0x9F4980")]
		public LayerMask GetLayer()
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x9F49A0", Offset = "0x9F49A0", VA = "0x9F49A0")]
		public void DrawGizmosMesh()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x9F4ACC", Offset = "0x9F4ACC", VA = "0x9F4ACC")]
		public void DrawGizmosMesh(Transform location)
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x9F4CAC", Offset = "0x9F4CAC", VA = "0x9F4CAC")]
		public void DrawGizmosWireMesh()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x9F4DD8", Offset = "0x9F4DD8", VA = "0x9F4DD8")]
		public void DrawGizmosWireMesh(Transform location)
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x9F4FB8", Offset = "0x9F4FB8", VA = "0x9F4FB8")]
		public static MeshDrawerInstance CreateInstance(SkinnedMeshRenderer target)
		{
			return null;
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x9F50A0", Offset = "0x9F50A0", VA = "0x9F50A0")]
		public static MeshDrawerInstance CreateInstance(MeshFilter target)
		{
			return null;
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x9F51AC", Offset = "0x9F51AC", VA = "0x9F51AC")]
		public static MeshDrawerInstance CreateInstance(MeshRenderer target)
		{
			return null;
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x9F52F8", Offset = "0x9F52F8", VA = "0x9F52F8")]
		public static MeshDrawerInstance[] CreateInstance(Prefab prefab)
		{
			return null;
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x9F5328", Offset = "0x9F5328", VA = "0x9F5328")]
		public static MeshDrawerInstance[] CreateInstance(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x9F55BC", Offset = "0x9F55BC", VA = "0x9F55BC")]
		public static MeshDrawerInstance[] CreateInstances(Prefab prefab)
		{
			return null;
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x9F55EC", Offset = "0x9F55EC", VA = "0x9F55EC")]
		public static MeshDrawerInstance[] CreateInstances(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x9F5870", Offset = "0x9F5870", VA = "0x9F5870")]
		public static Bounds GetTotalBounds(IReadOnlyList<MeshDrawerInstance> instances)
		{
			return default(Bounds);
		}
	}
	[Token(Token = "0x20001C8")]
	public static class PhysicsHelper
	{
		[Token(Token = "0x4000D22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<Collider> colliders;

		[Token(Token = "0x4000D23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Collider[] colliderArray;

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x9F5BAC", Offset = "0x9F5BAC", VA = "0x9F5BAC")]
		public static void SetMaxColliders(int amount)
		{
		}

		[Token(Token = "0x6000910")]
		public static Collider[] Copy<T>(Prefab from, T to, bool childrenIncluded = false) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000911")]
		public static Collider[] Copy<T>(GameObject from, T to, bool childrenIncluded = false) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x9F5C78", Offset = "0x9F5C78", VA = "0x9F5C78")]
		public static Collider[] Copy(Prefab from, GameObject to, bool childrenIncluded = false)
		{
			return null;
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x9F5D14", Offset = "0x9F5D14", VA = "0x9F5D14")]
		public static Collider[] Copy(GameObject from, GameObject to, bool childrenIncluded = false)
		{
			return null;
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x9F5FC4", Offset = "0x9F5FC4", VA = "0x9F5FC4")]
		private static void CopyChildren(Transform current, Transform target, List<Collider> colliderList, [Optional] Action<GameObject> onCreatedObject)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x9F63E4", Offset = "0x9F63E4", VA = "0x9F63E4")]
		public static Collider AddCollider(Collider referenceCollider, GameObject to)
		{
			return null;
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x9F6790", Offset = "0x9F6790", VA = "0x9F6790")]
		public static SphereCollider AddSphereCollider(SphereCollider refCol, GameObject to)
		{
			return null;
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x9F6894", Offset = "0x9F6894", VA = "0x9F6894")]
		public static BoxCollider AddBoxCollider(BoxCollider refCol, GameObject to)
		{
			return null;
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x9F69A8", Offset = "0x9F69A8", VA = "0x9F69A8")]
		public static CapsuleCollider AddCapsuleCollider(CapsuleCollider refCol, GameObject to)
		{
			return null;
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x9F6B1C", Offset = "0x9F6B1C", VA = "0x9F6B1C")]
		public static MeshCollider AddMeshCollider(MeshCollider refCol, GameObject to)
		{
			return null;
		}

		[Token(Token = "0x600091A")]
		public static Collider[] CopyFromRenderers<T>(Prefab from, T to) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x9F6C38", Offset = "0x9F6C38", VA = "0x9F6C38")]
		public static Collider[] CopyFromRenderers(Prefab from, GameObject to, bool useBoundingBox = true)
		{
			return null;
		}

		[Token(Token = "0x600091C")]
		public static void Clear<T>(T target, bool includeChildren = false) where T : Component
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x9F6DD4", Offset = "0x9F6DD4", VA = "0x9F6DD4")]
		public static void Clear(GameObject target, bool includeChildren = false)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x9F7020", Offset = "0x9F7020", VA = "0x9F7020")]
		public static Bounds TotalBounds(GameObject target, bool includeChildren = false, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x9F7148", Offset = "0x9F7148", VA = "0x9F7148")]
		public static Bounds TotalBounds(IReadOnlyList<Collider> colliders, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x9F74DC", Offset = "0x9F74DC", VA = "0x9F74DC")]
		public static Bounds TotalBounds(IReadOnlyList<Collider> colliders, Quaternion rotation, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x9F78F4", Offset = "0x9F78F4", VA = "0x9F78F4")]
		public static bool IsColliding(Collider collider, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x9F7B58", Offset = "0x9F7B58", VA = "0x9F7B58")]
		public static bool IsColliding(GameObject gameObject, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x9F7D90", Offset = "0x9F7D90", VA = "0x9F7D90")]
		public static bool IsColliding(IReadOnlyList<Collider> colliders, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x9F7A18", Offset = "0x9F7A18", VA = "0x9F7A18")]
		public static bool IsColliding(Collider collider, Vector3 positionOffset, Quaternion rotationOffset, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x9F7C7C", Offset = "0x9F7C7C", VA = "0x9F7C7C")]
		public static bool IsColliding(GameObject gameObject, Vector3 positionOffset, Quaternion rotationOffset, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x9F7EB4", Offset = "0x9F7EB4", VA = "0x9F7EB4")]
		public static bool IsColliding(IReadOnlyList<Collider> colliders, Vector3 positionOffset, Quaternion rotationOffset, bool includeTriggers = false, bool includeDisabledColliders = false)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x20001C9")]
	public struct PositionRotation
	{
		[Token(Token = "0x4000D24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 Position;

		[Token(Token = "0x4000D25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion Rotation;

		[Token(Token = "0x170000BF")]
		public Matrix4x4 Matrix4X4
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x7D8A60", Offset = "0x7D8A60", VA = "0x7D8A60")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x170000C0")]
		public InstantiateData InstantiateData
		{
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x7D8A68", Offset = "0x7D8A68", VA = "0x7D8A68")]
			get
			{
				return default(InstantiateData);
			}
		}

		[Token(Token = "0x170000C1")]
		public static PositionRotation Default
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x9F863C", Offset = "0x9F863C", VA = "0x9F863C")]
			get
			{
				return default(PositionRotation);
			}
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x7D8A70", Offset = "0x7D8A70", VA = "0x7D8A70")]
		public PositionRotation(Vector3 position)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x7D8A78", Offset = "0x7D8A78", VA = "0x7D8A78")]
		public PositionRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x7D8A80", Offset = "0x7D8A80", VA = "0x7D8A80")]
		public PositionRotation(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x7D8A94", Offset = "0x7D8A94", VA = "0x7D8A94")]
		public PositionRotation(InstantiateData instantiateData, Space space = Space.Self)
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x7D8AD8", Offset = "0x7D8AD8", VA = "0x7D8AD8")]
		public PositionRotation(Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x9F8B4C", Offset = "0x9F8B4C", VA = "0x9F8B4C")]
		public static implicit operator Vector3(PositionRotation positionRotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x9F8B58", Offset = "0x9F8B58", VA = "0x9F8B58")]
		public static implicit operator Quaternion(PositionRotation positionRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x9F8B64", Offset = "0x9F8B64", VA = "0x9F8B64")]
		public static implicit operator InstantiateData(PositionRotation positionRotation)
		{
			return default(InstantiateData);
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x9F8B90", Offset = "0x9F8B90", VA = "0x9F8B90")]
		public static implicit operator Matrix4x4(PositionRotation positionRotation)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x7D8B1C", Offset = "0x7D8B1C", VA = "0x7D8B1C")]
		public PositionRotation WorldToLocal(Transform transform)
		{
			return default(PositionRotation);
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x7D8B24", Offset = "0x7D8B24", VA = "0x7D8B24")]
		public void SetTransform(Transform transform, Space space = Space.Self)
		{
		}
	}
}
namespace LevelEditorAPI.InternalPrefab
{
	[Token(Token = "0x20001CA")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7670AC", Offset = "0x7670AC")]
	public class InitPrefabDatabase : MonoBehaviour
	{
		[Token(Token = "0x4000D26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "Readonly", RVA = "0x769D28", Offset = "0x769D28")]
		private PrefabDatabase optionalDatabaseReference;

		[Token(Token = "0x4000D27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool throwError;

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xA253F4", Offset = "0xA253F4", VA = "0xA253F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xA25688", Offset = "0xA25688", VA = "0xA25688")]
		public InitPrefabDatabase()
		{
		}
	}
	[Token(Token = "0x20001CB")]
	public interface IPrefab
	{
		[Token(Token = "0x170000C2")]
		string PrefabName
		{
			[Token(Token = "0x6000938")]
			get;
			[Token(Token = "0x6000939")]
			set;
		}

		[Token(Token = "0x170000C3")]
		GameObject GameObject
		{
			[Token(Token = "0x600093A")]
			get;
			[Token(Token = "0x600093B")]
			set;
		}

		[Token(Token = "0x170000C4")]
		int Id
		{
			[Token(Token = "0x600093C")]
			get;
			[Token(Token = "0x600093D")]
			set;
		}

		[Token(Token = "0x600093E")]
		void Initialize();
	}
	[Token(Token = "0x20001CC")]
	public interface IPrefabDatabase
	{
		[Token(Token = "0x600093F")]
		void AddItem(Prefab prefab);

		[Token(Token = "0x6000940")]
		void AddItems(IReadOnlyList<Prefab> prefabs);

		[Token(Token = "0x6000941")]
		void RemoveItem(Prefab prefab);

		[Token(Token = "0x6000942")]
		void RemoveItem(int id);

		[Token(Token = "0x6000943")]
		void RemoveItem(string name);

		[Token(Token = "0x6000944")]
		void RemoveItemByIndex(int index);

		[Token(Token = "0x6000945")]
		void Clear();

		[Token(Token = "0x6000946")]
		Prefab GetItemByIndex(int index);

		[Token(Token = "0x6000947")]
		void SetItemByIndex(int index, Prefab prefab);
	}
}
namespace LevelEditorAPI.InputSys
{
	[Token(Token = "0x20001CD")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x7670E4", Offset = "0x7670E4")]
	public class InputManager : ScriptableObject
	{
		[Token(Token = "0x4000D28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string @namespace;

		[Token(Token = "0x4000D29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string inputName;

		[Token(Token = "0x4000D2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string defaultDevice;

		[Token(Token = "0x4000D2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string[] devices;

		[Token(Token = "0x4000D2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Action[] actions;

		[Token(Token = "0x4000D2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x769DC4", Offset = "0x769DC4")]
		private string customCode;

		[Token(Token = "0x4000D2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool includeXRNodeTracking;

		[Token(Token = "0x170000C5")]
		public string Namespace
		{
			[Token(Token = "0x6000948")]
			[Address(RVA = "0xA23604", Offset = "0xA23604", VA = "0xA23604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public string InputName
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0xA2360C", Offset = "0xA2360C", VA = "0xA2360C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public string DefaultDevice
		{
			[Token(Token = "0x600094A")]
			[Address(RVA = "0xA23614", Offset = "0xA23614", VA = "0xA23614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		public string[] Devices
		{
			[Token(Token = "0x600094B")]
			[Address(RVA = "0xA2361C", Offset = "0xA2361C", VA = "0xA2361C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		public Action[] Actions
		{
			[Token(Token = "0x600094C")]
			[Address(RVA = "0xA23624", Offset = "0xA23624", VA = "0xA23624")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		public bool XRNodeTracking
		{
			[Token(Token = "0x600094D")]
			[Address(RVA = "0xA2362C", Offset = "0xA2362C", VA = "0xA2362C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CB")]
		public string CustomCode
		{
			[Token(Token = "0x600094E")]
			[Address(RVA = "0xA23634", Offset = "0xA23634", VA = "0xA23634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xA2363C", Offset = "0xA2363C", VA = "0xA2363C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xA23678", Offset = "0xA23678", VA = "0xA23678")]
		public InputManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001CE")]
	public class Action
	{
		[Token(Token = "0x4000D2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string name;

		[Token(Token = "0x4000D30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActionType actionType;

		[Token(Token = "0x4000D31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Axis[] axisX;

		[Token(Token = "0x4000D32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Axis[] axisY;

		[Token(Token = "0x170000CC")]
		public string Name
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0xA231AC", Offset = "0xA231AC", VA = "0xA231AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		public ActionType ActionType
		{
			[Token(Token = "0x6000952")]
			[Address(RVA = "0xA231B4", Offset = "0xA231B4", VA = "0xA231B4")]
			get
			{
				return default(ActionType);
			}
		}

		[Token(Token = "0x170000CE")]
		public Axis[] AxisX
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0xA231BC", Offset = "0xA231BC", VA = "0xA231BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		public Axis[] AxisY
		{
			[Token(Token = "0x6000954")]
			[Address(RVA = "0xA231C4", Offset = "0xA231C4", VA = "0xA231C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0xA231CC", Offset = "0xA231CC", VA = "0xA231CC")]
		public int Validate()
		{
			return default(int);
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0xA23404", Offset = "0xA23404", VA = "0xA23404")]
		public Action()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001CF")]
	public class Axis
	{
		[Token(Token = "0x4000D33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string name;

		[Token(Token = "0x4000D34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AxisTypee axisType;

		[Token(Token = "0x4000D35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string deviceOverride;

		[Token(Token = "0x4000D36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int buttonId;

		[Token(Token = "0x4000D37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "Readonly", RVA = "0x769E94", Offset = "0x769E94")]
		private string buttonName;

		[Token(Token = "0x4000D38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool invert;

		[Token(Token = "0x4000D39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int axisId;

		[Token(Token = "0x170000D0")]
		public string Name
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0xA2345C", Offset = "0xA2345C", VA = "0xA2345C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		public AxisTypee AxisType
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0xA23548", Offset = "0xA23548", VA = "0xA23548")]
			get
			{
				return default(AxisTypee);
			}
		}

		[Token(Token = "0x170000D2")]
		public string Device
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0xA234DC", Offset = "0xA234DC", VA = "0xA234DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		public int ButtonId
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0xA23550", Offset = "0xA23550", VA = "0xA23550")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D4")]
		public string ButtonName
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0xA23558", Offset = "0xA23558", VA = "0xA23558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		public bool Invert
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0xA23560", Offset = "0xA23560", VA = "0xA23560")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D6")]
		public int AxisId
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0xA23568", Offset = "0xA23568", VA = "0xA23568")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D7")]
		public float Dead
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0xA23570", Offset = "0xA23570", VA = "0xA23570")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D8")]
		public float Sensitivity
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0xA2357C", Offset = "0xA2357C", VA = "0xA2357C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D9")]
		public float Gravity
		{
			[Token(Token = "0x6000960")]
			[Address(RVA = "0xA23598", Offset = "0xA23598", VA = "0xA23598")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0xA2335C", Offset = "0xA2335C", VA = "0xA2335C")]
		public int Validate()
		{
			return default(int);
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0xA235A4", Offset = "0xA235A4", VA = "0xA235A4")]
		public Axis()
		{
		}
	}
	[Token(Token = "0x20001D0")]
	public enum ActionType
	{
		[Token(Token = "0x4000D3B")]
		Button,
		[Token(Token = "0x4000D3C")]
		Float,
		[Token(Token = "0x4000D3D")]
		Float2D
	}
	[Token(Token = "0x20001D1")]
	public enum AxisTypee
	{
		[Token(Token = "0x4000D3F")]
		Button,
		[Token(Token = "0x4000D40")]
		Axis
	}
	[Token(Token = "0x20001D2")]
	public static class InputSystem
	{
		[Token(Token = "0x200026D")]
		public enum DeviceType
		{
			[Token(Token = "0x4000F55")]
			Default
		}

		[Token(Token = "0x4000D41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IInputSystem_ActionMap actionMap;

		[Token(Token = "0x4000D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DeviceType deviceType;

		[Token(Token = "0x170000DA")]
		public static IInputSystem_ActionMap ActionMap
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0xA23710", Offset = "0xA23710", VA = "0xA23710")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000964")]
			[Address(RVA = "0xA23760", Offset = "0xA23760", VA = "0xA23760")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public static bool Stamp
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0xA237B4", Offset = "0xA237B4", VA = "0xA237B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DC")]
		public static bool Destroy
		{
			[Token(Token = "0x6000966")]
			[Address(RVA = "0xA23898", Offset = "0xA23898", VA = "0xA23898")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DD")]
		public static bool Redo
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0xA23980", Offset = "0xA23980", VA = "0xA23980")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DE")]
		public static bool Undo
		{
			[Token(Token = "0x6000968")]
			[Address(RVA = "0xA23A68", Offset = "0xA23A68", VA = "0xA23A68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DF")]
		public static float PlatformScale
		{
			[Token(Token = "0x6000969")]
			[Address(RVA = "0xA23B50", Offset = "0xA23B50", VA = "0xA23B50")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E0")]
		public static float PlatformRotate
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0xA23C38", Offset = "0xA23C38", VA = "0xA23C38")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E1")]
		public static bool PlatformRecenter
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0xA23D20", Offset = "0xA23D20", VA = "0xA23D20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E2")]
		public static bool ToolboxRecenter
		{
			[Token(Token = "0x600096C")]
			[Address(RVA = "0xA23E08", Offset = "0xA23E08", VA = "0xA23E08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xA23ECC", Offset = "0xA23ECC", VA = "0xA23ECC")]
		public static void SetDeviceType(DeviceType type)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xA23F20", Offset = "0xA23F20", VA = "0xA23F20")]
		public static DeviceType GetDeviceType()
		{
			return default(DeviceType);
		}
	}
	[Token(Token = "0x20001D3")]
	public interface IInputSystem_ActionMap
	{
		[Token(Token = "0x170000E3")]
		bool Stamp
		{
			[Token(Token = "0x600096F")]
			get;
		}

		[Token(Token = "0x170000E4")]
		bool Destroy
		{
			[Token(Token = "0x6000970")]
			get;
		}

		[Token(Token = "0x170000E5")]
		bool Redo
		{
			[Token(Token = "0x6000971")]
			get;
		}

		[Token(Token = "0x170000E6")]
		bool Undo
		{
			[Token(Token = "0x6000972")]
			get;
		}

		[Token(Token = "0x170000E7")]
		float PlatformScale
		{
			[Token(Token = "0x6000973")]
			get;
		}

		[Token(Token = "0x170000E8")]
		float PlatformRotate
		{
			[Token(Token = "0x6000974")]
			get;
		}

		[Token(Token = "0x170000E9")]
		bool PlatformRecenter
		{
			[Token(Token = "0x6000975")]
			get;
		}

		[Token(Token = "0x170000EA")]
		bool ToolboxRecenter
		{
			[Token(Token = "0x6000976")]
			get;
		}
	}
	[Token(Token = "0x20001D4")]
	public class InputSystem_Palazzo : IInputSystem_ActionMap
	{
		[Token(Token = "0x4000D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly InputHandler inputHandler;

		[Token(Token = "0x170000EB")]
		public bool Stamp
		{
			[Token(Token = "0x6000978")]
			[Address(RVA = "0xA23F9C", Offset = "0xA23F9C", VA = "0xA23F9C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EC")]
		public bool Destroy
		{
			[Token(Token = "0x6000979")]
			[Address(RVA = "0xA23FE4", Offset = "0xA23FE4", VA = "0xA23FE4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000ED")]
		public bool Redo
		{
			[Token(Token = "0x600097A")]
			[Address(RVA = "0xA2402C", Offset = "0xA2402C", VA = "0xA2402C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EE")]
		public bool Undo
		{
			[Token(Token = "0x600097B")]
			[Address(RVA = "0xA24034", Offset = "0xA24034", VA = "0xA24034", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EF")]
		public float PlatformScale
		{
			[Token(Token = "0x600097C")]
			[Address(RVA = "0xA2403C", Offset = "0xA2403C", VA = "0xA2403C", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F0")]
		public float PlatformRotate
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0xA24044", Offset = "0xA24044", VA = "0xA24044", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F1")]
		public bool PlatformRecenter
		{
			[Token(Token = "0x600097E")]
			[Address(RVA = "0xA24134", Offset = "0xA24134", VA = "0xA24134", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F2")]
		public bool ToolboxRecenter
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0xA2413C", Offset = "0xA2413C", VA = "0xA2413C", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0xA23F70", Offset = "0xA23F70", VA = "0xA23F70")]
		public InputSystem_Palazzo(InputHandler inputHandler)
		{
		}
	}
	[Token(Token = "0x20001D5")]
	public static class InputUtility
	{
		[Token(Token = "0x6000980")]
		[Address(RVA = "0xA24184", Offset = "0xA24184", VA = "0xA24184")]
		public static float GetAxis(string[] values)
		{
			return default(float);
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0xA2420C", Offset = "0xA2420C", VA = "0xA2420C")]
		public static string GetAxisName(InputManager manager, Action action, Axis axis)
		{
			return null;
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0xA246A4", Offset = "0xA246A4", VA = "0xA246A4")]
		public static string GetDefaultConstantName(InputManager manager, Action action)
		{
			return null;
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xA2473C", Offset = "0xA2473C", VA = "0xA2473C")]
		public static string[] GetConstantNames(InputManager manager, Action action)
		{
			return null;
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0xA24A74", Offset = "0xA24A74", VA = "0xA24A74")]
		public static string[] GetOverrides(InputManager manager, Action action)
		{
			return null;
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0xA24D1C", Offset = "0xA24D1C", VA = "0xA24D1C")]
		public static bool IsAxisValid(InputManager manager, Action action, Axis axis)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001D6")]
	public class State
	{
		[Token(Token = "0x4000D44")]
		private const float THRESHOLD = 0.05f;

		[Token(Token = "0x4000D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int frame;

		[Token(Token = "0x4000D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float oldInput;

		[Token(Token = "0x4000D47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isDown;

		[Token(Token = "0x4000D48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool isUp;

		[Token(Token = "0x4000D49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private bool isHold;

		[Token(Token = "0x170000F3")]
		public bool Down
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0xA24DD8", Offset = "0xA24DD8", VA = "0xA24DD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F4")]
		public bool Up
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0xA24DE0", Offset = "0xA24DE0", VA = "0xA24DE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F5")]
		public bool Hold
		{
			[Token(Token = "0x6000988")]
			[Address(RVA = "0xA24DE8", Offset = "0xA24DE8", VA = "0xA24DE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F6")]
		private bool IsUpdated
		{
			[Token(Token = "0x6000989")]
			[Address(RVA = "0xA24DF0", Offset = "0xA24DF0", VA = "0xA24DF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xA24E1C", Offset = "0xA24E1C", VA = "0xA24E1C")]
		public State Update(string[] axes)
		{
			return null;
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xA24EDC", Offset = "0xA24EDC", VA = "0xA24EDC")]
		public State Update(float input)
		{
			return null;
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xA24F94", Offset = "0xA24F94", VA = "0xA24F94")]
		public static implicit operator bool(State state)
		{
			return default(bool);
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xA24FBC", Offset = "0xA24FBC", VA = "0xA24FBC")]
		public State()
		{
		}
	}
}
namespace Fabric
{
	[Token(Token = "0x20001D7")]
	[ExecuteInEditMode]
	public class FabricSpringBoard : MonoBehaviour
	{
		[Token(Token = "0x4000D4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string _fabricManagerPrefabPath;

		[Token(Token = "0x4000D4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _isPresent;

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x9B5BDC", Offset = "0x9B5BDC", VA = "0x9B5BDC")]
		public FabricSpringBoard()
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x9B5C58", Offset = "0x9B5C58", VA = "0x9B5C58")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x9B5CC4", Offset = "0x9B5CC4", VA = "0x9B5CC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x9B5CC8", Offset = "0x9B5CC8", VA = "0x9B5CC8")]
		public void Load()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x9B5E3C", Offset = "0x9B5E3C", VA = "0x9B5E3C")]
		public static FabricManager GetFabricManagerInEditor()
		{
			return null;
		}
	}
}
