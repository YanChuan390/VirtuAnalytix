using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RayFire.DotNet;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RayFire;

[Serializable]
[Token(Token = "0x2000002")]
public class RFFace
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float area;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 pos;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 normal;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<int> tris;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1C07634", Offset = "0x1C07634", VA = "0x1C07634")]
	public RFFace(int Id, float Area, Vector3 Normal)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1C076EC", Offset = "0x1C076EC", VA = "0x1C076EC")]
	private List<RFFace> GetFaces(List<RFTriangle> Triangles)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000003")]
public class RFTriangle
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float area;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 normal;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 pos;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<int> neibs;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x19C0784", Offset = "0x19C0784", VA = "0x19C0784")]
	public RFTriangle(int Id, float Area, Vector3 Normal, Vector3 Pos)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x19B79EC", Offset = "0x19B79EC", VA = "0x19B79EC")]
	public static void SetTriangles(RFShard shard, MeshFilter mf)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x19B8B54", Offset = "0x19B8B54", VA = "0x19B8B54")]
	public static void Clear(RFShard shard)
	{
	}
}
[Serializable]
[Token(Token = "0x2000004")]
public class RFManDemolition
{
	[Token(Token = "0x2000067")]
	public enum FragmentParentType
	{
		[Token(Token = "0x400042A")]
		Manager,
		[Token(Token = "0x400042B")]
		Parent
	}

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public FragmentParentType parent;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int maximumAmount;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int badMeshTry;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sizeThreshold;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int currentAmount;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1C12050", Offset = "0x1C12050", VA = "0x1C12050")]
	public RFManDemolition()
	{
	}
}
[Serializable]
[Token(Token = "0x2000005")]
public class RFMaterial
{
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string name;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool destructible;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int solidity;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float density;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float drag;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float angularDrag;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public PhysicMaterial material;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float dynamicFriction;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float staticFriction;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float bounciness;

	[Token(Token = "0x17000001")]
	public PhysicMaterial Material
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1C12104", Offset = "0x1C12104", VA = "0x1C12104")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1C12070", Offset = "0x1C12070", VA = "0x1C12070")]
	public RFMaterial(string Name, float Density, float Drag, float AngularDrag, int Solidity, bool Destructible, float DynFriction, float StFriction, float Bounce)
	{
	}
}
[Serializable]
[Token(Token = "0x2000006")]
public class RFMaterialPresets
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFMaterial heavyMetal;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RFMaterial lightMetal;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFMaterial denseRock;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFMaterial porousRock;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFMaterial concrete;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFMaterial brick;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFMaterial glass;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFMaterial rubber;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFMaterial ice;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFMaterial wood;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1C121BC", Offset = "0x1C121BC", VA = "0x1C121BC")]
	public RFMaterialPresets()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1C126AC", Offset = "0x1C126AC", VA = "0x1C126AC")]
	public void SetMaterials()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1C12A7C", Offset = "0x1C12A7C", VA = "0x1C12A7C")]
	public float Density(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1C12B2C", Offset = "0x1C12B2C", VA = "0x1C12B2C")]
	public float Drag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1C12BDC", Offset = "0x1C12BDC", VA = "0x1C12BDC")]
	public float AngularDrag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1C12C90", Offset = "0x1C12C90", VA = "0x1C12C90")]
	public int Solidity(MaterialType materialType)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1C12D40", Offset = "0x1C12D40", VA = "0x1C12D40")]
	public bool Destructible(MaterialType materialType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1C12DF8", Offset = "0x1C12DF8", VA = "0x1C12DF8")]
	public static PhysicMaterial Material(MaterialType materialType)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class RFPoolingParticles
{
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16C10", Offset = "0xD16C10")]
	private sealed class <StartPoolingCor>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFPoolingParticles <>4__this;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform manTm;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x19B283C", Offset = "0x19B283C", VA = "0x19B283C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x19B28A4", Offset = "0x19B28A4", VA = "0x19B28A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x19B26A4", Offset = "0x19B26A4", VA = "0x19B26A4")]
		[DebuggerHidden]
		public <StartPoolingCor>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x19B26D0", Offset = "0x19B26D0", VA = "0x19B26D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x19B26D4", Offset = "0x19B26D4", VA = "0x19B26D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x19B2844", Offset = "0x19B2844", VA = "0x19B2844", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD16F40", Offset = "0xD16F40")]
	public int capacity;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public int poolRate;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public ParticleSystem poolInstance;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Transform poolRoot;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public List<ParticleSystem> poolList;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public bool inProgress;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x19B2138", Offset = "0x19B2138", VA = "0x19B2138")]
	public RFPoolingParticles()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x19B21C8", Offset = "0x19B21C8", VA = "0x19B21C8")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x19B22DC", Offset = "0x19B22DC", VA = "0x19B22DC")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x19B240C", Offset = "0x19B240C", VA = "0x19B240C")]
	public static ParticleSystem CreateParticleInstance()
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x19B24B0", Offset = "0x19B24B0", VA = "0x19B24B0")]
	public ParticleSystem GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x19B254C", Offset = "0x19B254C", VA = "0x19B254C")]
	private ParticleSystem CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x19B260C", Offset = "0x19B260C", VA = "0x19B260C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1AEC0", Offset = "0xD1AEC0")]
	public IEnumerator StartPoolingCor(Transform manTm)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class RFPoolingFragment
{
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16C20", Offset = "0xD16C20")]
	private sealed class <StartPoolingCor>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFPoolingFragment <>4__this;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform manTm;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x1700002C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x19B20C8", Offset = "0x19B20C8", VA = "0x19B20C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x19B2130", Offset = "0x19B2130", VA = "0x19B2130", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x19B1F34", Offset = "0x19B1F34", VA = "0x19B1F34")]
		[DebuggerHidden]
		public <StartPoolingCor>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x19B1F60", Offset = "0x19B1F60", VA = "0x19B1F60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x19B1F64", Offset = "0x19B1F64", VA = "0x19B1F64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x19B20D0", Offset = "0x19B20D0", VA = "0x19B20D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD16FAC", Offset = "0xD16FAC")]
	public int capacity;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int poolRate;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RayfireRigid poolInstance;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform poolRoot;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<RayfireRigid> poolList;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool inProgress;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x19B18CC", Offset = "0x19B18CC", VA = "0x19B18CC")]
	public RFPoolingFragment()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x19B195C", Offset = "0x19B195C", VA = "0x19B195C")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x19B1A70", Offset = "0x19B1A70", VA = "0x19B1A70")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x19B1B8C", Offset = "0x19B1B8C", VA = "0x19B1B8C")]
	public static RayfireRigid CreateRigidInstance()
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x19B1D44", Offset = "0x19B1D44", VA = "0x19B1D44")]
	public RayfireRigid GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x19B1DDC", Offset = "0x19B1DDC", VA = "0x19B1DDC")]
	private RayfireRigid CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x19B1E9C", Offset = "0x19B1E9C", VA = "0x19B1E9C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1AF24", Offset = "0xD1AF24")]
	public IEnumerator StartPoolingCor(Transform manTm)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000009")]
public class RFStorage
{
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16C30", Offset = "0xD16C30")]
	private sealed class <StorageCor>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFStorage <>4__this;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x1700002E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x19BCA44", Offset = "0x19BCA44", VA = "0x19BCA44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x19BCAAC", Offset = "0x19BCAAC", VA = "0x19BCAAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x19BC5DC", Offset = "0x19BC5DC", VA = "0x19BC5DC")]
		[DebuggerHidden]
		public <StorageCor>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x19BC7D4", Offset = "0x19BC7D4", VA = "0x19BC7D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x19BC7D8", Offset = "0x19BC7D8", VA = "0x19BC7D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x19BCA4C", Offset = "0x19BCA4C", VA = "0x19BCA4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Transform> storageList;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform storageRoot;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool inProgress;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float rate;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x19BC3AC", Offset = "0x19BC3AC", VA = "0x19BC3AC")]
	public RFStorage()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x19BC430", Offset = "0x19BC430", VA = "0x19BC430")]
	public void CreateStorageRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x19BC560", Offset = "0x19BC560", VA = "0x19BC560")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1AF88", Offset = "0xD1AF88")]
	public IEnumerator StorageCor()
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x19BC608", Offset = "0x19BC608", VA = "0x19BC608")]
	public void Register(Transform tm)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x19BC698", Offset = "0x19BC698", VA = "0x19BC698")]
	public void DestroyAll()
	{
	}
}
[Serializable]
[Token(Token = "0x200000A")]
public class RFCluster : IComparable<RFCluster>
{
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform tm;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public int depth;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public Vector3 pos;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion rot;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Vector3 scl;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[HideInInspector]
	public Bounds bound;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[HideInInspector]
	public bool demolishable;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public RayfireRigid rigid;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public List<RFShard> shards;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public float areaCollapse;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public float minimumArea;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public float maximumArea;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[HideInInspector]
	public float sizeCollapse;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public float minimumSize;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public float maximumSize;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public int randomCollapse;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[HideInInspector]
	public int randomSeed;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public bool cachedHost;

	[NonSerialized]
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool initialized;

	[NonSerialized]
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public RFCluster mainCluster;

	[NonSerialized]
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<RFCluster> childClusters;

	[NonSerialized]
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<RFCluster> neibClusters;

	[NonSerialized]
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<float> neibArea;

	[NonSerialized]
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<float> neibPerc;

	[NonSerialized]
	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private List<RFShard> checkShards;

	[NonSerialized]
	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private List<RFShard> newClusterShards;

	[Token(Token = "0x17000002")]
	public bool HasChildClusters
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1C5940C", Offset = "0x1C5940C", VA = "0x1C5940C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000003")]
	public bool UnyieldingByShard
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1C5CDAC", Offset = "0x1C5CDAC", VA = "0x1C5CDAC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000004")]
	public bool UnyieldingByRigid
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1C5CE50", Offset = "0x1C5CE50", VA = "0x1C5CE50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1C5A364", Offset = "0x1C5A364", VA = "0x1C5A364")]
	public RFCluster()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1C57734", Offset = "0x1C57734", VA = "0x1C57734")]
	public RFCluster(RFCluster source)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1C5A49C", Offset = "0x1C5A49C", VA = "0x1C5A49C", Slot = "4")]
	public int CompareTo(RFCluster otherCluster)
	{
		return default(int);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1C57A48", Offset = "0x1C57A48", VA = "0x1C57A48")]
	public static void InitCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1C5A520", Offset = "0x1C5A520", VA = "0x1C5A520")]
	private static void InitConnectedCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1C5A74C", Offset = "0x1C5A74C", VA = "0x1C5A74C")]
	private static void InitNestedCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1C5A964", Offset = "0x1C5A964", VA = "0x1C5A964")]
	public static void ConnectivityUnyCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1C5B0F0", Offset = "0x1C5B0F0", VA = "0x1C5B0F0")]
	public static void ConnectivityCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1C5AE64", Offset = "0x1C5AE64", VA = "0x1C5AE64")]
	public static void NewClusterByShards(RFCluster mainCLuster, List<RFShard> shards)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1C5B600", Offset = "0x1C5B600", VA = "0x1C5B600")]
	public void AddChildCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1C5AFC8", Offset = "0x1C5AFC8", VA = "0x1C5AFC8")]
	public static void ReduceChildClusters(RFCluster cluster)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1C5B798", Offset = "0x1C5B798", VA = "0x1C5B798")]
	public static Bounds GetChildrenBound(Transform tm)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1C5BE84", Offset = "0x1C5BE84", VA = "0x1C5BE84")]
	public static Bounds GetClusterBound(RFCluster cluster)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1C5B8D4", Offset = "0x1C5B8D4", VA = "0x1C5B8D4")]
	public static Bounds GetBoundsBound(List<Bounds> bounds)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1C5C014", Offset = "0x1C5C014", VA = "0x1C5C014")]
	public static Bounds GetShardsBound(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1C5C500", Offset = "0x1C5C500", VA = "0x1C5C500")]
	public static Bounds GetShardsBoundByPosition(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1C5B6A4", Offset = "0x1C5B6A4", VA = "0x1C5B6A4")]
	public static int GetBiggestCluster(List<RFCluster> clusters)
	{
		return default(int);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1C5CA40", Offset = "0x1C5CA40", VA = "0x1C5CA40")]
	public static void GetSoloShards(RFCluster cluster, List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1C5B528", Offset = "0x1C5B528", VA = "0x1C5B528")]
	public static int GetUniqClusterId(RFCluster cluster)
	{
		return default(int);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1C5CB90", Offset = "0x1C5CB90", VA = "0x1C5CB90")]
	public static bool IntegrityCheck(RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1C5CC74", Offset = "0x1C5CC74", VA = "0x1C5CC74")]
	public static void CreateClusterRoot(RFCluster cluster, Vector3 pos, Quaternion rot, int layer, string tag, string nm)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1C5CF04", Offset = "0x1C5CF04", VA = "0x1C5CF04")]
	private List<RFShard> GetNestedShards(bool OwnShards = false)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1C5D068", Offset = "0x1C5D068", VA = "0x1C5D068")]
	public List<RFCluster> GetNestedClusters()
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1C5D174", Offset = "0x1C5D174", VA = "0x1C5D174")]
	private bool TrisNeib(RFCluster otherCluster)
	{
		return default(bool);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1C5D4B4", Offset = "0x1C5D4B4", VA = "0x1C5D4B4")]
	private float NeibArea(RFCluster otherCluster)
	{
		return default(float);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1C5D7FC", Offset = "0x1C5D7FC", VA = "0x1C5D7FC")]
	public int GetNeibIndArea([Optional] List<RFCluster> clusterList)
	{
		return default(int);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1C5D928", Offset = "0x1C5D928", VA = "0x1C5D928")]
	public static void SetClusterNeib(List<RFCluster> clusters, bool connectivity)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1C5E05C", Offset = "0x1C5E05C", VA = "0x1C5E05C")]
	public static RFCluster GetNeibClusterArea(List<RFCluster> clusters, List<RFCluster> clusterList)
	{
		return null;
	}
}
[Token(Token = "0x200000B")]
public class RFEvent
{
	[Token(Token = "0x200006B")]
	public delegate void EventAction(RayfireRigid rigid);

	[Token(Token = "0x14000001")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1C696E8", Offset = "0x1C696E8", VA = "0x1C696E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1AFEC", Offset = "0xD1AFEC")]
		add
		{
		}
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1C6978C", Offset = "0x1C6978C", VA = "0x1C6978C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1AFFC", Offset = "0xD1AFFC")]
		remove
		{
		}
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1C56098", Offset = "0x1C56098", VA = "0x1C56098")]
	public void InvokeLocalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1C575B4", Offset = "0x1C575B4", VA = "0x1C575B4")]
	public RFEvent()
	{
	}
}
[Token(Token = "0x200000C")]
public class RFDemolitionEvent : RFEvent
{
	[Token(Token = "0x14000002")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1C66AD8", Offset = "0x1C66AD8", VA = "0x1C66AD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B00C", Offset = "0xD1B00C")]
		add
		{
		}
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1C66B8C", Offset = "0x1C66B8C", VA = "0x1C66B8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B01C", Offset = "0xD1B01C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1C63C24", Offset = "0x1C63C24", VA = "0x1C63C24")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1C66C40", Offset = "0x1C66C40", VA = "0x1C66C40")]
	public RFDemolitionEvent()
	{
	}
}
[Token(Token = "0x200000D")]
public class RFActivationEvent : RFEvent
{
	[Token(Token = "0x14000003")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1C570B0", Offset = "0x1C570B0", VA = "0x1C570B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B02C", Offset = "0xD1B02C")]
		add
		{
		}
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1C57164", Offset = "0x1C57164", VA = "0x1C57164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B03C", Offset = "0xD1B03C")]
		remove
		{
		}
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1C560A8", Offset = "0x1C560A8", VA = "0x1C560A8")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1C575AC", Offset = "0x1C575AC", VA = "0x1C575AC")]
	public RFActivationEvent()
	{
	}
}
[Token(Token = "0x200000E")]
public class RFRestrictionEvent : RFEvent
{
	[Token(Token = "0x14000004")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x19B6878", Offset = "0x19B6878", VA = "0x19B6878")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B04C", Offset = "0xD1B04C")]
		add
		{
		}
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x19B692C", Offset = "0x19B692C", VA = "0x19B692C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B05C", Offset = "0xD1B05C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x19B69E0", Offset = "0x19B69E0", VA = "0x19B69E0")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x19B6A4C", Offset = "0x19B6A4C", VA = "0x19B6A4C")]
	public RFRestrictionEvent()
	{
	}
}
[Token(Token = "0x200000F")]
public class RFShotEvent
{
	[Token(Token = "0x200006C")]
	public delegate void EventAction(RayfireGun gun);

	[Token(Token = "0x14000005")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x19BA5B0", Offset = "0x19BA5B0", VA = "0x19BA5B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B06C", Offset = "0xD1B06C")]
		add
		{
		}
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x19BA664", Offset = "0x19BA664", VA = "0x19BA664")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B07C", Offset = "0xD1B07C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x19BA718", Offset = "0x19BA718", VA = "0x19BA718")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B08C", Offset = "0xD1B08C")]
		add
		{
		}
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x19BA7BC", Offset = "0x19BA7BC", VA = "0x19BA7BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B09C", Offset = "0xD1B09C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x19BA860", Offset = "0x19BA860", VA = "0x19BA860")]
	public static void InvokeGlobalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x19BAC5C", Offset = "0x19BAC5C", VA = "0x19BAC5C")]
	public void InvokeLocalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x19BAC6C", Offset = "0x19BAC6C", VA = "0x19BAC6C")]
	public RFShotEvent()
	{
	}
}
[Token(Token = "0x2000010")]
public class RFExplosionEvent
{
	[Token(Token = "0x200006D")]
	public delegate void EventAction(RayfireBomb bomb);

	[Token(Token = "0x14000007")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1C69874", Offset = "0x1C69874", VA = "0x1C69874")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B0AC", Offset = "0xD1B0AC")]
		add
		{
		}
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1C69928", Offset = "0x1C69928", VA = "0x1C69928")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B0BC", Offset = "0xD1B0BC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1C699DC", Offset = "0x1C699DC", VA = "0x1C699DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B0CC", Offset = "0xD1B0CC")]
		add
		{
		}
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1C69A80", Offset = "0x1C69A80", VA = "0x1C69A80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B0DC", Offset = "0xD1B0DC")]
		remove
		{
		}
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1C69B24", Offset = "0x1C69B24", VA = "0x1C69B24")]
	public static void InvokeGlobalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1C69F20", Offset = "0x1C69F20", VA = "0x1C69F20")]
	public void InvokeLocalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1C69F30", Offset = "0x1C69F30", VA = "0x1C69F30")]
	public RFExplosionEvent()
	{
	}
}
[Token(Token = "0x2000011")]
public class RFSliceEvent
{
	[Token(Token = "0x200006E")]
	public delegate void EventAction(RayfireBlade blade);

	[Token(Token = "0x14000009")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x19BAD78", Offset = "0x19BAD78", VA = "0x19BAD78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B0EC", Offset = "0xD1B0EC")]
		add
		{
		}
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x19BAE2C", Offset = "0x19BAE2C", VA = "0x19BAE2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B0FC", Offset = "0xD1B0FC")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x19BAEE0", Offset = "0x19BAEE0", VA = "0x19BAEE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B10C", Offset = "0xD1B10C")]
		add
		{
		}
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x19BAF84", Offset = "0x19BAF84", VA = "0x19BAF84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD1B11C", Offset = "0xD1B11C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x19BB028", Offset = "0x19BB028", VA = "0x19BB028")]
	public static void InvokeGlobalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x19BB424", Offset = "0x19BB424", VA = "0x19BB424")]
	public void InvokeLocalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x19BB434", Offset = "0x19BB434", VA = "0x19BB434")]
	public RFSliceEvent()
	{
	}
}
[Serializable]
[Token(Token = "0x2000012")]
public class RFFlash
{
	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD17178", Offset = "0xD17178")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17178", Offset = "0xD17178")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17178", Offset = "0xD17178")]
	public float intensityMin;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD171E4", Offset = "0xD171E4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD171E4", Offset = "0xD171E4")]
	public float intensityMax;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1722C", Offset = "0xD1722C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1722C", Offset = "0xD1722C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1722C", Offset = "0xD1722C")]
	public float rangeMin;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17298", Offset = "0xD17298")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17298", Offset = "0xD17298")]
	public float rangeMax;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD172E0", Offset = "0xD172E0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD172E0", Offset = "0xD172E0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD172E0", Offset = "0xD172E0")]
	public float distance;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1734C", Offset = "0xD1734C")]
	public Color color;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1C0B16C", Offset = "0x1C0B16C", VA = "0x1C0B16C")]
	public RFFlash()
	{
	}
}
[Serializable]
[Token(Token = "0x2000013")]
public class RFDecals
{
	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD17360", Offset = "0xD17360")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17360", Offset = "0xD17360")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17360", Offset = "0xD17360")]
	public float sizeMin;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD173CC", Offset = "0xD173CC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD173CC", Offset = "0xD173CC")]
	public float sizeMax;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD17414", Offset = "0xD17414")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17414", Offset = "0xD17414")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17414", Offset = "0xD17414")]
	public float distance;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1C61DD0", Offset = "0x1C61DD0", VA = "0x1C61DD0")]
	public RFDecals()
	{
	}
}
[Serializable]
[Token(Token = "0x2000014")]
public class RFMesh
{
	[Serializable]
	[Token(Token = "0x200006F")]
	public class RFSubMeshTris
	{
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<int> triangles;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1C13E90", Offset = "0x1C13E90", VA = "0x1C13E90")]
		public RFSubMeshTris()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1C1366C", Offset = "0x1C1366C", VA = "0x1C1366C")]
		public RFSubMeshTris(List<int> tris)
		{
		}
	}

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool compress;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int subMeshCount;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Bounds bounds;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int[] triangles;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<RFSubMeshTris> subTriangles;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2[] uv;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3[] vertices;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4[] tangents;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> uvComp;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<int> verticesComp;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<int> tangentsComp;

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1C13124", Offset = "0x1C13124", VA = "0x1C13124")]
	public RFMesh(Mesh mesh, bool comp = false)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1C136A0", Offset = "0x1C136A0", VA = "0x1C136A0")]
	public Mesh GetMesh()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1C137CC", Offset = "0x1C137CC", VA = "0x1C137CC")]
	private void LoadTriangles(Mesh mesh)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1C0D8A0", Offset = "0x1C0D8A0", VA = "0x1C0D8A0")]
	public static Mesh BakeMesh(SkinnedMeshRenderer skin)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1C13D68", Offset = "0x1C13D68", VA = "0x1C13D68")]
	public static void ConvertRfMeshes(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1C13A3C", Offset = "0x1C13A3C", VA = "0x1C13A3C")]
	private static Vector2[] SetCompressedUv(List<int> uvComp)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1C138A8", Offset = "0x1C138A8", VA = "0x1C138A8")]
	private static Vector3[] SetCompressedVertices(List<int> verticesComp)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1C13BA8", Offset = "0x1C13BA8", VA = "0x1C13BA8")]
	private static Vector4[] SetCompressedTangents(List<int> tangentsComp)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000015")]
public class RFParticleNoise
{
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1748C", Offset = "0xD1748C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1748C", Offset = "0xD1748C")]
	public bool enabled;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD174DC", Offset = "0xD174DC")]
	public ParticleSystemNoiseQuality quality;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD174F0", Offset = "0xD174F0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD174F0", Offset = "0xD174F0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD174F0", Offset = "0xD174F0")]
	public float strengthMin;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17564", Offset = "0xD17564")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17564", Offset = "0xD17564")]
	public float strengthMax;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD175A8", Offset = "0xD175A8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD175A8", Offset = "0xD175A8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD175A8", Offset = "0xD175A8")]
	public float frequency;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17620", Offset = "0xD17620")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17620", Offset = "0xD17620")]
	public float scrollSpeed;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17670", Offset = "0xD17670")]
	public bool damping;

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1C14504", Offset = "0x1C14504", VA = "0x1C14504")]
	public RFParticleNoise()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1C14548", Offset = "0x1C14548", VA = "0x1C14548")]
	public void CopyFrom(RFParticleNoise source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000016")]
public class RFParticleRendering
{
	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD17684", Offset = "0xD17684")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17684", Offset = "0xD17684")]
	public bool castShadows;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD176D4", Offset = "0xD176D4")]
	public bool receiveShadows;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD176E8", Offset = "0xD176E8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD176E8", Offset = "0xD176E8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD176E8", Offset = "0xD176E8")]
	public LightProbeUsage lightProbes;

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1C14594", Offset = "0x1C14594", VA = "0x1C14594")]
	public RFParticleRendering()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1C145C4", Offset = "0x1C145C4", VA = "0x1C145C4")]
	public void CopyFrom(RFParticleRendering source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000017")]
public class RFParticleDynamicDebris
{
	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1774C", Offset = "0xD1774C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1774C", Offset = "0xD1774C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1774C", Offset = "0xD1774C")]
	public float speedMin;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD177B4", Offset = "0xD177B4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD177B4", Offset = "0xD177B4")]
	public float speedMax;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD177F8", Offset = "0xD177F8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD177F8", Offset = "0xD177F8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD177F8", Offset = "0xD177F8")]
	public float velocityMin;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1786C", Offset = "0xD1786C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1786C", Offset = "0xD1786C")]
	public float velocityMax;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD178B0", Offset = "0xD178B0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD178B0", Offset = "0xD178B0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD178B0", Offset = "0xD178B0")]
	public float gravityMin;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17918", Offset = "0xD17918")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17918", Offset = "0xD17918")]
	public float gravityMax;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD17968", Offset = "0xD17968")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17968", Offset = "0xD17968")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17968", Offset = "0xD17968")]
	public float rotationSpeed;

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1C142E0", Offset = "0x1C142E0", VA = "0x1C142E0")]
	public RFParticleDynamicDebris()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1C1432C", Offset = "0x1C1432C", VA = "0x1C1432C")]
	public void CopyFrom(RFParticleDynamicDebris source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000018")]
public class RFParticleDynamicDust
{
	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD179D0", Offset = "0xD179D0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD179D0", Offset = "0xD179D0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD179D0", Offset = "0xD179D0")]
	public float speedMin;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17A38", Offset = "0xD17A38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17A38", Offset = "0xD17A38")]
	public float speedMax;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD17A7C", Offset = "0xD17A7C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17A7C", Offset = "0xD17A7C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17A7C", Offset = "0xD17A7C")]
	public float rotation;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD17AE4", Offset = "0xD17AE4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17AE4", Offset = "0xD17AE4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17AE4", Offset = "0xD17AE4")]
	public float gravityMin;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17B4C", Offset = "0xD17B4C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17B4C", Offset = "0xD17B4C")]
	public float gravityMax;

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1C14378", Offset = "0x1C14378", VA = "0x1C14378")]
	public RFParticleDynamicDust()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1C143B4", Offset = "0x1C143B4", VA = "0x1C143B4")]
	public void CopyFrom(RFParticleDynamicDust source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000019")]
public class RFParticleEmission
{
	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD17B9C", Offset = "0xD17B9C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17B9C", Offset = "0xD17B9C")]
	public RFParticles.BurstType burstType;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17BEC", Offset = "0xD17BEC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17BEC", Offset = "0xD17BEC")]
	public int burstAmount;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD17C34", Offset = "0xD17C34")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17C34", Offset = "0xD17C34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17C34", Offset = "0xD17C34")]
	public float distanceRate;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17C9C", Offset = "0xD17C9C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17C9C", Offset = "0xD17C9C")]
	public float duration;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD17CE0", Offset = "0xD17CE0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17CE0", Offset = "0xD17CE0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17CE0", Offset = "0xD17CE0")]
	public float lifeMin;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17D4C", Offset = "0xD17D4C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17D4C", Offset = "0xD17D4C")]
	public float lifeMax;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD17D94", Offset = "0xD17D94")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17D94", Offset = "0xD17D94")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17D94", Offset = "0xD17D94")]
	public float sizeMin;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17E00", Offset = "0xD17E00")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17E00", Offset = "0xD17E00")]
	public float sizeMax;

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1C143F0", Offset = "0x1C143F0", VA = "0x1C143F0")]
	public RFParticleEmission()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1C14438", Offset = "0x1C14438", VA = "0x1C14438")]
	public void CopyFrom(RFParticleEmission source)
	{
	}
}
[Serializable]
[Token(Token = "0x200001A")]
public class RFParticleLimitations
{
	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD17E48", Offset = "0xD17E48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17E48", Offset = "0xD17E48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17E48", Offset = "0xD17E48")]
	public int minParticles;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17EC0", Offset = "0xD17EC0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17EC0", Offset = "0xD17EC0")]
	public int maxParticles;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD17F08", Offset = "0xD17F08")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17F08", Offset = "0xD17F08")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17F08", Offset = "0xD17F08")]
	public int percentage;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17F74", Offset = "0xD17F74")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17F74", Offset = "0xD17F74")]
	public float sizeThreshold;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD17FBC", Offset = "0xD17FBC")]
	public int demolitionDepth;

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1C14484", Offset = "0x1C14484", VA = "0x1C14484")]
	public RFParticleLimitations()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1C144C8", Offset = "0x1C144C8", VA = "0x1C144C8")]
	public void CopyFrom(RFParticleLimitations source)
	{
	}
}
[Serializable]
[Token(Token = "0x200001B")]
public class RFParticleCollisionDebris
{
	[Token(Token = "0x2000070")]
	public enum RFParticleCollisionMatType
	{
		[Token(Token = "0x400043C")]
		ByPhysicalMaterial,
		[Token(Token = "0x400043D")]
		ByProperties
	}

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD17FFC", Offset = "0xD17FFC")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD17FFC", Offset = "0xD17FFC")]
	public LayerMask collidesWith;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1804C", Offset = "0xD1804C")]
	public ParticleSystemCollisionQuality quality;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18060", Offset = "0xD18060")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18060", Offset = "0xD18060")]
	public float radiusScale;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD180B4", Offset = "0xD180B4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD180B4", Offset = "0xD180B4")]
	public RFParticleCollisionMatType dampenType;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18104", Offset = "0xD18104")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18104", Offset = "0xD18104")]
	public float dampenMin;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18148", Offset = "0xD18148")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18148", Offset = "0xD18148")]
	public float dampenMax;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1818C", Offset = "0xD1818C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1818C", Offset = "0xD1818C")]
	public RFParticleCollisionMatType bounceType;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD181DC", Offset = "0xD181DC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD181DC", Offset = "0xD181DC")]
	public float bounceMin;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18220", Offset = "0xD18220")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18220", Offset = "0xD18220")]
	public float bounceMax;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public bool propertiesSet;

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1C13F9C", Offset = "0x1C13F9C", VA = "0x1C13F9C")]
	public RFParticleCollisionDebris()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1C13FFC", Offset = "0x1C13FFC", VA = "0x1C13FFC")]
	public void CopyFrom(RFParticleCollisionDebris source)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1C14060", Offset = "0x1C14060", VA = "0x1C14060")]
	public void SetMaterialProps(RayfireDebris debris)
	{
	}
}
[Serializable]
[Token(Token = "0x200001C")]
public class RFParticleCollisionDust
{
	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD18274", Offset = "0xD18274")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18274", Offset = "0xD18274")]
	public LayerMask collidesWith;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD182C4", Offset = "0xD182C4")]
	public ParticleSystemCollisionQuality quality;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD182D8", Offset = "0xD182D8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD182D8", Offset = "0xD182D8")]
	public float radiusScale;

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1C14278", Offset = "0x1C14278", VA = "0x1C14278")]
	public RFParticleCollisionDust()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1C142B4", Offset = "0x1C142B4", VA = "0x1C142B4")]
	public void CopyFrom(RFParticleCollisionDust source)
	{
	}
}
[Serializable]
[Token(Token = "0x200001D")]
public class RFParticles
{
	[Token(Token = "0x2000071")]
	public enum RFParticleCollisionMatType
	{
		[Token(Token = "0x400043F")]
		ByPhysicalMaterial,
		[Token(Token = "0x4000440")]
		ByProperties
	}

	[Token(Token = "0x2000072")]
	public enum BurstType
	{
		[Token(Token = "0x4000442")]
		None,
		[Token(Token = "0x4000443")]
		TotalAmount,
		[Token(Token = "0x4000444")]
		PerOneUnitSize,
		[Token(Token = "0x4000445")]
		FragmentAmount
	}

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ParticleSystem.MinMaxCurve constantCurve;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string debrisStr;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string dustStr;

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1C145F0", Offset = "0x1C145F0", VA = "0x1C145F0")]
	public static void SetParticleComponents(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1C14924", Offset = "0x1C14924", VA = "0x1C14924")]
	public static void SetParticleComponents(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1C14D1C", Offset = "0x1C14D1C", VA = "0x1C14D1C")]
	public static void InitDemolitionParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1C14E20", Offset = "0x1C14E20", VA = "0x1C14E20")]
	public static void CreateDemolitionDebris(RayfireRigid source)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1C1526C", Offset = "0x1C1526C", VA = "0x1C1526C")]
	public static void CreateDemolitionDust(RayfireRigid source)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1C16A64", Offset = "0x1C16A64", VA = "0x1C16A64")]
	public static void InitActivationParticlesRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1C16C10", Offset = "0x1C16C10", VA = "0x1C16C10")]
	public static void InitActivationParticlesShard(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1C1612C", Offset = "0x1C1612C", VA = "0x1C1612C")]
	public static void CreateDebrisRigid(RayfireDebris target)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1C16FA8", Offset = "0x1C16FA8", VA = "0x1C16FA8")]
	public static void CreateDebrisShard(RayfireRigidRoot root, RayfireDebris debris, RFShard shard)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1C16730", Offset = "0x1C16730", VA = "0x1C16730")]
	public static void CreateDustRigid(RayfireDust target)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1C1711C", Offset = "0x1C1711C", VA = "0x1C1711C")]
	public static void CreateDustShard(RayfireRigidRoot root, RayfireDust dust, RFShard shard)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1C17290", Offset = "0x1C17290", VA = "0x1C17290")]
	public static ParticleSystem CreateParticleSystemDebris(RayfireDebris debris, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1C175B8", Offset = "0x1C175B8", VA = "0x1C175B8")]
	public static ParticleSystem CreateParticleSystemDust(RayfireDust dust, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1C17730", Offset = "0x1C17730", VA = "0x1C17730")]
	private static ParticleSystem CreateParticleSystem(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1C17920", Offset = "0x1C17920", VA = "0x1C17920")]
	public static void CreateDebrisImpact(RayfireDebris debris, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1C17AE4", Offset = "0x1C17AE4", VA = "0x1C17AE4")]
	public static void CreateDustImpact(RayfireDust dust, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1C156B8", Offset = "0x1C156B8", VA = "0x1C156B8")]
	private static void DetachParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1C17CA8", Offset = "0x1C17CA8", VA = "0x1C17CA8")]
	public static void CopyRigidParticles(RayfireRigid source, RayfireRigid target)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1C180D8", Offset = "0x1C180D8", VA = "0x1C180D8")]
	public static void CopyRootMeshParticles(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1C18AFC", Offset = "0x1C18AFC", VA = "0x1C18AFC")]
	public static void CopyRigidRootParticles(RayfireRigidRoot source, RayfireRigid target)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1C18F2C", Offset = "0x1C18F2C", VA = "0x1C18F2C")]
	public static void SetMain(ParticleSystem.MainModule main, float lifeMin, float lifeMax, float sizeMin, float sizeMax, float gravityMin, float gravityMax, float speedMin, float speedMax, float divergence, int maxParticles, float duration)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1C1919C", Offset = "0x1C1919C", VA = "0x1C1919C")]
	public static void SetEmission(ParticleSystem.EmissionModule emissionModule, float distanceRate, int burstAmount)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1C19300", Offset = "0x1C19300", VA = "0x1C19300")]
	public static void SetShapeMesh(ParticleSystem.ShapeModule shapeModule, Mesh mesh, int emitMatIndex, Vector3 shapeScale)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1C193C0", Offset = "0x1C193C0", VA = "0x1C193C0")]
	public static void SetShapeObject(ParticleSystem.ShapeModule shapeModule)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1C17408", Offset = "0x1C17408", VA = "0x1C17408")]
	public static int GetEmissionMatIndex(Renderer renderer, Material mat)
	{
		return default(int);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1C19410", Offset = "0x1C19410", VA = "0x1C19410")]
	public static void SetVelocity(ParticleSystem.InheritVelocityModule velocity, RFParticleDynamicDebris dynamic)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1C19504", Offset = "0x1C19504", VA = "0x1C19504")]
	public static void SetRotationOverLifeTime(ParticleSystem.RotationOverLifetimeModule rotation, RFParticleDynamicDust dynamic)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1C195D4", Offset = "0x1C195D4", VA = "0x1C195D4")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationByLife(float spin)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1C19808", Offset = "0x1C19808", VA = "0x1C19808")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, float size)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1C19AB0", Offset = "0x1C19AB0", VA = "0x1C19AB0")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, Vector3 size)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1C198B4", Offset = "0x1C198B4", VA = "0x1C198B4")]
	public static ParticleSystem.MinMaxCurve GetCurveSizeOverLifeTime(float val)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1C19BC4", Offset = "0x1C19BC4", VA = "0x1C19BC4")]
	public static void SetRotationBySpeed(ParticleSystem.RotationBySpeedModule rotationBySpeed, float rotationSpeed)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1C19C9C", Offset = "0x1C19C9C", VA = "0x1C19C9C")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationBySpeed(float rotationSpeed)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1C19E6C", Offset = "0x1C19E6C", VA = "0x1C19E6C")]
	public static void SetColorOverLife(ParticleSystem.ColorOverLifetimeModule colorLife, float opacity)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1C1A030", Offset = "0x1C1A030", VA = "0x1C1A030")]
	public static void SetNoise(ParticleSystem.NoiseModule psNoise, RFParticleNoise scrNoise)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1C1A250", Offset = "0x1C1A250", VA = "0x1C1A250")]
	public static void SetCollisionDebris(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDebris coll)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1C1A3A4", Offset = "0x1C1A3A4", VA = "0x1C1A3A4")]
	public static void SetCollisionDust(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDust coll)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1C16220", Offset = "0x1C16220", VA = "0x1C16220")]
	public static void GetDebrisTargets(List<RayfireDebris> filtered, List<RayfireDebris> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1C16824", Offset = "0x1C16824", VA = "0x1C16824")]
	public static void GetDustTargets(List<RayfireDust> filtered, List<RayfireDust> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1C15E5C", Offset = "0x1C15E5C", VA = "0x1C15E5C")]
	public static void SetRigidDebrisFinalAmount(List<RayfireDebris> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1C16460", Offset = "0x1C16460", VA = "0x1C16460")]
	public static void SetDustFinalAmount(List<RayfireDust> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1C17534", Offset = "0x1C17534", VA = "0x1C17534")]
	public static int GetShardFinalAmount(RFShard shard, BurstType burstType, int burstAmount, float sizeSum)
	{
		return default(int);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1C1A44C", Offset = "0x1C1A44C", VA = "0x1C1A44C")]
	public static bool AmountCheck(RayfireRigid source, int pType)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1C1A65C", Offset = "0x1C1A65C", VA = "0x1C1A65C")]
	public RFParticles()
	{
	}
}
[Serializable]
[Token(Token = "0x200001E")]
public class RFShard : IComparable<RFShard>
{
	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float sz;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool uny;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool act;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Bounds bnd;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 pos;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Quaternion rot;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 scl;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public SimType sm;

	[NonSerialized]
	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float m;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int nAm;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<int> nIds;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<float> nArea;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<int> sIds;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<float> nSt;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float sSt;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Transform tm;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public MeshFilter mf;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Collider col;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Rigidbody rb;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public RayfireRigid rigid;

	[NonSerialized]
	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public int fade;

	[NonSerialized]
	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public float fo;

	[NonSerialized]
	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<RFTriangle> tris;

	[NonSerialized]
	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public RFCluster cluster;

	[NonSerialized]
	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public List<RFShard> neibShards;

	[NonSerialized]
	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public bool check;

	[NonSerialized]
	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public bool[] sCheck;

	[Token(Token = "0x17000005")]
	public bool StressState
	{
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x19B8FB0", Offset = "0x19B8FB0", VA = "0x19B8FB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000006")]
	public bool SupportState
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x19B99EC", Offset = "0x19B99EC", VA = "0x19B99EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	public bool InactiveOrKinematic
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x19B9A44", Offset = "0x19B9A44", VA = "0x19B9A44")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x19B7034", Offset = "0x19B7034", VA = "0x19B7034")]
	public RFShard()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x19B70B8", Offset = "0x19B70B8", VA = "0x19B70B8")]
	public RFShard(RFShard source)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x19B734C", Offset = "0x19B734C", VA = "0x19B734C")]
	public RFShard(Transform Tm)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x19B74E8", Offset = "0x19B74E8", VA = "0x19B74E8")]
	public RFShard(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x19B7630", Offset = "0x19B7630", VA = "0x19B7630", Slot = "4")]
	public int CompareTo(RFShard otherShard)
	{
		return default(int);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x19B7660", Offset = "0x19B7660", VA = "0x19B7660")]
	public static void SetShards(RFCluster cluster, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x19B774C", Offset = "0x19B774C", VA = "0x19B774C")]
	public static void SetShardsByTransformList(RFCluster cluster, List<Transform> tmList, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x19B7DC4", Offset = "0x19B7DC4", VA = "0x19B7DC4")]
	public static void SetShardsByRigidList(RFCluster cluster, List<RayfireRigid> rigids, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x19B7ED8", Offset = "0x19B7ED8", VA = "0x19B7ED8")]
	private bool TrisNeib(RFShard otherShard)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x19B8104", Offset = "0x19B8104", VA = "0x19B8104")]
	private float NeibArea(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x19B8374", Offset = "0x19B8374", VA = "0x19B8374")]
	public static void SetShardNeibs(List<RFShard> shards, ConnectivityType type, float minArea = 0f, float minSize = 0f, int perc = 0, int seed = 0)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x19B8BC0", Offset = "0x19B8BC0", VA = "0x19B8BC0")]
	public static void ReinitNeibs(List<RFShard> shards)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x19B8E48", Offset = "0x19B8E48", VA = "0x19B8E48")]
	public static void ReinitNeibsTest(List<RFShard> shards)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x19B8D28", Offset = "0x19B8D28", VA = "0x19B8D28")]
	public void RemoveNeibAt(int ind)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x19B900C", Offset = "0x19B900C", VA = "0x19B900C")]
	public void ClearNeib()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x19B90EC", Offset = "0x19B90EC", VA = "0x19B90EC")]
	public static void SetUnchecked(List<RFShard> shards)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x19B9178", Offset = "0x19B9178", VA = "0x19B9178")]
	public static Plane GetSlicePlane(Bounds bound)
	{
		return default(Plane);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x19B92BC", Offset = "0x19B92BC", VA = "0x19B92BC")]
	public static List<RFShard> SortByDistanceToPoint(List<RFShard> shards, Vector3 point, int amount)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x19B95B4", Offset = "0x19B95B4", VA = "0x19B95B4")]
	public static List<RFShard> SortByDistanceToPlane(List<RFShard> shards, Vector3 point, Vector3 normal, int amount)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x19B98B4", Offset = "0x19B98B4", VA = "0x19B98B4")]
	public static bool UnyieldingByShard(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x19B9950", Offset = "0x19B9950", VA = "0x19B9950")]
	public static bool AllUnyShards(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x19B9A58", Offset = "0x19B9A58", VA = "0x19B9A58")]
	public static RFShard GetShardByCollider(List<RFShard> shards, Collider collider)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x19B9B58", Offset = "0x19B9B58", VA = "0x19B9B58")]
	public static List<RFShard> GetShardsByColliders(List<RFShard> shards, List<Collider> colliders)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200001F")]
public class RFSound
{
	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float multiplier;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip clip;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<AudioClip> clips;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioMixerGroup outputGroup;

	[Token(Token = "0x17000008")]
	public bool HasClips
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x19BB61C", Offset = "0x19BB61C", VA = "0x19BB61C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x19BB480", Offset = "0x19BB480", VA = "0x19BB480")]
	public RFSound()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x19BB4B0", Offset = "0x19BB4B0", VA = "0x19BB4B0")]
	public RFSound(RFSound source)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x19BB678", Offset = "0x19BB678", VA = "0x19BB678")]
	public static void CopySound(RayfireSound source, RayfireRigid target)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x19BB768", Offset = "0x19BB768", VA = "0x19BB768")]
	public static void CopySound(RayfireSound source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x19BB920", Offset = "0x19BB920", VA = "0x19BB920")]
	public static void Play(RayfireSound scr, AudioClip clip, AudioMixerGroup group, float volume)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x19BBB78", Offset = "0x19BBB78", VA = "0x19BBB78")]
	public static void InitializationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x19BBF7C", Offset = "0x19BBF7C", VA = "0x19BBF7C")]
	public static void ActivationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x19BC13C", Offset = "0x19BC13C", VA = "0x19BC13C")]
	public static void DemolitionSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x19BBEB8", Offset = "0x19BBEB8", VA = "0x19BBEB8")]
	public static float GeVolume(RayfireSound scr, float size)
	{
		return default(float);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x19BBD48", Offset = "0x19BBD48", VA = "0x19BBD48")]
	private static bool FilterCheck(RayfireSound scr, float size)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000020")]
public class RFStress
{
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16C40", Offset = "0xD16C40")]
	private sealed class <StressCor>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity scr;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFStress <>4__this;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x17000030")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x19BFF08", Offset = "0x19BFF08", VA = "0x19BFF08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x19BFF70", Offset = "0x19BFF70", VA = "0x19BFF70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x19BCCEC", Offset = "0x19BCCEC", VA = "0x19BCCEC")]
		[DebuggerHidden]
		public <StressCor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x19BFD48", Offset = "0x19BFD48", VA = "0x19BFD48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x19BFD4C", Offset = "0x19BFD4C", VA = "0x19BFD4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x19BFF10", Offset = "0x19BFF10", VA = "0x19BFF10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int threshold;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float erosion;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float interval;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int support;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool exposed;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool bySize;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<RFShard> strShards;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<RFShard> supShards;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 rotCache;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 grvCache;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int supCache;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float sizeCache;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool initialized;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<RFShard> checkShards;

	[NonSerialized]
	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool inProgress;

	[NonSerialized]
	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int strAmount;

	[NonSerialized]
	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int supAmount;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<int> path;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<int> frontier;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<int> frontPrior;

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x19BCAB4", Offset = "0x19BCAB4", VA = "0x19BCAB4")]
	public RFStress()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x19BCB9C", Offset = "0x19BCB9C", VA = "0x19BCB9C")]
	public static void StopStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x19BCBC0", Offset = "0x19BCBC0", VA = "0x19BCBC0")]
	public static void StartStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x19BCC54", Offset = "0x19BCC54", VA = "0x19BCC54")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B12C", Offset = "0xD1B12C")]
	private IEnumerator StressCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x19BCD18", Offset = "0x19BCD18", VA = "0x19BCD18")]
	private bool CheckSupport(RayfireConnectivity scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x19BCFD8", Offset = "0x19BCFD8", VA = "0x19BCFD8")]
	private static void StressErosion(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x19BD5AC", Offset = "0x19BD5AC", VA = "0x19BD5AC")]
	private static void StressCollapse(RayfireConnectivity connectivity, int maxStressValue)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x19BD5F4", Offset = "0x19BD5F4", VA = "0x19BD5F4")]
	private static int RemNeibByStress(RFStress stress, int stressVal)
	{
		return default(int);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x19BD910", Offset = "0x19BD910", VA = "0x19BD910")]
	public static void Initialize(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x19BD984", Offset = "0x19BD984", VA = "0x19BD984")]
	private static bool InitializeNeed(RayfireConnectivity conn)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x19BDB14", Offset = "0x19BDB14", VA = "0x19BDB14")]
	private static void SetStressConnections(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x19BE708", Offset = "0x19BE708", VA = "0x19BE708")]
	private static void SetStressSupport(List<RFShard> shards, RFStress stress)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x19BED5C", Offset = "0x19BED5C", VA = "0x19BED5C")]
	private static void PrepareCheckShards(RFStress stress)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x19BE018", Offset = "0x19BE018", VA = "0x19BE018")]
	private static void SetSizeMultiplier(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x19BF748", Offset = "0x19BF748", VA = "0x19BF748")]
	private static void SetSizeMultiplierOLD(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x19BEDF4", Offset = "0x19BEDF4", VA = "0x19BEDF4")]
	private static List<int> GetPathAstar(RFStress str, List<RFShard> shards, int startId, int lastId)
	{
		return null;
	}
}
[Token(Token = "0x2000021")]
public enum AxisType
{
	[Token(Token = "0x40000DA")]
	XRed,
	[Token(Token = "0x40000DB")]
	YGreen,
	[Token(Token = "0x40000DC")]
	ZBlue
}
[Token(Token = "0x2000022")]
public enum PlaneType
{
	[Token(Token = "0x40000DE")]
	XY,
	[Token(Token = "0x40000DF")]
	XZ,
	[Token(Token = "0x40000E0")]
	YZ
}
[Token(Token = "0x2000023")]
public enum FragType
{
	[Token(Token = "0x40000E2")]
	Voronoi = 0,
	[Token(Token = "0x40000E3")]
	Splinters = 1,
	[Token(Token = "0x40000E4")]
	Slabs = 2,
	[Token(Token = "0x40000E5")]
	Radial = 3,
	[Token(Token = "0x40000E6")]
	Custom = 5,
	[Token(Token = "0x40000E7")]
	Slices = 7,
	[Token(Token = "0x40000E8")]
	Bricks = 9,
	[Token(Token = "0x40000E9")]
	Voxels = 10,
	[Token(Token = "0x40000EA")]
	Tets = 11,
	[Token(Token = "0x40000EB")]
	Decompose = 15
}
[Token(Token = "0x2000024")]
public enum DemolitionType
{
	[Token(Token = "0x40000ED")]
	None = 0,
	[Token(Token = "0x40000EE")]
	Runtime = 1,
	[Token(Token = "0x40000EF")]
	AwakePrecache = 2,
	[Token(Token = "0x40000F0")]
	AwakePrefragment = 3,
	[Token(Token = "0x40000F1")]
	ReferenceDemolition = 9
}
[Token(Token = "0x2000025")]
public enum CachingType
{
	[Token(Token = "0x40000F3")]
	Disable,
	[Token(Token = "0x40000F4")]
	ByFrames,
	[Token(Token = "0x40000F5")]
	ByFragmentsPerFrame
}
[Token(Token = "0x2000026")]
public enum FadeType
{
	[Token(Token = "0x40000F7")]
	None = 0,
	[Token(Token = "0x40000F8")]
	SimExclude = 1,
	[Token(Token = "0x40000F9")]
	FallDown = 2,
	[Token(Token = "0x40000FA")]
	ScaleDown = 3,
	[Token(Token = "0x40000FB")]
	MoveDown = 4,
	[Token(Token = "0x40000FC")]
	Destroy = 5,
	[Token(Token = "0x40000FD")]
	SetStatic = 8,
	[Token(Token = "0x40000FE")]
	SetKinematic = 9
}
[Token(Token = "0x2000027")]
public enum RFFadeLifeType
{
	[Token(Token = "0x4000100")]
	ByLifeTime = 4,
	[Token(Token = "0x4000101")]
	BySimulationAndLifeTime = 8
}
[Token(Token = "0x2000028")]
public enum MaterialType
{
	[Token(Token = "0x4000103")]
	HeavyMetal,
	[Token(Token = "0x4000104")]
	LightMetal,
	[Token(Token = "0x4000105")]
	DenseRock,
	[Token(Token = "0x4000106")]
	PorousRock,
	[Token(Token = "0x4000107")]
	Concrete,
	[Token(Token = "0x4000108")]
	Brick,
	[Token(Token = "0x4000109")]
	Glass,
	[Token(Token = "0x400010A")]
	Rubber,
	[Token(Token = "0x400010B")]
	Ice,
	[Token(Token = "0x400010C")]
	Wood
}
[Token(Token = "0x2000029")]
public enum MassType
{
	[Token(Token = "0x400010E")]
	MaterialDensity,
	[Token(Token = "0x400010F")]
	MassProperty,
	[Token(Token = "0x4000110")]
	RigidBodyComponent
}
[Token(Token = "0x200002A")]
public enum ObjectType
{
	[Token(Token = "0x4000112")]
	Mesh = 0,
	[Token(Token = "0x4000113")]
	MeshRoot = 1,
	[Token(Token = "0x4000114")]
	SkinnedMesh = 2,
	[Token(Token = "0x4000115")]
	NestedCluster = 4,
	[Token(Token = "0x4000116")]
	ConnectedCluster = 5
}
[Token(Token = "0x200002B")]
public enum SimType
{
	[Token(Token = "0x4000118")]
	Dynamic,
	[Token(Token = "0x4000119")]
	Sleeping,
	[Token(Token = "0x400011A")]
	Inactive,
	[Token(Token = "0x400011B")]
	Kinematic,
	[Token(Token = "0x400011C")]
	Static
}
[Token(Token = "0x200002C")]
public enum FragSimType
{
	[Token(Token = "0x400011E")]
	Dynamic,
	[Token(Token = "0x400011F")]
	Sleeping,
	[Token(Token = "0x4000120")]
	Inactive,
	[Token(Token = "0x4000121")]
	Kinematic,
	[Token(Token = "0x4000122")]
	Inherit
}
[Token(Token = "0x200002D")]
public enum ConnectivityType
{
	[Token(Token = "0x4000124")]
	ByBoundingBox,
	[Token(Token = "0x4000125")]
	ByMesh,
	[Token(Token = "0x4000126")]
	ByBoundingBoxAndMesh
}
[Token(Token = "0x200002E")]
public enum FragmentMode
{
	[Token(Token = "0x4000128")]
	Runtime,
	[Token(Token = "0x4000129")]
	Editor
}
[Token(Token = "0x200002F")]
public enum RFColliderType
{
	[Token(Token = "0x400012B")]
	Mesh = 0,
	[Token(Token = "0x400012C")]
	Box = 1,
	[Token(Token = "0x400012D")]
	Sphere = 2,
	[Token(Token = "0x400012E")]
	None = 4
}
[Token(Token = "0x2000030")]
public enum RFParenting
{
	[Token(Token = "0x4000130")]
	Manager = 0,
	[Token(Token = "0x4000131")]
	Parent = 1,
	[Token(Token = "0x4000132")]
	Sphere = 2,
	[Token(Token = "0x4000133")]
	None = 4
}
[Token(Token = "0x2000031")]
public class RFFrag
{
	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Mesh mesh;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 pivot;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFDictionary subId;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RayfireRigid fragment;

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1C0B1D8", Offset = "0x1C0B1D8", VA = "0x1C0B1D8")]
	public RFFrag()
	{
	}
}
[Token(Token = "0x2000032")]
public class RFTri
{
	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int meshId;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int subMeshId;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> ids;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Vector3> vpos;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Vector3> vnormal;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector2> uvs;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Vector4> tangents;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<RFTri> neibTris;

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x19C0604", Offset = "0x19C0604", VA = "0x19C0604")]
	public RFTri()
	{
	}
}
[Serializable]
[Token(Token = "0x2000033")]
public class RFDictionary
{
	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<int> keys;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> values;

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1C695C4", Offset = "0x1C695C4", VA = "0x1C695C4")]
	public RFDictionary(Dictionary<int, int> dictionary)
	{
	}
}
[Serializable]
[Token(Token = "0x2000034")]
public class RFShatterCluster
{
	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int count;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int seed;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float relax;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int amount;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int layers;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scale;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int min;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int max;

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x19BA4E4", Offset = "0x19BA4E4", VA = "0x19BA4E4")]
	public RFShatterCluster()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x19BA538", Offset = "0x19BA538", VA = "0x19BA538")]
	public RFShatterCluster(RFShatterCluster src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000035")]
public class RFVoronoi
{
	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float centerBias;

	[Token(Token = "0x17000009")]
	public int Amount
	{
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x19C08C8", Offset = "0x19C08C8", VA = "0x19C08C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x19C085C", Offset = "0x19C085C", VA = "0x19C085C")]
	public RFVoronoi()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x19C0888", Offset = "0x19C0888", VA = "0x19C0888")]
	public RFVoronoi(RFVoronoi src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000036")]
public class RFSplinters
{
	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AxisType axis;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int amount;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float strength;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float centerBias;

	[Token(Token = "0x1700000A")]
	public int Amount
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x19BC384", Offset = "0x19BC384", VA = "0x19BC384")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x19BC2FC", Offset = "0x19BC2FC", VA = "0x19BC2FC")]
	public RFSplinters()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x19BC334", Offset = "0x19BC334", VA = "0x19BC334")]
	public RFSplinters(RFSplinters src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000037")]
public class RFRadial
{
	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AxisType centerAxis;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float radius;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float divergence;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool restrictToPlane;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int rings;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int focus;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int focusStr;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int randomRings;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int rays;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int randomRays;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int twist;

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x19B28AC", Offset = "0x19B28AC", VA = "0x19B28AC")]
	public RFRadial()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x19B28FC", Offset = "0x19B28FC", VA = "0x19B28FC")]
	public RFRadial(RFRadial src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000038")]
public class RFSlice
{
	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public PlaneType plane;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Transform> sliceList;

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x19BACB8", Offset = "0x19BACB8", VA = "0x19BACB8")]
	public RFSlice()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x19BACE4", Offset = "0x19BACE4", VA = "0x19BACE4")]
	public RFSlice(RFSlice src)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x19BAD28", Offset = "0x19BAD28", VA = "0x19BAD28")]
	public Vector3 Axis(Transform tm)
	{
		return default(Vector3);
	}
}
[Serializable]
[Token(Token = "0x2000039")]
public class RFBricks
{
	[Token(Token = "0x2000074")]
	public enum RFBrickType
	{
		[Token(Token = "0x400044C")]
		ByAmount,
		[Token(Token = "0x400044D")]
		BySize
	}

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFBrickType amountType;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float mult;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int amount_X;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int amount_Y;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int amount_Z;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool size_Lock;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float size_X;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float size_Y;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float size_Z;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int sizeVar_X;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int sizeVar_Y;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int sizeVar_Z;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float offset_X;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float offset_Y;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float offset_Z;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool split_X;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool split_Y;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool split_Z;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int split_probability;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float split_offset;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int split_rotation;

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1C5A0D8", Offset = "0x1C5A0D8", VA = "0x1C5A0D8")]
	public RFBricks()
	{
	}
}
[Serializable]
[Token(Token = "0x200003A")]
public class RFVoxels
{
	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1832C", Offset = "0xD1832C")]
	public float size;

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x19C08F0", Offset = "0x19C08F0", VA = "0x19C08F0")]
	public RFVoxels()
	{
	}
}
[Serializable]
[Token(Token = "0x200003B")]
public class RFTets
{
	[Token(Token = "0x2000075")]
	public enum TetType
	{
		[Token(Token = "0x400044F")]
		Uniform,
		[Token(Token = "0x4000450")]
		Curved
	}

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TetType lattice;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int density;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int noise;

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x19C0584", Offset = "0x19C0584", VA = "0x19C0584")]
	public RFTets()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x19C05BC", Offset = "0x19C05BC", VA = "0x19C05BC")]
	public RFTets(RFTets src)
	{
	}
}
[Serializable]
[Token(Token = "0x200003C")]
public class RFActivation
{
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16C50", Offset = "0xD16C50")]
	private sealed class <ActivationVelocityCor>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFActivation <>4__this;

		[Token(Token = "0x17000032")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x1C56860", Offset = "0x1C56860", VA = "0x1C56860", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1C568C8", Offset = "0x1C568C8", VA = "0x1C568C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1C557A4", Offset = "0x1C557A4", VA = "0x1C557A4")]
		[DebuggerHidden]
		public <ActivationVelocityCor>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1C56718", Offset = "0x1C56718", VA = "0x1C56718", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1C5671C", Offset = "0x1C5671C", VA = "0x1C5671C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1C56868", Offset = "0x1C56868", VA = "0x1C56868", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16C60", Offset = "0xD16C60")]
	private sealed class <ActivationOffsetCor>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFActivation <>4__this;

		[Token(Token = "0x17000034")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x1C566A8", Offset = "0x1C566A8", VA = "0x1C566A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x1C56710", Offset = "0x1C56710", VA = "0x1C56710", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1C55868", Offset = "0x1C55868", VA = "0x1C55868")]
		[DebuggerHidden]
		public <ActivationOffsetCor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1C564F4", Offset = "0x1C564F4", VA = "0x1C564F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1C564F8", Offset = "0x1C564F8", VA = "0x1C564F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1C566B0", Offset = "0x1C566B0", VA = "0x1C566B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16C70", Offset = "0xD16C70")]
	private sealed class <InactiveCor>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFActivation <>4__this;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x17000036")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1C56A08", Offset = "0x1C56A08", VA = "0x1C56A08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x1C56A70", Offset = "0x1C56A70", VA = "0x1C56A70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1C5592C", Offset = "0x1C5592C", VA = "0x1C5592C")]
		[DebuggerHidden]
		public <InactiveCor>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1C568D0", Offset = "0x1C568D0", VA = "0x1C568D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1C568D4", Offset = "0x1C568D4", VA = "0x1C568D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1C56A10", Offset = "0x1C56A10", VA = "0x1C56A10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16C80", Offset = "0xD16C80")]
	private sealed class <InactiveCor>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFActivation <>4__this;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot scr;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x1C57040", Offset = "0x1C57040", VA = "0x1C57040", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x1C570A8", Offset = "0x1C570A8", VA = "0x1C570A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1C559F0", Offset = "0x1C559F0", VA = "0x1C559F0")]
		[DebuggerHidden]
		public <InactiveCor>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1C56A78", Offset = "0x1C56A78", VA = "0x1C56A78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1C56A7C", Offset = "0x1C56A7C", VA = "0x1C56A7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1C57048", Offset = "0x1C57048", VA = "0x1C57048", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD18348", Offset = "0xD18348")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18348", Offset = "0xD18348")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD18348", Offset = "0xD18348")]
	public float byVelocity;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD183BC", Offset = "0xD183BC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD183BC", Offset = "0xD183BC")]
	public float byOffset;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1840C", Offset = "0xD1840C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD1840C", Offset = "0xD1840C")]
	public float byDamage;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1845C", Offset = "0xD1845C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD1845C", Offset = "0xD1845C")]
	public bool byActivator;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD184AC", Offset = "0xD184AC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD184AC", Offset = "0xD184AC")]
	public bool byImpact;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD184FC", Offset = "0xD184FC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD184FC", Offset = "0xD184FC")]
	public bool byConnectivity;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1854C", Offset = "0xD1854C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1854C", Offset = "0xD1854C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD1854C", Offset = "0xD1854C")]
	public bool unyielding;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD185C0", Offset = "0xD185C0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD185C0", Offset = "0xD185C0")]
	public bool activatable;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD18610", Offset = "0xD18610")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18610", Offset = "0xD18610")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD18610", Offset = "0xD18610")]
	public string layer;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public RayfireConnectivity connect;

	[NonSerialized]
	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool activated;

	[NonSerialized]
	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool inactiveCorState;

	[NonSerialized]
	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool velocityCorState;

	[NonSerialized]
	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	public bool offsetCorState;

	[NonSerialized]
	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public IEnumerator velocityEnum;

	[NonSerialized]
	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IEnumerator offsetEnum;

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1C55578", Offset = "0x1C55578", VA = "0x1C55578")]
	public RFActivation()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1C555FC", Offset = "0x1C555FC", VA = "0x1C555FC")]
	public void CopyFrom(RFActivation act)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1C555C4", Offset = "0x1C555C4", VA = "0x1C555C4")]
	public void Reset()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1C55660", Offset = "0x1C55660", VA = "0x1C55660")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1C5570C", Offset = "0x1C5570C", VA = "0x1C5570C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B190", Offset = "0xD1B190")]
	public IEnumerator ActivationVelocityCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1C557D0", Offset = "0x1C557D0", VA = "0x1C557D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B1F4", Offset = "0xD1B1F4")]
	public IEnumerator ActivationOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x1C55894", Offset = "0x1C55894", VA = "0x1C55894")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B258", Offset = "0xD1B258")]
	public IEnumerator InactiveCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1C55958", Offset = "0x1C55958", VA = "0x1C55958")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B2BC", Offset = "0xD1B2BC")]
	public IEnumerator InactiveCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1C55A1C", Offset = "0x1C55A1C", VA = "0x1C55A1C")]
	public static void ActivateRigid(RayfireRigid scr, bool connCheck = true)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1C56110", Offset = "0x1C56110", VA = "0x1C56110")]
	public static bool ActivateShard(RFShard shard, RayfireRigidRoot rigidRoot)
	{
		return default(bool);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1C55FA0", Offset = "0x1C55FA0", VA = "0x1C55FA0")]
	private static void SetRigidActivationLayer(RayfireRigid scr)
	{
	}
}
[Token(Token = "0x200003D")]
public class RFBackupCluster
{
	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFCluster cluster;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool saved;

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1C575BC", Offset = "0x1C575BC", VA = "0x1C575BC")]
	private RFBackupCluster()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1C575E4", Offset = "0x1C575E4", VA = "0x1C575E4")]
	public static void BackupConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1C57D54", Offset = "0x1C57D54", VA = "0x1C57D54")]
	public static void ResetRigidCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1C57F68", Offset = "0x1C57F68", VA = "0x1C57F68")]
	private static void DestroyParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1C585A4", Offset = "0x1C585A4", VA = "0x1C585A4")]
	private static void ResetDeepShardRigid(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1C590D8", Offset = "0x1C590D8", VA = "0x1C590D8")]
	private static void ResetShardRigid(RFShard shard)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1C57AA8", Offset = "0x1C57AA8", VA = "0x1C57AA8")]
	public static void SaveTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1C58C8C", Offset = "0x1C58C8C", VA = "0x1C58C8C")]
	private static void RestoreShardTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1C58A94", Offset = "0x1C58A94", VA = "0x1C58A94")]
	private static void ResetNestedTransformRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x1C586C8", Offset = "0x1C586C8", VA = "0x1C586C8")]
	private static void ResetNestedRootsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x1C58B88", Offset = "0x1C58B88", VA = "0x1C58B88")]
	private static void ResetNestedParentsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x1C58F34", Offset = "0x1C58F34", VA = "0x1C58F34")]
	private static void DestroyRoots(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1C59484", Offset = "0x1C59484", VA = "0x1C59484")]
	private static bool BackupState(RayfireConnectivity scr, bool warning = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x1C596FC", Offset = "0x1C596FC", VA = "0x1C596FC")]
	public static void BackupConnectivity(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1C59800", Offset = "0x1C59800", VA = "0x1C59800")]
	public static void RestoreConnectivity(RayfireConnectivity scr)
	{
	}
}
[Serializable]
[Token(Token = "0x200003E")]
public class RFCollapse
{
	[Token(Token = "0x200007A")]
	public enum RFCollapseType
	{
		[Token(Token = "0x4000462")]
		ByArea = 1,
		[Token(Token = "0x4000463")]
		BySize = 3,
		[Token(Token = "0x4000464")]
		Random = 5
	}

	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16C90", Offset = "0xD16C90")]
	private sealed class <CollapseCor>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFCollapse <>4__this;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <step>5__3;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int <i>5__4;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x1C5FD84", Offset = "0x1C5FD84", VA = "0x1C5FD84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x1C5FDEC", Offset = "0x1C5FDEC", VA = "0x1C5FDEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1C5E534", Offset = "0x1C5E534", VA = "0x1C5E534")]
		[DebuggerHidden]
		public <CollapseCor>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1C5FB90", Offset = "0x1C5FB90", VA = "0x1C5FB90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1C5FB94", Offset = "0x1C5FB94", VA = "0x1C5FB94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1C5FD8C", Offset = "0x1C5FD8C", VA = "0x1C5FD8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16CA0", Offset = "0xD16CA0")]
	private sealed class <CollapseCor>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFCollapse <>4__this;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireConnectivity scr;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <step>5__3;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int <i>5__4;

		[Token(Token = "0x1700003C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x1C5FB20", Offset = "0x1C5FB20", VA = "0x1C5FB20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x1C5FB88", Offset = "0x1C5FB88", VA = "0x1C5FB88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1C5E6B0", Offset = "0x1C5E6B0", VA = "0x1C5E6B0")]
		[DebuggerHidden]
		public <CollapseCor>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1C5F934", Offset = "0x1C5F934", VA = "0x1C5F934", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1C5F938", Offset = "0x1C5F938", VA = "0x1C5F938", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1C5FB28", Offset = "0x1C5FB28", VA = "0x1C5FB28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD18694", Offset = "0xD18694")]
	public RFCollapseType type;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int start;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int end;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int steps;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float duration;

	[NonSerialized]
	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool inProgress;

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1C5E3C0", Offset = "0x1C5E3C0", VA = "0x1C5E3C0")]
	public RFCollapse()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1C5E3F8", Offset = "0x1C5E3F8", VA = "0x1C5E3F8")]
	public static void StartCollapse(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1C5E49C", Offset = "0x1C5E49C", VA = "0x1C5E49C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B320", Offset = "0xD1B320")]
	private IEnumerator CollapseCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1C5E560", Offset = "0x1C5E560", VA = "0x1C5E560")]
	public static void StartCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1C5E68C", Offset = "0x1C5E68C", VA = "0x1C5E68C")]
	public static void StopCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1C5E5F4", Offset = "0x1C5E5F4", VA = "0x1C5E5F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B384", Offset = "0xD1B384")]
	private IEnumerator CollapseCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1C5E6DC", Offset = "0x1C5E6DC", VA = "0x1C5E6DC")]
	public static void AreaCollapse(RayfireRigid scr, int areaPercentage)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1C5E808", Offset = "0x1C5E808", VA = "0x1C5E808")]
	public static void SizeCollapse(RayfireRigid scr, int sizePercentage)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x1C5E794", Offset = "0x1C5E794", VA = "0x1C5E794")]
	public static void AreaCollapse(RayfireRigid scr, float minAreaValue)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x1C5E8C0", Offset = "0x1C5E8C0", VA = "0x1C5E8C0")]
	public static void SizeCollapse(RayfireRigid scr, float minSizeValue)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1C5F058", Offset = "0x1C5F058", VA = "0x1C5F058")]
	public static void RandomCollapse(RayfireRigid scr, int randomValue, int randomSeed)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1C5EC5C", Offset = "0x1C5EC5C", VA = "0x1C5EC5C")]
	private static void CollapseCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x1C5F634", Offset = "0x1C5F634", VA = "0x1C5F634")]
	public static void AreaCollapse(RayfireConnectivity connectivity, int areaPercentage)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1C5F744", Offset = "0x1C5F744", VA = "0x1C5F744")]
	public static void SizeCollapse(RayfireConnectivity connectivity, int sizePercentage)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1C5F6E4", Offset = "0x1C5F6E4", VA = "0x1C5F6E4")]
	public static void AreaCollapse(RayfireConnectivity connectivity, float areaValue)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1C5F7F4", Offset = "0x1C5F7F4", VA = "0x1C5F7F4")]
	public static void SizeCollapse(RayfireConnectivity connectivity, float sizeValue)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1C5F854", Offset = "0x1C5F854", VA = "0x1C5F854")]
	public static void RandomCollapse(RayfireConnectivity connectivity, int randomPercentage, int seedValue)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1C5E934", Offset = "0x1C5E934", VA = "0x1C5E934")]
	private static int RemNeibByArea(RFCluster cluster, float minArea)
	{
		return default(int);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x1C5ED78", Offset = "0x1C5ED78", VA = "0x1C5ED78")]
	private static int RemNeibBySize(RFCluster cluster, float minSize)
	{
		return default(int);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x1C5F0E0", Offset = "0x1C5F0E0", VA = "0x1C5F0E0")]
	private static int RemNeibRandom(RFCluster cluster, int percent, int seed)
	{
		return default(int);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x1C59D3C", Offset = "0x1C59D3C", VA = "0x1C59D3C")]
	public static void SetRangeData(RFCluster cluster, int perc = 0, int seed = 0)
	{
	}
}
[Serializable]
[Token(Token = "0x200003F")]
public class RFDamage
{
	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD186CC", Offset = "0xD186CC")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD186CC", Offset = "0xD186CC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD186CC", Offset = "0xD186CC")]
	public bool enable;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18740", Offset = "0xD18740")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD18740", Offset = "0xD18740")]
	public float maxDamage;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18790", Offset = "0xD18790")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD18790", Offset = "0xD18790")]
	public float currentDamage;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD187E0", Offset = "0xD187E0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD187E0", Offset = "0xD187E0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD187E0", Offset = "0xD187E0")]
	public bool collect;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18854", Offset = "0xD18854")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD18854", Offset = "0xD18854")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18854", Offset = "0xD18854")]
	public float multiplier;

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x1C61BB4", Offset = "0x1C61BB4", VA = "0x1C61BB4")]
	public RFDamage()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1C61BF4", Offset = "0x1C61BF4", VA = "0x1C61BF4")]
	public void CopyFrom(RFDamage damage)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x1C5947C", Offset = "0x1C5947C", VA = "0x1C5947C")]
	public void Reset()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x1C61C2C", Offset = "0x1C61C2C", VA = "0x1C61C2C")]
	public static bool Apply(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1C61C80", Offset = "0x1C61C80", VA = "0x1C61C80")]
	public static bool ApplyDamage(RayfireRigid scr, float damageValue, Vector3 damagePoint, float damageRadius = 0f)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000040")]
public class RFDemolitionCluster
{
	[Token(Token = "0x200007D")]
	public enum RFDetachType
	{
		[Token(Token = "0x4000474")]
		RatioToSize = 0,
		[Token(Token = "0x4000475")]
		WorldUnits = 3
	}

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD188C0", Offset = "0xD188C0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD188C0", Offset = "0xD188C0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD188C0", Offset = "0xD188C0")]
	public ConnectivityType connectivity;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD18934", Offset = "0xD18934")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18934", Offset = "0xD18934")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18934", Offset = "0xD18934")]
	public float minimumArea;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1899C", Offset = "0xD1899C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1899C", Offset = "0xD1899C")]
	public float minimumSize;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD189E0", Offset = "0xD189E0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD189E0", Offset = "0xD189E0")]
	public int percentage;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18A28", Offset = "0xD18A28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18A28", Offset = "0xD18A28")]
	public int seed;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD18A70", Offset = "0xD18A70")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18A70", Offset = "0xD18A70")]
	public RFDetachType type;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18AC0", Offset = "0xD18AC0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD18AC0", Offset = "0xD18AC0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18AC0", Offset = "0xD18AC0")]
	public int ratio;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18B2C", Offset = "0xD18B2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18B2C", Offset = "0xD18B2C")]
	public float units;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD18B70", Offset = "0xD18B70")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18B70", Offset = "0xD18B70")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18B70", Offset = "0xD18B70")]
	public int shardArea;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18BDC", Offset = "0xD18BDC")]
	public bool shardDemolition;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD18BF0", Offset = "0xD18BF0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18BF0", Offset = "0xD18BF0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18BF0", Offset = "0xD18BF0")]
	public int minAmount;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18C58", Offset = "0xD18C58")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18C58", Offset = "0xD18C58")]
	public int maxAmount;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18CA8", Offset = "0xD18CA8")]
	public bool demolishable;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD18CBC", Offset = "0xD18CBC")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18CBC", Offset = "0xD18CBC")]
	public RFCollapse collapse;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public int clsCount;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public RFCluster cluster;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public List<RFCluster> minorClusters;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public bool cn;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	[HideInInspector]
	public bool nd;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[HideInInspector]
	public int am;

	[NonSerialized]
	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RFBackupCluster backup;

	[NonSerialized]
	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float damageRadius;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string nameApp;

	[Token(Token = "0x1700000B")]
	public bool HasChildClusters
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1C66A14", Offset = "0x1C66A14", VA = "0x1C66A14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	public bool HasMinorClusters
	{
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1C626F4", Offset = "0x1C626F4", VA = "0x1C626F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1C61E08", Offset = "0x1C61E08", VA = "0x1C61E08")]
	public RFDemolitionCluster()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1C61E6C", Offset = "0x1C61E6C", VA = "0x1C61E6C")]
	public void CopyFrom(RFDemolitionCluster demolition)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x1C59474", Offset = "0x1C59474", VA = "0x1C59474")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1C61EFC", Offset = "0x1C61EFC", VA = "0x1C61EFC")]
	public static void ResetClusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1C61FDC", Offset = "0x1C61FDC", VA = "0x1C61FDC")]
	public static void ClusterizeEditor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x1C62088", Offset = "0x1C62088", VA = "0x1C62088")]
	public static void Clusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1C62524", Offset = "0x1C62524", VA = "0x1C62524")]
	private static void ClusterizeConnected(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1C622D8", Offset = "0x1C622D8", VA = "0x1C622D8")]
	private static void ClusterizeNested(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x1C62750", Offset = "0x1C62750", VA = "0x1C62750")]
	private static void ClusterizeNestedRecursive(RayfireRigid scr, Transform transform, RFCluster cluster, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1C62A80", Offset = "0x1C62A80", VA = "0x1C62A80")]
	public static bool DemolishCluster(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x1C62CF0", Offset = "0x1C62CF0", VA = "0x1C62CF0")]
	public static List<RFShard> DemolishConnectedCluster(RayfireRigid scr, [Optional] Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x1C62E90", Offset = "0x1C62E90", VA = "0x1C62E90")]
	private static Collider[] GetDetachColliders(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x1C6304C", Offset = "0x1C6304C", VA = "0x1C6304C")]
	private static List<RFShard> DetachShardsByColliders(RayfireRigid scr, Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1C62BA8", Offset = "0x1C62BA8", VA = "0x1C62BA8")]
	private static void DemolishNestedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1C5F488", Offset = "0x1C5F488", VA = "0x1C5F488")]
	public static void PostDemolitionCluster(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1C63740", Offset = "0x1C63740", VA = "0x1C63740")]
	private static void SetupDetachShards(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x1C63840", Offset = "0x1C63840", VA = "0x1C63840")]
	private static void CreateChildClusters(RayfireRigid scr, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1C6393C", Offset = "0x1C6393C", VA = "0x1C6393C")]
	private static void UpdateOriginalCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x1C64924", Offset = "0x1C64924", VA = "0x1C64924")]
	public static void SliceConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x1C6500C", Offset = "0x1C6500C", VA = "0x1C6500C")]
	private static void SetupPlaneShards(RayfireRigid scr, List<RFShard> clusterShards, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1C633C4", Offset = "0x1C633C4", VA = "0x1C633C4")]
	private static void ClusterizeDetachShards(RayfireRigid scr, List<RFShard> detachShards, int clusterAmount, int sortType)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1C63FCC", Offset = "0x1C63FCC", VA = "0x1C63FCC")]
	public static void CreateClusterRuntime(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x1C65338", Offset = "0x1C65338", VA = "0x1C65338")]
	private static void DivideAllShards(RFCluster cluster, List<RFShard> detachShards, int amount)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x1C65B58", Offset = "0x1C65B58", VA = "0x1C65B58")]
	private static void DivideShards(RFCluster mainCluster, RFCluster childCluster)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x1C65EAC", Offset = "0x1C65EAC", VA = "0x1C65EAC")]
	private static void DetachEdgeShards(RayfireRigid scr, RFCluster cluster, List<RFShard> detachShards, int edgeShardArea)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1C65A58", Offset = "0x1C65A58", VA = "0x1C65A58")]
	private static void DetachOneNeibShards(List<RFCluster> childClusters, List<RFShard> detachShards, int edgeAmount, int startIndex)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x1C66210", Offset = "0x1C66210", VA = "0x1C66210")]
	private static void DetachOneNeibShard(RFCluster cls, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x1C63C8C", Offset = "0x1C63C8C", VA = "0x1C63C8C")]
	private static void AddRigidComponent(RayfireRigid scr, List<RFShard> shardList)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1C664D0", Offset = "0x1C664D0", VA = "0x1C664D0")]
	private static void AddRigidComponent(RayfireRigid scr, RFShard shard, Transform parent)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1C63EB8", Offset = "0x1C63EB8", VA = "0x1C63EB8")]
	private static void SetRigidRootShard(RayfireRigid scr, List<RFShard> shards)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x1C668B8", Offset = "0x1C668B8", VA = "0x1C668B8")]
	private static bool SameClusterCheck(RayfireRigid scr, List<RFShard> detachShards, int shardAmount, int clusterAmount)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000041")]
public class RFDemolitionSkin
{
	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Transform> bones;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<SkinnedMeshRenderer> skins;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<SkinnedMeshRenderer> skins0;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<SkinnedMeshRenderer> skins1;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<SkinnedMeshRenderer> skins2;

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x1C69310", Offset = "0x1C69310", VA = "0x1C69310")]
	public void SetupSkin(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1C693B4", Offset = "0x1C693B4", VA = "0x1C693B4")]
	public void SeparateSkins(Vector3 planeNormal, Vector3 planePoint)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x1C695BC", Offset = "0x1C695BC", VA = "0x1C695BC")]
	public RFDemolitionSkin()
	{
	}
}
[Serializable]
[Token(Token = "0x2000042")]
public class RFDemolitionMesh
{
	[Token(Token = "0x200007E")]
	public enum MeshInputType
	{
		[Token(Token = "0x4000477")]
		AtStart = 3,
		[Token(Token = "0x4000478")]
		AtInitialization = 6,
		[Token(Token = "0x4000479")]
		AtDemolition = 9
	}

	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16CB0", Offset = "0xD16CB0")]
	private sealed class <RuntimeCachingCor>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFDemolitionMesh <>4__this;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <demolitionShouldLocal>5__2;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<int> <batchAmount>5__3;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject <tmRefGo>5__4;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Mesh> <meshesList>5__5;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Vector3> <pivotsList>5__6;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<RFDictionary> <subList>5__7;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int <i>5__8;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x1C692A0", Offset = "0x1C692A0", VA = "0x1C692A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x1C69308", Offset = "0x1C69308", VA = "0x1C69308", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1C68CEC", Offset = "0x1C68CEC", VA = "0x1C68CEC")]
		[DebuggerHidden]
		public <RuntimeCachingCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1C68E08", Offset = "0x1C68E08", VA = "0x1C68E08", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1C68E0C", Offset = "0x1C68E0C", VA = "0x1C68E0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1C692A8", Offset = "0x1C692A8", VA = "0x1C692A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD18D6C", Offset = "0xD18D6C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18D6C", Offset = "0xD18D6C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD18D6C", Offset = "0xD18D6C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18D6C", Offset = "0xD18D6C")]
	public int amount;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18DFC", Offset = "0xD18DFC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD18DFC", Offset = "0xD18DFC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18DFC", Offset = "0xD18DFC")]
	public int variation;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18E68", Offset = "0xD18E68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD18E68", Offset = "0xD18E68")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18E68", Offset = "0xD18E68")]
	public float depthFade;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18ED4", Offset = "0xD18ED4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD18ED4", Offset = "0xD18ED4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18ED4", Offset = "0xD18ED4")]
	public float contactBias;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18F3C", Offset = "0xD18F3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD18F3C", Offset = "0xD18F3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD18F3C", Offset = "0xD18F3C")]
	public int seed;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD18FA8", Offset = "0xD18FA8")]
	public bool useShatter;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD18FE0", Offset = "0xD18FE0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD18FE0", Offset = "0xD18FE0")]
	public bool clusterize;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19030", Offset = "0xD19030")]
	public FragSimType simType;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19044", Offset = "0xD19044")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19044", Offset = "0xD19044")]
	public MeshInputType meshInput;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19094", Offset = "0xD19094")]
	public RFFragmentProperties properties;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD190A8", Offset = "0xD190A8")]
	public RFRuntimeCaching runtimeCaching;

	[NonSerialized]
	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int badMesh;

	[NonSerialized]
	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int shatterMode;

	[NonSerialized]
	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int totalAmount;

	[NonSerialized]
	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int innerSubId;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public Quaternion cacheRotationStart;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public Mesh mesh;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public RFShatter rfShatter;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public RayfireShatter scrShatter;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string fragmentStr;

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x1C66C48", Offset = "0x1C66C48", VA = "0x1C66C48")]
	public RFDemolitionMesh()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x1C66D70", Offset = "0x1C66D70", VA = "0x1C66D70")]
	public void CopyFrom(RFDemolitionMesh demolition)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x1C59468", Offset = "0x1C59468", VA = "0x1C59468")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x1C66EA0", Offset = "0x1C66EA0", VA = "0x1C66EA0")]
	public static bool DemolishMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1C67B7C", Offset = "0x1C67B7C", VA = "0x1C67B7C")]
	public static bool ClusterizeFragments(RayfireRigid rigid)
	{
		return default(bool);
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1C6712C", Offset = "0x1C6712C", VA = "0x1C6712C")]
	public static List<RayfireRigid> CreateFragments(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1C68038", Offset = "0x1C68038", VA = "0x1C68038")]
	public static void SliceMesh(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1C684A8", Offset = "0x1C684A8", VA = "0x1C684A8")]
	public static List<RayfireRigid> CreateSlices(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1C67EF0", Offset = "0x1C67EF0", VA = "0x1C67EF0")]
	private static void SetFragmentSimulationType(RayfireRigid frag, RayfireRigid scr)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1C67A9C", Offset = "0x1C67A9C", VA = "0x1C67A9C")]
	private static void CacheRuntime(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1C68B8C", Offset = "0x1C68B8C", VA = "0x1C68B8C")]
	public static void CacheInstant(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1C67F2C", Offset = "0x1C67F2C", VA = "0x1C67F2C")]
	public int GetLayer(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1C68C54", Offset = "0x1C68C54", VA = "0x1C68C54")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B3E8", Offset = "0xD1B3E8")]
	public IEnumerator RuntimeCachingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1C68D18", Offset = "0x1C68D18", VA = "0x1C68D18")]
	public void StopRuntimeCaching()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1C68D40", Offset = "0x1C68D40", VA = "0x1C68D40")]
	private void ResetRuntimeCaching(RayfireRigid scr, GameObject tmRefGo)
	{
	}
}
[Serializable]
[Token(Token = "0x2000043")]
public class RFFade
{
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16CC0", Offset = "0xD16CC0")]
	private sealed class <FadeOffsetCor>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1C099FC", Offset = "0x1C099FC", VA = "0x1C099FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x1C09A64", Offset = "0x1C09A64", VA = "0x1C09A64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1C080BC", Offset = "0x1C080BC", VA = "0x1C080BC")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1C097A4", Offset = "0x1C097A4", VA = "0x1C097A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1C097A8", Offset = "0x1C097A8", VA = "0x1C097A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1C09A04", Offset = "0x1C09A04", VA = "0x1C09A04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16CD0", Offset = "0xD16CD0")]
	private sealed class <FadeOffsetCor>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot scr;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000042")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1C09E18", Offset = "0x1C09E18", VA = "0x1C09E18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x1C09E80", Offset = "0x1C09E80", VA = "0x1C09E80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1C08164", Offset = "0x1C08164", VA = "0x1C08164")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1C09A6C", Offset = "0x1C09A6C", VA = "0x1C09A6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1C09A70", Offset = "0x1C09A70", VA = "0x1C09A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1C09E20", Offset = "0x1C09E20", VA = "0x1C09E20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16CE0", Offset = "0xD16CE0")]
	private sealed class <LivingCor>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x17000044")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x1C0A5E4", Offset = "0x1C0A5E4", VA = "0x1C0A5E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1C0A64C", Offset = "0x1C0A64C", VA = "0x1C0A64C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1C08320", Offset = "0x1C08320", VA = "0x1C08320")]
		[DebuggerHidden]
		public <LivingCor>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1C0A2F4", Offset = "0x1C0A2F4", VA = "0x1C0A2F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1C0A2F8", Offset = "0x1C0A2F8", VA = "0x1C0A2F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1C0A5EC", Offset = "0x1C0A5EC", VA = "0x1C0A5EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16CF0", Offset = "0xD16CF0")]
	private sealed class <LivingCor>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot root;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFShard shard;

		[Token(Token = "0x17000046")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x1C0A920", Offset = "0x1C0A920", VA = "0x1C0A920", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x1C0A988", Offset = "0x1C0A988", VA = "0x1C0A988", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1C0834C", Offset = "0x1C0834C", VA = "0x1C0834C")]
		[DebuggerHidden]
		public <LivingCor>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1C0A654", Offset = "0x1C0A654", VA = "0x1C0A654", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1C0A658", Offset = "0x1C0A658", VA = "0x1C0A658", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1C0A928", Offset = "0x1C0A928", VA = "0x1C0A928", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16D00", Offset = "0xD16D00")]
	private sealed class <SimulationLivingCor>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform tm;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <oldPos>5__2;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <distanceThreshold>5__3;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000048")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x1C0B0FC", Offset = "0x1C0B0FC", VA = "0x1C0B0FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x1C0B164", Offset = "0x1C0B164", VA = "0x1C0B164", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1C083F4", Offset = "0x1C083F4", VA = "0x1C083F4")]
		[DebuggerHidden]
		public <SimulationLivingCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1C0AF78", Offset = "0x1C0AF78", VA = "0x1C0AF78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1C0AF7C", Offset = "0x1C0AF7C", VA = "0x1C0AF7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1C0B104", Offset = "0x1C0B104", VA = "0x1C0B104", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16D10", Offset = "0xD16D10")]
	private sealed class <FallDownCor>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid rigid;

		[Token(Token = "0x1700004A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x1C0A078", Offset = "0x1C0A078", VA = "0x1C0A078", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x1C0A0E0", Offset = "0x1C0A0E0", VA = "0x1C0A0E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1C0878C", Offset = "0x1C0878C", VA = "0x1C0878C")]
		[DebuggerHidden]
		public <FallDownCor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1C09E88", Offset = "0x1C09E88", VA = "0x1C09E88", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1C09E8C", Offset = "0x1C09E8C", VA = "0x1C09E8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1C0A080", Offset = "0x1C0A080", VA = "0x1C0A080", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16D20", Offset = "0xD16D20")]
	private sealed class <FallDownCor>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFShard shard;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot root;

		[Token(Token = "0x1700004C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x1C0A284", Offset = "0x1C0A284", VA = "0x1C0A284", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x1C0A2EC", Offset = "0x1C0A2EC", VA = "0x1C0A2EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1C08850", Offset = "0x1C08850", VA = "0x1C08850")]
		[DebuggerHidden]
		public <FallDownCor>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1C0A0E8", Offset = "0x1C0A0E8", VA = "0x1C0A0E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1C0A0EC", Offset = "0x1C0A0EC", VA = "0x1C0A0EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1C0A28C", Offset = "0x1C0A28C", VA = "0x1C0A28C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16D30", Offset = "0xD16D30")]
	private sealed class <ScaleDownCor>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <steps>5__2;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x1700004E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x1C0ABF8", Offset = "0x1C0ABF8", VA = "0x1C0ABF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x1C0AC60", Offset = "0x1C0AC60", VA = "0x1C0AC60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1C088F8", Offset = "0x1C088F8", VA = "0x1C088F8")]
		[DebuggerHidden]
		public <ScaleDownCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1C0A990", Offset = "0x1C0A990", VA = "0x1C0A990", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1C0A994", Offset = "0x1C0A994", VA = "0x1C0A994", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1C0AC00", Offset = "0x1C0AC00", VA = "0x1C0AC00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16D40", Offset = "0xD16D40")]
	private sealed class <ScaleDownCor>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot root;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFShard shard;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <steps>5__2;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000050")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x1C0AF08", Offset = "0x1C0AF08", VA = "0x1C0AF08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x1C0AF70", Offset = "0x1C0AF70", VA = "0x1C0AF70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1C089BC", Offset = "0x1C089BC", VA = "0x1C089BC")]
		[DebuggerHidden]
		public <ScaleDownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1C0AC68", Offset = "0x1C0AC68", VA = "0x1C0AC68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1C0AC6C", Offset = "0x1C0AC6C", VA = "0x1C0AC6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1C0AF10", Offset = "0x1C0AF10", VA = "0x1C0AF10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16D50", Offset = "0xD16D50")]
	private sealed class <FadeMoveDownCor>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid rigid;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <steps>5__2;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000052")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x1C093A0", Offset = "0x1C093A0", VA = "0x1C093A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x1C09408", Offset = "0x1C09408", VA = "0x1C09408", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1C08A64", Offset = "0x1C08A64", VA = "0x1C08A64")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1C08FC8", Offset = "0x1C08FC8", VA = "0x1C08FC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1C08FCC", Offset = "0x1C08FCC", VA = "0x1C08FCC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1C093A8", Offset = "0x1C093A8", VA = "0x1C093A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16D60", Offset = "0xD16D60")]
	private sealed class <FadeMoveDownCor>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFShard shard;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot root;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <steps>5__2;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000054")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x1C09734", Offset = "0x1C09734", VA = "0x1C09734", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x1C0979C", Offset = "0x1C0979C", VA = "0x1C0979C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1C08B28", Offset = "0x1C08B28", VA = "0x1C08B28")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1C09410", Offset = "0x1C09410", VA = "0x1C09410", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1C09414", Offset = "0x1C09414", VA = "0x1C09414", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1C0973C", Offset = "0x1C0973C", VA = "0x1C0973C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD190FC", Offset = "0xD190FC")]
	public bool onDemolition;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19134", Offset = "0xD19134")]
	public bool onActivation;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19148", Offset = "0xD19148")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD19148", Offset = "0xD19148")]
	public float byOffset;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1918C", Offset = "0xD1918C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1918C", Offset = "0xD1918C")]
	public RFFadeLifeType lifeType;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD191DC", Offset = "0xD191DC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD191DC", Offset = "0xD191DC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD191DC", Offset = "0xD191DC")]
	public float lifeTime;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19248", Offset = "0xD19248")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD19248", Offset = "0xD19248")]
	public float lifeVariation;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1928C", Offset = "0xD1928C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1928C", Offset = "0xD1928C")]
	public FadeType fadeType;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD192DC", Offset = "0xD192DC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD192DC", Offset = "0xD192DC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD192DC", Offset = "0xD192DC")]
	public float fadeTime;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD19344", Offset = "0xD19344")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19344", Offset = "0xD19344")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19344", Offset = "0xD19344")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD19344", Offset = "0xD19344")]
	public float sizeFilter;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD193D0", Offset = "0xD193D0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD193D0", Offset = "0xD193D0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD193D0", Offset = "0xD193D0")]
	public int shardAmount;

	[NonSerialized]
	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int state;

	[NonSerialized]
	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool stop;

	[NonSerialized]
	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 position;

	[NonSerialized]
	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool offsetCorState;

	[NonSerialized]
	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public IEnumerator offsetEnum;

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1C07D18", Offset = "0x1C07D18", VA = "0x1C07D18")]
	public RFFade()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1C07D9C", Offset = "0x1C07D9C", VA = "0x1C07D9C")]
	public void CopyFrom(RFFade fade)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1C07D84", Offset = "0x1C07D84", VA = "0x1C07D84")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1C07E10", Offset = "0x1C07E10", VA = "0x1C07E10")]
	public void DemolitionFade(List<RayfireRigid> fadeObjects)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1C08040", Offset = "0x1C08040", VA = "0x1C08040")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B44C", Offset = "0xD1B44C")]
	public static IEnumerator FadeOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1C080E8", Offset = "0x1C080E8", VA = "0x1C080E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B4B0", Offset = "0xD1B4B0")]
	public static IEnumerator FadeOffsetCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1C07F28", Offset = "0x1C07F28", VA = "0x1C07F28")]
	public static void FadeRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1C0820C", Offset = "0x1C0820C", VA = "0x1C0820C")]
	public static void FadeShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1C08190", Offset = "0x1C08190", VA = "0x1C08190")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B514", Offset = "0xD1B514")]
	private static IEnumerator LivingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1C08288", Offset = "0x1C08288", VA = "0x1C08288")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B578", Offset = "0xD1B578")]
	private static IEnumerator LivingCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1C08378", Offset = "0x1C08378", VA = "0x1C08378")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B5DC", Offset = "0xD1B5DC")]
	private static IEnumerator SimulationLivingCor(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1C08420", Offset = "0x1C08420", VA = "0x1C08420")]
	private static void FadeExclude(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1C0861C", Offset = "0x1C0861C", VA = "0x1C0861C")]
	private static void FadeExclude(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1C08710", Offset = "0x1C08710", VA = "0x1C08710")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B640", Offset = "0xD1B640")]
	private static IEnumerator FallDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1C087B8", Offset = "0x1C087B8", VA = "0x1C087B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B6A4", Offset = "0xD1B6A4")]
	private static IEnumerator FallDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1C0887C", Offset = "0x1C0887C", VA = "0x1C0887C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B708", Offset = "0xD1B708")]
	private static IEnumerator ScaleDownCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x1C08924", Offset = "0x1C08924", VA = "0x1C08924")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B76C", Offset = "0xD1B76C")]
	private static IEnumerator ScaleDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x1C089E8", Offset = "0x1C089E8", VA = "0x1C089E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B7D0", Offset = "0xD1B7D0")]
	private static IEnumerator FadeMoveDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1C08A90", Offset = "0x1C08A90", VA = "0x1C08A90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B834", Offset = "0xD1B834")]
	private static IEnumerator FadeMoveDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1C08B54", Offset = "0x1C08B54", VA = "0x1C08B54")]
	private static void DisableClusterColliders(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1C08D68", Offset = "0x1C08D68", VA = "0x1C08D68")]
	public static void SetOffsetFadeList(RayfireRigidRoot root)
	{
	}
}
[Serializable]
[Token(Token = "0x2000044")]
public class RFFragmentProperties
{
	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1943C", Offset = "0xD1943C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1943C", Offset = "0xD1943C")]
	public RFColliderType colliderType;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD1948C", Offset = "0xD1948C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1948C", Offset = "0xD1948C")]
	public float sizeFilter;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD194E0", Offset = "0xD194E0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD194E0", Offset = "0xD194E0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD194E0", Offset = "0xD194E0")]
	public bool decompose;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19554", Offset = "0xD19554")]
	public bool removeCollinear;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1958C", Offset = "0xD1958C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1958C", Offset = "0xD1958C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD1958C", Offset = "0xD1958C")]
	public string layer;

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1C0FAF4", Offset = "0x1C0FAF4", VA = "0x1C0FAF4")]
	public RFFragmentProperties()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1C0FB5C", Offset = "0x1C0FB5C", VA = "0x1C0FB5C")]
	public void CopyFrom(RFFragmentProperties fragmentProperties)
	{
	}
}
[Serializable]
[Token(Token = "0x2000045")]
public class RFLimitations
{
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16D70", Offset = "0xD16D70")]
	private sealed class <DemolishableCor>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFLimitations <>4__this;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x17000056")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x1C11FE0", Offset = "0x1C11FE0", VA = "0x1C11FE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x1C12048", Offset = "0x1C12048", VA = "0x1C12048", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1C0FE2C", Offset = "0x1C0FE2C", VA = "0x1C0FE2C")]
		[DebuggerHidden]
		public <DemolishableCor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1C11EB0", Offset = "0x1C11EB0", VA = "0x1C11EB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1C11EB4", Offset = "0x1C11EB4", VA = "0x1C11EB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1C11FE8", Offset = "0x1C11FE8", VA = "0x1C11FE8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD19600", Offset = "0xD19600")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19600", Offset = "0xD19600")]
	public bool byCollision;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19660", Offset = "0xD19660")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19660", Offset = "0xD19660")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD19660", Offset = "0xD19660")]
	public float solidity;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD196C8", Offset = "0xD196C8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD196C8", Offset = "0xD196C8")]
	public string tag;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD19718", Offset = "0xD19718")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19718", Offset = "0xD19718")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD19718", Offset = "0xD19718")]
	public int depth;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19790", Offset = "0xD19790")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19790", Offset = "0xD19790")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD19790", Offset = "0xD19790")]
	public float time;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD197FC", Offset = "0xD197FC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD197FC", Offset = "0xD197FC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD197FC", Offset = "0xD197FC")]
	public float size;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19868", Offset = "0xD19868")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19868", Offset = "0xD19868")]
	public bool visible;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD198B8", Offset = "0xD198B8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD198B8", Offset = "0xD198B8")]
	public bool sliceByBlade;

	[NonSerialized]
	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> slicePlanes;

	[NonSerialized]
	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ContactPoint contactPoint;

	[NonSerialized]
	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector3 contactVector3;

	[NonSerialized]
	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3 contactNormal;

	[NonSerialized]
	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool demolitionShould;

	[NonSerialized]
	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	public bool demolished;

	[NonSerialized]
	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float birthTime;

	[NonSerialized]
	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float bboxSize;

	[NonSerialized]
	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int currentDepth;

	[NonSerialized]
	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool demolishableCorState;

	[NonSerialized]
	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float sliceForce;

	[NonSerialized]
	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool affectInactive;

	[NonSerialized]
	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RayfireRigid ancestor;

	[NonSerialized]
	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<RayfireRigid> descendants;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public Bounds bound;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string rootStr;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string rigidStr;

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1C0FB9C", Offset = "0x1C0FB9C", VA = "0x1C0FB9C")]
	public RFLimitations()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1C0FD20", Offset = "0x1C0FD20", VA = "0x1C0FD20")]
	public void CopyFrom(RFLimitations limitations)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1C0FC58", Offset = "0x1C0FC58", VA = "0x1C0FC58")]
	public void Reset()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1C0FD94", Offset = "0x1C0FD94", VA = "0x1C0FD94")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B898", Offset = "0xD1B898")]
	public IEnumerator DemolishableCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1C0FE58", Offset = "0x1C0FE58", VA = "0x1C0FE58")]
	public static void Checks(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1C119CC", Offset = "0x1C119CC", VA = "0x1C119CC")]
	public static void SetBound(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1C11AA8", Offset = "0x1C11AA8", VA = "0x1C11AA8")]
	public static void SetAncestor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1C11BF0", Offset = "0x1C11BF0", VA = "0x1C11BF0")]
	public static void SetDescendants(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1C11CC4", Offset = "0x1C11CC4", VA = "0x1C11CC4")]
	public static void CreateRoot(RayfireRigid rfScr)
	{
	}
}
[Serializable]
[Token(Token = "0x2000046")]
public class RFPhysic
{
	[Token(Token = "0x200008C")]
	private struct RFIgnorePair
	{
		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int a;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private int b;

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x19B18C4", Offset = "0x19B18C4", VA = "0x19B18C4")]
		public RFIgnorePair(int A, int B)
		{
		}
	}

	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16D80", Offset = "0xD16D80")]
	private sealed class <PhysicsDataCor>d__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFPhysic <>4__this;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x17000058")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x19B1854", Offset = "0x19B1854", VA = "0x19B1854", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x19B18BC", Offset = "0x19B18BC", VA = "0x19B18BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x19B16D0", Offset = "0x19B16D0", VA = "0x19B16D0")]
		[DebuggerHidden]
		public <PhysicsDataCor>d__70(int <>1__state)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x19B16FC", Offset = "0x19B16FC", VA = "0x19B16FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x19B1700", Offset = "0x19B1700", VA = "0x19B1700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x19B185C", Offset = "0x19B185C", VA = "0x19B185C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD19918", Offset = "0xD19918")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19918", Offset = "0xD19918")]
	public MaterialType materialType;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19978", Offset = "0xD19978")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19978", Offset = "0xD19978")]
	public PhysicMaterial material;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD199C8", Offset = "0xD199C8")]
	public MassType massBy;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19A00", Offset = "0xD19A00")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19A00", Offset = "0xD19A00")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD19A00", Offset = "0xD19A00")]
	public float mass;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD19A70", Offset = "0xD19A70")]
	public RFColliderType colliderType;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19AA8", Offset = "0xD19AA8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19AA8", Offset = "0xD19AA8")]
	public bool planarCheck;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19AF8", Offset = "0xD19AF8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19AF8", Offset = "0xD19AF8")]
	public bool ignoreNear;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19B48", Offset = "0xD19B48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD19B48", Offset = "0xD19B48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19B48", Offset = "0xD19B48")]
	public bool useGravity;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19BBC", Offset = "0xD19BBC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD19BBC", Offset = "0xD19BBC")]
	public int solverIterations;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD19C00", Offset = "0xD19C00")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19C00", Offset = "0xD19C00")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD19C00", Offset = "0xD19C00")]
	public float dampening;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Rigidbody rigidBody;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Collider meshCollider;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public List<Collider> clusterColliders;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public List<int> ignoreList;

	[NonSerialized]
	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool rec;

	[NonSerialized]
	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool exclude;

	[NonSerialized]
	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int solidity;

	[NonSerialized]
	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool destructible;

	[NonSerialized]
	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool physicsDataCorState;

	[NonSerialized]
	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector3 velocity;

	[NonSerialized]
	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector3 initScale;

	[NonSerialized]
	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector3 initPosition;

	[NonSerialized]
	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Quaternion initRotation;

	[NonSerialized]
	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public IEnumerator physicsEnum;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int coplanarVertLimit;

	[Token(Token = "0x1700000D")]
	public bool HasIgnore
	{
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1C1DA5C", Offset = "0x1C1DA5C", VA = "0x1C1DA5C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000E")]
	public bool HasClusterColliders
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1C08D08", Offset = "0x1C08D08", VA = "0x1C08D08")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000F")]
	public bool Destructible
	{
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1C1E600", Offset = "0x1C1E600", VA = "0x1C1E600")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000010")]
	public int Solidity
	{
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1C1E680", Offset = "0x1C1E680", VA = "0x1C1E680")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000011")]
	public PhysicMaterial PhysMaterial
	{
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1C1CAD0", Offset = "0x1C1CAD0", VA = "0x1C1CAD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1C1A720", Offset = "0x1C1A720", VA = "0x1C1A720")]
	public RFPhysic()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1C1A8C0", Offset = "0x1C1A8C0", VA = "0x1C1A8C0")]
	public void CopyFrom(RFPhysic physics)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1C1A83C", Offset = "0x1C1A83C", VA = "0x1C1A83C")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1C1A950", Offset = "0x1C1A950", VA = "0x1C1A950")]
	public void SaveInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1C1A9B4", Offset = "0x1C1A9B4", VA = "0x1C1A9B4")]
	public void LoadInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1C1AA14", Offset = "0x1C1AA14", VA = "0x1C1AA14")]
	public static void SetSimulationType(Rigidbody rb, SimType simulationType, ObjectType objectType, bool useGravity, int solver)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1C1ABE4", Offset = "0x1C1ABE4", VA = "0x1C1ABE4")]
	private static void SetDynamic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1C1ACEC", Offset = "0x1C1ACEC", VA = "0x1C1ACEC")]
	private static void SetSleeping(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1C1AD38", Offset = "0x1C1AD38", VA = "0x1C1AD38")]
	private static void SetInactive(Rigidbody rb)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1C1AD80", Offset = "0x1C1AD80", VA = "0x1C1AD80")]
	private static void SetKinematic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1C1AC24", Offset = "0x1C1AC24", VA = "0x1C1AC24")]
	private static void SetCollisionDetection(Rigidbody rb, ObjectType objectType)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1C1ADD0", Offset = "0x1C1ADD0", VA = "0x1C1ADD0")]
	public static void SetDensity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1C1B234", Offset = "0x1C1B234", VA = "0x1C1B234")]
	public static void SetDensity(RFShard shard, float density)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x1C1B0C4", Offset = "0x1C1B0C4", VA = "0x1C1B0C4")]
	private static float MassLimit(float m)
	{
		return default(float);
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1C1B304", Offset = "0x1C1B304", VA = "0x1C1B304")]
	public static void SetMassByParent(RFPhysic target, float targetSize, float parentMass, float parentSize)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x1C1B344", Offset = "0x1C1B344", VA = "0x1C1B344")]
	public static void SetDrag(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1C1B430", Offset = "0x1C1B430", VA = "0x1C1B430")]
	public static void SetDrag(RFShard shard, float drag, float dragAngular)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1C1B480", Offset = "0x1C1B480", VA = "0x1C1B480")]
	public static void SetFragmentsVelocity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1C1B7A0", Offset = "0x1C1B7A0", VA = "0x1C1B7A0")]
	public static void SetFragmentCollider(RayfireRigid scr, Mesh mesh)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1C1B8E4", Offset = "0x1C1B8E4", VA = "0x1C1B8E4")]
	public static void SetRigidCollider(RayfireRigid scr, [Optional] Mesh mesh)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x1C1BD98", Offset = "0x1C1BD98", VA = "0x1C1BD98")]
	public static void SetRigidRootCollider(RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1C1BF48", Offset = "0x1C1BF48", VA = "0x1C1BF48")]
	public static void SetupMeshRootColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x1C1C0E8", Offset = "0x1C1C0E8", VA = "0x1C1C0E8")]
	public static void SetClusterCollidersByShards(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1C1C270", Offset = "0x1C1C270", VA = "0x1C1C270")]
	private static void CollidersRemoveNull(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x1C1C3C0", Offset = "0x1C1C3C0", VA = "0x1C1C3C0")]
	private static void SetShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x1C1C5E0", Offset = "0x1C1C5E0", VA = "0x1C1C5E0")]
	private static void SetDeepShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1C1C6E0", Offset = "0x1C1C6E0", VA = "0x1C1C6E0")]
	public static void CollectClusterColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1C1C7B4", Offset = "0x1C1C7B4", VA = "0x1C1C7B4")]
	private static void CollectDeepColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1C1C910", Offset = "0x1C1C910", VA = "0x1C1C910")]
	public static void SetColliderMaterial(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1C1CB5C", Offset = "0x1C1CB5C", VA = "0x1C1CB5C")]
	public static void SetColliderMaterial(RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x1C1CC0C", Offset = "0x1C1CC0C", VA = "0x1C1CC0C")]
	public static void SetParticleColliderMaterial(List<RayfireDebris> debris)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1C1CD24", Offset = "0x1C1CD24", VA = "0x1C1CD24")]
	public static void SetColliderConvex(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1C1CE1C", Offset = "0x1C1CE1C", VA = "0x1C1CE1C")]
	public static void DestroyColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1C1CFC0", Offset = "0x1C1CFC0", VA = "0x1C1CFC0")]
	public static void SetPhysics(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1C1D114", Offset = "0x1C1D114", VA = "0x1C1D114")]
	public static void SetPhysics(List<RFShard> shards, RFPhysic physic)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1C1D484", Offset = "0x1C1D484", VA = "0x1C1D484")]
	public static void SetPhysics(RFShard shard, RFPhysic physic)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1C1D674", Offset = "0x1C1D674", VA = "0x1C1D674")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RayfireRigid> rigids)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1C1E0A8", Offset = "0x1C1E0A8", VA = "0x1C1E0A8")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1C1E1CC", Offset = "0x1C1E1CC", VA = "0x1C1E1CC")]
	public static void SetIgnoreListShards(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1C1DCDC", Offset = "0x1C1DCDC", VA = "0x1C1DCDC")]
	public static List<int> GetIgnoreListFast(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x1C1DAB8", Offset = "0x1C1DAB8", VA = "0x1C1DAB8")]
	public static List<int> GetIgnoreListShort(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x1C1DE5C", Offset = "0x1C1DE5C", VA = "0x1C1DE5C")]
	public static void IgnoreNeibCollision(List<RayfireRigid> rigids, List<int> pr)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1C1E33C", Offset = "0x1C1E33C", VA = "0x1C1E33C")]
	public static void IgnoreNeibCollision(List<RFShard> shards, List<int> pr)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x1C1B794", Offset = "0x1C1B794", VA = "0x1C1B794")]
	public static bool IsNull(Rigidbody rb)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x1C1E568", Offset = "0x1C1E568", VA = "0x1C1E568")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B8FC", Offset = "0xD1B8FC")]
	public IEnumerator PhysicsDataCor(RayfireRigid scr)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000047")]
public class RFReferenceDemolition
{
	[Token(Token = "0x200008E")]
	public enum ActionType
	{
		[Token(Token = "0x40004C6")]
		Instantiate,
		[Token(Token = "0x40004C7")]
		SetActive
	}

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD19CB8", Offset = "0xD19CB8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19CB8", Offset = "0xD19CB8")]
	public GameObject reference;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19D08", Offset = "0xD19D08")]
	public List<GameObject> randomList;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD19D1C", Offset = "0xD19D1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19D1C", Offset = "0xD19D1C")]
	public ActionType action;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19D6C", Offset = "0xD19D6C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19D6C", Offset = "0xD19D6C")]
	public bool addRigid;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19DBC", Offset = "0xD19DBC")]
	public bool inheritScale;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19DD0", Offset = "0xD19DD0")]
	public bool inheritMaterials;

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x19B2984", Offset = "0x19B2984", VA = "0x19B2984")]
	public RFReferenceDemolition()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x19B29C4", Offset = "0x19B29C4", VA = "0x19B29C4")]
	public void CopyFrom(RFReferenceDemolition referenceDemolitionDml)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x19B2AA4", Offset = "0x19B2AA4", VA = "0x19B2AA4")]
	public GameObject GetReference()
	{
		return null;
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x19B2CD8", Offset = "0x19B2CD8", VA = "0x19B2CD8")]
	public static bool DemolishReference(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x19B3654", Offset = "0x19B3654", VA = "0x19B3654")]
	private static GameObject GetInstance(RayfireRigid scr, GameObject refGo)
	{
		return null;
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x19B380C", Offset = "0x19B380C", VA = "0x19B380C")]
	private static void InheritMaterials(RayfireRigid scr, GameObject instGo)
	{
	}
}
[Serializable]
[Token(Token = "0x2000048")]
public class RFReset
{
	[Token(Token = "0x200008F")]
	public enum PostDemolitionType
	{
		[Token(Token = "0x40004C9")]
		DestroyWithDelay,
		[Token(Token = "0x40004CA")]
		DeactivateToReset
	}

	[Token(Token = "0x2000090")]
	public enum MeshResetType
	{
		[Token(Token = "0x40004CC")]
		Destroy = 0,
		[Token(Token = "0x40004CD")]
		ReuseInputMesh = 2,
		[Token(Token = "0x40004CE")]
		ReuseFragmentMeshes = 4
	}

	[Token(Token = "0x2000091")]
	public enum FragmentsResetType
	{
		[Token(Token = "0x40004D0")]
		Destroy = 0,
		[Token(Token = "0x40004D1")]
		Reuse = 2,
		[Token(Token = "0x40004D2")]
		Preserve = 4
	}

	[Serializable]
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16D90", Offset = "0xD16D90")]
	private sealed class <>c
	{
		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<RayfireRigid, bool> <>9__23_0;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<RayfireRigid, bool> <>9__23_1;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<RayfireRigid, bool> <>9__29_0;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<RayfireRigid, bool> <>9__29_1;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<RayfireRigid, bool> <>9__29_2;

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x19B66E4", Offset = "0x19B66E4", VA = "0x19B66E4")]
		public <>c()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x19B66EC", Offset = "0x19B66EC", VA = "0x19B66EC")]
		internal bool <DestroyFragments>b__23_0(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x19B6758", Offset = "0x19B6758", VA = "0x19B6758")]
		internal bool <DestroyFragments>b__23_1(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x19B67C4", Offset = "0x19B67C4", VA = "0x19B67C4")]
		internal bool <FragmentReuseState>b__29_0(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x19B6830", Offset = "0x19B6830", VA = "0x19B6830")]
		internal bool <FragmentReuseState>b__29_1(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x19B6854", Offset = "0x19B6854", VA = "0x19B6854")]
		internal bool <FragmentReuseState>b__29_2(RayfireRigid t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD19DE4", Offset = "0xD19DE4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19DE4", Offset = "0xD19DE4")]
	public bool transform;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19E44", Offset = "0xD19E44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19E44", Offset = "0xD19E44")]
	public bool damage;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19E94", Offset = "0xD19E94")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19E94", Offset = "0xD19E94")]
	public bool connectivity;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD19EE4", Offset = "0xD19EE4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19EE4", Offset = "0xD19EE4")]
	public PostDemolitionType action;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19F34", Offset = "0xD19F34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD19F34", Offset = "0xD19F34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD19F34", Offset = "0xD19F34")]
	public float destroyDelay;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD19FA0", Offset = "0xD19FA0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19FA0", Offset = "0xD19FA0")]
	public MeshResetType mesh;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD19FF0", Offset = "0xD19FF0")]
	public FragmentsResetType fragments;

	[NonSerialized]
	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A004", Offset = "0xD1A004")]
	public bool toBeDestroyed;

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x19B39F8", Offset = "0x19B39F8", VA = "0x19B39F8")]
	public RFReset()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x19B3A3C", Offset = "0x19B3A3C", VA = "0x19B3A3C")]
	public void CopyFrom(RFReset reset, ObjectType objectTypeTo)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x19B3AA0", Offset = "0x19B3AA0", VA = "0x19B3AA0")]
	public static void ResetRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x19B4460", Offset = "0x19B4460", VA = "0x19B4460")]
	public static void ResetFade(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x19B3D04", Offset = "0x19B3D04", VA = "0x19B3D04")]
	private static bool MeshRootReset(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x19B4AD8", Offset = "0x19B4AD8", VA = "0x19B4AD8")]
	private static bool MeshRootCleanup(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x19B4C50", Offset = "0x19B4C50", VA = "0x19B4C50")]
	public static void RigidRootReset(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x19B5354", Offset = "0x19B5354", VA = "0x19B5354")]
	private static void ResetParentAndTm(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x19B50F4", Offset = "0x19B50F4", VA = "0x19B50F4")]
	private static void ResetSimType(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x19B4F8C", Offset = "0x19B4F8C", VA = "0x19B4F8C")]
	public static void DestroyParticles(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x19B55E4", Offset = "0x19B55E4", VA = "0x19B55E4")]
	public static void DestroyClusters(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x19B46EC", Offset = "0x19B46EC", VA = "0x19B46EC")]
	public static void ResetMeshDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x19B5E78", Offset = "0x19B5E78", VA = "0x19B5E78")]
	private static void DestroyFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x19B47FC", Offset = "0x19B47FC", VA = "0x19B47FC")]
	public static void DestroyParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x19B59C4", Offset = "0x19B59C4", VA = "0x19B59C4")]
	private static void ReuseFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x19B65F8", Offset = "0x19B65F8", VA = "0x19B65F8")]
	private static void PreserveFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x19B47D0", Offset = "0x19B47D0", VA = "0x19B47D0")]
	private static void ResetClusterDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x19B3BD8", Offset = "0x19B3BD8", VA = "0x19B3BD8")]
	private static bool ObjectReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x19B573C", Offset = "0x19B573C", VA = "0x19B573C")]
	private static bool FragmentReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x19B40DC", Offset = "0x19B40DC", VA = "0x19B40DC")]
	private static void RestoreTransform(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x19B4224", Offset = "0x19B4224", VA = "0x19B4224")]
	public static void Reset(RayfireRigid scr)
	{
	}
}
[Serializable]
[Token(Token = "0x2000049")]
public class RFRuntimeCaching
{
	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public CachingType type;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1A018", Offset = "0xD1A018")]
	public int frames;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1A034", Offset = "0xD1A034")]
	public int fragments;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool skipFirstDemolition;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[HideInInspector]
	public bool inProgress;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[HideInInspector]
	public bool wasUsed;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[HideInInspector]
	public bool stop;

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x19B6AF4", Offset = "0x19B6AF4", VA = "0x19B6AF4")]
	public RFRuntimeCaching()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x19B6B24", Offset = "0x19B6B24", VA = "0x19B6B24")]
	public static List<int> GetBatchByFrames(int frames, int amount)
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x19B6CA4", Offset = "0x19B6CA4", VA = "0x19B6CA4")]
	public static List<int> GetBatchByFragments(int fragments, int amount)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x19B6D7C", Offset = "0x19B6D7C", VA = "0x19B6D7C")]
	public static List<int> GetMarkedElements(int batchInd, List<int> batchAmount)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x19B6EAC", Offset = "0x19B6EAC", VA = "0x19B6EAC")]
	public static GameObject CreateTmRef(RayfireRigid rfScr)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200004A")]
public class RFMirrored
{
	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public PlaneType planeType;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool noPoints;

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x1C13F6C", Offset = "0x1C13F6C", VA = "0x1C13F6C")]
	public RFMirrored()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x1C0F78C", Offset = "0x1C0F78C", VA = "0x1C0F78C")]
	public static List<Vector3> GetMirroredPointCLoud(RFMirrored mirror, Transform tm, int seed, Bounds bound)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200004B")]
public class RFCustom
{
	[Token(Token = "0x2000093")]
	public enum RFPointCloudSourceType
	{
		[Token(Token = "0x40004DA")]
		ChildrenTransform = 4,
		[Token(Token = "0x40004DB")]
		TransformList = 8,
		[Token(Token = "0x40004DC")]
		Vector3List = 12
	}

	[Token(Token = "0x2000094")]
	public enum RFPointCloudUseType
	{
		[Token(Token = "0x40004DE")]
		VolumePoints = 4,
		[Token(Token = "0x40004DF")]
		PointCloud = 12
	}

	[Token(Token = "0x2000095")]
	public enum RFModifierType
	{
		[Token(Token = "0x40004E1")]
		None = 0,
		[Token(Token = "0x40004E2")]
		Splinters = 3,
		[Token(Token = "0x40004E3")]
		Slabs = 6
	}

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFPointCloudSourceType source;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public RFPointCloudUseType useAs;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int amount;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float radius;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool enable;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float size;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Transform> transforms;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> vector3;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool noPoints;

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x1C61358", Offset = "0x1C61358", VA = "0x1C61358")]
	public RFCustom()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x1C613A8", Offset = "0x1C613A8", VA = "0x1C613A8")]
	public RFCustom(RFCustom src)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1C61420", Offset = "0x1C61420", VA = "0x1C61420")]
	public static List<Vector3> GetCustomPointCLoud(RFCustom custom, Transform tm, int seed, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1C614EC", Offset = "0x1C614EC", VA = "0x1C614EC")]
	private static List<Vector3> GetCustomInputCloud(RFCustom custom, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x1C61758", Offset = "0x1C61758", VA = "0x1C61758")]
	private static List<Vector3> GetCustomOutputCloud(RFCustom custom, List<Vector3> inputPoints, int seed, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x1C6196C", Offset = "0x1C6196C", VA = "0x1C6196C")]
	private static List<Vector3> GetCustomBoundPoints(List<Vector3> inputPoints, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x1C61A4C", Offset = "0x1C61A4C", VA = "0x1C61A4C")]
	private static Vector3 RandomPointInRadius(Vector3 point, float radius)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x1C61B24", Offset = "0x1C61B24", VA = "0x1C61B24")]
	private static Vector3 RandomVector()
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200004C")]
public static class RFFragment
{
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16DA0", Offset = "0xD16DA0")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RFSlice slices;

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1C0F814", Offset = "0x1C0F814", VA = "0x1C0F814")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1C0FAD8", Offset = "0x1C0FAD8", VA = "0x1C0FAD8")]
		internal Vector3 <SetSlices>b__1(Transform t)
		{
			return default(Vector3);
		}
	}

	[Serializable]
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16DB0", Offset = "0xD16DB0")]
	private sealed class <>c
	{
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Transform, Vector3> <>9__28_0;

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1C0FAB4", Offset = "0x1C0FAB4", VA = "0x1C0FAB4")]
		public <>c()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1C0FABC", Offset = "0x1C0FABC", VA = "0x1C0FABC")]
		internal Vector3 <SetSlices>b__28_0(Transform t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool silentMode;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<Mesh> meshListStatic;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static List<Vector3> pivotListStatic;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static List<Dictionary<int, int>> subIdsListStatic;

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x1C0B1E0", Offset = "0x1C0B1E0", VA = "0x1C0B1E0")]
	public static void CacheMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x1C0C800", Offset = "0x1C0C800", VA = "0x1C0C800")]
	private static void RemovePlanar(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x1C0CAB0", Offset = "0x1C0CAB0", VA = "0x1C0CAB0")]
	private static void RemoveBySize(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scr)
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x1C0CF20", Offset = "0x1C0CF20", VA = "0x1C0CF20")]
	public static bool InputMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x1C0CFF4", Offset = "0x1C0CFF4", VA = "0x1C0CFF4")]
	private static bool SetRigidShatter(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x1C0D238", Offset = "0x1C0D238", VA = "0x1C0D238")]
	public static void CacheMeshesInst(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x1C0D5EC", Offset = "0x1C0D5EC", VA = "0x1C0D5EC")]
	public static void CacheMeshesMult(Transform tmSaved, ref List<Mesh> meshesList, ref List<Vector3> pivotsList, ref List<RFDictionary> subList, RayfireRigid scrRigid, List<int> batchAmount, int batchInd)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x1C0D460", Offset = "0x1C0D460", VA = "0x1C0D460")]
	private static void FinalCacheMeshes(ref Mesh[] meshes, RayfireRigid scrRigid, bool successState)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x1C0D19C", Offset = "0x1C0D19C", VA = "0x1C0D19C")]
	private static Mesh GetDemolitionMesh(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x1C0B7C4", Offset = "0x1C0B7C4", VA = "0x1C0B7C4")]
	private static Mesh GetDemolitionMesh(RayfireShatter scr)
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x1C0D94C", Offset = "0x1C0D94C", VA = "0x1C0D94C")]
	public static void SliceMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scr, List<Vector3> sliceData)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x1C0C318", Offset = "0x1C0C318", VA = "0x1C0C318")]
	private static bool Compute(int shatterMode, RFShatter shatter, Transform tm, ref Mesh[] meshes, ref Vector3[] pivots, Mesh mesh, int innerSubId, ref List<Dictionary<int, int>> subIds, UnityEngine.Object obj, [Optional] List<int> markedElements)
	{
		return default(bool);
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x1C0B6F0", Offset = "0x1C0B6F0", VA = "0x1C0B6F0")]
	private static int GetShatterMode([Optional] RayfireShatter scrShatter)
	{
		return default(int);
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x1C0DE90", Offset = "0x1C0DE90", VA = "0x1C0DE90")]
	private static bool EmptyMeshState(Mesh[] meshes)
	{
		return default(bool);
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x1C0BC08", Offset = "0x1C0BC08", VA = "0x1C0BC08")]
	private static void SetFragmentProperties(RFShatter shatter, RayfireShatter scrSh, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x1C0B8AC", Offset = "0x1C0B8AC", VA = "0x1C0B8AC")]
	private static RFShatter SetShatter(FragmentMode mode, int shatterMode, Mesh mesh, Transform transform, RFSurface interior, bool decompose, bool deleteCol, int seed = 1, bool preCap = true, bool remCap = false, bool remDbl = true, bool inner = false, bool smooth = false, int percSize = 3, bool postWeld = true)
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x1C0F2AC", Offset = "0x1C0F2AC", VA = "0x1C0F2AC")]
	private static void SetShatterEditorMode(RFShatter shatter, float sizeFilter, bool preCap, bool remCap, bool remDbl, bool exInside)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x1C0F3FC", Offset = "0x1C0F3FC", VA = "0x1C0F3FC")]
	private static void SetShatterRuntimeMode(RFShatter shatter)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x1C0DF10", Offset = "0x1C0DF10", VA = "0x1C0DF10")]
	private static void SetVoronoi(RFShatter shatter, int numFragments, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x1C0E06C", Offset = "0x1C0E06C", VA = "0x1C0E06C")]
	private static void SetSplinters(RFShatter shatter, RFSplinters splint, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1C0E1DC", Offset = "0x1C0E1DC", VA = "0x1C0E1DC")]
	private static void SetSlabs(RFShatter shatter, RFSplinters slabs, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x1C0E34C", Offset = "0x1C0E34C", VA = "0x1C0E34C")]
	private static void SetRadial(RFShatter shatter, RFRadial radial, Transform tm, Vector3 centerPos, Quaternion centerDirection)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1C0E5DC", Offset = "0x1C0E5DC", VA = "0x1C0E5DC")]
	private static void SetCustom(RFShatter shatter, RFCustom custom, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x1C0F6D8", Offset = "0x1C0F6D8", VA = "0x1C0F6D8")]
	private static void SetMirrored(RFShatter shatter, RFMirrored mirror, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1C0E6CC", Offset = "0x1C0E6CC", VA = "0x1C0E6CC")]
	private static void SetSlices(RFShatter shatter, Transform tm, RFSlice slices)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x1C0E9AC", Offset = "0x1C0E9AC", VA = "0x1C0E9AC")]
	private static void SetBricks(RFShatter shatter, Transform tm, RFBricks bricks, Bounds bounds)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1C0EC5C", Offset = "0x1C0EC5C", VA = "0x1C0EC5C")]
	private static void SetVoxels(RFShatter shatter, Transform tm, RFVoxels voxels, Bounds bounds)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x1C0F81C", Offset = "0x1C0F81C", VA = "0x1C0F81C")]
	private static float BoolToFloat(bool v)
	{
		return default(float);
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x1C0ED44", Offset = "0x1C0ED44", VA = "0x1C0ED44")]
	private static void SetTet(RFShatter shatter, Bounds bounds, RFTets tets)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x1C0F07C", Offset = "0x1C0F07C", VA = "0x1C0F07C")]
	private static void SetDecompose(RFShatter shatter)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x1C0F0DC", Offset = "0x1C0F0DC", VA = "0x1C0F0DC")]
	private static void SetClusters(RFShatter shatter, RFShatterCluster gluing)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x1C0F4B0", Offset = "0x1C0F4B0", VA = "0x1C0F4B0")]
	private static void SetStretching(RFShatter shatter, AxisType axis, float strength, FragType fragType)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x1C0F61C", Offset = "0x1C0F61C", VA = "0x1C0F61C")]
	private static Vector3 DirectionAxis(AxisType axisType)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x1C0F830", Offset = "0x1C0F830", VA = "0x1C0F830")]
	public static void RescaleMesh(Mesh mesh, float scale)
	{
	}
}
[Serializable]
[Token(Token = "0x200004D")]
public class RFMeshExport
{
	[Token(Token = "0x2000098")]
	public enum MeshExportType
	{
		[Token(Token = "0x40004E8")]
		LastFragments = 0,
		[Token(Token = "0x40004E9")]
		Children = 3
	}

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public MeshExportType source;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string suffix;

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x1C13F0C", Offset = "0x1C13F0C", VA = "0x1C13F0C")]
	public RFMeshExport()
	{
	}
}
[Serializable]
[Token(Token = "0x200004E")]
public class RFShatterAdvanced
{
	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int seed;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool decompose;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool removeCollinear;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	public bool copyComponents;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	public bool postWeld;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool smooth;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool inputPrecap;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool outputPrecap;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool removeDoubleFaces;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int elementSizeThreshold;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool combineChildren;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool inner;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool planar;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int relativeSize;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float absoluteSize;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool vertexLimitation;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int vertexAmount;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float planarThreshold;

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x19B9CA0", Offset = "0x19B9CA0", VA = "0x19B9CA0")]
	public RFShatterAdvanced()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x19B9D00", Offset = "0x19B9D00", VA = "0x19B9D00")]
	public RFShatterAdvanced(RFShatterAdvanced src)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x19B9D88", Offset = "0x19B9D88", VA = "0x19B9D88")]
	public static bool IsCoplanar(Mesh mesh, float threshold)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x200004F")]
public class RFSurface
{
	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Material innerMaterial;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float mappingScale;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material outerMaterial;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool needNewMat;

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x19BFF78", Offset = "0x19BFF78", VA = "0x19BFF78")]
	public RFSurface()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x19BFFC8", Offset = "0x19BFFC8", VA = "0x19BFFC8")]
	public void CopyFrom(RFSurface interior)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x19C001C", Offset = "0x19C001C", VA = "0x19C001C")]
	public static void SetMaterial(List<RFDictionary> origSubMeshIdsRF, Material[] sharedMaterials, RFSurface interior, MeshRenderer targetRend, int i, int amount)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x19C028C", Offset = "0x19C028C", VA = "0x19C028C")]
	public static int SetInnerSubId(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x19C0408", Offset = "0x19C0408", VA = "0x19C0408")]
	public static int SetInnerSubId(RayfireShatter scr)
	{
		return default(int);
	}
}
[Token(Token = "0x2000050")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD16390", Offset = "0xD16390")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD16390", Offset = "0xD16390")]
public class RayfireActivator : MonoBehaviour
{
	[Token(Token = "0x2000099")]
	public enum ActivationType
	{
		[Token(Token = "0x40004EB")]
		OnEnter,
		[Token(Token = "0x40004EC")]
		OnExit
	}

	[Token(Token = "0x200009A")]
	public enum AnimationType
	{
		[Token(Token = "0x40004EE")]
		ByGlobalPositionList = 0,
		[Token(Token = "0x40004EF")]
		ByStaticLine = 1,
		[Token(Token = "0x40004F0")]
		ByDynamicLine = 2,
		[Token(Token = "0x40004F1")]
		ByLocalPositionList = 5
	}

	[Token(Token = "0x200009B")]
	public enum GizmoType
	{
		[Token(Token = "0x40004F3")]
		Sphere,
		[Token(Token = "0x40004F4")]
		Box,
		[Token(Token = "0x40004F5")]
		Collider
	}

	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16DC0", Offset = "0xD16DC0")]
	private sealed class <DelayedActivationCor>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid rigid;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x19C2A00", Offset = "0x19C2A00", VA = "0x19C2A00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x19C2A68", Offset = "0x19C2A68", VA = "0x19C2A68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x19C1198", Offset = "0x19C1198", VA = "0x19C1198")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__40(int <>1__state)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x19C28F4", Offset = "0x19C28F4", VA = "0x19C28F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x19C28F8", Offset = "0x19C28F8", VA = "0x19C28F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x19C2A08", Offset = "0x19C2A08", VA = "0x19C2A08", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16DD0", Offset = "0xD16DD0")]
	private sealed class <DelayedClusterCor>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid rigid;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Collider coll;

		[Token(Token = "0x1700005C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x19C2DB4", Offset = "0x19C2DB4", VA = "0x19C2DB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x19C2E1C", Offset = "0x19C2E1C", VA = "0x19C2E1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x19C11C4", Offset = "0x19C11C4", VA = "0x19C11C4")]
		[DebuggerHidden]
		public <DelayedClusterCor>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x19C2BEC", Offset = "0x19C2BEC", VA = "0x19C2BEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x19C2BF0", Offset = "0x19C2BF0", VA = "0x19C2BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x19C2DBC", Offset = "0x19C2DBC", VA = "0x19C2DBC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16DE0", Offset = "0xD16DE0")]
	private sealed class <DelayedActivationCor>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot rigidRoot;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Collider coll;

		[Token(Token = "0x1700005E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x19C2B7C", Offset = "0x19C2B7C", VA = "0x19C2B7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x19C2BE4", Offset = "0x19C2BE4", VA = "0x19C2BE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x19C1568", Offset = "0x19C1568", VA = "0x19C1568")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x19C2A70", Offset = "0x19C2A70", VA = "0x19C2A70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x19C2A74", Offset = "0x19C2A74", VA = "0x19C2A74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x19C2B84", Offset = "0x19C2B84", VA = "0x19C2B84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16DF0", Offset = "0xD16DF0")]
	private sealed class <AnimationCor>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x17000060")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x19C2884", Offset = "0x19C2884", VA = "0x19C2884", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x19C28EC", Offset = "0x19C28EC", VA = "0x19C28EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x19C1DB4", Offset = "0x19C1DB4", VA = "0x19C1DB4")]
		[DebuggerHidden]
		public <AnimationCor>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x19C245C", Offset = "0x19C245C", VA = "0x19C245C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x19C2460", Offset = "0x19C2460", VA = "0x19C2460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x19C288C", Offset = "0x19C288C", VA = "0x19C288C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GizmoType gizmoType;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sphereRadius;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 boxSize;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool checkRigid;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool checkRigidRoot;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ActivationType type;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float delay;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool demolishCluster;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool apply;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 velocity;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 spin;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public ForceMode mode;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool showAnimation;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float duration;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float scaleAnimation;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public AnimationType positionAnimation;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public LineRenderer line;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<Vector3> positionList;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool showGizmo;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Collider activatorCollider;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool animating;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float pathRatio;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float lineLength;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<float> checkpoints;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float delta;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float deltaRatioStep;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float distDeltaStep;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private float distRatio;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float timePassed;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private int activeSegment;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Vector3 positionStart;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private Vector3 scaleStart;

	[Token(Token = "0x17000012")]
	public bool ByPositions
	{
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x19C2360", Offset = "0x19C2360", VA = "0x19C2360")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public bool ByLine
	{
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x19C1730", Offset = "0x19C1730", VA = "0x19C1730")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x19C091C", Offset = "0x19C091C", VA = "0x19C091C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x19C0B8C", Offset = "0x19C0B8C", VA = "0x19C0B8C")]
	private void OnTriggerEnter(Collider coll)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x19C0BEC", Offset = "0x19C0BEC", VA = "0x19C0BEC")]
	private void OnTriggerExit(Collider coll)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x19C0B9C", Offset = "0x19C0B9C", VA = "0x19C0B9C")]
	private void ActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x19C0C00", Offset = "0x19C0C00", VA = "0x19C0C00")]
	private void RigidListActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x19C1054", Offset = "0x19C1054", VA = "0x19C1054")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B960", Offset = "0xD1B960")]
	private IEnumerator DelayedActivationCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x19C10EC", Offset = "0x19C10EC", VA = "0x19C10EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1B9C4", Offset = "0xD1B9C4")]
	private IEnumerator DelayedClusterCor(RayfireRigid rigid, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x19C100C", Offset = "0x19C100C", VA = "0x19C100C")]
	private void Activate(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x19C0E40", Offset = "0x19C0E40", VA = "0x19C0E40")]
	private void RigidRootActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x19C14BC", Offset = "0x19C14BC", VA = "0x19C14BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BA28", Offset = "0xD1BA28")]
	private IEnumerator DelayedActivationCor(RayfireRigidRoot rigidRoot, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x19C1344", Offset = "0x19C1344", VA = "0x19C1344")]
	private void ActivateCollider(RayfireRigidRoot rigidRoot, Collider coll)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x19C11F0", Offset = "0x19C11F0", VA = "0x19C11F0")]
	private void AddForce(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x19C0980", Offset = "0x19C0980", VA = "0x19C0980")]
	private void ColliderCheck()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x19C1594", Offset = "0x19C1594", VA = "0x19C1594")]
	public void TriggerAnimation()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x19C1668", Offset = "0x19C1668", VA = "0x19C1668")]
	private void SetAnimation()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x19C1750", Offset = "0x19C1750", VA = "0x19C1750")]
	private void SetWorldPointsByLine()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x19C1930", Offset = "0x19C1930", VA = "0x19C1930")]
	private void SetWorldPointsByLocal()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x19C1B18", Offset = "0x19C1B18", VA = "0x19C1B18")]
	private void SetCheckPoints()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x19C16B4", Offset = "0x19C16B4", VA = "0x19C16B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BA8C", Offset = "0xD1BA8C")]
	private IEnumerator AnimationCor()
	{
		return null;
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x19C1DE0", Offset = "0x19C1DE0", VA = "0x19C1DE0")]
	private int GetSegment(float ration)
	{
		return default(int);
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x19C1EEC", Offset = "0x19C1EEC", VA = "0x19C1EEC")]
	private void ResetData()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x19C1F58", Offset = "0x19C1F58", VA = "0x19C1F58")]
	public void StopAnimation()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x19C1F60", Offset = "0x19C1F60", VA = "0x19C1F60")]
	public void ResetAnimation()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x19C1FA0", Offset = "0x19C1FA0", VA = "0x19C1FA0")]
	public void AddPosition(Vector3 newPos)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x19C2290", Offset = "0x19C2290", VA = "0x19C2290")]
	public void SetGizmoType(GizmoType gizmo)
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x19C2380", Offset = "0x19C2380", VA = "0x19C2380")]
	public RayfireActivator()
	{
	}
}
[Token(Token = "0x2000051")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD163F0", Offset = "0xD163F0")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD163F0", Offset = "0xD163F0")]
public class RayfireBlade : MonoBehaviour
{
	[Token(Token = "0x20000A0")]
	public enum CutType
	{
		[Token(Token = "0x4000508")]
		Enter,
		[Token(Token = "0x4000509")]
		Exit,
		[Token(Token = "0x400050A")]
		EnterExit
	}

	[Token(Token = "0x20000A1")]
	public enum ActionType
	{
		[Token(Token = "0x400050C")]
		Slice,
		[Token(Token = "0x400050D")]
		Demolish
	}

	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16E00", Offset = "0xD16E00")]
	private sealed class <CooldownCor>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireBlade <>4__this;

		[Token(Token = "0x17000062")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x19C3B40", Offset = "0x19C3B40", VA = "0x19C3B40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x19C3BA8", Offset = "0x19C3BA8", VA = "0x19C3BA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x19C37E8", Offset = "0x19C37E8", VA = "0x19C37E8")]
		[DebuggerHidden]
		public <CooldownCor>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x19C3A54", Offset = "0x19C3A54", VA = "0x19C3A54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x19C3A58", Offset = "0x19C3A58", VA = "0x19C3A58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x19C3B48", Offset = "0x19C3B48", VA = "0x19C3B48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ActionType actionType;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public CutType onTrigger;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PlaneType sliceType;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float force;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool affectInactive;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float damage;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float cooldown;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int mask;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string tagFilter;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<GameObject> targets;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public RayfireRigid rigid;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public Transform transForm;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public Vector3[] enterPlane;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public Vector3[] exitPlane;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public Collider colLider;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public bool coolDownState;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RFSliceEvent sliceEvent;

	[Token(Token = "0x17000014")]
	public bool HasTargets
	{
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x19C3950", Offset = "0x19C3950", VA = "0x19C3950")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x19C2E24", Offset = "0x19C2E24", VA = "0x19C2E24")]
	private void Awake()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x19C2E28", Offset = "0x19C2E28", VA = "0x19C2E28")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x19C2F88", Offset = "0x19C2F88", VA = "0x19C2F88")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x19C3048", Offset = "0x19C3048", VA = "0x19C3048")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x19C2F8C", Offset = "0x19C2F8C", VA = "0x19C2F8C")]
	private void TriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x19C304C", Offset = "0x19C304C", VA = "0x19C304C")]
	private void TriggerExit(Collider col)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x19C3540", Offset = "0x19C3540", VA = "0x19C3540")]
	private void Demolish(GameObject targetObject)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x19C376C", Offset = "0x19C376C", VA = "0x19C376C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BAF0", Offset = "0xD1BAF0")]
	private IEnumerator CooldownCor()
	{
		return null;
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x19C3814", Offset = "0x19C3814", VA = "0x19C3814")]
	private void SetCooldown(bool state)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x19C3660", Offset = "0x19C3660", VA = "0x19C3660")]
	private bool FilterCheck(GameObject targetObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x19C383C", Offset = "0x19C383C", VA = "0x19C383C")]
	public void SliceTarget()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x19C33A4", Offset = "0x19C33A4", VA = "0x19C33A4")]
	private void Slice(GameObject targetObject, Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x19C3720", Offset = "0x19C3720", VA = "0x19C3720")]
	private bool ApplyDamage(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x19C32AC", Offset = "0x19C32AC", VA = "0x19C32AC")]
	private Vector3[] GetSlicePlane()
	{
		return null;
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x19C3820", Offset = "0x19C3820", VA = "0x19C3820")]
	private bool LayerCheck(int layerId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x19C39AC", Offset = "0x19C39AC", VA = "0x19C39AC")]
	public RayfireBlade()
	{
	}
}
[Token(Token = "0x2000052")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD16450", Offset = "0xD16450")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD16450", Offset = "0xD16450")]
public class RayfireBomb : MonoBehaviour
{
	[Token(Token = "0x20000A3")]
	public enum RangeType
	{
		[Token(Token = "0x4000512")]
		Spherical
	}

	[Token(Token = "0x20000A4")]
	public enum FadeType
	{
		[Token(Token = "0x4000514")]
		Linear,
		[Token(Token = "0x4000515")]
		Exponential,
		[Token(Token = "0x4000516")]
		None
	}

	[Serializable]
	[Token(Token = "0x20000A5")]
	public class Projectile
	{
		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 positionPivot;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 positionClosest;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fade;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Rigidbody rb;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RayfireRigid rigid;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Quaternion rotation;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RFShard shard;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RayfireRigidRoot rigidRoot;

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x19C52CC", Offset = "0x19C52CC", VA = "0x19C52CC")]
		public Projectile()
		{
		}
	}

	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16E10", Offset = "0xD16E10")]
	private sealed class <ExplodeCor>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireBomb <>4__this;

		[Token(Token = "0x17000064")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x19C5F70", Offset = "0x19C5F70", VA = "0x19C5F70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x19C5FD8", Offset = "0x19C5FD8", VA = "0x19C5FD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x19C3FD8", Offset = "0x19C3FD8", VA = "0x19C3FD8")]
		[DebuggerHidden]
		public <ExplodeCor>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x19C5EAC", Offset = "0x19C5EAC", VA = "0x19C5EAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x19C5EB0", Offset = "0x19C5EB0", VA = "0x19C5EB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x19C5F78", Offset = "0x19C5F78", VA = "0x19C5F78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16E20", Offset = "0xD16E20")]
	private sealed class <ApplyExpand>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireBomb <>4__this;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<Projectile> action;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Projectile> <projs>5__2;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<bool> <applied>5__3;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <time>5__4;

		[Token(Token = "0x17000066")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x19C5E3C", Offset = "0x19C5E3C", VA = "0x19C5E3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x19C5EA4", Offset = "0x19C5EA4", VA = "0x19C5EA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x19C58B4", Offset = "0x19C58B4", VA = "0x19C58B4")]
		[DebuggerHidden]
		public <ApplyExpand>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x19C5A2C", Offset = "0x19C5A2C", VA = "0x19C5A2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x19C5A30", Offset = "0x19C5A30", VA = "0x19C5A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x19C5E44", Offset = "0x19C5E44", VA = "0x19C5E44", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool showGizmo;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RangeType rangeType;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FadeType fadeType;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int deletion;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float strength;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int variation;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int chaos;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float forceByMassScale;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float expandTime;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool affectInactive;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool affectKinematic;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float heightOffset;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float delay;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool atStart;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool destroy;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool applyDamage;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float damageValue;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool play;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float volume;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioClip clip;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFExplosionEvent explosionEvent;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public Vector3 bombPosition;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public Vector3 explPosition;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public Collider[] colliders;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public int mask;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public string tagFilter;

	[NonSerialized]
	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<Projectile> projectiles;

	[NonSerialized]
	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private List<Projectile> deletionProjectiles;

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x19C3BB0", Offset = "0x19C3BB0", VA = "0x19C3BB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x19C3C38", Offset = "0x19C3C38", VA = "0x19C3C38")]
	private void Start()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x19C3CD4", Offset = "0x19C3CD4", VA = "0x19C3CD4")]
	public void CopyFrom(RayfireBomb scr)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x19C3C7C", Offset = "0x19C3C7C", VA = "0x19C3C7C")]
	public void Explode(float delayLoc)
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x19C3F5C", Offset = "0x19C3F5C", VA = "0x19C3F5C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BB54", Offset = "0xD1BB54")]
	private IEnumerator ExplodeCor()
	{
		return null;
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x19C3D84", Offset = "0x19C3D84", VA = "0x19C3D84")]
	private void Explode()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x19C4900", Offset = "0x19C4900", VA = "0x19C4900")]
	private void PlayAudio()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x19C412C", Offset = "0x19C412C", VA = "0x19C412C")]
	private bool Setup()
	{
		return default(bool);
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x19C3BB4", Offset = "0x19C3BB4", VA = "0x19C3BB4")]
	private void ClearLists()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x19C4FDC", Offset = "0x19C4FDC", VA = "0x19C4FDC")]
	public void Restore()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x19C5004", Offset = "0x19C5004", VA = "0x19C5004")]
	private static void RestoreProjectiles(List<Projectile> prj)
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x19C4004", Offset = "0x19C4004", VA = "0x19C4004")]
	private void SetPositions()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x19C49CC", Offset = "0x19C49CC", VA = "0x19C49CC")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x19C4A18", Offset = "0x19C4A18", VA = "0x19C4A18")]
	private void SetProjectiles()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x19C419C", Offset = "0x19C419C", VA = "0x19C419C")]
	private bool SetRigidDamage()
	{
		return default(bool);
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x19C4368", Offset = "0x19C4368", VA = "0x19C4368")]
	private void Deletion()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x19C4684", Offset = "0x19C4684", VA = "0x19C4684")]
	private void Activate()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x19C540C", Offset = "0x19C540C", VA = "0x19C540C")]
	private void Activate(Projectile projectile)
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x19C4808", Offset = "0x19C4808", VA = "0x19C4808")]
	private void SetForce()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x19C5628", Offset = "0x19C5628", VA = "0x19C5628")]
	private void SetForce(Projectile projectile)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x19C4770", Offset = "0x19C4770", VA = "0x19C4770")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BBB8", Offset = "0xD1BBB8")]
	private IEnumerator ApplyExpand(Action<Projectile> action)
	{
		return null;
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x19C52D4", Offset = "0x19C52D4", VA = "0x19C52D4")]
	private float Fade(Vector3 bombPos, Vector3 fragPos)
	{
		return default(float);
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x19C57C8", Offset = "0x19C57C8", VA = "0x19C57C8")]
	private Vector3 Vector(Projectile projectile)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x19C58E0", Offset = "0x19C58E0", VA = "0x19C58E0")]
	public RayfireBomb()
	{
	}
}
[Token(Token = "0x2000053")]
[SelectionBase]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD164B0", Offset = "0xD164B0")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD164B0", Offset = "0xD164B0")]
public class RayfireCluster : MonoBehaviour
{
	[Token(Token = "0x20000A8")]
	public enum ClusterType
	{
		[Token(Token = "0x400052A")]
		ByPointCloud,
		[Token(Token = "0x400052B")]
		BySharedArea
	}

	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16E30", Offset = "0xD16E30")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RFShard biggestShard;

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x179CF28", Offset = "0x179CF28", VA = "0x179CF28")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x179CF30", Offset = "0x179CF30", VA = "0x179CF30")]
		internal bool <ClusterizeRangeShards>b__0(RFShard t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16E40", Offset = "0xD16E40")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RFCluster biggestCluster;

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x179CF60", Offset = "0x179CF60", VA = "0x179CF60")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x179CF68", Offset = "0x179CF68", VA = "0x179CF68")]
		internal bool <ClusterizeRangeClusters>b__0(RFCluster t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A14C", Offset = "0xD1A14C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1A14C", Offset = "0xD1A14C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A14C", Offset = "0xD1A14C")]
	public ClusterType type;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1A1BC", Offset = "0xD1A1BC")]
	public int depth;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1A1D4", Offset = "0xD1A1D4")]
	public int seed;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1A1F0", Offset = "0xD1A1F0")]
	public int smoothPass;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1A208", Offset = "0xD1A208")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A208", Offset = "0xD1A208")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1A208", Offset = "0xD1A208")]
	public int baseAmount;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1A280", Offset = "0xD1A280")]
	public int depthAmount;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConnectivityType connectivity;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1A29C", Offset = "0xD1A29C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A29C", Offset = "0xD1A29C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1A29C", Offset = "0xD1A29C")]
	public int minimumAmount;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1A310", Offset = "0xD1A310")]
	public int maximumAmount;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public bool showGizmo;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	[HideInInspector]
	public bool colorPreview;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	[HideInInspector]
	public bool scalePreview;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Color wireColor;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public float previewScale;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public List<RFCluster> allClusters;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public List<RFShard> allShards;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int clusterId;

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x19C5FE0", Offset = "0x19C5FE0", VA = "0x19C5FE0")]
	public void Extract()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x19C61E8", Offset = "0x19C61E8", VA = "0x19C61E8")]
	public void Clusterize()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x19C6270", Offset = "0x19C6270", VA = "0x19C6270")]
	private void ClusterizeVoronoi()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x19C6A90", Offset = "0x19C6A90", VA = "0x19C6A90")]
	private List<RFCluster> ClusterizeClusterByAmount(RFCluster parentCluster, int amount)
	{
		return null;
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x19C7F60", Offset = "0x19C7F60", VA = "0x19C7F60")]
	private void ConnectivityCheck(List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x19C645C", Offset = "0x19C645C", VA = "0x19C645C")]
	private void ClusterizeRange()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x19C89C8", Offset = "0x19C89C8", VA = "0x19C89C8")]
	private List<RFCluster> ClusterizeRangeShards(RFCluster mainCluster)
	{
		return null;
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x19C8D90", Offset = "0x19C8D90", VA = "0x19C8D90")]
	private List<RFCluster> ClusterizeRangeClusters(RFCluster parentCluster)
	{
		return null;
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x19C7700", Offset = "0x19C7700", VA = "0x19C7700")]
	private static void RoughnessPassShards(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x19C95B8", Offset = "0x19C95B8", VA = "0x19C95B8")]
	private void RoughnessPassClusters(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x19C7518", Offset = "0x19C7518", VA = "0x19C7518")]
	private void SetSoloShardToCluster(List<RFShard> soloShards, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x19C9E38", Offset = "0x19C9E38", VA = "0x19C9E38")]
	private int GetNeibIndArea(RFShard shard, [Optional] List<RFShard> shardList)
	{
		return default(int);
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x19C93C8", Offset = "0x19C93C8", VA = "0x19C93C8")]
	private void SetSoloClusterToCluster(List<RFCluster> soloClusters, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x19C6990", Offset = "0x19C6990", VA = "0x19C6990")]
	private RFCluster SetupMainCluster(ConnectivityType connect)
	{
		return null;
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x19C7194", Offset = "0x19C7194", VA = "0x19C7194")]
	private void SetClusterNames()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x19C87F4", Offset = "0x19C87F4", VA = "0x19C87F4")]
	private void CreateRoot(RFCluster childCluster, Transform parentTm)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x19C9F68", Offset = "0x19C9F68", VA = "0x19C9F68")]
	private Bounds GetShardsBound(List<RFShard> shards, [Optional] List<RFCluster> clusters)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x19C90A4", Offset = "0x19C90A4", VA = "0x19C90A4")]
	private static RFShard GetNeibShardArea(List<RFShard> shardGroup, List<RFShard> shardList)
	{
		return null;
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x19C7388", Offset = "0x19C7388", VA = "0x19C7388")]
	private List<Vector3> VoronoiPointCloud(Bounds bound, int am)
	{
		return null;
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x19CA1F0", Offset = "0x19CA1F0", VA = "0x19CA1F0")]
	public RayfireCluster()
	{
	}
}
[Token(Token = "0x2000054")]
public class RFCombineMesh
{
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16E50", Offset = "0xD16E50")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transForm;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Transform> transList;

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1C605CC", Offset = "0x1C605CC", VA = "0x1C605CC")]
		public <>c__DisplayClass7_0()
		{
		}
	}

	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16E60", Offset = "0xD16E60")]
	private sealed class <>c__DisplayClass7_1
	{
		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass7_0 CS$<>8__locals1;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1C605D4", Offset = "0x1C605D4", VA = "0x1C605D4")]
		public <>c__DisplayClass7_1()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1C61294", Offset = "0x1C61294", VA = "0x1C61294")]
		internal Vector3 <GetCombinedMesh>b__0(Vector3 t)
		{
			return default(Vector3);
		}
	}

	[Serializable]
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16E70", Offset = "0xD16E70")]
	private sealed class <>c
	{
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Vector3, Vector3> <>9__7_1;

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1C6119C", Offset = "0x1C6119C", VA = "0x1C6119C")]
		public <>c()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1C611A4", Offset = "0x1C611A4", VA = "0x1C611A4")]
		internal Vector3 <GetCombinedMesh>b__7_1(Vector3 o)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16E80", Offset = "0xD16E80")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Material> allMaterials;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<Material, int> <>9__0;

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1C6112C", Offset = "0x1C6112C", VA = "0x1C6112C")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1C6122C", Offset = "0x1C6122C", VA = "0x1C6122C")]
		internal int <GetMatIdList>b__0(Material t)
		{
			return default(int);
		}
	}

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<int> trianglesSubId;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<List<int>> triangles;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Vector3> vertices;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Vector3> normals;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Vector2> uvs;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Vector4> tangents;

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x1C5FDF4", Offset = "0x1C5FDF4", VA = "0x1C5FDF4")]
	public RFCombineMesh()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x1C5FF6C", Offset = "0x1C5FF6C", VA = "0x1C5FF6C")]
	public static RFCombineMesh GetCombinedMesh(Transform transForm, List<Mesh> meshList, List<Transform> transList, List<List<int>> matIdList, List<bool> invertNormals)
	{
		return null;
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x1C605DC", Offset = "0x1C605DC", VA = "0x1C605DC")]
	public static Mesh CreateMesh(RFCombineMesh cMesh, string name)
	{
		return null;
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x1C60788", Offset = "0x1C60788", VA = "0x1C60788")]
	public static Mesh CombineShatter(RayfireShatter shatter, Transform root, List<MeshFilter> filters)
	{
		return null;
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x1C60910", Offset = "0x1C60910", VA = "0x1C60910")]
	private static void GetMeshTransMatLists(List<MeshFilter> filters, ref List<Mesh> meshList, ref List<Transform> transList, ref List<List<Material>> matList, int verts, float size)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x1C60C70", Offset = "0x1C60C70", VA = "0x1C60C70")]
	public static List<Material> GetAllMaterials(List<Transform> transList, List<List<Material>> matList)
	{
		return null;
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x1C60E1C", Offset = "0x1C60E1C", VA = "0x1C60E1C")]
	public static List<List<int>> GetMatIdList(List<Transform> transList, List<List<Material>> matList, List<Material> allMaterials)
	{
		return null;
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x1C60FBC", Offset = "0x1C60FBC", VA = "0x1C60FBC")]
	public static List<bool> GetInvertList(List<Transform> transList)
	{
		return null;
	}
}
[Token(Token = "0x2000055")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD16520", Offset = "0xD16520")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD16520", Offset = "0xD16520")]
public class RayfireCombine : MonoBehaviour
{
	[Token(Token = "0x20000AF")]
	public enum CombType
	{
		[Token(Token = "0x4000537")]
		Children,
		[Token(Token = "0x4000538")]
		ObjectsList
	}

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CombType type;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<GameObject> objects;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool meshFilters;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool skinnedMeshes;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool particleSystems;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sizeThreshold;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int vertexThreshold;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform transForm;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private MeshFilter mFilter;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MeshRenderer mRenderer;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<bool> invertNormals;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Transform> transList;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<MeshFilter> mFilters;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<SkinnedMeshRenderer> skinnedMeshRends;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<ParticleSystemRenderer> particleRends;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<Mesh> meshList;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<List<int>> matIdList;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<List<Material>> matList;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<Material> allMaterials;

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x179CF98", Offset = "0x179CF98", VA = "0x179CF98")]
	public void Combine()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x179D078", Offset = "0x179D078", VA = "0x179D078")]
	private bool SetData()
	{
		return default(bool);
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x179E6A8", Offset = "0x179E6A8", VA = "0x179E6A8")]
	public RayfireCombine()
	{
	}
}
[Token(Token = "0x2000056")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD16580", Offset = "0xD16580")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD16580", Offset = "0xD16580")]
public class RayfireConnectivity : MonoBehaviour
{
	[Token(Token = "0x20000B0")]
	public enum RFConnInitType
	{
		[Token(Token = "0x400053A")]
		AtStart = 1,
		[Token(Token = "0x400053B")]
		ByMethod = 3,
		[Token(Token = "0x400053C")]
		ByIntegrity = 5
	}

	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16E90", Offset = "0xD16E90")]
	private sealed class <ConnectivityCor>d__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity <>4__this;

		[Token(Token = "0x17000068")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x17A2240", Offset = "0x17A2240", VA = "0x17A2240", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x17A22A8", Offset = "0x17A22A8", VA = "0x17A22A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x17A0090", Offset = "0x17A0090", VA = "0x17A0090")]
		[DebuggerHidden]
		public <ConnectivityCor>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x17A2188", Offset = "0x17A2188", VA = "0x17A2188", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x17A218C", Offset = "0x17A218C", VA = "0x17A218C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x17A2248", Offset = "0x17A2248", VA = "0x17A2248", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16EA0", Offset = "0xD16EA0")]
	private sealed class <ChildrenCor>d__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity <>4__this;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <checkChildren>5__2;

		[Token(Token = "0x1700006A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x17A2118", Offset = "0x17A2118", VA = "0x17A2118", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x17A2180", Offset = "0x17A2180", VA = "0x17A2180", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x17A1C94", Offset = "0x17A1C94", VA = "0x17A1C94")]
		[DebuggerHidden]
		public <ChildrenCor>d__58(int <>1__state)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x17A2070", Offset = "0x17A2070", VA = "0x17A2070", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x17A2074", Offset = "0x17A2074", VA = "0x17A2074", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x17A2120", Offset = "0x17A2120", VA = "0x17A2120", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ConnectivityType type;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float expand;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float minimumArea;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minimumSize;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int percentage;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int seed;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool clusterize;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool demolishable;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public RFConnInitType startCollapse;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int collapseByIntegrity;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFCollapse collapse;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFConnInitType startStress;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int stressByIntegrity;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFStress stress;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool showConnections;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool showNodes;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	public bool showGizmo;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
	public bool showStress;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool checkConnectivity;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool connectivityCheckNeed;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<RayfireRigid> rigidList;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFCluster cluster;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int initShardAmount;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int clsCount;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RayfireRigidRoot rigidRootHost;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public RayfireRigid meshRootHost;

	[NonSerialized]
	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public RFBackupCluster backup;

	[NonSerialized]
	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool childrenChanged;

	[NonSerialized]
	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	private bool childrenCorState;

	[NonSerialized]
	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
	private bool connectivityCorState;

	[NonSerialized]
	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
	private bool corState;

	[Token(Token = "0x17000015")]
	public float AmountIntegrity
	{
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x17A0374", Offset = "0x17A0374", VA = "0x17A0374")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x179E6D0", Offset = "0x179E6D0", VA = "0x179E6D0")]
	private void SetRuntimeMeshRootHost()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x179E820", Offset = "0x179E820", VA = "0x179E820")]
	public void ResetConnectivity()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x179E858", Offset = "0x179E858", VA = "0x179E858")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x179E864", Offset = "0x179E864", VA = "0x179E864")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x179EA60", Offset = "0x179EA60", VA = "0x179EA60")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x179EBF8", Offset = "0x179EBF8", VA = "0x179EBF8")]
	private bool WarningCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x179F2B0", Offset = "0x179F2B0", VA = "0x179F2B0")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x179F340", Offset = "0x179F340", VA = "0x179F340")]
	private void PrepareCluster()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x179F4A0", Offset = "0x179F4A0", VA = "0x179F4A0")]
	private void CreateCluster()
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x179EDB0", Offset = "0x179EDB0", VA = "0x179EDB0")]
	private void SetClusterForMeshRoot()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x179F018", Offset = "0x179F018", VA = "0x179F018")]
	private void SetClusterForRigidRoot()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x179FCC0", Offset = "0x179FCC0", VA = "0x179FCC0")]
	private void SetExpand()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x179F5D4", Offset = "0x179F5D4", VA = "0x179F5D4")]
	private void SetRigidListByFragments(List<RayfireRigid> rgList)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x179F7C4", Offset = "0x179F7C4", VA = "0x179F7C4")]
	public static bool InitCachedShardsByRigidList(List<RayfireRigid> rigids, RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x179FD84", Offset = "0x179FD84", VA = "0x179FD84")]
	public static void InitCachedShardsByRigidRoot(RayfireRigidRoot root, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x179E9E4", Offset = "0x179E9E4", VA = "0x179E9E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BC1C", Offset = "0xD1BC1C")]
	private IEnumerator ConnectivityCor()
	{
		return null;
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x17A00BC", Offset = "0x17A00BC", VA = "0x17A00BC")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x17A0294", Offset = "0x17A0294", VA = "0x17A0294")]
	private void CheckConnectivityRigidList()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x17A01B4", Offset = "0x17A01B4", VA = "0x17A01B4")]
	private void CheckConnectivityRigidRoot()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x17A07BC", Offset = "0x17A07BC", VA = "0x17A07BC")]
	private void ActivateShards(List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x17A0C4C", Offset = "0x17A0C4C", VA = "0x17A0C4C")]
	private void Clusterize()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x17A03E8", Offset = "0x17A03E8", VA = "0x17A03E8")]
	private static void CleanUpActivatedShardsRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x17A05F0", Offset = "0x17A05F0", VA = "0x17A05F0")]
	private static void CheckUnyieldingRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x17A0980", Offset = "0x17A0980", VA = "0x17A0980")]
	private static void CleanUpActivatedShardsRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x17A0A80", Offset = "0x17A0A80", VA = "0x17A0A80")]
	private static void CheckUnyieldingRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x17A1C88", Offset = "0x17A1C88", VA = "0x17A1C88")]
	private void OnTransformChildrenChanged()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x179E968", Offset = "0x179E968", VA = "0x179E968")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BC80", Offset = "0xD1BC80")]
	private IEnumerator ChildrenCor()
	{
		return null;
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x17A1CC0", Offset = "0x17A1CC0", VA = "0x17A1CC0")]
	private void ChildrenCheck()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x179EF00", Offset = "0x179EF00", VA = "0x179EF00")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x17A203C", Offset = "0x17A203C", VA = "0x17A203C")]
	public RayfireConnectivity()
	{
	}
}
[Token(Token = "0x2000057")]
[SelectionBase]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD165F0", Offset = "0xD165F0")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD165F0", Offset = "0xD165F0")]
public class RayfireDebris : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16EB0", Offset = "0xD16EB0")]
	private sealed class <>c
	{
		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<MeshFilter, bool> <>9__28_0;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<MeshFilter, Mesh> <>9__28_1;

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x17A353C", Offset = "0x17A353C", VA = "0x17A353C")]
		public <>c()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x17A3544", Offset = "0x17A3544", VA = "0x17A3544")]
		internal bool <SetReferenceMeshes>b__28_0(MeshFilter mf)
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x17A35FC", Offset = "0x17A35FC", VA = "0x17A35FC")]
		internal Mesh <SetReferenceMeshes>b__28_1(MeshFilter mf)
		{
			return null;
		}
	}

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1A398", Offset = "0xD1A398")]
	public bool onDemolition;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A3D0", Offset = "0xD1A3D0")]
	public bool onActivation;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A3E4", Offset = "0xD1A3E4")]
	public bool onImpact;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1A3F8", Offset = "0xD1A3F8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A3F8", Offset = "0xD1A3F8")]
	public GameObject debrisReference;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A448", Offset = "0xD1A448")]
	public Material debrisMaterial;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A45C", Offset = "0xD1A45C")]
	public Material emissionMaterial;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1A470", Offset = "0xD1A470")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A470", Offset = "0xD1A470")]
	public RFParticleEmission emission;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A4C0", Offset = "0xD1A4C0")]
	public RFParticleDynamicDebris dynamic;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A4D4", Offset = "0xD1A4D4")]
	public RFParticleNoise noise;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A4E8", Offset = "0xD1A4E8")]
	public RFParticleCollisionDebris collision;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A4FC", Offset = "0xD1A4FC")]
	public RFParticleLimitations limitations;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A510", Offset = "0xD1A510")]
	public RFParticleRendering rendering;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public RayfireRigid rigid;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public ParticleSystem pSystem;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Transform hostTm;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public bool initialized;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public List<Mesh> debrisMeshList;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public Vector3 refScale;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public List<RayfireDebris> children;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	public int amountFinal;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[HideInInspector]
	public bool oldChild;

	[Token(Token = "0x17000016")]
	public bool HasChildren
	{
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x17A30A4", Offset = "0x17A30A4", VA = "0x17A30A4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x17A22B0", Offset = "0x17A22B0", VA = "0x17A22B0")]
	public RayfireDebris()
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x17A24B8", Offset = "0x17A24B8", VA = "0x17A24B8")]
	public void CopyFrom(RayfireDebris source)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x17A25B8", Offset = "0x17A25B8", VA = "0x17A25B8")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x17A2A3C", Offset = "0x17A2A3C", VA = "0x17A2A3C")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x17A2E80", Offset = "0x17A2E80", VA = "0x17A2E80")]
	public void Clean()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x17A2B6C", Offset = "0x17A2B6C", VA = "0x17A2B6C")]
	public void CreateDebris(RayfireDebris scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x17A3100", Offset = "0x17A3100", VA = "0x17A3100")]
	private void SetParticleRendererDebris(ParticleSystemRenderer rend, RayfireDebris scr)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x17A25CC", Offset = "0x17A25CC", VA = "0x17A25CC")]
	private void SetReferenceMeshes(GameObject refs)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x17A32F4", Offset = "0x17A32F4", VA = "0x17A32F4")]
	private void SetDebrisMaterial(List<MeshFilter> mfs)
	{
	}
}
[Token(Token = "0x2000058")]
[SelectionBase]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD16660", Offset = "0xD16660")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD16660", Offset = "0xD16660")]
public class RayfireDust : MonoBehaviour
{
	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1A5B4", Offset = "0xD1A5B4")]
	public bool onDemolition;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A5EC", Offset = "0xD1A5EC")]
	public bool onActivation;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A600", Offset = "0xD1A600")]
	public bool onImpact;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1A614", Offset = "0xD1A614")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A614", Offset = "0xD1A614")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD1A614", Offset = "0xD1A614")]
	public float opacity;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A680", Offset = "0xD1A680")]
	public Material dustMaterial;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A694", Offset = "0xD1A694")]
	public List<Material> dustMaterials;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A6A8", Offset = "0xD1A6A8")]
	public Material emissionMaterial;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1A6BC", Offset = "0xD1A6BC")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A6BC", Offset = "0xD1A6BC")]
	public RFParticleEmission emission;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A70C", Offset = "0xD1A70C")]
	public RFParticleDynamicDust dynamic;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A720", Offset = "0xD1A720")]
	public RFParticleNoise noise;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A734", Offset = "0xD1A734")]
	public RFParticleCollisionDust collision;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A748", Offset = "0xD1A748")]
	public RFParticleLimitations limitations;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A75C", Offset = "0xD1A75C")]
	public RFParticleRendering rendering;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public RayfireRigid rigid;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public ParticleSystem pSystem;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Transform hostTm;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public bool initialized;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public List<RayfireDust> children;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public int amountFinal;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[HideInInspector]
	public bool oldChild;

	[Token(Token = "0x17000017")]
	public bool HasChildren
	{
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x17A413C", Offset = "0x17A413C", VA = "0x17A413C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000018")]
	public bool HasMaterials
	{
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x17A3AC0", Offset = "0x17A3AC0", VA = "0x17A3AC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x17A3618", Offset = "0x17A3618", VA = "0x17A3618")]
	public RayfireDust()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x17A37B8", Offset = "0x17A37B8", VA = "0x17A37B8")]
	public void CopyFrom(RayfireDust source)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x17A38B0", Offset = "0x17A38B0", VA = "0x17A38B0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x17A3B1C", Offset = "0x17A3B1C", VA = "0x17A3B1C")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x17A3F18", Offset = "0x17A3F18", VA = "0x17A3F18")]
	public void Clean()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x17A3C2C", Offset = "0x17A3C2C", VA = "0x17A3C2C")]
	public void CreateDust(RayfireDust scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x17A4198", Offset = "0x17A4198", VA = "0x17A4198")]
	private void SetParticleRendererDust(ParticleSystemRenderer rend, RayfireDust scr)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x17A430C", Offset = "0x17A430C", VA = "0x17A430C")]
	private void SetMaterialDust(ParticleSystemRenderer rend, List<Material> mats)
	{
	}
}
[Token(Token = "0x2000059")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD166D0", Offset = "0xD166D0")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD166D0", Offset = "0xD166D0")]
public class RayfireGun : MonoBehaviour
{
	[Token(Token = "0x20000B4")]
	public enum ImpactType
	{
		[Token(Token = "0x4000548")]
		AddExplosionForce,
		[Token(Token = "0x4000549")]
		AddForceAtPosition
	}

	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16EC0", Offset = "0xD16EC0")]
	private sealed class <StartShootCor>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireGun <>4__this;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <shootId>5__2;

		[Token(Token = "0x1700006C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x17A68C0", Offset = "0x17A68C0", VA = "0x17A68C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x17A6928", Offset = "0x17A6928", VA = "0x17A6928", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x17A44AC", Offset = "0x17A44AC", VA = "0x17A44AC")]
		[DebuggerHidden]
		public <StartShootCor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x17A67D0", Offset = "0x17A67D0", VA = "0x17A67D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x17A67D4", Offset = "0x17A67D4", VA = "0x17A67D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x17A68C8", Offset = "0x17A68C8", VA = "0x17A68C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16ED0", Offset = "0xD16ED0")]
	private sealed class <BurstCor>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireGun <>4__this;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x1700006E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x17A6760", Offset = "0x17A6760", VA = "0x17A6760", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x17A67C8", Offset = "0x17A67C8", VA = "0x17A67C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x17A4CB8", Offset = "0x17A4CB8", VA = "0x17A4CB8")]
		[DebuggerHidden]
		public <BurstCor>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x17A6664", Offset = "0x17A6664", VA = "0x17A6664", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x17A6668", Offset = "0x17A6668", VA = "0x17A6668", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x17A6768", Offset = "0x17A6768", VA = "0x17A6768", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AxisType axis;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxDistance;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int rounds;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float rate;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ImpactType type;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float strength;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float radius;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool demolishCluster;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool affectInactive;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	public bool rigid;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	public bool rigidRoot;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD1A7E0", Offset = "0xD1A7E0")]
	public bool rigidBody;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float damage;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool debris;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool dust;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool flash;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFFlash Flash;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int mask;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string tagFilter;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool showRay;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool showHit;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	public bool shooting;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string untagged;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RFShotEvent shotEvent;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Collider[] impactColliders;

	[Token(Token = "0x17000019")]
	public Vector3 ShootVector
	{
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x17A455C", Offset = "0x17A455C", VA = "0x17A455C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x17A43F8", Offset = "0x17A43F8", VA = "0x17A43F8")]
	public void StartShooting()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x17A4430", Offset = "0x17A4430", VA = "0x17A4430")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BCE4", Offset = "0xD1BCE4")]
	private IEnumerator StartShootCor()
	{
		return null;
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x17A44D8", Offset = "0x17A44D8", VA = "0x17A44D8")]
	public void StopShooting()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x17A44E0", Offset = "0x17A44E0", VA = "0x17A44E0")]
	public void Shoot(int shootId = 1)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x17A4C04", Offset = "0x17A4C04", VA = "0x17A4C04")]
	public void Burst()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x17A4C3C", Offset = "0x17A4C3C", VA = "0x17A4C3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BD48", Offset = "0xD1BD48")]
	private IEnumerator BurstCor()
	{
		return null;
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x17A46F8", Offset = "0x17A46F8", VA = "0x17A46F8")]
	public void Shoot(Vector3 shootPos, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x17A5438", Offset = "0x17A5438", VA = "0x17A5438")]
	private void ImpactRigid(RayfireRigid rigidScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x17A5B3C", Offset = "0x17A5B3C", VA = "0x17A5B3C")]
	private void ImpactRoot(RayfireRigidRoot rootScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x17A5F70", Offset = "0x17A5F70", VA = "0x17A5F70")]
	private void AddForce(List<Rigidbody> impactRbList, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x17A521C", Offset = "0x17A521C", VA = "0x17A521C")]
	private RayfireRigid ApplyDamage(RayfireRigid scrRigid, RaycastHit hit, Vector3 shootPos, Vector3 shootVector, Vector3 impactPoint)
	{
		return null;
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x17A4CE4", Offset = "0x17A4CE4", VA = "0x17A4CE4")]
	private void VfxFlash(Vector3 position, Vector3 normal)
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x17A4EFC", Offset = "0x17A4EFC", VA = "0x17A4EFC")]
	private void VfxDebris(List<RayfireDebris> debrisList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x17A508C", Offset = "0x17A508C", VA = "0x17A508C")]
	private void VfxDust(List<RayfireDust> dustList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x17A61C0", Offset = "0x17A61C0", VA = "0x17A61C0")]
	private List<RayfireRigid> ActivationCheck(RayfireRigid scrTarget, Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x17A64FC", Offset = "0x17A64FC", VA = "0x17A64FC")]
	public RayfireGun()
	{
	}
}
[Token(Token = "0x200005A")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD16730", Offset = "0xD16730")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD16730", Offset = "0xD16730")]
public class RayfireMan : MonoBehaviour
{
	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static RayfireMan inst;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int buildMajor;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int buildMinor;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool setGravity;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float multiplier;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RigidbodyInterpolation interpolation;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float colliderSize;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static float colliderSizeStatic;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD1A818", Offset = "0xD1A818")]
	public CollisionDetectionMode meshCollision;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public CollisionDetectionMode clusterCollision;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float minimumMass;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float maximumMass;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFMaterialPresets materialPresets;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject parent;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float globalSolidity;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float timeQuota;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFManDemolition advancedDemolitionProperties;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFPoolingFragment fragments;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFPoolingParticles particles;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform transForm;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<string> layers;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RFStorage storage;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float maxTimeThisFrame;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public HashSet<string> layersHash;

	[Token(Token = "0x1700001A")]
	public static bool MaxAmountCheck
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x17A7278", Offset = "0x17A7278", VA = "0x17A7278")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x17A6930", Offset = "0x17A6930", VA = "0x17A6930")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x17A6BCC", Offset = "0x17A6BCC", VA = "0x17A6BCC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x17A6BD4", Offset = "0x17A6BD4", VA = "0x17A6BD4")]
	private void Reset()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x17A6934", Offset = "0x17A6934", VA = "0x17A6934")]
	private void SetInstance()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x17A6EC8", Offset = "0x17A6EC8", VA = "0x17A6EC8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x17A6F00", Offset = "0x17A6F00", VA = "0x17A6F00")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x17A6BD8", Offset = "0x17A6BD8", VA = "0x17A6BD8")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x17A6F60", Offset = "0x17A6F60", VA = "0x17A6F60")]
	private void SetGravity()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x17A7120", Offset = "0x17A7120", VA = "0x17A7120")]
	public static void RayFireManInit()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x17A701C", Offset = "0x17A701C", VA = "0x17A701C")]
	private void SetLayers()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x17A6C9C", Offset = "0x17A6C9C", VA = "0x17A6C9C")]
	private void SetPooling()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x17A6DD0", Offset = "0x17A6DD0", VA = "0x17A6DD0")]
	private void SetStorage()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x17A7300", Offset = "0x17A7300", VA = "0x17A7300")]
	public static void SetParentByManager(Transform tm, Transform original, bool noRegister = false)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x17A74A4", Offset = "0x17A74A4", VA = "0x17A74A4")]
	public static void SetParentToManager(Transform tm)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x17A7554", Offset = "0x17A7554", VA = "0x17A7554")]
	public static void SetParentByManager(Transform tm)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x17A76B4", Offset = "0x17A76B4", VA = "0x17A76B4")]
	public static void DestroyFragment(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x17A7958", Offset = "0x17A7958", VA = "0x17A7958")]
	public static void DestroyShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x17A7A2C", Offset = "0x17A7A2C", VA = "0x17A7A2C")]
	public static void DestroyGo(GameObject go)
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x17A77D0", Offset = "0x17A77D0", VA = "0x17A77D0")]
	private static void DestroyOp(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x17A7A94", Offset = "0x17A7A94", VA = "0x17A7A94")]
	public RayfireMan()
	{
	}
}
[Serializable]
[Token(Token = "0x200005B")]
public class RFCache
{
	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<bool> act;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Vector3> pos;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Quaternion> rot;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform transform;

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x1C5A138", Offset = "0x1C5A138", VA = "0x1C5A138")]
	public RFCache(Transform parent, Transform tm)
	{
	}
}
[Token(Token = "0x200005C")]
[SelectionBase]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD167A0", Offset = "0xD167A0")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD167A0", Offset = "0xD167A0")]
public class RayfireRecorder : MonoBehaviour
{
	[Token(Token = "0x20000B7")]
	public enum AnimatorType
	{
		[Token(Token = "0x4000553")]
		Disabled = 0,
		[Token(Token = "0x4000554")]
		Record = 2,
		[Token(Token = "0x4000555")]
		Play = 8
	}

	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16EE0", Offset = "0xD16EE0")]
	private sealed class <RecordCor>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRecorder <>4__this;

		[Token(Token = "0x17000070")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x17A9020", Offset = "0x17A9020", VA = "0x17A9020", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x17A9088", Offset = "0x17A9088", VA = "0x17A9088", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x17A8C4C", Offset = "0x17A8C4C", VA = "0x17A8C4C")]
		[DebuggerHidden]
		public <RecordCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x17A8D04", Offset = "0x17A8D04", VA = "0x17A8D04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x17A8D08", Offset = "0x17A8D08", VA = "0x17A8D08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x17A9028", Offset = "0x17A9028", VA = "0x17A9028", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimatorType mode;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool recordOnStart;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string clipName;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float duration;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int rate;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool reduceKeys;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float threshold;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool playOnStart;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationClip animationClip;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RuntimeAnimatorController controller;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool setToKinematic;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool recorder;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float recordedTime;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int stateNameHash;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string assetFolder;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string clipFolder;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float stepTime;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Animator animator;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<Transform> tmList;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<RFCache> cacheList;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<float> timeList;

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x17A7C2C", Offset = "0x17A7C2C", VA = "0x17A7C2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x17A7F6C", Offset = "0x17A7F6C", VA = "0x17A7F6C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x17A7FD0", Offset = "0x17A7FD0", VA = "0x17A7FD0")]
	private void SetRigid()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x17A7C30", Offset = "0x17A7C30", VA = "0x17A7C30")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x17A8284", Offset = "0x17A8284", VA = "0x17A8284")]
	private void SetModeRecord()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x17A84A0", Offset = "0x17A84A0", VA = "0x17A84A0")]
	private void SetModePlay()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x17A8B90", Offset = "0x17A8B90", VA = "0x17A8B90")]
	private void Reset()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x17A81B4", Offset = "0x17A81B4", VA = "0x17A81B4")]
	public void StartRecord()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x17A8BD0", Offset = "0x17A8BD0", VA = "0x17A8BD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BDAC", Offset = "0xD1BDAC")]
	private IEnumerator RecordCor()
	{
		return null;
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x17A8C78", Offset = "0x17A8C78", VA = "0x17A8C78")]
	public void StopRecord()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x17A8228", Offset = "0x17A8228", VA = "0x17A8228")]
	public void StartPlay()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x17A8C80", Offset = "0x17A8C80", VA = "0x17A8C80")]
	public RayfireRecorder()
	{
	}
}
[Token(Token = "0x200005D")]
[SelectionBase]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD16820", Offset = "0xD16820")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD16820", Offset = "0xD16820")]
public class RayfireRestriction : MonoBehaviour
{
	[Token(Token = "0x20000B9")]
	public enum RFBoundActionType
	{
		[Token(Token = "0x400055A")]
		Fade = 2,
		[Token(Token = "0x400055B")]
		Reset = 4,
		[Token(Token = "0x400055C")]
		PostDemolitionAction = 9
	}

	[Token(Token = "0x20000BA")]
	public enum RFDistanceType
	{
		[Token(Token = "0x400055E")]
		InitializePosition = 0,
		[Token(Token = "0x400055F")]
		TargetPosition = 2
	}

	[Token(Token = "0x20000BB")]
	public enum RFBoundTriggerType
	{
		[Token(Token = "0x4000561")]
		Inside = 0,
		[Token(Token = "0x4000562")]
		Outside = 2
	}

	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16EF0", Offset = "0xD16EF0")]
	private sealed class <RestrictionDistanceCor>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <intervalDelay>5__2;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <actionDelay>5__3;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 <checkPosition>5__4;

		[Token(Token = "0x17000072")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x17A98F8", Offset = "0x17A98F8", VA = "0x17A98F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x17A9960", Offset = "0x17A9960", VA = "0x17A9960", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x17A9584", Offset = "0x17A9584", VA = "0x17A9584")]
		[DebuggerHidden]
		public <RestrictionDistanceCor>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x17A95DC", Offset = "0x17A95DC", VA = "0x17A95DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x17A95E0", Offset = "0x17A95E0", VA = "0x17A95E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x17A9900", Offset = "0x17A9900", VA = "0x17A9900", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16F00", Offset = "0xD16F00")]
	private sealed class <RestrictionTriggerCor>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <intervalDelay>5__2;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <actionDelay>5__3;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <brokeState>5__4;

		[Token(Token = "0x17000074")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x17A9D2C", Offset = "0x17A9D2C", VA = "0x17A9D2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x17A9D94", Offset = "0x17A9D94", VA = "0x17A9D94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x17A95B0", Offset = "0x17A95B0", VA = "0x17A95B0")]
		[DebuggerHidden]
		public <RestrictionTriggerCor>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x17A9968", Offset = "0x17A9968", VA = "0x17A9968", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x17A996C", Offset = "0x17A996C", VA = "0x17A996C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x17A9D34", Offset = "0x17A9D34", VA = "0x17A9D34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool enable;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RFBoundActionType breakAction;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float actionDelay;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float checkInterval;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float distance;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public RFDistanceType position;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform target;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Collider Collider;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFBoundTriggerType region;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool broke;

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x17A9090", Offset = "0x17A9090", VA = "0x17A9090")]
	public RayfireRestriction()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x17A9100", Offset = "0x17A9100", VA = "0x17A9100")]
	public void CopyFrom(RayfireRestriction rest)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x17A90F8", Offset = "0x17A90F8", VA = "0x17A90F8")]
	public void Reset()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x17A917C", Offset = "0x17A917C", VA = "0x17A917C")]
	public static void InitRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x17A9484", Offset = "0x17A9484", VA = "0x17A9484")]
	private static void BrokeRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x17A938C", Offset = "0x17A938C", VA = "0x17A938C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BE10", Offset = "0xD1BE10")]
	private static IEnumerator RestrictionDistanceCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x17A9408", Offset = "0x17A9408", VA = "0x17A9408")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BE74", Offset = "0xD1BE74")]
	private static IEnumerator RestrictionTriggerCor(RayfireRigid scr)
	{
		return null;
	}
}
[Token(Token = "0x200005E")]
[SelectionBase]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD168A0", Offset = "0xD168A0")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD168A0", Offset = "0xD168A0")]
public class RayfireRigid : MonoBehaviour
{
	[Token(Token = "0x20000BE")]
	public enum InitType
	{
		[Token(Token = "0x4000570")]
		ByMethod,
		[Token(Token = "0x4000571")]
		AtStart
	}

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A850", Offset = "0xD1A850")]
	public InitType initialization;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1A864", Offset = "0xD1A864")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A864", Offset = "0xD1A864")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD1A864", Offset = "0xD1A864")]
	public SimType simulationType;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A8D8", Offset = "0xD1A8D8")]
	public ObjectType objectType;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A8EC", Offset = "0xD1A8EC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD1A8EC", Offset = "0xD1A8EC")]
	public DemolitionType demolitionType;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1A93C", Offset = "0xD1A93C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A93C", Offset = "0xD1A93C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD1A93C", Offset = "0xD1A93C")]
	public RFPhysic physics;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1A9B0", Offset = "0xD1A9B0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD1A9B0", Offset = "0xD1A9B0")]
	public RFActivation activation;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1AA00", Offset = "0xD1AA00")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AA00", Offset = "0xD1AA00")]
	public RFLimitations limitations;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AA50", Offset = "0xD1AA50")]
	public RFDemolitionMesh meshDemolition;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AA64", Offset = "0xD1AA64")]
	public RFDemolitionCluster clusterDemolition;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AA78", Offset = "0xD1AA78")]
	public RFReferenceDemolition referenceDemolition;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AA8C", Offset = "0xD1AA8C")]
	public RFSurface materials;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AAA0", Offset = "0xD1AAA0")]
	public RFDamage damage;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1AAB4", Offset = "0xD1AAB4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AAB4", Offset = "0xD1AAB4")]
	public RFFade fading;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AB04", Offset = "0xD1AB04")]
	public RFReset reset;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1AB18", Offset = "0xD1AB18")]
	[HideInInspector]
	public bool initialized;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	[HideInInspector]
	public bool corState;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public Mesh[] meshes;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public Vector3[] pivots;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public RFMesh[] rfMeshes;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public List<RFDictionary> subIds;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public List<RayfireRigid> fragments;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	public Quaternion cacheRotation;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	public Transform transForm;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[HideInInspector]
	public Transform rootChild;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[HideInInspector]
	public Transform rootParent;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[HideInInspector]
	public MeshFilter meshFilter;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[HideInInspector]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[HideInInspector]
	public SkinnedMeshRenderer skinnedMeshRend;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[HideInInspector]
	public List<RayfireDebris> debrisList;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[HideInInspector]
	public List<RayfireDust> dustList;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[HideInInspector]
	public RayfireRestriction restriction;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[HideInInspector]
	public RayfireSound sound;

	[NonSerialized]
	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public RayfireRigidRoot rigidRoot;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public RFDemolitionEvent demolitionEvent;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public RFActivationEvent activationEvent;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public RFRestrictionEvent restrictionEvent;

	[Token(Token = "0x1700001B")]
	public bool HasFragments
	{
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x17A6164", Offset = "0x17A6164", VA = "0x17A6164")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001C")]
	public bool HasMeshes
	{
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x17ADC38", Offset = "0x17ADC38", VA = "0x17ADC38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001D")]
	public bool HasRfMeshes
	{
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x17ADC58", Offset = "0x17ADC58", VA = "0x17ADC58")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001E")]
	public bool HasDebris
	{
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x17ADC78", Offset = "0x17ADC78", VA = "0x17ADC78")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001F")]
	public bool HasDust
	{
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x17ADCD4", Offset = "0x17ADCD4", VA = "0x17ADCD4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public bool HasSlices
	{
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x17AD7D4", Offset = "0x17AD7D4", VA = "0x17AD7D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000021")]
	public bool IsCluster
	{
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x17ADD30", Offset = "0x17ADD30", VA = "0x17ADD30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000022")]
	public float AmountIntegrity
	{
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x17ADD44", Offset = "0x17ADD44", VA = "0x17ADD44")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x17A9D9C", Offset = "0x17A9D9C", VA = "0x17A9D9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x17A9E80", Offset = "0x17A9E80", VA = "0x17A9E80")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x17A9ECC", Offset = "0x17A9ECC", VA = "0x17A9ECC")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x17AABAC", Offset = "0x17AABAC", VA = "0x17AABAC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x17AAC0C", Offset = "0x17AAC0C", VA = "0x17AAC0C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x17AAC64", Offset = "0x17AAC64", VA = "0x17AAC64")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x17AAE38", Offset = "0x17AAE38", VA = "0x17AAE38")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x17AA07C", Offset = "0x17AA07C", VA = "0x17AA07C")]
	public void SetComponentsBasic()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x17AA6A0", Offset = "0x17AA6A0", VA = "0x17AA6A0")]
	private void SetComponentsPhysics()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x17AACFC", Offset = "0x17AACFC", VA = "0x17AACFC")]
	private void EditorSetupMeshRoot()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x17AA338", Offset = "0x17AA338", VA = "0x17AA338")]
	private bool SetupMeshRoot()
	{
		return default(bool);
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x17AB738", Offset = "0x17AB738", VA = "0x17AB738")]
	private void MeshRootCheck()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x17AB8F4", Offset = "0x17AB8F4", VA = "0x17AB8F4")]
	private void AddMeshRootRigid()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x17ABE14", Offset = "0x17ABE14", VA = "0x17ABE14")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x17AAED0", Offset = "0x17AAED0", VA = "0x17AAED0")]
	private void ResetMeshRootSetup()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x17AAA44", Offset = "0x17AAA44", VA = "0x17AAA44")]
	private void SetObjectType()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x17AA95C", Offset = "0x17AA95C", VA = "0x17AA95C")]
	public void Default()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x17ABF48", Offset = "0x17ABF48", VA = "0x17ABF48")]
	private void SetPhysics()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x17AAA8C", Offset = "0x17AAA8C", VA = "0x17AAA8C")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x17AC070", Offset = "0x17AC070", VA = "0x17AC070")]
	public void InactiveCors()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x17A9DD8", Offset = "0x17A9DD8", VA = "0x17A9DD8")]
	public void MeshInput()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x17AA844", Offset = "0x17AA844", VA = "0x17AA844")]
	private void AwakePrecache()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x17AA8CC", Offset = "0x17AA8CC", VA = "0x17AA8CC")]
	private void AwakePrefragment()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x17AC3D4", Offset = "0x17AC3D4", VA = "0x17AC3D4", Slot = "4")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x17AC484", Offset = "0x17AC484", VA = "0x17AC484", Slot = "5")]
	protected virtual bool CollisionDemolition(Collision collision)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x17AC764", Offset = "0x17AC764", VA = "0x17AC764")]
	public bool State()
	{
		return default(bool);
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x17AC8B8", Offset = "0x17AC8B8", VA = "0x17AC8B8", Slot = "6")]
	public virtual bool DemolitionState()
	{
		return default(bool);
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x17ACA44", Offset = "0x17ACA44", VA = "0x17ACA44")]
	public void Demolish()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x17A1994", Offset = "0x17A1994", VA = "0x17A1994")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x17AD2D0", Offset = "0x17AD2D0", VA = "0x17AD2D0")]
	public void InitMeshFragments()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x17AC170", Offset = "0x17AC170", VA = "0x17AC170")]
	private void Prefragment()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x17AD544", Offset = "0x17AD544", VA = "0x17AD544")]
	public void DeleteCache()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x17AD424", Offset = "0x17AD424", VA = "0x17AD424")]
	public void DeleteFragments()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x17AD5E4", Offset = "0x17AD5E4", VA = "0x17AD5E4")]
	public void AddSlicePlane(Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x17AD684", Offset = "0x17AD684", VA = "0x17AD684")]
	public void Slice()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x17AD83C", Offset = "0x17AD83C", VA = "0x17AD83C")]
	public void CacheFrames()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x17AD87C", Offset = "0x17AD87C", VA = "0x17AD87C")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0xD1BED8", Offset = "0xD1BED8")]
	public void SaveInitTransform()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x17A615C", Offset = "0x17A615C", VA = "0x17A615C")]
	public bool ApplyDamage(float damageValue, Vector3 damagePoint, float damageRadius = 0f)
	{
		return default(bool);
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x17A5EA8", Offset = "0x17A5EA8", VA = "0x17A5EA8")]
	public void Activate(bool connCheck = true)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x17A1BCC", Offset = "0x17A1BCC", VA = "0x17A1BCC")]
	public void Fade()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x17ADA90", Offset = "0x17ADA90", VA = "0x17ADA90")]
	public void ResetRigid()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x17ADA98", Offset = "0x17ADA98", VA = "0x17ADA98")]
	public void DestroyCollider(Collider col)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x17ADB00", Offset = "0x17ADB00", VA = "0x17ADB00")]
	public void DestroyObject(GameObject go)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x17ADB68", Offset = "0x17ADB68", VA = "0x17ADB68")]
	public void DestroyRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x17ADBD0", Offset = "0x17ADBD0", VA = "0x17ADBD0")]
	public void DestroyRb(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x17ADDD0", Offset = "0x17ADDD0", VA = "0x17ADDD0")]
	public RayfireRigid()
	{
	}
}
[Serializable]
[Token(Token = "0x200005F")]
public class RFRigidRootDemolition
{
	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AC74", Offset = "0xD1AC74")]
	public RFLimitations limitations;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AC88", Offset = "0xD1AC88")]
	public RFDemolitionCluster clusterDemolition;

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x19B6A54", Offset = "0x19B6A54", VA = "0x19B6A54")]
	public RFRigidRootDemolition()
	{
	}
}
[Token(Token = "0x2000060")]
[SelectionBase]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD16920", Offset = "0xD16920")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD16920", Offset = "0xD16920")]
public class RayfireRigidRoot : MonoBehaviour
{
	[Token(Token = "0x20000BF")]
	public enum InitType
	{
		[Token(Token = "0x4000573")]
		ByMethod,
		[Token(Token = "0x4000574")]
		AtStart
	}

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AC9C", Offset = "0xD1AC9C")]
	public InitType initialization;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1ACB0", Offset = "0xD1ACB0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1ACB0", Offset = "0xD1ACB0")]
	public SimType simulationType;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AD00", Offset = "0xD1AD00")]
	public RFPhysic physics;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AD14", Offset = "0xD1AD14")]
	public RFActivation activation;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AD28", Offset = "0xD1AD28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1AD28", Offset = "0xD1AD28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AD28", Offset = "0xD1AD28")]
	public RFRigidRootDemolition demolition;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD1AD8C", Offset = "0xD1AD8C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1AD8C", Offset = "0xD1AD8C")]
	public RFFade fading;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD1ADDC", Offset = "0xD1ADDC")]
	public RFReset reset;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public Transform tm;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public RayfireSound sound;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public RFCluster cluster;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public List<RayfireRigid> meshRoots;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public bool initialized;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	[HideInInspector]
	public bool cached;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[HideInInspector]
	public float sizeBox;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public float sizeSum;

	[NonSerialized]
	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<RFCluster> clusters;

	[NonSerialized]
	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<RFShard> inactiveShards;

	[NonSerialized]
	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<RFShard> offsetFadeShards;

	[NonSerialized]
	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<RFShard> destroyShards;

	[NonSerialized]
	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<RFShard> meshRigidShards;

	[NonSerialized]
	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<RFShard> meshRootShards;

	[NonSerialized]
	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<RFShard> rigidRootShards;

	[NonSerialized]
	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<Transform> parentList;

	[NonSerialized]
	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<RayfireDebris> debrisList;

	[NonSerialized]
	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<RayfireDust> dustList;

	[NonSerialized]
	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<RayfireUnyielding> unyList;

	[NonSerialized]
	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public List<Transform> particleList;

	[NonSerialized]
	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public bool corState;

	[NonSerialized]
	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public HashSet<Collider> collidersHash;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string strRoot;

	[Token(Token = "0x17000023")]
	public bool HasClusters
	{
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x17B0E08", Offset = "0x17B0E08", VA = "0x17B0E08")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000024")]
	public bool HasDebris
	{
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x17B0E64", Offset = "0x17B0E64", VA = "0x17B0E64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000025")]
	public bool HasDust
	{
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x17B0EC0", Offset = "0x17B0EC0", VA = "0x17B0EC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000026")]
	public bool HasUny
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x17B0888", Offset = "0x17B0888", VA = "0x17B0888")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x17AE054", Offset = "0x17AE054", VA = "0x17AE054")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x17AE104", Offset = "0x17AE104", VA = "0x17AE104")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x17AE134", Offset = "0x17AE134", VA = "0x17AE134")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x17AE090", Offset = "0x17AE090", VA = "0x17AE090")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x17AE43C", Offset = "0x17AE43C", VA = "0x17AE43C")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x17AE658", Offset = "0x17AE658", VA = "0x17AE658")]
	public void ResetRigidRoot()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x17AE660", Offset = "0x17AE660", VA = "0x17AE660")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x17AE800", Offset = "0x17AE800", VA = "0x17AE800")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x17AE298", Offset = "0x17AE298", VA = "0x17AE298")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x17AE9E4", Offset = "0x17AE9E4", VA = "0x17AE9E4")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x17AF7D0", Offset = "0x17AF7D0", VA = "0x17AF7D0")]
	private bool MeshRootCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x17AEB14", Offset = "0x17AEB14", VA = "0x17AEB14")]
	private void SetShards()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x17AFD08", Offset = "0x17AFD08", VA = "0x17AFD08")]
	private void SetCustomShardsLists()
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x17AFF6C", Offset = "0x17AFF6C", VA = "0x17AFF6C")]
	private void SetShardsSimulationType()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x17B015C", Offset = "0x17B015C", VA = "0x17B015C")]
	private void SetParentList()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x17B0264", Offset = "0x17B0264", VA = "0x17B0264")]
	private void AddShard(Transform shardTm, [Optional] RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x17B0364", Offset = "0x17B0364", VA = "0x17B0364")]
	private void AddShardWithRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x17AF3A4", Offset = "0x17AF3A4", VA = "0x17AF3A4")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x17AF944", Offset = "0x17AF944", VA = "0x17AF944")]
	private void SetCollidersMaterial()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x17AFB48", Offset = "0x17AFB48", VA = "0x17AFB48")]
	public void SetInactiveList()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x17AF518", Offset = "0x17AF518", VA = "0x17AF518")]
	private void SetUnyielding()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x17AE18C", Offset = "0x17AE18C", VA = "0x17AE18C")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x17A18C4", Offset = "0x17A18C4", VA = "0x17A18C4")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x17B0D88", Offset = "0x17B0D88", VA = "0x17B0D88")]
	private static bool IsNestedCluster(Transform trans)
	{
		return default(bool);
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x17B0414", Offset = "0x17B0414", VA = "0x17B0414")]
	private static bool ShardFilter(RFShard shard, RayfireRigidRoot scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x17B0F1C", Offset = "0x17B0F1C", VA = "0x17B0F1C")]
	public void CollideTest()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x17B0F28", Offset = "0x17B0F28", VA = "0x17B0F28")]
	public RayfireRigidRoot()
	{
	}
}
[Token(Token = "0x2000061")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD169A0", Offset = "0xD169A0")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD169A0", Offset = "0xD169A0")]
public class RayfireShatter : MonoBehaviour
{
	[Token(Token = "0x20000C0")]
	public enum FragLastMode
	{
		[Token(Token = "0x4000576")]
		New,
		[Token(Token = "0x4000577")]
		ToLast
	}

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FragType type;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFVoronoi voronoi;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFSplinters splinters;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFSplinters slabs;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFRadial radial;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFCustom custom;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFMirrored mirrored;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFSlice slice;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFBricks bricks;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFVoxels voxels;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFTets tets;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public FragmentMode mode;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RFSurface material;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public RFShatterCluster clusters;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public RFShatterAdvanced advanced;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RFMeshExport export;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool showCenter;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public Vector3 centerPosition;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Quaternion centerDirection;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform transForm;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public MeshFilter meshFilter;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public SkinnedMeshRenderer skinnedMeshRend;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<MeshFilter> meshFilters;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Mesh[] meshes;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Vector3[] pivots;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<Transform> rootChildList;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public List<GameObject> fragmentsAll;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public List<GameObject> fragmentsLast;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public List<RFDictionary> origSubMeshIdsRF;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Material[] materials;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public int shatterMode;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public bool colorPreview;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
	public bool scalePreview;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public float previewScale;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public float size;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float rescaleFix;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public Vector3 originalScale;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[HideInInspector]
	public Bounds bound;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[HideInInspector]
	public bool resetState;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float minSize;

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x17B10B0", Offset = "0x17B10B0", VA = "0x17B10B0")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x17B1218", Offset = "0x17B1218", VA = "0x17B1218")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x17B12B8", Offset = "0x17B12B8", VA = "0x17B12B8")]
	private bool MainCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x17B16F4", Offset = "0x17B16F4", VA = "0x17B16F4")]
	private bool SingleMeshCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x17B1958", Offset = "0x17B1958", VA = "0x17B1958")]
	private bool DefineComponents()
	{
		return default(bool);
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x17B1BF8", Offset = "0x17B1BF8", VA = "0x17B1BF8")]
	public Bounds GetBound()
	{
		return default(Bounds);
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x17B1D94", Offset = "0x17B1D94", VA = "0x17B1D94")]
	public void Fragment(FragLastMode fragmentMode = FragLastMode.New)
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x17B21FC", Offset = "0x17B21FC", VA = "0x17B21FC")]
	private List<GameObject> CreateFragments([Optional] GameObject lastRoot)
	{
		return null;
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x17B2D1C", Offset = "0x17B2D1C", VA = "0x17B2D1C")]
	public void DeleteFragmentsLast(int destroyMode = 0)
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x17B30CC", Offset = "0x17B30CC", VA = "0x17B30CC")]
	public void DeleteFragmentsAll()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x17B10B4", Offset = "0x17B10B4", VA = "0x17B10B4")]
	public void ResetCenter()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x17B1F68", Offset = "0x17B1F68", VA = "0x17B1F68")]
	private void ScaleCheck()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x17B3230", Offset = "0x17B3230", VA = "0x17B3230")]
	public void ResetScale(float scaleValue)
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x17ABBD8", Offset = "0x17ABBD8", VA = "0x17ABBD8")]
	public static void CopyRootMeshShatter(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x17B3484", Offset = "0x17B3484", VA = "0x17B3484")]
	private void CopyFrom(RayfireShatter shatter)
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x17B2B38", Offset = "0x17B2B38", VA = "0x17B2B38")]
	private void VertexLimitation()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x17B36CC", Offset = "0x17B36CC", VA = "0x17B36CC")]
	public RayfireShatter()
	{
	}
}
[Token(Token = "0x2000062")]
[SelectionBase]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD16A00", Offset = "0xD16A00")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD16A00", Offset = "0xD16A00")]
public class RayfireSnapshot : MonoBehaviour
{
	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string assetName;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool compress;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnityEngine.Object snapshotAsset;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sizeFilter;

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x17B3AB4", Offset = "0x17B3AB4", VA = "0x17B3AB4")]
	private void Reset()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x17B3AF4", Offset = "0x17B3AF4", VA = "0x17B3AF4")]
	public RayfireSnapshot()
	{
	}
}
[Token(Token = "0x2000063")]
[SelectionBase]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD16A80", Offset = "0xD16A80")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD16A80", Offset = "0xD16A80")]
public class RayfireSound : MonoBehaviour
{
	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float baseVolume;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sizeVolume;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFSound initialization;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFSound activation;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFSound demolition;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float minimumSize;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float cameraDistance;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RayfireRigid rigid;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RayfireRigidRoot rigidRoot;

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x17B3AFC", Offset = "0x17B3AFC", VA = "0x17B3AFC")]
	public RayfireSound()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x17AB2E0", Offset = "0x17AB2E0", VA = "0x17AB2E0")]
	public void WarningCheck()
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x17B3B30", Offset = "0x17B3B30", VA = "0x17B3B30")]
	public void CopyFrom(RayfireSound source)
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x17B3C38", Offset = "0x17B3C38", VA = "0x17B3C38")]
	private void CreateSource(RayfireRigid scr)
	{
	}
}
[Token(Token = "0x2000064")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD16AF0", Offset = "0xD16AF0")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD16AF0", Offset = "0xD16AF0")]
public class RayfireUnyielding : MonoBehaviour
{
	[Token(Token = "0x20000C1")]
	public enum UnySimType
	{
		[Token(Token = "0x4000579")]
		Original = 1,
		[Token(Token = "0x400057A")]
		Inactive,
		[Token(Token = "0x400057B")]
		Kinematic
	}

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool unyielding;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool activatable;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UnySimType simulationType;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 centerPosition;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 size;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RayfireRigid rigidHost;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<RayfireRigid> rigidList;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<RFShard> shardList;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool showGizmo;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool showCenter;

	[Token(Token = "0x17000027")]
	private bool HasRigids
	{
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x17B544C", Offset = "0x17B544C", VA = "0x17B544C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000028")]
	private bool HasShards
	{
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x17B54A8", Offset = "0x17B54A8", VA = "0x17B54A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000029")]
	public Vector3 Extents
	{
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x17B43D0", Offset = "0x17B43D0", VA = "0x17B43D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x17B3E78", Offset = "0x17B3E78", VA = "0x17B3E78")]
	public static void ClusterSetup(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x17B3F74", Offset = "0x17B3F74", VA = "0x17B3F74")]
	private static void ClusterOverlap(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x17B4278", Offset = "0x17B4278", VA = "0x17B4278")]
	private static int ClusterLayerMask(RayfireRigid rigid)
	{
		return default(int);
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x17B44DC", Offset = "0x17B44DC", VA = "0x17B44DC")]
	private static void SetShardUnyState(RFShard shard, bool unyielding, bool activatable)
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x17ABD58", Offset = "0x17ABD58", VA = "0x17ABD58")]
	public static void MeshRootSetup(RayfireRigid mRoot)
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x17B4500", Offset = "0x17B4500", VA = "0x17B4500")]
	private static List<RayfireUnyielding> GetUnyList(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x17B45E8", Offset = "0x17B45E8", VA = "0x17B45E8")]
	private static void SetMeshRootUnyRigidList(RayfireRigid mRoot, RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x17B498C", Offset = "0x17B498C", VA = "0x17B498C")]
	private static int MeshRootLayerMask(RayfireRigid mRoot)
	{
		return default(int);
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x17B488C", Offset = "0x17B488C", VA = "0x17B488C")]
	public static void SetMeshRootUny(Transform tm, List<RayfireUnyielding> unyList)
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x17B4AC8", Offset = "0x17B4AC8", VA = "0x17B4AC8")]
	private static void SetRigidUnyState(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x17B4D3C", Offset = "0x17B4D3C", VA = "0x17B4D3C")]
	private static void SetRigidUnySim(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x17ACC40", Offset = "0x17ACC40", VA = "0x17ACC40")]
	public static void SetUnyieldingFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x17B4F08", Offset = "0x17B4F08", VA = "0x17B4F08")]
	private static void SetRigidUnyState(RayfireRigid rigid, bool uny, bool act)
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x17B4F94", Offset = "0x17B4F94", VA = "0x17B4F94")]
	private static void CopyUny(RayfireUnyielding source, GameObject target)
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x17B08E4", Offset = "0x17B08E4", VA = "0x17B08E4")]
	public void GetRigidRootUnyShardList(RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x17B0C68", Offset = "0x17B0C68", VA = "0x17B0C68")]
	public void SetRigidRootUnyShardList()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x17B5110", Offset = "0x17B5110", VA = "0x17B5110")]
	public void Activate()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x17B5504", Offset = "0x17B5504", VA = "0x17B5504")]
	public RayfireUnyielding()
	{
	}
}
[Token(Token = "0x2000065")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD16B50", Offset = "0xD16B50")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD16B50", Offset = "0xD16B50")]
public class RayfireVortex : MonoBehaviour
{
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16F10", Offset = "0xD16F10")]
	private sealed class <VortexForceCor>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireVortex <>4__this;

		[Token(Token = "0x17000076")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x27CE3A0", Offset = "0x27CE3A0", VA = "0x27CE3A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x27CE408", Offset = "0x27CE408", VA = "0x27CE408", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x27CE240", Offset = "0x27CE240", VA = "0x27CE240")]
		[DebuggerHidden]
		public <VortexForceCor>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x27CE26C", Offset = "0x27CE26C", VA = "0x27CE26C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x27CE270", Offset = "0x27CE270", VA = "0x27CE270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x27CE3A8", Offset = "0x27CE3A8", VA = "0x27CE3A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16F20", Offset = "0xD16F20")]
	private sealed class <SetCollidersCor>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireVortex <>4__this;

		[Token(Token = "0x17000078")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x27CE1D0", Offset = "0x27CE1D0", VA = "0x27CE1D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x27CE238", Offset = "0x27CE238", VA = "0x27CE238", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x27CE054", Offset = "0x27CE054", VA = "0x27CE054")]
		[DebuggerHidden]
		public <SetCollidersCor>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x27CE080", Offset = "0x27CE080", VA = "0x27CE080", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x27CE084", Offset = "0x27CE084", VA = "0x27CE084", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x27CE1D8", Offset = "0x27CE1D8", VA = "0x27CE1D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Transform transForm;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Collider[] colliders;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 bot;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 top;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 normal;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 direction;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 rbPos;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 linePoint;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 vectorUp;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 centerOutVector;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 vectorCenter;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 perpend;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3 vectorSwirl;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private Vector3 forceVector;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float distancePerpend;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float distanceBottom;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float upRateNow;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float localRadius;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float upRateOwn;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private float centerRateOwn;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float centerRateNow;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float upRateDif;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float centerRateDif;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float maxRadius;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float axisDistance;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private Plane bottomPlane;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private float torqueVal;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool topHandle;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public Vector3 topAnchor;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Vector3 bottomAnchor;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public bool showGizmo;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public float topRadius;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public float bottomRadius;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float eye;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public bool forceByMass;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public float stiffness;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public float swirlStrength;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public bool enableTorque;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public float torqueStrength;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public float torqueVariation;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public bool enableHeightBias;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public float biasSpeed;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	public float biasSpread;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public int seed;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public int circles;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public int mask;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public string tagFilter;

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x17B5574", Offset = "0x17B5574", VA = "0x17B5574")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x17B5578", Offset = "0x17B5578", VA = "0x17B5578")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x17B55FC", Offset = "0x17B55FC", VA = "0x17B55FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BF10", Offset = "0xD1BF10")]
	private IEnumerator VortexForceCor()
	{
		return null;
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x17B5678", Offset = "0x17B5678", VA = "0x17B5678")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BF74", Offset = "0xD1BF74")]
	private IEnumerator SetCollidersCor()
	{
		return null;
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x17B56F4", Offset = "0x17B56F4", VA = "0x17B56F4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x17B5738", Offset = "0x17B5738", VA = "0x17B5738")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x17B586C", Offset = "0x17B586C", VA = "0x17B586C")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x17B59EC", Offset = "0x17B59EC", VA = "0x17B59EC")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x17B5BB0", Offset = "0x17B5BB0", VA = "0x17B5BB0")]
	private void SetForce()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x17B61FC", Offset = "0x17B61FC", VA = "0x17B61FC")]
	private Vector3 GetClosetLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x17B63E8", Offset = "0x17B63E8", VA = "0x17B63E8")]
	private Vector3 GetParallelLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x17B64B0", Offset = "0x17B64B0", VA = "0x17B64B0")]
	public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
	{
		return default(bool);
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x17B6634", Offset = "0x17B6634", VA = "0x17B6634")]
	private static Vector3 SetVectorLength(Vector3 vector, float size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x17B62C4", Offset = "0x17B62C4", VA = "0x17B62C4")]
	private float HeightBias(float upRateOwnLoc, float centerRateOwnLoc)
	{
		return default(float);
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x17B66CC", Offset = "0x17B66CC", VA = "0x17B66CC")]
	public RayfireVortex()
	{
	}
}
[Token(Token = "0x2000066")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD16BB0", Offset = "0xD16BB0")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD16BB0", Offset = "0xD16BB0")]
public class RayfireWind : MonoBehaviour
{
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD16F30", Offset = "0xD16F30")]
	private sealed class <WindForceCor>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireWind <>4__this;

		[Token(Token = "0x1700007A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x27CF334", Offset = "0x27CF334", VA = "0x27CF334", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x27CF39C", Offset = "0x27CF39C", VA = "0x27CF39C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x27CE514", Offset = "0x27CE514", VA = "0x27CE514")]
		[DebuggerHidden]
		public <WindForceCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x27CF264", Offset = "0x27CF264", VA = "0x27CF264", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x27CF268", Offset = "0x27CF268", VA = "0x27CF268", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x27CF33C", Offset = "0x27CF33C", VA = "0x27CF33C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 gizmoSize;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool showGizmo;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float globalScale;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float lengthScale;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float widthScale;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float speed;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool showNoise;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float minimum;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float maximum;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float torque;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool forceByMass;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float divergency;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float turbulence;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float previewDensity;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float previewSize;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int mask;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string tagFilter;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform transForm;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Collider[] colliders;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 halfExtents;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 center;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float offset;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x27CE410", Offset = "0x27CE410", VA = "0x27CE410")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x27CE414", Offset = "0x27CE414", VA = "0x27CE414")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x27CE498", Offset = "0x27CE498", VA = "0x27CE498")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD1BFD8", Offset = "0xD1BFD8")]
	private IEnumerator WindForceCor()
	{
		return null;
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x27CE540", Offset = "0x27CE540", VA = "0x27CE540")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x27CE56C", Offset = "0x27CE56C", VA = "0x27CE56C")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x27CE578", Offset = "0x27CE578", VA = "0x27CE578")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x27CE758", Offset = "0x27CE758", VA = "0x27CE758")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x27CE814", Offset = "0x27CE814", VA = "0x27CE814")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x27CE9E0", Offset = "0x27CE9E0", VA = "0x27CE9E0")]
	private void SetForce()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x27CEDB4", Offset = "0x27CEDB4", VA = "0x27CEDB4")]
	private Vector3 GetVectorGlobal(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x27CEDE8", Offset = "0x27CEDE8", VA = "0x27CEDE8")]
	public Vector3 GetVectorLocal(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x27CECF8", Offset = "0x27CECF8", VA = "0x27CECF8")]
	private float PerlinFixedGlobal(Vector3 worldPos)
	{
		return default(float);
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x27CF028", Offset = "0x27CF028", VA = "0x27CF028")]
	public float PerlinFixedLocal(Vector3 localPos)
	{
		return default(float);
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x27CF0EC", Offset = "0x27CF0EC", VA = "0x27CF0EC")]
	public float PerlinCustomGlobal(Vector3 worldPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x27CEF5C", Offset = "0x27CEF5C", VA = "0x27CEF5C")]
	public float PerlinCustomLocal(Vector3 localPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x27CED2C", Offset = "0x27CED2C", VA = "0x27CED2C")]
	public float WindStrength(float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x27CECB0", Offset = "0x27CECB0", VA = "0x27CECB0")]
	private void SetSpeed()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x27CF158", Offset = "0x27CF158", VA = "0x27CF158")]
	public RayfireWind()
	{
	}
}
