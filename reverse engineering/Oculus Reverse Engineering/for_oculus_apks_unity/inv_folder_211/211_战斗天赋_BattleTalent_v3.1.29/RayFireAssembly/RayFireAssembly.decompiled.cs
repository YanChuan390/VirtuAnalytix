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

[Token(Token = "0x2000002")]
public class RFFace
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float area;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector3 normal;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x31705AC", Offset = "0x31705AC", VA = "0x31705AC")]
	private RFFace(float Area, Vector3 Normal)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x31705F8", Offset = "0x31705F8", VA = "0x31705F8")]
	public static void SetPolys(RFShard shard)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x3170940", Offset = "0x3170940", VA = "0x3170940")]
	public static void Clear(RFShard shard)
	{
	}
}
[Token(Token = "0x2000003")]
public class RFTriangle
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float area;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 normal;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 pos;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<int> neibs;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int[] triangles;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Vector3[] vertices;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Vector3[] normals;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x367EA6C", Offset = "0x367EA6C", VA = "0x367EA6C")]
	private RFTriangle(float Area, Vector3 Normal, Vector3 Pos)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x3675AD0", Offset = "0x3675AD0", VA = "0x3675AD0")]
	public static void SetTriangles(RFShard shard)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x3677294", Offset = "0x3677294", VA = "0x3677294")]
	public static void Clear(RFShard shard)
	{
	}
}
[Serializable]
[Token(Token = "0x2000004")]
public class RFManDemolition
{
	[Token(Token = "0x200006C")]
	public enum FragmentParentType
	{
		[Token(Token = "0x400049A")]
		Manager,
		[Token(Token = "0x400049B")]
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

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x317DA88", Offset = "0x317DA88", VA = "0x317DA88")]
	public void ChangeCurrentAmount(int am)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x317DAA8", Offset = "0x317DAA8", VA = "0x317DAA8")]
	public void AmountWarning()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x317DB14", Offset = "0x317DB14", VA = "0x317DB14")]
	public void ResetCurrentAmount()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x317DB1C", Offset = "0x317DB1C", VA = "0x317DB1C")]
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
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x317DBD0", Offset = "0x317DBD0", VA = "0x317DBD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x317DB3C", Offset = "0x317DB3C", VA = "0x317DB3C")]
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

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x317DC88", Offset = "0x317DC88", VA = "0x317DC88")]
	public RFMaterialPresets()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x317E178", Offset = "0x317E178", VA = "0x317E178")]
	public void SetMaterials()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x317E548", Offset = "0x317E548", VA = "0x317E548")]
	public float Density(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x317E5F8", Offset = "0x317E5F8", VA = "0x317E5F8")]
	public float Drag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x317E6A8", Offset = "0x317E6A8", VA = "0x317E6A8")]
	public float AngularDrag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x317E75C", Offset = "0x317E75C", VA = "0x317E75C")]
	public int Solidity(MaterialType materialType)
	{
		return default(int);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x317E80C", Offset = "0x317E80C", VA = "0x317E80C")]
	public bool Destructible(MaterialType materialType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x317E8C4", Offset = "0x317E8C4", VA = "0x317E8C4")]
	public static PhysicMaterial Material(MaterialType materialType)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class RFPoolingParticles
{
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE8F7C", Offset = "0x1DE8F7C")]
	private sealed class <StartPoolingCor>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFPoolingParticles <>4__this;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform manTm;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x3670884", Offset = "0x3670884", VA = "0x3670884", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x36708EC", Offset = "0x36708EC", VA = "0x36708EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x36706EC", Offset = "0x36706EC", VA = "0x36706EC")]
		[DebuggerHidden]
		public <StartPoolingCor>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x3670718", Offset = "0x3670718", VA = "0x3670718", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x367071C", Offset = "0x367071C", VA = "0x367071C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x367088C", Offset = "0x367088C", VA = "0x367088C", Slot = "8")]
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
	public int capacity;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool inProgress;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int rate;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<ParticleSystem> list;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem inst;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform root;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject host;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ParticleSystem ps;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x3670144", Offset = "0x3670144", VA = "0x3670144")]
	public RFPoolingParticles()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x36701D8", Offset = "0x36701D8", VA = "0x36701D8")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x36702EC", Offset = "0x36702EC", VA = "0x36702EC")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x3670420", Offset = "0x3670420", VA = "0x3670420")]
	public ParticleSystem CreateParticleInstance()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x36704F8", Offset = "0x36704F8", VA = "0x36704F8")]
	public ParticleSystem GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x3670594", Offset = "0x3670594", VA = "0x3670594")]
	private ParticleSystem CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x3670654", Offset = "0x3670654", VA = "0x3670654")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA1D4", Offset = "0x1DEA1D4")]
	public IEnumerator StartPoolingCor(Transform manTm)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class RFPoolingFragment
{
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE8F8C", Offset = "0x1DE8F8C")]
	private sealed class <StartPoolingCor>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFPoolingFragment <>4__this;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform manTm;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x36700D4", Offset = "0x36700D4", VA = "0x36700D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x367013C", Offset = "0x367013C", VA = "0x367013C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x366FF40", Offset = "0x366FF40", VA = "0x366FF40")]
		[DebuggerHidden]
		public <StartPoolingCor>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x366FF6C", Offset = "0x366FF6C", VA = "0x366FF6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x366FF70", Offset = "0x366FF70", VA = "0x366FF70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x36700DC", Offset = "0x36700DC", VA = "0x36700DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int capacity;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool inProgress;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<RayfireRigid> list;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rate;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RayfireRigid inst;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform root;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject go;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MeshFilter mf;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer mr;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private RayfireRigid rg;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Rigidbody rb;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x366F844", Offset = "0x366F844", VA = "0x366F844")]
	public RFPoolingFragment()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x366F8D8", Offset = "0x366F8D8", VA = "0x366F8D8")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x366F9EC", Offset = "0x366F9EC", VA = "0x366F9EC")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x366FB0C", Offset = "0x366FB0C", VA = "0x366FB0C")]
	public RayfireRigid CreateRigidInstance()
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x366FD50", Offset = "0x366FD50", VA = "0x366FD50")]
	public RayfireRigid GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x366FDE8", Offset = "0x366FDE8", VA = "0x366FDE8")]
	private RayfireRigid CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x366FEA8", Offset = "0x366FEA8", VA = "0x366FEA8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA238", Offset = "0x1DEA238")]
	public IEnumerator StartPoolingCor(Transform manTm)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000009")]
public class RFStorage
{
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE8F9C", Offset = "0x1DE8F9C")]
	private sealed class <StorageCor>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFStorage <>4__this;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x367ACC8", Offset = "0x367ACC8", VA = "0x367ACC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x367AD30", Offset = "0x367AD30", VA = "0x367AD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x367A860", Offset = "0x367A860", VA = "0x367A860")]
		[DebuggerHidden]
		public <StorageCor>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x367AA58", Offset = "0x367AA58", VA = "0x367AA58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x367AA5C", Offset = "0x367AA5C", VA = "0x367AA5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x367ACD0", Offset = "0x367ACD0", VA = "0x367ACD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Transform> storageList;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform storageRoot;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool inProgress;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float rate;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x367A630", Offset = "0x367A630", VA = "0x367A630")]
	public RFStorage()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x367A6B4", Offset = "0x367A6B4", VA = "0x367A6B4")]
	public void CreateStorageRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x367A7E4", Offset = "0x367A7E4", VA = "0x367A7E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA29C", Offset = "0x1DEA29C")]
	public IEnumerator StorageCor()
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x367A88C", Offset = "0x367A88C", VA = "0x367A88C")]
	public void Register(Transform tm)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x367A91C", Offset = "0x367A91C", VA = "0x367A91C")]
	public void DestroyAll()
	{
	}
}
[Serializable]
[Token(Token = "0x200000A")]
public class RFCluster : IComparable<RFCluster>
{
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform tm;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int depth;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 pos;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Quaternion rot;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 scl;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Bounds bound;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool demolishable;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RayfireRigid rigid;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<RFShard> shards;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float areaCollapse;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float minimumArea;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float maximumArea;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float sizeCollapse;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float minimumSize;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float maximumSize;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int randomCollapse;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool cachedHost;

	[NonSerialized]
	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool initialized;

	[NonSerialized]
	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public RFCluster mainCluster;

	[NonSerialized]
	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<RFCluster> childClusters;

	[NonSerialized]
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<RFCluster> neibClusters;

	[NonSerialized]
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<float> neibArea;

	[NonSerialized]
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<float> neibPerc;

	[NonSerialized]
	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private List<RFShard> checkShards;

	[NonSerialized]
	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private List<RFShard> newClusterShards;

	[Token(Token = "0x17000002")]
	public bool HasChildClusters
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x36BE7DC", Offset = "0x36BE7DC", VA = "0x36BE7DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000003")]
	public bool UnyieldingByShard
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x36C2224", Offset = "0x36C2224", VA = "0x36C2224")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000004")]
	public bool UnyieldingByRigid
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x36C22C8", Offset = "0x36C22C8", VA = "0x36C22C8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x36BF730", Offset = "0x36BF730", VA = "0x36BF730")]
	public RFCluster()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x36BCB0C", Offset = "0x36BCB0C", VA = "0x36BCB0C")]
	public RFCluster(RFCluster source)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x36BF860", Offset = "0x36BF860", VA = "0x36BF860", Slot = "4")]
	public int CompareTo(RFCluster otherCluster)
	{
		return default(int);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x36BCE18", Offset = "0x36BCE18", VA = "0x36BCE18")]
	public static void InitCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x36BF8E4", Offset = "0x36BF8E4", VA = "0x36BF8E4")]
	private static void InitConnectedCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x36BFB10", Offset = "0x36BFB10", VA = "0x36BFB10")]
	private static void InitNestedCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x36BFD28", Offset = "0x36BFD28", VA = "0x36BFD28")]
	public static void ConnectivityUnyCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x36C0520", Offset = "0x36C0520", VA = "0x36C0520")]
	public static void ConnectivityCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x36C0294", Offset = "0x36C0294", VA = "0x36C0294")]
	public static void NewClusterByShards(RFCluster mainCLuster, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x36C0A78", Offset = "0x36C0A78", VA = "0x36C0A78")]
	public void AddChildCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x36C03F8", Offset = "0x36C03F8", VA = "0x36C03F8")]
	public static void ReduceChildClusters(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x36C0C10", Offset = "0x36C0C10", VA = "0x36C0C10")]
	public static Bounds GetChildrenBound(Transform tm)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x36C12FC", Offset = "0x36C12FC", VA = "0x36C12FC")]
	public static Bounds GetClusterBound(RFCluster cluster)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x36C0D4C", Offset = "0x36C0D4C", VA = "0x36C0D4C")]
	public static Bounds GetBoundsBound(List<Bounds> bounds)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x36C148C", Offset = "0x36C148C", VA = "0x36C148C")]
	public static Bounds GetShardsBound(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x36C1978", Offset = "0x36C1978", VA = "0x36C1978")]
	public static Bounds GetShardsBoundByPosition(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x36C0B1C", Offset = "0x36C0B1C", VA = "0x36C0B1C")]
	public static int GetBiggestCluster(List<RFCluster> clusters)
	{
		return default(int);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x36C1EB8", Offset = "0x36C1EB8", VA = "0x36C1EB8")]
	public static void GetSoloShards(RFCluster cluster, List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x36C09A0", Offset = "0x36C09A0", VA = "0x36C09A0")]
	public static int GetUniqClusterId(RFCluster cluster)
	{
		return default(int);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x36C2008", Offset = "0x36C2008", VA = "0x36C2008")]
	public static bool IntegrityCheck(RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x36C20EC", Offset = "0x36C20EC", VA = "0x36C20EC")]
	public static void CreateClusterRoot(RFCluster cluster, Vector3 pos, Quaternion rot, int layer, string tag, string nm)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x36C237C", Offset = "0x36C237C", VA = "0x36C237C")]
	private List<RFShard> GetNestedShards(bool OwnShards = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x36C24E0", Offset = "0x36C24E0", VA = "0x36C24E0")]
	public List<RFCluster> GetNestedClusters()
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x36C25EC", Offset = "0x36C25EC", VA = "0x36C25EC")]
	private bool TrisNeib(RFCluster otherCluster)
	{
		return default(bool);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x36C292C", Offset = "0x36C292C", VA = "0x36C292C")]
	private float NeibArea(RFCluster otherCluster)
	{
		return default(float);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x36C2C74", Offset = "0x36C2C74", VA = "0x36C2C74")]
	public int GetNeibIndArea([Optional] List<RFCluster> clusterList)
	{
		return default(int);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x36C2DA0", Offset = "0x36C2DA0", VA = "0x36C2DA0")]
	public static void SetClusterNeib(List<RFCluster> clusters, bool connectivity)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x36C34D4", Offset = "0x36C34D4", VA = "0x36C34D4")]
	public static RFCluster GetNeibClusterArea(List<RFCluster> clusters, List<RFCluster> clusterList)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x36C3838", Offset = "0x36C3838", VA = "0x36C3838")]
	public static float GetClusterMass(RFCluster cluster)
	{
		return default(float);
	}
}
[Token(Token = "0x200000B")]
public class RFEvent
{
	[Token(Token = "0x2000070")]
	public delegate void EventAction(RayfireRigid rigid);

	[Token(Token = "0x2000071")]
	public delegate void EventActionMeshRoot(RayfireRigid rigid, RayfireRigid meshRoot);

	[Token(Token = "0x2000072")]
	public delegate void EventActionRoot(RFShard shard, RayfireRigidRoot root);

	[Token(Token = "0x14000001")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x316EE4C", Offset = "0x316EE4C", VA = "0x316EE4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA300", Offset = "0x1DEA300")]
		add
		{
		}
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x316EEF0", Offset = "0x316EEF0", VA = "0x316EEF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA310", Offset = "0x1DEA310")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event EventActionMeshRoot LocalEventMeshRoot
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x316EF94", Offset = "0x316EF94", VA = "0x316EF94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA320", Offset = "0x1DEA320")]
		add
		{
		}
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x316F038", Offset = "0x316F038", VA = "0x316F038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA330", Offset = "0x1DEA330")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event EventActionRoot LocalEventRoot
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x316F0DC", Offset = "0x316F0DC", VA = "0x316F0DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA340", Offset = "0x1DEA340")]
		add
		{
		}
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x316F180", Offset = "0x316F180", VA = "0x316F180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA350", Offset = "0x1DEA350")]
		remove
		{
		}
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x316F224", Offset = "0x316F224", VA = "0x316F224")]
	public void InvokeLocalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x316F5C8", Offset = "0x316F5C8", VA = "0x316F5C8")]
	public void InvokeLocalEventMeshRoot(RayfireRigid rigid, RayfireRigid meshRoot)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x316F9C0", Offset = "0x316F9C0", VA = "0x316F9C0")]
	public void InvokeLocalEventRoot(RFShard shard, RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x316FDB8", Offset = "0x316FDB8", VA = "0x316FDB8")]
	public RFEvent()
	{
	}
}
[Token(Token = "0x200000C")]
public class RFDemolitionEvent : RFEvent
{
	[Token(Token = "0x14000004")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x36CDEA4", Offset = "0x36CDEA4", VA = "0x36CDEA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA360", Offset = "0x1DEA360")]
		add
		{
		}
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x36CDF58", Offset = "0x36CDF58", VA = "0x36CDF58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA370", Offset = "0x1DEA370")]
		remove
		{
		}
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x36CAD5C", Offset = "0x36CAD5C", VA = "0x36CAD5C")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x36CE00C", Offset = "0x36CE00C", VA = "0x36CE00C")]
	public RFDemolitionEvent()
	{
	}
}
[Token(Token = "0x200000D")]
public class RFActivationEvent : RFEvent
{
	[Token(Token = "0x14000005")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x36BC6B4", Offset = "0x36BC6B4", VA = "0x36BC6B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA380", Offset = "0x1DEA380")]
		add
		{
		}
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x36BC768", Offset = "0x36BC768", VA = "0x36BC768")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA390", Offset = "0x1DEA390")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public static event EventActionRoot GlobalEventRoot
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x36BC81C", Offset = "0x36BC81C", VA = "0x36BC81C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA3A0", Offset = "0x1DEA3A0")]
		add
		{
		}
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x36BC8D4", Offset = "0x36BC8D4", VA = "0x36BC8D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA3B0", Offset = "0x1DEA3B0")]
		remove
		{
		}
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x36BADCC", Offset = "0x36BADCC", VA = "0x36BADCC")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x36BB394", Offset = "0x36BB394", VA = "0x36BB394")]
	public static void InvokeGlobalEventRoot(RFShard shard, RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x36BC98C", Offset = "0x36BC98C", VA = "0x36BC98C")]
	public RFActivationEvent()
	{
	}
}
[Token(Token = "0x200000E")]
public class RFRestrictionEvent : RFEvent
{
	[Token(Token = "0x14000007")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x3674BC0", Offset = "0x3674BC0", VA = "0x3674BC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA3C0", Offset = "0x1DEA3C0")]
		add
		{
		}
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x3674C74", Offset = "0x3674C74", VA = "0x3674C74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA3D0", Offset = "0x1DEA3D0")]
		remove
		{
		}
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x3674D28", Offset = "0x3674D28", VA = "0x3674D28")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x3674D94", Offset = "0x3674D94", VA = "0x3674D94")]
	public RFRestrictionEvent()
	{
	}
}
[Token(Token = "0x200000F")]
public class RFShotEvent
{
	[Token(Token = "0x2000073")]
	public delegate void EventAction(RayfireGun gun);

	[Token(Token = "0x14000008")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x367861C", Offset = "0x367861C", VA = "0x367861C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA3E0", Offset = "0x1DEA3E0")]
		add
		{
		}
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x36786D0", Offset = "0x36786D0", VA = "0x36786D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA3F0", Offset = "0x1DEA3F0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x3678784", Offset = "0x3678784", VA = "0x3678784")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA400", Offset = "0x1DEA400")]
		add
		{
		}
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x3678828", Offset = "0x3678828", VA = "0x3678828")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA410", Offset = "0x1DEA410")]
		remove
		{
		}
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x36788CC", Offset = "0x36788CC", VA = "0x36788CC")]
	public static void InvokeGlobalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x3678CC8", Offset = "0x3678CC8", VA = "0x3678CC8")]
	public void InvokeLocalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x3678CD8", Offset = "0x3678CD8", VA = "0x3678CD8")]
	public RFShotEvent()
	{
	}
}
[Token(Token = "0x2000010")]
public class RFExplosionEvent
{
	[Token(Token = "0x2000074")]
	public delegate void EventAction(RayfireBomb bomb);

	[Token(Token = "0x1400000A")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x316FEA4", Offset = "0x316FEA4", VA = "0x316FEA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA420", Offset = "0x1DEA420")]
		add
		{
		}
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x316FF58", Offset = "0x316FF58", VA = "0x316FF58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA430", Offset = "0x1DEA430")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x317000C", Offset = "0x317000C", VA = "0x317000C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA440", Offset = "0x1DEA440")]
		add
		{
		}
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x31700B0", Offset = "0x31700B0", VA = "0x31700B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA450", Offset = "0x1DEA450")]
		remove
		{
		}
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x3170154", Offset = "0x3170154", VA = "0x3170154")]
	public static void InvokeGlobalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x3170550", Offset = "0x3170550", VA = "0x3170550")]
	public void InvokeLocalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x3170560", Offset = "0x3170560", VA = "0x3170560")]
	public RFExplosionEvent()
	{
	}
}
[Token(Token = "0x2000011")]
public class RFSliceEvent
{
	[Token(Token = "0x2000075")]
	public delegate void EventAction(RayfireBlade blade);

	[Token(Token = "0x1400000C")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x3678DEC", Offset = "0x3678DEC", VA = "0x3678DEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA460", Offset = "0x1DEA460")]
		add
		{
		}
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x3678EA0", Offset = "0x3678EA0", VA = "0x3678EA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA470", Offset = "0x1DEA470")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x3678F54", Offset = "0x3678F54", VA = "0x3678F54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA480", Offset = "0x1DEA480")]
		add
		{
		}
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x3678FF8", Offset = "0x3678FF8", VA = "0x3678FF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA490", Offset = "0x1DEA490")]
		remove
		{
		}
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x367909C", Offset = "0x367909C", VA = "0x367909C")]
	public static void InvokeGlobalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x3679498", Offset = "0x3679498", VA = "0x3679498")]
	public void InvokeLocalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x36794A8", Offset = "0x36794A8", VA = "0x36794A8")]
	public RFSliceEvent()
	{
	}
}
[Token(Token = "0x2000012")]
public class RFConnectivityEvent
{
	[Token(Token = "0x2000076")]
	public delegate void EventAction(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters);

	[Token(Token = "0x1400000E")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x36C6C9C", Offset = "0x36C6C9C", VA = "0x36C6C9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA4A0", Offset = "0x1DEA4A0")]
		add
		{
		}
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x36C6D50", Offset = "0x36C6D50", VA = "0x36C6D50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA4B0", Offset = "0x1DEA4B0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x36C6E04", Offset = "0x36C6E04", VA = "0x36C6E04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA4C0", Offset = "0x1DEA4C0")]
		add
		{
		}
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x36C6EA8", Offset = "0x36C6EA8", VA = "0x36C6EA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA4D0", Offset = "0x1DEA4D0")]
		remove
		{
		}
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x36C6F4C", Offset = "0x36C6F4C", VA = "0x36C6F4C")]
	public static void InvokeGlobalEvent(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x36C73E0", Offset = "0x36C73E0", VA = "0x36C73E0")]
	public void InvokeLocalEvent(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x36C73F0", Offset = "0x36C73F0", VA = "0x36C73F0")]
	public RFConnectivityEvent()
	{
	}
}
[Token(Token = "0x2000013")]
public class RFFadingEvent
{
	[Token(Token = "0x2000077")]
	public delegate void EventAction(Transform tm);

	[Token(Token = "0x14000010")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x3174000", Offset = "0x3174000", VA = "0x3174000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA4E0", Offset = "0x1DEA4E0")]
		add
		{
		}
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x31740B4", Offset = "0x31740B4", VA = "0x31740B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA4F0", Offset = "0x1DEA4F0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x3174168", Offset = "0x3174168", VA = "0x3174168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA500", Offset = "0x1DEA500")]
		add
		{
		}
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x317420C", Offset = "0x317420C", VA = "0x317420C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DEA510", Offset = "0x1DEA510")]
		remove
		{
		}
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x31733D4", Offset = "0x31733D4", VA = "0x31733D4")]
	public static void InvokeGlobalEvent(Transform tm)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x31733C4", Offset = "0x31733C4", VA = "0x31733C4")]
	public void InvokeLocalEvent(Transform tm)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x3170A6C", Offset = "0x3170A6C", VA = "0x3170A6C")]
	public RFFadingEvent()
	{
	}
}
[Serializable]
[Token(Token = "0x2000014")]
public class RFFlash
{
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1DE93BC", Offset = "0x1DE93BC")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE93BC", Offset = "0x1DE93BC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE93BC", Offset = "0x1DE93BC")]
	public float intensityMin;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9428", Offset = "0x1DE9428")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE9428", Offset = "0x1DE9428")]
	public float intensityMax;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1DE9470", Offset = "0x1DE9470")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9470", Offset = "0x1DE9470")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE9470", Offset = "0x1DE9470")]
	public float rangeMin;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE94DC", Offset = "0x1DE94DC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE94DC", Offset = "0x1DE94DC")]
	public float rangeMax;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1DE9524", Offset = "0x1DE9524")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9524", Offset = "0x1DE9524")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE9524", Offset = "0x1DE9524")]
	public float distance;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9590", Offset = "0x1DE9590")]
	public Color color;

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x3174688", Offset = "0x3174688", VA = "0x3174688")]
	public RFFlash()
	{
	}
}
[Serializable]
[Token(Token = "0x2000015")]
public class RFDecals
{
	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1DE95A4", Offset = "0x1DE95A4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE95A4", Offset = "0x1DE95A4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE95A4", Offset = "0x1DE95A4")]
	public float sizeMin;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9610", Offset = "0x1DE9610")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE9610", Offset = "0x1DE9610")]
	public float sizeMax;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1DE9658", Offset = "0x1DE9658")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9658", Offset = "0x1DE9658")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE9658", Offset = "0x1DE9658")]
	public float distance;

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x36C8580", Offset = "0x36C8580", VA = "0x36C8580")]
	public RFDecals()
	{
	}
}
[Serializable]
[Token(Token = "0x2000016")]
public class RFJoint
{
	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int df;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ConfigurableJoint jn;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Rigidbody r1;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Rigidbody r2;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int br;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int an;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int dm;

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x3179640", Offset = "0x3179640", VA = "0x3179640")]
	public RFJoint(int Id, int Br, int An, int Dm)
	{
	}
}
[Serializable]
[Token(Token = "0x2000017")]
public class RFJointProperties
{
	[Token(Token = "0x2000078")]
	public enum RFJointBreakType
	{
		[Token(Token = "0x40004AB")]
		Breakable,
		[Token(Token = "0x40004AC")]
		Unbreakable
	}

	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE8FAC", Offset = "0x1DE8FAC")]
	private sealed class <DeformationCor>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFJointProperties <>4__this;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x317B114", Offset = "0x317B114", VA = "0x317B114", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x317B17C", Offset = "0x317B17C", VA = "0x317B17C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x317AD2C", Offset = "0x317AD2C", VA = "0x317AD2C")]
		[DebuggerHidden]
		public <DeformationCor>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x317AE18", Offset = "0x317AE18", VA = "0x317AE18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x317AE1C", Offset = "0x317AE1C", VA = "0x317AE1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x317B11C", Offset = "0x317B11C", VA = "0x317B11C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public RFJointBreakType breakType;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int breakForce;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int breakForceVar;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool forceByMass;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool varInAwake;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int angleLimit;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int angleLimitVar;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int damper;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool deformEnable;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int deformCount;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float stiffFrc;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int stiffAbs;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int bend;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int percentage;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float weakening;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int initAmount;

	[NonSerialized]
	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<RFJoint> deformList;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<RFJoint> jointList;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static SoftJointLimit jointLimit;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static SoftJointLimitSpring spring;

	[Token(Token = "0x17000005")]
	public bool HasJoints
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x3179AE4", Offset = "0x3179AE4", VA = "0x3179AE4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000006")]
	public bool HasDeforms
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x317A780", Offset = "0x317A780", VA = "0x317A780")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x3179690", Offset = "0x3179690", VA = "0x3179690")]
	public static void CreateJoints(RFCluster cluster, RFJointProperties joints)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x3179BD0", Offset = "0x3179BD0", VA = "0x3179BD0")]
	public static RFJoint CreateJoint(RFShard shard, RFShard neib, RFJointProperties joints, int id)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x317A40C", Offset = "0x317A40C", VA = "0x317A40C")]
	public static void SetPositionMotion(ConfigurableJoint joint)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x317A458", Offset = "0x317A458", VA = "0x317A458")]
	public static void SetAngularMotion(float angleLimit, RFJoint joint)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x3179D5C", Offset = "0x3179D5C", VA = "0x3179D5C")]
	public static void SetAngularMotion(float angleLimit, int var, List<RFJoint> jointList)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x317A5A0", Offset = "0x317A5A0", VA = "0x317A5A0")]
	public static void SetSpring(int damper, ConfigurableJoint joint)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x3179EA0", Offset = "0x3179EA0", VA = "0x3179EA0")]
	public static void SetSpring(int damper, List<RFJoint> jointList)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x317A664", Offset = "0x317A664", VA = "0x317A664")]
	public static void SetBreakForce(int force, ConfigurableJoint joint)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x317A684", Offset = "0x317A684", VA = "0x317A684")]
	public static void SetBreakForce(int force, List<RFJoint> jointList)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x3179F90", Offset = "0x3179F90", VA = "0x3179F90")]
	public static void SetBreakForce(int force, int var, List<RFJoint> jointList, bool byMass)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x317A2D4", Offset = "0x317A2D4", VA = "0x317A2D4")]
	public static void SetTransform(Transform tm1, Transform tm2, ConfigurableJoint joint)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x3179B40", Offset = "0x3179B40", VA = "0x3179B40")]
	public void EmptyList()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x317A7DC", Offset = "0x317A7DC", VA = "0x317A7DC")]
	public void DestroyJoints()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x317A0C0", Offset = "0x317A0C0", VA = "0x317A0C0")]
	public static void SaveProperties(List<RFJoint> joints)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x317A978", Offset = "0x317A978", VA = "0x317A978")]
	public static RFJoint DeformJoint(RFJoint joint, RFJointProperties joints)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x317AB14", Offset = "0x317AB14", VA = "0x317AB14")]
	public static void SetDeformation(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x317ACB0", Offset = "0x317ACB0", VA = "0x317ACB0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA520", Offset = "0x1DEA520")]
	public IEnumerator DeformationCor()
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x317AD58", Offset = "0x317AD58", VA = "0x317AD58")]
	public RFJointProperties()
	{
	}
}
[Serializable]
[Token(Token = "0x2000018")]
public class RFMesh
{
	[Serializable]
	[Token(Token = "0x200007A")]
	public class RFSubMeshTris
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<int> triangles;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x317F95C", Offset = "0x317F95C", VA = "0x317F95C")]
		public RFSubMeshTris()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x317F138", Offset = "0x317F138", VA = "0x317F138")]
		public RFSubMeshTris(List<int> tris)
		{
		}
	}

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool compress;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int subMeshCount;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Bounds bounds;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int[] triangles;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<RFSubMeshTris> subTriangles;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2[] uv;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3[] vertices;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4[] tangents;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> uvComp;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<int> verticesComp;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<int> tangentsComp;

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x317EBF0", Offset = "0x317EBF0", VA = "0x317EBF0")]
	public RFMesh(Mesh mesh, bool comp = false)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x317F16C", Offset = "0x317F16C", VA = "0x317F16C")]
	public Mesh GetMesh()
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x317F298", Offset = "0x317F298", VA = "0x317F298")]
	private void LoadTriangles(Mesh mesh)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x31770A0", Offset = "0x31770A0", VA = "0x31770A0")]
	public static Mesh BakeMesh(SkinnedMeshRenderer skin)
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x317F834", Offset = "0x317F834", VA = "0x317F834")]
	public static void ConvertRfMeshes(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x317F508", Offset = "0x317F508", VA = "0x317F508")]
	private static Vector2[] SetCompressedUv(List<int> uvComp)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x317F374", Offset = "0x317F374", VA = "0x317F374")]
	private static Vector3[] SetCompressedVertices(List<int> verticesComp)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x317F674", Offset = "0x317F674", VA = "0x317F674")]
	private static Vector4[] SetCompressedTangents(List<int> tangentsComp)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000019")]
public class RFParticleNoise
{
	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enabled;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public ParticleSystemNoiseQuality quality;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float strengthMin;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float strengthMax;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float frequency;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float scrollSpeed;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool damping;

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x317FFCC", Offset = "0x317FFCC", VA = "0x317FFCC")]
	public RFParticleNoise()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x3180010", Offset = "0x3180010", VA = "0x3180010")]
	public void CopyFrom(RFParticleNoise source)
	{
	}
}
[Serializable]
[Token(Token = "0x200001A")]
public class RFParticleRendering
{
	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool castShadows;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool receiveShadows;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public MotionVectorGenerationMode motionVectors;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LightProbeUsage lightProbes;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool l;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int layer;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool t;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string tag;

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x318005C", Offset = "0x318005C", VA = "0x318005C")]
	public RFParticleRendering()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x3180094", Offset = "0x3180094", VA = "0x3180094")]
	public void CopyFrom(RFParticleRendering source)
	{
	}
}
[Serializable]
[Token(Token = "0x200001B")]
public class RFParticleDynamicDebris
{
	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float speedMin;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float speedMax;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float velocityMin;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float velocityMax;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float gravityMin;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float gravityMax;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float rotationSpeed;

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x317FDAC", Offset = "0x317FDAC", VA = "0x317FDAC")]
	public RFParticleDynamicDebris()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x317FDF8", Offset = "0x317FDF8", VA = "0x317FDF8")]
	public void CopyFrom(RFParticleDynamicDebris source)
	{
	}
}
[Serializable]
[Token(Token = "0x200001C")]
public class RFParticleDynamicDust
{
	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float speedMin;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float speedMax;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float rotation;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float gravityMin;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float gravityMax;

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x317FE44", Offset = "0x317FE44", VA = "0x317FE44")]
	public RFParticleDynamicDust()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x317FE80", Offset = "0x317FE80", VA = "0x317FE80")]
	public void CopyFrom(RFParticleDynamicDust source)
	{
	}
}
[Serializable]
[Token(Token = "0x200001D")]
public class RFParticleEmission
{
	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFParticles.BurstType burstType;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int burstAmount;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float distanceRate;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float duration;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lifeMin;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float lifeMax;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float sizeMin;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sizeMax;

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x317FEBC", Offset = "0x317FEBC", VA = "0x317FEBC")]
	public RFParticleEmission()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x317FF04", Offset = "0x317FF04", VA = "0x317FF04")]
	public void CopyFrom(RFParticleEmission source)
	{
	}
}
[Serializable]
[Token(Token = "0x200001E")]
public class RFParticleLimitations
{
	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int minParticles;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int maxParticles;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool visible;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int percentage;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sizeThreshold;

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x317FF50", Offset = "0x317FF50", VA = "0x317FF50")]
	public RFParticleLimitations()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x317FF90", Offset = "0x317FF90", VA = "0x317FF90")]
	public void CopyFrom(RFParticleLimitations source)
	{
	}
}
[Serializable]
[Token(Token = "0x200001F")]
public class RFParticleCollisionDebris
{
	[Token(Token = "0x200007B")]
	public enum RFParticleCollisionMatType
	{
		[Token(Token = "0x40004B2")]
		ByPhysicalMaterial,
		[Token(Token = "0x40004B3")]
		ByProperties
	}

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LayerMask collidesWith;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public ParticleSystemCollisionQuality quality;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float radiusScale;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RFParticleCollisionMatType dampenType;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float dampenMin;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float dampenMax;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFParticleCollisionMatType bounceType;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float bounceMin;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float bounceMax;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public bool propertiesSet;

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x317FA68", Offset = "0x317FA68", VA = "0x317FA68")]
	public RFParticleCollisionDebris()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x317FAC8", Offset = "0x317FAC8", VA = "0x317FAC8")]
	public void CopyFrom(RFParticleCollisionDebris source)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x317FB2C", Offset = "0x317FB2C", VA = "0x317FB2C")]
	public void SetMaterialProps(RayfireDebris debris)
	{
	}
}
[Serializable]
[Token(Token = "0x2000020")]
public class RFParticleCollisionDust
{
	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LayerMask collidesWith;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public ParticleSystemCollisionQuality quality;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float radiusScale;

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x317FD44", Offset = "0x317FD44", VA = "0x317FD44")]
	public RFParticleCollisionDust()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x317FD80", Offset = "0x317FD80", VA = "0x317FD80")]
	public void CopyFrom(RFParticleCollisionDust source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000021")]
public class RFParticles
{
	[Token(Token = "0x200007C")]
	public enum RFParticleCollisionMatType
	{
		[Token(Token = "0x40004B5")]
		ByPhysicalMaterial,
		[Token(Token = "0x40004B6")]
		ByProperties
	}

	[Token(Token = "0x200007D")]
	public enum BurstType
	{
		[Token(Token = "0x40004B8")]
		None,
		[Token(Token = "0x40004B9")]
		TotalAmount,
		[Token(Token = "0x40004BA")]
		PerOneUnitSize,
		[Token(Token = "0x40004BB")]
		FragmentAmount
	}

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ParticleSystem.MinMaxCurve constantCurve;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string debrisStr;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string dustStr;

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x31800F0", Offset = "0x31800F0", VA = "0x31800F0")]
	public static void SetParticleComponents(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x3180424", Offset = "0x3180424", VA = "0x3180424")]
	public static void SetParticleComponents(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x318081C", Offset = "0x318081C", VA = "0x318081C")]
	public static void InitDemolitionParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x3180920", Offset = "0x3180920", VA = "0x3180920")]
	public static void CreateDemolitionDebris(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x3181884", Offset = "0x3181884", VA = "0x3181884")]
	private static void CreateReferenceDemolitionDebris(RayfireDebris debris)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x3180C94", Offset = "0x3180C94", VA = "0x3180C94")]
	public static void CreateDemolitionDust(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x3182594", Offset = "0x3182594", VA = "0x3182594")]
	public static void CreateActivationParticlesRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x31831C8", Offset = "0x31831C8", VA = "0x31831C8")]
	public static void CreateActivationParticlesShard(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x3181E64", Offset = "0x3181E64", VA = "0x3181E64")]
	public static void CreateDebrisRigid(RayfireDebris target)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x3182808", Offset = "0x3182808", VA = "0x3182808")]
	public static void CreateDebrisCluster(RayfireRigid rigid, RayfireDebris debris)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x3183560", Offset = "0x3183560", VA = "0x3183560")]
	public static void CreateDebrisShard(RayfireRigidRoot root, RayfireDebris debris, RFShard shard)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x3182244", Offset = "0x3182244", VA = "0x3182244")]
	public static void CreateDustRigid(RayfireDust target)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x3182CE8", Offset = "0x3182CE8", VA = "0x3182CE8")]
	public static void CreateDustCluster(RayfireRigid rigid, RayfireDust dust)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x31836F8", Offset = "0x31836F8", VA = "0x31836F8")]
	public static void CreateDustShard(RayfireRigidRoot root, RayfireDust dust, RFShard shard)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x3183890", Offset = "0x3183890", VA = "0x3183890")]
	public static ParticleSystem CreateParticleSystemDebris(RayfireDebris debris, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x3183BEC", Offset = "0x3183BEC", VA = "0x3183BEC")]
	public static ParticleSystem CreateParticleSystemDust(RayfireDust dust, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x3183D6C", Offset = "0x3183D6C", VA = "0x3183D6C")]
	private static ParticleSystem CreateParticleSystem(Transform tm, RFParticleRendering rend)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x3184008", Offset = "0x3184008", VA = "0x3184008")]
	public static void CreateDebrisImpact(RayfireDebris debris, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x31841CC", Offset = "0x31841CC", VA = "0x31841CC")]
	public static void CreateDustImpact(RayfireDust dust, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x31810E0", Offset = "0x31810E0", VA = "0x31810E0")]
	private static void DetachParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x3184390", Offset = "0x3184390", VA = "0x3184390")]
	public static void CopyRigidParticles(RayfireRigid source, RayfireRigid target)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x31847C0", Offset = "0x31847C0", VA = "0x31847C0")]
	public static void CopyRootMeshParticles(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x3185214", Offset = "0x3185214", VA = "0x3185214")]
	public static void CopyRigidRootParticles(RayfireRigidRoot source, RayfireRigid target)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x3185644", Offset = "0x3185644", VA = "0x3185644")]
	public static void SetMain(ParticleSystem.MainModule main, float lifeMin, float lifeMax, float sizeMin, float sizeMax, float gravityMin, float gravityMax, float speedMin, float speedMax, float divergence, int maxParticles, float duration)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x31858B4", Offset = "0x31858B4", VA = "0x31858B4")]
	public static void SetEmission(ParticleSystem.EmissionModule emissionModule, float distanceRate, int burstAmount)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x3185A18", Offset = "0x3185A18", VA = "0x3185A18")]
	public static void SetShapeMesh(ParticleSystem.ShapeModule shapeModule, Mesh mesh, int emitMatIndex, Vector3 shapeScale)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x3185AD8", Offset = "0x3185AD8", VA = "0x3185AD8")]
	public static void SetShapeObject(ParticleSystem.ShapeModule shapeModule)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x3183A10", Offset = "0x3183A10", VA = "0x3183A10")]
	public static int GetEmissionMatIndex(Renderer renderer, Material mat)
	{
		return default(int);
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x3185B28", Offset = "0x3185B28", VA = "0x3185B28")]
	public static void SetVelocity(ParticleSystem.InheritVelocityModule velocity, RFParticleDynamicDebris dynamic)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x3185C1C", Offset = "0x3185C1C", VA = "0x3185C1C")]
	public static void SetRotationOverLifeTime(ParticleSystem.RotationOverLifetimeModule rotation, RFParticleDynamicDust dynamic)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x3185CEC", Offset = "0x3185CEC", VA = "0x3185CEC")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationByLife(float spin)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x3185F20", Offset = "0x3185F20", VA = "0x3185F20")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, float size)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x31861C8", Offset = "0x31861C8", VA = "0x31861C8")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, Vector3 size)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x3185FCC", Offset = "0x3185FCC", VA = "0x3185FCC")]
	public static ParticleSystem.MinMaxCurve GetCurveSizeOverLifeTime(float val)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x31862DC", Offset = "0x31862DC", VA = "0x31862DC")]
	public static void SetRotationBySpeed(ParticleSystem.RotationBySpeedModule rotationBySpeed, float rotationSpeed)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x31863B4", Offset = "0x31863B4", VA = "0x31863B4")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationBySpeed(float rotationSpeed)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x3186584", Offset = "0x3186584", VA = "0x3186584")]
	public static void SetColorOverLife(ParticleSystem.ColorOverLifetimeModule colorLife, float opacity)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x3186748", Offset = "0x3186748", VA = "0x3186748")]
	public static void SetNoise(ParticleSystem.NoiseModule psNoise, RFParticleNoise scrNoise)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x3186968", Offset = "0x3186968", VA = "0x3186968")]
	public static void SetCollisionDebris(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDebris coll)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x3186ABC", Offset = "0x3186ABC", VA = "0x3186ABC")]
	public static void SetCollisionDust(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDust coll)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x3181954", Offset = "0x3181954", VA = "0x3181954")]
	public static void GetDebrisTargets(List<RayfireDebris> filtered, List<RayfireDebris> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x3182354", Offset = "0x3182354", VA = "0x3182354")]
	public static void GetDustTargets(List<RayfireDust> filtered, List<RayfireDust> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x3181B94", Offset = "0x3181B94", VA = "0x3181B94")]
	public static void SetRigidDebrisFinalAmount(List<RayfireDebris> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x3181F74", Offset = "0x3181F74", VA = "0x3181F74")]
	public static void SetDustFinalAmount(List<RayfireDust> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x3183B68", Offset = "0x3183B68", VA = "0x3183B68")]
	public static int GetShardFinalAmount(RFShard shard, BurstType burstType, int burstAmount, float sizeSum)
	{
		return default(int);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x3186B64", Offset = "0x3186B64", VA = "0x3186B64")]
	public static bool AmountCheck(RayfireRigid source, int pType)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x3186D74", Offset = "0x3186D74", VA = "0x3186D74")]
	public RFParticles()
	{
	}
}
[Serializable]
[Token(Token = "0x2000022")]
public class RFShard : IComparable<RFShard>
{
	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float neibPosThreshold;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float neibAreaThreshold;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float bBoxSharedAreaDiv;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float sz;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool uny;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool act;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Bounds bnd;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 pos;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SimType sm;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float dm;

	[NonSerialized]
	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion rot;

	[NonSerialized]
	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector3 scl;

	[NonSerialized]
	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector3 los;

	[NonSerialized]
	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float m;

	[NonSerialized]
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int lb;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int nAm;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<int> nIds;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<float> nArea;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<int> sIds;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<float> nSt;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float sSt;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Transform tm;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public MeshFilter mf;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Collider col;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Rigidbody rb;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public RayfireRigid rigid;

	[NonSerialized]
	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public int fade;

	[NonSerialized]
	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float fo;

	[NonSerialized]
	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<RFTriangle> tris;

	[NonSerialized]
	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public List<RFFace> poly;

	[NonSerialized]
	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public RFCluster cluster;

	[NonSerialized]
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<RFShard> neibShards;

	[NonSerialized]
	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public bool check;

	[NonSerialized]
	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool[] sCheck;

	[Token(Token = "0x17000007")]
	public bool StressState
	{
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x3677588", Offset = "0x3677588", VA = "0x3677588")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000008")]
	public bool SupportState
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x3677FC4", Offset = "0x3677FC4", VA = "0x3677FC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	public bool InactiveOrKinematic
	{
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x367801C", Offset = "0x367801C", VA = "0x367801C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000A")]
	public bool Visible
	{
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x3678030", Offset = "0x3678030", VA = "0x3678030")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x367537C", Offset = "0x367537C", VA = "0x367537C")]
	public RFShard()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x3675400", Offset = "0x3675400", VA = "0x3675400")]
	public RFShard(RFShard source)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x36756A4", Offset = "0x36756A4", VA = "0x36756A4")]
	public RFShard(Transform Tm)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x3675854", Offset = "0x3675854", VA = "0x3675854")]
	public RFShard(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x36759BC", Offset = "0x36759BC", VA = "0x36759BC", Slot = "4")]
	public int CompareTo(RFShard otherShard)
	{
		return default(int);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x36759EC", Offset = "0x36759EC", VA = "0x36759EC")]
	public static void SetMeshData(List<RFShard> shards, ConnectivityType type)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x3675F40", Offset = "0x3675F40", VA = "0x3675F40")]
	public static void SetMeshData(RFShard shard, ConnectivityType type)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x3675F88", Offset = "0x3675F88", VA = "0x3675F88")]
	public static void SetShards(RFCluster cluster, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x3676094", Offset = "0x3676094", VA = "0x3676094")]
	public static void SetShardsByTransformList(RFCluster cluster, List<Transform> tmList, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x3676340", Offset = "0x3676340", VA = "0x3676340")]
	public static void SetShardsByRigidList(RFCluster cluster, List<RayfireRigid> rigids, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x3676460", Offset = "0x3676460", VA = "0x3676460")]
	private float NeibAreaByPoly(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x36766F0", Offset = "0x36766F0", VA = "0x36766F0")]
	private float NeibAreaByTris(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x3676998", Offset = "0x3676998", VA = "0x3676998")]
	public static void SetShardNeibs(List<RFShard> shards, ConnectivityType type, float minArea = 0f, float minSize = 0f, int perc = 0, int seed = 0)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x3677300", Offset = "0x3677300", VA = "0x3677300")]
	public static void ReinitNeibs(List<RFShard> shards)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x3677468", Offset = "0x3677468", VA = "0x3677468")]
	public void RemoveNeibAt(int ind)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x36775E4", Offset = "0x36775E4", VA = "0x36775E4")]
	public void ClearNeib()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x36776C4", Offset = "0x36776C4", VA = "0x36776C4")]
	public static void SetUnchecked(List<RFShard> shards)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x3677750", Offset = "0x3677750", VA = "0x3677750")]
	public static Plane GetSlicePlane(Bounds bound)
	{
		return default(Plane);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x3677894", Offset = "0x3677894", VA = "0x3677894")]
	public static List<RFShard> SortByDistanceToPoint(List<RFShard> shards, Vector3 point, int amount)
	{
		return null;
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x3677B8C", Offset = "0x3677B8C", VA = "0x3677B8C")]
	public static List<RFShard> SortByDistanceToPlane(List<RFShard> shards, Vector3 point, Vector3 normal, int amount)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x3677E8C", Offset = "0x3677E8C", VA = "0x3677E8C")]
	public static bool UnyieldingByShard(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x3677F28", Offset = "0x3677F28", VA = "0x3677F28")]
	public static bool AllUnyShards(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x3678120", Offset = "0x3678120", VA = "0x3678120")]
	public static RFShard GetShardByCollider(List<RFShard> shards, Collider collider)
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x3678220", Offset = "0x3678220", VA = "0x3678220")]
	public static List<RFShard> GetShardsByColliders(List<RFShard> shards, List<Collider> colliders)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000023")]
public class RFSound
{
	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool once;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float multiplier;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip clip;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<AudioClip> clips;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioMixerGroup outputGroup;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool played;

	[Token(Token = "0x1700000B")]
	public bool HasClips
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x3679690", Offset = "0x3679690", VA = "0x3679690")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x36794F4", Offset = "0x36794F4", VA = "0x36794F4")]
	public RFSound()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x3679524", Offset = "0x3679524", VA = "0x3679524")]
	public RFSound(RFSound source)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x36796EC", Offset = "0x36796EC", VA = "0x36796EC")]
	public static void CopySound(RayfireSound source, RayfireRigid target)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x36797DC", Offset = "0x36797DC", VA = "0x36797DC")]
	public static void CopySound(RayfireSound source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x3679994", Offset = "0x3679994", VA = "0x3679994")]
	public static void Play(RayfireSound scr, AudioClip clip, AudioMixerGroup group, float volume)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x3679BEC", Offset = "0x3679BEC", VA = "0x3679BEC")]
	public static void InitializationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x367A004", Offset = "0x367A004", VA = "0x367A004")]
	public static void ActivationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x367A1D8", Offset = "0x367A1D8", VA = "0x367A1D8")]
	public static void DemolitionSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x367A3AC", Offset = "0x367A3AC", VA = "0x367A3AC")]
	public static void CollisionSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x3679F40", Offset = "0x3679F40", VA = "0x3679F40")]
	public static float GeVolume(RayfireSound scr, float size)
	{
		return default(float);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x3679DD0", Offset = "0x3679DD0", VA = "0x3679DD0")]
	private static bool FilterCheck(RayfireSound scr, float size)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000024")]
public class RFStress
{
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE8FBC", Offset = "0x1DE8FBC")]
	private sealed class <StressCor>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity scr;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFStress <>4__this;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x17000037")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x367E1D0", Offset = "0x367E1D0", VA = "0x367E1D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x367E238", Offset = "0x367E238", VA = "0x367E238", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x367AF70", Offset = "0x367AF70", VA = "0x367AF70")]
		[DebuggerHidden]
		public <StressCor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x367E010", Offset = "0x367E010", VA = "0x367E010", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x367E014", Offset = "0x367E014", VA = "0x367E014", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x367E1D8", Offset = "0x367E1D8", VA = "0x367E1D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int threshold;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float erosion;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float interval;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int support;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool exposed;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool bySize;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<RFShard> strShards;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<RFShard> supShards;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 rotCache;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 grvCache;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int supCache;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float sizeCache;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool initialized;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<RFShard> checkShards;

	[NonSerialized]
	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool inProgress;

	[NonSerialized]
	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int strAmount;

	[NonSerialized]
	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int supAmount;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<int> path;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<int> frontier;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<int> frontPrior;

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x367AD38", Offset = "0x367AD38", VA = "0x367AD38")]
	public RFStress()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x367AE20", Offset = "0x367AE20", VA = "0x367AE20")]
	public static void StopStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x367AE44", Offset = "0x367AE44", VA = "0x367AE44")]
	public static void StartStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x367AED8", Offset = "0x367AED8", VA = "0x367AED8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA584", Offset = "0x1DEA584")]
	private IEnumerator StressCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x367AF9C", Offset = "0x367AF9C", VA = "0x367AF9C")]
	private bool CheckSupport(RayfireConnectivity scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x367B25C", Offset = "0x367B25C", VA = "0x367B25C")]
	private static void StressErosion(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x367B830", Offset = "0x367B830", VA = "0x367B830")]
	private static void StressCollapse(RayfireConnectivity connectivity, int maxStressValue)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x367B878", Offset = "0x367B878", VA = "0x367B878")]
	private static int RemNeibByStress(RFStress stress, int stressVal)
	{
		return default(int);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x367BB94", Offset = "0x367BB94", VA = "0x367BB94")]
	public static void Initialize(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x367BC08", Offset = "0x367BC08", VA = "0x367BC08")]
	private static bool InitializeNeed(RayfireConnectivity conn)
	{
		return default(bool);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x367BD98", Offset = "0x367BD98", VA = "0x367BD98")]
	private static void SetStressConnections(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x367C990", Offset = "0x367C990", VA = "0x367C990")]
	private static void SetStressSupport(List<RFShard> shards, RFStress stress)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x367D024", Offset = "0x367D024", VA = "0x367D024")]
	private static void PrepareCheckShards(RFStress stress)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x367C29C", Offset = "0x367C29C", VA = "0x367C29C")]
	private static void SetSizeMultiplier(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x367DA10", Offset = "0x367DA10", VA = "0x367DA10")]
	private static void SetSizeMultiplierOLD(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x367D0BC", Offset = "0x367D0BC", VA = "0x367D0BC")]
	private static List<int> GetPathAstar(RFStress str, List<RFShard> shards, int startId, int lastId)
	{
		return null;
	}
}
[Token(Token = "0x2000025")]
public enum AxisType
{
	[Token(Token = "0x4000112")]
	XRed,
	[Token(Token = "0x4000113")]
	YGreen,
	[Token(Token = "0x4000114")]
	ZBlue
}
[Token(Token = "0x2000026")]
public enum PlaneType
{
	[Token(Token = "0x4000116")]
	XY,
	[Token(Token = "0x4000117")]
	XZ,
	[Token(Token = "0x4000118")]
	YZ
}
[Token(Token = "0x2000027")]
public enum FragType
{
	[Token(Token = "0x400011A")]
	Voronoi = 0,
	[Token(Token = "0x400011B")]
	Splinters = 1,
	[Token(Token = "0x400011C")]
	Slabs = 2,
	[Token(Token = "0x400011D")]
	Radial = 3,
	[Token(Token = "0x400011E")]
	Custom = 5,
	[Token(Token = "0x400011F")]
	Slices = 7,
	[Token(Token = "0x4000120")]
	Bricks = 9,
	[Token(Token = "0x4000121")]
	Voxels = 10,
	[Token(Token = "0x4000122")]
	Tets = 11,
	[Token(Token = "0x4000123")]
	Decompose = 15
}
[Token(Token = "0x2000028")]
public enum DemolitionType
{
	[Token(Token = "0x4000125")]
	None = 0,
	[Token(Token = "0x4000126")]
	Runtime = 1,
	[Token(Token = "0x4000127")]
	AwakePrecache = 2,
	[Token(Token = "0x4000128")]
	AwakePrefragment = 3,
	[Token(Token = "0x4000129")]
	ReferenceDemolition = 9
}
[Token(Token = "0x2000029")]
public enum CachingType
{
	[Token(Token = "0x400012B")]
	Disable,
	[Token(Token = "0x400012C")]
	ByFrames,
	[Token(Token = "0x400012D")]
	ByFragmentsPerFrame
}
[Token(Token = "0x200002A")]
public enum FadeType
{
	[Token(Token = "0x400012F")]
	None = 0,
	[Token(Token = "0x4000130")]
	SimExclude = 1,
	[Token(Token = "0x4000131")]
	FallDown = 2,
	[Token(Token = "0x4000132")]
	ScaleDown = 3,
	[Token(Token = "0x4000133")]
	MoveDown = 4,
	[Token(Token = "0x4000134")]
	Destroy = 5,
	[Token(Token = "0x4000135")]
	SetStatic = 8,
	[Token(Token = "0x4000136")]
	SetKinematic = 9
}
[Token(Token = "0x200002B")]
public enum RFFadeLifeType
{
	[Token(Token = "0x4000138")]
	ByLifeTime = 4,
	[Token(Token = "0x4000139")]
	BySimulationAndLifeTime = 8
}
[Token(Token = "0x200002C")]
public enum MaterialType
{
	[Token(Token = "0x400013B")]
	HeavyMetal,
	[Token(Token = "0x400013C")]
	LightMetal,
	[Token(Token = "0x400013D")]
	DenseRock,
	[Token(Token = "0x400013E")]
	PorousRock,
	[Token(Token = "0x400013F")]
	Concrete,
	[Token(Token = "0x4000140")]
	Brick,
	[Token(Token = "0x4000141")]
	Glass,
	[Token(Token = "0x4000142")]
	Rubber,
	[Token(Token = "0x4000143")]
	Ice,
	[Token(Token = "0x4000144")]
	Wood
}
[Token(Token = "0x200002D")]
public enum MassType
{
	[Token(Token = "0x4000146")]
	MaterialDensity,
	[Token(Token = "0x4000147")]
	MassProperty,
	[Token(Token = "0x4000148")]
	RigidBodyComponent
}
[Token(Token = "0x200002E")]
public enum ObjectType
{
	[Token(Token = "0x400014A")]
	Mesh = 0,
	[Token(Token = "0x400014B")]
	MeshRoot = 1,
	[Token(Token = "0x400014C")]
	SkinnedMesh = 2,
	[Token(Token = "0x400014D")]
	NestedCluster = 4,
	[Token(Token = "0x400014E")]
	ConnectedCluster = 5
}
[Token(Token = "0x200002F")]
public enum SimType
{
	[Token(Token = "0x4000150")]
	Dynamic,
	[Token(Token = "0x4000151")]
	Sleeping,
	[Token(Token = "0x4000152")]
	Inactive,
	[Token(Token = "0x4000153")]
	Kinematic,
	[Token(Token = "0x4000154")]
	Static
}
[Token(Token = "0x2000030")]
public enum FragSimType
{
	[Token(Token = "0x4000156")]
	Dynamic,
	[Token(Token = "0x4000157")]
	Sleeping,
	[Token(Token = "0x4000158")]
	Inactive,
	[Token(Token = "0x4000159")]
	Kinematic,
	[Token(Token = "0x400015A")]
	Inherit
}
[Token(Token = "0x2000031")]
public enum ConnectivityType
{
	[Token(Token = "0x400015C")]
	ByBoundingBox = 0,
	[Token(Token = "0x400015D")]
	ByTriangles = 1,
	[Token(Token = "0x400015E")]
	ByPolygons = 3,
	[Token(Token = "0x400015F")]
	ByBoundingBoxAndTriangles = 2,
	[Token(Token = "0x4000160")]
	ByBoundingBoxAndPolygons = 4
}
[Token(Token = "0x2000032")]
public enum FragmentMode
{
	[Token(Token = "0x4000162")]
	Runtime,
	[Token(Token = "0x4000163")]
	Editor
}
[Token(Token = "0x2000033")]
public enum RFColliderType
{
	[Token(Token = "0x4000165")]
	Mesh = 0,
	[Token(Token = "0x4000166")]
	Box = 1,
	[Token(Token = "0x4000167")]
	Sphere = 2,
	[Token(Token = "0x4000168")]
	None = 4
}
[Token(Token = "0x2000034")]
public enum RFParenting
{
	[Token(Token = "0x400016A")]
	Manager = 0,
	[Token(Token = "0x400016B")]
	Parent = 1,
	[Token(Token = "0x400016C")]
	Sphere = 2,
	[Token(Token = "0x400016D")]
	None = 4
}
[Token(Token = "0x2000035")]
public class RFFrag
{
	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Mesh mesh;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 pivot;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFDictionary subId;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RayfireRigid fragment;

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x31746F4", Offset = "0x31746F4", VA = "0x31746F4")]
	public RFFrag()
	{
	}
}
[Token(Token = "0x2000036")]
public class RFTri
{
	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int meshId;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int subMeshId;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> ids;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Vector3> vpos;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Vector3> vnormal;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector2> uvs;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Vector4> tangents;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<RFTri> neibTris;

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x367E8EC", Offset = "0x367E8EC", VA = "0x367E8EC")]
	public RFTri()
	{
	}
}
[Serializable]
[Token(Token = "0x2000037")]
public class RFDictionary
{
	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<int> keys;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> values;

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x316ED28", Offset = "0x316ED28", VA = "0x316ED28")]
	public RFDictionary(Dictionary<int, int> dictionary)
	{
	}
}
[Serializable]
[Token(Token = "0x2000038")]
public class RFShatterCluster
{
	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int count;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int seed;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float relax;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int amount;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int layers;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scale;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int min;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int max;

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x3678550", Offset = "0x3678550", VA = "0x3678550")]
	public RFShatterCluster()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x36785A4", Offset = "0x36785A4", VA = "0x36785A4")]
	public RFShatterCluster(RFShatterCluster src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000039")]
public class RFVoronoi
{
	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float centerBias;

	[Token(Token = "0x1700000C")]
	public int Amount
	{
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x367EB48", Offset = "0x367EB48", VA = "0x367EB48")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x367EADC", Offset = "0x367EADC", VA = "0x367EADC")]
	public RFVoronoi()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x367EB08", Offset = "0x367EB08", VA = "0x367EB08")]
	public RFVoronoi(RFVoronoi src)
	{
	}
}
[Serializable]
[Token(Token = "0x200003A")]
public class RFSplinters
{
	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AxisType axis;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int amount;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float strength;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float centerBias;

	[Token(Token = "0x1700000D")]
	public int Amount
	{
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x367A608", Offset = "0x367A608", VA = "0x367A608")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x367A580", Offset = "0x367A580", VA = "0x367A580")]
	public RFSplinters()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x367A5B8", Offset = "0x367A5B8", VA = "0x367A5B8")]
	public RFSplinters(RFSplinters src)
	{
	}
}
[Serializable]
[Token(Token = "0x200003B")]
public class RFRadial
{
	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AxisType centerAxis;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float radius;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float divergence;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool restrictToPlane;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int rings;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int focus;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int focusStr;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int randomRings;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int rays;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int randomRays;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int twist;

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x36708F4", Offset = "0x36708F4", VA = "0x36708F4")]
	public RFRadial()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x3670944", Offset = "0x3670944", VA = "0x3670944")]
	public RFRadial(RFRadial src)
	{
	}
}
[Serializable]
[Token(Token = "0x200003C")]
public class RFSlice
{
	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public PlaneType plane;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Transform> sliceList;

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x3678D24", Offset = "0x3678D24", VA = "0x3678D24")]
	public RFSlice()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x3678D50", Offset = "0x3678D50", VA = "0x3678D50")]
	public RFSlice(RFSlice src)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x3678D94", Offset = "0x3678D94", VA = "0x3678D94")]
	public Vector3 Axis(Transform tm)
	{
		return default(Vector3);
	}
}
[Serializable]
[Token(Token = "0x200003D")]
public class RFBricks
{
	[Token(Token = "0x200007F")]
	public enum RFBrickType
	{
		[Token(Token = "0x40004C2")]
		ByAmount,
		[Token(Token = "0x40004C3")]
		BySize
	}

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFBrickType amountType;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float mult;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int amount_X;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int amount_Y;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int amount_Z;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool size_Lock;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float size_X;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float size_Y;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float size_Z;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int sizeVar_X;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int sizeVar_Y;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int sizeVar_Z;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float offset_X;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float offset_Y;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float offset_Z;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool split_X;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool split_Y;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool split_Z;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int split_probability;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float split_offset;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int split_rotation;

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x36BF4A4", Offset = "0x36BF4A4", VA = "0x36BF4A4")]
	public RFBricks()
	{
	}
}
[Serializable]
[Token(Token = "0x200003E")]
public class RFVoxels
{
	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE96E0", Offset = "0x1DE96E0")]
	public float size;

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x367EB70", Offset = "0x367EB70", VA = "0x367EB70")]
	public RFVoxels()
	{
	}
}
[Serializable]
[Token(Token = "0x200003F")]
public class RFTets
{
	[Token(Token = "0x2000080")]
	public enum TetType
	{
		[Token(Token = "0x40004C5")]
		Uniform,
		[Token(Token = "0x40004C6")]
		Curved
	}

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TetType lattice;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int density;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int noise;

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x367E86C", Offset = "0x367E86C", VA = "0x367E86C")]
	public RFTets()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x367E8A4", Offset = "0x367E8A4", VA = "0x367E8A4")]
	public RFTets(RFTets src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000040")]
public class RFActivation
{
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE8FCC", Offset = "0x1DE8FCC")]
	private sealed class <ActivationVelocityCor>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFActivation <>4__this;

		[Token(Token = "0x17000039")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x36BBC0C", Offset = "0x36BBC0C", VA = "0x36BBC0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x36BBC74", Offset = "0x36BBC74", VA = "0x36BBC74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x36BA5DC", Offset = "0x36BA5DC", VA = "0x36BA5DC")]
		[DebuggerHidden]
		public <ActivationVelocityCor>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x36BBAC4", Offset = "0x36BBAC4", VA = "0x36BBAC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x36BBAC8", Offset = "0x36BBAC8", VA = "0x36BBAC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x36BBC14", Offset = "0x36BBC14", VA = "0x36BBC14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE8FDC", Offset = "0x1DE8FDC")]
	private sealed class <ActivationOffsetCor>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFActivation <>4__this;

		[Token(Token = "0x1700003B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x36BBA54", Offset = "0x36BBA54", VA = "0x36BBA54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x36BBABC", Offset = "0x36BBABC", VA = "0x36BBABC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x36BA6A0", Offset = "0x36BA6A0", VA = "0x36BA6A0")]
		[DebuggerHidden]
		public <ActivationOffsetCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x36BB86C", Offset = "0x36BB86C", VA = "0x36BB86C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x36BB870", Offset = "0x36BB870", VA = "0x36BB870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x36BBA5C", Offset = "0x36BBA5C", VA = "0x36BBA5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE8FEC", Offset = "0x1DE8FEC")]
	private sealed class <InactiveCor>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFActivation <>4__this;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x1700003D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x36BBDB4", Offset = "0x36BBDB4", VA = "0x36BBDB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x36BBE1C", Offset = "0x36BBE1C", VA = "0x36BBE1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x36BA764", Offset = "0x36BA764", VA = "0x36BA764")]
		[DebuggerHidden]
		public <InactiveCor>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x36BBC7C", Offset = "0x36BBC7C", VA = "0x36BBC7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x36BBC80", Offset = "0x36BBC80", VA = "0x36BBC80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x36BBDBC", Offset = "0x36BBDBC", VA = "0x36BBDBC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE8FFC", Offset = "0x1DE8FFC")]
	private sealed class <InactiveCor>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFActivation <>4__this;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot scr;

		[Token(Token = "0x1700003F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x36BC644", Offset = "0x36BC644", VA = "0x36BC644", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x36BC6AC", Offset = "0x36BC6AC", VA = "0x36BC6AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x36BA828", Offset = "0x36BA828", VA = "0x36BA828")]
		[DebuggerHidden]
		public <InactiveCor>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x36BBE24", Offset = "0x36BBE24", VA = "0x36BBE24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x36BBE28", Offset = "0x36BBE28", VA = "0x36BBE28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x36BC64C", Offset = "0x36BC64C", VA = "0x36BC64C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool local;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float byOffset;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float byVelocity;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float byDamage;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool byActivator;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool byImpact;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool byConnectivity;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool unyielding;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool activatable;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool l;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int layer;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RayfireConnectivity connect;

	[NonSerialized]
	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int lb;

	[NonSerialized]
	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool activated;

	[NonSerialized]
	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool inactiveCorState;

	[NonSerialized]
	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	public bool velocityCorState;

	[NonSerialized]
	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	public bool offsetCorState;

	[NonSerialized]
	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public IEnumerator velocityEnum;

	[NonSerialized]
	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IEnumerator offsetEnum;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float randomRot;

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x36BA3A0", Offset = "0x36BA3A0", VA = "0x36BA3A0")]
	public RFActivation()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x36BA42C", Offset = "0x36BA42C", VA = "0x36BA42C")]
	public void CopyFrom(RFActivation act)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x36BA3F0", Offset = "0x36BA3F0", VA = "0x36BA3F0")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x36BA498", Offset = "0x36BA498", VA = "0x36BA498")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x36BA544", Offset = "0x36BA544", VA = "0x36BA544")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA5E8", Offset = "0x1DEA5E8")]
	public IEnumerator ActivationVelocityCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x36BA608", Offset = "0x36BA608", VA = "0x36BA608")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA64C", Offset = "0x1DEA64C")]
	public IEnumerator ActivationOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x36BA6CC", Offset = "0x36BA6CC", VA = "0x36BA6CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA6B0", Offset = "0x1DEA6B0")]
	public IEnumerator InactiveCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x36BA790", Offset = "0x36BA790", VA = "0x36BA790")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA714", Offset = "0x1DEA714")]
	public IEnumerator InactiveCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x36BA854", Offset = "0x36BA854", VA = "0x36BA854")]
	public static void ActivateRigid(RayfireRigid scr, bool connCheck = true)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x36BAFA0", Offset = "0x36BAFA0", VA = "0x36BAFA0")]
	public static bool ActivateShard(RFShard shard, RayfireRigidRoot rigidRoot)
	{
		return default(bool);
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x36BAE38", Offset = "0x36BAE38", VA = "0x36BAE38")]
	public static void ActivationRandomRotation(Rigidbody rb)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x36BAD6C", Offset = "0x36BAD6C", VA = "0x36BAD6C")]
	private static void SetActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x36BB414", Offset = "0x36BB414", VA = "0x36BB414")]
	public static void RestoreActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x36BB474", Offset = "0x36BB474", VA = "0x36BB474")]
	public static void BackupActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x36BB33C", Offset = "0x36BB33C", VA = "0x36BB33C")]
	private static void SetActivationLayer(RFShard shard, RFActivation activation)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x36BB4BC", Offset = "0x36BB4BC", VA = "0x36BB4BC")]
	public static void SetActivationLayer(List<RFShard> shards, RFActivation activation, Transform root)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x36BB5E0", Offset = "0x36BB5E0", VA = "0x36BB5E0")]
	public static void RestoreActivationLayer(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x36BB6EC", Offset = "0x36BB6EC", VA = "0x36BB6EC")]
	public static void BackupActivationLayer(RayfireRigidRoot root)
	{
	}
}
[Token(Token = "0x2000041")]
public class RFBackupCluster
{
	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFCluster cluster;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool saved;

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x36BC994", Offset = "0x36BC994", VA = "0x36BC994")]
	private RFBackupCluster()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x36BC9BC", Offset = "0x36BC9BC", VA = "0x36BC9BC")]
	public static void BackupConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x36BD124", Offset = "0x36BD124", VA = "0x36BD124")]
	public static void ResetRigidCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x36BD338", Offset = "0x36BD338", VA = "0x36BD338")]
	private static void DestroyParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x36BD974", Offset = "0x36BD974", VA = "0x36BD974")]
	private static void ResetDeepShardRigid(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x36BE4A8", Offset = "0x36BE4A8", VA = "0x36BE4A8")]
	private static void ResetShardRigid(RFShard shard)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x36BCE78", Offset = "0x36BCE78", VA = "0x36BCE78")]
	public static void SaveTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x36BE05C", Offset = "0x36BE05C", VA = "0x36BE05C")]
	private static void RestoreShardTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x36BDE64", Offset = "0x36BDE64", VA = "0x36BDE64")]
	private static void ResetNestedTransformRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x36BDA98", Offset = "0x36BDA98", VA = "0x36BDA98")]
	private static void ResetNestedRootsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x36BDF58", Offset = "0x36BDF58", VA = "0x36BDF58")]
	private static void ResetNestedParentsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x36BE304", Offset = "0x36BE304", VA = "0x36BE304")]
	private static void DestroyRoots(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x36BE854", Offset = "0x36BE854", VA = "0x36BE854")]
	private static bool BackupState(RayfireConnectivity scr, bool warning = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x36BEACC", Offset = "0x36BEACC", VA = "0x36BEACC")]
	public static void BackupConnectivity(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x36BEBD0", Offset = "0x36BEBD0", VA = "0x36BEBD0")]
	public static void RestoreConnectivity(RayfireConnectivity scr)
	{
	}
}
[Serializable]
[Token(Token = "0x2000042")]
public class RFCollapse
{
	[Token(Token = "0x2000085")]
	public enum RFCollapseType
	{
		[Token(Token = "0x40004D8")]
		ByArea = 1,
		[Token(Token = "0x40004D9")]
		BySize = 3,
		[Token(Token = "0x40004DA")]
		Random = 5
	}

	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE900C", Offset = "0x1DE900C")]
	private sealed class <CollapseCor>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFCollapse <>4__this;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <step>5__3;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int <i>5__4;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x36C5470", Offset = "0x36C5470", VA = "0x36C5470", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x36C54D8", Offset = "0x36C54D8", VA = "0x36C54D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x36C3A94", Offset = "0x36C3A94", VA = "0x36C3A94")]
		[DebuggerHidden]
		public <CollapseCor>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x36C5288", Offset = "0x36C5288", VA = "0x36C5288", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x36C528C", Offset = "0x36C528C", VA = "0x36C528C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x36C5478", Offset = "0x36C5478", VA = "0x36C5478", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE901C", Offset = "0x1DE901C")]
	private sealed class <CollapseCor>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFCollapse <>4__this;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireConnectivity scr;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <step>5__3;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int <i>5__4;

		[Token(Token = "0x17000043")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x36C56C8", Offset = "0x36C56C8", VA = "0x36C56C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x36C5730", Offset = "0x36C5730", VA = "0x36C5730", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x36C3C38", Offset = "0x36C3C38", VA = "0x36C3C38")]
		[DebuggerHidden]
		public <CollapseCor>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x36C54E0", Offset = "0x36C54E0", VA = "0x36C54E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x36C54E4", Offset = "0x36C54E4", VA = "0x36C54E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x36C56D0", Offset = "0x36C56D0", VA = "0x36C56D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1DE96FC", Offset = "0x1DE96FC")]
	public RFCollapseType type;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int start;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int end;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int steps;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float duration;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int var;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int seed;

	[NonSerialized]
	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool inProgress;

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x36C38F0", Offset = "0x36C38F0", VA = "0x36C38F0")]
	public RFCollapse()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x36C392C", Offset = "0x36C392C", VA = "0x36C392C")]
	public static void StartCollapse(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x36C39FC", Offset = "0x36C39FC", VA = "0x36C39FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA778", Offset = "0x1DEA778")]
	private IEnumerator CollapseCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x36C3AC0", Offset = "0x36C3AC0", VA = "0x36C3AC0")]
	public static void StartCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x36C3C14", Offset = "0x36C3C14", VA = "0x36C3C14")]
	public static void StopCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x36C3B7C", Offset = "0x36C3B7C", VA = "0x36C3B7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA7DC", Offset = "0x1DEA7DC")]
	private IEnumerator CollapseCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x36C3C64", Offset = "0x36C3C64", VA = "0x36C3C64")]
	public static void AreaCollapse(RayfireRigid scr, int areaPercentage)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x36C3DA4", Offset = "0x36C3DA4", VA = "0x36C3DA4")]
	public static void SizeCollapse(RayfireRigid scr, int sizePercentage)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x36C3D1C", Offset = "0x36C3D1C", VA = "0x36C3D1C")]
	public static void AreaCollapse(RayfireRigid scr, float minAreaValue)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x36C3E5C", Offset = "0x36C3E5C", VA = "0x36C3E5C")]
	public static void SizeCollapse(RayfireRigid scr, float minSizeValue)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x36C4790", Offset = "0x36C4790", VA = "0x36C4790")]
	public static void RandomCollapse(RayfireRigid scr, int randomValue)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x36C4304", Offset = "0x36C4304", VA = "0x36C4304")]
	private static void CollapseCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x36C4D44", Offset = "0x36C4D44", VA = "0x36C4D44")]
	public static void AreaCollapse(RayfireConnectivity connectivity, int areaPercentage)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x36C4E68", Offset = "0x36C4E68", VA = "0x36C4E68")]
	public static void SizeCollapse(RayfireConnectivity connectivity, int sizePercentage)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x36C4DF4", Offset = "0x36C4DF4", VA = "0x36C4DF4")]
	public static void AreaCollapse(RayfireConnectivity connectivity, float areaValue)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x36C4F18", Offset = "0x36C4F18", VA = "0x36C4F18")]
	public static void SizeCollapse(RayfireConnectivity connectivity, float sizeValue)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x36C4F8C", Offset = "0x36C4F8C", VA = "0x36C4F8C")]
	public static void RandomCollapse(RayfireConnectivity connectivity, int randomPercentage)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x36C3EE4", Offset = "0x36C3EE4", VA = "0x36C3EE4")]
	private static int RemNeibByArea(RFCluster cluster, float minArea, float variation, int seed)
	{
		return default(int);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x36C4420", Offset = "0x36C4420", VA = "0x36C4420")]
	private static int RemNeibBySize(RFCluster cluster, float minSize, float variation, int seed)
	{
		return default(int);
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x36C4810", Offset = "0x36C4810", VA = "0x36C4810")]
	private static int RemNeibRandom(RFCluster cluster, int percent, int seed)
	{
		return default(int);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x36C5064", Offset = "0x36C5064", VA = "0x36C5064")]
	private static void RemoveConnection(RFCluster cluster, int s, int n)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x36BF10C", Offset = "0x36BF10C", VA = "0x36BF10C")]
	public static void SetRangeData(RFCluster cluster, int perc = 0)
	{
	}
}
[Serializable]
[Token(Token = "0x2000043")]
public class RFDamage
{
	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float maxDamage;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float currentDamage;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool collect;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float multiplier;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool toShards;

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x36C7E20", Offset = "0x36C7E20", VA = "0x36C7E20")]
	public RFDamage()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x36C7E64", Offset = "0x36C7E64", VA = "0x36C7E64")]
	public void CopyFrom(RFDamage damage)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x36BE84C", Offset = "0x36BE84C", VA = "0x36BE84C")]
	public void Reset()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x36C7EA4", Offset = "0x36C7EA4", VA = "0x36C7EA4")]
	public static bool ApplyDamage(RayfireRigid scr, float value, Vector3 point, float radius, Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x36C8028", Offset = "0x36C8028", VA = "0x36C8028")]
	public static bool ApplyTo(RayfireRigid scr, float value, Vector3 point, float radius = 0f, [Optional] Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x36C8178", Offset = "0x36C8178", VA = "0x36C8178")]
	public static bool ApplyToRigid(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x36C8064", Offset = "0x36C8064", VA = "0x36C8064")]
	public static bool ApplyToShard(RayfireRigid scr, float value, Vector3 point, float radius, Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x36C81CC", Offset = "0x36C81CC", VA = "0x36C81CC")]
	public static bool ApplyToShard(RayfireRigid scr, float value, Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x36C8370", Offset = "0x36C8370", VA = "0x36C8370")]
	public static bool ApplyToShards(RayfireRigid scr, float value, Vector3 point, float radius)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000044")]
public class RFDemolitionCluster
{
	[Token(Token = "0x2000088")]
	public enum RFDetachType
	{
		[Token(Token = "0x40004EA")]
		RatioToSize = 0,
		[Token(Token = "0x40004EB")]
		WorldUnits = 3
	}

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ConnectivityType connectivity;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float minimumArea;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float minimumSize;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int percentage;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int seed;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public RFDetachType type;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int ratio;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float units;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int shardArea;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool shardDemolition;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int minAmount;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int maxAmount;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool demolishable;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFCollapse collapse;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int clsCount;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFCluster cluster;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<RFCluster> minorClusters;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool cn;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool nd;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int am;

	[NonSerialized]
	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RFBackupCluster backup;

	[NonSerialized]
	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float damageRadius;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string nameApp;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Collider[] shareOverlapColArray;

	[Token(Token = "0x1700000E")]
	public bool HasChildClusters
	{
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x36CDDB4", Offset = "0x36CDDB4", VA = "0x36CDDB4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000F")]
	public bool HasMinorClusters
	{
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x36C9214", Offset = "0x36C9214", VA = "0x36C9214")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x36C85B8", Offset = "0x36C85B8", VA = "0x36C85B8")]
	public RFDemolitionCluster()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x36C861C", Offset = "0x36C861C", VA = "0x36C861C")]
	public void CopyFrom(RFDemolitionCluster demolition)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x36BE844", Offset = "0x36BE844", VA = "0x36BE844")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x36C86AC", Offset = "0x36C86AC", VA = "0x36C86AC")]
	public static void ResetClusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x36C87B0", Offset = "0x36C87B0", VA = "0x36C87B0")]
	public static void ClusterizeEditor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x36C885C", Offset = "0x36C885C", VA = "0x36C885C")]
	public static void Clusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x36C8DFC", Offset = "0x36C8DFC", VA = "0x36C8DFC")]
	private static void ClusterizeConnected(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x36C901C", Offset = "0x36C901C", VA = "0x36C901C")]
	private static void InitNestedCluster(RFCluster parentCluster, List<RFCluster> minorClusters)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x36C8AAC", Offset = "0x36C8AAC", VA = "0x36C8AAC")]
	private static void ClusterizeNested(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x36C9270", Offset = "0x36C9270", VA = "0x36C9270")]
	private static void ClusterizeNestedRecursive(RayfireRigid scr, Transform transform, RFCluster cluster, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x36C95C0", Offset = "0x36C95C0", VA = "0x36C95C0")]
	public static bool DemolishCluster(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x36C99D0", Offset = "0x36C99D0", VA = "0x36C99D0")]
	public static void RayFireDemolishImpact(Vector3 center, float range, float force)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x36C9C38", Offset = "0x36C9C38", VA = "0x36C9C38")]
	public static bool RayFireDemolishCheck(Collider coll)
	{
		return default(bool);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x36C9830", Offset = "0x36C9830", VA = "0x36C9830")]
	public static List<RFShard> DemolishConnectedCluster(RayfireRigid scr, [Optional] Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x36C9DDC", Offset = "0x36C9DDC", VA = "0x36C9DDC")]
	private static Collider[] GetDetachColliders(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x36CA0D8", Offset = "0x36CA0D8", VA = "0x36CA0D8")]
	private static List<RFShard> DetachShardsByColliders(RayfireRigid scr, Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x36C96E8", Offset = "0x36C96E8", VA = "0x36C96E8")]
	private static void DemolishNestedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x36C4BB4", Offset = "0x36C4BB4", VA = "0x36C4BB4")]
	public static void PostDemolitionCluster(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x36CA878", Offset = "0x36CA878", VA = "0x36CA878")]
	private static void SetupDetachShards(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x36CA978", Offset = "0x36CA978", VA = "0x36CA978")]
	private static void CreateChildClusters(RayfireRigid scr, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x36CAA74", Offset = "0x36CAA74", VA = "0x36CAA74")]
	private static void UpdateOriginalCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x36CBAE0", Offset = "0x36CBAE0", VA = "0x36CBAE0")]
	public static void SliceConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x36CC208", Offset = "0x36CC208", VA = "0x36CC208")]
	private static void SetupPlaneShards(RayfireRigid scr, List<RFShard> clusterShards, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x36CA474", Offset = "0x36CA474", VA = "0x36CA474")]
	private static void ClusterizeDetachShards(RayfireRigid scr, List<RFShard> detachShards, int clusterAmount, int sortType)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x36CB108", Offset = "0x36CB108", VA = "0x36CB108")]
	public static void CreateClusterRuntime(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x36CC558", Offset = "0x36CC558", VA = "0x36CC558")]
	private static void DivideAllShards(RFCluster cluster, List<RFShard> detachShards, int amount)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x36CCDBC", Offset = "0x36CCDBC", VA = "0x36CCDBC")]
	private static void DivideShards(RFCluster mainCluster, RFCluster childCluster)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x36CD164", Offset = "0x36CD164", VA = "0x36CD164")]
	public static void DetachEdgeShards(RFCluster cluster, List<RFShard> detachShards, int edgeShardArea)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x36CCCBC", Offset = "0x36CCCBC", VA = "0x36CCCBC")]
	private static void DetachOneNeibShards(List<RFCluster> childClusters, List<RFShard> detachShards, int edgeAmount, int startIndex)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x36CD5AC", Offset = "0x36CD5AC", VA = "0x36CD5AC")]
	private static void DetachOneNeibShard(RFCluster cls, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x36CADC8", Offset = "0x36CADC8", VA = "0x36CADC8")]
	private static void AddRigidComponent(RayfireRigid scr, List<RFShard> shardList)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x36CD86C", Offset = "0x36CD86C", VA = "0x36CD86C")]
	private static void AddRigidComponent(RayfireRigid scr, RFShard shard, Transform parent)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x36CAFF4", Offset = "0x36CAFF4", VA = "0x36CAFF4")]
	private static void SetRigidRootShard(RayfireRigid scr, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x36CDC58", Offset = "0x36CDC58", VA = "0x36CDC58")]
	private static bool SameClusterCheck(RayfireRigid scr, List<RFShard> detachShards, int shardAmount, int clusterAmount)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000045")]
public class RFDemolitionSkin
{
	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Transform> bones;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<SkinnedMeshRenderer> skins;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<SkinnedMeshRenderer> skins0;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<SkinnedMeshRenderer> skins1;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<SkinnedMeshRenderer> skins2;

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x316EA74", Offset = "0x316EA74", VA = "0x316EA74")]
	public void SetupSkin(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x316EB18", Offset = "0x316EB18", VA = "0x316EB18")]
	public void SeparateSkins(Vector3 planeNormal, Vector3 planePoint)
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x316ED20", Offset = "0x316ED20", VA = "0x316ED20")]
	public RFDemolitionSkin()
	{
	}
}
[Serializable]
[Token(Token = "0x2000046")]
public class RFDemolitionMesh
{
	[Token(Token = "0x2000089")]
	public enum MeshInputType
	{
		[Token(Token = "0x40004ED")]
		AtStart = 3,
		[Token(Token = "0x40004EE")]
		AtInitialization = 6,
		[Token(Token = "0x40004EF")]
		AtDemolition = 9
	}

	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE902C", Offset = "0x1DE902C")]
	private sealed class <RuntimeCachingCor>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFDemolitionMesh <>4__this;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <demolitionShouldLocal>5__2;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<int> <batchAmount>5__3;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject <tmRefGo>5__4;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Mesh> <meshesList>5__5;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Vector3> <pivotsList>5__6;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<RFDictionary> <subList>5__7;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int <i>5__8;

		[Token(Token = "0x17000045")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x316EA04", Offset = "0x316EA04", VA = "0x316EA04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x316EA6C", Offset = "0x316EA6C", VA = "0x316EA6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x316E1B8", Offset = "0x316E1B8", VA = "0x316E1B8")]
		[DebuggerHidden]
		public <RuntimeCachingCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x316E1E4", Offset = "0x316E1E4", VA = "0x316E1E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x316E1E8", Offset = "0x316E1E8", VA = "0x316E1E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x316EA0C", Offset = "0x316EA0C", VA = "0x316EA0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int variation;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float depthFade;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float contactBias;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int seed;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool useShatter;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool addChildren;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool clusterize;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FragSimType simType;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public MeshInputType meshInput;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFFragmentProperties properties;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFRuntimeCaching runtimeCaching;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RayfireShatter scrShatter;

	[NonSerialized]
	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int badMesh;

	[NonSerialized]
	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int shatterMode;

	[NonSerialized]
	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int totalAmount;

	[NonSerialized]
	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int innerSubId;

	[NonSerialized]
	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Mesh mesh;

	[NonSerialized]
	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFShatter rfShatter;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public Quaternion cacheRotationStart;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string fragmentStr;

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x36CE014", Offset = "0x36CE014", VA = "0x36CE014")]
	public RFDemolitionMesh()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x36CE144", Offset = "0x36CE144", VA = "0x36CE144")]
	public void CopyFrom(RFDemolitionMesh demolition)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x36BE838", Offset = "0x36BE838", VA = "0x36BE838")]
	public void Reset()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x36CE27C", Offset = "0x36CE27C", VA = "0x36CE27C")]
	public static bool DemolishMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x36CEFC0", Offset = "0x36CEFC0", VA = "0x36CEFC0")]
	public static bool ClusterizeFragments(RayfireRigid rigid)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x36CE508", Offset = "0x36CE508", VA = "0x36CE508")]
	public static List<RayfireRigid> CreateFragments(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x36CF43C", Offset = "0x36CF43C", VA = "0x36CF43C")]
	public static void SliceMesh(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x36CF854", Offset = "0x36CF854", VA = "0x36CF854")]
	public static List<RayfireRigid> CreateSlices(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x36CF400", Offset = "0x36CF400", VA = "0x36CF400")]
	private static void SetFragmentSimulationType(RayfireRigid frag, RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x36CEEE0", Offset = "0x36CEEE0", VA = "0x36CEEE0")]
	private static void CacheRuntime(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x36CFF94", Offset = "0x36CFF94", VA = "0x36CFF94")]
	private static void CacheInstant(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x36D005C", Offset = "0x36D005C", VA = "0x36D005C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA840", Offset = "0x1DEA840")]
	public IEnumerator RuntimeCachingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x36D00F4", Offset = "0x36D00F4", VA = "0x36D00F4")]
	public void StopRuntimeCaching()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x36D011C", Offset = "0x36D011C", VA = "0x36D011C")]
	private void ResetRuntimeCaching(RayfireRigid scr, GameObject tmRefGo)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x36D0188", Offset = "0x36D0188", VA = "0x36D0188")]
	public static void Awake(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x36D0250", Offset = "0x36D0250", VA = "0x36D0250")]
	private static void PreCache(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x36D02DC", Offset = "0x36D02DC", VA = "0x36D02DC")]
	private static void Prefragment(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x36D0524", Offset = "0x36D0524", VA = "0x36D0524")]
	public static void ChildrenToFragments(RayfireRigid scr)
	{
	}
}
[Serializable]
[Token(Token = "0x2000047")]
public class RFFade
{
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE903C", Offset = "0x1DE903C")]
	private sealed class <FadeOffsetCor>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x3172754", Offset = "0x3172754", VA = "0x3172754", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x31727BC", Offset = "0x31727BC", VA = "0x31727BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x3170D8C", Offset = "0x3170D8C", VA = "0x3170D8C")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x31724FC", Offset = "0x31724FC", VA = "0x31724FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x3172500", Offset = "0x3172500", VA = "0x3172500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x317275C", Offset = "0x317275C", VA = "0x317275C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE904C", Offset = "0x1DE904C")]
	private sealed class <FadeOffsetCor>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot scr;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x3172B70", Offset = "0x3172B70", VA = "0x3172B70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x3172BD8", Offset = "0x3172BD8", VA = "0x3172BD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x3170E34", Offset = "0x3170E34", VA = "0x3170E34")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x31727C4", Offset = "0x31727C4", VA = "0x31727C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x31727C8", Offset = "0x31727C8", VA = "0x31727C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x3172B78", Offset = "0x3172B78", VA = "0x3172B78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE905C", Offset = "0x1DE905C")]
	private sealed class <LivingCor>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x317343C", Offset = "0x317343C", VA = "0x317343C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x31734A4", Offset = "0x31734A4", VA = "0x31734A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x3171104", Offset = "0x3171104", VA = "0x3171104")]
		[DebuggerHidden]
		public <LivingCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x317307C", Offset = "0x317307C", VA = "0x317307C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x3173080", Offset = "0x3173080", VA = "0x3173080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x3173444", Offset = "0x3173444", VA = "0x3173444", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE906C", Offset = "0x1DE906C")]
	private sealed class <LivingCor>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot root;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFShard shard;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x31737B4", Offset = "0x31737B4", VA = "0x31737B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x317381C", Offset = "0x317381C", VA = "0x317381C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x3171130", Offset = "0x3171130", VA = "0x3171130")]
		[DebuggerHidden]
		public <LivingCor>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x31734AC", Offset = "0x31734AC", VA = "0x31734AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x31734B0", Offset = "0x31734B0", VA = "0x31734B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x31737BC", Offset = "0x31737BC", VA = "0x31737BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE907C", Offset = "0x1DE907C")]
	private sealed class <SimulationLivingCor>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform tm;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <oldPos>5__2;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <distanceThreshold>5__3;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x3173F90", Offset = "0x3173F90", VA = "0x3173F90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x3173FF8", Offset = "0x3173FF8", VA = "0x3173FF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x31711D8", Offset = "0x31711D8", VA = "0x31711D8")]
		[DebuggerHidden]
		public <SimulationLivingCor>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x3173E0C", Offset = "0x3173E0C", VA = "0x3173E0C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x3173E10", Offset = "0x3173E10", VA = "0x3173E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x3173F98", Offset = "0x3173F98", VA = "0x3173F98", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE908C", Offset = "0x1DE908C")]
	private sealed class <FallDownCor>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid rigid;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x3172DD0", Offset = "0x3172DD0", VA = "0x3172DD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x3172E38", Offset = "0x3172E38", VA = "0x3172E38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x3171570", Offset = "0x3171570", VA = "0x3171570")]
		[DebuggerHidden]
		public <FallDownCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x3172BE0", Offset = "0x3172BE0", VA = "0x3172BE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x3172BE4", Offset = "0x3172BE4", VA = "0x3172BE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x3172DD8", Offset = "0x3172DD8", VA = "0x3172DD8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE909C", Offset = "0x1DE909C")]
	private sealed class <FallDownCor>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFShard shard;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot root;

		[Token(Token = "0x17000053")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x317300C", Offset = "0x317300C", VA = "0x317300C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x3173074", Offset = "0x3173074", VA = "0x3173074", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x3171634", Offset = "0x3171634", VA = "0x3171634")]
		[DebuggerHidden]
		public <FallDownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x3172E40", Offset = "0x3172E40", VA = "0x3172E40", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x3172E44", Offset = "0x3172E44", VA = "0x3172E44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x3173014", Offset = "0x3173014", VA = "0x3173014", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE90AC", Offset = "0x1DE90AC")]
	private sealed class <ScaleDownCor>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <steps>5__2;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000055")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x3173A8C", Offset = "0x3173A8C", VA = "0x3173A8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x3173AF4", Offset = "0x3173AF4", VA = "0x3173AF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x31716DC", Offset = "0x31716DC", VA = "0x31716DC")]
		[DebuggerHidden]
		public <ScaleDownCor>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x3173824", Offset = "0x3173824", VA = "0x3173824", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x3173828", Offset = "0x3173828", VA = "0x3173828", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x3173A94", Offset = "0x3173A94", VA = "0x3173A94", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE90BC", Offset = "0x1DE90BC")]
	private sealed class <ScaleDownCor>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot root;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFShard shard;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <steps>5__2;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000057")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x3173D9C", Offset = "0x3173D9C", VA = "0x3173D9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x3173E04", Offset = "0x3173E04", VA = "0x3173E04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x31717A0", Offset = "0x31717A0", VA = "0x31717A0")]
		[DebuggerHidden]
		public <ScaleDownCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x3173AFC", Offset = "0x3173AFC", VA = "0x3173AFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x3173B00", Offset = "0x3173B00", VA = "0x3173B00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x3173DA4", Offset = "0x3173DA4", VA = "0x3173DA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE90CC", Offset = "0x1DE90CC")]
	private sealed class <FadeMoveDownCor>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid rigid;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <steps>5__2;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000059")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x31720F8", Offset = "0x31720F8", VA = "0x31720F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x3172160", Offset = "0x3172160", VA = "0x3172160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x3171848", Offset = "0x3171848", VA = "0x3171848")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x3171D20", Offset = "0x3171D20", VA = "0x3171D20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x3171D24", Offset = "0x3171D24", VA = "0x3171D24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x3172100", Offset = "0x3172100", VA = "0x3172100", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE90DC", Offset = "0x1DE90DC")]
	private sealed class <FadeMoveDownCor>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFShard shard;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot root;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <steps>5__2;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x1700005B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x317248C", Offset = "0x317248C", VA = "0x317248C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x31724F4", Offset = "0x31724F4", VA = "0x31724F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x317190C", Offset = "0x317190C", VA = "0x317190C")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x3172168", Offset = "0x3172168", VA = "0x3172168", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x317216C", Offset = "0x317216C", VA = "0x317216C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x3172494", Offset = "0x3172494", VA = "0x3172494", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool onDemolition;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool onActivation;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float byOffset;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RFFadeLifeType lifeType;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float lifeTime;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lifeVariation;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public FadeType fadeType;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fadeTime;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sizeFilter;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int shardAmount;

	[NonSerialized]
	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int state;

	[NonSerialized]
	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool stop;

	[NonSerialized]
	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 position;

	[NonSerialized]
	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool offsetCorState;

	[NonSerialized]
	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public IEnumerator offsetEnum;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFFadingEvent fadingEvent;

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x31709AC", Offset = "0x31709AC", VA = "0x31709AC")]
	public RFFade()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x3170A8C", Offset = "0x3170A8C", VA = "0x3170A8C")]
	public void CopyFrom(RFFade fade)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x3170A74", Offset = "0x3170A74", VA = "0x3170A74")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x3170B00", Offset = "0x3170B00", VA = "0x3170B00")]
	public void DemolitionFade(List<RayfireRigid> fadeObjects)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x3170D10", Offset = "0x3170D10", VA = "0x3170D10")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA8A4", Offset = "0x1DEA8A4")]
	public static IEnumerator FadeOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x3170DB8", Offset = "0x3170DB8", VA = "0x3170DB8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA908", Offset = "0x1DEA908")]
	public static IEnumerator FadeOffsetCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x3170BF8", Offset = "0x3170BF8", VA = "0x3170BF8")]
	public static void FadeRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x3170EDC", Offset = "0x3170EDC", VA = "0x3170EDC")]
	public static void FadeShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x3170FF0", Offset = "0x3170FF0", VA = "0x3170FF0")]
	public static void FadeClusterShards(RayfireRigid scr, List<RFShard> fadeShards)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x3170E60", Offset = "0x3170E60", VA = "0x3170E60")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA96C", Offset = "0x1DEA96C")]
	private static IEnumerator LivingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x3170F58", Offset = "0x3170F58", VA = "0x3170F58")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEA9D0", Offset = "0x1DEA9D0")]
	private static IEnumerator LivingCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x317115C", Offset = "0x317115C", VA = "0x317115C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEAA34", Offset = "0x1DEAA34")]
	private static IEnumerator SimulationLivingCor(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x3171204", Offset = "0x3171204", VA = "0x3171204")]
	private static void FadeExclude(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x3171400", Offset = "0x3171400", VA = "0x3171400")]
	private static void FadeExclude(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x31714F4", Offset = "0x31714F4", VA = "0x31714F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEAA98", Offset = "0x1DEAA98")]
	private static IEnumerator FallDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x317159C", Offset = "0x317159C", VA = "0x317159C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEAAFC", Offset = "0x1DEAAFC")]
	private static IEnumerator FallDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x3171660", Offset = "0x3171660", VA = "0x3171660")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEAB60", Offset = "0x1DEAB60")]
	private static IEnumerator ScaleDownCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x3171708", Offset = "0x3171708", VA = "0x3171708")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEABC4", Offset = "0x1DEABC4")]
	private static IEnumerator ScaleDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x31717CC", Offset = "0x31717CC", VA = "0x31717CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEAC28", Offset = "0x1DEAC28")]
	private static IEnumerator FadeMoveDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x3171874", Offset = "0x3171874", VA = "0x3171874")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEAC8C", Offset = "0x1DEAC8C")]
	private static IEnumerator FadeMoveDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x3171938", Offset = "0x3171938", VA = "0x3171938")]
	private static void DisableClusterColliders(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x3171AC0", Offset = "0x3171AC0", VA = "0x3171AC0")]
	public static void SetOffsetFadeList(RayfireRigidRoot root)
	{
	}
}
[Serializable]
[Token(Token = "0x2000048")]
public class RFFragmentProperties
{
	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFColliderType colliderType;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float sizeFilter;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool decompose;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool removeCollinear;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool l;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int m;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int layer;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool t;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string tag;

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x3179470", Offset = "0x3179470", VA = "0x3179470")]
	public RFFragmentProperties()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x31794E8", Offset = "0x31794E8", VA = "0x31794E8")]
	public void CopyFrom(RFFragmentProperties fragmentProperties)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x3179540", Offset = "0x3179540", VA = "0x3179540")]
	public int GetLayer(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x3179590", Offset = "0x3179590", VA = "0x3179590")]
	public string GetTag(RayfireRigid scr)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000049")]
public class RFLimitations
{
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE90EC", Offset = "0x1DE90EC")]
	private sealed class <DemolishableCor>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFLimitations <>4__this;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x1700005D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x317DA18", Offset = "0x317DA18", VA = "0x317DA18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x317DA80", Offset = "0x317DA80", VA = "0x317DA80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x317B414", Offset = "0x317B414", VA = "0x317B414")]
		[DebuggerHidden]
		public <DemolishableCor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x317D8E8", Offset = "0x317D8E8", VA = "0x317D8E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x317D8EC", Offset = "0x317D8EC", VA = "0x317D8EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x317DA20", Offset = "0x317DA20", VA = "0x317DA20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool byCollision;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float solidity;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string tag;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int depth;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float time;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float size;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool visible;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool sliceByBlade;

	[NonSerialized]
	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> slicePlanes;

	[NonSerialized]
	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ContactPoint contactPoint;

	[NonSerialized]
	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector3 contactVector3;

	[NonSerialized]
	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3 contactNormal;

	[NonSerialized]
	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool demolitionShould;

	[NonSerialized]
	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	public bool demolished;

	[NonSerialized]
	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float birthTime;

	[NonSerialized]
	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float bboxSize;

	[NonSerialized]
	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int currentDepth;

	[NonSerialized]
	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool demolishableCorState;

	[NonSerialized]
	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float sliceForce;

	[NonSerialized]
	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool affectInactive;

	[NonSerialized]
	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RayfireRigid ancestor;

	[NonSerialized]
	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<RayfireRigid> descendants;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public Bounds bound;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string rootStr;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string rigidStr;

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x317B184", Offset = "0x317B184", VA = "0x317B184")]
	public RFLimitations()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x317B308", Offset = "0x317B308", VA = "0x317B308")]
	public void CopyFrom(RFLimitations limitations)
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x317B240", Offset = "0x317B240", VA = "0x317B240")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x317B37C", Offset = "0x317B37C", VA = "0x317B37C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEACF0", Offset = "0x1DEACF0")]
	public IEnumerator DemolishableCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x317B440", Offset = "0x317B440", VA = "0x317B440")]
	public static void Checks(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x317CFBC", Offset = "0x317CFBC", VA = "0x317CFBC")]
	public static void SetBound(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x317D098", Offset = "0x317D098", VA = "0x317D098")]
	public static void SetAncestor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x317D1E0", Offset = "0x317D1E0", VA = "0x317D1E0")]
	public static void SetDescendants(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x317D2B4", Offset = "0x317D2B4", VA = "0x317D2B4")]
	public static void CreateRoot(RayfireRigid rfScr)
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x317D428", Offset = "0x317D428", VA = "0x317D428")]
	public bool CollisionCheck(RayfireRigid rigid)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x317D474", Offset = "0x317D474", VA = "0x317D474")]
	public void SetContactInfo(ContactPoint contact)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x317D4D0", Offset = "0x317D4D0", VA = "0x317D4D0")]
	public bool KinematicCollisionCheck(Collision collision, float finalSolidity)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x317D614", Offset = "0x317D614", VA = "0x317D614")]
	public bool ContactPointsCheck(Collision collision, float finalSolidity)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x317D6FC", Offset = "0x317D6FC", VA = "0x317D6FC")]
	public bool DamagePointsCheck(Collision collision, RayfireRigid rigid)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x200004A")]
public class RFPhysic
{
	[Token(Token = "0x2000097")]
	private struct RFIgnorePair
	{
		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int a;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private int b;

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x366F428", Offset = "0x366F428", VA = "0x366F428")]
		public RFIgnorePair(int A, int B)
		{
		}
	}

	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE90FC", Offset = "0x1DE90FC")]
	private sealed class <PhysicsDataCor>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFPhysic <>4__this;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x1700005F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x366F7D4", Offset = "0x366F7D4", VA = "0x366F7D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x366F83C", Offset = "0x366F83C", VA = "0x366F83C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x366F4C8", Offset = "0x366F4C8", VA = "0x366F4C8")]
		[DebuggerHidden]
		public <PhysicsDataCor>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x366F650", Offset = "0x366F650", VA = "0x366F650", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x366F654", Offset = "0x366F654", VA = "0x366F654", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x366F7DC", Offset = "0x366F7DC", VA = "0x366F7DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1DE9754", Offset = "0x1DE9754")]
	public MaterialType mt;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PhysicMaterial material;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MassType massBy;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float mass;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1DE978C", Offset = "0x1DE978C")]
	public RFColliderType ct;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1DE97C4", Offset = "0x1DE97C4")]
	public bool pc;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1DE97FC", Offset = "0x1DE97FC")]
	public bool ine;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1DE9834", Offset = "0x1DE9834")]
	public bool gr;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1DE986C", Offset = "0x1DE986C")]
	public int si;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float st;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1DE98A4", Offset = "0x1DE98A4")]
	public float dm;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Rigidbody rigidBody;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Collider meshCollider;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Collider> clusterColliders;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> ignoreList;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool rec;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool exclude;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int solidity;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool destructible;

	[NonSerialized]
	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 velocity;

	[NonSerialized]
	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3 initScale;

	[NonSerialized]
	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Vector3 initPosition;

	[NonSerialized]
	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Quaternion initRotation;

	[NonSerialized]
	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Vector3 localPosition;

	[NonSerialized]
	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public IEnumerator physicsEnum;

	[NonSerialized]
	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool physicsDataCorState;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int coplanarVertLimit;

	[Token(Token = "0x17000010")]
	public bool HasIgnore
	{
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x366E928", Offset = "0x366E928", VA = "0x366E928")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000011")]
	public bool HasClusterColliders
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x366CFC4", Offset = "0x366CFC4", VA = "0x366CFC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000012")]
	public bool Destructible
	{
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x366F4F4", Offset = "0x366F4F4", VA = "0x366F4F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public int Solidity
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x366F578", Offset = "0x366F578", VA = "0x366F578")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000014")]
	public PhysicMaterial PhysMaterial
	{
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x366D984", Offset = "0x366D984", VA = "0x366D984")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x366ACC0", Offset = "0x366ACC0", VA = "0x366ACC0")]
	public RFPhysic()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x366AE74", Offset = "0x366AE74", VA = "0x366AE74")]
	public void CopyFrom(RFPhysic physics)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x366ADF0", Offset = "0x366ADF0", VA = "0x366ADF0")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x366AF0C", Offset = "0x366AF0C", VA = "0x366AF0C")]
	public void SaveInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x366AF84", Offset = "0x366AF84", VA = "0x366AF84")]
	public void LoadInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x366AFE4", Offset = "0x366AFE4", VA = "0x366AFE4")]
	public static void SetSimulationType(Rigidbody rb, SimType simulationType, ObjectType objectType, bool useGravity, int solver, float sleep = 0.005f)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x366B1D8", Offset = "0x366B1D8", VA = "0x366B1D8")]
	private static void SetDynamic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x366B2E0", Offset = "0x366B2E0", VA = "0x366B2E0")]
	private static void SetSleeping(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x366B32C", Offset = "0x366B32C", VA = "0x366B32C")]
	private static void SetInactive(Rigidbody rb)
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x366B374", Offset = "0x366B374", VA = "0x366B374")]
	private static void SetKinematic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x366B218", Offset = "0x366B218", VA = "0x366B218")]
	private static void SetCollisionDetection(Rigidbody rb, ObjectType objectType)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x366B3C4", Offset = "0x366B3C4", VA = "0x366B3C4")]
	public static void SetDensity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x366B6C4", Offset = "0x366B6C4", VA = "0x366B6C4")]
	public static void SetDensity(RFShard shard, RFPhysic physics, float density)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x366B554", Offset = "0x366B554", VA = "0x366B554")]
	private static float MassLimit(float m)
	{
		return default(float);
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x366B7D0", Offset = "0x366B7D0", VA = "0x366B7D0")]
	public static void SetMassByParent(RFPhysic target, float targetSize, float parentMass, float parentSize)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x366B810", Offset = "0x366B810", VA = "0x366B810")]
	public static void SetDrag(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x366B904", Offset = "0x366B904", VA = "0x366B904")]
	public static void SetDrag(RFShard shard, float drag, float dragAngular)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x366B954", Offset = "0x366B954", VA = "0x366B954")]
	public static void SetFragmentsVelocity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x366BC74", Offset = "0x366BC74", VA = "0x366BC74")]
	public static void SetFragmentCollider(RayfireRigid scr, Mesh mesh)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x366BDB8", Offset = "0x366BDB8", VA = "0x366BDB8")]
	public static void SetRigidCollider(RayfireRigid scr, [Optional] Mesh mesh)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x366C96C", Offset = "0x366C96C", VA = "0x366C96C")]
	public static void SetRigidRootCollider(RayfireRigidRoot root, RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x366CB4C", Offset = "0x366CB4C", VA = "0x366CB4C")]
	public static void SetupMeshRootColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x366CCEC", Offset = "0x366CCEC", VA = "0x366CCEC")]
	public static void SetClusterCollidersByShards(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x366CE74", Offset = "0x366CE74", VA = "0x366CE74")]
	private static void CollidersRemoveNull(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x366D024", Offset = "0x366D024", VA = "0x366D024")]
	private static void SetShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x366D494", Offset = "0x366D494", VA = "0x366D494")]
	private static void SetDeepShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x366D594", Offset = "0x366D594", VA = "0x366D594")]
	public static void CollectClusterColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x366D668", Offset = "0x366D668", VA = "0x366D668")]
	private static void CollectDeepColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x366D7C4", Offset = "0x366D7C4", VA = "0x366D7C4")]
	public static void SetColliderMaterial(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x366DA14", Offset = "0x366DA14", VA = "0x366DA14")]
	public static void SetColliderMaterial(RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x366DAC4", Offset = "0x366DAC4", VA = "0x366DAC4")]
	public static void SetParticleColliderMaterial(List<RayfireDebris> debris)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x366DBE0", Offset = "0x366DBE0", VA = "0x366DBE0")]
	public static void SetColliderConvex(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x366DCD8", Offset = "0x366DCD8", VA = "0x366DCD8")]
	public static void DestroyColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x366DE5C", Offset = "0x366DE5C", VA = "0x366DE5C")]
	public static void SetPhysics(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x366DFB0", Offset = "0x366DFB0", VA = "0x366DFB0")]
	public static void SetPhysics(List<RFShard> shards, RFPhysic physic)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x366E338", Offset = "0x366E338", VA = "0x366E338")]
	public static void SetPhysics(RFShard shard, RFPhysic physic)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x366E540", Offset = "0x366E540", VA = "0x366E540")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RayfireRigid> rigids)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x366EF68", Offset = "0x366EF68", VA = "0x366EF68")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x366F08C", Offset = "0x366F08C", VA = "0x366F08C")]
	public static void SetIgnoreListShards(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x366EB9C", Offset = "0x366EB9C", VA = "0x366EB9C")]
	public static List<int> GetIgnoreListFast(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x366E984", Offset = "0x366E984", VA = "0x366E984")]
	public static List<int> GetIgnoreListShort(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x366ED1C", Offset = "0x366ED1C", VA = "0x366ED1C")]
	public static void IgnoreNeibCollision(List<RayfireRigid> rigids, List<int> pr)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x366F1FC", Offset = "0x366F1FC", VA = "0x366F1FC")]
	public static void IgnoreNeibCollision(List<RFShard> shards, List<int> pr)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x366BC68", Offset = "0x366BC68", VA = "0x366BC68")]
	public static bool IsNull(Rigidbody rb)
	{
		return default(bool);
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x366F430", Offset = "0x366F430", VA = "0x366F430")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEAD54", Offset = "0x1DEAD54")]
	public IEnumerator PhysicsDataCor(RayfireRigid scr)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200004B")]
public class RFReferenceDemolition
{
	[Token(Token = "0x2000099")]
	public enum ActionType
	{
		[Token(Token = "0x400053C")]
		Instantiate,
		[Token(Token = "0x400053D")]
		SetActive
	}

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject reference;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> randomList;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ActionType action;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool addRigid;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool inheritScale;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool inheritMaterials;

	[Token(Token = "0x17000015")]
	public bool HasRandomRefs
	{
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x3670B10", Offset = "0x3670B10", VA = "0x3670B10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x36709CC", Offset = "0x36709CC", VA = "0x36709CC")]
	public RFReferenceDemolition()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x3670A0C", Offset = "0x3670A0C", VA = "0x3670A0C")]
	public void CopyFrom(RFReferenceDemolition referenceDemolitionDml)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x3670B6C", Offset = "0x3670B6C", VA = "0x3670B6C")]
	public GameObject GetReference()
	{
		return null;
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x3670DD0", Offset = "0x3670DD0", VA = "0x3670DD0")]
	public static bool DemolishReference(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x367174C", Offset = "0x367174C", VA = "0x367174C")]
	private static GameObject GetInstance(RayfireRigid scr, GameObject refGo)
	{
		return null;
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x3671904", Offset = "0x3671904", VA = "0x3671904")]
	private static void InheritMaterials(RayfireRigid scr, GameObject instGo)
	{
	}
}
[Serializable]
[Token(Token = "0x200004C")]
public class RFReset
{
	[Token(Token = "0x200009A")]
	public enum PostDemolitionType
	{
		[Token(Token = "0x400053F")]
		DestroyWithDelay,
		[Token(Token = "0x4000540")]
		DeactivateToReset
	}

	[Token(Token = "0x200009B")]
	public enum MeshResetType
	{
		[Token(Token = "0x4000542")]
		Destroy = 0,
		[Token(Token = "0x4000543")]
		ReuseInputMesh = 2,
		[Token(Token = "0x4000544")]
		ReuseFragmentMeshes = 4
	}

	[Token(Token = "0x200009C")]
	public enum FragmentsResetType
	{
		[Token(Token = "0x4000546")]
		Destroy = 0,
		[Token(Token = "0x4000547")]
		Reuse = 2,
		[Token(Token = "0x4000548")]
		Preserve = 4
	}

	[Serializable]
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE910C", Offset = "0x1DE910C")]
	private sealed class <>c
	{
		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<RayfireRigid, bool> <>9__24_0;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<RayfireRigid, bool> <>9__24_1;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<RayfireRigid, bool> <>9__30_0;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<RayfireRigid, bool> <>9__30_1;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<RayfireRigid, bool> <>9__30_2;

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x3674A2C", Offset = "0x3674A2C", VA = "0x3674A2C")]
		public <>c()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x3674A34", Offset = "0x3674A34", VA = "0x3674A34")]
		internal bool <DestroyFragments>b__24_0(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x3674AA0", Offset = "0x3674AA0", VA = "0x3674AA0")]
		internal bool <DestroyFragments>b__24_1(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x3674B0C", Offset = "0x3674B0C", VA = "0x3674B0C")]
		internal bool <FragmentReuseState>b__30_0(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x3674B78", Offset = "0x3674B78", VA = "0x3674B78")]
		internal bool <FragmentReuseState>b__30_1(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x3674B9C", Offset = "0x3674B9C", VA = "0x3674B9C")]
		internal bool <FragmentReuseState>b__30_2(RayfireRigid t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool transform;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool damage;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool connectivity;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public PostDemolitionType action;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float destroyDelay;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public MeshResetType mesh;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FragmentsResetType fragments;

	[NonSerialized]
	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool toBeDestroyed;

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x3671AF0", Offset = "0x3671AF0", VA = "0x3671AF0")]
	public RFReset()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x3671B34", Offset = "0x3671B34", VA = "0x3671B34")]
	public void CopyFrom(RFReset reset, ObjectType objectType)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x3671B98", Offset = "0x3671B98", VA = "0x3671B98")]
	public static void ResetRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x3672548", Offset = "0x3672548", VA = "0x3672548")]
	public static void ResetFade(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x3671EA4", Offset = "0x3671EA4", VA = "0x3671EA4")]
	private static bool MeshRootReset(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x3672C60", Offset = "0x3672C60", VA = "0x3672C60")]
	private static bool MeshRootCleanup(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x3672DD8", Offset = "0x3672DD8", VA = "0x3672DD8")]
	public static void DestroyMeshRootParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x3672F40", Offset = "0x3672F40", VA = "0x3672F40")]
	public static void RigidRootReset(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x3673680", Offset = "0x3673680", VA = "0x3673680")]
	private static void ResetParentAndTm(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x3673420", Offset = "0x3673420", VA = "0x3673420")]
	private static void ResetSimType(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x36732B8", Offset = "0x36732B8", VA = "0x36732B8")]
	public static void DestroyRigidRootParticles(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x3673910", Offset = "0x3673910", VA = "0x3673910")]
	public static void DestroyClusters(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x36727D4", Offset = "0x36727D4", VA = "0x36727D4")]
	public static void ResetMeshDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x36741A4", Offset = "0x36741A4", VA = "0x36741A4")]
	private static void DestroyFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x3672984", Offset = "0x3672984", VA = "0x3672984")]
	public static void DestroyRigidParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x3673CF0", Offset = "0x3673CF0", VA = "0x3673CF0")]
	private static void ReuseFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x3674940", Offset = "0x3674940", VA = "0x3674940")]
	private static void PreserveFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x36728B8", Offset = "0x36728B8", VA = "0x36728B8")]
	private static void ResetClusterDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x3671D78", Offset = "0x3671D78", VA = "0x3671D78")]
	private static bool ObjectReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x3673A68", Offset = "0x3673A68", VA = "0x3673A68")]
	private static bool FragmentReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x36721BC", Offset = "0x36721BC", VA = "0x36721BC")]
	private static void RestoreTransform(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x3672300", Offset = "0x3672300", VA = "0x3672300")]
	public static void Reset(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x36728E4", Offset = "0x36728E4", VA = "0x36728E4")]
	public static void ResetSound(RayfireSound scr)
	{
	}
}
[Serializable]
[Token(Token = "0x200004D")]
public class RFRuntimeCaching
{
	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public CachingType type;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE98DC", Offset = "0x1DE98DC")]
	public int frames;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE98F8", Offset = "0x1DE98F8")]
	public int fragments;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool skipFirstDemolition;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[HideInInspector]
	public bool inProgress;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[HideInInspector]
	public bool wasUsed;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[HideInInspector]
	public bool stop;

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x3674E3C", Offset = "0x3674E3C", VA = "0x3674E3C")]
	public RFRuntimeCaching()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x3674E6C", Offset = "0x3674E6C", VA = "0x3674E6C")]
	public static List<int> GetBatchByFrames(int frames, int amount)
	{
		return null;
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x3674FEC", Offset = "0x3674FEC", VA = "0x3674FEC")]
	public static List<int> GetBatchByFragments(int fragments, int amount)
	{
		return null;
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x36750C4", Offset = "0x36750C4", VA = "0x36750C4")]
	public static List<int> GetMarkedElements(int batchInd, List<int> batchAmount)
	{
		return null;
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x36751F4", Offset = "0x36751F4", VA = "0x36751F4")]
	public static GameObject CreateTmRef(RayfireRigid rfScr)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200004E")]
public class RFMirrored
{
	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public PlaneType planeType;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool noPoints;

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x317FA38", Offset = "0x317FA38", VA = "0x317FA38")]
	public RFMirrored()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x3179108", Offset = "0x3179108", VA = "0x3179108")]
	public static List<Vector3> GetMirroredPointCLoud(RFMirrored mirror, Transform tm, int seed, Bounds bound)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200004F")]
public class RFCustom
{
	[Token(Token = "0x200009E")]
	public enum RFPointCloudSourceType
	{
		[Token(Token = "0x4000550")]
		ChildrenTransform = 4,
		[Token(Token = "0x4000551")]
		TransformList = 8,
		[Token(Token = "0x4000552")]
		Vector3List = 12
	}

	[Token(Token = "0x200009F")]
	public enum RFPointCloudUseType
	{
		[Token(Token = "0x4000554")]
		VolumePoints = 4,
		[Token(Token = "0x4000555")]
		PointCloud = 12
	}

	[Token(Token = "0x20000A0")]
	public enum RFModifierType
	{
		[Token(Token = "0x4000557")]
		None = 0,
		[Token(Token = "0x4000558")]
		Splinters = 3,
		[Token(Token = "0x4000559")]
		Slabs = 6
	}

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFPointCloudSourceType source;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public RFPointCloudUseType useAs;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int amount;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float radius;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool enable;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float size;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Transform> transforms;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> vector3;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool noPoints;

	[NonSerialized]
	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Vector3> inputPoints;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Vector3> outputPoints;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Vector3> inBoundPoints;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<Vector3> outBoundPoints;

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x36C7448", Offset = "0x36C7448", VA = "0x36C7448")]
	public RFCustom()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x36C7498", Offset = "0x36C7498", VA = "0x36C7498")]
	public RFCustom(RFCustom src)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x36C7510", Offset = "0x36C7510", VA = "0x36C7510")]
	public static List<Vector3> GetCustomPointCLoud(RFCustom custom, Transform tm, int seed, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x36C75E0", Offset = "0x36C75E0", VA = "0x36C75E0")]
	private static void SetCustomInputCloud(RFCustom custom, Transform tm)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x36C7868", Offset = "0x36C7868", VA = "0x36C7868")]
	private static void SetCustomOutputCloud(RFCustom custom, int seed, Bounds bound)
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x36C7ADC", Offset = "0x36C7ADC", VA = "0x36C7ADC")]
	private static void SetCustomBoundPoints(RFCustom custom, Bounds bound)
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x36C7CB8", Offset = "0x36C7CB8", VA = "0x36C7CB8")]
	private static Vector3 RandomPointInRadius(Vector3 point, float radius)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x36C7D90", Offset = "0x36C7D90", VA = "0x36C7D90")]
	private static Vector3 RandomVector()
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000050")]
public static class RFFragment
{
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE911C", Offset = "0x1DE911C")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RFSlice slices;

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x3179190", Offset = "0x3179190", VA = "0x3179190")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x3179454", Offset = "0x3179454", VA = "0x3179454")]
		internal Vector3 <SetSlices>b__1(Transform t)
		{
			return default(Vector3);
		}
	}

	[Serializable]
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE912C", Offset = "0x1DE912C")]
	private sealed class <>c
	{
		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Transform, Vector3> <>9__31_0;

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x3179430", Offset = "0x3179430", VA = "0x3179430")]
		public <>c()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x3179438", Offset = "0x3179438", VA = "0x3179438")]
		internal Vector3 <SetSlices>b__31_0(Transform t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool silentMode;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<Mesh> meshListStatic;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static List<Vector3> pivotListStatic;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static List<Dictionary<int, int>> subIdsListStatic;

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x31746FC", Offset = "0x31746FC", VA = "0x31746FC")]
	public static void CacheMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x3175BC8", Offset = "0x3175BC8", VA = "0x3175BC8")]
	private static void RemovePlanar(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x3175E78", Offset = "0x3175E78", VA = "0x3175E78")]
	private static void RemoveBySize(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scr)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x316E67C", Offset = "0x316E67C", VA = "0x316E67C")]
	public static bool InputMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x31762E8", Offset = "0x31762E8", VA = "0x31762E8")]
	private static bool SetRigidShatter(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x3176CF0", Offset = "0x3176CF0", VA = "0x3176CF0")]
	public static void CacheMeshesInst(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x316E754", Offset = "0x316E754", VA = "0x316E754")]
	public static void CacheMeshesMult(Transform tmSaved, ref List<Mesh> meshesList, ref List<Vector3> pivotsList, ref List<RFDictionary> subList, RayfireRigid scrRigid, List<int> batchAmount, int batchInd)
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x3176F14", Offset = "0x3176F14", VA = "0x3176F14")]
	private static void FinalCacheMeshes(ref Mesh[] meshes, RayfireRigid scrRigid, bool successState)
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x3176C54", Offset = "0x3176C54", VA = "0x3176C54")]
	private static Mesh GetDemolitionMesh(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x3174CF0", Offset = "0x3174CF0", VA = "0x3174CF0")]
	private static Mesh GetDemolitionMesh(RayfireShatter scr)
	{
		return null;
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x317714C", Offset = "0x317714C", VA = "0x317714C")]
	public static void SliceMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scr, List<Vector3> sliceData)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x31756E0", Offset = "0x31756E0", VA = "0x31756E0")]
	private static bool Compute(int shatterMode, RFShatter shatter, Transform tm, ref Mesh[] meshes, ref Vector3[] pivots, Mesh mesh, int innerSubId, ref List<Dictionary<int, int>> subIds, UnityEngine.Object obj, [Optional] List<int> markedElements)
	{
		return default(bool);
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x3174C1C", Offset = "0x3174C1C", VA = "0x3174C1C")]
	private static int GetShatterMode([Optional] RayfireShatter scrShatter)
	{
		return default(int);
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x3177690", Offset = "0x3177690", VA = "0x3177690")]
	private static bool EmptyMeshState(Mesh[] meshes)
	{
		return default(bool);
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x3175150", Offset = "0x3175150", VA = "0x3175150")]
	private static void SetShatterFragmentProperties(RFShatter shatter, RayfireShatter scrSh)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x317649C", Offset = "0x317649C", VA = "0x317649C")]
	private static void SetRigidFragmentProperties(RFShatter shatter, RayfireShatter scrSh, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x3174DD8", Offset = "0x3174DD8", VA = "0x3174DD8")]
	private static RFShatter SetShatter(FragmentMode fragmentMode, int shatterMode, Mesh mesh, Transform transform, RFSurface interior, bool decompose, bool delete_collinear = false, int seed = 1, bool pre_cap = true, bool remove_cap_faces = false, bool remove_double_faces = true, bool exclude_inside = false, bool post_normals_smooth = false, int min_bbox_diag_size_filter_perc = 3, int meshRemoveMinFaceFilter = 4, bool postWeld = true)
	{
		return null;
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x3178AAC", Offset = "0x3178AAC", VA = "0x3178AAC")]
	private static void SetShatterEditorMode(RFShatter shatter, float min_bbox_diag_size_filter, bool pre_cap, bool remove_cap_faces, bool remove_double_faces, bool exclude_inside, int meshRemoveMinFaceFilter)
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x3178C1C", Offset = "0x3178C1C", VA = "0x3178C1C")]
	private static void SetShatterRuntimeMode(RFShatter shatter, bool pre_cap, int meshRemoveMinFaceFilter)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x3178CF4", Offset = "0x3178CF4", VA = "0x3178CF4")]
	private static void SetCustomUV(RFShatter shatter, RFSurface interior)
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x3178DAC", Offset = "0x3178DAC", VA = "0x3178DAC")]
	private static void SetCustomColor(RFShatter shatter, RFSurface interior)
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x31778E0", Offset = "0x31778E0", VA = "0x31778E0")]
	private static void SetVoronoi(RFShatter shatter, int numFragments, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x3177A3C", Offset = "0x3177A3C", VA = "0x3177A3C")]
	private static void SetSplinters(RFShatter shatter, int numFragments, RFSplinters splint, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x3177BAC", Offset = "0x3177BAC", VA = "0x3177BAC")]
	private static void SetSlabs(RFShatter shatter, int numFragments, RFSplinters slabs, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x3177D1C", Offset = "0x3177D1C", VA = "0x3177D1C")]
	private static void SetRadial(RFShatter shatter, RFRadial radial, Transform tm, Vector3 centerPos, Quaternion centerDirection)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x3177FAC", Offset = "0x3177FAC", VA = "0x3177FAC")]
	private static void SetCustom(RFShatter shatter, RFCustom custom, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x3179054", Offset = "0x3179054", VA = "0x3179054")]
	private static void SetMirrored(RFShatter shatter, RFMirrored mirror, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x317809C", Offset = "0x317809C", VA = "0x317809C")]
	private static void SetSlices(RFShatter shatter, Transform tm, RFSlice slices)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x317837C", Offset = "0x317837C", VA = "0x317837C")]
	private static void SetBricks(RFShatter shatter, Transform tm, RFBricks bricks, Bounds bounds)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x317862C", Offset = "0x317862C", VA = "0x317862C")]
	private static void SetVoxels(RFShatter shatter, Transform tm, RFVoxels voxels, Bounds bounds)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x3179198", Offset = "0x3179198", VA = "0x3179198")]
	private static float BoolToFloat(bool v)
	{
		return default(float);
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x3178714", Offset = "0x3178714", VA = "0x3178714")]
	private static void SetTet(RFShatter shatter, Bounds bounds, RFTets tets)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x3178A4C", Offset = "0x3178A4C", VA = "0x3178A4C")]
	private static void SetDecompose(RFShatter shatter)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x3177710", Offset = "0x3177710", VA = "0x3177710")]
	private static void SetClusters(RFShatter shatter, RFShatterCluster gluing)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x3178E2C", Offset = "0x3178E2C", VA = "0x3178E2C")]
	private static void SetStretching(RFShatter shatter, AxisType axis, float strength, FragType fragType)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x3178F98", Offset = "0x3178F98", VA = "0x3178F98")]
	private static Vector3 DirectionAxis(AxisType axisType)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x31791AC", Offset = "0x31791AC", VA = "0x31791AC")]
	public static void RescaleMesh(Mesh mesh, float scale)
	{
	}
}
[Serializable]
[Token(Token = "0x2000051")]
public class RFMeshExport
{
	[Token(Token = "0x20000A3")]
	public enum MeshExportType
	{
		[Token(Token = "0x400055E")]
		LastFragments = 0,
		[Token(Token = "0x400055F")]
		Children = 3
	}

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public MeshExportType source;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string suffix;

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x317F9D8", Offset = "0x317F9D8", VA = "0x317F9D8")]
	public RFMeshExport()
	{
	}
}
[Serializable]
[Token(Token = "0x2000052")]
public class RFShatterAdvanced
{
	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int seed;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool decompose;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool removeCollinear;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	public bool copyComponents;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	public bool postWeld;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool smooth;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool inputPrecap;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool outputPrecap;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool removeDoubleFaces;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int elementSizeThreshold;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool combineChildren;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool inner;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool planar;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int relativeSize;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float absoluteSize;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool sizeLimitation;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sizeAmount;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool vertexLimitation;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int vertexAmount;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool triangleLimitation;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int triangleAmount;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float planarThreshold;

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x36783DC", Offset = "0x36783DC", VA = "0x36783DC")]
	public RFShatterAdvanced()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x3678450", Offset = "0x3678450", VA = "0x3678450")]
	public RFShatterAdvanced(RFShatterAdvanced src)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x366C268", Offset = "0x366C268", VA = "0x366C268")]
	public static bool IsCoplanar(Mesh mesh, float threshold)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000053")]
public class RFSurface
{
	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1DE9950", Offset = "0x1DE9950")]
	public Material iMat;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1DE9988", Offset = "0x1DE9988")]
	public Material oMat;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1DE99C0", Offset = "0x1DE99C0")]
	public float mScl;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool uvE;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 uvC;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool cE;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Color cC;

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x367E240", Offset = "0x367E240", VA = "0x367E240")]
	public RFSurface()
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x367E294", Offset = "0x367E294", VA = "0x367E294")]
	public void CopyFrom(RFSurface interior)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x367E304", Offset = "0x367E304", VA = "0x367E304")]
	public static void SetMaterial(List<RFDictionary> origSubMeshIdsRF, Material[] sharedMaterials, RFSurface interior, MeshRenderer targetRend, int i, int amount)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x367E574", Offset = "0x367E574", VA = "0x367E574")]
	public static int SetInnerSubId(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x367E6F0", Offset = "0x367E6F0", VA = "0x367E6F0")]
	public static int SetInnerSubId(RayfireShatter scr)
	{
		return default(int);
	}
}
[Token(Token = "0x2000054")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE86FC", Offset = "0x1DE86FC")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE86FC", Offset = "0x1DE86FC")]
public class RayfireActivator : MonoBehaviour
{
	[Token(Token = "0x20000A4")]
	public enum ActivationType
	{
		[Token(Token = "0x4000561")]
		OnTriggerEnter,
		[Token(Token = "0x4000562")]
		OnTriggerExit,
		[Token(Token = "0x4000563")]
		OnCollision
	}

	[Token(Token = "0x20000A5")]
	public enum AnimationType
	{
		[Token(Token = "0x4000565")]
		ByGlobalPositionList = 0,
		[Token(Token = "0x4000566")]
		ByStaticLine = 1,
		[Token(Token = "0x4000567")]
		ByDynamicLine = 2,
		[Token(Token = "0x4000568")]
		ByLocalPositionList = 5
	}

	[Token(Token = "0x20000A6")]
	public enum GizmoType
	{
		[Token(Token = "0x400056A")]
		Box = 1,
		[Token(Token = "0x400056B")]
		Sphere = 0,
		[Token(Token = "0x400056C")]
		Collider = 2,
		[Token(Token = "0x400056D")]
		ParticleSystem = 5
	}

	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE913C", Offset = "0x1DE913C")]
	private sealed class <DelayedActivationCor>d__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid rigid;

		[Token(Token = "0x17000061")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x3681054", Offset = "0x3681054", VA = "0x3681054", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x36810BC", Offset = "0x36810BC", VA = "0x36810BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x367F7A4", Offset = "0x367F7A4", VA = "0x367F7A4")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x3680F48", Offset = "0x3680F48", VA = "0x3680F48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x3680F4C", Offset = "0x3680F4C", VA = "0x3680F4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x368105C", Offset = "0x368105C", VA = "0x368105C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE914C", Offset = "0x1DE914C")]
	private sealed class <DelayedClusterCor>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid rigid;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Collider coll;

		[Token(Token = "0x17000063")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x3681408", Offset = "0x3681408", VA = "0x3681408", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x3681470", Offset = "0x3681470", VA = "0x3681470", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x367F7D0", Offset = "0x367F7D0", VA = "0x367F7D0")]
		[DebuggerHidden]
		public <DelayedClusterCor>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x3681240", Offset = "0x3681240", VA = "0x3681240", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x3681244", Offset = "0x3681244", VA = "0x3681244", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x3681410", Offset = "0x3681410", VA = "0x3681410", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE915C", Offset = "0x1DE915C")]
	private sealed class <DelayedActivationCor>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot rigidRoot;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Collider coll;

		[Token(Token = "0x17000065")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x36811D0", Offset = "0x36811D0", VA = "0x36811D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x3681238", Offset = "0x3681238", VA = "0x3681238", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x367FBCC", Offset = "0x367FBCC", VA = "0x367FBCC")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x36810C4", Offset = "0x36810C4", VA = "0x36810C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x36810C8", Offset = "0x36810C8", VA = "0x36810C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x36811D8", Offset = "0x36811D8", VA = "0x36811D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE916C", Offset = "0x1DE916C")]
	private sealed class <AnimationCor>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x17000067")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x3680ED8", Offset = "0x3680ED8", VA = "0x3680ED8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x3680F40", Offset = "0x3680F40", VA = "0x3680F40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x368040C", Offset = "0x368040C", VA = "0x368040C")]
		[DebuggerHidden]
		public <AnimationCor>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x3680AB0", Offset = "0x3680AB0", VA = "0x3680AB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x3680AB4", Offset = "0x3680AB4", VA = "0x3680AB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x3680EE0", Offset = "0x3680EE0", VA = "0x3680EE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GizmoType gizmoType;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sphereRadius;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 boxSize;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool checkRigid;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool checkRigidRoot;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ActivationType type;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float delay;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool demolishCluster;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool apply;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 velocity;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 spin;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public ForceMode mode;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool coord;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool showAnimation;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float duration;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float scaleAnimation;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public AnimationType positionAnimation;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public LineRenderer line;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<Vector3> positionList;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool showGizmo;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Collider activatorCollider;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ParticleSystem ps;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<ParticleCollisionEvent> collisionEvents;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool animating;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float pathRatio;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float lineLength;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<float> checkpoints;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float delta;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float deltaRatioStep;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float distDeltaStep;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private float distRatio;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float timePassed;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int activeSegment;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Vector3 positionStart;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private Vector3 scaleStart;

	[Token(Token = "0x17000016")]
	public bool ByPositions
	{
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x36809B8", Offset = "0x36809B8", VA = "0x36809B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000017")]
	public bool ByLine
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x367FD94", Offset = "0x367FD94", VA = "0x367FD94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x367EB9C", Offset = "0x367EB9C", VA = "0x367EB9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x367EFFC", Offset = "0x367EFFC", VA = "0x367EFFC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x367F0A8", Offset = "0x367F0A8", VA = "0x367F0A8")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x367F1E8", Offset = "0x367F1E8", VA = "0x367F1E8")]
	private void OnTriggerEnter(Collider coll)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x367F1F8", Offset = "0x367F1F8", VA = "0x367F1F8")]
	private void OnTriggerExit(Collider coll)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x367EC14", Offset = "0x367EC14", VA = "0x367EC14")]
	private void SetCollider()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x367EE44", Offset = "0x367EE44", VA = "0x367EE44")]
	private void SetParticleSystem()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x367F058", Offset = "0x367F058", VA = "0x367F058")]
	private void ActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x367F20C", Offset = "0x367F20C", VA = "0x367F20C")]
	private void RigidListActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x367F660", Offset = "0x367F660", VA = "0x367F660")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEADB8", Offset = "0x1DEADB8")]
	private IEnumerator DelayedActivationCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x367F6F8", Offset = "0x367F6F8", VA = "0x367F6F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEAE1C", Offset = "0x1DEAE1C")]
	private IEnumerator DelayedClusterCor(RayfireRigid rigid, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x367F618", Offset = "0x367F618", VA = "0x367F618")]
	private void Activate(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x367F44C", Offset = "0x367F44C", VA = "0x367F44C")]
	private void RigidRootActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x367FB20", Offset = "0x367FB20", VA = "0x367FB20")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEAE80", Offset = "0x1DEAE80")]
	private IEnumerator DelayedActivationCor(RayfireRigidRoot rigidRoot, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x367F984", Offset = "0x367F984", VA = "0x367F984")]
	private void ActivateCollider(RayfireRigidRoot rigidRoot, Collider coll)
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x367F7FC", Offset = "0x367F7FC", VA = "0x367F7FC")]
	private void AddForce(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x367FBF8", Offset = "0x367FBF8", VA = "0x367FBF8")]
	public void TriggerAnimation()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x367FCCC", Offset = "0x367FCCC", VA = "0x367FCCC")]
	private void SetAnimation()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x367FDA8", Offset = "0x367FDA8", VA = "0x367FDA8")]
	private void SetWorldPointsByLine()
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x367FF88", Offset = "0x367FF88", VA = "0x367FF88")]
	private void SetWorldPointsByLocal()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x3680170", Offset = "0x3680170", VA = "0x3680170")]
	private void SetCheckPoints()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x367FD18", Offset = "0x367FD18", VA = "0x367FD18")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEAEE4", Offset = "0x1DEAEE4")]
	private IEnumerator AnimationCor()
	{
		return null;
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x3680438", Offset = "0x3680438", VA = "0x3680438")]
	private int GetSegment(float ration)
	{
		return default(int);
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x3680544", Offset = "0x3680544", VA = "0x3680544")]
	private void ResetData()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x36805B0", Offset = "0x36805B0", VA = "0x36805B0")]
	public void StopAnimation()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x36805B8", Offset = "0x36805B8", VA = "0x36805B8")]
	public void ResetAnimation()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x36805F8", Offset = "0x36805F8", VA = "0x36805F8")]
	public void AddPosition(Vector3 newPos)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x36808E8", Offset = "0x36808E8", VA = "0x36808E8")]
	public void SetGizmoType(GizmoType gizmo)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x36809D4", Offset = "0x36809D4", VA = "0x36809D4")]
	public RayfireActivator()
	{
	}
}
[Token(Token = "0x2000055")]
public class RFSliceData
{
	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 planePos;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 planeDir;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 swingDir;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float swingStr;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float force;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float damage;

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x3678DE4", Offset = "0x3678DE4", VA = "0x3678DE4")]
	public RFSliceData()
	{
	}
}
[Token(Token = "0x2000056")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE875C", Offset = "0x1DE875C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE875C", Offset = "0x1DE875C")]
public class RayfireBlade : MonoBehaviour
{
	[Token(Token = "0x20000AB")]
	public enum CutType
	{
		[Token(Token = "0x4000580")]
		Enter,
		[Token(Token = "0x4000581")]
		Exit,
		[Token(Token = "0x4000582")]
		EnterExit
	}

	[Token(Token = "0x20000AC")]
	public enum ActionType
	{
		[Token(Token = "0x4000584")]
		Slice,
		[Token(Token = "0x4000585")]
		Demolish
	}

	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE917C", Offset = "0x1DE917C")]
	private sealed class <CooldownCor>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireBlade <>4__this;

		[Token(Token = "0x17000069")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x2BE0814", Offset = "0x2BE0814", VA = "0x2BE0814", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x2BE087C", Offset = "0x2BE087C", VA = "0x2BE087C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2BE06FC", Offset = "0x2BE06FC", VA = "0x2BE06FC")]
		[DebuggerHidden]
		public <CooldownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x2BE0728", Offset = "0x2BE0728", VA = "0x2BE0728", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2BE072C", Offset = "0x2BE072C", VA = "0x2BE072C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2BE081C", Offset = "0x2BE081C", VA = "0x2BE081C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ActionType actionType;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public CutType onTrigger;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PlaneType sliceType;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float force;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool affectInactive;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float damage;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool skin;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float cooldown;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int mask;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string tagFilter;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<GameObject> targets;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RayfireRigid rigid;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform transForm;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3[] enterPlane;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3[] exitPlane;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Collider colLider;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3[] slicePlanes;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool coolDownState;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private RFSliceData sliceData;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 posEnter;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 posExit;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RFSliceEvent sliceEvent;

	[Token(Token = "0x17000018")]
	public bool HasTargets
	{
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x3682210", Offset = "0x3682210", VA = "0x3682210")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x3681478", Offset = "0x3681478", VA = "0x3681478")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x368147C", Offset = "0x368147C", VA = "0x368147C")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x3681670", Offset = "0x3681670", VA = "0x3681670")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x368174C", Offset = "0x368174C", VA = "0x368174C")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x3681674", Offset = "0x3681674", VA = "0x3681674")]
	private void TriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x3681750", Offset = "0x3681750", VA = "0x3681750")]
	private void TriggerExit(Collider col)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x3681C88", Offset = "0x3681C88", VA = "0x3681C88")]
	private void Demolish(GameObject targetObject)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x3681EB4", Offset = "0x3681EB4", VA = "0x3681EB4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEAF48", Offset = "0x1DEAF48")]
	private IEnumerator CooldownCor()
	{
		return null;
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x3681F30", Offset = "0x3681F30", VA = "0x3681F30")]
	private void SetCooldown(bool state)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x3681DA8", Offset = "0x3681DA8", VA = "0x3681DA8")]
	private bool FilterCheck(GameObject targetObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x3681F58", Offset = "0x3681F58", VA = "0x3681F58")]
	public void SliceTarget()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x3681AC0", Offset = "0x3681AC0", VA = "0x3681AC0")]
	private void Slice(GameObject targetObject, Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x3681E68", Offset = "0x3681E68", VA = "0x3681E68")]
	private bool ApplyDamage(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x36819C8", Offset = "0x36819C8", VA = "0x36819C8")]
	private Vector3[] GetSlicePlane()
	{
		return null;
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x368206C", Offset = "0x368206C", VA = "0x368206C")]
	private RFSliceData GetSliceData()
	{
		return null;
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x3681F3C", Offset = "0x3681F3C", VA = "0x3681F3C")]
	private bool LayerCheck(int layerId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x368226C", Offset = "0x368226C", VA = "0x368226C")]
	public RayfireBlade()
	{
	}
}
[Token(Token = "0x2000057")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE87BC", Offset = "0x1DE87BC")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE87BC", Offset = "0x1DE87BC")]
public class RayfireBomb : MonoBehaviour
{
	[Token(Token = "0x20000AE")]
	public enum RangeType
	{
		[Token(Token = "0x400058A")]
		Spherical
	}

	[Token(Token = "0x20000AF")]
	public enum FadeType
	{
		[Token(Token = "0x400058C")]
		Linear = 0,
		[Token(Token = "0x400058D")]
		Exponential = 1,
		[Token(Token = "0x400058E")]
		ByCurve = 3,
		[Token(Token = "0x400058F")]
		None = 2
	}

	[Serializable]
	[Token(Token = "0x20000B0")]
	public class Projectile
	{
		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 positionPivot;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 positionClosest;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fade;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Rigidbody rb;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RayfireRigid rigid;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Quaternion rotation;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RFShard shard;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RayfireRigidRoot rigidRoot;

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2BE224C", Offset = "0x2BE224C", VA = "0x2BE224C")]
		public Projectile()
		{
		}
	}

	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE918C", Offset = "0x1DE918C")]
	private sealed class <ExplodeCor>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireBomb <>4__this;

		[Token(Token = "0x1700006B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x2BE2B08", Offset = "0x2BE2B08", VA = "0x2BE2B08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x2BE2B70", Offset = "0x2BE2B70", VA = "0x2BE2B70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x2BE0BE4", Offset = "0x2BE0BE4", VA = "0x2BE0BE4")]
		[DebuggerHidden]
		public <ExplodeCor>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x2BE2A44", Offset = "0x2BE2A44", VA = "0x2BE2A44", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x2BE2A48", Offset = "0x2BE2A48", VA = "0x2BE2A48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x2BE2B10", Offset = "0x2BE2B10", VA = "0x2BE2B10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool showGizmo;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RangeType rangeType;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FadeType fadeType;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int deletion;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float strength;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int variation;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int chaos;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool forceByMass;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool affectInactive;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool affectKinematic;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float heightOffset;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float delay;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool atStart;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool destroy;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
	public bool applyDamage;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float damageValue;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve curve;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool play;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float volume;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioClip clip;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFExplosionEvent explosionEvent;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public Vector3 bombPosition;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public Vector3 explPosition;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public Collider[] colliders;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public int mask;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public string tagFilter;

	[NonSerialized]
	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<Projectile> projectiles;

	[NonSerialized]
	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private List<Projectile> deletionProjectiles;

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x2BE0884", Offset = "0x2BE0884", VA = "0x2BE0884")]
	private void Awake()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x2BE090C", Offset = "0x2BE090C", VA = "0x2BE090C")]
	private void Start()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x2BE09A8", Offset = "0x2BE09A8", VA = "0x2BE09A8")]
	public void CopyFrom(RayfireBomb scr)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x2BE0950", Offset = "0x2BE0950", VA = "0x2BE0950")]
	public void Explode(float delayLoc)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x2BE0B68", Offset = "0x2BE0B68", VA = "0x2BE0B68")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEAFAC", Offset = "0x1DEAFAC")]
	private IEnumerator ExplodeCor()
	{
		return null;
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x2BE0A50", Offset = "0x2BE0A50", VA = "0x2BE0A50")]
	private void Explode()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x2BE18A4", Offset = "0x2BE18A4", VA = "0x2BE18A4")]
	private void PlayAudio()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x2BE0D38", Offset = "0x2BE0D38", VA = "0x2BE0D38")]
	private bool Setup()
	{
		return default(bool);
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x2BE0888", Offset = "0x2BE0888", VA = "0x2BE0888")]
	private void ClearLists()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x2BE1F80", Offset = "0x2BE1F80", VA = "0x2BE1F80")]
	public void Restore()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x2BE1FA8", Offset = "0x2BE1FA8", VA = "0x2BE1FA8")]
	private static void RestoreProjectiles(List<Projectile> prj)
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x2BE0C10", Offset = "0x2BE0C10", VA = "0x2BE0C10")]
	private void SetPositions()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x2BE1970", Offset = "0x2BE1970", VA = "0x2BE1970")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x2BE19BC", Offset = "0x2BE19BC", VA = "0x2BE19BC")]
	private void SetProjectiles()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x2BE0DA8", Offset = "0x2BE0DA8", VA = "0x2BE0DA8")]
	private bool SetRigidDamage()
	{
		return default(bool);
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x2BE0F74", Offset = "0x2BE0F74", VA = "0x2BE0F74")]
	private void Deletion()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x2BE128C", Offset = "0x2BE128C", VA = "0x2BE128C")]
	private void Activate()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x2BE1614", Offset = "0x2BE1614", VA = "0x2BE1614")]
	private void SetForce()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x2BE2254", Offset = "0x2BE2254", VA = "0x2BE2254")]
	private float Fade(Vector3 bombPos, Vector3 fragPos)
	{
		return default(float);
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x2BE2640", Offset = "0x2BE2640", VA = "0x2BE2640")]
	private Vector3 Vector(Projectile projectile)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x2BE272C", Offset = "0x2BE272C", VA = "0x2BE272C")]
	public RayfireBomb()
	{
	}
}
[Token(Token = "0x2000058")]
[SelectionBase]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE881C", Offset = "0x1DE881C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE881C", Offset = "0x1DE881C")]
public class RayfireCluster : MonoBehaviour
{
	[Token(Token = "0x20000B2")]
	public enum ClusterType
	{
		[Token(Token = "0x400059C")]
		ByPointCloud,
		[Token(Token = "0x400059D")]
		BySharedArea
	}

	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE919C", Offset = "0x1DE919C")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RFShard biggestShard;

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x2BE5CB8", Offset = "0x2BE5CB8", VA = "0x2BE5CB8")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x2BE6F24", Offset = "0x2BE6F24", VA = "0x2BE6F24")]
		internal bool <ClusterizeRangeShards>b__0(RFShard t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE91AC", Offset = "0x1DE91AC")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RFCluster biggestCluster;

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x2BE5FE4", Offset = "0x2BE5FE4", VA = "0x2BE5FE4")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x2BE6F54", Offset = "0x2BE6F54", VA = "0x2BE6F54")]
		internal bool <ClusterizeRangeClusters>b__0(RFCluster t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9A58", Offset = "0x1DE9A58")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1DE9A58", Offset = "0x1DE9A58")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9A58", Offset = "0x1DE9A58")]
	public ClusterType type;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE9AC8", Offset = "0x1DE9AC8")]
	public int depth;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE9AE0", Offset = "0x1DE9AE0")]
	public int seed;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE9AFC", Offset = "0x1DE9AFC")]
	public int smoothPass;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1DE9B14", Offset = "0x1DE9B14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9B14", Offset = "0x1DE9B14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE9B14", Offset = "0x1DE9B14")]
	public int baseAmount;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE9B8C", Offset = "0x1DE9B8C")]
	public int depthAmount;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConnectivityType connectivity;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1DE9BA8", Offset = "0x1DE9BA8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9BA8", Offset = "0x1DE9BA8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE9BA8", Offset = "0x1DE9BA8")]
	public int minimumAmount;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE9C1C", Offset = "0x1DE9C1C")]
	public int maximumAmount;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public bool showGizmo;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	[HideInInspector]
	public bool colorPreview;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	[HideInInspector]
	public bool scalePreview;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Color wireColor;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public float previewScale;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public List<RFCluster> allClusters;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public List<RFShard> allShards;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int clusterId;

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x2BE2B78", Offset = "0x2BE2B78", VA = "0x2BE2B78")]
	public void Extract()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x2BE2D80", Offset = "0x2BE2D80", VA = "0x2BE2D80")]
	public void Clusterize()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x2BE2E08", Offset = "0x2BE2E08", VA = "0x2BE2E08")]
	private void ClusterizeVoronoi()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x2BE36A4", Offset = "0x2BE36A4", VA = "0x2BE36A4")]
	private List<RFCluster> ClusterizeClusterByAmount(RFCluster parentCluster, int amount)
	{
		return null;
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x2BE4B74", Offset = "0x2BE4B74", VA = "0x2BE4B74")]
	private void ConnectivityCheck(List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x2BE3020", Offset = "0x2BE3020", VA = "0x2BE3020")]
	private void ClusterizeRange()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x2BE55DC", Offset = "0x2BE55DC", VA = "0x2BE55DC")]
	private List<RFCluster> ClusterizeRangeShards(RFCluster mainCluster)
	{
		return null;
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x2BE59A4", Offset = "0x2BE59A4", VA = "0x2BE59A4")]
	private List<RFCluster> ClusterizeRangeClusters(RFCluster parentCluster)
	{
		return null;
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x2BE4314", Offset = "0x2BE4314", VA = "0x2BE4314")]
	private static void RoughnessPassShards(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x2BE61DC", Offset = "0x2BE61DC", VA = "0x2BE61DC")]
	private void RoughnessPassClusters(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x2BE412C", Offset = "0x2BE412C", VA = "0x2BE412C")]
	private void SetSoloShardToCluster(List<RFShard> soloShards, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x2BE6A5C", Offset = "0x2BE6A5C", VA = "0x2BE6A5C")]
	private int GetNeibIndArea(RFShard shard, [Optional] List<RFShard> shardList)
	{
		return default(int);
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x2BE5FEC", Offset = "0x2BE5FEC", VA = "0x2BE5FEC")]
	private void SetSoloClusterToCluster(List<RFCluster> soloClusters, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x2BE357C", Offset = "0x2BE357C", VA = "0x2BE357C")]
	private RFCluster SetupMainCluster(ConnectivityType connect)
	{
		return null;
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x2BE3DA8", Offset = "0x2BE3DA8", VA = "0x2BE3DA8")]
	private void SetClusterNames()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x2BE5408", Offset = "0x2BE5408", VA = "0x2BE5408")]
	private void CreateRoot(RFCluster childCluster, Transform parentTm)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x2BE6B8C", Offset = "0x2BE6B8C", VA = "0x2BE6B8C")]
	private Bounds GetShardsBound(List<RFShard> shards, [Optional] List<RFCluster> clusters)
	{
		return default(Bounds);
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x2BE5CC0", Offset = "0x2BE5CC0", VA = "0x2BE5CC0")]
	private static RFShard GetNeibShardArea(List<RFShard> shardGroup, List<RFShard> shardList)
	{
		return null;
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x2BE3F9C", Offset = "0x2BE3F9C", VA = "0x2BE3F9C")]
	private List<Vector3> VoronoiPointCloud(Bounds bound, int am)
	{
		return null;
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x2BE6E14", Offset = "0x2BE6E14", VA = "0x2BE6E14")]
	public RayfireCluster()
	{
	}
}
[Token(Token = "0x2000059")]
public class RFCombineMesh
{
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE91BC", Offset = "0x1DE91BC")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transForm;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Transform> transList;

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x36C5F10", Offset = "0x36C5F10", VA = "0x36C5F10")]
		public <>c__DisplayClass7_0()
		{
		}
	}

	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE91CC", Offset = "0x1DE91CC")]
	private sealed class <>c__DisplayClass7_1
	{
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass7_0 CS$<>8__locals1;

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x36C5F18", Offset = "0x36C5F18", VA = "0x36C5F18")]
		public <>c__DisplayClass7_1()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x36C6BD8", Offset = "0x36C6BD8", VA = "0x36C6BD8")]
		internal Vector3 <GetCombinedMesh>b__0(Vector3 t)
		{
			return default(Vector3);
		}
	}

	[Serializable]
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE91DC", Offset = "0x1DE91DC")]
	private sealed class <>c
	{
		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Vector3, Vector3> <>9__7_1;

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x36C6AE0", Offset = "0x36C6AE0", VA = "0x36C6AE0")]
		public <>c()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x36C6AE8", Offset = "0x36C6AE8", VA = "0x36C6AE8")]
		internal Vector3 <GetCombinedMesh>b__7_1(Vector3 o)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE91EC", Offset = "0x1DE91EC")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Material> allMaterials;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<Material, int> <>9__0;

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x36C6A70", Offset = "0x36C6A70", VA = "0x36C6A70")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x36C6B70", Offset = "0x36C6B70", VA = "0x36C6B70")]
		internal int <GetMatIdList>b__0(Material t)
		{
			return default(int);
		}
	}

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<int> trianglesSubId;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<List<int>> triangles;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Vector3> vertices;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Vector3> normals;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Vector2> uvs;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Vector4> tangents;

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x36C5738", Offset = "0x36C5738", VA = "0x36C5738")]
	public RFCombineMesh()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x36C58B0", Offset = "0x36C58B0", VA = "0x36C58B0")]
	public static RFCombineMesh GetCombinedMesh(Transform transForm, List<Mesh> meshList, List<Transform> transList, List<List<int>> matIdList, List<bool> invertNormals)
	{
		return null;
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x36C5F20", Offset = "0x36C5F20", VA = "0x36C5F20")]
	public static Mesh CreateMesh(RFCombineMesh cMesh, string name)
	{
		return null;
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x36C60CC", Offset = "0x36C60CC", VA = "0x36C60CC")]
	public static Mesh CombineShatter(RayfireShatter shatter, Transform root, List<MeshFilter> filters)
	{
		return null;
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x36C6254", Offset = "0x36C6254", VA = "0x36C6254")]
	private static void GetMeshTransMatLists(List<MeshFilter> filters, ref List<Mesh> meshList, ref List<Transform> transList, ref List<List<Material>> matList, int verts, float size)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x36C65B4", Offset = "0x36C65B4", VA = "0x36C65B4")]
	public static List<Material> GetAllMaterials(List<Transform> transList, List<List<Material>> matList)
	{
		return null;
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x36C6760", Offset = "0x36C6760", VA = "0x36C6760")]
	public static List<List<int>> GetMatIdList(List<Transform> transList, List<List<Material>> matList, List<Material> allMaterials)
	{
		return null;
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x36C6900", Offset = "0x36C6900", VA = "0x36C6900")]
	public static List<bool> GetInvertList(List<Transform> transList)
	{
		return null;
	}
}
[Token(Token = "0x200005A")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE888C", Offset = "0x1DE888C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE888C", Offset = "0x1DE888C")]
public class RayfireCombine : MonoBehaviour
{
	[Token(Token = "0x20000B9")]
	public enum CombType
	{
		[Token(Token = "0x40005A9")]
		Children,
		[Token(Token = "0x40005AA")]
		ObjectsList
	}

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CombType type;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<GameObject> objects;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool meshFilters;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool skinnedMeshes;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool particleSystems;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sizeThreshold;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int vertexThreshold;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform transForm;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private MeshFilter mFilter;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MeshRenderer mRenderer;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<bool> invertNormals;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Transform> transList;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<MeshFilter> mFilters;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<SkinnedMeshRenderer> skinnedMeshRends;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<ParticleSystemRenderer> particleRends;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<Mesh> meshList;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<List<int>> matIdList;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<List<Material>> matList;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<Material> allMaterials;

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x2BE6F84", Offset = "0x2BE6F84", VA = "0x2BE6F84")]
	public void Combine()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x2BE7064", Offset = "0x2BE7064", VA = "0x2BE7064")]
	private bool SetData()
	{
		return default(bool);
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x2BE8694", Offset = "0x2BE8694", VA = "0x2BE8694")]
	public RayfireCombine()
	{
	}
}
[Token(Token = "0x200005B")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE88EC", Offset = "0x1DE88EC")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE88EC", Offset = "0x1DE88EC")]
public class RayfireConnectivity : MonoBehaviour
{
	[Token(Token = "0x20000BA")]
	public enum RFConnInitType
	{
		[Token(Token = "0x40005AC")]
		AtStart = 1,
		[Token(Token = "0x40005AD")]
		ByMethod = 3,
		[Token(Token = "0x40005AE")]
		ByIntegrity = 5
	}

	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE91FC", Offset = "0x1DE91FC")]
	private sealed class <ConnectivityCor>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity <>4__this;

		[Token(Token = "0x1700006D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x2BED2FC", Offset = "0x2BED2FC", VA = "0x2BED2FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x2BED364", Offset = "0x2BED364", VA = "0x2BED364", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x2BEA1E0", Offset = "0x2BEA1E0", VA = "0x2BEA1E0")]
		[DebuggerHidden]
		public <ConnectivityCor>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x2BED244", Offset = "0x2BED244", VA = "0x2BED244", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2BED248", Offset = "0x2BED248", VA = "0x2BED248", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2BED304", Offset = "0x2BED304", VA = "0x2BED304", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE920C", Offset = "0x1DE920C")]
	private sealed class <ChildrenCor>d__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity <>4__this;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <checkChildren>5__2;

		[Token(Token = "0x1700006F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x2BED1D4", Offset = "0x2BED1D4", VA = "0x2BED1D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x2BED23C", Offset = "0x2BED23C", VA = "0x2BED23C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x2BEC320", Offset = "0x2BEC320", VA = "0x2BEC320")]
		[DebuggerHidden]
		public <ChildrenCor>d__61(int <>1__state)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2BED12C", Offset = "0x2BED12C", VA = "0x2BED12C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2BED130", Offset = "0x2BED130", VA = "0x2BED130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2BED1DC", Offset = "0x2BED1DC", VA = "0x2BED1DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ConnectivityType type;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float expand;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float minimumArea;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minimumSize;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int percentage;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int seed;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool clusterize;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool demolishable;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public RFConnInitType startCollapse;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int collapseByIntegrity;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFCollapse collapse;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFConnInitType startStress;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int stressByIntegrity;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFStress stress;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool showConnections;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool showNodes;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	public bool showGizmo;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
	public bool showStress;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool checkConnectivity;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool connectivityCheckNeed;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<RayfireRigid> rigidList;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFCluster cluster;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int initShardAmount;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int clsCount;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RayfireRigidRoot rigidRootHost;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public RayfireRigid meshRootHost;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Collider triggerCollider;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int triggerDebris;

	[NonSerialized]
	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public RFBackupCluster backup;

	[NonSerialized]
	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool childrenChanged;

	[NonSerialized]
	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	private bool childrenCorState;

	[NonSerialized]
	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
	private bool connectivityCorState;

	[NonSerialized]
	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
	private bool corState;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RFConnectivityEvent connectivityEvent;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public RFJointProperties joints;

	[Token(Token = "0x17000019")]
	public float AmountIntegrity
	{
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x2BEA50C", Offset = "0x2BEA50C", VA = "0x2BEA50C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x2BE86BC", Offset = "0x2BE86BC", VA = "0x2BE86BC")]
	private void SetRuntimeMeshRootHost()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x2BE880C", Offset = "0x2BE880C", VA = "0x2BE880C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x2BE8818", Offset = "0x2BE8818", VA = "0x2BE8818")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x2BE8A14", Offset = "0x2BE8A14", VA = "0x2BE8A14")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x2BE8C9C", Offset = "0x2BE8C9C", VA = "0x2BE8C9C")]
	private bool WarningCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x2BE9370", Offset = "0x2BE9370", VA = "0x2BE9370")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x2BE9400", Offset = "0x2BE9400", VA = "0x2BE9400")]
	private void PrepareCluster()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x2BE9560", Offset = "0x2BE9560", VA = "0x2BE9560")]
	private RFCluster CreateCluster()
	{
		return null;
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x2BE8E70", Offset = "0x2BE8E70", VA = "0x2BE8E70")]
	private void SetClusterForMeshRoot()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x2BE9138", Offset = "0x2BE9138", VA = "0x2BE9138")]
	private void SetClusterForRigidRoot()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x2BE9E00", Offset = "0x2BE9E00", VA = "0x2BE9E00")]
	private void SetExpand()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x2BE9648", Offset = "0x2BE9648", VA = "0x2BE9648")]
	private void SetRigidListByFragments(List<RayfireRigid> rgList)
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x2BE989C", Offset = "0x2BE989C", VA = "0x2BE989C")]
	public static bool InitCachedShardsByRigidList(List<RayfireRigid> rigids, RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x2BE9ED4", Offset = "0x2BE9ED4", VA = "0x2BE9ED4")]
	public static void InitCachedShardsByRigidRoot(RayfireRigidRoot root, RFCluster cluster)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x2BE8998", Offset = "0x2BE8998", VA = "0x2BE8998")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEB010", Offset = "0x1DEB010")]
	private IEnumerator ConnectivityCor()
	{
		return null;
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x2BEA20C", Offset = "0x2BEA20C", VA = "0x2BEA20C")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x2BEA408", Offset = "0x2BEA408", VA = "0x2BEA408")]
	private void CheckConnectivityRigidList()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x2BEA304", Offset = "0x2BEA304", VA = "0x2BEA304")]
	private void CheckConnectivityRigidRoot()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x2BEA954", Offset = "0x2BEA954", VA = "0x2BEA954")]
	private void ActivateShards(List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x2BEAEA0", Offset = "0x2BEAEA0", VA = "0x2BEAEA0")]
	private void Clusterize()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x2BEA580", Offset = "0x2BEA580", VA = "0x2BEA580")]
	private static void CleanUpActivatedShardsRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x2BEA788", Offset = "0x2BEA788", VA = "0x2BEA788")]
	private static void CheckUnyieldingRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x2BEABD4", Offset = "0x2BEABD4", VA = "0x2BEABD4")]
	private static void CleanUpActivatedShardsRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x2BEACD4", Offset = "0x2BEACD4", VA = "0x2BEACD4")]
	private static void CheckUnyieldingRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x2BEC314", Offset = "0x2BEC314", VA = "0x2BEC314")]
	private void OnTransformChildrenChanged()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x2BE891C", Offset = "0x2BE891C", VA = "0x2BE891C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEB074", Offset = "0x1DEB074")]
	private IEnumerator ChildrenCor()
	{
		return null;
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x2BEC34C", Offset = "0x2BEC34C", VA = "0x2BEC34C")]
	private void ChildrenCheck()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x2BEC6C8", Offset = "0x2BEC6C8", VA = "0x2BEC6C8")]
	public void ResetConnectivity()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x2BE9004", Offset = "0x2BE9004", VA = "0x2BE9004")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x2BEC700", Offset = "0x2BEC700", VA = "0x2BEC700")]
	public void Fracture()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x2BEC70C", Offset = "0x2BEC70C", VA = "0x2BEC70C")]
	public void Fracture(Collider col, int debris)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x2BECBB4", Offset = "0x2BECBB4", VA = "0x2BECBB4")]
	private HashSet<Collider> GetOverlappedColliders(Collider col)
	{
		return null;
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x2BED058", Offset = "0x2BED058", VA = "0x2BED058")]
	public RayfireConnectivity()
	{
	}
}
[Token(Token = "0x200005C")]
[SelectionBase]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE895C", Offset = "0x1DE895C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE895C", Offset = "0x1DE895C")]
public class RayfireDebris : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE921C", Offset = "0x1DE921C")]
	private sealed class <>c
	{
		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<MeshFilter, bool> <>9__28_0;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<MeshFilter, Mesh> <>9__28_1;

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x2BEE610", Offset = "0x2BEE610", VA = "0x2BEE610")]
		public <>c()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2BEE618", Offset = "0x2BEE618", VA = "0x2BEE618")]
		internal bool <SetReferenceMeshes>b__28_0(MeshFilter mf)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2BEE6D0", Offset = "0x2BEE6D0", VA = "0x2BEE6D0")]
		internal Mesh <SetReferenceMeshes>b__28_1(MeshFilter mf)
		{
			return null;
		}
	}

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1DE9CA4", Offset = "0x1DE9CA4")]
	public bool onDemolition;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9CDC", Offset = "0x1DE9CDC")]
	public bool onActivation;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9CF0", Offset = "0x1DE9CF0")]
	public bool onImpact;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1DE9D04", Offset = "0x1DE9D04")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9D04", Offset = "0x1DE9D04")]
	public GameObject debrisReference;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9D54", Offset = "0x1DE9D54")]
	public Material debrisMaterial;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9D68", Offset = "0x1DE9D68")]
	public Material emissionMaterial;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1DE9D7C", Offset = "0x1DE9D7C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9D7C", Offset = "0x1DE9D7C")]
	public RFParticleEmission emission;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9DCC", Offset = "0x1DE9DCC")]
	public RFParticleDynamicDebris dynamic;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9DE0", Offset = "0x1DE9DE0")]
	public RFParticleNoise noise;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9DF4", Offset = "0x1DE9DF4")]
	public RFParticleCollisionDebris collision;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9E08", Offset = "0x1DE9E08")]
	public RFParticleLimitations limitations;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9E1C", Offset = "0x1DE9E1C")]
	public RFParticleRendering rendering;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public RayfireRigid rigid;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public ParticleSystem pSystem;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Transform hostTm;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public bool initialized;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public List<Mesh> debrisMeshList;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public Vector3 refScale;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public List<RayfireDebris> children;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	public int amountFinal;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[HideInInspector]
	public bool oldChild;

	[Token(Token = "0x1700001A")]
	public bool HasChildren
	{
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2BEE160", Offset = "0x2BEE160", VA = "0x2BEE160")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x2BED36C", Offset = "0x2BED36C", VA = "0x2BED36C")]
	public RayfireDebris()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x2BED574", Offset = "0x2BED574", VA = "0x2BED574")]
	public void CopyFrom(RayfireDebris source)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x2BED674", Offset = "0x2BED674", VA = "0x2BED674")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x2BEDAF8", Offset = "0x2BEDAF8", VA = "0x2BEDAF8")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x2BEDF3C", Offset = "0x2BEDF3C", VA = "0x2BEDF3C")]
	public void Clean()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x2BEDC28", Offset = "0x2BEDC28", VA = "0x2BEDC28")]
	public void CreateDebris(RayfireDebris scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x2BEE1BC", Offset = "0x2BEE1BC", VA = "0x2BEE1BC")]
	private void SetParticleRendererDebris(ParticleSystemRenderer rend, RayfireDebris scr)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x2BED688", Offset = "0x2BED688", VA = "0x2BED688")]
	private void SetReferenceMeshes(GameObject refs)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x2BEE3C8", Offset = "0x2BEE3C8", VA = "0x2BEE3C8")]
	private void SetDebrisMaterial(List<MeshFilter> mfs)
	{
	}
}
[Token(Token = "0x200005D")]
[SelectionBase]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE89CC", Offset = "0x1DE89CC")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE89CC", Offset = "0x1DE89CC")]
public class RayfireDust : MonoBehaviour
{
	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1DE9EC0", Offset = "0x1DE9EC0")]
	public bool onDemolition;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9EF8", Offset = "0x1DE9EF8")]
	public bool onActivation;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9F0C", Offset = "0x1DE9F0C")]
	public bool onImpact;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1DE9F20", Offset = "0x1DE9F20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9F20", Offset = "0x1DE9F20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1DE9F20", Offset = "0x1DE9F20")]
	public float opacity;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9F8C", Offset = "0x1DE9F8C")]
	public Material dustMaterial;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9FA0", Offset = "0x1DE9FA0")]
	public List<Material> dustMaterials;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9FB4", Offset = "0x1DE9FB4")]
	public Material emissionMaterial;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1DE9FC8", Offset = "0x1DE9FC8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DE9FC8", Offset = "0x1DE9FC8")]
	public RFParticleEmission emission;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DEA018", Offset = "0x1DEA018")]
	public RFParticleDynamicDust dynamic;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DEA02C", Offset = "0x1DEA02C")]
	public RFParticleNoise noise;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DEA040", Offset = "0x1DEA040")]
	public RFParticleCollisionDust collision;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DEA054", Offset = "0x1DEA054")]
	public RFParticleLimitations limitations;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DEA068", Offset = "0x1DEA068")]
	public RFParticleRendering rendering;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public RayfireRigid rigid;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public ParticleSystem pSystem;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Transform hostTm;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public bool initialized;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public List<RayfireDust> children;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public int amountFinal;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[HideInInspector]
	public bool oldChild;

	[Token(Token = "0x1700001B")]
	public bool HasChildren
	{
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2BEF210", Offset = "0x2BEF210", VA = "0x2BEF210")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001C")]
	public bool HasMaterials
	{
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x2BEEB94", Offset = "0x2BEEB94", VA = "0x2BEEB94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x2BEE6EC", Offset = "0x2BEE6EC", VA = "0x2BEE6EC")]
	public RayfireDust()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x2BEE88C", Offset = "0x2BEE88C", VA = "0x2BEE88C")]
	public void CopyFrom(RayfireDust source)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x2BEE984", Offset = "0x2BEE984", VA = "0x2BEE984")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x2BEEBF0", Offset = "0x2BEEBF0", VA = "0x2BEEBF0")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x2BEEFEC", Offset = "0x2BEEFEC", VA = "0x2BEEFEC")]
	public void Clean()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x2BEED00", Offset = "0x2BEED00", VA = "0x2BEED00")]
	public void CreateDust(RayfireDust scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x2BEF26C", Offset = "0x2BEF26C", VA = "0x2BEF26C")]
	private void SetParticleRendererDust(ParticleSystemRenderer rend, RayfireDust scr)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x2BEF3F8", Offset = "0x2BEF3F8", VA = "0x2BEF3F8")]
	private void SetMaterialDust(ParticleSystemRenderer rend, List<Material> mats)
	{
	}
}
[Token(Token = "0x200005E")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE8A3C", Offset = "0x1DE8A3C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE8A3C", Offset = "0x1DE8A3C")]
public class RayfireGun : MonoBehaviour
{
	[Token(Token = "0x20000BE")]
	public enum ImpactType
	{
		[Token(Token = "0x40005BA")]
		AddExplosionForce,
		[Token(Token = "0x40005BB")]
		AddForceAtPosition
	}

	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE922C", Offset = "0x1DE922C")]
	private sealed class <StartShootCor>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireGun <>4__this;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <shootId>5__2;

		[Token(Token = "0x17000071")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x2BF1A78", Offset = "0x2BF1A78", VA = "0x2BF1A78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x2BF1AE0", Offset = "0x2BF1AE0", VA = "0x2BF1AE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2BEF598", Offset = "0x2BEF598", VA = "0x2BEF598")]
		[DebuggerHidden]
		public <StartShootCor>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2BF1988", Offset = "0x2BF1988", VA = "0x2BF1988", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2BF198C", Offset = "0x2BF198C", VA = "0x2BF198C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2BF1A80", Offset = "0x2BF1A80", VA = "0x2BF1A80", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE923C", Offset = "0x1DE923C")]
	private sealed class <BurstCor>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireGun <>4__this;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x17000073")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x2BF1918", Offset = "0x2BF1918", VA = "0x2BF1918", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x2BF1980", Offset = "0x2BF1980", VA = "0x2BF1980", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2BEFE04", Offset = "0x2BEFE04", VA = "0x2BEFE04")]
		[DebuggerHidden]
		public <BurstCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2BF181C", Offset = "0x2BF181C", VA = "0x2BF181C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2BF1820", Offset = "0x2BF1820", VA = "0x2BF1820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2BF1920", Offset = "0x2BF1920", VA = "0x2BF1920", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AxisType axis;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxDistance;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int rounds;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float rate;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ImpactType type;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float strength;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float radius;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float offset;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool demolishCluster;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool affectInactive;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public bool rigid;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
	public bool rigidRoot;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1DEA0EC", Offset = "0x1DEA0EC")]
	public bool rigidBody;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float damage;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool debris;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool dust;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool flash;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFFlash Flash;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int mask;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string tagFilter;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool showRay;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool showHit;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	public bool shooting;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string untagged;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RFShotEvent shotEvent;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Collider[] impactColliders;

	[Token(Token = "0x1700001D")]
	public Vector3 ShootVector
	{
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x2BEF648", Offset = "0x2BEF648", VA = "0x2BEF648")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x2BEF4E4", Offset = "0x2BEF4E4", VA = "0x2BEF4E4")]
	public void StartShooting()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x2BEF51C", Offset = "0x2BEF51C", VA = "0x2BEF51C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEB0D8", Offset = "0x1DEB0D8")]
	private IEnumerator StartShootCor()
	{
		return null;
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x2BEF5C4", Offset = "0x2BEF5C4", VA = "0x2BEF5C4")]
	public void StopShooting()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x2BEF5CC", Offset = "0x2BEF5CC", VA = "0x2BEF5CC")]
	public void Shoot(int shootId = 1)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x2BEFD50", Offset = "0x2BEFD50", VA = "0x2BEFD50")]
	public void Burst()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x2BEFD88", Offset = "0x2BEFD88", VA = "0x2BEFD88")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEB13C", Offset = "0x1DEB13C")]
	private IEnumerator BurstCor()
	{
		return null;
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x2BEF7E4", Offset = "0x2BEF7E4", VA = "0x2BEF7E4")]
	public void Shoot(Vector3 shootPos, Vector3 shootVector)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x2BF05C0", Offset = "0x2BF05C0", VA = "0x2BF05C0")]
	private void ImpactRigid(RayfireRigid rigidScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x2BF0CC4", Offset = "0x2BF0CC4", VA = "0x2BF0CC4")]
	private void ImpactRoot(RayfireRigidRoot rootScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x2BF10D0", Offset = "0x2BF10D0", VA = "0x2BF10D0")]
	private void AddForce(List<Rigidbody> impactRbList, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x2BF0368", Offset = "0x2BF0368", VA = "0x2BF0368")]
	private RayfireRigid ApplyDamage(RayfireRigid scr, RaycastHit hit, Vector3 shootPos, Vector3 shootVector, Vector3 impactPoint)
	{
		return null;
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x2BEFE30", Offset = "0x2BEFE30", VA = "0x2BEFE30")]
	private void VfxFlash(Vector3 position, Vector3 normal)
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x2BF0048", Offset = "0x2BF0048", VA = "0x2BF0048")]
	private void VfxDebris(List<RayfireDebris> debrisList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x2BF01D8", Offset = "0x2BF01D8", VA = "0x2BF01D8")]
	private void VfxDust(List<RayfireDust> dustList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x2BF1378", Offset = "0x2BF1378", VA = "0x2BF1378")]
	private List<RayfireRigid> ActivationCheck(RayfireRigid scrTarget, Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x2BF16B4", Offset = "0x2BF16B4", VA = "0x2BF16B4")]
	public RayfireGun()
	{
	}
}
[Token(Token = "0x200005F")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE8A9C", Offset = "0x1DE8A9C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE8A9C", Offset = "0x1DE8A9C")]
public class RayfireMan : MonoBehaviour
{
	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static RayfireMan inst;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int buildMajor;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int buildMinor;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool setGravity;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float multiplier;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RigidbodyInterpolation interpolation;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float colliderSize;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static float colliderSizeStatic;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1DEA124", Offset = "0x1DEA124")]
	public CollisionDetectionMode meshCollision;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public CollisionDetectionMode clusterCollision;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float minimumMass;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float maximumMass;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFMaterialPresets materialPresets;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject parent;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float globalSolidity;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float timeQuota;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFManDemolition advancedDemolitionProperties;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFPoolingFragment fragments;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFPoolingParticles particles;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform transForm;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<string> layers;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RFStorage storage;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float maxTimeThisFrame;

	[Token(Token = "0x1700001E")]
	public static bool MaxAmountCheck
	{
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2BF23F8", Offset = "0x2BF23F8", VA = "0x2BF23F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x2BF1AE8", Offset = "0x2BF1AE8", VA = "0x2BF1AE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x2BF1D84", Offset = "0x2BF1D84", VA = "0x2BF1D84")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x2BF1D8C", Offset = "0x2BF1D8C", VA = "0x2BF1D8C")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x2BF1AEC", Offset = "0x2BF1AEC", VA = "0x2BF1AEC")]
	private void SetInstance()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x2BF2084", Offset = "0x2BF2084", VA = "0x2BF2084")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x2BF20BC", Offset = "0x2BF20BC", VA = "0x2BF20BC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x2BF1D90", Offset = "0x2BF1D90", VA = "0x2BF1D90")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x2BF211C", Offset = "0x2BF211C", VA = "0x2BF211C")]
	private void SetGravity()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x2BF22A0", Offset = "0x2BF22A0", VA = "0x2BF22A0")]
	public static void RayFireManInit()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x2BF21D8", Offset = "0x2BF21D8", VA = "0x2BF21D8")]
	private void SetLayers()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x2BF1E58", Offset = "0x2BF1E58", VA = "0x2BF1E58")]
	private void SetPooling()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x2BF1F8C", Offset = "0x2BF1F8C", VA = "0x2BF1F8C")]
	private void SetStorage()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x2BF24C0", Offset = "0x2BF24C0", VA = "0x2BF24C0")]
	public void DestroyStorage()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x2BF24DC", Offset = "0x2BF24DC", VA = "0x2BF24DC")]
	public static void SetParentByManager(Transform tm, Transform original, bool noRegister = false)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x2BF2710", Offset = "0x2BF2710", VA = "0x2BF2710")]
	public static void SetParentByManager(Transform tm)
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x2BE240C", Offset = "0x2BE240C", VA = "0x2BE240C")]
	public static void DestroyFragment(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x2BF29F8", Offset = "0x2BF29F8", VA = "0x2BF29F8")]
	public static void DestroyShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x2BF2ACC", Offset = "0x2BF2ACC", VA = "0x2BF2ACC")]
	public static void DestroyGo(GameObject go)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x2BF2870", Offset = "0x2BF2870", VA = "0x2BF2870")]
	private static void DestroyOp(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x2BF2B34", Offset = "0x2BF2B34", VA = "0x2BF2B34")]
	public RayfireMan()
	{
	}
}
[Serializable]
[Token(Token = "0x2000060")]
public class RFCache
{
	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<bool> act;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Vector3> pos;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Quaternion> rot;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform transform;

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x36BF504", Offset = "0x36BF504", VA = "0x36BF504")]
	public RFCache(Transform parent, Transform tm)
	{
	}
}
[Token(Token = "0x2000061")]
[SelectionBase]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE8B0C", Offset = "0x1DE8B0C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE8B0C", Offset = "0x1DE8B0C")]
public class RayfireRecorder : MonoBehaviour
{
	[Token(Token = "0x20000C1")]
	public enum AnimatorType
	{
		[Token(Token = "0x40005C5")]
		Disabled = 0,
		[Token(Token = "0x40005C6")]
		Record = 2,
		[Token(Token = "0x40005C7")]
		Play = 8
	}

	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE924C", Offset = "0x1DE924C")]
	private sealed class <RecordCor>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRecorder <>4__this;

		[Token(Token = "0x17000075")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x2BF40D0", Offset = "0x2BF40D0", VA = "0x2BF40D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x2BF4138", Offset = "0x2BF4138", VA = "0x2BF4138", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2BF3CFC", Offset = "0x2BF3CFC", VA = "0x2BF3CFC")]
		[DebuggerHidden]
		public <RecordCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2BF3DB4", Offset = "0x2BF3DB4", VA = "0x2BF3DB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2BF3DB8", Offset = "0x2BF3DB8", VA = "0x2BF3DB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2BF40D8", Offset = "0x2BF40D8", VA = "0x2BF40D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimatorType mode;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool recordOnStart;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string clipName;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float duration;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int rate;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool reduceKeys;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float threshold;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool playOnStart;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationClip animationClip;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RuntimeAnimatorController controller;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool setToKinematic;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool recorder;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float recordedTime;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int stateNameHash;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string assetFolder;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string clipFolder;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float stepTime;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Animator animator;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<Transform> tmList;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<RFCache> cacheList;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<float> timeList;

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x2BF2CCC", Offset = "0x2BF2CCC", VA = "0x2BF2CCC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x2BF300C", Offset = "0x2BF300C", VA = "0x2BF300C")]
	private void Start()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x2BF3070", Offset = "0x2BF3070", VA = "0x2BF3070")]
	private void SetRigid()
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x2BF2CD0", Offset = "0x2BF2CD0", VA = "0x2BF2CD0")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x2BF3334", Offset = "0x2BF3334", VA = "0x2BF3334")]
	private void SetModeRecord()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x2BF3550", Offset = "0x2BF3550", VA = "0x2BF3550")]
	private void SetModePlay()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x2BF3C40", Offset = "0x2BF3C40", VA = "0x2BF3C40")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x2BF3264", Offset = "0x2BF3264", VA = "0x2BF3264")]
	public void StartRecord()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x2BF3C80", Offset = "0x2BF3C80", VA = "0x2BF3C80")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEB1A0", Offset = "0x1DEB1A0")]
	private IEnumerator RecordCor()
	{
		return null;
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x2BF3D28", Offset = "0x2BF3D28", VA = "0x2BF3D28")]
	public void StopRecord()
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x2BF32D8", Offset = "0x2BF32D8", VA = "0x2BF32D8")]
	public void StartPlay()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x2BF3D30", Offset = "0x2BF3D30", VA = "0x2BF3D30")]
	public RayfireRecorder()
	{
	}
}
[Token(Token = "0x2000062")]
[SelectionBase]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE8B8C", Offset = "0x1DE8B8C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE8B8C", Offset = "0x1DE8B8C")]
public class RayfireRestriction : MonoBehaviour
{
	[Token(Token = "0x20000C3")]
	public enum RFBoundActionType
	{
		[Token(Token = "0x40005CC")]
		Fade = 2,
		[Token(Token = "0x40005CD")]
		Reset = 4,
		[Token(Token = "0x40005CE")]
		PostDemolitionAction = 9
	}

	[Token(Token = "0x20000C4")]
	public enum RFDistanceType
	{
		[Token(Token = "0x40005D0")]
		InitializePosition = 0,
		[Token(Token = "0x40005D1")]
		TargetPosition = 2
	}

	[Token(Token = "0x20000C5")]
	public enum RFBoundTriggerType
	{
		[Token(Token = "0x40005D3")]
		Inside = 0,
		[Token(Token = "0x40005D4")]
		Outside = 2
	}

	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE925C", Offset = "0x1DE925C")]
	private sealed class <RestrictionDistanceCor>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <intervalDelay>5__2;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <actionDelay>5__3;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 <checkPosition>5__4;

		[Token(Token = "0x17000077")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x2BF4B48", Offset = "0x2BF4B48", VA = "0x2BF4B48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x2BF4BB0", Offset = "0x2BF4BB0", VA = "0x2BF4BB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2BF4758", Offset = "0x2BF4758", VA = "0x2BF4758")]
		[DebuggerHidden]
		public <RestrictionDistanceCor>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2BF47B0", Offset = "0x2BF47B0", VA = "0x2BF47B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2BF47B4", Offset = "0x2BF47B4", VA = "0x2BF47B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2BF4B50", Offset = "0x2BF4B50", VA = "0x2BF4B50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE926C", Offset = "0x1DE926C")]
	private sealed class <RestrictionTriggerCor>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <intervalDelay>5__2;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <actionDelay>5__3;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <brokeState>5__4;

		[Token(Token = "0x17000079")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x2BF4F7C", Offset = "0x2BF4F7C", VA = "0x2BF4F7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x2BF4FE4", Offset = "0x2BF4FE4", VA = "0x2BF4FE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2BF4784", Offset = "0x2BF4784", VA = "0x2BF4784")]
		[DebuggerHidden]
		public <RestrictionTriggerCor>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2BF4BB8", Offset = "0x2BF4BB8", VA = "0x2BF4BB8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2BF4BBC", Offset = "0x2BF4BBC", VA = "0x2BF4BBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2BF4F84", Offset = "0x2BF4F84", VA = "0x2BF4F84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool enable;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RFBoundActionType breakAction;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float actionDelay;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float checkInterval;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float distance;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public RFDistanceType position;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform target;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Collider Collider;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFBoundTriggerType region;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RayfireRigid rigid;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool broke;

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x2BF4140", Offset = "0x2BF4140", VA = "0x2BF4140")]
	public RayfireRestriction()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x2BF41B0", Offset = "0x2BF41B0", VA = "0x2BF41B0")]
	public void CopyFrom(RayfireRestriction rest)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x2BF41A8", Offset = "0x2BF41A8", VA = "0x2BF41A8")]
	public void Reset()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x2BF422C", Offset = "0x2BF422C", VA = "0x2BF422C")]
	private void Start()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x2BF4558", Offset = "0x2BF4558", VA = "0x2BF4558")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x2BF455C", Offset = "0x2BF455C", VA = "0x2BF455C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x2BF4324", Offset = "0x2BF4324", VA = "0x2BF4324")]
	public void InitRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x2BF4658", Offset = "0x2BF4658", VA = "0x2BF4658")]
	private static void BrokeRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x2BF4560", Offset = "0x2BF4560", VA = "0x2BF4560")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEB204", Offset = "0x1DEB204")]
	private static IEnumerator RestrictionDistanceCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x2BF45DC", Offset = "0x2BF45DC", VA = "0x2BF45DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEB268", Offset = "0x1DEB268")]
	private IEnumerator RestrictionTriggerCor(RayfireRigid scr)
	{
		return null;
	}
}
[Token(Token = "0x2000063")]
[SelectionBase]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE8C0C", Offset = "0x1DE8C0C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE8C0C", Offset = "0x1DE8C0C")]
public class RayfireRigid : MonoBehaviour
{
	[Token(Token = "0x20000C8")]
	public enum InitType
	{
		[Token(Token = "0x40005E2")]
		ByMethod,
		[Token(Token = "0x40005E3")]
		AtStart
	}

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InitType initialization;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SimType simulationType;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ObjectType objectType;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public DemolitionType demolitionType;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFPhysic physics;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFActivation activation;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFLimitations limitations;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFDemolitionMesh meshDemolition;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFDemolitionCluster clusterDemolition;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFReferenceDemolition referenceDemolition;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFSurface materials;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFDamage damage;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFFade fading;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RFReset reset;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool initialized;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	public bool corState;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Mesh[] meshes;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector3[] pivots;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RFMesh[] rfMeshes;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<RFDictionary> subIds;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<RayfireRigid> fragments;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Quaternion cacheRotation;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform transForm;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Transform rootChild;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Transform rootParent;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public MeshFilter meshFilter;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public SkinnedMeshRenderer skinnedMeshRend;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<RayfireDebris> debrisList;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<RayfireDust> dustList;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public RayfireRestriction restriction;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public RayfireSound sound;

	[NonSerialized]
	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public RayfireRigid meshRoot;

	[NonSerialized]
	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public RayfireRigidRoot rigidRoot;

	[NonSerialized]
	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public List<Transform> particleList;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public RFDemolitionEvent demolitionEvent;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public RFActivationEvent activationEvent;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public RFRestrictionEvent restrictionEvent;

	[Token(Token = "0x1700001F")]
	public bool HasFragments
	{
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x2BF131C", Offset = "0x2BF131C", VA = "0x2BF131C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public bool HasMeshes
	{
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x2BF7F7C", Offset = "0x2BF7F7C", VA = "0x2BF7F7C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000021")]
	public bool HasRfMeshes
	{
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x2BF7F9C", Offset = "0x2BF7F9C", VA = "0x2BF7F9C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000022")]
	public bool HasDebris
	{
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x2BF7FBC", Offset = "0x2BF7FBC", VA = "0x2BF7FBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000023")]
	public bool HasDust
	{
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x2BF8018", Offset = "0x2BF8018", VA = "0x2BF8018")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000024")]
	public bool HasSlices
	{
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x2BF7B20", Offset = "0x2BF7B20", VA = "0x2BF7B20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000025")]
	public bool IsCluster
	{
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x2BF8074", Offset = "0x2BF8074", VA = "0x2BF8074")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000026")]
	public bool Visible
	{
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x2BF7274", Offset = "0x2BF7274", VA = "0x2BF7274")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000027")]
	public float AmountIntegrity
	{
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x2BF8088", Offset = "0x2BF8088", VA = "0x2BF8088")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x2BF4FEC", Offset = "0x2BF4FEC", VA = "0x2BF4FEC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x2BF50D0", Offset = "0x2BF50D0", VA = "0x2BF50D0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x2BF5138", Offset = "0x2BF5138", VA = "0x2BF5138")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x2BF5CB8", Offset = "0x2BF5CB8", VA = "0x2BF5CB8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x2BF5D18", Offset = "0x2BF5D18", VA = "0x2BF5D18")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x2BF5D70", Offset = "0x2BF5D70", VA = "0x2BF5D70")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x2BF5F64", Offset = "0x2BF5F64", VA = "0x2BF5F64")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x2BF531C", Offset = "0x2BF531C", VA = "0x2BF531C")]
	public void SetComponentsBasic()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x2BF5894", Offset = "0x2BF5894", VA = "0x2BF5894")]
	public void SetComponentsPhysics()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x2BF5E28", Offset = "0x2BF5E28", VA = "0x2BF5E28")]
	private void EditorSetupMeshRoot()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x2BF5564", Offset = "0x2BF5564", VA = "0x2BF5564")]
	private bool SetupMeshRoot()
	{
		return default(bool);
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x2BF6518", Offset = "0x2BF6518", VA = "0x2BF6518")]
	private void MeshRootCheck()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x2BF66D4", Offset = "0x2BF66D4", VA = "0x2BF66D4")]
	private void AddMeshRootRigid(Transform tm)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x2BF69D0", Offset = "0x2BF69D0", VA = "0x2BF69D0")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x2BF601C", Offset = "0x2BF601C", VA = "0x2BF601C")]
	private void ResetMeshRootSetup()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x2BF5B58", Offset = "0x2BF5B58", VA = "0x2BF5B58")]
	public void SetObjectType()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x2BF5A44", Offset = "0x2BF5A44", VA = "0x2BF5A44")]
	public void Default()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x2BF6B04", Offset = "0x2BF6B04", VA = "0x2BF6B04")]
	private void SetPhysics()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x2BF5BA0", Offset = "0x2BF5BA0", VA = "0x2BF5BA0")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x2BF6CE0", Offset = "0x2BF6CE0", VA = "0x2BF6CE0")]
	public void InactiveCors()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x2BF5028", Offset = "0x2BF5028", VA = "0x2BF5028")]
	public void MeshInput()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x2BF6DE0", Offset = "0x2BF6DE0", VA = "0x2BF6DE0", Slot = "4")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x2BF6EE4", Offset = "0x2BF6EE4", VA = "0x2BF6EE4", Slot = "5")]
	protected virtual bool CollisionDemolition(Collision collision)
	{
		return default(bool);
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x2BF7014", Offset = "0x2BF7014", VA = "0x2BF7014")]
	public bool State()
	{
		return default(bool);
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x2BF7184", Offset = "0x2BF7184", VA = "0x2BF7184", Slot = "6")]
	public virtual bool DemolitionState()
	{
		return default(bool);
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x2BF7360", Offset = "0x2BF7360", VA = "0x2BF7360")]
	public void Demolish()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x2BEC048", Offset = "0x2BEC048", VA = "0x2BEC048")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x2BF756C", Offset = "0x2BF756C", VA = "0x2BF756C")]
	public void InitMeshFragments()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x2BF76BC", Offset = "0x2BF76BC", VA = "0x2BF76BC")]
	public void DeleteCache()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x2BF775C", Offset = "0x2BF775C", VA = "0x2BF775C")]
	public void DeleteFragments()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x2BF787C", Offset = "0x2BF787C", VA = "0x2BF787C")]
	public void AddSlicePlane(Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x2BF791C", Offset = "0x2BF791C", VA = "0x2BF791C")]
	public void Slice()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x2BF7B88", Offset = "0x2BF7B88", VA = "0x2BF7B88")]
	public void CacheFrames()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x2BF7BC8", Offset = "0x2BF7BC8", VA = "0x2BF7BC8")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x1DEB2CC", Offset = "0x1DEB2CC")]
	public void SaveInitTransform()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x2BE2404", Offset = "0x2BE2404", VA = "0x2BE2404")]
	public bool ApplyDamage(float damageValue, Vector3 damagePoint, float damageRadius = 0f, [Optional] Collider coll)
	{
		return default(bool);
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x2BE2528", Offset = "0x2BE2528", VA = "0x2BE2528")]
	public void Activate(bool connCheck = true)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x2BEC258", Offset = "0x2BEC258", VA = "0x2BEC258")]
	public void Fade()
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x2BE2244", Offset = "0x2BE2244", VA = "0x2BE2244")]
	public void ResetRigid()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x2BF7DDC", Offset = "0x2BF7DDC", VA = "0x2BF7DDC")]
	public void DestroyCollider(Collider col)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x2BF7E44", Offset = "0x2BF7E44", VA = "0x2BF7E44")]
	public void DestroyObject(GameObject go)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x2BF7EAC", Offset = "0x2BF7EAC", VA = "0x2BF7EAC")]
	public void DestroyRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x2BF7F14", Offset = "0x2BF7F14", VA = "0x2BF7F14")]
	public void DestroyRb(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x2BF8114", Offset = "0x2BF8114", VA = "0x2BF8114")]
	public RayfireRigid()
	{
	}
}
[Serializable]
[Token(Token = "0x2000064")]
public class RFRigidRootDemolition
{
	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DEA15C", Offset = "0x1DEA15C")]
	public RFLimitations limitations;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1DEA170", Offset = "0x1DEA170")]
	public RFDemolitionCluster clusterDemolition;

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x3674D9C", Offset = "0x3674D9C", VA = "0x3674D9C")]
	public RFRigidRootDemolition()
	{
	}
}
[Token(Token = "0x2000065")]
[SelectionBase]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE8C8C", Offset = "0x1DE8C8C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE8C8C", Offset = "0x1DE8C8C")]
public class RayfireRigidRoot : MonoBehaviour
{
	[Token(Token = "0x20000C9")]
	public enum InitType
	{
		[Token(Token = "0x40005E5")]
		ByMethod,
		[Token(Token = "0x40005E6")]
		AtStart
	}

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InitType initialization;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SimType simulationType;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFPhysic physics;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFActivation activation;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFRigidRootDemolition demolition;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFFade fading;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFReset reset;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform tm;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RayfireSound sound;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFCluster cluster;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<RayfireRigid> meshRoots;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool initialized;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool cached;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float sizeBox;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float sizeSum;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<Collider> collidersList;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<RFShard> meshRootShards;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<RFShard> rigidRootShards;

	[NonSerialized]
	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<RFCluster> clusters;

	[NonSerialized]
	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<RFShard> inactiveShards;

	[NonSerialized]
	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<RFShard> offsetFadeShards;

	[NonSerialized]
	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<RFShard> destroyShards;

	[NonSerialized]
	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<RFShard> meshRigidShards;

	[NonSerialized]
	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<Transform> parentList;

	[NonSerialized]
	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<RayfireDebris> debrisList;

	[NonSerialized]
	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<RayfireDust> dustList;

	[NonSerialized]
	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public List<RayfireUnyielding> unyList;

	[NonSerialized]
	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<Transform> particleList;

	[NonSerialized]
	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public bool corState;

	[NonSerialized]
	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public HashSet<Collider> collidersHash;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public RFActivationEvent activationEvent;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string strRoot;

	[Token(Token = "0x17000028")]
	public bool HasClusters
	{
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x2BFB0EC", Offset = "0x2BFB0EC", VA = "0x2BFB0EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000029")]
	public bool HasDebris
	{
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x2BFB148", Offset = "0x2BFB148", VA = "0x2BFB148")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002A")]
	public bool HasDust
	{
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x2BFB1A4", Offset = "0x2BFB1A4", VA = "0x2BFB1A4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002B")]
	public bool HasUny
	{
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2BFB010", Offset = "0x2BFB010", VA = "0x2BFB010")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x2BF8398", Offset = "0x2BF8398", VA = "0x2BF8398")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x2BF8464", Offset = "0x2BF8464", VA = "0x2BF8464")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x2BF8494", Offset = "0x2BF8494", VA = "0x2BF8494")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x2BF83D4", Offset = "0x2BF83D4", VA = "0x2BF83D4")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x2BF8938", Offset = "0x2BF8938", VA = "0x2BF8938")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x2BF8B54", Offset = "0x2BF8B54", VA = "0x2BF8B54")]
	public void ResetRigidRoot()
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x2BF8B5C", Offset = "0x2BF8B5C", VA = "0x2BF8B5C")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x2BF8CFC", Offset = "0x2BF8CFC", VA = "0x2BF8CFC")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x2BF85F8", Offset = "0x2BF85F8", VA = "0x2BF85F8")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x2BF9170", Offset = "0x2BF9170", VA = "0x2BF9170")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x2BF9F54", Offset = "0x2BF9F54", VA = "0x2BF9F54")]
	private bool MeshRootCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x2BF9204", Offset = "0x2BF9204", VA = "0x2BF9204")]
	private void SetShards()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x2BFA468", Offset = "0x2BFA468", VA = "0x2BFA468")]
	private void SetCustomShardsLists()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x2BFA6F4", Offset = "0x2BFA6F4", VA = "0x2BFA6F4")]
	private void SetShardsSimulationType()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x2BFA8E4", Offset = "0x2BFA8E4", VA = "0x2BFA8E4")]
	private void SetParentList()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x2BFA9EC", Offset = "0x2BFA9EC", VA = "0x2BFA9EC")]
	private void AddShard(Transform shardTm, [Optional] RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x2BFAAEC", Offset = "0x2BFAAEC", VA = "0x2BFAAEC")]
	private void AddShardWithRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x2BF9A94", Offset = "0x2BF9A94", VA = "0x2BF9A94")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x2BFA02C", Offset = "0x2BFA02C", VA = "0x2BFA02C")]
	private void SetCollidersMaterial()
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x2BFA230", Offset = "0x2BFA230", VA = "0x2BFA230")]
	public void SetInactiveList()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x2BF9C94", Offset = "0x2BF9C94", VA = "0x2BF9C94")]
	private void SetUnyielding()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x2BF84EC", Offset = "0x2BF84EC", VA = "0x2BF84EC")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x2BEBF78", Offset = "0x2BEBF78", VA = "0x2BEBF78")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x2BFB06C", Offset = "0x2BFB06C", VA = "0x2BFB06C")]
	private static bool IsNestedCluster(Transform trans)
	{
		return default(bool);
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x2BFAB9C", Offset = "0x2BFAB9C", VA = "0x2BFAB9C")]
	private static bool ShardFilter(RFShard shard, RayfireRigidRoot scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x2BFB200", Offset = "0x2BFB200", VA = "0x2BFB200")]
	public void CollideTest()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x2BFB20C", Offset = "0x2BFB20C", VA = "0x2BFB20C")]
	public RayfireRigidRoot()
	{
	}
}
[Token(Token = "0x2000066")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE8D0C", Offset = "0x1DE8D0C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE8D0C", Offset = "0x1DE8D0C")]
public class RayfireShatter : MonoBehaviour
{
	[Token(Token = "0x20000CA")]
	public enum FragLastMode
	{
		[Token(Token = "0x40005E8")]
		New,
		[Token(Token = "0x40005E9")]
		ToLast
	}

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FragType type;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFVoronoi voronoi;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFSplinters splinters;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFSplinters slabs;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFRadial radial;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFCustom custom;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFMirrored mirrored;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFSlice slice;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFBricks bricks;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFVoxels voxels;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFTets tets;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public FragmentMode mode;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RFSurface material;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public RFShatterCluster clusters;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public RFShatterAdvanced advanced;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RFMeshExport export;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool showCenter;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public Vector3 centerPosition;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Quaternion centerDirection;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform transForm;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public MeshFilter meshFilter;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public SkinnedMeshRenderer skinnedMeshRend;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<MeshFilter> meshFilters;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Mesh[] meshes;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Vector3[] pivots;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<Transform> rootChildList;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public List<GameObject> fragmentsAll;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public List<GameObject> fragmentsLast;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public List<RFDictionary> origSubMeshIdsRF;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Material[] materials;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public int shatterMode;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public bool colorPreview;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
	public bool scalePreview;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public float previewScale;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public float size;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float rescaleFix;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public Vector3 originalScale;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[HideInInspector]
	public Bounds bound;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[HideInInspector]
	public bool resetState;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float minSize;

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x55BCB00", Offset = "0x55BCB00", VA = "0x55BCB00")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x55BCC68", Offset = "0x55BCC68", VA = "0x55BCC68")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x55BCD08", Offset = "0x55BCD08", VA = "0x55BCD08")]
	private bool MainCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x55BD144", Offset = "0x55BD144", VA = "0x55BD144")]
	private bool SingleMeshCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x55BD3A8", Offset = "0x55BD3A8", VA = "0x55BD3A8")]
	private bool DefineComponents()
	{
		return default(bool);
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x55BD648", Offset = "0x55BD648", VA = "0x55BD648")]
	public Bounds GetBound()
	{
		return default(Bounds);
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x55BD7E4", Offset = "0x55BD7E4", VA = "0x55BD7E4")]
	public void Fragment(FragLastMode fragmentMode = FragLastMode.New)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x55BDC7C", Offset = "0x55BDC7C", VA = "0x55BDC7C")]
	private List<GameObject> CreateFragments([Optional] Transform root)
	{
		return null;
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x55BE934", Offset = "0x55BE934", VA = "0x55BE934")]
	public void DeleteFragmentsLast(int destroyMode = 0)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x55BECE4", Offset = "0x55BECE4", VA = "0x55BECE4")]
	public void DeleteFragmentsAll()
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x55BCB04", Offset = "0x55BCB04", VA = "0x55BCB04")]
	public void ResetCenter()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x55BD9E8", Offset = "0x55BD9E8", VA = "0x55BD9E8")]
	private void ScaleCheck()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x55BEE48", Offset = "0x55BEE48", VA = "0x55BEE48")]
	public void ResetScale(float scaleValue)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x55BF09C", Offset = "0x55BF09C", VA = "0x55BF09C")]
	public static void CopyRootMeshShatter(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x55BF21C", Offset = "0x55BF21C", VA = "0x55BF21C")]
	private void CopyFrom(RayfireShatter shatter)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x55BE5E0", Offset = "0x55BE5E0", VA = "0x55BE5E0")]
	private void SizeLimitation()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x55BE71C", Offset = "0x55BE71C", VA = "0x55BE71C")]
	private void VertexLimitation()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x55BE818", Offset = "0x55BE818", VA = "0x55BE818")]
	private void TriangleLimitation()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x55BF464", Offset = "0x55BF464", VA = "0x55BF464")]
	private void LimitationFragment(int ind)
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x55BF730", Offset = "0x55BF730", VA = "0x55BF730")]
	public RayfireShatter()
	{
	}
}
[Token(Token = "0x2000067")]
[SelectionBase]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE8D6C", Offset = "0x1DE8D6C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE8D6C", Offset = "0x1DE8D6C")]
public class RayfireSnapshot : MonoBehaviour
{
	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string assetName;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool compress;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnityEngine.Object snapshotAsset;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sizeFilter;

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x55BFB18", Offset = "0x55BFB18", VA = "0x55BFB18")]
	private void Reset()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x55BFB58", Offset = "0x55BFB58", VA = "0x55BFB58")]
	public RayfireSnapshot()
	{
	}
}
[Token(Token = "0x2000068")]
[SelectionBase]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE8DEC", Offset = "0x1DE8DEC")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE8DEC", Offset = "0x1DE8DEC")]
public class RayfireSound : MonoBehaviour
{
	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float baseVolume;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sizeVolume;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFSound initialization;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFSound activation;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFSound demolition;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFSound collision;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float relativeVelocity;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float lastCollision;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float minimumSize;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float cameraDistance;

	[NonSerialized]
	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RayfireRigid rigid;

	[NonSerialized]
	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RayfireRigidRoot rigidRoot;

	[NonSerialized]
	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x55BFB60", Offset = "0x55BFB60", VA = "0x55BFB60")]
	public RayfireSound()
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x55BFB9C", Offset = "0x55BFB9C", VA = "0x55BFB9C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x55BFBA0", Offset = "0x55BFBA0", VA = "0x55BFBA0")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x55BFD44", Offset = "0x55BFD44", VA = "0x55BFD44")]
	private void WarningCheck()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x55C02CC", Offset = "0x55C02CC", VA = "0x55C02CC")]
	public void CopyFrom(RayfireSound source)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x55C03D4", Offset = "0x55C03D4", VA = "0x55C03D4")]
	private void CreateSource(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x55C0614", Offset = "0x55C0614", VA = "0x55C0614")]
	public void OnCollisionEnter(Collision coll)
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x55C0618", Offset = "0x55C0618", VA = "0x55C0618")]
	private void CollisionSound(Collision coll)
	{
	}
}
[Token(Token = "0x2000069")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE8E5C", Offset = "0x1DE8E5C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE8E5C", Offset = "0x1DE8E5C")]
public class RayfireUnyielding : MonoBehaviour
{
	[Token(Token = "0x20000CB")]
	public enum UnySimType
	{
		[Token(Token = "0x40005EB")]
		Original = 1,
		[Token(Token = "0x40005EC")]
		Inactive,
		[Token(Token = "0x40005ED")]
		Kinematic
	}

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool unyielding;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool activatable;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UnySimType simulationType;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 centerPosition;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 size;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RayfireRigid rigidHost;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<RayfireRigid> rigidList;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<RFShard> shardList;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool showGizmo;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool showCenter;

	[Token(Token = "0x1700002C")]
	private bool HasRigids
	{
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x55C2CF0", Offset = "0x55C2CF0", VA = "0x55C2CF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002D")]
	private bool HasShards
	{
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x55C2D4C", Offset = "0x55C2D4C", VA = "0x55C2D4C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002E")]
	public Vector3 Extents
	{
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x55C0D24", Offset = "0x55C0D24", VA = "0x55C0D24")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x55C07CC", Offset = "0x55C07CC", VA = "0x55C07CC")]
	public static void ClusterSetup(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x55C08C8", Offset = "0x55C08C8", VA = "0x55C08C8")]
	private static void ClusterOverlap(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x55C0BCC", Offset = "0x55C0BCC", VA = "0x55C0BCC")]
	private static int ClusterLayerMask(RayfireRigid rigid)
	{
		return default(int);
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x55C0E30", Offset = "0x55C0E30", VA = "0x55C0E30")]
	private static void SetShardUnyState(RFShard shard, bool unyielding, bool activatable)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x55C0E54", Offset = "0x55C0E54", VA = "0x55C0E54")]
	public static void MeshRootSetup(RayfireRigid mRoot)
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x55C0F10", Offset = "0x55C0F10", VA = "0x55C0F10")]
	private static List<RayfireUnyielding> GetUnyList(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x55C0FF8", Offset = "0x55C0FF8", VA = "0x55C0FF8")]
	private static void SetMeshRootUnyRigidList(RayfireRigid mRoot, RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x55C139C", Offset = "0x55C139C", VA = "0x55C139C")]
	private static int MeshRootLayerMask(RayfireRigid mRoot)
	{
		return default(int);
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x55C129C", Offset = "0x55C129C", VA = "0x55C129C")]
	public static void SetMeshRootUnyState(Transform tm, List<RayfireUnyielding> unyList)
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x55C14D8", Offset = "0x55C14D8", VA = "0x55C14D8")]
	private static void SetRigidUnyState(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x55C174C", Offset = "0x55C174C", VA = "0x55C174C")]
	private static void SetRigidUnySim(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x55C1A68", Offset = "0x55C1A68", VA = "0x55C1A68")]
	public static void ResetMeshRootSetup(RayfireRigid mRoot)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x55C1B34", Offset = "0x55C1B34", VA = "0x55C1B34")]
	public static void SetUnyieldingFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x55C22E0", Offset = "0x55C22E0", VA = "0x55C22E0")]
	private static void SetRigidUnyState(RayfireRigid rigid, bool uny, bool act)
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x55C236C", Offset = "0x55C236C", VA = "0x55C236C")]
	private static void CopyUny(RayfireUnyielding source, GameObject target)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x55C24E8", Offset = "0x55C24E8", VA = "0x55C24E8")]
	public void GetRigidRootUnyShardList(RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x55C286C", Offset = "0x55C286C", VA = "0x55C286C")]
	public void SetRigidRootUnyShardList()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x55C298C", Offset = "0x55C298C", VA = "0x55C298C")]
	public void Activate()
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x55C2DA8", Offset = "0x55C2DA8", VA = "0x55C2DA8")]
	public RayfireUnyielding()
	{
	}
}
[Token(Token = "0x200006A")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE8EBC", Offset = "0x1DE8EBC")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE8EBC", Offset = "0x1DE8EBC")]
public class RayfireVortex : MonoBehaviour
{
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE927C", Offset = "0x1DE927C")]
	private sealed class <VortexForceCor>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireVortex <>4__this;

		[Token(Token = "0x1700007B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x55C4410", Offset = "0x55C4410", VA = "0x55C4410", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x55C4478", Offset = "0x55C4478", VA = "0x55C4478", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x55C2F1C", Offset = "0x55C2F1C", VA = "0x55C2F1C")]
		[DebuggerHidden]
		public <VortexForceCor>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x55C42E0", Offset = "0x55C42E0", VA = "0x55C42E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x55C42E4", Offset = "0x55C42E4", VA = "0x55C42E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x55C4418", Offset = "0x55C4418", VA = "0x55C4418", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE928C", Offset = "0x1DE928C")]
	private sealed class <SetCollidersCor>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireVortex <>4__this;

		[Token(Token = "0x1700007D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x55C4270", Offset = "0x55C4270", VA = "0x55C4270", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x55C42D8", Offset = "0x55C42D8", VA = "0x55C42D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x55C2FC4", Offset = "0x55C2FC4", VA = "0x55C2FC4")]
		[DebuggerHidden]
		public <SetCollidersCor>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x55C412C", Offset = "0x55C412C", VA = "0x55C412C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x55C4130", Offset = "0x55C4130", VA = "0x55C4130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x55C4278", Offset = "0x55C4278", VA = "0x55C4278", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Transform transForm;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Collider[] colliders;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 bot;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 top;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 normal;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 direction;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 rbPos;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 linePoint;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 vectorUp;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 centerOutVector;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 vectorCenter;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 perpend;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3 vectorSwirl;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private Vector3 forceVector;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float distancePerpend;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float distanceBottom;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float upRateNow;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float localRadius;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float upRateOwn;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private float centerRateOwn;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float centerRateNow;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float upRateDif;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float centerRateDif;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float maxRadius;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float axisDistance;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private Plane bottomPlane;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private float torqueVal;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool topHandle;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public Vector3 topAnchor;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Vector3 bottomAnchor;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public bool showGizmo;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public float topRadius;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public float bottomRadius;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float eye;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public bool forceByMass;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public float stiffness;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public float swirlStrength;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public bool enableTorque;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public float torqueStrength;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public float torqueVariation;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public bool enableHeightBias;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public float biasSpeed;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	public float biasSpread;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public int seed;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public int circles;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public int mask;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public string tagFilter;

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x55C2E18", Offset = "0x55C2E18", VA = "0x55C2E18")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x55C2E1C", Offset = "0x55C2E1C", VA = "0x55C2E1C")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x55C2EA0", Offset = "0x55C2EA0", VA = "0x55C2EA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEB304", Offset = "0x1DEB304")]
	private IEnumerator VortexForceCor()
	{
		return null;
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x55C2F48", Offset = "0x55C2F48", VA = "0x55C2F48")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEB368", Offset = "0x1DEB368")]
	private IEnumerator SetCollidersCor()
	{
		return null;
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x55C2FF0", Offset = "0x55C2FF0", VA = "0x55C2FF0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x55C3034", Offset = "0x55C3034", VA = "0x55C3034")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x55C3168", Offset = "0x55C3168", VA = "0x55C3168")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x55C32E8", Offset = "0x55C32E8", VA = "0x55C32E8")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x55C34AC", Offset = "0x55C34AC", VA = "0x55C34AC")]
	private void SetForce()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x55C3AF8", Offset = "0x55C3AF8", VA = "0x55C3AF8")]
	private Vector3 GetClosetLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x55C3CE4", Offset = "0x55C3CE4", VA = "0x55C3CE4")]
	private Vector3 GetParallelLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x55C3DAC", Offset = "0x55C3DAC", VA = "0x55C3DAC")]
	public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x55C3F30", Offset = "0x55C3F30", VA = "0x55C3F30")]
	private static Vector3 SetVectorLength(Vector3 vector, float size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x55C3BC0", Offset = "0x55C3BC0", VA = "0x55C3BC0")]
	private float HeightBias(float upRateOwnLoc, float centerRateOwnLoc)
	{
		return default(float);
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x55C3FC8", Offset = "0x55C3FC8", VA = "0x55C3FC8")]
	public RayfireVortex()
	{
	}
}
[Token(Token = "0x200006B")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1DE8F1C", Offset = "0x1DE8F1C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1DE8F1C", Offset = "0x1DE8F1C")]
public class RayfireWind : MonoBehaviour
{
	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1DE929C", Offset = "0x1DE929C")]
	private sealed class <WindForceCor>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireWind <>4__this;

		[Token(Token = "0x1700007F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x55C5550", Offset = "0x55C5550", VA = "0x55C5550", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x55C55B8", Offset = "0x55C55B8", VA = "0x55C55B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x55C4584", Offset = "0x55C4584", VA = "0x55C4584")]
		[DebuggerHidden]
		public <WindForceCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x55C5480", Offset = "0x55C5480", VA = "0x55C5480", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x55C5484", Offset = "0x55C5484", VA = "0x55C5484", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x55C5558", Offset = "0x55C5558", VA = "0x55C5558", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 gizmoSize;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool showGizmo;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float globalScale;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float lengthScale;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float widthScale;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float speed;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool showNoise;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float minimum;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float maximum;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float torque;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool forceByMass;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float divergency;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float turbulence;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float previewDensity;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float previewSize;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int mask;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string tagFilter;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform transForm;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Collider[] colliders;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 halfExtents;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 center;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float offset;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x55C4480", Offset = "0x55C4480", VA = "0x55C4480")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x55C4484", Offset = "0x55C4484", VA = "0x55C4484")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x55C4508", Offset = "0x55C4508", VA = "0x55C4508")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x1DEB3CC", Offset = "0x1DEB3CC")]
	private IEnumerator WindForceCor()
	{
		return null;
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x55C45B0", Offset = "0x55C45B0", VA = "0x55C45B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x55C45DC", Offset = "0x55C45DC", VA = "0x55C45DC")]
	private void Reset()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x55C45E8", Offset = "0x55C45E8", VA = "0x55C45E8")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x55C47D0", Offset = "0x55C47D0", VA = "0x55C47D0")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x55C488C", Offset = "0x55C488C", VA = "0x55C488C")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x55C4A50", Offset = "0x55C4A50", VA = "0x55C4A50")]
	private void SetForce()
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x55C4E24", Offset = "0x55C4E24", VA = "0x55C4E24")]
	private Vector3 GetVectorGlobal(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x55C4E84", Offset = "0x55C4E84", VA = "0x55C4E84")]
	public Vector3 GetVectorLocal(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x55C50C4", Offset = "0x55C50C4", VA = "0x55C50C4")]
	public Vector3 GetVectorLocalPreview(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x55C4D68", Offset = "0x55C4D68", VA = "0x55C4D68")]
	private float PerlinFixedGlobal(Vector3 worldPos)
	{
		return default(float);
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x55C5244", Offset = "0x55C5244", VA = "0x55C5244")]
	public float PerlinFixedLocal(Vector3 localPos)
	{
		return default(float);
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x55C5308", Offset = "0x55C5308", VA = "0x55C5308")]
	public float PerlinCustomGlobal(Vector3 worldPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x55C4FF8", Offset = "0x55C4FF8", VA = "0x55C4FF8")]
	public float PerlinCustomLocal(Vector3 localPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x55C4D9C", Offset = "0x55C4D9C", VA = "0x55C4D9C")]
	public float WindStrength(float val)
	{
		return default(float);
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x55C4D20", Offset = "0x55C4D20", VA = "0x55C4D20")]
	private void SetSpeed()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x55C5374", Offset = "0x55C5374", VA = "0x55C5374")]
	public RayfireWind()
	{
	}
}
